using Caliburn.Micro;
using PetLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetReporter.Helpers
{
    public static class ReportViewHelper
    {
        public static bool FormatCSVString(BindableCollection<Animal> animals)
        {
            var csv = new StringBuilder();

            try
            {
                // Define Header
                var header = String.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"",
                                           "Name",
                                           "Joined Practice",
                                           "Animal Name",
                                           "Species",
                                           "Number of Visits",
                                           "Cost Per Visit",
                                           "Character"
                                          );
                csv.AppendLine(header);


                foreach (var item in animals)
                {
                    var row = String.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"",
                                          item.FullName,
                                          item.JoinedPractice.ToShortDateString(),
                                          item.AnimalName,
                                          item.Type,
                                          item.NumberOfVisits,
                                          item.CostPerVisit,
                                          item.Behaviour
                                         );
                    csv.AppendLine(row);
                }

                string fileName = string.Concat(DateTime.Now.ToString("yyyyMMddHHmmssfff"), "-VetCustomer.csv");
                string filepath = string.Format(@"C:\\Temp\{0}", fileName);

                File.WriteAllText(filepath, csv.ToString());

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        
        }
    }
}
