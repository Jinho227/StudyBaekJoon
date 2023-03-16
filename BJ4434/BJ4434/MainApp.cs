using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ4434
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[][] s = new string[n][];
            int[][] num = new int[n][];
            int[] sum = new int[n];
            double[] avg = new double[n];
            int temp;
            int p = 0;
            for(int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine().Split();
                sum[i] = 0;
                temp = Int32.Parse(s[i][0]);
                num[i] = new int[temp + 1];
                num[i][0] = Int32.Parse(s[i][0]);
                for(int j = 1; j <= num[i][0]; j++)
                {
                    num[i][j] = Int32.Parse(s[i][j]);
                    sum[i] += num[i][j];
                }
                avg[i] = sum[i] / num[i][0];
                for(int j = 1; j <= num[i][0]; j++)
                {
                    if((double)num[i][j] > avg[i])
                    {
                        p++;
                    }
                }
                avg[i] = (double)p / num[i][0] * 100;
                p = 0;
            }
            foreach(double c in avg)
            {
                Console.WriteLine(string.Format("{0:0.000}%", c));
            }
            
            
        }
    }
}
