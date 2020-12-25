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
    public partial class CarUpdate : XtraForm
    {
        public string whereCar;

        public CarUpdate()
        {
            InitializeComponent();
        }



        private void simpleButton19_Click(object sender, EventArgs e)

        {
            SqlConnection connection = new SqlConnection(ServerConnection.stringConnection);

            if (!string.IsNullOrEmpty(carPTextEdit7.Text) &&
                !string.IsNullOrEmpty(carBrandTextEdit5.Text) &&
                !string.IsNullOrEmpty(carModelTextEdit6.Text) &&
                !string.IsNullOrEmpty(carApComboBoxEdit3.Text) &&
                !string.IsNullOrEmpty(carTelTextEdit8.Text) )
            {

                string mySQL = string.Empty;
                connection.Open();

                mySQL = "UPDATE Arac SET Arac_Plaka='" + carPTextEdit7.Text + "' " +
                    ", Marka='" + carBrandTextEdit5.Text + "' " +
                    ", Model='" + carModelTextEdit6.Text + "' " +
                    ", Daire_Numarasi='" + carApComboBoxEdit3.Text + "' " +
                    ", Irtibat_No='" + carTelTextEdit8.Text + "' WHERE Arac_ID='" + whereCar+"'" ;

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
