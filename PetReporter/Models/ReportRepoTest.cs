using PetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetReporter.Models
{
    class ReportRepoTest
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
            new Owner { OwnerID = 1, FullName = "Dave Hinton" },
            new Owner { OwnerID = 2, FullName = "Janet Moralee" },
            new Owner { OwnerID = 3, FullName = "Phil Irons" },
            new Owner { OwnerID = 4, FullName = "Mike Hadlow" },
            new Owner { OwnerID = 5, FullName = "Kelly Smith" },
             new Owner { OwnerID = 6, FullName = "Chris Tull" },
              new Owner { OwnerID =7, FullName = "Steve Whittle" },
               new Owner { OwnerID = 8, FullName = "Rhona Ronstadt" },
              new Owner { OwnerID = 9, FullName = "Sophie Travel" },
               new Owner { OwnerID = 10, FullName = "Andy McClure" },
                new Owner { OwnerID = 11, FullName = "Dave Mateer" },

           };
        }

        public List<Animal> GetAnimals(Owner owner)
        {
            return new List<Animal>();
        }

    }
}
