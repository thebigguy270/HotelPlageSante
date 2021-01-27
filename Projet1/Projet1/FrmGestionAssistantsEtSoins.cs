using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projet1
{
    public partial class FrmGestionAssistantsEtSoins : Form
    {
        public decimal noAssistant;
        public FrmGestionAssistantsEtSoins()
        {
            InitializeComponent();
        }







        private void FrmGestionAssistantsEtSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.soinSansAssistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinSansAssistantTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.soinSansAssistant);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.spoon'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.spoonTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.spoon);

            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistantSoin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistant);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet1.spoon'. Vous pouvez la déplacer ou la supprimer selon les besoins.

            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistant);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistantSoin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistantSoin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.planifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.planifSoin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.typeSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.typeSoin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.typeSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.typeSoin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.soin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistant);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistantSoin);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistantSoin);
            this.spoonTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.spoon);
            assistantTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(assistantTableAdapter_RowUpdated);
            assistantSoinTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(assistantSoinTableAdapter_RowUpdated);
            spoonTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(spoonTableAdapter_RowUpdated);

        }

        private void spoonTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                //String noSoin = e.Row["noSoin"].ToString();
                //MessageBox.Show("Conflit d'accès concurrentiel pour le soin " + noSoin + ". Aucun enregistrement possible.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;
            }
        }

        private void assistantSoinTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                String noAssistant = e.Row["noAssistant"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour l'assistant  " + noAssistant + ". Aucun enregistrement possible.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;
            }
        }

        private void assistantTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                String noAssistant = e.Row["noAssistant"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour l'assistant  " + noAssistant + ". Aucun enregistrement possible.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;
            }
        }

        private void btnAjoutAssist_Click(object sender, EventArgs e)
        {
            decimal noAssistantMax = 0;
            BD5B6TP1_BrodeurLussierDataSet.assistantRow unAssistant = bD5B6TP1_BrodeurLussierDataSet.assistant.NewassistantRow();
            foreach (BD5B6TP1_BrodeurLussierDataSet.assistantRow uneLigne in bD5B6TP1_BrodeurLussierDataSet.assistant.Rows)
            {
                if (uneLigne.noAssistant > noAssistantMax)
                {
                    noAssistantMax = uneLigne.noAssistant;
                }
            }
            unAssistant.noAssistant = noAssistantMax + 1;
            unAssistant.prenom = "";
            frmAjouterAssistant frmAjout = new frmAjouterAssistant();
            frmAjout.unAssistant = unAssistant;
            frmAjout.ShowDialog();
            if(unAssistant.prenom != "")
            {
                bD5B6TP1_BrodeurLussierDataSet.assistant.AddassistantRow(unAssistant);
                assistantBindingSource.MoveLast();
                this.Validate();
                this.assistantBindingSource.EndEdit();

                this.assistantSoinTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.assistantSoin);
                
                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void dgAssistants_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgAssistants.Rows[e.RowIndex] != null && !dgAssistants.Rows[e.RowIndex].IsNewRow && dgAssistants.IsCurrentRowDirty)
            {
                String messageErreur = "";
                String strPrenom = dgAssistants["dgTxtPrenom", e.RowIndex].Value.ToString();
                String strNom = dgAssistants["dgTxtNom", e.RowIndex].Value.ToString();
                String strSpecialites = dgAssistants["dgTxtSpecialites", e.RowIndex].Value.ToString();
                String strRemarques = dgAssistants["dgTxtRemarques", e.RowIndex].Value.ToString();
                if ((strPrenom == "") || (strNom == "") ||
                    (strSpecialites == ""))
                {
                    messageErreur = "Une variable importante manque";
                    e.Cancel = true;
                }
                dgAssistants.Rows[e.RowIndex].ErrorText = messageErreur;
            }
        }

        private void btnModifierAssist_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.assistantBindingSource.EndEdit();
                this.assistantTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.assistant);
                this.soinTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.soin);
                this.assistantSoinTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.assistantSoin);

                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(DBConcurrencyException erreur)
            {
                String noAssistant = erreur.Row["dgTxtAssistant"].ToString(); 
                MessageBox.Show("Conflit d'accès pour l'assistant " + noAssistant + ", Aucun enregistrement possible ", "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerAssist_Click(object sender, EventArgs e)
        {
            if (dgAssistants.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                    connection.Open();
                    String requeteNoAssistant = "SELECT COUNT(*) FROM planifSoin WHERE noAssistant = @noAssistant;";
                    SqlCommand commande = new SqlCommand(requeteNoAssistant, connection);
                    String strNoAssist = dgAssistants["dgTxtAssistant", dgAssistants.CurrentRow.Index].Value.ToString();
                    
                    SqlParameter paramNoAssistant = new SqlParameter("@noAssistant", strNoAssist);
                    commande.Parameters.Add(paramNoAssistant);
                    if ((int)commande.ExecuteScalar() == 0)
                    {

                        foreach (var row in soinBindingSource)
                        {

                            soinBindingSource.Remove(row);
                        }
                        assistantBindingSource.RemoveCurrent();
                        assistantTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.assistant);
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("L'assistant a des soins de planifié, suppression impossible", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnAjouterSoinAAssistant(object sender, EventArgs e)
        {

            BD5B6TP1_BrodeurLussierDataSet.spoonRow unSoin = bD5B6TP1_BrodeurLussierDataSet.spoon.NewspoonRow();
            frmAjouterSoinPourAssistant frmAjout = new frmAjouterSoinPourAssistant();
            frmAjout.unSoin = unSoin;
            unSoin.noSoin = -1;
            String strNoAssist = dgAssistants["dgTxtAssistant", dgAssistants.CurrentRow.Index].Value.ToString();
            unSoin.noAssistant = Decimal.Parse(strNoAssist);
            frmAjout.ShowDialog();
            if (unSoin.noSoin != -1)
            {
                bD5B6TP1_BrodeurLussierDataSet.spoon.AddspoonRow(unSoin);
                this.spoonTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.spoon);
                this.soinTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.soin);

                BD5B6TP1_BrodeurLussierDataSet.assistantSoinRow assiS = bD5B6TP1_BrodeurLussierDataSet.assistantSoin.NewassistantSoinRow();
                assiS.noAssistant = unSoin.noAssistant;
                assiS.noSoin = unSoin.noSoin;
                bD5B6TP1_BrodeurLussierDataSet.assistantSoin.AddassistantSoinRow(assiS);



                spoonBindingSource2.MoveLast();
                this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);
                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgSoins.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultat == DialogResult.Yes)
                {

                    SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                    connection.Open();
                    SqlTransaction maTransaction = connection.BeginTransaction();
                    try
                    {
                        String requeteNoSoin = "SELECT COUNT(*) FROM planifSoin WHERE noSoin = @noSoin;";
                        SqlCommand commande = new SqlCommand(requeteNoSoin, connection);
                        String strNoSoin = dgSoins["dgTxtNoSoin", dgSoins.CurrentRow.Index].Value.ToString();
                        //MessageBox.Show(strNoSoin);
                        SqlParameter paramNoSoin = new SqlParameter("@noSoin", strNoSoin);
                        commande.Parameters.Add(paramNoSoin);
                        commande.Transaction = maTransaction;
                        if ((int)commande.ExecuteScalar() == 0)
                        {
                            spoonBindingSource2.RemoveCurrent();
                            String requeteNoAssistant = "DELETE FROM assistantSoin WHERE noAssistant = @noAssistant AND noSoin = @noSoin;";
                            SqlCommand commande2 = new SqlCommand(requeteNoAssistant, connection);

                            String strNoAssistant = dgAssistants["dgTxtAssistant", dgAssistants.CurrentRow.Index].Value.ToString();
                            SqlParameter paramNoAssistant = new SqlParameter("@noAssistant", strNoAssistant);
                            SqlParameter paramNoSoin2 = new SqlParameter("@noSoin", strNoSoin);

                            commande2.Transaction = maTransaction;
                            commande2.Parameters.Add(paramNoAssistant);
                            commande2.Parameters.Add(paramNoSoin2);
                            commande2.ExecuteNonQuery();
                            maTransaction.Commit();
                            

                            

                            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);
                        }
                        else
                        {
                            MessageBox.Show("L'assistant a des soins de planifié, suppression impossible", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.ToString());
                        maTransaction.Rollback();
                        MessageBox.Show("Transaction Échouée");
                    }
                    connection.Close();
                }
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.assistantTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistant);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}