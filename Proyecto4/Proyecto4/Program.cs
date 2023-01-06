using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            string linea;

            Console.WriteLine("Ingrese el primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el valor 2:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            suma = num1+ num2;
            producto = num1 * num2;
            Console.WriteLine("El resultado de la suma es: " + suma);
            Console.WriteLine("El resultado de la multiplicación es: " + producto);
            Console.ReadKey();  
        }
    }
}
