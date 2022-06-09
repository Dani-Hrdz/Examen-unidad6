using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SISTEMA_DE_INVENTARIO
{
    class SistemaInventario
    {
        string nombre, descripcion;
        float precio;
        int stok;
        StreamWriter sw = null;
        StreamReader sr = null;
       public void crearArchivo()
        {
            char resp;
            
            try
            {
                sw = new StreamWriter("Productos.txt", true);
                do
                {
                    Console.Clear();
                    Console.Write("Nombre del producto: ");
                    nombre = Console.ReadLine();
                    Console.Write("Descripcion del producto:");
                    descripcion = Console.ReadLine();
                    Console.Write("Precio del producto: ");
                    precio = Single.Parse(Console.ReadLine());
                    Console.Write("Cantidad en stok: ");
                    stok = int.Parse(Console.ReadLine());

                    sw.Write(nombre);
                    sw.Write(descripcion);
                    sw.Write(precio);
                    sw.Write(stok);
                    Console.Write("\n\nDeseas almacenar otro registro (s/n)? ");

                    resp = char.Parse(Console.ReadLine());

                } while ((resp == 'S') || (resp == 's'));
            }
            catch(Exception e)
            {
                Console.WriteLine("\nError: " + e.Message);
                Console.WriteLine("\nRuta: " + e.StackTrace);
            }
            finally
            {
                if (sw != null) sw.Close();
                Console.Write("\nPresione enter para terminar la Escritura de Datos y regresar al Menu.");
                Console.ReadKey();
            }
        }
       
    }
}
