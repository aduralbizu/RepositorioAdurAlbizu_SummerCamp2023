namespace EjemploEventos
{
    public class Reloj
    {
        //Delegado:

        public delegate void CambioSegundoDelegado(object reloj, InformacionTiempoEventArgs informacionTiempo);
        //el metodo con su misma firma podra ser guardado en el delegado

        //Evento:

        public event CambioSegundoDelegado CambioSegundoEvento; //este es el evento

        public Reloj()
        {

        }

        public int segundo; //Segundo actual
        public void IniciaReloj()
        {
            DateTime fechaHoraActual;
            for ( ; ; )
            {
                Thread.Sleep( 100 ); //Para hacer una parada de 100 ms. Para comprobar en que momento cambia de segundo, para poder iniciar ell evento
                
                fechaHoraActual = DateTime.Now;

                //Antes pregunto:
                if (fechaHoraActual.Second!=segundo) //Ver si el segundo es diferente que el segundo lanzo el evento
                {
                   // Console.WriteLine(segundo); //No es la idea, el reloj no deberia tener interfaz. Solo para ver que el reloj funciona
                    //Guardad info tiempo
                    var informacionTiempo = new InformacionTiempoEventArgs(fechaHoraActual.Hour, fechaHoraActual.Minute, fechaHoraActual.Second);
                    //El cliente no sabe nada, sabe lo que le envía el evento


                    //Lanzar el evento
                    if (CambioSegundoEvento != null) //Entra solo si hay alguien a la escucha
                    {
                        CambioSegundoEvento(this, informacionTiempo); //Si no hay nadie escuchando, esto es nulo: Hay que definir el susvriptor

                    }//Arreglo con el if y compruebo si alguien ha añadido contenido personalizado (suscriptor se susvribe al evento)
                    //Si no tiene nada, incurriríamos en una excepcion. Con el if, si no hay nadie a la escucha no ocurre nada
                }

                segundo = fechaHoraActual.Second;
            }
        }
    }
}