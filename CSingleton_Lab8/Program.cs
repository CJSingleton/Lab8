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

            string selection;
            string nameIn = "";
            bool check = true;
            string knowMore = "y";
            while (check)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-5):");
                nameIn = Console.ReadLine();
                nameIn = ValidateNum(nameIn);//checks to make sure the input is a single digit integer.

                check = ValidateIndexRange(nameIn, names);//checks if input is whithin index range, throws exception if not.
            }

            while (knowMore == "y")
            {
                Console.WriteLine($"Student {int.Parse(nameIn)} is {names[int.Parse(nameIn) - 1]}. What would you like to know about {names[int.Parse(nameIn) - 1]}? (Enter \"hometown\" or \"favorite food\"):");

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
                        continue;
                        //Console.WriteLine("This is not a valid selection. Please choose either \"hometown\" or \"favorite food\":");
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
        public static bool ValidateIndexRange(string choice, string[] array1)
        {
            int input = 0;
            try
            {
                input = int.Parse(choice);
                string data = array1[input];
                return false;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return true;
            }

        }
    }
}
