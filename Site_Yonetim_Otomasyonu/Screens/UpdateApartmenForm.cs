using Site_Yonetim_Otomasyonu.Connection;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Site_Yonetim_Otomasyonu.Screens
{
    
    public partial class UpdateApartmenForm : DevExpress.XtraEditors.XtraForm
    {
        public string whereApartment;

        public UpdateApartmenForm()
        {
            InitializeComponent();
        }

        private void UpdateApartmenForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ServerConnection.stringConnection);

            if (!string.IsNullOrEmpty(apartmentNumtextEdit.Text) &&
                !string.IsNullOrEmpty(apartmentStatusComboBoxEdit1.Text) &&
                !string.IsNullOrEmpty(apartmentHostComboBoxEdit2.Text) &&
                !string.IsNullOrEmpty(apartmentPersonComboBoxEdit3.Text) &&
                !string.IsNullOrEmpty(floorUpDown1.Text))
            {

                string mySQL = string.Empty;
                connection.Open();

                mySQL = "UPDATE Daire SET Daire_Numarasi='" + apartmentNumtextEdit.Text + "' " +
                    ", Daire_Durumu='" + apartmentStatusComboBoxEdit1.Text + "' " +
                    ", Daire_Sahibi='" + apartmentHostComboBoxEdit2.Text + "' " +
                    ", Daire_Sakini='" + apartmentPersonComboBoxEdit3.Text + "' " +
                    ", Kat='" + floorUpDown1.Text + "' WHERE Daire_Numarasi='"+whereApartment+"'";

                SqlCommand cmd = new SqlCommand(mySQL, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                MainForm mainForm = new MainForm();
                mainForm.ShowApartmentData("SELECT Daire_Numarasi as 'Daire Numarasi', Daire_Durumu as 'Dairenin Durumu', Daire_Sakini as " +
                "'Daire Sakini',Kat as 'Oturdugu Kat',Daire_Sahibi as 'Daire Sahibi' FROM Daire");



                MessageBox.Show("Basariyla Guncellendi :)",
                "Guncelendi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            } else{
                MessageBox.Show("Lutfen Tum Alanlari Doldurunuz!",
                    "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
