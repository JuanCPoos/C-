using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_8_Ej_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;

            Console.WriteLine("Ingrese día");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año");
            año = int.Parse(Console.ReadLine());

            if(dia == 25 && mes == 12)
            {
                Console.WriteLine("Es navidad");
            }
            else
            {
                Console.WriteLine("No es navidad");
            }
            Console.ReadKey(); 

        }
    }
}
