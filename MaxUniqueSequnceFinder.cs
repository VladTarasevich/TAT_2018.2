
using System;
using System.Linq;

class MaxUniqueSequnceFinder
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку:  ");
        string input = Console.ReadLine();
        if (input == "")
        {
            Console.WriteLine($"Строка пуста.Попробуйте снова.");
        }
        int counter = 0;
        String unique = "";
        int j,maxUniqueLenth = 0;
        int startSymbolPointer = 0;
        for (maxUniqueLenth=0,j=0;j<input.Length ;j++)
        {

            if (!unique.Contains(input[j]))
            {
                unique += input[j];

            }
            else
            {
                unique = "";
                startSymbolPointer++;
                j = startSymbolPointer-1;
            }

            if (maxUniqueLenth < unique.Length)
            {
                maxUniqueLenth = unique.Length;
            }
        }
        counter = maxUniqueLenth;
        
        Console.WriteLine($"Максимальное количество последовательных неодинаковых символов " + counter);
        Console.ReadKey();

        
    }

}




