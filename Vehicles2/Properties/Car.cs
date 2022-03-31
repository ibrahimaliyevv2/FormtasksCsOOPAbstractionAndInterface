using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Car:IVehicle, IDrivable
    {
        double _millage;
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Millage { get => _millage; }
        public int CurrentFuel { get; set; }
        public int FuelForKm { get; set; }

        public void Drive(double km)
        {
            if (km>0 && km*FuelForKm<CurrentFuel) {
                CurrentFuel -= FuelForKm;
                _millage += km;
            }
        }
        public void Show() {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Millage: {Millage}, Current Fuel: {CurrentFuel}");
        }
        
    }
}
