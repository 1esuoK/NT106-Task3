using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bt_bai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.Show();
        }

        private void bt_bai2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.Show();
        }

        private void bt_bai4_Click(object sender, EventArgs e)
        {
            Bai4 b4 = new Bai4();
            b4.Show();
        }

        private void bt_bai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.Show();
        }

        private void bt_bai6_Click(object sender, EventArgs e)
        {
            Bai6 b6 = new Bai6();
            b6.Show();
        }

        private void bt_bai5_Click(object sender, EventArgs e)
        {
            Bai5 b5 = new Bai5();
            b5.Show();
        }
    }
}
