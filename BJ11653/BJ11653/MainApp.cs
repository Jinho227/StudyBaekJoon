using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ11653
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] output = new int[100];
            int i = 0;
            int j;
            while(input != 1)
            {
                j = 2;
                do
                {
                    if (input % j != 0)
                    {
                        j++;
                    }
                    else
                    {
                        output[i++] = j;
                        input /= j;
                        break;
                    }
                }
                while (true);
            }

            for(int k = 0; k < i; k++)
            {
                Console.WriteLine(output[k]);
            }
        }
    }
}
