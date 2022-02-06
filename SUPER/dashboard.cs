using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SUPER
{
	public sealed class dashboard : Form
	{
		private IContainer m_dashboard;

		private PictureBox pictureBox2;

		private PictureBox pictureBox3;

		private PictureBox pictureBox4;

		private Label label1;

		private Timer m_dashboard = (Timer)AssistantHelper.dashboard;

		private Label label3;

		private Label label4;

		public dashboard()
		{
			MainLoad();
		}

		public DateTime MainLoad(long long_0)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(long_0).ToLocalTime();
		}

		private void dashboardLoad(object sender, EventArgs param_221)
		{
			m_dashboard.Start();
			label4.Text = "Welcome back, " + Login.dashboard.dashboard.username;
		}

		private void pictureBox3Click(object sender, EventArgs param_223)
		{
			try
			{
				Process.Start("https://discord.gg/wCfaK3pb42");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not open the link, turn antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void pictureBox4Click(object sender, EventArgs param_225)
		{
			try
			{
				Process.Start("https://t.me/superwooferx");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not open the link, turn antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void pictureBox2Click(object sender, EventArgs param_227)
		{
			try
			{
				Process.Start("https://shoppy.gg/@SuperCheats");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not open the link, turn antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void gpuClick(object sender, EventArgs param_229)
		{
			try
			{
				Process.Start("https://www.youtube.com/channel/UCdrb1_w3DUFkPNZ6Q7fX3ZQ");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not open the link, turn antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void xboxClick(object sender, EventArgs param_231)
		{
			DateTime now = DateTime.Now;
			label1.Text = now.ToString();
		}

		private void serialcheckersClick(object sender, EventArgs param_233)
		{
		}

		private void biosClick(object sender, EventArgs param_235)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.m_dashboard > AssistantHelper.dashboard)
				((IDisposable)this.m_dashboard).Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			this.m_dashboard = (Timer)(object)new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(dashboard));
			label1 = new Label();
			m_dashboard = new Timer((IContainer)this.m_dashboard);
			pictureBox4 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox2 = new PictureBox();
			label3 = new Label();
			label4 = new Label();
			((ISupportInitialize)pictureBox4).BeginInit();
			((ISupportInitialize)pictureBox3).BeginInit();
			((ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Font = new Font("Lucida Console", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(28, 54);
			label1.Name = "label1";
			label1.Size = new Size(67, 16);
			label1.TabIndex = 5;
			label1.Text = "label1";
			m_dashboard.Tick += xboxClick;
			pictureBox4.Cursor = Cursors.Hand;
			pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(714, 555);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(45, 30);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 3;
			pictureBox4.TabStop = false;
			pictureBox4.Click += pictureBox4Click;
			pictureBox3.Cursor = Cursors.Hand;
			pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(765, 555);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(45, 30);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 2;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3Click;
			pictureBox2.Cursor = Cursors.Hand;
			pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(816, 555);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(45, 30);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2Click;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Franklin Gothic Medium", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(717, 12);
			label3.Name = "label3";
			label3.Size = new Size(144, 42);
			label3.TabIndex = 72;
			label3.Text = "Build: Jan 19 2022 \r\nBuild Version: 3.0.0";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label4.AutoSize = true;
			label4.Font = new Font("Ebrima", 21.75f, FontStyle.Bold);
			label4.ForeColor = Color.White;
			label4.Location = new Point(24, 12);
			label4.Name = "label4";
			label4.Size = new Size(274, 40);
			label4.TabIndex = 105;
			label4.Text = "Welcome back, ....!";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 597);
			base.Controls.Add(label4);
			base.Controls.Add(label3);
			base.Controls.Add(label1);
			base.Controls.Add(pictureBox4);
			base.Controls.Add(pictureBox3);
			base.Controls.Add(pictureBox2);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "dashboard";
			Text = "dashboard";
			base.Load += dashboardLoad;
			((ISupportInitialize)pictureBox4).EndInit();
			((ISupportInitialize)pictureBox3).EndInit();
			((ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
