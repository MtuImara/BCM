using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BCM
{
    public partial class vente : Form
    {
        public vente()
        {
            InitializeComponent();


            //appels des fonctions
            afficherStock(""); //fonction d'affichage du stock
            afficherVente(""); //fonction d'affichage de la vente
        }




        //**********************************************************************************************
        //fonctions de masquage et demasquage du bouton ajout vente
        public void masquageBoutonAjoutVente()
        {
            if (checkBoxNouveau.Checked)
            {
                buttonAjoutVente.Visible = true;
            }
            else
            {
                buttonAjoutVente.Visible = false;
            }
        }

        //masquage et demasquage du bouton de la vente
        private void checkBoxNouveau_CheckedChanged(object sender, EventArgs e)
        {
            masquageBoutonAjoutVente();
        }



        //fonctions de masquage et demasquage du bouton ajout vente
        public void masquageBoutonRetour()
        {
            if (checkBoxRetour.Checked)
            {
                groupBoxV.Visible = true;
                groupBoxBack.Visible = true;
                buttonRetourProduit.Visible = true;
                dataGridVieVente.Visible = true;
            }
            else
            {
                groupBoxV.Visible = false;
                groupBoxBack.Visible = false;
                buttonRetourProduit.Visible = false;
                dataGridVieVente.Visible = false;
            }
        }


        //check le bouton d'ajout d'une back

        private void checkBoxRetour_CheckedChanged(object sender, EventArgs e)
        {
            masquageBoutonRetour();
        }



        //**********************************************************************************************
        //**********************************************************************************************
        //fonctins keyPress de verification des champs

        private void eventQteAVendre(object sender, KeyPressEventArgs e)
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

        private void eventNouveauPrix(object sender, KeyPressEventArgs e)
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

        private void eventPrixRetour(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxPrixProduitRetour.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

        private void eventQteRetourne(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxQuantiteRetourner.Text.IndexOf('.') != -1)
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

            textBoxNomProduitARemettre.Text = "";
            textBoxPrixProduitVendu.Text = "";
            textBoxPrixProduitRetour.Text = "";
            textBoxQuantiteSortie.Text = "";
            textBoxQuantiteRetourner.Text = "";
            textBoxIDStock.Text = "";

            textBoxRechercheProd.Text = "";

        }

        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            //appels des fonctions

            nettoyageForm(); //nettoyage du formulaire


            afficherStock(""); //fonction d'affichage du stock
            afficherVente(""); //fonction d'affichage de la vente
        }

        //**********************************************************************************************
        //**********************************************************************************************
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
            textBoxPrixVente.Text = dataGridViewStock.CurrentRow.Cells[3].Value.ToString();
            comboBoxPlace.Text = dataGridViewStock.CurrentRow.Cells[4].Value.ToString();

        }



        //fonction d'Affichage du Vente
        public void afficherVente(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM vente WHERE CONCAT(nom_Produit, date_Vente) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridVieVente.AllowUserToAddRows = false;
                dataGridVieVente.DataSource = dt;
                dataGridVieVente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                /*
                                //calcul du total
                                double total = 0;
                                for (int i = 0; i < dataGridVieVente.Rows.Count; i++)
                                {
                                    try
                                    {
                                        total += Convert.ToInt32(dataGridVieVente.Rows[i].Cells[3].Value);
                                    }
                                    catch (Exception)
                                    {

                                    }

                                    textBoxSommeTotale.Text = total.ToString();
                                }
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        //fonction evenement Remplissage TextBox A partir Du Datagriview vente
        private void SelectionVenteEvenement(object sender, EventArgs e)
        {
            textBoxIDVente.Text = dataGridVieVente.CurrentRow.Cells[0].Value.ToString();
            textBoxNomProduitARemettre.Text = dataGridVieVente.CurrentRow.Cells[1].Value.ToString();
            textBoxQuantiteSortie.Text = dataGridVieVente.CurrentRow.Cells[2].Value.ToString();
            textBoxPrixProduitVendu.Text = dataGridVieVente.CurrentRow.Cells[3].Value.ToString();
            textBoxPrixProduitRetour.Text = dataGridVieVente.CurrentRow.Cells[3].Value.ToString();
            dateRemise.Text = dataGridVieVente.CurrentRow.Cells[5].Value.ToString();

        }





        //**********************************************************************************************
        //**********************************************************************************************
        //fonction d'evenement provenant du textChange pour effectuer la recherche
        private void EvenementDeRechercheVenteStock(object sender, EventArgs e)
        {
            afficherStock(textBoxRechercheProd.Text); //fonction d'affichage du stock
            afficherVente(textBoxRechercheProd.Text); //fonction d'affichage de la vente
        }

        //**********************************************************************************************
        //**********************************************************************************************
        //fonction et bouton d'ajout d'une nouvelle vente

        public void fonctionAjoutNouvelleVente()
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO vente(nom_Produit, quantite, prix_vente,total, date_Vente , quantite_Retourne , prix_Retour) VALUES('" + textBoxNomProduit.Text + "','" + textBoxQuantiteAVendre.Text + "' , '" + textBoxPrixVente.Text + "' , '" + textBoxQuantiteAVendre.Text + "' * '" + textBoxPrixVente.Text + "' , '" + dateSortie.Text + "' , 0 , 0 )";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                MessageBox.Show("Vente effectuée avec Succès");

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

        private void buttonAjoutVente_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text != "" && textBoxQuantiteAVendre.Text != "" && textBoxPrixVente.Text != "")
            {
                if (double.Parse(textBoxQuantiteAVendre.Text) <= double.Parse(textBoxStock.Text))
                {

                    fonctionAjoutNouvelleVente();
                    miseAJourStock();


                    afficherStock(""); //fonction d'affichage du stock
                    afficherVente(""); //fonction d'affichage de la vente

                    nettoyageForm();//fonction de nettoyage

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
        //fonctions et bouton de retour du produit

        //fonction permettant le retour d'un produit dans le stock
        public void fonctionRetourProduitStock()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
            try
            {
                connection.Open();
                string requete = "UPDATE stock SET  quantite= quantite + '" + textBoxQuantiteRetourner.Text + "' , quantite_vendue= quantite_vendue - '" + textBoxQuantiteRetourner.Text + "'  WHERE nom_Produit='" + textBoxNomProduitARemettre.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                afficherStock(""); //affichage du stock
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //fonction permettant la mise a jour de la vente apres le retour d'un produit
        public void fonctionRetourModifiantVente()
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
            try
            {
                connection.Open();
                string requete = "UPDATE vente SET quantite = quantite - '" + textBoxQuantiteRetourner.Text + "' , total = ('" + textBoxQuantiteSortie.Text + "' - '" + textBoxQuantiteRetourner.Text + "') * '" + textBoxPrixProduitRetour.Text + "' , date_Vente = '" + dateRemise.Text + "', quantite_Retourne = quantite_Retourne + '" + textBoxQuantiteRetourner.Text + "' , prix_Retour= '" + textBoxPrixProduitRetour.Text + "' , date_Retour = '" + dateRemise.Text + "'  WHERE ID='" + textBoxIDVente.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("SUCCESS");

                afficherVente(""); //appel de la fonction affichage
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //bouton retour
        private void buttonRetourProduit_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduitARemettre.Text != "" && textBoxPrixProduitVendu.Text != "" && textBoxPrixProduitRetour.Text != "" && textBoxQuantiteSortie.Text != "" && textBoxQuantiteRetourner.Text != "")
            {
                if (double.Parse(textBoxQuantiteSortie.Text) >= double.Parse(textBoxQuantiteRetourner.Text))
                {
                    fonctionRetourModifiantVente();
                    fonctionRetourProduitStock();

                    textBoxQuantiteSortie.Text = "";
                    textBoxQuantiteRetourner.Text = "";
                    textBoxPrixProduitRetour.Text = "";
                    textBoxPrixProduitVendu.Text = "";
                    dateRemise.Text = "";
                    textBoxNomProduitARemettre.Text = "";
                    textBoxIDVente.Text = "";
                }
                else
                {
                    MessageBox.Show("La Quantité à retournée n'est pas correcte", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Veillez bien remplir votre formulaire", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
