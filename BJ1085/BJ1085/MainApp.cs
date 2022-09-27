using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1085
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int x, y, w, h;
            string[] s = Console.ReadLine().Split();
            x = int.Parse(s[0]);
            y = int.Parse(s[1]);
            w = int.Parse(s[2]);
            h = int.Parse(s[3]);

            int D = x - 0;
            if (D > y - 0)
                D = y - 0;
            if (D > w - x)
                D = w - x;
            if (D > h - y)
                D = h - y;
            Console.WriteLine(D);



        }
    }
}
