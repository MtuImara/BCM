using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices; //bibliotheque pour faciliter le deplacement du formulaire
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace BCM
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();

            //appel des foctions du graph
            //situationStockGraph(); //fonction graph stock
            situationVenteGraph(); // fonction graph vente
        }


        //code mere pour faciliter le deplacement du formulaire
        //***************************************************************************************************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hmdw, int wmsg, int wparam, int lparam);
        //***************************************************************************************************


        //fonctions evenementielles permettant de deplacer notre formulaire
        //***************************************************************************************************
        private void eventDeDeplacementFormAccueil(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void eventDeDeplacementEnteteFormAccueil(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void eventDeDeplacementEnTeteFormAccueil(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //***************************************************************************************************



        private void Accueil_Load(object sender, EventArgs e)
        {

            
            this.reportViewerPannel.RefreshReport();
        }


        //bouton de minumisation du menu vertical
        private void button2_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 213)
            {
                panelMenuVertical.Width = 60;
            }
            else
            {
                panelMenuVertical.Width = 213;
            }
        }

        //close fenetre
        private void button1_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            this.Close();
        }

    //***************************************************************************
        //fonction d'appel du form en system MVC
        private void sytemMVC(object Formhijo)
        {
            if (this.panelTableauDeBord.Controls.Count > 0)
                this.panelTableauDeBord.Controls.RemoveAt(0);

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelTableauDeBord.Controls.Add(fh);
            this.panelTableauDeBord.Tag = fh;
            fh.Show();

        }

    //***************************************************************************

    //***************************************************************************
        //boutons pour l'appel des forms
        private void buttonVente_Click(object sender, EventArgs e)
        {
            sytemMVC(new vente());
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            sytemMVC(new Stock());
        }

        private void buttonTransfert_Click(object sender, EventArgs e)
        {
            sytemMVC(new Transfert());
        }

        private void buttonPersonnel_Click(object sender, EventArgs e)
        {
            sytemMVC(new InventaireVente());
        }

        private void buttonAgence_Click(object sender, EventArgs e)
        {
            sytemMVC(new InventaireProduit());
        }

        private void buttonInventaire_Click(object sender, EventArgs e)
        {
            //sytemMVC(new Inventaire());

            panelSousMenu.Visible = true;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            panelSousMenu.Visible = false;
        }

        private void buttonAutreService_Click(object sender, EventArgs e)
        {
            sytemMVC(new AutreService());
        }

        private void Boutonfacture_Click(object sender, EventArgs e)
        {
            sytemMVC(new Facture());
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            sytemMVC(new RapportRetour());
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            sytemMVC(new TableauDeBordStock());
        }

        //***************************************************************************
        //***************************************************************************
        //icones personnel et agence

        private void button3_Click(object sender, EventArgs e)
        {
            Perso p = new Perso();
            p.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Agency ag = new Agency();
            ag.Show();
        }


        //*****************************************************************************************************
        //*****************************************************************************************************
        //creation de graph 

        


        public void situationVenteGraph()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_Produit, quantite FROM vente  ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetVente dsV = new DataSetVente();

                md.Fill(dsV, "vente");

                ReportDataSource source = new ReportDataSource("DataSetGraphVente", dsV.Tables[0]);

                this.reportViewerPannel.LocalReport.DataSources.Clear();
                this.reportViewerPannel.LocalReport.DataSources.Add(source);
                this.reportViewerPannel.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        /*
       private void buttonInventaireDateVenteGraph_Click(object sender, EventArgs e)
       {
           try
           {
               MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

               string requete = "SELECT nom_Produit, quantite FROM vente WHERE date_Vente BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "'  ";

               MySqlCommand afficher = new MySqlCommand(requete, connection);
               MySqlDataAdapter md = new MySqlDataAdapter(afficher);


               DataSetVente dsV = new DataSetVente();

               md.Fill(dsV, "vente");

               ReportDataSource source = new ReportDataSource("DataSetGraphVente", dsV.Tables[0]);

               this.reportViewerPannel.LocalReport.DataSources.Clear();
               this.reportViewerPannel.LocalReport.DataSources.Add(source);
               this.reportViewerPannel.RefreshReport();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }
*/


    }
}
