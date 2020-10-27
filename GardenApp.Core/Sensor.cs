using System;

namespace GardenApp.Core
{
    public abstract class Sensor:ISensor
    {
        private string name;
        private double latestValue;

        public string SerieNr { get; protected set; }

        public Sensor(string name, string serieNr)
        {
            this.name = name;
            SerieNr = serieNr;
        }

        internal void SetSerieNr(string serieNr)
        {
            SerieNr = serieNr;
        }

        public abstract double GetMeasurement();

        public override string ToString()
        {
            var output = String.Empty;
            output += $"Sensor: ({SerieNr})";
            return output;
        }
    }
}