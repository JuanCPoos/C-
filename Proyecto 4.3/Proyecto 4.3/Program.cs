using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma;
            float promedio;
            string linea;

            Console.WriteLine("Ingres valor 1: ");
            linea= Console.ReadLine();
            num1= int.Parse(linea);

            Console.WriteLine("Ingres valor 2: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("Ingres valor 3: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.WriteLine("Ingres valor 4: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            Console.WriteLine("suma de los valores: " + suma);
            Console.WriteLine("promedio de los valores: " + promedio);
            Console.ReadKey();





        }
    }
}
