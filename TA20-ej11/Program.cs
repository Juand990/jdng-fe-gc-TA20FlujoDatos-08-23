﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            if (num1>num2)
            {
                Console.WriteLine(num1 + " es el mayor.");
            }
            else
            {
                if (num1==num2)
                {
                    Console.WriteLine("Son numeros iguales.");
                }
                else
                {
                    Console.WriteLine(num2 + " es el mayor.");
                }
            }
            Console.ReadKey();
        }
    }
}
