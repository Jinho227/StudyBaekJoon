using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ10988
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] c = new char[s.Length];
            int a = 1;
            int i = 0;
            foreach(char temp in s)
            {
                c[i] = temp;
                i++;
            }
            for(i = 0; i < s.Length; i++)
            {
                if(c[i] != c[s.Length - (i + 1)])
                {
                    a = 0;
                    break;
                }
            }
            Console.WriteLine(a);
        }
    }
}
