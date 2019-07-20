using Dapper;
using PetLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDAL
{
    public class DALManager
    {
        private readonly static string _localSqlServerConnection = @"Data Source =.\; Initial Catalog = VeterinaryPractice; Integrated Security = True";
        private readonly SQLServerConnection _sqlServerConnectionParams;

        /// <summary>
        ///  In reality I'd pass in a connection object from the App
        ///  but as this is a local test we'll use the string above
        /// </summary>
        /// <param name="connectionObj"></param>
        public DALManager(SQLServerConnection connectionObj)
        {
            _sqlServerConnectionParams = connectionObj;
        }


        public List<Owner> GetOwners()
        {
            List<Owner> owners = new List<Owner>();

            StringBuilder selectBuilder = new StringBuilder();

            selectBuilder.Append("SELECT OwnerID, RTRIM(FirstName) as FirstName, RTRIM(LastName) as LastName, ");
            selectBuilder.Append("RTRIM(FirstName) + ' ' + RTRIM(LastName) as FullName  FROM Owner");

            try
            {
                using (SqlConnection con = CreateSqlServerConnection())
                {
                    owners = con.Query<Owner>(selectBuilder.ToString()).ToList();
                }
            }
            catch (Exception e)
            {

                throw;
            }

            return owners;
        }

        public List<Animal> GetAnimals(Owner owner)
        {
            List<Animal> animals = new List<Animal>();

            StringBuilder selectBuilder = new StringBuilder();
            String whereClause = "";

            if (owner != null)
            {
                whereClause = String.Format("WHERE p.OwnerID = {0} ", owner.OwnerID);
            }
            

            selectBuilder.Append("SELECT AnimalID, PetID, OwnerID, Type, Name, JoinedPractice, Behaviour, NumberOfVisits, TotalCost, (TotalCost / NumberOfVisits) AS CostPerVisit from ( ");
            selectBuilder.Append("SELECT a.AnimalID, p.PetID, p.OwnerID, a.Type, p.Name, p.JoinedPractice, c.Behaviour, Count(v.PetID) as NumberOfVisits, sum(pr.Cost) TotalCost from Animal a ");
            selectBuilder.Append("JOIN Pet p ON P.AnimalID = a.AnimalID ");
            selectBuilder.Append("JOIN Visit v ON v.PetID = p.PetID ");
            selectBuilder.Append("JOIN Procedures pr ON pr.ProcedureID = v.ProcedureID ");
            selectBuilder.Append("Left Outer JOIN Characteristics c ON P.AnimalID = c.AnimalID AND p.PetID = c.PetID ");

            if (!String.IsNullOrEmpty(whereClause))
            {
                selectBuilder.Append(whereClause);
            }

            selectBuilder.Append("Group by a.AnimalID, p.PetID, p.OwnerID, a.Type, p.Name, p.JoinedPractice, c.Behaviour) Animals ");

            try
            {
                using (SqlConnection con = CreateSqlServerConnection())
                {
                    animals = con.Query<Animal>(selectBuilder.ToString()).ToList();
                }
            }
            catch (Exception e)
            {

                throw;
            }

            return animals;
        }

        private SqlConnection CreateSqlServerConnection()
        {
            SqlConnection connection = new SqlConnection();

            if (!String.IsNullOrEmpty(_localSqlServerConnection))
            {
                connection.ConnectionString = _localSqlServerConnection;

                connection.Open();
                return connection;
            }
            else
            {
                StringBuilder connectionString = new StringBuilder();

                connectionString.Append("Server=");
                connectionString.Append(_sqlServerConnectionParams.Server);
                connectionString.Append(";Database=");
                connectionString.Append(_sqlServerConnectionParams.Database);
                connectionString.Append(";User Id=");
                connectionString.Append(_sqlServerConnectionParams.UserId);
                connectionString.Append(";Password=");
                connectionString.Append(_sqlServerConnectionParams.PassWord);

                connection.ConnectionString = connectionString.ToString();

                connection.Open();

                return connection;
            }
        }
    }
}
