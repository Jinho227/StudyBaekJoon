using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ2738
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n, m;
            string[] num = Console.ReadLine().Split();
            n = int.Parse(num[0]);
            m = int.Parse(num[1]);

            int[,] input = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    input[i, j] = int.Parse(temp[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    input[i, j] += int.Parse(temp[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    Console.Write(input[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            return;
        }
    }
}
