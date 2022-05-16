// Decompiled with JetBrains decompiler
// Type: Registry.Login
// Assembly: "Dron's Unlocker", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05A23AB4-AE9D-4CC7-9B58-77B3FAA021E6
// Assembly location: C:\Users\twist\Desktop\Dron's Unlocker_protected_dump.dem.justify.exe

using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Registry
{
  public class Login : Form
  {
    private IContainer components;
    private SiticoneGroupBox siticoneGroupBox1;
    private SiticoneButton siticoneButton1;
    private SiticoneDragControl siticoneDragControl1;
        private WebClient web;
        private WebClient webClient;
        private SiticoneButton siticoneButton3;

    public Login() => this.InitializeComponent();

    private void Login_Load(object sender, EventArgs e)
    {

    }

    private void siticoneButton1_Click(object sender, EventArgs e)
    {
        new Main().Show();
        this.Hide();
    }

    private void siticoneButton3_Click(object sender, EventArgs e) => Application.Exit();

    private void siticoneGroupBox1_Click(object sender, EventArgs e)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.webClient = new System.Net.WebClient();
            this.web = new System.Net.WebClient();
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webClient
            // 
            this.webClient.BaseAddress = "";
            this.webClient.CachePolicy = null;
            this.webClient.Credentials = null;
            this.webClient.Encoding = ((System.Text.Encoding)(resources.GetObject("webClient.Encoding")));
            this.webClient.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("webClient.Headers")));
            this.webClient.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("webClient.QueryString")));
            this.webClient.UseDefaultCredentials = false;
            // 
            // web
            // 
            this.web.BaseAddress = "";
            this.web.CachePolicy = null;
            this.web.Credentials = null;
            this.web.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("web.Headers")));
            this.web.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("web.QueryString")));
            this.web.UseDefaultCredentials = false;
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.siticoneGroupBox1.BorderThickness = 0;
            this.siticoneGroupBox1.Controls.Add(this.siticoneButton3);
            this.siticoneGroupBox1.Controls.Add(this.siticoneButton1);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(324, 167);
            this.siticoneGroupBox1.TabIndex = 0;
            this.siticoneGroupBox1.Text = "Fahv\'s Unlocker Login";
            this.siticoneGroupBox1.Click += new System.EventHandler(this.siticoneGroupBox1_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(271, 3);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(53, 35);
            this.siticoneButton3.TabIndex = 5;
            this.siticoneButton3.Text = "X";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton1.BorderRadius = 4;
            this.siticoneButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(27, 75);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(272, 45);
            this.siticoneButton1.TabIndex = 2;
            this.siticoneButton1.Text = "Load Tool";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticoneGroupBox1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(325, 171);
            this.Controls.Add(this.siticoneGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

    }
  }
}
