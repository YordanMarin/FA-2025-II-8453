using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class Estudiantes
    {
        string[] nombres = new string[0];
        byte[] edades = new byte[0];
        int pos = 0;

        public void insertar()
        {
            string seguir;
            while (true)
            {
                Array.Resize(ref nombres, nombres.Length + 1);
                Array.Resize(ref edades, edades.Length + 1);

                Console.Write("\nIngrese nombre: ");
                nombres[pos] = Console.ReadLine();
                Console.Write("Ingrese edad: ");
                edades[pos] = byte.Parse(Console.ReadLine());
                pos++;
                Console.WriteLine("\nSe registro correctamente");

                while (true)
                {
                    Console.Write("\n¿Desea seguir registando? (S/N): ");
                    seguir = Console.ReadLine();
                    if (seguir == "s" || seguir == "n") break;
                    else Console.WriteLine("Opción no valida\n");
                }
                if (seguir == "n") break;
            }
        }

        public void mostrar()
        {
            Console.WriteLine("\nPOS\tNOMBRE\t\tEDAD");
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{i}\t{nombres[i]}\t\t{edades[i]}");
            }
        }

        public int buscar(string nom)
        {
            for(int i = 0;i < nombres.Length; i++)
            {
                if (nom == nombres[i])
                    return i;
            }
            return -1;
        }

        public void modificar()
        {
            Console.Write("\nIngrese el nombre a modificar: ");
            string nom = Console.ReadLine();

            int indice = buscar(nom);

            if (indice != -1)
            {
                Console.Write("\nIngrese el nuevo nombre: ");
                nombres[indice] = Console.ReadLine();
                Console.Write("Ingrese la nueva edad: ");
                edades[indice] = byte.Parse(Console.ReadLine());
            }
            else Console.WriteLine("No existe");
        }

        public void eliminar()
        {
            Console.Write("\nIngrese el nombre a eliminar: ");
            string nom = Console.ReadLine();

            int indice = buscar(nom);

            if (indice != -1)
            {
                for(int i = indice;  i < nombres.Length-1; i++)
                {
                    nombres[i] = nombres[i + 1];
                    edades[i] = edades[i + 1];
                }
                Array.Resize(ref nombres, nombres.Length -1);
                Array.Resize(ref edades, edades.Length -1);
                pos--;
            }
            else Console.WriteLine("No existe");
        }
    }
}
