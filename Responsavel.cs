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
        public Aluno AlunoVinculado { get; set; }
        #endregion

        #region Construtor
        public Responsavel(int registroResponsavel, Aluno alunoVinculado, string nome, string genero, string cpf, string rg,
                            DateTime nascimento, string telefone, Endereco endereco)
            : base(nome, genero, cpf, rg, nascimento, telefone, endereco)
        {
            RegistroResponsavel = registroResponsavel;
            AlunoVinculado = alunoVinculado;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public override void ExibirDados()
        {
            Console.WriteLine($"--- Dados do Responsável (Registro: {RegistroResponsavel}) ---");
            base.ExibirDados();
            if (AlunoVinculado != null)
            {
=                AlunoVinculado.ExibirDados();
            }
            else
            {
                Console.WriteLine("Nenhum aluno vinculado.");
            }
            Console.WriteLine("\nDados do Aluno vinculado: ");
        }
        #endregion

        #region Metodo AtualizarDados
        public void AtualizarDadosContato(string novoTelefone, Endereco novoEndereco)
        {
            if (!string.IsNullOrWhiteSpace(novoTelefone))
            {
                Telefone = novoTelefone;
            }
            if (novoEndereco != null)
            {
                Endereco = novoEndereco;
            }
            Console.WriteLine("Dados de contato do responsável atualizados com sucesso.");
        }
        #endregion

        #region Metodo ValidarDados
        public bool DadosSaoValidos()
        {
            bool baseValido = !string.IsNullOrWhiteSpace(Nome) &&
                                !string.IsNullOrWhiteSpace(Telefone) &&
                                Endereco != null &&
                                Endereco.Rua != null;

            bool responsavelValido = RegistroResponsavel > 0 && AlunoVinculado != null;
            return baseValido && responsavelValido;
        }
        #endregion

        #region Metodo ObterAlunoVinculado

        public Aluno ObterAlunoVinculado()
        {
            return AlunoVinculado;
        }

        #endregion

        #endregion
    }
}