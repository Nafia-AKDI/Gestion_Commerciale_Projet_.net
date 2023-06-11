using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock2.Data_Base
{
    public class AchatRepository
    {
        private string connectionString;
        public AchatRepository()
        {
            this.connectionString = "server = localhost; database = gestioncommerciale; uid = root; pwd =\"\";";
        }

        public void AjouterAchat(int fournisseurId, int articleId, int quantite)
        {
            // Code pour ajouter un enregistrement dans la table "achat"


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO achat (fourn_id, art_id, qte) VALUES (@FournisseurId, @ArticleId, @Quantite)";
                MySqlCommand command = new MySqlCommand(query, connection);
                //command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@FournisseurId", fournisseurId);
                command.Parameters.AddWithValue("@ArticleId", articleId);
                command.Parameters.AddWithValue("@Quantite", quantite);
                command.ExecuteNonQuery();
            }
        }

        public List<Achat> GetAllAchats()
        {
            List<Achat> achats = new List<Achat>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM achat";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int Id = reader.GetInt32(reader.GetOrdinal("id"));
                            // DateTime DateAchat = reader.GetDateTime(reader.GetOrdinal("date_ach"));
                            int FournisseurId = reader.GetInt32(reader.GetOrdinal("fourn_id"));
                            int ArticleId = reader.GetInt32(reader.GetOrdinal("art_id"));
                            int Quantite = reader.GetInt32(reader.GetOrdinal("qte"));



                            achats.Add(new Achat(Id, FournisseurId, ArticleId, Quantite));

                        }
                    }
                }
            }
            return achats;
        }

        /*public void SupprimerAchat(int achatId)
        {
            // Code pour supprimer un enregistrement de la table "achat"
            string query = "DELETE FROM achat WHERE id = @AchatId";

            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@AchatId", achatId);

                dbConnection.Open();
                command.ExecuteNonQuery();
                dbConnection.Close();
            }
        }
    }*/
    }
}
