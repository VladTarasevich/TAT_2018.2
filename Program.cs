﻿using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert();
        }

        public static void Convert()
        {
            StringBuilder output = new StringBuilder();
            int input = GetInput();
            int baseOutput = GetBase();
            if (input == 0)
            {
                Console.WriteLine("Ответ");
                Console.WriteLine(0);
                Console.ReadKey();
            }
            else
            {
                int rem;
                for (int i = 0; input > 0; i++)
                {
                    input = Math.DivRem(input, baseOutput, out rem);
                    output.Append(rem);
                }
                Char[] outputArray = output.ToString().ToCharArray();
                Array.Reverse(outputArray);
                Console.WriteLine("Ответ");
                Console.WriteLine(outputArray);
                Console.ReadKey();
            }
        }

        public static int GetInput()
        {
            int input;
            Console.WriteLine("Введите число");
            String inputString = Console.ReadLine();
            while (!Int32.TryParse(inputString, out input))
            {
                Console.WriteLine("Некорректный ввод");
                inputString = Console.ReadLine();
            }
            return input;
        }

        public static int GetBase()
        {
            int input;
            Console.WriteLine("Введите основание");
            String inputString = Console.ReadLine();
            while (!Int32.TryParse(inputString, out input) || input < 2 || input > 20)
            {
                Console.WriteLine("Некорректный ввод");
                inputString = Console.ReadLine();
            }
            return input;
        }



    }
}
