using Prototype.Implementations;

namespace TestPtorotype
{
    public class ProtypeUnitTest
    {
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
    }
}