using System;
using System.Collections.Generic;

namespace ManejoDeArreglos1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Variables.Array = new int[5, 6];
            Variables.suma = 0;
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Variables.Array[f, c] = f + c;
                    Variables.suma += Variables.Array[f, c];
                    Console.Write(" " + Variables.Array[f, c]);
                }
                Variables.suma = Escribir.F_suma(Variables.Array, Variables.suma, f, 5);
                Console.Write("\n");
            }
            Console.WriteLine("Presione cualquier tecla para SALIR");
            Console.ReadKey();
        }
    }
}
