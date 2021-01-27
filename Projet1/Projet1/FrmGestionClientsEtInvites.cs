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
    public partial class FrmGestionClientsEtInvites : Form
    {
       

        public FrmGestionClientsEtInvites()
        {
            InitializeComponent();
        }

        private void FrmGestionClientsEtInvites_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.invite);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.invite);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.client);
            
            this.inviteTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.invite);
            //inviteTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(inviteTableAdapter_RowUpdated);
            //clientTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(clientTableAdapter_RowUpdated);
        }

        private void inviteTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

            if (e.RecordsAffected == 0)
            {
                String noClient = e.Row["noInvite"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour l'invité " + noClient + ". Aucun enregistrement possible.", "Conflit d'accès");

                e.Status = UpdateStatus.Continue;
            }
        }

        private void clientTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

            if (e.RecordsAffected == 0)
            {
                String noClient = e.Row["noClient"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour le client " + noClient + ". Aucun enregistrement possible.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgClient_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgClient.Rows[e.RowIndex] != null && !dgClient.Rows[e.RowIndex].IsNewRow && dgClient.IsCurrentRowDirty)
            {
                String strMessage = "";
                if (dgClient["dgTxtAdresseClient", e.RowIndex].Value.ToString() == "")
                {
                    strMessage = "L'adresse de ce client ne peut pas être nulle.";
                    e.Cancel = true;
                }
                if (dgClient["dgTxtVilleClient", e.RowIndex].Value.ToString() == "")
                {
                    strMessage = "La ville de ce client ne peut pas être nulle.";
                    e.Cancel = true;
                }
                if (dgClient["dgTxtPaysClient", e.RowIndex].Value.ToString() == "")
                {
                    strMessage = "Le pays de ce client ne peut pas être nul.";
                    e.Cancel = true;
                }
                if (dgClient["dgTxtNomClient", e.RowIndex].Value.ToString() == "")
                {
                    strMessage = "Le nom de ce client ne peut pas être nul.";
                    e.Cancel = true;
                }
                if (dgClient["dgTxtPrenomClient", e.RowIndex].Value.ToString() == "")
                {
                    strMessage = "Le prénom de ce client ne peut pas être nul.";
                    e.Cancel = true;
                }
                if (dgClient["dgTxtCodePostalClient", e.RowIndex].Value.ToString() == "")
                {
                    strMessage = "Le code postal de ce client ne peut pas être nul.";
                    e.Cancel = true;
                }
                dgClient.Rows[e.RowIndex].ErrorText = strMessage;
            }
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            decimal noClientMax = 0;
            BD5B6TP1_BrodeurLussierDataSet.clientRow unClient = bD5B6TP1_BrodeurLussierDataSet.client.NewclientRow();
            foreach (BD5B6TP1_BrodeurLussierDataSet.clientRow uneLigne in bD5B6TP1_BrodeurLussierDataSet.client.Rows)
            {
                if (uneLigne.noClient > noClientMax)
                {
                    noClientMax = uneLigne.noClient;
                }
            }
            unClient.noClient = noClientMax + 10;
            unClient.prenom = "";
            frmAjouterClient frmAjout = new frmAjouterClient();
            frmAjout.unClient = unClient;
            unClient.dateInscription = DateTime.MinValue;
            frmAjout.ShowDialog();
            if (unClient.dateInscription != DateTime.MinValue)
            {

                bD5B6TP1_BrodeurLussierDataSet.client.AddclientRow(unClient);
                clientBindingSource.MoveLast();
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.clientTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.client);
                
            }
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (dgClient.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    String strNoClient = dgClient["dgTxtNoClient", dgClient.CurrentRow.Index].Value.ToString();

                    SqlConnection maConnexion = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                    maConnexion.Open();
                    SqlTransaction transclient = maConnexion.BeginTransaction();
                    String strMessage = "";
                    try
                    {
                        String SQLRequete1 = "SELECT COUNT(*) FROM invite WHERE noClient = @nc";
                        String SQLRequete2 = "SELECT COUNT(*) FROM reservationChambre WHERE noClient = @nc";
                        String SQLRequete3 = "SELECT COUNT(*) FROM planifSoin WHERE noPersonne = @nc";
                        int scal1 = 0;
                        int scal2 = 0;
                        int scal3 = 0;
                        SqlCommand maCommande1 = new SqlCommand(SQLRequete1, maConnexion);
                        SqlCommand maCommande2 = new SqlCommand(SQLRequete2, maConnexion);
                        SqlCommand maCommande3 = new SqlCommand(SQLRequete3, maConnexion);
                        maCommande1.Transaction = transclient;
                        SqlParameter paramNoC1 = new SqlParameter("@nc", strNoClient);
                        maCommande1.Parameters.Add(paramNoC1);
                        scal1 = (int)maCommande1.ExecuteScalar();

                        maCommande2.Transaction = transclient;
                        SqlParameter paramNoC2 = new SqlParameter("@nc", strNoClient);
                        maCommande2.Parameters.Add(paramNoC2);
                        scal2 = (int)maCommande2.ExecuteScalar();

                        maCommande3.Transaction = transclient;
                        SqlParameter paramNoC3 = new SqlParameter("@nc", strNoClient);
                        maCommande3.Parameters.Add(paramNoC3);
                        scal3 = (int)maCommande3.ExecuteScalar();

                        if (scal1 > 0)
                        {
                            strMessage += "Le client a des invités.";
                            
                        }
                        if (scal2 > 0)
                        {
                            strMessage += "Le client a réservé une chambre.";
                        }
                        if (scal3 > 0)
                        {
                            strMessage += "Le client a un soin de planifié.";
                        }
                        if ((scal1 == 0)&& (scal2 == 0)&& (scal3 == 0))
                        {
                            clientBindingSource.RemoveCurrent();
                            this.clientTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.client);
                           
                        }
                        dgClient.Rows[dgClient.CurrentRow.Index].ErrorText = strMessage;
                        transclient.Commit();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.ToString());
                        transclient.Rollback();
                        MessageBox.Show("Transaction Échouée");
                    }
                    maConnexion.Close();
                }
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.clientBindingSource.EndEdit();
            try
            {
                this.clientTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.client);
                
                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DBConcurrencyException erreur)
            {
                String noClient = erreur.Row["dgTxtNoClient"].ToString();
                MessageBox.Show("Conflit d'accès pour le client " + noClient + ", Aucun enregistrement possible ", "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {
            if (dgInvite.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    String strNoInvite = dgInvite["dgTxtNoInvite", dgInvite.CurrentRow.Index].Value.ToString();
                    SqlConnection maConnexion = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                    maConnexion.Open();
                    String strCommande = "SELECT COUNT(*) FROM planifSoin WHERE noPersonne=@noInvite";
                    SqlCommand maCommande = new SqlCommand(strCommande, maConnexion);
                    SqlParameter paramNoC1 = new SqlParameter("@noInvite", strNoInvite);
                    maCommande.Parameters.Add(paramNoC1);
                    if ((int)maCommande.ExecuteScalar()==0)
                    {
                        
                        inviteBindingSource.RemoveCurrent();
                        this.inviteTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.invite);
                        
                    }
                    else
                    {
                        MessageBox.Show("On ne peut pas effacer un invité s'il a un soin de planifié.");
                    }
                    maConnexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas effacer d'invités sans en sélectionner.");
            }
        }

        private void dgInvite_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgInvite.Rows[e.RowIndex] != null && !dgInvite.Rows[e.RowIndex].IsNewRow && dgInvite.IsCurrentRowDirty)
            {
                if (dgInvite["dgTxtNomPrenom", e.RowIndex].Value.ToString() == "")
                {
                    dgInvite.Rows[e.RowIndex].ErrorText = "Le nom et le prénom de l'invité ne peut pas être nul.";
                    e.Cancel = true;
                }
            }
        }

        private void btnModifierInvite_Click(object sender, EventArgs e)
        {
            try
            {
                this.inviteTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.invite);
                

                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DBConcurrencyException erreur)
            {
                String noInvite = erreur.Row["dgTxtNoInvite"].ToString();
                MessageBox.Show("Conflit d'accès pour le client " + noInvite + ", Aucun enregistrement possible ", "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterInvite_Click(object sender, EventArgs e)
        {
            
            BD5B6TP1_BrodeurLussierDataSet.inviteRow unInvite = bD5B6TP1_BrodeurLussierDataSet.invite.NewinviteRow();
            
           
            frmAjouterInvite frmA = new frmAjouterInvite();



            frmA.unInvite = unInvite;
            
            unInvite.noClient = Convert.ToDecimal(dgClient["dgTxtNoClient",dgClient.CurrentRow.Index].Value.ToString());
            unInvite.nomPrenom = "";
            int compteurclient = 0;
            //noClient


            SqlConnection connexion = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
            connexion.Open();
            String requeteNoClient = "SELECT COUNT(*) FROM invite WHERE noClient = @noClient;";
            SqlCommand commande = new SqlCommand(requeteNoClient, connexion);


            SqlParameter paramNoClient = new SqlParameter("@noClient", dgClient["dgTxtNoClient", dgClient.CurrentRow.Index].Value.ToString());
            commande.Parameters.Add(paramNoClient);
            compteurclient = (int)commande.ExecuteScalar();
            frmA.compteurclient = compteurclient;
            MessageBox.Show(compteurclient.ToString());
            if (compteurclient < 10)
            {


                unInvite.noClient = Convert.ToDecimal(dgClient["dgTxtNoClient", dgClient.CurrentRow.Index].Value.ToString());
                
                frmA.ShowDialog();
                if (unInvite.nomPrenom != "")
                {

                    this.bD5B6TP1_BrodeurLussierDataSet.invite.AddinviteRow(unInvite);
                    inviteBindingSource.MoveLast();

                    this.Validate();
                    this.inviteBindingSource.EndEdit();
                    this.inviteTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.invite);
                    this.inviteTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.invite);


                    MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Un client ne peut avoir que dix invités au maximum.");
            }
            connexion.Close();



           




        }
    }
}
