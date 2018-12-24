namespace CSMPC
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabPageSerial = new System.Windows.Forms.TabPage();
            this.TabPageSerial_Gbx_SerialSend = new System.Windows.Forms.GroupBox();
            this.TabPageSerial_Cbx_SerialRecvReturn = new System.Windows.Forms.CheckBox();
            this.MasterPC_TabPage_SerialPort_Label_Time = new System.Windows.Forms.Label();
            this.TabPageSerial_Nud_SerialTimer = new System.Windows.Forms.NumericUpDown();
            this.TabPageSerial_Cbx_SerialSendTimer = new System.Windows.Forms.CheckBox();
            this.TabPageSerial_Btn_SerialSend = new System.Windows.Forms.Button();
            this.TabPageSerial_Tbx_SerialSend = new System.Windows.Forms.TextBox();
            this.TabPageSerial_Gbx_SerialRecv = new System.Windows.Forms.GroupBox();
            this.TabPageSerial_Lab_SerialRecvSpeed = new System.Windows.Forms.Label();
            this.TabPageSerial_Tbx_SerialRecv = new System.Windows.Forms.TextBox();
            this.TabPageSerial_Gbx_SerialInfo = new System.Windows.Forms.GroupBox();
            this.TabPageSerial_Lab_SerialTipSend = new System.Windows.Forms.Label();
            this.TabPageSerial_Lab_SerialTipRecv = new System.Windows.Forms.Label();
            this.TabPageSerial_Tbx_SerialTipBaud = new System.Windows.Forms.TextBox();
            this.TabPageSerial_Lab_SerialTipBaud = new System.Windows.Forms.Label();
            this.TabPageSerial_Tbx_SerialTipName = new System.Windows.Forms.TextBox();
            this.TabPageSerial_Lab_SerialTipName = new System.Windows.Forms.Label();
            this.TabPageSerial_Tbx_SerialTipInfo = new System.Windows.Forms.TextBox();
            this.TabPageSerial_Lab_SerialTipInfo = new System.Windows.Forms.Label();
            this.TabPageSerial_Gbx_SerialFunction = new System.Windows.Forms.GroupBox();
            this.TabPageSerial_Gbx_Func = new System.Windows.Forms.GroupBox();
            this.TabPageSerial_Btn_Send_Clear = new System.Windows.Forms.Button();
            this.TabPageSerial_Btn_Recv_Clear = new System.Windows.Forms.Button();
            this.TabPageSerial_Gbx_Send = new System.Windows.Forms.GroupBox();
            this.TabPageSerial_Rad_Send_Hex = new System.Windows.Forms.RadioButton();
            this.TabPageSerial_Rad_Send_String = new System.Windows.Forms.RadioButton();
            this.TabPageSerial_Gbx_Recv = new System.Windows.Forms.GroupBox();
            this.TabPageSerial_Rad_Recv_Hex = new System.Windows.Forms.RadioButton();
            this.TabPageSerial_Rad_Recv_String = new System.Windows.Forms.RadioButton();
            this.TabPageSerial_Gbx_SerialConfig = new System.Windows.Forms.GroupBox();
            this.TabPageSerial_Btn_SerialOpen = new System.Windows.Forms.Button();
            this.TabPageSerial_Btn_SerialUpdate = new System.Windows.Forms.Button();
            this.TabPageSerial_Cbx_SerialCheckBit = new System.Windows.Forms.ComboBox();
            this.TabPageSerial_Lab_SerialCheckBit = new System.Windows.Forms.Label();
            this.TabPageSerial_Cbx_SerialStopBit = new System.Windows.Forms.ComboBox();
            this.TabPageSerial_Lab_SerialStopBit = new System.Windows.Forms.Label();
            this.TabPageSerial_Cbx_SerialDateBit = new System.Windows.Forms.ComboBox();
            this.TabPageSerial_Lab_SerialDateBit = new System.Windows.Forms.Label();
            this.TabPageSerial_Cbx_SerialBaud = new System.Windows.Forms.ComboBox();
            this.TabPageSerial_Lab_SerialBaud = new System.Windows.Forms.Label();
            this.TabPageSerial_Cbx_SerialName = new System.Windows.Forms.ComboBox();
            this.TabPageSerial_Lab_SerialName = new System.Windows.Forms.Label();
            this.TabPageNet = new System.Windows.Forms.TabPage();
            this.TabNet = new System.Windows.Forms.TabControl();
            this.TabPageTCPServer = new System.Windows.Forms.TabPage();
            this.TabPageTCPServer_Gbx_Send = new System.Windows.Forms.GroupBox();
            this.TabPageTCPServer_Lab_ConnectObject = new System.Windows.Forms.Label();
            this.TabPageTCPServer_Btn_Send = new System.Windows.Forms.Button();
            this.TabPageTCPServer_Cbx_ConnectObject = new System.Windows.Forms.ComboBox();
            this.TabPageTCPServer_Tbx_Send = new System.Windows.Forms.TextBox();
            this.TabPageTCPServer_Gbx_Recv = new System.Windows.Forms.GroupBox();
            this.TabPageTCPServer_Tbx_Recv = new System.Windows.Forms.TextBox();
            this.TabPageTCPServer_Gbx_NetFunction = new System.Windows.Forms.GroupBox();
            this.TabPageTCPServer_Gbx_NetFunc = new System.Windows.Forms.GroupBox();
            this.TabPageTCPServer_Btn_NetSendClear = new System.Windows.Forms.Button();
            this.TabPageTCPServer_Btn_NetRecvClear = new System.Windows.Forms.Button();
            this.TabPageTCPServer_Gbx_NetSend = new System.Windows.Forms.GroupBox();
            this.TabPageTCPServer_Rad_NetSendHex = new System.Windows.Forms.RadioButton();
            this.TabPageTCPServer_Rad_NetSendString = new System.Windows.Forms.RadioButton();
            this.TabPageTCPServer_Gbx_NetRecv = new System.Windows.Forms.GroupBox();
            this.TabPageTCPServer_Rad_NetRecvHex = new System.Windows.Forms.RadioButton();
            this.TabPageTCPServer_Rad_NetRecvString = new System.Windows.Forms.RadioButton();
            this.TabPageTCPServer_Gbx_NetConfig = new System.Windows.Forms.GroupBox();
            this.TabPageTCPServer_Btn_NetListen = new System.Windows.Forms.Button();
            this.TabPageTCPServer_Tbx_NetServerMaxListen = new System.Windows.Forms.TextBox();
            this.TabPageTCPServer_Lab_NetServerMaxListen = new System.Windows.Forms.Label();
            this.TabPageTCPServer_Tbx_NetLocalHostPort = new System.Windows.Forms.TextBox();
            this.TabPageTCPServer_Lab_NetLocalHostPort = new System.Windows.Forms.Label();
            this.TabPageTCPServer_Tbx_NetLocalHostIP = new System.Windows.Forms.TextBox();
            this.TabPageTCPServer_Lab_NetLocalHostIP = new System.Windows.Forms.Label();
            this.TabPageTCPClient = new System.Windows.Forms.TabPage();
            this.TabPageTCPClient_Gbx_Send = new System.Windows.Forms.GroupBox();
            this.TabPageTCPClient_Btn_Send = new System.Windows.Forms.Button();
            this.TabPageTCPClient_Tbx_Send = new System.Windows.Forms.TextBox();
            this.TabPageTCPClient_Gbx_Recv = new System.Windows.Forms.GroupBox();
            this.TabPageTCPClient_Tbx_Recv = new System.Windows.Forms.TextBox();
            this.TabPageTCPClient_Gbx_NetFunction = new System.Windows.Forms.GroupBox();
            this.TabPageTCPClient_Gbx_NetFunc = new System.Windows.Forms.GroupBox();
            this.TabPageTCPClient_Btn_NetSendClear = new System.Windows.Forms.Button();
            this.TabPageTCPClient_Btn_NetRecvClear = new System.Windows.Forms.Button();
            this.TabPageTCPClient_Gbx_NetSend = new System.Windows.Forms.GroupBox();
            this.TabPageTCPClient_Rad_NetSendHex = new System.Windows.Forms.RadioButton();
            this.TabPageTCPClient_Rad_NetSendString = new System.Windows.Forms.RadioButton();
            this.TabPageTCPClient_Gbx_NetRecv = new System.Windows.Forms.GroupBox();
            this.TabPageTCPClient_Rad_NetRecvHex = new System.Windows.Forms.RadioButton();
            this.TabPageTCPClient_Rad_NetRecvString = new System.Windows.Forms.RadioButton();
            this.TabPageTCPClient_Gbx_NetConfig = new System.Windows.Forms.GroupBox();
            this.TabPageTCPServer_Btn_NetConnect = new System.Windows.Forms.Button();
            this.TabPageTCPClient_Tbx_NetLocalHostPort = new System.Windows.Forms.TextBox();
            this.TabPageTCPClient_Lab_NetLocalHostPort = new System.Windows.Forms.Label();
            this.TabPageTCPClient_Tbx_NetLocalHostIP = new System.Windows.Forms.TextBox();
            this.TabPageTCPClient_Lab_NetLocalHostIP = new System.Windows.Forms.Label();
            this.TabPageUDP = new System.Windows.Forms.TabPage();
            this.TabPageUDP_Gbx_Send = new System.Windows.Forms.GroupBox();
            this.TabPageUDP_Tbx_TargetPort = new System.Windows.Forms.TextBox();
            this.TabPageUDP_Lab_TargetPort = new System.Windows.Forms.Label();
            this.TabPageUDP_Tbx_TargetIP = new System.Windows.Forms.TextBox();
            this.TabPageUDP_Lab_TargetIP = new System.Windows.Forms.Label();
            this.TabPageUDP_Btn_Send = new System.Windows.Forms.Button();
            this.TabPageUDP_Tbx_Send = new System.Windows.Forms.TextBox();
            this.TabPageUDP_Gbx_Recv = new System.Windows.Forms.GroupBox();
            this.TabPageUDP_Tbx_Recv = new System.Windows.Forms.TextBox();
            this.TabPageUDP_Gbx_NetFunction = new System.Windows.Forms.GroupBox();
            this.TabPageUDP_Gbx_NetFunc = new System.Windows.Forms.GroupBox();
            this.TabPageUDP_Btn_NetSendClear = new System.Windows.Forms.Button();
            this.TabPageUDP_Btn_NetRecvClear = new System.Windows.Forms.Button();
            this.TabPageUDP_Gbx_NetSend = new System.Windows.Forms.GroupBox();
            this.TabPageUDP_Rad_NetSendHex = new System.Windows.Forms.RadioButton();
            this.TabPageUDP_Rad_NetSendString = new System.Windows.Forms.RadioButton();
            this.TabPageUDP_Gbx_NetRecv = new System.Windows.Forms.GroupBox();
            this.TabPageUDP_Rad_NetRecvHex = new System.Windows.Forms.RadioButton();
            this.TabPageUDP_Rad_NetRecvString = new System.Windows.Forms.RadioButton();
            this.TabPageUDP_Gbx_NetConfig = new System.Windows.Forms.GroupBox();
            this.TabPageUDP_Btn_NetOpen = new System.Windows.Forms.Button();
            this.TabPageUDP_Tbx_NetLocalHostPort = new System.Windows.Forms.TextBox();
            this.TabPageUDP_Lab_NetLocalHostPort = new System.Windows.Forms.Label();
            this.TabPageUDP_Tbx_NetLocalHostIP = new System.Windows.Forms.TextBox();
            this.TabPageUDP_Lab_NetLocalHostIP = new System.Windows.Forms.Label();
            this.TabPageCurve = new System.Windows.Forms.TabPage();
            this.TabPageCurve_Gbx_SerialCurve = new System.Windows.Forms.GroupBox();
            this.TabPageCurve_Zed_Graph = new ZedGraph.ZedGraphControl();
            this.TabPageCurve_Gbx_SerialInfo = new System.Windows.Forms.GroupBox();
            this.TabPageCurve_Btn_ExportData = new System.Windows.Forms.Button();
            this.TabPageCurve_Lab_SerialInfoRecv = new System.Windows.Forms.Label();
            this.TabPageCurve_Tbx_SerialInfoBaud = new System.Windows.Forms.TextBox();
            this.TabPageCurve_Lab_SerialInfoBaud = new System.Windows.Forms.Label();
            this.TabPageCurve_Tbx_SerialInfoName = new System.Windows.Forms.TextBox();
            this.TabPageCurve_Lab_SerialInfoName = new System.Windows.Forms.Label();
            this.TabPageCurve_Tbx_SerialInfo = new System.Windows.Forms.TextBox();
            this.TabPageCurve_Lab_SerialInfo = new System.Windows.Forms.Label();
            this.TabPageCurve_Gbx_Function = new System.Windows.Forms.GroupBox();
            this.TabPageCurve_Btn_CurveClear = new System.Windows.Forms.Button();
            this.TabPageCurve_Lab_Curve8 = new System.Windows.Forms.Label();
            this.TabPageCurve_Lab_Curve7 = new System.Windows.Forms.Label();
            this.TabPageCurve_Lab_Curve6 = new System.Windows.Forms.Label();
            this.TabPageCurve_Lab_Curve5 = new System.Windows.Forms.Label();
            this.TabPageCurve_Lab_Curve4 = new System.Windows.Forms.Label();
            this.TabPageCurve_Lab_Curve3 = new System.Windows.Forms.Label();
            this.TabPageCurve_Lab_Curve2 = new System.Windows.Forms.Label();
            this.TabPageCurve_Lab_Curve1 = new System.Windows.Forms.Label();
            this.TabPageCurve_Nud_CurveNum = new System.Windows.Forms.NumericUpDown();
            this.TabPageCurve_Lab_CurveNum = new System.Windows.Forms.Label();
            this.TabPageCurve_Cbx_Curve8 = new System.Windows.Forms.CheckBox();
            this.TabPageCurve_Cbx_Curve7 = new System.Windows.Forms.CheckBox();
            this.TabPageCurve_Cbx_Curve6 = new System.Windows.Forms.CheckBox();
            this.TabPageCurve_Cbx_Curve5 = new System.Windows.Forms.CheckBox();
            this.TabPageCurve_Cbx_Curve4 = new System.Windows.Forms.CheckBox();
            this.TabPageCurve_Cbx_Curve3 = new System.Windows.Forms.CheckBox();
            this.TabPageCurve_Cbx_Curve2 = new System.Windows.Forms.CheckBox();
            this.TabPageCurve_Cbx_Curve1 = new System.Windows.Forms.CheckBox();
            this.TabPageCurve_Gbx_SerialConfig = new System.Windows.Forms.GroupBox();
            this.TabPageCurve_Btn_SerialOpen = new System.Windows.Forms.Button();
            this.TabPageCurve_Btn_SerialRefresh = new System.Windows.Forms.Button();
            this.TabPageCurve_Cbx_SerialCheckBit = new System.Windows.Forms.ComboBox();
            this.TabPageCurve_Lab_SerialCheckBit = new System.Windows.Forms.Label();
            this.TabPageCurve_Cbx_SerialStopBit = new System.Windows.Forms.ComboBox();
            this.TabPageCurve_Lab_SerialStopBit = new System.Windows.Forms.Label();
            this.TabPageCurve_Cbx_SerialDataBit = new System.Windows.Forms.ComboBox();
            this.TabPageCurve_Lab_SerialDataBit = new System.Windows.Forms.Label();
            this.TabPageCurve_Cbx_SerialBaud = new System.Windows.Forms.ComboBox();
            this.TabPageCurve_Lab_SerialBaud = new System.Windows.Forms.Label();
            this.TabPageCurve_Cbx_SerialName = new System.Windows.Forms.ComboBox();
            this.TabPageCurve_Lab_SerialName = new System.Windows.Forms.Label();
            this.TabPageAnalysis = new System.Windows.Forms.TabPage();
            this.TabPageConsole = new System.Windows.Forms.TabPage();
            this.TabPageHelp = new System.Windows.Forms.TabPage();
            this.TabPageAbout = new System.Windows.Forms.TabPage();
            this.SerialPortDebug = new System.IO.Ports.SerialPort(this.components);
            this.SerialTimerSend = new System.Windows.Forms.Timer(this.components);
            this.SerialTimerRecvSpeed = new System.Windows.Forms.Timer(this.components);
            this.SerialTimerRefresh = new System.Windows.Forms.Timer(this.components);
            this.SerialPortCurve = new System.IO.Ports.SerialPort(this.components);
            this.CurveRefresh = new System.Windows.Forms.Timer(this.components);
            this.TabMain.SuspendLayout();
            this.TabPageSerial.SuspendLayout();
            this.TabPageSerial_Gbx_SerialSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPageSerial_Nud_SerialTimer)).BeginInit();
            this.TabPageSerial_Gbx_SerialRecv.SuspendLayout();
            this.TabPageSerial_Gbx_SerialInfo.SuspendLayout();
            this.TabPageSerial_Gbx_SerialFunction.SuspendLayout();
            this.TabPageSerial_Gbx_Func.SuspendLayout();
            this.TabPageSerial_Gbx_Send.SuspendLayout();
            this.TabPageSerial_Gbx_Recv.SuspendLayout();
            this.TabPageSerial_Gbx_SerialConfig.SuspendLayout();
            this.TabPageNet.SuspendLayout();
            this.TabNet.SuspendLayout();
            this.TabPageTCPServer.SuspendLayout();
            this.TabPageTCPServer_Gbx_Send.SuspendLayout();
            this.TabPageTCPServer_Gbx_Recv.SuspendLayout();
            this.TabPageTCPServer_Gbx_NetFunction.SuspendLayout();
            this.TabPageTCPServer_Gbx_NetFunc.SuspendLayout();
            this.TabPageTCPServer_Gbx_NetSend.SuspendLayout();
            this.TabPageTCPServer_Gbx_NetRecv.SuspendLayout();
            this.TabPageTCPServer_Gbx_NetConfig.SuspendLayout();
            this.TabPageTCPClient.SuspendLayout();
            this.TabPageTCPClient_Gbx_Send.SuspendLayout();
            this.TabPageTCPClient_Gbx_Recv.SuspendLayout();
            this.TabPageTCPClient_Gbx_NetFunction.SuspendLayout();
            this.TabPageTCPClient_Gbx_NetFunc.SuspendLayout();
            this.TabPageTCPClient_Gbx_NetSend.SuspendLayout();
            this.TabPageTCPClient_Gbx_NetRecv.SuspendLayout();
            this.TabPageTCPClient_Gbx_NetConfig.SuspendLayout();
            this.TabPageUDP.SuspendLayout();
            this.TabPageUDP_Gbx_Send.SuspendLayout();
            this.TabPageUDP_Gbx_Recv.SuspendLayout();
            this.TabPageUDP_Gbx_NetFunction.SuspendLayout();
            this.TabPageUDP_Gbx_NetFunc.SuspendLayout();
            this.TabPageUDP_Gbx_NetSend.SuspendLayout();
            this.TabPageUDP_Gbx_NetRecv.SuspendLayout();
            this.TabPageUDP_Gbx_NetConfig.SuspendLayout();
            this.TabPageCurve.SuspendLayout();
            this.TabPageCurve_Gbx_SerialCurve.SuspendLayout();
            this.TabPageCurve_Gbx_SerialInfo.SuspendLayout();
            this.TabPageCurve_Gbx_Function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPageCurve_Nud_CurveNum)).BeginInit();
            this.TabPageCurve_Gbx_SerialConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.TabPageSerial);
            this.TabMain.Controls.Add(this.TabPageNet);
            this.TabMain.Controls.Add(this.TabPageCurve);
            this.TabMain.Controls.Add(this.TabPageAnalysis);
            this.TabMain.Controls.Add(this.TabPageConsole);
            this.TabMain.Controls.Add(this.TabPageHelp);
            this.TabMain.Controls.Add(this.TabPageAbout);
            this.TabMain.Location = new System.Drawing.Point(12, 12);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(920, 657);
            this.TabMain.TabIndex = 0;
            // 
            // TabPageSerial
            // 
            this.TabPageSerial.Controls.Add(this.TabPageSerial_Gbx_SerialSend);
            this.TabPageSerial.Controls.Add(this.TabPageSerial_Gbx_SerialRecv);
            this.TabPageSerial.Controls.Add(this.TabPageSerial_Gbx_SerialInfo);
            this.TabPageSerial.Controls.Add(this.TabPageSerial_Gbx_SerialFunction);
            this.TabPageSerial.Controls.Add(this.TabPageSerial_Gbx_SerialConfig);
            this.TabPageSerial.Location = new System.Drawing.Point(4, 22);
            this.TabPageSerial.Name = "TabPageSerial";
            this.TabPageSerial.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSerial.Size = new System.Drawing.Size(912, 631);
            this.TabPageSerial.TabIndex = 0;
            this.TabPageSerial.Text = "串口调试";
            this.TabPageSerial.UseVisualStyleBackColor = true;
            // 
            // TabPageSerial_Gbx_SerialSend
            // 
            this.TabPageSerial_Gbx_SerialSend.Controls.Add(this.TabPageSerial_Cbx_SerialRecvReturn);
            this.TabPageSerial_Gbx_SerialSend.Controls.Add(this.MasterPC_TabPage_SerialPort_Label_Time);
            this.TabPageSerial_Gbx_SerialSend.Controls.Add(this.TabPageSerial_Nud_SerialTimer);
            this.TabPageSerial_Gbx_SerialSend.Controls.Add(this.TabPageSerial_Cbx_SerialSendTimer);
            this.TabPageSerial_Gbx_SerialSend.Controls.Add(this.TabPageSerial_Btn_SerialSend);
            this.TabPageSerial_Gbx_SerialSend.Controls.Add(this.TabPageSerial_Tbx_SerialSend);
            this.TabPageSerial_Gbx_SerialSend.Location = new System.Drawing.Point(162, 302);
            this.TabPageSerial_Gbx_SerialSend.Name = "TabPageSerial_Gbx_SerialSend";
            this.TabPageSerial_Gbx_SerialSend.Size = new System.Drawing.Size(744, 270);
            this.TabPageSerial_Gbx_SerialSend.TabIndex = 5;
            this.TabPageSerial_Gbx_SerialSend.TabStop = false;
            this.TabPageSerial_Gbx_SerialSend.Text = "发送区";
            // 
            // TabPageSerial_Cbx_SerialRecvReturn
            // 
            this.TabPageSerial_Cbx_SerialRecvReturn.AutoSize = true;
            this.TabPageSerial_Cbx_SerialRecvReturn.Location = new System.Drawing.Point(6, 248);
            this.TabPageSerial_Cbx_SerialRecvReturn.Name = "TabPageSerial_Cbx_SerialRecvReturn";
            this.TabPageSerial_Cbx_SerialRecvReturn.Size = new System.Drawing.Size(72, 16);
            this.TabPageSerial_Cbx_SerialRecvReturn.TabIndex = 4;
            this.TabPageSerial_Cbx_SerialRecvReturn.Text = "接收换行";
            this.TabPageSerial_Cbx_SerialRecvReturn.UseVisualStyleBackColor = true;
            // 
            // MasterPC_TabPage_SerialPort_Label_Time
            // 
            this.MasterPC_TabPage_SerialPort_Label_Time.AutoSize = true;
            this.MasterPC_TabPage_SerialPort_Label_Time.Location = new System.Drawing.Point(218, 249);
            this.MasterPC_TabPage_SerialPort_Label_Time.Name = "MasterPC_TabPage_SerialPort_Label_Time";
            this.MasterPC_TabPage_SerialPort_Label_Time.Size = new System.Drawing.Size(29, 12);
            this.MasterPC_TabPage_SerialPort_Label_Time.TabIndex = 4;
            this.MasterPC_TabPage_SerialPort_Label_Time.Text = "毫秒";
            // 
            // TabPageSerial_Nud_SerialTimer
            // 
            this.TabPageSerial_Nud_SerialTimer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Nud_SerialTimer.Location = new System.Drawing.Point(162, 243);
            this.TabPageSerial_Nud_SerialTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TabPageSerial_Nud_SerialTimer.Name = "TabPageSerial_Nud_SerialTimer";
            this.TabPageSerial_Nud_SerialTimer.Size = new System.Drawing.Size(49, 23);
            this.TabPageSerial_Nud_SerialTimer.TabIndex = 3;
            this.TabPageSerial_Nud_SerialTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TabPageSerial_Nud_SerialTimer.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // TabPageSerial_Cbx_SerialSendTimer
            // 
            this.TabPageSerial_Cbx_SerialSendTimer.AutoSize = true;
            this.TabPageSerial_Cbx_SerialSendTimer.Location = new System.Drawing.Point(84, 248);
            this.TabPageSerial_Cbx_SerialSendTimer.Name = "TabPageSerial_Cbx_SerialSendTimer";
            this.TabPageSerial_Cbx_SerialSendTimer.Size = new System.Drawing.Size(72, 16);
            this.TabPageSerial_Cbx_SerialSendTimer.TabIndex = 1;
            this.TabPageSerial_Cbx_SerialSendTimer.Text = "定时发送";
            this.TabPageSerial_Cbx_SerialSendTimer.UseVisualStyleBackColor = true;
            this.TabPageSerial_Cbx_SerialSendTimer.CheckedChanged += new System.EventHandler(this.TabPageSerial_Cbx_SerialSendTimer_CheckedChanged);
            // 
            // TabPageSerial_Btn_SerialSend
            // 
            this.TabPageSerial_Btn_SerialSend.Enabled = false;
            this.TabPageSerial_Btn_SerialSend.Location = new System.Drawing.Point(612, 241);
            this.TabPageSerial_Btn_SerialSend.Name = "TabPageSerial_Btn_SerialSend";
            this.TabPageSerial_Btn_SerialSend.Size = new System.Drawing.Size(126, 23);
            this.TabPageSerial_Btn_SerialSend.TabIndex = 2;
            this.TabPageSerial_Btn_SerialSend.Text = "发送";
            this.TabPageSerial_Btn_SerialSend.UseVisualStyleBackColor = true;
            this.TabPageSerial_Btn_SerialSend.Click += new System.EventHandler(this.TabPageSerial_Btn_SerialSend_Click);
            // 
            // TabPageSerial_Tbx_SerialSend
            // 
            this.TabPageSerial_Tbx_SerialSend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Tbx_SerialSend.Location = new System.Drawing.Point(6, 20);
            this.TabPageSerial_Tbx_SerialSend.Multiline = true;
            this.TabPageSerial_Tbx_SerialSend.Name = "TabPageSerial_Tbx_SerialSend";
            this.TabPageSerial_Tbx_SerialSend.Size = new System.Drawing.Size(732, 215);
            this.TabPageSerial_Tbx_SerialSend.TabIndex = 1;
            this.TabPageSerial_Tbx_SerialSend.TextChanged += new System.EventHandler(this.TabPageSerial_Tbx_SerialSend_TextChanged);
            // 
            // TabPageSerial_Gbx_SerialRecv
            // 
            this.TabPageSerial_Gbx_SerialRecv.Controls.Add(this.TabPageSerial_Lab_SerialRecvSpeed);
            this.TabPageSerial_Gbx_SerialRecv.Controls.Add(this.TabPageSerial_Tbx_SerialRecv);
            this.TabPageSerial_Gbx_SerialRecv.Location = new System.Drawing.Point(162, 6);
            this.TabPageSerial_Gbx_SerialRecv.Name = "TabPageSerial_Gbx_SerialRecv";
            this.TabPageSerial_Gbx_SerialRecv.Size = new System.Drawing.Size(744, 290);
            this.TabPageSerial_Gbx_SerialRecv.TabIndex = 4;
            this.TabPageSerial_Gbx_SerialRecv.TabStop = false;
            this.TabPageSerial_Gbx_SerialRecv.Text = "接收区";
            // 
            // TabPageSerial_Lab_SerialRecvSpeed
            // 
            this.TabPageSerial_Lab_SerialRecvSpeed.AutoSize = true;
            this.TabPageSerial_Lab_SerialRecvSpeed.BackColor = System.Drawing.Color.White;
            this.TabPageSerial_Lab_SerialRecvSpeed.Location = new System.Drawing.Point(616, 0);
            this.TabPageSerial_Lab_SerialRecvSpeed.Name = "TabPageSerial_Lab_SerialRecvSpeed";
            this.TabPageSerial_Lab_SerialRecvSpeed.Size = new System.Drawing.Size(83, 12);
            this.TabPageSerial_Lab_SerialRecvSpeed.TabIndex = 1;
            this.TabPageSerial_Lab_SerialRecvSpeed.Text = "速度:0字节/秒";
            // 
            // TabPageSerial_Tbx_SerialRecv
            // 
            this.TabPageSerial_Tbx_SerialRecv.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Tbx_SerialRecv.Location = new System.Drawing.Point(6, 20);
            this.TabPageSerial_Tbx_SerialRecv.Multiline = true;
            this.TabPageSerial_Tbx_SerialRecv.Name = "TabPageSerial_Tbx_SerialRecv";
            this.TabPageSerial_Tbx_SerialRecv.Size = new System.Drawing.Size(732, 264);
            this.TabPageSerial_Tbx_SerialRecv.TabIndex = 1;
            this.TabPageSerial_Tbx_SerialRecv.TextChanged += new System.EventHandler(this.TabPageSerial_Tbx_SerialRecv_TextChanged);
            // 
            // TabPageSerial_Gbx_SerialInfo
            // 
            this.TabPageSerial_Gbx_SerialInfo.Controls.Add(this.TabPageSerial_Lab_SerialTipSend);
            this.TabPageSerial_Gbx_SerialInfo.Controls.Add(this.TabPageSerial_Lab_SerialTipRecv);
            this.TabPageSerial_Gbx_SerialInfo.Controls.Add(this.TabPageSerial_Tbx_SerialTipBaud);
            this.TabPageSerial_Gbx_SerialInfo.Controls.Add(this.TabPageSerial_Lab_SerialTipBaud);
            this.TabPageSerial_Gbx_SerialInfo.Controls.Add(this.TabPageSerial_Tbx_SerialTipName);
            this.TabPageSerial_Gbx_SerialInfo.Controls.Add(this.TabPageSerial_Lab_SerialTipName);
            this.TabPageSerial_Gbx_SerialInfo.Controls.Add(this.TabPageSerial_Tbx_SerialTipInfo);
            this.TabPageSerial_Gbx_SerialInfo.Controls.Add(this.TabPageSerial_Lab_SerialTipInfo);
            this.TabPageSerial_Gbx_SerialInfo.Location = new System.Drawing.Point(6, 578);
            this.TabPageSerial_Gbx_SerialInfo.Name = "TabPageSerial_Gbx_SerialInfo";
            this.TabPageSerial_Gbx_SerialInfo.Size = new System.Drawing.Size(900, 47);
            this.TabPageSerial_Gbx_SerialInfo.TabIndex = 3;
            this.TabPageSerial_Gbx_SerialInfo.TabStop = false;
            this.TabPageSerial_Gbx_SerialInfo.Text = "串口信息";
            // 
            // TabPageSerial_Lab_SerialTipSend
            // 
            this.TabPageSerial_Lab_SerialTipSend.AutoSize = true;
            this.TabPageSerial_Lab_SerialTipSend.Location = new System.Drawing.Point(816, 21);
            this.TabPageSerial_Lab_SerialTipSend.Name = "TabPageSerial_Lab_SerialTipSend";
            this.TabPageSerial_Lab_SerialTipSend.Size = new System.Drawing.Size(53, 12);
            this.TabPageSerial_Lab_SerialTipSend.TabIndex = 10;
            this.TabPageSerial_Lab_SerialTipSend.Text = "已发送:0";
            // 
            // TabPageSerial_Lab_SerialTipRecv
            // 
            this.TabPageSerial_Lab_SerialTipRecv.AutoSize = true;
            this.TabPageSerial_Lab_SerialTipRecv.Location = new System.Drawing.Point(724, 21);
            this.TabPageSerial_Lab_SerialTipRecv.Name = "TabPageSerial_Lab_SerialTipRecv";
            this.TabPageSerial_Lab_SerialTipRecv.Size = new System.Drawing.Size(53, 12);
            this.TabPageSerial_Lab_SerialTipRecv.TabIndex = 1;
            this.TabPageSerial_Lab_SerialTipRecv.Text = "已接收:0";
            // 
            // TabPageSerial_Tbx_SerialTipBaud
            // 
            this.TabPageSerial_Tbx_SerialTipBaud.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Tbx_SerialTipBaud.Location = new System.Drawing.Point(622, 18);
            this.TabPageSerial_Tbx_SerialTipBaud.Name = "TabPageSerial_Tbx_SerialTipBaud";
            this.TabPageSerial_Tbx_SerialTipBaud.Size = new System.Drawing.Size(85, 22);
            this.TabPageSerial_Tbx_SerialTipBaud.TabIndex = 9;
            // 
            // TabPageSerial_Lab_SerialTipBaud
            // 
            this.TabPageSerial_Lab_SerialTipBaud.AutoSize = true;
            this.TabPageSerial_Lab_SerialTipBaud.Location = new System.Drawing.Point(569, 21);
            this.TabPageSerial_Lab_SerialTipBaud.Name = "TabPageSerial_Lab_SerialTipBaud";
            this.TabPageSerial_Lab_SerialTipBaud.Size = new System.Drawing.Size(47, 12);
            this.TabPageSerial_Lab_SerialTipBaud.TabIndex = 8;
            this.TabPageSerial_Lab_SerialTipBaud.Text = "波特率:";
            // 
            // TabPageSerial_Tbx_SerialTipName
            // 
            this.TabPageSerial_Tbx_SerialTipName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Tbx_SerialTipName.Location = new System.Drawing.Point(478, 18);
            this.TabPageSerial_Tbx_SerialTipName.Name = "TabPageSerial_Tbx_SerialTipName";
            this.TabPageSerial_Tbx_SerialTipName.Size = new System.Drawing.Size(85, 22);
            this.TabPageSerial_Tbx_SerialTipName.TabIndex = 7;
            // 
            // TabPageSerial_Lab_SerialTipName
            // 
            this.TabPageSerial_Lab_SerialTipName.AutoSize = true;
            this.TabPageSerial_Lab_SerialTipName.Location = new System.Drawing.Point(425, 22);
            this.TabPageSerial_Lab_SerialTipName.Name = "TabPageSerial_Lab_SerialTipName";
            this.TabPageSerial_Lab_SerialTipName.Size = new System.Drawing.Size(47, 12);
            this.TabPageSerial_Lab_SerialTipName.TabIndex = 6;
            this.TabPageSerial_Lab_SerialTipName.Text = "串口号:";
            // 
            // TabPageSerial_Tbx_SerialTipInfo
            // 
            this.TabPageSerial_Tbx_SerialTipInfo.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPageSerial_Tbx_SerialTipInfo.Location = new System.Drawing.Point(71, 19);
            this.TabPageSerial_Tbx_SerialTipInfo.Name = "TabPageSerial_Tbx_SerialTipInfo";
            this.TabPageSerial_Tbx_SerialTipInfo.Size = new System.Drawing.Size(348, 21);
            this.TabPageSerial_Tbx_SerialTipInfo.TabIndex = 1;
            // 
            // TabPageSerial_Lab_SerialTipInfo
            // 
            this.TabPageSerial_Lab_SerialTipInfo.AutoSize = true;
            this.TabPageSerial_Lab_SerialTipInfo.Location = new System.Drawing.Point(6, 22);
            this.TabPageSerial_Lab_SerialTipInfo.Name = "TabPageSerial_Lab_SerialTipInfo";
            this.TabPageSerial_Lab_SerialTipInfo.Size = new System.Drawing.Size(59, 12);
            this.TabPageSerial_Lab_SerialTipInfo.TabIndex = 5;
            this.TabPageSerial_Lab_SerialTipInfo.Text = "提示信息:";
            // 
            // TabPageSerial_Gbx_SerialFunction
            // 
            this.TabPageSerial_Gbx_SerialFunction.Controls.Add(this.TabPageSerial_Gbx_Func);
            this.TabPageSerial_Gbx_SerialFunction.Controls.Add(this.TabPageSerial_Gbx_Send);
            this.TabPageSerial_Gbx_SerialFunction.Controls.Add(this.TabPageSerial_Gbx_Recv);
            this.TabPageSerial_Gbx_SerialFunction.Location = new System.Drawing.Point(6, 223);
            this.TabPageSerial_Gbx_SerialFunction.Name = "TabPageSerial_Gbx_SerialFunction";
            this.TabPageSerial_Gbx_SerialFunction.Size = new System.Drawing.Size(150, 240);
            this.TabPageSerial_Gbx_SerialFunction.TabIndex = 2;
            this.TabPageSerial_Gbx_SerialFunction.TabStop = false;
            this.TabPageSerial_Gbx_SerialFunction.Text = "串口辅助";
            // 
            // TabPageSerial_Gbx_Func
            // 
            this.TabPageSerial_Gbx_Func.Controls.Add(this.TabPageSerial_Btn_Send_Clear);
            this.TabPageSerial_Gbx_Func.Controls.Add(this.TabPageSerial_Btn_Recv_Clear);
            this.TabPageSerial_Gbx_Func.Location = new System.Drawing.Point(6, 160);
            this.TabPageSerial_Gbx_Func.Name = "TabPageSerial_Gbx_Func";
            this.TabPageSerial_Gbx_Func.Size = new System.Drawing.Size(138, 74);
            this.TabPageSerial_Gbx_Func.TabIndex = 1;
            this.TabPageSerial_Gbx_Func.TabStop = false;
            this.TabPageSerial_Gbx_Func.Text = "功能";
            // 
            // TabPageSerial_Btn_Send_Clear
            // 
            this.TabPageSerial_Btn_Send_Clear.Location = new System.Drawing.Point(6, 45);
            this.TabPageSerial_Btn_Send_Clear.Name = "TabPageSerial_Btn_Send_Clear";
            this.TabPageSerial_Btn_Send_Clear.Size = new System.Drawing.Size(126, 23);
            this.TabPageSerial_Btn_Send_Clear.TabIndex = 2;
            this.TabPageSerial_Btn_Send_Clear.Text = "清发送区";
            this.TabPageSerial_Btn_Send_Clear.UseVisualStyleBackColor = true;
            this.TabPageSerial_Btn_Send_Clear.Click += new System.EventHandler(this.TabPageSerial_Btn_Send_Clear_Click);
            // 
            // TabPageSerial_Btn_Recv_Clear
            // 
            this.TabPageSerial_Btn_Recv_Clear.Location = new System.Drawing.Point(6, 16);
            this.TabPageSerial_Btn_Recv_Clear.Name = "TabPageSerial_Btn_Recv_Clear";
            this.TabPageSerial_Btn_Recv_Clear.Size = new System.Drawing.Size(126, 23);
            this.TabPageSerial_Btn_Recv_Clear.TabIndex = 1;
            this.TabPageSerial_Btn_Recv_Clear.Text = "清接收区";
            this.TabPageSerial_Btn_Recv_Clear.UseVisualStyleBackColor = true;
            this.TabPageSerial_Btn_Recv_Clear.Click += new System.EventHandler(this.TabPageSerial_Btn_Recv_Clear_Click);
            // 
            // TabPageSerial_Gbx_Send
            // 
            this.TabPageSerial_Gbx_Send.Controls.Add(this.TabPageSerial_Rad_Send_Hex);
            this.TabPageSerial_Gbx_Send.Controls.Add(this.TabPageSerial_Rad_Send_String);
            this.TabPageSerial_Gbx_Send.Location = new System.Drawing.Point(6, 90);
            this.TabPageSerial_Gbx_Send.Name = "TabPageSerial_Gbx_Send";
            this.TabPageSerial_Gbx_Send.Size = new System.Drawing.Size(138, 64);
            this.TabPageSerial_Gbx_Send.TabIndex = 1;
            this.TabPageSerial_Gbx_Send.TabStop = false;
            this.TabPageSerial_Gbx_Send.Text = "发码区";
            // 
            // TabPageSerial_Rad_Send_Hex
            // 
            this.TabPageSerial_Rad_Send_Hex.AutoSize = true;
            this.TabPageSerial_Rad_Send_Hex.Location = new System.Drawing.Point(6, 42);
            this.TabPageSerial_Rad_Send_Hex.Name = "TabPageSerial_Rad_Send_Hex";
            this.TabPageSerial_Rad_Send_Hex.Size = new System.Drawing.Size(95, 16);
            this.TabPageSerial_Rad_Send_Hex.TabIndex = 2;
            this.TabPageSerial_Rad_Send_Hex.TabStop = true;
            this.TabPageSerial_Rad_Send_Hex.Text = "十六进制发送";
            this.TabPageSerial_Rad_Send_Hex.UseVisualStyleBackColor = true;
            // 
            // TabPageSerial_Rad_Send_String
            // 
            this.TabPageSerial_Rad_Send_String.AutoSize = true;
            this.TabPageSerial_Rad_Send_String.Location = new System.Drawing.Point(6, 20);
            this.TabPageSerial_Rad_Send_String.Name = "TabPageSerial_Rad_Send_String";
            this.TabPageSerial_Rad_Send_String.Size = new System.Drawing.Size(83, 16);
            this.TabPageSerial_Rad_Send_String.TabIndex = 1;
            this.TabPageSerial_Rad_Send_String.TabStop = true;
            this.TabPageSerial_Rad_Send_String.Text = "字符串发送";
            this.TabPageSerial_Rad_Send_String.UseVisualStyleBackColor = true;
            // 
            // TabPageSerial_Gbx_Recv
            // 
            this.TabPageSerial_Gbx_Recv.Controls.Add(this.TabPageSerial_Rad_Recv_Hex);
            this.TabPageSerial_Gbx_Recv.Controls.Add(this.TabPageSerial_Rad_Recv_String);
            this.TabPageSerial_Gbx_Recv.Location = new System.Drawing.Point(6, 20);
            this.TabPageSerial_Gbx_Recv.Name = "TabPageSerial_Gbx_Recv";
            this.TabPageSerial_Gbx_Recv.Size = new System.Drawing.Size(138, 64);
            this.TabPageSerial_Gbx_Recv.TabIndex = 1;
            this.TabPageSerial_Gbx_Recv.TabStop = false;
            this.TabPageSerial_Gbx_Recv.Text = "收码区";
            // 
            // TabPageSerial_Rad_Recv_Hex
            // 
            this.TabPageSerial_Rad_Recv_Hex.AutoSize = true;
            this.TabPageSerial_Rad_Recv_Hex.Location = new System.Drawing.Point(6, 42);
            this.TabPageSerial_Rad_Recv_Hex.Name = "TabPageSerial_Rad_Recv_Hex";
            this.TabPageSerial_Rad_Recv_Hex.Size = new System.Drawing.Size(95, 16);
            this.TabPageSerial_Rad_Recv_Hex.TabIndex = 1;
            this.TabPageSerial_Rad_Recv_Hex.TabStop = true;
            this.TabPageSerial_Rad_Recv_Hex.Text = "十六进制显示";
            this.TabPageSerial_Rad_Recv_Hex.UseVisualStyleBackColor = true;
            // 
            // TabPageSerial_Rad_Recv_String
            // 
            this.TabPageSerial_Rad_Recv_String.AutoSize = true;
            this.TabPageSerial_Rad_Recv_String.Location = new System.Drawing.Point(6, 20);
            this.TabPageSerial_Rad_Recv_String.Name = "TabPageSerial_Rad_Recv_String";
            this.TabPageSerial_Rad_Recv_String.Size = new System.Drawing.Size(83, 16);
            this.TabPageSerial_Rad_Recv_String.TabIndex = 0;
            this.TabPageSerial_Rad_Recv_String.TabStop = true;
            this.TabPageSerial_Rad_Recv_String.Text = "字符串显示";
            this.TabPageSerial_Rad_Recv_String.UseVisualStyleBackColor = true;
            // 
            // TabPageSerial_Gbx_SerialConfig
            // 
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Btn_SerialOpen);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Btn_SerialUpdate);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Cbx_SerialCheckBit);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Lab_SerialCheckBit);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Cbx_SerialStopBit);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Lab_SerialStopBit);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Cbx_SerialDateBit);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Lab_SerialDateBit);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Cbx_SerialBaud);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Lab_SerialBaud);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Cbx_SerialName);
            this.TabPageSerial_Gbx_SerialConfig.Controls.Add(this.TabPageSerial_Lab_SerialName);
            this.TabPageSerial_Gbx_SerialConfig.Location = new System.Drawing.Point(6, 6);
            this.TabPageSerial_Gbx_SerialConfig.Name = "TabPageSerial_Gbx_SerialConfig";
            this.TabPageSerial_Gbx_SerialConfig.Size = new System.Drawing.Size(150, 211);
            this.TabPageSerial_Gbx_SerialConfig.TabIndex = 0;
            this.TabPageSerial_Gbx_SerialConfig.TabStop = false;
            this.TabPageSerial_Gbx_SerialConfig.Text = "串口配置";
            // 
            // TabPageSerial_Btn_SerialOpen
            // 
            this.TabPageSerial_Btn_SerialOpen.Location = new System.Drawing.Point(6, 182);
            this.TabPageSerial_Btn_SerialOpen.Name = "TabPageSerial_Btn_SerialOpen";
            this.TabPageSerial_Btn_SerialOpen.Size = new System.Drawing.Size(138, 23);
            this.TabPageSerial_Btn_SerialOpen.TabIndex = 17;
            this.TabPageSerial_Btn_SerialOpen.Text = "打开串口";
            this.TabPageSerial_Btn_SerialOpen.UseVisualStyleBackColor = true;
            this.TabPageSerial_Btn_SerialOpen.Click += new System.EventHandler(this.TabPageSerial_Btn_SerialOpen_Click);
            // 
            // TabPageSerial_Btn_SerialUpdate
            // 
            this.TabPageSerial_Btn_SerialUpdate.Location = new System.Drawing.Point(6, 153);
            this.TabPageSerial_Btn_SerialUpdate.Name = "TabPageSerial_Btn_SerialUpdate";
            this.TabPageSerial_Btn_SerialUpdate.Size = new System.Drawing.Size(138, 23);
            this.TabPageSerial_Btn_SerialUpdate.TabIndex = 16;
            this.TabPageSerial_Btn_SerialUpdate.Text = "刷新串口";
            this.TabPageSerial_Btn_SerialUpdate.UseVisualStyleBackColor = true;
            this.TabPageSerial_Btn_SerialUpdate.Click += new System.EventHandler(this.TabPageSerial_Btn_SerialUpdate_Click);
            // 
            // TabPageSerial_Cbx_SerialCheckBit
            // 
            this.TabPageSerial_Cbx_SerialCheckBit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Cbx_SerialCheckBit.FormattingEnabled = true;
            this.TabPageSerial_Cbx_SerialCheckBit.Location = new System.Drawing.Point(59, 125);
            this.TabPageSerial_Cbx_SerialCheckBit.Name = "TabPageSerial_Cbx_SerialCheckBit";
            this.TabPageSerial_Cbx_SerialCheckBit.Size = new System.Drawing.Size(85, 23);
            this.TabPageSerial_Cbx_SerialCheckBit.TabIndex = 15;
            // 
            // TabPageSerial_Lab_SerialCheckBit
            // 
            this.TabPageSerial_Lab_SerialCheckBit.AutoSize = true;
            this.TabPageSerial_Lab_SerialCheckBit.Location = new System.Drawing.Point(6, 129);
            this.TabPageSerial_Lab_SerialCheckBit.Name = "TabPageSerial_Lab_SerialCheckBit";
            this.TabPageSerial_Lab_SerialCheckBit.Size = new System.Drawing.Size(47, 12);
            this.TabPageSerial_Lab_SerialCheckBit.TabIndex = 14;
            this.TabPageSerial_Lab_SerialCheckBit.Text = "校验位:";
            // 
            // TabPageSerial_Cbx_SerialStopBit
            // 
            this.TabPageSerial_Cbx_SerialStopBit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Cbx_SerialStopBit.FormattingEnabled = true;
            this.TabPageSerial_Cbx_SerialStopBit.Location = new System.Drawing.Point(59, 97);
            this.TabPageSerial_Cbx_SerialStopBit.Name = "TabPageSerial_Cbx_SerialStopBit";
            this.TabPageSerial_Cbx_SerialStopBit.Size = new System.Drawing.Size(85, 23);
            this.TabPageSerial_Cbx_SerialStopBit.TabIndex = 13;
            // 
            // TabPageSerial_Lab_SerialStopBit
            // 
            this.TabPageSerial_Lab_SerialStopBit.AutoSize = true;
            this.TabPageSerial_Lab_SerialStopBit.Location = new System.Drawing.Point(6, 101);
            this.TabPageSerial_Lab_SerialStopBit.Name = "TabPageSerial_Lab_SerialStopBit";
            this.TabPageSerial_Lab_SerialStopBit.Size = new System.Drawing.Size(47, 12);
            this.TabPageSerial_Lab_SerialStopBit.TabIndex = 12;
            this.TabPageSerial_Lab_SerialStopBit.Text = "停止位:";
            // 
            // TabPageSerial_Cbx_SerialDateBit
            // 
            this.TabPageSerial_Cbx_SerialDateBit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Cbx_SerialDateBit.FormattingEnabled = true;
            this.TabPageSerial_Cbx_SerialDateBit.Location = new System.Drawing.Point(59, 69);
            this.TabPageSerial_Cbx_SerialDateBit.Name = "TabPageSerial_Cbx_SerialDateBit";
            this.TabPageSerial_Cbx_SerialDateBit.Size = new System.Drawing.Size(85, 23);
            this.TabPageSerial_Cbx_SerialDateBit.TabIndex = 11;
            // 
            // TabPageSerial_Lab_SerialDateBit
            // 
            this.TabPageSerial_Lab_SerialDateBit.AutoSize = true;
            this.TabPageSerial_Lab_SerialDateBit.Location = new System.Drawing.Point(6, 73);
            this.TabPageSerial_Lab_SerialDateBit.Name = "TabPageSerial_Lab_SerialDateBit";
            this.TabPageSerial_Lab_SerialDateBit.Size = new System.Drawing.Size(47, 12);
            this.TabPageSerial_Lab_SerialDateBit.TabIndex = 10;
            this.TabPageSerial_Lab_SerialDateBit.Text = "数据位:";
            // 
            // TabPageSerial_Cbx_SerialBaud
            // 
            this.TabPageSerial_Cbx_SerialBaud.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Cbx_SerialBaud.FormattingEnabled = true;
            this.TabPageSerial_Cbx_SerialBaud.Location = new System.Drawing.Point(59, 41);
            this.TabPageSerial_Cbx_SerialBaud.Name = "TabPageSerial_Cbx_SerialBaud";
            this.TabPageSerial_Cbx_SerialBaud.Size = new System.Drawing.Size(85, 23);
            this.TabPageSerial_Cbx_SerialBaud.TabIndex = 9;
            // 
            // TabPageSerial_Lab_SerialBaud
            // 
            this.TabPageSerial_Lab_SerialBaud.AutoSize = true;
            this.TabPageSerial_Lab_SerialBaud.Location = new System.Drawing.Point(6, 45);
            this.TabPageSerial_Lab_SerialBaud.Name = "TabPageSerial_Lab_SerialBaud";
            this.TabPageSerial_Lab_SerialBaud.Size = new System.Drawing.Size(47, 12);
            this.TabPageSerial_Lab_SerialBaud.TabIndex = 8;
            this.TabPageSerial_Lab_SerialBaud.Text = "波特率:";
            // 
            // TabPageSerial_Cbx_SerialName
            // 
            this.TabPageSerial_Cbx_SerialName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSerial_Cbx_SerialName.FormattingEnabled = true;
            this.TabPageSerial_Cbx_SerialName.Location = new System.Drawing.Point(59, 13);
            this.TabPageSerial_Cbx_SerialName.Name = "TabPageSerial_Cbx_SerialName";
            this.TabPageSerial_Cbx_SerialName.Size = new System.Drawing.Size(85, 23);
            this.TabPageSerial_Cbx_SerialName.TabIndex = 7;
            // 
            // TabPageSerial_Lab_SerialName
            // 
            this.TabPageSerial_Lab_SerialName.AutoSize = true;
            this.TabPageSerial_Lab_SerialName.Location = new System.Drawing.Point(6, 17);
            this.TabPageSerial_Lab_SerialName.Name = "TabPageSerial_Lab_SerialName";
            this.TabPageSerial_Lab_SerialName.Size = new System.Drawing.Size(47, 12);
            this.TabPageSerial_Lab_SerialName.TabIndex = 0;
            this.TabPageSerial_Lab_SerialName.Text = "串口号:";
            // 
            // TabPageNet
            // 
            this.TabPageNet.Controls.Add(this.TabNet);
            this.TabPageNet.Location = new System.Drawing.Point(4, 22);
            this.TabPageNet.Name = "TabPageNet";
            this.TabPageNet.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNet.Size = new System.Drawing.Size(912, 631);
            this.TabPageNet.TabIndex = 1;
            this.TabPageNet.Text = "网络调试";
            this.TabPageNet.UseVisualStyleBackColor = true;
            // 
            // TabNet
            // 
            this.TabNet.Controls.Add(this.TabPageTCPServer);
            this.TabNet.Controls.Add(this.TabPageTCPClient);
            this.TabNet.Controls.Add(this.TabPageUDP);
            this.TabNet.Location = new System.Drawing.Point(6, 6);
            this.TabNet.Name = "TabNet";
            this.TabNet.SelectedIndex = 0;
            this.TabNet.Size = new System.Drawing.Size(900, 619);
            this.TabNet.TabIndex = 0;
            // 
            // TabPageTCPServer
            // 
            this.TabPageTCPServer.Controls.Add(this.TabPageTCPServer_Gbx_Send);
            this.TabPageTCPServer.Controls.Add(this.TabPageTCPServer_Gbx_Recv);
            this.TabPageTCPServer.Controls.Add(this.TabPageTCPServer_Gbx_NetFunction);
            this.TabPageTCPServer.Controls.Add(this.TabPageTCPServer_Gbx_NetConfig);
            this.TabPageTCPServer.Location = new System.Drawing.Point(4, 22);
            this.TabPageTCPServer.Name = "TabPageTCPServer";
            this.TabPageTCPServer.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTCPServer.Size = new System.Drawing.Size(892, 593);
            this.TabPageTCPServer.TabIndex = 0;
            this.TabPageTCPServer.Text = "TCP服务端";
            this.TabPageTCPServer.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPServer_Gbx_Send
            // 
            this.TabPageTCPServer_Gbx_Send.Controls.Add(this.TabPageTCPServer_Lab_ConnectObject);
            this.TabPageTCPServer_Gbx_Send.Controls.Add(this.TabPageTCPServer_Btn_Send);
            this.TabPageTCPServer_Gbx_Send.Controls.Add(this.TabPageTCPServer_Cbx_ConnectObject);
            this.TabPageTCPServer_Gbx_Send.Controls.Add(this.TabPageTCPServer_Tbx_Send);
            this.TabPageTCPServer_Gbx_Send.Location = new System.Drawing.Point(162, 302);
            this.TabPageTCPServer_Gbx_Send.Name = "TabPageTCPServer_Gbx_Send";
            this.TabPageTCPServer_Gbx_Send.Size = new System.Drawing.Size(724, 285);
            this.TabPageTCPServer_Gbx_Send.TabIndex = 6;
            this.TabPageTCPServer_Gbx_Send.TabStop = false;
            this.TabPageTCPServer_Gbx_Send.Text = "发送区";
            // 
            // TabPageTCPServer_Lab_ConnectObject
            // 
            this.TabPageTCPServer_Lab_ConnectObject.AutoSize = true;
            this.TabPageTCPServer_Lab_ConnectObject.Location = new System.Drawing.Point(6, 261);
            this.TabPageTCPServer_Lab_ConnectObject.Name = "TabPageTCPServer_Lab_ConnectObject";
            this.TabPageTCPServer_Lab_ConnectObject.Size = new System.Drawing.Size(59, 12);
            this.TabPageTCPServer_Lab_ConnectObject.TabIndex = 3;
            this.TabPageTCPServer_Lab_ConnectObject.Text = "连接对象:";
            // 
            // TabPageTCPServer_Btn_Send
            // 
            this.TabPageTCPServer_Btn_Send.Enabled = false;
            this.TabPageTCPServer_Btn_Send.Location = new System.Drawing.Point(612, 256);
            this.TabPageTCPServer_Btn_Send.Name = "TabPageTCPServer_Btn_Send";
            this.TabPageTCPServer_Btn_Send.Size = new System.Drawing.Size(106, 23);
            this.TabPageTCPServer_Btn_Send.TabIndex = 2;
            this.TabPageTCPServer_Btn_Send.Text = "发送";
            this.TabPageTCPServer_Btn_Send.UseVisualStyleBackColor = true;
            this.TabPageTCPServer_Btn_Send.Click += new System.EventHandler(this.TabPageTCPServer_Btn_Send_Click);
            // 
            // TabPageTCPServer_Cbx_ConnectObject
            // 
            this.TabPageTCPServer_Cbx_ConnectObject.FormattingEnabled = true;
            this.TabPageTCPServer_Cbx_ConnectObject.Location = new System.Drawing.Point(71, 258);
            this.TabPageTCPServer_Cbx_ConnectObject.Name = "TabPageTCPServer_Cbx_ConnectObject";
            this.TabPageTCPServer_Cbx_ConnectObject.Size = new System.Drawing.Size(240, 20);
            this.TabPageTCPServer_Cbx_ConnectObject.TabIndex = 4;
            // 
            // TabPageTCPServer_Tbx_Send
            // 
            this.TabPageTCPServer_Tbx_Send.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageTCPServer_Tbx_Send.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPServer_Tbx_Send.Multiline = true;
            this.TabPageTCPServer_Tbx_Send.Name = "TabPageTCPServer_Tbx_Send";
            this.TabPageTCPServer_Tbx_Send.Size = new System.Drawing.Size(712, 230);
            this.TabPageTCPServer_Tbx_Send.TabIndex = 1;
            this.TabPageTCPServer_Tbx_Send.TextChanged += new System.EventHandler(this.TabPageTCPServer_Tbx_Send_TextChanged);
            // 
            // TabPageTCPServer_Gbx_Recv
            // 
            this.TabPageTCPServer_Gbx_Recv.Controls.Add(this.TabPageTCPServer_Tbx_Recv);
            this.TabPageTCPServer_Gbx_Recv.Location = new System.Drawing.Point(162, 6);
            this.TabPageTCPServer_Gbx_Recv.Name = "TabPageTCPServer_Gbx_Recv";
            this.TabPageTCPServer_Gbx_Recv.Size = new System.Drawing.Size(724, 290);
            this.TabPageTCPServer_Gbx_Recv.TabIndex = 5;
            this.TabPageTCPServer_Gbx_Recv.TabStop = false;
            this.TabPageTCPServer_Gbx_Recv.Text = "消息区";
            // 
            // TabPageTCPServer_Tbx_Recv
            // 
            this.TabPageTCPServer_Tbx_Recv.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageTCPServer_Tbx_Recv.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPServer_Tbx_Recv.Multiline = true;
            this.TabPageTCPServer_Tbx_Recv.Name = "TabPageTCPServer_Tbx_Recv";
            this.TabPageTCPServer_Tbx_Recv.Size = new System.Drawing.Size(712, 264);
            this.TabPageTCPServer_Tbx_Recv.TabIndex = 1;
            this.TabPageTCPServer_Tbx_Recv.TextChanged += new System.EventHandler(this.TabPageTCPServer_Tbx_Recv_TextChanged);
            // 
            // TabPageTCPServer_Gbx_NetFunction
            // 
            this.TabPageTCPServer_Gbx_NetFunction.Controls.Add(this.TabPageTCPServer_Gbx_NetFunc);
            this.TabPageTCPServer_Gbx_NetFunction.Controls.Add(this.TabPageTCPServer_Gbx_NetSend);
            this.TabPageTCPServer_Gbx_NetFunction.Controls.Add(this.TabPageTCPServer_Gbx_NetRecv);
            this.TabPageTCPServer_Gbx_NetFunction.Location = new System.Drawing.Point(6, 212);
            this.TabPageTCPServer_Gbx_NetFunction.Name = "TabPageTCPServer_Gbx_NetFunction";
            this.TabPageTCPServer_Gbx_NetFunction.Size = new System.Drawing.Size(150, 240);
            this.TabPageTCPServer_Gbx_NetFunction.TabIndex = 3;
            this.TabPageTCPServer_Gbx_NetFunction.TabStop = false;
            this.TabPageTCPServer_Gbx_NetFunction.Text = "网络辅助";
            // 
            // TabPageTCPServer_Gbx_NetFunc
            // 
            this.TabPageTCPServer_Gbx_NetFunc.Controls.Add(this.TabPageTCPServer_Btn_NetSendClear);
            this.TabPageTCPServer_Gbx_NetFunc.Controls.Add(this.TabPageTCPServer_Btn_NetRecvClear);
            this.TabPageTCPServer_Gbx_NetFunc.Location = new System.Drawing.Point(6, 160);
            this.TabPageTCPServer_Gbx_NetFunc.Name = "TabPageTCPServer_Gbx_NetFunc";
            this.TabPageTCPServer_Gbx_NetFunc.Size = new System.Drawing.Size(138, 74);
            this.TabPageTCPServer_Gbx_NetFunc.TabIndex = 1;
            this.TabPageTCPServer_Gbx_NetFunc.TabStop = false;
            this.TabPageTCPServer_Gbx_NetFunc.Text = "功能";
            // 
            // TabPageTCPServer_Btn_NetSendClear
            // 
            this.TabPageTCPServer_Btn_NetSendClear.Location = new System.Drawing.Point(6, 45);
            this.TabPageTCPServer_Btn_NetSendClear.Name = "TabPageTCPServer_Btn_NetSendClear";
            this.TabPageTCPServer_Btn_NetSendClear.Size = new System.Drawing.Size(126, 23);
            this.TabPageTCPServer_Btn_NetSendClear.TabIndex = 2;
            this.TabPageTCPServer_Btn_NetSendClear.Text = "清发送区";
            this.TabPageTCPServer_Btn_NetSendClear.UseVisualStyleBackColor = true;
            this.TabPageTCPServer_Btn_NetSendClear.Click += new System.EventHandler(this.TabPageTCPServer_Btn_NetSendClear_Click);
            // 
            // TabPageTCPServer_Btn_NetRecvClear
            // 
            this.TabPageTCPServer_Btn_NetRecvClear.Location = new System.Drawing.Point(6, 16);
            this.TabPageTCPServer_Btn_NetRecvClear.Name = "TabPageTCPServer_Btn_NetRecvClear";
            this.TabPageTCPServer_Btn_NetRecvClear.Size = new System.Drawing.Size(126, 23);
            this.TabPageTCPServer_Btn_NetRecvClear.TabIndex = 1;
            this.TabPageTCPServer_Btn_NetRecvClear.Text = "清消息区";
            this.TabPageTCPServer_Btn_NetRecvClear.UseVisualStyleBackColor = true;
            this.TabPageTCPServer_Btn_NetRecvClear.Click += new System.EventHandler(this.TabPageTCPServer_Btn_NetRecvClear_Click);
            // 
            // TabPageTCPServer_Gbx_NetSend
            // 
            this.TabPageTCPServer_Gbx_NetSend.Controls.Add(this.TabPageTCPServer_Rad_NetSendHex);
            this.TabPageTCPServer_Gbx_NetSend.Controls.Add(this.TabPageTCPServer_Rad_NetSendString);
            this.TabPageTCPServer_Gbx_NetSend.Location = new System.Drawing.Point(6, 90);
            this.TabPageTCPServer_Gbx_NetSend.Name = "TabPageTCPServer_Gbx_NetSend";
            this.TabPageTCPServer_Gbx_NetSend.Size = new System.Drawing.Size(138, 64);
            this.TabPageTCPServer_Gbx_NetSend.TabIndex = 1;
            this.TabPageTCPServer_Gbx_NetSend.TabStop = false;
            this.TabPageTCPServer_Gbx_NetSend.Text = "发码区";
            // 
            // TabPageTCPServer_Rad_NetSendHex
            // 
            this.TabPageTCPServer_Rad_NetSendHex.AutoSize = true;
            this.TabPageTCPServer_Rad_NetSendHex.Location = new System.Drawing.Point(6, 42);
            this.TabPageTCPServer_Rad_NetSendHex.Name = "TabPageTCPServer_Rad_NetSendHex";
            this.TabPageTCPServer_Rad_NetSendHex.Size = new System.Drawing.Size(95, 16);
            this.TabPageTCPServer_Rad_NetSendHex.TabIndex = 2;
            this.TabPageTCPServer_Rad_NetSendHex.TabStop = true;
            this.TabPageTCPServer_Rad_NetSendHex.Text = "十六进制发送";
            this.TabPageTCPServer_Rad_NetSendHex.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPServer_Rad_NetSendString
            // 
            this.TabPageTCPServer_Rad_NetSendString.AutoSize = true;
            this.TabPageTCPServer_Rad_NetSendString.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPServer_Rad_NetSendString.Name = "TabPageTCPServer_Rad_NetSendString";
            this.TabPageTCPServer_Rad_NetSendString.Size = new System.Drawing.Size(83, 16);
            this.TabPageTCPServer_Rad_NetSendString.TabIndex = 1;
            this.TabPageTCPServer_Rad_NetSendString.TabStop = true;
            this.TabPageTCPServer_Rad_NetSendString.Text = "字符串发送";
            this.TabPageTCPServer_Rad_NetSendString.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPServer_Gbx_NetRecv
            // 
            this.TabPageTCPServer_Gbx_NetRecv.Controls.Add(this.TabPageTCPServer_Rad_NetRecvHex);
            this.TabPageTCPServer_Gbx_NetRecv.Controls.Add(this.TabPageTCPServer_Rad_NetRecvString);
            this.TabPageTCPServer_Gbx_NetRecv.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPServer_Gbx_NetRecv.Name = "TabPageTCPServer_Gbx_NetRecv";
            this.TabPageTCPServer_Gbx_NetRecv.Size = new System.Drawing.Size(138, 64);
            this.TabPageTCPServer_Gbx_NetRecv.TabIndex = 1;
            this.TabPageTCPServer_Gbx_NetRecv.TabStop = false;
            this.TabPageTCPServer_Gbx_NetRecv.Text = "消息区";
            // 
            // TabPageTCPServer_Rad_NetRecvHex
            // 
            this.TabPageTCPServer_Rad_NetRecvHex.AutoSize = true;
            this.TabPageTCPServer_Rad_NetRecvHex.Location = new System.Drawing.Point(6, 42);
            this.TabPageTCPServer_Rad_NetRecvHex.Name = "TabPageTCPServer_Rad_NetRecvHex";
            this.TabPageTCPServer_Rad_NetRecvHex.Size = new System.Drawing.Size(95, 16);
            this.TabPageTCPServer_Rad_NetRecvHex.TabIndex = 1;
            this.TabPageTCPServer_Rad_NetRecvHex.TabStop = true;
            this.TabPageTCPServer_Rad_NetRecvHex.Text = "十六进制显示";
            this.TabPageTCPServer_Rad_NetRecvHex.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPServer_Rad_NetRecvString
            // 
            this.TabPageTCPServer_Rad_NetRecvString.AutoSize = true;
            this.TabPageTCPServer_Rad_NetRecvString.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPServer_Rad_NetRecvString.Name = "TabPageTCPServer_Rad_NetRecvString";
            this.TabPageTCPServer_Rad_NetRecvString.Size = new System.Drawing.Size(83, 16);
            this.TabPageTCPServer_Rad_NetRecvString.TabIndex = 0;
            this.TabPageTCPServer_Rad_NetRecvString.TabStop = true;
            this.TabPageTCPServer_Rad_NetRecvString.Text = "字符串显示";
            this.TabPageTCPServer_Rad_NetRecvString.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPServer_Gbx_NetConfig
            // 
            this.TabPageTCPServer_Gbx_NetConfig.Controls.Add(this.TabPageTCPServer_Btn_NetListen);
            this.TabPageTCPServer_Gbx_NetConfig.Controls.Add(this.TabPageTCPServer_Tbx_NetServerMaxListen);
            this.TabPageTCPServer_Gbx_NetConfig.Controls.Add(this.TabPageTCPServer_Lab_NetServerMaxListen);
            this.TabPageTCPServer_Gbx_NetConfig.Controls.Add(this.TabPageTCPServer_Tbx_NetLocalHostPort);
            this.TabPageTCPServer_Gbx_NetConfig.Controls.Add(this.TabPageTCPServer_Lab_NetLocalHostPort);
            this.TabPageTCPServer_Gbx_NetConfig.Controls.Add(this.TabPageTCPServer_Tbx_NetLocalHostIP);
            this.TabPageTCPServer_Gbx_NetConfig.Controls.Add(this.TabPageTCPServer_Lab_NetLocalHostIP);
            this.TabPageTCPServer_Gbx_NetConfig.Location = new System.Drawing.Point(6, 6);
            this.TabPageTCPServer_Gbx_NetConfig.Name = "TabPageTCPServer_Gbx_NetConfig";
            this.TabPageTCPServer_Gbx_NetConfig.Size = new System.Drawing.Size(150, 200);
            this.TabPageTCPServer_Gbx_NetConfig.TabIndex = 0;
            this.TabPageTCPServer_Gbx_NetConfig.TabStop = false;
            this.TabPageTCPServer_Gbx_NetConfig.Text = "网络配置";
            // 
            // TabPageTCPServer_Btn_NetListen
            // 
            this.TabPageTCPServer_Btn_NetListen.Location = new System.Drawing.Point(6, 171);
            this.TabPageTCPServer_Btn_NetListen.Name = "TabPageTCPServer_Btn_NetListen";
            this.TabPageTCPServer_Btn_NetListen.Size = new System.Drawing.Size(138, 23);
            this.TabPageTCPServer_Btn_NetListen.TabIndex = 1;
            this.TabPageTCPServer_Btn_NetListen.Text = "监听";
            this.TabPageTCPServer_Btn_NetListen.UseVisualStyleBackColor = true;
            this.TabPageTCPServer_Btn_NetListen.Click += new System.EventHandler(this.TabPageTCPServer_Btn_NetListen_Click);
            // 
            // TabPageTCPServer_Tbx_NetServerMaxListen
            // 
            this.TabPageTCPServer_Tbx_NetServerMaxListen.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TabPageTCPServer_Tbx_NetServerMaxListen.Location = new System.Drawing.Point(6, 132);
            this.TabPageTCPServer_Tbx_NetServerMaxListen.Name = "TabPageTCPServer_Tbx_NetServerMaxListen";
            this.TabPageTCPServer_Tbx_NetServerMaxListen.Size = new System.Drawing.Size(71, 23);
            this.TabPageTCPServer_Tbx_NetServerMaxListen.TabIndex = 6;
            this.TabPageTCPServer_Tbx_NetServerMaxListen.TextChanged += new System.EventHandler(this.TabPageTCPServer_Tbx_NetServerMaxListen_TextChanged);
            this.TabPageTCPServer_Tbx_NetServerMaxListen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabPageTCPServer_Tbx_NetServerMaxListen_KeyPress);
            // 
            // TabPageTCPServer_Lab_NetServerMaxListen
            // 
            this.TabPageTCPServer_Lab_NetServerMaxListen.AutoSize = true;
            this.TabPageTCPServer_Lab_NetServerMaxListen.Location = new System.Drawing.Point(6, 117);
            this.TabPageTCPServer_Lab_NetServerMaxListen.Name = "TabPageTCPServer_Lab_NetServerMaxListen";
            this.TabPageTCPServer_Lab_NetServerMaxListen.Size = new System.Drawing.Size(71, 12);
            this.TabPageTCPServer_Lab_NetServerMaxListen.TabIndex = 5;
            this.TabPageTCPServer_Lab_NetServerMaxListen.Text = "最大连接数:";
            // 
            // TabPageTCPServer_Tbx_NetLocalHostPort
            // 
            this.TabPageTCPServer_Tbx_NetLocalHostPort.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TabPageTCPServer_Tbx_NetLocalHostPort.Location = new System.Drawing.Point(6, 81);
            this.TabPageTCPServer_Tbx_NetLocalHostPort.Name = "TabPageTCPServer_Tbx_NetLocalHostPort";
            this.TabPageTCPServer_Tbx_NetLocalHostPort.Size = new System.Drawing.Size(71, 23);
            this.TabPageTCPServer_Tbx_NetLocalHostPort.TabIndex = 4;
            this.TabPageTCPServer_Tbx_NetLocalHostPort.TextChanged += new System.EventHandler(this.TabPageTCPServer_Tbx_NetLocalHostPort_TextChanged);
            this.TabPageTCPServer_Tbx_NetLocalHostPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabPageTCPServer_Tbx_NetLocalHostPort_KeyPress);
            // 
            // TabPageTCPServer_Lab_NetLocalHostPort
            // 
            this.TabPageTCPServer_Lab_NetLocalHostPort.AutoSize = true;
            this.TabPageTCPServer_Lab_NetLocalHostPort.Location = new System.Drawing.Point(6, 66);
            this.TabPageTCPServer_Lab_NetLocalHostPort.Name = "TabPageTCPServer_Lab_NetLocalHostPort";
            this.TabPageTCPServer_Lab_NetLocalHostPort.Size = new System.Drawing.Size(47, 12);
            this.TabPageTCPServer_Lab_NetLocalHostPort.TabIndex = 3;
            this.TabPageTCPServer_Lab_NetLocalHostPort.Text = "端口号:";
            // 
            // TabPageTCPServer_Tbx_NetLocalHostIP
            // 
            this.TabPageTCPServer_Tbx_NetLocalHostIP.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TabPageTCPServer_Tbx_NetLocalHostIP.Location = new System.Drawing.Point(6, 32);
            this.TabPageTCPServer_Tbx_NetLocalHostIP.Name = "TabPageTCPServer_Tbx_NetLocalHostIP";
            this.TabPageTCPServer_Tbx_NetLocalHostIP.Size = new System.Drawing.Size(138, 23);
            this.TabPageTCPServer_Tbx_NetLocalHostIP.TabIndex = 2;
            // 
            // TabPageTCPServer_Lab_NetLocalHostIP
            // 
            this.TabPageTCPServer_Lab_NetLocalHostIP.AutoSize = true;
            this.TabPageTCPServer_Lab_NetLocalHostIP.Location = new System.Drawing.Point(6, 17);
            this.TabPageTCPServer_Lab_NetLocalHostIP.Name = "TabPageTCPServer_Lab_NetLocalHostIP";
            this.TabPageTCPServer_Lab_NetLocalHostIP.Size = new System.Drawing.Size(71, 12);
            this.TabPageTCPServer_Lab_NetLocalHostIP.TabIndex = 1;
            this.TabPageTCPServer_Lab_NetLocalHostIP.Text = "本机IP地址:";
            // 
            // TabPageTCPClient
            // 
            this.TabPageTCPClient.Controls.Add(this.TabPageTCPClient_Gbx_Send);
            this.TabPageTCPClient.Controls.Add(this.TabPageTCPClient_Gbx_Recv);
            this.TabPageTCPClient.Controls.Add(this.TabPageTCPClient_Gbx_NetFunction);
            this.TabPageTCPClient.Controls.Add(this.TabPageTCPClient_Gbx_NetConfig);
            this.TabPageTCPClient.Location = new System.Drawing.Point(4, 22);
            this.TabPageTCPClient.Name = "TabPageTCPClient";
            this.TabPageTCPClient.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTCPClient.Size = new System.Drawing.Size(892, 593);
            this.TabPageTCPClient.TabIndex = 1;
            this.TabPageTCPClient.Text = "TCP客户端";
            this.TabPageTCPClient.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Gbx_Send
            // 
            this.TabPageTCPClient_Gbx_Send.Controls.Add(this.TabPageTCPClient_Btn_Send);
            this.TabPageTCPClient_Gbx_Send.Controls.Add(this.TabPageTCPClient_Tbx_Send);
            this.TabPageTCPClient_Gbx_Send.Location = new System.Drawing.Point(162, 302);
            this.TabPageTCPClient_Gbx_Send.Name = "TabPageTCPClient_Gbx_Send";
            this.TabPageTCPClient_Gbx_Send.Size = new System.Drawing.Size(724, 285);
            this.TabPageTCPClient_Gbx_Send.TabIndex = 7;
            this.TabPageTCPClient_Gbx_Send.TabStop = false;
            this.TabPageTCPClient_Gbx_Send.Text = "发送区";
            // 
            // TabPageTCPClient_Btn_Send
            // 
            this.TabPageTCPClient_Btn_Send.Enabled = false;
            this.TabPageTCPClient_Btn_Send.Location = new System.Drawing.Point(612, 256);
            this.TabPageTCPClient_Btn_Send.Name = "TabPageTCPClient_Btn_Send";
            this.TabPageTCPClient_Btn_Send.Size = new System.Drawing.Size(106, 23);
            this.TabPageTCPClient_Btn_Send.TabIndex = 2;
            this.TabPageTCPClient_Btn_Send.Text = "发送";
            this.TabPageTCPClient_Btn_Send.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Tbx_Send
            // 
            this.TabPageTCPClient_Tbx_Send.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageTCPClient_Tbx_Send.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPClient_Tbx_Send.Multiline = true;
            this.TabPageTCPClient_Tbx_Send.Name = "TabPageTCPClient_Tbx_Send";
            this.TabPageTCPClient_Tbx_Send.Size = new System.Drawing.Size(712, 230);
            this.TabPageTCPClient_Tbx_Send.TabIndex = 1;
            // 
            // TabPageTCPClient_Gbx_Recv
            // 
            this.TabPageTCPClient_Gbx_Recv.Controls.Add(this.TabPageTCPClient_Tbx_Recv);
            this.TabPageTCPClient_Gbx_Recv.Location = new System.Drawing.Point(162, 6);
            this.TabPageTCPClient_Gbx_Recv.Name = "TabPageTCPClient_Gbx_Recv";
            this.TabPageTCPClient_Gbx_Recv.Size = new System.Drawing.Size(724, 290);
            this.TabPageTCPClient_Gbx_Recv.TabIndex = 6;
            this.TabPageTCPClient_Gbx_Recv.TabStop = false;
            this.TabPageTCPClient_Gbx_Recv.Text = "消息区";
            // 
            // TabPageTCPClient_Tbx_Recv
            // 
            this.TabPageTCPClient_Tbx_Recv.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageTCPClient_Tbx_Recv.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPClient_Tbx_Recv.Multiline = true;
            this.TabPageTCPClient_Tbx_Recv.Name = "TabPageTCPClient_Tbx_Recv";
            this.TabPageTCPClient_Tbx_Recv.Size = new System.Drawing.Size(712, 264);
            this.TabPageTCPClient_Tbx_Recv.TabIndex = 1;
            // 
            // TabPageTCPClient_Gbx_NetFunction
            // 
            this.TabPageTCPClient_Gbx_NetFunction.Controls.Add(this.TabPageTCPClient_Gbx_NetFunc);
            this.TabPageTCPClient_Gbx_NetFunction.Controls.Add(this.TabPageTCPClient_Gbx_NetSend);
            this.TabPageTCPClient_Gbx_NetFunction.Controls.Add(this.TabPageTCPClient_Gbx_NetRecv);
            this.TabPageTCPClient_Gbx_NetFunction.Location = new System.Drawing.Point(6, 159);
            this.TabPageTCPClient_Gbx_NetFunction.Name = "TabPageTCPClient_Gbx_NetFunction";
            this.TabPageTCPClient_Gbx_NetFunction.Size = new System.Drawing.Size(150, 240);
            this.TabPageTCPClient_Gbx_NetFunction.TabIndex = 4;
            this.TabPageTCPClient_Gbx_NetFunction.TabStop = false;
            this.TabPageTCPClient_Gbx_NetFunction.Text = "网络辅助";
            // 
            // TabPageTCPClient_Gbx_NetFunc
            // 
            this.TabPageTCPClient_Gbx_NetFunc.Controls.Add(this.TabPageTCPClient_Btn_NetSendClear);
            this.TabPageTCPClient_Gbx_NetFunc.Controls.Add(this.TabPageTCPClient_Btn_NetRecvClear);
            this.TabPageTCPClient_Gbx_NetFunc.Location = new System.Drawing.Point(6, 160);
            this.TabPageTCPClient_Gbx_NetFunc.Name = "TabPageTCPClient_Gbx_NetFunc";
            this.TabPageTCPClient_Gbx_NetFunc.Size = new System.Drawing.Size(138, 74);
            this.TabPageTCPClient_Gbx_NetFunc.TabIndex = 1;
            this.TabPageTCPClient_Gbx_NetFunc.TabStop = false;
            this.TabPageTCPClient_Gbx_NetFunc.Text = "功能";
            // 
            // TabPageTCPClient_Btn_NetSendClear
            // 
            this.TabPageTCPClient_Btn_NetSendClear.Location = new System.Drawing.Point(6, 45);
            this.TabPageTCPClient_Btn_NetSendClear.Name = "TabPageTCPClient_Btn_NetSendClear";
            this.TabPageTCPClient_Btn_NetSendClear.Size = new System.Drawing.Size(126, 23);
            this.TabPageTCPClient_Btn_NetSendClear.TabIndex = 2;
            this.TabPageTCPClient_Btn_NetSendClear.Text = "清发送区";
            this.TabPageTCPClient_Btn_NetSendClear.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Btn_NetRecvClear
            // 
            this.TabPageTCPClient_Btn_NetRecvClear.Location = new System.Drawing.Point(6, 16);
            this.TabPageTCPClient_Btn_NetRecvClear.Name = "TabPageTCPClient_Btn_NetRecvClear";
            this.TabPageTCPClient_Btn_NetRecvClear.Size = new System.Drawing.Size(126, 23);
            this.TabPageTCPClient_Btn_NetRecvClear.TabIndex = 1;
            this.TabPageTCPClient_Btn_NetRecvClear.Text = "清消息区";
            this.TabPageTCPClient_Btn_NetRecvClear.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Gbx_NetSend
            // 
            this.TabPageTCPClient_Gbx_NetSend.Controls.Add(this.TabPageTCPClient_Rad_NetSendHex);
            this.TabPageTCPClient_Gbx_NetSend.Controls.Add(this.TabPageTCPClient_Rad_NetSendString);
            this.TabPageTCPClient_Gbx_NetSend.Location = new System.Drawing.Point(6, 90);
            this.TabPageTCPClient_Gbx_NetSend.Name = "TabPageTCPClient_Gbx_NetSend";
            this.TabPageTCPClient_Gbx_NetSend.Size = new System.Drawing.Size(138, 64);
            this.TabPageTCPClient_Gbx_NetSend.TabIndex = 1;
            this.TabPageTCPClient_Gbx_NetSend.TabStop = false;
            this.TabPageTCPClient_Gbx_NetSend.Text = "发码区";
            // 
            // TabPageTCPClient_Rad_NetSendHex
            // 
            this.TabPageTCPClient_Rad_NetSendHex.AutoSize = true;
            this.TabPageTCPClient_Rad_NetSendHex.Location = new System.Drawing.Point(6, 42);
            this.TabPageTCPClient_Rad_NetSendHex.Name = "TabPageTCPClient_Rad_NetSendHex";
            this.TabPageTCPClient_Rad_NetSendHex.Size = new System.Drawing.Size(95, 16);
            this.TabPageTCPClient_Rad_NetSendHex.TabIndex = 2;
            this.TabPageTCPClient_Rad_NetSendHex.TabStop = true;
            this.TabPageTCPClient_Rad_NetSendHex.Text = "十六进制发送";
            this.TabPageTCPClient_Rad_NetSendHex.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Rad_NetSendString
            // 
            this.TabPageTCPClient_Rad_NetSendString.AutoSize = true;
            this.TabPageTCPClient_Rad_NetSendString.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPClient_Rad_NetSendString.Name = "TabPageTCPClient_Rad_NetSendString";
            this.TabPageTCPClient_Rad_NetSendString.Size = new System.Drawing.Size(83, 16);
            this.TabPageTCPClient_Rad_NetSendString.TabIndex = 1;
            this.TabPageTCPClient_Rad_NetSendString.TabStop = true;
            this.TabPageTCPClient_Rad_NetSendString.Text = "字符串发送";
            this.TabPageTCPClient_Rad_NetSendString.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Gbx_NetRecv
            // 
            this.TabPageTCPClient_Gbx_NetRecv.Controls.Add(this.TabPageTCPClient_Rad_NetRecvHex);
            this.TabPageTCPClient_Gbx_NetRecv.Controls.Add(this.TabPageTCPClient_Rad_NetRecvString);
            this.TabPageTCPClient_Gbx_NetRecv.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPClient_Gbx_NetRecv.Name = "TabPageTCPClient_Gbx_NetRecv";
            this.TabPageTCPClient_Gbx_NetRecv.Size = new System.Drawing.Size(138, 64);
            this.TabPageTCPClient_Gbx_NetRecv.TabIndex = 1;
            this.TabPageTCPClient_Gbx_NetRecv.TabStop = false;
            this.TabPageTCPClient_Gbx_NetRecv.Text = "消息区";
            // 
            // TabPageTCPClient_Rad_NetRecvHex
            // 
            this.TabPageTCPClient_Rad_NetRecvHex.AutoSize = true;
            this.TabPageTCPClient_Rad_NetRecvHex.Location = new System.Drawing.Point(6, 42);
            this.TabPageTCPClient_Rad_NetRecvHex.Name = "TabPageTCPClient_Rad_NetRecvHex";
            this.TabPageTCPClient_Rad_NetRecvHex.Size = new System.Drawing.Size(95, 16);
            this.TabPageTCPClient_Rad_NetRecvHex.TabIndex = 1;
            this.TabPageTCPClient_Rad_NetRecvHex.TabStop = true;
            this.TabPageTCPClient_Rad_NetRecvHex.Text = "十六进制显示";
            this.TabPageTCPClient_Rad_NetRecvHex.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Rad_NetRecvString
            // 
            this.TabPageTCPClient_Rad_NetRecvString.AutoSize = true;
            this.TabPageTCPClient_Rad_NetRecvString.Location = new System.Drawing.Point(6, 20);
            this.TabPageTCPClient_Rad_NetRecvString.Name = "TabPageTCPClient_Rad_NetRecvString";
            this.TabPageTCPClient_Rad_NetRecvString.Size = new System.Drawing.Size(83, 16);
            this.TabPageTCPClient_Rad_NetRecvString.TabIndex = 0;
            this.TabPageTCPClient_Rad_NetRecvString.TabStop = true;
            this.TabPageTCPClient_Rad_NetRecvString.Text = "字符串显示";
            this.TabPageTCPClient_Rad_NetRecvString.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Gbx_NetConfig
            // 
            this.TabPageTCPClient_Gbx_NetConfig.Controls.Add(this.TabPageTCPServer_Btn_NetConnect);
            this.TabPageTCPClient_Gbx_NetConfig.Controls.Add(this.TabPageTCPClient_Tbx_NetLocalHostPort);
            this.TabPageTCPClient_Gbx_NetConfig.Controls.Add(this.TabPageTCPClient_Lab_NetLocalHostPort);
            this.TabPageTCPClient_Gbx_NetConfig.Controls.Add(this.TabPageTCPClient_Tbx_NetLocalHostIP);
            this.TabPageTCPClient_Gbx_NetConfig.Controls.Add(this.TabPageTCPClient_Lab_NetLocalHostIP);
            this.TabPageTCPClient_Gbx_NetConfig.Location = new System.Drawing.Point(6, 6);
            this.TabPageTCPClient_Gbx_NetConfig.Name = "TabPageTCPClient_Gbx_NetConfig";
            this.TabPageTCPClient_Gbx_NetConfig.Size = new System.Drawing.Size(150, 147);
            this.TabPageTCPClient_Gbx_NetConfig.TabIndex = 1;
            this.TabPageTCPClient_Gbx_NetConfig.TabStop = false;
            this.TabPageTCPClient_Gbx_NetConfig.Text = "网络配置";
            // 
            // TabPageTCPServer_Btn_NetConnect
            // 
            this.TabPageTCPServer_Btn_NetConnect.Location = new System.Drawing.Point(6, 118);
            this.TabPageTCPServer_Btn_NetConnect.Name = "TabPageTCPServer_Btn_NetConnect";
            this.TabPageTCPServer_Btn_NetConnect.Size = new System.Drawing.Size(138, 23);
            this.TabPageTCPServer_Btn_NetConnect.TabIndex = 1;
            this.TabPageTCPServer_Btn_NetConnect.Text = "连接";
            this.TabPageTCPServer_Btn_NetConnect.UseVisualStyleBackColor = true;
            // 
            // TabPageTCPClient_Tbx_NetLocalHostPort
            // 
            this.TabPageTCPClient_Tbx_NetLocalHostPort.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TabPageTCPClient_Tbx_NetLocalHostPort.Location = new System.Drawing.Point(6, 81);
            this.TabPageTCPClient_Tbx_NetLocalHostPort.Name = "TabPageTCPClient_Tbx_NetLocalHostPort";
            this.TabPageTCPClient_Tbx_NetLocalHostPort.Size = new System.Drawing.Size(71, 23);
            this.TabPageTCPClient_Tbx_NetLocalHostPort.TabIndex = 4;
            // 
            // TabPageTCPClient_Lab_NetLocalHostPort
            // 
            this.TabPageTCPClient_Lab_NetLocalHostPort.AutoSize = true;
            this.TabPageTCPClient_Lab_NetLocalHostPort.Location = new System.Drawing.Point(6, 66);
            this.TabPageTCPClient_Lab_NetLocalHostPort.Name = "TabPageTCPClient_Lab_NetLocalHostPort";
            this.TabPageTCPClient_Lab_NetLocalHostPort.Size = new System.Drawing.Size(47, 12);
            this.TabPageTCPClient_Lab_NetLocalHostPort.TabIndex = 3;
            this.TabPageTCPClient_Lab_NetLocalHostPort.Text = "端口号:";
            // 
            // TabPageTCPClient_Tbx_NetLocalHostIP
            // 
            this.TabPageTCPClient_Tbx_NetLocalHostIP.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TabPageTCPClient_Tbx_NetLocalHostIP.Location = new System.Drawing.Point(6, 32);
            this.TabPageTCPClient_Tbx_NetLocalHostIP.Name = "TabPageTCPClient_Tbx_NetLocalHostIP";
            this.TabPageTCPClient_Tbx_NetLocalHostIP.Size = new System.Drawing.Size(138, 23);
            this.TabPageTCPClient_Tbx_NetLocalHostIP.TabIndex = 2;
            // 
            // TabPageTCPClient_Lab_NetLocalHostIP
            // 
            this.TabPageTCPClient_Lab_NetLocalHostIP.AutoSize = true;
            this.TabPageTCPClient_Lab_NetLocalHostIP.Location = new System.Drawing.Point(6, 17);
            this.TabPageTCPClient_Lab_NetLocalHostIP.Name = "TabPageTCPClient_Lab_NetLocalHostIP";
            this.TabPageTCPClient_Lab_NetLocalHostIP.Size = new System.Drawing.Size(83, 12);
            this.TabPageTCPClient_Lab_NetLocalHostIP.TabIndex = 1;
            this.TabPageTCPClient_Lab_NetLocalHostIP.Text = "服务器IP地址:";
            // 
            // TabPageUDP
            // 
            this.TabPageUDP.Controls.Add(this.TabPageUDP_Gbx_Send);
            this.TabPageUDP.Controls.Add(this.TabPageUDP_Gbx_Recv);
            this.TabPageUDP.Controls.Add(this.TabPageUDP_Gbx_NetFunction);
            this.TabPageUDP.Controls.Add(this.TabPageUDP_Gbx_NetConfig);
            this.TabPageUDP.Location = new System.Drawing.Point(4, 22);
            this.TabPageUDP.Name = "TabPageUDP";
            this.TabPageUDP.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageUDP.Size = new System.Drawing.Size(892, 593);
            this.TabPageUDP.TabIndex = 2;
            this.TabPageUDP.Text = "UDP";
            this.TabPageUDP.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Gbx_Send
            // 
            this.TabPageUDP_Gbx_Send.Controls.Add(this.TabPageUDP_Tbx_TargetPort);
            this.TabPageUDP_Gbx_Send.Controls.Add(this.TabPageUDP_Lab_TargetPort);
            this.TabPageUDP_Gbx_Send.Controls.Add(this.TabPageUDP_Tbx_TargetIP);
            this.TabPageUDP_Gbx_Send.Controls.Add(this.TabPageUDP_Lab_TargetIP);
            this.TabPageUDP_Gbx_Send.Controls.Add(this.TabPageUDP_Btn_Send);
            this.TabPageUDP_Gbx_Send.Controls.Add(this.TabPageUDP_Tbx_Send);
            this.TabPageUDP_Gbx_Send.Location = new System.Drawing.Point(162, 302);
            this.TabPageUDP_Gbx_Send.Name = "TabPageUDP_Gbx_Send";
            this.TabPageUDP_Gbx_Send.Size = new System.Drawing.Size(724, 285);
            this.TabPageUDP_Gbx_Send.TabIndex = 8;
            this.TabPageUDP_Gbx_Send.TabStop = false;
            this.TabPageUDP_Gbx_Send.Text = "发送区";
            // 
            // TabPageUDP_Tbx_TargetPort
            // 
            this.TabPageUDP_Tbx_TargetPort.Location = new System.Drawing.Point(292, 258);
            this.TabPageUDP_Tbx_TargetPort.Name = "TabPageUDP_Tbx_TargetPort";
            this.TabPageUDP_Tbx_TargetPort.Size = new System.Drawing.Size(71, 21);
            this.TabPageUDP_Tbx_TargetPort.TabIndex = 5;
            // 
            // TabPageUDP_Lab_TargetPort
            // 
            this.TabPageUDP_Lab_TargetPort.AutoSize = true;
            this.TabPageUDP_Lab_TargetPort.Location = new System.Drawing.Point(239, 261);
            this.TabPageUDP_Lab_TargetPort.Name = "TabPageUDP_Lab_TargetPort";
            this.TabPageUDP_Lab_TargetPort.Size = new System.Drawing.Size(47, 12);
            this.TabPageUDP_Lab_TargetPort.TabIndex = 6;
            this.TabPageUDP_Lab_TargetPort.Text = "端口号:";
            // 
            // TabPageUDP_Tbx_TargetIP
            // 
            this.TabPageUDP_Tbx_TargetIP.Location = new System.Drawing.Point(83, 258);
            this.TabPageUDP_Tbx_TargetIP.Name = "TabPageUDP_Tbx_TargetIP";
            this.TabPageUDP_Tbx_TargetIP.Size = new System.Drawing.Size(138, 21);
            this.TabPageUDP_Tbx_TargetIP.TabIndex = 5;
            // 
            // TabPageUDP_Lab_TargetIP
            // 
            this.TabPageUDP_Lab_TargetIP.AutoSize = true;
            this.TabPageUDP_Lab_TargetIP.Location = new System.Drawing.Point(6, 261);
            this.TabPageUDP_Lab_TargetIP.Name = "TabPageUDP_Lab_TargetIP";
            this.TabPageUDP_Lab_TargetIP.Size = new System.Drawing.Size(71, 12);
            this.TabPageUDP_Lab_TargetIP.TabIndex = 3;
            this.TabPageUDP_Lab_TargetIP.Text = "目标IP地址:";
            // 
            // TabPageUDP_Btn_Send
            // 
            this.TabPageUDP_Btn_Send.Enabled = false;
            this.TabPageUDP_Btn_Send.Location = new System.Drawing.Point(612, 256);
            this.TabPageUDP_Btn_Send.Name = "TabPageUDP_Btn_Send";
            this.TabPageUDP_Btn_Send.Size = new System.Drawing.Size(106, 23);
            this.TabPageUDP_Btn_Send.TabIndex = 2;
            this.TabPageUDP_Btn_Send.Text = "发送";
            this.TabPageUDP_Btn_Send.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Tbx_Send
            // 
            this.TabPageUDP_Tbx_Send.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageUDP_Tbx_Send.Location = new System.Drawing.Point(6, 20);
            this.TabPageUDP_Tbx_Send.Multiline = true;
            this.TabPageUDP_Tbx_Send.Name = "TabPageUDP_Tbx_Send";
            this.TabPageUDP_Tbx_Send.Size = new System.Drawing.Size(712, 230);
            this.TabPageUDP_Tbx_Send.TabIndex = 1;
            // 
            // TabPageUDP_Gbx_Recv
            // 
            this.TabPageUDP_Gbx_Recv.Controls.Add(this.TabPageUDP_Tbx_Recv);
            this.TabPageUDP_Gbx_Recv.Location = new System.Drawing.Point(162, 6);
            this.TabPageUDP_Gbx_Recv.Name = "TabPageUDP_Gbx_Recv";
            this.TabPageUDP_Gbx_Recv.Size = new System.Drawing.Size(724, 290);
            this.TabPageUDP_Gbx_Recv.TabIndex = 7;
            this.TabPageUDP_Gbx_Recv.TabStop = false;
            this.TabPageUDP_Gbx_Recv.Text = "消息区";
            // 
            // TabPageUDP_Tbx_Recv
            // 
            this.TabPageUDP_Tbx_Recv.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageUDP_Tbx_Recv.Location = new System.Drawing.Point(6, 20);
            this.TabPageUDP_Tbx_Recv.Multiline = true;
            this.TabPageUDP_Tbx_Recv.Name = "TabPageUDP_Tbx_Recv";
            this.TabPageUDP_Tbx_Recv.Size = new System.Drawing.Size(712, 264);
            this.TabPageUDP_Tbx_Recv.TabIndex = 1;
            // 
            // TabPageUDP_Gbx_NetFunction
            // 
            this.TabPageUDP_Gbx_NetFunction.Controls.Add(this.TabPageUDP_Gbx_NetFunc);
            this.TabPageUDP_Gbx_NetFunction.Controls.Add(this.TabPageUDP_Gbx_NetSend);
            this.TabPageUDP_Gbx_NetFunction.Controls.Add(this.TabPageUDP_Gbx_NetRecv);
            this.TabPageUDP_Gbx_NetFunction.Location = new System.Drawing.Point(6, 159);
            this.TabPageUDP_Gbx_NetFunction.Name = "TabPageUDP_Gbx_NetFunction";
            this.TabPageUDP_Gbx_NetFunction.Size = new System.Drawing.Size(150, 240);
            this.TabPageUDP_Gbx_NetFunction.TabIndex = 5;
            this.TabPageUDP_Gbx_NetFunction.TabStop = false;
            this.TabPageUDP_Gbx_NetFunction.Text = "网络辅助";
            // 
            // TabPageUDP_Gbx_NetFunc
            // 
            this.TabPageUDP_Gbx_NetFunc.Controls.Add(this.TabPageUDP_Btn_NetSendClear);
            this.TabPageUDP_Gbx_NetFunc.Controls.Add(this.TabPageUDP_Btn_NetRecvClear);
            this.TabPageUDP_Gbx_NetFunc.Location = new System.Drawing.Point(6, 160);
            this.TabPageUDP_Gbx_NetFunc.Name = "TabPageUDP_Gbx_NetFunc";
            this.TabPageUDP_Gbx_NetFunc.Size = new System.Drawing.Size(138, 74);
            this.TabPageUDP_Gbx_NetFunc.TabIndex = 1;
            this.TabPageUDP_Gbx_NetFunc.TabStop = false;
            this.TabPageUDP_Gbx_NetFunc.Text = "功能";
            // 
            // TabPageUDP_Btn_NetSendClear
            // 
            this.TabPageUDP_Btn_NetSendClear.Location = new System.Drawing.Point(6, 45);
            this.TabPageUDP_Btn_NetSendClear.Name = "TabPageUDP_Btn_NetSendClear";
            this.TabPageUDP_Btn_NetSendClear.Size = new System.Drawing.Size(126, 23);
            this.TabPageUDP_Btn_NetSendClear.TabIndex = 2;
            this.TabPageUDP_Btn_NetSendClear.Text = "清发送区";
            this.TabPageUDP_Btn_NetSendClear.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Btn_NetRecvClear
            // 
            this.TabPageUDP_Btn_NetRecvClear.Location = new System.Drawing.Point(6, 16);
            this.TabPageUDP_Btn_NetRecvClear.Name = "TabPageUDP_Btn_NetRecvClear";
            this.TabPageUDP_Btn_NetRecvClear.Size = new System.Drawing.Size(126, 23);
            this.TabPageUDP_Btn_NetRecvClear.TabIndex = 1;
            this.TabPageUDP_Btn_NetRecvClear.Text = "清消息区";
            this.TabPageUDP_Btn_NetRecvClear.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Gbx_NetSend
            // 
            this.TabPageUDP_Gbx_NetSend.Controls.Add(this.TabPageUDP_Rad_NetSendHex);
            this.TabPageUDP_Gbx_NetSend.Controls.Add(this.TabPageUDP_Rad_NetSendString);
            this.TabPageUDP_Gbx_NetSend.Location = new System.Drawing.Point(6, 90);
            this.TabPageUDP_Gbx_NetSend.Name = "TabPageUDP_Gbx_NetSend";
            this.TabPageUDP_Gbx_NetSend.Size = new System.Drawing.Size(138, 64);
            this.TabPageUDP_Gbx_NetSend.TabIndex = 1;
            this.TabPageUDP_Gbx_NetSend.TabStop = false;
            this.TabPageUDP_Gbx_NetSend.Text = "发码区";
            // 
            // TabPageUDP_Rad_NetSendHex
            // 
            this.TabPageUDP_Rad_NetSendHex.AutoSize = true;
            this.TabPageUDP_Rad_NetSendHex.Location = new System.Drawing.Point(6, 42);
            this.TabPageUDP_Rad_NetSendHex.Name = "TabPageUDP_Rad_NetSendHex";
            this.TabPageUDP_Rad_NetSendHex.Size = new System.Drawing.Size(95, 16);
            this.TabPageUDP_Rad_NetSendHex.TabIndex = 2;
            this.TabPageUDP_Rad_NetSendHex.TabStop = true;
            this.TabPageUDP_Rad_NetSendHex.Text = "十六进制发送";
            this.TabPageUDP_Rad_NetSendHex.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Rad_NetSendString
            // 
            this.TabPageUDP_Rad_NetSendString.AutoSize = true;
            this.TabPageUDP_Rad_NetSendString.Location = new System.Drawing.Point(6, 20);
            this.TabPageUDP_Rad_NetSendString.Name = "TabPageUDP_Rad_NetSendString";
            this.TabPageUDP_Rad_NetSendString.Size = new System.Drawing.Size(83, 16);
            this.TabPageUDP_Rad_NetSendString.TabIndex = 1;
            this.TabPageUDP_Rad_NetSendString.TabStop = true;
            this.TabPageUDP_Rad_NetSendString.Text = "字符串发送";
            this.TabPageUDP_Rad_NetSendString.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Gbx_NetRecv
            // 
            this.TabPageUDP_Gbx_NetRecv.Controls.Add(this.TabPageUDP_Rad_NetRecvHex);
            this.TabPageUDP_Gbx_NetRecv.Controls.Add(this.TabPageUDP_Rad_NetRecvString);
            this.TabPageUDP_Gbx_NetRecv.Location = new System.Drawing.Point(6, 20);
            this.TabPageUDP_Gbx_NetRecv.Name = "TabPageUDP_Gbx_NetRecv";
            this.TabPageUDP_Gbx_NetRecv.Size = new System.Drawing.Size(138, 64);
            this.TabPageUDP_Gbx_NetRecv.TabIndex = 1;
            this.TabPageUDP_Gbx_NetRecv.TabStop = false;
            this.TabPageUDP_Gbx_NetRecv.Text = "消息区";
            // 
            // TabPageUDP_Rad_NetRecvHex
            // 
            this.TabPageUDP_Rad_NetRecvHex.AutoSize = true;
            this.TabPageUDP_Rad_NetRecvHex.Location = new System.Drawing.Point(6, 42);
            this.TabPageUDP_Rad_NetRecvHex.Name = "TabPageUDP_Rad_NetRecvHex";
            this.TabPageUDP_Rad_NetRecvHex.Size = new System.Drawing.Size(95, 16);
            this.TabPageUDP_Rad_NetRecvHex.TabIndex = 1;
            this.TabPageUDP_Rad_NetRecvHex.TabStop = true;
            this.TabPageUDP_Rad_NetRecvHex.Text = "十六进制显示";
            this.TabPageUDP_Rad_NetRecvHex.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Rad_NetRecvString
            // 
            this.TabPageUDP_Rad_NetRecvString.AutoSize = true;
            this.TabPageUDP_Rad_NetRecvString.Location = new System.Drawing.Point(6, 20);
            this.TabPageUDP_Rad_NetRecvString.Name = "TabPageUDP_Rad_NetRecvString";
            this.TabPageUDP_Rad_NetRecvString.Size = new System.Drawing.Size(83, 16);
            this.TabPageUDP_Rad_NetRecvString.TabIndex = 0;
            this.TabPageUDP_Rad_NetRecvString.TabStop = true;
            this.TabPageUDP_Rad_NetRecvString.Text = "字符串显示";
            this.TabPageUDP_Rad_NetRecvString.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Gbx_NetConfig
            // 
            this.TabPageUDP_Gbx_NetConfig.Controls.Add(this.TabPageUDP_Btn_NetOpen);
            this.TabPageUDP_Gbx_NetConfig.Controls.Add(this.TabPageUDP_Tbx_NetLocalHostPort);
            this.TabPageUDP_Gbx_NetConfig.Controls.Add(this.TabPageUDP_Lab_NetLocalHostPort);
            this.TabPageUDP_Gbx_NetConfig.Controls.Add(this.TabPageUDP_Tbx_NetLocalHostIP);
            this.TabPageUDP_Gbx_NetConfig.Controls.Add(this.TabPageUDP_Lab_NetLocalHostIP);
            this.TabPageUDP_Gbx_NetConfig.Location = new System.Drawing.Point(6, 6);
            this.TabPageUDP_Gbx_NetConfig.Name = "TabPageUDP_Gbx_NetConfig";
            this.TabPageUDP_Gbx_NetConfig.Size = new System.Drawing.Size(150, 147);
            this.TabPageUDP_Gbx_NetConfig.TabIndex = 2;
            this.TabPageUDP_Gbx_NetConfig.TabStop = false;
            this.TabPageUDP_Gbx_NetConfig.Text = "网络配置";
            // 
            // TabPageUDP_Btn_NetOpen
            // 
            this.TabPageUDP_Btn_NetOpen.Location = new System.Drawing.Point(6, 118);
            this.TabPageUDP_Btn_NetOpen.Name = "TabPageUDP_Btn_NetOpen";
            this.TabPageUDP_Btn_NetOpen.Size = new System.Drawing.Size(138, 23);
            this.TabPageUDP_Btn_NetOpen.TabIndex = 1;
            this.TabPageUDP_Btn_NetOpen.Text = "打开";
            this.TabPageUDP_Btn_NetOpen.UseVisualStyleBackColor = true;
            // 
            // TabPageUDP_Tbx_NetLocalHostPort
            // 
            this.TabPageUDP_Tbx_NetLocalHostPort.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TabPageUDP_Tbx_NetLocalHostPort.Location = new System.Drawing.Point(6, 81);
            this.TabPageUDP_Tbx_NetLocalHostPort.Name = "TabPageUDP_Tbx_NetLocalHostPort";
            this.TabPageUDP_Tbx_NetLocalHostPort.Size = new System.Drawing.Size(71, 23);
            this.TabPageUDP_Tbx_NetLocalHostPort.TabIndex = 4;
            // 
            // TabPageUDP_Lab_NetLocalHostPort
            // 
            this.TabPageUDP_Lab_NetLocalHostPort.AutoSize = true;
            this.TabPageUDP_Lab_NetLocalHostPort.Location = new System.Drawing.Point(6, 66);
            this.TabPageUDP_Lab_NetLocalHostPort.Name = "TabPageUDP_Lab_NetLocalHostPort";
            this.TabPageUDP_Lab_NetLocalHostPort.Size = new System.Drawing.Size(47, 12);
            this.TabPageUDP_Lab_NetLocalHostPort.TabIndex = 3;
            this.TabPageUDP_Lab_NetLocalHostPort.Text = "端口号:";
            // 
            // TabPageUDP_Tbx_NetLocalHostIP
            // 
            this.TabPageUDP_Tbx_NetLocalHostIP.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TabPageUDP_Tbx_NetLocalHostIP.Location = new System.Drawing.Point(6, 32);
            this.TabPageUDP_Tbx_NetLocalHostIP.Name = "TabPageUDP_Tbx_NetLocalHostIP";
            this.TabPageUDP_Tbx_NetLocalHostIP.Size = new System.Drawing.Size(138, 23);
            this.TabPageUDP_Tbx_NetLocalHostIP.TabIndex = 2;
            // 
            // TabPageUDP_Lab_NetLocalHostIP
            // 
            this.TabPageUDP_Lab_NetLocalHostIP.AutoSize = true;
            this.TabPageUDP_Lab_NetLocalHostIP.Location = new System.Drawing.Point(6, 17);
            this.TabPageUDP_Lab_NetLocalHostIP.Name = "TabPageUDP_Lab_NetLocalHostIP";
            this.TabPageUDP_Lab_NetLocalHostIP.Size = new System.Drawing.Size(71, 12);
            this.TabPageUDP_Lab_NetLocalHostIP.TabIndex = 1;
            this.TabPageUDP_Lab_NetLocalHostIP.Text = "本地IP地址:";
            // 
            // TabPageCurve
            // 
            this.TabPageCurve.Controls.Add(this.TabPageCurve_Gbx_SerialCurve);
            this.TabPageCurve.Controls.Add(this.TabPageCurve_Gbx_SerialInfo);
            this.TabPageCurve.Controls.Add(this.TabPageCurve_Gbx_Function);
            this.TabPageCurve.Controls.Add(this.TabPageCurve_Gbx_SerialConfig);
            this.TabPageCurve.Location = new System.Drawing.Point(4, 22);
            this.TabPageCurve.Name = "TabPageCurve";
            this.TabPageCurve.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageCurve.Size = new System.Drawing.Size(912, 631);
            this.TabPageCurve.TabIndex = 2;
            this.TabPageCurve.Text = "实时曲线";
            this.TabPageCurve.UseVisualStyleBackColor = true;
            // 
            // TabPageCurve_Gbx_SerialCurve
            // 
            this.TabPageCurve_Gbx_SerialCurve.Controls.Add(this.TabPageCurve_Zed_Graph);
            this.TabPageCurve_Gbx_SerialCurve.Location = new System.Drawing.Point(162, 6);
            this.TabPageCurve_Gbx_SerialCurve.Name = "TabPageCurve_Gbx_SerialCurve";
            this.TabPageCurve_Gbx_SerialCurve.Size = new System.Drawing.Size(744, 566);
            this.TabPageCurve_Gbx_SerialCurve.TabIndex = 7;
            this.TabPageCurve_Gbx_SerialCurve.TabStop = false;
            this.TabPageCurve_Gbx_SerialCurve.Text = "串口曲线";
            // 
            // TabPageCurve_Zed_Graph
            // 
            this.TabPageCurve_Zed_Graph.BackColor = System.Drawing.Color.Transparent;
            this.TabPageCurve_Zed_Graph.Location = new System.Drawing.Point(6, 20);
            this.TabPageCurve_Zed_Graph.Name = "TabPageCurve_Zed_Graph";
            this.TabPageCurve_Zed_Graph.ScrollGrace = 0D;
            this.TabPageCurve_Zed_Graph.ScrollMaxX = 0D;
            this.TabPageCurve_Zed_Graph.ScrollMaxY = 0D;
            this.TabPageCurve_Zed_Graph.ScrollMaxY2 = 0D;
            this.TabPageCurve_Zed_Graph.ScrollMinX = 0D;
            this.TabPageCurve_Zed_Graph.ScrollMinY = 0D;
            this.TabPageCurve_Zed_Graph.ScrollMinY2 = 0D;
            this.TabPageCurve_Zed_Graph.Size = new System.Drawing.Size(732, 540);
            this.TabPageCurve_Zed_Graph.TabIndex = 1;
            // 
            // TabPageCurve_Gbx_SerialInfo
            // 
            this.TabPageCurve_Gbx_SerialInfo.Controls.Add(this.TabPageCurve_Btn_ExportData);
            this.TabPageCurve_Gbx_SerialInfo.Controls.Add(this.TabPageCurve_Lab_SerialInfoRecv);
            this.TabPageCurve_Gbx_SerialInfo.Controls.Add(this.TabPageCurve_Tbx_SerialInfoBaud);
            this.TabPageCurve_Gbx_SerialInfo.Controls.Add(this.TabPageCurve_Lab_SerialInfoBaud);
            this.TabPageCurve_Gbx_SerialInfo.Controls.Add(this.TabPageCurve_Tbx_SerialInfoName);
            this.TabPageCurve_Gbx_SerialInfo.Controls.Add(this.TabPageCurve_Lab_SerialInfoName);
            this.TabPageCurve_Gbx_SerialInfo.Controls.Add(this.TabPageCurve_Tbx_SerialInfo);
            this.TabPageCurve_Gbx_SerialInfo.Controls.Add(this.TabPageCurve_Lab_SerialInfo);
            this.TabPageCurve_Gbx_SerialInfo.Location = new System.Drawing.Point(6, 578);
            this.TabPageCurve_Gbx_SerialInfo.Name = "TabPageCurve_Gbx_SerialInfo";
            this.TabPageCurve_Gbx_SerialInfo.Size = new System.Drawing.Size(900, 47);
            this.TabPageCurve_Gbx_SerialInfo.TabIndex = 6;
            this.TabPageCurve_Gbx_SerialInfo.TabStop = false;
            this.TabPageCurve_Gbx_SerialInfo.Text = "串口信息";
            // 
            // TabPageCurve_Btn_ExportData
            // 
            this.TabPageCurve_Btn_ExportData.Location = new System.Drawing.Point(819, 17);
            this.TabPageCurve_Btn_ExportData.Name = "TabPageCurve_Btn_ExportData";
            this.TabPageCurve_Btn_ExportData.Size = new System.Drawing.Size(75, 23);
            this.TabPageCurve_Btn_ExportData.TabIndex = 12;
            this.TabPageCurve_Btn_ExportData.Text = "导出数据";
            this.TabPageCurve_Btn_ExportData.UseVisualStyleBackColor = true;
            this.TabPageCurve_Btn_ExportData.Click += new System.EventHandler(this.TabPageCurve_Btn_ExportData_Click);
            // 
            // TabPageCurve_Lab_SerialInfoRecv
            // 
            this.TabPageCurve_Lab_SerialInfoRecv.AutoSize = true;
            this.TabPageCurve_Lab_SerialInfoRecv.Location = new System.Drawing.Point(724, 21);
            this.TabPageCurve_Lab_SerialInfoRecv.Name = "TabPageCurve_Lab_SerialInfoRecv";
            this.TabPageCurve_Lab_SerialInfoRecv.Size = new System.Drawing.Size(53, 12);
            this.TabPageCurve_Lab_SerialInfoRecv.TabIndex = 1;
            this.TabPageCurve_Lab_SerialInfoRecv.Text = "已接收:0";
            // 
            // TabPageCurve_Tbx_SerialInfoBaud
            // 
            this.TabPageCurve_Tbx_SerialInfoBaud.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageCurve_Tbx_SerialInfoBaud.Location = new System.Drawing.Point(622, 18);
            this.TabPageCurve_Tbx_SerialInfoBaud.Name = "TabPageCurve_Tbx_SerialInfoBaud";
            this.TabPageCurve_Tbx_SerialInfoBaud.Size = new System.Drawing.Size(85, 22);
            this.TabPageCurve_Tbx_SerialInfoBaud.TabIndex = 9;
            // 
            // TabPageCurve_Lab_SerialInfoBaud
            // 
            this.TabPageCurve_Lab_SerialInfoBaud.AutoSize = true;
            this.TabPageCurve_Lab_SerialInfoBaud.Location = new System.Drawing.Point(569, 21);
            this.TabPageCurve_Lab_SerialInfoBaud.Name = "TabPageCurve_Lab_SerialInfoBaud";
            this.TabPageCurve_Lab_SerialInfoBaud.Size = new System.Drawing.Size(47, 12);
            this.TabPageCurve_Lab_SerialInfoBaud.TabIndex = 8;
            this.TabPageCurve_Lab_SerialInfoBaud.Text = "波特率:";
            // 
            // TabPageCurve_Tbx_SerialInfoName
            // 
            this.TabPageCurve_Tbx_SerialInfoName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageCurve_Tbx_SerialInfoName.Location = new System.Drawing.Point(478, 18);
            this.TabPageCurve_Tbx_SerialInfoName.Name = "TabPageCurve_Tbx_SerialInfoName";
            this.TabPageCurve_Tbx_SerialInfoName.Size = new System.Drawing.Size(85, 22);
            this.TabPageCurve_Tbx_SerialInfoName.TabIndex = 7;
            // 
            // TabPageCurve_Lab_SerialInfoName
            // 
            this.TabPageCurve_Lab_SerialInfoName.AutoSize = true;
            this.TabPageCurve_Lab_SerialInfoName.Location = new System.Drawing.Point(425, 22);
            this.TabPageCurve_Lab_SerialInfoName.Name = "TabPageCurve_Lab_SerialInfoName";
            this.TabPageCurve_Lab_SerialInfoName.Size = new System.Drawing.Size(47, 12);
            this.TabPageCurve_Lab_SerialInfoName.TabIndex = 6;
            this.TabPageCurve_Lab_SerialInfoName.Text = "串口号:";
            // 
            // TabPageCurve_Tbx_SerialInfo
            // 
            this.TabPageCurve_Tbx_SerialInfo.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPageCurve_Tbx_SerialInfo.Location = new System.Drawing.Point(71, 19);
            this.TabPageCurve_Tbx_SerialInfo.Name = "TabPageCurve_Tbx_SerialInfo";
            this.TabPageCurve_Tbx_SerialInfo.Size = new System.Drawing.Size(348, 21);
            this.TabPageCurve_Tbx_SerialInfo.TabIndex = 1;
            // 
            // TabPageCurve_Lab_SerialInfo
            // 
            this.TabPageCurve_Lab_SerialInfo.AutoSize = true;
            this.TabPageCurve_Lab_SerialInfo.Location = new System.Drawing.Point(6, 22);
            this.TabPageCurve_Lab_SerialInfo.Name = "TabPageCurve_Lab_SerialInfo";
            this.TabPageCurve_Lab_SerialInfo.Size = new System.Drawing.Size(59, 12);
            this.TabPageCurve_Lab_SerialInfo.TabIndex = 5;
            this.TabPageCurve_Lab_SerialInfo.Text = "提示信息:";
            // 
            // TabPageCurve_Gbx_Function
            // 
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Btn_CurveClear);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_Curve8);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_Curve7);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_Curve6);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_Curve5);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_Curve4);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_Curve3);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_Curve2);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_Curve1);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Nud_CurveNum);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Lab_CurveNum);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Cbx_Curve8);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Cbx_Curve7);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Cbx_Curve6);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Cbx_Curve5);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Cbx_Curve4);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Cbx_Curve3);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Cbx_Curve2);
            this.TabPageCurve_Gbx_Function.Controls.Add(this.TabPageCurve_Cbx_Curve1);
            this.TabPageCurve_Gbx_Function.Location = new System.Drawing.Point(6, 223);
            this.TabPageCurve_Gbx_Function.Name = "TabPageCurve_Gbx_Function";
            this.TabPageCurve_Gbx_Function.Size = new System.Drawing.Size(150, 240);
            this.TabPageCurve_Gbx_Function.TabIndex = 5;
            this.TabPageCurve_Gbx_Function.TabStop = false;
            this.TabPageCurve_Gbx_Function.Text = "辅助功能";
            // 
            // TabPageCurve_Btn_CurveClear
            // 
            this.TabPageCurve_Btn_CurveClear.Location = new System.Drawing.Point(68, 211);
            this.TabPageCurve_Btn_CurveClear.Name = "TabPageCurve_Btn_CurveClear";
            this.TabPageCurve_Btn_CurveClear.Size = new System.Drawing.Size(76, 23);
            this.TabPageCurve_Btn_CurveClear.TabIndex = 1;
            this.TabPageCurve_Btn_CurveClear.Text = "清除曲线";
            this.TabPageCurve_Btn_CurveClear.UseVisualStyleBackColor = true;
            this.TabPageCurve_Btn_CurveClear.Click += new System.EventHandler(this.TabPageCurve_Btn_CurveClear_Click);
            // 
            // TabPageCurve_Lab_Curve8
            // 
            this.TabPageCurve_Lab_Curve8.AutoSize = true;
            this.TabPageCurve_Lab_Curve8.BackColor = System.Drawing.Color.BlueViolet;
            this.TabPageCurve_Lab_Curve8.Location = new System.Drawing.Point(69, 175);
            this.TabPageCurve_Lab_Curve8.Name = "TabPageCurve_Lab_Curve8";
            this.TabPageCurve_Lab_Curve8.Size = new System.Drawing.Size(41, 12);
            this.TabPageCurve_Lab_Curve8.TabIndex = 16;
            this.TabPageCurve_Lab_Curve8.Text = "数值:0";
            // 
            // TabPageCurve_Lab_Curve7
            // 
            this.TabPageCurve_Lab_Curve7.AutoSize = true;
            this.TabPageCurve_Lab_Curve7.BackColor = System.Drawing.Color.RoyalBlue;
            this.TabPageCurve_Lab_Curve7.Location = new System.Drawing.Point(69, 153);
            this.TabPageCurve_Lab_Curve7.Name = "TabPageCurve_Lab_Curve7";
            this.TabPageCurve_Lab_Curve7.Size = new System.Drawing.Size(41, 12);
            this.TabPageCurve_Lab_Curve7.TabIndex = 15;
            this.TabPageCurve_Lab_Curve7.Text = "数值:0";
            // 
            // TabPageCurve_Lab_Curve6
            // 
            this.TabPageCurve_Lab_Curve6.AutoSize = true;
            this.TabPageCurve_Lab_Curve6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TabPageCurve_Lab_Curve6.Location = new System.Drawing.Point(69, 131);
            this.TabPageCurve_Lab_Curve6.Name = "TabPageCurve_Lab_Curve6";
            this.TabPageCurve_Lab_Curve6.Size = new System.Drawing.Size(41, 12);
            this.TabPageCurve_Lab_Curve6.TabIndex = 14;
            this.TabPageCurve_Lab_Curve6.Text = "数值:0";
            // 
            // TabPageCurve_Lab_Curve5
            // 
            this.TabPageCurve_Lab_Curve5.AutoSize = true;
            this.TabPageCurve_Lab_Curve5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TabPageCurve_Lab_Curve5.Location = new System.Drawing.Point(69, 109);
            this.TabPageCurve_Lab_Curve5.Name = "TabPageCurve_Lab_Curve5";
            this.TabPageCurve_Lab_Curve5.Size = new System.Drawing.Size(41, 12);
            this.TabPageCurve_Lab_Curve5.TabIndex = 13;
            this.TabPageCurve_Lab_Curve5.Text = "数值:0";
            // 
            // TabPageCurve_Lab_Curve4
            // 
            this.TabPageCurve_Lab_Curve4.AutoSize = true;
            this.TabPageCurve_Lab_Curve4.BackColor = System.Drawing.Color.LawnGreen;
            this.TabPageCurve_Lab_Curve4.Location = new System.Drawing.Point(69, 87);
            this.TabPageCurve_Lab_Curve4.Name = "TabPageCurve_Lab_Curve4";
            this.TabPageCurve_Lab_Curve4.Size = new System.Drawing.Size(41, 12);
            this.TabPageCurve_Lab_Curve4.TabIndex = 12;
            this.TabPageCurve_Lab_Curve4.Text = "数值:0";
            // 
            // TabPageCurve_Lab_Curve3
            // 
            this.TabPageCurve_Lab_Curve3.AutoSize = true;
            this.TabPageCurve_Lab_Curve3.BackColor = System.Drawing.Color.Orange;
            this.TabPageCurve_Lab_Curve3.Location = new System.Drawing.Point(69, 65);
            this.TabPageCurve_Lab_Curve3.Name = "TabPageCurve_Lab_Curve3";
            this.TabPageCurve_Lab_Curve3.Size = new System.Drawing.Size(41, 12);
            this.TabPageCurve_Lab_Curve3.TabIndex = 11;
            this.TabPageCurve_Lab_Curve3.Text = "数值:0";
            // 
            // TabPageCurve_Lab_Curve2
            // 
            this.TabPageCurve_Lab_Curve2.AutoSize = true;
            this.TabPageCurve_Lab_Curve2.BackColor = System.Drawing.Color.Teal;
            this.TabPageCurve_Lab_Curve2.Location = new System.Drawing.Point(69, 43);
            this.TabPageCurve_Lab_Curve2.Name = "TabPageCurve_Lab_Curve2";
            this.TabPageCurve_Lab_Curve2.Size = new System.Drawing.Size(41, 12);
            this.TabPageCurve_Lab_Curve2.TabIndex = 10;
            this.TabPageCurve_Lab_Curve2.Text = "数值:0";
            // 
            // TabPageCurve_Lab_Curve1
            // 
            this.TabPageCurve_Lab_Curve1.AutoSize = true;
            this.TabPageCurve_Lab_Curve1.BackColor = System.Drawing.Color.LightCoral;
            this.TabPageCurve_Lab_Curve1.Location = new System.Drawing.Point(69, 21);
            this.TabPageCurve_Lab_Curve1.Name = "TabPageCurve_Lab_Curve1";
            this.TabPageCurve_Lab_Curve1.Size = new System.Drawing.Size(41, 12);
            this.TabPageCurve_Lab_Curve1.TabIndex = 9;
            this.TabPageCurve_Lab_Curve1.Text = "数值:0";
            // 
            // TabPageCurve_Nud_CurveNum
            // 
            this.TabPageCurve_Nud_CurveNum.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPageCurve_Nud_CurveNum.Location = new System.Drawing.Point(8, 213);
            this.TabPageCurve_Nud_CurveNum.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.TabPageCurve_Nud_CurveNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TabPageCurve_Nud_CurveNum.Name = "TabPageCurve_Nud_CurveNum";
            this.TabPageCurve_Nud_CurveNum.Size = new System.Drawing.Size(54, 21);
            this.TabPageCurve_Nud_CurveNum.TabIndex = 8;
            this.TabPageCurve_Nud_CurveNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TabPageCurve_Nud_CurveNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.TabPageCurve_Nud_CurveNum.ValueChanged += new System.EventHandler(this.TabPageCurve_Nud_CurveNum_ValueChanged);
            // 
            // TabPageCurve_Lab_CurveNum
            // 
            this.TabPageCurve_Lab_CurveNum.AutoSize = true;
            this.TabPageCurve_Lab_CurveNum.Location = new System.Drawing.Point(6, 198);
            this.TabPageCurve_Lab_CurveNum.Name = "TabPageCurve_Lab_CurveNum";
            this.TabPageCurve_Lab_CurveNum.Size = new System.Drawing.Size(53, 12);
            this.TabPageCurve_Lab_CurveNum.TabIndex = 7;
            this.TabPageCurve_Lab_CurveNum.Text = "曲线数量";
            // 
            // TabPageCurve_Cbx_Curve8
            // 
            this.TabPageCurve_Cbx_Curve8.AutoSize = true;
            this.TabPageCurve_Cbx_Curve8.BackColor = System.Drawing.Color.BlueViolet;
            this.TabPageCurve_Cbx_Curve8.Location = new System.Drawing.Point(8, 174);
            this.TabPageCurve_Cbx_Curve8.Name = "TabPageCurve_Cbx_Curve8";
            this.TabPageCurve_Cbx_Curve8.Size = new System.Drawing.Size(54, 16);
            this.TabPageCurve_Cbx_Curve8.TabIndex = 6;
            this.TabPageCurve_Cbx_Curve8.Text = "曲线8";
            this.TabPageCurve_Cbx_Curve8.UseVisualStyleBackColor = false;
            this.TabPageCurve_Cbx_Curve8.CheckedChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve8_CheckedChanged);
            this.TabPageCurve_Cbx_Curve8.EnabledChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve8_EnabledChanged);
            // 
            // TabPageCurve_Cbx_Curve7
            // 
            this.TabPageCurve_Cbx_Curve7.AutoSize = true;
            this.TabPageCurve_Cbx_Curve7.BackColor = System.Drawing.Color.RoyalBlue;
            this.TabPageCurve_Cbx_Curve7.Location = new System.Drawing.Point(8, 152);
            this.TabPageCurve_Cbx_Curve7.Name = "TabPageCurve_Cbx_Curve7";
            this.TabPageCurve_Cbx_Curve7.Size = new System.Drawing.Size(54, 16);
            this.TabPageCurve_Cbx_Curve7.TabIndex = 1;
            this.TabPageCurve_Cbx_Curve7.Text = "曲线7";
            this.TabPageCurve_Cbx_Curve7.UseVisualStyleBackColor = false;
            this.TabPageCurve_Cbx_Curve7.CheckedChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve7_CheckedChanged);
            this.TabPageCurve_Cbx_Curve7.EnabledChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve7_EnabledChanged);
            // 
            // TabPageCurve_Cbx_Curve6
            // 
            this.TabPageCurve_Cbx_Curve6.AutoSize = true;
            this.TabPageCurve_Cbx_Curve6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TabPageCurve_Cbx_Curve6.Location = new System.Drawing.Point(8, 130);
            this.TabPageCurve_Cbx_Curve6.Name = "TabPageCurve_Cbx_Curve6";
            this.TabPageCurve_Cbx_Curve6.Size = new System.Drawing.Size(54, 16);
            this.TabPageCurve_Cbx_Curve6.TabIndex = 5;
            this.TabPageCurve_Cbx_Curve6.Text = "曲线6";
            this.TabPageCurve_Cbx_Curve6.UseVisualStyleBackColor = false;
            this.TabPageCurve_Cbx_Curve6.CheckedChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve6_CheckedChanged);
            this.TabPageCurve_Cbx_Curve6.EnabledChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve6_EnabledChanged);
            // 
            // TabPageCurve_Cbx_Curve5
            // 
            this.TabPageCurve_Cbx_Curve5.AutoSize = true;
            this.TabPageCurve_Cbx_Curve5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TabPageCurve_Cbx_Curve5.Location = new System.Drawing.Point(8, 108);
            this.TabPageCurve_Cbx_Curve5.Name = "TabPageCurve_Cbx_Curve5";
            this.TabPageCurve_Cbx_Curve5.Size = new System.Drawing.Size(54, 16);
            this.TabPageCurve_Cbx_Curve5.TabIndex = 4;
            this.TabPageCurve_Cbx_Curve5.Text = "曲线5";
            this.TabPageCurve_Cbx_Curve5.UseVisualStyleBackColor = false;
            this.TabPageCurve_Cbx_Curve5.CheckedChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve5_CheckedChanged);
            this.TabPageCurve_Cbx_Curve5.EnabledChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve5_EnabledChanged);
            // 
            // TabPageCurve_Cbx_Curve4
            // 
            this.TabPageCurve_Cbx_Curve4.AutoSize = true;
            this.TabPageCurve_Cbx_Curve4.BackColor = System.Drawing.Color.LawnGreen;
            this.TabPageCurve_Cbx_Curve4.Location = new System.Drawing.Point(8, 86);
            this.TabPageCurve_Cbx_Curve4.Name = "TabPageCurve_Cbx_Curve4";
            this.TabPageCurve_Cbx_Curve4.Size = new System.Drawing.Size(54, 16);
            this.TabPageCurve_Cbx_Curve4.TabIndex = 3;
            this.TabPageCurve_Cbx_Curve4.Text = "曲线4";
            this.TabPageCurve_Cbx_Curve4.UseVisualStyleBackColor = false;
            this.TabPageCurve_Cbx_Curve4.CheckedChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve4_CheckedChanged);
            this.TabPageCurve_Cbx_Curve4.EnabledChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve4_EnabledChanged);
            // 
            // TabPageCurve_Cbx_Curve3
            // 
            this.TabPageCurve_Cbx_Curve3.AutoSize = true;
            this.TabPageCurve_Cbx_Curve3.BackColor = System.Drawing.Color.Orange;
            this.TabPageCurve_Cbx_Curve3.Location = new System.Drawing.Point(8, 64);
            this.TabPageCurve_Cbx_Curve3.Name = "TabPageCurve_Cbx_Curve3";
            this.TabPageCurve_Cbx_Curve3.Size = new System.Drawing.Size(54, 16);
            this.TabPageCurve_Cbx_Curve3.TabIndex = 2;
            this.TabPageCurve_Cbx_Curve3.Text = "曲线3";
            this.TabPageCurve_Cbx_Curve3.UseVisualStyleBackColor = false;
            this.TabPageCurve_Cbx_Curve3.CheckedChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve3_CheckedChanged);
            this.TabPageCurve_Cbx_Curve3.EnabledChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve3_EnabledChanged);
            // 
            // TabPageCurve_Cbx_Curve2
            // 
            this.TabPageCurve_Cbx_Curve2.AutoSize = true;
            this.TabPageCurve_Cbx_Curve2.BackColor = System.Drawing.Color.Teal;
            this.TabPageCurve_Cbx_Curve2.Location = new System.Drawing.Point(8, 42);
            this.TabPageCurve_Cbx_Curve2.Name = "TabPageCurve_Cbx_Curve2";
            this.TabPageCurve_Cbx_Curve2.Size = new System.Drawing.Size(54, 16);
            this.TabPageCurve_Cbx_Curve2.TabIndex = 1;
            this.TabPageCurve_Cbx_Curve2.Text = "曲线2";
            this.TabPageCurve_Cbx_Curve2.UseVisualStyleBackColor = false;
            this.TabPageCurve_Cbx_Curve2.CheckedChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve2_CheckedChanged);
            this.TabPageCurve_Cbx_Curve2.EnabledChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve2_EnabledChanged);
            // 
            // TabPageCurve_Cbx_Curve1
            // 
            this.TabPageCurve_Cbx_Curve1.AutoSize = true;
            this.TabPageCurve_Cbx_Curve1.BackColor = System.Drawing.Color.LightCoral;
            this.TabPageCurve_Cbx_Curve1.Location = new System.Drawing.Point(8, 20);
            this.TabPageCurve_Cbx_Curve1.Name = "TabPageCurve_Cbx_Curve1";
            this.TabPageCurve_Cbx_Curve1.Size = new System.Drawing.Size(54, 16);
            this.TabPageCurve_Cbx_Curve1.TabIndex = 0;
            this.TabPageCurve_Cbx_Curve1.Text = "曲线1";
            this.TabPageCurve_Cbx_Curve1.UseVisualStyleBackColor = false;
            this.TabPageCurve_Cbx_Curve1.CheckedChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve1_CheckedChanged);
            this.TabPageCurve_Cbx_Curve1.EnabledChanged += new System.EventHandler(this.TabPageCurve_Cbx_Curve1_EnabledChanged);
            // 
            // TabPageCurve_Gbx_SerialConfig
            // 
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Btn_SerialOpen);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Btn_SerialRefresh);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Cbx_SerialCheckBit);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Lab_SerialCheckBit);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Cbx_SerialStopBit);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Lab_SerialStopBit);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Cbx_SerialDataBit);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Lab_SerialDataBit);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Cbx_SerialBaud);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Lab_SerialBaud);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Cbx_SerialName);
            this.TabPageCurve_Gbx_SerialConfig.Controls.Add(this.TabPageCurve_Lab_SerialName);
            this.TabPageCurve_Gbx_SerialConfig.Location = new System.Drawing.Point(6, 6);
            this.TabPageCurve_Gbx_SerialConfig.Name = "TabPageCurve_Gbx_SerialConfig";
            this.TabPageCurve_Gbx_SerialConfig.Size = new System.Drawing.Size(150, 211);
            this.TabPageCurve_Gbx_SerialConfig.TabIndex = 1;
            this.TabPageCurve_Gbx_SerialConfig.TabStop = false;
            this.TabPageCurve_Gbx_SerialConfig.Text = "串口配置";
            // 
            // TabPageCurve_Btn_SerialOpen
            // 
            this.TabPageCurve_Btn_SerialOpen.Location = new System.Drawing.Point(6, 182);
            this.TabPageCurve_Btn_SerialOpen.Name = "TabPageCurve_Btn_SerialOpen";
            this.TabPageCurve_Btn_SerialOpen.Size = new System.Drawing.Size(138, 23);
            this.TabPageCurve_Btn_SerialOpen.TabIndex = 17;
            this.TabPageCurve_Btn_SerialOpen.Text = "打开串口";
            this.TabPageCurve_Btn_SerialOpen.UseVisualStyleBackColor = true;
            this.TabPageCurve_Btn_SerialOpen.Click += new System.EventHandler(this.TabPageCurve_Btn_SerialOpen_Click);
            // 
            // TabPageCurve_Btn_SerialRefresh
            // 
            this.TabPageCurve_Btn_SerialRefresh.Location = new System.Drawing.Point(6, 153);
            this.TabPageCurve_Btn_SerialRefresh.Name = "TabPageCurve_Btn_SerialRefresh";
            this.TabPageCurve_Btn_SerialRefresh.Size = new System.Drawing.Size(138, 23);
            this.TabPageCurve_Btn_SerialRefresh.TabIndex = 16;
            this.TabPageCurve_Btn_SerialRefresh.Text = "刷新串口";
            this.TabPageCurve_Btn_SerialRefresh.UseVisualStyleBackColor = true;
            this.TabPageCurve_Btn_SerialRefresh.Click += new System.EventHandler(this.TabPageCurve_Btn_SerialRefresh_Click);
            // 
            // TabPageCurve_Cbx_SerialCheckBit
            // 
            this.TabPageCurve_Cbx_SerialCheckBit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageCurve_Cbx_SerialCheckBit.FormattingEnabled = true;
            this.TabPageCurve_Cbx_SerialCheckBit.Location = new System.Drawing.Point(59, 125);
            this.TabPageCurve_Cbx_SerialCheckBit.Name = "TabPageCurve_Cbx_SerialCheckBit";
            this.TabPageCurve_Cbx_SerialCheckBit.Size = new System.Drawing.Size(85, 23);
            this.TabPageCurve_Cbx_SerialCheckBit.TabIndex = 15;
            // 
            // TabPageCurve_Lab_SerialCheckBit
            // 
            this.TabPageCurve_Lab_SerialCheckBit.AutoSize = true;
            this.TabPageCurve_Lab_SerialCheckBit.Location = new System.Drawing.Point(6, 129);
            this.TabPageCurve_Lab_SerialCheckBit.Name = "TabPageCurve_Lab_SerialCheckBit";
            this.TabPageCurve_Lab_SerialCheckBit.Size = new System.Drawing.Size(47, 12);
            this.TabPageCurve_Lab_SerialCheckBit.TabIndex = 14;
            this.TabPageCurve_Lab_SerialCheckBit.Text = "校验位:";
            // 
            // TabPageCurve_Cbx_SerialStopBit
            // 
            this.TabPageCurve_Cbx_SerialStopBit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageCurve_Cbx_SerialStopBit.FormattingEnabled = true;
            this.TabPageCurve_Cbx_SerialStopBit.Location = new System.Drawing.Point(59, 97);
            this.TabPageCurve_Cbx_SerialStopBit.Name = "TabPageCurve_Cbx_SerialStopBit";
            this.TabPageCurve_Cbx_SerialStopBit.Size = new System.Drawing.Size(85, 23);
            this.TabPageCurve_Cbx_SerialStopBit.TabIndex = 13;
            // 
            // TabPageCurve_Lab_SerialStopBit
            // 
            this.TabPageCurve_Lab_SerialStopBit.AutoSize = true;
            this.TabPageCurve_Lab_SerialStopBit.Location = new System.Drawing.Point(6, 101);
            this.TabPageCurve_Lab_SerialStopBit.Name = "TabPageCurve_Lab_SerialStopBit";
            this.TabPageCurve_Lab_SerialStopBit.Size = new System.Drawing.Size(47, 12);
            this.TabPageCurve_Lab_SerialStopBit.TabIndex = 12;
            this.TabPageCurve_Lab_SerialStopBit.Text = "停止位:";
            // 
            // TabPageCurve_Cbx_SerialDataBit
            // 
            this.TabPageCurve_Cbx_SerialDataBit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageCurve_Cbx_SerialDataBit.FormattingEnabled = true;
            this.TabPageCurve_Cbx_SerialDataBit.Location = new System.Drawing.Point(59, 69);
            this.TabPageCurve_Cbx_SerialDataBit.Name = "TabPageCurve_Cbx_SerialDataBit";
            this.TabPageCurve_Cbx_SerialDataBit.Size = new System.Drawing.Size(85, 23);
            this.TabPageCurve_Cbx_SerialDataBit.TabIndex = 11;
            // 
            // TabPageCurve_Lab_SerialDataBit
            // 
            this.TabPageCurve_Lab_SerialDataBit.AutoSize = true;
            this.TabPageCurve_Lab_SerialDataBit.Location = new System.Drawing.Point(6, 73);
            this.TabPageCurve_Lab_SerialDataBit.Name = "TabPageCurve_Lab_SerialDataBit";
            this.TabPageCurve_Lab_SerialDataBit.Size = new System.Drawing.Size(47, 12);
            this.TabPageCurve_Lab_SerialDataBit.TabIndex = 10;
            this.TabPageCurve_Lab_SerialDataBit.Text = "数据位:";
            // 
            // TabPageCurve_Cbx_SerialBaud
            // 
            this.TabPageCurve_Cbx_SerialBaud.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageCurve_Cbx_SerialBaud.FormattingEnabled = true;
            this.TabPageCurve_Cbx_SerialBaud.Location = new System.Drawing.Point(59, 41);
            this.TabPageCurve_Cbx_SerialBaud.Name = "TabPageCurve_Cbx_SerialBaud";
            this.TabPageCurve_Cbx_SerialBaud.Size = new System.Drawing.Size(85, 23);
            this.TabPageCurve_Cbx_SerialBaud.TabIndex = 9;
            // 
            // TabPageCurve_Lab_SerialBaud
            // 
            this.TabPageCurve_Lab_SerialBaud.AutoSize = true;
            this.TabPageCurve_Lab_SerialBaud.Location = new System.Drawing.Point(6, 45);
            this.TabPageCurve_Lab_SerialBaud.Name = "TabPageCurve_Lab_SerialBaud";
            this.TabPageCurve_Lab_SerialBaud.Size = new System.Drawing.Size(47, 12);
            this.TabPageCurve_Lab_SerialBaud.TabIndex = 8;
            this.TabPageCurve_Lab_SerialBaud.Text = "波特率:";
            // 
            // TabPageCurve_Cbx_SerialName
            // 
            this.TabPageCurve_Cbx_SerialName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageCurve_Cbx_SerialName.FormattingEnabled = true;
            this.TabPageCurve_Cbx_SerialName.Location = new System.Drawing.Point(59, 13);
            this.TabPageCurve_Cbx_SerialName.Name = "TabPageCurve_Cbx_SerialName";
            this.TabPageCurve_Cbx_SerialName.Size = new System.Drawing.Size(85, 23);
            this.TabPageCurve_Cbx_SerialName.TabIndex = 7;
            // 
            // TabPageCurve_Lab_SerialName
            // 
            this.TabPageCurve_Lab_SerialName.AutoSize = true;
            this.TabPageCurve_Lab_SerialName.Location = new System.Drawing.Point(6, 17);
            this.TabPageCurve_Lab_SerialName.Name = "TabPageCurve_Lab_SerialName";
            this.TabPageCurve_Lab_SerialName.Size = new System.Drawing.Size(47, 12);
            this.TabPageCurve_Lab_SerialName.TabIndex = 0;
            this.TabPageCurve_Lab_SerialName.Text = "串口号:";
            // 
            // TabPageAnalysis
            // 
            this.TabPageAnalysis.Location = new System.Drawing.Point(4, 22);
            this.TabPageAnalysis.Name = "TabPageAnalysis";
            this.TabPageAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAnalysis.Size = new System.Drawing.Size(912, 631);
            this.TabPageAnalysis.TabIndex = 3;
            this.TabPageAnalysis.Text = "数据分析";
            this.TabPageAnalysis.UseVisualStyleBackColor = true;
            // 
            // TabPageConsole
            // 
            this.TabPageConsole.Location = new System.Drawing.Point(4, 22);
            this.TabPageConsole.Name = "TabPageConsole";
            this.TabPageConsole.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageConsole.Size = new System.Drawing.Size(912, 631);
            this.TabPageConsole.TabIndex = 4;
            this.TabPageConsole.Text = "控制台";
            this.TabPageConsole.UseVisualStyleBackColor = true;
            // 
            // TabPageHelp
            // 
            this.TabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.TabPageHelp.Name = "TabPageHelp";
            this.TabPageHelp.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageHelp.Size = new System.Drawing.Size(912, 631);
            this.TabPageHelp.TabIndex = 5;
            this.TabPageHelp.Text = "帮助";
            this.TabPageHelp.UseVisualStyleBackColor = true;
            // 
            // TabPageAbout
            // 
            this.TabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.TabPageAbout.Name = "TabPageAbout";
            this.TabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAbout.Size = new System.Drawing.Size(912, 631);
            this.TabPageAbout.TabIndex = 6;
            this.TabPageAbout.Text = "关于";
            this.TabPageAbout.UseVisualStyleBackColor = true;
            // 
            // SerialPortDebug
            // 
            this.SerialPortDebug.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortDebug_DataReceived);
            // 
            // SerialTimerSend
            // 
            this.SerialTimerSend.Tick += new System.EventHandler(this.SerialTimerSend_Tick);
            // 
            // SerialTimerRecvSpeed
            // 
            this.SerialTimerRecvSpeed.Interval = 1000;
            this.SerialTimerRecvSpeed.Tick += new System.EventHandler(this.SerialTimerRecvSpeed_Tick);
            // 
            // SerialTimerRefresh
            // 
            this.SerialTimerRefresh.Interval = 1;
            this.SerialTimerRefresh.Tick += new System.EventHandler(this.SerialTimerRefresh_Tick);
            // 
            // SerialPortCurve
            // 
            this.SerialPortCurve.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortCurve_DataReceived);
            // 
            // CurveRefresh
            // 
            this.CurveRefresh.Interval = 1;
            this.CurveRefresh.Tick += new System.EventHandler(this.CurveRefresh_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.TabMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "CSMPC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TabMain.ResumeLayout(false);
            this.TabPageSerial.ResumeLayout(false);
            this.TabPageSerial_Gbx_SerialSend.ResumeLayout(false);
            this.TabPageSerial_Gbx_SerialSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPageSerial_Nud_SerialTimer)).EndInit();
            this.TabPageSerial_Gbx_SerialRecv.ResumeLayout(false);
            this.TabPageSerial_Gbx_SerialRecv.PerformLayout();
            this.TabPageSerial_Gbx_SerialInfo.ResumeLayout(false);
            this.TabPageSerial_Gbx_SerialInfo.PerformLayout();
            this.TabPageSerial_Gbx_SerialFunction.ResumeLayout(false);
            this.TabPageSerial_Gbx_Func.ResumeLayout(false);
            this.TabPageSerial_Gbx_Send.ResumeLayout(false);
            this.TabPageSerial_Gbx_Send.PerformLayout();
            this.TabPageSerial_Gbx_Recv.ResumeLayout(false);
            this.TabPageSerial_Gbx_Recv.PerformLayout();
            this.TabPageSerial_Gbx_SerialConfig.ResumeLayout(false);
            this.TabPageSerial_Gbx_SerialConfig.PerformLayout();
            this.TabPageNet.ResumeLayout(false);
            this.TabNet.ResumeLayout(false);
            this.TabPageTCPServer.ResumeLayout(false);
            this.TabPageTCPServer_Gbx_Send.ResumeLayout(false);
            this.TabPageTCPServer_Gbx_Send.PerformLayout();
            this.TabPageTCPServer_Gbx_Recv.ResumeLayout(false);
            this.TabPageTCPServer_Gbx_Recv.PerformLayout();
            this.TabPageTCPServer_Gbx_NetFunction.ResumeLayout(false);
            this.TabPageTCPServer_Gbx_NetFunc.ResumeLayout(false);
            this.TabPageTCPServer_Gbx_NetSend.ResumeLayout(false);
            this.TabPageTCPServer_Gbx_NetSend.PerformLayout();
            this.TabPageTCPServer_Gbx_NetRecv.ResumeLayout(false);
            this.TabPageTCPServer_Gbx_NetRecv.PerformLayout();
            this.TabPageTCPServer_Gbx_NetConfig.ResumeLayout(false);
            this.TabPageTCPServer_Gbx_NetConfig.PerformLayout();
            this.TabPageTCPClient.ResumeLayout(false);
            this.TabPageTCPClient_Gbx_Send.ResumeLayout(false);
            this.TabPageTCPClient_Gbx_Send.PerformLayout();
            this.TabPageTCPClient_Gbx_Recv.ResumeLayout(false);
            this.TabPageTCPClient_Gbx_Recv.PerformLayout();
            this.TabPageTCPClient_Gbx_NetFunction.ResumeLayout(false);
            this.TabPageTCPClient_Gbx_NetFunc.ResumeLayout(false);
            this.TabPageTCPClient_Gbx_NetSend.ResumeLayout(false);
            this.TabPageTCPClient_Gbx_NetSend.PerformLayout();
            this.TabPageTCPClient_Gbx_NetRecv.ResumeLayout(false);
            this.TabPageTCPClient_Gbx_NetRecv.PerformLayout();
            this.TabPageTCPClient_Gbx_NetConfig.ResumeLayout(false);
            this.TabPageTCPClient_Gbx_NetConfig.PerformLayout();
            this.TabPageUDP.ResumeLayout(false);
            this.TabPageUDP_Gbx_Send.ResumeLayout(false);
            this.TabPageUDP_Gbx_Send.PerformLayout();
            this.TabPageUDP_Gbx_Recv.ResumeLayout(false);
            this.TabPageUDP_Gbx_Recv.PerformLayout();
            this.TabPageUDP_Gbx_NetFunction.ResumeLayout(false);
            this.TabPageUDP_Gbx_NetFunc.ResumeLayout(false);
            this.TabPageUDP_Gbx_NetSend.ResumeLayout(false);
            this.TabPageUDP_Gbx_NetSend.PerformLayout();
            this.TabPageUDP_Gbx_NetRecv.ResumeLayout(false);
            this.TabPageUDP_Gbx_NetRecv.PerformLayout();
            this.TabPageUDP_Gbx_NetConfig.ResumeLayout(false);
            this.TabPageUDP_Gbx_NetConfig.PerformLayout();
            this.TabPageCurve.ResumeLayout(false);
            this.TabPageCurve_Gbx_SerialCurve.ResumeLayout(false);
            this.TabPageCurve_Gbx_SerialInfo.ResumeLayout(false);
            this.TabPageCurve_Gbx_SerialInfo.PerformLayout();
            this.TabPageCurve_Gbx_Function.ResumeLayout(false);
            this.TabPageCurve_Gbx_Function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPageCurve_Nud_CurveNum)).EndInit();
            this.TabPageCurve_Gbx_SerialConfig.ResumeLayout(false);
            this.TabPageCurve_Gbx_SerialConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage TabPageSerial;
        private System.Windows.Forms.TabPage TabPageNet;
        private System.Windows.Forms.TabPage TabPageCurve;
        private System.Windows.Forms.TabPage TabPageAnalysis;
        private System.Windows.Forms.TabPage TabPageConsole;
        private System.Windows.Forms.TabPage TabPageHelp;
        private System.Windows.Forms.GroupBox TabPageSerial_Gbx_SerialConfig;
        private System.Windows.Forms.TabPage TabPageAbout;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialName;
        private System.Windows.Forms.ComboBox TabPageSerial_Cbx_SerialName;
        private System.Windows.Forms.Button TabPageSerial_Btn_SerialOpen;
        private System.Windows.Forms.Button TabPageSerial_Btn_SerialUpdate;
        private System.Windows.Forms.ComboBox TabPageSerial_Cbx_SerialCheckBit;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialCheckBit;
        private System.Windows.Forms.ComboBox TabPageSerial_Cbx_SerialStopBit;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialStopBit;
        private System.Windows.Forms.ComboBox TabPageSerial_Cbx_SerialDateBit;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialDateBit;
        private System.Windows.Forms.ComboBox TabPageSerial_Cbx_SerialBaud;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialBaud;
        private System.Windows.Forms.GroupBox TabPageSerial_Gbx_SerialFunction;
        private System.Windows.Forms.GroupBox TabPageSerial_Gbx_Func;
        private System.Windows.Forms.Button TabPageSerial_Btn_Send_Clear;
        private System.Windows.Forms.Button TabPageSerial_Btn_Recv_Clear;
        private System.Windows.Forms.GroupBox TabPageSerial_Gbx_Send;
        private System.Windows.Forms.RadioButton TabPageSerial_Rad_Send_Hex;
        private System.Windows.Forms.RadioButton TabPageSerial_Rad_Send_String;
        private System.Windows.Forms.GroupBox TabPageSerial_Gbx_Recv;
        private System.Windows.Forms.RadioButton TabPageSerial_Rad_Recv_Hex;
        private System.Windows.Forms.RadioButton TabPageSerial_Rad_Recv_String;
        private System.Windows.Forms.GroupBox TabPageSerial_Gbx_SerialInfo;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialTipRecv;
        private System.Windows.Forms.TextBox TabPageSerial_Tbx_SerialTipBaud;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialTipBaud;
        private System.Windows.Forms.TextBox TabPageSerial_Tbx_SerialTipName;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialTipName;
        private System.Windows.Forms.TextBox TabPageSerial_Tbx_SerialTipInfo;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialTipInfo;
        private System.Windows.Forms.GroupBox TabPageSerial_Gbx_SerialSend;
        private System.Windows.Forms.CheckBox TabPageSerial_Cbx_SerialRecvReturn;
        private System.Windows.Forms.Label MasterPC_TabPage_SerialPort_Label_Time;
        private System.Windows.Forms.NumericUpDown TabPageSerial_Nud_SerialTimer;
        private System.Windows.Forms.CheckBox TabPageSerial_Cbx_SerialSendTimer;
        private System.Windows.Forms.Button TabPageSerial_Btn_SerialSend;
        private System.Windows.Forms.TextBox TabPageSerial_Tbx_SerialSend;
        private System.Windows.Forms.GroupBox TabPageSerial_Gbx_SerialRecv;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialRecvSpeed;
        private System.Windows.Forms.TextBox TabPageSerial_Tbx_SerialRecv;
        private System.IO.Ports.SerialPort SerialPortDebug;
        private System.Windows.Forms.Timer SerialTimerSend;
        private System.Windows.Forms.Timer SerialTimerRecvSpeed;
        private System.Windows.Forms.Timer SerialTimerRefresh;
        private System.Windows.Forms.Label TabPageSerial_Lab_SerialTipSend;
        private System.Windows.Forms.GroupBox TabPageCurve_Gbx_SerialCurve;
        private System.Windows.Forms.GroupBox TabPageCurve_Gbx_SerialInfo;
        private System.Windows.Forms.Button TabPageCurve_Btn_ExportData;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialInfoRecv;
        private System.Windows.Forms.TextBox TabPageCurve_Tbx_SerialInfoBaud;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialInfoBaud;
        private System.Windows.Forms.TextBox TabPageCurve_Tbx_SerialInfoName;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialInfoName;
        private System.Windows.Forms.TextBox TabPageCurve_Tbx_SerialInfo;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialInfo;
        private System.Windows.Forms.GroupBox TabPageCurve_Gbx_Function;
        private System.Windows.Forms.Button TabPageCurve_Btn_CurveClear;
        private System.Windows.Forms.Label TabPageCurve_Lab_Curve8;
        private System.Windows.Forms.Label TabPageCurve_Lab_Curve7;
        private System.Windows.Forms.Label TabPageCurve_Lab_Curve6;
        private System.Windows.Forms.Label TabPageCurve_Lab_Curve5;
        private System.Windows.Forms.Label TabPageCurve_Lab_Curve4;
        private System.Windows.Forms.Label TabPageCurve_Lab_Curve3;
        private System.Windows.Forms.Label TabPageCurve_Lab_Curve2;
        private System.Windows.Forms.Label TabPageCurve_Lab_Curve1;
        private System.Windows.Forms.NumericUpDown TabPageCurve_Nud_CurveNum;
        private System.Windows.Forms.Label TabPageCurve_Lab_CurveNum;
        private System.Windows.Forms.CheckBox TabPageCurve_Cbx_Curve8;
        private System.Windows.Forms.CheckBox TabPageCurve_Cbx_Curve7;
        private System.Windows.Forms.CheckBox TabPageCurve_Cbx_Curve6;
        private System.Windows.Forms.CheckBox TabPageCurve_Cbx_Curve5;
        private System.Windows.Forms.CheckBox TabPageCurve_Cbx_Curve4;
        private System.Windows.Forms.CheckBox TabPageCurve_Cbx_Curve3;
        private System.Windows.Forms.CheckBox TabPageCurve_Cbx_Curve2;
        private System.Windows.Forms.CheckBox TabPageCurve_Cbx_Curve1;
        private System.Windows.Forms.GroupBox TabPageCurve_Gbx_SerialConfig;
        private System.Windows.Forms.Button TabPageCurve_Btn_SerialOpen;
        private System.Windows.Forms.Button TabPageCurve_Btn_SerialRefresh;
        private System.Windows.Forms.ComboBox TabPageCurve_Cbx_SerialCheckBit;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialCheckBit;
        private System.Windows.Forms.ComboBox TabPageCurve_Cbx_SerialStopBit;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialStopBit;
        private System.Windows.Forms.ComboBox TabPageCurve_Cbx_SerialDataBit;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialDataBit;
        private System.Windows.Forms.ComboBox TabPageCurve_Cbx_SerialBaud;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialBaud;
        private System.Windows.Forms.ComboBox TabPageCurve_Cbx_SerialName;
        private System.Windows.Forms.Label TabPageCurve_Lab_SerialName;
        private ZedGraph.ZedGraphControl TabPageCurve_Zed_Graph;
        private System.IO.Ports.SerialPort SerialPortCurve;
        private System.Windows.Forms.Timer CurveRefresh;
        private System.Windows.Forms.TabControl TabNet;
        private System.Windows.Forms.TabPage TabPageTCPServer;
        private System.Windows.Forms.TabPage TabPageTCPClient;
        private System.Windows.Forms.TabPage TabPageUDP;
        private System.Windows.Forms.GroupBox TabPageTCPServer_Gbx_NetConfig;
        private System.Windows.Forms.Label TabPageTCPServer_Lab_NetLocalHostIP;
        private System.Windows.Forms.Button TabPageTCPServer_Btn_NetListen;
        private System.Windows.Forms.TextBox TabPageTCPServer_Tbx_NetServerMaxListen;
        private System.Windows.Forms.Label TabPageTCPServer_Lab_NetServerMaxListen;
        private System.Windows.Forms.TextBox TabPageTCPServer_Tbx_NetLocalHostPort;
        private System.Windows.Forms.Label TabPageTCPServer_Lab_NetLocalHostPort;
        private System.Windows.Forms.TextBox TabPageTCPServer_Tbx_NetLocalHostIP;
        private System.Windows.Forms.GroupBox TabPageTCPServer_Gbx_NetFunction;
        private System.Windows.Forms.GroupBox TabPageTCPServer_Gbx_NetFunc;
        private System.Windows.Forms.Button TabPageTCPServer_Btn_NetSendClear;
        private System.Windows.Forms.Button TabPageTCPServer_Btn_NetRecvClear;
        private System.Windows.Forms.GroupBox TabPageTCPServer_Gbx_NetSend;
        private System.Windows.Forms.RadioButton TabPageTCPServer_Rad_NetSendHex;
        private System.Windows.Forms.RadioButton TabPageTCPServer_Rad_NetSendString;
        private System.Windows.Forms.GroupBox TabPageTCPServer_Gbx_NetRecv;
        private System.Windows.Forms.RadioButton TabPageTCPServer_Rad_NetRecvHex;
        private System.Windows.Forms.RadioButton TabPageTCPServer_Rad_NetRecvString;
        private System.Windows.Forms.GroupBox TabPageTCPServer_Gbx_Send;
        private System.Windows.Forms.ComboBox TabPageTCPServer_Cbx_ConnectObject;
        private System.Windows.Forms.Label TabPageTCPServer_Lab_ConnectObject;
        private System.Windows.Forms.Button TabPageTCPServer_Btn_Send;
        private System.Windows.Forms.TextBox TabPageTCPServer_Tbx_Send;
        private System.Windows.Forms.GroupBox TabPageTCPServer_Gbx_Recv;
        private System.Windows.Forms.TextBox TabPageTCPServer_Tbx_Recv;
        private System.Windows.Forms.GroupBox TabPageTCPClient_Gbx_NetConfig;
        private System.Windows.Forms.Button TabPageTCPServer_Btn_NetConnect;
        private System.Windows.Forms.TextBox TabPageTCPClient_Tbx_NetLocalHostPort;
        private System.Windows.Forms.Label TabPageTCPClient_Lab_NetLocalHostPort;
        private System.Windows.Forms.TextBox TabPageTCPClient_Tbx_NetLocalHostIP;
        private System.Windows.Forms.Label TabPageTCPClient_Lab_NetLocalHostIP;
        private System.Windows.Forms.GroupBox TabPageTCPClient_Gbx_Send;
        private System.Windows.Forms.Button TabPageTCPClient_Btn_Send;
        private System.Windows.Forms.TextBox TabPageTCPClient_Tbx_Send;
        private System.Windows.Forms.GroupBox TabPageTCPClient_Gbx_Recv;
        private System.Windows.Forms.TextBox TabPageTCPClient_Tbx_Recv;
        private System.Windows.Forms.GroupBox TabPageTCPClient_Gbx_NetFunction;
        private System.Windows.Forms.GroupBox TabPageTCPClient_Gbx_NetFunc;
        private System.Windows.Forms.Button TabPageTCPClient_Btn_NetSendClear;
        private System.Windows.Forms.Button TabPageTCPClient_Btn_NetRecvClear;
        private System.Windows.Forms.GroupBox TabPageTCPClient_Gbx_NetSend;
        private System.Windows.Forms.RadioButton TabPageTCPClient_Rad_NetSendHex;
        private System.Windows.Forms.RadioButton TabPageTCPClient_Rad_NetSendString;
        private System.Windows.Forms.GroupBox TabPageTCPClient_Gbx_NetRecv;
        private System.Windows.Forms.RadioButton TabPageTCPClient_Rad_NetRecvHex;
        private System.Windows.Forms.RadioButton TabPageTCPClient_Rad_NetRecvString;
        private System.Windows.Forms.GroupBox TabPageUDP_Gbx_NetConfig;
        private System.Windows.Forms.Button TabPageUDP_Btn_NetOpen;
        private System.Windows.Forms.TextBox TabPageUDP_Tbx_NetLocalHostPort;
        private System.Windows.Forms.Label TabPageUDP_Lab_NetLocalHostPort;
        private System.Windows.Forms.TextBox TabPageUDP_Tbx_NetLocalHostIP;
        private System.Windows.Forms.Label TabPageUDP_Lab_NetLocalHostIP;
        private System.Windows.Forms.GroupBox TabPageUDP_Gbx_Send;
        private System.Windows.Forms.TextBox TabPageUDP_Tbx_TargetPort;
        private System.Windows.Forms.Label TabPageUDP_Lab_TargetPort;
        private System.Windows.Forms.TextBox TabPageUDP_Tbx_TargetIP;
        private System.Windows.Forms.Label TabPageUDP_Lab_TargetIP;
        private System.Windows.Forms.Button TabPageUDP_Btn_Send;
        private System.Windows.Forms.TextBox TabPageUDP_Tbx_Send;
        private System.Windows.Forms.GroupBox TabPageUDP_Gbx_Recv;
        private System.Windows.Forms.TextBox TabPageUDP_Tbx_Recv;
        private System.Windows.Forms.GroupBox TabPageUDP_Gbx_NetFunction;
        private System.Windows.Forms.GroupBox TabPageUDP_Gbx_NetFunc;
        private System.Windows.Forms.Button TabPageUDP_Btn_NetSendClear;
        private System.Windows.Forms.Button TabPageUDP_Btn_NetRecvClear;
        private System.Windows.Forms.GroupBox TabPageUDP_Gbx_NetSend;
        private System.Windows.Forms.RadioButton TabPageUDP_Rad_NetSendHex;
        private System.Windows.Forms.RadioButton TabPageUDP_Rad_NetSendString;
        private System.Windows.Forms.GroupBox TabPageUDP_Gbx_NetRecv;
        private System.Windows.Forms.RadioButton TabPageUDP_Rad_NetRecvHex;
        private System.Windows.Forms.RadioButton TabPageUDP_Rad_NetRecvString;
    }
}

