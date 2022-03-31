using System;
using Properties;
namespace Vehicles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Brand = "E38",
                Model = "BMW",
                FuelForKm = 2,
                CurrentFuel = 80
            };
            car.Drive(4);
            car.Show();
        }
    }
}
