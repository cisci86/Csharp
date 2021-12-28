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
            Vehicle vehicle = new Vehicle("ABC123", Color.Red, 4);

            //Act
            added = garage.AddVehicle(vehicle);

            //Assert
            Assert.Equal(expected, added);
        }
        
        [Fact]
        public void IsFull_ReturnTrue()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(1);
            Vehicle vehicle = new Vehicle("ABC123", Color.Yellow, 4);

            garage.AddVehicle(vehicle);
            bool isFull = garage.IsFull();

            Assert.True(isFull);
        }

        [Fact]
        public void IsFull_ReturnFalse()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(3);
            Vehicle vehicle = new Vehicle("ABC123", Color.Yellow, 4);

            garage.AddVehicle(vehicle);
            bool isFull = garage.IsFull();

            Assert.False(isFull);
        }
        [Fact]
        public void IsEmpty_ReturnTrue()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(1);
            bool isEmpty = garage.IsEmpty();

            Assert.True(isEmpty);
        }
        [Fact]
        public void IsEmpty_ReturnFalse()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(3);
            Vehicle vehicle = new Vehicle("ABC123", Color.Yellow, 4);

            garage.AddVehicle(vehicle);
            bool isEmpty = garage.IsEmpty();

            Assert.False(isEmpty);
        }
        [Fact]
        public void RemoveVehicle_Removed()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(3);
            Vehicle vehicle = new Vehicle("ABC123", Color.Yellow, 4);
            var expected = true;

            garage.AddVehicle(vehicle);
            garage.RemoveVehicle(0);
            var acctual = garage.IsEmpty();
            
            Assert.Equal(expected, acctual);
        }

        //Jag kom inte på något bra sätt att testa "GetArray()" Funktionen så det har jag inte gjort.
    }
}