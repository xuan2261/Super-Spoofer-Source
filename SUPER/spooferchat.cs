using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class spooferchat : Form
	{
		private string dashboard;

		private IContainer dashboard;

		private Timer dashboard;

		private DataGridView dataGridView1;

		private DataGridViewTextBoxColumn dashboard = (DataGridViewTextBoxColumn)AssistantHelper.dashboard;

		private DataGridViewTextBoxColumn green;

		private DataGridViewTextBoxColumn spooferfixes;

		private PictureBox pictureBox1;

		private SiticoneCustomRadioButton appearance;

		private Label label1;

		private SiticoneButton status;

		private PictureBox send;

		private SiticoneTextBox chatmsg;

		private SiticoneButton sonline;

		private Panel panel1;

		private SiticoneGroupBox keyoutput;

		public spooferchat()
		{
			MainLoad();
		}

		private void MainLoad(object sender, EventArgs param_610)
		{
		}

		private void spooferchatLoad(object sender, EventArgs param_612)
		{
			((Timer)(object)this.dashboard).Start();
			label1.Text = Login.dashboard.dashboard.username;
		}

		public static void MainLoad(string string_0, string string_1, string string_2)
		{
			PartitionService.MainLoad(string_0, new NameValueCollection
			{
				{ "username", string_2 },
				{ "content", string_1 }
			});
		}

		public DateTime MainLoad(long long_0)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(long_0).ToLocalTime();
		}

		private void stoppClick(object sender, EventArgs param_618)
		{
			if (chatmsg.Text.Contains("scam") || chatmsg.Text.Contains("discord.") || chatmsg.Text.Contains("https") || chatmsg.Text.Contains(".com") || chatmsg.Text.Contains(".gg"))
			{
				chatmsg.Text = "";
				MessageBox.Show("Do not send links or use any banned words!", "Super Spoofer - Chat Ban Warn!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else if (Login.dashboard.bsClick(chatmsg.Text, (string)(object)this.dashboard))
			{
				string text = "6";
				chatmsg.Text = "";
				string text2 = "https://discord.com/api/webhooks/914615308554215496/ecK5YfftMoTJp3M8OuY3NHxEBfluFSLu8EQ2LXpDMr1-ByEc_JQ1o_fCDimo9-9V_AP";
				dataGridView1.Rows.Insert(0, "[ " + Login.dashboard.dashboard.username + " ]", chatmsg.Text, MainLoad(DateTimeOffset.Now.ToUnixTimeSeconds()));
				MainLoad(text2 + text, chatmsg.Text, Login.dashboard.dashboard.username);
			}
		}

		private void windowsClick(object sender, EventArgs param_620)
		{
			dataGridView1.Rows.Clear();
			((Timer)(object)this.dashboard).Interval = 3000;
			if (!string.IsNullOrEmpty((string)(object)this.dashboard))
			{
				List<VectorLayout.SymbolEventArgs> list = Login.dashboard.MainLoad((string)(object)this.dashboard);
				if (list == null || !list.Any())
				{
					dataGridView1.Rows.Insert(0, "[ SERVER ]", "No one has talked here yet, Be the first!");
					return;
				}
				foreach (VectorLayout.SymbolEventArgs item in list)
				{
					dataGridView1.Rows.Insert(0, "[ " + item.author + " ]", item.message, MainLoad(long.Parse(item.timestamp)));
				}
			}
			else
				dataGridView1.Rows.Insert(0, "[ SERVER ]", "No one has talked here yet, Be the first!");
		}

		private void gpuClick(object sender, EventArgs param_622)
		{
			dataGridView1.ClearSelection();
		}

		private void MainLoad(object sender, DataGridViewCellEventArgs param_624)
		{
		}

		private void xboxClick(object sender, EventArgs param_626)
		{
		}

		private void serialcheckersClick(object sender, EventArgs param_628)
		{
		}

		private void statusClick(object sender, EventArgs param_630)
		{
			appearance.CheckedState.BorderColor = Color.FromArgb(192, 0, 0);
			appearance.CheckedState.FillColor = Color.FromArgb(192, 0, 0);
			appearance.CheckedState.InnerColor = Color.FromArgb(192, 0, 0);
			send.Enabled = false;
			chatmsg.Enabled = false;
			chatmsg.Text = "Chat Disabled; Appearing Offline!";
			status.Visible = false;
			sonline.Visible = true;
		}

		private void sendClick(object sender, EventArgs param_632)
		{
			if (chatmsg.Text.Contains("scam") || chatmsg.Text.Contains("discord.") || chatmsg.Text.Contains("https") || chatmsg.Text.Contains(".com") || chatmsg.Text.Contains(".gg"))
			{
				chatmsg.Text = "";
				MessageBox.Show("Do not send links or use any banned words!", "Super Spoofer - Chat Ban Warn!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
				Login.dashboard.bsClick(chatmsg.Text, (string)(object)this.dashboard);
		}

		private void sonlineClick(object sender, EventArgs param_634)
		{
			appearance.CheckedState.BorderColor = Color.Lime;
			appearance.CheckedState.FillColor = Color.Lime;
			appearance.CheckedState.InnerColor = Color.Lime;
			send.Enabled = true;
			chatmsg.Enabled = true;
			chatmsg.Text = "";
			sonline.Visible = false;
			status.Visible = true;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.dashboard > AssistantHelper.dashboard)
				((IDisposable)this.dashboard).Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			this.dashboard = (DataGridViewTextBoxColumn)(object)new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(spooferchat));
			dataGridView1 = new DataGridView();
			dashboard = new DataGridViewTextBoxColumn();
			green = new DataGridViewTextBoxColumn();
			spooferfixes = new DataGridViewTextBoxColumn();
			this.dashboard = (DataGridViewTextBoxColumn)(object)new Timer((IContainer)this.dashboard);
			chatmsg = new SiticoneTextBox();
			send = new PictureBox();
			pictureBox1 = new PictureBox();
			appearance = new SiticoneCustomRadioButton();
			label1 = new Label();
			status = new SiticoneButton();
			sonline = new SiticoneButton();
			panel1 = new Panel();
			keyoutput = new SiticoneGroupBox();
			((ISupportInitialize)dataGridView1).BeginInit();
			((ISupportInitialize)send).BeginInit();
			((ISupportInitialize)pictureBox1).BeginInit();
			keyoutput.SuspendLayout();
			SuspendLayout();
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle.ForeColor = Color.White;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(25, 26, 30);
			dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			dataGridView1.BackgroundColor = Color.FromArgb(25, 26, 30);
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView1.ColumnHeadersVisible = false;
			dataGridView1.Columns.AddRange(dashboard, green, spooferfixes);
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
			dataGridView1.GridColor = Color.FromArgb(25, 26, 30);
			dataGridView1.Location = new Point(13, 48);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(25, 26, 30);
			dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(25, 26, 30);
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
			dataGridView1.ScrollBars = ScrollBars.None;
			dataGridView1.ShowCellErrors = false;
			dataGridView1.ShowCellToolTips = false;
			dataGridView1.ShowEditingIcon = false;
			dataGridView1.ShowRowErrors = false;
			dataGridView1.Size = new Size(667, 488);
			dataGridView1.TabIndex = 117;
			dataGridView1.CellContentClick += MainLoad;
			dataGridView1.SelectionChanged += gpuClick;
			dashboard.HeaderText = "user";
			dashboard.Name = "Sender";
			dashboard.ReadOnly = true;
			dashboard.Width = 140;
			green.HeaderText = "Message";
			green.Name = "Message";
			green.ReadOnly = true;
			green.Width = 540;
			spooferfixes.HeaderText = "time";
			spooferfixes.Name = "time";
			spooferfixes.ReadOnly = true;
			spooferfixes.Width = 150;
			((Timer)(object)this.dashboard).Tick += windowsClick;
			chatmsg.BorderColor = Color.FromArgb(37, 39, 43);
			chatmsg.BorderRadius = 2;
			chatmsg.Cursor = Cursors.IBeam;
			chatmsg.DefaultText = "";
			chatmsg.DisabledState.BorderColor = Color.FromArgb(37, 39, 43);
			chatmsg.DisabledState.FillColor = Color.FromArgb(49, 51, 57);
			chatmsg.DisabledState.ForeColor = Color.FromArgb(155, 157, 161);
			chatmsg.DisabledState.Parent = chatmsg;
			chatmsg.DisabledState.PlaceholderForeColor = Color.FromArgb(193, 200, 207);
			chatmsg.FillColor = Color.FromArgb(49, 51, 57);
			chatmsg.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			chatmsg.FocusedState.Parent = chatmsg;
			chatmsg.ForeColor = Color.FromArgb(155, 157, 161);
			chatmsg.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			chatmsg.HoveredState.Parent = chatmsg;
			chatmsg.Location = new Point(13, 545);
			chatmsg.Margin = new Padding(4, 3, 4, 3);
			chatmsg.Name = "chatmsg";
			chatmsg.PasswordChar = '\0';
			chatmsg.PlaceholderText = "";
			chatmsg.SelectedText = "";
			chatmsg.ShadowDecoration.Parent = chatmsg;
			chatmsg.Size = new Size(614, 27);
			chatmsg.TabIndex = 119;
			send.Cursor = Cursors.Hand;
			send.Image = (Image)componentResourceManager.GetObject("send.Image");
			send.Location = new Point(634, 545);
			send.Name = "send";
			send.Size = new Size(46, 27);
			send.SizeMode = PictureBoxSizeMode.Zoom;
			send.TabIndex = 119;
			send.TabStop = false;
			send.Click += sendClick;
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(138, 116);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 118;
			pictureBox1.TabStop = false;
			appearance.Checked = true;
			appearance.CheckedState.BorderColor = Color.Lime;
			appearance.CheckedState.BorderThickness = 0;
			appearance.CheckedState.FillColor = Color.Lime;
			appearance.CheckedState.InnerColor = Color.Lime;
			appearance.CheckedState.Parent = appearance;
			appearance.Location = new Point(12, 4);
			appearance.Name = "appearance";
			appearance.ShadowDecoration.Parent = appearance;
			appearance.Size = new Size(20, 20);
			appearance.TabIndex = 118;
			appearance.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			appearance.UncheckedState.BorderThickness = 2;
			appearance.UncheckedState.FillColor = Color.Transparent;
			appearance.UncheckedState.InnerColor = Color.Transparent;
			appearance.UncheckedState.Parent = appearance;
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(12, 127);
			label1.Name = "label1";
			label1.Size = new Size(41, 16);
			label1.TabIndex = 118;
			label1.Text = "label1";
			status.CheckedState.Parent = status;
			status.CustomImages.Parent = status;
			status.FillColor = Color.FromArgb(192, 0, 0);
			status.Font = new Font("Courier New", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			status.ForeColor = Color.White;
			status.HoveredState.Parent = status;
			status.Location = new Point(12, 159);
			status.Name = "status";
			status.ShadowDecoration.Parent = status;
			status.Size = new Size(138, 25);
			status.TabIndex = 118;
			status.Text = "Appear Offline";
			status.Click += statusClick;
			sonline.CheckedState.Parent = sonline;
			sonline.CustomImages.Parent = sonline;
			sonline.FillColor = Color.LimeGreen;
			sonline.Font = new Font("Courier New", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			sonline.ForeColor = Color.White;
			sonline.HoveredState.Parent = sonline;
			sonline.Location = new Point(12, 159);
			sonline.Name = "sonline";
			sonline.ShadowDecoration.Parent = sonline;
			sonline.Size = new Size(138, 25);
			sonline.TabIndex = 119;
			sonline.Text = "Appear Online";
			sonline.Visible = false;
			sonline.Click += sonlineClick;
			panel1.BackColor = Color.Gray;
			panel1.Location = new Point(12, 152);
			panel1.Name = "panel1";
			panel1.Size = new Size(138, 1);
			panel1.TabIndex = 118;
			keyoutput.BorderColor = Color.FromArgb(65, 71, 85);
			keyoutput.Controls.Add(chatmsg);
			keyoutput.Controls.Add(send);
			keyoutput.Controls.Add(dataGridView1);
			keyoutput.CustomBorderColor = Color.White;
			keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			keyoutput.Font = new Font("Segoe UI", 9f);
			keyoutput.ForeColor = Color.FromArgb(125, 137, 149);
			keyoutput.Location = new Point(164, 4);
			keyoutput.Name = "keyoutput";
			keyoutput.ShadowDecoration.Parent = keyoutput;
			keyoutput.Size = new Size(697, 581);
			keyoutput.TabIndex = 118;
			keyoutput.Text = "superspoofer.cc Group Chat";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 597);
			base.Controls.Add(sonline);
			base.Controls.Add(status);
			base.Controls.Add(panel1);
			base.Controls.Add(label1);
			base.Controls.Add(appearance);
			base.Controls.Add(pictureBox1);
			base.Controls.Add(keyoutput);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "spooferchat";
			Text = "spooferchat";
			base.Load += spooferchatLoad;
			((ISupportInitialize)dataGridView1).EndInit();
			((ISupportInitialize)send).EndInit();
			((ISupportInitialize)pictureBox1).EndInit();
			keyoutput.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
