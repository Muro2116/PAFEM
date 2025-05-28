using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Endereco
    {
        #region Atributos
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        #endregion

        #region Construtor
        public Endereco(string rua, string numero, string bairro, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine($"Endereço: {Rua}, {Numero}, {Bairro}, {Cidade} - {Estado}, CEP: {Cep}");
        }
        #endregion

        #endregion
    }
}