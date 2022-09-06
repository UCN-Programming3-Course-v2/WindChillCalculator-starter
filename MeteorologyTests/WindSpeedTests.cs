using MeteorologyCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteorologyTests
{
    public class WindSpeedTests
    {
        [Fact]
        public void TestGetMilesPerHourNormal()
        {
            // Arrange
            WindSpeed speed = new(10, WindSpeed.Unit.MeterPerSecond);
            float mphExpected = 22.3694F;

            // Act
            float mphResult = speed.MilesPerHour;

            // Assert
            Assert.Equal(mphExpected, mphResult, 4);

        }

        [Fact]
        public void TestGetMetersPerSecondNormal()
        {
            // Arrange
            WindSpeed speed = new(22.3694F, WindSpeed.Unit.MilesPerHour);
            float mpsExpected = 10;

            // Act
            float mpsResult = speed.MetersPerSecond;

            // Assert
            Assert.Equal(mpsExpected, mpsResult, 4);
        }
    }
}
