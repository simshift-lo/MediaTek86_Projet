namespace MediaTek86_Projet.Vue
{
    partial class FrmAbsences
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.colDateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(37, 20);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(118, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Absences du personnel";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateDebut,
            this.colDateFin,
            this.colMotif});
            this.dgvAbsences.Location = new System.Drawing.Point(40, 68);
            this.dgvAbsences.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowTemplate.Height = 28;
            this.dgvAbsences.Size = new System.Drawing.Size(423, 196);
            this.dgvAbsences.TabIndex = 1;
            this.dgvAbsences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbsences_CellContentClick);
            // 
            // colDateDebut
            // 
            this.colDateDebut.HeaderText = "Date début";
            this.colDateDebut.Name = "colDateDebut";
            // 
            // colDateFin
            // 
            this.colDateFin.HeaderText = "Date fin";
            this.colDateFin.Name = "colDateFin";
            // 
            // colMotif
            // 
            this.colMotif.HeaderText = "Motif";
            this.colMotif.Name = "colMotif";
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(40, 287);
            this.btnAjouterAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(74, 23);
            this.btnAjouterAbsence.TabIndex = 2;
            this.btnAjouterAbsence.Text = "Ajouter";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            this.btnAjouterAbsence.Click += new System.EventHandler(this.btnAjouterAbsence_Click);
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(118, 287);
            this.btnModifierAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(74, 23);
            this.btnModifierAbsence.TabIndex = 3;
            this.btnModifierAbsence.Text = "Modifier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            this.btnModifierAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(196, 287);
            this.btnSupprimerAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(73, 23);
            this.btnSupprimerAbsence.TabIndex = 4;
            this.btnSupprimerAbsence.Text = "Supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnModifierAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAbsences";
            this.Text = "FrmAbsences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotif;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
    }
}