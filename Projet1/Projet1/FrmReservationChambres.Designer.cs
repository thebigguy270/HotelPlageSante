using System;

namespace Projet1
{
    partial class FrmReservationChambres
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
            this.reservationChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_BrodeurLussierDataSet = new Projet1.BD5B6TP1_BrodeurLussierDataSet();
            this.reservationChambreTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.reservationChambreTableAdapter();
            this.dgReservationsChambre = new System.Windows.Forms.DataGridView();
            this.dgTxtNoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoChambreReservee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDateArrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDateDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNbPersonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimerReservation = new System.Windows.Forms.Button();
            this.btnAjouterReservation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivee = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPersonnes = new System.Windows.Forms.NumericUpDown();
            this.dgChambres = new System.Windows.Forms.DataGridView();
            this.dgTxtNoChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDecorations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoTypeChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbClientsNoms = new System.Windows.Forms.ComboBox();
            this.clientNomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.chambreTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter1 = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientTableAdapter();
            this.clientNomsTableAdapter = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientNomsTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errMessageAjoutR = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.reservationChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationsChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientNomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessageAjoutR)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationChambreBindingSource
            // 
            this.reservationChambreBindingSource.DataMember = "reservationChambre";
            this.reservationChambreBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // bD5B6TP1_BrodeurLussierDataSet
            // 
            this.bD5B6TP1_BrodeurLussierDataSet.DataSetName = "BD5B6TP1_BrodeurLussierDataSet";
            this.bD5B6TP1_BrodeurLussierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationChambreTableAdapter
            // 
            this.reservationChambreTableAdapter.ClearBeforeFill = true;
            // 
            // dgReservationsChambre
            // 
            this.dgReservationsChambre.AllowUserToAddRows = false;
            this.dgReservationsChambre.AllowUserToDeleteRows = false;
            this.dgReservationsChambre.AutoGenerateColumns = false;
            this.dgReservationsChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservationsChambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoClient,
            this.dgTxtNoChambreReservee,
            this.dgTxtDateArrive,
            this.dgTxtDateDepart,
            this.dgTxtNbPersonnes});
            this.dgReservationsChambre.DataSource = this.reservationChambreBindingSource;
            this.dgReservationsChambre.Location = new System.Drawing.Point(12, 438);
            this.dgReservationsChambre.Name = "dgReservationsChambre";
            this.dgReservationsChambre.ReadOnly = true;
            this.dgReservationsChambre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservationsChambre.Size = new System.Drawing.Size(543, 220);
            this.dgReservationsChambre.TabIndex = 0;
            // 
            // dgTxtNoClient
            // 
            this.dgTxtNoClient.DataPropertyName = "noClient";
            this.dgTxtNoClient.HeaderText = "No. Client";
            this.dgTxtNoClient.Name = "dgTxtNoClient";
            this.dgTxtNoClient.ReadOnly = true;
            // 
            // dgTxtNoChambreReservee
            // 
            this.dgTxtNoChambreReservee.DataPropertyName = "noChambre";
            this.dgTxtNoChambreReservee.HeaderText = "No. Chambre";
            this.dgTxtNoChambreReservee.Name = "dgTxtNoChambreReservee";
            this.dgTxtNoChambreReservee.ReadOnly = true;
            // 
            // dgTxtDateArrive
            // 
            this.dgTxtDateArrive.DataPropertyName = "dateArrive";
            this.dgTxtDateArrive.HeaderText = "Date d\'Arrivée";
            this.dgTxtDateArrive.Name = "dgTxtDateArrive";
            this.dgTxtDateArrive.ReadOnly = true;
            // 
            // dgTxtDateDepart
            // 
            this.dgTxtDateDepart.DataPropertyName = "dateDepart";
            this.dgTxtDateDepart.HeaderText = "Date de départ";
            this.dgTxtDateDepart.Name = "dgTxtDateDepart";
            this.dgTxtDateDepart.ReadOnly = true;
            // 
            // dgTxtNbPersonnes
            // 
            this.dgTxtNbPersonnes.DataPropertyName = "nbPersonnes";
            this.dgTxtNbPersonnes.HeaderText = "Nombre de Personnes";
            this.dgTxtNbPersonnes.Name = "dgTxtNbPersonnes";
            this.dgTxtNbPersonnes.ReadOnly = true;
            // 
            // btnSupprimerReservation
            // 
            this.btnSupprimerReservation.Location = new System.Drawing.Point(562, 519);
            this.btnSupprimerReservation.Name = "btnSupprimerReservation";
            this.btnSupprimerReservation.Size = new System.Drawing.Size(133, 23);
            this.btnSupprimerReservation.TabIndex = 1;
            this.btnSupprimerReservation.Text = "Supprimer réservation";
            this.btnSupprimerReservation.UseVisualStyleBackColor = true;
            this.btnSupprimerReservation.Click += new System.EventHandler(this.btnSupprimerReservation_Click);
            // 
            // btnAjouterReservation
            // 
            this.btnAjouterReservation.Location = new System.Drawing.Point(522, 199);
            this.btnAjouterReservation.Name = "btnAjouterReservation";
            this.btnAjouterReservation.Size = new System.Drawing.Size(133, 23);
            this.btnAjouterReservation.TabIndex = 2;
            this.btnAjouterReservation.Text = "Ajouter réservation";
            this.btnAjouterReservation.UseVisualStyleBackColor = true;
            this.btnAjouterReservation.Click += new System.EventHandler(this.btnAjouterReservation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Début:";
            // 
            // dtpDepart
            // 
            this.dtpDepart.CustomFormat = "ddMMMM, yyyy  |  HH:mm";
            this.dtpDepart.Location = new System.Drawing.Point(81, 332);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(200, 20);
            this.dtpDepart.TabIndex = 33;
            this.dtpDepart.Value = new System.DateTime(2018, 10, 24, 0, 0, 0, 0);
            // 
            // dtpArrivee
            // 
            this.dtpArrivee.CustomFormat = "ddMMMM, yyyy  |  HH:mm";
            this.dtpArrivee.Location = new System.Drawing.Point(81, 306);
            this.dtpArrivee.Name = "dtpArrivee";
            this.dtpArrivee.Size = new System.Drawing.Size(200, 20);
            this.dtpArrivee.TabIndex = 32;
            this.dtpArrivee.Value = new System.DateTime(2018, 10, 24, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Personnes:";
            // 
            // nudPersonnes
            // 
            this.nudPersonnes.Location = new System.Drawing.Point(105, 281);
            this.nudPersonnes.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPersonnes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersonnes.Name = "nudPersonnes";
            this.nudPersonnes.Size = new System.Drawing.Size(120, 20);
            this.nudPersonnes.TabIndex = 30;
            this.nudPersonnes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgChambres
            // 
            this.dgChambres.AllowUserToAddRows = false;
            this.dgChambres.AllowUserToDeleteRows = false;
            this.dgChambres.AutoGenerateColumns = false;
            this.dgChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoChambre,
            this.dgTxtEmplacement,
            this.dgTxtDecorations,
            this.dgTxtNoTypeChambre});
            this.dgChambres.DataSource = this.chambreBindingSource;
            this.dgChambres.Location = new System.Drawing.Point(42, 55);
            this.dgChambres.Name = "dgChambres";
            this.dgChambres.ReadOnly = true;
            this.dgChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChambres.Size = new System.Drawing.Size(442, 220);
            this.dgChambres.TabIndex = 28;
            // 
            // dgTxtNoChambre
            // 
            this.dgTxtNoChambre.DataPropertyName = "noChambre";
            this.dgTxtNoChambre.HeaderText = "no de Chambre";
            this.dgTxtNoChambre.Name = "dgTxtNoChambre";
            this.dgTxtNoChambre.ReadOnly = true;
            // 
            // dgTxtEmplacement
            // 
            this.dgTxtEmplacement.DataPropertyName = "emplacement";
            this.dgTxtEmplacement.HeaderText = "Emplacement";
            this.dgTxtEmplacement.Name = "dgTxtEmplacement";
            this.dgTxtEmplacement.ReadOnly = true;
            // 
            // dgTxtDecorations
            // 
            this.dgTxtDecorations.DataPropertyName = "decorations";
            this.dgTxtDecorations.HeaderText = "Décorations";
            this.dgTxtDecorations.Name = "dgTxtDecorations";
            this.dgTxtDecorations.ReadOnly = true;
            // 
            // dgTxtNoTypeChambre
            // 
            this.dgTxtNoTypeChambre.DataPropertyName = "noTypeChambre";
            this.dgTxtNoTypeChambre.HeaderText = "No. Type de Chambre";
            this.dgTxtNoTypeChambre.Name = "dgTxtNoTypeChambre";
            this.dgTxtNoTypeChambre.ReadOnly = true;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Client:";
            // 
            // cbClientsNoms
            // 
            this.cbClientsNoms.DataSource = this.clientNomsBindingSource;
            this.cbClientsNoms.DisplayMember = "nomcomplet";
            this.cbClientsNoms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientsNoms.FormattingEnabled = true;
            this.cbClientsNoms.Location = new System.Drawing.Point(81, 28);
            this.cbClientsNoms.Name = "cbClientsNoms";
            this.cbClientsNoms.Size = new System.Drawing.Size(170, 21);
            this.cbClientsNoms.TabIndex = 27;
            this.cbClientsNoms.ValueMember = "noClient";
            // 
            // clientNomsBindingSource
            // 
            this.clientNomsBindingSource.DataMember = "clientNoms";
            this.clientNomsBindingSource.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "client";
            this.bindingSource1.DataSource = this.bD5B6TP1_BrodeurLussierDataSet;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // clientNomsTableAdapter
            // 
            this.clientNomsTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Suppression";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgChambres);
            this.groupBox1.Controls.Add(this.btnAjouterReservation);
            this.groupBox1.Controls.Add(this.cbClientsNoms);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudPersonnes);
            this.groupBox1.Controls.Add(this.dtpDepart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpArrivee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 357);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout des réservations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // errMessageAjoutR
            // 
            this.errMessageAjoutR.ContainerControl = this;
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
            this.tableAdapterManager.reservationChambreTableAdapter = this.reservationChambreTableAdapter;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.spoonTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // FrmReservationChambres
            // 
            this.ClientSize = new System.Drawing.Size(1070, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSupprimerReservation);
            this.Controls.Add(this.dgReservationsChambre);
            this.Name = "FrmReservationChambres";
            this.Text = "Réservation des chambres";
            this.Load += new System.EventHandler(this.FrmReservationChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_BrodeurLussierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationsChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientNomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessageAjoutR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private BD5B6TP1_BrodeurLussierDataSet bD5B6TP1_BrodeurLussierDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientNomsTableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource reservationChambreBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.reservationChambreTableAdapter reservationChambreTableAdapter;
        private System.Windows.Forms.DataGridView dgReservationsChambre;
        
        private System.Windows.Forms.Button btnSupprimerReservation;
        private System.Windows.Forms.Button btnAjouterReservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.DateTimePicker dtpArrivee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPersonnes;
        private System.Windows.Forms.DataGridView dgChambres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClientsNoms;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.BindingSource clientNomsBindingSource;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.clientNomsTableAdapter clientNomsTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errMessageAjoutR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoChambreReservee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateArrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNbPersonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDecorations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoTypeChambre;
        private BD5B6TP1_BrodeurLussierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}