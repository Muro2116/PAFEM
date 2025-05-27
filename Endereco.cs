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
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        #endregion

        #region Construtor
        public Endereco(string rua, string numero, string bairro, string cidade, string estado, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine($"Endereço: {rua}, {numero}, {bairro}, {cidade} - {estado}, CEP: {cep}");
        }
        #endregion

        #endregion
    }
}