using Ejercicio01;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class InventarioRepository : IRepository<Inventario>
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

        public IEnumerable<Inventario> GetAll()
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

        public void Update(Inventario entity)
        {
            throw new NotImplementedException();
        }
    }
}
