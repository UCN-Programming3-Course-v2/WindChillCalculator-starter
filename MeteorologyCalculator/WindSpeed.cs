using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteorologyCalculator
{
    /// <summary>
    /// Represents a windspeed in either MPH (miles per hour) or MPS (meters per second)
    /// </summary>
    public class WindSpeed
    {
        private readonly float _speed;
        private readonly Unit _unit;

        public float MilesPerHour => _unit == Unit.MilesPerHour ? _speed : _speed * 2.23694F;

        public float MetersPerSecond => _unit == Unit.MeterPerSecond ? _speed : _speed * 0.44704F;

        public WindSpeed(float speed, Unit unit)
        {
            _speed = speed;
            _unit = unit;
        }

        public enum Unit
        {
            MeterPerSecond,
            MilesPerHour
        }
    }
}
