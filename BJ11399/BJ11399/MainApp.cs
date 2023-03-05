using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ11399
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] t = new int[n];
            string[] s = Console.ReadLine().Split();
            int sum = 0;
            int total = 0;

            for(int i = 0; i < n; i++)
            {
                t[i] = Int32.Parse(s[i]);
            }

            Array.Sort(t);

            for(int i = 0; i < n; i++)
            {
                sum += t[i];
                total += sum;
            }

            Console.WriteLine(total);
        }
    }
}
