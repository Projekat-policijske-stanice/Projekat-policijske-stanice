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
    public class PolicemanBusinessTests
    {
        private Mock<IPolicemanRepository> mockPolicemanRepository = new Mock<IPolicemanRepository>();
        private Policeman policeman = new Policeman
        {
            Id = 1,
            Name = "Djordje",
            Surname = "Obradovic",
            JMBG = "1210994741520",
            Gender = "Muski",
            Shift = "Druga",
            Status = "Odsutan"
        };
        private List<Policeman> listOfPoliceman = new List<Policeman>();
        private PolicemanBusiness policemanBusiness;

        [TestMethod]
        public void PolicemanInserted()
        {

            //Arange
            mockPolicemanRepository.Setup(x => x.InsertPoliceman(policeman)).Returns(1);
            this.policemanBusiness = new PolicemanBusiness(mockPolicemanRepository.Object);

            //Act
            var result = policemanBusiness.InsertPoliceman(policeman);

            //Asert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void GetAllPolicemen()
        {
            //Arange
            listOfPoliceman.Add(new Policeman
            {
                Id = 1,
                Name = "Djordje",
                Surname = "Obradovic",
                JMBG = "1210994741520",
                Gender = "Muski",
                Shift = "Druga",
                Status = "Odsutan"
            });
            listOfPoliceman.Add(new Policeman
            {
                Id = 1,
                Name = "Djordje",
                Surname = "Obradovic",
                JMBG = "1210994741520",
                Gender = "Muski",
                Shift = "Druga",
                Status = "Odsutan"
            });
            listOfPoliceman.Add(new Policeman
            {
                Id = 1,
                Name = "Djordje",
                Surname = "Obradovic",
                JMBG = "1210994741520",
                Gender = "Muski",
                Shift = "Druga",
                Status = "Odsutan"
            });
            mockPolicemanRepository.Setup(x => x.GetAllPolicemen()).Returns(listOfPoliceman);
            policemanBusiness = new PolicemanBusiness(mockPolicemanRepository.Object);

            //Act
            var result = policemanBusiness.GetAllPolicemen();

            //Assert
            Assert.AreEqual(3, result.Count);
        }

    }
}
