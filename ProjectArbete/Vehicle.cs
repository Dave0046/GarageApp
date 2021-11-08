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

        public Vehicle(string RegNumber, string Color, string Brand, string Type, int NumberOfTires)
        {
            this.RegNumber = RegNumber;
            this.Color = Color;
            this.Brand = Brand;
            this.Type = Type;
            this.NumberOfTires = NumberOfTires;
        }

        public override string ToString()
        {
            return RegNumber + "\t" + Color + "\t" + Brand + "\t" + Type + "\t" + NumberOfTires;
        }
    }
}