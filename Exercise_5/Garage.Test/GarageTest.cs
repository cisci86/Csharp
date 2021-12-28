using Exercise_5;
using Xunit;

namespace Garage.Test
{
    public class GarageTest
    {
        [Fact]
        public void AddVehicle_AddedToSlotIsTrue()
        {
            //Arrange
            Garage<Vehicle> garage = new Garage<Vehicle>(5);
            bool added = false;
            var expected = true;

            //Act
            //added = garage.AddVehicle();

            //Assert
            Assert.Equal(expected, added);
        }
    }
}