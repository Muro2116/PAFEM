using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_NP1_Programacao_orientada_a_objetos
{
    using System;

    public class Sala
    {
        // Atributos
        private int RegistroSala;
        private int NumeroSala;
        private int Capacidade;
        private string Localizacao;

        // Métodos 
        public void CreateSala(int registroSala, int numeroSala, int capacidade, string localizacao)
        {
            RegistroSala = registroSala;
            NumeroSala = numeroSala;
            Capacidade = capacidade;
            Localizacao = localizacao;
            Console.WriteLine("Sala criada com sucesso!");
        }

        public void ReadSala()
        {
            Console.WriteLine($"Registro da Sala: {RegistroSala}");
            Console.WriteLine($"Número da Sala: {NumeroSala}");
            Console.WriteLine($"Capacidade: {Capacidade}");
            Console.WriteLine($"Localização: {Localizacao}");
        }

        public void UpdateSala(int registroSala, int numeroSala, int capacidade, string localizacao)
        {
            RegistroSala = registroSala;
            NumeroSala = numeroSala;
            Capacidade = capacidade;
            Localizacao = localizacao;
            Console.WriteLine("Dados da sala atualizados com sucesso!");
        }

        public void DeleteSala()
        {
            RegistroSala = 0;
            NumeroSala = 0;
            Capacidade = 0;
            Localizacao = null;
            Console.WriteLine("Sala excluída com sucesso!");
        }

        public int GetRegistro()
        {
            return RegistroSala;
        }

        public void SetRegistro(int registroSala)
        {
            RegistroSala = registroSala;
            Console.WriteLine("Registro atualizado com sucesso!");
        }

        public int GetNumero()
        {
            return NumeroSala;
        }

        public void SetNumero(int numeroSala)
        {
            NumeroSala = numeroSala;
            Console.WriteLine("Número atualizado com sucesso!");
        }

        public int GetCapacidade()
        {
            return Capacidade;
        }

        public void SetCapacidade(int capacidade)
        {
            Capacidade = capacidade;
            Console.WriteLine("Capacidade atualizada com sucesso!");
        }

        public string GetLocalizacao()
        {
            return Localizacao;
        }

        public void SetLocalizacao(string localizacao)
        {
            Localizacao = localizacao;
            Console.WriteLine("Localização atualizada com sucesso!");
        }

        
        public void InfoSala()
        {
            Console.WriteLine($"Informações da Sala:");
            Console.WriteLine($"Registro: {RegistroSala}, Número: {NumeroSala}, Capacidade: {Capacidade}, Localização: {Localizacao}");
        }

        public void ReservarSala()
        {
            Console.WriteLine($"Sala {NumeroSala} reservada com sucesso!");
        }

        public bool VerificarDisponibilidade()
        {
       
            return true;
        }
    }
}