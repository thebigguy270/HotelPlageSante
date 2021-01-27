namespace Projet1
{
    partial class frmAjouterAssistant
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
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label specialitesLabel;
            System.Windows.Forms.Label remarquesLabel;
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.assistantTableAdapter();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtSpecialites = new System.Windows.Forms.TextBox();
            this.txtRemarques = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFermer = new System.Windows.Forms.Button();
            prenomLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            specialitesLabel = new System.Windows.Forms.Label();
            remarquesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(26, 9);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 3;
            prenomLabel.Text = "Prénom:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(26, 35);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom:";
            // 
            // specialitesLabel
            // 
            specialitesLabel.AutoSize = true;
            specialitesLabel.Location = new System.Drawing.Point(26, 61);
            specialitesLabel.Name = "specialitesLabel";
            specialitesLabel.Size = new System.Drawing.Size(61, 13);
            specialitesLabel.TabIndex = 7;
            specialitesLabel.Text = "Spécialités:";
            // 
            // remarquesLabel
            // 
            remarquesLabel.AutoSize = true;
            remarquesLabel.Location = new System.Drawing.Point(26, 87);
            remarquesLabel.Name = "remarquesLabel";
            remarquesLabel.Size = new System.Drawing.Size(64, 13);
            remarquesLabel.TabIndex = 9;
            remarquesLabel.Text = "Remarques:";
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "assistant";
            this.assistantBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = this.assistantTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
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
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(99, 6);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(99, 32);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 6;
            // 
            // txtSpecialites
            // 
            this.txtSpecialites.Location = new System.Drawing.Point(99, 58);
            this.txtSpecialites.Name = "txtSpecialites";
            this.txtSpecialites.Size = new System.Drawing.Size(100, 20);
            this.txtSpecialites.TabIndex = 8;
            // 
            // txtRemarques
            // 
            this.txtRemarques.Location = new System.Drawing.Point(99, 84);
            this.txtRemarques.Name = "txtRemarques";
            this.txtRemarques.Size = new System.Drawing.Size(100, 20);
            this.txtRemarques.TabIndex = 10;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(227, 9);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(125, 23);
            this.btnAjout.TabIndex = 11;
            this.btnAjout.Text = "Ajouter l\'assistant";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(227, 39);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(125, 23);
            this.btnFermer.TabIndex = 12;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmAjouterAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 118);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(specialitesLabel);
            this.Controls.Add(this.txtSpecialites);
            this.Controls.Add(remarquesLabel);
            this.Controls.Add(this.txtRemarques);
            this.Name = "frmAjouterAssistant";
            this.Text = "Ajouter un Assistant";
            this.Load += new System.EventHandler(this.frmAjouterAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.assistantTableAdapter assistantTableAdapter;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtSpecialites;
        private System.Windows.Forms.TextBox txtRemarques;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Button btnFermer;
    }
}