using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cap_6_Ej_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            string linea, alumno;
            float promedio;

            Console.Write("Ingrese el nombre del alumno:");
            alumno = Console.ReadLine();

            Console.WriteLine("Ingrese nota 1 del alumno: ");
            nota1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese nota 2 del alumno: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota 3 del alumno: ");
            nota3 = int.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Promedio de " + alumno + ": " + promedio);

            if (promedio >= 7)
            {
                Console.WriteLine("El alumno " + alumno + " se encuentra Promocionado");
            }
            else
            {
                Console.WriteLine("El alumno no alcanzo la Promoción");
            }
            Console.ReadKey();  



        }
    }
}
