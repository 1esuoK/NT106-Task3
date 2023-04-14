namespace Lab02
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.bt_compress = new System.Windows.Forms.Button();
            this.bt_decompress = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bt_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // txt_filepath
            // 
            this.txt_filepath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_filepath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filepath.ForeColor = System.Drawing.Color.White;
            this.txt_filepath.Location = new System.Drawing.Point(117, 25);
            this.txt_filepath.Multiline = true;
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.ReadOnly = true;
            this.txt_filepath.Size = new System.Drawing.Size(350, 37);
            this.txt_filepath.TabIndex = 1;
            // 
            // bt_compress
            // 
            this.bt_compress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compress.Location = new System.Drawing.Point(538, 25);
            this.bt_compress.Name = "bt_compress";
            this.bt_compress.Size = new System.Drawing.Size(169, 37);
            this.bt_compress.TabIndex = 2;
            this.bt_compress.Text = "Compress";
            this.bt_compress.UseVisualStyleBackColor = true;
            this.bt_compress.Click += new System.EventHandler(this.bt_compress_Click);
            // 
            // bt_decompress
            // 
            this.bt_decompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_decompress.Location = new System.Drawing.Point(538, 71);
            this.bt_decompress.Name = "bt_decompress";
            this.bt_decompress.Size = new System.Drawing.Size(169, 37);
            this.bt_decompress.TabIndex = 2;
            this.bt_decompress.Text = "Decompress";
            this.bt_decompress.UseVisualStyleBackColor = true;
            this.bt_decompress.Click += new System.EventHandler(this.bt_decompress_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(117, 71);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 37);
            this.progressBar.TabIndex = 3;
            // 
            // bt_file
            // 
            this.bt_file.Location = new System.Drawing.Point(484, 25);
            this.bt_file.Name = "bt_file";
            this.bt_file.Size = new System.Drawing.Size(36, 37);
            this.bt_file.TabIndex = 4;
            this.bt_file.Text = "...";
            this.bt_file.UseVisualStyleBackColor = true;
            this.bt_file.Click += new System.EventHandler(this.bt_file_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(730, 147);
            this.Controls.Add(this.bt_file);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bt_decompress);
            this.Controls.Add(this.bt_compress);
            this.Controls.Add(this.txt_filepath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filepath;
        private System.Windows.Forms.Button bt_compress;
        private System.Windows.Forms.Button bt_decompress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button bt_file;
    }
}