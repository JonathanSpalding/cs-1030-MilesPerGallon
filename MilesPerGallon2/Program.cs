using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Confvert Calculate Miles Per Gallon
 * 
 * by: Jonathan Spalding
 * Assignment: 2.2
 * 
 * Output: mpt
 * Input: Miles and Gallons
 * */

namespace MilesPerGallon2
{
    class Program
    {
        static void Main(string[] args)
        {
            float miles, gallons, mpg;
            string textLine;

            Console.Write("How many miles were driven: ");
            textLine = Console.ReadLine();
            miles = float.Parse(textLine);

            Console.Write("How many gallons were used: ");
            textLine = Console.ReadLine();
            gallons = float.Parse(textLine);

            mpg = miles / gallons;
            Console.Write("This is how many Miles to the Gallon you got: ");
            Console.WriteLine(mpg.ToString());

            Console.ReadLine();
        }
    }
}
/*
 * The formula is mpg = miles / gallons
Because there is a division in this equation, make sure and use real (floating point) numbers and variables.
All program code should be in main.
You should explicitly prompt your user for input.
Read in your user input value as a string then explicitly convert them to a numeric value suitable for calculations using real numbers (floating point).
In your output include a prompt that tells a user you are outputting "Miles Per Gallon".
Make sure your program waits in the console window until the user presses a return.
 * */
