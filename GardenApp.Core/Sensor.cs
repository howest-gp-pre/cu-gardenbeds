using System;

namespace GardenApp.Core
{
    public abstract class Sensor:ISensor
    {
        private string name;
        public string SerialNumber { get; protected set; }

        public Sensor(string name, string serialNumber)
        {
            this.name = name;
            SerialNumber = serialNumber;
        }

        public void SetSerieNr(string serieNr)
        {
            SerialNumber = serieNr;
        }

        public abstract double GetMeasurement();

        public override string ToString()
        {
            var output = String.Empty;
            output += $"Sensor: ({SerialNumber})";
            return output;
        }
    }
}