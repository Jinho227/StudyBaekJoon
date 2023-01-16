using System;

namespace BJ2740
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int[] N = new int[2];
            int[] M = new int[2];
            for (int i = 0; i < 2; i++)
            {
                N[i] = Convert.ToInt32(s[i]);
            }
            int[,] A = new int[N[0], N[1]];
            for (int i = 0; i < N[0]; i++)
            {
                string[] temp = Console.ReadLine().Split();
                for(int j = 0; j < N[1]; j++)
                {
                    A[i, j] = Convert.ToInt32(temp[j]);
                }
            }
            string[] t = Console.ReadLine().Split();
            for (int i = 0; i < 2; i++)
            {
                M[i] = Convert.ToInt32(t[i]);
            }
            int[,] B = new int[M[0], M[1]];
            for (int i = 0; i < M[0]; i++)
            {
                string[] temp = Console.ReadLine().Split();
                for (int j = 0; j < M[1]; j++)
                {
                    B[i, j] = Convert.ToInt32(temp[j]);
                }
            }

            int[,] AB = new int[N[0], M[1]];
            for (int i = 0; i < N[0]; i++)
            {
                for (int j = 0; j < M[1]; j++)
                {
                    for(int k = 0; k < M[0]; k++)
                    {
                        AB[i,j] += A[i, k] * B[k, j];
                    }
                    Console.Write(AB[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
