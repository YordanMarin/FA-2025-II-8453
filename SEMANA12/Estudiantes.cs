using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA12
{
    internal class Estudiantes
    {
        byte[] edades = new byte[0];
        int cantidad = 0;
        public void registrar()
        {
            Array.Resize(ref edades, edades.Length+1);
            byte ed;
            while (true)
            {
                Console.Write("\nIngrese la edad del estudiante: ");
                if (byte.TryParse(Console.ReadLine(), out ed) && ed >= 14 && ed <= 120) break;
                else Console.WriteLine("Ingrese una edad correcta!\n");
            }

            edades[cantidad] = ed;
            cantidad++;
            Console.WriteLine("\nEdad registrado correctamente.");
        }

        public void mostrar()
        {
            Console.WriteLine();
            Console.Write("POS" + "\t");
            Console.Write("EDAD"+"\n");

            for (int i = 0; i < edades.Length; i++)
            {
                Console.Write(i+"\t");
                Console.Write(edades[i]+"\n");
            }
        }

        public void eliminar()
        {
            int indice = -1;

            Console.Write("\nIngrese la edad a eliminar: ");
            byte eli = byte.Parse(Console.ReadLine());

            for(int i = 0;i < edades.Length; i++)
            {
                if (edades[i] == eli)
                    indice = i;
            }

            if (indice != -1)
            {
                for(int j = indice;j<edades.Length-1; j++)
                {
                    edades[j] = edades[j+1];
                }
                Array.Resize(ref edades,edades.Length-1);
                cantidad--;

                Console.WriteLine("\nEliminado correctamente.");
            }
            else Console.WriteLine("\nNo se puede eliminar porque no existe.");
        }

        public void ordenar()
        {
            for(int i = 0;i < edades.Length - 1; i++)
            {
                for(int j=0; j < edades.Length - i - 1; j++)
                {
                    if (edades[j] < edades[j + 1])
                    {
                        byte temp = edades[j];
                        edades[j] = edades[j + 1];
                        edades[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nSe ordeno correctamnete.");
        }
    }
}
