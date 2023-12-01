using Newtonsoft.Json;

namespace Teste2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Digite seu CEP: ");
            string cep = Console.ReadLine();

            cep.Replace("-", null).Trim();

            // envia solicitações HTTP e recebe respostas HTTP de um recurso identificado por um URI
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://viacep.com.br/ws/") };
            var response = await client.GetAsync($"{cep}/json");//response vai ser minha resposta em forma de json, metodo get do http -> buscar infos
            var content = await response.Content.ReadAsStringAsync();

            var user = JsonConvert.DeserializeObject<Endereco>(content);
            Console.WriteLine(user.ToString());
        }
    }
}