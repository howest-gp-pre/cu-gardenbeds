using System;

namespace GardenApp.Core
{
    public class TemperatureSensor:Sensor
    {
        public TemperatureSensor(string name, string serieNr) : base(name, serieNr)
        {
        }

        public override double GetMeasurement()
        {
            SerieNr = Guid.NewGuid().ToString();
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
             return $"Temperature {base.ToString()}";
        }
    }
}