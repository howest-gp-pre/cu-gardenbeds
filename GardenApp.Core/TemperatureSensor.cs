using System;

namespace GardenApp.Core
{
    public class TemperatureSensor : Sensor
    {
        public TemperatureSensor(string name, string serialNumber) : base(name, serialNumber)
        {
        }

        public override double GetMeasurement()
        {
            return Faker.RandomNumber.Next(-18, 60);
        }

        public override string ToString()
        {
            return $"Temperature {base.ToString()}";
        }
    }
}