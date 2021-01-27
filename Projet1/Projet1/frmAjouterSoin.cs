using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class frmAjouterSoin : Form
    {

        public BD5B6TP1_BrodeurLussierDataSet.soinRow unSoin;
        public frmAjouterSoin()
        {
            InitializeComponent();
        }


        private void frmAjouterSoin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.typeSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.typeSoin);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Boolean boolDesc=true;
            Boolean boolDuree=true;
            Boolean boolPrix=true;
           
            decimal decPrix=0;
            char point = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            var exprDonnee = new Regex("^[0-9]{1,}(" + point + "[0-9]{2})?$");
            //description

            if (tbDescription.Text == "")
            {
                boolDesc = false ;
                errMessage.SetError(tbDescription, "Vous devez spécifier la description");
            }

            //
            if (tbPrix.Text == "")
            {
                boolPrix = false;
                errMessage.SetError(tbPrix, "Vous devez spécifier le prix du soin.");
            }
            else if(!exprDonnee.IsMatch(tbPrix.Text))
            {
                boolPrix = false;
                errMessage.SetError(tbPrix, "Le prix doit être un nombre décimal.");
            }
            else
            {
                decPrix = Convert.ToDecimal(tbPrix.Text.Replace(',', point).Replace('.', point));
            }

            if (boolDesc && boolDuree && boolPrix)
            {
                unSoin.description = tbDescription.Text;
                unSoin.duree = 60;
                unSoin.noTypeSoin = Convert.ToDecimal(cbTypeDeSoin.SelectedValue.ToString());
                unSoin.prix = decPrix;
                this.Close();
            }

        }
    }
}
