using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2;
            while (true)
            {
                Console.Write("Ingrese nombre 1: ");
                nom1 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom1)) break;
                else Console.WriteLine("No se permiten vacios.\n");
            }
            while (true) 
            { 
                Console.Write("Ingrese nombre 2: ");
                nom2 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom2)) break;
                else Console.WriteLine("No se permiten vacios.\n");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nCantidad de caracteres nombre1: "+nom1.Length);
            Console.WriteLine("Cantidad de caracteres nombre2: " + nom2.Length);
            Console.WriteLine("Nombre 1 en mayusculas: " + nom1.ToUpper());
            Console.WriteLine("Nombre 2 en minusculas: " + nom2.ToLower());
            if (nom1.CompareTo(nom2) == 0)
                Console.WriteLine("Nombre 1 y Nombre 2 son iguales");
            else Console.WriteLine("Nombre 1 y Nombre 2 no son iguales");
            if (nom1.Contains("an")) Console.WriteLine("Si existe 'an'");
            else Console.WriteLine("No existe 'an'");
            if (nom1.IndexOf("a") != -1)
                Console.WriteLine("La primera 'a' posición es: " + nom1.IndexOf("a"));
            else Console.WriteLine("No existe 'a'");
            if (nom2.LastIndexOf("a") != -1)
                Console.WriteLine("La ultima 'a' posición es: " + nom2.LastIndexOf("a"));
            else Console.WriteLine("No existe 'a'");
            Console.WriteLine("Insertando 'upn' en nombre 1: " + nom1.Insert(0,"UPN"));
            Console.WriteLine("Insertando 'sistemas' en nombre 2: " + nom2.Insert(nom2.Length, "SISTEMAS"));
            if (nom1.Length > 5) 
                Console.WriteLine("Eliminando caracteres desde 5 pos: "+nom1.Remove(5));
            else Console.WriteLine("No tiene mas de 5 caracteres nombre 1");
            if (nom1.Contains("a"))
                Console.WriteLine("reemplanzo a por @:" + nom1.Replace("a", "@"));
            else Console.WriteLine("No existe la 'a'");

            if (nom1.Contains("a"))
            {
                string[] partes = nom1.Split('a');
                Console.Write("División de partes de nombre 1: ");
                for (int i = 0; i < partes.Length; i++)
                    Console.Write(partes[i] +" -> ");
            }
            else Console.WriteLine("No existe la 'a'");

            if (nom2.Length > 4)
                Console.WriteLine("Sub cadena nombre 2:" + nom2.Substring(4));
            else Console.WriteLine("Nombre 2 no tiene mas de 4 caracteres");

            char[] arreglo = nom1.ToCharArray();
            for (int i = 0; i < arreglo.Length; i++)
                Console.WriteLine(arreglo[i]);

            Console.Write("Nombre1 en reversa: ");
            for (int i = arreglo.Length-1; i >=0; i--)
                Console.Write(arreglo[i]);

            Array.Sort(arreglo);
            Console.Write("\nNombre1 ordenado: ");
            for (int i = 0; i < arreglo.Length; i++)
                Console.Write(arreglo[i]);
            Console.ReadKey();
        }
    }
}
