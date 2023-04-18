using System;
using System.Collections.Generic;

namespace Geminus
{
    class Program
    {
        static readonly int n = 5;
        static readonly int[] myArray = new int[] { 1, 2 };

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");

            Ejercicio1(n);

            Console.WriteLine("Ejercicio 2");

            Ejercicio2(myArray);
        }

        public static void Ejercicio1(int n)
        {

            string lastString = "_";
            string nextString = "X";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (nextString == "X")
                    {
                        Console.Write("X");
                        lastString = "X";
                        nextString = "_";
                    }
                    else
                    {
                        Console.Write("_");
                        lastString = "_";
                        nextString = "X";

                    }

                }
                Console.WriteLine();
                if (lastString == "X")
                    nextString = "_";
                else if (lastString == "_")
                    nextString = "X";
            }
        }
        
        public static void Ejercicio2(int[] myArray)
        {
            string[,] matriz = new string[4, 4];

            //Dibujar con X
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = "X";
                }
            }

            int posI = 0;
            int posJ = 0;

            matriz[posI, posJ] = "O";

            //Buscar 0
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    matriz[posI, posJ] = "X";
                    posJ += myArray[i];
                    matriz[posI, posJ] = "O";
                }
                else if (i % 2 == 1)
                {
                    matriz[posI, posJ] = "X";
                    posI += myArray[i];
                    matriz[posI, posJ] = "O";
                }
            }

            //Mostrar matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }

        }

        public static void Ejercicio3()
        {
            
        }


    }
}
