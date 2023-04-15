using System;

namespace Geminus
{
    class Program
    {
        static int n = 5;
        static void Main(string[] args)
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

    }
}
