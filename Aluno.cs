using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_NP1_Programacao_orientada_a_objetos
{
    public class Aluno
    {
        //atributos
        public int RegistroMatricula { get; private set; }
        public string Curso { get; set; }
        public DateTime DataMatricula { get; private set; }

        public string Nome { get; set; }
        public string Genero { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }

        //construtor
        public Aluno(int registromatricula, string curso, DateTime dataMatricula, string nome, string genero, string cpf, string rg, DateTime nascimento, string telefone)
        {
            RegistroMatricula = registromatricula;
            Curso = curso;
            DataMatricula = dataMatricula;
            Nome = nome;
            Genero = genero;
            CPF = cpf;
            RG = rg;
            Nascimento = nascimento;
            Telefone = telefone;
        }

        //métodos
        public void CreateAluno (int registromatricula, string curso, DateTime datamatricula)
        {
            RegistroMatricula = registromatricula;
            Curso = curso;
            DataMatricula = datamatricula;
            Console.WriteLine("Matricula do aluno criada.");
        }

        public void ReadAluno ()
        { Console.WriteLine($"Registro: {RegistroMatricula}, Curso: {Curso}, Data da matrícula {DataMatricula}");

        }

        public void UpdateAluno (string novoCurso)
        {
            Curso = novoCurso;
            Console.WriteLine("Curso atualizado");
        }

        public void DeleteAluno()
        {
            RegistroMatricula = 0;
            Curso = string.Empty;
            DataMatricula = DateTime.MinValue;
            Console.WriteLine("Aluno Excluido");
        }

        public int GetMatricula ()
        {  
            return RegistroMatricula; 
        }

        public void Setmatricula (int novoregistromatricula)
        {
            RegistroMatricula= novoregistromatricula;
            Console.WriteLine("Nova matriculada realizada com sucesso");
        }

        public string GetCurso ()
        {
            return Curso;
        }

        public void SetCurso (string curso)
        {
            Curso = curso;
            Console.WriteLine("Curso atualizado");
        }

        public DateTime GetDataMatricula()
        {
            return DataMatricula;
        }

        public void SetDataMatricula(DateTime dataMatricula)
        {
            DataMatricula = dataMatricula;
            Console.WriteLine("Data de matrícula atualizada com sucesso!");
        }

    
        public bool VerificarMatriculaAtiva()
        {
            return RegistroMatricula != 0;
        }

        public TimeSpan TempoDeMatricula()
        {
            return DateTime.Now - DataMatricula;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Registro Matrícula: {RegistroMatricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Data da Matrícula: {DataMatricula}");
            Console.WriteLine($"Tempo de Matrícula: {TempoDeMatricula().Days} dias");
            Console.WriteLine($"Matrícula Ativa: {(VerificarMatriculaAtiva() ? "Sim" : "Não")}");
        }

        // Calcular idade
        public int CalcularIdade()
        {
            var hoje = DateTime.Today;
            int idade = hoje.Year - Nascimento.Year;
            if (Nascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade;
        }

        // Exibir dados
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("RG: " + RG);
            Console.WriteLine("Nascimento: " + Nascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine("Idade: " + CalcularIdade());
            Console.WriteLine("Telefone: " + Telefone);
        }
    }


}





    