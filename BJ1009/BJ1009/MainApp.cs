using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1009
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int number;
            int[,] s;
            number = int.Parse(Console.ReadLine());
            s = new int[number, 2];
            int a = 1;
            for(int i = 0; i < number; i++)
            {
                string[] temp = Console.ReadLine().Split();
                s[i, 0] = int.Parse(temp[0]);
                s[i, 1] = int.Parse(temp[1]);
            }

            for (int i = 0; i < number; i++)
            {
                for(int j = 1; j <= s[i, 1]; j++)
                {
                    a = (s[i, 0] * a) % 10;
                }
                if (a % 10 == 0)
                    Console.WriteLine(10);
                else
                    Console.WriteLine(a);
                a = 1;
            }
                
        }
    }
}
