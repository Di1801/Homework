using System;

namespace Arithmetic_Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t=====Вычисление суммы арифметической прогрессии=====\n\n");
            Console.ResetColor();
            int a1;
            int d;
            int n;
            int sum;
            do
            {
                try
                {
                    Console.WriteLine("\nВведите первый элемент арифметической прогрессии: ");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите разность арифметической прогрессии: ");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число элементов арифметической прогрессии: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    sum = (a1 + (a1 + d * (n - 1))) * n / 2;
                    Console.Write("Сумма членов прогрессии равна:  ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(sum);
                    Console.ResetColor();
                    Console.WriteLine("\nВыберите пункт меню: ");
                    Console.WriteLine("1-Продолжить \n2-Выход ");
                    int menuChoise = int.Parse(Console.ReadLine());
                    if (menuChoise == 2)
                        Environment.Exit(0);
                    else
                        continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                }
            } while (true);
        }
    }
}
