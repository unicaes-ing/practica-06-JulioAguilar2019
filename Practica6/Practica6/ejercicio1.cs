using System;
using System.Drawing;
//Julio Israel Aguilar Melgar --- 04/09/2019
namespace Practica6
{
    class ejercicio1 : Validacion
    {
        #region MetodoMain
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Tabla de multiplicar");
            #region LlamadaFuncion
            Validar("Ingrese el número que desea:", out num);
            Tabla(num);
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey(); 
            #endregion
            Console.Clear();
            Console.WriteLine("Ingrese el número que desea:");
            Validar("Ingrese el número que desea:", out num);
            Tabla(num, ConsoleColor.Yellow);
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
        } 
        #endregion

        #region Funcion1
        static void Tabla(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }
        }
        #endregion

        #region Funcion2
        static void Tabla(int num, ConsoleColor color)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }
        } 
        #endregion
    }
}
