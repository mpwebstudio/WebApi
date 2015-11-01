namespace DataCleansing.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class BicEurope
    {
        public double Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string BankCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string BranchCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(150)]
        public string BankName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(55)]
        public string BranchName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(80)]
        public string BranchAddress { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(140)]
        public string City { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(25)]
        public string Telephone { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(25)]
        public string Fax { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(23)]
        public string Country { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(2)]
        public string IsoCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(12)]
        public string Swift { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string Postcode { get; set; }
    }
}
