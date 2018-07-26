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
            string knowMore = "y";

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-5)");
            string nameIn = Console.ReadLine();
            ValidateData(nameIn);

            while (knowMore == "y")
            {
                string selection;
                ValidateRange((int.Parse(nameIn)-1), names, knowMore);

                try
                {
                    selection = Console.ReadLine();
                    if (selection == "hometown")
                    {
                        Console.WriteLine($"{names[(int.Parse(nameIn)) - 1]} is from {hometown[(int.Parse(nameIn)) - 1]}");
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
                        Console.WriteLine("This is not a valid selection. Please choose either \"hometown\" or \"favorite food\"");
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

        public static string ValidateData(string input)
        {
            while (!Regex.IsMatch(input, @"^\d{1}$"))
            {
                Console.WriteLine("Your input is invalid. Please try again.");
                input = Console.ReadLine();
            }
            return input;
        }

        public static string ValidateRange(int input, string[] array1, string halt)
        {
            try
            {
                Console.WriteLine($"Student {input + 1} is {array1[input]}. What would you like to know about {array1[input]}? (Enter \"hometown\" or \"favorite food\"):");
            }
            catch (IndexOutOfRangeException ex)
            {
                halt = "n";
                Console.WriteLine(ex);
            }
            return halt;
        }
        
        //public static void ValidateFormat(string input, string[] array1, string[] array2)
        //{
        //    try
        //    {

        //    }
        //    catch
        //    {

        //    }
        //}

        //    GetValidInput(@"^\d{1}$", "Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-5)",names);
        //Console.WriteLine(names[int.Parse(nameinput)]);

        //Console.WriteLine($"Student {nameinput}");             


        //string result = GetInputResults(nameinput);

        //Console.WriteLine($"Student {nameinput} is {names[]}. What would you like to know about {names[i]}? " +
        //            $"Enter \"hometown\" or \"favorite food\".");


        //public static string ValidateInput1(string pattern, string temp, string[] data)//string userMessage = "Please enter a valid input:", string errorMessage = "Error in input! Please try again.")
        //{
        //    //Console.WriteLine(userMessage);
        //    string userInput = Console.ReadLine();


        //    while (!Regex.IsMatch(userInput, pattern))
        //    {
        //        try
        //        {
        //            Console.WriteLine(userMessage);
        //            userInput = Console.ReadLine();
        //            Console.WriteLine(data[6]);

        //            if (Regex.IsMatch(userInput, pattern))
        //            {

        //            }

        //            //return userInput;

        //        }
        //        catch (IndexOutOfRangeException ex)
        //        {
        //            Console.WriteLine(ex);
        //            continue;
        //        }
        //        catch (FormatException ex)
        //        {
        //            Console.WriteLine(ex);
        //            continue;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex);
        //            continue;
        //        }
        //    }
        //    return userInput;
        //}
    }
}
