namespace Projet1
{
    partial class FrmMenuAdmin
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
            this.btnGererUtilisateurs = new System.Windows.Forms.Button();
            this.btnGererClientsEtInvites = new System.Windows.Forms.Button();
            this.btnGererAssistantsEtSoins = new System.Windows.Forms.Button();
            this.btnGererSoins = new System.Windows.Forms.Button();
            this.btnGererChambres = new System.Windows.Forms.Button();
            this.btnReserverChambres = new System.Windows.Forms.Button();
            this.btnVisualiserRapports = new System.Windows.Forms.Button();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGererUtilisateurs
            // 
            this.btnGererUtilisateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererUtilisateurs.Location = new System.Drawing.Point(12, 12);
            this.btnGererUtilisateurs.Name = "btnGererUtilisateurs";
            this.btnGererUtilisateurs.Size = new System.Drawing.Size(303, 30);
            this.btnGererUtilisateurs.TabIndex = 0;
            this.btnGererUtilisateurs.Text = "Gérer les utilisateurs";
            this.btnGererUtilisateurs.UseVisualStyleBackColor = true;
            this.btnGererUtilisateurs.Click += new System.EventHandler(this.btnGererUtilisateurs_Click);
            // 
            // btnGererClientsEtInvites
            // 
            this.btnGererClientsEtInvites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererClientsEtInvites.Location = new System.Drawing.Point(12, 48);
            this.btnGererClientsEtInvites.Name = "btnGererClientsEtInvites";
            this.btnGererClientsEtInvites.Size = new System.Drawing.Size(303, 30);
            this.btnGererClientsEtInvites.TabIndex = 1;
            this.btnGererClientsEtInvites.Text = "Gérer les clients et leurs invités";
            this.btnGererClientsEtInvites.UseVisualStyleBackColor = true;
            this.btnGererClientsEtInvites.Click += new System.EventHandler(this.btnGererClientsEtInvites_Click);
            // 
            // btnGererAssistantsEtSoins
            // 
            this.btnGererAssistantsEtSoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererAssistantsEtSoins.Location = new System.Drawing.Point(12, 84);
            this.btnGererAssistantsEtSoins.Name = "btnGererAssistantsEtSoins";
            this.btnGererAssistantsEtSoins.Size = new System.Drawing.Size(303, 30);
            this.btnGererAssistantsEtSoins.TabIndex = 2;
            this.btnGererAssistantsEtSoins.Text = "Gérer les assistants et les soins qu’ils offrent";
            this.btnGererAssistantsEtSoins.UseVisualStyleBackColor = true;
            this.btnGererAssistantsEtSoins.Click += new System.EventHandler(this.btnGererAssistantsEtSoins_Click);
            // 
            // btnGererSoins
            // 
            this.btnGererSoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererSoins.Location = new System.Drawing.Point(12, 120);
            this.btnGererSoins.Name = "btnGererSoins";
            this.btnGererSoins.Size = new System.Drawing.Size(303, 30);
            this.btnGererSoins.TabIndex = 3;
            this.btnGererSoins.Text = "Gérer les soins";
            this.btnGererSoins.UseVisualStyleBackColor = true;
            this.btnGererSoins.Click += new System.EventHandler(this.btnGererSoins_Click);
            // 
            // btnGererChambres
            // 
            this.btnGererChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererChambres.Location = new System.Drawing.Point(11, 156);
            this.btnGererChambres.Name = "btnGererChambres";
            this.btnGererChambres.Size = new System.Drawing.Size(303, 30);
            this.btnGererChambres.TabIndex = 5;
            this.btnGererChambres.Text = "Gérer les chambres";
            this.btnGererChambres.UseVisualStyleBackColor = true;
            this.btnGererChambres.Click += new System.EventHandler(this.btnGererChambres_Click);
            // 
            // btnReserverChambres
            // 
            this.btnReserverChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserverChambres.Location = new System.Drawing.Point(11, 192);
            this.btnReserverChambres.Name = "btnReserverChambres";
            this.btnReserverChambres.Size = new System.Drawing.Size(303, 30);
            this.btnReserverChambres.TabIndex = 6;
            this.btnReserverChambres.Text = "Réserver des chambres (pour les clients)";
            this.btnReserverChambres.UseVisualStyleBackColor = true;
            this.btnReserverChambres.Click += new System.EventHandler(this.btnReserverChambres_Click);
            // 
            // btnVisualiserRapports
            // 
            this.btnVisualiserRapports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualiserRapports.Location = new System.Drawing.Point(11, 228);
            this.btnVisualiserRapports.Name = "btnVisualiserRapports";
            this.btnVisualiserRapports.Size = new System.Drawing.Size(303, 30);
            this.btnVisualiserRapports.TabIndex = 7;
            this.btnVisualiserRapports.Text = "Visualiser des rapports";
            this.btnVisualiserRapports.UseVisualStyleBackColor = true;
            this.btnVisualiserRapports.Click += new System.EventHandler(this.btnVisualiserRapports_Click);
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnecter.Location = new System.Drawing.Point(11, 264);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(303, 30);
            this.btnDeconnecter.TabIndex = 8;
            this.btnDeconnecter.Text = "Se déconnecter";
            this.btnDeconnecter.UseVisualStyleBackColor = true;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(11, 300);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(303, 30);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter l’application";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 378);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDeconnecter);
            this.Controls.Add(this.btnVisualiserRapports);
            this.Controls.Add(this.btnReserverChambres);
            this.Controls.Add(this.btnGererChambres);
            this.Controls.Add(this.btnGererSoins);
            this.Controls.Add(this.btnGererAssistantsEtSoins);
            this.Controls.Add(this.btnGererClientsEtInvites);
            this.Controls.Add(this.btnGererUtilisateurs);
            this.Name = "FrmMenuAdmin";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGererUtilisateurs;
        private System.Windows.Forms.Button btnGererClientsEtInvites;
        private System.Windows.Forms.Button btnGererAssistantsEtSoins;
        private System.Windows.Forms.Button btnGererSoins;
        private System.Windows.Forms.Button btnGererChambres;
        private System.Windows.Forms.Button btnReserverChambres;
        private System.Windows.Forms.Button btnVisualiserRapports;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Button btnQuitter;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
    }
}