using EjemploDelegados.Medios;
using static EjemploDelegados.InventarioMedios;

namespace EjemploDelegados
{
    //Hay que crear una aplicación 
    //para el servicio de medios de una biblio publica
    //de modo que:
    //1a- Segun el tipo de medio indique al ususario los pasos a dar 
    //para reproducir ese medio y verificar si está en buen estado
    //para archivarlo o bien desecharlo si está en mal estado
    //2b-Crear una  apliacacion que permita indicar los pasos a dar independientemente del medio
    //la he llamado inventariomeios
    //3c - Mostrar el contenido segun el tipo de medio:
    //      Cds - Mostrar lista d canciones
    //      Vinilo - Mostarr lista de canciones en contraportada
    //      VHS - Mostrar info de  la peli
    // Para ello hace falta pasar codigo de barraas o identificador pàra localizar el medio en la BBDD(base de datos simujlada)


    internal class Program
    {
        static void Main(string[] args)
        {
            //++1-Crear instancias

            //Crear la instancia del inventario de medios
            var inventarioMedios = new InventarioMedios();

            var reproductorCassette = new ReproductorCassette();

            var tocaDiscos = new Tocadiscos();

            var videoVhs = new VideoVhs();

            //++2- Crear instancias delegado
            ProbarMediosDelegado probarDiscosDelegado = new ProbarMediosDelegado(tocaDiscos.ProbarVinilo); //Recibe como parametro puntero a un metodo
            ProbarMediosDelegado probarCintasVhsDelegado = new ProbarMediosDelegado(videoVhs.ProbarVhs); //Recibe como parametro puntero a un metodo
                                                                                    //si te pones aquí ves _ptr, el puntero del metodo
            //Estoy pasando un método pero no se está ejecutando
            //++ 3-Utilizar delegados

            //probar un vinilo

            inventarioMedios.ResultadoProbarMedios(probarDiscosDelegado);

            //Probar VHS:

            inventarioMedios.ResultadoProbarMedios(probarCintasVhsDelegado);

            //++Continuaciçon del ejercicio

            string CodigoBarras = "2132902ddwd123e";

            InfoMedioDelegado InfoDiscoDelegado = new InfoMedioDelegado(tocaDiscos.ObtenerCancionesDisco(CodigoBarras)); //Recibe como parametro puntero a un metodo
            InfoMedioDelegado InfoCintaVhsDelegado = new InfoMedioDelegado(videoVhs. ObtenerinfoPeli); //

        }
    }
}