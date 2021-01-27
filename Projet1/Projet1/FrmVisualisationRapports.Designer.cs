namespace Projet1
{
    partial class FrmVisualisationRapports
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
            this.invitesEtClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invitesEtClientsTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.invitesEtClientsTableAdapter();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.cbInvitesEtClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rapportABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapportATableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.RapportATableAdapter();
            this.rapportABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rapportADataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMontant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitesEtClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportADataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // cbInvitesEtClients
            // 
            this.cbInvitesEtClients.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invitesEtClientsBindingSource, "noPersonne", true));
            this.cbInvitesEtClients.DataSource = this.invitesEtClientsBindingSource;
            this.cbInvitesEtClients.DisplayMember = "nomPrenom";
            this.cbInvitesEtClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvitesEtClients.FormattingEnabled = true;
            this.cbInvitesEtClients.Location = new System.Drawing.Point(122, 51);
            this.cbInvitesEtClients.Name = "cbInvitesEtClients";
            this.cbInvitesEtClients.Size = new System.Drawing.Size(300, 21);
            this.cbInvitesEtClients.TabIndex = 1;
            this.cbInvitesEtClients.ValueMember = "noPersonne";
            this.cbInvitesEtClients.SelectedIndexChanged += new System.EventHandler(this.cbInvitesEtClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client/Invité:";
            // 
            // rapportABindingSource
            // 
            this.rapportABindingSource.DataSource = this.invitesEtClientsBindingSource;
            // 
            // rapportATableAdapter
            // 
            this.rapportATableAdapter.ClearBeforeFill = true;
            // 
            // rapportABindingSource1
            // 
            this.rapportABindingSource1.DataMember = "invitesEtClients_RapportA";
            this.rapportABindingSource1.DataSource = this.invitesEtClientsBindingSource;
            // 
            // rapportADataGridView1
            // 
            this.rapportADataGridView1.AllowUserToAddRows = false;
            this.rapportADataGridView1.AllowUserToDeleteRows = false;
            this.rapportADataGridView1.AutoGenerateColumns = false;
            this.rapportADataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportADataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.rapportADataGridView1.DataSource = this.rapportABindingSource1;
            this.rapportADataGridView1.Location = new System.Drawing.Point(122, 97);
            this.rapportADataGridView1.Name = "rapportADataGridView1";
            this.rapportADataGridView1.ReadOnly = true;
            this.rapportADataGridView1.Size = new System.Drawing.Size(444, 220);
            this.rapportADataGridView1.TabIndex = 3;
            this.rapportADataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rapportADataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "noPersonne";
            this.dataGridViewTextBoxColumn3.HeaderText = "noPersonne";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description du Soin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "noAssistant";
            this.dataGridViewTextBoxColumn5.HeaderText = "noAssistant";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dateHeure";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date et heure du soin";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "noSoin";
            this.dataGridViewTextBoxColumn7.HeaderText = "noSoin";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "prix";
            this.dataGridViewTextBoxColumn8.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nomCompletAssistant";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nom de l\'assistant";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant Total:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbMontant
            // 
            this.tbMontant.Location = new System.Drawing.Point(132, 417);
            this.tbMontant.Name = "tbMontant";
            this.tbMontant.ReadOnly = true;
            this.tbMontant.Size = new System.Drawing.Size(100, 20);
            this.tbMontant.TabIndex = 6;
            // 
            // FrmVisualisationRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.tbMontant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rapportADataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbInvitesEtClients);
            this.Name = "FrmVisualisationRapports";
            this.Text = "Visualisation du rapport A";
            this.Load += new System.EventHandler(this.FrmVisualisationRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitesEtClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportADataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource invitesEtClientsBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.invitesEtClientsTableAdapter invitesEtClientsTableAdapter;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbInvitesEtClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource rapportABindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.RapportATableAdapter rapportATableAdapter;
        private System.Windows.Forms.BindingSource rapportABindingSource1;
        private System.Windows.Forms.DataGridView rapportADataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMontant;
    }
}