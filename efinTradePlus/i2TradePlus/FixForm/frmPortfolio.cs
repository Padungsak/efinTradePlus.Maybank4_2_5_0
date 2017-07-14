using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using STIControl;
using STIControl.CustomGrid;
using STIControl.i2Chart.Finance;
using STIControl.i2Chart.Finance.DataProvider;
using STIControl.i2Chart.Object;
using STIControl.SortTableGrid;

namespace i2TradePlus.FixForm
{
	// Token: 0x0200005B RID: 91
	public class frmPortfolio : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x00041C40 File Offset: 0x00040040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmPortfolio() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._currAccount = string.Empty;
			this._accType = string.Empty;
			this._iCommType = 0;
			this._isForceUpdate = true;
			this._isSupportCBReport = true;
			this._tradingFee = 0m;
			this._clearingFee = 0m;
			this._settlementFee = 0m;
			this._buyLimit = 0m;
			this._equity = 0m;
			this._equityTfex = 0m;
			this.bgwLoadReport = null;
			this._reportPageNo = 1;
			this._currentTop = 99999;
			this._textPrint = null;
			this._previewPrinter = null;
			this._printDocument = null;
			this._printDialog = null;
			this._PAGEPREVIEW = 0;
			this.tdsR1 = null;
			this.tdsR3 = null;
			this.tdsR8 = null;
			this.tdsNAV = null;
			this.tdsHoldChart = null;
			this.tdsTfex = null;
			this.tdsFScore = null;
			this.tdsBeta = null;
			this._isAreadyLoadNAV = false;
			this.tmReload = null;
			this._reportType = "Portfolio";
			this._subReportType = "Portfolio";
			this._frmRiskManage = null;
			this._frmTradeJournal = null;
			this._navStartDate = string.Empty;
			this._headerMessage = string.Empty;
			this.linesPrinted = 0;
			this.summaryMaper = null;
			this.linesPrinted_TFEX = 0;
			this._frmConfirm = null;
			this.components = null;
			
			this.InitializeComponent();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00041DC4 File Offset: 0x000401C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmPortfolio(Dictionary<string, object> propertiesValue) : base(propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._currAccount = string.Empty;
			this._accType = string.Empty;
			this._iCommType = 0;
			this._isForceUpdate = true;
			this._isSupportCBReport = true;
			this._tradingFee = 0m;
			this._clearingFee = 0m;
			this._settlementFee = 0m;
			this._buyLimit = 0m;
			this._equity = 0m;
			this._equityTfex = 0m;
			this.bgwLoadReport = null;
			this._reportPageNo = 1;
			this._currentTop = 99999;
			this._textPrint = null;
			this._previewPrinter = null;
			this._printDocument = null;
			this._printDialog = null;
			this._PAGEPREVIEW = 0;
			this.tdsR1 = null;
			this.tdsR3 = null;
			this.tdsR8 = null;
			this.tdsNAV = null;
			this.tdsHoldChart = null;
			this.tdsTfex = null;
			this.tdsFScore = null;
			this.tdsBeta = null;
			this._isAreadyLoadNAV = false;
			this.tmReload = null;
			this._reportType = "Portfolio";
			this._subReportType = "Portfolio";
			this._frmRiskManage = null;
			this._frmTradeJournal = null;
			this._navStartDate = string.Empty;
			this._headerMessage = string.Empty;
			this.linesPrinted = 0;
			this.summaryMaper = null;
			this.linesPrinted_TFEX = 0;
			this._frmConfirm = null;
			this.components = null;
			
			this.InitializeComponent();
			try
			{
				this.tstbStock2.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
				this.intzaCB.Height = 0;
				this.tslbStock.Visible = false;
				this.tstbStock2.Visible = false;
				this.tsbtnClearStock.Visible = false;
				this.tsbtnPrint.Visible = false;
				this.tsCbMainSelect.Items.Clear();
				this.tsCbMainSelect.Items.Add("Portfolio");
				this.tsCbMainSelect.Items.Add("Holding Chart");
				if (ApplicationInfo.SupportNAV)
				{
					this.tsCbMainSelect.Items.Add("NAV Chart");
				}
				if (ApplicationInfo.SupportPM)
				{
					this.tsCbMainSelect.Items.Add("Portfolio Management");
				}
				this.tsCbTFexMainSelect.Items.Clear();
				this.tsCbTFexMainSelect.Items.Add("Portfolio");
				if (ApplicationInfo.SupportFreewill)
				{
					this.intzaInfoHeader.Item("lbHighLimit").Text = "";
					this.intzaInfoHeader.Item("lbCustomerFlag").Visible = false;
					this.intzaInfoHeader.Item("tbCustomerFlag").Visible = false;
					this.tsbtnPrint.Visible = false;
				}
				this.bgwLoadReport = new BackgroundWorker();
				this.bgwLoadReport.WorkerReportsProgress = true;
				this.bgwLoadReport.DoWork += new DoWorkEventHandler(this.bgwLoadReport_DoWork);
				this.bgwLoadReport.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwLoadReport_RunWorkerCompleted);
				this.InitChart();
				this.tsCbMainSelect.Width = 130;
				this.tsCbSubSelect.Width = 140;
				this.tsCbTFexMainSelect.Width = 130;
				this.tsCbTFexSubSelect.Width = 140;
			}
			catch (Exception ex)
			{
				this.ShowError("frmPortfolio", ex);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0004217C File Offset: 0x0004057C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitChart()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.chart.DefaultFormulas = "MAIN#Compare(NAV)";
				this.chart.AdjustData = true;
				this.chart.ContextMenu = null;
				this.chart.Chart.FixedTime = false;
				this.chart.Skin = "History";
				DataManagerBase dataManager = new DbDataManager(DataCycleBase.DAY);
				this.chart.DataManager = dataManager;
				this.chart.CurrentDataCycle = DataCycle.Day;
				this.chart.StockRenderType = StockRenderType.Line;
				this.chart.PriceLabelFormat = "{DD} SET:{CLOSE} {Change}";
			}
			catch (Exception ex)
			{
				this.ShowError("InitChart", ex);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00042258 File Offset: 0x00040658
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPortfolio_IDoFontChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(true);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0004228C File Offset: 0x0004068C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPortfolio_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			switch (e.KeyCode)
			{
			case Keys.Left:
			case Keys.Right:
				if (this._reportType == "NAV Chart")
				{
					this.chart.HandleKeyEvent(this, e);
				}
				break;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000422F8 File Offset: 0x000406F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPortfolio_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged | this.IsHeightChanged);
				base.Show();
				this.StartReloadTimer(200, true);
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0004234C File Offset: 0x0004074C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPortfolio_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.setVisibleControl("Portfolio", "Profit/Loss");
			this.SetResize(true);
			base.Show();
			base.OpenedForm();
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00042384 File Offset: 0x00040784
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPortfolio_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.wcGraphVolume.ColorBuy = MyColor.UpColor;
				this.wcGraphVolume.ColorSell = MyColor.DownColor;
				this.wcGraphVolume.ColorNoChg = MyColor.UnChgColor;
				this.wcGraphVolume.ColorUp = MyColor.UpColor;
				this.wcGraphVolume.ColorDown = MyColor.DownColor;
				this.wcGraphVolume.ColorVolume = MyColor.UnChgColor;
				this.wcGraphVolumeSector.ColorBuy = MyColor.UpColor;
				this.wcGraphVolumeSector.ColorSell = MyColor.DownColor;
				this.wcGraphVolumeSector.ColorNoChg = MyColor.UnChgColor;
				this.wcGraphVolumeSector.ColorUp = MyColor.UpColor;
				this.wcGraphVolumeSector.ColorDown = MyColor.DownColor;
				this.wcGraphVolumeSector.ColorVolume = MyColor.UnChgColor;
				if (this._navStartDate != string.Empty)
				{
					this.tstbStartDate.Text = this._navStartDate;
				}
				else
				{
					this.tstbStartDate.Text = DateTime.Now.AddDays(-100.0).ToString("dd/MM/yyyy");
				}
				this.tstbEndDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
				this.StartReloadTimer(200, true);
			}
			catch (Exception ex)
			{
				this.ShowError("frmPortfolio_IDoLoadData", ex);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00042530 File Offset: 0x00040930
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Dictionary<string, object> DoPackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.PropertiesValue.Clear();
				base.PropertiesValue.Add("NAVStartDate", this.tstbStartDate.Text);
			}
			catch (Exception ex)
			{
				this.ShowError("MarketWatch.DoPackProperties", ex);
			}
			return base.PropertiesValue;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000425B0 File Offset: 0x000409B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DoUnpackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (base.PropertiesValue != null)
				{
					if (base.PropertiesValue.ContainsKey("NAVStartDate"))
					{
						this._navStartDate = base.PropertiesValue["NAVStartDate"].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("MarketWatch.DoUnpackProperties", ex);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00042644 File Offset: 0x00040A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPortfolio_IDoCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsHeightChanged | this.IsWidthChanged);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00042684 File Offset: 0x00040A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState == ClientBaseForm.ClientBaseFormState.Showed)
			{
				string messageType = message.MessageType;
				if (messageType != null)
				{
					if (messageType == "0I")
					{
						OrderInfoClient orderInfoClient = (OrderInfoClient)message;
						if (orderInfoClient.Account == ApplicationInfo.AccInfo.CurrentAccount)
						{
							this.StartReloadTimer(1500, false);
						}
					}
				}
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00042714 File Offset: 0x00040B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState == ClientBaseForm.ClientBaseFormState.Showed)
			{
				string messageType = message.MessageType;
				if (messageType != null)
				{
					if (messageType == "#T9I")
					{
						OrderTFEXInfoClient orderTFEXInfoClient = (OrderTFEXInfoClient)message;
						if (orderTFEXInfoClient.Account == ApplicationInfo.AccInfo.CurrentAccount)
						{
							this.StartReloadTimer(1500, false);
						}
					}
				}
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000427A4 File Offset: 0x00040BA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartReloadTimer(int interval, bool isRequest)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmPortfolio.StartReloadTimerCallBack(this.StartReloadTimer), new object[]
				{
					interval,
					isRequest
				});
			}
			else
			{
				try
				{
					this._isForceUpdate = isRequest;
					if (this.tmReload == null)
					{
						this.tmReload = new Timer();
						this.tmReload.Tick += new EventHandler(this.tmReload_Tick);
					}
					this.tmReload.Enabled = false;
					this.tmReload.Interval = interval;
					this.tmReload.Enabled = true;
				}
				catch (Exception ex)
				{
					this.ShowError("StartReloadTimer", ex);
				}
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0004289C File Offset: 0x00040C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmReload_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tmReload.Enabled = false;
				this._currAccount = ApplicationInfo.AccInfo.CurrentAccount;
				if (this._currAccount != string.Empty)
				{
					this.ReportClick(this._reportType, this._subReportType);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tmReload_Tick", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0004293C File Offset: 0x00040D3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetResize(bool isChanged)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (isChanged)
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					this.panelSET.SetBounds(0, 0, base.Width, base.Height);
					if (this.intzaInfoHeader.Font != Settings.Default.Default_Font)
					{
						this.intzaInfoHeader.Font = Settings.Default.Default_Font;
					}
					this.intzaInfoHeader.SetBounds(1, this.tStripMain.Bottom + 1, base.Width - 2, this.intzaInfoHeader.MyBottom + 3);
					int bottom = this.intzaInfoHeader.Bottom;
					if (this._reportType == "Portfolio")
					{
						this.panelReportMenu.SetBounds(0, bottom + 1, base.Width, this.tStripMain.Height + 1);
						if (this._subReportType == "Profit/Loss" || this._subReportType == "Confrim by Stock" || this._subReportType == "Realize Profit/Loss" || this._subReportType == "Confrim Summary")
						{
							if (this._subReportType == "Profit/Loss")
							{
								this.intzaSumReport.Height = this.intzaSumReport.GetHeightByRows(1);
								this.intzaReport.SetBounds(1, this.panelReportMenu.Bottom + 1, base.Width - 2, base.Height - (this.intzaSumReport.Height + 1) - (this.panelReportMenu.Bottom + 1) - 1);
								this.intzaSumReport.SetBounds(0, this.intzaReport.Bottom + 1, this.intzaReport.Width, this.intzaSumReport.Height);
							}
							else
							{
								this.intzaReport.SetBounds(1, this.panelReportMenu.Bottom + 1, base.Width - 2, base.Height - (this.panelReportMenu.Bottom + 1) - 1);
							}
							if (this.intzaReport.Font != Settings.Default.Default_Font)
							{
								this.intzaReport.Font = new Font(Settings.Default.Default_Font.Name, Settings.Default.Default_Font.Size - 1f);
								this.intzaSumReport.Font = this.intzaReport.Font;
							}
						}
						else if (this._subReportType == "Credit Balance")
						{
							if (ApplicationInfo.SupportFreewill)
							{
								this.intzaCB_Freewill.Font = Settings.Default.Default_Font;
								this.intzaCB_Freewill.SetBounds(0, this.panelReportMenu.Bottom + 1, this.intzaInfoHeader.Width, base.ClientSize.Height - this.panelReportMenu.Bottom - 1);
							}
							else
							{
								this.intzaCB.Font = Settings.Default.Default_Font;
								this.intzaCB.SetBounds(0, this.panelReportMenu.Bottom + 1, this.intzaInfoHeader.Width, base.ClientSize.Height - this.panelReportMenu.Bottom - 1);
							}
						}
					}
					else if (this._reportType == "Portfolio Management")
					{
						if (this._subReportType == "Risk Management")
						{
							this._frmRiskManage.SetBounds(1, bottom + 1, base.Width - 2, base.Height - (bottom + 1));
							this._frmRiskManage.SetResize();
						}
						else
						{
							this.intzaSumReport.Height = this.intzaSumReport.GetHeightByRows(1);
							this.intzaReport.SetBounds(1, bottom + 1, base.Width - 2, base.Height - (this.intzaSumReport.Height + 1) - (bottom + 1) - 1);
							this.intzaSumReport.SetBounds(0, this.intzaReport.Bottom + 1, this.intzaReport.Width, this.intzaSumReport.Height);
						}
					}
					else if (this._reportType == "Holding Chart")
					{
						int num = base.Height - bottom - 2;
						this.wcGraphVolume.SetBounds(0, bottom + 1, base.Width, num / 2);
						this.wcGraphVolumeSector.SetBounds(this.wcGraphVolume.Left, this.wcGraphVolume.Bottom, this.wcGraphVolume.Width, this.wcGraphVolume.Height);
					}
					else if (this._reportType == "NAV Chart")
					{
						this.panelNav.SetBounds(0, bottom + 1, base.Width, base.Height - bottom - 2);
					}
				}
				else
				{
					this.panelTFEXPort.SetBounds(0, 0, base.Width, base.Height);
					if (this._subReportType == "Risk Management")
					{
						int bottom = this.intzaCustHeadTfex.Bottom;
						this._frmRiskManage.SetBounds(1, bottom + 1, base.Width - 2, base.Height - (bottom + 1));
						this._frmRiskManage.SetResize();
					}
					else if (!(this._subReportType == "Trade Journal"))
					{
						if (this.sortGridTfex.Font.Size != Settings.Default.Default_Font.Size - 1f)
						{
							this.sortGridTfex.Font = new Font(Settings.Default.Default_Font.Name, Settings.Default.Default_Font.Size - 1f);
							this.sortGridTfexSumm.Font = this.sortGridTfex.Font;
							this.intzaCustBottTfex.Font = this.sortGridTfex.Font;
						}
						this.intzaCustHeadTfex.SetBounds(0, this.tStripMainT.Height + 1, base.Width, this.intzaCustHeadTfex.MyBottom);
						this.intzaCustBottTfex.SetBounds(0, this.intzaCustHeadTfex.Bottom + 1, this.intzaCustHeadTfex.Width, this.intzaCustBottTfex.MyBottom);
						this.sortGridTfexSumm.SetBounds(0, this.panelTFEXPort.Height - this.sortGridTfexSumm.GetHeightByRows(1), this.panelTFEXPort.Width, this.sortGridTfexSumm.GetHeightByRows(1));
						this.sortGridTfex.SetBounds(0, this.intzaCustBottTfex.Bottom + 1, base.Width, base.Height - (this.intzaCustBottTfex.Bottom + 1) - this.sortGridTfexSumm.Height - 1);
					}
				}
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00043090 File Offset: 0x00041490
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnRefreshReport_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetReportPage();
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000430A8 File Offset: 0x000414A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetReportPage()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._reportType == "Portfolio Management" && this._subReportType == "Risk Management")
			{
				if (this._frmRiskManage != null)
				{
					this._frmRiskManage.Reload(ApplicationInfo.IsEquityAccount ? this._equity : this._equityTfex);
				}
			}
			else if (!this.bgwLoadReport.IsBusy)
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					this._reportPageNo = 1;
					if (this._reportType == "NAV Chart" && this._isAreadyLoadNAV)
					{
						return;
					}
				}
				this.bgwLoadReport.RunWorkerAsync();
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000431A4 File Offset: 0x000415A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateHeaderReport()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string headerMessage = string.Empty;
				headerMessage = this.intzaReport.Columns[0].Text;
				this._headerMessage = headerMessage;
			}
			catch (Exception ex)
			{
				this.ShowError("CreateHeaderReport", ex);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00043214 File Offset: 0x00041614
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetString(string value, int maxLen, StringAlignment alignment)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			if (value.Length < maxLen)
			{
				if (alignment == StringAlignment.Near)
				{
					result = value.PadRight(maxLen, ' ');
				}
				else
				{
					result = value.PadLeft(maxLen, ' ');
				}
			}
			else
			{
				result = value;
			}
			return result;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00043278 File Offset: 0x00041678
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPrint_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.BeginInvoke(new frmPortfolio.ShowPrintDailogCallBack(this.ShowPrintDailog));
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0004329C File Offset: 0x0004169C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowPrintDailog()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._textPrint == null)
				{
					this._textPrint = new ArrayList();
				}
				else
				{
					this._textPrint.Clear();
				}
				string text = string.Empty;
				SortGrid sortGrid = this.intzaReport;
				foreach (ColumnItem current in sortGrid.Columns)
				{
					text += ((current.Alignment == StringAlignment.Near) ? current.Text.PadRight(current.Width, ' ') : current.Text.PadLeft(current.Width, ' '));
				}
				this.SetDetailHeaderText(text);
				string text2 = string.Empty;
				string text3 = string.Empty;
				for (int i = 0; i < sortGrid.Rows; i++)
				{
					foreach (ColumnItem current in sortGrid.Columns)
					{
						text3 = sortGrid.Records(i).Fields(current.Name).Text.ToString();
						if (current.ValueFormat == FormatType.Symbol && !string.IsNullOrEmpty(sortGrid.Records(i).Fields(current.Name).Tag))
						{
							text3 = text3 + " (" + sortGrid.Records(i).Fields(current.Name).Tag + ")";
						}
						text2 += ((current.Alignment == StringAlignment.Near) ? text3.PadRight(current.Width, ' ') : text3.PadLeft(current.Width, ' '));
					}
					this.AddPrintText(text2);
					text2 = string.Empty;
				}
				string empty = string.Empty;
				this._PAGEPREVIEW = 0;
				this._previewPrinter = new PrintPreviewDialog();
				this._printDocument = new PrintDocument();
				this._printDialog = new PrintDialog();
				this._printDocument.BeginPrint += new PrintEventHandler(this.OnBeginPrint);
				this._printDocument.PrintPage += new PrintPageEventHandler(this.OnPrintPage);
				this._printDocument.DocumentName = this._reportType.Substring(2);
				this._printDialog.Document = this._printDocument;
				this._previewPrinter.Document = this._printDocument;
				this._previewPrinter.ShowDialog();
			}
			catch (Exception ex)
			{
				this.ShowError("ShowPrinter", ex);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000435C8 File Offset: 0x000419C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBeginPrint(object sender, PrintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.PrintAction == PrintAction.PrintToPrinter)
			{
				if (this._printDialog.ShowDialog() == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
				this._PAGEPREVIEW = 0;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00043628 File Offset: 0x00041A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPrintPage(object sender, PrintPageEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				int num = e.MarginBounds.Left - 30;
				int num2 = e.MarginBounds.Top - 30;
				Brush brush = new SolidBrush(Color.Black);
				this._PAGEPREVIEW++;
				e.Graphics.DrawString("#Page " + this._PAGEPREVIEW, new Font("Courier New", 8f, FontStyle.Italic), Brushes.Black, (float)e.MarginBounds.Right, (float)(e.MarginBounds.Bottom + 50));
				while (this.linesPrinted < this._textPrint.Count)
				{
					e.Graphics.DrawString(this._textPrint[this.linesPrinted++].ToString(), new Font("Courier New", 8f, FontStyle.Regular), brush, (float)num, (float)num2);
					num2 += 15;
					if (num2 >= e.MarginBounds.Bottom && this.linesPrinted < this._textPrint.Count)
					{
						e.HasMorePages = true;
						return;
					}
				}
				this.linesPrinted = 0;
				e.HasMorePages = false;
			}
			catch (Exception ex)
			{
				this.ShowError("OnPrintPage", ex);
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000437DC File Offset: 0x00041BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDetailHeaderText(string columnsHeaderText)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance)
				{
					this.AddPrintText_TFEX("                            " + ApplicationInfo.GetFullNameBroker(ApplicationInfo.BrokerId));
					this.AddPrintText(DateTime.Now.ToString("MMM dd,yyyy hh:mm:ss"));
					this.AddPrintText("Customer  :  " + this._currAccount + "         NAME        : " + this.intzaInfoHeader.Item("tbCustName").Text);
					this.AddPrintText(string.Concat(new string[]
					{
						"Cust Type :  ",
						this.intzaInfoHeader.Item("tbCustomerType").Text,
						"              ",
						"Acc. Type  : ",
						this.intzaInfoHeader.Item("tbAccountType").Text,
						"   Credit Type : ",
						this.intzaInfoHeader.Item("tbCreditType").Text,
						ApplicationInfo.SupportFreewill ? "" : "  Flag : ",
						this.intzaInfoHeader.Item("tbCustomerFlag").Text
					}));
					if (ApplicationInfo.SupportFreewill)
					{
						this.AddPrintText(string.Concat(new string[]
						{
							"EE :  ",
							this.intzaInfoHeader.Item("tbBuyLimit").Text,
							"  PP. :  ",
							this.intzaInfoHeader.Item("tbHighLimit").Text,
							"  Credit Line : ",
							this.intzaInfoHeader.Item("tbCreditLine").Text,
							"  Equity : ",
							this.intzaInfoHeader.Item("tbEquity").Text
						}));
					}
					else
					{
						this.AddPrintText(string.Concat(new string[]
						{
							"Excess Equity : ",
							this.intzaCB.Item("tbExcessEquityCurrent").Text,
							"  Previous EE. : ",
							this.intzaCB.Item("tbExcessEquityPrevious").Text,
							"  Credit Line : ",
							this.intzaInfoHeader.Item("tbCreditLine").Text,
							"  Equity : ",
							this.intzaInfoHeader.Item("tbEquity").Text
						}));
					}
					if (!ApplicationInfo.SupportFreewill)
					{
						this.AddPrintText("=================================================================================================");
						this.AddPrintText(this.GetString("PREVIOUS", 25, StringAlignment.Near) + this.GetString("CURRENT", 50, StringAlignment.Near) + "\r\n");
						this.AddPrintText("=================================================================================================");
						this.AddPrintText(this.GetString("Excess Equity : ", 15, StringAlignment.Near) + this.GetString(this.intzaCB.Item("tbExcessEquityPrevious").Text, 35, StringAlignment.Near) + this.GetString("Excess Equity : ", 15, StringAlignment.Near) + this.GetString(this.intzaCB.Item("tbExcessEquityCurrent").Text, 30, StringAlignment.Near));
						this.AddPrintText(string.Concat(new string[]
						{
							this.GetString(" ", 51, StringAlignment.Near),
							this.GetString("MM : ", 1, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbMMpercentCurrent").Text, 15, StringAlignment.Near),
							this.GetString("Mark EE. : ", 10, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbMarkToEECurrent").Text, 5, StringAlignment.Near)
						}));
						this.AddPrintText(this.GetString("Equity : ", 15, StringAlignment.Near) + this.GetString(this.intzaCB.Item("tbEquityPrevious").Text, 36, StringAlignment.Near) + this.GetString("Equity : ", 15, StringAlignment.Near) + this.GetString(this.intzaCB.Item("tbEquityCurrent").Text, 30, StringAlignment.Near));
						this.AddPrintText(this.GetString("MR : ", 15, StringAlignment.Near) + this.GetString(this.intzaCB.Item("tbMRPrevious").Text, 36, StringAlignment.Near) + this.GetString("MR : ", 15, StringAlignment.Near) + this.GetString(this.intzaCB.Item("tbMRCurrent").Text, 30, StringAlignment.Near));
						this.AddPrintText(this.GetString("Asset:", 51, StringAlignment.Near) + this.GetString("Asset:", 34, StringAlignment.Near));
						this.AddPrintText(string.Concat(new string[]
						{
							this.GetString(" ", 5, StringAlignment.Near),
							this.GetString("Cash Bal.  : ", 1, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbCashBalancePrevious").Text, 15, StringAlignment.Near),
							this.GetString(" ", 18, StringAlignment.Near),
							this.GetString("Cash Bal.  : ", 1, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbCashBalanceCurrent").Text, 15, StringAlignment.Near)
						}));
						this.AddPrintText(string.Concat(new string[]
						{
							this.GetString(" ", 5, StringAlignment.Near),
							this.GetString("LMV", 11, StringAlignment.Near),
							this.GetString(":", 2, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbLmvPrevious").Text, 15, StringAlignment.Near),
							this.GetString(" ", 18, StringAlignment.Near),
							this.GetString("LMV", 11, StringAlignment.Near),
							this.GetString(":", 2, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbLmvCurrent").Text, 15, StringAlignment.Near)
						}));
						this.AddPrintText(string.Concat(new string[]
						{
							this.GetString(" ", 5, StringAlignment.Near),
							this.GetString("Collateral : ", 10, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbColleteralPrevious").Text, 15, StringAlignment.Near),
							this.GetString(" ", 18, StringAlignment.Near),
							this.GetString("Collateral : ", 10, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbColleteralCurrent").Text, 15, StringAlignment.Near)
						}));
						this.AddPrintText(this.GetString("Liabilites:", 51, StringAlignment.Near) + this.GetString("Liabilites:", 34, StringAlignment.Near));
						this.AddPrintText(string.Concat(new string[]
						{
							this.GetString(" ", 5, StringAlignment.Near),
							this.GetString("Loan", 11, StringAlignment.Near),
							this.GetString(":", 2, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbLoanPrevious").Text, 15, StringAlignment.Near),
							this.GetString(" ", 18, StringAlignment.Near),
							this.GetString("Loan", 11, StringAlignment.Near),
							this.GetString(":", 2, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbLoanCurrent").Text, 15, StringAlignment.Near)
						}));
						this.AddPrintText(string.Concat(new string[]
						{
							this.GetString(" ", 5, StringAlignment.Near),
							this.GetString("SMV", 11, StringAlignment.Near),
							this.GetString(":", 2, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbSmvPrevious").Text, 15, StringAlignment.Near),
							this.GetString(" ", 18, StringAlignment.Near),
							this.GetString("SMV", 11, StringAlignment.Near),
							this.GetString(":", 2, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbSmvCurrent").Text, 15, StringAlignment.Near)
						}));
						this.AddPrintText(string.Concat(new string[]
						{
							this.GetString("Call : ", 1, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbCallPrevious").Text, 25, StringAlignment.Near),
							this.GetString(" ", 19, StringAlignment.Near),
							this.GetString("Call : ", 1, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbCallCurrent").Text, 25, StringAlignment.Near)
						}));
						this.AddPrintText(string.Concat(new string[]
						{
							this.GetString("Force: ", 1, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbForcePrevious").Text, 25, StringAlignment.Near),
							this.GetString(" ", 19, StringAlignment.Near),
							this.GetString("Force: ", 1, StringAlignment.Near),
							this.GetString(this.intzaCB.Item("tbForceCurrent").Text, 25, StringAlignment.Near)
						}));
					}
				}
				else
				{
					this.AddPrintText_TFEX("                            " + ApplicationInfo.GetFullNameBroker(ApplicationInfo.BrokerId));
					this.AddPrintText(DateTime.Now.ToString("MMM dd,yyyy hh:mm:ss"));
					this.AddPrintText("Customer  :  " + this._currAccount + "         NAME        : " + this.intzaInfoHeader.Item("tbCustName").Text);
					this.AddPrintText(string.Concat(new string[]
					{
						"Cust Type :  ",
						this.intzaInfoHeader.Item("tbCustomerType").Text,
						"              ",
						"Credit Type : ",
						this.intzaInfoHeader.Item("tbCreditType").Text,
						"  Acc. Type  :   ",
						this._accType,
						ApplicationInfo.SupportFreewill ? "" : ("  Flag : " + this.intzaInfoHeader.Item("tbCustomerFlag").Text)
					}));
					this.AddPrintText(string.Concat(new string[]
					{
						"Buy Limit :  ",
						this.intzaInfoHeader.Item("tbBuyLimit").Text,
						"  Credit Line : ",
						this.intzaInfoHeader.Item("tbCreditLine").Text,
						"  Equity : ",
						this.intzaInfoHeader.Item("tbEquity").Text
					}));
				}
				this.AddPrintText("========================================================================================================");
				this.AddPrintText(columnsHeaderText + "\r\n");
				this.AddPrintText("========================================================================================================");
			}
			catch (Exception ex)
			{
				this.ShowError("SetDetailHeaderText", ex);
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0004430C File Offset: 0x0004270C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddPrintText(string content)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._textPrint.Add(content);
			}
			catch (Exception ex)
			{
				this.ShowError("AddPrintText", ex);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00044364 File Offset: 0x00042764
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddPrintText()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string content = string.Empty;
				for (int i = 0; i < this.intzaReport.Rows; i++)
				{
					content = this.intzaReport.Records(i).Fields("col1").Text.ToString();
					this.AddPrintText(content);
					content = string.Empty;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("AddPrintText", ex);
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00044404 File Offset: 0x00042804
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender.GetType() == typeof(ToolStripComboBox))
			{
				((ToolStripComboBox)sender).ForeColor = Color.Black;
				((ToolStripComboBox)sender).BackColor = Color.Yellow;
				((ToolStripComboBox)sender).SelectAll();
			}
			else if (sender.GetType() == typeof(ToolStripTextBox))
			{
				((ToolStripTextBox)sender).ForeColor = Color.Black;
				((ToolStripTextBox)sender).BackColor = Color.Yellow;
				((ToolStripTextBox)sender).SelectAll();
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000444C0 File Offset: 0x000428C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender.GetType() == typeof(ToolStripComboBox))
			{
				((ToolStripComboBox)sender).ForeColor = Color.Yellow;
				((ToolStripComboBox)sender).BackColor = Color.FromArgb(60, 60, 60);
				((ToolStripComboBox)sender).SelectAll();
			}
			else if (sender.GetType() == typeof(ToolStripTextBox))
			{
				((ToolStripTextBox)sender).ForeColor = Color.Yellow;
				((ToolStripTextBox)sender).BackColor = Color.FromArgb(60, 60, 60);
				((ToolStripTextBox)sender).SelectAll();
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00044588 File Offset: 0x00042988
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setVisibleControl(string reportType, string subReportType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					this._reportType = string.Empty;
					bool visible = false;
					this.tsCbMainSelect.SelectedIndexChanged -= new EventHandler(this.tsCbMainSelect_SelectedIndexChanged);
					this.tsCbSubSelect.SelectedIndexChanged -= new EventHandler(this.tsCbSubSelect_SelectedIndexChanged);
					this.tsCbSubSelect.Items.Clear();
					this.tsbtnPortManHelp.Visible = false;
					if (this._frmRiskManage != null)
					{
						this._frmRiskManage.Visible = false;
					}
					this.wcGraphVolume.Visible = false;
					this.wcGraphVolumeSector.Visible = false;
					this.intzaReport.Visible = false;
					this.intzaReport.ClearAllText();
					this.intzaSumReport.Visible = false;
					this.intzaSumReport.ClearAllText();
					this.panelReportMenu.Visible = false;
					this.intzaCB.Visible = false;
					this.intzaCB_Freewill.Visible = false;
					this.panelNav.Visible = false;
					if (reportType == "Holding Chart")
					{
						this._reportType = "Holding Chart";
						this.wcGraphVolume.Visible = true;
						this.wcGraphVolumeSector.Visible = true;
					}
					else if (reportType == "NAV Chart")
					{
						this._reportType = "NAV Chart";
						this.panelNav.Visible = true;
					}
					else if (reportType == "Portfolio")
					{
						visible = true;
						this._reportType = "Portfolio";
						this.tsCbSubSelect.Items.Add("Profit/Loss");
						this.tsCbSubSelect.Items.Add("Realize Profit/Loss");
						if (!ApplicationInfo.SupportFreewill)
						{
							this.tsCbSubSelect.Items.Add("Confrim by Stock");
						}
						this.tsCbSubSelect.Items.Add("Confrim Summary");
						if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance)
						{
							this.tsCbSubSelect.Items.Add("Credit Balance");
						}
						if (subReportType == "Credit Balance")
						{
							this._subReportType = "Credit Balance";
							if (ApplicationInfo.SupportFreewill)
							{
								this.intzaCB_Freewill.Visible = true;
								this.intzaCB_Freewill.BringToFront();
							}
							else
							{
								this.intzaCB.Visible = true;
								this.intzaCB.BringToFront();
							}
						}
						else
						{
							if (subReportType == "Confrim by Stock")
							{
								this._subReportType = "Confrim by Stock";
								this.createColumns("Confrim by Stock");
								this.panelReportMenu.Visible = true;
							}
							else if (subReportType == "Confrim Summary")
							{
								this._subReportType = "Confrim Summary";
								this.createColumns("Confrim by Stock");
								this.panelReportMenu.Visible = true;
							}
							else if (subReportType == "Realize Profit/Loss")
							{
								this._subReportType = "Realize Profit/Loss";
								this.createColumns("Realize Profit/Loss");
								this.panelReportMenu.Visible = true;
							}
							else
							{
								this._subReportType = "Profit/Loss";
								this.createColumns("Profit/Loss");
								this.intzaSumReport.Visible = true;
								this.intzaSumReport.BringToFront();
							}
							this.intzaReport.Visible = true;
							this.intzaReport.BringToFront();
						}
						this.panelReportMenu.Visible = true;
					}
					else if (reportType == "Portfolio Management")
					{
						if (string.IsNullOrEmpty(subReportType))
						{
							subReportType = "F-Score Analysis";
						}
						this._reportType = "Portfolio Management";
						this._subReportType = subReportType;
						this.tsCbSubSelect.Items.Add("F-Score Analysis");
						if (ApplicationInfo.IsAutoTradeSupport(1))
						{
							this.tsCbSubSelect.Items.Add("Beta Analysis");
						}
						if (subReportType == "Risk Management")
						{
							if (this._frmRiskManage == null)
							{
								this._frmRiskManage = new frmRiskManagement();
								this._frmRiskManage.TopLevel = false;
							}
							this._frmRiskManage.Parent = this.panelSET;
							this._frmRiskManage.Visible = true;
						}
						else
						{
							this.createColumns(this._subReportType);
							this.intzaReport.Visible = true;
							this.intzaSumReport.Visible = true;
							this.tsbtnPortManHelp.Visible = true;
							this.intzaReport.BringToFront();
						}
					}
					this.tsCbMainSelect.Text = this._reportType;
					this.tsCbSubSelect.Text = this._subReportType;
					this.tsCbSubSelect.Visible = (this.tsCbSubSelect.Items.Count > 0);
					this.panelSET.Visible = true;
					this.panelTFEXPort.Visible = false;
					this.intzaInfoHeader.EndUpdate();
					this.tslbStock.Visible = visible;
					this.tstbStock2.Visible = visible;
					this.tsbtnClearStock.Visible = visible;
					this.tsbtnPrint.Visible = visible;
					this.tsCbMainSelect.SelectedIndexChanged += new EventHandler(this.tsCbMainSelect_SelectedIndexChanged);
					this.tsCbSubSelect.SelectedIndexChanged += new EventHandler(this.tsCbSubSelect_SelectedIndexChanged);
				}
				else
				{
					this.tsCbTFexMainSelect.SelectedIndexChanged -= new EventHandler(this.tsCbTFexMainSelect_SelectedIndexChanged);
					this.tsCbTFexSubSelect.SelectedIndexChanged -= new EventHandler(this.tsCbTFexSubSelect_SelectedIndexChanged);
					this.tsCbTFexSubSelect.Items.Clear();
					if ((!(reportType == "Portfolio") || !(subReportType == "Profit/Loss")) && !(reportType == "Portfolio Management"))
					{
						reportType = "Portfolio";
						subReportType = "Profit/Loss";
					}
					if (reportType == "Portfolio Management")
					{
						reportType = "Portfolio";
						subReportType = "Profit/Loss";
					}
					this.sortGridTfex.Visible = false;
					this.sortGridTfexSumm.Visible = false;
					this.intzaCustBottTfex.Visible = false;
					if (this._frmRiskManage != null)
					{
						this._frmRiskManage.Visible = false;
					}
					if (this._frmTradeJournal != null)
					{
						this._frmTradeJournal.Visible = false;
					}
					if (reportType == "Portfolio")
					{
						this.tsCbTFexSubSelect.Items.Add("Profit/Loss");
						this.sortGridTfex.Visible = true;
						this.sortGridTfexSumm.Visible = true;
						this.intzaCustBottTfex.Visible = true;
					}
					else if (reportType == "Portfolio Management")
					{
					}
					this._reportType = reportType;
					this._subReportType = subReportType;
					this.tsCbTFexMainSelect.Text = this._reportType;
					this.tsCbTFexSubSelect.Text = this._subReportType;
					this.panelTFEXPort.Visible = true;
					this.panelSET.Visible = false;
					this.tsCbTFexMainSelect.SelectedIndexChanged += new EventHandler(this.tsCbTFexMainSelect_SelectedIndexChanged);
					this.tsCbTFexSubSelect.SelectedIndexChanged += new EventHandler(this.tsCbTFexSubSelect_SelectedIndexChanged);
				}
			}
			catch (Exception ex)
			{
				this.tsCbMainSelect.SelectedIndexChanged -= new EventHandler(this.tsCbMainSelect_SelectedIndexChanged);
				this.tsCbSubSelect.SelectedIndexChanged -= new EventHandler(this.tsCbSubSelect_SelectedIndexChanged);
				this.tsCbMainSelect.SelectedIndexChanged += new EventHandler(this.tsCbMainSelect_SelectedIndexChanged);
				this.tsCbSubSelect.SelectedIndexChanged += new EventHandler(this.tsCbSubSelect_SelectedIndexChanged);
				this.tsCbTFexMainSelect.SelectedIndexChanged -= new EventHandler(this.tsCbTFexMainSelect_SelectedIndexChanged);
				this.tsCbTFexSubSelect.SelectedIndexChanged -= new EventHandler(this.tsCbTFexSubSelect_SelectedIndexChanged);
				this.tsCbTFexMainSelect.SelectedIndexChanged += new EventHandler(this.tsCbTFexMainSelect_SelectedIndexChanged);
				this.tsCbTFexSubSelect.SelectedIndexChanged += new EventHandler(this.tsCbTFexSubSelect_SelectedIndexChanged);
				this.ShowError("setVisibleControl", ex);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00044E5C File Offset: 0x0004325C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReportClick(string reportType, string subReportType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.setVisibleControl(reportType, subReportType);
			this.SetResize(true);
			this.SetReportPage();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00044E88 File Offset: 0x00043288
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock2_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Return)
			{
				string text = this.tstbStock2.Text.Trim();
				if (text == string.Empty)
				{
					this.SetReportPage();
				}
				else
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[text];
					if (stockInformation.Number > -1)
					{
						this.tstbStock2.Text = stockInformation.Symbol;
						this.tstbStock2.SelectAll();
						this.SetReportPage();
					}
					else
					{
						this.tstbStock2.SelectAll();
					}
				}
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00044F54 File Offset: 0x00043354
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnPrint_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.BeginInvoke(new frmPortfolio.ShowPrintDailogCallBack(this.ShowPrintDailog));
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00044F78 File Offset: 0x00043378
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnClearStock_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tstbStock2.Text = string.Empty;
			this.SetReportPage();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00044FA4 File Offset: 0x000433A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoadReport_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.IsLoadingData = true;
				string text = this.tstbStock2.Text;
				string text2 = string.Empty;
				if (ApplicationInfo.IsEquityAccount)
				{
					if (this._reportType == "Portfolio")
					{
						if (this._subReportType == "Profit/Loss" || this._subReportType == "Credit Balance")
						{
							this._totUnReal_Pct = 0m;
							this._totUnReal = 0m;
							this._totRealize = 0m;
							this._totCost = 0m;
							this._totCurrValue = 0m;
							text2 = ApplicationInfo.WebOrderService.ViewCustomer_MobileReportAll(this._currAccount, this.tstbStock2.Text.Trim());
							if (!string.IsNullOrEmpty(text2))
							{
								if (this.tdsR1 == null)
								{
									this.tdsR1 = new DataSet();
								}
								else
								{
									this.tdsR1.Clear();
								}
								MyDataHelper.StringToDataSet(text2, this.tdsR1);
							}
						}
						else if (this._subReportType == "Confrim by Stock" || this._subReportType == "Confrim Summary")
						{
							int startRow = (this._reportPageNo - 1) * this._currentTop + 1;
							if (this._subReportType == "Confrim by Stock")
							{
								text2 = ApplicationInfo.WebOrderService.ViewCustomer_ConfirmByStock(this._currAccount, this._iCommType, text, startRow, this._currentTop);
							}
							else
							{
								text2 = ApplicationInfo.WebOrderService.ViewCustomer_ConfirmSummary(this._currAccount, this._iCommType, text, startRow, this._currentTop);
							}
							if (!string.IsNullOrEmpty(text2))
							{
								if (this.tdsR8 == null)
								{
									this.tdsR8 = new DataSet();
								}
								else
								{
									this.tdsR8.Clear();
								}
								MyDataHelper.StringToDataSet(text2, this.tdsR8);
							}
							text2 = ApplicationInfo.WebOrderService.ViewCustomersInfo(this._currAccount, "");
							if (!string.IsNullOrEmpty(text2))
							{
								DataSet dataSet = new DataSet();
								MyDataHelper.StringToDataSet(text2, dataSet);
								if (this.tdsR8 != null)
								{
									this.tdsR8.Merge(dataSet);
								}
							}
						}
						else if (this._subReportType == "Realize Profit/Loss")
						{
							int startRow = (this._reportPageNo - 1) * this._currentTop + 1;
							text2 = ApplicationInfo.WebOrderService.ViewCustomer_RealizeProfitLoss(this._currAccount, text, startRow, this._currentTop);
							if (!string.IsNullOrEmpty(text2))
							{
								if (this.tdsR3 == null)
								{
									this.tdsR3 = new DataSet();
								}
								else
								{
									this.tdsR3.Clear();
								}
								MyDataHelper.StringToDataSet(text2, this.tdsR3);
							}
							text2 = ApplicationInfo.WebOrderService.ViewCustomersInfo(this._currAccount, "");
							if (!string.IsNullOrEmpty(text2))
							{
								DataSet dataSet = new DataSet();
								MyDataHelper.StringToDataSet(text2, dataSet);
								if (this.tdsR3 != null)
								{
									this.tdsR3.Merge(dataSet);
								}
							}
						}
					}
					else if (this._reportType == "Portfolio Management")
					{
						if (this._subReportType == "F-Score Analysis")
						{
							this._totCost = 0m;
							this._totCurrValue = 0m;
							this._totBalanceScore = 0m;
							text2 = ApplicationInfo.WebOrderService.ViewCustomer_FScoreAnalysis(this._currAccount);
							if (!string.IsNullOrEmpty(text2))
							{
								if (this.tdsFScore == null)
								{
									this.tdsFScore = new DataSet();
								}
								else
								{
									this.tdsFScore.Clear();
								}
								MyDataHelper.StringToDataSet(text2, this.tdsFScore);
							}
						}
						else if (this._subReportType == "Beta Analysis")
						{
							this._totCost = 0m;
							this._totCurrValue = 0m;
							this._totBetaScore = 0m;
							text2 = ApplicationInfo.WebOrderService.ViewCustomer_BetaAnalysis(this._currAccount);
							if (!string.IsNullOrEmpty(text2))
							{
								if (this.tdsBeta == null)
								{
									this.tdsBeta = new DataSet();
								}
								else
								{
									this.tdsBeta.Clear();
								}
								MyDataHelper.StringToDataSet(text2, this.tdsBeta);
							}
						}
					}
					else if (this._reportType == "Holding Chart")
					{
						int startRow = (this._reportPageNo - 1) * this._currentTop + 1;
						text2 = ApplicationInfo.WebOrderService.ViewCustomer_ProjectedProfitLoss(this._currAccount, "", startRow, this._currentTop);
						if (!string.IsNullOrEmpty(text2))
						{
							if (this.tdsHoldChart == null)
							{
								this.tdsHoldChart = new DataSet();
							}
							else
							{
								this.tdsHoldChart.Clear();
							}
							MyDataHelper.StringToDataSet(text2, this.tdsHoldChart);
						}
					}
					else if (this._reportType == "NAV Chart")
					{
						int num = Convert.ToInt32(this.tstbStartDate.Text.Substring(0, 2));
						int num2 = Convert.ToInt32(this.tstbStartDate.Text.Substring(3, 2));
						int num3 = Convert.ToInt32(this.tstbStartDate.Text.Substring(6, 4));
						if (num3 > 2500)
						{
							num3 -= 543;
						}
						string startDate = num3 + num2.ToString().PadLeft(2, '0') + num.ToString().PadLeft(2, '0');
						num = Convert.ToInt32(this.tstbEndDate.Text.Substring(0, 2));
						num2 = Convert.ToInt32(this.tstbEndDate.Text.Substring(3, 2));
						num3 = Convert.ToInt32(this.tstbEndDate.Text.Substring(6, 4));
						if (num3 > 2500)
						{
							num3 -= 543;
						}
						string endDate = num3 + num2.ToString().PadLeft(2, '0') + num.ToString().PadLeft(2, '0');
						text2 = ApplicationInfo.WebAlertService.NAVChart(this._currAccount, startDate, endDate);
						if (!string.IsNullOrEmpty(text2))
						{
							if (this.tdsNAV == null)
							{
								this.tdsNAV = new DataSet();
							}
							else
							{
								this.tdsNAV.Clear();
							}
							MyDataHelper.StringToDataSet(text2, this.tdsNAV);
						}
					}
				}
				else
				{
					text2 = ApplicationInfo.WebServiceTFEX.ViewCustomersAll(this._currAccount);
					if (!string.IsNullOrEmpty(text2))
					{
						if (this.tdsTfex == null)
						{
							this.tdsTfex = new DataSet();
						}
						else
						{
							this.tdsTfex.Clear();
						}
						MyDataHelper.StringToDataSet(text2, this.tdsTfex);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoadReport_DoWork", ex);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0004579C File Offset: 0x00043B9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoadReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Error == null)
				{
					if (ApplicationInfo.IsEquityAccount)
					{
						if (this._reportType == "Holding Chart")
						{
							this.UpdateToVolumeChart(this.tdsHoldChart);
							this.tdsHoldChart.Clear();
						}
						else if (this._reportType == "NAV Chart")
						{
							this.chart.Symbol = "SET";
							((DbDataManager)this.chart.HistoryDataManager).Tds = this.tdsNAV;
							this.chart.BindData_History();
							this.chart.NeedRebind();
							this.chart.ShowCrossCursor = true;
							this.chart.SetCursorByPosition(this.chart.GetLastDataIndex());
							this._isAreadyLoadNAV = true;
						}
						else if (this._reportType == "Portfolio Management")
						{
							if (this._subReportType == "F-Score Analysis")
							{
								this.UpdateToReport_FScore(this.tdsFScore);
								this.tdsFScore.Clear();
								this.intzaReport.Redraw();
							}
							else if (this._subReportType == "Beta Analysis")
							{
								this.UpdateToReport_Beta(this.tdsBeta);
								this.tdsBeta.Clear();
								this.intzaReport.Redraw();
							}
						}
						else
						{
							if (this._subReportType == "Profit/Loss" || this._subReportType == "Credit Balance")
							{
								this.UpdateCustomerDataToGrid(this.tdsR1);
								this.UpdateToReport3(this.tdsR1);
								this.tdsR1.Clear();
								this.intzaReport.Redraw();
							}
							else if (this._subReportType == "Confrim by Stock" || this._subReportType == "Confrim Summary")
							{
								if (this.tdsR8.Tables.Contains("ITDS_Get_Cust_Info") && this.tdsR8.Tables["ITDS_Get_Cust_Info"].Rows.Count > 0)
								{
									this.UpdateCustomerDataToGrid(this.tdsR8);
								}
								this.intzaReport.Rows = 0;
								this.UpdateToConfirmByStock();
								this.intzaReport.Redraw();
							}
							else if (this._subReportType == "Realize Profit/Loss")
							{
								if (this.tdsR3.Tables.Contains("view_realize_pl") && this.tdsR3.Tables["view_realize_pl"].Rows.Count > 0)
								{
									this.intzaReport.Rows = 0;
									foreach (DataRow dr in this.tdsR3.Tables["view_realize_pl"].Rows)
									{
										this.UpdateToReport4(dr);
									}
								}
								if (this.tdsR3.Tables.Contains("ITDS_Get_Cust_Info") && this.tdsR3.Tables["ITDS_Get_Cust_Info"].Rows.Count > 0)
								{
									this.UpdateCustomerDataToGrid(this.tdsR3);
								}
								this.tdsR3.Clear();
								this.intzaReport.Redraw();
							}
							if (this._accType == "C" || this._accType == "H" || this._accType == "D")
							{
								this._equity = this._buyLimit + this._totCurrValue;
							}
							this.intzaInfoHeader.Item("tbEquity").Text = this._equity.ToString("#,##0.00");
						}
					}
					else
					{
						this.UpdateCustomerDataToGrid_TFEX();
						if (this.tdsTfex != null)
						{
							this.tdsTfex.Clear();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoadReport_RunWorkerCompleted", ex);
				this.intzaReport.Redraw();
			}
			base.IsLoadingData = false;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00045CE0 File Offset: 0x000440E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToVolumeChart(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.wcGraphVolume.InitData();
				this.wcGraphVolumeSector.InitData();
				Dictionary<string, frmPortfolio.VCItem> dictionary = new Dictionary<string, frmPortfolio.VCItem>();
				Dictionary<string, frmPortfolio.VCItem> dictionary2 = new Dictionary<string, frmPortfolio.VCItem>();
				string key = string.Empty;
				foreach (DataRow dataRow in ds.Tables[0].Rows)
				{
					key = dataRow["stock"].ToString().Trim();
					decimal num;
					decimal.TryParse(dataRow["Cost"].ToString(), out num);
					decimal num2;
					decimal.TryParse(dataRow["Curr_val"].ToString(), out num2);
					long value;
					long.TryParse(dataRow["sellable"].ToString(), out value);
					decimal d;
					decimal.TryParse(dataRow["last_price"].ToString(), out d);
					decimal value2;
					if (d > 0m)
					{
						if (ApplicationInfo.SupportFreewill)
						{
							decimal.TryParse(dataRow["Unrl_pl"].ToString(), out value2);
						}
						else if (dataRow["position_type"].ToString() == "S")
						{
							value2 = Math.Round(num - num2, 0, MidpointRounding.AwayFromZero);
						}
						else
						{
							value2 = Math.Round(num2 - num, 0, MidpointRounding.AwayFromZero);
						}
					}
					else
					{
						if (ApplicationInfo.SupportFreewill)
						{
							decimal.TryParse(dataRow["i2last_price"].ToString(), out d);
						}
						else
						{
							decimal.TryParse(dataRow["last_price"].ToString(), out d);
						}
						num2 = d * value;
						decimal num3 = num2 * ApplicationInfo.AccInfo.TotalCommAndFee / 100m;
						num3 += num3 * ApplicationInfo.UserVAT / 100m;
						if (num != 0m)
						{
							if (dataRow["position_type"].ToString() == "20")
							{
								value2 = num - (num2 + num3);
							}
							else
							{
								value2 = num2 - num3 - num;
							}
						}
						else
						{
							value2 = 0m;
						}
					}
					if (num > 0m)
					{
						if (dictionary.ContainsKey(key))
						{
							frmPortfolio.VCItem vCItem = dictionary[key];
							vCItem.profit += (double)value2;
							vCItem.value += (double)num;
						}
						else
						{
							dictionary.Add(key, new frmPortfolio.VCItem((double)num, (double)value2));
						}
					}
				}
				decimal num4 = this._buyLimit;
				foreach (KeyValuePair<string, frmPortfolio.VCItem> current in dictionary)
				{
					num4 += (decimal)current.Value.value;
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[current.Key];
					if (stockInformation.Number > 0)
					{
						string key2 = string.Empty;
						IndexStat.IndexItem sector = ApplicationInfo.IndexStatInfo.GetSector(stockInformation.SectorNumber);
						if (sector != null)
						{
							key2 = sector.Symbol;
						}
						else if (stockInformation.SecurityType == "W")
						{
							key2 = "WARRANT";
						}
						else if (stockInformation.SecurityType == "F")
						{
							key2 = "FOREIGN";
						}
						else
						{
							key2 = "OTHER";
						}
						if (!dictionary2.ContainsKey(key2))
						{
							dictionary2.Add(key2, new frmPortfolio.VCItem(current.Value.value, current.Value.profit));
						}
						else
						{
							dictionary2[key2].value += current.Value.value;
							dictionary2[key2].profit += current.Value.profit;
						}
					}
				}
				decimal num5 = 0m;
				foreach (KeyValuePair<string, frmPortfolio.VCItem> current in dictionary)
				{
					decimal num6 = Math.Round((decimal)current.Value.value / num4 * 100m, 2);
					if (num6 == 0m)
					{
						num6 = 0.01m;
					}
					num5 += num6;
					this.wcGraphVolume.InputData(current.Key, (double)num6, current.Value.profit);
				}
				num5 = 0m;
				foreach (KeyValuePair<string, frmPortfolio.VCItem> current in dictionary2)
				{
					decimal num6 = Math.Round((decimal)current.Value.value / num4 * 100m, 2);
					if (num6 == 0m)
					{
						num6 = 0.01m;
					}
					num5 += num6;
					this.wcGraphVolumeSector.InputData(current.Key, (double)num6, current.Value.profit);
				}
				this.wcGraphVolumeSector.InputData("Credit", (double)(100m - num5), 0.0);
				dictionary.Clear();
				dictionary = null;
				dictionary2.Clear();
				dictionary2 = null;
				this.wcGraphVolume.EndUpdate();
				this.wcGraphVolumeSector.EndUpdate();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToVolumeChart", ex);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00046464 File Offset: 0x00044864
		[MethodImpl(MethodImplOptions.NoInlining)]
		private decimal GetSpTotolCommVAT(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal result = 0m;
			try
			{
				if (ds != null && ds.Tables.Contains("RETURN") && ds.Tables["RETURN"].Rows.Count > 0)
				{
					DataRow dataRow = ds.Tables["RETURN"].Rows[0];
					decimal.TryParse(dataRow["TotalCommVAT"].ToString(), out result);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0004652C File Offset: 0x0004492C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaListView1_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = e.KeyChar.ToString();
				switch (text)
				{
				case "0":
				case "1":
				case "2":
				case "3":
				case "4":
				case "5":
				case "6":
				case "7":
				case "8":
				case "9":
					goto IL_156;
				}
				if (char.IsLetter(e.KeyChar))
				{
					this.tstbStock2.Focus();
					this.tstbStock2.Text = e.KeyChar.ToString();
					this.tstbStock2.Select(1, 0);
				}
				IL_156:;
			}
			catch (Exception ex)
			{
				this.ShowError("intzaListView1_KeyPress", ex);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000466C8 File Offset: 0x00044AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPortfolio_IDoSymbolLinked(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (source == SymbolLinkSource.SwitchAccount)
			{
				if (!this.bgwLoadReport.IsBusy)
				{
					if (this._currAccount != ApplicationInfo.AccInfo.CurrentAccount)
					{
						this._isAreadyLoadNAV = false;
						this._reportType = "Portfolio";
						this._subReportType = "Profit/Loss";
						this.StartReloadTimer(200, true);
					}
				}
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00046754 File Offset: 0x00044B54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSelStartDate_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._mcPos = 1;
				this.monthCalendar1.Top = this.tStripMenu.Height;
				this.monthCalendar1.Left = this.tstbStartDate.Bounds.Left;
				this.monthCalendar1.SetDate(new DateTime(Convert.ToInt32(this.tstbStartDate.Text.Substring(6, 4)), Convert.ToInt32(this.tstbStartDate.Text.Substring(3, 2)), Convert.ToInt32(this.tstbStartDate.Text.Substring(0, 2))));
				this.monthCalendar1.Show();
				this.monthCalendar1.Focus();
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnSelStartDate_Click", ex);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00046848 File Offset: 0x00044C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSelEndDate_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._mcPos = 2;
				this.monthCalendar1.Top = this.tStripMenu.Height;
				this.monthCalendar1.Left = this.tstbEndDate.Bounds.Left;
				this.monthCalendar1.SetDate(new DateTime(Convert.ToInt32(this.tstbEndDate.Text.Substring(6, 4)), Convert.ToInt32(this.tstbEndDate.Text.Substring(3, 2)), Convert.ToInt32(this.tstbEndDate.Text.Substring(0, 2))));
				this.monthCalendar1.Show();
				this.monthCalendar1.Focus();
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnSelEndDate_Click", ex);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0004693C File Offset: 0x00044D3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._mcPos == 1)
				{
					this.tstbStartDate.Text = e.Start.ToString("dd/MM/yyyy");
				}
				else if (this._mcPos == 2)
				{
					this.tstbEndDate.Text = e.Start.ToString("dd/MM/yyyy");
				}
				this.monthCalendar1.Hide();
			}
			catch (Exception ex)
			{
				this.ShowError("monthCalendar1_DateSelected", ex);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000469FC File Offset: 0x00044DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void monthCalendar1_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.monthCalendar1.Hide();
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00046A1C File Offset: 0x00044E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnReload_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.bgwLoadReport.IsBusy)
				{
					this.bgwLoadReport.RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnReload_Click", ex);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00046A84 File Offset: 0x00044E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateCustomerDataToGrid(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaInfoHeader.BeginUpdate();
				this.intzaCB.BeginUpdate();
				this.intzaInfoHeader.ClearAllText();
				this.intzaCB.ClearAllText();
				if (ApplicationInfo.SupportFreewill)
				{
					if (ds != null && ds.Tables["ITDS_Get_Cust_Info"].Rows.Count > 0)
					{
						DataRow dataRow = ds.Tables["ITDS_Get_Cust_Info"].Rows[0];
						this._accType = dataRow["ACCTYPE"].ToString().Trim();
						this.intzaInfoHeader.Item("tbCustName").Text = ApplicationInfo.AccInfo.CurrentAccount + " " + dataRow["custname"].ToString().Trim();
						this.intzaInfoHeader.Item("tbAccountType").Text = Utilities.GetAccountTypeName(this._accType);
						this.intzaInfoHeader.Item("tbTrader").Text = dataRow["traderid"].ToString().Trim() + " " + dataRow["tradername"].ToString().Trim();
						this.intzaInfoHeader.Item("tbCustomerType").Text = dataRow["custtype"].ToString();
						this.intzaInfoHeader.Item("tbCreditType").Text = Utilities.GetCreditTypeName(dataRow["credittype"].ToString());
						if (!ApplicationInfo.AccInfo.IsCurrAccCreditBalance)
						{
							decimal.TryParse(dataRow["buycredit"].ToString(), out this._buyLimit);
							this.intzaInfoHeader.Item("tbBuyLimit").Text = this._buyLimit.ToString("#,##0.00");
						}
						decimal num = 0m;
						decimal num2 = 0m;
						decimal.TryParse(dataRow["creditlimit"].ToString(), out num2);
						this.intzaInfoHeader.Item("tbCreditLine").Text = num2.ToString("#,##0.00");
						this.intzaInfoHeader.Item("tbCantOverCredit").Text = ((dataRow["canovercredit"].ToString() == "Y") ? "N" : "Y");
						if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance)
						{
							this.intzaInfoHeader.Item("lbBuyLimit").Text = "Excess Equity";
							this.intzaInfoHeader.Item("lbHighLimit").Text = "Purchasing Power";
							if (ds.Tables.Contains("ITDS_Get_Cust_CrdtBal") && ds.Tables["ITDS_Get_Cust_CrdtBal"].Rows.Count > 0)
							{
								DataRow dataRow2 = ds.Tables["ITDS_Get_Cust_CrdtBal"].Rows[0];
								decimal.TryParse(dataRow2["PP"].ToString(), out num);
								this.intzaInfoHeader.Item("tbHighLimit").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["equity"].ToString(), out this._equity);
								decimal.TryParse(dataRow2["EE"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbAccEE").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbEE").Text = num.ToString("#,##0.00");
								this.intzaInfoHeader.Item("tbBuyLimit").Text = num.ToString("#,##0.00");
								this._buyLimit = num;
								decimal.TryParse(dataRow2["EE_50"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbBuyCredit50").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["EE_60"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbBuyCredit60").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["EE_70"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbBuyCredit70").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["ASSET"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbAssets").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbAssets").FontColor = Utilities.ComparePriceColor(num, 0m);
								decimal.TryParse(dataRow2["MR"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbMR").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["call_force"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbCallForce").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["call_force"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbCallForce").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["Liability"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbLiabilities").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbLiabilities").FontColor = Utilities.ComparePriceColor(num, 0m);
								decimal.TryParse(dataRow2["Equity"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbEquity").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbEquity").FontColor = Utilities.ComparePriceColor(num, 0m);
								decimal.TryParse(dataRow2["BuyMR"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbBuyMR").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["SellMR"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbSellMR").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["Cash_balance"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbCashBal").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbCashBal").FontColor = MyColor.UpColor;
								decimal.TryParse(dataRow2["EE"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbEE").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbEE").FontColor = Utilities.ComparePriceColor(num, 0m);
								decimal.TryParse(dataRow2["PP"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbPP").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbPP").FontColor = Utilities.ComparePriceColor(num, 0m);
								decimal.TryParse(dataRow2["brk_call_lmv"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbCallLMV").Text = num.ToString("#,##0.00");
								decimal.TryParse(dataRow2["LMV"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbLMV").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbLMV").FontColor = MyColor.UpColor;
								decimal.TryParse(dataRow2["Collat"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbCollateral").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbCollateral").FontColor = MyColor.UpColor;
								decimal.TryParse(dataRow2["call_margin"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbCallMargin").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbCallMargin").FontColor = MyColor.UnChgColor;
								decimal.TryParse(dataRow2["brk_call_smv"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbCallSMV").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbCallSMV").FontColor = MyColor.UnChgColor;
								decimal.TryParse(dataRow2["SMV"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbSMV").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbSMV").FontColor = MyColor.DownColor;
								decimal.TryParse(dataRow2["Debt"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbDEBT").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbDEBT").FontColor = MyColor.DownColor;
								decimal.TryParse(dataRow2["brk_sell_lmv"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbForceLMV").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbForceLMV").FontColor = MyColor.UnChgColor;
								decimal.TryParse(dataRow2["BMV"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbBMV").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbBMV").FontColor = MyColor.UnChgColor;
								this.intzaCB_Freewill.Item("tbAction").Text = dataRow2["action"].ToString();
								decimal.TryParse(dataRow2["brk_sell_smv"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbForceSMV").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbForceSMV").FontColor = MyColor.UnChgColor;
								decimal.TryParse(dataRow2["Withdrawal"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbWithdrawal").Text = num.ToString("#,##0.00");
								this.intzaCB_Freewill.Item("tbWithdrawal").FontColor = Utilities.ComparePriceColor(num, 0m);
								decimal.TryParse(dataRow["Mrgcode"].ToString(), out num);
								this.intzaCB_Freewill.Item("tbMarginRate").Text = num.ToString("#,##0.00");
							}
						}
						else
						{
							this.intzaInfoHeader.Item("lbBuyLimit").Text = "Buy Limit";
							this.intzaInfoHeader.Item("lbHighLimit").Text = "";
						}
					}
				}
				else if (ds != null && ds.Tables["ITDS_Get_Cust_Info"].Rows.Count > 0)
				{
					DataRow dataRow = ds.Tables["ITDS_Get_Cust_Info"].Rows[0];
					if (dataRow["sServiceTypeFlag"].ToString().Trim() == "G")
					{
						this._iCommType = 1;
					}
					else
					{
						this._iCommType = 0;
					}
					decimal.TryParse(dataRow["nmrTradingFee"].ToString(), out this._tradingFee);
					decimal.TryParse(dataRow["nmrClearingFee"].ToString(), out this._clearingFee);
					decimal.TryParse(dataRow["nmrSettlementFee"].ToString(), out this._settlementFee);
					this._accType = dataRow["sAccType"].ToString().Trim();
					this.intzaInfoHeader.Item("tbCustName").Text = ApplicationInfo.AccInfo.CurrentAccount + " " + dataRow["sName"].ToString().Trim();
					this.intzaInfoHeader.Item("tbAccountType").Text = Utilities.GetAccountTypeName(this._accType);
					this.intzaInfoHeader.Item("tbTrader").Text = dataRow["sTraderName"].ToString().Trim() + " : " + dataRow["sTradUserNo"].ToString().Trim();
					this.intzaInfoHeader.Item("tbCustomerType").Text = dataRow["sPC"].ToString();
					this.intzaInfoHeader.Item("tbCreditType").Text = Utilities.GetCreditTypeName(dataRow["sCrdtType"].ToString());
					this.intzaInfoHeader.Item("tbCantOverCredit").Text = dataRow["sNotOverShort"].ToString();
					if (this._accType == "C" || this._accType == "H" || this._accType == "D")
					{
						decimal num3 = 0m;
						this.intzaInfoHeader.Item("lbBuyLimit").Text = "Buy Limit";
						decimal.TryParse(dataRow["nmrBuyLmt"].ToString(), out this._buyLimit);
						this.intzaInfoHeader.Item("tbBuyLimit").Text = this._buyLimit.ToString("#,##0.00");
						this.intzaInfoHeader.Item("lbHighLimit").Text = "High Limit";
						decimal.TryParse(dataRow["nmrHighLmt"].ToString(), out num3);
						this.intzaInfoHeader.Item("tbHighLimit").Text = num3.ToString("#,##0.00");
						this.intzaInfoHeader.Item("tbCustomerFlag").Text = dataRow["sCustFlag"].ToString();
						this.intzaInfoHeader.Item("tbBuyLimit").FontColor = MyColor.UnChgColor;
						this.intzaInfoHeader.Item("tbHighLimit").FontColor = MyColor.UnChgColor;
						decimal num2 = 0m;
						decimal.TryParse(dataRow["nmrOrigBuy"].ToString(), out num2);
						this.intzaInfoHeader.Item("tbCreditLine").Text = num2.ToString("#,##0.00");
					}
					if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance)
					{
						string text = string.Empty;
						text = dataRow["sTSFCFlag"].ToString();
						if (text.Trim() == "" || text.ToUpper() == "N")
						{
							this.intzaInfoHeader.Item("tbCustomerFlag").Text = "Normal";
						}
						else if (text.ToUpper() == "Y")
						{
							this.intzaInfoHeader.Item("tbCustomerFlag").Text = "TSFC";
						}
						decimal num2 = 0m;
						decimal.TryParse(dataRow["nmrOrigBuy"].ToString(), out num2);
						this.intzaInfoHeader.Item("tbCreditLine").Text = num2.ToString("#,##0.00");
						if (ds.Tables.Contains("ITDS_Get_Cust_CrdtBal"))
						{
							DataRow dataRow2 = ds.Tables["ITDS_Get_Cust_CrdtBal"].Rows[0];
							decimal num4 = 0m;
							int num5 = 0;
							decimal.TryParse(dataRow2["LoanLimit"].ToString(), out num4);
							int.TryParse(dataRow2["MarginRate"].ToString(), out num5);
							this.intzaCB.Item("tbLoanLimit").Text = num4.ToString("#,##0.00");
							this.intzaCB.Item("tbMarginRate").Text = num5.ToString("#,###") + "%";
							decimal price = 0m;
							decimal price2 = 0m;
							decimal price3 = 0m;
							decimal price4 = 0m;
							decimal price5 = 0m;
							decimal price6 = 0m;
							decimal price7 = 0m;
							decimal price8 = 0m;
							decimal num6 = 0m;
							decimal num7 = 0m;
							decimal.TryParse(dataRow2["PrevEE"].ToString(), out price);
							decimal.TryParse(dataRow2["PrevEquity"].ToString(), out price2);
							decimal.TryParse(dataRow2["PrevMR"].ToString(), out price3);
							decimal.TryParse(dataRow2["PrevCashBal"].ToString(), out price4);
							decimal.TryParse(dataRow2["PrevLMV"].ToString(), out price5);
							decimal.TryParse(dataRow2["PrevColl"].ToString(), out price6);
							decimal.TryParse(dataRow2["PrevLoan"].ToString(), out price7);
							decimal.TryParse(dataRow2["PrevSMV"].ToString(), out price8);
							decimal.TryParse(dataRow2["PrevCall"].ToString(), out num6);
							decimal.TryParse(dataRow2["PrevForce"].ToString(), out num7);
							this.intzaCB.Item("tbExcessEquityPrevious").Text = price.ToString("#,##0.00");
							this.intzaCB.Item("tbEquityPrevious").Text = price2.ToString("#,##0.00");
							this.intzaCB.Item("tbMRPrevious").Text = price3.ToString("#,##0.00");
							this.intzaCB.Item("tbCashBalancePrevious").Text = price4.ToString("#,##0.00");
							this.intzaCB.Item("tbLmvPrevious").Text = price5.ToString("#,##0.00");
							this.intzaCB.Item("tbColleteralPrevious").Text = price6.ToString("#,##0.00");
							this.intzaCB.Item("tbLoanPrevious").Text = price7.ToString("#,##0.00");
							this.intzaCB.Item("tbSmvPrevious").Text = price8.ToString("#,##0.00");
							this.intzaCB.Item("tbCallPrevious").Text = num6.ToString("#,##0.00");
							this.intzaCB.Item("tbForcePrevious").Text = num7.ToString("#,##0.00");
							decimal price9 = 0m;
							decimal price10 = 0m;
							decimal num8 = 0m;
							decimal price11 = 0m;
							decimal price12 = 0m;
							decimal price13 = 0m;
							decimal price14 = 0m;
							decimal price15 = 0m;
							decimal price16 = 0m;
							decimal price17 = 0m;
							decimal num9 = 0m;
							decimal num10 = 0m;
							decimal num11 = 0m;
							decimal.TryParse(dataRow2["CurEE"].ToString(), out num8);
							decimal.TryParse(dataRow2["CurEquity"].ToString(), out price10);
							decimal.TryParse(dataRow2["CurCashBal"].ToString(), out price11);
							decimal.TryParse(dataRow2["CurLoan"].ToString(), out price9);
							decimal.TryParse(dataRow2["MM%"].ToString(), out price16);
							decimal.TryParse(dataRow2["MarkEE"].ToString(), out price17);
							decimal.TryParse(dataRow2["CurMR"].ToString(), out price15);
							decimal.TryParse(dataRow2["CurLMV"].ToString(), out price12);
							decimal.TryParse(dataRow2["CurColl"].ToString(), out price13);
							decimal.TryParse(dataRow2["CurSMV"].ToString(), out price14);
							decimal.TryParse(dataRow2["CurCall"].ToString(), out num9);
							decimal.TryParse(dataRow2["CurForce"].ToString(), out num10);
							decimal.TryParse(dataRow2["PP"].ToString(), out num11);
							this.intzaCB.Item("tbExcessEquityCurrent").Text = num8.ToString("#,##0.00");
							this.intzaCB.Item("tbEquityCurrent").Text = price10.ToString("#,##0.00");
							this.intzaCB.Item("tbCashBalanceCurrent").Text = price11.ToString("#,##0.00");
							this.intzaCB.Item("tbLoanCurrent").Text = price9.ToString("#,##0.00");
							this.intzaCB.Item("tbMMpercentCurrent").Text = price16.ToString();
							this.intzaCB.Item("tbMarkToEECurrent").Text = price17.ToString("#,##0.00");
							this.intzaCB.Item("tbMRCurrent").Text = price15.ToString("#,##0.00");
							this.intzaCB.Item("tbLmvCurrent").Text = price12.ToString("#,##0.00");
							this.intzaCB.Item("tbColleteralCurrent").Text = price13.ToString("#,##0.00");
							this.intzaCB.Item("tbSmvCurrent").Text = price14.ToString("#,##0.00");
							this.intzaCB.Item("tbCallCurrent").Text = num9.ToString("#,##0.00");
							this.intzaCB.Item("tbForceCurrent").Text = num10.ToString("#,##0.00");
							this.intzaInfoHeader.Item("tbBuyLimit").Text = num8.ToString("#,##0.00");
							this._buyLimit = num8;
							this.intzaInfoHeader.Item("tbHighLimit").Text = num11.ToString("#,##0.00");
							this.intzaCB.Item("tbExcessEquityPrevious").FontColor = Utilities.ComparePriceColor(price, 0m);
							this.intzaCB.Item("tbExcessEquityCurrent").FontColor = Utilities.ComparePriceColor(num8, 0m);
							this.intzaCB.Item("tbMarkToEECurrent").FontColor = Utilities.ComparePriceColor(price17, 0m);
							this.intzaCB.Item("tbMMpercentCurrent").FontColor = Utilities.ComparePriceColor(price16, 0m);
							this.intzaCB.Item("tbEquityPrevious").FontColor = Utilities.ComparePriceColor(price2, 0m);
							this.intzaCB.Item("tbEquityCurrent").FontColor = Utilities.ComparePriceColor(price10, 0m);
							this.intzaCB.Item("tbCashBalancePrevious").FontColor = Utilities.ComparePriceColor(price4, 0m);
							this.intzaCB.Item("tbCashBalanceCurrent").FontColor = Utilities.ComparePriceColor(price11, 0m);
							this.intzaCB.Item("tbLmvPrevious").FontColor = Utilities.ComparePriceColor(price5, 0m);
							this.intzaCB.Item("tbLmvCurrent").FontColor = Utilities.ComparePriceColor(price12, 0m);
							this.intzaCB.Item("tbColleteralPrevious").FontColor = Utilities.ComparePriceColor(price13, 0m);
							this.intzaCB.Item("tbColleteralCurrent").FontColor = Utilities.ComparePriceColor(price6, 0m);
							this.intzaCB.Item("tbLoanPrevious").FontColor = Utilities.ComparePriceColor(price7, 0m);
							this.intzaCB.Item("tbLoanCurrent").FontColor = Utilities.ComparePriceColor(price9, 0m);
							this.intzaCB.Item("tbSmvPrevious").FontColor = Utilities.ComparePriceColor(price8, 0m);
							this.intzaCB.Item("tbSmvCurrent").FontColor = Utilities.ComparePriceColor(price14, 0m);
							this.intzaCB.Item("tbMRPrevious").FontColor = Utilities.ComparePriceColor(price3, 0m);
							this.intzaCB.Item("tbMRCurrent").FontColor = Utilities.ComparePriceColor(price15, 0m);
							decimal.TryParse(dataRow2["CurEquity"].ToString(), out this._equity);
						}
						else
						{
							decimal.TryParse(dataRow["nmrBuyLmt"].ToString(), out this._buyLimit);
							this.intzaInfoHeader.Item("tbBuyLimit").Text = this._buyLimit.ToString("#,##0.00");
							this.intzaInfoHeader.Item("tbHighLimit").Text = (this._buyLimit / ApplicationInfo.UserMarginRate * 100m).ToString("#,##0.00");
						}
						this.intzaInfoHeader.Item("lbBuyLimit").Text = "Excess Equity";
						this.intzaInfoHeader.Item("lbHighLimit").Text = "Purchasing Power";
					}
				}
				if (this._isSupportCBReport)
				{
					if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance)
					{
						if (!this.tsCbSubSelect.Items.Contains("Credit Balance"))
						{
							this.tsCbSubSelect.Items.Add("Credit Balance");
						}
					}
					else if (this.tsCbSubSelect.Items.Contains("Credit Balance"))
					{
						this.tsCbSubSelect.Items.Remove("Credit Balance");
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				this.intzaInfoHeader.Redraw();
				this.intzaCB.Redraw();
				if (!base.Visible)
				{
					base.Show();
				}
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000486F4 File Offset: 0x00046AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToReport3(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = 0L;
				long num2 = 0L;
				decimal num3 = 0m;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				decimal num7 = 0m;
				decimal d = 0m;
				decimal d2 = 0m;
				decimal num8 = 0m;
				this.intzaReport.Rows = ds.Tables["view_projected_pl"].Rows.Count;
				Dictionary<string, decimal> dictionary = new Dictionary<string, decimal>();
				decimal num9 = 0m;
				if (!ApplicationInfo.SupportFreewill)
				{
                    IEnumerator enumerator = ds.Tables["view_realize_pl"].Rows.GetEnumerator();
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							string key = string.Concat(new string[]
							{
								dataRow["stock"].ToString().Trim(),
								"_",
								dataRow["position_type"].ToString(),
								"_",
								dataRow["trustee_id"].ToString()
							});
							decimal.TryParse(dataRow["stock"].ToString(), out num9);
							decimal d3;
							decimal.TryParse(dataRow["costCommVat"].ToString(), out d3);
							decimal d4;
							decimal.TryParse(dataRow["sellComVat"].ToString(), out d4);
							decimal num10;
							decimal.TryParse(dataRow["sell_total_amount"].ToString(), out num10);
							decimal num11;
							decimal.TryParse(dataRow["cost_total_amount"].ToString(), out num11);
							if (ApplicationInfo.BrokerId == 2 || ApplicationInfo.BrokerId == 88)
							{
								if (dataRow["position_type"].ToString() == "S")
								{
									num9 = num11 - num10;
								}
								else
								{
									num9 = num10 - num11;
								}
							}
							else if (dataRow["position_type"].ToString() == "S")
							{
								num9 = num11 - num10 - (d3 + d4);
							}
							else
							{
								num9 = num10 - num11 - (d3 + d4);
							}
							dictionary.Add(key, num9);
						}
					}
				}
				int num12 = 0;
				foreach (DataRow dataRow in ds.Tables["view_projected_pl"].Rows)
				{
					RecordItem recordItem = this.intzaReport.Records(num12);
					long.TryParse(dataRow["onhand"].ToString(), out num);
					decimal.TryParse(dataRow["average"].ToString(), out num3);
					decimal.TryParse(dataRow["last_price"].ToString(), out num5);
					long.TryParse(dataRow["sellable"].ToString(), out num2);
					decimal.TryParse(dataRow["Cost"].ToString(), out num4);
					decimal.TryParse(dataRow["Curr_val"].ToString(), out num6);
					if (ApplicationInfo.SupportFreewill)
					{
						if (num5 > 0m)
						{
							decimal.TryParse(dataRow["Unrl_pl"].ToString(), out num7);
							decimal.TryParse(dataRow["Unrl_pl_pct"].ToString(), out num8);
						}
						else
						{
							decimal.TryParse(dataRow["i2last_price"].ToString(), out num5);
							num6 = num5 * num2;
							decimal num13 = num6 * ApplicationInfo.AccInfo.TotalCommAndFee / 100m;
							num13 += num13 * ApplicationInfo.UserVAT / 100m;
							if (num4 != 0m)
							{
								if (dataRow["position_type"].ToString() == "20")
								{
									num7 = num4 - (num6 + num13);
								}
								else
								{
									num7 = num6 - num13 - num4;
								}
								num8 = num7 / num4 * 100m;
							}
							else
							{
								num7 = 0m;
								num8 = 0m;
							}
						}
						decimal.TryParse(dataRow["realize_pl"].ToString(), out num9);
					}
					else
					{
						decimal.TryParse(dataRow["costCommVat"].ToString(), out d);
						decimal.TryParse(dataRow["currValCommVat"].ToString(), out d2);
						num7 = 0m;
						num8 = 0m;
						num9 = 0m;
						if (ApplicationInfo.BrokerId == 2 || ApplicationInfo.BrokerId == 88)
						{
							if (dataRow["position_type"].ToString() == "S")
							{
								num7 = Math.Round(num4 - num6, 0, MidpointRounding.AwayFromZero);
							}
							else
							{
								num7 = Math.Round(num6 - num4, 0, MidpointRounding.AwayFromZero);
							}
						}
						else if (num6 > 0m && num4 > 0m)
						{
							if (dataRow["position_type"].ToString() == "S")
							{
								num7 = Math.Round(num4 - num6 - (d + d2), 0, MidpointRounding.AwayFromZero);
							}
							else
							{
								num7 = Math.Round(num6 - num4 - (d + d2), 0, MidpointRounding.AwayFromZero);
							}
						}
						dictionary.TryGetValue(string.Concat(new string[]
						{
							dataRow["stock"].ToString().Trim(),
							"_",
							dataRow["position_type"].ToString(),
							"_",
							dataRow["trustee_id"].ToString()
						}), out num9);
						if (num4 > 0m)
						{
							num8 = num7 / num4 * 100m;
						}
					}
					if (dataRow["position_type"].ToString() != "B")
					{
						this._totUnReal += num7;
						this._totRealize += num9;
						this._totCurrValue += num6;
						this._totCost += num4;
						recordItem.Fields("avg").Text = Utilities.PriceFormat(num3, (ApplicationInfo.BrokerId == 11) ? 2 : 4);
						recordItem.Fields("last").Text = Utilities.PriceFormat(num5);
						recordItem.Fields("unreal_pct").Text = Utilities.PriceFormat(num8, true, "");
						recordItem.Fields("unreal").Text = Utilities.VolumeFormat((long)num7, true);
						recordItem.Fields("cost").Text = Utilities.VolumeFormat((long)num4, true);
						recordItem.Fields("curr_value").Text = Utilities.VolumeFormat((long)num6, true);
						recordItem.Fields("realize").Text = Utilities.PriceFormat(num9, 2);
					}
					recordItem.Fields("stock").Text = dataRow["stock"].ToString();
					recordItem.Fields("stock").Tag = this.GetPositionType(dataRow["position_type"].ToString().Trim());
					recordItem.Fields("onhand").Text = FormatUtil.VolumeFormat(num, true);
					recordItem.Fields("sellable").Text = Utilities.VolumeFormat(num2, true);
					recordItem.Fields("ttf").Text = Utilities.PriceFormat(dataRow["trustee_id"].ToString());
					if (!ApplicationInfo.SupportFreewill)
					{
						decimal num14;
						decimal.TryParse(dataRow["nmrNetSettlementVal"].ToString(), out num14);
						recordItem.Fields("netsettle").Text = Utilities.VolumeFormat(num14, true);
						recordItem.Fields("netsettle").FontColor = Color.Orange;
						this._totNetSettle += num14;
					}
					Color fontColor = MyColor.UnChgColor;
					if (num7 > 0m)
					{
						fontColor = MyColor.UpColor;
					}
					else if (num7 < 0m)
					{
						fontColor = MyColor.DownColor;
					}
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("onhand").FontColor = fontColor;
					recordItem.Fields("avg").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					recordItem.Fields("unreal_pct").FontColor = fontColor;
					recordItem.Fields("sellable").FontColor = fontColor;
					recordItem.Fields("cost").FontColor = fontColor;
					recordItem.Fields("curr_value").FontColor = fontColor;
					recordItem.Fields("ttf").FontColor = fontColor;
					recordItem.Fields("unreal").FontColor = fontColor;
					if (num9 > 0m)
					{
						fontColor = MyColor.UpColor;
					}
					else
					{
						fontColor = MyColor.DownColor;
					}
					recordItem.Fields("realize").FontColor = fontColor;
					num12++;
				}
				dictionary.Clear();
				dictionary = null;
				if (this._totCost > 0m)
				{
					this._totUnReal_Pct = this._totUnReal / this._totCost * 100m;
				}
				else
				{
					this._totUnReal_Pct = 0m;
				}
				this.setSummaryTab();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToReport3", ex);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00049314 File Offset: 0x00047714
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetPositionType(string positionType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			if (ApplicationInfo.SupportFreewill)
			{
				switch (positionType)
				{
				case "2":
					result = "";
					goto IL_161;
				case "4":
					result = "P";
					goto IL_161;
				case "8":
					result = "N";
					goto IL_161;
				case "9":
					result = "E";
					goto IL_161;
				case "12":
					result = "R";
					goto IL_161;
				case "20":
					result = "S";
					goto IL_161;
				case "21":
					result = "p";
					goto IL_161;
				case "22":
					result = "B";
					goto IL_161;
				case "23":
					result = "r";
					goto IL_161;
				}
				result = positionType;
				IL_161:;
			}
			else
			{
				result = positionType;
			}
			return result;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00049494 File Offset: 0x00047894
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setSummaryTab()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				RecordItem recordItem = this.intzaSumReport.Records(0);
				this.intzaSumReport.ClearAllText();
				recordItem.BackColor = Color.FromArgb(25, 25, 25);
				recordItem.Fields("text").Text = "Total";
				recordItem.Fields("cost").Text = Utilities.VolumeFormat(this._totCost, true);
				recordItem.Fields("cost").FontColor = MyColor.UnChgColor;
				recordItem.Fields("curr_value").Text = Utilities.VolumeFormat(this._totCurrValue, true);
				recordItem.Fields("curr_value").FontColor = MyColor.UnChgColor;
				if (this._subReportType == "Profit/Loss")
				{
					recordItem.Fields("unreal_pct").Text = Utilities.PriceFormat(this._totUnReal_Pct, true, "");
					recordItem.Fields("unreal_pct").FontColor = Utilities.ComparePriceColor(this._totUnReal_Pct, 0m);
					recordItem.Fields("unreal").Text = Utilities.VolumeFormat(this._totUnReal, true);
					recordItem.Fields("unreal").FontColor = Utilities.ComparePriceColor(this._totUnReal, 0m);
					if (this.intzaReport.GetColumn("realize").Visible)
					{
						recordItem.Fields("realize").Text = Utilities.PriceFormat(this._totRealize, 2);
						recordItem.Fields("realize").FontColor = Utilities.ComparePriceColor(this._totRealize, 0m);
					}
					else
					{
						recordItem.Fields("realize").Text = Utilities.PriceFormat(this._totNetSettle, 2);
						recordItem.Fields("realize").FontColor = Color.Orange;
					}
				}
				else if (this._subReportType == "F-Score Analysis")
				{
					recordItem.Fields("unreal").Text = "";
					recordItem.Fields("unreal_pct").Text = "";
					recordItem.Fields("realize").Text = Utilities.PriceFormat(this._totBalanceScore);
					recordItem.Fields("realize").FontColor = Color.Yellow;
				}
				else if (this._subReportType == "Beta Analysis")
				{
					recordItem.Fields("realize").Text = Utilities.PriceFormat(this._totBetaScore, 2);
					recordItem.Fields("realize").FontColor = Color.Yellow;
				}
				this.intzaSumReport.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("setSummaryTab", ex);
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000497D0 File Offset: 0x00047BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToReport_FScore(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = 0L;
				long num2 = 0L;
				decimal num3 = 0m;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				decimal num7 = 0m;
				foreach (DataRow dataRow in ds.Tables["view_fscore"].Rows)
				{
					if (dataRow["position_type"].ToString() != "B" && !string.IsNullOrEmpty(dataRow["f_score"].ToString()) && dataRow["f_score"].ToString() != "N/A")
					{
						decimal.TryParse(dataRow["Cost"].ToString(), out num4);
						num7 += num4;
					}
				}
				int num8 = 0;
				this.intzaReport.Rows = ds.Tables["view_fscore"].Rows.Count;
				foreach (DataRow dataRow in ds.Tables["view_fscore"].Rows)
				{
					RecordItem recordItem = this.intzaReport.Records(num8);
					long.TryParse(dataRow["onhand"].ToString(), out num);
					decimal.TryParse(dataRow["average"].ToString(), out num3);
					decimal.TryParse(dataRow["last_price"].ToString(), out num5);
					long.TryParse(dataRow["sellable"].ToString(), out num2);
					decimal.TryParse(dataRow["Cost"].ToString(), out num4);
					decimal.TryParse(dataRow["Curr_val"].ToString(), out num6);
					if (ApplicationInfo.SupportFreewill)
					{
						if (num5 == 0m)
						{
							decimal.TryParse(dataRow["i2last_price"].ToString(), out num5);
							num6 = num5 * num2;
						}
					}
					if (dataRow["position_type"].ToString() != "B")
					{
						recordItem.Fields("avg").Text = Utilities.PriceFormat(num3, (ApplicationInfo.BrokerId == 11) ? 2 : 4);
						recordItem.Fields("last").Text = Utilities.PriceFormat(num5);
						recordItem.Fields("cost").Text = Utilities.VolumeFormat((long)num4, true);
						recordItem.Fields("curr_value").Text = Utilities.VolumeFormat((long)num6, true);
						if (!string.IsNullOrEmpty(dataRow["f_score"].ToString()) && dataRow["f_score"].ToString() != "N/A")
						{
							decimal num9;
							decimal.TryParse(dataRow["f_score"].ToString(), out num9);
							decimal num10 = num4 / num7 * 100m;
							decimal num11 = num10 * num9 / 100m;
							this._totBalanceScore += num11;
							recordItem.Fields("f_score").Text = num9;
							recordItem.Fields("tot_val_pct").Text = Utilities.PriceFormat(num10, 2, "0.00");
							recordItem.Fields("bal_score_pct").Text = Utilities.PriceFormat(num11, 2, "0.00");
							if (num9 <= 4m)
							{
								recordItem.Fields("f_score").FontColor = Color.Red;
							}
							else if (num9 >= 5m)
							{
								recordItem.Fields("f_score").FontColor = Color.Lime;
							}
						}
						else
						{
							recordItem.Fields("f_score").Text = "N/A";
							recordItem.Fields("tot_val_pct").Text = "N/A";
							recordItem.Fields("bal_score_pct").Text = "N/A";
							recordItem.Fields("f_score").FontColor = Color.Yellow;
							recordItem.Fields("tot_val_pct").FontColor = Color.Yellow;
							recordItem.Fields("bal_score_pct").FontColor = Color.Yellow;
						}
					}
					recordItem.Fields("stock").Text = dataRow["stock"].ToString();
					recordItem.Fields("stock").Tag = this.GetPositionType(dataRow["position_type"].ToString().Trim());
					recordItem.Fields("onhand").Text = FormatUtil.VolumeFormat(num, true);
					recordItem.Fields("sellable").Text = Utilities.VolumeFormat(num2, true);
					recordItem.Fields("ttf").Text = Utilities.PriceFormat(dataRow["trustee_id"].ToString());
					Color fontColor = Utilities.ComparePriceColor(num6, num4);
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("onhand").FontColor = fontColor;
					recordItem.Fields("avg").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					recordItem.Fields("sellable").FontColor = fontColor;
					recordItem.Fields("cost").FontColor = fontColor;
					recordItem.Fields("curr_value").FontColor = fontColor;
					recordItem.Fields("ttf").FontColor = fontColor;
					num8++;
				}
				this.setSummaryTab();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToReport3", ex);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00049F30 File Offset: 0x00048330
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToReport_Beta(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = 0L;
				long value = 0L;
				decimal num2 = 0m;
				decimal num3 = 0m;
				decimal num4 = 0m;
				decimal price = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				decimal num7 = 0m;
				this.intzaReport.Rows = ds.Tables["view_beta"].Rows.Count;
				decimal num8 = 0m;
				foreach (DataRow dataRow in ds.Tables["view_beta"].Rows)
				{
					decimal.TryParse(dataRow["Cost"].ToString(), out num3);
					if (dataRow["position_type"].ToString() != "B")
					{
						num8 += num3;
					}
				}
				int num9 = 0;
				foreach (DataRow dataRow in ds.Tables["view_beta"].Rows)
				{
					RecordItem recordItem = this.intzaReport.Records(num9);
					long.TryParse(dataRow["onhand"].ToString(), out num);
					long.TryParse(dataRow["sellable"].ToString(), out value);
					decimal.TryParse(dataRow["average"].ToString(), out num2);
					decimal.TryParse(dataRow["last_price"].ToString(), out num4);
					decimal.TryParse(dataRow["Cost"].ToString(), out num3);
					decimal.TryParse(dataRow["Curr_val"].ToString(), out price);
					decimal.TryParse(dataRow["beta6"].ToString(), out num5);
					decimal.TryParse(dataRow["beta30"].ToString(), out num6);
					decimal.TryParse(dataRow["beta90"].ToString(), out num7);
					decimal num10 = (num8 > 0m) ? (num3 / num8 * 100m) : 0m;
					if (ApplicationInfo.SupportFreewill)
					{
						if (num4 == 0m)
						{
							decimal.TryParse(dataRow["i2last_price"].ToString(), out num4);
							price = num4 * value;
						}
					}
					if (dataRow["position_type"].ToString() != "B")
					{
						int num11 = 0;
						if (dataRow["beta6"].ToString() != "N/A")
						{
							num11++;
							recordItem.Fields("beta6").Text = Utilities.PriceFormat(num5, 2, "0.00");
							recordItem.Fields("beta6").FontColor = Utilities.ComparePriceColor(num5, 1m);
						}
						else
						{
							recordItem.Fields("beta6").Text = "N/A";
							recordItem.Fields("beta6").FontColor = Color.Yellow;
						}
						if (dataRow["beta30"].ToString() != "N/A")
						{
							num11++;
							recordItem.Fields("beta30").Text = Utilities.PriceFormat(num6, 2, "0.00");
							recordItem.Fields("beta30").FontColor = Utilities.ComparePriceColor(num6, 1m);
						}
						else
						{
							recordItem.Fields("beta30").Text = "N/A";
							recordItem.Fields("beta30").FontColor = Color.Yellow;
						}
						if (dataRow["beta90"].ToString() != "N/A")
						{
							num11++;
							recordItem.Fields("beta90").Text = Utilities.PriceFormat(num7, 2, "0.00");
							recordItem.Fields("beta90").FontColor = Utilities.ComparePriceColor(num7, 1m);
						}
						else
						{
							recordItem.Fields("beta90").Text = "N/A";
							recordItem.Fields("beta90").FontColor = Color.Yellow;
						}
						if (num11 > 0)
						{
							decimal num12 = (num11 > 0) ? ((num5 + num6 + num7) / num11) : 0m;
							decimal num13 = (num10 > 0m) ? (num12 * num10 / 100m) : 0m;
							recordItem.Fields("tot_val_pct").Text = Utilities.PriceFormat(num10, 2, "0.00");
							recordItem.Fields("beta_count").Text = Utilities.PriceFormat(num12, 2, "0.00");
							recordItem.Fields("beta_score").Text = Utilities.PriceFormat(num13, 2, "0.00");
							this._totBetaScore += num13;
						}
						else
						{
							recordItem.Fields("tot_val_pct").Text = "N/A";
							recordItem.Fields("beta_count").Text = "N/A";
							recordItem.Fields("beta_score").Text = "N/A";
							recordItem.Fields("tot_val_pct").FontColor = Color.Yellow;
							recordItem.Fields("beta_count").FontColor = Color.Yellow;
							recordItem.Fields("beta_score").FontColor = Color.Yellow;
						}
						recordItem.Fields("last").Text = Utilities.PriceFormat(num4);
					}
					recordItem.Fields("stock").Text = dataRow["stock"].ToString();
					recordItem.Fields("stock").Tag = this.GetPositionType(dataRow["position_type"].ToString().Trim());
					recordItem.Fields("onhand").Text = FormatUtil.VolumeFormat(num, true);
					recordItem.Fields("ttf").Text = Utilities.PriceFormat(dataRow["trustee_id"].ToString());
					recordItem.Fields("avg").Text = Utilities.PriceFormat(num2, (ApplicationInfo.BrokerId == 11) ? 2 : 4);
					Color fontColor = Utilities.ComparePriceColor(price, num3);
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("ttf").FontColor = fontColor;
					recordItem.Fields("onhand").FontColor = fontColor;
					recordItem.Fields("avg").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					num9++;
				}
				this.setSummaryTab();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToReport3", ex);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0004A7CC File Offset: 0x00048BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateCustomerDataToGrid_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaCustHeadTfex.BeginUpdate();
				this.intzaCustHeadTfex.ClearAllText();
				if (this.tdsTfex != null && this.tdsTfex.Tables.Contains("ViewCustomers") && this.tdsTfex.Tables["ViewCustomers"].Rows.Count > 0)
				{
					DataRow dataRow = this.tdsTfex.Tables["ViewCustomers"].Rows[0];
					string text = string.Empty;
					text = dataRow["account_type"].ToString().Trim();
					this.intzaCustHeadTfex.Item("tbCustName").Text = dataRow["name"].ToString().Trim();
					this.intzaCustHeadTfex.Item("tbAccountType").Text = text;
					this.intzaCustHeadTfex.Item("tbTrader").Text = dataRow["trader_name"].ToString().Trim() + " : " + dataRow["trader_id"].ToString().Trim();
					this.intzaCustHeadTfex.Item("tbCustomerType").Text = dataRow["customer_type"].ToString();
					decimal num = 0m;
					decimal.TryParse(dataRow["CashBalancePrev"].ToString(), out num);
					this.intzaCustHeadTfex.Item("CashBalancePrev").Text = num.ToString("#,##0.00");
					decimal num2 = 0m;
					string empty = string.Empty;
					this.intzaCustHeadTfex.Item("lbBuyLimit").Text = "Buy Limit";
					decimal.TryParse(dataRow["buy_credit_limit"].ToString(), out num2);
					this.intzaCustHeadTfex.Item("tbBuyLimit").Text = num2.ToString("#,##0.00");
					decimal num3 = 0m;
					decimal.TryParse(dataRow["credit_line"].ToString(), out num3);
					this.intzaCustHeadTfex.Item("tbCreditLine").Text = num3.ToString("#,##0.00");
				}
				else
				{
					this.intzaCustHeadTfex.Item("tbCustName").Text = "Account not found!";
				}
				if (this.tdsTfex != null && this.tdsTfex.Tables.Contains("ITDSD_Get_Cust_Info") && this.tdsTfex.Tables["ITDSD_Get_Cust_Info"].Rows.Count > 0)
				{
					DataRow dataRow = this.tdsTfex.Tables["ITDSD_Get_Cust_Info"].Rows[0];
					decimal num4 = 0m;
					decimal.TryParse(dataRow["cashbalance"].ToString(), out num4);
					decimal num5 = 0m;
					decimal.TryParse(dataRow["ActualComm"].ToString(), out num5);
					this.intzaCustHeadTfex.Item("tbCommvat").Text = num5.ToString("#,##0.00");
				}
				this.sortGridTfex.BeginUpdate();
				this.sortGridTfex.Rows = 0;
				this.UpdateToBottomControl_TFEX();
				string text2 = string.Empty;
				string text3 = string.Empty;
				this._tfexTotMarketVal = 0m;
				this._tfexCost = 0m;
				this._tfexUnrealSettle = 0m;
				this._tfexUnrealCost = 0m;
				this._tfexReal = 0m;
				if (this.tdsTfex != null && this.tdsTfex.Tables.Contains("ITDSD_Get_Cust_Posi") && this.tdsTfex.Tables["ITDSD_Get_Cust_Posi"].Rows.Count > 0)
				{
					foreach (DataRow dataRow in this.tdsTfex.Tables["ITDSD_Get_Cust_Posi"].Rows)
					{
						text2 = dataRow["Series"].ToString().Trim();
						text3 = dataRow["Side"].ToString();
						SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[text2.ToString().Trim()];
						decimal num6 = 0m;
						DataRow[] array = this.tdsTfex.Tables["Realize"].Select(string.Concat(new string[]
						{
							"Series='",
							text2,
							"' and Side='",
							text3,
							"'"
						}));
						if (array != null && array.Length > 0)
						{
							if (text3 == "L")
							{
								decimal.TryParse(array[0]["realize"].ToString(), out num6);
								num6 *= seriesInformation.ContractSize;
							}
							else if (text3 == "S")
							{
								decimal.TryParse(array[0]["realize"].ToString(), out num6);
								num6 *= seriesInformation.ContractSize;
							}
						}
						this.UpdateToReport1_TFEX(dataRow, num6);
					}
					string empty2 = string.Empty;
					this.sortGridTfexSumm.Records(0).Fields("last").Text = "Total";
					this.sortGridTfexSumm.Records(0).Fields("mkt_val").Text = Utilities.PriceFormat(this._tfexTotMarketVal, 0, "0");
					this.sortGridTfexSumm.Records(0).Fields("cost_val").Text = Utilities.PriceFormat(this._tfexCost, 0, "0");
					this.sortGridTfexSumm.Records(0).Fields("unreal_settle").Text = Utilities.PriceFormat(this._tfexUnrealSettle, 0, "0");
					this.sortGridTfexSumm.Records(0).Fields("unreal_cost").Text = Utilities.PriceFormat(this._tfexUnrealCost, 0, "0");
					this.sortGridTfexSumm.Records(0).Fields("realize").Text = Utilities.PriceFormat(this._tfexReal, 0, "0");
					this.sortGridTfexSumm.Records(0).Fields("last").FontColor = Color.LightGray;
					this.sortGridTfexSumm.Records(0).Fields("mkt_val").FontColor = MyColor.UnChgColor;
					this.sortGridTfexSumm.Records(0).Fields("cost_val").FontColor = MyColor.UnChgColor;
					this.sortGridTfexSumm.Records(0).Fields("unreal_settle").FontColor = Utilities.ComparePriceColor(this._tfexUnrealSettle, 0m);
					this.sortGridTfexSumm.Records(0).Fields("unreal_cost").FontColor = Utilities.ComparePriceColor(this._tfexUnrealCost, 0m);
					this.sortGridTfexSumm.Records(0).Fields("realize").FontColor = Utilities.ComparePriceColor(this._tfexReal, 0m);
					this.sortGridTfexSumm.Redraw();
				}
				if (this.tdsTfex != null)
				{
					this.tdsTfex.Clear();
				}
				this.sortGridTfex.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateCustomerDataToGrid_TFEX", ex);
			}
			finally
			{
				this.intzaCustHeadTfex.EndUpdate();
				if (!base.Visible)
				{
					base.Show();
				}
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0004B098 File Offset: 0x00049498
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToReport1_TFEX(DataRow dr, decimal realize)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[dr["Series"].ToString().Trim()];
				long num = 0L;
				long num2 = 0L;
				long num3 = 0L;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				decimal num7 = 0m;
				decimal num8 = 0m;
				long.TryParse(dr["StartQty"].ToString(), out num3);
				long.TryParse(dr["CurrentQty"].ToString(), out num);
				long.TryParse(dr["SellableQty"].ToString(), out num2);
				decimal.TryParse(dr["CurrentAvgPrice"].ToString(), out num4);
				decimal.TryParse(dr["LastPrice"].ToString(), out num5);
				string text = string.Empty;
				decimal num9 = 0m;
				decimal.TryParse(dr["MarkAvgPrice"].ToString(), out num7);
				decimal.TryParse(dr["FixingPrice"].ToString(), out num8);
				string a = string.Empty;
				if (seriesInformation.MarketId == "TXI")
				{
					a = ApplicationInfo.IndexInfoTfex.TXIState;
				}
				else if (seriesInformation.MarketId == "TXM")
				{
					a = ApplicationInfo.IndexInfoTfex.TXMState;
				}
				else if (seriesInformation.MarketId == "TXC")
				{
					a = ApplicationInfo.IndexInfoTfex.TXCState;
				}
				else if (seriesInformation.MarketId == "TXE")
				{
					a = ApplicationInfo.IndexInfoTfex.TXEState;
				}
				else if (seriesInformation.MarketId == "TXR")
				{
					a = ApplicationInfo.IndexInfoTfex.TXRState;
				}
				else if (seriesInformation.MarketId == "TXS")
				{
					a = ApplicationInfo.IndexInfoTfex.TXSState;
				}
				decimal num10;
				if (a == "3C")
				{
					if (seriesInformation.FixPrice > 0m)
					{
						num10 = seriesInformation.FixPrice;
						num5 = seriesInformation.FixPrice;
					}
					else if (num5 > 0m)
					{
						num10 = num5;
					}
					else
					{
						num10 = seriesInformation.PrevFixPrice;
						num5 = seriesInformation.PrevFixPrice;
					}
				}
				else if (num5 > 0m)
				{
					num10 = num5;
				}
				else
				{
					num10 = seriesInformation.PrevFixPrice;
					num5 = seriesInformation.PrevFixPrice;
				}
				decimal num11 = num2 * num4 * seriesInformation.ContractSize;
				decimal num12 = num2 * num5 * seriesInformation.ContractSize;
				decimal num13 = num2 * num4;
				if (dr["Side"].ToString() == "L")
				{
					text = "Long";
					num6 = (num10 - num7) * num2 * seriesInformation.ContractSize;
					num9 = (num10 - num4) * num2 * seriesInformation.ContractSize;
				}
				else if (dr["Side"].ToString() == "S")
				{
					text = "Short";
					num6 = (num7 - num10) * num2 * seriesInformation.ContractSize;
					num9 = (num4 - num10) * num2 * seriesInformation.ContractSize;
				}
				Color fontColor = MyColor.UnChgColor;
				RecordItem recordItem = this.sortGridTfex.AddRecord(-1, false);
				recordItem.Fields("series").Text = dr["Series"].ToString().Trim();
				recordItem.Fields("side").Text = text;
				recordItem.Fields("start_vol").Text = Utilities.VolumeFormat(num3, true);
				recordItem.Fields("onhand").Text = Utilities.VolumeFormat(num, true);
				recordItem.Fields("sellable").Text = Utilities.VolumeFormat(num2, true);
				recordItem.Fields("cost_avg").Text = Utilities.PriceFormat(num4, 4);
				recordItem.Fields("cost_settle").Text = Utilities.PriceFormat(num7, 4);
				recordItem.Fields("last").Text = Utilities.PriceFormat(num5);
				recordItem.Fields("mkt_val").Text = Utilities.PriceFormat(num12);
				recordItem.Fields("cost_val").Text = Utilities.VolumeFormat(num11, true);
				recordItem.Fields("unreal_settle").Text = Utilities.VolumeFormat(num6, true);
				recordItem.Fields("unreal_cost").Text = Utilities.VolumeFormat(num9, true);
				recordItem.Fields("realize").Text = Utilities.VolumeFormat(realize, true);
				fontColor = Utilities.ComparePriceColor(num6, 0m);
				recordItem.Fields("series").FontColor = fontColor;
				recordItem.Fields("side").FontColor = ((dr["Side"].ToString() == "L") ? MyColor.CeilingColor : MyColor.FloorColor);
				recordItem.Fields("start_vol").FontColor = MyColor.UnChgColor;
				recordItem.Fields("onhand").FontColor = MyColor.UnChgColor;
				recordItem.Fields("sellable").FontColor = MyColor.UnChgColor;
				fontColor = Utilities.ComparePriceColor(num6, 0m);
				recordItem.Fields("cost_settle").FontColor = fontColor;
				recordItem.Fields("cost_avg").FontColor = fontColor;
				recordItem.Fields("last").FontColor = fontColor;
				recordItem.Fields("mkt_val").FontColor = fontColor;
				recordItem.Fields("cost_val").FontColor = fontColor;
				recordItem.Fields("unreal_settle").FontColor = Utilities.ComparePriceColor(num6, 0m);
				recordItem.Fields("unreal_cost").FontColor = Utilities.ComparePriceColor(num9, 0m);
				recordItem.Fields("realize").FontColor = Utilities.ComparePriceColor(realize, 0m);
				this._tfexTotMarketVal += num12;
				this._tfexCost += num11;
				this._tfexUnrealSettle += num6;
				this._tfexUnrealCost += num9;
				this._tfexReal += realize;
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToReport1_TFEX", ex);
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0004B88C File Offset: 0x00049C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToBottomControl_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.UpdateToBottomControl_TFEX));
			}
			else
			{
				try
				{
					this.intzaCustBottTfex.BeginUpdate();
					this.intzaCustBottTfex.ClearAllText();
					if (this.tdsTfex != null && this.tdsTfex.Tables.Contains("ITDSD_Get_Cust_MarginInfo"))
					{
						decimal num = 0m;
						decimal num2 = 0m;
						decimal num3 = 0m;
						decimal num4 = 0m;
						decimal num5 = 0m;
						decimal num6 = 0m;
						string str = string.Empty;
						foreach (DataRow dataRow in this.tdsTfex.Tables["ITDSD_Get_Cust_MarginInfo"].Rows)
						{
							decimal.TryParse(dataRow["EquityBal"].ToString(), out num);
							decimal.TryParse(dataRow["EE"].ToString(), out num2);
							decimal.TryParse(dataRow["PrevFloatPL"].ToString(), out num3);
							decimal.TryParse(dataRow["UnrealPLFuture"].ToString(), out num4);
							decimal.TryParse(dataRow["MarginBal"].ToString(), out num5);
							decimal.TryParse(dataRow["CallForceAmount"].ToString(), out num6);
							if (string.IsNullOrEmpty(dataRow["CallForceFlag"].ToString().Trim()))
							{
								str = "Normal";
							}
							else
							{
								str = dataRow["CallForceFlag"].ToString().Trim();
							}
							if (dataRow["PortType"].ToString().Trim() == "1")
							{
								this.intzaCustBottTfex.Item("tbEquityBalancePrevious").Text = Utilities.PriceFormat(num);
								this.intzaCustBottTfex.Item("tbEquityBalancePrevious").FontColor = Utilities.ComparePriceColor(num, 0m);
								this.intzaCustBottTfex.Item("tbEEBalancePrevious").Text = Utilities.PriceFormat(num2);
								this.intzaCustBottTfex.Item("tbEEBalancePrevious").FontColor = Utilities.ComparePriceColor(num2, 0m);
								this.intzaCustBottTfex.Item("tbUnrealizedPLPrevious").Text = Utilities.PriceFormat(num3);
								this.intzaCustBottTfex.Item("tbUnrealizedPLPrevious").FontColor = Utilities.ComparePriceColor(num3, 0m);
								this.intzaCustBottTfex.Item("tbMarginBalancePrevious").Text = Utilities.PriceFormat(num5);
								this.intzaCustBottTfex.Item("tbMarginBalancePrevious").FontColor = Utilities.ComparePriceColor(num5, 0m);
								this.intzaCustBottTfex.Item("tbCallForcePrevious").Text = str + " / " + Utilities.PriceFormat(num6);
								this.intzaCustBottTfex.Item("tbCallForcePrevious").FontColor = Utilities.ComparePriceColor(num6, 0m);
							}
							else if (dataRow["PortType"].ToString().Trim() == "3")
							{
								this.intzaCustBottTfex.Item("tbEquityBalanceCurrent").Text = Utilities.PriceFormat(num);
								this.intzaCustBottTfex.Item("tbEquityBalanceCurrent").FontColor = Utilities.ComparePriceColor(num, 0m);
								this.intzaCustBottTfex.Item("tbEEBalanceCurrent").Text = Utilities.PriceFormat(num2);
								this.intzaCustBottTfex.Item("tbEEBalanceCurrent").FontColor = Utilities.ComparePriceColor(num2, 0m);
								this.intzaCustBottTfex.Item("tbMarginBalanceCurrent").Text = Utilities.PriceFormat(num5);
								this.intzaCustBottTfex.Item("tbMarginBalanceCurrent").FontColor = Utilities.ComparePriceColor(num5, 0m);
								this.intzaCustBottTfex.Item("tbCallForceCurrent").Text = str + " / " + Utilities.PriceFormat(num6);
								this.intzaCustBottTfex.Item("tbCallForceCurrent").FontColor = Utilities.ComparePriceColor(num6, 0m);
								this.intzaCustHeadTfex.Item("tbDepositWithdraw").Text = Utilities.PriceFormat(dataRow["DepositWithdraw"].ToString());
							}
							else if (dataRow["PortType"].ToString().Trim() == "2")
							{
								this._equityTfex = num;
								this.intzaCustBottTfex.Item("tbEquityBalanceCurrentPort").Text = Utilities.PriceFormat(num);
								this.intzaCustBottTfex.Item("tbEquityBalanceCurrentPort").FontColor = Utilities.ComparePriceColor(num, 0m);
								this.intzaCustBottTfex.Item("tbEEBalanceCurerntPort").Text = Utilities.PriceFormat(num2);
								this.intzaCustBottTfex.Item("tbEEBalanceCurerntPort").FontColor = Utilities.ComparePriceColor(num2, 0m);
								this.intzaCustBottTfex.Item("tbUnrealizedPLCurrentPort").Text = Utilities.PriceFormat(num4);
								this.intzaCustBottTfex.Item("tbUnrealizedPLCurrentPort").FontColor = Utilities.ComparePriceColor(num4, 0m);
								this.intzaCustBottTfex.Item("tbMarginBalanceCurrentPort").Text = Utilities.PriceFormat(num5);
								this.intzaCustBottTfex.Item("tbMarginBalanceCurrentPort").FontColor = Utilities.ComparePriceColor(num5, 0m);
								this.intzaCustBottTfex.Item("tbCallForceCurrentPort").Text = str + " / " + Utilities.PriceFormat(num6);
								this.intzaCustBottTfex.Item("tbCallForceCurrentPort").FontColor = Utilities.ComparePriceColor(num6, 0m);
							}
						}
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					this.intzaCustBottTfex.EndUpdate();
				}
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0004BFB4 File Offset: 0x0004A3B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sortGridTfex_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.RowIndex == -1)
			{
				if (e.Column.Name == "unreal_settle")
				{
					this.sortGridTfex.GetColumn("unreal_settle").Visible = false;
					this.sortGridTfex.GetColumn("cost_settle").Visible = false;
					this.sortGridTfex.GetColumn("unreal_cost").Visible = true;
					this.sortGridTfex.GetColumn("cost_avg").Visible = true;
					this.sortGridTfexSumm.GetColumn("unreal_settle").Visible = false;
					this.sortGridTfexSumm.GetColumn("unreal_cost").Visible = true;
					this.sortGridTfex.Redraw();
					this.sortGridTfexSumm.Redraw();
				}
				else if (e.Column.Name == "unreal_cost")
				{
					this.sortGridTfex.GetColumn("unreal_settle").Visible = true;
					this.sortGridTfex.GetColumn("cost_settle").Visible = true;
					this.sortGridTfex.GetColumn("unreal_cost").Visible = false;
					this.sortGridTfex.GetColumn("cost_avg").Visible = false;
					this.sortGridTfexSumm.GetColumn("unreal_cost").Visible = false;
					this.sortGridTfexSumm.GetColumn("unreal_settle").Visible = true;
					this.sortGridTfex.Redraw();
					this.sortGridTfexSumm.Redraw();
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0004C170 File Offset: 0x0004A570
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToConfirmByStock()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string name = "view_confirm_bystock";
				if (this._subReportType == "Confrim Summary")
				{
					name = "view_customer_confirm";
				}
				if (this.tdsR8.Tables.Contains(name) && this.tdsR8.Tables[name].Rows.Count > 0)
				{
					List<frmPortfolio.RecViewCustomerConfirmSummary> list = new List<frmPortfolio.RecViewCustomerConfirmSummary>();
					List<frmPortfolio.RecViewCustomerConfirmSummary> list2 = new List<frmPortfolio.RecViewCustomerConfirmSummary>();
					List<frmPortfolio.RecViewCustomerConfirmSummary> list3 = new List<frmPortfolio.RecViewCustomerConfirmSummary>();
					List<frmPortfolio.RecViewCustomerConfirmSummary> list4 = new List<frmPortfolio.RecViewCustomerConfirmSummary>();
					foreach (DataRow dataRow in this.tdsR8.Tables[name].Rows)
					{
						frmPortfolio.RecViewCustomerConfirmSummary item = default(frmPortfolio.RecViewCustomerConfirmSummary);
						item.Side = dataRow["side"].ToString();
						if (ApplicationInfo.SupportFreewill)
						{
							if (dataRow["stock"].ToString().IndexOf(":") > -1)
							{
								item.Stock = dataRow["stock"].ToString().Replace(":", "");
								item.TTF = "2";
							}
							else if (dataRow["stock"].ToString().IndexOf("+") > -1)
							{
								item.Stock = dataRow["stock"].ToString().Replace("+", "");
								item.TTF = "1";
							}
							else
							{
								item.Stock = dataRow["stock"].ToString();
								item.TTF = "";
							}
						}
						else
						{
							item.Stock = dataRow["stock"].ToString();
							item.TTF = dataRow["trustee_id"].ToString();
						}
						long.TryParse(dataRow["volume"].ToString(), out item.Volume);
						decimal.TryParse(dataRow["price"].ToString(), out item.Price);
						decimal.TryParse(dataRow["amount"].ToString(), out item.Amount);
						decimal.TryParse(dataRow["Comm_Vat"].ToString(), out item.CommVat);
						if (dataRow["side"].ToString().ToLower() == "b")
						{
							item.NetAmnt = item.Amount + item.CommVat;
							list.Add(item);
						}
						else if (dataRow["side"].ToString().ToLower() == "s")
						{
							item.NetAmnt = item.Amount - item.CommVat;
							list2.Add(item);
						}
						else if (dataRow["side"].ToString().ToLower() == "c")
						{
							item.NetAmnt = item.Amount + item.CommVat;
							list3.Add(item);
						}
						else if (dataRow["side"].ToString().ToLower() == "h")
						{
							item.NetAmnt = item.Amount - item.CommVat;
							list4.Add(item);
						}
					}
					if (this._subReportType == "Confrim by Stock")
					{
						this.UpdateToReport9(list, list2, list3, list4);
					}
					else
					{
						this.UpdateToReport6(list, list2, list3, list4);
					}
					this.ShowCommSlide(this.tdsR8);
					list.Clear();
					list2.Clear();
					list3.Clear();
					list4.Clear();
					list = null;
					list2 = null;
					list3 = null;
					list4 = null;
				}
				this.tdsR8.Clear();
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoadReport_RunWorkerCompleted", ex);
			}
			finally
			{
				base.IsLoadingData = false;
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0004C698 File Offset: 0x0004AA98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToReport9(List<frmPortfolio.RecViewCustomerConfirmSummary> recB, List<frmPortfolio.RecViewCustomerConfirmSummary> recS, List<frmPortfolio.RecViewCustomerConfirmSummary> recC, List<frmPortfolio.RecViewCustomerConfirmSummary> recH)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal num = 0m;
				decimal num2 = 0m;
				decimal num3 = 0m;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				decimal num7 = 0m;
				decimal num8 = 0m;
				decimal num9 = 0m;
				decimal num10 = 0m;
				decimal num11 = 0m;
				decimal num12 = 0m;
				decimal num13 = 0m;
				decimal num14 = 0m;
				decimal num15 = 0m;
				decimal price = 0m;
				string empty = string.Empty;
				string text = string.Empty;
				long num16 = 0L;
				if (recB.Count > 0)
				{
					for (int i = 0; i < recB.Count; i++)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = recB[i].Stock;
						}
						if (text != recB[i].Stock)
						{
							if (num16 > 0L)
							{
								price = num13 / num16;
							}
							this.UpdateR9toGrid("", "*** Sub Total ***", "", num16, price, num13, num14, num15, Color.LightGray);
							num += num13;
							num2 += num14;
							num3 += num15;
							num13 = 0m;
							num14 = 0m;
							num15 = 0m;
							num16 = 0L;
							price = 0m;
							text = recB[i].Stock;
						}
						num13 += recB[i].Amount;
						num14 += Math.Round(recB[i].CommVat, 2, MidpointRounding.AwayFromZero);
						num15 += Math.Round(recB[i].NetAmnt, 2, MidpointRounding.AwayFromZero);
						num16 += recB[i].Volume;
						this.UpdateR9toGrid(recB[i].Side, recB[i].Stock, recB[i].TTF, recB[i].Volume, recB[i].Price, recB[i].Amount, recB[i].CommVat, recB[i].NetAmnt, MyColor.UpColor);
					}
					if (num16 > 0L)
					{
						price = num13 / num16;
					}
					this.UpdateR9toGrid("", "*** Sub Total ***", "", num16, price, num13, num14, num15, Color.LightGray);
					num += num13;
					num2 += Math.Round(num14, 2, MidpointRounding.AwayFromZero);
					num3 += Math.Round(num15, 2, MidpointRounding.AwayFromZero);
					this.UpdateR9toGrid("", "*** TOTAL BOUGHT **", "", 0L, 0m, num, num2, num3, MyColor.UpColor);
				}
				text = string.Empty;
				num13 = 0m;
				num14 = 0m;
				num15 = 0m;
				num16 = 0L;
				price = 0m;
				if (recS.Count > 0)
				{
					for (int i = 0; i < recS.Count; i++)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = recS[i].Stock;
						}
						if (text != recS[i].Stock)
						{
							if (num16 > 0L)
							{
								price = num13 / num16;
							}
							this.UpdateR9toGrid("", "*** Sub Total ***", "", num16, price, num13, num14, num15, Color.LightGray);
							num4 += num13;
							num5 += num14;
							num6 += num15;
							num13 = 0m;
							num14 = 0m;
							num15 = 0m;
							num16 = 0L;
							price = 0m;
							text = recS[i].Stock;
						}
						num13 += recS[i].Amount;
						num14 += Math.Round(recS[i].CommVat, 2, MidpointRounding.AwayFromZero);
						num15 += Math.Round(recS[i].NetAmnt, 2, MidpointRounding.AwayFromZero);
						num16 += recS[i].Volume;
						this.UpdateR9toGrid(recS[i].Side, recS[i].Stock, recS[i].TTF, recS[i].Volume, recS[i].Price, recS[i].Amount, recS[i].CommVat, recS[i].NetAmnt, MyColor.DownColor);
					}
					if (num16 > 0L)
					{
						price = num13 / num16;
					}
					this.UpdateR9toGrid("", "*** Sub Total ***", "", num16, price, num13, num14, num15, Color.LightGray);
					num4 += num13;
					num5 += Math.Round(num14, 2, MidpointRounding.AwayFromZero);
					num6 += Math.Round(num15, 2, MidpointRounding.AwayFromZero);
					this.UpdateR9toGrid("", "*** TOTAL SOLD ***", "", 0L, 0m, num4, num5, num6, MyColor.DownColor);
				}
				text = string.Empty;
				num13 = 0m;
				num14 = 0m;
				num15 = 0m;
				num16 = 0L;
				price = 0m;
				if (recC.Count > 0)
				{
					for (int i = 0; i < recC.Count; i++)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = recC[i].Stock;
						}
						if (text != recC[i].Stock)
						{
							if (num16 > 0L)
							{
								price = num13 / num16;
							}
							this.UpdateR9toGrid("", "*** Sub Total ***", "", num16, price, num13, num14, num15, Color.LightGray);
							num7 += num13;
							num8 += num14;
							num9 += num15;
							num13 = 0m;
							num14 = 0m;
							num15 = 0m;
							num16 = 0L;
							price = 0m;
							text = recC[i].Stock;
						}
						num13 += recC[i].Amount;
						num14 += Math.Round(recC[i].CommVat, 2, MidpointRounding.AwayFromZero);
						num15 += Math.Round(recC[i].NetAmnt, 2, MidpointRounding.AwayFromZero);
						num16 += recC[i].Volume;
						this.UpdateR9toGrid(recC[i].Side, recC[i].Stock, recC[i].TTF, recC[i].Volume, recC[i].Price, recC[i].Amount, recC[i].CommVat, recC[i].NetAmnt, Color.Cyan);
					}
					if (num16 > 0L)
					{
						price = num13 / num16;
					}
					this.UpdateR9toGrid("", "*** Sub Total ***", "", num16, price, num13, num14, num15, Color.LightGray);
					num7 += num13;
					num8 += Math.Round(num14, 2, MidpointRounding.AwayFromZero);
					num9 += Math.Round(num15, 2, MidpointRounding.AwayFromZero);
					this.UpdateR9toGrid("", "*** TOTAL COVER ***", "", 0L, 0m, num7, num8, num9, Color.Cyan);
				}
				text = string.Empty;
				num13 = 0m;
				num14 = 0m;
				num15 = 0m;
				num16 = 0L;
				price = 0m;
				if (recH.Count > 0)
				{
					for (int i = 0; i < recH.Count; i++)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = recH[i].Stock;
						}
						if (text != recH[i].Stock)
						{
							if (num16 > 0L)
							{
								price = num13 / num16;
							}
							this.UpdateR9toGrid("", "*** Sub Total ***", "", num16, price, num13, num14, num15, Color.LightGray);
							num10 += num13;
							num11 += num14;
							num12 += num15;
							num13 = 0m;
							num14 = 0m;
							num15 = 0m;
							num16 = 0L;
							price = 0m;
							text = recH[i].Stock;
						}
						num13 += recH[i].Amount;
						num14 += Math.Round(recH[i].CommVat, 2, MidpointRounding.AwayFromZero);
						num15 += Math.Round(recH[i].NetAmnt, 2, MidpointRounding.AwayFromZero);
						num16 += recH[i].Volume;
						this.UpdateR9toGrid(recH[i].Side, recH[i].Stock, recH[i].TTF, recH[i].Volume, recH[i].Price, recH[i].Amount, recH[i].CommVat, recH[i].NetAmnt, Color.Magenta);
					}
					if (num16 > 0L)
					{
						price = num13 / num16;
					}
					this.UpdateR9toGrid("", "*** Sub Total ***", "", num16, price, num13, num14, num15, Color.LightGray);
					num10 += num13;
					num11 += Math.Round(num14, 2, MidpointRounding.AwayFromZero);
					num12 += Math.Round(num15, 2, MidpointRounding.AwayFromZero);
					this.UpdateR9toGrid("", "*** TOTAL SHORT ***", "", 0L, 0m, num10, num11, num12, Color.Magenta);
				}
				decimal num17 = num4 + num10 - (num + num7);
				decimal num18 = this.GetSpTotolCommVAT(this.tdsR8);
				if (num18 == 0m)
				{
					num18 = num2 + num5 + num8 + num11;
				}
				decimal num19 = num18;
				decimal netAmount = num17 - num19;
				this.UpdateR9toGrid("", "*** TOTAL NET ***", "", 0L, 0m, num17, num19, netAmount, Color.Orange);
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToReport9", ex);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0004D2DC File Offset: 0x0004B6DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateR9toGrid(string side, string stock, string ttf, long volume, decimal price, decimal amount, decimal commVAT, decimal netAmount, Color color)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				RecordItem recordItem = this.intzaReport.AddRecord(-1, false);
				recordItem.Fields("side").Text = side;
				recordItem.Fields("stock").Text = stock;
				recordItem.Fields("ttf").Text = ttf;
				recordItem.Fields("volume").Text = Utilities.VolumeFormat(volume, true);
				recordItem.Fields("price").Text = price;
				recordItem.Fields("amount").Text = amount;
				recordItem.Fields("commvat").Text = commVAT;
				recordItem.Fields("netamount").Text = netAmount;
				recordItem.Fields("side").FontColor = color;
				recordItem.Fields("stock").FontColor = color;
				recordItem.Fields("ttf").FontColor = color;
				recordItem.Fields("volume").FontColor = color;
				recordItem.Fields("price").FontColor = color;
				recordItem.Fields("amount").FontColor = color;
				recordItem.Fields("commvat").FontColor = color;
				recordItem.Fields("netamount").FontColor = color;
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateR9toGrid", ex);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0004D48C File Offset: 0x0004B88C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateR9_2toGrid(string message, string subMessage, decimal value)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				RecordItem recordItem = this.intzaReport.AddRecord(-1, false);
				recordItem.Fields("stock").Text = message;
				recordItem.Fields("volume").Text = subMessage;
				recordItem.Fields("price").Text = value;
				recordItem.Fields("stock").FontColor = MyColor.UnChgColor;
				recordItem.Fields("volume").FontColor = MyColor.UnChgColor;
				recordItem.Fields("price").FontColor = MyColor.UnChgColor;
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateR9_2toGrid", ex);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0004D560 File Offset: 0x0004B960
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToReport6(List<frmPortfolio.RecViewCustomerConfirmSummary> recB, List<frmPortfolio.RecViewCustomerConfirmSummary> recS, List<frmPortfolio.RecViewCustomerConfirmSummary> recC, List<frmPortfolio.RecViewCustomerConfirmSummary> recH)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal num = 0m;
				decimal num2 = 0m;
				decimal num3 = 0m;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				decimal num7 = 0m;
				decimal num8 = 0m;
				decimal num9 = 0m;
				decimal num10 = 0m;
				decimal num11 = 0m;
				decimal num12 = 0m;
				if (recB.Count > 0)
				{
					for (int i = 0; i < recB.Count; i++)
					{
						num += recB[i].Amount;
						num2 += Math.Round(recB[i].CommVat, 2, MidpointRounding.AwayFromZero);
						num3 += Math.Round(recB[i].NetAmnt, 2, MidpointRounding.AwayFromZero);
						this.UpdateR9toGrid(recB[i].Side, recB[i].Stock, recB[i].TTF, recB[i].Volume, recB[i].Price, recB[i].Amount, recB[i].CommVat, recB[i].NetAmnt, MyColor.UpColor);
					}
					this.UpdateR9toGrid("", "*** TOTAL BOUGHT **", "", 0L, 0m, num, num2, num3, MyColor.UpColor);
				}
				if (recS.Count > 0)
				{
					for (int i = 0; i < recS.Count; i++)
					{
						num4 += recS[i].Amount;
						num5 += Math.Round(recS[i].CommVat, 2, MidpointRounding.AwayFromZero);
						num6 += Math.Round(recS[i].NetAmnt, 2, MidpointRounding.AwayFromZero);
						this.UpdateR9toGrid(recS[i].Side, recS[i].Stock, recS[i].TTF, recS[i].Volume, recS[i].Price, recS[i].Amount, recS[i].CommVat, recS[i].NetAmnt, MyColor.DownColor);
					}
					this.UpdateR9toGrid("", "*** TOTAL SOLD ***", "", 0L, 0m, num4, num5, num6, MyColor.DownColor);
				}
				if (recC.Count > 0)
				{
					for (int i = 0; i < recC.Count; i++)
					{
						num7 += recC[i].Amount;
						num8 += Math.Round(recC[i].CommVat, 2, MidpointRounding.AwayFromZero);
						num9 += Math.Round(recC[i].NetAmnt, 2, MidpointRounding.AwayFromZero);
						this.UpdateR9toGrid(recC[i].Side, recC[i].Stock, recC[i].TTF, recC[i].Volume, recC[i].Price, recC[i].Amount, recC[i].CommVat, recC[i].NetAmnt, Color.Cyan);
					}
					this.UpdateR9toGrid("", "*** TOTAL COVER ***", "", 0L, 0m, num7, num8, num9, Color.Cyan);
				}
				if (recH.Count > 0)
				{
					for (int i = 0; i < recH.Count; i++)
					{
						num10 += recH[i].Amount;
						num11 += Math.Round(recH[i].CommVat, 2, MidpointRounding.AwayFromZero);
						num12 += Math.Round(recH[i].NetAmnt, 2, MidpointRounding.AwayFromZero);
						this.UpdateR9toGrid(recH[i].Side, recH[i].Stock, recH[i].TTF, recH[i].Volume, recH[i].Price, recH[i].Amount, recH[i].CommVat, recH[i].NetAmnt, Color.Magenta);
					}
					this.UpdateR9toGrid("", "*** TOTAL SHORT ***", "", 0L, 0m, num10, num11, num12, Color.Magenta);
				}
				decimal num13 = num4 + num10 - (num + num7);
				decimal num14 = this.GetSpTotolCommVAT(this.tdsR8);
				if (num14 == 0m)
				{
					num14 = num2 + num5 + num8 + num11;
				}
				decimal netAmount = num13 - num14;
				this.UpdateR9toGrid("", "*** TOTAL NET ***", "", 0L, 0m, num13, num14, netAmount, Color.Orange);
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToReport9", ex);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0004DB3C File Offset: 0x0004BF3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CustomerSummarySideGroup(DataRow item)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				bool flag = false;
				foreach (KeyValuePair<decimal, long> current in this.summaryMaper)
				{
					decimal d;
					decimal.TryParse(item["deal_price"].ToString(), out d);
					if (current.Key == d)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					foreach (KeyValuePair<decimal, long> current in this.summaryMaper)
					{
						decimal d2;
						decimal.TryParse(item["deal_price"].ToString(), out d2);
						if (current.Key == d2)
						{
							long num;
							long.TryParse(item["deal_volume"].ToString(), out num);
							decimal num2;
							decimal.TryParse(item["deal_price"].ToString(), out num2);
							long value = current.Value + num;
							if (this.summaryMaper.Count > 0)
							{
								this.summaryMaper.Remove(num2);
							}
							this.summaryMaper.Add(num2, value);
							break;
						}
					}
				}
				else if (item["deal_price"] != null)
				{
					long num;
					long.TryParse(item["deal_volume"].ToString(), out num);
					decimal num2;
					decimal.TryParse(item["deal_price"].ToString(), out num2);
					if (num2 > 0m)
					{
						this.summaryMaper.Add(num2, num);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SummarySideGroup", ex);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0004DDB8 File Offset: 0x0004C1B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToReport4(DataRow dr)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = 0L;
				long num2 = 0L;
				long num3 = 0L;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				decimal num7 = 0m;
				decimal num8 = 0m;
				decimal d = 0m;
				decimal d2 = 0m;
				long.TryParse(dr["start_share"].ToString(), out num);
				long.TryParse(dr["buy_volume"].ToString(), out num2);
				long.TryParse(dr["sell_volume"].ToString(), out num3);
				decimal.TryParse(dr["sell_avg"].ToString(), out num4);
				decimal.TryParse(dr["cost_avg"].ToString(), out num5);
				decimal.TryParse(dr["sell_total_amount"].ToString(), out num6);
				decimal.TryParse(dr["cost_total_amount"].ToString(), out num7);
				if (ApplicationInfo.SupportFreewill)
				{
					decimal.TryParse(dr["realize_pl"].ToString(), out num8);
				}
				else
				{
					decimal.TryParse(dr["costCommVat"].ToString(), out d2);
					decimal.TryParse(dr["sellComVat"].ToString(), out d);
					if (ApplicationInfo.BrokerId == 2 || ApplicationInfo.BrokerId == 88)
					{
						if (dr["position_type"].ToString() == "S")
						{
							num8 = Math.Round(num7 - num6, 2, MidpointRounding.AwayFromZero);
						}
						else
						{
							num8 = Math.Round(num6 - num7, 2, MidpointRounding.AwayFromZero);
						}
					}
					else if (dr["position_type"].ToString() == "S")
					{
						num8 = Math.Round(num7 - num6 - (d2 + d), 0, MidpointRounding.AwayFromZero);
					}
					else
					{
						num8 = Math.Round(num6 - num7 - (d2 + d), 0, MidpointRounding.AwayFromZero);
					}
				}
				Color fontColor = MyColor.UnChgColor;
				if (num8 > 0m)
				{
					fontColor = MyColor.UpColor;
				}
				else if (num8 < 0m)
				{
					fontColor = MyColor.DownColor;
				}
				RecordItem recordItem = this.intzaReport.AddRecord(-1, false);
				recordItem.Fields("stock").Text = dr["stock"].ToString().Trim();
				recordItem.Fields("stock").Tag = this.GetPositionType(dr["position_type"].ToString().Trim());
				recordItem.Fields("ttf").Text = ((dr["trustee_id"].ToString() == "0") ? string.Empty : dr["trustee_id"].ToString());
				if (dr["position_type"].ToString() != "B")
				{
					recordItem.Fields("start").Text = Utilities.VolumeFormat(num, true);
					recordItem.Fields("today_bh").Text = Utilities.VolumeFormat(num2, true);
					recordItem.Fields("today_sc").Text = Utilities.VolumeFormat(num3, true);
					recordItem.Fields("sc_avg").Text = Utilities.PriceFormat(num4, 4);
					recordItem.Fields("cost_avg").Text = Utilities.PriceFormat(num5, 4);
					recordItem.Fields("sc_amount").Text = Utilities.PriceFormat(num6);
					recordItem.Fields("cost_amount").Text = Utilities.PriceFormat(num7);
					recordItem.Fields("realize").Text = Utilities.PriceFormat(num8);
				}
				recordItem.Fields("stock").FontColor = fontColor;
				recordItem.Fields("ttf").FontColor = fontColor;
				recordItem.Fields("start").FontColor = fontColor;
				recordItem.Fields("today_bh").FontColor = fontColor;
				recordItem.Fields("today_sc").FontColor = fontColor;
				recordItem.Fields("sc_avg").FontColor = fontColor;
				recordItem.Fields("cost_avg").FontColor = fontColor;
				recordItem.Fields("sc_amount").FontColor = fontColor;
				recordItem.Fields("cost_amount").FontColor = fontColor;
				recordItem.Fields("realize").FontColor = fontColor;
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToReport4", ex);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0004E320 File Offset: 0x0004C720
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowCommSlide(DataSet tds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (tds.Tables.Contains("RETURN") && tds.Tables["RETURN"].Rows.Count > 0)
				{
					DataRow dataRow = tds.Tables["RETURN"].Rows[0];
					this.UpdateR9toGrid("", "", "", 0L, 0m, 0m, 0m, 0m, MyColor.UnChgColor);
					decimal value;
					decimal.TryParse(dataRow["TotalCommission"].ToString(), out value);
					this.UpdateR9_2toGrid("COMMISSION", "", value);
					decimal.TryParse(dataRow["TotalTradingFee"].ToString(), out value);
					this.UpdateR9_2toGrid("TRADING FEE", "(" + this._tradingFee.ToString("0.0000") + "%)", value);
					decimal.TryParse(dataRow["TotalClearingFee"].ToString(), out value);
					this.UpdateR9_2toGrid("CLEARING FEE", "(" + this._clearingFee.ToString("0.0000") + "%)", value);
					decimal.TryParse(dataRow["TotalSettlementFee"].ToString(), out value);
					this.UpdateR9_2toGrid("SETTLEMENT FEE", "(" + this._settlementFee.ToString("0.00") + " BAHT)", value);
					decimal.TryParse(dataRow["TotalVAT"].ToString(), out value);
					this.UpdateR9_2toGrid("VAT", "(" + ApplicationInfo.UserVAT.ToString("0.00") + "%)", value);
					decimal.TryParse(dataRow["TotalCommVAT"].ToString(), out value);
					this.UpdateR9_2toGrid("COMMISSION & VAT", "", value);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ShowCommSlide", ex);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0004E570 File Offset: 0x0004C970
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnCreditBalance_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.setVisibleControl("Portfolio", "Credit Balance");
			this.SetResize(true);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0004E59C File Offset: 0x0004C99C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void createColumns(string type)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaReport.Rows = 0;
				this.intzaReport.Columns.Clear();
				this.intzaSumReport.GetColumn("cost").Visible = true;
				this.intzaSumReport.GetColumn("curr_value").Visible = true;
				this.intzaSumReport.GetColumn("unreal_pct").Visible = true;
				this.intzaSumReport.GetColumn("unreal").Visible = true;
				if (type == "Profit/Loss")
				{
					ColumnItem columnItem = new ColumnItem();
					ColumnItem columnItem2 = new ColumnItem();
					ColumnItem columnItem3 = new ColumnItem();
					ColumnItem columnItem4 = new ColumnItem();
					ColumnItem columnItem5 = new ColumnItem();
					ColumnItem columnItem6 = new ColumnItem();
					ColumnItem columnItem7 = new ColumnItem();
					ColumnItem columnItem8 = new ColumnItem();
					ColumnItem columnItem9 = new ColumnItem();
					ColumnItem columnItem10 = new ColumnItem();
					ColumnItem columnItem11 = new ColumnItem();
					columnItem.Alignment = StringAlignment.Near;
					columnItem.BackColor = Color.FromArgb(64, 64, 64);
					columnItem.ColumnAlignment = StringAlignment.Center;
					columnItem.FontColor = Color.LightGray;
					columnItem.MyStyle = FontStyle.Regular;
					columnItem.Name = "stock";
					columnItem.Text = "Symbol";
					columnItem.ValueFormat = FormatType.Symbol;
					columnItem.Visible = true;
					columnItem.Width = 13;
					columnItem2.Alignment = StringAlignment.Center;
					columnItem2.BackColor = Color.FromArgb(64, 64, 64);
					columnItem2.ColumnAlignment = StringAlignment.Center;
					columnItem2.FontColor = Color.LightGray;
					columnItem2.MyStyle = FontStyle.Regular;
					columnItem2.Name = "ttf";
					columnItem2.Text = "TTF";
					columnItem2.ValueFormat = FormatType.Text;
					columnItem2.Visible = true;
					columnItem2.Width = 4;
					columnItem3.Alignment = StringAlignment.Far;
					columnItem3.BackColor = Color.FromArgb(64, 64, 64);
					columnItem3.ColumnAlignment = StringAlignment.Center;
					columnItem3.FontColor = Color.LightGray;
					columnItem3.MyStyle = FontStyle.Regular;
					columnItem3.Name = "onhand";
					columnItem3.Text = "OnHand";
					columnItem3.ValueFormat = FormatType.Text;
					columnItem3.Visible = true;
					columnItem3.Width = 10;
					columnItem4.Alignment = StringAlignment.Far;
					columnItem4.BackColor = Color.FromArgb(64, 64, 64);
					columnItem4.ColumnAlignment = StringAlignment.Center;
					columnItem4.FontColor = Color.LightGray;
					columnItem4.MyStyle = FontStyle.Regular;
					columnItem4.Name = "sellable";
					columnItem4.Text = "Sellable";
					columnItem4.ValueFormat = FormatType.Text;
					columnItem4.Visible = true;
					columnItem4.Width = 10;
					columnItem5.Alignment = StringAlignment.Far;
					columnItem5.BackColor = Color.FromArgb(64, 64, 64);
					columnItem5.ColumnAlignment = StringAlignment.Center;
					columnItem5.FontColor = Color.LightGray;
					columnItem5.MyStyle = FontStyle.Regular;
					columnItem5.Name = "avg";
					columnItem5.Text = "Avg";
					columnItem5.ValueFormat = FormatType.Text;
					columnItem5.Visible = true;
					columnItem5.Width = 9;
					columnItem6.Alignment = StringAlignment.Far;
					columnItem6.BackColor = Color.FromArgb(64, 64, 64);
					columnItem6.ColumnAlignment = StringAlignment.Center;
					columnItem6.FontColor = Color.LightGray;
					columnItem6.MyStyle = FontStyle.Regular;
					columnItem6.Name = "last";
					columnItem6.Text = "Last";
					columnItem6.ValueFormat = FormatType.Text;
					columnItem6.Visible = true;
					columnItem6.Width = 7;
					columnItem7.Alignment = StringAlignment.Far;
					columnItem7.BackColor = Color.FromArgb(64, 64, 64);
					columnItem7.ColumnAlignment = StringAlignment.Center;
					columnItem7.FontColor = Color.LightGray;
					columnItem7.MyStyle = FontStyle.Regular;
					columnItem7.Name = "cost";
					columnItem7.Text = "Cost";
					columnItem7.ValueFormat = FormatType.Text;
					columnItem7.Visible = true;
					columnItem7.Width = 10;
					columnItem8.Alignment = StringAlignment.Far;
					columnItem8.BackColor = Color.FromArgb(64, 64, 64);
					columnItem8.ColumnAlignment = StringAlignment.Center;
					columnItem8.FontColor = Color.LightGray;
					columnItem8.MyStyle = FontStyle.Regular;
					columnItem8.Name = "curr_value";
					columnItem8.Text = "Curr Val";
					columnItem8.ValueFormat = FormatType.Text;
					columnItem8.Visible = true;
					columnItem8.Width = 10;
					columnItem9.Alignment = StringAlignment.Far;
					columnItem9.BackColor = Color.FromArgb(64, 64, 64);
					columnItem9.ColumnAlignment = StringAlignment.Center;
					columnItem9.FontColor = Color.LightGray;
					columnItem9.MyStyle = FontStyle.Regular;
					columnItem9.Name = "unreal_pct";
					columnItem9.Text = "%Unrl";
					columnItem9.ValueFormat = FormatType.Text;
					columnItem9.Visible = true;
					columnItem9.Width = 7;
					columnItem10.Alignment = StringAlignment.Far;
					columnItem10.BackColor = Color.FromArgb(64, 64, 64);
					columnItem10.ColumnAlignment = StringAlignment.Center;
					columnItem10.FontColor = Color.LightGray;
					columnItem10.MyStyle = FontStyle.Regular;
					columnItem10.Name = "unreal";
					columnItem10.Text = "Unrl P/L";
					columnItem10.ValueFormat = FormatType.Text;
					columnItem10.Visible = true;
					columnItem10.Width = 10;
					columnItem11.Alignment = StringAlignment.Far;
					columnItem11.BackColor = Color.FromArgb(64, 64, 64);
					columnItem11.ColumnAlignment = StringAlignment.Center;
					columnItem11.FontColor = Color.LightGray;
					columnItem11.MyStyle = FontStyle.Regular;
					columnItem11.Name = "realize";
					columnItem11.Text = "Real P/L";
					columnItem11.ValueFormat = FormatType.Text;
					columnItem11.Visible = true;
					columnItem11.Width = 10;
					ColumnItem columnItem12 = null;
					if (!ApplicationInfo.SupportFreewill)
					{
						columnItem12 = new ColumnItem();
						columnItem12.Alignment = StringAlignment.Far;
						columnItem12.BackColor = Color.FromArgb(64, 64, 64);
						columnItem12.ColumnAlignment = StringAlignment.Center;
						columnItem12.FontColor = Color.LightGray;
						columnItem12.MyStyle = FontStyle.Regular;
						columnItem12.Name = "netsettle";
						columnItem12.Text = "Net Settle";
						columnItem12.ValueFormat = FormatType.Text;
						columnItem12.Visible = false;
						columnItem12.Width = 10;
					}
					if (!ApplicationInfo.SupportFreewill)
					{
						columnItem11.MyStyle = FontStyle.Underline;
						columnItem12.MyStyle = FontStyle.Underline;
					}
					this.intzaReport.Columns.Add(columnItem);
					this.intzaReport.Columns.Add(columnItem2);
					this.intzaReport.Columns.Add(columnItem3);
					this.intzaReport.Columns.Add(columnItem4);
					this.intzaReport.Columns.Add(columnItem5);
					this.intzaReport.Columns.Add(columnItem6);
					this.intzaReport.Columns.Add(columnItem7);
					this.intzaReport.Columns.Add(columnItem8);
					this.intzaReport.Columns.Add(columnItem9);
					this.intzaReport.Columns.Add(columnItem10);
					this.intzaReport.Columns.Add(columnItem11);
					if (!ApplicationInfo.SupportFreewill)
					{
						this.intzaReport.Columns.Add(columnItem12);
					}
					this.intzaSumReport.GetColumn("text").Width = 53;
					this.intzaSumReport.GetColumn("cost").Width = 10;
					this.intzaSumReport.GetColumn("curr_value").Width = 10;
					this.intzaSumReport.GetColumn("unreal_pct").Width = 7;
					this.intzaSumReport.GetColumn("unreal").Width = 10;
					this.intzaSumReport.GetColumn("realize").Width = 10;
					this.intzaSumReport.GetColumn("realize").Alignment = StringAlignment.Far;
					this.intzaSumReport.Redraw();
				}
				else if (type == "Confrim by Stock")
				{
					ColumnItem columnItem13 = new ColumnItem();
					ColumnItem columnItem14 = new ColumnItem();
					ColumnItem columnItem15 = new ColumnItem();
					ColumnItem columnItem16 = new ColumnItem();
					ColumnItem columnItem17 = new ColumnItem();
					ColumnItem columnItem18 = new ColumnItem();
					ColumnItem columnItem19 = new ColumnItem();
					ColumnItem columnItem20 = new ColumnItem();
					columnItem13.Alignment = StringAlignment.Center;
					columnItem13.BackColor = Color.FromArgb(64, 64, 64);
					columnItem13.ColumnAlignment = StringAlignment.Center;
					columnItem13.FontColor = Color.LightGray;
					columnItem13.MyStyle = FontStyle.Regular;
					columnItem13.Name = "side";
					columnItem13.Text = "Side";
					columnItem13.ValueFormat = FormatType.Text;
					columnItem13.Visible = true;
					columnItem13.Width = 6;
					columnItem14.Alignment = StringAlignment.Near;
					columnItem14.BackColor = Color.FromArgb(64, 64, 64);
					columnItem14.ColumnAlignment = StringAlignment.Center;
					columnItem14.FontColor = Color.LightGray;
					columnItem14.MyStyle = FontStyle.Regular;
					columnItem14.Name = "stock";
					columnItem14.Text = "Symbol";
					columnItem14.ValueFormat = FormatType.Text;
					columnItem14.Visible = true;
					columnItem14.Width = 19;
					columnItem15.Alignment = StringAlignment.Center;
					columnItem15.BackColor = Color.FromArgb(64, 64, 64);
					columnItem15.ColumnAlignment = StringAlignment.Center;
					columnItem15.FontColor = Color.LightGray;
					columnItem15.MyStyle = FontStyle.Regular;
					columnItem15.Name = "ttf";
					columnItem15.Text = "TTF";
					columnItem15.ValueFormat = FormatType.Volume;
					columnItem15.Visible = true;
					columnItem15.Width = 6;
					columnItem16.Alignment = StringAlignment.Far;
					columnItem16.BackColor = Color.FromArgb(64, 64, 64);
					columnItem16.ColumnAlignment = StringAlignment.Center;
					columnItem16.FontColor = Color.LightGray;
					columnItem16.MyStyle = FontStyle.Regular;
					columnItem16.Name = "volume";
					columnItem16.Text = "Volume";
					columnItem16.ValueFormat = FormatType.Text;
					columnItem16.Visible = true;
					columnItem16.Width = 15;
					columnItem17.Alignment = StringAlignment.Far;
					columnItem17.BackColor = Color.FromArgb(64, 64, 64);
					columnItem17.ColumnAlignment = StringAlignment.Center;
					columnItem17.FontColor = Color.LightGray;
					columnItem17.MyStyle = FontStyle.Regular;
					columnItem17.Name = "price";
					columnItem17.Text = "Price";
					columnItem17.ValueFormat = FormatType.Price;
					columnItem17.Visible = true;
					columnItem17.Width = 10;
					columnItem18.Alignment = StringAlignment.Far;
					columnItem18.BackColor = Color.FromArgb(64, 64, 64);
					columnItem18.ColumnAlignment = StringAlignment.Center;
					columnItem18.FontColor = Color.LightGray;
					columnItem18.MyStyle = FontStyle.Regular;
					columnItem18.Name = "amount";
					columnItem18.Text = "Amount";
					columnItem18.ValueFormat = FormatType.Price;
					columnItem18.Visible = true;
					columnItem18.Width = 16;
					columnItem19.Alignment = StringAlignment.Far;
					columnItem19.BackColor = Color.FromArgb(64, 64, 64);
					columnItem19.ColumnAlignment = StringAlignment.Center;
					columnItem19.FontColor = Color.LightGray;
					columnItem19.MyStyle = FontStyle.Regular;
					columnItem19.Name = "commvat";
					columnItem19.Text = "Comm+VAT";
					columnItem19.ValueFormat = FormatType.Price;
					columnItem19.Visible = true;
					columnItem19.Width = 12;
					columnItem20.Alignment = StringAlignment.Far;
					columnItem20.BackColor = Color.FromArgb(64, 64, 64);
					columnItem20.ColumnAlignment = StringAlignment.Center;
					columnItem20.FontColor = Color.LightGray;
					columnItem20.MyStyle = FontStyle.Regular;
					columnItem20.Name = "netamount";
					columnItem20.Text = "Net Amt";
					columnItem20.ValueFormat = FormatType.Price;
					columnItem20.Visible = true;
					columnItem20.Width = 16;
					this.intzaReport.Columns.Add(columnItem13);
					this.intzaReport.Columns.Add(columnItem14);
					this.intzaReport.Columns.Add(columnItem15);
					this.intzaReport.Columns.Add(columnItem16);
					this.intzaReport.Columns.Add(columnItem17);
					this.intzaReport.Columns.Add(columnItem18);
					this.intzaReport.Columns.Add(columnItem19);
					this.intzaReport.Columns.Add(columnItem20);
				}
				else if (type == "Realize Profit/Loss")
				{
					ColumnItem columnItem = new ColumnItem();
					ColumnItem columnItem2 = new ColumnItem();
					ColumnItem columnItem12 = new ColumnItem();
					ColumnItem columnItem3 = new ColumnItem();
					ColumnItem columnItem4 = new ColumnItem();
					ColumnItem columnItem5 = new ColumnItem();
					ColumnItem columnItem6 = new ColumnItem();
					ColumnItem columnItem7 = new ColumnItem();
					ColumnItem columnItem8 = new ColumnItem();
					ColumnItem columnItem9 = new ColumnItem();
					columnItem.Alignment = StringAlignment.Near;
					columnItem.BackColor = Color.FromArgb(64, 64, 64);
					columnItem.ColumnAlignment = StringAlignment.Center;
					columnItem.FontColor = Color.LightGray;
					columnItem.MyStyle = FontStyle.Regular;
					columnItem.Name = "stock";
					columnItem.Text = "Symbol";
					columnItem.ValueFormat = FormatType.Symbol;
					columnItem.Visible = true;
					columnItem.Width = 13;
					columnItem2.Alignment = StringAlignment.Center;
					columnItem2.BackColor = Color.FromArgb(64, 64, 64);
					columnItem2.ColumnAlignment = StringAlignment.Center;
					columnItem2.FontColor = Color.LightGray;
					columnItem2.MyStyle = FontStyle.Regular;
					columnItem2.Name = "ttf";
					columnItem2.Text = "TTF";
					columnItem2.ValueFormat = FormatType.Text;
					columnItem2.Visible = true;
					columnItem2.Width = 4;
					columnItem12.Alignment = StringAlignment.Far;
					columnItem12.BackColor = Color.FromArgb(64, 64, 64);
					columnItem12.ColumnAlignment = StringAlignment.Center;
					columnItem12.FontColor = Color.LightGray;
					columnItem12.MyStyle = FontStyle.Regular;
					columnItem12.Name = "start";
					columnItem12.Text = "Start";
					columnItem12.ValueFormat = FormatType.Text;
					columnItem12.Visible = true;
					columnItem12.Width = 10;
					columnItem3.Alignment = StringAlignment.Far;
					columnItem3.BackColor = Color.FromArgb(64, 64, 64);
					columnItem3.ColumnAlignment = StringAlignment.Center;
					columnItem3.FontColor = Color.LightGray;
					columnItem3.MyStyle = FontStyle.Regular;
					columnItem3.Name = "today_bh";
					columnItem3.Text = "B/H Today";
					columnItem3.ValueFormat = FormatType.Text;
					columnItem3.Visible = true;
					columnItem3.Width = 10;
					columnItem4.Alignment = StringAlignment.Far;
					columnItem4.BackColor = Color.FromArgb(64, 64, 64);
					columnItem4.ColumnAlignment = StringAlignment.Center;
					columnItem4.FontColor = Color.LightGray;
					columnItem4.MyStyle = FontStyle.Regular;
					columnItem4.Name = "today_sc";
					columnItem4.Text = "S/C Today";
					columnItem4.ValueFormat = FormatType.Text;
					columnItem4.Visible = true;
					columnItem4.Width = 10;
					columnItem5.Alignment = StringAlignment.Far;
					columnItem5.BackColor = Color.FromArgb(64, 64, 64);
					columnItem5.ColumnAlignment = StringAlignment.Center;
					columnItem5.FontColor = Color.LightGray;
					columnItem5.MyStyle = FontStyle.Regular;
					columnItem5.Name = "sc_avg";
					columnItem5.Text = "S/C Avg";
					columnItem5.ValueFormat = FormatType.Text;
					columnItem5.Visible = true;
					columnItem5.Width = 9;
					columnItem6.Alignment = StringAlignment.Far;
					columnItem6.BackColor = Color.FromArgb(64, 64, 64);
					columnItem6.ColumnAlignment = StringAlignment.Center;
					columnItem6.FontColor = Color.LightGray;
					columnItem6.MyStyle = FontStyle.Regular;
					columnItem6.Name = "cost_avg";
					columnItem6.Text = "Cost Avg";
					columnItem6.ValueFormat = FormatType.Text;
					columnItem6.Visible = true;
					columnItem6.Width = 9;
					columnItem7.Alignment = StringAlignment.Far;
					columnItem7.BackColor = Color.FromArgb(64, 64, 64);
					columnItem7.ColumnAlignment = StringAlignment.Center;
					columnItem7.FontColor = Color.LightGray;
					columnItem7.MyStyle = FontStyle.Regular;
					columnItem7.Name = "sc_amount";
					columnItem7.Text = "S/C Amount";
					columnItem7.ValueFormat = FormatType.Text;
					columnItem7.Visible = true;
					columnItem7.Width = 11;
					columnItem8.Alignment = StringAlignment.Far;
					columnItem8.BackColor = Color.FromArgb(64, 64, 64);
					columnItem8.ColumnAlignment = StringAlignment.Center;
					columnItem8.FontColor = Color.LightGray;
					columnItem8.MyStyle = FontStyle.Regular;
					columnItem8.Name = "cost_amount";
					columnItem8.Text = "Cost Amount";
					columnItem8.ValueFormat = FormatType.Text;
					columnItem8.Visible = true;
					columnItem8.Width = 12;
					columnItem9.Alignment = StringAlignment.Far;
					columnItem9.BackColor = Color.FromArgb(64, 64, 64);
					columnItem9.ColumnAlignment = StringAlignment.Center;
					columnItem9.FontColor = Color.LightGray;
					columnItem9.MyStyle = FontStyle.Regular;
					columnItem9.Name = "realize";
					columnItem9.Text = "Realize P/L";
					columnItem9.ValueFormat = FormatType.Text;
					columnItem9.Visible = true;
					columnItem9.Width = 12;
					this.intzaReport.Columns.Add(columnItem);
					this.intzaReport.Columns.Add(columnItem2);
					this.intzaReport.Columns.Add(columnItem12);
					this.intzaReport.Columns.Add(columnItem3);
					this.intzaReport.Columns.Add(columnItem4);
					this.intzaReport.Columns.Add(columnItem5);
					this.intzaReport.Columns.Add(columnItem6);
					this.intzaReport.Columns.Add(columnItem7);
					this.intzaReport.Columns.Add(columnItem8);
					this.intzaReport.Columns.Add(columnItem9);
					this.intzaSumReport.GetColumn("cost").Visible = true;
					this.intzaSumReport.GetColumn("curr_value").Visible = true;
					this.intzaSumReport.GetColumn("unreal_pct").Visible = true;
					this.intzaSumReport.GetColumn("unreal").Visible = true;
				}
				else if (type == "F-Score Analysis")
				{
					ColumnItem columnItem = new ColumnItem();
					ColumnItem columnItem2 = new ColumnItem();
					ColumnItem columnItem3 = new ColumnItem();
					ColumnItem columnItem4 = new ColumnItem();
					ColumnItem columnItem5 = new ColumnItem();
					ColumnItem columnItem6 = new ColumnItem();
					ColumnItem columnItem7 = new ColumnItem();
					ColumnItem columnItem8 = new ColumnItem();
					ColumnItem columnItem9 = new ColumnItem();
					ColumnItem columnItem10 = new ColumnItem();
					ColumnItem columnItem11 = new ColumnItem();
					columnItem.Alignment = StringAlignment.Near;
					columnItem.BackColor = Color.FromArgb(64, 64, 64);
					columnItem.ColumnAlignment = StringAlignment.Center;
					columnItem.FontColor = Color.LightGray;
					columnItem.MyStyle = FontStyle.Regular;
					columnItem.Name = "stock";
					columnItem.Text = "Symbol";
					columnItem.ValueFormat = FormatType.Symbol;
					columnItem.Visible = true;
					columnItem.Width = 13;
					columnItem2.Alignment = StringAlignment.Center;
					columnItem2.BackColor = Color.FromArgb(64, 64, 64);
					columnItem2.ColumnAlignment = StringAlignment.Center;
					columnItem2.FontColor = Color.LightGray;
					columnItem2.MyStyle = FontStyle.Regular;
					columnItem2.Name = "ttf";
					columnItem2.Text = "TTF";
					columnItem2.ValueFormat = FormatType.Text;
					columnItem2.Visible = true;
					columnItem2.Width = 4;
					columnItem3.Alignment = StringAlignment.Far;
					columnItem3.BackColor = Color.FromArgb(64, 64, 64);
					columnItem3.ColumnAlignment = StringAlignment.Center;
					columnItem3.FontColor = Color.LightGray;
					columnItem3.MyStyle = FontStyle.Regular;
					columnItem3.Name = "onhand";
					columnItem3.Text = "OnHand";
					columnItem3.ValueFormat = FormatType.Text;
					columnItem3.Visible = true;
					columnItem3.Width = 10;
					columnItem4.Alignment = StringAlignment.Far;
					columnItem4.BackColor = Color.FromArgb(64, 64, 64);
					columnItem4.ColumnAlignment = StringAlignment.Center;
					columnItem4.FontColor = Color.LightGray;
					columnItem4.MyStyle = FontStyle.Regular;
					columnItem4.Name = "sellable";
					columnItem4.Text = "Sellable";
					columnItem4.ValueFormat = FormatType.Text;
					columnItem4.Visible = true;
					columnItem4.Width = 10;
					columnItem5.Alignment = StringAlignment.Far;
					columnItem5.BackColor = Color.FromArgb(64, 64, 64);
					columnItem5.ColumnAlignment = StringAlignment.Center;
					columnItem5.FontColor = Color.LightGray;
					columnItem5.MyStyle = FontStyle.Regular;
					columnItem5.Name = "avg";
					columnItem5.Text = "Avg";
					columnItem5.ValueFormat = FormatType.Text;
					columnItem5.Visible = true;
					columnItem5.Width = 7;
					columnItem6.Alignment = StringAlignment.Far;
					columnItem6.BackColor = Color.FromArgb(64, 64, 64);
					columnItem6.ColumnAlignment = StringAlignment.Center;
					columnItem6.FontColor = Color.LightGray;
					columnItem6.MyStyle = FontStyle.Regular;
					columnItem6.Name = "last";
					columnItem6.Text = "Last";
					columnItem6.ValueFormat = FormatType.Text;
					columnItem6.Visible = true;
					columnItem6.Width = 7;
					columnItem7.Alignment = StringAlignment.Far;
					columnItem7.BackColor = Color.FromArgb(64, 64, 64);
					columnItem7.ColumnAlignment = StringAlignment.Center;
					columnItem7.FontColor = Color.LightGray;
					columnItem7.MyStyle = FontStyle.Regular;
					columnItem7.Name = "cost";
					columnItem7.Text = "Cost";
					columnItem7.ValueFormat = FormatType.Text;
					columnItem7.Visible = true;
					columnItem7.Width = 10;
					columnItem8.Alignment = StringAlignment.Far;
					columnItem8.BackColor = Color.FromArgb(64, 64, 64);
					columnItem8.ColumnAlignment = StringAlignment.Center;
					columnItem8.FontColor = Color.LightGray;
					columnItem8.MyStyle = FontStyle.Regular;
					columnItem8.Name = "curr_value";
					columnItem8.Text = "Curr Val";
					columnItem8.ValueFormat = FormatType.Text;
					columnItem8.Visible = true;
					columnItem8.Width = 10;
					columnItem9.Alignment = StringAlignment.Center;
					columnItem9.BackColor = Color.FromArgb(64, 64, 64);
					columnItem9.ColumnAlignment = StringAlignment.Center;
					columnItem9.FontColor = Color.LightGray;
					columnItem9.MyStyle = FontStyle.Regular;
					columnItem9.Name = "tot_val_pct";
					columnItem9.Text = "Total Cost(%)";
					columnItem9.ValueFormat = FormatType.Text;
					columnItem9.Visible = true;
					columnItem9.Width = 10;
					columnItem10.Alignment = StringAlignment.Center;
					columnItem10.BackColor = Color.FromArgb(64, 64, 64);
					columnItem10.ColumnAlignment = StringAlignment.Center;
					columnItem10.FontColor = Color.LightGray;
					columnItem10.MyStyle = FontStyle.Regular;
					columnItem10.Name = "f_score";
					columnItem10.Text = "F-Score";
					columnItem10.ValueFormat = FormatType.Text;
					columnItem10.Visible = true;
					columnItem10.Width = 7;
					columnItem11.Alignment = StringAlignment.Center;
					columnItem11.BackColor = Color.FromArgb(64, 64, 64);
					columnItem11.ColumnAlignment = StringAlignment.Center;
					columnItem11.FontColor = Color.LightGray;
					columnItem11.MyStyle = FontStyle.Regular;
					columnItem11.Name = "bal_score_pct";
					columnItem11.Text = "Balance Score(%)";
					columnItem11.ValueFormat = FormatType.Text;
					columnItem11.Visible = true;
					columnItem11.Width = 12;
					this.intzaReport.Columns.Add(columnItem);
					this.intzaReport.Columns.Add(columnItem2);
					this.intzaReport.Columns.Add(columnItem3);
					this.intzaReport.Columns.Add(columnItem4);
					this.intzaReport.Columns.Add(columnItem5);
					this.intzaReport.Columns.Add(columnItem6);
					this.intzaReport.Columns.Add(columnItem7);
					this.intzaReport.Columns.Add(columnItem8);
					this.intzaReport.Columns.Add(columnItem9);
					this.intzaReport.Columns.Add(columnItem10);
					this.intzaReport.Columns.Add(columnItem11);
					this.intzaSumReport.GetColumn("text").Width = 88;
					this.intzaSumReport.GetColumn("cost").Visible = false;
					this.intzaSumReport.GetColumn("curr_value").Visible = false;
					this.intzaSumReport.GetColumn("unreal_pct").Visible = false;
					this.intzaSumReport.GetColumn("unreal").Visible = false;
					this.intzaSumReport.GetColumn("realize").Width = 12;
					this.intzaSumReport.GetColumn("realize").Alignment = StringAlignment.Center;
					this.intzaSumReport.Redraw();
				}
				else if (type == "Beta Analysis")
				{
					ColumnItem columnItem = new ColumnItem();
					ColumnItem columnItem2 = new ColumnItem();
					ColumnItem columnItem3 = new ColumnItem();
					ColumnItem columnItem4 = new ColumnItem();
					ColumnItem columnItem5 = new ColumnItem();
					ColumnItem columnItem6 = new ColumnItem();
					ColumnItem columnItem7 = new ColumnItem();
					ColumnItem columnItem8 = new ColumnItem();
					ColumnItem columnItem9 = new ColumnItem();
					ColumnItem columnItem10 = new ColumnItem();
					ColumnItem columnItem11 = new ColumnItem();
					columnItem.Alignment = StringAlignment.Near;
					columnItem.BackColor = Color.FromArgb(64, 64, 64);
					columnItem.ColumnAlignment = StringAlignment.Center;
					columnItem.FontColor = Color.LightGray;
					columnItem.MyStyle = FontStyle.Regular;
					columnItem.Name = "stock";
					columnItem.Text = "Symbol";
					columnItem.ValueFormat = FormatType.Symbol;
					columnItem.Visible = true;
					columnItem.Width = 13;
					columnItem2.Alignment = StringAlignment.Center;
					columnItem2.BackColor = Color.FromArgb(64, 64, 64);
					columnItem2.ColumnAlignment = StringAlignment.Center;
					columnItem2.FontColor = Color.LightGray;
					columnItem2.MyStyle = FontStyle.Regular;
					columnItem2.Name = "ttf";
					columnItem2.Text = "TTF";
					columnItem2.ValueFormat = FormatType.Text;
					columnItem2.Visible = true;
					columnItem2.Width = 4;
					columnItem3.Alignment = StringAlignment.Far;
					columnItem3.BackColor = Color.FromArgb(64, 64, 64);
					columnItem3.ColumnAlignment = StringAlignment.Center;
					columnItem3.FontColor = Color.LightGray;
					columnItem3.MyStyle = FontStyle.Regular;
					columnItem3.Name = "onhand";
					columnItem3.Text = "OnHand";
					columnItem3.ValueFormat = FormatType.Text;
					columnItem3.Visible = true;
					columnItem3.Width = 11;
					columnItem4.Alignment = StringAlignment.Far;
					columnItem4.BackColor = Color.FromArgb(64, 64, 64);
					columnItem4.ColumnAlignment = StringAlignment.Center;
					columnItem4.FontColor = Color.LightGray;
					columnItem4.MyStyle = FontStyle.Regular;
					columnItem4.Name = "avg";
					columnItem4.Text = "Avg";
					columnItem4.ValueFormat = FormatType.Text;
					columnItem4.Visible = true;
					columnItem4.Width = 8;
					columnItem5.Alignment = StringAlignment.Far;
					columnItem5.BackColor = Color.FromArgb(64, 64, 64);
					columnItem5.ColumnAlignment = StringAlignment.Center;
					columnItem5.FontColor = Color.LightGray;
					columnItem5.MyStyle = FontStyle.Regular;
					columnItem5.Name = "last";
					columnItem5.Text = "Last";
					columnItem5.ValueFormat = FormatType.Text;
					columnItem5.Visible = true;
					columnItem5.Width = 8;
					columnItem6.Alignment = StringAlignment.Center;
					columnItem6.BackColor = Color.FromArgb(64, 64, 64);
					columnItem6.ColumnAlignment = StringAlignment.Center;
					columnItem6.FontColor = Color.LightGray;
					columnItem6.MyStyle = FontStyle.Regular;
					columnItem6.Name = "beta6";
					columnItem6.Text = "Beta-6Day";
					columnItem6.ValueFormat = FormatType.Text;
					columnItem6.Visible = true;
					columnItem6.Width = 9;
					columnItem7.Alignment = StringAlignment.Center;
					columnItem7.BackColor = Color.FromArgb(64, 64, 64);
					columnItem7.ColumnAlignment = StringAlignment.Center;
					columnItem7.FontColor = Color.LightGray;
					columnItem7.MyStyle = FontStyle.Regular;
					columnItem7.Name = "beta30";
					columnItem7.Text = "Beta-30Day";
					columnItem7.ValueFormat = FormatType.Text;
					columnItem7.Visible = true;
					columnItem7.Width = 9;
					columnItem8.Alignment = StringAlignment.Center;
					columnItem8.BackColor = Color.FromArgb(64, 64, 64);
					columnItem8.ColumnAlignment = StringAlignment.Center;
					columnItem8.FontColor = Color.LightGray;
					columnItem8.MyStyle = FontStyle.Regular;
					columnItem8.Name = "beta90";
					columnItem8.Text = "Beta-90Day";
					columnItem8.ValueFormat = FormatType.Text;
					columnItem8.Visible = true;
					columnItem8.Width = 9;
					columnItem9.Alignment = StringAlignment.Center;
					columnItem9.BackColor = Color.FromArgb(64, 64, 64);
					columnItem9.ColumnAlignment = StringAlignment.Center;
					columnItem9.FontColor = Color.LightGray;
					columnItem9.MyStyle = FontStyle.Regular;
					columnItem9.Name = "beta_count";
					columnItem9.Text = "Avg Beta";
					columnItem9.ValueFormat = FormatType.Text;
					columnItem9.Visible = true;
					columnItem9.Width = 9;
					columnItem10.Alignment = StringAlignment.Center;
					columnItem10.BackColor = Color.FromArgb(64, 64, 64);
					columnItem10.ColumnAlignment = StringAlignment.Center;
					columnItem10.FontColor = Color.LightGray;
					columnItem10.MyStyle = FontStyle.Regular;
					columnItem10.Name = "tot_val_pct";
					columnItem10.Text = "Total Cost(%)";
					columnItem10.ValueFormat = FormatType.Text;
					columnItem10.Visible = true;
					columnItem10.Width = 10;
					columnItem11.Alignment = StringAlignment.Center;
					columnItem11.BackColor = Color.FromArgb(64, 64, 64);
					columnItem11.ColumnAlignment = StringAlignment.Center;
					columnItem11.FontColor = Color.LightGray;
					columnItem11.MyStyle = FontStyle.Regular;
					columnItem11.Name = "beta_score";
					columnItem11.Text = "Beta Score";
					columnItem11.ValueFormat = FormatType.Text;
					columnItem11.Visible = true;
					columnItem11.Width = 10;
					this.intzaReport.Columns.Add(columnItem);
					this.intzaReport.Columns.Add(columnItem2);
					this.intzaReport.Columns.Add(columnItem3);
					this.intzaReport.Columns.Add(columnItem4);
					this.intzaReport.Columns.Add(columnItem5);
					this.intzaReport.Columns.Add(columnItem6);
					this.intzaReport.Columns.Add(columnItem7);
					this.intzaReport.Columns.Add(columnItem8);
					this.intzaReport.Columns.Add(columnItem9);
					this.intzaReport.Columns.Add(columnItem10);
					this.intzaReport.Columns.Add(columnItem11);
					this.intzaSumReport.GetColumn("text").Width = 90;
					this.intzaSumReport.GetColumn("cost").Visible = false;
					this.intzaSumReport.GetColumn("curr_value").Visible = false;
					this.intzaSumReport.GetColumn("unreal_pct").Visible = false;
					this.intzaSumReport.GetColumn("unreal").Visible = false;
					this.intzaSumReport.GetColumn("realize").Width = 10;
					this.intzaSumReport.GetColumn("realize").Alignment = StringAlignment.Center;
					this.intzaSumReport.Redraw();
				}
				this.intzaReport.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("createColumns", ex);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0005052C File Offset: 0x0004E92C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnPrintT_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.BeginInvoke(new frmPortfolio.ShowPrintDailog_TFEX_CallBack(this.ShowPrintDailog_TFEX));
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00050550 File Offset: 0x0004E950
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateHeaderReport_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = string.Empty;
				for (int i = 0; i < this.sortGridTfex.Columns.Count; i++)
				{
					if (this.sortGridTfex.Columns[i].Visible)
					{
						text += this.GetString(this.sortGridTfex.Columns[i].Text, this.sortGridTfex.Columns[i].Width, this.sortGridTfex.Columns[i].ColumnAlignment);
					}
				}
				this._headerMessage = text;
			}
			catch (Exception ex)
			{
				this.ShowError("CreateHeaderReport", ex);
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00050640 File Offset: 0x0004EA40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowPrintDailog_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._textPrint == null)
				{
					this._textPrint = new ArrayList();
				}
				else
				{
					this._textPrint.Clear();
				}
				SortGrid sortGrid = this.sortGridTfex;
				this._headerMessage = "";
				foreach (ColumnItem current in sortGrid.Columns)
				{
					if (current.Visible)
					{
						this._headerMessage += ((current.Alignment == StringAlignment.Near) ? current.Text.PadRight(current.Width, ' ') : current.Text.PadLeft(current.Width, ' '));
					}
				}
				this.SetDetailHeaderText_TFEX(this._headerMessage);
				string text = string.Empty;
				string text2 = string.Empty;
				for (int i = 0; i < sortGrid.Rows; i++)
				{
					foreach (ColumnItem current in sortGrid.Columns)
					{
						if (current.Visible)
						{
							text2 = sortGrid.Records(i).Fields(current.Name).Text.ToString();
							if (current.ValueFormat == FormatType.Symbol && !string.IsNullOrEmpty(sortGrid.Records(i).Fields(current.Name).Tag))
							{
								text2 = text2 + " (" + sortGrid.Records(i).Fields(current.Name).Tag + ")";
							}
							text += ((current.Alignment == StringAlignment.Near) ? text2.PadRight(current.Width, ' ') : text2.PadLeft(current.Width, ' '));
						}
					}
					this.AddPrintText(text);
					text = string.Empty;
				}
				string empty = string.Empty;
				this._PAGEPREVIEW = 0;
				this._previewPrinter = new PrintPreviewDialog();
				this._printDocument = new PrintDocument();
				this._printDialog = new PrintDialog();
				this._printDocument.BeginPrint += new PrintEventHandler(this.OnBeginPrint_TFEX);
				this._printDocument.PrintPage += new PrintPageEventHandler(this.OnPrintPage_TFEX);
				this._printDocument.DocumentName = "Realize  Profit / Loss";
				this._printDialog.Document = this._printDocument;
				this._previewPrinter.Document = this._printDocument;
				this._previewPrinter.ShowDialog();
			}
			catch (Exception ex)
			{
				this.ShowError("ShowPrinter_TFEX", ex);
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0005099C File Offset: 0x0004ED9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnBeginPrint_TFEX(object sender, PrintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.PrintAction == PrintAction.PrintToPrinter)
			{
				if (this._printDialog.ShowDialog() == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
				this._PAGEPREVIEW = 0;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000509F4 File Offset: 0x0004EDF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPrintPage_TFEX(object sender, PrintPageEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			int num = e.MarginBounds.Left - 30;
			int num2 = e.MarginBounds.Top - 30;
			Brush brush = new SolidBrush(Color.Black);
			this._PAGEPREVIEW++;
			e.Graphics.DrawString("#Page " + this._PAGEPREVIEW, new Font("Courier New", 8f, FontStyle.Italic), Brushes.Black, (float)e.MarginBounds.Right, (float)(e.MarginBounds.Bottom + 50));
			while (this.linesPrinted_TFEX < this._textPrint.Count)
			{
				e.Graphics.DrawString(this._textPrint[this.linesPrinted_TFEX++].ToString(), new Font("Courier New", 8f, FontStyle.Regular), brush, (float)num, (float)num2);
				num2 += 15;
				if (num2 >= e.MarginBounds.Bottom && this.linesPrinted_TFEX < this._textPrint.Count)
				{
					e.HasMorePages = true;
					return;
				}
			}
			this.linesPrinted_TFEX = 0;
			e.HasMorePages = false;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00050B68 File Offset: 0x0004EF68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDetailHeaderText_TFEX(string columnsHeaderText)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string empty = string.Empty;
			try
			{
				this.AddPrintText_TFEX("                            " + ApplicationInfo.GetFullNameBroker(ApplicationInfo.BrokerId));
				this.AddPrintText_TFEX(DateTime.Now.ToString("MMM dd,yyyy hh:mm:ss"));
				this.AddPrintText_TFEX("Customer  :  " + this._currAccount + "                NAME : " + this.intzaCustHeadTfex.Item("tbCustName").Text);
				this.AddPrintText_TFEX(string.Concat(new string[]
				{
					"Cust Type :  ",
					this.intzaCustHeadTfex.Item("tbCustomerType").Text,
					"                    Acc. Type : ",
					this.intzaCustHeadTfex.Item("tbAccountType").Text,
					"                      Flag : ",
					this.intzaCustHeadTfex.Item("tbCustomerFlag").Text
				}));
				this.AddPrintText_TFEX("Buy Limit :  " + this.intzaCustHeadTfex.Item("tbBuyLimit").Text + "          Credit Line : " + this.intzaCustHeadTfex.Item("tbCreditLine").Text);
				this.AddPrintText_TFEX("===========================================================================================================");
				this.AddPrintText_TFEX(columnsHeaderText + "\r\n");
				this.AddPrintText_TFEX("===========================================================================================================");
			}
			catch (Exception ex)
			{
				this.ShowError("SetDetailHeaderText_TFEX", ex);
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00050D08 File Offset: 0x0004F108
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddPrintText_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string content = string.Empty;
				for (int i = 0; i < this.sortGridTfex.Rows; i++)
				{
					content = this.sortGridTfex.Records(i).Fields("col1").Text.ToString();
					this.AddPrintText(content);
					content = string.Empty;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("AddPrintText_TFEX", ex);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00050DA8 File Offset: 0x0004F1A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddPrintText_TFEX(string content)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._textPrint.Add(content);
			}
			catch (Exception ex)
			{
				this.ShowError("AddPrintText_TFEX", ex);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00050E00 File Offset: 0x0004F200
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddPrintText_TFEX(ListView lv)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = string.Empty;
				for (int i = 0; i < lv.Items.Count; i++)
				{
					ListViewItem listViewItem = lv.Items[i];
					for (int j = 0; j < listViewItem.SubItems.Count; j++)
					{
						text += this.GetString(listViewItem.SubItems[j].Text, lv.Columns[j].Width / 10, (StringAlignment)lv.Columns[j].TextAlign);
					}
					this.AddPrintText_TFEX(text);
					text = string.Empty;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("AddPrintText_TFEX", ex);
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00050EF8 File Offset: 0x0004F2F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaReport_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!ApplicationInfo.SupportFreewill)
				{
					if (e.RowIndex == -1)
					{
						if (e.Column.Name == "realize")
						{
							this.intzaReport.GetColumn("realize").Visible = false;
							this.intzaReport.GetColumn("netsettle").Visible = true;
							this.intzaReport.Redraw();
							this.setSummaryTab();
						}
						else if (e.Column.Name == "netsettle")
						{
							this.intzaReport.GetColumn("netsettle").Visible = false;
							this.intzaReport.GetColumn("realize").Visible = true;
							this.intzaReport.Redraw();
							this.setSummaryTab();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaReport_TableMouseClick", ex);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00051030 File Offset: 0x0004F430
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsCbMainSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReportClick(this.tsCbMainSelect.Text, null);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00051054 File Offset: 0x0004F454
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsCbSubSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReportClick(this._reportType, this.tsCbSubSelect.Text);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00051080 File Offset: 0x0004F480
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnPortManHelp_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._subReportType == "F-Score Analysis")
				{
					Process.Start("http://helponline.efinancethai.com/index.php?option=com_content&view=article&id=1392:portfolio-management-f-score-analysis-beta-analysis&catid=144&Itemid=1193");
				}
				else if (this._subReportType == "Beta Analysis")
				{
					Process.Start("http://helponline.efinancethai.com/index.php?option=com_content&view=article&id=1392:portfolio-management-f-score-analysis-beta-analysis&catid=144&Itemid=1193");
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnFacebook_Click", ex);
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00051118 File Offset: 0x0004F518
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnNavAdj_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Point location = new Point((this.panelNav.Width - this.panelNavAdjust.Width) / 2, (this.panelNav.Height - this.panelNavAdjust.Height) / 2);
				this.panelNavAdjust.Location = location;
				this.panelNavAdjust.Visible = !this.panelNavAdjust.Visible;
				this.btnNavAdjOk.Enabled = true;
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnNavAdj_Click", ex);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000511D0 File Offset: 0x0004F5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnNavAdjCancel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.panelNavAdjust.Visible = false;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000511F0 File Offset: 0x0004F5F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnNavAdjOk_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal num;
				decimal.TryParse(this.tbNavAdjAmount.Text, out num);
				if (num <= 0m)
				{
					this.ShowMessageForm("Invalid amount!");
				}
				else
				{
					if (!this.rbNavAdjDeposit.Checked)
					{
						if (!this.rbNavAdjWithdraw.Checked)
						{
							this.ShowMessageForm("Please select Deposit or Withdraw?");
							return;
						}
						num *= -1m;
					}
					this.btnNavAdjOk.Enabled = false;
					string sDate = this.dateTimePicker1.Value.ToString("yyyyMMdd");
					ApplicationInfo.WebOrderService.NAVAdjustmentCompleted -= new NAVAdjustmentCompletedEventHandler(this.WebOrderService_NAVAdjustmentCompleted);
					ApplicationInfo.WebOrderService.NAVAdjustmentCompleted += new NAVAdjustmentCompletedEventHandler(this.WebOrderService_NAVAdjustmentCompleted);
					ApplicationInfo.WebOrderService.NAVAdjustmentAsync(this._currAccount, num, sDate);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnNavAdjOk_Click", ex);
				this.btnNavAdjOk.Enabled = true;
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00051350 File Offset: 0x0004F750
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebOrderService_NAVAdjustmentCompleted(object sender, NAVAdjustmentCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ApplicationInfo.WebOrderService.NAVAdjustmentCompleted -= new NAVAdjustmentCompletedEventHandler(this.WebOrderService_NAVAdjustmentCompleted);
			if (e.Error == null)
			{
				string[] array = e.Result.ToString().Split(new char[]
				{
					':'
				});
				if (array.Length == 2)
				{
					if (array[0] == "Y")
					{
						this.panelNavAdjust.Visible = false;
						this.ShowMessageForm("NAV updated, " + array[1] + " rows effects.");
						if (!this.bgwLoadReport.IsBusy)
						{
							this.bgwLoadReport.RunWorkerAsync();
						}
					}
					else
					{
						this.ShowMessageForm("NAV update fail, " + array[1]);
					}
				}
				else
				{
					this.ShowMessageForm("NAV update fail, " + e.Result.ToString());
				}
			}
			else
			{
				this.ShowError("NAVAdjustmentCompleted", new Exception(e.Error.Message));
			}
			this.btnNavAdjOk.Enabled = true;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00051494 File Offset: 0x0004F894
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbNavAdjAmount_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbNavAdjAmount.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbNavAdjAmount.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbNavAdjAmount.Text.Replace(",", ""));
							this.tbNavAdjAmount.Text = num.ToString("#,###");
							this.tbNavAdjAmount.Select(this.tbNavAdjAmount.Text.Length, 0);
						}
						catch
						{
							this.tbNavAdjAmount.Text = this.tbNavAdjAmount.Text.Substring(0, this.tbNavAdjAmount.Text.Length - 1);
						}
					}
					else
					{
						this.tbNavAdjAmount.Text = this.tbNavAdjAmount.Text.Substring(0, this.tbNavAdjAmount.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbNavAdjAmount_TextChanged", ex);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00051614 File Offset: 0x0004FA14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageForm(string message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmPortfolio.ShowMessageFormCallBack(this.ShowMessageForm), new object[]
				{
					message
				});
			}
			else
			{
				try
				{
					if (this._frmConfirm != null)
					{
						if (!this._frmConfirm.IsDisposed)
						{
							this._frmConfirm.Dispose();
						}
						this._frmConfirm = null;
					}
					this._frmConfirm = new frmOrderFormConfirm(message, frmOrderFormConfirm.OpenStyle.ShowBox);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.Parent = this;
					this._frmConfirm.Location = new Point((this._frmConfirm.Parent.Width - this._frmConfirm.Width) / 2, (this._frmConfirm.Parent.Height - this._frmConfirm.Height) / 2);
					this._frmConfirm.TopMost = true;
					this._frmConfirm.Show();
					this._frmConfirm.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("ShowMessageInFormConfirm", ex);
				}
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00051768 File Offset: 0x0004FB68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsCbTFexMainSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReportClick(this.tsCbTFexMainSelect.Text, null);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0005178C File Offset: 0x0004FB8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsCbTFexSubSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReportClick(this._reportType, this.tsCbTFexSubSelect.Text);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000517B8 File Offset: 0x0004FBB8
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

		// Token: 0x0600047E RID: 1150 RVA: 0x00051808 File Offset: 0x0004FC08
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPortfolio));
			clsPermission clsPermission = new clsPermission();
			clsPermission clsPermission2 = new clsPermission();
			clsPermission clsPermission3 = new clsPermission();
			clsPermission clsPermission4 = new clsPermission();
			ExchangeIntraday exchangeIntraday = new ExchangeIntraday();
			ItemGrid itemGrid = new ItemGrid();
			ItemGrid itemGrid2 = new ItemGrid();
			ItemGrid itemGrid3 = new ItemGrid();
			ItemGrid itemGrid4 = new ItemGrid();
			ItemGrid itemGrid5 = new ItemGrid();
			ItemGrid itemGrid6 = new ItemGrid();
			ItemGrid itemGrid7 = new ItemGrid();
			ItemGrid itemGrid8 = new ItemGrid();
			ItemGrid itemGrid9 = new ItemGrid();
			ItemGrid itemGrid10 = new ItemGrid();
			ItemGrid itemGrid11 = new ItemGrid();
			ItemGrid itemGrid12 = new ItemGrid();
			ItemGrid itemGrid13 = new ItemGrid();
			ItemGrid itemGrid14 = new ItemGrid();
			ItemGrid itemGrid15 = new ItemGrid();
			ItemGrid itemGrid16 = new ItemGrid();
			ItemGrid itemGrid17 = new ItemGrid();
			ItemGrid itemGrid18 = new ItemGrid();
			ItemGrid itemGrid19 = new ItemGrid();
			ItemGrid itemGrid20 = new ItemGrid();
			ItemGrid itemGrid21 = new ItemGrid();
			ItemGrid itemGrid22 = new ItemGrid();
			ItemGrid itemGrid23 = new ItemGrid();
			ItemGrid itemGrid24 = new ItemGrid();
			ItemGrid itemGrid25 = new ItemGrid();
			ItemGrid itemGrid26 = new ItemGrid();
			ItemGrid itemGrid27 = new ItemGrid();
			ItemGrid itemGrid28 = new ItemGrid();
			ItemGrid itemGrid29 = new ItemGrid();
			ItemGrid itemGrid30 = new ItemGrid();
			ItemGrid itemGrid31 = new ItemGrid();
			ItemGrid itemGrid32 = new ItemGrid();
			ItemGrid itemGrid33 = new ItemGrid();
			ItemGrid itemGrid34 = new ItemGrid();
			ItemGrid itemGrid35 = new ItemGrid();
			ItemGrid itemGrid36 = new ItemGrid();
			ItemGrid itemGrid37 = new ItemGrid();
			ItemGrid itemGrid38 = new ItemGrid();
			ItemGrid itemGrid39 = new ItemGrid();
			ItemGrid itemGrid40 = new ItemGrid();
			ItemGrid itemGrid41 = new ItemGrid();
			ItemGrid itemGrid42 = new ItemGrid();
			ItemGrid itemGrid43 = new ItemGrid();
			ItemGrid itemGrid44 = new ItemGrid();
			ItemGrid itemGrid45 = new ItemGrid();
			ItemGrid itemGrid46 = new ItemGrid();
			ItemGrid itemGrid47 = new ItemGrid();
			ItemGrid itemGrid48 = new ItemGrid();
			ItemGrid itemGrid49 = new ItemGrid();
			ItemGrid itemGrid50 = new ItemGrid();
			ItemGrid itemGrid51 = new ItemGrid();
			ItemGrid itemGrid52 = new ItemGrid();
			ItemGrid itemGrid53 = new ItemGrid();
			ItemGrid itemGrid54 = new ItemGrid();
			ItemGrid itemGrid55 = new ItemGrid();
			ItemGrid itemGrid56 = new ItemGrid();
			ItemGrid itemGrid57 = new ItemGrid();
			ItemGrid itemGrid58 = new ItemGrid();
			ItemGrid itemGrid59 = new ItemGrid();
			ItemGrid itemGrid60 = new ItemGrid();
			ItemGrid itemGrid61 = new ItemGrid();
			ItemGrid itemGrid62 = new ItemGrid();
			ItemGrid itemGrid63 = new ItemGrid();
			ItemGrid itemGrid64 = new ItemGrid();
			ItemGrid itemGrid65 = new ItemGrid();
			ItemGrid itemGrid66 = new ItemGrid();
			ItemGrid itemGrid67 = new ItemGrid();
			ItemGrid itemGrid68 = new ItemGrid();
			ItemGrid itemGrid69 = new ItemGrid();
			ItemGrid itemGrid70 = new ItemGrid();
			ItemGrid itemGrid71 = new ItemGrid();
			ItemGrid itemGrid72 = new ItemGrid();
			ItemGrid itemGrid73 = new ItemGrid();
			ItemGrid itemGrid74 = new ItemGrid();
			ItemGrid itemGrid75 = new ItemGrid();
			ItemGrid itemGrid76 = new ItemGrid();
			ItemGrid itemGrid77 = new ItemGrid();
			ItemGrid itemGrid78 = new ItemGrid();
			ItemGrid itemGrid79 = new ItemGrid();
			ItemGrid itemGrid80 = new ItemGrid();
			ItemGrid itemGrid81 = new ItemGrid();
			ItemGrid itemGrid82 = new ItemGrid();
			ItemGrid itemGrid83 = new ItemGrid();
			ItemGrid itemGrid84 = new ItemGrid();
			ItemGrid itemGrid85 = new ItemGrid();
			ItemGrid itemGrid86 = new ItemGrid();
			ItemGrid itemGrid87 = new ItemGrid();
			ItemGrid itemGrid88 = new ItemGrid();
			ItemGrid itemGrid89 = new ItemGrid();
			ItemGrid itemGrid90 = new ItemGrid();
			ItemGrid itemGrid91 = new ItemGrid();
			ItemGrid itemGrid92 = new ItemGrid();
			ItemGrid itemGrid93 = new ItemGrid();
			ItemGrid itemGrid94 = new ItemGrid();
			ItemGrid itemGrid95 = new ItemGrid();
			ItemGrid itemGrid96 = new ItemGrid();
			ItemGrid itemGrid97 = new ItemGrid();
			ItemGrid itemGrid98 = new ItemGrid();
			ItemGrid itemGrid99 = new ItemGrid();
			ItemGrid itemGrid100 = new ItemGrid();
			ItemGrid itemGrid101 = new ItemGrid();
			ItemGrid itemGrid102 = new ItemGrid();
			ItemGrid itemGrid103 = new ItemGrid();
			ItemGrid itemGrid104 = new ItemGrid();
			ItemGrid itemGrid105 = new ItemGrid();
			ItemGrid itemGrid106 = new ItemGrid();
			ItemGrid itemGrid107 = new ItemGrid();
			ItemGrid itemGrid108 = new ItemGrid();
			ItemGrid itemGrid109 = new ItemGrid();
			ItemGrid itemGrid110 = new ItemGrid();
			ItemGrid itemGrid111 = new ItemGrid();
			ItemGrid itemGrid112 = new ItemGrid();
			ItemGrid itemGrid113 = new ItemGrid();
			ItemGrid itemGrid114 = new ItemGrid();
			ItemGrid itemGrid115 = new ItemGrid();
			ItemGrid itemGrid116 = new ItemGrid();
			ItemGrid itemGrid117 = new ItemGrid();
			ItemGrid itemGrid118 = new ItemGrid();
			ItemGrid itemGrid119 = new ItemGrid();
			ItemGrid itemGrid120 = new ItemGrid();
			ItemGrid itemGrid121 = new ItemGrid();
			ItemGrid itemGrid122 = new ItemGrid();
			ItemGrid itemGrid123 = new ItemGrid();
			ItemGrid itemGrid124 = new ItemGrid();
			ItemGrid itemGrid125 = new ItemGrid();
			ItemGrid itemGrid126 = new ItemGrid();
			ItemGrid itemGrid127 = new ItemGrid();
			ItemGrid itemGrid128 = new ItemGrid();
			ItemGrid itemGrid129 = new ItemGrid();
			ItemGrid itemGrid130 = new ItemGrid();
			ItemGrid itemGrid131 = new ItemGrid();
			ItemGrid itemGrid132 = new ItemGrid();
			ItemGrid itemGrid133 = new ItemGrid();
			ItemGrid itemGrid134 = new ItemGrid();
			ColumnItem columnItem = new ColumnItem();
			ColumnItem columnItem2 = new ColumnItem();
			ColumnItem columnItem3 = new ColumnItem();
			ColumnItem columnItem4 = new ColumnItem();
			ColumnItem columnItem5 = new ColumnItem();
			ColumnItem columnItem6 = new ColumnItem();
			ColumnItem columnItem7 = new ColumnItem();
			ColumnItem columnItem8 = new ColumnItem();
			ColumnItem columnItem9 = new ColumnItem();
			ColumnItem columnItem10 = new ColumnItem();
			ColumnItem columnItem11 = new ColumnItem();
			ColumnItem columnItem12 = new ColumnItem();
			ColumnItem columnItem13 = new ColumnItem();
			ColumnItem columnItem14 = new ColumnItem();
			ColumnItem columnItem15 = new ColumnItem();
			ColumnItem columnItem16 = new ColumnItem();
			ColumnItem columnItem17 = new ColumnItem();
			ColumnItem columnItem18 = new ColumnItem();
			ColumnItem columnItem19 = new ColumnItem();
			ColumnItem columnItem20 = new ColumnItem();
			ColumnItem columnItem21 = new ColumnItem();
			ColumnItem columnItem22 = new ColumnItem();
			ColumnItem columnItem23 = new ColumnItem();
			ColumnItem columnItem24 = new ColumnItem();
			ColumnItem columnItem25 = new ColumnItem();
			ColumnItem columnItem26 = new ColumnItem();
			ColumnItem columnItem27 = new ColumnItem();
			ColumnItem columnItem28 = new ColumnItem();
			ColumnItem columnItem29 = new ColumnItem();
			ColumnItem columnItem30 = new ColumnItem();
			ColumnItem columnItem31 = new ColumnItem();
			ColumnItem columnItem32 = new ColumnItem();
			ColumnItem columnItem33 = new ColumnItem();
			ColumnItem columnItem34 = new ColumnItem();
			ColumnItem columnItem35 = new ColumnItem();
			ColumnItem columnItem36 = new ColumnItem();
			ItemGrid itemGrid135 = new ItemGrid();
			ItemGrid itemGrid136 = new ItemGrid();
			ItemGrid itemGrid137 = new ItemGrid();
			ItemGrid itemGrid138 = new ItemGrid();
			ItemGrid itemGrid139 = new ItemGrid();
			ItemGrid itemGrid140 = new ItemGrid();
			ItemGrid itemGrid141 = new ItemGrid();
			ItemGrid itemGrid142 = new ItemGrid();
			ItemGrid itemGrid143 = new ItemGrid();
			ItemGrid itemGrid144 = new ItemGrid();
			ItemGrid itemGrid145 = new ItemGrid();
			ItemGrid itemGrid146 = new ItemGrid();
			ItemGrid itemGrid147 = new ItemGrid();
			ItemGrid itemGrid148 = new ItemGrid();
			ItemGrid itemGrid149 = new ItemGrid();
			ItemGrid itemGrid150 = new ItemGrid();
			ItemGrid itemGrid151 = new ItemGrid();
			ItemGrid itemGrid152 = new ItemGrid();
			ItemGrid itemGrid153 = new ItemGrid();
			ItemGrid itemGrid154 = new ItemGrid();
			ItemGrid itemGrid155 = new ItemGrid();
			ItemGrid itemGrid156 = new ItemGrid();
			ItemGrid itemGrid157 = new ItemGrid();
			ItemGrid itemGrid158 = new ItemGrid();
			ItemGrid itemGrid159 = new ItemGrid();
			ItemGrid itemGrid160 = new ItemGrid();
			ItemGrid itemGrid161 = new ItemGrid();
			ItemGrid itemGrid162 = new ItemGrid();
			ItemGrid itemGrid163 = new ItemGrid();
			ItemGrid itemGrid164 = new ItemGrid();
			ItemGrid itemGrid165 = new ItemGrid();
			ItemGrid itemGrid166 = new ItemGrid();
			ItemGrid itemGrid167 = new ItemGrid();
			ItemGrid itemGrid168 = new ItemGrid();
			ItemGrid itemGrid169 = new ItemGrid();
			ItemGrid itemGrid170 = new ItemGrid();
			ItemGrid itemGrid171 = new ItemGrid();
			ItemGrid itemGrid172 = new ItemGrid();
			ItemGrid itemGrid173 = new ItemGrid();
			ItemGrid itemGrid174 = new ItemGrid();
			ItemGrid itemGrid175 = new ItemGrid();
			ItemGrid itemGrid176 = new ItemGrid();
			ItemGrid itemGrid177 = new ItemGrid();
			ItemGrid itemGrid178 = new ItemGrid();
			ItemGrid itemGrid179 = new ItemGrid();
			ItemGrid itemGrid180 = new ItemGrid();
			ItemGrid itemGrid181 = new ItemGrid();
			ItemGrid itemGrid182 = new ItemGrid();
			ItemGrid itemGrid183 = new ItemGrid();
			ItemGrid itemGrid184 = new ItemGrid();
			ItemGrid itemGrid185 = new ItemGrid();
			ItemGrid itemGrid186 = new ItemGrid();
			this.tStripMain = new ToolStrip();
			this.tsCbMainSelect = new ToolStripComboBox();
			this.tsCbSubSelect = new ToolStripComboBox();
			this.tsbtnPrint = new ToolStripButton();
			this.tsbtnPortManHelp = new ToolStripButton();
			this.wcGraphVolumeSector = new ucVolumeAtPrice();
			this.wcGraphVolume = new ucVolumeAtPrice();
			this.panelNav = new Panel();
			this.panelNavAdjust = new Panel();
			this.btnNavAdjCancel = new Button();
			this.btnNavAdjOk = new Button();
			this.dateTimePicker1 = new DateTimePicker();
			this.lbNavAdjDate = new Label();
			this.tbNavAdjAmount = new TextBox();
			this.lbNavAdjAmount = new Label();
			this.rbNavAdjWithdraw = new RadioButton();
			this.rbNavAdjDeposit = new RadioButton();
			this.lbNavAdjLabel1 = new Label();
			this.monthCalendar1 = new MonthCalendar();
			this.chart = new ChartWinControl();
			this.tStripMenu = new ToolStrip();
			this.toolStripLabel1 = new ToolStripLabel();
			this.tstbStartDate = new ToolStripLabel();
			this.tsbtnSelStartDate = new ToolStripButton();
			this.toolStripLabel2 = new ToolStripLabel();
			this.tstbEndDate = new ToolStripLabel();
			this.tsbtnSelEndDate = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.tsbtnReload = new ToolStripButton();
			this.tsbtnNavAdj = new ToolStripButton();
			this.panelSET = new Panel();
			this.intzaCB_Freewill = new IntzaCustomGrid();
			this.panelReportMenu = new Panel();
			this.toolStrip1 = new ToolStrip();
			this.tslbStock = new ToolStripLabel();
			this.tstbStock2 = new ToolStripTextBox();
			this.tsbtnClearStock = new ToolStripButton();
			this.intzaCB = new IntzaCustomGrid();
			this.intzaInfoHeader = new IntzaCustomGrid();
			this.intzaSumReport = new SortGrid();
			this.intzaReport = new SortGrid();
			this.panelTFEXPort = new Panel();
			this.sortGridTfexSumm = new SortGrid();
			this.sortGridTfex = new SortGrid();
			this.intzaCustBottTfex = new IntzaCustomGrid();
			this.intzaCustHeadTfex = new IntzaCustomGrid();
			this.tStripMainT = new ToolStrip();
			this.tsbtnPrintT = new ToolStripButton();
			this.tsCbTFexMainSelect = new ToolStripComboBox();
			this.tsCbTFexSubSelect = new ToolStripComboBox();
			this.tStripMain.SuspendLayout();
			this.panelNav.SuspendLayout();
			this.panelNavAdjust.SuspendLayout();
			this.tStripMenu.SuspendLayout();
			this.panelSET.SuspendLayout();
			this.panelReportMenu.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panelTFEXPort.SuspendLayout();
			this.tStripMainT.SuspendLayout();
			base.SuspendLayout();
			this.tStripMain.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripMain.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMain.Items.AddRange(new ToolStripItem[]
			{
				this.tsCbMainSelect,
				this.tsCbSubSelect,
				this.tsbtnPrint,
				this.tsbtnPortManHelp
			});
			this.tStripMain.Location = new Point(0, 0);
			this.tStripMain.Name = "tStripMain";
			this.tStripMain.Padding = new Padding(1, 1, 1, 4);
			this.tStripMain.RenderMode = ToolStripRenderMode.System;
			this.tStripMain.Size = new Size(863, 28);
			this.tStripMain.TabIndex = 20;
			this.tStripMain.Tag = "-1";
			this.tStripMain.Text = "toolStrip1";
			this.tsCbMainSelect.AutoSize = false;
			this.tsCbMainSelect.BackColor = Color.FromArgb(30, 30, 30);
			this.tsCbMainSelect.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tsCbMainSelect.DropDownWidth = 130;
			this.tsCbMainSelect.ForeColor = Color.WhiteSmoke;
			this.tsCbMainSelect.Name = "tsCbMainSelect";
			this.tsCbMainSelect.Padding = new Padding(5, 0, 0, 0);
			this.tsCbMainSelect.Size = new Size(50, 23);
			this.tsCbMainSelect.SelectedIndexChanged += new EventHandler(this.tsCbMainSelect_SelectedIndexChanged);
			this.tsCbSubSelect.AutoSize = false;
			this.tsCbSubSelect.BackColor = Color.FromArgb(30, 30, 30);
			this.tsCbSubSelect.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tsCbSubSelect.DropDownWidth = 140;
			this.tsCbSubSelect.ForeColor = Color.WhiteSmoke;
			this.tsCbSubSelect.Name = "tsCbSubSelect";
			this.tsCbSubSelect.Padding = new Padding(5, 0, 0, 0);
			this.tsCbSubSelect.Size = new Size(40, 23);
			this.tsCbSubSelect.SelectedIndexChanged += new EventHandler(this.tsCbSubSelect_SelectedIndexChanged);
			this.tsbtnPrint.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnPrint.BackColor = Color.FromArgb(30, 30, 30);
			this.tsbtnPrint.ForeColor = Color.LightGray;
			this.tsbtnPrint.Image = (Image)componentResourceManager.GetObject("tsbtnPrint.Image");
			this.tsbtnPrint.ImageTransparentColor = Color.Magenta;
			this.tsbtnPrint.Name = "tsbtnPrint";
			this.tsbtnPrint.Size = new Size(52, 20);
			this.tsbtnPrint.Text = "Print";
			this.tsbtnPrint.Click += new EventHandler(this.tsbtnPrint_Click);
			this.tsbtnPortManHelp.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnPortManHelp.ForeColor = Color.LightGray;
			this.tsbtnPortManHelp.Image = (Image)componentResourceManager.GetObject("tsbtnPortManHelp.Image");
			this.tsbtnPortManHelp.ImageTransparentColor = Color.Magenta;
			this.tsbtnPortManHelp.Name = "tsbtnPortManHelp";
			this.tsbtnPortManHelp.Padding = new Padding(0, 0, 5, 0);
			this.tsbtnPortManHelp.Size = new Size(57, 20);
			this.tsbtnPortManHelp.Text = "Help";
			this.tsbtnPortManHelp.ToolTipText = "Portfolio Management Help Online";
			this.tsbtnPortManHelp.Click += new EventHandler(this.tsbtnPortManHelp_Click);
			clsPermission.DisplayBuySell = enumDisplayBuySell.Yes;
			clsPermission.HistoricalDay = 30.0;
			clsPermission.Permission = enumPermission.Visible;
			clsPermission.VolType = null;
			clsPermission.WordingType = null;
			this.wcGraphVolumeSector.ActiveSET = clsPermission;
			clsPermission2.DisplayBuySell = enumDisplayBuySell.Yes;
			clsPermission2.HistoricalDay = 30.0;
			clsPermission2.Permission = enumPermission.Visible;
			clsPermission2.VolType = null;
			clsPermission2.WordingType = null;
			this.wcGraphVolumeSector.ActiveTFEX = clsPermission2;
			this.wcGraphVolumeSector.BackColor = Color.FromArgb(20, 20, 20);
			this.wcGraphVolumeSector.ColorBg = Color.FromArgb(20, 20, 20);
			this.wcGraphVolumeSector.ColorBuy = Color.Lime;
			this.wcGraphVolumeSector.ColorCeiling = Color.Aqua;
			this.wcGraphVolumeSector.ColorDown = Color.Red;
			this.wcGraphVolumeSector.ColorFloor = Color.Fuchsia;
			this.wcGraphVolumeSector.ColorGrid = Color.DimGray;
			this.wcGraphVolumeSector.ColorNoChg = Color.Yellow;
			this.wcGraphVolumeSector.ColorSell = Color.Red;
			this.wcGraphVolumeSector.ColorUp = Color.Lime;
			this.wcGraphVolumeSector.ColorValue = Color.White;
			this.wcGraphVolumeSector.ColorVolume = Color.Yellow;
			this.wcGraphVolumeSector.CurDate = null;
			this.wcGraphVolumeSector.dictIPO = (Dictionary<string, float>)componentResourceManager.GetObject("wcGraphVolumeSector.dictIPO");
			this.wcGraphVolumeSector.FontName = "Arial";
			this.wcGraphVolumeSector.FontSize = 10f;
			this.wcGraphVolumeSector.Location = new Point(259, 100);
			this.wcGraphVolumeSector.Mode = 1;
			this.wcGraphVolumeSector.Name = "wcGraphVolumeSector";
			this.wcGraphVolumeSector.Size = new Size(87, 36);
			this.wcGraphVolumeSector.SymbolList = null;
			this.wcGraphVolumeSector.SymbolType = enumType.eSet;
			this.wcGraphVolumeSector.TabIndex = 31;
			this.wcGraphVolumeSector.TextBoxBgColor = Color.Empty;
			this.wcGraphVolumeSector.TextBoxForeColor = Color.Empty;
			this.wcGraphVolumeSector.TypeMode = enumMode.Previous;
			this.wcGraphVolumeSector.Visible = false;
			clsPermission3.DisplayBuySell = enumDisplayBuySell.Yes;
			clsPermission3.HistoricalDay = 30.0;
			clsPermission3.Permission = enumPermission.Visible;
			clsPermission3.VolType = null;
			clsPermission3.WordingType = null;
			this.wcGraphVolume.ActiveSET = clsPermission3;
			clsPermission4.DisplayBuySell = enumDisplayBuySell.Yes;
			clsPermission4.HistoricalDay = 30.0;
			clsPermission4.Permission = enumPermission.Visible;
			clsPermission4.VolType = null;
			clsPermission4.WordingType = null;
			this.wcGraphVolume.ActiveTFEX = clsPermission4;
			this.wcGraphVolume.BackColor = Color.FromArgb(20, 20, 20);
			this.wcGraphVolume.ColorBg = Color.FromArgb(20, 20, 20);
			this.wcGraphVolume.ColorBuy = Color.Lime;
			this.wcGraphVolume.ColorCeiling = Color.Aqua;
			this.wcGraphVolume.ColorDown = Color.Red;
			this.wcGraphVolume.ColorFloor = Color.Fuchsia;
			this.wcGraphVolume.ColorGrid = Color.DimGray;
			this.wcGraphVolume.ColorNoChg = Color.Yellow;
			this.wcGraphVolume.ColorSell = Color.Red;
			this.wcGraphVolume.ColorUp = Color.Lime;
			this.wcGraphVolume.ColorValue = Color.White;
			this.wcGraphVolume.ColorVolume = Color.Yellow;
			this.wcGraphVolume.CurDate = null;
			this.wcGraphVolume.dictIPO = (Dictionary<string, float>)componentResourceManager.GetObject("wcGraphVolume.dictIPO");
			this.wcGraphVolume.FontName = "Arial";
			this.wcGraphVolume.FontSize = 10f;
			this.wcGraphVolume.Location = new Point(259, 49);
			this.wcGraphVolume.Mode = 1;
			this.wcGraphVolume.Name = "wcGraphVolume";
			this.wcGraphVolume.Size = new Size(87, 36);
			this.wcGraphVolume.SymbolList = null;
			this.wcGraphVolume.SymbolType = enumType.eSet;
			this.wcGraphVolume.TabIndex = 30;
			this.wcGraphVolume.TextBoxBgColor = Color.Empty;
			this.wcGraphVolume.TextBoxForeColor = Color.Empty;
			this.wcGraphVolume.TypeMode = enumMode.Previous;
			this.wcGraphVolume.Visible = false;
			this.panelNav.Controls.Add(this.panelNavAdjust);
			this.panelNav.Controls.Add(this.monthCalendar1);
			this.panelNav.Controls.Add(this.chart);
			this.panelNav.Controls.Add(this.tStripMenu);
			this.panelNav.Location = new Point(460, 30);
			this.panelNav.Name = "panelNav";
			this.panelNav.Size = new Size(397, 167);
			this.panelNav.TabIndex = 54;
			this.panelNav.Visible = false;
			this.panelNavAdjust.BackColor = Color.FromArgb(55, 55, 55);
			this.panelNavAdjust.Controls.Add(this.btnNavAdjCancel);
			this.panelNavAdjust.Controls.Add(this.btnNavAdjOk);
			this.panelNavAdjust.Controls.Add(this.dateTimePicker1);
			this.panelNavAdjust.Controls.Add(this.lbNavAdjDate);
			this.panelNavAdjust.Controls.Add(this.tbNavAdjAmount);
			this.panelNavAdjust.Controls.Add(this.lbNavAdjAmount);
			this.panelNavAdjust.Controls.Add(this.rbNavAdjWithdraw);
			this.panelNavAdjust.Controls.Add(this.rbNavAdjDeposit);
			this.panelNavAdjust.Controls.Add(this.lbNavAdjLabel1);
			this.panelNavAdjust.Location = new Point(43, 32);
			this.panelNavAdjust.Name = "panelNavAdjust";
			this.panelNavAdjust.Size = new Size(243, 133);
			this.panelNavAdjust.TabIndex = 72;
			this.panelNavAdjust.Visible = false;
			this.btnNavAdjCancel.BackColor = Color.FromArgb(70, 70, 70);
			this.btnNavAdjCancel.FlatStyle = FlatStyle.Popup;
			this.btnNavAdjCancel.ForeColor = Color.WhiteSmoke;
			this.btnNavAdjCancel.Location = new Point(127, 103);
			this.btnNavAdjCancel.Name = "btnNavAdjCancel";
			this.btnNavAdjCancel.Size = new Size(75, 23);
			this.btnNavAdjCancel.TabIndex = 8;
			this.btnNavAdjCancel.Text = "Cancel";
			this.btnNavAdjCancel.UseVisualStyleBackColor = false;
			this.btnNavAdjCancel.Click += new EventHandler(this.btnNavAdjCancel_Click);
			this.btnNavAdjOk.BackColor = Color.FromArgb(70, 70, 70);
			this.btnNavAdjOk.FlatStyle = FlatStyle.Popup;
			this.btnNavAdjOk.ForeColor = Color.WhiteSmoke;
			this.btnNavAdjOk.Location = new Point(46, 103);
			this.btnNavAdjOk.Name = "btnNavAdjOk";
			this.btnNavAdjOk.Size = new Size(75, 23);
			this.btnNavAdjOk.TabIndex = 7;
			this.btnNavAdjOk.Text = "Ok";
			this.btnNavAdjOk.UseVisualStyleBackColor = false;
			this.btnNavAdjOk.Click += new EventHandler(this.btnNavAdjOk_Click);
			this.dateTimePicker1.Format = DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new Point(83, 64);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new Size(124, 20);
			this.dateTimePicker1.TabIndex = 6;
			this.lbNavAdjDate.AutoSize = true;
			this.lbNavAdjDate.ForeColor = Color.WhiteSmoke;
			this.lbNavAdjDate.Location = new Point(19, 67);
			this.lbNavAdjDate.Name = "lbNavAdjDate";
			this.lbNavAdjDate.Size = new Size(55, 13);
			this.lbNavAdjDate.TabIndex = 5;
			this.lbNavAdjDate.Text = "Start Date";
			this.tbNavAdjAmount.BorderStyle = BorderStyle.FixedSingle;
			this.tbNavAdjAmount.Location = new Point(83, 37);
			this.tbNavAdjAmount.Name = "tbNavAdjAmount";
			this.tbNavAdjAmount.Size = new Size(124, 20);
			this.tbNavAdjAmount.TabIndex = 4;
			this.tbNavAdjAmount.TextChanged += new EventHandler(this.tbNavAdjAmount_TextChanged);
			this.lbNavAdjAmount.AutoSize = true;
			this.lbNavAdjAmount.ForeColor = Color.WhiteSmoke;
			this.lbNavAdjAmount.Location = new Point(31, 41);
			this.lbNavAdjAmount.Name = "lbNavAdjAmount";
			this.lbNavAdjAmount.Size = new Size(43, 13);
			this.lbNavAdjAmount.TabIndex = 3;
			this.lbNavAdjAmount.Text = "Amount";
			this.rbNavAdjWithdraw.AutoSize = true;
			this.rbNavAdjWithdraw.ForeColor = Color.FromArgb(255, 128, 128);
			this.rbNavAdjWithdraw.Location = new Point(145, 10);
			this.rbNavAdjWithdraw.Name = "rbNavAdjWithdraw";
			this.rbNavAdjWithdraw.Size = new Size(70, 17);
			this.rbNavAdjWithdraw.TabIndex = 2;
			this.rbNavAdjWithdraw.TabStop = true;
			this.rbNavAdjWithdraw.Text = "Withdraw";
			this.rbNavAdjWithdraw.UseVisualStyleBackColor = true;
			this.rbNavAdjDeposit.AutoSize = true;
			this.rbNavAdjDeposit.ForeColor = Color.Lime;
			this.rbNavAdjDeposit.Location = new Point(78, 10);
			this.rbNavAdjDeposit.Name = "rbNavAdjDeposit";
			this.rbNavAdjDeposit.Size = new Size(61, 17);
			this.rbNavAdjDeposit.TabIndex = 1;
			this.rbNavAdjDeposit.TabStop = true;
			this.rbNavAdjDeposit.Text = "Deposit";
			this.rbNavAdjDeposit.UseVisualStyleBackColor = true;
			this.lbNavAdjLabel1.AutoSize = true;
			this.lbNavAdjLabel1.ForeColor = Color.WhiteSmoke;
			this.lbNavAdjLabel1.Location = new Point(33, 11);
			this.lbNavAdjLabel1.Name = "lbNavAdjLabel1";
			this.lbNavAdjLabel1.Size = new Size(36, 13);
			this.lbNavAdjLabel1.TabIndex = 0;
			this.lbNavAdjLabel1.Text = "Adjust";
			this.monthCalendar1.Location = new Point(76, 26);
			this.monthCalendar1.MaxDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
			this.monthCalendar1.MaxSelectionCount = 1;
			this.monthCalendar1.MinDate = new DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 66;
			this.monthCalendar1.Visible = false;
			this.monthCalendar1.DateSelected += new DateRangeEventHandler(this.monthCalendar1_DateSelected);
			this.monthCalendar1.Leave += new EventHandler(this.monthCalendar1_Leave);
			this.chart.AreaPercent = "3;1";
			this.chart.BackColor = Color.FromArgb(30, 30, 30);
			this.chart.CausesValidation = false;
			this.chart.ChartDragMode = ChartDragMode.Axis;
			this.chart.CrossCursorMouseMode = MouseAction.MouseDown;
			this.chart.DefaultFormulas = null;
			this.chart.Designing = false;
			this.chart.Dock = DockStyle.Fill;
			this.chart.EndTime = new DateTime(0L);
			this.chart.FavoriteFormulas = "";
			exchangeIntraday.NativeCycle = true;
			exchangeIntraday.ShowFirstXLabel = true;
			exchangeIntraday.TimePeriods = new TimePeriod[0];
			exchangeIntraday.TimeZone = 7.0;
			this.chart.IntradayInfo = exchangeIntraday;
			this.chart.LatestValueType = LatestValueType.None;
			this.chart.Location = new Point(0, 27);
			this.chart.MaxColumnWidth = 30.0;
			this.chart.MaxPrice = 0.0;
			this.chart.MinPrice = 0.0;
			this.chart.Name = "chart";
			this.chart.NeedDrawCursor = false;
			this.chart.PriceLabelFormat = null;
			this.chart.ScaleType = ScaleType.Default;
			this.chart.SelectFormulaMouseMode = MouseAction.MouseDown;
			this.chart.ShowCursorLabel = false;
			this.chart.ShowHorizontalGrid = ShowLineMode.Default;
			this.chart.ShowStatistic = false;
			this.chart.ShowVerticalGrid = ShowLineMode.Default;
			this.chart.Size = new Size(397, 140);
			this.chart.Skin = "GreenRed";
			this.chart.StartTime = new DateTime(0L);
			this.chart.StickRenderType = StickRenderType.Default;
			this.chart.StockBars = 50;
			this.chart.StockRenderType = StockRenderType.Default;
			this.chart.Symbol = "";
			this.chart.TabIndex = 65;
			this.chart.TabStop = false;
			this.chart.ValueTextMode = ValueTextMode.Default;
			this.tStripMenu.BackColor = Color.FromArgb(35, 35, 35);
			this.tStripMenu.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripLabel1,
				this.tstbStartDate,
				this.tsbtnSelStartDate,
				this.toolStripLabel2,
				this.tstbEndDate,
				this.tsbtnSelEndDate,
				this.toolStripSeparator1,
				this.tsbtnReload,
				this.tsbtnNavAdj
			});
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Padding = new Padding(0, 1, 1, 3);
			this.tStripMenu.RenderMode = ToolStripRenderMode.System;
			this.tStripMenu.Size = new Size(397, 27);
			this.tStripMenu.TabIndex = 64;
			this.tStripMenu.Text = "toolStrip1";
			this.toolStripLabel1.ForeColor = Color.LightGray;
			this.toolStripLabel1.Margin = new Padding(5, 1, 0, 2);
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new Size(64, 20);
			this.toolStripLabel1.Text = "Start Date :";
			this.tstbStartDate.BackColor = Color.FromArgb(45, 45, 45);
			this.tstbStartDate.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tstbStartDate.ForeColor = Color.Yellow;
			this.tstbStartDate.Margin = new Padding(5, 1, 5, 2);
			this.tstbStartDate.Name = "tstbStartDate";
			this.tstbStartDate.Size = new Size(55, 20);
			this.tstbStartDate.Text = "20090101";
			this.tsbtnSelStartDate.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnSelStartDate.Image = (Image)componentResourceManager.GetObject("tsbtnSelStartDate.Image");
			this.tsbtnSelStartDate.ImageTransparentColor = Color.Magenta;
			this.tsbtnSelStartDate.Name = "tsbtnSelStartDate";
			this.tsbtnSelStartDate.Size = new Size(23, 20);
			this.tsbtnSelStartDate.Text = "toolStripButton1";
			this.tsbtnSelStartDate.ToolTipText = "Select Date";
			this.tsbtnSelStartDate.Click += new EventHandler(this.tsbtnSelStartDate_Click);
			this.toolStripLabel2.ForeColor = Color.LightGray;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new Size(60, 20);
			this.toolStripLabel2.Text = "End Date :";
			this.tstbEndDate.BackColor = Color.FromArgb(45, 45, 45);
			this.tstbEndDate.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tstbEndDate.ForeColor = Color.Yellow;
			this.tstbEndDate.Margin = new Padding(5, 1, 5, 2);
			this.tstbEndDate.Name = "tstbEndDate";
			this.tstbEndDate.Size = new Size(55, 20);
			this.tstbEndDate.Text = "20090501";
			this.tsbtnSelEndDate.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnSelEndDate.Image = (Image)componentResourceManager.GetObject("tsbtnSelEndDate.Image");
			this.tsbtnSelEndDate.ImageTransparentColor = Color.Magenta;
			this.tsbtnSelEndDate.Name = "tsbtnSelEndDate";
			this.tsbtnSelEndDate.Size = new Size(23, 20);
			this.tsbtnSelEndDate.Text = "toolStripButton2";
			this.tsbtnSelEndDate.ToolTipText = "Select Date";
			this.tsbtnSelEndDate.Click += new EventHandler(this.tsbtnSelEndDate_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 23);
			this.tsbtnReload.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnReload.Image = Resources.refresh;
			this.tsbtnReload.ImageTransparentColor = Color.Magenta;
			this.tsbtnReload.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnReload.Name = "tsbtnReload";
			this.tsbtnReload.Size = new Size(23, 20);
			this.tsbtnReload.Text = "Reload";
			this.tsbtnReload.Click += new EventHandler(this.tsbtnReload_Click);
			this.tsbtnNavAdj.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnNavAdj.ForeColor = Color.WhiteSmoke;
			this.tsbtnNavAdj.Image = (Image)componentResourceManager.GetObject("tsbtnNavAdj.Image");
			this.tsbtnNavAdj.ImageTransparentColor = Color.Magenta;
			this.tsbtnNavAdj.Name = "tsbtnNavAdj";
			this.tsbtnNavAdj.Size = new Size(47, 20);
			this.tsbtnNavAdj.Text = "Edit";
			this.tsbtnNavAdj.Click += new EventHandler(this.tsbtnNavAdj_Click);
			this.panelSET.BackColor = Color.FromArgb(20, 20, 20);
			this.panelSET.Controls.Add(this.panelNav);
			this.panelSET.Controls.Add(this.intzaCB_Freewill);
			this.panelSET.Controls.Add(this.panelReportMenu);
			this.panelSET.Controls.Add(this.intzaCB);
			this.panelSET.Controls.Add(this.intzaInfoHeader);
			this.panelSET.Controls.Add(this.tStripMain);
			this.panelSET.Controls.Add(this.intzaSumReport);
			this.panelSET.Controls.Add(this.intzaReport);
			this.panelSET.Controls.Add(this.wcGraphVolume);
			this.panelSET.Controls.Add(this.wcGraphVolumeSector);
			this.panelSET.Location = new Point(4, 5);
			this.panelSET.Name = "panelSET";
			this.panelSET.Size = new Size(863, 320);
			this.panelSET.TabIndex = 71;
			this.panelSET.Visible = false;
			this.intzaCB_Freewill.AllowDrop = true;
			this.intzaCB_Freewill.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaCB_Freewill.CanDrag = false;
			this.intzaCB_Freewill.IsAutoRepaint = true;
			this.intzaCB_Freewill.IsDroped = false;
			itemGrid.AdjustFontSize = 0f;
			itemGrid.Alignment = StringAlignment.Near;
			itemGrid.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid.Changed = false;
			itemGrid.FieldType = ItemType.Label2;
			itemGrid.FontColor = Color.LightGray;
			itemGrid.FontStyle = FontStyle.Regular;
			itemGrid.Height = 1f;
			itemGrid.IsBlink = 0;
			itemGrid.Name = "lbAccEE";
			itemGrid.Text = "Acc EE";
			itemGrid.ValueFormat = FormatType.Text;
			itemGrid.Visible = true;
			itemGrid.Width = 10;
			itemGrid.X = 0;
			itemGrid.Y = 0f;
			itemGrid2.AdjustFontSize = 0f;
			itemGrid2.Alignment = StringAlignment.Near;
			itemGrid2.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid2.Changed = false;
			itemGrid2.FieldType = ItemType.Text;
			itemGrid2.FontColor = Color.Yellow;
			itemGrid2.FontStyle = FontStyle.Regular;
			itemGrid2.Height = 1f;
			itemGrid2.IsBlink = 0;
			itemGrid2.Name = "tbAccEE";
			itemGrid2.Text = "";
			itemGrid2.ValueFormat = FormatType.Text;
			itemGrid2.Visible = true;
			itemGrid2.Width = 15;
			itemGrid2.X = 10;
			itemGrid2.Y = 0f;
			itemGrid3.AdjustFontSize = 0f;
			itemGrid3.Alignment = StringAlignment.Near;
			itemGrid3.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid3.Changed = false;
			itemGrid3.FieldType = ItemType.Label2;
			itemGrid3.FontColor = Color.LightGray;
			itemGrid3.FontStyle = FontStyle.Regular;
			itemGrid3.Height = 1f;
			itemGrid3.IsBlink = 0;
			itemGrid3.Name = "lbBuyCredit50";
			itemGrid3.Text = "BCrd 50%";
			itemGrid3.ValueFormat = FormatType.Text;
			itemGrid3.Visible = true;
			itemGrid3.Width = 10;
			itemGrid3.X = 25;
			itemGrid3.Y = 0f;
			itemGrid4.AdjustFontSize = 0f;
			itemGrid4.Alignment = StringAlignment.Near;
			itemGrid4.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid4.Changed = false;
			itemGrid4.FieldType = ItemType.Text;
			itemGrid4.FontColor = Color.Yellow;
			itemGrid4.FontStyle = FontStyle.Regular;
			itemGrid4.Height = 1f;
			itemGrid4.IsBlink = 0;
			itemGrid4.Name = "tbBuyCredit50";
			itemGrid4.Text = "";
			itemGrid4.ValueFormat = FormatType.Text;
			itemGrid4.Visible = true;
			itemGrid4.Width = 15;
			itemGrid4.X = 35;
			itemGrid4.Y = 0f;
			itemGrid5.AdjustFontSize = 0f;
			itemGrid5.Alignment = StringAlignment.Near;
			itemGrid5.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid5.Changed = false;
			itemGrid5.FieldType = ItemType.Label2;
			itemGrid5.FontColor = Color.LightGray;
			itemGrid5.FontStyle = FontStyle.Regular;
			itemGrid5.Height = 1f;
			itemGrid5.IsBlink = 0;
			itemGrid5.Name = "lbBuyCredit60";
			itemGrid5.Text = "BCrd 60%";
			itemGrid5.ValueFormat = FormatType.Text;
			itemGrid5.Visible = true;
			itemGrid5.Width = 10;
			itemGrid5.X = 50;
			itemGrid5.Y = 0f;
			itemGrid6.AdjustFontSize = 0f;
			itemGrid6.Alignment = StringAlignment.Near;
			itemGrid6.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid6.Changed = false;
			itemGrid6.FieldType = ItemType.Text;
			itemGrid6.FontColor = Color.Yellow;
			itemGrid6.FontStyle = FontStyle.Regular;
			itemGrid6.Height = 1f;
			itemGrid6.IsBlink = 0;
			itemGrid6.Name = "tbBuyCredit60";
			itemGrid6.Text = "";
			itemGrid6.ValueFormat = FormatType.Text;
			itemGrid6.Visible = true;
			itemGrid6.Width = 15;
			itemGrid6.X = 60;
			itemGrid6.Y = 0f;
			itemGrid7.AdjustFontSize = 0f;
			itemGrid7.Alignment = StringAlignment.Near;
			itemGrid7.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid7.Changed = false;
			itemGrid7.FieldType = ItemType.Label2;
			itemGrid7.FontColor = Color.LightGray;
			itemGrid7.FontStyle = FontStyle.Regular;
			itemGrid7.Height = 1f;
			itemGrid7.IsBlink = 0;
			itemGrid7.Name = "lbBuyCredit70";
			itemGrid7.Text = "BCrd 70%";
			itemGrid7.ValueFormat = FormatType.Text;
			itemGrid7.Visible = true;
			itemGrid7.Width = 10;
			itemGrid7.X = 75;
			itemGrid7.Y = 0f;
			itemGrid8.AdjustFontSize = 0f;
			itemGrid8.Alignment = StringAlignment.Near;
			itemGrid8.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid8.Changed = false;
			itemGrid8.FieldType = ItemType.Text;
			itemGrid8.FontColor = Color.Yellow;
			itemGrid8.FontStyle = FontStyle.Regular;
			itemGrid8.Height = 1f;
			itemGrid8.IsBlink = 0;
			itemGrid8.Name = "tbBuyCredit70";
			itemGrid8.Text = "";
			itemGrid8.ValueFormat = FormatType.Text;
			itemGrid8.Visible = true;
			itemGrid8.Width = 15;
			itemGrid8.X = 85;
			itemGrid8.Y = 0f;
			itemGrid9.AdjustFontSize = 0f;
			itemGrid9.Alignment = StringAlignment.Near;
			itemGrid9.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid9.Changed = false;
			itemGrid9.FieldType = ItemType.Label2;
			itemGrid9.FontColor = Color.LightGray;
			itemGrid9.FontStyle = FontStyle.Regular;
			itemGrid9.Height = 1f;
			itemGrid9.IsBlink = 0;
			itemGrid9.Name = "lbAssets";
			itemGrid9.Text = "Assets";
			itemGrid9.ValueFormat = FormatType.Text;
			itemGrid9.Visible = true;
			itemGrid9.Width = 10;
			itemGrid9.X = 0;
			itemGrid9.Y = 1f;
			itemGrid10.AdjustFontSize = 0f;
			itemGrid10.Alignment = StringAlignment.Near;
			itemGrid10.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid10.Changed = false;
			itemGrid10.FieldType = ItemType.Text;
			itemGrid10.FontColor = Color.Lime;
			itemGrid10.FontStyle = FontStyle.Regular;
			itemGrid10.Height = 1f;
			itemGrid10.IsBlink = 0;
			itemGrid10.Name = "tbAssets";
			itemGrid10.Text = "";
			itemGrid10.ValueFormat = FormatType.Text;
			itemGrid10.Visible = true;
			itemGrid10.Width = 15;
			itemGrid10.X = 10;
			itemGrid10.Y = 1f;
			itemGrid11.AdjustFontSize = 0f;
			itemGrid11.Alignment = StringAlignment.Near;
			itemGrid11.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid11.Changed = false;
			itemGrid11.FieldType = ItemType.Label2;
			itemGrid11.FontColor = Color.LightGray;
			itemGrid11.FontStyle = FontStyle.Regular;
			itemGrid11.Height = 1f;
			itemGrid11.IsBlink = 0;
			itemGrid11.Name = "lbMR";
			itemGrid11.Text = "MR";
			itemGrid11.ValueFormat = FormatType.Text;
			itemGrid11.Visible = true;
			itemGrid11.Width = 10;
			itemGrid11.X = 25;
			itemGrid11.Y = 1f;
			itemGrid12.AdjustFontSize = 0f;
			itemGrid12.Alignment = StringAlignment.Near;
			itemGrid12.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid12.Changed = false;
			itemGrid12.FieldType = ItemType.Text;
			itemGrid12.FontColor = Color.Yellow;
			itemGrid12.FontStyle = FontStyle.Regular;
			itemGrid12.Height = 1f;
			itemGrid12.IsBlink = 0;
			itemGrid12.Name = "tbMR";
			itemGrid12.Text = "";
			itemGrid12.ValueFormat = FormatType.Text;
			itemGrid12.Visible = true;
			itemGrid12.Width = 15;
			itemGrid12.X = 35;
			itemGrid12.Y = 1f;
			itemGrid13.AdjustFontSize = 0f;
			itemGrid13.Alignment = StringAlignment.Near;
			itemGrid13.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid13.Changed = false;
			itemGrid13.FieldType = ItemType.Label2;
			itemGrid13.FontColor = Color.LightGray;
			itemGrid13.FontStyle = FontStyle.Regular;
			itemGrid13.Height = 1f;
			itemGrid13.IsBlink = 0;
			itemGrid13.Name = "lbCallForce";
			itemGrid13.Text = "Call Force";
			itemGrid13.ValueFormat = FormatType.Text;
			itemGrid13.Visible = true;
			itemGrid13.Width = 10;
			itemGrid13.X = 50;
			itemGrid13.Y = 1f;
			itemGrid14.AdjustFontSize = 0f;
			itemGrid14.Alignment = StringAlignment.Near;
			itemGrid14.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid14.Changed = false;
			itemGrid14.FieldType = ItemType.Text;
			itemGrid14.FontColor = Color.Yellow;
			itemGrid14.FontStyle = FontStyle.Regular;
			itemGrid14.Height = 1f;
			itemGrid14.IsBlink = 0;
			itemGrid14.Name = "tbCallForce";
			itemGrid14.Text = "";
			itemGrid14.ValueFormat = FormatType.Text;
			itemGrid14.Visible = true;
			itemGrid14.Width = 15;
			itemGrid14.X = 60;
			itemGrid14.Y = 1f;
			itemGrid15.AdjustFontSize = 0f;
			itemGrid15.Alignment = StringAlignment.Near;
			itemGrid15.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid15.Changed = false;
			itemGrid15.FieldType = ItemType.Label2;
			itemGrid15.FontColor = Color.LightGray;
			itemGrid15.FontStyle = FontStyle.Regular;
			itemGrid15.Height = 1f;
			itemGrid15.IsBlink = 0;
			itemGrid15.Name = "lbShortForce";
			itemGrid15.Text = "Shortage Force";
			itemGrid15.ValueFormat = FormatType.Text;
			itemGrid15.Visible = true;
			itemGrid15.Width = 10;
			itemGrid15.X = 75;
			itemGrid15.Y = 1f;
			itemGrid16.AdjustFontSize = 0f;
			itemGrid16.Alignment = StringAlignment.Near;
			itemGrid16.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid16.Changed = false;
			itemGrid16.FieldType = ItemType.Text;
			itemGrid16.FontColor = Color.Yellow;
			itemGrid16.FontStyle = FontStyle.Regular;
			itemGrid16.Height = 1f;
			itemGrid16.IsBlink = 0;
			itemGrid16.Name = "tbShortForce";
			itemGrid16.Text = "";
			itemGrid16.ValueFormat = FormatType.Text;
			itemGrid16.Visible = true;
			itemGrid16.Width = 15;
			itemGrid16.X = 85;
			itemGrid16.Y = 1f;
			itemGrid17.AdjustFontSize = 0f;
			itemGrid17.Alignment = StringAlignment.Near;
			itemGrid17.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid17.Changed = false;
			itemGrid17.FieldType = ItemType.Label2;
			itemGrid17.FontColor = Color.LightGray;
			itemGrid17.FontStyle = FontStyle.Regular;
			itemGrid17.Height = 1f;
			itemGrid17.IsBlink = 0;
			itemGrid17.Name = "lbLiabilities";
			itemGrid17.Text = "Liabilities";
			itemGrid17.ValueFormat = FormatType.Text;
			itemGrid17.Visible = true;
			itemGrid17.Width = 10;
			itemGrid17.X = 0;
			itemGrid17.Y = 2f;
			itemGrid18.AdjustFontSize = 0f;
			itemGrid18.Alignment = StringAlignment.Near;
			itemGrid18.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid18.Changed = false;
			itemGrid18.FieldType = ItemType.Text;
			itemGrid18.FontColor = Color.Red;
			itemGrid18.FontStyle = FontStyle.Regular;
			itemGrid18.Height = 1f;
			itemGrid18.IsBlink = 0;
			itemGrid18.Name = "tbLiabilities";
			itemGrid18.Text = "";
			itemGrid18.ValueFormat = FormatType.Text;
			itemGrid18.Visible = true;
			itemGrid18.Width = 15;
			itemGrid18.X = 10;
			itemGrid18.Y = 2f;
			itemGrid19.AdjustFontSize = 0f;
			itemGrid19.Alignment = StringAlignment.Near;
			itemGrid19.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid19.Changed = false;
			itemGrid19.FieldType = ItemType.Label2;
			itemGrid19.FontColor = Color.LightGray;
			itemGrid19.FontStyle = FontStyle.Regular;
			itemGrid19.Height = 1f;
			itemGrid19.IsBlink = 0;
			itemGrid19.Name = "lbEquity";
			itemGrid19.Text = "Equity";
			itemGrid19.ValueFormat = FormatType.Text;
			itemGrid19.Visible = true;
			itemGrid19.Width = 10;
			itemGrid19.X = 25;
			itemGrid19.Y = 2f;
			itemGrid20.AdjustFontSize = 0f;
			itemGrid20.Alignment = StringAlignment.Near;
			itemGrid20.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid20.Changed = false;
			itemGrid20.FieldType = ItemType.Text;
			itemGrid20.FontColor = Color.Yellow;
			itemGrid20.FontStyle = FontStyle.Regular;
			itemGrid20.Height = 1f;
			itemGrid20.IsBlink = 0;
			itemGrid20.Name = "tbEquity";
			itemGrid20.Text = "";
			itemGrid20.ValueFormat = FormatType.Text;
			itemGrid20.Visible = true;
			itemGrid20.Width = 15;
			itemGrid20.X = 35;
			itemGrid20.Y = 2f;
			itemGrid21.AdjustFontSize = 0f;
			itemGrid21.Alignment = StringAlignment.Near;
			itemGrid21.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid21.Changed = false;
			itemGrid21.FieldType = ItemType.Label2;
			itemGrid21.FontColor = Color.LightGray;
			itemGrid21.FontStyle = FontStyle.Regular;
			itemGrid21.Height = 1f;
			itemGrid21.IsBlink = 0;
			itemGrid21.Name = "lbBuyMR";
			itemGrid21.Text = "Buy MR";
			itemGrid21.ValueFormat = FormatType.Text;
			itemGrid21.Visible = true;
			itemGrid21.Width = 10;
			itemGrid21.X = 50;
			itemGrid21.Y = 2f;
			itemGrid22.AdjustFontSize = 0f;
			itemGrid22.Alignment = StringAlignment.Near;
			itemGrid22.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid22.Changed = false;
			itemGrid22.FieldType = ItemType.Text;
			itemGrid22.FontColor = Color.Yellow;
			itemGrid22.FontStyle = FontStyle.Regular;
			itemGrid22.Height = 1f;
			itemGrid22.IsBlink = 0;
			itemGrid22.Name = "tbBuyMR";
			itemGrid22.Text = "";
			itemGrid22.ValueFormat = FormatType.Text;
			itemGrid22.Visible = true;
			itemGrid22.Width = 15;
			itemGrid22.X = 60;
			itemGrid22.Y = 2f;
			itemGrid23.AdjustFontSize = 0f;
			itemGrid23.Alignment = StringAlignment.Near;
			itemGrid23.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid23.Changed = false;
			itemGrid23.FieldType = ItemType.Label2;
			itemGrid23.FontColor = Color.LightGray;
			itemGrid23.FontStyle = FontStyle.Regular;
			itemGrid23.Height = 1f;
			itemGrid23.IsBlink = 0;
			itemGrid23.Name = "lbSellMR";
			itemGrid23.Text = "Sell MR";
			itemGrid23.ValueFormat = FormatType.Text;
			itemGrid23.Visible = true;
			itemGrid23.Width = 10;
			itemGrid23.X = 75;
			itemGrid23.Y = 2f;
			itemGrid24.AdjustFontSize = 0f;
			itemGrid24.Alignment = StringAlignment.Near;
			itemGrid24.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid24.Changed = false;
			itemGrid24.FieldType = ItemType.Text;
			itemGrid24.FontColor = Color.Yellow;
			itemGrid24.FontStyle = FontStyle.Regular;
			itemGrid24.Height = 1f;
			itemGrid24.IsBlink = 0;
			itemGrid24.Name = "tbSellMR";
			itemGrid24.Text = "";
			itemGrid24.ValueFormat = FormatType.Text;
			itemGrid24.Visible = true;
			itemGrid24.Width = 15;
			itemGrid24.X = 85;
			itemGrid24.Y = 2f;
			itemGrid25.AdjustFontSize = 0f;
			itemGrid25.Alignment = StringAlignment.Near;
			itemGrid25.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid25.Changed = false;
			itemGrid25.FieldType = ItemType.Label2;
			itemGrid25.FontColor = Color.LightGray;
			itemGrid25.FontStyle = FontStyle.Regular;
			itemGrid25.Height = 1f;
			itemGrid25.IsBlink = 0;
			itemGrid25.Name = "lbCashBal";
			itemGrid25.Text = "Cash Bal";
			itemGrid25.ValueFormat = FormatType.Text;
			itemGrid25.Visible = true;
			itemGrid25.Width = 10;
			itemGrid25.X = 0;
			itemGrid25.Y = 3f;
			itemGrid26.AdjustFontSize = 0f;
			itemGrid26.Alignment = StringAlignment.Near;
			itemGrid26.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid26.Changed = false;
			itemGrid26.FieldType = ItemType.Text;
			itemGrid26.FontColor = Color.Lime;
			itemGrid26.FontStyle = FontStyle.Regular;
			itemGrid26.Height = 1f;
			itemGrid26.IsBlink = 0;
			itemGrid26.Name = "tbCashBal";
			itemGrid26.Text = "";
			itemGrid26.ValueFormat = FormatType.Text;
			itemGrid26.Visible = true;
			itemGrid26.Width = 15;
			itemGrid26.X = 10;
			itemGrid26.Y = 3f;
			itemGrid27.AdjustFontSize = 0f;
			itemGrid27.Alignment = StringAlignment.Near;
			itemGrid27.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid27.Changed = false;
			itemGrid27.FieldType = ItemType.Label2;
			itemGrid27.FontColor = Color.LightGray;
			itemGrid27.FontStyle = FontStyle.Regular;
			itemGrid27.Height = 1f;
			itemGrid27.IsBlink = 0;
			itemGrid27.Name = "lbEE";
			itemGrid27.Text = "EE";
			itemGrid27.ValueFormat = FormatType.Text;
			itemGrid27.Visible = true;
			itemGrid27.Width = 10;
			itemGrid27.X = 25;
			itemGrid27.Y = 3f;
			itemGrid28.AdjustFontSize = 0f;
			itemGrid28.Alignment = StringAlignment.Near;
			itemGrid28.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid28.Changed = false;
			itemGrid28.FieldType = ItemType.Text;
			itemGrid28.FontColor = Color.Yellow;
			itemGrid28.FontStyle = FontStyle.Regular;
			itemGrid28.Height = 1f;
			itemGrid28.IsBlink = 0;
			itemGrid28.Name = "tbEE";
			itemGrid28.Text = "";
			itemGrid28.ValueFormat = FormatType.Text;
			itemGrid28.Visible = true;
			itemGrid28.Width = 15;
			itemGrid28.X = 35;
			itemGrid28.Y = 3f;
			itemGrid29.AdjustFontSize = 0f;
			itemGrid29.Alignment = StringAlignment.Near;
			itemGrid29.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid29.Changed = false;
			itemGrid29.FieldType = ItemType.Label2;
			itemGrid29.FontColor = Color.LightGray;
			itemGrid29.FontStyle = FontStyle.Regular;
			itemGrid29.Height = 1f;
			itemGrid29.IsBlink = 0;
			itemGrid29.Name = "lbPP";
			itemGrid29.Text = "PP";
			itemGrid29.ValueFormat = FormatType.Text;
			itemGrid29.Visible = true;
			itemGrid29.Width = 10;
			itemGrid29.X = 50;
			itemGrid29.Y = 3f;
			itemGrid30.AdjustFontSize = 0f;
			itemGrid30.Alignment = StringAlignment.Near;
			itemGrid30.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid30.Changed = false;
			itemGrid30.FieldType = ItemType.Text;
			itemGrid30.FontColor = Color.Yellow;
			itemGrid30.FontStyle = FontStyle.Regular;
			itemGrid30.Height = 1f;
			itemGrid30.IsBlink = 0;
			itemGrid30.Name = "tbPP";
			itemGrid30.Text = "";
			itemGrid30.ValueFormat = FormatType.Text;
			itemGrid30.Visible = true;
			itemGrid30.Width = 15;
			itemGrid30.X = 60;
			itemGrid30.Y = 3f;
			itemGrid31.AdjustFontSize = 0f;
			itemGrid31.Alignment = StringAlignment.Near;
			itemGrid31.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid31.Changed = false;
			itemGrid31.FieldType = ItemType.Label2;
			itemGrid31.FontColor = Color.LightGray;
			itemGrid31.FontStyle = FontStyle.Regular;
			itemGrid31.Height = 1f;
			itemGrid31.IsBlink = 0;
			itemGrid31.Name = "lbCallLMV";
			itemGrid31.Text = "Call LMV";
			itemGrid31.ValueFormat = FormatType.Text;
			itemGrid31.Visible = true;
			itemGrid31.Width = 10;
			itemGrid31.X = 75;
			itemGrid31.Y = 3f;
			itemGrid32.AdjustFontSize = 0f;
			itemGrid32.Alignment = StringAlignment.Near;
			itemGrid32.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid32.Changed = false;
			itemGrid32.FieldType = ItemType.Text;
			itemGrid32.FontColor = Color.Yellow;
			itemGrid32.FontStyle = FontStyle.Regular;
			itemGrid32.Height = 1f;
			itemGrid32.IsBlink = 0;
			itemGrid32.Name = "tbCallLMV";
			itemGrid32.Text = "";
			itemGrid32.ValueFormat = FormatType.Text;
			itemGrid32.Visible = true;
			itemGrid32.Width = 15;
			itemGrid32.X = 85;
			itemGrid32.Y = 3f;
			itemGrid33.AdjustFontSize = 0f;
			itemGrid33.Alignment = StringAlignment.Near;
			itemGrid33.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid33.Changed = false;
			itemGrid33.FieldType = ItemType.Label2;
			itemGrid33.FontColor = Color.LightGray;
			itemGrid33.FontStyle = FontStyle.Regular;
			itemGrid33.Height = 1f;
			itemGrid33.IsBlink = 0;
			itemGrid33.Name = "lbLMV";
			itemGrid33.Text = "LMV";
			itemGrid33.ValueFormat = FormatType.Text;
			itemGrid33.Visible = true;
			itemGrid33.Width = 10;
			itemGrid33.X = 0;
			itemGrid33.Y = 4f;
			itemGrid34.AdjustFontSize = 0f;
			itemGrid34.Alignment = StringAlignment.Near;
			itemGrid34.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid34.Changed = false;
			itemGrid34.FieldType = ItemType.Text;
			itemGrid34.FontColor = Color.Lime;
			itemGrid34.FontStyle = FontStyle.Regular;
			itemGrid34.Height = 1f;
			itemGrid34.IsBlink = 0;
			itemGrid34.Name = "tbLMV";
			itemGrid34.Text = "";
			itemGrid34.ValueFormat = FormatType.Text;
			itemGrid34.Visible = true;
			itemGrid34.Width = 15;
			itemGrid34.X = 10;
			itemGrid34.Y = 4f;
			itemGrid35.AdjustFontSize = 0f;
			itemGrid35.Alignment = StringAlignment.Near;
			itemGrid35.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid35.Changed = false;
			itemGrid35.FieldType = ItemType.Label2;
			itemGrid35.FontColor = Color.LightGray;
			itemGrid35.FontStyle = FontStyle.Regular;
			itemGrid35.Height = 1f;
			itemGrid35.IsBlink = 0;
			itemGrid35.Name = "lbCollateral";
			itemGrid35.Text = "Collateral";
			itemGrid35.ValueFormat = FormatType.Text;
			itemGrid35.Visible = true;
			itemGrid35.Width = 10;
			itemGrid35.X = 25;
			itemGrid35.Y = 4f;
			itemGrid36.AdjustFontSize = 0f;
			itemGrid36.Alignment = StringAlignment.Near;
			itemGrid36.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid36.Changed = false;
			itemGrid36.FieldType = ItemType.Text;
			itemGrid36.FontColor = Color.Lime;
			itemGrid36.FontStyle = FontStyle.Regular;
			itemGrid36.Height = 1f;
			itemGrid36.IsBlink = 0;
			itemGrid36.Name = "tbCollateral";
			itemGrid36.Text = "";
			itemGrid36.ValueFormat = FormatType.Text;
			itemGrid36.Visible = true;
			itemGrid36.Width = 15;
			itemGrid36.X = 35;
			itemGrid36.Y = 4f;
			itemGrid37.AdjustFontSize = 0f;
			itemGrid37.Alignment = StringAlignment.Near;
			itemGrid37.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid37.Changed = false;
			itemGrid37.FieldType = ItemType.Label2;
			itemGrid37.FontColor = Color.LightGray;
			itemGrid37.FontStyle = FontStyle.Regular;
			itemGrid37.Height = 1f;
			itemGrid37.IsBlink = 0;
			itemGrid37.Name = "lbCallMargin";
			itemGrid37.Text = "Call Margin";
			itemGrid37.ValueFormat = FormatType.Text;
			itemGrid37.Visible = true;
			itemGrid37.Width = 10;
			itemGrid37.X = 50;
			itemGrid37.Y = 4f;
			itemGrid38.AdjustFontSize = 0f;
			itemGrid38.Alignment = StringAlignment.Near;
			itemGrid38.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid38.Changed = false;
			itemGrid38.FieldType = ItemType.Text;
			itemGrid38.FontColor = Color.Yellow;
			itemGrid38.FontStyle = FontStyle.Regular;
			itemGrid38.Height = 1f;
			itemGrid38.IsBlink = 0;
			itemGrid38.Name = "tbCallMargin";
			itemGrid38.Text = "";
			itemGrid38.ValueFormat = FormatType.Text;
			itemGrid38.Visible = true;
			itemGrid38.Width = 15;
			itemGrid38.X = 60;
			itemGrid38.Y = 4f;
			itemGrid39.AdjustFontSize = 0f;
			itemGrid39.Alignment = StringAlignment.Near;
			itemGrid39.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid39.Changed = false;
			itemGrid39.FieldType = ItemType.Label2;
			itemGrid39.FontColor = Color.LightGray;
			itemGrid39.FontStyle = FontStyle.Regular;
			itemGrid39.Height = 1f;
			itemGrid39.IsBlink = 0;
			itemGrid39.Name = "lbCallSMV";
			itemGrid39.Text = "Call SMV";
			itemGrid39.ValueFormat = FormatType.Text;
			itemGrid39.Visible = true;
			itemGrid39.Width = 10;
			itemGrid39.X = 75;
			itemGrid39.Y = 4f;
			itemGrid40.AdjustFontSize = 0f;
			itemGrid40.Alignment = StringAlignment.Near;
			itemGrid40.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid40.Changed = false;
			itemGrid40.FieldType = ItemType.Text;
			itemGrid40.FontColor = Color.Yellow;
			itemGrid40.FontStyle = FontStyle.Regular;
			itemGrid40.Height = 1f;
			itemGrid40.IsBlink = 0;
			itemGrid40.Name = "tbCallSMV";
			itemGrid40.Text = "";
			itemGrid40.ValueFormat = FormatType.Text;
			itemGrid40.Visible = true;
			itemGrid40.Width = 15;
			itemGrid40.X = 85;
			itemGrid40.Y = 4f;
			itemGrid41.AdjustFontSize = 0f;
			itemGrid41.Alignment = StringAlignment.Near;
			itemGrid41.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid41.Changed = false;
			itemGrid41.FieldType = ItemType.Label2;
			itemGrid41.FontColor = Color.LightGray;
			itemGrid41.FontStyle = FontStyle.Regular;
			itemGrid41.Height = 1f;
			itemGrid41.IsBlink = 0;
			itemGrid41.Name = "lbSMV";
			itemGrid41.Text = "SMV";
			itemGrid41.ValueFormat = FormatType.Text;
			itemGrid41.Visible = true;
			itemGrid41.Width = 10;
			itemGrid41.X = 0;
			itemGrid41.Y = 5f;
			itemGrid42.AdjustFontSize = 0f;
			itemGrid42.Alignment = StringAlignment.Near;
			itemGrid42.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid42.Changed = false;
			itemGrid42.FieldType = ItemType.Text;
			itemGrid42.FontColor = Color.Red;
			itemGrid42.FontStyle = FontStyle.Regular;
			itemGrid42.Height = 1f;
			itemGrid42.IsBlink = 0;
			itemGrid42.Name = "tbSMV";
			itemGrid42.Text = "";
			itemGrid42.ValueFormat = FormatType.Text;
			itemGrid42.Visible = true;
			itemGrid42.Width = 15;
			itemGrid42.X = 10;
			itemGrid42.Y = 5f;
			itemGrid43.AdjustFontSize = 0f;
			itemGrid43.Alignment = StringAlignment.Near;
			itemGrid43.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid43.Changed = false;
			itemGrid43.FieldType = ItemType.Label2;
			itemGrid43.FontColor = Color.LightGray;
			itemGrid43.FontStyle = FontStyle.Regular;
			itemGrid43.Height = 1f;
			itemGrid43.IsBlink = 0;
			itemGrid43.Name = "lbDEBT";
			itemGrid43.Text = "DEBT";
			itemGrid43.ValueFormat = FormatType.Text;
			itemGrid43.Visible = true;
			itemGrid43.Width = 10;
			itemGrid43.X = 25;
			itemGrid43.Y = 5f;
			itemGrid44.AdjustFontSize = 0f;
			itemGrid44.Alignment = StringAlignment.Near;
			itemGrid44.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid44.Changed = false;
			itemGrid44.FieldType = ItemType.Text;
			itemGrid44.FontColor = Color.Red;
			itemGrid44.FontStyle = FontStyle.Regular;
			itemGrid44.Height = 1f;
			itemGrid44.IsBlink = 0;
			itemGrid44.Name = "tbDEBT";
			itemGrid44.Text = "";
			itemGrid44.ValueFormat = FormatType.Text;
			itemGrid44.Visible = true;
			itemGrid44.Width = 15;
			itemGrid44.X = 35;
			itemGrid44.Y = 5f;
			itemGrid45.AdjustFontSize = 0f;
			itemGrid45.Alignment = StringAlignment.Near;
			itemGrid45.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid45.Changed = false;
			itemGrid45.FieldType = ItemType.Label2;
			itemGrid45.FontColor = Color.LightGray;
			itemGrid45.FontStyle = FontStyle.Regular;
			itemGrid45.Height = 1f;
			itemGrid45.IsBlink = 0;
			itemGrid45.Name = "lbShortageCall";
			itemGrid45.Text = "Shortage Call";
			itemGrid45.ValueFormat = FormatType.Text;
			itemGrid45.Visible = true;
			itemGrid45.Width = 10;
			itemGrid45.X = 50;
			itemGrid45.Y = 5f;
			itemGrid46.AdjustFontSize = 0f;
			itemGrid46.Alignment = StringAlignment.Near;
			itemGrid46.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid46.Changed = false;
			itemGrid46.FieldType = ItemType.Text;
			itemGrid46.FontColor = Color.Yellow;
			itemGrid46.FontStyle = FontStyle.Regular;
			itemGrid46.Height = 1f;
			itemGrid46.IsBlink = 0;
			itemGrid46.Name = "tbShortageCall";
			itemGrid46.Text = "";
			itemGrid46.ValueFormat = FormatType.Text;
			itemGrid46.Visible = true;
			itemGrid46.Width = 15;
			itemGrid46.X = 60;
			itemGrid46.Y = 5f;
			itemGrid47.AdjustFontSize = 0f;
			itemGrid47.Alignment = StringAlignment.Near;
			itemGrid47.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid47.Changed = false;
			itemGrid47.FieldType = ItemType.Label2;
			itemGrid47.FontColor = Color.LightGray;
			itemGrid47.FontStyle = FontStyle.Regular;
			itemGrid47.Height = 1f;
			itemGrid47.IsBlink = 0;
			itemGrid47.Name = "lbForceLMV";
			itemGrid47.Text = "Force LMV";
			itemGrid47.ValueFormat = FormatType.Text;
			itemGrid47.Visible = true;
			itemGrid47.Width = 10;
			itemGrid47.X = 75;
			itemGrid47.Y = 5f;
			itemGrid48.AdjustFontSize = 0f;
			itemGrid48.Alignment = StringAlignment.Near;
			itemGrid48.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid48.Changed = false;
			itemGrid48.FieldType = ItemType.Text;
			itemGrid48.FontColor = Color.Yellow;
			itemGrid48.FontStyle = FontStyle.Regular;
			itemGrid48.Height = 1f;
			itemGrid48.IsBlink = 0;
			itemGrid48.Name = "tbForceLMV";
			itemGrid48.Text = "";
			itemGrid48.ValueFormat = FormatType.Text;
			itemGrid48.Visible = true;
			itemGrid48.Width = 15;
			itemGrid48.X = 85;
			itemGrid48.Y = 5f;
			itemGrid49.AdjustFontSize = 0f;
			itemGrid49.Alignment = StringAlignment.Near;
			itemGrid49.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid49.Changed = false;
			itemGrid49.FieldType = ItemType.Label2;
			itemGrid49.FontColor = Color.LightGray;
			itemGrid49.FontStyle = FontStyle.Regular;
			itemGrid49.Height = 1f;
			itemGrid49.IsBlink = 0;
			itemGrid49.Name = "lbBMV";
			itemGrid49.Text = "BMV";
			itemGrid49.ValueFormat = FormatType.Text;
			itemGrid49.Visible = true;
			itemGrid49.Width = 10;
			itemGrid49.X = 0;
			itemGrid49.Y = 6f;
			itemGrid50.AdjustFontSize = 0f;
			itemGrid50.Alignment = StringAlignment.Near;
			itemGrid50.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid50.Changed = false;
			itemGrid50.FieldType = ItemType.Text;
			itemGrid50.FontColor = Color.Yellow;
			itemGrid50.FontStyle = FontStyle.Regular;
			itemGrid50.Height = 1f;
			itemGrid50.IsBlink = 0;
			itemGrid50.Name = "tbBMV";
			itemGrid50.Text = "";
			itemGrid50.ValueFormat = FormatType.Text;
			itemGrid50.Visible = true;
			itemGrid50.Width = 15;
			itemGrid50.X = 10;
			itemGrid50.Y = 6f;
			itemGrid51.AdjustFontSize = 0f;
			itemGrid51.Alignment = StringAlignment.Near;
			itemGrid51.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid51.Changed = false;
			itemGrid51.FieldType = ItemType.Label2;
			itemGrid51.FontColor = Color.LightGray;
			itemGrid51.FontStyle = FontStyle.Regular;
			itemGrid51.Height = 1f;
			itemGrid51.IsBlink = 0;
			itemGrid51.Name = "lbAction";
			itemGrid51.Text = "Action";
			itemGrid51.ValueFormat = FormatType.Text;
			itemGrid51.Visible = true;
			itemGrid51.Width = 10;
			itemGrid51.X = 25;
			itemGrid51.Y = 6f;
			itemGrid52.AdjustFontSize = 0f;
			itemGrid52.Alignment = StringAlignment.Near;
			itemGrid52.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid52.Changed = false;
			itemGrid52.FieldType = ItemType.Text;
			itemGrid52.FontColor = Color.Yellow;
			itemGrid52.FontStyle = FontStyle.Regular;
			itemGrid52.Height = 1f;
			itemGrid52.IsBlink = 0;
			itemGrid52.Name = "tbAction";
			itemGrid52.Text = "";
			itemGrid52.ValueFormat = FormatType.Text;
			itemGrid52.Visible = true;
			itemGrid52.Width = 15;
			itemGrid52.X = 35;
			itemGrid52.Y = 6f;
			itemGrid53.AdjustFontSize = 0f;
			itemGrid53.Alignment = StringAlignment.Near;
			itemGrid53.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid53.Changed = false;
			itemGrid53.FieldType = ItemType.Label2;
			itemGrid53.FontColor = Color.LightGray;
			itemGrid53.FontStyle = FontStyle.Regular;
			itemGrid53.Height = 1f;
			itemGrid53.IsBlink = 0;
			itemGrid53.Name = "lbBorrowMR";
			itemGrid53.Text = "Borrow MR";
			itemGrid53.ValueFormat = FormatType.Text;
			itemGrid53.Visible = true;
			itemGrid53.Width = 10;
			itemGrid53.X = 50;
			itemGrid53.Y = 6f;
			itemGrid54.AdjustFontSize = 0f;
			itemGrid54.Alignment = StringAlignment.Near;
			itemGrid54.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid54.Changed = false;
			itemGrid54.FieldType = ItemType.Text;
			itemGrid54.FontColor = Color.Yellow;
			itemGrid54.FontStyle = FontStyle.Regular;
			itemGrid54.Height = 1f;
			itemGrid54.IsBlink = 0;
			itemGrid54.Name = "tbBorrowMR";
			itemGrid54.Text = "";
			itemGrid54.ValueFormat = FormatType.Text;
			itemGrid54.Visible = true;
			itemGrid54.Width = 15;
			itemGrid54.X = 60;
			itemGrid54.Y = 6f;
			itemGrid55.AdjustFontSize = 0f;
			itemGrid55.Alignment = StringAlignment.Near;
			itemGrid55.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid55.Changed = false;
			itemGrid55.FieldType = ItemType.Label2;
			itemGrid55.FontColor = Color.LightGray;
			itemGrid55.FontStyle = FontStyle.Regular;
			itemGrid55.Height = 1f;
			itemGrid55.IsBlink = 0;
			itemGrid55.Name = "lbForceSMV";
			itemGrid55.Text = "Force SMV";
			itemGrid55.ValueFormat = FormatType.Text;
			itemGrid55.Visible = true;
			itemGrid55.Width = 10;
			itemGrid55.X = 75;
			itemGrid55.Y = 6f;
			itemGrid56.AdjustFontSize = 0f;
			itemGrid56.Alignment = StringAlignment.Near;
			itemGrid56.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid56.Changed = false;
			itemGrid56.FieldType = ItemType.Text;
			itemGrid56.FontColor = Color.Yellow;
			itemGrid56.FontStyle = FontStyle.Regular;
			itemGrid56.Height = 1f;
			itemGrid56.IsBlink = 0;
			itemGrid56.Name = "tbForceSMV";
			itemGrid56.Text = "";
			itemGrid56.ValueFormat = FormatType.Text;
			itemGrid56.Visible = true;
			itemGrid56.Width = 15;
			itemGrid56.X = 85;
			itemGrid56.Y = 6f;
			itemGrid57.AdjustFontSize = 0f;
			itemGrid57.Alignment = StringAlignment.Near;
			itemGrid57.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid57.Changed = false;
			itemGrid57.FieldType = ItemType.Label2;
			itemGrid57.FontColor = Color.LightGray;
			itemGrid57.FontStyle = FontStyle.Regular;
			itemGrid57.Height = 1f;
			itemGrid57.IsBlink = 0;
			itemGrid57.Name = "lbWithdrawal";
			itemGrid57.Text = "Withdrawal";
			itemGrid57.ValueFormat = FormatType.Text;
			itemGrid57.Visible = true;
			itemGrid57.Width = 10;
			itemGrid57.X = 0;
			itemGrid57.Y = 7f;
			itemGrid58.AdjustFontSize = 0f;
			itemGrid58.Alignment = StringAlignment.Near;
			itemGrid58.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid58.Changed = false;
			itemGrid58.FieldType = ItemType.Text;
			itemGrid58.FontColor = Color.Yellow;
			itemGrid58.FontStyle = FontStyle.Regular;
			itemGrid58.Height = 1f;
			itemGrid58.IsBlink = 0;
			itemGrid58.Name = "tbWithdrawal";
			itemGrid58.Text = "";
			itemGrid58.ValueFormat = FormatType.Text;
			itemGrid58.Visible = true;
			itemGrid58.Width = 15;
			itemGrid58.X = 10;
			itemGrid58.Y = 7f;
			itemGrid59.AdjustFontSize = 0f;
			itemGrid59.Alignment = StringAlignment.Near;
			itemGrid59.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid59.Changed = false;
			itemGrid59.FieldType = ItemType.Label2;
			itemGrid59.FontColor = Color.LightGray;
			itemGrid59.FontStyle = FontStyle.Regular;
			itemGrid59.Height = 1f;
			itemGrid59.IsBlink = 0;
			itemGrid59.Name = "lbMarginRate";
			itemGrid59.Text = "Margin Rate";
			itemGrid59.ValueFormat = FormatType.Text;
			itemGrid59.Visible = true;
			itemGrid59.Width = 10;
			itemGrid59.X = 25;
			itemGrid59.Y = 7f;
			itemGrid60.AdjustFontSize = 0f;
			itemGrid60.Alignment = StringAlignment.Near;
			itemGrid60.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid60.Changed = false;
			itemGrid60.FieldType = ItemType.Text;
			itemGrid60.FontColor = Color.Yellow;
			itemGrid60.FontStyle = FontStyle.Regular;
			itemGrid60.Height = 1f;
			itemGrid60.IsBlink = 0;
			itemGrid60.Name = "tbMarginRate";
			itemGrid60.Text = "";
			itemGrid60.ValueFormat = FormatType.Text;
			itemGrid60.Visible = true;
			itemGrid60.Width = 15;
			itemGrid60.X = 35;
			itemGrid60.Y = 7f;
			this.intzaCB_Freewill.Items.Add(itemGrid);
			this.intzaCB_Freewill.Items.Add(itemGrid2);
			this.intzaCB_Freewill.Items.Add(itemGrid3);
			this.intzaCB_Freewill.Items.Add(itemGrid4);
			this.intzaCB_Freewill.Items.Add(itemGrid5);
			this.intzaCB_Freewill.Items.Add(itemGrid6);
			this.intzaCB_Freewill.Items.Add(itemGrid7);
			this.intzaCB_Freewill.Items.Add(itemGrid8);
			this.intzaCB_Freewill.Items.Add(itemGrid9);
			this.intzaCB_Freewill.Items.Add(itemGrid10);
			this.intzaCB_Freewill.Items.Add(itemGrid11);
			this.intzaCB_Freewill.Items.Add(itemGrid12);
			this.intzaCB_Freewill.Items.Add(itemGrid13);
			this.intzaCB_Freewill.Items.Add(itemGrid14);
			this.intzaCB_Freewill.Items.Add(itemGrid15);
			this.intzaCB_Freewill.Items.Add(itemGrid16);
			this.intzaCB_Freewill.Items.Add(itemGrid17);
			this.intzaCB_Freewill.Items.Add(itemGrid18);
			this.intzaCB_Freewill.Items.Add(itemGrid19);
			this.intzaCB_Freewill.Items.Add(itemGrid20);
			this.intzaCB_Freewill.Items.Add(itemGrid21);
			this.intzaCB_Freewill.Items.Add(itemGrid22);
			this.intzaCB_Freewill.Items.Add(itemGrid23);
			this.intzaCB_Freewill.Items.Add(itemGrid24);
			this.intzaCB_Freewill.Items.Add(itemGrid25);
			this.intzaCB_Freewill.Items.Add(itemGrid26);
			this.intzaCB_Freewill.Items.Add(itemGrid27);
			this.intzaCB_Freewill.Items.Add(itemGrid28);
			this.intzaCB_Freewill.Items.Add(itemGrid29);
			this.intzaCB_Freewill.Items.Add(itemGrid30);
			this.intzaCB_Freewill.Items.Add(itemGrid31);
			this.intzaCB_Freewill.Items.Add(itemGrid32);
			this.intzaCB_Freewill.Items.Add(itemGrid33);
			this.intzaCB_Freewill.Items.Add(itemGrid34);
			this.intzaCB_Freewill.Items.Add(itemGrid35);
			this.intzaCB_Freewill.Items.Add(itemGrid36);
			this.intzaCB_Freewill.Items.Add(itemGrid37);
			this.intzaCB_Freewill.Items.Add(itemGrid38);
			this.intzaCB_Freewill.Items.Add(itemGrid39);
			this.intzaCB_Freewill.Items.Add(itemGrid40);
			this.intzaCB_Freewill.Items.Add(itemGrid41);
			this.intzaCB_Freewill.Items.Add(itemGrid42);
			this.intzaCB_Freewill.Items.Add(itemGrid43);
			this.intzaCB_Freewill.Items.Add(itemGrid44);
			this.intzaCB_Freewill.Items.Add(itemGrid45);
			this.intzaCB_Freewill.Items.Add(itemGrid46);
			this.intzaCB_Freewill.Items.Add(itemGrid47);
			this.intzaCB_Freewill.Items.Add(itemGrid48);
			this.intzaCB_Freewill.Items.Add(itemGrid49);
			this.intzaCB_Freewill.Items.Add(itemGrid50);
			this.intzaCB_Freewill.Items.Add(itemGrid51);
			this.intzaCB_Freewill.Items.Add(itemGrid52);
			this.intzaCB_Freewill.Items.Add(itemGrid53);
			this.intzaCB_Freewill.Items.Add(itemGrid54);
			this.intzaCB_Freewill.Items.Add(itemGrid55);
			this.intzaCB_Freewill.Items.Add(itemGrid56);
			this.intzaCB_Freewill.Items.Add(itemGrid57);
			this.intzaCB_Freewill.Items.Add(itemGrid58);
			this.intzaCB_Freewill.Items.Add(itemGrid59);
			this.intzaCB_Freewill.Items.Add(itemGrid60);
			this.intzaCB_Freewill.LineColor = Color.Red;
			this.intzaCB_Freewill.Location = new Point(10, 91);
			this.intzaCB_Freewill.Name = "intzaCB_Freewill";
			this.intzaCB_Freewill.Size = new Size(243, 82);
			this.intzaCB_Freewill.TabIndex = 24;
			this.intzaCB_Freewill.Visible = false;
			this.panelReportMenu.Controls.Add(this.toolStrip1);
			this.panelReportMenu.Location = new Point(3, 178);
			this.panelReportMenu.Name = "panelReportMenu";
			this.panelReportMenu.Size = new Size(854, 39);
			this.panelReportMenu.TabIndex = 71;
			this.toolStrip1.BackColor = Color.FromArgb(35, 35, 35);
			this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.tslbStock,
				this.tstbStock2,
				this.tsbtnClearStock
			});
			this.toolStrip1.Location = new Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new Padding(1, 1, 1, 3);
			this.toolStrip1.RenderMode = ToolStripRenderMode.System;
			this.toolStrip1.Size = new Size(854, 28);
			this.toolStrip1.TabIndex = 21;
			this.toolStrip1.Tag = "-1";
			this.toolStrip1.Text = "toolStrip1";
			this.tslbStock.ForeColor = Color.WhiteSmoke;
			this.tslbStock.Margin = new Padding(5, 1, 0, 2);
			this.tslbStock.Name = "tslbStock";
			this.tslbStock.Size = new Size(71, 21);
			this.tslbStock.Text = "Filter Stock :";
			this.tstbStock2.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.tstbStock2.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tstbStock2.BackColor = Color.FromArgb(60, 60, 60);
			this.tstbStock2.BorderStyle = BorderStyle.FixedSingle;
			this.tstbStock2.CharacterCasing = CharacterCasing.Upper;
			this.tstbStock2.ForeColor = Color.LightGray;
			this.tstbStock2.Margin = new Padding(1, 0, 1, 1);
			this.tstbStock2.MaxLength = 12;
			this.tstbStock2.Name = "tstbStock2";
			this.tstbStock2.Size = new Size(100, 23);
			this.tstbStock2.Leave += new EventHandler(this.controlOrder_Leave);
			this.tstbStock2.Enter += new EventHandler(this.controlOrder_Enter);
			this.tstbStock2.KeyUp += new KeyEventHandler(this.tstbStock2_KeyUp);
			this.tsbtnClearStock.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnClearStock.ForeColor = Color.WhiteSmoke;
			this.tsbtnClearStock.ImageTransparentColor = Color.Magenta;
			this.tsbtnClearStock.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnClearStock.Name = "tsbtnClearStock";
			this.tsbtnClearStock.Size = new Size(38, 21);
			this.tsbtnClearStock.Text = "Clear";
			this.tsbtnClearStock.ToolTipText = "Clear Stock Filter";
			this.tsbtnClearStock.Click += new EventHandler(this.tsbtnClearStock_Click);
			this.intzaCB.AllowDrop = true;
			this.intzaCB.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaCB.BorderStyle = BorderStyle.FixedSingle;
			this.intzaCB.CanDrag = false;
			this.intzaCB.IsAutoRepaint = true;
			this.intzaCB.IsDroped = false;
			itemGrid61.AdjustFontSize = 0f;
			itemGrid61.Alignment = StringAlignment.Near;
			itemGrid61.BackColor = Color.DimGray;
			itemGrid61.Changed = false;
			itemGrid61.FieldType = ItemType.TextGradient;
			itemGrid61.FontColor = Color.WhiteSmoke;
			itemGrid61.FontStyle = FontStyle.Regular;
			itemGrid61.Height = 1f;
			itemGrid61.IsBlink = 0;
			itemGrid61.Name = "lbBankCol";
			itemGrid61.Text = "";
			itemGrid61.ValueFormat = FormatType.Text;
			itemGrid61.Visible = true;
			itemGrid61.Width = 30;
			itemGrid61.X = 0;
			itemGrid61.Y = 1f;
			itemGrid62.AdjustFontSize = 0f;
			itemGrid62.Alignment = StringAlignment.Center;
			itemGrid62.BackColor = Color.DimGray;
			itemGrid62.Changed = false;
			itemGrid62.FieldType = ItemType.TextGradient;
			itemGrid62.FontColor = Color.WhiteSmoke;
			itemGrid62.FontStyle = FontStyle.Regular;
			itemGrid62.Height = 1f;
			itemGrid62.IsBlink = 0;
			itemGrid62.Name = "lbPrevious";
			itemGrid62.Text = "Previous";
			itemGrid62.ValueFormat = FormatType.Text;
			itemGrid62.Visible = true;
			itemGrid62.Width = 35;
			itemGrid62.X = 30;
			itemGrid62.Y = 1f;
			itemGrid63.AdjustFontSize = 0f;
			itemGrid63.Alignment = StringAlignment.Center;
			itemGrid63.BackColor = Color.DimGray;
			itemGrid63.Changed = false;
			itemGrid63.FieldType = ItemType.TextGradient;
			itemGrid63.FontColor = Color.WhiteSmoke;
			itemGrid63.FontStyle = FontStyle.Regular;
			itemGrid63.Height = 1f;
			itemGrid63.IsBlink = 0;
			itemGrid63.Name = "lbCurrent";
			itemGrid63.Text = "Current";
			itemGrid63.ValueFormat = FormatType.Text;
			itemGrid63.Visible = true;
			itemGrid63.Width = 35;
			itemGrid63.X = 65;
			itemGrid63.Y = 1f;
			itemGrid64.AdjustFontSize = -1f;
			itemGrid64.Alignment = StringAlignment.Far;
			itemGrid64.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid64.Changed = false;
			itemGrid64.FieldType = ItemType.Label;
			itemGrid64.FontColor = Color.WhiteSmoke;
			itemGrid64.FontStyle = FontStyle.Regular;
			itemGrid64.Height = 1f;
			itemGrid64.IsBlink = 0;
			itemGrid64.Name = "lbExcessEquity";
			itemGrid64.Text = "Excess Equity";
			itemGrid64.ValueFormat = FormatType.Text;
			itemGrid64.Visible = true;
			itemGrid64.Width = 30;
			itemGrid64.X = 0;
			itemGrid64.Y = 2f;
			itemGrid65.AdjustFontSize = 0f;
			itemGrid65.Alignment = StringAlignment.Near;
			itemGrid65.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid65.Changed = false;
			itemGrid65.FieldType = ItemType.Text;
			itemGrid65.FontColor = Color.White;
			itemGrid65.FontStyle = FontStyle.Regular;
			itemGrid65.Height = 1f;
			itemGrid65.IsBlink = 0;
			itemGrid65.Name = "tbExcessEquityPrevious";
			itemGrid65.Text = "";
			itemGrid65.ValueFormat = FormatType.Text;
			itemGrid65.Visible = true;
			itemGrid65.Width = 35;
			itemGrid65.X = 30;
			itemGrid65.Y = 2f;
			itemGrid66.AdjustFontSize = 0f;
			itemGrid66.Alignment = StringAlignment.Near;
			itemGrid66.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid66.Changed = false;
			itemGrid66.FieldType = ItemType.Text;
			itemGrid66.FontColor = Color.White;
			itemGrid66.FontStyle = FontStyle.Regular;
			itemGrid66.Height = 1f;
			itemGrid66.IsBlink = 0;
			itemGrid66.Name = "tbExcessEquityCurrent";
			itemGrid66.Text = "";
			itemGrid66.ValueFormat = FormatType.Text;
			itemGrid66.Visible = true;
			itemGrid66.Width = 35;
			itemGrid66.X = 65;
			itemGrid66.Y = 2f;
			itemGrid67.AdjustFontSize = -1f;
			itemGrid67.Alignment = StringAlignment.Far;
			itemGrid67.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid67.Changed = false;
			itemGrid67.FieldType = ItemType.Label;
			itemGrid67.FontColor = Color.WhiteSmoke;
			itemGrid67.FontStyle = FontStyle.Regular;
			itemGrid67.Height = 1f;
			itemGrid67.IsBlink = 0;
			itemGrid67.Name = "lbMarkToEE";
			itemGrid67.Text = "Mark to Market EE";
			itemGrid67.ValueFormat = FormatType.Text;
			itemGrid67.Visible = true;
			itemGrid67.Width = 30;
			itemGrid67.X = 0;
			itemGrid67.Y = 3f;
			itemGrid68.AdjustFontSize = 0f;
			itemGrid68.Alignment = StringAlignment.Near;
			itemGrid68.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid68.Changed = false;
			itemGrid68.FieldType = ItemType.Text;
			itemGrid68.FontColor = Color.White;
			itemGrid68.FontStyle = FontStyle.Regular;
			itemGrid68.Height = 1f;
			itemGrid68.IsBlink = 0;
			itemGrid68.Name = "tbMarkToEEPrevious";
			itemGrid68.Text = "";
			itemGrid68.ValueFormat = FormatType.Text;
			itemGrid68.Visible = true;
			itemGrid68.Width = 35;
			itemGrid68.X = 30;
			itemGrid68.Y = 3f;
			itemGrid69.AdjustFontSize = 0f;
			itemGrid69.Alignment = StringAlignment.Near;
			itemGrid69.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid69.Changed = false;
			itemGrid69.FieldType = ItemType.Text;
			itemGrid69.FontColor = Color.White;
			itemGrid69.FontStyle = FontStyle.Regular;
			itemGrid69.Height = 1f;
			itemGrid69.IsBlink = 0;
			itemGrid69.Name = "tbMarkToEECurrent";
			itemGrid69.Text = "";
			itemGrid69.ValueFormat = FormatType.Text;
			itemGrid69.Visible = true;
			itemGrid69.Width = 35;
			itemGrid69.X = 65;
			itemGrid69.Y = 3f;
			itemGrid70.AdjustFontSize = -1f;
			itemGrid70.Alignment = StringAlignment.Far;
			itemGrid70.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid70.Changed = false;
			itemGrid70.FieldType = ItemType.Label;
			itemGrid70.FontColor = Color.WhiteSmoke;
			itemGrid70.FontStyle = FontStyle.Regular;
			itemGrid70.Height = 1f;
			itemGrid70.IsBlink = 0;
			itemGrid70.Name = "lbMMpercent";
			itemGrid70.Text = "MM%";
			itemGrid70.ValueFormat = FormatType.Text;
			itemGrid70.Visible = true;
			itemGrid70.Width = 30;
			itemGrid70.X = 0;
			itemGrid70.Y = 4f;
			itemGrid71.AdjustFontSize = 0f;
			itemGrid71.Alignment = StringAlignment.Near;
			itemGrid71.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid71.Changed = false;
			itemGrid71.FieldType = ItemType.Text;
			itemGrid71.FontColor = Color.White;
			itemGrid71.FontStyle = FontStyle.Regular;
			itemGrid71.Height = 1f;
			itemGrid71.IsBlink = 0;
			itemGrid71.Name = "tbMMpercentPrevious";
			itemGrid71.Text = "";
			itemGrid71.ValueFormat = FormatType.PercentChange;
			itemGrid71.Visible = true;
			itemGrid71.Width = 35;
			itemGrid71.X = 30;
			itemGrid71.Y = 4f;
			itemGrid72.AdjustFontSize = 0f;
			itemGrid72.Alignment = StringAlignment.Near;
			itemGrid72.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid72.Changed = false;
			itemGrid72.FieldType = ItemType.Text;
			itemGrid72.FontColor = Color.White;
			itemGrid72.FontStyle = FontStyle.Regular;
			itemGrid72.Height = 1f;
			itemGrid72.IsBlink = 0;
			itemGrid72.Name = "tbMMpercentCurrent";
			itemGrid72.Text = "";
			itemGrid72.ValueFormat = FormatType.PercentChange;
			itemGrid72.Visible = true;
			itemGrid72.Width = 35;
			itemGrid72.X = 65;
			itemGrid72.Y = 4f;
			itemGrid73.AdjustFontSize = -1f;
			itemGrid73.Alignment = StringAlignment.Far;
			itemGrid73.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid73.Changed = false;
			itemGrid73.FieldType = ItemType.Label;
			itemGrid73.FontColor = Color.WhiteSmoke;
			itemGrid73.FontStyle = FontStyle.Regular;
			itemGrid73.Height = 1f;
			itemGrid73.IsBlink = 0;
			itemGrid73.Name = "lbEquity";
			itemGrid73.Text = "Equity";
			itemGrid73.ValueFormat = FormatType.Text;
			itemGrid73.Visible = true;
			itemGrid73.Width = 30;
			itemGrid73.X = 0;
			itemGrid73.Y = 5f;
			itemGrid74.AdjustFontSize = 0f;
			itemGrid74.Alignment = StringAlignment.Near;
			itemGrid74.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid74.Changed = false;
			itemGrid74.FieldType = ItemType.Text;
			itemGrid74.FontColor = Color.White;
			itemGrid74.FontStyle = FontStyle.Regular;
			itemGrid74.Height = 1f;
			itemGrid74.IsBlink = 0;
			itemGrid74.Name = "tbEquityPrevious";
			itemGrid74.Text = "";
			itemGrid74.ValueFormat = FormatType.Price;
			itemGrid74.Visible = true;
			itemGrid74.Width = 35;
			itemGrid74.X = 30;
			itemGrid74.Y = 5f;
			itemGrid75.AdjustFontSize = 0f;
			itemGrid75.Alignment = StringAlignment.Near;
			itemGrid75.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid75.Changed = false;
			itemGrid75.FieldType = ItemType.Text;
			itemGrid75.FontColor = Color.White;
			itemGrid75.FontStyle = FontStyle.Regular;
			itemGrid75.Height = 1f;
			itemGrid75.IsBlink = 0;
			itemGrid75.Name = "tbEquityCurrent";
			itemGrid75.Text = "";
			itemGrid75.ValueFormat = FormatType.Price;
			itemGrid75.Visible = true;
			itemGrid75.Width = 35;
			itemGrid75.X = 65;
			itemGrid75.Y = 5f;
			itemGrid76.AdjustFontSize = -1f;
			itemGrid76.Alignment = StringAlignment.Far;
			itemGrid76.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid76.Changed = false;
			itemGrid76.FieldType = ItemType.Label;
			itemGrid76.FontColor = Color.WhiteSmoke;
			itemGrid76.FontStyle = FontStyle.Regular;
			itemGrid76.Height = 1f;
			itemGrid76.IsBlink = 0;
			itemGrid76.Name = "lbMR";
			itemGrid76.Text = "MR";
			itemGrid76.ValueFormat = FormatType.Text;
			itemGrid76.Visible = true;
			itemGrid76.Width = 30;
			itemGrid76.X = 0;
			itemGrid76.Y = 6f;
			itemGrid77.AdjustFontSize = 0f;
			itemGrid77.Alignment = StringAlignment.Near;
			itemGrid77.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid77.Changed = false;
			itemGrid77.FieldType = ItemType.Text;
			itemGrid77.FontColor = Color.White;
			itemGrid77.FontStyle = FontStyle.Regular;
			itemGrid77.Height = 1f;
			itemGrid77.IsBlink = 0;
			itemGrid77.Name = "tbMRPrevious";
			itemGrid77.Text = "";
			itemGrid77.ValueFormat = FormatType.Text;
			itemGrid77.Visible = true;
			itemGrid77.Width = 35;
			itemGrid77.X = 30;
			itemGrid77.Y = 6f;
			itemGrid78.AdjustFontSize = 0f;
			itemGrid78.Alignment = StringAlignment.Near;
			itemGrid78.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid78.Changed = false;
			itemGrid78.FieldType = ItemType.Text;
			itemGrid78.FontColor = Color.White;
			itemGrid78.FontStyle = FontStyle.Regular;
			itemGrid78.Height = 1f;
			itemGrid78.IsBlink = 0;
			itemGrid78.Name = "tbMRCurrent";
			itemGrid78.Text = "";
			itemGrid78.ValueFormat = FormatType.Text;
			itemGrid78.Visible = true;
			itemGrid78.Width = 35;
			itemGrid78.X = 65;
			itemGrid78.Y = 6f;
			itemGrid79.AdjustFontSize = 0f;
			itemGrid79.Alignment = StringAlignment.Near;
			itemGrid79.BackColor = Color.DimGray;
			itemGrid79.Changed = false;
			itemGrid79.FieldType = ItemType.TextGradient;
			itemGrid79.FontColor = Color.WhiteSmoke;
			itemGrid79.FontStyle = FontStyle.Regular;
			itemGrid79.Height = 1f;
			itemGrid79.IsBlink = 0;
			itemGrid79.Name = "lbAsset";
			itemGrid79.Text = "ASSET";
			itemGrid79.ValueFormat = FormatType.Text;
			itemGrid79.Visible = true;
			itemGrid79.Width = 30;
			itemGrid79.X = 0;
			itemGrid79.Y = 7f;
			itemGrid80.AdjustFontSize = 0f;
			itemGrid80.Alignment = StringAlignment.Near;
			itemGrid80.BackColor = Color.DimGray;
			itemGrid80.Changed = false;
			itemGrid80.FieldType = ItemType.TextGradient;
			itemGrid80.FontColor = Color.WhiteSmoke;
			itemGrid80.FontStyle = FontStyle.Regular;
			itemGrid80.Height = 1f;
			itemGrid80.IsBlink = 0;
			itemGrid80.Name = "lbAssetPrevious";
			itemGrid80.Text = "";
			itemGrid80.ValueFormat = FormatType.Text;
			itemGrid80.Visible = true;
			itemGrid80.Width = 35;
			itemGrid80.X = 30;
			itemGrid80.Y = 7f;
			itemGrid81.AdjustFontSize = 0f;
			itemGrid81.Alignment = StringAlignment.Near;
			itemGrid81.BackColor = Color.DimGray;
			itemGrid81.Changed = false;
			itemGrid81.FieldType = ItemType.TextGradient;
			itemGrid81.FontColor = Color.WhiteSmoke;
			itemGrid81.FontStyle = FontStyle.Regular;
			itemGrid81.Height = 1f;
			itemGrid81.IsBlink = 0;
			itemGrid81.Name = "lbAssetCurrent";
			itemGrid81.Text = "";
			itemGrid81.ValueFormat = FormatType.Text;
			itemGrid81.Visible = true;
			itemGrid81.Width = 35;
			itemGrid81.X = 65;
			itemGrid81.Y = 7f;
			itemGrid82.AdjustFontSize = -1f;
			itemGrid82.Alignment = StringAlignment.Far;
			itemGrid82.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid82.Changed = false;
			itemGrid82.FieldType = ItemType.Label;
			itemGrid82.FontColor = Color.WhiteSmoke;
			itemGrid82.FontStyle = FontStyle.Regular;
			itemGrid82.Height = 1f;
			itemGrid82.IsBlink = 0;
			itemGrid82.Name = "lbCashBalance";
			itemGrid82.Text = "Cash Balance";
			itemGrid82.ValueFormat = FormatType.Text;
			itemGrid82.Visible = true;
			itemGrid82.Width = 30;
			itemGrid82.X = 0;
			itemGrid82.Y = 8f;
			itemGrid83.AdjustFontSize = 0f;
			itemGrid83.Alignment = StringAlignment.Near;
			itemGrid83.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid83.Changed = false;
			itemGrid83.FieldType = ItemType.Text;
			itemGrid83.FontColor = Color.White;
			itemGrid83.FontStyle = FontStyle.Regular;
			itemGrid83.Height = 1f;
			itemGrid83.IsBlink = 0;
			itemGrid83.Name = "tbCashBalancePrevious";
			itemGrid83.Text = "";
			itemGrid83.ValueFormat = FormatType.Text;
			itemGrid83.Visible = true;
			itemGrid83.Width = 35;
			itemGrid83.X = 30;
			itemGrid83.Y = 8f;
			itemGrid84.AdjustFontSize = 0f;
			itemGrid84.Alignment = StringAlignment.Near;
			itemGrid84.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid84.Changed = false;
			itemGrid84.FieldType = ItemType.Text;
			itemGrid84.FontColor = Color.White;
			itemGrid84.FontStyle = FontStyle.Regular;
			itemGrid84.Height = 1f;
			itemGrid84.IsBlink = 0;
			itemGrid84.Name = "tbCashBalanceCurrent";
			itemGrid84.Text = "";
			itemGrid84.ValueFormat = FormatType.Text;
			itemGrid84.Visible = true;
			itemGrid84.Width = 35;
			itemGrid84.X = 65;
			itemGrid84.Y = 8f;
			itemGrid85.AdjustFontSize = -1f;
			itemGrid85.Alignment = StringAlignment.Far;
			itemGrid85.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid85.Changed = false;
			itemGrid85.FieldType = ItemType.Label;
			itemGrid85.FontColor = Color.WhiteSmoke;
			itemGrid85.FontStyle = FontStyle.Regular;
			itemGrid85.Height = 1f;
			itemGrid85.IsBlink = 0;
			itemGrid85.Name = "lbLmv";
			itemGrid85.Text = "LMV";
			itemGrid85.ValueFormat = FormatType.Text;
			itemGrid85.Visible = true;
			itemGrid85.Width = 30;
			itemGrid85.X = 0;
			itemGrid85.Y = 9f;
			itemGrid86.AdjustFontSize = 0f;
			itemGrid86.Alignment = StringAlignment.Near;
			itemGrid86.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid86.Changed = false;
			itemGrid86.FieldType = ItemType.Text;
			itemGrid86.FontColor = Color.White;
			itemGrid86.FontStyle = FontStyle.Regular;
			itemGrid86.Height = 1f;
			itemGrid86.IsBlink = 0;
			itemGrid86.Name = "tbLmvPrevious";
			itemGrid86.Text = "";
			itemGrid86.ValueFormat = FormatType.Text;
			itemGrid86.Visible = true;
			itemGrid86.Width = 35;
			itemGrid86.X = 30;
			itemGrid86.Y = 9f;
			itemGrid87.AdjustFontSize = 0f;
			itemGrid87.Alignment = StringAlignment.Near;
			itemGrid87.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid87.Changed = false;
			itemGrid87.FieldType = ItemType.Text;
			itemGrid87.FontColor = Color.White;
			itemGrid87.FontStyle = FontStyle.Regular;
			itemGrid87.Height = 1f;
			itemGrid87.IsBlink = 0;
			itemGrid87.Name = "tbLmvCurrent";
			itemGrid87.Text = "";
			itemGrid87.ValueFormat = FormatType.Text;
			itemGrid87.Visible = true;
			itemGrid87.Width = 35;
			itemGrid87.X = 65;
			itemGrid87.Y = 9f;
			itemGrid88.AdjustFontSize = -1f;
			itemGrid88.Alignment = StringAlignment.Far;
			itemGrid88.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid88.Changed = false;
			itemGrid88.FieldType = ItemType.Label;
			itemGrid88.FontColor = Color.WhiteSmoke;
			itemGrid88.FontStyle = FontStyle.Regular;
			itemGrid88.Height = 1f;
			itemGrid88.IsBlink = 0;
			itemGrid88.Name = "lbColleteral";
			itemGrid88.Text = "Colleteral";
			itemGrid88.ValueFormat = FormatType.Text;
			itemGrid88.Visible = true;
			itemGrid88.Width = 30;
			itemGrid88.X = 0;
			itemGrid88.Y = 10f;
			itemGrid89.AdjustFontSize = 0f;
			itemGrid89.Alignment = StringAlignment.Near;
			itemGrid89.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid89.Changed = false;
			itemGrid89.FieldType = ItemType.Text;
			itemGrid89.FontColor = Color.White;
			itemGrid89.FontStyle = FontStyle.Regular;
			itemGrid89.Height = 1f;
			itemGrid89.IsBlink = 0;
			itemGrid89.Name = "tbColleteralPrevious";
			itemGrid89.Text = "";
			itemGrid89.ValueFormat = FormatType.Text;
			itemGrid89.Visible = true;
			itemGrid89.Width = 35;
			itemGrid89.X = 30;
			itemGrid89.Y = 10f;
			itemGrid90.AdjustFontSize = 0f;
			itemGrid90.Alignment = StringAlignment.Near;
			itemGrid90.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid90.Changed = false;
			itemGrid90.FieldType = ItemType.Text;
			itemGrid90.FontColor = Color.White;
			itemGrid90.FontStyle = FontStyle.Regular;
			itemGrid90.Height = 1f;
			itemGrid90.IsBlink = 0;
			itemGrid90.Name = "tbColleteralCurrent";
			itemGrid90.Text = "";
			itemGrid90.ValueFormat = FormatType.Text;
			itemGrid90.Visible = true;
			itemGrid90.Width = 35;
			itemGrid90.X = 65;
			itemGrid90.Y = 10f;
			itemGrid91.AdjustFontSize = 0f;
			itemGrid91.Alignment = StringAlignment.Near;
			itemGrid91.BackColor = Color.DimGray;
			itemGrid91.Changed = false;
			itemGrid91.FieldType = ItemType.TextGradient;
			itemGrid91.FontColor = Color.WhiteSmoke;
			itemGrid91.FontStyle = FontStyle.Regular;
			itemGrid91.Height = 1f;
			itemGrid91.IsBlink = 0;
			itemGrid91.Name = "lbLiabilities";
			itemGrid91.Text = "LIABILITIES";
			itemGrid91.ValueFormat = FormatType.Text;
			itemGrid91.Visible = true;
			itemGrid91.Width = 30;
			itemGrid91.X = 0;
			itemGrid91.Y = 11f;
			itemGrid92.AdjustFontSize = 0f;
			itemGrid92.Alignment = StringAlignment.Near;
			itemGrid92.BackColor = Color.DimGray;
			itemGrid92.Changed = false;
			itemGrid92.FieldType = ItemType.TextGradient;
			itemGrid92.FontColor = Color.WhiteSmoke;
			itemGrid92.FontStyle = FontStyle.Regular;
			itemGrid92.Height = 1f;
			itemGrid92.IsBlink = 0;
			itemGrid92.Name = "lbLiabilitiesPrevious";
			itemGrid92.Text = "";
			itemGrid92.ValueFormat = FormatType.Text;
			itemGrid92.Visible = true;
			itemGrid92.Width = 35;
			itemGrid92.X = 30;
			itemGrid92.Y = 11f;
			itemGrid93.AdjustFontSize = 0f;
			itemGrid93.Alignment = StringAlignment.Near;
			itemGrid93.BackColor = Color.DimGray;
			itemGrid93.Changed = false;
			itemGrid93.FieldType = ItemType.TextGradient;
			itemGrid93.FontColor = Color.WhiteSmoke;
			itemGrid93.FontStyle = FontStyle.Regular;
			itemGrid93.Height = 1f;
			itemGrid93.IsBlink = 0;
			itemGrid93.Name = "lbLiabilitiesCurrent";
			itemGrid93.Text = "";
			itemGrid93.ValueFormat = FormatType.Text;
			itemGrid93.Visible = true;
			itemGrid93.Width = 35;
			itemGrid93.X = 65;
			itemGrid93.Y = 11f;
			itemGrid94.AdjustFontSize = -1f;
			itemGrid94.Alignment = StringAlignment.Far;
			itemGrid94.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid94.Changed = false;
			itemGrid94.FieldType = ItemType.Label;
			itemGrid94.FontColor = Color.WhiteSmoke;
			itemGrid94.FontStyle = FontStyle.Regular;
			itemGrid94.Height = 1f;
			itemGrid94.IsBlink = 0;
			itemGrid94.Name = "lbLoan";
			itemGrid94.Text = "Loan";
			itemGrid94.ValueFormat = FormatType.Text;
			itemGrid94.Visible = true;
			itemGrid94.Width = 30;
			itemGrid94.X = 0;
			itemGrid94.Y = 12f;
			itemGrid95.AdjustFontSize = 0f;
			itemGrid95.Alignment = StringAlignment.Near;
			itemGrid95.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid95.Changed = false;
			itemGrid95.FieldType = ItemType.Text;
			itemGrid95.FontColor = Color.White;
			itemGrid95.FontStyle = FontStyle.Regular;
			itemGrid95.Height = 1f;
			itemGrid95.IsBlink = 0;
			itemGrid95.Name = "tbLoanPrevious";
			itemGrid95.Text = "";
			itemGrid95.ValueFormat = FormatType.Text;
			itemGrid95.Visible = true;
			itemGrid95.Width = 35;
			itemGrid95.X = 30;
			itemGrid95.Y = 12f;
			itemGrid96.AdjustFontSize = 0f;
			itemGrid96.Alignment = StringAlignment.Near;
			itemGrid96.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid96.Changed = false;
			itemGrid96.FieldType = ItemType.Text;
			itemGrid96.FontColor = Color.White;
			itemGrid96.FontStyle = FontStyle.Regular;
			itemGrid96.Height = 1f;
			itemGrid96.IsBlink = 0;
			itemGrid96.Name = "tbLoanCurrent";
			itemGrid96.Text = "";
			itemGrid96.ValueFormat = FormatType.Text;
			itemGrid96.Visible = true;
			itemGrid96.Width = 35;
			itemGrid96.X = 65;
			itemGrid96.Y = 12f;
			itemGrid97.AdjustFontSize = -1f;
			itemGrid97.Alignment = StringAlignment.Far;
			itemGrid97.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid97.Changed = false;
			itemGrid97.FieldType = ItemType.Label;
			itemGrid97.FontColor = Color.WhiteSmoke;
			itemGrid97.FontStyle = FontStyle.Regular;
			itemGrid97.Height = 1f;
			itemGrid97.IsBlink = 0;
			itemGrid97.Name = "lbSmv";
			itemGrid97.Text = "SMV";
			itemGrid97.ValueFormat = FormatType.Price;
			itemGrid97.Visible = true;
			itemGrid97.Width = 30;
			itemGrid97.X = 0;
			itemGrid97.Y = 13f;
			itemGrid98.AdjustFontSize = 0f;
			itemGrid98.Alignment = StringAlignment.Near;
			itemGrid98.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid98.Changed = false;
			itemGrid98.FieldType = ItemType.Text;
			itemGrid98.FontColor = Color.White;
			itemGrid98.FontStyle = FontStyle.Regular;
			itemGrid98.Height = 1f;
			itemGrid98.IsBlink = 0;
			itemGrid98.Name = "tbSmvPrevious";
			itemGrid98.Text = "";
			itemGrid98.ValueFormat = FormatType.Text;
			itemGrid98.Visible = true;
			itemGrid98.Width = 35;
			itemGrid98.X = 30;
			itemGrid98.Y = 13f;
			itemGrid99.AdjustFontSize = 0f;
			itemGrid99.Alignment = StringAlignment.Near;
			itemGrid99.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid99.Changed = false;
			itemGrid99.FieldType = ItemType.Text;
			itemGrid99.FontColor = Color.White;
			itemGrid99.FontStyle = FontStyle.Regular;
			itemGrid99.Height = 1f;
			itemGrid99.IsBlink = 0;
			itemGrid99.Name = "tbSmvCurrent";
			itemGrid99.Text = "";
			itemGrid99.ValueFormat = FormatType.Text;
			itemGrid99.Visible = true;
			itemGrid99.Width = 35;
			itemGrid99.X = 65;
			itemGrid99.Y = 13f;
			itemGrid100.AdjustFontSize = 0f;
			itemGrid100.Alignment = StringAlignment.Near;
			itemGrid100.BackColor = Color.DimGray;
			itemGrid100.Changed = false;
			itemGrid100.FieldType = ItemType.TextGradient;
			itemGrid100.FontColor = Color.WhiteSmoke;
			itemGrid100.FontStyle = FontStyle.Regular;
			itemGrid100.Height = 1f;
			itemGrid100.IsBlink = 0;
			itemGrid100.Name = "lbBankCol1Previous";
			itemGrid100.Text = "";
			itemGrid100.ValueFormat = FormatType.Text;
			itemGrid100.Visible = true;
			itemGrid100.Width = 35;
			itemGrid100.X = 30;
			itemGrid100.Y = 14f;
			itemGrid101.AdjustFontSize = 0f;
			itemGrid101.Alignment = StringAlignment.Near;
			itemGrid101.BackColor = Color.DimGray;
			itemGrid101.Changed = false;
			itemGrid101.FieldType = ItemType.TextGradient;
			itemGrid101.FontColor = Color.WhiteSmoke;
			itemGrid101.FontStyle = FontStyle.Regular;
			itemGrid101.Height = 1f;
			itemGrid101.IsBlink = 0;
			itemGrid101.Name = "lbBankCol1";
			itemGrid101.Text = "CALL & FORCE";
			itemGrid101.ValueFormat = FormatType.Text;
			itemGrid101.Visible = true;
			itemGrid101.Width = 30;
			itemGrid101.X = 0;
			itemGrid101.Y = 14f;
			itemGrid102.AdjustFontSize = 0f;
			itemGrid102.Alignment = StringAlignment.Near;
			itemGrid102.BackColor = Color.DimGray;
			itemGrid102.Changed = false;
			itemGrid102.FieldType = ItemType.TextGradient;
			itemGrid102.FontColor = Color.WhiteSmoke;
			itemGrid102.FontStyle = FontStyle.Regular;
			itemGrid102.Height = 1f;
			itemGrid102.IsBlink = 0;
			itemGrid102.Name = "lbBankCol1Current";
			itemGrid102.Text = "";
			itemGrid102.ValueFormat = FormatType.Text;
			itemGrid102.Visible = true;
			itemGrid102.Width = 35;
			itemGrid102.X = 65;
			itemGrid102.Y = 14f;
			itemGrid103.AdjustFontSize = -1f;
			itemGrid103.Alignment = StringAlignment.Far;
			itemGrid103.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid103.Changed = false;
			itemGrid103.FieldType = ItemType.Label;
			itemGrid103.FontColor = Color.WhiteSmoke;
			itemGrid103.FontStyle = FontStyle.Regular;
			itemGrid103.Height = 1f;
			itemGrid103.IsBlink = 0;
			itemGrid103.Name = "lbCall";
			itemGrid103.Text = "Call";
			itemGrid103.ValueFormat = FormatType.Text;
			itemGrid103.Visible = true;
			itemGrid103.Width = 30;
			itemGrid103.X = 0;
			itemGrid103.Y = 15f;
			itemGrid104.AdjustFontSize = 0f;
			itemGrid104.Alignment = StringAlignment.Near;
			itemGrid104.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid104.Changed = false;
			itemGrid104.FieldType = ItemType.Text;
			itemGrid104.FontColor = Color.Red;
			itemGrid104.FontStyle = FontStyle.Regular;
			itemGrid104.Height = 1f;
			itemGrid104.IsBlink = 0;
			itemGrid104.Name = "tbCallPrevious";
			itemGrid104.Text = "";
			itemGrid104.ValueFormat = FormatType.Text;
			itemGrid104.Visible = true;
			itemGrid104.Width = 35;
			itemGrid104.X = 30;
			itemGrid104.Y = 15f;
			itemGrid105.AdjustFontSize = 0f;
			itemGrid105.Alignment = StringAlignment.Near;
			itemGrid105.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid105.Changed = false;
			itemGrid105.FieldType = ItemType.Text;
			itemGrid105.FontColor = Color.Red;
			itemGrid105.FontStyle = FontStyle.Regular;
			itemGrid105.Height = 1f;
			itemGrid105.IsBlink = 0;
			itemGrid105.Name = "tbCallCurrent";
			itemGrid105.Text = "";
			itemGrid105.ValueFormat = FormatType.Text;
			itemGrid105.Visible = true;
			itemGrid105.Width = 35;
			itemGrid105.X = 65;
			itemGrid105.Y = 15f;
			itemGrid106.AdjustFontSize = -1f;
			itemGrid106.Alignment = StringAlignment.Far;
			itemGrid106.BackColor = Color.FromArgb(64, 64, 64);
			itemGrid106.Changed = false;
			itemGrid106.FieldType = ItemType.Label;
			itemGrid106.FontColor = Color.WhiteSmoke;
			itemGrid106.FontStyle = FontStyle.Regular;
			itemGrid106.Height = 1f;
			itemGrid106.IsBlink = 0;
			itemGrid106.Name = "lbForce";
			itemGrid106.Text = "Force";
			itemGrid106.ValueFormat = FormatType.Text;
			itemGrid106.Visible = true;
			itemGrid106.Width = 30;
			itemGrid106.X = 0;
			itemGrid106.Y = 16f;
			itemGrid107.AdjustFontSize = 0f;
			itemGrid107.Alignment = StringAlignment.Near;
			itemGrid107.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid107.Changed = false;
			itemGrid107.FieldType = ItemType.Text;
			itemGrid107.FontColor = Color.Red;
			itemGrid107.FontStyle = FontStyle.Regular;
			itemGrid107.Height = 1f;
			itemGrid107.IsBlink = 0;
			itemGrid107.Name = "tbForcePrevious";
			itemGrid107.Text = "";
			itemGrid107.ValueFormat = FormatType.Text;
			itemGrid107.Visible = true;
			itemGrid107.Width = 35;
			itemGrid107.X = 30;
			itemGrid107.Y = 16f;
			itemGrid108.AdjustFontSize = 0f;
			itemGrid108.Alignment = StringAlignment.Near;
			itemGrid108.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid108.Changed = false;
			itemGrid108.FieldType = ItemType.Text;
			itemGrid108.FontColor = Color.Red;
			itemGrid108.FontStyle = FontStyle.Regular;
			itemGrid108.Height = 1f;
			itemGrid108.IsBlink = 0;
			itemGrid108.Name = "tbForceCurrent";
			itemGrid108.Text = "";
			itemGrid108.ValueFormat = FormatType.Text;
			itemGrid108.Visible = true;
			itemGrid108.Width = 35;
			itemGrid108.X = 65;
			itemGrid108.Y = 16f;
			itemGrid109.AdjustFontSize = 0f;
			itemGrid109.Alignment = StringAlignment.Near;
			itemGrid109.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid109.Changed = false;
			itemGrid109.FieldType = ItemType.Label2;
			itemGrid109.FontColor = Color.WhiteSmoke;
			itemGrid109.FontStyle = FontStyle.Regular;
			itemGrid109.Height = 1f;
			itemGrid109.IsBlink = 0;
			itemGrid109.Name = "lbMarginRate";
			itemGrid109.Text = "Margin Rate";
			itemGrid109.ValueFormat = FormatType.Text;
			itemGrid109.Visible = true;
			itemGrid109.Width = 11;
			itemGrid109.X = 0;
			itemGrid109.Y = 0f;
			itemGrid110.AdjustFontSize = 0f;
			itemGrid110.Alignment = StringAlignment.Near;
			itemGrid110.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid110.Changed = false;
			itemGrid110.FieldType = ItemType.Text;
			itemGrid110.FontColor = Color.Yellow;
			itemGrid110.FontStyle = FontStyle.Regular;
			itemGrid110.Height = 1f;
			itemGrid110.IsBlink = 0;
			itemGrid110.Name = "tbMarginRate";
			itemGrid110.Text = "";
			itemGrid110.ValueFormat = FormatType.Volume;
			itemGrid110.Visible = true;
			itemGrid110.Width = 14;
			itemGrid110.X = 11;
			itemGrid110.Y = 0f;
			itemGrid111.AdjustFontSize = 0f;
			itemGrid111.Alignment = StringAlignment.Near;
			itemGrid111.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid111.Changed = false;
			itemGrid111.FieldType = ItemType.Label2;
			itemGrid111.FontColor = Color.WhiteSmoke;
			itemGrid111.FontStyle = FontStyle.Regular;
			itemGrid111.Height = 1f;
			itemGrid111.IsBlink = 0;
			itemGrid111.Name = "lbLoanLimit";
			itemGrid111.Text = "Loan Limit";
			itemGrid111.ValueFormat = FormatType.Text;
			itemGrid111.Visible = true;
			itemGrid111.Width = 11;
			itemGrid111.X = 25;
			itemGrid111.Y = 0f;
			itemGrid112.AdjustFontSize = 0f;
			itemGrid112.Alignment = StringAlignment.Near;
			itemGrid112.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid112.Changed = false;
			itemGrid112.FieldType = ItemType.Text;
			itemGrid112.FontColor = Color.Yellow;
			itemGrid112.FontStyle = FontStyle.Regular;
			itemGrid112.Height = 1f;
			itemGrid112.IsBlink = 0;
			itemGrid112.Name = "tbLoanLimit";
			itemGrid112.Text = "";
			itemGrid112.ValueFormat = FormatType.Volume;
			itemGrid112.Visible = true;
			itemGrid112.Width = 14;
			itemGrid112.X = 36;
			itemGrid112.Y = 0f;
			this.intzaCB.Items.Add(itemGrid61);
			this.intzaCB.Items.Add(itemGrid62);
			this.intzaCB.Items.Add(itemGrid63);
			this.intzaCB.Items.Add(itemGrid64);
			this.intzaCB.Items.Add(itemGrid65);
			this.intzaCB.Items.Add(itemGrid66);
			this.intzaCB.Items.Add(itemGrid67);
			this.intzaCB.Items.Add(itemGrid68);
			this.intzaCB.Items.Add(itemGrid69);
			this.intzaCB.Items.Add(itemGrid70);
			this.intzaCB.Items.Add(itemGrid71);
			this.intzaCB.Items.Add(itemGrid72);
			this.intzaCB.Items.Add(itemGrid73);
			this.intzaCB.Items.Add(itemGrid74);
			this.intzaCB.Items.Add(itemGrid75);
			this.intzaCB.Items.Add(itemGrid76);
			this.intzaCB.Items.Add(itemGrid77);
			this.intzaCB.Items.Add(itemGrid78);
			this.intzaCB.Items.Add(itemGrid79);
			this.intzaCB.Items.Add(itemGrid80);
			this.intzaCB.Items.Add(itemGrid81);
			this.intzaCB.Items.Add(itemGrid82);
			this.intzaCB.Items.Add(itemGrid83);
			this.intzaCB.Items.Add(itemGrid84);
			this.intzaCB.Items.Add(itemGrid85);
			this.intzaCB.Items.Add(itemGrid86);
			this.intzaCB.Items.Add(itemGrid87);
			this.intzaCB.Items.Add(itemGrid88);
			this.intzaCB.Items.Add(itemGrid89);
			this.intzaCB.Items.Add(itemGrid90);
			this.intzaCB.Items.Add(itemGrid91);
			this.intzaCB.Items.Add(itemGrid92);
			this.intzaCB.Items.Add(itemGrid93);
			this.intzaCB.Items.Add(itemGrid94);
			this.intzaCB.Items.Add(itemGrid95);
			this.intzaCB.Items.Add(itemGrid96);
			this.intzaCB.Items.Add(itemGrid97);
			this.intzaCB.Items.Add(itemGrid98);
			this.intzaCB.Items.Add(itemGrid99);
			this.intzaCB.Items.Add(itemGrid100);
			this.intzaCB.Items.Add(itemGrid101);
			this.intzaCB.Items.Add(itemGrid102);
			this.intzaCB.Items.Add(itemGrid103);
			this.intzaCB.Items.Add(itemGrid104);
			this.intzaCB.Items.Add(itemGrid105);
			this.intzaCB.Items.Add(itemGrid106);
			this.intzaCB.Items.Add(itemGrid107);
			this.intzaCB.Items.Add(itemGrid108);
			this.intzaCB.Items.Add(itemGrid109);
			this.intzaCB.Items.Add(itemGrid110);
			this.intzaCB.Items.Add(itemGrid111);
			this.intzaCB.Items.Add(itemGrid112);
			this.intzaCB.LineColor = Color.Red;
			this.intzaCB.Location = new Point(350, 31);
			this.intzaCB.Margin = new Padding(1);
			this.intzaCB.Name = "intzaCB";
			this.intzaCB.Size = new Size(147, 131);
			this.intzaCB.TabIndex = 19;
			this.intzaCB.TabStop = false;
			this.intzaCB.KeyPress += new KeyPressEventHandler(this.intzaListView1_KeyPress);
			this.intzaInfoHeader.AllowDrop = true;
			this.intzaInfoHeader.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfoHeader.CanDrag = false;
			this.intzaInfoHeader.IsAutoRepaint = true;
			this.intzaInfoHeader.IsDroped = false;
			itemGrid113.AdjustFontSize = -1f;
			itemGrid113.Alignment = StringAlignment.Near;
			itemGrid113.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid113.Changed = false;
			itemGrid113.FieldType = ItemType.Label2;
			itemGrid113.FontColor = Color.LightGray;
			itemGrid113.FontStyle = FontStyle.Regular;
			itemGrid113.Height = 1f;
			itemGrid113.IsBlink = 0;
			itemGrid113.Name = "lbCustName";
			itemGrid113.Text = "Name";
			itemGrid113.ValueFormat = FormatType.Text;
			itemGrid113.Visible = true;
			itemGrid113.Width = 11;
			itemGrid113.X = 0;
			itemGrid113.Y = 0f;
			itemGrid114.AdjustFontSize = 0f;
			itemGrid114.Alignment = StringAlignment.Near;
			itemGrid114.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid114.Changed = false;
			itemGrid114.FieldType = ItemType.Text;
			itemGrid114.FontColor = Color.Yellow;
			itemGrid114.FontStyle = FontStyle.Regular;
			itemGrid114.Height = 1f;
			itemGrid114.IsBlink = 0;
			itemGrid114.Name = "tbCustName";
			itemGrid114.Text = "";
			itemGrid114.ValueFormat = FormatType.Text;
			itemGrid114.Visible = true;
			itemGrid114.Width = 35;
			itemGrid114.X = 11;
			itemGrid114.Y = 0f;
			itemGrid115.AdjustFontSize = -1f;
			itemGrid115.Alignment = StringAlignment.Near;
			itemGrid115.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid115.Changed = false;
			itemGrid115.FieldType = ItemType.Label2;
			itemGrid115.FontColor = Color.LightGray;
			itemGrid115.FontStyle = FontStyle.Regular;
			itemGrid115.Height = 1f;
			itemGrid115.IsBlink = 0;
			itemGrid115.Name = "lbTrader";
			itemGrid115.Text = "Trader";
			itemGrid115.ValueFormat = FormatType.Text;
			itemGrid115.Visible = true;
			itemGrid115.Width = 8;
			itemGrid115.X = 46;
			itemGrid115.Y = 0f;
			itemGrid116.AdjustFontSize = 0f;
			itemGrid116.Alignment = StringAlignment.Near;
			itemGrid116.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid116.Changed = false;
			itemGrid116.FieldType = ItemType.Text;
			itemGrid116.FontColor = Color.Yellow;
			itemGrid116.FontStyle = FontStyle.Regular;
			itemGrid116.Height = 1f;
			itemGrid116.IsBlink = 0;
			itemGrid116.Name = "tbTrader";
			itemGrid116.Text = "";
			itemGrid116.ValueFormat = FormatType.Text;
			itemGrid116.Visible = true;
			itemGrid116.Width = 21;
			itemGrid116.X = 54;
			itemGrid116.Y = 0f;
			itemGrid117.AdjustFontSize = -1f;
			itemGrid117.Alignment = StringAlignment.Near;
			itemGrid117.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid117.Changed = false;
			itemGrid117.FieldType = ItemType.Label2;
			itemGrid117.FontColor = Color.LightGray;
			itemGrid117.FontStyle = FontStyle.Regular;
			itemGrid117.Height = 1f;
			itemGrid117.IsBlink = 0;
			itemGrid117.Name = "lbCustomerFlag";
			itemGrid117.Text = "Cust Flag";
			itemGrid117.ValueFormat = FormatType.Text;
			itemGrid117.Visible = true;
			itemGrid117.Width = 13;
			itemGrid117.X = 75;
			itemGrid117.Y = 0f;
			itemGrid118.AdjustFontSize = 0f;
			itemGrid118.Alignment = StringAlignment.Near;
			itemGrid118.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid118.Changed = false;
			itemGrid118.FieldType = ItemType.Text;
			itemGrid118.FontColor = Color.Yellow;
			itemGrid118.FontStyle = FontStyle.Regular;
			itemGrid118.Height = 1f;
			itemGrid118.IsBlink = 0;
			itemGrid118.Name = "tbCustomerFlag";
			itemGrid118.Text = "";
			itemGrid118.ValueFormat = FormatType.Text;
			itemGrid118.Visible = true;
			itemGrid118.Width = 12;
			itemGrid118.X = 88;
			itemGrid118.Y = 0f;
			itemGrid119.AdjustFontSize = -1f;
			itemGrid119.Alignment = StringAlignment.Near;
			itemGrid119.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid119.Changed = false;
			itemGrid119.FieldType = ItemType.Label2;
			itemGrid119.FontColor = Color.LightGray;
			itemGrid119.FontStyle = FontStyle.Regular;
			itemGrid119.Height = 1f;
			itemGrid119.IsBlink = 0;
			itemGrid119.Name = "lbBuyLimit";
			itemGrid119.Text = "Buy Limit";
			itemGrid119.ValueFormat = FormatType.Text;
			itemGrid119.Visible = true;
			itemGrid119.Width = 11;
			itemGrid119.X = 0;
			itemGrid119.Y = 2f;
			itemGrid120.AdjustFontSize = 0f;
			itemGrid120.Alignment = StringAlignment.Near;
			itemGrid120.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid120.Changed = false;
			itemGrid120.FieldType = ItemType.Text;
			itemGrid120.FontColor = Color.Yellow;
			itemGrid120.FontStyle = FontStyle.Regular;
			itemGrid120.Height = 1f;
			itemGrid120.IsBlink = 0;
			itemGrid120.Name = "tbBuyLimit";
			itemGrid120.Text = "";
			itemGrid120.ValueFormat = FormatType.Text;
			itemGrid120.Visible = true;
			itemGrid120.Width = 14;
			itemGrid120.X = 11;
			itemGrid120.Y = 2f;
			itemGrid121.AdjustFontSize = -1f;
			itemGrid121.Alignment = StringAlignment.Near;
			itemGrid121.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid121.Changed = false;
			itemGrid121.FieldType = ItemType.Label2;
			itemGrid121.FontColor = Color.LightGray;
			itemGrid121.FontStyle = FontStyle.Regular;
			itemGrid121.Height = 1f;
			itemGrid121.IsBlink = 0;
			itemGrid121.Name = "lbCustomerType";
			itemGrid121.Text = "Cust Type";
			itemGrid121.ValueFormat = FormatType.Text;
			itemGrid121.Visible = true;
			itemGrid121.Width = 11;
			itemGrid121.X = 0;
			itemGrid121.Y = 1f;
			itemGrid122.AdjustFontSize = 0f;
			itemGrid122.Alignment = StringAlignment.Near;
			itemGrid122.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid122.Changed = false;
			itemGrid122.FieldType = ItemType.Text;
			itemGrid122.FontColor = Color.Yellow;
			itemGrid122.FontStyle = FontStyle.Regular;
			itemGrid122.Height = 1f;
			itemGrid122.IsBlink = 0;
			itemGrid122.Name = "tbCustomerType";
			itemGrid122.Text = "";
			itemGrid122.ValueFormat = FormatType.Text;
			itemGrid122.Visible = true;
			itemGrid122.Width = 14;
			itemGrid122.X = 11;
			itemGrid122.Y = 1f;
			itemGrid123.AdjustFontSize = -1f;
			itemGrid123.Alignment = StringAlignment.Near;
			itemGrid123.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid123.Changed = false;
			itemGrid123.FieldType = ItemType.Label2;
			itemGrid123.FontColor = Color.LightGray;
			itemGrid123.FontStyle = FontStyle.Regular;
			itemGrid123.Height = 1f;
			itemGrid123.IsBlink = 0;
			itemGrid123.Name = "lbAccountType";
			itemGrid123.Text = "Acc Type";
			itemGrid123.ValueFormat = FormatType.Text;
			itemGrid123.Visible = true;
			itemGrid123.Width = 14;
			itemGrid123.X = 25;
			itemGrid123.Y = 1f;
			itemGrid124.AdjustFontSize = -1f;
			itemGrid124.Alignment = StringAlignment.Near;
			itemGrid124.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid124.Changed = false;
			itemGrid124.FieldType = ItemType.Text;
			itemGrid124.FontColor = Color.Yellow;
			itemGrid124.FontStyle = FontStyle.Regular;
			itemGrid124.Height = 1f;
			itemGrid124.IsBlink = 0;
			itemGrid124.Name = "tbAccountType";
			itemGrid124.Text = "";
			itemGrid124.ValueFormat = FormatType.Text;
			itemGrid124.Visible = true;
			itemGrid124.Width = 14;
			itemGrid124.X = 39;
			itemGrid124.Y = 1f;
			itemGrid125.AdjustFontSize = -1f;
			itemGrid125.Alignment = StringAlignment.Near;
			itemGrid125.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid125.Changed = false;
			itemGrid125.FieldType = ItemType.Label2;
			itemGrid125.FontColor = Color.LightGray;
			itemGrid125.FontStyle = FontStyle.Regular;
			itemGrid125.Height = 1f;
			itemGrid125.IsBlink = 0;
			itemGrid125.Name = "lbCreditType";
			itemGrid125.Text = "Credit Type";
			itemGrid125.ValueFormat = FormatType.Text;
			itemGrid125.Visible = true;
			itemGrid125.Width = 10;
			itemGrid125.X = 53;
			itemGrid125.Y = 1f;
			itemGrid126.AdjustFontSize = -1f;
			itemGrid126.Alignment = StringAlignment.Near;
			itemGrid126.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid126.Changed = false;
			itemGrid126.FieldType = ItemType.Text;
			itemGrid126.FontColor = Color.Yellow;
			itemGrid126.FontStyle = FontStyle.Regular;
			itemGrid126.Height = 1f;
			itemGrid126.IsBlink = 0;
			itemGrid126.Name = "tbCreditType";
			itemGrid126.Text = "";
			itemGrid126.ValueFormat = FormatType.Text;
			itemGrid126.Visible = true;
			itemGrid126.Width = 12;
			itemGrid126.X = 63;
			itemGrid126.Y = 1f;
			itemGrid127.AdjustFontSize = -1f;
			itemGrid127.Alignment = StringAlignment.Near;
			itemGrid127.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid127.Changed = false;
			itemGrid127.FieldType = ItemType.Label2;
			itemGrid127.FontColor = Color.LightGray;
			itemGrid127.FontStyle = FontStyle.Regular;
			itemGrid127.Height = 1f;
			itemGrid127.IsBlink = 0;
			itemGrid127.Name = "lbCantOverCredit";
			itemGrid127.Text = "Can't Over Credit";
			itemGrid127.ValueFormat = FormatType.Text;
			itemGrid127.Visible = true;
			itemGrid127.Width = 13;
			itemGrid127.X = 75;
			itemGrid127.Y = 1f;
			itemGrid128.AdjustFontSize = 0f;
			itemGrid128.Alignment = StringAlignment.Near;
			itemGrid128.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid128.Changed = false;
			itemGrid128.FieldType = ItemType.Text;
			itemGrid128.FontColor = Color.Yellow;
			itemGrid128.FontStyle = FontStyle.Regular;
			itemGrid128.Height = 1f;
			itemGrid128.IsBlink = 0;
			itemGrid128.Name = "tbCantOverCredit";
			itemGrid128.Text = "";
			itemGrid128.ValueFormat = FormatType.Text;
			itemGrid128.Visible = true;
			itemGrid128.Width = 12;
			itemGrid128.X = 88;
			itemGrid128.Y = 1f;
			itemGrid129.AdjustFontSize = -1f;
			itemGrid129.Alignment = StringAlignment.Near;
			itemGrid129.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid129.Changed = false;
			itemGrid129.FieldType = ItemType.Label2;
			itemGrid129.FontColor = Color.LightGray;
			itemGrid129.FontStyle = FontStyle.Regular;
			itemGrid129.Height = 1f;
			itemGrid129.IsBlink = 0;
			itemGrid129.Name = "lbHighLimit";
			itemGrid129.Text = "High Limit";
			itemGrid129.ValueFormat = FormatType.Text;
			itemGrid129.Visible = true;
			itemGrid129.Width = 14;
			itemGrid129.X = 25;
			itemGrid129.Y = 2f;
			itemGrid130.AdjustFontSize = 0f;
			itemGrid130.Alignment = StringAlignment.Near;
			itemGrid130.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid130.Changed = false;
			itemGrid130.FieldType = ItemType.Text;
			itemGrid130.FontColor = Color.Yellow;
			itemGrid130.FontStyle = FontStyle.Regular;
			itemGrid130.Height = 1f;
			itemGrid130.IsBlink = 0;
			itemGrid130.Name = "tbHighLimit";
			itemGrid130.Text = "";
			itemGrid130.ValueFormat = FormatType.Text;
			itemGrid130.Visible = true;
			itemGrid130.Width = 14;
			itemGrid130.X = 39;
			itemGrid130.Y = 2f;
			itemGrid131.AdjustFontSize = -1f;
			itemGrid131.Alignment = StringAlignment.Near;
			itemGrid131.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid131.Changed = false;
			itemGrid131.FieldType = ItemType.Label2;
			itemGrid131.FontColor = Color.LightGray;
			itemGrid131.FontStyle = FontStyle.Regular;
			itemGrid131.Height = 1f;
			itemGrid131.IsBlink = 0;
			itemGrid131.Name = "lbCreditLine";
			itemGrid131.Text = "Credit Line";
			itemGrid131.ValueFormat = FormatType.Text;
			itemGrid131.Visible = true;
			itemGrid131.Width = 10;
			itemGrid131.X = 53;
			itemGrid131.Y = 2f;
			itemGrid132.AdjustFontSize = 0f;
			itemGrid132.Alignment = StringAlignment.Near;
			itemGrid132.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid132.Changed = false;
			itemGrid132.FieldType = ItemType.Text;
			itemGrid132.FontColor = Color.Yellow;
			itemGrid132.FontStyle = FontStyle.Regular;
			itemGrid132.Height = 1f;
			itemGrid132.IsBlink = 0;
			itemGrid132.Name = "tbCreditLine";
			itemGrid132.Text = "";
			itemGrid132.ValueFormat = FormatType.Text;
			itemGrid132.Visible = true;
			itemGrid132.Width = 12;
			itemGrid132.X = 63;
			itemGrid132.Y = 2f;
			itemGrid133.AdjustFontSize = -1f;
			itemGrid133.Alignment = StringAlignment.Near;
			itemGrid133.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid133.Changed = false;
			itemGrid133.FieldType = ItemType.Label2;
			itemGrid133.FontColor = Color.LightGray;
			itemGrid133.FontStyle = FontStyle.Regular;
			itemGrid133.Height = 1f;
			itemGrid133.IsBlink = 0;
			itemGrid133.Name = "lbEquity";
			itemGrid133.Text = "Equity";
			itemGrid133.ValueFormat = FormatType.Text;
			itemGrid133.Visible = true;
			itemGrid133.Width = 13;
			itemGrid133.X = 75;
			itemGrid133.Y = 2f;
			itemGrid134.AdjustFontSize = 0f;
			itemGrid134.Alignment = StringAlignment.Near;
			itemGrid134.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid134.Changed = false;
			itemGrid134.FieldType = ItemType.Text;
			itemGrid134.FontColor = Color.Yellow;
			itemGrid134.FontStyle = FontStyle.Regular;
			itemGrid134.Height = 1f;
			itemGrid134.IsBlink = 0;
			itemGrid134.Name = "tbEquity";
			itemGrid134.Text = "";
			itemGrid134.ValueFormat = FormatType.Text;
			itemGrid134.Visible = true;
			itemGrid134.Width = 12;
			itemGrid134.X = 88;
			itemGrid134.Y = 2f;
			this.intzaInfoHeader.Items.Add(itemGrid113);
			this.intzaInfoHeader.Items.Add(itemGrid114);
			this.intzaInfoHeader.Items.Add(itemGrid115);
			this.intzaInfoHeader.Items.Add(itemGrid116);
			this.intzaInfoHeader.Items.Add(itemGrid117);
			this.intzaInfoHeader.Items.Add(itemGrid118);
			this.intzaInfoHeader.Items.Add(itemGrid119);
			this.intzaInfoHeader.Items.Add(itemGrid120);
			this.intzaInfoHeader.Items.Add(itemGrid121);
			this.intzaInfoHeader.Items.Add(itemGrid122);
			this.intzaInfoHeader.Items.Add(itemGrid123);
			this.intzaInfoHeader.Items.Add(itemGrid124);
			this.intzaInfoHeader.Items.Add(itemGrid125);
			this.intzaInfoHeader.Items.Add(itemGrid126);
			this.intzaInfoHeader.Items.Add(itemGrid127);
			this.intzaInfoHeader.Items.Add(itemGrid128);
			this.intzaInfoHeader.Items.Add(itemGrid129);
			this.intzaInfoHeader.Items.Add(itemGrid130);
			this.intzaInfoHeader.Items.Add(itemGrid131);
			this.intzaInfoHeader.Items.Add(itemGrid132);
			this.intzaInfoHeader.Items.Add(itemGrid133);
			this.intzaInfoHeader.Items.Add(itemGrid134);
			this.intzaInfoHeader.LineColor = Color.Red;
			this.intzaInfoHeader.Location = new Point(10, 31);
			this.intzaInfoHeader.Margin = new Padding(1);
			this.intzaInfoHeader.Name = "intzaInfoHeader";
			this.intzaInfoHeader.Size = new Size(243, 58);
			this.intzaInfoHeader.TabIndex = 70;
			this.intzaInfoHeader.TabStop = false;
			this.intzaSumReport.AllowDrop = true;
			this.intzaSumReport.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaSumReport.CanBlink = true;
			this.intzaSumReport.CanDrag = false;
			this.intzaSumReport.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.White;
			columnItem.MyStyle = FontStyle.Bold;
			columnItem.Name = "text";
			columnItem.Text = "";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 53;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "cost";
			columnItem2.Text = "Cost";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 10;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "curr_value";
			columnItem3.Text = "Curr Val";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 10;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Bold;
			columnItem4.Name = "unreal_pct";
			columnItem4.Text = "%Unrl";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 7;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "unreal";
			columnItem5.Text = "Unrl P/L";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 10;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "realize";
			columnItem6.Text = "Real P/L";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 10;
			this.intzaSumReport.Columns.Add(columnItem);
			this.intzaSumReport.Columns.Add(columnItem2);
			this.intzaSumReport.Columns.Add(columnItem3);
			this.intzaSumReport.Columns.Add(columnItem4);
			this.intzaSumReport.Columns.Add(columnItem5);
			this.intzaSumReport.Columns.Add(columnItem6);
			this.intzaSumReport.CurrentScroll = 0;
			this.intzaSumReport.FocusItemIndex = -1;
			this.intzaSumReport.ForeColor = Color.Black;
			this.intzaSumReport.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaSumReport.HeaderPctHeight = 100f;
			this.intzaSumReport.IsAutoRepaint = true;
			this.intzaSumReport.IsDrawFullRow = false;
			this.intzaSumReport.IsDrawGrid = true;
			this.intzaSumReport.IsDrawHeader = false;
			this.intzaSumReport.IsScrollable = true;
			this.intzaSumReport.Location = new Point(8, 281);
			this.intzaSumReport.MainColumn = "";
			this.intzaSumReport.Name = "intzaSumReport";
			this.intzaSumReport.Rows = 1;
			this.intzaSumReport.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaSumReport.RowSelectType = 0;
			this.intzaSumReport.RowsVisible = 1;
			this.intzaSumReport.Size = new Size(829, 25);
			this.intzaSumReport.SortColumnName = "";
			this.intzaSumReport.SortType = SortType.Desc;
			this.intzaSumReport.TabIndex = 69;
			this.intzaReport.AllowDrop = true;
			this.intzaReport.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaReport.CanBlink = true;
			this.intzaReport.CanDrag = false;
			this.intzaReport.CanGetMouseMove = false;
			columnItem7.Alignment = StringAlignment.Near;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "stock";
			columnItem7.Text = "Symbol";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 11;
			columnItem8.Alignment = StringAlignment.Center;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "ttf";
			columnItem8.Text = "TTF";
			columnItem8.ValueFormat = FormatType.Text;
			columnItem8.Visible = true;
			columnItem8.Width = 4;
			columnItem9.Alignment = StringAlignment.Far;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "onhand";
			columnItem9.Text = "OnHand";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = true;
			columnItem9.Width = 10;
			columnItem10.Alignment = StringAlignment.Far;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.LightGray;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "sellable";
			columnItem10.Text = "Sellable";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = true;
			columnItem10.Width = 10;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "avg";
			columnItem11.Text = "Avg";
			columnItem11.ValueFormat = FormatType.Text;
			columnItem11.Visible = true;
			columnItem11.Width = 7;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "last";
			columnItem12.Text = "Last";
			columnItem12.ValueFormat = FormatType.Text;
			columnItem12.Visible = true;
			columnItem12.Width = 7;
			columnItem13.Alignment = StringAlignment.Far;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.ColumnAlignment = StringAlignment.Center;
			columnItem13.FontColor = Color.LightGray;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "cost";
			columnItem13.Text = "Cost";
			columnItem13.ValueFormat = FormatType.Text;
			columnItem13.Visible = true;
			columnItem13.Width = 10;
			columnItem14.Alignment = StringAlignment.Far;
			columnItem14.BackColor = Color.FromArgb(64, 64, 64);
			columnItem14.ColumnAlignment = StringAlignment.Center;
			columnItem14.FontColor = Color.LightGray;
			columnItem14.MyStyle = FontStyle.Regular;
			columnItem14.Name = "curr_value";
			columnItem14.Text = "Curr Val";
			columnItem14.ValueFormat = FormatType.Text;
			columnItem14.Visible = true;
			columnItem14.Width = 10;
			columnItem15.Alignment = StringAlignment.Far;
			columnItem15.BackColor = Color.FromArgb(64, 64, 64);
			columnItem15.ColumnAlignment = StringAlignment.Center;
			columnItem15.FontColor = Color.LightGray;
			columnItem15.MyStyle = FontStyle.Regular;
			columnItem15.Name = "unreal_pct";
			columnItem15.Text = "%Unrl";
			columnItem15.ValueFormat = FormatType.Text;
			columnItem15.Visible = true;
			columnItem15.Width = 7;
			columnItem16.Alignment = StringAlignment.Far;
			columnItem16.BackColor = Color.FromArgb(64, 64, 64);
			columnItem16.ColumnAlignment = StringAlignment.Center;
			columnItem16.FontColor = Color.LightGray;
			columnItem16.MyStyle = FontStyle.Regular;
			columnItem16.Name = "unreal";
			columnItem16.Text = "Unrl P/L";
			columnItem16.ValueFormat = FormatType.Text;
			columnItem16.Visible = true;
			columnItem16.Width = 10;
			columnItem17.Alignment = StringAlignment.Far;
			columnItem17.BackColor = Color.FromArgb(64, 64, 64);
			columnItem17.ColumnAlignment = StringAlignment.Center;
			columnItem17.FontColor = Color.LightGray;
			columnItem17.MyStyle = FontStyle.Regular;
			columnItem17.Name = "realize";
			columnItem17.Text = "Real P/L";
			columnItem17.ValueFormat = FormatType.Text;
			columnItem17.Visible = true;
			columnItem17.Width = 10;
			this.intzaReport.Columns.Add(columnItem7);
			this.intzaReport.Columns.Add(columnItem8);
			this.intzaReport.Columns.Add(columnItem9);
			this.intzaReport.Columns.Add(columnItem10);
			this.intzaReport.Columns.Add(columnItem11);
			this.intzaReport.Columns.Add(columnItem12);
			this.intzaReport.Columns.Add(columnItem13);
			this.intzaReport.Columns.Add(columnItem14);
			this.intzaReport.Columns.Add(columnItem15);
			this.intzaReport.Columns.Add(columnItem16);
			this.intzaReport.Columns.Add(columnItem17);
			this.intzaReport.CurrentScroll = 0;
			this.intzaReport.FocusItemIndex = -1;
			this.intzaReport.ForeColor = Color.Black;
			this.intzaReport.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaReport.HeaderPctHeight = 80f;
			this.intzaReport.IsAutoRepaint = true;
			this.intzaReport.IsDrawFullRow = false;
			this.intzaReport.IsDrawGrid = true;
			this.intzaReport.IsDrawHeader = true;
			this.intzaReport.IsScrollable = true;
			this.intzaReport.Location = new Point(8, 223);
			this.intzaReport.MainColumn = "";
			this.intzaReport.Name = "intzaReport";
			this.intzaReport.Rows = 0;
			this.intzaReport.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaReport.RowSelectType = 1;
			this.intzaReport.RowsVisible = 0;
			this.intzaReport.Size = new Size(829, 52);
			this.intzaReport.SortColumnName = "";
			this.intzaReport.SortType = SortType.Desc;
			this.intzaReport.TabIndex = 68;
			this.intzaReport.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaReport_TableMouseClick);
			this.panelTFEXPort.BackColor = Color.FromArgb(20, 20, 20);
			this.panelTFEXPort.Controls.Add(this.sortGridTfexSumm);
			this.panelTFEXPort.Controls.Add(this.sortGridTfex);
			this.panelTFEXPort.Controls.Add(this.intzaCustBottTfex);
			this.panelTFEXPort.Controls.Add(this.intzaCustHeadTfex);
			this.panelTFEXPort.Controls.Add(this.tStripMainT);
			this.panelTFEXPort.Location = new Point(4, 331);
			this.panelTFEXPort.Name = "panelTFEXPort";
			this.panelTFEXPort.Size = new Size(852, 253);
			this.panelTFEXPort.TabIndex = 72;
			this.panelTFEXPort.Visible = false;
			this.sortGridTfexSumm.AllowDrop = true;
			this.sortGridTfexSumm.BackColor = Color.FromArgb(30, 30, 30);
			this.sortGridTfexSumm.CanBlink = true;
			this.sortGridTfexSumm.CanDrag = false;
			this.sortGridTfexSumm.CanGetMouseMove = false;
			columnItem18.Alignment = StringAlignment.Far;
			columnItem18.BackColor = Color.FromArgb(64, 64, 64);
			columnItem18.ColumnAlignment = StringAlignment.Center;
			columnItem18.FontColor = Color.LightGray;
			columnItem18.MyStyle = FontStyle.Regular;
			columnItem18.Name = "last";
			columnItem18.Text = "Last";
			columnItem18.ValueFormat = FormatType.Text;
			columnItem18.Visible = true;
			columnItem18.Width = 56;
			columnItem19.Alignment = StringAlignment.Far;
			columnItem19.BackColor = Color.FromArgb(64, 64, 64);
			columnItem19.ColumnAlignment = StringAlignment.Center;
			columnItem19.FontColor = Color.LightGray;
			columnItem19.MyStyle = FontStyle.Regular;
			columnItem19.Name = "mkt_val";
			columnItem19.Text = "Mkt Value";
			columnItem19.ValueFormat = FormatType.Text;
			columnItem19.Visible = true;
			columnItem19.Width = 11;
			columnItem20.Alignment = StringAlignment.Far;
			columnItem20.BackColor = Color.FromArgb(64, 64, 64);
			columnItem20.ColumnAlignment = StringAlignment.Center;
			columnItem20.FontColor = Color.LightGray;
			columnItem20.MyStyle = FontStyle.Regular;
			columnItem20.Name = "cost_val";
			columnItem20.Text = "Cost Val";
			columnItem20.ValueFormat = FormatType.Text;
			columnItem20.Visible = true;
			columnItem20.Width = 11;
			columnItem21.Alignment = StringAlignment.Far;
			columnItem21.BackColor = Color.FromArgb(64, 64, 64);
			columnItem21.ColumnAlignment = StringAlignment.Center;
			columnItem21.FontColor = Color.LightGray;
			columnItem21.MyStyle = FontStyle.Regular;
			columnItem21.Name = "unreal_settle";
			columnItem21.Text = "Unreal(Settle)";
			columnItem21.ValueFormat = FormatType.Text;
			columnItem21.Visible = true;
			columnItem21.Width = 11;
			columnItem22.Alignment = StringAlignment.Far;
			columnItem22.BackColor = Color.FromArgb(64, 64, 64);
			columnItem22.ColumnAlignment = StringAlignment.Center;
			columnItem22.FontColor = Color.LightGray;
			columnItem22.MyStyle = FontStyle.Regular;
			columnItem22.Name = "unreal_cost";
			columnItem22.Text = "Unreal(Cost)";
			columnItem22.ValueFormat = FormatType.Text;
			columnItem22.Visible = false;
			columnItem22.Width = 11;
			columnItem23.Alignment = StringAlignment.Far;
			columnItem23.BackColor = Color.FromArgb(64, 64, 64);
			columnItem23.ColumnAlignment = StringAlignment.Center;
			columnItem23.FontColor = Color.LightGray;
			columnItem23.MyStyle = FontStyle.Regular;
			columnItem23.Name = "realize";
			columnItem23.Text = "Realize";
			columnItem23.ValueFormat = FormatType.Text;
			columnItem23.Visible = true;
			columnItem23.Width = 11;
			this.sortGridTfexSumm.Columns.Add(columnItem18);
			this.sortGridTfexSumm.Columns.Add(columnItem19);
			this.sortGridTfexSumm.Columns.Add(columnItem20);
			this.sortGridTfexSumm.Columns.Add(columnItem21);
			this.sortGridTfexSumm.Columns.Add(columnItem22);
			this.sortGridTfexSumm.Columns.Add(columnItem23);
			this.sortGridTfexSumm.CurrentScroll = 0;
			this.sortGridTfexSumm.FocusItemIndex = -1;
			this.sortGridTfexSumm.ForeColor = Color.Black;
			this.sortGridTfexSumm.GridColor = Color.FromArgb(45, 45, 45);
			this.sortGridTfexSumm.HeaderPctHeight = 80f;
			this.sortGridTfexSumm.IsAutoRepaint = true;
			this.sortGridTfexSumm.IsDrawFullRow = false;
			this.sortGridTfexSumm.IsDrawGrid = true;
			this.sortGridTfexSumm.IsDrawHeader = false;
			this.sortGridTfexSumm.IsScrollable = true;
			this.sortGridTfexSumm.Location = new Point(3, 228);
			this.sortGridTfexSumm.MainColumn = "";
			this.sortGridTfexSumm.Name = "sortGridTfexSumm";
			this.sortGridTfexSumm.Rows = 1;
			this.sortGridTfexSumm.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.sortGridTfexSumm.RowSelectType = 0;
			this.sortGridTfexSumm.RowsVisible = 1;
			this.sortGridTfexSumm.Size = new Size(846, 22);
			this.sortGridTfexSumm.SortColumnName = "";
			this.sortGridTfexSumm.SortType = SortType.Desc;
			this.sortGridTfexSumm.TabIndex = 28;
			this.sortGridTfex.AllowDrop = true;
			this.sortGridTfex.BackColor = Color.FromArgb(30, 30, 30);
			this.sortGridTfex.CanBlink = true;
			this.sortGridTfex.CanDrag = false;
			this.sortGridTfex.CanGetMouseMove = false;
			columnItem24.Alignment = StringAlignment.Near;
			columnItem24.BackColor = Color.FromArgb(64, 64, 64);
			columnItem24.ColumnAlignment = StringAlignment.Center;
			columnItem24.FontColor = Color.LightGray;
			columnItem24.MyStyle = FontStyle.Regular;
			columnItem24.Name = "series";
			columnItem24.Text = "Symbol";
			columnItem24.ValueFormat = FormatType.Text;
			columnItem24.Visible = true;
			columnItem24.Width = 11;
			columnItem25.Alignment = StringAlignment.Center;
			columnItem25.BackColor = Color.FromArgb(64, 64, 64);
			columnItem25.ColumnAlignment = StringAlignment.Center;
			columnItem25.FontColor = Color.LightGray;
			columnItem25.MyStyle = FontStyle.Regular;
			columnItem25.Name = "side";
			columnItem25.Text = "Side";
			columnItem25.ValueFormat = FormatType.Text;
			columnItem25.Visible = true;
			columnItem25.Width = 6;
			columnItem26.Alignment = StringAlignment.Far;
			columnItem26.BackColor = Color.FromArgb(64, 64, 64);
			columnItem26.ColumnAlignment = StringAlignment.Center;
			columnItem26.FontColor = Color.LightGray;
			columnItem26.MyStyle = FontStyle.Regular;
			columnItem26.Name = "start_vol";
			columnItem26.Text = "Str.Vol";
			columnItem26.ValueFormat = FormatType.Text;
			columnItem26.Visible = true;
			columnItem26.Width = 7;
			columnItem27.Alignment = StringAlignment.Far;
			columnItem27.BackColor = Color.FromArgb(64, 64, 64);
			columnItem27.ColumnAlignment = StringAlignment.Center;
			columnItem27.FontColor = Color.LightGray;
			columnItem27.MyStyle = FontStyle.Regular;
			columnItem27.Name = "onhand";
			columnItem27.Text = "OnHand";
			columnItem27.ValueFormat = FormatType.Text;
			columnItem27.Visible = true;
			columnItem27.Width = 7;
			columnItem28.Alignment = StringAlignment.Far;
			columnItem28.BackColor = Color.FromArgb(64, 64, 64);
			columnItem28.ColumnAlignment = StringAlignment.Center;
			columnItem28.FontColor = Color.LightGray;
			columnItem28.MyStyle = FontStyle.Regular;
			columnItem28.Name = "sellable";
			columnItem28.Text = "Sellable";
			columnItem28.ValueFormat = FormatType.Text;
			columnItem28.Visible = true;
			columnItem28.Width = 7;
			columnItem29.Alignment = StringAlignment.Far;
			columnItem29.BackColor = Color.FromArgb(64, 64, 64);
			columnItem29.ColumnAlignment = StringAlignment.Center;
			columnItem29.FontColor = Color.LightGray;
			columnItem29.MyStyle = FontStyle.Regular;
			columnItem29.Name = "cost_avg";
			columnItem29.Text = "C.Avg";
			columnItem29.ValueFormat = FormatType.Text;
			columnItem29.Visible = false;
			columnItem29.Width = 9;
			columnItem30.Alignment = StringAlignment.Far;
			columnItem30.BackColor = Color.FromArgb(64, 64, 64);
			columnItem30.ColumnAlignment = StringAlignment.Center;
			columnItem30.FontColor = Color.LightGray;
			columnItem30.MyStyle = FontStyle.Regular;
			columnItem30.Name = "cost_settle";
			columnItem30.Text = "C.Settle";
			columnItem30.ValueFormat = FormatType.Text;
			columnItem30.Visible = true;
			columnItem30.Width = 9;
			columnItem31.Alignment = StringAlignment.Far;
			columnItem31.BackColor = Color.FromArgb(64, 64, 64);
			columnItem31.ColumnAlignment = StringAlignment.Center;
			columnItem31.FontColor = Color.LightGray;
			columnItem31.MyStyle = FontStyle.Regular;
			columnItem31.Name = "last";
			columnItem31.Text = "Last";
			columnItem31.ValueFormat = FormatType.Text;
			columnItem31.Visible = true;
			columnItem31.Width = 9;
			columnItem32.Alignment = StringAlignment.Far;
			columnItem32.BackColor = Color.FromArgb(64, 64, 64);
			columnItem32.ColumnAlignment = StringAlignment.Center;
			columnItem32.FontColor = Color.LightGray;
			columnItem32.MyStyle = FontStyle.Regular;
			columnItem32.Name = "mkt_val";
			columnItem32.Text = "MktVal";
			columnItem32.ValueFormat = FormatType.Text;
			columnItem32.Visible = true;
			columnItem32.Width = 11;
			columnItem33.Alignment = StringAlignment.Far;
			columnItem33.BackColor = Color.FromArgb(64, 64, 64);
			columnItem33.ColumnAlignment = StringAlignment.Center;
			columnItem33.FontColor = Color.LightGray;
			columnItem33.MyStyle = FontStyle.Regular;
			columnItem33.Name = "cost_val";
			columnItem33.Text = "C.Val";
			columnItem33.ValueFormat = FormatType.Text;
			columnItem33.Visible = true;
			columnItem33.Width = 11;
			columnItem34.Alignment = StringAlignment.Far;
			columnItem34.BackColor = Color.Teal;
			columnItem34.ColumnAlignment = StringAlignment.Center;
			columnItem34.FontColor = Color.LightGray;
			columnItem34.MyStyle = FontStyle.Underline;
			columnItem34.Name = "unreal_settle";
			columnItem34.Text = "Unrl(Settle)";
			columnItem34.ValueFormat = FormatType.Text;
			columnItem34.Visible = true;
			columnItem34.Width = 11;
			columnItem35.Alignment = StringAlignment.Far;
			columnItem35.BackColor = Color.Teal;
			columnItem35.ColumnAlignment = StringAlignment.Center;
			columnItem35.FontColor = Color.LightGray;
			columnItem35.MyStyle = FontStyle.Underline;
			columnItem35.Name = "unreal_cost";
			columnItem35.Text = "Unrl(Cost)";
			columnItem35.ValueFormat = FormatType.Text;
			columnItem35.Visible = false;
			columnItem35.Width = 11;
			columnItem36.Alignment = StringAlignment.Far;
			columnItem36.BackColor = Color.FromArgb(64, 64, 64);
			columnItem36.ColumnAlignment = StringAlignment.Center;
			columnItem36.FontColor = Color.LightGray;
			columnItem36.MyStyle = FontStyle.Regular;
			columnItem36.Name = "realize";
			columnItem36.Text = "Realized";
			columnItem36.ValueFormat = FormatType.Text;
			columnItem36.Visible = true;
			columnItem36.Width = 11;
			this.sortGridTfex.Columns.Add(columnItem24);
			this.sortGridTfex.Columns.Add(columnItem25);
			this.sortGridTfex.Columns.Add(columnItem26);
			this.sortGridTfex.Columns.Add(columnItem27);
			this.sortGridTfex.Columns.Add(columnItem28);
			this.sortGridTfex.Columns.Add(columnItem29);
			this.sortGridTfex.Columns.Add(columnItem30);
			this.sortGridTfex.Columns.Add(columnItem31);
			this.sortGridTfex.Columns.Add(columnItem32);
			this.sortGridTfex.Columns.Add(columnItem33);
			this.sortGridTfex.Columns.Add(columnItem34);
			this.sortGridTfex.Columns.Add(columnItem35);
			this.sortGridTfex.Columns.Add(columnItem36);
			this.sortGridTfex.CurrentScroll = 0;
			this.sortGridTfex.FocusItemIndex = -1;
			this.sortGridTfex.ForeColor = Color.Black;
			this.sortGridTfex.GridColor = Color.FromArgb(45, 45, 45);
			this.sortGridTfex.HeaderPctHeight = 80f;
			this.sortGridTfex.IsAutoRepaint = true;
			this.sortGridTfex.IsDrawFullRow = false;
			this.sortGridTfex.IsDrawGrid = true;
			this.sortGridTfex.IsDrawHeader = true;
			this.sortGridTfex.IsScrollable = true;
			this.sortGridTfex.Location = new Point(0, 137);
			this.sortGridTfex.MainColumn = "";
			this.sortGridTfex.Name = "sortGridTfex";
			this.sortGridTfex.Rows = 0;
			this.sortGridTfex.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.sortGridTfex.RowSelectType = 0;
			this.sortGridTfex.RowsVisible = 0;
			this.sortGridTfex.Size = new Size(846, 73);
			this.sortGridTfex.SortColumnName = "";
			this.sortGridTfex.SortType = SortType.Desc;
			this.sortGridTfex.TabIndex = 27;
			this.sortGridTfex.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.sortGridTfex_TableMouseClick);
			this.intzaCustBottTfex.AllowDrop = true;
			this.intzaCustBottTfex.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaCustBottTfex.CanDrag = false;
			this.intzaCustBottTfex.IsAutoRepaint = true;
			this.intzaCustBottTfex.IsDroped = false;
			itemGrid135.AdjustFontSize = -1f;
			itemGrid135.Alignment = StringAlignment.Near;
			itemGrid135.BackColor = Color.DimGray;
			itemGrid135.Changed = false;
			itemGrid135.FieldType = ItemType.TextGradient;
			itemGrid135.FontColor = Color.LightGray;
			itemGrid135.FontStyle = FontStyle.Regular;
			itemGrid135.Height = 1f;
			itemGrid135.IsBlink = 0;
			itemGrid135.Name = "lbBankCol";
			itemGrid135.Text = "";
			itemGrid135.ValueFormat = FormatType.Text;
			itemGrid135.Visible = true;
			itemGrid135.Width = 25;
			itemGrid135.X = 0;
			itemGrid135.Y = 0f;
			itemGrid136.AdjustFontSize = -1f;
			itemGrid136.Alignment = StringAlignment.Center;
			itemGrid136.BackColor = Color.DimGray;
			itemGrid136.Changed = false;
			itemGrid136.FieldType = ItemType.TextGradient;
			itemGrid136.FontColor = Color.LightGray;
			itemGrid136.FontStyle = FontStyle.Regular;
			itemGrid136.Height = 1f;
			itemGrid136.IsBlink = 0;
			itemGrid136.Name = "lbPrevious";
			itemGrid136.Text = "Previous";
			itemGrid136.ValueFormat = FormatType.Text;
			itemGrid136.Visible = true;
			itemGrid136.Width = 25;
			itemGrid136.X = 25;
			itemGrid136.Y = 0f;
			itemGrid137.AdjustFontSize = -1f;
			itemGrid137.Alignment = StringAlignment.Center;
			itemGrid137.BackColor = Color.DimGray;
			itemGrid137.Changed = false;
			itemGrid137.FieldType = ItemType.TextGradient;
			itemGrid137.FontColor = Color.LightGray;
			itemGrid137.FontStyle = FontStyle.Regular;
			itemGrid137.Height = 1f;
			itemGrid137.IsBlink = 0;
			itemGrid137.Name = "lbCurrent";
			itemGrid137.Text = "Current (Expected)";
			itemGrid137.ValueFormat = FormatType.Text;
			itemGrid137.Visible = true;
			itemGrid137.Width = 25;
			itemGrid137.X = 50;
			itemGrid137.Y = 0f;
			itemGrid138.AdjustFontSize = -1f;
			itemGrid138.Alignment = StringAlignment.Center;
			itemGrid138.BackColor = Color.DimGray;
			itemGrid138.Changed = false;
			itemGrid138.FieldType = ItemType.TextGradient;
			itemGrid138.FontColor = Color.LightGray;
			itemGrid138.FontStyle = FontStyle.Regular;
			itemGrid138.Height = 1f;
			itemGrid138.IsBlink = 0;
			itemGrid138.Name = "lbCurrentPort";
			itemGrid138.Text = "Current (Port)";
			itemGrid138.ValueFormat = FormatType.Text;
			itemGrid138.Visible = true;
			itemGrid138.Width = 25;
			itemGrid138.X = 75;
			itemGrid138.Y = 0f;
			itemGrid139.AdjustFontSize = 0f;
			itemGrid139.Alignment = StringAlignment.Near;
			itemGrid139.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid139.Changed = false;
			itemGrid139.FieldType = ItemType.Label;
			itemGrid139.FontColor = Color.LightGray;
			itemGrid139.FontStyle = FontStyle.Regular;
			itemGrid139.Height = 1f;
			itemGrid139.IsBlink = 0;
			itemGrid139.Name = "lbEquityBalance";
			itemGrid139.Text = "Equity Balance";
			itemGrid139.ValueFormat = FormatType.Text;
			itemGrid139.Visible = true;
			itemGrid139.Width = 25;
			itemGrid139.X = 0;
			itemGrid139.Y = 1f;
			itemGrid140.AdjustFontSize = 0f;
			itemGrid140.Alignment = StringAlignment.Near;
			itemGrid140.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid140.Changed = false;
			itemGrid140.FieldType = ItemType.Text;
			itemGrid140.FontColor = Color.White;
			itemGrid140.FontStyle = FontStyle.Regular;
			itemGrid140.Height = 1f;
			itemGrid140.IsBlink = 0;
			itemGrid140.Name = "tbEquityBalancePrevious";
			itemGrid140.Text = "";
			itemGrid140.ValueFormat = FormatType.Text;
			itemGrid140.Visible = true;
			itemGrid140.Width = 25;
			itemGrid140.X = 25;
			itemGrid140.Y = 1f;
			itemGrid141.AdjustFontSize = 0f;
			itemGrid141.Alignment = StringAlignment.Near;
			itemGrid141.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid141.Changed = false;
			itemGrid141.FieldType = ItemType.Text;
			itemGrid141.FontColor = Color.White;
			itemGrid141.FontStyle = FontStyle.Regular;
			itemGrid141.Height = 1f;
			itemGrid141.IsBlink = 0;
			itemGrid141.Name = "tbEquityBalanceCurrent";
			itemGrid141.Text = "";
			itemGrid141.ValueFormat = FormatType.Text;
			itemGrid141.Visible = true;
			itemGrid141.Width = 25;
			itemGrid141.X = 50;
			itemGrid141.Y = 1f;
			itemGrid142.AdjustFontSize = 0f;
			itemGrid142.Alignment = StringAlignment.Near;
			itemGrid142.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid142.Changed = false;
			itemGrid142.FieldType = ItemType.Text;
			itemGrid142.FontColor = Color.White;
			itemGrid142.FontStyle = FontStyle.Regular;
			itemGrid142.Height = 1f;
			itemGrid142.IsBlink = 0;
			itemGrid142.Name = "tbEquityBalanceCurrentPort";
			itemGrid142.Text = "";
			itemGrid142.ValueFormat = FormatType.Text;
			itemGrid142.Visible = true;
			itemGrid142.Width = 25;
			itemGrid142.X = 75;
			itemGrid142.Y = 1f;
			itemGrid143.AdjustFontSize = 0f;
			itemGrid143.Alignment = StringAlignment.Near;
			itemGrid143.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid143.Changed = false;
			itemGrid143.FieldType = ItemType.Label;
			itemGrid143.FontColor = Color.LightGray;
			itemGrid143.FontStyle = FontStyle.Regular;
			itemGrid143.Height = 1f;
			itemGrid143.IsBlink = 0;
			itemGrid143.Name = "lbEEBalance";
			itemGrid143.Text = "Excess Equity Balance";
			itemGrid143.ValueFormat = FormatType.Text;
			itemGrid143.Visible = true;
			itemGrid143.Width = 25;
			itemGrid143.X = 0;
			itemGrid143.Y = 2f;
			itemGrid144.AdjustFontSize = 0f;
			itemGrid144.Alignment = StringAlignment.Near;
			itemGrid144.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid144.Changed = false;
			itemGrid144.FieldType = ItemType.Text;
			itemGrid144.FontColor = Color.White;
			itemGrid144.FontStyle = FontStyle.Regular;
			itemGrid144.Height = 1f;
			itemGrid144.IsBlink = 0;
			itemGrid144.Name = "tbEEBalancePrevious";
			itemGrid144.Text = "";
			itemGrid144.ValueFormat = FormatType.Text;
			itemGrid144.Visible = true;
			itemGrid144.Width = 25;
			itemGrid144.X = 25;
			itemGrid144.Y = 2f;
			itemGrid145.AdjustFontSize = 0f;
			itemGrid145.Alignment = StringAlignment.Near;
			itemGrid145.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid145.Changed = false;
			itemGrid145.FieldType = ItemType.Text;
			itemGrid145.FontColor = Color.White;
			itemGrid145.FontStyle = FontStyle.Regular;
			itemGrid145.Height = 1f;
			itemGrid145.IsBlink = 0;
			itemGrid145.Name = "tbEEBalanceCurrent";
			itemGrid145.Text = "";
			itemGrid145.ValueFormat = FormatType.Text;
			itemGrid145.Visible = true;
			itemGrid145.Width = 25;
			itemGrid145.X = 50;
			itemGrid145.Y = 2f;
			itemGrid146.AdjustFontSize = 0f;
			itemGrid146.Alignment = StringAlignment.Near;
			itemGrid146.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid146.Changed = false;
			itemGrid146.FieldType = ItemType.Text;
			itemGrid146.FontColor = Color.White;
			itemGrid146.FontStyle = FontStyle.Regular;
			itemGrid146.Height = 1f;
			itemGrid146.IsBlink = 0;
			itemGrid146.Name = "tbEEBalanceCurerntPort";
			itemGrid146.Text = "";
			itemGrid146.ValueFormat = FormatType.Text;
			itemGrid146.Visible = true;
			itemGrid146.Width = 25;
			itemGrid146.X = 75;
			itemGrid146.Y = 2f;
			itemGrid147.AdjustFontSize = 0f;
			itemGrid147.Alignment = StringAlignment.Near;
			itemGrid147.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid147.Changed = false;
			itemGrid147.FieldType = ItemType.Label;
			itemGrid147.FontColor = Color.LightGray;
			itemGrid147.FontStyle = FontStyle.Regular;
			itemGrid147.Height = 1f;
			itemGrid147.IsBlink = 0;
			itemGrid147.Name = "lbUnrealizedPL";
			itemGrid147.Text = "Unrealized P/L";
			itemGrid147.ValueFormat = FormatType.Text;
			itemGrid147.Visible = true;
			itemGrid147.Width = 25;
			itemGrid147.X = 0;
			itemGrid147.Y = 3f;
			itemGrid148.AdjustFontSize = 0f;
			itemGrid148.Alignment = StringAlignment.Near;
			itemGrid148.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid148.Changed = false;
			itemGrid148.FieldType = ItemType.Text;
			itemGrid148.FontColor = Color.White;
			itemGrid148.FontStyle = FontStyle.Regular;
			itemGrid148.Height = 1f;
			itemGrid148.IsBlink = 0;
			itemGrid148.Name = "tbUnrealizedPLPrevious";
			itemGrid148.Text = "";
			itemGrid148.ValueFormat = FormatType.Text;
			itemGrid148.Visible = true;
			itemGrid148.Width = 25;
			itemGrid148.X = 25;
			itemGrid148.Y = 3f;
			itemGrid149.AdjustFontSize = 0f;
			itemGrid149.Alignment = StringAlignment.Near;
			itemGrid149.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid149.Changed = false;
			itemGrid149.FieldType = ItemType.Text;
			itemGrid149.FontColor = Color.White;
			itemGrid149.FontStyle = FontStyle.Regular;
			itemGrid149.Height = 1f;
			itemGrid149.IsBlink = 0;
			itemGrid149.Name = "tbUnrealizedPLCurrent";
			itemGrid149.Text = "";
			itemGrid149.ValueFormat = FormatType.Text;
			itemGrid149.Visible = true;
			itemGrid149.Width = 25;
			itemGrid149.X = 50;
			itemGrid149.Y = 3f;
			itemGrid150.AdjustFontSize = 0f;
			itemGrid150.Alignment = StringAlignment.Near;
			itemGrid150.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid150.Changed = false;
			itemGrid150.FieldType = ItemType.Text;
			itemGrid150.FontColor = Color.White;
			itemGrid150.FontStyle = FontStyle.Regular;
			itemGrid150.Height = 1f;
			itemGrid150.IsBlink = 0;
			itemGrid150.Name = "tbUnrealizedPLCurrentPort";
			itemGrid150.Text = "";
			itemGrid150.ValueFormat = FormatType.Text;
			itemGrid150.Visible = true;
			itemGrid150.Width = 25;
			itemGrid150.X = 75;
			itemGrid150.Y = 3f;
			itemGrid151.AdjustFontSize = 0f;
			itemGrid151.Alignment = StringAlignment.Near;
			itemGrid151.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid151.Changed = false;
			itemGrid151.FieldType = ItemType.Label;
			itemGrid151.FontColor = Color.LightGray;
			itemGrid151.FontStyle = FontStyle.Regular;
			itemGrid151.Height = 1f;
			itemGrid151.IsBlink = 0;
			itemGrid151.Name = "lbMarginBalance";
			itemGrid151.Text = "Margin Balance";
			itemGrid151.ValueFormat = FormatType.Text;
			itemGrid151.Visible = true;
			itemGrid151.Width = 25;
			itemGrid151.X = 0;
			itemGrid151.Y = 4f;
			itemGrid152.AdjustFontSize = 0f;
			itemGrid152.Alignment = StringAlignment.Near;
			itemGrid152.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid152.Changed = false;
			itemGrid152.FieldType = ItemType.Text;
			itemGrid152.FontColor = Color.White;
			itemGrid152.FontStyle = FontStyle.Regular;
			itemGrid152.Height = 1f;
			itemGrid152.IsBlink = 0;
			itemGrid152.Name = "tbMarginBalancePrevious";
			itemGrid152.Text = "";
			itemGrid152.ValueFormat = FormatType.Text;
			itemGrid152.Visible = true;
			itemGrid152.Width = 25;
			itemGrid152.X = 25;
			itemGrid152.Y = 4f;
			itemGrid153.AdjustFontSize = 0f;
			itemGrid153.Alignment = StringAlignment.Near;
			itemGrid153.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid153.Changed = false;
			itemGrid153.FieldType = ItemType.Text;
			itemGrid153.FontColor = Color.White;
			itemGrid153.FontStyle = FontStyle.Regular;
			itemGrid153.Height = 1f;
			itemGrid153.IsBlink = 0;
			itemGrid153.Name = "tbMarginBalanceCurrent";
			itemGrid153.Text = "";
			itemGrid153.ValueFormat = FormatType.Price;
			itemGrid153.Visible = true;
			itemGrid153.Width = 25;
			itemGrid153.X = 50;
			itemGrid153.Y = 4f;
			itemGrid154.AdjustFontSize = 0f;
			itemGrid154.Alignment = StringAlignment.Near;
			itemGrid154.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid154.Changed = false;
			itemGrid154.FieldType = ItemType.Text;
			itemGrid154.FontColor = Color.White;
			itemGrid154.FontStyle = FontStyle.Regular;
			itemGrid154.Height = 1f;
			itemGrid154.IsBlink = 0;
			itemGrid154.Name = "tbMarginBalanceCurrentPort";
			itemGrid154.Text = "";
			itemGrid154.ValueFormat = FormatType.Text;
			itemGrid154.Visible = true;
			itemGrid154.Width = 25;
			itemGrid154.X = 75;
			itemGrid154.Y = 4f;
			itemGrid155.AdjustFontSize = 0f;
			itemGrid155.Alignment = StringAlignment.Near;
			itemGrid155.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid155.Changed = false;
			itemGrid155.FieldType = ItemType.Label;
			itemGrid155.FontColor = Color.LightGray;
			itemGrid155.FontStyle = FontStyle.Regular;
			itemGrid155.Height = 1f;
			itemGrid155.IsBlink = 0;
			itemGrid155.Name = "lbCallForce";
			itemGrid155.Text = "Call Force Flag / Amount";
			itemGrid155.ValueFormat = FormatType.Text;
			itemGrid155.Visible = true;
			itemGrid155.Width = 25;
			itemGrid155.X = 0;
			itemGrid155.Y = 5f;
			itemGrid156.AdjustFontSize = 0f;
			itemGrid156.Alignment = StringAlignment.Near;
			itemGrid156.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid156.Changed = false;
			itemGrid156.FieldType = ItemType.Text;
			itemGrid156.FontColor = Color.White;
			itemGrid156.FontStyle = FontStyle.Regular;
			itemGrid156.Height = 1f;
			itemGrid156.IsBlink = 0;
			itemGrid156.Name = "tbCallForcePrevious";
			itemGrid156.Text = "";
			itemGrid156.ValueFormat = FormatType.Text;
			itemGrid156.Visible = true;
			itemGrid156.Width = 25;
			itemGrid156.X = 25;
			itemGrid156.Y = 5f;
			itemGrid157.AdjustFontSize = 0f;
			itemGrid157.Alignment = StringAlignment.Near;
			itemGrid157.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid157.Changed = false;
			itemGrid157.FieldType = ItemType.Text;
			itemGrid157.FontColor = Color.White;
			itemGrid157.FontStyle = FontStyle.Regular;
			itemGrid157.Height = 1f;
			itemGrid157.IsBlink = 0;
			itemGrid157.Name = "tbCallForceCurrent";
			itemGrid157.Text = "";
			itemGrid157.ValueFormat = FormatType.Text;
			itemGrid157.Visible = true;
			itemGrid157.Width = 25;
			itemGrid157.X = 50;
			itemGrid157.Y = 5f;
			itemGrid158.AdjustFontSize = 0f;
			itemGrid158.Alignment = StringAlignment.Near;
			itemGrid158.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid158.Changed = false;
			itemGrid158.FieldType = ItemType.Text;
			itemGrid158.FontColor = Color.White;
			itemGrid158.FontStyle = FontStyle.Regular;
			itemGrid158.Height = 1f;
			itemGrid158.IsBlink = 0;
			itemGrid158.Name = "tbCallForceCurrentPort";
			itemGrid158.Text = "";
			itemGrid158.ValueFormat = FormatType.Text;
			itemGrid158.Visible = true;
			itemGrid158.Width = 25;
			itemGrid158.X = 75;
			itemGrid158.Y = 5f;
			this.intzaCustBottTfex.Items.Add(itemGrid135);
			this.intzaCustBottTfex.Items.Add(itemGrid136);
			this.intzaCustBottTfex.Items.Add(itemGrid137);
			this.intzaCustBottTfex.Items.Add(itemGrid138);
			this.intzaCustBottTfex.Items.Add(itemGrid139);
			this.intzaCustBottTfex.Items.Add(itemGrid140);
			this.intzaCustBottTfex.Items.Add(itemGrid141);
			this.intzaCustBottTfex.Items.Add(itemGrid142);
			this.intzaCustBottTfex.Items.Add(itemGrid143);
			this.intzaCustBottTfex.Items.Add(itemGrid144);
			this.intzaCustBottTfex.Items.Add(itemGrid145);
			this.intzaCustBottTfex.Items.Add(itemGrid146);
			this.intzaCustBottTfex.Items.Add(itemGrid147);
			this.intzaCustBottTfex.Items.Add(itemGrid148);
			this.intzaCustBottTfex.Items.Add(itemGrid149);
			this.intzaCustBottTfex.Items.Add(itemGrid150);
			this.intzaCustBottTfex.Items.Add(itemGrid151);
			this.intzaCustBottTfex.Items.Add(itemGrid152);
			this.intzaCustBottTfex.Items.Add(itemGrid153);
			this.intzaCustBottTfex.Items.Add(itemGrid154);
			this.intzaCustBottTfex.Items.Add(itemGrid155);
			this.intzaCustBottTfex.Items.Add(itemGrid156);
			this.intzaCustBottTfex.Items.Add(itemGrid157);
			this.intzaCustBottTfex.Items.Add(itemGrid158);
			this.intzaCustBottTfex.LineColor = Color.Red;
			this.intzaCustBottTfex.Location = new Point(3, 86);
			this.intzaCustBottTfex.Margin = new Padding(1);
			this.intzaCustBottTfex.Name = "intzaCustBottTfex";
			this.intzaCustBottTfex.Size = new Size(851, 47);
			this.intzaCustBottTfex.TabIndex = 26;
			this.intzaCustBottTfex.TabStop = false;
			this.intzaCustHeadTfex.AllowDrop = true;
			this.intzaCustHeadTfex.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.intzaCustHeadTfex.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaCustHeadTfex.CanDrag = false;
			this.intzaCustHeadTfex.IsAutoRepaint = true;
			this.intzaCustHeadTfex.IsDroped = false;
			itemGrid159.AdjustFontSize = -1f;
			itemGrid159.Alignment = StringAlignment.Near;
			itemGrid159.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid159.Changed = false;
			itemGrid159.FieldType = ItemType.Label2;
			itemGrid159.FontColor = Color.LightGray;
			itemGrid159.FontStyle = FontStyle.Regular;
			itemGrid159.Height = 1f;
			itemGrid159.IsBlink = 0;
			itemGrid159.Name = "lbCustName";
			itemGrid159.Text = "Name";
			itemGrid159.ValueFormat = FormatType.Text;
			itemGrid159.Visible = true;
			itemGrid159.Width = 14;
			itemGrid159.X = 0;
			itemGrid159.Y = 0f;
			itemGrid160.AdjustFontSize = 0f;
			itemGrid160.Alignment = StringAlignment.Near;
			itemGrid160.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid160.Changed = false;
			itemGrid160.FieldType = ItemType.Text;
			itemGrid160.FontColor = Color.Yellow;
			itemGrid160.FontStyle = FontStyle.Regular;
			itemGrid160.Height = 1f;
			itemGrid160.IsBlink = 0;
			itemGrid160.Name = "tbCustName";
			itemGrid160.Text = "";
			itemGrid160.ValueFormat = FormatType.Text;
			itemGrid160.Visible = true;
			itemGrid160.Width = 32;
			itemGrid160.X = 14;
			itemGrid160.Y = 0f;
			itemGrid161.AdjustFontSize = -1f;
			itemGrid161.Alignment = StringAlignment.Near;
			itemGrid161.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid161.Changed = false;
			itemGrid161.FieldType = ItemType.Label2;
			itemGrid161.FontColor = Color.LightGray;
			itemGrid161.FontStyle = FontStyle.Regular;
			itemGrid161.Height = 1f;
			itemGrid161.IsBlink = 0;
			itemGrid161.Name = "lbVipFlag";
			itemGrid161.Text = "Vip Flag";
			itemGrid161.ValueFormat = FormatType.Text;
			itemGrid161.Visible = false;
			itemGrid161.Width = 14;
			itemGrid161.X = 0;
			itemGrid161.Y = 1f;
			itemGrid162.AdjustFontSize = 0f;
			itemGrid162.Alignment = StringAlignment.Near;
			itemGrid162.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid162.Changed = false;
			itemGrid162.FieldType = ItemType.Text;
			itemGrid162.FontColor = Color.Yellow;
			itemGrid162.FontStyle = FontStyle.Regular;
			itemGrid162.Height = 1f;
			itemGrid162.IsBlink = 0;
			itemGrid162.Name = "tbVipFlag";
			itemGrid162.Text = "";
			itemGrid162.ValueFormat = FormatType.Text;
			itemGrid162.Visible = false;
			itemGrid162.Width = 17;
			itemGrid162.X = 14;
			itemGrid162.Y = 1f;
			itemGrid163.AdjustFontSize = -1f;
			itemGrid163.Alignment = StringAlignment.Near;
			itemGrid163.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid163.Changed = false;
			itemGrid163.FieldType = ItemType.Label2;
			itemGrid163.FontColor = Color.LightGray;
			itemGrid163.FontStyle = FontStyle.Regular;
			itemGrid163.Height = 1f;
			itemGrid163.IsBlink = 0;
			itemGrid163.Name = "lbAccountType";
			itemGrid163.Text = "Account Type";
			itemGrid163.ValueFormat = FormatType.Text;
			itemGrid163.Visible = true;
			itemGrid163.Width = 14;
			itemGrid163.X = 0;
			itemGrid163.Y = 1f;
			itemGrid164.AdjustFontSize = 0f;
			itemGrid164.Alignment = StringAlignment.Near;
			itemGrid164.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid164.Changed = false;
			itemGrid164.FieldType = ItemType.Text;
			itemGrid164.FontColor = Color.Yellow;
			itemGrid164.FontStyle = FontStyle.Regular;
			itemGrid164.Height = 1f;
			itemGrid164.IsBlink = 0;
			itemGrid164.Name = "tbAccountType";
			itemGrid164.Text = "";
			itemGrid164.ValueFormat = FormatType.Text;
			itemGrid164.Visible = true;
			itemGrid164.Width = 17;
			itemGrid164.X = 14;
			itemGrid164.Y = 1f;
			itemGrid165.AdjustFontSize = -1f;
			itemGrid165.Alignment = StringAlignment.Near;
			itemGrid165.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid165.Changed = false;
			itemGrid165.FieldType = ItemType.Label2;
			itemGrid165.FontColor = Color.LightGray;
			itemGrid165.FontStyle = FontStyle.Regular;
			itemGrid165.Height = 1f;
			itemGrid165.IsBlink = 0;
			itemGrid165.Name = "lbCantOverCredit";
			itemGrid165.Text = "Can't over credit";
			itemGrid165.ValueFormat = FormatType.Text;
			itemGrid165.Visible = false;
			itemGrid165.Width = 14;
			itemGrid165.X = 0;
			itemGrid165.Y = 2f;
			itemGrid166.AdjustFontSize = 0f;
			itemGrid166.Alignment = StringAlignment.Near;
			itemGrid166.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid166.Changed = false;
			itemGrid166.FieldType = ItemType.Text;
			itemGrid166.FontColor = Color.Yellow;
			itemGrid166.FontStyle = FontStyle.Regular;
			itemGrid166.Height = 1f;
			itemGrid166.IsBlink = 0;
			itemGrid166.Name = "tbCantOverCredit";
			itemGrid166.Text = "";
			itemGrid166.ValueFormat = FormatType.Text;
			itemGrid166.Visible = false;
			itemGrid166.Width = 17;
			itemGrid166.X = 14;
			itemGrid166.Y = 2f;
			itemGrid167.AdjustFontSize = -1f;
			itemGrid167.Alignment = StringAlignment.Near;
			itemGrid167.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid167.Changed = false;
			itemGrid167.FieldType = ItemType.Label2;
			itemGrid167.FontColor = Color.LightGray;
			itemGrid167.FontStyle = FontStyle.Regular;
			itemGrid167.Height = 1f;
			itemGrid167.IsBlink = 0;
			itemGrid167.Name = "lbBuyLimit";
			itemGrid167.Text = "Buy Limit";
			itemGrid167.ValueFormat = FormatType.Text;
			itemGrid167.Visible = true;
			itemGrid167.Width = 14;
			itemGrid167.X = 0;
			itemGrid167.Y = 2f;
			itemGrid168.AdjustFontSize = 0f;
			itemGrid168.Alignment = StringAlignment.Near;
			itemGrid168.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid168.Changed = false;
			itemGrid168.FieldType = ItemType.Text;
			itemGrid168.FontColor = Color.Yellow;
			itemGrid168.FontStyle = FontStyle.Regular;
			itemGrid168.Height = 1f;
			itemGrid168.IsBlink = 0;
			itemGrid168.Name = "tbBuyLimit";
			itemGrid168.Text = "";
			itemGrid168.ValueFormat = FormatType.Text;
			itemGrid168.Visible = true;
			itemGrid168.Width = 17;
			itemGrid168.X = 14;
			itemGrid168.Y = 2f;
			itemGrid169.AdjustFontSize = -1f;
			itemGrid169.Alignment = StringAlignment.Near;
			itemGrid169.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid169.Changed = false;
			itemGrid169.FieldType = ItemType.Label2;
			itemGrid169.FontColor = Color.LightGray;
			itemGrid169.FontStyle = FontStyle.Regular;
			itemGrid169.Height = 1f;
			itemGrid169.IsBlink = 0;
			itemGrid169.Name = "lbCustomerType";
			itemGrid169.Text = "Customer Type";
			itemGrid169.ValueFormat = FormatType.Text;
			itemGrid169.Visible = true;
			itemGrid169.Width = 17;
			itemGrid169.X = 33;
			itemGrid169.Y = 1f;
			itemGrid170.AdjustFontSize = 0f;
			itemGrid170.Alignment = StringAlignment.Near;
			itemGrid170.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid170.Changed = false;
			itemGrid170.FieldType = ItemType.Text;
			itemGrid170.FontColor = Color.Yellow;
			itemGrid170.FontStyle = FontStyle.Regular;
			itemGrid170.Height = 1f;
			itemGrid170.IsBlink = 0;
			itemGrid170.Name = "tbCustomerType";
			itemGrid170.Text = "";
			itemGrid170.ValueFormat = FormatType.Text;
			itemGrid170.Visible = true;
			itemGrid170.Width = 15;
			itemGrid170.X = 50;
			itemGrid170.Y = 1f;
			itemGrid171.AdjustFontSize = -1f;
			itemGrid171.Alignment = StringAlignment.Near;
			itemGrid171.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid171.Changed = false;
			itemGrid171.FieldType = ItemType.Label2;
			itemGrid171.FontColor = Color.LightGray;
			itemGrid171.FontStyle = FontStyle.Regular;
			itemGrid171.Height = 1f;
			itemGrid171.IsBlink = 0;
			itemGrid171.Name = "lbCashBalance";
			itemGrid171.Text = "Prev Cash Balance";
			itemGrid171.ValueFormat = FormatType.Text;
			itemGrid171.Visible = true;
			itemGrid171.Width = 14;
			itemGrid171.X = 0;
			itemGrid171.Y = 3f;
			itemGrid172.AdjustFontSize = 0f;
			itemGrid172.Alignment = StringAlignment.Near;
			itemGrid172.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid172.Changed = false;
			itemGrid172.FieldType = ItemType.Text;
			itemGrid172.FontColor = Color.Yellow;
			itemGrid172.FontStyle = FontStyle.Regular;
			itemGrid172.Height = 1f;
			itemGrid172.IsBlink = 0;
			itemGrid172.Name = "CashBalancePrev";
			itemGrid172.Text = "";
			itemGrid172.ValueFormat = FormatType.Text;
			itemGrid172.Visible = true;
			itemGrid172.Width = 17;
			itemGrid172.X = 14;
			itemGrid172.Y = 3f;
			itemGrid173.AdjustFontSize = -1f;
			itemGrid173.Alignment = StringAlignment.Near;
			itemGrid173.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid173.Changed = false;
			itemGrid173.FieldType = ItemType.Label2;
			itemGrid173.FontColor = Color.LightGray;
			itemGrid173.FontStyle = FontStyle.Regular;
			itemGrid173.Height = 1f;
			itemGrid173.IsBlink = 0;
			itemGrid173.Name = "lbCustomerFlag";
			itemGrid173.Text = "Customer Flag";
			itemGrid173.ValueFormat = FormatType.Text;
			itemGrid173.Visible = true;
			itemGrid173.Width = 15;
			itemGrid173.X = 67;
			itemGrid173.Y = 1f;
			itemGrid174.AdjustFontSize = 0f;
			itemGrid174.Alignment = StringAlignment.Near;
			itemGrid174.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid174.Changed = false;
			itemGrid174.FieldType = ItemType.Text;
			itemGrid174.FontColor = Color.Yellow;
			itemGrid174.FontStyle = FontStyle.Regular;
			itemGrid174.Height = 1f;
			itemGrid174.IsBlink = 0;
			itemGrid174.Name = "tbCustomerFlag";
			itemGrid174.Text = "";
			itemGrid174.ValueFormat = FormatType.Text;
			itemGrid174.Visible = true;
			itemGrid174.Width = 18;
			itemGrid174.X = 82;
			itemGrid174.Y = 1f;
			itemGrid175.AdjustFontSize = -1f;
			itemGrid175.Alignment = StringAlignment.Near;
			itemGrid175.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid175.Changed = false;
			itemGrid175.FieldType = ItemType.Label2;
			itemGrid175.FontColor = Color.LightGray;
			itemGrid175.FontStyle = FontStyle.Regular;
			itemGrid175.Height = 1f;
			itemGrid175.IsBlink = 0;
			itemGrid175.Name = "lbCreditLine";
			itemGrid175.Text = "Credit Line";
			itemGrid175.ValueFormat = FormatType.Text;
			itemGrid175.Visible = true;
			itemGrid175.Width = 15;
			itemGrid175.X = 67;
			itemGrid175.Y = 2f;
			itemGrid176.AdjustFontSize = 0f;
			itemGrid176.Alignment = StringAlignment.Near;
			itemGrid176.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid176.Changed = false;
			itemGrid176.FieldType = ItemType.Text;
			itemGrid176.FontColor = Color.Yellow;
			itemGrid176.FontStyle = FontStyle.Regular;
			itemGrid176.Height = 1f;
			itemGrid176.IsBlink = 0;
			itemGrid176.Name = "tbCreditLine";
			itemGrid176.Text = "";
			itemGrid176.ValueFormat = FormatType.Text;
			itemGrid176.Visible = true;
			itemGrid176.Width = 18;
			itemGrid176.X = 82;
			itemGrid176.Y = 2f;
			itemGrid177.AdjustFontSize = -1f;
			itemGrid177.Alignment = StringAlignment.Near;
			itemGrid177.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid177.Changed = false;
			itemGrid177.FieldType = ItemType.Label2;
			itemGrid177.FontColor = Color.LightGray;
			itemGrid177.FontStyle = FontStyle.Regular;
			itemGrid177.Height = 1f;
			itemGrid177.IsBlink = 0;
			itemGrid177.Name = "lbDepositWithdraw";
			itemGrid177.Text = "Deposit/Withdraw";
			itemGrid177.ValueFormat = FormatType.Text;
			itemGrid177.Visible = true;
			itemGrid177.Width = 17;
			itemGrid177.X = 33;
			itemGrid177.Y = 2f;
			itemGrid178.AdjustFontSize = 0f;
			itemGrid178.Alignment = StringAlignment.Near;
			itemGrid178.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid178.Changed = false;
			itemGrid178.FieldType = ItemType.Text;
			itemGrid178.FontColor = Color.Yellow;
			itemGrid178.FontStyle = FontStyle.Regular;
			itemGrid178.Height = 1f;
			itemGrid178.IsBlink = 0;
			itemGrid178.Name = "tbDepositWithdraw";
			itemGrid178.Text = "";
			itemGrid178.ValueFormat = FormatType.Text;
			itemGrid178.Visible = true;
			itemGrid178.Width = 15;
			itemGrid178.X = 50;
			itemGrid178.Y = 2f;
			itemGrid179.AdjustFontSize = -1f;
			itemGrid179.Alignment = StringAlignment.Near;
			itemGrid179.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid179.Changed = false;
			itemGrid179.FieldType = ItemType.Label2;
			itemGrid179.FontColor = Color.LightGray;
			itemGrid179.FontStyle = FontStyle.Regular;
			itemGrid179.Height = 1f;
			itemGrid179.IsBlink = 0;
			itemGrid179.Name = "lbTrader";
			itemGrid179.Text = "Trader";
			itemGrid179.ValueFormat = FormatType.Text;
			itemGrid179.Visible = true;
			itemGrid179.Width = 6;
			itemGrid179.X = 46;
			itemGrid179.Y = 0f;
			itemGrid180.AdjustFontSize = 0f;
			itemGrid180.Alignment = StringAlignment.Near;
			itemGrid180.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid180.Changed = false;
			itemGrid180.FieldType = ItemType.Text;
			itemGrid180.FontColor = Color.Yellow;
			itemGrid180.FontStyle = FontStyle.Regular;
			itemGrid180.Height = 1f;
			itemGrid180.IsBlink = 0;
			itemGrid180.Name = "tbTrader";
			itemGrid180.Text = "";
			itemGrid180.ValueFormat = FormatType.Text;
			itemGrid180.Visible = true;
			itemGrid180.Width = 35;
			itemGrid180.X = 52;
			itemGrid180.Y = 0f;
			itemGrid181.AdjustFontSize = -1f;
			itemGrid181.Alignment = StringAlignment.Near;
			itemGrid181.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid181.Changed = false;
			itemGrid181.FieldType = ItemType.Label2;
			itemGrid181.FontColor = Color.LightGray;
			itemGrid181.FontStyle = FontStyle.Regular;
			itemGrid181.Height = 1f;
			itemGrid181.IsBlink = 0;
			itemGrid181.Name = "lbCashBalance";
			itemGrid181.Text = "Cash Balance";
			itemGrid181.ValueFormat = FormatType.Text;
			itemGrid181.Visible = true;
			itemGrid181.Width = 17;
			itemGrid181.X = 33;
			itemGrid181.Y = 3f;
			itemGrid182.AdjustFontSize = 0f;
			itemGrid182.Alignment = StringAlignment.Near;
			itemGrid182.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid182.Changed = false;
			itemGrid182.FieldType = ItemType.Text;
			itemGrid182.FontColor = Color.Yellow;
			itemGrid182.FontStyle = FontStyle.Regular;
			itemGrid182.Height = 1f;
			itemGrid182.IsBlink = 0;
			itemGrid182.Name = "tbCashBalance";
			itemGrid182.Text = "";
			itemGrid182.ValueFormat = FormatType.Text;
			itemGrid182.Visible = true;
			itemGrid182.Width = 15;
			itemGrid182.X = 50;
			itemGrid182.Y = 3f;
			itemGrid183.AdjustFontSize = -1f;
			itemGrid183.Alignment = StringAlignment.Near;
			itemGrid183.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid183.Changed = false;
			itemGrid183.FieldType = ItemType.Label2;
			itemGrid183.FontColor = Color.LightGray;
			itemGrid183.FontStyle = FontStyle.Regular;
			itemGrid183.Height = 1f;
			itemGrid183.IsBlink = 0;
			itemGrid183.Name = "lbMMR";
			itemGrid183.Text = "MMR";
			itemGrid183.ValueFormat = FormatType.Text;
			itemGrid183.Visible = false;
			itemGrid183.Width = 17;
			itemGrid183.X = 33;
			itemGrid183.Y = 3f;
			itemGrid184.AdjustFontSize = 0f;
			itemGrid184.Alignment = StringAlignment.Near;
			itemGrid184.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid184.Changed = false;
			itemGrid184.FieldType = ItemType.Text;
			itemGrid184.FontColor = Color.Yellow;
			itemGrid184.FontStyle = FontStyle.Regular;
			itemGrid184.Height = 1f;
			itemGrid184.IsBlink = 0;
			itemGrid184.Name = "tbMMR";
			itemGrid184.Text = "";
			itemGrid184.ValueFormat = FormatType.Text;
			itemGrid184.Visible = false;
			itemGrid184.Width = 15;
			itemGrid184.X = 50;
			itemGrid184.Y = 3f;
			itemGrid185.AdjustFontSize = -1f;
			itemGrid185.Alignment = StringAlignment.Near;
			itemGrid185.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid185.Changed = false;
			itemGrid185.FieldType = ItemType.Label2;
			itemGrid185.FontColor = Color.LightGray;
			itemGrid185.FontStyle = FontStyle.Regular;
			itemGrid185.Height = 1f;
			itemGrid185.IsBlink = 0;
			itemGrid185.Name = "lbCommvat";
			itemGrid185.Text = "Comm+Vat";
			itemGrid185.ValueFormat = FormatType.Text;
			itemGrid185.Visible = true;
			itemGrid185.Width = 15;
			itemGrid185.X = 67;
			itemGrid185.Y = 3f;
			itemGrid186.AdjustFontSize = 0f;
			itemGrid186.Alignment = StringAlignment.Near;
			itemGrid186.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid186.Changed = false;
			itemGrid186.FieldType = ItemType.Text;
			itemGrid186.FontColor = Color.Yellow;
			itemGrid186.FontStyle = FontStyle.Regular;
			itemGrid186.Height = 1f;
			itemGrid186.IsBlink = 0;
			itemGrid186.Name = "tbCommvat";
			itemGrid186.Text = "";
			itemGrid186.ValueFormat = FormatType.Text;
			itemGrid186.Visible = true;
			itemGrid186.Width = 18;
			itemGrid186.X = 82;
			itemGrid186.Y = 3f;
			this.intzaCustHeadTfex.Items.Add(itemGrid159);
			this.intzaCustHeadTfex.Items.Add(itemGrid160);
			this.intzaCustHeadTfex.Items.Add(itemGrid161);
			this.intzaCustHeadTfex.Items.Add(itemGrid162);
			this.intzaCustHeadTfex.Items.Add(itemGrid163);
			this.intzaCustHeadTfex.Items.Add(itemGrid164);
			this.intzaCustHeadTfex.Items.Add(itemGrid165);
			this.intzaCustHeadTfex.Items.Add(itemGrid166);
			this.intzaCustHeadTfex.Items.Add(itemGrid167);
			this.intzaCustHeadTfex.Items.Add(itemGrid168);
			this.intzaCustHeadTfex.Items.Add(itemGrid169);
			this.intzaCustHeadTfex.Items.Add(itemGrid170);
			this.intzaCustHeadTfex.Items.Add(itemGrid171);
			this.intzaCustHeadTfex.Items.Add(itemGrid172);
			this.intzaCustHeadTfex.Items.Add(itemGrid173);
			this.intzaCustHeadTfex.Items.Add(itemGrid174);
			this.intzaCustHeadTfex.Items.Add(itemGrid175);
			this.intzaCustHeadTfex.Items.Add(itemGrid176);
			this.intzaCustHeadTfex.Items.Add(itemGrid177);
			this.intzaCustHeadTfex.Items.Add(itemGrid178);
			this.intzaCustHeadTfex.Items.Add(itemGrid179);
			this.intzaCustHeadTfex.Items.Add(itemGrid180);
			this.intzaCustHeadTfex.Items.Add(itemGrid181);
			this.intzaCustHeadTfex.Items.Add(itemGrid182);
			this.intzaCustHeadTfex.Items.Add(itemGrid183);
			this.intzaCustHeadTfex.Items.Add(itemGrid184);
			this.intzaCustHeadTfex.Items.Add(itemGrid185);
			this.intzaCustHeadTfex.Items.Add(itemGrid186);
			this.intzaCustHeadTfex.LineColor = Color.Red;
			this.intzaCustHeadTfex.Location = new Point(0, 30);
			this.intzaCustHeadTfex.Margin = new Padding(0);
			this.intzaCustHeadTfex.Name = "intzaCustHeadTfex";
			this.intzaCustHeadTfex.Size = new Size(852, 48);
			this.intzaCustHeadTfex.TabIndex = 26;
			this.intzaCustHeadTfex.TabStop = false;
			this.tStripMainT.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripMainT.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMainT.Items.AddRange(new ToolStripItem[]
			{
				this.tsbtnPrintT,
				this.tsCbTFexMainSelect,
				this.tsCbTFexSubSelect
			});
			this.tStripMainT.Location = new Point(0, 0);
			this.tStripMainT.Name = "tStripMainT";
			this.tStripMainT.Padding = new Padding(1, 1, 1, 4);
			this.tStripMainT.RenderMode = ToolStripRenderMode.System;
			this.tStripMainT.Size = new Size(852, 28);
			this.tStripMainT.TabIndex = 26;
			this.tStripMainT.Tag = "-1";
			this.tStripMainT.Text = "toolStrip1";
			this.tsbtnPrintT.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnPrintT.BackColor = Color.Transparent;
			this.tsbtnPrintT.ForeColor = Color.LightGray;
			this.tsbtnPrintT.Image = (Image)componentResourceManager.GetObject("tsbtnPrintT.Image");
			this.tsbtnPrintT.ImageTransparentColor = Color.Magenta;
			this.tsbtnPrintT.Name = "tsbtnPrintT";
			this.tsbtnPrintT.Size = new Size(52, 20);
			this.tsbtnPrintT.Text = "Print";
			this.tsbtnPrintT.Click += new EventHandler(this.tsbtnPrintT_Click);
			this.tsCbTFexMainSelect.AutoSize = false;
			this.tsCbTFexMainSelect.BackColor = Color.FromArgb(30, 30, 30);
			this.tsCbTFexMainSelect.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tsCbTFexMainSelect.DropDownWidth = 130;
			this.tsCbTFexMainSelect.ForeColor = Color.WhiteSmoke;
			this.tsCbTFexMainSelect.Name = "tsCbTFexMainSelect";
			this.tsCbTFexMainSelect.Padding = new Padding(5, 0, 0, 0);
			this.tsCbTFexMainSelect.Size = new Size(60, 23);
			this.tsCbTFexMainSelect.SelectedIndexChanged += new EventHandler(this.tsCbTFexMainSelect_SelectedIndexChanged);
			this.tsCbTFexSubSelect.AutoSize = false;
			this.tsCbTFexSubSelect.BackColor = Color.FromArgb(30, 30, 30);
			this.tsCbTFexSubSelect.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tsCbTFexSubSelect.DropDownWidth = 140;
			this.tsCbTFexSubSelect.ForeColor = Color.WhiteSmoke;
			this.tsCbTFexSubSelect.Name = "tsCbTFexSubSelect";
			this.tsCbTFexSubSelect.Padding = new Padding(5, 0, 0, 0);
			this.tsCbTFexSubSelect.Size = new Size(60, 23);
			this.tsCbTFexSubSelect.SelectedIndexChanged += new EventHandler(this.tsCbTFexSubSelect_SelectedIndexChanged);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(64, 64, 64);
			base.ClientSize = new Size(879, 594);
			base.Controls.Add(this.panelTFEXPort);
			base.Controls.Add(this.panelSET);
			base.Name = "frmPortfolio";
			this.Text = "Portfolio";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmPortfolio_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmPortfolio_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmPortfolio_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmPortfolio_IDoCustomSizeChanged);
			base.IDoSymbolLinked += new ClientBaseForm.OnSymbolLinkEventHandler(this.frmPortfolio_IDoSymbolLinked);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmPortfolio_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmPortfolio_IDoReActivated);
			base.Controls.SetChildIndex(this.panelSET, 0);
			base.Controls.SetChildIndex(this.panelTFEXPort, 0);
			this.tStripMain.ResumeLayout(false);
			this.tStripMain.PerformLayout();
			this.panelNav.ResumeLayout(false);
			this.panelNav.PerformLayout();
			this.panelNavAdjust.ResumeLayout(false);
			this.panelNavAdjust.PerformLayout();
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			this.panelSET.ResumeLayout(false);
			this.panelSET.PerformLayout();
			this.panelReportMenu.ResumeLayout(false);
			this.panelReportMenu.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panelTFEXPort.ResumeLayout(false);
			this.panelTFEXPort.PerformLayout();
			this.tStripMainT.ResumeLayout(false);
			this.tStripMainT.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000260 RID: 608
		private string _currAccount;

		// Token: 0x04000261 RID: 609
		private string _accType;

		// Token: 0x04000262 RID: 610
		private int _iCommType;

		// Token: 0x04000263 RID: 611
		private bool _isForceUpdate;

		// Token: 0x04000264 RID: 612
		private bool _isSupportCBReport;

		// Token: 0x04000265 RID: 613
		private decimal _tradingFee;

		// Token: 0x04000266 RID: 614
		private decimal _clearingFee;

		// Token: 0x04000267 RID: 615
		private decimal _settlementFee;

		// Token: 0x04000268 RID: 616
		private decimal _buyLimit;

		// Token: 0x04000269 RID: 617
		private decimal _equity;

		// Token: 0x0400026A RID: 618
		private decimal _equityTfex;

		// Token: 0x0400026B RID: 619
		private decimal _totUnReal_Pct;

		// Token: 0x0400026C RID: 620
		private decimal _totUnReal;

		// Token: 0x0400026D RID: 621
		private decimal _totRealize;

		// Token: 0x0400026E RID: 622
		private decimal _totCost;

		// Token: 0x0400026F RID: 623
		private decimal _totCurrValue;

		// Token: 0x04000270 RID: 624
		private decimal _totNetSettle;

		// Token: 0x04000271 RID: 625
		private decimal _totBalanceScore;

		// Token: 0x04000272 RID: 626
		private decimal _totBetaScore;

		// Token: 0x04000273 RID: 627
		private BackgroundWorker bgwLoadReport;

		// Token: 0x04000274 RID: 628
		private int _reportPageNo;

		// Token: 0x04000275 RID: 629
		private int _currentTop;

		// Token: 0x04000276 RID: 630
		private ArrayList _textPrint;

		// Token: 0x04000277 RID: 631
		private PrintPreviewDialog _previewPrinter;

		// Token: 0x04000278 RID: 632
		private PrintDocument _printDocument;

		// Token: 0x04000279 RID: 633
		private PrintDialog _printDialog;

		// Token: 0x0400027A RID: 634
		private int _PAGEPREVIEW;

		// Token: 0x0400027B RID: 635
		private DataSet tdsR1;

		// Token: 0x0400027C RID: 636
		private DataSet tdsR3;

		// Token: 0x0400027D RID: 637
		private DataSet tdsR8;

		// Token: 0x0400027E RID: 638
		private DataSet tdsNAV;

		// Token: 0x0400027F RID: 639
		private DataSet tdsHoldChart;

		// Token: 0x04000280 RID: 640
		private DataSet tdsTfex;

		// Token: 0x04000281 RID: 641
		private DataSet tdsFScore;

		// Token: 0x04000282 RID: 642
		private DataSet tdsBeta;

		// Token: 0x04000283 RID: 643
		private bool _isAreadyLoadNAV;

		// Token: 0x04000284 RID: 644
		private Timer tmReload;

		// Token: 0x04000285 RID: 645
		private string _reportType;

		// Token: 0x04000286 RID: 646
		private string _subReportType;

		// Token: 0x04000287 RID: 647
		private frmRiskManagement _frmRiskManage;

		// Token: 0x04000288 RID: 648
		private frmTradeJornal _frmTradeJournal;

		// Token: 0x04000289 RID: 649
		private string _navStartDate;

		// Token: 0x0400028A RID: 650
		private string _headerMessage;

		// Token: 0x0400028B RID: 651
		private int linesPrinted;

		// Token: 0x0400028C RID: 652
		private int _mcPos;

		// Token: 0x0400028D RID: 653
		private decimal _tfexTotMarketVal;

		// Token: 0x0400028E RID: 654
		private decimal _tfexUnrealSettle;

		// Token: 0x0400028F RID: 655
		private decimal _tfexUnrealCost;

		// Token: 0x04000290 RID: 656
		private decimal _tfexReal;

		// Token: 0x04000291 RID: 657
		private decimal _tfexCost;

		// Token: 0x04000292 RID: 658
		private Dictionary<decimal, long> summaryMaper;

		// Token: 0x04000293 RID: 659
		private int linesPrinted_TFEX;

		// Token: 0x04000294 RID: 660
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x04000295 RID: 661
		private IContainer components;

		// Token: 0x04000296 RID: 662
		private IntzaCustomGrid intzaCB;

		// Token: 0x04000297 RID: 663
		private ToolStrip tStripMain;

		// Token: 0x04000298 RID: 664
		private IntzaCustomGrid intzaCB_Freewill;

		// Token: 0x04000299 RID: 665
		private ucVolumeAtPrice wcGraphVolume;

		// Token: 0x0400029A RID: 666
		private ucVolumeAtPrice wcGraphVolumeSector;

		// Token: 0x0400029B RID: 667
		private Panel panelNav;

		// Token: 0x0400029C RID: 668
		private ChartWinControl chart;

		// Token: 0x0400029D RID: 669
		private ToolStrip tStripMenu;

		// Token: 0x0400029E RID: 670
		private ToolStripLabel toolStripLabel1;

		// Token: 0x0400029F RID: 671
		private ToolStripLabel tstbStartDate;

		// Token: 0x040002A0 RID: 672
		private ToolStripButton tsbtnSelStartDate;

		// Token: 0x040002A1 RID: 673
		private ToolStripLabel toolStripLabel2;

		// Token: 0x040002A2 RID: 674
		private ToolStripLabel tstbEndDate;

		// Token: 0x040002A3 RID: 675
		private ToolStripButton tsbtnSelEndDate;

		// Token: 0x040002A4 RID: 676
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x040002A5 RID: 677
		private ToolStripButton tsbtnReload;

		// Token: 0x040002A6 RID: 678
		private MonthCalendar monthCalendar1;

		// Token: 0x040002A7 RID: 679
		private SortGrid intzaReport;

		// Token: 0x040002A8 RID: 680
		private SortGrid intzaSumReport;

		// Token: 0x040002A9 RID: 681
		private IntzaCustomGrid intzaInfoHeader;

		// Token: 0x040002AA RID: 682
		private Panel panelSET;

		// Token: 0x040002AB RID: 683
		private Panel panelTFEXPort;

		// Token: 0x040002AC RID: 684
		private SortGrid sortGridTfex;

		// Token: 0x040002AD RID: 685
		private IntzaCustomGrid intzaCustBottTfex;

		// Token: 0x040002AE RID: 686
		private IntzaCustomGrid intzaCustHeadTfex;

		// Token: 0x040002AF RID: 687
		private ToolStrip tStripMainT;

		// Token: 0x040002B0 RID: 688
		private ToolStripButton tsbtnPrintT;

		// Token: 0x040002B1 RID: 689
		private SortGrid sortGridTfexSumm;

		// Token: 0x040002B2 RID: 690
		private Panel panelReportMenu;

		// Token: 0x040002B3 RID: 691
		private ToolStrip toolStrip1;

		// Token: 0x040002B4 RID: 692
		private ToolStripLabel tslbStock;

		// Token: 0x040002B5 RID: 693
		private ToolStripTextBox tstbStock2;

		// Token: 0x040002B6 RID: 694
		private ToolStripButton tsbtnClearStock;

		// Token: 0x040002B7 RID: 695
		private ToolStripComboBox tsCbMainSelect;

		// Token: 0x040002B8 RID: 696
		private ToolStripComboBox tsCbSubSelect;

		// Token: 0x040002B9 RID: 697
		private ToolStripButton tsbtnPortManHelp;

		// Token: 0x040002BA RID: 698
		private Panel panelNavAdjust;

		// Token: 0x040002BB RID: 699
		private Label lbNavAdjDate;

		// Token: 0x040002BC RID: 700
		private TextBox tbNavAdjAmount;

		// Token: 0x040002BD RID: 701
		private Label lbNavAdjAmount;

		// Token: 0x040002BE RID: 702
		private RadioButton rbNavAdjWithdraw;

		// Token: 0x040002BF RID: 703
		private RadioButton rbNavAdjDeposit;

		// Token: 0x040002C0 RID: 704
		private Label lbNavAdjLabel1;

		// Token: 0x040002C1 RID: 705
		private Button btnNavAdjCancel;

		// Token: 0x040002C2 RID: 706
		private Button btnNavAdjOk;

		// Token: 0x040002C3 RID: 707
		private DateTimePicker dateTimePicker1;

		// Token: 0x040002C4 RID: 708
		private ToolStripButton tsbtnNavAdj;

		// Token: 0x040002C5 RID: 709
		private ToolStripComboBox tsCbTFexMainSelect;

		// Token: 0x040002C6 RID: 710
		private ToolStripComboBox tsCbTFexSubSelect;

		// Token: 0x040002C7 RID: 711
		private ToolStripButton tsbtnPrint;

		// Token: 0x0200005C RID: 92
		public struct RecViewCustomerConfirmSummary
		{
			// Token: 0x040002C8 RID: 712
			public string Side;

			// Token: 0x040002C9 RID: 713
			public string Stock;

			// Token: 0x040002CA RID: 714
			public string TTF;

			// Token: 0x040002CB RID: 715
			public long Volume;

			// Token: 0x040002CC RID: 716
			public decimal Price;

			// Token: 0x040002CD RID: 717
			public decimal Amount;

			// Token: 0x040002CE RID: 718
			public decimal CommVat;

			// Token: 0x040002CF RID: 719
			public decimal NetAmnt;
		}

		// Token: 0x0200005D RID: 93
		public struct RecViewCustomerSummary
		{
			// Token: 0x040002D0 RID: 720
			public long order_number;

			// Token: 0x040002D1 RID: 721
			public string side;

			// Token: 0x040002D2 RID: 722
			public string stock;

			// Token: 0x040002D3 RID: 723
			public string trustee_id;

			// Token: 0x040002D4 RID: 724
			public long volume;

			// Token: 0x040002D5 RID: 725
			public string price;

			// Token: 0x040002D6 RID: 726
			public decimal matched_value;

			// Token: 0x040002D7 RID: 727
			public string status;

			// Token: 0x040002D8 RID: 728
			public long deal_volume;

			// Token: 0x040002D9 RID: 729
			public decimal deal_price;
		}

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000480 RID: 1152
		private delegate void StartReloadTimerCallBack(int interval, bool isRequest);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000484 RID: 1156
		private delegate void ShowPrintDailogCallBack();

		// Token: 0x02000060 RID: 96
		private class VCItem
		{
			// Token: 0x06000487 RID: 1159 RVA: 0x0005F018 File Offset: 0x0005D418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public VCItem(double value, double profit) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.value = value;
				this.profit = profit;
			}

			// Token: 0x040002DA RID: 730
			public double value;

			// Token: 0x040002DB RID: 731
			public double profit;
		}

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000489 RID: 1161
		private delegate void ShowPrintDailog_TFEX_CallBack();

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600048D RID: 1165
		private delegate void ShowMessageFormCallBack(string message);
	}
}
