namespace gestion_de_stock2.FORMS
{
    partial class add_fournisseur
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
            this.ajouter_fournisseur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ville_fournisseur = new System.Windows.Forms.TextBox();
            this.nom_fournisseur = new System.Windows.Forms.TextBox();
            this.number_fournisseur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajouter_fournisseur
            // 
            this.ajouter_fournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ajouter_fournisseur.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ajouter_fournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_fournisseur.Location = new System.Drawing.Point(245, 329);
            this.ajouter_fournisseur.Name = "ajouter_fournisseur";
            this.ajouter_fournisseur.Size = new System.Drawing.Size(120, 42);
            this.ajouter_fournisseur.TabIndex = 20;
            this.ajouter_fournisseur.Text = "ajouter";
            this.ajouter_fournisseur.UseVisualStyleBackColor = false;
            this.ajouter_fournisseur.Click += new System.EventHandler(this.ajouter_fournisseur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Number";
            // 
            // ville_fournisseur
            // 
            this.ville_fournisseur.Location = new System.Drawing.Point(272, 253);
            this.ville_fournisseur.Name = "ville_fournisseur";
            this.ville_fournisseur.Size = new System.Drawing.Size(210, 26);
            this.ville_fournisseur.TabIndex = 16;
            // 
            // nom_fournisseur
            // 
            this.nom_fournisseur.Location = new System.Drawing.Point(272, 154);
            this.nom_fournisseur.Name = "nom_fournisseur";
            this.nom_fournisseur.Size = new System.Drawing.Size(210, 26);
            this.nom_fournisseur.TabIndex = 14;
            // 
            // number_fournisseur
            // 
            this.number_fournisseur.Location = new System.Drawing.Point(272, 204);
            this.number_fournisseur.Name = "number_fournisseur";
            this.number_fournisseur.Size = new System.Drawing.Size(210, 26);
            this.number_fournisseur.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ajouter un nouveau fournisseur";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImage = global::gestion_de_stock2.Properties.Resources.icons8_quitter_30__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(555, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 35);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.ajouter_fournisseur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ville_fournisseur);
            this.Controls.Add(this.nom_fournisseur);
            this.Controls.Add(this.number_fournisseur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_fournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_fournisseur";
            this.Load += new System.EventHandler(this.add_fournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ajouter_fournisseur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ville_fournisseur;
        private System.Windows.Forms.TextBox nom_fournisseur;
        private System.Windows.Forms.TextBox number_fournisseur;
        private System.Windows.Forms.Label label1;
    }
}