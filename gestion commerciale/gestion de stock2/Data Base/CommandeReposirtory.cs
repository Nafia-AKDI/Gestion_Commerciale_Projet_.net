using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gestion_de_stock2.Data_Base
{
    public class CommandeRepository
    {
        private string connectionString;
        public CommandeRepository()
        {
            this.connectionString = "server = localhost; database = gestioncommerciale; uid = root; pwd =\"\";";
        }

        public void AjouterCmd(DateTime date, int clientId, int articleId, int quantite)
        {
            // Code pour ajouter un enregistrement dans la table "achat"


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO commande (date_cmd, client_id, art_id, qte) VALUES (@Date, @clientId, @ArticleId, @Quantite)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@clientId", clientId);
                command.Parameters.AddWithValue("@ArticleId", articleId);
                command.Parameters.AddWithValue("@Quantite", quantite);
                command.ExecuteNonQuery();
            }
        }

        public List<Commande> GetAllCommandes()
        {
            List<Commande> commands = new List<Commande>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT id, date_cmd, client_id,art_id, qte   FROM commande";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int Id = reader.GetInt32(reader.GetOrdinal("id"));
                            DateTime DateCmd = reader.GetDateTime(reader.GetOrdinal("date_cmd"));
                            int ClientId = reader.GetInt32(reader.GetOrdinal("client_id"));
                            int ArticleId = reader.GetInt32(reader.GetOrdinal("art_id"));
                            int Quantite = reader.GetInt32(reader.GetOrdinal("qte"));



                            commands.Add(new Commande(Id, DateCmd, ClientId, ArticleId, Quantite));

                        }
                    }
                }
            }
            return commands;
        }

        public void SupprimerCmd(int CmdId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM commande WHERE id = @cmdId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@cmdId", CmdId);
                command.ExecuteNonQuery();
            }
        }
    }
        

    }




