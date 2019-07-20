using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLib
{
    public class Animal : Owner
    {
        public int AnimalID { get; set; }
        public int PetID { get; set; }
        public int NumberOfVisits { get; set; }
        public DateTime JoinedPractice { get; set; }
        public int AnimalType { get; set; }
        public int CostPerVisit { get; set; }
    }
}
