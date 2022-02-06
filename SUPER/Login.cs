using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class Login : Form
	{
		private static string dashboard;

		private static string green;

		private static string spooferfixes;

		private static string systemspoof;

		public static VectorLayout dashboard;

		private static int dashboard;

		private IContainer dashboard;

		private SiticoneDragControl dashboard;

		private Label label1;

		private Label label4;

		private Timer dashboard = (Timer)AssistantHelper.dashboard;

		private Label label6;

		private Label AAA;

		private SiticoneDragControl green;

		private Timer green;

		private Label label5;

		private Timer spooferfixes;

		private SiticoneDragControl spooferfixes;

		private Label autohelper;

		private SiticoneCustomCheckBox autologin;

		public SiticoneGradientPanel siticonePanel1;

		private SiticoneButton loginnow;

		private Label pwr;

		private SiticoneTextBox password;

		private SiticoneTextBox username;

		private Label label2;

		private Label label3;

		private PictureBox pictureBox1;

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		public Login()
		{
			((VectorLayout)(object)Login.dashboard).MainLoad();
			if (Process.GetProcessesByName("ProcessHacker").Length == 0)
				this.bsClick();
			else
				this.stoppClick();
			biosClick();
			green.Start();
		}

		static Login()
		{
			Login.dashboard = (Timer)(object)"SUPER AUTH";
			Login.green = (Timer)(object)"j1p6c6E5TW";
			Login.spooferfixes = (SiticoneDragControl)(object)"f7bcfd0fe2fc39b7589589239e6a22ef47344de76c839876b565834ce7eeabd3";
			systemspoof = "3.0.0";
			Login.dashboard = (Timer)(object)new VectorLayout((string)(object)Login.dashboard, (string)(object)Login.green, (string)(object)Login.spooferfixes, systemspoof);
		}

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] ref bool bool_0);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		public static void MainLoad(string string_0, string string_1)
		{
			WebRequest webRequest = WebRequest.Create(string_0);
			webRequest.ContentType = "application/json";
			webRequest.Method = "POST";
			using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
				streamWriter.Write(string_1);
			webRequest.GetResponse();
		}

		private static IntPtr MainLoad(string string_0)
		{
			foreach (ProcessModule module in Process.GetCurrentProcess().Modules)
			{
				if (module.ModuleName.ToLower().Contains(string_0.ToLower()))
					return module.BaseAddress;
			}
			return IntPtr.Zero;
		}

		private void bsClick()
		{
		}

		private void stoppClick()
		{
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Application.Exit();
		}

		private void windowsClick()
		{
			MessageBox.Show("[ANTI-DEBUG] Please close all debuggers before continue!", "Super Cheats - Protection!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Application.Exit();
		}

		private void gpuClick()
		{
			if (MainLoad("SbieDll.dll") != IntPtr.Zero)
			{
				MessageBox.Show("Please fully uninstall sandboxie (EXITING...)", "Super Cheats - Protection!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				Application.Exit();
			}
			if (Process.GetProcessesByName("ida").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("dnspy").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("simpleassembly").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("peek").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("fiddler").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("processhacker").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("ida").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("ImportREC").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("IMMUNITYDEBUGGER").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("MegaDumper").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("reshacker").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("cheat engine").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
			if (Process.GetProcessesByName("HTTP Debugger").Length == 0)
				this.bsClick();
			else
				this.windowsClick();
		}

		private static int MainLoad()
		{
			if (Debugger.IsAttached)
				return 1;
			return 0;
		}

		private static int bsClick()
		{
			if (IsDebuggerPresent())
				return 1;
			return 0;
		}

		public static int stoppClick()
		{
			if (MainLoad() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerManagedPresent: HIT");
				return 1;
			}
			if (Login.bsClick() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerUnmanagedPresent: HIT");
				return 1;
			}
			if (Login.windowsClick() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckRemoteDebugger: HIT");
				return 1;
			}
			return 0;
		}

		private static int windowsClick()
		{
			bool bool_ = false;
			if (CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref bool_) && bool_)
				return 1;
			return 0;
		}

		private void xboxClick()
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
			}
			catch (Exception)
			{
			}
		}

		private void serialcheckersClick()
		{
			label6.Text = Directory.GetCurrentDirectory();
			if (label6.Text.Contains("D:"))
			{
				MessageBox.Show("Please place file on C: drive so we can access windows files!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			label6.Text = Directory.GetCurrentDirectory();
			if (label6.Text.Contains("E:"))
			{
				MessageBox.Show("Please place file on C: drive so we can access windows files!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}

		private void LoginLoad(object sender, EventArgs param_150)
		{
			if (((VectorLayout)(object)Login.dashboard).MainLoad())
			{
				MessageBox.Show("sdsa");
				Application.Exit();
			}
			Login.stoppClick();
			gpuClick();
			Process.Start("https://discord.gg/WveHU8kN2h");
			try
			{
				foreach (string item in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\username.json", Encoding.UTF8))
				{
					username.Text = item;
				}
				foreach (string item2 in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\password.json", Encoding.UTF8))
				{
					password.Text = item2;
				}
			}
			catch (Exception)
			{
			}
			green.Start();
			((Timer)(object)this.spooferfixes).Start();
			xboxClick();
		}

		public DateTime MainLoad(long long_0)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(long_0).ToLocalTime();
		}

		private void bsClick(object sender, EventArgs param_153)
		{
		}

		private void stoppClick(object sender, EventArgs param_155)
		{
		}

		private void windowsClick(object sender, EventArgs param_157)
		{
		}

		private void gpuClick(object sender, EventArgs param_159)
		{
		}

		private void xboxClick(object sender, EventArgs param_161)
		{
		}

		private void serialcheckersClick(object sender, EventArgs param_163)
		{
		}

		private void biosClick(object sender, EventArgs param_165)
		{
			if (Process.GetProcessesByName("ProcessHacker").Length == 0)
				this.bsClick();
			else
				this.stoppClick();
		}

		private void userinClick(object sender, EventArgs param_167)
		{
			if (password.Text == "Password")
			{
				password.Text = "";
				password.PasswordChar = '*';
			}
		}

		private void ReduceAddin(object sender, EventArgs param_169)
		{
			if (username.Text == "Username")
				username.Text = "";
		}

		private void grouClick(object sender, EventArgs param_171)
		{
			((VectorLayout)(object)Login.dashboard).bsClick("UM2q1OZuJq", "&type=resetpw&user=" + username.Text + "&format=json");
			MessageBox.Show("We have reset the password for user: " + username.Text + ". Please login with the password you want to set.", "Super Cheats - Information Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void LoginMove(object sender, EventArgs param_173)
		{
			base.Opacity = 30.0;
		}

		private void LoginDragOver(object sender, DragEventArgs param_175)
		{
		}

		private void OpenPciture(object sender, EventArgs param_177)
		{
		}

		private void ConnectWindow(object sender, EventArgs param_179)
		{
			if (AAA.Text == "True")
			{
				username.Text = "";
				password.Text = "";
				AAA.Text = "False";
				return;
			}
			try
			{
				foreach (string item in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\username.json", Encoding.UTF8))
				{
					username.Text = item;
				}
				foreach (string item2 in lick.ReadLines("C:\\Program Files\\Temp\\93-29-29 USERS\\password.json", Encoding.UTF8))
				{
					password.Text = item2;
				}
				AAA.Text = "True";
			}
			catch (Exception)
			{
				MessageBox.Show("Failed to auto-login, maybe you have reset your computer, or you have not yet created a account.", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void ToggleFunction(object sender, EventArgs param_181)
		{
			try
			{
				string path = "C:\\Program Files\\Temp\\93-29-29 USERS";
				if (!Directory.Exists(path))
					Directory.CreateDirectory(path);
				using (StreamWriter streamWriter = new StreamWriter("C:\\\\Program Files\\\\Temp\\\\93-29-29 USERS\\\\username.json"))
					streamWriter.WriteLine(username.Text);
				using (StreamWriter streamWriter2 = new StreamWriter("C:\\\\Program Files\\\\Temp\\\\93-29-29 USERS\\\\password.json"))
					streamWriter2.WriteLine(username.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot remember you turn your antivirus off so we can locate user local files.", "Super Spoofer - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void FormatEditor(object sender, EventArgs param_183)
		{
		}

		private void autohelperClick(object sender, EventArgs param_185)
		{
		}

		private void DisposeNetwork(object sender, EventArgs param_187)
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

		private void DisposeStub(object sender, EventArgs param_189)
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

		private void LoadSolution(object sender, EventArgs param_191)
		{
		}

		private void loginnowClick(object sender, EventArgs param_193)
		{
			if (((VectorLayout)(object)Login.dashboard).stoppClick(username.Text, password.Text))
			{
				((VectorLayout)(object)Login.dashboard).MainLoad("User Login");
				Hide();
				new Main().ShowDialog();
			}
		}

		private void PublishPage(object sender, EventArgs param_195)
		{
		}

		private void pwrClick(object sender, EventArgs param_197)
		{
		}

		private void UnregisterImage(object sender, EventArgs param_199)
		{
			pwr.Visible = true;
			autologin.Visible = true;
			loginnow.Visible = true;
			autohelper.Visible = true;
		}

		private void FreeDisk(object sender, EventArgs param_201)
		{
			pwr.Visible = false;
			autologin.Visible = false;
			autohelper.Visible = false;
			loginnow.Visible = false;
		}

		private void siticonePanel1Paint(object sender, PaintEventArgs param_203)
		{
		}

		private void HideImage(object sender, EventArgs param_205)
		{
		}

		private void AddWindow(object sender, EventArgs param_207)
		{
			((VectorLayout)(object)Login.dashboard).bsClick("UM2q1OZuJq", "&type=resetpw&user=" + username.Text + "&format=json");
			MessageBox.Show("We have reset the password for user: " + username.Text + ". Please login with the password you want to set.", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void label2Click(object sender, EventArgs param_209)
		{
			Application.Exit();
		}

		private void rsClick(object sender, EventArgs param_211)
		{
		}

		private void pictureBox1Click(object sender, EventArgs param_213)
		{
			if (label5.Text == "Not")
			{
				password.PasswordChar = '\0';
				label5.Text = "is";
			}
			else
			{
				password.PasswordChar = '*';
				label5.Text = "Not";
			}
		}

		private void apexClick(object sender, EventArgs param_215)
		{
		}

		private void BatchBuildStub(object sender, EventArgs param_217)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.dashboard > AssistantHelper.dashboard)
				((IDisposable)this.dashboard).Dispose();
			base.Dispose(disposing);
		}

		private void biosClick()
		{
			this.dashboard = (Timer)(object)new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Login));
			this.dashboard = (Timer)(object)new SiticoneDragControl((IContainer)this.dashboard);
			label1 = new Label();
			label4 = new Label();
			dashboard = new Timer((IContainer)this.dashboard);
			label6 = new Label();
			AAA = new Label();
			this.green = (Timer)(object)new SiticoneDragControl((IContainer)this.dashboard);
			green = new Timer((IContainer)this.dashboard);
			label5 = new Label();
			this.spooferfixes = (SiticoneDragControl)(object)new Timer((IContainer)this.dashboard);
			spooferfixes = new SiticoneDragControl((IContainer)this.dashboard);
			siticonePanel1 = new SiticoneGradientPanel();
			label3 = new Label();
			label2 = new Label();
			autohelper = new Label();
			autologin = new SiticoneCustomCheckBox();
			loginnow = new SiticoneButton();
			pwr = new Label();
			password = new SiticoneTextBox();
			username = new SiticoneTextBox();
			pictureBox1 = new PictureBox();
			siticonePanel1.SuspendLayout();
			((ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			((SiticoneDragControl)(object)this.dashboard).TargetControl = PluginSerializer.dashboard;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Light", 10f);
			label1.ForeColor = Color.White;
			label1.Location = new Point(-1, 206);
			label1.Name = "label1";
			label1.Size = new Size(0, 19);
			label1.TabIndex = 22;
			label4.AutoSize = true;
			label4.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(1212, 402);
			label4.Name = "label4";
			label4.Size = new Size(0, 17);
			label4.TabIndex = 48;
			label4.Visible = false;
			dashboard.Interval = 10;
			dashboard.Tick += gpuClick;
			label6.AutoSize = true;
			label6.Location = new Point(1083, 374);
			label6.Name = "label6";
			label6.Size = new Size(35, 13);
			label6.TabIndex = 78;
			label6.Text = "label6";
			label6.Visible = false;
			AAA.AutoSize = true;
			AAA.Font = new Font("Courier New", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			AAA.ForeColor = Color.White;
			AAA.Location = new Point(259, 467);
			AAA.Name = "AAA";
			AAA.Size = new Size(0, 16);
			AAA.TabIndex = 106;
			AAA.Visible = false;
			((SiticoneDragControl)(object)this.green).TargetControl = this;
			green.Interval = 10;
			green.Tick += biosClick;
			label5.AutoSize = true;
			label5.Location = new Point(1086, 361);
			label5.Name = "label5";
			label5.Size = new Size(14, 13);
			label5.TabIndex = 110;
			label5.Text = "is";
			label5.Visible = false;
			((Timer)(object)this.spooferfixes).Interval = 10;
			((Timer)(object)this.spooferfixes).Tick += BatchBuildStub;
			spooferfixes.TargetControl = siticonePanel1;
			siticonePanel1.BackColor = Color.Gray;
			siticonePanel1.Controls.Add(label3);
			siticonePanel1.Controls.Add(label2);
			siticonePanel1.Cursor = Cursors.Hand;
			siticonePanel1.FillColor = Color.FromArgb(49, 51, 57);
			siticonePanel1.FillColor2 = Color.FromArgb(49, 51, 57);
			siticonePanel1.Location = new Point(-3, -6);
			siticonePanel1.Name = "siticonePanel1";
			siticonePanel1.ShadowDecoration.Parent = siticonePanel1;
			siticonePanel1.Size = new Size(639, 24);
			siticonePanel1.TabIndex = 128;
			siticonePanel1.Paint += siticonePanel1Paint;
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb(49, 51, 57);
			label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(4, 6);
			label3.Name = "label3";
			label3.Size = new Size(94, 15);
			label3.TabIndex = 130;
			label3.Text = "superspoofer.cc";
			label2.AutoSize = true;
			label2.BackColor = Color.FromArgb(49, 51, 57);
			label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(314, 7);
			label2.Name = "label2";
			label2.Size = new Size(15, 15);
			label2.TabIndex = 129;
			label2.Text = "X";
			label2.Click += label2Click;
			autohelper.AutoSize = true;
			autohelper.Cursor = Cursors.Arrow;
			autohelper.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			autohelper.ForeColor = Color.DarkGray;
			autohelper.Location = new Point(40, 102);
			autohelper.Name = "autohelper";
			autohelper.Size = new Size(94, 17);
			autohelper.TabIndex = 105;
			autohelper.Text = "Remember me";
			autohelper.Click += autohelperClick;
			autologin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			autologin.CheckedState.BorderRadius = 2;
			autologin.CheckedState.BorderThickness = 0;
			autologin.CheckedState.FillColor = Color.DodgerBlue;
			autologin.CheckedState.Parent = autologin;
			autologin.Cursor = Cursors.Hand;
			autologin.Location = new Point(17, 102);
			autologin.Name = "autologin";
			autologin.ShadowDecoration.Parent = autologin;
			autologin.Size = new Size(17, 17);
			autologin.TabIndex = 126;
			autologin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			autologin.UncheckedState.BorderRadius = 2;
			autologin.UncheckedState.BorderThickness = 0;
			autologin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			autologin.UncheckedState.Parent = autologin;
			autologin.CheckedChanged += ToggleFunction;
			loginnow.BackColor = Color.FromArgb(49, 51, 57);
			loginnow.BorderColor = Color.FromArgb(49, 51, 57);
			loginnow.BorderRadius = 2;
			loginnow.CheckedState.Parent = loginnow;
			loginnow.Cursor = Cursors.Hand;
			loginnow.CustomImages.Parent = loginnow;
			loginnow.FillColor = Color.FromArgb(49, 51, 57);
			loginnow.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			loginnow.ForeColor = Color.White;
			loginnow.HoveredState.Parent = loginnow;
			loginnow.Location = new Point(17, 157);
			loginnow.Name = "loginnow";
			loginnow.PressedDepth = 0;
			loginnow.ShadowDecoration.Parent = loginnow;
			loginnow.Size = new Size(294, 26);
			loginnow.TabIndex = 9;
			loginnow.Text = "Login";
			loginnow.TextRenderingHint = TextRenderingHint.AntiAlias;
			loginnow.Click += loginnowClick;
			pwr.AutoSize = true;
			pwr.Cursor = Cursors.Hand;
			pwr.Font = new Font("Microsoft Sans Serif", 9.749999f, FontStyle.Bold, GraphicsUnit.Point, 0);
			pwr.ForeColor = Color.FromArgb(102, 121, 193);
			pwr.Location = new Point(81, 311);
			pwr.Name = "pwr";
			pwr.Size = new Size(147, 20);
			pwr.TabIndex = 8;
			pwr.Text = "Forgot your password?";
			pwr.UseCompatibleTextRendering = true;
			pwr.Click += pwrClick;
			password.BorderColor = Color.FromArgb(37, 39, 43);
			password.BorderRadius = 2;
			password.Cursor = Cursors.IBeam;
			password.DefaultText = "Password";
			password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			password.DisabledState.Parent = password;
			password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			password.FillColor = Color.FromArgb(49, 51, 57);
			password.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			password.FocusedState.Parent = password;
			password.ForeColor = Color.FromArgb(155, 157, 161);
			password.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			password.HoveredState.Parent = password;
			password.Location = new Point(14, 67);
			password.Name = "password";
			password.PasswordChar = '\0';
			password.PlaceholderText = "";
			password.SelectedText = "";
			password.ShadowDecoration.Parent = password;
			password.Size = new Size(297, 28);
			password.TabIndex = 7;
			password.TextChanged += rsClick;
			username.BorderColor = Color.FromArgb(37, 39, 43);
			username.BorderRadius = 2;
			username.Cursor = Cursors.IBeam;
			username.DefaultText = "Username";
			username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			username.DisabledState.Parent = username;
			username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			username.FillColor = Color.FromArgb(49, 51, 57);
			username.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			username.FocusedState.Parent = username;
			username.ForeColor = Color.FromArgb(155, 157, 161);
			username.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			username.HoveredState.Parent = username;
			username.Location = new Point(14, 33);
			username.Name = "username";
			username.PasswordChar = '\0';
			username.PlaceholderText = "";
			username.SelectedText = "";
			username.ShadowDecoration.Parent = username;
			username.Size = new Size(297, 28);
			username.TabIndex = 5;
			pictureBox1.BackColor = Color.FromArgb(49, 51, 57);
			pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(279, 69);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(29, 23);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 129;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			AutoValidate = AutoValidate.Disable;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(327, 195);
			base.ControlBox = false;
			base.Controls.Add(pictureBox1);
			base.Controls.Add(siticonePanel1);
			base.Controls.Add(label5);
			base.Controls.Add(AAA);
			base.Controls.Add(label6);
			base.Controls.Add(autologin);
			base.Controls.Add(label1);
			base.Controls.Add(label4);
			base.Controls.Add(loginnow);
			base.Controls.Add(autohelper);
			base.Controls.Add(pwr);
			base.Controls.Add(username);
			base.Controls.Add(password);
			Cursor = Cursors.SizeAll;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Login";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			Text = "Loader";
			base.TransparencyKey = Color.Maroon;
			base.Load += LoginLoad;
			base.DragOver += LoginDragOver;
			base.Move += LoginMove;
			siticonePanel1.ResumeLayout(false);
			siticonePanel1.PerformLayout();
			((ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
