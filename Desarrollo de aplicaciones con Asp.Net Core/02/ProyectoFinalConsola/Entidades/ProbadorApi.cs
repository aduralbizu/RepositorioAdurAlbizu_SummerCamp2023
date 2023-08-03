using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProbadorApi
    {

        public ProbadorApi()
        {

        }

        public static async Task Run()
        {
            string apiUrl = "https://api.freecurrencyapi.com/v1/latest?apikey=fca_live_cV1mDh79gHYunHYxMEIeuL6CIINDyjmpDPXUvCBf"; // Reemplaza esto con la URL de la API que deseas consultar.

            string apiResponse = await ClienteAPI.GetApiResponse(apiUrl);

            if (apiResponse != null)
            {
                // Procesa la información de la respuesta de la API aquí.
                Console.WriteLine(apiResponse);
            }
        }

    }
}
