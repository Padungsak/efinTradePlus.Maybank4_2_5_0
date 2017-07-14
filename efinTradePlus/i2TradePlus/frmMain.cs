using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Controls;
using i2TradePlus.FixForm;
using i2TradePlus.Information;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.MyDataSet;
using i2TradePlus.Properties;
using i2TradePlus.Templates;
using i2TradePlus.User_Control;
using i2TradePlus.WebProxy;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using ITSNet.Common.BIZ.RealtimeMessage.TFEX;
using ITSNet.Common.BIZ.Tunnel;
using Microsoft.Win32;
using nsoftware.IPWorksSSL;

namespace i2TradePlus
{
	// Token: 0x0200003D RID: 61
	internal class frmMain : Form
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000293 RID: 659 RVA: 0x0002DA04 File Offset: 0x0002BE04
		// (remove) Token: 0x06000294 RID: 660 RVA: 0x0002DA2C File Offset: 0x0002BE2C
        public static frmMain.OnMessageRecievedEventHendler _OnMessageReceived;
		internal static event frmMain.OnMessageRecievedEventHendler OnMessageReceived
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				//while (false)
				//{
					////object arg_0A_0 = null[0];
				//}
                frmMain._OnMessageReceived += value;
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                //while (false)
                //{
                //    //object arg_0A_0 = null[0];
                //}
                frmMain._OnMessageReceived -= value;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000295 RID: 661 RVA: 0x0002DA54 File Offset: 0x0002BE54
		// (remove) Token: 0x06000296 RID: 662 RVA: 0x0002DA7C File Offset: 0x0002BE7C
        public static frmMain.OnMessageTfexRecievedEventHendler _OnMessageTfexReceived;
		internal static event frmMain.OnMessageTfexRecievedEventHendler OnMessageTfexReceived
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
                //while (false)
                //{
                //    //object arg_0A_0 = null[0];
                //}
				frmMain._OnMessageTfexReceived += value;
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				frmMain._OnMessageTfexReceived -= value;
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0002DAA4 File Offset: 0x0002BEA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmMain() : base()
		{
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.feedsWebProxy = null;
			this.timerHeartBeat = null;
			this._isResizeMDNext = false;
			this.ipwIPPortMain = null;
			this._alertDetailForm = null;
			this._systemOptionForm = null;
			this.bgwLoadProfile = null;
			this.bgwLogout = null;
			this._isCheckHBworking = false;
			this._bcMessageFactory = null;
			this._isForceLogout = false;
			this._isExpire = false;
			this._connectionPullCounter = 0;
			this._isPushConnected = false;
			this.param = string.Empty;
			this.splashForm = null;
			this._powerMode = PowerModes.StatusChange;
			this.timmerStartBC = null;
			this.isTerminate = false;
			this._IsOpeningTemplate = false;
			this._OpenTemplateLastTime = DateTime.MinValue;
			this._lastTemplate = string.Empty;
			this.tmBottomClientResize = null;
			this._isPanelSepResize = false;
			this._formRS = null;
			this._slideType = 1;
			this._qMessage = null;
			this._isRunPeekQ = false;
			this._isPeekQWorking = false;
			this._frmStopDisclaimer = null;
			this.components = null;
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			this.InitializeComponent();
			this.MinimumSize = new Size(800, 600);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0002DBE4 File Offset: 0x0002BFE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeFeedsWebProxy()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.feedsWebProxy == null)
			{
				this.feedsWebProxy = new FeedsWebProxy();
				this.feedsWebProxy.UrlForSyncHandler = ApplicationInfo.UrlSyncHandler;
				this.feedsWebProxy.OnDataIN += new FeedsWebProxy.OnDataInHandler(this.feedsWebProxy_OnDataIN);
				this.feedsWebProxy.OnError += new FeedsWebProxy.OnErrorHandler(this.feedsWebProxy_OnError);
				this.feedsWebProxy.OnGettingHttp += new EventHandler(this.feedsWebProxy_OnGettingHttp);
				this.feedsWebProxy.OnGettedHttp += new EventHandler(this.feedsWebProxy_OnGettedHttp);
				this.feedsWebProxy.OnStoped += new EventHandler(this.feedsWebProxy_OnStoped);
				this.feedsWebProxy.OnStarted += new EventHandler(this.feedsWebProxy_OnStarted);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0002DCC4 File Offset: 0x0002C0C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void feedsWebProxy_OnStarted(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._connectionPullCounter = 0;
			this.ShowConnectionStatus();
			this.CloseSpashForm();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0002DCEC File Offset: 0x0002C0EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void feedsWebProxy_OnStoped(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ShowConnectionStatus();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0002DD04 File Offset: 0x0002C104
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void feedsWebProxy_OnGettedHttp(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0002DD18 File Offset: 0x0002C118
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void feedsWebProxy_OnGettingHttp(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0002DD2C File Offset: 0x0002C12C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void feedsWebProxy_OnError(TransferEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = e.Exception.Message.ToUpper();
			if (text != null)
			{
				if (text == "THE OPERATION HAS TIMED OUT" || text == "THE UNDERLYING CONNECTION WAS CLOSED: AN UNEXPECTED ERROR OCCURRED ON A RECEIVE." || text == "UNABLE TO CONNECT TO THE REMOTE SERVER")
				{
					this.ShowConnectionStatus();
					this.ShowSpashForm("PULL Connecting...");
					return;
				}
			}
			if (e.Exception != null)
			{
				this.ShowError("feedsWebProxy_OnError", e.Exception);
			}
			else if (e.Code == -1)
			{
				this.ShowError("feedsWebProxy_OnError", e.Exception);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0002DE00 File Offset: 0x0002C200
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void feedsWebProxy_OnDataIN(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!string.IsNullOrEmpty(message))
			{
				this.OnDataIn(message);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0002DE34 File Offset: 0x0002C234
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMain_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (base.CreateGraphics().DpiX == 120f)
				{
					ApplicationInfo.IsScreen125 = true;
				}
				else
				{
					ApplicationInfo.IsScreen125 = false;
				}
				if (Settings.Default.Default_WindowMaximizeState)
				{
					base.WindowState = FormWindowState.Maximized;
				}
				else
				{
					base.Bounds = Settings.Default.Default_Bound;
				}
				this._BTop = Settings.Default.Default_MainScreenHeight;
				if (Settings.Default.Default_FirstOpen)
				{
					int num;
					if (Screen.PrimaryScreen.Bounds.Size == new Size(1024, 768))
					{
						num = 10;
					}
					else if (Screen.PrimaryScreen.Bounds.Size == new Size(800, 600))
					{
						num = 7;
					}
					else if (Screen.PrimaryScreen.Bounds.Size == new Size(1280, 720))
					{
						num = 9;
					}
					else if (Screen.PrimaryScreen.Bounds.Size == new Size(1280, 768))
					{
						num = 10;
					}
					else if (Screen.PrimaryScreen.Bounds.Size == new Size(1280, 800))
					{
						num = 11;
					}
					else if (Screen.PrimaryScreen.Bounds.Size.Height <= 600)
					{
						num = 7;
					}
					else if (Screen.PrimaryScreen.Bounds.Size.Height <= 720)
					{
						num = 9;
					}
					else if (Screen.PrimaryScreen.Bounds.Size.Height <= 768)
					{
						num = 10;
					}
					else if (Screen.PrimaryScreen.Bounds.Size.Height <= 800)
					{
						num = 11;
					}
					else
					{
						num = 12;
					}
					Settings.Default.Default_Font = new Font(this.Font.Name, (float)num, FontStyle.Regular);
					Settings.Default.Default_FirstOpen = false;
				}
				this.panelTop.Font = new Font(Settings.Default.Default_Font.Name, 8.25f, Settings.Default.Default_Font.Style);
				MyColor.SetStyle(ApplicationInfo.IsFrontSoftStyle);
				this.timerCallLoginForm.Enabled = true;
			}
			catch (Exception ex)
			{
				this.ShowError("frmMain_Load", ex);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0002E168 File Offset: 0x0002C568
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerCallLoginForm_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timerCallLoginForm.Enabled = false;
				if (this.LoadAllInformation())
				{
					ApplicationInfo.IsAreadyLogin = true;
					if (this.bgwLoadProfile == null)
					{
						this.bgwLoadProfile = new BackgroundWorker();
					}
					this.bgwLoadProfile.DoWork -= new DoWorkEventHandler(this.bgwLoadProfile_DoWork);
					this.bgwLoadProfile.DoWork += new DoWorkEventHandler(this.bgwLoadProfile_DoWork);
					this.bgwLoadProfile.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.bgwLoadProfile_RunWorkerCompleted);
					this.bgwLoadProfile.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwLoadProfile_RunWorkerCompleted);
					this.bgwLoadProfile.RunWorkerAsync();
				}
				else
				{
					MessageBox.Show("Can't load information, please reopen program again");
					GC.Collect();
					Application.Exit();
				}
			}
			catch (Exception ex)
			{
				EventLog.WriteEntry("i2Trade", ex.Message, EventLogEntryType.Error);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0002E284 File Offset: 0x0002C684
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMain_SizeChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.WindowState != FormWindowState.Minimized)
			{
				if (TemplateManager.Instance.CurrentActiveTemplateView != null)
				{
					this.Instance_SetBottomSize();
				}
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0002E2D0 File Offset: 0x0002C6D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.isTerminate)
			{
				e.Cancel = !this.CloseApplication();
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0002E30C File Offset: 0x0002C70C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void TrigKeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender is frmBrowser)
			{
				this.frmMain_KeyDown(sender, e);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0002E344 File Offset: 0x0002C744
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void TrigKeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender is frmBrowser)
			{
				this.frmMain_KeyUp(sender, e);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0002E37C File Offset: 0x0002C77C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMain_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode <= Keys.Delete)
			{
				if (keyCode != Keys.Tab)
				{
					if (keyCode != Keys.Space)
					{
						if (keyCode != Keys.Delete)
						{
							goto IL_C3;
						}
						this.ViewOrderBox.SetFocus();
						e.SuppressKeyPress = true;
						goto IL_C3;
					}
					else
					{
						if (ApplicationInfo.CanRecvSpace)
						{
							return;
						}
						e.SuppressKeyPress = true;
						goto IL_C3;
					}
				}
			}
			else if (keyCode <= Keys.Divide)
			{
				if (keyCode != Keys.Multiply)
				{
					switch (keyCode)
					{
					case Keys.Subtract:
					case Keys.Divide:
						break;
					case Keys.Decimal:
						goto IL_C3;
					default:
						goto IL_C3;
					}
				}
			}
			else if (keyCode != Keys.F4 && keyCode != Keys.F10)
			{
				goto IL_C3;
			}
			e.SuppressKeyPress = true;
            IL_C3:
			try
			{
				
				if (ApplicationInfo.IsAreadyLogin)
				{
					if (HotKeyManager.IsValidHotKey(e.KeyData))
					{
						switch (HotKeyManager.GetSystemHotKey(e.KeyData))
						{
						case HotKeyFor.ToggleMenuTemplate:
							e.SuppressKeyPress = true;
							break;
						case HotKeyFor.LogOut:
							this.Logout(false);
							e.SuppressKeyPress = true;
							break;
						case HotKeyFor.SwitchAccount:
							this.SendOrderBox.SwitchAccountControl();
							e.SuppressKeyPress = true;
							break;
						case HotKeyFor.SwitchOrderBox:
							break;
						default:
						{
							HotKeyManager.HotkeyProperty templateHotKey = HotKeyManager.GetTemplateHotKey(e.KeyData);
							if (templateHotKey != null && !string.IsNullOrEmpty(templateHotKey.TemplateName))
							{
								string templateName = templateHotKey.TemplateName;
								switch (templateName)
								{
								case "Buy Order":
								case "Sell Order":
								case "Short Sell Order":
								case "Cover Buy Order":
									this.OpenSendNewOrderForm(templateHotKey.TemplateName);
									goto IL_2AD;
								case "Graph":
									this.OpenTemplate(templateHotKey.TemplateName, "CHART");
									goto IL_2AD;
								case "Finance":
									this.OpenTemplate(templateHotKey.TemplateName, "FINANCE");
									goto IL_2AD;
								case "News":
									this.OpenTemplate(templateHotKey.TemplateName, "NEWS");
									goto IL_2AD;
								}
								this.OpenTemplate(templateHotKey.TemplateName);
								IL_2AD:
								e.SuppressKeyPress = true;
							}
							break;
						}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmMain_KeyUp", ex);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0002E680 File Offset: 0x0002CA80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMain_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsAreadyLogin)
				{
					if (e.KeyCode != Keys.Space || !ApplicationInfo.CanRecvSpace)
					{
						if (TemplateManager.Instance.CurrentActiveTemplateView != null)
						{
							TemplateManager.Instance.CurrentActiveTemplateView.FormKeyUp(e);
						}
						if (e.KeyCode == Keys.NumLock)
						{
							this.SetNumLock();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmMain_KeyUp", ex);
			}
		}

		// Token: 0x060002A7 RID: 679
		[DllImport("user32.dll")]
		internal static extern short GetKeyState(int keyCode);

		// Token: 0x060002A8 RID: 680
		[DllImport("user32.dll")]
		private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

		// Token: 0x060002A9 RID: 681
		[DllImport("user32.dll")]
		private static extern int SetKeyboardState(byte keyState);

		// Token: 0x060002AA RID: 682
		[DllImport("user32.dll")]
		private static extern int GetKeyboardState(ref byte keyState);

		// Token: 0x060002AB RID: 683 RVA: 0x0002E748 File Offset: 0x0002CB48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetNumLock()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			byte[] array = new byte[256];
			frmMain.GetKeyboardState(ref array[0]);
			if (array[144] != 1)
			{
				frmMain.keybd_event(144, 0, 0u, 0);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0002E7A0 File Offset: 0x0002CBA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenSendNewOrderForm(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.CheckFormCanShowByLoginMode(typeof(ucSendNewOrder)))
				{
					string formActivate = string.Empty;
					if (templateName != null)
					{
						if (!(templateName == "Buy Order"))
						{
							if (!(templateName == "Sell Order"))
							{
								if (!(templateName == "Short Sell Order"))
								{
									if (templateName == "Cover Buy Order")
									{
										formActivate = "C";
									}
								}
								else
								{
									formActivate = "H";
								}
							}
							else
							{
								formActivate = "S";
							}
						}
						else
						{
							formActivate = "B";
						}
					}
					if (this.SendOrderBox != null)
					{
						this.SendOrderBox.SetFormActivate(formActivate);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("OpenSendNewOrderForm", ex);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0002E8A4 File Offset: 0x0002CCA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void stopBC()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._isRunPeekQ = false;
				if (this.ipwIPPortMain != null)
				{
					if (this.ipwIPPortMain.Connected)
					{
						this.UnregistrationFromTunnel();
						Thread.Sleep(100);
						this.ipwIPPortMain.Disconnect();
					}
					this.ipwIPPortMain.OnConnected -= new Ipports.OnConnectedHandler(this.ipwIPPortMain_OnConnected);
					this.ipwIPPortMain.OnDisconnected -= new Ipports.OnDisconnectedHandler(this.ipwIPPortMain_OnDisconnected);
					this.ipwIPPortMain.OnDataIn -= new Ipports.OnDataInHandler(this.ipwIPPortMain_OnDataIn);
					this.ipwIPPortMain.OnError -= new Ipports.OnErrorHandler(this.ipwIPPortMain_OnError);
					this.ipwIPPortMain.OnSSLServerAuthentication -= new Ipports.OnSSLServerAuthenticationHandler(this.ipwIPPortMain_OnSSLServerAuthentication);
					this.ipwIPPortMain.OnReadyToSend -= new Ipports.OnReadyToSendHandler(this.ipwIPPortMain_OnReadyToSend);
					this.ipwIPPortMain.Dispose();
					this.ipwIPPortMain = null;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("stopBC", ex);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0002E9DC File Offset: 0x0002CDDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void startBC()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timerMonitorFeed.Enabled = false;
				this.MarketStateBox.DisplayPushPullImage();
				if (!ApplicationInfo.IsPushMode)
				{
					this.ShowSpashForm("PULL Connecting...");
					this.InitializeFeedsWebProxy();
					this.stopBC();
					this.feedsWebProxy.Start();
				}
				else
				{
					this.ShowSpashForm("PUSH(" + Convert.ToString(ApplicationInfo.TunnelCounter + 1) + ") Connecting...");
					if (this.feedsWebProxy != null && this.feedsWebProxy.IsServiceStarted)
					{
						this.feedsWebProxy.Stop();
					}
					if (this.ipwIPPortMain == null)
					{
						this.ipwIPPortMain = new Ipports();
						this.ipwIPPortMain.OnConnected += new Ipports.OnConnectedHandler(this.ipwIPPortMain_OnConnected);
						this.ipwIPPortMain.OnDisconnected += new Ipports.OnDisconnectedHandler(this.ipwIPPortMain_OnDisconnected);
						this.ipwIPPortMain.OnDataIn += new Ipports.OnDataInHandler(this.ipwIPPortMain_OnDataIn);
						this.ipwIPPortMain.OnError += new Ipports.OnErrorHandler(this.ipwIPPortMain_OnError);
						this.ipwIPPortMain.OnSSLServerAuthentication += new Ipports.OnSSLServerAuthenticationHandler(this.ipwIPPortMain_OnSSLServerAuthentication);
						this.ipwIPPortMain.OnReadyToSend += new Ipports.OnReadyToSendHandler(this.ipwIPPortMain_OnReadyToSend);
						this.ipwIPPortMain.Config("InBufferSize=102400");
						if (ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].EnableSSL)
						{
							this.ipwIPPortMain.SSLStartMode = IpportsSSLStartModes.sslImplicit;
						}
						else
						{
							this.ipwIPPortMain.SSLStartMode = IpportsSSLStartModes.sslNone;
						}
					}
					this.ipwIPPortMain.Connected = false;
					this._isRunPeekQ = false;
					int num = 0;
					while (this._isPeekQWorking)
					{
						num++;
						Thread.Sleep(100);
						if (num > 50)
						{
							break;
						}
					}
					this._isRunPeekQ = true;
					if (this.ipwIPPortMain.RemoteHost != ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].HostIP)
					{
						this.ipwIPPortMain.RemoteHost = ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].HostIP;
					}
					if (this.ipwIPPortMain.RemotePort != ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].Port)
					{
						this.ipwIPPortMain.RemotePort = ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].Port;
					}
					this._lastEcho = DateTime.Now;
					this.ipwIPPortMain.Connected = true;
				}
				this.ShowConnectionStatus();
			}
			catch (Exception ex)
			{
				this.ShowError("StartBC", ex);
			}
			this.timerMonitorFeed.Enabled = true;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0002ECEC File Offset: 0x0002D0EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowConnectionStatus()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.ShowConnectionStatus));
			}
			else
			{
				try
				{
					if (ApplicationInfo.IsPushMode)
					{
						if (this.ipwIPPortMain != null)
						{
							ApplicationInfo.IsFeedsStarted = this.ipwIPPortMain.Connected;
						}
						else
						{
							ApplicationInfo.IsFeedsStarted = false;
						}
					}
					else if (this.feedsWebProxy != null)
					{
						ApplicationInfo.IsFeedsStarted = this.feedsWebProxy.CanConnectServer;
					}
					else
					{
						ApplicationInfo.IsFeedsStarted = false;
					}
					this.MarketStateBox.ShowFeedsState(ApplicationInfo.IsFeedsStarted);
				}
				catch (Exception ex)
				{
					this.ShowError("ShowConnectionStatus", ex);
				}
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0002EDE0 File Offset: 0x0002D1E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetEventToNewForm(Form form)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(((IRealtimeMessage)form).ReceiveMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Combine(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(((IRealtimeMessage)form).ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(((IRealtimeMessage)form).ReceiveTfexMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Combine(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(((IRealtimeMessage)form).ReceiveTfexMessage));
			}
			catch (Exception ex)
			{
				this.ShowError("SetEventToNewForm", ex);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0002EEC4 File Offset: 0x0002D2C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDataIn(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!string.IsNullOrEmpty(message))
			{
				try
				{
					this._lastEcho = DateTime.Now;
					if (!(message == "ER"))
					{
						if (message.Substring(0, 1) == "E")
						{
							IBroadcastMessage broadcastMessage = this._bcMessageFactory.CreateSETMessage(message.Substring(1));
							if (broadcastMessage != null)
							{
								StockList.StockInformation stockInformation = null;
								string messageType = broadcastMessage.MessageType;
								switch (messageType)
								{
								case "L+":
								{
									LSAccumulate lSAccumulate = (LSAccumulate)broadcastMessage;
									stockInformation = ApplicationInfo.StockInfo[lSAccumulate.SecurityNumber];
									if (stockInformation.Number <= 0)
									{
										return;
									}
									stockInformation.LastSalePrice = lSAccumulate.LastPrice;
									if (lSAccumulate.LastPrice > stockInformation.HighPrice)
									{
										stockInformation.HighPrice = lSAccumulate.LastPrice;
									}
									if (stockInformation.LowPrice == 0m || lSAccumulate.LastPrice < stockInformation.LowPrice)
									{
										stockInformation.LowPrice = lSAccumulate.LastPrice;
									}
									break;
								}
								case "TP":
								{
									TPMessage tPMessage = (TPMessage)broadcastMessage;
									stockInformation = ApplicationInfo.StockInfo[tPMessage.SecurityNumber];
									if (stockInformation.Number <= 0)
									{
										return;
									}
									if (tPMessage.Side == "B")
									{
										stockInformation.BidPrice1 = tPMessage.Price1.ToString();
									}
									else if (tPMessage.Side == "S")
									{
										stockInformation.OfferPrice1 = tPMessage.Price1.ToString();
									}
									break;
								}
								case "PD":
									stockInformation = ApplicationInfo.StockInfo[((PDMessage)broadcastMessage).SecurityNumber];
									break;
								case "SC":
								{
									SCMessage sCMessage = (SCMessage)broadcastMessage;
									ApplicationInfo.MarketState = sCMessage.MarketState;
									ApplicationInfo.MarketSession = sCMessage.MarketSession;
									this.SETBox.Invalidate();
									break;
								}
								case "MT":
								{
									MarketInfo marketInfo = (MarketInfo)broadcastMessage;
									ApplicationInfo.MarketState = marketInfo.MarketState;
									ApplicationInfo.MarketSession = marketInfo.MarketSession;
									ApplicationInfo.MarketTime = marketInfo.TimeStamp;
									break;
								}
								case "PO":
									stockInformation = ApplicationInfo.StockInfo[((POMessage)broadcastMessage).SecurityNumber];
									break;
								case "SS":
								{
									SSMessage sSMessage = (SSMessage)broadcastMessage;
									stockInformation = ApplicationInfo.StockInfo[sSMessage.SecurityNumber];
									if (stockInformation.Number > -1)
									{
										stockInformation.PriorPrice = sSMessage.PriorPrice;
										stockInformation.BoardLot = sSMessage.BoardLot;
										stockInformation.Ceiling = sSMessage.Ceiling;
										stockInformation.Floor = sSMessage.Floor;
										stockInformation.MarketId = sSMessage.MarketId;
										stockInformation.SecurityType = sSMessage.SecurityType;
										stockInformation.SectorNumber = sSMessage.SectorNumber;
										stockInformation.DisplayFlag = sSMessage.DisplayFlag;
									}
									break;
								}
								case "IS":
								{
									ISMessage iSMessage = (ISMessage)broadcastMessage;
									IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo[iSMessage.Symbol];
									indexItem.IndexHigh = iSMessage.IndexHigh;
									indexItem.IndexLow = iSMessage.IndexLow;
									indexItem.LastIndex = iSMessage.IndexValue;
									indexItem.AccValue = iSMessage.TotalValuesTraded;
									if (iSMessage.Symbol == ".SET")
									{
										this.SETBox.Invalidate();
									}
									else if (iSMessage.Symbol == "." + this.SET2Box.DisplaySET)
									{
										this.SET2Box.Invalidate();
									}
									break;
								}
								case "IE":
								{
									IEMessage iEMessage = (IEMessage)broadcastMessage;
									IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo[iEMessage.Symbol];
									if (indexItem != null)
									{
										indexItem.IndexHigh = iEMessage.IndexHigh;
										indexItem.IndexLow = iEMessage.IndexLow;
										indexItem.LastIndex = iEMessage.IndexValue;
										indexItem.AccValue = iEMessage.AccValue;
									}
									break;
								}
								case "OL":
									stockInformation = ApplicationInfo.StockInfo[((OLMessage)broadcastMessage).SecurityNumber];
									break;
								case "LO":
									stockInformation = ApplicationInfo.StockInfo[((LOMessage)broadcastMessage).SecurityNumber];
									break;
								case "CO":
									stockInformation = ApplicationInfo.StockInfo[((COMessage)broadcastMessage).SecurityNumber];
									break;
								}
								if (frmMain._OnMessageReceived != null)
								{
									frmMain._OnMessageReceived(broadcastMessage, stockInformation);
								}
							}
						}
						else if (message.Substring(0, 1) == "T")
						{
							IBroadcastMessage broadcastMessage = this._bcMessageFactory.CreateTfexMessage(message.Substring(1));
							if (broadcastMessage != null)
							{
								SeriesList.SeriesInformation seriesInformation = null;
								string messageType = broadcastMessage.MessageType;
								switch (messageType)
								{
								case "TP":
								{
									TPMessageTFEX tPMessageTFEX = (TPMessageTFEX)broadcastMessage;
									seriesInformation = ApplicationInfo.SeriesInfo[tPMessageTFEX.OrderBookId];
									if (tPMessageTFEX.Side == "B" && tPMessageTFEX.Vol1 != -1)
									{
										seriesInformation.BidPrice1 = tPMessageTFEX.Price1;
									}
									else if (tPMessageTFEX.Side == "A" && tPMessageTFEX.Vol1 != -1)
									{
										seriesInformation.OfferPrice1 = tPMessageTFEX.Price1;
									}
									break;
								}
								case "LS":
								{
									LSMessageTFEX lSMessageTFEX = (LSMessageTFEX)broadcastMessage;
									seriesInformation = ApplicationInfo.SeriesInfo[lSMessageTFEX.Sec];
									seriesInformation.LastSalePrice = lSMessageTFEX.Price;
									break;
								}
								case "PO":
								{
									POMessageTFEX pOMessageTFEX = (POMessageTFEX)broadcastMessage;
									seriesInformation = ApplicationInfo.SeriesInfo[pOMessageTFEX.Sec];
									break;
								}
								case "ST":
								{
									STMessageTFEX sTMessageTFEX = (STMessageTFEX)broadcastMessage;
									if (sTMessageTFEX.MarketCode == 1)
									{
										ApplicationInfo.IndexInfoTfex.TXIState = sTMessageTFEX.MarketState;
										ApplicationInfo.IndexInfoTfex.TXISession = sTMessageTFEX.MarketSession;
									}
									else if (sTMessageTFEX.MarketCode == 4)
									{
										ApplicationInfo.IndexInfoTfex.TXMState = sTMessageTFEX.MarketState;
										ApplicationInfo.IndexInfoTfex.TXMSession = sTMessageTFEX.MarketSession;
									}
									else if (sTMessageTFEX.MarketCode == 3)
									{
										ApplicationInfo.IndexInfoTfex.TXRState = sTMessageTFEX.MarketState;
										ApplicationInfo.IndexInfoTfex.TXRSession = sTMessageTFEX.MarketSession;
									}
									else if (sTMessageTFEX.MarketCode == 2)
									{
										ApplicationInfo.IndexInfoTfex.TXSState = sTMessageTFEX.MarketState;
										ApplicationInfo.IndexInfoTfex.TXSSession = sTMessageTFEX.MarketSession;
									}
									else if (sTMessageTFEX.MarketCode == 5)
									{
										ApplicationInfo.IndexInfoTfex.TXEState = sTMessageTFEX.MarketState;
										ApplicationInfo.IndexInfoTfex.TXESession = sTMessageTFEX.MarketSession;
									}
									else if (sTMessageTFEX.MarketCode == 6)
									{
										ApplicationInfo.IndexInfoTfex.TXCState = sTMessageTFEX.MarketState;
										ApplicationInfo.IndexInfoTfex.TXCSession = sTMessageTFEX.MarketSession;
									}
									break;
								}
								case "SU":
								{
									SUMessageTFEX sUMessageTFEX = (SUMessageTFEX)broadcastMessage;
									seriesInformation = ApplicationInfo.SeriesInfo[sUMessageTFEX.Sec];
									seriesInformation.ExpireDate = sUMessageTFEX.Expdate.ToString();
									seriesInformation.OpenInt = sUMessageTFEX.OpenBalance;
									break;
								}
								case "SD":
								{
									SDMessageTFEX sDMessageTFEX = (SDMessageTFEX)broadcastMessage;
									if (!ApplicationInfo.SeriesInfo.ItemsKeySymbol.ContainsKey(sDMessageTFEX.Sec.ToString()))
									{
										if (sDMessageTFEX.Group != 5)
										{
											seriesInformation = new SeriesList.SeriesInformation();
											seriesInformation.Symbol = sDMessageTFEX.Sec;
											seriesInformation.MarketCode = sDMessageTFEX.Market;
											seriesInformation.Group = sDMessageTFEX.Group;
											seriesInformation.UnderOrderBookId = sDMessageTFEX.UnderOrderBookId;
											seriesInformation.ContractSize = sDMessageTFEX.Price_quot_factor;
											ApplicationInfo.SeriesInfo.AddItem(seriesInformation);
											this.UpdateAutoComplete(seriesInformation.Symbol);
										}
									}
									else
									{
										seriesInformation = ApplicationInfo.SeriesInfo[sDMessageTFEX.Sec];
										seriesInformation.MarketCode = sDMessageTFEX.Market;
										seriesInformation.Group = sDMessageTFEX.Group;
										seriesInformation.UnderOrderBookId = sDMessageTFEX.UnderOrderBookId;
										seriesInformation.ContractSize = sDMessageTFEX.Price_quot_factor;
									}
									break;
								}
								case "SS":
								{
									SSMessageTFEX sSMessageTFEX = (SSMessageTFEX)broadcastMessage;
									seriesInformation = ApplicationInfo.SeriesInfo[sSMessageTFEX.Sec];
									break;
								}
								case "BU10":
								{
									BU10MessageTFEX bU10MessageTFEX = (BU10MessageTFEX)broadcastMessage;
									foreach (KeyValuePair<int, SeriesList.SeriesInformation> current in ApplicationInfo.SeriesInfo.Items)
									{
										if (current.Value.Group == bU10MessageTFEX.Group && current.Value.UnderOrderBookId == bU10MessageTFEX.Commodity)
										{
											current.Value.TickSize = bU10MessageTFEX.StepSize;
											break;
										}
									}
									break;
								}
								case "IU":
								{
									IUMessageTFEX iUMessageTFEX = (IUMessageTFEX)broadcastMessage;
									if (iUMessageTFEX.IndxName == "SET50")
									{
										IndexStat.IndexItem indexItem2 = ApplicationInfo.IndexStatInfo[".SET50"];
										if (indexItem2 != null)
										{
											if (iUMessageTFEX.LastIndx > 0m)
											{
												indexItem2.LastIndex = iUMessageTFEX.LastIndx;
											}
										}
									}
									break;
								}
								case "CA8":
								{
									CA8MessageTFEX cA8MessageTFEX = (CA8MessageTFEX)broadcastMessage;
									seriesInformation = ApplicationInfo.SeriesInfo[cA8MessageTFEX.Sec];
									if (ApplicationInfo.IndexInfoTfex.TXISession == 2)
									{
										seriesInformation.FixPrice = cA8MessageTFEX.FixingPrice;
										if (seriesInformation.MarketCode == 4)
										{
											seriesInformation.PrevFixPrice = cA8MessageTFEX.FixingPrice;
										}
									}
									else
									{
										seriesInformation.PrevFixPrice = cA8MessageTFEX.FixingPrice;
									}
									seriesInformation.NumOfDec = cA8MessageTFEX.DecPrice;
									break;
								}
								case "TCF":
								{
									TCFMessageTFEX tCFMessageTFEX = (TCFMessageTFEX)broadcastMessage;
									seriesInformation = ApplicationInfo.SeriesInfo[tCFMessageTFEX.SeriesName.Trim()];
									if (!string.IsNullOrEmpty(seriesInformation.Symbol))
									{
										seriesInformation.Ceiling = tCFMessageTFEX.Ceiling;
										seriesInformation.Floor = tCFMessageTFEX.Floor;
										seriesInformation.PrevFixPrice = tCFMessageTFEX.PrevFixPrice;
									}
									break;
								}
								case "MI":
								{
									MIMessageTFEX mIMessageTFEX = (MIMessageTFEX)broadcastMessage;
									ApplicationInfo.IndexInfoTfex.FutureVol = mIMessageTFEX.FuturesVol;
									ApplicationInfo.IndexInfoTfex.FutureOI = mIMessageTFEX.FuturesOI;
									ApplicationInfo.IndexInfoTfex.OptionsVol = mIMessageTFEX.OptionsVol;
									ApplicationInfo.IndexInfoTfex.OptionsOI = mIMessageTFEX.OptionsOI;
									ApplicationInfo.IndexInfoTfex.TfexTotalVol = mIMessageTFEX.TotalVol;
									ApplicationInfo.IndexInfoTfex.TfexTotalDeal = mIMessageTFEX.TotalDeal;
									ApplicationInfo.IndexInfoTfex.TfexTotalOI = mIMessageTFEX.TotalOI;
									break;
								}
								}
								if (frmMain._OnMessageTfexReceived != null)
								{
									frmMain._OnMessageTfexReceived(broadcastMessage, seriesInformation);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("OnDataIn", new Exception(ex.Message + ("[" + message) + "]"));
				}
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0002FD40 File Offset: 0x0002E140
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnAlert(AlertItem e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMain.OnAlertCallback(this.OnAlert), new object[]
				{
					e
				});
			}
			else
			{
				try
				{
					this.CreateAlertDetailForm();
					this._alertDetailForm.AddAlertItem(e);
					if (ApplicationInfo.AlertAutoPopup)
					{
						this._alertDetailForm.Show();
						this._alertDetailForm.BringToFront();
					}
					else
					{
						this.MarketStateBox.IsAllowBlinkAlert = true;
						this.MarketStateBox.AlterMessageCount++;
					}
					if (ApplicationInfo.AlertSound)
					{
						ApplicationInfo.Beep(500, 200);
					}
				}
				catch (Exception ex)
				{
					this.ShowError("OnAlert", ex);
				}
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0002FE48 File Offset: 0x0002E248
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateAlertDetailForm()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._alertDetailForm == null)
				{
					this._alertDetailForm = new frmAlertDetail();
					this._alertDetailForm.TopMost = true;
					this._alertDetailForm.StartPosition = FormStartPosition.CenterScreen;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0002FEBC File Offset: 0x0002E2BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenAlertForm()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.OpenAlertForm));
			}
			else
			{
				try
				{
					this.CreateAlertDetailForm();
					this._alertDetailForm.Show();
					this._alertDetailForm.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("OpenAlertForm", ex);
				}
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0002FF50 File Offset: 0x0002E350
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearAllTemplate()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				List<string> list = new List<string>();
				foreach (KeyValuePair<string, TemplateView> current in TemplateManager.Instance.TemplateViews)
				{
					list.Add(current.Value.Name);
				}
				for (int i = 0; i < list.Count; i++)
				{
					TemplateView template = TemplateManager.Instance.GetTemplate(list[i]);
					if (template != null)
					{
						TemplateManager.Instance.CurrentActiveTemplateView = template;
						this.SaveTemplate();
						TemplateManager.Instance.DeleteTemplate(TemplateManager.Instance.CurrentActiveTemplateView.Name);
						Thread.Sleep(100);
					}
				}
				list.Clear();
				list = null;
			}
			catch (Exception ex)
			{
				this.ShowError("ClearAllTemplate", ex);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00030084 File Offset: 0x0002E484
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadAppInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				using (ApplicationInfoDS applicationInfoDS = new ApplicationInfoDS())
				{
					string templatePathByUser = ApplicationInfo.GetTemplatePathByUser();
					string text = templatePathByUser + "\\ApplicationInfo.xml";
					if (File.Exists(text))
					{
						applicationInfoDS.ReadXml(text);
					}
					if (applicationInfoDS.Info.Rows.Count > 0)
					{
						if (applicationInfoDS.Info.Columns.Contains("TPBlinkColor"))
						{
							if (applicationInfoDS.Info[0].TPBlinkColor == "Y")
							{
								ApplicationInfo.IsSupportTPBlinkColor = true;
							}
							else
							{
								ApplicationInfo.IsSupportTPBlinkColor = false;
							}
						}
						if (applicationInfoDS.Info.Columns.Contains("ValidatePolicy"))
						{
							ApplicationInfo.IsRiskActive = applicationInfoDS.Info[0].ValidatePolicy;
						}
						if (applicationInfoDS.Info.Columns.Contains("AlertEnable"))
						{
							ApplicationInfo.AlertOpen = applicationInfoDS.Info[0].AlertEnable;
						}
						if (applicationInfoDS.Info.Columns.Contains("AlertAutoPopup"))
						{
							ApplicationInfo.AlertAutoPopup = applicationInfoDS.Info[0].AlertAutoPopup;
						}
						if (applicationInfoDS.Info.Columns.Contains("AlertSound"))
						{
							ApplicationInfo.AlertSound = applicationInfoDS.Info[0].AlertSound;
						}
					}
					else
					{
						ApplicationInfo.IsSupportTPBlinkColor = true;
						ApplicationInfo.IsRiskActive = false;
						ApplicationInfo.AlertOpen = false;
						ApplicationInfo.AlertAutoPopup = true;
						ApplicationInfo.AlertSound = false;
					}
					applicationInfoDS.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoadAppInfo", ex);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000302C8 File Offset: 0x0002E6C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaveAppInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				using (ApplicationInfoDS applicationInfoDS = new ApplicationInfoDS())
				{
					string text = ApplicationInfo.GetTemplatePathByUser() + "\\ApplicationInfo.xml";
					if (File.Exists(text))
					{
						applicationInfoDS.ReadXml(text);
						applicationInfoDS.Info.Clear();
					}
					ApplicationInfoDS.InfoRow infoRow = applicationInfoDS.Info.NewInfoRow();
					if (ApplicationInfo.IsSupportTPBlinkColor)
					{
						infoRow.TPBlinkColor = "Y";
					}
					else
					{
						infoRow.TPBlinkColor = "N";
					}
					infoRow.ValidatePolicy = ApplicationInfo.IsRiskActive;
					infoRow.AlertEnable = ApplicationInfo.AlertOpen;
					infoRow.AlertSound = ApplicationInfo.AlertSound;
					infoRow.AlertAutoPopup = ApplicationInfo.AlertAutoPopup;
					applicationInfoDS.Info.AddInfoRow(infoRow);
					if (File.Exists(text))
					{
						applicationInfoDS.WriteXml(text);
					}
					else
					{
						if (!Directory.Exists(ApplicationInfo.GetTemplatePathByUser()))
						{
							Directory.CreateDirectory(ApplicationInfo.GetTemplatePathByUser());
						}
						applicationInfoDS.WriteXml(text);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SaveUserProfile", ex);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00030450 File Offset: 0x0002E850
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CloseApplication()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			try
			{
				if (this._alertDetailForm != null)
				{
					this._alertDetailForm.Hide();
				}
				if (!ApplicationInfo.IsAreadyLogin)
				{
					result = true;
					return result;
				}
				if (MessageBox.Show("Would you like to Exit?", "Exit", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					result = false;
					return result;
				}
				this.Logout(true);
			}
			catch (Exception ex)
			{
				this.ShowError("CloseApplication", ex);
			}
			result = false;
			return result;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00030510 File Offset: 0x0002E910
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSpashForm(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMain.showSpashFormCallBack(this.ShowSpashForm), new object[]
				{
					message
				});
			}
			else
			{
				if (this.splashForm == null)
				{
					this.splashForm = new frmSplash();
					this.splashForm.TopLevel = false;
					this.splashForm.Parent = this;
					this.splashForm.TopMost = true;
				}
				if (base.WindowState != FormWindowState.Minimized)
				{
					this.splashForm.Left = (base.Width - this.splashForm.Width) / 2;
					this.splashForm.Top = (base.Height - this.splashForm.Height) / 2;
				}
				this.splashForm.SetCurrentTask(message);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0003060C File Offset: 0x0002EA0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CloseSpashForm()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.splashForm != null)
			{
				if (this.splashForm.InvokeRequired)
				{
					this.splashForm.Invoke(new MethodInvoker(this.CloseSpashForm));
				}
				else
				{
					this.splashForm.Hide();
					this.splashForm.DisposeMe();
					this.splashForm = null;
				}
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00030690 File Offset: 0x0002EA90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoadProfile_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (AlertManager.Instance.ReadData())
				{
					AlertManager.Instance.OnAlert -= new AlertManager.OnAlertHandler(this.OnAlert);
					AlertManager.Instance.OnAlert += new AlertManager.OnAlertHandler(this.OnAlert);
				}
				AlertManager.Instance.IsMonitoring = true;
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(AlertManager.Instance.ReceiveMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Combine(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(AlertManager.Instance.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(AlertManager.Instance.ReceiveTfexMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Combine(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(AlertManager.Instance.ReceiveTfexMessage));
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoadProfile_DoWork", ex);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000307BC File Offset: 0x0002EBBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoadProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.LoadAppInfo();
				try
				{
					HotKeyManager.Initial();
				}
				catch (Exception ex)
				{
					this.ShowError("HotkeyInit()", ex);
				}
				string text = "<" + ApplicationInfo.UserLoginID + "> ";
				switch (ApplicationInfo.BrokerId)
				{
				case 1:
					text += "CNS";
					this.picBrokerLogo.Image = Resources.logo_cns;
					break;
				case 2:
					text += "KTZ";
					this.picBrokerLogo.Image = Resources.logo_ktz;
					break;
				case 3:
					text += "RHBS";
					this.picBrokerLogo.Image = Resources.logo_rhbosk;
					break;
				case 4:
					text += "MAYBANK KIM ENG";
					this.picBrokerLogo.Image = Resources.logo_mbket;
					break;
				case 7:
					text += "AIRA";
					this.picBrokerLogo.Image = Resources.logo_aira;
					break;
				case 8:
					text += "ASIA PLUS";
					this.picBrokerLogo.Image = Resources.logo_asp;
					break;
				case 9:
					text += "KTBST";
					this.picBrokerLogo.Image = Resources.logo_ktbst;
					break;
				case 10:
					text += "AWS";
					this.picBrokerLogo.Image = Resources.logo_aws;
					break;
				case 11:
					text += "CIMBS";
					this.picBrokerLogo.Image = Resources.logo_cimbs;
					break;
				case 12:
					text += "YUANTA";
					this.picBrokerLogo.Image = Resources.logo_yuanta;
					break;
				case 13:
					text += "LHSEC";
					this.picBrokerLogo.Image = Resources.logo_lhsec;
					break;
				case 14:
					text += "AECS";
					this.picBrokerLogo.Image = Resources.logo_aecs;
					break;
				case 15:
					text += "TNS";
					this.picBrokerLogo.Image = Resources.logo_tns;
					break;
				case 16:
					text += "GLOBLEX";
					this.picBrokerLogo.Image = Resources.logo_gbx;
					break;
				case 17:
					text += "FNSYRUS";
					this.picBrokerLogo.Image = Resources.logo_fnsyrus;
					break;
				case 18:
					text += "UOB KayHian";
					this.picBrokerLogo.Image = Resources.logo_uob;
					break;
				}
				text += " efin Trade Plus";
				text = text + " " + Application.ProductVersion;
				if (ApplicationInfo.BrokerId == 88)
				{
					text += " -- DEMO";
				}
				if (ApplicationInfo.BrokerId == 89)
				{
					text += " -- CNS DEMO";
				}
				if (ApplicationInfo.BrokerId == 90)
				{
					text += " -- DEMO MOU";
					this.picBrokerLogo.Image = Resources.logo_demo;
					ApplicationInfo.BrokerId = 88;
				}
				this.Text = text;
				this.SetTopPanelActive(true);
				this.CloseSpashForm();
				TemplateManager.Instance.MainForm = this;
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.SendOrderBox.ReceiveMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Combine(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.SendOrderBox.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.SendOrderBox.ReceiveTfexMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Combine(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.SendOrderBox.ReceiveTfexMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.ViewOrderBox.ReceiveMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Combine(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.ViewOrderBox.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.ViewOrderBox.ReceiveTfexMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Combine(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.ViewOrderBox.ReceiveTfexMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.BroadcastMessageBox.ReceiveMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Combine(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.BroadcastMessageBox.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.BroadcastMessageBox.ReceiveTfexMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Combine(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.BroadcastMessageBox.ReceiveTfexMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.TickerSlideBox.ReceiveMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Combine(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.TickerSlideBox.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.TickerSlideBox.ReceiveTfexMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Combine(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.TickerSlideBox.ReceiveTfexMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.Smart1ClickBox.ReceiveMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Combine(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.Smart1ClickBox.ReceiveMessage));
				this.panBottom.Font = Settings.Default.Default_Font;
				ApplicationInfo.UserPincodeWrongCount = 0;
				Font font = new Font("Segoe UI", 10.2f);
				if (this.btnMarketWatch.Font != font)
				{
					this.btnMarketWatch.Font = font;
					this.btnViewOrder.Font = font;
					this.btnPortfolio.Font = font;
					this.btnAutoTrade.Font = font;
					this.btnMarketInfo.Font = font;
					this.btnSummary.Font = font;
					this.btnNews.Font = font;
					this.btnGraph.Font = font;
					this.btnFinance.Font = font;
					this.btnMore.Font = font;
					this.btnLogout.Font = new Font(font.Name, font.Size - 1.25f);
					this.btnMarketWatch.Left = 3;
					this.btnPortfolio.Left = this.btnMarketWatch.Right;
					this.btnViewOrder.Left = this.btnPortfolio.Right;
					if (ApplicationInfo.AutoTradeType > 0)
					{
						this.btnAutoTrade.Visible = true;
						this.btnAutoTrade.Left = this.btnViewOrder.Right;
						this.btnMarketInfo.Left = this.btnAutoTrade.Right;
					}
					else
					{
						this.btnAutoTrade.Visible = false;
						this.btnMarketInfo.Left = this.btnViewOrder.Right;
					}
					this.btnSummary.Left = this.btnMarketInfo.Right;
					this.btnNews.Visible = ApplicationInfo.IsSupportEfinChart;
					this.btnGraph.Visible = ApplicationInfo.IsSupportEfinChart;
					this.btnFinance.Visible = ApplicationInfo.IsSupportEfinChart;
					if (ApplicationInfo.IsSupportEfinChart)
					{
						this.btnNews.Left = this.btnSummary.Right;
						this.btnGraph.Left = this.btnNews.Right;
						this.btnFinance.Left = this.btnGraph.Right;
						this.btnMore.Left = this.btnFinance.Right;
					}
					else
					{
						this.btnMore.Left = this.btnFinance.Right;
					}
					if (ApplicationInfo.IsScreen125)
					{
						this.SETBox.Width += 30;
						this.SET2Box.Width += 40;
					}
					this.SETBox.Left = this.pici2Logo.Right + 5;
					this.SET2Box.Left = this.SETBox.Right + 5;
					this.SectorBox.Left = this.SET2Box.Right + 5;
				}
				this.panelMenu.Visible = true;
				this.SendOrderBox.Hide();
				this.ViewOrderBox.Hide();
				this.BroadcastMessageBox.Hide();
				this.btnResizeMD1.Hide();
				this.Resize_BottomBox();
				this.panelSep.Show();
				this.panBottom.Show();
				this.SendOrderBox.InitAccount();
				this.Resize_SendOrderBox();
				this.SendOrderBox.Visible = true;
				this.Resize_ViewOrderBox_BcBox();
				this.ViewOrderBox.Visible = true;
				this.btnResizeMD1.Visible = true;
				this.BroadcastMessageBox.Visible = true;
				this.Resize_DockR();
				this.ViewOrderBox.IsShowToolsBar = true;
				this.ViewOrderBox.SetHeaderHeightPct(80);
				if (Settings.Default.BottomSizePct == 0m)
				{
					Settings.Default.BottomSizePct = 0.6m;
				}
				this.SendOrderBox.IsActive = true;
				this.CloseSpashForm();
				this.ShowSpashForm("Open Default Template.");
				if (string.IsNullOrEmpty(TemplateManager.Instance.DefaultTemplateName))
				{
					this.OpenTemplate("My List");
				}
				else
				{
					this.OpenTemplate(TemplateManager.Instance.DefaultTemplateName);
				}
				this._isForceLogout = false;
				if (ApplicationInfo.HBInterval <= 0)
				{
					this.DisplayMessageBox("Invalid Heartbeat Time![" + ApplicationInfo.HBInterval + "]");
				}
				if (this.timerHeartBeat == null && ApplicationInfo.HBInterval > 0)
				{
					this.timerHeartBeat = new System.Timers.Timer();
					this.timerHeartBeat.Interval = (double)ApplicationInfo.HBInterval;
					this.timerHeartBeat.Elapsed += new ElapsedEventHandler(this.timerHeartBeat_Elapsed);
				}
				this.timerHeartBeat.Start();
				if (!ApplicationInfo.IsUseProxy)
				{
					ApplicationInfo.IsPushMode = true;
				}
				if (this.timmerStartBC == null)
				{
					this.timmerStartBC = new System.Windows.Forms.Timer();
					this.timmerStartBC.Interval = 1000;
					this.timmerStartBC.Tick += new EventHandler(this.timmerStartBC_Tick);
				}
				this.timmerStartBC.Enabled = false;
				this.timmerStartBC.Enabled = true;
				if (ApplicationInfo.AutoGetOrderInfoInterval < 1)
				{
					ApplicationInfo.AutoGetOrderInfoInterval = 1;
				}
				this.timerGetOrderInfo.Enabled = false;
				this.timerGetOrderInfo.Enabled = true;
				SystemEvents.PowerModeChanged -= new PowerModeChangedEventHandler(this.SystemEvents_PowerModeChanged);
				SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(this.SystemEvents_PowerModeChanged);
			}
			catch (Exception ex2)
			{
				this.ShowError("bgwLoadProfile_RunWorkerCompleted", ex2);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00031420 File Offset: 0x0002F820
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._powerMode = e.Mode;
				if (this._powerMode == PowerModes.Suspend)
				{
					if (this.timerMonitorFeed != null)
					{
						this.timerMonitorFeed.Enabled = false;
					}
					if (!ApplicationInfo.IsPushMode)
					{
						this.stopBC();
					}
					else if (this.feedsWebProxy != null && this.feedsWebProxy.IsServiceStarted)
					{
						this.feedsWebProxy.Stop();
					}
				}
				else
				{
					this.timer1.Start();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SystemEvents_PowerModeChanged", ex);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00031508 File Offset: 0x0002F908
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timmerStartBC_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timmerStartBC.Enabled = false;
				if (this._bcMessageFactory == null)
				{
					this._bcMessageFactory = new BroadcastMessageFactory();
				}
				this.startBC();
			}
			catch (Exception ex)
			{
				this.ShowError("timmerStartBC_Tick", ex);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00031584 File Offset: 0x0002F984
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Logout(bool isForce)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMain.LogoutCallBack(this.Logout), new object[]
				{
					isForce
				});
			}
			else
			{
				try
				{
					this.CloseSpashForm();
					DialogResult dialogResult;
					if (this._isForceLogout)
					{
						dialogResult = DialogResult.Yes;
					}
					else if (!isForce)
					{
						dialogResult = MessageBox.Show("Would you like to logout?", "Logout", MessageBoxButtons.YesNo);
					}
					else
					{
						dialogResult = DialogResult.Yes;
					}
					if (dialogResult == DialogResult.Yes)
					{
						if (this.bgwLogout == null)
						{
							this.bgwLogout = new BackgroundWorker();
							this.bgwLogout.WorkerReportsProgress = true;
							this.bgwLogout.DoWork += new DoWorkEventHandler(this.bgwLogout_DoWork);
							this.bgwLogout.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwLogout_RunWorkerCompleted);
						}
						this.ShowSpashForm("Logout...");
						this.isTerminate = isForce;
						if (!this.bgwLogout.IsBusy)
						{
							this.bgwLogout.RunWorkerAsync();
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("Logout", ex);
				}
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000316EC File Offset: 0x0002FAEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLogout_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timmerStartBC.Enabled = false;
				this.timerMonitorFeed.Enabled = false;
				this.timerHeartBeat.Enabled = false;
				this.timerCallLoginForm.Enabled = false;
				this.timerGetOrderInfo.Enabled = false;
				this._isRunPeekQ = false;
				if (!string.IsNullOrEmpty(ApplicationInfo.UserSessionID))
				{
					for (int i = 1; i <= 5; i++)
					{
						string text = string.Empty;
						string text2 = string.Empty;
						foreach (string current in ApplicationInfo.FavStockList[i])
						{
							text = text + ";" + current;
						}
						if (text.Length > 0)
						{
							text = text.Substring(1);
							if (!ApplicationInfo.IsSupportTfex)
							{
								text2 = ApplicationInfo.WebMainService.SaveUserConfig(ApplicationInfo.UserLoginID, "FAV" + i, text);
							}
							else
							{
								text2 = ApplicationInfo.WebMainService.SaveUserConfig(ApplicationInfo.UserLoginID, "FAV" + i + "T", text);
							}
							if (text2 != "ok")
							{
								this.ShowError("SaveFavorites", new Exception(text2));
							}
						}
					}
					string text3 = string.Empty;
					for (int j = 0; j < ApplicationInfo.TickerStockList.Count; j++)
					{
						text3 = text3 + ";" + ApplicationInfo.TickerStockList[j];
					}
					if (text3.Length > 0)
					{
						text3 = text3.Substring(1);
						string text2 = string.Empty;
						if (!ApplicationInfo.IsSupportTfex)
						{
							text2 = ApplicationInfo.WebMainService.SaveUserConfig(ApplicationInfo.UserLoginID, "TICKER_FIL", text3);
						}
						else
						{
							text2 = ApplicationInfo.WebMainService.SaveUserConfig(ApplicationInfo.UserLoginID, "TICKER_FILT", text3);
						}
						if (text2 != "ok")
						{
							this.ShowError("SaveTickerFilter", new Exception(text2));
						}
					}
					ApplicationInfo.WebMainService.SaveUserConfig(ApplicationInfo.UserLoginID, "FONT_SOFT", ApplicationInfo.IsFrontSoftStyle ? "Y" : "N");
					ApplicationInfo.WebMainService.LogoutAD(Convert.ToInt32(ApplicationInfo.UserSessionID), ApplicationInfo.UserLoginMode, ApplicationInfo.UserLoginID, ApplicationInfo.GetSession());
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LogOut", ex);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00031A08 File Offset: 0x0002FE08
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLogout_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.IsAreadyLogin = false;
				AlertManager.Instance.IsMonitoring = false;
				if (this.feedsWebProxy != null)
				{
					this.feedsWebProxy.Stop();
					this.feedsWebProxy.OnDataIN -= new FeedsWebProxy.OnDataInHandler(this.feedsWebProxy_OnDataIN);
					this.feedsWebProxy.OnError -= new FeedsWebProxy.OnErrorHandler(this.feedsWebProxy_OnError);
					this.feedsWebProxy.OnGettingHttp -= new EventHandler(this.feedsWebProxy_OnGettingHttp);
					this.feedsWebProxy.OnGettedHttp -= new EventHandler(this.feedsWebProxy_OnGettedHttp);
					this.feedsWebProxy.OnStoped -= new EventHandler(this.feedsWebProxy_OnStoped);
					this.feedsWebProxy.OnStarted -= new EventHandler(this.feedsWebProxy_OnStarted);
					this.feedsWebProxy = null;
				}
				this.stopBC();
				if (this._qMessage != null)
				{
					this._qMessage.Clear();
					this._qMessage = null;
				}
				SystemEvents.PowerModeChanged -= new PowerModeChangedEventHandler(this.SystemEvents_PowerModeChanged);
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.SendOrderBox.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.SendOrderBox.ReceiveTfexMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.ViewOrderBox.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.ViewOrderBox.ReceiveTfexMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.BroadcastMessageBox.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.BroadcastMessageBox.ReceiveTfexMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.TickerSlideBox.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(this.TickerSlideBox.ReceiveTfexMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(this.Smart1ClickBox.ReceiveMessage));
				frmMain._OnMessageReceived = (frmMain.OnMessageRecievedEventHendler)Delegate.Remove(frmMain._OnMessageReceived, new frmMain.OnMessageRecievedEventHendler(AlertManager.Instance.ReceiveMessage));
				frmMain._OnMessageTfexReceived = (frmMain.OnMessageTfexRecievedEventHendler)Delegate.Remove(frmMain._OnMessageTfexReceived, new frmMain.OnMessageTfexRecievedEventHendler(AlertManager.Instance.ReceiveTfexMessage));
				try
				{
					AlertManager.Instance.OnAlert -= new AlertManager.OnAlertHandler(this.OnAlert);
					AlertManager.Instance.SaveXML();
				}
				catch (Exception ex)
				{
					EventLog.WriteEntry("i2TradePlus", "SaveAlert::" + ex.Message, EventLogEntryType.Error);
				}
				if (this._alertDetailForm != null)
				{
					if (!this._alertDetailForm.IsDisposed)
					{
						this._alertDetailForm.Dispose();
					}
					this._alertDetailForm = null;
				}
				if (this._systemOptionForm != null)
				{
					if (!this._systemOptionForm.IsDisposed)
					{
						this._systemOptionForm.Dispose();
					}
					this._systemOptionForm = null;
				}
				this.ClearAllTemplate();
				this.SetTopPanelActive(false);
				this.SaveAppInfo();
				if (base.WindowState == FormWindowState.Maximized)
				{
					Settings.Default.Default_WindowMaximizeState = true;
					Settings.Default.Default_Bound = base.Bounds;
				}
				else if (base.WindowState != FormWindowState.Minimized)
				{
					Settings.Default.Default_WindowMaximizeState = false;
					Settings.Default.Default_Bound = base.Bounds;
				}
				Settings.Default.Default_MainScreenHeight = this._BTop;
				Settings.Default.Save();
				if (this.ViewOrderBox != null)
				{
					this.ViewOrderBox.DisposeMe();
				}
				this.SendOrderBox.DisposeMe();
				this.panelMenu.Hide();
				this.panelDockR.Hide();
				this.panBottom.Hide();
				this.CloseSpashForm();
				ExceptionManager.Close();
				if (this._isForceLogout)
				{
					this._isForceLogout = false;
					if (this._isExpire)
					{
						MessageBox.Show("Your session has expired.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						MessageBox.Show("Another sign with the same user!.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				if (ApplicationInfo.StockAutoComp != null)
				{
					ApplicationInfo.StockAutoComp.Clear();
					ApplicationInfo.StockAutoComp = null;
				}
				if (ApplicationInfo.StockInfo != null)
				{
					ApplicationInfo.StockInfo.Items.Clear();
					ApplicationInfo.StockInfo = null;
				}
				if (ApplicationInfo.IndexStatInfo != null)
				{
					ApplicationInfo.IndexStatInfo.Items.Clear();
					ApplicationInfo.IndexStatInfo = null;
				}
				if (ApplicationInfo.TunnelHosts != null)
				{
					ApplicationInfo.TunnelHosts.Clear();
					ApplicationInfo.TunnelHosts = null;
				}
				if (ApplicationInfo.AccInfo != null)
				{
					ApplicationInfo.AccInfo.Items.Clear();
				}
				if (ApplicationInfo.FavStockList != null)
				{
					ApplicationInfo.FavStockList.Clear();
					ApplicationInfo.FavStockList = null;
				}
				base.Close();
			}
			catch (Exception ex2)
			{
				EventLog.WriteEntry("i2Trade", ex2.Message, EventLogEntryType.Error);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00032008 File Offset: 0x00030408
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisplayMessageBox(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new frmMain.DisplayMessageBoxCallBack(this.DisplayMessageBox), new object[]
				{
					message
				});
			}
			else
			{
				MessageBox.Show(message, "");
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00032068 File Offset: 0x00030468
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenTemplate(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.OpenTemplate(templateName, "");
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00032088 File Offset: 0x00030488
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenTemplate(string templateName, string subPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._IsOpeningTemplate)
				{
					if (!(this._OpenTemplateLastTime.AddMilliseconds(100.0) >= DateTime.Now))
					{
						if (TemplateManager.Instance.CurrentActiveTemplateView != null)
						{
							this._lastTemplate = TemplateManager.Instance.CurrentActiveTemplateView.Name;
						}
						if (this.ViewOrderBox != null)
						{
							this.ViewOrderBox.CloseViewOrderInfoBox();
						}
						this._OpenTemplateLastTime = DateTime.Now;
						this._IsOpeningTemplate = true;
						if (TemplateManager.Instance.IsTemplateContains(templateName))
						{
							TemplateManager.Instance.Show(templateName);
							this.SetMenu(templateName);
							this._IsOpeningTemplate = false;
						}
						else
						{
							string text = string.Empty;
							bool flag = false;
							text = ApplicationInfo.GetTemplatePathByUser();
							if (text != string.Empty)
							{
								text = text + "\\" + templateName + ".xml";
								if (File.Exists(text))
								{
									flag = true;
								}
							}
							TemplateView templateView = templateView = TemplateManager.Instance.CreateTemplateView(templateName);
							templateView.CurrentState = TemplateView.ContentState.OpeningOrClosing;
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							if (flag)
							{
								TemplateDS templateDS = new TemplateDS();
								templateDS.ReadXml(text);
								TemplateDS.FormRememberFieldRow[] array = (TemplateDS.FormRememberFieldRow[])templateDS.FormRememberField.Select();
								TemplateDS.FormRememberFieldRow[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									TemplateDS.FormRememberFieldRow formRememberFieldRow = array2[i];
									dictionary.Add(formRememberFieldRow.FieldName, formRememberFieldRow.FieldValue);
								}
							}
							List<MainFixedTemplate.ControlClient> list = MainFixedTemplate.GetFixedTemplate(templateName);
							foreach (MainFixedTemplate.ControlClient current in list)
							{
								if (dictionary.Count == 0)
								{
									dictionary = current.Property;
								}
								Form form;
								if (subPage == string.Empty)
								{
									form = (Form)Activator.CreateInstance(current.ControlType, new object[]
									{
										dictionary
									});
								}
								else
								{
									form = (Form)Activator.CreateInstance(current.ControlType, new object[]
									{
										dictionary,
										subPage
									});
								}
								Form expr_271 = form;
								expr_271.Name += form.GetHashCode().ToString();
								form.FormBorderStyle = FormBorderStyle.None;
								form.TopLevel = false;
								form.Parent = this;
								this.SetEventToNewForm(form);
								TemplateManager.Instance.AddFormToTemplate(templateName, form, current.FormIndex);
								Thread.Sleep(10);
							}
							list.Clear();
							list = null;
							dictionary.Clear();
							dictionary = null;
							TemplateManager.Instance.Show(templateName);
							this.SetMenu(templateName);
							templateView.CurrentState = TemplateView.ContentState.Unchanged;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("OpenTemplate", ex);
			}
			finally
			{
				this._IsOpeningTemplate = false;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0003243C File Offset: 0x0003083C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaveTemplate()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.SaveTemplate));
			}
			else
			{
				try
				{
					string text = string.Empty;
					string text2 = string.Empty;
					string name = TemplateManager.Instance.CurrentActiveTemplateView.Name;
					TemplateView.ContentState templateState = TemplateManager.Instance.GetTemplateState(TemplateManager.Instance.CurrentActiveTemplateView.Name);
					text = TemplateManager.Instance.CurrentActiveTemplateView.Name;
					text2 = ApplicationInfo.GetTemplatePathByUser();
					if (!string.IsNullOrEmpty(text))
					{
						Form activeMdiChild = base.ActiveMdiChild;
						string str = text + ".xml";
						TemplateDS templateDS = new TemplateDS();
						Dictionary<string, object> templateProperties = TemplateManager.Instance.GetTemplateProperties(text);
						if (templateProperties != null)
						{
							TemplateDS.TemplatePropertyRow templatePropertyRow = templateDS.TemplateProperty.NewTemplatePropertyRow();
							templatePropertyRow.PropertyName = "Name";
							templatePropertyRow.PropertyValue = text;
							templateDS.TemplateProperty.AddTemplatePropertyRow(templatePropertyRow);
							foreach (KeyValuePair<string, object> current in templateProperties)
							{
								if (current.Key != "Name")
								{
									templatePropertyRow = templateDS.TemplateProperty.NewTemplatePropertyRow();
									templatePropertyRow.PropertyName = current.Key;
									templatePropertyRow.PropertyValue = current.Value.ToString();
									templateDS.TemplateProperty.AddTemplatePropertyRow(templatePropertyRow);
								}
							}
							List<Dictionary<string, object>> allFormProperties = TemplateManager.Instance.GetAllFormProperties(text);
							if (allFormProperties != null && allFormProperties.Count > 0)
							{
								int num = 0;
								foreach (Dictionary<string, object> current2 in allFormProperties)
								{
									num++;
									if (current2 != null)
									{
										TemplateDS.FormInfoRow formInfoRow = templateDS.FormInfo.NewFormInfoRow();
										formInfoRow.FormID = num;
										foreach (KeyValuePair<string, object> current3 in current2)
										{
											if (current3.Key == "Type")
											{
												formInfoRow.Type = current3.Value.ToString();
											}
											else if (current3.Key == "Name")
											{
												formInfoRow.Name = current3.Value.ToString();
											}
											else
											{
												TemplateDS.FormPropertyRow formPropertyRow = templateDS.FormProperty.NewFormPropertyRow();
												formPropertyRow.FormID = num;
												formPropertyRow.PropertyName = current3.Key;
												if (current3.Key == "Font")
												{
													Font font = (Font)current3.Value;
													formPropertyRow.PropertyValue = string.Format("{0}|{1}|{2}", font.Name, font.Size, (int)font.Style);
												}
												else
												{
													formPropertyRow.PropertyValue = current3.Value.ToString();
												}
												templateDS.FormProperty.AddFormPropertyRow(formPropertyRow);
											}
										}
										templateDS.FormInfo.AddFormInfoRow(formInfoRow);
										if (current2.ContainsKey("Name"))
										{
											Dictionary<string, object> formPropertyFields = TemplateManager.Instance.GetFormPropertyFields(text, current2["Name"].ToString());
											if (formPropertyFields != null)
											{
												foreach (KeyValuePair<string, object> current4 in formPropertyFields)
												{
													TemplateDS.FormRememberFieldRow formRememberFieldRow = templateDS.FormRememberField.NewFormRememberFieldRow();
													formRememberFieldRow.FormID = num;
													formRememberFieldRow.FieldName = current4.Key;
													formRememberFieldRow.FieldValue = current4.Value.ToString();
													templateDS.FormRememberField.AddFormRememberFieldRow(formRememberFieldRow);
												}
											}
										}
									}
								}
								try
								{
									if (!Directory.Exists(text2))
									{
										Directory.CreateDirectory(text2);
									}
									templateDS.WriteXml(text2 + "\\" + str);
								}
								catch (Exception ex)
								{
									this.ShowError("SaveTemplate", ex);
									return;
								}
							}
						}
					}
					text = null;
					text2 = null;
				}
				catch (Exception ex)
				{
					this.ShowError("SaveTemplate", ex);
				}
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000329CC File Offset: 0x00030DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void templateMenu_OnOpenTemplate(string templateName, string templateGroup)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (templateName != null)
			{
				if (templateName == "Buy Order" || templateName == "Sell Order" || templateName == "Short Sell Order" || templateName == "Cover Buy Order")
				{
					this.OpenSendNewOrderForm(templateName);
					return;
				}
			}
			this.OpenTemplate(templateName);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00032A50 File Offset: 0x00030E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00032A84 File Offset: 0x00030E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerHeartBeat_Elapsed(object sender, ElapsedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.timerHeartBeat.Stop();
			try
			{
				if (ApplicationInfo.IsAreadyLogin && this._powerMode != PowerModes.Suspend)
				{
					if (!this._isCheckHBworking)
					{
						string text = string.Empty;
						if (ApplicationInfo.IsPushMode)
						{
							this.param = "1";
							text = ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].HostIP + ":" + ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].Port;
						}
						else
						{
							this.param = "0";
						}
						ApplicationInfo.WebMainService.SendHeartBeat2Completed -= new SendHeartBeat2CompletedEventHandler(this.WebUserService_SendHeartBeat2Completed);
						ApplicationInfo.WebMainService.SendHeartBeat2Completed += new SendHeartBeat2CompletedEventHandler(this.WebUserService_SendHeartBeat2Completed);
						this._isCheckHBworking = true;
						ApplicationInfo.WebMainService.SendHeartBeat2Async(string.Concat(new string[]
						{
							"user_id=",
							ApplicationInfo.UserLoginID,
							"|session=",
							ApplicationInfo.UserSessionID,
							"|web_ip=",
							new Uri(ApplicationInfo.WebService.Url).Host,
							"|conn_mode=",
							this.param,
							"|tunnel_info=",
							text
						}));
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("HeartBeat", ex);
			}
			if (ApplicationInfo.IsAreadyLogin)
			{
				if (!this._isForceLogout)
				{
					this.timerHeartBeat.Start();
				}
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00032C58 File Offset: 0x00031058
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebUserService_SendHeartBeat2Completed(object sender, SendHeartBeat2CompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.WebMainService.SendHeartBeat2Completed -= new SendHeartBeat2CompletedEventHandler(this.WebUserService_SendHeartBeat2Completed);
				if (e.Error == null)
				{
					if (e.Result.ToString() == "kick")
					{
						this._isForceLogout = true;
						this.Logout(true);
					}
					else if (e.Result.ToString() == "expire")
					{
						this._isExpire = true;
						this._isForceLogout = true;
						this.Logout(true);
					}
					else if (e.Result.ToString() != "ok")
					{
						this.ShowError("HeartBeat", new Exception(e.Result.ToString()));
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("HeartBeatCallBack", ex);
			}
			this._isCheckHBworking = false;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00032D84 File Offset: 0x00031184
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExcuteFile(string fileName, string param)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				new Process
				{
					StartInfo = 
					{
						FileName = fileName,
						Arguments = param,
						UseShellExecute = true,
						RedirectStandardOutput = false
					}
				}.Start();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00032E00 File Offset: 0x00031200
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00032ED0 File Offset: 0x000312D0
		private int _BTop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				int num = base.ClientSize.Height - this.SendOrderBox.Height - 2;
				if (this._bTop > num)
				{
					this._bTop = num;
				}
				else if (this._bTop <= 0)
				{
					this._bTop = (int)((double)base.Height * 0.75);
				}
				else if ((double)this._bTop < (double)base.Height * 0.6)
				{
					this._bTop = (int)((double)base.Height * 0.6);
				}
				return this._bTop;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._bTop = value;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00032EE8 File Offset: 0x000312E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Instance_SetBottomSize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.WindowState != FormWindowState.Minimized)
			{
				if (this.tmBottomClientResize == null)
				{
					this.tmBottomClientResize = new System.Windows.Forms.Timer();
					this.tmBottomClientResize.Interval = 50;
					this.tmBottomClientResize.Tick -= new EventHandler(this.tmBottomClientResize_Tick);
					this.tmBottomClientResize.Tick += new EventHandler(this.tmBottomClientResize_Tick);
				}
				this.tmBottomClientResize.Enabled = false;
				this.tmBottomClientResize.Enabled = true;
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00032F90 File Offset: 0x00031390
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Resize_DockR()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			int num = (int)((double)base.ClientSize.Width * 0.26);
			this.panelControlDockR.Width = num;
			this.panelDockR.SuspendLayout();
			Rectangle workingArea = this.GetWorkingArea();
			this.panelDockR.SetBounds(base.ClientSize.Width - num, workingArea.Top, num, this._BTop - workingArea.Top);
			if (!this.panelDockR.Visible)
			{
				this.panelDockR.Visible = true;
			}
			if (this._slideType == 1)
			{
				this.TickerSlideBox.SetBounds(0, 0, this.panelDockR.Width, this.panelDockR.Height);
				if (!this.TickerSlideBox.IsInit)
				{
					this.TickerSlideBox.Init();
					this.TickerSlideBox.SetResize();
				}
				else
				{
					this.TickerSlideBox.SetResize();
				}
				this.TickerSlideBox.Visible = true;
			}
			else if (this._slideType == 2)
			{
				this.Smart1ClickBox.SetBounds(0, 0, this.panelDockR.Width, this.panelDockR.Height);
				this.Smart1ClickBox.SetResize();
				this.Smart1ClickBox.Visible = true;
			}
			if (this._slideType != 1)
			{
				this.TickerSlideBox.Visible = false;
			}
			if (this._slideType != 2)
			{
				this.Smart1ClickBox.Visible = false;
			}
			this.panelDockR.ResumeLayout();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0003315C File Offset: 0x0003155C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Resize_SendOrderBox()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SendOrderBox.SuspendLayout();
			this.SendOrderBox.SetBounds(3, 3, base.ClientSize.Width - 6, this.SendOrderBox.Height);
			this.SendOrderBox.SetResize();
			this.SendOrderBox.ResumeLayout();
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000331C8 File Offset: 0x000315C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Resize_BottomBox()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.panelSep.SetBounds(base.ClientRectangle.Left, this._BTop, base.ClientRectangle.Width, 2);
			this.panBottom.SetBounds(0, this._BTop + this.panelSep.Height, base.ClientSize.Width, base.ClientSize.Height - this._BTop - 2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00033258 File Offset: 0x00031658
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmBottomClientResize_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tmBottomClientResize != null)
				{
					this.tmBottomClientResize.Enabled = false;
				}
				this.panBottom.SuspendLayout();
				this.Resize_SendOrderBox();
				this.Resize_BottomBox();
				this.Resize_ViewOrderBox_BcBox();
				this.panBottom.ResumeLayout(false);
				this.Resize_DockR();
				this.setTopPos();
				if (TemplateManager.Instance.CurrentActiveTemplateView != null)
				{
					TemplateManager.Instance.CurrentActiveTemplateView.SetFormSize();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tmBottomClientResize_Tick", ex);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00033320 File Offset: 0x00031720
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnResizeMD_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._isResizeMDNext)
			{
				if (Settings.Default.BottomSizePct == 0.6m)
				{
					Settings.Default.BottomSizePct = 1m;
				}
				else
				{
					Settings.Default.BottomSizePct += 0.1m;
				}
			}
			else if (Settings.Default.BottomSizePct >= 1m)
			{
				Settings.Default.BottomSizePct = 0.6m;
			}
			else
			{
				Settings.Default.BottomSizePct -= 0.1m;
			}
			this.Resize_ViewOrderBox_BcBox();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00033410 File Offset: 0x00031810
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Resize_ViewOrderBox_BcBox()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.ViewOrderBox.SetBounds(this.SendOrderBox.Left, this.SendOrderBox.Bottom + 3, Convert.ToInt32((this.SendOrderBox.Width - this.btnResizeMD1.Width - 2) * Settings.Default.BottomSizePct), this.panBottom.Height - this.SendOrderBox.Height - 10);
				this.ViewOrderBox.SetResize(true);
				if (Settings.Default.BottomSizePct <= 0.5m)
				{
					this.btnResizeMD1.Image = Resources.MoveNextHS;
					this._isResizeMDNext = true;
				}
				else if (Settings.Default.BottomSizePct >= 1m)
				{
					this.btnResizeMD1.Image = Resources.MovePreviousHS;
					this._isResizeMDNext = false;
				}
				this.btnResizeMD1.SetBounds(this.ViewOrderBox.Right + 2, this.ViewOrderBox.Top, 14, this.ViewOrderBox.Height);
				this.BroadcastMessageBox.SetBounds(this.btnResizeMD1.Right + 2, this.ViewOrderBox.Top, this.panBottom.Width - (this.btnResizeMD1.Right + 5), this.ViewOrderBox.Height);
				this.BroadcastMessageBox.SetResize();
			}
			catch (Exception ex)
			{
				this.panBottom.ResumeLayout();
				this.ShowError("ShowControlInBottomBox", ex);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000335F0 File Offset: 0x000319F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerGetOrderInfo_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.AutoGetOrderNoList.Count > 0)
				{
					this.timerGetOrderInfo.Enabled = false;
					string text = string.Empty;
					List<string> list = new List<string>();
					foreach (KeyValuePair<string, DateTime> current in ApplicationInfo.AutoGetOrderNoList)
					{
						if (current.Value.AddSeconds((double)ApplicationInfo.AutoGetOrderInfoInterval) < DateTime.Now)
						{
							text = text + "," + current.Key;
							list.Add(current.Key);
						}
					}
					foreach (string current2 in list)
					{
						ApplicationInfo.RemoveOrderNoFromAutoRefreshList(current2, "");
					}
					list.Clear();
					list = null;
					if (text.Length > 0)
					{
						text = text.Substring(1);
					}
					if (!string.IsNullOrEmpty(text))
					{
						string text2 = ApplicationInfo.WebOrderService.ViewOrderByOrderNo(ApplicationInfo.AccInfo.CurrentAccount, text);
						if (!string.IsNullOrEmpty(text2))
						{
							using (DataSet dataSet = new DataSet())
							{
								MyDataHelper.StringToDataSet(text2, dataSet);
								if (dataSet.Tables.Contains("ORDERS"))
								{
									long volume = 0L;
									long matchedVolume = 0L;
									long num = 0L;
									long orderNumber = 0L;
									string text3 = string.Empty;
									decimal priceForCal = 0m;
									decimal matcedValue = 0m;
									string approverId = string.Empty;
									string orderDate = string.Empty;
									string orderTime = string.Empty;
									foreach (DataRow dataRow in dataSet.Tables["ORDERS"].Rows)
									{
										long.TryParse(dataRow["order_number"].ToString(), out orderNumber);
										long.TryParse(dataRow["volume"].ToString(), out volume);
										long.TryParse(dataRow["matched_volume"].ToString(), out matchedVolume);
										long.TryParse(dataRow["pub_vol"].ToString(), out num);
										text3 = Utilities.PriceFormat(dataRow["price_to_set"].ToString());
										decimal.TryParse(dataRow["price"].ToString(), out priceForCal);
										decimal.TryParse(dataRow["matched_value"].ToString(), out matcedValue);
										orderTime = Utilities.GetTime(dataRow["order_time"].ToString());
										if (dataRow.Table.Columns.Contains("bitApproval"))
										{
											if (dataRow["bitApproval"].ToString().Trim() == "1" || dataRow["bitApproval"].ToString().Trim().ToUpper() == "TRUE")
											{
												approverId = "APP";
											}
											else
											{
												approverId = string.Empty;
											}
										}
										if (dataRow.Table.Columns.Contains("sSendDate"))
										{
											orderDate = dataRow["sSendDate"].ToString();
										}
										string str = string.Empty;
										if (ApplicationInfo.SupportFreewill && dataSet.Tables.Contains("TABREF"))
										{
											DataRow[] array = dataSet.Tables["TABREF"].Select("iFisOrdNo=" + dataRow["order_number"].ToString());
											if (array.Length > 0)
											{
												str = array[0]["iRefOrdNo"].ToString();
											}
										}
										string message = new OrderInfoClient().Pack("", "", "R" + str, orderNumber, dataRow["side"].ToString(), dataRow["stock"].ToString(), volume, text3, priceForCal, matchedVolume, matcedValue, num, ApplicationInfo.AccInfo.CurrentAccount, dataRow["trustee_id"].ToString(), "", dataRow["status"].ToString(), dataRow["quote"].ToString(), orderTime, "", 0m, "1I", 0L, "", approverId, orderDate);
										IBroadcastMessage message2 = this._bcMessageFactory.CreateSETMessage(message);
										if (frmMain._OnMessageReceived != null)
										{
											frmMain._OnMessageReceived(message2, null);
										}
									}
								}
								if (ApplicationInfo.SupportFreewill)
								{
									if (dataSet.Tables.Contains("FAIL_ORD") && dataSet.Tables["FAIL_ORD"].Rows.Count > 0)
									{
										foreach (DataRow dataRow in dataSet.Tables["FAIL_ORD"].Rows)
										{
											string[] array2 = dataRow["item"].ToString().Split(new char[]
											{
												'#'
											});
											string message = new BroadCastOrderMessageClient().Pack(array2[5], "", "", "RF", "", string.Concat(new string[]
											{
												"Sending command fails, ",
												Utilities.GetOrderSideName(array2[1]),
												" ",
												array2[2],
												" at ",
												array2[4],
												"@ vol ",
												array2[3],
												", Account ",
												array2[5]
											}));
											IBroadcastMessage message2 = this._bcMessageFactory.CreateSETMessage(message);
											if (frmMain._OnMessageReceived != null)
											{
												frmMain._OnMessageReceived(message2, null);
											}
										}
									}
									if (dataSet.Tables.Contains("OFFLINE") && dataSet.Tables["OFFLINE"].Rows.Count > 0)
									{
										string text3 = string.Empty;
										string orderTime = string.Empty;
										string orderDate = string.Empty;
										decimal priceForCal = 0m;
										foreach (DataRow dataRow in dataSet.Tables["OFFLINE"].Rows)
										{
											long orderNumber;
											long.TryParse(dataRow["orderno"].ToString(), out orderNumber);
											long volume;
											long.TryParse(dataRow["volume"].ToString(), out volume);
											long num;
											long.TryParse(dataRow["pubvolume"].ToString(), out num);
											string text4 = dataRow["conditionprice"].ToString().Trim();
											if (text4 == null)
											{
												goto IL_88F;
											}
											if (!(text4 == "A"))
											{
												if (!(text4 == "C"))
												{
													if (!(text4 == "M"))
													{
														if (!(text4 == "K"))
														{
															if (!(text4 == "L"))
															{
																goto IL_88F;
															}
															text3 = "ML";
														}
														else
														{
															text3 = "MO";
														}
													}
													else
													{
														text3 = "MP";
													}
												}
												else
												{
													text3 = "ATC";
												}
											}
											else
											{
												text3 = "ATO";
											}
											IL_8CA:
											orderTime = Utilities.GetTime(dataRow["ordertime"].ToString());
											orderDate = dataRow["orderdate"].ToString();
											string message = new OrderInfoClient().Pack("", "", "OFFLINE", orderNumber, dataRow["side"].ToString(), dataRow["secsymbol"].ToString(), volume, text3, priceForCal, 0L, 0m, num, ApplicationInfo.AccInfo.CurrentAccount, dataRow["trusteeid"].ToString(), "", dataRow["orderstatus"].ToString(), "", orderTime, "", 0m, "1I", 0L, "", "", orderDate);
											IBroadcastMessage message2 = this._bcMessageFactory.CreateSETMessage(message);
											if (frmMain._OnMessageReceived != null)
											{
												frmMain._OnMessageReceived(message2, null);
											}
											continue;
											IL_88F:
											text3 = Utilities.PriceFormat(dataRow["price"].ToString().Trim());
											decimal.TryParse(dataRow["price"].ToString(), out priceForCal);
											goto IL_8CA;
										}
									}
								}
								dataSet.Clear();
							}
						}
					}
					text = null;
				}
				if (ApplicationInfo.AutoGetOrderNoList_TFEX.Count > 0)
				{
					string text = string.Empty;
					foreach (KeyValuePair<string, DateTime> current in ApplicationInfo.AutoGetOrderNoList_TFEX)
					{
						if (current.Value.AddSeconds((double)ApplicationInfo.AutoGetOrderInfoInterval) < DateTime.Now)
						{
							text = text + "," + current.Key;
						}
					}
					if (text.Length > 0)
					{
						text = text.Substring(1);
					}
					if (!string.IsNullOrEmpty(text))
					{
						string text2 = ApplicationInfo.WebServiceTFEX.ViewOrderByOrderNo(ApplicationInfo.AccInfo.CurrentAccount, text);
						if (!string.IsNullOrEmpty(text2))
						{
							using (DataSet dataSet = new DataSet())
							{
								MyDataHelper.StringToDataSet(text2, dataSet);
								if (dataSet.Tables.Contains("ORDERS"))
								{
									long volume = 0L;
									long matchedVolume = 0L;
									long num = 0L;
									long orderNumber = 0L;
									string text3 = string.Empty;
									decimal priceForCal = 0m;
									string orderTime = string.Empty;
									string sendDate = string.Empty;
									for (int i = 0; i < dataSet.Tables["ORDERS"].Rows.Count; i++)
									{
										DataRow dataRow = dataSet.Tables["ORDERS"].Rows[i];
										long.TryParse(dataRow["order_number"].ToString(), out orderNumber);
										long.TryParse(dataRow["volume"].ToString(), out volume);
										long.TryParse(dataRow["matched_volume"].ToString(), out matchedVolume);
										long.TryParse(dataRow["pub_vol"].ToString(), out num);
										text3 = Utilities.PriceFormat(dataRow["price_to_set"].ToString());
										decimal.TryParse(dataRow["price"].ToString(), out priceForCal);
										orderTime = Utilities.GetTime(dataRow["order_time"].ToString());
										sendDate = dataRow["sSendDate"].ToString();
										string message = new OrderTFEXInfoClient().Pack("", ApplicationInfo.AccInfo.CurrentAccount, orderNumber.ToString(), dataRow["position"].ToString(), dataRow["side"].ToString(), dataRow["series"].ToString().Trim(), volume, text3, matchedVolume, num, dataRow["status"].ToString().Trim(), orderTime, dataRow["quote"].ToString().Trim(), sendDate, dataRow["sOrdType"].ToString(), 0L, "", "");
										IBroadcastMessage message2 = this._bcMessageFactory.CreateTfexMessage(message);
										if (frmMain._OnMessageTfexReceived != null)
										{
											frmMain._OnMessageTfexReceived(message2, null);
										}
										ApplicationInfo.RemoveOrderNoFromAutoRefreshList_TFEX(orderNumber.ToString());
									}
								}
								dataSet.Clear();
							}
						}
					}
					text = null;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("timerGetOrderInfo_Tick", ex);
			}
			this.timerGetOrderInfo.Enabled = true;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000344B8 File Offset: 0x000328B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnLogout_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Logout(false);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000344D4 File Offset: 0x000328D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenSystemOptionForm()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.OpenSystemOptionForm));
			}
			else
			{
				try
				{
					if (this._systemOptionForm == null || this._systemOptionForm.IsDisposed)
					{
						this._systemOptionForm = new frmSystemOption();
					}
					this._systemOptionForm.TopLevel = false;
					this._systemOptionForm.Parent = this;
					if (base.Left < 0)
					{
						this._systemOptionForm.Left = base.Left + (base.Width - this._systemOptionForm.Width) / 2;
					}
					else
					{
						this._systemOptionForm.Left = (base.Width - this._systemOptionForm.Width) / 2;
					}
					if (base.Top < 0)
					{
						this._systemOptionForm.Top = base.Top + (base.Height - this._systemOptionForm.Height) / 2;
					}
					else
					{
						this._systemOptionForm.Top = (base.Height - this._systemOptionForm.Height) / 2;
					}
					this._systemOptionForm.Show();
					this._systemOptionForm.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("OpenSystemOptionForm", ex);
				}
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00034678 File Offset: 0x00032A78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tslbLogo_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.ExcuteFile("C:\\Program Files\\Internet Explorer\\iexplore.exe", "www.i2TradePlus.com");
			}
			catch (Exception ex)
			{
				this.ShowError("Open www.i2TradePlus.com Website", ex);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000346D4 File Offset: 0x00032AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool LoadAllInformation()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			try
			{
				if (!ApplicationInfo.IsLoadInformation)
				{
					this.ShowSpashForm("Loading Information ...");
					ApplicationInfo.IndexStatInfo.ResetData();
					string data = ApplicationInfo.WebService.LoadAllInformation();
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(data, dataSet);
						if (dataSet != null)
						{
							this.LoadStockInfomation(dataSet);
							this.LoadIndustrialInfomation(dataSet);
							this.LoadSectorInfomation(dataSet);
							this.LoadMarketInformation(dataSet);
							this.LoadDWInformation(dataSet);
							dataSet.Clear();
						}
					}
					if (ApplicationInfo.AutoTradeType > 0)
					{
						ApplicationInfo.IsAutoTradeAccepted = (ApplicationInfo.WebAlertService.StopOrderCheckDisclaimer(ApplicationInfo.UserLoginID) == ApplicationInfo.UserLoginID);
					}
					data = string.Empty;
					if (ApplicationInfo.IsSupportTfex)
					{
						this.SectorBox.DisplayType = 3;
						this.ShowSpashForm("Loading TFEX Information ...");
						try
						{
							this.LoadTFEXInfomation();
							this.LoadTFEXMarketstate();
						}
						catch (Exception ex)
						{
							this.DisplayMessageBox("Load TFEX Information Error!!!\r\n" + ex.Message);
						}
						if (ApplicationInfo.MultiAutoComp == null)
						{
							ApplicationInfo.MultiAutoComp = new AutoCompleteStringCollection();
						}
						else
						{
							ApplicationInfo.MultiAutoComp.Clear();
						}
						if (ApplicationInfo.StockAutoComp == null)
						{
							ApplicationInfo.StockAutoComp = new AutoCompleteStringCollection();
						}
						else
						{
							ApplicationInfo.StockAutoComp.Clear();
						}
						if (ApplicationInfo.SeriesAutoComp == null)
						{
							ApplicationInfo.SeriesAutoComp = new AutoCompleteStringCollection();
						}
						else
						{
							ApplicationInfo.SeriesAutoComp.Clear();
						}
						foreach (KeyValuePair<int, StockList.StockInformation> current in ApplicationInfo.StockInfo.Items)
						{
							if (!current.Value.IsOddLot)
							{
								ApplicationInfo.MultiAutoComp.Add(current.Value.Symbol);
								ApplicationInfo.StockAutoComp.Add(current.Value.Symbol);
							}
						}
						ApplicationInfo.StockAutoCompStringArr.Initialize();
						foreach (KeyValuePair<int, SeriesList.SeriesInformation> current2 in ApplicationInfo.SeriesInfo.Items)
						{
							if (current2.Value.Group != 5)
							{
								ApplicationInfo.MultiAutoComp.Add(current2.Value.Symbol);
								ApplicationInfo.SeriesAutoComp.Add(current2.Value.Symbol);
							}
						}
					}
					else
					{
						this.SectorBox.DisplayType = 2;
						if (ApplicationInfo.StockAutoComp == null)
						{
							ApplicationInfo.StockAutoComp = new AutoCompleteStringCollection();
						}
						else
						{
							ApplicationInfo.StockAutoComp.Clear();
						}
						foreach (KeyValuePair<int, StockList.StockInformation> current in ApplicationInfo.StockInfo.Items)
						{
							if (!current.Value.IsOddLot)
							{
								ApplicationInfo.StockAutoComp.Add(current.Value.Symbol);
							}
						}
						ApplicationInfo.StockAutoCompStringArr.Initialize();
					}
					string text = string.Empty;
					text = ApplicationInfo.WebService.GetTunnel(ApplicationInfo.IsSupportTfex);
					if (text != string.Empty)
					{
						string[] array = text.Trim().Split(new char[]
						{
							'|'
						});
						int num;
						int.TryParse(array[1], out num);
						string[] array2 = array[0].Trim().Split(new char[]
						{
							';'
						});
						if (ApplicationInfo.TunnelHosts == null)
						{
							ApplicationInfo.TunnelHosts = new List<TunnelInfo>();
						}
						else
						{
							ApplicationInfo.TunnelHosts.Clear();
						}
						string[] array3 = array2;
						for (int i = 0; i < array3.Length; i++)
						{
							string text2 = array3[i];
							if (!string.IsNullOrEmpty(text2))
							{
								string[] array4 = text2.Trim().Split(new char[]
								{
									':'
								});
								TunnelInfo tunnelInfo = new TunnelInfo();
								tunnelInfo.HostIP = array4[0].Trim();
								tunnelInfo.Port = (string.IsNullOrEmpty(array4[1]) ? 27000 : Convert.ToInt32(array4[1].Trim()));
								tunnelInfo.EnableSSL = (array4[2].Trim().ToUpper() == "Y");
								tunnelInfo.IsAlreadyStart = false;
								ApplicationInfo.TunnelHosts.Add(tunnelInfo);
							}
						}
						int tunnelCounter = num % ApplicationInfo.TunnelHosts.Count;
						ApplicationInfo.TunnelCounter = tunnelCounter;
					}
					ApplicationInfo.UrlSyncHandler = ApplicationInfo.WebService.GetCometInfo();
					ApplicationInfo.IsLoadInformation = true;
				}
			}
			catch (Exception ex2)
			{
				this.ShowError("LoadAllInformation", ex2);
				this.DisplayMessageBox(ex2.ToString());
				result = false;
				return result;
			}
			this.ShowSpashForm("");
			result = true;
			return result;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00034D30 File Offset: 0x00033130
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadStockInfomation(DataSet dsInvestor)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (dsInvestor.Tables.Contains("StockInformation") && dsInvestor.Tables["StockInformation"].Rows.Count > 0)
				{
					ApplicationInfo.StockInfo.ResetData();
					foreach (DataRow dataRow in dsInvestor.Tables["StockInformation"].Rows)
					{
						StockList.StockInformation stockInformation = new StockList.StockInformation();
						int num;
						int.TryParse(dataRow["security_number"].ToString(), out num);
						stockInformation.Number = num;
						stockInformation.Symbol = dataRow["security_symbol"].ToString().Trim();
						decimal num2;
						decimal.TryParse(dataRow["ceiling"].ToString(), out num2);
						stockInformation.Ceiling = num2;
						decimal.TryParse(dataRow["floor"].ToString(), out num2);
						stockInformation.Floor = num2;
						decimal.TryParse(dataRow["prior_close_price"].ToString(), out num2);
						stockInformation.PriorPrice = num2;
						decimal.TryParse(dataRow["high_price"].ToString(), out num2);
						stockInformation.HighPrice = num2;
						decimal.TryParse(dataRow["low_price"].ToString(), out num2);
						stockInformation.LowPrice = num2;
						decimal.TryParse(dataRow["last_sale_price"].ToString(), out num2);
						stockInformation.LastSalePrice = num2;
						stockInformation.BidPrice1 = dataRow["bid_price1"].ToString();
						stockInformation.OfferPrice1 = dataRow["offer_price1"].ToString();
						int.TryParse(dataRow["sector_number"].ToString(), out num);
						stockInformation.SectorNumber = num;
						int.TryParse(dataRow["board_lot"].ToString(), out num);
						stockInformation.BoardLot = num;
						stockInformation.SecurityType = dataRow["security_type"].ToString();
						stockInformation.DisplayFlag = dataRow["display_flag"].ToString();
						stockInformation.MarketId = dataRow["market_id"].ToString();
						stockInformation.IsOddLot = (dataRow["sIsOdd"].ToString() == "Y");
						stockInformation.IsCheckSpread = (dataRow["check_spread"].ToString() == "Y");
						if (stockInformation.IsOddLot)
						{
							StockList.StockInformation expr_2B4 = stockInformation;
							expr_2B4.Symbol += "_ODD";
						}
						ApplicationInfo.StockInfo.AddItem(stockInformation);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0003508C File Offset: 0x0003348C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadIndustrialInfomation(DataSet dsInvestor)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (dsInvestor.Tables.Contains("IndustryInformation") && dsInvestor.Tables["IndustryInformation"].Rows.Count > 0)
				{
					foreach (DataRow dataRow in dsInvestor.Tables["IndustryInformation"].Rows)
					{
						IndexStat.IndexItem indexItem = new IndexStat.IndexItem();
						int number;
						int.TryParse(dataRow["industry_number"].ToString(), out number);
						indexItem.Number = number;
						indexItem.Symbol = dataRow["industry_symbol"].ToString().Trim();
						indexItem.Fullname = dataRow["industry_name"].ToString().Trim();
						decimal prior;
						decimal.TryParse(dataRow["index_prior"].ToString(), out prior);
						indexItem.Prior = prior;
						indexItem.Type = "I";
						ApplicationInfo.IndexStatInfo.Items.Add(indexItem);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoadIndustrialInfomation", ex);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00035248 File Offset: 0x00033648
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadSectorInfomation(DataSet dsInvestor)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (dsInvestor.Tables.Contains("SectorInformation") && dsInvestor.Tables["SectorInformation"].Rows.Count > 0)
				{
					foreach (DataRow dataRow in dsInvestor.Tables["SectorInformation"].Rows)
					{
						IndexStat.IndexItem indexItem = new IndexStat.IndexItem();
						indexItem.Symbol = dataRow["sector_symbol"].ToString().Trim();
						indexItem.Fullname = dataRow["sector_name"].ToString().Trim();
						int number;
						int.TryParse(dataRow["sector_number"].ToString(), out number);
						indexItem.Number = number;
						decimal num;
						decimal.TryParse(dataRow["index_prior"].ToString(), out num);
						indexItem.Prior = num;
						decimal.TryParse(dataRow["index_value"].ToString(), out num);
						indexItem.LastIndex = num;
						decimal.TryParse(dataRow["accvalue"].ToString(), out num);
						indexItem.AccValue = num;
						decimal.TryParse(dataRow["index_high"].ToString(), out num);
						indexItem.IndexHigh = num;
						decimal.TryParse(dataRow["index_low"].ToString(), out num);
						indexItem.IndexLow = num;
						string symbol = indexItem.Symbol;
						if (symbol == null)
						{
							goto IL_23F;
						}
                        //if (<PrivateImplementationDetails>{4F24FA85-855F-4C6D-AD81-3D9DF826580F}.$$method0x60002d9-1 == null)
                        //{
                        //    <PrivateImplementationDetails>{4F24FA85-855F-4C6D-AD81-3D9DF826580F}.$$method0x60002d9-1 = new Dictionary<string, int>(6)
                        //    {
                        //        {
                        //            ".SET",
                        //            0
                        //        },
                        //        {
                        //            ".SET50",
                        //            1
                        //        },
                        //        {
                        //            ".SET100",
                        //            2
                        //        },
                        //        {
                        //            ".sSET",
                        //            3
                        //        },
                        //        {
                        //            ".SETHD",
                        //            4
                        //        },
                        //        {
                        //            ".MAI",
                        //            5
                        //        }
                        //    };
                        //}
                        //int num2;
                        //if (!<PrivateImplementationDetails>{4F24FA85-855F-4C6D-AD81-3D9DF826580F}.$$method0x60002d9-1.TryGetValue(symbol, out num2))
                        //{
                        //    goto IL_23F;
                        //}
                        //switch (num2)
                        //{
                        //case 0:
                        //case 1:
                        //case 2:
                        //case 3:
                        //case 4:
                        //case 5:
                        //    indexItem.Type = "E";
                        //    break;
                        //default:
                        //    goto IL_23F;
                        //}
						IL_250:
						indexItem.IsMainMarket = (indexItem.Symbol.IndexOf("-ms") == -1);
						ApplicationInfo.IndexStatInfo.Items.Add(indexItem);
						continue;
						IL_23F:
						indexItem.Type = "S";
						goto IL_250;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0003554C File Offset: 0x0003394C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadMarketInformation(DataSet dsInvestor)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (dsInvestor.Tables.Contains("market_status") && dsInvestor.Tables["market_status"].Rows.Count > 0)
				{
					ApplicationInfo.MarketState = dsInvestor.Tables["market_status"].Rows[0]["market_state"].ToString();
					int marketSession;
					int.TryParse(dsInvestor.Tables["market_status"].Rows[0]["market_session"].ToString(), out marketSession);
					ApplicationInfo.MarketSession = marketSession;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoadMarketInformation", ex);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00035648 File Offset: 0x00033A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadDWInformation(DataSet dsInvestor)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (dsInvestor.Tables.Contains("DWInformation") && dsInvestor.Tables["DWInformation"].Rows.Count > 0)
				{
					foreach (DataRow dataRow in dsInvestor.Tables["DWInformation"].Rows)
					{
						if (!string.IsNullOrEmpty(dataRow["sParentStock"].ToString().Trim()))
						{
							ApplicationInfo.DWParentStockList.Add(dataRow["sParentStock"].ToString().Trim());
						}
					}
				}
				dsInvestor.Clear();
			}
			catch (Exception ex)
			{
				this.ShowError("LoadDWInformation", ex);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00035790 File Offset: 0x00033B90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void panelSep_MouseDown(object sender, MouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._isPanelSepResize = true;
				if (this._formRS == null)
				{
					this._formRS = new Form();
					this._formRS.FormBorderStyle = FormBorderStyle.None;
					this._formRS.BackColor = Color.LightSteelBlue;
					this._formRS.Opacity = 0.7;
				}
				this._screenRectangle = base.RectangleToScreen(base.ClientRectangle);
				this._formRS.SetBounds(this._screenRectangle.Left, this._screenRectangle.Top + this.panBottom.Top, this.panBottom.Width, this.panBottom.Height);
				this._formRS.Show();
				this._formRS.BringToFront();
			}
			catch (Exception ex)
			{
				this.ShowError("panelSep_MouseDown", ex);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000358A4 File Offset: 0x00033CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void panelSep_MouseMove(object sender, MouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._formRS != null)
				{
					this._formRS.SetBounds(this._screenRectangle.Left, this._screenRectangle.Top + this.panelSep.Top + e.Y, this.panBottom.Width, this.panBottom.Height - e.Y);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("panelSep_MouseMove", ex);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00035954 File Offset: 0x00033D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void panelSep_MouseUp(object sender, MouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._isPanelSepResize)
				{
					if (this._formRS != null)
					{
						this._formRS.Hide();
					}
					this._isPanelSepResize = false;
					if (e.Y != 0)
					{
						this._BTop = this.panelSep.Top + e.Y;
						this.Instance_SetBottomSize();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("panelSep_MouseUp", ex);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00035A04 File Offset: 0x00033E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnOptions_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.OpenSystemOptionForm();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00035A1C File Offset: 0x00033E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnLogout_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Logout(false);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00035A38 File Offset: 0x00033E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTopPanelActive(bool isStart)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMain.SetTopPanelActiveCallBack(this.SetTopPanelActive), new object[]
				{
					isStart
				});
			}
			else
			{
				try
				{
					this.panelTop.Visible = isStart;
					this.MarketStateBox.IsAllowBlinkAlert = isStart;
					this.MarketStateBox.IsAlertStart = true;
					if (isStart)
					{
						this.setTopPos();
						ApplicationInfo.MarketTime = DateTime.Now;
					}
					this.SETBox.Active = isStart;
					this.SET2Box.Active = isStart;
					this.SectorBox.Active = isStart;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00035B1C File Offset: 0x00033F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnShowSlide_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._slideType = Convert.ToInt32((sender as Button).Tag);
				this.btnShowTickerSlide.ForeColor = Color.LightGray;
				this.btnShowSpeedOrderSlide.ForeColor = Color.LightGray;
				(sender as Button).ForeColor = Color.Cyan;
				this.Instance_SetBottomSize();
				if (this._slideType == 1)
				{
					this.TickerSlideBox.Init();
				}
				else if (this._slideType == 2)
				{
					this.Smart1ClickBox.Init();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnShowSlide_Click", ex);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00035BFC File Offset: 0x00033FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetMenu(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				foreach (Control control in this.panelMenu.Controls)
				{
					if (control.GetType() == typeof(Button))
					{
						control.ForeColor = Color.LightGray;
					}
				}
				Button button = null;
				switch (templateName)
				{
				case "My List":
					button = this.btnMarketWatch;
					break;
				case "Bids":
				case "Market Information":
				case "Ranking":
					button = this.btnMarketInfo;
					break;
				case "Stock in Play":
				case "Sale by Price":
				case "Sale by Time":
				case "View Oddlot":
					button = this.btnSummary;
					break;
				case "View Order":
					button = this.btnViewOrder;
					break;
				case "Portfolio":
					button = this.btnPortfolio;
					break;
				case "Graph":
					button = this.btnGraph;
					break;
				case "News":
					button = this.btnNews;
					break;
				case "Finance":
					button = this.btnFinance;
					break;
				case "Batch Order":
				case "SET News":
					button = this.btnMore;
					break;
				case "AutoTrade":
					button = this.btnAutoTrade;
					break;
				}
				if (button != null)
				{
					button.ForeColor = Color.GreenYellow;
				}
				if (ApplicationInfo.IsNewPortStyle)
				{
					if (templateName.ToLower() == "portfolio")
					{
						this.panelDockR.Visible = false;
						this.btnShowTickerSlide.Visible = false;
						this.btnShowSpeedOrderSlide.Visible = false;
					}
					else
					{
						this.panelDockR.Visible = true;
						this.btnShowTickerSlide.Visible = true;
						this.btnShowSpeedOrderSlide.Visible = true;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetMenu", ex);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00035F5C File Offset: 0x0003435C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Menus_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Button button = sender as Button;
				if (button == this.btnMarketWatch)
				{
					this.OpenTemplate("My List");
				}
				else if (button == this.btnViewOrder)
				{
					this.OpenTemplate("View Order");
				}
				else if (button == this.btnPortfolio)
				{
					this.OpenTemplate("Portfolio");
				}
				else if (button == this.btnAutoTrade)
				{
					if (ApplicationInfo.IsAutoTradeAccepted)
					{
						this.OpenTemplate("AutoTrade");
					}
					else
					{
						this.ShowStopDisclaimer();
					}
				}
				else if (button == this.btnSummary)
				{
					this.contextMenuStrip1.Items.Clear();
					this.contextMenuStrip1.Items.Add("Stock in Play");
					this.contextMenuStrip1.Items.Add("Sale by Price");
					this.contextMenuStrip1.Items.Add("Sale by Time");
					this.contextMenuStrip1.Items.Add("View Oddlot");
					this.contextMenuStrip1.Show(this.btnSummary.PointToScreen(new Point(0, this.btnSummary.Height)));
				}
				else if (button == this.btnMarketInfo)
				{
					this.contextMenuStrip1.Items.Clear();
					this.contextMenuStrip1.Items.Add("Market Information");
					this.contextMenuStrip1.Items.Add("Ranking");
					this.contextMenuStrip1.Items.Add("Bids");
					Point point = new Point(0, this.btnMarketInfo.Height);
					point = this.btnMarketInfo.PointToScreen(point);
					this.contextMenuStrip1.Show(point);
				}
				else if (button == this.btnGraph)
				{
					this.OpenTemplate("Graph", "CHART");
				}
				else if (button == this.btnNews)
				{
					this.OpenTemplate("News", "NEWS");
				}
				else if (button == this.btnFinance)
				{
					this.OpenTemplate("Finance", "FINANCE");
				}
				else if (button == this.btnMore)
				{
					this.contextMenuStrip1.Items.Clear();
					this.contextMenuStrip1.Items.Add("SET News");
					if (ApplicationInfo.SupportBatchOrder == "Y")
					{
						this.contextMenuStrip1.Items.Add("Batch Order");
					}
					Point point = new Point(0, this.btnMore.Height);
					point = this.btnMore.PointToScreen(point);
					this.contextMenuStrip1.Show(point);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("Menus_Click", ex);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000362C0 File Offset: 0x000346C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ipwIPPortMain_OnConnected(object sender, IpportsConnectedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.StatusCode == 0)
				{
					this.ipwIPPortMain.EOL = "\r\n";
				}
				else
				{
					this.ShowError("Socket.Connected", new Exception(e.StatusCode + ":" + e.Description));
				}
			}
			catch (Exception ex)
			{
				this.ShowError("OnConnected", ex);
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00036360 File Offset: 0x00034760
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ipwIPPortMain_OnReadyToSend(object sender, IpportsReadyToSendEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Thread thread = new Thread(new ThreadStart(this.RegistrationToTunnel));
				thread.Start();
			}
			catch (Exception ex)
			{
				this.ShowError("OnReadyToSend", ex);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000363C4 File Offset: 0x000347C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ipwIPPortMain_OnDataIn(object sender, IpportsDataInEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			lock (((ICollection)this._qMessage).SyncRoot)
			{
				this._qMessage.Enqueue(e.Text);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00036428 File Offset: 0x00034828
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PeekQ()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			int i = 0;
			string text = string.Empty;
			this._isPeekQWorking = true;
			while (this._isRunPeekQ)
			{
				try
				{
					lock (((ICollection)this._qMessage).SyncRoot)
					{
						i = this._qMessage.Count;
					}
					if (i > 20)
					{
						i = 20;
					}
					while (i > 0)
					{
						lock (((ICollection)this._qMessage).SyncRoot)
						{
							text = this._qMessage.Dequeue();
						}
						i--;
						string[] array = text.Split(new char[]
						{
							Convert.ToChar(3)
						});
						string[] array2 = array;
						for (int j = 0; j < array2.Length; j++)
						{
							string message = array2[j];
							this.OnDataIn(message);
						}
						if (!this._isRunPeekQ)
						{
							break;
						}
					}
				}
				catch
				{
				}
				Thread.Sleep(20);
			}
			if (this._qMessage != null)
			{
				this._qMessage.Clear();
			}
			this._isPeekQWorking = false;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000365C0 File Offset: 0x000349C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ipwIPPortMain_OnDisconnected(object sender, IpportsDisconnectedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ShowConnectionStatus();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000365D8 File Offset: 0x000349D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ipwIPPortMain_OnError(object sender, IpportsErrorEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ShowError("Socket.Error", new Exception(e.Description));
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00036600 File Offset: 0x00034A00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ipwIPPortMain_OnSSLServerAuthentication(object sender, IpportsSSLServerAuthenticationEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.Accept = true;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0003661C File Offset: 0x00034A1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendEchoToServer()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.ipwIPPortMain.DataToSend = new Echo().Pack(ApplicationInfo.UserLoginID, ApplicationInfo.UserSessionID) + this.ipwIPPortMain.EOL;
			}
			catch (IPWorksSSLIpportsException ex)
			{
				this.ShowError("SendEcho", ex);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00036698 File Offset: 0x00034A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerMonitorFeed_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsAreadyLogin)
				{
					if (ApplicationInfo.IsPushMode)
					{
						if (this.ipwIPPortMain.Connected)
						{
							this._isPushConnected = true;
							if (this._lastEcho.AddSeconds(12.0) >= DateTime.Now)
							{
								this.SendEchoToServer();
							}
							else
							{
								this.ShowError("", new Exception("Echo timeout!"));
								this.startBC();
							}
						}
						else
						{
							this.ShowError("", new Exception("Socket not connected!"));
							this.GetTunnelNode();
							this.startBC();
						}
					}
					else if (!this.feedsWebProxy.CanConnectServer)
					{
						this._connectionPullCounter++;
						if (this._connectionPullCounter >= 2)
						{
							this._connectionPullCounter = 0;
							this.startBC();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("timerCheckECForBcTunnel_Tick", ex);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000367F8 File Offset: 0x00034BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetTunnelNode()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._isPushConnected)
			{
				ApplicationInfo.TunnelCounter++;
				if (ApplicationInfo.TunnelCounter > ApplicationInfo.TunnelHosts.Count - 1)
				{
					ApplicationInfo.TunnelCounter = 0;
				}
			}
			else
			{
				bool isPushMode = false;
				for (int i = 0; i < ApplicationInfo.TunnelHosts.Count; i++)
				{
					ApplicationInfo.TunnelCounter++;
					if (ApplicationInfo.TunnelCounter > ApplicationInfo.TunnelHosts.Count - 1)
					{
						ApplicationInfo.TunnelCounter = 0;
					}
					if (!ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].IsAlreadyStart)
					{
						isPushMode = true;
						break;
					}
				}
				ApplicationInfo.IsPushMode = isPushMode;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000368D8 File Offset: 0x00034CD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RegistrationToTunnel()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.UserLoginMode != "I")
				{
					if (this.ipwIPPortMain.Connected)
					{
						if (this._qMessage == null)
						{
							this._qMessage = new Queue<string>();
						}
						else
						{
							this._qMessage.Clear();
						}
						this._isRunPeekQ = true;
						Thread thread = new Thread(new ThreadStart(this.PeekQ));
						thread.Start();
						string text = string.Empty;
						foreach (KeyValuePair<string, AccountInfo.ItemInfo> current in ApplicationInfo.AccInfo.Items)
						{
							text = text + "|" + current.Key;
						}
						if (text != string.Empty)
						{
							text = text.Substring(1);
						}
						string str = new Register().Pack(ApplicationInfo.UserLoginID, ApplicationInfo.UserSessionID, 1, text);
						this.ipwIPPortMain.DataToSend = str + this.ipwIPPortMain.EOL;
						text = null;
						this.ShowConnectionStatus();
						this.CloseSpashForm();
					}
					else
					{
						this.ShowError("RegistrationToTunnel", new Exception("Can't register to server , Socket not connect"));
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("RegistrationToTunnel", ex);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00036AB0 File Offset: 0x00034EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UnregistrationFromTunnel()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.UserLoginMode != "I" && this.ipwIPPortMain.Connected)
				{
					string str = new Unregister().Pack(ApplicationInfo.UserLoginID, ApplicationInfo.UserSessionID, 1, "");
					this.ipwIPPortMain.DataToSend = str + this.ipwIPPortMain.EOL;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UnregistrationFromTunnel", ex);
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00036B64 File Offset: 0x00034F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Rectangle GetWorkingArea()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			int num = (int)((double)base.ClientSize.Width * 0.26);
			return new Rectangle(1, 86, base.ClientSize.Width - num - 2, this._BTop - 86);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00036BC8 File Offset: 0x00034FC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHeaderToChild()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderBox.SetHeader();
			this.TickerSlideBox.SetHeaderColor(true);
			this.Smart1ClickBox.SetHeaderColor(true);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00036C00 File Offset: 0x00035000
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSmartStock(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.Smart1ClickBox.Visible)
			{
				this.Smart1ClickBox.SetSmartStock(sender, source, newStock);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00036C40 File Offset: 0x00035040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTemplateLink(string page, string subPage, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.CurrentSymbol = stock;
				TemplateManager.Instance.MainForm.OpenTemplate(page, subPage);
				foreach (Control control in this.panelMenu.Controls)
				{
					if (control.GetType() == typeof(Button))
					{
						control.ForeColor = Color.LightGray;
					}
				}
				Button button = null;
				if (page == "Stock in Play" || page == "Sale by Price" || page == "Sale by Time" || page == "View Oddlot")
				{
					button = this.btnSummary;
				}
				else if (page == "News")
				{
					button = this.btnNews;
				}
				else if (page == "Graph")
				{
					button = this.btnGraph;
				}
				else if (page == "Finance")
				{
					button = this.btnFinance;
				}
				else if (page == "My List")
				{
					button = this.btnMarketWatch;
				}
				if (button != null)
				{
					button.ForeColor = Color.GreenYellow;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetTemplateLink", ex);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00036E44 File Offset: 0x00035244
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarketStateBox_OnCallAlert()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.OpenAlertForm();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00036E5C File Offset: 0x0003525C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarketStateBox_OnSitchMode()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.startBC();
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00036E74 File Offset: 0x00035274
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendOrderBox_OnAccountChanged(string account)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.ViewOrderBox.SwitchAccount();
				this.BroadcastMessageBox.ReloadData();
				this.Smart1ClickBox.SwitchAccount();
				TemplateManager.Instance.SendSymbolLink(this, SymbolLinkSource.SwitchAccount, "");
			}
			catch (Exception ex)
			{
				this.ShowError("SendOrderBox_OnAccountChanged", ex);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00036EF4 File Offset: 0x000352F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendOrderBox_OnBoxStyleChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Instance_SetBottomSize();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00036F0C File Offset: 0x0003530C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendOrderBox_OnResized()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00036F20 File Offset: 0x00035320
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendOrderBox_OnResizeUpDown(bool isUp)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			int bTop = this._BTop;
			if (isUp)
			{
				this._BTop -= (int)((float)base.Height * 0.08f);
			}
			else
			{
				this._BTop += (int)((float)base.Height * 0.08f);
			}
			if (bTop != this._BTop)
			{
				this.Instance_SetBottomSize();
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00036FA4 File Offset: 0x000353A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateAutoComplete(string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMain.UpdateAutoCompleteCallBack(this.UpdateAutoComplete), new object[]
				{
					symbol
				});
			}
			else
			{
				try
				{
					ApplicationInfo.MultiAutoComp.Add(symbol);
					ApplicationInfo.MultiAutoCompStringArr = null;
					ApplicationInfo.MultiAutoCompStringArr.Initialize();
					ApplicationInfo.SeriesAutoComp.Add(symbol);
					ApplicationInfo.SeriesAutoCompStringArr.Initialize();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0003704C File Offset: 0x0003544C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadTFEXInfomation()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = ApplicationInfo.WebServiceTFEX.TFEXInformation();
				if (!string.IsNullOrEmpty(text))
				{
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(text, dataSet);
						if (dataSet.Tables.Contains("Info") && dataSet.Tables["Info"].Rows.Count > 0)
						{
							ApplicationInfo.SeriesInfo.ResetData();
							foreach (DataRow dataRow in dataSet.Tables["Info"].Rows)
							{
								SeriesList.SeriesInformation seriesInformation = new SeriesList.SeriesInformation();
								seriesInformation.Symbol = dataRow["sSeries"].ToString();
								int num;
								int.TryParse(dataRow["lOrderBookId"].ToString(), out num);
								seriesInformation.OrderBookId = num;
								int.TryParse(dataRow["lUndOrderBookId"].ToString(), out num);
								seriesInformation.UnderOrderBookId = num;
								decimal num2;
								decimal.TryParse(dataRow["nmrCeiling"].ToString(), out num2);
								seriesInformation.Ceiling = num2;
								decimal.TryParse(dataRow["nmrFloor"].ToString(), out num2);
								seriesInformation.Floor = num2;
								decimal.TryParse(dataRow["nmrFixPrice"].ToString(), out num2);
								seriesInformation.FixPrice = num2;
								decimal.TryParse(dataRow["nmrPrevFixPrice"].ToString(), out num2);
								seriesInformation.PrevFixPrice = num2;
								int.TryParse(dataRow["iMarketNo"].ToString(), out num);
								seriesInformation.MarketCode = num;
								int.TryParse(dataRow["iSymbolTypeNo"].ToString(), out num);
								seriesInformation.Group = num;
								decimal.TryParse(dataRow["nmrContractSize"].ToString(), out num2);
								seriesInformation.ContractSize = num2;
								seriesInformation.ExpireDate = dataRow["sExpDate"].ToString();
								int.TryParse(dataRow["iOpenBalance"].ToString(), out num);
								seriesInformation.OpenInt = num;
								decimal.TryParse(dataRow["nmrStrike"].ToString(), out num2);
								seriesInformation.StrikPrice = num2;
								decimal.TryParse(dataRow["nmrPrice"].ToString(), out num2);
								seriesInformation.LastSalePrice = num2;
								decimal.TryParse(dataRow["tickSize"].ToString(), out num2);
								seriesInformation.TickSize = num2;
								seriesInformation.SeriesType = dataRow["seriesType"].ToString();
								int numOfDec = 0;
								int.TryParse(dataRow["iDecPrice"].ToString(), out numOfDec);
								seriesInformation.NumOfDec = numOfDec;
								seriesInformation.MarketId = dataRow["sMarketId"].ToString().Trim();
								ApplicationInfo.SeriesInfo.AddItem(seriesInformation);
							}
						}
						if (dataSet.Tables.Contains("MarketInfo") && dataSet.Tables["MarketInfo"].Rows.Count > 0)
						{
							foreach (DataRow dataRow in dataSet.Tables["MarketInfo"].Rows)
							{
								long num3;
								long.TryParse(dataRow["TotVolume"].ToString(), out num3);
								long num4;
								long.TryParse(dataRow["TotDeal"].ToString(), out num4);
								long num5;
								long.TryParse(dataRow["oi"].ToString(), out num5);
								if (dataRow["iSymbolTypeNo"].ToString() == "1")
								{
									ApplicationInfo.IndexInfoTfex.OptionsVol += num3;
									ApplicationInfo.IndexInfoTfex.OptionsOI += num5;
									ApplicationInfo.IndexInfoTfex.TfexTotalDeal += num4;
								}
								else if (dataRow["iSymbolTypeNo"].ToString() == "2")
								{
									ApplicationInfo.IndexInfoTfex.OptionsVol += num3;
									ApplicationInfo.IndexInfoTfex.OptionsOI += num5;
									ApplicationInfo.IndexInfoTfex.TfexTotalDeal += num4;
								}
								else
								{
									ApplicationInfo.IndexInfoTfex.FutureVol = num3;
									ApplicationInfo.IndexInfoTfex.FutureOI = num5;
									ApplicationInfo.IndexInfoTfex.TfexTotalDeal += num4;
								}
							}
							ApplicationInfo.IndexInfoTfex.TfexTotalVol = ApplicationInfo.IndexInfoTfex.FutureVol + ApplicationInfo.IndexInfoTfex.OptionsVol;
							ApplicationInfo.IndexInfoTfex.TfexTotalOI = ApplicationInfo.IndexInfoTfex.FutureOI + ApplicationInfo.IndexInfoTfex.OptionsOI;
						}
						if (dataSet.Tables.Contains("UnderlyingInfo") && dataSet.Tables["UnderlyingInfo"].Rows.Count > 0)
						{
							ApplicationInfo.UnderlyingInfo.ResetData();
							foreach (DataRow dataRow in dataSet.Tables["UnderlyingInfo"].Rows)
							{
								UnderlyingInfo.UnderlyingList underlyingList = new UnderlyingInfo.UnderlyingList();
								int num;
								int.TryParse(dataRow["lOrderBookId"].ToString(), out num);
								underlyingList.OrderBookId = num;
								underlyingList.Symbol = dataRow["sSymbol"].ToString().Trim();
								ApplicationInfo.UnderlyingInfo.AddItem(underlyingList);
							}
						}
						if (ApplicationInfo.BrokerId == 4 && ApplicationInfo.IsSupportTfex)
						{
							BBOTFEXCurrency bBOTFEXCurrency = new BBOTFEXCurrency();
							bBOTFEXCurrency.CurrencyName = "USD";
							bBOTFEXCurrency.BidPrice = 0m;
							bBOTFEXCurrency.AskPrice = 0m;
							bBOTFEXCurrency.LastTime = "00:00:00";
							bBOTFEXCurrency.LastDate = "01 January 2000";
							ApplicationInfo.IndexInfoTfex.BBOCurrency.Add(bBOTFEXCurrency.CurrencyName, bBOTFEXCurrency);
							bBOTFEXCurrency = new BBOTFEXCurrency();
							bBOTFEXCurrency.CurrencyName = "THB";
							bBOTFEXCurrency.BidPrice = 0m;
							bBOTFEXCurrency.AskPrice = 0m;
							bBOTFEXCurrency.LastTime = "00:00:00";
							bBOTFEXCurrency.LastDate = "01 January 2000";
							ApplicationInfo.IndexInfoTfex.BBOCurrency.Add(bBOTFEXCurrency.CurrencyName, bBOTFEXCurrency);
						}
						dataSet.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00037884 File Offset: 0x00035C84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadTFEXMarketstate()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = ApplicationInfo.WebServiceTFEX.LoadMktStatus();
				if (!string.IsNullOrEmpty(text))
				{
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(text, dataSet);
						if (dataSet != null && dataSet.Tables.Contains("Table") && dataSet.Tables["Table"].Rows.Count > 0)
						{
							foreach (DataRow dataRow in dataSet.Tables["Table"].Rows)
							{
								if (dataRow["Market"].ToString().Trim() == "TXI")
								{
									ApplicationInfo.IndexInfoTfex.TXIState = dataRow["sStateNumber"].ToString().Trim();
									int num;
									int.TryParse(dataRow["Session"].ToString(), out num);
									ApplicationInfo.IndexInfoTfex.TXISession = num;
								}
								else if (dataRow["Market"].ToString().Trim() == "TXM")
								{
									ApplicationInfo.IndexInfoTfex.TXMState = dataRow["sStateNumber"].ToString();
									int num;
									int.TryParse(dataRow["Session"].ToString(), out num);
									ApplicationInfo.IndexInfoTfex.TXMSession = num;
								}
								else if (dataRow["Market"].ToString().Trim() == "TXR")
								{
									ApplicationInfo.IndexInfoTfex.TXRState = dataRow["sStateNumber"].ToString();
									int num;
									int.TryParse(dataRow["Session"].ToString(), out num);
									ApplicationInfo.IndexInfoTfex.TXRSession = num;
								}
								else if (dataRow["Market"].ToString().Trim() == "TXS")
								{
									ApplicationInfo.IndexInfoTfex.TXSState = dataRow["sStateNumber"].ToString();
									int num;
									int.TryParse(dataRow["Session"].ToString(), out num);
									ApplicationInfo.IndexInfoTfex.TXSSession = num;
								}
								else if (dataRow["Market"].ToString().Trim() == "TXE")
								{
									ApplicationInfo.IndexInfoTfex.TXEState = dataRow["sStateNumber"].ToString();
									int num;
									int.TryParse(dataRow["Session"].ToString(), out num);
									ApplicationInfo.IndexInfoTfex.TXESession = num;
								}
								else if (dataRow["Market"].ToString().Trim() == "TXC")
								{
									ApplicationInfo.IndexInfoTfex.TXCState = dataRow["sStateNumber"].ToString();
									int num;
									int.TryParse(dataRow["Session"].ToString(), out num);
									ApplicationInfo.IndexInfoTfex.TXCSession = num;
								}
							}
						}
						dataSet.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00037CA4 File Offset: 0x000360A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFont()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.Instance_SetBottomSize();
				this.TickerSlideBox.SetResize();
				this.Smart1ClickBox.SetResize();
			}
			catch (Exception ex)
			{
				this.ShowError("SetFont", ex);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00037D0C File Offset: 0x0003610C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnFacebook_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Process.Start("https://www.facebook.com/efinapp");
			}
			catch (Exception ex)
			{
				this.ShowError("btnFacebook_Click", ex);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00037D60 File Offset: 0x00036160
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timer1_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timer1.Stop();
				ApplicationInfo.IsResumeState = true;
				this.OpenTemplate(TemplateManager.Instance.CurrentActiveTemplateView.Name);
				ApplicationInfo.IsResumeState = false;
				this.startBC();
			}
			catch (Exception ex)
			{
				this.ShowError("timer1_Tick", ex);
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00037DE0 File Offset: 0x000361E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowStopDisclaimer()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMain.ShowStopDisclaimerCallBack(this.ShowStopDisclaimer));
			}
			else
			{
				try
				{
					if (this._frmStopDisclaimer != null)
					{
						if (!this._frmStopDisclaimer.IsDisposed)
						{
							this._frmStopDisclaimer.Dispose();
						}
						this._frmStopDisclaimer = null;
					}
					this._frmStopDisclaimer = new frmStopDisclaimer(false);
					this._frmStopDisclaimer.FormClosing -= new FormClosingEventHandler(this.frmStopDisclaimer_FormClosing);
					this._frmStopDisclaimer.FormClosing += new FormClosingEventHandler(this.frmStopDisclaimer_FormClosing);
					this._frmStopDisclaimer.TopLevel = false;
					this._frmStopDisclaimer.Parent = this;
					this._frmStopDisclaimer.Location = new Point((this._frmStopDisclaimer.Parent.Width - this._frmStopDisclaimer.Width) / 2, (this._frmStopDisclaimer.Parent.Height - this._frmStopDisclaimer.Height) / 2);
					this._frmStopDisclaimer.TopMost = true;
					this._frmStopDisclaimer.Show();
					this._frmStopDisclaimer.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("ShowStopDisclaimer", ex);
				}
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00037F60 File Offset: 0x00036360
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStopDisclaimer_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsAutoTradeAccepted)
				{
					this.OpenTemplate("AutoTrade");
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmStopDisclaimer_FormClosing", ex);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00037FC8 File Offset: 0x000363C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setTopPos()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SectorBox.Width = this.panelTop.Width - this.SectorBox.Left - this.picBrokerLogo.Width - this.MarketStateBox.Width - 10;
			this.MarketStateBox.Left = this.SectorBox.Right + 5;
			this.picBrokerLogo.Left = this.MarketStateBox.Right + 5;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00038054 File Offset: 0x00036454
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.ClickedItem != null)
			{
				if (e.ClickedItem.Text == "Stock in Play")
				{
					this.OpenTemplate(e.ClickedItem.Text, "Stock in Play");
				}
				else if (e.ClickedItem.Text == "Sale by Price")
				{
					this.OpenTemplate(e.ClickedItem.Text, "Sale by Price");
				}
				else if (e.ClickedItem.Text == "Sale by Time")
				{
					this.OpenTemplate(e.ClickedItem.Text, "Sale by Time");
				}
				else if (e.ClickedItem.Text == "View Oddlot")
				{
					this.OpenTemplate(e.ClickedItem.Text, "View Oddlot");
				}
				else
				{
					this.OpenTemplate(e.ClickedItem.Text);
				}
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00038180 File Offset: 0x00036580
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Dispose(bool disposing)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000381D0 File Offset: 0x000365D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
			this.timerCallLoginForm = new System.Windows.Forms.Timer(this.components);
			this.panBottom = new Panel();
			this.btnResizeMD1 = new Button();
			this.ViewOrderBox = new ucViewOrder();
			this.SendOrderBox = new ucSendNewOrder();
			this.BroadcastMessageBox = new ucBroadcastMessage();
			this.timerGetOrderInfo = new System.Windows.Forms.Timer(this.components);
			this.panelSep = new Panel();
			this.panelTop = new Panel();
			this.picBrokerLogo = new PictureBox();
			this.MarketStateBox = new ucMarketStateBox();
			this.SET2Box = new ucIndexBox();
			this.SETBox = new ucIndexBox();
			this.pici2Logo = new PictureBox();
			this.SectorBox = new ucIndexBox();
			this.btnLogout = new Button();
			this.toolTip1 = new ToolTip(this.components);
			this.btnShowTickerSlide = new Button();
			this.btnShowSpeedOrderSlide = new Button();
			this.btnFacebook = new Button();
			this.btnOptions2 = new Button();
			this.panelControlDockR = new Panel();
			this.panelDockR = new Panel();
			this.Smart1ClickBox = new ucSmart1Click();
			this.TickerSlideBox = new ucTickerSlide();
			this.panelMenu = new Panel();
			this.btnFinance = new Button();
			this.btnGraph = new Button();
			this.btnNews = new Button();
			this.btnMore = new Button();
			this.btnAutoTrade = new Button();
			this.btnMarketInfo = new Button();
			this.btnPortfolio = new Button();
			this.btnViewOrder = new Button();
			this.btnSummary = new Button();
			this.btnMarketWatch = new Button();
			this.timerMonitorFeed = new System.Windows.Forms.Timer(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1 = new ContextMenuStrip(this.components);
			this.panBottom.SuspendLayout();
			this.panelTop.SuspendLayout();
			((ISupportInitialize)this.picBrokerLogo).BeginInit();
			((ISupportInitialize)this.pici2Logo).BeginInit();
			this.panelControlDockR.SuspendLayout();
			this.panelDockR.SuspendLayout();
			this.panelMenu.SuspendLayout();
			base.SuspendLayout();
			this.timerCallLoginForm.Interval = 200;
			this.timerCallLoginForm.Tick += new EventHandler(this.timerCallLoginForm_Tick);
			this.panBottom.BackColor = Color.FromArgb(20, 20, 20);
			this.panBottom.Controls.Add(this.btnResizeMD1);
			this.panBottom.Controls.Add(this.ViewOrderBox);
			this.panBottom.Controls.Add(this.SendOrderBox);
			this.panBottom.Controls.Add(this.BroadcastMessageBox);
			this.panBottom.Dock = DockStyle.Bottom;
			this.panBottom.Location = new Point(0, 390);
			this.panBottom.Margin = new Padding(0);
			this.panBottom.Name = "panBottom";
			this.panBottom.Padding = new Padding(1);
			this.panBottom.Size = new Size(1153, 174);
			this.panBottom.TabIndex = 67;
			this.panBottom.Visible = false;
			this.btnResizeMD1.BackColor = Color.FromArgb(30, 30, 30);
			this.btnResizeMD1.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
			this.btnResizeMD1.FlatAppearance.BorderSize = 0;
			this.btnResizeMD1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnResizeMD1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnResizeMD1.FlatStyle = FlatStyle.Flat;
			this.btnResizeMD1.ForeColor = Color.DarkGray;
			this.btnResizeMD1.Image = Resources.MovePreviousHS;
			this.btnResizeMD1.Location = new Point(597, 52);
			this.btnResizeMD1.Margin = new Padding(0);
			this.btnResizeMD1.Name = "btnResizeMD1";
			this.btnResizeMD1.Size = new Size(17, 121);
			this.btnResizeMD1.TabIndex = 97;
			this.btnResizeMD1.TabStop = false;
			this.btnResizeMD1.UseVisualStyleBackColor = false;
			this.btnResizeMD1.Visible = false;
			this.btnResizeMD1.Click += new EventHandler(this.btnResizeMD_Click);
			this.ViewOrderBox.BackColor = Color.FromArgb(30, 30, 30);
			this.ViewOrderBox.IsActive = false;
			this.ViewOrderBox.IsLoadingData = false;
			this.ViewOrderBox.IsShowLoadingControl = true;
			this.ViewOrderBox.IsShowNextPage = true;
			this.ViewOrderBox.IsShowToolsBar = true;
			this.ViewOrderBox.Location = new Point(5, 64);
			this.ViewOrderBox.Margin = new Padding(0);
			this.ViewOrderBox.Name = "ViewOrderBox";
			this.ViewOrderBox.ShowOnMainForm = true;
			this.ViewOrderBox.Size = new Size(592, 95);
			this.ViewOrderBox.TabIndex = 93;
			this.ViewOrderBox.Visible = false;
			this.SendOrderBox.AllowDrop = true;
			this.SendOrderBox.BackColor = Color.FromArgb(30, 30, 30);
			this.SendOrderBox.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.SendOrderBox.ForeColor = Color.White;
			this.SendOrderBox.IsActive = false;
			this.SendOrderBox.Location = new Point(1, 1);
			this.SendOrderBox.Margin = new Padding(0);
			this.SendOrderBox.Name = "SendOrderBox";
			this.SendOrderBox.Size = new Size(845, 50);
			this.SendOrderBox.TabIndex = 94;
			this.SendOrderBox.TabStop = false;
			this.SendOrderBox.Visible = false;
			this.SendOrderBox.OnResized += new ucSendNewOrder.OnResizedHandler(this.SendOrderBox_OnResized);
			this.SendOrderBox.OnBoxStyleChanged += new ucSendNewOrder.OnBoxStyleChangedHandler(this.SendOrderBox_OnBoxStyleChanged);
			this.SendOrderBox.OnResizeUpDown += new ucSendNewOrder.OnResizeUpDownHandler(this.SendOrderBox_OnResizeUpDown);
			this.SendOrderBox.OnAccountChanged += new ucSendNewOrder.OnAccountChangedHandler(this.SendOrderBox_OnAccountChanged);
			this.BroadcastMessageBox.BackColor = Color.FromArgb(30, 30, 30);
			this.BroadcastMessageBox.IsFirstOpen = true;
			this.BroadcastMessageBox.Location = new Point(615, 52);
			this.BroadcastMessageBox.Margin = new Padding(1);
			this.BroadcastMessageBox.Name = "BroadcastMessageBox";
			this.BroadcastMessageBox.Padding = new Padding(1);
			this.BroadcastMessageBox.Size = new Size(231, 123);
			this.BroadcastMessageBox.TabIndex = 0;
			this.BroadcastMessageBox.Visible = false;
			this.timerGetOrderInfo.Interval = 1000;
			this.timerGetOrderInfo.Tick += new EventHandler(this.timerGetOrderInfo_Tick);
			this.panelSep.BackColor = Color.LightGray;
			this.panelSep.Cursor = Cursors.HSplit;
			this.panelSep.Location = new Point(22, 378);
			this.panelSep.Name = "panelSep";
			this.panelSep.Size = new Size(799, 3);
			this.panelSep.TabIndex = 69;
			this.panelSep.Visible = false;
			this.panelSep.MouseMove += new MouseEventHandler(this.panelSep_MouseMove);
			this.panelSep.MouseDown += new MouseEventHandler(this.panelSep_MouseDown);
			this.panelSep.MouseUp += new MouseEventHandler(this.panelSep_MouseUp);
			this.panelTop.BackColor = Color.FromArgb(20, 20, 20);
			this.panelTop.Controls.Add(this.picBrokerLogo);
			this.panelTop.Controls.Add(this.MarketStateBox);
			this.panelTop.Controls.Add(this.SET2Box);
			this.panelTop.Controls.Add(this.SETBox);
			this.panelTop.Controls.Add(this.pici2Logo);
			this.panelTop.Controls.Add(this.SectorBox);
			this.panelTop.Dock = DockStyle.Top;
			this.panelTop.Location = new Point(0, 0);
			this.panelTop.MaximumSize = new Size(0, 54);
			this.panelTop.MinimumSize = new Size(0, 54);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new Size(1153, 54);
			this.panelTop.TabIndex = 70;
			this.panelTop.Visible = false;
			this.picBrokerLogo.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.picBrokerLogo.BackColor = Color.Transparent;
			this.picBrokerLogo.Image = Resources.logo_demo;
			this.picBrokerLogo.Location = new Point(1021, 4);
			this.picBrokerLogo.Name = "picBrokerLogo";
			this.picBrokerLogo.Padding = new Padding(5);
			this.picBrokerLogo.Size = new Size(129, 46);
			this.picBrokerLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			this.picBrokerLogo.TabIndex = 65;
			this.picBrokerLogo.TabStop = false;
			this.MarketStateBox.AlterMessageCount = 0;
			this.MarketStateBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.MarketStateBox.BackColor = Color.FromArgb(30, 30, 30);
			this.MarketStateBox.IsAlertStart = false;
			this.MarketStateBox.IsAllowBlinkAlert = false;
			this.MarketStateBox.Location = new Point(881, 2);
			this.MarketStateBox.Margin = new Padding(4);
			this.MarketStateBox.Name = "MarketStateBox";
			this.MarketStateBox.Size = new Size(170, 50);
			this.MarketStateBox.TabIndex = 62;
			this.MarketStateBox.OnSitchMode += new ucMarketStateBox.SwitchMode(this.MarketStateBox_OnSitchMode);
			this.MarketStateBox.OnCallAlert += new ucMarketStateBox.CallAlert(this.MarketStateBox_OnCallAlert);
			this.SET2Box.Active = false;
			this.SET2Box.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.SET2Box.BackColor = Color.Black;
			this.SET2Box.DisplaySector = 0;
			this.SET2Box.DisplaySET = "SET50";
			this.SET2Box.DisplayType = 1;
			this.SET2Box.Location = new Point(389, 2);
			this.SET2Box.Margin = new Padding(4);
			this.SET2Box.Name = "SET2Box";
			this.SET2Box.Size = new Size(275, 50);
			this.SET2Box.TabIndex = 60;
			this.SETBox.Active = false;
			this.SETBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.SETBox.BackColor = Color.Black;
			this.SETBox.DisplaySector = 0;
			this.SETBox.DisplaySET = "SET";
			this.SETBox.DisplayType = 1;
			this.SETBox.Location = new Point(152, 2);
			this.SETBox.Margin = new Padding(4);
			this.SETBox.Name = "SETBox";
			this.SETBox.Size = new Size(232, 50);
			this.SETBox.TabIndex = 59;
			this.pici2Logo.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.pici2Logo.BackColor = Color.Transparent;
			this.pici2Logo.Image = Resources.LOGO;
			this.pici2Logo.Location = new Point(3, 2);
			this.pici2Logo.Name = "pici2Logo";
			this.pici2Logo.Padding = new Padding(5);
			this.pici2Logo.Size = new Size(145, 49);
			this.pici2Logo.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pici2Logo.TabIndex = 12;
			this.pici2Logo.TabStop = false;
			this.SectorBox.Active = false;
			this.SectorBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.SectorBox.BackColor = Color.Black;
			this.SectorBox.DisplaySector = 1;
			this.SectorBox.DisplaySET = "";
			this.SectorBox.DisplayType = 3;
			this.SectorBox.Location = new Point(669, 2);
			this.SectorBox.Margin = new Padding(4);
			this.SectorBox.Name = "SectorBox";
			this.SectorBox.Size = new Size(182, 50);
			this.SectorBox.TabIndex = 61;
			this.btnLogout.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnLogout.BackColor = Color.Transparent;
			this.btnLogout.FlatAppearance.BorderColor = Color.DimGray;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnLogout.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnLogout.FlatStyle = FlatStyle.Flat;
			this.btnLogout.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnLogout.ForeColor = Color.LightGray;
			this.btnLogout.Location = new Point(170, 2);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Padding = new Padding(1, 0, 1, 0);
			this.btnLogout.Size = new Size(57, 26);
			this.btnLogout.TabIndex = 11;
			this.btnLogout.Tag = "0";
			this.btnLogout.Text = "Logout";
			this.btnLogout.TextAlign = ContentAlignment.TopCenter;
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipTitle = "Info guide";
			this.btnShowTickerSlide.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.btnShowTickerSlide.BackColor = Color.FromArgb(20, 20, 20);
			this.btnShowTickerSlide.FlatAppearance.BorderColor = Color.DimGray;
			this.btnShowTickerSlide.FlatAppearance.BorderSize = 0;
			this.btnShowTickerSlide.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnShowTickerSlide.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnShowTickerSlide.FlatStyle = FlatStyle.Flat;
			this.btnShowTickerSlide.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnShowTickerSlide.ForeColor = Color.Cyan;
			this.btnShowTickerSlide.Image = Resources.side_noside;
			this.btnShowTickerSlide.Location = new Point(3, 3);
			this.btnShowTickerSlide.Name = "btnShowTickerSlide";
			this.btnShowTickerSlide.Size = new Size(25, 26);
			this.btnShowTickerSlide.TabIndex = 0;
			this.btnShowTickerSlide.TabStop = false;
			this.btnShowTickerSlide.Tag = "1";
			this.btnShowTickerSlide.Text = "T";
			this.toolTip1.SetToolTip(this.btnShowTickerSlide, "Ticker Panel");
			this.btnShowTickerSlide.UseVisualStyleBackColor = false;
			this.btnShowTickerSlide.Click += new EventHandler(this.btnShowSlide_Click);
			this.btnShowSpeedOrderSlide.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.btnShowSpeedOrderSlide.BackColor = Color.FromArgb(20, 20, 20);
			this.btnShowSpeedOrderSlide.FlatAppearance.BorderColor = Color.DimGray;
			this.btnShowSpeedOrderSlide.FlatAppearance.BorderSize = 0;
			this.btnShowSpeedOrderSlide.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnShowSpeedOrderSlide.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnShowSpeedOrderSlide.FlatStyle = FlatStyle.Flat;
			this.btnShowSpeedOrderSlide.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnShowSpeedOrderSlide.ForeColor = Color.LightGray;
			this.btnShowSpeedOrderSlide.Image = Resources.side_noside;
			this.btnShowSpeedOrderSlide.Location = new Point(31, 3);
			this.btnShowSpeedOrderSlide.Name = "btnShowSpeedOrderSlide";
			this.btnShowSpeedOrderSlide.Size = new Size(25, 26);
			this.btnShowSpeedOrderSlide.TabIndex = 12;
			this.btnShowSpeedOrderSlide.TabStop = false;
			this.btnShowSpeedOrderSlide.Tag = "2";
			this.btnShowSpeedOrderSlide.Text = "S";
			this.toolTip1.SetToolTip(this.btnShowSpeedOrderSlide, "Smart One Click Panel");
			this.btnShowSpeedOrderSlide.UseVisualStyleBackColor = false;
			this.btnShowSpeedOrderSlide.Click += new EventHandler(this.btnShowSlide_Click);
			this.btnFacebook.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnFacebook.BackColor = Color.Transparent;
			this.btnFacebook.FlatAppearance.BorderColor = Color.DimGray;
			this.btnFacebook.FlatAppearance.BorderSize = 0;
			this.btnFacebook.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnFacebook.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnFacebook.FlatStyle = FlatStyle.Flat;
			this.btnFacebook.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnFacebook.ForeColor = Color.LightGray;
			this.btnFacebook.Image = (Image)componentResourceManager.GetObject("btnFacebook.Image");
			this.btnFacebook.Location = new Point(110, 2);
			this.btnFacebook.Name = "btnFacebook";
			this.btnFacebook.Size = new Size(25, 26);
			this.btnFacebook.TabIndex = 75;
			this.btnFacebook.TabStop = false;
			this.btnFacebook.Tag = "2";
			this.toolTip1.SetToolTip(this.btnFacebook, "Goto i2Trade facebook");
			this.btnFacebook.UseVisualStyleBackColor = false;
			this.btnFacebook.Click += new EventHandler(this.btnFacebook_Click);
			this.btnOptions2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnOptions2.BackColor = Color.Transparent;
			this.btnOptions2.FlatAppearance.BorderColor = Color.DimGray;
			this.btnOptions2.FlatAppearance.BorderSize = 0;
			this.btnOptions2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnOptions2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnOptions2.FlatStyle = FlatStyle.Flat;
			this.btnOptions2.ForeColor = Color.LightGray;
			this.btnOptions2.Image = (Image)componentResourceManager.GetObject("btnOptions2.Image");
			this.btnOptions2.Location = new Point(137, 2);
			this.btnOptions2.Name = "btnOptions2";
			this.btnOptions2.Size = new Size(25, 26);
			this.btnOptions2.TabIndex = 2;
			this.btnOptions2.TabStop = false;
			this.toolTip1.SetToolTip(this.btnOptions2, "Setting");
			this.btnOptions2.UseVisualStyleBackColor = false;
			this.btnOptions2.Click += new EventHandler(this.btnOptions_Click);
			this.panelControlDockR.BackColor = Color.FromArgb(30, 30, 30);
			this.panelControlDockR.Controls.Add(this.btnFacebook);
			this.panelControlDockR.Controls.Add(this.btnLogout);
			this.panelControlDockR.Controls.Add(this.btnOptions2);
			this.panelControlDockR.Controls.Add(this.btnShowSpeedOrderSlide);
			this.panelControlDockR.Controls.Add(this.btnShowTickerSlide);
			this.panelControlDockR.Dock = DockStyle.Right;
			this.panelControlDockR.Location = new Point(923, 0);
			this.panelControlDockR.Name = "panelControlDockR";
			this.panelControlDockR.Padding = new Padding(0, 0, 0, 1);
			this.panelControlDockR.Size = new Size(230, 30);
			this.panelControlDockR.TabIndex = 72;
			this.panelDockR.BackColor = Color.FromArgb(20, 20, 20);
			this.panelDockR.Controls.Add(this.Smart1ClickBox);
			this.panelDockR.Controls.Add(this.TickerSlideBox);
			this.panelDockR.Location = new Point(891, 178);
			this.panelDockR.Name = "panelDockR";
			this.panelDockR.Size = new Size(255, 162);
			this.panelDockR.TabIndex = 73;
			this.panelDockR.Visible = false;
			this.Smart1ClickBox.BackColor = Color.FromArgb(20, 20, 20);
			this.Smart1ClickBox.IsLoadingData = true;
			this.Smart1ClickBox.Location = new Point(10, 98);
			this.Smart1ClickBox.Margin = new Padding(4);
			this.Smart1ClickBox.Name = "Smart1ClickBox";
			this.Smart1ClickBox.Size = new Size(242, 26);
			this.Smart1ClickBox.TabIndex = 2;
			this.Smart1ClickBox.Visible = false;
			this.TickerSlideBox.BackColor = Color.FromArgb(20, 20, 20);
			this.TickerSlideBox.Location = new Point(14, 3);
			this.TickerSlideBox.Margin = new Padding(4);
			this.TickerSlideBox.Name = "TickerSlideBox";
			this.TickerSlideBox.Size = new Size(268, 54);
			this.TickerSlideBox.TabIndex = 0;
			this.TickerSlideBox.Visible = false;
			this.panelMenu.BackColor = Color.FromArgb(30, 30, 30);
			this.panelMenu.Controls.Add(this.btnFinance);
			this.panelMenu.Controls.Add(this.btnGraph);
			this.panelMenu.Controls.Add(this.btnNews);
			this.panelMenu.Controls.Add(this.btnMore);
			this.panelMenu.Controls.Add(this.panelControlDockR);
			this.panelMenu.Controls.Add(this.btnAutoTrade);
			this.panelMenu.Controls.Add(this.btnMarketInfo);
			this.panelMenu.Controls.Add(this.btnPortfolio);
			this.panelMenu.Controls.Add(this.btnViewOrder);
			this.panelMenu.Controls.Add(this.btnSummary);
			this.panelMenu.Controls.Add(this.btnMarketWatch);
			this.panelMenu.Dock = DockStyle.Top;
			this.panelMenu.Location = new Point(0, 54);
			this.panelMenu.MaximumSize = new Size(0, 30);
			this.panelMenu.MinimumSize = new Size(0, 30);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new Size(1153, 30);
			this.panelMenu.TabIndex = 74;
			this.panelMenu.Visible = false;
			this.btnFinance.AutoSize = true;
			this.btnFinance.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnFinance.BackColor = Color.Transparent;
			this.btnFinance.FlatAppearance.BorderSize = 0;
			this.btnFinance.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnFinance.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnFinance.FlatStyle = FlatStyle.Flat;
			this.btnFinance.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnFinance.ForeColor = Color.LightGray;
			this.btnFinance.Location = new Point(560, 1);
			this.btnFinance.Name = "btnFinance";
			this.btnFinance.Size = new Size(58, 25);
			this.btnFinance.TabIndex = 76;
			this.btnFinance.Tag = "0";
			this.btnFinance.Text = "Finance";
			this.btnFinance.TextAlign = ContentAlignment.TopCenter;
			this.btnFinance.UseVisualStyleBackColor = false;
			this.btnFinance.Click += new EventHandler(this.Menus_Click);
			this.btnGraph.AutoSize = true;
			this.btnGraph.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnGraph.BackColor = Color.Transparent;
			this.btnGraph.FlatAppearance.BorderSize = 0;
			this.btnGraph.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnGraph.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnGraph.FlatStyle = FlatStyle.Flat;
			this.btnGraph.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnGraph.ForeColor = Color.LightGray;
			this.btnGraph.Location = new Point(504, 1);
			this.btnGraph.Name = "btnGraph";
			this.btnGraph.Size = new Size(49, 25);
			this.btnGraph.TabIndex = 75;
			this.btnGraph.Tag = "0";
			this.btnGraph.Text = "Graph";
			this.btnGraph.TextAlign = ContentAlignment.TopCenter;
			this.btnGraph.UseVisualStyleBackColor = false;
			this.btnGraph.Click += new EventHandler(this.Menus_Click);
			this.btnNews.AutoSize = true;
			this.btnNews.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnNews.BackColor = Color.Transparent;
			this.btnNews.FlatAppearance.BorderSize = 0;
			this.btnNews.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnNews.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnNews.FlatStyle = FlatStyle.Flat;
			this.btnNews.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnNews.ForeColor = Color.LightGray;
			this.btnNews.Location = new Point(450, 1);
			this.btnNews.Name = "btnNews";
			this.btnNews.Size = new Size(46, 25);
			this.btnNews.TabIndex = 74;
			this.btnNews.Tag = "0";
			this.btnNews.Text = "News";
			this.btnNews.TextAlign = ContentAlignment.TopCenter;
			this.btnNews.UseVisualStyleBackColor = false;
			this.btnNews.Click += new EventHandler(this.Menus_Click);
			this.btnMore.AutoSize = true;
			this.btnMore.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMore.BackColor = Color.Transparent;
			this.btnMore.FlatAppearance.BorderSize = 0;
			this.btnMore.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMore.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnMore.FlatStyle = FlatStyle.Flat;
			this.btnMore.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnMore.ForeColor = Color.LightGray;
			this.btnMore.Location = new Point(629, 1);
			this.btnMore.Name = "btnMore";
			this.btnMore.Size = new Size(45, 25);
			this.btnMore.TabIndex = 73;
			this.btnMore.Tag = "0";
			this.btnMore.Text = "More";
			this.btnMore.TextAlign = ContentAlignment.TopCenter;
			this.btnMore.UseVisualStyleBackColor = false;
			this.btnMore.Click += new EventHandler(this.Menus_Click);
			this.btnAutoTrade.AutoSize = true;
			this.btnAutoTrade.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnAutoTrade.BackColor = Color.Transparent;
			this.btnAutoTrade.FlatAppearance.BorderSize = 0;
			this.btnAutoTrade.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnAutoTrade.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnAutoTrade.FlatStyle = FlatStyle.Flat;
			this.btnAutoTrade.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnAutoTrade.ForeColor = Color.LightGray;
			this.btnAutoTrade.Location = new Point(220, 1);
			this.btnAutoTrade.Name = "btnAutoTrade";
			this.btnAutoTrade.Padding = new Padding(1, 0, 1, 0);
			this.btnAutoTrade.Size = new Size(78, 25);
			this.btnAutoTrade.TabIndex = 18;
			this.btnAutoTrade.Tag = "0";
			this.btnAutoTrade.Text = "Auto Trade";
			this.btnAutoTrade.TextAlign = ContentAlignment.TopCenter;
			this.btnAutoTrade.UseVisualStyleBackColor = false;
			this.btnAutoTrade.Visible = false;
			this.btnAutoTrade.Click += new EventHandler(this.Menus_Click);
			this.btnMarketInfo.AutoSize = true;
			this.btnMarketInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMarketInfo.BackColor = Color.Transparent;
			this.btnMarketInfo.FlatAppearance.BorderSize = 0;
			this.btnMarketInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMarketInfo.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnMarketInfo.FlatStyle = FlatStyle.Flat;
			this.btnMarketInfo.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnMarketInfo.ForeColor = Color.LightGray;
			this.btnMarketInfo.Location = new Point(304, 1);
			this.btnMarketInfo.Name = "btnMarketInfo";
			this.btnMarketInfo.Padding = new Padding(1, 0, 1, 0);
			this.btnMarketInfo.Size = new Size(56, 25);
			this.btnMarketInfo.TabIndex = 12;
			this.btnMarketInfo.Tag = "0";
			this.btnMarketInfo.Text = "Market";
			this.btnMarketInfo.TextAlign = ContentAlignment.TopCenter;
			this.btnMarketInfo.UseVisualStyleBackColor = false;
			this.btnMarketInfo.Click += new EventHandler(this.Menus_Click);
			this.btnPortfolio.AutoSize = true;
			this.btnPortfolio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnPortfolio.BackColor = Color.Transparent;
			this.btnPortfolio.FlatAppearance.BorderSize = 0;
			this.btnPortfolio.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPortfolio.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnPortfolio.FlatStyle = FlatStyle.Flat;
			this.btnPortfolio.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnPortfolio.ForeColor = Color.LightGray;
			this.btnPortfolio.Location = new Point(67, 1);
			this.btnPortfolio.Name = "btnPortfolio";
			this.btnPortfolio.Padding = new Padding(1, 0, 1, 0);
			this.btnPortfolio.Size = new Size(65, 25);
			this.btnPortfolio.TabIndex = 5;
			this.btnPortfolio.Tag = "0";
			this.btnPortfolio.Text = "Portfolio";
			this.btnPortfolio.TextAlign = ContentAlignment.TopCenter;
			this.btnPortfolio.UseVisualStyleBackColor = false;
			this.btnPortfolio.Click += new EventHandler(this.Menus_Click);
			this.btnViewOrder.AutoSize = true;
			this.btnViewOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnViewOrder.BackColor = Color.Transparent;
			this.btnViewOrder.FlatAppearance.BorderSize = 0;
			this.btnViewOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnViewOrder.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnViewOrder.FlatStyle = FlatStyle.Flat;
			this.btnViewOrder.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnViewOrder.ForeColor = Color.LightGray;
			this.btnViewOrder.Location = new Point(136, 1);
			this.btnViewOrder.Name = "btnViewOrder";
			this.btnViewOrder.Padding = new Padding(1, 0, 1, 0);
			this.btnViewOrder.Size = new Size(77, 25);
			this.btnViewOrder.TabIndex = 4;
			this.btnViewOrder.Tag = "0";
			this.btnViewOrder.Text = "View Order";
			this.btnViewOrder.TextAlign = ContentAlignment.TopCenter;
			this.btnViewOrder.UseVisualStyleBackColor = false;
			this.btnViewOrder.Click += new EventHandler(this.Menus_Click);
			this.btnSummary.AutoSize = true;
			this.btnSummary.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnSummary.BackColor = Color.Transparent;
			this.btnSummary.FlatAppearance.BorderSize = 0;
			this.btnSummary.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSummary.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnSummary.FlatStyle = FlatStyle.Flat;
			this.btnSummary.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnSummary.ForeColor = Color.LightGray;
			this.btnSummary.Location = new Point(369, 1);
			this.btnSummary.Name = "btnSummary";
			this.btnSummary.Size = new Size(68, 25);
			this.btnSummary.TabIndex = 2;
			this.btnSummary.Tag = "0";
			this.btnSummary.Text = "Summary";
			this.btnSummary.TextAlign = ContentAlignment.TopCenter;
			this.btnSummary.UseVisualStyleBackColor = false;
			this.btnSummary.Click += new EventHandler(this.Menus_Click);
			this.btnMarketWatch.AutoSize = true;
			this.btnMarketWatch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMarketWatch.BackColor = Color.FromArgb(30, 30, 30);
			this.btnMarketWatch.FlatAppearance.BorderSize = 0;
			this.btnMarketWatch.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMarketWatch.FlatAppearance.MouseOverBackColor = Color.Gray;
			this.btnMarketWatch.FlatStyle = FlatStyle.Flat;
			this.btnMarketWatch.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnMarketWatch.ForeColor = Color.LightGray;
			this.btnMarketWatch.Location = new Point(3, 1);
			this.btnMarketWatch.Name = "btnMarketWatch";
			this.btnMarketWatch.Padding = new Padding(1, 0, 1, 0);
			this.btnMarketWatch.Size = new Size(57, 25);
			this.btnMarketWatch.TabIndex = 0;
			this.btnMarketWatch.Tag = "1";
			this.btnMarketWatch.Text = "My List";
			this.btnMarketWatch.TextAlign = ContentAlignment.TopCenter;
			this.btnMarketWatch.UseVisualStyleBackColor = false;
			this.btnMarketWatch.Click += new EventHandler(this.Menus_Click);
			this.timerMonitorFeed.Interval = 6000;
			this.timerMonitorFeed.Tick += new EventHandler(this.timerMonitorFeed_Tick);
			this.timer1.Interval = 1000;
			this.timer1.Tick += new EventHandler(this.timer1_Tick);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(61, 4);
			this.contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(1153, 564);
			base.Controls.Add(this.panelMenu);
			base.Controls.Add(this.panelDockR);
			base.Controls.Add(this.panelSep);
			base.Controls.Add(this.panBottom);
			base.Controls.Add(this.panelTop);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Name = "frmMain";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Trading Workstation";
			base.Load += new EventHandler(this.frmMain_Load);
			base.SizeChanged += new EventHandler(this.frmMain_SizeChanged);
			base.KeyUp += new KeyEventHandler(this.frmMain_KeyUp);
			base.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
			base.KeyDown += new KeyEventHandler(this.frmMain_KeyDown);
			this.panBottom.ResumeLayout(false);
			this.panelTop.ResumeLayout(false);
			((ISupportInitialize)this.picBrokerLogo).EndInit();
			((ISupportInitialize)this.pici2Logo).EndInit();
			this.panelControlDockR.ResumeLayout(false);
			this.panelDockR.ResumeLayout(false);
			this.panelMenu.ResumeLayout(false);
			this.panelMenu.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400019E RID: 414
		private FeedsWebProxy feedsWebProxy;

		// Token: 0x0400019F RID: 415
		private System.Timers.Timer timerHeartBeat;

		// Token: 0x040001A0 RID: 416
		private bool _isResizeMDNext;

		// Token: 0x040001A1 RID: 417
		private Ipports ipwIPPortMain;

		// Token: 0x040001A2 RID: 418
		private frmAlertDetail _alertDetailForm;

		// Token: 0x040001A3 RID: 419
		private frmSystemOption _systemOptionForm;

		// Token: 0x040001A4 RID: 420
		private BackgroundWorker bgwLoadProfile;

		// Token: 0x040001A5 RID: 421
		private BackgroundWorker bgwLogout;

		// Token: 0x040001A6 RID: 422
		private bool _isCheckHBworking;

		// Token: 0x040001A7 RID: 423
		private BroadcastMessageFactory _bcMessageFactory;

		// Token: 0x040001A8 RID: 424
		private bool _isForceLogout;

		// Token: 0x040001A9 RID: 425
		private bool _isExpire;

		// Token: 0x040001AA RID: 426
		private int _connectionPullCounter;

		// Token: 0x040001AB RID: 427
		private DateTime _lastEcho;

		// Token: 0x040001AC RID: 428
		private bool _isPushConnected;

		// Token: 0x040001AD RID: 429
		private string param;

		// Token: 0x040001AE RID: 430
		private frmSplash splashForm;

		// Token: 0x040001AF RID: 431
		private PowerModes _powerMode;

		// Token: 0x040001B0 RID: 432
		private System.Windows.Forms.Timer timmerStartBC;

		// Token: 0x040001B1 RID: 433
		private bool isTerminate;

		// Token: 0x040001B2 RID: 434
		private bool _IsOpeningTemplate;

		// Token: 0x040001B3 RID: 435
		private DateTime _OpenTemplateLastTime;

		// Token: 0x040001B4 RID: 436
		private string _lastTemplate;

		// Token: 0x040001B5 RID: 437
		private System.Windows.Forms.Timer tmBottomClientResize;

		// Token: 0x040001B6 RID: 438
		private int _bTop;

		// Token: 0x040001B7 RID: 439
		private bool _isPanelSepResize;

		// Token: 0x040001B8 RID: 440
		private Form _formRS;

		// Token: 0x040001B9 RID: 441
		private Rectangle _screenRectangle;

		// Token: 0x040001BA RID: 442
		private int _slideType;

		// Token: 0x040001BB RID: 443
		private Queue<string> _qMessage;

		// Token: 0x040001BC RID: 444
		private bool _isRunPeekQ;

		// Token: 0x040001BD RID: 445
		private bool _isPeekQWorking;

		// Token: 0x040001BE RID: 446
		private frmStopDisclaimer _frmStopDisclaimer;

		// Token: 0x040001BF RID: 447
		private IContainer components;

		// Token: 0x040001C0 RID: 448
		private System.Windows.Forms.Timer timerCallLoginForm;

		// Token: 0x040001C1 RID: 449
		private ucBroadcastMessage BroadcastMessageBox;

		// Token: 0x040001C2 RID: 450
		private Panel panBottom;

		// Token: 0x040001C3 RID: 451
		private System.Windows.Forms.Timer timerGetOrderInfo;

		// Token: 0x040001C4 RID: 452
		private Button btnResizeMD1;

		// Token: 0x040001C5 RID: 453
		private Panel panelSep;

		// Token: 0x040001C6 RID: 454
		private ucViewOrder ViewOrderBox;

		// Token: 0x040001C7 RID: 455
		public ucSendNewOrder SendOrderBox;

		// Token: 0x040001C8 RID: 456
		private Panel panelTop;

		// Token: 0x040001C9 RID: 457
		private Button btnLogout;

		// Token: 0x040001CA RID: 458
		private PictureBox pici2Logo;

		// Token: 0x040001CB RID: 459
		private ToolTip toolTip1;

		// Token: 0x040001CC RID: 460
		private Panel panelControlDockR;

		// Token: 0x040001CD RID: 461
		private Panel panelDockR;

		// Token: 0x040001CE RID: 462
		private ucTickerSlide TickerSlideBox;

		// Token: 0x040001CF RID: 463
		private Button btnShowTickerSlide;

		// Token: 0x040001D0 RID: 464
		private Panel panelMenu;

		// Token: 0x040001D1 RID: 465
		private Button btnPortfolio;

		// Token: 0x040001D2 RID: 466
		private Button btnViewOrder;

		// Token: 0x040001D3 RID: 467
		private Button btnSummary;

		// Token: 0x040001D4 RID: 468
		private Button btnMarketWatch;

		// Token: 0x040001D5 RID: 469
		private Button btnMarketInfo;

		// Token: 0x040001D6 RID: 470
		private System.Windows.Forms.Timer timerMonitorFeed;

		// Token: 0x040001D7 RID: 471
		private Button btnOptions2;

		// Token: 0x040001D8 RID: 472
		private ucSmart1Click Smart1ClickBox;

		// Token: 0x040001D9 RID: 473
		private Button btnShowSpeedOrderSlide;

		// Token: 0x040001DA RID: 474
		private ucIndexBox SETBox;

		// Token: 0x040001DB RID: 475
		private ucIndexBox SET2Box;

		// Token: 0x040001DC RID: 476
		private ucIndexBox SectorBox;

		// Token: 0x040001DD RID: 477
		private ucMarketStateBox MarketStateBox;

		// Token: 0x040001DE RID: 478
		private Button btnFacebook;

		// Token: 0x040001DF RID: 479
		private System.Windows.Forms.Timer timer1;

		// Token: 0x040001E0 RID: 480
		private Button btnAutoTrade;

		// Token: 0x040001E1 RID: 481
		private PictureBox picBrokerLogo;

		// Token: 0x040001E2 RID: 482
		private ContextMenuStrip contextMenuStrip1;

		// Token: 0x040001E3 RID: 483
		private Button btnMore;

		// Token: 0x040001E4 RID: 484
		private Button btnFinance;

		// Token: 0x040001E5 RID: 485
		private Button btnGraph;

		// Token: 0x040001E6 RID: 486
		private Button btnNews;

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x0600030A RID: 778
		internal delegate void OnMessageRecievedEventHendler(IBroadcastMessage message, StockList.StockInformation stockInfo);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x0600030E RID: 782
		internal delegate void OnMessageTfexRecievedEventHendler(IBroadcastMessage message, SeriesList.SeriesInformation seriesInfo);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000312 RID: 786
		private delegate void OnAlertCallback(AlertItem e);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000316 RID: 790
		private delegate void showSpashFormCallBack(string message);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600031A RID: 794
		private delegate void LogoutCallBack(bool isForce);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600031E RID: 798
		private delegate void DisplayMessageBoxCallBack(string message);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000322 RID: 802
		private delegate void SetTopPanelActiveCallBack(bool isStart);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000326 RID: 806
		private delegate void RegistrationToTunnelCallBack();

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x0600032A RID: 810
		private delegate void UpdateAutoCompleteCallBack(string symbol);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600032E RID: 814
		private delegate void ShowStopDisclaimerCallBack();
	}
}
