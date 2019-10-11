using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6
{
    class ejercicio2 : Validacion
    {
        static void Main(string[] args)
        {
            int ancho, alto,x , y;          
            char caracter;
            #region Ancho                 
            Validar("Ingrese el ancho del rectangulo: ", out ancho);
            #endregion
            #region Alto          
            Validar("Ingrese el alto del rectangulo: ", out alto);
            #endregion
            #region Llamada de funcion 1
            Dibujo(ancho, alto);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Llamada de la sobrecarga de la función
            Console.WriteLine("Ingrese el caracter deseado: ");
            caracter = char.Parse(Console.ReadLine());
            Dibujo(ancho, alto, caracter);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region CoordenadaX   
            Validar("Ingrese la coordenada X: ", out x);
            #endregion
            #region CoordenadaY           
            Validar("Ingrese la coordenada Y: ", out y);
            #endregion
            #region Llamada de la sobrecarga de la funciòn 2
            Console.Clear();
            Dibujo(ancho, alto, caracter, x, y);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();           
        }
        #endregion


        #region Funcion1
        static void Dibujo(int alto, int ancho)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine(" ");
                Console.Write(" ");
                for (int j = 0; j < ancho; j++)
                {                    
                    Console.Write("*");
                    Console.Write(" ");
                }
            }
        }
        #endregion

        #region Sobrecarga1
        static void Dibujo(int alto, int ancho, char caracter)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine(" ");
                Console.Write(" ");
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write(caracter);
                    Console.Write(" ");
                }
            }
        }
        #endregion

        #region Sobrecarga2
        static void Dibujo(int alto, int ancho, char caracter, int x, int y)
        {         
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine(" ");
                Console.Write(" ");
                Console.SetCursorPosition(x, y++);
                for (int j = 0; j < ancho; j++)
                {                    
                    Console.Write(caracter);
                    Console.Write(" ");
                }
            }
        } 
        #endregion
    }
}
