namespace SmartPing_v1._0._0
{
    partial class SmartPing
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartPing));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFolderBTN = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.startPing = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.sendCheckBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectCommandBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.ComboBox();
            this.minute = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeleftView = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.emailTo = new System.Windows.Forms.TextBox();
            this.emailFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveToText = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSetTime = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alarmOn = new System.Windows.Forms.CheckBox();
            this.rbTimerElapse = new System.Windows.Forms.RadioButton();
            this.rbPingSuccess = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.trayMenu1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFolderBTN
            // 
            this.openFolderBTN.Location = new System.Drawing.Point(319, 201);
            this.openFolderBTN.Name = "openFolderBTN";
            this.openFolderBTN.Size = new System.Drawing.Size(60, 27);
            this.openFolderBTN.TabIndex = 5;
            this.openFolderBTN.Text = "Open";
            this.openFolderBTN.UseVisualStyleBackColor = true;
            this.openFolderBTN.Click += new System.EventHandler(this.openFolderBTN_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FolderPath.Location = new System.Drawing.Point(25, 201);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(288, 27);
            this.FolderPath.TabIndex = 4;
            this.FolderPath.Text = "C:\\temp";
            // 
            // startPing
            // 
            this.startPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPing.Location = new System.Drawing.Point(716, 405);
            this.startPing.Name = "startPing";
            this.startPing.Size = new System.Drawing.Size(135, 49);
            this.startPing.TabIndex = 18;
            this.startPing.Text = "Start process";
            this.startPing.UseVisualStyleBackColor = true;
            this.startPing.Click += new System.EventHandler(this.startPing_Click);
            // 
            // ip
            // 
            this.ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ip.Location = new System.Drawing.Point(71, 80);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(163, 27);
            this.ip.TabIndex = 2;
            this.ip.TextChanged += new System.EventHandler(this.ip_TextChanged);
            this.ip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ip:";
            // 
            // pingTimer
            // 
            this.pingTimer.Tick += new System.EventHandler(this.pingT);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select destination folder";
            // 
            // sendCheckBox1
            // 
            this.sendCheckBox1.AutoSize = true;
            this.sendCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendCheckBox1.Location = new System.Drawing.Point(526, 178);
            this.sendCheckBox1.Name = "sendCheckBox1";
            this.sendCheckBox1.Size = new System.Drawing.Size(284, 24);
            this.sendCheckBox1.TabIndex = 11;
            this.sendCheckBox1.Text = "Send log via email after time ends";
            this.sendCheckBox1.UseVisualStyleBackColor = true;
            this.sendCheckBox1.CheckedChanged += new System.EventHandler(this.sendCheckBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 262);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(500, 202);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseEnter += new System.EventHandler(this.richTextBox1_MouseEnter);
            this.richTextBox1.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Results";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(14, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Hours:";
            // 
            // selectCommandBox
            // 
            this.selectCommandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCommandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectCommandBox.Items.AddRange(new object[] {
            "Ping",
            "Shutdown",
            "Restart"});
            this.selectCommandBox.Location = new System.Drawing.Point(126, 28);
            this.selectCommandBox.Name = "selectCommandBox";
            this.selectCommandBox.Size = new System.Drawing.Size(108, 28);
            this.selectCommandBox.TabIndex = 1;
            this.selectCommandBox.SelectedIndexChanged += new System.EventHandler(this.selectCommandBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(21, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Command:";
            // 
            // hour
            // 
            this.hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hour.FormattingEnabled = true;
            this.hour.Location = new System.Drawing.Point(80, 58);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(51, 28);
            this.hour.TabIndex = 8;
            this.hour.SelectedIndexChanged += new System.EventHandler(this.hour_SelectedIndexChanged);
            // 
            // minute
            // 
            this.minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minute.FormattingEnabled = true;
            this.minute.Location = new System.Drawing.Point(231, 58);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(51, 28);
            this.minute.TabIndex = 9;
            this.minute.SelectedIndexChanged += new System.EventHandler(this.minute_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(152, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Minutes:";
            // 
            // second
            // 
            this.second.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.second.FormattingEnabled = true;
            this.second.Location = new System.Drawing.Point(388, 58);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(51, 28);
            this.second.TabIndex = 10;
            this.second.SelectionChangeCommitted += new System.EventHandler(this.second_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(303, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Seconds:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeleftView);
            this.groupBox1.Controls.Add(this.second);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.minute);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.hour);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(551, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // timeleftView
            // 
            this.timeleftView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.timeleftView.AutoSize = true;
            this.timeleftView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeleftView.Location = new System.Drawing.Point(155, 20);
            this.timeleftView.Margin = new System.Windows.Forms.Padding(0);
            this.timeleftView.Name = "timeleftView";
            this.timeleftView.Size = new System.Drawing.Size(141, 36);
            this.timeleftView.TabIndex = 47;
            this.timeleftView.Text = "00:00:00";
            this.timeleftView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(64, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Port:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(115, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 27);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "smtp.xxx.cz";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(56, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Smtp:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(327, 62);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 24);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "SSL";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // emailTo
            // 
            this.emailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTo.Location = new System.Drawing.Point(115, 58);
            this.emailTo.Name = "emailTo";
            this.emailTo.Size = new System.Drawing.Size(184, 27);
            this.emailTo.TabIndex = 14;
            this.emailTo.Text = "xxx@seznam.cz";
            // 
            // emailFrom
            // 
            this.emailFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailFrom.Location = new System.Drawing.Point(115, 21);
            this.emailFrom.Name = "emailFrom";
            this.emailFrom.Size = new System.Drawing.Size(184, 27);
            this.emailFrom.TabIndex = 13;
            this.emailFrom.Text = "xxx@seznam.cz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(76, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(56, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "From:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.emailTo);
            this.groupBox2.Controls.Add(this.emailFrom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(551, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 191);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email";
            // 
            // saveToText
            // 
            this.saveToText.AutoSize = true;
            this.saveToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveToText.Location = new System.Drawing.Point(46, 126);
            this.saveToText.Name = "saveToText";
            this.saveToText.Size = new System.Drawing.Size(141, 24);
            this.saveToText.TabIndex = 3;
            this.saveToText.Text = "Save to log file";
            this.saveToText.UseVisualStyleBackColor = true;
            this.saveToText.CheckedChanged += new System.EventHandler(this.saveToText_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tray
            // 
            this.Tray.ContextMenuStrip = this.trayMenu1;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_MouseDoubleClick);
            this.Tray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tray_MouseMove);
            // 
            // trayMenu1
            // 
            this.trayMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayMenu1.Name = "contextMenuStrip1";
            this.trayMenu1.Size = new System.Drawing.Size(115, 52);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkSetTime
            // 
            this.checkSetTime.AutoSize = true;
            this.checkSetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkSetTime.Location = new System.Drawing.Point(526, 20);
            this.checkSetTime.Name = "checkSetTime";
            this.checkSetTime.Size = new System.Drawing.Size(99, 24);
            this.checkSetTime.TabIndex = 6;
            this.checkSetTime.Text = "Set timer";
            this.checkSetTime.UseVisualStyleBackColor = true;
            this.checkSetTime.CheckedChanged += new System.EventHandler(this.checkSetTime_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 25);
            this.panel1.TabIndex = 43;
            // 
            // alarmOn
            // 
            this.alarmOn.AutoSize = true;
            this.alarmOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alarmOn.Location = new System.Drawing.Point(347, 40);
            this.alarmOn.Name = "alarmOn";
            this.alarmOn.Size = new System.Drawing.Size(75, 24);
            this.alarmOn.TabIndex = 44;
            this.alarmOn.Text = "Alarm";
            this.alarmOn.UseVisualStyleBackColor = true;
            this.alarmOn.CheckedChanged += new System.EventHandler(this.alarmOn_CheckedChanged);
            // 
            // rbTimerElapse
            // 
            this.rbTimerElapse.AutoSize = true;
            this.rbTimerElapse.Location = new System.Drawing.Point(26, 58);
            this.rbTimerElapse.Name = "rbTimerElapse";
            this.rbTimerElapse.Size = new System.Drawing.Size(111, 21);
            this.rbTimerElapse.TabIndex = 45;
            this.rbTimerElapse.TabStop = true;
            this.rbTimerElapse.Text = "Timer elapse";
            this.rbTimerElapse.UseVisualStyleBackColor = true;
            this.rbTimerElapse.CheckedChanged += new System.EventHandler(this.rbTimerElapse_CheckedChanged);
            // 
            // rbPingSuccess
            // 
            this.rbPingSuccess.AutoSize = true;
            this.rbPingSuccess.Location = new System.Drawing.Point(26, 31);
            this.rbPingSuccess.Name = "rbPingSuccess";
            this.rbPingSuccess.Size = new System.Drawing.Size(112, 21);
            this.rbPingSuccess.TabIndex = 46;
            this.rbPingSuccess.TabStop = true;
            this.rbPingSuccess.Text = "Ping success";
            this.rbPingSuccess.UseVisualStyleBackColor = true;
            this.rbPingSuccess.CheckedChanged += new System.EventHandler(this.rbPingSuccess_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbTimerElapse);
            this.groupBox3.Controls.Add(this.rbPingSuccess);
            this.groupBox3.Location = new System.Drawing.Point(305, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 91);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alarm settings";
            // 
            // SmartPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1049, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.alarmOn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkSetTime);
            this.Controls.Add(this.saveToText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.selectCommandBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sendCheckBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.startPing);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.openFolderBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SmartPing";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartPing";
            this.Load += new System.EventHandler(this.SmartPing_Load);
            this.Click += new System.EventHandler(this.SmartPing_Click);
            this.Move += new System.EventHandler(this.SmartPing_Move);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.trayMenu1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button openFolderBTN;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button startPing;
        private System.Windows.Forms.Timer pingTimer;
        private System.Windows.Forms.CheckBox sendCheckBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectCommandBox;
        private System.Windows.Forms.ComboBox second;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox minute;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox hour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox emailTo;
        private System.Windows.Forms.TextBox emailFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox saveToText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip trayMenu1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkSetTime;
        private System.Windows.Forms.Label timeleftView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox alarmOn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbTimerElapse;
        private System.Windows.Forms.RadioButton rbPingSuccess;
    }
}

