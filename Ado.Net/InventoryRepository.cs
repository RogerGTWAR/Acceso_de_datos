using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.Net.Models;
using System.Drawing;

namespace Ado.Net
{
    public class InventoryRepository : IRepository<Inventario>
    {
        private readonly string _connectionString;

        public InventoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Inventario> GetAll()
        {
            List<Inventario> inventories = new List<Inventario>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Inventory";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inventories.Add(new Inventario
                    {
                        Id = (int)reader["Id"],
                        MakeId = (int)reader["MakeId"],
                        Color = (string)reader["Color"],
                        PetName = (string)reader["PetName"]
                    });
                }
            }
            return inventories;
        }

        public Inventario GetById(int id)
        {
            Inventario inventory = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Inventory WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    inventory = new Inventario
                    {
                        Id = (int)reader["Id"],
                        MakeId = (int)reader["MakeId"],
                        Color = (string)reader["Color"],
                        PetName = (string)reader["PetName"]
                    };
                }
            }
            return inventory;
        }

        public void Add(Inventario inventory)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Inventory (MakeId, Color, PetName) VALUES (@MakeId, @Color, @PetName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MakeId", inventory.MakeId);
                command.Parameters.AddWithValue("@Color", inventory.Color);
                command.Parameters.AddWithValue("@PetName", inventory.PetName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Inventario inventory)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Inventory SET MakeId = @MakeId, Color = @Color, PetName = @PetName WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MakeId", inventory.MakeId);
                command.Parameters.AddWithValue("@Color", inventory.Color);
                command.Parameters.AddWithValue("@PetName", inventory.PetName);
                command.Parameters.AddWithValue("@Id", inventory.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Inventory WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<Inventario> GetByName(string name, string color)
        {
            List<Inventario> inventarios = new List<Inventario>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Inventory WHERE PetName LIKE @PetName";
                if (!string.IsNullOrEmpty(color))
                {
                    query += " AND Color LIKE @Color";
                }
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PetName", "%" + name + "%");
                if (!string.IsNullOrEmpty(color))
                {
                    command.Parameters.AddWithValue("@Color", "%" + color + "%");
                }
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inventarios.Add(new Inventario
                    {
                        Id = (int)reader["Id"],
                        PetName = (string)reader["PetName"],
                        Color = (string)reader["Color"],
                        MakeId = (int)reader["MakeId"]
                    });
                }
            }
            return inventarios;
        }
    }
}

