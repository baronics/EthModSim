using System;
using System.Net.Sockets;
using System.Windows.Forms;

/// <summary>
/// Simulates the Ethernet Module
/// </summary>
namespace EthModSim
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.em;
        }

        private void OnSend(object sender, EventArgs e)
        {
            string mcpAddress = tbIp.Text;
            int port = 1236;

            // Do all this on background thread

            try
            {
                using TcpClient client = new TcpClient();
                Output($"Connecting to {mcpAddress}:{port} ...");
                if (!client.ConnectAsync(mcpAddress, port).Wait(1000))
                {
                    Output("Connection failure");
                    return;
                }

                NetworkStream stream = client.GetStream();

                // Send the message to the connected MCP
                // { 0xff, 0x06, 0x47, 0x69, 0x31, 0x2f, 0x30, 0x37, 0x0b, 0x44, 0x65, 0x6d, 0x6f, 0x2d, 0x53, 0x77, 0x69, 0x74, 0x63, 0x68 }
                using (BuildByteArray bba = new BuildByteArray())
                {
                    bba.Add(0xFF);
                    bba.AddWithLength(tbSwitchPort.Text);
                    bba.AddWithLength(tbSwitch.Text);
                    stream.Write(bba.ToArray());
                    Output($"Sent: {HexConvert(bba.ToArray())}");
                }

                // Buffer to store the response bytes. 01 07 BF AD where 01 07 means the data received correctly and BF AD is CRC.
                Span<byte> rxData = stackalloc byte[8];
                int rxLen = stream.Read(rxData);
                Output($"Rcvd: {HexConvert(rxData.Slice(0, rxLen).ToArray())}");
            }
            catch (Exception ex)
            {
                Output(ex.Message);
            }
        }

        private void Output(string message)
        {
            tbStatus.AppendText(message + Environment.NewLine);
        }

        private static string HexConvert(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", " ");
        }

        private void OnClear(object sender, EventArgs e)
        {
            tbStatus.Clear();
        }
    }
}
