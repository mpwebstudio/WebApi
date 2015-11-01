namespace DataCleansing.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class BicCodeEurope
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string BankCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string BankOrInstitution { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string City { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Country { get; set; }
    }
}
