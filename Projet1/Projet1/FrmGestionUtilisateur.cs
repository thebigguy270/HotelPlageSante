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
    public partial class FrmGestionUtilisateur : Form
    {
        public String noU;
        public String mdp;

        public FrmGestionUtilisateur()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FrmGestionUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.typeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.typeUtilisateur);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.utilisateur);
            utilisateurTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(utilisateurTableAdapter_RowUpdated);
        }

        private void utilisateurTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                String noContrat = e.Row["noUtilisateur"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour l'utilisateur " + noContrat + ". Aucun enregistrement possible.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;

            }
        }

        private void btnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.utilisateurBindingSource.EndEdit();

                this.utilisateurTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.utilisateur);
                //this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);

                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DBConcurrencyException erreur)
            {
                String noAssistant = erreur.Row["dgTxtAssistant"].ToString();
                MessageBox.Show("Conflit d'accès pour l'assistant " + noAssistant + ", Aucun enregistrement possible ", "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgUtilisateur.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    if ((dgUtilisateur["dgTxtNomUtilisateur",dgUtilisateur.CurrentRow.Index].Value.ToString() != noU)&& (dgUtilisateur["dgTxtMDP", dgUtilisateur.CurrentRow.Index].Value.ToString() != mdp)) {
                        SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                        utilisateurBindingSource.RemoveCurrent();
                        this.utilisateurTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.utilisateur);
                        //this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);

                        MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERREUR: Il est impossible de vous supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
            else
            {
                MessageBox.Show("Vous devez avoir sélectionné un utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterUtilisateur_Click(object sender, EventArgs e)
        {
            decimal noUtilisateurMax = 0;
            BD5B6TP1_BrodeurLussierDataSet.utilisateurRow unUtilisateur = bD5B6TP1_BrodeurLussierDataSet.utilisateur.NewutilisateurRow();
            foreach (BD5B6TP1_BrodeurLussierDataSet.utilisateurRow uneLigne in bD5B6TP1_BrodeurLussierDataSet.utilisateur.Rows)
            {
                if (uneLigne.noUtilisateur > noUtilisateurMax)
                {
                    noUtilisateurMax = uneLigne.noUtilisateur;
                }
            }
            unUtilisateur.noUtilisateur = noUtilisateurMax + 1;
            unUtilisateur.nomUtilisateur = "";
            frmAjouterUtilisateur frmAjout = new frmAjouterUtilisateur();
            frmAjout.unUtilisateur = unUtilisateur;
            frmAjout.ShowDialog();
            if (unUtilisateur.nomUtilisateur != "")
            {
                bD5B6TP1_BrodeurLussierDataSet.utilisateur.AddutilisateurRow(unUtilisateur);
                utilisateurBindingSource.MoveLast();
                this.Validate();
                this.utilisateurBindingSource.EndEdit();

                this.utilisateurTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.utilisateur);
                //this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);
                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void utilisateurDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgUtilisateur.Rows[e.RowIndex] != null && !dgUtilisateur.Rows[e.RowIndex].IsNewRow && dgUtilisateur.IsCurrentRowDirty)
            {
                String messageErreur = "";
                if (noU == dgUtilisateur["dgTxtNomUtilisateur", e.RowIndex].Value.ToString())
                {
                    e.Cancel = true;
                    messageErreur = "On ne peut modifier le type de soi-même";
                }
                dgUtilisateur.Rows[e.RowIndex].ErrorText = messageErreur;
            }
        }
    }
}
