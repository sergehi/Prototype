using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementations
{
    internal class DieselCar : Car
    {
        public string Fuel { get; set; } = "Дизель";
        public DieselCar(string make, string model, int year) 
            : base(make, model, year)
        {
            CarType = "Автомобиль с дизельным двигателем";
        }
        public override Car CloneObj()
        {
            return new DieselCar(Make, Model, Year);
        }

    }
}
