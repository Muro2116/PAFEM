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
        private required string aprovacaoProfessor { get; set; }
        private required string curso { get; set; }
        private required DateTime dataRecuperacao { get; set; }
        private required string registroProva { get; set; }
        #endregion

        #region Construtor
        public Recuperacao(string aprovacaoProfessor, string curso, DateTime dataRecuperacao, string registroProva)
        {
            this.aprovacaoProfessor = aprovacaoProfessor;
            this.curso = curso;
            this.dataRecuperacao = dataRecuperacao;
            this.registroProva = registroProva;
        }
        #endregion

        #region Metodos

        #region Método ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine($"Aprovação do Professor: {aprovacaoProfessor}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Data da Recuperação: {dataRecuperacao.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Registro da Prova: {registroProva}");
        }
        #endregion

        #endregion
    }
}