namespace Site_Yonetim_Otomasyonu
{
    partial class LoginForm
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
            this.gradientPanel1 = new Site_Yonetim_Otomasyonu.GradientPanel();
            this.showPasswordCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerButton = new DevExpress.XtraEditors.SimpleButton();
            this.forgetPasswordButton = new DevExpress.XtraEditors.SimpleButton();
            this.userNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 40F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.gradientPanel1.Controls.Add(this.showPasswordCheckBox);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.registerButton);
            this.gradientPanel1.Controls.Add(this.forgetPasswordButton);
            this.gradientPanel1.Controls.Add(this.userNameTextEdit);
            this.gradientPanel1.Controls.Add(this.idLabel);
            this.gradientPanel1.Controls.Add(this.passwordLabel);
            this.gradientPanel1.Controls.Add(this.loginButton);
            this.gradientPanel1.Controls.Add(this.passwordTextEdit);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(392, 564);
            this.gradientPanel1.TabIndex = 7;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.Location = new System.Drawing.Point(249, 354);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showPasswordCheckBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.showPasswordCheckBox.Properties.Appearance.Options.UseFont = true;
            this.showPasswordCheckBox.Properties.Appearance.Options.UseForeColor = true;
            this.showPasswordCheckBox.Properties.Caption = "Sifreyi Goster";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(115, 20);
            this.showPasswordCheckBox.TabIndex = 8;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_lock_208px;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 211);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(150, 506);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(93, 33);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Kayıt OL";
            this.registerButton.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // forgetPasswordButton
            // 
            this.forgetPasswordButton.Location = new System.Drawing.Point(150, 462);
            this.forgetPasswordButton.Name = "forgetPasswordButton";
            this.forgetPasswordButton.Size = new System.Drawing.Size(93, 33);
            this.forgetPasswordButton.TabIndex = 5;
            this.forgetPasswordButton.Text = "Şifremi Unuttum";
            // 
            // userNameTextEdit
            // 
            this.userNameTextEdit.Location = new System.Drawing.Point(128, 272);
            this.userNameTextEdit.Name = "userNameTextEdit";
            this.userNameTextEdit.Properties.Mask.EditMask = "Kullanici";
            this.userNameTextEdit.Size = new System.Drawing.Size(136, 20);
            this.userNameTextEdit.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.idLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.idLabel.Appearance.Options.UseFont = true;
            this.idLabel.Appearance.Options.UseForeColor = true;
            this.idLabel.Location = new System.Drawing.Point(134, 242);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(124, 24);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Kullanıcı Adı";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Appearance.Options.UseFont = true;
            this.passwordLabel.Appearance.Options.UseForeColor = true;
            this.passwordLabel.Location = new System.Drawing.Point(169, 298);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(46, 24);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Şifre";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(150, 377);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(93, 33);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(128, 328);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.UseSystemPasswordChar = true;
            this.passwordTextEdit.Size = new System.Drawing.Size(136, 20);
            this.passwordTextEdit.TabIndex = 4;
            this.passwordTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextEdit_KeyDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 564);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = global::Site_Yonetim_Otomasyonu.Properties.Resources.customer_32x321;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.LabelControl idLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.TextEdit userNameTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private GradientPanel gradientPanel1;
        private DevExpress.XtraEditors.SimpleButton registerButton;
        private DevExpress.XtraEditors.SimpleButton forgetPasswordButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.CheckEdit showPasswordCheckBox;
    }

}