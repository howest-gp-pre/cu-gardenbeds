namespace GardenApp.Core
{
    public class MoistureSensor:Sensor
    {
        public MoistureSensor(string name, string serieNr) 
            : base(name, serieNr)
        {
        }


        public override double GetMeasurement()
        {
            throw new System.NotImplementedException();
        }
    }
}