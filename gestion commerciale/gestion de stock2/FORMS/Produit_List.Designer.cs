namespace gestion_de_stock2.FORMS
{
    partial class Produit_List
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
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_produit = new System.Windows.Forms.Button();
            this.supprimer_produit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.Nom,
            this.quantité,
            this.Prix});
            this.table.Location = new System.Drawing.Point(3, 150);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 50;
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(755, 353);
            this.table.TabIndex = 5;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.Width = 150;
            // 
            // quantité
            // 
            this.quantité.HeaderText = "quantité";
            this.quantité.MinimumWidth = 8;
            this.quantité.Name = "quantité";
            this.quantité.Width = 150;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 8;
            this.Prix.Name = "Prix";
            this.Prix.Width = 150;
            // 
            // add_produit
            // 
            this.add_produit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.add_produit.BackColor = System.Drawing.Color.Lime;
            this.add_produit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_produit.Location = new System.Drawing.Point(124, 64);
            this.add_produit.Name = "add_produit";
            this.add_produit.Size = new System.Drawing.Size(211, 45);
            this.add_produit.TabIndex = 3;
            this.add_produit.Text = "nouveau produit";
            this.add_produit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_produit.UseVisualStyleBackColor = false;
            this.add_produit.Click += new System.EventHandler(this.add_produit_Click);
            // 
            // supprimer_produit
            // 
            this.supprimer_produit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.supprimer_produit.BackColor = System.Drawing.Color.DeepPink;
            this.supprimer_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_produit.Location = new System.Drawing.Point(411, 64);
            this.supprimer_produit.Name = "supprimer_produit";
            this.supprimer_produit.Size = new System.Drawing.Size(236, 45);
            this.supprimer_produit.TabIndex = 4;
            this.supprimer_produit.Text = "supprimer produit";
            this.supprimer_produit.UseVisualStyleBackColor = false;
            this.supprimer_produit.Click += new System.EventHandler(this.supprimer_produit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Acheter Produit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Produit_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.add_produit);
            this.Controls.Add(this.supprimer_produit);
            this.Name = "Produit_List";
            this.Size = new System.Drawing.Size(889, 636);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button add_produit;
        private System.Windows.Forms.Button supprimer_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
    }
}
