using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Site_Yonetim_Otomasyonu
{
    public partial class LoginForm : XtraForm
    {
        public LoginForm()
        {
            Thread thread = new Thread(new ThreadStart(formRun));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread.Abort();


        }
      
        private void formRun()
        {
            Application.Run(new SplashForm());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }

}
