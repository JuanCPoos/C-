using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;

            Console.WriteLine("ingrese un valor para num 1: ");
            linea = Console.ReadLine();
            num1= int.Parse(linea);

            Console.WriteLine("ingrese un valor para num 2: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
            {
                Console.WriteLine("El mayor número ingresado es: " + num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("El mayor número ingresado es: " + num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los valores ingresados son iguales");
            }
            Console.ReadKey();  

        }
    }
}
