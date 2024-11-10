using Ado.Net.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net
{
    public class MakeRepository : IRepository<Make>
    {
        private readonly string _connectionString;

        public MakeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Make> GetAll()
        {
            List<Make> makes = new List<Make>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Makes";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    makes.Add(new Make
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"]
                    });
                }
            }
            return makes;
        }

        public Make GetById(int id)
        {
            Make make = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Makes WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    make = new Make
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"]
                    };
                }
            }
            return make;
        }

        public void Add(Make make)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Makes (Name) VALUES (@Name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", make.Name);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Make make)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Makes SET Name = @Name WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", make.Name);
                command.Parameters.AddWithValue("@Id", make.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string queryString = "DELETE FROM Makes WHERE Id = @id";
   
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
        }

        public IEnumerable<Make> GetByName(string name, string color)
        {
            List<Make> makes = new List<Make>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Makes WHERE Name LIKE @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", "%" + name + "%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    makes.Add(new Make
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"]
                    });
                }
            }
            return makes;
        }
    }
}
