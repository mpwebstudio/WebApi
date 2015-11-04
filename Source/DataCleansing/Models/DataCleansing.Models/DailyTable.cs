namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class DailyTable
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string IP { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string Host { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string APINumber { get; set; }
        public Nullable<int> Credits { get; set; }
    }
}
