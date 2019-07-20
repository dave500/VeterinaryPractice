using Caliburn.Micro;
using PetLib;
using PetReporter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetReporter.ViewModels
{
    public class ReportViewModel : Screen
    {
        private readonly IReportRepo _reportRepo;
        private readonly IWindowManager _windowManager;
        private readonly Owner _owner;


        public ReportViewModel(IReportRepo reportRepo, IWindowManager windowManager, Owner owner)
        {
            _reportRepo = reportRepo;
            _windowManager = windowManager;
            _owner = owner;
            Animals = new BindableCollection<Animal>(_reportRepo.GetAnimals(_owner));
        }

        private String _title = "Park View Veterinary Practice";
        private String _subTitle = "Report Generator";
        private String _ownerDDLabel = "Select Owner";

        private BindableCollection<Animal> _animals = new BindableCollection<Animal>();
       


        public BindableCollection<Animal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }
    }
}
