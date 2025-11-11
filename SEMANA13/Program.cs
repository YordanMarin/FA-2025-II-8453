using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conti;
            Estudiantes e = new Estudiantes();
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE EDADES\n");
                Console.WriteLine("********** Menú de opciones*********");
                Console.WriteLine("*   1. Insertar                    *");
                Console.WriteLine("*   2. Mostrar                     *");
                Console.WriteLine("*   3. Buscar                       *");
                Console.WriteLine("*   4. Modificar                   *");
                Console.WriteLine("*   5. Eliminar                    *");
                Console.WriteLine("*   6. Ordenar                     *");
                Console.WriteLine("*   0. Salir                       *");
                Console.WriteLine("************************************\n");

                int opc;

                while (true)
                {
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opc) && opc >= 0 && opc <= 6) break;
                    else Console.WriteLine("Ingrese una opción correcta!\n");
                }

                switch (opc)
                {
                    case 0: return;
                    case 1: e.insertar(); break;
                    case 2: e.mostrar(); break;
                    case 3:
                        e.mostrar();
                        Console.Write("\nIngrese el nombre a buscar: ");
                        string buscar = Console.ReadLine();
                        int indice = e.buscar(buscar);
                        if (indice != -1)
                            Console.WriteLine($"\n{buscar} esta en la posición {indice}");
                        else Console.WriteLine($"\n{buscar} no existe");
                            break;
                    case 4: 
                        e.mostrar();
                        e.modificar();
                        e.mostrar();
                        break;
                    case 5:
                        e.mostrar();
                        e.eliminar();
                        e.mostrar();
                        break;
                    case 6: break;
                }

                while (true)
                {
                    Console.Write("\n¿Deseas regresar al menú? (S/N): ");
                    conti = Console.ReadLine();
                    if (conti == "s" || conti == "n") break;
                    else Console.WriteLine("Ingrese una opción correcta!\n");
                }
            } while (conti == "s");
        }
    }
}
