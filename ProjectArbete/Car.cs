using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApplication
{
    public class Car : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public bool Combi { get; set; }
        public Car(string RegNumber, string Color, string Brand, string Type, int NumberOfTires, int numberOfSeats, bool combi) :
    base(RegNumber, Color, Brand, Type, NumberOfTires)
        {
            NumberOfSeats = numberOfSeats;
            Combi = combi;
        }
    }
}