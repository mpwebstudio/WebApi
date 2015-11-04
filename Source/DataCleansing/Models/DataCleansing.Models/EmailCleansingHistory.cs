namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class EmailCleansingHistory
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> ValidEmail { get; set; }
        public Nullable<int> InvalidEmail { get; set; }
        public Nullable<int> SyntaxValid { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UserName { get; set; }
        public Nullable<DateTime> DateSubmited { get; set; }
        public Nullable<int> RecordsUploaded { get; set; }
    }
}
