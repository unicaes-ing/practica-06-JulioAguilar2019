using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6
{
    public class Validacion
    {
        public static void Validar(string mensaje, out int num)
        {
            bool condicion;
            do
            { Console.Clear();
                Console.WriteLine(mensaje);
                condicion = int.TryParse(Console.ReadLine(), out num);
                if (condicion == false || num < 0)
                {
                    Console.WriteLine("Valor no válido. Introduzca nuevamente un valor.");
                    Console.WriteLine("Presione <Enter> para continuar...");
                    Console.ReadKey();
                }
            } while (condicion == false || num < 0);
        }

        public static void Validar(string mensaje, double num = 0)
        {
            bool condicion;
            do
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                condicion = double.TryParse(Console.ReadLine(), out num);
                if (condicion == false || num < 0)
                {
                    Console.WriteLine("Valor no válido. Introduzca nuevamente un valor.");
                    Console.WriteLine("Presione <Enter> para continuar...");
                    Console.ReadKey();
                }
            } while (condicion == false || num < 0);                
        }

    }

}
