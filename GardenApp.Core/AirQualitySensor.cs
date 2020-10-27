namespace GardenApp.Core
{
    public class AirQualitySensor:Sensor
    {
        public AirQualitySensor(string name, string serieNr) : base(name, serieNr)
        {
           
        }

        public override double GetMeasurement()
        {
            throw new System.NotImplementedException();
        }
    }
}