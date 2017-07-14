using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.Properties;
using i2TradePlus.Templates;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using ITSNet.Common.BIZ.WebClient;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus.Controls
{
	// Token: 0x02000024 RID: 36
	public class ucSmart1Click : UserControl, IRealtimeMessage
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00012628 File Offset: 0x00010A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ucSmart1Click() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._stockInfo = null;
			this.bgwReloadData = null;
			this.bgwGetOrderForCancel = null;
			this.tdsMainInfo = null;
			this._isInit = false;
			this.tmLoad = null;
			this._lstOrder = null;
			this._cancelSide = string.Empty;
			this.tdsOrderForCancel = null;
			this._listOfOrderCancel = null;
			this.frmConfirm = null;
			this.tmCloseSplash = null;
			this._isLoading = true;
			this.components = null;
			
			this.InitializeComponent();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			base.UpdateStyles();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000126D4 File Offset: 0x00010AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isInit)
				{
					this._isInit = true;
					this.bgwReloadData = new BackgroundWorker();
					this.bgwReloadData.WorkerReportsProgress = true;
					this.bgwReloadData.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
					this.bgwReloadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
					this.bgwGetOrderForCancel = new BackgroundWorker();
					this.bgwGetOrderForCancel.WorkerReportsProgress = true;
					this.bgwGetOrderForCancel.DoWork += new DoWorkEventHandler(this.bgwGetOrderForCancel_DoWork);
					this.bgwGetOrderForCancel.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwGetOrderForCancel_RunWorkerCompleted);
					this.chbSmartClick.Checked = Settings.Default.SmartOneClick;
					this.tstbDefVol.Text = Utilities.VolumeFormat(Settings.Default.SmartClickVolume, true);
				}
				this.SwitchAccount();
				this.setNewStock(ApplicationInfo.CurrentSymbol, false);
			}
			catch (Exception ex)
			{
				this.ShowError("Init", ex);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00012824 File Offset: 0x00010C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchAccount()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._isInit)
				{
					if (ApplicationInfo.BrokerId == 1 && ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
					{
						this.chbDeposit.Visible = true;
					}
					else
					{
						this.chbDeposit.Visible = false;
						this.chbDeposit.Checked = false;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SwitchAccount", ex);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000128F4 File Offset: 0x00010CF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetResize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.setToolStripFont(this.toolStrip2);
				this.sortGrid.Font = new Font(Settings.Default.Default_Font.Name, Settings.Default.Default_Font.Size - 1f, Settings.Default.Default_Font.Style);
				this.panelTitle.Invalidate();
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001299C File Offset: 0x00010D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setNewStock(string stock, bool isForce)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stock];
				if (stockInformation.Number > 0)
				{
					if (stockInformation != this._stockInfo || isForce)
					{
						this._stockInfo = stockInformation;
						if (this.tmLoad == null)
						{
							this.tmLoad = new System.Windows.Forms.Timer();
							this.tmLoad.Interval = 300;
							this.tmLoad.Tick += new EventHandler(this.tmLoad_Tick);
						}
						this.tmLoad.Stop();
						this.tmLoad.Start();
					}
				}
				else
				{
					this._stockInfo = null;
					this.IsLoadingData = false;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("setNewStock", ex);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00012AA4 File Offset: 0x00010EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmLoad_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tmLoad.Stop();
				if (this._stockInfo != null)
				{
					if (!this.bgwReloadData.IsBusy)
					{
						this.bgwReloadData.RunWorkerAsync();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tmLoad_Tick", ex);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00012B2C File Offset: 0x00010F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._stockInfo != null)
				{
					this.IsLoadingData = true;
					if (this.tdsMainInfo == null)
					{
						this.tdsMainInfo = new DataSet();
					}
					else
					{
						this.tdsMainInfo.Clear();
					}
					string dataForSmartClick = ApplicationInfo.WebOrderService.GetDataForSmartClick(this._stockInfo.Symbol, ApplicationInfo.AccInfo.CurrentAccount);
					if (!string.IsNullOrEmpty(dataForSmartClick))
					{
						MyDataHelper.StringToDataSet(dataForSmartClick, this.tdsMainInfo);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_DoWork", ex);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00012BFC File Offset: 0x00010FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			try
			{
				this.tslbStock.Text = this._stockInfo.Symbol;
				this._price = ((this._stockInfo.LastSalePrice > 0m) ? this._stockInfo.LastSalePrice : this._stockInfo.PriorPrice);
				if (this._price == 0m)
				{
					if (!decimal.TryParse(this._stockInfo.BidPrice1, out this._price))
					{
						decimal.TryParse(this._stockInfo.OfferPrice1, out this._price);
					}
					if (this._price == 0m)
					{
						return;
					}
				}
				List<decimal> list = new List<decimal>();
				list.Add(this._price);
				decimal num = this._price;
				for (int i = 0; i < 15; i++)
				{
					num -= this.GetNextSpreadDown(num);
					if (!(num > 0m) || !(num >= this._stockInfo.Floor))
					{
						break;
					}
					list.Add(num);
				}
				num = this._price;
				for (int i = 0; i < 15; i++)
				{
					num += this.GetNextSpreadUp(num);
					if (!(num <= this._stockInfo.Ceiling))
					{
						break;
					}
					list.Add(num);
				}
				object arg_0A_0;
				list.Sort(delegate(decimal r1, decimal r2)
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return decimal.Compare(r2, r1);
				});
				if (this._lstOrder == null)
				{
					this._lstOrder = new Dictionary<string, ucSmart1Click.RecordData>();
				}
				else
				{
					this._lstOrder.Clear();
				}
				foreach (decimal current in list)
				{
					ucSmart1Click.RecordData value = default(ucSmart1Click.RecordData);
					value.price = current;
					this._lstOrder.Add(Utilities.PriceFormat(current), value);
				}
				list.Clear();
				list = null;
				if (this.tdsMainInfo.Tables.Contains("ORDERS") && this.tdsMainInfo.Tables["ORDERS"].Rows.Count > 0)
				{
					string key = string.Empty;
					string a = string.Empty;
					foreach (DataRow dataRow in this.tdsMainInfo.Tables["ORDERS"].Rows)
					{
						key = Utilities.PriceFormat(dataRow["price"].ToString());
						if (this._lstOrder.ContainsKey(key))
						{
							a = dataRow["side"].ToString().Trim();
							ucSmart1Click.RecordData value = this._lstOrder[key];
							if (a == "B")
							{
								value.buyVol += Convert.ToInt64(dataRow["volume"].ToString()) - Convert.ToInt64(dataRow["matched_volume"].ToString());
								value.buyDeal++;
							}
							else
							{
								value.sellVol += Convert.ToInt64(dataRow["volume"].ToString()) - Convert.ToInt64(dataRow["matched_volume"].ToString());
								value.sellDeal++;
							}
							this._lstOrder[key] = value;
						}
					}
				}
				this.sortGrid.BeginUpdate();
				this.sortGrid.Rows = this._lstOrder.Count;
				this.sortGrid.ClearAllText();
				int num2 = 0;
				int num3 = -1;
				foreach (KeyValuePair<string, ucSmart1Click.RecordData> current2 in this._lstOrder)
				{
					this.updateToGrid(num2, current2.Value);
					if (current2.Value.price == this._price)
					{
						num3 = num2;
					}
					num2++;
				}
				this.sortGrid.SetFocusItem(num3);
				this.sortGrid.SetCenterScroll(num3);
				this.sortGrid.Redraw();
				this.tdsMainInfo.Clear();
				long num4 = Settings.Default.SmartClickVolume;
				long num5 = num4 % (long)this._stockInfo.BoardLot;
				if (num5 > 0L)
				{
					num4 -= num5;
					this.tstbDefVol.Text = Utilities.VolumeFormat(num4, true);
					Settings.Default.SmartClickVolume = num4;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SecurityInfo:RunWorkerCompleted", ex);
			}
			this.IsLoadingData = false;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00013254 File Offset: 0x00011654
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void updateToGrid(int index, ucSmart1Click.RecordData recData)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				RecordItem recordItem;
				if (index == -1)
				{
					recordItem = this.sortGrid.AddRecord(-1, false);
				}
				else
				{
					recordItem = this.sortGrid.Records(index);
				}
				if (recData.buyDeal > 0)
				{
					recordItem.Fields("buycancel").Text = "0";
				}
				else
				{
					recordItem.Fields("buycancel").Text = "";
				}
				if (recData.sellDeal > 0)
				{
					recordItem.Fields("sellcancel").Text = "0";
				}
				else
				{
					recordItem.Fields("sellcancel").Text = "";
				}
				recordItem.Fields("buydeal").Text = recData.buyDeal;
				recordItem.Fields("buyvol").Text = recData.buyVol;
				recordItem.Fields("price").Text = recData.price;
				recordItem.Fields("sellvol").Text = recData.sellVol;
				recordItem.Fields("selldeal").Text = recData.sellDeal;
				Color fontColor = Utilities.ComparePriceCFColor(recData.price, this._stockInfo);
				recordItem.Fields("buydeal").FontColor = fontColor;
				recordItem.Fields("buyvol").FontColor = fontColor;
				recordItem.Fields("price").FontColor = fontColor;
				recordItem.Fields("price").BackColor = Color.FromArgb(25, 25, 25);
				recordItem.Fields("sellvol").FontColor = fontColor;
				recordItem.Fields("selldeal").FontColor = fontColor;
			}
			catch (Exception ex)
			{
				this.ShowError("updateToGrid", ex);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00013480 File Offset: 0x00011880
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000134B4 File Offset: 0x000118B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private decimal GetNextSpreadDown(decimal Price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal result;
			if (Price <= 2m)
			{
				result = 0.01m;
			}
			else if (Price <= 5m)
			{
				result = 0.02m;
			}
			else if (Price <= 10m)
			{
				result = 0.05m;
			}
			else if (Price <= 25m)
			{
				result = 0.1m;
			}
			else if (Price <= 100m)
			{
				result = 0.25m;
			}
			else if (Price <= 200m)
			{
				result = 0.5m;
			}
			else if (Price <= 400m)
			{
				result = 1m;
			}
			else
			{
				result = 2m;
			}
			return result;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000135F0 File Offset: 0x000119F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private decimal GetNextSpreadUp(decimal Price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal result;
			if (Price < 2m)
			{
				result = 0.01m;
			}
			else if (Price < 5m)
			{
				result = 0.02m;
			}
			else if (Price < 10m)
			{
				result = 0.05m;
			}
			else if (Price < 25m)
			{
				result = 0.1m;
			}
			else if (Price < 100m)
			{
				result = 0.25m;
			}
			else if (Price < 200m)
			{
				result = 0.5m;
			}
			else if (Price < 400m)
			{
				result = 1m;
			}
			else
			{
				result = 2m;
			}
			return result;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0001372C File Offset: 0x00011B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHeaderColor(bool isRedraw)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				foreach (Control control in base.Controls)
				{
					if (control.GetType() == typeof(SortGrid))
					{
						foreach (ColumnItem current in ((SortGrid)control).Columns)
						{
							current.BackColor = Settings.Default.HeaderBackGColor;
							current.FontColor = Settings.Default.HeaderFontColor;
						}
						((SortGrid)control).GridColor = Settings.Default.GridColor;
						if (isRedraw)
						{
							((SortGrid)control).Redraw();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetHeaderBackColor", ex);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000138C0 File Offset: 0x00011CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setToolStripFont(ToolStrip control)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Font font = new Font(Settings.Default.Default_Font.Name, Settings.Default.Default_Font.Size - 1f, FontStyle.Regular);
				control.Font = font;
				foreach (ToolStripItem toolStripItem in control.Items)
				{
					toolStripItem.Font = font;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("setToolStripFont", ex);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000139A4 File Offset: 0x00011DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this._isLoading)
			{
				try
				{
					string messageType = message.MessageType;
					if (messageType != null)
					{
						if (!(messageType == "0I"))
						{
							if (messageType == "L+")
							{
								if (this._stockInfo != null && realtimeStockInfo.Number == this._stockInfo.Number)
								{
									LSAccumulate lSAccumulate = (LSAccumulate)message;
									int num = this.sortGrid.FindIndex("price", Utilities.PriceFormat(lSAccumulate.LastPrice));
									if (num > -1)
									{
										this.sortGrid.SetFocusItem(num);
									}
								}
							}
						}
						else
						{
							this.ReceiveOrderInfo(message);
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ReceiveMessage", ex);
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00013AC0 File Offset: 0x00011EC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00013AD4 File Offset: 0x00011ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReceiveOrderInfo(IBroadcastMessage message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.sortGrid.InvokeRequired)
			{
				this.sortGrid.Invoke(new ucSmart1Click.ReceiveOrderInfoCallBack(this.ReceiveOrderInfo), new object[]
				{
					message
				});
			}
			else
			{
				try
				{
					OrderInfoClient orderInfoClient = (OrderInfoClient)message;
					if (orderInfoClient.Account.Trim() == ApplicationInfo.AccInfo.CurrentAccount)
					{
						if (this._lstOrder.ContainsKey(Utilities.PriceFormat(orderInfoClient.PriceToSET)))
						{
							ucSmart1Click.RecordData recordData = this._lstOrder[Utilities.PriceFormat(orderInfoClient.PriceToSET)];
							string status = orderInfoClient.Status;
							switch (status)
							{
							case "X":
							case "XA":
							case "C":
							{
								if (orderInfoClient.Side == "B")
								{
									recordData.buyDeal--;
									recordData.buyVol -= orderInfoClient.Volume - orderInfoClient.MatchedVolume;
								}
								else if (orderInfoClient.Side == "S")
								{
									recordData.sellDeal--;
									recordData.sellVol -= orderInfoClient.Volume - orderInfoClient.MatchedVolume;
								}
								this._lstOrder[Utilities.PriceFormat(orderInfoClient.PriceToSET)] = recordData;
								int num2 = this.sortGrid.FindIndex("price", Utilities.PriceFormat(orderInfoClient.PriceToSET));
								if (num2 > -1)
								{
									this.updateToGrid(num2, recordData);
									this.sortGrid.EndUpdate(num2);
								}
								break;
							}
							case "M":
							case "MA":
							{
								if (orderInfoClient.Side == "B")
								{
									recordData.buyDeal--;
									recordData.buyVol -= orderInfoClient.LastVolumeInCase;
								}
								else if (orderInfoClient.Side == "S")
								{
									recordData.sellDeal--;
									recordData.sellVol -= orderInfoClient.LastVolumeInCase;
								}
								this._lstOrder[Utilities.PriceFormat(orderInfoClient.PriceToSET)] = recordData;
								int num2 = this.sortGrid.FindIndex("price", Utilities.PriceFormat(orderInfoClient.PriceToSET));
								if (num2 > -1)
								{
									this.updateToGrid(num2, recordData);
									this.sortGrid.EndUpdate(num2);
								}
								break;
							}
							case "O":
							case "OA":
							case "PO":
							case "POA":
							{
								if (orderInfoClient.Side == "B")
								{
									if (orderInfoClient.OriginalMessageType == "1I")
									{
										recordData.buyVol += orderInfoClient.Volume;
										recordData.buyDeal++;
									}
									else
									{
										recordData.buyVol -= orderInfoClient.LastVolumeInCase;
									}
								}
								else if (orderInfoClient.Side == "S")
								{
									if (orderInfoClient.OriginalMessageType == "1I")
									{
										recordData.sellVol += orderInfoClient.Volume;
										recordData.sellDeal++;
									}
									else
									{
										recordData.sellVol -= orderInfoClient.LastVolumeInCase;
									}
								}
								this._lstOrder[Utilities.PriceFormat(orderInfoClient.PriceToSET)] = recordData;
								int num2 = this.sortGrid.FindIndex("price", Utilities.PriceFormat(orderInfoClient.PriceToSET));
								if (num2 > -1)
								{
									this.updateToGrid(num2, recordData);
									this.sortGrid.EndUpdate(num2);
								}
								break;
							}
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ReceiveOrderInfo", ex);
				}
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00013FE8 File Offset: 0x000123E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sortGrid_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1)
				{
					if (e.Mouse.Button == MouseButtons.Left)
					{
						if (e.Column.Name == "buyvol")
						{
							string price = this.sortGrid.Records(e.RowIndex).Fields("price").Text.ToString();
							TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(this.chbDeposit.Checked ? "S" : "B", this._stockInfo.Symbol, price, this.chbDeposit.Checked);
						}
						else if (e.Column.Name == "sellvol")
						{
							string price = this.sortGrid.Records(e.RowIndex).Fields("price").Text.ToString();
							TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick("S", this._stockInfo.Symbol, price, this.chbDeposit.Checked);
						}
						else if (e.Column.Name == "buycancel")
						{
							if (this.sortGrid.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString() == "1")
							{
								this._cancelSide = "B";
								decimal.TryParse(this.sortGrid.Records(e.RowIndex).Fields("price").Text.ToString(), out this._cancelPrice);
								if (!this.bgwGetOrderForCancel.IsBusy)
								{
									this._cancelLocation = new Point(e.Mouse.X, e.FieldPosition.Top);
									if (!this.bgwGetOrderForCancel.IsBusy)
									{
										this.bgwGetOrderForCancel.RunWorkerAsync();
									}
								}
							}
						}
						else if (e.Column.Name == "sellcancel")
						{
							if (this.sortGrid.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString() == "1")
							{
								this._cancelSide = "S";
								decimal.TryParse(this.sortGrid.Records(e.RowIndex).Fields("price").Text.ToString(), out this._cancelPrice);
								if (!this.bgwGetOrderForCancel.IsBusy)
								{
									this._cancelLocation = new Point(e.Mouse.X, e.FieldPosition.Top);
									if (!this.bgwGetOrderForCancel.IsBusy)
									{
										this.bgwGetOrderForCancel.RunWorkerAsync();
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("sortGrid_TableMouseClick", ex);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0001436C File Offset: 0x0001276C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwGetOrderForCancel_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tdsOrderForCancel == null)
				{
					this.tdsOrderForCancel = new DataSet();
				}
				else
				{
					this.tdsOrderForCancel.Clear();
				}
				string orderFor1Click = ApplicationInfo.WebOrderService.GetOrderFor1Click(this._stockInfo.Symbol, ApplicationInfo.AccInfo.CurrentAccount, this._cancelPrice.ToString(), this._cancelSide);
				if (!string.IsNullOrEmpty(orderFor1Click))
				{
					MyDataHelper.StringToDataSet(orderFor1Click, this.tdsOrderForCancel);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwGetOrderForCancel_DoWork", ex);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00014434 File Offset: 0x00012834
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwGetOrderForCancel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tdsOrderForCancel != null && this.tdsOrderForCancel.Tables.Contains("ORDERS"))
				{
					foreach (object current in this.contextMenuStrip1.Items)
					{
						if (current.GetType() == typeof(ToolStripMenuItem))
						{
							(current as ToolStripMenuItem).Click -= new EventHandler(this.item_Click);
						}
					}
					this.contextMenuStrip1.Items.Clear();
					foreach (DataRow dataRow in this.tdsOrderForCancel.Tables["ORDERS"].Rows)
					{
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
						toolStripMenuItem.Text = "OrderNo " + dataRow["order_number"].ToString().Trim() + " ,Vol " + dataRow["volume"].ToString();
						toolStripMenuItem.Tag = dataRow["order_number"].ToString().Trim() + "|" + dataRow["sSendDate"].ToString().Trim();
						toolStripMenuItem.Click += new EventHandler(this.item_Click);
						this.contextMenuStrip1.Items.Add(toolStripMenuItem);
					}
					if (this.contextMenuStrip1.Items.Count > 0)
					{
						this.contextMenuStrip1.Items.Add(new ToolStripSeparator());
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
						toolStripMenuItem.Text = "CANCEL ALL";
						toolStripMenuItem.Tag = "ALL";
						toolStripMenuItem.Click += new EventHandler(this.item_Click);
						this.contextMenuStrip1.Items.Add(toolStripMenuItem);
						ToolStripSeparator value = new ToolStripSeparator();
						this.contextMenuStrip1.Items.Add(value);
						ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
						toolStripMenuItem2.Text = "Close";
						toolStripMenuItem2.Tag = "CLOSE";
						toolStripMenuItem2.Click += new EventHandler(this.item_Click);
						this.contextMenuStrip1.Items.Add(toolStripMenuItem2);
					}
					this.contextMenuStrip1.Show(this.sortGrid, this._cancelLocation.X, this._cancelLocation.Y);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwGetOrderForCancel_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000147A0 File Offset: 0x00012BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void item_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = (sender as ToolStripMenuItem).Tag.ToString();
				if (this._listOfOrderCancel == null)
				{
					this._listOfOrderCancel = new Dictionary<long, string>();
				}
				else
				{
					this._listOfOrderCancel.Clear();
				}
				if (text == "ALL")
				{
					foreach (DataRow dataRow in this.tdsOrderForCancel.Tables["ORDERS"].Rows)
					{
						this._listOfOrderCancel.Add(Convert.ToInt64(dataRow["order_number"].ToString()), dataRow["sSendDate"].ToString().Trim());
					}
					this.ShowMessageInFormConfirm("Do you want to cancel all at " + this._cancelPrice + " ?", frmOrderFormConfirm.OpenStyle.ConfirmCancel);
				}
				else if (text == "CLOSE")
				{
					int num = this.sortGrid.FindIndex("price", Utilities.PriceFormat(this._cancelPrice));
					if (num > -1)
					{
						RecordItem recordItem = this.sortGrid.Records(num);
						if (this._cancelSide == "B" && recordItem.Fields("buycancel").Text.ToString() == "1")
						{
							recordItem.Fields("buycancel").Text = "0";
						}
						if (this._cancelSide == "S" && recordItem.Fields("sellcancel").Text.ToString() == "1")
						{
							recordItem.Fields("sellcancel").Text = "0";
						}
						this.sortGrid.EndUpdate(num);
					}
				}
				else
				{
					string[] array = text.Split(new char[]
					{
						'|'
					});
					this._listOfOrderCancel.Add(Convert.ToInt64(array[0]), array[1]);
					this.ShowMessageInFormConfirm("Do you want to cancel order number " + Convert.ToInt64(array[0]) + " ?", frmOrderFormConfirm.OpenStyle.ConfirmCancel);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("item_Click", ex);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00014AB0 File Offset: 0x00012EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoopCancelOrder()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				foreach (KeyValuePair<long, string> current in this._listOfOrderCancel)
				{
					if (current.Key > 0L)
					{
						this.SendCancelOrder(current.Value, current.Key);
						Thread.Sleep(20);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoopCancelOrder", ex);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00014B78 File Offset: 0x00012F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SendCancelOrder(string sendDate, long orderNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = false;
			string data = string.Empty;
			try
			{
				this.ShowSplash(true, "Send Cancel Order " + orderNumber + "...", true);
				string message = SendCancelOrderMessage.Pack(sendDate, orderNumber, ApplicationInfo.AccInfo.CurrentAccount, ApplicationInfo.GetSession(), ApplicationInfo.AuthenKey, ApplicationInfo.AccInfo.CurrInternetUser, ApplicationInfo.GetTermicalId());
				data = ApplicationInfo.WebOrderService.SendCancelOrder(message);
				using (DataSet dataSet = new DataSet())
				{
					MyDataHelper.StringToDataSet(data, dataSet);
					if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
					{
						if (Convert.ToInt32(dataSet.Tables["Results"].Rows[0]["code"]) == 0)
						{
							ApplicationInfo.AddOrderNoToAutoRefreshList(orderNumber.ToString(), 2);
							this.ShowSplash(true, "Cancel Successful. [" + orderNumber + "]", true);
						}
						else if (Convert.ToInt32(dataSet.Tables["Results"].Rows[0]["code"]) == 1)
						{
							this.ShowSplash(true, "Send Request Cancel Order Number " + orderNumber, true);
						}
						else
						{
							this.ShowMessageInFormConfirm(dataSet.Tables["Results"].Rows[0]["message"].ToString(), frmOrderFormConfirm.OpenStyle.ShowBox);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowMessageInFormConfirm(ex.Message, frmOrderFormConfirm.OpenStyle.ShowBox);
			}
			return result;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00014DC0 File Offset: 0x000131C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucSmart1Click.ShowMessageInFormConfirmCallBack(this.ShowMessageInFormConfirm), new object[]
				{
					message,
					openStyle
				});
			}
			else
			{
				try
				{
					if (this.frmConfirm != null)
					{
						if (!this.frmConfirm.IsDisposed)
						{
							this.frmConfirm.Dispose();
						}
						this.frmConfirm = null;
					}
					this.frmConfirm = new frmOrderFormConfirm(message, openStyle);
					this.frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this.frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this.frmConfirm.TopLevel = false;
					if (base.Parent.GetType() == typeof(Panel))
					{
						this.frmConfirm.Parent = base.Parent.Parent;
					}
					else if (base.Parent.GetType().BaseType == typeof(ClientBaseForm))
					{
						this.frmConfirm.Parent = base.Parent;
					}
					else if (base.Parent.Parent.Parent.GetType() == typeof(frmMain))
					{
						this.frmConfirm.Parent = base.Parent.Parent.Parent;
					}
					this.frmConfirm.Location = new Point((this.frmConfirm.Parent.Width - this.frmConfirm.Width) / 2, (this.frmConfirm.Parent.Height - this.frmConfirm.Height) / 2);
					this.frmConfirm.TopMost = true;
					this.frmConfirm.Show();
					this.frmConfirm.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("ShowMessageInFormConfirm", ex);
				}
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0001500C File Offset: 0x0001340C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				DialogResult result = ((frmOrderFormConfirm)sender).Result;
				frmOrderFormConfirm.OpenStyle openFormStyle = ((frmOrderFormConfirm)sender).OpenFormStyle;
				if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmCancel)
				{
					if (result == DialogResult.OK)
					{
						Thread thread = new Thread(new ThreadStart(this.LoopCancelOrder));
						thread.Start();
					}
					else
					{
						RecordItem recordItem = this.sortGrid.Find("price", Utilities.PriceFormat(this._cancelPrice));
						if (recordItem != null)
						{
							if (this._cancelSide == "B")
							{
								recordItem.Fields("buycancel").Text = "0";
							}
							else if (this._cancelSide == "S")
							{
								recordItem.Fields("sellcancel").Text = "0";
							}
							this.sortGrid.EndUpdate();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00015164 File Offset: 0x00013564
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void changeDefaultVolume_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Settings.Default.SmartClickVolume = Convert.ToInt64((sender as ToolStripButton).Text.Replace(",", ""));
				this.tstbDefVol.Text = Utilities.VolumeFormat(Settings.Default.SmartClickVolume, true);
			}
			catch (Exception ex)
			{
				this.ShowError("changeDefaultVolume_Click", ex);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000151F8 File Offset: 0x000135F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnUpPrice_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender == this.tsbtnUpPrice)
				{
					Settings.Default.SmartClickVolume += (long)this._stockInfo.BoardLot;
				}
				else
				{
					Settings.Default.SmartClickVolume -= (long)this._stockInfo.BoardLot;
					if (Settings.Default.SmartClickVolume <= 0L)
					{
						Settings.Default.SmartClickVolume = (long)this._stockInfo.BoardLot;
					}
				}
				this.tstbDefVol.Text = Utilities.VolumeFormat(Settings.Default.SmartClickVolume.ToString(), true);
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnUpPrice_Click", ex);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000152E8 File Offset: 0x000136E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbDefVol_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tstbDefVol.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tstbDefVol.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tstbDefVol.Text.Replace(",", ""));
							this.tstbDefVol.Text = num.ToString("#,###");
							this.tstbDefVol.Select(this.tstbDefVol.Text.Length, 0);
						}
						catch
						{
							this.tstbDefVol.Text = this.tstbDefVol.Text.Substring(0, this.tstbDefVol.Text.Length - 1);
						}
					}
					else
					{
						this.tstbDefVol.Text = this.tstbDefVol.Text.Substring(0, this.tstbDefVol.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tstbDefVol_TextChanged", ex);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00015468 File Offset: 0x00013868
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbDefVol_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tstbDefVol.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tstbDefVol.Text))
					{
						try
						{
							decimal d = Convert.ToInt64(this.tstbDefVol.Text.Replace(",", ""));
							if (!(d > 0m) || !(d < this._stockInfo.BoardLot))
							{
								d %= this._stockInfo.BoardLot;
								if (d > 0m)
								{
									this.tstbDefVol.Text = Utilities.VolumeFormat(Settings.Default.SmartClickVolume, true);
								}
								else
								{
									Settings.Default.SmartClickVolume = Convert.ToInt64(this.tstbDefVol.Text.Replace(",", ""));
								}
							}
						}
						catch
						{
							this.tstbDefVol.Text = Utilities.VolumeFormat(Settings.Default.SmartClickVolume, true);
						}
					}
					else
					{
						this.tstbDefVol.Text = Utilities.VolumeFormat(Settings.Default.SmartClickVolume, true);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tstbDefVol_Leave", ex);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00015654 File Offset: 0x00013A54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplash(bool visible, string message, bool isAutoClose)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucSmart1Click.ShowSplashCallBack(this.ShowSplash), new object[]
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
							this.tmCloseSplash = new System.Windows.Forms.Timer();
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

		// Token: 0x06000165 RID: 357 RVA: 0x00015804 File Offset: 0x00013C04
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00015830 File Offset: 0x00013C30
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0001585C File Offset: 0x00013C5C
		public bool IsLoadingData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._isLoading;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (!base.DesignMode)
				{
					this._isLoading = value;
					this.ShowSplash(this._isLoading, "Loading...", false);
				}
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000158A4 File Offset: 0x00013CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSmartStock(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._isInit)
			{
				if (source == SymbolLinkSource.SmartStock)
				{
					this.setNewStock(newStock, false);
				}
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000158EC File Offset: 0x00013CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void panelTitle_Paint(object sender, PaintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.ClipRectangle.Width == this.panelTitle.Width)
			{
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				Color teal = Color.Teal;
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(e.ClipRectangle, teal, Color.FromArgb(80, teal), LinearGradientMode.Vertical))
				{
					e.Graphics.FillRectangle(linearGradientBrush, e.ClipRectangle);
				}
				using (StringFormat stringFormat = new StringFormat())
				{
					stringFormat.Alignment = StringAlignment.Center;
					stringFormat.LineAlignment = StringAlignment.Center;
					e.Graphics.DrawString("Smart One Click", this.Font, Brushes.LightGray, e.ClipRectangle, stringFormat);
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00015A04 File Offset: 0x00013E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sortGrid_ItemDragDrop(object sender, TableMouseEventArgs e, string dragValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.setNewStock(dragValue, false);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00015A20 File Offset: 0x00013E20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void chbSmartClick_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Settings.Default.SmartOneClick = this.chbSmartClick.Checked;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00015A48 File Offset: 0x00013E48
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

		// Token: 0x0600016D RID: 365 RVA: 0x00015A98 File Offset: 0x00013E98
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
			this.toolStrip2 = new ToolStrip();
			this.tsbtnDownPrice = new ToolStripButton();
			this.tstbDefVol = new ToolStripTextBox();
			this.tsbtnUpPrice = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.tsbtnDefVol100 = new ToolStripButton();
			this.tsbtnDefVol1000 = new ToolStripButton();
			this.tsbtnDefVol200 = new ToolStripButton();
			this.tsbtnDefVol500 = new ToolStripButton();
			this.tsbtnDefVol10K = new ToolStripButton();
			this.tsbtnDefVol20K = new ToolStripButton();
			this.tsbtnDefVol100K = new ToolStripButton();
			this.contextMenuStrip1 = new ContextMenuStrip(this.components);
			this.lbLoading = new Label();
			this.panelTitle = new Panel();
			this.toolTip1 = new ToolTip(this.components);
			this.panel1 = new Panel();
			this.chbDeposit = new CheckBox();
			this.chbSmartClick = new CheckBox();
			this.sortGrid = new SortGrid();
			this.tslbStock = new ToolStripLabel();
			this.toolStrip2.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip2.BackColor = Color.FromArgb(30, 30, 30);
			this.toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new ToolStripItem[]
			{
				this.tslbStock,
				this.tsbtnDownPrice,
				this.tstbDefVol,
				this.tsbtnUpPrice,
				this.toolStripSeparator2,
				this.tsbtnDefVol100,
				this.tsbtnDefVol1000,
				this.tsbtnDefVol200,
				this.tsbtnDefVol500,
				this.tsbtnDefVol10K,
				this.tsbtnDefVol20K,
				this.tsbtnDefVol100K
			});
			this.toolStrip2.LayoutStyle = ToolStripLayoutStyle.Flow;
			this.toolStrip2.Location = new Point(0, 46);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new Padding(1, 1, 1, 2);
			this.toolStrip2.RenderMode = ToolStripRenderMode.System;
			this.toolStrip2.Size = new Size(348, 48);
			this.toolStrip2.TabIndex = 4;
			this.toolStrip2.Tag = "-1";
			this.tsbtnDownPrice.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnDownPrice.Image = Resources.MovePreviousHS;
			this.tsbtnDownPrice.ImageTransparentColor = Color.Magenta;
			this.tsbtnDownPrice.Name = "tsbtnDownPrice";
			this.tsbtnDownPrice.Padding = new Padding(2, 0, 2, 0);
			this.tsbtnDownPrice.Size = new Size(24, 20);
			this.tsbtnDownPrice.Click += new EventHandler(this.tsbtnUpPrice_Click);
			this.tstbDefVol.BackColor = Color.Gainsboro;
			this.tstbDefVol.BorderStyle = BorderStyle.FixedSingle;
			this.tstbDefVol.ForeColor = Color.Black;
			this.tstbDefVol.MaxLength = 9;
			this.tstbDefVol.Name = "tstbDefVol";
			this.tstbDefVol.Size = new Size(80, 23);
			this.tstbDefVol.Text = "100";
			this.tstbDefVol.TextBoxTextAlign = HorizontalAlignment.Center;
			this.tstbDefVol.Leave += new EventHandler(this.tstbDefVol_Leave);
			this.tstbDefVol.TextChanged += new EventHandler(this.tstbDefVol_TextChanged);
			this.tsbtnUpPrice.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnUpPrice.Image = Resources.MoveNextHS;
			this.tsbtnUpPrice.ImageTransparentColor = Color.Magenta;
			this.tsbtnUpPrice.Name = "tsbtnUpPrice";
			this.tsbtnUpPrice.Padding = new Padding(2, 0, 2, 0);
			this.tsbtnUpPrice.Size = new Size(24, 20);
			this.tsbtnUpPrice.Click += new EventHandler(this.tsbtnUpPrice_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 23);
			this.tsbtnDefVol100.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnDefVol100.ForeColor = Color.LightGray;
			this.tsbtnDefVol100.ImageTransparentColor = Color.Magenta;
			this.tsbtnDefVol100.Name = "tsbtnDefVol100";
			this.tsbtnDefVol100.Size = new Size(29, 19);
			this.tsbtnDefVol100.Text = "100";
			this.tsbtnDefVol100.Click += new EventHandler(this.changeDefaultVolume_Click);
			this.tsbtnDefVol1000.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnDefVol1000.ForeColor = Color.LightGray;
			this.tsbtnDefVol1000.ImageTransparentColor = Color.Magenta;
			this.tsbtnDefVol1000.Name = "tsbtnDefVol1000";
			this.tsbtnDefVol1000.Size = new Size(38, 19);
			this.tsbtnDefVol1000.Text = "1,000";
			this.tsbtnDefVol1000.Click += new EventHandler(this.changeDefaultVolume_Click);
			this.tsbtnDefVol200.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnDefVol200.ForeColor = Color.LightGray;
			this.tsbtnDefVol200.ImageTransparentColor = Color.Magenta;
			this.tsbtnDefVol200.Name = "tsbtnDefVol200";
			this.tsbtnDefVol200.Size = new Size(35, 19);
			this.tsbtnDefVol200.Text = "2000";
			this.tsbtnDefVol200.Click += new EventHandler(this.changeDefaultVolume_Click);
			this.tsbtnDefVol500.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnDefVol500.ForeColor = Color.LightGray;
			this.tsbtnDefVol500.ImageTransparentColor = Color.Magenta;
			this.tsbtnDefVol500.Name = "tsbtnDefVol500";
			this.tsbtnDefVol500.Size = new Size(35, 19);
			this.tsbtnDefVol500.Text = "5000";
			this.tsbtnDefVol500.Click += new EventHandler(this.changeDefaultVolume_Click);
			this.tsbtnDefVol10K.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnDefVol10K.ForeColor = Color.LightGray;
			this.tsbtnDefVol10K.ImageTransparentColor = Color.Magenta;
			this.tsbtnDefVol10K.Name = "tsbtnDefVol10K";
			this.tsbtnDefVol10K.Size = new Size(44, 19);
			this.tsbtnDefVol10K.Text = "10,000";
			this.tsbtnDefVol10K.Click += new EventHandler(this.changeDefaultVolume_Click);
			this.tsbtnDefVol20K.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnDefVol20K.ForeColor = Color.LightGray;
			this.tsbtnDefVol20K.ImageTransparentColor = Color.Magenta;
			this.tsbtnDefVol20K.Name = "tsbtnDefVol20K";
			this.tsbtnDefVol20K.Size = new Size(44, 19);
			this.tsbtnDefVol20K.Text = "20,000";
			this.tsbtnDefVol20K.Click += new EventHandler(this.changeDefaultVolume_Click);
			this.tsbtnDefVol100K.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnDefVol100K.ForeColor = Color.LightGray;
			this.tsbtnDefVol100K.ImageTransparentColor = Color.Magenta;
			this.tsbtnDefVol100K.Name = "tsbtnDefVol100K";
			this.tsbtnDefVol100K.Size = new Size(50, 19);
			this.tsbtnDefVol100K.Text = "100,000";
			this.tsbtnDefVol100K.Click += new EventHandler(this.changeDefaultVolume_Click);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(61, 4);
			this.lbLoading.AutoSize = true;
			this.lbLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbLoading.ForeColor = Color.Yellow;
			this.lbLoading.Location = new Point(109, 254);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Padding = new Padding(5, 3, 5, 3);
			this.lbLoading.Size = new Size(76, 23);
			this.lbLoading.TabIndex = 9;
			this.lbLoading.Text = "Loading ...";
			this.lbLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbLoading.Visible = false;
			this.panelTitle.BackColor = Color.FromArgb(20, 20, 20);
			this.panelTitle.Dock = DockStyle.Top;
			this.panelTitle.Location = new Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new Size(348, 21);
			this.panelTitle.TabIndex = 88;
			this.panelTitle.Paint += new PaintEventHandler(this.panelTitle_Paint);
			this.panel1.BackColor = Color.FromArgb(30, 30, 30);
			this.panel1.Controls.Add(this.chbDeposit);
			this.panel1.Controls.Add(this.chbSmartClick);
			this.panel1.Dock = DockStyle.Top;
			this.panel1.Location = new Point(0, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(348, 25);
			this.panel1.TabIndex = 89;
			this.chbDeposit.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.chbDeposit.AutoSize = true;
			this.chbDeposit.ForeColor = Color.OrangeRed;
			this.chbDeposit.Location = new Point(191, 5);
			this.chbDeposit.Name = "chbDeposit";
			this.chbDeposit.Size = new Size(62, 17);
			this.chbDeposit.TabIndex = 1;
			this.chbDeposit.Text = "Deposit";
			this.chbDeposit.UseVisualStyleBackColor = true;
			this.chbSmartClick.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.chbSmartClick.AutoSize = true;
			this.chbSmartClick.ForeColor = Color.PaleGreen;
			this.chbSmartClick.Location = new Point(264, 5);
			this.chbSmartClick.Name = "chbSmartClick";
			this.chbSmartClick.Size = new Size(79, 17);
			this.chbSmartClick.TabIndex = 0;
			this.chbSmartClick.Text = "Smart Click";
			this.chbSmartClick.UseVisualStyleBackColor = true;
			this.chbSmartClick.CheckedChanged += new EventHandler(this.chbSmartClick_CheckedChanged);
			this.sortGrid.AllowDrop = true;
			this.sortGrid.BackColor = Color.FromArgb(30, 30, 30);
			this.sortGrid.CanBlink = true;
			this.sortGrid.CanDrag = false;
			this.sortGrid.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "buycancel";
			columnItem.Text = "";
			columnItem.ValueFormat = FormatType.Bitmap;
			columnItem.Visible = true;
			columnItem.Width = 7;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "buydeal";
			columnItem2.Text = "#";
			columnItem2.ValueFormat = FormatType.Volume;
			columnItem2.Visible = true;
			columnItem2.Width = 10;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.Cyan;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "buyvol";
			columnItem3.Text = "Buy";
			columnItem3.ValueFormat = FormatType.BidOfferVolume;
			columnItem3.Visible = true;
			columnItem3.Width = 23;
			columnItem4.Alignment = StringAlignment.Center;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "price";
			columnItem4.Text = "Price";
			columnItem4.ValueFormat = FormatType.Price;
			columnItem4.Visible = true;
			columnItem4.Width = 20;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.Magenta;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "sellvol";
			columnItem5.Text = "Sell";
			columnItem5.ValueFormat = FormatType.BidOfferVolume;
			columnItem5.Visible = true;
			columnItem5.Width = 23;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "selldeal";
			columnItem6.Text = "#";
			columnItem6.ValueFormat = FormatType.Volume;
			columnItem6.Visible = true;
			columnItem6.Width = 10;
			columnItem7.Alignment = StringAlignment.Near;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "sellcancel";
			columnItem7.Text = "";
			columnItem7.ValueFormat = FormatType.Bitmap;
			columnItem7.Visible = true;
			columnItem7.Width = 7;
			this.sortGrid.Columns.Add(columnItem);
			this.sortGrid.Columns.Add(columnItem2);
			this.sortGrid.Columns.Add(columnItem3);
			this.sortGrid.Columns.Add(columnItem4);
			this.sortGrid.Columns.Add(columnItem5);
			this.sortGrid.Columns.Add(columnItem6);
			this.sortGrid.Columns.Add(columnItem7);
			this.sortGrid.CurrentScroll = 0;
			this.sortGrid.Cursor = Cursors.Hand;
			this.sortGrid.Dock = DockStyle.Fill;
			this.sortGrid.FocusItemIndex = -1;
			this.sortGrid.ForeColor = Color.Black;
			this.sortGrid.GridColor = Color.FromArgb(45, 45, 45);
			this.sortGrid.HeaderPctHeight = 80f;
			this.sortGrid.IsAutoRepaint = true;
			this.sortGrid.IsDrawFullRow = false;
			this.sortGrid.IsDrawGrid = true;
			this.sortGrid.IsDrawHeader = true;
			this.sortGrid.IsScrollable = true;
			this.sortGrid.Location = new Point(0, 94);
			this.sortGrid.MainColumn = "";
			this.sortGrid.Name = "sortGrid";
			this.sortGrid.Rows = 0;
			this.sortGrid.RowSelectColor = Color.FromArgb(64, 64, 64);
			this.sortGrid.RowSelectType = 1;
			this.sortGrid.RowsVisible = 0;
			this.sortGrid.Size = new Size(348, 437);
			this.sortGrid.SortColumnName = "";
			this.sortGrid.SortType = SortType.Desc;
			this.sortGrid.TabIndex = 5;
			this.sortGrid.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.sortGrid_TableMouseClick);
			this.sortGrid.ItemDragDrop += new SortGrid.ItemDragDropEventHandler(this.sortGrid_ItemDragDrop);
			this.tslbStock.ForeColor = Color.Yellow;
			this.tslbStock.Name = "tslbStock";
			this.tslbStock.Padding = new Padding(3, 0, 0, 0);
			this.tslbStock.Size = new Size(50, 15);
			this.tslbStock.Text = "Symbol";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.Controls.Add(this.lbLoading);
			base.Controls.Add(this.sortGrid);
			base.Controls.Add(this.toolStrip2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panelTitle);
			base.Name = "ucSmart1Click";
			base.Size = new Size(348, 531);
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000096 RID: 150
		private StockList.StockInformation _stockInfo;

		// Token: 0x04000097 RID: 151
		private BackgroundWorker bgwReloadData;

		// Token: 0x04000098 RID: 152
		private BackgroundWorker bgwGetOrderForCancel;

		// Token: 0x04000099 RID: 153
		private DataSet tdsMainInfo;

		// Token: 0x0400009A RID: 154
		private bool _isInit;

		// Token: 0x0400009B RID: 155
		private System.Windows.Forms.Timer tmLoad;

		// Token: 0x0400009C RID: 156
		private Dictionary<string, ucSmart1Click.RecordData> _lstOrder;

		// Token: 0x0400009D RID: 157
		private decimal _price;

		// Token: 0x0400009E RID: 158
		private string _cancelSide;

		// Token: 0x0400009F RID: 159
		private decimal _cancelPrice;

		// Token: 0x040000A0 RID: 160
		private Point _cancelLocation;

		// Token: 0x040000A1 RID: 161
		private DataSet tdsOrderForCancel;

		// Token: 0x040000A2 RID: 162
		private Dictionary<long, string> _listOfOrderCancel;

		// Token: 0x040000A3 RID: 163
		private frmOrderFormConfirm frmConfirm;

		// Token: 0x040000A4 RID: 164
		private System.Windows.Forms.Timer tmCloseSplash;

		// Token: 0x040000A5 RID: 165
		private bool _isLoading;

		// Token: 0x040000A6 RID: 166
		private IContainer components;

		// Token: 0x040000A7 RID: 167
		private ToolStrip toolStrip2;

		// Token: 0x040000A8 RID: 168
		private ToolStripButton tsbtnDefVol100;

		// Token: 0x040000A9 RID: 169
		private ToolStripButton tsbtnDefVol1000;

		// Token: 0x040000AA RID: 170
		private ToolStripButton tsbtnDefVol10K;

		// Token: 0x040000AB RID: 171
		private SortGrid sortGrid;

		// Token: 0x040000AC RID: 172
		private ToolStripButton tsbtnDownPrice;

		// Token: 0x040000AD RID: 173
		private ToolStripButton tsbtnUpPrice;

		// Token: 0x040000AE RID: 174
		private ToolStripTextBox tstbDefVol;

		// Token: 0x040000AF RID: 175
		private ToolStripButton tsbtnDefVol20K;

		// Token: 0x040000B0 RID: 176
		private ToolStripButton tsbtnDefVol200;

		// Token: 0x040000B1 RID: 177
		private ToolStripButton tsbtnDefVol500;

		// Token: 0x040000B2 RID: 178
		private ContextMenuStrip contextMenuStrip1;

		// Token: 0x040000B3 RID: 179
		private Label lbLoading;

		// Token: 0x040000B4 RID: 180
		private Panel panelTitle;

		// Token: 0x040000B5 RID: 181
		private ToolTip toolTip1;

		// Token: 0x040000B6 RID: 182
		private ToolStripButton tsbtnDefVol100K;

		// Token: 0x040000B7 RID: 183
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x040000B8 RID: 184
		private Panel panel1;

		// Token: 0x040000B9 RID: 185
		private CheckBox chbDeposit;

		// Token: 0x040000BA RID: 186
		private CheckBox chbSmartClick;

		// Token: 0x040000BB RID: 187
		private ToolStripLabel tslbStock;

		// Token: 0x040000BC RID: 188
		//[CompilerGenerated]
		//private static Comparison<decimal> <>9__CachedAnonymousMethodDelegate1;

		// Token: 0x02000025 RID: 37
		private struct RecordData
		{
			// Token: 0x040000BD RID: 189
			public int buyDeal;

			// Token: 0x040000BE RID: 190
			public long buyVol;

			// Token: 0x040000BF RID: 191
			public decimal price;

			// Token: 0x040000C0 RID: 192
			public long sellVol;

			// Token: 0x040000C1 RID: 193
			public int sellDeal;
		}

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate void ReceiveOrderInfoCallBack(IBroadcastMessage message);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate void ShowMessageInFormConfirmCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate void ShowSplashCallBack(bool visible, string message, bool isAutoClose);
	}
}
