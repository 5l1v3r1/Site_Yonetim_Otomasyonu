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
using System.Net;
using System.Net.Mail;

namespace Site_Yonetim_Otomasyonu.Screens
{
    public partial class ForgetPasswordForm : XtraForm
    {
        string randomCode;
        public static string to;

        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {

        }
        private void sendCodeButton_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            to = (eMailTextEdit.Text).ToString();
            from = "siteyonetimotomasyonu@gmail.com";
            pass = "asd123dsa123";
            messageBody = "Sifre Sifirlama Kodunuz:"+randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Sifre Sifirlama Kodunuz";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Kodunuz Basariyla Gonderilmistir");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            if (randomCode ==(codeTextEdit.Text).ToString())
            {
                to = eMailTextEdit.Text;
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
                resetPasswordForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Kod ", "Hata",
    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
