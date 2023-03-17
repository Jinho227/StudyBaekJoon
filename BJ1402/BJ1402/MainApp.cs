using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1402
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            string[] s = new string[n];

            /* 모든 것이 yes이기 때문에 */
            for(int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("yes");
            }

        }
    }
}
