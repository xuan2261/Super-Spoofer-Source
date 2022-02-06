using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class WebhookTool : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private SiticoneGroupBox keyoutput;

		private SiticoneTextBox singmgs;

		private Label label5;

		private SiticoneTextBox singuser;

		private Label label1;

		private SiticoneTextBox singweb;

		private Label label8;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton6;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		public WebhookTool()
		{
			stoppClick();
		}

		public static void MainLoad(string string_0, string string_1)
		{
			WebRequest webRequest = WebRequest.Create(string_0);
			webRequest.ContentType = "application/json";
			webRequest.Method = "POST";
			using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
				streamWriter.Write(string_1);
			webRequest.GetResponse();
		}

		public static void MainLoad(string string_0, string string_1, string string_2)
		{
			PartitionService.MainLoad(string_0, new NameValueCollection
			{
				{ "username", string_2 },
				{ "content", string_1 }
			});
		}

		private void MainLoad(object sender, EventArgs param_643)
		{
		}

		private async void bsClick(object sender, EventArgs param_645)
		{
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
		}

		private void stoppClick(object sender, EventArgs param_647)
		{
		}

		private void bsClick()
		{
		}

		private void WebhookToolLoad(object sender, EventArgs param_649)
		{
		}

		private async void gpuClick(object sender, EventArgs param_651)
		{
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
			bsClick();
			await Task.Delay(200);
		}

		private void xboxClick(object sender, EventArgs param_653)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(singweb.Text);
				webRequest.Method = "DELETE";
				_ = (HttpWebResponse)webRequest.GetResponse();
			}
			catch (Exception)
			{
				MessageBox.Show("Webhook is not found! Cannot delete", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void siticoneRoundedGradientButton5Click(object sender, EventArgs param_655)
		{
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
		}

		private async void siticoneRoundedGradientButton6Click(object sender, EventArgs param_657)
		{
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
			await Task.Delay(200);
			MainLoad(singweb.Text, singmgs.Text, singuser.Text);
		}

		private void siticoneRoundedGradientButton3Click(object sender, EventArgs param_659)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(singweb.Text);
				webRequest.Method = "DELETE";
				_ = (HttpWebResponse)webRequest.GetResponse();
			}
			catch (Exception)
			{
				MessageBox.Show("Webhook is not found! Cannot delete", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void stoppClick()
		{
			keyoutput = new SiticoneGroupBox();
			siticoneRoundedGradientButton6 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton5 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			singmgs = new SiticoneTextBox();
			label5 = new Label();
			singuser = new SiticoneTextBox();
			label1 = new Label();
			singweb = new SiticoneTextBox();
			label8 = new Label();
			keyoutput.SuspendLayout();
			SuspendLayout();
			keyoutput.BorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.Controls.Add(siticoneRoundedGradientButton6);
			keyoutput.Controls.Add(siticoneRoundedGradientButton5);
			keyoutput.Controls.Add(siticoneRoundedGradientButton3);
			keyoutput.Controls.Add(singmgs);
			keyoutput.Controls.Add(label5);
			keyoutput.Controls.Add(singuser);
			keyoutput.Controls.Add(label1);
			keyoutput.Controls.Add(singweb);
			keyoutput.Controls.Add(label8);
			keyoutput.CustomBorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			keyoutput.Font = new Font("Segoe UI", 9f);
			keyoutput.ForeColor = Color.FromArgb(125, 137, 149);
			keyoutput.Location = new Point(237, 81);
			keyoutput.Name = "keyoutput";
			keyoutput.ShadowDecoration.Parent = keyoutput;
			keyoutput.Size = new Size(399, 374);
			keyoutput.TabIndex = 115;
			keyoutput.Text = "Webhook Spammer";
			siticoneRoundedGradientButton6.BorderThickness = 1;
			siticoneRoundedGradientButton6.CheckedState.Parent = siticoneRoundedGradientButton6;
			siticoneRoundedGradientButton6.CustomImages.Parent = siticoneRoundedGradientButton6;
			siticoneRoundedGradientButton6.FillColor = Color.DimGray;
			siticoneRoundedGradientButton6.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton6.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton6.ForeColor = Color.White;
			siticoneRoundedGradientButton6.HoveredState.Parent = siticoneRoundedGradientButton6;
			siticoneRoundedGradientButton6.Location = new Point(208, 220);
			siticoneRoundedGradientButton6.Name = "siticoneRoundedGradientButton6";
			siticoneRoundedGradientButton6.ShadowDecoration.Parent = siticoneRoundedGradientButton6;
			siticoneRoundedGradientButton6.Size = new Size(178, 30);
			siticoneRoundedGradientButton6.TabIndex = 118;
			siticoneRoundedGradientButton6.Text = "Spam Message";
			siticoneRoundedGradientButton6.Click += siticoneRoundedGradientButton6Click;
			siticoneRoundedGradientButton5.BorderThickness = 1;
			siticoneRoundedGradientButton5.CheckedState.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.CustomImages.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.FillColor = Color.DimGray;
			siticoneRoundedGradientButton5.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton5.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton5.ForeColor = Color.White;
			siticoneRoundedGradientButton5.HoveredState.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.Location = new Point(17, 220);
			siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
			siticoneRoundedGradientButton5.ShadowDecoration.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.Size = new Size(178, 30);
			siticoneRoundedGradientButton5.TabIndex = 117;
			siticoneRoundedGradientButton5.Text = "Send Message";
			siticoneRoundedGradientButton5.Click += siticoneRoundedGradientButton5Click;
			siticoneRoundedGradientButton3.BorderThickness = 1;
			siticoneRoundedGradientButton3.CheckedState.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.CustomImages.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.FillColor = Color.DarkRed;
			siticoneRoundedGradientButton3.FillColor2 = Color.DarkRed;
			siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton3.ForeColor = Color.White;
			siticoneRoundedGradientButton3.HoveredState.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.Location = new Point(17, 331);
			siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			siticoneRoundedGradientButton3.ShadowDecoration.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.Size = new Size(369, 30);
			siticoneRoundedGradientButton3.TabIndex = 116;
			siticoneRoundedGradientButton3.Text = "Delete Webhook";
			siticoneRoundedGradientButton3.Click += siticoneRoundedGradientButton3Click;
			singmgs.BorderColor = Color.FromArgb(79, 84, 103);
			singmgs.Cursor = Cursors.No;
			singmgs.DefaultText = "";
			singmgs.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			singmgs.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			singmgs.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			singmgs.DisabledState.Parent = singmgs;
			singmgs.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			singmgs.FillColor = Color.FromArgb(25, 26, 30);
			singmgs.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			singmgs.FocusedState.Parent = singmgs;
			singmgs.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			singmgs.HoveredState.Parent = singmgs;
			singmgs.Location = new Point(17, 184);
			singmgs.Name = "singmgs";
			singmgs.PasswordChar = '\0';
			singmgs.PlaceholderText = "";
			singmgs.SelectedText = "";
			singmgs.ShadowDecoration.Parent = singmgs;
			singmgs.Size = new Size(369, 30);
			singmgs.TabIndex = 102;
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.White;
			label5.Location = new Point(14, 168);
			label5.Name = "label5";
			label5.Size = new Size(56, 13);
			label5.TabIndex = 101;
			label5.Text = "Message:";
			singuser.BorderColor = Color.FromArgb(79, 84, 103);
			singuser.Cursor = Cursors.No;
			singuser.DefaultText = "";
			singuser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			singuser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			singuser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			singuser.DisabledState.Parent = singuser;
			singuser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			singuser.FillColor = Color.FromArgb(25, 26, 30);
			singuser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			singuser.FocusedState.Parent = singuser;
			singuser.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			singuser.HoveredState.Parent = singuser;
			singuser.Location = new Point(17, 125);
			singuser.Name = "singuser";
			singuser.PasswordChar = '\0';
			singuser.PlaceholderText = "";
			singuser.SelectedText = "";
			singuser.ShadowDecoration.Parent = singuser;
			singuser.Size = new Size(369, 30);
			singuser.TabIndex = 100;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(14, 109);
			label1.Name = "label1";
			label1.Size = new Size(62, 13);
			label1.TabIndex = 99;
			label1.Text = "Nickname:";
			singweb.BorderColor = Color.FromArgb(79, 84, 103);
			singweb.Cursor = Cursors.No;
			singweb.DefaultText = "";
			singweb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			singweb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			singweb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			singweb.DisabledState.Parent = singweb;
			singweb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			singweb.FillColor = Color.FromArgb(25, 26, 30);
			singweb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			singweb.FocusedState.Parent = singweb;
			singweb.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			singweb.HoveredState.Parent = singweb;
			singweb.Location = new Point(17, 67);
			singweb.Name = "singweb";
			singweb.PasswordChar = '\0';
			singweb.PlaceholderText = "";
			singweb.SelectedText = "";
			singweb.ShadowDecoration.Parent = singweb;
			singweb.Size = new Size(369, 30);
			singweb.TabIndex = 98;
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.White;
			label8.Location = new Point(14, 51);
			label8.Name = "label8";
			label8.Size = new Size(61, 13);
			label8.TabIndex = 53;
			label8.Text = "Webhook:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 597);
			base.Controls.Add(keyoutput);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "WebhookTool";
			Text = "WebhookTool";
			base.Load += WebhookToolLoad;
			keyoutput.ResumeLayout(false);
			keyoutput.PerformLayout();
			ResumeLayout(false);
		}
	}
}
