using PesquisaEndereco.Entities;
using PesquisaEndereco.Services;

namespace PesquisaEndereco
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Informe o cep:");
            string cep = Console.ReadLine();

            EnderecoServices services = new EnderecoServices();

            Endereco encontrado = await services.Integracao(cep);

            if (!encontrado.Verifica)
            {
                Console.WriteLine("Endereco Encontrado");
                Console.WriteLine(encontrado.ToString());
            }
            else
            {
                Console.WriteLine("Endereco NÃO Encontrado");
            }
        }
    }
}