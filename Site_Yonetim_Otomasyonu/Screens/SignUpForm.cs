using DevExpress.XtraEditors;
using System;
using System.Data;
using Site_Yonetim_Otomasyonu.views;
using System.Windows.Forms;

namespace Site_Yonetim_Otomasyonu.views
{
    public partial class SignUpForm : XtraForm
    {
        LoginForm loginForm = new LoginForm();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            nameTextEdit.Select();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                passwordTextEdit.Properties.UseSystemPasswordChar = false;
                rPasswordTextEdit.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextEdit.Properties.UseSystemPasswordChar = true;
                rPasswordTextEdit.Properties.UseSystemPasswordChar = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void Register()
        {
            //check empty on textedit
            if (!string.IsNullOrEmpty(nameTextEdit.Text) &&
                !string.IsNullOrEmpty(lastNameTextEdit.Text) &&
                !string.IsNullOrEmpty(eMailTextEdit.Text) &&
                !string.IsNullOrEmpty(userNameTextEdit.Text) &&
                !string.IsNullOrEmpty(passwordTextEdit.Text) &&
                !string.IsNullOrEmpty(rPasswordTextEdit.Text))
            {

                if (passwordTextEdit.Text == rPasswordTextEdit.Text)
                {

                    //check username for duplicates
                    string sqlUsername = "SELECT KullaniciAdi FROM Kullanicilar WHERE KullaniciAdi = '" + userNameTextEdit.Text + "'";
                    DataTable checkUsername = Site_Yonetim_Otomasyonu.Connection.ServerConnection.ExecuteSQL(sqlUsername);

                    if (checkUsername.Rows.Count > 0)
                    {
                        MessageBox.Show("Kullanici Onceden Kayitli Farkli Bir Kullanici Adi Deneyin",
                            "Uyari",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string mySQL = string.Empty;

                        mySQL = "INSERT INTO Kullanicilar (Isim, SoyIsim, Email, KullaniciAdi,Sifre) " +
                            "VALUES('" + nameTextEdit.Text + "','" + lastNameTextEdit.Text +
                            "','" + eMailTextEdit.Text + "','" + userNameTextEdit.Text +
                            "','" + passwordTextEdit.Text + "')";

                        Site_Yonetim_Otomasyonu.Connection.ServerConnection.ExecuteSQL(mySQL);

                        MessageBox.Show("Basariyla Kayit Oldunuz :)",
                       "Hosgeldiniz",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loginForm.Show();
                        this.Hide();

                    }

                }
                else
                {
                    MessageBox.Show("Girdiginiz Sifreler Uyusmuyor Tekrar Kontrol Ediniz!",
                        "Uyari",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Lutfen Tum Alanlari Doldurunuz!",
                    "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rPasswordTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }
    }
}
