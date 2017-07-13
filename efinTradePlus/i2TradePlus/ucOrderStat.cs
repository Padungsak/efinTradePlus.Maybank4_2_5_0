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
using ITSNet.Common.BIZ;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x02000031 RID: 49
	public class ucOrderStat : UserControl
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00025070 File Offset: 0x00023470
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ucOrderStat()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.bgwPortStat = null;
			this.bgwPortStatByStock = null;
			this._isInit = false;
			this._currAccount = string.Empty;
			this.tdsPortStat = null;
			this._startDate = string.Empty;
			this._endDate = string.Empty;
			this.tdsPortStatByStock = null;
			this.isLoadingData = false;
			this.tmCloseSplash = null;
			this._mcPos = 0;
			this.components = null;
			base..ctor();
			try
			{
				this.InitializeComponent();
				if (!base.DesignMode)
				{
					this.bgwPortStat = new BackgroundWorker();
					this.bgwPortStat.WorkerReportsProgress = true;
					this.bgwPortStat.DoWork += new DoWorkEventHandler(this.bgwPortStat_DoWork);
					this.bgwPortStat.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwPortStat_RunWorkerCompleted);
					this.bgwPortStatByStock = new BackgroundWorker();
					this.bgwPortStatByStock.WorkerReportsProgress = true;
					this.bgwPortStatByStock.DoWork += new DoWorkEventHandler(this.bgwPortStatByStock_DoWork);
					this.bgwPortStatByStock.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwPortStatByStock_RunWorkerCompleted);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000251BC File Offset: 0x000235BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetResize();
			base.Show();
			this.IsLoadingData = false;
			this.tstbStartDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			this.tstbEndDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			if (!this._isInit)
			{
				if (!this.bgwPortStat.IsBusy)
				{
					this.bgwPortStat.RunWorkerAsync();
				}
			}
			this._isInit = true;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00025260 File Offset: 0x00023660
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reload_AccountChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._currAccount != ApplicationInfo.AccInfo.CurrentAccount)
			{
				if (!this.bgwPortStat.IsBusy)
				{
					this.bgwPortStat.RunWorkerAsync();
				}
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000252BC File Offset: 0x000236BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetResize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tStripMenu.Font = Settings.Default.Default_Font;
				foreach (ToolStripItem toolStripItem in this.tStripMenu.Items)
				{
					toolStripItem.Font = Settings.Default.Default_Font;
				}
				this.tableStockList.Font = Settings.Default.Default_Font;
				this.tableDetail.Font = Settings.Default.Default_Font;
				this.intzaSum.Font = Settings.Default.Default_Font;
				this.tableStockList.SetBounds(0, this.tStripMenu.Top + this.tStripMenu.Height, (int)((double)base.Width * 0.27), base.Height - (this.tStripMenu.Top + this.tStripMenu.Height));
				this.tableDetail.SetBounds(this.tableStockList.Left + this.tableStockList.Width + 1, this.tableStockList.Top, base.Width - (this.tableStockList.Left + this.tableStockList.Width + 1), base.Height - (this.intzaSum.GetHeightByRows() + 1) - this.tableStockList.Top);
				this.intzaSum.SetBounds(this.tableDetail.Left, this.tableDetail.Top + this.tableDetail.Height + 1, this.tableDetail.Width, this.intzaSum.GetHeightByRows());
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000254F4 File Offset: 0x000238F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00025508 File Offset: 0x00023908
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender.GetType() == typeof(ToolStripTextBox))
				{
					((ToolStripTextBox)sender).BackColor = Color.Yellow;
					((ToolStripTextBox)sender).ForeColor = Color.Black;
					((ToolStripTextBox)sender).SelectAll();
				}
				else if (sender.GetType() == typeof(ToolStripComboBox))
				{
					((ToolStripComboBox)sender).BackColor = Color.Yellow;
					((ToolStripComboBox)sender).ForeColor = Color.Black;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("controlOrder_Enter", ex);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000255E4 File Offset: 0x000239E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender.GetType() == typeof(ToolStripTextBox))
				{
					((ToolStripTextBox)sender).BackColor = Color.FromArgb(45, 45, 45);
					((ToolStripTextBox)sender).ForeColor = Color.LightGray;
				}
				else if (sender.GetType() == typeof(ToolStripComboBox))
				{
					((ToolStripComboBox)sender).BackColor = Color.FromArgb(45, 45, 45);
					((ToolStripComboBox)sender).ForeColor = Color.LightGray;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("controlOrder_Leave", ex);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000256C0 File Offset: 0x00023AC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderHistory_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Space)
			{
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000256F8 File Offset: 0x00023AF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwPortStat_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.IsLoadingData = true;
				this._currAccount = ApplicationInfo.AccInfo.CurrentAccount;
				string portfolioStatAllStock = ApplicationInfo.WebService.GetPortfolioStatAllStock(this._currAccount, this._startDate, this._endDate);
				if (this.tdsPortStat == null)
				{
					this.tdsPortStat = new DataSet();
				}
				else
				{
					this.tdsPortStat.Clear();
				}
				if (!string.IsNullOrEmpty(portfolioStatAllStock))
				{
					MyDataHelper.StringToDataSet(portfolioStatAllStock, this.tdsPortStat);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwPortStat_DoWork", ex);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000257C0 File Offset: 0x00023BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwPortStat_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tableStockList.BeginUpdate();
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				string text = string.Empty;
				if (this.tdsPortStat.Tables.Contains("TABLE"))
				{
					foreach (DataRow dataRow in this.tdsPortStat.Tables["TABLE"].Rows)
					{
						text = dataRow["sSec"].ToString().Trim();
						if (dictionary.ContainsKey(text))
						{
							dictionary[text] = Convert.ToInt32(dataRow["iCount"].ToString().Trim());
						}
						else
						{
							dictionary.Add(text, Convert.ToInt32(dataRow["iCount"].ToString().Trim()));
						}
					}
				}
				if (this.tdsPortStat.Tables.Contains("TABLE_HIST"))
				{
					foreach (DataRow dataRow in this.tdsPortStat.Tables["TABLE_HIST"].Rows)
					{
						text = dataRow["sSec"].ToString().Trim();
						if (dictionary.ContainsKey(text))
						{
							Dictionary<string, int> dictionary2;
							string key;
							(dictionary2 = dictionary)[key = text] = dictionary2[key] + Convert.ToInt32(dataRow["iCount"].ToString().Trim());
						}
						else
						{
							dictionary.Add(text, Convert.ToInt32(dataRow["iCount"].ToString().Trim()));
						}
					}
				}
				this.tableStockList.Rows = dictionary.Count;
				int num = 0;
				foreach (KeyValuePair<string, int> current in dictionary)
				{
					this.tableStockList.Records(num).Fields("rowId").Text = num + 1;
					this.tableStockList.Records(num).Fields("stock").Text = current.Key;
					this.tableStockList.Records(num).Fields("deals").Text = current.Value;
					this.tableStockList.Records(num).Fields("rowId").FontColor = MyColor.UnChgColor;
					this.tableStockList.Records(num).Fields("stock").FontColor = MyColor.UnChgColor;
					this.tableStockList.Records(num).Fields("deals").FontColor = MyColor.UnChgColor;
					num++;
				}
				dictionary.Clear();
				dictionary = null;
				this.tableStockList.Redraw();
				this.tdsPortStat.Clear();
				if (this.tableStockList.Rows > 0)
				{
					this.tableStockList.FocusItemIndex = 0;
					this.LoadByStock(this.tableStockList.Records(0).Fields("stock").Text.ToString());
				}
				else
				{
					this.tableDetail.Rows = 0;
					this.tableDetail.Redraw();
					this.intzaSum.ClearAllText();
					this.intzaSum.Redraw();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwPortStat_RunWorkerCompleted", ex);
			}
			this.IsLoadingData = false;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00025C64 File Offset: 0x00024064
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwPortStatByStock_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.IsLoadingData = true;
				string portfolioStatByStock = ApplicationInfo.WebService.GetPortfolioStatByStock(this._currAccount, e.Argument.ToString(), this._startDate, this._endDate);
				if (this.tdsPortStatByStock == null)
				{
					this.tdsPortStatByStock = new DataSet();
				}
				else
				{
					this.tdsPortStat.Clear();
				}
				if (!string.IsNullOrEmpty(portfolioStatByStock))
				{
					MyDataHelper.StringToDataSet(portfolioStatByStock, this.tdsPortStatByStock);
					e.Result = e.Argument.ToString();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwPortStatByStock_DoWork", ex);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00025D3C File Offset: 0x0002413C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwPortStatByStock_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tableDetail.BeginUpdate();
				StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[e.Result.ToString()];
				this.tableDetail.Rows = this.tdsPortStatByStock.Tables[0].Rows.Count;
				long num = 0L;
				long num2 = 0L;
				long num3 = 0L;
				long num4 = 0L;
				decimal num5 = 0m;
				decimal num6 = 0m;
				long num7 = 0L;
				long num8 = 0L;
				int num9 = 0;
				int num10 = 0;
				string text = string.Empty;
				Color fontColor = MyColor.UnChgColor;
				Dictionary<decimal, ucOrderStat.OrderRecord> dictionary = new Dictionary<decimal, ucOrderStat.OrderRecord>();
				string name = string.Empty;
				for (int i = 1; i <= 2; i++)
				{
					name = "TABLE" + ((i - 1) * 2 + 1);
					if (this.tdsPortStatByStock.Tables.Contains(name))
					{
						foreach (DataRow dataRow in this.tdsPortStatByStock.Tables[name].Rows)
						{
							long num11;
							long.TryParse(dataRow["nmrVol"].ToString(), out num11);
							decimal key;
							decimal.TryParse(dataRow["nmrPriceForCrdt"].ToString(), out key);
							long num12;
							long.TryParse(dataRow["nmrLeaveVol"].ToString(), out num12);
							int num13;
							int.TryParse(dataRow["icount"].ToString(), out num13);
							text = dataRow["sSide"].ToString().Trim();
							ucOrderStat.OrderRecord value;
							if (!dictionary.ContainsKey(key))
							{
								value = default(ucOrderStat.OrderRecord);
								dictionary.Add(key, value);
							}
							else
							{
								value = dictionary[key];
							}
							if (text.Equals("B") || text.Equals("C"))
							{
								value.buyDeals += num13;
								value.buyVolume += num11;
								value.buyLeaveVolume += num12;
							}
							else
							{
								value.sellDeals += num13;
								value.sellVolume += num11;
								value.sellLeaveVolume += num12;
							}
							dictionary[key] = value;
						}
					}
					name = "TABLE" + ((i - 1) * 2 + 2);
					if (this.tdsPortStatByStock.Tables.Contains(name))
					{
						foreach (DataRow dataRow in this.tdsPortStatByStock.Tables[name].Rows)
						{
							decimal key;
							decimal.TryParse(dataRow["nmrPrice"].ToString(), out key);
							long num14;
							long.TryParse(dataRow["nmrVol"].ToString(), out num14);
							text = dataRow["sSide"].ToString().Trim();
							ucOrderStat.OrderRecord value;
							if (!dictionary.ContainsKey(key))
							{
								value = default(ucOrderStat.OrderRecord);
								dictionary.Add(key, value);
							}
							else
							{
								value = dictionary[key];
							}
							if (text.Equals("B") || text.Equals("C"))
							{
								value.buyMatched += num14;
							}
							else
							{
								value.sellMatched += num14;
							}
							dictionary[key] = value;
						}
					}
				}
				this.tableDetail.Rows = dictionary.Count;
				int num15 = 0;
				foreach (KeyValuePair<decimal, ucOrderStat.OrderRecord> current in dictionary)
				{
					fontColor = Utilities.ComparePriceCFColor(current.Key, stockInformation);
					this.tableDetail.Records(num15).Fields("price").Text = current.Key;
					this.tableDetail.Records(num15).Fields("buyDeal").Text = current.Value.buyDeals;
					this.tableDetail.Records(num15).Fields("buyVol").Text = current.Value.buyVolume;
					this.tableDetail.Records(num15).Fields("buyMatchVol").Text = current.Value.buyMatched;
					this.tableDetail.Records(num15).Fields("sellDeal").Text = current.Value.sellDeals;
					this.tableDetail.Records(num15).Fields("sellVol").Text = current.Value.sellVolume;
					this.tableDetail.Records(num15).Fields("sellMatchVol").Text = current.Value.sellMatched;
					this.tableDetail.Records(num15).Fields("price").FontColor = fontColor;
					this.tableDetail.Records(num15).Fields("buyDeal").FontColor = Color.LightGray;
					this.tableDetail.Records(num15).Fields("buyVol").FontColor = MyColor.UnChgColor;
					this.tableDetail.Records(num15).Fields("buyMatchVol").FontColor = MyColor.BuyColor;
					this.tableDetail.Records(num15).Fields("sellDeal").FontColor = Color.LightGray;
					this.tableDetail.Records(num15).Fields("sellVol").FontColor = MyColor.UnChgColor;
					this.tableDetail.Records(num15).Fields("sellMatchVol").FontColor = MyColor.SellColor;
					num10 += current.Value.sellDeals;
					num2 += current.Value.sellVolume;
					num4 += current.Value.sellMatched;
					num6 += current.Value.sellMatched * current.Key;
					num8 += current.Value.sellLeaveVolume;
					num9 += current.Value.buyDeals;
					num += current.Value.buyVolume;
					num3 += current.Value.buyMatched;
					num5 += current.Value.buyMatched * current.Key;
					num7 += current.Value.buyLeaveVolume;
					num15++;
				}
				this.tableDetail.Sort("price", SortType.Desc);
				this.tableDetail.Redraw();
				dictionary.Clear();
				dictionary = null;
				this.intzaSum.BeginUpdate();
				this.intzaSum.ClearAllText();
				this.intzaSum.GetColumn("item").Text = stockInformation.Symbol;
				this.intzaSum.Records(0).Fields("item").Text = "Transactions";
				this.intzaSum.Records(1).Fields("item").Text = "Volume";
				this.intzaSum.Records(2).Fields("item").Text = "Matched Average";
				this.intzaSum.Records(3).Fields("item").Text = "Matched Value";
				this.intzaSum.Records(4).Fields("item").Text = "Matched Volume";
				this.intzaSum.Records(5).Fields("item").Text = "UnMatch Volume";
				decimal num16 = 0m;
				if (num3 > 0L)
				{
					num16 = num5 / num3;
				}
				this.intzaSum.Records(0).Fields("buy").Text = FormatUtil.VolumeFormat(num9, true);
				this.intzaSum.Records(1).Fields("buy").Text = FormatUtil.VolumeFormat(num, true);
				this.intzaSum.Records(2).Fields("buy").Text = FormatUtil.PriceFormat(num16, 4, "");
				this.intzaSum.Records(2).Fields("buy").FontColor = Utilities.ComparePriceCFColor(num16, stockInformation);
				this.intzaSum.Records(3).Fields("buy").Text = FormatUtil.VolumeFormat(num5, true);
				this.intzaSum.Records(4).Fields("buy").Text = FormatUtil.VolumeFormat(num3, true);
				this.intzaSum.Records(5).Fields("buy").Text = FormatUtil.VolumeFormat(num7, true);
				decimal num17 = 0m;
				if (num4 > 0L)
				{
					num17 = num6 / num4;
				}
				this.intzaSum.Records(0).Fields("sell").Text = FormatUtil.VolumeFormat(num10, true);
				this.intzaSum.Records(1).Fields("sell").Text = FormatUtil.VolumeFormat(num2, true);
				this.intzaSum.Records(2).Fields("sell").Text = FormatUtil.PriceFormat(num17, 4, "");
				this.intzaSum.Records(2).Fields("sell").FontColor = Utilities.ComparePriceCFColor(num17, stockInformation);
				this.intzaSum.Records(3).Fields("sell").Text = FormatUtil.VolumeFormat(num6, true);
				this.intzaSum.Records(4).Fields("sell").Text = FormatUtil.VolumeFormat(num4, true);
				this.intzaSum.Records(5).Fields("sell").Text = FormatUtil.VolumeFormat(num8, true);
				this.intzaSum.Redraw();
				this.tdsPortStatByStock.Clear();
			}
			catch (Exception ex)
			{
				this.ShowError("bgwPortStatByStock_RunWorkerCompleted", ex);
			}
			this.IsLoadingData = false;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00026940 File Offset: 0x00024D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadByStock(string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwPortStatByStock.IsBusy)
			{
				this.bgwPortStatByStock.RunWorkerAsync(stock);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0002697C File Offset: 0x00024D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tableStockList_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoadByStock(this.tableStockList.Records(this.tableStockList.FocusItemIndex).Fields("stock").Text.ToString());
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000269CC File Offset: 0x00024DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderHistory_IDoHeaderChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tableDetail.GetColumn("buyDeal").BackColor = MyColor.BuyColor;
				this.tableDetail.GetColumn("buyMatchVol").BackColor = MyColor.BuyColor;
				this.tableDetail.GetColumn("buyVol").BackColor = MyColor.BuyColor;
				this.tableDetail.GetColumn("buyDeal").FontColor = Color.Black;
				this.tableDetail.GetColumn("buyMatchVol").FontColor = Color.Black;
				this.tableDetail.GetColumn("buyVol").FontColor = Color.Black;
				this.tableDetail.GetColumn("sellMatchVol").BackColor = MyColor.SellColor;
				this.tableDetail.GetColumn("sellVol").BackColor = MyColor.SellColor;
				this.tableDetail.GetColumn("sellDeal").BackColor = MyColor.SellColor;
				this.tableDetail.GetColumn("sellVol").FontColor = Color.White;
				this.tableDetail.GetColumn("sellMatchVol").FontColor = Color.White;
				this.tableDetail.GetColumn("sellDeal").FontColor = Color.White;
				this.intzaSum.GetColumn("buy").BackColor = MyColor.BuyColor;
				this.intzaSum.GetColumn("sell").BackColor = MyColor.SellColor;
				this.intzaSum.GetColumn("buy").FontColor = Color.Black;
				this.intzaSum.GetColumn("sell").FontColor = Color.White;
			}
			catch (Exception ex)
			{
				this.ShowError("frmViewOrderHistory_IDoHeaderChanged", ex);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00026BD4 File Offset: 0x00024FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00026C08 File Offset: 0x00025008
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00026C34 File Offset: 0x00025034
		public bool IsLoadingData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isLoadingData;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isLoadingData = value;
				if (!base.DesignMode)
				{
					this.ShowSplash(this.isLoadingData, "Loading...", false);
				}
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00026C7C File Offset: 0x0002507C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplash(bool visible, string message, bool isAutoClose)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucOrderStat.ShowSplashCallBack(this.ShowSplash), new object[]
				{
					visible,
					message,
					isAutoClose
				});
			}
			else
			{
				try
				{
					if (ApplicationInfo.SuuportSplash == "Y")
					{
						if (this.tmCloseSplash == null)
						{
							this.tmCloseSplash = new Timer();
							this.tmCloseSplash.Interval = 1000;
							this.tmCloseSplash.Tick += new EventHandler(this.tmCloseSplash_Tick);
						}
						if (visible)
						{
							this.lbLoading.Text = message;
							this.lbLoading.Left = (base.Width - this.lbLoading.Width) / 2;
							this.lbLoading.Top = (base.Height - this.lbLoading.Height) / 2;
							this.lbLoading.Visible = true;
							this.lbLoading.BringToFront();
							this.tmCloseSplash.Enabled = false;
							if (isAutoClose)
							{
								this.tmCloseSplash.Enabled = true;
							}
						}
						else
						{
							this.lbLoading.Visible = false;
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ShowSplash", ex);
				}
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00026E2C File Offset: 0x0002522C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmCloseSplash_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tmCloseSplash.Enabled = false;
			this.ShowSplash(false, "", false);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00026E58 File Offset: 0x00025258
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnReload_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.bgwPortStat.IsBusy)
				{
					int num = Convert.ToInt32(this.tstbStartDate.Text.Substring(0, 2));
					int num2 = Convert.ToInt32(this.tstbStartDate.Text.Substring(3, 2));
					int num3 = Convert.ToInt32(this.tstbStartDate.Text.Substring(6, 4));
					if (num3 > 2500)
					{
						num3 -= 543;
					}
					this._startDate = num3 + num2.ToString().PadLeft(2, '0') + num.ToString().PadLeft(2, '0');
					num = Convert.ToInt32(this.tstbEndDate.Text.Substring(0, 2));
					num2 = Convert.ToInt32(this.tstbEndDate.Text.Substring(3, 2));
					num3 = Convert.ToInt32(this.tstbEndDate.Text.Substring(6, 4));
					if (num3 > 2500)
					{
						num3 -= 543;
					}
					this._endDate = num3 + num2.ToString().PadLeft(2, '0') + num.ToString().PadLeft(2, '0');
					if (this._startDate == DateTime.Now.ToString("yyyyMMdd"))
					{
						this._startDate = string.Empty;
					}
					if (this._endDate == DateTime.Now.ToString("yyyyMMdd"))
					{
						this._endDate = string.Empty;
					}
					if (!this.bgwPortStat.IsBusy)
					{
						this.bgwPortStat.RunWorkerAsync();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnReload_Click", ex);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00027074 File Offset: 0x00025474
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

		// Token: 0x0600020E RID: 526 RVA: 0x00027168 File Offset: 0x00025568
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

		// Token: 0x0600020F RID: 527 RVA: 0x0002725C File Offset: 0x0002565C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
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

		// Token: 0x06000210 RID: 528 RVA: 0x000272F0 File Offset: 0x000256F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void monthCalendar1_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.monthCalendar1.Hide();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00027310 File Offset: 0x00025710
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

		// Token: 0x06000212 RID: 530 RVA: 0x00027360 File Offset: 0x00025760
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ucOrderStat));
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
			this.lbLoading = new Label();
			this.tStripMenu = new ToolStrip();
			this.toolStripLabel1 = new ToolStripLabel();
			this.tstbStartDate = new ToolStripLabel();
			this.tsbtnSelStartDate = new ToolStripButton();
			this.toolStripLabel2 = new ToolStripLabel();
			this.tstbEndDate = new ToolStripLabel();
			this.tsbtnSelEndDate = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.tsbtnReload = new ToolStripButton();
			this.monthCalendar1 = new MonthCalendar();
			this.intzaSum = new SortGrid();
			this.tableStockList = new SortGrid();
			this.tableDetail = new SortGrid();
			this.tStripMenu.SuspendLayout();
			base.SuspendLayout();
			this.lbLoading.AutoSize = true;
			this.lbLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbLoading.ForeColor = Color.Yellow;
			this.lbLoading.Location = new Point(352, 149);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Padding = new Padding(5, 3, 5, 3);
			this.lbLoading.Size = new Size(76, 23);
			this.lbLoading.TabIndex = 62;
			this.lbLoading.Text = "Loading ...";
			this.lbLoading.Visible = false;
			this.tStripMenu.BackColor = Color.FromArgb(20, 20, 20);
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
				this.tsbtnReload
			});
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Size = new Size(780, 25);
			this.tStripMenu.TabIndex = 63;
			this.tStripMenu.Text = "toolStrip1";
			this.toolStripLabel1.ForeColor = Color.LightGray;
			this.toolStripLabel1.Margin = new Padding(5, 1, 0, 2);
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new Size(64, 22);
			this.toolStripLabel1.Text = "Start Date :";
			this.tstbStartDate.BackColor = Color.Gray;
			this.tstbStartDate.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tstbStartDate.ForeColor = Color.Yellow;
			this.tstbStartDate.Margin = new Padding(5, 1, 5, 2);
			this.tstbStartDate.Name = "tstbStartDate";
			this.tstbStartDate.Size = new Size(55, 22);
			this.tstbStartDate.Text = "20090101";
			this.tsbtnSelStartDate.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnSelStartDate.Image = (Image)componentResourceManager.GetObject("tsbtnSelStartDate.Image");
			this.tsbtnSelStartDate.ImageTransparentColor = Color.Magenta;
			this.tsbtnSelStartDate.Name = "tsbtnSelStartDate";
			this.tsbtnSelStartDate.Size = new Size(23, 22);
			this.tsbtnSelStartDate.Text = "toolStripButton1";
			this.tsbtnSelStartDate.ToolTipText = "Select Date";
			this.tsbtnSelStartDate.Click += new EventHandler(this.tsbtnSelStartDate_Click);
			this.toolStripLabel2.ForeColor = Color.LightGray;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new Size(60, 22);
			this.toolStripLabel2.Text = "End Date :";
			this.tstbEndDate.BackColor = Color.Gray;
			this.tstbEndDate.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tstbEndDate.ForeColor = Color.Yellow;
			this.tstbEndDate.Margin = new Padding(5, 1, 5, 2);
			this.tstbEndDate.Name = "tstbEndDate";
			this.tstbEndDate.Size = new Size(55, 22);
			this.tstbEndDate.Text = "20090501";
			this.tsbtnSelEndDate.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnSelEndDate.Image = (Image)componentResourceManager.GetObject("tsbtnSelEndDate.Image");
			this.tsbtnSelEndDate.ImageTransparentColor = Color.Magenta;
			this.tsbtnSelEndDate.Name = "tsbtnSelEndDate";
			this.tsbtnSelEndDate.Size = new Size(23, 22);
			this.tsbtnSelEndDate.Text = "toolStripButton2";
			this.tsbtnSelEndDate.ToolTipText = "Select Date";
			this.tsbtnSelEndDate.Click += new EventHandler(this.tsbtnSelEndDate_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 25);
			this.tsbtnReload.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnReload.Image = Resources.refresh;
			this.tsbtnReload.ImageTransparentColor = Color.Magenta;
			this.tsbtnReload.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnReload.Name = "tsbtnReload";
			this.tsbtnReload.Size = new Size(23, 22);
			this.tsbtnReload.Text = "Reload";
			this.tsbtnReload.Click += new EventHandler(this.tsbtnReload_Click);
			this.monthCalendar1.Location = new Point(142, 27);
			this.monthCalendar1.MaxDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
			this.monthCalendar1.MaxSelectionCount = 1;
			this.monthCalendar1.MinDate = new DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 64;
			this.monthCalendar1.Visible = false;
			this.monthCalendar1.DateSelected += new DateRangeEventHandler(this.monthCalendar1_DateSelected);
			this.monthCalendar1.Leave += new EventHandler(this.monthCalendar1_Leave);
			this.intzaSum.AllowDrop = true;
			this.intzaSum.BackColor = Color.FromArgb(20, 20, 20);
			this.intzaSum.CanBlink = true;
			this.intzaSum.CanDrag = false;
			this.intzaSum.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "item";
			columnItem.Text = "";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 30;
			columnItem2.Alignment = StringAlignment.Center;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.Cyan;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "buy";
			columnItem2.Text = "BUY";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 35;
			columnItem3.Alignment = StringAlignment.Center;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.Magenta;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "sell";
			columnItem3.Text = "SELL";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 35;
			this.intzaSum.Columns.Add(columnItem);
			this.intzaSum.Columns.Add(columnItem2);
			this.intzaSum.Columns.Add(columnItem3);
			this.intzaSum.CurrentScroll = 0;
			this.intzaSum.FocusItemIndex = -1;
			this.intzaSum.ForeColor = Color.Black;
			this.intzaSum.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaSum.HeaderPctHeight = 80f;
			this.intzaSum.IsAutoRepaint = true;
			this.intzaSum.IsDrawFullRow = false;
			this.intzaSum.IsDrawGrid = true;
			this.intzaSum.IsDrawHeader = true;
			this.intzaSum.IsScrollable = true;
			this.intzaSum.Location = new Point(193, 214);
			this.intzaSum.MainColumn = "";
			this.intzaSum.Name = "intzaSum";
			this.intzaSum.Rows = 6;
			this.intzaSum.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaSum.RowSelectType = 0;
			this.intzaSum.RowsVisible = 6;
			this.intzaSum.Size = new Size(583, 99);
			this.intzaSum.SortColumnName = "";
			this.intzaSum.SortType = SortType.Desc;
			this.intzaSum.TabIndex = 7;
			this.tableStockList.AllowDrop = true;
			this.tableStockList.BackColor = Color.FromArgb(20, 20, 20);
			this.tableStockList.CanBlink = true;
			this.tableStockList.CanDrag = false;
			this.tableStockList.CanGetMouseMove = false;
			columnItem4.Alignment = StringAlignment.Center;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "rowId";
			columnItem4.Text = "No.";
			columnItem4.ValueFormat = FormatType.RecordNumber;
			columnItem4.Visible = true;
			columnItem4.Width = 20;
			columnItem5.Alignment = StringAlignment.Near;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "stock";
			columnItem5.Text = "Symbol";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 50;
			columnItem6.Alignment = StringAlignment.Center;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "deals";
			columnItem6.Text = "Trans";
			columnItem6.ValueFormat = FormatType.Volume;
			columnItem6.Visible = true;
			columnItem6.Width = 30;
			this.tableStockList.Columns.Add(columnItem4);
			this.tableStockList.Columns.Add(columnItem5);
			this.tableStockList.Columns.Add(columnItem6);
			this.tableStockList.CurrentScroll = 0;
			this.tableStockList.FocusItemIndex = -1;
			this.tableStockList.ForeColor = Color.Black;
			this.tableStockList.GridColor = Color.FromArgb(45, 45, 45);
			this.tableStockList.HeaderPctHeight = 80f;
			this.tableStockList.IsAutoRepaint = true;
			this.tableStockList.IsDrawFullRow = false;
			this.tableStockList.IsDrawGrid = true;
			this.tableStockList.IsDrawHeader = true;
			this.tableStockList.IsScrollable = true;
			this.tableStockList.Location = new Point(0, 28);
			this.tableStockList.MainColumn = "";
			this.tableStockList.Name = "tableStockList";
			this.tableStockList.Rows = 0;
			this.tableStockList.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.tableStockList.RowSelectType = 3;
			this.tableStockList.RowsVisible = 0;
			this.tableStockList.Size = new Size(193, 284);
			this.tableStockList.SortColumnName = "";
			this.tableStockList.SortType = SortType.Desc;
			this.tableStockList.TabIndex = 1;
			this.tableStockList.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.tableStockList_TableMouseClick);
			this.tableDetail.AllowDrop = true;
			this.tableDetail.BackColor = Color.FromArgb(20, 20, 20);
			this.tableDetail.CanBlink = true;
			this.tableDetail.CanDrag = false;
			this.tableDetail.CanGetMouseMove = false;
			columnItem7.Alignment = StringAlignment.Center;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "buyDeal";
			columnItem7.Text = "Trans";
			columnItem7.ValueFormat = FormatType.Volume;
			columnItem7.Visible = true;
			columnItem7.Width = 8;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "buyVol";
			columnItem8.Text = "BuyVol";
			columnItem8.ValueFormat = FormatType.Volume;
			columnItem8.Visible = true;
			columnItem8.Width = 17;
			columnItem9.Alignment = StringAlignment.Far;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "buyMatchVol";
			columnItem9.Text = "Matched";
			columnItem9.ValueFormat = FormatType.Volume;
			columnItem9.Visible = true;
			columnItem9.Width = 17;
			columnItem10.Alignment = StringAlignment.Center;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.Yellow;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "price";
			columnItem10.Text = "Price";
			columnItem10.ValueFormat = FormatType.Price;
			columnItem10.Visible = true;
			columnItem10.Width = 16;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "sellMatchVol";
			columnItem11.Text = "Matched";
			columnItem11.ValueFormat = FormatType.Volume;
			columnItem11.Visible = true;
			columnItem11.Width = 17;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "sellVol";
			columnItem12.Text = "SellVol";
			columnItem12.ValueFormat = FormatType.Volume;
			columnItem12.Visible = true;
			columnItem12.Width = 17;
			columnItem13.Alignment = StringAlignment.Center;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.ColumnAlignment = StringAlignment.Center;
			columnItem13.FontColor = Color.LightGray;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "sellDeal";
			columnItem13.Text = "Trans";
			columnItem13.ValueFormat = FormatType.Volume;
			columnItem13.Visible = true;
			columnItem13.Width = 8;
			this.tableDetail.Columns.Add(columnItem7);
			this.tableDetail.Columns.Add(columnItem8);
			this.tableDetail.Columns.Add(columnItem9);
			this.tableDetail.Columns.Add(columnItem10);
			this.tableDetail.Columns.Add(columnItem11);
			this.tableDetail.Columns.Add(columnItem12);
			this.tableDetail.Columns.Add(columnItem13);
			this.tableDetail.CurrentScroll = 0;
			this.tableDetail.FocusItemIndex = -1;
			this.tableDetail.ForeColor = Color.Black;
			this.tableDetail.GridColor = Color.FromArgb(45, 45, 45);
			this.tableDetail.HeaderPctHeight = 80f;
			this.tableDetail.IsAutoRepaint = true;
			this.tableDetail.IsDrawFullRow = false;
			this.tableDetail.IsDrawGrid = true;
			this.tableDetail.IsDrawHeader = true;
			this.tableDetail.IsScrollable = true;
			this.tableDetail.Location = new Point(186, 28);
			this.tableDetail.MainColumn = "";
			this.tableDetail.Name = "tableDetail";
			this.tableDetail.Rows = 0;
			this.tableDetail.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.tableDetail.RowSelectType = 0;
			this.tableDetail.RowsVisible = 0;
			this.tableDetail.Size = new Size(591, 186);
			this.tableDetail.SortColumnName = "";
			this.tableDetail.SortType = SortType.Desc;
			this.tableDetail.TabIndex = 2;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.ControlDark;
			base.Controls.Add(this.monthCalendar1);
			base.Controls.Add(this.tStripMenu);
			base.Controls.Add(this.lbLoading);
			base.Controls.Add(this.intzaSum);
			base.Controls.Add(this.tableStockList);
			base.Controls.Add(this.tableDetail);
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "ucOrderStat";
			base.Size = new Size(780, 313);
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000149 RID: 329
		private BackgroundWorker bgwPortStat;

		// Token: 0x0400014A RID: 330
		private BackgroundWorker bgwPortStatByStock;

		// Token: 0x0400014B RID: 331
		private bool _isInit;

		// Token: 0x0400014C RID: 332
		private string _currAccount;

		// Token: 0x0400014D RID: 333
		private DataSet tdsPortStat;

		// Token: 0x0400014E RID: 334
		private string _startDate;

		// Token: 0x0400014F RID: 335
		private string _endDate;

		// Token: 0x04000150 RID: 336
		private DataSet tdsPortStatByStock;

		// Token: 0x04000151 RID: 337
		private bool isLoadingData;

		// Token: 0x04000152 RID: 338
		private Timer tmCloseSplash;

		// Token: 0x04000153 RID: 339
		private int _mcPos;

		// Token: 0x04000154 RID: 340
		private IContainer components;

		// Token: 0x04000155 RID: 341
		private SortGrid tableStockList;

		// Token: 0x04000156 RID: 342
		private SortGrid tableDetail;

		// Token: 0x04000157 RID: 343
		private SortGrid intzaSum;

		// Token: 0x04000158 RID: 344
		private Label lbLoading;

		// Token: 0x04000159 RID: 345
		private ToolStrip tStripMenu;

		// Token: 0x0400015A RID: 346
		private ToolStripLabel toolStripLabel1;

		// Token: 0x0400015B RID: 347
		private ToolStripLabel toolStripLabel2;

		// Token: 0x0400015C RID: 348
		private ToolStripButton tsbtnReload;

		// Token: 0x0400015D RID: 349
		private ToolStripButton tsbtnSelStartDate;

		// Token: 0x0400015E RID: 350
		private ToolStripButton tsbtnSelEndDate;

		// Token: 0x0400015F RID: 351
		private MonthCalendar monthCalendar1;

		// Token: 0x04000160 RID: 352
		private ToolStripLabel tstbStartDate;

		// Token: 0x04000161 RID: 353
		private ToolStripLabel tstbEndDate;

		// Token: 0x04000162 RID: 354
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x02000032 RID: 50
		private struct OrderRecord
		{
			// Token: 0x04000163 RID: 355
			public int buyDeals;

			// Token: 0x04000164 RID: 356
			public long buyVolume;

			// Token: 0x04000165 RID: 357
			public long buyMatched;

			// Token: 0x04000166 RID: 358
			public long buyLeaveVolume;

			// Token: 0x04000167 RID: 359
			public long sellMatched;

			// Token: 0x04000168 RID: 360
			public long sellVolume;

			// Token: 0x04000169 RID: 361
			public int sellDeals;

			// Token: 0x0400016A RID: 362
			public long sellLeaveVolume;
		}

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate void ShowSplashCallBack(bool visible, string message, bool isAutoClose);
	}
}
