using System;
using Trabalho_POO;

namespace Trabalho_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema de Academia de Cursos PAFEM ---");
            Console.WriteLine("===========================================\n");
            // Exemplo de uso de Endereco
            Console.WriteLine("--- Configurando Endereços ---");
            Endereco enderecoAluno1 = new Endereco("Rua das Palmeiras", "123", "Vila Mariana", "São Paulo", "SP", "01234-567");
            Endereco enderecoProf1 = new Endereco("Avenida Principal", "789", "Centro", "Campinas", "SP", "13001-001");
            Endereco enderecoCurso = new Endereco("Rua da Instituição", "1000", "Campus Universitário", "Valinhos", "SP", "13270-000");
            Console.WriteLine("Endereços criados.\n");
            enderecoAluno1.ExibirDados();
            Console.WriteLine();

            // Exemplo de uso de Aluno
            Console.WriteLine("--- Cadastrando Aluno ---");
            Aluno aluno1 = new Aluno(
                "Ana Silva", "Feminino", "111.222.333-44", "33.444.555-6", new DateTime(2003, 5, 15), "11987654321", enderecoAluno1,
                1001, "Desenvolvimento Web", new DateTime(2024, 1, 10)
            );
            aluno1.ExibirDados();
            Console.WriteLine($"Idade do Aluno: {aluno1.CalcularIdade()} anos");
            Console.WriteLine($"Matrícula Ativa: {(aluno1.VerificarMatriculaAtiva() ? "Sim" : "Não")}");
            Console.WriteLine($"Tempo de Matrícula: {aluno1.TempoDeMatricula().Days} dias\n");

            Console.WriteLine("--- Atualizando Curso do Aluno ---");
            aluno1.AtualizarCurso("Desenvolvimento Full Stack");
            Console.WriteLine($"Novo curso do aluno: {aluno1.Curso}\n");

            // Validando CPF
            Console.WriteLine($"CPF {aluno1.Cpf} é válido? {Pessoa.ValidarCPF(aluno1.Cpf)}");
            Console.WriteLine($"CPF 277.825.726-81 é válido? {Pessoa.ValidarCPF("277.825.726-81")}\n");

            // Exemplo de uso de Professor
            Console.WriteLine("--- Cadastrando Professor ---");
            Professor prof1 = new Professor(
                501, "Dr. Carlos Antunes", "Masculino", "222.333.444-55", "44.555.666-7", new DateTime(1980, 8, 25), "19912345678", enderecoProf1,
                "Inteligência Artificial", 7500.00m, new DateTime(2015, 3, 1)
            );
            prof1.ExibirDados();
            Console.WriteLine();
            prof1.ExibirCurriculo();
            Console.WriteLine($"Tempo de casa do professor: {prof1.TempoDeCasa()} anos\n");

            Console.WriteLine("--- Reajustando Salário do Professor ---");
            prof1.ReajusteSalarial(10);
            Console.WriteLine($"Novo salário do professor: R${prof1.Salario:F2}\n");

            // Exemplo de uso de Responsável
            Console.WriteLine("--- Cadastrando Responsável ---");
            Responsavel resp1 = new Responsavel(
                7001, aluno1, "Marcos Silva", "Masculino", "333.444.555-66", "55.666.777-8", new DateTime(1975, 10, 5), "11988887777", enderecoAluno1 // Usando o mesmo endereço do aluno por simplicidade
            );
            resp1.ExibirDados();
            Console.WriteLine($"Dados do Responsável são válidos? {resp1.DadosSaoValidos()}\n");
            Console.WriteLine($"Aluno vinculado ao responsável {resp1.Nome}: {resp1.ObterAlunoVinculado().Nome}\n");

            // Exemplo de uso de Curso
            Console.WriteLine("--- Cadastrando Curso ---");
            Curso cursoTI = new Curso(
                201, "Tecnologia da Informação Avançada", 1200.00m, new DateTime(2024, 7, 1), new DateTime(2025, 6, 30)
            );
            cursoTI.ExibirDados();
            Console.WriteLine($"Duração do curso em dias: {cursoTI.CalcularDuracaoEmDias()}\n");

            Console.WriteLine("--- Aplicando Desconto no Curso ---");
            cursoTI.AplicarDesconto(15);
            Console.WriteLine($"Novo valor do curso: R${cursoTI.Valor:F2}\n");

            // Exemplo de uso de Sala
            Console.WriteLine("--- Cadastrando Sala ---");
            Sala sala101 = new Sala(1, 101, 30, "Bloco A, Primeiro Andar");
            sala101.ExibirDados();
            sala101.AtualizarDados(102, 35, "Bloco A, Segundo Andar Atualizado");
            Console.WriteLine("Dados da sala após atualização:");
            sala101.ExibirDados();
            Console.WriteLine();

            // Exemplo de uso de Modulo
            Console.WriteLine("--- Cadastrando Módulo para Aluno ---");
            Módulos moduloProg = new Módulos(1, "Programação Orientada a Objetos", "Conceitos de POO com C#", aluno1);
            moduloProg.RegistrarDataInicio();
            moduloProg.ExibirDados();
            Console.WriteLine();

            // Criando Prova e Associando ao Módulo
            Console.WriteLine("--- Criando e Associando Prova ao Módulo ---");
            // Prova onde o aluno não atinge a média para recuperação
            Prova provaPOO_aluno1_Reprov = new Prova("PPOO01", moduloProg.TituloModulo, DateTime.Now.AddDays(30), 5.5, false);
            Console.WriteLine($"Nota da prova é válida? {provaPOO_aluno1_Reprov.ValidarNota()}");
            moduloProg.AssociarProva(provaPOO_aluno1_Reprov);
            provaPOO_aluno1_Reprov.ExibirDados();
            Console.WriteLine();

            // Gerando agendamento de recuperação
            Console.WriteLine("--- Verificando Necessidade de Recuperação e Gerando Agendamento ---");
            Recuperacao? agendamentoRecuperacao1 = provaPOO_aluno1_Reprov.GerarAgendamentoRecuperacao(
                aluno1.RegistroMatricula.ToString(),
                DateTime.Now.AddDays(45)
            );
            Console.WriteLine("\nDados da prova após tentativa de gerar recuperação:");
            provaPOO_aluno1_Reprov.ExibirDados();

            if (agendamentoRecuperacao1 != null)
            {
                Console.WriteLine("\n--- Detalhes do Agendamento de Recuperação ---");
                agendamentoRecuperacao1.ExibirDados();
                agendamentoRecuperacao1.AtualizarStatusAprovacao("Aprovada", prof1.Nome); // Professor aprova
                // O método AssociarAluno em Recuperacao apenas exibe mensagem no momento
                agendamentoRecuperacao1.AssociarAluno(aluno1);
                Console.WriteLine("\nDados da recuperação após atualização do professor:");
                agendamentoRecuperacao1.ExibirDados();
            }
            else
            {
                Console.WriteLine("Nenhuma recuperação foi necessária para esta prova.");
            }
            Console.WriteLine();

            // Prova onde o aluno atinge a média
            Console.WriteLine("--- Criando outra Prova (Aluno Aprovado) ---");
            Prova provaBD_aluno1_Aprov = new Prova("PBD01", "Banco de Dados", DateTime.Now.AddDays(60), 8.0, false);
            Recuperacao? agendamentoRecuperacao2 = provaBD_aluno1_Aprov.GerarAgendamentoRecuperacao(
                aluno1.RegistroMatricula.ToString(),
                DateTime.Now.AddDays(75)
            );
            if (agendamentoRecuperacao2 == null)
            {
                Console.WriteLine($"Aluno aprovado na prova {provaBD_aluno1_Aprov.RegistroProva}, não precisa de recuperação.\n");
            }

            // Finalizando Módulo
            Console.WriteLine("--- Verificando Situação e Concluindo Módulo ---");
            moduloProg.VerificarSituacao();
            
            Console.WriteLine("\n(Simulando que a pendência da recuperação foi resolvida para fins de teste do certificado)");
            moduloProg.AssociarProva(provaBD_aluno1_Aprov);
            moduloProg.VerificarSituacao();

            moduloProg.MarcarComoConcluido();
            moduloProg.EmitirCertificado();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}