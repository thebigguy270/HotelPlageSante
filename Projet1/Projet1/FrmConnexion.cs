using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet1
{
    public partial class FrmConnexion : Form
    {

        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (tbNomUtilisateur.Text == "")
            {
                MessageBox.Show("Vous n'avez pas tapé de nom d'utilisateur.");
                tbNomUtilisateur.Focus();
            }
            else if (tbMotDePasse.Text == "")
            {
                MessageBox.Show("Vous n'avez pas tapé de mot de passe.");
                tbMotDePasse.Focus();
            }
            else
            {
                SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                connection.Open();

                String requeteNomUtilisateur = "SELECT COUNT(*) FROM utilisateur WHERE nomUtilisateur = @nomUtilisateur;";
                SqlCommand commande = new SqlCommand(requeteNomUtilisateur, connection);
                SqlParameter paramNomUtilisateur = new SqlParameter("@nomUtilisateur", tbNomUtilisateur.Text);
                commande.Parameters.Add(paramNomUtilisateur);

                if ((int)commande.ExecuteScalar() == 0)
                {
                    connection.Close();

                    tbNomUtilisateur.Clear();
                    tbMotDePasse.Clear();
                    MessageBox.Show("Le nom d'utilisateur que vous avez tapé n'existe pas.");
                    tbNomUtilisateur.Focus();
                }
                else
                {
                    String requeteMotDePasse = "SELECT COUNT(*) FROM utilisateur WHERE nomUtilisateur = @nomUtilisateur and mdpUtilisateur = @mdpUtilisateur;";
                    commande.CommandText = requeteMotDePasse;
                    SqlParameter paramMotDePasse = new SqlParameter("@mdpUtilisateur", tbMotDePasse.Text);
                    commande.Parameters.Add(paramMotDePasse);

                    if ((int)commande.ExecuteScalar() == 0)
                    {
                        connection.Close();

                        tbMotDePasse.Clear();
                        MessageBox.Show("Le mot de passe que vous avez tapé ne correspond pas à votre nom d'utilisateur.");
                        tbMotDePasse.Focus();
                    }
                    else
                    {
                        String requeteTypeUtilisateur = "SELECT @typeUtilisateur = noTypeUtilisateur FROM utilisateur WHERE nomUtilisateur = @nomUtilisateur and mdpUtilisateur = @mdpUtilisateur;";
                        commande.CommandText = requeteTypeUtilisateur;
                        SqlParameter paramTypeUtilisateur = new SqlParameter("@typeUtilisateur", null);
                        paramTypeUtilisateur.Direction = ParameterDirection.Output;
                        paramTypeUtilisateur.SqlDbType = SqlDbType.Int;
                        commande.Parameters.Add(paramTypeUtilisateur);

                        commande.ExecuteNonQuery();

                        connection.Close();

                        if ((int)commande.Parameters["@typeUtilisateur"].Value == 1)
                        {
                            String noU = tbNomUtilisateur.Text;
                            String mdp = tbMotDePasse.Text;
                            tbNomUtilisateur.Clear();
                            tbMotDePasse.Clear();
                            tbNomUtilisateur.Focus();
                            this.Hide();
                            FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin();
                            frmMenuAdmin.noU = noU;
                            frmMenuAdmin.mdp = mdp;
                            frmMenuAdmin.frmConnexion = this;
                            frmMenuAdmin.ShowDialog();
                        }
                        else if ((int)commande.Parameters["@typeUtilisateur"].Value == 2)
                        {
                            tbNomUtilisateur.Clear();
                            tbMotDePasse.Clear();
                            tbNomUtilisateur.Focus();
                            this.Hide();
                            FrmMenuPrepose frmMenuAdmin = new FrmMenuPrepose();
                            
                            frmMenuAdmin.frmConnexion = this;
                            frmMenuAdmin.ShowDialog();
                        }
                    }
                }
            }
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
