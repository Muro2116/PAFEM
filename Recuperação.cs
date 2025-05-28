using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Recuperacao
    {
        #region Atributos
        public string RegistroAluno { get; set; }
        public string AprovacaoProfessor { get; set; }
        public string Disciplina { get; set; }
        public DateTime DataRecuperacao { get; set; }
        public string RegistroProvaReferencia { get; set; }
        #endregion

        #region Construtor
        public Recuperacao(string registroAluno, string aprovacaoProfessor, string disciplina, DateTime dataRecuperacao, string registroProvaReferencia)
        {
            RegistroAluno = registroAluno;
            AprovacaoProfessor = aprovacaoProfessor;
            Disciplina = disciplina;
            DataRecuperacao = dataRecuperacao;
            RegistroProvaReferencia = registroProvaReferencia;
        }
        #endregion

        #region Metodos

        #region Método ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine("--- Detalhes da Recuperação ---");
            Console.WriteLine($"Aluno (RA): {RegistroAluno}");
            Console.WriteLine($"Status Aprovação Professor: {AprovacaoProfessor}");
            Console.WriteLine($"Disciplina: {Disciplina}");
            Console.WriteLine($"Data da Recuperação: {DataRecuperacao:dd/MM/yyyy}");
            Console.WriteLine($"Registro da Prova de Referência: {RegistroProvaReferencia}");
            Console.WriteLine("-----------------------------");
        }
        #endregion

        #region Método AssociarAluno
        public void AssociarAluno(Aluno aluno)
        {
            if (aluno != null)
            {
                Console.WriteLine($"Recuperação para a prova '{RegistroProvaReferencia}' está vinculada ao aluno {aluno.Nome} (Matrícula: {aluno.RegistroMatricula}).");
            }
            else
            {
                Console.WriteLine("Não é possível associar a um aluno nulo.");
            }
        }
        #endregion

        #region Método AtualizarStatusAprovacao
        public void AtualizarStatusAprovacao(string novoStatus, string nomeProfessorAvaliador)
        {
            AprovacaoProfessor = $"{novoStatus} por Prof(a). {nomeProfessorAvaliador}";
            Console.WriteLine($"Status de aprovação da recuperação para o aluno {RegistroAluno} (Prova: {RegistroProvaReferencia}) atualizado para: {AprovacaoProfessor}.");
        }
        #endregion

        #endregion
    }
}