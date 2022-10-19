using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using SmartPing_v1._0._0.Properties;
using System.Reflection;

namespace SmartPing_v1._0._0
{
    public partial class SmartPing : Form
    {
        TimeSpan time = new TimeSpan();
        int h, m, s;
        private bool isClicked = false;
        private int _hour = 0;
        private int _minute = 0;
        private int _second = 0;



        string hour1 = "00";
        string minute1 = "00";
        string second1 = "00";

        #region PC INFO
        public static string hostName;
        public string ipaddress;

        #endregion

        public SmartPing()
        {
            InitializeComponent();

            ip.GotFocus += ip_GotFocus;
            ip.LostFocus += ip_LostFocus;

            
            
            foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
            {
               // gb.Paint += groupBox1_Paint;
            }
        }
        public string eFrom;
        private string eTo;
        protected string defaultIp = "8.8.8.8";
        private string _ip;
        private void SmartPing_Load(object sender, EventArgs e)
        {
            

            groupBox3.Enabled = false;
            //selectCommandBox.KeyDown += new KeyEventHandler(selectCommandBox_KeyDown);
            this.selectCommandBox.KeyDown +=
                  new System.Windows.Forms.KeyEventHandler(this.selectCommandBox_KeyDown);
            this.hour.KeyDown +=
                  new System.Windows.Forms.KeyEventHandler(this.hour_KeyDown);
            this.minute.KeyDown +=
                  new System.Windows.Forms.KeyEventHandler(this.selectCommandBox_KeyDown);
            this.second.KeyDown +=
                  new System.Windows.Forms.KeyEventHandler(this.selectCommandBox_KeyDown);
            for (int x = 0; x < 24; x++)
            {
                hour.Items.Add(x.ToString());
            }
                for (int i = 0; i < 60; i++)
            {
                
                minute.Items.Add(i.ToString());
                second.Items.Add(i.ToString());
            }
            selectCommandBox.SelectedItem = "Ping";
            hour.SelectedItem = "0";
            minute.SelectedItem = "0";
            second.SelectedItem = "0";



            

            groupBox1.Enabled = false;
            //timeleftView.Enabled = true;
            groupBox2.Enabled = false;

            eFrom += emailFrom.Text;
            eTo += emailTo.Text;
            
            ip.Text = defaultIp;
            ip.ForeColor = Color.Gray;
            
            _ip = ip.Text;
            
            FolderPath.Text = @"C:\temp";

            

            saveToText.Checked = false;
            FolderPath.Enabled = false;
            openFolderBTN.Enabled = false;

            ipaddress = GetLocalIPAddress();
            hostName = System.Net.Dns.GetHostName();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }


        public static string _destPath;
        private void openFolderBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath.Text = dialog.SelectedPath;
                _destPath = dialog.SelectedPath;
                //_destPath = @"c:\temp";
            }
            else
            {
                _destPath = FolderPath.Text;
            }
        }
        private string dirPath;
        private void sendCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sendCheckBox1.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            else if (sendCheckBox1.Checked == false)
            {
                groupBox2.Enabled = false;
            }
        }
        private void saveToText_CheckedChanged(object sender, EventArgs e)
        {
            
            if (saveToText.Checked == true)
            {
                FolderPath.Enabled = true;
                openFolderBTN.Enabled = true;
                _destPath = FolderPath.Text;

            }
            else if (saveToText.Checked == false)
            {
                FolderPath.Enabled = false;
                openFolderBTN.Enabled = false;
                //_destPath = FolderPath.Text;
            }
        }

        private void selectCommandBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sendCheckBox1.Checked = false)
            {
                _destPath = FolderPath.Text;
            }
            
            if(selectCommandBox.SelectedItem == "Ping")
            {
                
            }
        }
        
        public void SendEmail()
        {
            string _Path = dirPath + "ping.txt";
            MessageBox.Show(_Path);
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(emailFrom.Text);

                message.To.Add(new MailAddress(emailTo.Text));
                message.Subject = hostName + " - " + ipaddress;
                message.IsBodyHtml = true; //to make message body as html  
                //message.Body = "Testttttt";
                message.Attachments.Add(new Attachment(_Path));

                smtp.Port = 25;
                smtp.Host = "smtp.seznam.cz"; //for gmail host  
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("", ""); //user & password
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                smtp.Send(message);
                MessageBox.Show("Sent successfully", "Done");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Something wrong \n" + ex.InnerException.Message, "Error");
            }
        }
        private bool textChanged = false;
        
        private void ip_GotFocus(object sender, EventArgs e)
        {
            ip.ForeColor = Color.Black;
            
                if (textChanged == true && ip.Text == defaultIp)
                {

                    ip.ForeColor = Color.Black;
                    ip.Text = "";
                }
                else if (textChanged == true && ip.Text != defaultIp)
                {

                    ip.ForeColor = Color.Black;

                }
            
        }

        private void ip_LostFocus(object sender, EventArgs e)
        {
           
            if (ip.Text == "")
            {
                ip.ForeColor = Color.Gray;
                ip.Text = defaultIp;
                
            }
       
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') == 4)
            {
                e.Handled = true;
            }
        }

        private void SmartPing_Click(object sender, EventArgs e)
        {

            
                //ip.Enabled = false;
                ip_LostFocus(sender, e);
               // ip.Enabled = true;
            
            


        }

        private void ip_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }

        private string output;
      
        private int secondCount;
        private void PingIp()
        {
            this.Player.Stop();
            pingTimer.Start();
            pingTimer.Interval = 1000;
            secondCount++;
            
            Ping ping = new Ping();
            try
            {
                PingReply pingreply = ping.Send(ip.Text);
                string dt = DateTime.Now.ToString();
                try
                {
                    output = String.Format("{0:G}", dt) + " - Reply from " + "[" + pingreply.Address.ToString() + "]"
                              + "  time=" + pingreply.RoundtripTime.ToString() + "ms" + " TTL=" + pingreply.Options.Ttl + "\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                if (pingreply.Status.ToString() == "Success")
                {
                    
                    if (alarmOn.Checked == true)
                    {
                        if (rbPingSuccess.Checked == true)
                        {
                            
                            Player = new SoundPlayer(Properties.Resources._104506550_2);
                            Player.PlayLooping();
                        }
                        else if (rbTimerElapse.Checked == true)
                        {
                            

                            if(checkSetTime.Checked == true && totalSeconds == 0)
                            {
                                Player = new SoundPlayer(Properties.Resources._104506550_2);
                                Player.PlayLooping();
                            }
                        }

                    }
                    else { }
                    //richTextBox1 = "Ping to " + ip.Text.ToString() + "\n";
                    richTextBox1.AppendText(output);
                    

                    string textPath = FolderPath.Text + @"\ping.txt";


                    StreamWriter File = new StreamWriter(textPath, true);


                    File.WriteLine(output);
                    File.Close();

                    // return;
                    
                }
                else
                {
                    richTextBox1.AppendText("Request timed out." + "\n");
                }

            }
            catch(PingException e)
            {
                richTextBox1.AppendText("Request timed out." + "\n");

            }
            richTextBox1.ScrollToCaret();
        }

        private void pingT(object sender, EventArgs e)
        {
            PingIp();
            //MessageBox.Show("test");
        
        }


      

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            
            label9.Focus();
        }

        System.Windows.Forms.Timer timerr;
        private int totalMinutes;
        private int totalSeconds;
        private void timer1_Tick(object sender, EventArgs e)
        {

            //_second = _second - 1;
            if (checkSetTime.Checked == true)
            {
                groupBox1.Enabled = true;

                if (totalSeconds > 0)
                {
                    groupBox1.Enabled = false;
                    timeleftView.Enabled = true;
                    //groupBox2.Enabled = false;
                    selectCommandBox.Enabled = false;
                    hour.Enabled = false;
                    minute.Enabled = false;
                    second.Enabled = false;
                    saveToText.Enabled = false;
                    sendCheckBox1.Enabled = false;
                    checkSetTime.Enabled = false;
                    FolderPath.Enabled = false;
                    ip.Enabled = false;
                    openFolderBTN.Enabled = false;

                    totalSeconds--;

                    int hours = totalSeconds / 3600;

                    int minutes = totalSeconds / 60;

                    int seconds = totalSeconds - (minutes * 60) - (hours * 3600);

                    time = TimeSpan.FromSeconds(totalSeconds);

                    this.timeleftView.Text = time.ToString(@"hh\:mm\:ss");
                    Tray.Text = "SmartPing\n" + "Remaining time: " + timeleftView.Text;

                    //dirPath = _destPath + @"\" + date + @"\";

                    /*You need the line: DestroyIcon(hIcon) to prevent the app from quitting after about 50 minutes due to a memory leak.*/
                }
                else if (totalSeconds == 0)
                {

                    pingTimer.Stop();
                    timer1.Stop();
                    this.Show();
                    startPing.Text = "Start process";
                    richTextBox1.AppendText("Process stopped.");
                    this.WindowState = FormWindowState.Normal;
                    if (saveToText.Checked == true)
                    {
                            FolderPath.Enabled = true;
                            File.Copy(_destPath + @"\" + "ping.txt", dirPath + "ping.txt");
                            File.Delete(_destPath + @"\ping.txt");
                           
                        //FolderPath.Text = dirPath.ToString() + "ping.txt";
                    }
                    else
                    {
                        FolderPath.Enabled = false;
                    }
                    if (sendCheckBox1.Checked == true)
                    {
                        groupBox2.Enabled = true;
                        SendEmail();
                    }
                    else
                    {
                        groupBox2.Enabled = false;
                    }
                    //rand123321 @seznam.cz

                    ip.Enabled = true;
                    groupBox1.Enabled = true;
                    
                    selectCommandBox.Enabled = true;
                    hour.Enabled = true;
                    minute.Enabled = true;
                    second.Enabled = true;
                    saveToText.Enabled = true;
                    sendCheckBox1.Enabled = true;
                    checkSetTime.Enabled = true;
                    
                    openFolderBTN.Enabled = true;
                    startPing.Enabled = false;
                    startPing.Enabled = true;

                    clickCounter = 0;
                    Tray.Visible = false;

                    MessageBox.Show("Done");

                    Player.Stop();
                }
            }
            else
            {
                groupBox1.Enabled = false;
            }
            

        }
        private void second_SelectedIndexChanged(object sender, EventArgs e)
        {
            second1 = second.SelectedIndex.ToString();
            //timeleftView.Text = "00:00:00";
            if (second.SelectedIndex > -1)
            {
                if (second.SelectedIndex < 10)
                {
                    second1 = string.Format("0{0}", second.SelectedIndex.ToString());
                    //MessageBox.Show(second1);

                }
                else if (second.SelectedIndex >= 10)
                {
                    second1 = string.Format("{0}", second.SelectedIndex.ToString());
                    //MessageBox.Show(second1);

                }

                timeleftView.Text = String.Format("{0}:{1}:{2}", hour1, minute1, second1);
            }
        }
        private void minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            minute1 = minute.SelectedIndex.ToString();
            
            //timeleftView.Text = "00:00:00";
            if (minute.SelectedIndex > -1)
            {
                if (minute.SelectedIndex < 10)
                {
                    minute1 = string.Format("0{0}", minute.SelectedIndex.ToString());
                    //MessageBox.Show(second1);

                }
                else if (minute.SelectedIndex >= 10)
                {
                    minute1 = string.Format("{0}", minute.SelectedIndex.ToString());
                    //MessageBox.Show(second1);

                }

                timeleftView.Text = String.Format("{0}:{1}:{2}", hour1, minute1, second1);
            }

        }

        private void hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            hour1 = hour.SelectedIndex.ToString();
            //timeleftView.Text = "00:00:00";
            if (hour.SelectedIndex > -1)
            {
                if (hour.SelectedIndex < 10)
                {
                    hour1 = string.Format("0{0}", hour.SelectedIndex.ToString());
                    //MessageBox.Show(second1);

                }
                else if (hour.SelectedIndex >= 10)
                {
                    hour1 = string.Format("{0}", hour.SelectedIndex.ToString());
                    //MessageBox.Show(second1);

                }

                timeleftView.Text = String.Format("{0}:{1}:{2}", hour1, minute1, second1);
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void SmartPing_Move(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                Tray.Visible = true;
                

            }
        }

        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Tray.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkSetTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSetTime.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else if (checkSetTime.Checked == false)
            {
                groupBox1.Enabled = false;
                timeleftView.Text = "00:00:00";
            }
        }
        int countKeyDown = 0;
        private void selectCommandBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space && countKeyDown == 0)
            {

                countKeyDown = 1;
                selectCommandBox.DroppedDown = true;

            }
            else if (e.KeyCode == Keys.Space && countKeyDown == 1)
            {
                countKeyDown = 0;
                selectCommandBox.DroppedDown = false;
                
                
            }
            
            
        }
        int countKeyDownA = 0;
        int countKeyDownB = 0;
        int countKeyDownC = 0;
        private void hour_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space && countKeyDownA == 0)
            {

                countKeyDownA = 1;
                hour.DroppedDown = true;

            }
            else if (e.KeyCode == Keys.Space && countKeyDownA == 1)
            {
                countKeyDownA = 0;
                hour.DroppedDown = false;


            }
        }

        private void minute_KeyDown(object sender, KeyEventArgs e)
        {
            
          /*  if (e.KeyCode == Keys.Space && countKeyDownB == 0)
            {

                countKeyDownB = 1;
                minute.DroppedDown = true;

            }
            else if (e.KeyCode == Keys.Space && countKeyDownB == 1)
            {
                countKeyDownB = 0;
                minute.DroppedDown = false;


            }*/
        }

        private void second_KeyDown(object sender, KeyEventArgs e)
        {
            
           /* if (e.KeyCode == Keys.Space && countKeyDownC == 0)
            {

                countKeyDownC = 1;
                second.DroppedDown = true;

            }
            else if (e.KeyCode == Keys.Space && countKeyDownC == 1)
            {
                countKeyDownC = 0;
                second.DroppedDown = false;


            }*/
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Tray_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (clickCounter < 2)
            {
                Tray.Text = "SmartPing\n" + "Process started";
            }else
            if (checkSetTime.Checked == false | clickCounter >= 2)
            {
                Tray.Text = "SmartPing\n" + "Non-active";
            }*/
            
        }
        private SoundPlayer Player = new SoundPlayer();
        

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.Stop();   
        }

        private void rbTimerElapse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTimerElapse.Checked == true)
                rbPingSuccess.Checked = false;
        }

        private void rbPingSuccess_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPingSuccess.Checked == true)
                rbTimerElapse.Checked = false;
        }

        private void alarmOn_CheckedChanged(object sender, EventArgs e)
        {
            if (alarmOn.Checked == true)
            {
                groupBox3.Enabled = true;
                rbPingSuccess.Checked = true;
            }else if(alarmOn.Checked == false)
            {
                groupBox3.Enabled = false;
                rbPingSuccess.Checked = false;
                rbTimerElapse.Checked = false;
            }
        }

        private int clickCounter = 0;
        private void startPing_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            timer1.Interval = 1000;
            clickCounter++;

            int hours = Int32.Parse(this.hour.SelectedIndex.ToString());
            
            int minutes = Int32.Parse(this.minute.SelectedIndex.ToString());
            int seconds = Int32.Parse(this.second.SelectedIndex.ToString());

          
            totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            
            if (clickCounter == 1)
            {
                



                File.Delete(FolderPath.Text + @"\ping.txt");
                selectCommandBox.Enabled = false;
                hour.Enabled = false;
                minute.Enabled = false;
                second.Enabled = false;
                saveToText.Enabled = false;
                sendCheckBox1.Enabled = false;
                checkSetTime.Enabled = false;
                ip.Enabled = false;
                FolderPath.Enabled = false;
                openFolderBTN.Enabled = false;
                groupBox1.Enabled = false;
                alarmOn.Enabled = false;
                if (sendCheckBox1.Checked == true)
                {
                    groupBox2.Enabled = false;
                    
                }
                timeleftView.Enabled = true;
                //ip.Enabled = false;

                startPing.Text = "Stop process";
                richTextBox1.Text = "Pinging to " + ip.Text.ToString() + "\n";
                PingIp();

                string date = DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss");
                if (saveToText.Checked == true)
                {

                   

                    dirPath = _destPath + @"\" + date + @"\";
                    
                  

                    Directory.CreateDirectory(dirPath);


                }
                else
                {

                }
                
            
            }
            else if (clickCounter >= 2)
            {
                pingTimer.Stop();
                Player.Stop();
                checkSetTime.Focus();
                clickCounter = 0;

                



                if (saveToText.Checked == true)
                {
                    FolderPath.Enabled = true;
                    File.Copy(_destPath + @"\" +"ping.txt", dirPath + "ping.txt");
                    File.Delete(_destPath + @"\ping.txt");

                    //FolderPath.Text = dirPath.ToString() + "ping.txt";


                }
                else
                {
                    FolderPath.Enabled = false;
                }
                if(checkSetTime.Checked == true)
                {
                    groupBox1.Enabled = true;
                }
                else
                {
                    groupBox1.Enabled = false;
                }

                if (sendCheckBox1.Checked == true)
                {
                    groupBox2.Enabled = true;
                    timer1.Stop();
                    SendEmail();

                    /*if (!backgroundWorker1.IsBusy)
                    {
                        _inputParameter.Delay = 100;
                        _inputParameter.Process = 10;
                        backgroundWorker1.RunWorkerAsync(_inputParameter);
                    }*/

                }
                else
                {
                    groupBox2.Enabled = false;
                }
                
                
                timer1.Stop();
                richTextBox1.AppendText("Process stopped.");

                startPing.Text = "Start process";
                selectCommandBox.Enabled = true;
                hour.Enabled = true;
                minute.Enabled = true;
                second.Enabled = true;
                saveToText.Enabled = true;
                sendCheckBox1.Enabled = true;
                checkSetTime.Enabled = true;
                ip.Enabled = true;
                startPing.Enabled = false;
                startPing.Enabled = true;
                //FolderPath.Enabled = true;
                openFolderBTN.Enabled = true;
                alarmOn.Enabled = true;
                //timeleftView.Enabled = false;


                //groupBox2.Enabled = true;

            }
            
        }
    }
}
