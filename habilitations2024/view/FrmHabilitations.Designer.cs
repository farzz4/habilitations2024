namespace Habilitations2024.view
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnChangerPwd = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvLesDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.gboAjoutDeveloppeur = new System.Windows.Forms.GroupBox();
            this.cboProfil = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAnnulerDeveloppeur = new System.Windows.Forms.Button();
            this.btnEnregistrerDeveloppeur = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gboModifPwd = new System.Windows.Forms.GroupBox();
            this.btnAnnulerPwd = new System.Windows.Forms.Button();
            this.btnEnregistrerPwd = new System.Windows.Forms.Button();
            this.txtEncorePwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboLesDeveloppeurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesDeveloppeurs)).BeginInit();
            this.gboAjoutDeveloppeur.SuspendLayout();
            this.gboModifPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboLesDeveloppeurs
            // 
            this.gboLesDeveloppeurs.Controls.Add(this.label8);
            this.gboLesDeveloppeurs.Controls.Add(this.comboBox1);
            this.gboLesDeveloppeurs.Controls.Add(this.btnChangerPwd);
            this.gboLesDeveloppeurs.Controls.Add(this.btnSupprimer);
            this.gboLesDeveloppeurs.Controls.Add(this.btnModifier);
            this.gboLesDeveloppeurs.Controls.Add(this.dgvLesDeveloppeurs);
            this.gboLesDeveloppeurs.Location = new System.Drawing.Point(19, 28);
            this.gboLesDeveloppeurs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboLesDeveloppeurs.Name = "gboLesDeveloppeurs";
            this.gboLesDeveloppeurs.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboLesDeveloppeurs.Size = new System.Drawing.Size(569, 305);
            this.gboLesDeveloppeurs.TabIndex = 0;
            this.gboLesDeveloppeurs.TabStop = false;
            this.gboLesDeveloppeurs.Text = "Les développeurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Filtre";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightCoral;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(407, 266);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 27);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnChangerPwd
            // 
            this.btnChangerPwd.BackColor = System.Drawing.Color.Firebrick;
            this.btnChangerPwd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangerPwd.Location = new System.Drawing.Point(257, 270);
            this.btnChangerPwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChangerPwd.Name = "btnChangerPwd";
            this.btnChangerPwd.Size = new System.Drawing.Size(83, 28);
            this.btnChangerPwd.TabIndex = 3;
            this.btnChangerPwd.Text = "Changer pwd";
            this.btnChangerPwd.UseVisualStyleBackColor = false;
            this.btnChangerPwd.Click += new System.EventHandler(this.btnChangerPwd_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Firebrick;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSupprimer.Location = new System.Drawing.Point(132, 270);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(83, 28);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Firebrick;
            this.btnModifier.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifier.Location = new System.Drawing.Point(9, 270);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(86, 28);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvLesDeveloppeurs
            // 
            this.dgvLesDeveloppeurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLesDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesDeveloppeurs.Location = new System.Drawing.Point(9, 25);
            this.dgvLesDeveloppeurs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvLesDeveloppeurs.MultiSelect = false;
            this.dgvLesDeveloppeurs.Name = "dgvLesDeveloppeurs";
            this.dgvLesDeveloppeurs.RowHeadersVisible = false;
            this.dgvLesDeveloppeurs.RowHeadersWidth = 51;
            this.dgvLesDeveloppeurs.RowTemplate.Height = 24;
            this.dgvLesDeveloppeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLesDeveloppeurs.Size = new System.Drawing.Size(555, 235);
            this.dgvLesDeveloppeurs.TabIndex = 0;
            // 
            // gboAjoutDeveloppeur
            // 
            this.gboAjoutDeveloppeur.Controls.Add(this.cboProfil);
            this.gboAjoutDeveloppeur.Controls.Add(this.txtTel);
            this.gboAjoutDeveloppeur.Controls.Add(this.txtMail);
            this.gboAjoutDeveloppeur.Controls.Add(this.txtPrenom);
            this.gboAjoutDeveloppeur.Controls.Add(this.txtNom);
            this.gboAjoutDeveloppeur.Controls.Add(this.btnAnnulerDeveloppeur);
            this.gboAjoutDeveloppeur.Controls.Add(this.btnEnregistrerDeveloppeur);
            this.gboAjoutDeveloppeur.Controls.Add(this.label7);
            this.gboAjoutDeveloppeur.Controls.Add(this.label6);
            this.gboAjoutDeveloppeur.Controls.Add(this.label3);
            this.gboAjoutDeveloppeur.Controls.Add(this.label5);
            this.gboAjoutDeveloppeur.Controls.Add(this.label4);
            this.gboAjoutDeveloppeur.Location = new System.Drawing.Point(19, 339);
            this.gboAjoutDeveloppeur.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboAjoutDeveloppeur.Name = "gboAjoutDeveloppeur";
            this.gboAjoutDeveloppeur.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboAjoutDeveloppeur.Size = new System.Drawing.Size(569, 178);
            this.gboAjoutDeveloppeur.TabIndex = 1;
            this.gboAjoutDeveloppeur.TabStop = false;
            this.gboAjoutDeveloppeur.Text = "Ajouter un développeur";
            // 
            // cboProfil
            // 
            this.cboProfil.BackColor = System.Drawing.Color.LightCoral;
            this.cboProfil.FormattingEnabled = true;
            this.cboProfil.Location = new System.Drawing.Point(376, 113);
            this.cboProfil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboProfil.Name = "cboProfil";
            this.cboProfil.Size = new System.Drawing.Size(157, 27);
            this.cboProfil.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.LightCoral;
            this.txtTel.Location = new System.Drawing.Point(376, 75);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(157, 27);
            this.txtTel.TabIndex = 14;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.LightCoral;
            this.txtMail.Location = new System.Drawing.Point(376, 35);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(157, 27);
            this.txtMail.TabIndex = 13;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.LightCoral;
            this.txtPrenom.Location = new System.Drawing.Point(72, 75);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(144, 27);
            this.txtPrenom.TabIndex = 12;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.LightCoral;
            this.txtNom.Location = new System.Drawing.Point(72, 35);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(144, 27);
            this.txtNom.TabIndex = 11;
            // 
            // btnAnnulerDeveloppeur
            // 
            this.btnAnnulerDeveloppeur.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnulerDeveloppeur.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnulerDeveloppeur.Location = new System.Drawing.Point(132, 136);
            this.btnAnnulerDeveloppeur.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnnulerDeveloppeur.Name = "btnAnnulerDeveloppeur";
            this.btnAnnulerDeveloppeur.Size = new System.Drawing.Size(83, 35);
            this.btnAnnulerDeveloppeur.TabIndex = 10;
            this.btnAnnulerDeveloppeur.Text = "Annuler";
            this.btnAnnulerDeveloppeur.UseVisualStyleBackColor = false;
            this.btnAnnulerDeveloppeur.Click += new System.EventHandler(this.btnAnnulerDeveloppeur_Click);
            // 
            // btnEnregistrerDeveloppeur
            // 
            this.btnEnregistrerDeveloppeur.BackColor = System.Drawing.Color.Firebrick;
            this.btnEnregistrerDeveloppeur.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnregistrerDeveloppeur.Location = new System.Drawing.Point(9, 136);
            this.btnEnregistrerDeveloppeur.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEnregistrerDeveloppeur.Name = "btnEnregistrerDeveloppeur";
            this.btnEnregistrerDeveloppeur.Size = new System.Drawing.Size(86, 35);
            this.btnEnregistrerDeveloppeur.TabIndex = 9;
            this.btnEnregistrerDeveloppeur.Text = "Enregistrer";
            this.btnEnregistrerDeveloppeur.UseVisualStyleBackColor = false;
            this.btnEnregistrerDeveloppeur.Click += new System.EventHandler(this.btnEnregistrerDeveloppeur_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Profil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom";
            // 
            // gboModifPwd
            // 
            this.gboModifPwd.Controls.Add(this.btnAnnulerPwd);
            this.gboModifPwd.Controls.Add(this.btnEnregistrerPwd);
            this.gboModifPwd.Controls.Add(this.txtEncorePwd);
            this.gboModifPwd.Controls.Add(this.txtPwd);
            this.gboModifPwd.Controls.Add(this.label2);
            this.gboModifPwd.Controls.Add(this.label1);
            this.gboModifPwd.Location = new System.Drawing.Point(19, 525);
            this.gboModifPwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboModifPwd.Name = "gboModifPwd";
            this.gboModifPwd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboModifPwd.Size = new System.Drawing.Size(569, 118);
            this.gboModifPwd.TabIndex = 2;
            this.gboModifPwd.TabStop = false;
            this.gboModifPwd.Text = "Changer le mot de passe";
            // 
            // btnAnnulerPwd
            // 
            this.btnAnnulerPwd.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnulerPwd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnulerPwd.Location = new System.Drawing.Point(132, 85);
            this.btnAnnulerPwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnnulerPwd.Name = "btnAnnulerPwd";
            this.btnAnnulerPwd.Size = new System.Drawing.Size(86, 28);
            this.btnAnnulerPwd.TabIndex = 5;
            this.btnAnnulerPwd.Text = "Annuler";
            this.btnAnnulerPwd.UseVisualStyleBackColor = false;
            this.btnAnnulerPwd.Click += new System.EventHandler(this.btnAnnulerPwd_Click);
            // 
            // btnEnregistrerPwd
            // 
            this.btnEnregistrerPwd.BackColor = System.Drawing.Color.Firebrick;
            this.btnEnregistrerPwd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnregistrerPwd.Location = new System.Drawing.Point(9, 85);
            this.btnEnregistrerPwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEnregistrerPwd.Name = "btnEnregistrerPwd";
            this.btnEnregistrerPwd.Size = new System.Drawing.Size(86, 28);
            this.btnEnregistrerPwd.TabIndex = 4;
            this.btnEnregistrerPwd.Text = "Enregistrer";
            this.btnEnregistrerPwd.UseVisualStyleBackColor = false;
            this.btnEnregistrerPwd.Click += new System.EventHandler(this.btnEnregistrerPwd_Click);
            // 
            // txtEncorePwd
            // 
            this.txtEncorePwd.BackColor = System.Drawing.Color.LightCoral;
            this.txtEncorePwd.Location = new System.Drawing.Point(376, 37);
            this.txtEncorePwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEncorePwd.Name = "txtEncorePwd";
            this.txtEncorePwd.PasswordChar = '*';
            this.txtEncorePwd.Size = new System.Drawing.Size(157, 27);
            this.txtEncorePwd.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.LightCoral;
            this.txtPwd.Location = new System.Drawing.Point(61, 37);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(157, 27);
            this.txtPwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pwd";
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(608, 660);
            this.Controls.Add(this.gboModifPwd);
            this.Controls.Add(this.gboAjoutDeveloppeur);
            this.Controls.Add(this.gboLesDeveloppeurs);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations2024";
            this.gboLesDeveloppeurs.ResumeLayout(false);
            this.gboLesDeveloppeurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesDeveloppeurs)).EndInit();
            this.gboAjoutDeveloppeur.ResumeLayout(false);
            this.gboAjoutDeveloppeur.PerformLayout();
            this.gboModifPwd.ResumeLayout(false);
            this.gboModifPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboLesDeveloppeurs;
        private System.Windows.Forms.GroupBox gboAjoutDeveloppeur;
        private System.Windows.Forms.GroupBox gboModifPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulerPwd;
        private System.Windows.Forms.Button btnEnregistrerPwd;
        private System.Windows.Forms.TextBox txtEncorePwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnnulerDeveloppeur;
        private System.Windows.Forms.Button btnEnregistrerDeveloppeur;
        private System.Windows.Forms.ComboBox cboProfil;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dgvLesDeveloppeurs;
        private System.Windows.Forms.Button btnChangerPwd;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

