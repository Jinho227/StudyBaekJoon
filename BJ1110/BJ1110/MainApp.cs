using System;

namespace BJ1110
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int temp = Int32.Parse(Console.ReadLine());
            int N = temp;
            int N10;
            int N1;
            int i = 0;
            while (true)
            {
                N10 = N / 10;
                N1 = N % 10;

                N  = (N1 * 10) + ((N10 + N1) % 10);
                i++;
                if (N == temp)
                    break;
            }
            Console.WriteLine(i);
        }
    }
}
