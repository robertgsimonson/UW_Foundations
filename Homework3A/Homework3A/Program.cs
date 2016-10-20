using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3A
{
    class FindDHMS
    {
        static void Main()
        {
            int secPerDay = 86400;  //Constants needed for calculations
            int secPerHour = 3600;
            int secPerMin = 60;
            int userSeconds;

            //begin
            Console.WriteLine("Please enter total number of seconds...");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userSeconds))
            {
                //Print Days
                Console.WriteLine("Days: {0}", userSeconds / secPerDay);     //Print the whole days
                userSeconds = userSeconds % secPerDay;                       //Convert the remanider back into seconds
                Console.WriteLine("Hours: {0}", userSeconds / secPerHour);   //Print the whole hours
                userSeconds = userSeconds % secPerHour;                      //Convert the remanider back into seconds
                Console.WriteLine("Minutes: {0}", userSeconds / secPerMin);  //Print the whole minutes
                userSeconds = userSeconds % secPerMin;                       //Convert the remanider back into seconds
                Console.WriteLine("Seconds: " +userSeconds);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You did not enter an integer!");
                Console.ReadLine();
            }

//Add the logic for negatives
        }
    }
}
