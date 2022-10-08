using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1712
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] temp = new string[3];
            int a, b, c;
            long i = 0;
            temp = Console.ReadLine().Split();
            a = int.Parse(temp[0]);
            b = int.Parse(temp[1]);
            c = int.Parse(temp[2]);

            if( b >= c)
            {
                Console.WriteLine(-1);
            }
            else
            {
                if(a % (c - b) == 0)
                    i = (a / (c - b)) + 1;
                else
                    i = (a / (c - b)) + 1;
                Console.WriteLine(i);
            }
        }
    }
}
