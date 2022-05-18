using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private readonly string Location;
        private readonly double Temperature;
        private const double FARENHEITCONSTFRACTION = 9.0 / 5.0;
        private const double FARENHEITCONSTINT = 32;
        private double Farenheit = 0;


        public WeatherReporter(string location, double temperature)
        {
            Location = location;
            Temperature = temperature;
        }

        public double CalculateFarenheit()
        {
            return Farenheit = FARENHEITCONSTFRACTION * Temperature + FARENHEITCONSTINT;
        }

        public string DisplayFarenheit()
        {
            return $"I am in {Location} and it is {CheckLocation()}. {CheckTemperature()}. The temperature in Fahrenheit is {CalculateFarenheit()}.";
        }

        private string CheckLocation()
        {
            if (Location.Equals("London"))
                return "🌦";

            if (Location.Equals("California"))
                return "🌅";

            if (Location.Equals("Cape Town"))
                return "🌤";

            return "🔆";
        }

        private string CheckTemperature()
        {
            if (Temperature > 30)
                return "It's too hot 🥵!";

            if (Temperature < 10)
                return "It's too cold 🥶!";

            return "Ahhh...it's just right 😊!";
        }

    }
}

