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
    public partial class frmAjouterClient : Form
    {
        public BD5B6TP1_BrodeurLussierDataSet.clientRow unClient;
        public frmAjouterClient()
        {
            InitializeComponent();
        }

        private void frmAjouterClient_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            String strNom = tbNom.Text;
            String strPrenom = tbPrenom.Text;
            String strVille = tbVille.Text;
            String strPays = tbPays.Text;
            String strCP = tbCP.Text;
            String strAdresse = tbAdresse.Text;
            Boolean bNom = true;
            Boolean bPrenom = true;
            Boolean bVille = true;
            Boolean bPays = true;
            Boolean bCP = true;
            Boolean bAdresse = true;
            if (strNom == "")
            {
                errMessage.SetError(tbNom, "Le nom doit avoir une valeur.");
                bNom = false;
            }
            if (strPrenom == "")
            {
                errMessage.SetError(tbPrenom, "Le prénom doit avoir une valeur.");
                bPrenom = false;
            }
            if (strVille == "")
            {
                errMessage.SetError(tbVille, "Le nom de la ville ne peut pas être nul.");
                bVille = false;
            }
            if (strPays == "")
            {
                errMessage.SetError(tbPays, "Le nom du pays ne peut pas être nul.");
                bPays = false;
            }
            if (strCP == "")
            {
                errMessage.SetError(tbCP, "Le prénom doit avoir une valeur");
                bCP = false;
            }
            if (strAdresse == "")
            {
                errMessage.SetError(tbAdresse, "La valeur de l'adresse ne peut pas être nulle.");
                bAdresse = false;
            }
            if (bCP && bNom && bPrenom && bPays && bVille&&bAdresse)
            {
                unClient.dateInscription = DateTime.Now;
                unClient.codePostal = strCP;
                unClient.nom = strNom;
                unClient.pays = strPays;
                unClient.prenom = strPrenom;
                unClient.adresse = strAdresse;
                unClient.ville = strVille;
                this.Close();
            }

        }
    }
}
