using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCM
{
    public partial class AutreService : Form
    {
        public AutreService()
        {
            InitializeComponent();


            //appels des fonctions
            afficherAgenceComboBoxEtudiant();//fonction affiche client comboBox
                        
            afficherStock(""); //fonction d'affichage du stock

            afficherClientGros(""); //fonction d'affichage du client de gros

        }

        private void AutreService_Load(object sender, EventArgs e)
        {

        }



        //bouton ajout client
        private void buttonAjoutClient_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Show();
        }

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

        //**********************************************************************************************
        //**********************************************************************************************
        //fonction et bouton de Nettoyage
        public void nettoyageForm()
        {
            textBoxStock.Text = "";
            comboBoxPlace.Text = "";
            textBoxPrixAchat.Text = "";
            textBoxNomProduit.Text = "";
            textBoxQuantiteAVendre.Text = "";
            textBoxPrixVente.Text = "";
            textBoxIDStock.Text = "";

            textBoxRechercheProd.Text = "";
            comboBoxNomClient.Text = "";
            comboBoxCreditCash.Text = "";
            textBoxIdClientGros.Text = "";

        }

        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyageForm();
        }


        //***************************************************************************************

        //***************************************************************************************
        //Fonctins de conversion des champs de string en doubleet leur verification

        private void eventQtV(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxQuantiteAVendre.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

        private void eventPrix(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxPrixVente.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

        //**********************************************************************************************
        //**********************************************************************************************
        //fonction d'affichage
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

        //Evenement de selection du dataGrideView Stock
        private void SelectionStockEvenement(object sender, EventArgs e)
        {
            textBoxIDStock.Text = dataGridViewStock.CurrentRow.Cells[0].Value.ToString();
            textBoxNomProduit.Text = dataGridViewStock.CurrentRow.Cells[1].Value.ToString();
            textBoxStock.Text = dataGridViewStock.CurrentRow.Cells[2].Value.ToString();
            textBoxPrixAchat.Text = dataGridViewStock.CurrentRow.Cells[3].Value.ToString();
            comboBoxPlace.Text = dataGridViewStock.CurrentRow.Cells[4].Value.ToString();

        }


        public void afficherClientGros(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM client_gros WHERE CONCAT(nom_Produit, nom_client, situation) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewClientGros.AllowUserToAddRows = false;
                dataGridViewClientGros.DataSource = dt;
                dataGridViewClientGros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //fonction evenement Remplissage TextBox A partir Du Datagriview vente
        private void eventAfficheClientGros(object sender, EventArgs e)
        {
            textBoxIdClientGros.Text = dataGridViewClientGros.CurrentRow.Cells[0].Value.ToString();
            textBoxNomProduit.Text = dataGridViewClientGros.CurrentRow.Cells[1].Value.ToString();
            textBoxQuantiteAVendre.Text = dataGridViewClientGros.CurrentRow.Cells[2].Value.ToString();
            textBoxPrixVente.Text = dataGridViewStock.CurrentRow.Cells[3].Value.ToString();
            comboBoxNomClient.Text = dataGridViewClientGros.CurrentRow.Cells[5].Value.ToString();
            comboBoxCreditCash.Text = dataGridViewClientGros.CurrentRow.Cells[6].Value.ToString();

        }


        //**********************************************************************************************
        //**********************************************************************************************
        //fonction d'evenement provenant du textChange pour effectuer la recherche
        private void eventRechercheDonnee(object sender, EventArgs e)
        {
            afficherStock(textBoxRechercheProd.Text); //fonction d'affichage du stock

            afficherClientGros(textBoxRechercheProd.Text); //fonction d'affichage du client de gros

        }

        //**********************************************************************************************
        //**********************************************************************************************
        //fonction et bouton vente avec credit

        public void venteAvecCredit()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO client_gros(nom_Produit, quantite, prix,total, nom_client , situation , date_sortie) VALUES('" + textBoxNomProduit.Text + "','" + textBoxQuantiteAVendre.Text + "' , '" + textBoxPrixVente.Text + "' , '" + textBoxQuantiteAVendre.Text + "' * '" + textBoxPrixVente.Text + "' ,'" + comboBoxNomClient.Text + "' , 'Dette' ,'" + dateSortie.Text + "' )";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                MessageBox.Show("Crédit accordée avec Succès");

                while (lire.Read())
                {
                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //fonction mise A Jour du Stock
        public void miseAJourStock()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE stock SET  quantite  = quantite - '" + textBoxQuantiteAVendre.Text + "', quantite_vendue = quantite_vendue + '" + textBoxQuantiteAVendre.Text + "' WHERE ID='" + textBoxIDStock.Text + "'";
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


        //bouton Ajout Credit
        private void buttonVenteAvecCredit_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text != "" && textBoxQuantiteAVendre.Text != "" && textBoxPrixVente.Text != "" && comboBoxNomClient.Text !="" && comboBoxCreditCash.Text !="")
            {
                    if (double.Parse(textBoxQuantiteAVendre.Text) <= double.Parse(textBoxStock.Text))
                    {

                        venteAvecCredit();
                        miseAJourStock();


                        afficherStock(""); //fonction d'affichage du stock
                        afficherClientGros(""); //fonction d'affichage de la vente

                        nettoyageForm(); //fonction de nettoyage

                    }
                    else
                    {
                        MessageBox.Show("La Quantité Stockée n'est pas assez suffisante ou bien c'est épuisé", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                                
            }
            else
            {
                MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        //**********************************************************************************************
        //**********************************************************************************************
        //fonction et bouton vente avec cash

        public void venteAvecCash()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO client_gros(nom_Produit, quantite, prix,total, nom_client , situation , date_sortie) VALUES('" + textBoxNomProduit.Text + "','" + textBoxQuantiteAVendre.Text + "' , '" + textBoxPrixVente.Text + "' , '" + textBoxQuantiteAVendre.Text + "' * '" + textBoxPrixVente.Text + "' ,'" + comboBoxNomClient.Text + "' , 'Cash' ,'" + dateSortie.Text + "' )";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                MessageBox.Show("Vente Effectuée avec Succès");

                while (lire.Read())
                {
                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //fonction d'ajout d'une nouvelle vente

        public void fonctionAjoutNouvelleVente()
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO vente(nom_Produit, quantite, prix_vente,total, date_Vente , quantite_Retourne , prix_Retour,nom_client) VALUES('" + textBoxNomProduit.Text + "','" + textBoxQuantiteAVendre.Text + "' , '" + textBoxPrixVente.Text + "' , '" + textBoxQuantiteAVendre.Text + "' * '" + textBoxPrixVente.Text + "' , '" + dateSortie.Text + "' , 0 , 0 , '" + comboBoxNomClient.Text + "' )";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                //MessageBox.Show("Vente effectuée avec Succès");

                while (lire.Read())
                {
                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //bouton ajout vente avec cash
        private void buttonAjoutVenteCash_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text != "" && textBoxQuantiteAVendre.Text != "" && textBoxPrixVente.Text != "" && comboBoxNomClient.Text != "" && comboBoxCreditCash.Text != "")
            {
                if (double.Parse(textBoxQuantiteAVendre.Text) <= double.Parse(textBoxStock.Text))
                {

                    venteAvecCash();
                    fonctionAjoutNouvelleVente();
                    miseAJourStock();


                    afficherStock(""); //fonction d'affichage du stock
                    afficherClientGros(""); //fonction d'affichage de la vente

                    nettoyageForm(); //fonction de nettoyage

                }
                else
                {
                    MessageBox.Show("La Quantité Stockée n'est pas assez suffisante ou bien c'est épuisé", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //**********************************************************************************************
        //**********************************************************************************************
        //fonction et bouton vente avec remboursement
        
        public void fonctioCreditRembourse()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {
                
                    connection.Open();
                    string requete = "UPDATE client_gros SET situation ='Remboursement' , date_Remboursement = '" + dateSortie.Text + "'  WHERE ID='" + textBoxIdClientGros.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("La dette a été Remboursée avec Succès");

                  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //bouton remboursement
        private void buttonRemboursementCredit_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text != "" && textBoxQuantiteAVendre.Text != "" && textBoxPrixVente.Text != "" && comboBoxNomClient.Text != "" && comboBoxCreditCash.Text != "")
            {
               

                    fonctioCreditRembourse();
                    fonctionAjoutNouvelleVente();
                    miseAJourStock();


                    afficherStock(""); //fonction d'affichage du stock
                    afficherClientGros(""); //fonction d'affichage de la vente

                    nettoyageForm(); //fonction de nettoyage

               
            }
            else
            {
                MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        //**********************************************************************************************
        //**********************************************************************************************
        // bouton de suppression avec remboursement


        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {

                if (textBoxNomProduit.Text != "" && textBoxQuantiteAVendre.Text != "" && textBoxIdClientGros.Text != "" && comboBoxNomClient.Text != "" && comboBoxCreditCash.Text != "")
                {
                    connection.Open();
                    string requete = "DELETE FROM client_gros WHERE ID='" + textBoxIdClientGros.Text + "' ";
                    MySqlCommand supprimer = new MySqlCommand(requete, connection);

                    supprimer.Connection = connection;
                    supprimer.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("La vente a été bien supprimée");

                    afficherStock(""); //fonction d'affichage du stock
                    afficherClientGros(""); //fonction d'affichage de la vente

                    nettoyageForm(); //fonction de nettoyage
                }
                else
                {
                    MessageBox.Show("Veillez bien selectionner le champs à supprimer dans votre formulaire", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
