using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChatApp
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        UdpClient client;
        IPEndPoint ipe;
        int port = 55555;
        int remotePort = 44444;

        private void bt_connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new UdpClient(port);
                ipe = new IPEndPoint(IPAddress.Parse(tb_ip.Text), remotePort);
                client.BeginReceive(new AsyncCallback(onReceive), client);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void onReceive(IAsyncResult AR)
        {
            byte[] buff = client.EndReceive(AR, ref ipe);
            client.BeginReceive(new AsyncCallback(onReceive), client);
            ControlInvoke(tb_viewmess, () => tb_viewmess.AppendText(">> " + Encoding.UTF8.GetString(buff) + Environment.NewLine));
        }
        delegate void UniversalVoidDelegate();

        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing) return;
            if (control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(ipe);
                client.Send(Encoding.UTF8.GetBytes(tb_message.Text), tb_message.Text.Length);
                tb_message.Clear();
            }
            catch
            {
                MessageBox.Show("Gửi thất bại!");
            }
        }
    }
}
