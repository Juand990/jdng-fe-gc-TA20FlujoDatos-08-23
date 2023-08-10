using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio de un circulo: ");
            double radio = double.Parse(Console.ReadLine());            
            double area = Math.PI * Math.Pow(radio,2);            
            Console.WriteLine("Area del circulo: " + area);
            Console.ReadKey();
        }
    }
}
