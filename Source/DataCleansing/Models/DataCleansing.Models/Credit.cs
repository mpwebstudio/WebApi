namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Credit
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UserName { get; set; }
        public Nullable<int> Credits { get; set; }
        public Nullable<DateTime> DatePurchase { get; set; }
        public Nullable<DateTime> DateExpire { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string ApiNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string Host { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string IP { get; set; }
    }
}
