using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApplication
{
    public class Garage<T>:IEnumerable<Vehicle> where T: Vehicle
    {
        List<T> listVehicle = new List<T>();
        public string GarageName { get; set; }
        public Garage()
        {
        }
        public Garage(string GarageName)
        {
            this.GarageName = GarageName;
        }
        public void AddVehicle(T vehicle)
        {
            listVehicle.Add(vehicle);
        }

        public bool RemoveVehicle(string regNumber)
        {
            T vehicle = SearchVehicle(regNumber);
            if ( vehicle!= null)
            {
                listVehicle.Remove(vehicle);
                return true;
            }
            return false;
        }

        public T SearchVehicle(string regNumber)
        {
            foreach (var vehicle in listVehicle)
            {
                if (vehicle.RegNumber.CompareTo(regNumber) == 0)
                    return vehicle;
            }
            return null;
        }


        public void FindAllWithColor()
        {
            List<string> colors= listVehicle.Select(u => u.Color).Distinct().ToList();
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }

        public void FindAllWithWheels()
        {
            List<int> wheels = listVehicle.Select(u => u.NumberOfTires).Distinct().ToList();
            foreach (var tire in wheels)
            {
                Console.WriteLine(tire);
            }
        }

        public void FindAllWithPassengers()
        {
            List<int> passengers = listVehicle.Select(u => u.NumberOfPassengers).Distinct().ToList();
            foreach (var passenger in passengers)
            {
                Console.WriteLine(passengers);
            }
        }




        public List<T> ListVehicle()
        {
            return listVehicle;
        }

        public List<string> ListTypeVehicle()
        {
            return listVehicle.Select(u => u.Type).Distinct().ToList();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Vehicle> GetEnumerator()
        {
            return listVehicle.GetEnumerator();
        }

    }
}