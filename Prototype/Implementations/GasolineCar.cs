using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementations
{
    public class GasolineCar : Car
    {
        public string GasolineType { get; set; }
        public GasolineCar(string make, string model, int year, string gasolineType)
            : base(make, model, year)
        {
            CarType = "Автомобиль с бензиновым двигателем";
            GasolineType = gasolineType;
        }
        public override Car CloneObj()
        {
            return new GasolineCar(Make, Model, Year, GasolineType);
        }

    }
}
