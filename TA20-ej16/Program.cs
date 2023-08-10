using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un precio: ");
            double precio = double.Parse(Console.ReadLine());
            const int IVA = 21;
            double precioAnadido = precio / 100 * IVA;
            double total = precio + precioAnadido;
            Console.WriteLine("Precio TOTAL con IVA = "+ total);
            Console.ReadKey();
        }
    }
}
