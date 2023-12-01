using Newtonsoft.Json;
using PesquisaEndereco.Entities;

namespace PesquisaEndereco.Services
{
    internal class EnderecoServices
    {
        //buscar por cep
        public async Task<Endereco> Integracao(string cep)
        {
            HttpClient client = new HttpClient();//operação da api
            //getAsync -> vai receber o endereço da api e vai buscar os valores
            //a variavel response vai receber esses valores
            var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");//await aguardar a resposta do servidor
            var jsonString = await response.Content.ReadAsStringAsync();//vai transformar essa requisição(json) em string

            var jsonObject = JsonConvert.DeserializeObject<Endereco>(jsonString);//vai transformar em objeto

            if (jsonObject != null)
            {
                return jsonObject;
            }
            else
            {
                return new Endereco
                {
                    Verifica = true
                };
            }

        }
    }
}
