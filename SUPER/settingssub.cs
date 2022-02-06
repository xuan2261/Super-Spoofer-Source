using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class settingssub : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private SiticoneGroupBox keyoutput;

		private SiticoneTextBox exp;

		private Label label2;

		private SiticoneTextBox sub;

		private Label label7;

		private SiticoneRoundedButton siticoneRoundedButton1;

		public settingssub()
		{
			MainLoad();
		}

		public DateTime MainLoad(long long_0)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(long_0).ToLocalTime();
		}

		private void settingssubLoad(object sender, EventArgs param_546)
		{
			try
			{
				exp.Text = MainLoad(long.Parse(Login.dashboard.dashboard.subscriptions[0].expiry)).ToString() ?? "";
				sub.Text = Login.dashboard.dashboard.subscriptions[0].subscription;
			}
			catch (Exception)
			{
				Application.Exit();
			}
		}

		private void bsClick(object sender, EventArgs param_548)
		{
		}

		private void siticoneRoundedButton1Click(object sender, EventArgs param_550)
		{
			Process.Start("http://superspoofer.cc/prices.html");
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
			siticoneRoundedButton1 = new SiticoneRoundedButton();
			exp = new SiticoneTextBox();
			label2 = new Label();
			sub = new SiticoneTextBox();
			label7 = new Label();
			keyoutput.SuspendLayout();
			SuspendLayout();
			keyoutput.BorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.Controls.Add(siticoneRoundedButton1);
			keyoutput.Controls.Add(exp);
			keyoutput.Controls.Add(label2);
			keyoutput.Controls.Add(sub);
			keyoutput.Controls.Add(label7);
			keyoutput.CustomBorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			keyoutput.Font = new Font("Segoe UI", 9f);
			keyoutput.ForeColor = Color.FromArgb(125, 137, 149);
			keyoutput.Location = new Point(12, 14);
			keyoutput.Name = "keyoutput";
			keyoutput.ShadowDecoration.Parent = keyoutput;
			keyoutput.Size = new Size(630, 545);
			keyoutput.TabIndex = 97;
			keyoutput.Text = "Subscription Data";
			siticoneRoundedButton1.CheckedState.Parent = siticoneRoundedButton1;
			siticoneRoundedButton1.CustomImages.Parent = siticoneRoundedButton1;
			siticoneRoundedButton1.FillColor = Color.Green;
			siticoneRoundedButton1.Font = new Font("Segoe UI", 9f);
			siticoneRoundedButton1.ForeColor = Color.White;
			siticoneRoundedButton1.HoveredState.Parent = siticoneRoundedButton1;
			siticoneRoundedButton1.Location = new Point(465, 501);
			siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			siticoneRoundedButton1.ShadowDecoration.Parent = siticoneRoundedButton1;
			siticoneRoundedButton1.Size = new Size(149, 32);
			siticoneRoundedButton1.TabIndex = 98;
			siticoneRoundedButton1.Text = "Renew Subscription!";
			siticoneRoundedButton1.Click += siticoneRoundedButton1Click;
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
			exp.Location = new Point(17, 122);
			exp.Name = "exp";
			exp.PasswordChar = '\0';
			exp.PlaceholderText = "";
			exp.ReadOnly = true;
			exp.SelectedText = "";
			exp.ShadowDecoration.Parent = exp;
			exp.Size = new Size(597, 30);
			exp.TabIndex = 97;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(14, 106);
			label2.Name = "label2";
			label2.Size = new Size(110, 13);
			label2.TabIndex = 96;
			label2.Text = "Subscription Expiry:";
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
			sub.Location = new Point(17, 65);
			sub.Name = "sub";
			sub.PasswordChar = '\0';
			sub.PlaceholderText = "";
			sub.ReadOnly = true;
			sub.SelectedText = "";
			sub.ShadowDecoration.Parent = sub;
			sub.Size = new Size(597, 30);
			sub.TabIndex = 95;
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.White;
			label7.Location = new Point(14, 49);
			label7.Name = "label7";
			label7.Size = new Size(75, 13);
			label7.TabIndex = 34;
			label7.Text = "Subscription:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(654, 571);
			base.Controls.Add(keyoutput);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "settingssub";
			Text = "settingssub";
			base.Load += settingssubLoad;
			keyoutput.ResumeLayout(false);
			keyoutput.PerformLayout();
			ResumeLayout(false);
		}
	}
}
