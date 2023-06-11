using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace gestion_de_stock2.Data_Base
{
    public class ClientRepository
    {
        private string connectionString; // Chaîne de connexion à votre base de données

        public ClientRepository()
        {
            this.connectionString = "server = localhost; database = gestioncommerciale; uid = root; pwd =\"\";";
        }

        public void AddClient(string nom, string number, string ville)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO client (nom, number, ville) VALUES (@Nom, @Number, @Ville)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@number", number);
                    command.Parameters.AddWithValue("@ville", ville);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT id, nom, number, ville FROM client";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string nom = reader.GetString("nom");
                            string number = reader.GetString("number");
                            string ville = reader.GetString("ville");
                            clients.Add(new Client(id, nom, number, ville));
                        }
                    }
                }
            }

            return clients;
        }

        public void UpdateClient(int id, string nom)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "UPDATE client SET nom = @nom WHERE id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteClient(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "DELETE FROM client WHERE id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    
}
