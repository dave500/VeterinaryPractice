using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLib
{
    public static class Reporter
    {
        

        



        public static bool WriteToXls(string dataToWrite)
        {
            try
            {
                string destination = DateTime.Now.ToString("dd_MM_yyyy_HH_mm") + "VetCustomerReport";
                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    destination = destination.Replace(c, '_');
                }
                destination = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + destination + ".xlsx";
                FileStream fs = new FileStream(destination, FileMode.Create, FileAccess.Write);
                StreamWriter objWrite = new StreamWriter(fs);
                objWrite.Write(dataToWrite);
                objWrite.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
