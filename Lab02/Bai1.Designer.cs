namespace Lab02
{
    partial class Bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai1));
            this.txt_view = new System.Windows.Forms.TextBox();
            this.bt_doc = new System.Windows.Forms.Button();
            this.bt_ghi = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_view
            // 
            this.txt_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_view.ForeColor = System.Drawing.Color.White;
            this.txt_view.Location = new System.Drawing.Point(12, 53);
            this.txt_view.Multiline = true;
            this.txt_view.Name = "txt_view";
            this.txt_view.Size = new System.Drawing.Size(776, 309);
            this.txt_view.TabIndex = 0;
            // 
            // bt_doc
            // 
            this.bt_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_doc.Location = new System.Drawing.Point(131, 386);
            this.bt_doc.Name = "bt_doc";
            this.bt_doc.Size = new System.Drawing.Size(134, 52);
            this.bt_doc.TabIndex = 1;
            this.bt_doc.Text = "Đọc File";
            this.bt_doc.UseVisualStyleBackColor = true;
            this.bt_doc.Click += new System.EventHandler(this.bt_doc_Click);
            // 
            // bt_ghi
            // 
            this.bt_ghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ghi.Location = new System.Drawing.Point(338, 386);
            this.bt_ghi.Name = "bt_ghi";
            this.bt_ghi.Size = new System.Drawing.Size(134, 52);
            this.bt_ghi.TabIndex = 1;
            this.bt_ghi.Text = "Ghi File";
            this.bt_ghi.UseVisualStyleBackColor = true;
            this.bt_ghi.Click += new System.EventHandler(this.bt_ghi_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_thoat.Location = new System.Drawing.Point(557, 386);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(134, 52);
            this.bt_thoat.TabIndex = 2;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_ghi);
            this.Controls.Add(this.bt_doc);
            this.Controls.Add(this.txt_view);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_view;
        private System.Windows.Forms.Button bt_doc;
        private System.Windows.Forms.Button bt_ghi;
        private System.Windows.Forms.Button bt_thoat;
    }
}