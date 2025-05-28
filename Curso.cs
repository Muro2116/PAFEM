using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Curso
    {
        #region Atributos
        public int Registro { get; private set; } 
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        #endregion

        #region Construtor
        public Curso(int registro, string nome, decimal valor, DateTime dataInicio, DateTime dataFim)
        {
            Registro = registro;
            Nome = nome;
            Valor = valor;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine("--- Detalhes do Curso ---");
            Console.WriteLine($"Registro: {Registro}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Valor: R${Valor:F2}"); // F2 para formatar como moeda
            Console.WriteLine($"Data de Início: {DataInicio:dd/MM/yyyy}");
            Console.WriteLine($"Data de Fim: {DataFim:dd/MM/yyyy}");
            Console.WriteLine($"Duração Estimada: {CalcularDuracaoEmDias()} dias");

        }
        #endregion

        #region Metodo AtualizarDados
        public void AtualizarDados(string novoNome, decimal novoValor, DateTime novaDataInicio, DateTime novaDataFim)
        {
            if (!string.IsNullOrWhiteSpace(novoNome))
                Nome = novoNome;
            if (novoValor >= 0)
                Valor = novoValor;
            DataInicio = novaDataInicio;
            DataFim = novaDataFim;
            
            Console.WriteLine($"Dados do curso '{Nome}' (Registro: {Registro}) atualizados.");
        }
        #endregion

        #region Metodo LimparDadosCurso
        public void LimparDadosCurso()
        {
            Nome = string.Empty;
            Valor = 0;
            DataInicio = DateTime.MinValue;
            DataFim = DateTime.MinValue;
            Console.WriteLine($"Dados do curso (Registro: {Registro}) foram limpos/resetados.");
        }
        #endregion

        #region Metodo AplicarDesconto
        public void AplicarDesconto(decimal percentualDesconto)
        {
            if (percentualDesconto > 0 && percentualDesconto <= 100)
            {
                Valor -= Valor * (percentualDesconto / 100);
                Console.WriteLine($"Desconto de {percentualDesconto}% aplicado. Novo valor do curso '{Nome}': R${Valor:F2}");
            }
            else
            {
                Console.WriteLine("Percentual de desconto inválido. Deve ser entre 0 e 100.");
            }
        }
        #endregion

        #region Metodo CalcularDuracaoEmDias 
        public int CalcularDuracaoEmDias()
        {
            if (DataFim >= DataInicio)
            {
                return (DataFim - DataInicio).Days;
            }
            return 0;
            
        }
        #endregion

        #endregion
    }
}