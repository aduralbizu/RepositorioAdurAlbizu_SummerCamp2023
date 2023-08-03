using Movies.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Client.Services
{


    //Tarea:

    //1- Crear clase para la respuesta (coger json pegar como clase y ya lo tenemos
    //2- Crear http client
    //3- Establecer ruta base por ejempllo http://www.boredapi.com
    //4- get asinc("api/activity")
    //5- Deserializar

    //Hemos hecho cambios sobre el documento


    public class CRUDService : IIntegrationService
    {

        public static HttpClient _HttpClient = new HttpClient(); //Hemos creado el cliente
        public CRUDService()
        {
            _HttpClient.BaseAddress = new Uri("http://www.boredapi.com");
            
        }
        public async Task Run()
        {

            await EjemploGet();
        
        }

        private async Task EjemploGet() //Hemos editado para el ejercicio
        {
            var response = await _HttpClient.GetAsync("api/activity?"); //une _HttpClient.BaseAddress + "api/movies"

            response.EnsureSuccessStatusCode(); //Obligatoria experar a que todo vaya bien sin expecion

            var content = await response.Content.ReadAsStringAsync(); //Leer

            var activity = new Activity(); //Hacer la lista
            activity = JsonConvert.DeserializeObject<Activity>(content); //Desserializar

            Console.WriteLine("Lectura del JSON completada. JSON extraído:");
            Console.WriteLine("{");
            Console.WriteLine($"Activity: {activity.activity}");
            Console.WriteLine($"Type: {activity.type}");
            Console.WriteLine($"Participants: {activity.participants}");
            Console.WriteLine($"Price: {activity.price}");
            Console.WriteLine($"Link: {activity.link}");
            Console.WriteLine($"Key: {activity.key}");
            Console.WriteLine($"Accessibility: {activity.accessibility}");
            Console.WriteLine("}");


            
        }
    }
}
