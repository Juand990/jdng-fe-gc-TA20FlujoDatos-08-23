using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un dia de la semana: ");
            string dia = Console.ReadLine().ToLower();
            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Entre semana.");
                    break;
                case "martes":
                    Console.WriteLine("Entre semana.");
                    break;
                case "miercoles":
                    Console.WriteLine("Entre semana.");
                    break;
                case "jueves":
                    Console.WriteLine("Entre semana.");
                    break;
                case "viernes":
                    Console.WriteLine("Entre semana.");
                    break;
                case "sabado":
                    Console.WriteLine("Fin de semana.");
                    break;
                case "domingo":
                    Console.WriteLine("Fin de semana.");
                    break;
                default:
                    Console.WriteLine("Dia no valido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
