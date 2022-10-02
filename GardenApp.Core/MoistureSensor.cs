namespace GardenApp.Core
{
    public class MoistureSensor:Sensor
    {
        public MoistureSensor(string name, string serialNumber) 
            : base(name, serialNumber)
        {
        }

        public override double GetMeasurement()
        {
            return Faker.RandomNumber.Next(0, 100);
        }
    }
}