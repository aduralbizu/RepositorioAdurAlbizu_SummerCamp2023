using System.ComponentModel.DataAnnotations;

namespace Persistence.Entities
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [StringLength(25)]
        public string? Telefono { get; set; }



    }
}
