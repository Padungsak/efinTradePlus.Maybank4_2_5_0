using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using ITSNet.Common.BIZ;
using ITSNet.Controls.XtWebBrowser;
using ITSNet.Controls.XtWebBrowser.UserActivityMonitor;

namespace i2TradePlus.FixForm
{
	// Token: 0x02000051 RID: 81
	public class frmBrowser : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x06000380 RID: 896 RVA: 0x0003BD44 File Offset: 0x0003A144
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.xtbNews = new XtBrowser();
			base.SuspendLayout();
			this.xtbNews.Dock = DockStyle.Fill;
			this.xtbNews.Location = new Point(0, 0);
			this.xtbNews.Name = "xtbNews";
			this.xtbNews.Size = new Size(740, 544);
			this.xtbNews.TabIndex = 0;
			this.xtbNews.Url = null;
			this.xtbNews.SearchStockClicked += new XtBrowser.SearchStockClickEventCallBack(this.xtbNews_SearchStockClicked);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(740, 544);
			base.Controls.Add(this.xtbNews);
			base.Name = "frmBrowser";
			this.Text = "frmi2Browser";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmi2Browser_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmi2Browser_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmi2Browser_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmi2Browser_IDoCustomSizeChanged);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmi2Browser_IDoReActivated);
			base.Controls.SetChildIndex(this.xtbNews, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0003BED0 File Offset: 0x0003A2D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmBrowser() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.mHotKeyId = 0;
			this.tmLoad = null;
			this._url = string.Empty;
			this._isNews = false;
			
			this.InitializeComponent();
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0003BF20 File Offset: 0x0003A320
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmBrowser(Dictionary<string, object> propertiesValue) : base(propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.mHotKeyId = 0;
			this.tmLoad = null;
			this._url = string.Empty;
			this._isNews = false;
			this.InitializeComponent();
		}

		// Token: 0x06000383 RID: 899
		[DllImport("user32.dll")]
		private static extern int FindWindow(string cls, string wndwText);

		// Token: 0x06000384 RID: 900
		[DllImport("user32.dll")]
		private static extern int ShowWindow(int hwnd, int cmd);

		// Token: 0x06000385 RID: 901
		[DllImport("user32.dll")]
		private static extern long SHAppBarMessage(long dword, int cmd);

		// Token: 0x06000386 RID: 902
		[DllImport("user32.dll")]
		private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);

		// Token: 0x06000387 RID: 903
		[DllImport("user32.dll")]
		private static extern int UnregisterHotKey(IntPtr hwnd, int id);

		// Token: 0x06000388 RID: 904 RVA: 0x0003BF74 File Offset: 0x0003A374
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RegisterGlobalHotKey(Keys hotkey, int modifiers)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.mHotKeyId += 1;
				if (this.mHotKeyId > 0)
				{
					if (frmBrowser.RegisterHotKey(base.Handle, (int)this.mHotKeyId, modifiers, (int)Convert.ToInt16(hotkey)) == 0)
					{
						MessageBox.Show("Error: " + this.mHotKeyId.ToString() + " - " + Marshal.GetLastWin32Error().ToString(), "Hot Key Registration");
					}
				}
			}
			catch
			{
				this.UnregisterGlobalHotKey();
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0003C03C File Offset: 0x0003A43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UnregisterGlobalHotKey()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			for (int i = 1; i <= (int)this.mHotKeyId; i++)
			{
				frmBrowser.UnregisterHotKey(base.Handle, i);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0003C088 File Offset: 0x0003A488
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void WndProc(ref Message m)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.WndProc(ref m);
			if (m.Msg == 786)
			{
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0003C0C8 File Offset: 0x0003A4C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RegisterGlobalHotKey()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.RegisterGlobalHotKey(Keys.F5, 0);
			this.RegisterGlobalHotKey(Keys.N, 2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0003C0F0 File Offset: 0x0003A4F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnKeyDown(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.OnKeyDown(e);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0003C10C File Offset: 0x0003A50C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.OnKeyUp(e);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0003C128 File Offset: 0x0003A528
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmi2Browser_Activated(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.RegisterGlobalHotKey();
			HookManager.KeyDown -= new KeyEventHandler(this.HookManager_KeyDown);
			HookManager.KeyDown += new KeyEventHandler(this.HookManager_KeyDown);
			HookManager.KeyUp -= new KeyEventHandler(this.HookManager_KeyUp);
			HookManager.KeyUp += new KeyEventHandler(this.HookManager_KeyUp);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0003C194 File Offset: 0x0003A594
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmi2Browser_Deactivate(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.UnregisterGlobalHotKey();
			HookManager.KeyDown -= new KeyEventHandler(this.HookManager_KeyDown);
			HookManager.KeyUp -= new KeyEventHandler(this.HookManager_KeyUp);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0003C1D0 File Offset: 0x0003A5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0003C1E4 File Offset: 0x0003A5E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenBrowser(string url)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tmLoad == null)
			{
				this.tmLoad = new Timer();
				this.tmLoad.Interval = 100;
				this.tmLoad.Tick += new EventHandler(this.tmLoad_Tick);
			}
			this._url = url;
			this.tmLoad.Stop();
			this.tmLoad.Start();
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0003C268 File Offset: 0x0003A668
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmLoad_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tmLoad.Stop();
			this.xtbNews.Navigate(this._url);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0003C298 File Offset: 0x0003A698
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmi2Browser_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState == ClientBaseForm.ClientBaseFormState.Closing)
				{
					return;
				}
				this.SetResize(true);
				base.Show();
				base.OpenedForm();
			}
			catch (Exception ex)
			{
				this.ShowError("frmi2Browser_IDoShownDelay", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0003C318 File Offset: 0x0003A718
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmi2Browser_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.CallSymbolLink(true, ApplicationInfo.NewsSymbol);
			}
			catch (Exception ex)
			{
				this.ShowError("frmi2Browser_IDoLoadData", ex);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0003C370 File Offset: 0x0003A770
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnVisibleChanged(EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.OnVisibleChanged(e);
			if (base.Visible)
			{
				this.RegisterGlobalHotKey();
				HookManager.KeyDown -= new KeyEventHandler(this.HookManager_KeyDown);
				HookManager.KeyUp -= new KeyEventHandler(this.HookManager_KeyUp);
				HookManager.KeyDown += new KeyEventHandler(this.HookManager_KeyDown);
				HookManager.KeyUp += new KeyEventHandler(this.HookManager_KeyUp);
				(base.Parent as Form).Activated -= new EventHandler(this.frmi2Browser_Activated);
				(base.Parent as Form).Activated += new EventHandler(this.frmi2Browser_Activated);
				(base.Parent as Form).Deactivate -= new EventHandler(this.frmi2Browser_Deactivate);
				(base.Parent as Form).Deactivate += new EventHandler(this.frmi2Browser_Deactivate);
			}
			else
			{
				this.UnregisterGlobalHotKey();
				HookManager.KeyDown -= new KeyEventHandler(this.HookManager_KeyDown);
				HookManager.KeyUp -= new KeyEventHandler(this.HookManager_KeyUp);
				(base.Parent as Form).Activated -= new EventHandler(this.frmi2Browser_Activated);
				(base.Parent as Form).Deactivate -= new EventHandler(this.frmi2Browser_Deactivate);
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0003C4D8 File Offset: 0x0003A8D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HookManager_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			(base.Parent as frmMain).TrigKeyDown(this, e);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0003C4FC File Offset: 0x0003A8FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HookManager_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			(base.Parent as frmMain).TrigKeyUp(this, e);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0003C520 File Offset: 0x0003A920
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmi2Browser_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged);
				base.Show();
				if (ApplicationInfo.NewsSymbol != string.Empty)
				{
					this.CallSymbolLink(this._isNews, ApplicationInfo.NewsSymbol);
				}
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0003C58C File Offset: 0x0003A98C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CallSymbolLink(bool isNews, string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._isNews = isNews;
				if (this._isNews)
				{
					if (symbol == string.Empty || symbol.ToLower() == "symbol")
					{
						this.OpenBrowser(ApplicationInfo.NewsHomeLink);
					}
					else
					{
						symbol = symbol.Replace("&", "%26");
						this.OpenBrowser(ApplicationInfo.NewsSymbolLink.Replace("XXXXX", symbol));
						ApplicationInfo.NewsSymbol = string.Empty;
					}
				}
				else if (symbol == string.Empty || symbol.ToLower() == "symbol")
				{
					this.OpenBrowser(ApplicationInfo.StockFocusHomeLink);
				}
				else
				{
					symbol = symbol.Replace("&", "%26");
					this.OpenBrowser(ApplicationInfo.StockFocusSymbolLink.Replace("XXXXX", symbol));
				}
			}
			catch (Exception ex)
			{
				this.ShowError("CallSymbolLink", ex);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0003C6E8 File Offset: 0x0003AAE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmi2Browser_IDoCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0003C720 File Offset: 0x0003AB20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmi2Browser_IDoFontChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				base.SuspendLayout();
				this.SetResize(true);
				base.ResumeLayout();
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0003C764 File Offset: 0x0003AB64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetResize(bool isChanged)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0003C7B0 File Offset: 0x0003ABB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0003C7C4 File Offset: 0x0003ABC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void xtbNews_SearchStockClicked(bool isNews, string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.CallSymbolLink(isNews, symbol);
		}

		// Token: 0x04000209 RID: 521
		private XtBrowser xtbNews;

		// Token: 0x0400020A RID: 522
		private short mHotKeyId;

		// Token: 0x0400020B RID: 523
		private Timer tmLoad;

		// Token: 0x0400020C RID: 524
		private string _url;

		// Token: 0x0400020D RID: 525
		private bool _isNews;
	}
}
