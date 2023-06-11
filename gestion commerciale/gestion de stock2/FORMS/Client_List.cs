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
    public partial class Client_List : UserControl
    {
        private ClientRepository clientRepository;
        // Associer le gestionnaire d'événements au bouton "Supprimer"

        public Client_List()
        {
            InitializeComponent();
            clientRepository = new ClientRepository();
            //button1_Click_1.Click += new EventHandler(button1_Click_1);
        }

        private void Client_List_Load(object sender, EventArgs e)
        {
            List<Client> clients = clientRepository.GetAllClients();
            dataGridView1.DataSource = clients;
            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            dataGridView1.Columns["Nom"].DataPropertyName = "Nom";
            dataGridView1.Columns["Number"].DataPropertyName = "Number";
            dataGridView1.Columns["Ville"].DataPropertyName = "Ville";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenir l'index de la ligne sélectionnée
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Obtenir l'ID du client à supprimer
                int clientId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                // Supprimer la ligne sélectionnée de la source de données du DataGridView
                List<Client> clients = (List<Client>)dataGridView1.DataSource;
                clients.RemoveAt(rowIndex);

                // Mettre à jour la source de données du DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clients;

                // Supprimer le client de la base de données
                clientRepository.DeleteClient(clientId);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenir l'index de la ligne sélectionnée
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Obtenir l'ID du client à supprimer
                int clientId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                // Supprimer la ligne sélectionnée de la source de données du DataGridView
                List<Client> clients = (List<Client>)dataGridView1.DataSource;
                clients.RemoveAt(rowIndex);

                // Mettre à jour la source de données du DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clients;

                // Supprimer le client de la base de données
                clientRepository.DeleteClient(clientId);
            }
        }
    }
}
