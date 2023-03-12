using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ10817
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int[] n = new int[3];
            
            for(int i = 0; i < 3; i++)
            {
                n[i] = Int32.Parse(s[i]);
            }
            Array.Sort(n);
            Console.WriteLine(n[1]);
        }
    }
}
