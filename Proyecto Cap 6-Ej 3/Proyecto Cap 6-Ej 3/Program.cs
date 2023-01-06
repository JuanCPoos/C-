using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_6_Ej_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;

            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());
                        
            if(numero >= 10 && numero < 100) {                  
                Console.WriteLine("El número ingresado es de dos dígitos.");
            }
            else if(numero >= 0 && numero < 10)
            {
                Console.WriteLine("El número ingresado es de un dígito");
            }
            Console.ReadKey();
        }
    }
}
