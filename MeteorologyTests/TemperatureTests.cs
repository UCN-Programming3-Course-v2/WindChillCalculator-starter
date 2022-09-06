using MeteorologyCalculator;

namespace MeteorologyTests
{
    public class TemperatureTests
    {
        [Fact]
        public void TestGetFahrenheitTemperatureNormal()
        {
            // Arrange
            Temperature temperature = new(5, Temperature.Scale.Celsius);
            double fahrenheitExpected = 41;

            // Act
            double fahrenheitResult = temperature.Fahrenheit;

            // Assert
            Assert.Equal(fahrenheitExpected, fahrenheitResult);
        }

        [Fact]
        public void TestGetCelsiusTemperatureNormal()
        {
            // Arrange
            Temperature temperature = new(41, Temperature.Scale.Fahrenheit);
            double celsiusExpected = 5;

            // Act
            double celsiusResult = temperature.Celsius;

            // Assert
            Assert.Equal(celsiusExpected, celsiusResult);
        }
    }
}

//WindSpeed wind = new(0, WindSpeed.Unit.MeterPerSecond);
//WindChillFactor wChillFactor = new(temperature, wind);
//double fahrenheitExpected = 41.00;