using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SUPER
{
	public sealed class VectorLayout
	{
		[DataContract]
		private sealed class response_structure
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool dashboard;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string dashboard;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string green;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string spooferfixes;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string systemspoof;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string gamespoof;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private app_data_structure dashboard;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string autohelper;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string webtool;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string userin;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string label3;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string spooferstatus;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private user_data_structure dashboard;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private List<SymbolEventArgs> dashboard;

			[DataMember]
			public bool success
			{
				[CompilerGenerated]
				get
				{
					return System.Runtime.CompilerServices.Unsafe.As<List<SymbolEventArgs>, bool>(ref this.dashboard);
				}
				[CompilerGenerated]
				set
				{
					System.Runtime.CompilerServices.Unsafe.As<List<SymbolEventArgs>, bool>(ref this.dashboard) = value;
				}
			}

			[DataMember]
			public string sessionid
			{
				[CompilerGenerated]
				get
				{
					return (string)(object)this.dashboard;
				}
				[CompilerGenerated]
				set
				{
					this.dashboard = (List<SymbolEventArgs>)(object)value;
				}
			}

			[DataMember]
			public string contents
			{
				[CompilerGenerated]
				get
				{
					return green;
				}
				[CompilerGenerated]
				set
				{
					green = value;
				}
			}

			[DataMember]
			public string response
			{
				[CompilerGenerated]
				get
				{
					return spooferfixes;
				}
				[CompilerGenerated]
				set
				{
					spooferfixes = value;
				}
			}

			[DataMember]
			public string message
			{
				[CompilerGenerated]
				get
				{
					return systemspoof;
				}
				[CompilerGenerated]
				set
				{
					systemspoof = value;
				}
			}

			[DataMember]
			public string download
			{
				[CompilerGenerated]
				get
				{
					return gamespoof;
				}
				[CompilerGenerated]
				set
				{
					gamespoof = value;
				}
			}

			[DataMember(EmitDefaultValue = false, IsRequired = false)]
			public app_data_structure appinfo
			{
				[CompilerGenerated]
				get
				{
					return (app_data_structure)(object)this.dashboard;
				}
				[CompilerGenerated]
				set
				{
					this.dashboard = (List<SymbolEventArgs>)(object)value;
				}
			}

			public string key
			{
				[CompilerGenerated]
				get
				{
					return autohelper;
				}
				[CompilerGenerated]
				set
				{
					autohelper = value;
				}
			}

			[DataMember]
			public string unused
			{
				[CompilerGenerated]
				get
				{
					return webtool;
				}
				[CompilerGenerated]
				set
				{
					webtool = value;
				}
			}

			[DataMember]
			public string used
			{
				[CompilerGenerated]
				get
				{
					return userin;
				}
				[CompilerGenerated]
				set
				{
					userin = value;
				}
			}

			[DataMember]
			public string users
			{
				[CompilerGenerated]
				get
				{
					return label3;
				}
				[CompilerGenerated]
				set
				{
					label3 = value;
				}
			}

			[DataMember]
			public string vars
			{
				[CompilerGenerated]
				get
				{
					return spooferstatus;
				}
				[CompilerGenerated]
				set
				{
					spooferstatus = value;
				}
			}

			[DataMember(EmitDefaultValue = false, IsRequired = false)]
			public user_data_structure info
			{
				[CompilerGenerated]
				get
				{
					return (user_data_structure)(object)this.dashboard;
				}
				[CompilerGenerated]
				set
				{
					this.dashboard = (List<SymbolEventArgs>)(object)value;
				}
			}

			[DataMember]
			public List<SymbolEventArgs> messages
			{
				[CompilerGenerated]
				get
				{
					return dashboard;
				}
				[CompilerGenerated]
				set
				{
					dashboard = value;
				}
			}
		}

		public sealed class SymbolEventArgs
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string dashboard;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string green;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string spooferfixes;

			public string message
			{
				[CompilerGenerated]
				get
				{
					return dashboard;
				}
				[CompilerGenerated]
				set
				{
					dashboard = value;
				}
			}

			public string author
			{
				[CompilerGenerated]
				get
				{
					return green;
				}
				[CompilerGenerated]
				set
				{
					green = value;
				}
			}

			public string timestamp
			{
				[CompilerGenerated]
				get
				{
					return spooferfixes;
				}
				[CompilerGenerated]
				set
				{
					spooferfixes = value;
				}
			}
		}

		[DataContract]
		private sealed class app_data_structure
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string dashboard;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string green;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string spooferfixes;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string systemspoof;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string gamespoof;

			[DataMember]
			public string numUsers
			{
				[CompilerGenerated]
				get
				{
					return dashboard;
				}
				[CompilerGenerated]
				set
				{
					dashboard = value;
				}
			}

			[DataMember]
			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					return green;
				}
				[CompilerGenerated]
				set
				{
					green = value;
				}
			}

			[DataMember]
			public string numKeys
			{
				[CompilerGenerated]
				get
				{
					return spooferfixes;
				}
				[CompilerGenerated]
				set
				{
					spooferfixes = value;
				}
			}

			[DataMember]
			public string version
			{
				[CompilerGenerated]
				get
				{
					return systemspoof;
				}
				[CompilerGenerated]
				set
				{
					systemspoof = value;
				}
			}

			[DataMember]
			public string customerPanelLink
			{
				[CompilerGenerated]
				get
				{
					return gamespoof;
				}
				[CompilerGenerated]
				set
				{
					gamespoof = value;
				}
			}
		}

		[DataContract]
		private sealed class user_data_structure
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string dashboard;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<OutlineQueue> dashboard;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string green;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string spooferfixes;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string systemspoof;

			[DataMember]
			public string username
			{
				[CompilerGenerated]
				get
				{
					return (string)(object)this.dashboard;
				}
				[CompilerGenerated]
				set
				{
					this.dashboard = (List<OutlineQueue>)(object)value;
				}
			}

			[DataMember]
			public List<OutlineQueue> subscriptions
			{
				[CompilerGenerated]
				get
				{
					return dashboard;
				}
				[CompilerGenerated]
				set
				{
					dashboard = value;
				}
			}

			[DataMember]
			public string createdate
			{
				[CompilerGenerated]
				get
				{
					return green;
				}
				[CompilerGenerated]
				set
				{
					green = value;
				}
			}

			[DataMember]
			public string lastlogin
			{
				[CompilerGenerated]
				get
				{
					return spooferfixes;
				}
				[CompilerGenerated]
				set
				{
					spooferfixes = value;
				}
			}

			[DataMember]
			public string property_27
			{
				[CompilerGenerated]
				get
				{
					return systemspoof;
				}
				[CompilerGenerated]
				set
				{
					systemspoof = value;
				}
			}
		}

		public sealed class DockingPaneResolver
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string dashboard;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string green;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string spooferfixes;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string systemspoof;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string gamespoof;

			public string numUsers
			{
				[CompilerGenerated]
				get
				{
					return dashboard;
				}
				[CompilerGenerated]
				set
				{
					dashboard = value;
				}
			}

			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					return green;
				}
				[CompilerGenerated]
				set
				{
					green = value;
				}
			}

			public string numKeys
			{
				[CompilerGenerated]
				get
				{
					return spooferfixes;
				}
				[CompilerGenerated]
				set
				{
					spooferfixes = value;
				}
			}

			public string version
			{
				[CompilerGenerated]
				get
				{
					return systemspoof;
				}
				[CompilerGenerated]
				set
				{
					systemspoof = value;
				}
			}

			public string customerPanelLink
			{
				[CompilerGenerated]
				get
				{
					return gamespoof;
				}
				[CompilerGenerated]
				set
				{
					gamespoof = value;
				}
			}
		}

		public sealed class PathType
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string dashboard;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<OutlineQueue> dashboard;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string green;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string spooferfixes;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string systemspoof;

			public string username
			{
				[CompilerGenerated]
				get
				{
					return (string)(object)this.dashboard;
				}
				[CompilerGenerated]
				set
				{
					this.dashboard = (List<OutlineQueue>)(object)value;
				}
			}

			public List<OutlineQueue> subscriptions
			{
				[CompilerGenerated]
				get
				{
					return dashboard;
				}
				[CompilerGenerated]
				set
				{
					dashboard = value;
				}
			}

			public string createdate
			{
				[CompilerGenerated]
				get
				{
					return green;
				}
				[CompilerGenerated]
				set
				{
					green = value;
				}
			}

			public string lastlogin
			{
				[CompilerGenerated]
				get
				{
					return spooferfixes;
				}
				[CompilerGenerated]
				set
				{
					spooferfixes = value;
				}
			}

			public string property_37
			{
				[CompilerGenerated]
				get
				{
					return systemspoof;
				}
				[CompilerGenerated]
				set
				{
					systemspoof = value;
				}
			}
		}

		public sealed class OutlineQueue
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string dashboard;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string green;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string spooferfixes;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string systemspoof;

			public string subscription
			{
				[CompilerGenerated]
				get
				{
					return dashboard;
				}
				[CompilerGenerated]
				set
				{
					dashboard = value;
				}
			}

			public string expiry
			{
				[CompilerGenerated]
				get
				{
					return green;
				}
				[CompilerGenerated]
				set
				{
					green = value;
				}
			}

			public string createdate
			{
				[CompilerGenerated]
				get
				{
					return spooferfixes;
				}
				[CompilerGenerated]
				set
				{
					spooferfixes = value;
				}
			}

			public string lastlogin
			{
				[CompilerGenerated]
				get
				{
					return systemspoof;
				}
				[CompilerGenerated]
				set
				{
					systemspoof = value;
				}
			}
		}

		public string dashboard;

		public string green;

		public string spooferfixes;

		public string systemspoof;

		private string gamespoof;

		private string autohelper;

		private bool dashboard;

		public DockingPaneResolver dashboard;

		public PathType dashboard;

		private AssemblyType dashboard = new AssemblyType(new response_structure());

		public VectorLayout(string string_0, string string_1, string string_2, string string_3)
		{
			if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1) || string.IsNullOrWhiteSpace(string_2) || string.IsNullOrWhiteSpace(string_3))
			{
				MessageBox.Show("Application not setup correctly. Please watch video link found in Login.cs");
				Environment.Exit(0);
			}
			this.dashboard = (AssemblyType)(object)string_0;
			green = string_1;
			spooferfixes = string_2;
			systemspoof = string_3;
		}

		public void MainLoad()
		{
			autohelper = DomainStream.stoppClick(DomainStream.MainLoad());
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string text2 = MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("init")),
				["ver"] = DomainStream.windowsClick(systemspoof, spooferfixes, text),
				["enckey"] = DomainStream.windowsClick(autohelper, spooferfixes, text),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			});
			if (text2 == "KeyAuth_Invalid")
			{
				MessageBox.Show("Application not found.");
				Environment.Exit(0);
			}
			string string_ = DomainStream.gpuClick(text2, spooferfixes, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_);
			if (response_structure.success)
			{
				MainLoad(response_structure.appinfo);
				gamespoof = response_structure.sessionid;
				System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard) = true;
			}
			else if (response_structure.message == "invalidver")
			{
				Process.Start(response_structure.download);
				MessageBox.Show("Invalid Version! Check your browser we auto updated.", "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			else
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}

		public bool MainLoad()
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
				Environment.Exit(0);
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_ = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("checkblacklist")),
				["hwid"] = DomainStream.windowsClick(value, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			if (dashboard.MainLoad<response_structure>(string_).success)
				return true;
			return false;
		}

		public bool MainLoad(string string_0, string string_1, string string_2)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				return false;
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_3 = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("register")),
				["username"] = DomainStream.windowsClick(string_0, autohelper, text),
				["pass"] = DomainStream.windowsClick(string_1, autohelper, text),
				["key"] = DomainStream.windowsClick(string_2, autohelper, text),
				["hwid"] = DomainStream.windowsClick(value, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_3);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			MainLoad(response_structure.info);
			return true;
		}

		public List<SymbolEventArgs> MainLoad(string string_0)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				Environment.Exit(0);
			}
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_ = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("chatget")),
				["channel"] = DomainStream.windowsClick(string_0, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				return AssemblyStack.dashboard;
			}
			return response_structure.messages;
		}

		public bool bsClick(string string_0, string string_1)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				Environment.Exit(0);
			}
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_2 = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("chatsend")),
				["message"] = DomainStream.windowsClick(string_0, autohelper, text),
				["channel"] = DomainStream.windowsClick(string_1, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}

		public bool stoppClick(string string_0, string string_1)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				return false;
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_2 = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("login")),
				["username"] = DomainStream.windowsClick(string_0, autohelper, text),
				["pass"] = DomainStream.windowsClick(string_1, autohelper, text),
				["hwid"] = DomainStream.windowsClick(value, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			MainLoad(response_structure.info);
			return true;
		}

		public void bsClick(string string_0, string string_1)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				return;
			}
			_ = WindowsIdentity.GetCurrent().User.Value;
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_2 = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("upgrade")),
				["username"] = DomainStream.windowsClick(string_0, autohelper, text),
				["key"] = DomainStream.windowsClick(string_1, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			else
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		public bool bsClick(string string_0)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				return false;
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_ = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("license")),
				["key"] = DomainStream.windowsClick(string_0, autohelper, text),
				["hwid"] = DomainStream.windowsClick(value, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				return false;
			}
			MainLoad(response_structure.info);
			return true;
		}

		public void stoppClick()
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				return;
			}
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_ = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("ban")),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}

		public string MainLoad(string string_0)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				return "";
			}
			_ = WindowsIdentity.GetCurrent().User.Value;
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_ = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("var")),
				["varid"] = DomainStream.windowsClick(string_0, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return "";
			}
			return response_structure.message;
		}

		public string MainLoad(string string_0, string string_1)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("DEV ERR", "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_2 = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("webhook")),
				["webid"] = DomainStream.windowsClick(string_0, autohelper, text),
				["params"] = DomainStream.windowsClick(string_1, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_2);
			response_structure response_structure2 = JsonConvert.DeserializeObject<response_structure>(response_structure.response);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				return "";
			}
			return response_structure2.users;
		}

		public string bsClick(string string_0, string string_1)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("DEV ERR", "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_2 = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("webhook")),
				["webid"] = DomainStream.windowsClick(string_0, autohelper, text),
				["params"] = DomainStream.windowsClick(string_1, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			return "";
		}

		public string stoppClick(string string_0, string string_1)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("DEV ERR", "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_2 = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("webhook")),
				["webid"] = DomainStream.windowsClick(string_0, autohelper, text),
				["params"] = DomainStream.windowsClick(string_1, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_2);
			response_structure response_structure2 = JsonConvert.DeserializeObject<response_structure>(response_structure.response);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				return "";
			}
			return response_structure2.used;
		}

		public byte[] MainLoad(string string_0)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				return new byte[0];
			}
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			string string_ = DomainStream.gpuClick(MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("file")),
				["fileid"] = DomainStream.windowsClick(string_0, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			}), autohelper, text);
			response_structure response_structure = dashboard.MainLoad<response_structure>(string_);
			if (!response_structure.success)
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return DomainStream.bsClick(response_structure.contents);
		}

		public void MainLoad(string string_0)
		{
			if (!System.Runtime.CompilerServices.Unsafe.As<AssemblyType, bool>(ref this.dashboard))
			{
				MessageBox.Show("Please initzalize first");
				return;
			}
			string text = DomainStream.stoppClick(DomainStream.MainLoad());
			MainLoad(new NameValueCollection
			{
				["type"] = DomainStream.MainLoad(Encoding.Default.GetBytes("log")),
				["pcuser"] = DomainStream.windowsClick(Environment.UserName, autohelper, text),
				["message"] = DomainStream.windowsClick(string_0, autohelper, text),
				["sessionid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(gamespoof)),
				["name"] = DomainStream.MainLoad(Encoding.Default.GetBytes((string)(object)this.dashboard)),
				["ownerid"] = DomainStream.MainLoad(Encoding.Default.GetBytes(green)),
				["init_iv"] = text
			});
		}

		private static string MainLoad(NameValueCollection nameValueCollection_0)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", nameValueCollection_0);
					return Encoding.Default.GetString(bytes);
				}
			}
			catch
			{
				MessageBox.Show("ERROR 404 : Connection Failure! API is downed.", "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Thread.Sleep(3500);
				Environment.Exit(0);
				return "nothing";
			}
		}

		private void MainLoad(app_data_structure app_data_structure_0)
		{
			((DockingPaneResolver)(object)this.dashboard).numUsers = app_data_structure_0.numUsers;
			((DockingPaneResolver)(object)this.dashboard).numOnlineUsers = app_data_structure_0.numOnlineUsers;
			((DockingPaneResolver)(object)this.dashboard).numKeys = app_data_structure_0.numKeys;
			((DockingPaneResolver)(object)this.dashboard).version = app_data_structure_0.version;
			((DockingPaneResolver)(object)this.dashboard).customerPanelLink = app_data_structure_0.customerPanelLink;
		}

		private void MainLoad(user_data_structure user_data_structure_0)
		{
			((PathType)(object)this.dashboard).username = user_data_structure_0.username;
			((PathType)(object)this.dashboard).property_37 = user_data_structure_0.property_27;
			((PathType)(object)this.dashboard).subscriptions = user_data_structure_0.subscriptions;
			((PathType)(object)this.dashboard).createdate = user_data_structure_0.createdate;
			((PathType)(object)this.dashboard).lastlogin = user_data_structure_0.lastlogin;
		}
	}
}
