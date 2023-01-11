using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_8_Ej_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int día, mes, año;
            string linea;

            Console.WriteLine("Ingrese el día:");
            día = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año:");
            año = int.Parse(Console.ReadLine());
            
            if(año == DateTime.Now.Year)
            {
                if (mes == 1 || mes == 2 || mes == 3)
                {
                    Console.WriteLine("La fecha ingresada corresponde al primer trimestre del año");
                }
                else
                {
                    Console.WriteLine("La fecha ingresa no corresponde al primer trimestre del año")
                }
            }
            else
            {
                Console.WriteLine("Año no correspondiente");
            }
            

            Console.ReadKey();
        }
    }
}
