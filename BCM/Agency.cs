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
    public partial class Agency : Form
    {
        public Agency()
        {
            InitializeComponent();

            afficherAgence(); //appel de la fonction d'affichage
        }


        //fonction de nettoyage
        public void nettoyageForm()
        {
            textBoxNomAgence.Text = "";
            textBoxID.Text = "";
            textBoxLocalisation.Text = "";
        }


        //fonction d'affichage
        public void afficherAgence()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM agency";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewAgence.AllowUserToAddRows = false;
                dataGridViewAgence.DataSource = dt;
                dataGridViewAgence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                //les outils pour compter les bres des produits
                int effectif = dataGridViewAgence.RowCount;
                double nombre = effectif;
                textBoxTotalAgence.Text = nombre.ToString();

                // textBoxEffectifProduit.Text = Convert.ToString(nombre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void eventRemplissageDataGridView(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewAgence.CurrentRow.Cells[0].Value.ToString();
            textBoxNomAgence.Text = dataGridViewAgence.CurrentRow.Cells[1].Value.ToString();
            textBoxLocalisation.Text = dataGridViewAgence.CurrentRow.Cells[2].Value.ToString();

        }


        private void buttonAjoutAgence_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

                if (textBoxNomAgence.Text != "" && textBoxLocalisation.Text != "")
                {
                    string requete = "INSERT INTO agency(name_Agency, localisation) VALUES('" + this.textBoxNomAgence.Text + "','" + this.textBoxLocalisation.Text + "')";
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
            nettoyageForm();
        }

        private void buttonModifierAgence_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");

            try
            {
                if (textBoxNomAgence.Text != "" && textBoxLocalisation.Text != "")
                {
                    connection.Open();
                    string requete = "UPDATE agency SET name_Agency='" + textBoxNomAgence.Text + "' , localisation='" + textBoxLocalisation.Text + "' WHERE ID='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("L'Agence a été bien modifiée");

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

                if (textBoxNomAgence.Text != "" && textBoxLocalisation.Text != "")
                {
                    connection.Open();
                    string requete = "DELETE FROM agency WHERE ID='" + textBoxID.Text + "' ";
                    MySqlCommand supprimer = new MySqlCommand(requete, connection);

                    supprimer.Connection = connection;
                    supprimer.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("L'Agence a été bien Supprimée");

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

        private void Agency_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
