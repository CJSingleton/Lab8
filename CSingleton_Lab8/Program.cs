using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSingleton_Lab8
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Alex", "Joan", "Jack", "Alice", "Matt" };
            string[] hometown = { "Detroit", "Chicago", "Philidalphia", "London", "Boston" };
            string[] favFood = { "Pizza", "Ice Cream", "Pad Thai", "Steak", "Pasta" };

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-5):");
            string nameIn = Console.ReadLine();
            ValidateNum(nameIn);//checks to make sure the input is a single digit integer.

            string knowMore = "y";

            while (knowMore == "y")
            {
                string selection;

                ValidateIndexRange((int.Parse(nameIn)-1), names);//checks if input is whithin index range, throws exception if not.

                try//validation on "would you like to know more question. 
                {
                    selection = Console.ReadLine();
                    if (selection == "hometown")
                    {
                        Console.WriteLine($"{names[(int.Parse(nameIn)) - 1]} is from {hometown[(int.Parse(nameIn)) - 1]}.");
                        Console.WriteLine("Would you like to know more? (y/n)");
                        knowMore = Console.ReadLine();
                    }
                    else if (selection == "favorite food")
                    {
                        Console.WriteLine($"{names[(int.Parse(nameIn)) - 1]}'s favorite food is {favFood[(int.Parse(nameIn)) - 1]}.");
                        Console.WriteLine("Would you like to know more? (y/n)");
                        knowMore = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid selection. Please choose either \"hometown\" or \"favorite food\":");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static string ValidateNum(string input)
        {
            while (!Regex.IsMatch(input, @"^\d{1}$"))
            {
                Console.WriteLine("Your input is invalid. Please try again.");
                input = Console.ReadLine();
            }
            return input;
        }
        public static void ValidateIndexRange(int input, string[] array1)
        {
            try
            {
                Console.WriteLine($"Student {input + 1} is {array1[input]}. What would you like to know about {array1[input]}? (Enter \"hometown\" or \"favorite food\"):");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
