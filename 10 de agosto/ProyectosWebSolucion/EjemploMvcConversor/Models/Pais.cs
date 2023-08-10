using System.ComponentModel.DataAnnotations;

namespace EjemploMvcConversor.Models
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
