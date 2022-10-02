using System;

namespace GardenApp.Core
{
    public class AirQualitySensor : Sensor
    {
        public AirQualitySensor(string name, string serialNumber) : base(name, serialNumber)
        {
        }

        public override double GetMeasurement()
        {
            return Faker.RandomNumber.Next(0, 500);
        }
    }
}