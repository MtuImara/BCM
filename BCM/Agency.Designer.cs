namespace BCM
{
    partial class Agency
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotalAgence = new System.Windows.Forms.TextBox();
            this.textBoxLocalisation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonNettoyage = new System.Windows.Forms.Button();
            this.buttonSupprimerAgence = new System.Windows.Forms.Button();
            this.buttonModifierAgence = new System.Windows.Forms.Button();
            this.buttonAjoutAgence = new System.Windows.Forms.Button();
            this.dataGridViewAgence = new System.Windows.Forms.DataGridView();
            this.textBoxNomAgence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgence)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTotalAgence);
            this.groupBox1.Controls.Add(this.textBoxLocalisation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.buttonNettoyage);
            this.groupBox1.Controls.Add(this.buttonSupprimerAgence);
            this.groupBox1.Controls.Add(this.buttonModifierAgence);
            this.groupBox1.Controls.Add(this.buttonAjoutAgence);
            this.groupBox1.Controls.Add(this.dataGridViewAgence);
            this.groupBox1.Controls.Add(this.textBoxNomAgence);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 267);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tot Agence:";
            // 
            // textBoxTotalAgence
            // 
            this.textBoxTotalAgence.Location = new System.Drawing.Point(489, 14);
            this.textBoxTotalAgence.Name = "textBoxTotalAgence";
            this.textBoxTotalAgence.ReadOnly = true;
            this.textBoxTotalAgence.Size = new System.Drawing.Size(39, 22);
            this.textBoxTotalAgence.TabIndex = 12;
            // 
            // textBoxLocalisation
            // 
            this.textBoxLocalisation.Location = new System.Drawing.Point(129, 81);
            this.textBoxLocalisation.Name = "textBoxLocalisation";
            this.textBoxLocalisation.Size = new System.Drawing.Size(145, 22);
            this.textBoxLocalisation.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Localisation:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(235, 118);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(39, 22);
            this.textBoxID.TabIndex = 9;
            this.textBoxID.Visible = false;
            // 
            // buttonNettoyage
            // 
            this.buttonNettoyage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNettoyage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.FlatAppearance.BorderSize = 0;
            this.buttonNettoyage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonNettoyage.ForeColor = System.Drawing.Color.White;
            this.buttonNettoyage.Location = new System.Drawing.Point(180, 200);
            this.buttonNettoyage.Name = "buttonNettoyage";
            this.buttonNettoyage.Size = new System.Drawing.Size(94, 36);
            this.buttonNettoyage.TabIndex = 8;
            this.buttonNettoyage.Text = "Refresh";
            this.buttonNettoyage.UseVisualStyleBackColor = false;
            this.buttonNettoyage.Click += new System.EventHandler(this.buttonNettoyage_Click);
            // 
            // buttonSupprimerAgence
            // 
            this.buttonSupprimerAgence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerAgence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerAgence.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerAgence.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerAgence.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerAgence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerAgence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSupprimerAgence.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerAgence.Location = new System.Drawing.Point(26, 200);
            this.buttonSupprimerAgence.Name = "buttonSupprimerAgence";
            this.buttonSupprimerAgence.Size = new System.Drawing.Size(94, 36);
            this.buttonSupprimerAgence.TabIndex = 7;
            this.buttonSupprimerAgence.Text = "Supprimer";
            this.buttonSupprimerAgence.UseVisualStyleBackColor = false;
            this.buttonSupprimerAgence.Click += new System.EventHandler(this.buttonSupprimerAgence_Click);
            // 
            // buttonModifierAgence
            // 
            this.buttonModifierAgence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierAgence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierAgence.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierAgence.FlatAppearance.BorderSize = 0;
            this.buttonModifierAgence.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierAgence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierAgence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonModifierAgence.ForeColor = System.Drawing.Color.White;
            this.buttonModifierAgence.Location = new System.Drawing.Point(180, 143);
            this.buttonModifierAgence.Name = "buttonModifierAgence";
            this.buttonModifierAgence.Size = new System.Drawing.Size(94, 36);
            this.buttonModifierAgence.TabIndex = 6;
            this.buttonModifierAgence.Text = "Modifier";
            this.buttonModifierAgence.UseVisualStyleBackColor = false;
            this.buttonModifierAgence.Click += new System.EventHandler(this.buttonModifierAgence_Click);
            // 
            // buttonAjoutAgence
            // 
            this.buttonAjoutAgence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutAgence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjoutAgence.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutAgence.FlatAppearance.BorderSize = 0;
            this.buttonAjoutAgence.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutAgence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutAgence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAjoutAgence.ForeColor = System.Drawing.Color.White;
            this.buttonAjoutAgence.Location = new System.Drawing.Point(26, 143);
            this.buttonAjoutAgence.Name = "buttonAjoutAgence";
            this.buttonAjoutAgence.Size = new System.Drawing.Size(94, 36);
            this.buttonAjoutAgence.TabIndex = 5;
            this.buttonAjoutAgence.Text = "Nouveau";
            this.buttonAjoutAgence.UseVisualStyleBackColor = false;
            this.buttonAjoutAgence.Click += new System.EventHandler(this.buttonAjoutAgence_Click);
            // 
            // dataGridViewAgence
            // 
            this.dataGridViewAgence.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAgence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewAgence.Location = new System.Drawing.Point(300, 42);
            this.dataGridViewAgence.Name = "dataGridViewAgence";
            this.dataGridViewAgence.Size = new System.Drawing.Size(240, 197);
            this.dataGridViewAgence.TabIndex = 4;
            this.dataGridViewAgence.Click += new System.EventHandler(this.eventRemplissageDataGridView);
            // 
            // textBoxNomAgence
            // 
            this.textBoxNomAgence.Location = new System.Drawing.Point(129, 39);
            this.textBoxNomAgence.Name = "textBoxNomAgence";
            this.textBoxNomAgence.Size = new System.Drawing.Size(145, 22);
            this.textBoxNomAgence.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'Agence:";
            // 
            // Agency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agency";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agency";
            this.Load += new System.EventHandler(this.Agency_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalAgence;
        private System.Windows.Forms.TextBox textBoxLocalisation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonNettoyage;
        private System.Windows.Forms.Button buttonSupprimerAgence;
        private System.Windows.Forms.Button buttonModifierAgence;
        private System.Windows.Forms.Button buttonAjoutAgence;
        private System.Windows.Forms.DataGridView dataGridViewAgence;
        private System.Windows.Forms.TextBox textBoxNomAgence;
        private System.Windows.Forms.Label label1;
    }
}