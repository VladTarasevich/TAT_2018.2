using System;

namespace OOP
{
   class Operations
   {

        AutoData List = new AutoData();
        private int numberOfMarks;
        private string operation;
        public Operations() 
        {
            
            SetMarks();
            AddMarks(numberOfMarks);
            GetOperation();

        }

        private void SetMarks() 
        {
            do
            {
                try
                {
                    Console.Write("Enter number of products: ");
                    numberOfMarks = Convert.ToInt32(Console.ReadLine());
                    if (numberOfMarks > 0) 
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
        private void AddMarks(int numberOfProducts) 
        {

            for (int i = 0; i < numberOfProducts; i++)
            {
                List.AddAuto();
            }

        }
        private void GetOperation()
        {
            string type;
            do
            {
                Console.WriteLine("Enter some operation(average price,count types,count all,exit): ");

                operation = Console.ReadLine();



                if (operation == "average price")
                {
                    Console.Write(" >>> ");
                    Console.WriteLine(List.AveragePrice());
                }

                if (operation.StartsWith("average price "))
                {
                    Console.Write(" >>> ");
                    type = operation.Substring(14);
                    Console.WriteLine(List.AveragePrice(type));
                }


                if (operation == "count types")
                {
                    Console.Write("=");
                    Console.Write(List.CountTypes());
                }

                if (operation == "count all")
                {
                    Console.Write("=");
                    Console.WriteLine(List.Count());
                }


                if (operation == "exit")
                {
                    break;
                }

            }
            while (true);
        }

    }
}
    
