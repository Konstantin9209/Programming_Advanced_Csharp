using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    { 
   
        Vehicles vehicles = new Vehicles();
        string[] input =
        {
            "{Car/Ford/Focus/120",
            "Car/Toyota/Camry/150",
            "Truck/Volvo/VNL/500"
        };
        // Arrange
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string result = vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        Vehicles vehicles1 = new Vehicles();
        string[] input = { };
        string expected = $"Cars:{Environment.NewLine}Trucks:";
        string result = vehicles1.AddAndGetCatalogue(input);
        Assert.AreEqual(expected, result);
    }
}
