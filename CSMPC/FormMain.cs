using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32;
using ZedGraph;

namespace CSMPC
{
    public partial class FormMain : Form
    {
        // 成员变量
        // 串口调试
        public string[] m_strSerialName;            // 串口名称
        public long m_lSerialRecvCount = 0;         // 串口接收数据计数
        public long m_lSerialSendCount = 0;         // 串口发送数据计数
        public bool m_bSerialListenFlag = false;    // 串口监听标志
        public bool m_bSerialCloseFlag = false;     // 串口关闭标志
        public static volatile bool m_bSerialSleep = false;         // 串口线程睡眠标志
        public static volatile bool m_bSerialRecvFinish = false;    // 串口接收完成标志
        public static long m_lSerialRecvLast = 0;                   // 串口接收上次计数(速率)
        public static string m_strSerialRecv = null;                // 串口接收字符串

        // 串口曲线
        public string[] m_strSerialCurveName;       // 串口曲线名称
        public long m_lSerialCurveRecvCount = 0;    // 串口曲线接收数据计数
        public bool m_bSerialCurveListenFlag = false;               // 串口监听标志
        public bool m_bSerialCurveCloseFlag = false;                // 串口关闭标志
        public static volatile bool m_bSerialCurveSleep = false;         // 串口线程睡眠标志
        public static volatile bool m_bSerialCurveRecvFinish = false;    // 串口接收完成标志
        public static int m_nSerialCurveBufferSize = 256;           // 串口缓冲数组大小(256 byte)
        public static byte[] m_SerialCurveReadBuffer = new byte[m_nSerialCurveBufferSize];      // 串口缓冲数组
        public static volatile byte[] m_SerialCurveCheckDataBuffer = new byte[20];              // 拆分串口数组数据
        public static volatile int[] m_nSerialCurveData = new int[8];                           // 串口曲线数据
        public static volatile bool m_bSerialCurveDataCheckFinish = false;                      // 数据拆分完成
        public static volatile string m_strSerialCurveSelectedTab = "串口曲线";                 // 选择页当前选项

        // ZedGraph
        public static LineItem ZedGraph_Curve_1;    // 曲线1
        public static LineItem ZedGraph_Curve_2;    // 曲线2
        public static LineItem ZedGraph_Curve_3;    // 曲线3
        public static LineItem ZedGraph_Curve_4;    // 曲线4
        public static LineItem ZedGraph_Curve_5;    // 曲线5
        public static LineItem ZedGraph_Curve_6;    // 曲线6
        public static LineItem ZedGraph_Curve_7;    // 曲线7
        public static LineItem ZedGraph_Curve_8;    // 曲线8

        public static volatile PointPairList ZedGraph_List_1 = new PointPairList(); // 曲线1数据
        public static volatile PointPairList ZedGraph_List_2 = new PointPairList(); // 曲线2数据
        public static volatile PointPairList ZedGraph_List_3 = new PointPairList(); // 曲线3数据
        public static volatile PointPairList ZedGraph_List_4 = new PointPairList(); // 曲线4数据
        public static volatile PointPairList ZedGraph_List_5 = new PointPairList(); // 曲线5数据
        public static volatile PointPairList ZedGraph_List_6 = new PointPairList(); // 曲线6数据
        public static volatile PointPairList ZedGraph_List_7 = new PointPairList(); // 曲线7数据
        public static volatile PointPairList ZedGraph_List_8 = new PointPairList(); // 曲线8数据

        // 网络调试
        // TCP服务端
        public Socket m_SocketServer;                                                               // TCP服务端监听Socket
        public Thread m_tSocketAccept;                                                              // TCP服务端接受线程
        public Dictionary<string, Socket> m_dicSocket = new Dictionary<string, Socket>();           // TCP服务端通信存储Socket
        public Dictionary<string, Thread> m_dicThread = new Dictionary<string, Thread>();           // TCP服务端接收存储Thread
        public bool m_bListen = false;                                                              // TCP服务端监听状态
        public const int m_nRecvBufSize = 4096;                                                     // TCP服务端接收数组大小
        public const int m_nSendBufSize = 4096;                                                     // TCP服务端发送数组大小

        private delegate void TCPSERVERRECVMSGCALLBACK(string strRecv);                             // TCP服务端接受消息委托
        private delegate void TCPSERVERSETTEXTCALLBACK(string strText);                             // TCP服务端系统消息委托
        private delegate void TCPSERVERADDOBJECTCALLBACK(string strItem);                           // TCP服务端添加对象委托
        private delegate void TCPSERVERDELOBJECTCALLBACK(string strItem);                           // TCP服务端删除对象委托

        private TCPSERVERRECVMSGCALLBACK TCPServerRecvMsgCallback;
        private TCPSERVERSETTEXTCALLBACK TCPServerSetTextCallback;
        private TCPSERVERADDOBJECTCALLBACK TCPServerAddObjectCallback;
        private TCPSERVERDELOBJECTCALLBACK TCPServerDelObjectCallback;

        // TCP客户端
        public Socket m_SocketClient;                                                               // TCP客户端连接Socket
        public Thread m_tSocketConnect;                                                             // TCP客户端连接线程
        public bool m_bConnect = false;                                                             // TCP客户端连接状态

        private delegate void TCPCLIENTSETTEXTCALLBACK(string strText);                             // TCP客户端系统消息委托
        private delegate void TCPCLIENTSTOPLISTENCALLBACK();                                        // TCP客户端响应服务端停止监听委托

        private TCPCLIENTSETTEXTCALLBACK TCPClientSetTextCallback;
        private TCPCLIENTSTOPLISTENCALLBACK TCPClientStopListenCallback;

        // UDP
        public Socket m_SocketUDP;                                                                  // UDP通信连接Socket
        public Thread m_tSocketUDP;                                                                 // UDP通信连接线程
        public bool m_bUDP = false;                                                                 // UDP通信打开关闭状态(true:开启/false:关闭)

        private delegate void UDPSETTEXTCALLBACK(string strText);                                   // UDP通信系统消息委托

        private UDPSETTEXTCALLBACK UDPSetTextCallback;

        // 数据分析
        // 进程监视
        public Dictionary<string, IntPtr> m_dicProcessHandle = new Dictionary<string, IntPtr>();    // 进程PID存储进程句柄
        public bool m_bPMStart = false;                                                             // 进程监视监测状态(true:开启/false:关闭)
        public bool m_bPMFinish = false;                                                            // 进程监视转换完成
        public static volatile double[] m_dProcessCurveValue = new double[8];                       // 进程监视曲线当前值

        // ZedGraph
        public static LineItem ZedGraph_Process_1;    // 进程1
        public static LineItem ZedGraph_Process_2;    // 进程2
        public static LineItem ZedGraph_Process_3;    // 进程3
        public static LineItem ZedGraph_Process_4;    // 进程4
        public static LineItem ZedGraph_Process_5;    // 进程5
        public static LineItem ZedGraph_Process_6;    // 进程6
        public static LineItem ZedGraph_Process_7;    // 进程7
        public static LineItem ZedGraph_Process_8;    // 进程8

        public static volatile PointPairList ZedGraph_ProcessList_1 = new PointPairList();  // 曲线1数据
        public static volatile PointPairList ZedGraph_ProcessList_2 = new PointPairList();  // 曲线2数据
        public static volatile PointPairList ZedGraph_ProcessList_3 = new PointPairList();  // 曲线3数据
        public static volatile PointPairList ZedGraph_ProcessList_4 = new PointPairList();  // 曲线4数据
        public static volatile PointPairList ZedGraph_ProcessList_5 = new PointPairList();  // 曲线5数据
        public static volatile PointPairList ZedGraph_ProcessList_6 = new PointPairList();  // 曲线6数据
        public static volatile PointPairList ZedGraph_ProcessList_7 = new PointPairList();  // 曲线7数据
        public static volatile PointPairList ZedGraph_ProcessList_8 = new PointPairList();  // 曲线8数据

        struct PROCESS_MEMORY_COUNTERS
        {
            public UInt32 cb;
            public UInt32 PageFaultCount;
            public UInt32 PeakWorkingSetSize;
            public UInt32 WorkingSetSize;
            public UInt32 QuotaPeakPagedPoolUsage;
            public UInt32 QuotaPagedPoolUsage;
            public UInt32 QuotaPeakNonPagedPoolUsage;
            public UInt32 QuotaNonPagedPoolUsage;
            public UInt32 PagefileUsage;
            public UInt32 PeakPagefileUsage;
        };

        // 控制台
        private delegate void CONSOLELOGSETTEXTCALLBACK(string strText);

        private CONSOLELOGSETTEXTCALLBACK ConsoleLogSetTextCallback;

        #region 导入动态链接库函数
        [DllImport("Kernel32.dll", EntryPoint = "OpenProcess", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, UInt32 bInheritHandle, UInt32 dwProcessId);

        [DllImport("Kernel32.dll", EntryPoint = "CloseHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 CloseHandle(IntPtr hObject);

        [DllImport("Psapi.dll", EntryPoint = "GetProcessMemoryInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 GetProcessMemoryInfo(IntPtr hProcess, IntPtr ppsmemCounters, UInt32 cb);

        #endregion

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

            #region 网络调试选项卡初始化
            /*
             * 网络调试设置
             */
            // TCP服务端

            // 本机IP地址设置
            TabPageTCPServer_Tbx_NetLocalHostIP.Text = GetLocalIP();

            // 本机端口号设置
            TabPageTCPServer_Tbx_NetLocalHostPort.Text = "6000";

            // 最大连接数设置
            TabPageTCPServer_Tbx_NetServerMaxListen.Text = "10";

            // 网络辅助设置
            TabPageTCPServer_Rad_NetRecvString.Checked = true;
            TabPageTCPServer_Rad_NetRecvHex.Checked = false;
            TabPageTCPServer_Rad_NetSendString.Checked = true;
            TabPageTCPServer_Rad_NetSendHex.Checked = false;

            // 消息区设置
            TabPageTCPServer_Tbx_Recv.ReadOnly = true;
            TabPageTCPServer_Tbx_Recv.BackColor = Color.White;
            TabPageTCPServer_Tbx_Recv.ScrollBars = ScrollBars.Vertical;

            // 发送区设置
            TabPageTCPServer_Tbx_Send.ReadOnly = false;
            TabPageTCPServer_Tbx_Send.ScrollBars = ScrollBars.Vertical;

            TabPageTCPServer_Cbx_ConnectObject.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageTCPServer_Cbx_ConnectObject.Items.Clear();
            TabPageTCPServer_Cbx_ConnectObject.Items.Add("广播");
            TabPageTCPServer_Cbx_ConnectObject.SelectedIndex = 0;

            // TCP客户端

            // 服务器IP地址设置(暂定为本机IP地址...)
            TabPageTCPClient_Tbx_NetLocalHostIP.Text = GetLocalIP();

            // 服务器端口号设置
            TabPageTCPClient_Tbx_NetLocalHostPort.Text = "6000";

            // 网络辅助设置
            TabPageTCPClient_Rad_NetRecvString.Checked = true;
            TabPageTCPClient_Rad_NetRecvHex.Checked = false;
            TabPageTCPClient_Rad_NetSendString.Checked = true;
            TabPageTCPClient_Rad_NetSendHex.Checked = false;

            // 消息区设置
            TabPageTCPClient_Tbx_Recv.ReadOnly = true;
            TabPageTCPClient_Tbx_Recv.BackColor = Color.White;
            TabPageTCPClient_Tbx_Recv.ScrollBars = ScrollBars.Vertical;

            // 发送区设置
            TabPageTCPClient_Tbx_Send.ReadOnly = false;
            TabPageTCPClient_Tbx_Send.ScrollBars = ScrollBars.Vertical;

            // UDP

            // 本地IP地址设置
            TabPageUDP_Tbx_NetLocalHostIP.Text = GetLocalIP();

            // 本地端口号设置
            TabPageUDP_Tbx_NetLocalHostPort.Text = "6000";

            // 网络辅助设置
            TabPageUDP_Rad_NetRecvString.Checked = true;
            TabPageUDP_Rad_NetRecvHex.Checked = false;
            TabPageUDP_Rad_NetSendString.Checked = true;
            TabPageUDP_Rad_NetSendHex.Checked = false;

            // 消息区设置
            TabPageUDP_Tbx_Recv.ReadOnly = true;
            TabPageUDP_Tbx_Recv.BackColor = Color.White;
            TabPageUDP_Tbx_Recv.ScrollBars = ScrollBars.Vertical;

            // 发送区设置
            TabPageUDP_Tbx_Send.ReadOnly = false;
            TabPageUDP_Tbx_Send.ScrollBars = ScrollBars.Vertical;

            TabPageUDP_Tbx_TargetIP.Text = GetLocalIP();
            TabPageUDP_Tbx_TargetPort.Text = "6001";

            #endregion

            #region 实时曲线选项卡初始化
            /*
             * 实时曲线设置
             */
            // 串口配置设置
            TabPageCurve_Cbx_SerialName.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageCurve_Cbx_SerialBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageCurve_Cbx_SerialDataBit.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageCurve_Cbx_SerialStopBit.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageCurve_Cbx_SerialCheckBit.DropDownStyle = ComboBoxStyle.DropDownList;

            // 曲线初始化
            SerialPortCurve_ZedGraphInit();

            // 辅助功能设置
            TabPageCurve_Cbx_Curve1.Enabled = true;
            TabPageCurve_Cbx_Curve2.Enabled = true;
            TabPageCurve_Cbx_Curve3.Enabled = true;
            TabPageCurve_Cbx_Curve4.Enabled = true;
            TabPageCurve_Cbx_Curve5.Enabled = false;
            TabPageCurve_Cbx_Curve6.Enabled = false;
            TabPageCurve_Cbx_Curve7.Enabled = false;
            TabPageCurve_Cbx_Curve8.Enabled = false;

            TabPageCurve_Cbx_Curve1.Checked = true;
            TabPageCurve_Cbx_Curve2.Checked = true;
            TabPageCurve_Cbx_Curve3.Checked = true;
            TabPageCurve_Cbx_Curve4.Checked = true;
            TabPageCurve_Cbx_Curve5.Checked = false;
            TabPageCurve_Cbx_Curve6.Checked = false;
            TabPageCurve_Cbx_Curve7.Checked = false;
            TabPageCurve_Cbx_Curve8.Checked = false;

            TabPageCurve_Lab_Curve1.Enabled = true;
            TabPageCurve_Lab_Curve2.Enabled = true;
            TabPageCurve_Lab_Curve3.Enabled = true;
            TabPageCurve_Lab_Curve4.Enabled = true;
            TabPageCurve_Lab_Curve5.Enabled = false;
            TabPageCurve_Lab_Curve6.Enabled = false;
            TabPageCurve_Lab_Curve7.Enabled = false;
            TabPageCurve_Lab_Curve8.Enabled = false;

            TabPageCurve_Nud_CurveNum.Minimum = 1;
            TabPageCurve_Nud_CurveNum.Maximum = 8;
            TabPageCurve_Nud_CurveNum.Value = 4;
            TabPageCurve_Nud_CurveNum.Increment = 1;

            // 信息区设置
            TabPageCurve_Tbx_SerialInfo.ReadOnly = true;
            TabPageCurve_Tbx_SerialInfoName.ReadOnly = true;
            TabPageCurve_Tbx_SerialInfoBaud.ReadOnly = true;
            TabPageCurve_Tbx_SerialInfo.BackColor = Color.White;
            TabPageCurve_Tbx_SerialInfoName.BackColor = Color.White;
            TabPageCurve_Tbx_SerialInfoBaud.BackColor = Color.White;

            /*
             * 实时曲线初始化
             */
            // 串口名称配置
            TabPageCurve_Cbx_SerialName.Items.Clear();     // 清除串口名称
            m_strSerialCurveName = SerialPort.GetPortNames();    // 获取串口名称
            if (m_strSerialCurveName.Length != 0)
            {
                foreach (string it in m_strSerialCurveName)
                {
                    TabPageCurve_Cbx_SerialName.Items.Add(it);
                }
                TabPageCurve_Cbx_SerialName.SelectedIndex = 0;
            }
            else
            {
                TabPageCurve_Cbx_SerialName.SelectedIndex = -1;
            }

            // 波特率配置
            TabPageCurve_Cbx_SerialBaud.Items.Clear();
            TabPageCurve_Cbx_SerialBaud.Items.Add("9600");
            TabPageCurve_Cbx_SerialBaud.Items.Add("14400");
            TabPageCurve_Cbx_SerialBaud.Items.Add("19200");
            TabPageCurve_Cbx_SerialBaud.Items.Add("38400");
            TabPageCurve_Cbx_SerialBaud.Items.Add("57600");
            TabPageCurve_Cbx_SerialBaud.Items.Add("115200");
            TabPageCurve_Cbx_SerialBaud.Items.Add("128000");
            TabPageCurve_Cbx_SerialBaud.Items.Add("256000");
            TabPageCurve_Cbx_SerialBaud.SelectedIndex = 5;

            // 数据位配置
            TabPageCurve_Cbx_SerialDataBit.Items.Clear();
            TabPageCurve_Cbx_SerialDataBit.Items.Add("5");
            TabPageCurve_Cbx_SerialDataBit.Items.Add("6");
            TabPageCurve_Cbx_SerialDataBit.Items.Add("7");
            TabPageCurve_Cbx_SerialDataBit.Items.Add("8");
            TabPageCurve_Cbx_SerialDataBit.SelectedIndex = 3;

            // 停止位配置
            TabPageCurve_Cbx_SerialStopBit.Items.Clear();
            TabPageCurve_Cbx_SerialStopBit.Items.Add("1");
            TabPageCurve_Cbx_SerialStopBit.Items.Add("2");
            TabPageCurve_Cbx_SerialStopBit.SelectedIndex = 0;

            // 校验位配置
            TabPageCurve_Cbx_SerialCheckBit.Items.Clear();
            TabPageCurve_Cbx_SerialCheckBit.Items.Add("None");
            TabPageCurve_Cbx_SerialCheckBit.Items.Add("Odd");
            TabPageCurve_Cbx_SerialCheckBit.Items.Add("Even");
            TabPageCurve_Cbx_SerialCheckBit.SelectedIndex = 0;

            // 串口信息提示
            if (TabPageCurve_Cbx_SerialName.SelectedIndex == 0)
            {
                TabPageCurve_Tbx_SerialInfo.Text = "已检测到串口!";
                TabPageCurve_Tbx_SerialInfoName.Text = TabPageCurve_Cbx_SerialName.Text;
                TabPageCurve_Tbx_SerialInfoBaud.Text = TabPageCurve_Cbx_SerialBaud.Text;
            }
            else
            {
                TabPageCurve_Tbx_SerialInfo.Text = "未检测到串口,请刷新重试!";
                TabPageCurve_Tbx_SerialInfoName.Text = "";
                TabPageCurve_Tbx_SerialInfoBaud.Text = "";
            }

            // 关闭串口
            SerialPortCurve.Close();

            #endregion

            #region 数据分析选项卡初始化
            /*
             * 进程监测设置
             */
             // 监视配置设置
            TabAnalysisProcessPage_Tbx_PID.ReadOnly = false;
            TabAnalysisProcessPage_Tbx_PID.BackColor = Color.White;
            TabAnalysisProcessPage_Tbx_Handle.ReadOnly = true;
            TabAnalysisProcessPage_Tbx_Handle.BackColor = Color.White;
            TabAnalysisProcessPage_Btn_Find.Enabled = true;

            // 监视列表设置
            TabAnalysisProcessPage_LV_Process.Columns.Add("PID", 69, HorizontalAlignment.Center);
            TabAnalysisProcessPage_LV_Process.Columns.Add("句柄", 69, HorizontalAlignment.Center);

            TabAnalysisProcessPage_Btn_Add.Enabled = false;
            TabAnalysisProcessPage_Btn_Del.Enabled = true;

            // 进程监视ZedGraph初始化
            AnalysisProcess_ZedGraphInit();

            // 进程内存设置


            #endregion

            #region 控制台选项卡初始化
            /*
             * 控制台设置
             */
            // 控制台文本设置
            TabPageConsole_Tbx_Console.ReadOnly = true;
            TabPageConsole_Tbx_Console.BackColor = Color.White;
            TabPageConsole_Tbx_Console.ScrollBars = ScrollBars.Vertical;

            #endregion

            #region 帮助选项卡初始化
            /*
             * 帮助设置
             */
            // 帮助选项设置
            TabPageHelp_Cbx_HelpItem.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageHelp_Cbx_HelpSubItem.DropDownStyle = ComboBoxStyle.DropDownList;
            TabPageHelp_Cbx_HelpSubText.DropDownStyle = ComboBoxStyle.DropDownList;

            // 帮助项配置
            TabPageHelp_Cbx_HelpItem.Items.Clear();
            TabPageHelp_Cbx_HelpItem.Items.Add("串口调试");
            TabPageHelp_Cbx_HelpItem.Items.Add("网络调试");
            TabPageHelp_Cbx_HelpItem.Items.Add("实时曲线");
            TabPageHelp_Cbx_HelpItem.Items.Add("数据分析");
            TabPageHelp_Cbx_HelpItem.Items.Add("控制台");
            TabPageHelp_Cbx_HelpItem.SelectedIndex = 0;

            // 帮助子项配置
            TabPageHelp_Cbx_HelpSubItem.Items.Clear();
            TabPageHelp_Cbx_HelpSubItem.Items.Add("串口调试");
            TabPageHelp_Cbx_HelpSubItem.SelectedIndex = 0;

            // 帮助内容配置
            TabPageHelp_Cbx_HelpSubText.Items.Clear();
            TabPageHelp_Cbx_HelpSubText.Items.Add("应用");
            TabPageHelp_Cbx_HelpSubText.Items.Add("代码");
            TabPageHelp_Cbx_HelpSubText.SelectedIndex = 0;

            // 帮助文本设置
            TabPageHelp_Tbx_Help.ReadOnly = true;
            TabPageHelp_Tbx_Help.BackColor = Color.White;
            TabPageHelp_Tbx_Help.ScrollBars = ScrollBars.Vertical;

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
                            this.TabPageSerial_Tbx_SerialRecv.AppendText("\r\n");
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

        #region 网络调试

        #region TCP服务端

        #region 获取本地IP地址
        public static string GetLocalIP()   // 获取本地IP地址
        {
            try
            {
                string strLocalIP = "";
                string strHostName = Dns.GetHostName();
                IPHostEntry iPHostEntry = Dns.GetHostEntry(strHostName);
                for (int i = 0; i < iPHostEntry.AddressList.Length; ++i)
                {
                    if (iPHostEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        strLocalIP = iPHostEntry.AddressList[i].ToString();
                    }
                }

                return strLocalIP;
            }
            catch(Exception)
            {
                MessageBox.Show("获取本地IP地址出错!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
        #endregion

        #region 检测IP地址是否合法
        public bool IsIPAddress(string sIpAddress)  // IP地址是否合法
        {
            bool blnTest = false;
            bool bRet = true;

            Regex regex = new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
            blnTest = regex.IsMatch(sIpAddress);
            if (blnTest == true)
            {
                string[] strTemp = sIpAddress.Split(new char[] { '.' });
                int nDotCount = strTemp.Length - 1;
                if (3 == nDotCount)
                {
                    for (int i = 0; i < strTemp.Length; i++)
                    {
                        if (Convert.ToInt32(strTemp[i]) > 255)
                        {
                            bRet = false;
                        }
                    }
                }
                else
                {
                    bRet = false;
                }
            }
            else
            {
                bRet = false;
            }
            return bRet;
        }
        #endregion

        #region TCP服务端端口号TextBox响应
        private void TabPageTCPServer_Tbx_NetLocalHostPort_KeyPress(object sender, KeyPressEventArgs e) // TextBox只能输入数字
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TabPageTCPServer_Tbx_NetLocalHostPort_TextChanged(object sender, EventArgs e)  // TextBox限制上下限
        {
            string strText = TabPageTCPServer_Tbx_NetLocalHostPort.Text;
            int nText = 0;

            if(strText != null && strText != "")
            {
                nText = int.Parse(strText);

                if(nText < 0)
                {
                    nText = 0;
                }

                if(nText > 65535)
                {
                    nText = 65535;
                }

                TabPageTCPServer_Tbx_NetLocalHostPort.Text = nText.ToString();
            }
        }
        #endregion

        #region TCP服务端最大连接TextBox响应
        private void TabPageTCPServer_Tbx_NetServerMaxListen_KeyPress(object sender, KeyPressEventArgs e)   // TextBox只能输入数字
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TabPageTCPServer_Tbx_NetServerMaxListen_TextChanged(object sender, EventArgs e)    // TextBox限制上下限
        {
            string strText = TabPageTCPServer_Tbx_NetServerMaxListen.Text;
            int nText = 0;

            if (strText != null && strText != "")
            {
                nText = int.Parse(strText);

                if (nText < 0)
                {
                    nText = 0;
                }

                if (nText > 100)
                {
                    nText = 100;
                }

                TabPageTCPServer_Tbx_NetServerMaxListen.Text = nText.ToString();
            }
        }
        #endregion

        #region TCP服务端监听
        private void TabPageTCPServer_Btn_NetListen_Click(object sender, EventArgs e)
        {
            if(!m_bListen) // 开启监听
            {
                string strServerIp = string.Empty;
                string strServerPort = string.Empty;
                string strMaxConnect = string.Empty;

                strServerIp = TabPageTCPServer_Tbx_NetLocalHostIP.Text;
                strServerPort = TabPageTCPServer_Tbx_NetLocalHostPort.Text;
                strMaxConnect = TabPageTCPServer_Tbx_NetServerMaxListen.Text;

                if (!IsIPAddress(strServerIp))
                {
                    MessageBox.Show("本地IP地址不合法!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (strServerPort == "")
                {
                    MessageBox.Show("本地端口号不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (strMaxConnect == "")
                {
                    MessageBox.Show("最大连接数不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nServerPort = int.Parse(strServerPort);
                int nMaxConnect = int.Parse(strMaxConnect);

                // 服务端Socket
                m_SocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 获取本地的IP地址
                IPAddress iP = IPAddress.Parse(strServerIp);

                // 获取本地的端口号
                IPEndPoint point = new IPEndPoint(iP, nServerPort);

                // 绑定IP地址和端口号
                try
                {
                    m_SocketServer.Bind(point);
                }
                catch (Exception)
                {
                    this.TabPageTCPServer_Tbx_Recv.AppendText("The TCP Server is Already Occupied!");
                    this.TabPageTCPServer_Tbx_Recv.AppendText("\r\n");
                    return;
                }

                // 服务端监听
                m_SocketServer.Listen(nMaxConnect);

                this.TabPageTCPServer_Tbx_Recv.AppendText("The TCP Server is Already Open And Listening...");
                this.TabPageTCPServer_Tbx_Recv.AppendText("\r\n");

                m_bListen = true;
                this.TabPageTCPServer_Btn_NetListen.Text = "停止";
                this.TabPageTCPServer_Btn_Send.Enabled = true;

                // 服务端委托
                TCPServerRecvMsgCallback = new TCPSERVERRECVMSGCALLBACK(TCPServerRecvMsg);
                TCPServerSetTextCallback = new TCPSERVERSETTEXTCALLBACK(TCPServerSetText);
                TCPServerAddObjectCallback = new TCPSERVERADDOBJECTCALLBACK(TCPServerAddObject);
                TCPServerDelObjectCallback = new TCPSERVERDELOBJECTCALLBACK(TCPServerDelObject);

                // 服务端接受(开启监听线程)
                m_tSocketAccept = new Thread(new ParameterizedThreadStart(TCPServerStartListenThread));
                m_tSocketAccept.IsBackground = true;
                m_tSocketAccept.Start(m_SocketServer);
            }
            else // 关闭监听
            {
                // 服务端关闭通信Socket
                foreach(KeyValuePair<string, Socket> pair in m_dicSocket)
                {
                    pair.Value.Close();

                    string strMsg = "Remote Client(" + pair.Key + ") Successfully Disconnected.";

                    this.TabPageTCPServer_Tbx_Recv.Invoke(TCPServerSetTextCallback, strMsg);
                }

                m_SocketServer.Close();
                m_dicSocket.Clear();

                this.TabPageTCPServer_Tbx_Recv.AppendText("The TCP Server is Already Closed.");
                this.TabPageTCPServer_Tbx_Recv.AppendText("\r\n");

                // 服务端关闭接收线程Thread
                foreach(KeyValuePair<string, Thread> pair in m_dicThread)
                {
                    pair.Value.Abort();
                }

                m_tSocketAccept.Abort();
                m_dicThread.Clear();

                // 清除所有Socket连接对象
                this.TabPageTCPServer_Cbx_ConnectObject.Items.Clear();
                this.TabPageTCPServer_Cbx_ConnectObject.Items.Add("广播");
                this.TabPageTCPServer_Cbx_ConnectObject.SelectedIndex = 0;

                m_bListen = false;
                this.TabPageTCPServer_Btn_NetListen.Text = "监听";
                this.TabPageTCPServer_Btn_Send.Enabled = false;

            }

        }
        #endregion

        #region TCP服务端Socket监听线程
        private void TCPServerStartListenThread(object sender)
        {
            Socket socket = sender as Socket;
            while(true)
            {
                // 服务端等待客户端连接
                Socket socketsend = null;

                try
                {
                    socketsend = socket.Accept();
                }
                catch(Exception)
                {
                    break;
                }

                string strIP = socketsend.RemoteEndPoint.ToString();
                string strMsg = "Remote Client(" + strIP + ") Successfully Established Connection.";

                this.TabPageTCPServer_Cbx_ConnectObject.Invoke(TCPServerAddObjectCallback, strIP);
                this.TabPageTCPServer_Tbx_Recv.Invoke(TCPServerSetTextCallback, strMsg);

                Thread tServerRecv = new Thread(new ParameterizedThreadStart(TCPServerRecvMessage));
                tServerRecv.IsBackground = true;
                tServerRecv.Start(socketsend);

                m_dicSocket.Add(strIP, socketsend);
                m_dicThread.Add(strIP, tServerRecv);
            }

        }
        #endregion

        #region TCP服务端Socket接受消息线程
        private void TCPServerRecvMessage(object sender)
        {
            Socket socket = sender as Socket;
            while(true)
            {
                // 服务端消息接收线程
                byte[] RecvBuf = new byte[m_nRecvBufSize];  // TCP服务端消息接收缓冲数组(默认4096Byte)

                try
                {
                    int nCount = socket.Receive(RecvBuf);                   // TCP服务端消息接收数据长度
                    string strIP = socket.RemoteEndPoint.ToString();        // TCP客户端IP地址和端口号
                    string strRecv = "";
                    string strMsg = "";

                    if(nCount == 0)
                    {
                        // TCP客户端断开连接
                        socket.Close();     // 关闭Socket

                        strMsg = "Remote Client(" + strIP + ") Successfully Disconnected.";
                        this.TabPageTCPServer_Tbx_Recv.Invoke(TCPServerSetTextCallback, strMsg);

                        m_dicSocket.Remove(strIP);  // 删除TCP客户端信息
                        m_dicThread.Remove(strIP);

                        this.TabPageTCPServer_Cbx_ConnectObject.Invoke(TCPServerDelObjectCallback, strIP);

                        break;
                    }
                    else
                    {
                        strMsg += "[" + strIP + "] ";
                        strMsg += DateTime.Now.ToLongTimeString().ToString();
                        this.TabPageTCPServer_Tbx_Recv.Invoke(TCPServerSetTextCallback, strMsg);

                        if (this.TabPageTCPServer_Rad_NetRecvString.Checked)    // 字符串接收数据
                        {
                            strRecv = Encoding.Default.GetString(RecvBuf, 0, nCount);
                        }
                        else // 16进制接收数据
                        {
                            for (int i = 0; i < nCount; i++)
                            {
                                strRecv += (RecvBuf[i].ToString("X2") + " ");
                            }
                        }

                        strMsg = strRecv;
                        this.TabPageTCPServer_Tbx_Recv.Invoke(TCPServerSetTextCallback, strMsg);
                    }
                    
                }
                catch(Exception ex)
                {
                    var e = ex as Win32Exception;

                    if (e == null)
                    {
                        e = ex.InnerException as Win32Exception;
                    }

                    if (e != null)
                    {
                        if (e.ErrorCode == 10054)    // Socket远程主机关闭
                        {
                            string strIP = socket.RemoteEndPoint.ToString();

                            // 服务端删除通信Socket
                            foreach (KeyValuePair<string, Socket> pair in m_dicSocket)
                            {
                                if(pair.Key == strIP)
                                {
                                    m_dicSocket.Remove(pair.Key);   // 删除通信Socket
                                    m_dicThread.Remove(pair.Key);   // 删除通信Thread
                                    socket.Close();                 // 关闭通信Socket
                                    break;
                                }
                            }

                            // 清除Socket连接对象
                            this.TabPageTCPServer_Cbx_ConnectObject.Invoke(TCPServerDelObjectCallback, strIP);

                            string strMsg = "";
                            strMsg = "Remote Client(" + strIP + ") has been Disconnected.";
                            this.TabPageTCPServer_Tbx_Recv.Invoke(TCPServerSetTextCallback, strMsg);
                        }
                        else if (e.ErrorCode == 10053)   // Socket本地主机关闭
                        {

                        }
                    }

                    break;
                }

            }

        }
        #endregion

        #region TCP服务端Socket发送消息
        private void TabPageTCPServer_Btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string strSend = this.TabPageTCPServer_Tbx_Send.Text.Trim();
                byte[] SendBuf = null;

                if (this.TabPageTCPServer_Rad_NetSendString.Checked)    // 字符串发送数据
                {
                    SendBuf = Encoding.Default.GetBytes(strSend);
                }
                else // 16进制发送数据
                {
                    string[] strArr = strSend.Split(' ');
                    List<byte> SendList = new List<byte>();

                    foreach (string str in strArr)
                    {
                        byte[] StrBuf = Encoding.Default.GetBytes(str);
                        
                        for(int i = 0; (i < StrBuf.Length) && ((i + 1) < StrBuf.Length); i += 2)
                        {
                            byte[] ShotBuf = new byte[] { StrBuf[i], StrBuf[i + 1] };
                            string ShotStr = Encoding.Default.GetString(ShotBuf);
                            byte StrValue = Convert.ToByte(ShotStr, 16);
                            SendList.Add(StrValue);
                        }

                    }

                    SendBuf = SendList.ToArray();
                }

                // 选择发送对象
                string strObj = this.TabPageTCPServer_Cbx_ConnectObject.SelectedItem.ToString();

                if(strObj == "广播")
                {
                    foreach(KeyValuePair<string, Socket> pair in m_dicSocket)
                    {
                        pair.Value.Send(SendBuf);
                    }

                }
                else
                {
                    foreach (KeyValuePair<string, Socket> pair in m_dicSocket)
                    {
                        if(pair.Key == strObj)
                        {
                            pair.Value.Send(SendBuf);
                        }
                    }

                }

                // 消息区显示发送信息
                string strIP = m_SocketServer.LocalEndPoint.ToString();
                string strMsg = "";

                strMsg += "[" + strIP + "] ";
                strMsg += DateTime.Now.ToLongTimeString().ToString();
                this.TabPageTCPServer_Tbx_Recv.Invoke(TCPServerSetTextCallback, strMsg);

                strMsg = Encoding.Default.GetString(SendBuf);
                this.TabPageTCPServer_Tbx_Recv.Invoke(TCPServerSetTextCallback, strMsg);
            }
            catch(Exception ex)
            {
                MessageBox.Show("发送消息发生错误! 错误:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region TCP服务端接收委托
        private void TCPServerRecvMsg(string strRecv)
        {
            this.TabPageTCPServer_Tbx_Recv.AppendText(strRecv);
            this.TabPageTCPServer_Tbx_Recv.AppendText("\r\n");
        }
        #endregion

        #region TCP服务端系统消息委托
        private void TCPServerSetText(string strText)
        {
            this.TabPageTCPServer_Tbx_Recv.AppendText(strText);
            this.TabPageTCPServer_Tbx_Recv.AppendText("\r\n");
        }
        #endregion

        #region TCP服务端添加对象委托
        private void TCPServerAddObject(string strItem)
        {
            this.TabPageTCPServer_Cbx_ConnectObject.Items.Add(strItem);
        }
        #endregion

        #region TCP服务端删除对象委托
        private void TCPServerDelObject(string strItem)
        {
            this.TabPageTCPServer_Cbx_ConnectObject.Items.Remove(strItem);
            this.TabPageTCPServer_Cbx_ConnectObject.SelectedIndex = 0;
        }
        #endregion

        #region TCP服务端清除消息区
        private void TabPageTCPServer_Btn_NetRecvClear_Click(object sender, EventArgs e)
        {
            this.TabPageTCPServer_Tbx_Recv.Clear();
        }
        #endregion

        #region TCP服务端清除发送区
        private void TabPageTCPServer_Btn_NetSendClear_Click(object sender, EventArgs e)
        {
            this.TabPageTCPServer_Tbx_Send.Clear();
        }
        #endregion

        #region TCP服务端消息区滚动
        private void TabPageTCPServer_Tbx_Recv_TextChanged(object sender, EventArgs e)
        {
            this.TabPageTCPServer_Tbx_Recv.SelectionStart = this.TabPageTCPServer_Tbx_Recv.Text.Length;
            this.TabPageTCPServer_Tbx_Recv.SelectionLength = 0;
            this.TabPageTCPServer_Tbx_Recv.ScrollToCaret();
        }
        #endregion

        #region TCP服务端发送区滚动
        private void TabPageTCPServer_Tbx_Send_TextChanged(object sender, EventArgs e)
        {
            this.TabPageTCPServer_Tbx_Send.SelectionStart = this.TabPageTCPServer_Tbx_Send.Text.Length;
            this.TabPageTCPServer_Tbx_Send.SelectionLength = 0;
            this.TabPageTCPServer_Tbx_Send.ScrollToCaret();
        }
        #endregion

        #endregion

        #region TCP客户端

        #region TCP客户端连接
        private void TabPageTCPServer_Btn_NetConnect_Click(object sender, EventArgs e)
        {
            if(!m_bConnect) // 开始连接
            {
                string strClientIp = string.Empty;
                string strClientPort = string.Empty;

                strClientIp = TabPageTCPClient_Tbx_NetLocalHostIP.Text;
                strClientPort = TabPageTCPClient_Tbx_NetLocalHostPort.Text;

                if (!IsIPAddress(strClientIp))
                {
                    MessageBox.Show("服务器IP地址不合法!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(strClientPort == "")
                {
                    MessageBox.Show("服务器端口号不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nClientPort = int.Parse(strClientPort);

                // 客户端Socket
                m_SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 获取服务器的IP地址
                IPAddress iP = IPAddress.Parse(strClientIp);

                // Socket连接服务器
                try
                {
                    m_SocketClient.Connect(iP, nClientPort);
                }
                catch(Exception)
                {
                    this.TabPageTCPClient_Tbx_Recv.AppendText("Unable to Connect to Remote Server!");
                    this.TabPageTCPClient_Tbx_Recv.AppendText("\r\n");
                    return;
                }

                // 客户端消息提示
                this.TabPageTCPClient_Tbx_Recv.AppendText("Successfully Connected to Remote Server...");
                this.TabPageTCPClient_Tbx_Recv.AppendText("\r\n");

                m_bConnect = true;
                this.TabPageTCPClient_Btn_NetConnect.Text = "断开";
                this.TabPageTCPClient_Btn_Send.Enabled = true;

                // 客户端委托
                TCPClientSetTextCallback = new TCPCLIENTSETTEXTCALLBACK(TCPClientSetText);
                TCPClientStopListenCallback = new TCPCLIENTSTOPLISTENCALLBACK(TCPClientStopListen);

                // 客户端接受(开启监听线程)
                m_tSocketConnect = new Thread(new ParameterizedThreadStart(TCPClientRecvMessage));
                m_tSocketConnect.IsBackground = true;
                m_tSocketConnect.Start(m_SocketClient);
            }
            else // 断开连接
            {
                // 客户端关闭Socket
                m_SocketClient.Close();

                this.TabPageTCPClient_Tbx_Recv.AppendText("Disconnected From The Remote Server.");
                this.TabPageTCPClient_Tbx_Recv.AppendText("\r\n");

                // 客户端关闭接收线程Thread
                m_tSocketConnect.Abort();

                m_bConnect = false;
                this.TabPageTCPClient_Btn_NetConnect.Text = "连接";
                this.TabPageTCPClient_Btn_Send.Enabled = false;
            }

        }
        #endregion

        #region TCP客户端系统消息委托
        private void TCPClientSetText(string strText)
        {
            this.TabPageTCPClient_Tbx_Recv.AppendText(strText);
            this.TabPageTCPClient_Tbx_Recv.AppendText("\r\n");
        }
        #endregion

        #region TCP客户端响应服务端停止监听委托
        private void TCPClientStopListen()
        {
            m_bConnect = false;
            this.TabPageTCPClient_Btn_NetConnect.Text = "连接";
            this.TabPageTCPClient_Btn_Send.Enabled = false;
        }
        #endregion

        #region TCP客户端接收消息线程
        private void TCPClientRecvMessage(object sender)
        {
            Socket socket = sender as Socket;
            while(true)
            {
                // 客户端消息接收线程
                byte[] RecvBuf = new byte[m_nRecvBufSize];  // TCP客户端消息接收缓冲数组(默认4096Byte)

                try
                {
                    int nCount = socket.Receive(RecvBuf);                   // TCP客户端消息接收数据长度
                    string strIP = socket.RemoteEndPoint.ToString();        // TCP服务端IP地址和端口号
                    string strRecv = "";
                    string strMsg = "";

                    if(nCount == 0)
                    {
                        // TCP服务端断开连接
                        socket.Close();     // 关闭Socket

                        strMsg = "Remote Server has Stopped Listen!";
                        this.TabPageTCPClient_Tbx_Recv.Invoke(TCPClientSetTextCallback, strMsg);

                        break;
                    }
                    else
                    {
                        strMsg += "[" + strIP + "] ";
                        strMsg += DateTime.Now.ToLongTimeString().ToString();
                        this.TabPageTCPClient_Tbx_Recv.Invoke(TCPClientSetTextCallback, strMsg);

                        if (this.TabPageTCPClient_Rad_NetRecvString.Checked)    // 字符串接收数据
                        {
                            strRecv = Encoding.Default.GetString(RecvBuf, 0, nCount);
                        }
                        else // 16进制接收数据
                        {
                            for (int i = 0; i < nCount; i++)
                            {
                                strRecv += (RecvBuf[i].ToString("X2") + " ");
                            }
                        }

                        strMsg = strRecv;
                        this.TabPageTCPClient_Tbx_Recv.Invoke(TCPClientSetTextCallback, strMsg);
                    }

                }
                catch(Exception ex)
                {
                    var e = ex as Win32Exception;

                    if(e == null)
                    {
                        e = ex.InnerException as Win32Exception;
                    }

                    if(e != null)
                    {
                        if(e.ErrorCode == 10054)    // Socket远程主机关闭
                        {
                            // TCP服务端已停止监听
                            socket.Close();     // 关闭Socket

                            string strMsg = "";
                            strMsg = "Remote Server has Stopped Listen!";
                            this.TabPageTCPClient_Tbx_Recv.Invoke(TCPClientSetTextCallback, strMsg);

                            // 响应服务端停止监听委托
                            this.Invoke(TCPClientStopListenCallback);
                        }
                        else if(e.ErrorCode == 10053)   // Socket本地主机关闭
                        {

                        }
                    }

                    break;
                }

            }

        }
        #endregion

        #region TCP客户端消息区滚动
        private void TabPageTCPClient_Tbx_Recv_TextChanged(object sender, EventArgs e)
        {
            this.TabPageTCPClient_Tbx_Recv.SelectionStart = this.TabPageTCPClient_Tbx_Recv.Text.Length;
            this.TabPageTCPClient_Tbx_Recv.SelectionLength = 0;
            this.TabPageTCPClient_Tbx_Recv.ScrollToCaret();
        }
        #endregion

        #region TCP客户端接收区滚动
        private void TabPageTCPClient_Tbx_Send_TextChanged(object sender, EventArgs e)
        {
            this.TabPageTCPClient_Tbx_Send.SelectionStart = this.TabPageTCPClient_Tbx_Send.Text.Length;
            this.TabPageTCPClient_Tbx_Send.SelectionLength = 0;
            this.TabPageTCPClient_Tbx_Send.ScrollToCaret();
        }
        #endregion

        #region TCP客户端清除消息区
        private void TabPageTCPClient_Btn_NetRecvClear_Click(object sender, EventArgs e)
        {
            this.TabPageTCPClient_Tbx_Recv.Clear();
        }
        #endregion

        #region TCP客户端清除发送区
        private void TabPageTCPClient_Btn_NetSendClear_Click(object sender, EventArgs e)
        {
            this.TabPageTCPClient_Tbx_Send.Clear();
        }
        #endregion

        #region TCP客户端Socket发送消息
        private void TabPageTCPClient_Btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string strSend = this.TabPageTCPClient_Tbx_Send.Text.Trim();
                byte[] SendBuf = null;

                if (this.TabPageTCPClient_Rad_NetSendString.Checked)    // 字符串发送数据
                {
                    SendBuf = Encoding.Default.GetBytes(strSend);
                }
                else // 16进制发送数据
                {
                    string[] strArr = strSend.Split(' ');
                    List<byte> SendList = new List<byte>();

                    foreach (string str in strArr)
                    {
                        byte[] StrBuf = Encoding.Default.GetBytes(str);

                        for (int i = 0; (i < StrBuf.Length) && ((i + 1) < StrBuf.Length); i += 2)
                        {
                            byte[] ShotBuf = new byte[] { StrBuf[i], StrBuf[i + 1] };
                            string ShotStr = Encoding.Default.GetString(ShotBuf);
                            byte StrValue = Convert.ToByte(ShotStr, 16);
                            SendList.Add(StrValue);
                        }

                    }

                    SendBuf = SendList.ToArray();
                }

                // Socket发送消息
                m_SocketClient.Send(SendBuf);

                // 消息区显示发送信息
                string strIP = m_SocketClient.LocalEndPoint.ToString();
                string strMsg = "";

                strMsg += "[" + strIP + "] ";
                strMsg += DateTime.Now.ToLongTimeString().ToString();
                this.TabPageTCPClient_Tbx_Recv.Invoke(TCPClientSetTextCallback, strMsg);

                strMsg = Encoding.Default.GetString(SendBuf);
                this.TabPageTCPClient_Tbx_Recv.Invoke(TCPClientSetTextCallback, strMsg);
            }
            catch(Exception ex)
            {
                MessageBox.Show("发送消息发生错误! 错误:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #endregion

        #region UDP

        #region UDP打开关闭连接
        private void TabPageUDP_Btn_NetOpen_Click(object sender, EventArgs e)
        {
            if(!m_bUDP) // 打开
            {
                string strUDPIp = string.Empty;
                string strUDPPort = string.Empty;

                strUDPIp = TabPageUDP_Tbx_NetLocalHostIP.Text;
                strUDPPort = TabPageUDP_Tbx_NetLocalHostPort.Text;

                if (!IsIPAddress(strUDPIp))
                {
                    MessageBox.Show("本地IP地址不合法!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(strUDPPort == "")
                {
                    MessageBox.Show("本地端口号不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nUDPPort = int.Parse(strUDPPort);

                // UDP通信Socket
                m_SocketUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // 获取本地的IP地址
                IPAddress iP = IPAddress.Parse(strUDPIp);

                // 获取本地的端口号
                IPEndPoint point = new IPEndPoint(iP, nUDPPort);

                // UDP通信绑定网络地址
                try
                {
                    m_SocketUDP.Bind(point);
                }
                catch(Exception)
                {
                    this.TabPageUDP_Tbx_Recv.AppendText("The UDP Port is Already Occupied!");
                    this.TabPageUDP_Tbx_Recv.AppendText("\r\n");
                    return;
                }

                // UDP通信消息提示
                this.TabPageUDP_Tbx_Recv.AppendText("Successfully Open UDP Port...");
                this.TabPageUDP_Tbx_Recv.AppendText("\r\n");

                m_bUDP = true;
                this.TabPageUDP_Btn_NetOpen.Text = "断开";
                this.TabPageUDP_Btn_Send.Enabled = true;

                // UDP通信委托
                UDPSetTextCallback = new UDPSETTEXTCALLBACK(UDPSetText);

                // UDP通信接受(开启监听线程)
                m_tSocketUDP = new Thread(new ParameterizedThreadStart(UDPRecvMessage));
                m_tSocketUDP.IsBackground = true;
                m_tSocketUDP.Start(m_SocketUDP);
            }
            else // 关闭
            {
                // UDP通信关闭Socket
                m_SocketUDP.Close();

                this.TabPageUDP_Tbx_Recv.AppendText("Successfully Close UDP Port...");
                this.TabPageUDP_Tbx_Recv.AppendText("\r\n");

                // UDP通信关闭接收线程Thread
                m_tSocketUDP.Abort();

                m_bUDP = false;
                this.TabPageUDP_Btn_NetOpen.Text = "打开";
                this.TabPageUDP_Btn_Send.Enabled = false;
            }

        }
        #endregion

        #region UDP消息区系统消息委托
        private void UDPSetText(string strText)
        {
            this.TabPageUDP_Tbx_Recv.AppendText(strText);
            this.TabPageUDP_Tbx_Recv.AppendText("\r\n");
        }
        #endregion

        #region UDP消息区滚动
        private void TabPageUDP_Tbx_Recv_TextChanged(object sender, EventArgs e)
        {
            this.TabPageUDP_Tbx_Recv.SelectionStart = this.TabPageUDP_Tbx_Recv.Text.Length;
            this.TabPageUDP_Tbx_Recv.SelectionLength = 0;
            this.TabPageUDP_Tbx_Recv.ScrollToCaret();
        }
        #endregion

        #region UDP发送区滚动
        private void TabPageUDP_Tbx_Send_TextChanged(object sender, EventArgs e)
        {
            this.TabPageUDP_Tbx_Send.SelectionStart = this.TabPageUDP_Tbx_Send.Text.Length;
            this.TabPageUDP_Tbx_Send.SelectionLength = 0;
            this.TabPageUDP_Tbx_Send.ScrollToCaret();
        }
        #endregion

        #region UDP清除消息区
        private void TabPageUDP_Btn_NetRecvClear_Click(object sender, EventArgs e)
        {
            this.TabPageUDP_Tbx_Recv.Clear();
        }
        #endregion

        #region UDP清除发送区
        private void TabPageUDP_Btn_NetSendClear_Click(object sender, EventArgs e)
        {
            this.TabPageUDP_Tbx_Send.Clear();
        }
        #endregion

        #region UDP通信接收消息线程
        private void UDPRecvMessage(object sender)
        {
            Socket socket = sender as Socket;
            while(true)
            {
                // UDP消息接收线程
                byte[] RecvBuf = new byte[m_nRecvBufSize];  // UDP消息接收缓冲数组(默认4096Byte)

                try
                {
                    EndPoint point = new IPEndPoint(IPAddress.Any, 0);
                    int nCount = socket.ReceiveFrom(RecvBuf, ref point);
                    string strIP = point.ToString();        // UDP通信IP地址和端口号
                    string strRecv = "";
                    string strMsg = "";

                    if (nCount == 0)
                    {
                        // UDP通信断开连接
                        socket.Close();     // 关闭Socket

                        strMsg = "Remote UDP is Disconnected!";
                        this.TabPageUDP_Tbx_Recv.Invoke(UDPSetTextCallback, strMsg);

                        break;
                    }
                    else
                    {
                        strMsg += "[" + strIP + "] ";
                        strMsg += DateTime.Now.ToLongTimeString().ToString();
                        this.TabPageUDP_Tbx_Recv.Invoke(UDPSetTextCallback, strMsg);

                        if (this.TabPageUDP_Rad_NetRecvString.Checked)    // 字符串接收数据
                        {
                            strRecv = Encoding.Default.GetString(RecvBuf, 0, nCount);
                        }
                        else // 16进制接收数据
                        {
                            for (int i = 0; i < nCount; i++)
                            {
                                strRecv += (RecvBuf[i].ToString("X2") + " ");
                            }
                        }

                        strMsg = strRecv;
                        this.TabPageUDP_Tbx_Recv.Invoke(UDPSetTextCallback, strMsg);
                    }

                }
                catch(Exception ex)
                {
                    
                }

            }

        }
        #endregion

        #region UDP通信Socket发送消息
        private void TabPageUDP_Btn_Send_Click(object sender, EventArgs e)
        {
            string strUDPIp = string.Empty;
            string strUDPPort = string.Empty;

            strUDPIp = this.TabPageUDP_Tbx_TargetIP.Text;
            strUDPPort = this.TabPageUDP_Tbx_TargetPort.Text;

            int nUDPPort = int.Parse(strUDPPort);

            if (!IsIPAddress(strUDPIp))
            {
                MessageBox.Show("远程IP地址不合法!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 获取本地的IP地址
            IPAddress iP = IPAddress.Parse(strUDPIp);

            // 获取本地的端口号
            EndPoint point = new IPEndPoint(iP, nUDPPort);

            try
            {
                string strSend = this.TabPageUDP_Tbx_Send.Text.Trim();
                byte[] SendBuf = null;

                if (this.TabPageUDP_Rad_NetSendString.Checked)    // 字符串发送数据
                {
                    SendBuf = Encoding.Default.GetBytes(strSend);
                }
                else // 16进制发送数据
                {
                    string[] strArr = strSend.Split(' ');
                    List<byte> SendList = new List<byte>();

                    foreach (string str in strArr)
                    {
                        byte[] StrBuf = Encoding.Default.GetBytes(str);

                        for (int i = 0; (i < StrBuf.Length) && ((i + 1) < StrBuf.Length); i += 2)
                        {
                            byte[] ShotBuf = new byte[] { StrBuf[i], StrBuf[i + 1] };
                            string ShotStr = Encoding.Default.GetString(ShotBuf);
                            byte StrValue = Convert.ToByte(ShotStr, 16);
                            SendList.Add(StrValue);
                        }

                    }

                    SendBuf = SendList.ToArray();
                }

                // Socket发送消息
                m_SocketUDP.SendTo(SendBuf, SocketFlags.None, point);

                // 消息区显示发送信息
                string strIP = m_SocketUDP.LocalEndPoint.ToString();
                string strMsg = "";

                strMsg += "[" + strIP + "] ";
                strMsg += DateTime.Now.ToLongTimeString().ToString();
                this.TabPageUDP_Tbx_Recv.Invoke(UDPSetTextCallback, strMsg);

                strMsg = Encoding.Default.GetString(SendBuf);
                this.TabPageUDP_Tbx_Recv.Invoke(UDPSetTextCallback, strMsg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送消息发生错误! 错误:" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #endregion

        #endregion

        #region 实时曲线

        #region 串口曲线初始化
        private void SerialPortCurve_ZedGraphInit() // 串口曲线初始化
        {
            // ZedGraph坐标轴标题标签初始化
            this.TabPageCurve_Zed_Graph.GraphPane.Title.Text = "串口曲线";
            this.TabPageCurve_Zed_Graph.GraphPane.XAxis.Title.Text = "时间";
            this.TabPageCurve_Zed_Graph.GraphPane.YAxis.Title.Text = "数值";
            //this.TabPageCurve_Zed_Graph.GraphPane.XAxis.MajorGrid.IsVisible = true;   // X轴虚线
            this.TabPageCurve_Zed_Graph.GraphPane.YAxis.MajorGrid.IsVisible = true; // Y轴虚线
            //this.TabPageCurve_Zed_Graph.GraphPane.Chart.Border.IsVisible = false;

            // ZedGraph坐标轴值设置初始化
            this.TabPageCurve_Zed_Graph.GraphPane.XAxis.Scale.Min = 1;  // X轴坐标最小值
            this.TabPageCurve_Zed_Graph.GraphPane.XAxis.Scale.Max = 2;  // X轴坐标最大值
            this.TabPageCurve_Zed_Graph.GraphPane.YAxis.Scale.Min = 0;  // Y轴坐标最小值
            this.TabPageCurve_Zed_Graph.GraphPane.YAxis.Scale.Max = 1;  // Y轴坐标最大值

            this.TabPageCurve_Zed_Graph.GraphPane.XAxis.Scale.MinAuto = true;
            this.TabPageCurve_Zed_Graph.GraphPane.XAxis.Scale.MaxAuto = true;
            this.TabPageCurve_Zed_Graph.GraphPane.YAxis.Scale.MinAuto = true;
            this.TabPageCurve_Zed_Graph.GraphPane.YAxis.Scale.MaxAuto = true;

            this.TabPageCurve_Zed_Graph.GraphPane.XAxis.Type = ZedGraph.AxisType.Ordinal;

            this.TabPageCurve_Zed_Graph.GraphPane.CurveList.Clear();    // 清空曲线

            // ZedGraph创建曲线
            ZedGraph_Curve_1 = this.TabPageCurve_Zed_Graph.GraphPane.AddCurve("曲线1", ZedGraph_List_1, Color.LightCoral, SymbolType.None);
            ZedGraph_Curve_2 = this.TabPageCurve_Zed_Graph.GraphPane.AddCurve("曲线2", ZedGraph_List_2, Color.Teal, SymbolType.None);
            ZedGraph_Curve_3 = this.TabPageCurve_Zed_Graph.GraphPane.AddCurve("曲线3", ZedGraph_List_3, Color.Orange, SymbolType.None);
            ZedGraph_Curve_4 = this.TabPageCurve_Zed_Graph.GraphPane.AddCurve("曲线4", ZedGraph_List_4, Color.LawnGreen, SymbolType.None);
            ZedGraph_Curve_5 = this.TabPageCurve_Zed_Graph.GraphPane.AddCurve("曲线5", ZedGraph_List_5, Color.LightSeaGreen, SymbolType.None);
            ZedGraph_Curve_6 = this.TabPageCurve_Zed_Graph.GraphPane.AddCurve("曲线6", ZedGraph_List_6, Color.LightSkyBlue, SymbolType.None);
            ZedGraph_Curve_7 = this.TabPageCurve_Zed_Graph.GraphPane.AddCurve("曲线7", ZedGraph_List_7, Color.RoyalBlue, SymbolType.None);
            ZedGraph_Curve_8 = this.TabPageCurve_Zed_Graph.GraphPane.AddCurve("曲线8", ZedGraph_List_8, Color.BlueViolet, SymbolType.None);

            // ZedGraph曲线样式设置
            ZedGraph_Curve_1.Line.Width = 2;
            ZedGraph_Curve_2.Line.Width = 2;
            ZedGraph_Curve_3.Line.Width = 2;
            ZedGraph_Curve_4.Line.Width = 2;
            ZedGraph_Curve_5.Line.Width = 2;
            ZedGraph_Curve_6.Line.Width = 2;
            ZedGraph_Curve_7.Line.Width = 2;
            ZedGraph_Curve_8.Line.Width = 2;

            this.TabPageCurve_Zed_Graph.Refresh();  // 刷新曲线
        }
        #endregion

        #region 检查串口设置
        private bool SerialPortCurve_ConfigCheck()  // 检查串口设置
        {
            // 串口名称未设置
            if (TabPageCurve_Cbx_SerialName.Text.Trim() == "")
            {
                return false;
            }

            // 波特率未设置
            if (TabPageCurve_Cbx_SerialBaud.Text.Trim() == "")
            {
                return false;
            }

            // 数据位未设置
            if (TabPageCurve_Cbx_SerialDataBit.Text.Trim() == "")
            {
                return false;
            }

            // 停止位未设置
            if (TabPageCurve_Cbx_SerialStopBit.Text.Trim() == "")
            {
                return false;
            }

            // 校验位未设置
            if (TabPageCurve_Cbx_SerialCheckBit.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
        #endregion

        #region 刷新串口状态
        private void SerialPortCurve_RefreshSerial()    // 刷新串口状态
        {
            // 串口名称配置
            TabPageCurve_Cbx_SerialName.Items.Clear();     // 清除串口名称
            m_strSerialCurveName = SerialPort.GetPortNames();    // 获取串口名称
            if (m_strSerialCurveName.Length != 0)
            {
                foreach (string it in m_strSerialCurveName)
                {
                    TabPageCurve_Cbx_SerialName.Items.Add(it);
                }
                TabPageCurve_Cbx_SerialName.SelectedIndex = 0;
            }
            else
            {
                TabPageCurve_Cbx_SerialName.SelectedIndex = -1;
            }

            // 串口信息提示
            if (TabPageCurve_Cbx_SerialName.SelectedIndex == 0)
            {
                TabPageCurve_Tbx_SerialInfo.Text = "已检测到串口!";
                TabPageCurve_Tbx_SerialInfoName.Text = TabPageCurve_Cbx_SerialName.Text;
                TabPageCurve_Tbx_SerialInfoBaud.Text = TabPageCurve_Cbx_SerialBaud.Text;
            }
            else
            {
                TabPageCurve_Tbx_SerialInfo.Text = "未检测到串口,请刷新重试!";
                TabPageCurve_Tbx_SerialInfoName.Text = "";
                TabPageCurve_Tbx_SerialInfoBaud.Text = "";
            }
        }
        #endregion

        #region 刷新串口状态
        private void TabPageCurve_Btn_SerialRefresh_Click(object sender, EventArgs e)   // 刷新串口
        {
            // 当前串口状态获取,串口打开:1,串口关闭:0.
            if(!this.SerialPortCurve.IsOpen) // 串口关闭时才可以刷新串口
            {
                SerialPortCurve_RefreshSerial();
            }
        }
        #endregion

        #region 打开关闭串口
        private void TabPageCurve_Btn_SerialOpen_Click(object sender, EventArgs e)  // 打开关闭串口
        {
            // 当前串口状态获取,串口打开:1,串口关闭:0.
            if(this.SerialPortCurve.IsOpen) // 串口已打开,单击关闭串口
            {
                // 关闭串口
                try
                {
                    m_bSerialCurveCloseFlag = true;     // 串口正在关闭
                    m_bSerialCurveSleep = true;         // 串口线程睡眠等待UI更新

                    while(m_bSerialCurveListenFlag)
                    {
                        Application.DoEvents();         // 等待监听串口状态标志
                    }

                    this.SerialPortCurve.Close();
                    TabPageCurve_Btn_SerialOpen.Text = "打开串口";
                    m_bSerialCurveCloseFlag = false;    // 串口已经关闭

                    // 串口设置按钮打开
                    TabPageCurve_Cbx_SerialName.Enabled = true;
                    TabPageCurve_Cbx_SerialBaud.Enabled = true;
                    TabPageCurve_Cbx_SerialDataBit.Enabled = true;
                    TabPageCurve_Cbx_SerialStopBit.Enabled = true;
                    TabPageCurve_Cbx_SerialCheckBit.Enabled = true;
                    TabPageCurve_Btn_SerialRefresh.Enabled = true;
                    TabPageCurve_Btn_ExportData.Enabled = true;

                    // 定时刷新曲线定时器Timer
                    CurveRefresh.Stop();                    // 停止定时
                    CurveRefresh.Enabled = false;           // 关闭定时刷新

                    // 串口提示信息
                    TabPageCurve_Tbx_SerialInfo.Text = "串口已关闭";
                }
                catch (Exception)
                {
                    // 串口提示信息
                    TabPageCurve_Tbx_SerialInfo.Text = "关闭串口时发生错误!";

                    // 关闭串口失败
                    MessageBox.Show("关闭串口时发生错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else //串口已关闭,单击打开串口
            {
                if(TabPageCurve_Btn_SerialOpen.Text == "关闭串口")  // 串口发送数据时断开
                {
                    // 刷新串口状态
                    SerialPortCurve_RefreshSerial();

                    // 串口设置按钮打开
                    TabPageCurve_Cbx_SerialName.Enabled = true;
                    TabPageCurve_Cbx_SerialBaud.Enabled = true;
                    TabPageCurve_Cbx_SerialDataBit.Enabled = true;
                    TabPageCurve_Cbx_SerialStopBit.Enabled = true;
                    TabPageCurve_Cbx_SerialCheckBit.Enabled = true;
                    TabPageCurve_Btn_SerialRefresh.Enabled = true;
                    TabPageCurve_Btn_ExportData.Enabled = true;

                    // 定时刷新曲线定时器Timer
                    CurveRefresh.Stop();                    // 停止定时
                    CurveRefresh.Enabled = false;           // 关闭定时刷新

                    // 串口提示信息
                    TabPageCurve_Tbx_SerialInfo.Text = "串口已关闭";
                }
                else // 串口已关闭,单击打开串口
                {
                    if (!SerialPortCurve_ConfigCheck())   // 串口未设置成功
                    {
                        // 串口提示信息
                        TabPageCurve_Tbx_SerialInfo.Text = "串口未设置!";//Curve

                        // 串口未设置
                        MessageBox.Show("串口未设置,请检查串口设置!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // 设置串口名称
                    this.SerialPortCurve.PortName = TabPageCurve_Cbx_SerialName.Text;

                    // 设置串口波特率
                    switch (TabPageCurve_Cbx_SerialBaud.Text)
                    {
                        case "9600":
                            this.SerialPortCurve.BaudRate = 9600;   // 串口波特率9600
                            break;
                        case "14400":
                            this.SerialPortCurve.BaudRate = 14400;  // 串口波特率14400
                            break;
                        case "19200":
                            this.SerialPortCurve.BaudRate = 19200;  // 串口波特率19200
                            break;
                        case "38400":
                            this.SerialPortCurve.BaudRate = 38400;  // 串口波特率38400
                            break;
                        case "57600":
                            this.SerialPortCurve.BaudRate = 57600;  // 串口波特率57600
                            break;
                        case "115200":
                            this.SerialPortCurve.BaudRate = 115200; // 串口波特率115200
                            break;
                        case "128000":
                            this.SerialPortCurve.BaudRate = 128000; // 串口波特率128000
                            break;
                        case "256000":
                            this.SerialPortCurve.BaudRate = 256000; // 串口波特率256000
                            break;
                        default:
                            this.SerialPortCurve.BaudRate = 115200; // 串口波特率115200
                            break;
                    }

                    // 设置串口数据位
                    switch (TabPageCurve_Cbx_SerialDataBit.Text)
                    {
                        case "5":
                            this.SerialPortCurve.DataBits = 5;  // 串口数据位5Bit
                            break;
                        case "6":
                            this.SerialPortCurve.DataBits = 6;  // 串口数据位6Bit
                            break;
                        case "7":
                            this.SerialPortCurve.DataBits = 7;  // 串口数据位7Bit
                            break;
                        case "8":
                            this.SerialPortCurve.DataBits = 8;  // 串口数据位8Bit
                            break;
                        default:
                            this.SerialPortCurve.DataBits = 8;  // 串口数据位8Bit
                            break;
                    }

                    // 设置串口停止位
                    switch (TabPageCurve_Cbx_SerialStopBit.Text)
                    {
                        case "1":
                            this.SerialPortCurve.StopBits = StopBits.One;   // 串口停止位1Bit
                            break;
                        case "2":
                            this.SerialPortCurve.StopBits = StopBits.Two;   // 串口停止位2Bit
                            break;
                        default:
                            this.SerialPortCurve.StopBits = StopBits.One;   // 串口停止位1Bit
                            break;
                    }

                    // 设置校验位
                    switch (TabPageCurve_Cbx_SerialCheckBit.Text)
                    {
                        case "None":
                            this.SerialPortCurve.Parity = Parity.None;  // 串口校验位(无校验)
                            break;
                        case "Odd":
                            this.SerialPortCurve.Parity = Parity.Even;  // 串口校验位(奇校验)
                            break;
                        case "Even":
                            this.SerialPortCurve.Parity = Parity.Odd;   // 串口校验位(偶校验)
                            break;
                        default:
                            this.SerialPortCurve.Parity = Parity.None;  // 串口校验位(无校验)
                            break;
                    }

                    // 设置串口
                    this.SerialPortCurve.ReadTimeout = -1;  // 设置超出读取时间
                    this.SerialPortCurve.RtsEnable = true;

                    // 打开串口
                    try
                    {
                        // 打开串口
                        m_bSerialCurveSleep = true;     // 串口线程睡眠等待UI更新
                        this.SerialPortCurve.Open();    // 打开串口
                        TabPageCurve_Tbx_SerialInfo.Text = "关闭串口";

                        // 串口设置按钮关闭
                        TabPageCurve_Cbx_SerialName.Enabled = false;
                        TabPageCurve_Cbx_SerialBaud.Enabled = false;
                        TabPageCurve_Cbx_SerialDataBit.Enabled = false;
                        TabPageCurve_Cbx_SerialStopBit.Enabled = false;
                        TabPageCurve_Cbx_SerialCheckBit.Enabled = false;
                        TabPageCurve_Btn_SerialRefresh.Enabled = false;
                        TabPageCurve_Btn_ExportData.Enabled = false;

                        // 定时刷新曲线定时器Timer
                        CurveRefresh.Enabled = true;           // 关闭定时刷新
                        CurveRefresh.Start();                  // 开始定时

                        // 串口提示信息
                        TabPageCurve_Tbx_SerialInfo.Text = "串口已打开!";
                        TabPageCurve_Tbx_SerialInfoName.Text = TabPageCurve_Cbx_SerialName.Text;
                        TabPageCurve_Tbx_SerialInfoBaud.Text = TabPageCurve_Cbx_SerialBaud.Text;
                    }
                    catch (Exception)
                    {
                        // 串口提示信息
                        TabPageCurve_Tbx_SerialInfo.Text = "串口无效或已被占用!";

                        // 打开串口失败
                        MessageBox.Show("串口无效或已被占用!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }

            }

        }

        #endregion

        #region 串口数据接收
        private void SerialPortCurve_DataReceived(object sender, SerialDataReceivedEventArgs e) // 串口数据接收
        {
            // 当前串口状态获取,串口打开:1,串口关闭:0.
            if (this.SerialPortCurve.IsOpen)//如果串口打开
            {
                // 如果正在关闭,忽略操作
                if (m_bSerialCurveCloseFlag)
                {
                    Thread.Sleep(100);  // 线程睡眠
                    m_bSerialCurveSleep = false;
                    return;
                }

                // 关闭串口
                try
                {
                    m_bSerialCurveListenFlag = true;   // 设置标志

                    // 串口线程睡眠等待
                    if (m_bSerialCurveSleep == true)    // 串口线程睡眠等待UI刷新
                    {
                        Thread.Sleep(100);  // 线程睡眠
                        m_bSerialCurveSleep = false;
                    }

                    int i, j, k;
                    Byte[] ReceiveDataArray = new Byte[this.SerialPortCurve.BytesToRead];       // ReceiveDataArray数组表示COM口接受的数据量
                    this.SerialPortCurve.Read(ReceiveDataArray, 0, ReceiveDataArray.Length);    // 读取数据到ReceiveDataArray数组
                    this.SerialPortCurve.DiscardInBuffer(); // 清空SerialPort数据缓冲Buff

                    // 对串口数据进行拆分
                    for (i = 0; i < ReceiveDataArray.Length - (Int16)TabPageCurve_Nud_CurveNum.Value * 2 - 3; i++)  // 搜索数据格式
                    {
                        // 数据格式(0xFF,0x00,...,0xAA,0x55)
                        if (ReceiveDataArray[i] == (byte)(0xFF) && ReceiveDataArray[i + 1] == (byte)(0x00) && ReceiveDataArray[i + (Int16)TabPageCurve_Nud_CurveNum.Value * 2 + 2] == (byte)(0xAA) && ReceiveDataArray[i + (Int16)TabPageCurve_Nud_CurveNum.Value * 2 + 3] == (byte)(0x55))
                        {
                            for (j = 0, k = i; j < (Int16)TabPageCurve_Nud_CurveNum.Value; j++, k += 2)
                            {
                                m_nSerialCurveData[j] = BitConverter.ToInt16(ReceiveDataArray, k + 2);  // 数据拆分
                            }
                            i += (Int16)TabPageCurve_Nud_CurveNum.Value * 2 + 3;
                            m_bSerialCurveDataCheckFinish = true;   // 数据拆分完成
                        }
                    }
                    
                }
                // 异常处理
                catch (Exception)
                {
                    // 串口信息提示
                    TabPageCurve_Tbx_SerialInfo.Text = "串口传输出现异常!";
                    MessageBox.Show("串口传输出现异常!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 串口接收结束
                finally
                {
                    m_bSerialCurveListenFlag = false;
                    m_bSerialCurveSleep = false;
                }
            }
            else // 如果串口关闭
            {
                // 串口信息提示
                TabPageCurve_Tbx_SerialInfo.Text = "串口未打开!";
                MessageBox.Show("串口未打开!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        #endregion

        #region 定时刷新曲线
        private void CurveRefresh_Tick(object sender, EventArgs e)  // 定时刷新曲线
        {
            if (m_bSerialCurveDataCheckFinish)  // 数据拆分完成
            {
                // 刷新UI界面
                this.Invoke((EventHandler)(delegate
                {
                    this.TabPageCurve_Lab_Curve1.Text = "数值:" + m_nSerialCurveData[0].ToString();   // 曲线1数值显示
                    this.TabPageCurve_Lab_Curve2.Text = "数值:" + m_nSerialCurveData[1].ToString();   // 曲线2数值显示
                    this.TabPageCurve_Lab_Curve3.Text = "数值:" + m_nSerialCurveData[2].ToString();   // 曲线3数值显示
                    this.TabPageCurve_Lab_Curve4.Text = "数值:" + m_nSerialCurveData[3].ToString();   // 曲线4数值显示
                    this.TabPageCurve_Lab_Curve5.Text = "数值:" + m_nSerialCurveData[4].ToString();   // 曲线5数值显示
                    this.TabPageCurve_Lab_Curve6.Text = "数值:" + m_nSerialCurveData[5].ToString();   // 曲线6数值显示
                    this.TabPageCurve_Lab_Curve7.Text = "数值:" + m_nSerialCurveData[6].ToString();   // 曲线7数值显示
                    this.TabPageCurve_Lab_Curve8.Text = "数值:" + m_nSerialCurveData[7].ToString();   // 曲线8数值显示

                    // 坐标点数多余300后保持坐标中存在300点
                    if (ZedGraph_List_1.Count >= 300)
                    {
                        ZedGraph_List_1.RemoveAt(0);
                    }
                    if (ZedGraph_List_2.Count >= 300)
                    {
                        ZedGraph_List_2.RemoveAt(0);
                    }
                    if (ZedGraph_List_3.Count >= 300)
                    {
                        ZedGraph_List_3.RemoveAt(0);
                    }
                    if (ZedGraph_List_4.Count >= 300)
                    {
                        ZedGraph_List_4.RemoveAt(0);
                    }
                    if (ZedGraph_List_5.Count >= 300)
                    {
                        ZedGraph_List_5.RemoveAt(0);
                    }
                    if (ZedGraph_List_6.Count >= 300)
                    {
                        ZedGraph_List_6.RemoveAt(0);
                    }
                    if (ZedGraph_List_7.Count >= 300)
                    {
                        ZedGraph_List_7.RemoveAt(0);
                    }
                    if (ZedGraph_List_8.Count >= 300)
                    {
                        ZedGraph_List_8.RemoveAt(0);
                    }

                    ZedGraph_List_1.Add(0, m_nSerialCurveData[0]);  // ZedGraph_List_1添加数据
                    ZedGraph_List_2.Add(0, m_nSerialCurveData[1]);  // ZedGraph_List_2添加数据
                    ZedGraph_List_3.Add(0, m_nSerialCurveData[2]);  // ZedGraph_List_3添加数据
                    ZedGraph_List_4.Add(0, m_nSerialCurveData[3]);  // ZedGraph_List_4添加数据
                    ZedGraph_List_5.Add(0, m_nSerialCurveData[4]);  // ZedGraph_List_5添加数据
                    ZedGraph_List_6.Add(0, m_nSerialCurveData[5]);  // ZedGraph_List_6添加数据
                    ZedGraph_List_7.Add(0, m_nSerialCurveData[6]);  // ZedGraph_List_7添加数据
                    ZedGraph_List_8.Add(0, m_nSerialCurveData[7]);  // ZedGraph_List_8添加数据

                    this.TabPageCurve_Zed_Graph.AxisChange();       // 坐标轴自动适应
                    this.TabPageCurve_Zed_Graph.Invalidate();       // 重绘控件

                    // 接收曲线限幅
                    m_lSerialCurveRecvCount += 1;                   // 接收曲线数加一
                    if (m_lSerialCurveRecvCount > 32767)
                    {
                        m_lSerialCurveRecvCount = 32767;
                    }
                    this.TabPageCurve_Lab_SerialInfoRecv.Text = "已接收:" + m_lSerialCurveRecvCount.ToString();
                }
                    ));
                m_bSerialCurveDataCheckFinish = false;  // 等待拆分数据
            }
        }

        #endregion

        #region 清除曲线
        private void TabPageCurve_Btn_CurveClear_Click(object sender, EventArgs e)  // 清除曲线
        {
            // 清除绘图曲线
            ZedGraph_List_1.RemoveRange(0, ZedGraph_List_1.Count);  // 清除曲线1数据
            ZedGraph_List_2.RemoveRange(0, ZedGraph_List_2.Count);  // 清除曲线2数据
            ZedGraph_List_3.RemoveRange(0, ZedGraph_List_3.Count);  // 清除曲线3数据
            ZedGraph_List_4.RemoveRange(0, ZedGraph_List_4.Count);  // 清除曲线4数据
            ZedGraph_List_5.RemoveRange(0, ZedGraph_List_5.Count);  // 清除曲线5数据
            ZedGraph_List_6.RemoveRange(0, ZedGraph_List_6.Count);  // 清除曲线6数据
            ZedGraph_List_7.RemoveRange(0, ZedGraph_List_7.Count);  // 清除曲线7数据
            ZedGraph_List_8.RemoveRange(0, ZedGraph_List_8.Count);  // 清除曲线8数据

            ZedGraph_Curve_1.Clear();   // 清除曲线1数据
            ZedGraph_Curve_2.Clear();   // 清除曲线2数据
            ZedGraph_Curve_3.Clear();   // 清除曲线3数据
            ZedGraph_Curve_4.Clear();   // 清除曲线4数据
            ZedGraph_Curve_5.Clear();   // 清除曲线5数据
            ZedGraph_Curve_6.Clear();   // 清除曲线6数据
            ZedGraph_Curve_7.Clear();   // 清除曲线7数据
            ZedGraph_Curve_8.Clear();   // 清除曲线8数据

            this.TabPageCurve_Zed_Graph.Refresh();  // ZedGraph刷新

            // 清除接收曲线数据
            m_lSerialCurveRecvCount = 0;
            this.TabPageCurve_Lab_SerialInfoRecv.Text = "已接收:0";
        }
        #endregion

        #region 曲线导出
        private void TabPageCurve_Btn_ExportData_Click(object sender, EventArgs e)  // 曲线导出
        {
            // 串口曲线当前有数据
            if (ZedGraph_List_1.Count != 0 || ZedGraph_List_2.Count != 0
                || ZedGraph_List_3.Count != 0 || ZedGraph_List_4.Count != 0
                    || ZedGraph_List_5.Count != 0 || ZedGraph_List_6.Count != 0
                        || ZedGraph_List_7.Count != 0 || ZedGraph_List_8.Count != 0)
            {
                // 串口曲线导出当前数据
                try
                {
                    FolderBrowserDialog FilePath = new FolderBrowserDialog();   // 创建保存文件对话框
                    if (FilePath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        FileStream FileData = File.Create(FilePath.SelectedPath + "\\" + "SerialCurve" + DateTime.Now.ToString("yyyyMMdd") + ".csv");
                        StreamWriter FileWriter = new StreamWriter(FileData);

                        FileData.SetLength(0);  // 设置数据流长度
                        FileWriter.Flush();     // 清除缓冲区

                        // 写入信息
                        FileWriter.WriteLine("CSMPC SerialCurve Export");
                        FileWriter.WriteLine(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
                        FileWriter.WriteLine("\r\n");

                        // 写入表头
                        FileWriter.WriteLine("曲线1,曲线2,曲线3,曲线4,曲线5,曲线6,曲线7,曲线8");

                        // 写入数据
                        int nSize = ZedGraph_List_1.Count;

                        for(int i = 0; i < nSize; ++i)
                        {
                            // 曲线1
                            if (this.TabPageCurve_Cbx_Curve1.Checked)
                            {
                                FileWriter.Write(ZedGraph_List_1[i].Y.ToString());
                            }
                            else
                            {
                                FileWriter.Write("0");
                            }
                            FileWriter.Write(",");

                            // 曲线2
                            if (this.TabPageCurve_Cbx_Curve2.Checked)
                            {
                                FileWriter.Write(ZedGraph_List_2[i].Y.ToString());
                            }
                            else
                            {
                                FileWriter.Write("0");
                            }
                            FileWriter.Write(",");

                            // 曲线3
                            if (this.TabPageCurve_Cbx_Curve3.Checked)
                            {
                                FileWriter.Write(ZedGraph_List_3[i].Y.ToString());
                            }
                            else
                            {
                                FileWriter.Write("0");
                            }
                            FileWriter.Write(",");

                            // 曲线4
                            if (this.TabPageCurve_Cbx_Curve4.Checked)
                            {
                                FileWriter.Write(ZedGraph_List_4[i].Y.ToString());
                            }
                            else
                            {
                                FileWriter.Write("0");
                            }
                            FileWriter.Write(",");

                            // 曲线5
                            if (this.TabPageCurve_Cbx_Curve5.Checked)
                            {
                                FileWriter.Write(ZedGraph_List_5[i].Y.ToString());
                            }
                            else
                            {
                                FileWriter.Write("0");
                            }
                            FileWriter.Write(",");

                            // 曲线6
                            if (this.TabPageCurve_Cbx_Curve6.Checked)
                            {
                                FileWriter.Write(ZedGraph_List_6[i].Y.ToString());
                            }
                            else
                            {
                                FileWriter.Write("0");
                            }
                            FileWriter.Write(",");

                            // 曲线7
                            if (this.TabPageCurve_Cbx_Curve7.Checked)
                            {
                                FileWriter.Write(ZedGraph_List_7[i].Y.ToString());
                            }
                            else
                            {
                                FileWriter.Write("0");
                            }
                            FileWriter.Write(",");

                            // 曲线8
                            if (this.TabPageCurve_Cbx_Curve8.Checked)
                            {
                                FileWriter.Write(ZedGraph_List_8[i].Y.ToString());
                            }
                            else
                            {
                                FileWriter.Write("0");
                            }
                            FileWriter.WriteLine("\r\n");
                        }

                        FileWriter.Close(); // 关闭数据流
                        FileData.Close();   // 关闭文件

                        MessageBox.Show("串口曲线数据导出成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                catch(Exception)
                {
                    MessageBox.Show("串口曲线数据导出失败!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口曲线数据不存在,无法导出!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }
        #endregion

        #region 曲线数量变化
        private void TabPageCurve_Nud_CurveNum_ValueChanged(object sender, EventArgs e) // 曲线数量变化
        {
            // 当前曲线数量
            switch ((int)this.TabPageCurve_Nud_CurveNum.Value)
            {
                case 1:// 当前选中1条曲线
                    this.TabPageCurve_Cbx_Curve1.Enabled = true;//曲线1可用
                    this.TabPageCurve_Cbx_Curve2.Enabled = false;//曲线2不可用
                    this.TabPageCurve_Cbx_Curve3.Enabled = false;//曲线3不可用
                    this.TabPageCurve_Cbx_Curve4.Enabled = false;//曲线4不可用
                    this.TabPageCurve_Cbx_Curve5.Enabled = false;//曲线5不可用
                    this.TabPageCurve_Cbx_Curve6.Enabled = false;//曲线6不可用
                    this.TabPageCurve_Cbx_Curve7.Enabled = false;//曲线7不可用
                    this.TabPageCurve_Cbx_Curve8.Enabled = false;//曲线8不可用

                    this.TabPageCurve_Cbx_Curve1.Checked = true;//曲线1选中
                    this.TabPageCurve_Cbx_Curve2.Checked = false;//曲线2不选中
                    this.TabPageCurve_Cbx_Curve3.Checked = false;//曲线3不选中
                    this.TabPageCurve_Cbx_Curve4.Checked = false;//曲线4不选中
                    this.TabPageCurve_Cbx_Curve5.Checked = false;//曲线5不选中
                    this.TabPageCurve_Cbx_Curve6.Checked = false;//曲线6不选中
                    this.TabPageCurve_Cbx_Curve7.Checked = false;//曲线7不选中
                    this.TabPageCurve_Cbx_Curve8.Checked = false;//曲线8不选中

                    this.TabPageCurve_Lab_Curve1.Enabled = true;//曲线1数值可用
                    this.TabPageCurve_Lab_Curve2.Enabled = false;//曲线2数值不可用
                    this.TabPageCurve_Lab_Curve3.Enabled = false;//曲线3数值不可用
                    this.TabPageCurve_Lab_Curve4.Enabled = false;//曲线4数值不可用
                    this.TabPageCurve_Lab_Curve5.Enabled = false;//曲线5数值不可用
                    this.TabPageCurve_Lab_Curve6.Enabled = false;//曲线6数值不可用
                    this.TabPageCurve_Lab_Curve7.Enabled = false;//曲线7数值不可用
                    this.TabPageCurve_Lab_Curve8.Enabled = false;//曲线8数值不可用
                    break;
                case 2://当前选中2条曲线
                    this.TabPageCurve_Cbx_Curve1.Enabled = true;//曲线1可用
                    this.TabPageCurve_Cbx_Curve2.Enabled = true;//曲线2可用
                    this.TabPageCurve_Cbx_Curve3.Enabled = false;//曲线3不可用
                    this.TabPageCurve_Cbx_Curve4.Enabled = false;//曲线4不可用
                    this.TabPageCurve_Cbx_Curve5.Enabled = false;//曲线5不可用
                    this.TabPageCurve_Cbx_Curve6.Enabled = false;//曲线6不可用
                    this.TabPageCurve_Cbx_Curve7.Enabled = false;//曲线7不可用
                    this.TabPageCurve_Cbx_Curve8.Enabled = false;//曲线8不可用

                    this.TabPageCurve_Cbx_Curve1.Checked = true;//曲线1选中
                    this.TabPageCurve_Cbx_Curve2.Checked = true;//曲线2选中
                    this.TabPageCurve_Cbx_Curve3.Checked = false;//曲线3不选中
                    this.TabPageCurve_Cbx_Curve4.Checked = false;//曲线4不选中
                    this.TabPageCurve_Cbx_Curve5.Checked = false;//曲线5不选中
                    this.TabPageCurve_Cbx_Curve6.Checked = false;//曲线6不选中
                    this.TabPageCurve_Cbx_Curve7.Checked = false;//曲线7不选中
                    this.TabPageCurve_Cbx_Curve8.Checked = false;//曲线8不选中

                    this.TabPageCurve_Lab_Curve1.Enabled = true;//曲线1数值可用
                    this.TabPageCurve_Lab_Curve2.Enabled = true;//曲线2数值可用
                    this.TabPageCurve_Lab_Curve3.Enabled = false;//曲线3数值不可用
                    this.TabPageCurve_Lab_Curve4.Enabled = false;//曲线4数值不可用
                    this.TabPageCurve_Lab_Curve5.Enabled = false;//曲线5数值不可用
                    this.TabPageCurve_Lab_Curve6.Enabled = false;//曲线6数值不可用
                    this.TabPageCurve_Lab_Curve7.Enabled = false;//曲线7数值不可用
                    this.TabPageCurve_Lab_Curve8.Enabled = false;//曲线8数值不可用
                    break;
                case 3://当前选中3条曲线
                    this.TabPageCurve_Cbx_Curve1.Enabled = true;//曲线1可用
                    this.TabPageCurve_Cbx_Curve2.Enabled = true;//曲线2可用
                    this.TabPageCurve_Cbx_Curve3.Enabled = true;//曲线3可用
                    this.TabPageCurve_Cbx_Curve4.Enabled = false;//曲线4不可用
                    this.TabPageCurve_Cbx_Curve5.Enabled = false;//曲线5不可用
                    this.TabPageCurve_Cbx_Curve6.Enabled = false;//曲线6不可用
                    this.TabPageCurve_Cbx_Curve7.Enabled = false;//曲线7不可用
                    this.TabPageCurve_Cbx_Curve8.Enabled = false;//曲线8不可用

                    this.TabPageCurve_Cbx_Curve1.Checked = true;//曲线1选中
                    this.TabPageCurve_Cbx_Curve2.Checked = true;//曲线2选中
                    this.TabPageCurve_Cbx_Curve3.Checked = true;//曲线3选中
                    this.TabPageCurve_Cbx_Curve4.Checked = false;//曲线4不选中
                    this.TabPageCurve_Cbx_Curve5.Checked = false;//曲线5不选中
                    this.TabPageCurve_Cbx_Curve6.Checked = false;//曲线6不选中
                    this.TabPageCurve_Cbx_Curve7.Checked = false;//曲线7不选中
                    this.TabPageCurve_Cbx_Curve8.Checked = false;//曲线8不选中

                    this.TabPageCurve_Lab_Curve1.Enabled = true;//曲线1数值可用
                    this.TabPageCurve_Lab_Curve2.Enabled = true;//曲线2数值可用
                    this.TabPageCurve_Lab_Curve3.Enabled = true;//曲线3数值可用
                    this.TabPageCurve_Lab_Curve4.Enabled = false;//曲线4数值不可用
                    this.TabPageCurve_Lab_Curve5.Enabled = false;//曲线5数值不可用
                    this.TabPageCurve_Lab_Curve6.Enabled = false;//曲线6数值不可用
                    this.TabPageCurve_Lab_Curve7.Enabled = false;//曲线7数值不可用
                    this.TabPageCurve_Lab_Curve8.Enabled = false;//曲线8数值不可用
                    break;
                case 4://当前选中4条曲线
                    this.TabPageCurve_Cbx_Curve1.Enabled = true;//曲线1可用
                    this.TabPageCurve_Cbx_Curve2.Enabled = true;//曲线2可用
                    this.TabPageCurve_Cbx_Curve3.Enabled = true;//曲线3可用
                    this.TabPageCurve_Cbx_Curve4.Enabled = true;//曲线4可用
                    this.TabPageCurve_Cbx_Curve5.Enabled = false;//曲线5不可用
                    this.TabPageCurve_Cbx_Curve6.Enabled = false;//曲线6不可用
                    this.TabPageCurve_Cbx_Curve7.Enabled = false;//曲线7不可用
                    this.TabPageCurve_Cbx_Curve8.Enabled = false;//曲线8不可用

                    this.TabPageCurve_Cbx_Curve1.Checked = true;//曲线1选中
                    this.TabPageCurve_Cbx_Curve2.Checked = true;//曲线2选中
                    this.TabPageCurve_Cbx_Curve3.Checked = true;//曲线3选中
                    this.TabPageCurve_Cbx_Curve4.Checked = true;//曲线4选中
                    this.TabPageCurve_Cbx_Curve5.Checked = false;//曲线5不选中
                    this.TabPageCurve_Cbx_Curve6.Checked = false;//曲线6不选中
                    this.TabPageCurve_Cbx_Curve7.Checked = false;//曲线7不选中
                    this.TabPageCurve_Cbx_Curve8.Checked = false;//曲线8不选中

                    this.TabPageCurve_Lab_Curve1.Enabled = true;//曲线1数值可用
                    this.TabPageCurve_Lab_Curve2.Enabled = true;//曲线2数值可用
                    this.TabPageCurve_Lab_Curve3.Enabled = true;//曲线3数值可用
                    this.TabPageCurve_Lab_Curve4.Enabled = true;//曲线4数值可用
                    this.TabPageCurve_Lab_Curve5.Enabled = false;//曲线5数值不可用
                    this.TabPageCurve_Lab_Curve6.Enabled = false;//曲线6数值不可用
                    this.TabPageCurve_Lab_Curve7.Enabled = false;//曲线7数值不可用
                    this.TabPageCurve_Lab_Curve8.Enabled = false;//曲线8数值不可用
                    break;
                case 5://当前选中5条曲线
                    this.TabPageCurve_Cbx_Curve1.Enabled = true;//曲线1可用
                    this.TabPageCurve_Cbx_Curve2.Enabled = true;//曲线2可用
                    this.TabPageCurve_Cbx_Curve3.Enabled = true;//曲线3可用
                    this.TabPageCurve_Cbx_Curve4.Enabled = true;//曲线4可用
                    this.TabPageCurve_Cbx_Curve5.Enabled = true;//曲线5可用
                    this.TabPageCurve_Cbx_Curve6.Enabled = false;//曲线6不可用
                    this.TabPageCurve_Cbx_Curve7.Enabled = false;//曲线7不可用
                    this.TabPageCurve_Cbx_Curve8.Enabled = false;//曲线8不可用

                    this.TabPageCurve_Cbx_Curve1.Checked = true;//曲线1选中
                    this.TabPageCurve_Cbx_Curve2.Checked = true;//曲线2选中
                    this.TabPageCurve_Cbx_Curve3.Checked = true;//曲线3选中
                    this.TabPageCurve_Cbx_Curve4.Checked = true;//曲线4选中
                    this.TabPageCurve_Cbx_Curve5.Checked = true;//曲线5选中
                    this.TabPageCurve_Cbx_Curve6.Checked = false;//曲线6不选中
                    this.TabPageCurve_Cbx_Curve7.Checked = false;//曲线7不选中
                    this.TabPageCurve_Cbx_Curve8.Checked = false;//曲线8不选中

                    this.TabPageCurve_Lab_Curve1.Enabled = true;//曲线1数值可用
                    this.TabPageCurve_Lab_Curve2.Enabled = true;//曲线2数值可用
                    this.TabPageCurve_Lab_Curve3.Enabled = true;//曲线3数值可用
                    this.TabPageCurve_Lab_Curve4.Enabled = true;//曲线4数值可用
                    this.TabPageCurve_Lab_Curve5.Enabled = true;//曲线5数值可用
                    this.TabPageCurve_Lab_Curve6.Enabled = false;//曲线6数值不可用
                    this.TabPageCurve_Lab_Curve7.Enabled = false;//曲线7数值不可用
                    this.TabPageCurve_Lab_Curve8.Enabled = false;//曲线8数值不可用
                    break;
                case 6://当前选中6条曲线
                    this.TabPageCurve_Cbx_Curve1.Enabled = true;//曲线1可用
                    this.TabPageCurve_Cbx_Curve2.Enabled = true;//曲线2可用
                    this.TabPageCurve_Cbx_Curve3.Enabled = true;//曲线3可用
                    this.TabPageCurve_Cbx_Curve4.Enabled = true;//曲线4可用
                    this.TabPageCurve_Cbx_Curve5.Enabled = true;//曲线5可用
                    this.TabPageCurve_Cbx_Curve6.Enabled = true;//曲线6可用
                    this.TabPageCurve_Cbx_Curve7.Enabled = false;//曲线7不可用
                    this.TabPageCurve_Cbx_Curve8.Enabled = false;//曲线8不可用

                    this.TabPageCurve_Cbx_Curve1.Checked = true;//曲线1选中
                    this.TabPageCurve_Cbx_Curve2.Checked = true;//曲线2选中
                    this.TabPageCurve_Cbx_Curve3.Checked = true;//曲线3选中
                    this.TabPageCurve_Cbx_Curve4.Checked = true;//曲线4选中
                    this.TabPageCurve_Cbx_Curve5.Checked = true;//曲线5选中
                    this.TabPageCurve_Cbx_Curve6.Checked = true;//曲线6选中
                    this.TabPageCurve_Cbx_Curve7.Checked = false;//曲线7不选中
                    this.TabPageCurve_Cbx_Curve8.Checked = false;//曲线8不选中

                    this.TabPageCurve_Lab_Curve1.Enabled = true;//曲线1数值可用
                    this.TabPageCurve_Lab_Curve2.Enabled = true;//曲线2数值可用
                    this.TabPageCurve_Lab_Curve3.Enabled = true;//曲线3数值可用
                    this.TabPageCurve_Lab_Curve4.Enabled = true;//曲线4数值可用
                    this.TabPageCurve_Lab_Curve5.Enabled = true;//曲线5数值可用
                    this.TabPageCurve_Lab_Curve6.Enabled = true;//曲线6数值可用
                    this.TabPageCurve_Lab_Curve7.Enabled = false;//曲线7数值不可用
                    this.TabPageCurve_Lab_Curve8.Enabled = false;//曲线8数值不可用
                    break;
                case 7://当前选中7条曲线
                    this.TabPageCurve_Cbx_Curve1.Enabled = true;//曲线1可用
                    this.TabPageCurve_Cbx_Curve2.Enabled = true;//曲线2可用
                    this.TabPageCurve_Cbx_Curve3.Enabled = true;//曲线3可用
                    this.TabPageCurve_Cbx_Curve4.Enabled = true;//曲线4可用
                    this.TabPageCurve_Cbx_Curve5.Enabled = true;//曲线5可用
                    this.TabPageCurve_Cbx_Curve6.Enabled = true;//曲线6可用
                    this.TabPageCurve_Cbx_Curve7.Enabled = true;//曲线7可用
                    this.TabPageCurve_Cbx_Curve8.Enabled = false;//曲线8不可用

                    this.TabPageCurve_Cbx_Curve1.Checked = true;//曲线1选中
                    this.TabPageCurve_Cbx_Curve2.Checked = true;//曲线2选中
                    this.TabPageCurve_Cbx_Curve3.Checked = true;//曲线3选中
                    this.TabPageCurve_Cbx_Curve4.Checked = true;//曲线4选中
                    this.TabPageCurve_Cbx_Curve5.Checked = true;//曲线5选中
                    this.TabPageCurve_Cbx_Curve6.Checked = true;//曲线6选中
                    this.TabPageCurve_Cbx_Curve7.Checked = true;//曲线7选中
                    this.TabPageCurve_Cbx_Curve8.Checked = false;//曲线8不选中

                    this.TabPageCurve_Lab_Curve1.Enabled = true;//曲线1数值可用
                    this.TabPageCurve_Lab_Curve2.Enabled = true;//曲线2数值可用
                    this.TabPageCurve_Lab_Curve3.Enabled = true;//曲线3数值可用
                    this.TabPageCurve_Lab_Curve4.Enabled = true;//曲线4数值可用
                    this.TabPageCurve_Lab_Curve5.Enabled = true;//曲线5数值可用
                    this.TabPageCurve_Lab_Curve6.Enabled = true;//曲线6数值可用
                    this.TabPageCurve_Lab_Curve7.Enabled = true;//曲线7数值可用
                    this.TabPageCurve_Lab_Curve8.Enabled = false;//曲线8数值不可用
                    break;
                case 8://当前选中8条曲线
                    this.TabPageCurve_Cbx_Curve1.Enabled = true;//曲线1可用
                    this.TabPageCurve_Cbx_Curve2.Enabled = true;//曲线2可用
                    this.TabPageCurve_Cbx_Curve3.Enabled = true;//曲线3可用
                    this.TabPageCurve_Cbx_Curve4.Enabled = true;//曲线4可用
                    this.TabPageCurve_Cbx_Curve5.Enabled = true;//曲线5可用
                    this.TabPageCurve_Cbx_Curve6.Enabled = true;//曲线6可用
                    this.TabPageCurve_Cbx_Curve7.Enabled = true;//曲线7可用
                    this.TabPageCurve_Cbx_Curve8.Enabled = true;//曲线8可用

                    this.TabPageCurve_Cbx_Curve1.Checked = true;//曲线1选中
                    this.TabPageCurve_Cbx_Curve2.Checked = true;//曲线2选中
                    this.TabPageCurve_Cbx_Curve3.Checked = true;//曲线3选中
                    this.TabPageCurve_Cbx_Curve4.Checked = true;//曲线4选中
                    this.TabPageCurve_Cbx_Curve5.Checked = true;//曲线5选中
                    this.TabPageCurve_Cbx_Curve6.Checked = true;//曲线6选中
                    this.TabPageCurve_Cbx_Curve7.Checked = true;//曲线7选中
                    this.TabPageCurve_Cbx_Curve8.Checked = true;//曲线8选中

                    this.TabPageCurve_Lab_Curve1.Enabled = true;//曲线1数值可用
                    this.TabPageCurve_Lab_Curve2.Enabled = true;//曲线2数值可用
                    this.TabPageCurve_Lab_Curve3.Enabled = true;//曲线3数值可用
                    this.TabPageCurve_Lab_Curve4.Enabled = true;//曲线4数值可用
                    this.TabPageCurve_Lab_Curve5.Enabled = true;//曲线5数值可用
                    this.TabPageCurve_Lab_Curve6.Enabled = true;//曲线6数值可用
                    this.TabPageCurve_Lab_Curve7.Enabled = true;//曲线7数值可用
                    this.TabPageCurve_Lab_Curve8.Enabled = true;//曲线8数值可用
                    break;
                default: // 默认情况
                    MessageBox.Show("曲线数量输入错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        #endregion

        #region 曲线复选框事件

        #region 曲线复选框Checked变化
        private void TabPageCurve_Cbx_Curve1_CheckedChanged(object sender, EventArgs e) // 曲线1复选框Checked变化
        {
            if (this.TabPageCurve_Cbx_Curve1.Checked)//曲线1复选框选中
            {
                ZedGraph_Curve_1.IsVisible = true;//曲线1可见
            }
            else//曲线1复选框未选中
            {
                ZedGraph_Curve_1.IsVisible = false;//曲线1不可见
            }
        }

        private void TabPageCurve_Cbx_Curve2_CheckedChanged(object sender, EventArgs e) // 曲线2复选框Checked变化
        {
            if (this.TabPageCurve_Cbx_Curve2.Checked)//曲线2复选框选中
            {
                ZedGraph_Curve_2.IsVisible = true;//曲线2可见
            }
            else//曲线2复选框未选中
            {
                ZedGraph_Curve_2.IsVisible = false;//曲线2不可见
            }
        }

        private void TabPageCurve_Cbx_Curve3_CheckedChanged(object sender, EventArgs e) // 曲线3复选框Checked变化
        {
            if (this.TabPageCurve_Cbx_Curve3.Checked)//曲线3复选框选中
            {
                ZedGraph_Curve_3.IsVisible = true;//曲线3可见
            }
            else//曲线3复选框未选中
            {
                ZedGraph_Curve_3.IsVisible = false;//曲线3不可见
            }
        }

        private void TabPageCurve_Cbx_Curve4_CheckedChanged(object sender, EventArgs e) // 曲线4复选框Checked变化
        {
            if (this.TabPageCurve_Cbx_Curve4.Checked)//曲线4复选框选中
            {
                ZedGraph_Curve_4.IsVisible = true;//曲线4可见
            }
            else//曲线4复选框未选中
            {
                ZedGraph_Curve_4.IsVisible = false;//曲线4不可见
            }
        }

        private void TabPageCurve_Cbx_Curve5_CheckedChanged(object sender, EventArgs e) // 曲线5复选框Checked变化
        {
            if (this.TabPageCurve_Cbx_Curve5.Checked)//曲线5复选框选中
            {
                ZedGraph_Curve_5.IsVisible = true;//曲线5可见
            }
            else//曲线5复选框未选中
            {
                ZedGraph_Curve_5.IsVisible = false;//曲线5不可见
            }
        }

        private void TabPageCurve_Cbx_Curve6_CheckedChanged(object sender, EventArgs e) // 曲线6复选框Checked变化
        {
            if (this.TabPageCurve_Cbx_Curve6.Checked)//曲线6复选框选中
            {
                ZedGraph_Curve_6.IsVisible = true;//曲线6可见
            }
            else//曲线6复选框未选中
            {
                ZedGraph_Curve_6.IsVisible = false;//曲线6不可见
            }
        }

        private void TabPageCurve_Cbx_Curve7_CheckedChanged(object sender, EventArgs e) // 曲线7复选框Checked变化
        {
            if (this.TabPageCurve_Cbx_Curve7.Checked)//曲线7复选框选中
            {
                ZedGraph_Curve_7.IsVisible = true;//曲线7可见
            }
            else//曲线7复选框未选中
            {
                ZedGraph_Curve_7.IsVisible = false;//曲线7不可见
            }
        }

        private void TabPageCurve_Cbx_Curve8_CheckedChanged(object sender, EventArgs e) // 曲线8复选框Checked变化
        {
            if (this.TabPageCurve_Cbx_Curve8.Checked)//曲线8复选框选中
            {
                ZedGraph_Curve_8.IsVisible = true;//曲线8可见
            }
            else//曲线8复选框未选中
            {
                ZedGraph_Curve_8.IsVisible = false;//曲线8不可见
            }
        }

        #endregion

        #region 曲线复选框Enabled变化
        private void TabPageCurve_Cbx_Curve1_EnabledChanged(object sender, EventArgs e) // 曲线1复选框Enable变化
        {
            if (this.TabPageCurve_Cbx_Curve1.Enabled == false)//曲线1复选框禁止
            {
                ZedGraph_Curve_1.IsVisible = false;//曲线1不可见
            }
            else//曲线1复选框可用
            {
                if (this.TabPageCurve_Cbx_Curve1.Checked)//曲线1复选框选中
                {
                    ZedGraph_Curve_1.IsVisible = true;//曲线1可见
                }
                else
                {
                    ZedGraph_Curve_1.IsVisible = false;//曲线1不可见
                }
            }
        }

        private void TabPageCurve_Cbx_Curve2_EnabledChanged(object sender, EventArgs e) // 曲线2复选框Enable变化
        {
            if (this.TabPageCurve_Cbx_Curve2.Enabled == false)//曲线2复选框禁止
            {
                ZedGraph_Curve_2.IsVisible = false;//曲线2不可见
            }
            else//曲线2复选框可用
            {
                if (this.TabPageCurve_Cbx_Curve2.Checked)//曲线2复选框选中
                {
                    ZedGraph_Curve_2.IsVisible = true;//曲线2可见
                }
                else
                {
                    ZedGraph_Curve_2.IsVisible = false;//曲线2不可见
                }
            }
        }

        private void TabPageCurve_Cbx_Curve3_EnabledChanged(object sender, EventArgs e) // 曲线3复选框Enable变化
        {
            if (this.TabPageCurve_Cbx_Curve3.Enabled == false)//曲线3复选框禁止
            {
                ZedGraph_Curve_3.IsVisible = false;//曲线3不可见
            }
            else//曲线3复选框可用
            {
                if (this.TabPageCurve_Cbx_Curve3.Checked)//曲线3复选框选中
                {
                    ZedGraph_Curve_3.IsVisible = true;//曲线3可见
                }
                else
                {
                    ZedGraph_Curve_3.IsVisible = false;//曲线3不可见
                }
            }
        }

        private void TabPageCurve_Cbx_Curve4_EnabledChanged(object sender, EventArgs e) // 曲线4复选框Enable变化
        {
            if (this.TabPageCurve_Cbx_Curve4.Enabled == false)//曲线4复选框禁止
            {
                ZedGraph_Curve_4.IsVisible = false;//曲线4不可见
            }
            else//曲线4复选框可用
            {
                if (this.TabPageCurve_Cbx_Curve4.Checked)//曲线4复选框选中
                {
                    ZedGraph_Curve_4.IsVisible = true;//曲线4可见
                }
                else
                {
                    ZedGraph_Curve_4.IsVisible = false;//曲线4不可见
                }
            }
        }

        private void TabPageCurve_Cbx_Curve5_EnabledChanged(object sender, EventArgs e) // 曲线5复选框Enable变化
        {
            if (this.TabPageCurve_Cbx_Curve5.Enabled == false)//曲线5复选框禁止
            {
                ZedGraph_Curve_5.IsVisible = false;//曲线5不可见
            }
            else//曲线5复选框可用
            {
                if (this.TabPageCurve_Cbx_Curve5.Checked)//曲线5复选框选中
                {
                    ZedGraph_Curve_5.IsVisible = true;//曲线5可见
                }
                else
                {
                    ZedGraph_Curve_5.IsVisible = false;//曲线5不可见
                }
            }
        }

        private void TabPageCurve_Cbx_Curve6_EnabledChanged(object sender, EventArgs e) // 曲线6复选框Enable变化
        {
            if (this.TabPageCurve_Cbx_Curve6.Enabled == false)//曲线6复选框禁止
            {
                ZedGraph_Curve_6.IsVisible = false;//曲线6不可见
            }
            else//曲线6复选框可用
            {
                if (this.TabPageCurve_Cbx_Curve6.Checked)//曲线6复选框选中
                {
                    ZedGraph_Curve_6.IsVisible = true;//曲线6可见
                }
                else
                {
                    ZedGraph_Curve_6.IsVisible = false;//曲线6不可见
                }
            }
        }

        private void TabPageCurve_Cbx_Curve7_EnabledChanged(object sender, EventArgs e) // 曲线7复选框Enable变化
        {
            if (this.TabPageCurve_Cbx_Curve7.Enabled == false)//曲线7复选框禁止
            {
                ZedGraph_Curve_7.IsVisible = false;//曲线7不可见
            }
            else//曲线7复选框可用
            {
                if (this.TabPageCurve_Cbx_Curve7.Checked)//曲线7复选框选中
                {
                    ZedGraph_Curve_7.IsVisible = true;//曲线7可见
                }
                else
                {
                    ZedGraph_Curve_7.IsVisible = false;//曲线7不可见
                }
            }
        }

        private void TabPageCurve_Cbx_Curve8_EnabledChanged(object sender, EventArgs e) // 曲线8复选框Enable变化
        {
            if (this.TabPageCurve_Cbx_Curve8.Enabled == false)//曲线8复选框禁止
            {
                ZedGraph_Curve_8.IsVisible = false;//曲线8不可见
            }
            else//曲线8复选框可用
            {
                if (this.TabPageCurve_Cbx_Curve8.Checked)//曲线8复选框选中
                {
                    ZedGraph_Curve_8.IsVisible = true;//曲线8可见
                }
                else
                {
                    ZedGraph_Curve_8.IsVisible = false;//曲线8不可见
                }
            }
        }

        #endregion

        #endregion

        #endregion

        #region 数据分析

        #region 进程监视

        #region 进程监视曲线初始化
        private void AnalysisProcess_ZedGraphInit()
        {
            // ZedGraph坐标轴标题标签初始化
            this.TabPageProcess_Zed_Graph.GraphPane.Title.Text = "进程监视";
            this.TabPageProcess_Zed_Graph.GraphPane.XAxis.Title.Text = "时间";
            this.TabPageProcess_Zed_Graph.GraphPane.YAxis.Title.Text = "数值";
            //this.TabPageProcess_Zed_Graph.GraphPane.XAxis.MajorGrid.IsVisible = true;   // X轴虚线
            this.TabPageProcess_Zed_Graph.GraphPane.YAxis.MajorGrid.IsVisible = true; // Y轴虚线
            //this.TabPageProcess_Zed_Graph.GraphPane.Chart.Border.IsVisible = false;

            // ZedGraph坐标轴值设置初始化
            this.TabPageProcess_Zed_Graph.GraphPane.XAxis.Scale.Min = 1;  // X轴坐标最小值
            this.TabPageProcess_Zed_Graph.GraphPane.XAxis.Scale.Max = 2;  // X轴坐标最大值
            this.TabPageProcess_Zed_Graph.GraphPane.YAxis.Scale.Min = 0;  // Y轴坐标最小值
            this.TabPageProcess_Zed_Graph.GraphPane.YAxis.Scale.Max = 1;  // Y轴坐标最大值

            this.TabPageProcess_Zed_Graph.GraphPane.XAxis.Scale.MinAuto = true;
            this.TabPageProcess_Zed_Graph.GraphPane.XAxis.Scale.MaxAuto = true;
            this.TabPageProcess_Zed_Graph.GraphPane.YAxis.Scale.MinAuto = true;
            this.TabPageProcess_Zed_Graph.GraphPane.YAxis.Scale.MaxAuto = true;

            this.TabPageProcess_Zed_Graph.GraphPane.XAxis.Type = ZedGraph.AxisType.Ordinal;

            this.TabPageProcess_Zed_Graph.GraphPane.CurveList.Clear();    // 清空曲线

            // ZedGraph创建曲线
            ZedGraph_Process_1 = this.TabPageProcess_Zed_Graph.GraphPane.AddCurve("进程1", ZedGraph_ProcessList_1, Color.LightCoral, SymbolType.None);
            ZedGraph_Process_2 = this.TabPageProcess_Zed_Graph.GraphPane.AddCurve("进程2", ZedGraph_ProcessList_2, Color.Teal, SymbolType.None);
            ZedGraph_Process_3 = this.TabPageProcess_Zed_Graph.GraphPane.AddCurve("进程3", ZedGraph_ProcessList_3, Color.Orange, SymbolType.None);
            ZedGraph_Process_4 = this.TabPageProcess_Zed_Graph.GraphPane.AddCurve("进程4", ZedGraph_ProcessList_4, Color.LawnGreen, SymbolType.None);
            ZedGraph_Process_5 = this.TabPageProcess_Zed_Graph.GraphPane.AddCurve("进程5", ZedGraph_ProcessList_5, Color.LightSeaGreen, SymbolType.None);
            ZedGraph_Process_6 = this.TabPageProcess_Zed_Graph.GraphPane.AddCurve("进程6", ZedGraph_ProcessList_6, Color.LightSkyBlue, SymbolType.None);
            ZedGraph_Process_7 = this.TabPageProcess_Zed_Graph.GraphPane.AddCurve("进程7", ZedGraph_ProcessList_7, Color.RoyalBlue, SymbolType.None);
            ZedGraph_Process_8 = this.TabPageProcess_Zed_Graph.GraphPane.AddCurve("进程8", ZedGraph_ProcessList_8, Color.BlueViolet, SymbolType.None);

            // ZedGraph曲线可见
            ZedGraph_Process_1.IsVisible = false;
            ZedGraph_Process_2.IsVisible = false;
            ZedGraph_Process_3.IsVisible = false;
            ZedGraph_Process_4.IsVisible = false;
            ZedGraph_Process_5.IsVisible = false;
            ZedGraph_Process_6.IsVisible = false;
            ZedGraph_Process_7.IsVisible = false;
            ZedGraph_Process_8.IsVisible = false;

            // ZedGraph曲线样式设置
            ZedGraph_Process_1.Line.Width = 2;
            ZedGraph_Process_2.Line.Width = 2;
            ZedGraph_Process_3.Line.Width = 2;
            ZedGraph_Process_4.Line.Width = 2;
            ZedGraph_Process_5.Line.Width = 2;
            ZedGraph_Process_6.Line.Width = 2;
            ZedGraph_Process_7.Line.Width = 2;
            ZedGraph_Process_8.Line.Width = 2;

            this.TabPageProcess_Zed_Graph.Refresh();  // 刷新曲线

        }
        #endregion

        #region 进程PID文本框控件响应
        private void TabAnalysisProcessPage_Tbx_PID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TabAnalysisProcessPage_Tbx_PID_TextChanged(object sender, EventArgs e)
        {
            string strText = TabAnalysisProcessPage_Tbx_PID.Text;
            int nText = 0;

            if (strText != null && strText != "")
            {
                nText = int.Parse(strText);

                if (nText < 0)
                {
                    nText = 0;
                }

                if (nText > 65535)
                {
                    nText = 65535;
                }

                TabAnalysisProcessPage_Tbx_PID.Text = nText.ToString();
            }
        }
        #endregion

        #region 进程PID查找进程句柄
        private void TabAnalysisProcessPage_Btn_Find_Click(object sender, EventArgs e)
        {
            string strProcessID = this.TabAnalysisProcessPage_Tbx_PID.Text;

            if(strProcessID == "")
            {
                MessageBox.Show("进程PID不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UInt32 dwProcessID = UInt32.Parse(strProcessID);
            IntPtr hProcess = IntPtr.Zero;

            // 进程PID查找进程句柄
            UInt32 dwDesiredAccess = (UInt32)(0x000F0000L | 0x00100000L | 0x0000FFFF);
            hProcess = OpenProcess(dwDesiredAccess, 0, dwProcessID);
            if(hProcess == IntPtr.Zero)
            {
                MessageBox.Show("未查找到进程PID对应的进程句柄!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strhProcess = hProcess.ToString();
            TabAnalysisProcessPage_Tbx_Handle.Text = strhProcess;

            TabAnalysisProcessPage_Tbx_PID.ReadOnly = true;
            TabAnalysisProcessPage_Btn_Find.Enabled = false;
            TabAnalysisProcessPage_Btn_Add.Enabled = true;
            TabAnalysisProcessPage_Btn_Del.Enabled = false;
        }

        #endregion

        #region 进程监视开启关闭
        private void TabAnalysisProcessPage_Btn_Start_Click(object sender, EventArgs e)
        {
            if(!m_bPMStart) // 开始监视
            {
                int nCount = this.TabAnalysisProcessPage_LV_Process.Items.Count;
                if (nCount == 0)
                {
                    MessageBox.Show("请至少添加一个监视进程!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProcessGet.Enabled = true;
                ProcessGet.Start();
                ProcessRefresh.Enabled = true;
                ProcessRefresh.Start();

                m_bPMStart = true;
                this.TabAnalysisProcessPage_Btn_Start.Text = "关闭";

                this.TabAnalysisProcessPage_Btn_Find.Enabled = false;
                this.TabAnalysisProcessPage_Btn_Add.Enabled = false;
                this.TabAnalysisProcessPage_Btn_Del.Enabled = false;
            }
            else // 停止监视
            {
                ProcessRefresh.Stop();
                ProcessRefresh.Enabled = false;
                ProcessGet.Stop();
                ProcessGet.Enabled = false;

                m_bPMStart = false;
                this.TabAnalysisProcessPage_Btn_Start.Text = "开启";

                this.TabAnalysisProcessPage_Btn_Find.Enabled = true;
                this.TabAnalysisProcessPage_Btn_Add.Enabled = false;
                this.TabAnalysisProcessPage_Btn_Del.Enabled = true;
            }
            
        }
        #endregion

        #region 进程监视添加进程句柄
        private void TabAnalysisProcessPage_Btn_Add_Click(object sender, EventArgs e)
        {
            string strPID = this.TabAnalysisProcessPage_Tbx_PID.Text;
            string strProcess = this.TabAnalysisProcessPage_Tbx_Handle.Text;
            IntPtr hProcess = (IntPtr)(Convert.ToInt32(strProcess));

            // 进程监视存储迭代器
            foreach (KeyValuePair<string, IntPtr> pair in m_dicProcessHandle)
            {
                if (strPID == pair.Key)
                {
                    CloseHandle(pair.Value);
                    m_dicProcessHandle.Remove(pair.Key);
                    break;
                }

            }

            if (m_dicProcessHandle.Count < 8)
            {
                m_dicProcessHandle.Add(strPID, hProcess);
            }
            else
            {
                MessageBox.Show("进程监视队列已满!请先删除...", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 添加进程监视句柄
            this.TabAnalysisProcessPage_LV_Process.Items.Clear();

            this.TabAnalysisProcessPage_LV_Process.BeginUpdate();
            foreach(KeyValuePair<string, IntPtr> pair in m_dicProcessHandle)
            {
                ListViewItem item = new ListViewItem();

                item.Text = pair.Key;
                item.SubItems.Add(pair.Value.ToString());
                this.TabAnalysisProcessPage_LV_Process.Items.Add(item);
            }
            this.TabAnalysisProcessPage_LV_Process.EndUpdate();

            // 进程曲线CheckBox变化
            AnalysisProcess_UpdateList_CheckedChanged(m_dicProcessHandle.Count);

            // 恢复进程PID查找
            TabAnalysisProcessPage_Tbx_PID.ReadOnly = false;
            TabAnalysisProcessPage_Btn_Find.Enabled = true;
            TabAnalysisProcessPage_Btn_Add.Enabled = false;
            TabAnalysisProcessPage_Btn_Start.Enabled = true;
        }
        #endregion

        #region 进程监视删除进程句柄
        private void TabAnalysisProcessPage_Btn_Del_Click(object sender, EventArgs e)
        {
            int nDelCount = this.TabAnalysisProcessPage_LV_Process.CheckedItems.Count;

            if(nDelCount == 0)
            {
                MessageBox.Show("未选中任何监视进程!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> listDel = new List<string>();

            for(int i = 0; i < nDelCount; ++i)
            {
                string strProcessID = this.TabAnalysisProcessPage_LV_Process.CheckedItems[i].Text;
                listDel.Add(strProcessID);
            }

            // 进程监视存储迭代器
            Dictionary<string, IntPtr> dicCopy = new Dictionary<string, IntPtr>(m_dicProcessHandle);

            foreach (KeyValuePair<string, IntPtr> pair in dicCopy)
            {
                foreach(string it in listDel)
                {
                    if(it == pair.Key)
                    {
                        CloseHandle(pair.Value);
                        m_dicProcessHandle.Remove(pair.Key);
                        continue;
                    }

                }

            }

            // 刷新进程监视句柄
            this.TabAnalysisProcessPage_LV_Process.Items.Clear();

            this.TabAnalysisProcessPage_LV_Process.BeginUpdate();
            foreach (KeyValuePair<string, IntPtr> pair in m_dicProcessHandle)
            {
                ListViewItem item = new ListViewItem();

                item.Text = pair.Key;
                item.SubItems.Add(pair.Value.ToString());
                this.TabAnalysisProcessPage_LV_Process.Items.Add(item);
            }
            this.TabAnalysisProcessPage_LV_Process.EndUpdate();

            // 进程曲线CheckBox变化
            AnalysisProcess_UpdateList_CheckedChanged(m_dicProcessHandle.Count);

        }
        #endregion

        #region 进程监视获取内存信息定时器响应
        private void ProcessGet_Tick(object sender, EventArgs e)
        {
            if(!m_bPMFinish)
            {
                List<double> lstCurve = new List<double>();

                lstCurve.Clear();

                foreach (KeyValuePair<string, IntPtr> pair in m_dicProcessHandle)
                {
                    UInt32 bRet = 0;
                    PROCESS_MEMORY_COUNTERS sProcessInfo = new PROCESS_MEMORY_COUNTERS();
                    IntPtr hProcessInfo = IntPtr.Zero;

                    int nSize = Marshal.SizeOf(sProcessInfo);
                    IntPtr lpProcessInfo = Marshal.AllocHGlobal(nSize);
                    Marshal.StructureToPtr(sProcessInfo, lpProcessInfo, true);

                    bRet = GetProcessMemoryInfo(pair.Value, lpProcessInfo, (UInt32)nSize);
                    if (bRet == 0)
                    {
                        ProcessRefresh.Stop();
                        ProcessRefresh.Enabled = false;
                        this.ProcessGet.Stop();
                        this.ProcessGet.Enabled = false;

                        m_bPMStart = false;
                        this.TabAnalysisProcessPage_Btn_Start.Text = "开启";

                        this.TabAnalysisProcessPage_Btn_Find.Enabled = true;
                        this.TabAnalysisProcessPage_Btn_Add.Enabled = false;
                        this.TabAnalysisProcessPage_Btn_Start.Enabled = true;
                        return;
                    }

                    PROCESS_MEMORY_COUNTERS sGetInfo = (PROCESS_MEMORY_COUNTERS)Marshal.PtrToStructure(lpProcessInfo, typeof(PROCESS_MEMORY_COUNTERS));
                    double dProcessValue = sGetInfo.WorkingSetSize * 1.0f / 1024.0f / 1024.0f;

                    lstCurve.Add(dProcessValue);
                }

                for (int i = 0; i < 8; ++i)
                {
                    m_dProcessCurveValue[i] = 0.00;
                }

                for (int i = 0; i < lstCurve.Count; ++i)
                {
                    m_dProcessCurveValue[i] = lstCurve[i];
                }

                m_bPMFinish = true;
            }
            
        }
        #endregion

        #region 进程监视曲线刷新定时器响应
        private void ProcessRefresh_Tick(object sender, EventArgs e)
        {
            if (m_bPMFinish)  // 数据拆分完成
            {
                // 刷新UI界面
                this.Invoke((EventHandler)(delegate
                {
                    this.TabAnalysisProcessPage_Lab_P1.Text = "数值:" + m_dProcessCurveValue[0].ToString();   // 进程1数值显示
                    this.TabAnalysisProcessPage_Lab_P2.Text = "数值:" + m_dProcessCurveValue[1].ToString();   // 进程2数值显示
                    this.TabAnalysisProcessPage_Lab_P3.Text = "数值:" + m_dProcessCurveValue[2].ToString();   // 进程3数值显示
                    this.TabAnalysisProcessPage_Lab_P4.Text = "数值:" + m_dProcessCurveValue[3].ToString();   // 进程4数值显示
                    this.TabAnalysisProcessPage_Lab_P5.Text = "数值:" + m_dProcessCurveValue[4].ToString();   // 进程5数值显示
                    this.TabAnalysisProcessPage_Lab_P6.Text = "数值:" + m_dProcessCurveValue[5].ToString();   // 进程6数值显示
                    this.TabAnalysisProcessPage_Lab_P7.Text = "数值:" + m_dProcessCurveValue[6].ToString();   // 进程7数值显示
                    this.TabAnalysisProcessPage_Lab_P8.Text = "数值:" + m_dProcessCurveValue[7].ToString();   // 进程8数值显示

                    // 坐标点数多余300后保持坐标中存在300点
                    if (ZedGraph_ProcessList_1.Count >= 300)
                    {
                        ZedGraph_ProcessList_1.RemoveAt(0);
                    }
                    if (ZedGraph_ProcessList_2.Count >= 300)
                    {
                        ZedGraph_ProcessList_2.RemoveAt(0);
                    }
                    if (ZedGraph_ProcessList_3.Count >= 300)
                    {
                        ZedGraph_ProcessList_3.RemoveAt(0);
                    }
                    if (ZedGraph_ProcessList_4.Count >= 300)
                    {
                        ZedGraph_ProcessList_4.RemoveAt(0);
                    }
                    if (ZedGraph_ProcessList_5.Count >= 300)
                    {
                        ZedGraph_ProcessList_5.RemoveAt(0);
                    }
                    if (ZedGraph_ProcessList_6.Count >= 300)
                    {
                        ZedGraph_ProcessList_6.RemoveAt(0);
                    }
                    if (ZedGraph_ProcessList_7.Count >= 300)
                    {
                        ZedGraph_ProcessList_7.RemoveAt(0);
                    }
                    if (ZedGraph_ProcessList_8.Count >= 300)
                    {
                        ZedGraph_ProcessList_8.RemoveAt(0);
                    }

                    ZedGraph_ProcessList_1.Add(0, m_dProcessCurveValue[0]);  // ZedGraph_List_1添加数据
                    ZedGraph_ProcessList_2.Add(0, m_dProcessCurveValue[1]);  // ZedGraph_List_2添加数据
                    ZedGraph_ProcessList_3.Add(0, m_dProcessCurveValue[2]);  // ZedGraph_List_3添加数据
                    ZedGraph_ProcessList_4.Add(0, m_dProcessCurveValue[3]);  // ZedGraph_List_4添加数据
                    ZedGraph_ProcessList_5.Add(0, m_dProcessCurveValue[4]);  // ZedGraph_List_5添加数据
                    ZedGraph_ProcessList_6.Add(0, m_dProcessCurveValue[5]);  // ZedGraph_List_6添加数据
                    ZedGraph_ProcessList_7.Add(0, m_dProcessCurveValue[6]);  // ZedGraph_List_7添加数据
                    ZedGraph_ProcessList_8.Add(0, m_dProcessCurveValue[7]);  // ZedGraph_List_8添加数据

                    this.TabPageProcess_Zed_Graph.AxisChange();       // 坐标轴自动适应
                    this.TabPageProcess_Zed_Graph.Invalidate();       // 重绘控件
                }
                    ));
                m_bPMFinish = false;  // 等待拆分数据
            }
        }
        #endregion

        #region 进程监视复选框Checked变化
        private void TabAnalysisProcessPage_Cbx_P1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TabAnalysisProcessPage_Cbx_P1.Checked)
            {
                ZedGraph_Process_1.IsVisible = true;
            }
            else
            {
                ZedGraph_Process_1.IsVisible = false;
            }
        }

        private void TabAnalysisProcessPage_Cbx_P2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TabAnalysisProcessPage_Cbx_P2.Checked)
            {
                ZedGraph_Process_2.IsVisible = true;
            }
            else
            {
                ZedGraph_Process_2.IsVisible = false;
            }
        }

        private void TabAnalysisProcessPage_Cbx_P3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TabAnalysisProcessPage_Cbx_P3.Checked)
            {
                ZedGraph_Process_3.IsVisible = true;
            }
            else
            {
                ZedGraph_Process_3.IsVisible = false;
            }
        }

        private void TabAnalysisProcessPage_Cbx_P4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TabAnalysisProcessPage_Cbx_P4.Checked)
            {
                ZedGraph_Process_4.IsVisible = true;
            }
            else
            {
                ZedGraph_Process_4.IsVisible = false;
            }
        }

        private void TabAnalysisProcessPage_Cbx_P5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TabAnalysisProcessPage_Cbx_P5.Checked)
            {
                ZedGraph_Process_5.IsVisible = true;
            }
            else
            {
                ZedGraph_Process_5.IsVisible = false;
            }
        }

        private void TabAnalysisProcessPage_Cbx_P6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TabAnalysisProcessPage_Cbx_P6.Checked)
            {
                ZedGraph_Process_6.IsVisible = true;
            }
            else
            {
                ZedGraph_Process_6.IsVisible = false;
            }
        }

        private void TabAnalysisProcessPage_Cbx_P7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TabAnalysisProcessPage_Cbx_P7.Checked)
            {
                ZedGraph_Process_7.IsVisible = true;
            }
            else
            {
                ZedGraph_Process_7.IsVisible = false;
            }
        }

        private void TabAnalysisProcessPage_Cbx_P8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TabAnalysisProcessPage_Cbx_P8.Checked)
            {
                ZedGraph_Process_8.IsVisible = true;
            }
            else
            {
                ZedGraph_Process_8.IsVisible = false;
            }
        }
        #endregion

        #region 进程监视清除所有曲线
        private void TabAnalysisProcessPage_Btn_Clear_Click(object sender, EventArgs e)
        {
            // 清除绘图曲线
            ZedGraph_ProcessList_1.RemoveRange(0, ZedGraph_ProcessList_1.Count);  // 清除曲线1数据
            ZedGraph_ProcessList_2.RemoveRange(0, ZedGraph_ProcessList_2.Count);  // 清除曲线2数据
            ZedGraph_ProcessList_3.RemoveRange(0, ZedGraph_ProcessList_3.Count);  // 清除曲线3数据
            ZedGraph_ProcessList_4.RemoveRange(0, ZedGraph_ProcessList_4.Count);  // 清除曲线4数据
            ZedGraph_ProcessList_5.RemoveRange(0, ZedGraph_ProcessList_5.Count);  // 清除曲线5数据
            ZedGraph_ProcessList_6.RemoveRange(0, ZedGraph_ProcessList_6.Count);  // 清除曲线6数据
            ZedGraph_ProcessList_7.RemoveRange(0, ZedGraph_ProcessList_7.Count);  // 清除曲线7数据
            ZedGraph_ProcessList_8.RemoveRange(0, ZedGraph_ProcessList_8.Count);  // 清除曲线8数据

            ZedGraph_Process_1.Clear();   // 清除曲线1数据
            ZedGraph_Process_2.Clear();   // 清除曲线2数据
            ZedGraph_Process_3.Clear();   // 清除曲线3数据
            ZedGraph_Process_4.Clear();   // 清除曲线4数据
            ZedGraph_Process_5.Clear();   // 清除曲线5数据
            ZedGraph_Process_6.Clear();   // 清除曲线6数据
            ZedGraph_Process_7.Clear();   // 清除曲线7数据
            ZedGraph_Process_8.Clear();   // 清除曲线8数据

            this.TabPageProcess_Zed_Graph.Refresh();  // ZedGraph刷新
        }
        #endregion

        #region 进程监视当前显示曲线响应
        private void AnalysisProcess_UpdateList_CheckedChanged(int nCount)  // 曲线选中项改变
        {
            switch(nCount)
            {
                case 0:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = false;
                    break;
                case 1:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = false;
                    break;
                case 2:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = false;
                    break;
                case 3:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = false;
                    break;
                case 4:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = false;
                    break;
                case 5:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = false;
                    break;
                case 6:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = false;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = false;
                    break;
                case 7:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = false;
                    break;
                case 8:
                    this.TabAnalysisProcessPage_Cbx_P1.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P2.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P3.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P4.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P5.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P6.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P7.Checked = true;
                    this.TabAnalysisProcessPage_Cbx_P8.Checked = true;
                    break;
            }

        }

        #endregion

        #endregion

        #endregion

        #region 控制台

        #region 控制台记录
        private void TabPageConsole_ConsoleWrite(string strText)    // 控制台日志记录
        {
            if (!TabPageConsole_Tbx_Console.InvokeRequired)
            {
                string strArr = string.Empty;

                strArr += "[";
                strArr += DateTime.Now.ToString();
                strArr += "]";
                strArr += strText;

                TabPageConsole_Tbx_Console.AppendText(strArr);
            }
            else
            {
                ConsoleLogSetTextCallback = new CONSOLELOGSETTEXTCALLBACK(TabPageConsole_ConsoleWrite);
                TabPageConsole_Tbx_Console.Invoke(ConsoleLogSetTextCallback, strText);
            }
        }
        #endregion

        #region 清空控制台
        private void TabPageConsole_Btn_Clear_Click(object sender, EventArgs e) // 清空控制台
        {
            TabPageConsole_Tbx_Console.Clear();
        }
        #endregion

        #endregion

        #region 帮助

        #region 帮助项文本改变响应
        private void TabPageHelp_Cbx_HelpItem_SelectedIndexChanged(object sender, EventArgs e)  // 帮助项文本改变
        {
            ComboBox CbxHelpItem = sender as ComboBox;
            switch(CbxHelpItem.SelectedIndex)
            {
                case 0: // 串口调试
                    TabPageHelp_Cbx_HelpSubItem.Items.Clear();
                    TabPageHelp_Cbx_HelpSubItem.Items.Add("串口调试");
                    TabPageHelp_Cbx_HelpSubItem.SelectedIndex = 0;
                    break;
                case 1: // 网络调试
                    TabPageHelp_Cbx_HelpSubItem.Items.Clear();
                    TabPageHelp_Cbx_HelpSubItem.Items.Add("TCP服务端");
                    TabPageHelp_Cbx_HelpSubItem.Items.Add("TCP客户端");
                    TabPageHelp_Cbx_HelpSubItem.Items.Add("UDP");
                    TabPageHelp_Cbx_HelpSubItem.SelectedIndex = 0;
                    break;
                case 2: // 实时曲线
                    TabPageHelp_Cbx_HelpSubItem.Items.Clear();
                    TabPageHelp_Cbx_HelpSubItem.Items.Add("实时曲线");
                    TabPageHelp_Cbx_HelpSubItem.SelectedIndex = 0;
                    break;
                case 3: // 数据分析
                    TabPageHelp_Cbx_HelpSubItem.Items.Clear();
                    TabPageHelp_Cbx_HelpSubItem.Items.Add("进程监测");
                    TabPageHelp_Cbx_HelpSubItem.SelectedIndex = 0;
                    break;
                case 4: // 控制台
                    TabPageHelp_Cbx_HelpSubItem.Items.Clear();
                    TabPageHelp_Cbx_HelpSubItem.Items.Add("控制台");
                    TabPageHelp_Cbx_HelpSubItem.SelectedIndex = 0;
                    break;
                default:
                    MessageBox.Show("帮助项文本选择错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }
        #endregion

        #region 帮助子项文本改变响应
        private void TabPageHelp_Cbx_HelpSubItem_SelectedIndexChanged(object sender, EventArgs e)   // 帮助子项文本改变
        {

        }
        #endregion

        #region 帮助内容文本改变响应
        private void TabPageHelp_Cbx_HelpSubText_SelectedIndexChanged(object sender, EventArgs e)   // 帮助内容文本改变
        {

        }
        #endregion

        #region 帮助查询按钮点击响应
        private void TabPageHelp_Btn_Help_Click(object sender, EventArgs e)
        {
            int nIndexItem = 0;
            int nIndexSubItem = 0;
            int nIndexSubHelp = 0;

            nIndexItem = TabPageHelp_Cbx_HelpItem.SelectedIndex;            // 帮助项
            nIndexSubItem = TabPageHelp_Cbx_HelpSubItem.SelectedIndex;      // 帮助子项
            nIndexSubHelp = TabPageHelp_Cbx_HelpSubText.SelectedIndex;      // 帮助内容

            switch(nIndexItem)
            {
                case 0: // 串口调试
                    switch(nIndexSubItem)
                    {
                        case 0: // 串口调试
                            switch(nIndexSubHelp)
                            {
                                case 0: // 应用
                                    TabPageHelp_Tbx_Help.Clear();
                                    TabPageHelp_Tbx_Help.Text = "串口调试帮助:\r\r\n" +
                                                                "串口调试模块主要用于调试从控制器发送的串口数据, 支持多种协议, 支持多种传输方式.\r\r\n" +
                                                                "\r\r\n" +
                                                                "控制器支持:MCU、DSP、FPGA...\r\r\n" +
                                                                "协议支持:RS - 232、RS - 422、RS - 485\r\r\n" +
                                                                "传输方式: 串口、蓝牙、2.4GHz射频\r\r\n";
                                    break;
                                case 1: // 代码
                                    TabPageHelp_Tbx_Help.Clear();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 1: // 网络调试
                    switch (nIndexSubItem)
                    {
                        case 0: // TCP服务端
                            switch (nIndexSubHelp)
                            {
                                case 0: // 应用
                                    TabPageHelp_Tbx_Help.Clear();
                                    TabPageHelp_Tbx_Help.Text = "网络调试帮助:\r\r\n" +
                                                                "网络调试模块主要用于调试局域网内不同设备之间的通信数据.\r\r\n" +
                                                                "\r\r\n" + 
                                                                "网络调试支持:TCP、UDP.";

                                    break;
                                case 1: // 代码
                                    TabPageHelp_Tbx_Help.Clear();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 1: // TCP客户端
                            switch (nIndexSubHelp)
                            {
                                case 0: // 应用
                                    TabPageHelp_Tbx_Help.Clear();
                                    TabPageHelp_Tbx_Help.Text = "网络调试帮助:\r\r\n" +
                                                                "网络调试模块主要用于调试局域网内不同设备之间的通信数据.\r\r\n" +
                                                                "\r\r\n" +
                                                                "网络调试支持:TCP、UDP.";
                                    break;
                                case 1: // 代码
                                    TabPageHelp_Tbx_Help.Clear();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2: // UDP
                            switch (nIndexSubHelp)
                            {
                                case 0: // 应用
                                    TabPageHelp_Tbx_Help.Clear();
                                    TabPageHelp_Tbx_Help.Text = "网络调试帮助:\r\r\n" +
                                                                "网络调试模块主要用于调试局域网内不同设备之间的通信数据.\r\r\n" +
                                                                "\r\r\n" +
                                                                "网络调试支持:TCP、UDP.";
                                    break;
                                case 1: // 代码
                                    TabPageHelp_Tbx_Help.Clear();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 2: // 实时曲线
                    switch (nIndexSubItem)
                    {
                        case 0: // 实时曲线
                            switch (nIndexSubHelp)
                            {
                                case 0: // 应用
                                    TabPageHelp_Tbx_Help.Clear();
                                    TabPageHelp_Tbx_Help.Text = "实时曲线帮助:\r\r\n" +
                                                                "实时曲线模块主要用于显示从控制器发送的串口数据的曲线显示.\r\r\n" +
                                                                "\r\r\n" + 
                                                                "串口曲线发送格式:\r\r\n" +
                                                                "编码格式: 0xFF, 0x00, 0x16, 0x08, ...曲线i..., 0xAA, 0x55\r\r\n" +
                                                                "(8位发送, 先高后低)\r\r\n";
                                    break;
                                case 1: // 代码
                                    TabPageHelp_Tbx_Help.Clear();
                                    TabPageHelp_Tbx_Help.Text = "串口曲线发送格式:\r\r\n" +
                                                                "(格式: 0xFF, 0x00, 0x16, 0x08, ...曲线i..., 0xAA, 0x55)\r\r\n" +
                                                                "(8位发送, 先高后低)\r\r\n" +
                                                                "\r\r\n" +
                                                                "signed int SendData_Temp;\r\r\n" +
                                                                "unsigned char SendData_Temp_High, SendData_Temp_Low;\r\r\n" +
                                                                "\r\r\n" +
                                                                "UART_PutChar(UART_UART4, 0xFF);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, 0x00);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, 0x16);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, 0x08);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线1\r\r\n" +
                                                                "SendData_Temp = (signed int)DAC_Count;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线2\r\r\n" +
                                                                "SendData_Temp = (signed int)giAcc_Z;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线3\r\r\n" +
                                                                "SendData_Temp = (signed int)giGyro_Z;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线4\r\r\n" +
                                                                "SendData_Temp = (signed int)0;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线4\r\r\n" +
                                                                "SendData_Temp = (signed int)0;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线5\r\r\n" +
                                                                "SendData_Temp = (signed int)0;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线6\r\r\n" +
                                                                "SendData_Temp = (signed int)0;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线7\r\r\n" +
                                                                "SendData_Temp = (signed int)0;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "//曲线8\r\r\n" +
                                                                "SendData_Temp = (signed int)0;\r\r\n" +
                                                                "SendData_Temp_High = SendData_Temp >> 8;\r\r\n" +
                                                                "SendData_Temp_Low = SendData_Temp & 0xff;\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_High);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, SendData_Temp_Low);\r\r\n" +
                                                                "\r\r\n" +
                                                                "UART_PutChar(UART_UART4, 0xAA);\r\r\n" +
                                                                "UART_PutChar(UART_UART4, 0x55);\r\r\n";

                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 3: // 数据分析
                    switch (nIndexSubItem)
                    {
                        case 0: // 进程监视
                            switch (nIndexSubHelp)
                            {
                                case 0: // 应用
                                    TabPageHelp_Tbx_Help.Clear();
                                    break;
                                case 1: // 代码
                                    TabPageHelp_Tbx_Help.Clear();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 4: // 控制台
                    switch (nIndexSubItem)
                    {
                        case 0: // 控制台
                            switch (nIndexSubHelp)
                            {
                                case 0: // 应用
                                    TabPageHelp_Tbx_Help.Clear();
                                    break;
                                case 1: // 代码
                                    TabPageHelp_Tbx_Help.Clear();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

        }
        #endregion

        #endregion

        #region 关于

        #region 关于页面重绘
        private void TabPageAbout_Paint(object sender, PaintEventArgs e)    // 关于页面重绘
        {

        }
        #endregion

        #endregion

    }

}
