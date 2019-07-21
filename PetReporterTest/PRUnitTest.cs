using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PetReporter.Models;
using PetLib;
using System.Collections.Generic;
using Caliburn.Micro;
using PetReporter.ViewModels;

namespace PetReporterTest
{
    [TestClass]
    public class PRUnitTest
    {

        private Mock<IReportRepo> reportRepo;
        private Mock<IWindowManager> windowManager;


        [TestMethod]
        public void TestRepo()
        {
            reportRepo = new Mock<IReportRepo>();


            reportRepo.Setup(m => m.GetOwners()).Returns(new List<Owner>() { new Owner { OwnerID = 1, FullName = "Dave Hinton" },
            new Owner { OwnerID = 2, FullName = "Janet Moralee" },
            new Owner { OwnerID = 3, FullName = "Phil Irons" },
            new Owner { OwnerID = 4, FullName = "Mike Hadlow" },
            new Owner { OwnerID = 5, FullName = "Kelly Smith" },
            new Owner { OwnerID = 6, FullName = "Chris Tull" },
            new Owner { OwnerID = 7, FullName = "Steve Whittle" },
            new Owner { OwnerID = 8, FullName = "Rhona Ronstadt" },
            new Owner { OwnerID = 9, FullName = "Sophie Travel" },
            new Owner { OwnerID = 10, FullName = "Andy McClure" },
            new Owner { OwnerID = 11, FullName = "Dave Mateer" } });

            var owners = reportRepo.Object.GetOwners();

            Assert.AreEqual(owners.Count, 11);
            
        }

        [TestMethod]
        public void TestGetOwnerViewModel()
        {
            windowManager = new Mock<IWindowManager>();
            reportRepo = new Mock<IReportRepo>();

            reportRepo.Setup(m => m.GetOwners()).Returns(new List<Owner>() { new Owner { OwnerID = 1, FullName = "Dave Hinton" },
            new Owner { OwnerID = 2, FullName = "Janet Moralee" },
            new Owner { OwnerID = 3, FullName = "Phil Irons" },
            new Owner { OwnerID = 4, FullName = "Mike Hadlow" },
            new Owner { OwnerID = 5, FullName = "Kelly Smith" },
            new Owner { OwnerID = 6, FullName = "Chris Tull" },
            new Owner { OwnerID = 7, FullName = "Steve Whittle" },
            new Owner { OwnerID = 8, FullName = "Rhona Ronstadt" },
            new Owner { OwnerID = 9, FullName = "Sophie Travel" },
            new Owner { OwnerID = 10, FullName = "Andy McClure" },
            new Owner { OwnerID = 11, FullName = "Dave Mateer" } });


            var ownerViewModel = new OwnerViewModel(reportRepo.Object, windowManager.Object);
            

            Assert.AreEqual(ownerViewModel.Owners.Count, 11);


        }

    }
}
