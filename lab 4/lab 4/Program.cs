using System;
using System.Collections.Generic;
class Numbers
{ 
    public int RomanToInt(string s)
    {
        Dictionary<char, int> Rim = new Dictionary<char, int>()
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
        int pred = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int value = Rim[s[i]];

            if (value < pred)
            {
                result -= value;
            }
            else
            {
                result += value;
            }

            pred = value;
        }

        return result;
    }

    static void Main()
    {
        Numbers converter = new Numbers();

        Console.WriteLine("Введите римское число для преобразования в целое число:");
        string input = Console.ReadLine().ToUpper(); 

        int result = converter.RomanToInt(input);
        Console.WriteLine($"Результат преобразования: {result}");
    }
}
