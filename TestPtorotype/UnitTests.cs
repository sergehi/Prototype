using Prototype.Implementations;

namespace TestPtorotype
{
    public class ProtypeUnitTest
    {

        [Fact]
        public void GasolineCar_Clone_ShouldCreateDifferentInstance()
        {
            // Arrange
            var original = new GasolineCar("Lada", "Granta", 2022, "SuperEuro");
            // Act
            var cloned = (GasolineCar)original.Clone();
            // Assert
            Assert.NotSame(original, cloned); // Проверяем, что это разные экземпляры
            Assert.Equal(original.Make, cloned.Make);
            Assert.Equal(original.Model, cloned.Model);
            Assert.Equal(original.Year, cloned.Year);
            Assert.Equal(original.GasolineType, cloned.GasolineType);
        }
        [Fact]
        public void GasolineCar_CloneObj_ShouldCreateDifferentInstance()
        {
            // Arrange
            var original = new GasolineCar("Laga", "Granta", 2022, "SuperEuro");

            // Act
            var cloned = (GasolineCar)original.CloneObj();

            // Assert
            Assert.NotSame(original, cloned); // Проверяем, что это разные экземпляры
            Assert.Equal(original.Make, cloned.Make);
            Assert.Equal(original.Model, cloned.Model);
            Assert.Equal(original.Year, cloned.Year);
            Assert.Equal(original.GasolineType, cloned.GasolineType);
        }

        [Fact]
        public void DieselCar_Clone_ShouldCreateDifferentInstance()
        {
            // Arrange
            var original = new DieselCar("Lada", "Granta", 2022);
            // Act
            var cloned = (DieselCar)original.Clone();
            // Assert
            Assert.NotSame(original, cloned); // Проверяем, что это разные экземпляры
            Assert.Equal(original.Make, cloned.Make);
            Assert.Equal(original.Model, cloned.Model);
            Assert.Equal(original.Year, cloned.Year);
            Assert.Equal(original.Fuel, cloned.Fuel);
        }
        [Fact]
        public void DieselCar_CloneObj_ShouldCreateDifferentInstance()
        {
            // Arrange
            var original = new DieselCar("Laga", "Granta", 2022);

            // Act
            var cloned = (DieselCar)original.CloneObj();

            // Assert
            Assert.NotSame(original, cloned); // Проверяем, что это разные экземпляры
            Assert.Equal(original.Make, cloned.Make);
            Assert.Equal(original.Model, cloned.Model);
            Assert.Equal(original.Year, cloned.Year);
            Assert.Equal(original.Fuel, cloned.Fuel);
        }


        [Fact]
        public void ElectricCar_Clone_ShouldCreateDifferentInstance()
        {
            // Arrange
            var original = new ElectricCar("Tesla", "Model S", 2022, 100);

            // Act
            var cloned = (ElectricCar)original.Clone();

            // Assert
            Assert.NotSame(original, cloned); // Проверяем, что это разные экземпляры
            Assert.Equal(original.Make, cloned.Make);
            Assert.Equal(original.Model, cloned.Model);
            Assert.Equal(original.Year, cloned.Year);
            Assert.Equal(original.BatteryCapacity, cloned.BatteryCapacity);
        }
        [Fact]
        public void ElectricCar_CloneObj_ShouldCreateDifferentInstance()
        {
            // Arrange
            var original = new ElectricCar("Tesla", "Model S", 2022, 100);

            // Act
            var cloned = (ElectricCar)original.CloneObj();

            // Assert
            Assert.NotSame(original, cloned); // Проверяем, что это разные экземпляры
            Assert.Equal(original.Make, cloned.Make);
            Assert.Equal(original.Model, cloned.Model);
            Assert.Equal(original.Year, cloned.Year);
            Assert.Equal(original.BatteryCapacity, cloned.BatteryCapacity);
        }

        [Fact]
        public void SportsCar_Clone_ShouldCreateDifferentInstance()
        {
            // Arrange
            var original = new SportsCar("Ferrari", "488", 2021, "Аи95", 670);

            // Act
            var cloned = (SportsCar)original.Clone();

            // Assert
            Assert.NotSame(original, cloned); // Проверяем, что это разные экземпляры
            Assert.Equal(original.Make, cloned.Make);
            Assert.Equal(original.Model, cloned.Model);
            Assert.Equal(original.Year, cloned.Year);
            Assert.Equal(original.HorsePower, cloned.HorsePower);
        }
        [Fact]
        public void SportsCar_CloneObj_ShouldCreateDifferentInstance()
        {
            // Arrange
            var original = new SportsCar("Ferrari", "488", 2021, "Аи95", 670);

            // Act
            var cloned = (SportsCar)original.CloneObj();

            // Assert
            Assert.NotSame(original, cloned); // Проверяем, что это разные экземпляры
            Assert.Equal(original.Make, cloned.Make);
            Assert.Equal(original.Model, cloned.Model);
            Assert.Equal(original.Year, cloned.Year);
            Assert.Equal(original.HorsePower, cloned.HorsePower);
        }

    }
}