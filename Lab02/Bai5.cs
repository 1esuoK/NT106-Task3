using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Compression;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void bt_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK) txt_filepath.Text = ofd.FileName;
            }
            progressBar.Value = 0;
        }

        private void bt_compress_Click(object sender, EventArgs e)
        {
            try
            {
                string compressedFilePath;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "GZip files (*.gz)|*.gz|All files (*.*)|*.*";
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    compressedFilePath = sfd.FileName;

                    // Nén tập tin thành tập tin .gz
                    string inputFilePath = txt_filepath.Text;
                    using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream compressedFileStream = File.Create(compressedFilePath))
                        {
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionLevel.Optimal))
                            {
                                inputFileStream.CopyTo(compressionStream);
                                progressBar.Value = 100;
                            }
                        }
                    }
                }
            }
            catch { MessageBox.Show("Fail to Compress!"); }
        }

        private void bt_decompress_Click(object sender, EventArgs e)
        {
            try
            {
                string compressedFilePath = txt_filepath.Text;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                        string decompressedFilePath = saveFileDialog.FileName;
                        using (FileStream compressedFileStream = new FileStream(compressedFilePath, FileMode.Open, FileAccess.Read))
                        {
                            using (FileStream decompressedFileStream = File.Create(decompressedFilePath))
                            {
                                using (GZipStream decompressionStream = new GZipStream(compressedFileStream, CompressionMode.Decompress))
                                {
                                    decompressionStream.CopyTo(decompressedFileStream);
                                    progressBar.Value = 100;
                                }
                            }
                        }
                }
            }
            catch
            {
                MessageBox.Show("Fail to Extract!");
            }

        }
    }
}
