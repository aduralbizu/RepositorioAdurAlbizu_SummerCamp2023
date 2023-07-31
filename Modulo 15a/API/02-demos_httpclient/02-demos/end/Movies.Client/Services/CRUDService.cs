using Movies.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Client.Services
{
    public class CRUDService : IIntegrationService
    {

        public static HttpClient _HttpClient = new HttpClient(); //Hemos creado el cliente
        public CRUDService()
        {
            _HttpClient.BaseAddress = new Uri("http://localhost:57863");
            
        }
        public async Task Run()
        {

            await EjemploGet();
        
        }

        private async Task EjemploGet()
        {
            var response = await _HttpClient.GetAsync("api/movies"); //une _HttpClient.BaseAddress + "api/movies"

            response.EnsureSuccessStatusCode(); //Obligatoria experar a que todo vaya bien sin expecion

            var content = await response.Content.ReadAsStringAsync(); //Leer

            var movies = new List<Movie>(); //Hacer la lista
            movies = JsonConvert.DeserializeObject<List<Movie>>(content); //Desserializar
        }
    }
}
