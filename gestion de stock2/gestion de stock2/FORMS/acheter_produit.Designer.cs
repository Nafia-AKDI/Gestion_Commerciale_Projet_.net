namespace gestion_de_stock2.FORMS
{
    partial class acheter_produit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.quantité = new System.Windows.Forms.NumericUpDown();
            this.comboBox_fournisseur = new System.Windows.Forms.ComboBox();
            this.comboBox_produit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ajouter_commande = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantité)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImage = global::gestion_de_stock2.Properties.Resources.icons8_quitter_30__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(492, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 39);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // quantité
            // 
            this.quantité.Location = new System.Drawing.Point(225, 234);
            this.quantité.Name = "quantité";
            this.quantité.Size = new System.Drawing.Size(245, 26);
            this.quantité.TabIndex = 34;
            // 
            // comboBox_fournisseur
            // 
            this.comboBox_fournisseur.FormattingEnabled = true;
            this.comboBox_fournisseur.Location = new System.Drawing.Point(225, 186);
            this.comboBox_fournisseur.Name = "comboBox_fournisseur";
            this.comboBox_fournisseur.Size = new System.Drawing.Size(245, 28);
            this.comboBox_fournisseur.TabIndex = 32;
            // 
            // comboBox_produit
            // 
            this.comboBox_produit.FormattingEnabled = true;
            this.comboBox_produit.Location = new System.Drawing.Point(225, 144);
            this.comboBox_produit.Name = "comboBox_produit";
            this.comboBox_produit.Size = new System.Drawing.Size(245, 28);
            this.comboBox_produit.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fournisseur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Acheter un produit";
            // 
            // ajouter_commande
            // 
            this.ajouter_commande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ajouter_commande.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ajouter_commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_commande.Location = new System.Drawing.Point(207, 307);
            this.ajouter_commande.Name = "ajouter_commande";
            this.ajouter_commande.Size = new System.Drawing.Size(120, 50);
            this.ajouter_commande.TabIndex = 37;
            this.ajouter_commande.Text = "ajouter";
            this.ajouter_commande.UseVisualStyleBackColor = false;
            this.ajouter_commande.Click += new System.EventHandler(this.ajouter_commande_Click);
            // 
            // acheter_produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(545, 407);
            this.Controls.Add(this.ajouter_commande);
            this.Controls.Add(this.quantité);
            this.Controls.Add(this.comboBox_fournisseur);
            this.Controls.Add(this.comboBox_produit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "acheter_produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acheter_produit";
            ((System.ComponentModel.ISupportInitialize)(this.quantité)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown quantité;
        private System.Windows.Forms.ComboBox comboBox_fournisseur;
        private System.Windows.Forms.ComboBox comboBox_produit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajouter_commande;
    }
}