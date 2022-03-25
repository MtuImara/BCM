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

namespace BCM
{
    public partial class Perso : Form
    {
        public Perso()
        {
            InitializeComponent();

            //appel des fonctions
            nettoyageForm();//nettoyage

            afficherPersonnel();//affichage
        }


        //fonction de nettoyage
        public void nettoyageForm()
        {
            textBoxNomPerso.Text = "";
            textBoxMotPass.Text = "";
        }
        //fonction d'affichage
        public void afficherPersonnel()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM personnel";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewPersonnel.AllowUserToAddRows = false;
                dataGridViewPersonnel.DataSource = dt;
                dataGridViewPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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


        private void eventRemplissageTextBox(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewPersonnel.CurrentRow.Cells[0].Value.ToString();
            textBoxNomPerso.Text = dataGridViewPersonnel.CurrentRow.Cells[1].Value.ToString();
            textBoxMotPass.Text = dataGridViewPersonnel.CurrentRow.Cells[2].Value.ToString();

        }


        private void buttonAjoutPersonnel_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                if (textBoxNomPerso.Text != "" && textBoxMotPass.Text != "")
                {
                    string requete = "INSERT INTO personnel(nom, passWord) VALUES('" + this.textBoxNomPerso.Text + "','" + this.textBoxMotPass.Text + "')";
                    MySqlCommand inserer = new MySqlCommand(requete, connection);
                    MySqlDataReader lire;

                    connection.Open();
                    lire = inserer.ExecuteReader();

                    MessageBox.Show("Success");

                    while (lire.Read())
                    {
                        connection.Close();
                    }

                    nettoyageForm(); //nettoyagedu formulaire
                    afficherPersonnel(); //affichage de la fonction d'affichage
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir votre formulaire", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
               // MessageBox.Show("Problem of Connection to the Database", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        //refresh
        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyageForm();
        }

        private void buttonModifierPerso_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {
                if (textBoxNomPerso.Text != "" && textBoxMotPass.Text != "")
                {
                    connection.Open();
                    string requete = "UPDATE personnel SET nom='" + textBoxNomPerso.Text + "' , passWord='" + textBoxMotPass.Text + "' WHERE ID='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("La personne a été bien modifiée");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherPersonnel(); //affichage de la fonction d'affichage
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir votre formulaire", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSupprimerPerso_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {

                if (textBoxNomPerso.Text != "" && textBoxMotPass.Text != "")
                {
                    connection.Open();
                    string requete = "DELETE FROM personnel WHERE ID='" + textBoxID.Text + "' ";
                    MySqlCommand supprimer = new MySqlCommand(requete, connection);

                    supprimer.Connection = connection;
                    supprimer.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("La personne a été bien supprimée");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherPersonnel(); //affichage de la fonction d'affichage
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir votre formulaire", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
