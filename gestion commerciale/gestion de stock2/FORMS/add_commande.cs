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
    public partial class add_commande : Form
    {
        private ArticleRepository articleRepository;
        private ClientRepository clientRepository;
        public add_commande()
        {
            InitializeComponent();
            articleRepository = new ArticleRepository();
            List<Article> produits = articleRepository.GetAllArticles();

            clientRepository = new ClientRepository();
            List<Client> clients = clientRepository.GetAllClients();

            // Ajouter les produits au ComboBox
            comboBox2.DataSource = produits;
            comboBox2.DisplayMember = "Nom"; // Afficher le nom du produit
            comboBox2.ValueMember = "Id"; // Utiliser l'ID du produit comme valeur

            comboBox1.DataSource = clients;
            comboBox1.DisplayMember = "Nom"; // Afficher le nom du produit
            comboBox1.ValueMember = "Id"; // Utiliser l'ID du produit comme valeur
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_commande_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouter_commande_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs sélectionnées dans les contrôles (comboBox, textBox, etc.)
            int clientID = Convert.ToInt32(comboBox1.SelectedValue);
            int articleID = Convert.ToInt32(comboBox2.SelectedValue);
            int quantite = Convert.ToInt32(quantité.Text);
            DateTime dateCommande = date.Value;



            // Appeler la méthode d'ajout de commande de votre classe CommandeRepository
            CommandeRepository commandeRepository = new CommandeRepository();
            commandeRepository.AjouterCmd(dateCommande, clientID, articleID, quantite);

            
        }
    }
}
