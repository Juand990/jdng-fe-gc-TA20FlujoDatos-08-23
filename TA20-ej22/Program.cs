using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA20_ej22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = "123asd";
            int intentos = 3;
            bool acertado = false;
            while (!acertado & intentos>=1)
            {
                Console.WriteLine("Introduce la contraseña: ");
                string introPass = Console.ReadLine();
                if (pass == introPass)
                {
                    acertado = true;
                }
                intentos--;
            }
            if (acertado)
            {
                Console.WriteLine("Enhorabuena, contraseña correcta.");
            }
            else
            {
                Console.WriteLine("No has encontrado la contraseña correcta.");
            }
            Console.ReadKey();
        }
    }
}
