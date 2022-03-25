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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();


            afficherStock("");//fonction d'affichage
        }

        //***************************************************************************************
        //fonction et bouton de nettoyage 
        public void nettoyerForm()
        {

            textBoxPrixAchat.Text = "";
            textBoxQuantite.Text = "";
            comboBoxPlace.Text = "";
            textBoxNomProd.Text = "";
            textBoxPrixAchat.Text = "";
            textBoxID.Text = "";
            textBoxRechercheProd.Text = "";
            textBoxStockInitial.Text = "";
            textBoxQteAcheter.Text = "";
            textBoxTotalProduitAModifier.Text = "";
            comboBoxPlaceAModifier.Text = "";
            textBoxNomProduitAModifier.Text = "";
            textBoxPrixProduitAModifier.Text = "";
            textBoxQuantiteAModifier.Text = "";
        }
        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyerForm();
        }

        //***************************************************************************************
        private void groupBoxStock_Enter(object sender, EventArgs e)
        {

        }


//***************************************************************************************
        //masquez un champ avec un checkBox

        public void fonctionMasquerChamp()
        {
            if (checkBoxNouveau.Checked)
            {
                buttonAjout.Visible = true;
            }
            else
            {
                buttonAjout.Visible = false;
            }
        }

        public void masquerBoutonModifier()
        {

            if (checkBoxModifier.Checked)
            {
                buttonModifier.Visible = true;
            }
            else
            {
                buttonModifier.Visible = false;
            }
        }

        public void masquerBoutonAdding()
        {
            if (checkBoxAdding.Checked)
            {
                buttonAdding.Visible = true;
            }
            else
            {
                buttonAdding.Visible = false;
            }
        }

        public void masquerBoutonSupprimer()
        {

            if (checkBoxSuppression.Checked)
            {
                buttonSupprimer.Visible = true;
            }
            else
            {
                buttonSupprimer.Visible = false;
            }
        }


        public void masquerTousBoutons()
        {
            if (checkBoxVoirTousBouton.Checked)
            {
                buttonAjout.Visible = true;
                buttonModifier.Visible = true;
                buttonAdding.Visible = true;
                buttonSupprimer.Visible = true;
            }
            else
            {
                buttonAjout.Visible = false;
                buttonModifier.Visible = false;
                buttonAdding.Visible = false;
                buttonSupprimer.Visible = false;
            }
        }

        //appel des fonctions des masquage


        private void checkBoxNouveau_CheckedChanged_1(object sender, EventArgs e)
        {
            fonctionMasquerChamp();
        }

        private void checkBoxModifier_CheckedChanged_1(object sender, EventArgs e)
        {
            masquerBoutonModifier();
        }

        private void checkBoxAdding_CheckedChanged_1(object sender, EventArgs e)
        {
            masquerBoutonAdding();
        }

        private void checkBoxSuppression_CheckedChanged_1(object sender, EventArgs e)
        {
            masquerBoutonSupprimer();
        }

        private void checkBoxVoirTousBouton_CheckedChanged_1(object sender, EventArgs e)
        {
            masquerTousBoutons();
        }



        //***************************************************************************************


        //***************************************************************************************
        //fonction et bouton d'ajout du nouveau produit ainsi que le statistique des produits entrés journalierement

        public void fonctionAjoutNouveauProduit()
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

               
                    string requete = "INSERT INTO stock(nom_Produit, quantite, prix, place,quantite_vendue,total_Approvisionnement) VALUES('" + this.textBoxNomProd.Text + "','" + this.textBoxQuantite.Text + "','" + this.textBoxPrixAchat.Text + "','" + this.comboBoxPlace.Text + "', 0 , '" + this.textBoxQuantite.Text + "' )";
                    MySqlCommand inserer = new MySqlCommand(requete, connection);
                    MySqlDataReader lire;

                    connection.Open();
                    lire = inserer.ExecuteReader();

                    MessageBox.Show("Nouveau Produit bien enregistré dans le stock");

                    while (lire.Read())
                    {
                        connection.Close();
                    }

                    //nettoyerForm(); //nettoyagedu formulaire
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Votre Base de donnée n'est pas connée à l'application", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }



        public void produitEntreJournalierement()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                
                    string requete = "INSERT INTO produit_recu(nom_Produit, quantite, prix) VALUES('" + this.textBoxNomProd.Text + "','" + this.textBoxQuantite.Text + "','" + this.textBoxPrixAchat.Text + "')";
                    MySqlCommand inserer = new MySqlCommand(requete, connection);
                    MySqlDataReader lire;

                    connection.Open();
                    lire = inserer.ExecuteReader();

                    //MessageBox.Show("Nouveau Produit bien enregistré dans le stock");

                    while (lire.Read())
                    {
                        connection.Close();
                    }

                   

            }
            catch (Exception ex)
            {
                MessageBox.Show("Votre Base de donnée n'est pas connée à l'application", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (textBoxNomProd.Text != "" && textBoxQuantite.Text != "" && textBoxPrixAchat.Text != "" && comboBoxPlace.Text != "")
            {
                produitEntreJournalierement();
                fonctionAjoutNouveauProduit();


                nettoyerForm(); //nettoyagedu formulaire
                afficherStock(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

         }
        //***************************************************************************************

        //***************************************************************************************
        //fonction d'affichage
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

/*
                //les outils pour compter les bres des produits
                int effectif = dataGridViewStock.RowCount;
                double nombre = effectif;
                textBoxEffectifProduit.Text = nombre.ToString();

                // textBoxEffectifProduit.Text = Convert.ToString(nombre);
*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //Evenement de selection du dataGrideView
        private void SelectionEvenement(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewStock.CurrentRow.Cells[0].Value.ToString();
            textBoxNomProduitAModifier.Text = dataGridViewStock.CurrentRow.Cells[1].Value.ToString();
            textBoxStockInitial.Text = dataGridViewStock.CurrentRow.Cells[2].Value.ToString();
            textBoxPrixProduitAModifier.Text = dataGridViewStock.CurrentRow.Cells[3].Value.ToString();
            comboBoxPlaceAModifier.Text = dataGridViewStock.CurrentRow.Cells[4].Value.ToString();
            textBoxQteAcheter.Text = dataGridViewStock.CurrentRow.Cells[5].Value.ToString();
            textBoxTotalProduitAModifier.Text = dataGridViewStock.CurrentRow.Cells[6].Value.ToString();


        }


        //***************************************************************************************

        //***************************************************************************************
        //fonction d'evenement provenant du textChange pour effectuer la recherche
        private void EvenementDeRecherche(object sender, EventArgs e)
        {
            afficherStock(textBoxRechercheProd.Text);
        }


        //***************************************************************************************

        //***************************************************************************************
        //fonction et bouton de modification
        public void fonctionModification()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE stock SET nom_Produit ='" + textBoxNomProduitAModifier.Text + "' , quantite='" + textBoxStockInitial.Text + "' , prix='" + textBoxPrixProduitAModifier.Text + "', place='" + comboBoxPlaceAModifier.Text + "', quantite_vendue='" + textBoxQteAcheter.Text + "', total_Approvisionnement='" + textBoxTotalProduitAModifier.Text + "'  WHERE ID='" + textBoxID.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Le produit a été bien Modifié");

                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxStockInitial.Text != ""  && comboBoxPlaceAModifier.Text != "" && textBoxNomProduitAModifier.Text != "" && textBoxPrixProduitAModifier.Text != "")
            {

                fonctionModification(); //fonction pour modifier

                nettoyerForm(); //nettoyagedu formulaire
                afficherStock(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //***************************************************************************************

        //***************************************************************************************
        //fonction et bouton de suppression
        public void fonctionSuppression()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
            try
            {
                    connection.Open();
                    string requete = "DELETE FROM stock WHERE ID='" + textBoxID.Text + "' ";
                    MySqlCommand supprimer = new MySqlCommand(requete, connection);

                    supprimer.Connection = connection;
                    supprimer.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Le produit a été bien Supprimé");

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxStockInitial.Text != "" && comboBoxPlaceAModifier.Text != "" && textBoxNomProduitAModifier.Text != "" && textBoxPrixProduitAModifier.Text != "")
            {

                fonctionSuppression(); //fonction pour supprimer

                nettoyerForm(); //nettoyagedu formulaire
                afficherStock(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //***************************************************************************************

        //***************************************************************************************
        //fonction et bouton d'ajouter la quantité d'un produit qui existe et fonction d'ajout des quantités des produit journalierement
        public void fonctionAdding()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE stock SET  quantite  = quantite + '" + textBoxQuantiteAModifier.Text + "' , total_Approvisionnement= total_Approvisionnement + '" + textBoxQuantiteAModifier.Text + "' WHERE ID='" + textBoxID.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("La Quantité a été bien Ajoutée");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //fonction d'ajout des quantités des produit journalierement
        public void produitQteEntreJournalierement()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");


                string requete = "INSERT INTO produit_recu(nom_Produit, quantite, prix) VALUES('" + this.textBoxNomProduitAModifier.Text + "','" + this.textBoxQuantiteAModifier.Text + "','" + this.textBoxPrixProduitAModifier.Text + "')";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                
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

        private void buttonAdding_Click(object sender, EventArgs e)
        {
            if (textBoxStockInitial.Text != "" && textBoxQuantiteAModifier.Text != "" && textBoxNomProduitAModifier.Text != "" && textBoxPrixProduitAModifier.Text != "")
            {

                fonctionAdding(); //fonction pour ajouter la nouvelle quantité
                produitQteEntreJournalierement(); //fonction d'ajout des quantités des produit journalierement

                nettoyerForm(); //nettoyagedu formulaire
                afficherStock(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //***************************************************************************************

        //***************************************************************************************
        //Fonctins de conversion des champs de string en double et leur verification

        private void textBoxQuantiteAModifier_TextChanged(object sender, EventArgs e)
        {
           // addingQte();
        }

        private void eventVerifNewQte(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if(qte == 46 && textBoxQuantiteAModifier.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if(!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }


        }

        private void eventResteStock(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxStockInitial.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

        private void eventPrixAModif(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxPrixProduitAModifier.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

        private void eventQte(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxQuantite.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

        private void eventPrixProduit(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxPrixAchat.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }


        //****************************************************************************************

    }
}
