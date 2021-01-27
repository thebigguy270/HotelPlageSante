namespace Projet1
{
    partial class FrmGestionUtilisateur
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.dgTxtNoUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtMDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCbType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterUtilisateur = new System.Windows.Forms.Button();
            this.btnModifierUtilisateur = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.utilisateurTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.utilisateurTableAdapter();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.typeUtilisateurTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeUtilisateurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(526, 184);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(185, 23);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.AllowUserToAddRows = false;
            this.dgUtilisateur.AutoGenerateColumns = false;
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoUtilisateur,
            this.dgTxtNomUtilisateur,
            this.dgTxtMDP,
            this.dgCbType});
            this.dgUtilisateur.DataSource = this.utilisateurBindingSource;
            this.dgUtilisateur.Location = new System.Drawing.Point(26, 12);
            this.dgUtilisateur.MultiSelect = false;
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUtilisateur.Size = new System.Drawing.Size(443, 220);
            this.dgUtilisateur.TabIndex = 13;
            this.dgUtilisateur.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.utilisateurDataGridView_RowValidating);
            // 
            // dgTxtNoUtilisateur
            // 
            this.dgTxtNoUtilisateur.DataPropertyName = "noUtilisateur";
            this.dgTxtNoUtilisateur.HeaderText = "N. Utilisateur";
            this.dgTxtNoUtilisateur.Name = "dgTxtNoUtilisateur";
            this.dgTxtNoUtilisateur.ReadOnly = true;
            // 
            // dgTxtNomUtilisateur
            // 
            this.dgTxtNomUtilisateur.DataPropertyName = "nomUtilisateur";
            this.dgTxtNomUtilisateur.HeaderText = "Nom D\'Utilisateur";
            this.dgTxtNomUtilisateur.Name = "dgTxtNomUtilisateur";
            this.dgTxtNomUtilisateur.ReadOnly = true;
            // 
            // dgTxtMDP
            // 
            this.dgTxtMDP.DataPropertyName = "mdpUtilisateur";
            this.dgTxtMDP.HeaderText = "Mot De Passe";
            this.dgTxtMDP.Name = "dgTxtMDP";
            this.dgTxtMDP.ReadOnly = true;
            // 
            // dgCbType
            // 
            this.dgCbType.DataPropertyName = "noTypeUtilisateur";
            this.dgCbType.DataSource = this.typeUtilisateurBindingSource;
            this.dgCbType.DisplayMember = "identification";
            this.dgCbType.HeaderText = "Type De L\'Utilisateur";
            this.dgCbType.Name = "dgCbType";
            this.dgCbType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCbType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgCbType.ValueMember = "noTypeUtilisateur";
            // 
            // typeUtilisateurBindingSource
            // 
            this.typeUtilisateurBindingSource.DataMember = "typeUtilisateur";
            this.typeUtilisateurBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // btnAjouterUtilisateur
            // 
            this.btnAjouterUtilisateur.Location = new System.Drawing.Point(526, 46);
            this.btnAjouterUtilisateur.Name = "btnAjouterUtilisateur";
            this.btnAjouterUtilisateur.Size = new System.Drawing.Size(185, 23);
            this.btnAjouterUtilisateur.TabIndex = 14;
            this.btnAjouterUtilisateur.Text = "Ajouter l\'utilisateur";
            this.btnAjouterUtilisateur.UseVisualStyleBackColor = true;
            this.btnAjouterUtilisateur.Click += new System.EventHandler(this.btnAjouterUtilisateur_Click);
            // 
            // btnModifierUtilisateur
            // 
            this.btnModifierUtilisateur.Location = new System.Drawing.Point(526, 90);
            this.btnModifierUtilisateur.Name = "btnModifierUtilisateur";
            this.btnModifierUtilisateur.Size = new System.Drawing.Size(185, 23);
            this.btnModifierUtilisateur.TabIndex = 15;
            this.btnModifierUtilisateur.Text = "Sauvegarder les modifications";
            this.btnModifierUtilisateur.UseVisualStyleBackColor = true;
            this.btnModifierUtilisateur.Click += new System.EventHandler(this.btnModifierUtilisateur_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Supprimer l\'utilisateur sélectionné";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = this.typeUtilisateurTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = this.utilisateurTableAdapter;
            // 
            // typeUtilisateurTableAdapter
            // 
            this.typeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnModifierUtilisateur);
            this.Controls.Add(this.btnAjouterUtilisateur);
            this.Controls.Add(this.dgUtilisateur);
            this.Controls.Add(this.btnRetour);
            this.Name = "FrmGestionUtilisateur";
            this.Text = "Gesstion Des Utilisateurs";
            this.Load += new System.EventHandler(this.FrmGestionUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeUtilisateurTableAdapter typeUtilisateurTableAdapter;
        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource;
        private System.Windows.Forms.Button btnAjouterUtilisateur;
        private System.Windows.Forms.Button btnModifierUtilisateur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtMDP;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgCbType;
    }
}