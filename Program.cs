using System;
using System.Collections.Generic;
using System.Linq;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = fruits
            .Where(f => f.Contains("l"));
            foreach (string f in LFruits)
                Console.WriteLine(f);



            List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

            IEnumerable<int> fourSixMultiples = numbers
                .Where(n => n % 6 == 0)
                .Where(n => n % 4 == 0);
            foreach (int num in fourSixMultiples)
                Console.WriteLine(num);

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

            var sortDescedingQuery = names.OrderByDescending(n => n);

            foreach (string n in sortDescedingQuery)
            {
                Console.WriteLine(n);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> nums = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

            var sortAscendingQuery = nums.OrderBy(n => n);

            foreach (int n in sortAscendingQuery)
            {
                Console.WriteLine(n);
            }

            // Output how many numbers are in this list
            List<int> numsCount = new List<int>()
{
 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

            var howManyNums = numsCount.Count();

            Console.WriteLine(howManyNums);



            // How much money have we made?
            List<double> purchases = new List<double>()
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};

            double sum1 = purchases.Sum();
            Console.WriteLine(sum1);


            // What is our most expensive product?
            List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};

        }
    }
}

//     nums.TakeWhile(num => 
//     {
//         //return true if i is NOT a perfect square
//         //return false if i IS a perfect square
//         double sqrt = Math.Sqrt(num);
//         return sqrt % 1 != 0; 
//     }).ToList().ForEach(Console.WriteLine);
// }








