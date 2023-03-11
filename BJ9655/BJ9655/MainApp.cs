using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ9655
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine("CY");
            }
            else
            {
                Console.WriteLine("SK");
            }
        }
    }
}
