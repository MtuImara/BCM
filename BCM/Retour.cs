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
    public partial class Retour : Form
    {
        public Retour()
        {
            InitializeComponent();

            //appels des fonctions
            afficherStock(""); //fonction d'affichage du stock

            afficherRetour(""); //fonction d'affichage du retour

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
        //fonction et bouton de nettoyage
        //fonction de nettoyage
        public void nettoyage()
        {
            textBoxStock.Text = "";
            textBoxNomProduit.Text = "";
            textBoxQuantiteATransfere.Text = "";
            textBoxPrix.Text = "";
            textBoxIDStock.Text = "";
            textBoxRechercheProd.Text = "";
            dateRetour.Text = "";
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
                string requete = "SELECT * FROM stock WHERE CONCAT(nom_Produit) LIKE '%" + rechercheValeur + "%'";
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
            textBoxPrix.Text = dataGridViewStock.CurrentRow.Cells[3].Value.ToString();

        }


        //fonction d'Affichage du retour
        public void afficherRetour(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM retour WHERE CONCAT(nom_Produit) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewRetour.AllowUserToAddRows = false;
                dataGridViewRetour.DataSource = dt;
                dataGridViewRetour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //fonction remplissage des textBox par le DataGridView retour
        private void evenementRemplissageDataGridRetour(object sender, EventArgs e)
        {
            textBoxIDRetour.Text = dataGridViewRetour.CurrentRow.Cells[0].Value.ToString();
            textBoxNomProduit.Text = dataGridViewRetour.CurrentRow.Cells[1].Value.ToString();
            textBoxQuantiteATransfere.Text = dataGridViewRetour.CurrentRow.Cells[2].Value.ToString();
            

        }


        //**********************************************************************************************
        //**********************************************************************************************
        //fonction d'evenement provenant du textChange pour effectuer la recherche
        private void EvenementDeRechercheRetourStock(object sender, EventArgs e)
        {
            afficherStock(textBoxRechercheProd.Text); //fonction d'affichage du stock
            afficherRetour(textBoxRechercheProd.Text); //fonction d'affichage du transfert
        }


        //**********************************************************************************************
        //**********************************************************************************************

        //fonction et bouton Ajout d'un transfert ainsi que la misea jour du stock
        public void ajoutRetour()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");




                string requete = "INSERT INTO retour(nom_Produit, quantite, prix, total, dateRetour) VALUES('" + textBoxNomProduit.Text + "','" + textBoxQuantiteATransfere.Text + "','" + textBoxPrix.Text + "' , '" + textBoxQuantiteATransfere.Text + "' * '" + textBoxPrix.Text + "' ,'" + dateRetour.Text + "')";
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


        //btn retour
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text != "" && textBoxStock.Text != "" && textBoxQuantiteATransfere.Text != "" && textBoxPrix.Text != "" && textBoxIDStock.Text != "")
            {
                if (double.Parse(textBoxQuantiteATransfere.Text) <= double.Parse(textBoxStock.Text))
                {

                    ajoutRetour();
                    miseAJourStock();

                    MessageBox.Show("Retour effectué avec Succès");

                    afficherStock(""); //fonction d'affichage du stock
                    afficherRetour(""); //fonction d'affichage de le retour



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
        //fonctions permettant le retour d'un produit dans le stock apres suppression d'un retour ainsi que le bouton de suppression
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


        //fonction de suppression retour
        public void fonctionSuppressionRetour()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
            try
            {
                connection.Open();
                string requete = "DELETE FROM retour WHERE ID='" + textBoxIDRetour.Text + "' ";
                MySqlCommand supprimer = new MySqlCommand(requete, connection);

                supprimer.Connection = connection;
                supprimer.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Le Retour a été bien Supprimé");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //btn suppression retour
        private void buttonSuppressionProduitRetourne_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text != "" && textBoxQuantiteATransfere.Text != "" && textBoxIDRetour.Text != "")
            {
                fonctionRetourProduitStock();
                fonctionSuppressionRetour();


                afficherStock(""); //fonction d'affichage du stock
                afficherRetour(""); //fonction d'affichage du retour



                nettoyage(); //fonction de nottoyage du formulaire

            }
            else
            {
                MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
