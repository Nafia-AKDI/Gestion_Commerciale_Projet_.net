using gestion_de_stock2.Data_Base;
using gestion_de_stock2.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_de_stock2
{
    public partial class login : Form
    {
        private UserRepository userRepository;
        public login()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = email.Text;
            string upassword = password.Text;
            bool credentialsValid = userRepository.CheckCredentials(username, upassword);

            if (credentialsValid)
            {
                // Les informations d'identification sont valides, procéder à la page suivante
                page_principale form2 = new page_principale();
                form2.Show();

                
            }
            else
            {
                // Les informations d'identification sont invalides, afficher un message d'erreur
                MessageBox.Show("Identifiants invalides. Veuillez réessayer.");
            }
            
            
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
