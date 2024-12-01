using System.Linq.Expressions;
using FurnitureCityBE.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureCityBE.Repositories;

public class GenericRepository<T>: IGenericRepository<T> where T : class
{
    private readonly FurnitureStoreDb _db;
    public GenericRepository(FurnitureStoreDb context)
    {
        _db = context;
    }
    
    public void Add(T entity)
    {
        _db.Set<T>().Add(entity);
    }

    public async void Del(Guid id)
    {
        var q = await GetById(id);
        _db.Set<T>().Remove(q);
    }

    public async void Edit(T entity)
    {
        _db.Entry<T>(entity).State = EntityState.Modified;
    }

    public async Task<List<T>> GetAll()
    {
        return await _db.Set<T>().Select(a=>a).ToListAsync();
    }

    public async Task<T?> GetById(Guid id)
    {
        return await _db.Set<T>().FindAsync(id);
    }
    public async Task<Invoice?> GetInvoiceByOrderId(Guid orderId)
    {
        return await _db.Set<Invoice>().FirstOrDefaultAsync(invoice => invoice.OrderId == orderId);
    }

    public async Task<List<Order>> GetOrderByUserId(Guid userId)
    {
        return await _db.Set <Order>().Where(order => order.UserId == userId).ToListAsync();
    }

    public async Task<int> Savechange()
    {
        return await _db.SaveChangesAsync();
    }
    public async Task<T?> Find(Expression<Func<T, bool>> predicate)
    {
        return await _db.Set<T>().FirstOrDefaultAsync(predicate);
    }
}
