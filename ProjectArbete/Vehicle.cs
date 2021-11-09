using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApplication
{
    public class Vehicle
    {
        public string RegNumber{ get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int NumberOfTires { get; set; }
        public int NumberOfPassengers { get; set; }
        public Vehicle(string regNumber, string Color, string Brand, string Type, int NumberOfTires, int NumberOfPassengers)
        {
            this.RegNumber = regNumber;
            this.Color = Color;
            this.Brand = Brand;
            this.Type = Type;
            this.NumberOfTires = NumberOfTires;
            this.NumberOfPassengers = NumberOfPassengers;
        }

        public override string ToString()
        {
            return RegNumber + "\t" + Color + "\t" + Brand + "\t" + Type + "\t" + NumberOfTires + "\t" + NumberOfPassengers;
        }
    }
}