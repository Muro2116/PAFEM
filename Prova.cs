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
        private required string registroProva { get; set; }
        private required string disciplina { get; set; }
        private required DateTime dataProva { get; set; }
        private required double nota { get; set; }
        private bool necessitaRecuperacao { get; set; }
        #endregion

        #region Construtor
        public Prova(string registroProva, string disciplina, DateTime dataProva, double nota, bool ncessitaRecuperacao)
        {
            this.registroProva = registroProva;
            this.disciplina = disciplina;
            this.dataProva = dataProva;
            this.nota = nota;
            this.ncessitaRecuperacao = false;
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
            Console.WriteLine("Recuperação: " + (Recuperacao ? "Sim" : "Não"));
        }
        #endregion

        #region Metood ValidarNota
        public bool ValidarNota()
        {
            return Nota >= 0 && Nota <= 10;
        }
        #endregion

        #region Metodo VerificarRecuperacao
        public Recuperacao? GerarAgendamentoRecuperacao(string registroAluno, DateTime dataAgendadaParaRecuperacao)
        {
            if (this.Nota < 7)
            {
                this.necessitaRecuperacao = true;
                Recuperacao agendamento = new Recuperacao
                (
                    aprovacaoProfessor: "Aguardando aprovação do professor",
                    disciplina: this.Disciplina,
                    dataRecuperacao: dataAgendadaParaRecuperacao,
                    registroProva: this.RegistroProva
                );
                Console.WriteLine($"Aluno (RA: {registroAluno}) necessita de recuperação para a disciplina '{this.Disciplina}' (Prova: {this.RegistroProva}).");
                Console.WriteLine($"Agendamento de recuperação criado para {dataAgendadaParaRecuperacao:dd/MM/yyyy}.");
                return agendamento;
            }
            else
            {
                this.necessitaRecuperacao = false;
                Console.WriteLine($"Aluno (RA: {registroAluno}) não necessita de recuperação para a disciplina '{this.Disciplina}' (Prova: {this.RegistroProva}).");
                return null;
            }
        }
        #endregion

        #endregion
    }
}