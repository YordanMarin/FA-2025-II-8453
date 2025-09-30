using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("*   BIENVENIDOS AL JUEGO DE ADIVINA EL NÚMERO    *");
            Console.WriteLine("*                                                *");
            Console.WriteLine("* Instrucciones:                                 *");
            Console.WriteLine("* 1. Tienes 3 intentos                           *");
            Console.WriteLine("* 2. Cada fallo ud. tendra una pista             *");
            Console.WriteLine("**************************************************\n");

            int intentos = 3;
            Random rnd = new Random();
            int secreto = rnd.Next(1,21);
            int num;

            do
            {
                Console.Write("Ingrese el número a adivinar: ");
                num = int.Parse(Console.ReadLine());

                if(secreto == num)
                {
                    Console.WriteLine("\nCorrecto! adivinaste el número!");
                    return;
                }
                else
                {
                    intentos--;
                    if(num < secreto)
                        Console.WriteLine("Pista: El número es mayor\n");
                    else
                        Console.WriteLine("Pista: El número es menor\n");
                }
            } while (intentos>0);
            Console.WriteLine($"\nNo lograste adivinar el número {secreto}!");
        }
    }
}
