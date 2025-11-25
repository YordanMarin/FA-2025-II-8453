using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tañana de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tañana de columnas: ");
            int colum = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, colum];
            Random rnd = new Random();
            int[] suma = new int[colum];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    matriz[i, j] = rnd.Next(20, 31);
                    suma[j] += matriz[i, j];
                    Console.Write(matriz[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
            for(int i = 0;i < colum; i++)
            {
                Console.Write(suma[i] + "\t");
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
