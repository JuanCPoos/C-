using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_6_Ej_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, diferencia;
            float producto, division;
            string linea;

            Console.WriteLine("Ingrese el primer valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
                Console.WriteLine("El resultado de la resta es: " + (num1 - num2));                
            }
            else if (num2 > num1)
            {
                
                Console.WriteLine("El resultado de la producto es: " + (num2 * num1));
                Console.WriteLine("El resultado de la división es: " + (num2 / num1));                
            }
            Console.ReadKey();


        }
    }
}
