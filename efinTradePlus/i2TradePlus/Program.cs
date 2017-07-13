using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;

namespace i2TradePlus
{
	// Token: 0x02000003 RID: 3
	public static class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000450
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Start(params string[] args)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Program.Main(args);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000468
		[STAThread]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Main(params string[] args)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				string empty = string.Empty;
				string empty2 = string.Empty;
				string empty3 = string.Empty;
				string empty4 = string.Empty;
				string empty5 = string.Empty;
				string empty6 = string.Empty;
				string empty7 = string.Empty;
				string empty8 = string.Empty;
				if (args != null && args.Length > 0)
				{
					string[] array = args[0].Split(new char[]
					{
						';'
					});
					string[] array2 = array;
					int i = 0;
					while (i < array2.Length)
					{
						string text = array2[i];
						string[] array3 = text.Split(new char[]
						{
							'='
						});
						string text2 = array3[0].ToLower();
						switch (text2)
						{
						case "openfromweb":
							bool.TryParse(array3[1].ToString(), out ApplicationInfo.IsOpenFromWeb);
							break;
						case "brokerid":
							int.TryParse(array3[1].ToString(), out ApplicationInfo.BrokerId);
							break;
						case "appid":
							ApplicationInfo.UserLoginMode = array3[1];
							break;
						case "inbroker":
							ApplicationInfo.AccInfo.UserInternetInBroker = array3[1];
							break;
						case "account":
							ApplicationInfo.AccInfo.UserLists = array3[1];
							break;
						case "usernameproxy":
							Settings.Default.ProxyUsername = array3[1];
							break;
						case "passwordproxy":
							ApplicationInfo.ProxyPassword = array3[1];
							break;
						case "key":
							ApplicationInfo.AuthenKey = array3[1];
							break;
						case "pin":
							ApplicationInfo.UserPincode = array3[1];
							break;
						case "ke_session":
							ApplicationInfo.KE_Session = array3[1];
							break;
						case "ke_athurl":
							ApplicationInfo.KE_AuthenUrl = array3[1];
							break;
						case "ke_local":
							ApplicationInfo.KE_LOCAL = array3[1];
							break;
						case "ke_sbl":
							ApplicationInfo.SuuportSBL = array3[1];
							break;
						case "aspticket":
							ApplicationInfo.ASP_Ticket = array3[1];
							break;
						case "ktz_session":
							ApplicationInfo.KTZ_Session = array3[1];
							break;
						case "ktz_cust_map_key":
							ApplicationInfo.KTZ_custMapKey = array3[1];
							break;
						case "fss_session":
							ApplicationInfo.FSS_Session = array3[1];
							break;
						case "tns_session":
							ApplicationInfo.TNS_Session = array3[1];
							break;
						case "yt_session":
							ApplicationInfo.YUANTA_Session = array3[1];
							break;
						case "user_efin":
							ApplicationInfo.UserEfin = array3[1];
							break;
						case "req_tfex":
							Settings.Default.RequestTfex = (array3[1] == "Y");
							break;
						case "second_i2info":
							ApplicationInfo.Isi2infoLink2 = (array3[1] == "Y");
							break;
						case "autotrade":
							ApplicationInfo.AutoTradeFromWeb = (array3[1] == "Y");
							break;
						}
						IL_43D:
						i++;
						continue;
						goto IL_43D;
					}
					if (ApplicationInfo.IsOpenFromWeb)
					{
						if (ApplicationInfo.AccInfo.UserLists != string.Empty)
						{
							string[] array4 = ApplicationInfo.AccInfo.UserLists.Split(new char[]
							{
								'|'
							});
							if (array4.Length > 0)
							{
								ApplicationInfo.UserLoginID = array4[0];
								ApplicationInfo.AccInfo.UserLists = ApplicationInfo.AccInfo.UserLists.Replace('|', '/');
							}
						}
					}
					Application.Run(new frmLogIn());
				}
			}
			catch (Exception ex)
			{
				EventLog.WriteEntry("i2TradePlus", ex.Message);
			}
			finally
			{
			}
			try
			{
			}
			catch
			{
			}
		}

		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll")]
		private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x06000004 RID: 4
		[DllImport("user32.dll")]
		private static extern int SetForegroundWindow(IntPtr hWnd);

		// Token: 0x06000005 RID: 5
		[DllImport("user32.dll")]
		private static extern int IsIconic(IntPtr hWnd);

		// Token: 0x06000006 RID: 6 RVA: 0x000025F0 File Offset: 0x000009F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IntPtr GetCurrentInstanceWindowHandle()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			IntPtr result = IntPtr.Zero;
			Process currentProcess = Process.GetCurrentProcess();
			Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
			Process[] array = processesByName;
			for (int i = 0; i < array.Length; i++)
			{
				Process process = array[i];
				if (process.Id != currentProcess.Id && process.MainModule.FileName == currentProcess.MainModule.FileName && process.MainWindowHandle != IntPtr.Zero)
				{
					result = process.MainWindowHandle;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000026BC File Offset: 0x00000ABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SwitchToCurrentInstance()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			IntPtr currentInstanceWindowHandle = Program.GetCurrentInstanceWindowHandle();
			if (currentInstanceWindowHandle != IntPtr.Zero)
			{
				if (Program.IsIconic(currentInstanceWindowHandle) != 0)
				{
					Program.ShowWindow(currentInstanceWindowHandle, 9);
				}
				Program.SetForegroundWindow(currentInstanceWindowHandle);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002718 File Offset: 0x00000B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Run(Form frmMain)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			if (Program.IsAlreadyRunning())
			{
				Program.SwitchToCurrentInstance();
				result = false;
			}
			else
			{
				Application.Run(frmMain);
				result = true;
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002760 File Offset: 0x00000B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Run()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return !Program.IsAlreadyRunning();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000279C File Offset: 0x00000B9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool IsAlreadyRunning()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string location = Assembly.GetExecutingAssembly().Location;
			FileSystemInfo fileSystemInfo = new FileInfo(location);
			string name = fileSystemInfo.Name;
			bool flag;
			Program.mutex = new Mutex(true, "Global\\" + name, out flag);
			if (flag)
			{
				Program.mutex.ReleaseMutex();
			}
			return !flag;
		}

		// Token: 0x04000001 RID: 1
		private static Mutex mutex;
	}
}
