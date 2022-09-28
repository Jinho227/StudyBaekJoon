using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1546
{
    class MainApp
    {
        
        static void Main(string[] args)
        {
            string numbers;
            int number;
            double sum = 0;
            double Max = 0;
            double[] score = new double[1000];
            numbers = Console.ReadLine();
            number = int.Parse(numbers);
            string[] arr = Console.ReadLine().Split();

            for (int i = 0; i < number; i++)
            {
                score[i] = double.Parse(arr[i]);
                if (Max < score[i])
                    Max = score[i];
                sum += score[i];
            }
            Console.WriteLine(sum / Max * 100 / number);

            return;
        }
    }
}
