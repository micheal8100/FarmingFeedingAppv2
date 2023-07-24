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
        //grain cost
        private int grainCost = 30;


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
        // returns a list of the food per day per breed 
        public List<List<int>> CalculatTotalCostPerBreedPerDay(float costPerGram)
        { 
            List<List<int>> CostPerBreedPerDay = new List<List<int>>() {};
            int sheepCount = 0;

            foreach (Sheep sheep in sheeps)
            {
                for (int i = 0; i < sheepBreeds.Count(); i++)
                {
                    // to check if its the breed of the sheep
                    if (sheep.getBreed() == sheepBreeds[i])
                    {
                        //check if the user has allready added this sheep breed before
                        if (sheepSorter.Contains(i))
                        {
                            // so that it stays in one list
                            for (int c = 0; c < 6; c++)
                            {
                                CostPerBreedPerDay[i][c] += sheep.getFoodPerDay()[c];
                            }
                        }
                        else
                        {
                            //adding so that we can keep every thing in one list the next time we add a sheep with this breed 
                            sheepSorter.Add(i);
                            CostPerBreedPerDay.Add(sheep.getFoodPerDay());
                        }
                    }
                }
                sheepCount++;
            }
            return CostPerBreedPerDay;
        }
        // return sheepbreed list
        public List<string> GetSheepBreeds()
        {
            return sheepBreeds;
        }
        // calculates the cost per 1g
        public float CostPerGram()
        {
            // 30m is around the cost per 20 kgs
            return grainCost / 20000;
        }
        // adds Sheep To The List Sheep list and runs the CalculattotalCostPerBreed() method
        public void addSheep(Sheep Sheep)
        {
            sheeps.Add(Sheep);
        }
        // populates the weeklyCostPerBreed list with the cost per breed 
        public List<float> CalculattotalCostPerBreed(float costPerGram)
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
                        weeklyCostPerBreed[i] += sheeps[sheepCount].costSum(costPerGram);
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
        public string allBreedCostSum(float costPerGram)
        {

            string breedSum = "";

            for (int i = 0; i < sheepBreeds.Count; i++)
            {
                breedSum += $"{sheepBreeds[i]}: ${CalculattotalCostPerBreed(costPerGram)[i]}\n";
            }

            return breedSum;
        }
        // calculates the over cost for all sheep
        public float overAllCost(float costPerGram)
        {
            float totalCost = 0;
            foreach (float breedCost in CalculattotalCostPerBreed(costPerGram))
            {
                totalCost += breedCost;
            }
            return totalCost;
        }
        // Retruns a overall sumary of all added sheep
        public string allSummary(float costPerGram)
        {
            return "Weekly Feeding Cost Summary\n\n" + allBreedCostSum(costPerGram) + "\nOverall Cost: $" + overAllCost(costPerGram);
        }
    }
}
