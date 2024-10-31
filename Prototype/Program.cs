//0.Придумать и создать 3-4 класса, которые как минимум дважды наследуются и написать краткое описание текстом.
//     см. \Implementations\Classes.txt
//1. Создать свой дженерик интерфейс IMyCloneable для реализации шаблона "Прототип".

//2. Сделать возможность клонирования объекта для каждого из этих классов, используя вызовы родительских конструкторов.

//3. Составить тесты или написать программу для демонстрации функции клонирования.

//4. Добавить к каждому классу реализацию стандартного интерфейса ICloneable и реализовать его функционал через уже созданные методы.

//5. Написать вывод: какие преимущества и недостатки у каждого из интерфейсов: IMyCloneable и ICloneable.


using Prototype.Implementations;
using Prototype.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаем массив автомобилей разных типов
        Car[] cars = { 
            new ElectricCar("Tesla", "Model S", 2022, 100), 
            new DieselCar("Volvo", "XC60 B4", 2021), 
            new GasolineCar("Audi", "A3", 2023, "Аи95"), 
            new SportsCar("Ferrari", "488", 2021, "Аи95", 670) 
        };
        
        // По каждому автомобилю в массиве
        foreach (var car in cars)
        {
            // Информация об исходном автомобиле
            Console.WriteLine("Исходный автомобиль:");
            PrintCarInfo(car);
            var clonedCarByMyClonable = car.CloneObj();
            // Информация об автомобиле, клонированном с помощью метода IMyCloneable.CloneObj()
            Console.WriteLine("Клонированный(CloneObj())");
            PrintCarInfo(clonedCarByMyClonable);
            var clonedCarByClonable = (Car)car.Clone();
            // Информация об автомобиле, клонированном с помощью метода ICloneable.Clone()
            Console.WriteLine("Клонированный(Clone())");
            PrintCarInfo(clonedCarByClonable);
            Console.WriteLine("");
        }
        Console.ReadKey();
    }

    // Вывод свойств автомобиля в зависимости от его типа
    private static void PrintCarInfo(ICar car)
    {
        // Общие свойства
        Console.WriteLine($"Тип:{car.CarType},\tПроизводитель: {car.Make},\tМодель: {car.Model},\tГод: {car.Year}");
        
        // Свойства, зависящие от типа
        if (car is ElectricCar electricCar)
            Console.WriteLine($"- Батарея: {electricCar.BatteryCapacity} кВтч");
        else if (car is SportsCar sportsCar)
            Console.WriteLine($"- Тип бензина: {sportsCar.GasolineType}, Мощность: {sportsCar.HorsePower}");
        else if (car is GasolineCar gasolineCar)
            Console.WriteLine($"- Тип бензина: {gasolineCar.GasolineType}");
        else if (car is DieselCar dieselCar)
            Console.WriteLine($"- Тип топлива: {dieselCar.Fuel}");
    }
}