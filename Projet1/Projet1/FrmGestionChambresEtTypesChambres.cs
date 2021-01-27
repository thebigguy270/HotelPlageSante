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
using System.Globalization;

namespace Projet1
{
    public partial class FrmGestionChambresEtTypesChambres : Form
    {
        public FrmGestionChambresEtTypesChambres()
        {
            InitializeComponent();
        }

        private void FrmGestionChambresEtTypesChambres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.typeChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeChambreTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.typeChambre);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.chambre);
            chambreTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(chambreTableAdapter_RowUpdated);
            typeChambreTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(typeChambreTableAdapter_RowUpdated);
        }

        private void chambreTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                String noChambre = e.Row["noChambre"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour la chambre " + noChambre + ". Aucun enregistrement possible.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;

            }
        }

        private void typeChambreTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                String noTypeChambre = e.Row["noTypeChambre"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour le type " + noTypeChambre + ". Aucun enregistrement possible.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;

            }
        }

        private void btnSupprimerCHambre_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultat == DialogResult.Yes)
            {
                if (dgChambres.SelectedRows.Count > 0)
                {
                    SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                    connection.Open();
                    String requeteNoChambre = "SELECT COUNT(*) FROM reservationChambre WHERE noChambre = @noChambre;";
                    SqlCommand commande = new SqlCommand(requeteNoChambre, connection);
                    String strNoChambre = dgChambres["dgTxtNoChambre", dgChambres.CurrentRow.Index].Value.ToString();
                    MessageBox.Show(strNoChambre);
                    SqlParameter paramNoChambre = new SqlParameter("@noChambre", strNoChambre);
                    commande.Parameters.Add(paramNoChambre);
                    if ((int)commande.ExecuteScalar() == 0)
                    {

                        chambreBindingSource.RemoveCurrent();
                        this.chambreTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.chambre);
                        this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);

                    }
                    else
                    {
                        MessageBox.Show("La chambre est déja réservée, suppression impossible", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
        }

        private void btnModifierChambre_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            try {
                this.chambreTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.chambre);
                

                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DBConcurrencyException erreur)
            {
                String noChambre = erreur.Row["dgTxtNoChambre"].ToString();
                MessageBox.Show("Conflit d'accès pour la chambre " + noChambre +", Aucun enregistrement possible ", "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {
            //no nouvelle chambre
            decimal noChambreMax = 0;
            BD5B6TP1_BrodeurLussierDataSet.chambreRow uneChambre = bD5B6TP1_BrodeurLussierDataSet.chambre.NewchambreRow();
            foreach (BD5B6TP1_BrodeurLussierDataSet.chambreRow uneLigne in bD5B6TP1_BrodeurLussierDataSet.chambre.Rows)
            {
                if (uneLigne.noChambre > noChambreMax)
                {
                    noChambreMax = uneLigne.noChambre;
                }
            }
            uneChambre.noChambre = noChambreMax + 1;
            frmAjouterChambre frmA = new frmAjouterChambre();
            frmA.uneChambre = uneChambre;
            uneChambre.noTypeChambre = 0;
            frmA.ShowDialog();
            if (uneChambre.noTypeChambre != 0)
            {
                bD5B6TP1_BrodeurLussierDataSet.chambre.AddchambreRow(uneChambre);
                chambreBindingSource.MoveLast();
                this.Validate();
                this.chambreBindingSource.EndEdit();
                this.chambreTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.chambre);
               
            }

        }

        private void dgChambres_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            String txtTypeChambre = dgChambres["dgTxtNoTypeChambre", e.RowIndex].Value.ToString();
            String txtEmplacement = dgChambres["dgTxtNoEmplacement", e.RowIndex].Value.ToString(); 
            String txtDecorations = dgChambres["dgTxtDecorations", e.RowIndex].Value.ToString();
            String messageErreur = "";
            if ((txtDecorations == "")|| (txtEmplacement == "") || (txtTypeChambre == "")){
                messageErreur = "Une variable importante manque";
                e.Cancel = true;
            }
            dgChambres.Rows[e.RowIndex].ErrorText = messageErreur;

        }

        private void btnAjouterTypeChambre_Click(object sender, EventArgs e)
        {
            decimal noTypeChambreMax = 0;
            BD5B6TP1_BrodeurLussierDataSet.typeChambreRow unTypeDeChambre = bD5B6TP1_BrodeurLussierDataSet.typeChambre.NewtypeChambreRow();
            foreach (BD5B6TP1_BrodeurLussierDataSet.typeChambreRow uneLigne in bD5B6TP1_BrodeurLussierDataSet.typeChambre.Rows)
            {
                if (uneLigne.noTypeChambre > noTypeChambreMax)
                {
                    noTypeChambreMax = uneLigne.noTypeChambre;
                }
            }
            unTypeDeChambre.noTypeChambre = noTypeChambreMax + 1;
            unTypeDeChambre.description = "";
            frmAjouterTypeDeChambre frmA = new frmAjouterTypeDeChambre();
            frmA.unTypeDeChambre = unTypeDeChambre;
            frmA.ShowDialog();
            if (unTypeDeChambre.description != "")
            {
                bD5B6TP1_BrodeurLussierDataSet.typeChambre.AddtypeChambreRow(unTypeDeChambre);
                typeChambreBindingSource.MoveLast();
                this.Validate();
                this.typeChambreBindingSource.EndEdit();
                this.typeChambreTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.typeChambre);
                
            }


        }

        private void btnSupprimerTypeChambre_Click(object sender, EventArgs e)
        {
            if (dgTypeChambre.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                    connection.Open();
                    String requeteNoTypeChambre = "SELECT COUNT(*) FROM chambre WHERE noTypeChambre = @noTypeChambre;";
                    SqlCommand commande = new SqlCommand(requeteNoTypeChambre, connection);
                    String strNoTypeChambre = dgTypeChambre["dgTxtType", dgChambres.CurrentRow.Index].Value.ToString();
                    
                    SqlParameter paramNoTypeChambre = new SqlParameter("@noTypeChambre", strNoTypeChambre);
                    commande.Parameters.Add(paramNoTypeChambre);
                    if ((int)commande.ExecuteScalar() == 0)
                    {
                        typeChambreBindingSource.RemoveCurrent();
                        this.typeChambreTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.typeChambre);
                        

                    }
                    else
                    {
                        MessageBox.Show("La chambre est déja réservée, suppression impossible", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();

                }
            }
            else
                MessageBox.Show("Vous n'avez pas sélectionné de type de chambre", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnModifierTypeChambre_Click(object sender, EventArgs e)
        {
            try {
                this.Validate();
                this.typeChambreBindingSource.EndEdit();
                this.typeChambreTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.typeChambre);
                
            }
  

             catch (DBConcurrencyException erreur)
            {
                String noTypeChambre = erreur.Row["dgTxtNoTypeChambre"].ToString(); 
                MessageBox.Show("Conflit d'accès pour le type " + noTypeChambre + ", Aucun enregistrement possible ", "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void dgTypeChambre_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            String txtDescription = dgTypeChambre["dgTxtDescription", e.RowIndex].Value.ToString();
            String txtPrixMoyen = dgTypeChambre["dgTxtPrixMoyen", e.RowIndex].Value.ToString();
            String txtPrixBas = dgTypeChambre["dgTxtPrixBas", e.RowIndex].Value.ToString();
            String txtPrixHaut = dgTypeChambre["dgTxtPrixHaut", e.RowIndex].Value.ToString();
            decimal dcPrixMoyen=0;
            decimal dcPrixHaut=0;
            decimal dcPrixBas=0;
            Boolean boolDecimalPM = Decimal.TryParse(txtPrixMoyen, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture,out dcPrixMoyen);
            Boolean boolDecimalH = Decimal.TryParse(txtPrixHaut, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out dcPrixHaut);
            Boolean boolDecimalB = Decimal.TryParse(txtPrixBas, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out dcPrixBas);
            String strMessage = "";
            if (txtDescription == "")
            {
                strMessage += "La description doit avoir une valeur.";
                e.Cancel = true;
            }
            if (txtPrixBas == "")
            {
                strMessage += "Le prix le plus bas doit avoir une valeur.";
                e.Cancel = true;
            }
            else if (!boolDecimalB)
            {
                strMessage += "Le prix le plus bas doit être de type décimal.";
                e.Cancel = true;
            }
            if (txtPrixMoyen == "")
            {
                strMessage += "Le prix moyen doit avoir une valeur.";
                e.Cancel = true;
            }
            else if (!boolDecimalPM)
            {
                strMessage += "Le prix moyen doit être de type décimal.";
                e.Cancel = true;
            }
            if (txtPrixHaut == "")
            {
                strMessage += "Le prix le plus haut doit avoir une valeur.";
                e.Cancel = true;
            }
            else if (!boolDecimalH)
            {
                strMessage += "Le prix le plus haut doit être de type décimal.";
                e.Cancel = true;
            }
            dgTypeChambre.Rows[e.RowIndex].ErrorText = strMessage;

        }

        private void dgChambres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
