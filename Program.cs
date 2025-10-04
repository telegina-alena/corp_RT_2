using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите шестизначный номер билета: ");
        int ticket = int.Parse(Console.ReadLine()); //считываем ввод и переводим в Int
        // Проверяем корректность ввода
        if (ticket > 1000000 || ticket < 99999)
        {
            Console.WriteLine("Ошибка: введите корректный шестизначный номер");
            return;
        }
        int sumFirst; // сумма первых трех чисел
        int sumLast; //сумма последних трех чисел
        int numb_6 = ticket % 10;
        ticket /= 10;
        int numb_5 = ticket % 10;
        ticket /= 10;
        int numb_4 = ticket % 10;
        ticket /= 10;
        int numb_3 = ticket % 10;
        ticket /= 10;
        int numb_2 = ticket % 10;
        ticket /= 10;
        int numb_1 = ticket % 10;
        ticket /= 10;
        sumFirst = numb_1 + numb_2 + numb_3;
        sumLast = numb_4 + numb_5 + numb_6;
        if (sumFirst == sumLast)
        {
            Console.WriteLine("Билет является счастливым!");
        }
        else
        {
            Console.WriteLine("Билет НЕ является счастливым((");
        }
    }
}

class Program1
{
    static void Main1()
    {
        // Ввод чисел
        Console.Write("Введите числитель M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите знаменатель N: ");
        int n = int.Parse(Console.ReadLine());

        // Находим НОД
        int gcd = FindGCD(m, n);

        // Сокращаем дробь
        int numerator = m / gcd;
        int denominator = n / gcd;

        // Выводим результат
        Console.WriteLine($"Несократимая дробь: {numerator}/{denominator}");
        }

        // Метод для нахождения НОД (алгоритм Евклида)
        static int FindGCD(int a, int b)
        {
        while (b != 0)
        {
        int temp = b;
        b = a % b;
        a = temp;
        }
        return a;
    }
}