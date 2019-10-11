using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            Validacion.Validar("Ingrese un número y se convertira a decimal", out int num);
            DecimalaBinario(num);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();
            
        }

    static void DecimalaBinario(int num) 
    {
            if (num < 2)
            {
                Console.Write(num);
            }            
            else
            {
                DecimalaBinario(num / 2);
                Console.Write(num % 2);               
            }
        }
  }
}
