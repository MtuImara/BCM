namespace BCM
{
    partial class InventaireVente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBoxPersonnel = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAfficheToutesVentes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonInventaireDateCommande = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDe = new System.Windows.Forms.TextBox();
            this.buttonReportQuantite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewerVente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetVente = new BCM.DataSetVente();
            this.groupBoxPersonnel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPersonnel
            // 
            this.groupBoxPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPersonnel.BackColor = System.Drawing.Color.White;
            this.groupBoxPersonnel.Controls.Add(this.reportViewerVente);
            this.groupBoxPersonnel.Controls.Add(this.groupBox2);
            this.groupBoxPersonnel.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxPersonnel.Location = new System.Drawing.Point(10, 10);
            this.groupBoxPersonnel.Name = "groupBoxPersonnel";
            this.groupBoxPersonnel.Size = new System.Drawing.Size(1067, 607);
            this.groupBoxPersonnel.TabIndex = 4;
            this.groupBoxPersonnel.TabStop = false;
            this.groupBoxPersonnel.Text = "Rapport Vente";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.buttonInventaireDateCommande);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateFin);
            this.groupBox2.Controls.Add(this.dateDebut);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(715, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 516);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAfficheToutesVentes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(18, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 93);
            this.panel1.TabIndex = 34;
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
            this.buttonAfficheToutesVentes.Location = new System.Drawing.Point(63, 44);
            this.buttonAfficheToutesVentes.Name = "buttonAfficheToutesVentes";
            this.buttonAfficheToutesVentes.Size = new System.Drawing.Size(178, 36);
            this.buttonAfficheToutesVentes.TabIndex = 34;
            this.buttonAfficheToutesVentes.Text = "Rapport";
            this.buttonAfficheToutesVentes.UseVisualStyleBackColor = false;
            this.buttonAfficheToutesVentes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(55, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Voir toutes les Ventes";
            // 
            // buttonInventaireDateCommande
            // 
            this.buttonInventaireDateCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDateCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInventaireDateCommande.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDateCommande.FlatAppearance.BorderSize = 0;
            this.buttonInventaireDateCommande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDateCommande.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonInventaireDateCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventaireDateCommande.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonInventaireDateCommande.ForeColor = System.Drawing.Color.White;
            this.buttonInventaireDateCommande.Location = new System.Drawing.Point(81, 224);
            this.buttonInventaireDateCommande.Name = "buttonInventaireDateCommande";
            this.buttonInventaireDateCommande.Size = new System.Drawing.Size(178, 36);
            this.buttonInventaireDateCommande.TabIndex = 33;
            this.buttonInventaireDateCommande.Text = "Rapport";
            this.buttonInventaireDateCommande.UseVisualStyleBackColor = false;
            this.buttonInventaireDateCommande.Click += new System.EventHandler(this.buttonInventaireDateCommande_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(155, 180);
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
            this.dateFin.Location = new System.Drawing.Point(191, 182);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(127, 22);
            this.dateFin.TabIndex = 31;
            // 
            // dateDebut
            // 
            this.dateDebut.CustomFormat = "yyyy-MM-dd";
            this.dateDebut.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(18, 182);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(127, 22);
            this.dateDebut.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxA);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxDe);
            this.groupBox3.Controls.Add(this.buttonReportQuantite);
            this.groupBox3.Location = new System.Drawing.Point(6, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 184);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(148, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "A";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxA.Location = new System.Drawing.Point(205, 78);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(101, 24);
            this.textBoxA.TabIndex = 35;
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eventA);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(316, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Vérification des Ventes par Quantité";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDe
            // 
            this.textBoxDe.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxDe.Location = new System.Drawing.Point(21, 78);
            this.textBoxDe.Name = "textBoxDe";
            this.textBoxDe.Size = new System.Drawing.Size(101, 24);
            this.textBoxDe.TabIndex = 24;
            this.textBoxDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eventDe);
            // 
            // buttonReportQuantite
            // 
            this.buttonReportQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonReportQuantite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportQuantite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonReportQuantite.FlatAppearance.BorderSize = 0;
            this.buttonReportQuantite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonReportQuantite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonReportQuantite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportQuantite.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonReportQuantite.ForeColor = System.Drawing.Color.White;
            this.buttonReportQuantite.Location = new System.Drawing.Point(75, 128);
            this.buttonReportQuantite.Name = "buttonReportQuantite";
            this.buttonReportQuantite.Size = new System.Drawing.Size(178, 36);
            this.buttonReportQuantite.TabIndex = 27;
            this.buttonReportQuantite.Text = "Rapport";
            this.buttonReportQuantite.UseVisualStyleBackColor = false;
            this.buttonReportQuantite.Click += new System.EventHandler(this.buttonReportQuantite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voir les Vente par date";
            // 
            // reportViewerVente
            // 
            reportDataSource4.Name = "DataSetVente";
            reportDataSource4.Value = this.VenteBindingSource;
            this.reportViewerVente.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerVente.LocalReport.ReportEmbeddedResource = "BCM.RapportVente.rdlc";
            this.reportViewerVente.Location = new System.Drawing.Point(6, 28);
            this.reportViewerVente.Name = "reportViewerVente";
            this.reportViewerVente.ServerReport.BearerToken = null;
            this.reportViewerVente.Size = new System.Drawing.Size(703, 561);
            this.reportViewerVente.TabIndex = 16;
            // 
            // VenteBindingSource
            // 
            this.VenteBindingSource.DataMember = "Vente";
            this.VenteBindingSource.DataSource = this.DataSetVente;
            // 
            // DataSetVente
            // 
            this.DataSetVente.DataSetName = "DataSetVente";
            this.DataSetVente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InventaireVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1087, 627);
            this.Controls.Add(this.groupBoxPersonnel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventaireVente";
            this.Load += new System.EventHandler(this.InventaireVente_Load);
            this.groupBoxPersonnel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonnel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAfficheToutesVentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonInventaireDateCommande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDe;
        private System.Windows.Forms.Button buttonReportQuantite;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVente;
        private System.Windows.Forms.BindingSource VenteBindingSource;
        private DataSetVente DataSetVente;
    }
}