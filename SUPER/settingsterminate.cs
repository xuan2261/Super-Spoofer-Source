using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class settingsterminate : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private Label label1;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton6;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton7;

		private Label label2;

		private Label label11;

		private SiticoneGroupBox keyoutput;

		public settingsterminate()
		{
			MainLoad();
		}

		private void MainLoad(object sender, EventArgs param_553)
		{
		}

		private void bsClick(object sender, EventArgs param_555)
		{
		}

		private void siticoneRoundedGradientButton1Click(object sender, EventArgs param_557)
		{
			Application.Exit();
		}

		private void MainLoad(object sender, PaintEventArgs param_559)
		{
		}

		private void siticoneRoundedGradientButton2Click(object sender, EventArgs param_561)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void siticoneRoundedGradientButton3Click(object sender, EventArgs param_563)
		{
			Application.Restart();
		}

		private void siticoneRoundedGradientButton7Click(object sender, EventArgs param_565)
		{
			new TOS().Show();
		}

		private void siticoneRoundedGradientButton4Click(object sender, EventArgs param_567)
		{
			try
			{
				lick.Delete("C:\\Program Files\\Temp\\93-29-29 USERS\\username.json");
				lick.Delete("C:\\Program Files\\Temp\\93-29-29 USERS\\password.json");
				lick.Delete("C:\\Program Files\\Temp\\93-29-29 USERS\\discordid.json");
				lick.Delete("C:\\Program Files\\Temp\\93-29-29 USERS\\key.json");
				MessageBox.Show("We have wiped user infromation data from autologin and userdetails.", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("We have wiped user infromation data from autologin and userdetails.", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void siticoneRoundedGradientButton5Click(object sender, EventArgs param_569)
		{
			try
			{
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\START.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\RUNAMIDE.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\REGC1.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\REGC2.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\MAC.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\TIOSJ.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\ZLCKG.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\LZOGJX.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\LZOghlg.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\CLEAN.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\amifldrv64.sys");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\AMIDEWINx64.exe");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\amide.sys");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\2837136472462842364.exe");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\system_fingerprint.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\system_utils.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\telemetry_fingerprint.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\registry_helper.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\random_utils.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\log_helper.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\identity_data.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\hardware_fingerprint.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\generate_fingerprint.py");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\APX.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\DBCLN.exe");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\RS.bat");
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\DBCLN.exe");
				MessageBox.Show("We have wiped saved drivers and saved cleaners from PC.", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("We have wiped saved drivers and saved cleaners from PC.", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void siticoneRoundedGradientButton6Click(object sender, EventArgs param_571)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			siticoneRoundedGradientButton7 = new SiticoneRoundedGradientButton();
			label2 = new Label();
			siticoneRoundedGradientButton6 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton5 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
			label1 = new Label();
			label11 = new Label();
			keyoutput = new SiticoneGroupBox();
			keyoutput.SuspendLayout();
			SuspendLayout();
			siticoneRoundedGradientButton7.BorderThickness = 1;
			siticoneRoundedGradientButton7.CheckedState.Parent = siticoneRoundedGradientButton7;
			siticoneRoundedGradientButton7.CustomImages.Parent = siticoneRoundedGradientButton7;
			siticoneRoundedGradientButton7.FillColor = Color.DimGray;
			siticoneRoundedGradientButton7.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton7.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton7.ForeColor = Color.White;
			siticoneRoundedGradientButton7.HoveredState.Parent = siticoneRoundedGradientButton7;
			siticoneRoundedGradientButton7.Location = new Point(20, 251);
			siticoneRoundedGradientButton7.Name = "siticoneRoundedGradientButton7";
			siticoneRoundedGradientButton7.ShadowDecoration.Parent = siticoneRoundedGradientButton7;
			siticoneRoundedGradientButton7.Size = new Size(154, 27);
			siticoneRoundedGradientButton7.TabIndex = 113;
			siticoneRoundedGradientButton7.Text = "Super Spoofer TOS";
			siticoneRoundedGradientButton7.TextAlign = HorizontalAlignment.Left;
			siticoneRoundedGradientButton7.Click += siticoneRoundedGradientButton7Click;
			label2.AutoSize = true;
			label2.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.AppWorkspace;
			label2.Location = new Point(17, 233);
			label2.Name = "label2";
			label2.Size = new Size(105, 15);
			label2.TabIndex = 112;
			label2.Text = "APPLICATION OPTIONS:";
			siticoneRoundedGradientButton6.BorderThickness = 1;
			siticoneRoundedGradientButton6.CheckedState.Parent = siticoneRoundedGradientButton6;
			siticoneRoundedGradientButton6.CustomImages.Parent = siticoneRoundedGradientButton6;
			siticoneRoundedGradientButton6.FillColor = Color.DimGray;
			siticoneRoundedGradientButton6.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton6.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton6.ForeColor = Color.White;
			siticoneRoundedGradientButton6.HoveredState.Parent = siticoneRoundedGradientButton6;
			siticoneRoundedGradientButton6.Location = new Point(20, 189);
			siticoneRoundedGradientButton6.Name = "siticoneRoundedGradientButton6";
			siticoneRoundedGradientButton6.ShadowDecoration.Parent = siticoneRoundedGradientButton6;
			siticoneRoundedGradientButton6.Size = new Size(372, 23);
			siticoneRoundedGradientButton6.TabIndex = 111;
			siticoneRoundedGradientButton6.Text = "Wipe Super Spoofer (Fully uninstall - Registerys + File System)";
			siticoneRoundedGradientButton6.TextAlign = HorizontalAlignment.Left;
			siticoneRoundedGradientButton6.Click += siticoneRoundedGradientButton6Click;
			siticoneRoundedGradientButton5.BorderThickness = 1;
			siticoneRoundedGradientButton5.CheckedState.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.CustomImages.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.FillColor = Color.DimGray;
			siticoneRoundedGradientButton5.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton5.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton5.ForeColor = Color.White;
			siticoneRoundedGradientButton5.HoveredState.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.Location = new Point(19, 160);
			siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
			siticoneRoundedGradientButton5.ShadowDecoration.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.Size = new Size(372, 23);
			siticoneRoundedGradientButton5.TabIndex = 110;
			siticoneRoundedGradientButton5.Text = "Wipe all drivers / cleaners (Fresh Boot)";
			siticoneRoundedGradientButton5.TextAlign = HorizontalAlignment.Left;
			siticoneRoundedGradientButton5.Click += siticoneRoundedGradientButton5Click;
			siticoneRoundedGradientButton4.BorderThickness = 1;
			siticoneRoundedGradientButton4.CheckedState.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.CustomImages.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.FillColor = Color.DimGray;
			siticoneRoundedGradientButton4.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton4.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton4.ForeColor = Color.White;
			siticoneRoundedGradientButton4.HoveredState.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.Location = new Point(19, 131);
			siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
			siticoneRoundedGradientButton4.ShadowDecoration.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.Size = new Size(372, 23);
			siticoneRoundedGradientButton4.TabIndex = 109;
			siticoneRoundedGradientButton4.Text = "Wipe user profile (Saved Data)";
			siticoneRoundedGradientButton4.TextAlign = HorizontalAlignment.Left;
			siticoneRoundedGradientButton4.Click += siticoneRoundedGradientButton4Click;
			siticoneRoundedGradientButton3.BorderThickness = 1;
			siticoneRoundedGradientButton3.CheckedState.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.CustomImages.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.FillColor = Color.DarkRed;
			siticoneRoundedGradientButton3.FillColor2 = Color.DarkRed;
			siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton3.ForeColor = Color.White;
			siticoneRoundedGradientButton3.HoveredState.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.Location = new Point(269, 71);
			siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			siticoneRoundedGradientButton3.ShadowDecoration.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.Size = new Size(123, 23);
			siticoneRoundedGradientButton3.TabIndex = 108;
			siticoneRoundedGradientButton3.Text = "Restart Session";
			siticoneRoundedGradientButton3.Click += siticoneRoundedGradientButton3Click;
			siticoneRoundedGradientButton2.BorderThickness = 1;
			siticoneRoundedGradientButton2.CheckedState.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.CustomImages.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.FillColor = Color.DarkRed;
			siticoneRoundedGradientButton2.FillColor2 = Color.DarkRed;
			siticoneRoundedGradientButton2.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton2.ForeColor = Color.White;
			siticoneRoundedGradientButton2.HoveredState.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.Location = new Point(144, 71);
			siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			siticoneRoundedGradientButton2.ShadowDecoration.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.Size = new Size(123, 23);
			siticoneRoundedGradientButton2.TabIndex = 107;
			siticoneRoundedGradientButton2.Text = "Minimize Session";
			siticoneRoundedGradientButton2.Click += siticoneRoundedGradientButton2Click;
			siticoneRoundedGradientButton1.BorderThickness = 1;
			siticoneRoundedGradientButton1.CheckedState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.CustomImages.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.FillColor = Color.DarkRed;
			siticoneRoundedGradientButton1.FillColor2 = Color.DarkRed;
			siticoneRoundedGradientButton1.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton1.ForeColor = Color.White;
			siticoneRoundedGradientButton1.HoveredState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Location = new Point(19, 71);
			siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
			siticoneRoundedGradientButton1.ShadowDecoration.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Size = new Size(123, 23);
			siticoneRoundedGradientButton1.TabIndex = 106;
			siticoneRoundedGradientButton1.Text = "End Session";
			siticoneRoundedGradientButton1.Click += siticoneRoundedGradientButton1Click;
			label1.AutoSize = true;
			label1.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.AppWorkspace;
			label1.Location = new Point(16, 113);
			label1.Name = "label1";
			label1.Size = new Size(77, 15);
			label1.TabIndex = 47;
			label1.Text = "OTHER OPTIONS:";
			label11.AutoSize = true;
			label11.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label11.ForeColor = SystemColors.AppWorkspace;
			label11.Location = new Point(16, 53);
			label11.Name = "label11";
			label11.Size = new Size(66, 15);
			label11.TabIndex = 43;
			label11.Text = "EXIT OPTIONS:";
			keyoutput.BackColor = Color.FromArgb(25, 26, 30);
			keyoutput.BorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.Controls.Add(siticoneRoundedGradientButton2);
			keyoutput.Controls.Add(label11);
			keyoutput.Controls.Add(siticoneRoundedGradientButton4);
			keyoutput.Controls.Add(siticoneRoundedGradientButton7);
			keyoutput.Controls.Add(siticoneRoundedGradientButton3);
			keyoutput.Controls.Add(siticoneRoundedGradientButton5);
			keyoutput.Controls.Add(label2);
			keyoutput.Controls.Add(siticoneRoundedGradientButton1);
			keyoutput.Controls.Add(label1);
			keyoutput.Controls.Add(siticoneRoundedGradientButton6);
			keyoutput.CustomBorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			keyoutput.Font = new Font("Segoe UI", 9f);
			keyoutput.ForeColor = Color.FromArgb(125, 137, 149);
			keyoutput.Location = new Point(12, 14);
			keyoutput.Name = "keyoutput";
			keyoutput.ShadowDecoration.Parent = keyoutput;
			keyoutput.Size = new Size(630, 545);
			keyoutput.TabIndex = 98;
			keyoutput.Text = "Spoofer Options";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(654, 571);
			base.Controls.Add(keyoutput);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "settingsterminate";
			Text = "settingsterminate";
			keyoutput.ResumeLayout(false);
			keyoutput.PerformLayout();
			ResumeLayout(false);
		}
	}
}
