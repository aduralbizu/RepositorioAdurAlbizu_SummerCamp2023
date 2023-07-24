using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    public class ErrorBaseDatosExcepcion:Exception
    {
        public string Mensaje { get; }
        public DateTime FechaHoraExcepcion { get; set; }
        public ErrorBaseDatosExcepcion(string mensaje, DateTime fechaHoraExcepcion):base(mensaje) //se ejecuta la esxcepcion
        {
            Mensaje = mensaje;
            FechaHoraExcepcion = fechaHoraExcepcion;
        }
        
    }
}
