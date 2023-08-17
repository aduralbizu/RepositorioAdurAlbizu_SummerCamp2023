using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;



namespace Models
{
    //[Table("Moneda")]
    public class Moneda
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(3)]
        [Required]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }


    }
}
