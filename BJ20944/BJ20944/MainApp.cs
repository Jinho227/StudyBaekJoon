using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ20944
{
    class MainApp
    {
        static public string fnGetRandomString(int numLength)
        {

            string strResult = "";
            Random rand = new Random();
            string strRandomChar = "abcdefghijklnmopqrstuvwxyz"; //랜덤으로 들어갈 문자 및 숫자 

            StringBuilder rs = new StringBuilder();

            //매개변수로 받은 numLength만큼 데이터를 가져 올 수 있습니다.
            for (int i = 0; i < numLength; i++)
            {
                rs.Append(strRandomChar[(int)(rand.NextDouble() * strRandomChar.Length)]);
            }
            strResult = rs.ToString();

            return strResult;
        }
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            char s = char.Parse(fnGetRandomString(1));
            char t = char.Parse(fnGetRandomString(1));
            char[] str = new char[N];

            if(N % 2 == 0)
            {
               for(int i = 0; i < N; i++)
                {
                    str[i] = s;
                }
            }
            else
            {
                for(int i = 0; i < N; i++)
                {
                    if ((N / 2) == i)
                        str[i] = t;
                    else
                        str[i] = s;
                }
            }
            Console.WriteLine(str);
        }
    }
}
