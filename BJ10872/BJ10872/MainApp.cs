using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ10872
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            
            int output = 1;
            if (a == 0)
                Console.WriteLine(1);
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    output *= i;
                }
                Console.WriteLine(output);
            }
            
        }
    }
}
