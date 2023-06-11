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
    public partial class page_principale : Form
    {
        public page_principale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              // Effacez le contenu précédent du panneau
              pnlafficher.Controls.Clear();
            // Créez une instance de votre contrôleur utilisateur
            Client_List myUserControl = new Client_List();

            // Ajoutez le contrôleur utilisateur au panneau
            pnlafficher.Controls.Add(myUserControl);

            // Affichez le contrôleur utilisateur
            myUserControl.Show();
        }

        private void page_principale_Load(object sender, EventArgs e)
        {

        }

        private void pnlafficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Effacez le contenu précédent du panneau
            pnlafficher.Controls.Clear();
            // Créez une instance de votre contrôleur utilisateur
            Fournisseur_List myUserControl = new Fournisseur_List();

            // Ajoutez le contrôleur utilisateur au panneau
            pnlafficher.Controls.Add(myUserControl);

            // Affichez le contrôleur utilisateur
            myUserControl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Effacez le contenu précédent du panneau
            pnlafficher.Controls.Clear();
            // Créez une instance de votre contrôleur utilisateur
            Commande_List myUserControl = new Commande_List();

            // Ajoutez le contrôleur utilisateur au panneau
            pnlafficher.Controls.Add(myUserControl);

            // Affichez le contrôleur utilisateur
            myUserControl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Effacez le contenu précédent du panneau
            pnlafficher.Controls.Clear();
            // Créez une instance de votre contrôleur utilisateur
            Produit_List myUserControl = new Produit_List();

            // Ajoutez le contrôleur utilisateur au panneau
            pnlafficher.Controls.Add(myUserControl);

            // Affichez le contrôleur utilisateur
            myUserControl.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
