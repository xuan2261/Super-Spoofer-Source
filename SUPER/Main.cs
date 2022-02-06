using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;

namespace SUPER
{
	public sealed class Main : Form
	{
		private int dashboard;

		private int green;

		private int spooferfixes;

		private IContainer dashboard;

		private SiticonePanel siticonePanel3;

		private SiticoneGradientButton dashboard;

		private SiticoneGradientButton serialcheckers;

		private SiticoneGradientButton spooferfixes;

		private SiticoneGradientButton systemspoof;

		private SiticoneGradientButton gamespoof;

		private SiticoneDragControl dashboard;

		private Timer dashboard;

		private SiticoneControlBox siticoneControlBox3;

		private SiticoneControlBox siticoneControlBox4;

		private SiticoneGradientButton siticoneGradientButton2;

		private SiticoneGradientButton webtool;

		public SiticoneGradientPanel siticonePanel1;

		public System.Windows.Forms.ProgressBar blue;

		public System.Windows.Forms.ProgressBar green;

		public System.Windows.Forms.ProgressBar red;

		public SiticoneGradientButton userin;

		public Timer green;

		public SiticoneGradientButton siticoneGradientButton1;

		private SiticonePanel siticonePanel2;

		private SiticoneGradientButton spooferstatus;

		public System.Windows.Forms.PictureBox pictureBox1;

		private SiticoneGradientButton siticoneGradientButton3;

		private Timer spooferfixes;

		private System.Windows.Forms.Panel panel2;

		private System.Windows.Forms.Panel panel1;

		private Timer systemspoof;

		private Label label1;

		public Main()
		{
			System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard) = 255;
			System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes) = 0;
			this.dashboard = (Timer)AssistantHelper.dashboard;
			base._002Ector();
			stoppClick();
			spooferfixes.Start();
		}

		private void MainLoad(object sender, EventArgs param_90)
		{
			label1.Text = "Cracked By Yeetret ";
			systemspoof.Start();
			try
			{
				new SoundPlayer("C:\\Windows\\Media\\Windows Unlock.wav").Play();
			}
			catch (Exception)
			{
			}
			siticonePanel3.Controls.Clear();
			dashboard dashboard2 = new dashboard
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			dashboard2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(dashboard2);
			dashboard2.Show();
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void dashboardClick(object sender, EventArgs param_92)
		{
			siticonePanel3.Controls.Clear();
			dashboard dashboard2 = new dashboard
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			dashboard2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(dashboard2);
			dashboard2.Show();
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void stoppClick(object sender, EventArgs param_94)
		{
			Application.Exit();
		}

		private void gamespoofClick(object sender, EventArgs param_96)
		{
			siticonePanel3.Controls.Clear();
			gamespoofer gamespoofer2 = new gamespoofer
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			gamespoofer2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(gamespoofer2);
			gamespoofer2.Show();
			gamespoof.CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void systemspoofClick(object sender, EventArgs param_98)
		{
			siticonePanel3.Controls.Clear();
			systemspoofer systemspoofer2 = new systemspoofer
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			systemspoofer2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(systemspoofer2);
			systemspoofer2.Show();
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void xboxClick(object sender, EventArgs param_100)
		{
		}

		private void serialcheckersClick(object sender, EventArgs param_102)
		{
			siticonePanel3.Controls.Clear();
			serialcheck serialcheck2 = new serialcheck
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			serialcheck2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(serialcheck2);
			serialcheck2.Show();
			serialcheckers.CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void siticonePanel2Paint(object sender, PaintEventArgs param_104)
		{
		}

		private void biosClick(object sender, EventArgs param_106)
		{
		}

		private void userinClick(object sender, EventArgs param_108)
		{
			siticonePanel3.Controls.Clear();
			userinformation userinformation2 = new userinformation
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			userinformation2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(userinformation2);
			userinformation2.Show();
			userin.CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void spooferfixesClick(object sender, EventArgs param_110)
		{
			siticonePanel3.Controls.Clear();
			spooferfixes spooferfixes2 = new spooferfixes
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			spooferfixes2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(spooferfixes2);
			spooferfixes2.Show();
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void grouClick(object sender, EventArgs param_112)
		{
		}

		private void LoginMove(object sender, EventArgs param_114)
		{
		}

		private void webtoolClick(object sender, EventArgs param_116)
		{
			siticonePanel3.Controls.Clear();
			WebhookTool webhookTool = new WebhookTool
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			webhookTool.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(webhookTool);
			webhookTool.Show();
			webtool.CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void siticoneGradientButton2Click(object sender, EventArgs param_118)
		{
			siticonePanel3.Controls.Clear();
			fivemmenus fivemmenus2 = new fivemmenus
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			fivemmenus2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(fivemmenus2);
			fivemmenus2.Show();
			siticoneGradientButton2.CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			siticoneGradientButton2.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton2.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void ToggleFunction(object sender, EventArgs param_120)
		{
		}

		private void FormatEditor(object sender, EventArgs param_122)
		{
		}

		private void Increase(object sender, EventArgs param_124)
		{
			siticonePanel1.FillColor = Color.FromArgb(System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard), System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green), System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes));
			siticonePanel1.FillColor2 = Color.FromArgb(System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard), System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green), System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes));
			if (System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard) > 0 && System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard)--;
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green)++;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green) > 0 && System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green)--;
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes)++;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes) > 0 && System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes)--;
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard)++;
			}
		}

		private void siticoneGradientButton1Click(object sender, EventArgs param_126)
		{
			siticonePanel3.Controls.Clear();
			spooferchat spooferchat2 = new spooferchat
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			spooferchat2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(spooferchat2);
			spooferchat2.Show();
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.CustomBorderColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void siticonePanel3Paint(object sender, PaintEventArgs param_128)
		{
		}

		private void spooferstatusClick(object sender, EventArgs param_130)
		{
			siticonePanel3.Controls.Clear();
			status status2 = new status
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			status2.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(status2);
			status2.Show();
			spooferstatus.CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void siticoneGradientButton3Click(object sender, EventArgs param_132)
		{
			siticonePanel3.Controls.Clear();
			FiveMscripthook fiveMscripthook = new FiveMscripthook
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			fiveMscripthook.FormBorderStyle = FormBorderStyle.None;
			siticonePanel3.Controls.Add(fiveMscripthook);
			fiveMscripthook.Show();
			siticoneGradientButton3.CustomBorderColor = Color.FromArgb(red.Value, ((System.Windows.Forms.ProgressBar)(object)this.green).Value, blue.Value);
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.CustomBorderColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.CustomBorderColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			userin.CustomBorderColor = Color.FromArgb(7, 6, 24);
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.CustomBorderColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
		}

		private void MainLoad()
		{
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Application.Exit();
		}

		private void bsClick()
		{
		}

		private void loginnowClick(object sender, EventArgs param_134)
		{
			if (Process.GetProcessesByName("ProcessHacker").Length == 0)
				bsClick();
			else
				MainLoad();
		}

		private void PublishPage(object sender, EventArgs param_136)
		{
			label1.Text = "Cracked By Yeetret#5359";
		}

		private void pwrClick(object sender, EventArgs param_138)
		{
			BackColor = Color.FromArgb(System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard), System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green), System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes));
			if (System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard) > 0 && System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard)--;
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green)++;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green) > 0 && System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green)--;
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes)++;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes) > 0 && System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.green) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.spooferfixes)--;
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard)++;
			}
		}

		private void siticoneControlBox3Click(object sender, EventArgs param_140)
		{
			Application.Exit();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.dashboard > AssistantHelper.dashboard)
				((IDisposable)this.dashboard).Dispose();
			base.Dispose(disposing);
		}

		private void stoppClick()
		{
			this.dashboard = (Timer)(object)new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
			siticonePanel3 = new SiticonePanel();
			this.dashboard = (Timer)(object)new SiticoneDragControl((IContainer)this.dashboard);
			siticonePanel1 = new SiticoneGradientPanel();
			label1 = new Label();
			siticoneControlBox3 = new SiticoneControlBox();
			siticoneControlBox4 = new SiticoneControlBox();
			dashboard = new Timer((IContainer)this.dashboard);
			red = new System.Windows.Forms.ProgressBar();
			this.green = (Timer)(object)new System.Windows.Forms.ProgressBar();
			blue = new System.Windows.Forms.ProgressBar();
			green = new Timer((IContainer)this.dashboard);
			siticonePanel2 = new SiticonePanel();
			siticoneGradientButton3 = new SiticoneGradientButton();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			spooferstatus = new SiticoneGradientButton();
			siticoneGradientButton1 = new SiticoneGradientButton();
			siticoneGradientButton2 = new SiticoneGradientButton();
			webtool = new SiticoneGradientButton();
			panel2 = new System.Windows.Forms.Panel();
			userin = new SiticoneGradientButton();
			serialcheckers = new SiticoneGradientButton();
			this.spooferfixes = (Timer)(object)new SiticoneGradientButton();
			this.systemspoof = (Timer)(object)new SiticoneGradientButton();
			gamespoof = new SiticoneGradientButton();
			this.dashboard = (Timer)(object)new SiticoneGradientButton();
			panel1 = new System.Windows.Forms.Panel();
			spooferfixes = new Timer((IContainer)this.dashboard);
			systemspoof = new Timer((IContainer)this.dashboard);
			siticonePanel1.SuspendLayout();
			siticonePanel2.SuspendLayout();
			((ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			siticonePanel3.BackColor = Color.FromArgb(25, 26, 30);
			siticonePanel3.BorderColor = Color.Gray;
			siticonePanel3.BorderThickness = 1;
			siticonePanel3.Location = new Point(194, 37);
			siticonePanel3.Name = "siticonePanel3";
			siticonePanel3.ShadowDecoration.Parent = siticonePanel3;
			siticonePanel3.Size = new Size(873, 597);
			siticonePanel3.TabIndex = 2;
			siticonePanel3.Paint += siticonePanel3Paint;
			((SiticoneDragControl)(object)this.dashboard).TargetControl = siticonePanel1;
			siticonePanel1.BackColor = Color.FromArgb(7, 6, 24);
			siticonePanel1.Controls.Add(label1);
			siticonePanel1.Controls.Add(siticoneControlBox3);
			siticonePanel1.Controls.Add(siticoneControlBox4);
			siticonePanel1.Cursor = Cursors.Hand;
			siticonePanel1.FillColor = Color.FromArgb(7, 6, 24);
			siticonePanel1.FillColor2 = Color.FromArgb(7, 6, 24);
			siticonePanel1.Location = new Point(-382, 0);
			siticonePanel1.Name = "siticonePanel1";
			siticonePanel1.ShadowDecoration.Parent = siticonePanel1;
			siticonePanel1.Size = new Size(1470, 31);
			siticonePanel1.TabIndex = 53;
			label1.AutoSize = true;
			label1.Font = new Font("Franklin Gothic Medium", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(389, 5);
			label1.Name = "label1";
			label1.Size = new Size(136, 21);
			label1.TabIndex = 3;
			label1.Text = "Cracked By Yeetret#5359";
			siticoneControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			siticoneControlBox3.BackColor = Color.Transparent;
			siticoneControlBox3.BorderColor = Color.Silver;
			siticoneControlBox3.BorderRadius = 10;
			siticoneControlBox3.Cursor = Cursors.Hand;
			siticoneControlBox3.FillColor = Color.Transparent;
			siticoneControlBox3.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
			siticoneControlBox3.HoveredState.IconColor = Color.White;
			siticoneControlBox3.HoveredState.Parent = siticoneControlBox3;
			siticoneControlBox3.IconColor = Color.White;
			siticoneControlBox3.Location = new Point(1408, 4);
			siticoneControlBox3.Name = "siticoneControlBox3";
			siticoneControlBox3.ShadowDecoration.Parent = siticoneControlBox3;
			siticoneControlBox3.Size = new Size(45, 23);
			siticoneControlBox3.TabIndex = 1;
			siticoneControlBox3.Click += siticoneControlBox3Click;
			siticoneControlBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			siticoneControlBox4.BackColor = Color.Transparent;
			siticoneControlBox4.BorderColor = Color.Silver;
			siticoneControlBox4.BorderRadius = 10;
			siticoneControlBox4.ControlBoxType = ControlBoxType.MinimizeBox;
			siticoneControlBox4.Cursor = Cursors.Hand;
			siticoneControlBox4.FillColor = Color.Transparent;
			siticoneControlBox4.HoveredState.Parent = siticoneControlBox4;
			siticoneControlBox4.IconColor = Color.White;
			siticoneControlBox4.Location = new Point(1358, 4);
			siticoneControlBox4.Name = "siticoneControlBox4";
			siticoneControlBox4.ShadowDecoration.Parent = siticoneControlBox4;
			siticoneControlBox4.Size = new Size(45, 23);
			siticoneControlBox4.TabIndex = 2;
			dashboard.Interval = 10;
			dashboard.Tick += pwrClick;
			red.Location = new Point(950, 571);
			red.Maximum = 255;
			red.Name = "red";
			red.Size = new Size(50, 14);
			red.TabIndex = 73;
			red.Value = 255;
			red.Visible = false;
			((Control)(object)this.green).Location = new Point(1006, 571);
			((System.Windows.Forms.ProgressBar)(object)this.green).Maximum = 255;
			((Control)(object)this.green).Name = "green";
			((Control)(object)this.green).Size = new Size(50, 14);
			((Control)(object)this.green).TabIndex = 74;
			((System.Windows.Forms.ProgressBar)(object)this.green).Value = 255;
			((Control)(object)this.green).Visible = false;
			blue.Location = new Point(1062, 571);
			blue.Maximum = 255;
			blue.Name = "blue";
			blue.Size = new Size(50, 14);
			blue.TabIndex = 75;
			blue.Value = 255;
			blue.Visible = false;
			green.Interval = 10;
			green.Tick += Increase;
			siticonePanel2.BackColor = Color.FromArgb(7, 6, 24);
			siticonePanel2.BorderColor = Color.DarkGray;
			siticonePanel2.BorderThickness = 1;
			siticonePanel2.Controls.Add(siticoneGradientButton3);
			siticonePanel2.Controls.Add(pictureBox1);
			siticonePanel2.Controls.Add(spooferstatus);
			siticonePanel2.Controls.Add(siticoneGradientButton1);
			siticonePanel2.Controls.Add(siticoneGradientButton2);
			siticonePanel2.Controls.Add(webtool);
			siticonePanel2.Controls.Add(panel2);
			siticonePanel2.Controls.Add(userin);
			siticonePanel2.Controls.Add(serialcheckers);
			siticonePanel2.Controls.Add((Control)(object)this.spooferfixes);
			siticonePanel2.Controls.Add((Control)(object)this.systemspoof);
			siticonePanel2.Controls.Add(gamespoof);
			siticonePanel2.Controls.Add((Control)(object)this.dashboard);
			siticonePanel2.Controls.Add(panel1);
			siticonePanel2.Location = new Point(-1, 28);
			siticonePanel2.Name = "siticonePanel2";
			siticonePanel2.ShadowDecoration.Parent = siticonePanel2;
			siticonePanel2.Size = new Size(189, 672);
			siticonePanel2.TabIndex = 1;
			siticonePanel2.Paint += siticonePanel2Paint;
			siticoneGradientButton3.CheckedState.Parent = siticoneGradientButton3;
			siticoneGradientButton3.Cursor = Cursors.Hand;
			siticoneGradientButton3.CustomBorderThickness = new Padding(4, 0, 0, 0);
			siticoneGradientButton3.CustomImages.Parent = siticoneGradientButton3;
			siticoneGradientButton3.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton3.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneGradientButton3.ForeColor = Color.White;
			siticoneGradientButton3.HoveredState.Parent = siticoneGradientButton3;
			siticoneGradientButton3.Image = (Image)componentResourceManager.GetObject("siticoneGradientButton3.Image");
			siticoneGradientButton3.ImageAlign = HorizontalAlignment.Left;
			siticoneGradientButton3.Location = new Point(13, 466);
			siticoneGradientButton3.Name = "siticoneGradientButton3";
			siticoneGradientButton3.ShadowDecoration.Parent = siticoneGradientButton3;
			siticoneGradientButton3.Size = new Size(163, 40);
			siticoneGradientButton3.TabIndex = 76;
			siticoneGradientButton3.Text = "FiveM Bypass";
			siticoneGradientButton3.Click += siticoneGradientButton3Click;
			pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(13, 13);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(163, 64);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 75;
			pictureBox1.TabStop = false;
			spooferstatus.CheckedState.Parent = spooferstatus;
			spooferstatus.Cursor = Cursors.Hand;
			spooferstatus.CustomBorderThickness = new Padding(4, 0, 0, 0);
			spooferstatus.CustomImages.Parent = spooferstatus;
			spooferstatus.FillColor = Color.FromArgb(7, 6, 24);
			spooferstatus.FillColor2 = Color.FromArgb(7, 6, 24);
			spooferstatus.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			spooferstatus.ForeColor = Color.White;
			spooferstatus.HoveredState.Parent = spooferstatus;
			spooferstatus.Image = (Image)componentResourceManager.GetObject("spooferstatus.Image");
			spooferstatus.ImageAlign = HorizontalAlignment.Left;
			spooferstatus.Location = new Point(13, 221);
			spooferstatus.Name = "spooferstatus";
			spooferstatus.ShadowDecoration.Parent = spooferstatus;
			spooferstatus.Size = new Size(163, 40);
			spooferstatus.TabIndex = 74;
			spooferstatus.Text = "Spoofer Status";
			spooferstatus.Click += spooferstatusClick;
			siticoneGradientButton1.CheckedState.Parent = siticoneGradientButton1;
			siticoneGradientButton1.Cursor = Cursors.Hand;
			siticoneGradientButton1.CustomBorderThickness = new Padding(4, 0, 0, 0);
			siticoneGradientButton1.CustomImages.Parent = siticoneGradientButton1;
			siticoneGradientButton1.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneGradientButton1.ForeColor = Color.White;
			siticoneGradientButton1.HoveredState.Parent = siticoneGradientButton1;
			siticoneGradientButton1.Image = (Image)componentResourceManager.GetObject("siticoneGradientButton1.Image");
			siticoneGradientButton1.ImageAlign = HorizontalAlignment.Left;
			siticoneGradientButton1.Location = new Point(13, 524);
			siticoneGradientButton1.Name = "siticoneGradientButton1";
			siticoneGradientButton1.ShadowDecoration.Parent = siticoneGradientButton1;
			siticoneGradientButton1.Size = new Size(163, 40);
			siticoneGradientButton1.TabIndex = 73;
			siticoneGradientButton1.Text = "Spoofer Chat";
			siticoneGradientButton1.Click += siticoneGradientButton1Click;
			siticoneGradientButton2.CheckedState.Parent = siticoneGradientButton2;
			siticoneGradientButton2.Cursor = Cursors.Hand;
			siticoneGradientButton2.CustomBorderThickness = new Padding(4, 0, 0, 0);
			siticoneGradientButton2.CustomImages.Parent = siticoneGradientButton2;
			siticoneGradientButton2.FillColor = Color.FromArgb(7, 6, 24);
			siticoneGradientButton2.FillColor2 = Color.FromArgb(7, 6, 24);
			siticoneGradientButton2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneGradientButton2.ForeColor = Color.White;
			siticoneGradientButton2.HoveredState.Parent = siticoneGradientButton2;
			siticoneGradientButton2.Image = (Image)componentResourceManager.GetObject("siticoneGradientButton2.Image");
			siticoneGradientButton2.ImageAlign = HorizontalAlignment.Left;
			siticoneGradientButton2.Location = new Point(13, 420);
			siticoneGradientButton2.Name = "siticoneGradientButton2";
			siticoneGradientButton2.ShadowDecoration.Parent = siticoneGradientButton2;
			siticoneGradientButton2.Size = new Size(163, 40);
			siticoneGradientButton2.TabIndex = 10;
			siticoneGradientButton2.Text = "FiveM Menu";
			siticoneGradientButton2.Click += siticoneGradientButton2Click;
			webtool.CheckedState.Parent = webtool;
			webtool.Cursor = Cursors.Hand;
			webtool.CustomBorderThickness = new Padding(4, 0, 0, 0);
			webtool.CustomImages.Parent = webtool;
			webtool.FillColor = Color.FromArgb(7, 6, 24);
			webtool.FillColor2 = Color.FromArgb(7, 6, 24);
			webtool.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			webtool.ForeColor = Color.White;
			webtool.HoveredState.Parent = webtool;
			webtool.Image = (Image)componentResourceManager.GetObject("webtool.Image");
			webtool.ImageAlign = HorizontalAlignment.Left;
			webtool.Location = new Point(13, 374);
			webtool.Name = "webtool";
			webtool.ShadowDecoration.Parent = webtool;
			webtool.Size = new Size(163, 40);
			webtool.TabIndex = 9;
			webtool.Text = "Webhook Tool";
			webtool.Click += webtoolClick;
			panel2.BackColor = Color.DarkGray;
			panel2.Location = new Point(-8, 365);
			panel2.Name = "panel2";
			panel2.Size = new Size(197, 1);
			panel2.TabIndex = 7;
			userin.CheckedState.Parent = userin;
			userin.Cursor = Cursors.Hand;
			userin.CustomBorderThickness = new Padding(4, 0, 0, 0);
			userin.CustomImages.Parent = userin;
			userin.FillColor = Color.FromArgb(7, 6, 24);
			userin.FillColor2 = Color.FromArgb(7, 6, 24);
			userin.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			userin.ForeColor = Color.White;
			userin.HoveredState.Parent = userin;
			userin.Image = (Image)componentResourceManager.GetObject("userin.Image");
			userin.ImageAlign = HorizontalAlignment.Left;
			userin.Location = new Point(13, 570);
			userin.Name = "userin";
			userin.ShadowDecoration.Parent = userin;
			userin.Size = new Size(163, 40);
			userin.TabIndex = 8;
			userin.Text = "User Settings";
			userin.Click += userinClick;
			serialcheckers.CheckedState.Parent = serialcheckers;
			serialcheckers.Cursor = Cursors.Hand;
			serialcheckers.CustomBorderThickness = new Padding(4, 0, 0, 0);
			serialcheckers.CustomImages.Parent = serialcheckers;
			serialcheckers.FillColor = Color.FromArgb(7, 6, 24);
			serialcheckers.FillColor2 = Color.FromArgb(7, 6, 24);
			serialcheckers.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			serialcheckers.ForeColor = Color.White;
			serialcheckers.HoveredState.Parent = serialcheckers;
			serialcheckers.Image = (Image)componentResourceManager.GetObject("serialcheckers.Image");
			serialcheckers.ImageAlign = HorizontalAlignment.Left;
			serialcheckers.Location = new Point(13, 313);
			serialcheckers.Name = "serialcheckers";
			serialcheckers.ShadowDecoration.Parent = serialcheckers;
			serialcheckers.Size = new Size(163, 40);
			serialcheckers.TabIndex = 5;
			serialcheckers.Text = "Serial Checker";
			serialcheckers.Click += serialcheckersClick;
			((SiticoneGradientButton)(object)this.spooferfixes).CheckedState.Parent = (CustomButtonBase)(object)this.spooferfixes;
			((Control)(object)this.spooferfixes).Cursor = Cursors.Hand;
			((SiticoneGradientButton)(object)this.spooferfixes).CustomBorderThickness = new Padding(4, 0, 0, 0);
			((SiticoneGradientButton)(object)this.spooferfixes).CustomImages.Parent = (CustomButtonBase)(object)this.spooferfixes;
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.spooferfixes).FillColor2 = Color.FromArgb(7, 6, 24);
			((Control)(object)this.spooferfixes).Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			((Control)(object)this.spooferfixes).ForeColor = Color.White;
			((SiticoneGradientButton)(object)this.spooferfixes).HoveredState.Parent = (CustomButtonBase)(object)this.spooferfixes;
			((SiticoneGradientButton)(object)this.spooferfixes).Image = (Image)componentResourceManager.GetObject("spooferfixes.Image");
			((SiticoneGradientButton)(object)this.spooferfixes).ImageAlign = HorizontalAlignment.Left;
			((Control)(object)this.spooferfixes).Location = new Point(13, 267);
			((Control)(object)this.spooferfixes).Name = "spooferfixes";
			((SiticoneGradientButton)(object)this.spooferfixes).ShadowDecoration.Parent = (Control)(object)this.spooferfixes;
			((Control)(object)this.spooferfixes).Size = new Size(163, 40);
			((Control)(object)this.spooferfixes).TabIndex = 4;
			((Control)(object)this.spooferfixes).Text = "Spoofer Fixes";
			((Control)(object)this.spooferfixes).Click += spooferfixesClick;
			((SiticoneGradientButton)(object)this.systemspoof).CheckedState.Parent = (CustomButtonBase)(object)this.systemspoof;
			((Control)(object)this.systemspoof).Cursor = Cursors.Hand;
			((SiticoneGradientButton)(object)this.systemspoof).CustomBorderThickness = new Padding(4, 0, 0, 0);
			((SiticoneGradientButton)(object)this.systemspoof).CustomImages.Parent = (CustomButtonBase)(object)this.systemspoof;
			((SiticoneGradientButton)(object)this.systemspoof).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.systemspoof).FillColor2 = Color.FromArgb(7, 6, 24);
			((Control)(object)this.systemspoof).Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			((Control)(object)this.systemspoof).ForeColor = Color.White;
			((SiticoneGradientButton)(object)this.systemspoof).HoveredState.Parent = (CustomButtonBase)(object)this.systemspoof;
			((SiticoneGradientButton)(object)this.systemspoof).Image = (Image)componentResourceManager.GetObject("systemspoof.Image");
			((SiticoneGradientButton)(object)this.systemspoof).ImageAlign = HorizontalAlignment.Left;
			((Control)(object)this.systemspoof).Location = new Point(13, 175);
			((Control)(object)this.systemspoof).Name = "systemspoof";
			((SiticoneGradientButton)(object)this.systemspoof).ShadowDecoration.Parent = (Control)(object)this.systemspoof;
			((Control)(object)this.systemspoof).Size = new Size(163, 40);
			((Control)(object)this.systemspoof).TabIndex = 2;
			((Control)(object)this.systemspoof).Text = "System Spoofer";
			((Control)(object)this.systemspoof).Click += systemspoofClick;
			gamespoof.CheckedState.Parent = gamespoof;
			gamespoof.Cursor = Cursors.Hand;
			gamespoof.CustomBorderThickness = new Padding(4, 0, 0, 0);
			gamespoof.CustomImages.Parent = gamespoof;
			gamespoof.FillColor = Color.FromArgb(7, 6, 24);
			gamespoof.FillColor2 = Color.FromArgb(7, 6, 24);
			gamespoof.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			gamespoof.ForeColor = Color.White;
			gamespoof.HoveredState.Parent = gamespoof;
			gamespoof.Image = (Image)componentResourceManager.GetObject("gamespoof.Image");
			gamespoof.ImageAlign = HorizontalAlignment.Left;
			gamespoof.Location = new Point(13, 129);
			gamespoof.Name = "gamespoof";
			gamespoof.ShadowDecoration.Parent = gamespoof;
			gamespoof.Size = new Size(163, 40);
			gamespoof.TabIndex = 1;
			gamespoof.Text = "Game Spoofer";
			gamespoof.Click += gamespoofClick;
			((SiticoneGradientButton)(object)this.dashboard).CheckedState.Parent = (CustomButtonBase)(object)this.dashboard;
			((Control)(object)this.dashboard).Cursor = Cursors.Hand;
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderColor = Color.White;
			((SiticoneGradientButton)(object)this.dashboard).CustomBorderThickness = new Padding(4, 0, 0, 0);
			((SiticoneGradientButton)(object)this.dashboard).CustomImages.Parent = (CustomButtonBase)(object)this.dashboard;
			((SiticoneGradientButton)(object)this.dashboard).FillColor = Color.FromArgb(7, 6, 24);
			((SiticoneGradientButton)(object)this.dashboard).FillColor2 = Color.FromArgb(7, 6, 24);
			((Control)(object)this.dashboard).Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			((Control)(object)this.dashboard).ForeColor = Color.White;
			((SiticoneGradientButton)(object)this.dashboard).HoveredState.Parent = (CustomButtonBase)(object)this.dashboard;
			((SiticoneGradientButton)(object)this.dashboard).Image = (Image)componentResourceManager.GetObject("dashboard.Image");
			((SiticoneGradientButton)(object)this.dashboard).ImageAlign = HorizontalAlignment.Left;
			((Control)(object)this.dashboard).Location = new Point(13, 83);
			((Control)(object)this.dashboard).Name = "dashboard";
			((SiticoneGradientButton)(object)this.dashboard).ShadowDecoration.Parent = (Control)(object)this.dashboard;
			((Control)(object)this.dashboard).Size = new Size(163, 40);
			((Control)(object)this.dashboard).TabIndex = 0;
			((Control)(object)this.dashboard).Text = "Dashboard";
			((Control)(object)this.dashboard).Click += dashboardClick;
			panel1.BackColor = Color.DarkGray;
			panel1.Location = new Point(3, 512);
			panel1.Name = "panel1";
			panel1.Size = new Size(197, 1);
			panel1.TabIndex = 6;
			spooferfixes.Interval = 10;
			spooferfixes.Tick += loginnowClick;
			systemspoof.Tick += PublishPage;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			AutoValidate = AutoValidate.Disable;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(1075, 646);
			base.Controls.Add(blue);
			base.Controls.Add((Control)(object)this.green);
			base.Controls.Add(siticonePanel1);
			base.Controls.Add(red);
			base.Controls.Add(siticonePanel3);
			base.Controls.Add(siticonePanel2);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.StartPosition = FormStartPosition.CenterScreen;
			Text = "Loader";
			base.TransparencyKey = Color.Maroon;
			base.Load += MainLoad;
			siticonePanel1.ResumeLayout(false);
			siticonePanel1.PerformLayout();
			siticonePanel2.ResumeLayout(false);
			((ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}
	}
}
