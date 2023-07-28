using System.Reflection.Metadata.Ecma335;

namespace EjemploEventos
{
    public class InformacionTiempoEventArgs
    {
        //Esto es un mero transportador
        public int Hora { get; set; }

        public int Minuto { get; set; }

        public int Segundo { get; set; }

        public InformacionTiempoEventArgs (int hora, int minuto, int segundo)
        {
            Hora = hora;
            Minuto = minuto;
            Segundo = segundo;
        }
    }
}