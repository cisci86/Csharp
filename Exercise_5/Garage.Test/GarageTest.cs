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
            Garage<string> garage = new Garage<string>(5);
            bool added = false;
            var expected = true;

            //Act
            added = garage.AddVehicle("Hej hopp");

            //Assert
            Assert.Equal(expected, added);
        }
    }
}