using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class settingsappearance : Form
	{
		private int dashboard;

		private int green;

		private int spooferfixes;

		private IContainer dashboard;

		private Timer dashboard;

		private SiticoneRoundedButton siticoneRoundedButton7;

		private SiticoneRoundedButton siticoneRoundedButton6;

		private SiticoneGroupBox keyoutput;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		private Label label4;

		private Label label5;

		private Label label6;

		public SiticoneTrackBar green;

		public SiticoneTrackBar blue;

		public SiticoneTrackBar red;

		private SiticoneGroupBox siticoneGroupBox1;

		public settingsappearance()
		{
			System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard) = 255;
			System.Runtime.CompilerServices.Unsafe.As<SiticoneTrackBar, int>(ref this.green) = 0;
			spooferfixes = 0;
			this.dashboard = (Timer)AssistantHelper.dashboard;
			base._002Ector();
			MainLoad();
		}

		private void MainLoad(object sender, EventArgs param_514)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard) > 0 && spooferfixes == 0)
			{
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard)--;
				System.Runtime.CompilerServices.Unsafe.As<SiticoneTrackBar, int>(ref this.green)++;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<SiticoneTrackBar, int>(ref this.green) > 0 && System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.As<SiticoneTrackBar, int>(ref this.green)--;
				spooferfixes++;
			}
			if (spooferfixes > 0 && System.Runtime.CompilerServices.Unsafe.As<SiticoneTrackBar, int>(ref this.green) == 0)
			{
				spooferfixes--;
				System.Runtime.CompilerServices.Unsafe.As<Timer, int>(ref this.dashboard)++;
			}
		}

		private void settingsappearanceLoad(object sender, EventArgs param_516)
		{
			dashboard.Start();
		}

		private void stoppClick(object sender, EventArgs param_518)
		{
		}

		private void siticoneRoundedButton6Click(object sender, EventArgs param_520)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
				((Main)Application.OpenForms["Main"]).pictureBox1.ImageLocation = openFileDialog.FileName;
		}

		private void siticoneRoundedButton7Click(object sender, EventArgs param_522)
		{
			((Main)Application.OpenForms["Main"]).pictureBox1.Image = DeviceLayout._78_788100_fire_logo_png_svg_free_download_fire_logo;
		}

		private void xboxClick(object sender, EventArgs param_524)
		{
			((Main)Application.OpenForms["Main"]).green.Start();
		}

		private void siticoneRoundedGradientButton2Click(object sender, EventArgs param_526)
		{
			Main main = (Main)Application.OpenForms["Main"];
			main.siticonePanel1.FillColor = Color.FromArgb(red.Value, green.Value, blue.Value);
			main.red.Value = red.Value;
			((ProgressBar)(object)main.green).Value = green.Value;
			main.blue.Value = blue.Value;
		}

		private void biosClick(object sender, EventArgs param_528)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void MainLoad(object sender, ScrollEventArgs param_530)
		{
		}

		private void bsClick(object sender, ScrollEventArgs param_532)
		{
		}

		private void userinClick(object sender, EventArgs param_534)
		{
		}

		private void ReduceAddin(object sender, EventArgs param_536)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.dashboard > AssistantHelper.dashboard)
				((IDisposable)this.dashboard).Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			this.dashboard = (Timer)(object)new Container();
			siticoneRoundedButton7 = new SiticoneRoundedButton();
			siticoneRoundedButton6 = new SiticoneRoundedButton();
			dashboard = new Timer((IContainer)this.dashboard);
			keyoutput = new SiticoneGroupBox();
			siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			green = new SiticoneTrackBar();
			blue = new SiticoneTrackBar();
			red = new SiticoneTrackBar();
			siticoneGroupBox1 = new SiticoneGroupBox();
			keyoutput.SuspendLayout();
			siticoneGroupBox1.SuspendLayout();
			SuspendLayout();
			siticoneRoundedButton7.CheckedState.Parent = siticoneRoundedButton7;
			siticoneRoundedButton7.Cursor = Cursors.Hand;
			siticoneRoundedButton7.CustomImages.Parent = siticoneRoundedButton7;
			siticoneRoundedButton7.FillColor = Color.Gray;
			siticoneRoundedButton7.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedButton7.ForeColor = Color.White;
			siticoneRoundedButton7.HoveredState.Parent = siticoneRoundedButton7;
			siticoneRoundedButton7.Location = new Point(209, 51);
			siticoneRoundedButton7.Name = "siticoneRoundedButton7";
			siticoneRoundedButton7.ShadowDecoration.Parent = siticoneRoundedButton7;
			siticoneRoundedButton7.Size = new Size(103, 23);
			siticoneRoundedButton7.TabIndex = 40;
			siticoneRoundedButton7.Text = "Default";
			siticoneRoundedButton7.Click += siticoneRoundedButton7Click;
			siticoneRoundedButton6.CheckedState.Parent = siticoneRoundedButton6;
			siticoneRoundedButton6.Cursor = Cursors.Hand;
			siticoneRoundedButton6.CustomImages.Parent = siticoneRoundedButton6;
			siticoneRoundedButton6.FillColor = Color.FromArgb(41, 98, 255);
			siticoneRoundedButton6.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedButton6.ForeColor = Color.White;
			siticoneRoundedButton6.HoveredState.Parent = siticoneRoundedButton6;
			siticoneRoundedButton6.Location = new Point(11, 51);
			siticoneRoundedButton6.Name = "siticoneRoundedButton6";
			siticoneRoundedButton6.ShadowDecoration.Parent = siticoneRoundedButton6;
			siticoneRoundedButton6.Size = new Size(192, 23);
			siticoneRoundedButton6.TabIndex = 42;
			siticoneRoundedButton6.Text = "Change";
			siticoneRoundedButton6.Click += siticoneRoundedButton6Click;
			dashboard.Interval = 10;
			dashboard.Tick += MainLoad;
			keyoutput.BorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.Controls.Add(siticoneGroupBox1);
			keyoutput.Controls.Add(siticoneRoundedGradientButton2);
			keyoutput.Controls.Add(label4);
			keyoutput.Controls.Add(label5);
			keyoutput.Controls.Add(label6);
			keyoutput.Controls.Add(green);
			keyoutput.Controls.Add(blue);
			keyoutput.Controls.Add(red);
			keyoutput.CustomBorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			keyoutput.Font = new Font("Segoe UI", 9f);
			keyoutput.ForeColor = Color.FromArgb(125, 137, 149);
			keyoutput.Location = new Point(12, 12);
			keyoutput.Name = "keyoutput";
			keyoutput.ShadowDecoration.Parent = keyoutput;
			keyoutput.Size = new Size(630, 547);
			keyoutput.TabIndex = 98;
			keyoutput.Text = "Super Spoofer Appearance";
			siticoneRoundedGradientButton2.CheckedState.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.CustomImages.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.FillColor = Color.FromArgb(41, 98, 255);
			siticoneRoundedGradientButton2.FillColor2 = Color.FromArgb(41, 98, 255);
			siticoneRoundedGradientButton2.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton2.ForeColor = Color.White;
			siticoneRoundedGradientButton2.HoveredState.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.Location = new Point(15, 141);
			siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			siticoneRoundedGradientButton2.ShadowDecoration.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.Size = new Size(594, 23);
			siticoneRoundedGradientButton2.TabIndex = 51;
			siticoneRoundedGradientButton2.Text = "Change Theme Colour";
			siticoneRoundedGradientButton2.Click += siticoneRoundedGradientButton2Click;
			label4.AutoSize = true;
			label4.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(12, 112);
			label4.Name = "label4";
			label4.Size = new Size(37, 17);
			label4.TabIndex = 50;
			label4.Text = "BLUE";
			label5.AutoSize = true;
			label5.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.White;
			label5.Location = new Point(12, 83);
			label5.Name = "label5";
			label5.Size = new Size(49, 17);
			label5.TabIndex = 49;
			label5.Text = "GREEN";
			label6.AutoSize = true;
			label6.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(12, 54);
			label6.Name = "label6";
			label6.Size = new Size(32, 17);
			label6.TabIndex = 48;
			label6.Text = "RED";
			green.FillColor = Color.FromArgb(193, 200, 207);
			green.HoveredState.Parent = green;
			green.Location = new Point(65, 83);
			green.Maximum = 255;
			green.Name = "green";
			green.Size = new Size(544, 23);
			green.TabIndex = 47;
			green.ThumbColor = Color.Green;
			green.Value = 0;
			blue.FillColor = Color.FromArgb(193, 200, 207);
			blue.HoveredState.Parent = blue;
			blue.Location = new Point(65, 112);
			blue.Maximum = 255;
			blue.Name = "blue";
			blue.Size = new Size(544, 23);
			blue.TabIndex = 46;
			blue.ThumbColor = Color.DodgerBlue;
			blue.Value = 0;
			red.FillColor = Color.FromArgb(193, 200, 207);
			red.HoveredState.Parent = red;
			red.Location = new Point(65, 54);
			red.Maximum = 255;
			red.Name = "red";
			red.Size = new Size(544, 23);
			red.TabIndex = 45;
			red.ThumbColor = Color.Red;
			red.Value = 255;
			red.Scroll += bsClick;
			siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.Controls.Add(siticoneRoundedButton6);
			siticoneGroupBox1.Controls.Add(siticoneRoundedButton7);
			siticoneGroupBox1.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox1.Location = new Point(15, 445);
			siticoneGroupBox1.Name = "siticoneGroupBox1";
			siticoneGroupBox1.ShadowDecoration.Parent = siticoneGroupBox1;
			siticoneGroupBox1.Size = new Size(325, 89);
			siticoneGroupBox1.TabIndex = 99;
			siticoneGroupBox1.Text = "Super Spoofer Icon";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(654, 571);
			base.Controls.Add(keyoutput);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "settingsappearance";
			Text = "settingsappearance";
			base.Load += settingsappearanceLoad;
			keyoutput.ResumeLayout(false);
			keyoutput.PerformLayout();
			siticoneGroupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
