using FurnitureCityBE.Models;
using FurnitureCityBE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class OrderController(FurnitureStoreDb dbContext) : ControllerBase
{
    private readonly FurnitureStoreDb _dbContext = dbContext;
    private readonly GenericRepository<Order> _repository = new(dbContext);
    private readonly GenericRepository<OrderItem> _repositoryOrderItem = new(dbContext);
    private readonly GenericRepository<ShipmentStatus> _repositoryShipment = new(dbContext);


    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Order>>> Index([FromQuery] Guid? userId = null)
    {
        try
        {
            // Query the orders, optionally filter by userId
            var query = _dbContext.Orders
                .Include(o => o.User)
                .Include(o => o.ShipmentStatuses)
                .Include(o => o.Invoice)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)

                .AsQueryable();

            if (userId.HasValue)
            {
                query = query.Where(o => o.UserId == userId.Value);
            }

            var orders = await query.Select(o => new OrderDetailsDTO
            {
                OrderId = o.Id,
                User = new UserDTO
                {
                    UserId = o.User.Id,
                    UserName = o.User.Name,
                    Email = o.User.Email,
                    Date = o.Invoice.Date,
                },
                ShipmentStatus = o.ShipmentStatuses.Select(o => o.Status).FirstOrDefault(),
                InvoiceDetails = new InvoiceDTO
                {
                    InvoiceId = o.Invoice.Id,
                    InvoiceNumber = o.Invoice.InvoiceNumber,
                    TotalAmount = o.Invoice.TotalAmount,
                    TaxAmount = o.Invoice.TaxAmount,
                    NetAmount = o.Invoice.NetAmount,
                },
                OrderItems = o.OrderItems.Select(oi => new OrderItemDTO
                {
                    ProductId = oi.Product.Id,
                    ProductName = oi.Product.Name,
                    Quantity = oi.Quantity,
                    Price = oi.Product.Price,
                }).ToList()
            }).ToListAsync();

            return Ok(orders);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "An error occurred while fetching order details.", error = ex.Message });
        }
    }

    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<Order>> Create(List<OrderItemRequest> items)
    {
        if (items == null || items.Count == 0)
            return BadRequest("No items provided.");

        var userId = items[0].userId;
        var orderId = Guid.NewGuid();

        // Create a new order
        var order = new Order
        {
            Id = orderId,
            OrderId = "order",
            UserId = userId,
            Status = OrderStatus.PLACED.ToString()
        };

        // Add the order to the database
        _dbContext.Orders.Add(order);
        await _dbContext.SaveChangesAsync(); // Ensure the order is saved and the ID is available for foreign key references

        // Prepare order items
        var orderItemsToAdd = new List<OrderItem>();
        var productIds = items.Select(i => i.ProductId).ToList();

        // Fetch product details
        var productsOrdered = await _dbContext.Products
            .Where(product => productIds.Contains(product.Id))
            .ToListAsync();

        decimal netAmount = 0;

        foreach (var item in items)
        {
            var product = productsOrdered.FirstOrDefault(p => p.Id == item.ProductId);
            if (product == null)
                return BadRequest($"Product with ID {item.ProductId} not found.");

            if (!product.IsActive || product.Quantity < item.Quantity)
                return BadRequest($"Product {product.Name} is not available in the required quantity.");

            // Deduct stock
            product.Quantity -= item.Quantity;

            // Calculate net amount
            netAmount += product.Price * item.Quantity;

            // Create order item

            orderItemsToAdd.Add(new OrderItem
            {
                OrderId = orderId,
                ProductId = item.ProductId,
                Quantity = item.Quantity
            });

        }


        // Add order items
        _dbContext.OrderItems.AddRange(orderItemsToAdd);

        // Calculate tax and total amount
        const decimal taxPercentage = 18m;
        decimal taxAmount = Math.Round((netAmount * taxPercentage) / 100, 2);
        decimal totalAmount = netAmount + taxAmount;

        // Create invoice
        var invoice = new Invoice
        {
            Id = Guid.NewGuid(),
            Date = DateTime.UtcNow,
            InvoiceNumber = $"INV-{DateTime.UtcNow.Ticks}",
            NetAmount = netAmount,
            TaxAmount = taxAmount,
            TotalAmount = totalAmount,
            OrderId = orderId // Foreign key reference to the saved order
        };

        // Add the invoice to the database
        _dbContext.Invoices.Add(invoice);

        // Add shipment status
        var shipmentStatus = new ShipmentStatus
        {
            Id = Guid.NewGuid(),
            OrderId = orderId,
            Status = ShippmentStatus.YET_TO_DISPATCH.ToString()
        };
        _dbContext.ShipmentStatuses.Add(shipmentStatus);

        // Save all changes
        await _dbContext.SaveChangesAsync();

        return Ok(orderId);


    }
}
