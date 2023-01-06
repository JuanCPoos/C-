using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_7_Ej_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int promedio;
            string linea;

            Console.WriteLine("Ingrese el núm 1: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el núm 2: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("Ingrese el núm 3: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            promedio = (num1 + num2 + num3) / 3;

            if(promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                if (promedio >= 4)
                {
                    Console.WriteLine("Regular");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
                
            Console.ReadKey();

        }
    }
}
