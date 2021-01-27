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
    public partial class FrmVisualisationRapports : Form
    {
        public FrmVisualisationRapports()
        {
            InitializeComponent();
        }

        private void FrmVisualisationRapports_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.RapportA'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rapportATableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.RapportA);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.invitesEtClients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.invitesEtClientsTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.invitesEtClients);
            //Montant total
            SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
            connection.Open();
            String strNoPersonne = cbInvitesEtClients.SelectedValue.ToString();
            String requeteNoPersonne = "SELECT SUM(soin.prix) FROM planifSoin inner join soin ON planifSoin.noSoin = soin.noSoin WHERE planifSoin.noPersonne ='" + strNoPersonne + "'";
            SqlCommand commande = new SqlCommand(requeteNoPersonne, connection);
            String montant = commande.ExecuteScalar().ToString();
            if (montant != "")
            {
                tbMontant.Text = montant.ToString();
            }
            else
            {
                tbMontant.Text = "0,00";
            }

        }

        private void rapportADataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbInvitesEtClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Montant total
            SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
            connection.Open();
            String strNoPersonne = cbInvitesEtClients.SelectedValue.ToString();
            String requeteNoPersonne = "SELECT SUM(soin.prix) FROM planifSoin inner join soin ON planifSoin.noSoin = soin.noSoin WHERE planifSoin.noPersonne ='" + strNoPersonne + "'";
            SqlCommand commande = new SqlCommand(requeteNoPersonne, connection);
            String montant = commande.ExecuteScalar().ToString();
            if (montant != "")
            {
                tbMontant.Text = montant.ToString();
            }
            else
            {
                tbMontant.Text = "0,00";
            }
        }
    }
}
