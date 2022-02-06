using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class settingsupgradesub : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		private SiticoneTextBox key;

		private Label label1;

		private SiticoneTextBox username;

		private Label label7;

		private SiticoneGroupBox keyoutput;

		public settingsupgradesub()
		{
			MainLoad();
		}

		private void MainLoad(object sender, EventArgs param_574)
		{
		}

		private void siticoneRoundedGradientButton1Click(object sender, EventArgs param_576)
		{
			Login.dashboard.bsClick(username.Text, key.Text);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			key = new SiticoneTextBox();
			label1 = new Label();
			username = new SiticoneTextBox();
			label7 = new Label();
			siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
			keyoutput = new SiticoneGroupBox();
			keyoutput.SuspendLayout();
			SuspendLayout();
			key.BorderColor = Color.FromArgb(79, 84, 103);
			key.Cursor = Cursors.No;
			key.DefaultText = "";
			key.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			key.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			key.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			key.DisabledState.Parent = key;
			key.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			key.FillColor = Color.FromArgb(25, 26, 30);
			key.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			key.FocusedState.Parent = key;
			key.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			key.HoveredState.Parent = key;
			key.Location = new Point(13, 116);
			key.Name = "key";
			key.PasswordChar = '\0';
			key.PlaceholderText = "";
			key.ReadOnly = true;
			key.SelectedText = "";
			key.ShadowDecoration.Parent = key;
			key.Size = new Size(430, 35);
			key.TabIndex = 111;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(10, 100);
			label1.Name = "label1";
			label1.Size = new Size(48, 13);
			label1.TabIndex = 110;
			label1.Text = "License:";
			username.BorderColor = Color.FromArgb(79, 84, 103);
			username.Cursor = Cursors.No;
			username.DefaultText = "";
			username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			username.DisabledState.Parent = username;
			username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			username.FillColor = Color.FromArgb(25, 26, 30);
			username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			username.FocusedState.Parent = username;
			username.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			username.HoveredState.Parent = username;
			username.Location = new Point(13, 63);
			username.Name = "username";
			username.PasswordChar = '\0';
			username.PlaceholderText = "";
			username.ReadOnly = true;
			username.SelectedText = "";
			username.ShadowDecoration.Parent = username;
			username.Size = new Size(430, 35);
			username.TabIndex = 109;
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.White;
			label7.Location = new Point(10, 47);
			label7.Name = "label7";
			label7.Size = new Size(62, 13);
			label7.TabIndex = 108;
			label7.Text = "Username:";
			siticoneRoundedGradientButton1.BorderThickness = 1;
			siticoneRoundedGradientButton1.CheckedState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.CustomImages.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.FillColor = Color.DarkGreen;
			siticoneRoundedGradientButton1.FillColor2 = Color.DarkGreen;
			siticoneRoundedGradientButton1.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton1.ForeColor = Color.White;
			siticoneRoundedGradientButton1.HoveredState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Location = new Point(13, 157);
			siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
			siticoneRoundedGradientButton1.ShadowDecoration.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Size = new Size(123, 23);
			siticoneRoundedGradientButton1.TabIndex = 107;
			siticoneRoundedGradientButton1.Text = "Upgrade Sub";
			siticoneRoundedGradientButton1.Click += siticoneRoundedGradientButton1Click;
			keyoutput.BorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.Controls.Add(key);
			keyoutput.Controls.Add(siticoneRoundedGradientButton1);
			keyoutput.Controls.Add(label1);
			keyoutput.Controls.Add(username);
			keyoutput.Controls.Add(label7);
			keyoutput.CustomBorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			keyoutput.Font = new Font("Segoe UI", 9f);
			keyoutput.ForeColor = Color.FromArgb(125, 137, 149);
			keyoutput.Location = new Point(12, 12);
			keyoutput.Name = "keyoutput";
			keyoutput.ShadowDecoration.Parent = keyoutput;
			keyoutput.Size = new Size(630, 547);
			keyoutput.TabIndex = 112;
			keyoutput.Text = "Super Spoofer Locked Serials";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(654, 571);
			base.Controls.Add(keyoutput);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "settingsupgradesub";
			Text = "settingsupgradesub";
			keyoutput.ResumeLayout(false);
			keyoutput.PerformLayout();
			ResumeLayout(false);
		}
	}
}
