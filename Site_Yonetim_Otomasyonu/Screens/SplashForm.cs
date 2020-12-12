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

namespace Site_Yonetim_Otomasyonu
{
    public partial class SplashForm : XtraForm
    {
        int move = 5;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 5;

            if (panelSlide.Left>504)
            {
                panelSlide.Left = 0;

            }
            if (panelSlide.Left < 0)
            {
                move = -100;

            }

        }
    }
}
