using Microsoft.EntityFrameworkCore;

namespace Reports.Storage.DataBase
{
    public interface IDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}
