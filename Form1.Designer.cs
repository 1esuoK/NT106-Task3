namespace UDPChatApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_server = new System.Windows.Forms.Button();
            this.bt_client = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_server
            // 
            this.bt_server.BackColor = System.Drawing.Color.White;
            this.bt_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_server.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.bt_server.Location = new System.Drawing.Point(180, 274);
            this.bt_server.Name = "bt_server";
            this.bt_server.Size = new System.Drawing.Size(170, 64);
            this.bt_server.TabIndex = 0;
            this.bt_server.Text = "Server";
            this.bt_server.UseVisualStyleBackColor = false;
            this.bt_server.Click += new System.EventHandler(this.bt_server_Click);
            // 
            // bt_client
            // 
            this.bt_client.BackColor = System.Drawing.Color.White;
            this.bt_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.bt_client.Location = new System.Drawing.Point(445, 274);
            this.bt_client.Name = "bt_client";
            this.bt_client.Size = new System.Drawing.Size(170, 64);
            this.bt_client.TabIndex = 0;
            this.bt_client.Text = "Client";
            this.bt_client.UseVisualStyleBackColor = false;
            this.bt_client.Click += new System.EventHandler(this.bt_client_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_client);
            this.Controls.Add(this.bt_server);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Discord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_server;
        private System.Windows.Forms.Button bt_client;
        private System.Windows.Forms.Label label1;
    }
}

