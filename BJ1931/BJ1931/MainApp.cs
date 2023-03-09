using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1931
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] s = new string[2];
            uint[][] a = new uint[n][];
            uint min = uint.MaxValue;
            uint max = uint.MinValue;
            int j = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                a[i] = new uint[2];
                s = Console.ReadLine().Split();
                a[i][0] = uint.Parse(s[0]);
                a[i][1] = uint.Parse(s[1]);
            }
            IOrderedEnumerable<uint[]> sortedBysecond = a.OrderBy(y => y[1]);
            a = sortedBysecond.ToArray();
            while (true)
            {
                min = uint.MaxValue;
                for (int i = j; i < n; i++)
                {
                    if (min > a[i][1] && max <= a[i][0]) 
                    { 
                        min = a[i][1];
                        j = i;
                    }
                }
                if (uint.MaxValue != min)
                {
                    k++;
                    max = min;
                }
                else
                {

                    break;
                }
            }
            Console.WriteLine(k);
            
        }
    }
}
