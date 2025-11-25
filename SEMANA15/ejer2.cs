using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de matriz: ");
            int ta = int.Parse(Console.ReadLine());

            int[,] matriz = new int[ta,ta];
            Random rnd = new Random();

            for (int i = 0; i < ta; i++)
            {
                for(int j = 0; j < ta; j++)
                {
                    matriz[i,j] = rnd.Next(40,51);
                    Console.Write(matriz[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMATRIZ TRANSPUESTA:");
            int[,] transpuesta = new int[ta, ta];

            for (int i = 0; i < ta; i++)
            {
                for (int j = 0; j < ta; j++)
                {
                    transpuesta[i, j] = matriz[j,i];
                    Console.Write(transpuesta[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
