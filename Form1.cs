using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void bt_client_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
