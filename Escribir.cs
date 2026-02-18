
using System;

namespace ManejoDeArreglos1
{
    public class Escribir
    {
        public static int F_suma(int[,] Array, int suma, int f, int v)
        {
            Variables.Array[f, 5] = Variables.suma;
            Console.Write(" = " + Variables.Array[f, 5]);
            return (Variables.suma = 0);
        }
    }
}