namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class RawSortCode
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string SortCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(450)]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string BankName { get; set; }
    }
}
