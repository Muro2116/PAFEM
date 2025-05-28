using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public abstract class Pessoa
    {
        #region Atributos
        protected string Nome { get; set; }
        protected string Genero { get; set; }
        protected string Cpf { get; set; }
        protected string Rg { get; set; }
        protected DateTime Nascimento { get; set; }
        protected string Telefone { get; set; }
        protected Endereco Endereco { get; set; }
        #endregion

        #region Construtor
        protected Pessoa(string nome, string genero, string cpf, string rg, DateTime nascimento, string telefone, Endereco endereco)
        {
            Nome = nome;
            Genero = genero;
            Cpf = cpf;
            Rg = rg;
            Nascimento = nascimento;
            Telefone = telefone;
            Endereco = endereco;
        }
        #endregion

        #region Metodos

        #region Método para validar CPF
        public static bool ValidarCPF(string cpfParaValidar)
        {
            string cpfLimpo = cpfParaValidar.Replace(".", "").Replace("-", "");

            if (cpfLimpo.Length != 11 || cpfLimpo.Distinct().Count() == 1)
                return false;

            for (int digitoIdx = 0; digitoIdx < 2; digitoIdx++)
            {
                int soma = 0;
                int pesoInicial = 10 + digitoIdx;

                for (int i = 0; i < 9 + digitoIdx; i++)
                {
                    soma += (cpfLimpo[i] - '0') * (pesoInicial - i);
                }

                int resultado = soma % 11;

                int digitoVerificadorCalculado = resultado < 2 ? 0 : 11 - resultado;

                if ((cpfLimpo[9 + digitoIdx] - '0') != digitoVerificadorCalculado)
                    return false;
            }
            return true;
        }
        #endregion

        #region Método exibir dados
        public virtual void ExibirDados()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"RG: {Rg}");
            Console.WriteLine($"Data de Nascimento: {Nascimento:dd/MM/yyyy}");
            Console.WriteLine($"Telefone: {Telefone}");
            if (Endereco != null)
            {
                Console.Write("Endereço: ");
                Endereco.ExibirDados();
            }
            else
            {
                Console.WriteLine("Endereço: Não informado");
            }
            Console.WriteLine("------------------------------------");
        }
        #endregion

        #endregion
    }
}