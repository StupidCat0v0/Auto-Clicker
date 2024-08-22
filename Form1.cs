using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Controls;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        struct mouse
        {
            public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
            public const int MOUSEEVENTF_LEFTUP = 0x0004;
            public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
            public const int MOUSEEVENTF_RIGHTUP = 0x0010;
            public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
            public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
            public const int MOUSEEVENTF_WHEEL = 0x800;
            public const int KEYEVENTF_KEYUP = 0x0002;
            public const int VK_F6 = 0x75;
            public const int VK_F7 = 0x76;
            public const int VK_F8 = 0x77;
        }

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk,
            byte bScan,
            int dwFlags,  //这里是整数类型  0 为按下，2为释放
            int dwExtraInfo  //这里是整数类型 一般情况下设成为 0
        );

        [DllImport("user32.dll")]
        public static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        [DllImport("user32.dll")]
        public static extern int MessageBeep(uint uType);
        uint beepI = 0x00000010;

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("kernel32")]
        static extern uint GetTickCount();

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern int SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//跨线程访问

            Thread thread = new Thread(this.read);
            thread.IsBackground = true;
            thread.Start();

            抖动范围text.Visible = false;
            抖动范围.Visible = false;
            Promptlabel.Visible = false;
            输入.Checked = true;
            连点.Checked = true;
            左键.Checked = true;
            Promptlabel.Visible = true;
            速度panel.Visible = false;
            宏listBox.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void 抖动范围_ValueChanged(object sender, EventArgs e) { }
        private void 抖动范围text_Click(object sender, EventArgs e) { }

        private void 连点_CheckedChanged(object sender, EventArgs e)
        {
            if (连点.Checked == true)
            {
                抖动.Checked = false;
                滚轮.Checked = false;
                宏.Checked = false;
                速度panel.Visible = false;
                抖动范围text.Visible = false;
                抖动范围.Visible = false;
                左键.Visible = true;
                中键.Visible = true;
                右键.Visible = true;

                宏panel.SendToBack();
                宏panel.Visible = false;
                宏listBox.Visible = false;
                执行.Visible = false;
                comboBox1.Visible = false;
            }
        }
        private void 抖动_CheckedChanged(object sender, EventArgs e)
        {
            if (抖动.Checked == true)
            {
                连点.Checked = false;
                滚轮.Checked = false;
                宏.Checked = false;
                速度panel.Visible = false;
                抖动范围text.Visible = true;
                抖动范围.Visible = true;
                左键.Visible = false;
                中键.Visible = false;
                右键.Visible = false;

                宏panel.SendToBack();
                宏panel.Visible = false;
                宏listBox.Visible = false;
                执行.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private void 左键_CheckedChanged(object sender, EventArgs e)
        {
            if (左键.Checked == true)
            {
                中键.Checked = false;
                右键.Checked = false;
            }
        }
        private void 中键_CheckedChanged(object sender, EventArgs e)
        {
            if (中键.Checked == true)
            {
                左键.Checked = false;
                右键.Checked = false;
            }
        }
        private void 右键_CheckedChanged(object sender, EventArgs e)
        {
            if (右键.Checked == true)
            {
                中键.Checked = false;
                左键.Checked = false;
            }
        }

        private void 时_Click(object sender, EventArgs e) { }
        private void 时UpDown_ValueChanged(object sender, EventArgs e) { }
        private void 分_Click(object sender, EventArgs e) { }
        private void 分UpDown_ValueChanged(object sender, EventArgs e) { }
        private void 秒_Click(object sender, EventArgs e) { }
        private void 秒UpDown_ValueChanged(object sender, EventArgs e) { }
        private void 毫_Click(object sender, EventArgs e) { }
        private void 毫UpDown_ValueChanged(object sender, EventArgs e) { }
        private void listtime_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Promptlabel_Click(object sender, EventArgs e) { }

        private void 录制_CheckedChanged(object sender, EventArgs e)
        {
            if (录制.Checked == true)
            {
                this.Promptlabel.Text = "F6开始录制\r\n左键点击6次";
                listtime.Items.Clear();
                Promptlabel.Visible = true;
                输入.Checked = false;
                时UpDown.Visible = false;
                分UpDown.Visible = false;
                秒UpDown.Visible = false;
                毫UpDown.Visible = false;
                时.Visible = false;
                分.Visible = false;
                秒.Visible = false;
                毫.Visible = false;
            }
        }
        private void 输入_CheckedChanged(object sender, EventArgs e)
        {
            if (输入.Checked == true)
            {
                this.Promptlabel.Text = "F6开始/暂停\r\nF8反滚动";
                listtime.Items.Clear();
                录制.Checked = false;
                Promptlabel.Visible = true;
                时UpDown.Visible = true;
                分UpDown.Visible = true;
                秒UpDown.Visible = true;
                毫UpDown.Visible = true;
                时.Visible = true;
                分.Visible = true;
                秒.Visible = true;
                毫.Visible = true;
            }
        }

        public static class SystemSleep
        {
            [DllImport("kernel32")]
            private static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);
            [Flags]
            private enum ExecutionState : uint
            {
                SystemRequired = 0x01,

                DisplayRequired = 0x02,

                [Obsolete("This value is not supported.")]
                UserPresent = 0x04,
                AwaymodeRequired = 0x40,
                Continuous = 0x80000000,
            }

            public static void PreventForCurrentThread(bool keepDisplayOn = true)
            {
                SetThreadExecutionState(keepDisplayOn
                    ? ExecutionState.Continuous | ExecutionState.SystemRequired | ExecutionState.DisplayRequired
                    : ExecutionState.Continuous | ExecutionState.SystemRequired);
            }
            public static void RestoreForCurrentThread()
            {
                SetThreadExecutionState(ExecutionState.Continuous);
            }
            public static void ResetIdle(bool keepDisplayOn = true)
            {
                SetThreadExecutionState(keepDisplayOn
                    ? ExecutionState.SystemRequired | ExecutionState.DisplayRequired
                    : ExecutionState.SystemRequired);
            }
        }
        private void 常亮_CheckedChanged(object sender, EventArgs e)
        {
            if (常亮.Checked == true)
                SystemSleep.PreventForCurrentThread();
            else
                SystemSleep.RestoreForCurrentThread();
        }

        private void 置顶_CheckedChanged(object sender, EventArgs e)
        {
            if (置顶.Checked == true)
                this.TopMost = true;
            else
                this.TopMost = false;
        }


        public struct FLASHWINFO
        {
            public UInt32 cbSize;
            public IntPtr hwnd;
            public UInt32 dwFlags;
            public UInt32 uCount;
            public UInt32 dwTimeout;
        }
        public enum falshType : uint
        {
            FLASHW_STOP = 0,    //停止闪烁
            FALSHW_CAPTION = 1,  //只闪烁标题
            FLASHW_TRAY = 2,   //只闪烁任务栏
            FLASHW_ALL = 3,     //标题和任务栏同时闪烁
            FLASHW_PARAM1 = 4,
            FLASHW_PARAM2 = 12,
            FLASHW_TIMER = FLASHW_TRAY | FLASHW_PARAM1,   //无条件闪烁任务栏直到发送停止标志或者窗口被激活，如果未激活，停止时高亮
            FLASHW_TIMERNOFG = FLASHW_TRAY | FLASHW_PARAM2  //未激活时闪烁任务栏直到发送停止标志或者窗体被激活，停止后高亮
        }
        public static bool flashTaskBar(IntPtr hWnd, falshType type)
        {
            FLASHWINFO fInfo = new FLASHWINFO();
            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = hWnd;//要闪烁的窗口的句柄，该窗口可以是打开的或最小化的
            fInfo.dwFlags = (uint)type;//闪烁的类型
            fInfo.uCount = UInt32.MaxValue;//闪烁窗口的次数
            fInfo.dwTimeout = 0; //窗口闪烁的频度，毫秒为单位；若该值为0，则为默认图标的闪烁频度
            return FlashWindowEx(ref fInfo);
        }

        private void 滚轮_CheckedChanged(object sender, EventArgs e)
        {
            if (滚轮.Checked == true)
            {
                this.Promptlabel.Text = "F6开始/暂停\r\nF8反滚动";
                抖动.Checked = false;
                连点.Checked = false;
                宏.Checked = false;
                速度panel.Visible = true;
                速度panel.BringToFront();

                宏panel.SendToBack();
                宏panel.Visible = false;
                宏listBox.Visible = false;
                执行.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private void 速度panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 速度text_Click(object sender, EventArgs e)
        {

        }

        private void 滚轮UpDown_ValueChanged(object sender, EventArgs e)
        {

        }









        int mode = 1;
        int key = 1;
        int time_ = 1;
        int degree = 0;//Int32.Parse(this.抖动范围.Value.ToString());
        int velocity = 0;//Int32.Parse(this.滚轮UpDown.Value.ToString());
        private void read()
        {
            while (true)
            {
                while (GetAsyncKeyState(mouse.VK_F6) == 0)//重复执行直到按下
                {
                    if (GetAsyncKeyState(mouse.VK_F8) != 0)
                    {
                        this.滚轮UpDown.Value = -velocity;
                        while (GetAsyncKeyState(mouse.VK_F8) != 0) ;//重复执行直到松开
                    }
                }

                while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
                if (连点.Checked == true || 抖动.Checked == true)
                {
                    if (连点.Checked == true)
                    {
                        mode = 1;
                        if (左键.Checked == true)
                        {
                            key = 1;
                        }
                        else if (右键.Checked == true)
                        {
                            key = 2;
                        }
                        else if (中键.Checked == true)
                        {
                            key = 3;
                        }
                        else
                        {
                            MessageBox.Show("按键不能为空", "提示");
                        }
                    }
                    else if (抖动.Checked == true)
                    {
                        mode = 2;
                        degree = Int32.Parse(this.抖动范围.Value.ToString());
                    }
                    if (输入.Checked == true)
                    {
                        listtime.Items.Clear();
                        time_ = int.Parse(时UpDown.Text) * 3600000 + int.Parse(分UpDown.Text)
                            * 60000 + int.Parse(秒UpDown.Text) * 1000 + int.Parse(毫UpDown.Text);
                        listtime.Items.Add(time_ + "ms");

                        if (time_ == 0)
                        {
                            MessageBox.Show("时间不可为0", "提示");
                            毫UpDown.Text = "1";
                        }
                        else
                            Clickrun();
                    }
                    else if (录制.Checked == true)
                    {
                        listtime.Items.Clear();
                        Record();
                    Continuou:
                        this.Promptlabel.Text = "F6开始/暂停\r\nF8反滚动";
                        while (GetAsyncKeyState(mouse.VK_F6) == 0) ;//重复执行直到按下
                        while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
                        Clickrun();
                        this.Promptlabel.Text = "F6继续\r\nF7结束";
                        while (true)
                        {
                            if (GetAsyncKeyState(mouse.VK_F6) != 0)//如果按下
                            {
                                goto Continuou;
                            }
                            else if (GetAsyncKeyState(mouse.VK_F7) != 0)//如果按下
                            {
                                listtime.Items.Clear();
                                break;
                            }
                        }
                    }
                }
                else if (滚轮.Checked == true)
                {
                    velocity = Int32.Parse(this.滚轮UpDown.Value.ToString());
                    Slide();
                }
                else if (宏.Checked == true)
                {
                    aw();
                }

                //在此添加

            }
        }
        private void aw()
        {
            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
            while (GetAsyncKeyState(mouse.VK_F6) == 0)//重复执行直到按下
            {
                keybd_event(1, 0, 0, 0);
            }
            keybd_event(1, 0, 0x0002, 0);

            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
        }

        private void Slide()
        {
            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
            while (GetAsyncKeyState(mouse.VK_F6) == 0)//重复执行直到按下
            {
                mouse_event(mouse.MOUSEEVENTF_WHEEL, 0, 0, velocity, 0); //鼠标滑轮滚动
                if (GetAsyncKeyState(mouse.VK_F8) != 0)//重复执行直到松开
                {
                    滚轮UpDown.Value = -velocity;
                    velocity = Int32.Parse(滚轮UpDown.Value.ToString());
                    while (GetAsyncKeyState(mouse.VK_F8) != 0) ;//重复执行直到松开
                }
            }
            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
        }

        private void Record()
        {
            if (mode == 2)
                key = 1;                //抖动靠左键录制
            while (GetAsyncKeyState(key) != 0) ;//重复执行直到松开
            while (GetAsyncKeyState(key) == 0)//重复执行直到按下
                if (GetAsyncKeyState(mouse.VK_F7) != 0)
                    goto exitlearn;
            while (GetAsyncKeyState(key) != 0) ;//重复执行直到松开
            int[] time2 = new int[5];
            for (int i = 0; i < 4; i++)
            {
                uint s1 = GetTickCount();

                while (GetAsyncKeyState(key) == 0)
                    if (GetAsyncKeyState(mouse.VK_F7) != 0)
                        goto exitlearn;//Process.GetCurrentProcess().Kill();
                while (GetAsyncKeyState(key) != 0) ;

                uint s2 = GetTickCount() - s1;

                listtime.Items.Add("t" + (i + 1).ToString() + ":" + s2.ToString() + "ms");
                int.TryParse(s2 + "", out time2[i]);
            }
            time_ = (time2[0] + time2[1] + time2[2] + time2[3] + time2[4]) / 5;
            listtime.Items.Add("均：" + time_ + "ms");

        exitlearn:
            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
            flashTaskBar(this.Handle, falshType.FLASHW_TIMERNOFG);
            MessageBeep(beepI);
        }

        private void Clickrun()
        {
            Point xy = new Point();
            Random ran = new Random();//随机数
            GetCursorPos(ref xy);//获取鼠标坐标 

            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
            while (GetAsyncKeyState(mouse.VK_F6) == 0)//重复执行直到按下
            {
                if (mode == 1)
                {
                    if (key == 1)
                        mouse_event(mouse.MOUSEEVENTF_LEFTDOWN | mouse.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);//左键点击
                    else if (key == 2)
                        mouse_event(mouse.MOUSEEVENTF_RIGHTDOWN | mouse.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);//右键点击
                    else if (key == 3)
                        mouse_event(mouse.MOUSEEVENTF_MIDDLEDOWN | mouse.MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);//中键点击
                }
                else if (mode == 2)
                    SetCursorPos(xy.X + ran.Next(-degree, degree), xy.Y + ran.Next(-degree, degree));//更改鼠标坐标 

                uint t1 = GetTickCount();
                uint t2 = t1;
                while (int.Parse((t2 - t1).ToString()) < time_)
                {
                    t2 = GetTickCount();

                    if (GetAsyncKeyState(mouse.VK_F6) != 0)//如果按下
                        goto exitrun;
                }
            }
        exitrun:;
            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
            flashTaskBar(this.Handle, falshType.FLASHW_TIMERNOFG);
            MessageBeep(beepI);
        }




        private void 宏_CheckedChanged(object sender, EventArgs e)
        {
            if (宏.Checked == true)
            {
                this.Promptlabel.Text = "F6开始/暂停\r\nF8反滚动";
                抖动.Checked = false;
                连点.Checked = false;
                滚轮.Checked = false;
                速度panel.Visible = false;

                宏panel.BringToFront();
                宏panel.Visible = true;
                宏listBox.Visible = true;
                执行.Visible = true;
                comboBox1.Visible = true;
            }
        }

        private void 宏listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 执行_Click(object sender, EventArgs e)
        {

        }

        private void 宏panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void i_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
        }

        private void x_Click(object sender, EventArgs e)
        {

        }
    }
}


/*
0x01					鼠标左键
0x02				 	鼠标右键
0x03				 	控制中断处理
0x04				 	中间鼠标按钮 (三键鼠标)
0x05				 	X1 鼠标按钮
0x06				 	X2 鼠标按钮
0x30				 	0 键
0x31				 	1 键
0x32				 	2 键
0x33				 	3 键
0x34				 	4 键
0x35				 	5 键
0x36				 	6 键
0x37				 	7 键
0x38				 	8 键
0x39				 	9 键
0x41				 	A 键
0x42				 	B 键
0x43				 	C 键
0x44				 	D 键
0x45				 	E 键
0x46				 	F 键
0x47				 	G 键
0x48				 	H 键
0x49				 	I 键
0x4A				 	J 键
0x4B				 	K 键
0x4C				 	L 键
0x4D				 	M 键
0x4E				 	N 键
0x4F				 	O 键
0x50				 	P 键
0x51				 	Q 键
0x52				 	R 键
0x53				 	S 键
0x54				 	T 键
0x55				 	U 键
0x56				 	V 键
0x57				 	W 键
0x58				 	X 键
0x59				 	Y 键
0x5A				 	Z 键
0x70				 	F1 键
0x71				 	F2 键
0x72				 	F3 键
0x73				 	F4 键
0x74				 	F5 键
0x75				 	F6 键
0x76				 	F7 键
0x77				 	F8 键
0x78				 	F9 键
0x79				 	F10 键
0x7A				 	F11 键
0x7B				 	F12 键
0x7C				 	F13 键
0x7D				 	F14 键
0x7E				 	F15 键
0x7F				 	F16 键
0x80				 	F17 键
0x81				 	F18 键
0x82				 	F19 键
0x83				 	F20 键
0x84				 	F21 键
0x85				 	F22 键
0x86				 	F23 键
0x87				 	F24 键
0x09				 	Tab 键
0x20				 	空格键
0x1B				 	ESC 键
0x0C				 	CLEAR 键
0x0D				 	Enter 键
0x10				 	SHIFT 键
0x11				 	Ctrl 键
0x12				 	Alt 键
0x13				 	PAUSE 键
0x14				 	CAPS LOCK 键
0x21				 	PAGE UP 键
0x22				 	PAGE DOWN 键
0x23				 	END 键
0x24				 	HOME 键
0x29				 	SELECT 键
0x2A				 	PRINT 键
0x2B				 	EXECUTE 键
0x08				 	BACKSPACE 密钥
0xA0				 	左 SHIFT 键
0xA1				 	右 SHIFT 键
0xA2				 	左 Ctrl 键
0xA3				 	右 Ctrl 键
0xA4				 	左 Alt 键
0xA5				 	右 ALT 键
0x5B				 	左Windows键 (自然键盘)
0x5C				 	右Windows键 (自然键盘)
0x25				 	向左键
0x26				 	向上键
0x27				 	向右键
0x28				 	向下键
0x6A				 	乘键
0x6B				 	添加密钥
0x6C				 	分隔符键
0x6D				 	减去键
0x6E				 	十进制键
0x6F				 	除键
0xBB				 	对于任何国家/地区，“+”键
0xBC				 	对于任何国家/地区，“，键
0xBD				 	对于任何国家/地区，“-”键
0xBE				 	对于任何国家/地区，“.”键
0x60				 	数字键盘 0 键
0x61				 	数字键盘 1 键
0x62				 	数字键盘 2 键
0x63				 	数字键盘 3 键
0x64				 	数字键盘 4 键
0x65				 	数字键盘 5 键
0x66				 	数字键盘 6 键
0x67				 	数字键盘 7 键
0x68				 	数字键盘 8 键
0x69				 	数字键盘 9 键
0x15				 	IME Kana 模式
0x15				 	IME 朝鲜文库埃尔模式
0x15				 	IME Hanguel 模式
0x16				 	IME On
0x17				 	IME Junja 模式
0x18				 	IME 最终模式
0x19				 	IME Hanja 模式
0x19				 	IME Kanji 模式
0x1A				 	IME 关闭
0x1C				 	IME 转换
0x1D				 	IME 不转换
0x1E				 	IME 接受
0x1F				 	IME 模式更改请求
0x5D				 	应用程序键 (自然键盘)
0x2C				 	打印屏幕键
0x2D				 	INS 密钥
0x2E				 	DEL 键
0x2F				 	帮助密钥
0x5F				 	计算机休眠键
0x90				 	NUM LOCK 密钥
0x91				 	SCROLL LOCK 键
0xA6				 	浏览器后退键
0xA7				 	浏览器前进键
0xA8				 	浏览器刷新键
0xA9				 	浏览器停止键
0xAA				 	浏览器搜索键
0xAB				 	浏览器收藏键
0xAC				 	浏览器“开始”和“主页”键
0xAD				 	静音键
0xAE				 	音量减小键
0xAF				 	音量增加键
0xB0				 	下一曲目键
0xB1				 	上一曲目键
0xB2				 	停止媒体键
0xB3				 	播放/暂停媒体键
0xB4				 	启动邮件键
0xB5				 	选择媒体键
0xB6				 	启动应用程序 1 键
0xB7				 	启动应用程序 2 键
0xBA				 	美国标准键盘，“;：”键
0xBF				 	美国标准键盘，“/？” key
0xC0				 	美国标准键盘，“~”键
0xDB				 	美国标准键盘，“[{”键
0xDC				 	美国标准键盘，“\|”键
0xDD				 	=美国标准键盘，“]}”键
0xDE				 	美国标准键盘，“单引号/双引号”键
0xE1				 	OEM 特定
0xE2				 	美国标准键盘<>键，或102 键键盘\\|键
0xE5					IME PROCESS 密钥
0xE6					OEM 特定
0xE7					用于将 Unicode 字符当作键击传递
0xF6					Attn 键
0xF7					CrSel 键
0xF8					ExSel 密钥
0xF9					擦除 EOF 密钥
0xFA					播放键
0xFB					缩放键
0xFD					PA1 键
0xFE					清除键
 */