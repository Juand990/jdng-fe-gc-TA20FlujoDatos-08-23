using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos precios vas a introducir??");
            int numPrecios=int.Parse(Console.ReadLine());
            double sumaPrecios = 0;
            Console.WriteLine("Introduce los precios.");
            while (numPrecios>0)
            {
                double precio = double.Parse(Console.ReadLine());
                sumaPrecios=sumaPrecios+precio;
                numPrecios--;
            }
            Console.WriteLine("Total= " +sumaPrecios);
            Console.ReadKey();
        }
    }
}
