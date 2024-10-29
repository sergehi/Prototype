using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Interfaces;

namespace Prototype.Implementations
{
    public class Car : ICar, IMyCloneable<Car>, ICloneable
    {
        public string CarType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            CarType = "Абстрактный автомобиль";
        }

        public virtual Car CloneObj()
        {
            return new Car(Make, Model, Year);
        }

        public object Clone()
        {
            return CloneObj();
        }
    }
}
