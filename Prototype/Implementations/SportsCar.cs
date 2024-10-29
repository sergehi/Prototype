using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementations
{
    public class SportsCar : GasolineCar
    {
        public int HorsePower { get; set; }

        public SportsCar(string make, string model, int year, string gasolineType, int horsePower)
            : base(make, model, year, gasolineType)
        {
            CarType = "Спортивный автомобиль";
            HorsePower = horsePower;
        }

        public override Car CloneObj()
        {
            return new SportsCar(Make, Model, Year, GasolineType, HorsePower);
        }
    }
}
