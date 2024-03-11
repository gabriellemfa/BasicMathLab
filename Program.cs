using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathLab
{



    internal class Program
    {
        static void Main(string[] args)

        { 
            //Creates an object of BasicMath class
            BasicMath calculator = new BasicMath();

            //Loop to keep the program running until user quits
            while (true)
            {
                //Displays menu options
                Console.WriteLine($"Simple Calculator\n" +
                              "****************\nChoose an option\n" +
                              "Option 1: Add\n" +
                              "Option 2: Subtract\n" +
                              "Option 3: Multiply\n" +
                              "Option 4: Divide\n" +
                              "Enter your choice (or 'q' to quit): ");

                //Reads user's choice
                string option = Console.ReadLine();


                //checks if user wants to quit
                if (option.ToLower() == "q")
                    break;

                double num1, num2, result;

                //Performs the operations based on the user's choice
                switch (option)
                {

                    //If user chooses the addition option
                    case "1":
                        Console.WriteLine("\nAddition:");
                        num1 = GetNumber("Enter the first number: ");
                        num2 = GetNumber("Enter the second number: ");
                        result = calculator.Add(num1, num2);
                        Console.WriteLine($"Result: {result}\n");
                        break;

                    //If user chooses the subtraction option
                    case "2":
                        Console.WriteLine("\nSubtraction:");
                        num1 = GetNumber("Enter the first number: ");
                        num2 = GetNumber("Enter the second number: ");
                        result = calculator.Subtract(num1, num2);
                        Console.WriteLine($"Result: {result}\n");
                        break;


                    //If user chooses the multiplication option
                    case "3":
                        Console.WriteLine("\nMultiplication:");
                        num1 = GetNumber("Enter the first number: ");
                        num2 = GetNumber("Enter the second number: ");
                        result = calculator.Multiply(num1, num2);
                        Console.WriteLine($"Result: {result}\n");
                        break;


                    //If user chooses the division option
                    case "4":
                        Console.WriteLine("\nDivision:");
                        num1 = GetNumber("Enter the first number: ");
                        num2 = GetNumber("Enter the second number (non-zero): ");

                        //if user inputs "0"
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }
                        result = calculator.Divide(num1, num2);
                        Console.WriteLine($"Result: {result} \n");
                        break;

                    //if user inputs anything outside of the options
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }

            Console.WriteLine("Program ended");

        }

        //Method to get a valid number input from the user
        static double GetNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out number))
                    return number;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

    }
}
