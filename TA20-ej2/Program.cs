using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un nombre de persona: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe un nombre de ciudad: ");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
            Console.ReadKey();
        }
    }
}
