﻿using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int relHumid;
            int windSpeed;
            double heatIndex;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            if (temperature > 50)
            {
                // Get the relative humidity from the user

                Console.WriteLine("Enter relative humidity");

                input = Console.ReadLine();

                relHumid = int.Parse(input);

                // Calculate heat index

                heatIndex = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relHumid * 0.094));

                Console.WriteLine("The heat index is " + heatIndex);
                    }   

            else
            {
                // Get the windspeed from the user
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }
        }
    }
}
