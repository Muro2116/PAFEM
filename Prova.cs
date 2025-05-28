using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Prova
    {
        #region Atributos
        public string RegistroProva { get; private set; }
        public string Disciplina { get; private set; }
        public DateTime DataProva { get; private set; }
        public double Nota { get; private set; } 
        public bool NecessitaRecuperacao { get; set; }
        #endregion

        #region Construtor
        public Prova(string registroProva, string disciplina, DateTime dataProva, double nota, bool necessitaRecuperacao)
        {
            RegistroProva = registroProva;
            Disciplina = disciplina;
            DataProva = dataProva;
            Nota = nota;
            NecessitaRecuperacao = necessitaRecuperacao;
        }
        #endregion

        #region Metodos

        #region Método ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine("Registro da Prova: " + RegistroProva);
            Console.WriteLine("Disciplina: " + Disciplina);
            Console.WriteLine("Data da Prova: " + DataProva.ToString("dd/MM/yyyy"));
            Console.WriteLine("Nota: " + Nota);
            Console.WriteLine("Necessita Recuperação: " + (NecessitaRecuperacao ? "Sim" : "Não"));
        }
        #endregion

        #region Metood ValidarNota
        public bool ValidarNota()
{
            return Nota >= 0 && Nota <= 10;
        }
        #endregion

        #region Metodo GerarAgendamentoRecuperacao
        public Recuperacao? GerarAgendamentoRecuperacao(string registroAluno, DateTime dataAgendadaParaRecuperacao)
        {
            if (this.Nota < 7)
            {
                this.NecessitaRecuperacao = true;
                Recuperacao agendamento = new Recuperacao(
                    registroAluno: registroAluno,
                    aprovacaoProfessor: "Aguardando aprovação do professor",
                    disciplina: this.Disciplina,
                    dataRecuperacao: dataAgendadaParaRecuperacao,
                    registroProvaReferencia: this.RegistroProva
                );
                Console.WriteLine($"Aluno (RA: {registroAluno}) necessita de recuperação para a disciplina '{this.Disciplina}' (Prova: {this.RegistroProva}).");
                Console.WriteLine($"Agendamento de recuperação criado para {dataAgendadaParaRecuperacao:dd/MM/yyyy}.");
                return agendamento;
            }
            else
            {
                this.NecessitaRecuperacao = false;
                Console.WriteLine($"Aluno (RA: {registroAluno}) não necessita de recuperação para a disciplina '{this.Disciplina}' (Prova: {this.RegistroProva}). Nota: {this.Nota}");
                return null;
            }
        }
        #endregion

        #endregion
    }
}