using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6
{
    class ejercicio3 : Validacion
    {
        static void Main(string[] args)
        {
            int bases=0, exponente=0;            
            #region Base                      
            Validar("Ingrese la base: ", out bases);
            #endregion
            #region Exponente           
            Console.WriteLine();
            Validar("Ingrese el exponente: ", out exponente);
            #endregion
            Console.WriteLine(NumElevado(2,4));
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
        }

        #region Funcion
        static int NumElevado(int bases, int exponente)
        {
            if (exponente < 1)
            {
                return 1;
            }
            return bases * NumElevado(bases, exponente - 1);
        } 
        #endregion
    }
}
     
