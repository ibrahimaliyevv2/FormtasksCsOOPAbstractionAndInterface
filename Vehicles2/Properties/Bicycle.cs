using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Bicycle : IVehicle, IDrivable
    {
        private double _millage;
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Millage { get => _millage; }

        public void Drive(double km)
        {
            _millage+=km;
        }
    }
}
