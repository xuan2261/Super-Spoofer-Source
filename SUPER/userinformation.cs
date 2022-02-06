using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DiscordRPC;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class userinformation : Form
	{
		private IContainer dashboard;

		private Panel panel1;

		private ColorWithAlpha dashboard;

		private SiticonePanel siticonePanel2;

		private SiticoneGradientButton lockedserials;

		private SiticoneGradientButton userdetails;

		private SiticoneGradientButton upgradesub;

		private SiticoneGradientButton subscriptions;

		private Label label5;

		private Label label2;

		private SiticoneGradientButton application;

		private Label label9;

		private SiticoneGradientButton appearance;

		private ColorDialog dashboard = (ColorDialog)AssistantHelper.dashboard;

		private AlphaGradientPanel mainn;

		private SiticoneGradientButton siticoneGradientButton1;

		public userinformation()
		{
			bsClick();
		}

		private void panel1Paint(object sender, PaintEventArgs param_434)
		{
			mainn.Controls.Clear();
			settingsuserdetails settingsuserdetails2 = new settingsuserdetails
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			settingsuserdetails2.FormBorderStyle = FormBorderStyle.None;
			mainn.Controls.Add(settingsuserdetails2);
			settingsuserdetails2.Show();
		}

		public DateTime MainLoad(long long_0)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(long_0).ToLocalTime();
		}

		public string MainLoad()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		private void userinformationLoad(object sender, EventArgs param_437)
		{
		}

		private void bsClick(object sender, EventArgs param_439)
		{
		}

		private void stoppClick(object sender, EventArgs param_441)
		{
		}

		private void windowsClick(object sender, EventArgs param_443)
		{
		}

		private void gpuClick(object sender, EventArgs param_445)
		{
		}

		private void xboxClick(object sender, EventArgs param_447)
		{
		}

		public static void MainLoad()
		{
			DiscordRpcClient discordRpcClient = new DiscordRpcClient("899385349929828393");
			discordRpcClient.Initialize();
			discordRpcClient.SetPresence(new RichPresence
			{
				Details = "Best Working Spoofer!",
				State = "> discord.gg/EByg4K9TwC",
				Timestamps = Timestamps.Now,
				Assets = new Assets
				{
					LargeImageKey = "saper",
					LargeImageText = "#1 SPOOFER",
					SmallImageKey = "discord",
					SmallImageText = "discord.gg/EByg4K9TwC"
				}
			});
		}

		private void serialcheckersClick(object sender, EventArgs param_449)
		{
		}

		private void biosClick(object sender, EventArgs param_451)
		{
		}

		private void userinClick(object sender, EventArgs param_453)
		{
		}

		private void lockedserialsClick(object sender, EventArgs param_455)
		{
			mainn.Controls.Clear();
			settingslockedserials settingslockedserials2 = new settingslockedserials
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			settingslockedserials2.FormBorderStyle = FormBorderStyle.None;
			mainn.Controls.Add(settingslockedserials2);
			settingslockedserials2.Show();
			lockedserials.CustomBorderColor = Color.White;
			lockedserials.FillColor = Color.FromArgb(50, 50, 50);
			lockedserials.FillColor2 = Color.FromArgb(50, 50, 50);
			userdetails.CustomBorderColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor2 = Color.FromArgb(31, 31, 31);
			subscriptions.CustomBorderColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor2 = Color.FromArgb(31, 31, 31);
			upgradesub.CustomBorderColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor2 = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(31, 31, 31);
			application.CustomBorderColor = Color.FromArgb(31, 31, 31);
			application.FillColor = Color.FromArgb(31, 31, 31);
			application.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.CustomBorderColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor2 = Color.FromArgb(31, 31, 31);
		}

		private void userdetailsClick(object sender, EventArgs param_457)
		{
			mainn.Controls.Clear();
			settingsuserdetails settingsuserdetails2 = new settingsuserdetails
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			settingsuserdetails2.FormBorderStyle = FormBorderStyle.None;
			mainn.Controls.Add(settingsuserdetails2);
			settingsuserdetails2.Show();
			userdetails.CustomBorderColor = Color.White;
			userdetails.FillColor = Color.FromArgb(50, 50, 50);
			userdetails.FillColor2 = Color.FromArgb(50, 50, 50);
			lockedserials.CustomBorderColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor2 = Color.FromArgb(31, 31, 31);
			subscriptions.CustomBorderColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor2 = Color.FromArgb(31, 31, 31);
			upgradesub.CustomBorderColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor2 = Color.FromArgb(31, 31, 31);
			application.CustomBorderColor = Color.FromArgb(31, 31, 31);
			application.FillColor = Color.FromArgb(31, 31, 31);
			application.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.FillColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor2 = Color.FromArgb(31, 31, 31);
		}

		private void subscriptionsClick(object sender, EventArgs param_459)
		{
			mainn.Controls.Clear();
			settingssub settingssub2 = new settingssub
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			settingssub2.FormBorderStyle = FormBorderStyle.None;
			mainn.Controls.Add(settingssub2);
			settingssub2.Show();
			subscriptions.CustomBorderColor = Color.White;
			subscriptions.FillColor = Color.FromArgb(50, 50, 50);
			subscriptions.FillColor2 = Color.FromArgb(50, 50, 50);
			userdetails.CustomBorderColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor2 = Color.FromArgb(31, 31, 31);
			lockedserials.CustomBorderColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor2 = Color.FromArgb(31, 31, 31);
			upgradesub.CustomBorderColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor2 = Color.FromArgb(31, 31, 31);
			application.CustomBorderColor = Color.FromArgb(31, 31, 31);
			application.FillColor = Color.FromArgb(31, 31, 31);
			application.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.FillColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor2 = Color.FromArgb(31, 31, 31);
		}

		private void upgradesubClick(object sender, EventArgs param_461)
		{
			mainn.Controls.Clear();
			settingsupgradesub settingsupgradesub2 = new settingsupgradesub
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			settingsupgradesub2.FormBorderStyle = FormBorderStyle.None;
			mainn.Controls.Add(settingsupgradesub2);
			settingsupgradesub2.Show();
			upgradesub.CustomBorderColor = Color.White;
			upgradesub.FillColor = Color.FromArgb(50, 50, 50);
			upgradesub.FillColor2 = Color.FromArgb(50, 50, 50);
			userdetails.CustomBorderColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor2 = Color.FromArgb(31, 31, 31);
			lockedserials.CustomBorderColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor2 = Color.FromArgb(31, 31, 31);
			subscriptions.CustomBorderColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor2 = Color.FromArgb(31, 31, 31);
			application.CustomBorderColor = Color.FromArgb(31, 31, 31);
			application.FillColor = Color.FromArgb(31, 31, 31);
			application.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.FillColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor2 = Color.FromArgb(31, 31, 31);
		}

		private void ConnectWindow(object sender, EventArgs param_463)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.AllowFullOpen = true;
			if (colorDialog.ShowDialog() == DialogResult.OK)
				((Main)Application.OpenForms["Main"]).siticonePanel1.FillColor = colorDialog.Color;
		}

		private void siticonePanel2Paint(object sender, PaintEventArgs param_465)
		{
		}

		private void ToggleFunction(object sender, EventArgs param_467)
		{
		}

		private void FormatEditor(object sender, EventArgs param_469)
		{
		}

		private void mainnPaint(object sender, PaintEventArgs param_471)
		{
		}

		private void appearanceClick(object sender, EventArgs param_473)
		{
			mainn.Controls.Clear();
			settingsappearance settingsappearance2 = new settingsappearance
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			settingsappearance2.FormBorderStyle = FormBorderStyle.None;
			mainn.Controls.Add(settingsappearance2);
			settingsappearance2.Show();
			appearance.CustomBorderColor = Color.White;
			appearance.FillColor = Color.FromArgb(50, 50, 50);
			appearance.FillColor2 = Color.FromArgb(50, 50, 50);
			userdetails.CustomBorderColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor2 = Color.FromArgb(31, 31, 31);
			lockedserials.CustomBorderColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor2 = Color.FromArgb(31, 31, 31);
			subscriptions.CustomBorderColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor2 = Color.FromArgb(31, 31, 31);
			upgradesub.CustomBorderColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor2 = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(31, 31, 31);
			application.CustomBorderColor = Color.FromArgb(31, 31, 31);
			application.FillColor = Color.FromArgb(31, 31, 31);
			application.FillColor2 = Color.FromArgb(31, 31, 31);
		}

		private void DisposeNetwork(object sender, EventArgs param_475)
		{
		}

		private void DisposeStub(object sender, EventArgs param_477)
		{
		}

		private void LoadSolution(object sender, EventArgs param_479)
		{
		}

		private void applicationClick(object sender, EventArgs param_481)
		{
			mainn.Controls.Clear();
			settingsterminate settingsterminate2 = new settingsterminate
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			settingsterminate2.FormBorderStyle = FormBorderStyle.None;
			mainn.Controls.Add(settingsterminate2);
			settingsterminate2.Show();
			application.CustomBorderColor = Color.White;
			application.FillColor = Color.FromArgb(50, 50, 50);
			application.FillColor2 = Color.FromArgb(50, 50, 50);
			userdetails.CustomBorderColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor2 = Color.FromArgb(31, 31, 31);
			lockedserials.CustomBorderColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor2 = Color.FromArgb(31, 31, 31);
			upgradesub.CustomBorderColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor2 = Color.FromArgb(31, 31, 31);
			subscriptions.CustomBorderColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.CustomBorderColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor2 = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.CustomBorderColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(31, 31, 31);
		}

		private void PublishPage(object sender, EventArgs param_483)
		{
		}

		private void siticoneGradientButton1Click(object sender, EventArgs param_485)
		{
			mainn.Controls.Clear();
			settingsstats settingsstats2 = new settingsstats
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			settingsstats2.FormBorderStyle = FormBorderStyle.None;
			mainn.Controls.Add(settingsstats2);
			settingsstats2.Show();
			siticoneGradientButton1.CustomBorderColor = Color.White;
			siticoneGradientButton1.FillColor = Color.FromArgb(50, 50, 50);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(50, 50, 50);
			application.CustomBorderColor = Color.FromArgb(31, 31, 31);
			application.FillColor = Color.FromArgb(31, 31, 31);
			application.FillColor2 = Color.FromArgb(31, 31, 31);
			userdetails.CustomBorderColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor = Color.FromArgb(31, 31, 31);
			userdetails.FillColor2 = Color.FromArgb(31, 31, 31);
			lockedserials.CustomBorderColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor2 = Color.FromArgb(31, 31, 31);
			upgradesub.CustomBorderColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor2 = Color.FromArgb(31, 31, 31);
			subscriptions.CustomBorderColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.CustomBorderColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor2 = Color.FromArgb(31, 31, 31);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.dashboard > AssistantHelper.dashboard)
				((IDisposable)this.dashboard).Dispose();
			base.Dispose(disposing);
		}

		private void bsClick()
		{
			panel1 = new Panel();
			mainn = new AlphaGradientPanel();
			this.dashboard = (ColorDialog)(object)new ColorWithAlpha();
			siticonePanel2 = new SiticonePanel();
			appearance = new SiticoneGradientButton();
			application = new SiticoneGradientButton();
			label9 = new Label();
			label5 = new Label();
			label2 = new Label();
			lockedserials = new SiticoneGradientButton();
			userdetails = new SiticoneGradientButton();
			upgradesub = new SiticoneGradientButton();
			subscriptions = new SiticoneGradientButton();
			dashboard = new ColorDialog();
			siticoneGradientButton1 = new SiticoneGradientButton();
			panel1.SuspendLayout();
			siticonePanel2.SuspendLayout();
			SuspendLayout();
			panel1.BackColor = Color.FromArgb(25, 26, 30);
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(mainn);
			panel1.Location = new Point(189, -6);
			panel1.Name = "panel1";
			panel1.Size = new Size(695, 611);
			panel1.TabIndex = 0;
			panel1.Paint += panel1Paint;
			mainn.BackColor = Color.Transparent;
			mainn.Border = false;
			mainn.BorderColor = Color.Yellow;
			mainn.Colors.Add((ColorWithAlpha)(object)this.dashboard);
			mainn.ContentPadding = new Padding(0);
			mainn.CornerRadius = 20;
			mainn.Corners = Corner.All;
			mainn.Gradient = true;
			mainn.GradientMode = LinearGradientMode.Vertical;
			mainn.GradientOffset = 1f;
			mainn.GradientSize = new Size(0, 0);
			mainn.GradientWrapMode = WrapMode.Tile;
			mainn.Grayscale = false;
			mainn.Image = AssemblyTable.dashboard;
			mainn.ImageAlpha = 75;
			mainn.ImagePadding = new Padding(5);
			mainn.ImagePosition = ImagePosition.BottomRight;
			mainn.ImageSize = new Size(48, 48);
			mainn.Location = new Point(17, 19);
			mainn.Name = "mainn";
			mainn.Rounded = true;
			mainn.Size = new Size(654, 571);
			mainn.TabIndex = 40;
			mainn.Paint += mainnPaint;
			((ColorWithAlpha)(object)this.dashboard).Alpha = 255;
			((ColorWithAlpha)(object)this.dashboard).Color = SystemColors.AppWorkspace;
			((ColorWithAlpha)(object)this.dashboard).Parent = mainn;
			siticonePanel2.BackColor = Color.FromArgb(31, 31, 31);
			siticonePanel2.BorderColor = Color.SlateGray;
			siticonePanel2.Controls.Add(siticoneGradientButton1);
			siticonePanel2.Controls.Add(appearance);
			siticonePanel2.Controls.Add(application);
			siticonePanel2.Controls.Add(label9);
			siticonePanel2.Controls.Add(label5);
			siticonePanel2.Controls.Add(label2);
			siticonePanel2.Controls.Add(lockedserials);
			siticonePanel2.Controls.Add(userdetails);
			siticonePanel2.Controls.Add(upgradesub);
			siticonePanel2.Controls.Add(subscriptions);
			siticonePanel2.Location = new Point(-6, -18);
			siticonePanel2.Name = "siticonePanel2";
			siticonePanel2.ShadowDecoration.Parent = siticonePanel2;
			siticonePanel2.Size = new Size(189, 669);
			siticonePanel2.TabIndex = 14;
			siticonePanel2.Paint += siticonePanel2Paint;
			appearance.CheckedState.Parent = appearance;
			appearance.Cursor = Cursors.Hand;
			appearance.CustomBorderThickness = new Padding(3, 0, 0, 0);
			appearance.CustomImages.Parent = appearance;
			appearance.FillColor = Color.FromArgb(31, 31, 31);
			appearance.FillColor2 = Color.FromArgb(31, 31, 31);
			appearance.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			appearance.ForeColor = Color.White;
			appearance.HoveredState.Parent = appearance;
			appearance.ImageAlign = HorizontalAlignment.Left;
			appearance.Location = new Point(6, 267);
			appearance.Name = "appearance";
			appearance.ShadowDecoration.Parent = appearance;
			appearance.Size = new Size(163, 31);
			appearance.TabIndex = 18;
			appearance.Text = "Appearance Options";
			appearance.TextAlign = HorizontalAlignment.Left;
			appearance.Click += appearanceClick;
			application.CheckedState.Parent = application;
			application.Cursor = Cursors.Hand;
			application.CustomBorderThickness = new Padding(3, 0, 0, 0);
			application.CustomImages.Parent = application;
			application.FillColor = Color.FromArgb(31, 31, 31);
			application.FillColor2 = Color.FromArgb(31, 31, 31);
			application.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			application.ForeColor = Color.White;
			application.HoveredState.Parent = application;
			application.ImageAlign = HorizontalAlignment.Left;
			application.Location = new Point(6, 230);
			application.Name = "application";
			application.ShadowDecoration.Parent = application;
			application.Size = new Size(163, 31);
			application.TabIndex = 16;
			application.Text = "Application Options";
			application.TextAlign = HorizontalAlignment.Left;
			application.Click += applicationClick;
			label9.AutoSize = true;
			label9.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.ForeColor = SystemColors.AppWorkspace;
			label9.Location = new Point(3, 212);
			label9.Name = "label9";
			label9.Size = new Size(100, 15);
			label9.TabIndex = 15;
			label9.Text = "Application Settings";
			label5.AutoSize = true;
			label5.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = SystemColors.AppWorkspace;
			label5.Location = new Point(3, 123);
			label5.Name = "label5";
			label5.Size = new Size(106, 15);
			label5.TabIndex = 14;
			label5.Text = "Subscription Settings";
			label2.AutoSize = true;
			label2.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.AppWorkspace;
			label2.Location = new Point(3, 32);
			label2.Name = "label2";
			label2.Size = new Size(68, 15);
			label2.TabIndex = 13;
			label2.Text = "User Settings";
			lockedserials.CheckedState.Parent = lockedserials;
			lockedserials.Cursor = Cursors.Hand;
			lockedserials.CustomBorderThickness = new Padding(3, 0, 0, 0);
			lockedserials.CustomImages.Parent = lockedserials;
			lockedserials.FillColor = Color.FromArgb(31, 31, 31);
			lockedserials.FillColor2 = Color.FromArgb(31, 31, 31);
			lockedserials.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			lockedserials.ForeColor = Color.White;
			lockedserials.HoveredState.Parent = lockedserials;
			lockedserials.ImageAlign = HorizontalAlignment.Left;
			lockedserials.Location = new Point(6, 87);
			lockedserials.Name = "lockedserials";
			lockedserials.ShadowDecoration.Parent = lockedserials;
			lockedserials.Size = new Size(163, 31);
			lockedserials.TabIndex = 10;
			lockedserials.Text = "Locked Serials";
			lockedserials.TextAlign = HorizontalAlignment.Left;
			lockedserials.Click += lockedserialsClick;
			userdetails.CheckedState.Parent = userdetails;
			userdetails.Cursor = Cursors.Hand;
			userdetails.CustomBorderColor = Color.White;
			userdetails.CustomBorderThickness = new Padding(3, 0, 0, 0);
			userdetails.CustomImages.Parent = userdetails;
			userdetails.FillColor = Color.FromArgb(50, 50, 50);
			userdetails.FillColor2 = Color.FromArgb(50, 50, 50);
			userdetails.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			userdetails.ForeColor = Color.White;
			userdetails.HoveredState.Parent = userdetails;
			userdetails.ImageAlign = HorizontalAlignment.Left;
			userdetails.Location = new Point(6, 50);
			userdetails.Name = "userdetails";
			userdetails.ShadowDecoration.Parent = userdetails;
			userdetails.Size = new Size(163, 31);
			userdetails.TabIndex = 9;
			userdetails.Text = "My Account";
			userdetails.TextAlign = HorizontalAlignment.Left;
			userdetails.Click += userdetailsClick;
			upgradesub.CheckedState.Parent = upgradesub;
			upgradesub.Cursor = Cursors.Hand;
			upgradesub.CustomBorderThickness = new Padding(3, 0, 0, 0);
			upgradesub.CustomImages.Parent = upgradesub;
			upgradesub.FillColor = Color.FromArgb(31, 31, 31);
			upgradesub.FillColor2 = Color.FromArgb(31, 31, 31);
			upgradesub.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			upgradesub.ForeColor = Color.White;
			upgradesub.HoveredState.Parent = upgradesub;
			upgradesub.ImageAlign = HorizontalAlignment.Left;
			upgradesub.Location = new Point(6, 178);
			upgradesub.Name = "upgradesub";
			upgradesub.ShadowDecoration.Parent = upgradesub;
			upgradesub.Size = new Size(163, 31);
			upgradesub.TabIndex = 8;
			upgradesub.Text = "Upgrade Subscription";
			upgradesub.TextAlign = HorizontalAlignment.Left;
			upgradesub.Click += upgradesubClick;
			subscriptions.CheckedState.Parent = subscriptions;
			subscriptions.Cursor = Cursors.Hand;
			subscriptions.CustomBorderThickness = new Padding(3, 0, 0, 0);
			subscriptions.CustomImages.Parent = subscriptions;
			subscriptions.FillColor = Color.FromArgb(31, 31, 31);
			subscriptions.FillColor2 = Color.FromArgb(31, 31, 31);
			subscriptions.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			subscriptions.ForeColor = Color.White;
			subscriptions.HoveredState.Parent = subscriptions;
			subscriptions.ImageAlign = HorizontalAlignment.Left;
			subscriptions.Location = new Point(6, 141);
			subscriptions.Name = "subscriptions";
			subscriptions.ShadowDecoration.Parent = subscriptions;
			subscriptions.Size = new Size(163, 31);
			subscriptions.TabIndex = 7;
			subscriptions.Text = "Subscriptions";
			subscriptions.TextAlign = HorizontalAlignment.Left;
			subscriptions.Click += subscriptionsClick;
			siticoneGradientButton1.CheckedState.Parent = siticoneGradientButton1;
			siticoneGradientButton1.Cursor = Cursors.Hand;
			siticoneGradientButton1.CustomBorderThickness = new Padding(3, 0, 0, 0);
			siticoneGradientButton1.CustomImages.Parent = siticoneGradientButton1;
			siticoneGradientButton1.FillColor = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.FillColor2 = Color.FromArgb(31, 31, 31);
			siticoneGradientButton1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneGradientButton1.ForeColor = Color.White;
			siticoneGradientButton1.HoveredState.Parent = siticoneGradientButton1;
			siticoneGradientButton1.ImageAlign = HorizontalAlignment.Left;
			siticoneGradientButton1.Location = new Point(6, 304);
			siticoneGradientButton1.Name = "siticoneGradientButton1";
			siticoneGradientButton1.ShadowDecoration.Parent = siticoneGradientButton1;
			siticoneGradientButton1.Size = new Size(163, 31);
			siticoneGradientButton1.TabIndex = 19;
			siticoneGradientButton1.Text = "Application Stats";
			siticoneGradientButton1.TextAlign = HorizontalAlignment.Left;
			siticoneGradientButton1.Click += siticoneGradientButton1Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 597);
			base.Controls.Add(siticonePanel2);
			base.Controls.Add(panel1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "userinformation";
			Text = "userinformation";
			base.Load += userinformationLoad;
			panel1.ResumeLayout(false);
			siticonePanel2.ResumeLayout(false);
			siticonePanel2.PerformLayout();
			ResumeLayout(false);
		}
	}
}
