using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class FrmGestionSoins : Form
    {
        public FrmGestionSoins()
        {
            InitializeComponent();
        }

        

        private void FrmGestionSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.typeSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.typeSoin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.soin);

        }

        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            decimal noSoinMax = 0;
            BD5B6TP1_BrodeurLussierDataSet.soinRow unSoin = bD5B6TP1_BrodeurLussierDataSet.soin.NewsoinRow();
            foreach (BD5B6TP1_BrodeurLussierDataSet.soinRow uneLigne in bD5B6TP1_BrodeurLussierDataSet.soin.Rows)
            {
                if (uneLigne.noSoin > noSoinMax)
                {
                    noSoinMax = uneLigne.noSoin;
                }
            }
            unSoin.noSoin = noSoinMax + 1;
            unSoin.description = "";
            frmAjouterSoin frmAjout = new frmAjouterSoin();
            frmAjout.unSoin = unSoin;
            frmAjout.ShowDialog();
            if (unSoin.description != "")
            {
                bD5B6TP1_BrodeurLussierDataSet.soin.AddsoinRow(unSoin);
                soinBindingSource.MoveLast();
                this.Validate();
                this.soinBindingSource.EndEdit();

                this.soinTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.soin);
                this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);
                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {
            if (dgSoins.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                    connection.Open();
                    SqlTransaction trans = connection.BeginTransaction();
                    try
                    {
                        String strNoSoin = dgSoins["dgTxtNoSoin", dgSoins.CurrentRow.Index].Value.ToString();
                        String requeteNoSoinPlanif = "SELECT COUNT(*) FROM planifSoin WHERE noSoin = @noSoin;";
                        SqlCommand commande1 = new SqlCommand(requeteNoSoinPlanif, connection);

                        SqlParameter paramNoSoin = new SqlParameter("@noSoin", strNoSoin);
                        commande1.Parameters.Add(paramNoSoin);
                        commande1.Transaction = trans;
                        int planif = (int)commande1.ExecuteScalar();
                        String requeteNoSoinAssistant = "SELECT COUNT(*) FROM assistantSoin WHERE noSoin = @noSoin;";
                        SqlCommand commande2 = new SqlCommand(requeteNoSoinAssistant, connection);
                        SqlParameter paramNoSoin2 = new SqlParameter("@noSoin", strNoSoin);
                        commande2.Parameters.Add(paramNoSoin2);
                        commande2.Transaction = trans;
                        int assist = (int)commande2.ExecuteScalar();
                        if ((planif == 0) && (assist == 0))
                        {
                            soinBindingSource.RemoveCurrent();
                        }
                        else
                        {
                            MessageBox.Show("Impossible de supprimer, le soin est soit déja planifié ou un assistant lui est associé avec.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        trans.Commit();
                    }
                    catch(Exception ex)
                    {

                        trans.Rollback();
                        MessageBox.Show(ex.ToString());
                    }
                    connection.Close();
                }

            }
        }

        private void dgSoins_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgSoins.Rows[e.RowIndex] != null && !dgSoins.Rows[e.RowIndex].IsNewRow && dgSoins.IsCurrentRowDirty)
            {
                String strMessageErreur = "";
                //soin
                Boolean boolPrixOK = false;
                Boolean boolDureeOK = false;
                String strPrix = dgSoins["dgTxtPrix", e.RowIndex].Value.ToString();
                String strDescription = dgSoins["dgTxtDescription", e.RowIndex].Value.ToString();
                String strDuree = dgSoins["dgTxtDuree", e.RowIndex].Value.ToString();
                String strNoType = dgSoins["dgTxtTypeSoin", e.RowIndex].Value.ToString();
                //prix
                decimal dcPrix = 0;
                int intDuree = 0;
                if (Decimal.TryParse(strPrix, NumberStyles.Any, CultureInfo.InvariantCulture, out dcPrix))
                {
                    boolPrixOK = true;
                }
                if (strPrix == "")
                {
                    e.Cancel = true;
                    strMessageErreur += "Le prix ne peut pas être vide.";
                }
                if (!boolPrixOK)
                {
                    e.Cancel = true;
                    strMessageErreur += "Le prix doit être de valeur décimale.";
                }
                if (strDuree == "")
                {
                    e.Cancel = true;
                    strMessageErreur += "La durée ne peut pas être vide.";
                }
                if (int.TryParse(strDuree, out intDuree))
                {
                    boolDureeOK = true;
                }
                if (!boolDureeOK)
                {
                    e.Cancel = true;
                    strMessageErreur += "La durée doit être représentée avec un nombre entier.";
                }
                if (strDescription == "")
                {
                    e.Cancel = true;
                    strMessageErreur += "La durée doit être représentée avec un nombre entier.";
                }
                dgSoins.Rows[e.RowIndex].ErrorText = strMessageErreur;
            }
        }

        private void btnModifierSoin_Click(object sender, EventArgs e)
        {
            try
            {
                this.soinTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.soin);
                this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);
                MessageBox.Show("Les modifications sont sauvegardées");
            }
            catch (DBConcurrencyException erreur)
            {
                String noSoin = erreur.Row["dgTxtNoSoin"].ToString();
                MessageBox.Show("Conflit d'accès pour le type " + noSoin + ", Aucun enregistrement possible ", "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
