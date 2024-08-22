namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.连点 = new System.Windows.Forms.CheckBox();
            this.抖动 = new System.Windows.Forms.CheckBox();
            this.常亮 = new System.Windows.Forms.CheckBox();
            this.置顶 = new System.Windows.Forms.CheckBox();
            this.抖动范围 = new System.Windows.Forms.NumericUpDown();
            this.抖动范围text = new System.Windows.Forms.Label();
            this.录制 = new System.Windows.Forms.CheckBox();
            this.输入 = new System.Windows.Forms.CheckBox();
            this.时UpDown = new System.Windows.Forms.NumericUpDown();
            this.时 = new System.Windows.Forms.Label();
            this.分 = new System.Windows.Forms.Label();
            this.秒 = new System.Windows.Forms.Label();
            this.分UpDown = new System.Windows.Forms.NumericUpDown();
            this.秒UpDown = new System.Windows.Forms.NumericUpDown();
            this.毫 = new System.Windows.Forms.Label();
            this.毫UpDown = new System.Windows.Forms.NumericUpDown();
            this.listtime = new System.Windows.Forms.ListBox();
            this.Promptlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.左键 = new System.Windows.Forms.CheckBox();
            this.中键 = new System.Windows.Forms.CheckBox();
            this.右键 = new System.Windows.Forms.CheckBox();
            this.滚轮 = new System.Windows.Forms.CheckBox();
            this.速度panel = new System.Windows.Forms.Panel();
            this.滚轮UpDown = new System.Windows.Forms.NumericUpDown();
            this.速度text = new System.Windows.Forms.Label();
            this.宏 = new System.Windows.Forms.CheckBox();
            this.宏listBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.执行 = new System.Windows.Forms.Button();
            this.宏panel = new System.Windows.Forms.Panel();
            this.i = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.抖动范围)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.时UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.分UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.秒UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.毫UpDown)).BeginInit();
            this.速度panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.滚轮UpDown)).BeginInit();
            this.宏panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // 连点
            // 
            this.连点.AutoSize = true;
            this.连点.Location = new System.Drawing.Point(12, 37);
            this.连点.Name = "连点";
            this.连点.Size = new System.Drawing.Size(89, 19);
            this.连点.TabIndex = 1;
            this.连点.Text = "鼠标连点";
            this.连点.UseVisualStyleBackColor = true;
            this.连点.CheckedChanged += new System.EventHandler(this.连点_CheckedChanged);
            // 
            // 抖动
            // 
            this.抖动.AutoSize = true;
            this.抖动.Location = new System.Drawing.Point(107, 37);
            this.抖动.Name = "抖动";
            this.抖动.Size = new System.Drawing.Size(89, 19);
            this.抖动.TabIndex = 2;
            this.抖动.Text = "鼠标抖动";
            this.抖动.UseVisualStyleBackColor = true;
            this.抖动.CheckedChanged += new System.EventHandler(this.抖动_CheckedChanged);
            // 
            // 常亮
            // 
            this.常亮.AutoSize = true;
            this.常亮.Location = new System.Drawing.Point(519, 37);
            this.常亮.Name = "常亮";
            this.常亮.Size = new System.Drawing.Size(89, 19);
            this.常亮.TabIndex = 29;
            this.常亮.Text = "屏幕常亮";
            this.常亮.UseVisualStyleBackColor = true;
            this.常亮.CheckedChanged += new System.EventHandler(this.常亮_CheckedChanged);
            // 
            // 置顶
            // 
            this.置顶.AutoSize = true;
            this.置顶.Location = new System.Drawing.Point(413, 37);
            this.置顶.Name = "置顶";
            this.置顶.Size = new System.Drawing.Size(89, 19);
            this.置顶.TabIndex = 30;
            this.置顶.Text = "窗口置顶";
            this.置顶.UseVisualStyleBackColor = true;
            this.置顶.CheckedChanged += new System.EventHandler(this.置顶_CheckedChanged);
            // 
            // 抖动范围
            // 
            this.抖动范围.Location = new System.Drawing.Point(82, 59);
            this.抖动范围.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.抖动范围.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.抖动范围.Name = "抖动范围";
            this.抖动范围.Size = new System.Drawing.Size(150, 25);
            this.抖动范围.TabIndex = 50;
            this.抖动范围.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.抖动范围.ValueChanged += new System.EventHandler(this.抖动范围_ValueChanged);
            // 
            // 抖动范围text
            // 
            this.抖动范围text.AutoSize = true;
            this.抖动范围text.Location = new System.Drawing.Point(9, 64);
            this.抖动范围text.Name = "抖动范围text";
            this.抖动范围text.Size = new System.Drawing.Size(67, 15);
            this.抖动范围text.TabIndex = 51;
            this.抖动范围text.Text = "抖动范围";
            this.抖动范围text.Click += new System.EventHandler(this.抖动范围text_Click);
            // 
            // 录制
            // 
            this.录制.AutoSize = true;
            this.录制.Location = new System.Drawing.Point(112, 88);
            this.录制.Name = "录制";
            this.录制.Size = new System.Drawing.Size(89, 19);
            this.录制.TabIndex = 52;
            this.录制.Text = "录制时长";
            this.录制.UseVisualStyleBackColor = true;
            this.录制.CheckedChanged += new System.EventHandler(this.录制_CheckedChanged);
            // 
            // 输入
            // 
            this.输入.AutoSize = true;
            this.输入.Location = new System.Drawing.Point(12, 88);
            this.输入.Name = "输入";
            this.输入.Size = new System.Drawing.Size(89, 19);
            this.输入.TabIndex = 53;
            this.输入.Text = "输入时长";
            this.输入.UseVisualStyleBackColor = true;
            this.输入.CheckedChanged += new System.EventHandler(this.输入_CheckedChanged);
            // 
            // 时UpDown
            // 
            this.时UpDown.Location = new System.Drawing.Point(40, 113);
            this.时UpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.时UpDown.Name = "时UpDown";
            this.时UpDown.Size = new System.Drawing.Size(99, 25);
            this.时UpDown.TabIndex = 54;
            this.时UpDown.ValueChanged += new System.EventHandler(this.时UpDown_ValueChanged);
            // 
            // 时
            // 
            this.时.AutoSize = true;
            this.时.Location = new System.Drawing.Point(12, 118);
            this.时.Name = "时";
            this.时.Size = new System.Drawing.Size(22, 15);
            this.时.TabIndex = 55;
            this.时.Text = "时";
            this.时.Click += new System.EventHandler(this.时_Click);
            // 
            // 分
            // 
            this.分.AutoSize = true;
            this.分.Location = new System.Drawing.Point(145, 118);
            this.分.Name = "分";
            this.分.Size = new System.Drawing.Size(22, 15);
            this.分.TabIndex = 56;
            this.分.Text = "分";
            this.分.Click += new System.EventHandler(this.分_Click);
            // 
            // 秒
            // 
            this.秒.AutoSize = true;
            this.秒.Location = new System.Drawing.Point(278, 117);
            this.秒.Name = "秒";
            this.秒.Size = new System.Drawing.Size(22, 15);
            this.秒.TabIndex = 57;
            this.秒.Text = "秒";
            this.秒.Click += new System.EventHandler(this.秒_Click);
            // 
            // 分UpDown
            // 
            this.分UpDown.Location = new System.Drawing.Point(173, 113);
            this.分UpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.分UpDown.Name = "分UpDown";
            this.分UpDown.Size = new System.Drawing.Size(99, 25);
            this.分UpDown.TabIndex = 58;
            this.分UpDown.ValueChanged += new System.EventHandler(this.分UpDown_ValueChanged);
            // 
            // 秒UpDown
            // 
            this.秒UpDown.Location = new System.Drawing.Point(306, 113);
            this.秒UpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.秒UpDown.Name = "秒UpDown";
            this.秒UpDown.Size = new System.Drawing.Size(99, 25);
            this.秒UpDown.TabIndex = 59;
            this.秒UpDown.ValueChanged += new System.EventHandler(this.秒UpDown_ValueChanged);
            // 
            // 毫
            // 
            this.毫.AutoSize = true;
            this.毫.Location = new System.Drawing.Point(411, 118);
            this.毫.Name = "毫";
            this.毫.Size = new System.Drawing.Size(37, 15);
            this.毫.TabIndex = 60;
            this.毫.Text = "毫秒";
            this.毫.Click += new System.EventHandler(this.毫_Click);
            // 
            // 毫UpDown
            // 
            this.毫UpDown.Location = new System.Drawing.Point(454, 113);
            this.毫UpDown.Maximum = new decimal(new int[] {
            1910001000,
            0,
            0,
            0});
            this.毫UpDown.Name = "毫UpDown";
            this.毫UpDown.Size = new System.Drawing.Size(93, 25);
            this.毫UpDown.TabIndex = 61;
            this.毫UpDown.ThousandsSeparator = true;
            this.毫UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.毫UpDown.ValueChanged += new System.EventHandler(this.毫UpDown_ValueChanged);
            // 
            // listtime
            // 
            this.listtime.FormattingEnabled = true;
            this.listtime.ItemHeight = 15;
            this.listtime.Location = new System.Drawing.Point(12, 144);
            this.listtime.Name = "listtime";
            this.listtime.Size = new System.Drawing.Size(205, 94);
            this.listtime.TabIndex = 63;
            this.listtime.SelectedIndexChanged += new System.EventHandler(this.listtime_SelectedIndexChanged);
            // 
            // Promptlabel
            // 
            this.Promptlabel.AutoSize = true;
            this.Promptlabel.Location = new System.Drawing.Point(232, 144);
            this.Promptlabel.Name = "Promptlabel";
            this.Promptlabel.Size = new System.Drawing.Size(0, 15);
            this.Promptlabel.TabIndex = 64;
            this.Promptlabel.Click += new System.EventHandler(this.Promptlabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 68;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // 左键
            // 
            this.左键.AutoSize = true;
            this.左键.Location = new System.Drawing.Point(12, 62);
            this.左键.Name = "左键";
            this.左键.Size = new System.Drawing.Size(59, 19);
            this.左键.TabIndex = 69;
            this.左键.Text = "左键";
            this.左键.UseVisualStyleBackColor = true;
            this.左键.CheckedChanged += new System.EventHandler(this.左键_CheckedChanged);
            // 
            // 中键
            // 
            this.中键.AutoSize = true;
            this.中键.Location = new System.Drawing.Point(77, 62);
            this.中键.Name = "中键";
            this.中键.Size = new System.Drawing.Size(59, 19);
            this.中键.TabIndex = 70;
            this.中键.Text = "中键";
            this.中键.UseVisualStyleBackColor = true;
            this.中键.CheckedChanged += new System.EventHandler(this.中键_CheckedChanged);
            // 
            // 右键
            // 
            this.右键.AutoSize = true;
            this.右键.Location = new System.Drawing.Point(142, 62);
            this.右键.Name = "右键";
            this.右键.Size = new System.Drawing.Size(59, 19);
            this.右键.TabIndex = 71;
            this.右键.Text = "右键";
            this.右键.UseVisualStyleBackColor = true;
            this.右键.CheckedChanged += new System.EventHandler(this.右键_CheckedChanged);
            // 
            // 滚轮
            // 
            this.滚轮.AutoSize = true;
            this.滚轮.Location = new System.Drawing.Point(202, 37);
            this.滚轮.Name = "滚轮";
            this.滚轮.Size = new System.Drawing.Size(89, 19);
            this.滚轮.TabIndex = 75;
            this.滚轮.Text = "鼠标滚轮";
            this.滚轮.UseVisualStyleBackColor = true;
            this.滚轮.CheckedChanged += new System.EventHandler(this.滚轮_CheckedChanged);
            // 
            // 速度panel
            // 
            this.速度panel.Controls.Add(this.滚轮UpDown);
            this.速度panel.Controls.Add(this.速度text);
            this.速度panel.Location = new System.Drawing.Point(6, 58);
            this.速度panel.Name = "速度panel";
            this.速度panel.Size = new System.Drawing.Size(555, 81);
            this.速度panel.TabIndex = 77;
            this.速度panel.Paint += new System.Windows.Forms.PaintEventHandler(this.速度panel_Paint);
            // 
            // 滚轮UpDown
            // 
            this.滚轮UpDown.Location = new System.Drawing.Point(46, 2);
            this.滚轮UpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.滚轮UpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.滚轮UpDown.Name = "滚轮UpDown";
            this.滚轮UpDown.Size = new System.Drawing.Size(165, 25);
            this.滚轮UpDown.TabIndex = 51;
            this.滚轮UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.滚轮UpDown.ValueChanged += new System.EventHandler(this.滚轮UpDown_ValueChanged);
            // 
            // 速度text
            // 
            this.速度text.AutoSize = true;
            this.速度text.Location = new System.Drawing.Point(3, 5);
            this.速度text.Name = "速度text";
            this.速度text.Size = new System.Drawing.Size(37, 15);
            this.速度text.TabIndex = 0;
            this.速度text.Text = "速度";
            this.速度text.Click += new System.EventHandler(this.速度text_Click);
            // 
            // 宏
            // 
            this.宏.AutoSize = true;
            this.宏.Location = new System.Drawing.Point(297, 37);
            this.宏.Name = "宏";
            this.宏.Size = new System.Drawing.Size(44, 19);
            this.宏.TabIndex = 78;
            this.宏.Text = "宏";
            this.宏.UseVisualStyleBackColor = true;
            this.宏.CheckedChanged += new System.EventHandler(this.宏_CheckedChanged);
            // 
            // 宏listBox
            // 
            this.宏listBox.FormattingEnabled = true;
            this.宏listBox.ItemHeight = 15;
            this.宏listBox.Location = new System.Drawing.Point(0, 2);
            this.宏listBox.Name = "宏listBox";
            this.宏listBox.Size = new System.Drawing.Size(507, 169);
            this.宏listBox.TabIndex = 79;
            this.宏listBox.SelectedIndexChanged += new System.EventHandler(this.宏listBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "aaa",
            "a",
            "aa",
            "a",
            "a"});
            this.comboBox1.Location = new System.Drawing.Point(510, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 23);
            this.comboBox1.TabIndex = 80;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 执行
            // 
            this.执行.Location = new System.Drawing.Point(510, 5);
            this.执行.Name = "执行";
            this.执行.Size = new System.Drawing.Size(89, 23);
            this.执行.TabIndex = 52;
            this.执行.Text = "执行";
            this.执行.UseVisualStyleBackColor = true;
            this.执行.Click += new System.EventHandler(this.执行_Click);
            // 
            // 宏panel
            // 
            this.宏panel.Controls.Add(this.comboBox1);
            this.宏panel.Controls.Add(this.执行);
            this.宏panel.Controls.Add(this.宏listBox);
            this.宏panel.Location = new System.Drawing.Point(6, 58);
            this.宏panel.Name = "宏panel";
            this.宏panel.Size = new System.Drawing.Size(602, 194);
            this.宏panel.TabIndex = 81;
            this.宏panel.Paint += new System.Windows.Forms.PaintEventHandler(this.宏panel_Paint);
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(519, 5);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(51, 23);
            this.i.TabIndex = 82;
            this.i.Text = "-";
            this.i.UseVisualStyleBackColor = true;
            this.i.Click += new System.EventHandler(this.i_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 23);
            this.button3.TabIndex = 83;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.x_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 292);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.i);
            this.Controls.Add(this.宏);
            this.Controls.Add(this.滚轮);
            this.Controls.Add(this.右键);
            this.Controls.Add(this.中键);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Promptlabel);
            this.Controls.Add(this.listtime);
            this.Controls.Add(this.毫UpDown);
            this.Controls.Add(this.毫);
            this.Controls.Add(this.秒UpDown);
            this.Controls.Add(this.分UpDown);
            this.Controls.Add(this.秒);
            this.Controls.Add(this.分);
            this.Controls.Add(this.时);
            this.Controls.Add(this.时UpDown);
            this.Controls.Add(this.输入);
            this.Controls.Add(this.抖动范围text);
            this.Controls.Add(this.抖动范围);
            this.Controls.Add(this.置顶);
            this.Controls.Add(this.常亮);
            this.Controls.Add(this.抖动);
            this.Controls.Add(this.连点);
            this.Controls.Add(this.左键);
            this.Controls.Add(this.录制);
            this.Controls.Add(this.速度panel);
            this.Controls.Add(this.宏panel);
            this.Name = "Form1";
            this.Text = "连点器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.抖动范围)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.时UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.分UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.秒UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.毫UpDown)).EndInit();
            this.速度panel.ResumeLayout(false);
            this.速度panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.滚轮UpDown)).EndInit();
            this.宏panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox 连点;
        private System.Windows.Forms.CheckBox 抖动;
        private System.Windows.Forms.CheckBox 常亮;
        private System.Windows.Forms.CheckBox 置顶;
        private System.Windows.Forms.NumericUpDown 抖动范围;
        private System.Windows.Forms.Label 抖动范围text;
        private System.Windows.Forms.CheckBox 录制;
        private System.Windows.Forms.CheckBox 输入;
        private System.Windows.Forms.NumericUpDown 时UpDown;
        private System.Windows.Forms.Label 时;
        private System.Windows.Forms.Label 分;
        private System.Windows.Forms.Label 秒;
        private System.Windows.Forms.NumericUpDown 分UpDown;
        private System.Windows.Forms.NumericUpDown 秒UpDown;
        private System.Windows.Forms.Label 毫;
        private System.Windows.Forms.NumericUpDown 毫UpDown;
        private System.Windows.Forms.ListBox listtime;
        private System.Windows.Forms.Label Promptlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox 左键;
        private System.Windows.Forms.CheckBox 中键;
        private System.Windows.Forms.CheckBox 右键;
        private System.Windows.Forms.CheckBox 滚轮;
        private System.Windows.Forms.Panel 速度panel;
        private System.Windows.Forms.Label 速度text;
        private System.Windows.Forms.NumericUpDown 滚轮UpDown;
        private System.Windows.Forms.CheckBox 宏;
        private System.Windows.Forms.ListBox 宏listBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button 执行;
        private System.Windows.Forms.Panel 宏panel;
        private System.Windows.Forms.Button i;
        private System.Windows.Forms.Button button3;
    }
}

