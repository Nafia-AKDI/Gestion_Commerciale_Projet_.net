using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace gestion_de_stock2.Data_Base
{
    public class FournisseurRepository
    {
        private string connectionString; 

        public FournisseurRepository()
        {
            this.connectionString = "server = localhost; database = gestioncommerciale; uid = root; pwd =\"\";";
        }

        public void AjouterFournisseur(string nom, string number, string ville)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO fournisseur (nom, number, ville) VALUES (@Nom, @Number, @Ville)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Nom", nom);
                command.Parameters.AddWithValue("@Number", number);
                command.Parameters.AddWithValue("@Ville", ville);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Fournisseur> GetAllFournisseurs()
        {
            List<Fournisseur> fournisseurs = new List<Fournisseur>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT id, nom, number, ville FROM fournisseur";
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
                            fournisseurs.Add(new Fournisseur(id, nom, number, ville));

                        }
                    }
                }
            }
            return fournisseurs;
        }

        public void ModifierFournisseur(Fournisseur fournisseur)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE fournisseur SET nom = @Nom, number = @Number, ville = @Ville WHERE id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Nom", fournisseur.Nom);
                command.Parameters.AddWithValue("@Number", fournisseur.Number);
                command.Parameters.AddWithValue("@Ville", fournisseur.Ville);
                command.Parameters.AddWithValue("@Id", fournisseur.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void SupprimerFournisseur(int fournisseurId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM fournisseur WHERE id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", fournisseurId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    
}
