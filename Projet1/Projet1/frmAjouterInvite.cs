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
    public partial class frmAjouterInvite : Form
    {
        public BD5B6TP1_BrodeurLussierDataSet.inviteRow unInvite; 
        public int compteurclient;
        public frmAjouterInvite()
        {
            InitializeComponent();
        }

        private void frmAjouterInvite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD5B6TP1_BrodeurLussierDataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bD5B6TP1_BrodeurLussierDataSet.client);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            String strNomPrenom = tbNomPrenom.Text;
           
            Boolean boolNom = (strNomPrenom != "");
            
            //noInvite



            if (!boolNom)
            {
                errMessage.SetError(tbNomPrenom, "Le nom ne peut pas être nul.");
            }

            
            else
            {



                //noInvite

                //Reprendre noInvite effacé
                List<Decimal> decInvite = new List<Decimal>();
                Decimal decNoInviteRetire = 0;
                    Boolean boolTabDecContientNoClient = false;
                    Decimal noInviteMax = 0;
                    foreach (BD5B6TP1_BrodeurLussierDataSet.inviteRow uneLigne in bD5B6TP1_BrodeurLussierDataSet.invite.Rows)
                    {
                        if (uneLigne.noClient == unInvite.noClient)
                        {
                            if (uneLigne.noInvite > noInviteMax)
                            {
                                noInviteMax = uneLigne.noInvite;
                                decInvite.Add(uneLigne.noInvite);
                            }
                        }
                    }

                    for(int i= Convert.ToInt32(unInvite.noClient)+1; i < noInviteMax; i++)
                    {
                        if (decInvite.Contains(Convert.ToDecimal(i)))
                        {
                            decNoInviteRetire = Convert.ToDecimal(i);
                            boolTabDecContientNoClient = true;
                            break;
                        }
                    }

                    
                    if(boolTabDecContientNoClient == true)
                    {
                        unInvite.noInvite = decNoInviteRetire;
                        decInvite.Remove(decNoInviteRetire);
                    }
                    else
                    {
                        unInvite.noInvite = int.Parse(Convert.ToString(unInvite.noClient)) + compteurclient + 1;
                    }
                unInvite.nomPrenom = strNomPrenom;
                this.Close();
            }
        }
    }
}
