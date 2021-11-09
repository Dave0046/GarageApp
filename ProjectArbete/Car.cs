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
        public Car(string regNumber, string Color, string Brand, string Type, int NumberOfTires, int NumberOfPassengers, int numberOfSeats, bool combi) :
    base(regNumber, Color, Brand, Type, NumberOfTires, NumberOfPassengers)
        {
            NumberOfSeats = numberOfSeats;
            Combi = combi;
        }
    }
}