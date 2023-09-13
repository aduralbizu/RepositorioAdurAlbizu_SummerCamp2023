using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Se requiere el nombre")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se fecha de nacimiento")]
        public DateTime FechadeNacimiento { get; set; }
        [Required(ErrorMessage = "Se requiere el telefono")]
        [StringLength(25, ErrorMessage = "El nombre no puede tener más de 25 caracteres.")]
        public string Telefono { get; set; }

    }
}
