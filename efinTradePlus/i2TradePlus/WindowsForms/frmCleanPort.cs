using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus.WindowsForms
{
	// Token: 0x020000B9 RID: 185
	public class frmCleanPort : Form
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x000A8484 File Offset: 0x000A6884
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

		// Token: 0x0600088E RID: 2190 RVA: 0x000A84D4 File Offset: 0x000A68D4
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
			this.toolStrip1 = new ToolStrip();
			this.tsbtnReload = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.tsbtnSellAll = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.tsbtnSell = new ToolStripButton();
			this.tsbtnClose = new ToolStripButton();
			this.intza = new SortGrid();
			this.toolStrip1.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.tsbtnReload,
				this.toolStripSeparator2,
				this.tsbtnSellAll,
				this.toolStripSeparator1,
				this.tsbtnSell,
				this.tsbtnClose
			});
			this.toolStrip1.Location = new Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new Size(644, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			this.tsbtnReload.ForeColor = Color.Black;
			this.tsbtnReload.Image = Resources.refresh;
			this.tsbtnReload.ImageTransparentColor = Color.Magenta;
			this.tsbtnReload.Name = "tsbtnReload";
			this.tsbtnReload.Padding = new Padding(10, 0, 5, 0);
			this.tsbtnReload.Size = new Size(78, 22);
			this.tsbtnReload.Text = "Reload";
			this.tsbtnReload.Click += new EventHandler(this.tsbtnReload_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 25);
			this.tsbtnSellAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSellAll.ForeColor = Color.Black;
			this.tsbtnSellAll.ImageTransparentColor = Color.Magenta;
			this.tsbtnSellAll.Name = "tsbtnSellAll";
			this.tsbtnSellAll.Padding = new Padding(5, 0, 5, 0);
			this.tsbtnSellAll.Size = new Size(54, 22);
			this.tsbtnSellAll.Text = "Sell all";
			this.tsbtnSellAll.Click += new EventHandler(this.tsbtnSellAll_Click);
			this.toolStripSeparator1.ForeColor = Color.Black;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 25);
			this.tsbtnSell.ForeColor = Color.Black;
			this.tsbtnSell.ImageTransparentColor = Color.Magenta;
			this.tsbtnSell.Name = "tsbtnSell";
			this.tsbtnSell.Padding = new Padding(0, 0, 5, 0);
			this.tsbtnSell.Size = new Size(34, 22);
			this.tsbtnSell.Text = "Sell";
			this.tsbtnSell.Click += new EventHandler(this.tsbtnSell_Click);
			this.tsbtnClose.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnClose.ForeColor = Color.Black;
			this.tsbtnClose.Image = Resources.fileclose;
			this.tsbtnClose.ImageTransparentColor = Color.Magenta;
			this.tsbtnClose.Name = "tsbtnClose";
			this.tsbtnClose.Size = new Size(56, 22);
			this.tsbtnClose.Text = "Close";
			this.tsbtnClose.Click += new EventHandler(this.tsbtnClose_Click);
			this.intza.AllowDrop = true;
			this.intza.BackColor = Color.LightGray;
			this.intza.CanBlink = false;
			this.intza.CanDrag = false;
			this.intza.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "stock";
			columnItem.Text = "Symbol";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 13;
			columnItem2.Alignment = StringAlignment.Center;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "sType";
			columnItem2.Text = "Type";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 8;
			columnItem3.Alignment = StringAlignment.Center;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "trusteeId";
			columnItem3.Text = "TTF";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 8;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "onhand";
			columnItem4.Text = "OnHand";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 15;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "sellable";
			columnItem5.Text = "Sellable";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 15;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "avgPrice";
			columnItem6.Text = "Average";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 12;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "last";
			columnItem7.Text = "Last";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 12;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "ul";
			columnItem8.Text = "UnReal P/L";
			columnItem8.ValueFormat = FormatType.Text;
			columnItem8.Visible = true;
			columnItem8.Width = 17;
			this.intza.Columns.Add(columnItem);
			this.intza.Columns.Add(columnItem2);
			this.intza.Columns.Add(columnItem3);
			this.intza.Columns.Add(columnItem4);
			this.intza.Columns.Add(columnItem5);
			this.intza.Columns.Add(columnItem6);
			this.intza.Columns.Add(columnItem7);
			this.intza.Columns.Add(columnItem8);
			this.intza.CurrentScroll = 0;
			this.intza.Dock = DockStyle.Fill;
			this.intza.FocusItemIndex = -1;
			this.intza.ForeColor = Color.Black;
			this.intza.GridColor = Color.DarkGray;
			this.intza.HeaderPctHeight = 100f;
			this.intza.IsAutoRepaint = true;
			this.intza.IsDrawFullRow = false;
			this.intza.IsDrawGrid = true;
			this.intza.IsDrawHeader = true;
			this.intza.IsScrollable = true;
			this.intza.Location = new Point(0, 25);
			this.intza.MainColumn = "";
			this.intza.Name = "intza";
			this.intza.Rows = 0;
			this.intza.RowSelectColor = Color.DarkGray;
			this.intza.RowSelectType = 3;
			this.intza.RowsVisible = 0;
			this.intza.Size = new Size(644, 223);
			this.intza.SortColumnName = "";
			this.intza.SortType = SortType.Desc;
			this.intza.TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(644, 248);
			base.ControlBox = false;
			base.Controls.Add(this.intza);
			base.Controls.Add(this.toolStrip1);
			this.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.MaximizeBox = false;
			base.Name = "frmCleanPort";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Portfolio Clearing Process";
			base.Shown += new EventHandler(this.frmCleanPort_Shown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000A8F50 File Offset: 0x000A7350
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmCleanPort()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwLoadReport = null;
			this.tdsR2 = null;
			this._frmConfirm = null;
			this._isAll = false;
			base..ctor();
			try
			{
				this.InitializeComponent();
				this.bgwLoadReport = new BackgroundWorker();
				this.bgwLoadReport.WorkerReportsProgress = true;
				this.bgwLoadReport.DoWork += new DoWorkEventHandler(this.bgwLoadReport_DoWork);
				this.bgwLoadReport.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwLoadReport_RunWorkerCompleted);
				this.intza.Font = Settings.Default.Default_Font;
			}
			catch (Exception ex)
			{
				this.ShowError("frmCleanPort", ex);
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000A9030 File Offset: 0x000A7430
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoadReport_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = ApplicationInfo.WebOrderService.ViewCustomer_ProjectedProfitLoss(ApplicationInfo.AccInfo.CurrentAccount, "", 0, 100);
				if (!string.IsNullOrEmpty(text))
				{
					if (this.tdsR2 == null)
					{
						this.tdsR2 = new DataSet();
					}
					else
					{
						this.tdsR2.Clear();
					}
					MyDataHelper.StringToDataSet(text, this.tdsR2);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoadReport_DoWork", ex);
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000A90E4 File Offset: 0x000A74E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoadReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intza.BeginUpdate();
				this.intza.Rows = 0;
				bool flag = this.tdsR2.Tables[0].Columns.Contains("costCommVat");
				foreach (DataRow dataRow in this.tdsR2.Tables[0].Rows)
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
					long.TryParse(dataRow["onhand"].ToString(), out num);
					long.TryParse(dataRow["sellable"].ToString(), out num2);
					decimal.TryParse(dataRow["average"].ToString(), out num3);
					decimal.TryParse(dataRow["last_price"].ToString(), out num5);
					decimal.TryParse(dataRow["Cost"].ToString(), out num4);
					decimal.TryParse(dataRow["Curr_val"].ToString(), out num6);
					if (flag)
					{
						decimal.TryParse(dataRow["costCommVat"].ToString(), out d);
						decimal.TryParse(dataRow["currValCommVat"].ToString(), out d2);
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
						else if (dataRow["position_type"].ToString() == "S")
						{
							num7 = Math.Round(num4 - num6 - (d + d2), 0, MidpointRounding.AwayFromZero);
						}
						else
						{
							num7 = Math.Round(num6 - num4 - (d + d2), 0, MidpointRounding.AwayFromZero);
						}
					}
					else
					{
						decimal.TryParse(dataRow["Unrl_pl"].ToString(), out num7);
					}
					Color fontColor = Color.Black;
					if (num7 > 0m)
					{
						fontColor = Color.Green;
					}
					else if (num7 < 0m)
					{
						fontColor = Color.Red;
					}
					RecordItem recordItem = this.intza.AddRecord(-1, false);
					recordItem.Fields("stock").Text = dataRow["stock"].ToString().Trim();
					recordItem.Fields("sType").Text = dataRow["position_type"].ToString().Trim();
					recordItem.Fields("trusteeId").Text = ((dataRow["trustee_id"].ToString() == "0") ? string.Empty : dataRow["trustee_id"].ToString());
					recordItem.Fields("onhand").Text = Utilities.VolumeFormat(num, true);
					recordItem.Fields("sellable").Text = Utilities.VolumeFormat(num2, true);
					if (dataRow["position_type"].ToString() != "B")
					{
						recordItem.Fields("avgPrice").Text = Utilities.PriceFormat(num3, 4);
						recordItem.Fields("last").Text = Utilities.PriceFormat(num5, 2);
						recordItem.Fields("ul").Text = Utilities.VolumeFormat(num7, true);
					}
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("sType").FontColor = fontColor;
					recordItem.Fields("trusteeId").FontColor = fontColor;
					recordItem.Fields("onhand").FontColor = fontColor;
					recordItem.Fields("sellable").FontColor = fontColor;
					recordItem.Fields("avgPrice").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					recordItem.Fields("ul").FontColor = fontColor;
				}
				this.tdsR2.Clear();
				this.intza.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoadReport_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000A967C File Offset: 0x000A7A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000A96B0 File Offset: 0x000A7AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmCleanPort_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.bgwLoadReport.RunWorkerAsync();
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000A96D8 File Offset: 0x000A7AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000A96F0 File Offset: 0x000A7AF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnReload_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwLoadReport.IsBusy)
			{
				this.bgwLoadReport.RunWorkerAsync();
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000A972C File Offset: 0x000A7B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSell_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.intza.FocusItemIndex > -1)
				{
					this.LoopSend(false);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnSell_Click", ex);
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000A9798 File Offset: 0x000A7B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSellAll_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.LoopSend(true);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000A97B4 File Offset: 0x000A7BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoopSend(bool isAll)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._isAll = isAll;
				this.ShowMessageInFormConfirm("Confirm to send ?", frmOrderFormConfirm.OpenStyle.ConfirmSendNew, 0);
			}
			catch (Exception ex)
			{
				this.ShowError("LoopSend", ex);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000A9814 File Offset: 0x000A7C14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoopThreadSend()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				int num = 0;
				int num2 = this.intza.Rows;
				if (!this._isAll)
				{
					num = this.intza.FocusItemIndex;
					num2 = num + 1;
				}
				int num3 = 0;
				int num4 = 0;
				for (int i = num; i < num2; i++)
				{
					RecordItem recordItem = this.intza.Records(i);
					string symbol = recordItem.Fields("stock").Text.ToString();
					long num5 = 0L;
					long.TryParse(recordItem.Fields("onhand").Text.ToString().Replace(",", ""), out num5);
					int ttf = 0;
					int.TryParse(recordItem.Fields("trusteeId").Text.ToString(), out ttf);
					string a = recordItem.Fields("sType").Text.ToString().Trim();
					if (num5 > 0L)
					{
						num3++;
						string side = "S";
						if (a == "B")
						{
							side = "H";
						}
						string price = "MP";
						if (ApplicationInfo.MarketState == "M")
						{
							price = "ATC";
						}
						else if (ApplicationInfo.MarketState == "P")
						{
							price = "ATO";
						}
						ApplicationInfo.SendNewOrderResult sendNewOrderResult = ApplicationInfo.SendNewOrder(symbol, side, num5, price, num5, "", ttf, "", false);
						if (sendNewOrderResult.OrderNo > 0L)
						{
							ApplicationInfo.AddOrderNoToAutoRefreshList(sendNewOrderResult.OrderNo.ToString(), sendNewOrderResult.IsFwOfflineOrder ? 3 : 1);
							num4++;
						}
					}
				}
				if (num3 > 1)
				{
					this.ShowMessageInFormConfirm(string.Concat(new object[]
					{
						"All orders are ",
						num3,
						" ,  ",
						num3 - num4,
						" order failed."
					}), frmOrderFormConfirm.OpenStyle.ShowBox, 0);
				}
				else
				{
					this.ShowMessageInFormConfirm((num4 == 0) ? "Failed." : "Complete.", frmOrderFormConfirm.OpenStyle.ShowBox, 0);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoopSend", ex);
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000A9ABC File Offset: 0x000A7EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle, int verifyCode)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmCleanPort.ShowMessageInFormConfirmCallBack(this.ShowMessageInFormConfirm), new object[]
				{
					message,
					openStyle,
					verifyCode
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
					this._frmConfirm = new frmOrderFormConfirm(message, openStyle);
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.Parent = base.Parent;
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

		// Token: 0x0600089B RID: 2203 RVA: 0x000A9C60 File Offset: 0x000A8060
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.Focus();
				frmOrderFormConfirm.OpenStyle openFormStyle = ((frmOrderFormConfirm)sender).OpenFormStyle;
				if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmSendNew)
				{
					DialogResult result = ((frmOrderFormConfirm)sender).Result;
					if (result == DialogResult.OK)
					{
						new Thread(new ThreadStart(this.LoopThreadSend))
						{
							IsBackground = true
						}.Start();
					}
				}
				else if (openFormStyle == frmOrderFormConfirm.OpenStyle.ShowBox)
				{
					if (!this.bgwLoadReport.IsBusy)
					{
						this.bgwLoadReport.RunWorkerAsync();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x04000571 RID: 1393
		private IContainer components;

		// Token: 0x04000572 RID: 1394
		private ToolStrip toolStrip1;

		// Token: 0x04000573 RID: 1395
		private ToolStripButton tsbtnSell;

		// Token: 0x04000574 RID: 1396
		private ToolStripButton tsbtnSellAll;

		// Token: 0x04000575 RID: 1397
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000576 RID: 1398
		private ToolStripButton tsbtnClose;

		// Token: 0x04000577 RID: 1399
		private ToolStripButton tsbtnReload;

		// Token: 0x04000578 RID: 1400
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000579 RID: 1401
		private SortGrid intza;

		// Token: 0x0400057A RID: 1402
		private BackgroundWorker bgwLoadReport;

		// Token: 0x0400057B RID: 1403
		private DataSet tdsR2;

		// Token: 0x0400057C RID: 1404
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x0400057D RID: 1405
		private bool _isAll;

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x0600089D RID: 2205
		private delegate void ShowMessageInFormConfirmCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle, int verifyCode);
	}
}
