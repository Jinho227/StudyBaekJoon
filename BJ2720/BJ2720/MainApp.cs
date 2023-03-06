using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ2720
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] t = new int[n];
            int[] c = new int[4];

            for(int i = 0; i < n; i++)
            {
                t[i] = Int32.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                c[0] = t[i] / 25;
                c[1] = (t[i] % 25) / 10;
                c[2] = ((t[i] % 25) % 10) / 5;
                c[3] = t[i] % 5;
                Console.WriteLine(c[0] + " " + c[1] + " " + c[2] + " " + c[3]);
            }
        }
    }
}
