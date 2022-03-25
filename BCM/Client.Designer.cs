namespace BCM
{
    partial class Client
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
            this.textBoxTotalClient = new System.Windows.Forms.TextBox();
            this.textBoxLocalisation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonNettoyage = new System.Windows.Forms.Button();
            this.buttonSupprimerClient = new System.Windows.Forms.Button();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.buttonAjoutAgence = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.textBoxNomClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTotalClient);
            this.groupBox1.Controls.Add(this.textBoxLocalisation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.buttonNettoyage);
            this.groupBox1.Controls.Add(this.buttonSupprimerClient);
            this.groupBox1.Controls.Add(this.buttonModifierClient);
            this.groupBox1.Controls.Add(this.buttonAjoutAgence);
            this.groupBox1.Controls.Add(this.dataGridViewClient);
            this.groupBox1.Controls.Add(this.textBoxNomClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tot Client:";
            // 
            // textBoxTotalClient
            // 
            this.textBoxTotalClient.Location = new System.Drawing.Point(489, 14);
            this.textBoxTotalClient.Name = "textBoxTotalClient";
            this.textBoxTotalClient.ReadOnly = true;
            this.textBoxTotalClient.Size = new System.Drawing.Size(39, 22);
            this.textBoxTotalClient.TabIndex = 12;
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
            this.textBoxID.Location = new System.Drawing.Point(235, 149);
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
            this.buttonNettoyage.Location = new System.Drawing.Point(180, 222);
            this.buttonNettoyage.Name = "buttonNettoyage";
            this.buttonNettoyage.Size = new System.Drawing.Size(94, 36);
            this.buttonNettoyage.TabIndex = 8;
            this.buttonNettoyage.Text = "Refresh";
            this.buttonNettoyage.UseVisualStyleBackColor = false;
            this.buttonNettoyage.Click += new System.EventHandler(this.buttonNettoyage_Click);
            // 
            // buttonSupprimerClient
            // 
            this.buttonSupprimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerClient.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerClient.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimerClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSupprimerClient.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerClient.Location = new System.Drawing.Point(26, 222);
            this.buttonSupprimerClient.Name = "buttonSupprimerClient";
            this.buttonSupprimerClient.Size = new System.Drawing.Size(94, 36);
            this.buttonSupprimerClient.TabIndex = 7;
            this.buttonSupprimerClient.Text = "Supprimer";
            this.buttonSupprimerClient.UseVisualStyleBackColor = false;
            this.buttonSupprimerClient.Click += new System.EventHandler(this.buttonSupprimerAgence_Click);
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierClient.FlatAppearance.BorderSize = 0;
            this.buttonModifierClient.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifierClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonModifierClient.ForeColor = System.Drawing.Color.White;
            this.buttonModifierClient.Location = new System.Drawing.Point(180, 176);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(94, 36);
            this.buttonModifierClient.TabIndex = 6;
            this.buttonModifierClient.Text = "Modifier";
            this.buttonModifierClient.UseVisualStyleBackColor = false;
            this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierAgence_Click);
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
            this.buttonAjoutAgence.Location = new System.Drawing.Point(26, 176);
            this.buttonAjoutAgence.Name = "buttonAjoutAgence";
            this.buttonAjoutAgence.Size = new System.Drawing.Size(94, 36);
            this.buttonAjoutAgence.TabIndex = 5;
            this.buttonAjoutAgence.Text = "Nouveau";
            this.buttonAjoutAgence.UseVisualStyleBackColor = false;
            this.buttonAjoutAgence.Click += new System.EventHandler(this.buttonAjoutAgence_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewClient.Location = new System.Drawing.Point(300, 42);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(240, 197);
            this.dataGridViewClient.TabIndex = 4;
            this.dataGridViewClient.Click += new System.EventHandler(this.eventRemplissageDataGridView);
            // 
            // textBoxNomClient
            // 
            this.textBoxNomClient.Location = new System.Drawing.Point(129, 39);
            this.textBoxNomClient.Name = "textBoxNomClient";
            this.textBoxNomClient.Size = new System.Drawing.Size(145, 22);
            this.textBoxNomClient.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Client:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(129, 121);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(145, 22);
            this.textBoxPhone.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalClient;
        private System.Windows.Forms.TextBox textBoxLocalisation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonNettoyage;
        private System.Windows.Forms.Button buttonSupprimerClient;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonAjoutAgence;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxNomClient;
        private System.Windows.Forms.Label label1;
    }
}