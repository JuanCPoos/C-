using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_7_Ej_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, mayor, menor;
            string linea;

            Console.WriteLine("Ingrese el primer número");
            linea= Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el segundo número");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("Ingrese el tercer número");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if(num1 > num2){
                mayor = num1; 
                if(mayor > num3) // Num 1 es el mayor
                {
                    Console.WriteLine("El número mayor es: " + mayor);
                }
                else
                {
                    mayor = num3;
                    Console.WriteLine("El número mayor es: " + mayor);
                }
            }
            else
            {
                mayor = num2;
                if(mayor > num3) //Num 2 es el mayor
                {
                    Console.WriteLine("El número mayor es: " + mayor);
                }
                else
                {
                    mayor = num3;
                    Console.WriteLine("El número mayor es: " + mayor);
                }
            }
            Console.ReadKey();

        }
    }
}
