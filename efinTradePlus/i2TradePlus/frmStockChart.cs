using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using EO.WebBrowser;
using EO.WebBrowser.WinForm;
using i2TradePlus.Information;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using ITSNet.Common.BIZ.RealtimeMessage.TFEX;

namespace i2TradePlus
{
	// Token: 0x020000C9 RID: 201
	public class frmStockChart : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x06000927 RID: 2343 RVA: 0x000B69A0 File Offset: 0x000B4DA0
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

		// Token: 0x06000928 RID: 2344 RVA: 0x000B69F0 File Offset: 0x000B4DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tslbStock = new ToolStripLabel();
			this.tstbStock = new ToolStripComboBox();
			this.tStripMenu = new ToolStrip();
			this.tsbtnChart = new ToolStripButton();
			this.tsbtnFinance = new ToolStripButton();
			this.tsbtnNews = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.tsbtnMyPort = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.tslbFav = new ToolStripLabel();
			this.tsbtnFav1 = new ToolStripButton();
			this.tsbtnFav2 = new ToolStripButton();
			this.tsbtnFav3 = new ToolStripButton();
			this.tsbtnFav4 = new ToolStripButton();
			this.tsbtnFav5 = new ToolStripButton();
			this.tsbtnPeriod = new ToolStripButton();
			this.tsbtnDraw = new ToolStripButton();
			this.tsbtnIndicator = new ToolStripButton();
			this.tsbtbPS = new ToolStripButton();
			this.webView1 = new WebView();
			this.webControl1 = new WebControl();
			this.tStripMenu.SuspendLayout();
			base.SuspendLayout();
			this.tslbStock.BackColor = Color.Transparent;
			this.tslbStock.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tslbStock.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tslbStock.ForeColor = Color.Gainsboro;
			this.tslbStock.ImageTransparentColor = Color.Magenta;
			this.tslbStock.Margin = new Padding(5, 1, 0, 2);
			this.tslbStock.Name = "tslbStock";
			this.tslbStock.Padding = new Padding(1, 0, 2, 0);
			this.tslbStock.Size = new Size(44, 20);
			this.tslbStock.Text = "Symbol";
			this.tstbStock.BackColor = Color.FromArgb(45, 45, 45);
			this.tstbStock.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tstbStock.ForeColor = Color.Yellow;
			this.tstbStock.Name = "tstbStock";
			this.tstbStock.Size = new Size(100, 23);
			this.tstbStock.SelectedIndexChanged += new EventHandler(this.tstbStock_SelectedIndexChanged);
			this.tstbStock.KeyUp += new KeyEventHandler(this.tstbStock_KeyUp);
			this.tstbStock.KeyDown += new KeyEventHandler(this.tstbStock_KeyDown);
			this.tstbStock.KeyPress += new KeyPressEventHandler(this.tstbStock_KeyPress);
			this.tStripMenu.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripMenu.BackgroundImageLayout = ImageLayout.None;
			this.tStripMenu.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.tslbStock,
				this.tstbStock,
				this.tsbtnChart,
				this.tsbtnFinance,
				this.tsbtnNews,
				this.toolStripSeparator2,
				this.tsbtnMyPort,
				this.toolStripSeparator1,
				this.tslbFav,
				this.tsbtnFav1,
				this.tsbtnFav2,
				this.tsbtnFav3,
				this.tsbtnFav4,
				this.tsbtnFav5,
				this.tsbtnPeriod,
				this.tsbtnDraw,
				this.tsbtnIndicator,
				this.tsbtbPS
			});
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Padding = new Padding(0, 2, 1, 3);
			this.tStripMenu.RenderMode = ToolStripRenderMode.System;
			this.tStripMenu.Size = new Size(779, 28);
			this.tStripMenu.TabIndex = 51;
			this.tStripMenu.KeyDown += new KeyEventHandler(this.tstbStock_KeyDown);
			this.tsbtnChart.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnChart.ForeColor = Color.Gainsboro;
			this.tsbtnChart.ImageTransparentColor = Color.Magenta;
			this.tsbtnChart.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnChart.Name = "tsbtnChart";
			this.tsbtnChart.Size = new Size(40, 20);
			this.tsbtnChart.Text = "Chart";
			this.tsbtnChart.Visible = false;
			this.tsbtnChart.Click += new EventHandler(this.tsbtnChart_Click);
			this.tsbtnFinance.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnFinance.ForeColor = Color.LightGray;
			this.tsbtnFinance.ImageTransparentColor = Color.Magenta;
			this.tsbtnFinance.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnFinance.Name = "tsbtnFinance";
			this.tsbtnFinance.Size = new Size(52, 20);
			this.tsbtnFinance.Text = "Finance";
			this.tsbtnFinance.Visible = false;
			this.tsbtnFinance.Click += new EventHandler(this.tsbtnFinance_Click);
			this.tsbtnNews.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnNews.ForeColor = Color.LightGray;
			this.tsbtnNews.ImageTransparentColor = Color.Magenta;
			this.tsbtnNews.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnNews.Name = "tsbtnNews";
			this.tsbtnNews.Size = new Size(40, 20);
			this.tsbtnNews.Text = "News";
			this.tsbtnNews.Visible = false;
			this.tsbtnNews.Click += new EventHandler(this.tsbtnNews_Click);
			this.toolStripSeparator2.ForeColor = SystemColors.ControlText;
			this.toolStripSeparator2.Margin = new Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 23);
			this.toolStripSeparator2.Visible = false;
			this.tsbtnMyPort.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnMyPort.ForeColor = Color.LightGray;
			this.tsbtnMyPort.ImageTransparentColor = Color.Magenta;
			this.tsbtnMyPort.Name = "tsbtnMyPort";
			this.tsbtnMyPort.Size = new Size(53, 20);
			this.tsbtnMyPort.Text = "My Port";
			this.tsbtnMyPort.Click += new EventHandler(this.tsbtnMyPort_Click);
			this.toolStripSeparator1.Margin = new Padding(5, 0, 0, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 23);
			this.tslbFav.ForeColor = Color.LightGray;
			this.tslbFav.Margin = new Padding(5, 1, 0, 2);
			this.tslbFav.Name = "tslbFav";
			this.tslbFav.Size = new Size(49, 20);
			this.tslbFav.Text = "Favorite";
			this.tsbtnFav1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnFav1.ForeColor = Color.LightGray;
			this.tsbtnFav1.ImageTransparentColor = Color.Magenta;
			this.tsbtnFav1.Name = "tsbtnFav1";
			this.tsbtnFav1.Size = new Size(23, 20);
			this.tsbtnFav1.Text = "1";
			this.tsbtnFav1.Click += new EventHandler(this.tsbtnMyPort_Click);
			this.tsbtnFav2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnFav2.ForeColor = Color.LightGray;
			this.tsbtnFav2.ImageTransparentColor = Color.Magenta;
			this.tsbtnFav2.Name = "tsbtnFav2";
			this.tsbtnFav2.Size = new Size(23, 20);
			this.tsbtnFav2.Text = "2";
			this.tsbtnFav2.Click += new EventHandler(this.tsbtnMyPort_Click);
			this.tsbtnFav3.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnFav3.ForeColor = Color.LightGray;
			this.tsbtnFav3.ImageTransparentColor = Color.Magenta;
			this.tsbtnFav3.Name = "tsbtnFav3";
			this.tsbtnFav3.Size = new Size(23, 20);
			this.tsbtnFav3.Text = "3";
			this.tsbtnFav3.Click += new EventHandler(this.tsbtnMyPort_Click);
			this.tsbtnFav4.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnFav4.ForeColor = Color.LightGray;
			this.tsbtnFav4.ImageTransparentColor = Color.Magenta;
			this.tsbtnFav4.Name = "tsbtnFav4";
			this.tsbtnFav4.Size = new Size(23, 20);
			this.tsbtnFav4.Text = "4";
			this.tsbtnFav4.Click += new EventHandler(this.tsbtnMyPort_Click);
			this.tsbtnFav5.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnFav5.ForeColor = Color.LightGray;
			this.tsbtnFav5.ImageTransparentColor = Color.Magenta;
			this.tsbtnFav5.Name = "tsbtnFav5";
			this.tsbtnFav5.Size = new Size(23, 20);
			this.tsbtnFav5.Text = "5";
			this.tsbtnFav5.Click += new EventHandler(this.tsbtnMyPort_Click);
			this.tsbtnPeriod.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnPeriod.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnPeriod.ForeColor = Color.LightGray;
			this.tsbtnPeriod.ImageTransparentColor = Color.Magenta;
			this.tsbtnPeriod.Name = "tsbtnPeriod";
			this.tsbtnPeriod.Size = new Size(45, 20);
			this.tsbtnPeriod.Text = "Period";
			this.tsbtnPeriod.Click += new EventHandler(this.tsbtnPeriod_Click);
			this.tsbtnDraw.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnDraw.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnDraw.ForeColor = Color.LightGray;
			this.tsbtnDraw.ImageTransparentColor = Color.Magenta;
			this.tsbtnDraw.Name = "tsbtnDraw";
			this.tsbtnDraw.Size = new Size(38, 20);
			this.tsbtnDraw.Text = "Draw";
			this.tsbtnDraw.Click += new EventHandler(this.tsbtnDraw_Click);
			this.tsbtnIndicator.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnIndicator.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnIndicator.ForeColor = Color.LightGray;
			this.tsbtnIndicator.ImageTransparentColor = Color.Magenta;
			this.tsbtnIndicator.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnIndicator.Name = "tsbtnIndicator";
			this.tsbtnIndicator.Size = new Size(58, 20);
			this.tsbtnIndicator.Text = "Indicator";
			this.tsbtnIndicator.Click += new EventHandler(this.tsbtnIndicator_Click);
			this.tsbtbPS.Alignment = ToolStripItemAlignment.Right;
			this.tsbtbPS.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtbPS.ForeColor = Color.LightGray;
			this.tsbtbPS.ImageTransparentColor = Color.Magenta;
			this.tsbtbPS.Name = "tsbtbPS";
			this.tsbtbPS.Size = new Size(24, 20);
			this.tsbtbPS.Text = "PS";
			this.tsbtbPS.Click += new EventHandler(this.tsbtbPS_Click);
			this.webControl1.BackColor = Color.White;
			this.webControl1.Dock = DockStyle.Fill;
			this.webControl1.Location = new Point(0, 28);
			this.webControl1.Name = "webControl1";
			this.webControl1.Size = new Size(779, 355);
			this.webControl1.TabIndex = 53;
			this.webControl1.Text = "webControl1";
			this.webControl1.WebView = this.webView1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(25, 25, 25);
			base.ClientSize = new Size(779, 383);
			base.Controls.Add(this.webControl1);
			base.Controls.Add(this.tStripMenu);
			base.FormBorderStyle = FormBorderStyle.Sizable;
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "frmStockChart";
			this.Text = "eFin Tools";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmStockHistory_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmStockHistory_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmStockHistory_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmStockHistory_IDoCustomSizeChanged);
			base.IDoSymbolLinked += new ClientBaseForm.OnSymbolLinkEventHandler(this.frmStockChart_IDoSymbolLinked);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmStockHistory_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmStockHistory_IDoReActivated);
			base.Controls.SetChildIndex(this.tStripMenu, 0);
			base.Controls.SetChildIndex(this.webControl1, 0);
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000B7808 File Offset: 0x000B5C08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmStockChart() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwReloadData = null;
			this._currSymbol = string.Empty;
			this._firstLoad = true;
			this._currPage = string.Empty;
			this._currSubPage = string.Empty;
			this._myPort = string.Empty;
			this._myFav = string.Empty;
			this._isLoading = false;
			this._canRecv = false;
			this._isSetChartParam = false;
			
			this.InitializeComponent();
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000B789C File Offset: 0x000B5C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmStockChart(Dictionary<string, object> propertiesValue, string currentPage) : base(propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwReloadData = null;
			this._currSymbol = string.Empty;
			this._firstLoad = true;
			this._currPage = string.Empty;
			this._currSubPage = string.Empty;
			this._myPort = string.Empty;
			this._myFav = string.Empty;
			this._isLoading = false;
			this._canRecv = false;
			this._isSetChartParam = false;
			
			this._currPage = currentPage;
			this.InitializeComponent();
			try
			{
				if (!base.DesignMode)
				{
					this.webControl1.WebView.LoadCompleted -= new LoadCompletedEventHandler(this.WebView_LoadCompleted);
					this.webControl1.WebView.LoadCompleted += new LoadCompletedEventHandler(this.WebView_LoadCompleted);
					this.webControl1.WebView.NewWindow -= new NewWindowHandler(this.WebView_NewWindow);
					this.webControl1.WebView.NewWindow += new NewWindowHandler(this.WebView_NewWindow);
					if (this.bgwReloadData == null)
					{
						this.bgwReloadData = new BackgroundWorker();
						this.bgwReloadData.WorkerReportsProgress = true;
						this.bgwReloadData.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
						this.bgwReloadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
					}
				}
				Runtime.AddLicense("RfYZ8p7cwp61n1mXpM0M66Xm+8+4iVmXpLHLn1mXwPIP41nr/QEQvFu807/u56vm8fbNn6/c9gQU7qe0psLgrWmZpMDpjEOXpLHLu2jY8P0a9neEjrHLn1mz8wMP5KvA8vcan53Y+PbooW6mtcrasWmoubPL8q7ZyQkb6Kvc99IfvFuss8LkrmuntcfNn6/c9gQU7qe0psPNn2i1kZvLn1mXwAQU5qfY+AYd5Hew3MABtZK71QjuzmTGzwQfzWjN+PoSvHazswQU5qfY+AYd5HeEjs3a66La6f8e5HeEjnXj7fQQ7azcwp61n1mXpM0X6Jzc8gQQyJ21u8Lkr2mvucPhsHWm8PoO5Kfq6doPvUaBpLHLn3Xj7fQQ7azc6c/nrqXg5w==");
				if (ApplicationInfo.IsSupportEfinChart)
				{
					this.webControl1.Visible = true;
				}
				if (!base.DesignMode)
				{
					this.tstbStock.Items.AddRange(ApplicationInfo.StockAutoCompStringArr);
					this.tstbStock.Sorted = true;
					this.tstbStock.AutoCompleteMode = AutoCompleteMode.Suggest;
					this.tstbStock.AutoCompleteSource = AutoCompleteSource.ListItems;
				}
				this.tsbtnMyPort.Visible = false;
				this.tslbFav.Visible = false;
				this.toolStripSeparator2.Visible = false;
				this.tsbtnMyPort.Visible = false;
				this.tsbtnFav1.Visible = false;
				this.tsbtnFav2.Visible = false;
				this.tsbtnFav3.Visible = false;
				this.tsbtnFav4.Visible = false;
				this.tsbtnFav5.Visible = false;
			}
			catch (Exception ex)
			{
				this.ShowError("frmStockChart", ex);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000B7B3C File Offset: 0x000B5F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebView_NewWindow(object sender, NewWindowEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Process.Start(e.TargetUrl);
			}
			catch (Exception ex)
			{
				this.ShowError("WebView_NewWindow", ex);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000B7B94 File Offset: 0x000B5F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Dictionary<string, object> DoPackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SaveTemplate();
			base.PropertiesValue.Clear();
			return base.PropertiesValue;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000B7BD0 File Offset: 0x000B5FD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DoUnpackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.PropertiesValue != null)
			{
				if (base.PropertiesValue.ContainsKey("SubPage"))
				{
					this._currPage = base.PropertiesValue["SubPage"].ToString();
				}
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000B7C34 File Offset: 0x000B6034
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockHistory_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetResize(true);
			base.Show();
			base.OpenedForm();
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000B7C5C File Offset: 0x000B605C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockHistory_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsSupportEfinChart)
				{
					if (this._firstLoad)
					{
						ApplicationInfo.WebService.ClearEfinSession(ApplicationInfo.UserEfin);
					}
					if (!string.IsNullOrEmpty(ApplicationInfo.UserEfin))
					{
						if (ApplicationInfo.CurrentSymbol != string.Empty)
						{
							this.tstbStock.Text = ApplicationInfo.CurrentSymbol;
						}
						if (this._currPage != string.Empty)
						{
							this.SetPage(this._currPage, true);
						}
						else
						{
							this.SetPage("CHART", true);
						}
					}
					else
					{
						this.ShowError("StockChart", new Exception("eFin user is empty!!!"));
						this.webControl1.Visible = false;
						MessageBox.Show("eFin user is empty!!!");
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmStockHistory_IDoLoadData", ex);
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000B7D84 File Offset: 0x000B6184
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockHistory_IDoCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this._isLoading)
			{
				this.SetResize(this.IsWidthChanged | this.IsHeightChanged);
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000B7DC4 File Offset: 0x000B61C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockHistory_IDoFontChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this._isLoading)
			{
				this.SetResize(true);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000B7DF8 File Offset: 0x000B61F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockHistory_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this._isLoading)
			{
				if (ApplicationInfo.IsSupportEfinChart)
				{
					this.SetResize(true);
					base.Show();
					this.SetNewStock(ApplicationInfo.CurrentSymbol);
				}
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000B7E54 File Offset: 0x000B6254
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockHistory_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Space)
			{
				switch (keyCode)
				{
				}
			}
			else
			{
				this.tstbStock.Focus();
				this.tstbStock.SelectAll();
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000B7EBC File Offset: 0x000B62BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockChart_IDoSymbolLinked(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (source == SymbolLinkSource.SwitchAccount)
			{
				if (this._currPage == "NEWS")
				{
					this.ReloadData();
				}
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000B7F0C File Offset: 0x000B630C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetResize(bool isChanged)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (isChanged)
			{
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000B7F38 File Offset: 0x000B6338
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._isLoading = true;
				if (ApplicationInfo.IsSupportEfinChart)
				{
					if (this._currPage == "NEWS")
					{
						if (this._currSubPage == "MyPort")
						{
							this._myPort = ApplicationInfo.WebOrderService.GetMyPortSymbolList(ApplicationInfo.AccInfo.CurrentAccount);
							this._myPort = this._myPort.Replace("'", "");
						}
						else if (this._currSubPage == "FAV1" || this._currSubPage == "FAV2" || this._currSubPage == "FAV3" || this._currSubPage == "FAV4" || this._currSubPage == "FAV5")
						{
							int favPage = 0;
							if (this._currSubPage == "FAV1")
							{
								favPage = 1;
							}
							if (this._currSubPage == "FAV2")
							{
								favPage = 2;
							}
							if (this._currSubPage == "FAV3")
							{
								favPage = 3;
							}
							if (this._currSubPage == "FAV4")
							{
								favPage = 4;
							}
							if (this._currSubPage == "FAV5")
							{
								favPage = 5;
							}
							this._myFav = ApplicationInfo.GetFavSymbolListByPage(favPage, ApplicationInfo.FavStockPerPage);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this._isLoading = false;
				this.ShowError("bgwReloadData_DoWork", ex);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000B8134 File Offset: 0x000B6534
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsSupportEfinChart)
				{
					if (this._firstLoad)
					{
						string text = string.Empty;
						string text2 = HttpUtility.UrlEncode(this._currSymbol);
						if (this._currPage == "CHART")
						{
							this._canRecv = false;
							text = string.Concat(new string[]
							{
								ApplicationInfo.UrlEfinChart,
								"?userid=",
								ApplicationInfo.UserEfin,
								"&symbol=",
								text2,
								"&tp=1"
							});
						}
						else if (this._currPage == "FINANCE")
						{
							text = string.Concat(new string[]
							{
								ApplicationInfo.UrlEfinFinance,
								"?userid=",
								ApplicationInfo.UserEfin,
								"&websessionid=",
								ApplicationInfo.UrlEfinSession,
								"&symbol=",
								text2
							});
						}
						else if (this._currPage == "NEWS")
						{
							text = string.Concat(new string[]
							{
								ApplicationInfo.UrlEfinNews,
								"?userid=",
								ApplicationInfo.UserEfin,
								"&websessionid=",
								ApplicationInfo.UrlEfinSession,
								"&symbol=",
								text2
							});
						}
						if (text != null && this.webControl1 != null)
						{
							this.webControl1.WebView.LoadUrl(text);
						}
					}
					else if (this._currPage == "CHART")
					{
						this._canRecv = false;
						JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
						JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("changesymbol");
						object obj = jSFunction.Invoke(dOMWindow, new object[]
						{
							this._currSymbol
						});
						this._canRecv = true;
					}
					else if (this._currPage == "FINANCE")
					{
						JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
						JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("setsymbols");
						object obj = jSFunction.Invoke(dOMWindow, new object[]
						{
							this._currSymbol
						});
					}
					else if (this._currPage == "NEWS")
					{
						if (this._currSubPage == "MyPort")
						{
							JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
							JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("setsymbols");
							object obj = jSFunction.Invoke(dOMWindow, new object[]
							{
								this._myPort
							});
						}
						else if (this._currSubPage == "FAV1" || this._currSubPage == "FAV2" || this._currSubPage == "FAV3" || this._currSubPage == "FAV4" || this._currSubPage == "FAV5")
						{
							JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
							JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("setsymbols");
							object obj = jSFunction.Invoke(dOMWindow, new object[]
							{
								this._myFav
							});
						}
						else
						{
							JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
							JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("setsymbols");
							object obj = jSFunction.Invoke(dOMWindow, new object[]
							{
								this._currSymbol
							});
						}
					}
					this._firstLoad = false;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_RunWorkerCompleted", ex);
			}
			this._isLoading = false;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000B85CC File Offset: 0x000B69CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwReloadData.IsBusy)
			{
				this.bgwReloadData.RunWorkerAsync();
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000B8608 File Offset: 0x000B6A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				if (!this._isLoading)
				{
					try
					{
						if (this._canRecv && this._currPage == "CHART")
						{
							string messageType = message.MessageType;
							if (messageType != null)
							{
								if (messageType == "L+")
								{
									if (realtimeStockInfo != null && realtimeStockInfo.Symbol == this._currSymbol && !realtimeStockInfo.IsOddLot)
									{
										LSAccumulate lSAccumulate = (LSAccumulate)message;
										string text = string.Concat(new object[]
										{
											this._currSymbol,
											";",
											lSAccumulate.Side,
											";",
											lSAccumulate.LastPrice,
											";",
											lSAccumulate.Volume,
											";",
											lSAccumulate.LastTime.Replace(":", "")
										});
										JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
										JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("dataInSTI");
										object obj = jSFunction.Invoke(dOMWindow, new object[]
										{
											text
										});
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						this.ShowError("ReceiveMessage", ex);
					}
				}
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000B87E8 File Offset: 0x000B6BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				try
				{
					if (!base.IsLoadingData)
					{
						string messageType = message.MessageType;
						if (messageType != null)
						{
							if (messageType == "LS")
							{
								if (realtimeSeriesInfo.Symbol == this._currSymbol)
								{
									LSMessageTFEX lSMessageTFEX = (LSMessageTFEX)message;
									string text = string.Concat(new object[]
									{
										this._currSymbol,
										";",
										lSMessageTFEX.Side,
										";",
										lSMessageTFEX.Price,
										";",
										lSMessageTFEX.Vol,
										";",
										lSMessageTFEX.LastTime.Replace(":", "")
									});
									JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
									JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("dataInSTI");
									object obj = jSFunction.Invoke(dOMWindow, new object[]
									{
										text
									});
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ReceiveTfexMessage", ex);
				}
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000B8984 File Offset: 0x000B6D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			((Control)sender).BackColor = Color.Yellow;
			((Control)sender).ForeColor = Color.Black;
			if (sender.GetType() == typeof(TextBox))
			{
				((TextBox)sender).SelectAll();
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000B89EC File Offset: 0x000B6DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender.GetType() == typeof(CheckBox))
			{
				((Control)sender).BackColor = Color.Transparent;
				if (this.BackColor == Color.DarkGreen)
				{
					((Control)sender).ForeColor = Color.White;
				}
				else
				{
					((Control)sender).ForeColor = Color.Black;
				}
			}
			else
			{
				((Control)sender).BackColor = Color.White;
				((Control)sender).ForeColor = Color.Black;
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000B8AA4 File Offset: 0x000B6EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
			}
			catch (Exception ex)
			{
				this.ShowError("tstbStock_KeyPress", ex);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000B8B0C File Offset: 0x000B6F0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Keys keyCode = e.KeyCode;
				if (keyCode != Keys.Return)
				{
					switch (keyCode)
					{
					case Keys.Prior:
					case Keys.Next:
						break;
					default:
						switch (keyCode)
						{
						case Keys.Up:
						case Keys.Down:
							break;
						case Keys.Right:
							goto IL_64;
						default:
							goto IL_64;
						}
						break;
					}
					e.SuppressKeyPress = true;
				}
				else
				{
					e.SuppressKeyPress = true;
				}
				IL_64:;
			}
			catch (Exception ex)
			{
				this.ShowError("tstbStock_KeyDown", ex);
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000B8BAC File Offset: 0x000B6FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Keys keyCode = e.KeyCode;
				if (keyCode == Keys.Return)
				{
					this.SetNewStock(this.tstbStock.Text.Trim());
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tstbStock_KeyUp", ex);
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000B8C28 File Offset: 0x000B7028
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this._isLoading)
			{
				this.SetNewStock(this.tstbStock.Text.Trim());
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000B8C6C File Offset: 0x000B706C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetNewStock(string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tStripMenu.InvokeRequired)
			{
				this.tStripMenu.Invoke(new frmStockChart.SetNewStockInfoCallBack(this.SetNewStock), new object[]
				{
					symbol
				});
			}
			else
			{
				try
				{
					if (!this._isLoading && this._currSymbol != symbol)
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[symbol];
						if (stockInformation.Number > 0)
						{
							this._currSymbol = stockInformation.Symbol;
							this._currSubPage = string.Empty;
							if (!this._firstLoad)
							{
								this.SetPage(this._currPage, false);
							}
						}
						else
						{
							this._currSymbol = symbol;
							this._currSubPage = string.Empty;
							if (!this._firstLoad)
							{
								this.SetPage(this._currPage, false);
							}
						}
						if (this.tstbStock.Text != this._currSymbol)
						{
							this.tstbStock.Text = this._currSymbol;
						}
						this.tstbStock.Focus();
						this.tstbStock.SelectAll();
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SetNewStockInfo", ex);
				}
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000B8E00 File Offset: 0x000B7200
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnFinance_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._currPage == "CHART")
			{
				this.SaveTemplate();
			}
			this.SetPage("FINANCE", true);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000B8E4C File Offset: 0x000B724C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnChart_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetPage("CHART", true);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000B8E6C File Offset: 0x000B726C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnNews_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._currPage == "CHART")
			{
				this.SaveTemplate();
			}
			this.SetPage("NEWS", true);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000B8EB8 File Offset: 0x000B72B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPage(string newPage, bool firstLoad)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._isSetChartParam = false;
				this._currPage = newPage;
				this._firstLoad = firstLoad;
				this.tStripMenu.SuspendLayout();
				this.tsbtnFav1.Visible = (this._currPage == "NEWS");
				this.tsbtnFav2.Visible = (this._currPage == "NEWS");
				this.tsbtnFav3.Visible = (this._currPage == "NEWS");
				this.tsbtnFav4.Visible = (this._currPage == "NEWS");
				this.tsbtnFav5.Visible = (this._currPage == "NEWS");
				this.tsbtnMyPort.Visible = (this._currPage == "NEWS");
				this.tslbFav.Visible = (this._currPage == "NEWS");
				this.toolStripSeparator2.Visible = (this._currPage == "NEWS");
				this.tsbtnIndicator.Visible = (this._currPage == "CHART");
				this.tsbtbPS.Visible = (this._currPage == "CHART");
				this.tsbtnDraw.Visible = (this._currPage == "CHART");
				this.tsbtnPeriod.Visible = (this._currPage == "CHART");
				this.tsbtnChart.BackColor = ((this._currPage == "CHART") ? Color.DimGray : this.tStripMenu.BackColor);
				this.tsbtnFinance.BackColor = ((this._currPage == "FINANCE") ? Color.DimGray : this.tStripMenu.BackColor);
				this.tsbtnNews.BackColor = ((this._currPage == "NEWS") ? Color.DimGray : this.tStripMenu.BackColor);
				if (this._currPage == "NEWS")
				{
					this.tsbtnMyPort.ForeColor = ((this._currSubPage == "MyPort") ? Color.Cyan : Color.LightGray);
					this.tsbtnFav1.ForeColor = ((this._currSubPage == "FAV1") ? Color.Cyan : Color.LightGray);
					this.tsbtnFav2.ForeColor = ((this._currSubPage == "FAV2") ? Color.Cyan : Color.LightGray);
					this.tsbtnFav3.ForeColor = ((this._currSubPage == "FAV3") ? Color.Cyan : Color.LightGray);
					this.tsbtnFav4.ForeColor = ((this._currSubPage == "FAV4") ? Color.Cyan : Color.LightGray);
					this.tsbtnFav5.ForeColor = ((this._currSubPage == "FAV5") ? Color.Cyan : Color.LightGray);
					this.tstbStock.Text = ((this._currSubPage == string.Empty) ? this._currSymbol : string.Empty);
				}
				else if (this._currPage == "FINANCE")
				{
					this._isLoading = true;
					this.tstbStock.Text = this._currSymbol;
					this._isLoading = false;
				}
				this.tStripMenu.ResumeLayout();
				this.ReloadData();
			}
			catch (Exception ex)
			{
				this.ShowError("SetPage", ex);
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000B92E4 File Offset: 0x000B76E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnMyPort_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender == this.tsbtnMyPort)
			{
				this._currSubPage = "MyPort";
			}
			else if (sender == this.tsbtnFav1)
			{
				this._currSubPage = "FAV1";
			}
			else if (sender == this.tsbtnFav2)
			{
				this._currSubPage = "FAV2";
			}
			else if (sender == this.tsbtnFav3)
			{
				this._currSubPage = "FAV3";
			}
			else if (sender == this.tsbtnFav4)
			{
				this._currSubPage = "FAV4";
			}
			else if (sender == this.tsbtnFav5)
			{
				this._currSubPage = "FAV5";
			}
			this.SetPage("NEWS", false);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000B93E8 File Offset: 0x000B77E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnIndicator_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currPage == "CHART")
				{
					JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
					JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("jsinfToggleMenu");
					object obj = jSFunction.Invoke(dOMWindow, new object[]
					{
						"studies"
					});
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnIndicator_Click", ex);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x000B9498 File Offset: 0x000B7898
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtbPS_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currPage == "CHART")
				{
					JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
					JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("jsinfToggleMenu");
					object obj = jSFunction.Invoke(dOMWindow, new object[]
					{
						"menu_ps"
					});
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtbPS_Click", ex);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000B9548 File Offset: 0x000B7948
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnDraw_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
				JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("jsinfToggleMenu");
				object obj = jSFunction.Invoke(dOMWindow, new object[]
				{
					"draw"
				});
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnDraw_Click", ex);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000B95D8 File Offset: 0x000B79D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnPeriod_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
				JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("jsinfToggleMenu");
				object obj = jSFunction.Invoke(dOMWindow, new object[]
				{
					"periodicity"
				});
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnPeriod_Click", ex);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000B9668 File Offset: 0x000B7A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebView_LoadCompleted(object sender, LoadCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currPage == "CHART" && !this._isSetChartParam)
				{
					JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
					JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("setParametersSave");
					object obj = jSFunction.Invoke(dOMWindow, new object[]
					{
						Settings.Default.Template
					});
					this._isSetChartParam = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("WebView_LoadCompleted", ex);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000B9730 File Offset: 0x000B7B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaveTemplate()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currPage == "CHART")
				{
					JSObject dOMWindow = this.webControl1.WebView.GetDOMWindow();
					JSFunction jSFunction = (JSFunction)this.webControl1.WebView.EvalScript("getParametersSave");
					object obj = jSFunction.Invoke(dOMWindow, null);
					if (obj != null)
					{
						Settings.Default.Template = obj.ToString();
						Settings.Default.Save();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SaveTemplate", ex);
			}
		}

		// Token: 0x04000649 RID: 1609
		public const string CHART_PAGE = "CHART";

		// Token: 0x0400064A RID: 1610
		public const string FINANCE_PAGE = "FINANCE";

		// Token: 0x0400064B RID: 1611
		public const string NEWS_PAGE = "NEWS";

		// Token: 0x0400064C RID: 1612
		private IContainer components;

		// Token: 0x0400064D RID: 1613
		private ToolStripLabel tslbStock;

		// Token: 0x0400064E RID: 1614
		private ToolStripComboBox tstbStock;

		// Token: 0x0400064F RID: 1615
		private ToolStrip tStripMenu;

		// Token: 0x04000650 RID: 1616
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000651 RID: 1617
		private ToolStripButton tsbtnFinance;

		// Token: 0x04000652 RID: 1618
		private ToolStripButton tsbtnNews;

		// Token: 0x04000653 RID: 1619
		private ToolStripButton tsbtnMyPort;

		// Token: 0x04000654 RID: 1620
		private ToolStripButton tsbtnFav1;

		// Token: 0x04000655 RID: 1621
		private ToolStripButton tsbtnFav2;

		// Token: 0x04000656 RID: 1622
		private ToolStripButton tsbtnFav3;

		// Token: 0x04000657 RID: 1623
		private ToolStripButton tsbtnFav4;

		// Token: 0x04000658 RID: 1624
		private ToolStripButton tsbtnFav5;

		// Token: 0x04000659 RID: 1625
		private ToolStripLabel tslbFav;

		// Token: 0x0400065A RID: 1626
		private ToolStripButton tsbtnChart;

		// Token: 0x0400065B RID: 1627
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400065C RID: 1628
		private ToolStripButton tsbtnPeriod;

		// Token: 0x0400065D RID: 1629
		private ToolStripButton tsbtnDraw;

		// Token: 0x0400065E RID: 1630
		private ToolStripButton tsbtbPS;

		// Token: 0x0400065F RID: 1631
		private ToolStripButton tsbtnIndicator;

		// Token: 0x04000660 RID: 1632
		private WebView webView1;

		// Token: 0x04000661 RID: 1633
		private WebControl webControl1;

		// Token: 0x04000662 RID: 1634
		private BackgroundWorker bgwReloadData;

		// Token: 0x04000663 RID: 1635
		private string _currSymbol;

		// Token: 0x04000664 RID: 1636
		private bool _firstLoad;

		// Token: 0x04000665 RID: 1637
		private string _currPage;

		// Token: 0x04000666 RID: 1638
		private string _currSubPage;

		// Token: 0x04000667 RID: 1639
		private string _myPort;

		// Token: 0x04000668 RID: 1640
		private string _myFav;

		// Token: 0x04000669 RID: 1641
		private bool _isLoading;

		// Token: 0x0400066A RID: 1642
		private bool _canRecv;

		// Token: 0x0400066B RID: 1643
		private bool _isSetChartParam;

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x0600094E RID: 2382
		private delegate void SetNewStockInfoCallBack(string symbol);
	}
}
