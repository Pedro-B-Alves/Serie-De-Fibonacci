using System;

namespace Serie_De_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1, t2, t3;
            Console.WriteLine("Série De Fibonacci até que o valor seja maior que 500");
            t1 = 0;
            t2 = 1;
            t3 = 1;
            Console.WriteLine($"{t1}\r\n{t2}");
            while(t3 < 500)
            {
                t3 = t1 + t2;
                Console.WriteLine(t3);
                t1 = t2;
                t2 = t3;
            }
        }
    }
}
