﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Hospital
{
    public class Data
    {
        private string connectionString =
            "datasource = 127.0.0.1;" +
            "port = 3306;" +
            "username = root; password =;" +
            "database = hospital;";

        private const int _patient = 1;
        private const int _nurse = 2;
        private const int _doctor = 3;

        private int Insert(string query)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                int result = commandDatabase.ExecuteNonQuery();
                return (int)commandDatabase.LastInsertedId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

        public int InsertPatient(Patient patient)
        {
            string query = $"INSERT INTO person(ID, Name, Birth, Type, Problem, Treatment)" +
                $"VALUES(NULL,'{patient.Name}', '{patient.Birth.ToString("yyyy-MM-dd")}'," +
                $"'{_patient}', '{patient.Problem}', '{patient.Treatment}');";
            return this.Insert(query);
        }

    }
}
