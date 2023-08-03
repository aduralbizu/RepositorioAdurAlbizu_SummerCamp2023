
namespace Entidades
{
    public static class ClienteAPI
    {
   

        public static async Task<string> GetApiResponse(string apiUrl)
        {

            HttpClient _httpClient = new HttpClient();
            using (HttpClient client = _httpClient)
            {
                try
                {

                    HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode(); // Lanza una excepción si la respuesta es un error (por ejemplo, código 404).

                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                catch (HttpRequestException ex)
                {
                    // Manejo de errores en caso de que haya un problema con la solicitud.
                    Console.WriteLine($"Error de solicitud HTTP: {ex.Message}");
                    return null;
                }


            }
          
        }

    }
}
