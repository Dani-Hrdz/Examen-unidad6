using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SISTEMA_DE_INVENTARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables auxiliares
            
            int option;
            

            //creacion del objeto
            SistemaInventario Si = new SistemaInventario();

            //menu de opciones
            do
            {
                Console.Clear();
                Console.WriteLine("\n---ARCHIVO BINARIO EMPLEADOS---");
                Console.WriteLine("1.- Creacion de un Archivo");
                Console.WriteLine("2.- Lectura de un Archivo");
                Console.WriteLine("3.- Salida del Programa");
                Console.Write("\nQue opcion deseas? ");
                option = Int16.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //bloque de escritura
                            Si.crearArchivo();

                        break;
                    case 2:
                        Console.Clear();
                        Si.LecturaArchivo();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Presione <enter> para salir del Programa");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("Esa Opcion no Existe!!, Presione <enter> para continuar...");
                        Console.ReadKey();
                        break;

                }
            } while (option != 3);
        }
    }
}
