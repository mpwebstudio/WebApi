namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AddressCleansingHistory
    {
        [Key]
        public int Id { get; set; }

        public int RecordsUploaded { get; set; }

        public int AddressCorrected { get; set; }

        public int AddressNotFound { get; set; }

        public DateTime DateSubmited { get; set; }
        
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
