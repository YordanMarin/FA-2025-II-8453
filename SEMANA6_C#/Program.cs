using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al sistema de validación de contraseña\n");

            Console.Write("Genere una contraseña: ");
            string g = Console.ReadLine();

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("-      Válide su contraseña       -");
            Console.WriteLine("-----------------------------------\n");

            int intentos = 3;

            while(intentos > 0)
            {
                Console.Write("Ingrese la contraseña: ");
                string i = Console.ReadLine();

                if(i == g)
                {
                    Console.WriteLine("\nAcceso concedido.");
                    return;
                }
                else
                {
                    intentos--;
                    Console.WriteLine("\nContraseña incorrecta. Intentos restantes: "+(intentos));
                }
            }
            Console.WriteLine("\nAcceso denegado. Cerrando programa!");
        }
    }
}
