using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private readonly string Location;
        private readonly double Temperature;
        private const double FARENHEITCONSTFRACTION = 9.0 / 5.0;
        private const double FARENHEITCONSTINT = 32;

        public WeatherReporter(string location, double temperature)
        {
            Location = location;
            Temperature = temperature;
        }

        public string DisplayFarenheit()
        {
            double newFarenheit = FARENHEITCONSTFRACTION * Temperature + FARENHEITCONSTINT;
            return $"I am in {Location} and it is {CheckLocation()}. {CheckTemperature()}. The temperature in Fahrenheit is {newFarenheit}.";
        }

        private string CheckLocation()
        {
            if (Location.Equals("London"))
            {

                return "🌦";

            }
            else if (Location.Equals("California"))
            {

                return "🌅";

            }
            else if (Location.Equals("Cape Town"))
            {

                return "🌤";

            }
            return "🔆";
        }

        private string CheckTemperature()
        {
            if (Temperature > 30)
            {

                return "It's too hot 🥵!";

            }
            else if (Temperature < 10)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

