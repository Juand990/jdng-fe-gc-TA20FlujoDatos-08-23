using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor numerico: ");
            int valor=int.Parse(Console.ReadLine());
            if (valor%2==0)
            {
                Console.WriteLine(valor+" es divisible entre 2.");
            }
            else
            {
                Console.WriteLine(valor + " NO es divisible entre 2.");
            }
            Console.ReadKey(); 
        }
    }
}
