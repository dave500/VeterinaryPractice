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


        public ReportViewModel(IReportRepo reportRepo, IWindowManager windowManager)
        {
            _reportRepo = reportRepo;
            _windowManager = windowManager;
            Owners = new BindableCollection<Owner>(reportRepo.GetOwners());
        }

        private BindableCollection<Owner> _owners = new BindableCollection<Owner>();
        private String _title = "Park View Veterinary Practice";
        private String _subTitle = "Report Generator";
        private String _ownerDDLabel = "Select Owner";


        public BindableCollection<Owner> Owners
        {
            get { return _owners; }
            set { _owners = value; }
        }

        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public String SubTitle
        {
            get { return _subTitle; }
            set { _subTitle = value; }
        }

        public String OwnerLabel
        {
            get { return _ownerDDLabel; }
            set { _ownerDDLabel = value; }
        }

        private Owner _selectedOwner;

        public Owner SelectedOwner
        {
            get { return _selectedOwner; }
            set
            {
                _selectedOwner = value;
                NotifyOfPropertyChange(() => SelectedOwner);
            }
        }

    }
}
