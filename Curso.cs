using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Atributos
public class Curso
{
    public int Registro { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }


    //Métodos
    public void CreateCurso(int registro, string nome, decimal valor, DateTime dataInicio, DateTime dataFim)
    {
        Registro = registro;
        Nome = nome;
        Valor = valor;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }


    //Ler métodos
    public void ReadCurso()
    {
        Console.WriteLine($"Registro: {Registro}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Valor: R${Valor}");
        Console.WriteLine($"Data de Início: {DataInicio}");
        Console.WriteLine($"Data de Fim: {DataFim}");
    }

    //opção de atualização do curso
    public void UpdateCurso(string nome, decimal valor, DateTime dataInicio, DateTime dataFim)
    {
        Nome = nome;
        Valor = valor;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }


    //Opção para excluir o curso
    public void DeleteCurso()
    {
        Registro = 0;
        Nome = null;
        Valor = 0;
        DataInicio = DateTime.MinValue;
        DataFim = DateTime.MinValue;
    }

    //Opção de aplicar desconto
    public void AplicarDesconto(decimal porcentagem)
    {
        Valor -= Valor * (porcentagem / 100);
    }


    //Opção exibir Detalhes
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Detalhes do Curso: Nome = {Nome}, Valor = R${Valor}, Data de Início = {DataInicio}, Data de Fim = {DataFim}");
    }

    public int CalcularDuracao()
    {
        return (DataFim - DataInicio).Days; // Retorna a duração em dias
    }
}