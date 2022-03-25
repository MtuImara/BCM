namespace BCM
{
    partial class RapportRetour
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
            this.groupBoxInvProd = new System.Windows.Forms.GroupBox();
            this.reportViewerRetour = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonInventaireDateNomProduit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNomProduit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.DataSetRetour = new BCM.DataSetRetour();
            this.RetourProduitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxInvProd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourProduitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInvProd
            // 
            this.groupBoxInvProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInvProd.BackColor = System.Drawing.Color.White;
            this.groupBoxInvProd.Controls.Add(this.reportViewerRetour);
            this.groupBoxInvProd.Controls.Add(this.groupBox2);
            this.groupBoxInvProd.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxInvProd.Location = new System.Drawing.Point(4, 7);
            this.groupBoxInvProd.Name = "groupBoxInvProd";
            this.groupBoxInvProd.Size = new System.Drawing.Size(1063, 603);
            this.groupBoxInvProd.TabIndex = 6;
            this.groupBoxInvProd.TabStop = false;
            this.groupBoxInvProd.Text = "Rapport Retour";
            // 
            // reportViewerRetour
            // 
            reportDataSource2.Name = "DataSetRetourP";
            reportDataSource2.Value = this.RetourProduitBindingSource;
            this.reportViewerRetour.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRetour.LocalReport.ReportEmbeddedResource = "BCM.ReportRetourProduit.rdlc";
            this.reportViewerRetour.Location = new System.Drawing.Point(16, 22);
            this.reportViewerRetour.Name = "reportViewerRetour";
            this.reportViewerRetour.ServerReport.BearerToken = null;
            this.reportViewerRetour.Size = new System.Drawing.Size(616, 550);
            this.reportViewerRetour.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(657, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 400);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxNomProduit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateFin);
            this.groupBox1.Controls.Add(this.dateDebut);
            this.groupBox1.Location = new System.Drawing.Point(30, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonInventaireDateNomProduit);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(30, 222);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 156);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            // 
            // buttonInventaireDateNomProduit
            // 
            this.buttonInventaireDateNomProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDateNomProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInventaireDateNomProduit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDateNomProduit.FlatAppearance.BorderSize = 0;
            this.buttonInventaireDateNomProduit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonInventaireDateNomProduit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonInventaireDateNomProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventaireDateNomProduit.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonInventaireDateNomProduit.ForeColor = System.Drawing.Color.White;
            this.buttonInventaireDateNomProduit.Location = new System.Drawing.Point(73, 82);
            this.buttonInventaireDateNomProduit.Name = "buttonInventaireDateNomProduit";
            this.buttonInventaireDateNomProduit.Size = new System.Drawing.Size(178, 36);
            this.buttonInventaireDateNomProduit.TabIndex = 34;
            this.buttonInventaireDateNomProduit.Text = "Rapport";
            this.buttonInventaireDateNomProduit.UseVisualStyleBackColor = false;
            this.buttonInventaireDateNomProduit.Click += new System.EventHandler(this.buttonInventaireDateNomProduit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 34);
            this.label2.TabIndex = 28;
            this.label2.Text = "Voir tous les Retours par date et/ou avec \r\nle Nom du Produit";
            // 
            // comboBoxNomProduit
            // 
            this.comboBoxNomProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNomProduit.FormattingEnabled = true;
            this.comboBoxNomProduit.Location = new System.Drawing.Point(156, 103);
            this.comboBoxNomProduit.Name = "comboBoxNomProduit";
            this.comboBoxNomProduit.Size = new System.Drawing.Size(144, 25);
            this.comboBoxNomProduit.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(39, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nom du Produit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(155, 38);
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
            this.dateFin.Location = new System.Drawing.Point(191, 40);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(127, 22);
            this.dateFin.TabIndex = 31;
            // 
            // dateDebut
            // 
            this.dateDebut.CustomFormat = "yyyy-MM-dd";
            this.dateDebut.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(18, 40);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(127, 22);
            this.dateDebut.TabIndex = 30;
            // 
            // DataSetRetour
            // 
            this.DataSetRetour.DataSetName = "DataSetRetour";
            this.DataSetRetour.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RetourProduitBindingSource
            // 
            this.RetourProduitBindingSource.DataMember = "RetourProduit";
            this.RetourProduitBindingSource.DataSource = this.DataSetRetour;
            // 
            // RapportRetour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1087, 627);
            this.Controls.Add(this.groupBoxInvProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RapportRetour";
            this.Text = "RapportRetour";
            this.Load += new System.EventHandler(this.RapportRetour_Load);
            this.groupBoxInvProd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourProduitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInvProd;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRetour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonInventaireDateNomProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNomProduit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.BindingSource RetourProduitBindingSource;
        private DataSetRetour DataSetRetour;
    }
}