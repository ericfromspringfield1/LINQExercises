﻿using System;
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

            double maxPrice = prices.Max();
            Console.WriteLine(maxPrice);

            /*
    Store each number in the following List until a perfect square
    is detected.

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
            List<int> wheresSquaredo = new List<int>()
{
    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
};

    wheresSquaredo.TakeWhile(num => 
    {
        //return true if i is NOT a perfect square
        //return false if i IS a perfect square
        double sqrt = Math.Sqrt(num);
        return sqrt % 1 != 0; 
    }).ToList().ForEach(Console.WriteLine);
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };
          
       var millionaireCustomers = customers
        .Where(c => c.Balance <= 500000)
        .GroupBy(customer => customer.Bank);

        foreach (var customerGroup in millionaireCustomers)
        {
         Console.WriteLine($"{customerGroup.Key} {customerGroup.Count()}");
         foreach (var customer in customerGroup)
         {
             Console.WriteLine(customer.Name);
         }
        }

        }
        // Build a collection of customers who are millionaires 
        //Millionaires per bank
        
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}
                
       
    }
        }
    
        

    
    
    


/*
    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1
*/


    











