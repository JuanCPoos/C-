﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            string linea;

            Console.WriteLine("Ingrese su sueldo: ");
            linea= Console.ReadLine();

            sueldo = float.Parse(linea);
            if(sueldo > 3000){
                Console.WriteLine("Esta persona debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("Esta persona no debe abonar impuestos");
            }
            Console.ReadKey(); 

        }
    }
}
