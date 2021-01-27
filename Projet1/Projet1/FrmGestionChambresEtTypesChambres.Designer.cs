namespace Projet1
{
    partial class FrmGestionChambresEtTypesChambres
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
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.chambreTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.chambreTableAdapter();
            this.dgChambres = new System.Windows.Forms.DataGridView();
            this.dgTxtNoChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDecorations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoTypeChambre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterChambre = new System.Windows.Forms.Button();
            this.btnModifierChambre = new System.Windows.Forms.Button();
            this.btnSupprimerCHambre = new System.Windows.Forms.Button();
            this.typeChambreTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeChambreTableAdapter();
            this.dgTypeChambre = new System.Windows.Forms.DataGridView();
            this.dgTxtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrixHaut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrixBas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrixMoyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.noTypeChambreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decorations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTypeChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterTypeChambre = new System.Windows.Forms.Button();
            this.btnSupprimerTypeChambre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.btnModifierTypeChambre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTypeChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // dgChambres
            // 
            this.dgChambres.AllowUserToAddRows = false;
            this.dgChambres.AllowUserToDeleteRows = false;
            this.dgChambres.AutoGenerateColumns = false;
            this.dgChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoChambre,
            this.dgTxtNoEmplacement,
            this.dgTxtDecorations,
            this.dgTxtNoTypeChambre});
            this.dgChambres.DataSource = this.chambreBindingSource;
            this.dgChambres.Location = new System.Drawing.Point(22, 36);
            this.dgChambres.MultiSelect = false;
            this.dgChambres.Name = "dgChambres";
            this.dgChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChambres.Size = new System.Drawing.Size(543, 150);
            this.dgChambres.TabIndex = 0;
            this.dgChambres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChambres_CellContentClick);
            this.dgChambres.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgChambres_RowValidating);
            // 
            // dgTxtNoChambre
            // 
            this.dgTxtNoChambre.DataPropertyName = "noChambre";
            this.dgTxtNoChambre.HeaderText = "noChambre";
            this.dgTxtNoChambre.Name = "dgTxtNoChambre";
            this.dgTxtNoChambre.ReadOnly = true;
            this.dgTxtNoChambre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgTxtNoEmplacement
            // 
            this.dgTxtNoEmplacement.DataPropertyName = "emplacement";
            this.dgTxtNoEmplacement.HeaderText = "emplacement";
            this.dgTxtNoEmplacement.Name = "dgTxtNoEmplacement";
            // 
            // dgTxtDecorations
            // 
            this.dgTxtDecorations.DataPropertyName = "decorations";
            this.dgTxtDecorations.HeaderText = "decorations";
            this.dgTxtDecorations.Name = "dgTxtDecorations";
            // 
            // dgTxtNoTypeChambre
            // 
            this.dgTxtNoTypeChambre.DataPropertyName = "noTypeChambre";
            this.dgTxtNoTypeChambre.DataSource = this.typeChambreBindingSource;
            this.dgTxtNoTypeChambre.DisplayMember = "description";
            this.dgTxtNoTypeChambre.HeaderText = "noTypeChambre";
            this.dgTxtNoTypeChambre.Name = "dgTxtNoTypeChambre";
            this.dgTxtNoTypeChambre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTxtNoTypeChambre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgTxtNoTypeChambre.ValueMember = "noTypeChambre";
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "typeChambre";
            this.typeChambreBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // btnAjouterChambre
            // 
            this.btnAjouterChambre.Location = new System.Drawing.Point(591, 79);
            this.btnAjouterChambre.Name = "btnAjouterChambre";
            this.btnAjouterChambre.Size = new System.Drawing.Size(143, 23);
            this.btnAjouterChambre.TabIndex = 1;
            this.btnAjouterChambre.Text = "Ajouter chambre";
            this.btnAjouterChambre.UseVisualStyleBackColor = true;
            this.btnAjouterChambre.Click += new System.EventHandler(this.btnAjouterChambre_Click);
            // 
            // btnModifierChambre
            // 
            this.btnModifierChambre.Location = new System.Drawing.Point(591, 108);
            this.btnModifierChambre.Name = "btnModifierChambre";
            this.btnModifierChambre.Size = new System.Drawing.Size(143, 49);
            this.btnModifierChambre.TabIndex = 2;
            this.btnModifierChambre.Text = "Sauvegarder les modifications des chambres";
            this.btnModifierChambre.UseVisualStyleBackColor = true;
            this.btnModifierChambre.Click += new System.EventHandler(this.btnModifierChambre_Click);
            // 
            // btnSupprimerCHambre
            // 
            this.btnSupprimerCHambre.Location = new System.Drawing.Point(591, 163);
            this.btnSupprimerCHambre.Name = "btnSupprimerCHambre";
            this.btnSupprimerCHambre.Size = new System.Drawing.Size(143, 23);
            this.btnSupprimerCHambre.TabIndex = 3;
            this.btnSupprimerCHambre.Text = "Supprimer Chambre";
            this.btnSupprimerCHambre.UseVisualStyleBackColor = true;
            this.btnSupprimerCHambre.Click += new System.EventHandler(this.btnSupprimerCHambre_Click);
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // dgTypeChambre
            // 
            this.dgTypeChambre.AllowUserToAddRows = false;
            this.dgTypeChambre.AllowUserToDeleteRows = false;
            this.dgTypeChambre.AutoGenerateColumns = false;
            this.dgTypeChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTypeChambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtType,
            this.dgTxtDescription,
            this.dgTxtPrixHaut,
            this.dgTxtPrixBas,
            this.dgTxtPrixMoyen});
            this.dgTypeChambre.DataSource = this.typeChambreBindingSource;
            this.dgTypeChambre.Location = new System.Drawing.Point(22, 224);
            this.dgTypeChambre.MultiSelect = false;
            this.dgTypeChambre.Name = "dgTypeChambre";
            this.dgTypeChambre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTypeChambre.Size = new System.Drawing.Size(543, 150);
            this.dgTypeChambre.TabIndex = 4;
            this.dgTypeChambre.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgTypeChambre_RowValidating);
            // 
            // dgTxtType
            // 
            this.dgTxtType.DataPropertyName = "noTypeChambre";
            this.dgTxtType.HeaderText = "noTypeChambre";
            this.dgTxtType.Name = "dgTxtType";
            this.dgTxtType.ReadOnly = true;
            // 
            // dgTxtDescription
            // 
            this.dgTxtDescription.DataPropertyName = "description";
            this.dgTxtDescription.HeaderText = "description";
            this.dgTxtDescription.Name = "dgTxtDescription";
            this.dgTxtDescription.ReadOnly = true;
            // 
            // dgTxtPrixHaut
            // 
            this.dgTxtPrixHaut.DataPropertyName = "prixHaut";
            this.dgTxtPrixHaut.HeaderText = "prixHaut";
            this.dgTxtPrixHaut.Name = "dgTxtPrixHaut";
            this.dgTxtPrixHaut.ReadOnly = true;
            // 
            // dgTxtPrixBas
            // 
            this.dgTxtPrixBas.DataPropertyName = "prixBas";
            this.dgTxtPrixBas.HeaderText = "prixBas";
            this.dgTxtPrixBas.Name = "dgTxtPrixBas";
            this.dgTxtPrixBas.ReadOnly = true;
            // 
            // dgTxtPrixMoyen
            // 
            this.dgTxtPrixMoyen.DataPropertyName = "prixMoyen";
            this.dgTxtPrixMoyen.HeaderText = "prixMoyen";
            this.dgTxtPrixMoyen.Name = "dgTxtPrixMoyen";
            this.dgTxtPrixMoyen.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chambres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Types de chambre:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noTypeChambreDataGridViewTextBoxColumn1,
            this.emplacement,
            this.decorations,
            this.noTypeChambre});
            this.dataGridView2.DataSource = this.chambreBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(22, 409);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(543, 125);
            this.dataGridView2.TabIndex = 7;
            // 
            // noTypeChambreDataGridViewTextBoxColumn1
            // 
            this.noTypeChambreDataGridViewTextBoxColumn1.DataPropertyName = "noTypeChambre";
            this.noTypeChambreDataGridViewTextBoxColumn1.HeaderText = "noTypeChambre";
            this.noTypeChambreDataGridViewTextBoxColumn1.Name = "noTypeChambreDataGridViewTextBoxColumn1";
            this.noTypeChambreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emplacement
            // 
            this.emplacement.DataPropertyName = "emplacement";
            this.emplacement.HeaderText = "emplacement";
            this.emplacement.Name = "emplacement";
            this.emplacement.ReadOnly = true;
            // 
            // decorations
            // 
            this.decorations.DataPropertyName = "decorations";
            this.decorations.HeaderText = "decorations";
            this.decorations.Name = "decorations";
            this.decorations.ReadOnly = true;
            // 
            // noTypeChambre
            // 
            this.noTypeChambre.DataPropertyName = "noTypeChambre";
            this.noTypeChambre.HeaderText = "noTypeChambre";
            this.noTypeChambre.Name = "noTypeChambre";
            this.noTypeChambre.ReadOnly = true;
            // 
            // chambreBindingSource1
            // 
            this.chambreBindingSource1.DataMember = "fk_typeChambre";
            this.chambreBindingSource1.DataSource = this.typeChambreBindingSource;
            // 
            // btnAjouterTypeChambre
            // 
            this.btnAjouterTypeChambre.Location = new System.Drawing.Point(603, 320);
            this.btnAjouterTypeChambre.Name = "btnAjouterTypeChambre";
            this.btnAjouterTypeChambre.Size = new System.Drawing.Size(166, 23);
            this.btnAjouterTypeChambre.TabIndex = 8;
            this.btnAjouterTypeChambre.Text = "Ajouter un Type De chambre";
            this.btnAjouterTypeChambre.UseVisualStyleBackColor = true;
            this.btnAjouterTypeChambre.Click += new System.EventHandler(this.btnAjouterTypeChambre_Click);
            // 
            // btnSupprimerTypeChambre
            // 
            this.btnSupprimerTypeChambre.Location = new System.Drawing.Point(603, 378);
            this.btnSupprimerTypeChambre.Name = "btnSupprimerTypeChambre";
            this.btnSupprimerTypeChambre.Size = new System.Drawing.Size(166, 23);
            this.btnSupprimerTypeChambre.TabIndex = 9;
            this.btnSupprimerTypeChambre.Text = "Supprimer un Type De Chambre";
            this.btnSupprimerTypeChambre.UseVisualStyleBackColor = true;
            this.btnSupprimerTypeChambre.Click += new System.EventHandler(this.btnSupprimerTypeChambre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chambres associées au type sélectionné";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = this.chambreTableAdapter;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.spoonTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // btnModifierTypeChambre
            // 
            this.btnModifierTypeChambre.Location = new System.Drawing.Point(603, 349);
            this.btnModifierTypeChambre.Name = "btnModifierTypeChambre";
            this.btnModifierTypeChambre.Size = new System.Drawing.Size(166, 23);
            this.btnModifierTypeChambre.TabIndex = 11;
            this.btnModifierTypeChambre.Text = "Modifier le Type de Chambre";
            this.btnModifierTypeChambre.UseVisualStyleBackColor = true;
            this.btnModifierTypeChambre.Click += new System.EventHandler(this.btnModifierTypeChambre_Click);
            // 
            // FrmGestionChambresEtTypesChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 668);
            this.Controls.Add(this.btnModifierTypeChambre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSupprimerTypeChambre);
            this.Controls.Add(this.btnAjouterTypeChambre);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTypeChambre);
            this.Controls.Add(this.btnSupprimerCHambre);
            this.Controls.Add(this.btnModifierChambre);
            this.Controls.Add(this.btnAjouterChambre);
            this.Controls.Add(this.dgChambres);
            this.Name = "FrmGestionChambresEtTypesChambres";
            this.Text = "Gestion des Chambres et des types de chambre";
            this.Load += new System.EventHandler(this.FrmGestionChambresEtTypesChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTypeChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.DataGridView dgChambres;
        private System.Windows.Forms.Button btnAjouterChambre;
        private System.Windows.Forms.Button btnModifierChambre;
        private System.Windows.Forms.Button btnSupprimerCHambre;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeChambreTableAdapter typeChambreTableAdapter;
        private System.Windows.Forms.DataGridView dgTypeChambre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDecorations;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgTxtNoTypeChambre;
        private System.Windows.Forms.Button btnAjouterTypeChambre;
        private System.Windows.Forms.Button btnSupprimerTypeChambre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource chambreBindingSource1;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTypeChambreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn decorations;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTypeChambre;
        private System.Windows.Forms.Button btnModifierTypeChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrixHaut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrixBas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrixMoyen;
    }
}