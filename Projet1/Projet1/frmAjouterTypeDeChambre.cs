using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class frmAjouterTypeDeChambre : Form
    {
        public BD5B6TP1_BrodeurLussierDataSet.typeChambreRow unTypeDeChambre;
        public frmAjouterTypeDeChambre()
        {
            InitializeComponent();
        }

        private void frmAjouterTypeDeChambre_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            char point = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            var exprDonnee = new Regex("^[0-9]{1,}(" + point + "[0-9]{2}){0,1}?$");
            String strDescription = tbDescription.Text;
            String strPrixH = tbPrixH.Text;
            String strPrixB = tbPrixB.Text;
            String strPrixM = tbPrixM.Text;
            Boolean boolPH = false;
            Boolean boolPB = false;
            Boolean boolPM = false;
            Boolean boolDescription = false;
            SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
            connection.Open();
            String requeteNoTypeChambre = "SELECT COUNT(*) FROM typeChambre WHERE description = '" + strDescription + "'";
            SqlCommand commande = new SqlCommand(requeteNoTypeChambre, connection);
            int compteurdescription = (int)commande.ExecuteScalar();


            if (strPrixH == "")
            {
                errMessage.SetError(tbPrixH, "Le prix le plus haut doit être un nombre décimal");
                boolPH = false;
            }

            else if (!exprDonnee.IsMatch(strPrixH))
            {
                errMessage.SetError(tbPrixH, "Le prix le plus haut doit être défini");
                boolPH = false;
            }
            else
            {
                boolPH = true;
                
            }
            if (strPrixB == "")
            {
                errMessage.SetError(tbPrixB, "Le prix le plus haut doit être défini");
                boolPB = false;
            }
            else if (!exprDonnee.IsMatch(strPrixB))
            {
                errMessage.SetError(tbPrixB, "Le prix le plus bas doit être un nombre décimal");
                boolPB = false;
            }
            else
            {
                boolPB = true;
            }
            if (strPrixM == "")
            {
                errMessage.SetError(tbPrixM, "Le prix le plus haut doit être défini");
                boolPM = false;
            }

            else if (!exprDonnee.IsMatch(strPrixM))
            {
                errMessage.SetError(tbPrixM, "Le prix moyen doit être un nombre décimal");
                boolPM = false;
            }
            else
            {
                boolPM = true;
            }

            if (strDescription == "")
            {
                errMessage.SetError(tbDescription, "La description doit être définie");
                boolDescription = false;
            }
            else if (compteurdescription > 0)
            {
                errMessage.SetError(tbDescription, "Un type de chambre a déja cette description");
                boolDescription = false;
            }
            else
            {
                boolDescription = true;
            }
            if (boolPB && boolPH && boolPM && boolDescription)
            {
                Decimal prixM = Convert.ToDecimal(strPrixM);
                Decimal prixB = Convert.ToDecimal(strPrixB);
                Decimal prixH = Convert.ToDecimal(strPrixH);
                Boolean boolDecP = true;
                
                if (prixM >= prixH)
                {
                    errMessage.SetError(tbPrixH, "Le prix moyen doit être plus petit que le plus grand prix possible");
                    boolDecP = false;
                }
                if (prixM <= prixB)
                {
                    errMessage.SetError(tbPrixB, "Le prix moyen doit être plus grand que le plus petit prix possible");
                    boolDecP = false;
                }
                if (prixB >= prixH)
                {
                    errMessage.SetError(tbPrixH, "Le prix le plus bas doit être plus petit que le plus grand prix possible");
                    errMessage.SetError(tbPrixB, "Le prix le plus bas doit être plus petit que le plus grand prix possible");
                    boolDecP = false;
                }
                if (boolDecP)
                {
                    unTypeDeChambre.description = strDescription;
                    unTypeDeChambre.prixBas = prixB;
                    unTypeDeChambre.prixHaut = prixH;
                    unTypeDeChambre.prixMoyen = prixM;
                    this.Close();
                }

            }
        }
    }
}
