using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnBlood
{
    public partial class Data_collection_Form1 : Form
    {
        public Data_collection_Form1()
        {
            InitializeComponent();
        }

        private void Nalabel_Click(object sender, EventArgs e)
        {

        }

        private void M_button_Click(object sender, EventArgs e)
        {
            Pmana_Form Pmf = new Pmana_Form();
            Pmf.Show();
            this.Hide();
        }

        private void S_button_Click(object sender, EventArgs e)
        {
            Statistics_Form STF = new Statistics_Form();
            STF.Show();
            this.Hide();
        }

        private void E_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
