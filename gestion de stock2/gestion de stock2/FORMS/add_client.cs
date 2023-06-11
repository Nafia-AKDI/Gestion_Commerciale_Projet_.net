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
    public partial class add_client : Form
    {
        private ClientRepository clientRepository;
        public Client_List ClientListForm { get; set; }
        public add_client()
        {
            InitializeComponent();
            clientRepository = new ClientRepository();

        }

        private void nom_produit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_client_Click(object sender, EventArgs e)
        {
            

        }

        private void ajouter_client_Click_1(object sender, EventArgs e)
        {
            // Récupérer les informations saisies par l'utilisateur
            string nomClient = nom_client.Text;
            string numberClient = number_client.Text;
            string villeClient = ville_client.Text;

            try
            {
                // Appeler la méthode AddClient du ClientRepository pour ajouter le client
                clientRepository.AddClient(nomClient, numberClient, villeClient);

                // Afficher un message de confirmation à l'utilisateur
                MessageBox.Show("Le client a été ajouté avec succès.", "Ajout de client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fermer le formulaire add_client
                this.Close();
            }
            catch (Exception ex)
            {
                // Gérer les erreurs éventuelles lors de l'ajout du client
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Rechargez la liste des clients dans le formulaire Client_List

            this.Close();
        }
    }
}
