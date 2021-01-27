using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class frmAjouterChambre : Form
    {
        public BD5B6TP1_BrodeurLussierDataSet.chambreRow uneChambre;
        public frmAjouterChambre()
        {
            InitializeComponent();
        }

        private void frmAjouterChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.typeChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeChambreTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.typeChambre);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Boolean boolDec = true;
            Boolean boolEmp = true;
            Boolean boolTypeChambre = true;
            
            if (tbDecorations.Text == "")
            {
                boolDec = false;
                errMessage.SetError(tbDecorations, "Vous devez spécifier les décorations");
            }
            if(tbEmplacement.Text == "")
            {
                boolEmp = false;
                errMessage.SetError(tbDecorations, "Vous devez spécifier l'emplacement");
            }
            if(cbTypeChambre.SelectedIndex < 0)
            {
                boolTypeChambre = false;
                errMessage.SetError(tbDecorations, "Vous devez spécifier le type de la chambre");
            }
            if (boolDec&&boolEmp&&boolTypeChambre)
            {
                uneChambre.noTypeChambre = decimal.Parse(cbTypeChambre.SelectedValue.ToString());
                uneChambre.decorations = tbDecorations.Text;
                uneChambre.emplacement = tbEmplacement.Text;
                this.Close();

            }

        }

        private void tbEmplacement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
