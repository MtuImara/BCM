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


using System.Runtime.InteropServices; //bibliotheque pour faciliter le deplacement du formulaire

namespace BCM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //code mere pour faciliter le deplacement du formulaire
        //***************************************************************************************************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hmdw, int wmsg, int wparam, int lparam);
        //***************************************************************************************************

        //fonction evenementielle permettant de deplacer notre formulaire
        private void eventDeDeplacementForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //bouton pour quitter l'application
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult quitter;
            quitter = MessageBox.Show("Voulez-vous fermer cette Application?", "Alert!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //bouton login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNom.Text != "" && textBoxPassword.Text != "")
                {

                    MySqlConnection con = new MySqlConnection("database=moderne; server=localhost; user id=root; pwd=");



                        string query = "SELECT * FROM personnel WHERE nom='" + textBoxNom.Text.Trim() + "' AND passWord='" + textBoxPassword.Text.Trim() + "'";

                        DataTable dt = new DataTable();
                        MySqlDataAdapter md = new MySqlDataAdapter(query, con);
                        md.Fill(dt);

                    
                
                        if (dt.Rows.Count == 1)
                        {


                            Accueil a = new Accueil();

                            a.Show();

                            textBoxNom.Text = "";
                            textBoxPassword.Text = "";
                        }
                        else
                        {


                            MessageBox.Show("Vos données ne sont pas Correctes!! Veillez Réessayer", "Alert",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                else
                {


                    MessageBox.Show("Veillez bien remplir votre formulaire", "Alert",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Pas de connexion!!! Veillez Vérifier si la Base de Données est alumée", "Alert",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //Accueil ac = new Accueil();
            //ac.Show();
        }
    }
}
