namespace Lab02
{
    partial class Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2));
            this.bt_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_linecount = new System.Windows.Forms.TextBox();
            this.txt_charcount = new System.Windows.Forms.TextBox();
            this.txt_wordcount = new System.Windows.Forms.TextBox();
            this.txt_view = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_read
            // 
            this.bt_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_read.Location = new System.Drawing.Point(17, 68);
            this.bt_read.Name = "bt_read";
            this.bt_read.Size = new System.Drawing.Size(346, 37);
            this.bt_read.TabIndex = 0;
            this.bt_read.Text = "Read File";
            this.bt_read.UseVisualStyleBackColor = true;
            this.bt_read.Click += new System.EventHandler(this.bt_read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(12, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lines count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(12, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Words count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(12, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Characters count";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(170, 151);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(193, 27);
            this.txt_name.TabIndex = 2;
            // 
            // txt_size
            // 
            this.txt_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_size.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_size.ForeColor = System.Drawing.Color.White;
            this.txt_size.Location = new System.Drawing.Point(170, 201);
            this.txt_size.Multiline = true;
            this.txt_size.Name = "txt_size";
            this.txt_size.ReadOnly = true;
            this.txt_size.Size = new System.Drawing.Size(193, 27);
            this.txt_size.TabIndex = 2;
            // 
            // txt_url
            // 
            this.txt_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.ForeColor = System.Drawing.Color.White;
            this.txt_url.Location = new System.Drawing.Point(170, 248);
            this.txt_url.Multiline = true;
            this.txt_url.Name = "txt_url";
            this.txt_url.ReadOnly = true;
            this.txt_url.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_url.Size = new System.Drawing.Size(193, 27);
            this.txt_url.TabIndex = 2;
            // 
            // txt_linecount
            // 
            this.txt_linecount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_linecount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_linecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_linecount.ForeColor = System.Drawing.Color.White;
            this.txt_linecount.Location = new System.Drawing.Point(170, 295);
            this.txt_linecount.Multiline = true;
            this.txt_linecount.Name = "txt_linecount";
            this.txt_linecount.ReadOnly = true;
            this.txt_linecount.Size = new System.Drawing.Size(193, 27);
            this.txt_linecount.TabIndex = 2;
            // 
            // txt_charcount
            // 
            this.txt_charcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_charcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_charcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_charcount.ForeColor = System.Drawing.Color.White;
            this.txt_charcount.Location = new System.Drawing.Point(210, 392);
            this.txt_charcount.Multiline = true;
            this.txt_charcount.Name = "txt_charcount";
            this.txt_charcount.ReadOnly = true;
            this.txt_charcount.Size = new System.Drawing.Size(153, 27);
            this.txt_charcount.TabIndex = 2;
            // 
            // txt_wordcount
            // 
            this.txt_wordcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_wordcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_wordcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wordcount.ForeColor = System.Drawing.Color.White;
            this.txt_wordcount.Location = new System.Drawing.Point(170, 346);
            this.txt_wordcount.Multiline = true;
            this.txt_wordcount.Name = "txt_wordcount";
            this.txt_wordcount.ReadOnly = true;
            this.txt_wordcount.Size = new System.Drawing.Size(193, 27);
            this.txt_wordcount.TabIndex = 2;
            // 
            // txt_view
            // 
            this.txt_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_view.ForeColor = System.Drawing.Color.White;
            this.txt_view.Location = new System.Drawing.Point(435, 68);
            this.txt_view.Multiline = true;
            this.txt_view.Name = "txt_view";
            this.txt_view.ReadOnly = true;
            this.txt_view.Size = new System.Drawing.Size(522, 457);
            this.txt_view.TabIndex = 2;
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.Location = new System.Drawing.Point(17, 476);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(118, 37);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(245, 476);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(118, 37);
            this.bt_exit.TabIndex = 3;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(993, 561);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.txt_view);
            this.Controls.Add(this.txt_charcount);
            this.Controls.Add(this.txt_wordcount);
            this.Controls.Add(this.txt_linecount);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_size);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_read);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_linecount;
        private System.Windows.Forms.TextBox txt_charcount;
        private System.Windows.Forms.TextBox txt_wordcount;
        private System.Windows.Forms.TextBox txt_view;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_exit;
    }
}