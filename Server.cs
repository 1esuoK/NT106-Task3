using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDPChatApp
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        IPEndPoint ipe;
        UdpClient server;
        int remotePort = 55555;
        int port = 44444;
        private void bt_send_Click(object sender, EventArgs e)
        {
            try
            {
                server.Connect(ipe);
                server.Send(Encoding.UTF8.GetBytes(tb_message.Text), tb_message.Text.Length);
                tb_message.Clear();
            }
            catch
            {
                MessageBox.Show("Gửi thất bại!");
            }
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            try
            {
                server = new UdpClient(port);
                ipe = new IPEndPoint(IPAddress.Parse(tb_ip.Text), remotePort);
                server.BeginReceive(new AsyncCallback(onReceive), server);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void onReceive(IAsyncResult AR)
        {
            byte[] buff = server.EndReceive(AR, ref ipe);
            server.BeginReceive(new AsyncCallback(onReceive), server);
            ControlInvoke(tb_viewmess, ()=> tb_viewmess.AppendText(">> "+Encoding.UTF8.GetString(buff) + Environment.NewLine));
        }
        delegate void UniversalVoidDelegate();

        public static void ControlInvoke(Control control,Action function)
        {
            if(control.IsDisposed || control.Disposing) return;
            if(control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }

        private void tb_ip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
