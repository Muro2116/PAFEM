namespace Trabalho_POO;

public class Prova
{
    // Atributos
    public required string RegistroProva { get; set; }
    public required string Disciplina { get; set; }
    public required DateTime DataProva { get; set; }
    public required double Nota { get; set; }
    public bool Recuperacao { get; set; }

    // Construtor
    public Prova(string registroProva, string disciplina, DateTime dataProva, double nota, bool recuperacao)
    {
        RegistroProva = registroProva;
        Disciplina = disciplina;
        DataProva = dataProva;
        Nota = nota;
        Recuperacao = recuperacao;
    }

    // Métodos

    // Método para validar nota
    public bool ValidarNota()
    {
        return Nota >= 0 && Nota <= 10;
    }

    // Método para recuperação
    public void VerificarRecuperacao()
    {
        if (Nota < 6)
        {
            Recuperacao = true;
        }
        else
        {
            Recuperacao = false;
        }
    }

    // Exibir dados
    public void ExibirDados()
    {
        Console.WriteLine("Registro da Prova: " + RegistroProva);
        Console.WriteLine("Disciplina: " + Disciplina);
        Console.WriteLine("Data da Prova: " + DataProva.ToString("dd/MM/yyyy"));
        Console.WriteLine("Nota: " + Nota);
        Console.WriteLine("Recuperação: " + (Recuperacao ? "Sim" : "Não"));
    }
}