﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1>numero2)
            {
                Console.WriteLine(numero1+" es el mayor:");
            }
            else
            {
                Console.WriteLine(numero2 + " es el mayor:");
            }
            Console.ReadKey();
        }
    }
}
