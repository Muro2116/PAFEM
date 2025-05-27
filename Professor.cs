using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabalho_POO
{
    public class Professor : Pessoa
    {
        #region Atributos
        private required int registro { get; set; }
        private required string endereco { get; set; }
        private required string especializacao { get; set; }
        private required decimal salario { get; set; }
        private required DateTime dataContratacao { get; set; }
        #endregion

        #region Construtor
        
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public override void ExibirDados()
        {
            Console.WriteLine($"Registro: {Registro}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Especialização: {Especializacao}");
            Console.WriteLine($"Salário: R${Salario}");
            Console.WriteLine($"Data de Contratação: {DataContratacao.ToShortDateString()}");
        }
        #endregion

        #region Metodo AtualizarDados
        public void UpdateProfessor(string nome, string telefone, string endereco, string especializacao, decimal salario)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
            this.especializacao = especializacao;
            this.salario = salario;
        }
        #endregion

        #region Metodo DeletarDados
        public void DeleteProfessor()
        {
            registro = 0;
            nome = null;
            telefone = null;
            cpf = null;
            endereco = null;
            especializacao = null;
            salario = 0;
            dataContratacao = DateTime.MinValue;
        }
        #endregion

        #region Metodo AjusteSalarial
        public void ReajusteSalarial(decimal percentual)
        {
            salario += salario * (percentual / 100);
        }
        #endregion

        #region Metodo ExibirCurriculo
        public void ExibirCurriculo()
        {
            Console.WriteLine($"Currículo de {nome}:\nEspecialização: {especializacao}\nExperiência desde: {dataContratacao.Year}");
        }
        #endregion

        #region Metodo ExibirTempoDeCasa
        public int TempoDeCasa()
        {
            return (DateTime.Now - dataContratacao).Days / 365; // Retorna o tempo de casa em anos
        }
        #endregion

        #endregion
    }
}