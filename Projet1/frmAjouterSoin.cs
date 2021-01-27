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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Boolean boolTxtDescription;
            Boolean boolPrix;
            decimal dcPrix;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
