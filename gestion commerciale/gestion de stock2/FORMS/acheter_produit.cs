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
using static gestion_de_stock2.Data_Base.AchatRepository;

namespace gestion_de_stock2.FORMS
{
    public partial class acheter_produit : Form
    {
        private ArticleRepository articleRepository;
        private FournisseurRepository fournisseurRepository;
        public acheter_produit()
        {
            InitializeComponent();
            articleRepository = new ArticleRepository();
            List<Article> produits = articleRepository.GetAllArticles();

            fournisseurRepository = new FournisseurRepository();
            List<Fournisseur> fournisseurs = fournisseurRepository.GetAllFournisseurs();

            // Ajouter les produits au ComboBox
            comboBox_produit.DataSource = produits;
            comboBox_produit.DisplayMember = "Nom"; // Afficher le nom du produit
            comboBox_produit.ValueMember = "Id"; // Utiliser l'ID du produit comme valeur

            comboBox_fournisseur.DataSource = fournisseurs;
            comboBox_fournisseur.DisplayMember = "Nom"; // Afficher le nom du produit
            comboBox_fournisseur.ValueMember = "Id"; // Utiliser l'ID du produit comme valeur

        }
        private void acheter_produit_Load(object sender, EventArgs e)
        {
            // Récupérer la liste des produits depuis le repository
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouter_commande_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs sélectionnées dans les contrôles (comboBox, textBox, etc.)
            int fournisseurId = Convert.ToInt32(comboBox_fournisseur.SelectedValue);
            int articleId = Convert.ToInt32(comboBox_produit.SelectedValue);
            int quantite = Convert.ToInt32(quantité.Text);

            // Créer un nouvel objet Achat avec les valeurs récupérées
           

            // Appeler la méthode d'ajout d'achat de votre classe AchatRepository
            AchatRepository achatRepository = new AchatRepository();
            achatRepository.AjouterAchat(fournisseurId, articleId, quantite);

            
        }
    }
}
