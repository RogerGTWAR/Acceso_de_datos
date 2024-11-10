using Ejercicio_1.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class InventarioRepository : I_InventarioRepository
    {
        private readonly string _connectionString;
        public InventarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(Inventario inventario)
        {
            string queryString = "INSERT INTO Inventory(MakeId, Color, PetName) VALUES(@makeid, @color, @petname)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@makeid", inventario.MakeId);
                command.Parameters.AddWithValue("@color", inventario.Color);
                command.Parameters.AddWithValue("@petname", inventario.PetName);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string queryString = "DELETE FROM Inventory WHERE Id = @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al eliminar los datos de la base de datos {ex.Message}");
            }
        }

        public List<Inventario> GetAll()
        {
            List<Inventario> inventarios = new List<Inventario>();
            string queryString = "SELECT Id, MakeId, Color, PetName FROM Inventory";
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
                            inventarios.Add(new Inventario()
                            {
                                Id = reader.GetInt32(0),
                                MakeId = reader.GetInt32(1),
                                Color = reader.GetString(2),
                                PetName = reader.GetString(3),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al recuperar clientes: {ex.Message}");
            }
            return inventarios;
        }

        public Inventario GetValue(int id)
        {
            string queryString = "SELECT Id, MakeId, Color, PetName FROM Inventory WHERE Id = @id";

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
                            Inventario inventario = new Inventario
                            {
                                Id = reader.GetInt32(0),
                                MakeId = reader.GetInt32(1),
                                Color = reader.GetString(2),
                                PetName = reader.GetString(3),
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

        public void Update(Inventario inventario)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Inventario SET MakeId = @MakeId, Color = @Color, PetName = @PetName WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MakeId", inventario.MakeId);
                command.Parameters.AddWithValue("@Color", inventario.Color);
                command.Parameters.AddWithValue("@PetName", inventario.PetName);
                command.Parameters.AddWithValue("@Id", inventario.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<Inventario> SearchByPetName(string petName)
        {
            var inventarios = new List<Inventario>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, MakeId, Color, PetName FROM Inventario WHERE PetName LIKE @PetName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PetName", "%" + petName + "%");
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        inventarios.Add(new Inventario
                        {
                            Id = (int)reader["Id"],
                            MakeId = (int)reader["MakeId"],
                            Color = reader["Color"].ToString(),
                            PetName = reader["PetName"].ToString()
                        });
                    }
                }
            }

            return inventarios;
        }
        public List<Inventario> GetByMakeId(int makeId)
        {
            List<Inventario> list = new List<Inventario>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Inventario WHERE MakeId = @MakeId", conn);
                cmd.Parameters.AddWithValue("@MakeId", makeId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Inventario
                    {
                        Id = (int)reader["Id"],
                        MakeId = (int)reader["MakeId"],
                        Color = reader["Color"].ToString(),
                        PetName = reader["PetName"].ToString(),
                    });
                }
            }
            return list;
        }

        public Inventario GetById(int id)
        {
            Inventario inventario = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    inventario = new Inventario
                    {
                        Id = (int)reader["Id"],
                        MakeId = (int)reader["MakeId"],
                        Color = (string)reader["Color"],
                        PetName = (string)reader["PetName"]
                    };
                }
            }
            return inventario;
        }
            public void Insert(Inventario inventario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Inventory (MakeId, Color, PetName) VALUES (@MakeId, @Color, @PetName)", conn);
                cmd.Parameters.AddWithValue("@MakeId", inventario.MakeId);
                cmd.Parameters.AddWithValue("@Color", inventario.Color);
                cmd.Parameters.AddWithValue("@PetName", inventario.PetName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
