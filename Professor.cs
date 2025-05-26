using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Professor
{
    // Propriedades privadas
    private int registro;
    private string nome;
    private string telefone;
    private string cpf;
    private string endereco;
    private string especializacao;
    private decimal salario;
    private DateTime dataContratacao;

    // Método para criar um novo professor
    public void CreateProfessor(int registro, string nome, string telefone, string cpf, string endereco, string especializacao, decimal salario, DateTime dataContratacao)
    {
        this.registro = registro;
        this.nome = nome;
        this.telefone = telefone;
        this.cpf = cpf;
        this.endereco = endereco;
        this.especializacao = especializacao;
        this.salario = salario;
        this.dataContratacao = dataContratacao;
    }

    // Método para exibir os detalhes do professor
    public void ReadProfessor()
    {
        Console.WriteLine($"Registro: {registro}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"CPF: {cpf}");
        Console.WriteLine($"Endereço: {endereco}");
        Console.WriteLine($"Especialização: {especializacao}");
        Console.WriteLine($"Salário: R${salario}");
        Console.WriteLine($"Data de Contratação: {dataContratacao.ToShortDateString()}");
    }

    // Método para atualizar informações do professor
    public void UpdateProfessor(string nome, string telefone, string endereco, string especializacao, decimal salario)
    {
        this.nome = nome;
        this.telefone = telefone;
        this.endereco = endereco;
        this.especializacao = especializacao;
        this.salario = salario;
    }

    // Método para deletar os dados do professor
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

    // Getters e Setters
    public int GetRegistro() => registro;
    public void SetRegistro(int registro) => this.registro = registro;

    public string GetNome() => nome;
    public void SetNome(string nome) => this.nome = nome;

    public string GetTelefone() => telefone;
    public void SetTelefone(string telefone) => this.telefone = telefone;

    public string GetCpf() => cpf;
    public void SetCpf(string cpf) => this.cpf = cpf;

    public string GetEndereco() => endereco;
    public void SetEndereco(string endereco) => this.endereco = endereco;

    public string GetEspecializacao() => especializacao;
    public void SetEspecializacao(string especializacao) => this.especializacao = especializacao;

    public decimal GetSalario() => salario;
    public void SetSalario(decimal salario) => this.salario = salario;

    public DateTime GetDataContratacao() => dataContratacao;
    public void SetDataContratacao(DateTime dataContratacao) => this.dataContratacao = dataContratacao;

    // Métodos adicionais
    public void ReajusteSalarial(decimal percentual)
    {
        salario += salario * (percentual / 100);
    }

    public void ExibirCurriculo()
    {
        Console.WriteLine($"Currículo de {nome}:\nEspecialização: {especializacao}\nExperiência desde: {dataContratacao.Year}");
    }

    public int TempoDeCasa()
    {
        return (DateTime.Now - dataContratacao).Days / 365; // Retorna o tempo de casa em anos
    }
}