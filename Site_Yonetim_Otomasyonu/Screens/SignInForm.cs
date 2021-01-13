
using DevExpress.XtraEditors;
using Site_Yonetim_Otomasyonu.views;
using System;
using System.Windows.Forms;
using Site_Yonetim_Otomasyonu.Connection;
using System.Data;
using Site_Yonetim_Otomasyonu.Screens;
using System.Threading;

namespace Site_Yonetim_Otomasyonu
{
    public partial class LoginForm : XtraForm
    {
        public LoginForm()
        {
//Thread thread = new Thread(new ThreadStart(formRun));
           // thread.Start();
           // Thread.Sleep(1500);
            InitializeComponent();
           // thread.Abort();
        }
      
        public void formRun()
        {
            Application.Run(new SplashForm());
        }

        private void Login_Load(object sender, EventArgs e)
        {
            userNameTextEdit.Select();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();

        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(showPasswordCheckBox.Checked == true)
            {
                passwordTextEdit.Properties.UseSystemPasswordChar = false;

            }
            else
            {
                passwordTextEdit.Properties.UseSystemPasswordChar = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }


        private void Login()
        {
            if (!string.IsNullOrEmpty(userNameTextEdit.Text) &&
                !string.IsNullOrEmpty(passwordTextEdit.Text))
            {
                string mySQL = string.Empty;
                mySQL = "SELECT * FROM  Kullanicilar WHERE KullaniciAdi ='"
                    + userNameTextEdit.Text + "' AND Sifre ='"
                    + passwordTextEdit.Text + "'";

                DataTable userData = ServerConnection.ExecuteSQL(mySQL);

                if (userData.Rows.Count > 0)
                {
                    showPasswordCheckBox.Checked = false;

                    this.Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();

                    mainForm = null;

                    this.Show();
                    this.userNameTextEdit.Select();

                }
                else
                {
                    MessageBox.Show("Kullanici Adi veya Sifre Hatali. Tekrar Deneyin",
                        "Giris Yapilamiyor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    userNameTextEdit.Focus();
                    userNameTextEdit.SelectAll();

                }

            }
            else
            {
                MessageBox.Show("Lutfen Kullanici adi ve Sifre Giriniz", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                userNameTextEdit.Select();
            }
        }

        private void passwordTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void forgetPasswordButton_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            this.Hide();
            forgetPasswordForm.Show();
        }
    }
}
