namespace gestion_de_stock2.FORMS
{
    partial class Commande_List
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.table = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_commande = new System.Windows.Forms.Button();
            this.supprimer_commande = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToOrderColumns = true;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Produit,
            this.Quantité,
            this.Date});
            this.table.Location = new System.Drawing.Point(3, 152);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 50;
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(883, 353);
            this.table.TabIndex = 5;
            // 
            // Client
            // 
            this.Client.Frozen = true;
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 8;
            this.Client.Name = "Client";
            this.Client.Width = 150;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.MinimumWidth = 8;
            this.Produit.Name = "Produit";
            this.Produit.Width = 150;
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.MinimumWidth = 8;
            this.Quantité.Name = "Quantité";
            this.Quantité.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // add_commande
            // 
            this.add_commande.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.add_commande.BackColor = System.Drawing.Color.Lime;
            this.add_commande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_commande.Location = new System.Drawing.Point(89, 66);
            this.add_commande.Name = "add_commande";
            this.add_commande.Size = new System.Drawing.Size(226, 45);
            this.add_commande.TabIndex = 3;
            this.add_commande.Text = "ajouter commande";
            this.add_commande.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_commande.UseVisualStyleBackColor = false;
            this.add_commande.Click += new System.EventHandler(this.add_commande_Click);
            // 
            // supprimer_commande
            // 
            this.supprimer_commande.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.supprimer_commande.BackColor = System.Drawing.Color.DeepPink;
            this.supprimer_commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_commande.Location = new System.Drawing.Point(385, 66);
            this.supprimer_commande.Name = "supprimer_commande";
            this.supprimer_commande.Size = new System.Drawing.Size(255, 45);
            this.supprimer_commande.TabIndex = 4;
            this.supprimer_commande.Text = "supprimer commande";
            this.supprimer_commande.UseVisualStyleBackColor = false;
            this.supprimer_commande.Click += new System.EventHandler(this.supprimer_commande_Click);
            // 
            // Commande_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Controls.Add(this.add_commande);
            this.Controls.Add(this.supprimer_commande);
            this.Name = "Commande_List";
            this.Size = new System.Drawing.Size(889, 636);
            this.Load += new System.EventHandler(this.Commande_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button add_commande;
        private System.Windows.Forms.Button supprimer_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
