using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace DemoAsync2
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            /*
            string uri = "https://viacep.com.br/ws/92330220/json/";
            var resposta = await client.GetAsync(uri);
            Console.WriteLine(resposta.StatusCode);
            Console.WriteLine(resposta.IsSuccessStatusCode);
            Console.WriteLine(await resposta.Content.ReadAsStringAsync());
            */

            /*
            try{
                string uri = "https://viacep.com.br/ws/92330220/json/";
                var resposta = await client.GetStringAsync(uri);
                Console.WriteLine(resposta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            */

            try
            {
                string cep = "92330220";
                string uri = "https://viacep.com.br/ws/"+cep+"/json/";
                var resposta = await client.GetFromJsonAsync<ViaCep>(uri);
                Console.WriteLine(resposta.Logradouro);
            }
            catch (Exception ex)
            {               
                Console.WriteLine(ex.Message);
            }
               
           
        }
    }
}
