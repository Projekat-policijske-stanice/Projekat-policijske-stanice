using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayerTests
{
    [TestClass]
    public class VehicleBusinessTests
    {
        private Mock<IVehicleRepository> mockVehicleRepository = new Mock<IVehicleRepository>();
        private Vehicle vehicle = new Vehicle
        {
            Id = 3,
            Name = "Skoda Superb",
            Type = "2.0 Dizel",
            Condition = "Na terenu",
            Consumption = 6.10m,
            Correctness = "Ispravan"
        };
        private List<Vehicle> listOfVehicles = new List<Vehicle>();
        private VehicleBusiness vehicleBusiness;

        [TestMethod]
        public void VehicleUpdated()
        {

            //Arange
            mockVehicleRepository.Setup(x => x.UpdateVehicle(vehicle)).Returns(1);
            this.vehicleBusiness = new VehicleBusiness(mockVehicleRepository.Object);

            //Act
            var result = vehicleBusiness.UpdateVehicle(vehicle);

            //Asert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void GetAllVehicle()
        {
            //Arange
            listOfVehicles.Add(new Vehicle 
            {
                Id = 3,
                Name = "Skoda Superb",
                Type = "2.0 Dizel",
                Condition = "Na terenu",
                Consumption = 6.10m,
                Correctness = "Ispravan"
            });
            listOfVehicles.Add(new Vehicle
            {
                Id = 4,
                Name = "Skoda Octavia",
                Type = "1.9 Dizel",
                Condition = "U garazi",
                Consumption = 5.20m,
                Correctness = "Ispravan"
            });
            listOfVehicles.Add(new Vehicle
            {
                Id = 5,
                Name = "Fiat Punto",
                Type = "1.4 Benzin",
                Condition = "Na terenu",
                Consumption = 4.10m,
                Correctness = "Ispravan"
            });
            mockVehicleRepository.Setup(a => a.GetAllVehicles()).Returns(listOfVehicles);
            this.vehicleBusiness = new VehicleBusiness(mockVehicleRepository.Object);

            //Act
            var result = vehicleBusiness.GetAllVehicles();

            //Asert
            Assert.AreEqual(3, result.Count);
        }
    }
}
