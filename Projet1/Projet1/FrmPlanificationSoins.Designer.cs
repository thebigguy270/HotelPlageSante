namespace Projet1
{
    partial class FrmPlanificationSoins
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
            this.planifSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1BrodeurLussierDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planifSoinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.planifSoinTableAdapter();
            this.clientTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientTableAdapter();
            this.invitesEtClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invitesEtClientsTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.invitesEtClientsTableAdapter();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.ddlNoEtNomInviteClient = new System.Windows.Forms.ComboBox();
            this.ddlSoin = new System.Windows.Forms.ComboBox();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1BrodeurLussierDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitesEtClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planifSoinBindingSource
            // 
            this.planifSoinBindingSource.DataMember = "planifSoin";
            this.planifSoinBindingSource.DataSource = this.bD5B6TP1BrodeurLussierDataSetBindingSource;
            // 
            // bD5B6TP1BrodeurLussierDataSetBindingSource
            // 
            this.bD5B6TP1BrodeurLussierDataSetBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            this.bD5B6TP1BrodeurLussierDataSetBindingSource.Position = 0;
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.bD5B6TP1BrodeurLussierDataSetBindingSource;
            // 
            // planifSoinTableAdapter
            // 
            this.planifSoinTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // invitesEtClientsBindingSource
            // 
            this.invitesEtClientsBindingSource.DataMember = "invitesEtClients";
            this.invitesEtClientsBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // invitesEtClientsTableAdapter
            // 
            this.invitesEtClientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = this.planifSoinTableAdapter;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // ddlNoEtNomInviteClient
            // 
            this.ddlNoEtNomInviteClient.DataSource = this.invitesEtClientsBindingSource;
            this.ddlNoEtNomInviteClient.DisplayMember = "nomPrenom";
            this.ddlNoEtNomInviteClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNoEtNomInviteClient.FormattingEnabled = true;
            this.ddlNoEtNomInviteClient.Location = new System.Drawing.Point(98, 43);
            this.ddlNoEtNomInviteClient.Name = "ddlNoEtNomInviteClient";
            this.ddlNoEtNomInviteClient.Size = new System.Drawing.Size(121, 21);
            this.ddlNoEtNomInviteClient.TabIndex = 0;
            this.ddlNoEtNomInviteClient.ValueMember = "noPersonne";
            // 
            // ddlSoin
            // 
            this.ddlSoin.DataSource = this.soinBindingSource;
            this.ddlSoin.DisplayMember = "description";
            this.ddlSoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSoin.FormattingEnabled = true;
            this.ddlSoin.Location = new System.Drawing.Point(98, 70);
            this.ddlSoin.Name = "ddlSoin";
            this.ddlSoin.Size = new System.Drawing.Size(121, 21);
            this.ddlSoin.TabIndex = 1;
            this.ddlSoin.ValueMember = "noSoin";
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "soin";
            this.soinBindingSource.DataSource = this.bD5B6TP1BrodeurLussierDataSetBindingSource;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client/Invité:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soin:";
            // 
            // FrmPlanificationSoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlSoin);
            this.Controls.Add(this.ddlNoEtNomInviteClient);
            this.Name = "FrmPlanificationSoins";
            this.Text = "Planification des soins";
            this.Load += new System.EventHandler(this.FrmPlanificationSoins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1BrodeurLussierDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitesEtClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bD5B6TP1BrodeurLussierDataSetBindingSource;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource planifSoinBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.planifSoinTableAdapter planifSoinTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource invitesEtClientsBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.invitesEtClientsTableAdapter invitesEtClientsTableAdapter;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ddlNoEtNomInviteClient;
        private System.Windows.Forms.ComboBox ddlSoin;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}