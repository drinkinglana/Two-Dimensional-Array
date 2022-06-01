using System;

namespace Arreglo_Bidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] coordenadas = new string[6, 6];

            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    string X = Convert.ToString(x);
                    string Y = Convert.ToString(y);
                    string coordenada = "(" + x + "," + y + ")";
                    coordenadas[x, y] = coordenada;
                }
            }

            ImprimeMatriz(coordenadas);
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            do
            {
                for (int y = 0; y < 6; y++)
                {
                    for (int x = 0; x < 6; x++)
                    {
                        string X = Convert.ToString(x);
                        string Y = Convert.ToString(y);
                        string coordenada = "(" + x + "," + y + ")";
                        ImprimeMatriz(coordenadas, coordenada);
                        keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                        }
                    }
                }
            } while (keyInfo.Key == ConsoleKey.Enter);
        }

        public static void ImprimeMatriz(string[,] coordenadas)
        {
            for (int y = 5; y >= 0; y--)
            {
                for (int x = 0; x < 6; x++)
                {
                    Console.Write(coordenadas[x, y]);
                    Console.Write("  ");
                }
                Console.WriteLine("\n");
                Console.WriteLine();
            }
        }

        public static void ImprimeMatriz(string[,] coordenadas, string coordenada)
        {
            for (int y = 5; y >= 0; y--)
            {
                for (int x = 0; x < 6; x++)
                {
                    if (coordenada == coordenadas[x, y])
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(coordenadas[x, y]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(coordenadas[x, y]);
                    }
                    Console.Write("  ");
                }
                Console.WriteLine("\n");
                Console.WriteLine();
            }
        }
    }
}
