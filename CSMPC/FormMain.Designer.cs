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
            this.TabPageCurve = new System.Windows.Forms.TabPage();
            this.TabPageAnalysis = new System.Windows.Forms.TabPage();
            this.TabPageConsole = new System.Windows.Forms.TabPage();
            this.TabPageHelp = new System.Windows.Forms.TabPage();
            this.TabPageAbout = new System.Windows.Forms.TabPage();
            this.SerialPortDebug = new System.IO.Ports.SerialPort(this.components);
            this.SerialTimerSend = new System.Windows.Forms.Timer(this.components);
            this.SerialTimerRecvSpeed = new System.Windows.Forms.Timer(this.components);
            this.SerialTimerRefresh = new System.Windows.Forms.Timer(this.components);
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
            this.TabPageCurve_Gbx_SerialInfo = new System.Windows.Forms.GroupBox();
            this.TabPageCurve_Lab_SerialInfoRecv = new System.Windows.Forms.Label();
            this.TabPageCurve_Tbx_SerialInfoBaud = new System.Windows.Forms.TextBox();
            this.TabPageCurve_Lab_SerialInfoBaud = new System.Windows.Forms.Label();
            this.TabPageCurve_Tbx_SerialInfoName = new System.Windows.Forms.TextBox();
            this.TabPageCurve_Lab_SerialInfoName = new System.Windows.Forms.Label();
            this.TabPageCurve_Tbx_SerialInfo = new System.Windows.Forms.TextBox();
            this.TabPageCurve_Lab_SerialInfo = new System.Windows.Forms.Label();
            this.TabPageSerial_Lab_SerialTipSend = new System.Windows.Forms.Label();
            this.TabPageCurve_Btn_ExportData = new System.Windows.Forms.Button();
            this.TabPageCurve_Gbx_SerialCurve = new System.Windows.Forms.GroupBox();
            this.TabPageCurve_Zed_Graph = new ZedGraph.ZedGraphControl();
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
            this.TabPageCurve.SuspendLayout();
            this.TabPageCurve_Gbx_SerialConfig.SuspendLayout();
            this.TabPageCurve_Gbx_Function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPageCurve_Nud_CurveNum)).BeginInit();
            this.TabPageCurve_Gbx_SerialInfo.SuspendLayout();
            this.TabPageCurve_Gbx_SerialCurve.SuspendLayout();
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
            this.TabPageNet.Location = new System.Drawing.Point(4, 22);
            this.TabPageNet.Name = "TabPageNet";
            this.TabPageNet.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNet.Size = new System.Drawing.Size(912, 631);
            this.TabPageNet.TabIndex = 1;
            this.TabPageNet.Text = "网络调试";
            this.TabPageNet.UseVisualStyleBackColor = true;
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
            // TabPageSerial_Lab_SerialTipSend
            // 
            this.TabPageSerial_Lab_SerialTipSend.AutoSize = true;
            this.TabPageSerial_Lab_SerialTipSend.Location = new System.Drawing.Point(816, 21);
            this.TabPageSerial_Lab_SerialTipSend.Name = "TabPageSerial_Lab_SerialTipSend";
            this.TabPageSerial_Lab_SerialTipSend.Size = new System.Drawing.Size(53, 12);
            this.TabPageSerial_Lab_SerialTipSend.TabIndex = 10;
            this.TabPageSerial_Lab_SerialTipSend.Text = "已发送:0";
            // 
            // TabPageCurve_Btn_ExportData
            // 
            this.TabPageCurve_Btn_ExportData.Location = new System.Drawing.Point(819, 17);
            this.TabPageCurve_Btn_ExportData.Name = "TabPageCurve_Btn_ExportData";
            this.TabPageCurve_Btn_ExportData.Size = new System.Drawing.Size(75, 23);
            this.TabPageCurve_Btn_ExportData.TabIndex = 12;
            this.TabPageCurve_Btn_ExportData.Text = "导出数据";
            this.TabPageCurve_Btn_ExportData.UseVisualStyleBackColor = true;
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
            // CurveRefresh
            // 
            this.CurveRefresh.Interval = 1;
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
            this.TabPageCurve.ResumeLayout(false);
            this.TabPageCurve_Gbx_SerialConfig.ResumeLayout(false);
            this.TabPageCurve_Gbx_SerialConfig.PerformLayout();
            this.TabPageCurve_Gbx_Function.ResumeLayout(false);
            this.TabPageCurve_Gbx_Function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPageCurve_Nud_CurveNum)).EndInit();
            this.TabPageCurve_Gbx_SerialInfo.ResumeLayout(false);
            this.TabPageCurve_Gbx_SerialInfo.PerformLayout();
            this.TabPageCurve_Gbx_SerialCurve.ResumeLayout(false);
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
    }
}

