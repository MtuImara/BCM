using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace BCM
{
    public partial class TableauDeBordStock : Form
    {
        public TableauDeBordStock()
        {
            InitializeComponent();

            situationStockGraph(); //appel fonction
        }

        private void TableauDeBordStock_Load(object sender, EventArgs e)
        {

            this.reportViewerTableauDeBord.RefreshReport();
        }

        public void situationStockGraph()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_Produit, quantite FROM stock  ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetProduit dsV = new DataSetProduit();

                md.Fill(dsV, "Produit_Stocke");

                ReportDataSource source = new ReportDataSource("DataSetGraphStock", dsV.Tables[0]);

                this.reportViewerTableauDeBord.LocalReport.DataSources.Clear();
                this.reportViewerTableauDeBord.LocalReport.DataSources.Add(source);
                this.reportViewerTableauDeBord.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
