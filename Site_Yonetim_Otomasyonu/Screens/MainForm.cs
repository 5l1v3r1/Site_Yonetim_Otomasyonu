using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Site_Yonetim_Otomasyonu.Connection;

namespace Site_Yonetim_Otomasyonu.Screens
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection = new SqlConnection(ServerConnection.stringConnection);
        public MainForm()
        {
            InitializeComponent();
            ShowData("Select Daire_Sahibi as 'Sahiplik Durumu', " +
                "Ad,Soyad,Telefon_No as 'Telefon Numarasi',E_Mail as 'E posta" +
                "',Aciklama,Is_Adresi as'Is Adresi', Kisi_ID as'Kisi Numarasi' From Kisi");
            connection.Close();
        }

        public void ShowData(string data)
        {

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(data, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void employeesNavigationPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel7_Paint(object sender, PaintEventArgs e)
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
                !string.IsNullOrEmpty(explanationTextBox.Text) 
                )
            {
                //check users 
                string sql= "SELECT * FROM Kisi WHERE Ad = '" + nameTextEdit.Text + "' AND Soyad = '" + lastNameTextEdit.Text + "'";
                DataTable checkUsers = Site_Yonetim_Otomasyonu.Connection.ServerConnection.ExecuteSQL(sql);
                if (checkUsers.Rows.Count > 0)
                {
                    MessageBox.Show("Kullanici Onceden Kayitli Farkli Bir Kullanici Adi Deneyin",
                        "Uyari",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string mySQL = string.Empty;

                    mySQL = "INSERT INTO Kisi (Ad, Soyad, Telefon_No, E_Mail,Is_Adresi,Aciklama,Daire_Sahibi) " +
                        "VALUES('" + nameTextEdit.Text.ToLower() + "','" + lastNameTextEdit.Text.ToLower() +
                        "','" + telTextEdit.Text + "','" + eMailtextEdit1.Text +
                        "','" + adressTextBox.Text + "','" + explanationTextBox.Text + "','" + sahipCheckedComboBoxEdit1.Text + "')";

                    Site_Yonetim_Otomasyonu.Connection.ServerConnection.ExecuteSQL(mySQL);

                    MessageBox.Show("Basariyla Kayit Oldunuz :)",
                   "Hosgeldiniz",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


            }
            else
            {
                 MessageBox.Show("Lutfen Tum Alanlari Doldurunuz!",
                    "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sahipCheckedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !string.IsNullOrEmpty(textEdit2.Text))
            {
                ShowData("Select Daire_Sahibi as 'Sahiplik Durumu', " +
                "Ad,Soyad,Telefon_No as 'Telefon Numarasi',E_Mail as 'E posta" +
                "',Aciklama,Is_Adresi as'Is Adresi' From Kisi Where Daire_Sahibi='"+ textEdit2.Text+"'");
            }else if(radioButton2.Checked && !string.IsNullOrEmpty(textEdit2.Text)) {
                ShowData("Select Daire_Sahibi as 'Sahiplik Durumu', " +
               "Ad,Soyad,Telefon_No as 'Telefon Numarasi',E_Mail as 'E posta" +
               "',Aciklama,Is_Adresi as'Is Adresi' From Kisi Where Ad='" + textEdit2.Text + "'");
            }
            else if (radioButton3.Checked && !string.IsNullOrEmpty(textEdit2.Text))
            {
                ShowData("Select Daire_Sahibi as 'Sahiplik Durumu', " +
               "Ad,Soyad,Telefon_No as 'Telefon Numarasi',E_Mail as 'E posta" +
               "',Aciklama,Is_Adresi as'Is Adresi' From Kisi Where Soyad='" + textEdit2.Text + "'");
            }
            else
            {
                MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tabPane1.SelectNextPage();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                connection.Open();
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                string selectedUser=dataGridView1.CurrentRow.Cells[7].Value.ToString();
                SqlCommand cmd = new SqlCommand("DELETE FROM Kisi WHERE Kisi_ID ="+selectedUser+"", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kisi Silindi!", "Harika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kisi Secin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dataGridView1.CurrentRow.Cells[7].Value);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUserForm = new UpdateUserForm();

            updateUserForm.sahipCheckedComboBoxEdit1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateUserForm.nameTextEdit.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateUserForm.lastNameTextEdit.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateUserForm.telTextEdit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateUserForm.eMailtextEdit1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateUserForm.explanationTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateUserForm.adressTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            updateUserForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}