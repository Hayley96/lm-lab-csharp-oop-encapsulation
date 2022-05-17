using NUnit.Framework;
using FluentAssertions;
using Encapsulation.Models;

namespace EncapsulationTests
{
    public class Tests
    {
        private WeatherReporter wr;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DisplayFarenheit_Should_Return_59_When_The_Value_15_Is_Assigned_To_Temperature_Field()
        {
            WeatherReporter wr = new("London", 15);
            wr.DisplayFarenheit().Should().Contain("59");
        }

        [Test]
        public void DisplayFarenheit_Should_Return_104_When_The_Value_40_Is_Assigned_To_Temperature_Field()
        {
            WeatherReporter wr = new("California", 40);
            wr.DisplayFarenheit().Should().Contain("104");
        }

        [Test]
        public void DisplayFarenheit_Should_Return_A_String_Containing_The_Word_Hot_When_Temperature_Is_Greater_Than_30()
        {
            WeatherReporter wr = new("Cape Town", 40);
            wr.DisplayFarenheit().Should().Contain("hot");
        }

        [Test]
        public void DisplayFarenheit_Should_Return_A_String_Containing_The_Word_Cold_When_Temperature_Is_Less_Than_10()
        {
            WeatherReporter wr = new("London", 5);
            wr.DisplayFarenheit().Should().Contain("cold");
        }

        [Test]
        public void CalculateFarenheit_Should_Return_104_When_The_Value_40_Is_Assigned_To_Temperature_Field()
        {
            WeatherReporter wr = new("London", 40);
            wr.CalculateFarenheit().Should().Be(104);
        }

        [Test]
        public void CalculateFarenheit_Should_Return_59_When_The_Value_15_Is_Assigned_To_Temperature_Field()
        {
            WeatherReporter wr = new("London", 15);
            wr.CalculateFarenheit().Should().Be(59);
        }
    }
}