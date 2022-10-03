using System;

namespace GardenApp.Core;

public class Person
{
    public string Name { get; set; }
    public string Address { get; }
    public DateTime Dob { get; }

    public Person(string name, string address, DateTime dob)
    {
        Name = name;
        Address = address;
        Dob = dob;
    }
}