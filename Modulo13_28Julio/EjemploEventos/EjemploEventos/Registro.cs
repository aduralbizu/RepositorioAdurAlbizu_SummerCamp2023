namespace EjemploEventos
{
    internal class Registro
    {
        DateTime Date1;
        DateTime Date2;
        public Registro()
        {
            Date1 = DateTime.Now;
        }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {

            
            Date2 = DateTime.Now;
            
            TimeSpan interval = Date2 - Date1;
            
            if (interval.Seconds >= 10)
            {
                Console.WriteLine($"Hora actual (registro): {e.Hora.ToString()} "
                                            + $"{e.Minuto.ToString()} "
                                            + $"{e.Segundo.ToString()}  "
                                            + $"{DateTime.Now.Year.ToString()} "
                                            + $"{DateTime.Now.Month.ToString()} "
                                            + $"{DateTime.Now.Day.ToString()}");

                Date1 = Date2;

            }


        }

    }
}