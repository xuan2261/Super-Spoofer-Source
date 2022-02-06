using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class spooferfixes : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private PictureBox pictureBox1;

		private PictureBox pictureBox2;

		private SiticoneRoundedButton windows;

		private SiticoneRoundedButton bs;

		private SiticoneRoundedButton stopp;

		private SiticoneGroupBox siticoneGroupBox3;

		private SiticoneGroupBox siticoneGroupBox1;

		private SiticoneRoundedButton xbox;

		private SiticoneGroupBox siticoneGroupBox5;

		private SiticoneGroupBox siticoneGroupBox4;

		private SiticoneGroupBox siticoneGroupBox2;

		private PictureBox pictureBox5;

		private PictureBox pictureBox3;

		public spooferfixes()
		{
			MainLoad();
		}

		private void spooferfixesLoad(object sender, EventArgs param_361)
		{
		}

		private void bsClick(object sender, EventArgs param_363)
		{
			try
			{
				string text = Path.GetTempPath() + "\\BSOD.bat";
				StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.Write("@echo off");
				streamWriter.Write("\necho WAIT FOR THIS TO FINISH");
				streamWriter.Write("\necho WAIT FOR THIS TO FINISH");
				streamWriter.Write("\necho WAIT FOR THIS TO FINISH");
				streamWriter.Write("\nDISM /Online /Cleanup-Image /RestoreHealth");
				streamWriter.Write("\nsfc /scannow");
				streamWriter.Write("\npause >nul");
				streamWriter.Close();
				Process.Start(text);
			}
			catch (Exception)
			{
				MessageBox.Show("Could not fix BS, turn antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void stoppClick(object sender, EventArgs param_365)
		{
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true))
					registryKey.DeleteValue("c");
				MessageBox.Show("Removed perm spoof, you can reactivate any time!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("Could not undo perm spoof, You never activated perm spoof!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void windowsClick(object sender, EventArgs param_367)
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/896100252996755456/Activation.exe", "C:\\Windows\\Activation.exe");
				Process.Start("C:\\Windows\\Activation.exe");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not fix [WIN-ACTIVATE] the main error would be that we cannot download the fixer, then antivirus off and try again!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void gpuClick(object sender, EventArgs param_369)
		{
		}

		private void xboxClick(object sender, EventArgs param_371)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void pictureBox5Click(object sender, EventArgs param_373)
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(spooferfixes));
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			windows = new SiticoneRoundedButton();
			bs = new SiticoneRoundedButton();
			stopp = new SiticoneRoundedButton();
			siticoneGroupBox3 = new SiticoneGroupBox();
			siticoneGroupBox5 = new SiticoneGroupBox();
			siticoneGroupBox4 = new SiticoneGroupBox();
			pictureBox3 = new PictureBox();
			siticoneGroupBox2 = new SiticoneGroupBox();
			pictureBox5 = new PictureBox();
			siticoneGroupBox1 = new SiticoneGroupBox();
			xbox = new SiticoneRoundedButton();
			((ISupportInitialize)pictureBox1).BeginInit();
			((ISupportInitialize)pictureBox2).BeginInit();
			siticoneGroupBox3.SuspendLayout();
			siticoneGroupBox5.SuspendLayout();
			siticoneGroupBox4.SuspendLayout();
			((ISupportInitialize)pictureBox3).BeginInit();
			siticoneGroupBox2.SuspendLayout();
			((ISupportInitialize)pictureBox5).BeginInit();
			siticoneGroupBox1.SuspendLayout();
			SuspendLayout();
			pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 44);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(197, 72);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 44);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(197, 72);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			windows.CheckedState.Parent = windows;
			windows.Cursor = Cursors.Hand;
			windows.CustomImages.Parent = windows;
			windows.FillColor = Color.FromArgb(7, 6, 24);
			windows.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			windows.ForeColor = Color.White;
			windows.HoveredState.Parent = windows;
			windows.Location = new Point(12, 122);
			windows.Name = "windows";
			windows.ShadowDecoration.Parent = windows;
			windows.Size = new Size(197, 20);
			windows.TabIndex = 2;
			windows.Text = "Reactivate Windows";
			windows.Click += windowsClick;
			bs.CheckedState.Parent = bs;
			bs.Cursor = Cursors.Hand;
			bs.CustomImages.Parent = bs;
			bs.FillColor = Color.FromArgb(7, 6, 24);
			bs.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			bs.ForeColor = Color.White;
			bs.HoveredState.Parent = bs;
			bs.Location = new Point(12, 122);
			bs.Name = "bs";
			bs.ShadowDecoration.Parent = bs;
			bs.Size = new Size(197, 20);
			bs.TabIndex = 2;
			bs.Text = "Prevent Bluescreen";
			bs.Click += bsClick;
			stopp.CheckedState.Parent = stopp;
			stopp.Cursor = Cursors.Hand;
			stopp.CustomImages.Parent = stopp;
			stopp.FillColor = Color.FromArgb(7, 6, 24);
			stopp.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			stopp.ForeColor = Color.White;
			stopp.HoveredState.Parent = stopp;
			stopp.Location = new Point(11, 122);
			stopp.Name = "stopp";
			stopp.ShadowDecoration.Parent = stopp;
			stopp.Size = new Size(197, 20);
			stopp.TabIndex = 2;
			stopp.Text = "Terinate Perm-Spoof";
			stopp.Click += stoppClick;
			siticoneGroupBox3.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox3.Controls.Add(siticoneGroupBox5);
			siticoneGroupBox3.Controls.Add(siticoneGroupBox4);
			siticoneGroupBox3.Controls.Add(siticoneGroupBox2);
			siticoneGroupBox3.Controls.Add(siticoneGroupBox1);
			siticoneGroupBox3.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox3.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox3.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox3.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox3.Location = new Point(13, 12);
			siticoneGroupBox3.Name = "siticoneGroupBox3";
			siticoneGroupBox3.ShadowDecoration.Parent = siticoneGroupBox3;
			siticoneGroupBox3.Size = new Size(848, 370);
			siticoneGroupBox3.TabIndex = 97;
			siticoneGroupBox3.Text = "Super Spoofer - Fixes";
			siticoneGroupBox5.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox5.Controls.Add(pictureBox2);
			siticoneGroupBox5.Controls.Add(windows);
			siticoneGroupBox5.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox5.FillColor = Color.FromArgb(50, 55, 67);
			siticoneGroupBox5.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox5.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox5.Location = new Point(420, 209);
			siticoneGroupBox5.Name = "siticoneGroupBox5";
			siticoneGroupBox5.ShadowDecoration.Parent = siticoneGroupBox5;
			siticoneGroupBox5.Size = new Size(219, 149);
			siticoneGroupBox5.TabIndex = 99;
			siticoneGroupBox5.Text = "Reactivate Corrupted Windows";
			siticoneGroupBox4.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox4.Controls.Add(pictureBox3);
			siticoneGroupBox4.Controls.Add(stopp);
			siticoneGroupBox4.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox4.FillColor = Color.FromArgb(50, 55, 67);
			siticoneGroupBox4.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox4.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox4.Location = new Point(195, 209);
			siticoneGroupBox4.Name = "siticoneGroupBox4";
			siticoneGroupBox4.ShadowDecoration.Parent = siticoneGroupBox4;
			siticoneGroupBox4.Size = new Size(219, 149);
			siticoneGroupBox4.TabIndex = 98;
			siticoneGroupBox4.Text = "Terminate Perm Spoof";
			pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(12, 44);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(197, 72);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 5;
			pictureBox3.TabStop = false;
			siticoneGroupBox2.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox2.Controls.Add(bs);
			siticoneGroupBox2.Controls.Add(pictureBox5);
			siticoneGroupBox2.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox2.FillColor = Color.FromArgb(50, 55, 67);
			siticoneGroupBox2.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox2.Location = new Point(420, 54);
			siticoneGroupBox2.Name = "siticoneGroupBox2";
			siticoneGroupBox2.ShadowDecoration.Parent = siticoneGroupBox2;
			siticoneGroupBox2.Size = new Size(219, 149);
			siticoneGroupBox2.TabIndex = 98;
			siticoneGroupBox2.Text = "Prevent Bluescreens";
			pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(12, 44);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(197, 72);
			pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 98;
			pictureBox5.TabStop = false;
			pictureBox5.Click += pictureBox5Click;
			siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.Controls.Add(xbox);
			siticoneGroupBox1.Controls.Add(pictureBox1);
			siticoneGroupBox1.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.FillColor = Color.FromArgb(50, 55, 67);
			siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox1.Location = new Point(195, 54);
			siticoneGroupBox1.Name = "siticoneGroupBox1";
			siticoneGroupBox1.ShadowDecoration.Parent = siticoneGroupBox1;
			siticoneGroupBox1.Size = new Size(219, 149);
			siticoneGroupBox1.TabIndex = 97;
			siticoneGroupBox1.Text = "Relink Xbox Account";
			xbox.CheckedState.Parent = xbox;
			xbox.Cursor = Cursors.Hand;
			xbox.CustomImages.Parent = xbox;
			xbox.FillColor = Color.FromArgb(7, 6, 24);
			xbox.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			xbox.ForeColor = Color.White;
			xbox.HoveredState.Parent = xbox;
			xbox.Location = new Point(12, 122);
			xbox.Name = "xbox";
			xbox.ShadowDecoration.Parent = xbox;
			xbox.Size = new Size(197, 20);
			xbox.TabIndex = 97;
			xbox.Text = "Relink Xbox Account";
			xbox.Click += xboxClick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 597);
			base.Controls.Add(siticoneGroupBox3);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "spooferfixes";
			Text = "spooferfixes";
			base.Load += spooferfixesLoad;
			((ISupportInitialize)pictureBox1).EndInit();
			((ISupportInitialize)pictureBox2).EndInit();
			siticoneGroupBox3.ResumeLayout(false);
			siticoneGroupBox5.ResumeLayout(false);
			siticoneGroupBox4.ResumeLayout(false);
			((ISupportInitialize)pictureBox3).EndInit();
			siticoneGroupBox2.ResumeLayout(false);
			((ISupportInitialize)pictureBox5).EndInit();
			siticoneGroupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
