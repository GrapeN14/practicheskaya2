using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер месяца: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1: Console.WriteLine("Зима \nДекабрь - 31, Январь - 31, Февраль - 29"); break;
                case 2: Console.WriteLine("Весна \nМарт - 31, Апрель - 30, Май - 31"); break;
                case 3: Console.WriteLine("Лето \nИюнь - 30, Июль - 31, Август - 31"); break;
                case 4: Console.WriteLine("Осень \nСентябрь - 30, Октябрь - 31, Ноябрь - 31"); break;
                default: Console.WriteLine("Нет такого времени года"); break;
            }
            Console.ReadLine();
        }
    }
}