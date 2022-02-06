using System;
using System.ComponentModel;
using System.Drawing;
using System.Management;
using System.Net;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class settingslockedserials : Form
	{
		private static string dashboard;

		private static string green;

		private IContainer dashboard = AssistantHelper.dashboard;

		private SiticoneGroupBox keyoutput;

		private Label label1;

		private SiticoneTextBox ipr;

		private SiticoneTextBox hwidr;

		private Label label2;

		private Label label5;

		private SiticoneTextBox windowsa;

		private Label label4;

		private SiticoneTextBox cpureturn;

		private Label label3;

		private SiticoneTextBox pcname;

		public settingslockedserials()
		{
			this.MainLoad();
		}

		public string MainLoad()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		private void settingslockedserialsLoad(object sender, EventArgs param_539)
		{
			try
			{
				hwidr.Text = WindowsIdentity.GetCurrent().User.Value;
				ipr.Text = this.MainLoad();
			}
			catch (Exception)
			{
				hwidr.Text = "Failed to load HWID";
				ipr.Text = "Failed to load IP";
			}
			ManagementObjectCollection managementObjectCollection = TreeNodeCollection.dashboard;
			foreach (ManagementObject item in new ManagementObjectSearcher("Select * From Win32_processor").Get())
			{
				settingslockedserials.dashboard = (IContainer)(object)item["ProcessorID"].ToString();
				green = ((string)(object)settingslockedserials.dashboard).Substring(((string)(object)settingslockedserials.dashboard).Length - 10);
			}
			cpureturn.Text = green;
			pcname.Text = Dns.GetHostName();
			windowsa.Text = new ComputerInfo().OSFullName + " (" + new ComputerInfo().OSVersion + ")";
		}

		private void bsClick(object sender, EventArgs param_541)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			keyoutput = new SiticoneGroupBox();
			label5 = new Label();
			windowsa = new SiticoneTextBox();
			label4 = new Label();
			cpureturn = new SiticoneTextBox();
			label3 = new Label();
			pcname = new SiticoneTextBox();
			label2 = new Label();
			ipr = new SiticoneTextBox();
			hwidr = new SiticoneTextBox();
			label1 = new Label();
			keyoutput.SuspendLayout();
			SuspendLayout();
			keyoutput.BorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.Controls.Add(label5);
			keyoutput.Controls.Add(windowsa);
			keyoutput.Controls.Add(label4);
			keyoutput.Controls.Add(cpureturn);
			keyoutput.Controls.Add(label3);
			keyoutput.Controls.Add(pcname);
			keyoutput.Controls.Add(label2);
			keyoutput.Controls.Add(ipr);
			keyoutput.Controls.Add(hwidr);
			keyoutput.Controls.Add(label1);
			keyoutput.CustomBorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			keyoutput.Font = new Font("Segoe UI", 9f);
			keyoutput.ForeColor = Color.FromArgb(125, 137, 149);
			keyoutput.Location = new Point(12, 12);
			keyoutput.Name = "keyoutput";
			keyoutput.ShadowDecoration.Parent = keyoutput;
			keyoutput.Size = new Size(630, 547);
			keyoutput.TabIndex = 99;
			keyoutput.Text = "Super Spoofer Locked Serials";
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.White;
			label5.Location = new Point(15, 165);
			label5.Name = "label5";
			label5.Size = new Size(124, 13);
			label5.TabIndex = 106;
			label5.Text = "Windows Information:";
			windowsa.BorderColor = Color.FromArgb(79, 84, 103);
			windowsa.Cursor = Cursors.No;
			windowsa.DefaultText = "";
			windowsa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			windowsa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			windowsa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			windowsa.DisabledState.Parent = windowsa;
			windowsa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			windowsa.FillColor = Color.FromArgb(25, 26, 30);
			windowsa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			windowsa.FocusedState.Parent = windowsa;
			windowsa.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			windowsa.HoveredState.Parent = windowsa;
			windowsa.Location = new Point(18, 181);
			windowsa.Name = "windowsa";
			windowsa.PasswordChar = '\0';
			windowsa.PlaceholderText = "";
			windowsa.ReadOnly = true;
			windowsa.SelectedText = "";
			windowsa.ShadowDecoration.Parent = windowsa;
			windowsa.Size = new Size(599, 30);
			windowsa.TabIndex = 105;
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(318, 106);
			label4.Name = "label4";
			label4.Size = new Size(32, 13);
			label4.TabIndex = 104;
			label4.Text = "CPU:";
			cpureturn.BorderColor = Color.FromArgb(79, 84, 103);
			cpureturn.Cursor = Cursors.No;
			cpureturn.DefaultText = "";
			cpureturn.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			cpureturn.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			cpureturn.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			cpureturn.DisabledState.Parent = cpureturn;
			cpureturn.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			cpureturn.FillColor = Color.FromArgb(25, 26, 30);
			cpureturn.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			cpureturn.FocusedState.Parent = cpureturn;
			cpureturn.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			cpureturn.HoveredState.Parent = cpureturn;
			cpureturn.Location = new Point(321, 122);
			cpureturn.Name = "cpureturn";
			cpureturn.PasswordChar = '\0';
			cpureturn.PlaceholderText = "";
			cpureturn.ReadOnly = true;
			cpureturn.SelectedText = "";
			cpureturn.ShadowDecoration.Parent = cpureturn;
			cpureturn.Size = new Size(296, 30);
			cpureturn.TabIndex = 103;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(15, 106);
			label3.Name = "label3";
			label3.Size = new Size(44, 13);
			label3.TabIndex = 102;
			label3.Text = "Device:";
			pcname.BorderColor = Color.FromArgb(79, 84, 103);
			pcname.Cursor = Cursors.No;
			pcname.DefaultText = "";
			pcname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			pcname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			pcname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			pcname.DisabledState.Parent = pcname;
			pcname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			pcname.FillColor = Color.FromArgb(25, 26, 30);
			pcname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			pcname.FocusedState.Parent = pcname;
			pcname.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			pcname.HoveredState.Parent = pcname;
			pcname.Location = new Point(18, 122);
			pcname.Name = "pcname";
			pcname.PasswordChar = '\0';
			pcname.PlaceholderText = "";
			pcname.ReadOnly = true;
			pcname.SelectedText = "";
			pcname.ShadowDecoration.Parent = pcname;
			pcname.Size = new Size(295, 30);
			pcname.TabIndex = 101;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(318, 51);
			label2.Name = "label2";
			label2.Size = new Size(54, 13);
			label2.TabIndex = 100;
			label2.Text = "IP Saved:";
			ipr.BorderColor = Color.FromArgb(79, 84, 103);
			ipr.Cursor = Cursors.No;
			ipr.DefaultText = "";
			ipr.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			ipr.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			ipr.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			ipr.DisabledState.Parent = ipr;
			ipr.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			ipr.FillColor = Color.FromArgb(25, 26, 30);
			ipr.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			ipr.FocusedState.Parent = ipr;
			ipr.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			ipr.HoveredState.Parent = ipr;
			ipr.Location = new Point(321, 67);
			ipr.Name = "ipr";
			ipr.PasswordChar = '\0';
			ipr.PlaceholderText = "";
			ipr.ReadOnly = true;
			ipr.SelectedText = "";
			ipr.ShadowDecoration.Parent = ipr;
			ipr.Size = new Size(296, 30);
			ipr.TabIndex = 99;
			ipr.TextChanged += bsClick;
			hwidr.BorderColor = Color.FromArgb(79, 84, 103);
			hwidr.Cursor = Cursors.No;
			hwidr.DefaultText = "";
			hwidr.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			hwidr.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			hwidr.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			hwidr.DisabledState.Parent = hwidr;
			hwidr.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			hwidr.FillColor = Color.FromArgb(25, 26, 30);
			hwidr.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			hwidr.FocusedState.Parent = hwidr;
			hwidr.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			hwidr.HoveredState.Parent = hwidr;
			hwidr.Location = new Point(17, 67);
			hwidr.Name = "hwidr";
			hwidr.PasswordChar = '\0';
			hwidr.PlaceholderText = "";
			hwidr.ReadOnly = true;
			hwidr.SelectedText = "";
			hwidr.ShadowDecoration.Parent = hwidr;
			hwidr.Size = new Size(296, 30);
			hwidr.TabIndex = 98;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(14, 51);
			label1.Name = "label1";
			label1.Size = new Size(77, 13);
			label1.TabIndex = 53;
			label1.Text = "Hwid Locked:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(654, 571);
			base.Controls.Add(keyoutput);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "settingslockedserials";
			Text = "settingslockedserials";
			base.Load += settingslockedserialsLoad;
			keyoutput.ResumeLayout(false);
			keyoutput.PerformLayout();
			ResumeLayout(false);
		}
	}
}
