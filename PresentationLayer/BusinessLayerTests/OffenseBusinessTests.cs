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
    public class OffenseBusinessTests
    {
        private Mock<IOffenseRepository> mockOffenseRepository = new Mock<IOffenseRepository>();
        private Offense offense = new Offense
        {
            PolicemanId = 1,
            VehicleId = 2,
            Date = Convert.ToDateTime("12-02-2020 21:20")
        };
        private List<Offense> listOfOffenses = new List<Offense>();
        private OffenseBusiness offenseBusiness;

        [TestMethod]
        public void OffenseInserted()
        {

            //Arange
            mockOffenseRepository.Setup(x => x.InsertOffense(offense)).Returns(1);
            this.offenseBusiness = new OffenseBusiness(mockOffenseRepository.Object);

            //Act
            var result = offenseBusiness.InsertOffense(offense);

            //Asert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void OffenseDeleted()
        {
            //Arange
            mockOffenseRepository.Setup(a => a.DeleteOffense(offense)).Returns(1);
            this.offenseBusiness = new OffenseBusiness(mockOffenseRepository.Object);

            //Act
            var result = offenseBusiness.DeleteOffense(offense);

            //Asert
            Assert.IsTrue(result);
        }
    }
}
