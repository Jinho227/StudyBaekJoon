using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1076
{
    class MainApp
    {
        public struct Ohm
        {
            public string color;
            public int value;
            public int multiply;

            public Ohm(string color, int value, int multiply)
            {
                this.color = color;
                this.value = value;
                this.multiply = multiply;
            }
        }

        static void Main(string[] args)
        {
            Ohm[] ohm = new Ohm[] {
                new Ohm {color = "black", value = 0, multiply = 1 },
                new Ohm {color = "brown", value = 1, multiply = 10 },
                new Ohm {color = "red", value = 2, multiply = 100 },
                new Ohm {color = "orange", value = 3, multiply = 1000 },
                new Ohm {color = "yellow", value = 4, multiply = 10000 },
                new Ohm {color = "green", value = 5, multiply = 100000 },
                new Ohm {color = "blue", value = 6, multiply = 1000000 },
                new Ohm {color = "violet", value = 7, multiply = 10000000 },
                new Ohm {color = "grey", value = 8, multiply = 100000000 },
                new Ohm {color = "white", value = 9, multiply = 1000000000 }
            };

            string temp;
            long value = 0;
            temp = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (temp == ohm[i].color)
                {
                    value = ohm[i].value * 10;
                    break;
                }
            }
            temp = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (temp == ohm[i].color)
                {
                    value += ohm[i].value;
                    break;
                }
            }
            temp = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (temp == ohm[i].color)
                {
                    value *= ohm[i].multiply;
                    break;
                } 
            }
            Console.WriteLine(value);
        }
    }
}
