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
        public List<int> GetSheepSorter()
        {
            return sheepSorter;
        }
        //based on foodPerDay List Determines if a sheep is healthy
        public string DetermineHealth(float overWeeksFood)
        {
            // eating too much if over 5000
            if (overWeeksFood > 5000)
            {
                return "Eating to much food";
            }
            // eating to little if under 2000
            else if (overWeeksFood < 2000)
            {
                return "Eating to little food";
            }
            // its in a healthy range
            else
            {
                return "Eating average food";
            }
        }
        // returns a list of the food per day per breed for graph
        public List<int[]> CalculatTotalCostPerBreedPerDay()
        {
            //a list to hold data to return
            List<int[]> costPerBreedPerDay = new List<int[]>();

            // lopes though all the sheep breeds and runs the TotalConsumtionPerDay method for that breed
            //and then adds them into the costPerBreedPerDay list
            foreach (string breed in sheepBreeds)
            {
                    costPerBreedPerDay.Add(TotalConsumtionPerDay(breed)) ;
            }
            return costPerBreedPerDay; 
        }

        private int[] TotalConsumtionPerDay(string breed)
        {
            // array to hold values or if their arent any makes it = to 0,0,0,0...
            int[] breedConsumtionPerDay = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

            // lops though all sheeps in sheep
            foreach (Sheep sheep in sheeps)
            {
                //checks if the sheep is = to breed
                if (sheep.GetBreed().Equals(breed))
                {
                    int index = 0;
                    // makes breedComsumtionPerDay = to the sum of all sheeps getfoodPerDay in the provided breed
                    foreach (int food in sheep.GetFoodPerDay())
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
        public void AddSheep(Sheep Sheep)
        {
            sheeps.Add(Sheep);
        }
        // populates the weeklyCostPerBreed list with the cost per breed 
        public List<float> CalculattotalCostPerBreed()
        {
            // list to hold return values
            List<float> weeklyCostPerBreed = new List<float>() { 0, 0, 0, 0, 0 };
            int breedIndex = 0;
            // lops though all sheep 
            foreach (Sheep sheep in sheeps)
            {
                //makes sure the index counter is = to 0
                breedIndex = 0;
                // lops though all the breeds
                foreach (string breed in sheepBreeds)
                {
                    //checks if the breeds are equal
                    if (sheep.GetBreed().Equals(breed))
                    {
                        // adds it to the weeklyCostPerBreed list at Corect index
                        weeklyCostPerBreed[breedIndex] += sheep.CostSum(CostPerGram());
                    }
                    breedIndex++;
                }
            }
            return weeklyCostPerBreed;
        }

        // counts the number of sheep in order to give a number on the id
        public int NumberOfSheep()
        {
            return sheeps.Count();
        }

        // returns a cost sumary for all breeds 
        public string AllBreedCostSum( )
        {
            string breedSum = "";
            // lops though and makes all summary strings for each breed
            for (int i = 0; i < sheepBreeds.Count; i++)
            {
                breedSum += $"{sheepBreeds[i]}: ${CalculattotalCostPerBreed()[i]}\n";
            }

            return breedSum;
        }
        // calculates the over cost for all sheep
        public float OverAllCost()
        {
            float totalCost = 0;
            foreach (float breedCost in CalculattotalCostPerBreed())
            {
                totalCost += breedCost;
            }
            return totalCost;
        }
        // Retruns a overall sumary of all added sheep
        public string AllSummary( )
        {
            return "Weekly Feeding Cost Summary\n\n" + AllBreedCostSum() + "\nOverall Cost: $" + OverAllCost();
        }
       
    }
}