using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class frmAjouterUtilisateur : Form
    {
        public BD5B6TP1_BrodeurLussierDataSet.utilisateurRow unUtilisateur;
        public frmAjouterUtilisateur()
        {
            InitializeComponent();
        }

        

        private void frmAjouterUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.typeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.typeUtilisateur);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            String strNomU = tbNomUtilisateur.Text;
            String strMDP = tbMDP.Text;
            String strType = cbTypeUtilisateur.SelectedValue.ToString();
            Boolean boolUtil = false;
            Boolean boolMDP = false;
            int compte = 0;
            //Uniqueté de l'utilisateur
            SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
            connection.Open();
            
            String requeteSQL1 = "SELECT COUNT(*) from utilisateur WHERE nomUtilisateur='" + strNomU + "'"; ;
            SqlCommand maCommande1 = new SqlCommand(requeteSQL1, connection);
            SqlParameter paramNomU = new SqlParameter("@noU", strNomU);
            paramNomU.SqlDbType = SqlDbType.VarChar;
            paramNomU.Direction = ParameterDirection.Input;
            maCommande1.Parameters.Add(paramNomU);
            compte = (int)maCommande1.ExecuteScalar();
            connection.Close();
            if (compte > 0)
            {
                errMessage.SetError(tbNomUtilisateur, "Un utilisateur a déja ce nom");
                boolUtil = false;
            }
                
                
            //nom util
            if (strNomU == "")
            {
                boolUtil = false;
                errMessage.SetError(tbNomUtilisateur, "Vous devez spécifier le nom de l'utlisateur");

            }
            else if ((strNomU != "") && (compte <= 0))
            {
                boolUtil = true;
            }
            //Mot de passe
            if (strMDP != "")
            {
                boolMDP = true;
            }
            else
            {
                errMessage.SetError(tbMDP, "Vous devez spécifier le nom de l'utlisateur");
            }

            //cb

            if (boolUtil && boolMDP)
            {
                unUtilisateur.nomUtilisateur = strNomU;
                unUtilisateur.mdpUtilisateur = strMDP;
                unUtilisateur.noTypeUtilisateur = Decimal.Parse(cbTypeUtilisateur.SelectedValue.ToString());
                this.Close();
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
