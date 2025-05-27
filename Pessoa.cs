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
        protected required string nome { get; set; }
        protected required string genero { get; set; }
        protected required string cpf { get; set; }
        protected required string rg { get; set; }
        protected required DateTime nascimento { get; set; }
        protected required string telefone { get; set; }
        #endregion

        #region Construtor
        public Pessoa(string nome, string genero, string cpf, string rg, DateTime nascimento, string telefone)
        {
            this.nome = nome;
            this.genero = genero;
            this.cpf = cpf;
            this.rg = rg;
            this.nascimento = nascimento;
            this.telefone = telefone;
        }
        #endregion

        #region Metodos

        #region Método para validar CPF
        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
                return false;

            for (int digito = 0; digito < 2; digito++)
            {
                int soma = 0;
                int peso = 10 + digito;

                for (int i = 0; i < 9 + digito; i++)
                {
                    soma += (cpf[i] - '0') * (peso - i);
                }

                int resultado = soma % 11;

                int verificador = resultado < 2 ? 0 : 11 - resultado;

                if ((cpf[9 + digito] - '0') != verificador)
                    return false;
            }
            return true;
        }
        #endregion

        #region Método exibir dados
        public virtual void ExibirDados()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Gênero: {genero}")
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"RG: {rg}");
            Console.WriteLine($"Data de Nascimento: {nascimento:dd/MM/yyyy}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine("------------------------------------");
        }
        #endregion

        #endregion
    }
}