using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1152
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();

            int number = temp.Length;
            if (temp[0] == "")
                number -= 1;
            if (temp[(temp.Length - 1)] == "")
                number -= 1;
            Console.WriteLine(number);
        }
    }
}
