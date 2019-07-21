using PetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetReporter.Models
{
    class ReportRepoTest : IReportRepo
    {
        private static SQLServerConnection _connection;

        public ReportRepoTest(PetLib.SQLServerConnection connection)
        {
            _connection = connection;
        }

        public List<Owner> GetOwners()
        {
            return new List<Owner>()
           {
            
            new Owner { OwnerID = 2, FullName = "Janet Moralee" },
            new Owner { OwnerID = 8, FullName = "Rhona Ronstadt" },
            new Owner { OwnerID = 10, FullName = "Andy McClure" },
            new Owner { OwnerID = 11, FullName = "Dave Mateer" }

           };
        }

        public List<Animal> GetAnimals(Owner owner)
        {
            var animals = new List<Animal>()
            {
                new Animal { FullName = "Rhona Ronstadt", JoinedPractice = Convert.ToDateTime("2014/09/23 00:00:00"), AnimalName = "Willow", Type = "Horse", NumberOfVisits = 2, CostPerVisit = Convert.ToDecimal("75.00"), Behaviour = null, OwnerID = 8 },
                new Animal { FullName = "Dave Mateer", JoinedPractice = Convert.ToDateTime("2004/11/11 00:00:00"), AnimalName = "Smokey", Type = "Cat", NumberOfVisits = 3, CostPerVisit = Convert.ToDecimal("56.36"), Behaviour = "9 Lives", OwnerID = 11 },
                new Animal { FullName = "Janet Moralee", JoinedPractice = Convert.ToDateTime("2016/01/08 00:00:00"), AnimalName = "Charles De Gaulle", Type = "Parrot", NumberOfVisits = 2, CostPerVisit = Convert.ToDecimal("68.00"), Behaviour = "Speaks French", OwnerID = 2},
                new Animal { FullName = "Andy McClure", JoinedPractice = Convert.ToDateTime("2019/06/01 00:00:00"), AnimalName = "Murphy", Type = "Dog", NumberOfVisits = 2, CostPerVisit = Convert.ToDecimal("44.25"), Behaviour = "Walks on Hind Legs", OwnerID = 10 }


            };

            if (owner != null)
            {
                var animal1 = animals.Where(a => a.OwnerID == owner.OwnerID).ToList();

                return animal1;
            }

            return animals;
        }

    }
}
