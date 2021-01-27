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
    public partial class frmAjouterAssistant : Form
    {
        public BD5B6TP1_BrodeurLussierDataSet.assistantRow unAssistant;
        public frmAjouterAssistant()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);

        }

        private void assistantBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_BrodeurLussierDataSet);

        }

        private void frmAjouterAssistant_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.assistant);

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {

            if (txtNom.Text.Trim() == "")
                errMessage.SetError(txtNom, " Le nom ne peut pas être vide");
            else
            {
                errMessage.SetError(txtNom, "");
                if (txtPrenom.Text.Trim() == "")
                    errMessage.SetError(txtPrenom, " Le prénom ne peut pas être vide");
                else
                {
                    errMessage.SetError(txtPrenom, "");
                    if (txtSpecialites.Text.Trim() == "")
                        errMessage.SetError(txtSpecialites, " L'assistant doit avoir une spécialité");
                    else
                    {
                        errMessage.SetError(txtSpecialites, "");
                        unAssistant.nom = txtNom.Text;
                        unAssistant.prenom = txtPrenom.Text;
                        unAssistant.specialites = txtSpecialites.Text;
                        unAssistant.remarques = txtRemarques.Text;
                        this.Close();
                    }
                }



            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
