using gestion_de_stock2.Data_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_de_stock2.FORMS
{
    public partial class Commande_List : UserControl
    {
        private CommandeRepository commandeRepository;
        private List<Commande> commandes;
        public Commande_List()
        {
            InitializeComponent();
            commandeRepository = new CommandeRepository();
            commandes = new List<Commande>();
            Commande_List_Load(this, EventArgs.Empty);
        }

        private void Commande_List_Load(object sender, EventArgs e)
        {
            commandes = commandeRepository.GetAllCommandes();
            table.DataSource = commandes;
            table.Columns["Id"].DataPropertyName = "Id";
            table.Columns["Quantité"].DataPropertyName = "Quantité";
            table.Columns["Produit"].DataPropertyName = "Produit";
            table.Columns["Client"].DataPropertyName = "Client";
            table.Columns["Date"].DataPropertyName = "Date";
        }

        
        

        private void add_commande_Click(object sender, EventArgs e)
        {
            add_commande form2 = new add_commande();

            // Affichez le formulaire
            form2.Show();
        }

        private void supprimer_commande_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (table.SelectedRows.Count > 0)
            {
                // Obtenir l'index de la ligne sélectionnée
                int rowIndex = table.SelectedRows[0].Index;

                // Obtenir l'ID du client à supprimer
                int clientId = (int)table.SelectedRows[0].Cells["Id"].Value;

                // Supprimer la ligne sélectionnée de la source de données du DataGridView
                List<Commande> clients = (List<Commande>)table.DataSource;
                clients.RemoveAt(rowIndex);

                // Mettre à jour la source de données du DataGridView
                table.DataSource = null;
                table.DataSource = clients;

                // Supprimer le client de la base de données
                commandeRepository.SupprimerCmd(clientId);
            }
        }
    }
}
