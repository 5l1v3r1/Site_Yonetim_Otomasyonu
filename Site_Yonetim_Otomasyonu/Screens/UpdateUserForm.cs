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
    public partial class UpdateUserForm : XtraForm
    {
        SqlConnection connection = new SqlConnection(ServerConnection.stringConnection);
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sahipCheckedComboBoxEdit1.Text) &&
                !string.IsNullOrEmpty(nameTextEdit.Text) &&
                !string.IsNullOrEmpty(lastNameTextEdit.Text) &&
                !string.IsNullOrEmpty(telTextEdit.Text) &&
                !string.IsNullOrEmpty(eMailtextEdit1.Text) &&
                !string.IsNullOrEmpty(adressTextBox.Text) &&
                !string.IsNullOrEmpty(explanationTextBox.Text))
            {

                string mySQL = string.Empty;
                connection.Open();

                mySQL = "UPDATE Kisi SET Ad='" + nameTextEdit.Text.ToLower() + "' " +
                    ", Soyad='" + lastNameTextEdit.Text.ToLower() + "' " +
                    ", Telefon_No='" + telTextEdit.Text + "' " +
                    ", E_Mail='"+eMailtextEdit1.Text+"' " +
                    ", Is_Adresi='"+adressTextBox.Text+"' " +
                    ", Aciklama='"+explanationTextBox.Text+"' " +
                    ", Daire_Sahibi='"+sahipCheckedComboBoxEdit1.Text+"'";

                SqlCommand cmd = new SqlCommand(mySQL, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                MainForm mainForm = new MainForm();

                mainForm.ShowPersonData("Select Daire_Sahibi as 'Sahiplik Durumu', " +
                "Ad,Soyad,Telefon_No as 'Telefon Numarasi',E_Mail as 'E posta" +
                "',Aciklama,Is_Adresi as'Is Adresi', Kisi_ID as'Kisi Numarasi' From Kisi");

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
