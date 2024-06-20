using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;


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
                        Console.WriteLine("Position: " + i + ", " + j);
                        Console.WriteLine("Left: " + matriz[i,j-1]);
                        Console.WriteLine("Rigth: " + matriz[i, j + 1]);
                        Console.WriteLine("Down: " + matriz[i+1, j]);
                        Console.WriteLine("Up: " + matriz[i-1,j]);
                        Console.WriteLine();

                    }

                }
            }



        }
    }
}
