using System;
using System.Collections.Generic;

class RomanToInteger
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int value = romanValues[s[i]];

            if (value < prevValue)
            {
                result -= value;
            }
            else
            {
                result += value;
            }

            prevValue = value;
        }

        return result;
    }

    static void Main()
    {
        RomanToInteger converter = new RomanToInteger();

        Console.WriteLine("Введите римское число для преобразования в целое число:");
        string input = Console.ReadLine().ToUpper(); // Преобразуем введенную строку в верхний регистр

        int result = converter.RomanToInt(input);
        Console.WriteLine($"Результат преобразования: {result}");
    }
}