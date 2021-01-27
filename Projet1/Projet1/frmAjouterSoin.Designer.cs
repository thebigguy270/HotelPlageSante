namespace Projet1
{
    partial class frmAjouterSoin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.cbTypeDeSoin = new System.Windows.Forms.ComboBox();
            this.typeSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.typeSoinTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeSoinTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type de Soin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(167, 35);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 4;
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(167, 88);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(100, 20);
            this.tbPrix.TabIndex = 6;
            // 
            // cbTypeDeSoin
            // 
            this.cbTypeDeSoin.DataSource = this.typeSoinBindingSource;
            this.cbTypeDeSoin.DisplayMember = "description";
            this.cbTypeDeSoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeDeSoin.FormattingEnabled = true;
            this.cbTypeDeSoin.Location = new System.Drawing.Point(167, 61);
            this.cbTypeDeSoin.Name = "cbTypeDeSoin";
            this.cbTypeDeSoin.Size = new System.Drawing.Size(100, 21);
            this.cbTypeDeSoin.TabIndex = 7;
            this.cbTypeDeSoin.ValueMember = "noTypeSoin";
            // 
            // typeSoinBindingSource
            // 
            this.typeSoinBindingSource.DataMember = "typeSoin";
            this.typeSoinBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(50, 163);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(192, 163);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // typeSoinTableAdapter
            // 
            this.typeSoinTableAdapter.ClearBeforeFill = true;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjouterSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 240);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbTypeDeSoin);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmAjouterSoin";
            this.Text = "Ajouter Un Soin";
            this.Load += new System.EventHandler(this.frmAjouterSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.ComboBox cbTypeDeSoin;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource typeSoinBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeSoinTableAdapter typeSoinTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}