using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using ITSNet.Common.BIZ;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus.FixForm
{
	// Token: 0x02000235 RID: 565
	public class frmViewOrder : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x0600157C RID: 5500 RVA: 0x0011EFA0 File Offset: 0x0011D3A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmViewOrder()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._currentPage = 0;
			this.components = null;
			base..ctor();
			this.InitializeComponent();
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0011EFD4 File Offset: 0x0011D3D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmViewOrder(Dictionary<string, object> propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._currentPage = 0;
			this.components = null;
			base..ctor();
			this.InitializeComponent();
			if (ApplicationInfo.SupportFreewill)
			{
				this.intzaSum.GetColumn("mvalue").Visible = false;
				this.intzaSum.GetColumn("unmatch").Width = 27;
				this.intzaSum.GetColumn("mvolume").Width = 27;
				this.intzaSum.Redraw();
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0011F078 File Offset: 0x0011D478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderBox.ReceiveMessage(message, realtimeStockInfo);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0011F098 File Offset: 0x0011D498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderBox.ReceiveTfexMessage(message, realtimeSeriesInfo);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0011F0B8 File Offset: 0x0011D4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrder_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderBox.IsActive = true;
			this.SetPage(0);
			base.Show();
			base.OpenedForm();
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0011F0EC File Offset: 0x0011D4EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrder_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderBox.ReloadData();
			base.IsLoadingData = false;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0011F114 File Offset: 0x0011D514
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrder_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged | this.IsHeightChanged);
				base.Show();
				this.ViewOrderBox.SelectAllOrderForCancel(false);
				this.ViewOrderBox.SetGridFocus(true);
				if (!ApplicationInfo.IsEquityAccount)
				{
					this.SetPage(0);
				}
				else
				{
					this.SetPage(this._currentPage);
				}
			}
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0011F19C File Offset: 0x0011D59C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrder_IDoFontChanged()
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

		// Token: 0x06001584 RID: 5508 RVA: 0x0011F1D4 File Offset: 0x0011D5D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrder_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ViewOrderBox.FormKeyUp(this, e);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0011F1F4 File Offset: 0x0011D5F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrder_IDoCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged | this.IsHeightChanged);
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0011F234 File Offset: 0x0011D634
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
					if (this._currentPage == 0 && ApplicationInfo.IsEquityAccount)
					{
						int heightByRows = this.intzaSum.GetHeightByRows();
						this.intzaSum.SetBounds(0, base.Height - heightByRows + 1, base.Width, heightByRows);
						this.ViewOrderBox.SetBounds(0, this.tStripTop.Top + this.tStripTop.Height, base.Width, base.Height - heightByRows - this.tStripTop.Bottom - 1);
						this.ViewOrderBox.SetResize(isChanged);
					}
					else if (this._currentPage == 1)
					{
						this.OrderStatBox.SetBounds(0, this.tStripTop.Top + this.tStripTop.Height, base.Width, base.Height - this.tStripTop.Bottom);
						this.OrderStatBox.SetResize();
					}
					else
					{
						this.ViewOrderBox.SetBounds(0, this.tStripTop.Top + this.tStripTop.Height, base.Width, base.Height - this.tStripTop.Bottom - 1);
						this.ViewOrderBox.SetResize(isChanged);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0011F3E4 File Offset: 0x0011D7E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucViewOrder_OnDisplaySummaryOrders()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaSum.BeginUpdate();
				this.intzaSum.ClearAllText();
				this.intzaSum.Records(0).Fields("sum").Text = "*** BUY ***";
				this.intzaSum.Records(0).Fields("volume").Text = this.ViewOrderBox.TotalBuyVolume;
				this.intzaSum.Records(0).Fields("mvolume").Text = this.ViewOrderBox.TotalBuyMatchedVolume;
				this.intzaSum.Records(0).Fields("mvalue").Text = this.ViewOrderBox.TotalBuyMatchedValue;
				this.intzaSum.Records(0).Fields("unmatch").Text = this.ViewOrderBox.UnMatchedBuyVol;
				this.intzaSum.Records(0).Fields("sum").FontColor = MyColor.UpColor;
				this.intzaSum.Records(0).Fields("volume").FontColor = MyColor.UpColor;
				this.intzaSum.Records(0).Fields("mvolume").FontColor = MyColor.UpColor;
				this.intzaSum.Records(0).Fields("mvalue").FontColor = MyColor.UpColor;
				this.intzaSum.Records(0).Fields("unmatch").FontColor = MyColor.UpColor;
				this.intzaSum.Records(1).Fields("sum").Text = "*** SELL ***";
				this.intzaSum.Records(1).Fields("volume").Text = this.ViewOrderBox.TotalSellVolume;
				this.intzaSum.Records(1).Fields("mvolume").Text = this.ViewOrderBox.TotalSellMatchedVolume;
				this.intzaSum.Records(1).Fields("mvalue").Text = this.ViewOrderBox.TotalSellMatchedValue;
				this.intzaSum.Records(1).Fields("unmatch").Text = this.ViewOrderBox.UnMatchedSellVol;
				this.intzaSum.Records(1).Fields("sum").FontColor = MyColor.DownColor;
				this.intzaSum.Records(1).Fields("volume").FontColor = MyColor.DownColor;
				this.intzaSum.Records(1).Fields("mvolume").FontColor = MyColor.DownColor;
				this.intzaSum.Records(1).Fields("mvalue").FontColor = MyColor.DownColor;
				this.intzaSum.Records(1).Fields("unmatch").FontColor = MyColor.DownColor;
				this.intzaSum.EndUpdate();
			}
			catch (Exception ex)
			{
				this.ShowError("ucViewOrder_OnDisplaySummaryOrders", ex);
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0011F74C File Offset: 0x0011DB4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrder_VisibleChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.DesignMode)
			{
				if (!base.Visible)
				{
					this.ViewOrderBox.CloseViewOrderInfoBox();
				}
			}
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0011F790 File Offset: 0x0011DB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrder_IDoSymbolLinked(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (source == SymbolLinkSource.SwitchAccount)
			{
				if (!ApplicationInfo.IsEquityAccount)
				{
					this.SetPage(0);
				}
				else
				{
					this.SetPage(this._currentPage);
				}
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0011F7E4 File Offset: 0x0011DBE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnViewByStock_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetPage(1);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0011F800 File Offset: 0x0011DC00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnViewTransaction_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetPage(0);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0011F81C File Offset: 0x0011DC1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPage(int currPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.SupportFreewill)
				{
					this.tsripViewOrderByStock.Visible = false;
					this.tsbtnViewByStock.Visible = false;
				}
				else
				{
					this.tsripViewOrderByStock.Visible = ApplicationInfo.IsEquityAccount;
					this.tsbtnViewByStock.Visible = ApplicationInfo.IsEquityAccount;
				}
				this.tsbtnViewTransaction.ForeColor = Color.LightGray;
				this.tsbtnViewByStock.ForeColor = Color.LightGray;
				this.ViewOrderBox.SwitchAccount();
				if (currPage == 0)
				{
					this._currentPage = 0;
					this.tsbtnViewTransaction.ForeColor = Color.Orange;
					this.ViewOrderBox.Show();
					this.OrderStatBox.Hide();
					this.SetResize(true);
					if (ApplicationInfo.IsEquityAccount)
					{
						this.intzaSum.Show();
						this.ViewOrderBox.SetView(1);
					}
					else
					{
						this.intzaSum.Hide();
						this.ViewOrderBox.SetView(3);
					}
				}
				else if (currPage == 1)
				{
					this._currentPage = 1;
					this.tsbtnViewByStock.ForeColor = Color.Orange;
					this.intzaSum.Visible = false;
					this.OrderStatBox.Show();
					this.OrderStatBox.Init();
					this.ViewOrderBox.Hide();
					this.intzaSum.Hide();
					this.SetResize(true);
					this.OrderStatBox.Reload_AccountChanged();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetPage", ex);
			}
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0011FA04 File Offset: 0x0011DE04
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

		// Token: 0x0600158E RID: 5518 RVA: 0x0011FA54 File Offset: 0x0011DE54
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
			this.ViewOrderBox = new ucViewOrder();
			this.intzaSum = new SortGrid();
			this.tStripTop = new ToolStrip();
			this.tsbtnViewTransaction = new ToolStripButton();
			this.tsripViewOrderByStock = new ToolStripSeparator();
			this.tsbtnViewByStock = new ToolStripButton();
			this.OrderStatBox = new ucOrderStat();
			this.tStripTop.SuspendLayout();
			base.SuspendLayout();
			this.ViewOrderBox.BackColor = Color.FromArgb(20, 20, 20);
			this.ViewOrderBox.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.ViewOrderBox.IsActive = false;
			this.ViewOrderBox.IsLoadingData = false;
			this.ViewOrderBox.IsShowLoadingControl = false;
			this.ViewOrderBox.IsShowNextPage = false;
			this.ViewOrderBox.IsShowToolsBar = true;
			this.ViewOrderBox.Location = new Point(0, 36);
			this.ViewOrderBox.Margin = new Padding(0);
			this.ViewOrderBox.Name = "ViewOrderBox";
			this.ViewOrderBox.ShowOnMainForm = false;
			this.ViewOrderBox.Size = new Size(783, 146);
			this.ViewOrderBox.TabIndex = 8;
			this.ViewOrderBox.OnDisplaySummaryOrders += new ucViewOrder.OnDisplaySummaryOrdersHandler(this.ucViewOrder_OnDisplaySummaryOrders);
			this.intzaSum.AllowDrop = true;
			this.intzaSum.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaSum.CanBlink = true;
			this.intzaSum.CanDrag = false;
			this.intzaSum.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "sum";
			columnItem.Text = "Summary";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 28;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "volume";
			columnItem2.Text = "Volume";
			columnItem2.ValueFormat = FormatType.Volume;
			columnItem2.Visible = true;
			columnItem2.Width = 18;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "unmatch";
			columnItem3.Text = "UnMatch Volume";
			columnItem3.ValueFormat = FormatType.Volume;
			columnItem3.Visible = true;
			columnItem3.Width = 18;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "mvolume";
			columnItem4.Text = "Matched Volume";
			columnItem4.ValueFormat = FormatType.Volume;
			columnItem4.Visible = true;
			columnItem4.Width = 18;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "mvalue";
			columnItem5.Text = "Matched Value";
			columnItem5.ValueFormat = FormatType.Price;
			columnItem5.Visible = true;
			columnItem5.Width = 18;
			this.intzaSum.Columns.Add(columnItem);
			this.intzaSum.Columns.Add(columnItem2);
			this.intzaSum.Columns.Add(columnItem3);
			this.intzaSum.Columns.Add(columnItem4);
			this.intzaSum.Columns.Add(columnItem5);
			this.intzaSum.CurrentScroll = 0;
			this.intzaSum.FocusItemIndex = -1;
			this.intzaSum.ForeColor = Color.Black;
			this.intzaSum.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaSum.HeaderPctHeight = 80f;
			this.intzaSum.IsAutoRepaint = true;
			this.intzaSum.IsDrawFullRow = false;
			this.intzaSum.IsDrawGrid = true;
			this.intzaSum.IsDrawHeader = true;
			this.intzaSum.IsScrollable = false;
			this.intzaSum.Location = new Point(0, 345);
			this.intzaSum.MainColumn = "";
			this.intzaSum.Name = "intzaSum";
			this.intzaSum.Rows = 2;
			this.intzaSum.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaSum.RowSelectType = 0;
			this.intzaSum.RowsVisible = 2;
			this.intzaSum.Size = new Size(783, 52);
			this.intzaSum.SortColumnName = "";
			this.intzaSum.SortType = SortType.Desc;
			this.intzaSum.TabIndex = 25;
			this.tStripTop.AllowMerge = false;
			this.tStripTop.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripTop.CanOverflow = false;
			this.tStripTop.GripMargin = new Padding(0);
			this.tStripTop.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripTop.Items.AddRange(new ToolStripItem[]
			{
				this.tsbtnViewTransaction,
				this.tsripViewOrderByStock,
				this.tsbtnViewByStock
			});
			this.tStripTop.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.tStripTop.Location = new Point(0, 0);
			this.tStripTop.Name = "tStripTop";
			this.tStripTop.Padding = new Padding(1, 1, 1, 2);
			this.tStripTop.RenderMode = ToolStripRenderMode.Professional;
			this.tStripTop.Size = new Size(784, 26);
			this.tStripTop.TabIndex = 58;
			this.tStripTop.Tag = "-1";
			this.tsbtnViewTransaction.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnViewTransaction.ForeColor = Color.Orange;
			this.tsbtnViewTransaction.ImageTransparentColor = Color.Magenta;
			this.tsbtnViewTransaction.Margin = new Padding(5, 1, 5, 2);
			this.tsbtnViewTransaction.Name = "tsbtnViewTransaction";
			this.tsbtnViewTransaction.Size = new Size(155, 20);
			this.tsbtnViewTransaction.Text = "View Order by Transactions";
			this.tsbtnViewTransaction.Click += new EventHandler(this.tsbtnViewTransaction_Click);
			this.tsripViewOrderByStock.Name = "tsripViewOrderByStock";
			this.tsripViewOrderByStock.Size = new Size(6, 23);
			this.tsbtnViewByStock.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnViewByStock.ForeColor = Color.LightGray;
			this.tsbtnViewByStock.ImageTransparentColor = Color.Magenta;
			this.tsbtnViewByStock.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnViewByStock.Name = "tsbtnViewByStock";
			this.tsbtnViewByStock.Size = new Size(117, 20);
			this.tsbtnViewByStock.Text = "View Order by Stock";
			this.tsbtnViewByStock.Click += new EventHandler(this.tsbtnViewByStock_Click);
			this.OrderStatBox.BackColor = Color.FromArgb(30, 30, 30);
			this.OrderStatBox.IsLoadingData = false;
			this.OrderStatBox.Location = new Point(3, 196);
			this.OrderStatBox.Margin = new Padding(3, 4, 3, 4);
			this.OrderStatBox.Name = "OrderStatBox";
			this.OrderStatBox.Size = new Size(780, 128);
			this.OrderStatBox.TabIndex = 66;
			this.OrderStatBox.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(784, 431);
			base.Controls.Add(this.OrderStatBox);
			base.Controls.Add(this.tStripTop);
			base.Controls.Add(this.intzaSum);
			base.Controls.Add(this.ViewOrderBox);
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "frmViewOrder";
			this.Text = "ViewOrder";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmViewOrder_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmViewOrder_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmViewOrder_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmViewOrder_IDoCustomSizeChanged);
			base.IDoSymbolLinked += new ClientBaseForm.OnSymbolLinkEventHandler(this.frmViewOrder_IDoSymbolLinked);
			base.VisibleChanged += new EventHandler(this.frmViewOrder_VisibleChanged);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmViewOrder_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmViewOrder_IDoReActivated);
			base.Controls.SetChildIndex(this.ViewOrderBox, 0);
			base.Controls.SetChildIndex(this.intzaSum, 0);
			base.Controls.SetChildIndex(this.tStripTop, 0);
			base.Controls.SetChildIndex(this.OrderStatBox, 0);
			this.tStripTop.ResumeLayout(false);
			this.tStripTop.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000B36 RID: 2870
		private int _currentPage;

		// Token: 0x04000B37 RID: 2871
		private IContainer components;

		// Token: 0x04000B38 RID: 2872
		private ucViewOrder ViewOrderBox;

		// Token: 0x04000B39 RID: 2873
		private SortGrid intzaSum;

		// Token: 0x04000B3A RID: 2874
		private ToolStrip tStripTop;

		// Token: 0x04000B3B RID: 2875
		private ToolStripButton tsbtnViewByStock;

		// Token: 0x04000B3C RID: 2876
		private ToolStripButton tsbtnViewTransaction;

		// Token: 0x04000B3D RID: 2877
		private ToolStripSeparator tsripViewOrderByStock;

		// Token: 0x04000B3E RID: 2878
		private ucOrderStat OrderStatBox;
	}
}
