using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WinFormsClinicApp
{
    internal class DataBase
    {
        private static DataBase instance;
        private static readonly string selectCustomersString = "SELECT * FROM Customer";
        private static readonly string selectAnimalsString = "SELECT * FROM Animal";
        private static readonly string selectCustomersAnimalsString = "SELECT * FROM Animal WHERE customerId=@customerId";
        private string dbPath;
        public static DataBase Instance()
        {
            if (instance == null)
            {
                instance = new DataBase();
            }
            return instance;
        }

        private DataBase(){ }

        public void CheckDb(string dbPath)
        {
            this.dbPath = dbPath;
            try
            {
                using (var connection = new SqliteConnection("Data Source=" + dbPath))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        transaction.Rollback();
                    }
                }
                
            }
            catch (SqliteException ex)
            {
                throw new SqliteException(ex.Message, ex.ErrorCode, ex.SqliteExtendedErrorCode);
            }
        }

        public IEnumerable GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using(var connection = new SqliteConnection("Data Source=" + dbPath))
            {
                SqliteCommand selectCustomers = new SqliteCommand(selectCustomersString, connection);
                connection.Open();
                using (SqliteDataReader reader = selectCustomers.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            customers.Add(new Customer(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString()));
                        }
                    }
                }
            }
            return customers;
        }

        public IEnumerable GetAnimals()
        {
            List<Animal> animals = new List<Animal>();
            using (var connection = new SqliteConnection("Data Source=" + dbPath))
            {
                SqliteCommand selectAnimals = new SqliteCommand(selectAnimalsString, connection);
                connection.Open();
                using (SqliteDataReader reader = selectAnimals.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            animals.Add(new Animal(reader.GetValue(0).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString()));
                        }
                    }
                }
            }
            return animals;
        }

        public IEnumerable GetCustomersAnimals(int customerId)
        {
            List<Animal> animals = new List<Animal>();
            using (var connection = new SqliteConnection("Data Source=" + dbPath))
            {
                SqliteCommand selectCustomersAnimals = new SqliteCommand(selectCustomersAnimalsString, connection);
                SqliteParameter cusomerIdParam = new SqliteParameter("@customerId", customerId);
                selectCustomersAnimals.Parameters.Add(cusomerIdParam);
                connection.Open();
                using (SqliteDataReader reader = selectCustomersAnimals.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            animals.Add(new Animal(reader.GetValue(0).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString()));
                        }
                    }
                }
            }
            return animals;
        }

    }
}
