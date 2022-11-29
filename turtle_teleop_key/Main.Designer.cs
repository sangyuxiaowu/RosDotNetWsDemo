namespace turtle_teleop_key
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnB = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.btnCon = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnB);
            this.groupBox1.Controls.Add(this.btnV);
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Controls.Add(this.btnG);
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btnT);
            this.groupBox1.Controls.Add(this.btnR);
            this.groupBox1.Controls.Add(this.btnE);
            this.groupBox1.Location = new System.Drawing.Point(25, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "F";
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(91, 91);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(29, 23);
            this.btnB.TabIndex = 8;
            this.btnB.TabStop = false;
            this.btnB.Text = "↘";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(56, 91);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(29, 23);
            this.btnV.TabIndex = 7;
            this.btnV.TabStop = false;
            this.btnV.Text = "↓";
            this.btnV.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(21, 91);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(29, 23);
            this.btnC.TabIndex = 6;
            this.btnC.TabStop = false;
            this.btnC.Text = "↙";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(91, 62);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(29, 23);
            this.btnG.TabIndex = 5;
            this.btnG.TabStop = false;
            this.btnG.Text = "→";
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(21, 62);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(29, 23);
            this.btnD.TabIndex = 3;
            this.btnD.TabStop = false;
            this.btnD.Text = "←";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(91, 33);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(29, 23);
            this.btnT.TabIndex = 2;
            this.btnT.TabStop = false;
            this.btnT.Text = "↗";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(56, 33);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(29, 23);
            this.btnR.TabIndex = 1;
            this.btnR.TabStop = false;
            this.btnR.Text = "↑";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(21, 33);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(29, 23);
            this.btnE.TabIndex = 0;
            this.btnE.TabStop = false;
            this.btnE.Text = "↖";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numSpeed);
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Location = new System.Drawing.Point(213, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "速度";
            // 
            // numSpeed
            // 
            this.numSpeed.DecimalPlaces = 1;
            this.numSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSpeed.Location = new System.Drawing.Point(77, 22);
            this.numSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(47, 23);
            this.numSpeed.TabIndex = 10;
            this.numSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(60, 91);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(29, 23);
            this.btnDown.TabIndex = 9;
            this.btnDown.TabStop = false;
            this.btnDown.Tag = "down,-1";
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(95, 91);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(29, 23);
            this.btnRight.TabIndex = 8;
            this.btnRight.TabStop = false;
            this.btnRight.Tag = "right,-1";
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(25, 91);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(29, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.TabStop = false;
            this.btnLeft.Tag = "left,1";
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(60, 62);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(29, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.TabStop = false;
            this.btnUp.Tag = "up,1";
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(25, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(336, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "点击激活键盘控制";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Controls.Add(this.btnCon);
            this.groupBox3.Controls.Add(this.txtIP);
            this.groupBox3.Location = new System.Drawing.Point(25, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 67);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "连接";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(137, 28);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(73, 23);
            this.numPort.TabIndex = 5;
            this.numPort.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(232, 27);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(80, 23);
            this.btnCon.TabIndex = 1;
            this.btnCon.Text = "连接";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(15, 28);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(105, 23);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 318);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnB;
        private Button btnV;
        private Button btnC;
        private Button btnG;
        private Button btnD;
        private Button btnT;
        private Button btnR;
        private Button btnE;
        private Button btnRight;
        private Button btnLeft;
        private Button btnUp;
        private Button btnDown;
        private Label label1;
        private System.Windows.Forms.Timer timer;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private NumericUpDown numPort;
        private Button btnCon;
        private TextBox txtIP;
        private Label label2;
        private NumericUpDown numSpeed;
    }
}