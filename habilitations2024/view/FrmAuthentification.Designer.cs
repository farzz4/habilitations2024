namespace habilitations2024.view
{
    partial class FrmAuthentification
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.BtnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saisissez les informations suivantes pour vous connecter : ";
            // 
            // TxtNom
            // 
            this.TxtNom.BackColor = System.Drawing.Color.LightCoral;
            this.TxtNom.Location = new System.Drawing.Point(124, 83);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(159, 27);
            this.TxtNom.TabIndex = 4;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.BackColor = System.Drawing.Color.LightCoral;
            this.TxtPrenom.Location = new System.Drawing.Point(124, 137);
            this.TxtPrenom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(159, 27);
            this.TxtPrenom.TabIndex = 5;
            // 
            // TxtPwd
            // 
            this.TxtPwd.BackColor = System.Drawing.Color.LightCoral;
            this.TxtPwd.Location = new System.Drawing.Point(124, 193);
            this.TxtPwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(159, 27);
            this.TxtPwd.TabIndex = 6;
            // 
            // BtnConnection
            // 
            this.BtnConnection.BackColor = System.Drawing.Color.Firebrick;
            this.BtnConnection.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConnection.Location = new System.Drawing.Point(183, 251);
            this.BtnConnection.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnConnection.Name = "BtnConnection";
            this.BtnConnection.Size = new System.Drawing.Size(100, 28);
            this.BtnConnection.TabIndex = 7;
            this.BtnConnection.Text = "Se connecter";
            this.BtnConnection.UseVisualStyleBackColor = false;
            this.BtnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(343, 294);
            this.Controls.Add(this.BtnConnection);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmAuthentification";
            this.Text = "FrmAuthentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.Button BtnConnection;
    }
}