using System;

namespace OOP
{
    class Auto
    {
        private string mark;
        private string model;
        private int amount;
        private int price;
        public Auto() 
        {
            Console.WriteLine("New car");
            SetMark();
            SetModel();
            SetAmount();
            SetCost();
            Console.WriteLine();
        }
        private void SetMark() 
        {
            char[] markChar = new char[80]; 
            bool empty = false; 
            do
            {
                try
                {
                    Console.Write("Mark: ");
                    mark = Console.ReadLine();
                    markChar = mark.ToCharArray();

                    for (int i = 0; i < markChar.Length; i++)
                    {
                        if (markChar[0] == ' ') 
                        {
                            break;
                        }
                        if (Char.IsLetterOrDigit(markChar[i]) == true) 
                        {
                            empty = true;
                            break;
                        }
                    }
                    if (empty == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, check your data");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input, check your data");
                }
            }
            while (true);
        }
        private void SetModel() 
        {
            char[] modelChar = new char[80]; 
            bool Empty = false; 
            do
            {
                try
                {
                    Console.Write("Model: ");
                    model = Console.ReadLine();
                    modelChar = model.ToCharArray();
                    for (int i = 0; i < modelChar.Length; i++)
                    {
                        if (modelChar[0] == ' ') 
                        {
                            break;
                        }
                        if (Char.IsLetterOrDigit(modelChar[i]) == true) 
                        {
                            Empty = true;
                            break;
                        }
                    }
                    if (Empty == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, check your data");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input, check your data");
                }
            }
            while (true);
        }
        private void SetAmount()
        {
            do
            {
                try
                {
                    Console.Write("Amount: "); 
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (amount > 0)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect input, check your data");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input, check your data");
                }
            }
            while (true);
        }
        private void SetCost() 
        {
            do
            {
                try
                {
                    Console.Write("Price: ");
                    price = Convert.ToInt32(Console.ReadLine());
                    if (price > 0) 
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, check your data");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input, check your data");
                }
            }
            while (true);
        }
        public int getAmount()
        {
            return amount;
        }
        public int getCost()
        {
            return price;
        }
        public string getMark() 
        {
            return mark;
        }
        public string getModel() 
        {
            return model;
        }
        public void RepeatAmountSet(int plusAmount) 
        {
            amount += plusAmount;
        }
    }
}
