using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Módulos
    {
        #region Atributos
        private int numeroModulo { get; set; }
        private string tituloModulo { get; set; }
        private string descricao { get; set; }
        private bool concluido { get; private set; }
        private DateTime? dataInicio { get; set; }
        private DateTime? dataConclusao { get; set; }
        private Aluno Aluno { get; set; }
        #endregion

        #region Construtor
        public Módulos(int numeroModulo, string tituloModulo, string descricao, Aluno aluno)
        {
            this.numeroModulo = numeroModulo;
            this.tituloModulo = tituloModulo;
            this.descricao = descricao;
            this.Aluno = aluno;
            this.concluido = false;
            this.dataInicio = null;
            this.dataConclusao = null;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public override void ExibirDados()
        {
            Console.WriteLine($"Módulo {NumeroModulo}: {TituloModulo}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Iniciado em: {DataInicio?.ToShortDateString() ?? "Não iniciado"}");
            Console.WriteLine($"Status: {(Concluido ? "Concluido" : "Pendente")}");
        }
        #endregion

        #region MetodoConcluirModulo
        public void MarcarComoConcluido()
        {
            Concluido = true;
            DataConclusao = DateTime.Now;
            Console.WriteLine($"Módulo \"{TituloModulo}\"foi concluido em {DataConclusao.Value.ToShortDateString()}");
        }
        #endregion

        #region Metodo Certificado
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
        #endregion

        #endregion
    }
}