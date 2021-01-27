namespace Projet1
{
    partial class frmAjouterUtilisateur
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomUtilisateur = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.cbTypeUtilisateur = new System.Windows.Forms.ComboBox();
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUtilisateurTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeUtilisateurTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(24, 202);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(171, 202);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom d\'utilisateur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type d\'utilisateur:";
            // 
            // tbNomUtilisateur
            // 
            this.tbNomUtilisateur.Location = new System.Drawing.Point(149, 50);
            this.tbNomUtilisateur.Name = "tbNomUtilisateur";
            this.tbNomUtilisateur.Size = new System.Drawing.Size(121, 20);
            this.tbNomUtilisateur.TabIndex = 5;
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(149, 76);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(121, 20);
            this.tbMDP.TabIndex = 6;
            // 
            // cbTypeUtilisateur
            // 
            this.cbTypeUtilisateur.DataSource = this.typeUtilisateurBindingSource;
            this.cbTypeUtilisateur.DisplayMember = "identification";
            this.cbTypeUtilisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeUtilisateur.FormattingEnabled = true;
            this.cbTypeUtilisateur.Location = new System.Drawing.Point(149, 103);
            this.cbTypeUtilisateur.Name = "cbTypeUtilisateur";
            this.cbTypeUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.cbTypeUtilisateur.TabIndex = 7;
            this.cbTypeUtilisateur.ValueMember = "noTypeUtilisateur";
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeUtilisateurBindingSource
            // 
            this.typeUtilisateurBindingSource.DataMember = "typeUtilisateur";
            this.typeUtilisateurBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // typeUtilisateurTableAdapter
            // 
            this.typeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 255);
            this.Controls.Add(this.cbTypeUtilisateur);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbNomUtilisateur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Name = "frmAjouterUtilisateur";
            this.Text = "Ajouter un utilisateur";
            this.Load += new System.EventHandler(this.frmAjouterUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomUtilisateur;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.ComboBox cbTypeUtilisateur;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeUtilisateurTableAdapter typeUtilisateurTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}