using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        private double capacity;
        private double currentWeight=0;
        private double remainingWeight;

        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public double CurrentWeight
        {
            get { return currentWeight; }
            
        }

        public double RemainingWeight
        {
            get { return remainingWeight; }
        }

        public void AddItems(int noOfItems, double weightPerUnit)
        {
            double itemsTobeAdded = weightPerUnit*noOfItems;
            if (currentWeight + itemsTobeAdded <= capacity)
            {
                currentWeight +=  noOfItems*weightPerUnit;
                remainingWeight = capacity - currentWeight;
            }
            else
            {
                throw new Exception("Overload...");
            }
            
        }
    }
}
