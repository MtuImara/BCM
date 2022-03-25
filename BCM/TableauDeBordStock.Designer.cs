namespace BCM
{
    partial class TableauDeBordStock
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
            this.reportViewerTableauDeBord = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerTableauDeBord
            // 
            this.reportViewerTableauDeBord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerTableauDeBord.LocalReport.ReportEmbeddedResource = "BCM.ReportDashBodyStock.rdlc";
            this.reportViewerTableauDeBord.Location = new System.Drawing.Point(12, 12);
            this.reportViewerTableauDeBord.Name = "reportViewerTableauDeBord";
            this.reportViewerTableauDeBord.ServerReport.BearerToken = null;
            this.reportViewerTableauDeBord.ShowToolBar = false;
            this.reportViewerTableauDeBord.Size = new System.Drawing.Size(1047, 548);
            this.reportViewerTableauDeBord.TabIndex = 0;
            // 
            // TableauDeBordStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 588);
            this.Controls.Add(this.reportViewerTableauDeBord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableauDeBordStock";
            this.Text = "TableauDeBordStock";
            this.Load += new System.EventHandler(this.TableauDeBordStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTableauDeBord;
    }
}