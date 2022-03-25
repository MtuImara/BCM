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
    public partial class RapportRetour : Form
    {
        public RapportRetour()
        {
            InitializeComponent();

            afficherProduitComboBox(); //appel fonction
        }

        private void RapportRetour_Load(object sender, EventArgs e)
        {

        }


        //******************************************************************************************************************
        //fonction affiche client comboBox
        public void afficherProduitComboBox()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM stock";

                con.Open();
                MySqlCommand perso = new MySqlCommand(personnel, con);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    comboBoxNomProduit.Items.Add(lire.GetString("nom_Produit"));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        private void buttonInventaireDateNomProduit_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                
                string requete = "SELECT * FROM  retour WHERE dateRetour BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "' ";

                //multiple requette
                if (comboBoxNomProduit.Text != "")
                    requete += " AND nom_Produit='" + comboBoxNomProduit.Text + "'";
               /* if (comboBoxCreditCash.Text != "")
                    requete += " AND situation='" + comboBoxCreditCash.Text + "'";

                */

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetRetour dsV = new DataSetRetour();

                md.Fill(dsV, "RetourProduit");

                ReportDataSource source = new ReportDataSource("DataSetRetourP", dsV.Tables[0]);

                this.reportViewerRetour.LocalReport.DataSources.Clear();
                this.reportViewerRetour.LocalReport.DataSources.Add(source);
                this.reportViewerRetour.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
