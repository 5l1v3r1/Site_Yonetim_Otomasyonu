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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.idLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 40F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.simpleButton2);
            this.gradientPanel1.Controls.Add(this.simpleButton1);
            this.gradientPanel1.Controls.Add(this.textEdit1);
            this.gradientPanel1.Controls.Add(this.idLabel);
            this.gradientPanel1.Controls.Add(this.passwordLabel);
            this.gradientPanel1.Controls.Add(this.loginButton);
            this.gradientPanel1.Controls.Add(this.textEdit2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(392, 564);
            this.gradientPanel1.TabIndex = 7;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(150, 506);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 33);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Kayıt OL";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(150, 462);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 33);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Şifremi Unuttum";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(128, 272);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "Kullanici";
            this.textEdit1.Size = new System.Drawing.Size(136, 20);
            this.textEdit1.TabIndex = 3;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
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
            this.idLabel.Click += new System.EventHandler(this.labelControl1_Click);
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
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(150, 365);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(93, 33);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Giriş Yap";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(128, 328);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.UseSystemPasswordChar = true;
            this.textEdit2.Size = new System.Drawing.Size(136, 20);
            this.textEdit2.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.LabelControl idLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private GradientPanel gradientPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

}