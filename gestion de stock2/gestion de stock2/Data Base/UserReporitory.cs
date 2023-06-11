using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace gestion_de_stock2.Data_Base
{
    public class UserRepository
    {
        private string connectionString;

        public UserRepository()
        {
            this.connectionString = "server = localhost; database = gestioncommerciale; uid = root; pwd =\"\";";
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id,nom,email,pws,role_id FROM user";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                            user.Nom = reader.GetString(reader.GetOrdinal("nom"));
                            user.Email = reader.GetString(reader.GetOrdinal("email"));
                            user.Password = reader.GetString(reader.GetOrdinal("pws"));
                            user.RoleId = reader.GetInt32(reader.GetOrdinal("role_id"));
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }
        public bool CheckCredentials(string userName, string userPassword)
        {
            // Effectuer une requête pour vérifier les informations d'identification dans la base de données
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM user WHERE nom = @Nom AND pws = @Password";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", userName);
                    command.Parameters.AddWithValue("@Password", userPassword);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Si le compte existe, renvoyer true
                    return count > 0;
                }
            }
        }







    }
}
