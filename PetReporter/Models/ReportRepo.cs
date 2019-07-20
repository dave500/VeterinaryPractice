using PetDAL;
using PetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetReporter.Models
{
    public class ReportRepo : IReportRepo
    {
        private static SQLServerConnection _connection;
        private static DALManager _dalMgr = new DALManager(_connection);

        public ReportRepo(SQLServerConnection connection)
        {
            _connection = connection;
        }

        public List<Owner> GetOwners()
        {
           return _dalMgr.GetOwners();
        }
    }
}
