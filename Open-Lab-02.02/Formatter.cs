﻿using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            string output = "";
            for (int i = 0; i < numbers.Lenght; i++)
            {
                output = output + numbers[i].ToString("F", CultureInfo.InvariantCulture) + " ";
            }
            Console.Write(output.Substring(0, output.Legth - 1));
        }
    }
}
