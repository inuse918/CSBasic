using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "유" + "채" + "린";
            Console.Write("Hello C#");
            int add = 2;
            int Alpha;

            Console.WriteLine("Hello World");
            Console.Write("Hello World");

            Console.Write(52);
            Console.Write(7 % 3);
            Console.Write('A');
            Console.Write("A");

            Console.WriteLine("김도영\t노래너무잘불렁");
            Console.WriteLine("이상연\n셀카올려");
            Console.WriteLine("\"\"\"");

            Console.WriteLine("이" + "상" + "연");

            int a = 200000000;
            int b = 100000000;
            Console.WriteLine((long)a + b);
            Console.WriteLine((long)a + (long)b);
            Console.WriteLine(a + (long)b);
            Console.WriteLine(a + b);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            var hello = "안녕~";
            string input = Console.ReadLine();
            Console.WriteLine("입력: " + input);
        }
    }
}
