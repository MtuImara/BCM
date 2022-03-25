namespace BCM
{
    partial class InventaireProduit
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Produit_StockeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetProduit = new BCM.DataSetProduit();
            this.groupBoxInvProd = new System.Windows.Forms.GroupBox();
            this.reportViewerProduitStock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.Produit_StockeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProduit)).BeginInit();
            this.groupBoxInvProd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Produit_StockeBindingSource
            // 
            this.Produit_StockeBindingSource.DataMember = "Produit_Stocke";
            this.Produit_StockeBindingSource.DataSource = this.DataSetProduit;
            // 
            // DataSetProduit
            // 
            this.DataSetProduit.DataSetName = "DataSetProduit";
            this.DataSetProduit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxInvProd
            // 
            this.groupBoxInvProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInvProd.BackColor = System.Drawing.Color.White;
            this.groupBoxInvProd.Controls.Add(this.reportViewerProduitStock);
            this.groupBoxInvProd.Controls.Add(this.groupBox2);
            this.groupBoxInvProd.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxInvProd.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInvProd.Name = "groupBoxInvProd";
            this.groupBoxInvProd.Size = new System.Drawing.Size(1063, 603);
            this.groupBoxInvProd.TabIndex = 4;
            this.groupBoxInvProd.TabStop = false;
            this.groupBoxInvProd.Text = "Rapport Produit";
            // 
            // reportViewerProduitStock
            // 
            reportDataSource1.Name = "DataSet_Produit_Stocke";
            reportDataSource1.Value = this.Produit_StockeBindingSource;
            this.reportViewerProduitStock.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerProduitStock.LocalReport.ReportEmbeddedResource = "BCM.ReportProduitStocke.rdlc";
            this.reportViewerProduitStock.Location = new System.Drawing.Point(40, 22);
            this.reportViewerProduitStock.Name = "reportViewerProduitStock";
            this.reportViewerProduitStock.ServerReport.BearerToken = null;
            this.reportViewerProduitStock.Size = new System.Drawing.Size(631, 575);
            this.reportViewerProduitStock.TabIndex = 15;
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
            this.groupBox2.Location = new System.Drawing.Point(709, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 516);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(18, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 93);
            this.panel1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(63, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "Rapport";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Voir tous les Produits Stockés";
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
            this.label3.Location = new System.Drawing.Point(149, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Au";
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
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "To";
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
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "Vérification des Produits en cours de \r\nfinition";
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
            this.label1.Location = new System.Drawing.Point(3, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voir les produits commandés par date";
            // 
            // InventaireProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1087, 627);
            this.Controls.Add(this.groupBoxInvProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventaireProduit";
            this.Text = "Agence";
            this.Load += new System.EventHandler(this.InventaireProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Produit_StockeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProduit)).EndInit();
            this.groupBoxInvProd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInvProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProduitStock;
        private System.Windows.Forms.BindingSource Produit_StockeBindingSource;
        private DataSetProduit DataSetProduit;
    }
}