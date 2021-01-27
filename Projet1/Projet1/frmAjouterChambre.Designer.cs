namespace Projet1
{
    partial class frmAjouterChambre
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
            this.tbEmplacement = new System.Windows.Forms.TextBox();
            this.tbDecorations = new System.Windows.Forms.TextBox();
            this.cbTypeChambre = new System.Windows.Forms.ComboBox();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.typeChambreTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeChambreTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(24, 118);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(177, 118);
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
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emplacement:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Décorations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type de la chambre:";
            // 
            // tbEmplacement
            // 
            this.tbEmplacement.Location = new System.Drawing.Point(131, 31);
            this.tbEmplacement.Name = "tbEmplacement";
            this.tbEmplacement.Size = new System.Drawing.Size(121, 20);
            this.tbEmplacement.TabIndex = 5;
            this.tbEmplacement.TextChanged += new System.EventHandler(this.tbEmplacement_TextChanged);
            // 
            // tbDecorations
            // 
            this.tbDecorations.Location = new System.Drawing.Point(131, 57);
            this.tbDecorations.Name = "tbDecorations";
            this.tbDecorations.Size = new System.Drawing.Size(121, 20);
            this.tbDecorations.TabIndex = 6;
            // 
            // cbTypeChambre
            // 
            this.cbTypeChambre.DataSource = this.typeChambreBindingSource;
            this.cbTypeChambre.DisplayMember = "description";
            this.cbTypeChambre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeChambre.FormattingEnabled = true;
            this.cbTypeChambre.Location = new System.Drawing.Point(131, 84);
            this.cbTypeChambre.Name = "cbTypeChambre";
            this.cbTypeChambre.Size = new System.Drawing.Size(121, 21);
            this.cbTypeChambre.TabIndex = 7;
            this.cbTypeChambre.ValueMember = "noTypeChambre";
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "typeChambre";
            this.typeChambreBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjouterChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 169);
            this.Controls.Add(this.cbTypeChambre);
            this.Controls.Add(this.tbDecorations);
            this.Controls.Add(this.tbEmplacement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Name = "frmAjouterChambre";
            this.Text = "Ajouter une chambre";
            this.Load += new System.EventHandler(this.frmAjouterChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox tbEmplacement;
        private System.Windows.Forms.TextBox tbDecorations;
        private System.Windows.Forms.ComboBox cbTypeChambre;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.typeChambreTableAdapter typeChambreTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}