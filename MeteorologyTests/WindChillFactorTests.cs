using MeteorologyCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteorologyTests
{
    public class WindChillFactorTests
    {
        [Fact]
        public void TestCalculateWindChillFactorSuccess()
        {
            // Arrange
            Temperature temperature = new(5, Temperature.Scale.Celsius);
            WindSpeed windSpeed = new(9, WindSpeed.Unit.MeterPerSecond);
            WindChillFactor windChillFactor = new(temperature, windSpeed);
            double expectedFahrenheit = 31.7616;
            double expectedCelsius = -0.1;

            // Act
            double celsiusResult = windChillFactor.CalculateWindChillFactor(Temperature.Scale.Celsius);
            double fahrenheitResult = windChillFactor.CalculateWindChillFactor(Temperature.Scale.Fahrenheit);

            // Assert
            Assert.Equal(expectedFahrenheit, fahrenheitResult, 4);
            Assert.Equal(expectedCelsius, celsiusResult, 4);
        }

        [Fact]
        public void TestCalculateWindChillFactorFailOnLowWindSpeed()
        {
            // Arrange
            Temperature temperature = new(5, Temperature.Scale.Celsius);
            WindSpeed windSpeed = new(2, WindSpeed.Unit.MilesPerHour);
            string expectedMessage = "Windspeed too low";

            // Act
            Exception exResult = Assert.Throws<MeteorologyException>(() => new WindChillFactor(temperature, windSpeed));

            // Assert
            Assert.Equal(expectedMessage, exResult.Message);
        }

        [Fact]
        public void TestCreateWindChillFactorWithTemperatureTooHigh()
        {
            // Arrange
            Temperature temperature = new(50, Temperature.Scale.Fahrenheit);
            WindSpeed windSpeed = new(9, WindSpeed.Unit.MilesPerHour);
            string expectedMessage = "Temperature too high";

            // Act
            Exception exResult = Assert.Throws<MeteorologyException>(() => new WindChillFactor(temperature, windSpeed));

            // Assert
            Assert.Equal(expectedMessage, exResult.Message);
        }
    }
}
