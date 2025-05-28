using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Professor : Pessoa
    {
        #region Atributos
        public int Registro { get; private set; }
        public string Especializacao { get; set; }
        public decimal Salario { get; private set; }
        public DateTime DataContratacao { get; private set; }
        #endregion

        #region Construtor
        public Professor(int registro, string nome, string genero, string cpf, string rg, DateTime nascimento, string telefone, Endereco endereco,
                         string especializacao, decimal salario, DateTime dataContratacao)
            : base(nome, genero, cpf, rg, nascimento, telefone, endereco)
        {
            Registro = registro;
            Especializacao = especializacao;
            Salario = salario;
            DataContratacao = dataContratacao;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Registro Profissional: {Registro}");
            Console.WriteLine($"Especialização: {Especializacao}");
            Console.WriteLine($"Salário: R${Salario:F2}");
            Console.WriteLine($"Data de Contratação: {DataContratacao:dd/MM/yyyy}");
        }
        #endregion

        #region Metodo AtualizarDados
        public void AtualizarDados(string novoNome, string novoTelefone, Endereco novoEndereco, string novaEspecializacao, decimal novoSalario)
        {
            if (!string.IsNullOrWhiteSpace(novoNome))
                Nome = novoNome;
            if (!string.IsNullOrWhiteSpace(novoTelefone))
                Telefone = novoTelefone;
            if (novoEndereco != null)
                Endereco = novoEndereco;
            if (!string.IsNullOrWhiteSpace(novaEspecializacao))
                Especializacao = novaEspecializacao;
            Console.WriteLine("Dados do professor atualizados (Nome, Telefone, Endereço, Especialização). Salário é ajustado via ReajusteSalarial.");
        }
        #endregion

        #region Metodo DeletarDados
        public void DeletarDados()
        {
            Registro = 0;
            Especializacao = string.Empty;
            Salario = 0;
            DataContratacao = DateTime.MinValue;
            Console.WriteLine("Dados do professor foram resetados/limpos.");
        }
        #endregion

        #region Metodo AjusteSalarial
        public void ReajusteSalarial(decimal percentualAumento)
        {
            if (percentualAumento > 0)
            {
                Salario += Salario * (percentualAumento / 100);
                Console.WriteLine($"Salário reajustado para: R${Salario:F2}");
            }
            else
            {
                Console.WriteLine("Percentual de aumento inválido.");
            }
        }

        #endregion

        #region Metodo ExibirCurriculo
        public void ExibirCurriculo()
        {
            Console.WriteLine($"Currículo de {Nome}:");
            Console.WriteLine($"Especialização: {Especializacao}");
            Console.WriteLine($"Experiência (Data de Contratação): {DataContratacao:dd/MM/yyyy}");
            Console.WriteLine($"Tempo de Casa: {TempoDeCasa()} anos");
        }
        #endregion

        #region Metodo ExibirTempoDeCasa
        public int TempoDeCasa()
        {
            if (DataContratacao == DateTime.MinValue) return 0;
            DateTime hoje = DateTime.Today;
            int anos = hoje.Year - DataContratacao.Year;
            if (DataContratacao.Date > hoje.AddYears(-anos))
            {
                anos--;
            }
            return Math.Max(0, anos);
        }
        #endregion

        #endregion
    }
}