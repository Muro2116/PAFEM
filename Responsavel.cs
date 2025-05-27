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
        private int registroResponsavel { get; set; }
        private string endereco { get; set; }
        #endregion

        #region Construtor

        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public override void ExibirDados()
        {
            Console.WriteLine($"Registro do Responsável: {registroResponsavel}");
            Console.WriteLine($"Nome do Responsável: {nome}");
            Console.WriteLine($"Telefone de Emergência: {telefone}");
            Console.WriteLine($"Endereço: {endereco}");
        }
        #endregion

        #region Metodo AtualizarDados
        public void AtualizarInformacoes(string novoTelefone, string novoEndereco)
        {
            telefone = novoTelefone;
            endereco = novoEndereco;
            Console.WriteLine("Informações atualizadas com sucesso.");
        }
        #endregion

        #region Metodo ValidarDados
        public bool DadosSaoValidos()
        {
            return !string.IsNullOrWhiteSpace(Nome_Responsavel) &&
                   !string.IsNullOrWhiteSpace(Telefone_Emergencia) &&
                   !string.IsNullOrWhiteSpace(Endereco) &&
                    Registro_Responsavel > 0;
        }
        #endregion

        #endregion
    }
}
