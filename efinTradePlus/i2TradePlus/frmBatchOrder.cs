using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using CSVReaderTest;
using i2TradePlus.Information;
using i2TradePlus.MyDataSet;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x02000016 RID: 22
	public class frmBatchOrder : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00009C9C File Offset: 0x0000809C
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

		// Token: 0x0600009D RID: 157 RVA: 0x00009CEC File Offset: 0x000080EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmBatchOrder));
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
			this.toolStrip1 = new ToolStrip();
			this.tsbtnClearAll = new ToolStripButton();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.tsbtnClear = new ToolStripButton();
			this.tsImportCSV = new ToolStripButton();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.tsExportCSV = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.tsSendSelected = new ToolStripButton();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.tsbtnSendAllOrder = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.tsbtnValidateOrder = new ToolStripButton();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.tsbtnStopSending = new ToolStripButton();
			this.cbText = new ComboBox();
			this.orderQueueDS1 = new OrderQueueDS();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel2 = new ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new ToolStripStatusLabel();
			this.tslbTotAmount = new ToolStripStatusLabel();
			this.sortGrid1 = new SortGrid();
			this.toolStrip1.SuspendLayout();
			((ISupportInitialize)this.orderQueueDS1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip1.BackColor = Color.FromArgb(30, 30, 30);
			this.toolStrip1.GripMargin = new Padding(0);
			this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.tsbtnClearAll,
				this.toolStripSeparator4,
				this.tsbtnClear,
				this.tsImportCSV,
				this.toolStripSeparator6,
				this.tsExportCSV,
				this.toolStripSeparator1,
				this.tsSendSelected,
				this.toolStripSeparator3,
				this.tsbtnSendAllOrder,
				this.toolStripSeparator2,
				this.tsbtnValidateOrder,
				this.toolStripSeparator5,
				this.tsbtnStopSending
			});
			this.toolStrip1.Location = new Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new Padding(1, 1, 1, 2);
			this.toolStrip1.RenderMode = ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new Size(685, 26);
			this.toolStrip1.TabIndex = 8;
			this.tsbtnClearAll.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnClearAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnClearAll.ForeColor = Color.WhiteSmoke;
			this.tsbtnClearAll.ImageTransparentColor = Color.Magenta;
			this.tsbtnClearAll.Name = "tsbtnClearAll";
			this.tsbtnClearAll.Size = new Size(55, 20);
			this.tsbtnClearAll.Text = "Clear All";
			this.tsbtnClearAll.Click += new EventHandler(this.tsbtnRemoveAll_Click);
			this.toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(6, 23);
			this.tsbtnClear.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnClear.ForeColor = Color.WhiteSmoke;
			this.tsbtnClear.ImageTransparentColor = Color.Magenta;
			this.tsbtnClear.Name = "tsbtnClear";
			this.tsbtnClear.Size = new Size(38, 20);
			this.tsbtnClear.Text = "Clear";
			this.tsbtnClear.ToolTipText = "Clear [Ctrl+Insert]";
			this.tsbtnClear.Click += new EventHandler(this.tsbtnRemove_Click);
			this.tsImportCSV.ForeColor = Color.WhiteSmoke;
			this.tsImportCSV.Image = (Image)componentResourceManager.GetObject("tsImportCSV.Image");
			this.tsImportCSV.ImageTransparentColor = Color.Magenta;
			this.tsImportCSV.Margin = new Padding(5, 1, 0, 2);
			this.tsImportCSV.Name = "tsImportCSV";
			this.tsImportCSV.Size = new Size(96, 20);
			this.tsImportCSV.Text = "Import Order";
			this.tsImportCSV.Click += new EventHandler(this.tsImportCSV_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new Size(6, 23);
			this.tsExportCSV.ForeColor = Color.WhiteSmoke;
			this.tsExportCSV.Image = (Image)componentResourceManager.GetObject("tsExportCSV.Image");
			this.tsExportCSV.ImageTransparentColor = Color.Magenta;
			this.tsExportCSV.Margin = new Padding(2, 1, 0, 2);
			this.tsExportCSV.Name = "tsExportCSV";
			this.tsExportCSV.Size = new Size(93, 20);
			this.tsExportCSV.Text = "Export Order";
			this.tsExportCSV.Click += new EventHandler(this.tsExportCSV_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 23);
			this.tsSendSelected.ForeColor = Color.WhiteSmoke;
			this.tsSendSelected.ImageTransparentColor = Color.Magenta;
			this.tsSendSelected.Margin = new Padding(20, 1, 0, 2);
			this.tsSendSelected.Name = "tsSendSelected";
			this.tsSendSelected.Size = new Size(84, 20);
			this.tsSendSelected.Text = "Send Selected";
			this.tsSendSelected.Click += new EventHandler(this.tsSendSelected_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(6, 23);
			this.tsbtnSendAllOrder.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSendAllOrder.ForeColor = Color.WhiteSmoke;
			this.tsbtnSendAllOrder.ImageTransparentColor = Color.Magenta;
			this.tsbtnSendAllOrder.Margin = new Padding(2, 1, 0, 2);
			this.tsbtnSendAllOrder.Name = "tsbtnSendAllOrder";
			this.tsbtnSendAllOrder.Size = new Size(54, 20);
			this.tsbtnSendAllOrder.Text = "Send All";
			this.tsbtnSendAllOrder.Click += new EventHandler(this.tsbtnSendAllOrder_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 23);
			this.tsbtnValidateOrder.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnValidateOrder.ForeColor = Color.WhiteSmoke;
			this.tsbtnValidateOrder.Image = (Image)componentResourceManager.GetObject("tsbtnValidateOrder.Image");
			this.tsbtnValidateOrder.ImageTransparentColor = Color.Magenta;
			this.tsbtnValidateOrder.Margin = new Padding(2, 1, 0, 2);
			this.tsbtnValidateOrder.Name = "tsbtnValidateOrder";
			this.tsbtnValidateOrder.Size = new Size(86, 20);
			this.tsbtnValidateOrder.Text = "Validate Order";
			this.tsbtnValidateOrder.Click += new EventHandler(this.tsbtnValidateOrder_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size(6, 23);
			this.tsbtnStopSending.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnStopSending.ForeColor = Color.WhiteSmoke;
			this.tsbtnStopSending.Image = (Image)componentResourceManager.GetObject("tsbtnStopSending.Image");
			this.tsbtnStopSending.ImageTransparentColor = Color.Magenta;
			this.tsbtnStopSending.Name = "tsbtnStopSending";
			this.tsbtnStopSending.Size = new Size(35, 20);
			this.tsbtnStopSending.Text = "Stop";
			this.tsbtnStopSending.Click += new EventHandler(this.tsbtnStopSending_Click);
			this.cbText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cbText.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbText.FlatStyle = FlatStyle.Flat;
			this.cbText.FormattingEnabled = true;
			this.cbText.Location = new Point(581, 373);
			this.cbText.Margin = new Padding(0);
			this.cbText.MaxDropDownItems = 10;
			this.cbText.MaxLength = 20;
			this.cbText.Name = "cbText";
			this.cbText.Size = new Size(95, 21);
			this.cbText.TabIndex = 11;
			this.cbText.Visible = false;
			this.cbText.Leave += new EventHandler(this.cbText_Leave);
			this.cbText.KeyPress += new KeyPressEventHandler(this.cbText_KeyPress);
			this.cbText.KeyUp += new KeyEventHandler(this.cbText_KeyUp);
			this.cbText.KeyDown += new KeyEventHandler(this.cbStock_KeyDown);
			this.cbText.TextChanged += new EventHandler(this.cbText_TextChanged);
			this.orderQueueDS1.DataSetName = "OrderQueueDS";
			this.orderQueueDS1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.statusStrip1.BackColor = Color.FromArgb(30, 30, 30);
			this.statusStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripStatusLabel2,
				this.toolStripStatusLabel1,
				this.toolStripStatusLabel4,
				this.toolStripStatusLabel3,
				this.tslbTotAmount
			});
			this.statusStrip1.Location = new Point(0, 414);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(685, 22);
			this.statusStrip1.TabIndex = 12;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel2.BackColor = Color.Transparent;
			this.toolStripStatusLabel2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel2.ForeColor = Color.Violet;
			this.toolStripStatusLabel2.LinkColor = Color.Blue;
			this.toolStripStatusLabel2.Margin = new Padding(5, 3, 0, 2);
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new Size(115, 17);
			this.toolStripStatusLabel2.Text = "[ Home ] Select Item";
			this.toolStripStatusLabel2.Visible = false;
			this.toolStripStatusLabel1.BackColor = Color.Transparent;
			this.toolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.ForeColor = SystemColors.ActiveCaption;
			this.toolStripStatusLabel1.LinkColor = Color.Blue;
			this.toolStripStatusLabel1.Margin = new Padding(5, 3, 0, 2);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(177, 17);
			this.toolStripStatusLabel1.Text = "[ Space/Double Click ]  Edit Item";
			this.toolStripStatusLabel4.BackColor = Color.Transparent;
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new Size(388, 17);
			this.toolStripStatusLabel4.Spring = true;
			this.toolStripStatusLabel3.BackColor = Color.Transparent;
			this.toolStripStatusLabel3.ForeColor = Color.Gainsboro;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new Size(87, 17);
			this.toolStripStatusLabel3.Text = "Total Amount :";
			this.tslbTotAmount.ForeColor = Color.Yellow;
			this.tslbTotAmount.Name = "tslbTotAmount";
			this.tslbTotAmount.Size = new Size(13, 17);
			this.tslbTotAmount.Text = "0";
			this.sortGrid1.AllowDrop = true;
			this.sortGrid1.BackColor = Color.FromArgb(30, 30, 30);
			this.sortGrid1.CanBlink = false;
			this.sortGrid1.CanDrag = false;
			this.sortGrid1.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "#";
			columnItem.ValueFormat = FormatType.RecordNumber;
			columnItem.Visible = true;
			columnItem.Width = 4;
			columnItem2.Alignment = StringAlignment.Center;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "checkbox";
			columnItem2.Text = "";
			columnItem2.ValueFormat = FormatType.CheckBox;
			columnItem2.Visible = true;
			columnItem2.Width = 3;
			columnItem3.Alignment = StringAlignment.Center;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "side";
			columnItem3.Text = "B/S";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 5;
			columnItem4.Alignment = StringAlignment.Near;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "stock";
			columnItem4.Text = "Stock";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 13;
			columnItem5.Alignment = StringAlignment.Center;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "ttf";
			columnItem5.Text = "TTF";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 5;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "volume";
			columnItem6.Text = "Volume";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 10;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "price";
			columnItem7.Text = "Price";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 9;
			columnItem8.Alignment = StringAlignment.Center;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "condition";
			columnItem8.Text = "Cond";
			columnItem8.ValueFormat = FormatType.Text;
			columnItem8.Visible = true;
			columnItem8.Width = 6;
			columnItem9.Alignment = StringAlignment.Far;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "pubvol";
			columnItem9.Text = "P/B Vol";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = true;
			columnItem9.Width = 10;
			columnItem10.Alignment = StringAlignment.Center;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.LightGray;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "deposit";
			columnItem10.Text = "Dep";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = true;
			columnItem10.Width = 4;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "amount";
			columnItem11.Text = "Amount";
			columnItem11.ValueFormat = FormatType.Price;
			columnItem11.Visible = true;
			columnItem11.Width = 12;
			columnItem12.Alignment = StringAlignment.Near;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "processstatus";
			columnItem12.Text = "Status";
			columnItem12.ValueFormat = FormatType.Text;
			columnItem12.Visible = true;
			columnItem12.Width = 19;
			this.sortGrid1.Columns.Add(columnItem);
			this.sortGrid1.Columns.Add(columnItem2);
			this.sortGrid1.Columns.Add(columnItem3);
			this.sortGrid1.Columns.Add(columnItem4);
			this.sortGrid1.Columns.Add(columnItem5);
			this.sortGrid1.Columns.Add(columnItem6);
			this.sortGrid1.Columns.Add(columnItem7);
			this.sortGrid1.Columns.Add(columnItem8);
			this.sortGrid1.Columns.Add(columnItem9);
			this.sortGrid1.Columns.Add(columnItem10);
			this.sortGrid1.Columns.Add(columnItem11);
			this.sortGrid1.Columns.Add(columnItem12);
			this.sortGrid1.CurrentScroll = 0;
			this.sortGrid1.Dock = DockStyle.Fill;
			this.sortGrid1.FocusItemIndex = -1;
			this.sortGrid1.ForeColor = Color.Black;
			this.sortGrid1.GridColor = Color.FromArgb(45, 45, 45);
			this.sortGrid1.HeaderPctHeight = 80f;
			this.sortGrid1.IsAutoRepaint = true;
			this.sortGrid1.IsDrawFullRow = false;
			this.sortGrid1.IsDrawGrid = true;
			this.sortGrid1.IsDrawHeader = true;
			this.sortGrid1.IsScrollable = true;
			this.sortGrid1.Location = new Point(0, 26);
			this.sortGrid1.MainColumn = "";
			this.sortGrid1.Name = "sortGrid1";
			this.sortGrid1.Rows = 0;
			this.sortGrid1.RowSelectColor = Color.Navy;
			this.sortGrid1.RowSelectType = 3;
			this.sortGrid1.RowsVisible = 0;
			this.sortGrid1.Size = new Size(685, 388);
			this.sortGrid1.SortColumnName = "";
			this.sortGrid1.SortType = SortType.Desc;
			this.sortGrid1.TabIndex = 17;
			this.sortGrid1.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.sortGrid1_TableMouseClick);
			this.sortGrid1.TableMouseDoubleClick += new SortGrid.TableMouseDoubleClickEventHandler(this.sortGrid1_TableMouseDoubleClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(685, 436);
			base.Controls.Add(this.sortGrid1);
			base.Controls.Add(this.cbText);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.toolStrip1);
			base.KeyPreview = true;
			base.Name = "frmBatchOrder";
			this.Text = "Smart Order Queue";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmSmartOrder_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmSmartOrder_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmSmartOrder_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmSmartOrder_IDoCustomSizeChanged);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmSmartOrder_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmSmartOrder_IDoReActivated);
			base.Controls.SetChildIndex(this.toolStrip1, 0);
			base.Controls.SetChildIndex(this.statusStrip1, 0);
			base.Controls.SetChildIndex(this.cbText, 0);
			base.Controls.SetChildIndex(this.sortGrid1, 0);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((ISupportInitialize)this.orderQueueDS1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000B364 File Offset: 0x00009764
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmBatchOrder(Dictionary<string, object> propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._frmConfirm = null;
			this._isEditing = false;
			this._stockInfo = null;
			this._TotAmount = 0m;
			this._dtOrderQueue = null;
			this._stockSymbol = string.Empty;
			this._side = string.Empty;
			this._volume = 0L;
			this._price = string.Empty;
			this._publishVol = 0L;
			this._condition = string.Empty;
			this._ttf = 0;
			this._deposit = string.Empty;
			this._sendSuccessCount = 0;
			this._sendCount = 0;
			this._isSelectAll = false;
			this._currOrdNoPending = 0L;
			this._currSeqLineNo = 0;
			this._lstOrder = null;
			this._isSending = false;
			base..ctor(propertiesValue);
			this.InitializeComponent();
			this.sortGrid1.Rows = 100;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000B454 File Offset: 0x00009854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				try
				{
					if (ApplicationInfo.SupportFreewill)
					{
						string messageType = message.MessageType;
						if (messageType != null)
						{
							if (messageType == "0I")
							{
								OrderInfoClient orderInfoClient = (OrderInfoClient)message;
								if (this._isSending && (orderInfoClient.RefId == "R" + this._currOrdNoPending || orderInfoClient.RefId == "OFFLINE"))
								{
									if (this._lstOrder.Count > 0)
									{
										this._currSeqLineNo = this._lstOrder[0];
										this._lstOrder.Remove(this._currSeqLineNo);
										Thread thread = new Thread(new ThreadStart(this.SendFreewillOrder));
										thread.Start();
									}
									else
									{
										this._isSending = false;
									}
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

		// Token: 0x060000A0 RID: 160 RVA: 0x0000B5BC File Offset: 0x000099BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B5D0 File Offset: 0x000099D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSmartOrder_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetResize(true);
			base.Show();
			base.OpenedForm();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B5F8 File Offset: 0x000099F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSmartOrder_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = ApplicationInfo.GetTemplatePathByUser() + "\\OrderQueue.xml";
			try
			{
				if (File.Exists(text))
				{
					this.sortGrid1.ClearAllText();
					this.orderQueueDS1.ReadXml(text);
					int num = 0;
					if (this.sortGrid1.Rows < this.orderQueueDS1.OrderRecord.Rows.Count)
					{
						this.sortGrid1.Rows = this.orderQueueDS1.OrderRecord.Rows.Count;
					}
					foreach (OrderQueueDS.OrderRecordRow orderRecordRow in this.orderQueueDS1.OrderRecord)
					{
						if (num >= this.sortGrid1.Rows)
						{
							break;
						}
						RecordItem recordItem = this.sortGrid1.Records(num);
						recordItem.Fields("side").Text = orderRecordRow.side;
						recordItem.Fields("stock").Text = orderRecordRow.stock;
						recordItem.Fields("ttf").Text = orderRecordRow.ttf;
						recordItem.Fields("volume").Text = orderRecordRow.volume;
						recordItem.Fields("price").Text = orderRecordRow.price;
						recordItem.Fields("pubvol").Text = orderRecordRow.pubvol;
						recordItem.Fields("condition").Text = orderRecordRow.condition;
						recordItem.Fields("deposit").Text = orderRecordRow.deposit;
						recordItem.Changed = true;
						num++;
					}
					this.sortGrid1.Redraw();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmSmartOrder_IDoLoadData:ReadXml", ex);
			}
			this.sortGrid1.Focus();
			try
			{
				if (this.sortGrid1.Rows > 0)
				{
					this.sortGrid1.SetFocusItem(0);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmSmartOrder_IDoLoadData", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000B8C8 File Offset: 0x00009CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSmartOrder_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Space)
			{
				if (keyCode == Keys.Home)
				{
					this.sortGrid1.Focus();
				}
			}
			else
			{
				if (this.cbText.Tag == null)
				{
					this.cbText.Tag = "side";
				}
				if (this.sortGrid1.FocusItemIndex > -1)
				{
					if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("side").Text.ToString().Trim() == string.Empty)
					{
						this.cbText.Tag = "side";
					}
					this.SetTextPosition(this.sortGrid1.FocusItemIndex, this.cbText.Tag.ToString());
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B9D4 File Offset: 0x00009DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSmartOrder_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!base.IsLoadingData)
				{
					this.SetResize(this.IsWidthChanged | this.IsHeightChanged);
					base.Show();
					this.sortGrid1.Focus();
					if (this.sortGrid1.Rows > 0)
					{
						this.sortGrid1.SetFocusItem(0);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmSmartOrder_IDoReActivated", ex);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000BA78 File Offset: 0x00009E78
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
					this.cbText.Font = new Font(Settings.Default.Default_Font.Name, Settings.Default.Default_Font.Size - 1f, FontStyle.Regular);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000BB04 File Offset: 0x00009F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTextPosition(int rowIndex, string columnName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._isEditing = true;
				Rectangle position = this.sortGrid1.GetPosition(rowIndex, columnName);
				this.cbText.Items.Clear();
				this.sortGrid1.SetFocusItem(rowIndex);
				this.cbText.Tag = columnName;
				this.cbText.SetBounds(position.X + this.sortGrid1.Left, position.Y + this.sortGrid1.Top + 1, position.Width, position.Height);
				this.cbText.Enabled = true;
				this.cbText.DropDownStyle = ComboBoxStyle.DropDown;
				if (columnName != null)
				{
					if (!(columnName == "side"))
					{
						if (!(columnName == "stock"))
						{
							if (!(columnName == "price"))
							{
								if (!(columnName == "ttf"))
								{
									if (!(columnName == "condition"))
									{
										if (columnName == "deposit")
										{
											if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
											{
												this.cbText.DropDownStyle = ComboBoxStyle.DropDownList;
												this.cbText.Items.Add("");
												this.cbText.Items.Add("D");
												if (ApplicationInfo.SupportCollateral == "Y")
												{
													this.cbText.Items.Add("C");
												}
											}
											else
											{
												this.cbText.Enabled = false;
												this.SetTextPosition(this.sortGrid1.FocusItemIndex, "condition");
											}
										}
									}
									else
									{
										this.cbText.Items.Add("");
										this.cbText.Items.Add("IOC");
										this.cbText.Items.Add("FOK");
									}
								}
								else
								{
									this.cbText.Items.Add("");
									this.cbText.Items.Add("1");
									this.cbText.Items.Add("2");
								}
							}
							else
							{
								this.cbText.Items.Add("ATO");
								this.cbText.Items.Add("ATC");
								this.cbText.Items.Add("MP");
								this.cbText.Items.Add("MO");
								this.cbText.Items.Add("ML");
							}
						}
						else
						{
							this.cbText.Items.AddRange(ApplicationInfo.StockAutoCompStringArr);
						}
					}
					else
					{
						this.cbText.Items.Add("B");
						this.cbText.Items.Add("S");
						if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
						{
							this.cbText.Items.Add("C");
							this.cbText.Items.Add("H");
						}
					}
				}
				this.cbText.BringToFront();
				this.cbText.Show();
				this.cbText.Text = this.sortGrid1.Records(rowIndex).Fields(columnName).Text.ToString();
				this.cbText.Focus();
				this.cbText.SelectAll();
				this._isEditing = false;
			}
			catch (Exception ex)
			{
				this._isEditing = false;
				this.ShowError("SetTextPosition", ex);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000BF50 File Offset: 0x0000A350
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnValidateOrder_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.checkOrderValidateAll();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000BF68 File Offset: 0x0000A368
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnRemove_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.ClearByRow();
				this.calAmountPerRow();
			}
			catch (Exception ex)
			{
				this.ShowError("SetTextPosition", ex);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000BFC0 File Offset: 0x0000A3C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearByRow()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.sortGrid1.FocusItemIndex > -1)
			{
				this.cbText.Hide();
				this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("checkbox").Text = "0";
				this.sortGrid1.ClearAllTextByRow(this.sortGrid1.FocusItemIndex);
				this.sortGrid1.EndUpdate(this.sortGrid1.FocusItemIndex);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000C05C File Offset: 0x0000A45C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnRemoveAll_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (MessageBox.Show("Clear All Data?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					this.cbText.Hide();
					this.sortGrid1.Rows = 100;
					this.sortGrid1.Redraw();
					this._TotAmount = 0m;
					this.tslbTotAmount.Text = Utilities.PriceFormat(this._TotAmount);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnRemoveAll_Click", ex);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000C114 File Offset: 0x0000A514
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_KeyUp(object sender, KeyEventArgs e)
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
					if (keyCode == Keys.Escape)
					{
						this.cbText.Hide();
						goto IL_768;
					}
					switch (keyCode)
					{
					case Keys.Left:
					{
						string text = this.cbText.Tag.ToString();
						switch (text)
						{
						case "stock":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "side");
							break;
						case "ttf":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "stock");
							break;
						case "volume":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "ttf");
							break;
						case "price":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "volume");
							break;
						case "pubvol":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "price");
							break;
						case "condition":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "pubvol");
							break;
						case "deposit":
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "condition");
							break;
						}
						e.SuppressKeyPress = true;
						goto IL_768;
					}
					case Keys.Up:
						if (this.sortGrid1.FocusItemIndex - 1 > -1)
						{
							if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex - 1).Fields("side").Text.ToString().Trim() == string.Empty)
							{
								this.cbText.Tag = "side";
							}
							this.sortGrid1.SetFocusItem(this.sortGrid1.FocusItemIndex - 1);
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, this.cbText.Tag.ToString());
						}
						e.SuppressKeyPress = true;
						goto IL_768;
					case Keys.Right:
						break;
					case Keys.Down:
						this.calAmountPerRow();
						if (this.sortGrid1.FocusItemIndex + 1 < this.sortGrid1.Rows)
						{
							if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex + 1).Fields("side").Text.ToString().Trim() == string.Empty)
							{
								this.cbText.Tag = "side";
							}
							this.sortGrid1.SetFocusItem(this.sortGrid1.FocusItemIndex);
							this.SetTextPosition(this.sortGrid1.FocusItemIndex + 1, this.cbText.Tag.ToString());
						}
						e.SuppressKeyPress = true;
						goto IL_768;
					default:
						goto IL_768;
					}
				}
				if (this.SetText())
				{
					string text = this.cbText.Tag.ToString();
					switch (text)
					{
					case "side":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "stock");
						break;
					case "stock":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "ttf");
						break;
					case "ttf":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "volume");
						break;
					case "volume":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "price");
						this.calAmountPerRow();
						break;
					case "price":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "pubvol");
						this.calAmountPerRow();
						break;
					case "pubvol":
						this.SetTextPosition(this.sortGrid1.FocusItemIndex, "condition");
						this.calAmountPerRow();
						break;
					case "condition":
						if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
						{
							this.SetTextPosition(this.sortGrid1.FocusItemIndex, "deposit");
						}
						else if (this.sortGrid1.FocusItemIndex + 1 < this.sortGrid1.Rows)
						{
							if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex + 1).Fields("side").Text.ToString().Trim() == string.Empty)
							{
								this.cbText.Tag = "side";
							}
							this.sortGrid1.SetFocusItem(this.sortGrid1.FocusItemIndex);
							this.SetTextPosition(this.sortGrid1.FocusItemIndex + 1, this.cbText.Tag.ToString());
						}
						break;
					case "deposit":
						if (this.sortGrid1.FocusItemIndex + 1 < this.sortGrid1.Rows)
						{
							if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex + 1).Fields("side").Text.ToString().Trim() == string.Empty)
							{
								this.cbText.Tag = "side";
							}
							this.sortGrid1.SetFocusItem(this.sortGrid1.FocusItemIndex);
							this.SetTextPosition(this.sortGrid1.FocusItemIndex + 1, this.cbText.Tag.ToString());
						}
						break;
					}
					if (this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("checkbox").Text.ToString() == "")
					{
						this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("checkbox").Text = "0";
						this.sortGrid1.EndUpdate(this.sortGrid1.FocusItemIndex);
					}
				}
				e.SuppressKeyPress = true;
				IL_768:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbText_KeyUp", ex);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000C8C4 File Offset: 0x0000ACC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SetText()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result = false;
			try
			{
				string text = this.cbText.Tag.ToString();
				switch (text)
				{
				case "side":
					text = this.cbText.Text.Trim();
					if (text != null)
					{
						if (text == "B" || text == "S" || text == "C" || text == "H")
						{
							result = true;
						}
					}
					break;
				case "stock":
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbText.Text.Trim()];
					if (stockInformation.Number > 0)
					{
						result = true;
					}
					break;
				}
				case "ttf":
					text = this.cbText.Text.Trim();
					if (text != null)
					{
						if (text == "" || text == "1" || text == "2")
						{
							result = true;
						}
					}
					break;
				case "volume":
				case "pubvol":
				{
					long num2;
					long.TryParse(this.cbText.Text.Replace(",", ""), out num2);
					if (num2 > 0L)
					{
						result = true;
					}
					break;
				}
				case "price":
					text = this.cbText.Text.Trim();
					if (text != null)
					{
						if (text == "ATO" || text == "ATC" || text == "MP" || text == "MO" || text == "ML")
						{
							result = true;
							break;
						}
					}
					if (FormatUtil.Isnumeric(this.cbText.Text.Trim()))
					{
						result = true;
					}
					break;
				case "condition":
					text = this.cbText.Text.Trim();
					if (text != null)
					{
						if (text == "" || text == "IOC" || text == "FOK")
						{
							result = true;
						}
					}
					break;
				case "deposit":
					text = this.cbText.Text.Trim();
					if (text != null)
					{
						if (text == "" || text == "0" || text == "1")
						{
							result = true;
						}
					}
					break;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetText", ex);
			}
			return result;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000CC98 File Offset: 0x0000B098
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbStock_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			switch (e.KeyCode)
			{
			case Keys.Prior:
			case Keys.Next:
			case Keys.Left:
			case Keys.Up:
			case Keys.Right:
			case Keys.Down:
				e.SuppressKeyPress = true;
				break;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000CCF8 File Offset: 0x0000B0F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000CD34 File Offset: 0x0000B134
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.cbText.Tag.ToString() == "volume" || this.cbText.Tag.ToString() == "pubvol")
				{
					if (this.cbText.Text.Trim() != string.Empty)
					{
						if (FormatUtil.Isnumeric(this.cbText.Text))
						{
							try
							{
								decimal num = Convert.ToInt64(this.cbText.Text.Replace(",", ""));
								this.cbText.Text = num.ToString("#,###");
								this.cbText.Select(this.cbText.Text.Length, 0);
							}
							catch
							{
								this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
							}
						}
						else
						{
							this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
						}
					}
				}
				if (!this._isEditing && this.sortGrid1.FocusItemIndex > -1 && this.cbText.Tag != null)
				{
					this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields(this.cbText.Tag.ToString()).Text = this.cbText.Text;
					if (this.cbText.Tag.ToString() == "side")
					{
						if (this.cbText.Text.ToString().Trim().ToUpper() == "B")
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("side").FontColor = Color.Lime;
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("checkbox").Text = "0";
						}
						else if (this.cbText.Text.ToString().Trim().ToUpper() == "S")
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("side").FontColor = Color.Red;
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("checkbox").Text = "0";
						}
						else if (this.cbText.Text.ToString().Trim().ToUpper() == "C")
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("side").FontColor = Color.Cyan;
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("checkbox").Text = "0";
						}
						else if (this.cbText.Text.ToString().Trim().ToUpper() == "H")
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("side").FontColor = Color.Magenta;
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("checkbox").Text = "0";
						}
						else
						{
							this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("checkbox").Text = "";
						}
					}
					if (this.cbText.Tag.ToString() == "volume")
					{
						this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("pubvol").Text = this.cbText.Text;
					}
					if (this.cbText.Tag.ToString() == "pubvol" && this.cbText.Text == string.Empty)
					{
						this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("pubvol").Text = this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Fields("volume").Text;
					}
					if (this.cbText.Tag.ToString() == "ttf")
					{
						if (this.cbText.Text.Trim() != string.Empty)
						{
							if (FormatUtil.Isnumeric(this.cbText.Text))
							{
								try
								{
									int num2 = Convert.ToInt32(this.cbText.Text.Replace(",", ""));
									if (num2 == 0 || num2 == 1 || num2 == 2)
									{
										if (num2 == 0)
										{
											this.cbText.Text = "0";
										}
										this.cbText.Select(this.cbText.Text.Length, 0);
									}
									else
									{
										this.cbText.Text = string.Empty;
									}
								}
								catch
								{
									this.cbText.Text = string.Empty;
								}
							}
							else
							{
								this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
							}
						}
					}
					this.sortGrid1.Records(this.sortGrid1.FocusItemIndex).Changed = true;
					this.sortGrid1.EndUpdate();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("cbText_TextChanged", ex);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000D470 File Offset: 0x0000B870
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbText_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.cbText.Tag.ToString() == "ttf")
			{
				if (this.cbText.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.cbText.Text))
					{
						try
						{
							int num = Convert.ToInt32(this.cbText.Text.Replace(",", ""));
							if (num == 0 || num == 1 || num == 2)
							{
								if (num == 0)
								{
									this.cbText.Text = "0";
								}
								this.cbText.Select(this.cbText.Text.Length, 0);
							}
							else
							{
								this.cbText.Text = string.Empty;
							}
						}
						catch
						{
							this.cbText.Text = string.Empty;
						}
					}
					else
					{
						this.cbText.Text = this.cbText.Text.Substring(0, this.cbText.Text.Length - 1);
					}
				}
			}
			else if (this.cbText.Tag.ToString() == "volume" || this.cbText.Tag.ToString() == "pubvol")
			{
				if (this.cbText.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.cbText.Text))
					{
						try
						{
							decimal num2 = Convert.ToInt64(this.cbText.Text.Replace(",", ""));
							this.cbText.Text = num2.ToString("#,###");
							this.cbText.Select(this.cbText.Text.Length, 0);
						}
						catch
						{
							this.cbText.Text = string.Empty;
						}
					}
					else
					{
						this.cbText.Text = string.Empty;
					}
				}
			}
			this.cbText.Hide();
			this.calAmountPerRow();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000D734 File Offset: 0x0000BB34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSmartOrder_IDoFontChanged()
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

		// Token: 0x060000B2 RID: 178 RVA: 0x0000D778 File Offset: 0x0000BB78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmSmartOrder_IDoCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged || this.IsHeightChanged);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000D7C4 File Offset: 0x0000BBC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsImportCSV_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Select file";
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.FileName = string.Empty;
				openFileDialog.Filter = "csv files (*.csv)|*.csv";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (!this.IsFileLocked(new FileInfo(openFileDialog.FileName)))
					{
						this.ReadFileImported(openFileDialog.FileName);
						Application.DoEvents();
					}
					else
					{
						this.ShowMessageInFormConfirm("Can not import because the file is currently in use.", frmOrderFormConfirm.OpenStyle.ShowBox);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000D898 File Offset: 0x0000BC98
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool IsFileLocked(FileInfo file)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			FileStream fileStream = null;
			bool result;
			try
			{
				fileStream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			}
			catch (IOException)
			{
				result = true;
				return result;
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
			result = false;
			return result;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000D914 File Offset: 0x0000BD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadFileImported(string strFilePath)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				using (CsvFileReader csvFileReader = new CsvFileReader(strFilePath))
				{
					CsvRow csvRow = new CsvRow();
					int num = 0;
					DataTable dataTable = null;
					while (csvFileReader.ReadRow(csvRow))
					{
						if (num == 0)
						{
							dataTable = this.CreateOrderTable();
						}
						else
						{
							dataTable.Rows.Add(new object[0]);
							for (int i = 0; i < csvRow.Count; i++)
							{
								dataTable.Rows[num - 1][i] = csvRow[i].ToString().Trim();
							}
						}
						num++;
						Console.WriteLine();
					}
					if (dataTable != null && dataTable.Columns.Count > 0 && dataTable.TableName == "orderQueue")
					{
						this.UpdateToOrderGrid(new DataSet
						{
							Tables = 
							{
								dataTable
							}
						});
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000DAA0 File Offset: 0x0000BEA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DataTable CreateOrderTable()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return new DataTable("orderQueue")
			{
				Columns = 
				{
					"Side",
					"Stock",
					"NVDR",
					"Volume",
					"Price",
					"Validity",
					"PublishVol"
				}
			};
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000DB48 File Offset: 0x0000BF48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToOrderGrid(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.sortGrid1.ClearAllText();
				int num = 0;
				this.sortGrid1.Rows = 100;
				decimal d = 0m;
				decimal d2 = 0m;
				this._TotAmount = 0m;
				string text = string.Empty;
				foreach (DataRow dataRow in ds.Tables[0].Rows)
				{
					this._stockInfo = null;
					long num2 = 0L;
					long num3 = 0L;
					if (num >= this.sortGrid1.Rows)
					{
						break;
					}
					RecordItem recordItem = this.sortGrid1.Records(num);
					text = dataRow["Side"].ToString().ToUpper();
					if (text == "BUY")
					{
						text = "B";
					}
					else if (text == "SELL")
					{
						text = "S";
					}
					else if (text == "COVER")
					{
						text = "C";
					}
					else if (text == "SHORT")
					{
						text = "H";
					}
					recordItem.Fields("side").Text = text;
					recordItem.Fields("stock").Text = dataRow["Stock"].ToString().ToUpper();
					recordItem.Fields("ttf").Text = ((dataRow["NVDR"].ToString().Trim() == "0") ? "" : dataRow["NVDR"].ToString().Trim());
					recordItem.Fields("volume").Text = FormatUtil.VolumeFormat(dataRow["Volume"], true);
					recordItem.Fields("price").Text = FormatUtil.PriceFormat(dataRow["Price"].ToString().Trim(), 2, 0);
					recordItem.Fields("pubvol").Text = FormatUtil.VolumeFormat(FormatUtil.Isnumeric(dataRow["PublishVol"]) ? dataRow["PublishVol"] : dataRow["Volume"], true);
					recordItem.Fields("condition").Text = dataRow["Validity"];
					recordItem.Fields("deposit").Text = "";
					recordItem.Fields("processstatus").Text = "";
					recordItem.Fields("checkbox").Text = 0;
					this._stockInfo = ApplicationInfo.StockInfo[dataRow["Stock"].ToString().Trim()];
					if (this._stockInfo != null && this._stockInfo.Number > -1)
					{
						if (dataRow["Volume"].ToString().Replace(",", "").IndexOf(".") > 0)
						{
							long.TryParse(dataRow["Volume"].ToString().Replace(",", "").Substring(0, dataRow["Volume"].ToString().Replace(",", "").IndexOf(".")), out num2);
						}
						else
						{
							long.TryParse(dataRow["Volume"].ToString().Replace(",", ""), out num2);
						}
						if (dataRow["PublishVol"].ToString().Replace(",", "").IndexOf(".") > 0)
						{
							long.TryParse(dataRow["PublishVol"].ToString().Replace(",", "").Substring(0, dataRow["PublishVol"].ToString().Replace(",", "").IndexOf(".")), out num3);
						}
						else
						{
							long.TryParse(dataRow["PublishVol"].ToString().Replace(",", ""), out num3);
						}
						if (num3 <= 0L)
						{
							num3 = num2;
						}
						recordItem.Fields("pubvol").Text = FormatUtil.VolumeFormat(num3.ToString(), true);
						if (dataRow["Price"].ToString() == "ATO" || dataRow["Price"].ToString() == "ATC" || dataRow["Price"].ToString() == "MP")
						{
							if (text == "B" || text == "C")
							{
								d = this._stockInfo.Ceiling;
							}
							else if (text == "S" || text == "H")
							{
								d = this._stockInfo.Floor;
							}
						}
						else
						{
							decimal.TryParse(dataRow["Price"].ToString().Replace(",", ""), out d);
						}
						d2 = num2 * d;
						this._TotAmount += d2;
					}
					recordItem.Fields("amount").Text = FormatUtil.PriceFormat(d2.ToString());
					if (text == "B")
					{
						recordItem.Fields("side").FontColor = Color.Lime;
					}
					else if (text == "S")
					{
						recordItem.Fields("side").FontColor = Color.Red;
					}
					else if (text == "C")
					{
						recordItem.Fields("side").FontColor = Color.Cyan;
					}
					else if (text == "H")
					{
						recordItem.Fields("side").FontColor = Color.Pink;
					}
					else
					{
						recordItem.Fields("side").FontColor = Color.White;
					}
					recordItem.Fields("amount").FontColor = Color.Cyan;
					recordItem.Changed = true;
					num++;
				}
				this.tslbTotAmount.Text = Utilities.PriceFormat(this._TotAmount);
				this._stockInfo = null;
				this.sortGrid1.Redraw();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000E34C File Offset: 0x0000C74C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSendAllOrder_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isSending)
				{
					this._isSelectAll = true;
					if (this._lstOrder == null)
					{
						this._lstOrder = new List<int>();
					}
					else
					{
						this._lstOrder.Clear();
					}
					for (int i = 0; i < this.sortGrid1.Rows; i++)
					{
						RecordItem recordItem = this.sortGrid1.Records(i);
						if (recordItem.Fields("side").Text.ToString() != string.Empty && recordItem.Fields("stock").Text.ToString() != string.Empty && recordItem.Fields("volume").Text.ToString() != string.Empty)
						{
							this._lstOrder.Add(i);
						}
					}
					if (this._lstOrder.Count > 0)
					{
						this._isSending = true;
						this.ShowMessageInFormConfirm("Confirm to send " + this._lstOrder.Count + " orders?", frmOrderFormConfirm.OpenStyle.ConfirmSendNew, 0);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnSendAllOrder_Click", ex);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000E4E8 File Offset: 0x0000C8E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsSendSelected_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isSending)
				{
					this._isSelectAll = false;
					string text = string.Empty;
					if (this._lstOrder == null)
					{
						this._lstOrder = new List<int>();
					}
					else
					{
						this._lstOrder.Clear();
					}
					for (int i = 0; i < this.sortGrid1.Rows; i++)
					{
						if (this.sortGrid1.Records(i).Fields("checkbox").Text.ToString() == "1")
						{
							text = text + "," + (i + 1);
							this._lstOrder.Add(i);
						}
					}
					if (this._lstOrder.Count > 0)
					{
						this._isSending = true;
						text = text.Substring(1);
						this.ShowMessageInFormConfirm("Confirm to send list " + text + "?", frmOrderFormConfirm.OpenStyle.ConfirmSendNew, 0);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsSendSelected_Click", ex);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000E644 File Offset: 0x0000CA44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoopThroughGrid()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				bool flag = false;
				string text = ApplicationInfo.WebOrderService.VerifyOrderMkt();
				using (DataSet dataSet = new DataSet())
				{
					MyDataHelper.StringToDataSet(text, dataSet);
					if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
					{
						long num = 0L;
						string message = string.Empty;
						long.TryParse(dataSet.Tables["Results"].Rows[0]["code"].ToString(), out num);
						message = dataSet.Tables["Results"].Rows[0]["message"].ToString().Trim();
						if (num > 0L)
						{
							flag = true;
						}
						else
						{
							this.ShowMessageInFormConfirm(message, frmOrderFormConfirm.OpenStyle.Error);
						}
						dataSet.Clear();
					}
				}
				if (flag)
				{
					int num2 = 1;
					this._sendSuccessCount = 0;
					this._sendCount = 0;
					int num3 = 0;
					for (int i = 0; i < this.sortGrid1.Rows; i++)
					{
						RecordItem recordItem = this.sortGrid1.Records(i);
						bool flag2 = this._isSelectAll || recordItem.Fields("checkbox").Text.ToString() == "1";
						if (flag2)
						{
							if (recordItem.Fields("side").Text.ToString() != string.Empty && recordItem.Fields("stock").Text.ToString() != string.Empty && recordItem.Fields("volume").Text.ToString() != string.Empty)
							{
								this._side = recordItem.Fields("side").Text.ToString();
								this._stockSymbol = recordItem.Fields("stock").Text.ToString();
								long.TryParse(recordItem.Fields("volume").Text.ToString().Replace(",", ""), out this._volume);
								this._price = recordItem.Fields("price").Text.ToString().Replace(",", "");
								long.TryParse(recordItem.Fields("pubvol").Text.ToString().Replace(",", ""), out this._publishVol);
								this._condition = recordItem.Fields("condition").Text.ToString();
								int.TryParse(recordItem.Fields("ttf").Text.ToString(), out this._ttf);
								this._deposit = recordItem.Fields("deposit").Text.ToString();
								text = this.checkOrderValidate(this._side, this._stockSymbol, this._volume, this._price, this._ttf, this._publishVol, this._condition);
								StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this._stockSymbol];
								string condition = this._condition;
								if (condition != null)
								{
									if (!(condition == "IOC"))
									{
										if (!(condition == "FOK"))
										{
											if (condition == "")
											{
												if (ApplicationInfo.SupportFreewill)
												{
													if (this._volume < (long)stockInformation.BoardLot)
													{
														this._condition = "O";
													}
													else
													{
														this._condition = " ";
													}
												}
												else
												{
													this._condition = " ";
												}
											}
										}
										else
										{
											this._condition = "F";
										}
									}
									else
									{
										this._condition = "I";
									}
								}
								if (text == string.Empty)
								{
									this._sendCount++;
									ApplicationInfo.SendNewOrderResult sendNewOrderResult = ApplicationInfo.SendNewOrder(this._stockSymbol, this._side, this._volume, this._price, this._publishVol, this._condition, this._ttf, this._deposit, false);
									if (sendNewOrderResult.OrderNo > 0L)
									{
										ApplicationInfo.AddOrderNoToAutoRefreshList(sendNewOrderResult.OrderNo.ToString(), sendNewOrderResult.IsFwOfflineOrder ? 3 : 1);
										this.UpdateOrderResult("Success [" + sendNewOrderResult.OrderNo + "]", Color.Lime, i);
										this._sendSuccessCount++;
									}
									else
									{
										this.UpdateOrderResult(sendNewOrderResult.ResultMessage, Color.Yellow, i);
									}
									if (num2 == 100)
									{
										num2 = 0;
										Thread.Sleep(2000);
									}
									num2++;
								}
								else
								{
									num3++;
									this.UpdateOrderResult(text, Color.Red, i);
								}
								if (!this._isSending)
								{
									break;
								}
							}
						}
					}
					this.ShowMessageInFormConfirm(string.Concat(new object[]
					{
						"Send order :: Succeed ",
						this._sendSuccessCount,
						" orders, Failed ",
						this._sendCount - this._sendSuccessCount,
						" orders, Invalid orders ",
						num3,
						" orders."
					}), frmOrderFormConfirm.OpenStyle.ShowBox, 0);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoopThroughGrid", ex);
			}
			this._isSending = false;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000ECD4 File Offset: 0x0000D0D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckMktFreewill()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				bool flag = false;
				string data = ApplicationInfo.WebOrderService.VerifyOrderMkt();
				using (DataSet dataSet = new DataSet())
				{
					MyDataHelper.StringToDataSet(data, dataSet);
					if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
					{
						long num = 0L;
						string message = string.Empty;
						long.TryParse(dataSet.Tables["Results"].Rows[0]["code"].ToString(), out num);
						message = dataSet.Tables["Results"].Rows[0]["message"].ToString().Trim();
						if (num > 0L)
						{
							flag = true;
						}
						else
						{
							this.ShowMessageInFormConfirm(message, frmOrderFormConfirm.OpenStyle.Error);
						}
						dataSet.Clear();
					}
				}
				if (flag)
				{
					this._currSeqLineNo = this._lstOrder[0];
					this._lstOrder.Remove(this._currSeqLineNo);
					this.SendFreewillOrder();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("CheckMktFreewill", ex);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000EE94 File Offset: 0x0000D294
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendFreewillOrder()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				int num = 1;
				this._sendSuccessCount = 0;
				this._sendCount = 0;
				int num2 = 0;
				string text = string.Empty;
				int currSeqLineNo = this._currSeqLineNo;
				RecordItem recordItem = this.sortGrid1.Records(currSeqLineNo);
				bool flag = this._isSelectAll || recordItem.Fields("checkbox").Text.ToString() == "1";
				if (flag)
				{
					if (recordItem.Fields("side").Text.ToString() != string.Empty && recordItem.Fields("stock").Text.ToString() != string.Empty && recordItem.Fields("volume").Text.ToString() != string.Empty)
					{
						this._side = recordItem.Fields("side").Text.ToString();
						this._stockSymbol = recordItem.Fields("stock").Text.ToString();
						long.TryParse(recordItem.Fields("volume").Text.ToString().Replace(",", ""), out this._volume);
						this._price = recordItem.Fields("price").Text.ToString().Replace(",", "");
						long.TryParse(recordItem.Fields("pubvol").Text.ToString().Replace(",", ""), out this._publishVol);
						this._condition = recordItem.Fields("condition").Text.ToString();
						int.TryParse(recordItem.Fields("ttf").Text.ToString(), out this._ttf);
						this._deposit = recordItem.Fields("deposit").Text.ToString();
						text = this.checkOrderValidate(this._side, this._stockSymbol, this._volume, this._price, this._ttf, this._publishVol, this._condition);
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this._stockSymbol];
						string condition = this._condition;
						if (condition != null)
						{
							if (!(condition == "IOC"))
							{
								if (!(condition == "FOK"))
								{
									if (condition == "")
									{
										if (ApplicationInfo.SupportFreewill)
										{
											if (this._volume < (long)stockInformation.BoardLot)
											{
												this._condition = "O";
											}
											else
											{
												this._condition = " ";
											}
										}
										else
										{
											this._condition = " ";
										}
									}
								}
								else
								{
									this._condition = "F";
								}
							}
							else
							{
								this._condition = "I";
							}
						}
						if (text == string.Empty)
						{
							this._sendCount++;
							ApplicationInfo.SendNewOrderResult sendNewOrderResult = ApplicationInfo.SendNewOrder(this._stockSymbol, this._side, this._volume, this._price, this._publishVol, this._condition, this._ttf, this._deposit, false);
							if (sendNewOrderResult.OrderNo > 0L)
							{
								this._currOrdNoPending = sendNewOrderResult.OrderNo;
								ApplicationInfo.AddOrderNoToAutoRefreshList(sendNewOrderResult.OrderNo.ToString(), sendNewOrderResult.IsFwOfflineOrder ? 3 : 1);
								this.UpdateOrderResult("Success [" + sendNewOrderResult.OrderNo + "]", Color.Lime, currSeqLineNo);
								this._sendSuccessCount++;
							}
							else
							{
								this._currOrdNoPending = -1L;
								this.UpdateOrderResult(sendNewOrderResult.ResultMessage, Color.Yellow, currSeqLineNo);
							}
							num++;
						}
						else
						{
							num2++;
							this.UpdateOrderResult(text, Color.Red, currSeqLineNo);
							if (this._lstOrder.Count > 0)
							{
								this._currSeqLineNo = this._lstOrder[0];
								this._lstOrder.Remove(this._currSeqLineNo);
								Thread thread = new Thread(new ThreadStart(this.SendFreewillOrder));
								thread.Start();
							}
							else
							{
								this._isSending = false;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("LoopThroughGrid", ex);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000F398 File Offset: 0x0000D798
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkOrderValidateAll()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = string.Empty;
				for (int i = 0; i < this.sortGrid1.Rows; i++)
				{
					if (this.sortGrid1.Records(i).Fields("side").Text.ToString() != string.Empty && this.sortGrid1.Records(i).Fields("stock").Text.ToString() != string.Empty && this.sortGrid1.Records(i).Fields("volume").Text.ToString() != string.Empty)
					{
						this._side = this.sortGrid1.Records(i).Fields("side").Text.ToString();
						this._stockSymbol = this.sortGrid1.Records(i).Fields("stock").Text.ToString();
						long.TryParse(this.sortGrid1.Records(i).Fields("volume").Text.ToString().Replace(",", ""), out this._volume);
						this._price = this.sortGrid1.Records(i).Fields("price").Text.ToString().Replace(",", "");
						long.TryParse(this.sortGrid1.Records(i).Fields("pubvol").Text.ToString().Replace(",", ""), out this._publishVol);
						this._condition = this.sortGrid1.Records(i).Fields("condition").Text.ToString();
						int.TryParse(this.sortGrid1.Records(i).Fields("ttf").Text.ToString(), out this._ttf);
						this._deposit = this.sortGrid1.Records(i).Fields("deposit").Text.ToString();
						text = this.checkOrderValidate(this._side, this._stockSymbol, this._volume, this._price, this._ttf, this._publishVol, this._condition);
						if (text == string.Empty)
						{
							this.UpdateOrderResult("OK.", Color.Lime, i);
						}
						else
						{
							this.UpdateOrderResult(text, Color.Red, i);
						}
					}
					else
					{
						this.sortGrid1.Records(i).Fields("processstatus").Text = "";
						this.sortGrid1.Redraw();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("checkOrderValidate", ex);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000F6C4 File Offset: 0x0000DAC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string checkOrderValidate(string side, string symbol, long volume, string price, int ttf, long pubVol, string condition)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			bool flag = true;
			StockList.StockInformation stockInformation = null;
			try
			{
				if (string.IsNullOrEmpty(side) || (!(side == "B") && !(side == "S") && !(side == "C") && !(side == "H")))
				{
					result = "Invalid side.";
					flag = false;
				}
				if (flag)
				{
					stockInformation = ApplicationInfo.StockInfo[symbol];
					if (stockInformation == null || stockInformation.Symbol == string.Empty || stockInformation.Number < 1)
					{
						result = "Invalid stock symbol.";
						flag = false;
					}
				}
				if (flag)
				{
					if (volume < 1L)
					{
						result = "Invalid volume.";
						flag = false;
					}
				}
				if (flag)
				{
					decimal num = 0m;
					if (!this.IsValidPrice(price, stockInformation))
					{
						if (FormatUtil.Isnumeric(price))
						{
							decimal.TryParse(price, out num);
							if (num > stockInformation.Ceiling)
							{
								result = "Invalid price [higher than ceiling].";
							}
							else if (num < stockInformation.Floor)
							{
								result = "Invalid price [less than floor].";
							}
							else
							{
								result = "Invalid price.";
							}
						}
						else
						{
							result = "Invalid price.";
						}
						flag = false;
					}
					else if (FormatUtil.Isnumeric(price))
					{
						decimal.TryParse(price, out num);
						if (!this.IsValidSpread(num))
						{
							result = "Invalid price spread.";
							flag = false;
						}
					}
				}
				if (flag)
				{
					switch (ttf)
					{
					case 0:
					case 1:
					case 2:
						break;
					default:
						result = "Invalid trustee ID.";
						flag = false;
						break;
					}
				}
				if (flag)
				{
					if (this._publishVol > volume)
					{
						result = "Invalid Publish.";
						flag = false;
					}
				}
				if (flag)
				{
					string text = condition;
					if (text != null)
					{
						if (text == "IOC")
						{
							condition = "I";
							goto IL_2D9;
						}
						if (text == "FOK")
						{
							condition = "F";
							goto IL_2D9;
						}
						if (text == "")
						{
							condition = " ";
							goto IL_2D9;
						}
					}
					result = "Invalid condition.";
					IL_2D9:;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("checkOrderValidate", ex);
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000F9F0 File Offset: 0x0000DDF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsValidSpread(decimal Price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal spreadPrice = this.GetSpreadPrice(Price);
			return Price % spreadPrice == 0m;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000FA40 File Offset: 0x0000DE40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private decimal GetSpreadPrice(decimal price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal result;
			if (price >= 400m)
			{
				result = 2m;
			}
			else if (price >= 200m && price < 400m)
			{
				result = 1m;
			}
			else if (price >= 100m && price < 200m)
			{
				result = 0.50m;
			}
			else if (price >= 25m && price < 100m)
			{
				result = 0.25m;
			}
			else if (price >= 10m && price < 25m)
			{
				result = 0.1m;
			}
			else if (price >= 5m && price < 10m)
			{
				result = 0.05m;
			}
			else if (price >= 2m && price < 5m)
			{
				result = 0.02m;
			}
			else
			{
				result = 0.01m;
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000FC14 File Offset: 0x0000E014
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsValidPrice(string price, StockList.StockInformation tmpStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			try
			{
				if (price != null)
				{
					if (price == "ATO" || price == "ATC" || price == "MP" || price == "MO" || price == "ML")
					{
						result = true;
						return result;
					}
				}
				if (!FormatUtil.Isnumeric(price))
				{
					result = false;
					return result;
				}
				int num = price.IndexOf('.');
				string text = string.Empty;
				if (num > -1)
				{
					text = price.Substring(num + 1);
					if (text.Length < 2)
					{
						result = false;
						return result;
					}
					if (text.Length > 2)
					{
						result = false;
						return result;
					}
				}
				if (Convert.ToDecimal(price) <= 0m || Convert.ToDecimal(price) < tmpStockInfo.Floor || Convert.ToDecimal(price) > tmpStockInfo.Ceiling)
				{
					result = false;
					return result;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("IsValidPrice", ex);
			}
			result = true;
			return result;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000FDC0 File Offset: 0x0000E1C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateOrderResult(string text, Color color, int currRow)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.sortGrid1.InvokeRequired)
			{
				this.sortGrid1.Invoke(new frmBatchOrder.UpdateOrderResultCallback(this.UpdateOrderResult), new object[]
				{
					text,
					color,
					currRow
				});
			}
			else
			{
				try
				{
					this.sortGrid1.Records(currRow).Fields("processstatus").Text = text;
					this.sortGrid1.Records(currRow).Fields("processstatus").FontColor = color;
					this.sortGrid1.Records(currRow).Fields("checkbox").Text = "0";
					this.sortGrid1.Redraw();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000FEB4 File Offset: 0x0000E2B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectAllOrderForCancel(bool setSelectAll)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.sortGrid1.InvokeRequired)
				{
					this.sortGrid1.Invoke(new frmBatchOrder.SelectAllOrderForCancelCallBack(this.SelectAllOrderForCancel), new object[]
					{
						setSelectAll
					});
				}
				else
				{
					this._isSelectAll = setSelectAll;
					for (int i = 0; i < this.sortGrid1.Rows; i++)
					{
						if (this.sortGrid1.Records(i).Fields("checkbox").Text.ToString() == "1" || this.sortGrid1.Records(i).Fields("checkbox").Text.ToString() == "0")
						{
							if (this._isSelectAll)
							{
								this.sortGrid1.Records(i).Fields("checkbox").Text = "1";
							}
							else
							{
								this.sortGrid1.Records(i).Fields("checkbox").Text = "0";
							}
							this.sortGrid1.Records(i).Changed = true;
						}
					}
					this.sortGrid1.EndUpdate();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SelectAllOrderForCancel", ex);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0001005C File Offset: 0x0000E45C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ShowMessageInFormConfirm(message, openStyle, 0);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00010078 File Offset: 0x0000E478
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle, int verifyCode)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmBatchOrder.ShowMessageInFormConfirmCallBack(this.ShowMessageInFormConfirm), new object[]
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

		// Token: 0x060000C6 RID: 198 RVA: 0x0001021C File Offset: 0x0000E61C
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
						if (ApplicationInfo.SupportFreewill)
						{
							if (this._lstOrder.Count > 0)
							{
								Thread thread = new Thread(new ThreadStart(this.CheckMktFreewill));
								thread.Start();
							}
						}
						else
						{
							Thread thread2 = new Thread(new ThreadStart(this.LoopThroughGrid));
							thread2.Start();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00010314 File Offset: 0x0000E714
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void calAmountPerRow()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long value = 0L;
				decimal d = 0m;
				decimal num = 0m;
				this._TotAmount = 0m;
				int i = this.sortGrid1.FocusItemIndex;
				if (i > -1)
				{
					RecordItem recordItem = this.sortGrid1.Records(i);
					this._stockInfo = null;
					this._stockInfo = ApplicationInfo.StockInfo[recordItem.Fields("stock").Text.ToString().Trim()];
					if (this._stockInfo != null && this._stockInfo.Number > -1)
					{
						if (recordItem.Fields("volume").Text.ToString().Replace(",", "").IndexOf(".") > 0)
						{
							long.TryParse(recordItem.Fields("volume").Text.ToString().Replace(",", "").Substring(0, recordItem.Fields("volume").Text.ToString().Replace(",", "").IndexOf(".")), out value);
						}
						else
						{
							long.TryParse(recordItem.Fields("volume").Text.ToString().Replace(",", ""), out value);
						}
						if (recordItem.Fields("price").Text.ToString() == "ATO" || recordItem.Fields("price").Text.ToString() == "ATC" || recordItem.Fields("price").Text.ToString() == "MP" || recordItem.Fields("price").Text.ToString() == "MO" || recordItem.Fields("price").Text.ToString() == "ML")
						{
							string text = recordItem.Fields("side").Text.ToString().Trim();
							if (text != null)
							{
								if (!(text == "B") && !(text == "C"))
								{
									if (text == "S" || text == "H")
									{
										d = this._stockInfo.Floor;
									}
								}
								else
								{
									d = this._stockInfo.Ceiling;
								}
							}
						}
						else
						{
							decimal.TryParse(recordItem.Fields("price").Text.ToString().Replace(",", ""), out d);
						}
						num = value * d;
						recordItem.Fields("amount").Text = num.ToString();
						recordItem.Fields("amount").FontColor = Color.Cyan;
						if (num > 0m)
						{
							recordItem.Fields("checkbox").Text = "0";
						}
						else
						{
							recordItem.Fields("checkbox").Text = "";
						}
						this.sortGrid1.Redraw();
					}
				}
				this._TotAmount = 0m;
				for (i = 0; i < this.sortGrid1.Rows; i++)
				{
					RecordItem recordItem = this.sortGrid1.Records(i);
					decimal.TryParse(recordItem.Fields("amount").Text.ToString(), out num);
					this._TotAmount += num;
				}
				this.tslbTotAmount.Text = Utilities.PriceFormat(this._TotAmount);
			}
			catch (Exception ex)
			{
				this.ShowError("calAmountPerRow", ex);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00010790 File Offset: 0x0000EB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsExportCSV_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.gridToDataSet();
				if (this._dtOrderQueue != null && this._dtOrderQueue.Rows.Count > 0)
				{
					CSVReadWrite.exportToCSV(this._dtOrderQueue);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001080C File Offset: 0x0000EC0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void gridToDataSet()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._dtOrderQueue = this.CreateOrderTable();
				this._dtOrderQueue.Rows.Add(new object[0]);
				this._dtOrderQueue.Rows[0][0] = "Side";
				this._dtOrderQueue.Rows[0][1] = "Stock Code";
				this._dtOrderQueue.Rows[0][2] = "NVDR";
				this._dtOrderQueue.Rows[0][3] = "Quantity ";
				this._dtOrderQueue.Rows[0][4] = "Price";
				this._dtOrderQueue.Rows[0][5] = "Validity";
				this._dtOrderQueue.Rows[0][6] = "Iceberg Vol";
				for (int i = 0; i < this.sortGrid1.Rows; i++)
				{
					RecordItem recordItem = this.sortGrid1.Records(i);
					if (recordItem.Fields("side").Text.ToString() != string.Empty && recordItem.Fields("stock").Text.ToString() != string.Empty && recordItem.Fields("volume").Text.ToString() != string.Empty)
					{
						this._dtOrderQueue.Rows.Add(new object[0]);
						this._dtOrderQueue.Rows[i + 1][0] = recordItem.Fields("side").Text.ToString();
						this._dtOrderQueue.Rows[i + 1][1] = recordItem.Fields("stock").Text.ToString();
						this._dtOrderQueue.Rows[i + 1][2] = recordItem.Fields("ttf").Text.ToString();
						this._dtOrderQueue.Rows[i + 1][3] = recordItem.Fields("volume").Text.ToString().Replace(",", "");
						this._dtOrderQueue.Rows[i + 1][4] = recordItem.Fields("price").Text.ToString().Replace(",", "");
						this._dtOrderQueue.Rows[i + 1][5] = recordItem.Fields("condition").Text.ToString();
						this._dtOrderQueue.Rows[i + 1][6] = recordItem.Fields("pubvol").Text.ToString().Replace(",", "");
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00010B78 File Offset: 0x0000EF78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sortGrid1_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex == -1)
				{
					string name = e.Column.Name;
					if (name != null)
					{
						if (!(name == "checkbox"))
						{
							if (name == "side" || name == "stock" || name == "volume" || name == "price" || name == "pubvol")
							{
								if (this.sortGrid1.SortType == SortType.Asc)
								{
									this.sortGrid1.Sort(e.Column.Name, SortType.Desc);
								}
								else
								{
									this.sortGrid1.Sort(e.Column.Name, SortType.Asc);
								}
								this.sortGrid1.Redraw();
							}
						}
						else
						{
							this.SelectAllOrderForCancel(!this._isSelectAll);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intza_TableMouseClick", ex);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00010CCC File Offset: 0x0000F0CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sortGrid1_TableMouseDoubleClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if ((float)e.Mouse.Y > this.sortGrid1.RowHeight)
				{
					string name = e.Column.Name;
					switch (name)
					{
					case "side":
					case "stock":
					case "ttf":
					case "volume":
					case "price":
					case "pubvol":
					case "condition":
					case "deposit":
						this.SetTextPosition(e.RowIndex, e.Column.Name);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intza_TableMouseClick", ex);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00010E30 File Offset: 0x0000F230
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnStopSending_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._isSending = false;
		}

		// Token: 0x04000059 RID: 89
		private IContainer components;

		// Token: 0x0400005A RID: 90
		private ToolStrip toolStrip1;

		// Token: 0x0400005B RID: 91
		private ToolStripButton tsbtnClear;

		// Token: 0x0400005C RID: 92
		private ToolStripButton tsbtnClearAll;

		// Token: 0x0400005D RID: 93
		private ComboBox cbText;

		// Token: 0x0400005E RID: 94
		private ToolStripSeparator toolStripSeparator4;

		// Token: 0x0400005F RID: 95
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000060 RID: 96
		private OrderQueueDS orderQueueDS1;

		// Token: 0x04000061 RID: 97
		private StatusStrip statusStrip1;

		// Token: 0x04000062 RID: 98
		private ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04000063 RID: 99
		private ToolStripStatusLabel toolStripStatusLabel4;

		// Token: 0x04000064 RID: 100
		private ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x04000065 RID: 101
		private ToolStripButton tsImportCSV;

		// Token: 0x04000066 RID: 102
		private ToolStripButton tsbtnSendAllOrder;

		// Token: 0x04000067 RID: 103
		private ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000068 RID: 104
		private ToolStripButton tsSendSelected;

		// Token: 0x04000069 RID: 105
		private ToolStripButton tsExportCSV;

		// Token: 0x0400006A RID: 106
		private ToolStripSeparator toolStripSeparator6;

		// Token: 0x0400006B RID: 107
		private ToolStripButton tsbtnValidateOrder;

		// Token: 0x0400006C RID: 108
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400006D RID: 109
		private SortGrid sortGrid1;

		// Token: 0x0400006E RID: 110
		private ToolStripStatusLabel toolStripStatusLabel3;

		// Token: 0x0400006F RID: 111
		private ToolStripStatusLabel tslbTotAmount;

		// Token: 0x04000070 RID: 112
		private ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000071 RID: 113
		private ToolStripButton tsbtnStopSending;

		// Token: 0x04000072 RID: 114
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x04000073 RID: 115
		private bool _isEditing;

		// Token: 0x04000074 RID: 116
		private StockList.StockInformation _stockInfo;

		// Token: 0x04000075 RID: 117
		private decimal _TotAmount;

		// Token: 0x04000076 RID: 118
		private DataTable _dtOrderQueue;

		// Token: 0x04000077 RID: 119
		private string _stockSymbol;

		// Token: 0x04000078 RID: 120
		private string _side;

		// Token: 0x04000079 RID: 121
		private long _volume;

		// Token: 0x0400007A RID: 122
		private string _price;

		// Token: 0x0400007B RID: 123
		private long _publishVol;

		// Token: 0x0400007C RID: 124
		private string _condition;

		// Token: 0x0400007D RID: 125
		private int _ttf;

		// Token: 0x0400007E RID: 126
		private string _deposit;

		// Token: 0x0400007F RID: 127
		private int _sendSuccessCount;

		// Token: 0x04000080 RID: 128
		private int _sendCount;

		// Token: 0x04000081 RID: 129
		private bool _isSelectAll;

		// Token: 0x04000082 RID: 130
		private long _currOrdNoPending;

		// Token: 0x04000083 RID: 131
		private int _currSeqLineNo;

		// Token: 0x04000084 RID: 132
		private List<int> _lstOrder;

		// Token: 0x04000085 RID: 133
		private bool _isSending;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000CE RID: 206
		private delegate void UpdateOrderResultCallback(string text, Color color, int currRow);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000D2 RID: 210
		private delegate void SelectAllOrderForCancelCallBack(bool setSelectAll);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000D6 RID: 214
		private delegate void ShowMessageInFormConfirmCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle, int verifyCode);
	}
}
