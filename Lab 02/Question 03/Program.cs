using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    class TemperatureTracker
    {
        // Array to store daily temperatures for a week (assuming 7 days)
        private int[] dailyTemperatures = new int[7];

        // Method to input temperatures for each day
        public void InputTemperatures()
        {
            for (int i = 0; i < dailyTemperatures.Length; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int temperature))
                {
                    dailyTemperatures[i] = temperature;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid temperature.");
                    i--; // Retry input for the same day
                }
            }
        }

        // Method to display the weekly temperature report
        public void DisplayTemperatureReport()
        {
            Console.WriteLine("\nWeekly Temperature Report:");
            for (int i = 0; i < dailyTemperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyTemperatures[i]}°C");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Instantiate an object of the TemperatureTracker class
            TemperatureTracker weeklyTemperatures = new TemperatureTracker();

            // Input temperatures for each day
            weeklyTemperatures.InputTemperatures();

            // Display the weekly temperature report
            weeklyTemperatures.DisplayTemperatureReport();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}