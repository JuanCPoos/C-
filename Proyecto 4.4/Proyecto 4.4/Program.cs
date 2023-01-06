using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio, total;
            int cantArticulo;
            string nomProducto, linea;

            Console.WriteLine("Qué artículo quiere cobrar: ");
            nomProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio de: " + nomProducto);
            linea = Console.ReadLine();
            precio = double.Parse(linea);

            Console.WriteLine("Qué cantidad desea cargar? ");
            linea= Console.ReadLine();
            cantArticulo = int.Parse(linea);

            total = cantArticulo * precio;
            Console.WriteLine("Total a cobrar: " + total);
            Console.ReadKey();  


        }
    }
}
