using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;

namespace BCM
{
    public partial class InventaireVente : Form
    {
        public InventaireVente()
        {
            InitializeComponent();
        }

        private void InventaireVente_Load(object sender, EventArgs e)
        {

          ///  this.reportViewer1.RefreshReport();
        }



        //***********************************************************************
        //boutons rapport

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_Produit, quantite, prix_vente, total, date_Vente, quantite_Retourne, prix_Retour, date_Retour FROM vente  ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetVente dsV = new DataSetVente();

                md.Fill(dsV, "vente");

                ReportDataSource source = new ReportDataSource("DataSetVente", dsV.Tables[0]);

                this.reportViewerVente.LocalReport.DataSources.Clear();
                this.reportViewerVente.LocalReport.DataSources.Add(source);
                this.reportViewerVente.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInventaireDateCommande_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_Produit, quantite, prix_vente, total, date_Vente, quantite_Retourne, prix_Retour, date_Retour FROM vente WHERE date_Vente BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "'  ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetVente dsV = new DataSetVente();

                md.Fill(dsV, "vente");

                ReportDataSource source = new ReportDataSource("DataSetVente", dsV.Tables[0]);

                this.reportViewerVente.LocalReport.DataSources.Clear();
                this.reportViewerVente.LocalReport.DataSources.Add(source);
                this.reportViewerVente.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReportQuantite_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_Produit, quantite, prix_vente, total, date_Vente, quantite_Retourne, prix_Retour, date_Retour FROM vente WHERE quantite BETWEEN '" + textBoxDe.Text + "' AND '" + textBoxA.Text + "'  ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetVente dsV = new DataSetVente();

                md.Fill(dsV, "vente");

                ReportDataSource source = new ReportDataSource("DataSetVente", dsV.Tables[0]);

                this.reportViewerVente.LocalReport.DataSources.Clear();
                this.reportViewerVente.LocalReport.DataSources.Add(source);
                this.reportViewerVente.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //**********************************************************************************************************
        //***************************************************************************************
        //Fonctins de conversion des champs de string en doubleet leur verification

        private void eventDe(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxDe.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

        private void eventA(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxA.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }
    }
}
