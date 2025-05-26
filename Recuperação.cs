namespace Trabalho_POO;

using System;

public class Recuperacao
{
    // Atributos
    public required string Aprovacao_Professor {get; set;}
    public required string Curso {get; set;}
    public required DateTime Data_Recuperacao {get; set;}
    public required string Registro_Prova {get; set;}
    

    // Construtor
    public Recuperacao (string aprovacao_professor, string curso, DateTime data_recupercao, string registro_prova)
        {
            Aprovacao_Professor = aprovacao_professor;
            Curso = curso;
            Data_Recuperacao = data_recupercao;
            Registro_Prova = registro_prova;
        }
    
    // Metodos
    public override string ToString()
        {
            return $"Estado da aprovação da recuperação: {Aprovacao_Professor} \nCurso da recuperação: {Curso} \nData da prova: {Data_Recuperacao} \nId da prova: {Registro_Prova}";
        }
}