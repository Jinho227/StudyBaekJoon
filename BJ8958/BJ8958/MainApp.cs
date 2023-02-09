using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ8958
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            string[] s = new string[n];
            int[] sum = new int[n];
            for(int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
                sum[i] = 0;
                int j = 0;
                foreach(char c in s[i])
                {
                   if(c == 'O')
                    {
                        sum[i] += ++j;
                    }
                    else
                    {
                        j = 0;
                    }
                        
                }
            }    
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}
