namespace DataCleansing.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using DataCleansing.Models;


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public IDbSet<Credit> Credits { get; set; }

        public IDbSet<AddressCleansingHistory> AddressCleansingHistory { get; set; }

        public IDbSet<BicCodeEurope> BicCodeEurope { get; set; }

        public IDbSet<BicEurope> BicEurope { get; set; }

        public IDbSet<BillingInformation> BillingInformation { get; set; }

        public IDbSet<CardCleansingHistory> CardCleansingHistory { get; set; }

        public IDbSet<DailyTable> DailyTable { get; set; }

        public IDbSet<DeduplicateCleansingHistory> DeduplicateCleansingHistory { get; set; }

        public IDbSet<Digit> Digit { get; set; }

        public IDbSet<EmailCleansingHistory> EmailCleansingHistory { get; set; }

        public IDbSet<History> History { get; set; }

        public IDbSet<IbanCleansingHistory> IbanCleansingHistory { get; set; }

        public IDbSet<Invoice> Invoice { get; set; }

        public IDbSet<Messages> Messagess { get; set; }

        public IDbSet<PhoneCleansingHistory> PhoneCleansingHistory { get; set; }

        public IDbSet<Profile> Profile { get; set; }

        public IDbSet<RawSortCode> RawSortCode { get; set; }

        public IDbSet<Subscribe> Subscribe { get; set; }

        public IDbSet<SwiftCode> SwiftCode { get; set; }

        public IDbSet<TemporaryUser> TemporaryUser { get; set; }

        public IDbSet<UKAreaCode> UKAreaCode { get; set; }

        public IDbSet<UKSortCode> UKSortCode { get; set; }

        public IDbSet<FullDetail> FullDetail { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
