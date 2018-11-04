using System;
using System.Collections.Generic;

namespace OOP
{
    class AutoData
    {
        List<Auto> List = new List<Auto>();
        public void AddAuto() 
        {
            List.Add(new Auto());
            Repeat();
        }
        
        public int CountTypes() 
        {
            int Marks = 0;
            for (int i = 0; i < List.Count; i++)
            {
                if (DoubleCheck(i) == true) 
                {
                    Marks++;
                }
            }
            return Marks;
        }
        private bool DoubleCheck(int iteration) 
        {
            bool check = true;
            if (iteration != 0)
            {
                for (int i = 0; i < iteration; i++)
                {
                    if (List[iteration].getMark() == List[i].getMark())
                    {
                        check = false;
                    }
                }
            }
            return check;
        }
        private void Repeat()
        {
            int j = List.Count - 1;
            for (int i = 0; i < j; i++)
            {
                if ((List[i].getMark() == List[j].getMark()) && (List[i].getModel() == List[j].getModel()) &&
                    (List[i].getCost() == List[j].getCost()))
                {
                    List[i].RepeatAmountSet(List[j].getAmount());
                    List.RemoveAt(j);
                    break;
                }
            }
        }
        public int Count() 
        {
            int Amount = 0;
            for (int i = 0; i < List.Count; i++)
            {
                Amount += List[i].getAmount();
            }
            return Amount;
        }
        public int Cost() 
        {
            int Cost = 0;
            for (int i = 0; i < List.Count; i++)
            {
                Cost += List[i].getCost();
            }
            return Cost;
        }
        public double AveragePrice() 
        {
            
            double tempCostAll = Convert.ToDouble(Cost());
            double tempCountAll = Convert.ToDouble(Count());
            double averagePrice = tempCostAll / tempCountAll;
            return averagePrice;
        }
        public double AveragePrice(string type) 
        {
            
            double tempCost = 0;
            double tempCount = 0;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].getMark() == type)
                {
                    tempCost += Convert.ToDouble(List[i].getCost());
                    tempCount += Convert.ToDouble(List[i].getAmount());
                }
            }
            double typeAveragePrice = tempCost / tempCount;
            return typeAveragePrice;
        }
    }
}
    
