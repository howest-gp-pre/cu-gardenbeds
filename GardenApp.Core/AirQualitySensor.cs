namespace GardenApp.Core;

public class AirQualitySensor:Sensor
{
    public AirQualitySensor(string name, string serialNr) : base(name, serialNr)
    {
    }

    public override double GetMeasurement()
    {
        return Faker.RandomNumber.Next(0, 500);
    }
    
    public override string ToString()
    {
        return $"Air quality {base.ToString()}";
    }
}