namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Crear instancia del reloj interno (publicador). No tiene interfaz de usuario ni nada
            var reloj = new Reloj();


            //2-Crear un reloj digital y nos suscribimos (suscriptor)
            var relojDigital = new RelojDigital();
            relojDigital.Suscribir(reloj); //Me suscribo al evento que me interesa del reloj


            //Ejercicio:
            //Crear un log o registro que guarde (muestre por pantalla)cada 10 s la fecha
            //(sistema) y hora (fecha se la da datetime y hora el reloj digital)
           
            var log = new Registro();
            log.Suscribir(reloj);

            //3-Poner en marcha el reloj. EL publicador se pone en marcha
            reloj.IniciaReloj();
        }
    }
}