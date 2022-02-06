using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class settingsuserdetails : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private SiticoneGroupBox grou;

		private SiticoneTextBox useroutput;

		private Label label7;

		private SiticoneTextBox keyoutput;

		private Label osad;

		private SiticoneTextBox discoutput;

		private Label label3;

		private SiticoneTextBox passoutput;

		private Label label2;

		private Label label1;

		private SiticoneTextBox pcname;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		private SiticoneTextBox exp;

		private Label label4;

		private SiticoneTextBox sub;

		private Label label5;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		private Panel panel2;

		private SiticoneTextBox lastl;

		private Label label8;

		private SiticoneTextBox creation;

		private Label label6;

		public settingsuserdetails()
		{
			this.MainLoad();
		}

		public DateTime MainLoad(long long_0)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(long_0).ToLocalTime();
		}

		private string MainLoad(int int_0)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUXYZ0123456789";
			Random random = new Random((int)DateTime.Now.Ticks);
			string text2 = "";
			for (int i = 0; i < int_0; i++)
			{
				text2 += text[random.Next(0, text.Length - 1)];
			}
			return text2;
		}

		private void settingsuserdetailsLoad(object sender, EventArgs param_581)
		{
			pcname.Text = MainLoad(25);
			try
			{
				exp.Text = MainLoad(long.Parse(Login.dashboard.dashboard.subscriptions[0].expiry)).ToString() ?? "";
				sub.Text = Login.dashboard.dashboard.subscriptions[0].subscription;
				lastl.Text = MainLoad(long.Parse(Login.dashboard.dashboard.lastlogin)).ToString();
				creation.Text = MainLoad(long.Parse(Login.dashboard.dashboard.createdate)).ToString();
			}
			catch (Exception)
			{
				Application.Exit();
			}
			try
			{
				useroutput.Text = Login.dashboard.dashboard.username;
			}
			catch (Exception)
			{
				useroutput.Text = "Failed to load username";
			}
			try
			{
				foreach (string item in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\password.json", Encoding.UTF8))
				{
					passoutput.Text = item;
				}
			}
			catch (Exception)
			{
				passoutput.Text = "Failed to load password";
			}
			try
			{
				foreach (string item2 in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\discordid.json", Encoding.UTF8))
				{
					discoutput.Text = item2;
				}
			}
			catch (Exception)
			{
				discoutput.Text = "Failed to load discord";
			}
			try
			{
				foreach (string item3 in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\key.json", Encoding.UTF8))
				{
					keyoutput.Text = item3;
				}
			}
			catch (Exception)
			{
				keyoutput.Text = "Failed to load license";
			}
		}

		private void bsClick(object sender, EventArgs param_583)
		{
		}

		private void stoppClick(object sender, EventArgs param_585)
		{
		}

		private void siticoneRoundedGradientButton1Click(object sender, EventArgs param_587)
		{
			Application.Exit();
		}

		private void gpuClick(object sender, EventArgs param_589)
		{
		}

		private void xboxClick(object sender, EventArgs param_591)
		{
			Login.dashboard.bsClick("UM2q1OZuJq", "&type=resetpw&user=" + useroutput.Text + "&format=json");
			MessageBox.Show("We have reset the password for user: " + useroutput.Text + ". Please login with the password you want to set.", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void serialcheckersClick(object sender, EventArgs param_593)
		{
		}

		public string MainLoad()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		private void siticoneRoundedGradientButton4Click(object sender, EventArgs param_595)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter("C:\\Windows\\Temp\\SuperData.txt"))
				{
					foreach (string item in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\password.json", Encoding.UTF8))
					{
						foreach (string item2 in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\discordid.json", Encoding.UTF8))
						{
							foreach (string item3 in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\key.json", Encoding.UTF8))
							{
								streamWriter.WriteLine("Username:" + Login.dashboard.dashboard.username);
								streamWriter.WriteLine("Password:" + item);
								streamWriter.WriteLine("Discord:" + item2);
								streamWriter.WriteLine("License:" + item3);
								streamWriter.WriteLine("");
								streamWriter.WriteLine("Subscription: " + Login.dashboard.dashboard.subscriptions[0].subscription);
								streamWriter.WriteLine("Expiry: " + MainLoad(long.Parse(Login.dashboard.dashboard.subscriptions[0].expiry)).ToString());
								streamWriter.WriteLine("");
								streamWriter.WriteLine("HWID: " + WindowsIdentity.GetCurrent().User.Value);
								streamWriter.WriteLine("IP: " + this.MainLoad());
								streamWriter.WriteLine("");
								streamWriter.WriteLine("Installation Folder: " + Directory.GetCurrentDirectory());
								streamWriter.WriteLine("Proccess ID: " + Process.GetCurrentProcess().Id);
								streamWriter.WriteLine("Proccess Name: " + Process.GetCurrentProcess().ProcessName);
								streamWriter.WriteLine("Proccess Start: " + Process.GetCurrentProcess().StartTime.ToString());
							}
						}
					}
				}
				Process.Start("C:\\Windows\\Temp\\SuperData.txt");
			}
			catch (Exception)
			{
			}
		}

		private void siticoneRoundedGradientButton3Click(object sender, EventArgs param_597)
		{
		}

		private void ReduceAddin(object sender, EventArgs param_599)
		{
		}

		private void grouClick(object sender, EventArgs param_601)
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
			grou = new SiticoneGroupBox();
			panel2 = new Panel();
			siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
			exp = new SiticoneTextBox();
			label4 = new Label();
			sub = new SiticoneTextBox();
			label5 = new Label();
			siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
			label1 = new Label();
			pcname = new SiticoneTextBox();
			keyoutput = new SiticoneTextBox();
			osad = new Label();
			discoutput = new SiticoneTextBox();
			label3 = new Label();
			passoutput = new SiticoneTextBox();
			label2 = new Label();
			useroutput = new SiticoneTextBox();
			label7 = new Label();
			creation = new SiticoneTextBox();
			label6 = new Label();
			lastl = new SiticoneTextBox();
			label8 = new Label();
			grou.SuspendLayout();
			SuspendLayout();
			grou.BorderColor = Color.FromArgb(65, 71, 85);
			grou.Controls.Add(lastl);
			grou.Controls.Add(label8);
			grou.Controls.Add(creation);
			grou.Controls.Add(label6);
			grou.Controls.Add(panel2);
			grou.Controls.Add(siticoneRoundedGradientButton4);
			grou.Controls.Add(exp);
			grou.Controls.Add(label4);
			grou.Controls.Add(sub);
			grou.Controls.Add(label5);
			grou.Controls.Add(siticoneRoundedGradientButton3);
			grou.Controls.Add(siticoneRoundedGradientButton1);
			grou.Controls.Add(label1);
			grou.Controls.Add(pcname);
			grou.Controls.Add(keyoutput);
			grou.Controls.Add(osad);
			grou.Controls.Add(discoutput);
			grou.Controls.Add(label3);
			grou.Controls.Add(passoutput);
			grou.Controls.Add(label2);
			grou.Controls.Add(useroutput);
			grou.Controls.Add(label7);
			grou.CustomBorderColor = Color.FromArgb(65, 71, 85);
			grou.FillColor = Color.FromArgb(25, 26, 30);
			grou.Font = new Font("Segoe UI", 9f);
			grou.ForeColor = Color.FromArgb(125, 137, 149);
			grou.Location = new Point(12, 12);
			grou.Name = "grou";
			grou.ShadowDecoration.Parent = grou;
			grou.Size = new Size(630, 547);
			grou.TabIndex = 96;
			grou.Text = "User Details";
			grou.Click += grouClick;
			panel2.BackColor = Color.FromArgb(64, 64, 64);
			panel2.Location = new Point(18, 492);
			panel2.Name = "panel2";
			panel2.Size = new Size(595, 1);
			panel2.TabIndex = 113;
			siticoneRoundedGradientButton4.BorderThickness = 1;
			siticoneRoundedGradientButton4.CheckedState.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.CustomImages.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.FillColor = Color.DarkViolet;
			siticoneRoundedGradientButton4.FillColor2 = Color.DarkViolet;
			siticoneRoundedGradientButton4.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton4.ForeColor = Color.White;
			siticoneRoundedGradientButton4.HoveredState.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.Location = new Point(332, 509);
			siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
			siticoneRoundedGradientButton4.ShadowDecoration.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.Size = new Size(155, 30);
			siticoneRoundedGradientButton4.TabIndex = 112;
			siticoneRoundedGradientButton4.Text = "Request All Logged Data";
			siticoneRoundedGradientButton4.Click += siticoneRoundedGradientButton4Click;
			exp.BorderColor = Color.FromArgb(79, 84, 103);
			exp.Cursor = Cursors.No;
			exp.DefaultText = "";
			exp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			exp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			exp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			exp.DisabledState.Parent = exp;
			exp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			exp.FillColor = Color.FromArgb(25, 26, 30);
			exp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			exp.FocusedState.Parent = exp;
			exp.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			exp.HoveredState.Parent = exp;
			exp.Location = new Point(332, 246);
			exp.Name = "exp";
			exp.PasswordChar = '\0';
			exp.PlaceholderText = "Loading...";
			exp.ReadOnly = true;
			exp.SelectedText = "";
			exp.ShadowDecoration.Parent = exp;
			exp.Size = new Size(281, 30);
			exp.TabIndex = 111;
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(329, 230);
			label4.Name = "label4";
			label4.Size = new Size(110, 13);
			label4.TabIndex = 110;
			label4.Text = "Subscription Expiry:";
			sub.BorderColor = Color.FromArgb(79, 84, 103);
			sub.Cursor = Cursors.No;
			sub.DefaultText = "";
			sub.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			sub.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			sub.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			sub.DisabledState.Parent = sub;
			sub.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			sub.FillColor = Color.FromArgb(25, 26, 30);
			sub.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			sub.FocusedState.Parent = sub;
			sub.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			sub.HoveredState.Parent = sub;
			sub.Location = new Point(18, 246);
			sub.Name = "sub";
			sub.PasswordChar = '\0';
			sub.PlaceholderText = "Loading...";
			sub.ReadOnly = true;
			sub.SelectedText = "";
			sub.ShadowDecoration.Parent = sub;
			sub.Size = new Size(298, 30);
			sub.TabIndex = 109;
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.White;
			label5.Location = new Point(15, 230);
			label5.Name = "label5";
			label5.Size = new Size(75, 13);
			label5.TabIndex = 108;
			label5.Text = "Subscription:";
			siticoneRoundedGradientButton3.BorderThickness = 1;
			siticoneRoundedGradientButton3.CheckedState.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.CustomImages.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.FillColor = Color.DarkRed;
			siticoneRoundedGradientButton3.FillColor2 = Color.DarkRed;
			siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton3.ForeColor = Color.White;
			siticoneRoundedGradientButton3.HoveredState.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.Location = new Point(493, 509);
			siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			siticoneRoundedGradientButton3.ShadowDecoration.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.Size = new Size(120, 30);
			siticoneRoundedGradientButton3.TabIndex = 107;
			siticoneRoundedGradientButton3.Text = "Delete Account";
			siticoneRoundedGradientButton3.Click += siticoneRoundedGradientButton3Click;
			siticoneRoundedGradientButton1.BorderThickness = 1;
			siticoneRoundedGradientButton1.CheckedState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.CustomImages.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.FillColor = Color.DarkRed;
			siticoneRoundedGradientButton1.FillColor2 = Color.DarkRed;
			siticoneRoundedGradientButton1.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton1.ForeColor = Color.White;
			siticoneRoundedGradientButton1.HoveredState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Location = new Point(553, 124);
			siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
			siticoneRoundedGradientButton1.ShadowDecoration.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Size = new Size(60, 30);
			siticoneRoundedGradientButton1.TabIndex = 105;
			siticoneRoundedGradientButton1.Text = "End";
			siticoneRoundedGradientButton1.Click += siticoneRoundedGradientButton1Click;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(342, 108);
			label1.Name = "label1";
			label1.Size = new Size(63, 13);
			label1.TabIndex = 104;
			label1.Text = "Session ID:";
			pcname.BorderColor = Color.FromArgb(79, 84, 103);
			pcname.Cursor = Cursors.No;
			pcname.DefaultText = "Loading...";
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
			pcname.Location = new Point(345, 124);
			pcname.Name = "pcname";
			pcname.PasswordChar = '\0';
			pcname.PlaceholderText = "";
			pcname.ReadOnly = true;
			pcname.SelectedText = "";
			pcname.ShadowDecoration.Parent = pcname;
			pcname.Size = new Size(202, 30);
			pcname.TabIndex = 103;
			keyoutput.BorderColor = Color.FromArgb(79, 84, 103);
			keyoutput.Cursor = Cursors.No;
			keyoutput.DefaultText = "Loading...";
			keyoutput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			keyoutput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			keyoutput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			keyoutput.DisabledState.Parent = keyoutput;
			keyoutput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			keyoutput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			keyoutput.FocusedState.Parent = keyoutput;
			keyoutput.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			keyoutput.HoveredState.Parent = keyoutput;
			keyoutput.Location = new Point(18, 184);
			keyoutput.Name = "keyoutput";
			keyoutput.PasswordChar = '\0';
			keyoutput.PlaceholderText = "";
			keyoutput.ReadOnly = true;
			keyoutput.SelectedText = "";
			keyoutput.ShadowDecoration.Parent = keyoutput;
			keyoutput.Size = new Size(595, 30);
			keyoutput.TabIndex = 101;
			osad.AutoSize = true;
			osad.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			osad.ForeColor = Color.White;
			osad.Location = new Point(15, 168);
			osad.Name = "osad";
			osad.Size = new Size(48, 13);
			osad.TabIndex = 100;
			osad.Text = "License:";
			discoutput.BorderColor = Color.FromArgb(79, 84, 103);
			discoutput.Cursor = Cursors.No;
			discoutput.DefaultText = "Loading...";
			discoutput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			discoutput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			discoutput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			discoutput.DisabledState.Parent = discoutput;
			discoutput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			discoutput.FillColor = Color.FromArgb(25, 26, 30);
			discoutput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			discoutput.FocusedState.Parent = discoutput;
			discoutput.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			discoutput.HoveredState.Parent = discoutput;
			discoutput.Location = new Point(17, 124);
			discoutput.Name = "discoutput";
			discoutput.PasswordChar = '\0';
			discoutput.PlaceholderText = "";
			discoutput.ReadOnly = true;
			discoutput.SelectedText = "";
			discoutput.ShadowDecoration.Parent = discoutput;
			discoutput.Size = new Size(298, 30);
			discoutput.TabIndex = 99;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(14, 108);
			label3.Name = "label3";
			label3.Size = new Size(49, 13);
			label3.TabIndex = 98;
			label3.Text = "Discord:";
			passoutput.BorderColor = Color.FromArgb(79, 84, 103);
			passoutput.Cursor = Cursors.No;
			passoutput.DefaultText = "Loading...";
			passoutput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			passoutput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			passoutput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			passoutput.DisabledState.Parent = passoutput;
			passoutput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			passoutput.FillColor = Color.FromArgb(25, 26, 30);
			passoutput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			passoutput.FocusedState.Parent = passoutput;
			passoutput.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			passoutput.HoveredState.Parent = passoutput;
			passoutput.Location = new Point(345, 65);
			passoutput.Name = "passoutput";
			passoutput.PasswordChar = '\0';
			passoutput.PlaceholderText = "";
			passoutput.ReadOnly = true;
			passoutput.SelectedText = "";
			passoutput.ShadowDecoration.Parent = passoutput;
			passoutput.Size = new Size(268, 30);
			passoutput.TabIndex = 97;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(342, 49);
			label2.Name = "label2";
			label2.Size = new Size(60, 13);
			label2.TabIndex = 96;
			label2.Text = "Password:";
			useroutput.BorderColor = Color.FromArgb(79, 84, 103);
			useroutput.Cursor = Cursors.No;
			useroutput.DefaultText = "Loading...";
			useroutput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			useroutput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			useroutput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			useroutput.DisabledState.Parent = useroutput;
			useroutput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			useroutput.FillColor = Color.FromArgb(25, 26, 30);
			useroutput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			useroutput.FocusedState.Parent = useroutput;
			useroutput.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			useroutput.HoveredState.Parent = useroutput;
			useroutput.Location = new Point(17, 65);
			useroutput.Name = "useroutput";
			useroutput.PasswordChar = '\0';
			useroutput.PlaceholderText = "";
			useroutput.ReadOnly = true;
			useroutput.SelectedText = "";
			useroutput.ShadowDecoration.Parent = useroutput;
			useroutput.Size = new Size(298, 30);
			useroutput.TabIndex = 95;
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.White;
			label7.Location = new Point(14, 49);
			label7.Name = "label7";
			label7.Size = new Size(62, 13);
			label7.TabIndex = 34;
			label7.Text = "Username:";
			creation.BorderColor = Color.FromArgb(79, 84, 103);
			creation.Cursor = Cursors.No;
			creation.DefaultText = "";
			creation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			creation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			creation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			creation.DisabledState.Parent = creation;
			creation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			creation.FillColor = Color.FromArgb(25, 26, 30);
			creation.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			creation.FocusedState.Parent = creation;
			creation.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			creation.HoveredState.Parent = creation;
			creation.Location = new Point(18, 305);
			creation.Margin = new Padding(4, 3, 4, 3);
			creation.Name = "creation";
			creation.PasswordChar = '\0';
			creation.PlaceholderText = "Loading...";
			creation.ReadOnly = true;
			creation.SelectedText = "";
			creation.ShadowDecoration.Parent = creation;
			creation.Size = new Size(298, 30);
			creation.TabIndex = 115;
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(15, 289);
			label6.Name = "label6";
			label6.Size = new Size(81, 13);
			label6.TabIndex = 114;
			label6.Text = "Creation Date:";
			lastl.BorderColor = Color.FromArgb(79, 84, 103);
			lastl.Cursor = Cursors.No;
			lastl.DefaultText = "";
			lastl.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			lastl.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			lastl.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			lastl.DisabledState.Parent = lastl;
			lastl.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			lastl.FillColor = Color.FromArgb(25, 26, 30);
			lastl.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			lastl.FocusedState.Parent = lastl;
			lastl.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			lastl.HoveredState.Parent = lastl;
			lastl.Location = new Point(332, 305);
			lastl.Margin = new Padding(5, 3, 5, 3);
			lastl.Name = "lastl";
			lastl.PasswordChar = '\0';
			lastl.PlaceholderText = "Loading...";
			lastl.ReadOnly = true;
			lastl.SelectedText = "";
			lastl.ShadowDecoration.Parent = lastl;
			lastl.Size = new Size(281, 30);
			lastl.TabIndex = 117;
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.White;
			label8.Location = new Point(329, 289);
			label8.Name = "label8";
			label8.Size = new Size(64, 13);
			label8.TabIndex = 116;
			label8.Text = "Last Login:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(654, 571);
			base.Controls.Add(grou);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "settingsuserdetails";
			Text = "settingsuserdetails";
			base.Load += settingsuserdetailsLoad;
			grou.ResumeLayout(false);
			grou.PerformLayout();
			ResumeLayout(false);
		}
	}
}
