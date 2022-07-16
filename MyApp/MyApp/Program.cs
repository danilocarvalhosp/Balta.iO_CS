using System;

namespace MyApp
{
    internal class Program
    {
        // INTERPOLAÇÃO DE STRINGS
        static void Main(string [] args) {
            var price = 10.2;
            var texto1 = "O preço do produto é " + price + " apenas na promoção.";
            var texto2 = string.Format("O preço do produto é {0} apenas na promoção.", price);
            var texto3 = $"O preço do produto é {price} apenas na promoção.";

            Console.WriteLine(texto3);
        }
    }
}
