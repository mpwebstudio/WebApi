namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class TemporaryUser
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string ip { get; set; }
        public Nullable<short> credits { get; set; }
    }
}
