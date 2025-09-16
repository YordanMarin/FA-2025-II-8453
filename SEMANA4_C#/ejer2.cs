using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            int annio = int.Parse(Console.ReadLine());

            if (annio % 4==0 && annio %100 != 0 || annio %400 ==0)
            {
                Console.WriteLine("Año bisiesto");
            }
            else
            {
                Console.WriteLine("Año no bisiesto");
            }

            if(annio % 2 == 0)
            {
                Console.WriteLine("Año par");
            }
            else
            {
                Console.WriteLine("Año impar");
            }
            Console.ReadKey();
        }
    }
}
