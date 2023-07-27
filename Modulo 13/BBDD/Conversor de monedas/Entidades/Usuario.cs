using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        //Esto en realidad será automáico

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public int PaisId { get; set; }
    }
}