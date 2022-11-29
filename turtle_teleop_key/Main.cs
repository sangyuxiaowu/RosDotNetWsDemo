using System.Diagnostics;
using System.Linq;
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
            if (btnCon.Text == "连接")
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
            //{"op": "publish", "topic": "/turtle1/pose", "msg": {"x": 5.544444561004639, "y": 5.544444561004639, "theta": 0.0, "linear_velocity": 0.0, "angular_velocity": 0.0}}

            Debug.WriteLine(Encoding.UTF8.GetString(e.Data));
        }

        private void ServerDisconnected(object? sender, EventArgs e)
        {
            this.Invoke(() => {
                btnCon.Text = "连接";
                this.Text = "已断开";
                txtIP.Enabled = true;
                numPort.Enabled = true;
                timer.Enabled = false;
            });
        }

        private void ServerConnected(object? sender, EventArgs e)
        {
            this.Invoke(() => {
                btnCon.Text = "断开";
                txtIP.Enabled = false;
                numPort.Enabled= false;
                timer.Enabled = true;
            });

            return;

            // 订阅 /turtle1/cmd_vel  /turtle1/color_sensor   /turtle1/pose
            
            var replyMess = JsonSerializer.Serialize(new
            {
                op = "subscribe",
                topic = "/turtle1/pose",
                type = "turtlesim/msg/Pose"
            });
            _client.SendAsync(replyMess);
            

            // 声明将要发布  /turtle1/cmd_vel  主题
            replyMess = JsonSerializer.Serialize(new
            {
                op = "advertise",
                topic = "/turtle1/cmd_vel",
                type = "geometry_msgs/msg/Twist"
            });
            _client.SendAsync(replyMess);
        }
        public Dictionary<string, double> keypress = new Dictionary<string, double>() {
            {"up",0 },{"down",0 },{"left",0 },{"right",0 }
        };
        private void timer_Tick(object sender, EventArgs e)
        {
            // 没有控制数据变化，不发送
            if (!keypress.Any(e => e.Value != 0)) return;
            var replyMess = JsonSerializer.Serialize(new
            {
                op = "publish",
                topic = "/turtle1/cmd_vel",
                msg = new Twits(new Geometry((keypress["up"]+ keypress["down"]) * (double)numSpeed.Value, 0, 0), new Geometry(0, 0, keypress["left"] + keypress["right"]))
            });
            Debug.WriteLine(replyMess);
            _client.SendAsync(replyMess);
        }

        /// <summary>
        /// 按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_Click(object sender, EventArgs e)
        {
            var info = ((Button)sender).Tag.ToString().Split(",");
            keypress[info[0]] = double.Parse(info[1]);
            await Task.Delay(1000);
            keypress[info[0]] = 0;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    keypress["up"] = 1;
                    break;
                case Keys.Down:
                    keypress["down"] = -1;
                    break; 
                case Keys.Left:
                    keypress["left"] = 1;
                    break;  
                case Keys.Right:
                    keypress["right"] = -1;
                    break;
            }
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    keypress["up"] = 0;
                    break;
                case Keys.Down:
                    keypress["down"] = 0;
                    break;
                case Keys.Left:
                    keypress["left"] = 0;
                    break;
                case Keys.Right:
                    keypress["right"] = 0;
                    break;
            }
        }
    }

    internal sealed record class Geometry(double x,double y, double z);
    internal sealed record class Twits(Geometry linear, Geometry angular);
}