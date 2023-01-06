using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_7_Ej_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, numero;
            string linea;

            Console.WriteLine("Ingrese un valor entero: ");
            linea = Console.ReadLine();

            valor = int.Parse(linea);

            if(valor < 0) {
                Console.WriteLine("El número ingresado es negativo");
            }
            else if(valor == 0)
            {
                Console.WriteLine("El número ingresado es nulo");
            }
            else if(valor > 0)
            {
                Console.WriteLine("El número ingresado es positivo");
            }
            Console.ReadKey();
        }
    }
}
