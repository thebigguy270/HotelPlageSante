using System;
using System.Windows.Forms;

namespace Projet1
{
    public partial class FrmMenuAdmin : Form
    {
        public FrmConnexion frmConnexion;
        public String mdp;
        public String noU;
        public FrmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnGererUtilisateurs_Click(object sender, EventArgs e)
        {
            FrmGestionUtilisateur frmU = new FrmGestionUtilisateur();
            frmU.noU = noU;
            frmU.mdp = mdp;
            this.Hide();
            (frmU).ShowDialog();
            this.Show();
        }

        private void btnGererClientsEtInvites_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FrmGestionClientsEtInvites()).ShowDialog();
            this.Show();
        }

        private void btnGererAssistantsEtSoins_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FrmGestionAssistantsEtSoins()).ShowDialog();
            this.Show();
        }

        private void btnGererSoins_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FrmGestionSoins()).ShowDialog();
            this.Show();
        }

        private void btnPlanifierSoins_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FrmPlanificationSoins()).ShowDialog();
            this.Show();
        }

        private void btnGererChambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FrmGestionChambresEtTypesChambres()).ShowDialog();
            this.Show();
        }

        private void btnReserverChambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FrmReservationChambres()).ShowDialog();
            this.Show();
        }

        private void btnVisualiserRapports_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FrmVisualisationRapports()).ShowDialog();
            this.Show();
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConnexion.Show();
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            bD5B6TP1_BrodeurLussierDataSet.assistant.WriteXml("assistant.xml");
            bD5B6TP1_BrodeurLussierDataSet.soin.WriteXml("soin.xml");
            bD5B6TP1_BrodeurLussierDataSet.chambre.WriteXml("chambre.xml");
            bD5B6TP1_BrodeurLussierDataSet.client.WriteXml("client.xml");
            bD5B6TP1_BrodeurLussierDataSet.invite.WriteXml("invite.xml");
            bD5B6TP1_BrodeurLussierDataSet.planifSoin.WriteXml("planifSoin.xml");
            bD5B6TP1_BrodeurLussierDataSet.reservationChambre.WriteXml("reservationChambre.xml");
            bD5B6TP1_BrodeurLussierDataSet.typeChambre.WriteXml("typeChambre.xml");
            bD5B6TP1_BrodeurLussierDataSet.typeSoin.WriteXml("typeSoin.xml");
            bD5B6TP1_BrodeurLussierDataSet.typeUtilisateur.WriteXml("typeUtilisateur.xml");
            bD5B6TP1_BrodeurLussierDataSet.utilisateur.WriteXml("utilisateur.xml");
            Application.Exit();
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
