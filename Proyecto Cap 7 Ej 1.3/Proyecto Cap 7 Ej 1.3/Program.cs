using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_7_Ej_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, bandera;
            int[] valores;
            string linea;

            Console.WriteLine("Presione 1 para iniciar, 0 para salir del programa: ");
            bandera = int.Parse(Console.ReadLine());
                        
            while (bandera == 1)
            {
                Console.WriteLine("Ingrese un valor: ");
                numero = int.Parse(Console.ReadLine()); 

                if (numero >= 0)
                {
                    if (numero < 10)
                    {
                        Console.WriteLine("Valor de un dígito.");
                    }
                    else if (numero < 100)
                    {
                        Console.WriteLine("Valor de dos dígitos.");
                    }
                    else if (numero < 1000)
                    {
                        Console.WriteLine("Valor de tres dígitos.");
                    }
                }
                else
                {
                    Console.WriteLine("¡ Atención ! - Valor incorrecto");
                }

                Console.WriteLine("Para continuar presione 1, para salir 0");
                bandera = int.Parse(Console.ReadLine());
            }
            

            /*Intentar con Iterador FOR
                * for (int i = 0; i < 3; i++)
               {
                   Console.WriteLine("dentro del for: " + i);
               }*/

        }
    }
}
