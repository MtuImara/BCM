namespace BCM
{
    partial class Facture
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.client_De_GrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetVente = new BCM.DataSetVente();
            this.groupBoxInvProd = new System.Windows.Forms.GroupBox();
            this.reportViewerFactureGros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClientParDate = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonInventaireDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCreditCash = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxNomClient = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonReportSituation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAfficheToutesVentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSetProduit = new BCM.DataSetProduit();
            this.Produit_StockeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.client_De_GrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVente)).BeginInit();
            this.groupBoxInvProd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Produit_StockeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // client_De_GrosBindingSource
            // 
            this.client_De_GrosBindingSource.DataMember = "client_De_Gros";
            // 
            // venteBindingSource
            // 
            this.venteBindingSource.DataMember = "vente";
            this.venteBindingSource.DataSource = this.DataSetVente;
            // 
            // DataSetVente
            // 
            this.DataSetVente.DataSetName = "DataSetVente";
            this.DataSetVente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxInvProd
            // 
            this.groupBoxInvProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInvProd.BackColor = System.Drawing.Color.White;
            this.groupBoxInvProd.Controls.Add(this.reportViewerFactureGros);
            this.groupBoxInvProd.Controls.Add(this.groupBox2);
            this.groupBoxInvProd.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxInvProd.Location = new System.Drawing.Point(4, 12);
            this.groupBoxInvProd.Name = "groupBoxInvProd";
            this.groupBoxInvProd.Size = new System.Drawing.Size(1063, 603);
            this.groupBoxInvProd.TabIndex = 5;
            this.groupBoxInvProd.TabStop = false;
            this.groupBoxInvProd.Text = "Rapport Facture de Gros";
            // 
            // reportViewerFactureGros
            // 
            reportDataSource2.Name = "DataSetClientDeGros";
            reportDataSource2.Value = this.client_De_GrosBindingSource;
            this.reportViewerFactureGros.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerFactureGros.LocalReport.ReportEmbeddedResource = "BCM.ReportFactureGros.rdlc";
            this.reportViewerFactureGros.Location = new System.Drawing.Point(16, 22);
            this.reportViewerFactureGros.Name = "reportViewerFactureGros";
            this.reportViewerFactureGros.ServerReport.BearerToken = null;
            this.reportViewerFactureGros.Size = new System.Drawing.Size(616, 550);
            this.reportViewerFactureGros.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(657, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 550);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.comboBoxCreditCash);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxNomClient);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateFin);
            this.groupBox1.Controls.Add(this.dateDebut);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 516);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.buttonClientParDate);
            this.groupBox6.Location = new System.Drawing.Point(6, 243);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(324, 88);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Voir Achat d\'un Client Par Date";
            // 
            // buttonClientParDate
            // 
            this.buttonClientParDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonClientParDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientParDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonClientParDate.FlatAppearance.BorderSize = 0;
            this.buttonClientParDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonClientParDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonClientParDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientParDate.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonClientParDate.ForeColor = System.Drawing.Color.White;
            this.buttonClientParDate.Location = new System.Drawing.Point(75, 44);
            this.buttonClientParDate.Name = "buttonClientParDate";
            this.buttonClientParDate.Size = new System.Drawing.Size(178, 36);
            this.buttonClientParDate.TabIndex = 27;
            this.buttonClientParDate.Text = "Rapport";
            this.buttonClientParDate.UseVisualStyleBackColor = false;
            this.buttonClientParDate.Click += new System.EventHandler(this.buttonClientParDate_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonInventaireDate);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(6, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 88);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            // 
            // buttonInventaireDate
            // 
            this.buttonInventaireDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInventaireDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDate.FlatAppearance.BorderSize = 0;
            this.buttonInventaireDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonInventaireDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventaireDate.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonInventaireDate.ForeColor = System.Drawing.Color.White;
            this.buttonInventaireDate.Location = new System.Drawing.Point(73, 43);
            this.buttonInventaireDate.Name = "buttonInventaireDate";
            this.buttonInventaireDate.Size = new System.Drawing.Size(178, 36);
            this.buttonInventaireDate.TabIndex = 34;
            this.buttonInventaireDate.Text = "Rapport";
            this.buttonInventaireDate.UseVisualStyleBackColor = false;
            this.buttonInventaireDate.Click += new System.EventHandler(this.buttonInventaireDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Voir toutes les Ventes de Gros Par Date";
            // 
            // comboBoxCreditCash
            // 
            this.comboBoxCreditCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCreditCash.FormattingEnabled = true;
            this.comboBoxCreditCash.Items.AddRange(new object[] {
            "Cash",
            "Dette",
            "Remboursement"});
            this.comboBoxCreditCash.Location = new System.Drawing.Point(143, 102);
            this.comboBoxCreditCash.Name = "comboBoxCreditCash";
            this.comboBoxCreditCash.Size = new System.Drawing.Size(144, 25);
            this.comboBoxCreditCash.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(71, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "Situation:";
            // 
            // comboBoxNomClient
            // 
            this.comboBoxNomClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNomClient.FormattingEnabled = true;
            this.comboBoxNomClient.Location = new System.Drawing.Point(143, 61);
            this.comboBoxNomClient.Name = "comboBoxNomClient";
            this.comboBoxNomClient.Size = new System.Drawing.Size(144, 25);
            this.comboBoxNomClient.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(39, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nom du Client:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonReportSituation);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 86);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            // 
            // buttonReportSituation
            // 
            this.buttonReportSituation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonReportSituation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportSituation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonReportSituation.FlatAppearance.BorderSize = 0;
            this.buttonReportSituation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonReportSituation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonReportSituation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportSituation.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonReportSituation.ForeColor = System.Drawing.Color.White;
            this.buttonReportSituation.Location = new System.Drawing.Point(73, 43);
            this.buttonReportSituation.Name = "buttonReportSituation";
            this.buttonReportSituation.Size = new System.Drawing.Size(178, 36);
            this.buttonReportSituation.TabIndex = 27;
            this.buttonReportSituation.Text = "Rapport";
            this.buttonReportSituation.UseVisualStyleBackColor = false;
            this.buttonReportSituation.Click += new System.EventHandler(this.buttonReportSituation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(-2, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Voir toutes les Situations de tous les Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(155, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "A";
            // 
            // dateFin
            // 
            this.dateFin.CustomFormat = "yyyy-MM-dd";
            this.dateFin.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(191, 22);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(127, 22);
            this.dateFin.TabIndex = 31;
            // 
            // dateDebut
            // 
            this.dateDebut.CustomFormat = "yyyy-MM-dd";
            this.dateDebut.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(18, 22);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(127, 22);
            this.dateDebut.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAfficheToutesVentes);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 88);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // buttonAfficheToutesVentes
            // 
            this.buttonAfficheToutesVentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficheToutesVentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAfficheToutesVentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficheToutesVentes.FlatAppearance.BorderSize = 0;
            this.buttonAfficheToutesVentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficheToutesVentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAfficheToutesVentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfficheToutesVentes.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAfficheToutesVentes.ForeColor = System.Drawing.Color.White;
            this.buttonAfficheToutesVentes.Location = new System.Drawing.Point(75, 41);
            this.buttonAfficheToutesVentes.Name = "buttonAfficheToutesVentes";
            this.buttonAfficheToutesVentes.Size = new System.Drawing.Size(178, 36);
            this.buttonAfficheToutesVentes.TabIndex = 34;
            this.buttonAfficheToutesVentes.Text = "Rapport";
            this.buttonAfficheToutesVentes.UseVisualStyleBackColor = false;
            this.buttonAfficheToutesVentes.Click += new System.EventHandler(this.buttonAfficheToutesVentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Voir toutes les Ventes";
            // 
            // DataSetProduit
            // 
            this.DataSetProduit.DataSetName = "DataSetProduit";
            this.DataSetProduit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Produit_StockeBindingSource
            // 
            this.Produit_StockeBindingSource.DataMember = "Produit_Stocke";
            this.Produit_StockeBindingSource.DataSource = this.DataSetProduit;
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1087, 627);
            this.Controls.Add(this.groupBoxInvProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facture";
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.client_De_GrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVente)).EndInit();
            this.groupBoxInvProd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Produit_StockeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInvProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource venteBindingSource;
        private DataSetVente DataSetVente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAfficheToutesVentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonReportSituation;
        private System.Windows.Forms.BindingSource Produit_StockeBindingSource;
        private DataSetProduit DataSetProduit;
        private System.Windows.Forms.BindingSource client_De_GrosBindingSource;
       // private DataSetClientGros DataSetClientGros;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFactureGros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNomClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClientParDate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonInventaireDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCreditCash;
        private System.Windows.Forms.Label label9;
    }
}