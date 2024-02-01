using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите четыре целых числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                if (b % 2 == 0)
                {
                    Console.WriteLine(b);
                }
                if (c % 2 == 0)
                {
                    Console.WriteLine(c);
                }
                if (d % 2 == 0)
                {
                    Console.WriteLine(d);
                }
                Console.ReadLine();
            }
        }
    }
}