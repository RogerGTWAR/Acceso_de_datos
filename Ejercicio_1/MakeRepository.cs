using Ejercicio_1.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class MakeRepository : IMakeRepository
    {
        private readonly string _connectionString;

        public MakeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Make make)
        {
            string queryString = "INSERT INTO Makes(Name) VALUES(@name)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@name", make.Name);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string queryString = "DELETE FROM Makes WHERE Id = @id";
            try
            {
                using (SqlConnection connection
            = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al eliminar nombre de la base de datos {ex.Message}");
            }
        }

        public List<Make> GetAll()
        {
            List<Make> makes = new List<Make>();
            string queryString = "SELECT Id, Name FROM Makes";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            makes.Add(new Make()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                            });
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al recuperar clientes: {ex.Message}");
            }
            return makes;
        }

        public Make GetById(int id)
        {
            string queryString = "SELECT Id, Name FROM Makes WHERE Id = @id";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() != null)
                        {
                            Make make = new Make
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al obtener datos de la base de datos {ex.Message}");
            }
            return null;
                
        }

        public Make GetValue(int id)
        {
            string queryString = "SELECT Id, Name FROM Makes WHERE Id = @id";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() != null)
                        {
                            Make make = new Make
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al obtener datos de la base de datos {ex.Message}");
            }
            return null;
        }

        public void Insert(Make make)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Makes (Name) VALUES (@Name)", conn);
                cmd.Parameters.AddWithValue("@Name", make.Name);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Make entity)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Makes SET Name = @Name WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
