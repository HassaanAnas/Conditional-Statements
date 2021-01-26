//  HASSAAN ANAS
//  1/26/2021
//  Deliverable 2 : Conditional Statements
using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // User input
            Console.WriteLine("Hello! What grade do you expect to get in ISM 4300?");

            // using try and catch to avoid errors
            try
            {
                // this variable will gather the user input
                string input = Console.ReadLine();

                // this will convert input into int
                int grade = int.Parse(input);

                // if statment for grade A+ 
                if (grade >= 98 && grade <= 100)
                {
                    Console.WriteLine("Congratulations! You have an A+");
                }

                // else if statement for grade A
                else if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("Congratulations! You have an A");
                }

                // else if statement for grade A-
                else if (grade >= 90 && grade <= 91)
                {
                    Console.WriteLine("Congratulations! You have an A-");
                }

                // else if statament for grade B+
                else if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("You have a B+");
                }

                // else if statement for grade B
                else if (grade >= 82 && grade <= 87)
                {
                    Console.WriteLine("You have a B");
                }

                // else if statement for grade B-
                else if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("You have a B-");
                }

                // else if statement for grade C+
                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("You have a C+");
                }

                // else if statement for grade C
                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("You have a C");
                }

                // else if statement for grade C-
                else if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("You have a C-");
                }

                // else if statement for grade D+
                else if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("You have a D+");
                }

                // else if statement for grade D
                else if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("You have a D");
                }

                // else if statement for grade D-
                else if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("You have a D-");
                }

                // else statement for grade F
                else
                {
                    Console.WriteLine(" You have an F");
                }
                        

                
            }

            // catch for avoiding errors in case an invalid value has been input
            catch
            {
                Console.WriteLine("Incorrect value please try again!");
            }
            









    }
    }
}