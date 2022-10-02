using System;

namespace GardenApp.Core
{
    public class Person
    {
        /*
         * - name:string => 1'
         * ------------------
         * + GetName():string => 1
         * + SetName(string) => 2
         */
        public string Name { get; /*1*/ set; /*2*/ }
        /*
         * - address: string
         * ------------------
         * + GetAddress():string
         */
        private string address;
        public string Address
        {
            get { return address; }
        }
        /*- dob: DateTime
         * ------------------
        + GetDob(): DateTime
        -  SetDob(DateTime)
        */
        public DateTime Dob { get; private set; }

        public Person(string address, string name, DateTime dob)
        {
            this.address = address;
            Name = name;
            Dob = dob;
        }
    }
}