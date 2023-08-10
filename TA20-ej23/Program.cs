using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce signo aritmetico: ");
            string signo = Console.ReadLine();
            switch (signo)
            {
                case "+":
                    Console.WriteLine("Suma de los valores= "+(valor1+valor2));
                    break;
                case "-":
                    Console.WriteLine("Resta de los valores= " + (valor1 - valor2));
                    break;
                case "*":
                    Console.WriteLine("Multiplicacion de los valores= " + (valor1 * valor2));
                    break;
                case "/":
                    Console.WriteLine("Division de los valores= " + (valor1 / valor2));
                    break;
                case "^":
                    Console.WriteLine("Potencia de los valores= " + Math.Pow(valor1, valor2));
                    break;
                case "%":
                    Console.WriteLine("Modulo de los valores= " + (valor1%valor2));
                    break;
                default:
                    Console.WriteLine("Signo no valido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
