using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using STIControl;
using STIControl.CustomGrid;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x0200002E RID: 46
	public class frmViewOrderInfoTFEX : Form
	{
		// Token: 0x060001CF RID: 463 RVA: 0x0001DF74 File Offset: 0x0001C374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmViewOrderInfoTFEX(long orderNumber, string ordType, string sendDate, int yPosition) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.currentTop = 50;
			this.orderNumber = 0L;
			this.selDbType = 0;
			this.pageNo = 1;
			this.ordType = string.Empty;
			this.sendDate = string.Empty;
			this.bgwReloadData = null;
			this.yPosition = 0;
			this.tdsOrderTrans = null;
			this.components = null;
			
			try
			{
				this.InitializeComponent();
				this.orderNumber = orderNumber;
				this.ordType = ordType;
				this.sendDate = sendDate;
				this.yPosition = yPosition;
				this.bgwReloadData = new BackgroundWorker();
				this.bgwReloadData.WorkerReportsProgress = true;
				this.bgwReloadData.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
				this.bgwReloadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001E078 File Offset: 0x0001C478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initial(long orderNumber, string ordType, string sendDate)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.orderNumber = orderNumber;
			this.ordType = ordType;
			this.sendDate = sendDate;
			if (this.bgwReloadData != null)
			{
				if (!this.bgwReloadData.IsBusy)
				{
					this.bgwReloadData.RunWorkerAsync();
				}
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001E0DC File Offset: 0x0001C4DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsDisposed)
			{
				try
				{
					if (this.orderNumber > 0L)
					{
						int startRow = (this.pageNo - 1) * this.currentTop + 1;
						string text = ApplicationInfo.WebServiceTFEX.ViewOrderDealData(this.orderNumber, startRow, this.currentTop, this.selDbType, this.ordType, this.sendDate);
						if (!string.IsNullOrEmpty(text))
						{
							if (this.tdsOrderTrans == null)
							{
								this.tdsOrderTrans = new DataSet();
							}
							else
							{
								this.tdsOrderTrans.Clear();
							}
							MyDataHelper.StringToDataSet(text, this.tdsOrderTrans);
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("bgwReloadData_DoWork", ex);
				}
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001E1DC File Offset: 0x0001C5DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsDisposed)
			{
				try
				{
					this.ShowInfo(this.tdsOrderTrans);
					this.tdsOrderTrans.Clear();
				}
				catch (Exception ex)
				{
					this.ShowError("bgwReloadData_RunWorkerCompleted", ex);
				}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001E254 File Offset: 0x0001C654
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowInfo(DataSet tdsOrderTrans)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaInfo1.BeginUpdate();
				this.intzaInfo1.ClearAllText();
				this.intzaInfo2.BeginUpdate();
				this.intzaInfo2.ClearAllText();
				this.intzaInfo3.BeginUpdate();
				this.intzaInfo3.ClearAllText();
				this.intzaInfo4.BeginUpdate();
				this.intzaInfo4.ClearAllText();
				this.intzaInfo5.BeginUpdate();
				this.intzaInfo5.ClearAllText();
				long num = 0L;
				long num2 = 0L;
				long num3 = 0L;
				long num4 = 0L;
				decimal num5 = 0m;
				if (tdsOrderTrans != null && tdsOrderTrans.Tables["ORDER_INFO"].Rows.Count > 0)
				{
					DataRow dataRow = tdsOrderTrans.Tables["ORDER_INFO"].Rows[0];
					long.TryParse(dataRow["order_number"].ToString(), out num);
					if (ApplicationInfo.FrontSystemTFEX == "EFIN")
					{
						this.intzaInfo1.Item("tbOrderNumber").Text = num.ToString().Substring(6);
					}
					else
					{
						this.intzaInfo1.Item("tbOrderNumber").Text = num.ToString();
					}
					if (dataRow["position"].ToString() == "1")
					{
						this.intzaInfo1.Item("tbPosition").Text = "Open";
					}
					else if (dataRow["position"].ToString() == "2")
					{
						this.intzaInfo1.Item("tbPosition").Text = "Close";
					}
					if (dataRow["side"].ToString() == "L")
					{
						this.intzaInfo1.Item("tbSide").Text = "Long";
					}
					else if (dataRow["side"].ToString() == "S")
					{
						this.intzaInfo1.Item("tbSide").Text = "Short";
					}
					this.intzaInfo1.Item("tbStock").Text = dataRow["series"].ToString();
					this.intzaInfo1.Item("tbVolume").Text = dataRow["volume"].ToString();
					decimal.TryParse(dataRow["price"].ToString(), out num5);
					this.intzaInfo1.Item("tbPrice").Text = Utilities.PriceFormat(dataRow["price"].ToString());
					if (this.intzaInfo1.Item("tbPrice").Text.ToString() == string.Empty)
					{
						this.intzaInfo1.Item("tbPrice").Text = "0";
					}
					long.TryParse(dataRow["matched"].ToString(), out num2);
					this.intzaInfo1.Item("tbMatched").Text = num2.ToString();
					long.TryParse(dataRow["published"].ToString(), out num3);
					long.TryParse(dataRow["volume"].ToString(), out num4);
					this.intzaInfo1.Item("tbPublished").Text = num3.ToString();
					this.intzaInfo2.Item("tbValidate").Text = dataRow["validity"].ToString();
					this.intzaInfo2.Item("tbAccount").Text = dataRow["account"].ToString();
					this.intzaInfo2.Item("tbStatus").Text = dataRow["status"].ToString();
					this.intzaInfo2.Item("tbEntryTime").Text = Utilities.GetTime(dataRow["entry_time"].ToString());
					this.intzaInfo2.Item("tbQuote").Text = dataRow["quote"].ToString();
					this.intzaInfo2.Item("tbQuoteTime").Text = Utilities.GetTime(dataRow["quote_time"].ToString());
					this.intzaInfo2.Item("tbOrigPrice").Text = Utilities.PriceFormat(dataRow["original_price"].ToString());
					this.intzaInfo2.Item("tbEntryId").Text = dataRow["entry_trade"].ToString();
					string a = string.Empty;
					a = dataRow["type"].ToString();
					if (a == "L")
					{
						this.intzaInfo3.Item("tbType").Text = "Life Order(L)";
					}
					else if (a == "F")
					{
						this.intzaInfo3.Item("tbType").Text = "After Close";
					}
					else if (a == "M" || a == "P" || a == "T")
					{
						this.intzaInfo3.Item("tbType").Text = "Market Order";
					}
					else
					{
						this.intzaInfo3.Item("tbType").Text = dataRow["type"].ToString();
					}
					if (dataRow["status"].ToString() == "A")
					{
						this.intzaInfo3.Item("tbStatusM").Text = "Waiting for Approve";
					}
					else if (dataRow["status"].ToString() == "D")
					{
						this.intzaInfo3.Item("tbStatusM").Text = "Disapproved";
					}
					else if (dataRow["status"].ToString() == "M")
					{
						this.intzaInfo3.Item("tbStatusM").Text = "Matched";
					}
					else if (dataRow["status"].ToString() == "O")
					{
						this.intzaInfo3.Item("tbStatusM").Text = "Open";
					}
					else if (dataRow["status"].ToString() == "R")
					{
						this.intzaInfo3.Item("tbStatusM").Text = "Rejected";
					}
					else if (dataRow["status"].ToString() == "X")
					{
						this.intzaInfo3.Item("tbStatusM").Text = "Cancel";
					}
					else if (dataRow["status"].ToString() == "PO")
					{
						this.intzaInfo3.Item("tbStatusM").Text = "Pre-open";
					}
					else if (dataRow["status"].ToString() == "C")
					{
						this.intzaInfo3.Item("tbStatusM").Text = "Cancel from SET";
					}
					else
					{
						this.intzaInfo3.Item("tbStatusM").Text = "";
					}
					this.intzaInfo3.Item("tbCanceller").Text = dataRow["cancel_trader"].ToString();
					this.intzaInfo3.Item("tbCancelTime").Text = Utilities.GetTime(dataRow["cancel_time"].ToString());
					this.intzaInfo3.Item("tbStopSeries").Text = dataRow["stop_series"].ToString();
					this.intzaInfo3.Item("tbStopPrice").Text = Utilities.PriceFormat(dataRow["stop_price"].ToString());
					if (this.intzaInfo3.Item("tbStopPrice").Text.ToString() == string.Empty)
					{
						this.intzaInfo3.Item("tbStopPrice").Text = "0";
					}
					this.intzaInfo3.Item("tbRejectCode").Text = dataRow["RejCode"].ToString();
					string text = dataRow["stop_cond"].ToString().Trim();
					if (!string.IsNullOrEmpty(text))
					{
						if (text == "1")
						{
							this.intzaInfo3.Item("tbStopCond").Text = "Bid >=";
						}
						else if (text == "2")
						{
							this.intzaInfo3.Item("tbStopCond").Text = "Bid <=";
						}
						else if (text == "3")
						{
							this.intzaInfo3.Item("tbStopCond").Text = "Ask >=";
						}
						else if (text == "4")
						{
							this.intzaInfo3.Item("tbStopCond").Text = "Ask <=";
						}
						else if (text == "5")
						{
							this.intzaInfo3.Item("tbStopCond").Text = "Last >=";
						}
						else if (text == "6")
						{
							this.intzaInfo3.Item("tbStopCond").Text = "Last <=";
						}
					}
					string text2 = dataRow["RejectMeaning"].ToString();
					int num6 = text2.IndexOf('-');
					if (num6 < 0)
					{
						num6 = text2.IndexOf(':');
					}
					if (num6 > -1)
					{
						this.intzaInfo4.Item("tbRejectDesc").Text = dataRow["RejectMeaning"].ToString().Substring(num6 + 1);
					}
					else
					{
						this.intzaInfo4.Item("tbRejectDesc").Text = dataRow["RejectMeaning"].ToString().Trim();
					}
					this.intzaInfo5.Item("tbTfexOrdNo").Text = dataRow["TFEXOrdNo"].ToString();
					Color fontColor = MyColor.UnChgColor;
					if (dataRow["side"].ToString() == "1")
					{
						fontColor = Color.Lime;
					}
					else if (dataRow["side"].ToString() == "2")
					{
						fontColor = Color.Red;
					}
					this.intzaInfo1.Item("tbSide").FontColor = fontColor;
					try
					{
						this.intzaDeal.BeginUpdate();
						this.intzaDeal.ClearAllText();
						if (tdsOrderTrans.Tables.Contains("DEAL_CONFIRM"))
						{
							this.intzaDeal.Rows = tdsOrderTrans.Tables["DEAL_CONFIRM"].Rows.Count;
							for (int i = 0; i < tdsOrderTrans.Tables["DEAL_CONFIRM"].Rows.Count; i++)
							{
								DataRow dataRow2 = tdsOrderTrans.Tables["DEAL_CONFIRM"].Rows[i];
								RecordItem recordItem = this.intzaDeal.Records(i);
								recordItem.Fields("confirm").Text = dataRow2["confirm_number"].ToString();
								recordItem.Fields("volume").Text = dataRow2["volume"].ToString();
								recordItem.Fields("price").Text = dataRow2["price"].ToString();
								recordItem.Fields("time").Text = Utilities.GetTime(dataRow2["match_time"].ToString());
							}
						}
						else
						{
							this.intzaDeal.Rows = 0;
						}
						this.intzaDeal.Redraw();
					}
					catch (Exception ex)
					{
						this.ShowError("LoadDealConfirmData", ex);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ShowInfo", ex);
			}
			finally
			{
				this.intzaInfo1.Redraw();
				this.intzaInfo2.Redraw();
				this.intzaInfo3.Redraw();
				this.intzaInfo4.Redraw();
				this.intzaInfo5.Redraw();
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0001F110 File Offset: 0x0001D510
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCloseOrderInfo_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001F128 File Offset: 0x0001D528
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001F15C File Offset: 0x0001D55C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPreviousPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.pageNo - 1 > 0)
			{
				this.pageNo--;
				if (!this.bgwReloadData.IsBusy)
				{
					this.bgwReloadData.RunWorkerAsync();
				}
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001F1BC File Offset: 0x0001D5BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btmFirstPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.pageNo > 1)
			{
				this.pageNo = 1;
				if (!this.bgwReloadData.IsBusy)
				{
					this.bgwReloadData.RunWorkerAsync();
				}
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001F214 File Offset: 0x0001D614
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfoTFEX_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.Text = "Deal Data [Press Enter for Close]";
			}
			catch (Exception ex)
			{
				this.ShowError("frmViewOrderInfoTFEX_Enter", ex);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001F26C File Offset: 0x0001D66C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfoTFEX_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Return || keyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001F2B0 File Offset: 0x0001D6B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfoTFEX_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.Text = "Deal Data";
			}
			catch (Exception ex)
			{
				this.ShowError("frmViewOrderInfo_Leave", ex);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0001F308 File Offset: 0x0001D708
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfoTFEX_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (base.Width > base.Parent.ClientSize.Width)
				{
					base.Width = base.Parent.ClientSize.Width;
				}
				if (this.yPosition > 0)
				{
					base.Location = new Point(base.Parent.Width - base.Width - 15, this.yPosition - base.Height);
				}
				else
				{
					base.Location = new Point(1, (base.Parent.Height - base.Height) / 2);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmViewOrderInfoTFEX_Load", ex);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001F3F8 File Offset: 0x0001D7F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfoTFEX_Shown(object sender, EventArgs e)
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

		// Token: 0x060001DD RID: 477 RVA: 0x0001F434 File Offset: 0x0001D834
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

		// Token: 0x060001DE RID: 478 RVA: 0x0001F484 File Offset: 0x0001D884
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ItemGrid itemGrid = new ItemGrid();
			ItemGrid itemGrid2 = new ItemGrid();
			ItemGrid itemGrid3 = new ItemGrid();
			ItemGrid itemGrid4 = new ItemGrid();
			ColumnItem columnItem = new ColumnItem();
			ColumnItem columnItem2 = new ColumnItem();
			ColumnItem columnItem3 = new ColumnItem();
			ColumnItem columnItem4 = new ColumnItem();
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
			this.intzaInfo5 = new IntzaCustomGrid();
			this.intzaInfo4 = new IntzaCustomGrid();
			this.intzaDeal = new SortGrid();
			this.intzaInfo3 = new IntzaCustomGrid();
			this.intzaInfo2 = new IntzaCustomGrid();
			this.intzaInfo1 = new IntzaCustomGrid();
			base.SuspendLayout();
			this.intzaInfo5.AllowDrop = true;
			this.intzaInfo5.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo5.CanDrag = false;
			this.intzaInfo5.IsAutoRepaint = true;
			this.intzaInfo5.IsDroped = false;
			itemGrid.AdjustFontSize = 0f;
			itemGrid.Alignment = StringAlignment.Near;
			itemGrid.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid.Changed = false;
			itemGrid.FieldType = ItemType.Label;
			itemGrid.FontColor = Color.White;
			itemGrid.FontStyle = FontStyle.Regular;
			itemGrid.Height = 1f;
			itemGrid.IsBlink = 0;
			itemGrid.Name = "lbTfexOrdNo                                                 ";
			itemGrid.Text = "TFEX Order No.";
			itemGrid.ValueFormat = FormatType.Text;
			itemGrid.Visible = true;
			itemGrid.Width = 22;
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
			itemGrid2.Name = "tbTfexOrdNo";
			itemGrid2.Text = "";
			itemGrid2.ValueFormat = FormatType.Text;
			itemGrid2.Visible = true;
			itemGrid2.Width = 100;
			itemGrid2.X = 22;
			itemGrid2.Y = 0f;
			this.intzaInfo5.Items.Add(itemGrid);
			this.intzaInfo5.Items.Add(itemGrid2);
			this.intzaInfo5.LineColor = Color.Red;
			this.intzaInfo5.Location = new Point(2, 167);
			this.intzaInfo5.Name = "intzaInfo5";
			this.intzaInfo5.Size = new Size(506, 19);
			this.intzaInfo5.TabIndex = 161;
			this.intzaInfo4.AllowDrop = true;
			this.intzaInfo4.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo4.CanDrag = false;
			this.intzaInfo4.IsAutoRepaint = true;
			this.intzaInfo4.IsDroped = false;
			itemGrid3.AdjustFontSize = 0f;
			itemGrid3.Alignment = StringAlignment.Near;
			itemGrid3.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid3.Changed = false;
			itemGrid3.FieldType = ItemType.Label;
			itemGrid3.FontColor = Color.White;
			itemGrid3.FontStyle = FontStyle.Regular;
			itemGrid3.Height = 1f;
			itemGrid3.IsBlink = 0;
			itemGrid3.Name = "lbRejectDesc";
			itemGrid3.Text = "Reject Desc";
			itemGrid3.ValueFormat = FormatType.Text;
			itemGrid3.Visible = true;
			itemGrid3.Width = 30;
			itemGrid3.X = 0;
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
			itemGrid4.Name = "tbRejectDesc";
			itemGrid4.Text = "";
			itemGrid4.ValueFormat = FormatType.Text;
			itemGrid4.Visible = true;
			itemGrid4.Width = 100;
			itemGrid4.X = 15;
			itemGrid4.Y = 0f;
			this.intzaInfo4.Items.Add(itemGrid3);
			this.intzaInfo4.Items.Add(itemGrid4);
			this.intzaInfo4.LineColor = Color.Red;
			this.intzaInfo4.Location = new Point(2, 147);
			this.intzaInfo4.Name = "intzaInfo4";
			this.intzaInfo4.Size = new Size(506, 19);
			this.intzaInfo4.TabIndex = 160;
			this.intzaDeal.AllowDrop = true;
			this.intzaDeal.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaDeal.CanBlink = false;
			this.intzaDeal.CanDrag = false;
			this.intzaDeal.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "confirm";
			columnItem.Text = "Confirm";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 25;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "volume";
			columnItem2.Text = "Vol";
			columnItem2.ValueFormat = FormatType.Volume;
			columnItem2.Visible = true;
			columnItem2.Width = 25;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "price";
			columnItem3.Text = "Price";
			columnItem3.ValueFormat = FormatType.Price;
			columnItem3.Visible = true;
			columnItem3.Width = 25;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "time";
			columnItem4.Text = "Time";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 25;
			this.intzaDeal.Columns.Add(columnItem);
			this.intzaDeal.Columns.Add(columnItem2);
			this.intzaDeal.Columns.Add(columnItem3);
			this.intzaDeal.Columns.Add(columnItem4);
			this.intzaDeal.CurrentScroll = 0;
			this.intzaDeal.FocusItemIndex = -1;
			this.intzaDeal.ForeColor = Color.Black;
			this.intzaDeal.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaDeal.HeaderPctHeight = 100f;
			this.intzaDeal.IsAutoRepaint = true;
			this.intzaDeal.IsDrawFullRow = true;
			this.intzaDeal.IsDrawGrid = true;
			this.intzaDeal.IsDrawHeader = true;
			this.intzaDeal.IsScrollable = true;
			this.intzaDeal.Location = new Point(510, 3);
			this.intzaDeal.MainColumn = "";
			this.intzaDeal.Name = "intzaDeal";
			this.intzaDeal.Rows = 0;
			this.intzaDeal.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaDeal.RowSelectType = 0;
			this.intzaDeal.RowsVisible = 0;
			this.intzaDeal.Size = new Size(236, 183);
			this.intzaDeal.SortColumnName = "";
			this.intzaDeal.SortType = SortType.Desc;
			this.intzaDeal.TabIndex = 159;
			this.intzaInfo3.AllowDrop = true;
			this.intzaInfo3.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo3.CanDrag = false;
			this.intzaInfo3.IsAutoRepaint = true;
			this.intzaInfo3.IsDroped = false;
			itemGrid5.AdjustFontSize = 0f;
			itemGrid5.Alignment = StringAlignment.Near;
			itemGrid5.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid5.Changed = false;
			itemGrid5.FieldType = ItemType.Label;
			itemGrid5.FontColor = Color.White;
			itemGrid5.FontStyle = FontStyle.Regular;
			itemGrid5.Height = 1f;
			itemGrid5.IsBlink = 0;
			itemGrid5.Name = "lbType";
			itemGrid5.Text = "Type";
			itemGrid5.ValueFormat = FormatType.Text;
			itemGrid5.Visible = true;
			itemGrid5.Width = 50;
			itemGrid5.X = 0;
			itemGrid5.Y = 0f;
			itemGrid6.AdjustFontSize = 0f;
			itemGrid6.Alignment = StringAlignment.Far;
			itemGrid6.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid6.Changed = false;
			itemGrid6.FieldType = ItemType.Text;
			itemGrid6.FontColor = Color.Yellow;
			itemGrid6.FontStyle = FontStyle.Regular;
			itemGrid6.Height = 1f;
			itemGrid6.IsBlink = 0;
			itemGrid6.Name = "tbType";
			itemGrid6.Text = "";
			itemGrid6.ValueFormat = FormatType.Text;
			itemGrid6.Visible = true;
			itemGrid6.Width = 50;
			itemGrid6.X = 50;
			itemGrid6.Y = 0f;
			itemGrid7.AdjustFontSize = 0f;
			itemGrid7.Alignment = StringAlignment.Near;
			itemGrid7.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid7.Changed = false;
			itemGrid7.FieldType = ItemType.Label;
			itemGrid7.FontColor = Color.White;
			itemGrid7.FontStyle = FontStyle.Regular;
			itemGrid7.Height = 1f;
			itemGrid7.IsBlink = 0;
			itemGrid7.Name = "lbStatusM";
			itemGrid7.Text = "Status Desc";
			itemGrid7.ValueFormat = FormatType.Text;
			itemGrid7.Visible = true;
			itemGrid7.Width = 39;
			itemGrid7.X = 0;
			itemGrid7.Y = 1f;
			itemGrid8.AdjustFontSize = 0f;
			itemGrid8.Alignment = StringAlignment.Far;
			itemGrid8.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid8.Changed = false;
			itemGrid8.FieldType = ItemType.Text;
			itemGrid8.FontColor = Color.Yellow;
			itemGrid8.FontStyle = FontStyle.Regular;
			itemGrid8.Height = 1f;
			itemGrid8.IsBlink = 0;
			itemGrid8.Name = "tbStatusM";
			itemGrid8.Text = "";
			itemGrid8.ValueFormat = FormatType.Text;
			itemGrid8.Visible = true;
			itemGrid8.Width = 60;
			itemGrid8.X = 39;
			itemGrid8.Y = 1f;
			itemGrid9.AdjustFontSize = 0f;
			itemGrid9.Alignment = StringAlignment.Near;
			itemGrid9.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid9.Changed = false;
			itemGrid9.FieldType = ItemType.Label;
			itemGrid9.FontColor = Color.White;
			itemGrid9.FontStyle = FontStyle.Regular;
			itemGrid9.Height = 1f;
			itemGrid9.IsBlink = 0;
			itemGrid9.Name = "lbCanceller";
			itemGrid9.Text = "Canceller";
			itemGrid9.ValueFormat = FormatType.Text;
			itemGrid9.Visible = true;
			itemGrid9.Width = 50;
			itemGrid9.X = 0;
			itemGrid9.Y = 2f;
			itemGrid10.AdjustFontSize = 0f;
			itemGrid10.Alignment = StringAlignment.Far;
			itemGrid10.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid10.Changed = false;
			itemGrid10.FieldType = ItemType.Text;
			itemGrid10.FontColor = Color.Yellow;
			itemGrid10.FontStyle = FontStyle.Regular;
			itemGrid10.Height = 1f;
			itemGrid10.IsBlink = 0;
			itemGrid10.Name = "tbCanceller";
			itemGrid10.Text = "";
			itemGrid10.ValueFormat = FormatType.Text;
			itemGrid10.Visible = true;
			itemGrid10.Width = 50;
			itemGrid10.X = 50;
			itemGrid10.Y = 2f;
			itemGrid11.AdjustFontSize = 0f;
			itemGrid11.Alignment = StringAlignment.Near;
			itemGrid11.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid11.Changed = false;
			itemGrid11.FieldType = ItemType.Label;
			itemGrid11.FontColor = Color.White;
			itemGrid11.FontStyle = FontStyle.Regular;
			itemGrid11.Height = 1f;
			itemGrid11.IsBlink = 0;
			itemGrid11.Name = "lbCancelTime";
			itemGrid11.Text = "Cancel Time";
			itemGrid11.ValueFormat = FormatType.Text;
			itemGrid11.Visible = true;
			itemGrid11.Width = 50;
			itemGrid11.X = 0;
			itemGrid11.Y = 3f;
			itemGrid12.AdjustFontSize = 0f;
			itemGrid12.Alignment = StringAlignment.Far;
			itemGrid12.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid12.Changed = false;
			itemGrid12.FieldType = ItemType.Text;
			itemGrid12.FontColor = Color.Yellow;
			itemGrid12.FontStyle = FontStyle.Regular;
			itemGrid12.Height = 1f;
			itemGrid12.IsBlink = 0;
			itemGrid12.Name = "tbCancelTime";
			itemGrid12.Text = "";
			itemGrid12.ValueFormat = FormatType.Text;
			itemGrid12.Visible = true;
			itemGrid12.Width = 50;
			itemGrid12.X = 50;
			itemGrid12.Y = 3f;
			itemGrid13.AdjustFontSize = 0f;
			itemGrid13.Alignment = StringAlignment.Near;
			itemGrid13.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid13.Changed = false;
			itemGrid13.FieldType = ItemType.Label;
			itemGrid13.FontColor = Color.White;
			itemGrid13.FontStyle = FontStyle.Regular;
			itemGrid13.Height = 1f;
			itemGrid13.IsBlink = 0;
			itemGrid13.Name = "lbStopSeries";
			itemGrid13.Text = "Stop Series";
			itemGrid13.ValueFormat = FormatType.Text;
			itemGrid13.Visible = true;
			itemGrid13.Width = 50;
			itemGrid13.X = 0;
			itemGrid13.Y = 4f;
			itemGrid14.AdjustFontSize = 0f;
			itemGrid14.Alignment = StringAlignment.Far;
			itemGrid14.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid14.Changed = false;
			itemGrid14.FieldType = ItemType.Text;
			itemGrid14.FontColor = Color.Cyan;
			itemGrid14.FontStyle = FontStyle.Regular;
			itemGrid14.Height = 1f;
			itemGrid14.IsBlink = 0;
			itemGrid14.Name = "tbStopSeries";
			itemGrid14.Text = "";
			itemGrid14.ValueFormat = FormatType.Text;
			itemGrid14.Visible = true;
			itemGrid14.Width = 50;
			itemGrid14.X = 50;
			itemGrid14.Y = 4f;
			itemGrid15.AdjustFontSize = 0f;
			itemGrid15.Alignment = StringAlignment.Near;
			itemGrid15.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid15.Changed = false;
			itemGrid15.FieldType = ItemType.Label;
			itemGrid15.FontColor = Color.White;
			itemGrid15.FontStyle = FontStyle.Regular;
			itemGrid15.Height = 1f;
			itemGrid15.IsBlink = 0;
			itemGrid15.Name = "lbStopPrice";
			itemGrid15.Text = "Stop Price";
			itemGrid15.ValueFormat = FormatType.Text;
			itemGrid15.Visible = true;
			itemGrid15.Width = 50;
			itemGrid15.X = 0;
			itemGrid15.Y = 5f;
			itemGrid16.AdjustFontSize = 0f;
			itemGrid16.Alignment = StringAlignment.Far;
			itemGrid16.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid16.Changed = false;
			itemGrid16.FieldType = ItemType.Text;
			itemGrid16.FontColor = Color.Yellow;
			itemGrid16.FontStyle = FontStyle.Regular;
			itemGrid16.Height = 1f;
			itemGrid16.IsBlink = 0;
			itemGrid16.Name = "tbStopPrice";
			itemGrid16.Text = "";
			itemGrid16.ValueFormat = FormatType.Text;
			itemGrid16.Visible = true;
			itemGrid16.Width = 50;
			itemGrid16.X = 50;
			itemGrid16.Y = 5f;
			itemGrid17.AdjustFontSize = 0f;
			itemGrid17.Alignment = StringAlignment.Near;
			itemGrid17.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid17.Changed = false;
			itemGrid17.FieldType = ItemType.Label;
			itemGrid17.FontColor = Color.White;
			itemGrid17.FontStyle = FontStyle.Regular;
			itemGrid17.Height = 1f;
			itemGrid17.IsBlink = 0;
			itemGrid17.Name = "lbStopCond";
			itemGrid17.Text = "Stop Cond";
			itemGrid17.ValueFormat = FormatType.Text;
			itemGrid17.Visible = true;
			itemGrid17.Width = 50;
			itemGrid17.X = 0;
			itemGrid17.Y = 6f;
			itemGrid18.AdjustFontSize = 0f;
			itemGrid18.Alignment = StringAlignment.Far;
			itemGrid18.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid18.Changed = false;
			itemGrid18.FieldType = ItemType.Text;
			itemGrid18.FontColor = Color.Yellow;
			itemGrid18.FontStyle = FontStyle.Regular;
			itemGrid18.Height = 1f;
			itemGrid18.IsBlink = 0;
			itemGrid18.Name = "tbStopCond";
			itemGrid18.Text = "";
			itemGrid18.ValueFormat = FormatType.Text;
			itemGrid18.Visible = true;
			itemGrid18.Width = 50;
			itemGrid18.X = 50;
			itemGrid18.Y = 6f;
			itemGrid19.AdjustFontSize = 0f;
			itemGrid19.Alignment = StringAlignment.Near;
			itemGrid19.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid19.Changed = false;
			itemGrid19.FieldType = ItemType.Label;
			itemGrid19.FontColor = Color.White;
			itemGrid19.FontStyle = FontStyle.Regular;
			itemGrid19.Height = 1f;
			itemGrid19.IsBlink = 0;
			itemGrid19.Name = "lbRejectCode";
			itemGrid19.Text = "Reject Code";
			itemGrid19.ValueFormat = FormatType.Text;
			itemGrid19.Visible = true;
			itemGrid19.Width = 50;
			itemGrid19.X = 0;
			itemGrid19.Y = 7f;
			itemGrid20.AdjustFontSize = 0f;
			itemGrid20.Alignment = StringAlignment.Far;
			itemGrid20.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid20.Changed = false;
			itemGrid20.FieldType = ItemType.Text;
			itemGrid20.FontColor = Color.Yellow;
			itemGrid20.FontStyle = FontStyle.Regular;
			itemGrid20.Height = 1f;
			itemGrid20.IsBlink = 0;
			itemGrid20.Name = "tbRejectCode";
			itemGrid20.Text = "";
			itemGrid20.ValueFormat = FormatType.Text;
			itemGrid20.Visible = true;
			itemGrid20.Width = 50;
			itemGrid20.X = 50;
			itemGrid20.Y = 7f;
			this.intzaInfo3.Items.Add(itemGrid5);
			this.intzaInfo3.Items.Add(itemGrid6);
			this.intzaInfo3.Items.Add(itemGrid7);
			this.intzaInfo3.Items.Add(itemGrid8);
			this.intzaInfo3.Items.Add(itemGrid9);
			this.intzaInfo3.Items.Add(itemGrid10);
			this.intzaInfo3.Items.Add(itemGrid11);
			this.intzaInfo3.Items.Add(itemGrid12);
			this.intzaInfo3.Items.Add(itemGrid13);
			this.intzaInfo3.Items.Add(itemGrid14);
			this.intzaInfo3.Items.Add(itemGrid15);
			this.intzaInfo3.Items.Add(itemGrid16);
			this.intzaInfo3.Items.Add(itemGrid17);
			this.intzaInfo3.Items.Add(itemGrid18);
			this.intzaInfo3.Items.Add(itemGrid19);
			this.intzaInfo3.Items.Add(itemGrid20);
			this.intzaInfo3.LineColor = Color.Red;
			this.intzaInfo3.Location = new Point(328, 3);
			this.intzaInfo3.Margin = new Padding(0);
			this.intzaInfo3.Name = "intzaInfo3";
			this.intzaInfo3.Size = new Size(180, 143);
			this.intzaInfo3.TabIndex = 158;
			this.intzaInfo2.AllowDrop = true;
			this.intzaInfo2.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo2.CanDrag = false;
			this.intzaInfo2.IsAutoRepaint = true;
			this.intzaInfo2.IsDroped = false;
			itemGrid21.AdjustFontSize = 0f;
			itemGrid21.Alignment = StringAlignment.Near;
			itemGrid21.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid21.Changed = false;
			itemGrid21.FieldType = ItemType.Label;
			itemGrid21.FontColor = Color.White;
			itemGrid21.FontStyle = FontStyle.Regular;
			itemGrid21.Height = 1f;
			itemGrid21.IsBlink = 0;
			itemGrid21.Name = "lbValidate";
			itemGrid21.Text = "Validate";
			itemGrid21.ValueFormat = FormatType.Volume;
			itemGrid21.Visible = true;
			itemGrid21.Width = 58;
			itemGrid21.X = 0;
			itemGrid21.Y = 0f;
			itemGrid22.AdjustFontSize = 0f;
			itemGrid22.Alignment = StringAlignment.Far;
			itemGrid22.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid22.Changed = false;
			itemGrid22.FieldType = ItemType.Text;
			itemGrid22.FontColor = Color.Yellow;
			itemGrid22.FontStyle = FontStyle.Regular;
			itemGrid22.Height = 1f;
			itemGrid22.IsBlink = 0;
			itemGrid22.Name = "tbValidate";
			itemGrid22.Text = "";
			itemGrid22.ValueFormat = FormatType.Text;
			itemGrid22.Visible = true;
			itemGrid22.Width = 42;
			itemGrid22.X = 58;
			itemGrid22.Y = 0f;
			itemGrid23.AdjustFontSize = 0f;
			itemGrid23.Alignment = StringAlignment.Near;
			itemGrid23.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid23.Changed = false;
			itemGrid23.FieldType = ItemType.Label;
			itemGrid23.FontColor = Color.White;
			itemGrid23.FontStyle = FontStyle.Regular;
			itemGrid23.Height = 1f;
			itemGrid23.IsBlink = 0;
			itemGrid23.Name = "lbAccount";
			itemGrid23.Text = "Account";
			itemGrid23.ValueFormat = FormatType.Text;
			itemGrid23.Visible = true;
			itemGrid23.Width = 40;
			itemGrid23.X = 0;
			itemGrid23.Y = 1f;
			itemGrid24.AdjustFontSize = 0f;
			itemGrid24.Alignment = StringAlignment.Far;
			itemGrid24.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid24.Changed = false;
			itemGrid24.FieldType = ItemType.Text;
			itemGrid24.FontColor = Color.Cyan;
			itemGrid24.FontStyle = FontStyle.Regular;
			itemGrid24.Height = 1f;
			itemGrid24.IsBlink = 0;
			itemGrid24.Name = "tbAccount";
			itemGrid24.Text = "";
			itemGrid24.ValueFormat = FormatType.Text;
			itemGrid24.Visible = true;
			itemGrid24.Width = 55;
			itemGrid24.X = 45;
			itemGrid24.Y = 1f;
			itemGrid25.AdjustFontSize = 0f;
			itemGrid25.Alignment = StringAlignment.Near;
			itemGrid25.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid25.Changed = false;
			itemGrid25.FieldType = ItemType.Label;
			itemGrid25.FontColor = Color.White;
			itemGrid25.FontStyle = FontStyle.Regular;
			itemGrid25.Height = 1f;
			itemGrid25.IsBlink = 0;
			itemGrid25.Name = "lbStatus";
			itemGrid25.Text = "Status";
			itemGrid25.ValueFormat = FormatType.Text;
			itemGrid25.Visible = true;
			itemGrid25.Width = 58;
			itemGrid25.X = 0;
			itemGrid25.Y = 2f;
			itemGrid26.AdjustFontSize = 0f;
			itemGrid26.Alignment = StringAlignment.Far;
			itemGrid26.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid26.Changed = false;
			itemGrid26.FieldType = ItemType.Text;
			itemGrid26.FontColor = Color.Cyan;
			itemGrid26.FontStyle = FontStyle.Regular;
			itemGrid26.Height = 1f;
			itemGrid26.IsBlink = 0;
			itemGrid26.Name = "tbStatus";
			itemGrid26.Text = "";
			itemGrid26.ValueFormat = FormatType.Text;
			itemGrid26.Visible = true;
			itemGrid26.Width = 42;
			itemGrid26.X = 58;
			itemGrid26.Y = 2f;
			itemGrid27.AdjustFontSize = 0f;
			itemGrid27.Alignment = StringAlignment.Near;
			itemGrid27.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid27.Changed = false;
			itemGrid27.FieldType = ItemType.Label;
			itemGrid27.FontColor = Color.White;
			itemGrid27.FontStyle = FontStyle.Regular;
			itemGrid27.Height = 1f;
			itemGrid27.IsBlink = 0;
			itemGrid27.Name = "lbEntryTime";
			itemGrid27.Text = "Entry Time";
			itemGrid27.ValueFormat = FormatType.Text;
			itemGrid27.Visible = true;
			itemGrid27.Width = 58;
			itemGrid27.X = 0;
			itemGrid27.Y = 3f;
			itemGrid28.AdjustFontSize = 0f;
			itemGrid28.Alignment = StringAlignment.Far;
			itemGrid28.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid28.Changed = false;
			itemGrid28.FieldType = ItemType.Text;
			itemGrid28.FontColor = Color.Yellow;
			itemGrid28.FontStyle = FontStyle.Regular;
			itemGrid28.Height = 1f;
			itemGrid28.IsBlink = 0;
			itemGrid28.Name = "tbEntryTime";
			itemGrid28.Text = "";
			itemGrid28.ValueFormat = FormatType.Text;
			itemGrid28.Visible = true;
			itemGrid28.Width = 42;
			itemGrid28.X = 58;
			itemGrid28.Y = 3f;
			itemGrid29.AdjustFontSize = 0f;
			itemGrid29.Alignment = StringAlignment.Near;
			itemGrid29.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid29.Changed = false;
			itemGrid29.FieldType = ItemType.Label;
			itemGrid29.FontColor = Color.White;
			itemGrid29.FontStyle = FontStyle.Regular;
			itemGrid29.Height = 1f;
			itemGrid29.IsBlink = 0;
			itemGrid29.Name = "lbQuote";
			itemGrid29.Text = "Quote";
			itemGrid29.ValueFormat = FormatType.Text;
			itemGrid29.Visible = true;
			itemGrid29.Width = 58;
			itemGrid29.X = 0;
			itemGrid29.Y = 4f;
			itemGrid30.AdjustFontSize = 0f;
			itemGrid30.Alignment = StringAlignment.Far;
			itemGrid30.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid30.Changed = false;
			itemGrid30.FieldType = ItemType.Text;
			itemGrid30.FontColor = Color.Yellow;
			itemGrid30.FontStyle = FontStyle.Regular;
			itemGrid30.Height = 1f;
			itemGrid30.IsBlink = 0;
			itemGrid30.Name = "tbQuote";
			itemGrid30.Text = "";
			itemGrid30.ValueFormat = FormatType.Text;
			itemGrid30.Visible = true;
			itemGrid30.Width = 42;
			itemGrid30.X = 58;
			itemGrid30.Y = 4f;
			itemGrid31.AdjustFontSize = 0f;
			itemGrid31.Alignment = StringAlignment.Near;
			itemGrid31.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid31.Changed = false;
			itemGrid31.FieldType = ItemType.Label;
			itemGrid31.FontColor = Color.White;
			itemGrid31.FontStyle = FontStyle.Regular;
			itemGrid31.Height = 1f;
			itemGrid31.IsBlink = 0;
			itemGrid31.Name = "lbQuoteTime";
			itemGrid31.Text = "Quote Time";
			itemGrid31.ValueFormat = FormatType.Text;
			itemGrid31.Visible = true;
			itemGrid31.Width = 58;
			itemGrid31.X = 0;
			itemGrid31.Y = 5f;
			itemGrid32.AdjustFontSize = 0f;
			itemGrid32.Alignment = StringAlignment.Far;
			itemGrid32.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid32.Changed = false;
			itemGrid32.FieldType = ItemType.Text;
			itemGrid32.FontColor = Color.Yellow;
			itemGrid32.FontStyle = FontStyle.Regular;
			itemGrid32.Height = 1f;
			itemGrid32.IsBlink = 0;
			itemGrid32.Name = "tbQuoteTime";
			itemGrid32.Text = "";
			itemGrid32.ValueFormat = FormatType.Text;
			itemGrid32.Visible = true;
			itemGrid32.Width = 42;
			itemGrid32.X = 58;
			itemGrid32.Y = 5f;
			itemGrid33.AdjustFontSize = 0f;
			itemGrid33.Alignment = StringAlignment.Near;
			itemGrid33.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid33.Changed = false;
			itemGrid33.FieldType = ItemType.Label;
			itemGrid33.FontColor = Color.White;
			itemGrid33.FontStyle = FontStyle.Regular;
			itemGrid33.Height = 1f;
			itemGrid33.IsBlink = 0;
			itemGrid33.Name = "lbOrigPrice";
			itemGrid33.Text = "Original Price";
			itemGrid33.ValueFormat = FormatType.Text;
			itemGrid33.Visible = true;
			itemGrid33.Width = 58;
			itemGrid33.X = 0;
			itemGrid33.Y = 6f;
			itemGrid34.AdjustFontSize = 0f;
			itemGrid34.Alignment = StringAlignment.Far;
			itemGrid34.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid34.Changed = false;
			itemGrid34.FieldType = ItemType.Text;
			itemGrid34.FontColor = Color.Red;
			itemGrid34.FontStyle = FontStyle.Regular;
			itemGrid34.Height = 1f;
			itemGrid34.IsBlink = 0;
			itemGrid34.Name = "tbOrigPrice";
			itemGrid34.Text = "";
			itemGrid34.ValueFormat = FormatType.Text;
			itemGrid34.Visible = true;
			itemGrid34.Width = 42;
			itemGrid34.X = 58;
			itemGrid34.Y = 6f;
			itemGrid35.AdjustFontSize = 0f;
			itemGrid35.Alignment = StringAlignment.Near;
			itemGrid35.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid35.Changed = false;
			itemGrid35.FieldType = ItemType.Label;
			itemGrid35.FontColor = Color.White;
			itemGrid35.FontStyle = FontStyle.Regular;
			itemGrid35.Height = 1f;
			itemGrid35.IsBlink = 0;
			itemGrid35.Name = "lbEntryId";
			itemGrid35.Text = "Entry Id";
			itemGrid35.ValueFormat = FormatType.Text;
			itemGrid35.Visible = true;
			itemGrid35.Width = 58;
			itemGrid35.X = 0;
			itemGrid35.Y = 7f;
			itemGrid36.AdjustFontSize = 0f;
			itemGrid36.Alignment = StringAlignment.Far;
			itemGrid36.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid36.Changed = false;
			itemGrid36.FieldType = ItemType.Text;
			itemGrid36.FontColor = Color.Yellow;
			itemGrid36.FontStyle = FontStyle.Regular;
			itemGrid36.Height = 1f;
			itemGrid36.IsBlink = 0;
			itemGrid36.Name = "tbEntryId";
			itemGrid36.Text = "";
			itemGrid36.ValueFormat = FormatType.Text;
			itemGrid36.Visible = true;
			itemGrid36.Width = 42;
			itemGrid36.X = 58;
			itemGrid36.Y = 7f;
			this.intzaInfo2.Items.Add(itemGrid21);
			this.intzaInfo2.Items.Add(itemGrid22);
			this.intzaInfo2.Items.Add(itemGrid23);
			this.intzaInfo2.Items.Add(itemGrid24);
			this.intzaInfo2.Items.Add(itemGrid25);
			this.intzaInfo2.Items.Add(itemGrid26);
			this.intzaInfo2.Items.Add(itemGrid27);
			this.intzaInfo2.Items.Add(itemGrid28);
			this.intzaInfo2.Items.Add(itemGrid29);
			this.intzaInfo2.Items.Add(itemGrid30);
			this.intzaInfo2.Items.Add(itemGrid31);
			this.intzaInfo2.Items.Add(itemGrid32);
			this.intzaInfo2.Items.Add(itemGrid33);
			this.intzaInfo2.Items.Add(itemGrid34);
			this.intzaInfo2.Items.Add(itemGrid35);
			this.intzaInfo2.Items.Add(itemGrid36);
			this.intzaInfo2.LineColor = Color.Red;
			this.intzaInfo2.Location = new Point(170, 3);
			this.intzaInfo2.Name = "intzaInfo2";
			this.intzaInfo2.Size = new Size(156, 143);
			this.intzaInfo2.TabIndex = 157;
			this.intzaInfo1.AllowDrop = true;
			this.intzaInfo1.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo1.CanDrag = false;
			this.intzaInfo1.IsAutoRepaint = true;
			this.intzaInfo1.IsDroped = false;
			itemGrid37.AdjustFontSize = 0f;
			itemGrid37.Alignment = StringAlignment.Near;
			itemGrid37.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid37.Changed = false;
			itemGrid37.FieldType = ItemType.Label;
			itemGrid37.FontColor = Color.White;
			itemGrid37.FontStyle = FontStyle.Regular;
			itemGrid37.Height = 1f;
			itemGrid37.IsBlink = 0;
			itemGrid37.Name = "lbOrderNumber";
			itemGrid37.Text = "Order No.";
			itemGrid37.ValueFormat = FormatType.Text;
			itemGrid37.Visible = true;
			itemGrid37.Width = 38;
			itemGrid37.X = 0;
			itemGrid37.Y = 0f;
			itemGrid38.AdjustFontSize = 0f;
			itemGrid38.Alignment = StringAlignment.Far;
			itemGrid38.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid38.Changed = false;
			itemGrid38.FieldType = ItemType.Text;
			itemGrid38.FontColor = Color.Cyan;
			itemGrid38.FontStyle = FontStyle.Regular;
			itemGrid38.Height = 1f;
			itemGrid38.IsBlink = 0;
			itemGrid38.Name = "tbOrderNumber";
			itemGrid38.Text = "";
			itemGrid38.ValueFormat = FormatType.Text;
			itemGrid38.Visible = true;
			itemGrid38.Width = 63;
			itemGrid38.X = 38;
			itemGrid38.Y = 0f;
			itemGrid39.AdjustFontSize = 0f;
			itemGrid39.Alignment = StringAlignment.Near;
			itemGrid39.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid39.Changed = false;
			itemGrid39.FieldType = ItemType.Label;
			itemGrid39.FontColor = Color.White;
			itemGrid39.FontStyle = FontStyle.Regular;
			itemGrid39.Height = 1f;
			itemGrid39.IsBlink = 0;
			itemGrid39.Name = "lbPosition";
			itemGrid39.Text = "Position";
			itemGrid39.ValueFormat = FormatType.Text;
			itemGrid39.Visible = true;
			itemGrid39.Width = 55;
			itemGrid39.X = 0;
			itemGrid39.Y = 1f;
			itemGrid40.AdjustFontSize = 0f;
			itemGrid40.Alignment = StringAlignment.Far;
			itemGrid40.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid40.Changed = false;
			itemGrid40.FieldType = ItemType.Text;
			itemGrid40.FontColor = Color.Yellow;
			itemGrid40.FontStyle = FontStyle.Regular;
			itemGrid40.Height = 1f;
			itemGrid40.IsBlink = 0;
			itemGrid40.Name = "tbPosition";
			itemGrid40.Text = "";
			itemGrid40.ValueFormat = FormatType.Text;
			itemGrid40.Visible = true;
			itemGrid40.Width = 45;
			itemGrid40.X = 55;
			itemGrid40.Y = 1f;
			itemGrid41.AdjustFontSize = 0f;
			itemGrid41.Alignment = StringAlignment.Near;
			itemGrid41.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid41.Changed = false;
			itemGrid41.FieldType = ItemType.Label;
			itemGrid41.FontColor = Color.White;
			itemGrid41.FontStyle = FontStyle.Regular;
			itemGrid41.Height = 1f;
			itemGrid41.IsBlink = 0;
			itemGrid41.Name = "lbSide";
			itemGrid41.Text = "Side";
			itemGrid41.ValueFormat = FormatType.Text;
			itemGrid41.Visible = true;
			itemGrid41.Width = 55;
			itemGrid41.X = 0;
			itemGrid41.Y = 2f;
			itemGrid42.AdjustFontSize = 0f;
			itemGrid42.Alignment = StringAlignment.Far;
			itemGrid42.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid42.Changed = false;
			itemGrid42.FieldType = ItemType.Text;
			itemGrid42.FontColor = Color.White;
			itemGrid42.FontStyle = FontStyle.Regular;
			itemGrid42.Height = 1f;
			itemGrid42.IsBlink = 0;
			itemGrid42.Name = "tbSide";
			itemGrid42.Text = "";
			itemGrid42.ValueFormat = FormatType.Text;
			itemGrid42.Visible = true;
			itemGrid42.Width = 45;
			itemGrid42.X = 55;
			itemGrid42.Y = 2f;
			itemGrid43.AdjustFontSize = 0f;
			itemGrid43.Alignment = StringAlignment.Near;
			itemGrid43.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid43.Changed = false;
			itemGrid43.FieldType = ItemType.Label;
			itemGrid43.FontColor = Color.White;
			itemGrid43.FontStyle = FontStyle.Regular;
			itemGrid43.Height = 1f;
			itemGrid43.IsBlink = 0;
			itemGrid43.Name = "lbStock";
			itemGrid43.Text = "Symbol";
			itemGrid43.ValueFormat = FormatType.Text;
			itemGrid43.Visible = true;
			itemGrid43.Width = 40;
			itemGrid43.X = 0;
			itemGrid43.Y = 3f;
			itemGrid44.AdjustFontSize = 0f;
			itemGrid44.Alignment = StringAlignment.Far;
			itemGrid44.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid44.Changed = false;
			itemGrid44.FieldType = ItemType.Text;
			itemGrid44.FontColor = Color.Yellow;
			itemGrid44.FontStyle = FontStyle.Regular;
			itemGrid44.Height = 1f;
			itemGrid44.IsBlink = 0;
			itemGrid44.Name = "tbStock";
			itemGrid44.Text = "";
			itemGrid44.ValueFormat = FormatType.Text;
			itemGrid44.Visible = true;
			itemGrid44.Width = 60;
			itemGrid44.X = 40;
			itemGrid44.Y = 3f;
			itemGrid45.AdjustFontSize = 0f;
			itemGrid45.Alignment = StringAlignment.Near;
			itemGrid45.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid45.Changed = false;
			itemGrid45.FieldType = ItemType.Label;
			itemGrid45.FontColor = Color.White;
			itemGrid45.FontStyle = FontStyle.Regular;
			itemGrid45.Height = 1f;
			itemGrid45.IsBlink = 0;
			itemGrid45.Name = "lbVolume";
			itemGrid45.Text = "Volume";
			itemGrid45.ValueFormat = FormatType.Text;
			itemGrid45.Visible = true;
			itemGrid45.Width = 55;
			itemGrid45.X = 0;
			itemGrid45.Y = 4f;
			itemGrid46.AdjustFontSize = 0f;
			itemGrid46.Alignment = StringAlignment.Far;
			itemGrid46.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid46.Changed = false;
			itemGrid46.FieldType = ItemType.Text;
			itemGrid46.FontColor = Color.Yellow;
			itemGrid46.FontStyle = FontStyle.Regular;
			itemGrid46.Height = 1f;
			itemGrid46.IsBlink = 0;
			itemGrid46.Name = "tbVolume";
			itemGrid46.Text = "";
			itemGrid46.ValueFormat = FormatType.Volume;
			itemGrid46.Visible = true;
			itemGrid46.Width = 45;
			itemGrid46.X = 55;
			itemGrid46.Y = 4f;
			itemGrid47.AdjustFontSize = 0f;
			itemGrid47.Alignment = StringAlignment.Near;
			itemGrid47.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid47.Changed = false;
			itemGrid47.FieldType = ItemType.Label;
			itemGrid47.FontColor = Color.White;
			itemGrid47.FontStyle = FontStyle.Regular;
			itemGrid47.Height = 1f;
			itemGrid47.IsBlink = 0;
			itemGrid47.Name = "lbPrice";
			itemGrid47.Text = "Price";
			itemGrid47.ValueFormat = FormatType.Text;
			itemGrid47.Visible = true;
			itemGrid47.Width = 55;
			itemGrid47.X = 0;
			itemGrid47.Y = 5f;
			itemGrid48.AdjustFontSize = 0f;
			itemGrid48.Alignment = StringAlignment.Far;
			itemGrid48.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid48.Changed = false;
			itemGrid48.FieldType = ItemType.Text;
			itemGrid48.FontColor = Color.Yellow;
			itemGrid48.FontStyle = FontStyle.Regular;
			itemGrid48.Height = 1f;
			itemGrid48.IsBlink = 0;
			itemGrid48.Name = "tbPrice";
			itemGrid48.Text = "";
			itemGrid48.ValueFormat = FormatType.Text;
			itemGrid48.Visible = true;
			itemGrid48.Width = 45;
			itemGrid48.X = 55;
			itemGrid48.Y = 5f;
			itemGrid49.AdjustFontSize = 0f;
			itemGrid49.Alignment = StringAlignment.Near;
			itemGrid49.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid49.Changed = false;
			itemGrid49.FieldType = ItemType.Label;
			itemGrid49.FontColor = Color.White;
			itemGrid49.FontStyle = FontStyle.Regular;
			itemGrid49.Height = 1f;
			itemGrid49.IsBlink = 0;
			itemGrid49.Name = "lbMatched";
			itemGrid49.Text = "Matched";
			itemGrid49.ValueFormat = FormatType.Text;
			itemGrid49.Visible = true;
			itemGrid49.Width = 55;
			itemGrid49.X = 0;
			itemGrid49.Y = 6f;
			itemGrid50.AdjustFontSize = 0f;
			itemGrid50.Alignment = StringAlignment.Far;
			itemGrid50.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid50.Changed = false;
			itemGrid50.FieldType = ItemType.Text;
			itemGrid50.FontColor = Color.Cyan;
			itemGrid50.FontStyle = FontStyle.Regular;
			itemGrid50.Height = 1f;
			itemGrid50.IsBlink = 0;
			itemGrid50.Name = "tbMatched";
			itemGrid50.Text = "";
			itemGrid50.ValueFormat = FormatType.Volume;
			itemGrid50.Visible = true;
			itemGrid50.Width = 45;
			itemGrid50.X = 55;
			itemGrid50.Y = 6f;
			itemGrid51.AdjustFontSize = 0f;
			itemGrid51.Alignment = StringAlignment.Near;
			itemGrid51.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid51.Changed = false;
			itemGrid51.FieldType = ItemType.Label;
			itemGrid51.FontColor = Color.White;
			itemGrid51.FontStyle = FontStyle.Regular;
			itemGrid51.Height = 1f;
			itemGrid51.IsBlink = 0;
			itemGrid51.Name = "lbPublished";
			itemGrid51.Text = "Published";
			itemGrid51.ValueFormat = FormatType.Text;
			itemGrid51.Visible = true;
			itemGrid51.Width = 55;
			itemGrid51.X = 0;
			itemGrid51.Y = 7f;
			itemGrid52.AdjustFontSize = 0f;
			itemGrid52.Alignment = StringAlignment.Far;
			itemGrid52.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid52.Changed = false;
			itemGrid52.FieldType = ItemType.Text;
			itemGrid52.FontColor = Color.Cyan;
			itemGrid52.FontStyle = FontStyle.Regular;
			itemGrid52.Height = 1f;
			itemGrid52.IsBlink = 0;
			itemGrid52.Name = "tbPublished";
			itemGrid52.Text = "";
			itemGrid52.ValueFormat = FormatType.Volume;
			itemGrid52.Visible = true;
			itemGrid52.Width = 45;
			itemGrid52.X = 55;
			itemGrid52.Y = 7f;
			this.intzaInfo1.Items.Add(itemGrid37);
			this.intzaInfo1.Items.Add(itemGrid38);
			this.intzaInfo1.Items.Add(itemGrid39);
			this.intzaInfo1.Items.Add(itemGrid40);
			this.intzaInfo1.Items.Add(itemGrid41);
			this.intzaInfo1.Items.Add(itemGrid42);
			this.intzaInfo1.Items.Add(itemGrid43);
			this.intzaInfo1.Items.Add(itemGrid44);
			this.intzaInfo1.Items.Add(itemGrid45);
			this.intzaInfo1.Items.Add(itemGrid46);
			this.intzaInfo1.Items.Add(itemGrid47);
			this.intzaInfo1.Items.Add(itemGrid48);
			this.intzaInfo1.Items.Add(itemGrid49);
			this.intzaInfo1.Items.Add(itemGrid50);
			this.intzaInfo1.Items.Add(itemGrid51);
			this.intzaInfo1.Items.Add(itemGrid52);
			this.intzaInfo1.LineColor = Color.Red;
			this.intzaInfo1.Location = new Point(2, 3);
			this.intzaInfo1.Name = "intzaInfo1";
			this.intzaInfo1.Size = new Size(166, 143);
			this.intzaInfo1.TabIndex = 156;
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(748, 188);
			base.Controls.Add(this.intzaInfo5);
			base.Controls.Add(this.intzaInfo4);
			base.Controls.Add(this.intzaDeal);
			base.Controls.Add(this.intzaInfo3);
			base.Controls.Add(this.intzaInfo2);
			base.Controls.Add(this.intzaInfo1);
			this.Font = new Font("Microsoft Sans Serif", 9f);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "frmViewOrderInfoTFEX";
			this.Text = "frmViewOrderInfoTFEX";
			base.Load += new EventHandler(this.frmViewOrderInfoTFEX_Load);
			base.Shown += new EventHandler(this.frmViewOrderInfoTFEX_Shown);
			base.Enter += new EventHandler(this.frmViewOrderInfoTFEX_Enter);
			base.Leave += new EventHandler(this.frmViewOrderInfoTFEX_Leave);
			base.KeyDown += new KeyEventHandler(this.frmViewOrderInfoTFEX_KeyDown);
			base.ResumeLayout(false);
		}

		// Token: 0x04000108 RID: 264
		private int currentTop;

		// Token: 0x04000109 RID: 265
		private long orderNumber;

		// Token: 0x0400010A RID: 266
		private int selDbType;

		// Token: 0x0400010B RID: 267
		private int pageNo;

		// Token: 0x0400010C RID: 268
		private string ordType;

		// Token: 0x0400010D RID: 269
		private string sendDate;

		// Token: 0x0400010E RID: 270
		private BackgroundWorker bgwReloadData;

		// Token: 0x0400010F RID: 271
		private int yPosition;

		// Token: 0x04000110 RID: 272
		private DataSet tdsOrderTrans;

		// Token: 0x04000111 RID: 273
		private IContainer components;

		// Token: 0x04000112 RID: 274
		private IntzaCustomGrid intzaInfo4;

		// Token: 0x04000113 RID: 275
		private SortGrid intzaDeal;

		// Token: 0x04000114 RID: 276
		private IntzaCustomGrid intzaInfo3;

		// Token: 0x04000115 RID: 277
		private IntzaCustomGrid intzaInfo2;

		// Token: 0x04000116 RID: 278
		private IntzaCustomGrid intzaInfo1;

		// Token: 0x04000117 RID: 279
		private IntzaCustomGrid intzaInfo5;
	}
}
