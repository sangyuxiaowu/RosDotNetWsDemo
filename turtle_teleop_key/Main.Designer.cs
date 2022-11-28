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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(25, 24);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(105, 23);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(263, 25);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(98, 23);
            this.btnCon.TabIndex = 1;
            this.btnCon.Text = "Connection";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnC_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(156, 26);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(73, 23);
            this.numPort.TabIndex = 2;
            this.numPort.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
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
            // groupBox2
            // 
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
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(21, 33);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(29, 23);
            this.btnE.TabIndex = 0;
            this.btnE.Text = "↖";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(56, 33);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(29, 23);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "↑";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(91, 33);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(29, 23);
            this.btnT.TabIndex = 2;
            this.btnT.Text = "↗";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(91, 62);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(29, 23);
            this.btnG.TabIndex = 5;
            this.btnG.Text = "→";
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(21, 62);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(29, 23);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "←";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(91, 91);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(29, 23);
            this.btnB.TabIndex = 8;
            this.btnB.Text = "↘";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(56, 91);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(29, 23);
            this.btnV.TabIndex = 7;
            this.btnV.Text = "↓";
            this.btnV.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(21, 91);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(29, 23);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "↙";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(95, 68);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(29, 23);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(25, 68);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(29, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(60, 39);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(29, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(60, 68);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(29, 23);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 239);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtIP);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIP;
        private Button btnCon;
        private NumericUpDown numPort;
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
    }
}