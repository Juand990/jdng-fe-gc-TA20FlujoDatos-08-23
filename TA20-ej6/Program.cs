using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor de producto: ");
            int precio=int.Parse(Console.ReadLine());
            Console.WriteLine("En que forma vas a pagar? (efectivo/tarjeta): ");
            string pagar = Console.ReadLine().ToLower();
            if (pagar=="tarjeta")
            {
                Console.WriteLine("Introduce numero de tarjeta: ");
                int tarjeta = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Producto PAGADO!");
            Console.ReadKey();
        }
    }
}
