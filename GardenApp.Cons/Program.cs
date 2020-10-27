using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GardenApp.Core;

namespace GardenApp.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGarden = new Garden();

            for (int i = 1; i <= 6; i++)
            {
                myGarden.AddGardenBed(new GardenBed(i));
            }
            
           // ... 
           
           // var sensor = new Sensor("sensor1", Guid.NewGuid().ToString());
           var tempSensor = new TemperatureSensor("sensor1", Guid.NewGuid().ToString());
           var gardenBed = myGarden.GardenBeds.First(); 
           gardenBed.AddSensor(tempSensor);
           Console.WriteLine(gardenBed.Sensors.First().SerieNr);

           Console.WriteLine(myGarden);
           Console.WriteLine("DONE");

        }
    }
}