
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace teste_API
{
    public class Buscador
    {
        static HttpClient client = new HttpClient();

        public static async Task<string> GetJsonAsync(string path)
        {
            client.BaseAddress = new Uri(path);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string json = "";
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Conexão com a api web bem sucedida!");
                json = await response.Content.ReadAsStringAsync();
                json = "{\"Cotacao\"" + json.Substring(9);

                return json;
            }
            return json;
        } 
    }
}