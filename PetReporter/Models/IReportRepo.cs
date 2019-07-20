using PetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace PetReporter.Models
{
    public interface IReportRepo
    {
        List<Owner> GetOwners();
        List<Animal> GetAnimals(Owner _owner);
    }
}
