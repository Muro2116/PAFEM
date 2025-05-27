using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Sala
    {
        #region Atributos
        private int registroSala { get; set; }
        private int numeroSala { get; set; }
        private int capacidade { get; set; }
        private string localizacao { get; set; }
        #endregion

        #region Construtor
        public Sala(int registroSala, int numeroSala, int capacidade, string localizacao)
        {
            this.RegistroSala = registroSala;
            this.NumeroSala = numeroSala;
            this.Capacidade = capacidade;
            this.Localizacao = localizacao;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine($"Registro da Sala: {RegistroSala}");
            Console.WriteLine($"Número da Sala: {NumeroSala}");
            Console.WriteLine($"Capacidade: {Capacidade}");
            Console.WriteLine($"Localização: {Localizacao}");
        }
        #endregion

        #region Metodo AtualizarDados
        public void AtualizarDados(int registroSala, int numeroSala, int capacidade, string localizacao)
        {
            RegistroSala = registroSala;
            NumeroSala = numeroSala;
            Capacidade = capacidade;
            Localizacao = localizacao;
            Console.WriteLine("Dados da sala atualizados com sucesso!");
        }
        #endregion

        #region Metodo ExcluirDados
        public void ExcluirDados()
        {
            RegistroSala = 0;
            NumeroSala = 0;
            Capacidade = 0;
            Localizacao = null;
            Console.WriteLine("Sala excluída com sucesso!");
        }
        #endregion

        #endregion
    }
}