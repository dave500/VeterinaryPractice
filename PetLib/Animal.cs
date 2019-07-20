﻿using System;
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
        public int OwnerID { get; set; }
        public String Type { get; set; }
        public String AnimalName { get; set; }
        public DateTime JoinedPractice { get; set; }
        public String Behaviour { get; set; }
        public int NumberOfVisits { get; set; }
        public decimal TotalCost { get; set; }
        public decimal CostPerVisit { get; set; }
    }
}
