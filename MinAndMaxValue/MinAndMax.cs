using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MinAndMaxValue;

public class MinAndMax
{
    public static string FindMinAndMaxValue(string numbers)
    {
        string[] words = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (numbers.Length < 1) { return null; }
        else if (words.Length == 1) { return numbers = $"{numbers} {numbers}"; }
        int counter = 0, max = 0, min = 0;
        for (int i = 0; i < words.Length - 1; i++)
        {
            int number = Convert.ToInt32(words[i]);
            int number1 = Convert.ToInt32(words[i + 1]);
            if (number > number1)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number1 < min)
                {
                    min = number1;
                }
                if (counter < 1)
                {
                    max = number;
                    min = number1;
                    counter++;
                }
            }
            else
            {
                if (number1 > max)
                {
                    max = number1;
                }
                if (number < min)
                {
                    min = number;
                }
                if (counter < 1)
                {
                    max = number1;
                    min = number;
                    counter++;
                }
            }
        }
        numbers = $"Max value - {max}, min value - {min}";
        return numbers;
    }
}
