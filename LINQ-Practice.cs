using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

        // Find the words in the collection that start with the letter 'L'
        IEnumerable<string> LFruits = from fruit in fruits
                                      where fruit.StartsWith("L")
                                      select fruit;

        // Display the result
        Console.WriteLine("Fruits that start with 'L':");
        foreach (string fruit in LFruits)
        {
            Console.WriteLine(fruit);
        }

        // Exercise Page Break
        Console.WriteLine("------------------------------");

        // Which of the following numbers are multiples of 4 or 6
        List<int> numbers = new List<int>()
        {
         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

        IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);

        Console.WriteLine("Numbers that are multiples of 4 or 6:");
        foreach (var num in fourSixMultiples)
        {
            Console.WriteLine(num + " ");
        }

        // Exercise Page Break
        Console.WriteLine("------------------------------");

        // Order these student names alphabetically, in descending order (Z to A)
        List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

        List<string> descend = names.OrderByDescending(name => name).ToList();

        Console.WriteLine("Names in descending order:");
        foreach (var name in descend)
        {
            Console.WriteLine(name);
        }

        // Exercise Page Break
        Console.WriteLine("------------------------------");

        // Build a collection of these numbers sorted in ascending order
        List<int> numbersAgain = new List<int>()
        {
         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

        IEnumerable<int> sorted = numbersAgain.OrderBy(n => n);

        Console.WriteLine("Numbers in ascending order:");
        foreach (int number in sorted)
        {
            Console.WriteLine(number);
        }

        // Exercise Page Break
        Console.WriteLine("------------------------------");

        // Output how many numbers are in this list
        List<int> numbersAgainWOW = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

        Console.WriteLine(numbersAgainWOW.Count);

        // Exercise Page Break
        Console.WriteLine("------------------------------");

        // How much money have we made?
        List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };

        Console.WriteLine("$" + purchases.Sum(x => Convert.ToInt32(x)));


        // Exercise Page Break
        Console.WriteLine("------------------------------");

        // What is our most expensive product?
        List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };

        Console.WriteLine(prices.Max());


        // Exercise Page Break
        Console.WriteLine("------------------------------");

        {
            List<int> wheresSquaredo = new List<int>()
        {
            66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };

            List<int> result = wheresSquaredo.TakeWhile(number => Math.Sqrt(number) % 1 != 0).ToList();

            Console.WriteLine("Numbers until a perfect square is detected:");
            foreach (var num in result)
            {
                Console.WriteLine(num + " ");
            }
        }

        // Exercise Page Break
        Console.WriteLine("------------------------------");

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

        List<Customer> millionaires = customers.Where(customer => customer.Balance >= 1000000.00).ToList();

        Console.WriteLine("Millionaire Customers:");
        foreach (var millionaire in millionaires)
        {
            Console.WriteLine($"{millionaire.Name} - Balance: {millionaire.Balance:C2}, Bank: {millionaire.Bank}");
        }

        // Exercise Page Break
        Console.WriteLine("------------------------------");

        var millionairePerBank = customers
        .Where(customer => customer.Balance >= 1000000.00)
        .GroupBy(customer => customer.Bank)
        .Select(group => new
        {
            Bank = group.Key,
            MillionaireCount = group.Count()
        });

        Console.WriteLine("Millionaires per Bank:");
        foreach (var item in millionairePerBank)
        {
            Console.WriteLine($"{item.Bank}: {item.MillionaireCount} millionaires");
        }
    }

    // Build a collection of customers who are millionaires
    public class Customer
    {
        public string Name { get; set; } = string.Empty;
        public double Balance { get; set; }
        public string Bank { get; set; } = string.Empty;
    }
}

