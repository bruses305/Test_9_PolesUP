using System;

namespace Test_9_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Введите год : ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a % 4 == 0 && a % 100 != 0)
                {
                    Console.WriteLine(a + " - true");
                }
                else
                {
                    Console.WriteLine(a + " - false");
                }
            }
        }
    }
}
