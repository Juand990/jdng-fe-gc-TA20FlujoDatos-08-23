using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu edad: ");
            string edad = Console.ReadLine();
            Console.WriteLine("Te llamas "+nombre+" y tienes "+edad+" años.");
            Console.ReadKey();
        }
    }
}
