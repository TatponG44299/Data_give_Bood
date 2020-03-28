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
    public partial class Pmana_Form : Form
    {
        public Pmana_Form()
        {
            InitializeComponent();
        }

        private void IDP_label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            SQLiteConnection DBii = new SQLiteConnection("Data Source=C:/Users/Admin/source/repos/Visual_Blood/PDatabase.db3;");
            string query = "INSERT INTO PJ_managar(Project_num, Project_name, location, Name) VALUES('"+ IDP_textBox.Text +"','" + NP_textBox.Text + "','" + Loca_textBox.Text + "' ,'" + MP_textBox.Text +"')";

            SQLiteCommand cmd = new SQLiteCommand(query,DBii);
            DBii.Open();
            cmd.ExecuteNonQuery();
            DBii.Close();
            MessageBox.Show("เพิ่มโครงการเรียบร้อย");

            Data_collection_Form1 DCF = new Data_collection_Form1();
            DCF.Show();
            this.Close();
        }

        private void Pmana_Form_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IDP_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NP_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NP_label_Click(object sender, EventArgs e)
        {

        }

        private void MP_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MP_label_Click(object sender, EventArgs e)
        {

        }
    }
}
