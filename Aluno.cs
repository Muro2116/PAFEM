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
        public int RegistroMatricula { get; private set; }
        public string Curso { get; set; }
        public DateTime DataMatricula { get; private set; }
        #endregion

        #region Construtor
        public Aluno(string nome, string genero, string cpf, string rg, DateTime nascimento, string telefone, Endereco endereco,
                    int registroMatricula, string curso, DateTime dataMatricula)
            : base(nome, genero, cpf, rg, nascimento, telefone, endereco)
        {
            RegistroMatricula = registroMatricula;
            Curso = curso;
            DataMatricula = dataMatricula;
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

        #region Metodo AtualizarCurso
        public void AtualizarCurso(string novoCurso)
        {
            if (!string.IsNullOrWhiteSpace(novoCurso))
            {
                Curso = novoCurso;
                Console.WriteLine("Curso atualizado");
            }
            else
            {
                Console.WriteLine("Nome do novo curso não pode ser vazio");
            }
        }
        #endregion

        #region Metodo LimparDadosAluno
        public void LimparDadosAluno()
        {
            RegistroMatricula = 0;
            Curso = string.Empty;
            DataMatricula = DateTime.MinValue;
            Console.WriteLine("Dados específicos do aluno foram limpos/resetados.");
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
            if (Nascimento.Date > hoje.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
        #endregion

        #endregion
    }
}