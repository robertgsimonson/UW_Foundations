using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class FindFactorial
    {
        static void Main()
        {
            Console.WriteLine("Please enter the integer you would like to calculate the factorial for...");

            string userInput = Console.ReadLine();  //intilize userEntry with user input
            int userInt;  //Storage for parse value of userEntry
            int sum = 1;  //Storage for partial result of the iterative factorial calculation.  Assign value of 1 since the
            
            if (int.TryParse(userInput, out userInt)) //if string parses to an int:  store in userInt
            {
                if (userInt >= 0)  //Check for a negative int 
                {
                    if (userInt == 0) //Check for 0
                    {
                        Console.WriteLine("The Factorial of 0 is defined as 1");
                        Console.ReadLine();
                    }
                    else  //Positive nonzero int was entered.  Proceed with calculation
                    {
                        for (; userInt > 0; userInt--)
                        {
                            sum = sum * userInt;   //accumulate the sum of the iterations to find factorial.  First interation sets sum to userInt.  Covers rule 1! = 1
                        }
                        Console.WriteLine("The Factorial of " + userInput + " is " + sum);
                        Console.ReadLine();
                    }
                }
                else  //user entered negative int
                {
                    Console.WriteLine("The factorial of a negative integer is undefined");
                    Console.ReadLine();
                }

            }
            else  //TryParse is false due to user entering a noninterger value
            {
                Console.WriteLine("You did not enter an integer!");
                Console.ReadLine();
            }
        }
    }
}
