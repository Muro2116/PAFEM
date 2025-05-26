using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Ernesto;

namespace Trabalho_Ernesto
{
    public class Responsavel
    {
        public int Registro_Responsavel { get; set; }
        public string Nome_Responsavel { get; set; }
        public string Telefone_Emergencia { get; set; }
        public string Endereco { get; set; }



        //método para exibir informações

        public string ExibirDados ()
        {
            return $"Numero de Registro: {Registro_Responsavel}\n" +
                   $"Nome do responsável: {Nome_Responsavel}\n" +
                   $"Telefone: {Telefone_Emergencia}\n"+
                   $"Endereço: {Endereco}";
                   
        }

        //metodo para atualizar info

        public void AtualizarContato(string novoTelefone_Emergencia, string novoEndereco)
        {
            Telefone_Emergencia = novoTelefone_Emergencia;
            Endereco = novoEndereco;
            Console.WriteLine("Informações atualizadas com sucesso.");
        }

        //metodo para validar dados

        public bool DadosSaoValidos()
        {
            return !string.IsNullOrWhiteSpace(Nome_Responsavel) &&
                   !string.IsNullOrWhiteSpace(Telefone_Emergencia) &&
                   !string.IsNullOrWhiteSpace(Endereco) &&
                    Registro_Responsavel > 0;
        }


    }
}
