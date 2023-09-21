using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rappresentare_una_persona_fisica
{
    internal class Persona
    {
        public int Codice;
        public string Cognome;
        public string Nome;
        public bool Registrato;

        public Persona(int codice, string cognome, string nome, bool registrato)
        {
            Codice = codice;
            Cognome = cognome;
            Nome = nome;
            Registrato = false;
        }
        public void Registra()
        {
            Registrato = true;
            Console.WriteLine($"{Cognome} {Nome} è stato registrato");
        }

        public void Mostra()
        {

            Console.WriteLine($"Codice: {Codice}");
            Console.WriteLine($"Cognome: {Cognome}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Registrato: {(Registrato ? "Si" : "No")}");
        }

    }
}
