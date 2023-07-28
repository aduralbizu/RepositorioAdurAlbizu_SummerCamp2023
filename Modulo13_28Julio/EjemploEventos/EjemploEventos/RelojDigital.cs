namespace EjemploEventos
{
    public class RelojDigital
    {
        public RelojDigital()
        {
        }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
                //Al codigo que ya existiera en este evento, le sumo. Ek event handler es llamado
                //to attach an event handler to the event
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
            Console.WriteLine($"Hora actual: {e.Hora.ToString()} "
                                                + $"{e.Minuto.ToString()} "
                                                + $"{e.Segundo.ToString()}");
        }
    }
}