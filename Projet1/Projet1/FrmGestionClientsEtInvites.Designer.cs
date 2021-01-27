namespace Projet1
{
    partial class FrmGestionClientsEtInvites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.btnRetour = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.dgClient = new System.Windows.Forms.DataGridView();
            this.dgTxtNoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtVilleClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPaysClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtAdresseClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtCodePostalClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDateInscriptionClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouterInvite = new System.Windows.Forms.Button();
            this.btnModifierInvite = new System.Windows.Forms.Button();
            this.btnSupprimerInvite = new System.Windows.Forms.Button();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inviteTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.inviteTableAdapter();
            this.dgInvite = new System.Windows.Forms.DataGridView();
            this.dgTxtNoInvite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNomPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoClientInvite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvite)).BeginInit();
            this.SuspendLayout();
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(895, 433);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(118, 23);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.spoonTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // dgClient
            // 
            this.dgClient.AllowUserToAddRows = false;
            this.dgClient.AllowUserToDeleteRows = false;
            this.dgClient.AutoGenerateColumns = false;
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoClient,
            this.dgTxtNomClient,
            this.dgTxtPrenomClient,
            this.dgTxtVilleClient,
            this.dgTxtPaysClient,
            this.dgTxtAdresseClient,
            this.dgTxtCodePostalClient,
            this.dgTxtDateInscriptionClient});
            this.dgClient.DataSource = this.clientBindingSource;
            this.dgClient.Location = new System.Drawing.Point(16, 28);
            this.dgClient.MultiSelect = false;
            this.dgClient.Name = "dgClient";
            this.dgClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClient.Size = new System.Drawing.Size(844, 220);
            this.dgClient.TabIndex = 13;
            this.dgClient.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgClient_RowValidating);
            // 
            // dgTxtNoClient
            // 
            this.dgTxtNoClient.DataPropertyName = "noClient";
            this.dgTxtNoClient.HeaderText = "no. Client";
            this.dgTxtNoClient.Name = "dgTxtNoClient";
            this.dgTxtNoClient.ReadOnly = true;
            // 
            // dgTxtNomClient
            // 
            this.dgTxtNomClient.DataPropertyName = "nom";
            this.dgTxtNomClient.HeaderText = "Nom";
            this.dgTxtNomClient.Name = "dgTxtNomClient";
            // 
            // dgTxtPrenomClient
            // 
            this.dgTxtPrenomClient.DataPropertyName = "prenom";
            this.dgTxtPrenomClient.HeaderText = "Prénom";
            this.dgTxtPrenomClient.Name = "dgTxtPrenomClient";
            // 
            // dgTxtVilleClient
            // 
            this.dgTxtVilleClient.DataPropertyName = "ville";
            this.dgTxtVilleClient.HeaderText = "Ville";
            this.dgTxtVilleClient.Name = "dgTxtVilleClient";
            // 
            // dgTxtPaysClient
            // 
            this.dgTxtPaysClient.DataPropertyName = "pays";
            this.dgTxtPaysClient.HeaderText = "Pays";
            this.dgTxtPaysClient.Name = "dgTxtPaysClient";
            // 
            // dgTxtAdresseClient
            // 
            this.dgTxtAdresseClient.DataPropertyName = "adresse";
            this.dgTxtAdresseClient.HeaderText = "Adresse";
            this.dgTxtAdresseClient.Name = "dgTxtAdresseClient";
            // 
            // dgTxtCodePostalClient
            // 
            this.dgTxtCodePostalClient.DataPropertyName = "codePostal";
            this.dgTxtCodePostalClient.HeaderText = "Code Postal";
            this.dgTxtCodePostalClient.Name = "dgTxtCodePostalClient";
            // 
            // dgTxtDateInscriptionClient
            // 
            this.dgTxtDateInscriptionClient.DataPropertyName = "dateInscription";
            this.dgTxtDateInscriptionClient.HeaderText = "Date d\'inscription";
            this.dgTxtDateInscriptionClient.Name = "dgTxtDateInscriptionClient";
            this.dgTxtDateInscriptionClient.ReadOnly = true;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(895, 62);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(109, 23);
            this.btnAjouterClient.TabIndex = 14;
            this.btnAjouterClient.Text = "Ajouter un client";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(895, 159);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(109, 67);
            this.btnModifierClient.TabIndex = 15;
            this.btnModifierClient.Text = "Sauvegarder les modifications des clients";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(895, 114);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(109, 23);
            this.btnSupprimerClient.TabIndex = 16;
            this.btnSupprimerClient.Text = "Supprimer le client";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Invités";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Clients";
            // 
            // btnAjouterInvite
            // 
            this.btnAjouterInvite.Location = new System.Drawing.Point(424, 300);
            this.btnAjouterInvite.Name = "btnAjouterInvite";
            this.btnAjouterInvite.Size = new System.Drawing.Size(141, 23);
            this.btnAjouterInvite.TabIndex = 19;
            this.btnAjouterInvite.Text = "Ajouter un invité";
            this.btnAjouterInvite.UseVisualStyleBackColor = true;
            this.btnAjouterInvite.Click += new System.EventHandler(this.btnAjouterInvite_Click);
            // 
            // btnModifierInvite
            // 
            this.btnModifierInvite.Location = new System.Drawing.Point(424, 329);
            this.btnModifierInvite.Name = "btnModifierInvite";
            this.btnModifierInvite.Size = new System.Drawing.Size(141, 37);
            this.btnModifierInvite.TabIndex = 20;
            this.btnModifierInvite.Text = "Sauvegarder les modifications des invités";
            this.btnModifierInvite.UseVisualStyleBackColor = true;
            this.btnModifierInvite.Click += new System.EventHandler(this.btnModifierInvite_Click);
            // 
            // btnSupprimerInvite
            // 
            this.btnSupprimerInvite.Location = new System.Drawing.Point(424, 373);
            this.btnSupprimerInvite.Name = "btnSupprimerInvite";
            this.btnSupprimerInvite.Size = new System.Drawing.Size(141, 23);
            this.btnSupprimerInvite.TabIndex = 21;
            this.btnSupprimerInvite.Text = "Supprimer un invité";
            this.btnSupprimerInvite.UseVisualStyleBackColor = true;
            this.btnSupprimerInvite.Click += new System.EventHandler(this.btnSupprimerInvite_Click);
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "fk_client_invite";
            this.inviteBindingSource.DataSource = this.clientBindingSource;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // dgInvite
            // 
            this.dgInvite.AllowUserToAddRows = false;
            this.dgInvite.AllowUserToDeleteRows = false;
            this.dgInvite.AutoGenerateColumns = false;
            this.dgInvite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoInvite,
            this.dgTxtNomPrenom,
            this.dgTxtNoClientInvite});
            this.dgInvite.DataSource = this.inviteBindingSource;
            this.dgInvite.Location = new System.Drawing.Point(16, 289);
            this.dgInvite.Name = "dgInvite";
            this.dgInvite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInvite.Size = new System.Drawing.Size(300, 220);
            this.dgInvite.TabIndex = 21;
            // 
            // dgTxtNoInvite
            // 
            this.dgTxtNoInvite.DataPropertyName = "noInvite";
            this.dgTxtNoInvite.HeaderText = "No. Invite";
            this.dgTxtNoInvite.Name = "dgTxtNoInvite";
            this.dgTxtNoInvite.ReadOnly = true;
            // 
            // dgTxtNomPrenom
            // 
            this.dgTxtNomPrenom.DataPropertyName = "nomPrenom";
            this.dgTxtNomPrenom.HeaderText = "Nom et Prénom";
            this.dgTxtNomPrenom.Name = "dgTxtNomPrenom";
            // 
            // dgTxtNoClientInvite
            // 
            this.dgTxtNoClientInvite.DataPropertyName = "noClient";
            this.dgTxtNoClientInvite.HeaderText = "noClient";
            this.dgTxtNoClientInvite.Name = "dgTxtNoClientInvite";
            this.dgTxtNoClientInvite.ReadOnly = true;
            // 
            // FrmGestionClientsEtInvites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 585);
            this.Controls.Add(this.dgInvite);
            this.Controls.Add(this.btnSupprimerInvite);
            this.Controls.Add(this.btnModifierInvite);
            this.Controls.Add(this.btnAjouterInvite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.dgClient);
            this.Controls.Add(this.btnRetour);
            this.Name = "FrmGestionClientsEtInvites";
            this.Text = "Gestion des clients et des invités";
            this.Load += new System.EventHandler(this.FrmGestionClientsEtInvites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouterInvite;
        private System.Windows.Forms.Button btnModifierInvite;
        private System.Windows.Forms.Button btnSupprimerInvite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtVilleClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPaysClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtAdresseClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtCodePostalClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateInscriptionClient;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.inviteTableAdapter inviteTableAdapter;
        private System.Windows.Forms.DataGridView dgInvite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoInvite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNomPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoClientInvite;
    }
}