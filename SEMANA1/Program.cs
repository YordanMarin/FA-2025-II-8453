using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey(); //detenimiento de consola
        }

        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso " +
                $"de Fundamentos de Algoritmo de la carrera {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Yordan\"");
        }

        static void ejer3()
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("Suma: "+(num1+num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicación: " + (num1 * num2));
            Console.WriteLine("División: " + divi);
        }

        static void ejer4()
        {
            Console.Write("Ingrese un número decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(num);
            double redo = Math.Round(num,2);
            double cubo = Math.Pow(num,3);
            double cubica = Math.Pow(num,1/3d);

            Console.WriteLine("Raiz cuadrada: " + raiz);
            Console.WriteLine("Redondeado: " +redo);
            Console.WriteLine("Elevado a 3: " + cubo);
            Console.WriteLine("Raiz cubica: " + cubica);
        }

        static void ejer5()
        {

        }

        static void ejer6()
        {

        }
    }
}
