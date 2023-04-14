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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void bt_doc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                txt_view.Text = sr.ReadToEnd();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Đọc File Thất Bại!");
            } 
            
        }

        private void bt_ghi_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(txt_view.Text.ToUpper());
                sw.Flush();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Ghi File Thất Bại!");
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
