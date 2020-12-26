namespace Site_Yonetim_Otomasyonu.Screens
{
    partial class ForgetPasswordForm
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
            this.verifyButton = new DevExpress.XtraEditors.SimpleButton();
            this.sendCodeButton = new DevExpress.XtraEditors.SimpleButton();
            this.eMailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 40F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.gradientPanel1.Controls.Add(this.verifyButton);
            this.gradientPanel1.Controls.Add(this.sendCodeButton);
            this.gradientPanel1.Controls.Add(this.eMailTextEdit);
            this.gradientPanel1.Controls.Add(this.idLabel);
            this.gradientPanel1.Controls.Add(this.passwordLabel);
            this.gradientPanel1.Controls.Add(this.codeTextEdit);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(346, 298);
            this.gradientPanel1.TabIndex = 8;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(105, 216);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(93, 33);
            this.verifyButton.TabIndex = 7;
            this.verifyButton.Text = "Dogrula";
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // sendCodeButton
            // 
            this.sendCodeButton.Location = new System.Drawing.Point(105, 112);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.Size = new System.Drawing.Size(93, 33);
            this.sendCodeButton.TabIndex = 6;
            this.sendCodeButton.Text = "Gonder";
            this.sendCodeButton.Click += new System.EventHandler(this.sendCodeButton_Click);
            // 
            // eMailTextEdit
            // 
            this.eMailTextEdit.Location = new System.Drawing.Point(105, 83);
            this.eMailTextEdit.Name = "eMailTextEdit";
            this.eMailTextEdit.Properties.Mask.EditMask = "Kullanici";
            this.eMailTextEdit.Size = new System.Drawing.Size(136, 20);
            this.eMailTextEdit.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.idLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.idLabel.Appearance.Options.UseFont = true;
            this.idLabel.Appearance.Options.UseForeColor = true;
            this.idLabel.Location = new System.Drawing.Point(105, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(60, 24);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "E-Mail";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Appearance.Options.UseFont = true;
            this.passwordLabel.Appearance.Options.UseForeColor = true;
            this.passwordLabel.Location = new System.Drawing.Point(105, 154);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(41, 24);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Kod";
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.Location = new System.Drawing.Point(105, 187);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.UseSystemPasswordChar = true;
            this.codeTextEdit.Size = new System.Drawing.Size(136, 20);
            this.codeTextEdit.TabIndex = 4;
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 298);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_lock_52px;
            this.MaximizeBox = false;
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi Unuttum";
            this.Load += new System.EventHandler(this.ForgetPasswordForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private e gradientPanel1;
        private DevExpress.XtraEditors.SimpleButton sendCodeButton;
        private DevExpress.XtraEditors.TextEdit eMailTextEdit;
        private DevExpress.XtraEditors.LabelControl idLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.SimpleButton verifyButton;
    }
}