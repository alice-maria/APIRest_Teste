using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    internal class Endereco
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public int? Ibge { get; set; }
        public int? Gia { get; set; }
        public int? DDD { get; set; }
        public int? Siafi { get; set; }
        public bool Verifica = false;

        public override string ToString()
        {
            return "Logradouro: " + Logradouro + "\nNumero: " + "\nComplemento: " + Complemento + "\nBairro: " + Bairro +
                "\nCidade: " + Localidade + "\nUF: " + UF + "\nCEP: " + CEP + "\nCódigo IBGE: " + Ibge;
        }
    }
}
