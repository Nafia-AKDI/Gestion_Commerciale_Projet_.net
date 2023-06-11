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
    public partial class Produit_List : UserControl
    {
        private ArticleRepository productRepository;
        private List<Article> produits;

        public Produit_List()
        {
            InitializeComponent();
            productRepository = new ArticleRepository();
            produits = new List<Article>();
            Produit_List_Load(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acheter_produit form2 = new acheter_produit();
            form2.Show();
        }

        private void add_produit_Click(object sender, EventArgs e)
        {
            add_product form = new add_product();
            form.Show();
        }

        private void Produit_List_Load(object sender, EventArgs e)
        {
            // Récupérer la liste des produits depuis le repository
            produits = productRepository.GetAllArticles();

            // Remplir le DataGridView avec les produits
            table.DataSource = produits;
            table.Columns["Id"].DataPropertyName = "Id";
            table.Columns["Nom"].DataPropertyName = "Nom";
            table.Columns["Prix"].DataPropertyName = "Prix";
            table.Columns["quantité"].DataPropertyName = "quantité";
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supprimer_produit_Click(object sender, EventArgs e)
        {

            // Vérifier si une ligne est sélectionnée
            if (table.SelectedRows.Count > 0)
            {
                // Obtenir l'index de la ligne sélectionnée
                int rowIndex = table.SelectedRows[0].Index;

                // Obtenir l'ID du client à supprimer
                int clientId = (int)table.SelectedRows[0].Cells["Id"].Value;

                // Supprimer la ligne sélectionnée de la source de données du DataGridView
                List<Article> clients = (List<Article>)table.DataSource;
                clients.RemoveAt(rowIndex);

                // Mettre à jour la source de données du DataGridView
                table.DataSource = null;
                table.DataSource = clients;

                // Supprimer le client de la base de données
                productRepository.SupprimerArticle(clientId);
            }
        }
    }
}
