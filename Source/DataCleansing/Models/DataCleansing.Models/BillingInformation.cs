namespace DataCleansing.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class BillingInformation
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Company { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Address2 { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string City { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string PostCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(25)]
        public string Country { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string CompanyNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string VATNumber { get; set; }
    }
}
