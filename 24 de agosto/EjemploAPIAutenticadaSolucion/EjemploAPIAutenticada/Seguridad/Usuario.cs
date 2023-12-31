﻿using Microsoft.AspNetCore.Identity;

namespace EjemploAPIAutenticada.Seguridad
{
    public class Usuario:IdentityUser //hemos creado nuevos usuarios basados en la clave base identity user
    {

        public int IdPais { get; set; }
        public DateTime FechaNacimiento { get; set; }


    }

    public class Pais
    {
        public int Id { get; set; }
        public string Name { get; set;}
    }

}
