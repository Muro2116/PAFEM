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
        public int NumeroModulo { get; set; }
        public string TituloModulo { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; private set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataConclusao { get; private set; }
        public Aluno Aluno { get; set; }
        public Prova Prova { get; set; }
        #endregion

        #region Construtor
        public Módulos(int numeroModulo, string tituloModulo, string descricao, Aluno aluno)
        {
            NumeroModulo = numeroModulo;
            TituloModulo = tituloModulo;
            Descricao = descricao;
            Aluno = aluno;
            Concluido = false;
            DataInicio = null;
            DataConclusao = null;
            Prova = null;
        }
        #endregion

        #region Metodos

        #region Metodo ExibirDados
        public void ExibirDados()
        {
            Console.WriteLine($"--- Módulo {NumeroModulo}: {TituloModulo} ---");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Aluno: {Aluno?.Nome ?? "Não especificado"}");
            Console.WriteLine($"Iniciado em: {DataInicio?.ToShortDateString() ?? "Não iniciado"}");
            Console.WriteLine($"Status: {(Concluido ? "Concluído" : "Pendente")}");
            if (Concluido && DataConclusao.HasValue)
            {
                Console.WriteLine($"Data de Conclusão: {DataConclusao.Value.ToShortDateString()}");
            }
            if (Prova != null)
            {
                Console.WriteLine($"Prova Associada: {Prova.RegistroProva}, Disciplina: {Prova.Disciplina}, Nota: {Prova.Nota}");
            }
            else
            {
                Console.WriteLine("Prova: Nenhuma prova associada ou realizada ainda.");
            }
            Console.WriteLine("-----------------------------------");  
        }
        #endregion

        #region MetodoConcluirModulo
        public void MarcarComoConcluido()
        {
            if (!Concluido)
            {
                Concluido = true;
                DataConclusao = DateTime.Now;
                Console.WriteLine($"Módulo \"{TituloModulo}\" foi concluído em {DataConclusao.Value.ToShortDateString()}.");
            }
            else
            {
                Console.WriteLine($"Módulo \"{TituloModulo}\" já está marcado como concluído.");
            }
        }
        #endregion

        #region Metodo RegistrarDataInicio
        public void RegistrarDataInicio()
        {
            if (!DataInicio.HasValue)
            {
                DataInicio = DateTime.Now;
                Console.WriteLine($"Módulo \"{TituloModulo}\" iniciado em {DataInicio.Value.ToShortDateString()}.");
            }
            else
            {
                Console.WriteLine($"Módulo \"{TituloModulo}\" já foi iniciado em {DataInicio.Value.ToShortDateString()}.");
            }
        }
        #endregion

        #region Metodo AssociarProva
        public void AssociarProva(Prova prova)
        {
            if (prova != null)
            {
                this.Prova = prova;
                Console.WriteLine($"Prova {prova.RegistroProva} associada ao módulo \"{TituloModulo}\".");
            }
            else
            {
                Console.WriteLine("Não é possível associar uma prova nula.");
            }
        }
        #endregion

        #region Metodo Verificar Situacao

        public void VerificarSituacao()
        {
            Console.WriteLine($"--- Situação do Módulo: {TituloModulo} (Aluno: {Aluno?.Nome ?? "N/A"}) ---");
            if (Prova == null)
            {
                Console.WriteLine("Status: Pendente. Nenhuma prova foi associada ou realizada para este módulo.");
            }
            else if (Prova.NecessitaRecuperacao)
            {
                Console.WriteLine($"Status: Reprovado na avaliação (Nota: {Prova.Nota}). Necessita agendar recuperação para a prova {Prova.RegistroProva}.");
            }
            else if (Concluido)
            {
                Console.WriteLine($"Status: Aprovado e Concluído! (Nota na prova: {Prova.Nota})");
            }
            else
            {
                Console.WriteLine($"Status: Aprovado na avaliação (Nota: {Prova.Nota}), mas o módulo ainda está em andamento ou aguardando outras pendências para conclusão.");
            }
            Console.WriteLine("---------------------------------------------------------");
        }

        #endregion

        #region Metodo Certificado
        public void EmitirCertificado()
        {
            bool aprovadoNaProva = Prova != null && !Prova.NecessitaRecuperacao;

            if (Concluido && aprovadoNaProva)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("     CERTIFICADO DE CONCLUSÃO      ");
                Console.WriteLine("===================================");
                Console.WriteLine($"Aluno(a): {Aluno?.Nome ?? "Nome não disponível"}");
                Console.WriteLine($"Certificamos que o módulo \"{TituloModulo}\"");
                Console.WriteLine($"foi concluído com aproveitamento em {DataConclusao?.ToShortDateString() ?? "Data não registrada"}.");
                Console.WriteLine($"Nota da Avaliação: {Prova?.Nota}");
                Console.WriteLine("Parabéns pelo empenho!");
                Console.WriteLine("===================================");
            }
            else
            {
                string motivo = !Concluido ? "não foi concluído" : "a aprovação na avaliação está pendente";
                Console.WriteLine($"Não é possível emitir o certificado: O módulo \"{TituloModulo}\" {motivo}.");
            }
        }
        #endregion

        #endregion
    }
}