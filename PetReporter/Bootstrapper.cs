using Caliburn.Micro;
using PetReporter.Models;
using PetReporter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetReporter
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer container = new SimpleContainer();


        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            container = new SimpleContainer();

            container.Singleton<IReportRepo, ReportRepoTest>();
            container.Singleton<IEventAggregator, EventAggregator>();
            container.Singleton<IWindowManager, WindowManager>();

            container.PerRequest<OwnerViewModel>();
        }


        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<OwnerViewModel>();
        }



        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }



        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }



        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}
