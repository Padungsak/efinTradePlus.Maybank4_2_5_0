using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.Properties;
using i2TradePlus.Templates;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus.FixForm
{
	// Token: 0x020000B2 RID: 178
	public class frmStockRanking : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0009FBC0 File Offset: 0x0009DFC0
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x0009FBEC File Offset: 0x0009DFEC
		public string CurrentPage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.currentPage;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.currentPage = value;
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0009FC04 File Offset: 0x0009E004
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmStockRanking() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.currentPage = "Top Active";
			this.maxRecordTopActive = 45;
			this.maxTopTopActive = 40;
			this.recDataRealTimeTopActive = default(frmStockRanking.RecordData);
			this.sortTypeTopActive = SortType.None;
			this.sortByNameTopActive = string.Empty;
			this.marketIdTopActive = "S";
			this.activeGroupTypeTopActive = frmStockRanking.ActiveGroupTypes.None;
			this.bgwTopActiveLoadData = null;
			this.dsTopActive = null;
			this.maxRecordProjectedOpenPrice = 45;
			this.marketIdProjectedOpenPrice = "S";
			this.boardTypeProjectedOpenPrice = frmStockRanking.BoardTypes.M;
			this.compareModeProjectedOpenPrice = "G";
			this.bgwProjectedOpenPriceLoadData = null;
			this.dsProjectedOpenPrice = null;
			this.maxRecordProjectedClosePrice = 45;
			this.marketIdProjectedClosePrice = "S";
			this.boardTypeProjectedClosePrice = frmStockRanking.BoardTypes.M;
			this.compareModeProjectedClosePrice = "G";
			this.bgwProjectedClosePriceLoadData = null;
			this.dsProjectedClosePrice = null;
			this.marketIdBestOpenPrice = "S";
			this.maxRecordBestOpenPrice = 45;
			this.boardTypeBestOpenPrice = frmStockRanking.BoardTypes.M;
			this.openSessionBestOpenPrice = 1;
			this.compareModeBestOpenPrice = "G";
			this.bgwBestOpenPriceLoadData = null;
			this.dsBestOpenPrice = null;
			this.components = null;
			base..ctor();
			this.InitializeComponent();
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0009FD34 File Offset: 0x0009E134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmStockRanking(Dictionary<string, object> propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.currentPage = "Top Active";
			this.maxRecordTopActive = 45;
			this.maxTopTopActive = 40;
			this.recDataRealTimeTopActive = default(frmStockRanking.RecordData);
			this.sortTypeTopActive = SortType.None;
			this.sortByNameTopActive = string.Empty;
			this.marketIdTopActive = "S";
			this.activeGroupTypeTopActive = frmStockRanking.ActiveGroupTypes.None;
			this.bgwTopActiveLoadData = null;
			this.dsTopActive = null;
			this.maxRecordProjectedOpenPrice = 45;
			this.marketIdProjectedOpenPrice = "S";
			this.boardTypeProjectedOpenPrice = frmStockRanking.BoardTypes.M;
			this.compareModeProjectedOpenPrice = "G";
			this.bgwProjectedOpenPriceLoadData = null;
			this.dsProjectedOpenPrice = null;
			this.maxRecordProjectedClosePrice = 45;
			this.marketIdProjectedClosePrice = "S";
			this.boardTypeProjectedClosePrice = frmStockRanking.BoardTypes.M;
			this.compareModeProjectedClosePrice = "G";
			this.bgwProjectedClosePriceLoadData = null;
			this.dsProjectedClosePrice = null;
			this.marketIdBestOpenPrice = "S";
			this.maxRecordBestOpenPrice = 45;
			this.boardTypeBestOpenPrice = frmStockRanking.BoardTypes.M;
			this.openSessionBestOpenPrice = 1;
			this.compareModeBestOpenPrice = "G";
			this.bgwBestOpenPriceLoadData = null;
			this.dsBestOpenPrice = null;
			this.components = null;
			base..ctor(propertiesValue);
			this.Init();
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0009FE68 File Offset: 0x0009E268
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.InitializeComponent();
			try
			{
				this.bgwTopActiveLoadData = new BackgroundWorker();
				this.bgwTopActiveLoadData.WorkerReportsProgress = true;
				this.bgwTopActiveLoadData.DoWork += new DoWorkEventHandler(this.bgwTopActiveLoadData_DoWork);
				this.bgwTopActiveLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwTopActiveLoadData_RunWorkerCompleted);
				this.bgwProjectedOpenPriceLoadData = new BackgroundWorker();
				this.bgwProjectedOpenPriceLoadData.DoWork += new DoWorkEventHandler(this.bgwProjectedOpenPriceLoadData_DoWork);
				this.bgwProjectedOpenPriceLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwProjectedOpenPriceLoadData_RunWorkerCompleted);
				this.bgwProjectedClosePriceLoadData = new BackgroundWorker();
				this.bgwProjectedClosePriceLoadData.DoWork += new DoWorkEventHandler(this.bgwProjectedClosePriceLoadData_DoWork);
				this.bgwProjectedClosePriceLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwProjectedClosePriceLoadData_RunWorkerCompleted);
				this.bgwBestOpenPriceLoadData = new BackgroundWorker();
				this.bgwBestOpenPriceLoadData.DoWork += new DoWorkEventHandler(this.bgwBestOpenPriceLoadData_DoWork);
				this.bgwBestOpenPriceLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwBestOpenPriceLoadData_RunWorkerCompleted);
				this.tscbSelection.Items.Clear();
				this.tscbSelection.Items.Add("Top Active");
				this.tscbSelection.Items.Add("Best Projected Open");
				this.tscbSelection.Items.Add("Best Projected Close");
				this.tscbSelection.Items.Add("Best Open Price");
			}
			catch (Exception ex)
			{
				this.ShowError("StockRanking.Init()", ex);
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000A0028 File Offset: 0x0009E428
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockRanking_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				this.SetActivePage();
				this.SetResize(true);
				base.Show();
				base.OpenedForm();
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000A007C File Offset: 0x0009E47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockRanking_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.activeGroupTypeTopActive == frmStockRanking.ActiveGroupTypes.None)
				{
					this.activeGroupTypeTopActive = frmStockRanking.ActiveGroupTypes.MostActive_Main;
				}
				this.ReloadDataPage(this.currentPage);
			}
			catch (Exception ex)
			{
				this.ShowError("frmStockRanking_IDoLoadData", ex);
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000A00EC File Offset: 0x0009E4EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockRanking_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged | this.IsHeightChanged);
				base.Show();
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000A0134 File Offset: 0x0009E534
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockRanking_IDoFontChanged()
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

		// Token: 0x06000843 RID: 2115 RVA: 0x000A0168 File Offset: 0x0009E568
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockRanking_IDoCustomSizeChanged()
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

		// Token: 0x06000844 RID: 2116 RVA: 0x000A01A8 File Offset: 0x0009E5A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetResize(bool isChanged)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (isChanged)
				{
					int height = this.tStripMenu.Height;
					Console.WriteLine("tH=" + height);
					this.intzaTopActive.SetBounds(0, height, base.ClientSize.Width, base.ClientSize.Height - height + 1);
					this.intzaBestOpen.SetBounds(0, height, base.ClientSize.Width, base.ClientSize.Height - height + 1);
					this.intzaProjectedClose.SetBounds(0, height, base.ClientSize.Width, base.ClientSize.Height - height + 1);
					this.intzaProjectedOpen.SetBounds(0, height, base.ClientSize.Width, base.ClientSize.Height - height + 1);
					this.tscbTopActiveType.Width = (int)base.CreateGraphics().MeasureString("Most Active - Foreign", this.tscbTopActiveType.Font).Width + 25;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000A0318 File Offset: 0x0009E718
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CallPage(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.currentPage = this.tscbSelection.Text;
				this.SetActivePage();
				this.ReloadDataPage(this.currentPage);
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000A0368 File Offset: 0x0009E768
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscmbStock_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000A03A4 File Offset: 0x0009E7A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwTopActiveLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				base.IsLoadingData = true;
				if (this.dsTopActive == null)
				{
					this.dsTopActive = new DataSet();
				}
				else
				{
					this.dsTopActive.Clear();
				}
				string text = string.Empty;
				try
				{
					switch (this.activeGroupTypeTopActive)
					{
					case frmStockRanking.ActiveGroupTypes.MostActive_Main:
						text = ApplicationInfo.WebService.TopActive("MA", "M", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					case frmStockRanking.ActiveGroupTypes.MostActive_Foreign:
						text = ApplicationInfo.WebService.TopActive("MA", "F", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					case frmStockRanking.ActiveGroupTypes.MostActive_BigLot:
						text = ApplicationInfo.WebService.TopActive("MB", "M", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					case frmStockRanking.ActiveGroupTypes.Gainer_Main:
						text = ApplicationInfo.WebService.TopActive("GN", "M", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					case frmStockRanking.ActiveGroupTypes.Gainer_Foreign:
						text = ApplicationInfo.WebService.TopActive("GN", "F", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					case frmStockRanking.ActiveGroupTypes.Loser_Main:
						text = ApplicationInfo.WebService.TopActive("LN", "M", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					case frmStockRanking.ActiveGroupTypes.Loser_Foreign:
						text = ApplicationInfo.WebService.TopActive("LN", "F", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					case frmStockRanking.ActiveGroupTypes.MostSwing_Main:
						text = ApplicationInfo.WebService.TopActive("SW", "M", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					case frmStockRanking.ActiveGroupTypes.MostSwing_Foreign:
						text = ApplicationInfo.WebService.TopActive("SW", "F", this.marketIdTopActive, this.maxRecordTopActive);
						break;
					default:
						return;
					}
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.dsTopActive);
					}
				}
				catch (Exception ex)
				{
					this.ShowError("TopActiveRequestWebData", ex);
				}
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000A05F8 File Offset: 0x0009E9F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwTopActiveLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					this.TopActiveUpdateToControl();
					this.dsTopActive.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwTopActiveLoadData_RunWorkerCompleted", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000A0670 File Offset: 0x0009EA70
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwProjectedOpenPriceLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = string.Empty;
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					base.IsLoadingData = true;
					if (this.dsProjectedOpenPrice == null)
					{
						this.dsProjectedOpenPrice = new DataSet();
					}
					else
					{
						this.dsProjectedOpenPrice.Clear();
					}
					text = ApplicationInfo.WebService.BestProjected(this.boardTypeProjectedOpenPrice.ToString(), this.compareModeProjectedOpenPrice, "O", "S", 1, this.maxRecordProjectedOpenPrice);
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.dsProjectedOpenPrice);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwProjectedOpenPriceLoadData_DoWork", ex);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000A0758 File Offset: 0x0009EB58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwProjectedOpenPriceLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					this.BestPOpen_UpdateToControl();
					this.dsProjectedOpenPrice.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwProjectedOpenPriceLoadData_RunWorkerCompleted", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000A07D0 File Offset: 0x0009EBD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwProjectedClosePriceLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					if (this.dsProjectedClosePrice == null)
					{
						this.dsProjectedClosePrice = new DataSet();
					}
					else
					{
						this.dsProjectedClosePrice.Clear();
					}
					base.IsLoadingData = true;
					string text = string.Empty;
					text = ApplicationInfo.WebService.BestProjected(this.boardTypeProjectedClosePrice.ToString(), this.compareModeProjectedClosePrice, "C", "S", 1, this.maxRecordProjectedClosePrice);
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.dsProjectedClosePrice);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestProjectedClosePriceRequestWebData", ex);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000A08B4 File Offset: 0x0009ECB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwProjectedClosePriceLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					this.BestPClose_UpdateToControl();
					this.dsProjectedClosePrice.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwProjectedClosePriceLoadData_RunWorkerCompleted", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000A092C File Offset: 0x0009ED2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwBestOpenPriceLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				base.IsLoadingData = true;
				string text = string.Empty;
				try
				{
					if (this.dsBestOpenPrice == null)
					{
						this.dsBestOpenPrice = new DataSet();
					}
					else
					{
						this.dsBestOpenPrice.Clear();
					}
					text = ApplicationInfo.WebService.BestOpenPrice(this.boardTypeBestOpenPrice.ToString(), this.compareModeBestOpenPrice, this.marketIdBestOpenPrice, this.openSessionBestOpenPrice, 1, this.maxRecordBestOpenPrice);
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.dsBestOpenPrice);
					}
				}
				catch (Exception ex)
				{
					this.ShowError("BestOpenPriceRequestWebData", ex);
				}
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000A0A14 File Offset: 0x0009EE14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwBestOpenPriceLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					this.BestOpen_UpdateToControl();
					this.dsBestOpenPrice.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwBestOpenPriceLoadData_RunWorkerCompleted", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000A0A8C File Offset: 0x0009EE8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Dictionary<string, object> DoPackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.PropertiesValue.Clear();
			return base.PropertiesValue;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000A0AC4 File Offset: 0x0009EEC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DoUnpackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000A0AD8 File Offset: 0x0009EED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadDataPage(string page)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (page == "Top Active")
			{
				this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.MostActive_Main);
			}
			else if (page == "Best Projected Open")
			{
				this.BestPOpen_ReloadData();
			}
			else if (page == "Best Projected Close")
			{
				this.BestPClose_ReloadData();
			}
			else if (page == "Best Open Price")
			{
				this.BestOpen_ReloadData();
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000A0B7C File Offset: 0x0009EF7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TopActiveSetVisibleColumn(string columnName, bool visible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.intzaTopActive.GetColumn(columnName).Visible = visible;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000A0BA0 File Offset: 0x0009EFA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TopActiveReloadData(frmStockRanking.ActiveGroupTypes activeGroupType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.IsLoadingData = true;
			this.activeGroupTypeTopActive = activeGroupType;
			this.TopActiveUpdateUIReloadData(activeGroupType);
			if (!this.bgwTopActiveLoadData.IsBusy)
			{
				this.bgwTopActiveLoadData.RunWorkerAsync();
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000A0BF4 File Offset: 0x0009EFF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TopActiveUpdateUIReloadData(frmStockRanking.ActiveGroupTypes activeGroupType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmStockRanking.TopActiveUpdateUIReloadDataCallback(this.TopActiveUpdateUIReloadData), new object[]
				{
					activeGroupType
				});
			}
			else
			{
				try
				{
					this.intzaTopActive.GetColumn("value").Text = "Value";
					this.intzaTopActive.GetColumn("volume").Text = "Volume";
					this.intzaTopActive.GetColumn("avg").Text = "Avg";
					switch (activeGroupType)
					{
					case frmStockRanking.ActiveGroupTypes.MostActive_Main:
					case frmStockRanking.ActiveGroupTypes.MostActive_Foreign:
						this.sortTypeTopActive = SortType.Desc;
						this.sortByNameTopActive = "value";
						break;
					case frmStockRanking.ActiveGroupTypes.MostActive_BigLot:
						this.sortTypeTopActive = SortType.Desc;
						this.sortByNameTopActive = "value";
						this.intzaTopActive.GetColumn("value").Text = "BValue";
						this.intzaTopActive.GetColumn("volume").Text = "BVolume";
						this.intzaTopActive.GetColumn("avg").Text = "BAvg";
						break;
					case frmStockRanking.ActiveGroupTypes.Gainer_Main:
					case frmStockRanking.ActiveGroupTypes.Gainer_Foreign:
						this.sortTypeTopActive = SortType.Desc;
						this.sortByNameTopActive = "pchg";
						break;
					case frmStockRanking.ActiveGroupTypes.Loser_Main:
					case frmStockRanking.ActiveGroupTypes.Loser_Foreign:
						this.sortTypeTopActive = SortType.Asc;
						this.sortByNameTopActive = "pchg";
						break;
					case frmStockRanking.ActiveGroupTypes.MostSwing_Main:
					case frmStockRanking.ActiveGroupTypes.MostSwing_Foreign:
						this.sortTypeTopActive = SortType.Desc;
						this.sortByNameTopActive = "pswing";
						break;
					default:
						return;
					}
					switch (activeGroupType)
					{
					case frmStockRanking.ActiveGroupTypes.MostActive_Main:
						this.tscbTopActiveType.Text = "Most Active - Main";
						break;
					case frmStockRanking.ActiveGroupTypes.MostActive_Foreign:
						this.tscbTopActiveType.Text = "Most Active - Foreign";
						break;
					case frmStockRanking.ActiveGroupTypes.MostActive_BigLot:
						this.tscbTopActiveType.Text = "Biglot";
						break;
					case frmStockRanking.ActiveGroupTypes.Gainer_Main:
						this.tscbTopActiveType.Text = "Gainer - Main";
						break;
					case frmStockRanking.ActiveGroupTypes.Gainer_Foreign:
						this.tscbTopActiveType.Text = "Gainer - Foreign";
						break;
					case frmStockRanking.ActiveGroupTypes.Loser_Main:
						this.tscbTopActiveType.Text = "Loser - Main";
						break;
					case frmStockRanking.ActiveGroupTypes.Loser_Foreign:
						this.tscbTopActiveType.Text = "Loser - Foreign";
						break;
					case frmStockRanking.ActiveGroupTypes.MostSwing_Main:
						this.tscbTopActiveType.Text = "Most Swing - Main";
						break;
					case frmStockRanking.ActiveGroupTypes.MostSwing_Foreign:
						this.tscbTopActiveType.Text = "Most Swing - Foreign";
						break;
					}
					if (this.marketIdTopActive == "S")
					{
						this.tscbTopActiveMkt.Text = "SET";
					}
					else
					{
						this.tscbTopActiveMkt.Text = "MAI";
					}
					this.intzaTopActive.ClearAllText();
					this.intzaTopActive.SortColumnName = this.sortByNameTopActive;
					this.intzaTopActive.Invalidate();
				}
				catch (Exception ex)
				{
					this.ShowError("TopActiveUpdateUIReloadData", ex);
				}
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000A0F38 File Offset: 0x0009F338
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TopActiveUpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaTopActive.BeginUpdate();
				this.intzaTopActive.ClearAllText();
				if (this.dsTopActive.Tables.Count > 0 && this.dsTopActive.Tables.Contains("security_info_stat"))
				{
					int num = 0;
					foreach (DataRow dataRow in this.dsTopActive.Tables["security_info_stat"].Rows)
					{
						int num2;
						int.TryParse(dataRow["security_number"].ToString(), out num2);
						if (num2 > 0)
						{
							frmStockRanking.RecordData recordData = default(frmStockRanking.RecordData);
							StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[num2];
							int.TryParse(dataRow["security_number"].ToString(), out recordData.StockNumber);
							recordData.DisplayFlag = dataRow["display_flag"].ToString();
							long.TryParse(dataRow["accvolume"].ToString(), out recordData.AccVolume);
							decimal.TryParse(dataRow["accvalue"].ToString(), out recordData.AccValue);
							decimal.TryParse(dataRow["high_price"].ToString(), out recordData.HighPrice);
							decimal.TryParse(dataRow["low_price"].ToString(), out recordData.LowPrice);
							decimal.TryParse(dataRow["last_sale_price"].ToString(), out recordData.LastPrice);
							recordData.ChangePrice = stockInformation.ChangePrice;
							recordData.ChangePricePct = stockInformation.ChangePricePct;
							decimal.TryParse(dataRow["swing"].ToString(), out recordData.Swing);
							decimal.TryParse(dataRow["swing_pct"].ToString(), out recordData.SwingPct);
							int.TryParse(dataRow["deals"].ToString(), out recordData.Deals);
							recordData.Prior = stockInformation.PriorPrice;
							recordData.Stock = stockInformation.Symbol;
							this.TopActiveUpdateToGrid(num, recordData, stockInformation);
						}
						num++;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("TopActiveUpdateToControl", ex);
			}
			finally
			{
				this.intzaTopActive.Redraw();
				if (!this.intzaTopActive.Visible)
				{
					this.intzaTopActive.Show();
				}
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000A125C File Offset: 0x0009F65C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TopActiveUpdateToGrid(int rowIndex, frmStockRanking.RecordData recordData, StockList.StockInformation realStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaTopActive.InvokeRequired)
			{
				this.intzaTopActive.Invoke(new frmStockRanking.TopActiveUpdateToGridCallBack(this.TopActiveUpdateToGrid), new object[]
				{
					rowIndex,
					recordData,
					realStockInfo
				});
			}
			else
			{
				try
				{
					RecordItem recordItem;
					if (rowIndex >= 0)
					{
						recordItem = this.intzaTopActive.Records(rowIndex);
					}
					else
					{
						recordItem = this.intzaTopActive.Find("stock", recordData.Stock);
						if (recordItem == null)
						{
							recordItem = this.intzaTopActive.Records(this.maxRecordTopActive - 1);
						}
					}
					recordItem.Fields("stock").Text = recordData.Stock;
					recordItem.Fields("stock").Tag = recordData.DisplayFlag;
					recordItem.Fields("deals").Text = recordData.Deals;
					recordItem.Fields("volume").Text = recordData.AccVolume;
					recordItem.Fields("value").Text = recordData.AccValue;
					decimal num = 0m;
					if (recordData.AccVolume > 0L)
					{
						num = Math.Round(recordData.AccValue / recordData.AccVolume, 2);
					}
					recordItem.Fields("avg").Text = num;
					recordItem.Fields("high").Text = recordData.HighPrice;
					recordItem.Fields("low").Text = recordData.LowPrice;
					recordItem.Fields("last").Text = recordData.LastPrice;
					recordItem.Fields("swing").Text = recordData.Swing;
					recordItem.Fields("pswing").Text = recordData.SwingPct;
					recordItem.Fields("chg").Text = recordData.ChangePrice;
					recordItem.Fields("pchg").Text = recordData.ChangePricePct;
					Color fontColor = Utilities.ComparePriceCFColor(recordData.LastPrice, realStockInfo);
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("deals").FontColor = fontColor;
					recordItem.Fields("volume").FontColor = fontColor;
					recordItem.Fields("value").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					recordItem.Fields("chg").FontColor = fontColor;
					recordItem.Fields("pchg").FontColor = fontColor;
					recordItem.Fields("swing").FontColor = fontColor;
					recordItem.Fields("pswing").FontColor = fontColor;
					recordItem.Fields("avg").FontColor = Utilities.ComparePriceCFColor(num, realStockInfo);
					recordItem.Fields("high").FontColor = Utilities.ComparePriceCFColor(recordData.HighPrice, realStockInfo);
					recordItem.Fields("low").FontColor = Utilities.ComparePriceCFColor(recordData.LowPrice, realStockInfo);
				}
				catch (Exception ex)
				{
					this.ShowError("TopActiveUpdateToGrid", ex);
				}
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000A1618 File Offset: 0x0009FA18
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool TopActiveVerifyBoard(StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = false;
			try
			{
				if (realtimeStockInfo.MarketId == this.marketIdTopActive)
				{
					switch (this.activeGroupTypeTopActive)
					{
					case frmStockRanking.ActiveGroupTypes.MostActive_Main:
					case frmStockRanking.ActiveGroupTypes.Gainer_Main:
					case frmStockRanking.ActiveGroupTypes.Loser_Main:
					case frmStockRanking.ActiveGroupTypes.MostSwing_Main:
						if (realtimeStockInfo.StockBoard == "M")
						{
							result = true;
						}
						goto IL_AD;
					case frmStockRanking.ActiveGroupTypes.MostActive_BigLot:
						result = true;
						goto IL_AD;
					}
					if (realtimeStockInfo.StockBoard == "F")
					{
						result = true;
					}
					IL_AD:;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("TopActiveVerifyBoard", ex);
			}
			return result;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000A1708 File Offset: 0x0009FB08
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TopActiveUpdateRealTimes(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmStockRanking.TopActiveUpdateRealTimesCallBack(this.TopActiveUpdateRealTimes), new object[]
				{
					message,
					realtimeStockInfo
				});
			}
			else
			{
				try
				{
					if (this.activeGroupTypeTopActive == frmStockRanking.ActiveGroupTypes.MostActive_BigLot)
					{
						if (message.MessageType != "PD")
						{
							return;
						}
					}
					else if (!this.TopActiveVerifyBoard(realtimeStockInfo))
					{
						return;
					}
					this.recDataRealTimeTopActive.Stock = "";
					this.recDataRealTimeTopActive.StockNumber = 0;
					this.recDataRealTimeTopActive.AccVolume = 0L;
					this.recDataRealTimeTopActive.AccValue = 0m;
					this.recDataRealTimeTopActive.LastPrice = 0m;
					this.recDataRealTimeTopActive.HighPrice = 0m;
					this.recDataRealTimeTopActive.LowPrice = 0m;
					this.recDataRealTimeTopActive.Deals = 0;
					this.recDataRealTimeTopActive.ChangePrice = 0m;
					this.recDataRealTimeTopActive.ChangePricePct = 0m;
					this.recDataRealTimeTopActive.Swing = 0m;
					this.recDataRealTimeTopActive.SwingPct = 0m;
					this.recDataRealTimeTopActive.DisplayFlag = "";
					this.recDataRealTimeTopActive.Prior = 0m;
					if (message.MessageType == "L+")
					{
						LSAccumulate lSAccumulate = (LSAccumulate)message;
						this.recDataRealTimeTopActive.StockNumber = lSAccumulate.SecurityNumber;
						this.recDataRealTimeTopActive.AccVolume = lSAccumulate.AccVolume * (long)realtimeStockInfo.BoardLot;
						this.recDataRealTimeTopActive.AccValue = lSAccumulate.AccValue;
						this.recDataRealTimeTopActive.LastPrice = lSAccumulate.LastPrice;
						this.recDataRealTimeTopActive.HighPrice = realtimeStockInfo.HighPrice;
						this.recDataRealTimeTopActive.LowPrice = realtimeStockInfo.LowPrice;
						this.recDataRealTimeTopActive.Deals = lSAccumulate.DealInMain;
					}
					else if (message.MessageType == "PD")
					{
						PDMessage pDMessage = (PDMessage)message;
						this.recDataRealTimeTopActive.StockNumber = pDMessage.SecurityNumber;
						this.recDataRealTimeTopActive.AccVolume = pDMessage.BiglotAccVolume;
						this.recDataRealTimeTopActive.AccValue = pDMessage.BiglotAccValue;
						this.recDataRealTimeTopActive.LastPrice = pDMessage.LastPrice;
						this.recDataRealTimeTopActive.HighPrice = pDMessage.HighPrice;
						this.recDataRealTimeTopActive.LowPrice = pDMessage.LowPrice;
						this.recDataRealTimeTopActive.Deals = pDMessage.BiglotDeals;
					}
					this.recDataRealTimeTopActive.DisplayFlag = realtimeStockInfo.DisplayFlag;
					this.recDataRealTimeTopActive.Stock = realtimeStockInfo.Symbol;
					this.recDataRealTimeTopActive.Prior = realtimeStockInfo.PriorPrice;
					if (realtimeStockInfo.PriorPrice > 0m && this.recDataRealTimeTopActive.LastPrice > 0m)
					{
						this.recDataRealTimeTopActive.ChangePrice = this.recDataRealTimeTopActive.LastPrice - realtimeStockInfo.PriorPrice;
						this.recDataRealTimeTopActive.ChangePricePct = this.recDataRealTimeTopActive.ChangePrice / realtimeStockInfo.PriorPrice * 100m;
					}
					if (realtimeStockInfo.PriorPrice > 0m && this.recDataRealTimeTopActive.LowPrice > 0m && this.recDataRealTimeTopActive.HighPrice > 0m)
					{
						this.recDataRealTimeTopActive.Swing = this.recDataRealTimeTopActive.HighPrice - this.recDataRealTimeTopActive.LowPrice;
						this.recDataRealTimeTopActive.SwingPct = this.recDataRealTimeTopActive.Swing / realtimeStockInfo.PriorPrice * 100m;
					}
					int num = -1;
					switch (this.activeGroupTypeTopActive)
					{
					case frmStockRanking.ActiveGroupTypes.MostActive_Main:
					case frmStockRanking.ActiveGroupTypes.MostActive_Foreign:
					{
						decimal d;
						if (decimal.TryParse(this.intzaTopActive.Records(this.maxTopTopActive).Fields("value").Text.ToString(), out d))
						{
							if (this.recDataRealTimeTopActive.AccValue <= d)
							{
								return;
							}
						}
						break;
					}
					case frmStockRanking.ActiveGroupTypes.Gainer_Main:
					case frmStockRanking.ActiveGroupTypes.Gainer_Foreign:
						num = this.intzaTopActive.FindIndex("stock", realtimeStockInfo.Symbol);
						if (num == -1)
						{
							if (this.recDataRealTimeTopActive.ChangePrice <= 0m)
							{
								return;
							}
							decimal d2 = 0m;
							if (decimal.TryParse(this.intzaTopActive.Records(this.maxTopTopActive).Fields("pchg").Text.ToString(), out d2))
							{
								if (this.recDataRealTimeTopActive.ChangePricePct <= d2)
								{
									return;
								}
							}
						}
						else if (this.recDataRealTimeTopActive.ChangePricePct <= 0m)
						{
							this.TopActive_ClearRecord(num);
							return;
						}
						break;
					case frmStockRanking.ActiveGroupTypes.Loser_Main:
					case frmStockRanking.ActiveGroupTypes.Loser_Foreign:
						num = this.intzaTopActive.FindIndex("stock", realtimeStockInfo.Symbol);
						if (num == -1)
						{
							if (this.recDataRealTimeTopActive.ChangePricePct >= 0m)
							{
								return;
							}
							decimal d2 = 0m;
							if (decimal.TryParse(this.intzaTopActive.Records(this.maxTopTopActive).Fields("pchg").Text.ToString(), out d2))
							{
								if (this.recDataRealTimeTopActive.ChangePricePct >= d2)
								{
									return;
								}
							}
						}
						else if (this.recDataRealTimeTopActive.ChangePricePct >= 0m)
						{
							this.TopActive_ClearRecord(num);
							return;
						}
						break;
					case frmStockRanking.ActiveGroupTypes.MostSwing_Main:
					case frmStockRanking.ActiveGroupTypes.MostSwing_Foreign:
						num = this.intzaTopActive.FindIndex("stock", realtimeStockInfo.Symbol);
						if (num == -1)
						{
							if (this.recDataRealTimeTopActive.SwingPct <= 0m)
							{
								return;
							}
							decimal d3;
							if (decimal.TryParse(this.intzaTopActive.Records(this.maxTopTopActive).Fields("pswing").Text.ToString(), out d3))
							{
								if (this.recDataRealTimeTopActive.SwingPct <= d3)
								{
									return;
								}
							}
						}
						else if (this.recDataRealTimeTopActive.SwingPct <= 0m)
						{
							this.TopActive_ClearRecord(num);
							return;
						}
						break;
					}
					this.TopActiveUpdateToGrid(num, this.recDataRealTimeTopActive, realtimeStockInfo);
					this.intzaTopActive.Sort(this.sortByNameTopActive, this.sortTypeTopActive);
					if (base.IsAllowRender)
					{
						this.intzaTopActive.Redraw();
					}
				}
				catch (Exception ex)
				{
					this.ShowError("TopActiveUpdateRealTimes", ex);
				}
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000A1F3C File Offset: 0x000A033C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TopActive_ClearRecord(int rowIndex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaTopActive.ClearAllTextByRow(rowIndex);
				this.intzaTopActive.Sort(this.sortByNameTopActive, this.sortTypeTopActive);
				if (base.IsAllowRender)
				{
					this.intzaTopActive.EndUpdate();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("TopActive_ClearRecord", ex);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000A1FC8 File Offset: 0x000A03C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestPOpen_ReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.IsLoadingData = true;
				this.BestPOpen_SetHeaderGrid();
				if (this.boardTypeProjectedOpenPrice == frmStockRanking.BoardTypes.M)
				{
					this.tscbBoard.Text = "Main";
				}
				else
				{
					this.tscbBoard.Text = "Foreign";
				}
				if (this.compareModeProjectedOpenPrice == "G")
				{
					this.tscbSort.Text = "Gainer";
				}
				else
				{
					this.tscbSort.Text = "Loser";
				}
				this.intzaProjectedOpen.ClearAllText();
				this.intzaProjectedOpen.Redraw();
				if (!this.bgwProjectedOpenPriceLoadData.IsBusy)
				{
					this.bgwProjectedOpenPriceLoadData.RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestProjectedOpenPriceReloadData", ex);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000A20D8 File Offset: 0x000A04D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestPOpen_UpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaProjectedOpen.BeginUpdate();
				this.intzaProjectedOpen.ClearAllText();
				if (this.dsProjectedOpenPrice.Tables.Count > 0 && this.dsProjectedOpenPrice.Tables.Contains("security_info_stat"))
				{
					for (int i = 0; i < this.dsProjectedOpenPrice.Tables["security_info_stat"].Rows.Count; i++)
					{
						DataRow dataRow = this.dsProjectedOpenPrice.Tables["security_info_stat"].Rows[i];
						int num;
						int.TryParse(dataRow["security_number"].ToString(), out num);
						if (num > 0)
						{
							StockList.StockInformation stockInfo = ApplicationInfo.StockInfo[num];
							decimal avg = 0m;
							long num2;
							long.TryParse(dataRow["accvolume"].ToString(), out num2);
							if (num2 > 0L)
							{
								decimal d;
								decimal.TryParse(dataRow["accvalue"].ToString(), out d);
								avg = Math.Round(d / num2, 2);
							}
							decimal poPrice;
							decimal.TryParse(dataRow["projected_open"].ToString(), out poPrice);
							decimal highPrice;
							decimal.TryParse(dataRow["high_price"].ToString(), out highPrice);
							decimal lowPrice;
							decimal.TryParse(dataRow["low_price"].ToString(), out lowPrice);
							decimal priorOrBkCls;
							if (ApplicationInfo.MarketSession <= 1)
							{
								decimal.TryParse(dataRow["prior_close_price"].ToString(), out priorOrBkCls);
							}
							else
							{
								decimal.TryParse(dataRow["brkcls"].ToString(), out priorOrBkCls);
							}
							this.BestPOpen_UpdateByPO(i, poPrice, priorOrBkCls, stockInfo);
							decimal openPrice = -1m;
							long openVolume = 0L;
							if (ApplicationInfo.MarketSession <= 1)
							{
								decimal.TryParse(dataRow["open_price1"].ToString(), out openPrice);
								long.TryParse(dataRow["open_volume1"].ToString(), out openVolume);
							}
							else if (ApplicationInfo.MarketSession == 2)
							{
								decimal.TryParse(dataRow["open_price2"].ToString(), out openPrice);
								long.TryParse(dataRow["open_volume2"].ToString(), out openVolume);
							}
							this.BestPOpen_UpdateByLS(this.intzaProjectedOpen.Records(i), avg, highPrice, lowPrice, openPrice, openVolume, stockInfo);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestProjectedOpenPriceUpdateToControl", ex);
			}
			this.intzaProjectedOpen.Redraw();
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000A23DC File Offset: 0x000A07DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestPOpen_UpdateByLS(RecordItem rec, decimal avg, decimal highPrice, decimal lowPrice, decimal openPrice, long openVolume, StockList.StockInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (rec != null)
				{
					rec.Fields("avg").Text = avg;
					rec.Fields("high").Text = highPrice;
					rec.Fields("low").Text = lowPrice;
					rec.Fields("avg").FontColor = Utilities.ComparePriceCFColor(avg, stockInfo);
					rec.Fields("high").FontColor = Utilities.ComparePriceCFColor(highPrice, stockInfo);
					rec.Fields("low").FontColor = Utilities.ComparePriceCFColor(lowPrice, stockInfo);
					if (openPrice > -1m)
					{
						rec.Fields("ovolume1").Text = openVolume;
						rec.Fields("open1").Text = openPrice;
						Color fontColor = Utilities.ComparePriceCFColor(openPrice, stockInfo);
						rec.Fields("open1").FontColor = fontColor;
						rec.Fields("ovolume1").FontColor = fontColor;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestProjectedOpenPriceUpdateByLS", ex);
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000A2548 File Offset: 0x000A0948
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool BestPOpen_UpdateByPO(int rowIndex, decimal poPrice, decimal priorOrBkCls, StockList.StockInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool flag = true;
			bool result;
			try
			{
				if (rowIndex <= -1)
				{
					result = false;
					return result;
				}
				RecordItem recordItem = this.intzaProjectedOpen.Records(rowIndex);
				recordItem.Fields("stock").Text = stockInfo.Symbol;
				recordItem.Fields("stock").Tag = stockInfo.DisplayFlag;
				if (priorOrBkCls == -1m)
				{
					decimal.TryParse(recordItem.Fields("prior").Text.ToString(), out priorOrBkCls);
				}
				else
				{
					recordItem.Fields("prior").Text = priorOrBkCls;
				}
				decimal num = 0m;
				decimal num2 = 0m;
				if (priorOrBkCls > 0m && poPrice > 0m)
				{
					num = poPrice - priorOrBkCls;
					num2 = num / priorOrBkCls * 100m;
				}
				recordItem.Fields("chg").Text = num;
				recordItem.Fields("pchg").Text = num2;
				recordItem.Fields("po").Text = poPrice;
				Color fontColor = Utilities.ComparePriceCFColor(poPrice, priorOrBkCls, stockInfo);
				recordItem.Fields("stock").FontColor = fontColor;
				recordItem.Fields("chg").FontColor = fontColor;
				recordItem.Fields("pchg").FontColor = fontColor;
				recordItem.Fields("po").FontColor = fontColor;
				recordItem.Fields("prior").FontColor = MyColor.UnChgColor;
			}
			catch (Exception ex)
			{
				this.ShowError("BestProjectedOpenPriceUpdateByPO", ex);
			}
			result = flag;
			return result;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000A276C File Offset: 0x000A0B6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestPOpen_SetHeaderGrid()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.MarketSession <= 1)
				{
					this.intzaProjectedOpen.GetColumn("ovolume1").Text = "OpenVol-1";
					this.intzaProjectedOpen.GetColumn("open1").Text = "Open-1";
					this.intzaProjectedOpen.GetColumn("prior").Text = "Prior";
				}
				else if (ApplicationInfo.MarketSession == 2)
				{
					this.intzaProjectedOpen.GetColumn("ovolume1").Text = "OpenVol-2";
					this.intzaProjectedOpen.GetColumn("open1").Text = "Open-2";
					this.intzaProjectedOpen.GetColumn("prior").Text = "BrkCls";
				}
				this.intzaProjectedOpen.GetColumn("po").Text = "PrjOpn";
			}
			catch (Exception ex)
			{
				this.ShowError("BestPOpen_SetHeaderGrid", ex);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000A289C File Offset: 0x000A0C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestPClose_ReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.IsLoadingData = true;
				if (this.boardTypeProjectedClosePrice == frmStockRanking.BoardTypes.M)
				{
					this.tscbBoard.Text = "Main";
				}
				else
				{
					this.tscbBoard.Text = "Foreign";
				}
				if (this.compareModeProjectedClosePrice == "G")
				{
					this.tscbSort.Text = "Gainer";
				}
				else
				{
					this.tscbSort.Text = "Loser";
				}
				this.intzaProjectedClose.ClearAllText();
				this.intzaProjectedClose.Redraw();
				if (!this.bgwProjectedClosePriceLoadData.IsBusy)
				{
					this.bgwProjectedClosePriceLoadData.RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestPClose_ReloadData", ex);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000A29A4 File Offset: 0x000A0DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestPClose_UpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaProjectedClose.BeginUpdate();
				this.intzaProjectedClose.ClearAllText();
				if (this.dsProjectedClosePrice.Tables.Count > 0 && this.dsProjectedClosePrice.Tables.Contains("security_info_stat"))
				{
					for (int i = 0; i < this.dsProjectedClosePrice.Tables["security_info_stat"].Rows.Count; i++)
					{
						DataRow dataRow = this.dsProjectedClosePrice.Tables["security_info_stat"].Rows[i];
						int num;
						int.TryParse(dataRow["security_number"].ToString(), out num);
						if (num > 0)
						{
							StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[num];
							decimal num2 = 0m;
							long num3;
							long.TryParse(dataRow["accvolume"].ToString(), out num3);
							if (num3 > 0L)
							{
								decimal d;
								decimal.TryParse(dataRow["accvalue"].ToString(), out d);
								num2 = Math.Round(d / num3, 2);
							}
							decimal num4;
							decimal.TryParse(dataRow["last_sale_price"].ToString(), out num4);
							decimal num5;
							decimal.TryParse(dataRow["projected_close"].ToString(), out num5);
							decimal num6;
							decimal.TryParse(dataRow["high_price"].ToString(), out num6);
							decimal num7;
							decimal.TryParse(dataRow["low_price"].ToString(), out num7);
							RecordItem recordItem = this.intzaProjectedClose.Records(i);
							recordItem.Fields("stock").Text = stockInformation.Symbol;
							recordItem.Fields("stock").Tag = stockInformation.DisplayFlag;
							recordItem.Fields("last").Text = num4;
							decimal num8 = 0m;
							decimal num9 = 0m;
							if (num4 > 0m && num5 > 0m)
							{
								num8 = num5 - num4;
								num9 = num8 / num4 * 100m;
							}
							recordItem.Fields("chg").Text = num8;
							recordItem.Fields("pchg").Text = num9;
							recordItem.Fields("poclose").Text = num5;
							recordItem.Fields("prior").Text = stockInformation.PriorPrice;
							recordItem.Fields("avg").Text = num2;
							recordItem.Fields("high").Text = num6;
							recordItem.Fields("low").Text = num7;
							Color fontColor = Utilities.ComparePriceCFColor(num5, stockInformation);
							recordItem.Fields("stock").FontColor = fontColor;
							recordItem.Fields("poclose").FontColor = fontColor;
							recordItem.Fields("chg").FontColor = fontColor;
							recordItem.Fields("pchg").FontColor = fontColor;
							recordItem.Fields("last").FontColor = Utilities.ComparePriceCFColor(num4, stockInformation);
							recordItem.Fields("prior").FontColor = MyColor.UnChgColor;
							recordItem.Fields("high").FontColor = Utilities.ComparePriceCFColor(num6, stockInformation);
							recordItem.Fields("low").FontColor = Utilities.ComparePriceCFColor(num7, stockInformation);
							recordItem.Fields("avg").FontColor = Utilities.ComparePriceCFColor(num2, stockInformation);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestProjectedClosePriceUpdateToControl", ex);
			}
			this.intzaProjectedClose.Redraw();
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000A2DFC File Offset: 0x000A11FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool BestPClose_UpdateByPO(int recIndex, decimal poClose, StockList.StockInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = true;
			try
			{
				RecordItem recordItem = this.intzaProjectedClose.Records(recIndex);
				if (recordItem != null)
				{
					decimal num = 0m;
					decimal.TryParse(recordItem.Fields("last").Text.ToString(), out num);
					decimal num2 = 0m;
					decimal num3 = 0m;
					if (num > 0m && poClose > 0m)
					{
						num2 = poClose - num;
						num3 = num2 / num * 100m;
					}
					recordItem.Fields("chg").Text = num2;
					recordItem.Fields("pchg").Text = num3;
					recordItem.Fields("poclose").Text = poClose;
					Color fontColor = Utilities.ComparePriceCFColor(poClose, stockInfo);
					recordItem.Fields("poclose").FontColor = fontColor;
					recordItem.Fields("chg").FontColor = fontColor;
					recordItem.Fields("pchg").FontColor = fontColor;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestProjectedClosePriceUpdateByPO", ex);
			}
			return result;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000A2F84 File Offset: 0x000A1384
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestPClose_ClearRecord(int rowIndex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaProjectedClose.ClearAllTextByRow(rowIndex);
				if (this.compareModeProjectedClosePrice == "G")
				{
					this.intzaProjectedClose.Sort("pchg", SortType.Desc);
				}
				else
				{
					this.intzaProjectedClose.Sort("pchg", SortType.Asc);
				}
				if (base.IsAllowRender)
				{
					this.intzaProjectedClose.EndUpdate();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestProjectedClosePriceClearRecord", ex);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000A303C File Offset: 0x000A143C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestOpen_ReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.IsLoadingData = true;
				if (this.boardTypeBestOpenPrice == frmStockRanking.BoardTypes.M)
				{
					this.tscbBoard.Text = "Main";
				}
				else
				{
					this.tscbBoard.Text = "Foreign";
				}
				if (this.openSessionBestOpenPrice == 1)
				{
					this.intzaBestOpen.GetColumn("open_volume").Text = "OpenVol-1";
					this.intzaBestOpen.GetColumn("open_price").Text = "Open-1";
					this.intzaBestOpen.GetColumn("prior").Text = "Prior";
					this.tscbBestOpenMktSession.Text = "1";
					this.Text = "Best Open Price - Session 1";
				}
				else if (this.openSessionBestOpenPrice == 2)
				{
					this.intzaBestOpen.GetColumn("open_volume").Text = "OpenVol-2";
					this.intzaBestOpen.GetColumn("open_price").Text = "Open-2";
					this.intzaBestOpen.GetColumn("prior").Text = "BrkCls";
					this.tscbBestOpenMktSession.Text = "2";
					this.Text = "Best Open Price - Session 2";
				}
				if (this.compareModeBestOpenPrice == "G")
				{
					this.tscbSort.Text = "Gainer";
				}
				else
				{
					this.tscbSort.Text = "Loser";
				}
				this.intzaBestOpen.ClearAllText();
				this.intzaBestOpen.Redraw();
				if (!this.bgwBestOpenPriceLoadData.IsBusy)
				{
					this.bgwBestOpenPriceLoadData.RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestOpenPriceReloadData", ex);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000A3258 File Offset: 0x000A1658
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestOpen_UpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaBestOpen.BeginUpdate();
				this.intzaBestOpen.ClearAllText();
				if (this.dsBestOpenPrice.Tables.Count > 0 && this.dsBestOpenPrice.Tables.Contains("security_info_stat"))
				{
					for (int i = 0; i < this.dsBestOpenPrice.Tables["security_info_stat"].Rows.Count; i++)
					{
						DataRow dataRow = this.dsBestOpenPrice.Tables["security_info_stat"].Rows[i];
						int num;
						int.TryParse(dataRow["security_number"].ToString(), out num);
						if (num > 0)
						{
							StockList.StockInformation stockInfo = ApplicationInfo.StockInfo[num];
							decimal openPrice;
							decimal.TryParse(dataRow["open_price"].ToString(), out openPrice);
							decimal priorOrBreakclose;
							decimal.TryParse(dataRow["prior"].ToString(), out priorOrBreakclose);
							decimal avg = 0m;
							long num2;
							long.TryParse(dataRow["accvolume"].ToString(), out num2);
							if (num2 > 0L)
							{
								decimal d;
								decimal.TryParse(dataRow["accvalue"].ToString(), out d);
								avg = Math.Round(d / num2, 2);
							}
							long openVolume;
							long.TryParse(dataRow["open_volume"].ToString(), out openVolume);
							decimal highPrice;
							decimal.TryParse(dataRow["high_price"].ToString(), out highPrice);
							decimal lowPrice;
							decimal.TryParse(dataRow["low_price"].ToString(), out lowPrice);
							decimal lastPrice;
							decimal.TryParse(dataRow["last_sale_price"].ToString(), out lastPrice);
							this.BestOpen_UpdateByLS(i, avg, openVolume, highPrice, lowPrice, lastPrice, openPrice, priorOrBreakclose, stockInfo);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestOpenPriceUpdateToControl", ex);
			}
			this.intzaBestOpen.Redraw();
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000A34AC File Offset: 0x000A18AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestOpen_UpdateByLS(int rowIndex, decimal avg, long openVolume, decimal highPrice, decimal lowPrice, decimal lastPrice, decimal openPrice, decimal priorOrBreakclose, StockList.StockInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				RecordItem recordItem = null;
				if (rowIndex > -1)
				{
					recordItem = this.intzaBestOpen.Records(rowIndex);
				}
				if (recordItem != null)
				{
					recordItem.Fields("stock").Text = stockInfo.Symbol;
					recordItem.Fields("stock").Tag = stockInfo.DisplayFlag;
					if (openPrice > 0m)
					{
						decimal num = 0m;
						decimal num2 = 0m;
						if (priorOrBreakclose > 0m && openPrice > 0m)
						{
							num = openPrice - priorOrBreakclose;
							num2 = num / priorOrBreakclose * 100m;
						}
						recordItem.Fields("open_price").Text = openPrice;
						recordItem.Fields("chg").Text = num;
						recordItem.Fields("pchg").Text = num2;
					}
					Color fontColor = Utilities.ComparePriceCFColor(lastPrice, stockInfo);
					recordItem.Fields("stock").FontColor = fontColor;
					if (openPrice > 0m)
					{
						fontColor = Utilities.ComparePriceCFColor(openPrice, stockInfo);
						recordItem.Fields("open_price").FontColor = fontColor;
						recordItem.Fields("chg").FontColor = fontColor;
						recordItem.Fields("pchg").FontColor = fontColor;
					}
					if (priorOrBreakclose > 0m)
					{
						recordItem.Fields("prior").Text = priorOrBreakclose;
					}
					recordItem.Fields("last").Text = lastPrice;
					recordItem.Fields("high").Text = highPrice;
					recordItem.Fields("low").Text = lowPrice;
					recordItem.Fields("avg").Text = avg;
					if (openVolume > -1L)
					{
						recordItem.Fields("open_volume").Text = openVolume;
						recordItem.Fields("open_volume").FontColor = recordItem.Fields("open_price").FontColor;
					}
					recordItem.Fields("prior").FontColor = MyColor.UnChgColor;
					recordItem.Fields("last").FontColor = Utilities.ComparePriceCFColor(lastPrice, stockInfo);
					recordItem.Fields("high").FontColor = Utilities.ComparePriceCFColor(highPrice, stockInfo);
					recordItem.Fields("low").FontColor = Utilities.ComparePriceCFColor(lowPrice, stockInfo);
					recordItem.Fields("avg").FontColor = Utilities.ComparePriceCFColor(avg, stockInfo);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestOpenPriceUpdateToGridByLS", ex);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000A37F4 File Offset: 0x000A1BF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BestOpen_ClearRecord(int rowIndex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaBestOpen.ClearAllTextByRow(rowIndex);
				if (this.compareModeBestOpenPrice == "G")
				{
					this.intzaBestOpen.Sort("pchg", SortType.Desc);
				}
				else
				{
					this.intzaBestOpen.Sort("pchg", SortType.Asc);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("BestOpenPriceClearRecord", ex);
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000A3890 File Offset: 0x000A1C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!base.IsLoadingData)
				{
					if (this.currentPage == "Top Active")
					{
						if (realtimeStockInfo != null && (message.MessageType == "L+" || message.MessageType == "PD"))
						{
							this.TopActiveUpdateRealTimes(message, realtimeStockInfo);
						}
					}
					else if (this.currentPage == "Best Projected Open")
					{
						if (realtimeStockInfo != null)
						{
							if (!(realtimeStockInfo.MarketId != this.marketIdProjectedOpenPrice))
							{
								if (this.boardTypeProjectedOpenPrice == frmStockRanking.BoardTypes.M)
								{
									if (realtimeStockInfo.StockBoard != "M")
									{
										return;
									}
								}
								else if (realtimeStockInfo.StockBoard != "F")
								{
									return;
								}
								if (message.MessageType == "L+")
								{
									LSAccumulate lSAccumulate = (LSAccumulate)message;
									int num = this.intzaProjectedOpen.FindIndex("stock", realtimeStockInfo.Symbol);
									if (num > -1)
									{
										decimal avg = 0m;
										if (lSAccumulate.AccVolume > 0L)
										{
											avg = lSAccumulate.AccValue / (lSAccumulate.AccVolume * (long)realtimeStockInfo.BoardLot);
										}
										decimal openPrice = -1m;
										long openVolume = 0L;
										if (lSAccumulate.Side == string.Empty)
										{
											openPrice = lSAccumulate.LastPrice;
											openVolume = lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot;
										}
										this.BestPOpen_UpdateByLS(this.intzaProjectedOpen.Records(num), avg, realtimeStockInfo.HighPrice, realtimeStockInfo.LowPrice, openPrice, openVolume, realtimeStockInfo);
										if (base.IsAllowRender)
										{
											this.intzaProjectedOpen.EndUpdate(num);
										}
									}
								}
								else if (message.MessageType == "PO")
								{
									if (!(ApplicationInfo.MarketState == "M"))
									{
										int num = this.intzaProjectedOpen.FindIndex("stock", realtimeStockInfo.Symbol);
										if (num > -1)
										{
											POMessage pOMessage = (POMessage)message;
											this.BestPOpen_UpdateByPO(num, pOMessage.ProjectedPrice, -1m, realtimeStockInfo);
											if (base.IsAllowRender)
											{
												this.intzaProjectedOpen.EndUpdate(num);
											}
										}
									}
								}
							}
						}
					}
					else if (this.currentPage == "Best Projected Close")
					{
						if (realtimeStockInfo == null)
						{
							if (message.MessageType == "SC")
							{
								this.intzaProjectedClose.Invalidate();
							}
						}
						else if (!(ApplicationInfo.MarketState == "P") && !(ApplicationInfo.MarketState == "O"))
						{
							if (!(realtimeStockInfo.MarketId != this.marketIdProjectedClosePrice))
							{
								if (this.boardTypeProjectedClosePrice == frmStockRanking.BoardTypes.M)
								{
									if (realtimeStockInfo.StockBoard != "M")
									{
										return;
									}
								}
								else if (realtimeStockInfo.StockBoard != "F")
								{
									return;
								}
								if (message.MessageType == "PO")
								{
									int num2 = this.intzaProjectedClose.FindIndex("stock", realtimeStockInfo.Symbol);
									if (num2 > -1)
									{
										POMessage pOMessage = (POMessage)message;
										this.BestPClose_UpdateByPO(num2, pOMessage.ProjectedPrice, realtimeStockInfo);
										if (base.IsAllowRender)
										{
											this.intzaProjectedClose.EndUpdate(num2);
										}
									}
								}
							}
						}
					}
					else if (this.currentPage == "Best Open Price")
					{
						if (message.MessageType == "L+")
						{
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ReceiveMessage", ex);
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000A3DC0 File Offset: 0x000A21C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000A3DD4 File Offset: 0x000A21D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaTopActive_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex >= 0)
				{
					string text = this.intzaTopActive.Records(e.RowIndex).Fields("stock").Text.ToString();
					if (!string.IsNullOrEmpty(text.Trim()))
					{
						if (Settings.Default.SmartOneClick)
						{
							if (e.Column.Name == "high" || e.Column.Name == "low" || e.Column.Name == "last")
							{
								string price = this.intzaTopActive.Records(e.RowIndex).Fields("last").Text.ToString();
								if (e.Column.Name == "high" || e.Column.Name == "low")
								{
									price = this.intzaTopActive.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString();
								}
								string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
								TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, text, price, false);
							}
						}
						if (e.Column.Name == "stock")
						{
							if (e.Mouse.Button == MouseButtons.Right)
							{
								this.contextLink.Tag = text;
								this.contextLink.Show(this.intzaProjectedOpen, new Point(e.Mouse.X, e.Mouse.Y));
							}
							else
							{
								TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(text);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaTopActive_TableMouseClick", ex);
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000A4058 File Offset: 0x000A2458
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaProjectedOpen_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex >= 0)
				{
					string text = this.intzaProjectedOpen.Records(e.RowIndex).Fields("stock").Text.ToString();
					if (!string.IsNullOrEmpty(text.Trim()))
					{
						if (Settings.Default.SmartOneClick)
						{
							if (e.Column.Name == "po" || e.Column.Name == "high" || e.Column.Name == "low" || e.Column.Name == "prior" || e.Column.Name == "open1")
							{
								string price = this.intzaProjectedOpen.Records(e.RowIndex).Fields("po").Text.ToString();
								if (e.Column.Name == "high" || e.Column.Name == "low" || e.Column.Name == "prior" || e.Column.Name == "open1")
								{
									price = this.intzaProjectedOpen.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString();
								}
								string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
								TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, text, price, false);
							}
						}
						if (e.Column.Name == "stock")
						{
							if (e.Mouse.Button == MouseButtons.Right)
							{
								this.contextLink.Tag = text;
								this.contextLink.Show(this.intzaProjectedOpen, new Point(e.Mouse.X, e.Mouse.Y));
							}
							else
							{
								TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(text);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaProjectedOpen_TableMouseClick", ex);
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000A4344 File Offset: 0x000A2744
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaProjectedClose_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex >= 0)
				{
					string text = this.intzaProjectedClose.Records(e.RowIndex).Fields("stock").Text.ToString();
					if (!string.IsNullOrEmpty(text.Trim()))
					{
						if (Settings.Default.SmartOneClick)
						{
							if (e.Column.Name == "poclose" || e.Column.Name == "high" || e.Column.Name == "low" || e.Column.Name == "prior" || e.Column.Name == "last")
							{
								string price = this.intzaProjectedClose.Records(e.RowIndex).Fields("poclose").Text.ToString();
								if (e.Column.Name == "high" || e.Column.Name == "low" || e.Column.Name == "prior" || e.Column.Name == "last")
								{
									price = this.intzaProjectedClose.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString();
								}
								string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
								TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, text, price, false);
							}
						}
						if (e.Column.Name == "stock")
						{
							if (e.Mouse.Button == MouseButtons.Right)
							{
								this.contextLink.Tag = text;
								this.contextLink.Show(this.intzaProjectedClose, new Point(e.Mouse.X, e.Mouse.Y));
							}
							else
							{
								TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(text);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaProjectedClose_TableMouseClick", ex);
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000A4630 File Offset: 0x000A2A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaBestOpen_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1)
				{
					string text = this.intzaBestOpen.Records(e.RowIndex).Fields("stock").Text.ToString();
					if (!string.IsNullOrEmpty(text.Trim()))
					{
						if (Settings.Default.SmartOneClick)
						{
							if (e.Column.Name == "open_price" || e.Column.Name == "high" || e.Column.Name == "low" || e.Column.Name == "prior" || e.Column.Name == "last")
							{
								string price = this.intzaBestOpen.Records(e.RowIndex).Fields("open_price").Text.ToString();
								if (e.Column.Name == "high" || e.Column.Name == "low" || e.Column.Name == "prior" || e.Column.Name == "last")
								{
									price = this.intzaBestOpen.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString();
								}
								string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
								TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, text, price, false);
							}
						}
						if (e.Column.Name == "stock")
						{
							if (e.Mouse.Button == MouseButtons.Right)
							{
								this.contextLink.Tag = text;
								this.contextLink.Show(this.intzaBestOpen, new Point(e.Mouse.X, e.Mouse.Y));
							}
							else
							{
								TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(text);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaBestOpen_TableMouseClick", ex);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000A4920 File Offset: 0x000A2D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockRanking_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Home)
			{
				if (this.currentPage == "Top Active")
				{
					this.currentPage = "Best Projected Open";
				}
				else if (this.currentPage == "Best Projected Open")
				{
					this.currentPage = "Best Projected Close";
				}
				else if (this.currentPage == "Best Projected Close")
				{
					this.currentPage = "Best Open Price";
				}
				else if (this.currentPage == "Best Open Price")
				{
					this.currentPage = "Top Active";
				}
				this.SetActivePage();
				this.ReloadDataPage(this.currentPage);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000A4A10 File Offset: 0x000A2E10
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetActivePage()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tscbSelection.Text = this.currentPage;
			this.tStripMenu.SuspendLayout();
			this.tslbTopActiveType.Visible = false;
			this.tscbTopActiveType.Visible = false;
			this.tslbTopActiveMkt.Visible = false;
			this.tscbTopActiveMkt.Visible = false;
			this.tslbBoard.Visible = false;
			this.tscbBoard.Visible = false;
			this.tslbSort.Visible = false;
			this.tscbSort.Visible = false;
			this.tslbBestOpenMktSession.Visible = false;
			this.tscbBestOpenMktSession.Visible = false;
			if (this.currentPage == "Top Active")
			{
				this.tslbTopActiveType.Visible = true;
				this.tscbTopActiveType.Visible = true;
				this.tslbTopActiveMkt.Visible = true;
				this.tscbTopActiveMkt.Visible = true;
				this.intzaTopActive.Show();
			}
			else if (this.currentPage == "Best Projected Open")
			{
				this.tslbBoard.Visible = true;
				this.tscbBoard.Visible = true;
				this.tslbSort.Visible = true;
				this.tscbSort.Visible = true;
				this.intzaProjectedOpen.Show();
			}
			else if (this.currentPage == "Best Projected Close")
			{
				this.tslbBoard.Visible = true;
				this.tscbBoard.Visible = true;
				this.tslbSort.Visible = true;
				this.tscbSort.Visible = true;
				this.intzaProjectedClose.Show();
			}
			else if (this.currentPage == "Best Open Price")
			{
				this.tslbBoard.Visible = true;
				this.tscbBoard.Visible = true;
				this.tslbSort.Visible = true;
				this.tscbSort.Visible = true;
				this.tslbBestOpenMktSession.Visible = true;
				this.tscbBestOpenMktSession.Visible = true;
				this.intzaBestOpen.Show();
			}
			if (this.currentPage != "Top Active")
			{
				this.intzaTopActive.Hide();
			}
			if (this.currentPage != "Best Projected Open")
			{
				this.intzaProjectedOpen.Hide();
			}
			if (this.currentPage != "Best Projected Close")
			{
				this.intzaProjectedClose.Hide();
			}
			if (this.currentPage != "Best Open Price")
			{
				this.intzaBestOpen.Hide();
			}
			this.tStripMenu.ResumeLayout();
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000A4D14 File Offset: 0x000A3114
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbTopActiveBoard_KeyPress(object sender, KeyPressEventArgs e)
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
				this.ShowError("tscbTopActiveType_KeyPress", ex);
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000A4D7C File Offset: 0x000A317C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private frmStockRanking.ActiveGroupTypes TopActiveGetType()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return frmStockRanking.ActiveGroupTypes.None;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000A4DA0 File Offset: 0x000A31A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbBestOpenMktSession_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.openSessionBestOpenPrice = Convert.ToInt32(this.tscbBestOpenMktSession.Text);
				this.BestOpen_ReloadData();
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000A4DE8 File Offset: 0x000A31E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbBoard_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				if (this.currentPage == "Best Open Price")
				{
					if (this.tscbBoard.Text.ToLower() == "main")
					{
						this.boardTypeBestOpenPrice = frmStockRanking.BoardTypes.M;
					}
					else
					{
						this.boardTypeBestOpenPrice = frmStockRanking.BoardTypes.F;
					}
					this.BestOpen_ReloadData();
				}
				else if (this.currentPage == "Best Projected Open")
				{
					if (this.tscbBoard.Text.ToLower() == "main")
					{
						this.boardTypeProjectedOpenPrice = frmStockRanking.BoardTypes.M;
					}
					else
					{
						this.boardTypeProjectedOpenPrice = frmStockRanking.BoardTypes.F;
					}
					this.BestPOpen_ReloadData();
				}
				else if (this.currentPage == "Best Projected Close")
				{
					if (this.tscbBoard.Text.ToLower() == "main")
					{
						this.boardTypeProjectedClosePrice = frmStockRanking.BoardTypes.M;
					}
					else
					{
						this.boardTypeProjectedClosePrice = frmStockRanking.BoardTypes.F;
					}
					this.BestPClose_ReloadData();
				}
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000A4F2C File Offset: 0x000A332C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				if (this.currentPage == "Best Open Price")
				{
					this.compareModeBestOpenPrice = this.tscbSort.Text.Substring(0, 1);
					this.BestOpen_ReloadData();
				}
				else if (this.currentPage == "Best Projected Open")
				{
					this.compareModeProjectedOpenPrice = this.tscbSort.Text.Substring(0, 1);
					this.BestPOpen_ReloadData();
				}
				else if (this.currentPage == "Best Projected Close")
				{
					this.compareModeProjectedClosePrice = this.tscbSort.Text.Substring(0, 1);
					this.BestPClose_ReloadData();
				}
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000A5014 File Offset: 0x000A3414
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbTopActiveType_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				string text = this.tscbTopActiveType.Text;
				switch (text)
				{
				case "Most Active - Main":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.MostActive_Main);
					break;
				case "Most Active - Foreign":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.MostActive_Foreign);
					break;
				case "Biglot":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.MostActive_BigLot);
					break;
				case "Gainer - Main":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.Gainer_Main);
					break;
				case "Gainer - Foreign":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.Gainer_Foreign);
					break;
				case "Loser - Main":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.Loser_Main);
					break;
				case "Loser - Foreign":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.Loser_Foreign);
					break;
				case "Most Swing - Main":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.MostSwing_Main);
					break;
				case "Most Swing - Foreign":
					this.TopActiveReloadData(frmStockRanking.ActiveGroupTypes.MostSwing_Foreign);
					break;
				}
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000A5190 File Offset: 0x000A3590
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbTopActiveMkt_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				if (this.tscbTopActiveMkt.Text == "SET")
				{
					this.marketIdTopActive = "S";
				}
				else
				{
					this.marketIdTopActive = "M";
				}
				this.TopActiveReloadData(this.activeGroupTypeTopActive);
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000A5204 File Offset: 0x000A3604
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmCallHistoricalChart_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.contextLink.Tag != null && this.contextLink.Tag.ToString() != string.Empty)
			{
				if (ApplicationInfo.IsSupportEfinChart)
				{
					TemplateManager.Instance.MainForm.SetTemplateLink("Graph", "", this.contextLink.Tag.ToString());
				}
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000A5298 File Offset: 0x000A3698
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmCallNews_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.contextLink.Tag != null && this.contextLink.Tag.ToString() != string.Empty)
			{
				if (ApplicationInfo.IsSupportEfinChart)
				{
					TemplateManager.Instance.MainForm.SetTemplateLink("News", "NEWS", this.contextLink.Tag.ToString());
				}
				else
				{
					ApplicationInfo.NewsSymbol = this.contextLink.Tag.ToString();
					TemplateManager.Instance.MainForm.SetTemplateLink("SET News", string.Empty, this.contextLink.Tag.ToString());
				}
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000A5374 File Offset: 0x000A3774
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmCallFinance_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.contextLink.Tag != null && this.contextLink.Tag.ToString() != string.Empty)
			{
				if (ApplicationInfo.IsSupportEfinChart)
				{
					TemplateManager.Instance.MainForm.SetTemplateLink("Finance", "FINANCE", this.contextLink.Tag.ToString());
				}
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000A5408 File Offset: 0x000A3808
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmCallStockSummary_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.contextLink.Tag != null && this.contextLink.Tag.ToString() != string.Empty)
			{
				TemplateManager.Instance.MainForm.SetTemplateLink("Stock in Play", "Stock in Play", this.contextLink.Tag.ToString());
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000A548C File Offset: 0x000A388C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmCallSaleByPrice_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.contextLink.Tag != null && this.contextLink.Tag.ToString() != string.Empty)
			{
				TemplateManager.Instance.MainForm.SetTemplateLink("Sale by Price", "Sale by Price", this.contextLink.Tag.ToString());
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000A5510 File Offset: 0x000A3910
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmCallSaleByTime_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.contextLink.Tag != null && this.contextLink.Tag.ToString() != string.Empty)
			{
				TemplateManager.Instance.MainForm.SetTemplateLink("Sale by Time", "Sale by Time", this.contextLink.Tag.ToString());
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000A5594 File Offset: 0x000A3994
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmCallOddlot_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.contextLink.Tag != null && this.contextLink.Tag.ToString() != string.Empty)
			{
				TemplateManager.Instance.MainForm.SetTemplateLink("View Oddlot", "View Oddlot", this.contextLink.Tag.ToString());
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000A5618 File Offset: 0x000A3A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmCallMarketWatch_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.contextLink.Tag != null && this.contextLink.Tag.ToString() != string.Empty)
			{
				TemplateManager.Instance.MainForm.SetTemplateLink("My List", string.Empty, this.contextLink.Tag.ToString());
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000A569C File Offset: 0x000A3A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void contextLink_Opening(object sender, CancelEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tsmCallHistoricalChart.Visible = ApplicationInfo.IsSupportEfinChart;
			this.tsmCallFinance.Visible = ApplicationInfo.IsSupportEfinChart;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000A56D0 File Offset: 0x000A3AD0
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

		// Token: 0x06000880 RID: 2176 RVA: 0x000A5720 File Offset: 0x000A3B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
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
			ColumnItem columnItem37 = new ColumnItem();
			ColumnItem columnItem38 = new ColumnItem();
			ColumnItem columnItem39 = new ColumnItem();
			ColumnItem columnItem40 = new ColumnItem();
			ColumnItem columnItem41 = new ColumnItem();
			ColumnItem columnItem42 = new ColumnItem();
			ColumnItem columnItem43 = new ColumnItem();
			ColumnItem columnItem44 = new ColumnItem();
			ColumnItem columnItem45 = new ColumnItem();
			this.tStripMenu = new ToolStrip();
			this.toolStripLabel10 = new ToolStripLabel();
			this.tscbSelection = new ToolStripComboBox();
			this.tslbTopActiveType = new ToolStripLabel();
			this.tscbTopActiveType = new ToolStripComboBox();
			this.tslbTopActiveMkt = new ToolStripLabel();
			this.tscbTopActiveMkt = new ToolStripComboBox();
			this.tslbBoard = new ToolStripLabel();
			this.tscbBoard = new ToolStripComboBox();
			this.tslbSort = new ToolStripLabel();
			this.tscbSort = new ToolStripComboBox();
			this.tslbBestOpenMktSession = new ToolStripLabel();
			this.tscbBestOpenMktSession = new ToolStripComboBox();
			this.intzaBestOpen = new SortGrid();
			this.intzaProjectedOpen = new SortGrid();
			this.intzaProjectedClose = new SortGrid();
			this.intzaTopActive = new SortGrid();
			this.contextLink = new ContextMenuStrip(this.components);
			this.tsmCallHistoricalChart = new ToolStripMenuItem();
			this.tsmCallNews = new ToolStripMenuItem();
			this.tsmCallFinance = new ToolStripMenuItem();
			this.toolStripMenuItem1 = new ToolStripSeparator();
			this.tsmCallMarketWatch = new ToolStripMenuItem();
			this.tsmCallStockInPlay = new ToolStripMenuItem();
			this.tsmCallSaleByPrice = new ToolStripMenuItem();
			this.tsmCallSaleByTime = new ToolStripMenuItem();
			this.tsmCallOddlot = new ToolStripMenuItem();
			this.tStripMenu.SuspendLayout();
			this.contextLink.SuspendLayout();
			base.SuspendLayout();
			this.tStripMenu.AllowMerge = false;
			this.tStripMenu.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripMenu.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripLabel10,
				this.tscbSelection,
				this.tslbTopActiveType,
				this.tscbTopActiveType,
				this.tslbTopActiveMkt,
				this.tscbTopActiveMkt,
				this.tslbBoard,
				this.tscbBoard,
				this.tslbSort,
				this.tscbSort,
				this.tslbBestOpenMktSession,
				this.tscbBestOpenMktSession
			});
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Padding = new Padding(1, 1, 1, 2);
			this.tStripMenu.RenderMode = ToolStripRenderMode.System;
			this.tStripMenu.Size = new Size(1252, 26);
			this.tStripMenu.TabIndex = 0;
			this.tStripMenu.TabStop = true;
			this.tStripMenu.Tag = "-1";
			this.toolStripLabel10.ForeColor = Color.LightGray;
			this.toolStripLabel10.Margin = new Padding(3, 1, 0, 2);
			this.toolStripLabel10.Name = "toolStripLabel10";
			this.toolStripLabel10.Size = new Size(33, 20);
			this.toolStripLabel10.Text = "Page";
			this.tscbSelection.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbSelection.ForeColor = Color.LightGray;
			this.tscbSelection.Name = "tscbSelection";
			this.tscbSelection.Size = new Size(170, 23);
			this.tscbSelection.SelectedIndexChanged += new EventHandler(this.CallPage);
			this.tslbTopActiveType.ForeColor = Color.LightGray;
			this.tslbTopActiveType.Margin = new Padding(5, 1, 0, 2);
			this.tslbTopActiveType.Name = "tslbTopActiveType";
			this.tslbTopActiveType.Size = new Size(41, 20);
			this.tslbTopActiveType.Text = "View : ";
			this.tscbTopActiveType.AutoCompleteCustomSource.AddRange(new string[]
			{
				"Most Active",
				"Biglot",
				"Gainer",
				"Loser",
				"Most Swing"
			});
			this.tscbTopActiveType.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tscbTopActiveType.AutoSize = false;
			this.tscbTopActiveType.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbTopActiveType.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbTopActiveType.ForeColor = Color.LightGray;
			this.tscbTopActiveType.Items.AddRange(new object[]
			{
				"Most Active - Main",
				"Most Active - Foreign",
				"Biglot",
				"Gainer - Main",
				"Gainer - Foreign",
				"Loser - Main",
				"Loser - Foreign",
				"Most Swing - Main",
				"Most Swing - Foreign"
			});
			this.tscbTopActiveType.Name = "tscbTopActiveType";
			this.tscbTopActiveType.Size = new Size(160, 23);
			this.tscbTopActiveType.SelectedIndexChanged += new EventHandler(this.tscbTopActiveType_SelectedIndexChanged);
			this.tslbTopActiveMkt.ForeColor = Color.LightGray;
			this.tslbTopActiveMkt.Margin = new Padding(5, 1, 0, 2);
			this.tslbTopActiveMkt.Name = "tslbTopActiveMkt";
			this.tslbTopActiveMkt.Size = new Size(53, 20);
			this.tslbTopActiveMkt.Text = "Market : ";
			this.tscbTopActiveMkt.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbTopActiveMkt.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbTopActiveMkt.ForeColor = Color.LightGray;
			this.tscbTopActiveMkt.Items.AddRange(new object[]
			{
				"SET",
				"MAI"
			});
			this.tscbTopActiveMkt.Name = "tscbTopActiveMkt";
			this.tscbTopActiveMkt.Size = new Size(90, 23);
			this.tscbTopActiveMkt.SelectedIndexChanged += new EventHandler(this.tscbTopActiveMkt_SelectedIndexChanged);
			this.tslbBoard.ForeColor = Color.LightGray;
			this.tslbBoard.Margin = new Padding(5, 1, 0, 2);
			this.tslbBoard.Name = "tslbBoard";
			this.tslbBoard.Size = new Size(47, 20);
			this.tslbBoard.Text = "Board : ";
			this.tscbBoard.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbBoard.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbBoard.ForeColor = Color.LightGray;
			this.tscbBoard.Items.AddRange(new object[]
			{
				"Main",
				"Foreign"
			});
			this.tscbBoard.Name = "tscbBoard";
			this.tscbBoard.Size = new Size(90, 23);
			this.tscbBoard.SelectedIndexChanged += new EventHandler(this.tscbBoard_SelectedIndexChanged);
			this.tslbSort.ForeColor = Color.LightGray;
			this.tslbSort.Margin = new Padding(5, 1, 0, 2);
			this.tslbSort.Name = "tslbSort";
			this.tslbSort.Size = new Size(53, 20);
			this.tslbSort.Text = "Sort by : ";
			this.tscbSort.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbSort.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbSort.ForeColor = Color.LightGray;
			this.tscbSort.Items.AddRange(new object[]
			{
				"Gainer",
				"Loser"
			});
			this.tscbSort.Name = "tscbSort";
			this.tscbSort.Size = new Size(90, 23);
			this.tscbSort.SelectedIndexChanged += new EventHandler(this.tscbSort_SelectedIndexChanged);
			this.tslbBestOpenMktSession.ForeColor = Color.LightGray;
			this.tslbBestOpenMktSession.Margin = new Padding(5, 1, 0, 2);
			this.tslbBestOpenMktSession.Name = "tslbBestOpenMktSession";
			this.tslbBestOpenMktSession.Size = new Size(95, 20);
			this.tslbBestOpenMktSession.Text = "Market Session : ";
			this.tscbBestOpenMktSession.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbBestOpenMktSession.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbBestOpenMktSession.ForeColor = Color.LightGray;
			this.tscbBestOpenMktSession.Items.AddRange(new object[]
			{
				"1",
				"2"
			});
			this.tscbBestOpenMktSession.Name = "tscbBestOpenMktSession";
			this.tscbBestOpenMktSession.Size = new Size(75, 23);
			this.tscbBestOpenMktSession.SelectedIndexChanged += new EventHandler(this.tscbBestOpenMktSession_SelectedIndexChanged);
			this.intzaBestOpen.AllowDrop = true;
			this.intzaBestOpen.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaBestOpen.CanBlink = true;
			this.intzaBestOpen.CanDrag = false;
			this.intzaBestOpen.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "No.";
			columnItem.ValueFormat = FormatType.RecordNumber;
			columnItem.Visible = true;
			columnItem.Width = 4;
			columnItem2.Alignment = StringAlignment.Near;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "stock";
			columnItem2.Text = "Symbol";
			columnItem2.ValueFormat = FormatType.Symbol;
			columnItem2.Visible = true;
			columnItem2.Width = 16;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "last";
			columnItem3.Text = "Last";
			columnItem3.ValueFormat = FormatType.Price;
			columnItem3.Visible = true;
			columnItem3.Width = 8;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "high";
			columnItem4.Text = "High";
			columnItem4.ValueFormat = FormatType.Price;
			columnItem4.Visible = true;
			columnItem4.Width = 8;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "low";
			columnItem5.Text = "Low";
			columnItem5.ValueFormat = FormatType.Price;
			columnItem5.Visible = true;
			columnItem5.Width = 8;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "avg";
			columnItem6.Text = "Avg";
			columnItem6.ValueFormat = FormatType.Price;
			columnItem6.Visible = true;
			columnItem6.Width = 9;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "open_volume";
			columnItem7.Text = "OpenVol-1";
			columnItem7.ValueFormat = FormatType.Volume;
			columnItem7.Visible = true;
			columnItem7.Width = 13;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "open_price";
			columnItem8.Text = "Open-1";
			columnItem8.ValueFormat = FormatType.Price;
			columnItem8.Visible = true;
			columnItem8.Width = 8;
			columnItem9.Alignment = StringAlignment.Far;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "prior";
			columnItem9.Text = "Prior";
			columnItem9.ValueFormat = FormatType.Price;
			columnItem9.Visible = true;
			columnItem9.Width = 8;
			columnItem10.Alignment = StringAlignment.Far;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.LightGray;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "chg";
			columnItem10.Text = "Chg";
			columnItem10.ValueFormat = FormatType.ChangePrice;
			columnItem10.Visible = true;
			columnItem10.Width = 9;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "pchg";
			columnItem11.Text = "%Chg";
			columnItem11.ValueFormat = FormatType.ChangePrice;
			columnItem11.Visible = true;
			columnItem11.Width = 9;
			this.intzaBestOpen.Columns.Add(columnItem);
			this.intzaBestOpen.Columns.Add(columnItem2);
			this.intzaBestOpen.Columns.Add(columnItem3);
			this.intzaBestOpen.Columns.Add(columnItem4);
			this.intzaBestOpen.Columns.Add(columnItem5);
			this.intzaBestOpen.Columns.Add(columnItem6);
			this.intzaBestOpen.Columns.Add(columnItem7);
			this.intzaBestOpen.Columns.Add(columnItem8);
			this.intzaBestOpen.Columns.Add(columnItem9);
			this.intzaBestOpen.Columns.Add(columnItem10);
			this.intzaBestOpen.Columns.Add(columnItem11);
			this.intzaBestOpen.CurrentScroll = 0;
			this.intzaBestOpen.FocusItemIndex = -1;
			this.intzaBestOpen.ForeColor = Color.Black;
			this.intzaBestOpen.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaBestOpen.HeaderPctHeight = 80f;
			this.intzaBestOpen.IsAutoRepaint = true;
			this.intzaBestOpen.IsDrawFullRow = false;
			this.intzaBestOpen.IsDrawGrid = true;
			this.intzaBestOpen.IsDrawHeader = true;
			this.intzaBestOpen.IsScrollable = true;
			this.intzaBestOpen.Location = new Point(59, 146);
			this.intzaBestOpen.MainColumn = "";
			this.intzaBestOpen.Name = "intzaBestOpen";
			this.intzaBestOpen.Rows = 45;
			this.intzaBestOpen.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.intzaBestOpen.RowSelectType = 2;
			this.intzaBestOpen.RowsVisible = 40;
			this.intzaBestOpen.Size = new Size(697, 38);
			this.intzaBestOpen.SortColumnName = "";
			this.intzaBestOpen.SortType = SortType.Desc;
			this.intzaBestOpen.TabIndex = 1;
			this.intzaBestOpen.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaBestOpen_TableMouseClick);
			this.intzaProjectedOpen.AllowDrop = true;
			this.intzaProjectedOpen.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaProjectedOpen.CanBlink = true;
			this.intzaProjectedOpen.CanDrag = false;
			this.intzaProjectedOpen.CanGetMouseMove = false;
			columnItem12.Alignment = StringAlignment.Center;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "no";
			columnItem12.Text = "No.";
			columnItem12.ValueFormat = FormatType.RecordNumber;
			columnItem12.Visible = true;
			columnItem12.Width = 4;
			columnItem13.Alignment = StringAlignment.Near;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.ColumnAlignment = StringAlignment.Center;
			columnItem13.FontColor = Color.LightGray;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "stock";
			columnItem13.Text = "Symbol";
			columnItem13.ValueFormat = FormatType.Symbol;
			columnItem13.Visible = true;
			columnItem13.Width = 16;
			columnItem14.Alignment = StringAlignment.Far;
			columnItem14.BackColor = Color.FromArgb(64, 64, 64);
			columnItem14.ColumnAlignment = StringAlignment.Center;
			columnItem14.FontColor = Color.LightGray;
			columnItem14.MyStyle = FontStyle.Regular;
			columnItem14.Name = "avg";
			columnItem14.Text = "Avg";
			columnItem14.ValueFormat = FormatType.Price;
			columnItem14.Visible = true;
			columnItem14.Width = 8;
			columnItem15.Alignment = StringAlignment.Far;
			columnItem15.BackColor = Color.FromArgb(64, 64, 64);
			columnItem15.ColumnAlignment = StringAlignment.Center;
			columnItem15.FontColor = Color.LightGray;
			columnItem15.MyStyle = FontStyle.Regular;
			columnItem15.Name = "high";
			columnItem15.Text = "High";
			columnItem15.ValueFormat = FormatType.Price;
			columnItem15.Visible = true;
			columnItem15.Width = 8;
			columnItem16.Alignment = StringAlignment.Far;
			columnItem16.BackColor = Color.FromArgb(64, 64, 64);
			columnItem16.ColumnAlignment = StringAlignment.Center;
			columnItem16.FontColor = Color.LightGray;
			columnItem16.MyStyle = FontStyle.Regular;
			columnItem16.Name = "low";
			columnItem16.Text = "Low";
			columnItem16.ValueFormat = FormatType.Price;
			columnItem16.Visible = true;
			columnItem16.Width = 8;
			columnItem17.Alignment = StringAlignment.Far;
			columnItem17.BackColor = Color.FromArgb(64, 64, 64);
			columnItem17.ColumnAlignment = StringAlignment.Center;
			columnItem17.FontColor = Color.LightGray;
			columnItem17.MyStyle = FontStyle.Regular;
			columnItem17.Name = "open1";
			columnItem17.Text = "Open-1";
			columnItem17.ValueFormat = FormatType.Price;
			columnItem17.Visible = true;
			columnItem17.Width = 8;
			columnItem18.Alignment = StringAlignment.Far;
			columnItem18.BackColor = Color.FromArgb(64, 64, 64);
			columnItem18.ColumnAlignment = StringAlignment.Center;
			columnItem18.FontColor = Color.LightGray;
			columnItem18.MyStyle = FontStyle.Regular;
			columnItem18.Name = "ovolume1";
			columnItem18.Text = "OpenVol-1";
			columnItem18.ValueFormat = FormatType.Volume;
			columnItem18.Visible = true;
			columnItem18.Width = 14;
			columnItem19.Alignment = StringAlignment.Far;
			columnItem19.BackColor = Color.FromArgb(64, 64, 64);
			columnItem19.ColumnAlignment = StringAlignment.Center;
			columnItem19.FontColor = Color.LightGray;
			columnItem19.MyStyle = FontStyle.Regular;
			columnItem19.Name = "prior";
			columnItem19.Text = "Prior";
			columnItem19.ValueFormat = FormatType.Text;
			columnItem19.Visible = true;
			columnItem19.Width = 8;
			columnItem20.Alignment = StringAlignment.Far;
			columnItem20.BackColor = Color.FromArgb(64, 64, 64);
			columnItem20.ColumnAlignment = StringAlignment.Center;
			columnItem20.FontColor = Color.LightGray;
			columnItem20.MyStyle = FontStyle.Regular;
			columnItem20.Name = "po";
			columnItem20.Text = "PrjOpn";
			columnItem20.ValueFormat = FormatType.Price;
			columnItem20.Visible = true;
			columnItem20.Width = 8;
			columnItem21.Alignment = StringAlignment.Far;
			columnItem21.BackColor = Color.FromArgb(64, 64, 64);
			columnItem21.ColumnAlignment = StringAlignment.Center;
			columnItem21.FontColor = Color.LightGray;
			columnItem21.MyStyle = FontStyle.Regular;
			columnItem21.Name = "chg";
			columnItem21.Text = "Chg";
			columnItem21.ValueFormat = FormatType.ChangePrice;
			columnItem21.Visible = true;
			columnItem21.Width = 9;
			columnItem22.Alignment = StringAlignment.Far;
			columnItem22.BackColor = Color.FromArgb(64, 64, 64);
			columnItem22.ColumnAlignment = StringAlignment.Center;
			columnItem22.FontColor = Color.LightGray;
			columnItem22.MyStyle = FontStyle.Regular;
			columnItem22.Name = "pchg";
			columnItem22.Text = "%Chg";
			columnItem22.ValueFormat = FormatType.ChangePrice;
			columnItem22.Visible = true;
			columnItem22.Width = 9;
			this.intzaProjectedOpen.Columns.Add(columnItem12);
			this.intzaProjectedOpen.Columns.Add(columnItem13);
			this.intzaProjectedOpen.Columns.Add(columnItem14);
			this.intzaProjectedOpen.Columns.Add(columnItem15);
			this.intzaProjectedOpen.Columns.Add(columnItem16);
			this.intzaProjectedOpen.Columns.Add(columnItem17);
			this.intzaProjectedOpen.Columns.Add(columnItem18);
			this.intzaProjectedOpen.Columns.Add(columnItem19);
			this.intzaProjectedOpen.Columns.Add(columnItem20);
			this.intzaProjectedOpen.Columns.Add(columnItem21);
			this.intzaProjectedOpen.Columns.Add(columnItem22);
			this.intzaProjectedOpen.CurrentScroll = 0;
			this.intzaProjectedOpen.FocusItemIndex = -1;
			this.intzaProjectedOpen.ForeColor = Color.Black;
			this.intzaProjectedOpen.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaProjectedOpen.HeaderPctHeight = 80f;
			this.intzaProjectedOpen.IsAutoRepaint = true;
			this.intzaProjectedOpen.IsDrawFullRow = false;
			this.intzaProjectedOpen.IsDrawGrid = true;
			this.intzaProjectedOpen.IsDrawHeader = true;
			this.intzaProjectedOpen.IsScrollable = true;
			this.intzaProjectedOpen.Location = new Point(59, 205);
			this.intzaProjectedOpen.MainColumn = "";
			this.intzaProjectedOpen.Name = "intzaProjectedOpen";
			this.intzaProjectedOpen.Rows = 45;
			this.intzaProjectedOpen.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.intzaProjectedOpen.RowSelectType = 2;
			this.intzaProjectedOpen.RowsVisible = 40;
			this.intzaProjectedOpen.Size = new Size(705, 53);
			this.intzaProjectedOpen.SortColumnName = "";
			this.intzaProjectedOpen.SortType = SortType.Desc;
			this.intzaProjectedOpen.TabIndex = 2;
			this.intzaProjectedOpen.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaProjectedOpen_TableMouseClick);
			this.intzaProjectedClose.AllowDrop = true;
			this.intzaProjectedClose.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaProjectedClose.CanBlink = true;
			this.intzaProjectedClose.CanDrag = false;
			this.intzaProjectedClose.CanGetMouseMove = false;
			columnItem23.Alignment = StringAlignment.Center;
			columnItem23.BackColor = Color.FromArgb(64, 64, 64);
			columnItem23.ColumnAlignment = StringAlignment.Center;
			columnItem23.FontColor = Color.LightGray;
			columnItem23.MyStyle = FontStyle.Regular;
			columnItem23.Name = "no";
			columnItem23.Text = "No.";
			columnItem23.ValueFormat = FormatType.RecordNumber;
			columnItem23.Visible = true;
			columnItem23.Width = 4;
			columnItem24.Alignment = StringAlignment.Near;
			columnItem24.BackColor = Color.FromArgb(64, 64, 64);
			columnItem24.ColumnAlignment = StringAlignment.Center;
			columnItem24.FontColor = Color.LightGray;
			columnItem24.MyStyle = FontStyle.Regular;
			columnItem24.Name = "stock";
			columnItem24.Text = "Symbol";
			columnItem24.ValueFormat = FormatType.Symbol;
			columnItem24.Visible = true;
			columnItem24.Width = 16;
			columnItem25.Alignment = StringAlignment.Far;
			columnItem25.BackColor = Color.FromArgb(64, 64, 64);
			columnItem25.ColumnAlignment = StringAlignment.Center;
			columnItem25.FontColor = Color.LightGray;
			columnItem25.MyStyle = FontStyle.Regular;
			columnItem25.Name = "avg";
			columnItem25.Text = "Avg";
			columnItem25.ValueFormat = FormatType.Price;
			columnItem25.Visible = true;
			columnItem25.Width = 10;
			columnItem26.Alignment = StringAlignment.Far;
			columnItem26.BackColor = Color.FromArgb(64, 64, 64);
			columnItem26.ColumnAlignment = StringAlignment.Center;
			columnItem26.FontColor = Color.LightGray;
			columnItem26.MyStyle = FontStyle.Regular;
			columnItem26.Name = "high";
			columnItem26.Text = "High";
			columnItem26.ValueFormat = FormatType.Price;
			columnItem26.Visible = true;
			columnItem26.Width = 10;
			columnItem27.Alignment = StringAlignment.Far;
			columnItem27.BackColor = Color.FromArgb(64, 64, 64);
			columnItem27.ColumnAlignment = StringAlignment.Center;
			columnItem27.FontColor = Color.LightGray;
			columnItem27.MyStyle = FontStyle.Regular;
			columnItem27.Name = "low";
			columnItem27.Text = "Low";
			columnItem27.ValueFormat = FormatType.Price;
			columnItem27.Visible = true;
			columnItem27.Width = 10;
			columnItem28.Alignment = StringAlignment.Far;
			columnItem28.BackColor = Color.FromArgb(64, 64, 64);
			columnItem28.ColumnAlignment = StringAlignment.Center;
			columnItem28.FontColor = Color.LightGray;
			columnItem28.MyStyle = FontStyle.Regular;
			columnItem28.Name = "prior";
			columnItem28.Text = "Prior";
			columnItem28.ValueFormat = FormatType.Price;
			columnItem28.Visible = true;
			columnItem28.Width = 10;
			columnItem29.Alignment = StringAlignment.Far;
			columnItem29.BackColor = Color.FromArgb(64, 64, 64);
			columnItem29.ColumnAlignment = StringAlignment.Center;
			columnItem29.FontColor = Color.LightGray;
			columnItem29.MyStyle = FontStyle.Regular;
			columnItem29.Name = "last";
			columnItem29.Text = "Last";
			columnItem29.ValueFormat = FormatType.Price;
			columnItem29.Visible = true;
			columnItem29.Width = 10;
			columnItem30.Alignment = StringAlignment.Far;
			columnItem30.BackColor = Color.FromArgb(64, 64, 64);
			columnItem30.ColumnAlignment = StringAlignment.Center;
			columnItem30.FontColor = Color.LightGray;
			columnItem30.MyStyle = FontStyle.Regular;
			columnItem30.Name = "poclose";
			columnItem30.Text = "PrjCls";
			columnItem30.ValueFormat = FormatType.Price;
			columnItem30.Visible = true;
			columnItem30.Width = 10;
			columnItem31.Alignment = StringAlignment.Far;
			columnItem31.BackColor = Color.FromArgb(64, 64, 64);
			columnItem31.ColumnAlignment = StringAlignment.Center;
			columnItem31.FontColor = Color.LightGray;
			columnItem31.MyStyle = FontStyle.Regular;
			columnItem31.Name = "chg";
			columnItem31.Text = "Chg";
			columnItem31.ValueFormat = FormatType.ChangePrice;
			columnItem31.Visible = true;
			columnItem31.Width = 10;
			columnItem32.Alignment = StringAlignment.Far;
			columnItem32.BackColor = Color.FromArgb(64, 64, 64);
			columnItem32.ColumnAlignment = StringAlignment.Center;
			columnItem32.FontColor = Color.LightGray;
			columnItem32.MyStyle = FontStyle.Regular;
			columnItem32.Name = "pchg";
			columnItem32.Text = "%Chg";
			columnItem32.ValueFormat = FormatType.ChangePrice;
			columnItem32.Visible = true;
			columnItem32.Width = 10;
			this.intzaProjectedClose.Columns.Add(columnItem23);
			this.intzaProjectedClose.Columns.Add(columnItem24);
			this.intzaProjectedClose.Columns.Add(columnItem25);
			this.intzaProjectedClose.Columns.Add(columnItem26);
			this.intzaProjectedClose.Columns.Add(columnItem27);
			this.intzaProjectedClose.Columns.Add(columnItem28);
			this.intzaProjectedClose.Columns.Add(columnItem29);
			this.intzaProjectedClose.Columns.Add(columnItem30);
			this.intzaProjectedClose.Columns.Add(columnItem31);
			this.intzaProjectedClose.Columns.Add(columnItem32);
			this.intzaProjectedClose.CurrentScroll = 0;
			this.intzaProjectedClose.FocusItemIndex = -1;
			this.intzaProjectedClose.ForeColor = Color.Black;
			this.intzaProjectedClose.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaProjectedClose.HeaderPctHeight = 80f;
			this.intzaProjectedClose.IsAutoRepaint = true;
			this.intzaProjectedClose.IsDrawFullRow = false;
			this.intzaProjectedClose.IsDrawGrid = true;
			this.intzaProjectedClose.IsDrawHeader = true;
			this.intzaProjectedClose.IsScrollable = true;
			this.intzaProjectedClose.Location = new Point(59, 286);
			this.intzaProjectedClose.MainColumn = "";
			this.intzaProjectedClose.Name = "intzaProjectedClose";
			this.intzaProjectedClose.Rows = 45;
			this.intzaProjectedClose.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.intzaProjectedClose.RowSelectType = 2;
			this.intzaProjectedClose.RowsVisible = 40;
			this.intzaProjectedClose.Size = new Size(705, 46);
			this.intzaProjectedClose.SortColumnName = "";
			this.intzaProjectedClose.SortType = SortType.Desc;
			this.intzaProjectedClose.TabIndex = 3;
			this.intzaProjectedClose.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaProjectedClose_TableMouseClick);
			this.intzaTopActive.AllowDrop = true;
			this.intzaTopActive.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaTopActive.CanBlink = true;
			this.intzaTopActive.CanDrag = false;
			this.intzaTopActive.CanGetMouseMove = false;
			columnItem33.Alignment = StringAlignment.Center;
			columnItem33.BackColor = Color.FromArgb(64, 64, 64);
			columnItem33.ColumnAlignment = StringAlignment.Center;
			columnItem33.FontColor = Color.LightGray;
			columnItem33.MyStyle = FontStyle.Regular;
			columnItem33.Name = "No";
			columnItem33.Text = "No.";
			columnItem33.ValueFormat = FormatType.RecordNumber;
			columnItem33.Visible = true;
			columnItem33.Width = 4;
			columnItem34.Alignment = StringAlignment.Near;
			columnItem34.BackColor = Color.FromArgb(64, 64, 64);
			columnItem34.ColumnAlignment = StringAlignment.Center;
			columnItem34.FontColor = Color.LightGray;
			columnItem34.MyStyle = FontStyle.Regular;
			columnItem34.Name = "stock";
			columnItem34.Text = "Symbol";
			columnItem34.ValueFormat = FormatType.Symbol;
			columnItem34.Visible = true;
			columnItem34.Width = 11;
			columnItem35.Alignment = StringAlignment.Far;
			columnItem35.BackColor = Color.FromArgb(64, 64, 64);
			columnItem35.ColumnAlignment = StringAlignment.Center;
			columnItem35.FontColor = Color.LightGray;
			columnItem35.MyStyle = FontStyle.Regular;
			columnItem35.Name = "deals";
			columnItem35.Text = "Deals";
			columnItem35.ValueFormat = FormatType.Volume;
			columnItem35.Visible = true;
			columnItem35.Width = 6;
			columnItem36.Alignment = StringAlignment.Far;
			columnItem36.BackColor = Color.FromArgb(64, 64, 64);
			columnItem36.ColumnAlignment = StringAlignment.Center;
			columnItem36.FontColor = Color.LightGray;
			columnItem36.MyStyle = FontStyle.Regular;
			columnItem36.Name = "volume";
			columnItem36.Text = "Volume";
			columnItem36.ValueFormat = FormatType.Volume;
			columnItem36.Visible = true;
			columnItem36.Width = 11;
			columnItem37.Alignment = StringAlignment.Far;
			columnItem37.BackColor = Color.FromArgb(64, 64, 64);
			columnItem37.ColumnAlignment = StringAlignment.Center;
			columnItem37.FontColor = Color.LightGray;
			columnItem37.MyStyle = FontStyle.Regular;
			columnItem37.Name = "value";
			columnItem37.Text = "Value";
			columnItem37.ValueFormat = FormatType.Volume;
			columnItem37.Visible = true;
			columnItem37.Width = 12;
			columnItem38.Alignment = StringAlignment.Far;
			columnItem38.BackColor = Color.FromArgb(64, 64, 64);
			columnItem38.ColumnAlignment = StringAlignment.Center;
			columnItem38.FontColor = Color.LightGray;
			columnItem38.MyStyle = FontStyle.Regular;
			columnItem38.Name = "avg";
			columnItem38.Text = "Avg";
			columnItem38.ValueFormat = FormatType.Price;
			columnItem38.Visible = true;
			columnItem38.Width = 7;
			columnItem39.Alignment = StringAlignment.Far;
			columnItem39.BackColor = Color.FromArgb(64, 64, 64);
			columnItem39.ColumnAlignment = StringAlignment.Center;
			columnItem39.FontColor = Color.LightGray;
			columnItem39.MyStyle = FontStyle.Regular;
			columnItem39.Name = "high";
			columnItem39.Text = "High";
			columnItem39.ValueFormat = FormatType.Price;
			columnItem39.Visible = true;
			columnItem39.Width = 7;
			columnItem40.Alignment = StringAlignment.Far;
			columnItem40.BackColor = Color.FromArgb(64, 64, 64);
			columnItem40.ColumnAlignment = StringAlignment.Center;
			columnItem40.FontColor = Color.LightGray;
			columnItem40.MyStyle = FontStyle.Regular;
			columnItem40.Name = "low";
			columnItem40.Text = "Low";
			columnItem40.ValueFormat = FormatType.Price;
			columnItem40.Visible = true;
			columnItem40.Width = 7;
			columnItem41.Alignment = StringAlignment.Far;
			columnItem41.BackColor = Color.FromArgb(64, 64, 64);
			columnItem41.ColumnAlignment = StringAlignment.Center;
			columnItem41.FontColor = Color.LightGray;
			columnItem41.MyStyle = FontStyle.Regular;
			columnItem41.Name = "last";
			columnItem41.Text = "Last";
			columnItem41.ValueFormat = FormatType.Price;
			columnItem41.Visible = true;
			columnItem41.Width = 7;
			columnItem42.Alignment = StringAlignment.Far;
			columnItem42.BackColor = Color.FromArgb(64, 64, 64);
			columnItem42.ColumnAlignment = StringAlignment.Center;
			columnItem42.FontColor = Color.LightGray;
			columnItem42.MyStyle = FontStyle.Regular;
			columnItem42.Name = "chg";
			columnItem42.Text = "Chg";
			columnItem42.ValueFormat = FormatType.ChangePrice;
			columnItem42.Visible = true;
			columnItem42.Width = 7;
			columnItem43.Alignment = StringAlignment.Far;
			columnItem43.BackColor = Color.FromArgb(64, 64, 64);
			columnItem43.ColumnAlignment = StringAlignment.Center;
			columnItem43.FontColor = Color.LightGray;
			columnItem43.MyStyle = FontStyle.Regular;
			columnItem43.Name = "pchg";
			columnItem43.Text = "%Chg";
			columnItem43.ValueFormat = FormatType.ChangePrice;
			columnItem43.Visible = true;
			columnItem43.Width = 7;
			columnItem44.Alignment = StringAlignment.Far;
			columnItem44.BackColor = Color.FromArgb(64, 64, 64);
			columnItem44.ColumnAlignment = StringAlignment.Center;
			columnItem44.FontColor = Color.LightGray;
			columnItem44.MyStyle = FontStyle.Regular;
			columnItem44.Name = "swing";
			columnItem44.Text = "Swing";
			columnItem44.ValueFormat = FormatType.Price;
			columnItem44.Visible = true;
			columnItem44.Width = 7;
			columnItem45.Alignment = StringAlignment.Far;
			columnItem45.BackColor = Color.FromArgb(64, 64, 64);
			columnItem45.ColumnAlignment = StringAlignment.Center;
			columnItem45.FontColor = Color.LightGray;
			columnItem45.MyStyle = FontStyle.Regular;
			columnItem45.Name = "pswing";
			columnItem45.Text = "%Swing";
			columnItem45.ValueFormat = FormatType.Price;
			columnItem45.Visible = true;
			columnItem45.Width = 7;
			this.intzaTopActive.Columns.Add(columnItem33);
			this.intzaTopActive.Columns.Add(columnItem34);
			this.intzaTopActive.Columns.Add(columnItem35);
			this.intzaTopActive.Columns.Add(columnItem36);
			this.intzaTopActive.Columns.Add(columnItem37);
			this.intzaTopActive.Columns.Add(columnItem38);
			this.intzaTopActive.Columns.Add(columnItem39);
			this.intzaTopActive.Columns.Add(columnItem40);
			this.intzaTopActive.Columns.Add(columnItem41);
			this.intzaTopActive.Columns.Add(columnItem42);
			this.intzaTopActive.Columns.Add(columnItem43);
			this.intzaTopActive.Columns.Add(columnItem44);
			this.intzaTopActive.Columns.Add(columnItem45);
			this.intzaTopActive.CurrentScroll = 0;
			this.intzaTopActive.FocusItemIndex = -1;
			this.intzaTopActive.ForeColor = Color.Black;
			this.intzaTopActive.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaTopActive.HeaderPctHeight = 80f;
			this.intzaTopActive.IsAutoRepaint = true;
			this.intzaTopActive.IsDrawFullRow = false;
			this.intzaTopActive.IsDrawGrid = true;
			this.intzaTopActive.IsDrawHeader = true;
			this.intzaTopActive.IsScrollable = true;
			this.intzaTopActive.Location = new Point(29, 354);
			this.intzaTopActive.MainColumn = "stock";
			this.intzaTopActive.Name = "intzaTopActive";
			this.intzaTopActive.Rows = 45;
			this.intzaTopActive.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.intzaTopActive.RowSelectType = 2;
			this.intzaTopActive.RowsVisible = 40;
			this.intzaTopActive.Size = new Size(708, 55);
			this.intzaTopActive.SortColumnName = "pchg";
			this.intzaTopActive.SortType = SortType.Desc;
			this.intzaTopActive.TabIndex = 4;
			this.intzaTopActive.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaTopActive_TableMouseClick);
			this.contextLink.Items.AddRange(new ToolStripItem[]
			{
				this.tsmCallHistoricalChart,
				this.tsmCallNews,
				this.tsmCallFinance,
				this.toolStripMenuItem1,
				this.tsmCallMarketWatch,
				this.tsmCallStockInPlay,
				this.tsmCallSaleByPrice,
				this.tsmCallSaleByTime,
				this.tsmCallOddlot
			});
			this.contextLink.Name = "contextMenuStrip1";
			this.contextLink.Size = new Size(153, 208);
			this.contextLink.Opening += new CancelEventHandler(this.contextLink_Opening);
			this.tsmCallHistoricalChart.Name = "tsmCallHistoricalChart";
			this.tsmCallHistoricalChart.Size = new Size(152, 22);
			this.tsmCallHistoricalChart.Text = "Graph";
			this.tsmCallHistoricalChart.Click += new EventHandler(this.tsmCallHistoricalChart_Click);
			this.tsmCallNews.Name = "tsmCallNews";
			this.tsmCallNews.Size = new Size(152, 22);
			this.tsmCallNews.Text = "News";
			this.tsmCallNews.Click += new EventHandler(this.tsmCallNews_Click);
			this.tsmCallFinance.Name = "tsmCallFinance";
			this.tsmCallFinance.Size = new Size(152, 22);
			this.tsmCallFinance.Text = "Finance";
			this.tsmCallFinance.Click += new EventHandler(this.tsmCallFinance_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(149, 6);
			this.tsmCallMarketWatch.Name = "tsmCallMarketWatch";
			this.tsmCallMarketWatch.Size = new Size(152, 22);
			this.tsmCallMarketWatch.Text = "Market Watch";
			this.tsmCallMarketWatch.Click += new EventHandler(this.tsmCallMarketWatch_Click);
			this.tsmCallStockInPlay.Name = "tsmCallStockInPlay";
			this.tsmCallStockInPlay.Size = new Size(152, 22);
			this.tsmCallStockInPlay.Text = "Stock in Play";
			this.tsmCallStockInPlay.Click += new EventHandler(this.tsmCallStockSummary_Click);
			this.tsmCallSaleByPrice.Name = "tsmCallSaleByPrice";
			this.tsmCallSaleByPrice.Size = new Size(152, 22);
			this.tsmCallSaleByPrice.Text = "Sale by Price";
			this.tsmCallSaleByPrice.Click += new EventHandler(this.tsmCallSaleByPrice_Click);
			this.tsmCallSaleByTime.Name = "tsmCallSaleByTime";
			this.tsmCallSaleByTime.Size = new Size(152, 22);
			this.tsmCallSaleByTime.Text = "Sale by Time";
			this.tsmCallSaleByTime.Click += new EventHandler(this.tsmCallSaleByTime_Click);
			this.tsmCallOddlot.Name = "tsmCallOddlot";
			this.tsmCallOddlot.Size = new Size(152, 22);
			this.tsmCallOddlot.Text = "View Oddlot";
			this.tsmCallOddlot.Click += new EventHandler(this.tsmCallOddlot_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(1252, 421);
			base.Controls.Add(this.intzaBestOpen);
			base.Controls.Add(this.intzaProjectedOpen);
			base.Controls.Add(this.intzaProjectedClose);
			base.Controls.Add(this.intzaTopActive);
			base.Controls.Add(this.tStripMenu);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "frmStockRanking";
			this.Text = "Stock Ranking";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmStockRanking_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmStockRanking_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmStockRanking_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmStockRanking_IDoCustomSizeChanged);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmStockRanking_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmStockRanking_IDoReActivated);
			base.Controls.SetChildIndex(this.tStripMenu, 0);
			base.Controls.SetChildIndex(this.intzaTopActive, 0);
			base.Controls.SetChildIndex(this.intzaProjectedClose, 0);
			base.Controls.SetChildIndex(this.intzaProjectedOpen, 0);
			base.Controls.SetChildIndex(this.intzaBestOpen, 0);
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			this.contextLink.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400051C RID: 1308
		private string currentPage;

		// Token: 0x0400051D RID: 1309
		private int maxRecordTopActive;

		// Token: 0x0400051E RID: 1310
		private int maxTopTopActive;

		// Token: 0x0400051F RID: 1311
		private frmStockRanking.RecordData recDataRealTimeTopActive;

		// Token: 0x04000520 RID: 1312
		private SortType sortTypeTopActive;

		// Token: 0x04000521 RID: 1313
		private string sortByNameTopActive;

		// Token: 0x04000522 RID: 1314
		private string marketIdTopActive;

		// Token: 0x04000523 RID: 1315
		private frmStockRanking.ActiveGroupTypes activeGroupTypeTopActive;

		// Token: 0x04000524 RID: 1316
		private BackgroundWorker bgwTopActiveLoadData;

		// Token: 0x04000525 RID: 1317
		private DataSet dsTopActive;

		// Token: 0x04000526 RID: 1318
		private int maxRecordProjectedOpenPrice;

		// Token: 0x04000527 RID: 1319
		private string marketIdProjectedOpenPrice;

		// Token: 0x04000528 RID: 1320
		private frmStockRanking.BoardTypes boardTypeProjectedOpenPrice;

		// Token: 0x04000529 RID: 1321
		private string compareModeProjectedOpenPrice;

		// Token: 0x0400052A RID: 1322
		private BackgroundWorker bgwProjectedOpenPriceLoadData;

		// Token: 0x0400052B RID: 1323
		private DataSet dsProjectedOpenPrice;

		// Token: 0x0400052C RID: 1324
		private int maxRecordProjectedClosePrice;

		// Token: 0x0400052D RID: 1325
		private string marketIdProjectedClosePrice;

		// Token: 0x0400052E RID: 1326
		private frmStockRanking.BoardTypes boardTypeProjectedClosePrice;

		// Token: 0x0400052F RID: 1327
		private string compareModeProjectedClosePrice;

		// Token: 0x04000530 RID: 1328
		private BackgroundWorker bgwProjectedClosePriceLoadData;

		// Token: 0x04000531 RID: 1329
		private DataSet dsProjectedClosePrice;

		// Token: 0x04000532 RID: 1330
		private string marketIdBestOpenPrice;

		// Token: 0x04000533 RID: 1331
		private int maxRecordBestOpenPrice;

		// Token: 0x04000534 RID: 1332
		private frmStockRanking.BoardTypes boardTypeBestOpenPrice;

		// Token: 0x04000535 RID: 1333
		private int openSessionBestOpenPrice;

		// Token: 0x04000536 RID: 1334
		private string compareModeBestOpenPrice;

		// Token: 0x04000537 RID: 1335
		private BackgroundWorker bgwBestOpenPriceLoadData;

		// Token: 0x04000538 RID: 1336
		private DataSet dsBestOpenPrice;

		// Token: 0x04000539 RID: 1337
		private IContainer components;

		// Token: 0x0400053A RID: 1338
		private ToolStrip tStripMenu;

		// Token: 0x0400053B RID: 1339
		private ToolStripComboBox tscbTopActiveType;

		// Token: 0x0400053C RID: 1340
		private ToolStripComboBox tscbTopActiveMkt;

		// Token: 0x0400053D RID: 1341
		private ToolStripLabel tslbTopActiveMkt;

		// Token: 0x0400053E RID: 1342
		private ToolStripLabel tslbTopActiveType;

		// Token: 0x0400053F RID: 1343
		private ToolStripLabel toolStripLabel10;

		// Token: 0x04000540 RID: 1344
		private ToolStripComboBox tscbSelection;

		// Token: 0x04000541 RID: 1345
		private ToolStripLabel tslbBoard;

		// Token: 0x04000542 RID: 1346
		private ToolStripComboBox tscbBoard;

		// Token: 0x04000543 RID: 1347
		private ToolStripLabel tslbSort;

		// Token: 0x04000544 RID: 1348
		private ToolStripComboBox tscbSort;

		// Token: 0x04000545 RID: 1349
		private ToolStripLabel tslbBestOpenMktSession;

		// Token: 0x04000546 RID: 1350
		private ToolStripComboBox tscbBestOpenMktSession;

		// Token: 0x04000547 RID: 1351
		private SortGrid intzaTopActive;

		// Token: 0x04000548 RID: 1352
		private SortGrid intzaProjectedClose;

		// Token: 0x04000549 RID: 1353
		private SortGrid intzaProjectedOpen;

		// Token: 0x0400054A RID: 1354
		private SortGrid intzaBestOpen;

		// Token: 0x0400054B RID: 1355
		private ContextMenuStrip contextLink;

		// Token: 0x0400054C RID: 1356
		private ToolStripMenuItem tsmCallHistoricalChart;

		// Token: 0x0400054D RID: 1357
		private ToolStripMenuItem tsmCallNews;

		// Token: 0x0400054E RID: 1358
		private ToolStripMenuItem tsmCallStockInPlay;

		// Token: 0x0400054F RID: 1359
		private ToolStripMenuItem tsmCallSaleByPrice;

		// Token: 0x04000550 RID: 1360
		private ToolStripMenuItem tsmCallSaleByTime;

		// Token: 0x04000551 RID: 1361
		private ToolStripMenuItem tsmCallOddlot;

		// Token: 0x04000552 RID: 1362
		private ToolStripSeparator toolStripMenuItem1;

		// Token: 0x04000553 RID: 1363
		private ToolStripMenuItem tsmCallMarketWatch;

		// Token: 0x04000554 RID: 1364
		private ToolStripMenuItem tsmCallFinance;

		// Token: 0x020000B3 RID: 179
		private enum ActiveGroupTypes
		{
			// Token: 0x04000556 RID: 1366
			None,
			// Token: 0x04000557 RID: 1367
			MostActive_Main,
			// Token: 0x04000558 RID: 1368
			MostActive_Foreign,
			// Token: 0x04000559 RID: 1369
			MostActive_BigLot,
			// Token: 0x0400055A RID: 1370
			Gainer_Main,
			// Token: 0x0400055B RID: 1371
			Gainer_Foreign,
			// Token: 0x0400055C RID: 1372
			Loser_Main,
			// Token: 0x0400055D RID: 1373
			Loser_Foreign,
			// Token: 0x0400055E RID: 1374
			MostSwing_Main,
			// Token: 0x0400055F RID: 1375
			MostSwing_Foreign
		}

		// Token: 0x020000B4 RID: 180
		public struct RecordData
		{
			// Token: 0x04000560 RID: 1376
			public int StockNumber;

			// Token: 0x04000561 RID: 1377
			public string Stock;

			// Token: 0x04000562 RID: 1378
			public string DisplayFlag;

			// Token: 0x04000563 RID: 1379
			public int Deals;

			// Token: 0x04000564 RID: 1380
			public long AccVolume;

			// Token: 0x04000565 RID: 1381
			public decimal AccValue;

			// Token: 0x04000566 RID: 1382
			public decimal HighPrice;

			// Token: 0x04000567 RID: 1383
			public decimal LowPrice;

			// Token: 0x04000568 RID: 1384
			public decimal LastPrice;

			// Token: 0x04000569 RID: 1385
			public decimal Prior;

			// Token: 0x0400056A RID: 1386
			public decimal ChangePrice;

			// Token: 0x0400056B RID: 1387
			public decimal ChangePricePct;

			// Token: 0x0400056C RID: 1388
			public decimal Swing;

			// Token: 0x0400056D RID: 1389
			public decimal SwingPct;
		}

		// Token: 0x020000B5 RID: 181
		private enum BoardTypes
		{
			// Token: 0x0400056F RID: 1391
			M,
			// Token: 0x04000570 RID: 1392
			F
		}

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000882 RID: 2178
		private delegate void TopActiveUpdateUIReloadDataCallback(frmStockRanking.ActiveGroupTypes activeGroupType);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000886 RID: 2182
		private delegate void TopActiveUpdateToGridCallBack(int rowIndex, frmStockRanking.RecordData recordData, StockList.StockInformation realStockInfo);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x0600088A RID: 2186
		private delegate void TopActiveUpdateRealTimesCallBack(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo);
	}
}
