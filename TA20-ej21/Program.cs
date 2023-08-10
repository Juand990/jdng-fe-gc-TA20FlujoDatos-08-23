using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dia de la semana: ");
            string dia=Console.ReadLine().ToLower();
            switch(dia)
            {
                case "lunes":
                    Console.WriteLine("Dia laborable");
                    break;
                case "martes":
                    Console.WriteLine("Dia laborable");
                    break;
                case "miercoles":
                    Console.WriteLine("Dia laborable");
                    break;
                case "jueves":
                    Console.WriteLine("Dia laborable");
                    break;
                case "viernes":
                    Console.WriteLine("Dia laborable");
                    break;
                case "sabado":
                    Console.WriteLine("Dia NO laborable");
                    break;
                case "domingo":
                    Console.WriteLine("Dia NO laborable");
                    break;
                default:
                    Console.WriteLine("Dia MAL introducido.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
