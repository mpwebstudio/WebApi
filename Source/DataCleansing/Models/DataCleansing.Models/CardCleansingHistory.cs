namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class CardCleansingHistory
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> ValidCards { get; set; }
        public Nullable<int> InvalidCards { get; set; }
        public Nullable<int> RecordsUploaded { get; set; }
        public Nullable<System.DateTime> DateSubmited { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
