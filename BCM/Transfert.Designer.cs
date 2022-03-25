namespace BCM
{
    partial class Transfert
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxIDTrensfert = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNettoyage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRechercheProd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIDStock = new System.Windows.Forms.TextBox();
            this.buttonSuppressionProduitTransferer = new System.Windows.Forms.Button();
            this.buttonTransfert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTransfert = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantiteATransfere = new System.Windows.Forms.TextBox();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomProduit = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTransfert = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.groupBoxTransfert.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfert)).BeginInit();
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
            this.groupBoxTransfert.Controls.Add(this.groupBox4);
            this.groupBoxTransfert.Controls.Add(this.buttonNettoyage);
            this.groupBoxTransfert.Controls.Add(this.label6);
            this.groupBoxTransfert.Controls.Add(this.textBoxRechercheProd);
            this.groupBoxTransfert.Controls.Add(this.groupBox2);
            this.groupBoxTransfert.Controls.Add(this.groupBox1);
            this.groupBoxTransfert.Controls.Add(this.groupBox7);
            this.groupBoxTransfert.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransfert.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTransfert.Name = "groupBoxTransfert";
            this.groupBoxTransfert.Size = new System.Drawing.Size(1063, 603);
            this.groupBoxTransfert.TabIndex = 2;
            this.groupBoxTransfert.TabStop = false;
            this.groupBoxTransfert.Text = "TRANSFERT et RETOURS";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox4.Controls.Add(this.textBoxIDTrensfert);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(736, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 133);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Retour des Produits";
            // 
            // textBoxIDTrensfert
            // 
            this.textBoxIDTrensfert.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxIDTrensfert.Location = new System.Drawing.Point(8, 103);
            this.textBoxIDTrensfert.Name = "textBoxIDTrensfert";
            this.textBoxIDTrensfert.ReadOnly = true;
            this.textBoxIDTrensfert.Size = new System.Drawing.Size(36, 24);
            this.textBoxIDTrensfert.TabIndex = 36;
            this.textBoxIDTrensfert.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BCM.Properties.Resources.transfert;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(40, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 37);
            this.button1.TabIndex = 35;
            this.button1.Text = "Retour Produit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.buttonNettoyage.Location = new System.Drawing.Point(518, 301);
            this.buttonNettoyage.Name = "buttonNettoyage";
            this.buttonNettoyage.Size = new System.Drawing.Size(113, 27);
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
            this.label6.Location = new System.Drawing.Point(145, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Recherche Produit:";
            // 
            // textBoxRechercheProd
            // 
            this.textBoxRechercheProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxRechercheProd.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxRechercheProd.Location = new System.Drawing.Point(294, 303);
            this.textBoxRechercheProd.Name = "textBoxRechercheProd";
            this.textBoxRechercheProd.Size = new System.Drawing.Size(151, 24);
            this.textBoxRechercheProd.TabIndex = 17;
            this.textBoxRechercheProd.TextChanged += new System.EventHandler(this.EvenementDeRechercheTransfertStock);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.textBoxIDStock);
            this.groupBox2.Controls.Add(this.buttonSuppressionProduitTransferer);
            this.groupBox2.Controls.Add(this.buttonTransfert);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBoxNomProduit);
            this.groupBox2.Controls.Add(this.textBoxStock);
            this.groupBox2.Location = new System.Drawing.Point(715, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 368);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // textBoxIDStock
            // 
            this.textBoxIDStock.Location = new System.Drawing.Point(12, 91);
            this.textBoxIDStock.Name = "textBoxIDStock";
            this.textBoxIDStock.Size = new System.Drawing.Size(44, 26);
            this.textBoxIDStock.TabIndex = 37;
            this.textBoxIDStock.Visible = false;
            // 
            // buttonSuppressionProduitTransferer
            // 
            this.buttonSuppressionProduitTransferer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSuppressionProduitTransferer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSuppressionProduitTransferer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSuppressionProduitTransferer.FlatAppearance.BorderSize = 0;
            this.buttonSuppressionProduitTransferer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSuppressionProduitTransferer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSuppressionProduitTransferer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuppressionProduitTransferer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuppressionProduitTransferer.ForeColor = System.Drawing.Color.White;
            this.buttonSuppressionProduitTransferer.Image = global::BCM.Properties.Resources.sup;
            this.buttonSuppressionProduitTransferer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuppressionProduitTransferer.Location = new System.Drawing.Point(83, 311);
            this.buttonSuppressionProduitTransferer.Name = "buttonSuppressionProduitTransferer";
            this.buttonSuppressionProduitTransferer.Size = new System.Drawing.Size(154, 40);
            this.buttonSuppressionProduitTransferer.TabIndex = 36;
            this.buttonSuppressionProduitTransferer.Text = "Supprimer";
            this.buttonSuppressionProduitTransferer.UseVisualStyleBackColor = false;
            this.buttonSuppressionProduitTransferer.Click += new System.EventHandler(this.buttonSuppressionProduitTransferer_Click);
            // 
            // buttonTransfert
            // 
            this.buttonTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonTransfert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransfert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonTransfert.FlatAppearance.BorderSize = 0;
            this.buttonTransfert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonTransfert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonTransfert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfert.ForeColor = System.Drawing.Color.White;
            this.buttonTransfert.Image = global::BCM.Properties.Resources.transfert;
            this.buttonTransfert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransfert.Location = new System.Drawing.Point(67, 256);
            this.buttonTransfert.Name = "buttonTransfert";
            this.buttonTransfert.Size = new System.Drawing.Size(186, 37);
            this.buttonTransfert.TabIndex = 34;
            this.buttonTransfert.Text = "Transférer";
            this.buttonTransfert.UseVisualStyleBackColor = false;
            this.buttonTransfert.Click += new System.EventHandler(this.buttonTransfert_Click);
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
            this.groupBox3.Controls.Add(this.dateTransfert);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxQuantiteATransfere);
            this.groupBox3.Controls.Add(this.comboBoxDestination);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(21, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 114);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // dateTransfert
            // 
            this.dateTransfert.CustomFormat = "yyyy-MM-dd";
            this.dateTransfert.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.dateTransfert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTransfert.Location = new System.Drawing.Point(80, 77);
            this.dateTransfert.Name = "dateTransfert";
            this.dateTransfert.Size = new System.Drawing.Size(127, 22);
            this.dateTransfert.TabIndex = 29;
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
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(180, 41);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(80, 27);
            this.comboBoxDestination.TabIndex = 13;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestination_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(180, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Destination";
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
            this.groupBox1.Controls.Add(this.dataGridViewTransfert);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.55F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 257);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfert";
            // 
            // dataGridViewTransfert
            // 
            this.dataGridViewTransfert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransfert.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransfert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransfert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewTransfert.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewTransfert.Name = "dataGridViewTransfert";
            this.dataGridViewTransfert.Size = new System.Drawing.Size(691, 230);
            this.dataGridViewTransfert.TabIndex = 11;
            this.dataGridViewTransfert.Click += new System.EventHandler(this.evenementRemplissageDataGridTransfert);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dataGridViewStock);
            this.groupBox7.Font = new System.Drawing.Font("Century Schoolbook", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(6, 36);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(703, 257);
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
            this.dataGridViewStock.Size = new System.Drawing.Size(691, 230);
            this.dataGridViewStock.TabIndex = 11;
            this.dataGridViewStock.Click += new System.EventHandler(this.evenementRemplissageDonneeStockDataGrid);
            // 
            // Transfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1087, 627);
            this.Controls.Add(this.groupBoxTransfert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transfert";
            this.Text = "Transfert";
            this.groupBoxTransfert.ResumeLayout(false);
            this.groupBoxTransfert.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfert)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTransfert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTransfert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantiteATransfere;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomProduit;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTransfert;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTransfert;
        private System.Windows.Forms.TextBox textBoxRechercheProd;
        private System.Windows.Forms.Button buttonNettoyage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSuppressionProduitTransferer;
        private System.Windows.Forms.TextBox textBoxIDStock;
        private System.Windows.Forms.TextBox textBoxIDTrensfert;
    }
}