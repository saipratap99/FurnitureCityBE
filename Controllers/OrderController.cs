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
    public async Task<ActionResult<List<Order>>> Index()
    {
        return Ok(await _repository.GetAll());
    }
    
    [HttpPost]
    [Route("[Action]")]
    public async Task<ActionResult<Order>> Create(List<OrderItemRequest> items)
    {
        // creates order
        // creates order items
        // creates invoice
        // creates shipment
        var userId = new Guid("cf7cc03c-172f-4b11-882d-e463796a1a40");
        var orderId = new Guid();
        _repository.Add(new Order{UserId = userId, Status = OrderStatus.PLACED.ToString(), Id = orderId});
        var orderItemsToAdd = new List<OrderItem>();
        var productIds = new List<Guid>();
        foreach (var item in items)
        {
            productIds.Add(item.ProductId);
            orderItemsToAdd.Add(new OrderItem {OrderId = orderId, ProductId = item.ProductId, Quantity = item.Quantity});
        }
        _repositoryShipment.Add(new ShipmentStatus(){OrderId = orderId, Status = ShippmentStatus.YET_TO_DISPATCH.ToString(), Id = orderId});
        
        // Fetch product details from the database
        var productsOrdered = await _dbContext.Products
            .Where(product => productIds.Contains(product.Id))
            .ToListAsync();

        
        // Calculate the net amount
        decimal netAmount = 0;
        foreach (var orderItem in orderItemsToAdd)
        {
            var product = productsOrdered.FirstOrDefault(p => p.Id == orderItem.ProductId);
            if (product == null)
            {
                return BadRequest($"Product with ID {orderItem.ProductId} not found.");
            }
        
            if (!product.IsActive || product.Quantity < orderItem.Quantity)
            {
                return BadRequest($"Product {product.Name} is not available in the required quantity.");
            }

            // Deduct the quantity from the product's stock
            product.Quantity -= orderItem.Quantity;

            // Calculate the total price for this product
            netAmount += product.Price * orderItem.Quantity;
        }

        // Calculate tax and total amounts
        const decimal taxPercentage = 18m;
        decimal taxAmount = Math.Round((netAmount * taxPercentage) / 100, 2);
        decimal totalAmount = netAmount + taxAmount;

        // Generate a new invoice
        var invoice = new Invoice
        {
            Id = Guid.NewGuid(),
            Date = DateTime.UtcNow,
            InvoiceNumber = $"INV-{DateTime.UtcNow.Ticks}",
            NetAmount = netAmount,
            TaxAmount = taxAmount,
            TotalAmount = totalAmount,
            OrderId = orderId
        };

        // Add the invoice to the database
        _dbContext.Invoices.Add(invoice);
        _dbContext.OrderItems.AddRange(orderItemsToAdd);
        await _dbContext.SaveChangesAsync();

        return Ok(orderId);
    }

}
