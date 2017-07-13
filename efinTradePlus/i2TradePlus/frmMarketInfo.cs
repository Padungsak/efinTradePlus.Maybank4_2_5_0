using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using STIControl;
using STIControl.CustomGrid;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x0200022A RID: 554
	public class frmMarketInfo : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x0600143C RID: 5180 RVA: 0x0010F564 File Offset: 0x0010D964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmMarketInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.IndustryNumber = -1;
			this._recvDataRealTime = default(frmMarketInfo.RecordData);
			this.bgwReloadData = null;
			this.tdsSectorInfo = null;
			this.sortType = SortType.Asc;
			this.bgwMarketInfoLoadData = null;
			this.bgwReloadChart = null;
			this.dsMarketInfo = null;
			this.selectionMenu = 0;
			this.isLoading = true;
			this._currentChartName = string.Empty;
			this.components = null;
			base..ctor();
			this.InitializeComponent();
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0010F5F4 File Offset: 0x0010D9F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmMarketInfo(Dictionary<string, object> properties)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.IndustryNumber = -1;
			this._recvDataRealTime = default(frmMarketInfo.RecordData);
			this.bgwReloadData = null;
			this.tdsSectorInfo = null;
			this.sortType = SortType.Asc;
			this.bgwMarketInfoLoadData = null;
			this.bgwReloadChart = null;
			this.dsMarketInfo = null;
			this.selectionMenu = 0;
			this.isLoading = true;
			this._currentChartName = string.Empty;
			this.components = null;
			base..ctor(properties);
			this.InitializeComponent();
			try
			{
				this.bgwReloadData = new BackgroundWorker();
				this.bgwReloadData.WorkerSupportsCancellation = true;
				this.bgwReloadData.WorkerReportsProgress = true;
				this.bgwReloadData.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
				this.bgwReloadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
				this.bgwMarketInfoLoadData = new BackgroundWorker();
				this.bgwMarketInfoLoadData.DoWork += new DoWorkEventHandler(this.bgwMarketInfoLoadData_DoWork);
				this.bgwMarketInfoLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwMarketInfoLoadData_RunWorkerCompleted);
				this.bgwReloadChart = new BackgroundWorker();
				this.bgwReloadChart.WorkerReportsProgress = true;
				this.bgwReloadChart.DoWork += new DoWorkEventHandler(this.bgwReloadChart_DoWork);
				this.bgwReloadChart.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadChart_RunWorkerCompleted);
				this.intzaSET.Records(0).Fields("name").Text = "SET";
				this.intzaSET.Records(3).Fields("name").Text = "SET50";
				this.intzaSET.Records(6).Fields("name").Text = "SET100";
				this.intzaSET.Records(9).Fields("name").Text = "sSET";
				this.intzaSET.Records(12).Fields("name").Text = "MAI";
				this.intzaSET.Records(15).Fields("name").Text = "SETHD";
				this.intzaSET.Records(0).Fields("name").FontColor = Color.Black;
				this.intzaSET.Records(3).Fields("name").FontColor = Color.Black;
				this.intzaSET.Records(6).Fields("name").FontColor = Color.Black;
				this.intzaSET.Records(9).Fields("name").FontColor = Color.Black;
				this.intzaSET.Records(12).Fields("name").FontColor = Color.Black;
				this.intzaSET.Records(15).Fields("name").FontColor = Color.Black;
				this.intzaSET.Records(0).Fields("name").BackColor = Color.Gold;
				this.intzaSET.Records(3).Fields("name").BackColor = Color.Gold;
				this.intzaSET.Records(6).Fields("name").BackColor = Color.Gold;
				this.intzaSET.Records(9).Fields("name").BackColor = Color.Gold;
				this.intzaSET.Records(12).Fields("name").BackColor = Color.Gold;
				this.intzaSET.Records(15).Fields("name").BackColor = Color.Gold;
				this.intzaSET.Records(0).Fields("name").FontStyle = FontStyle.Bold;
				this.intzaSET.Records(3).Fields("name").FontStyle = FontStyle.Bold;
				this.intzaSET.Records(6).Fields("name").FontStyle = FontStyle.Bold;
				this.intzaSET.Records(9).Fields("name").FontStyle = FontStyle.Bold;
				this.intzaSET.Records(12).Fields("name").FontStyle = FontStyle.Bold;
				this.intzaSET.Records(15).Fields("name").FontStyle = FontStyle.Bold;
				this.intzaSET.Records(1).Fields("name").Text = "High :";
				this.intzaSET.Records(4).Fields("name").Text = "High :";
				this.intzaSET.Records(7).Fields("name").Text = "High :";
				this.intzaSET.Records(10).Fields("name").Text = "High :";
				this.intzaSET.Records(13).Fields("name").Text = "High :";
				this.intzaSET.Records(16).Fields("name").Text = "High :";
				this.intzaSET.Records(1).Fields("name").FontColor = Color.Cyan;
				this.intzaSET.Records(4).Fields("name").FontColor = Color.Cyan;
				this.intzaSET.Records(7).Fields("name").FontColor = Color.Cyan;
				this.intzaSET.Records(10).Fields("name").FontColor = Color.Cyan;
				this.intzaSET.Records(13).Fields("name").FontColor = Color.Cyan;
				this.intzaSET.Records(16).Fields("name").FontColor = Color.Cyan;
				this.intzaSET.Records(2).Fields("name").Text = "Low :";
				this.intzaSET.Records(5).Fields("name").Text = "Low :";
				this.intzaSET.Records(8).Fields("name").Text = "Low :";
				this.intzaSET.Records(11).Fields("name").Text = "Low :";
				this.intzaSET.Records(14).Fields("name").Text = "Low :";
				this.intzaSET.Records(17).Fields("name").Text = "Low :";
				this.intzaSET.Records(2).Fields("name").FontColor = Color.Magenta;
				this.intzaSET.Records(5).Fields("name").FontColor = Color.Magenta;
				this.intzaSET.Records(8).Fields("name").FontColor = Color.Magenta;
				this.intzaSET.Records(11).Fields("name").FontColor = Color.Magenta;
				this.intzaSET.Records(14).Fields("name").FontColor = Color.Magenta;
				this.intzaSET.Records(17).Fields("name").FontColor = Color.Magenta;
				this.intzaSET.Records(0).BackColor = Color.FromArgb(30, 30, 30);
				this.intzaSET.Records(3).BackColor = Color.FromArgb(30, 30, 30);
				this.intzaSET.Records(6).BackColor = Color.FromArgb(30, 30, 30);
				this.intzaSET.Records(9).BackColor = Color.FromArgb(30, 30, 30);
				this.intzaSET.Records(12).BackColor = Color.FromArgb(30, 30, 30);
				this.intzaSET.Records(15).BackColor = Color.FromArgb(30, 30, 30);
			}
			catch (Exception ex)
			{
				this.ShowError("frmMarketInfo", ex);
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0010FE74 File Offset: 0x0010E274
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				if (this.tdsSectorInfo == null)
				{
					this.tdsSectorInfo = new DataSet();
				}
				this.ShowSplash2(true);
				string text = string.Empty;
				try
				{
					if (this.selectionMenu == 0)
					{
						text = ApplicationInfo.WebService.SectorStat();
					}
					else
					{
						text = ApplicationInfo.WebService.IndustryStat();
					}
					this.tdsSectorInfo.Clear();
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.tdsSectorInfo);
					}
				}
				catch (Exception ex)
				{
					this.ShowError("RequestWebData", ex);
				}
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0010FF54 File Offset: 0x0010E354
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					this.UpdateToControl(this.tdsSectorInfo);
					this.tdsSectorInfo.Clear();
					this.ShowSplash2(false);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0010FFD0 File Offset: 0x0010E3D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSectorInformation_IDOShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.SetResize(true);
				this.SetTextSortColumn("symbol");
				this.SetSort(SortType.Asc);
				this.SetPage(0);
				this.MarketInfoReloadDataSETindex();
				base.Show();
			}
			catch (Exception ex)
			{
				this.ShowError("frmSectorInformation_IDOShownDelay", ex);
			}
			base.OpenedForm();
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00110054 File Offset: 0x0010E454
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMarketInfo_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.MarketInfoReloadData();
				this.SetChart("INFO", this.tsbtnInfo);
			}
			catch (Exception ex)
			{
				this.ShowError("frmMarketInfo_IDoLoadData", ex);
			}
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x001100B8 File Offset: 0x0010E4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSectorStatistic_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.isLoading)
			{
				this.SetResize(this.IsWidthChanged || this.IsHeightChanged);
				base.Show();
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00110108 File Offset: 0x0010E508
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSectorStatistic_IDoFontChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.isLoading)
			{
				this.SetResize(true);
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0011013C File Offset: 0x0010E53C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.isLoading)
			{
				if (message.MessageType == "IE")
				{
					IEMessage iEMessage = (IEMessage)message;
					IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo[iEMessage.Symbol];
					if (indexItem != null)
					{
						int num = this.intzaSector.FindIndex("symbol", indexItem.Symbol);
						if (num > -1)
						{
							this._recvDataRealTime.Symbol = indexItem.Symbol;
							this._recvDataRealTime.Number = indexItem.Number;
							this._recvDataRealTime.AccVolume = iEMessage.AccVolume;
							this._recvDataRealTime.AccValue = iEMessage.AccValue;
							this._recvDataRealTime.Index = iEMessage.IndexValue;
							IndexStat.IndexItem indexItem2 = ApplicationInfo.IndexStatInfo[".SET"];
							if (indexItem2 != null)
							{
								if (indexItem2.AccValue > 0m)
								{
									this._recvDataRealTime.Mkt = iEMessage.AccValue / indexItem2.AccValue * 100m;
								}
							}
							this._recvDataRealTime.IndexPrior = indexItem.Prior;
							this.UpdateToGrid(num + 1, this._recvDataRealTime);
							if (base.IsAllowRender)
							{
								this.intzaSector.EndUpdate(num);
							}
						}
					}
				}
				else if (message.MessageType.ToUpper() == "IS")
				{
					ISMessage iSMessage = (ISMessage)message;
					this.ShowSetIndex(iSMessage.Symbol);
					if (base.IsAllowRender)
					{
						this.intzaSET.EndUpdate();
					}
					if (iSMessage.Symbol == ".SET")
					{
						this.MarketInfoUpdateByMT(iSMessage.MainAccVolume, iSMessage.MainAccValue, iSMessage.OddlotAccVolume, iSMessage.OddlotAccValue, iSMessage.BiglotAccVolume, iSMessage.BiglotAccValue, iSMessage.ForeignAccVolume, iSMessage.ForeignAccValue);
						this.MarketInfoUpdateByIS(iSMessage.Tick, iSMessage.Trin, iSMessage.SecurityUp, iSMessage.SecurityDown, iSMessage.SecurityNoChange, iSMessage.UpVolume * 1000L, iSMessage.DownVolume * 1000L, iSMessage.NoChangeVolume * 1000L);
					}
					if (base.IsAllowRender)
					{
						this.intzaMarketInfo.EndUpdate();
						this.intzaBoard.Redraw();
					}
				}
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00110414 File Offset: 0x0010E814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00110428 File Offset: 0x0010E828
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToGrid(int rowIndex, frmMarketInfo.RecordData recordData)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!string.IsNullOrEmpty(recordData.Symbol))
				{
					RecordItem recordItem = this.intzaSector.Records(rowIndex - 1);
					if (recordItem != null)
					{
						recordItem.Fields("symbol").Text = recordData.Symbol;
						recordItem.Fields("prior").Text = recordData.IndexPrior;
						recordItem.Fields("last").Text = recordData.Index;
						recordItem.Fields("volume").Text = recordData.AccVolume;
						recordItem.Fields("value").Text = recordData.AccValue;
						recordItem.Fields("pmkt").Text = recordData.Mkt;
						Color fontColor = MyColor.UnChgColor;
						decimal num = 0m;
						decimal num2 = 0m;
						if (recordData.Index > 0m && recordData.IndexPrior > 0m)
						{
							num = recordData.Index - recordData.IndexPrior;
							num2 = Math.Round(num / recordData.IndexPrior * 100m, 4);
							fontColor = Utilities.ComparePriceColor(num, 0m);
						}
						recordItem.Fields("chg").Text = num;
						recordItem.Fields("pchg").Text = num2;
						recordItem.Fields("symbol").FontColor = fontColor;
						recordItem.Fields("prior").FontColor = MyColor.UnChgColor;
						recordItem.Fields("volume").FontColor = fontColor;
						recordItem.Fields("value").FontColor = fontColor;
						recordItem.Fields("last").FontColor = fontColor;
						recordItem.Fields("chg").FontColor = fontColor;
						recordItem.Fields("pchg").FontColor = fontColor;
						recordItem.Fields("pmkt").FontColor = fontColor;
						recordItem.Changed = true;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToGrid", ex);
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x001106BC File Offset: 0x0010EABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwReloadData.IsBusy)
			{
				this.bgwReloadData.RunWorkerAsync(this.IndustryNumber);
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00110704 File Offset: 0x0010EB04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string empty = string.Empty;
				if (this.selectionMenu == 0)
				{
					this.intzaSector.BeginUpdate();
					if (ds.Tables["sector_stat_info"].Rows.Count > 0)
					{
						this.intzaSector.Rows = ds.Tables["sector_stat_info"].Rows.Count;
					}
					for (int i = 0; i < ds.Tables["sector_stat_info"].Rows.Count; i++)
					{
						DataRow dataRow = ds.Tables["sector_stat_info"].Rows[i];
						frmMarketInfo.RecordData recordData = default(frmMarketInfo.RecordData);
						recordData.Number = Convert.ToInt32(dataRow["sector_number"]);
						recordData.Symbol = dataRow["sector_symbol"].ToString().Trim();
						recordData.IndexPrior = Convert.ToDecimal(dataRow["index_prior"]);
						recordData.Index = Convert.ToDecimal(dataRow["index_value"]);
						recordData.AccVolume = Convert.ToInt64(dataRow["accvolume"]);
						recordData.AccValue = Convert.ToDecimal(dataRow["accvalue"]);
						recordData.Mkt = Convert.ToDecimal(dataRow["mkt"]);
						this.UpdateToGrid(i + 1, recordData);
					}
					this.intzaSector.Sort(this.intzaSector.SortColumnName, this.sortType);
					this.intzaSector.IsAutoRepaint = true;
					this.intzaSector.Invalidate();
				}
				else
				{
					this.intzaSector.BeginUpdate();
					if (ds.Tables["industry_stat"].Rows.Count > 0)
					{
						this.intzaSector.Rows = ds.Tables["industry_stat"].Rows.Count;
					}
					for (int i = 0; i < ds.Tables["industry_stat"].Rows.Count; i++)
					{
						DataRow dataRow2 = ds.Tables["industry_stat"].Rows[i];
						frmMarketInfo.RecordData recordData = default(frmMarketInfo.RecordData);
						recordData.Number = Convert.ToInt32(dataRow2["industry_number"]);
						recordData.Symbol = dataRow2["industry_symbol"].ToString();
						recordData.Index = Convert.ToDecimal(dataRow2["index_value"]);
						recordData.IndexPrior = Convert.ToDecimal(dataRow2["index_prior"]);
						recordData.AccVolume = Convert.ToInt64(dataRow2["accvolume"]);
						recordData.AccValue = Convert.ToDecimal(dataRow2["accvalue"]);
						recordData.Mkt = Convert.ToDecimal(dataRow2["mkt"]);
						this.UpdateToGrid(i + 1, recordData);
					}
					this.intzaSector.Sort(this.intzaSector.SortColumnName, this.sortType);
					this.intzaSector.IsAutoRepaint = true;
					this.intzaSector.Invalidate();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl", ex);
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00110AB8 File Offset: 0x0010EEB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SortColumn(string sortName, SortType sortTypeColumns)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.intzaSector.Sort(sortName, sortTypeColumns);
			this.intzaSector.Redraw();
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00110AE4 File Offset: 0x0010EEE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSort(SortType newSortType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.sortType = newSortType;
				this.tsbtnSortAsc.ForeColor = Color.Gray;
				this.tsbtnSortDesc.ForeColor = Color.Gray;
				if (newSortType == SortType.Asc)
				{
					this.tsbtnSortAsc.ForeColor = Color.Orange;
				}
				else
				{
					this.tsbtnSortDesc.ForeColor = Color.Orange;
				}
				this.SortColumn(this.intzaSector.SortColumnName, this.sortType);
			}
			catch (Exception ex)
			{
				this.ShowError("SetSort", ex);
			}
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00110BA4 File Offset: 0x0010EFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTextSortColumn(string sortName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tsSortBySector.ForeColor = Color.Gray;
			this.tsSortByVolume.ForeColor = Color.Gray;
			this.tsSortByValues.ForeColor = Color.Gray;
			if (sortName != null)
			{
				if (sortName == "symbol")
				{
					this.tsSortBySector.ForeColor = Color.Orange;
					goto IL_D7;
				}
				if (sortName == "volume")
				{
					this.tsSortByVolume.ForeColor = Color.Orange;
					goto IL_D7;
				}
				if (sortName == "value")
				{
					this.tsSortByValues.ForeColor = Color.Orange;
					goto IL_D7;
				}
			}
			this.tsSortBySector.ForeColor = Color.Orange;
			IL_D7:
			this.SortColumn(sortName, this.sortType);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00110C98 File Offset: 0x0010F098
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsSortBySector_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetTextSortColumn("symbol");
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00110CB8 File Offset: 0x0010F0B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsSortByIndustry_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetTextSortColumn("industry");
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00110CD8 File Offset: 0x0010F0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsSortByVolume_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetTextSortColumn("volume");
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00110CF8 File Offset: 0x0010F0F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsSortByValues_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetTextSortColumn("value");
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00110D18 File Offset: 0x0010F118
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSectorInformation_IDOCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.isLoading)
			{
				this.SetResize(this.IsHeightChanged | this.IsWidthChanged);
			}
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00110D58 File Offset: 0x0010F158
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
					this.intzaSET.SetBounds(0, 0, (int)((double)base.Width * 0.5), this.intzaSET.GetHeightByRows(12));
					this.toolStrip1.SetBounds(this.intzaSET.Left + this.intzaSET.Width + 1, 0, base.Width - (this.intzaSET.Right + 1), this.toolStrip1.Height);
					this.intzaBoard.SetBounds(this.intzaSET.Right + 2, this.toolStrip1.Bottom, base.Width - (this.intzaSET.Right + 1), this.intzaBoard.GetHeightByRows());
					this.intzaMarketInfo.SetBounds(this.intzaBoard.Left, this.intzaBoard.Bottom + 2, this.intzaBoard.Width, this.intzaSET.Height - this.toolStrip1.Bottom - 2 - this.intzaBoard.Height);
					this.pictureBox1.SetBounds(this.intzaBoard.Left, this.intzaBoard.Top, this.intzaBoard.Width, this.intzaSET.Height - this.toolStrip1.Bottom);
					this.panelSector.SetBounds(0, this.intzaSET.Bottom + 2, base.Width, base.Height - (this.intzaSET.Bottom + 2));
					if (this.pictureBox1.Visible)
					{
						this.ReloadChart();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00110F58 File Offset: 0x0010F358
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPage(int mode)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (mode == 0)
				{
					this.tsbtnSector.ForeColor = Color.Orange;
					this.tsbtnIndustry.ForeColor = Color.Gray;
					this.selectionMenu = 0;
					this.Text = "Sector Statistic";
				}
				else
				{
					this.tsbtnSector.ForeColor = Color.Gray;
					this.tsbtnIndustry.ForeColor = Color.Orange;
					this.selectionMenu = 1;
					this.Text = "Industry Statistic";
				}
				this.ReloadData();
			}
			catch (Exception ex)
			{
				this.ShowError("SetPage", ex);
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0011102C File Offset: 0x0010F42C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwMarketInfoLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				try
				{
					if (this.dsMarketInfo == null)
					{
						this.dsMarketInfo = new DataSet();
					}
					else
					{
						this.dsMarketInfo.Clear();
					}
					string text = ApplicationInfo.WebService.MarketIndicator();
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.dsMarketInfo);
					}
				}
				catch (Exception ex)
				{
					this.ShowError("MarketInfoRequestWebData", ex);
				}
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x001110DC File Offset: 0x0010F4DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwMarketInfoLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				this.MarketInfoUpdateToControl();
				this.dsMarketInfo.Clear();
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00111120 File Offset: 0x0010F520
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarketInfoReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwMarketInfoLoadData.IsBusy)
			{
				this.bgwMarketInfoLoadData.RunWorkerAsync();
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0011115C File Offset: 0x0010F55C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarketInfoUpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaMarketInfo.InvokeRequired)
			{
				this.intzaMarketInfo.Invoke(new MethodInvoker(this.MarketInfoUpdateToControl));
			}
			else
			{
				try
				{
					this.intzaMarketInfo.BeginUpdate();
					if (this.dsMarketInfo.Tables.Count > 0)
					{
						if (this.dsMarketInfo.Tables.Contains("market_info") && this.dsMarketInfo.Tables["market_info"].Rows.Count > 0)
						{
							DataRow dataRow = this.dsMarketInfo.Tables["market_info"].Rows[0];
							long mainVolume;
							long.TryParse(dataRow["main_accvolume"].ToString(), out mainVolume);
							long biglotVolume;
							long.TryParse(dataRow["biglot_accvolume"].ToString(), out biglotVolume);
							long oddlotVolume;
							long.TryParse(dataRow["oddlot_accvolume"].ToString(), out oddlotVolume);
							long foreignVolume;
							long.TryParse(dataRow["foreign_accvolume"].ToString(), out foreignVolume);
							decimal mainValue;
							decimal.TryParse(dataRow["main_accvalue"].ToString(), out mainValue);
							decimal biglotValue;
							decimal.TryParse(dataRow["biglot_accvalue"].ToString(), out biglotValue);
							decimal oddlogValue;
							decimal.TryParse(dataRow["oddlot_accvalue"].ToString(), out oddlogValue);
							decimal foreignValue;
							decimal.TryParse(dataRow["foreign_accvalue"].ToString(), out foreignValue);
							this.MarketInfoUpdateByMT(mainVolume, mainValue, oddlotVolume, oddlogValue, biglotVolume, biglotValue, foreignVolume, foreignValue);
							if (this.dsMarketInfo.Tables.Contains("set_index") && this.dsMarketInfo.Tables["set_index"].Rows.Count > 0)
							{
								decimal trin = 0m;
								DataRow dataRow2 = this.dsMarketInfo.Tables["set_index"].Rows[0];
								int num;
								int.TryParse(dataRow2["advances"].ToString(), out num);
								int num2;
								int.TryParse(dataRow2["declines"].ToString(), out num2);
								int securityNoChg;
								int.TryParse(dataRow2["nochg"].ToString(), out securityNoChg);
								long num3;
								long.TryParse(dataRow2["up_volume"].ToString(), out num3);
								long num4;
								long.TryParse(dataRow2["down_volume"].ToString(), out num4);
								long num5;
								long.TryParse(dataRow2["unchg_volume"].ToString(), out num5);
								int num6;
								int.TryParse(dataRow["compare_price_up"].ToString(), out num6);
								int num7;
								int.TryParse(dataRow["compare_price_down"].ToString(), out num7);
								if (num2 > 0 && num > 0)
								{
                                    trin = (decimal)Math.Round(num4 / (long)num2 / (num3 / (long)num), 2);
								}
								int tick = num6 - num7;
								this.MarketInfoUpdateByIS(tick, trin, num, num2, securityNoChg, num3 * 1000L, num4 * 1000L, num5 * 1000L);
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("MarketInfoUpdateToControl", ex);
				}
				finally
				{
					this.intzaMarketInfo.Redraw();
					this.intzaBoard.Redraw();
				}
			}
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00111550 File Offset: 0x0010F950
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarketInfoUpdateByMT(long mainVolume, decimal mainValue, long oddlotVolume, decimal oddlogValue, long biglotVolume, decimal biglotValue, long foreignVolume, decimal foreignValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = mainVolume + oddlotVolume + biglotVolume + foreignVolume;
				decimal num2 = mainValue + oddlogValue + biglotValue + foreignValue;
				decimal num3 = 0m;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				if (num2 > 0m)
				{
					num3 = mainValue / num2 * 100m;
					num6 = foreignValue / num2 * 100m;
					num5 = biglotValue / num2 * 100m;
					num4 = 100m - (num3 + num6 + num5);
				}
				RecordItem recordItem = this.intzaBoard.Records(0);
				recordItem.Fields("name").Text = "Main";
				recordItem.Fields("volume").Text = mainVolume;
				recordItem.Fields("value").Text = mainValue;
				recordItem.Fields("value_pct").Text = num3;
				recordItem = this.intzaBoard.Records(1);
				recordItem.Fields("name").Text = "Oddlot";
				recordItem.Fields("volume").Text = oddlotVolume;
				recordItem.Fields("value").Text = oddlogValue;
				if (num4 > 0m && num4 < 0.01m)
				{
					num4 = 0.01m;
				}
				recordItem.Fields("value_pct").Text = FormatUtil.PriceFormat(num4, 2, "0.00");
				recordItem = this.intzaBoard.Records(2);
				recordItem.Fields("name").Text = "Biglot";
				recordItem.Fields("volume").Text = biglotVolume;
				recordItem.Fields("value").Text = biglotValue;
				recordItem.Fields("value_pct").Text = num5;
				recordItem = this.intzaBoard.Records(3);
				recordItem.Fields("name").Text = "Foreign";
				recordItem.Fields("volume").Text = foreignVolume;
				recordItem.Fields("value").Text = foreignValue;
				recordItem.Fields("value_pct").Text = num6;
				recordItem = this.intzaBoard.Records(4);
				recordItem.Fields("name").Text = "Total";
				recordItem.Fields("volume").Text = num;
				recordItem.Fields("value").Text = num2;
				recordItem.Fields("value_pct").Text = "";
				for (int i = 0; i <= 4; i++)
				{
					recordItem = this.intzaBoard.Records(i);
					recordItem.Fields("name").FontColor = Color.LightGray;
					recordItem.Fields("volume").FontColor = MyColor.UnChgColor;
					recordItem.Fields("value").FontColor = MyColor.UnChgColor;
					recordItem.Fields("value_pct").FontColor = MyColor.UnChgColor;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("MarketInfoUpdateByMT", ex);
			}
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00111958 File Offset: 0x0010FD58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarketInfoUpdateByIS(int tick, decimal trin, int securityUp, int securityDown, int securityNoChg, long upVolume, long downVolume, long nochangeVolume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaMarketInfo.Item("tick_text").Text = tick.ToString();
				this.intzaMarketInfo.Item("tick_text").FontColor = MyColor.UnChgColor;
				this.intzaMarketInfo.Item("trin_text").Text = trin.ToString();
				this.intzaMarketInfo.Item("trin_text").FontColor = MyColor.UnChgColor;
				this.intzaMarketInfo.Item("up_text").Text = securityUp.ToString();
				this.intzaMarketInfo.Item("down_text").Text = securityDown.ToString();
				this.intzaMarketInfo.Item("nochange_text").Text = securityNoChg.ToString();
				this.intzaMarketInfo.Item("up_text").FontColor = MyColor.UpColor;
				this.intzaMarketInfo.Item("down_text").FontColor = MyColor.DownColor;
				this.intzaMarketInfo.Item("nochange_text").FontColor = MyColor.UnChgColor;
				this.intzaMarketInfo.Item("upvolume_text").Text = upVolume.ToString();
				this.intzaMarketInfo.Item("downvolume_text").Text = downVolume.ToString();
				this.intzaMarketInfo.Item("nochg_volume_text").Text = nochangeVolume.ToString();
				this.intzaMarketInfo.Item("upvolume_text").FontColor = MyColor.UpColor;
				this.intzaMarketInfo.Item("downvolume_text").FontColor = MyColor.DownColor;
				this.intzaMarketInfo.Item("nochg_volume_text").FontColor = MyColor.UnChgColor;
			}
			catch (Exception ex)
			{
				this.ShowError("MarketInfoUpdateByIS", ex);
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00111B70 File Offset: 0x0010FF70
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarketInfoReloadDataSETindex()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaSET.BeginUpdate();
				this.ShowSetIndex(".SET");
				this.ShowSetIndex(".SET50");
				this.ShowSetIndex(".SET100");
				this.ShowSetIndex(".sSET");
				this.ShowSetIndex(".SETHD");
				this.ShowSetIndex(".MAI");
				this.intzaSET.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("MarketInfoReloadDataSETindex", ex);
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00111C1C File Offset: 0x0011001C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSetIndex(string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo[symbol];
				if (indexItem != null)
				{
					decimal d = 0m;
					decimal num = 0m;
					Color fontColor = Utilities.ComparePriceColor(indexItem.LastIndex, indexItem.Prior);
					if (symbol == ".SET")
					{
						this.intzaSET.Records(0).Fields("prior").Text = FormatUtil.PriceFormat(indexItem.Prior);
						this.intzaSET.Records(0).Fields("index").Text = indexItem.LastIndex.ToString();
						this.intzaSET.Records(0).Fields("chg").Text = indexItem.IndexChg.ToString();
						this.intzaSET.Records(0).Fields("pchg").Text = indexItem.IndexChgPct.ToString();
						this.intzaSET.Records(0).Fields("prior").FontColor = MyColor.UnChgColor;
						this.intzaSET.Records(0).Fields("index").FontColor = fontColor;
						this.intzaSET.Records(0).Fields("chg").FontColor = fontColor;
						this.intzaSET.Records(0).Fields("pchg").FontColor = fontColor;
						fontColor = Utilities.ComparePriceColor(indexItem.IndexHigh, indexItem.Prior);
						if (indexItem.IndexHigh > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexHigh > 0m)
							{
								d = indexItem.IndexHigh - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(1).Fields("index").Text = indexItem.IndexHigh.ToString();
							this.intzaSET.Records(1).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(1).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(1).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(1).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(1).Fields("pchg").FontColor = fontColor;
						}
						fontColor = Utilities.ComparePriceColor(indexItem.IndexLow, indexItem.Prior);
						if (indexItem.IndexLow > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexLow > 0m)
							{
								d = indexItem.IndexLow - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(2).Fields("index").Text = indexItem.IndexLow.ToString();
							this.intzaSET.Records(2).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(2).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(2).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(2).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(2).Fields("pchg").FontColor = fontColor;
						}
					}
					else if (symbol == ".SET50")
					{
						this.intzaSET.Records(3).Fields("prior").Text = FormatUtil.PriceFormat(indexItem.Prior);
						this.intzaSET.Records(3).Fields("index").Text = indexItem.LastIndex.ToString();
						this.intzaSET.Records(3).Fields("chg").Text = indexItem.IndexChg.ToString();
						this.intzaSET.Records(3).Fields("pchg").Text = indexItem.IndexChgPct.ToString();
						this.intzaSET.Records(3).Fields("prior").FontColor = MyColor.UnChgColor;
						this.intzaSET.Records(3).Fields("index").FontColor = fontColor;
						this.intzaSET.Records(3).Fields("chg").FontColor = fontColor;
						this.intzaSET.Records(3).Fields("pchg").FontColor = fontColor;
						fontColor = Utilities.ComparePriceColor(indexItem.IndexHigh, indexItem.Prior);
						if (indexItem.IndexHigh > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexHigh > 0m)
							{
								d = indexItem.IndexHigh - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(4).Fields("index").Text = indexItem.IndexHigh.ToString();
							this.intzaSET.Records(4).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(4).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(4).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(4).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(4).Fields("pchg").FontColor = fontColor;
						}
						fontColor = Utilities.ComparePriceColor(indexItem.IndexLow, indexItem.Prior);
						if (indexItem.IndexLow > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexLow > 0m)
							{
								d = indexItem.IndexLow - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(5).Fields("index").Text = indexItem.IndexLow.ToString();
							this.intzaSET.Records(5).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(5).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(5).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(5).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(5).Fields("pchg").FontColor = fontColor;
						}
					}
					else if (symbol == ".SET100")
					{
						this.intzaSET.Records(6).Fields("prior").Text = FormatUtil.PriceFormat(indexItem.Prior);
						this.intzaSET.Records(6).Fields("index").Text = indexItem.LastIndex.ToString();
						this.intzaSET.Records(6).Fields("chg").Text = indexItem.IndexChg.ToString();
						this.intzaSET.Records(6).Fields("pchg").Text = indexItem.IndexChgPct.ToString();
						this.intzaSET.Records(6).Fields("prior").FontColor = MyColor.UnChgColor;
						this.intzaSET.Records(6).Fields("index").FontColor = fontColor;
						this.intzaSET.Records(6).Fields("chg").FontColor = fontColor;
						this.intzaSET.Records(6).Fields("pchg").FontColor = fontColor;
						fontColor = Utilities.ComparePriceColor(indexItem.IndexHigh, indexItem.Prior);
						if (indexItem.IndexHigh > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexHigh > 0m)
							{
								d = indexItem.IndexHigh - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(7).Fields("index").Text = indexItem.IndexHigh.ToString();
							this.intzaSET.Records(7).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(7).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(7).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(7).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(7).Fields("pchg").FontColor = fontColor;
						}
						fontColor = Utilities.ComparePriceColor(indexItem.IndexLow, indexItem.Prior);
						if (indexItem.IndexLow > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexLow > 0m)
							{
								d = indexItem.IndexLow - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(8).Fields("index").Text = indexItem.IndexLow.ToString();
							this.intzaSET.Records(8).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(8).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(8).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(8).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(8).Fields("pchg").FontColor = fontColor;
						}
					}
					else if (symbol == ".sSET")
					{
						this.intzaSET.Records(9).Fields("prior").Text = FormatUtil.PriceFormat(indexItem.Prior);
						this.intzaSET.Records(9).Fields("index").Text = indexItem.LastIndex.ToString();
						this.intzaSET.Records(9).Fields("chg").Text = indexItem.IndexChg.ToString();
						this.intzaSET.Records(9).Fields("pchg").Text = indexItem.IndexChgPct.ToString();
						this.intzaSET.Records(9).Fields("prior").FontColor = MyColor.UnChgColor;
						this.intzaSET.Records(9).Fields("index").FontColor = fontColor;
						this.intzaSET.Records(9).Fields("chg").FontColor = fontColor;
						this.intzaSET.Records(9).Fields("pchg").FontColor = fontColor;
						fontColor = Utilities.ComparePriceColor(indexItem.IndexHigh, indexItem.Prior);
						if (indexItem.IndexHigh > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexHigh > 0m)
							{
								d = indexItem.IndexHigh - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(10).Fields("index").Text = indexItem.IndexHigh.ToString();
							this.intzaSET.Records(10).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(10).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(10).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(10).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(10).Fields("pchg").FontColor = fontColor;
						}
						fontColor = Utilities.ComparePriceColor(indexItem.IndexLow, indexItem.Prior);
						if (indexItem.IndexLow > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexLow > 0m)
							{
								d = indexItem.IndexLow - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(11).Fields("index").Text = indexItem.IndexLow.ToString();
							this.intzaSET.Records(11).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(11).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(11).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(11).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(11).Fields("pchg").FontColor = fontColor;
						}
					}
					else if (symbol == ".MAI")
					{
						this.intzaMarketInfo.Item("maival_text").Text = FormatUtil.VolumeFormat(indexItem.AccValue.ToString(), true);
						this.intzaMarketInfo.Item("maival_text").FontColor = MyColor.UnChgColor;
						this.intzaSET.Records(12).Fields("prior").Text = FormatUtil.PriceFormat(indexItem.Prior);
						this.intzaSET.Records(12).Fields("index").Text = indexItem.LastIndex.ToString();
						this.intzaSET.Records(12).Fields("chg").Text = indexItem.IndexChg.ToString();
						this.intzaSET.Records(12).Fields("pchg").Text = indexItem.IndexChgPct.ToString();
						this.intzaSET.Records(12).Fields("prior").FontColor = MyColor.UnChgColor;
						this.intzaSET.Records(12).Fields("index").FontColor = fontColor;
						this.intzaSET.Records(12).Fields("chg").FontColor = fontColor;
						this.intzaSET.Records(12).Fields("pchg").FontColor = fontColor;
						fontColor = Utilities.ComparePriceColor(indexItem.IndexHigh, indexItem.Prior);
						if (indexItem.IndexHigh > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexHigh > 0m)
							{
								d = indexItem.IndexHigh - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(13).Fields("index").Text = indexItem.IndexHigh.ToString();
							this.intzaSET.Records(13).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(13).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(13).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(13).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(13).Fields("pchg").FontColor = fontColor;
						}
						fontColor = Utilities.ComparePriceColor(indexItem.IndexLow, indexItem.Prior);
						if (indexItem.IndexLow > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexLow > 0m)
							{
								d = indexItem.IndexLow - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(14).Fields("index").Text = indexItem.IndexLow.ToString();
							this.intzaSET.Records(14).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(14).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(14).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(14).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(14).Fields("pchg").FontColor = fontColor;
						}
					}
					else if (symbol == ".SETHD")
					{
						this.intzaSET.Records(15).Fields("prior").Text = FormatUtil.PriceFormat(indexItem.Prior);
						this.intzaSET.Records(15).Fields("index").Text = indexItem.LastIndex.ToString();
						this.intzaSET.Records(15).Fields("chg").Text = indexItem.IndexChg.ToString();
						this.intzaSET.Records(15).Fields("pchg").Text = indexItem.IndexChgPct.ToString();
						this.intzaSET.Records(15).Fields("prior").FontColor = MyColor.UnChgColor;
						this.intzaSET.Records(15).Fields("index").FontColor = fontColor;
						this.intzaSET.Records(15).Fields("chg").FontColor = fontColor;
						this.intzaSET.Records(15).Fields("pchg").FontColor = fontColor;
						fontColor = Utilities.ComparePriceColor(indexItem.IndexHigh, indexItem.Prior);
						if (indexItem.IndexHigh > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexHigh > 0m)
							{
								d = indexItem.IndexHigh - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(16).Fields("index").Text = indexItem.IndexHigh.ToString();
							this.intzaSET.Records(16).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(16).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(16).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(16).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(16).Fields("pchg").FontColor = fontColor;
						}
						fontColor = Utilities.ComparePriceColor(indexItem.IndexLow, indexItem.Prior);
						if (indexItem.IndexLow > 0m && indexItem.Prior > 0m)
						{
							if (indexItem.Prior > 0m && indexItem.IndexLow > 0m)
							{
								d = indexItem.IndexLow - indexItem.Prior;
								num = Math.Round(d / indexItem.Prior * 100m, 4);
							}
							this.intzaSET.Records(17).Fields("index").Text = indexItem.IndexLow.ToString();
							this.intzaSET.Records(17).Fields("chg").Text = d.ToString();
							this.intzaSET.Records(17).Fields("pchg").Text = num.ToString();
							this.intzaSET.Records(17).Fields("index").FontColor = fontColor;
							this.intzaSET.Records(17).Fields("chg").FontColor = fontColor;
							this.intzaSET.Records(17).Fields("pchg").FontColor = fontColor;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("MarketInfoShowSetIndex", ex);
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x001136CC File Offset: 0x00111ACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadChart()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwReloadChart.IsBusy)
			{
				this.bgwReloadChart.RunWorkerAsync();
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00113708 File Offset: 0x00111B08
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadChart_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.ShowSplashChart(true);
				string text = string.Empty;
				IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo["." + this._currentChartName];
				if (indexItem != null)
				{
					decimal prior = indexItem.Prior;
					text = ApplicationInfo.WebService.GetSetIndexChartImage("." + this._currentChartName, (double)prior, this.pictureBox1.Width, this.pictureBox1.Height);
					if (text != string.Empty)
					{
						byte[] buffer = Convert.FromBase64String(text);
						using (MemoryStream memoryStream = new MemoryStream(buffer))
						{
							this.pictureBox1.Image = Image.FromStream(memoryStream);
						}
						text = string.Empty;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadChart_DoWork", ex);
			}
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00113838 File Offset: 0x00111C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadChart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ShowSplashChart(false);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00113854 File Offset: 0x00111C54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplashChart(bool visible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMarketInfo.ShowSplashChartCallBack(this.ShowSplashChart), new object[]
				{
					visible
				});
			}
			else if (visible)
			{
				this.lbChartLoading.Left = this.pictureBox1.Left + (this.pictureBox1.Width - this.lbChartLoading.Width) / 2;
				this.lbChartLoading.Top = this.pictureBox1.Top + this.lbChartLoading.Height;
				this.lbChartLoading.Visible = true;
				this.lbChartLoading.BringToFront();
			}
			else
			{
				this.lbChartLoading.Visible = false;
			}
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0011393C File Offset: 0x00111D3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSETChart_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetChart(((ToolStripButton)sender).Text, sender);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00113960 File Offset: 0x00111D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnInfo_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetChart("INFO", sender);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00113980 File Offset: 0x00111D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetChart(string symbol, object sender)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tsbtnSETChart.ForeColor = Color.Gray;
				this.tsbtnSET50Chart.ForeColor = Color.Gray;
				this.tsbtnSET100Chart.ForeColor = Color.Gray;
				this.tsbtnMaiChart.ForeColor = Color.Gray;
				this.tsbtnsSETChart.ForeColor = Color.Gray;
				this.tsbtnInfo.ForeColor = Color.Gray;
				this.tsbtnSETHdChart.ForeColor = Color.Gray;
				switch (symbol)
				{
				case "SET":
				case "SET50":
				case "SET100":
				case "sSET":
				case "MAI":
				case "SETHD":
					this._currentChartName = symbol;
					this.pictureBox1.Show();
					this.intzaMarketInfo.Hide();
					this.intzaBoard.Hide();
					((ToolStripButton)sender).ForeColor = Color.Orange;
					this.ReloadChart();
					goto IL_1A9;
				}
				this.intzaBoard.Show();
				this.intzaMarketInfo.Show();
				this.pictureBox1.Hide();
				this.tsbtnInfo.ForeColor = Color.Orange;
				IL_1A9:;
			}
			catch (Exception ex)
			{
				this.ShowError("SetChart", ex);
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00113B70 File Offset: 0x00111F70
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplash2(bool visible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMarketInfo.ShowSplashCallBack(this.ShowSplash2), new object[]
				{
					visible
				});
			}
			else
			{
				this.isLoading = visible;
				if (ApplicationInfo.SuuportSplash == "Y")
				{
					if (visible)
					{
						this.lbLoading2.Left = (this.intzaSector.Width - this.lbLoading2.Width) / 2;
						this.lbLoading2.Top = (this.intzaSector.Height - this.lbLoading2.Height) / 2;
						this.lbLoading2.Visible = true;
						this.lbLoading2.BringToFront();
					}
					else
					{
						this.lbLoading2.Visible = false;
					}
				}
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00113C70 File Offset: 0x00112070
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSector_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.isLoading)
			{
				this.SetPage(0);
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00113CAC File Offset: 0x001120AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnIndustry_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.isLoading)
			{
				this.SetPage(1);
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00113CE8 File Offset: 0x001120E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSortAsc_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetSort(SortType.Asc);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00113D04 File Offset: 0x00112104
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSortDesc_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetSort(SortType.Desc);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00113D20 File Offset: 0x00112120
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

		// Token: 0x06001468 RID: 5224 RVA: 0x00113D70 File Offset: 0x00112170
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ColumnItem columnItem = new ColumnItem();
			ColumnItem columnItem2 = new ColumnItem();
			ColumnItem columnItem3 = new ColumnItem();
			ColumnItem columnItem4 = new ColumnItem();
			ColumnItem columnItem5 = new ColumnItem();
			ColumnItem columnItem6 = new ColumnItem();
			ColumnItem columnItem7 = new ColumnItem();
			ColumnItem columnItem8 = new ColumnItem();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMarketInfo));
			ColumnItem columnItem9 = new ColumnItem();
			ColumnItem columnItem10 = new ColumnItem();
			ColumnItem columnItem11 = new ColumnItem();
			ColumnItem columnItem12 = new ColumnItem();
			ColumnItem columnItem13 = new ColumnItem();
			ColumnItem columnItem14 = new ColumnItem();
			ColumnItem columnItem15 = new ColumnItem();
			ColumnItem columnItem16 = new ColumnItem();
			ColumnItem columnItem17 = new ColumnItem();
			this.tStripMenu = new ToolStrip();
			this.toolStripLabel1 = new ToolStripLabel();
			this.tsbtnSector = new ToolStripButton();
			this.tsbtnIndustry = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.toolStripLabel2 = new ToolStripLabel();
			this.tsSortBySector = new ToolStripButton();
			this.tsSortByVolume = new ToolStripButton();
			this.tsSortByValues = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.tsSortBy = new ToolStripLabel();
			this.tsbtnSortAsc = new ToolStripButton();
			this.tsbtnSortDesc = new ToolStripButton();
			this.panelSector = new Panel();
			this.intzaSector = new SortGrid();
			this.lbLoading2 = new Label();
			this.intzaMarketInfo = new IntzaCustomGrid();
			this.toolStrip1 = new ToolStrip();
			this.tsbtnInfo = new ToolStripButton();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.tsbtnSETChart = new ToolStripButton();
			this.tsbtnSET50Chart = new ToolStripButton();
			this.tsbtnSET100Chart = new ToolStripButton();
			this.tsbtnsSETChart = new ToolStripButton();
			this.tsbtnSETHdChart = new ToolStripButton();
			this.tsbtnMaiChart = new ToolStripButton();
			this.pictureBox1 = new PictureBox();
			this.lbChartLoading = new Label();
			this.intzaSET = new SortGrid();
			this.intzaBoard = new SortGrid();
			this.tStripMenu.SuspendLayout();
			this.panelSector.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.tStripMenu.AllowMerge = false;
			this.tStripMenu.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripMenu.GripMargin = new Padding(0);
			this.tStripMenu.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripLabel1,
				this.tsbtnSector,
				this.tsbtnIndustry,
				this.toolStripSeparator1,
				this.toolStripLabel2,
				this.tsSortBySector,
				this.tsSortByVolume,
				this.tsSortByValues,
				this.toolStripSeparator2,
				this.tsSortBy,
				this.tsbtnSortAsc,
				this.tsbtnSortDesc
			});
			this.tStripMenu.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Padding = new Padding(1, 1, 1, 2);
			this.tStripMenu.RenderMode = ToolStripRenderMode.System;
			this.tStripMenu.Size = new Size(675, 26);
			this.tStripMenu.TabIndex = 10;
			this.tStripMenu.Tag = "-1";
			this.tStripMenu.Text = "ToolStrip1";
			this.toolStripLabel1.ForeColor = Color.LightGray;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new Size(64, 20);
			this.toolStripLabel1.Text = "Selection : ";
			this.tsbtnSector.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSector.ForeColor = Color.LightGray;
			this.tsbtnSector.ImageTransparentColor = Color.Magenta;
			this.tsbtnSector.Name = "tsbtnSector";
			this.tsbtnSector.Size = new Size(44, 20);
			this.tsbtnSector.Text = "Sector";
			this.tsbtnSector.Click += new EventHandler(this.tsbtnSector_Click);
			this.tsbtnIndustry.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnIndustry.ForeColor = Color.LightGray;
			this.tsbtnIndustry.ImageTransparentColor = Color.Magenta;
			this.tsbtnIndustry.Name = "tsbtnIndustry";
			this.tsbtnIndustry.Size = new Size(54, 20);
			this.tsbtnIndustry.Text = "Industry";
			this.tsbtnIndustry.Click += new EventHandler(this.tsbtnIndustry_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 23);
			this.toolStripLabel2.ForeColor = Color.LightGray;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new Size(50, 20);
			this.toolStripLabel2.Text = "Sort by :";
			this.tsSortBySector.BackColor = Color.Transparent;
			this.tsSortBySector.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsSortBySector.ForeColor = Color.LightGray;
			this.tsSortBySector.ImageTransparentColor = Color.Magenta;
			this.tsSortBySector.Name = "tsSortBySector";
			this.tsSortBySector.Size = new Size(51, 20);
			this.tsSortBySector.Text = "Symbol";
			this.tsSortBySector.Click += new EventHandler(this.tsSortBySector_Click);
			this.tsSortByVolume.BackColor = Color.Transparent;
			this.tsSortByVolume.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsSortByVolume.ForeColor = Color.LightGray;
			this.tsSortByVolume.ImageTransparentColor = Color.Magenta;
			this.tsSortByVolume.Name = "tsSortByVolume";
			this.tsSortByVolume.Size = new Size(55, 20);
			this.tsSortByVolume.Text = "Volume.";
			this.tsSortByVolume.Click += new EventHandler(this.tsSortByVolume_Click);
			this.tsSortByValues.BackColor = Color.Transparent;
			this.tsSortByValues.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsSortByValues.ForeColor = Color.LightGray;
			this.tsSortByValues.ImageTransparentColor = Color.Magenta;
			this.tsSortByValues.Name = "tsSortByValues";
			this.tsSortByValues.Size = new Size(43, 20);
			this.tsSortByValues.Text = "Value.";
			this.tsSortByValues.Click += new EventHandler(this.tsSortByValues_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 23);
			this.tsSortBy.BackColor = Color.Transparent;
			this.tsSortBy.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsSortBy.Font = new Font("Microsoft Sans Serif", 9f);
			this.tsSortBy.ForeColor = Color.LightGray;
			this.tsSortBy.ImageTransparentColor = Color.Magenta;
			this.tsSortBy.Name = "tsSortBy";
			this.tsSortBy.Size = new Size(35, 20);
			this.tsSortBy.Text = "Sort :";
			this.tsbtnSortAsc.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSortAsc.ForeColor = Color.LightGray;
			this.tsbtnSortAsc.ImageTransparentColor = Color.Magenta;
			this.tsbtnSortAsc.Name = "tsbtnSortAsc";
			this.tsbtnSortAsc.Size = new Size(67, 20);
			this.tsbtnSortAsc.Text = "Ascending";
			this.tsbtnSortAsc.Click += new EventHandler(this.tsbtnSortAsc_Click);
			this.tsbtnSortDesc.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSortDesc.ForeColor = Color.LightGray;
			this.tsbtnSortDesc.ImageTransparentColor = Color.Magenta;
			this.tsbtnSortDesc.Name = "tsbtnSortDesc";
			this.tsbtnSortDesc.Size = new Size(73, 20);
			this.tsbtnSortDesc.Text = "Descending";
			this.tsbtnSortDesc.Click += new EventHandler(this.tsbtnSortDesc_Click);
			this.panelSector.Controls.Add(this.intzaSector);
			this.panelSector.Controls.Add(this.lbLoading2);
			this.panelSector.Controls.Add(this.tStripMenu);
			this.panelSector.Location = new Point(0, 214);
			this.panelSector.Name = "panelSector";
			this.panelSector.Size = new Size(675, 188);
			this.panelSector.TabIndex = 19;
			this.intzaSector.AllowDrop = true;
			this.intzaSector.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaSector.CanBlink = true;
			this.intzaSector.CanDrag = false;
			this.intzaSector.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "symbol";
			columnItem.Text = "Symbol";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 14;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "prior";
			columnItem2.Text = "Prev";
			columnItem2.ValueFormat = FormatType.Price;
			columnItem2.Visible = true;
			columnItem2.Width = 10;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "last";
			columnItem3.Text = "Last";
			columnItem3.ValueFormat = FormatType.Price;
			columnItem3.Visible = true;
			columnItem3.Width = 10;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "chg";
			columnItem4.Text = "Change";
			columnItem4.ValueFormat = FormatType.ChangePrice;
			columnItem4.Visible = true;
			columnItem4.Width = 10;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "pchg";
			columnItem5.Text = "%Change";
			columnItem5.ValueFormat = FormatType.ChangePrice;
			columnItem5.Visible = true;
			columnItem5.Width = 10;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "volume";
			columnItem6.Text = "Volume";
			columnItem6.ValueFormat = FormatType.Volume;
			columnItem6.Visible = true;
			columnItem6.Width = 17;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "value";
			columnItem7.Text = "Value";
			columnItem7.ValueFormat = FormatType.Volume;
			columnItem7.Visible = true;
			columnItem7.Width = 19;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "pmkt";
			columnItem8.Text = "%Mkt";
			columnItem8.ValueFormat = FormatType.Price;
			columnItem8.Visible = true;
			columnItem8.Width = 10;
			this.intzaSector.Columns.Add(columnItem);
			this.intzaSector.Columns.Add(columnItem2);
			this.intzaSector.Columns.Add(columnItem3);
			this.intzaSector.Columns.Add(columnItem4);
			this.intzaSector.Columns.Add(columnItem5);
			this.intzaSector.Columns.Add(columnItem6);
			this.intzaSector.Columns.Add(columnItem7);
			this.intzaSector.Columns.Add(columnItem8);
			this.intzaSector.CurrentScroll = 0;
			this.intzaSector.Dock = DockStyle.Fill;
			this.intzaSector.FocusItemIndex = -1;
			this.intzaSector.ForeColor = Color.Black;
			this.intzaSector.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaSector.HeaderPctHeight = 80f;
			this.intzaSector.IsAutoRepaint = true;
			this.intzaSector.IsDrawFullRow = false;
			this.intzaSector.IsDrawGrid = true;
			this.intzaSector.IsDrawHeader = true;
			this.intzaSector.IsScrollable = true;
			this.intzaSector.Location = new Point(0, 26);
			this.intzaSector.MainColumn = "";
			this.intzaSector.Name = "intzaSector";
			this.intzaSector.Rows = 0;
			this.intzaSector.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaSector.RowSelectType = 0;
			this.intzaSector.RowsVisible = 0;
			this.intzaSector.Size = new Size(675, 162);
			this.intzaSector.SortColumnName = "";
			this.intzaSector.SortType = SortType.Desc;
			this.intzaSector.TabIndex = 86;
			this.lbLoading2.AutoSize = true;
			this.lbLoading2.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbLoading2.ForeColor = Color.Yellow;
			this.lbLoading2.Location = new Point(308, 99);
			this.lbLoading2.Name = "lbLoading2";
			this.lbLoading2.Padding = new Padding(5, 3, 5, 3);
			this.lbLoading2.Size = new Size(69, 21);
			this.lbLoading2.TabIndex = 85;
			this.lbLoading2.Text = "Loading ...";
			this.lbLoading2.TextAlign = ContentAlignment.MiddleCenter;
			this.lbLoading2.Visible = false;
			this.intzaMarketInfo.AllowDrop = true;
			this.intzaMarketInfo.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaMarketInfo.CanDrag = false;
			this.intzaMarketInfo.IsAutoRepaint = true;
			this.intzaMarketInfo.IsDroped = false;
			itemGrid.AdjustFontSize = 0f;
			itemGrid.Alignment = StringAlignment.Near;
			itemGrid.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid.Changed = false;
			itemGrid.FieldType = ItemType.Label2;
			itemGrid.FontColor = Color.LightGray;
			itemGrid.FontStyle = FontStyle.Regular;
			itemGrid.Height = 1f;
			itemGrid.IsBlink = 0;
			itemGrid.Name = "upvolume_label";
			itemGrid.Text = "Up Vol";
			itemGrid.ValueFormat = FormatType.Text;
			itemGrid.Visible = true;
			itemGrid.Width = 25;
			itemGrid.X = 0;
			itemGrid.Y = 0f;
			itemGrid2.AdjustFontSize = 0f;
			itemGrid2.Alignment = StringAlignment.Far;
			itemGrid2.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid2.Changed = false;
			itemGrid2.FieldType = ItemType.Text;
			itemGrid2.FontColor = Color.Lime;
			itemGrid2.FontStyle = FontStyle.Regular;
			itemGrid2.Height = 1f;
			itemGrid2.IsBlink = 0;
			itemGrid2.Name = "upvolume_text";
			itemGrid2.Text = "";
			itemGrid2.ValueFormat = FormatType.Volume;
			itemGrid2.Visible = true;
			itemGrid2.Width = 30;
			itemGrid2.X = 25;
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
			itemGrid3.Name = "maival_label";
			itemGrid3.Text = "MAI Val";
			itemGrid3.ValueFormat = FormatType.Text;
			itemGrid3.Visible = true;
			itemGrid3.Width = 18;
			itemGrid3.X = 57;
			itemGrid3.Y = 0f;
			itemGrid4.AdjustFontSize = 0f;
			itemGrid4.Alignment = StringAlignment.Far;
			itemGrid4.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid4.Changed = false;
			itemGrid4.FieldType = ItemType.Text;
			itemGrid4.FontColor = Color.Yellow;
			itemGrid4.FontStyle = FontStyle.Regular;
			itemGrid4.Height = 1f;
			itemGrid4.IsBlink = 0;
			itemGrid4.Name = "maival_text";
			itemGrid4.Text = "";
			itemGrid4.ValueFormat = FormatType.Price;
			itemGrid4.Visible = true;
			itemGrid4.Width = 25;
			itemGrid4.X = 75;
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
			itemGrid5.Name = "downvolume_label";
			itemGrid5.Text = "Down Vol";
			itemGrid5.ValueFormat = FormatType.Text;
			itemGrid5.Visible = true;
			itemGrid5.Width = 25;
			itemGrid5.X = 0;
			itemGrid5.Y = 1f;
			itemGrid6.AdjustFontSize = 0f;
			itemGrid6.Alignment = StringAlignment.Far;
			itemGrid6.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid6.Changed = false;
			itemGrid6.FieldType = ItemType.Text;
			itemGrid6.FontColor = Color.Red;
			itemGrid6.FontStyle = FontStyle.Regular;
			itemGrid6.Height = 1f;
			itemGrid6.IsBlink = 0;
			itemGrid6.Name = "downvolume_text";
			itemGrid6.Text = "";
			itemGrid6.ValueFormat = FormatType.Volume;
			itemGrid6.Visible = true;
			itemGrid6.Width = 30;
			itemGrid6.X = 25;
			itemGrid6.Y = 1f;
			itemGrid7.AdjustFontSize = 0f;
			itemGrid7.Alignment = StringAlignment.Near;
			itemGrid7.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid7.Changed = false;
			itemGrid7.FieldType = ItemType.Label2;
			itemGrid7.FontColor = Color.LightGray;
			itemGrid7.FontStyle = FontStyle.Regular;
			itemGrid7.Height = 1f;
			itemGrid7.IsBlink = 0;
			itemGrid7.Name = "nochg_volume_label";
			itemGrid7.Text = "UnChg Vol";
			itemGrid7.ValueFormat = FormatType.Text;
			itemGrid7.Visible = true;
			itemGrid7.Width = 25;
			itemGrid7.X = 0;
			itemGrid7.Y = 2f;
			itemGrid8.AdjustFontSize = 0f;
			itemGrid8.Alignment = StringAlignment.Far;
			itemGrid8.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid8.Changed = false;
			itemGrid8.FieldType = ItemType.Text;
			itemGrid8.FontColor = Color.Yellow;
			itemGrid8.FontStyle = FontStyle.Regular;
			itemGrid8.Height = 1f;
			itemGrid8.IsBlink = 0;
			itemGrid8.Name = "nochg_volume_text";
			itemGrid8.Text = "";
			itemGrid8.ValueFormat = FormatType.Volume;
			itemGrid8.Visible = true;
			itemGrid8.Width = 30;
			itemGrid8.X = 25;
			itemGrid8.Y = 2f;
			itemGrid9.AdjustFontSize = 0f;
			itemGrid9.Alignment = StringAlignment.Near;
			itemGrid9.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid9.Changed = false;
			itemGrid9.FieldType = ItemType.Label2;
			itemGrid9.FontColor = Color.LightGray;
			itemGrid9.FontStyle = FontStyle.Regular;
			itemGrid9.Height = 1f;
			itemGrid9.IsBlink = 0;
			itemGrid9.Name = "up_label";
			itemGrid9.Text = "Up";
			itemGrid9.ValueFormat = FormatType.Text;
			itemGrid9.Visible = true;
			itemGrid9.Width = 11;
			itemGrid9.X = 0;
			itemGrid9.Y = 3f;
			itemGrid10.AdjustFontSize = 0f;
			itemGrid10.Alignment = StringAlignment.Near;
			itemGrid10.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid10.Changed = false;
			itemGrid10.FieldType = ItemType.Text;
			itemGrid10.FontColor = Color.Lime;
			itemGrid10.FontStyle = FontStyle.Regular;
			itemGrid10.Height = 1f;
			itemGrid10.IsBlink = 0;
			itemGrid10.Name = "up_text";
			itemGrid10.Text = "";
			itemGrid10.ValueFormat = FormatType.Volume;
			itemGrid10.Visible = true;
			itemGrid10.Width = 15;
			itemGrid10.X = 12;
			itemGrid10.Y = 3f;
			itemGrid11.AdjustFontSize = 0f;
			itemGrid11.Alignment = StringAlignment.Near;
			itemGrid11.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid11.Changed = false;
			itemGrid11.FieldType = ItemType.Label2;
			itemGrid11.FontColor = Color.LightGray;
			itemGrid11.FontStyle = FontStyle.Regular;
			itemGrid11.Height = 1f;
			itemGrid11.IsBlink = 0;
			itemGrid11.Name = "down_label";
			itemGrid11.Text = "Down";
			itemGrid11.ValueFormat = FormatType.Volume;
			itemGrid11.Visible = true;
			itemGrid11.Width = 12;
			itemGrid11.X = 30;
			itemGrid11.Y = 3f;
			itemGrid12.AdjustFontSize = 0f;
			itemGrid12.Alignment = StringAlignment.Near;
			itemGrid12.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid12.Changed = false;
			itemGrid12.FieldType = ItemType.Text;
			itemGrid12.FontColor = Color.Red;
			itemGrid12.FontStyle = FontStyle.Regular;
			itemGrid12.Height = 1f;
			itemGrid12.IsBlink = 0;
			itemGrid12.Name = "down_text";
			itemGrid12.Text = "";
			itemGrid12.ValueFormat = FormatType.Volume;
			itemGrid12.Visible = true;
			itemGrid12.Width = 15;
			itemGrid12.X = 43;
			itemGrid12.Y = 3f;
			itemGrid13.AdjustFontSize = 0f;
			itemGrid13.Alignment = StringAlignment.Near;
			itemGrid13.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid13.Changed = false;
			itemGrid13.FieldType = ItemType.Label2;
			itemGrid13.FontColor = Color.LightGray;
			itemGrid13.FontStyle = FontStyle.Regular;
			itemGrid13.Height = 1f;
			itemGrid13.IsBlink = 0;
			itemGrid13.Name = "nochange_label";
			itemGrid13.Text = "UnChg.";
			itemGrid13.ValueFormat = FormatType.Text;
			itemGrid13.Visible = true;
			itemGrid13.Width = 15;
			itemGrid13.X = 60;
			itemGrid13.Y = 3f;
			itemGrid14.AdjustFontSize = 0f;
			itemGrid14.Alignment = StringAlignment.Near;
			itemGrid14.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid14.Changed = false;
			itemGrid14.FieldType = ItemType.Text;
			itemGrid14.FontColor = Color.Yellow;
			itemGrid14.FontStyle = FontStyle.Regular;
			itemGrid14.Height = 1f;
			itemGrid14.IsBlink = 0;
			itemGrid14.Name = "nochange_text";
			itemGrid14.Text = "";
			itemGrid14.ValueFormat = FormatType.Volume;
			itemGrid14.Visible = true;
			itemGrid14.Width = 13;
			itemGrid14.X = 75;
			itemGrid14.Y = 3f;
			itemGrid15.AdjustFontSize = 0f;
			itemGrid15.Alignment = StringAlignment.Near;
			itemGrid15.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid15.Changed = false;
			itemGrid15.FieldType = ItemType.Label2;
			itemGrid15.FontColor = Color.LightGray;
			itemGrid15.FontStyle = FontStyle.Regular;
			itemGrid15.Height = 1f;
			itemGrid15.IsBlink = 0;
			itemGrid15.Name = "tick_label";
			itemGrid15.Text = "Tick";
			itemGrid15.ValueFormat = FormatType.Text;
			itemGrid15.Visible = true;
			itemGrid15.Width = 11;
			itemGrid15.X = 0;
			itemGrid15.Y = 4f;
			itemGrid16.AdjustFontSize = 0f;
			itemGrid16.Alignment = StringAlignment.Near;
			itemGrid16.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid16.Changed = false;
			itemGrid16.FieldType = ItemType.Text;
			itemGrid16.FontColor = Color.White;
			itemGrid16.FontStyle = FontStyle.Regular;
			itemGrid16.Height = 1f;
			itemGrid16.IsBlink = 0;
			itemGrid16.Name = "tick_text";
			itemGrid16.Text = "";
			itemGrid16.ValueFormat = FormatType.Price;
			itemGrid16.Visible = true;
			itemGrid16.Width = 15;
			itemGrid16.X = 12;
			itemGrid16.Y = 4f;
			itemGrid17.AdjustFontSize = 0f;
			itemGrid17.Alignment = StringAlignment.Near;
			itemGrid17.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid17.Changed = false;
			itemGrid17.FieldType = ItemType.Label2;
			itemGrid17.FontColor = Color.LightGray;
			itemGrid17.FontStyle = FontStyle.Regular;
			itemGrid17.Height = 1f;
			itemGrid17.IsBlink = 0;
			itemGrid17.Name = "trin_label";
			itemGrid17.Text = "Trin";
			itemGrid17.ValueFormat = FormatType.Volume;
			itemGrid17.Visible = true;
			itemGrid17.Width = 12;
			itemGrid17.X = 30;
			itemGrid17.Y = 4f;
			itemGrid18.AdjustFontSize = 0f;
			itemGrid18.Alignment = StringAlignment.Near;
			itemGrid18.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid18.Changed = false;
			itemGrid18.FieldType = ItemType.Text;
			itemGrid18.FontColor = Color.White;
			itemGrid18.FontStyle = FontStyle.Regular;
			itemGrid18.Height = 1f;
			itemGrid18.IsBlink = 0;
			itemGrid18.Name = "trin_text";
			itemGrid18.Text = "";
			itemGrid18.ValueFormat = FormatType.Price;
			itemGrid18.Visible = true;
			itemGrid18.Width = 55;
			itemGrid18.X = 43;
			itemGrid18.Y = 4f;
			this.intzaMarketInfo.Items.Add(itemGrid);
			this.intzaMarketInfo.Items.Add(itemGrid2);
			this.intzaMarketInfo.Items.Add(itemGrid3);
			this.intzaMarketInfo.Items.Add(itemGrid4);
			this.intzaMarketInfo.Items.Add(itemGrid5);
			this.intzaMarketInfo.Items.Add(itemGrid6);
			this.intzaMarketInfo.Items.Add(itemGrid7);
			this.intzaMarketInfo.Items.Add(itemGrid8);
			this.intzaMarketInfo.Items.Add(itemGrid9);
			this.intzaMarketInfo.Items.Add(itemGrid10);
			this.intzaMarketInfo.Items.Add(itemGrid11);
			this.intzaMarketInfo.Items.Add(itemGrid12);
			this.intzaMarketInfo.Items.Add(itemGrid13);
			this.intzaMarketInfo.Items.Add(itemGrid14);
			this.intzaMarketInfo.Items.Add(itemGrid15);
			this.intzaMarketInfo.Items.Add(itemGrid16);
			this.intzaMarketInfo.Items.Add(itemGrid17);
			this.intzaMarketInfo.Items.Add(itemGrid18);
			this.intzaMarketInfo.LineColor = Color.Red;
			this.intzaMarketInfo.Location = new Point(350, 128);
			this.intzaMarketInfo.Margin = new Padding(0);
			this.intzaMarketInfo.Name = "intzaMarketInfo";
			this.intzaMarketInfo.Size = new Size(316, 86);
			this.intzaMarketInfo.TabIndex = 23;
			this.intzaMarketInfo.Visible = false;
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = Color.FromArgb(30, 30, 30);
			this.toolStrip1.Dock = DockStyle.None;
			this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.tsbtnInfo,
				this.toolStripSeparator3,
				this.tsbtnSETChart,
				this.tsbtnSET50Chart,
				this.tsbtnSET100Chart,
				this.tsbtnsSETChart,
				this.tsbtnSETHdChart,
				this.tsbtnMaiChart
			});
			this.toolStrip1.Location = new Point(350, 1);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new Padding(1, 1, 1, 2);
			this.toolStrip1.RenderMode = ToolStripRenderMode.System;
			this.toolStrip1.Size = new Size(325, 25);
			this.toolStrip1.TabIndex = 24;
			this.toolStrip1.Tag = "-1";
			this.toolStrip1.Text = "toolStrip1";
			this.tsbtnInfo.ForeColor = Color.LightGray;
			this.tsbtnInfo.Image = (Image)componentResourceManager.GetObject("tsbtnInfo.Image");
			this.tsbtnInfo.ImageTransparentColor = Color.Magenta;
			this.tsbtnInfo.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnInfo.Name = "tsbtnInfo";
			this.tsbtnInfo.Size = new Size(51, 19);
			this.tsbtnInfo.Text = " Info";
			this.tsbtnInfo.Click += new EventHandler(this.tsbtnInfo_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(6, 22);
			this.tsbtnSETChart.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSETChart.ForeColor = Color.LightGray;
			this.tsbtnSETChart.ImageTransparentColor = Color.Magenta;
			this.tsbtnSETChart.Name = "tsbtnSETChart";
			this.tsbtnSETChart.Size = new Size(30, 19);
			this.tsbtnSETChart.Text = "SET";
			this.tsbtnSETChart.Click += new EventHandler(this.tsbtnSETChart_Click);
			this.tsbtnSET50Chart.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSET50Chart.ForeColor = Color.LightGray;
			this.tsbtnSET50Chart.ImageTransparentColor = Color.Magenta;
			this.tsbtnSET50Chart.Name = "tsbtnSET50Chart";
			this.tsbtnSET50Chart.Size = new Size(42, 19);
			this.tsbtnSET50Chart.Text = "SET50";
			this.tsbtnSET50Chart.Click += new EventHandler(this.tsbtnSETChart_Click);
			this.tsbtnSET100Chart.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSET100Chart.ForeColor = Color.LightGray;
			this.tsbtnSET100Chart.ImageTransparentColor = Color.Magenta;
			this.tsbtnSET100Chart.Name = "tsbtnSET100Chart";
			this.tsbtnSET100Chart.Size = new Size(48, 19);
			this.tsbtnSET100Chart.Text = "SET100";
			this.tsbtnSET100Chart.Click += new EventHandler(this.tsbtnSETChart_Click);
			this.tsbtnsSETChart.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnsSETChart.ForeColor = Color.LightGray;
			this.tsbtnsSETChart.Image = (Image)componentResourceManager.GetObject("tsbtnsSETChart.Image");
			this.tsbtnsSETChart.ImageTransparentColor = Color.Magenta;
			this.tsbtnsSETChart.Name = "tsbtnsSETChart";
			this.tsbtnsSETChart.Size = new Size(35, 19);
			this.tsbtnsSETChart.Text = "sSET";
			this.tsbtnsSETChart.Click += new EventHandler(this.tsbtnSETChart_Click);
			this.tsbtnSETHdChart.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSETHdChart.ForeColor = Color.LightGray;
			this.tsbtnSETHdChart.ImageTransparentColor = Color.Magenta;
			this.tsbtnSETHdChart.Name = "tsbtnSETHdChart";
			this.tsbtnSETHdChart.Size = new Size(47, 19);
			this.tsbtnSETHdChart.Text = "SETHD";
			this.tsbtnSETHdChart.Click += new EventHandler(this.tsbtnSETChart_Click);
			this.tsbtnMaiChart.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnMaiChart.ForeColor = Color.LightGray;
			this.tsbtnMaiChart.ImageTransparentColor = Color.Magenta;
			this.tsbtnMaiChart.Name = "tsbtnMaiChart";
			this.tsbtnMaiChart.Size = new Size(33, 19);
			this.tsbtnMaiChart.Text = "MAI";
			this.tsbtnMaiChart.Click += new EventHandler(this.tsbtnSETChart_Click);
			this.pictureBox1.BackColor = Color.FromArgb(30, 30, 30);
			this.pictureBox1.Location = new Point(360, 67);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(58, 64);
			this.pictureBox1.TabIndex = 82;
			this.pictureBox1.TabStop = false;
			this.lbChartLoading.AutoSize = true;
			this.lbChartLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbChartLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbChartLoading.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbChartLoading.ForeColor = Color.Yellow;
			this.lbChartLoading.Location = new Point(360, 150);
			this.lbChartLoading.Name = "lbChartLoading";
			this.lbChartLoading.Padding = new Padding(5, 3, 5, 3);
			this.lbChartLoading.Size = new Size(69, 21);
			this.lbChartLoading.TabIndex = 83;
			this.lbChartLoading.Text = "Loading ...";
			this.lbChartLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbChartLoading.Visible = false;
			this.intzaSET.AllowDrop = true;
			this.intzaSET.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaSET.CanBlink = true;
			this.intzaSET.CanDrag = false;
			this.intzaSET.CanGetMouseMove = false;
			columnItem9.Alignment = StringAlignment.Center;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "name";
			columnItem9.Text = "";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = true;
			columnItem9.Width = 20;
			columnItem10.Alignment = StringAlignment.Far;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.LightGray;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "prior";
			columnItem10.Text = "Prev";
			columnItem10.ValueFormat = FormatType.Price;
			columnItem10.Visible = true;
			columnItem10.Width = 20;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "index";
			columnItem11.Text = "Index";
			columnItem11.ValueFormat = FormatType.Price;
			columnItem11.Visible = true;
			columnItem11.Width = 20;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "chg";
			columnItem12.Text = "Change";
			columnItem12.ValueFormat = FormatType.ChangePrice;
			columnItem12.Visible = true;
			columnItem12.Width = 20;
			columnItem13.Alignment = StringAlignment.Far;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.ColumnAlignment = StringAlignment.Center;
			columnItem13.FontColor = Color.LightGray;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "pchg";
			columnItem13.Text = "%Change";
			columnItem13.ValueFormat = FormatType.ChangePrice;
			columnItem13.Visible = true;
			columnItem13.Width = 20;
			this.intzaSET.Columns.Add(columnItem9);
			this.intzaSET.Columns.Add(columnItem10);
			this.intzaSET.Columns.Add(columnItem11);
			this.intzaSET.Columns.Add(columnItem12);
			this.intzaSET.Columns.Add(columnItem13);
			this.intzaSET.CurrentScroll = 0;
			this.intzaSET.FocusItemIndex = -1;
			this.intzaSET.ForeColor = Color.Black;
			this.intzaSET.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaSET.HeaderPctHeight = 80f;
			this.intzaSET.IsAutoRepaint = true;
			this.intzaSET.IsDrawFullRow = false;
			this.intzaSET.IsDrawGrid = true;
			this.intzaSET.IsDrawHeader = true;
			this.intzaSET.IsScrollable = true;
			this.intzaSET.Location = new Point(0, 1);
			this.intzaSET.MainColumn = "";
			this.intzaSET.Name = "intzaSET";
			this.intzaSET.Rows = 18;
			this.intzaSET.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaSET.RowSelectType = 0;
			this.intzaSET.RowsVisible = 18;
			this.intzaSET.Size = new Size(347, 207);
			this.intzaSET.SortColumnName = "";
			this.intzaSET.SortType = SortType.Desc;
			this.intzaSET.TabIndex = 85;
			this.intzaBoard.AllowDrop = true;
			this.intzaBoard.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaBoard.CanBlink = true;
			this.intzaBoard.CanDrag = false;
			this.intzaBoard.CanGetMouseMove = false;
			columnItem14.Alignment = StringAlignment.Near;
			columnItem14.BackColor = Color.FromArgb(64, 64, 64);
			columnItem14.ColumnAlignment = StringAlignment.Center;
			columnItem14.FontColor = Color.LightGray;
			columnItem14.MyStyle = FontStyle.Regular;
			columnItem14.Name = "name";
			columnItem14.Text = "Board";
			columnItem14.ValueFormat = FormatType.Text;
			columnItem14.Visible = true;
			columnItem14.Width = 20;
			columnItem15.Alignment = StringAlignment.Far;
			columnItem15.BackColor = Color.FromArgb(64, 64, 64);
			columnItem15.ColumnAlignment = StringAlignment.Center;
			columnItem15.FontColor = Color.LightGray;
			columnItem15.MyStyle = FontStyle.Regular;
			columnItem15.Name = "volume";
			columnItem15.Text = "Volume";
			columnItem15.ValueFormat = FormatType.Price;
			columnItem15.Visible = true;
			columnItem15.Width = 30;
			columnItem16.Alignment = StringAlignment.Far;
			columnItem16.BackColor = Color.FromArgb(64, 64, 64);
			columnItem16.ColumnAlignment = StringAlignment.Center;
			columnItem16.FontColor = Color.LightGray;
			columnItem16.MyStyle = FontStyle.Regular;
			columnItem16.Name = "value";
			columnItem16.Text = "Value";
			columnItem16.ValueFormat = FormatType.Volume;
			columnItem16.Visible = true;
			columnItem16.Width = 30;
			columnItem17.Alignment = StringAlignment.Far;
			columnItem17.BackColor = Color.FromArgb(64, 64, 64);
			columnItem17.ColumnAlignment = StringAlignment.Center;
			columnItem17.FontColor = Color.LightGray;
			columnItem17.MyStyle = FontStyle.Regular;
			columnItem17.Name = "value_pct";
			columnItem17.Text = "%Value";
			columnItem17.ValueFormat = FormatType.Price;
			columnItem17.Visible = true;
			columnItem17.Width = 20;
			this.intzaBoard.Columns.Add(columnItem14);
			this.intzaBoard.Columns.Add(columnItem15);
			this.intzaBoard.Columns.Add(columnItem16);
			this.intzaBoard.Columns.Add(columnItem17);
			this.intzaBoard.CurrentScroll = 0;
			this.intzaBoard.FocusItemIndex = -1;
			this.intzaBoard.ForeColor = Color.Black;
			this.intzaBoard.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaBoard.HeaderPctHeight = 80f;
			this.intzaBoard.IsAutoRepaint = true;
			this.intzaBoard.IsDrawFullRow = false;
			this.intzaBoard.IsDrawGrid = false;
			this.intzaBoard.IsDrawHeader = true;
			this.intzaBoard.IsScrollable = false;
			this.intzaBoard.Location = new Point(359, 29);
			this.intzaBoard.MainColumn = "";
			this.intzaBoard.Name = "intzaBoard";
			this.intzaBoard.Rows = 5;
			this.intzaBoard.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaBoard.RowSelectType = 0;
			this.intzaBoard.RowsVisible = 5;
			this.intzaBoard.Size = new Size(313, 70);
			this.intzaBoard.SortColumnName = "";
			this.intzaBoard.SortType = SortType.Desc;
			this.intzaBoard.TabIndex = 86;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(675, 403);
			base.Controls.Add(this.intzaMarketInfo);
			base.Controls.Add(this.intzaBoard);
			base.Controls.Add(this.intzaSET);
			base.Controls.Add(this.lbChartLoading);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.toolStrip1);
			base.Controls.Add(this.panelSector);
			base.KeyPreview = true;
			base.Name = "frmMarketInfo";
			this.Text = "Sector Statistic";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmSectorInformation_IDOShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmMarketInfo_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmSectorStatistic_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmSectorInformation_IDOCustomSizeChanged);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmSectorStatistic_IDoReActivated);
			base.Controls.SetChildIndex(this.panelSector, 0);
			base.Controls.SetChildIndex(this.toolStrip1, 0);
			base.Controls.SetChildIndex(this.pictureBox1, 0);
			base.Controls.SetChildIndex(this.lbChartLoading, 0);
			base.Controls.SetChildIndex(this.intzaSET, 0);
			base.Controls.SetChildIndex(this.intzaBoard, 0);
			base.Controls.SetChildIndex(this.intzaMarketInfo, 0);
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			this.panelSector.ResumeLayout(false);
			this.panelSector.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A91 RID: 2705
		private int IndustryNumber;

		// Token: 0x04000A92 RID: 2706
		private frmMarketInfo.RecordData _recvDataRealTime;

		// Token: 0x04000A93 RID: 2707
		private BackgroundWorker bgwReloadData;

		// Token: 0x04000A94 RID: 2708
		private DataSet tdsSectorInfo;

		// Token: 0x04000A95 RID: 2709
		private SortType sortType;

		// Token: 0x04000A96 RID: 2710
		private BackgroundWorker bgwMarketInfoLoadData;

		// Token: 0x04000A97 RID: 2711
		private BackgroundWorker bgwReloadChart;

		// Token: 0x04000A98 RID: 2712
		private DataSet dsMarketInfo;

		// Token: 0x04000A99 RID: 2713
		private int selectionMenu;

		// Token: 0x04000A9A RID: 2714
		private bool isLoading;

		// Token: 0x04000A9B RID: 2715
		private string _currentChartName;

		// Token: 0x04000A9C RID: 2716
		private IContainer components;

		// Token: 0x04000A9D RID: 2717
		private ToolStrip tStripMenu;

		// Token: 0x04000A9E RID: 2718
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000A9F RID: 2719
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000AA0 RID: 2720
		private ToolStripButton tsSortBySector;

		// Token: 0x04000AA1 RID: 2721
		private ToolStripButton tsSortByVolume;

		// Token: 0x04000AA2 RID: 2722
		private ToolStripButton tsSortByValues;

		// Token: 0x04000AA3 RID: 2723
		private Panel panelSector;

		// Token: 0x04000AA4 RID: 2724
		private IntzaCustomGrid intzaMarketInfo;

		// Token: 0x04000AA5 RID: 2725
		private ToolStripLabel tsSortBy;

		// Token: 0x04000AA6 RID: 2726
		private ToolStrip toolStrip1;

		// Token: 0x04000AA7 RID: 2727
		private ToolStripButton tsbtnInfo;

		// Token: 0x04000AA8 RID: 2728
		private ToolStripButton tsbtnSETChart;

		// Token: 0x04000AA9 RID: 2729
		private ToolStripButton tsbtnSET50Chart;

		// Token: 0x04000AAA RID: 2730
		private ToolStripButton tsbtnSET100Chart;

		// Token: 0x04000AAB RID: 2731
		private ToolStripButton tsbtnMaiChart;

		// Token: 0x04000AAC RID: 2732
		private ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000AAD RID: 2733
		private PictureBox pictureBox1;

		// Token: 0x04000AAE RID: 2734
		private Label lbChartLoading;

		// Token: 0x04000AAF RID: 2735
		private ToolStripButton tsbtnSETHdChart;

		// Token: 0x04000AB0 RID: 2736
		private Label lbLoading2;

		// Token: 0x04000AB1 RID: 2737
		private ToolStripButton tsbtnSector;

		// Token: 0x04000AB2 RID: 2738
		private ToolStripButton tsbtnIndustry;

		// Token: 0x04000AB3 RID: 2739
		private ToolStripLabel toolStripLabel2;

		// Token: 0x04000AB4 RID: 2740
		private ToolStripButton tsbtnSortAsc;

		// Token: 0x04000AB5 RID: 2741
		private ToolStripButton tsbtnSortDesc;

		// Token: 0x04000AB6 RID: 2742
		private SortGrid intzaSET;

		// Token: 0x04000AB7 RID: 2743
		private SortGrid intzaSector;

		// Token: 0x04000AB8 RID: 2744
		private ToolStripLabel toolStripLabel1;

		// Token: 0x04000AB9 RID: 2745
		private SortGrid intzaBoard;

		// Token: 0x04000ABA RID: 2746
		private ToolStripButton tsbtnsSETChart;

		// Token: 0x0200022B RID: 555
		private struct RecordData
		{
			// Token: 0x04000ABB RID: 2747
			public int Number;

			// Token: 0x04000ABC RID: 2748
			public string Symbol;

			// Token: 0x04000ABD RID: 2749
			public decimal IndexPrior;

			// Token: 0x04000ABE RID: 2750
			public decimal Index;

			// Token: 0x04000ABF RID: 2751
			public long AccVolume;

			// Token: 0x04000AC0 RID: 2752
			public decimal AccValue;

			// Token: 0x04000AC1 RID: 2753
			public decimal Mkt;
		}

		// Token: 0x0200022C RID: 556
		// (Invoke) Token: 0x0600146A RID: 5226
		private delegate void ShowSplashChartCallBack(bool visible);

		// Token: 0x0200022D RID: 557
		// (Invoke) Token: 0x0600146E RID: 5230
		private delegate void ShowSplashCallBack(bool visible);
	}
}
