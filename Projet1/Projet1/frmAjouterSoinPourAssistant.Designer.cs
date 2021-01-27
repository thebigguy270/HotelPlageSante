namespace Projet1
{
    partial class frmAjouterSoinPourAssistant
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
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.soinSansAssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinSansAssistantTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinSansAssistantTableAdapter();
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            this.ddlSoinSansAssistant = new System.Windows.Forms.ComboBox();
            this.btnAjouterSoin = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.spoonTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.spoonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinSansAssistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soin sans assistant à sélectionner:";
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soinSansAssistantBindingSource
            // 
            this.soinSansAssistantBindingSource.DataMember = "soinSansAssistant";
            this.soinSansAssistantBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // soinSansAssistantTableAdapter
            // 
            this.soinSansAssistantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.spoonTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // ddlSoinSansAssistant
            // 
            this.ddlSoinSansAssistant.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soinSansAssistantBindingSource, "noSoin", true));
            this.ddlSoinSansAssistant.DataSource = this.soinSansAssistantBindingSource;
            this.ddlSoinSansAssistant.DisplayMember = "noSoin";
            this.ddlSoinSansAssistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSoinSansAssistant.FormattingEnabled = true;
            this.ddlSoinSansAssistant.Location = new System.Drawing.Point(210, 35);
            this.ddlSoinSansAssistant.Name = "ddlSoinSansAssistant";
            this.ddlSoinSansAssistant.Size = new System.Drawing.Size(90, 21);
            this.ddlSoinSansAssistant.TabIndex = 2;
            this.ddlSoinSansAssistant.ValueMember = "noSoin";
            // 
            // btnAjouterSoin
            // 
            this.btnAjouterSoin.Location = new System.Drawing.Point(38, 85);
            this.btnAjouterSoin.Name = "btnAjouterSoin";
            this.btnAjouterSoin.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterSoin.TabIndex = 3;
            this.btnAjouterSoin.Text = "Ajouter Soin";
            this.btnAjouterSoin.UseVisualStyleBackColor = true;
            this.btnAjouterSoin.Click += new System.EventHandler(this.btnAjouterSoin_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(225, 85);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // spoonTableAdapter
            // 
            this.spoonTableAdapter.ClearBeforeFill = true;
            // 
            // frmAjouterSoinPourAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 219);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouterSoin);
            this.Controls.Add(this.ddlSoinSansAssistant);
            this.Controls.Add(this.label1);
            this.Name = "frmAjouterSoinPourAssistant";
            this.Text = "Ajouter un soin à un assistant";
            this.Load += new System.EventHandler(this.frmAjouterSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinSansAssistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource soinSansAssistantBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.soinSansAssistantTableAdapter soinSansAssistantTableAdapter;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ddlSoinSansAssistant;
        private System.Windows.Forms.Button btnAjouterSoin;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ErrorProvider errMessage;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.spoonTableAdapter spoonTableAdapter;
    }
}