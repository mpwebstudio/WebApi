namespace DataCleansing.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Digit
     {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        [Column(TypeName = "VARCHAR")]
        public string CompanyName { get; set; }
        [MaxLength(30)]
        [Column(TypeName = "VARCHAR")]
        public string CompanyNumber { get; set; }
    }
}
