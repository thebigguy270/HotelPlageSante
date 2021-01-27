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
    public partial class frmAjouterSoinPourAssistant : Form
    {
        public BD5B6TP1_BrodeurLussierDataSet.spoonRow unSoin;
        public frmAjouterSoinPourAssistant()
        {
            InitializeComponent();
        }

        private void frmAjouterSoin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.spoon'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.spoonTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.spoon);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.soinSansAssistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinSansAssistantTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.soinSansAssistant);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            if(ddlSoinSansAssistant.Items.Count == 0)
            {
                this.Close();
            }
            else
            {
                if (ddlSoinSansAssistant.SelectedItem != null)
                {
                    errMessage.SetError(ddlSoinSansAssistant, "");
                    unSoin.noSoin = Decimal.Parse(ddlSoinSansAssistant.SelectedValue.ToString());
                    SqlConnection maConnexion = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                    maConnexion.Open();
                    String strCommande = "SELECT description FROM soin WHERE nosoin=@nosoin";
                    SqlCommand maCommande = new SqlCommand(strCommande, maConnexion);
                    SqlParameter paramNoC1 = new SqlParameter("@nosoin", ddlSoinSansAssistant.SelectedValue.ToString());
                    maCommande.Parameters.Add(paramNoC1);
                    String strDesc = Convert.ToString(maCommande.ExecuteScalar());
                    unSoin.description = strDesc;

                    this.Close();
                }
                else
                {
                    errMessage.SetError(ddlSoinSansAssistant, "Aucun soin sélectionné");
                    
                }
            }
        }
    }
}
