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

    public partial class add_fournisseur : Form
    {
        private FournisseurRepository fournisseurRepository;
        public Fournisseur_List FournisseurListForm { get; set; }
        public add_fournisseur()
        {
            InitializeComponent();
            fournisseurRepository = new FournisseurRepository();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void add_fournisseur_Load(object sender, EventArgs e)
        {

        }

        private void ajouter_fournisseur_Click(object sender, EventArgs e)
        {
            // Récupérer les informations saisies par l'utilisateur
            string nomFournisseur = nom_fournisseur.Text;
            string numberFournisseur = number_fournisseur.Text;
            string villeFournisseur = ville_fournisseur.Text;

            try
            {
                // Appeler la méthode AddClient du ClientRepository pour ajouter le client
                fournisseurRepository.AjouterFournisseur(nomFournisseur, numberFournisseur, villeFournisseur);

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
            // Rechargez la liste des clients dans le formulaire Client_List

            this.Close();
        }
    }
}
