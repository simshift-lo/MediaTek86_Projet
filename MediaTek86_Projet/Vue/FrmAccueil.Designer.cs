namespace MediaTek86_Projet.Vue
{
    partial class FrmAccueil
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(45, 44);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(139, 20);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Liste du personnel";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colPrenom,
            this.colTel,
            this.colMail,
            this.colService});
            this.dgvPersonnel.Location = new System.Drawing.Point(49, 99);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowTemplate.Height = 28;
            this.dgvPersonnel.Size = new System.Drawing.Size(627, 359);
            this.dgvPersonnel.TabIndex = 1;
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            // 
            // colPrenom
            // 
            this.colPrenom.HeaderText = "Prénom";
            this.colPrenom.Name = "colPrenom";
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Téléphone";
            this.colTel.Name = "colTel";
            // 
            // colMail
            // 
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            // 
            // colService
            // 
            this.colService.HeaderText = "Service";
            this.colService.Name = "colService";
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(49, 486);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(99, 28);
            this.btnAjouterPersonnel.TabIndex = 2;
            this.btnAjouterPersonnel.Text = "Ajouter";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(154, 486);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(96, 28);
            this.btnModifierPersonnel.TabIndex = 3;
            this.btnModifierPersonnel.Text = "Modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(256, 486);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(97, 28);
            this.btnSupprimerPersonnel.TabIndex = 4;
            this.btnSupprimerPersonnel.Text = "Supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(359, 486);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(94, 26);
            this.btnAbsences.TabIndex = 5;
            this.btnAbsences.Text = "Absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 734);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnSupprimerPersonnel);
            this.Controls.Add(this.btnModifierPersonnel);
            this.Controls.Add(this.btnAjouterPersonnel);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAccueil";
            this.Text = "FrmAccueil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnAbsences;
    }
}