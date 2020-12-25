using DevExpress.XtraEditors;
using Site_Yonetim_Otomasyonu.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Yonetim_Otomasyonu.Screens
{
    public partial class UpdateDuesForm : XtraForm
    {
        public string whereDues;
        public UpdateDuesForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ServerConnection.stringConnection);

            if (!string.IsNullOrEmpty(duesNoTextEdit8.Text) &&
                !string.IsNullOrEmpty(duesAprtBoxEdit1.Text) &&
                !string.IsNullOrEmpty(dateEdit1.Text) &&
                !string.IsNullOrEmpty(duesPayEdit5.Text) &&
                !string.IsNullOrEmpty(dmrbsTextEdit4.Text))
            {

                string mySQL = string.Empty;
                connection.Open();

                mySQL = "UPDATE Aidat SET Aidat_No='" + duesNoTextEdit8.Text + "' " +
                    ", Daire_Numarasi='" + duesAprtBoxEdit1.Text + "' " +
                    ", Tarih='" + dateEdit1.Text + "' " +
                    ", Aidat_Ucreti='" + duesPayEdit5.Text + "' " +
                    ", Demirbas_Giderleri='" + dmrbsTextEdit4.Text + "'," +
                    "  Toplam_Tutar = '"+totalTextEdit6.Text+"' WHERE Aidat_No='"+ whereDues +"'";

                SqlCommand cmd = new SqlCommand(mySQL, connection);
                cmd.ExecuteNonQuery();
                connection.Close();



                MessageBox.Show("Basariyla Guncellendi :)",
                "Guncelendi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Lutfen Tum Alanlari Doldurunuz!",
                    "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
