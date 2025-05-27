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
        private bool recuperacao { get; set; }
        #endregion

        #region Construtor
        public Prova(string registroProva, string disciplina, DateTime dataProva, double nota, bool recuperacao)
        {
            this.registroProva = registroProva;
            this.disciplina = disciplina;
            this.dataProva = dataProva;
            this.nota = nota;
            this.recuperacao = recuperacao;
        }
        #endregion

        #region Metodos

        #region Metood ValidarNota
        public bool ValidarNota()
        {
            return Nota >= 0 && Nota <= 10;
        }
        #endregion

        #region Metodo VerificarRecuperacao
        public void VerificarRecuperacao()
        {
            if (Nota < 6)
            {
                Recuperacao = true;
            }
            else
            {
                Recuperacao = false;
            }
        }
        #endregion

        #region Método ExibirDados
        public override void ExibirDados()
        {
            Console.WriteLine("Registro da Prova: " + RegistroProva);
            Console.WriteLine("Disciplina: " + Disciplina);
            Console.WriteLine("Data da Prova: " + DataProva.ToString("dd/MM/yyyy"));
            Console.WriteLine("Nota: " + Nota);
            Console.WriteLine("Recuperação: " + (Recuperacao ? "Sim" : "Não"));
        }
        #endregion

        #endregion
    }
}