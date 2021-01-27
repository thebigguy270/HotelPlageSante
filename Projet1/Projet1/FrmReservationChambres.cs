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
    public partial class FrmReservationChambres : Form
    {

        public FrmReservationChambres()
        {
            InitializeComponent();
        }

        private void FrmReservationChambres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet2.clientNoms'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientNomsTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.clientNoms);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet2.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter1.Fill(this.bD5B6TP1_BrodeurLussierDataSet.client);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet2.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.chambre);
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet2.reservationChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationChambreTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.reservationChambre);


        }

        private void btnSupprimerReservation_Click(object sender, EventArgs e)
        {
            if (dgReservationsChambre.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous vraiment l'effacer?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    DateTime dtReservation = DateTime.Parse(dgReservationsChambre["dgTxtDateArrive", dgReservationsChambre.CurrentRow.Index].Value.ToString());
                    DateTime dtDepart = DateTime.Parse(dgReservationsChambre["dgTxtDateDepart", dgReservationsChambre.CurrentRow.Index].Value.ToString());
                    DateTime dtAJD = DateTime.Now;
                    if (dtReservation.Date < dtAJD.Date)
                    {
                        reservationChambreBindingSource.RemoveCurrent();
                        reservationChambreTableAdapter.Update(bD5B6TP1_BrodeurLussierDataSet.reservationChambre);
                        tableAdapterManager.UpdateAll(bD5B6TP1_BrodeurLussierDataSet);
                        
                    }
                    else
                    {
                        MessageBox.Show("La chambre est réservée avant aujourd'hui, suppression impossible", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAjouterReservation_Click(object sender, EventArgs e)
        {
            String strErreur = "";
            Boolean boolChambreSelect = false;
            Boolean boolDate = true ;
            String strNoChambre = "";
            String strDateDepart = dtpDepart.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String strDateArrivee = dtpArrivee.Value.ToString("yyyy-MM-dd HH:mm:ss");
            
            if (dtpDepart.Value < dtpArrivee.Value)
            {
                strErreur = "Erreur, le déaprt doit se produire après l'arrivée";
                errMessageAjoutR.SetError(dgChambres, strErreur);
                boolDate = false;

            }
            if (dgChambres.SelectedRows.Count > 0)
            {
                boolChambreSelect = true;
                strNoChambre = dgChambres["dgTxtNoChambre", dgChambres.CurrentRow.Index].Value.ToString();
            }
            else
            {
                strErreur = "Erreur, vous devrez sélectionner une chambre";
                errMessageAjoutR.SetError(dgChambres, strErreur);
            }
            if (boolChambreSelect&&boolDate)
            {
                SqlConnection connection = new SqlConnection(Projet1.Properties.Settings.Default.BD5B6TP1_BrodeurLussierConnectionString);
                connection.Open();
                String requeteNoChambre = "SELECT COUNT(*) FROM reservationChambre WHERE (noChambre = @noChambre) AND (dateDepart >= '" + strDateArrivee + "') AND (dateArrive <= '" + strDateDepart + "')";
                SqlCommand commande = new SqlCommand(requeteNoChambre, connection);
                
                //MessageBox.Show(strNoChambre);
                SqlParameter paramNoChambre = new SqlParameter("@noChambre", strNoChambre);
                commande.Parameters.Add(paramNoChambre);
                

                string query = commande.CommandText;

                foreach (SqlParameter p in commande.Parameters)
                {
                    try
                    {
                        query = query.Replace(p.ParameterName, p.Value.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                MessageBox.Show(query);
                Int32 chambrescommandees = Convert.ToInt32(commande.ExecuteScalar());

                if (chambrescommandees == 0)
                {
                    
                    BD5B6TP1_BrodeurLussierDataSet.reservationChambreRow uneReservation = bD5B6TP1_BrodeurLussierDataSet.reservationChambre.NewreservationChambreRow();
                    uneReservation.noChambre = Convert.ToDecimal(strNoChambre);
                    uneReservation.dateArrive = Convert.ToDateTime(strDateArrivee);
                    uneReservation.dateDepart = Convert.ToDateTime(strDateDepart);
                    uneReservation.noClient = Convert.ToDecimal(cbClientsNoms.SelectedValue);
                    uneReservation.nbPersonnes = nudPersonnes.Value;
                    bD5B6TP1_BrodeurLussierDataSet.reservationChambre.AddreservationChambreRow(uneReservation);
                    reservationChambreBindingSource.MoveLast();
                    this.reservationChambreTableAdapter.Update(this.bD5B6TP1_BrodeurLussierDataSet.reservationChambre);
                    MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Une chambre est déja réservée ici.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
