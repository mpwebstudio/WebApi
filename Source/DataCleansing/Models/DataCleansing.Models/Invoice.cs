namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> InvoiceNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column(TypeName = "MONEY")]
        public Nullable<decimal> Amount { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string PaymentType { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public Nullable<int> CreditsPurchase { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string AccessType { get; set; }
        public Nullable<int> ProfileId { get; set; }
    }
}
