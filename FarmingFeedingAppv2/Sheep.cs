using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmingFeedingAppv2
{
    public class Sheep
    {
        //attributes or fields
        private int age;
        private readonly string BREED;
        private string id;
        //List for the total food over a week per day 
        private readonly List<int> FoodPerDay = new List<int>();

        //constructor - cronstructs an object of this class
        public Sheep(int age, string breed, List<int> FoodPerDay)
        {
            this.age = age;
            this.BREED = breed;
            this.FoodPerDay = FoodPerDay;
        }

        // Returns the value in the private age varible
        public int GetAge()
        {
            return this.age;
        }
        // Returns the value in the private age varible
        public List<int> GetFoodPerDay()
        {
            return FoodPerDay;
        }
        // returns the value in the breed variable
        public string GetBreed()
        {
            return this.BREED;
        }
        public void SetAge()
        {
            this.age++;
        }
     
        // creates an ID 
        public string IdGenorater(int NumberOfSheep)
        {
            id = BREED.Substring(0, 2).ToUpper() + NumberOfSheep + $"#{age}";
            return id;
        }

        // returns total food over the week
        public float OverWeeksFood()
        {
            float OverWeek = 0;
            for (int i = 0; i < FoodPerDay.Count; i++)
            {
                OverWeek += FoodPerDay[i];
            }
            return OverWeek;
        }
        //Creates a Food Summary for the week
        private string FoodSum()
        {
            string foodSum = "";
            for (int i = 0; i < FoodPerDay.Count; i++)
            {
                foodSum += $"Day {i + 1}: {FoodPerDay[i]}g\n";
            }
            return foodSum;
        }
        // creats a summary of the cost per sheep
        public float CostSum(float costPerGram)
        {
            return (float)Math.Round((OverWeeksFood() * costPerGram), 2);
        }
        //Creates a over all food and Cost summary
        public string Summary(float costPerGram, int NumberOfSheep, string determineHealth)
        {
            return "Breed: " + BREED + "\n" + "ID: " + IdGenorater(NumberOfSheep) + "\n" + determineHealth + "\n\n" + FoodSum() + "\n" +
               "Total Food Consumed: " + OverWeeksFood() + "\nCost: $" + CostSum(costPerGram) + "\n";
        }
        public override string ToString()
        {
            return "";
        }
    }
}
