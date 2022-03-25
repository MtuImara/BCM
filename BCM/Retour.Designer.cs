namespace BCM
{
    partial class Retour
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
            this.groupBoxTransfert = new System.Windows.Forms.GroupBox();
            this.buttonNettoyage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRechercheProd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIDRetour = new System.Windows.Forms.TextBox();
            this.textBoxIDStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.dateRetour = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantiteATransfere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomProduit = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRetour = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.buttonSuppressionProduitRetourne = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.groupBoxTransfert.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetour)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTransfert
            // 
            this.groupBoxTransfert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTransfert.BackColor = System.Drawing.Color.White;
            this.groupBoxTransfert.Controls.Add(this.buttonNettoyage);
            this.groupBoxTransfert.Controls.Add(this.label6);
            this.groupBoxTransfert.Controls.Add(this.textBoxRechercheProd);
            this.groupBoxTransfert.Controls.Add(this.groupBox2);
            this.groupBoxTransfert.Controls.Add(this.groupBox1);
            this.groupBoxTransfert.Controls.Add(this.groupBox7);
            this.groupBoxTransfert.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransfert.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTransfert.Name = "groupBoxTransfert";
            this.groupBoxTransfert.Size = new System.Drawing.Size(1063, 582);
            this.groupBoxTransfert.TabIndex = 3;
            this.groupBoxTransfert.TabStop = false;
            this.groupBoxTransfert.Text = "RETOUR DES PRODUITS";
            // 
            // buttonNettoyage
            // 
            this.buttonNettoyage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNettoyage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNettoyage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonNettoyage.FlatAppearance.BorderSize = 0;
            this.buttonNettoyage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonNettoyage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNettoyage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNettoyage.ForeColor = System.Drawing.Color.White;
            this.buttonNettoyage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNettoyage.Location = new System.Drawing.Point(518, 277);
            this.buttonNettoyage.Name = "buttonNettoyage";
            this.buttonNettoyage.Size = new System.Drawing.Size(113, 33);
            this.buttonNettoyage.TabIndex = 43;
            this.buttonNettoyage.Text = "Nettoyer";
            this.buttonNettoyage.UseVisualStyleBackColor = false;
            this.buttonNettoyage.Click += new System.EventHandler(this.buttonNettoyage_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(145, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Recherche Produit:";
            // 
            // textBoxRechercheProd
            // 
            this.textBoxRechercheProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxRechercheProd.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxRechercheProd.Location = new System.Drawing.Point(294, 280);
            this.textBoxRechercheProd.Name = "textBoxRechercheProd";
            this.textBoxRechercheProd.Size = new System.Drawing.Size(151, 24);
            this.textBoxRechercheProd.TabIndex = 17;
            this.textBoxRechercheProd.TextChanged += new System.EventHandler(this.EvenementDeRechercheRetourStock);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.textBoxIDRetour);
            this.groupBox2.Controls.Add(this.textBoxIDStock);
            this.groupBox2.Controls.Add(this.buttonSuppressionProduitRetourne);
            this.groupBox2.Controls.Add(this.buttonRetour);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBoxNomProduit);
            this.groupBox2.Controls.Add(this.textBoxStock);
            this.groupBox2.Location = new System.Drawing.Point(715, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 433);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // textBoxIDRetour
            // 
            this.textBoxIDRetour.Location = new System.Drawing.Point(12, 339);
            this.textBoxIDRetour.Name = "textBoxIDRetour";
            this.textBoxIDRetour.Size = new System.Drawing.Size(44, 26);
            this.textBoxIDRetour.TabIndex = 38;
            this.textBoxIDRetour.Visible = false;
            // 
            // textBoxIDStock
            // 
            this.textBoxIDStock.Location = new System.Drawing.Point(12, 91);
            this.textBoxIDStock.Name = "textBoxIDStock";
            this.textBoxIDStock.Size = new System.Drawing.Size(44, 26);
            this.textBoxIDStock.TabIndex = 37;
            this.textBoxIDStock.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(110, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nom du Produit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(98, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Quantité Stockée";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxPrix);
            this.groupBox3.Controls.Add(this.dateRetour);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxQuantiteATransfere);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(21, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 122);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxPrix.Location = new System.Drawing.Point(168, 40);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.ReadOnly = true;
            this.textBoxPrix.Size = new System.Drawing.Size(90, 24);
            this.textBoxPrix.TabIndex = 30;
            // 
            // dateRetour
            // 
            this.dateRetour.CustomFormat = "yyyy-MM-dd";
            this.dateRetour.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.dateRetour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRetour.Location = new System.Drawing.Point(80, 89);
            this.dateRetour.Name = "dateRetour";
            this.dateRetour.Size = new System.Drawing.Size(127, 22);
            this.dateRetour.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantité à Transférer";
            // 
            // textBoxQuantiteATransfere
            // 
            this.textBoxQuantiteATransfere.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxQuantiteATransfere.Location = new System.Drawing.Point(23, 40);
            this.textBoxQuantiteATransfere.Name = "textBoxQuantiteATransfere";
            this.textBoxQuantiteATransfere.Size = new System.Drawing.Size(90, 24);
            this.textBoxQuantiteATransfere.TabIndex = 17;
            this.textBoxQuantiteATransfere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eventQuantite);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(194, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Prix";
            // 
            // textBoxNomProduit
            // 
            this.textBoxNomProduit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNomProduit.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxNomProduit.Location = new System.Drawing.Point(67, 93);
            this.textBoxNomProduit.Name = "textBoxNomProduit";
            this.textBoxNomProduit.ReadOnly = true;
            this.textBoxNomProduit.Size = new System.Drawing.Size(196, 24);
            this.textBoxNomProduit.TabIndex = 24;
            // 
            // textBoxStock
            // 
            this.textBoxStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxStock.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxStock.Location = new System.Drawing.Point(83, 38);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.ReadOnly = true;
            this.textBoxStock.Size = new System.Drawing.Size(150, 24);
            this.textBoxStock.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewRetour);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.55F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retour";
            // 
            // dataGridViewRetour
            // 
            this.dataGridViewRetour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRetour.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRetour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewRetour.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewRetour.Name = "dataGridViewRetour";
            this.dataGridViewRetour.Size = new System.Drawing.Size(691, 217);
            this.dataGridViewRetour.TabIndex = 11;
            this.dataGridViewRetour.Click += new System.EventHandler(this.evenementRemplissageDataGridRetour);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dataGridViewStock);
            this.groupBox7.Font = new System.Drawing.Font("Century Schoolbook", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(6, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(703, 236);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Stock";
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewStock.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(691, 209);
            this.dataGridViewStock.TabIndex = 11;
            this.dataGridViewStock.Click += new System.EventHandler(this.evenementRemplissageDonneeStockDataGrid);
            // 
            // buttonSuppressionProduitRetourne
            // 
            this.buttonSuppressionProduitRetourne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSuppressionProduitRetourne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSuppressionProduitRetourne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSuppressionProduitRetourne.FlatAppearance.BorderSize = 0;
            this.buttonSuppressionProduitRetourne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSuppressionProduitRetourne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSuppressionProduitRetourne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuppressionProduitRetourne.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuppressionProduitRetourne.ForeColor = System.Drawing.Color.White;
            this.buttonSuppressionProduitRetourne.Image = global::BCM.Properties.Resources.sup;
            this.buttonSuppressionProduitRetourne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuppressionProduitRetourne.Location = new System.Drawing.Point(83, 360);
            this.buttonSuppressionProduitRetourne.Name = "buttonSuppressionProduitRetourne";
            this.buttonSuppressionProduitRetourne.Size = new System.Drawing.Size(154, 40);
            this.buttonSuppressionProduitRetourne.TabIndex = 36;
            this.buttonSuppressionProduitRetourne.Text = "Supprimer";
            this.buttonSuppressionProduitRetourne.UseVisualStyleBackColor = false;
            this.buttonSuppressionProduitRetourne.Click += new System.EventHandler(this.buttonSuppressionProduitRetourne_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.White;
            this.buttonRetour.Image = global::BCM.Properties.Resources.transfert;
            this.buttonRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetour.Location = new System.Drawing.Point(67, 283);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(186, 37);
            this.buttonRetour.TabIndex = 34;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // Retour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1071, 601);
            this.Controls.Add(this.groupBoxTransfert);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Retour";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retour";
            this.groupBoxTransfert.ResumeLayout(false);
            this.groupBoxTransfert.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetour)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTransfert;
        private System.Windows.Forms.Button buttonNettoyage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRechercheProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIDStock;
        private System.Windows.Forms.Button buttonSuppressionProduitRetourne;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.DateTimePicker dateRetour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantiteATransfere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomProduit;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRetour;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.TextBox textBoxIDRetour;
    }
}