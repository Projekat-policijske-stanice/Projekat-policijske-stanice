using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PresentationLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayerTests
{
    [TestClass]
    public class FormPolicemenTests
    {
        [TestMethod]
        public void TestRefreshData()
        {
            // Arrange
            List<Policeman> listOfPolicemen = new List<Policeman>()
            {
                new Policeman()
                {
                    Id = 1,
                    Name = "Djordje",
                    Surname = "Obradovic",
                    JMBG = "1210994741520",
                    Gender = "Muski",
                    Shift = "Druga",
                    Status = "Odsutan"
                },
                new Policeman()
                {
                    Id = 1,
                    Name = "Jovana",
                    Surname = "Obilic",
                    JMBG = "1210994741520",
                    Gender = "Muski",
                    Shift = "Prva",
                    Status = "Prisutan"
                },
                new Policeman()
                {
                    Id = 1,
                    Name = "Jelena",
                    Surname = "Kraljevic",
                    JMBG = "1210994741520",
                    Gender = "Muski",
                    Shift = "Prva",
                    Status = "Prisutan"
                },
                new Policeman()
                {
                    Id = 1,
                    Name = "Milica",
                    Surname = "Milosevic",
                    JMBG = "1210994741520",
                    Gender = "Muski",
                    Shift = "Druga",
                    Status = "Odsutan"
                }
            };

            var mockPolicemanBusinesss = new Mock<IPolicemanBusiness>();

            mockPolicemanBusinesss.Setup(r => r.GetAllPolicemen()).Returns(listOfPolicemen);

            var form = new formPolicemen(mockPolicemanBusinesss.Object);

            // Act
            PrivateObject obj = new PrivateObject(form);
            obj.Invoke("RefreshData");

            DataGridView dataGridPolicemen = (DataGridView)obj.GetFieldOrProperty("dataGridPolicemen");

            // Assert
            Assert.AreEqual(4, dataGridPolicemen.RowCount);
        }
    }
}
