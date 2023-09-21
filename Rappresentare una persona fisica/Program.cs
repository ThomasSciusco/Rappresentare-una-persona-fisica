using System;
using System.Threading;
using Rappresentare_una_persona_fisica;

namespace Rappresentare_una_persona_fisica

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona(1, "Rossi", "Mario");

            Console.WriteLine("Dati prima ddella registrazione");
            persona1.Mostra();

            persona1.Registra();

            Console.WriteLine("\nDati dopo la registrazione");
            persona1.Mostra();

        }
    }
}
