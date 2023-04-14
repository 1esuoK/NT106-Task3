using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void bt_read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string str = sr.ReadToEnd();
                txt_view.Text = str;
                txt_name.Text = ofd.SafeFileName.ToString();
                txt_url.Text = fs.Name.ToString();
                txt_size.Text = new System.IO.FileInfo(fs.Name).Length.ToString();
                txt_linecount.Text = str.Split('\n').Length.ToString();
                txt_wordcount.Text = str.Split(' ', '\n').Length.ToString();
                txt_charcount.Text = str.Length.ToString();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Đọc File Thất Bại!");
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_url.Clear();
            txt_size.Clear();
            txt_linecount.Clear();
            txt_wordcount.Clear();
            txt_charcount.Clear();
            txt_name.Clear();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
