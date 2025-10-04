using System;

class Program1
{
    static void Main()
    {
        // задание №2
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

        // задание №6
        Console.Write("Введите количество бактерий (N): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Введите количество капель антибиотика (Х): ");
        int X = int.Parse(Console.ReadLine());

        int bacteria = N; // текущее количество бактерий
        int hours = 0; // счетчик часов
        int killPower = X * 10; // начальная мощность антибиотика

        Console.WriteLine("\nДинамика изменения количества бактерий:");

        // Цикл моделирования процесса
        while (killPower > 0)
        {
            hours++;

            // Бактерии удваиваются
            bacteria = bacteria * 2;

            // Антибиотик убивает бактерии
            bacteria -= killPower;

            // Мощность антибиотика уменьшается
            killPower -= X;

            if (bacteria <= 0)
            {
                bacteria = 0;
                break;
            }

            Console.WriteLine($"Час {hours}: Бактерий = {bacteria}, Мощность антибиотика = {killPower}");
        }

        Console.WriteLine($"\nПроцесс завершен через {hours} часов");
        Console.WriteLine($"Конечное количество бактерий: {bacteria}");
    }
}