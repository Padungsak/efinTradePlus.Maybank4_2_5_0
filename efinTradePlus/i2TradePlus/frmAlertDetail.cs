using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;

namespace i2TradePlus
{
	// Token: 0x020000F6 RID: 246
	internal class frmAlertDetail : Form
	{
		// Token: 0x06000B6A RID: 2922 RVA: 0x000CFF1C File Offset: 0x000CE31C
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

		// Token: 0x06000B6B RID: 2923 RVA: 0x000CFF6C File Offset: 0x000CE36C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmAlertDetail));
			this.lvDetailAlert = new ListView();
			this.SymbolCol = new ColumnHeader();
			this.ExpressionCol = new ColumnHeader();
			this.timeArriveCol = new ColumnHeader();
			this.ctmsInformation = new ContextMenuStrip(this.components);
			this.tsmiStartMonitor = new ToolStripMenuItem();
			this.tsmiStopMonitor = new ToolStripMenuItem();
			this.tsmiSingleClear = new ToolStripMenuItem();
			this.tsmiClearDetail = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.tsmiFontDialog = new ToolStripMenuItem();
			this.tsmiAlertOption = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.tsmiCloesInfomation = new ToolStripMenuItem();
			this.tsInformationDetail = new ToolStrip();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.tsdViewMunu = new ToolStripDropDownButton();
			this.tsmStockByPrice = new ToolStripMenuItem();
			this.tsmStockInPlay = new ToolStripMenuItem();
			this.tsmSaleByPrice = new ToolStripMenuItem();
			this.tsmSaleByTime = new ToolStripMenuItem();
			this.tsmViewOddLot = new ToolStripMenuItem();
			this.tsbStartMonitor = new ToolStripButton();
			this.tsbStopMonitor = new ToolStripButton();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.tsbClearRow = new ToolStripButton();
			this.tsbFontDialog = new ToolStripButton();
			this.tsbClearAll = new ToolStripButton();
			this.tsbAlertOption = new ToolStripButton();
			this.toolStripSeparator7 = new ToolStripSeparator();
			this.toolStripLabel1 = new ToolStripLabel();
			this.lbRowcount = new ToolStripLabel();
			this.tsbClose = new ToolStripButton();
			this.ctmsInformation.SuspendLayout();
			this.tsInformationDetail.SuspendLayout();
			base.SuspendLayout();
			this.lvDetailAlert.BackColor = Color.Black;
			this.lvDetailAlert.BorderStyle = BorderStyle.FixedSingle;
			this.lvDetailAlert.Columns.AddRange(new ColumnHeader[]
			{
				this.SymbolCol,
				this.ExpressionCol,
				this.timeArriveCol
			});
			this.lvDetailAlert.Dock = DockStyle.Fill;
			this.lvDetailAlert.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lvDetailAlert.ForeColor = Color.Yellow;
			this.lvDetailAlert.FullRowSelect = true;
			this.lvDetailAlert.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.lvDetailAlert.Location = new Point(0, 25);
			this.lvDetailAlert.Name = "lvDetailAlert";
			this.lvDetailAlert.Size = new Size(520, 156);
			this.lvDetailAlert.TabIndex = 2;
			this.lvDetailAlert.UseCompatibleStateImageBehavior = false;
			this.lvDetailAlert.View = View.Details;
			this.lvDetailAlert.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(this.lvDetailAlert_ItemSelectionChanged);
			this.SymbolCol.Text = "Symbol";
			this.SymbolCol.Width = 80;
			this.ExpressionCol.Text = "Expression";
			this.ExpressionCol.Width = 335;
			this.timeArriveCol.Text = "Times";
			this.timeArriveCol.Width = 80;
			this.ctmsInformation.Items.AddRange(new ToolStripItem[]
			{
				this.tsmiStartMonitor,
				this.tsmiStopMonitor,
				this.tsmiSingleClear,
				this.tsmiClearDetail,
				this.toolStripSeparator1,
				this.tsmiFontDialog,
				this.tsmiAlertOption,
				this.toolStripSeparator3,
				this.tsmiCloesInfomation
			});
			this.ctmsInformation.Name = "ctmsInformation";
			this.ctmsInformation.Size = new Size(149, 170);
			this.tsmiStartMonitor.Image = (Image)componentResourceManager.GetObject("tsmiStartMonitor.Image");
			this.tsmiStartMonitor.Name = "tsmiStartMonitor";
			this.tsmiStartMonitor.Size = new Size(148, 22);
			this.tsmiStartMonitor.Text = "Monitor";
			this.tsmiStartMonitor.Visible = false;
			this.tsmiStartMonitor.Click += new EventHandler(this.tsmiStartMonitor_Click);
			this.tsmiStopMonitor.Image = (Image)componentResourceManager.GetObject("tsmiStopMonitor.Image");
			this.tsmiStopMonitor.Name = "tsmiStopMonitor";
			this.tsmiStopMonitor.Size = new Size(148, 22);
			this.tsmiStopMonitor.Text = "&Stop";
			this.tsmiStopMonitor.Visible = false;
			this.tsmiStopMonitor.Click += new EventHandler(this.tsmiStopMonitor_Click);
			this.tsmiSingleClear.Name = "tsmiSingleClear";
			this.tsmiSingleClear.Size = new Size(148, 22);
			this.tsmiSingleClear.Text = "&Clear";
			this.tsmiSingleClear.Visible = false;
			this.tsmiSingleClear.Click += new EventHandler(this.tsmiSingleClear_Click);
			this.tsmiClearDetail.Image = (Image)componentResourceManager.GetObject("tsmiClearDetail.Image");
			this.tsmiClearDetail.Name = "tsmiClearDetail";
			this.tsmiClearDetail.Size = new Size(148, 22);
			this.tsmiClearDetail.Text = "&Clear All";
			this.tsmiClearDetail.Visible = false;
			this.tsmiClearDetail.Click += new EventHandler(this.tsmiClearDetail_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(145, 6);
			this.toolStripSeparator1.Visible = false;
			this.tsmiFontDialog.Image = (Image)componentResourceManager.GetObject("tsmiFontDialog.Image");
			this.tsmiFontDialog.Name = "tsmiFontDialog";
			this.tsmiFontDialog.Size = new Size(148, 22);
			this.tsmiFontDialog.Text = "Font..";
			this.tsmiFontDialog.Click += new EventHandler(this.tsmiFontDialog_Click);
			this.tsmiAlertOption.Image = (Image)componentResourceManager.GetObject("tsmiAlertOption.Image");
			this.tsmiAlertOption.Name = "tsmiAlertOption";
			this.tsmiAlertOption.Size = new Size(148, 22);
			this.tsmiAlertOption.Text = "Alert Option...";
			this.tsmiAlertOption.Visible = false;
			this.tsmiAlertOption.Click += new EventHandler(this.tsmiAlertOption_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(145, 6);
			this.tsmiCloesInfomation.Image = Resources.fileclose;
			this.tsmiCloesInfomation.Name = "tsmiCloesInfomation";
			this.tsmiCloesInfomation.Size = new Size(148, 22);
			this.tsmiCloesInfomation.Text = "&Close";
			this.tsmiCloesInfomation.Click += new EventHandler(this.tsmiCloesInfomation_Click);
			this.tsInformationDetail.GripStyle = ToolStripGripStyle.Hidden;
			this.tsInformationDetail.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSeparator4,
				this.tsdViewMunu,
				this.tsbStartMonitor,
				this.tsbStopMonitor,
				this.toolStripSeparator5,
				this.tsbClearRow,
				this.tsbFontDialog,
				this.tsbClearAll,
				this.tsbAlertOption,
				this.toolStripSeparator7,
				this.toolStripLabel1,
				this.lbRowcount,
				this.tsbClose
			});
			this.tsInformationDetail.Location = new Point(0, 0);
			this.tsInformationDetail.Name = "tsInformationDetail";
			this.tsInformationDetail.RenderMode = ToolStripRenderMode.System;
			this.tsInformationDetail.Size = new Size(520, 25);
			this.tsInformationDetail.TabIndex = 3;
			this.tsInformationDetail.Text = "Information Detail";
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(6, 25);
			this.toolStripSeparator4.Visible = false;
			this.tsdViewMunu.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsdViewMunu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.tsmStockByPrice,
				this.tsmStockInPlay,
				this.tsmSaleByPrice,
				this.tsmSaleByTime,
				this.tsmViewOddLot
			});
			this.tsdViewMunu.Image = (Image)componentResourceManager.GetObject("tsdViewMunu.Image");
			this.tsdViewMunu.ImageTransparentColor = Color.Magenta;
			this.tsdViewMunu.Name = "tsdViewMunu";
			this.tsdViewMunu.Size = new Size(45, 22);
			this.tsdViewMunu.Text = "View";
			this.tsdViewMunu.ToolTipText = "View Menu Link...";
			this.tsdViewMunu.Visible = false;
			this.tsmStockByPrice.Name = "tsmStockByPrice";
			this.tsmStockByPrice.Size = new Size(142, 22);
			this.tsmStockByPrice.Text = "Stock Info";
			this.tsmStockInPlay.Name = "tsmStockInPlay";
			this.tsmStockInPlay.Size = new Size(142, 22);
			this.tsmStockInPlay.Text = "Stock In Play";
			this.tsmSaleByPrice.Name = "tsmSaleByPrice";
			this.tsmSaleByPrice.Size = new Size(142, 22);
			this.tsmSaleByPrice.Text = "Sale By Price";
			this.tsmSaleByTime.Name = "tsmSaleByTime";
			this.tsmSaleByTime.Size = new Size(142, 22);
			this.tsmSaleByTime.Text = "Sale By Time";
			this.tsmViewOddLot.Name = "tsmViewOddLot";
			this.tsmViewOddLot.Size = new Size(142, 22);
			this.tsmViewOddLot.Text = "View OddLot";
			this.tsbStartMonitor.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbStartMonitor.Image = (Image)componentResourceManager.GetObject("tsbStartMonitor.Image");
			this.tsbStartMonitor.ImageTransparentColor = Color.Magenta;
			this.tsbStartMonitor.Name = "tsbStartMonitor";
			this.tsbStartMonitor.Size = new Size(23, 22);
			this.tsbStartMonitor.Text = "Monitor";
			this.tsbStartMonitor.ToolTipText = "Start Monitoring.";
			this.tsbStartMonitor.Visible = false;
			this.tsbStartMonitor.Click += new EventHandler(this.tsmiStartMonitor_Click);
			this.tsbStopMonitor.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbStopMonitor.Image = (Image)componentResourceManager.GetObject("tsbStopMonitor.Image");
			this.tsbStopMonitor.ImageTransparentColor = Color.Magenta;
			this.tsbStopMonitor.Name = "tsbStopMonitor";
			this.tsbStopMonitor.Size = new Size(23, 22);
			this.tsbStopMonitor.Text = "Stop";
			this.tsbStopMonitor.ToolTipText = "Stop Monitoring.";
			this.tsbStopMonitor.Visible = false;
			this.tsbStopMonitor.Click += new EventHandler(this.tsmiStopMonitor_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size(6, 25);
			this.toolStripSeparator5.Visible = false;
			this.tsbClearRow.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbClearRow.Image = (Image)componentResourceManager.GetObject("tsbClearRow.Image");
			this.tsbClearRow.ImageTransparentColor = Color.Magenta;
			this.tsbClearRow.Name = "tsbClearRow";
			this.tsbClearRow.Size = new Size(38, 22);
			this.tsbClearRow.Text = "Clear";
			this.tsbClearRow.ToolTipText = "Clear row...";
			this.tsbClearRow.Visible = false;
			this.tsbClearRow.Click += new EventHandler(this.tsmiSingleClear_Click);
			this.tsbFontDialog.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbFontDialog.Image = (Image)componentResourceManager.GetObject("tsbFontDialog.Image");
			this.tsbFontDialog.ImageTransparentColor = Color.Magenta;
			this.tsbFontDialog.Name = "tsbFontDialog";
			this.tsbFontDialog.Size = new Size(23, 22);
			this.tsbFontDialog.Text = "Font...";
			this.tsbFontDialog.Visible = false;
			this.tsbFontDialog.Click += new EventHandler(this.tsbFontDialog_Click);
			this.tsbClearAll.Image = (Image)componentResourceManager.GetObject("tsbClearAll.Image");
			this.tsbClearAll.ImageTransparentColor = Color.Magenta;
			this.tsbClearAll.Name = "tsbClearAll";
			this.tsbClearAll.Size = new Size(54, 22);
			this.tsbClearAll.Text = "Clear";
			this.tsbClearAll.ToolTipText = "Clear All rows...";
			this.tsbClearAll.Click += new EventHandler(this.tsmiClearDetail_Click);
			this.tsbAlertOption.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbAlertOption.Image = (Image)componentResourceManager.GetObject("tsbAlertOption.Image");
			this.tsbAlertOption.ImageTransparentColor = Color.Magenta;
			this.tsbAlertOption.Name = "tsbAlertOption";
			this.tsbAlertOption.Size = new Size(23, 22);
			this.tsbAlertOption.Text = "Alert Option...";
			this.tsbAlertOption.Visible = false;
			this.tsbAlertOption.Click += new EventHandler(this.tsmiAlertOption_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new Size(6, 25);
			this.toolStripLabel1.BackColor = Color.Transparent;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new Size(67, 22);
			this.toolStripLabel1.Text = "Messages : ";
			this.lbRowcount.BackColor = Color.Transparent;
			this.lbRowcount.ForeColor = Color.Red;
			this.lbRowcount.Name = "lbRowcount";
			this.lbRowcount.Size = new Size(13, 22);
			this.lbRowcount.Text = "0";
			this.tsbClose.Alignment = ToolStripItemAlignment.Right;
			this.tsbClose.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbClose.Image = (Image)componentResourceManager.GetObject("tsbClose.Image");
			this.tsbClose.ImageTransparentColor = Color.Magenta;
			this.tsbClose.Name = "tsbClose";
			this.tsbClose.Size = new Size(23, 22);
			this.tsbClose.Text = "&Close";
			this.tsbClose.ToolTipText = "Close.";
			this.tsbClose.Click += new EventHandler(this.tsmiCloesInfomation_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(64, 64, 64);
			base.ClientSize = new Size(520, 181);
			this.ContextMenuStrip = this.ctmsInformation;
			base.ControlBox = false;
			base.Controls.Add(this.lvDetailAlert);
			base.Controls.Add(this.tsInformationDetail);
			this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.Name = "frmAlertDetail";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Price Alert on PC";
			base.FormClosing += new FormClosingEventHandler(this.frmAlertDetail_FormClosing);
			base.KeyDown += new KeyEventHandler(this.frmAlertDetail_KeyDown);
			this.ctmsInformation.ResumeLayout(false);
			this.tsInformationDetail.ResumeLayout(false);
			this.tsInformationDetail.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000D1094 File Offset: 0x000CF494
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal frmAlertDetail() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.symbolLink = string.Empty;
			this.sytemOptionForm = null;
			
			this.InitializeComponent();
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000D10D4 File Offset: 0x000CF4D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal frmAlertDetail(AlertItem alertItem) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.symbolLink = string.Empty;
			this.sytemOptionForm = null;
			
			this.InitializeComponent();
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x000D1114 File Offset: 0x000CF514
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x000D1140 File Offset: 0x000CF540
		internal string MessageTimeArrival
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.messageTimeArrival;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.messageTimeArrival = value;
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000D1158 File Offset: 0x000CF558
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAlertDetail_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000D1190 File Offset: 0x000CF590
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAlertDetail_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Hide();
			e.Cancel = true;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000D11B4 File Offset: 0x000CF5B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiClearDetail_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.lvDetailAlert.Items.Clear();
			this.symbolLink = string.Empty;
			AlertManager.Instance.MarkUnReadAll();
			this.UpdateRowCountLabel();
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000D11F4 File Offset: 0x000CF5F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiCloesInfomation_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Hide();
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000D1210 File Offset: 0x000CF610
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiStopMonitor_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (AlertManager.Instance.IsMonitoring)
			{
				AlertManager.Instance.IsMonitoring = false;
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000D124C File Offset: 0x000CF64C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiStartMonitor_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!AlertManager.Instance.IsMonitoring)
			{
				AlertManager.Instance.IsMonitoring = true;
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000D1288 File Offset: 0x000CF688
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiAlertOption_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.sytemOptionForm == null || this.sytemOptionForm.IsDisposed)
			{
				this.sytemOptionForm = new frmSystemOption();
			}
			this.sytemOptionForm.TopMost = true;
			this.sytemOptionForm.MdiParent = base.MdiParent;
			this.sytemOptionForm.Show();
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000D1304 File Offset: 0x000CF704
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void alertOptionForm_OnAlertClick()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000D1318 File Offset: 0x000CF718
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void lvDetailAlert_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.symbolLink = e.Item.Text;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000D133C File Offset: 0x000CF73C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiSingleClear_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.lvDetailAlert.SelectedItems.Count != 0)
			{
				AlertItem item = (AlertItem)this.lvDetailAlert.Items[this.lvDetailAlert.SelectedItems[0].Index].Tag;
				AlertManager.Instance.MarkUnRead(this.symbolLink, item);
				this.lvDetailAlert.Items[this.lvDetailAlert.SelectedItems[0].Index].Remove();
				this.symbolLink = string.Empty;
				this.UpdateRowCountLabel();
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000D13FC File Offset: 0x000CF7FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiFontDialog_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetFontDialog(this);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000D1418 File Offset: 0x000CF818
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbFontDialog_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetFontDialog(this);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000D1434 File Offset: 0x000CF834
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void AddAlertItem(AlertItem item)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.lvDetailAlert.InvokeRequired)
				{
					this.lvDetailAlert.Invoke(new frmAlertDetail.AddAlertItemCallback(this.AddAlertItem), new object[]
					{
						item
					});
				}
				else
				{
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = item.Symbol;
					if (item.Field.ToLower() == "%change")
					{
						listViewItem.SubItems.Add(string.Concat(new string[]
						{
							item.Field,
							" >= ",
							Utilities.PriceFormat(item.Value),
							", Current = ",
							Utilities.PriceFormat(item.ValueMessageRealtime)
						}));
					}
					else
					{
						listViewItem.SubItems.Add(string.Concat(new string[]
						{
							item.Field,
							" ",
							item.Operator,
							" ",
							Utilities.PriceFormat(item.Value),
							", Current = ",
							Utilities.PriceFormat(item.ValueMessageRealtime)
						}));
					}
					listViewItem.SubItems.Add(DateTime.Now.ToLongTimeString());
					listViewItem.Tag = item;
					if (this.lvDetailAlert != null)
					{
						this.lvDetailAlert.Items.Insert(0, listViewItem);
					}
					this.UpdateRowCountLabel();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("AddAlertItem", ex);
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000D160C File Offset: 0x000CFA0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x000D1640 File Offset: 0x000CFA40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateRowCountLabel()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tsInformationDetail.InvokeRequired)
			{
				this.tsInformationDetail.Invoke(new MethodInvoker(this.UpdateRowCountLabel));
			}
			else if (this.lvDetailAlert == null)
			{
				this.lbRowcount.Text = "0";
			}
			else
			{
				this.lbRowcount.Text = this.lvDetailAlert.Items.Count.ToString();
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000D16E0 File Offset: 0x000CFAE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetFontDialog(object formActive)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmAlertDetail.SetFontDialogCallBack(this.SetFontDialog), new object[]
				{
					formActive
				});
			}
			else if (formActive != null)
			{
				FontDialog fontDialog = new FontDialog();
				if (formActive.GetType() == typeof(frmAlertDetail))
				{
					fontDialog.Font = (formActive as frmAlertDetail).Controls[0].Font;
				}
				DialogResult dialogResult = fontDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					foreach (Control control in (formActive as Form).Controls)
					{
						if (control.GetType() == typeof(Label))
						{
							control.Font = fontDialog.Font;
						}
						else if (control.GetType() == typeof(ListView))
						{
							control.Font = fontDialog.Font;
						}
						control.Refresh();
					}
					(formActive as Form).Invalidate();
				}
			}
		}

		// Token: 0x04000785 RID: 1925
		private IContainer components;

		// Token: 0x04000786 RID: 1926
		private ListView lvDetailAlert;

		// Token: 0x04000787 RID: 1927
		private ColumnHeader SymbolCol;

		// Token: 0x04000788 RID: 1928
		private ColumnHeader ExpressionCol;

		// Token: 0x04000789 RID: 1929
		private ColumnHeader timeArriveCol;

		// Token: 0x0400078A RID: 1930
		private ContextMenuStrip ctmsInformation;

		// Token: 0x0400078B RID: 1931
		private ToolStripMenuItem tsmiClearDetail;

		// Token: 0x0400078C RID: 1932
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400078D RID: 1933
		private ToolStripMenuItem tsmiCloesInfomation;

		// Token: 0x0400078E RID: 1934
		private ToolStripMenuItem tsmiStartMonitor;

		// Token: 0x0400078F RID: 1935
		private ToolStripMenuItem tsmiStopMonitor;

		// Token: 0x04000790 RID: 1936
		private ToolStripMenuItem tsmiAlertOption;

		// Token: 0x04000791 RID: 1937
		private ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000792 RID: 1938
		private ToolStripMenuItem tsmiSingleClear;

		// Token: 0x04000793 RID: 1939
		private ToolStrip tsInformationDetail;

		// Token: 0x04000794 RID: 1940
		private ToolStripDropDownButton tsdViewMunu;

		// Token: 0x04000795 RID: 1941
		private ToolStripMenuItem tsmStockByPrice;

		// Token: 0x04000796 RID: 1942
		private ToolStripMenuItem tsmStockInPlay;

		// Token: 0x04000797 RID: 1943
		private ToolStripMenuItem tsmSaleByPrice;

		// Token: 0x04000798 RID: 1944
		private ToolStripMenuItem tsmSaleByTime;

		// Token: 0x04000799 RID: 1945
		private ToolStripMenuItem tsmViewOddLot;

		// Token: 0x0400079A RID: 1946
		private ToolStripSeparator toolStripSeparator4;

		// Token: 0x0400079B RID: 1947
		private ToolStripButton tsbStartMonitor;

		// Token: 0x0400079C RID: 1948
		private ToolStripButton tsbStopMonitor;

		// Token: 0x0400079D RID: 1949
		private ToolStripSeparator toolStripSeparator5;

		// Token: 0x0400079E RID: 1950
		private ToolStripButton tsbClearRow;

		// Token: 0x0400079F RID: 1951
		private ToolStripButton tsbClearAll;

		// Token: 0x040007A0 RID: 1952
		private ToolStripButton tsbAlertOption;

		// Token: 0x040007A1 RID: 1953
		private ToolStripSeparator toolStripSeparator7;

		// Token: 0x040007A2 RID: 1954
		private ToolStripButton tsbClose;

		// Token: 0x040007A3 RID: 1955
		private ToolStripMenuItem tsmiFontDialog;

		// Token: 0x040007A4 RID: 1956
		private ToolStripButton tsbFontDialog;

		// Token: 0x040007A5 RID: 1957
		private ToolStripLabel lbRowcount;

		// Token: 0x040007A6 RID: 1958
		private ToolStripLabel toolStripLabel1;

		// Token: 0x040007A7 RID: 1959
		private string symbolLink;

		// Token: 0x040007A8 RID: 1960
		private string messageTimeArrival;

		// Token: 0x040007A9 RID: 1961
		private frmSystemOption sytemOptionForm;

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x06000B81 RID: 2945
		private delegate void AddAlertItemCallback(AlertItem item);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x06000B85 RID: 2949
		internal delegate void SetFontDialogCallBack(object formActive);
	}
}
