using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_de_stock2.Data_Base
{
    public class ArticleRepository
    {
        private string connectionString;

        public ArticleRepository()
        {
            this.connectionString = "server = localhost; database = gestioncommerciale; uid = root; pwd =\"\";";
        }

        public void AjouterArticle(string Nom, string PU)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO artilce (nom, pu) VALUES (@nom, @pu)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nom", Nom);
                command.Parameters.AddWithValue("@pu", PU);
                command.ExecuteNonQuery();
            }
        }

        public List<Article> GetAllArticles()
        {
            List<Article> articles = new List<Article>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT id, nom, pu FROM artilce";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string nom = reader.GetString("nom");
                            string pu = reader.GetString("pu");
                           
                            articles.Add(new Article(id, nom, pu));

                        }
                    }
                }
            }

            return articles;
        }

        public void SupprimerArticle(int articleId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM article WHERE id = @articleId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@articleId", articleId);
                command.ExecuteNonQuery();
            }
        }
    }

   
}
