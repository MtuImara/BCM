namespace BCM
{
    partial class Perso
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonNettoyage = new System.Windows.Forms.Button();
            this.buttonSupprimerPerso = new System.Windows.Forms.Button();
            this.buttonModifierPerso = new System.Windows.Forms.Button();
            this.buttonAjoutPersonnel = new System.Windows.Forms.Button();
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.textBoxMotPass = new System.Windows.Forms.TextBox();
            this.textBoxNomPerso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.buttonNettoyage);
            this.groupBox1.Controls.Add(this.buttonSupprimerPerso);
            this.groupBox1.Controls.Add(this.buttonModifierPerso);
            this.groupBox1.Controls.Add(this.buttonAjoutPersonnel);
            this.groupBox1.Controls.Add(this.dataGridViewPersonnel);
            this.groupBox1.Controls.Add(this.textBoxMotPass);
            this.groupBox1.Controls.Add(this.textBoxNomPerso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(235, 128);
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
            this.buttonNettoyage.Location = new System.Drawing.Point(180, 213);
            this.buttonNettoyage.Name = "buttonNettoyage";
            this.buttonNettoyage.Size = new System.Drawing.Size(94, 36);
            this.buttonNettoyage.TabIndex = 8;
            this.buttonNettoyage.Text = "Refresh";
            this.buttonNettoyage.UseVisualStyleBackColor = false;
            this.buttonNettoyage.Click += new System.EventHandler(this.buttonNettoyage_Click);
            // 
            // buttonSupprimerPerso
            // 
            this.buttonSupprimerPerso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerPerso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerPerso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerPerso.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerPerso.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerPerso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerPerso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSupprimerPerso.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerPerso.Location = new System.Drawing.Point(26, 213);
            this.buttonSupprimerPerso.Name = "buttonSupprimerPerso";
            this.buttonSupprimerPerso.Size = new System.Drawing.Size(94, 36);
            this.buttonSupprimerPerso.TabIndex = 7;
            this.buttonSupprimerPerso.Text = "Supprimer";
            this.buttonSupprimerPerso.UseVisualStyleBackColor = false;
            this.buttonSupprimerPerso.Click += new System.EventHandler(this.buttonSupprimerPerso_Click);
            // 
            // buttonModifierPerso
            // 
            this.buttonModifierPerso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierPerso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierPerso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierPerso.FlatAppearance.BorderSize = 0;
            this.buttonModifierPerso.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierPerso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierPerso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonModifierPerso.ForeColor = System.Drawing.Color.White;
            this.buttonModifierPerso.Location = new System.Drawing.Point(180, 156);
            this.buttonModifierPerso.Name = "buttonModifierPerso";
            this.buttonModifierPerso.Size = new System.Drawing.Size(94, 36);
            this.buttonModifierPerso.TabIndex = 6;
            this.buttonModifierPerso.Text = "Modifier";
            this.buttonModifierPerso.UseVisualStyleBackColor = false;
            this.buttonModifierPerso.Click += new System.EventHandler(this.buttonModifierPerso_Click);
            // 
            // buttonAjoutPersonnel
            // 
            this.buttonAjoutPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjoutPersonnel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutPersonnel.FlatAppearance.BorderSize = 0;
            this.buttonAjoutPersonnel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutPersonnel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutPersonnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAjoutPersonnel.ForeColor = System.Drawing.Color.White;
            this.buttonAjoutPersonnel.Location = new System.Drawing.Point(26, 156);
            this.buttonAjoutPersonnel.Name = "buttonAjoutPersonnel";
            this.buttonAjoutPersonnel.Size = new System.Drawing.Size(94, 36);
            this.buttonAjoutPersonnel.TabIndex = 5;
            this.buttonAjoutPersonnel.Text = "Nouveau";
            this.buttonAjoutPersonnel.UseVisualStyleBackColor = false;
            this.buttonAjoutPersonnel.Click += new System.EventHandler(this.buttonAjoutPersonnel_Click);
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(300, 42);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(240, 197);
            this.dataGridViewPersonnel.TabIndex = 4;
            this.dataGridViewPersonnel.Click += new System.EventHandler(this.eventRemplissageTextBox);
            // 
            // textBoxMotPass
            // 
            this.textBoxMotPass.Location = new System.Drawing.Point(129, 84);
            this.textBoxMotPass.Name = "textBoxMotPass";
            this.textBoxMotPass.Size = new System.Drawing.Size(145, 22);
            this.textBoxMotPass.TabIndex = 3;
            // 
            // textBoxNomPerso
            // 
            this.textBoxNomPerso.Location = new System.Drawing.Point(129, 39);
            this.textBoxNomPerso.Name = "textBoxNomPerso";
            this.textBoxNomPerso.Size = new System.Drawing.Size(145, 22);
            this.textBoxNomPerso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassWord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // Perso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Perso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonNettoyage;
        private System.Windows.Forms.Button buttonSupprimerPerso;
        private System.Windows.Forms.Button buttonModifierPerso;
        private System.Windows.Forms.Button buttonAjoutPersonnel;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.TextBox textBoxMotPass;
        private System.Windows.Forms.TextBox textBoxNomPerso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}