using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmingFeedingAppv2
{
    public class SheepManager
    {
         // All Sheep Breeds My Program Acounts For
        private List<string> sheepBreeds = new List<String>() { "Australian whites NZ", "Border Leicester", "Charollais"
            , "Corriedale", "Awassi" };
        //to fill the cost per breed per day list in order 

        private List<int> sheepSorter = new List<int> { };

        // list of all animals 
        private List<Sheep> sheeps = new List<Sheep>();
       


        //constructor - cronstructs an object of this class
        public SheepManager()
        {

        }
        // gets the sheep sorter list
        public List<int> getSheepSorter()
        {
            return sheepSorter;
        }
        
        // Check Age 0 < x > 40
        public bool CheckAge(int age)
        {
            if (age > 0 && age < 30)
            {
                return true;
            }
            return false;
        }
        //based on foodPerDay List Determines if a sheep is healthy
        public string determineHealth(float overWeeksFood)
        {
            if (overWeeksFood > 4500)
            {
                return "Eating to much food";
            }
            else if (overWeeksFood < 2100)
            {
                return "Eating to little food";
            }
            else
            {
                return "Eating average food";
            }
        }
        // checks to see if any value out of the range 
        public bool checkFoodPerDay(List<int> foodPerDay)
        {
            for (int i = 0; i < 6; i++)
            {
                if (foodPerDay[i] >= 0 && foodPerDay[i] < 5000)
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        // returns a list of the food per day per breed for graph
        public List<int[]> CalculatTotalCostPerBreedPerDay()
        {
            //a list to hold data to return
            List<int[]> CostPerBreedPerDay = new List<int[]>();

            int index = 0;
            foreach (string breed in sheepBreeds)
            {
                
                    CostPerBreedPerDay.Add(TotalConsumtionPerDay(breed)) ;
             
                

            }
            return CostPerBreedPerDay; 
        }

        private int[] TotalConsumtionPerDay(string breed)
        {
            int[] breedConsumtionPerDay = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

            foreach (Sheep sheep in sheeps)
            {
                if (sheep.getBreed().Equals(breed))
                {
                    int index = 0;
                    foreach (int food in sheep.getFoodPerDay())
                    {
                        breedConsumtionPerDay[index] += food;
                        index++;
                    }
                }
            }
            return breedConsumtionPerDay;
        }
        // return sheepbreed list
        public List<string> GetSheepBreeds()
        {
            return sheepBreeds;
        }
        // stores the cost per 1g in a method so all calculations use the same number
        public float CostPerGram()
        {
            // 0.0015 is around the cost for 1 gram of grain 
            return 0.0015f;
        }
        // adds Sheep To The List Sheep list and runs the CalculattotalCostPerBreed() method
        public void addSheep(Sheep Sheep)
        {
            sheeps.Add(Sheep);
        }
        // populates the weeklyCostPerBreed list with the cost per breed 
        public List<float> CalculattotalCostPerBreed()
        {
            List<float> weeklyCostPerBreed = new List<float>() { 0, 0, 0, 0, 0 };
            int sheepCount = 0;
            // so i gose though every sheep
            foreach (Sheep sheep in sheeps)
            {
                for (int i = 0; i < sheepBreeds.Count(); i++)
                {
                    if (sheeps[sheepCount].getBreed() == sheepBreeds[i])
                    {
                        weeklyCostPerBreed[i] += sheeps[sheepCount].costSum(CostPerGram());
                    }
                }
                sheepCount++;
            }
            return weeklyCostPerBreed;
        }

        // counts the number of sheep in order to give a number on the id
        public int NumberOfSheep()
        {
            return sheeps.Count();
        }

        // returns a cost sumary for all breeds 
        public string allBreedCostSum( )
        {

            string breedSum = "";

            for (int i = 0; i < sheepBreeds.Count; i++)
            {
                breedSum += $"{sheepBreeds[i]}: ${CalculattotalCostPerBreed()[i]}\n";
            }

            return breedSum;
        }
        // calculates the over cost for all sheep
        public float overAllCost()
        {
            float totalCost = 0;
            foreach (float breedCost in CalculattotalCostPerBreed())
            {
                totalCost += breedCost;
            }
            return totalCost;
        }
        // Retruns a overall sumary of all added sheep
        public string allSummary( )
        {
            return "Weekly Feeding Cost Summary\n\n" + allBreedCostSum() + "\nOverall Cost: $" + overAllCost();
        }
       
    }
}