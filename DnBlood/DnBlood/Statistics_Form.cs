using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DnBlood
{
    public partial class Statistics_Form : Form
    {
        public Statistics_Form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IDP_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDC_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_button_Click(object sender, EventArgs e)
        {
            Data_collection_Form1 DCF = new Data_collection_Form1();
            DCF.Show();
            this.Close();
        }

        private void C_button_Click(object sender, EventArgs e)
        {
            SQLiteConnection SA = new SQLiteConnection("Data Source=C:/Users/Admin/source/repos/Visual_Blood/PDatabase.db3;");
            string query = "INSERT INTO Sa_Table(ID_Project, ID_Customs) VALUES('" + IDP_textBox.Text + "','" + IDC_textBox.Text + "')";

            SQLiteCommand Aom = new SQLiteCommand(query, SA);
            SA.Open();
            Aom.ExecuteNonQuery();
            SA.Close();
            MessageBox.Show("บันทึกเรียบร้อย");

            Data_collection_Form1 DCF = new Data_collection_Form1();
            DCF.Show();
            this.Close();
        }
    }
}
