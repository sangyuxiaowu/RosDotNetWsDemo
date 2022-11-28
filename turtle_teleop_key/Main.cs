using System.Diagnostics;
using System.Text;
using System.Text.Json;
using WatsonWebsocket;

namespace turtle_teleop_key
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public WatsonWsClient _client;

        private async void btnC_Click(object sender, EventArgs e)
        {
            btnCon.Enabled = false;
            if (btnCon.Text == "Connection")
            {
                _client = new WatsonWsClient(txtIP.Text, (int)numPort.Value, false);
                _client.ServerConnected += ServerConnected;
                _client.ServerDisconnected += ServerDisconnected;
                _client.MessageReceived += MessageReceived;
                await _client.StartAsync();

                this.Text = _client.Connected ? "已连接" : "连接失败";
  
            }
            else
            {
                if(_client is not null && _client.Connected)
                {
                    await _client.StopAsync();
                    _client.Dispose();
                    _client = null;
                }
            }
            btnCon.Enabled = true;
        }

        private void MessageReceived(object? sender, MessageReceivedEventArgs e)
        {
            Debug.WriteLine(Encoding.UTF8.GetString(e.Data));
        }

        private void ServerDisconnected(object? sender, EventArgs e)
        {
            this.Invoke(() => {
                btnCon.Text = "Connection";
                this.Text = "已断开";
                txtIP.Enabled = true;
                numPort.Enabled = true;
            });
        }

        private void ServerConnected(object? sender, EventArgs e)
        {
            this.Invoke(() => {
                btnCon.Text = "Disconnects";
                txtIP.Enabled = false;
                numPort.Enabled= false;
            });

            // 订阅 /turtle1/cmd_vel  /turtle1/color_sensor   /turtle1/pose
            var replyMess = JsonSerializer.Serialize(new
            {
                op = "subscribe",
                topic = "/turtle1/pose",
                type = "turtlesim/msg/Pose"
            });
            _client.SendAsync(replyMess);
        }

        
    }
}