using System;

namespace MyApp
{
    internal class Program
    {
        // EQUALS
        static void Main(string [] args) { 
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

            var teste = 33;
            Console.WriteLine(teste.Equals(33));
            ;
        }
    }
}
