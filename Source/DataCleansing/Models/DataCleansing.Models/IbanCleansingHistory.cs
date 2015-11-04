namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class IbanCleansingHistory
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> ValidRecords { get; set; }
        public Nullable<int> InvalidRecords { get; set; }
        public Nullable<int> SubmitedRecords { get; set; }
        public Nullable<DateTime> DateSubmited { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
