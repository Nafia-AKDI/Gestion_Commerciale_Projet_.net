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
    public partial class Fournisseur_List : UserControl
    {
        private FournisseurRepository fournisseurRepository;
        private List<Fournisseur> fournisseurs;

        public Fournisseur_List()
        {
            InitializeComponent();
            fournisseurRepository = new FournisseurRepository();
            fournisseurs = new List<Fournisseur>();
            Fournisseur_List_Load(this, EventArgs.Empty); // Appeler la méthode Fournisseur_List_Load
        }

        private void add_fournisseur_Click(object sender, EventArgs e)
        {
            add_fournisseur form2 = new add_fournisseur();
            form2.Show();
        }

        private void Fournisseur_List_Load(object sender, EventArgs e)
        {
            // Récupérer la liste des fournisseurs depuis le repository
            fournisseurs = fournisseurRepository.GetAllFournisseurs();

            // Remplir le DataGridView avec les fournisseurs
            dataGridView1.DataSource = fournisseurs;
            dataGridView1.Columns["Nom"].DataPropertyName = "Nom";
            dataGridView1.Columns["Number"].DataPropertyName = "Number";
            dataGridView1.Columns["Ville"].DataPropertyName = "Ville";
        }
   


private void add_client_Click(object sender, EventArgs e)
        {
            add_fournisseur form2 = new add_fournisseur();

            // Affichez le formulaire
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenir l'index de la ligne sélectionnée
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Obtenir l'ID du client à supprimer
                int fournisseurId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                // Supprimer la ligne sélectionnée de la source de données du DataGridView
                List<Fournisseur> fournisseurs = (List<Fournisseur>)dataGridView1.DataSource;
                fournisseurs.RemoveAt(rowIndex);

                // Mettre à jour la source de données du DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = fournisseurs;

                // Supprimer le client de la base de données
                fournisseurRepository.SupprimerFournisseur(fournisseurId);
            }
        }
    }
}
