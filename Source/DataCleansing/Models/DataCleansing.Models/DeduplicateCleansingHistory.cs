namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class DeduplicateCleansingHistory
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> UniqueRecords { get; set; }
        public Nullable<int> DuplicateRecords { get; set; }
        public Nullable<int> SubmitedRecords { get; set; }
        public Nullable<System.DateTime> DateSubmited { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
