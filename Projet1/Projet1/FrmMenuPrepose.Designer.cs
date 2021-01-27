namespace Projet1
{
    partial class FrmMenuPrepose
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.btnReserverChambres = new System.Windows.Forms.Button();
            this.btnGererClientsEtInvites = new System.Windows.Forms.Button();
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(12, 120);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(303, 30);
            this.btnQuitter.TabIndex = 14;
            this.btnQuitter.Text = "Quitter l’application";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnecter.Location = new System.Drawing.Point(12, 84);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(303, 30);
            this.btnDeconnecter.TabIndex = 13;
            this.btnDeconnecter.Text = "Se déconnecter";
            this.btnDeconnecter.UseVisualStyleBackColor = true;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // btnReserverChambres
            // 
            this.btnReserverChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserverChambres.Location = new System.Drawing.Point(12, 48);
            this.btnReserverChambres.Name = "btnReserverChambres";
            this.btnReserverChambres.Size = new System.Drawing.Size(303, 30);
            this.btnReserverChambres.TabIndex = 12;
            this.btnReserverChambres.Text = "Réserver des chambres";
            this.btnReserverChambres.UseVisualStyleBackColor = true;
            this.btnReserverChambres.Click += new System.EventHandler(this.btnReserverChambres_Click);
            // 
            // btnGererClientsEtInvites
            // 
            this.btnGererClientsEtInvites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGererClientsEtInvites.Location = new System.Drawing.Point(12, 12);
            this.btnGererClientsEtInvites.Name = "btnGererClientsEtInvites";
            this.btnGererClientsEtInvites.Size = new System.Drawing.Size(303, 30);
            this.btnGererClientsEtInvites.TabIndex = 10;
            this.btnGererClientsEtInvites.Text = "Gérer les clients et leurs invités";
            this.btnGererClientsEtInvites.UseVisualStyleBackColor = true;
            this.btnGererClientsEtInvites.Click += new System.EventHandler(this.btnGererClientsEtInvites_Click);
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmMenuPrepose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 199);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDeconnecter);
            this.Controls.Add(this.btnReserverChambres);
            this.Controls.Add(this.btnGererClientsEtInvites);
            this.Name = "FrmMenuPrepose";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Button btnReserverChambres;
        private System.Windows.Forms.Button btnGererClientsEtInvites;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
    }
}