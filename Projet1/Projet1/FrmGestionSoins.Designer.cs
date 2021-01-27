namespace Projet1
{
    partial class FrmGestionSoins
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
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinTableAdapter();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.dgSoins = new System.Windows.Forms.DataGridView();
            this.dgTxtNoSoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDuree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtTypeSoin = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgTxtPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterSoin = new System.Windows.Forms.Button();
            this.btnModifierSoin = new System.Windows.Forms.Button();
            this.btnSupprimerSoin = new System.Windows.Forms.Button();
            this.typeSoinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeSoinTableAdapter();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "soin";
            this.soinBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.spoonTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // dgSoins
            // 
            this.dgSoins.AllowUserToAddRows = false;
            this.dgSoins.AllowUserToDeleteRows = false;
            this.dgSoins.AutoGenerateColumns = false;
            this.dgSoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoSoin,
            this.dgTxtDescription,
            this.dgTxtDuree,
            this.dgTxtTypeSoin,
            this.dgTxtPrix});
            this.dgSoins.DataSource = this.soinBindingSource;
            this.dgSoins.Location = new System.Drawing.Point(12, 12);
            this.dgSoins.MultiSelect = false;
            this.dgSoins.Name = "dgSoins";
            this.dgSoins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoins.Size = new System.Drawing.Size(547, 220);
            this.dgSoins.TabIndex = 1;
            this.dgSoins.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgSoins_RowValidating);
            // 
            // dgTxtNoSoin
            // 
            this.dgTxtNoSoin.DataPropertyName = "noSoin";
            this.dgTxtNoSoin.HeaderText = "noSoin";
            this.dgTxtNoSoin.Name = "dgTxtNoSoin";
            this.dgTxtNoSoin.ReadOnly = true;
            // 
            // dgTxtDescription
            // 
            this.dgTxtDescription.DataPropertyName = "description";
            this.dgTxtDescription.HeaderText = "description";
            this.dgTxtDescription.Name = "dgTxtDescription";
            // 
            // dgTxtDuree
            // 
            this.dgTxtDuree.DataPropertyName = "duree";
            this.dgTxtDuree.HeaderText = "duree";
            this.dgTxtDuree.Name = "dgTxtDuree";
            // 
            // dgTxtTypeSoin
            // 
            this.dgTxtTypeSoin.DataPropertyName = "noTypeSoin";
            this.dgTxtTypeSoin.DataSource = this.typeSoinBindingSource;
            this.dgTxtTypeSoin.DisplayMember = "noTypeSoin";
            this.dgTxtTypeSoin.HeaderText = "noTypeSoin";
            this.dgTxtTypeSoin.Name = "dgTxtTypeSoin";
            this.dgTxtTypeSoin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTxtTypeSoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgTxtTypeSoin.ValueMember = "noTypeSoin";
            // 
            // typeSoinBindingSource
            // 
            this.typeSoinBindingSource.DataMember = "typeSoin";
            this.typeSoinBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // dgTxtPrix
            // 
            this.dgTxtPrix.DataPropertyName = "prix";
            this.dgTxtPrix.HeaderText = "prix";
            this.dgTxtPrix.Name = "dgTxtPrix";
            // 
            // btnAjouterSoin
            // 
            this.btnAjouterSoin.Location = new System.Drawing.Point(565, 59);
            this.btnAjouterSoin.Name = "btnAjouterSoin";
            this.btnAjouterSoin.Size = new System.Drawing.Size(131, 23);
            this.btnAjouterSoin.TabIndex = 2;
            this.btnAjouterSoin.Text = "Ajouter Soin";
            this.btnAjouterSoin.UseVisualStyleBackColor = true;
            this.btnAjouterSoin.Click += new System.EventHandler(this.btnAjouterSoin_Click);
            // 
            // btnModifierSoin
            // 
            this.btnModifierSoin.Location = new System.Drawing.Point(565, 89);
            this.btnModifierSoin.Name = "btnModifierSoin";
            this.btnModifierSoin.Size = new System.Drawing.Size(131, 54);
            this.btnModifierSoin.TabIndex = 3;
            this.btnModifierSoin.Text = "Sauvegarder les modifications des soins";
            this.btnModifierSoin.UseVisualStyleBackColor = true;
            this.btnModifierSoin.Click += new System.EventHandler(this.btnModifierSoin_Click);
            // 
            // btnSupprimerSoin
            // 
            this.btnSupprimerSoin.Location = new System.Drawing.Point(564, 149);
            this.btnSupprimerSoin.Name = "btnSupprimerSoin";
            this.btnSupprimerSoin.Size = new System.Drawing.Size(132, 23);
            this.btnSupprimerSoin.TabIndex = 4;
            this.btnSupprimerSoin.Text = "Supprimer Soin";
            this.btnSupprimerSoin.UseVisualStyleBackColor = true;
            this.btnSupprimerSoin.Click += new System.EventHandler(this.btnSupprimerSoin_Click);
            // 
            // typeSoinTableAdapter
            // 
            this.typeSoinTableAdapter.ClearBeforeFill = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(565, 209);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(131, 23);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmGestionSoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 335);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimerSoin);
            this.Controls.Add(this.btnModifierSoin);
            this.Controls.Add(this.btnAjouterSoin);
            this.Controls.Add(this.dgSoins);
            this.Name = "FrmGestionSoins";
            this.Text = "FrmGestionSoins";
            this.Load += new System.EventHandler(this.FrmGestionSoins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgSoins;
        private System.Windows.Forms.Button btnAjouterSoin;
        private System.Windows.Forms.Button btnModifierSoin;
        private System.Windows.Forms.Button btnSupprimerSoin;
        private System.Windows.Forms.BindingSource typeSoinBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeSoinTableAdapter typeSoinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDuree;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgTxtTypeSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrix;
        private System.Windows.Forms.Button btnRetour;
    }
}