using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BJ1541
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(-)|(\+)");
            string[] s = regex.Split(Console.ReadLine());
            bool m = false;
            int sum = 0;
            foreach(string result in s)
            {
                if(result == "+")
                {

                }
                else if(result == "-")
                {
                    m = true;
                }
                else
                {
                    if(m == true)
                    {
                        sum -= Int32.Parse(result);
                    }
                    else
                    {
                        sum += Int32.Parse(result);
                    }
                }

            }
            Console.WriteLine(sum);
        }
    }
}
