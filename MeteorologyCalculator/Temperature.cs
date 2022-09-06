using System;

namespace MeteorologyCalculator
{
    /// <summary>
    /// Represents a temperature on the Fahrenheit or Celsius scales.
    /// </summary>
    public class Temperature
    {
        private readonly double _temperature;
        private readonly Scale _scale;

        public double Fahrenheit => _scale == Scale.Fahrenheit ? _temperature : ConvertCelsiusToFahrenheit(_temperature);

        public double Celsius => _scale == Scale.Celsius ? _temperature : ConvertFahrenheitToCelsius(_temperature);

        public Temperature(double value, Scale scale)
        {
            _temperature = value;
            _scale = scale;
        }

        public enum Scale
        {
            Celsius,
            Fahrenheit,
        }

        internal static double ConvertFahrenheitToCelsius(double temperature)
        {
            return Math.Round((5d / 9d) * (temperature - 32), 1);
        }

        internal static double ConvertCelsiusToFahrenheit(double temperature)
        {
            return Math.Round((9d / 5d) * temperature + 32, 1);
        }
    }
}
