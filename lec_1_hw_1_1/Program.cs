using System;

namespace lec_1_hw_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число 1:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите число 2:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Сумма числа {0} и {1} равна {2}", num1, num2, num1 + num2);
            }
            catch(FormatException)
            {
                Console.WriteLine("Ошибка при вводе чисел!!!");
            }
        }
    }
}
