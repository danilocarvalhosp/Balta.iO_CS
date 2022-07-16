using System;

namespace MyApp
{
    internal class Program
    {
        // USANDO GUID: GLOBAL UNIQUE IDENTIFIER
        static void Main(string [] args) {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("de7cc307-0f6a-494c-b3d8-73cff111cff3");            
            Console.WriteLine(id.ToString().Substring(0, 8));            
        }
    }
}
