﻿using System;
class Program3
{
    private const char Symbol = '*';
    private const char EmptySymbol = ' ';
    private const int DoublingLengthValue = 2;
    private const int NumberFirstSymbol = 1;
    static void Main()
    {
        int UserNumber;
        Console.Write("Введите произвольное положительное число N и нажмите Enter" +
        Environment.NewLine + "N равно: ");

        while (!int.TryParse(Console.ReadLine(), out UserNumber) || UserNumber <= 0)

            Console.Write("Ошибка! Вы ввели 0, отрицательное или не числовое значение," +
            Environment.NewLine + "попробуйте ещё раз: ");

        for (int countSymbol = NumberFirstSymbol; countSymbol <= UserNumber; countSymbol++)

            Console.WriteLine(new string(EmptySymbol, UserNumber - countSymbol) + new string(Symbol, countSymbol * DoublingLengthValue - NumberFirstSymbol));
    }
}