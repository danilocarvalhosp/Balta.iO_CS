using System;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        // STRINGBUILDER
        static void Main(string [] args) {
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste ");
            texto.Append("para guardar em memória ");
            texto.Append("textos de várias linhas ");
            texto.Append("dividindo-os em partes");

            texto.ToString();
            Console.WriteLine(texto);
        }
    }
}
