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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

            afficherAgence();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        //fonction de nettoyage
        public void nettoyageForm()
        {
            textBoxNomClient.Text = "";
            textBoxID.Text = "";
            textBoxLocalisation.Text = "";
            textBoxPhone.Text = "";
        }


        //fonction d'affichage
        public void afficherAgence()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM client";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewClient.AllowUserToAddRows = false;
                dataGridViewClient.DataSource = dt;
                dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                //les outils pour compter les bres des produits
                int effectif = dataGridViewClient.RowCount;
                double nombre = effectif;
                textBoxTotalClient.Text = nombre.ToString();

                // textBoxEffectifProduit.Text = Convert.ToString(nombre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void eventRemplissageDataGridView(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewClient.CurrentRow.Cells[0].Value.ToString();
            textBoxNomClient.Text = dataGridViewClient.CurrentRow.Cells[1].Value.ToString();
            textBoxLocalisation.Text = dataGridViewClient.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewClient.CurrentRow.Cells[3].Value.ToString();


        }

        private void buttonAjoutAgence_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                if (textBoxNomClient.Text != "")
                {
                    string requete = "INSERT INTO client(nom_Client, localisation,phone) VALUES('" + this.textBoxNomClient.Text + "','" + this.textBoxLocalisation.Text + "','" + this.textBoxPhone.Text + "')";
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
                    afficherAgence(); //affichage de la fonction d'affichage
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Problem of Connection to the Database", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyageForm(); //nettoyagedu formulaire
            afficherAgence(); //affichage de la fonction d'affichage
        }

        private void buttonModifierAgence_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {
                if (textBoxNomClient.Text != "" )
                {
                    connection.Open();
                    string requete = "UPDATE client SET nom_Client='" + textBoxNomClient.Text + "' , localisation='" + textBoxLocalisation.Text + "' , phone='" + textBoxPhone.Text + "' WHERE ID='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Le Client a été bien modifié");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherAgence(); //affichage de la fonction d'affichage
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSupprimerAgence_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {

                if (textBoxNomClient.Text != "" )
                {
                    connection.Open();
                    string requete = "DELETE FROM client WHERE ID='" + textBoxID.Text + "' ";
                    MySqlCommand supprimer = new MySqlCommand(requete, connection);

                    supprimer.Connection = connection;
                    supprimer.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Le Client a été bien Supprimée");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherAgence(); //affichage de la fonction d'affichage
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
