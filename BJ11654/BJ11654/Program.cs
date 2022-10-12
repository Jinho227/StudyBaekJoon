using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ11654
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            byte[] b = Encoding.Default.GetBytes(a);
            Console.WriteLine(b[0]);
        }
    }
}
