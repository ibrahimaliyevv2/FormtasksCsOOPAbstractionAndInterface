using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    interface IVehicle
    {
        
        string Brand { get; set; }
        string Model { get; set; }
        double Millage { get; }
    }
}
