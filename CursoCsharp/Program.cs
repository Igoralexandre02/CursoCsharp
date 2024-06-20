using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;


namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de linhas: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Número de colunas: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }

            int Pos = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Pos == matriz[i, j])
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        if (i > 0)
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        if (j < n - 1)
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        if (i < m - 1)
                            Console.WriteLine("Down: " + matriz[i + 1, j]);

                    }
                }
            }
        }
    }
}
