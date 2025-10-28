using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 50, 6, 3, 7, 20 };

            Console.Write("Números: ");

            foreach (int i in num)
                Console.Write(i + " ");

            int minimo = num[0];
            int maximo = num[0];

            for(int i = 1;i < num.Length; i++)
            {
                if (num[i] < minimo)
                    minimo = num[i];
                if(num[i] > maximo)
                    maximo = num[i];
            }

            Console.WriteLine("\nMínimo: " + minimo);
            Console.WriteLine("Máximo: " + maximo);
        }
    }
}
