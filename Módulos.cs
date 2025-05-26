using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Ernesto;

namespace Trabalho_Ernesto
{
    public class Módulos
    {
        public int NumeroModulo { get; set; }
        public string TituloModulo { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; private set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }

        //Ref ao aluno

        public Aluno Aluno { get; set; }


        //metodo exibir informações

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Módulo {NumeroModulo}: {TituloModulo}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Iniciado em: {DataInicio?.ToShortDateString() ?? "Não iniciado"}");
            Console.WriteLine($"Status: {(Concluido ? "Concluido" : "Pendente")}");
        }

        //metodo marcar como concluido

        public void MarcarComoConcluido()
        {
            Concluido = true;
            DataConclusao = DateTime.Now;
            Console.WriteLine($"Módulo \"{TituloModulo}\"foi concluido em {DataConclusao.Value.ToShortDateString()}");
        }

        //metodo para emitir certificado caso tenha concluido o módulo

        public void EmitirCertificado()
        {
            if (Concluido)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("       CERTIFICADO DE CONCLUSÃO     ");
                Console.WriteLine("===================================");
                Console.WriteLine($"Aluno(a): {Aluno?.Nome ?? "Desconhecido"}");
                Console.WriteLine($"Certificamos que o módulo \"{TituloModulo}\"");
                Console.WriteLine($"foi concluído com sucesso em {DataConclusao?.ToShortDateString()}.");
                Console.WriteLine("Parabéns pelo empenho!");
                Console.WriteLine("===================================");
            }
            else
            {
                Console.WriteLine($"O módulo \"{TituloModulo}\" ainda não foi concluído. Conclua para emitir o certificado.");
            }


        }
    }
}

