using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Responsavel : Pessoa
    {
        #region Atributos
        public int RegistroResponsavel { get; set; }
        public Aluno Aluno { get; set; }
        #endregion

        #region Construtor
        public Responsavel(int registroResponsavel, Aluno aluno, string nome, string genero, string cpf, string rg, DateTime nascimento, string telefone, Endereco endereco)
            : base(nome, genero, cpf, rg, nascimento, telefone, endereco)
        {
            this.RegistroResponsavel = registroResponsavel;
            this.Aluno = aluno;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public override void ExibirDados()
        {
            Console.WriteLine($"Registro do Responsável: {RegistroResponsavel}");
            Console.WriteLine($"Nome do Responsável: {nome}");
            Console.WriteLine($"Telefone de Emergência: {telefone}");
            Console.Write($"Endereço: ");
            endereco.ExibirDados();
            Console.WriteLine("\nDados do Aluno vinculado: ");
            Aluno.ExibirDados();

        }
        #endregion

        #region Metodo AtualizarDados
        public void AtualizarDados(string novoTelefone, Endereco novoEndereco)
        {
            telefone = novoTelefone;
            endereco = novoEndereco;
            Console.WriteLine("Informações atualizadas com sucesso.");
        }
        #endregion

        #region Metodo ValidarDados
        public bool DadosSaoValidos()
        {
            return !string.IsNullOrWhiteSpace(nome) &&
                   !string.IsNullOrWhiteSpace(telefone) &&
                   endereco != null &&
                   RegistroResponsavel > 0;
        }
        #endregion

        #region Metodo Obter Aluno vinculado ao responsavel

        public Aluno ObterAlunoVinculado()
        {
            return Aluno;
        }
            
        #endregion
    }
}