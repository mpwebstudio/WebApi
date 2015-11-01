namespace DataCleansing.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using DataCleansing.Models;

    public interface IApplicationDbContext
    {
        IDbSet<BicCodeEurope> BicCodeEuropes { get; set; }

        IDbSet<BicEurope> BicEuropes { get; set; }
            
        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
