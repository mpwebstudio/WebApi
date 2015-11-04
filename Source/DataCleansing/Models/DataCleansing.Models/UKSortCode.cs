namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class UKSortCode
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(2)]
        public string BankCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(6)]
        public string BranchCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(62)]
        public string BankName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(85)]
        public string BranchName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(82)]
        public string BranchAddress { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(28)]
        public string City { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(27)]
        public string Telephone { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(21)]
        public string Fax { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(14)]
        public string Country { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(2)]
        public string IsoCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string Swift { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(8)]
        public string PostCode { get; set; }
    }
}
