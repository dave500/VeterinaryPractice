using Caliburn.Micro;
using PetLib;
using PetReporter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        private String _reportMessage = "";
        private String _reportColour = "";
      

        private BindableCollection<Animal> _animals = new BindableCollection<Animal>();

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

        public String ReportMessage
        {
            get { return _reportMessage; }
            set {
                _reportMessage = value;
                NotifyOfPropertyChange(() => ReportMessage);
            }
        }

        public String ReportColour
        {
            get { return _reportColour; }
            set
            {
                _reportColour = value;
                NotifyOfPropertyChange(() => ReportColour);
            }
        }

        public BindableCollection<Animal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }

       

        public void ExportCSV()
        {
            bool status = Helpers.ReportViewHelper.FormatCSVString(Animals);

            if (status)
            {
                ReportMessage = "Report Has Been Sussefully Created";
                ReportColour = "Green";
            }
            else
            {
                ReportMessage = @"Error: Please ensure directory c:\temp exists";
                ReportColour = "red";
            }
        }

        // Navigation
        public void ReturnHome()
        {

            _windowManager.ShowWindow(new OwnerViewModel(_reportRepo, _windowManager));
            (GetView() as Window).Close();
        }
    }
}
