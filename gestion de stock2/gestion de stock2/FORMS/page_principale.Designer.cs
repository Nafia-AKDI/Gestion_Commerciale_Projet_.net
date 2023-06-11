namespace gestion_de_stock2.FORMS
{
    partial class page_principale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlafficher = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.client);
            this.panel1.Location = new System.Drawing.Point(-1, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 709);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(320, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 38);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(312, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 44);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnlafficher
            // 
            this.pnlafficher.Location = new System.Drawing.Point(347, 63);
            this.pnlafficher.Name = "pnlafficher";
            this.pnlafficher.Size = new System.Drawing.Size(767, 603);
            this.pnlafficher.TabIndex = 2;
            this.pnlafficher.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlafficher_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.BackgroundImage = global::gestion_de_stock2.Properties.Resources.icons8_quitter_30__1_;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(795, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 38);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.BackgroundImage = global::gestion_de_stock2.Properties.Resources.icons8_fournisseur_90;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(104, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 91);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImage = global::gestion_de_stock2.Properties.Resources.icons8_commande_901;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(104, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 91);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImage = global::gestion_de_stock2.Properties.Resources.icons8_chasse_au_produit_90__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(104, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 95);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.client.BackgroundImage = global::gestion_de_stock2.Properties.Resources.icons8_groupe_d__39_utilisateurs_90;
            this.client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.client.ForeColor = System.Drawing.Color.FloralWhite;
            this.client.Location = new System.Drawing.Point(104, 71);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(91, 95);
            this.client.TabIndex = 0;
            this.client.UseVisualStyleBackColor = false;
            this.client.Click += new System.EventHandler(this.button1_Click);
            // 
            // page_principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 696);
            this.Controls.Add(this.pnlafficher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "page_principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "page_principale";
            this.Load += new System.EventHandler(this.page_principale_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlafficher;
    }
}