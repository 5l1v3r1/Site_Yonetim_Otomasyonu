using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Site_Yonetim_Otomasyonu.Connection;

namespace Site_Yonetim_Otomasyonu.Screens
{
    public partial class ResetPasswordForm : XtraForm

    {
        string userName = ForgetPasswordForm.to; 

        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            if (resetlTextEdit.Text == rResetlTextEdit.Text )
            {
                SqlConnection sqlConnection = new SqlConnection(ServerConnection.stringConnection);
                SqlCommand sqlCommand = new SqlCommand("UPDATE Kullanicilar SET Sifre ='"+resetlTextEdit.Text+ "' WHERE Email ='"+ userName + "'",sqlConnection);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Basariyla Sifreniz Guncellendi ", ":)",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();

            }
            else
            {
                MessageBox.Show("Girdiginiz Sifreler Ayni Degil!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                resetlTextEdit.Properties.UseSystemPasswordChar = false;
                rResetlTextEdit.Properties.UseSystemPasswordChar = false;

            }
            else
            {
                resetlTextEdit.Properties.UseSystemPasswordChar = false;
                rResetlTextEdit.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}
