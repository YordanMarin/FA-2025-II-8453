using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_C_
{
    internal class ejer7
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            Random rnd = new Random();

            Console.Write("\nNúmeros generados: ");
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(1, 51);
                Console.Write(num[i] +" ");
            }

            Console.Write("\n\nIngrese el número a buscar: ");
            int buscar = int.Parse(Console.ReadLine());

            for(int i = 0;i < cant; i++)
            {
                if(num[i] == buscar)
                {
                    Console.WriteLine("Número existe");
                    break;
                }
                else
                {
                    Console.WriteLine("Número no existe");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
