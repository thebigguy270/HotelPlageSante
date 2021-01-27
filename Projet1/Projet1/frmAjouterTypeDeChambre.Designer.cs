namespace Projet1
{
    partial class frmAjouterTypeDeChambre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tbPrixH = new System.Windows.Forms.TextBox();
            this.tbPrixB = new System.Windows.Forms.TextBox();
            this.tbPrixM = new System.Windows.Forms.TextBox();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix le plus haut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix le plus bas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix moyen:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(136, 50);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 7;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(48, 182);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(160, 182);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // tbPrixH
            // 
            this.tbPrixH.Location = new System.Drawing.Point(136, 86);
            this.tbPrixH.Name = "tbPrixH";
            this.tbPrixH.Size = new System.Drawing.Size(100, 20);
            this.tbPrixH.TabIndex = 10;
            // 
            // tbPrixB
            // 
            this.tbPrixB.Location = new System.Drawing.Point(136, 117);
            this.tbPrixB.Name = "tbPrixB";
            this.tbPrixB.Size = new System.Drawing.Size(100, 20);
            this.tbPrixB.TabIndex = 11;
            // 
            // tbPrixM
            // 
            this.tbPrixM.Location = new System.Drawing.Point(136, 147);
            this.tbPrixM.Name = "tbPrixM";
            this.tbPrixM.Size = new System.Drawing.Size(100, 20);
            this.tbPrixM.TabIndex = 12;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjouterTypeDeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 271);
            this.Controls.Add(this.tbPrixM);
            this.Controls.Add(this.tbPrixB);
            this.Controls.Add(this.tbPrixH);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAjouterTypeDeChambre";
            this.Text = "Ajouter un type de chambre";
            this.Load += new System.EventHandler(this.frmAjouterTypeDeChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox tbPrixH;
        private System.Windows.Forms.TextBox tbPrixB;
        private System.Windows.Forms.TextBox tbPrixM;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}