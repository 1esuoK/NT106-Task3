namespace Lab02
{
    partial class Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3));
            this.txt_view = new System.Windows.Forms.TextBox();
            this.bt_read = new System.Windows.Forms.Button();
            this.br_write = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_view
            // 
            this.txt_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_view.ForeColor = System.Drawing.Color.White;
            this.txt_view.Location = new System.Drawing.Point(23, 22);
            this.txt_view.Multiline = true;
            this.txt_view.Name = "txt_view";
            this.txt_view.Size = new System.Drawing.Size(699, 268);
            this.txt_view.TabIndex = 0;
            // 
            // bt_read
            // 
            this.bt_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_read.Location = new System.Drawing.Point(123, 308);
            this.bt_read.Name = "bt_read";
            this.bt_read.Size = new System.Drawing.Size(129, 42);
            this.bt_read.TabIndex = 1;
            this.bt_read.Text = "Read File";
            this.bt_read.UseVisualStyleBackColor = true;
            this.bt_read.Click += new System.EventHandler(this.bt_read_Click);
            // 
            // br_write
            // 
            this.br_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_write.Location = new System.Drawing.Point(306, 308);
            this.br_write.Name = "br_write";
            this.br_write.Size = new System.Drawing.Size(129, 42);
            this.br_write.TabIndex = 1;
            this.br_write.Text = "Write File";
            this.br_write.UseVisualStyleBackColor = true;
            this.br_write.Click += new System.EventHandler(this.br_write_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(490, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(746, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.br_write);
            this.Controls.Add(this.bt_read);
            this.Controls.Add(this.txt_view);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_view;
        private System.Windows.Forms.Button bt_read;
        private System.Windows.Forms.Button br_write;
        private System.Windows.Forms.Button button1;
    }
}