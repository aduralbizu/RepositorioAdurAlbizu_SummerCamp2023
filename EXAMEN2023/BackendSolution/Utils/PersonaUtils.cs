using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utils
{
    public class PersonaUtils
    {
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        public static bool EsTelefonoValido(string phoneNumber)
        {
            // Define una expresión regular para validar números de teléfono en formato "xxx-xxx-xxxx"
            string pattern = @"^\d{9}$";

            // Compara la cadena del número de teléfono con el patrón
            if (Regex.IsMatch(phoneNumber, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
            //return true;
        }
    }
}
