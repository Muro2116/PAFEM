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
        public int RegistroSala { get; private set; }
        public int NumeroSala { get; set; }
        public int Capacidade { get; set; }
        public string Localizacao { get; set; }
        #endregion

        #region Construtor
        public Sala(int registroSala, int numeroSala, int capacidade, string localizacao)
        {
            RegistroSala = registroSala;
            NumeroSala = numeroSala;
            Capacidade = capacidade;
            Localizacao = localizacao;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine("--- Dados da Sala ---");
            Console.WriteLine($"Registro da Sala: {RegistroSala}");
            Console.WriteLine($"Número da Sala: {NumeroSala}");
            Console.WriteLine($"Capacidade: {Capacidade} lugares");
            Console.WriteLine($"Localização: {Localizacao}");
            Console.WriteLine("---------------------");
        }
        #endregion

        #region Metodo AtualizarDados
        public void AtualizarDados(int novoNumeroSala, int novaCapacidade, string novaLocalizacao)
        {
            NumeroSala = novoNumeroSala;
            Capacidade = novaCapacidade;
            Localizacao = novaLocalizacao;
            Console.WriteLine("Dados da sala (Número, Capacidade, Localização) atualizados com sucesso!");
        }
        #endregion

        #region Metodo LimparDados
        public void LimparDados()
        {
            NumeroSala = 0;
            Capacidade = 0;
            Localizacao = string.Empty;
            Console.WriteLine("Dados da sala foram limpos/resetados (exceto RegistroSala).");
        }
        #endregion

        #endregion
    }
}