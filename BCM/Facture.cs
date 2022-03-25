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
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();


            afficherAgenceComboBoxEtudiant(); //fonction affiche client comboBox
        }

        private void Facture_Load(object sender, EventArgs e)
        {

            this.reportViewerFactureGros.RefreshReport();
        }


        //******************************************************************************************************************
        //fonction affiche client comboBox
        public void afficherAgenceComboBoxEtudiant()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM client";

                con.Open();
                MySqlCommand perso = new MySqlCommand(personnel, con);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    comboBoxNomClient.Items.Add(lire.GetString("nom_Client"));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        //**************************************************************************************
        //affiche
        //bouton d'Affichage de toutes les facture

        private void buttonAfficheToutesVentes_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                //string requete = "SELECT nom_Produit, quantite, prix_vente, total FROM vente WHERE ID BETWEEN '" + textBoxDe.Text + "' AND '" + textBoxA.Text + "'  ";

                string requete = "SELECT * FROM  client_gros ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetClient dsV = new DataSetClient();

                md.Fill(dsV, "client");

                ReportDataSource source = new ReportDataSource("DataSetC", dsV.Tables[0]);

                this.reportViewerFactureGros.LocalReport.DataSources.Clear();
                this.reportViewerFactureGros.LocalReport.DataSources.Add(source);
                this.reportViewerFactureGros.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //**************************************************************************************
        //affiche
        //bouton d'Affichage de toutes les facture

        private void buttonInventaireDate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                //string requete = "SELECT nom_Produit, quantite, prix_vente, total FROM vente WHERE ID BETWEEN '" + textBoxDe.Text + "' AND '" + textBoxA.Text + "'  ";

                string requete = "SELECT * FROM  client_gros WHERE date_sortie BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "' ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetClient dsV = new DataSetClient();

                md.Fill(dsV, "client");

                ReportDataSource source = new ReportDataSource("DataSetC", dsV.Tables[0]);

                this.reportViewerFactureGros.LocalReport.DataSources.Clear();
                this.reportViewerFactureGros.LocalReport.DataSources.Add(source);
                this.reportViewerFactureGros.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //**************************************************************************************
        //affiche
        //bouton d'Affichage de la facture d'un client par date

        private void buttonClientParDate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                //string requete = "SELECT nom_Produit, quantite, prix_vente, total FROM vente WHERE ID BETWEEN '" + textBoxDe.Text + "' AND '" + textBoxA.Text + "'  ";

                // string requete = "SELECT * FROM  client_gros WHERE  nom_client '" + comboBoxNomClient.Text + "' , date_sortie BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "' ";

                string requete = "SELECT * FROM  client_gros WHERE date_sortie BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "' ";

                //Si 
                if (comboBoxNomClient.Text!="")
                    requete+= " AND nom_client='"+ comboBoxNomClient.Text+ "'";
                if(comboBoxCreditCash.Text!="")
                    requete+=" AND situation='"+ comboBoxCreditCash.Text + "'";
               

                    //



                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetClient dsV = new DataSetClient();

                md.Fill(dsV, "client");

                ReportDataSource source = new ReportDataSource("DataSetC", dsV.Tables[0]);

                this.reportViewerFactureGros.LocalReport.DataSources.Clear();
                this.reportViewerFactureGros.LocalReport.DataSources.Add(source);
                this.reportViewerFactureGros.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReportSituation_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                //string requete = "SELECT nom_Produit, quantite, prix_vente, total FROM vente WHERE ID BETWEEN '" + textBoxDe.Text + "' AND '" + textBoxA.Text + "'  ";

                string requete = "SELECT * FROM  client_gros WHERE situation = '" + comboBoxCreditCash.Text + "' ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetClient dsV = new DataSetClient();

                md.Fill(dsV, "client");

                ReportDataSource source = new ReportDataSource("DataSetC", dsV.Tables[0]);

                this.reportViewerFactureGros.LocalReport.DataSources.Clear();
                this.reportViewerFactureGros.LocalReport.DataSources.Add(source);
                this.reportViewerFactureGros.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
