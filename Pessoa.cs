namespace Trabalho_POO;

using System;

public class Pessoa
{
    // Atributos
    public required string Nome {get; set;}
    public required string Genero {get; set;}
    public required string CPF {get; set;}
    public required string RG {get; set;}
    public required DateTime Nascimento {get; set;}
    public required string Telefone {get; set;}

    // Construtor
    public Pessoa(string nome, string genero, string cpf, string rg, DateTime nascimento, string telefone)
    {
        Nome = nome;
        Genero = genero;
        CPF = cpf;
        RG = rg;
        Nascimento = nascimento;
        Telefone = telefone;
    }

    // Métodos

    // Metodo para Validar CPF

    // Limpar a entrada do cpf deixando apenas numeros
    // Verificar tamanho do cpf (11 digitos) e se o cpf tem numeros iguais 
    // Verificar primeiro digito de validacao (for para iterar os pesos sobre cada número)
    // Verificar segundo digito de validacao (for para iterar os pesos sobre cada número)
    // retornar bool

    // Exibir dados
    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("CPF: " + CPF);
        Console.WriteLine("RG: " + RG);
        Console.WriteLine("Nascimento: " + Nascimento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Telefone: " + Telefone);
    }
}