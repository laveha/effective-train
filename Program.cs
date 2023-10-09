// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int a, e;
        double b, c, d;
        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");

            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неверный выбор. Пожалуйста, выберите одну из операций (1-9).");
                continue;
            }

            switch (a)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    c = double.Parse(Console.ReadLine());
                    d = b + c;
                    Console.WriteLine($"Результат: {d}");
                    break;
                case 2:
                    Console.Write("Введите первое число: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    c = double.Parse(Console.ReadLine());
                    d = b - c;
                    Console.WriteLine($"Результат: {d}");
                    break;
                case 3:
                    Console.Write("Введите первое число: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    c = double.Parse(Console.ReadLine());
                    d = b * c;
                    Console.WriteLine($"Результат: {d}");
                    break;
                case 4:
                    Console.Write("Введите первое число: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    c = double.Parse(Console.ReadLine());
                    if (c == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                    }
                    else
                    {
                        d = b / c;
                        Console.WriteLine($"Результат: {d}");
                    }
                    break;
                case 5:
                    Console.Write("Введите число: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    e = int.Parse(Console.ReadLine());
                    d = Math.Pow(b, e);
                    Console.WriteLine($"Результат: {d}");
                    break;
                case 6:
                    Console.Write("Введите число: ");
                    b = double.Parse(Console.ReadLine());
                    if (b < 0)
                    {
                        Console.WriteLine("Ошибка: нельзя извлекать корень из отрицательного числа.");
                    }
                    else
                    {
                        d = Math.Sqrt(b);
                        Console.WriteLine($"Результат: {d}");
                    }
                    break;
                case 7:
                    Console.Write("Введите число: ");
                    b = double.Parse(Console.ReadLine());
                    d = b / 100;
                    Console.WriteLine($"Результат: {d}");
                    break;
                case 8:
                    Console.Write("Введите число: ");
                    b = double.Parse(Console.ReadLine());
                    {
                        if (b == 0)
                            d = 1;
                        else if (b == 1)
                            d = 1;
                        else
                            d = b * (b - 1);
                    }
                    Console.WriteLine($"Результат: {d}");
                    break;
                case 9:
                    Console.WriteLine("Выход из программы.");
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите одну из операций (1-9).");
                    break;
            }
        } while (a != 9);
    }


}
