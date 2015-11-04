namespace DataCleansing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(25)]
        public string SurName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string Telephone { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string WebPage { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string ApiNumber { get; set; }
        public Nullable<DateTime> DataRegister { get; set; }
    }
}
