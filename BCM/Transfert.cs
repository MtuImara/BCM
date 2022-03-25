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

namespace BCM
{
    public partial class Transfert : Form
    {
        public Transfert()
        {
            InitializeComponent();

            //appels des fonctions
            afficherStock(""); //fonction d'affichage du stock
            afficherTransfert(""); //fonction d'affichage du transfert

            //fonction combo box
            afficherAgenceComboBoxEtudiant();

        }


        //**********************************************************************************************
        //**********************************************************************************************
        //fonctins keyPress de verification des champs
        private void eventQuantite(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxQuantiteATransfere.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }


        //*********************************************************************************
        //*********************************************************************************
        //fonction et bouton de nettoyage
        //fonction de nettoyage
        public void nettoyage()
        {
            textBoxStock.Text = "";
            textBoxNomProduit.Text = "";
            textBoxQuantiteATransfere.Text = "";
            comboBoxDestination.Text = "";
            textBoxIDStock.Text = "";
            textBoxRechercheProd.Text = "";
            dateTransfert.Text = "";
        }
        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyage();
        }

        //*********************************************************************************
        //*********************************************************************************
        //fonctions d'affichage
        public void afficherStock(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM stock WHERE CONCAT(nom_Produit, place) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewStock.AllowUserToAddRows = false;
                dataGridViewStock.DataSource = dt;
                dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //fonction remplissage des textBox par le DataGridView Stock
        private void evenementRemplissageDonneeStockDataGrid(object sender, EventArgs e)
        {
            textBoxIDStock.Text = dataGridViewStock.CurrentRow.Cells[0].Value.ToString();
            textBoxNomProduit.Text = dataGridViewStock.CurrentRow.Cells[1].Value.ToString();
            textBoxStock.Text = dataGridViewStock.CurrentRow.Cells[2].Value.ToString();

        }


        //fonction d'Affichage du transfert
        public void afficherTransfert(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM transfert WHERE CONCAT(nom_Produit, destination, date_Transfert) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewTransfert.AllowUserToAddRows = false;
                dataGridViewTransfert.DataSource = dt;
                dataGridViewTransfert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //fonction remplissage des textBox par le DataGridView Transfert
        private void evenementRemplissageDataGridTransfert(object sender, EventArgs e)
        {
            textBoxIDTrensfert.Text = dataGridViewTransfert.CurrentRow.Cells[0].Value.ToString();
            textBoxNomProduit.Text = dataGridViewTransfert.CurrentRow.Cells[1].Value.ToString();
            textBoxQuantiteATransfere.Text = dataGridViewTransfert.CurrentRow.Cells[2].Value.ToString();
            comboBoxDestination.Text = dataGridViewTransfert.CurrentRow.Cells[3].Value.ToString();
            dateTransfert.Text = dataGridViewTransfert.CurrentRow.Cells[4].Value.ToString();

        }



        //**********************************************************************************************
        //**********************************************************************************************
        //fonction d'evenement provenant du textChange pour effectuer la recherche
        private void EvenementDeRechercheTransfertStock(object sender, EventArgs e)
        {
            afficherStock(textBoxRechercheProd.Text); //fonction d'affichage du stock
            afficherTransfert(textBoxRechercheProd.Text); //fonction d'affichage du transfert
        }



        //**********************************************************************************************
        //**********************************************************************************************

        //fonction et bouton Ajout d'un transfert ainsi que la misea jour du stock
        public void ajoutTransfert()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");




                string requete = "INSERT INTO transfert(nom_Produit, quantite_Transfere, destination, date_Transfert) VALUES('" + textBoxNomProduit.Text + "','" + textBoxQuantiteATransfere.Text + "','" + comboBoxDestination.Text + "','" + dateTransfert.Text + "')";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();


                while (lire.Read())
                {
                    connection.Close();
                }


                //afficherTransfert(""); //appel de la fonction affichage


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //fonction mise A Jour du Stock
        public void miseAJourStock()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE stock SET  quantite  = quantite - '" + textBoxQuantiteATransfere.Text + "' WHERE ID='" + textBoxIDStock.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTransfert_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text != "" && textBoxStock.Text != "" && textBoxQuantiteATransfere.Text != "" && comboBoxDestination.Text != "" && textBoxIDStock.Text != "")
            {
                if (double.Parse(textBoxQuantiteATransfere.Text) <= double.Parse(textBoxStock.Text))
                {

                    ajoutTransfert();
                    miseAJourStock();

                    MessageBox.Show("Transfert effectué avec Succès");

                    afficherStock(""); //fonction d'affichage du stock
                    afficherTransfert(""); //fonction d'affichage du transfert



                    nettoyage(); //fonction de nottoyage du formulaire

                }
                else
                {
                    MessageBox.Show("La Quantité Stockée n'est pas assez suffisante ou bien est épuisé", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //**********************************************************************************************
        //**********************************************************************************************
        //fonctions permettant le retour d'un produit dans le stock apres suppression d'un transfert ainsi que le bouton de suppression
        public void fonctionRetourProduitStock()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE stock SET  quantite  = quantite + '" + textBoxQuantiteATransfere.Text + "' WHERE nom_Produit = '" + textBoxNomProduit.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //fonction de suppression transfert
        public void fonctionSuppressionTransfert()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
            try
            {
                connection.Open();
                string requete = "DELETE FROM transfert WHERE ID='" + textBoxIDTrensfert.Text + "' ";
                MySqlCommand supprimer = new MySqlCommand(requete, connection);

                supprimer.Connection = connection;
                supprimer.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Le Transfert a été bien Supprimé");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSuppressionProduitTransferer_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text != "" && textBoxQuantiteATransfere.Text != "" && comboBoxDestination.Text != "" && textBoxIDTrensfert.Text != "")
            {
                fonctionRetourProduitStock();
                fonctionSuppressionTransfert();


                afficherStock(""); //fonction d'affichage du stock
                afficherTransfert(""); //fonction d'affichage de la vente



                nettoyage(); //fonction de nottoyage du formulaire

            }
            else
            {
                MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //**********************************************************************************************
        //**********************************************************************************************
        //fonction permettant d'afficher les noms d'agences dans le combobox
        public void afficherAgenceComboBoxEtudiant()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM agency";

                con.Open();
                MySqlCommand perso = new MySqlCommand(personnel, con);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    comboBoxDestination.Items.Add(lire.GetString("name_Agency"));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        //********************************************************************************************************
        //********************************************************************************************************
        //bouton retour de produit en expiration
        private void button1_Click(object sender, EventArgs e)
        {
            Retour r = new Retour();
            r.Show();
        }
    }
}
