using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace CSMPC
{
    public partial class FormMain : Form
    {
        // 成员变量
        public string[] m_strSerialName;            // 串口名称
        public long m_lSerialRecvCount = 0;         // 串口接收数据计数
        public long m_lSerialSendCount = 0;         // 串口发送数据计数
        public bool m_bSerialListenFlag = false;    // 串口监听标志
        public bool m_bSerialCloseFlag = false;     // 串口关闭标志
        public static volatile bool m_bSerialSleep = false;         // 串口线程睡眠标志
        public static volatile bool m_bSerialRecvFinish = false;    // 串口接收完成标志
        public static long m_lSerialRecvLast = 0;                   // 串口接收上次计数(速率)
        public static string m_strSerialRecv = null;                // 串口接收字符串

        public FormMain()
        {
            InitializeComponent();
        }

        #region 窗口加载事件
        private void FormMain_Load(object sender, EventArgs e)  // 窗口加载事件
        {
            #region 串口调试选项卡初始化
            /*
             * 串口调试设置
             */
            // 串口配置设置
            TabPageSerial_Cbx_SerialName.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageSerial_Cbx_SerialBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageSerial_Cbx_SerialDateBit.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageSerial_Cbx_SerialStopBit.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageSerial_Cbx_SerialCheckBit.DropDownStyle = ComboBoxStyle.DropDownList;

            // 串口辅助设置
            TabPageSerial_Rad_Recv_String.Checked = true;
            TabPageSerial_Rad_Recv_Hex.Checked = false;
            TabPageSerial_Rad_Send_String.Checked = true;
            TabPageSerial_Rad_Send_Hex.Checked = false;

            // 接收区设置
            TabPageSerial_Tbx_SerialRecv.ReadOnly = true;
            TabPageSerial_Tbx_SerialRecv.BackColor = Color.White;
            TabPageSerial_Tbx_SerialRecv.ScrollBars = ScrollBars.Vertical;

            // 发送区设置
            TabPageSerial_Tbx_SerialSend.ReadOnly = false;
            TabPageSerial_Tbx_SerialSend.ScrollBars = ScrollBars.Vertical;

            TabPageSerial_Cbx_SerialRecvReturn.Enabled = false;
            TabPageSerial_Cbx_SerialRecvReturn.Checked = false;
            TabPageSerial_Cbx_SerialSendTimer.Enabled = false;
            TabPageSerial_Cbx_SerialSendTimer.Checked = false;

            TabPageSerial_Nud_SerialTimer.Maximum = 10000;
            TabPageSerial_Nud_SerialTimer.Minimum = 100;
            TabPageSerial_Nud_SerialTimer.Value = 1000;
            TabPageSerial_Nud_SerialTimer.Increment = 100;

            // 信息区设置
            TabPageSerial_Tbx_SerialTipInfo.ReadOnly = true;
            TabPageSerial_Tbx_SerialTipName.ReadOnly = true;
            TabPageSerial_Tbx_SerialTipBaud.ReadOnly = true;
            TabPageSerial_Tbx_SerialTipInfo.BackColor = Color.White;
            TabPageSerial_Tbx_SerialTipName.BackColor = Color.White;
            TabPageSerial_Tbx_SerialTipBaud.BackColor = Color.White;

            /*
             * 串口调试初始化
             */
            // 串口名称配置
            TabPageSerial_Cbx_SerialName.Items.Clear();     // 清除串口名称
            m_strSerialName = SerialPort.GetPortNames();    // 获取串口名称
            if(m_strSerialName.Length != 0)
            {
                foreach(string it in m_strSerialName)
                {
                    TabPageSerial_Cbx_SerialName.Items.Add(it);
                }
                TabPageSerial_Cbx_SerialName.SelectedIndex = 0;
            }
            else
            {
                TabPageSerial_Cbx_SerialName.SelectedIndex = -1;
            }

            // 波特率配置
            TabPageSerial_Cbx_SerialBaud.Items.Clear();
            TabPageSerial_Cbx_SerialBaud.Items.Add("9600");
            TabPageSerial_Cbx_SerialBaud.Items.Add("14400");
            TabPageSerial_Cbx_SerialBaud.Items.Add("19200");
            TabPageSerial_Cbx_SerialBaud.Items.Add("38400");
            TabPageSerial_Cbx_SerialBaud.Items.Add("57600");
            TabPageSerial_Cbx_SerialBaud.Items.Add("115200");
            TabPageSerial_Cbx_SerialBaud.Items.Add("128000");
            TabPageSerial_Cbx_SerialBaud.Items.Add("256000");
            TabPageSerial_Cbx_SerialBaud.SelectedIndex = 5;

            // 数据位配置
            TabPageSerial_Cbx_SerialDateBit.Items.Clear();
            TabPageSerial_Cbx_SerialDateBit.Items.Add("5");
            TabPageSerial_Cbx_SerialDateBit.Items.Add("6");
            TabPageSerial_Cbx_SerialDateBit.Items.Add("7");
            TabPageSerial_Cbx_SerialDateBit.Items.Add("8");
            TabPageSerial_Cbx_SerialDateBit.SelectedIndex = 3;

            // 停止位配置
            TabPageSerial_Cbx_SerialStopBit.Items.Clear();
            TabPageSerial_Cbx_SerialStopBit.Items.Add("1");
            TabPageSerial_Cbx_SerialStopBit.Items.Add("2");
            TabPageSerial_Cbx_SerialStopBit.SelectedIndex = 0;

            // 校验位配置
            TabPageSerial_Cbx_SerialCheckBit.Items.Clear();
            TabPageSerial_Cbx_SerialCheckBit.Items.Add("None");
            TabPageSerial_Cbx_SerialCheckBit.Items.Add("Odd");
            TabPageSerial_Cbx_SerialCheckBit.Items.Add("Even");
            TabPageSerial_Cbx_SerialCheckBit.SelectedIndex = 0;

            // 串口信息提示
            if (TabPageSerial_Cbx_SerialName.SelectedIndex == 0)
            {
                TabPageSerial_Tbx_SerialTipInfo.Text = "已检测到串口!";
                TabPageSerial_Tbx_SerialTipName.Text = TabPageSerial_Cbx_SerialName.Text;
                TabPageSerial_Tbx_SerialTipBaud.Text = TabPageSerial_Cbx_SerialBaud.Text;
            }
            else
            {
                TabPageSerial_Tbx_SerialTipInfo.Text = "未检测到串口,请刷新重试!";
                TabPageSerial_Tbx_SerialTipName.Text = "";
                TabPageSerial_Tbx_SerialTipBaud.Text = "";
            }

            // 关闭串口
            SerialPortDebug.Close();

            #endregion

        }
        #endregion

        #region 窗口关闭事件
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)  // 窗口关闭事件
        {

        }
        #endregion

        #region 串口调试

        #region 检查串口设置
        private bool SerialPortDebug_ConfigCheck()  // 检查串口设置
        {
            // 串口名称未设置
            if(TabPageSerial_Cbx_SerialName.Text.Trim() == "")
            {
                return false;
            }

            // 波特率未设置
            if(TabPageSerial_Cbx_SerialBaud.Text.Trim() == "")
            {
                return false;
            }

            // 数据位未设置
            if(TabPageSerial_Cbx_SerialDateBit.Text.Trim() == "")
            {
                return false;
            }

            // 停止位未设置
            if (TabPageSerial_Cbx_SerialStopBit.Text.Trim() == "")
            {
                return false;
            }

            // 校验位未设置
            if (TabPageSerial_Cbx_SerialCheckBit.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
        #endregion

        #region 刷新串口状态
        private void SerialPortDebug_RefreshSerial()    // 刷新串口状态
        {
            // 串口名称配置
            TabPageSerial_Cbx_SerialName.Items.Clear();     // 清除串口名称
            m_strSerialName = SerialPort.GetPortNames();    // 获取串口名称
            if (m_strSerialName.Length != 0)
            {
                foreach (string it in m_strSerialName)
                {
                    TabPageSerial_Cbx_SerialName.Items.Add(it);
                }
                TabPageSerial_Cbx_SerialName.SelectedIndex = 0;
            }
            else
            {
                TabPageSerial_Cbx_SerialName.SelectedIndex = -1;
            }

            // 串口信息提示
            if (TabPageSerial_Cbx_SerialName.SelectedIndex == 0)
            {
                TabPageSerial_Tbx_SerialTipInfo.Text = "已检测到串口!";
                TabPageSerial_Tbx_SerialTipName.Text = TabPageSerial_Cbx_SerialName.Text;
                TabPageSerial_Tbx_SerialTipBaud.Text = TabPageSerial_Cbx_SerialBaud.Text;
            }
            else
            {
                TabPageSerial_Tbx_SerialTipInfo.Text = "未检测到串口,请刷新重试!";
                TabPageSerial_Tbx_SerialTipName.Text = "";
                TabPageSerial_Tbx_SerialTipBaud.Text = "";
            }
        }
        #endregion

        #region 刷新串口
        private void TabPageSerial_Btn_SerialUpdate_Click(object sender, EventArgs e)   // 刷新串口
        {
            // 当前串口状态获取,串口打开:1,串口关闭:0.
            if(!this.SerialPortDebug.IsOpen)    // 串口关闭时才可以刷新串口
            {
                SerialPortDebug_RefreshSerial();    // 刷新串口状态
            }

        }
        #endregion

        #region 打开关闭串口
        private void TabPageSerial_Btn_SerialOpen_Click(object sender, EventArgs e) // 打开关闭串口
        {
            // 当前串口状态获取,串口打开:1,串口关闭:0.
            if(this.SerialPortDebug.IsOpen) //串口已打开,单击关闭串口
            {
                // 关闭串口...
                try
                {
                    m_bSerialCloseFlag = true;  // 串口正在关闭
                    m_bSerialSleep = true;      // 串口线程睡眠

                    while(m_bSerialListenFlag)
                    {
                        Application.DoEvents(); // 监听串口状态
                    }

                    this.SerialPortDebug.Close();   // 关闭串口
                    TabPageSerial_Btn_SerialOpen.Text = "打开串口";
                    m_bSerialCloseFlag = false; // 串口已经关闭

                    // 串口设置按钮开启
                    TabPageSerial_Cbx_SerialName.Enabled = true;
                    TabPageSerial_Cbx_SerialBaud.Enabled = true;
                    TabPageSerial_Cbx_SerialDateBit.Enabled = true;
                    TabPageSerial_Cbx_SerialStopBit.Enabled = true;
                    TabPageSerial_Cbx_SerialCheckBit.Enabled = true;
                    TabPageSerial_Rad_Recv_String.Enabled = true;
                    TabPageSerial_Rad_Recv_Hex.Enabled = true;
                    TabPageSerial_Rad_Send_String.Enabled = true;
                    TabPageSerial_Rad_Send_Hex.Enabled = true;
                    TabPageSerial_Btn_SerialUpdate.Enabled = true;
                    TabPageSerial_Cbx_SerialRecvReturn.Enabled = false;
                    TabPageSerial_Cbx_SerialSendTimer.Enabled = false;
                    TabPageSerial_Btn_SerialSend.Enabled = false;

                    this.SerialTimerRefresh.Stop();             // 停止刷新
                    this.SerialTimerRefresh.Enabled = false;    // 禁止定时器

                    this.SerialTimerRecvSpeed.Stop();           // 停止刷新
                    this.SerialTimerRecvSpeed.Enabled = false;  // 禁止定时器

                    TabPageSerial_Tbx_SerialTipInfo.Text = "串口已关闭!";
                }
                catch(Exception)
                {
                    // 串口提示信息
                    TabPageSerial_Tbx_SerialTipInfo.Text = "关闭串口时发生错误!";

                    // 关闭串口失败
                    MessageBox.Show("关闭串口时发生错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else // 串口已关闭,单击打开串口
            {
                if (TabPageSerial_Btn_SerialOpen.Text == "关闭串口")    // 串口发送数据时断开
                {
                    SerialPortDebug_RefreshSerial();    // 刷新串口状态

                    TabPageSerial_Btn_SerialOpen.Text = "打开串口";

                    // 串口设置按钮开启
                    TabPageSerial_Cbx_SerialName.Enabled = true;
                    TabPageSerial_Cbx_SerialBaud.Enabled = true;
                    TabPageSerial_Cbx_SerialDateBit.Enabled = true;
                    TabPageSerial_Cbx_SerialStopBit.Enabled = true;
                    TabPageSerial_Cbx_SerialCheckBit.Enabled = true;
                    TabPageSerial_Rad_Recv_String.Enabled = true;
                    TabPageSerial_Rad_Recv_Hex.Enabled = true;
                    TabPageSerial_Rad_Send_String.Enabled = true;
                    TabPageSerial_Rad_Send_Hex.Enabled = true;
                    TabPageSerial_Btn_SerialUpdate.Enabled = true;
                    TabPageSerial_Cbx_SerialRecvReturn.Enabled = false;
                    TabPageSerial_Cbx_SerialSendTimer.Enabled = false;
                    TabPageSerial_Btn_SerialSend.Enabled = false;

                    this.SerialTimerRefresh.Stop();             // 停止刷新
                    this.SerialTimerRefresh.Enabled = false;    // 禁止定时器

                    this.SerialTimerRecvSpeed.Stop();           // 停止刷新
                    this.SerialTimerRecvSpeed.Enabled = false;  // 禁止定时器

                    TabPageSerial_Tbx_SerialTipInfo.Text = "串口已关闭!";
                }
                else
                {
                    if(!SerialPortDebug_ConfigCheck())  // 串口设置未成功
                    {
                        // 串口提示信息
                        TabPageSerial_Tbx_SerialTipInfo.Text = "串口未设置!";

                        // 串口未设置
                        MessageBox.Show("串口未设置,请检查串口设置!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // 设置串口名称
                    this.SerialPortDebug.PortName = TabPageSerial_Cbx_SerialName.Text;

                    // 设置串口波特率
                    switch (this.TabPageSerial_Cbx_SerialBaud.Text)
                    {
                        case "9600":
                            this.SerialPortDebug.BaudRate = 9600;     // 串口波特率9600
                            break;
                        case "14400":
                            this.SerialPortDebug.BaudRate = 14400;    // 串口波特率14400
                            break;
                        case "19200":
                            this.SerialPortDebug.BaudRate = 19200;    // 串口波特率19200
                            break;
                        case "38400":
                            this.SerialPortDebug.BaudRate = 38400;    // 串口波特率38400
                            break;
                        case "57600":
                            this.SerialPortDebug.BaudRate = 57600;    // 串口波特率57600
                            break;
                        case "115200":
                            this.SerialPortDebug.BaudRate = 115200;   // 串口波特率115200
                            break;
                        case "128000":
                            this.SerialPortDebug.BaudRate = 128000;   // 串口波特率128000
                            break;
                        case "256000":
                            this.SerialPortDebug.BaudRate = 256000;   // 串口波特率256000
                            break;
                        default:
                            this.SerialPortDebug.BaudRate = 115200;   // 串口波特率115200
                            break;
                    }

                    // 设置串口数据位
                    switch (this.TabPageSerial_Cbx_SerialDateBit.Text)
                    {
                        case "5":
                            this.SerialPortDebug.DataBits = 5;  // 串口数据位5Bit
                            break;
                        case "6":
                            this.SerialPortDebug.DataBits = 6;  // 串口数据位6Bit
                            break;
                        case "7":
                            this.SerialPortDebug.DataBits = 7;  // 串口数据位7Bit
                            break;
                        case "8":
                            this.SerialPortDebug.DataBits = 8;  // 串口数据位8Bit
                            break;
                        default:
                            this.SerialPortDebug.DataBits = 8;  // 串口数据位8Bit
                            break;
                    }

                    // 设置串口停止位
                    switch (this.TabPageSerial_Cbx_SerialStopBit.Text)
                    {
                        case "1":
                            this.SerialPortDebug.StopBits = StopBits.One;   // 串口停止位1Bit
                            break;
                        case "2":
                            this.SerialPortDebug.StopBits = StopBits.Two;   // 串口停止位2Bit
                            break;
                        default:
                            this.SerialPortDebug.StopBits = StopBits.One;   // 串口停止位1Bit
                            break;
                    }

                    // 设置串口校验位
                    switch (this.TabPageSerial_Cbx_SerialCheckBit.Text)
                    {
                        case "None":
                            this.SerialPortDebug.Parity = Parity.None;  // 串口校验位(无校验)
                            break;
                        case "Odd":
                            this.SerialPortDebug.Parity = Parity.Even;  // 串口校验位(奇校验)
                            break;
                        case "Even":
                            this.SerialPortDebug.Parity = Parity.Odd;   // 串口校验位(偶校验)
                            break;
                        default:
                            this.SerialPortDebug.Parity = Parity.None;  // 串口校验位(无校验)
                            break;
                    }

                    // 设置串口属性
                    this.SerialPortDebug.ReadTimeout = -1;  // 设置超出读取时间
                    this.SerialPortDebug.RtsEnable = true;

                    // 打开串口
                    try
                    {
                        m_bSerialSleep = true;
                        this.SerialPortDebug.Open();
                        this.TabPageSerial_Btn_SerialOpen.Text = "关闭串口";

                        // 串口设置按钮关闭
                        TabPageSerial_Cbx_SerialName.Enabled = false;
                        TabPageSerial_Cbx_SerialBaud.Enabled = false;
                        TabPageSerial_Cbx_SerialDateBit.Enabled = false;
                        TabPageSerial_Cbx_SerialStopBit.Enabled = false;
                        TabPageSerial_Cbx_SerialCheckBit.Enabled = false;
                        TabPageSerial_Rad_Recv_String.Enabled = false;
                        TabPageSerial_Rad_Recv_Hex.Enabled = false;
                        TabPageSerial_Rad_Send_String.Enabled = false;
                        TabPageSerial_Rad_Send_Hex.Enabled = false;
                        TabPageSerial_Btn_SerialUpdate.Enabled = false;
                        TabPageSerial_Cbx_SerialRecvReturn.Enabled = true;
                        TabPageSerial_Cbx_SerialSendTimer.Enabled = true;
                        TabPageSerial_Btn_SerialSend.Enabled = true;

                        this.SerialTimerRefresh.Enabled = true;     // 使能定时器
                        this.SerialTimerRefresh.Start();            // 开始刷新

                        this.SerialTimerRecvSpeed.Enabled = true;   // 使能定时器
                        this.SerialTimerRecvSpeed.Start();          // 开始刷新

                        TabPageSerial_Tbx_SerialTipInfo.Text = "串口已打开!";
                        TabPageSerial_Tbx_SerialTipName.Text = TabPageSerial_Cbx_SerialName.Text;
                        TabPageSerial_Tbx_SerialTipBaud.Text = TabPageSerial_Cbx_SerialBaud.Text;
                    }
                    catch(Exception)
                    {
                        // 串口提示信息
                        TabPageSerial_Tbx_SerialTipInfo.Text = "串口无效或已被占用!";

                        // 打开串口失败
                        MessageBox.Show("串口无效或已被占用!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }

            }

        }
        #endregion

        #region 清除接收缓冲区
        private void TabPageSerial_Btn_Recv_Clear_Click(object sender, EventArgs e) // 清除接收缓冲区
        {
            this.TabPageSerial_Tbx_SerialRecv.Clear();  // 清除接收缓冲区文本框
            this.TabPageSerial_Lab_SerialTipRecv.Text = "已接收:0";    // 接收数据清零
            m_lSerialRecvCount = 0; // 接收数据量累加清零
        }
        #endregion

        #region 清除发送缓冲区
        private void TabPageSerial_Btn_Send_Clear_Click(object sender, EventArgs e) // 清除发送缓冲区
        {
            this.TabPageSerial_Tbx_SerialSend.Clear();  // 清除发送缓冲区文本框
            this.TabPageSerial_Lab_SerialTipSend.Text = "已发送:0";    // 发送数据清零
            m_lSerialSendCount = 0;  // 发送数据量累加清零
        }
        #endregion

        #region 接收滚动条设置
        private void TabPageSerial_Tbx_SerialRecv_TextChanged(object sender, EventArgs e)   // 接收TextBox滚动条设置
        {
            this.TabPageSerial_Tbx_SerialRecv.SelectionStart = this.TabPageSerial_Tbx_SerialRecv.Text.Length;    // TextBox起始点为文本框长度
            this.TabPageSerial_Tbx_SerialRecv.SelectionLength = 0;  // 文本框的选定字符
            this.TabPageSerial_Tbx_SerialRecv.ScrollToCaret();  // 当前内容滚动到插入符号位置
        }
        #endregion

        #region 发送滚动条设置
        private void TabPageSerial_Tbx_SerialSend_TextChanged(object sender, EventArgs e)   // 发送TextBox滚动条设置
        {
            this.TabPageSerial_Tbx_SerialSend.SelectionStart = this.TabPageSerial_Tbx_SerialSend.Text.Length;   // TextBox起始点为文本框长度
            this.TabPageSerial_Tbx_SerialSend.SelectionLength = 0;  // 文本框的选定字符
            this.TabPageSerial_Tbx_SerialSend.ScrollToCaret();  // 当前内容滚动到插入符号位置
        }
        #endregion

        #region 串口数据接收
        private void SerialPortDebug_DataReceived(object sender, SerialDataReceivedEventArgs e) // 串口数据接收
        {
            // 当前串口状态获取,串口打开:1,串口关闭:0.
            if(this.SerialPortDebug.IsOpen) // 如果串口打开
            {
                // 如果正在关闭,忽略操作
                if(m_bSerialCloseFlag)
                {
                    Thread.Sleep(100);  // 线程等待
                    m_bSerialSleep = false;
                    return;
                }

                // 关闭串口
                try
                {
                    m_bSerialListenFlag = true; // 线程正在监听

                    // 串口线程等待
                    if(m_bSerialSleep == true)
                    {
                        Thread.Sleep(100);  // 线程等待
                        m_bSerialSleep = false;
                    }

                    Byte[] RecvBuffer = new Byte[this.SerialPortDebug.BytesToRead];
                    m_lSerialRecvCount += this.SerialPortDebug.BytesToRead; // 接收数据累加
                    this.SerialPortDebug.Read(RecvBuffer, 0, RecvBuffer.Length);    // 读取数据到数组
                    this.SerialPortDebug.DiscardInBuffer(); // 清空数据缓冲区

                    if(TabPageSerial_Rad_Recv_String.Checked)
                    {
                        m_bSerialRecvFinish = false;    // 数据接收处理未完成
                        m_strSerialRecv = null;
                        for (int i = 0; i < RecvBuffer.Length; i++)
                        {
                            m_strSerialRecv += Convert.ToChar(RecvBuffer[i]);   // 接收到的字符数据
                        }
                        m_strSerialRecv += " ";   // 字符串结尾加空格
                        m_bSerialRecvFinish = true;   // 数据接收处理完成
                    }
                    else
                    {
                        m_bSerialRecvFinish = false;    // 数据接收处理未完成
                        m_strSerialRecv = null;
                        for (int i = 0; i < RecvBuffer.Length; i++)
                        {
                            m_strSerialRecv += ("0x" + RecvBuffer[i].ToString("X2") + " "); // 将接收到的字符数据转换成16进制数据(形式0xAA)
                        }
                        m_bSerialRecvFinish = true; // 数据接收处理完成
                    }

                }
                catch(Exception)
                {
                    // 串口信息提示
                    TabPageSerial_Tbx_SerialTipInfo.Text = "串口传输出现异常!";
                    MessageBox.Show("串口传输出现异常!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    m_bSerialListenFlag = false;
                    m_bSerialSleep = false;
                }

            }
            else // 如果串口关闭
            {
                // 串口信息提示
                TabPageSerial_Tbx_SerialTipInfo.Text = "串口未打开!";
                MessageBox.Show("串口未打开!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        #endregion

        #region 串口数据定时刷新
        private void SerialTimerRefresh_Tick(object sender, EventArgs e)    // 定时刷新串口数据
        {
            // 刷新UI界面
            if (m_bSerialRecvFinish)    // 串口接收数据完成
            {
                this.Invoke((EventHandler)(delegate
                {
                    if (this.TabPageSerial_Cbx_SerialRecvReturn.Checked)    // 接收换行CheckBox选中
                    {
                        if (m_strSerialRecv != null)  // 字符串不为空,AppendText方法接收
                        {
                            this.TabPageSerial_Tbx_SerialRecv.AppendText(m_strSerialRecv);   // TextBox接收字符串(在上次字符串尾部添加)
                            this.TabPageSerial_Tbx_SerialRecv.AppendText("\n");
                        }
                    }
                    else // 接收换行CheckBox未选中
                    {
                        if (m_strSerialRecv != null)//字符串不为空,AppendText方法接收
                        {
                            this.TabPageSerial_Tbx_SerialRecv.AppendText(m_strSerialRecv);  // TextBox接收字符串(在上次字符串尾部添加)
                        }
                    }

                    // 接收数据限幅
                    if (m_lSerialRecvCount > 32767) // 如果接收数据量超过32767
                    {
                        m_lSerialRecvCount = 32767; // 保持接收数据为32767
                    }
                    this.TabPageSerial_Lab_SerialTipRecv.Text = "已接收:" + m_lSerialRecvCount.ToString(); // 显示已接收字符串数量
                }
                ));
                m_bSerialRecvFinish = false;    // 等待串口接收
            }
        }
        #endregion

        #region 单击发送按钮
        private void TabPageSerial_Btn_SerialSend_Click(object sender, EventArgs e) // 单击发送按钮
        {
            // 当前串口状态获取,串口打开:1,串口关闭:0.
            if (this.SerialPortDebug.IsOpen)  // 如果串口打开
            {
                // 串口发送数据
                try
                {
                    if (this.TabPageSerial_Rad_Send_String.Checked) // RadioButton选中发送ASCII字符
                    {
                        this.SerialPortDebug.Write(this.TabPageSerial_Tbx_SerialSend.Text); // 串口发送文本
                    }
                    else // RadioButton选中发送Hex字符
                    {
                        char[] SendBuffer = this.TabPageSerial_Tbx_SerialSend.Text.ToCharArray();    // 发送字符串转换为文本
                        foreach (byte i in SendBuffer)
                        {
                            this.SerialPortDebug.Write(i.ToString("X2"));   // 发送字符串为Hex形式
                        }
                    }
                    m_lSerialSendCount += this.TabPageSerial_Tbx_SerialSend.Text.Length;    // 已发送数据长度
                    this.TabPageSerial_Tbx_SerialTipInfo.Text = "已发送:" + m_lSerialSendCount.ToString(); // 已发送数据

                    //发送数据限幅
                    if (m_lSerialSendCount > 32767) // 如果发送的数据量超过32767
                    {
                        m_lSerialSendCount = 32767; // 保持发送的数据量为32767
                    }
                }
                // 发送数据失败
                catch (Exception)
                {
                    // 串口信息提示
                    this.TabPageSerial_Tbx_SerialTipInfo.Text = "串口发送数据时出现错误!";
                    MessageBox.Show("串口发送数据时出现错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//如果串口关闭
            {
                // 串口信息提示
                this.TabPageSerial_Tbx_SerialTipInfo.Text = "串口未打开!";
                MessageBox.Show("串口未打开!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region 串口数据定时发送选项
        private void TabPageSerial_Cbx_SerialSendTimer_CheckedChanged(object sender, EventArgs e)   // 串口定时发送选项
        {
            if (this.TabPageSerial_Cbx_SerialSendTimer.Checked) // 串口定时发送选中
            {
                this.TabPageSerial_Nud_SerialTimer.Enabled = false; // 禁止NumberUpDown
                this.SerialTimerSend.Interval = Convert.ToInt16(this.TabPageSerial_Nud_SerialTimer.Value);  // 发送间隔
                this.SerialTimerSend.Enabled = true;    // 启用Timer
                this.SerialTimerSend.Start();   // 开始计时
            }
            else//串口定时发送取消
            {
                this.TabPageSerial_Nud_SerialTimer.Enabled = true;  // 启用NumberUpDown
                this.SerialTimerSend.Stop();  // 停止计时
                this.SerialTimerSend.Enabled = false; // 关闭Timer
            }
        }
        #endregion

        #region 串口数据定时发送
        private void SerialTimerSend_Tick(object sender, EventArgs e)   // 串口定时发送
        {
            // 当前串口状态获取,串口打开:1,串口关闭:0.
            if (this.SerialPortDebug.IsOpen)    // 如果串口打开
            {
                // 如果当前准备关闭串口,不发送数据,直接返回
                if (m_bSerialCloseFlag)
                {
                    this.TabPageSerial_Cbx_SerialSendTimer.Checked = false;    // CheckBox取消选中
                    this.TabPageSerial_Nud_SerialTimer.Enabled = true;  // 启用NumberUpDown
                    this.SerialTimerSend.Stop();  // 停止计时
                    this.SerialTimerSend.Enabled = false; // 关闭Timer
                    return;
                }

                // 串口发送数据
                try
                {
                    if (this.TabPageSerial_Rad_Send_String.Checked)   // RadioButton选中发送ASCII字符
                    {
                        this.SerialPortDebug.Write(this.TabPageSerial_Tbx_SerialSend.Text); // 串口发送文本
                    }
                    else // RadioButton选中发送Hex字符
                    {
                        char[] SendBuffer = this.TabPageSerial_Tbx_SerialSend.Text.ToCharArray();//发送字符串转换为文本
                        foreach (byte i in SendBuffer)
                        {
                            this.SerialPortDebug.Write(i.ToString("X2"));   // 发送字符串为Hex形式
                        }
                    }
                    m_lSerialSendCount += this.TabPageSerial_Tbx_SerialSend.Text.Length;    // 已发送数据长度
                    this.TabPageSerial_Lab_SerialTipSend.Text = "已发送:" + m_lSerialSendCount.ToString(); // 已发送数据
                    // 发送数据限幅
                    if (m_lSerialSendCount > 32767) // 如果发送的数据量超过32767
                    {
                        m_lSerialSendCount = 32767; // 保持发送的数据量为32767
                    }
                }
                // 发送数据失败
                catch (Exception)
                {
                    //串口信息提示
                    this.TabPageSerial_Cbx_SerialSendTimer.Checked = false; // CheckBox取消选中
                    this.TabPageSerial_Nud_SerialTimer.Enabled = true;  // 启用NumberUpDown
                    this.SerialTimerSend.Stop();//停止计时
                    this.SerialTimerSend.Enabled = false;//关闭Timer
                    this.TabPageSerial_Tbx_SerialTipInfo.Text = "串口发送数据时出现错误!";
                    MessageBox.Show("串口发送数据时出现错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // 如果串口关闭
            {
                // 串口信息提示
                this.TabPageSerial_Cbx_SerialSendTimer.Checked = false; //CheckBox取消选中
                this.TabPageSerial_Nud_SerialTimer.Enabled = true; // 启用NumberUpDown
                this.SerialTimerSend.Stop();//停止计时
                this.SerialTimerSend.Enabled = false;//关闭Timer
                this.TabPageSerial_Tbx_SerialTipInfo.Text = "串口未打开!";
                MessageBox.Show("串口未打开!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region 接收数据速度
        private void SerialTimerRecvSpeed_Tick(object sender, EventArgs e)  // 接收数据速度
        {
            long lRecvSpeed = 0;    // 当前接收速度
            lRecvSpeed = m_lSerialRecvCount - m_lSerialRecvLast;    // 计算1s内的传输速度
            if (lRecvSpeed < 0) // 限制最小速度为0
            {
                lRecvSpeed = 0;
            }
            this.TabPageSerial_Lab_SerialRecvSpeed.Text = "速度:" + lRecvSpeed.ToString() + "字节/秒";
            m_lSerialRecvLast = m_lSerialRecvCount;
        }
        #endregion

        #endregion


    }
}
