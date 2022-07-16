using System;

namespace MyApp
{
    internal class Program
    {
        // COMPARAÇÃO DE STRINGS
        static void Main(string [] args) {
            var texto1 = "Testando";
            Console.WriteLine(texto1.CompareTo("Testando"));
            Console.WriteLine(texto1.CompareTo("testando"));

            var texto2 = "Este texto é um teste";
            Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}
