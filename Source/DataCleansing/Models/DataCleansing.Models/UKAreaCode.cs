namespace DataCleansing.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class UKAreaCode
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(6)]
        public string Code { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string AreaCovered { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string IsValid { get; set; }
    }
}
