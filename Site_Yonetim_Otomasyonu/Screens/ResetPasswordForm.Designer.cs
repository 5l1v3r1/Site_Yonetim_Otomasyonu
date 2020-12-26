namespace Site_Yonetim_Otomasyonu.Screens
{
    partial class ResetPasswordForm
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
            this.gradientPanel1 = new Site_Yonetim_Otomasyonu.e();
            this.showPasswordCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.verifyButton = new DevExpress.XtraEditors.SimpleButton();
            this.resetlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.rResetlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rResetlTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 40F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.gradientPanel1.Controls.Add(this.showPasswordCheckBox);
            this.gradientPanel1.Controls.Add(this.verifyButton);
            this.gradientPanel1.Controls.Add(this.resetlTextEdit);
            this.gradientPanel1.Controls.Add(this.idLabel);
            this.gradientPanel1.Controls.Add(this.passwordLabel);
            this.gradientPanel1.Controls.Add(this.rResetlTextEdit);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(346, 298);
            this.gradientPanel1.TabIndex = 9;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.Location = new System.Drawing.Point(142, 178);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showPasswordCheckBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.showPasswordCheckBox.Properties.Appearance.Options.UseFont = true;
            this.showPasswordCheckBox.Properties.Appearance.Options.UseForeColor = true;
            this.showPasswordCheckBox.Properties.Caption = "Sifreyi Goster";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(115, 20);
            this.showPasswordCheckBox.TabIndex = 9;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(90, 218);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(93, 33);
            this.verifyButton.TabIndex = 7;
            this.verifyButton.Text = "Sifirla";
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // resetlTextEdit
            // 
            this.resetlTextEdit.Location = new System.Drawing.Point(90, 81);
            this.resetlTextEdit.Name = "resetlTextEdit";
            this.resetlTextEdit.Properties.Mask.EditMask = "Kullanici";
            this.resetlTextEdit.Properties.UseSystemPasswordChar = true;
            this.resetlTextEdit.Size = new System.Drawing.Size(167, 20);
            this.resetlTextEdit.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.idLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.idLabel.Appearance.Options.UseFont = true;
            this.idLabel.Appearance.Options.UseForeColor = true;
            this.idLabel.Location = new System.Drawing.Point(90, 48);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(95, 24);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Yeni Sifre";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Appearance.Options.UseFont = true;
            this.passwordLabel.Appearance.Options.UseForeColor = true;
            this.passwordLabel.Location = new System.Drawing.Point(90, 113);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(167, 24);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Yeni Sifre Tekrar";
            // 
            // rResetlTextEdit
            // 
            this.rResetlTextEdit.Location = new System.Drawing.Point(90, 152);
            this.rResetlTextEdit.Name = "rResetlTextEdit";
            this.rResetlTextEdit.Properties.UseSystemPasswordChar = true;
            this.rResetlTextEdit.Size = new System.Drawing.Size(167, 20);
            this.rResetlTextEdit.TabIndex = 4;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 298);
            this.Controls.Add(this.gradientPanel1);
            this.IconOptions.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_lock_52px;
            this.MaximizeBox = false;
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordForm";
            this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rResetlTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private e gradientPanel1;
        private DevExpress.XtraEditors.SimpleButton verifyButton;
        private DevExpress.XtraEditors.TextEdit resetlTextEdit;
        private DevExpress.XtraEditors.LabelControl idLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.TextEdit rResetlTextEdit;
        private DevExpress.XtraEditors.CheckEdit showPasswordCheckBox;
    }
}