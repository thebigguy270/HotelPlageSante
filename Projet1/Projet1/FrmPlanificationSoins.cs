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
    public partial class FrmPlanificationSoins : Form
    {
        public FrmPlanificationSoins()
        {
            InitializeComponent();
        }

        private void FrmPlanificationSoins_Load(object sender, EventArgs e)
        {
           
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.soin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.invitesEtClients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.invitesEtClientsTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.invitesEtClients);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.invitesEtClients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.invitesEtClientsTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.invitesEtClients);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.client);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.planifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.planifSoin);

        }

        private void nomPrenonLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
