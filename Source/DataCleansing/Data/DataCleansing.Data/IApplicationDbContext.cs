namespace DataCleansing.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using DataCleansing.Models;

    public interface IApplicationDbContext
    {
        IDbSet<Credit> Credits { get; set; }

        IDbSet<AddressCleansingHistory> AddressCleansingHistory { get; set; }

        IDbSet<BicCodeEurope> BicCodeEurope { get; set; }

        IDbSet<BicEurope> BicEurope { get; set; }

        IDbSet<BillingInformation> BillingInformation { get; set; }

        IDbSet<CardCleansingHistory> CardCleansingHistory { get; set; }

        IDbSet<DailyTable> DailyTable { get; set; }

        IDbSet<DeduplicateCleansingHistory> DeduplicateCleansingHistory { get; set; }

        IDbSet<Digit> Digit { get; set; }

        IDbSet<EmailCleansingHistory> EmailCleansingHistory { get; set; }

        IDbSet<History> History { get; set; }

        IDbSet<IbanCleansingHistory> IbanCleansingHistory { get; set; }

        IDbSet<Invoice> Invoice { get; set; }

        IDbSet<Messages> Messagess { get; set; }

        IDbSet<PhoneCleansingHistory> PhoneCleansingHistory { get; set; }

        IDbSet<Profile> Profile { get; set; }

        IDbSet<RawSortCode> RawSortCode { get; set; }

        IDbSet<Subscribe> Subscribe { get; set; }

        IDbSet<SwiftCode> SwiftCode { get; set; }

        IDbSet<TemporaryUser> TemporaryUser { get; set; }

        IDbSet<UKAreaCode> UKAreaCode { get; set; }

        IDbSet<UKSortCode> UKSortCode { get; set; }

        IDbSet<FullDetail> FullDetail { get; set; }

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
