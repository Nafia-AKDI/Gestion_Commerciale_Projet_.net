using gestion_de_stock2.Data_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_de_stock2.FORMS
{
    public partial class add_product : Form
    {
        private ArticleRepository articleRepository;
        public add_product()
        {
            InitializeComponent();
            articleRepository = new ArticleRepository();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérer les informations saisies par l'utilisateur
            string nomArticle = nom_produit.Text;
            string puArticle = prix_produit.Text;

            try
            {
                // Appeler la méthode AddClient du ClientRepository pour ajouter le client
                articleRepository.AjouterArticle(nomArticle, puArticle);

                // Afficher un message de confirmation à l'utilisateur
                MessageBox.Show("Le fournisseur a été ajouté avec succès.", "Ajout de fournissuer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fermer le formulaire add_client
                this.Close();
            }
            catch (Exception ex)
            {
                // Gérer les erreurs éventuelles lors de l'ajout du client
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du fournissuer : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
