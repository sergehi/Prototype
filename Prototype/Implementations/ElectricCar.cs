using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementations
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; } // в кВтч

        public ElectricCar(string make, string model, int year, int batteryCapacity)
            : base(make, model, year)
        {
            CarType = "Автомобиль с электрическим двигателем";
            BatteryCapacity = batteryCapacity;
        }

        public override Car CloneObj()
        {
            return new ElectricCar(Make, Model, Year, BatteryCapacity);
        }
    }
}
