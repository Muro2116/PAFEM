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
        private int registro { get; set; }
        private string nome { get; set; }
        private decimal valor { get; set; }
        private DateTime dataInicio { get; set; }
        private DateTime dataFim { get; set; }
        #endregion

        #region Construtor
        public void Curso(int registro, string nome, decimal valor, DateTime dataInicio, DateTime dataFim)
        {
            this.registro = registro;
            this.nome = nome;
            this.valor = valor;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public override void ExibirDados()
        {
            Console.WriteLine($"Registro: {Registro}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Valor: R${Valor}");
            Console.WriteLine($"Data de Início: {DataInicio}");
            Console.WriteLine($"Data de Fim: {DataFim}");
        }
        #endregion

        #region Metodo AtualizarDados
        public void UpdateCurso(string nome, decimal valor, DateTime dataInicio, DateTime dataFim)
        {
            Nome = nome;
            Valor = valor;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
        #endregion

        #region Metodo ExcluirDados
        public void DeleteCurso()
        {
            Registro = 0;
            Nome = null;
            Valor = 0;
            DataInicio = DateTime.MinValue;
            DataFim = DateTime.MinValue;
        }
        #endregion

        #region Metodo AplicarDesconto
        public void AplicarDesconto(decimal porcentagem)
        {
            Valor -= Valor * (porcentagem / 100);
        }
        #endregion

        #region Metodo CalcularDuracao 
        public int CalcularDuracao()
        {
            return (DataFim - DataInicio).Days; // Retorna a duração em dias
        }
        #endregion

        #endregion
    }
}