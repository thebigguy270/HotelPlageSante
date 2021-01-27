namespace Projet1
{
    partial class FrmGestionAssistantsEtSoins
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
            this.assistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.dgAssistants = new System.Windows.Forms.DataGridView();
            this.dgTxtAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtSpecialites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtRemarques = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spoonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spoonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjoutAssist = new System.Windows.Forms.Button();
            this.btnModifierAssist = new System.Windows.Forms.Button();
            this.btnSupprimerAssist = new System.Windows.Forms.Button();
            this.planifSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noSoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.typeSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.assistantSoinTableAdapter();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.assistantTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.assistantTableAdapter();
            this.soinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinTableAdapter();
            this.typeSoinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeSoinTableAdapter();
            this.planifSoinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.planifSoinTableAdapter();
            this.btnAjouterSoin = new System.Windows.Forms.Button();
            this.btnSupprimerSoin = new System.Windows.Forms.Button();
            this.spoonTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.spoonTableAdapter();
            this.dgSoins = new System.Windows.Forms.DataGridView();
            this.dgTxtNoAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoSoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spoonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRetour = new System.Windows.Forms.Button();
            this.soinSansAssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinSansAssistantTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinSansAssistantTableAdapter();
            this.soinSansAssistantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantSoinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssistants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinSansAssistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinSansAssistantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // assistantSoinBindingSource
            // 
            this.assistantSoinBindingSource.DataMember = "assistantSoin";
            this.assistantSoinBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgAssistants
            // 
            this.dgAssistants.AllowUserToAddRows = false;
            this.dgAssistants.AllowUserToDeleteRows = false;
            this.dgAssistants.AutoGenerateColumns = false;
            this.dgAssistants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAssistants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtAssistant,
            this.dgTxtPrenom,
            this.dgTxtNom,
            this.dgTxtSpecialites,
            this.dgTxtRemarques});
            this.dgAssistants.DataSource = this.assistantBindingSource;
            this.dgAssistants.Location = new System.Drawing.Point(24, 34);
            this.dgAssistants.MultiSelect = false;
            this.dgAssistants.Name = "dgAssistants";
            this.dgAssistants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAssistants.Size = new System.Drawing.Size(665, 220);
            this.dgAssistants.TabIndex = 1;
            this.dgAssistants.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgAssistants_RowValidating);
            // 
            // dgTxtAssistant
            // 
            this.dgTxtAssistant.DataPropertyName = "noAssistant";
            this.dgTxtAssistant.HeaderText = "no. Assistant";
            this.dgTxtAssistant.Name = "dgTxtAssistant";
            this.dgTxtAssistant.ReadOnly = true;
            // 
            // dgTxtPrenom
            // 
            this.dgTxtPrenom.DataPropertyName = "prenom";
            this.dgTxtPrenom.HeaderText = "Prénom";
            this.dgTxtPrenom.Name = "dgTxtPrenom";
            // 
            // dgTxtNom
            // 
            this.dgTxtNom.DataPropertyName = "nom";
            this.dgTxtNom.HeaderText = "Nom";
            this.dgTxtNom.Name = "dgTxtNom";
            // 
            // dgTxtSpecialites
            // 
            this.dgTxtSpecialites.DataPropertyName = "specialites";
            this.dgTxtSpecialites.HeaderText = "Spécialités";
            this.dgTxtSpecialites.Name = "dgTxtSpecialites";
            // 
            // dgTxtRemarques
            // 
            this.dgTxtRemarques.DataPropertyName = "remarques";
            this.dgTxtRemarques.HeaderText = "Remarques";
            this.dgTxtRemarques.Name = "dgTxtRemarques";
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "assistant";
            this.assistantBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // spoonBindingSource1
            // 
            this.spoonBindingSource1.DataSource = this.spoonBindingSource;
            // 
            // spoonBindingSource
            // 
            this.spoonBindingSource.DataMember = "spoon";
            this.spoonBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // btnAjoutAssist
            // 
            this.btnAjoutAssist.Location = new System.Drawing.Point(696, 71);
            this.btnAjoutAssist.Name = "btnAjoutAssist";
            this.btnAjoutAssist.Size = new System.Drawing.Size(121, 23);
            this.btnAjoutAssist.TabIndex = 3;
            this.btnAjoutAssist.Text = "Ajouter assistant";
            this.btnAjoutAssist.UseVisualStyleBackColor = true;
            this.btnAjoutAssist.Click += new System.EventHandler(this.btnAjoutAssist_Click);
            // 
            // btnModifierAssist
            // 
            this.btnModifierAssist.Location = new System.Drawing.Point(696, 101);
            this.btnModifierAssist.Name = "btnModifierAssist";
            this.btnModifierAssist.Size = new System.Drawing.Size(121, 51);
            this.btnModifierAssist.TabIndex = 4;
            this.btnModifierAssist.Text = "Sauvegarder les modifications des assistants";
            this.btnModifierAssist.UseVisualStyleBackColor = true;
            this.btnModifierAssist.Click += new System.EventHandler(this.btnModifierAssist_Click);
            // 
            // btnSupprimerAssist
            // 
            this.btnSupprimerAssist.CausesValidation = false;
            this.btnSupprimerAssist.Location = new System.Drawing.Point(695, 158);
            this.btnSupprimerAssist.Name = "btnSupprimerAssist";
            this.btnSupprimerAssist.Size = new System.Drawing.Size(122, 23);
            this.btnSupprimerAssist.TabIndex = 5;
            this.btnSupprimerAssist.Text = "Supprimer l\'assistant";
            this.btnSupprimerAssist.UseVisualStyleBackColor = true;
            this.btnSupprimerAssist.Click += new System.EventHandler(this.btnSupprimerAssist_Click);
            // 
            // planifSoinBindingSource
            // 
            this.planifSoinBindingSource.DataMember = "planifSoin";
            this.planifSoinBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // noSoinDataGridViewTextBoxColumn
            // 
            this.noSoinDataGridViewTextBoxColumn.DataPropertyName = "noSoin";
            this.noSoinDataGridViewTextBoxColumn.HeaderText = "noSoin";
            this.noSoinDataGridViewTextBoxColumn.Name = "noSoinDataGridViewTextBoxColumn";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // typeSoinBindingSource
            // 
            this.typeSoinBindingSource.DataMember = "typeSoin";
            this.typeSoinBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // assistantSoinTableAdapter
            // 
            this.assistantSoinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = this.assistantSoinTableAdapter;
            this.tableAdapterManager.assistantTableAdapter = this.assistantTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinSansAssistantTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.spoonTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = this.typeSoinTableAdapter;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // typeSoinTableAdapter
            // 
            this.typeSoinTableAdapter.ClearBeforeFill = true;
            // 
            // planifSoinTableAdapter
            // 
            this.planifSoinTableAdapter.ClearBeforeFill = true;
            // 
            // btnAjouterSoin
            // 
            this.btnAjouterSoin.Location = new System.Drawing.Point(696, 294);
            this.btnAjouterSoin.Name = "btnAjouterSoin";
            this.btnAjouterSoin.Size = new System.Drawing.Size(121, 23);
            this.btnAjouterSoin.TabIndex = 7;
            this.btnAjouterSoin.Text = "Ajouter Soin";
            this.btnAjouterSoin.UseVisualStyleBackColor = true;
            this.btnAjouterSoin.Click += new System.EventHandler(this.btnAjouterSoinAAssistant);
            // 
            // btnSupprimerSoin
            // 
            this.btnSupprimerSoin.Location = new System.Drawing.Point(696, 324);
            this.btnSupprimerSoin.Name = "btnSupprimerSoin";
            this.btnSupprimerSoin.Size = new System.Drawing.Size(121, 23);
            this.btnSupprimerSoin.TabIndex = 8;
            this.btnSupprimerSoin.Text = "Supprimer Soin";
            this.btnSupprimerSoin.UseVisualStyleBackColor = true;
            this.btnSupprimerSoin.Click += new System.EventHandler(this.button2_Click);
            // 
            // spoonTableAdapter
            // 
            this.spoonTableAdapter.ClearBeforeFill = true;
            // 
            // dgSoins
            // 
            this.dgSoins.AllowUserToAddRows = false;
            this.dgSoins.AllowUserToDeleteRows = false;
            this.dgSoins.AutoGenerateColumns = false;
            this.dgSoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoAssistant,
            this.dgTxtNoSoin,
            this.dgTxtDescription});
            this.dgSoins.DataSource = this.spoonBindingSource2;
            this.dgSoins.Location = new System.Drawing.Point(24, 284);
            this.dgSoins.Name = "dgSoins";
            this.dgSoins.ReadOnly = true;
            this.dgSoins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoins.Size = new System.Drawing.Size(668, 220);
            this.dgSoins.TabIndex = 8;
            // 
            // dgTxtNoAssistant
            // 
            this.dgTxtNoAssistant.DataPropertyName = "noAssistant";
            this.dgTxtNoAssistant.HeaderText = "noAssistant";
            this.dgTxtNoAssistant.Name = "dgTxtNoAssistant";
            this.dgTxtNoAssistant.ReadOnly = true;
            this.dgTxtNoAssistant.Visible = false;
            // 
            // dgTxtNoSoin
            // 
            this.dgTxtNoSoin.DataPropertyName = "noSoin";
            this.dgTxtNoSoin.HeaderText = "No. Soin";
            this.dgTxtNoSoin.Name = "dgTxtNoSoin";
            this.dgTxtNoSoin.ReadOnly = true;
            // 
            // dgTxtDescription
            // 
            this.dgTxtDescription.DataPropertyName = "description";
            this.dgTxtDescription.HeaderText = "Description";
            this.dgTxtDescription.Name = "dgTxtDescription";
            this.dgTxtDescription.ReadOnly = true;
            // 
            // spoonBindingSource2
            // 
            this.spoonBindingSource2.DataMember = "fk_assistant_assistantSoin3";
            this.spoonBindingSource2.DataSource = this.assistantBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Assistants:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soins associés";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(699, 480);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(118, 23);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // soinSansAssistantBindingSource
            // 
            this.soinSansAssistantBindingSource.DataMember = "soinSansAssistant";
            this.soinSansAssistantBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // soinSansAssistantTableAdapter
            // 
            this.soinSansAssistantTableAdapter.ClearBeforeFill = true;
            // 
            // soinSansAssistantDataGridView
            // 
            this.soinSansAssistantDataGridView.AutoGenerateColumns = false;
            this.soinSansAssistantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soinSansAssistantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.soinSansAssistantDataGridView.DataSource = this.soinSansAssistantBindingSource;
            this.soinSansAssistantDataGridView.Location = new System.Drawing.Point(824, 520);
            this.soinSansAssistantDataGridView.Name = "soinSansAssistantDataGridView";
            this.soinSansAssistantDataGridView.Size = new System.Drawing.Size(300, 220);
            this.soinSansAssistantDataGridView.TabIndex = 11;
            this.soinSansAssistantDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "noSoin";
            this.dataGridViewTextBoxColumn1.HeaderText = "noSoin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // assistantSoinDataGridView
            // 
            this.assistantSoinDataGridView.AutoGenerateColumns = false;
            this.assistantSoinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistantSoinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.assistantSoinDataGridView.DataSource = this.assistantSoinBindingSource;
            this.assistantSoinDataGridView.Location = new System.Drawing.Point(24, 559);
            this.assistantSoinDataGridView.Name = "assistantSoinDataGridView";
            this.assistantSoinDataGridView.Size = new System.Drawing.Size(300, 220);
            this.assistantSoinDataGridView.TabIndex = 11;
            this.assistantSoinDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "noAssistant";
            this.dataGridViewTextBoxColumn2.HeaderText = "noAssistant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "noSoin";
            this.dataGridViewTextBoxColumn3.HeaderText = "noSoin";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FrmGestionAssistantsEtSoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 838);
            this.Controls.Add(this.assistantSoinDataGridView);
            this.Controls.Add(this.soinSansAssistantDataGridView);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSoins);
            this.Controls.Add(this.btnSupprimerSoin);
            this.Controls.Add(this.btnAjouterSoin);
            this.Controls.Add(this.btnSupprimerAssist);
            this.Controls.Add(this.btnModifierAssist);
            this.Controls.Add(this.btnAjoutAssist);
            this.Controls.Add(this.dgAssistants);
            this.Name = "FrmGestionAssistantsEtSoins";
            this.Text = "Gestion des assistants et des soins";
            this.Load += new System.EventHandler(this.FrmGestionAssistantsEtSoins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssistants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinSansAssistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinSansAssistantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.assistantSoinTableAdapter assistantSoinTableAdapter;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.assistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private System.Windows.Forms.DataGridView dgAssistants;
        private System.Windows.Forms.Button btnAjoutAssist;
        private System.Windows.Forms.Button btnModifierAssist;
        private System.Windows.Forms.Button btnSupprimerAssist;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeSoinTableAdapter typeSoinTableAdapter;
        private System.Windows.Forms.BindingSource typeSoinBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.planifSoinTableAdapter planifSoinTableAdapter;
        private System.Windows.Forms.BindingSource planifSoinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSupprimerSoin;
        private System.Windows.Forms.Button btnAjouterSoin;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.spoonTableAdapter spoonTableAdapter;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private System.Windows.Forms.BindingSource spoonBindingSource1;
        private System.Windows.Forms.BindingSource spoonBindingSource;
        private System.Windows.Forms.DataGridView dgSoins;
        private System.Windows.Forms.BindingSource spoonBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtSpecialites;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtRemarques;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDescription;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.BindingSource soinSansAssistantBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinSansAssistantTableAdapter soinSansAssistantTableAdapter;
        private System.Windows.Forms.DataGridView soinSansAssistantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView assistantSoinDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}