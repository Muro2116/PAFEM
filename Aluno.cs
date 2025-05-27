using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Aluno : Pessoa
    {
        #region Atributos
        private int registroMatricula { get; private set; }
        private string curso { get; set; }
        private DateTime dataMatricula { get; private set; }
        #endregion

        #region Construtor
        public Aluno(string nome, string genero, string cpf, string rg, DateTime nascimento, string telefone, int registroMatricula, string curso, DateTime dataMatricula)
            : base(nome, genero, cpf, rg, nascimento, telefone)
        {
            this.RegistroMatricula = registroMatricula;
            this.Curso = curso;
            this.DataMatricula = dataMatricula;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Registro Matrícula: {RegistroMatricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Data da Matrícula: {DataMatricula.ToString("dd/MM/yyyy")}");
        }
        #endregion

        #region Metodo AtualizarDados
        public void AtualizarDados(string novoCurso)
        {
            Curso = novoCurso;
            Console.WriteLine("Curso atualizado");
        }
        #endregion

        #region Metodo ExcluirDados
        public void ExcluirDados()
        {
            RegistroMatricula = 0;
            Curso = string.Empty;
            DataMatricula = DateTime.MinValue;
            Console.WriteLine("Aluno Excluido");
        }
        #endregion

        #region Metodo VerificarMatriculaAtiva
        public bool VerificarMatriculaAtiva()
        {
            return RegistroMatricula != 0;
        }
        #endregion

        #region Metodo TempoDeMatricula
        public TimeSpan TempoDeMatricula()
        {
            return DateTime.Now - DataMatricula;
        }
        #endregion

        #region Metodo CalcularIdade
        public int CalcularIdade()
        {
            var hoje = DateTime.Today;
            int idade = hoje.Year - Nascimento.Year;
            if (Nascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade;
        }
        #endregion

        #endregion
    }
}