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
using ITSNet.Common.BIZ.RealtimeMessage.TFEX;
using STIControl;
using STIControl.CustomGrid;
using STIControl.SortTableGrid;

namespace i2TradePlus.FixForm
{
	// Token: 0x02000092 RID: 146
	public class frmStockSummary : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x00079B08 File Offset: 0x00077F08
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

		// Token: 0x0600070A RID: 1802 RVA: 0x00079B58 File Offset: 0x00077F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmStockSummary));
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
			ItemGrid itemGrid19 = new ItemGrid();
			ItemGrid itemGrid20 = new ItemGrid();
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
			clsPermission clsPermission = new clsPermission();
			clsPermission clsPermission2 = new clsPermission();
			this.tStripMenu = new ToolStrip();
			this.tslblStockInPlayStock = new ToolStripLabel();
			this.tscbStock = new ToolStripComboBox();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.toolStripLabel1 = new ToolStripLabel();
			this.tscbSelection = new ToolStripComboBox();
			this.tsbtnStockInPlayPrevPage = new ToolStripButton();
			this.tsbtnStockInPlayNextPage = new ToolStripButton();
			this.tslbHour = new ToolStripLabel();
			this.tstxtSaleByTimeSearchTimeHour = new ToolStripTextBox();
			this.tslbMinute = new ToolStripLabel();
			this.tstxtSaleByTimeSearchTimeMinute = new ToolStripTextBox();
			this.tsbtnSaleByTimeClearTime2 = new ToolStripButton();
			this.tssepSaleByTime2 = new ToolStripSeparator();
			this.tsbtnSaleByTimeFirstPage = new ToolStripButton();
			this.tsbtnSaleByTimePrevPage = new ToolStripButton();
			this.tslblSaleByTimePageNo = new ToolStripLabel();
			this.tsbtnSaleByTimeNextPage = new ToolStripButton();
			this.intzaVolumeByBoard = new SortGrid();
			this.intzaLS = new SortGrid();
			this.intzaViewOddLotInfo = new IntzaCustomGrid();
			this.intzaSaleByTime = new SortGrid();
			this.intzaSaleByPrice = new SortGrid();
			this.intzaViewOddLot = new SortGrid();
			this.intzaStockInPlay = new SortGrid();
			this.intzaInfo = new IntzaCustomGrid();
			this.intzaInfoTFEX = new IntzaCustomGrid();
			this.wcGraphVolume = new ucVolumeAtPrice();
			this.tStripMenu.SuspendLayout();
			base.SuspendLayout();
			this.tStripMenu.AllowMerge = false;
			this.tStripMenu.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripMenu.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.tslblStockInPlayStock,
				this.tscbStock,
				this.toolStripSeparator1,
				this.toolStripLabel1,
				this.tscbSelection,
				this.tsbtnStockInPlayPrevPage,
				this.tsbtnStockInPlayNextPage,
				this.tslbHour,
				this.tstxtSaleByTimeSearchTimeHour,
				this.tslbMinute,
				this.tstxtSaleByTimeSearchTimeMinute,
				this.tsbtnSaleByTimeClearTime2,
				this.tssepSaleByTime2,
				this.tsbtnSaleByTimeFirstPage,
				this.tsbtnSaleByTimePrevPage,
				this.tslblSaleByTimePageNo,
				this.tsbtnSaleByTimeNextPage
			});
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Padding = new Padding(1, 1, 1, 2);
			this.tStripMenu.RenderMode = ToolStripRenderMode.System;
			this.tStripMenu.Size = new Size(888, 26);
			this.tStripMenu.TabIndex = 17;
			this.tStripMenu.TabStop = true;
			this.tslblStockInPlayStock.BackColor = Color.Transparent;
			this.tslblStockInPlayStock.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tslblStockInPlayStock.ForeColor = Color.LightGray;
			this.tslblStockInPlayStock.Margin = new Padding(5, 1, 0, 2);
			this.tslblStockInPlayStock.Name = "tslblStockInPlayStock";
			this.tslblStockInPlayStock.Size = new Size(41, 20);
			this.tslblStockInPlayStock.Text = "Symbol";
			this.tscbStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tscbStock.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbStock.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tscbStock.ForeColor = Color.Yellow;
			this.tscbStock.MaxLength = 25;
			this.tscbStock.Name = "tscbStock";
			this.tscbStock.Size = new Size(125, 23);
			this.tscbStock.SelectedIndexChanged += new EventHandler(this.tscbStock_SelectedIndexChanged);
			this.tscbStock.KeyUp += new KeyEventHandler(this.tscbStock_KeyUp);
			this.tscbStock.KeyDown += new KeyEventHandler(this.comboStock_KeyDown);
			this.tscbStock.KeyPress += new KeyPressEventHandler(this.tscbStock_KeyPress);
			this.toolStripSeparator1.Margin = new Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 23);
			this.toolStripLabel1.ForeColor = Color.LightGray;
			this.toolStripLabel1.Margin = new Padding(2, 1, 2, 2);
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new Size(55, 20);
			this.toolStripLabel1.Text = "Selection";
			this.toolStripLabel1.Visible = false;
			this.tscbSelection.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbSelection.ForeColor = Color.LightGray;
			this.tscbSelection.Items.AddRange(new object[]
			{
				"Stock in Play",
				"Sale by Price",
				"Sale by Time",
				"View Oddlot"
			});
			this.tscbSelection.Name = "tscbSelection";
			this.tscbSelection.Size = new Size(130, 23);
			this.tscbSelection.Visible = false;
			this.tscbSelection.SelectedIndexChanged += new EventHandler(this.tscbSelection_SelectedIndexChanged);
			this.tsbtnStockInPlayPrevPage.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsbtnStockInPlayPrevPage.ForeColor = Color.LightGray;
			this.tsbtnStockInPlayPrevPage.Image = (Image)componentResourceManager.GetObject("tsbtnStockInPlayPrevPage.Image");
			this.tsbtnStockInPlayPrevPage.ImageTransparentColor = Color.Magenta;
			this.tsbtnStockInPlayPrevPage.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnStockInPlayPrevPage.Name = "tsbtnStockInPlayPrevPage";
			this.tsbtnStockInPlayPrevPage.Size = new Size(69, 20);
			this.tsbtnStockInPlayPrevPage.Text = "Page Up";
			this.tsbtnStockInPlayPrevPage.ToolTipText = "Up Page";
			this.tsbtnStockInPlayPrevPage.Click += new EventHandler(this.tsbtnStockInPlayPrevPage_Click);
			this.tsbtnStockInPlayNextPage.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsbtnStockInPlayNextPage.ForeColor = Color.LightGray;
			this.tsbtnStockInPlayNextPage.Image = (Image)componentResourceManager.GetObject("tsbtnStockInPlayNextPage.Image");
			this.tsbtnStockInPlayNextPage.ImageTransparentColor = Color.Magenta;
			this.tsbtnStockInPlayNextPage.Name = "tsbtnStockInPlayNextPage";
			this.tsbtnStockInPlayNextPage.Size = new Size(83, 20);
			this.tsbtnStockInPlayNextPage.Text = "Page Down";
			this.tsbtnStockInPlayNextPage.ToolTipText = "Down Page";
			this.tsbtnStockInPlayNextPage.Click += new EventHandler(this.tsbtnStockInPlayNextPage_Click);
			this.tslbHour.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tslbHour.ForeColor = Color.LightGray;
			this.tslbHour.Name = "tslbHour";
			this.tslbHour.Size = new Size(36, 20);
			this.tslbHour.Text = "Hour :";
			this.tstxtSaleByTimeSearchTimeHour.BackColor = Color.FromArgb(45, 45, 45);
			this.tstxtSaleByTimeSearchTimeHour.BorderStyle = BorderStyle.FixedSingle;
			this.tstxtSaleByTimeSearchTimeHour.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tstxtSaleByTimeSearchTimeHour.ForeColor = Color.LightGray;
			this.tstxtSaleByTimeSearchTimeHour.MaxLength = 2;
			this.tstxtSaleByTimeSearchTimeHour.Name = "tstxtSaleByTimeSearchTimeHour";
			this.tstxtSaleByTimeSearchTimeHour.Size = new Size(26, 23);
			this.tstxtSaleByTimeSearchTimeHour.TextBoxTextAlign = HorizontalAlignment.Center;
			this.tstxtSaleByTimeSearchTimeHour.ToolTipText = "{ เวลา ที่ต้องการค้นหา หน่วยเป็น ชม.}";
			this.tstxtSaleByTimeSearchTimeHour.KeyUp += new KeyEventHandler(this.tstxtSaleByTimeSearchTimeHour_KeyUp);
			this.tslbMinute.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tslbMinute.ForeColor = Color.LightGray;
			this.tslbMinute.Margin = new Padding(2, 1, 0, 2);
			this.tslbMinute.Name = "tslbMinute";
			this.tslbMinute.Size = new Size(45, 20);
			this.tslbMinute.Text = "Minute :";
			this.tstxtSaleByTimeSearchTimeMinute.BackColor = Color.FromArgb(45, 45, 45);
			this.tstxtSaleByTimeSearchTimeMinute.BorderStyle = BorderStyle.FixedSingle;
			this.tstxtSaleByTimeSearchTimeMinute.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tstxtSaleByTimeSearchTimeMinute.ForeColor = Color.LightGray;
			this.tstxtSaleByTimeSearchTimeMinute.MaxLength = 2;
			this.tstxtSaleByTimeSearchTimeMinute.Name = "tstxtSaleByTimeSearchTimeMinute";
			this.tstxtSaleByTimeSearchTimeMinute.Size = new Size(26, 23);
			this.tstxtSaleByTimeSearchTimeMinute.TextBoxTextAlign = HorizontalAlignment.Center;
			this.tstxtSaleByTimeSearchTimeMinute.ToolTipText = "{ เวลา ที่ต้องการค้นหา หน่วยเป็น นาที}";
			this.tstxtSaleByTimeSearchTimeMinute.KeyUp += new KeyEventHandler(this.tstxtSaleByTimeSearchTimeMinute_KeyUp);
			this.tsbtnSaleByTimeClearTime2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnSaleByTimeClearTime2.ForeColor = Color.LightGray;
			this.tsbtnSaleByTimeClearTime2.ImageTransparentColor = Color.Magenta;
			this.tsbtnSaleByTimeClearTime2.Margin = new Padding(5, 1, 3, 2);
			this.tsbtnSaleByTimeClearTime2.Name = "tsbtnSaleByTimeClearTime2";
			this.tsbtnSaleByTimeClearTime2.Size = new Size(38, 20);
			this.tsbtnSaleByTimeClearTime2.Text = "Clear";
			this.tsbtnSaleByTimeClearTime2.ToolTipText = "Clear Filter";
			this.tsbtnSaleByTimeClearTime2.Click += new EventHandler(this.tsbtnSaleByTimeClearTime_Click);
			this.tssepSaleByTime2.Margin = new Padding(2, 0, 5, 0);
			this.tssepSaleByTime2.Name = "tssepSaleByTime2";
			this.tssepSaleByTime2.Size = new Size(6, 23);
			this.tsbtnSaleByTimeFirstPage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnSaleByTimeFirstPage.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsbtnSaleByTimeFirstPage.Image = Resources.MoveFirstHS;
			this.tsbtnSaleByTimeFirstPage.ImageTransparentColor = Color.Magenta;
			this.tsbtnSaleByTimeFirstPage.Name = "tsbtnSaleByTimeFirstPage";
			this.tsbtnSaleByTimeFirstPage.Size = new Size(23, 20);
			this.tsbtnSaleByTimeFirstPage.ToolTipText = "First";
			this.tsbtnSaleByTimeFirstPage.Click += new EventHandler(this.tsbtnSaleByTimeFirstPage_Click);
			this.tsbtnSaleByTimePrevPage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnSaleByTimePrevPage.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsbtnSaleByTimePrevPage.Image = Resources.MovePreviousHS;
			this.tsbtnSaleByTimePrevPage.ImageTransparentColor = Color.Magenta;
			this.tsbtnSaleByTimePrevPage.Name = "tsbtnSaleByTimePrevPage";
			this.tsbtnSaleByTimePrevPage.Size = new Size(23, 20);
			this.tsbtnSaleByTimePrevPage.ToolTipText = "Previous";
			this.tsbtnSaleByTimePrevPage.Click += new EventHandler(this.tsbtnSaleByTimePrevPage_Click);
			this.tslblSaleByTimePageNo.BackColor = Color.Transparent;
			this.tslblSaleByTimePageNo.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tslblSaleByTimePageNo.ForeColor = Color.LightGray;
			this.tslblSaleByTimePageNo.Name = "tslblSaleByTimePageNo";
			this.tslblSaleByTimePageNo.Size = new Size(13, 20);
			this.tslblSaleByTimePageNo.Text = "0";
			this.tsbtnSaleByTimeNextPage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnSaleByTimeNextPage.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsbtnSaleByTimeNextPage.Image = Resources.MoveNextHS;
			this.tsbtnSaleByTimeNextPage.ImageTransparentColor = Color.Magenta;
			this.tsbtnSaleByTimeNextPage.Name = "tsbtnSaleByTimeNextPage";
			this.tsbtnSaleByTimeNextPage.Size = new Size(23, 20);
			this.tsbtnSaleByTimeNextPage.ToolTipText = "Next";
			this.tsbtnSaleByTimeNextPage.Click += new EventHandler(this.tsbtnSaleByTimeNextPage_Click);
			this.intzaVolumeByBoard.AllowDrop = true;
			this.intzaVolumeByBoard.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaVolumeByBoard.CanBlink = true;
			this.intzaVolumeByBoard.CanDrag = false;
			this.intzaVolumeByBoard.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "h1";
			columnItem.Text = "";
			columnItem.ValueFormat = FormatType.Label;
			columnItem.Visible = true;
			columnItem.Width = 17;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.DimGray;
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.White;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "deals";
			columnItem2.Text = "Deals";
			columnItem2.ValueFormat = FormatType.Volume;
			columnItem2.Visible = true;
			columnItem2.Width = 20;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.DimGray;
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.White;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "volume";
			columnItem3.Text = "Volume";
			columnItem3.ValueFormat = FormatType.Volume;
			columnItem3.Visible = true;
			columnItem3.Width = 29;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.DimGray;
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.White;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "value";
			columnItem4.Text = "Value";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 34;
			this.intzaVolumeByBoard.Columns.Add(columnItem);
			this.intzaVolumeByBoard.Columns.Add(columnItem2);
			this.intzaVolumeByBoard.Columns.Add(columnItem3);
			this.intzaVolumeByBoard.Columns.Add(columnItem4);
			this.intzaVolumeByBoard.CurrentScroll = 0;
			this.intzaVolumeByBoard.FocusItemIndex = -1;
			this.intzaVolumeByBoard.ForeColor = Color.Black;
			this.intzaVolumeByBoard.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaVolumeByBoard.HeaderPctHeight = 80f;
			this.intzaVolumeByBoard.IsAutoRepaint = true;
			this.intzaVolumeByBoard.IsDrawFullRow = false;
			this.intzaVolumeByBoard.IsDrawGrid = false;
			this.intzaVolumeByBoard.IsDrawHeader = true;
			this.intzaVolumeByBoard.IsScrollable = false;
			this.intzaVolumeByBoard.Location = new Point(612, 278);
			this.intzaVolumeByBoard.MainColumn = "";
			this.intzaVolumeByBoard.Margin = new Padding(0);
			this.intzaVolumeByBoard.Name = "intzaVolumeByBoard";
			this.intzaVolumeByBoard.Rows = 2;
			this.intzaVolumeByBoard.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaVolumeByBoard.RowSelectType = 0;
			this.intzaVolumeByBoard.RowsVisible = 2;
			this.intzaVolumeByBoard.Size = new Size(265, 48);
			this.intzaVolumeByBoard.SortColumnName = "";
			this.intzaVolumeByBoard.SortType = SortType.Desc;
			this.intzaVolumeByBoard.TabIndex = 87;
			this.intzaLS.AllowDrop = true;
			this.intzaLS.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaLS.CanBlink = true;
			this.intzaLS.CanDrag = false;
			this.intzaLS.CanGetMouseMove = false;
			columnItem5.Alignment = StringAlignment.Center;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "side";
			columnItem5.Text = "B/S";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 13;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "volume";
			columnItem6.Text = "Volume";
			columnItem6.ValueFormat = FormatType.Volume;
			columnItem6.Visible = true;
			columnItem6.Width = 36;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "price";
			columnItem7.Text = "Price";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 24;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "time";
			columnItem8.Text = "Time";
			columnItem8.ValueFormat = FormatType.Text;
			columnItem8.Visible = true;
			columnItem8.Width = 27;
			this.intzaLS.Columns.Add(columnItem5);
			this.intzaLS.Columns.Add(columnItem6);
			this.intzaLS.Columns.Add(columnItem7);
			this.intzaLS.Columns.Add(columnItem8);
			this.intzaLS.CurrentScroll = 0;
			this.intzaLS.FocusItemIndex = -1;
			this.intzaLS.ForeColor = Color.Black;
			this.intzaLS.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaLS.HeaderPctHeight = 80f;
			this.intzaLS.IsAutoRepaint = true;
			this.intzaLS.IsDrawFullRow = true;
			this.intzaLS.IsDrawGrid = false;
			this.intzaLS.IsDrawHeader = true;
			this.intzaLS.IsScrollable = false;
			this.intzaLS.Location = new Point(612, 199);
			this.intzaLS.MainColumn = "";
			this.intzaLS.Margin = new Padding(2);
			this.intzaLS.Name = "intzaLS";
			this.intzaLS.Rows = 0;
			this.intzaLS.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaLS.RowSelectType = 0;
			this.intzaLS.RowsVisible = 0;
			this.intzaLS.Size = new Size(265, 77);
			this.intzaLS.SortColumnName = "";
			this.intzaLS.SortType = SortType.Desc;
			this.intzaLS.TabIndex = 86;
			this.intzaViewOddLotInfo.AllowDrop = true;
			this.intzaViewOddLotInfo.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaViewOddLotInfo.CanDrag = false;
			this.intzaViewOddLotInfo.IsAutoRepaint = true;
			this.intzaViewOddLotInfo.IsDroped = false;
			itemGrid.AdjustFontSize = 0f;
			itemGrid.Alignment = StringAlignment.Near;
			itemGrid.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid.Changed = true;
			itemGrid.FieldType = ItemType.Label2;
			itemGrid.FontColor = Color.WhiteSmoke;
			itemGrid.FontStyle = FontStyle.Regular;
			itemGrid.Height = 1f;
			itemGrid.IsBlink = 0;
			itemGrid.Name = "lboddavg";
			itemGrid.Text = "Oddlot Avg";
			itemGrid.ValueFormat = FormatType.Text;
			itemGrid.Visible = true;
			itemGrid.Width = 25;
			itemGrid.X = 0;
			itemGrid.Y = 0f;
			itemGrid2.AdjustFontSize = 0f;
			itemGrid2.Alignment = StringAlignment.Near;
			itemGrid2.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid2.Changed = false;
			itemGrid2.FieldType = ItemType.Text;
			itemGrid2.FontColor = Color.White;
			itemGrid2.FontStyle = FontStyle.Regular;
			itemGrid2.Height = 1f;
			itemGrid2.IsBlink = 0;
			itemGrid2.Name = "oddavg";
			itemGrid2.Text = "";
			itemGrid2.ValueFormat = FormatType.Text;
			itemGrid2.Visible = true;
			itemGrid2.Width = 25;
			itemGrid2.X = 25;
			itemGrid2.Y = 0f;
			itemGrid3.AdjustFontSize = 0f;
			itemGrid3.Alignment = StringAlignment.Near;
			itemGrid3.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid3.Changed = true;
			itemGrid3.FieldType = ItemType.Label2;
			itemGrid3.FontColor = Color.WhiteSmoke;
			itemGrid3.FontStyle = FontStyle.Regular;
			itemGrid3.Height = 1f;
			itemGrid3.IsBlink = 0;
			itemGrid3.Name = "lbodddeal";
			itemGrid3.Text = "Oddlot Deal";
			itemGrid3.ValueFormat = FormatType.Text;
			itemGrid3.Visible = true;
			itemGrid3.Width = 25;
			itemGrid3.X = 0;
			itemGrid3.Y = 1f;
			itemGrid4.AdjustFontSize = 0f;
			itemGrid4.Alignment = StringAlignment.Near;
			itemGrid4.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid4.Changed = true;
			itemGrid4.FieldType = ItemType.Text;
			itemGrid4.FontColor = Color.Yellow;
			itemGrid4.FontStyle = FontStyle.Regular;
			itemGrid4.Height = 1f;
			itemGrid4.IsBlink = 0;
			itemGrid4.Name = "odddeal";
			itemGrid4.Text = "";
			itemGrid4.ValueFormat = FormatType.Text;
			itemGrid4.Visible = true;
			itemGrid4.Width = 25;
			itemGrid4.X = 25;
			itemGrid4.Y = 1f;
			itemGrid5.AdjustFontSize = 0f;
			itemGrid5.Alignment = StringAlignment.Near;
			itemGrid5.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid5.Changed = true;
			itemGrid5.FieldType = ItemType.Label2;
			itemGrid5.FontColor = Color.WhiteSmoke;
			itemGrid5.FontStyle = FontStyle.Regular;
			itemGrid5.Height = 1f;
			itemGrid5.IsBlink = 0;
			itemGrid5.Name = "lboddvol";
			itemGrid5.Text = "Oddlot Volume";
			itemGrid5.ValueFormat = FormatType.Text;
			itemGrid5.Visible = true;
			itemGrid5.Width = 25;
			itemGrid5.X = 0;
			itemGrid5.Y = 2f;
			itemGrid6.AdjustFontSize = 0f;
			itemGrid6.Alignment = StringAlignment.Near;
			itemGrid6.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid6.Changed = true;
			itemGrid6.FieldType = ItemType.Text;
			itemGrid6.FontColor = Color.Yellow;
			itemGrid6.FontStyle = FontStyle.Regular;
			itemGrid6.Height = 1f;
			itemGrid6.IsBlink = 0;
			itemGrid6.Name = "oddvol";
			itemGrid6.Text = "";
			itemGrid6.ValueFormat = FormatType.Text;
			itemGrid6.Visible = true;
			itemGrid6.Width = 25;
			itemGrid6.X = 25;
			itemGrid6.Y = 2f;
			itemGrid7.AdjustFontSize = 0f;
			itemGrid7.Alignment = StringAlignment.Near;
			itemGrid7.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid7.Changed = true;
			itemGrid7.FieldType = ItemType.Label2;
			itemGrid7.FontColor = Color.WhiteSmoke;
			itemGrid7.FontStyle = FontStyle.Regular;
			itemGrid7.Height = 1f;
			itemGrid7.IsBlink = 0;
			itemGrid7.Name = "lboddvalue";
			itemGrid7.Text = "Oddlot Value";
			itemGrid7.ValueFormat = FormatType.Text;
			itemGrid7.Visible = true;
			itemGrid7.Width = 25;
			itemGrid7.X = 50;
			itemGrid7.Y = 2f;
			itemGrid8.AdjustFontSize = 0f;
			itemGrid8.Alignment = StringAlignment.Near;
			itemGrid8.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid8.Changed = true;
			itemGrid8.FieldType = ItemType.Text;
			itemGrid8.FontColor = Color.Yellow;
			itemGrid8.FontStyle = FontStyle.Regular;
			itemGrid8.Height = 1f;
			itemGrid8.IsBlink = 0;
			itemGrid8.Name = "oddval";
			itemGrid8.Text = "";
			itemGrid8.ValueFormat = FormatType.Text;
			itemGrid8.Visible = true;
			itemGrid8.Width = 25;
			itemGrid8.X = 75;
			itemGrid8.Y = 2f;
			itemGrid9.AdjustFontSize = 0f;
			itemGrid9.Alignment = StringAlignment.Near;
			itemGrid9.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid9.Changed = true;
			itemGrid9.FieldType = ItemType.Label2;
			itemGrid9.FontColor = Color.WhiteSmoke;
			itemGrid9.FontStyle = FontStyle.Regular;
			itemGrid9.Height = 1f;
			itemGrid9.IsBlink = 0;
			itemGrid9.Name = "lbceiling";
			itemGrid9.Text = "Ceiling";
			itemGrid9.ValueFormat = FormatType.Text;
			itemGrid9.Visible = true;
			itemGrid9.Width = 25;
			itemGrid9.X = 0;
			itemGrid9.Y = 3f;
			itemGrid10.AdjustFontSize = 0f;
			itemGrid10.Alignment = StringAlignment.Near;
			itemGrid10.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid10.Changed = true;
			itemGrid10.FieldType = ItemType.Text;
			itemGrid10.FontColor = Color.Cyan;
			itemGrid10.FontStyle = FontStyle.Regular;
			itemGrid10.Height = 1f;
			itemGrid10.IsBlink = 0;
			itemGrid10.Name = "ceiling";
			itemGrid10.Text = "";
			itemGrid10.ValueFormat = FormatType.Price;
			itemGrid10.Visible = true;
			itemGrid10.Width = 25;
			itemGrid10.X = 25;
			itemGrid10.Y = 3f;
			itemGrid11.AdjustFontSize = 0f;
			itemGrid11.Alignment = StringAlignment.Near;
			itemGrid11.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid11.Changed = true;
			itemGrid11.FieldType = ItemType.Label2;
			itemGrid11.FontColor = Color.WhiteSmoke;
			itemGrid11.FontStyle = FontStyle.Regular;
			itemGrid11.Height = 1f;
			itemGrid11.IsBlink = 0;
			itemGrid11.Name = "lbfloor";
			itemGrid11.Text = "Floor";
			itemGrid11.ValueFormat = FormatType.Text;
			itemGrid11.Visible = true;
			itemGrid11.Width = 25;
			itemGrid11.X = 50;
			itemGrid11.Y = 3f;
			itemGrid12.AdjustFontSize = 0f;
			itemGrid12.Alignment = StringAlignment.Near;
			itemGrid12.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid12.Changed = true;
			itemGrid12.FieldType = ItemType.Text;
			itemGrid12.FontColor = Color.Magenta;
			itemGrid12.FontStyle = FontStyle.Regular;
			itemGrid12.Height = 1f;
			itemGrid12.IsBlink = 0;
			itemGrid12.Name = "floor";
			itemGrid12.Text = "";
			itemGrid12.ValueFormat = FormatType.Price;
			itemGrid12.Visible = true;
			itemGrid12.Width = 25;
			itemGrid12.X = 75;
			itemGrid12.Y = 3f;
			itemGrid13.AdjustFontSize = 0f;
			itemGrid13.Alignment = StringAlignment.Near;
			itemGrid13.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid13.Changed = true;
			itemGrid13.FieldType = ItemType.Label2;
			itemGrid13.FontColor = Color.WhiteSmoke;
			itemGrid13.FontStyle = FontStyle.Regular;
			itemGrid13.Height = 1f;
			itemGrid13.IsBlink = 0;
			itemGrid13.Name = "lbTotOddMktVol";
			itemGrid13.Text = "Total Odd Mkt Volume";
			itemGrid13.ValueFormat = FormatType.Text;
			itemGrid13.Visible = true;
			itemGrid13.Width = 30;
			itemGrid13.X = 50;
			itemGrid13.Y = 0f;
			itemGrid14.AdjustFontSize = 0f;
			itemGrid14.Alignment = StringAlignment.Near;
			itemGrid14.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid14.Changed = true;
			itemGrid14.FieldType = ItemType.Text;
			itemGrid14.FontColor = Color.Yellow;
			itemGrid14.FontStyle = FontStyle.Regular;
			itemGrid14.Height = 1f;
			itemGrid14.IsBlink = 0;
			itemGrid14.Name = "totvolume";
			itemGrid14.Text = "";
			itemGrid14.ValueFormat = FormatType.Volume;
			itemGrid14.Visible = true;
			itemGrid14.Width = 20;
			itemGrid14.X = 80;
			itemGrid14.Y = 0f;
			itemGrid15.AdjustFontSize = 0f;
			itemGrid15.Alignment = StringAlignment.Near;
			itemGrid15.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid15.Changed = true;
			itemGrid15.FieldType = ItemType.Label2;
			itemGrid15.FontColor = Color.WhiteSmoke;
			itemGrid15.FontStyle = FontStyle.Regular;
			itemGrid15.Height = 1f;
			itemGrid15.IsBlink = 0;
			itemGrid15.Name = "lbTotOddMktVal";
			itemGrid15.Text = "Total Odd Mkt Value";
			itemGrid15.ValueFormat = FormatType.Text;
			itemGrid15.Visible = true;
			itemGrid15.Width = 30;
			itemGrid15.X = 50;
			itemGrid15.Y = 1f;
			itemGrid16.AdjustFontSize = 0f;
			itemGrid16.Alignment = StringAlignment.Near;
			itemGrid16.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid16.Changed = true;
			itemGrid16.FieldType = ItemType.Text;
			itemGrid16.FontColor = Color.Yellow;
			itemGrid16.FontStyle = FontStyle.Regular;
			itemGrid16.Height = 1f;
			itemGrid16.IsBlink = 0;
			itemGrid16.Name = "totvalue";
			itemGrid16.Text = "";
			itemGrid16.ValueFormat = FormatType.Volume;
			itemGrid16.Visible = true;
			itemGrid16.Width = 20;
			itemGrid16.X = 80;
			itemGrid16.Y = 1f;
			itemGrid17.AdjustFontSize = 0f;
			itemGrid17.Alignment = StringAlignment.Near;
			itemGrid17.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid17.Changed = true;
			itemGrid17.FieldType = ItemType.Label2;
			itemGrid17.FontColor = Color.WhiteSmoke;
			itemGrid17.FontStyle = FontStyle.Regular;
			itemGrid17.Height = 1f;
			itemGrid17.IsBlink = 0;
			itemGrid17.Name = "lblast";
			itemGrid17.Text = "Last";
			itemGrid17.ValueFormat = FormatType.Text;
			itemGrid17.Visible = true;
			itemGrid17.Width = 25;
			itemGrid17.X = 0;
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
			itemGrid18.Name = "oddlast";
			itemGrid18.Text = "";
			itemGrid18.ValueFormat = FormatType.Text;
			itemGrid18.Visible = true;
			itemGrid18.Width = 25;
			itemGrid18.X = 25;
			itemGrid18.Y = 4f;
			itemGrid19.AdjustFontSize = 0f;
			itemGrid19.Alignment = StringAlignment.Near;
			itemGrid19.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid19.Changed = true;
			itemGrid19.FieldType = ItemType.Label2;
			itemGrid19.FontColor = Color.White;
			itemGrid19.FontStyle = FontStyle.Regular;
			itemGrid19.Height = 1f;
			itemGrid19.IsBlink = 0;
			itemGrid19.Name = "lbprior";
			itemGrid19.Text = "Prev";
			itemGrid19.ValueFormat = FormatType.Text;
			itemGrid19.Visible = true;
			itemGrid19.Width = 25;
			itemGrid19.X = 50;
			itemGrid19.Y = 4f;
			itemGrid20.AdjustFontSize = 0f;
			itemGrid20.Alignment = StringAlignment.Near;
			itemGrid20.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid20.Changed = true;
			itemGrid20.FieldType = ItemType.Text;
			itemGrid20.FontColor = Color.Yellow;
			itemGrid20.FontStyle = FontStyle.Regular;
			itemGrid20.Height = 1f;
			itemGrid20.IsBlink = 0;
			itemGrid20.Name = "prior";
			itemGrid20.Text = "";
			itemGrid20.ValueFormat = FormatType.Price;
			itemGrid20.Visible = true;
			itemGrid20.Width = 25;
			itemGrid20.X = 75;
			itemGrid20.Y = 4f;
			this.intzaViewOddLotInfo.Items.Add(itemGrid);
			this.intzaViewOddLotInfo.Items.Add(itemGrid2);
			this.intzaViewOddLotInfo.Items.Add(itemGrid3);
			this.intzaViewOddLotInfo.Items.Add(itemGrid4);
			this.intzaViewOddLotInfo.Items.Add(itemGrid5);
			this.intzaViewOddLotInfo.Items.Add(itemGrid6);
			this.intzaViewOddLotInfo.Items.Add(itemGrid7);
			this.intzaViewOddLotInfo.Items.Add(itemGrid8);
			this.intzaViewOddLotInfo.Items.Add(itemGrid9);
			this.intzaViewOddLotInfo.Items.Add(itemGrid10);
			this.intzaViewOddLotInfo.Items.Add(itemGrid11);
			this.intzaViewOddLotInfo.Items.Add(itemGrid12);
			this.intzaViewOddLotInfo.Items.Add(itemGrid13);
			this.intzaViewOddLotInfo.Items.Add(itemGrid14);
			this.intzaViewOddLotInfo.Items.Add(itemGrid15);
			this.intzaViewOddLotInfo.Items.Add(itemGrid16);
			this.intzaViewOddLotInfo.Items.Add(itemGrid17);
			this.intzaViewOddLotInfo.Items.Add(itemGrid18);
			this.intzaViewOddLotInfo.Items.Add(itemGrid19);
			this.intzaViewOddLotInfo.Items.Add(itemGrid20);
			this.intzaViewOddLotInfo.LineColor = Color.Red;
			this.intzaViewOddLotInfo.Location = new Point(38, 43);
			this.intzaViewOddLotInfo.Margin = new Padding(0);
			this.intzaViewOddLotInfo.Name = "intzaViewOddLotInfo";
			this.intzaViewOddLotInfo.Size = new Size(572, 87);
			this.intzaViewOddLotInfo.TabIndex = 10;
			this.intzaSaleByTime.AllowDrop = true;
			this.intzaSaleByTime.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaSaleByTime.CanBlink = true;
			this.intzaSaleByTime.CanDrag = false;
			this.intzaSaleByTime.CanGetMouseMove = false;
			columnItem9.Alignment = StringAlignment.Center;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "time";
			columnItem9.Text = "Time";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = true;
			columnItem9.Width = 22;
			columnItem10.Alignment = StringAlignment.Center;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.LightGray;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "side";
			columnItem10.Text = "B/S";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = true;
			columnItem10.Width = 11;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "volume";
			columnItem11.Text = "Volume";
			columnItem11.ValueFormat = FormatType.Volume;
			columnItem11.Visible = true;
			columnItem11.Width = 22;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "price";
			columnItem12.Text = "Price";
			columnItem12.ValueFormat = FormatType.Price;
			columnItem12.Visible = true;
			columnItem12.Width = 15;
			columnItem13.Alignment = StringAlignment.Far;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.ColumnAlignment = StringAlignment.Center;
			columnItem13.FontColor = Color.LightGray;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "chg";
			columnItem13.Text = "Change";
			columnItem13.ValueFormat = FormatType.ChangePrice;
			columnItem13.Visible = true;
			columnItem13.Width = 15;
			columnItem14.Alignment = StringAlignment.Far;
			columnItem14.BackColor = Color.FromArgb(64, 64, 64);
			columnItem14.ColumnAlignment = StringAlignment.Center;
			columnItem14.FontColor = Color.LightGray;
			columnItem14.MyStyle = FontStyle.Regular;
			columnItem14.Name = "avg";
			columnItem14.Text = "Average";
			columnItem14.ValueFormat = FormatType.Price;
			columnItem14.Visible = true;
			columnItem14.Width = 15;
			this.intzaSaleByTime.Columns.Add(columnItem9);
			this.intzaSaleByTime.Columns.Add(columnItem10);
			this.intzaSaleByTime.Columns.Add(columnItem11);
			this.intzaSaleByTime.Columns.Add(columnItem12);
			this.intzaSaleByTime.Columns.Add(columnItem13);
			this.intzaSaleByTime.Columns.Add(columnItem14);
			this.intzaSaleByTime.CurrentScroll = 0;
			this.intzaSaleByTime.FocusItemIndex = -1;
			this.intzaSaleByTime.ForeColor = Color.Black;
			this.intzaSaleByTime.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaSaleByTime.HeaderPctHeight = 100f;
			this.intzaSaleByTime.IsAutoRepaint = true;
			this.intzaSaleByTime.IsDrawFullRow = false;
			this.intzaSaleByTime.IsDrawGrid = true;
			this.intzaSaleByTime.IsDrawHeader = true;
			this.intzaSaleByTime.IsScrollable = false;
			this.intzaSaleByTime.Location = new Point(12, 74);
			this.intzaSaleByTime.MainColumn = "";
			this.intzaSaleByTime.Name = "intzaSaleByTime";
			this.intzaSaleByTime.Rows = 0;
			this.intzaSaleByTime.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaSaleByTime.RowSelectType = 0;
			this.intzaSaleByTime.RowsVisible = 0;
			this.intzaSaleByTime.Size = new Size(540, 85);
			this.intzaSaleByTime.SortColumnName = "";
			this.intzaSaleByTime.SortType = SortType.Desc;
			this.intzaSaleByTime.TabIndex = 28;
			this.intzaSaleByTime.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaSaleByTime_TableMouseClick);
			this.intzaSaleByPrice.AllowDrop = true;
			this.intzaSaleByPrice.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaSaleByPrice.CanBlink = true;
			this.intzaSaleByPrice.CanDrag = false;
			this.intzaSaleByPrice.CanGetMouseMove = false;
			columnItem15.Alignment = StringAlignment.Far;
			columnItem15.BackColor = Color.FromArgb(64, 64, 64);
			columnItem15.ColumnAlignment = StringAlignment.Center;
			columnItem15.FontColor = Color.LightGray;
			columnItem15.MyStyle = FontStyle.Regular;
			columnItem15.Name = "buy_deal";
			columnItem15.Text = "Deals";
			columnItem15.ValueFormat = FormatType.Volume;
			columnItem15.Visible = true;
			columnItem15.Width = 10;
			columnItem16.Alignment = StringAlignment.Far;
			columnItem16.BackColor = Color.FromArgb(64, 64, 64);
			columnItem16.ColumnAlignment = StringAlignment.Center;
			columnItem16.FontColor = Color.LightGray;
			columnItem16.MyStyle = FontStyle.Regular;
			columnItem16.Name = "buy_vol";
			columnItem16.Text = "Buy Volume";
			columnItem16.ValueFormat = FormatType.Volume;
			columnItem16.Visible = true;
			columnItem16.Width = 17;
			columnItem17.Alignment = StringAlignment.Center;
			columnItem17.BackColor = Color.FromArgb(64, 64, 64);
			columnItem17.ColumnAlignment = StringAlignment.Center;
			columnItem17.FontColor = Color.LightGray;
			columnItem17.MyStyle = FontStyle.Regular;
			columnItem17.Name = "price";
			columnItem17.Text = "Price";
			columnItem17.ValueFormat = FormatType.Text;
			columnItem17.Visible = true;
			columnItem17.Width = 12;
			columnItem18.Alignment = StringAlignment.Far;
			columnItem18.BackColor = Color.FromArgb(64, 64, 64);
			columnItem18.ColumnAlignment = StringAlignment.Center;
			columnItem18.FontColor = Color.LightGray;
			columnItem18.MyStyle = FontStyle.Regular;
			columnItem18.Name = "sell_vol";
			columnItem18.Text = "Sell Volume";
			columnItem18.ValueFormat = FormatType.Volume;
			columnItem18.Visible = true;
			columnItem18.Width = 17;
			columnItem19.Alignment = StringAlignment.Far;
			columnItem19.BackColor = Color.FromArgb(64, 64, 64);
			columnItem19.ColumnAlignment = StringAlignment.Center;
			columnItem19.FontColor = Color.LightGray;
			columnItem19.MyStyle = FontStyle.Regular;
			columnItem19.Name = "sell_deal";
			columnItem19.Text = "Deals";
			columnItem19.ValueFormat = FormatType.Volume;
			columnItem19.Visible = true;
			columnItem19.Width = 10;
			columnItem20.Alignment = StringAlignment.Far;
			columnItem20.BackColor = Color.FromArgb(64, 64, 64);
			columnItem20.ColumnAlignment = StringAlignment.Center;
			columnItem20.FontColor = Color.LightGray;
			columnItem20.MyStyle = FontStyle.Regular;
			columnItem20.Name = "mvol";
			columnItem20.Text = "Volume";
			columnItem20.ValueFormat = FormatType.Volume;
			columnItem20.Visible = true;
			columnItem20.Width = 15;
			columnItem21.Alignment = StringAlignment.Far;
			columnItem21.BackColor = Color.FromArgb(64, 64, 64);
			columnItem21.ColumnAlignment = StringAlignment.Center;
			columnItem21.FontColor = Color.LightGray;
			columnItem21.MyStyle = FontStyle.Regular;
			columnItem21.Name = "mval";
			columnItem21.Text = "Value";
			columnItem21.ValueFormat = FormatType.Volume;
			columnItem21.Visible = true;
			columnItem21.Width = 19;
			this.intzaSaleByPrice.Columns.Add(columnItem15);
			this.intzaSaleByPrice.Columns.Add(columnItem16);
			this.intzaSaleByPrice.Columns.Add(columnItem17);
			this.intzaSaleByPrice.Columns.Add(columnItem18);
			this.intzaSaleByPrice.Columns.Add(columnItem19);
			this.intzaSaleByPrice.Columns.Add(columnItem20);
			this.intzaSaleByPrice.Columns.Add(columnItem21);
			this.intzaSaleByPrice.CurrentScroll = 0;
			this.intzaSaleByPrice.FocusItemIndex = -1;
			this.intzaSaleByPrice.ForeColor = Color.Black;
			this.intzaSaleByPrice.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaSaleByPrice.HeaderPctHeight = 80f;
			this.intzaSaleByPrice.IsAutoRepaint = true;
			this.intzaSaleByPrice.IsDrawFullRow = false;
			this.intzaSaleByPrice.IsDrawGrid = true;
			this.intzaSaleByPrice.IsDrawHeader = true;
			this.intzaSaleByPrice.IsScrollable = true;
			this.intzaSaleByPrice.Location = new Point(12, 165);
			this.intzaSaleByPrice.MainColumn = "";
			this.intzaSaleByPrice.Name = "intzaSaleByPrice";
			this.intzaSaleByPrice.Rows = 0;
			this.intzaSaleByPrice.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaSaleByPrice.RowSelectType = 0;
			this.intzaSaleByPrice.RowsVisible = 0;
			this.intzaSaleByPrice.Size = new Size(540, 53);
			this.intzaSaleByPrice.SortColumnName = "";
			this.intzaSaleByPrice.SortType = SortType.Desc;
			this.intzaSaleByPrice.TabIndex = 27;
			this.intzaSaleByPrice.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaSaleByPrice_TableMouseClick);
			this.intzaViewOddLot.AllowDrop = true;
			this.intzaViewOddLot.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaViewOddLot.CanBlink = true;
			this.intzaViewOddLot.CanDrag = false;
			this.intzaViewOddLot.CanGetMouseMove = false;
			columnItem22.Alignment = StringAlignment.Center;
			columnItem22.BackColor = Color.FromArgb(64, 64, 64);
			columnItem22.ColumnAlignment = StringAlignment.Center;
			columnItem22.FontColor = Color.LightGray;
			columnItem22.MyStyle = FontStyle.Regular;
			columnItem22.Name = "bid_vol";
			columnItem22.Text = "Volume";
			columnItem22.ValueFormat = FormatType.Volume;
			columnItem22.Visible = true;
			columnItem22.Width = 30;
			columnItem23.Alignment = StringAlignment.Center;
			columnItem23.BackColor = Color.FromArgb(64, 64, 64);
			columnItem23.ColumnAlignment = StringAlignment.Center;
			columnItem23.FontColor = Color.LightGray;
			columnItem23.MyStyle = FontStyle.Regular;
			columnItem23.Name = "bid";
			columnItem23.Text = "Bid";
			columnItem23.ValueFormat = FormatType.Price;
			columnItem23.Visible = true;
			columnItem23.Width = 20;
			columnItem24.Alignment = StringAlignment.Center;
			columnItem24.BackColor = Color.FromArgb(64, 64, 64);
			columnItem24.ColumnAlignment = StringAlignment.Center;
			columnItem24.FontColor = Color.LightGray;
			columnItem24.MyStyle = FontStyle.Regular;
			columnItem24.Name = "offer";
			columnItem24.Text = "Offer";
			columnItem24.ValueFormat = FormatType.Price;
			columnItem24.Visible = true;
			columnItem24.Width = 20;
			columnItem25.Alignment = StringAlignment.Center;
			columnItem25.BackColor = Color.FromArgb(64, 64, 64);
			columnItem25.ColumnAlignment = StringAlignment.Center;
			columnItem25.FontColor = Color.LightGray;
			columnItem25.MyStyle = FontStyle.Regular;
			columnItem25.Name = "offer_vol";
			columnItem25.Text = "Volume";
			columnItem25.ValueFormat = FormatType.Volume;
			columnItem25.Visible = true;
			columnItem25.Width = 30;
			this.intzaViewOddLot.Columns.Add(columnItem22);
			this.intzaViewOddLot.Columns.Add(columnItem23);
			this.intzaViewOddLot.Columns.Add(columnItem24);
			this.intzaViewOddLot.Columns.Add(columnItem25);
			this.intzaViewOddLot.CurrentScroll = 0;
			this.intzaViewOddLot.FocusItemIndex = -1;
			this.intzaViewOddLot.ForeColor = Color.Black;
			this.intzaViewOddLot.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaViewOddLot.HeaderPctHeight = 100f;
			this.intzaViewOddLot.IsAutoRepaint = true;
			this.intzaViewOddLot.IsDrawFullRow = false;
			this.intzaViewOddLot.IsDrawGrid = true;
			this.intzaViewOddLot.IsDrawHeader = true;
			this.intzaViewOddLot.IsScrollable = true;
			this.intzaViewOddLot.Location = new Point(9, 336);
			this.intzaViewOddLot.MainColumn = "";
			this.intzaViewOddLot.Name = "intzaViewOddLot";
			this.intzaViewOddLot.Rows = 5;
			this.intzaViewOddLot.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaViewOddLot.RowSelectType = 0;
			this.intzaViewOddLot.RowsVisible = 5;
			this.intzaViewOddLot.Size = new Size(543, 73);
			this.intzaViewOddLot.SortColumnName = "";
			this.intzaViewOddLot.SortType = SortType.Desc;
			this.intzaViewOddLot.TabIndex = 26;
			this.intzaStockInPlay.AllowDrop = true;
			this.intzaStockInPlay.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaStockInPlay.CanBlink = true;
			this.intzaStockInPlay.CanDrag = false;
			this.intzaStockInPlay.CanGetMouseMove = false;
			columnItem26.Alignment = StringAlignment.Center;
			columnItem26.BackColor = Color.FromArgb(64, 64, 64);
			columnItem26.ColumnAlignment = StringAlignment.Center;
			columnItem26.FontColor = Color.LightGray;
			columnItem26.MyStyle = FontStyle.Regular;
			columnItem26.Name = "buy_deal";
			columnItem26.Text = "Deals";
			columnItem26.ValueFormat = FormatType.Volume;
			columnItem26.Visible = true;
			columnItem26.Width = 10;
			columnItem27.Alignment = StringAlignment.Far;
			columnItem27.BackColor = Color.FromArgb(64, 64, 64);
			columnItem27.ColumnAlignment = StringAlignment.Center;
			columnItem27.FontColor = Color.LightGray;
			columnItem27.MyStyle = FontStyle.Regular;
			columnItem27.Name = "buy_volume";
			columnItem27.Text = "Buy Volume";
			columnItem27.ValueFormat = FormatType.Volume;
			columnItem27.Visible = true;
			columnItem27.Width = 17;
			columnItem28.Alignment = StringAlignment.Far;
			columnItem28.BackColor = Color.FromArgb(64, 64, 64);
			columnItem28.ColumnAlignment = StringAlignment.Center;
			columnItem28.FontColor = Color.LightGray;
			columnItem28.MyStyle = FontStyle.Regular;
			columnItem28.Name = "bid";
			columnItem28.Text = "Bid Volume";
			columnItem28.ValueFormat = FormatType.BidOfferVolume;
			columnItem28.Visible = true;
			columnItem28.Width = 17;
			columnItem29.Alignment = StringAlignment.Center;
			columnItem29.BackColor = Color.FromArgb(64, 64, 64);
			columnItem29.ColumnAlignment = StringAlignment.Center;
			columnItem29.FontColor = Color.LightGray;
			columnItem29.MyStyle = FontStyle.Regular;
			columnItem29.Name = "price";
			columnItem29.Text = "Price";
			columnItem29.ValueFormat = FormatType.Text;
			columnItem29.Visible = true;
			columnItem29.Width = 12;
			columnItem30.Alignment = StringAlignment.Far;
			columnItem30.BackColor = Color.FromArgb(64, 64, 64);
			columnItem30.ColumnAlignment = StringAlignment.Center;
			columnItem30.FontColor = Color.LightGray;
			columnItem30.MyStyle = FontStyle.Regular;
			columnItem30.Name = "offer";
			columnItem30.Text = "Offer Volume";
			columnItem30.ValueFormat = FormatType.BidOfferVolume;
			columnItem30.Visible = true;
			columnItem30.Width = 17;
			columnItem31.Alignment = StringAlignment.Far;
			columnItem31.BackColor = Color.FromArgb(64, 64, 64);
			columnItem31.ColumnAlignment = StringAlignment.Center;
			columnItem31.FontColor = Color.LightGray;
			columnItem31.MyStyle = FontStyle.Regular;
			columnItem31.Name = "sell_vol";
			columnItem31.Text = "Sell Volume";
			columnItem31.ValueFormat = FormatType.Volume;
			columnItem31.Visible = true;
			columnItem31.Width = 17;
			columnItem32.Alignment = StringAlignment.Center;
			columnItem32.BackColor = Color.FromArgb(64, 64, 64);
			columnItem32.ColumnAlignment = StringAlignment.Center;
			columnItem32.FontColor = Color.LightGray;
			columnItem32.MyStyle = FontStyle.Regular;
			columnItem32.Name = "sell_deal";
			columnItem32.Text = "Deals";
			columnItem32.ValueFormat = FormatType.Volume;
			columnItem32.Visible = true;
			columnItem32.Width = 10;
			this.intzaStockInPlay.Columns.Add(columnItem26);
			this.intzaStockInPlay.Columns.Add(columnItem27);
			this.intzaStockInPlay.Columns.Add(columnItem28);
			this.intzaStockInPlay.Columns.Add(columnItem29);
			this.intzaStockInPlay.Columns.Add(columnItem30);
			this.intzaStockInPlay.Columns.Add(columnItem31);
			this.intzaStockInPlay.Columns.Add(columnItem32);
			this.intzaStockInPlay.CurrentScroll = 0;
			this.intzaStockInPlay.FocusItemIndex = -1;
			this.intzaStockInPlay.ForeColor = Color.Black;
			this.intzaStockInPlay.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaStockInPlay.HeaderPctHeight = 80f;
			this.intzaStockInPlay.IsAutoRepaint = true;
			this.intzaStockInPlay.IsDrawFullRow = false;
			this.intzaStockInPlay.IsDrawGrid = true;
			this.intzaStockInPlay.IsDrawHeader = true;
			this.intzaStockInPlay.IsScrollable = false;
			this.intzaStockInPlay.Location = new Point(12, 252);
			this.intzaStockInPlay.MainColumn = "";
			this.intzaStockInPlay.Name = "intzaStockInPlay";
			this.intzaStockInPlay.Rows = 0;
			this.intzaStockInPlay.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaStockInPlay.RowSelectType = 0;
			this.intzaStockInPlay.RowsVisible = 0;
			this.intzaStockInPlay.Size = new Size(540, 53);
			this.intzaStockInPlay.SortColumnName = "";
			this.intzaStockInPlay.SortType = SortType.Desc;
			this.intzaStockInPlay.TabIndex = 25;
			this.intzaStockInPlay.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaStockInPlay_TableMouseClick);
			this.intzaInfo.AllowDrop = true;
			this.intzaInfo.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo.CanDrag = false;
			this.intzaInfo.IsAutoRepaint = true;
			this.intzaInfo.IsDroped = false;
			itemGrid21.AdjustFontSize = 0f;
			itemGrid21.Alignment = StringAlignment.Near;
			itemGrid21.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid21.Changed = true;
			itemGrid21.FieldType = ItemType.Label2;
			itemGrid21.FontColor = Color.Gainsboro;
			itemGrid21.FontStyle = FontStyle.Regular;
			itemGrid21.Height = 1f;
			itemGrid21.IsBlink = 0;
			itemGrid21.Name = "lb_openvol";
			itemGrid21.Text = "OpnVol";
			itemGrid21.ValueFormat = FormatType.Text;
			itemGrid21.Visible = true;
			itemGrid21.Width = 22;
			itemGrid21.X = 0;
			itemGrid21.Y = 0f;
			itemGrid22.AdjustFontSize = 0f;
			itemGrid22.Alignment = StringAlignment.Far;
			itemGrid22.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid22.Changed = true;
			itemGrid22.FieldType = ItemType.Text;
			itemGrid22.FontColor = Color.Yellow;
			itemGrid22.FontStyle = FontStyle.Regular;
			itemGrid22.Height = 1f;
			itemGrid22.IsBlink = 0;
			itemGrid22.Name = "open_vol";
			itemGrid22.Text = "";
			itemGrid22.ValueFormat = FormatType.Volume;
			itemGrid22.Visible = true;
			itemGrid22.Width = 35;
			itemGrid22.X = 25;
			itemGrid22.Y = 0f;
			itemGrid23.AdjustFontSize = -2f;
			itemGrid23.Alignment = StringAlignment.Far;
			itemGrid23.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid23.Changed = true;
			itemGrid23.FieldType = ItemType.Text;
			itemGrid23.FontColor = Color.Yellow;
			itemGrid23.FontStyle = FontStyle.Regular;
			itemGrid23.Height = 1f;
			itemGrid23.IsBlink = 0;
			itemGrid23.Name = "p_open_vol";
			itemGrid23.Text = "";
			itemGrid23.ValueFormat = FormatType.Text;
			itemGrid23.Visible = false;
			itemGrid23.Width = 19;
			itemGrid23.X = 57;
			itemGrid23.Y = 0f;
			itemGrid24.AdjustFontSize = 0f;
			itemGrid24.Alignment = StringAlignment.Near;
			itemGrid24.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid24.Changed = true;
			itemGrid24.FieldType = ItemType.Label2;
			itemGrid24.FontColor = Color.Gainsboro;
			itemGrid24.FontStyle = FontStyle.Regular;
			itemGrid24.Height = 1f;
			itemGrid24.IsBlink = 0;
			itemGrid24.Name = "lb_buyvol";
			itemGrid24.Text = "BuyVol";
			itemGrid24.ValueFormat = FormatType.Text;
			itemGrid24.Visible = true;
			itemGrid24.Width = 22;
			itemGrid24.X = 0;
			itemGrid24.Y = 1.2f;
			itemGrid25.AdjustFontSize = 0f;
			itemGrid25.Alignment = StringAlignment.Far;
			itemGrid25.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid25.Changed = true;
			itemGrid25.FieldType = ItemType.Text;
			itemGrid25.FontColor = Color.Lime;
			itemGrid25.FontStyle = FontStyle.Regular;
			itemGrid25.Height = 1f;
			itemGrid25.IsBlink = 0;
			itemGrid25.Name = "buy_vol";
			itemGrid25.Text = "";
			itemGrid25.ValueFormat = FormatType.Volume;
			itemGrid25.Visible = true;
			itemGrid25.Width = 35;
			itemGrid25.X = 25;
			itemGrid25.Y = 1.2f;
			itemGrid26.AdjustFontSize = -2f;
			itemGrid26.Alignment = StringAlignment.Far;
			itemGrid26.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid26.Changed = true;
			itemGrid26.FieldType = ItemType.Text;
			itemGrid26.FontColor = Color.Lime;
			itemGrid26.FontStyle = FontStyle.Regular;
			itemGrid26.Height = 1f;
			itemGrid26.IsBlink = 0;
			itemGrid26.Name = "p_buy_vol";
			itemGrid26.Text = "";
			itemGrid26.ValueFormat = FormatType.Text;
			itemGrid26.Visible = false;
			itemGrid26.Width = 19;
			itemGrid26.X = 57;
			itemGrid26.Y = 1.2f;
			itemGrid27.AdjustFontSize = 0f;
			itemGrid27.Alignment = StringAlignment.Near;
			itemGrid27.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid27.Changed = true;
			itemGrid27.FieldType = ItemType.Label2;
			itemGrid27.FontColor = Color.Gainsboro;
			itemGrid27.FontStyle = FontStyle.Regular;
			itemGrid27.Height = 1f;
			itemGrid27.IsBlink = 0;
			itemGrid27.Name = "lb_selvol";
			itemGrid27.Text = "SelVol";
			itemGrid27.ValueFormat = FormatType.Text;
			itemGrid27.Visible = true;
			itemGrid27.Width = 22;
			itemGrid27.X = 0;
			itemGrid27.Y = 2.4f;
			itemGrid28.AdjustFontSize = 0f;
			itemGrid28.Alignment = StringAlignment.Far;
			itemGrid28.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid28.Changed = true;
			itemGrid28.FieldType = ItemType.Text;
			itemGrid28.FontColor = Color.Red;
			itemGrid28.FontStyle = FontStyle.Regular;
			itemGrid28.Height = 1f;
			itemGrid28.IsBlink = 0;
			itemGrid28.Name = "sel_vol";
			itemGrid28.Text = "";
			itemGrid28.ValueFormat = FormatType.Volume;
			itemGrid28.Visible = true;
			itemGrid28.Width = 35;
			itemGrid28.X = 25;
			itemGrid28.Y = 2.4f;
			itemGrid29.AdjustFontSize = -2f;
			itemGrid29.Alignment = StringAlignment.Far;
			itemGrid29.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid29.Changed = true;
			itemGrid29.FieldType = ItemType.Text;
			itemGrid29.FontColor = Color.Red;
			itemGrid29.FontStyle = FontStyle.Regular;
			itemGrid29.Height = 1f;
			itemGrid29.IsBlink = 0;
			itemGrid29.Name = "p_sel_vol";
			itemGrid29.Text = "";
			itemGrid29.ValueFormat = FormatType.Text;
			itemGrid29.Visible = false;
			itemGrid29.Width = 19;
			itemGrid29.X = 57;
			itemGrid29.Y = 2.4f;
			itemGrid30.AdjustFontSize = 0f;
			itemGrid30.Alignment = StringAlignment.Near;
			itemGrid30.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid30.Changed = false;
			itemGrid30.FieldType = ItemType.Text;
			itemGrid30.FontColor = Color.White;
			itemGrid30.FontStyle = FontStyle.Regular;
			itemGrid30.Height = 3.4f;
			itemGrid30.IsBlink = 0;
			itemGrid30.Name = "pie";
			itemGrid30.Text = "";
			itemGrid30.ValueFormat = FormatType.PieChartNew;
			itemGrid30.Visible = true;
			itemGrid30.Width = 40;
			itemGrid30.X = 60;
			itemGrid30.Y = 0f;
			itemGrid31.AdjustFontSize = 0f;
			itemGrid31.Alignment = StringAlignment.Near;
			itemGrid31.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid31.Changed = true;
			itemGrid31.FieldType = ItemType.Label2;
			itemGrid31.FontColor = Color.Gainsboro;
			itemGrid31.FontStyle = FontStyle.Regular;
			itemGrid31.Height = 1f;
			itemGrid31.IsBlink = 0;
			itemGrid31.Name = "lb_prior";
			itemGrid31.Text = "Prev";
			itemGrid31.ValueFormat = FormatType.Text;
			itemGrid31.Visible = true;
			itemGrid31.Width = 22;
			itemGrid31.X = 0;
			itemGrid31.Y = 3.6f;
			itemGrid32.AdjustFontSize = 0f;
			itemGrid32.Alignment = StringAlignment.Near;
			itemGrid32.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid32.Changed = true;
			itemGrid32.FieldType = ItemType.Text;
			itemGrid32.FontColor = Color.Yellow;
			itemGrid32.FontStyle = FontStyle.Regular;
			itemGrid32.Height = 1f;
			itemGrid32.IsBlink = 0;
			itemGrid32.Name = "prior";
			itemGrid32.Text = "";
			itemGrid32.ValueFormat = FormatType.Text;
			itemGrid32.Visible = true;
			itemGrid32.Width = 23;
			itemGrid32.X = 22;
			itemGrid32.Y = 3.6f;
			itemGrid33.AdjustFontSize = 0f;
			itemGrid33.Alignment = StringAlignment.Near;
			itemGrid33.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid33.Changed = true;
			itemGrid33.FieldType = ItemType.Label2;
			itemGrid33.FontColor = Color.Gainsboro;
			itemGrid33.FontStyle = FontStyle.Regular;
			itemGrid33.Height = 1f;
			itemGrid33.IsBlink = 0;
			itemGrid33.Name = "lb_avg";
			itemGrid33.Text = "Avg";
			itemGrid33.ValueFormat = FormatType.Text;
			itemGrid33.Visible = false;
			itemGrid33.Width = 25;
			itemGrid33.X = 48;
			itemGrid33.Y = 3.6f;
			itemGrid34.AdjustFontSize = 0f;
			itemGrid34.Alignment = StringAlignment.Near;
			itemGrid34.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid34.Changed = false;
			itemGrid34.FieldType = ItemType.Text;
			itemGrid34.FontColor = Color.White;
			itemGrid34.FontStyle = FontStyle.Regular;
			itemGrid34.Height = 1f;
			itemGrid34.IsBlink = 0;
			itemGrid34.Name = "avg";
			itemGrid34.Text = "";
			itemGrid34.ValueFormat = FormatType.Price;
			itemGrid34.Visible = false;
			itemGrid34.Width = 26;
			itemGrid34.X = 73;
			itemGrid34.Y = 3.6f;
			itemGrid35.AdjustFontSize = 0f;
			itemGrid35.Alignment = StringAlignment.Near;
			itemGrid35.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid35.Changed = true;
			itemGrid35.FieldType = ItemType.Label2;
			itemGrid35.FontColor = Color.Gainsboro;
			itemGrid35.FontStyle = FontStyle.Regular;
			itemGrid35.Height = 1f;
			itemGrid35.IsBlink = 0;
			itemGrid35.Name = "lbOpen";
			itemGrid35.Text = "Open-1";
			itemGrid35.ValueFormat = FormatType.Text;
			itemGrid35.Visible = true;
			itemGrid35.Width = 22;
			itemGrid35.X = 45;
			itemGrid35.Y = 4.6f;
			itemGrid36.AdjustFontSize = 0f;
			itemGrid36.Alignment = StringAlignment.Near;
			itemGrid36.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid36.Changed = false;
			itemGrid36.FieldType = ItemType.Text;
			itemGrid36.FontColor = Color.White;
			itemGrid36.FontStyle = FontStyle.Regular;
			itemGrid36.Height = 1f;
			itemGrid36.IsBlink = 0;
			itemGrid36.Name = "open1";
			itemGrid36.Text = "";
			itemGrid36.ValueFormat = FormatType.Price;
			itemGrid36.Visible = true;
			itemGrid36.Width = 31;
			itemGrid36.X = 67;
			itemGrid36.Y = 4.6f;
			itemGrid37.AdjustFontSize = 0f;
			itemGrid37.Alignment = StringAlignment.Near;
			itemGrid37.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid37.Changed = true;
			itemGrid37.FieldType = ItemType.Label2;
			itemGrid37.FontColor = Color.Gainsboro;
			itemGrid37.FontStyle = FontStyle.Regular;
			itemGrid37.Height = 1f;
			itemGrid37.IsBlink = 0;
			itemGrid37.Name = "lbOpen2";
			itemGrid37.Text = "Open-2";
			itemGrid37.ValueFormat = FormatType.Text;
			itemGrid37.Visible = true;
			itemGrid37.Width = 22;
			itemGrid37.X = 45;
			itemGrid37.Y = 5.6f;
			itemGrid38.AdjustFontSize = 0f;
			itemGrid38.Alignment = StringAlignment.Near;
			itemGrid38.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid38.Changed = false;
			itemGrid38.FieldType = ItemType.Text;
			itemGrid38.FontColor = Color.White;
			itemGrid38.FontStyle = FontStyle.Regular;
			itemGrid38.Height = 1f;
			itemGrid38.IsBlink = 0;
			itemGrid38.Name = "open2";
			itemGrid38.Text = "";
			itemGrid38.ValueFormat = FormatType.Price;
			itemGrid38.Visible = true;
			itemGrid38.Width = 31;
			itemGrid38.X = 67;
			itemGrid38.Y = 5.6f;
			itemGrid39.AdjustFontSize = 0f;
			itemGrid39.Alignment = StringAlignment.Near;
			itemGrid39.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid39.Changed = true;
			itemGrid39.FieldType = ItemType.Label2;
			itemGrid39.FontColor = Color.Gainsboro;
			itemGrid39.FontStyle = FontStyle.Regular;
			itemGrid39.Height = 1f;
			itemGrid39.IsBlink = 0;
			itemGrid39.Name = "lbHigh";
			itemGrid39.Text = "High";
			itemGrid39.ValueFormat = FormatType.Text;
			itemGrid39.Visible = true;
			itemGrid39.Width = 22;
			itemGrid39.X = 0;
			itemGrid39.Y = 4.6f;
			itemGrid40.AdjustFontSize = 0f;
			itemGrid40.Alignment = StringAlignment.Near;
			itemGrid40.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid40.Changed = false;
			itemGrid40.FieldType = ItemType.Text;
			itemGrid40.FontColor = Color.White;
			itemGrid40.FontStyle = FontStyle.Regular;
			itemGrid40.Height = 1f;
			itemGrid40.IsBlink = 0;
			itemGrid40.Name = "high";
			itemGrid40.Text = "";
			itemGrid40.ValueFormat = FormatType.Price;
			itemGrid40.Visible = true;
			itemGrid40.Width = 23;
			itemGrid40.X = 22;
			itemGrid40.Y = 4.6f;
			itemGrid41.AdjustFontSize = 0f;
			itemGrid41.Alignment = StringAlignment.Near;
			itemGrid41.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid41.Changed = true;
			itemGrid41.FieldType = ItemType.Label2;
			itemGrid41.FontColor = Color.Gainsboro;
			itemGrid41.FontStyle = FontStyle.Regular;
			itemGrid41.Height = 1f;
			itemGrid41.IsBlink = 0;
			itemGrid41.Name = "lbLow";
			itemGrid41.Text = "Low";
			itemGrid41.ValueFormat = FormatType.Text;
			itemGrid41.Visible = true;
			itemGrid41.Width = 22;
			itemGrid41.X = 0;
			itemGrid41.Y = 5.6f;
			itemGrid42.AdjustFontSize = 0f;
			itemGrid42.Alignment = StringAlignment.Near;
			itemGrid42.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid42.Changed = false;
			itemGrid42.FieldType = ItemType.Text;
			itemGrid42.FontColor = Color.White;
			itemGrid42.FontStyle = FontStyle.Regular;
			itemGrid42.Height = 1f;
			itemGrid42.IsBlink = 0;
			itemGrid42.Name = "low";
			itemGrid42.Text = "";
			itemGrid42.ValueFormat = FormatType.Price;
			itemGrid42.Visible = true;
			itemGrid42.Width = 23;
			itemGrid42.X = 22;
			itemGrid42.Y = 5.6f;
			itemGrid43.AdjustFontSize = 0f;
			itemGrid43.Alignment = StringAlignment.Near;
			itemGrid43.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid43.Changed = true;
			itemGrid43.FieldType = ItemType.Label2;
			itemGrid43.FontColor = Color.Gainsboro;
			itemGrid43.FontStyle = FontStyle.Regular;
			itemGrid43.Height = 1f;
			itemGrid43.IsBlink = 0;
			itemGrid43.Name = "lb_ceiling";
			itemGrid43.Text = "Ceiling";
			itemGrid43.ValueFormat = FormatType.Text;
			itemGrid43.Visible = true;
			itemGrid43.Width = 22;
			itemGrid43.X = 0;
			itemGrid43.Y = 6.6f;
			itemGrid44.AdjustFontSize = 0f;
			itemGrid44.Alignment = StringAlignment.Near;
			itemGrid44.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid44.Changed = true;
			itemGrid44.FieldType = ItemType.Text;
			itemGrid44.FontColor = Color.Cyan;
			itemGrid44.FontStyle = FontStyle.Regular;
			itemGrid44.Height = 1f;
			itemGrid44.IsBlink = 0;
			itemGrid44.Name = "ceiling";
			itemGrid44.Text = "";
			itemGrid44.ValueFormat = FormatType.Price;
			itemGrid44.Visible = true;
			itemGrid44.Width = 23;
			itemGrid44.X = 22;
			itemGrid44.Y = 6.6f;
			itemGrid45.AdjustFontSize = 0f;
			itemGrid45.Alignment = StringAlignment.Near;
			itemGrid45.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid45.Changed = true;
			itemGrid45.FieldType = ItemType.Label2;
			itemGrid45.FontColor = Color.Gainsboro;
			itemGrid45.FontStyle = FontStyle.Regular;
			itemGrid45.Height = 1f;
			itemGrid45.IsBlink = 0;
			itemGrid45.Name = "lb_floor";
			itemGrid45.Text = "Floor";
			itemGrid45.ValueFormat = FormatType.Text;
			itemGrid45.Visible = true;
			itemGrid45.Width = 22;
			itemGrid45.X = 0;
			itemGrid45.Y = 7.6f;
			itemGrid46.AdjustFontSize = 0f;
			itemGrid46.Alignment = StringAlignment.Near;
			itemGrid46.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid46.Changed = true;
			itemGrid46.FieldType = ItemType.Text;
			itemGrid46.FontColor = Color.FromArgb(187, 44, 189);
			itemGrid46.FontStyle = FontStyle.Regular;
			itemGrid46.Height = 1f;
			itemGrid46.IsBlink = 0;
			itemGrid46.Name = "floor";
			itemGrid46.Text = "";
			itemGrid46.ValueFormat = FormatType.Price;
			itemGrid46.Visible = true;
			itemGrid46.Width = 23;
			itemGrid46.X = 22;
			itemGrid46.Y = 7.6f;
			itemGrid47.AdjustFontSize = 0f;
			itemGrid47.Alignment = StringAlignment.Near;
			itemGrid47.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid47.Changed = true;
			itemGrid47.FieldType = ItemType.Label2;
			itemGrid47.FontColor = Color.Gainsboro;
			itemGrid47.FontStyle = FontStyle.Regular;
			itemGrid47.Height = 1f;
			itemGrid47.IsBlink = 0;
			itemGrid47.Name = "lb_par";
			itemGrid47.Text = "Par";
			itemGrid47.ValueFormat = FormatType.Text;
			itemGrid47.Visible = true;
			itemGrid47.Width = 22;
			itemGrid47.X = 45;
			itemGrid47.Y = 8.6f;
			itemGrid48.AdjustFontSize = 0f;
			itemGrid48.Alignment = StringAlignment.Near;
			itemGrid48.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid48.Changed = true;
			itemGrid48.FieldType = ItemType.Text;
			itemGrid48.FontColor = Color.Yellow;
			itemGrid48.FontStyle = FontStyle.Regular;
			itemGrid48.Height = 1f;
			itemGrid48.IsBlink = 0;
			itemGrid48.Name = "par";
			itemGrid48.Text = "";
			itemGrid48.ValueFormat = FormatType.Text;
			itemGrid48.Visible = true;
			itemGrid48.Width = 31;
			itemGrid48.X = 67;
			itemGrid48.Y = 8.6f;
			itemGrid49.AdjustFontSize = 0f;
			itemGrid49.Alignment = StringAlignment.Near;
			itemGrid49.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid49.Changed = true;
			itemGrid49.FieldType = ItemType.Label2;
			itemGrid49.FontColor = Color.Gainsboro;
			itemGrid49.FontStyle = FontStyle.Regular;
			itemGrid49.Height = 1f;
			itemGrid49.IsBlink = 0;
			itemGrid49.Name = "lbPoClose";
			itemGrid49.Text = "Prj.Close";
			itemGrid49.ValueFormat = FormatType.Text;
			itemGrid49.Visible = true;
			itemGrid49.Width = 22;
			itemGrid49.X = 45;
			itemGrid49.Y = 6.6f;
			itemGrid50.AdjustFontSize = 0f;
			itemGrid50.Alignment = StringAlignment.Near;
			itemGrid50.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid50.Changed = false;
			itemGrid50.FieldType = ItemType.Text;
			itemGrid50.FontColor = Color.White;
			itemGrid50.FontStyle = FontStyle.Regular;
			itemGrid50.Height = 1f;
			itemGrid50.IsBlink = 0;
			itemGrid50.Name = "poclose";
			itemGrid50.Text = "";
			itemGrid50.ValueFormat = FormatType.Price;
			itemGrid50.Visible = true;
			itemGrid50.Width = 31;
			itemGrid50.X = 67;
			itemGrid50.Y = 6.6f;
			itemGrid51.AdjustFontSize = 0f;
			itemGrid51.Alignment = StringAlignment.Near;
			itemGrid51.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid51.Changed = true;
			itemGrid51.FieldType = ItemType.Label2;
			itemGrid51.FontColor = Color.Gainsboro;
			itemGrid51.FontStyle = FontStyle.Regular;
			itemGrid51.Height = 1f;
			itemGrid51.IsBlink = 0;
			itemGrid51.Name = "lb_spread";
			itemGrid51.Text = "Spread";
			itemGrid51.ValueFormat = FormatType.Text;
			itemGrid51.Visible = true;
			itemGrid51.Width = 22;
			itemGrid51.X = 0;
			itemGrid51.Y = 8.6f;
			itemGrid52.AdjustFontSize = 0f;
			itemGrid52.Alignment = StringAlignment.Near;
			itemGrid52.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid52.Changed = true;
			itemGrid52.FieldType = ItemType.Text;
			itemGrid52.FontColor = Color.Yellow;
			itemGrid52.FontStyle = FontStyle.Regular;
			itemGrid52.Height = 1f;
			itemGrid52.IsBlink = 0;
			itemGrid52.Name = "spread";
			itemGrid52.Text = "";
			itemGrid52.ValueFormat = FormatType.Price;
			itemGrid52.Visible = true;
			itemGrid52.Width = 23;
			itemGrid52.X = 22;
			itemGrid52.Y = 8.6f;
			itemGrid53.AdjustFontSize = 0f;
			itemGrid53.Alignment = StringAlignment.Near;
			itemGrid53.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid53.Changed = true;
			itemGrid53.FieldType = ItemType.Label2;
			itemGrid53.FontColor = Color.Gainsboro;
			itemGrid53.FontStyle = FontStyle.Regular;
			itemGrid53.Height = 1f;
			itemGrid53.IsBlink = 0;
			itemGrid53.Name = "lb_povol";
			itemGrid53.Text = "Prj.Vol";
			itemGrid53.ValueFormat = FormatType.Text;
			itemGrid53.Visible = true;
			itemGrid53.Width = 22;
			itemGrid53.X = 45;
			itemGrid53.Y = 7.6f;
			itemGrid54.AdjustFontSize = 0f;
			itemGrid54.Alignment = StringAlignment.Near;
			itemGrid54.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid54.Changed = true;
			itemGrid54.FieldType = ItemType.Text;
			itemGrid54.FontColor = Color.Yellow;
			itemGrid54.FontStyle = FontStyle.Regular;
			itemGrid54.Height = 1f;
			itemGrid54.IsBlink = 0;
			itemGrid54.Name = "povol";
			itemGrid54.Text = "";
			itemGrid54.ValueFormat = FormatType.Text;
			itemGrid54.Visible = true;
			itemGrid54.Width = 31;
			itemGrid54.X = 67;
			itemGrid54.Y = 7.6f;
			itemGrid55.AdjustFontSize = 0f;
			itemGrid55.Alignment = StringAlignment.Near;
			itemGrid55.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid55.Changed = true;
			itemGrid55.FieldType = ItemType.Label2;
			itemGrid55.FontColor = Color.Gainsboro;
			itemGrid55.FontStyle = FontStyle.Regular;
			itemGrid55.Height = 1f;
			itemGrid55.IsBlink = 0;
			itemGrid55.Name = "lbMarginRate";
			itemGrid55.Text = "IM";
			itemGrid55.ValueFormat = FormatType.Text;
			itemGrid55.Visible = true;
			itemGrid55.Width = 22;
			itemGrid55.X = 45;
			itemGrid55.Y = 9.6f;
			itemGrid56.AdjustFontSize = 0f;
			itemGrid56.Alignment = StringAlignment.Near;
			itemGrid56.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid56.Changed = true;
			itemGrid56.FieldType = ItemType.Text;
			itemGrid56.FontColor = Color.Yellow;
			itemGrid56.FontStyle = FontStyle.Regular;
			itemGrid56.Height = 1f;
			itemGrid56.IsBlink = 0;
			itemGrid56.Name = "tbMarginRate";
			itemGrid56.Text = "";
			itemGrid56.ValueFormat = FormatType.Text;
			itemGrid56.Visible = true;
			itemGrid56.Width = 31;
			itemGrid56.X = 67;
			itemGrid56.Y = 9.6f;
			itemGrid57.AdjustFontSize = 0f;
			itemGrid57.Alignment = StringAlignment.Near;
			itemGrid57.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid57.Changed = true;
			itemGrid57.FieldType = ItemType.Label2;
			itemGrid57.FontColor = Color.Gainsboro;
			itemGrid57.FontStyle = FontStyle.Regular;
			itemGrid57.Height = 1f;
			itemGrid57.IsBlink = 0;
			itemGrid57.Name = "lb_flag";
			itemGrid57.Text = "Flag";
			itemGrid57.ValueFormat = FormatType.Text;
			itemGrid57.Visible = true;
			itemGrid57.Width = 22;
			itemGrid57.X = 0;
			itemGrid57.Y = 9.6f;
			itemGrid58.AdjustFontSize = 0f;
			itemGrid58.Alignment = StringAlignment.Near;
			itemGrid58.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid58.Changed = true;
			itemGrid58.FieldType = ItemType.Text;
			itemGrid58.FontColor = Color.Yellow;
			itemGrid58.FontStyle = FontStyle.Regular;
			itemGrid58.Height = 1f;
			itemGrid58.IsBlink = 0;
			itemGrid58.Name = "flag";
			itemGrid58.Text = "";
			itemGrid58.ValueFormat = FormatType.Text;
			itemGrid58.Visible = true;
			itemGrid58.Width = 23;
			itemGrid58.X = 22;
			itemGrid58.Y = 9.6f;
			itemGrid59.AdjustFontSize = 0f;
			itemGrid59.Alignment = StringAlignment.Near;
			itemGrid59.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid59.Changed = true;
			itemGrid59.FieldType = ItemType.Label2;
			itemGrid59.FontColor = Color.Gainsboro;
			itemGrid59.FontStyle = FontStyle.Regular;
			itemGrid59.Height = 1f;
			itemGrid59.IsBlink = 0;
			itemGrid59.Name = "lb_hl52weel";
			itemGrid59.Text = "H/L 52W";
			itemGrid59.ValueFormat = FormatType.Text;
			itemGrid59.Visible = true;
			itemGrid59.Width = 22;
			itemGrid59.X = 45;
			itemGrid59.Y = 3.6f;
			itemGrid60.AdjustFontSize = -1f;
			itemGrid60.Alignment = StringAlignment.Near;
			itemGrid60.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid60.Changed = false;
			itemGrid60.FieldType = ItemType.Text;
			itemGrid60.FontColor = Color.White;
			itemGrid60.FontStyle = FontStyle.Regular;
			itemGrid60.Height = 1f;
			itemGrid60.IsBlink = 0;
			itemGrid60.Name = "h52w";
			itemGrid60.Text = "";
			itemGrid60.ValueFormat = FormatType.Price;
			itemGrid60.Visible = true;
			itemGrid60.Width = 14;
			itemGrid60.X = 67;
			itemGrid60.Y = 3.6f;
			itemGrid61.AdjustFontSize = 0f;
			itemGrid61.Alignment = StringAlignment.Center;
			itemGrid61.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid61.Changed = true;
			itemGrid61.FieldType = ItemType.Label;
			itemGrid61.FontColor = Color.Gainsboro;
			itemGrid61.FontStyle = FontStyle.Regular;
			itemGrid61.Height = 1f;
			itemGrid61.IsBlink = 0;
			itemGrid61.Name = "lb2";
			itemGrid61.Text = "/";
			itemGrid61.ValueFormat = FormatType.Label;
			itemGrid61.Visible = true;
			itemGrid61.Width = 3;
			itemGrid61.X = 81;
			itemGrid61.Y = 3.6f;
			itemGrid62.AdjustFontSize = -1f;
			itemGrid62.Alignment = StringAlignment.Near;
			itemGrid62.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid62.Changed = false;
			itemGrid62.FieldType = ItemType.Text;
			itemGrid62.FontColor = Color.White;
			itemGrid62.FontStyle = FontStyle.Regular;
			itemGrid62.Height = 1f;
			itemGrid62.IsBlink = 0;
			itemGrid62.Name = "l52w";
			itemGrid62.Text = "";
			itemGrid62.ValueFormat = FormatType.Price;
			itemGrid62.Visible = true;
			itemGrid62.Width = 16;
			itemGrid62.X = 84;
			itemGrid62.Y = 3.6f;
			this.intzaInfo.Items.Add(itemGrid21);
			this.intzaInfo.Items.Add(itemGrid22);
			this.intzaInfo.Items.Add(itemGrid23);
			this.intzaInfo.Items.Add(itemGrid24);
			this.intzaInfo.Items.Add(itemGrid25);
			this.intzaInfo.Items.Add(itemGrid26);
			this.intzaInfo.Items.Add(itemGrid27);
			this.intzaInfo.Items.Add(itemGrid28);
			this.intzaInfo.Items.Add(itemGrid29);
			this.intzaInfo.Items.Add(itemGrid30);
			this.intzaInfo.Items.Add(itemGrid31);
			this.intzaInfo.Items.Add(itemGrid32);
			this.intzaInfo.Items.Add(itemGrid33);
			this.intzaInfo.Items.Add(itemGrid34);
			this.intzaInfo.Items.Add(itemGrid35);
			this.intzaInfo.Items.Add(itemGrid36);
			this.intzaInfo.Items.Add(itemGrid37);
			this.intzaInfo.Items.Add(itemGrid38);
			this.intzaInfo.Items.Add(itemGrid39);
			this.intzaInfo.Items.Add(itemGrid40);
			this.intzaInfo.Items.Add(itemGrid41);
			this.intzaInfo.Items.Add(itemGrid42);
			this.intzaInfo.Items.Add(itemGrid43);
			this.intzaInfo.Items.Add(itemGrid44);
			this.intzaInfo.Items.Add(itemGrid45);
			this.intzaInfo.Items.Add(itemGrid46);
			this.intzaInfo.Items.Add(itemGrid47);
			this.intzaInfo.Items.Add(itemGrid48);
			this.intzaInfo.Items.Add(itemGrid49);
			this.intzaInfo.Items.Add(itemGrid50);
			this.intzaInfo.Items.Add(itemGrid51);
			this.intzaInfo.Items.Add(itemGrid52);
			this.intzaInfo.Items.Add(itemGrid53);
			this.intzaInfo.Items.Add(itemGrid54);
			this.intzaInfo.Items.Add(itemGrid55);
			this.intzaInfo.Items.Add(itemGrid56);
			this.intzaInfo.Items.Add(itemGrid57);
			this.intzaInfo.Items.Add(itemGrid58);
			this.intzaInfo.Items.Add(itemGrid59);
			this.intzaInfo.Items.Add(itemGrid60);
			this.intzaInfo.Items.Add(itemGrid61);
			this.intzaInfo.Items.Add(itemGrid62);
			this.intzaInfo.LineColor = Color.Red;
			this.intzaInfo.Location = new Point(612, 28);
			this.intzaInfo.Margin = new Padding(2);
			this.intzaInfo.Name = "intzaInfo";
			this.intzaInfo.Size = new Size(265, 164);
			this.intzaInfo.TabIndex = 92;
			this.intzaInfo.TabStop = false;
			this.intzaInfoTFEX.AllowDrop = true;
			this.intzaInfoTFEX.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfoTFEX.CanDrag = false;
			this.intzaInfoTFEX.IsAutoRepaint = true;
			this.intzaInfoTFEX.IsDroped = false;
			itemGrid63.AdjustFontSize = 0f;
			itemGrid63.Alignment = StringAlignment.Near;
			itemGrid63.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid63.Changed = true;
			itemGrid63.FieldType = ItemType.Label;
			itemGrid63.FontColor = Color.Gainsboro;
			itemGrid63.FontStyle = FontStyle.Regular;
			itemGrid63.Height = 1f;
			itemGrid63.IsBlink = 0;
			itemGrid63.Name = "open_label";
			itemGrid63.Text = "Open";
			itemGrid63.ValueFormat = FormatType.Text;
			itemGrid63.Visible = true;
			itemGrid63.Width = 20;
			itemGrid63.X = 0;
			itemGrid63.Y = 0f;
			itemGrid64.AdjustFontSize = -1f;
			itemGrid64.Alignment = StringAlignment.Far;
			itemGrid64.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid64.Changed = true;
			itemGrid64.FieldType = ItemType.Text;
			itemGrid64.FontColor = Color.Yellow;
			itemGrid64.FontStyle = FontStyle.Regular;
			itemGrid64.Height = 1f;
			itemGrid64.IsBlink = 0;
			itemGrid64.Name = "open_vol";
			itemGrid64.Text = "";
			itemGrid64.ValueFormat = FormatType.Volume;
			itemGrid64.Visible = true;
			itemGrid64.Width = 35;
			itemGrid64.X = 20;
			itemGrid64.Y = 0f;
			itemGrid65.AdjustFontSize = 0f;
			itemGrid65.Alignment = StringAlignment.Far;
			itemGrid65.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid65.Changed = true;
			itemGrid65.FieldType = ItemType.Text;
			itemGrid65.FontColor = Color.Yellow;
			itemGrid65.FontStyle = FontStyle.Regular;
			itemGrid65.Height = 1f;
			itemGrid65.IsBlink = 0;
			itemGrid65.Name = "open_avg";
			itemGrid65.Text = "";
			itemGrid65.ValueFormat = FormatType.Text;
			itemGrid65.Visible = false;
			itemGrid65.Width = 27;
			itemGrid65.X = 73;
			itemGrid65.Y = 0f;
			itemGrid66.AdjustFontSize = 0f;
			itemGrid66.Alignment = StringAlignment.Near;
			itemGrid66.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid66.Changed = true;
			itemGrid66.FieldType = ItemType.Label;
			itemGrid66.FontColor = Color.Gainsboro;
			itemGrid66.FontStyle = FontStyle.Regular;
			itemGrid66.Height = 1f;
			itemGrid66.IsBlink = 0;
			itemGrid66.Name = "long_label";
			itemGrid66.Text = "Long";
			itemGrid66.ValueFormat = FormatType.Text;
			itemGrid66.Visible = true;
			itemGrid66.Width = 20;
			itemGrid66.X = 0;
			itemGrid66.Y = 1.2f;
			itemGrid67.AdjustFontSize = -1f;
			itemGrid67.Alignment = StringAlignment.Far;
			itemGrid67.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid67.Changed = true;
			itemGrid67.FieldType = ItemType.Text;
			itemGrid67.FontColor = Color.Lime;
			itemGrid67.FontStyle = FontStyle.Regular;
			itemGrid67.Height = 1f;
			itemGrid67.IsBlink = 0;
			itemGrid67.Name = "long_vol";
			itemGrid67.Text = "";
			itemGrid67.ValueFormat = FormatType.Volume;
			itemGrid67.Visible = true;
			itemGrid67.Width = 35;
			itemGrid67.X = 20;
			itemGrid67.Y = 1.2f;
			itemGrid68.AdjustFontSize = 0f;
			itemGrid68.Alignment = StringAlignment.Far;
			itemGrid68.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid68.Changed = true;
			itemGrid68.FieldType = ItemType.Text;
			itemGrid68.FontColor = Color.Yellow;
			itemGrid68.FontStyle = FontStyle.Regular;
			itemGrid68.Height = 1f;
			itemGrid68.IsBlink = 0;
			itemGrid68.Name = "long_avg";
			itemGrid68.Text = "";
			itemGrid68.ValueFormat = FormatType.Text;
			itemGrid68.Visible = false;
			itemGrid68.Width = 27;
			itemGrid68.X = 73;
			itemGrid68.Y = 1.2f;
			itemGrid69.AdjustFontSize = 0f;
			itemGrid69.Alignment = StringAlignment.Near;
			itemGrid69.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid69.Changed = true;
			itemGrid69.FieldType = ItemType.Label;
			itemGrid69.FontColor = Color.Gainsboro;
			itemGrid69.FontStyle = FontStyle.Regular;
			itemGrid69.Height = 1f;
			itemGrid69.IsBlink = 0;
			itemGrid69.Name = "short_label";
			itemGrid69.Text = "Short";
			itemGrid69.ValueFormat = FormatType.Text;
			itemGrid69.Visible = true;
			itemGrid69.Width = 20;
			itemGrid69.X = 0;
			itemGrid69.Y = 2.4f;
			itemGrid70.AdjustFontSize = -1f;
			itemGrid70.Alignment = StringAlignment.Far;
			itemGrid70.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid70.Changed = true;
			itemGrid70.FieldType = ItemType.Text;
			itemGrid70.FontColor = Color.Red;
			itemGrid70.FontStyle = FontStyle.Regular;
			itemGrid70.Height = 1f;
			itemGrid70.IsBlink = 0;
			itemGrid70.Name = "short_vol";
			itemGrid70.Text = "";
			itemGrid70.ValueFormat = FormatType.Volume;
			itemGrid70.Visible = true;
			itemGrid70.Width = 35;
			itemGrid70.X = 20;
			itemGrid70.Y = 2.4f;
			itemGrid71.AdjustFontSize = 0f;
			itemGrid71.Alignment = StringAlignment.Far;
			itemGrid71.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid71.Changed = true;
			itemGrid71.FieldType = ItemType.Text;
			itemGrid71.FontColor = Color.Yellow;
			itemGrid71.FontStyle = FontStyle.Regular;
			itemGrid71.Height = 1f;
			itemGrid71.IsBlink = 0;
			itemGrid71.Name = "short_avg";
			itemGrid71.Text = "";
			itemGrid71.ValueFormat = FormatType.Text;
			itemGrid71.Visible = false;
			itemGrid71.Width = 27;
			itemGrid71.X = 73;
			itemGrid71.Y = 2.4f;
			itemGrid72.AdjustFontSize = 0f;
			itemGrid72.Alignment = StringAlignment.Near;
			itemGrid72.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid72.Changed = false;
			itemGrid72.FieldType = ItemType.Text;
			itemGrid72.FontColor = Color.White;
			itemGrid72.FontStyle = FontStyle.Regular;
			itemGrid72.Height = 3.4f;
			itemGrid72.IsBlink = 0;
			itemGrid72.Name = "pie";
			itemGrid72.Text = "";
			itemGrid72.ValueFormat = FormatType.PieChartNew;
			itemGrid72.Visible = true;
			itemGrid72.Width = 40;
			itemGrid72.X = 60;
			itemGrid72.Y = 0f;
			itemGrid73.AdjustFontSize = 0f;
			itemGrid73.Alignment = StringAlignment.Near;
			itemGrid73.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid73.Changed = true;
			itemGrid73.FieldType = ItemType.Label;
			itemGrid73.FontColor = Color.Gainsboro;
			itemGrid73.FontStyle = FontStyle.Regular;
			itemGrid73.Height = 1f;
			itemGrid73.IsBlink = 0;
			itemGrid73.Name = "oi_lable";
			itemGrid73.Text = "OI";
			itemGrid73.ValueFormat = FormatType.Text;
			itemGrid73.Visible = true;
			itemGrid73.Width = 23;
			itemGrid73.X = 0;
			itemGrid73.Y = 3.6f;
			itemGrid74.AdjustFontSize = 0f;
			itemGrid74.Alignment = StringAlignment.Near;
			itemGrid74.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid74.Changed = true;
			itemGrid74.FieldType = ItemType.Text;
			itemGrid74.FontColor = Color.Yellow;
			itemGrid74.FontStyle = FontStyle.Regular;
			itemGrid74.Height = 1f;
			itemGrid74.IsBlink = 0;
			itemGrid74.Name = "oi";
			itemGrid74.Text = "";
			itemGrid74.ValueFormat = FormatType.Price;
			itemGrid74.Visible = true;
			itemGrid74.Width = 26;
			itemGrid74.X = 23;
			itemGrid74.Y = 3.6f;
			itemGrid75.AdjustFontSize = 0f;
			itemGrid75.Alignment = StringAlignment.Near;
			itemGrid75.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid75.Changed = true;
			itemGrid75.FieldType = ItemType.Label;
			itemGrid75.FontColor = Color.Gainsboro;
			itemGrid75.FontStyle = FontStyle.Regular;
			itemGrid75.Height = 1f;
			itemGrid75.IsBlink = 0;
			itemGrid75.Name = "psettle_label";
			itemGrid75.Text = "P.Settle";
			itemGrid75.ValueFormat = FormatType.Text;
			itemGrid75.Visible = true;
			itemGrid75.Width = 23;
			itemGrid75.X = 0;
			itemGrid75.Y = 4.6f;
			itemGrid76.AdjustFontSize = 0f;
			itemGrid76.Alignment = StringAlignment.Near;
			itemGrid76.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid76.Changed = true;
			itemGrid76.FieldType = ItemType.Text;
			itemGrid76.FontColor = Color.Yellow;
			itemGrid76.FontStyle = FontStyle.Regular;
			itemGrid76.Height = 1f;
			itemGrid76.IsBlink = 0;
			itemGrid76.Name = "psettle";
			itemGrid76.Text = "";
			itemGrid76.ValueFormat = FormatType.Text;
			itemGrid76.Visible = true;
			itemGrid76.Width = 26;
			itemGrid76.X = 23;
			itemGrid76.Y = 4.6f;
			itemGrid77.AdjustFontSize = 0f;
			itemGrid77.Alignment = StringAlignment.Near;
			itemGrid77.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid77.Changed = true;
			itemGrid77.FieldType = ItemType.Label;
			itemGrid77.FontColor = Color.Gainsboro;
			itemGrid77.FontStyle = FontStyle.Regular;
			itemGrid77.Height = 1f;
			itemGrid77.IsBlink = 0;
			itemGrid77.Name = "settle_label";
			itemGrid77.Text = "Settle";
			itemGrid77.ValueFormat = FormatType.Text;
			itemGrid77.Visible = true;
			itemGrid77.Width = 23;
			itemGrid77.X = 0;
			itemGrid77.Y = 5.6f;
			itemGrid78.AdjustFontSize = 0f;
			itemGrid78.Alignment = StringAlignment.Near;
			itemGrid78.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid78.Changed = true;
			itemGrid78.FieldType = ItemType.Text;
			itemGrid78.FontColor = Color.Yellow;
			itemGrid78.FontStyle = FontStyle.Regular;
			itemGrid78.Height = 1f;
			itemGrid78.IsBlink = 0;
			itemGrid78.Name = "settle";
			itemGrid78.Text = "";
			itemGrid78.ValueFormat = FormatType.Text;
			itemGrid78.Visible = true;
			itemGrid78.Width = 26;
			itemGrid78.X = 23;
			itemGrid78.Y = 5.6f;
			itemGrid79.AdjustFontSize = 0f;
			itemGrid79.Alignment = StringAlignment.Near;
			itemGrid79.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid79.Changed = true;
			itemGrid79.FieldType = ItemType.Label;
			itemGrid79.FontColor = Color.Gainsboro;
			itemGrid79.FontStyle = FontStyle.Regular;
			itemGrid79.Height = 1f;
			itemGrid79.IsBlink = 0;
			itemGrid79.Name = "ceiling_lable";
			itemGrid79.Text = "Ceiling";
			itemGrid79.ValueFormat = FormatType.Text;
			itemGrid79.Visible = true;
			itemGrid79.Width = 23;
			itemGrid79.X = 0;
			itemGrid79.Y = 6.6f;
			itemGrid80.AdjustFontSize = 0f;
			itemGrid80.Alignment = StringAlignment.Near;
			itemGrid80.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid80.Changed = true;
			itemGrid80.FieldType = ItemType.Text;
			itemGrid80.FontColor = Color.Cyan;
			itemGrid80.FontStyle = FontStyle.Regular;
			itemGrid80.Height = 1f;
			itemGrid80.IsBlink = 0;
			itemGrid80.Name = "ceiling";
			itemGrid80.Text = "";
			itemGrid80.ValueFormat = FormatType.Text;
			itemGrid80.Visible = true;
			itemGrid80.Width = 26;
			itemGrid80.X = 23;
			itemGrid80.Y = 6.6f;
			itemGrid81.AdjustFontSize = 0f;
			itemGrid81.Alignment = StringAlignment.Near;
			itemGrid81.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid81.Changed = true;
			itemGrid81.FieldType = ItemType.Label;
			itemGrid81.FontColor = Color.Gainsboro;
			itemGrid81.FontStyle = FontStyle.Regular;
			itemGrid81.Height = 1f;
			itemGrid81.IsBlink = 0;
			itemGrid81.Name = "floor_label";
			itemGrid81.Text = "Floor";
			itemGrid81.ValueFormat = FormatType.Text;
			itemGrid81.Visible = true;
			itemGrid81.Width = 23;
			itemGrid81.X = 0;
			itemGrid81.Y = 7.6f;
			itemGrid82.AdjustFontSize = 0f;
			itemGrid82.Alignment = StringAlignment.Near;
			itemGrid82.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid82.Changed = true;
			itemGrid82.FieldType = ItemType.Text;
			itemGrid82.FontColor = Color.Magenta;
			itemGrid82.FontStyle = FontStyle.Regular;
			itemGrid82.Height = 1f;
			itemGrid82.IsBlink = 0;
			itemGrid82.Name = "floor";
			itemGrid82.Text = "";
			itemGrid82.ValueFormat = FormatType.Text;
			itemGrid82.Visible = true;
			itemGrid82.Width = 26;
			itemGrid82.X = 23;
			itemGrid82.Y = 7.6f;
			itemGrid83.AdjustFontSize = 0f;
			itemGrid83.Alignment = StringAlignment.Near;
			itemGrid83.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid83.Changed = true;
			itemGrid83.FieldType = ItemType.Label;
			itemGrid83.FontColor = Color.White;
			itemGrid83.FontStyle = FontStyle.Regular;
			itemGrid83.Height = 1f;
			itemGrid83.IsBlink = 0;
			itemGrid83.Name = "Multiplier";
			itemGrid83.Text = "Multiplier";
			itemGrid83.ValueFormat = FormatType.Text;
			itemGrid83.Visible = true;
			itemGrid83.Width = 25;
			itemGrid83.X = 0;
			itemGrid83.Y = 8.6f;
			itemGrid84.AdjustFontSize = 0f;
			itemGrid84.Alignment = StringAlignment.Near;
			itemGrid84.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid84.Changed = true;
			itemGrid84.FieldType = ItemType.Text;
			itemGrid84.FontColor = Color.Yellow;
			itemGrid84.FontStyle = FontStyle.Regular;
			itemGrid84.Height = 1f;
			itemGrid84.IsBlink = 0;
			itemGrid84.Name = "multiplier";
			itemGrid84.Text = "";
			itemGrid84.ValueFormat = FormatType.Text;
			itemGrid84.Visible = true;
			itemGrid84.Width = 26;
			itemGrid84.X = 23;
			itemGrid84.Y = 8.6f;
			itemGrid85.AdjustFontSize = 0f;
			itemGrid85.Alignment = StringAlignment.Near;
			itemGrid85.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid85.Changed = true;
			itemGrid85.FieldType = ItemType.Label;
			itemGrid85.FontColor = Color.Gainsboro;
			itemGrid85.FontStyle = FontStyle.Regular;
			itemGrid85.Height = 1f;
			itemGrid85.IsBlink = 0;
			itemGrid85.Name = "tickSize_lable";
			itemGrid85.Text = "Spread";
			itemGrid85.ValueFormat = FormatType.Text;
			itemGrid85.Visible = true;
			itemGrid85.Width = 23;
			itemGrid85.X = 0;
			itemGrid85.Y = 9.6f;
			itemGrid86.AdjustFontSize = 0f;
			itemGrid86.Alignment = StringAlignment.Near;
			itemGrid86.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid86.Changed = true;
			itemGrid86.FieldType = ItemType.Text;
			itemGrid86.FontColor = Color.Yellow;
			itemGrid86.FontStyle = FontStyle.Regular;
			itemGrid86.Height = 1f;
			itemGrid86.IsBlink = 0;
			itemGrid86.Name = "tickSize";
			itemGrid86.Text = "";
			itemGrid86.ValueFormat = FormatType.Text;
			itemGrid86.Visible = true;
			itemGrid86.Width = 26;
			itemGrid86.X = 23;
			itemGrid86.Y = 9.6f;
			itemGrid87.AdjustFontSize = 0f;
			itemGrid87.Alignment = StringAlignment.Near;
			itemGrid87.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid87.Changed = true;
			itemGrid87.FieldType = ItemType.Label;
			itemGrid87.FontColor = Color.Gainsboro;
			itemGrid87.FontStyle = FontStyle.Regular;
			itemGrid87.Height = 1f;
			itemGrid87.IsBlink = 0;
			itemGrid87.Name = "turnover_label";
			itemGrid87.Text = "Turn Over";
			itemGrid87.ValueFormat = FormatType.Text;
			itemGrid87.Visible = false;
			itemGrid87.Width = 23;
			itemGrid87.X = 49;
			itemGrid87.Y = 3.6f;
			itemGrid88.AdjustFontSize = 0f;
			itemGrid88.Alignment = StringAlignment.Near;
			itemGrid88.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid88.Changed = true;
			itemGrid88.FieldType = ItemType.Text;
			itemGrid88.FontColor = Color.Yellow;
			itemGrid88.FontStyle = FontStyle.Regular;
			itemGrid88.Height = 1f;
			itemGrid88.IsBlink = 0;
			itemGrid88.Name = "turnover";
			itemGrid88.Text = "";
			itemGrid88.ValueFormat = FormatType.Price;
			itemGrid88.Visible = false;
			itemGrid88.Width = 29;
			itemGrid88.X = 72;
			itemGrid88.Y = 3.6f;
			itemGrid89.AdjustFontSize = 0f;
			itemGrid89.Alignment = StringAlignment.Near;
			itemGrid89.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid89.Changed = true;
			itemGrid89.FieldType = ItemType.Label;
			itemGrid89.FontColor = Color.Gainsboro;
			itemGrid89.FontStyle = FontStyle.Regular;
			itemGrid89.Height = 1f;
			itemGrid89.IsBlink = 0;
			itemGrid89.Name = "basis_label";
			itemGrid89.Text = "Basis";
			itemGrid89.ValueFormat = FormatType.Text;
			itemGrid89.Visible = true;
			itemGrid89.Width = 23;
			itemGrid89.X = 49;
			itemGrid89.Y = 3.6f;
			itemGrid90.AdjustFontSize = 0f;
			itemGrid90.Alignment = StringAlignment.Near;
			itemGrid90.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid90.Changed = true;
			itemGrid90.FieldType = ItemType.Text;
			itemGrid90.FontColor = Color.Yellow;
			itemGrid90.FontStyle = FontStyle.Regular;
			itemGrid90.Height = 1f;
			itemGrid90.IsBlink = 0;
			itemGrid90.Name = "basis";
			itemGrid90.Text = "";
			itemGrid90.ValueFormat = FormatType.Price;
			itemGrid90.Visible = true;
			itemGrid90.Width = 29;
			itemGrid90.X = 72;
			itemGrid90.Y = 3.6f;
			itemGrid91.AdjustFontSize = 0f;
			itemGrid91.Alignment = StringAlignment.Near;
			itemGrid91.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid91.Changed = true;
			itemGrid91.FieldType = ItemType.Label;
			itemGrid91.FontColor = Color.Gainsboro;
			itemGrid91.FontStyle = FontStyle.Regular;
			itemGrid91.Height = 1f;
			itemGrid91.IsBlink = 0;
			itemGrid91.Name = "open1_label";
			itemGrid91.Text = "Open 1";
			itemGrid91.ValueFormat = FormatType.Text;
			itemGrid91.Visible = true;
			itemGrid91.Width = 23;
			itemGrid91.X = 49;
			itemGrid91.Y = 4.6f;
			itemGrid92.AdjustFontSize = 0f;
			itemGrid92.Alignment = StringAlignment.Near;
			itemGrid92.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid92.Changed = true;
			itemGrid92.FieldType = ItemType.Text;
			itemGrid92.FontColor = Color.Yellow;
			itemGrid92.FontStyle = FontStyle.Regular;
			itemGrid92.Height = 1f;
			itemGrid92.IsBlink = 0;
			itemGrid92.Name = "open1";
			itemGrid92.Text = "";
			itemGrid92.ValueFormat = FormatType.Text;
			itemGrid92.Visible = true;
			itemGrid92.Width = 29;
			itemGrid92.X = 72;
			itemGrid92.Y = 4.6f;
			itemGrid93.AdjustFontSize = 0f;
			itemGrid93.Alignment = StringAlignment.Near;
			itemGrid93.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid93.Changed = true;
			itemGrid93.FieldType = ItemType.Label;
			itemGrid93.FontColor = Color.Gainsboro;
			itemGrid93.FontStyle = FontStyle.Regular;
			itemGrid93.Height = 1f;
			itemGrid93.IsBlink = 0;
			itemGrid93.Name = "open2_label";
			itemGrid93.Text = "Open 2";
			itemGrid93.ValueFormat = FormatType.Text;
			itemGrid93.Visible = true;
			itemGrid93.Width = 23;
			itemGrid93.X = 49;
			itemGrid93.Y = 5.6f;
			itemGrid94.AdjustFontSize = 0f;
			itemGrid94.Alignment = StringAlignment.Near;
			itemGrid94.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid94.Changed = true;
			itemGrid94.FieldType = ItemType.Text;
			itemGrid94.FontColor = Color.Yellow;
			itemGrid94.FontStyle = FontStyle.Regular;
			itemGrid94.Height = 1f;
			itemGrid94.IsBlink = 0;
			itemGrid94.Name = "open2";
			itemGrid94.Text = "";
			itemGrid94.ValueFormat = FormatType.Text;
			itemGrid94.Visible = true;
			itemGrid94.Width = 29;
			itemGrid94.X = 72;
			itemGrid94.Y = 5.6f;
			itemGrid95.AdjustFontSize = 0f;
			itemGrid95.Alignment = StringAlignment.Near;
			itemGrid95.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid95.Changed = true;
			itemGrid95.FieldType = ItemType.Label;
			itemGrid95.FontColor = Color.Gainsboro;
			itemGrid95.FontStyle = FontStyle.Regular;
			itemGrid95.Height = 1f;
			itemGrid95.IsBlink = 0;
			itemGrid95.Name = "poclose_label";
			itemGrid95.Text = "P.Close";
			itemGrid95.ValueFormat = FormatType.Text;
			itemGrid95.Visible = true;
			itemGrid95.Width = 23;
			itemGrid95.X = 49;
			itemGrid95.Y = 7.6f;
			itemGrid96.AdjustFontSize = 0f;
			itemGrid96.Alignment = StringAlignment.Near;
			itemGrid96.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid96.Changed = true;
			itemGrid96.FieldType = ItemType.Text;
			itemGrid96.FontColor = Color.Yellow;
			itemGrid96.FontStyle = FontStyle.Regular;
			itemGrid96.Height = 1f;
			itemGrid96.IsBlink = 0;
			itemGrid96.Name = "poclose";
			itemGrid96.Text = "";
			itemGrid96.ValueFormat = FormatType.Text;
			itemGrid96.Visible = true;
			itemGrid96.Width = 29;
			itemGrid96.X = 72;
			itemGrid96.Y = 7.6f;
			itemGrid97.AdjustFontSize = 0f;
			itemGrid97.Alignment = StringAlignment.Near;
			itemGrid97.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid97.Changed = true;
			itemGrid97.FieldType = ItemType.Label;
			itemGrid97.FontColor = Color.Gainsboro;
			itemGrid97.FontStyle = FontStyle.Regular;
			itemGrid97.Height = 1f;
			itemGrid97.IsBlink = 0;
			itemGrid97.Name = "open3_label";
			itemGrid97.Text = "Open 3";
			itemGrid97.ValueFormat = FormatType.Text;
			itemGrid97.Visible = true;
			itemGrid97.Width = 23;
			itemGrid97.X = 49;
			itemGrid97.Y = 6.6f;
			itemGrid98.AdjustFontSize = 0f;
			itemGrid98.Alignment = StringAlignment.Near;
			itemGrid98.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid98.Changed = true;
			itemGrid98.FieldType = ItemType.Text;
			itemGrid98.FontColor = Color.Yellow;
			itemGrid98.FontStyle = FontStyle.Regular;
			itemGrid98.Height = 1f;
			itemGrid98.IsBlink = 0;
			itemGrid98.Name = "open3";
			itemGrid98.Text = "";
			itemGrid98.ValueFormat = FormatType.Text;
			itemGrid98.Visible = true;
			itemGrid98.Width = 29;
			itemGrid98.X = 72;
			itemGrid98.Y = 6.6f;
			itemGrid99.AdjustFontSize = 0f;
			itemGrid99.Alignment = StringAlignment.Near;
			itemGrid99.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid99.Changed = true;
			itemGrid99.FieldType = ItemType.Label;
			itemGrid99.FontColor = Color.Gainsboro;
			itemGrid99.FontStyle = FontStyle.Regular;
			itemGrid99.Height = 1f;
			itemGrid99.IsBlink = 0;
			itemGrid99.Name = "first_date_label";
			itemGrid99.Text = "First";
			itemGrid99.ValueFormat = FormatType.Text;
			itemGrid99.Visible = false;
			itemGrid99.Width = 23;
			itemGrid99.X = 49;
			itemGrid99.Y = 7.6f;
			itemGrid100.AdjustFontSize = 0f;
			itemGrid100.Alignment = StringAlignment.Near;
			itemGrid100.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid100.Changed = true;
			itemGrid100.FieldType = ItemType.Text;
			itemGrid100.FontColor = Color.Yellow;
			itemGrid100.FontStyle = FontStyle.Regular;
			itemGrid100.Height = 1f;
			itemGrid100.IsBlink = 0;
			itemGrid100.Name = "first_date";
			itemGrid100.Text = "";
			itemGrid100.ValueFormat = FormatType.Text;
			itemGrid100.Visible = false;
			itemGrid100.Width = 29;
			itemGrid100.X = 72;
			itemGrid100.Y = 7.6f;
			itemGrid101.AdjustFontSize = 0f;
			itemGrid101.Alignment = StringAlignment.Near;
			itemGrid101.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid101.Changed = true;
			itemGrid101.FieldType = ItemType.Label;
			itemGrid101.FontColor = Color.Gainsboro;
			itemGrid101.FontStyle = FontStyle.Regular;
			itemGrid101.Height = 1f;
			itemGrid101.IsBlink = 0;
			itemGrid101.Name = "last_date_label";
			itemGrid101.Text = "Last";
			itemGrid101.ValueFormat = FormatType.Text;
			itemGrid101.Visible = true;
			itemGrid101.Width = 23;
			itemGrid101.X = 49;
			itemGrid101.Y = 8.6f;
			itemGrid102.AdjustFontSize = 0f;
			itemGrid102.Alignment = StringAlignment.Near;
			itemGrid102.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid102.Changed = true;
			itemGrid102.FieldType = ItemType.Text;
			itemGrid102.FontColor = Color.Yellow;
			itemGrid102.FontStyle = FontStyle.Regular;
			itemGrid102.Height = 1f;
			itemGrid102.IsBlink = 0;
			itemGrid102.Name = "last_date";
			itemGrid102.Text = "";
			itemGrid102.ValueFormat = FormatType.Text;
			itemGrid102.Visible = true;
			itemGrid102.Width = 29;
			itemGrid102.X = 72;
			itemGrid102.Y = 8.6f;
			itemGrid103.AdjustFontSize = 0f;
			itemGrid103.Alignment = StringAlignment.Near;
			itemGrid103.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid103.Changed = true;
			itemGrid103.FieldType = ItemType.Label;
			itemGrid103.FontColor = Color.Gainsboro;
			itemGrid103.FontStyle = FontStyle.Regular;
			itemGrid103.Height = 1f;
			itemGrid103.IsBlink = 0;
			itemGrid103.Name = "lastIndex_label";
			itemGrid103.Text = "Index";
			itemGrid103.ValueFormat = FormatType.Text;
			itemGrid103.Visible = true;
			itemGrid103.Width = 23;
			itemGrid103.X = 49;
			itemGrid103.Y = 9.6f;
			itemGrid104.AdjustFontSize = 0f;
			itemGrid104.Alignment = StringAlignment.Near;
			itemGrid104.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid104.Changed = true;
			itemGrid104.FieldType = ItemType.Text;
			itemGrid104.FontColor = Color.Yellow;
			itemGrid104.FontStyle = FontStyle.Regular;
			itemGrid104.Height = 1f;
			itemGrid104.IsBlink = 0;
			itemGrid104.Name = "lastIndex";
			itemGrid104.Text = "";
			itemGrid104.ValueFormat = FormatType.Text;
			itemGrid104.Visible = true;
			itemGrid104.Width = 29;
			itemGrid104.X = 72;
			itemGrid104.Y = 9.6f;
			this.intzaInfoTFEX.Items.Add(itemGrid63);
			this.intzaInfoTFEX.Items.Add(itemGrid64);
			this.intzaInfoTFEX.Items.Add(itemGrid65);
			this.intzaInfoTFEX.Items.Add(itemGrid66);
			this.intzaInfoTFEX.Items.Add(itemGrid67);
			this.intzaInfoTFEX.Items.Add(itemGrid68);
			this.intzaInfoTFEX.Items.Add(itemGrid69);
			this.intzaInfoTFEX.Items.Add(itemGrid70);
			this.intzaInfoTFEX.Items.Add(itemGrid71);
			this.intzaInfoTFEX.Items.Add(itemGrid72);
			this.intzaInfoTFEX.Items.Add(itemGrid73);
			this.intzaInfoTFEX.Items.Add(itemGrid74);
			this.intzaInfoTFEX.Items.Add(itemGrid75);
			this.intzaInfoTFEX.Items.Add(itemGrid76);
			this.intzaInfoTFEX.Items.Add(itemGrid77);
			this.intzaInfoTFEX.Items.Add(itemGrid78);
			this.intzaInfoTFEX.Items.Add(itemGrid79);
			this.intzaInfoTFEX.Items.Add(itemGrid80);
			this.intzaInfoTFEX.Items.Add(itemGrid81);
			this.intzaInfoTFEX.Items.Add(itemGrid82);
			this.intzaInfoTFEX.Items.Add(itemGrid83);
			this.intzaInfoTFEX.Items.Add(itemGrid84);
			this.intzaInfoTFEX.Items.Add(itemGrid85);
			this.intzaInfoTFEX.Items.Add(itemGrid86);
			this.intzaInfoTFEX.Items.Add(itemGrid87);
			this.intzaInfoTFEX.Items.Add(itemGrid88);
			this.intzaInfoTFEX.Items.Add(itemGrid89);
			this.intzaInfoTFEX.Items.Add(itemGrid90);
			this.intzaInfoTFEX.Items.Add(itemGrid91);
			this.intzaInfoTFEX.Items.Add(itemGrid92);
			this.intzaInfoTFEX.Items.Add(itemGrid93);
			this.intzaInfoTFEX.Items.Add(itemGrid94);
			this.intzaInfoTFEX.Items.Add(itemGrid95);
			this.intzaInfoTFEX.Items.Add(itemGrid96);
			this.intzaInfoTFEX.Items.Add(itemGrid97);
			this.intzaInfoTFEX.Items.Add(itemGrid98);
			this.intzaInfoTFEX.Items.Add(itemGrid99);
			this.intzaInfoTFEX.Items.Add(itemGrid100);
			this.intzaInfoTFEX.Items.Add(itemGrid101);
			this.intzaInfoTFEX.Items.Add(itemGrid102);
			this.intzaInfoTFEX.Items.Add(itemGrid103);
			this.intzaInfoTFEX.Items.Add(itemGrid104);
			this.intzaInfoTFEX.LineColor = Color.Red;
			this.intzaInfoTFEX.Location = new Point(612, 336);
			this.intzaInfoTFEX.Margin = new Padding(2);
			this.intzaInfoTFEX.Name = "intzaInfoTFEX";
			this.intzaInfoTFEX.Size = new Size(236, 158);
			this.intzaInfoTFEX.TabIndex = 93;
			this.intzaInfoTFEX.TabStop = false;
			clsPermission.DisplayBuySell = enumDisplayBuySell.Yes;
			clsPermission.HistoricalDay = 30.0;
			clsPermission.Permission = enumPermission.Visible;
			clsPermission.VolType = null;
			clsPermission.WordingType = null;
			this.wcGraphVolume.ActiveSET = clsPermission;
			clsPermission2.DisplayBuySell = enumDisplayBuySell.Yes;
			clsPermission2.HistoricalDay = 30.0;
			clsPermission2.Permission = enumPermission.Visible;
			clsPermission2.VolType = null;
			clsPermission2.WordingType = null;
			this.wcGraphVolume.ActiveTFEX = clsPermission2;
			this.wcGraphVolume.BackColor = Color.FromArgb(30, 30, 30);
			this.wcGraphVolume.ColorBg = Color.FromArgb(30, 30, 30);
			this.wcGraphVolume.ColorBuy = Color.Lime;
			this.wcGraphVolume.ColorCeiling = Color.Aqua;
			this.wcGraphVolume.ColorDown = Color.Red;
			this.wcGraphVolume.ColorFloor = Color.Fuchsia;
			this.wcGraphVolume.ColorGrid = Color.DarkGray;
			this.wcGraphVolume.ColorNoChg = Color.Yellow;
			this.wcGraphVolume.ColorSell = Color.Red;
			this.wcGraphVolume.ColorUp = Color.Lime;
			this.wcGraphVolume.ColorValue = Color.White;
			this.wcGraphVolume.ColorVolume = Color.Yellow;
			this.wcGraphVolume.CurDate = null;
			this.wcGraphVolume.dictIPO = (Dictionary<string, float>)componentResourceManager.GetObject("wcGraphVolume.dictIPO");
			this.wcGraphVolume.FontName = "Arial";
			this.wcGraphVolume.FontSize = 10f;
			this.wcGraphVolume.Location = new Point(435, 224);
			this.wcGraphVolume.Mode = 0;
			this.wcGraphVolume.Name = "wcGraphVolume";
			this.wcGraphVolume.Size = new Size(197, 69);
			this.wcGraphVolume.SymbolList = null;
			this.wcGraphVolume.SymbolType = enumType.eSet;
			this.wcGraphVolume.TabIndex = 94;
			this.wcGraphVolume.TextBoxBgColor = Color.Empty;
			this.wcGraphVolume.TextBoxForeColor = Color.Empty;
			this.wcGraphVolume.TypeMode = enumMode.Previous;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(888, 419);
			base.Controls.Add(this.wcGraphVolume);
			base.Controls.Add(this.intzaInfoTFEX);
			base.Controls.Add(this.intzaInfo);
			base.Controls.Add(this.intzaVolumeByBoard);
			base.Controls.Add(this.intzaLS);
			base.Controls.Add(this.intzaViewOddLotInfo);
			base.Controls.Add(this.intzaSaleByTime);
			base.Controls.Add(this.intzaSaleByPrice);
			base.Controls.Add(this.intzaViewOddLot);
			base.Controls.Add(this.intzaStockInPlay);
			base.Controls.Add(this.tStripMenu);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Margin = new Padding(4);
			base.Name = "frmStockSummary";
			this.Text = "Stock Summary";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmStockSummary_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmStockSummary_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmStockSummary_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmStockSummary_IDoCustomSizeChanged);
			base.IDoSymbolLinked += new ClientBaseForm.OnSymbolLinkEventHandler(this.frmStockSummary_IDoSymbolLinked);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmStockSummary_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmStockSummary_IDoReActivated);
			base.Controls.SetChildIndex(this.tStripMenu, 0);
			base.Controls.SetChildIndex(this.intzaStockInPlay, 0);
			base.Controls.SetChildIndex(this.intzaViewOddLot, 0);
			base.Controls.SetChildIndex(this.intzaSaleByPrice, 0);
			base.Controls.SetChildIndex(this.intzaSaleByTime, 0);
			base.Controls.SetChildIndex(this.intzaViewOddLotInfo, 0);
			base.Controls.SetChildIndex(this.intzaLS, 0);
			base.Controls.SetChildIndex(this.intzaVolumeByBoard, 0);
			base.Controls.SetChildIndex(this.intzaInfo, 0);
			base.Controls.SetChildIndex(this.intzaInfoTFEX, 0);
			base.Controls.SetChildIndex(this.wcGraphVolume, 0);
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00081E84 File Offset: 0x00080284
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmStockSummary() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._currentPage = "Stock in Play";
			this._stockInfoSET = null;
			this._seriesInfoTFEX = null;
			this.maxTopStockInPlay = 19;
			this.priceAtTopGrid = 0.0m;
			this.priceAtBottomGrid = 0.0m;
			this._buyDeals = 0;
			this._sellDeals = 0;
			this.bgwStockInPlayLoadData = null;
			this._dsStockInPlay = null;
			this.bgwSaleByPriceLoadData = null;
			this.dsSaleByPrice = null;
			this._saleByTimePageNo = 1;
			this.bgwSaleByTimeLoadData = null;
			this._dsSaleByTime = null;
			this.bgwViewOddLotLoadData = null;
			this._dsViewOddLot = null;
			this._currentSymbol = string.Empty;
			this._isNewStock = false;
			this._tfexBidPrice1 = 0m;
			this._tfexBidPrice2 = 0m;
			this._tfexBidPrice3 = 0m;
			this._tfexBidPrice4 = 0m;
			this._tfexBidPrice5 = 0m;
			this._tfexAskPrice1 = 0m;
			this._tfexAskPrice2 = 0m;
			this._tfexAskPrice3 = 0m;
			this._tfexAskPrice4 = 0m;
			this._tfexAskPrice5 = 0m;
			base..ctor();
			this.InitializeComponent();
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00081FD4 File Offset: 0x000803D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmStockSummary(Dictionary<string, object> propertiesValue, string currentPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._currentPage = "Stock in Play";
			this._stockInfoSET = null;
			this._seriesInfoTFEX = null;
			this.maxTopStockInPlay = 19;
			this.priceAtTopGrid = 0.0m;
			this.priceAtBottomGrid = 0.0m;
			this._buyDeals = 0;
			this._sellDeals = 0;
			this.bgwStockInPlayLoadData = null;
			this._dsStockInPlay = null;
			this.bgwSaleByPriceLoadData = null;
			this.dsSaleByPrice = null;
			this._saleByTimePageNo = 1;
			this.bgwSaleByTimeLoadData = null;
			this._dsSaleByTime = null;
			this.bgwViewOddLotLoadData = null;
			this._dsViewOddLot = null;
			this._currentSymbol = string.Empty;
			this._isNewStock = false;
			this._tfexBidPrice1 = 0m;
			this._tfexBidPrice2 = 0m;
			this._tfexBidPrice3 = 0m;
			this._tfexBidPrice4 = 0m;
			this._tfexBidPrice5 = 0m;
			this._tfexAskPrice1 = 0m;
			this._tfexAskPrice2 = 0m;
			this._tfexAskPrice3 = 0m;
			this._tfexAskPrice4 = 0m;
			this._tfexAskPrice5 = 0m;
			base..ctor(propertiesValue);
			this._currentPage = currentPage;
			this.Init();
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0008212C File Offset: 0x0008052C
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
				this.intzaStockInPlay.Hide();
				this.intzaSaleByTime.Hide();
				this.intzaSaleByPrice.Hide();
				this.wcGraphVolume.Hide();
				this.intzaViewOddLot.Hide();
				this.intzaViewOddLotInfo.Hide();
				if (ApplicationInfo.IsSupportTfex)
				{
					this.tscbStock.Items.AddRange(ApplicationInfo.MultiAutoCompStringArr);
				}
				else
				{
					this.tscbStock.Items.AddRange(ApplicationInfo.StockAutoCompStringArr);
				}
				this.tscbStock.Sorted = true;
				this.tscbStock.AutoCompleteMode = AutoCompleteMode.Suggest;
				this.tscbStock.AutoCompleteSource = AutoCompleteSource.ListItems;
				this.bgwStockInPlayLoadData = new BackgroundWorker();
				this.bgwStockInPlayLoadData.DoWork += new DoWorkEventHandler(this.bgwStockInPlayLoadData_DoWork);
				this.bgwStockInPlayLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwStockInPlayLoadData_RunWorkerCompleted);
				this.bgwSaleByPriceLoadData = new BackgroundWorker();
				this.bgwSaleByPriceLoadData.DoWork += new DoWorkEventHandler(this.bgwSaleByPriceLoadData_DoWork);
				this.bgwSaleByPriceLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwSaleByPriceLoadData_RunWorkerCompleted);
				this.bgwSaleByTimeLoadData = new BackgroundWorker();
				this.bgwSaleByTimeLoadData.DoWork += new DoWorkEventHandler(this.bgwSaleByTimeLoadData_DoWork);
				this.bgwSaleByTimeLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwSaleByTimeLoadData_RunWorkerCompleted);
				this.bgwViewOddLotLoadData = new BackgroundWorker();
				this.bgwViewOddLotLoadData.DoWork += new DoWorkEventHandler(this.bgwViewOddLotLoadData_DoWork);
				this.bgwViewOddLotLoadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwViewOddLotLoadData_RunWorkerCompleted);
				this.tscbSelection.Items.Clear();
				this.tscbSelection.Items.Add("Stock in Play");
				this.tscbSelection.Items.Add("Sale by Price");
				this.tscbSelection.Items.Add("Sale by Time");
				this.tscbSelection.Items.Add("View Oddlot");
				this.wcGraphVolume.ColorBuy = MyColor.BuyColor;
				this.wcGraphVolume.ColorSell = MyColor.SellColor;
				this.wcGraphVolume.ColorVolume = MyColor.OpenColor;
				this.wcGraphVolume.ColorUp = MyColor.UpColor;
				this.wcGraphVolume.ColorDown = MyColor.DownColor;
				this.wcGraphVolume.ColorNoChg = MyColor.UnChgColor;
				this.intzaViewOddLotInfo.Item("ceiling").FontColor = MyColor.CeilingColor;
				this.intzaViewOddLotInfo.Item("floor").FontColor = MyColor.FloorColor;
				this.intzaViewOddLotInfo.Item("prior").FontColor = MyColor.UnChgColor;
				if (ApplicationInfo.SupportFreewill)
				{
					this.intzaInfo.Item("lbMarginRate").Visible = false;
					this.intzaInfo.Item("tbMarginRate").Visible = false;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("Init", ex);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00082488 File Offset: 0x00080888
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockSummary_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetPage(this._currentPage);
			this.SetResize();
			base.Show();
			base.OpenedForm();
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000824BC File Offset: 0x000808BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockSummary_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaInfo.Item("open_vol").FontColor = MyColor.OpenColor;
				this.intzaInfo.Item("buy_vol").FontColor = MyColor.BuyColor;
				this.intzaInfo.Item("sel_vol").FontColor = MyColor.SellColor;
				this.intzaInfo.Item("p_open_vol").FontColor = MyColor.UnChgColor;
				this.intzaInfo.Item("p_buy_vol").FontColor = MyColor.BuyColor;
				this.intzaInfo.Item("p_sel_vol").FontColor = MyColor.SellColor;
				this.intzaInfo.Item("spread").FontColor = MyColor.UnChgColor;
				this.intzaInfo.Item("par").FontColor = MyColor.UnChgColor;
				this.ReloadDataPage(this._currentPage, true);
			}
			catch (Exception ex)
			{
				this.ShowError("frmStockSummary_IDoLoadData", ex);
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000825EC File Offset: 0x000809EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockSummary_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetPage(this._currentPage);
				this.SetResize();
				base.Show();
				this.ReloadDataPage(this._currentPage, this.IsHeightChanged);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00082648 File Offset: 0x00080A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockSummary_IDoCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize();
				if (this.IsHeightChanged)
				{
					string currentPage = this._currentPage;
					if (currentPage != null)
					{
						if (!(currentPage == "Sale by Time"))
						{
							if (currentPage == "Stock in Play")
							{
								if (this._stockInfoSET != null)
								{
									this.StockInPlayReloadData(0m, "", this._stockInfoSET.Number);
								}
								else if (this._seriesInfoTFEX != null)
								{
									this.StockInPlayReloadData_TFEX(this._seriesInfoTFEX.Symbol, this._seriesInfoTFEX.SeriesType, this._seriesInfoTFEX.TickSize, 0m, "");
								}
							}
						}
						else
						{
							this.SaleByTimeReloadData();
						}
					}
				}
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00082744 File Offset: 0x00080B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockSummary_IDoFontChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize();
				if (this._currentPage == "Stock in Play")
				{
					this.StockInPlay_SetNewStock(ApplicationInfo.CurrentSymbol, true);
				}
				else if (this._currentPage == "Sale by Time")
				{
					this.SaleByTime_SetNewStock(ApplicationInfo.CurrentSymbol, true);
				}
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000827CC File Offset: 0x00080BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockSummary_IDoMainFormKeyUp(KeyEventArgs e)
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
					if (this._currentPage == "Stock in Play")
					{
						this._currentPage = "Sale by Price";
					}
					else if (this._currentPage == "Sale by Price")
					{
						this._currentPage = "Sale by Time";
					}
					else if (this._currentPage == "Sale by Time")
					{
						this._currentPage = "View Oddlot";
					}
					else if (this._currentPage == "View Oddlot")
					{
						this._currentPage = "Stock in Play";
					}
					this.SetPage(this._currentPage);
					this.SetResize();
					this.ReloadDataPage(this._currentPage, true);
				}
			}
			else
			{
				this.tscbStock.Focus();
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000828E0 File Offset: 0x00080CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockSummary_IDoSymbolLinked(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (source == SymbolLinkSource.StockSymbol)
				{
					if (this._currentPage == "Stock in Play")
					{
						this.StockInPlay_SetNewStock(newStock, false);
					}
					else if (this._currentPage == "Sale by Price")
					{
						this.SaleByPrice_SetNewStock(newStock, false);
					}
					else if (this._currentPage == "Sale by Time")
					{
						this.SaleByTime_SetNewStock(newStock, false);
					}
					else if (this._currentPage == "View Oddlot")
					{
						this.ViewOddLotSetNewStock(newStock, false);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmStockSummary_IDoSymbolLinked", ex);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000829D4 File Offset: 0x00080DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetResize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				int height = this.tStripMenu.Height;
				int num = (int)((double)base.ClientSize.Width * 0.68);
				int num2 = base.ClientSize.Height - height;
				this.tscbSelection.Text = this._currentPage;
				this.tscbStock.DropDownWidth = this.tscbStock.Width;
				if (this._currentPage == "Stock in Play")
				{
					this.intzaStockInPlay.SetBounds(0, height, num, num2);
					if (this.intzaStockInPlay.GetRecordPerPage() != this.intzaStockInPlay.Rows)
					{
						this.intzaStockInPlay.SetRowByHeight();
						this.maxTopStockInPlay = this.intzaStockInPlay.Rows - 1;
					}
				}
				else if (this._currentPage == "Sale by Price")
				{
					this.intzaSaleByPrice.SetBounds(0, height, num, num2 / 2);
					this.wcGraphVolume.SetBounds(0, this.intzaSaleByPrice.Bottom + 1, this.intzaSaleByPrice.Width, num2 - (this.intzaSaleByPrice.Height + 1));
				}
				else if (this._currentPage == "Sale by Time")
				{
					this.intzaSaleByTime.SetBounds(0, height, num, num2);
					if (this.intzaSaleByTime.GetRecordPerPage() != this.intzaSaleByTime.Rows)
					{
						this.intzaSaleByTime.SetRowByHeight();
					}
				}
				else if (this._currentPage == "View Oddlot")
				{
					this.intzaViewOddLotInfo.SetBounds(0, height, num, this.intzaViewOddLotInfo.MyBottom);
					this.intzaViewOddLot.SetBounds(0, this.intzaViewOddLotInfo.Bottom + 1, num, num2 - (this.intzaViewOddLotInfo.Height + 1));
				}
				if (this._currentPage == "View Oddlot")
				{
					this.intzaLS.SetBounds(num + 1, height, base.ClientSize.Width - (num + 1), num2);
				}
				else
				{
					this.intzaInfo.SetBounds(num + 2, height + 2, base.ClientSize.Width - (num + 2), this.intzaInfo.MyBottom);
					this.intzaInfoTFEX.Bounds = this.intzaInfo.Bounds;
					this.intzaVolumeByBoard.SetBounds(this.intzaInfo.Left, base.ClientSize.Height - this.intzaVolumeByBoard.GetHeightByRows() - 2, this.intzaInfo.Width, this.intzaVolumeByBoard.GetHeightByRows());
					this.intzaLS.SetBounds(this.intzaInfo.Left, this.intzaInfo.Bottom + 2, this.intzaInfo.Width, this.intzaVolumeByBoard.Top - this.intzaInfo.Bottom - 4);
					if (this.intzaLS.GetRecordPerPage() != this.intzaLS.Rows)
					{
						this.intzaLS.SetRowByHeight();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetResizeByTab", ex);
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00082D7C File Offset: 0x0008117C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbStock_KeyPress(object sender, KeyPressEventArgs e)
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
				this.ShowError("tscmbStock_KeyPress", ex);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00082DE4 File Offset: 0x000811E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbStock_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._currentPage == "Stock in Play")
			{
				if (e.KeyCode == Keys.Return)
				{
					this.StockInPlay_SetNewStock(this.tscbStock.Text.Trim(), false);
				}
			}
			else if (this._currentPage == "Sale by Price")
			{
				if (e.KeyCode == Keys.Return)
				{
					this.SaleByPrice_SetNewStock(this.tscbStock.Text.Trim(), false);
				}
			}
			else if (this._currentPage == "Sale by Time")
			{
				if (e.KeyCode == Keys.Return)
				{
					this.SaleByTime_SetNewStock(this.tscbStock.Text.Trim(), false);
				}
				else if (e.KeyCode == Keys.Right)
				{
					this.tstxtSaleByTimeSearchTimeHour.Focus();
					this.tstxtSaleByTimeSearchTimeHour.SelectAll();
				}
			}
			else if (this._currentPage == "View Oddlot")
			{
				if (e.KeyCode == Keys.Return)
				{
					this.ViewOddLotSetNewStock(this.tscbStock.Text.Trim(), false);
				}
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00082F68 File Offset: 0x00081368
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnStockInPlayPrevPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._stockInfoSET != null && this._stockInfoSET.Number > 0)
			{
				if (this._stockInfoSET.Number > 0 && this.priceAtTopGrid > 0m && this.priceAtTopGrid < this._stockInfoSET.Ceiling)
				{
					this.StockInPlayReloadData(this.priceAtTopGrid, "+", this._stockInfoSET.Number);
				}
			}
			else if (this._seriesInfoTFEX != null)
			{
				if (this.priceAtTopGrid > 0m && this.priceAtTopGrid < this._seriesInfoTFEX.Ceiling)
				{
					this.StockInPlayReloadData_TFEX(this._seriesInfoTFEX.Symbol, this._seriesInfoTFEX.SeriesType, this._seriesInfoTFEX.TickSize, this.priceAtTopGrid, "+");
				}
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000830A4 File Offset: 0x000814A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnStockInPlayNextPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._stockInfoSET != null && this._stockInfoSET.Number > 0)
			{
				if (this._stockInfoSET.Number > 0 && this.priceAtBottomGrid > 0m && this.priceAtBottomGrid > this._stockInfoSET.Floor)
				{
					this.StockInPlayReloadData(this.priceAtBottomGrid, "-", this._stockInfoSET.Number);
				}
			}
			else if (this._seriesInfoTFEX != null)
			{
				if (this.priceAtTopGrid > 0m && this.priceAtTopGrid > this._seriesInfoTFEX.Floor)
				{
					this.StockInPlayReloadData_TFEX(this._seriesInfoTFEX.Symbol, this._seriesInfoTFEX.SeriesType, this._seriesInfoTFEX.TickSize, this.priceAtBottomGrid, "-");
				}
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000831E0 File Offset: 0x000815E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstxtSaleByTimeSearchTimeHour_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				switch (keyCode)
				{
				case Keys.Left:
					this.tscbStock.Focus();
					e.SuppressKeyPress = true;
					return;
				case Keys.Up:
					return;
				case Keys.Right:
					break;
				default:
					return;
				}
			}
			this.tstxtSaleByTimeSearchTimeMinute.Focus();
			this.tstxtSaleByTimeSearchTimeMinute.SelectAll();
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0008325C File Offset: 0x0008165C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstxtSaleByTimeSearchTimeMinute_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				switch (keyCode)
				{
				case Keys.Left:
					this.tstxtSaleByTimeSearchTimeHour.Focus();
					this.tstxtSaleByTimeSearchTimeHour.SelectAll();
					break;
				case Keys.Right:
					e.SuppressKeyPress = true;
					break;
				}
			}
			else
			{
				this.SaleByTime_SetNewStock(this.tscbStock.Text.Trim(), true);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000832E8 File Offset: 0x000816E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSaleByTimeFirstPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._saleByTimePageNo != 1)
			{
				this._saleByTimePageNo = 1;
				this.SaleByTimeReloadData();
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00083324 File Offset: 0x00081724
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSaleByTimePrevPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._saleByTimePageNo - 1 > 0)
			{
				this._saleByTimePageNo--;
				this.SaleByTimeReloadData();
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0008336C File Offset: 0x0008176C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSaleByTimeNextPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.intzaSaleByTime.Records(this.intzaSaleByTime.Rows - 1).Fields("price").Text.ToString() != string.Empty)
				{
					this._saleByTimePageNo++;
					this.SaleByTimeReloadData();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnSaleByTimeNextPage_Click", ex);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0008340C File Offset: 0x0008180C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwStockInPlayLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				try
				{
					if (this._stockInfoSET != null)
					{
						string[] array = ((string)e.Argument).Split(new char[]
						{
							'|'
						});
						decimal startPrice = 0m;
						decimal.TryParse(array[0].ToString(), out startPrice);
						string text = array[1].ToString();
						int securityNumber = 0;
						int.TryParse(array[2].ToString(), out securityNumber);
						base.IsLoadingData = true;
						if (this.intzaLS.GetRecordPerPage() != this.intzaLS.Rows)
						{
							this.intzaLS.SetRowByHeight();
						}
						string text2 = ApplicationInfo.WebService.StockInPlay(securityNumber, startPrice, text, this.maxTopStockInPlay, this.intzaLS.GetRecordPerPage());
						if (this._dsStockInPlay != null)
						{
							this._dsStockInPlay.Clear();
							this._dsStockInPlay = null;
						}
						this._dsStockInPlay = new DataSet();
						if (!string.IsNullOrEmpty(text2))
						{
							MyDataHelper.StringToDataSet(text2, this._dsStockInPlay);
						}
					}
					else if (this._seriesInfoTFEX != null)
					{
						string[] array = ((string)e.Argument).Split(new char[]
						{
							'|'
						});
						decimal startPrice = 0m;
						decimal.TryParse(array[0].ToString(), out startPrice);
						string text = array[1].ToString();
						string seriesName = array[2];
						string seriesType = array[3];
						decimal tickSize;
						decimal.TryParse(array[4].ToString(), out tickSize);
						base.IsLoadingData = true;
						string text2 = string.Empty;
						if (text.Equals(""))
						{
							text2 = ApplicationInfo.WebServiceTFEX.StockInPlay(seriesName, seriesType, tickSize, ApplicationInfo.IndexInfoTfex.TXISession, startPrice, text, this.maxTopStockInPlay - 1, this.intzaLS.GetRecordPerPage());
						}
						else
						{
							text2 = ApplicationInfo.WebServiceTFEX.StockInPlay(seriesName, seriesType, tickSize, ApplicationInfo.IndexInfoTfex.TXISession, startPrice, text, this.maxTopStockInPlay - 1, this.intzaLS.GetRecordPerPage());
						}
						if (this._dsStockInPlay != null)
						{
							this._dsStockInPlay.Clear();
							this._dsStockInPlay = null;
						}
						this._dsStockInPlay = new DataSet();
						if (!string.IsNullOrEmpty(text2))
						{
							MyDataHelper.StringToDataSet(text2, this._dsStockInPlay);
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("bgwStockInPlayLoadData_DoWork", ex);
				}
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000836D8 File Offset: 0x00081AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwStockInPlayLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					if (e.Error == null)
					{
						if (this._stockInfoSET != null)
						{
							this.StockInPlayUpdateToControl();
						}
						else
						{
							this.StockInPlayUpdateToControl_TFEX();
						}
						this._dsStockInPlay.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwStockInPlayLoadData_RunWorkerCompleted", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00083780 File Offset: 0x00081B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSaleByPriceLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				base.IsLoadingData = true;
				try
				{
					if (this._stockInfoSET != null)
					{
						string text = ApplicationInfo.WebService.SaleByPrice(this._stockInfoSET.Number, 1, 999, this.intzaLS.GetRecordPerPage());
						if (!string.IsNullOrEmpty(text))
						{
							if (this.dsSaleByPrice == null)
							{
								this.dsSaleByPrice = new DataSet();
							}
							else
							{
								this.dsSaleByPrice.Clear();
							}
							MyDataHelper.StringToDataSet(text, this.dsSaleByPrice);
						}
					}
					else
					{
						string text = ApplicationInfo.WebServiceTFEX.SeriesSaleByPrice(this._seriesInfoTFEX.Symbol, this._seriesInfoTFEX.SeriesType, 999);
						if (!string.IsNullOrEmpty(text))
						{
							if (this.dsSaleByPrice == null)
							{
								this.dsSaleByPrice = new DataSet();
							}
							else
							{
								this.dsSaleByPrice.Clear();
							}
							MyDataHelper.StringToDataSet(text, this.dsSaleByPrice);
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("bgwSaleByPriceLoadData_DoWork", ex);
				}
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000838F0 File Offset: 0x00081CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSaleByPriceLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					if (e.Error == null)
					{
						if (this._stockInfoSET != null)
						{
							this.SaleByPriceUpdateToControl();
							this.dsSaleByPrice.Clear();
						}
						else
						{
							this.SaleByPriceUpdateToControl_TFEX();
							this.dsSaleByPrice.Clear();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSaleByPriceLoadData_RunWorkerCompleted", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000839A8 File Offset: 0x00081DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSaleByTimeLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				try
				{
					base.IsLoadingData = true;
					string text = string.Empty;
					if (!string.IsNullOrEmpty(this.tstxtSaleByTimeSearchTimeHour.Text))
					{
						int num = 0;
						int.TryParse(this.tstxtSaleByTimeSearchTimeHour.Text, out num);
						if (num > 0 || num < 24)
						{
							string text2 = string.IsNullOrEmpty(this.tstxtSaleByTimeSearchTimeMinute.Text) ? "00" : this.tstxtSaleByTimeSearchTimeMinute.Text;
							int num2 = 0;
							int.TryParse(this.tstxtSaleByTimeSearchTimeHour.Text, out num2);
							if (num2 > 0)
							{
								if (this._stockInfoSET != null)
								{
									text = ((num2 < 10) ? "09" : num2.ToString()) + ":" + text2 + ":59";
								}
								else if (this._seriesInfoTFEX != null)
								{
									text = ((num2 < 10) ? "09" : num2.ToString()) + text2 + "59";
								}
							}
							else
							{
								text = string.Empty;
							}
						}
						else
						{
							text = string.Empty;
						}
					}
					else
					{
						text = string.Empty;
					}
					if (this._stockInfoSET != null)
					{
						ApplicationInfo.CurrentSymbol = this._stockInfoSET.Symbol;
						string text3 = ApplicationInfo.WebService.SaleByTime2(this._stockInfoSET.Number, (this._saleByTimePageNo - 1) * this.intzaSaleByTime.Rows + 1, this.intzaSaleByTime.Rows, this.intzaLS.GetRecordPerPage(), text);
						if (this._dsSaleByTime == null)
						{
							this._dsSaleByTime = new DataSet();
						}
						else
						{
							this._dsSaleByTime.Clear();
						}
						if (!string.IsNullOrEmpty(text3))
						{
							MyDataHelper.StringToDataSet(text3, this._dsSaleByTime);
						}
					}
					else if (this._seriesInfoTFEX != null)
					{
						string text3 = ApplicationInfo.WebServiceTFEX.SeriesSaleByTime(this._seriesInfoTFEX.Symbol, this._seriesInfoTFEX.SeriesType, this._saleByTimePageNo, this.intzaSaleByTime.Rows, this.intzaLS.GetRecordPerPage(), text);
						if (this._dsSaleByTime == null)
						{
							this._dsSaleByTime = new DataSet();
						}
						else
						{
							this._dsSaleByTime.Clear();
						}
						if (!string.IsNullOrEmpty(text3))
						{
							MyDataHelper.StringToDataSet(text3, this._dsSaleByTime);
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("bgwSaleByTimeLoadData_DoWork", ex);
				}
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00083CBC File Offset: 0x000820BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSaleByTimeLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				if (e.Error == null)
				{
					if (this._stockInfoSET != null)
					{
						this.SaleByTimeUpdateToControl();
					}
					else if (this._seriesInfoTFEX != null)
					{
						this.SaleByTimeUpdateToControl_TFEX();
					}
					this._dsSaleByTime.Clear();
				}
				base.IsLoadingData = false;
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00083D48 File Offset: 0x00082148
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwViewOddLotLoadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				try
				{
					string text = ApplicationInfo.WebService.ViewOddlot(this._stockInfoSET.Number, this.intzaLS.GetRecordPerPage());
					if (this._dsViewOddLot == null)
					{
						this._dsViewOddLot = new DataSet();
					}
					else
					{
						this._dsViewOddLot.Clear();
					}
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this._dsViewOddLot);
					}
				}
				catch (Exception ex)
				{
					this.ShowError("bgwViewOddLotLoadData_DoWork", ex);
				}
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00083E10 File Offset: 0x00082210
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwViewOddLotLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				this.ViewOddLotUpdateToControl(this._dsViewOddLot);
				this._dsViewOddLot.Clear();
				base.IsLoadingData = false;
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00083E60 File Offset: 0x00082260
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Dictionary<string, object> DoPackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return base.PropertiesValue;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00083E8C File Offset: 0x0008228C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DoUnpackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00083EA0 File Offset: 0x000822A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadDataPage(string page, bool isForce)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmStockSummary.ReloadDataPageCallBack(this.ReloadDataPage), new object[]
				{
					page,
					isForce
				});
			}
			else
			{
				try
				{
					if (page == "Stock in Play")
					{
						if (isForce || this.tscbStock.Text != ApplicationInfo.CurrentSymbol)
						{
							this.tscbStock.Text = ApplicationInfo.CurrentSymbol;
							this.StockInPlay_SetNewStock(ApplicationInfo.CurrentSymbol, isForce);
						}
						else
						{
							this.tscbStock.Focus();
						}
					}
					else if (page == "Sale by Price")
					{
						if (isForce || this.tscbStock.Text != ApplicationInfo.CurrentSymbol)
						{
							this.tscbStock.Text = ApplicationInfo.CurrentSymbol;
							this.SaleByPrice_SetNewStock(ApplicationInfo.CurrentSymbol, isForce);
						}
						else
						{
							this.tscbStock.Focus();
						}
					}
					else if (page == "Sale by Time")
					{
						if (isForce || this.tscbStock.Text != ApplicationInfo.CurrentSymbol)
						{
							this.tscbStock.Text = ApplicationInfo.CurrentSymbol;
							this.SaleByTime_SetNewStock(ApplicationInfo.CurrentSymbol, isForce);
						}
						else
						{
							this.tscbStock.Focus();
						}
					}
					else if (page == "View Oddlot")
					{
						if (isForce || this.tscbStock.Text != ApplicationInfo.CurrentSymbol)
						{
							this.tscbStock.Text = ApplicationInfo.CurrentSymbol;
							this.ViewOddLotSetNewStock(ApplicationInfo.CurrentSymbol, isForce);
						}
						else
						{
							this.tscbStock.Focus();
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ReloadDataPage", ex);
				}
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00084114 File Offset: 0x00082514
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlay_SetNewStock(string symbol, bool isForce)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (symbol != string.Empty && (isForce || symbol != this._currentSymbol))
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[symbol];
					if (stockInformation.Number > 0)
					{
						this._stockInfoSET = stockInformation;
						this._seriesInfoTFEX = null;
						this.intzaInfo.Visible = true;
						this.intzaInfoTFEX.Visible = false;
						ApplicationInfo.CurrentSymbol = this._stockInfoSET.Symbol;
						this._currentSymbol = this._stockInfoSET.Symbol;
						this.StockInPlayReloadData(0m, "", this._stockInfoSET.Number);
					}
					else
					{
						SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[symbol];
						if (seriesInformation.Symbol != string.Empty)
						{
							this._isNewStock = true;
							this._currentSymbol = seriesInformation.Symbol;
							this._seriesInfoTFEX = seriesInformation;
							this._stockInfoSET = null;
							this.intzaInfoTFEX.Visible = true;
							this.intzaInfo.Visible = false;
							ApplicationInfo.CurrentSymbol = seriesInformation.Symbol;
							this.StockInPlayReloadData_TFEX(seriesInformation.Symbol, seriesInformation.SeriesType, seriesInformation.TickSize, 0m, "");
						}
					}
				}
				if (this.tscbStock.Text != ApplicationInfo.CurrentSymbol)
				{
					this.tscbStock.Text = ApplicationInfo.CurrentSymbol;
				}
				this.tscbStock.Focus();
				this.tscbStock.SelectAll();
			}
			catch (Exception ex)
			{
				this.ShowError("StockInPlaySetNewStock", ex);
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00084310 File Offset: 0x00082710
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayReloadData(decimal currentPrice, string sign, int stockNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwStockInPlayLoadData.IsBusy)
			{
				this.bgwStockInPlayLoadData.RunWorkerAsync(string.Concat(new object[]
				{
					currentPrice,
					"|",
					sign,
					"|",
					stockNumber
				}));
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00084380 File Offset: 0x00082780
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayReloadData_TFEX(string seriesName, string seriesType, decimal tickSize, decimal currentPrice, string sign)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwStockInPlayLoadData.IsBusy)
			{
				this.bgwStockInPlayLoadData.RunWorkerAsync(string.Concat(new object[]
				{
					currentPrice,
					"|",
					sign,
					"|",
					seriesName,
					"|",
					seriesType,
					"|",
					tickSize.ToString()
				}));
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0008440C File Offset: 0x0008280C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayUpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaStockInPlay.BeginUpdate();
				if (this._dsStockInPlay.Tables.Contains("security_stat") && this._dsStockInPlay.Tables["security_stat"].Rows.Count > 0)
				{
					this.intzaStockInPlay.ClearAllText();
				}
				else
				{
					for (int i = 0; i < this.intzaStockInPlay.Rows - 1; i++)
					{
						this.intzaStockInPlay.ClearAllTextByRow(i);
					}
				}
				this.intzaLS.BeginUpdate();
				this.intzaLS.ClearAllText();
				this.priceAtBottomGrid = 0m;
				this.priceAtTopGrid = 0m;
				if (this._dsStockInPlay.Tables.Count > 0)
				{
					if (this._dsStockInPlay.Tables.Contains("stockinplay_price"))
					{
						if (this._dsStockInPlay.Tables["stockinplay_price"].Rows.Count > 0)
						{
							DataRow dataRow = this._dsStockInPlay.Tables["stockinplay_price"].Rows[0];
							string[] array = dataRow["price_list"].ToString().Split(new char[]
							{
								';'
							});
							int num = 0;
							for (int j = array.Length - 1; j >= 0; j--)
							{
								decimal num2;
								if (decimal.TryParse(array[j], out num2))
								{
									if ((num2 >= this._stockInfoSET.Floor && num2 <= this._stockInfoSET.Ceiling) || num2 == 0m)
									{
										this.intzaStockInPlay.Records(num).Fields("price").Text = Utilities.PriceFormat(array[j]);
										this.intzaStockInPlay.Records(num).Fields("price").FontColor = Utilities.ComparePriceCFColor(num2, this._stockInfoSET);
										this.intzaStockInPlay.Records(num).Fields("price").BackColor = Color.FromArgb(30, 30, 30);
										num++;
									}
								}
							}
							this.priceAtBottomGrid = 0m;
							if (array[0] != string.Empty)
							{
								this.priceAtBottomGrid = Convert.ToDecimal(array[0]);
							}
							this.priceAtTopGrid = 0m;
							if (array[array.Length - 1] != string.Empty)
							{
								this.priceAtTopGrid = Convert.ToDecimal(array[array.Length - 1]);
							}
							int.TryParse(dataRow["buy_deals"].ToString(), out this._buyDeals);
							int.TryParse(dataRow["sell_deals"].ToString(), out this._sellDeals);
						}
					}
					if (this._dsStockInPlay.Tables.Contains("security_stat") && this._dsStockInPlay.Tables["security_stat"].Rows.Count > 0)
					{
						long num3;
						long.TryParse(this._dsStockInPlay.Tables["security_stat"].Rows[0]["buy_volume"].ToString(), out num3);
						long num4;
						long.TryParse(this._dsStockInPlay.Tables["security_stat"].Rows[0]["sell_volume"].ToString(), out num4);
						long openVolume;
						long.TryParse(this._dsStockInPlay.Tables["security_stat"].Rows[0]["open_volume"].ToString(), out openVolume);
						this.StockInPlayUpdateTotalVolumeAndTotalDeals(num3, num4, openVolume);
					}
					if (this._dsStockInPlay.Tables.Contains("sale_by_price"))
					{
						foreach (DataRow dataRow in this._dsStockInPlay.Tables["sale_by_price"].Rows)
						{
							decimal num2;
							decimal.TryParse(dataRow["price"].ToString(), out num2);
							long num3;
							long.TryParse(dataRow["buy_volume"].ToString(), out num3);
							int deals;
							int.TryParse(dataRow["buy_deals"].ToString(), out deals);
							this.StockInPlayUpdateBuySellVolume("B", num2, num3, deals);
							long num4;
							long.TryParse(dataRow["sell_volume"].ToString(), out num4);
							int deals2;
							int.TryParse(dataRow["sell_deals"].ToString(), out deals2);
							this.StockInPlayUpdateBuySellVolume("S", num2, num4, deals2);
						}
					}
					if (this._dsStockInPlay.Tables.Contains("security_stat") && this._dsStockInPlay.Tables["security_stat"].Rows.Count > 0)
					{
						DataRow dataRow = this._dsStockInPlay.Tables["security_stat"].Rows[0];
						decimal.TryParse(dataRow["bid_price1"].ToString(), out this._tfexBidPrice1);
						decimal.TryParse(dataRow["bid_price2"].ToString(), out this._tfexBidPrice2);
						decimal.TryParse(dataRow["bid_price3"].ToString(), out this._tfexBidPrice3);
						decimal.TryParse(dataRow["bid_price4"].ToString(), out this._tfexBidPrice4);
						decimal.TryParse(dataRow["bid_price5"].ToString(), out this._tfexBidPrice5);
						long volume;
						long.TryParse(dataRow["bid_volume1"].ToString(), out volume);
						long volume2;
						long.TryParse(dataRow["bid_volume2"].ToString(), out volume2);
						long volume3;
						long.TryParse(dataRow["bid_volume3"].ToString(), out volume3);
						long volume4;
						long.TryParse(dataRow["bid_volume4"].ToString(), out volume4);
						long volume5;
						long.TryParse(dataRow["bid_volume5"].ToString(), out volume5);
						this.StockInPlayUpdateTopPrice("B", this._tfexBidPrice1, this._tfexBidPrice2, this._tfexBidPrice3, this._tfexBidPrice4, this._tfexBidPrice5, volume, volume2, volume3, volume4, volume5);
						decimal.TryParse(dataRow["offer_price1"].ToString(), out this._tfexAskPrice1);
						decimal.TryParse(dataRow["offer_price2"].ToString(), out this._tfexAskPrice2);
						decimal.TryParse(dataRow["offer_price3"].ToString(), out this._tfexAskPrice3);
						decimal.TryParse(dataRow["offer_price4"].ToString(), out this._tfexAskPrice4);
						decimal.TryParse(dataRow["offer_price5"].ToString(), out this._tfexAskPrice5);
						long.TryParse(dataRow["offer_volume1"].ToString(), out volume);
						long.TryParse(dataRow["offer_volume2"].ToString(), out volume2);
						long.TryParse(dataRow["offer_volume3"].ToString(), out volume3);
						long.TryParse(dataRow["offer_volume4"].ToString(), out volume4);
						long.TryParse(dataRow["offer_volume5"].ToString(), out volume5);
						this.StockInPlayUpdateTopPrice("S", this._tfexAskPrice1, this._tfexAskPrice2, this._tfexAskPrice3, this._tfexAskPrice4, this._tfexAskPrice5, volume, volume2, volume3, volume4, volume5);
					}
					this.UpdateToControl(this._dsStockInPlay);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl", ex);
			}
			finally
			{
				this.intzaStockInPlay.Redraw();
				this.intzaLS.Redraw();
				this.intzaInfo.Redraw();
				this.intzaVolumeByBoard.Redraw();
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00084D24 File Offset: 0x00083124
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayUpdateToControl_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaStockInPlay.BeginUpdate();
				this.intzaLS.BeginUpdate();
				this.intzaInfo.BeginUpdate();
				if (this._isNewStock)
				{
					this.intzaInfo.ClearAllText();
					this.intzaLS.ClearAllText();
					this.intzaStockInPlay.ClearAllText();
				}
				else
				{
					for (int i = 0; i < this.intzaStockInPlay.Rows - 1; i++)
					{
						this.intzaStockInPlay.ClearAllTextByRow(i);
					}
				}
				this._isNewStock = false;
				this.priceAtBottomGrid = 0m;
				this.priceAtTopGrid = 0m;
				if (this._dsStockInPlay.Tables.Count > 0)
				{
					if (this._dsStockInPlay.Tables.Contains("seriesinplay_price"))
					{
						if (this._dsStockInPlay.Tables["seriesinplay_price"].Rows.Count > 0)
						{
							DataRow dataRow = this._dsStockInPlay.Tables["seriesinplay_price"].Rows[0];
							string[] array = dataRow["price_list"].ToString().Split(new char[]
							{
								';'
							});
							int num = 0;
							for (int j = array.Length - 1; j >= 0; j--)
							{
								decimal num2;
								if (decimal.TryParse(array[j], out num2))
								{
									if ((num2 >= this._seriesInfoTFEX.Floor && num2 <= this._seriesInfoTFEX.Ceiling) || num2 == 0m)
									{
										if (num2 == 0m)
										{
											this.intzaStockInPlay.Records(num).Fields("price").Text = "0";
										}
										else
										{
											this.intzaStockInPlay.Records(num).Fields("price").Text = Utilities.PriceFormat(array[j], this._seriesInfoTFEX.NumOfDec);
										}
										this.intzaStockInPlay.Records(num).Fields("price").FontColor = Utilities.ComparePriceCFColor(num2, this._seriesInfoTFEX);
									}
								}
								else
								{
									this.intzaStockInPlay.Records(num).Fields("price").Text = "";
								}
								this.intzaStockInPlay.Records(num).Fields("price").BackColor = Color.FromArgb(50, 50, 50);
								num++;
							}
							this.priceAtBottomGrid = 0m;
							for (int k = 0; k < array.Length; k++)
							{
								if (array[k] != string.Empty)
								{
									this.priceAtBottomGrid = Convert.ToDecimal(array[k]);
									break;
								}
							}
							if (this.priceAtBottomGrid < this._seriesInfoTFEX.Floor)
							{
								this.priceAtBottomGrid = this._seriesInfoTFEX.Floor;
							}
							this.priceAtTopGrid = 0m;
							for (int k = array.Length - 1; k > -1; k--)
							{
								if (array[k] != string.Empty)
								{
									this.priceAtTopGrid = Convert.ToDecimal(array[k]);
									break;
								}
							}
							if (this.priceAtTopGrid > this._seriesInfoTFEX.Ceiling)
							{
								this.priceAtTopGrid = this._seriesInfoTFEX.Ceiling;
							}
							int.TryParse(dataRow["buy_deals"].ToString(), out this._buyDeals);
							int.TryParse(dataRow["sell_deals"].ToString(), out this._sellDeals);
						}
					}
					if (this._dsStockInPlay.Tables.Contains("series_info_stat") && this._dsStockInPlay.Tables["series_info_stat"].Rows.Count > 0)
					{
						long num3;
						long.TryParse(this._dsStockInPlay.Tables["series_info_stat"].Rows[0]["LongQty"].ToString(), out num3);
						long num4;
						long.TryParse(this._dsStockInPlay.Tables["series_info_stat"].Rows[0]["ShortQty"].ToString(), out num4);
						long openVolume;
						long.TryParse(this._dsStockInPlay.Tables["series_info_stat"].Rows[0]["TotalOpenQty"].ToString(), out openVolume);
						this.StockInPlayUpdateTotalVolumeAndTotalDeals(num3, num4, openVolume);
					}
					if (this._dsStockInPlay.Tables.Contains("sale_by_price"))
					{
						foreach (DataRow dataRow2 in this._dsStockInPlay.Tables["sale_by_price"].Rows)
						{
							decimal num2;
							decimal.TryParse(dataRow2["price"].ToString(), out num2);
							long num3;
							long.TryParse(dataRow2["long_volume"].ToString(), out num3);
							int dealBySide;
							int.TryParse(dataRow2["long_deals"].ToString(), out dealBySide);
							this.StockInPlayUpdateBuySellVolume_TFEX("B", num2, num3, dealBySide);
							long num4;
							long.TryParse(dataRow2["short_volume"].ToString(), out num4);
							int dealBySide2;
							int.TryParse(dataRow2["short_deals"].ToString(), out dealBySide2);
							this.StockInPlayUpdateBuySellVolume_TFEX("S", num2, num4, dealBySide2);
						}
					}
					if (this._dsStockInPlay.Tables.Contains("top_price") && this._dsStockInPlay.Tables["top_price"].Rows.Count > 0)
					{
						DataRow dataRow3 = this._dsStockInPlay.Tables["top_price"].Rows[0];
						decimal.TryParse(dataRow3["bidprice1"].ToString(), out this._tfexBidPrice1);
						decimal.TryParse(dataRow3["bidprice2"].ToString(), out this._tfexBidPrice2);
						decimal.TryParse(dataRow3["bidprice3"].ToString(), out this._tfexBidPrice3);
						decimal.TryParse(dataRow3["bidprice4"].ToString(), out this._tfexBidPrice4);
						decimal.TryParse(dataRow3["bidprice5"].ToString(), out this._tfexBidPrice5);
						long volume;
						long.TryParse(dataRow3["bidQty1"].ToString(), out volume);
						long volume2;
						long.TryParse(dataRow3["bidQty2"].ToString(), out volume2);
						long volume3;
						long.TryParse(dataRow3["bidQty3"].ToString(), out volume3);
						long volume4;
						long.TryParse(dataRow3["bidQty4"].ToString(), out volume4);
						long volume5;
						long.TryParse(dataRow3["bidQty5"].ToString(), out volume5);
						this.StockInPlayUpdateTopPrice_TFEX("B", this._tfexBidPrice1, this._tfexBidPrice2, this._tfexBidPrice3, this._tfexBidPrice4, this._tfexBidPrice5, volume, volume2, volume3, volume4, volume5);
						decimal.TryParse(dataRow3["Askprice1"].ToString(), out this._tfexAskPrice1);
						decimal.TryParse(dataRow3["Askprice2"].ToString(), out this._tfexAskPrice2);
						decimal.TryParse(dataRow3["Askprice3"].ToString(), out this._tfexAskPrice3);
						decimal.TryParse(dataRow3["Askprice4"].ToString(), out this._tfexAskPrice4);
						decimal.TryParse(dataRow3["Askprice5"].ToString(), out this._tfexAskPrice5);
						long.TryParse(dataRow3["AskQty1"].ToString(), out volume);
						long.TryParse(dataRow3["AskQty2"].ToString(), out volume2);
						long.TryParse(dataRow3["AskQty3"].ToString(), out volume3);
						long.TryParse(dataRow3["AskQty4"].ToString(), out volume4);
						long.TryParse(dataRow3["AskQty5"].ToString(), out volume5);
						this.StockInPlayUpdateTopPrice_TFEX("A", this._tfexAskPrice1, this._tfexAskPrice2, this._tfexAskPrice3, this._tfexAskPrice4, this._tfexAskPrice5, volume, volume2, volume3, volume4, volume5);
					}
					this.UpdateToControl_TFEX(this._dsStockInPlay);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl", ex);
			}
			finally
			{
				this.intzaStockInPlay.Redraw();
				this.intzaLS.Redraw();
				this.intzaInfo.Redraw();
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00085754 File Offset: 0x00083B54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateLastSaleTicker_TFEX(decimal price, string side, long volume, string lastUpdate, int index, SeriesList.SeriesInformation seriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.intzaLS.InvokeRequired)
				{
					this.intzaLS.Invoke(new frmStockSummary.UpdateLastSaleTicker_TFEXCallBack(this.UpdateLastSaleTicker_TFEX), new object[]
					{
						price,
						side,
						volume,
						lastUpdate,
						index,
						seriesInfo
					});
				}
				else
				{
					RecordItem recordItem;
					if (index == -1)
					{
						recordItem = this.intzaLS.AddRecord(1, true);
					}
					else
					{
						recordItem = this.intzaLS.Records(index);
					}
					recordItem.Fields("side").Text = side.ToString();
					recordItem.Fields("volume").Text = volume.ToString();
					recordItem.Fields("price").Text = Utilities.PriceFormat(price, seriesInfo.NumOfDec);
					recordItem.Fields("time").Text = Utilities.GetTimeLastSale(lastUpdate);
					Color fontColor = Utilities.ComparePriceCFColor(price, seriesInfo);
					recordItem.Fields("price").FontColor = fontColor;
					recordItem.Fields("time").FontColor = Color.LightGray;
					if (side == "B")
					{
						recordItem.Fields("side").FontColor = MyColor.BuyColor;
						recordItem.Fields("volume").FontColor = MyColor.BuyColor;
					}
					else if (side == "S")
					{
						recordItem.Fields("side").FontColor = MyColor.SellColor;
						recordItem.Fields("volume").FontColor = MyColor.SellColor;
					}
					else
					{
						recordItem.Fields("side").FontColor = MyColor.UnChgColor;
						recordItem.Fields("volume").FontColor = MyColor.UnChgColor;
					}
					recordItem.Changed = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateLastSaleTicker_TFEX", ex);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000859AC File Offset: 0x00083DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MainUpdateLastSalePrice_TFEX(decimal lastPrice, decimal high, decimal low, decimal accValue, long accVolume, SeriesList.SeriesInformation sf_TFEX)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal num = 0m;
				decimal num2 = 0m;
				Color fontColor = MyColor.UnChgColor;
				if (accVolume > 0L)
				{
					decimal num3 = Math.Round(accValue / accVolume, 2);
					this.intzaInfo.Item("tbAverage").Text = Utilities.PriceFormat(num3, sf_TFEX.NumOfDec);
					this.intzaInfo.Item("tbAverage").FontColor = Utilities.ComparePriceCFColor(num3, sf_TFEX);
				}
				if (sf_TFEX.PrevFixPrice > 0m && lastPrice > 0m)
				{
					num = lastPrice - sf_TFEX.PrevFixPrice;
					num2 = (lastPrice - sf_TFEX.PrevFixPrice) / sf_TFEX.PrevFixPrice * 100m;
					fontColor = Utilities.ComparePriceColor(num, 0m);
				}
				this.intzaInfo.Item("tbChange").Text = Utilities.PriceFormat(num, true, sf_TFEX.NumOfDec);
				this.intzaInfo.Item("tbChangePct").Text = Utilities.PriceFormat(num2, true, "%");
				this.intzaInfo.Item("tbChange").FontColor = fontColor;
				this.intzaInfo.Item("tbChangePct").FontColor = fontColor;
				this.intzaInfo.Item("tbHigh").Text = Utilities.PriceFormat(high, sf_TFEX.NumOfDec);
				this.intzaInfo.Item("tbLow").Text = Utilities.PriceFormat(low, sf_TFEX.NumOfDec);
				this.intzaInfo.Item("tbHigh").FontColor = Utilities.ComparePriceCFColor(high, sf_TFEX);
				this.intzaInfo.Item("tbLow").FontColor = Utilities.ComparePriceCFColor(low, sf_TFEX);
			}
			catch (Exception ex)
			{
				this.ShowError("MainUpdateLastSalePrice_TFEX", ex);
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00085C10 File Offset: 0x00084010
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayUpdateBuySellVolume_TFEX(string side, decimal price, long volume, int dealBySide)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price, this._seriesInfoTFEX.NumOfDec));
				if (recordItem != null)
				{
					int num = 0;
					decimal value = 0m;
					Color fontColor = recordItem.Fields("price").FontColor;
					if (side == "B")
					{
						int.TryParse(recordItem.Fields("buy_deal").Text.ToString().Replace(",", ""), out num);
						recordItem.Fields("buy_deal").Text = num + dealBySide;
						decimal.TryParse(recordItem.Fields("buy_volume").Text.ToString().Replace(",", ""), out value);
						recordItem.Fields("buy_volume").Text = Utilities.VolumeFormat((long)value + volume, true);
						recordItem.Fields("buy_deal").FontColor = fontColor;
						recordItem.Fields("buy_volume").FontColor = fontColor;
					}
					else if (side == "S")
					{
						int.TryParse(recordItem.Fields("sell_deal").Text.ToString().Replace(",", ""), out num);
						recordItem.Fields("sell_deal").Text = num + dealBySide;
						decimal.TryParse(recordItem.Fields("sell_vol").Text.ToString().Replace(",", ""), out value);
						recordItem.Fields("sell_vol").Text = Utilities.VolumeFormat((long)value + volume, true);
						recordItem.Fields("sell_vol").FontColor = fontColor;
						recordItem.Fields("sell_deal").FontColor = fontColor;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateBuySellVolume_TFEX", ex);
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00085E64 File Offset: 0x00084264
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayUpdateTopPrice_TFEX(string side, decimal price1, decimal price2, decimal price3, decimal price4, decimal price5, long volume1, long volume2, long volume3, long volume4, long volume5)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string columnName = string.Empty;
				if (side == "B")
				{
					columnName = "bid";
				}
				else if (side == "A")
				{
					columnName = "offer";
				}
				decimal num = (side == "B") ? this._tfexBidPrice1 : this._tfexAskPrice1;
				if (volume1 != -1L && price1 != num)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = string.Empty;
					}
				}
				num = ((side == "B") ? this._tfexBidPrice2 : this._tfexAskPrice2);
				if (volume2 != -1L && price2 != num)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = string.Empty;
					}
				}
				num = ((side == "B") ? this._tfexBidPrice3 : this._tfexAskPrice3);
				if (volume3 != -1L && price3 != num)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = string.Empty;
					}
				}
				num = ((side == "B") ? this._tfexBidPrice4 : this._tfexAskPrice4);
				if (volume4 != -1L && price4 != num)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = string.Empty;
					}
				}
				num = ((side == "B") ? this._tfexBidPrice5 : this._tfexAskPrice5);
				if (volume5 != -1L && price5 != num)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = string.Empty;
					}
				}
				if (volume1 != -1L)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price1, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = volume1;
						recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
					}
					if (side == "B")
					{
						this._tfexBidPrice1 = price1;
					}
					else
					{
						this._tfexAskPrice1 = price1;
					}
				}
				if (volume2 != -1L)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price2, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = volume2;
						recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
					}
					if (side == "B")
					{
						this._tfexBidPrice2 = price2;
					}
					else
					{
						this._tfexAskPrice2 = price2;
					}
				}
				if (volume3 != -1L)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price3, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = volume3;
						recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
					}
					if (side == "B")
					{
						this._tfexBidPrice3 = price3;
					}
					else
					{
						this._tfexAskPrice3 = price3;
					}
				}
				if (volume4 != -1L)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price4, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = volume4;
						recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
					}
					if (side == "B")
					{
						this._tfexBidPrice4 = price4;
					}
					else
					{
						this._tfexAskPrice4 = price4;
					}
				}
				if (volume5 != -1L)
				{
					RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price5, this._seriesInfoTFEX.NumOfDec));
					if (recordItem != null)
					{
						recordItem.Fields(columnName).Text = volume5;
						recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
					}
					if (side == "B")
					{
						this._tfexBidPrice5 = price5;
					}
					else
					{
						this._tfexAskPrice5 = price5;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("StockInPlayUpdateTopPrice", ex);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000864F4 File Offset: 0x000848F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayUpdateTotalVolumeAndTotalDeals(long buyVolume, long sellVolume, long openVolume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = buyVolume + sellVolume + openVolume;
				decimal num2 = 0m;
				decimal num3 = 0m;
				if (num > 0L)
				{
					num2 = buyVolume / num * 100m;
					num3 = sellVolume / num * 100m;
				}
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Fields("buy_deal").Text = this._buyDeals;
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Fields("sell_deal").Text = this._sellDeals;
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Fields("buy_volume").Text = Utilities.PriceFormat(num2, "%");
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Fields("sell_vol").Text = Utilities.PriceFormat(num3, "%");
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Fields("buy_deal").FontColor = MyColor.UnChgColor;
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Fields("sell_deal").FontColor = MyColor.UnChgColor;
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Fields("buy_volume").FontColor = MyColor.UnChgColor;
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Fields("sell_vol").FontColor = MyColor.UnChgColor;
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).BackColor = Color.FromArgb(45, 45, 45);
				this.intzaStockInPlay.Records(this.maxTopStockInPlay).Changed = true;
			}
			catch (Exception ex)
			{
				this.ShowError("StockInPlayUpdateTotalVolumeAndTotalDeals", ex);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00086738 File Offset: 0x00084B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayUpdateBuySellVolume(string side, decimal price, long volume, int deals)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price));
				if (recordItem != null)
				{
					int num = 0;
					decimal value = 0m;
					Color fontColor = recordItem.Fields("price").FontColor;
					if (side == "B")
					{
						int.TryParse(recordItem.Fields("buy_deal").Text.ToString().Replace(",", ""), out num);
						recordItem.Fields("buy_deal").Text = num + deals;
						decimal.TryParse(recordItem.Fields("buy_volume").Text.ToString().Replace(",", ""), out value);
						recordItem.Fields("buy_volume").Text = Utilities.VolumeFormat((long)value + volume, true);
						recordItem.Fields("buy_deal").FontColor = fontColor;
						recordItem.Fields("buy_volume").FontColor = fontColor;
						if (!base.IsLoadingData)
						{
							recordItem.Fields("offer").IsBlink = 3;
						}
					}
					else if (side == "S")
					{
						int.TryParse(recordItem.Fields("sell_deal").Text.ToString().Replace(",", ""), out num);
						recordItem.Fields("sell_deal").Text = num + deals;
						decimal.TryParse(recordItem.Fields("sell_vol").Text.ToString().Replace(",", ""), out value);
						recordItem.Fields("sell_vol").Text = Utilities.VolumeFormat((long)value + volume, true);
						recordItem.Fields("sell_vol").FontColor = fontColor;
						recordItem.Fields("sell_deal").FontColor = fontColor;
						if (!base.IsLoadingData)
						{
							recordItem.Fields("bid").IsBlink = 3;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("StockInPlayUpdateBuySellVolume", ex);
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000869C4 File Offset: 0x00084DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StockInPlayUpdateTopPrice(string side, decimal price1, decimal price2, decimal price3, decimal price4, decimal price5, long volume1, long volume2, long volume3, long volume4, long volume5)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string columnName = string.Empty;
				if (side == "B")
				{
					columnName = "bid";
				}
				else if (side == "S")
				{
					columnName = "offer";
				}
				if (price1 > -1m)
				{
					decimal num = (side == "B") ? this._tfexBidPrice1 : this._tfexAskPrice1;
					if (price1 != num)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = string.Empty;
						}
					}
				}
				if (price2 > -1m)
				{
					decimal num = (side == "B") ? this._tfexBidPrice2 : this._tfexAskPrice2;
					if (price2 != num)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = string.Empty;
						}
					}
				}
				if (price3 > -1m)
				{
					decimal num = (side == "B") ? this._tfexBidPrice3 : this._tfexAskPrice3;
					if (price3 != num)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = string.Empty;
						}
					}
				}
				if (price4 > -1m)
				{
					decimal num = (side == "B") ? this._tfexBidPrice4 : this._tfexAskPrice4;
					if (price4 != num)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = string.Empty;
						}
					}
				}
				if (price5 > -1m)
				{
					decimal num = (side == "B") ? this._tfexBidPrice5 : this._tfexAskPrice5;
					if (price5 != num)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(num));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = string.Empty;
						}
					}
				}
				if (volume1 != -1L)
				{
					if (price1 > 0m)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price1));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = volume1;
							recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
						}
					}
					if (side == "B")
					{
						this._tfexBidPrice1 = price1;
					}
					else
					{
						this._tfexAskPrice1 = price1;
					}
				}
				if (volume2 != -1L)
				{
					if (price2 > 0m)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price2));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = volume2;
							recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
						}
					}
					if (side == "B")
					{
						this._tfexBidPrice2 = price2;
					}
					else
					{
						this._tfexAskPrice2 = price2;
					}
				}
				if (volume3 != -1L)
				{
					if (price3 > 0m)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price3));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = volume3;
							recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
						}
					}
					if (side == "B")
					{
						this._tfexBidPrice3 = price3;
					}
					else
					{
						this._tfexAskPrice3 = price3;
					}
				}
				if (volume4 != -1L)
				{
					if (price4 > 0m)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price4));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = volume4;
							recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
						}
					}
					if (side == "B")
					{
						this._tfexBidPrice4 = price4;
					}
					else
					{
						this._tfexAskPrice4 = price4;
					}
				}
				if (volume5 != -1L)
				{
					if (price5 > 0m)
					{
						RecordItem recordItem = this.intzaStockInPlay.Find("price", Utilities.PriceFormat(price5));
						if (recordItem != null)
						{
							recordItem.Fields(columnName).Text = volume5;
							recordItem.Fields(columnName).FontColor = recordItem.Fields("price").FontColor;
						}
					}
					if (side == "B")
					{
						this._tfexBidPrice5 = price5;
					}
					else
					{
						this._tfexAskPrice5 = price5;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("StockInPlayUpdateTopPrice", ex);
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000870A4 File Offset: 0x000854A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewOddLotMktTotal(decimal value, long volume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaViewOddLotInfo.Item("totvalue").Text = value.ToString();
				this.intzaViewOddLotInfo.Item("totvolume").Text = volume.ToString();
			}
			catch (Exception ex)
			{
				this.ShowError("MainUpdateOddLotValue", ex);
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00087128 File Offset: 0x00085528
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaleByPrice_SetNewStock(string symbol, bool isForce)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (symbol != string.Empty && (isForce || symbol != this._currentSymbol))
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[symbol];
					if (stockInformation.Number > 0)
					{
						this._stockInfoSET = stockInformation;
						this._seriesInfoTFEX = null;
						this.intzaInfo.Visible = true;
						this.intzaInfoTFEX.Visible = false;
						ApplicationInfo.CurrentSymbol = this._stockInfoSET.Symbol;
						this._currentSymbol = this._stockInfoSET.Symbol;
						this.SaleByPriceReloadData();
					}
					else
					{
						SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[symbol];
						if (seriesInformation.Symbol != string.Empty)
						{
							this._isNewStock = true;
							this._currentSymbol = seriesInformation.Symbol;
							this._seriesInfoTFEX = seriesInformation;
							this._stockInfoSET = null;
							this.intzaInfo.Visible = false;
							this.intzaInfoTFEX.Visible = true;
							ApplicationInfo.CurrentSymbol = this._seriesInfoTFEX.Symbol;
							this.SaleByPriceReloadData();
						}
					}
				}
				if (this.tscbStock.Text != ApplicationInfo.CurrentSymbol)
				{
					this.tscbStock.Text = ApplicationInfo.CurrentSymbol;
				}
				this.tscbStock.Focus();
				this.tscbStock.SelectAll();
			}
			catch (Exception ex)
			{
				this.ShowError("SaleByPriceSetNewStock", ex);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000872F8 File Offset: 0x000856F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaleByPriceReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwSaleByPriceLoadData.IsBusy)
			{
				this.bgwSaleByPriceLoadData.RunWorkerAsync();
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00087334 File Offset: 0x00085734
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaleByPriceUpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaSaleByPrice.BeginUpdate();
				this.intzaLS.BeginUpdate();
				this.intzaLS.ClearAllText();
				if (this.dsSaleByPrice.Tables.Count > 0)
				{
					if (this.dsSaleByPrice.Tables.Contains("sale_by_price"))
					{
						this.intzaSaleByPrice.Rows = 0;
						this.wcGraphVolume.InitData(this._stockInfoSET.Symbol, (double)this._stockInfoSET.PriorPrice, (double)this._stockInfoSET.LastSalePrice, (double)this._stockInfoSET.Ceiling, (double)this._stockInfoSET.Floor);
						foreach (DataRow dataRow in this.dsSaleByPrice.Tables["sale_by_price"].Rows)
						{
							decimal num;
							decimal.TryParse(dataRow["price"].ToString(), out num);
							int sideDeals;
							int.TryParse(dataRow["buy_deals"].ToString(), out sideDeals);
							long num2;
							long.TryParse(dataRow["buy_volume"].ToString(), out num2);
							this.SaleByPriceUpdateBuySell(num, "B", sideDeals, num2, true);
							int.TryParse(dataRow["sell_deals"].ToString(), out sideDeals);
							long num3;
							long.TryParse(dataRow["sell_volume"].ToString(), out num3);
							this.SaleByPriceUpdateBuySell(num, "S", sideDeals, num3, true);
							long num4;
							long.TryParse(dataRow["other_volume"].ToString(), out num4);
							this.SaleByPriceUpdateBuySell(num, "", 0, num4, true);
							this.wcGraphVolume.InputData((double)num, num2 + num3 + num4, num2, num3);
						}
						this.wcGraphVolume.EndUpdate();
						this.wcGraphVolume.Sort();
					}
					this.UpdateToControl(this.dsSaleByPrice);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SaleByPriceUpdateToControl", ex);
			}
			finally
			{
				this.intzaSaleByPrice.Redraw();
				this.intzaLS.Redraw();
				this.intzaInfo.Redraw();
				this.intzaVolumeByBoard.Redraw();
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00087638 File Offset: 0x00085A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SaleByPriceUpdateBuySell(decimal price, string side, int sideDeals, long sideVolume, bool isNoBlink)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			if (this.intzaSaleByPrice.InvokeRequired)
			{
				result = (bool)this.intzaSaleByPrice.Invoke(new frmStockSummary.SaleByPriceUpdateBuySellCallBack(this.SaleByPriceUpdateBuySell), new object[]
				{
					price,
					side,
					sideDeals,
					sideVolume,
					isNoBlink
				});
			}
			else
			{
				bool flag = false;
				try
				{
					long num = 0L;
					long num2 = 0L;
					long num3 = 0L;
					long num4 = 0L;
					long num5 = 0L;
					Color fontColor = MyColor.UnChgColor;
					string text = Utilities.PriceFormat(price);
					if (this._seriesInfoTFEX != null)
					{
						text = Utilities.PriceFormat(price, this._seriesInfoTFEX.NumOfDec);
					}
					RecordItem recordItem = this.intzaSaleByPrice.Find("price", text);
					if (recordItem == null)
					{
						flag = true;
						recordItem = this.intzaSaleByPrice.AddRecord(1, false);
						recordItem.Fields("price").Text = text;
						recordItem.Fields("price").BackColor = Color.FromArgb(30, 30, 30);
						if (this._stockInfoSET != null)
						{
							fontColor = Utilities.ComparePriceCFColor(price, this._stockInfoSET);
						}
						else
						{
							fontColor = Utilities.ComparePriceCFColor(price, this._seriesInfoTFEX);
						}
						recordItem.Fields("buy_vol").FontColor = fontColor;
						recordItem.Fields("buy_deal").FontColor = fontColor;
						recordItem.Fields("sell_vol").FontColor = fontColor;
						recordItem.Fields("sell_deal").FontColor = fontColor;
						recordItem.Fields("price").FontColor = fontColor;
						recordItem.Fields("mvol").FontColor = fontColor;
						recordItem.Fields("mval").FontColor = fontColor;
					}
					string s = string.Empty;
					s = recordItem.Fields("mvol").Text.ToString().Replace(",", "");
					long.TryParse(s, out num5);
					s = recordItem.Fields("buy_deal").Text.ToString().Replace(",", "");
					long.TryParse(s, out num2);
					s = recordItem.Fields("buy_vol").Text.ToString().Replace(",", "");
					long.TryParse(s, out num);
					s = recordItem.Fields("sell_deal").Text.ToString().Replace(",", "");
					long.TryParse(s, out num4);
					s = recordItem.Fields("sell_vol").Text.ToString().Replace(",", "");
					long.TryParse(s, out num3);
					if (side == "B")
					{
						recordItem.Fields("buy_vol").Text = num + sideVolume;
						recordItem.Fields("buy_deal").Text = num2 + (long)sideDeals;
					}
					else if (side == "S")
					{
						recordItem.Fields("sell_vol").Text = num3 + sideVolume;
						recordItem.Fields("sell_deal").Text = num4 + (long)sideDeals;
					}
					if (isNoBlink)
					{
						recordItem.Fields("mvol").Text = "";
						recordItem.Fields("mval").Text = "";
					}
					recordItem.Fields("mvol").Text = num5 + sideVolume;
					recordItem.Fields("mval").Text = (num5 + sideVolume) * price;
					recordItem.Changed = true;
				}
				catch (Exception ex)
				{
					this.ShowError("SaleByPriceUpdateBuySell", ex);
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00087AB4 File Offset: 0x00085EB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaleByTime_SetNewStock(string stockSymbol, bool isForce)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (stockSymbol != string.Empty)
				{
					if (stockSymbol != string.Empty && (this._stockInfoSET == null || isForce || (this._stockInfoSET != null && stockSymbol != this._stockInfoSET.Symbol)))
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stockSymbol];
						if (stockInformation.Number > 0)
						{
							this._seriesInfoTFEX = null;
							this._stockInfoSET = stockInformation;
							this.intzaInfo.Visible = true;
							this.intzaInfoTFEX.Visible = false;
							ApplicationInfo.CurrentSymbol = this._stockInfoSET.Symbol;
							this._saleByTimePageNo = 1;
							this.SaleByTimeReloadData();
						}
						else
						{
							SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[stockSymbol];
							if (seriesInformation != null && seriesInformation.Symbol != string.Empty)
							{
								this._stockInfoSET = null;
								this._seriesInfoTFEX = seriesInformation;
								this.intzaInfoTFEX.Visible = true;
								this.intzaInfo.Visible = false;
								ApplicationInfo.CurrentSymbol = this._seriesInfoTFEX.Symbol;
								this._saleByTimePageNo = 1;
								this.SaleByTimeReloadData();
							}
						}
					}
				}
				if (this.tscbStock.Text != ApplicationInfo.CurrentSymbol)
				{
					this.tscbStock.Text = ApplicationInfo.CurrentSymbol;
				}
				this.tscbStock.Focus();
				this.tscbStock.SelectAll();
			}
			catch (Exception ex)
			{
				this.ShowError("SaleByTimeSetNewStock", ex);
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00087CB0 File Offset: 0x000860B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaleByTimeReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwSaleByTimeLoadData.IsBusy)
			{
				this.bgwSaleByTimeLoadData.RunWorkerAsync();
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00087CEC File Offset: 0x000860EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaleByTimeUpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tslblSaleByTimePageNo.Text = this._saleByTimePageNo.ToString();
				this.intzaSaleByTime.BeginUpdate();
				this.intzaSaleByTime.ClearAllText();
				if (this._dsSaleByTime != null && this._dsSaleByTime.Tables.Contains("last_sale_time"))
				{
					int num = 0;
					foreach (DataRow dataRow in this._dsSaleByTime.Tables["last_sale_time"].Rows)
					{
						decimal price;
						decimal.TryParse(dataRow["price"].ToString(), out price);
						long volume;
						long.TryParse(dataRow["volume"].ToString(), out volume);
						decimal chg;
						decimal.TryParse(dataRow["change_price"].ToString(), out chg);
						decimal avg;
						decimal.TryParse(dataRow["average_price"].ToString(), out avg);
						if (!this.SaleByTimeUpdateGridData(dataRow["side"].ToString(), price, volume, chg, avg, dataRow["last_update"].ToString(), num))
						{
							break;
						}
						num++;
					}
					if (this._saleByTimePageNo == 1)
					{
						this.UpdateToControl(this._dsSaleByTime);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SaleByTimeUpdateToControl", ex);
			}
			finally
			{
				this.intzaSaleByTime.Redraw();
				this.intzaLS.Redraw();
				this.intzaInfo.Redraw();
				this.intzaVolumeByBoard.Redraw();
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00087F48 File Offset: 0x00086348
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaleByTimeUpdateToControl_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tslblSaleByTimePageNo.Text = this._saleByTimePageNo.ToString();
				this.intzaSaleByTime.BeginUpdate();
				this.intzaSaleByTime.ClearAllText();
				if (this._dsSaleByTime.Tables.Count > 0)
				{
					if (this._dsSaleByTime.Tables.Contains("last_sale_time_tfex"))
					{
						int num = 0;
						foreach (DataRow dataRow in this._dsSaleByTime.Tables["last_sale_time_tfex"].Rows)
						{
							string side;
							if (dataRow["sSide"].ToString().Trim() == "B")
							{
								side = "B";
							}
							else if (dataRow["sSide"].ToString().Trim() == "S")
							{
								side = "S";
							}
							else
							{
								side = "";
							}
							long volume;
							long.TryParse(dataRow["iQuantity"].ToString(), out volume);
							decimal num2;
							decimal.TryParse(dataRow["nmrPrice"].ToString(), out num2);
							decimal avg;
							decimal.TryParse(dataRow["nmrAvgPrice"].ToString(), out avg);
							bool flag = this.SaleByTimeUpdateGridData_TFEX(side, num2, volume, num2 - this._seriesInfoTFEX.PrevFixPrice, avg, Utilities.GetTimeLastSale(dataRow["dtLastUpd"].ToString()), num);
							num++;
							if (!flag)
							{
								break;
							}
						}
					}
					if (this._saleByTimePageNo == 1)
					{
						this.UpdateToControl_TFEX(this._dsSaleByTime);
					}
				}
				this.intzaSaleByTime.Redraw();
				this.intzaLS.Redraw();
				this.intzaInfoTFEX.Redraw();
				this.intzaVolumeByBoard.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("SaleByTimeUpdateToControl", ex);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000881F4 File Offset: 0x000865F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SaleByTimeUpdateGridData(string side, decimal price, long volume, decimal chg, decimal avg, string last_update, int rowId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			try
			{
				RecordItem recordItem;
				if (rowId == -1)
				{
					recordItem = this.intzaSaleByTime.AddRecord(1, true);
				}
				else
				{
					recordItem = this.intzaSaleByTime.Records(rowId);
				}
				Color fontColor = Utilities.ComparePriceCFColor(price, this._stockInfoSET);
				recordItem.Fields("side").Text = side;
				recordItem.Fields("volume").Text = volume;
				recordItem.Fields("price").Text = price;
				recordItem.Fields("chg").Text = chg;
				recordItem.Fields("avg").Text = Utilities.PriceFormat(avg, 4);
				recordItem.Fields("time").Text = last_update;
				Color fontColor2 = MyColor.OpenColor;
				if (side == "B")
				{
					fontColor2 = MyColor.BuyColor;
				}
				else if (side == "S")
				{
					fontColor2 = MyColor.SellColor;
				}
				recordItem.Fields("side").FontColor = fontColor2;
				recordItem.Fields("volume").FontColor = fontColor2;
				recordItem.Fields("price").FontColor = fontColor;
				recordItem.Fields("time").FontColor = Color.LightGray;
				recordItem.Fields("chg").FontColor = fontColor;
				recordItem.Fields("avg").FontColor = Utilities.ComparePriceCFColor(avg, this._stockInfoSET);
				recordItem.Changed = true;
			}
			catch (Exception ex)
			{
				this.ShowError("SaleByTimeUpdateGridData", ex);
				result = false;
				return result;
			}
			result = true;
			return result;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000883EC File Offset: 0x000867EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SaleByTimeUpdateGridData_TFEX(string side, decimal price, long volume, decimal chg, decimal avg, string last_update, int rowId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			try
			{
				RecordItem recordItem;
				if (rowId == -1)
				{
					recordItem = this.intzaSaleByTime.AddRecord(1, true);
				}
				else
				{
					recordItem = this.intzaSaleByTime.Records(rowId);
				}
				recordItem.Fields("side").Text = side;
				recordItem.Fields("volume").Text = volume;
				recordItem.Fields("price").Text = Utilities.PriceFormat(price, this._seriesInfoTFEX.NumOfDec);
				recordItem.Fields("chg").Text = Utilities.PriceFormat(chg, this._seriesInfoTFEX.NumOfDec);
				recordItem.Fields("avg").Text = Utilities.PriceFormat(avg, this._seriesInfoTFEX.NumOfDec);
				recordItem.Fields("time").Text = Utilities.GetTime(last_update);
				if (side == "B")
				{
					recordItem.Fields("side").FontColor = MyColor.BuyColor;
					recordItem.Fields("volume").FontColor = MyColor.BuyColor;
				}
				else if (side == "S")
				{
					recordItem.Fields("side").FontColor = MyColor.SellColor;
					recordItem.Fields("volume").FontColor = MyColor.SellColor;
				}
				Color fontColor = Utilities.ComparePriceCFColor(price, this._seriesInfoTFEX);
				recordItem.Fields("price").FontColor = fontColor;
				recordItem.Fields("time").FontColor = Color.LightGray;
				recordItem.Fields("chg").FontColor = fontColor;
				recordItem.Fields("avg").FontColor = Utilities.ComparePriceCFColor(avg, this._seriesInfoTFEX);
				recordItem.Changed = true;
			}
			catch (Exception ex)
			{
				this.ShowError("SaleByTimeUpdateGridData_TFEX", ex);
				result = false;
				return result;
			}
			result = true;
			return result;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00088634 File Offset: 0x00086A34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewOddLotSetNewStock(string stockSymbol, bool isForce)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (stockSymbol != string.Empty && (this._stockInfoSET == null || isForce || (this._stockInfoSET != null && stockSymbol != this._stockInfoSET.Symbol)))
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stockSymbol + "_ODD"];
					if (stockInformation.Number > 0)
					{
						this._seriesInfoTFEX = null;
						this._stockInfoSET = stockInformation;
						this.intzaInfo.Visible = false;
						this.intzaInfoTFEX.Visible = false;
						ApplicationInfo.CurrentSymbol = stockSymbol;
						this.ViewOddLotReloadData();
					}
					else
					{
						this._stockInfoSET = null;
						this._seriesInfoTFEX = null;
						this.intzaLS.ClearAllText();
						this.intzaViewOddLot.ClearAllText();
						this.intzaViewOddLotInfo.ClearAllText();
						this.intzaLS.Redraw();
						this.intzaViewOddLot.Redraw();
						this.intzaViewOddLotInfo.Redraw();
					}
				}
				if (this.tscbStock.Text != ApplicationInfo.CurrentSymbol)
				{
					this.tscbStock.Text = ApplicationInfo.CurrentSymbol;
				}
				this.tscbStock.Focus();
				this.tscbStock.SelectAll();
			}
			catch (Exception ex)
			{
				this.ShowError("ViewOddLotSetNewStock", ex);
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000887EC File Offset: 0x00086BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewOddLotReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._stockInfoSET != null && this._stockInfoSET.Number > 0)
			{
				if (!this.bgwViewOddLotLoadData.IsBusy)
				{
					this.bgwViewOddLotLoadData.RunWorkerAsync(this._stockInfoSET.Number);
				}
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00088864 File Offset: 0x00086C64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewOddLotUpdateToControl(DataSet dsViewOddLot)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaViewOddLot.BeginUpdate();
				this.intzaViewOddLot.ClearAllText();
				this.intzaViewOddLotInfo.BeginUpdate();
				this.intzaViewOddLotInfo.ClearAllText();
				this.intzaLS.ClearAllText();
				this.intzaInfo.ClearAllText();
				this.intzaViewOddLotInfo.Item("ceiling").Text = this._stockInfoSET.Ceiling.ToString();
				this.intzaViewOddLotInfo.Item("floor").Text = this._stockInfoSET.Floor.ToString();
				this.intzaViewOddLotInfo.Item("prior").Text = this._stockInfoSET.PriorPrice.ToString();
				if (dsViewOddLot.Tables.Count > 0)
				{
					if (dsViewOddLot.Tables.Contains("oddlot_info_stat") && dsViewOddLot.Tables["oddlot_info_stat"].Rows.Count > 0)
					{
						DataRow dataRow = dsViewOddLot.Tables["oddlot_info_stat"].Rows[0];
						int deal;
						int.TryParse(dataRow["deal_in_oddlot"].ToString(), out deal);
						long volume;
						long.TryParse(dataRow["oddlot_accvolume"].ToString(), out volume);
						decimal value;
						decimal.TryParse(dataRow["oddlot_accvalue"].ToString(), out value);
						decimal lastPrice;
						decimal.TryParse(dataRow["last_sale_price"].ToString(), out lastPrice);
						this.ViewOddLotShowStockVolume(lastPrice, deal, volume, value);
						this.ViewOddLot_TopPrice("B", Convert.ToDecimal(dataRow["bid_price1"].ToString()), Convert.ToDecimal(dataRow["bid_price2"].ToString()), Convert.ToDecimal(dataRow["bid_price3"].ToString()), Convert.ToDecimal(dataRow["bid_price4"].ToString()), Convert.ToDecimal(dataRow["bid_price5"].ToString()), Convert.ToInt64(dataRow["bid_volume1"].ToString()), Convert.ToInt64(dataRow["bid_volume2"].ToString()), Convert.ToInt64(dataRow["bid_volume3"].ToString()), Convert.ToInt64(dataRow["bid_volume4"].ToString()), Convert.ToInt64(dataRow["bid_volume5"].ToString()));
						this.ViewOddLot_TopPrice("S", Convert.ToDecimal(dataRow["offer_price1"].ToString()), Convert.ToDecimal(dataRow["offer_price2"].ToString()), Convert.ToDecimal(dataRow["offer_price3"].ToString()), Convert.ToDecimal(dataRow["offer_price4"].ToString()), Convert.ToDecimal(dataRow["offer_price5"].ToString()), Convert.ToInt64(dataRow["offer_volume1"].ToString()), Convert.ToInt64(dataRow["offer_volume2"].ToString()), Convert.ToInt64(dataRow["offer_volume3"].ToString()), Convert.ToInt64(dataRow["offer_volume4"].ToString()), Convert.ToInt64(dataRow["offer_volume5"].ToString()));
					}
					if (dsViewOddLot.Tables.Contains("last_sale"))
					{
						this.intzaLS.Rows = dsViewOddLot.Tables["last_sale"].Rows.Count;
						int num = 0;
						foreach (DataRow dataRow in dsViewOddLot.Tables["last_sale"].Rows)
						{
							decimal price;
							decimal.TryParse(dataRow["price"].ToString(), out price);
							long volume2;
							long.TryParse(dataRow["volume"].ToString(), out volume2);
							this.UpdateStockTicker(price, dataRow["side"].ToString(), volume2, dataRow["last_update"].ToString(), num);
							num++;
						}
					}
					if (dsViewOddLot.Tables.Contains("market_info") && dsViewOddLot.Tables["market_info"].Rows.Count > 0)
					{
						this.ViewOddLotMktTotal(Convert.ToDecimal(dsViewOddLot.Tables["market_info"].Rows[0]["oddlot_accvalue"].ToString()), Convert.ToInt64(dsViewOddLot.Tables["market_info"].Rows[0]["oddlot_accvolume"].ToString()));
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ViewOddLotUpdateToControl", ex);
			}
			finally
			{
				this.intzaViewOddLotInfo.Redraw();
				this.intzaViewOddLot.Redraw();
				this.intzaLS.Redraw();
				this.intzaInfo.Redraw();
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00088E50 File Offset: 0x00087250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewOddLotShowStockVolume(decimal lastPrice, int deal, long volume, decimal value)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal num = 0m;
				if (volume > 0L)
				{
					num = Math.Round(value / volume, 2);
				}
				this.intzaViewOddLotInfo.Item("oddlast").Text = FormatUtil.PriceFormat(lastPrice, 2, "0");
				this.intzaViewOddLotInfo.Item("oddlast").FontColor = Utilities.ComparePriceCFColor(lastPrice, this._stockInfoSET);
				this.intzaViewOddLotInfo.Item("oddavg").Text = FormatUtil.PriceFormat(num, 2, "0");
				this.intzaViewOddLotInfo.Item("odddeal").Text = FormatUtil.PriceFormat(deal, 0, "0");
				this.intzaViewOddLotInfo.Item("oddvol").Text = FormatUtil.PriceFormat(volume, 0, "0");
				this.intzaViewOddLotInfo.Item("oddval").Text = FormatUtil.PriceFormat(value, 2, "0");
				this.intzaViewOddLotInfo.Item("oddavg").FontColor = ((num > 0m) ? Utilities.ComparePriceColor(num, this._stockInfoSET.PriorPrice) : MyColor.UnChgColor);
			}
			catch (Exception ex)
			{
				this.ShowError("ViewOddLotShowStockVolume", ex);
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00088FF8 File Offset: 0x000873F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewOddLot_TopPrice(string side, decimal price1, decimal price2, decimal price3, decimal price4, decimal price5, long volume1, long volume2, long volume3, long volume4, long volume5)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (side == "B")
			{
				this.intzaViewOddLot.Records(0).Fields("bid").Text = price1;
				this.intzaViewOddLot.Records(0).Fields("bid_vol").Text = volume1;
				this.intzaViewOddLot.Records(1).Fields("bid").Text = price2;
				this.intzaViewOddLot.Records(1).Fields("bid_vol").Text = volume2;
				this.intzaViewOddLot.Records(2).Fields("bid").Text = price3;
				this.intzaViewOddLot.Records(2).Fields("bid_vol").Text = volume3;
				this.intzaViewOddLot.Records(3).Fields("bid").Text = price4;
				this.intzaViewOddLot.Records(3).Fields("bid_vol").Text = volume4;
				this.intzaViewOddLot.Records(4).Fields("bid").Text = price5;
				this.intzaViewOddLot.Records(4).Fields("bid_vol").Text = volume5;
				Color fontColor = Utilities.ComparePriceCFColor(price1, this._stockInfoSET);
				this.intzaViewOddLot.Records(0).Fields("bid").FontColor = fontColor;
				this.intzaViewOddLot.Records(0).Fields("bid_vol").FontColor = fontColor;
				fontColor = Utilities.ComparePriceCFColor(price2, this._stockInfoSET);
				this.intzaViewOddLot.Records(1).Fields("bid").FontColor = fontColor;
				this.intzaViewOddLot.Records(1).Fields("bid_vol").FontColor = fontColor;
				fontColor = Utilities.ComparePriceCFColor(price3, this._stockInfoSET);
				this.intzaViewOddLot.Records(2).Fields("bid").FontColor = fontColor;
				this.intzaViewOddLot.Records(2).Fields("bid_vol").FontColor = fontColor;
				fontColor = Utilities.ComparePriceCFColor(price4, this._stockInfoSET);
				this.intzaViewOddLot.Records(3).Fields("bid").FontColor = fontColor;
				this.intzaViewOddLot.Records(3).Fields("bid_vol").FontColor = fontColor;
				fontColor = Utilities.ComparePriceCFColor(price5, this._stockInfoSET);
				this.intzaViewOddLot.Records(4).Fields("bid").FontColor = fontColor;
				this.intzaViewOddLot.Records(4).Fields("bid_vol").FontColor = fontColor;
			}
			else if (side == "S")
			{
				this.intzaViewOddLot.Records(0).Fields("offer").Text = price1;
				this.intzaViewOddLot.Records(0).Fields("offer_vol").Text = volume1;
				this.intzaViewOddLot.Records(1).Fields("offer").Text = price2;
				this.intzaViewOddLot.Records(1).Fields("offer_vol").Text = volume2;
				this.intzaViewOddLot.Records(2).Fields("offer").Text = price3;
				this.intzaViewOddLot.Records(2).Fields("offer_vol").Text = volume3;
				this.intzaViewOddLot.Records(3).Fields("offer").Text = price4;
				this.intzaViewOddLot.Records(3).Fields("offer_vol").Text = volume4;
				this.intzaViewOddLot.Records(4).Fields("offer").Text = price5;
				this.intzaViewOddLot.Records(4).Fields("offer_vol").Text = volume5;
				Color fontColor = Utilities.ComparePriceCFColor(price1, this._stockInfoSET);
				this.intzaViewOddLot.Records(0).Fields("offer").FontColor = fontColor;
				this.intzaViewOddLot.Records(0).Fields("offer_vol").FontColor = fontColor;
				fontColor = Utilities.ComparePriceCFColor(price2, this._stockInfoSET);
				this.intzaViewOddLot.Records(1).Fields("offer").FontColor = fontColor;
				this.intzaViewOddLot.Records(1).Fields("offer_vol").FontColor = fontColor;
				fontColor = Utilities.ComparePriceCFColor(price3, this._stockInfoSET);
				this.intzaViewOddLot.Records(2).Fields("offer").FontColor = fontColor;
				this.intzaViewOddLot.Records(2).Fields("offer_vol").FontColor = fontColor;
				fontColor = Utilities.ComparePriceCFColor(price4, this._stockInfoSET);
				this.intzaViewOddLot.Records(3).Fields("offer").FontColor = fontColor;
				this.intzaViewOddLot.Records(3).Fields("offer_vol").FontColor = fontColor;
				fontColor = Utilities.ComparePriceCFColor(price5, this._stockInfoSET);
				this.intzaViewOddLot.Records(4).Fields("offer").FontColor = fontColor;
				this.intzaViewOddLot.Records(4).Fields("offer_vol").FontColor = fontColor;
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000895CC File Offset: 0x000879CC
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
					if (message.MessageType == "IS")
					{
						if (this._currentPage == "View Oddlot")
						{
							if (this._stockInfoSET != null)
							{
								ISMessage iSMessage = (ISMessage)message;
								if (iSMessage.Symbol == ".SET")
								{
									this.ViewOddLotMktTotal(iSMessage.OddlotAccValue, iSMessage.OddlotAccVolume);
									if (base.IsAllowRender)
									{
										this.intzaViewOddLotInfo.EndUpdate();
									}
								}
							}
						}
					}
					if (realtimeStockInfo != null)
					{
						if (this._stockInfoSET != null && realtimeStockInfo.Number == this._stockInfoSET.Number)
						{
							if (message.MessageType == "TP")
							{
								if (this._currentPage == "Stock in Play")
								{
									TPMessage tPMessage = (TPMessage)message;
									this.StockInPlayUpdateTopPrice(tPMessage.Side, tPMessage.Price1, tPMessage.Price2, tPMessage.Price3, tPMessage.Price4, tPMessage.Price5, tPMessage.Volume1 * (long)realtimeStockInfo.BoardLot, tPMessage.Volume2 * (long)realtimeStockInfo.BoardLot, tPMessage.Volume3 * (long)realtimeStockInfo.BoardLot, tPMessage.Volume4 * (long)realtimeStockInfo.BoardLot, tPMessage.Volume5 * (long)realtimeStockInfo.BoardLot);
									if (base.IsAllowRender)
									{
										this.intzaStockInPlay.EndUpdate();
									}
								}
								else if (this._currentPage == "View Oddlot")
								{
									TPMessage tPMessage = (TPMessage)message;
									this.ViewOddLot_TopPrice(tPMessage.Side, tPMessage.Price1, tPMessage.Price2, tPMessage.Price3, tPMessage.Price4, tPMessage.Price5, tPMessage.Volume1, tPMessage.Volume2, tPMessage.Volume3, tPMessage.Volume4, tPMessage.Volume5);
									if (base.IsAllowRender)
									{
										this.intzaViewOddLot.Redraw();
									}
								}
							}
							else if (message.MessageType == "L+")
							{
								LSAccumulate lSAccumulate = (LSAccumulate)message;
								if (this._currentPage == "Stock in Play")
								{
									this.StockInPlayUpdateBuySellVolume(lSAccumulate.Side, lSAccumulate.LastPrice, lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot, lSAccumulate.Deals);
									if (lSAccumulate.Side == "B")
									{
										this._buyDeals += lSAccumulate.Deals;
									}
									else if (lSAccumulate.Side == "S")
									{
										this._sellDeals += lSAccumulate.Deals;
									}
									this.StockInPlayUpdateTotalVolumeAndTotalDeals(lSAccumulate.BuyVolume, lSAccumulate.SellVolume, lSAccumulate.OpenVolume);
									if (base.IsAllowRender)
									{
										this.intzaStockInPlay.EndUpdate();
									}
								}
								else if (this._currentPage == "Sale by Price")
								{
									if (this.SaleByPriceUpdateBuySell(lSAccumulate.LastPrice, lSAccumulate.Side, lSAccumulate.Deals, lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot, false))
									{
										this.intzaSaleByPrice.Sort("price", SortType.Desc);
									}
									if (base.IsAllowRender)
									{
										this.intzaSaleByPrice.EndUpdate();
									}
									if (lSAccumulate.Side == "B")
									{
										this.wcGraphVolume.UpdateData((double)lSAccumulate.LastPrice, lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot, lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot, 0L);
									}
									else if (lSAccumulate.Side == "S")
									{
										this.wcGraphVolume.UpdateData((double)lSAccumulate.LastPrice, lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot, 0L, lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot);
									}
									else
									{
										this.wcGraphVolume.UpdateData((double)lSAccumulate.LastPrice, lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot, 0L, 0L);
									}
									if (base.IsAllowRender)
									{
										this.wcGraphVolume.EndUpdate();
									}
								}
								else if (this._currentPage == "Sale by Time")
								{
									decimal avg = 0m;
									if (lSAccumulate.AccVolume > 0L)
									{
										avg = lSAccumulate.AccValue / (lSAccumulate.AccVolume * (long)realtimeStockInfo.BoardLot);
									}
									this.SaleByTimeUpdateGridData(lSAccumulate.Side, lSAccumulate.LastPrice, lSAccumulate.Volume * (long)realtimeStockInfo.BoardLot, realtimeStockInfo.ChangePrice, avg, lSAccumulate.LastTime, -1);
									if (base.IsAllowRender)
									{
										this.intzaSaleByTime.EndUpdate();
									}
								}
								if (realtimeStockInfo.Number == this._stockInfoSET.Number)
								{
									this.UpdatePriceInfo(lSAccumulate.LastPrice, realtimeStockInfo.HighPrice, realtimeStockInfo.LowPrice);
									this.UpdateAllVolume(lSAccumulate.DealInMain, lSAccumulate.AccVolume * (long)this._stockInfoSET.BoardLot, lSAccumulate.AccValue, lSAccumulate.OpenVolume * (long)this._stockInfoSET.BoardLot, lSAccumulate.BuyVolume * (long)this._stockInfoSET.BoardLot, lSAccumulate.SellVolume * (long)this._stockInfoSET.BoardLot);
									if (lSAccumulate.Side == string.Empty)
									{
										this.UpdateOpenOrProjectOpenPrice(ApplicationInfo.MarketState, ApplicationInfo.MarketSession, lSAccumulate.LastPrice);
									}
									this.UpdateMainBoardValue(lSAccumulate.DealInMain, lSAccumulate.AccVolume * (long)this._stockInfoSET.BoardLot, lSAccumulate.AccValue);
									if (base.IsAllowRender)
									{
										this.intzaInfo.EndUpdate();
										this.intzaVolumeByBoard.EndUpdate();
									}
									this.UpdateStockTicker(lSAccumulate.LastPrice, lSAccumulate.Side, Convert.ToInt64(lSAccumulate.Volume * (long)this._stockInfoSET.BoardLot), lSAccumulate.LastTime, -1);
									if (base.IsAllowRender)
									{
										this.intzaLS.Redraw();
									}
								}
								if (base.IsAllowRender)
								{
									this.intzaInfo.Redraw();
									this.intzaLS.Redraw();
									this.intzaVolumeByBoard.Redraw();
								}
							}
							else if (message.MessageType == "PD")
							{
								if (realtimeStockInfo.Number == this._stockInfoSET.Number)
								{
									PDMessage pDMessage = (PDMessage)message;
									this.UpdateBigLotValue(pDMessage.BiglotDeals, pDMessage.BiglotAccValue, pDMessage.BiglotAccVolume);
									if (base.IsAllowRender)
									{
										this.intzaVolumeByBoard.EndUpdate();
									}
								}
							}
							else if (message.MessageType == "LO")
							{
								LOMessage lOMessage = (LOMessage)message;
								if (this._currentPage == "View Oddlot")
								{
									this.ViewOddLotShowStockVolume(lOMessage.Price, lOMessage.OddlotDeals, lOMessage.OddlotAccVolume, lOMessage.OddlotAccValue);
									if (base.IsAllowRender)
									{
										this.intzaInfo.EndUpdate();
									}
									this.UpdateStockTicker(lOMessage.Price, lOMessage.Side, lOMessage.Volume, lOMessage.LastTime, -1);
									if (base.IsAllowRender)
									{
										this.intzaLS.Redraw();
									}
								}
							}
							else if (message.MessageType == "PO")
							{
								POMessage pOMessage = (POMessage)message;
								if (ApplicationInfo.MarketState == "M")
								{
									this.UpdateProjectedClosePrice(pOMessage.ProjectedPrice);
								}
								else
								{
									this.UpdateOpenOrProjectOpenPrice(ApplicationInfo.MarketState, ApplicationInfo.MarketSession, pOMessage.ProjectedPrice);
								}
								this.UpdateProjectedVolume(pOMessage.ProjectedVolume);
								if (base.IsAllowRender)
								{
									this.intzaInfo.EndUpdate();
								}
								if (base.IsAllowRender)
								{
									this.intzaInfo.EndUpdate();
								}
							}
							else if (message.MessageType == "SS")
							{
								if (realtimeStockInfo.Number == this._stockInfoSET.Number)
								{
									this.UpdateFromSS(realtimeStockInfo);
									if (base.IsAllowRender)
									{
										this.intzaInfo.EndUpdate();
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

		// Token: 0x06000747 RID: 1863 RVA: 0x00089FDC File Offset: 0x000883DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				if (!base.IsLoadingData)
				{
					try
					{
						if (this._seriesInfoTFEX != null && realtimeSeriesInfo != null && realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
						{
							string messageType = message.MessageType;
							switch (messageType)
							{
							case "TP":
								if (this._currentPage == "Stock in Play")
								{
									TPMessageTFEX tPMessageTFEX = (TPMessageTFEX)message;
									this.StockInPlayUpdateTopPrice_TFEX(tPMessageTFEX.Side, tPMessageTFEX.Price1, tPMessageTFEX.Price2, tPMessageTFEX.Price3, tPMessageTFEX.Price4, tPMessageTFEX.Price5, (long)tPMessageTFEX.Vol1, (long)tPMessageTFEX.Vol2, (long)tPMessageTFEX.Vol3, (long)tPMessageTFEX.Vol4, (long)tPMessageTFEX.Vol5);
									if (base.IsAllowRender)
									{
										this.intzaStockInPlay.Redraw();
									}
								}
								break;
							case "LS":
							{
								LSMessageTFEX lSMessageTFEX = (LSMessageTFEX)message;
								if (this._currentPage == "Sale by Time")
								{
									decimal avg = 0m;
									if (lSMessageTFEX.AccVolume > 0)
									{
										avg = lSMessageTFEX.AccValue / lSMessageTFEX.AccVolume;
									}
									this.SaleByTimeUpdateGridData_TFEX(lSMessageTFEX.Side, lSMessageTFEX.Price, (long)lSMessageTFEX.Vol, lSMessageTFEX.Price - realtimeSeriesInfo.PrevFixPrice, avg, lSMessageTFEX.LastTime, -1);
									if (base.IsAllowRender)
									{
										this.intzaSaleByTime.EndUpdate();
									}
								}
								else if (this._currentPage == "Sale by Price")
								{
									if (this.SaleByPriceUpdateBuySell(lSMessageTFEX.Price, lSMessageTFEX.Side, 1, (long)lSMessageTFEX.Vol, false))
									{
										this.intzaSaleByPrice.Sort("price", SortType.Desc);
									}
									if (base.IsAllowRender)
									{
										this.intzaSaleByPrice.EndUpdate();
									}
									if (lSMessageTFEX.Side == "B" && lSMessageTFEX.DealSource != 20)
									{
										this.wcGraphVolume.UpdateData((double)lSMessageTFEX.Price, (long)lSMessageTFEX.Vol, (long)lSMessageTFEX.Vol, 0L);
									}
									else if (lSMessageTFEX.Side == "S" && lSMessageTFEX.DealSource != 20)
									{
										this.wcGraphVolume.UpdateData((double)lSMessageTFEX.Price, (long)lSMessageTFEX.Vol, 0L, (long)lSMessageTFEX.Vol);
									}
									else
									{
										this.wcGraphVolume.UpdateData((double)lSMessageTFEX.Price, (long)lSMessageTFEX.Vol, 0L, 0L);
									}
									if (base.IsAllowRender)
									{
										this.wcGraphVolume.EndUpdate();
									}
								}
								else if (this._currentPage == "Stock in Play")
								{
									this.StockInPlayUpdateBuySellVolume_TFEX(lSMessageTFEX.Side, lSMessageTFEX.Price, (long)lSMessageTFEX.Vol, 1);
									if (lSMessageTFEX.Side == "B")
									{
										this._buyDeals++;
									}
									else if (lSMessageTFEX.Side == "S")
									{
										this._sellDeals++;
									}
									this.StockInPlayUpdateTotalVolumeAndTotalDeals((long)lSMessageTFEX.LongQty, (long)lSMessageTFEX.ShortQty, (long)lSMessageTFEX.OpenQty);
									if (base.IsAllowRender)
									{
										this.intzaStockInPlay.EndUpdate();
									}
								}
								if (realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
								{
									LSMessageTFEX lSMessageTFEX2 = (LSMessageTFEX)message;
									if (lSMessageTFEX2.DealSource == 20)
									{
										if (ApplicationInfo.IndexInfoTfex.TXIState != "3C")
										{
											this.UpdateOpenOrProjectOpenPriceTFEX(ApplicationInfo.IndexInfoTfex.TXIState, lSMessageTFEX2.Price, realtimeSeriesInfo);
										}
										else
										{
											this.UpdateOpenOrProjectOpenPriceTFEX(ApplicationInfo.IndexInfoTfex.TXMState, lSMessageTFEX2.Price, realtimeSeriesInfo);
										}
									}
									this.UpdateAllVolumeTFEX(lSMessageTFEX2.Deals, (long)lSMessageTFEX2.AccVolume, lSMessageTFEX2.AccValue, (long)lSMessageTFEX2.OpenQty, (long)lSMessageTFEX2.LongQty, (long)lSMessageTFEX2.ShortQty, lSMessageTFEX2.OpenValue, lSMessageTFEX2.LongValue, lSMessageTFEX2.ShortValue, realtimeSeriesInfo.ContractSize, lSMessageTFEX2.Basis);
									if (base.IsAllowRender)
									{
										this.intzaInfoTFEX.EndUpdate();
										this.intzaVolumeByBoard.EndUpdate();
									}
									int num = lSMessageTFEX2.Vol;
									int num2;
									int.TryParse(num.ToString(), out num2);
									this.UpdateTickerInfo_TFEX(lSMessageTFEX2.Price, lSMessageTFEX2.Side, (long)num2, lSMessageTFEX2.LastTime, -1);
									if (base.IsAllowRender)
									{
										this.intzaLS.Redraw();
									}
								}
								break;
							}
							case "PO":
								if (realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
								{
									POMessageTFEX pOMessageTFEX = (POMessageTFEX)message;
									if (ApplicationInfo.IndexInfoTfex.TXIState != "3C")
									{
										this.UpdateOpenOrProjectOpenPriceTFEX(ApplicationInfo.IndexInfoTfex.TXIState, pOMessageTFEX.Equilibrium_price_I, realtimeSeriesInfo);
									}
									else
									{
										this.UpdateOpenOrProjectOpenPriceTFEX(ApplicationInfo.IndexInfoTfex.TXMState, pOMessageTFEX.Equilibrium_price_I, realtimeSeriesInfo);
									}
									if (base.IsAllowRender)
									{
										this.intzaInfoTFEX.EndUpdate();
									}
								}
								break;
							case "SD":
								if (realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
								{
									SDMessageTFEX sDMessageTFEX = (SDMessageTFEX)message;
									if (sDMessageTFEX.Lastdate.ToString().Length == 8)
									{
										this.intzaInfoTFEX.Item("last_date").Text = Utilities.GetDateFormat(sDMessageTFEX.Lastdate.ToString());
									}
									IntzaBaseItem arg_75D_0 = this.intzaInfoTFEX.Item("multiplier");
									int num = sDMessageTFEX.Price_quot_factor;
									arg_75D_0.Text = num.ToString();
									if (base.IsAllowRender)
									{
										this.intzaInfoTFEX.EndUpdate();
									}
								}
								break;
							case "CA8":
								if (realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
								{
									CA8MessageTFEX cA8MessageTFEX = (CA8MessageTFEX)message;
									if (ApplicationInfo.IndexInfoTfex.TXISession == 2)
									{
										this.intzaInfoTFEX.Item("settle").Text = Utilities.PriceFormat(cA8MessageTFEX.FixingPrice.ToString(), this._seriesInfoTFEX.NumOfDec);
										this.intzaInfoTFEX.Item("settle").FontColor = Utilities.ComparePriceColor(cA8MessageTFEX.FixingPrice, realtimeSeriesInfo.PrevFixPrice);
										if (realtimeSeriesInfo.MarketCode == 4 || realtimeSeriesInfo.MarketCode == 5)
										{
											this.intzaInfoTFEX.Item("psettle").Text = Utilities.PriceFormat(cA8MessageTFEX.FixingPrice, this._seriesInfoTFEX.NumOfDec);
											this.intzaInfoTFEX.Item("psettle").FontColor = MyColor.UnChgColor;
										}
									}
									else
									{
										this.intzaInfoTFEX.Item("psettle").Text = Utilities.PriceFormat(cA8MessageTFEX.FixingPrice, this._seriesInfoTFEX.NumOfDec);
										this.intzaInfoTFEX.Item("psettle").FontColor = MyColor.UnChgColor;
									}
									if (base.IsAllowRender)
									{
										this.intzaInfoTFEX.EndUpdate();
									}
								}
								break;
							case "BU10":
								if (realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
								{
									BU10MessageTFEX bU10MessageTFEX = (BU10MessageTFEX)message;
									this.intzaInfoTFEX.Item("tickSize").Text = Utilities.PriceFormat(bU10MessageTFEX.StepSize, this._seriesInfoTFEX.NumOfDec);
									if (base.IsAllowRender)
									{
										this.intzaInfoTFEX.EndUpdate();
									}
								}
								break;
							case "TCF":
								if (realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
								{
									TCFMessageTFEX tCFMessageTFEX = (TCFMessageTFEX)message;
									this.intzaInfoTFEX.Item("ceiling").Text = FormatUtil.PriceFormat(realtimeSeriesInfo.Ceiling.ToString(), realtimeSeriesInfo.NumOfDec, "");
									this.intzaInfoTFEX.Item("floor").Text = FormatUtil.PriceFormat(realtimeSeriesInfo.Floor.ToString(), realtimeSeriesInfo.NumOfDec, "");
									this.intzaInfoTFEX.Item("psettle").Text = Utilities.PriceFormat(tCFMessageTFEX.PrevFixPrice, realtimeSeriesInfo.NumOfDec);
									this.intzaInfoTFEX.Item("psettle").FontColor = MyColor.UnChgColor;
									if (base.IsAllowRender)
									{
										this.intzaInfoTFEX.EndUpdate();
									}
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						this.ShowError("ReceiveTfexMessage", ex);
					}
				}
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0008AAC4 File Offset: 0x00088EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbStock_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.RefreshData();
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0008AAF4 File Offset: 0x00088EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RefreshData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._currentPage == "Stock in Play")
			{
				this.StockInPlay_SetNewStock(this.tscbStock.Text.Trim(), true);
			}
			else if (this._currentPage == "Sale by Price")
			{
				this.SaleByPrice_SetNewStock(this.tscbStock.Text.Trim(), true);
			}
			else if (this._currentPage == "Sale by Time")
			{
				this.SaleByTime_SetNewStock(this.tscbStock.Text.Trim(), true);
			}
			else if (this._currentPage == "View Oddlot")
			{
				this.ViewOddLotSetNewStock(this.tscbStock.Text.Trim(), true);
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0008ABF0 File Offset: 0x00088FF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSaleByTimeClearTime_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tstxtSaleByTimeSearchTimeHour.Clear();
				this.tstxtSaleByTimeSearchTimeMinute.Clear();
				this.SaleByTime_SetNewStock(this.tscbStock.Text.Trim(), true);
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnSaleByTimeClearTime_Click", ex);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0008AC6C File Offset: 0x0008906C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaStockInPlay_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex >= 0)
				{
					if (Settings.Default.SmartOneClick)
					{
						string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
						string text = this.intzaStockInPlay.Records(e.RowIndex).Fields("price").Text.ToString();
						text = text.Replace("+", "");
						text = text.Replace("-", "");
						TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, ApplicationInfo.CurrentSymbol, text, false);
					}
					else
					{
						TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(ApplicationInfo.CurrentSymbol);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaStockInPlay_TableMouseClick", ex);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0008AD88 File Offset: 0x00089188
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaStockInPlayLS_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (Settings.Default.SmartOneClick && e.RowIndex >= 0)
				{
					string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
					string text = this.intzaLS.Records(e.RowIndex).Fields("price").Text.ToString();
					text = text.Replace("+", "");
					text = text.Replace("-", "");
					TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, ApplicationInfo.CurrentSymbol, text, false);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaStockInPlayLS_TableMouseClick", ex);
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0008AE84 File Offset: 0x00089284
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaSaleByPrice_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex >= 0)
				{
					if (Settings.Default.SmartOneClick)
					{
						string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
						string price = this.intzaSaleByPrice.Records(e.RowIndex).Fields("price").Text.ToString();
						TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, ApplicationInfo.CurrentSymbol, price, false);
					}
					else
					{
						TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(ApplicationInfo.CurrentSymbol);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaSaleByPrice_TableMouseClick", ex);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0008AF7C File Offset: 0x0008937C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaSaleByTime_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex >= 0)
				{
					if (Settings.Default.SmartOneClick)
					{
						string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
						string text = this.intzaSaleByTime.Records(e.RowIndex).Fields("price").Text.ToString();
						text = text.Replace("+", "");
						text = text.Replace("-", "");
						TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, ApplicationInfo.CurrentSymbol, text, false);
					}
					else
					{
						TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(ApplicationInfo.CurrentSymbol);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaSaleByTime_TableMouseClick", ex);
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0008B098 File Offset: 0x00089498
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaViewOddLot_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex >= 0)
				{
					if (Settings.Default.SmartOneClick)
					{
						string price = string.Empty;
						string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
						if (e.Column.Name == "bid" || e.Column.Name == "offer")
						{
							price = this.intzaViewOddLot.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString();
						}
						TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, ApplicationInfo.CurrentSymbol, price, false);
					}
					else
					{
						TemplateManager.Instance.MainForm.SendOrderBox.SetCurrentSymbol(ApplicationInfo.CurrentSymbol);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaViewOddLot_TableMouseClick", ex);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0008B1E8 File Offset: 0x000895E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPage(string currentPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._currentPage = currentPage;
				if (this._currentPage == "Stock in Play")
				{
					this.tsbtnStockInPlayPrevPage.Visible = true;
					this.tsbtnStockInPlayNextPage.Visible = true;
					this.intzaStockInPlay.Show();
				}
				else if (this._currentPage == "Sale by Price")
				{
					this.intzaSaleByPrice.Show();
					this.wcGraphVolume.Show();
				}
				else if (this._currentPage == "Sale by Time")
				{
					this.tslbHour.Visible = true;
					this.tstxtSaleByTimeSearchTimeHour.Visible = true;
					this.tslbMinute.Visible = true;
					this.tstxtSaleByTimeSearchTimeMinute.Visible = true;
					this.tsbtnSaleByTimeClearTime2.Visible = true;
					this.tssepSaleByTime2.Visible = true;
					this.tsbtnSaleByTimeFirstPage.Visible = true;
					this.tsbtnSaleByTimePrevPage.Visible = true;
					this.tslblSaleByTimePageNo.Visible = true;
					this.tsbtnSaleByTimeNextPage.Visible = true;
					this.intzaSaleByTime.Show();
				}
				else if (this._currentPage == "View Oddlot")
				{
				}
				if (this._currentPage == "View Oddlot")
				{
					this.intzaViewOddLotInfo.Show();
					this.intzaViewOddLot.Show();
					this.intzaLS.Visible = true;
					this.intzaInfo.Visible = false;
					this.intzaVolumeByBoard.Visible = false;
					this.intzaInfoTFEX.Visible = false;
				}
				else
				{
					this.intzaInfo.Visible = true;
					this.intzaLS.Visible = true;
					this.intzaVolumeByBoard.Visible = true;
				}
				if (this._currentPage != "Stock in Play")
				{
					this.tsbtnStockInPlayPrevPage.Visible = false;
					this.tsbtnStockInPlayNextPage.Visible = false;
					this.intzaStockInPlay.Hide();
				}
				if (this._currentPage != "Sale by Price")
				{
					this.intzaSaleByPrice.Hide();
					this.wcGraphVolume.Hide();
				}
				if (this._currentPage != "Sale by Time")
				{
					this.tslbHour.Visible = false;
					this.tstxtSaleByTimeSearchTimeHour.Visible = false;
					this.tslbMinute.Visible = false;
					this.tstxtSaleByTimeSearchTimeMinute.Visible = false;
					this.tsbtnSaleByTimeClearTime2.Visible = false;
					this.tssepSaleByTime2.Visible = false;
					this.tsbtnSaleByTimeFirstPage.Visible = false;
					this.tsbtnSaleByTimePrevPage.Visible = false;
					this.tslblSaleByTimePageNo.Visible = false;
					this.tsbtnSaleByTimeNextPage.Visible = false;
					this.intzaSaleByTime.Hide();
				}
				if (this._currentPage != "View Oddlot")
				{
					this.intzaViewOddLot.Hide();
					this.intzaViewOddLotInfo.Hide();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetPage", ex);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0008B57C File Offset: 0x0008997C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void comboStock_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				switch (e.KeyCode)
				{
				case Keys.Prior:
					if (this._currentPage == "Stock in Play")
					{
						this.tsbtnStockInPlayPrevPage.PerformClick();
					}
					else if (this._currentPage == "Sale by Time")
					{
						this.tsbtnSaleByTimePrevPage.PerformClick();
					}
					e.SuppressKeyPress = true;
					break;
				case Keys.Next:
					if (this._currentPage == "Stock in Play")
					{
						this.tsbtnStockInPlayNextPage.PerformClick();
					}
					else if (this._currentPage == "Sale by Time")
					{
						this.tsbtnSaleByTimeNextPage.PerformClick();
					}
					e.SuppressKeyPress = true;
					break;
				case Keys.Home:
				case Keys.Up:
				case Keys.Down:
					e.SuppressKeyPress = true;
					break;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("comboStock_KeyDown", ex);
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0008B6D0 File Offset: 0x00089AD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbSelection_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!base.IsLoadingData)
				{
					this.SetPage(this.tscbSelection.Text.Trim());
					this.SetResize();
					this.ReloadDataPage(this._currentPage, true);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tscbSelection_SelectedIndexChanged", ex);
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0008B754 File Offset: 0x00089B54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaleByPriceUpdateToControl_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaSaleByPrice.BeginUpdate();
				this.intzaLS.BeginUpdate();
				this.intzaLS.ClearAllText();
				if (this.dsSaleByPrice != null && this.dsSaleByPrice.Tables.Contains("Sell_by_price"))
				{
					this.intzaSaleByPrice.Rows = 0;
					this.wcGraphVolume.InitData(this._seriesInfoTFEX.Symbol, (double)this._seriesInfoTFEX.PrevFixPrice, (double)this._seriesInfoTFEX.LastSalePrice, (double)this._seriesInfoTFEX.Ceiling, (double)this._seriesInfoTFEX.Floor);
					foreach (DataRow dataRow in this.dsSaleByPrice.Tables["Sell_by_price"].Rows)
					{
						decimal num;
						decimal.TryParse(dataRow["nmrPrice"].ToString(), out num);
						int sideDeals;
						int.TryParse(dataRow["LongDeal"].ToString(), out sideDeals);
						long num2;
						long.TryParse(dataRow["LongVolume"].ToString(), out num2);
						this.SaleByPriceUpdateBuySell(num, "B", sideDeals, num2, true);
						int.TryParse(dataRow["ShortDeal"].ToString(), out sideDeals);
						long num3;
						long.TryParse(dataRow["ShortVolume"].ToString(), out num3);
						this.SaleByPriceUpdateBuySell(num, "S", sideDeals, num3, true);
						long num4;
						long.TryParse(dataRow["TotalVolume"].ToString(), out num4);
						this.SaleByPriceUpdateBuySell(num, "", 0, num4 - (num2 + num3), true);
						this.wcGraphVolume.InputData((double)num, num4, num2, num3);
					}
					this.wcGraphVolume.EndUpdate();
					this.wcGraphVolume.Sort();
				}
				this.UpdateToControl_TFEX(this.dsSaleByPrice);
				this.intzaSaleByPrice.Redraw();
				this.intzaLS.Redraw();
				this.intzaInfoTFEX.Redraw();
				this.intzaVolumeByBoard.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("SaleByPriceUpdateToControl", ex);
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0008BA28 File Offset: 0x00089E28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaInfo.BeginUpdate();
				this.intzaLS.BeginUpdate();
				this.intzaVolumeByBoard.BeginUpdate();
				this.intzaInfo.ClearAllText();
				this.intzaLS.ClearAllText();
				this.intzaVolumeByBoard.ClearAllText();
				if (ds.Tables.Count > 0)
				{
					if (ds.Tables.Contains("security_stat") && ds.Tables["security_stat"].Rows.Count > 0)
					{
						DataRow dataRow = ds.Tables["security_stat"].Rows[0];
						decimal num = 0m;
						if (decimal.TryParse(dataRow["ceiling"].ToString(), out num))
						{
							if (num != this._stockInfoSET.Ceiling)
							{
								this._stockInfoSET.Ceiling = num;
							}
						}
						if (decimal.TryParse(dataRow["floor"].ToString(), out num))
						{
							if (num != this._stockInfoSET.Floor)
							{
								this._stockInfoSET.Floor = num;
							}
						}
						this.intzaInfo.Item("ceiling").Text = this._stockInfoSET.Ceiling.ToString();
						this.intzaInfo.Item("floor").Text = this._stockInfoSET.Floor.ToString();
						this.intzaInfo.Item("ceiling").FontColor = MyColor.CeilingColor;
						this.intzaInfo.Item("floor").FontColor = MyColor.FloorColor;
						if (ds.Tables["security_stat"].Columns.Contains("high52w"))
						{
							this.intzaInfo.Item("h52w").Text = dataRow["high52w"].ToString();
							this.intzaInfo.Item("l52w").Text = dataRow["low52w"].ToString();
							this.intzaInfo.Item("h52w").FontColor = MyColor.UpColor;
							this.intzaInfo.Item("l52w").FontColor = MyColor.DownColor;
						}
						if (decimal.TryParse(dataRow["prior_close_price"].ToString(), out num))
						{
							if (num != this._stockInfoSET.PriorPrice)
							{
								this._stockInfoSET.PriorPrice = num;
							}
						}
						this.intzaInfo.Item("prior").Text = Utilities.PriceFormat(this._stockInfoSET.PriorPrice, 2, 0);
						this.intzaInfo.Item("prior").FontColor = MyColor.UnChgColor;
						this.intzaInfo.Item("par").Text = Utilities.PriceFormat(dataRow["par_value"], 5);
						this.intzaInfo.Item("flag").Text = dataRow["display_flag"].ToString();
						this.intzaInfo.Item("tbMarginRate").Text = Utilities.PriceFormat(dataRow["margin_rate"], "%");
						this._stockInfoSET.LastSalePrice = Convert.ToDecimal(dataRow["last_sale_price"]);
						this._stockInfoSET.HighPrice = Convert.ToDecimal(dataRow["high_price"]);
						this._stockInfoSET.LowPrice = Convert.ToDecimal(dataRow["low_price"]);
						this.UpdatePriceInfo(this._stockInfoSET.LastSalePrice, this._stockInfoSET.HighPrice, this._stockInfoSET.LowPrice);
						if (ApplicationInfo.MarketSession == 1)
						{
							if (ApplicationInfo.MarketState == "P")
							{
								this.UpdateOpenOrProjectOpenPrice("P", 1, Convert.ToDecimal(dataRow["projected_open"]));
							}
							else
							{
								this.UpdateOpenOrProjectOpenPrice("O", 1, Convert.ToDecimal(dataRow["open_price1"]));
							}
						}
						else if (ApplicationInfo.MarketSession == 2)
						{
							this.UpdateOpenOrProjectOpenPrice("O", 1, Convert.ToDecimal(dataRow["open_price1"]));
							if (ApplicationInfo.MarketState == "P")
							{
								this.UpdateOpenOrProjectOpenPrice("P", 2, Convert.ToDecimal(dataRow["projected_open"]));
							}
							else
							{
								this.UpdateOpenOrProjectOpenPrice("O", 2, Convert.ToDecimal(dataRow["open_price2"]));
							}
						}
						if (ApplicationInfo.MarketState == "P")
						{
							this.UpdateProjectedVolume(Convert.ToInt64(dataRow["projected_open_volume"]));
						}
						this.UpdateProjectedClosePrice(Convert.ToDecimal(dataRow["projected_close"]));
						if (ApplicationInfo.MarketState == "M")
						{
							this.UpdateProjectedVolume(Convert.ToInt64(dataRow["projected_close_volume"]));
						}
						this.UpdateAllVolume(Convert.ToInt32(dataRow["deals"]), Convert.ToInt64(dataRow["accvolume"]), Convert.ToDecimal(dataRow["accvalue"]), Convert.ToInt64(dataRow["open_volume"]), Convert.ToInt64(dataRow["buy_volume"]), Convert.ToInt64(dataRow["sell_volume"]));
						this.UpdateMainBoardValue(Convert.ToInt32(dataRow["deals"]), Convert.ToInt64(dataRow["accvolume"]), Convert.ToDecimal(dataRow["accvalue"]));
						if (ds.Tables.Contains("last_sale"))
						{
							int num2 = 0;
							foreach (DataRow dataRow2 in ds.Tables["last_sale"].Rows)
							{
								this.UpdateStockTicker(Convert.ToDecimal(dataRow2["price"]), dataRow2["side"].ToString(), Convert.ToInt64(dataRow2["volume"]), dataRow2["last_update"].ToString(), num2);
								num2++;
							}
						}
						this.UpdateBigLotValue(Convert.ToInt32(dataRow["deal_in_biglot"]), Convert.ToDecimal(dataRow["biglot_accvalue"]), Convert.ToInt64(dataRow["biglot_accvolume"]));
						dataRow = null;
					}
				}
				this.intzaVolumeByBoard.Redraw();
				this.intzaInfo.Redraw();
				this.intzaLS.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl", ex);
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0008C21C File Offset: 0x0008A61C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePriceInfo(decimal lastPrice, decimal high, decimal low)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmStockSummary.UpdatePriceInfoCallBack(this.UpdatePriceInfo), new object[]
				{
					lastPrice,
					high,
					low
				});
			}
			else
			{
				try
				{
					this.intzaInfo.Item("spread").Text = Utilities.GetSpreadPrice(lastPrice, this._stockInfoSET.PriorPrice, this._stockInfoSET.IsCheckSpread).ToString();
					this.intzaInfo.Item("high").Text = high.ToString();
					this.intzaInfo.Item("low").Text = low.ToString();
					this.intzaInfo.Item("high").FontColor = Utilities.ComparePriceCFColor(high, this._stockInfoSET);
					this.intzaInfo.Item("low").FontColor = Utilities.ComparePriceCFColor(low, this._stockInfoSET);
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateLastSalePrice", ex);
				}
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0008C378 File Offset: 0x0008A778
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateOpenOrProjectOpenPrice(string state, int session, decimal price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmStockSummary.UpdateOpenOrProjectOpenPriceCallBack(this.UpdateOpenOrProjectOpenPrice), new object[]
				{
					state,
					session,
					price
				});
			}
			else
			{
				try
				{
					if (state == "P")
					{
						Color backColor = Utilities.ComparePriceCFColor(price, this._stockInfoSET);
						if (session == 1)
						{
							if (price > 0m)
							{
								this.intzaInfo.Item("open1").Text = price.ToString();
								this.intzaInfo.Item("open1").BackColor = backColor;
								this.intzaInfo.Item("open1").FontColor = Color.Black;
							}
							else
							{
								this.intzaInfo.Item("open1").BackColor = this.intzaInfo.BackColor;
							}
						}
						else if (session == 2)
						{
							if (price > 0m)
							{
								this.intzaInfo.Item("open2").Text = price.ToString();
								this.intzaInfo.Item("open2").BackColor = backColor;
								this.intzaInfo.Item("open2").FontColor = Color.Black;
							}
							else
							{
								this.intzaInfo.Item("open2").BackColor = this.intzaInfo.BackColor;
							}
						}
					}
					else if (state == "O")
					{
						if (session == 1)
						{
							this.intzaInfo.Item("open1").Text = price.ToString();
							this.intzaInfo.Item("open1").BackColor = this.intzaInfo.BackColor;
							this.intzaInfo.Item("open1").FontColor = Utilities.ComparePriceCFColor(price, this._stockInfoSET);
						}
						else if (session == 2)
						{
							this.intzaInfo.Item("open2").Text = price.ToString();
							this.intzaInfo.Item("open2").BackColor = this.intzaInfo.BackColor;
							this.intzaInfo.Item("open2").FontColor = Utilities.ComparePriceCFColor(price, this._stockInfoSET);
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateOpenOrProjectOpenPrice", ex);
				}
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0008C688 File Offset: 0x0008AA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateProjectedVolume(long volume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmStockSummary.UpdateProjectedVolumeCallBack(this.UpdateProjectedVolume), new object[]
				{
					volume
				});
			}
			else
			{
				try
				{
					if (volume > -1L)
					{
						if (volume > 10000000L)
						{
							volume /= 1000L;
							this.intzaInfo.Item("povol").Text = volume.ToString("#,##0") + "K";
						}
						else
						{
							this.intzaInfo.Item("povol").Text = volume.ToString("#,##0");
						}
					}
					else
					{
						this.intzaInfo.Item("povol").Text = "";
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateProjectedVolume", ex);
				}
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0008C7C0 File Offset: 0x0008ABC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateProjectedClosePrice(decimal closePrice)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmStockSummary.UpdateProjectedClosePriceCallBack(this.UpdateProjectedClosePrice), new object[]
				{
					closePrice
				});
			}
			else
			{
				try
				{
					this.intzaInfo.Item("poclose").Text = closePrice.ToString();
					if (closePrice == 0m)
					{
						this.intzaInfo.Item("poclose").BackColor = this.intzaInfo.BackColor;
						this.intzaInfo.Item("poclose").FontColor = Color.White;
					}
					else if (ApplicationInfo.MarketState == "M")
					{
						Color backColor = Utilities.ComparePriceCFColor(closePrice, this._stockInfoSET);
						this.intzaInfo.Item("poclose").BackColor = backColor;
						this.intzaInfo.Item("poclose").FontColor = Color.Black;
					}
					else
					{
						this.intzaInfo.Item("poclose").BackColor = this.intzaInfo.BackColor;
						this.intzaInfo.Item("poclose").FontColor = Utilities.ComparePriceCFColor(closePrice, this._stockInfoSET);
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateProjectedClosePrice", ex);
				}
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0008C978 File Offset: 0x0008AD78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateAllVolume(int deals, long accVolume, decimal accValue, long openVolume, long buyVolume, long sellVolume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmStockSummary.UpdateAllVolumeCallBack(this.UpdateAllVolume), new object[]
				{
					deals,
					accVolume,
					accValue,
					openVolume,
					buyVolume,
					sellVolume
				});
			}
			else
			{
				try
				{
					decimal num = 0m;
					decimal num2 = 0m;
					decimal num3 = 0m;
					if (accVolume > 0L)
					{
						decimal num4 = Math.Round(accValue / accVolume, 2);
						num = openVolume / accVolume * 100m;
						num2 = buyVolume / accVolume * 100m;
						num3 = ((sellVolume > 0L) ? (100m - num2 - num) : 0m);
					}
					this.intzaInfo.Item("open_vol").Text = openVolume.ToString();
					this.intzaInfo.Item("buy_vol").Text = buyVolume.ToString();
					this.intzaInfo.Item("sel_vol").Text = sellVolume.ToString();
					this.intzaInfo.Item("p_open_vol").Text = Utilities.PriceFormat(num, "%");
					this.intzaInfo.Item("p_buy_vol").Text = Utilities.PriceFormat(num2, "%");
					this.intzaInfo.Item("p_sel_vol").Text = Utilities.PriceFormat(num3, "%");
					this.intzaInfo.Item("pie").Text = string.Concat(new string[]
					{
						num.ToString("0.00"),
						";",
						num2.ToString("0.00"),
						";",
						num3.ToString("0.00")
					});
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateAllVolume", ex);
				}
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0008CC28 File Offset: 0x0008B028
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateStockTicker(decimal price, string side, long volume, string lastUpdate, int index)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaLS.InvokeRequired)
			{
				this.intzaLS.Invoke(new frmStockSummary.UpdateLastSaleTickerInfoCallBack(this.UpdateStockTicker), new object[]
				{
					price,
					side,
					volume,
					lastUpdate,
					index
				});
			}
			else
			{
				try
				{
					RecordItem recordItem;
					if (index == -1)
					{
						recordItem = this.intzaLS.AddRecord(1, true);
					}
					else
					{
						recordItem = this.intzaLS.Records(index);
					}
					recordItem.Fields("volume").Text = volume.ToString();
					recordItem.Fields("side").Text = side;
					recordItem.Fields("price").Text = Utilities.PriceFormat(price);
					recordItem.Fields("time").Text = Utilities.GetTime(lastUpdate);
					Color fontColor = Utilities.ComparePriceCFColor(price, this._stockInfoSET);
					if (side == "B")
					{
						recordItem.Fields("side").FontColor = MyColor.BuyColor;
						recordItem.Fields("volume").FontColor = MyColor.BuyColor;
					}
					else if (side == "S")
					{
						recordItem.Fields("side").FontColor = MyColor.SellColor;
						recordItem.Fields("volume").FontColor = MyColor.SellColor;
					}
					else
					{
						recordItem.Fields("side").FontColor = MyColor.OpenColor;
						recordItem.Fields("volume").FontColor = MyColor.OpenColor;
					}
					recordItem.Fields("price").FontColor = fontColor;
					recordItem.Fields("time").FontColor = Color.LightGray;
					recordItem.Changed = true;
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateStockTicker", ex);
				}
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0008CE74 File Offset: 0x0008B274
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateFromSS(StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmStockSummary.UpdateFromSSCallBack(this.UpdateFromSS), new object[]
				{
					realtimeStockInfo
				});
			}
			else
			{
				try
				{
					this.intzaInfo.Item("ceiling").Text = realtimeStockInfo.Ceiling.ToString();
					this.intzaInfo.Item("floor").Text = realtimeStockInfo.Floor.ToString();
					this.intzaInfo.Item("prior").Text = Utilities.PriceFormat(realtimeStockInfo.PriorPrice, 2, 0);
					this.intzaInfo.Item("flag").Text = realtimeStockInfo.DisplayFlag;
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateFromSS", ex);
				}
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0008CF90 File Offset: 0x0008B390
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateMainBoardValue(int deals, long accVolume, decimal accValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaVolumeByBoard.InvokeRequired)
			{
				this.intzaVolumeByBoard.Invoke(new frmStockSummary.UpdateMainBoardValueCallBack(this.UpdateMainBoardValue), new object[]
				{
					deals,
					accVolume,
					accValue
				});
			}
			else
			{
				try
				{
					this.intzaVolumeByBoard.Records(0).Fields("h1").Text = "Main";
					this.intzaVolumeByBoard.Records(0).Fields("deals").Text = deals.ToString();
					this.intzaVolumeByBoard.Records(0).Fields("volume").Text = accVolume.ToString();
					this.intzaVolumeByBoard.Records(0).Fields("value").Text = Utilities.VolumeFormat(accValue, true);
					this.intzaVolumeByBoard.Records(0).Fields("deals").FontColor = MyColor.UnChgColor;
					this.intzaVolumeByBoard.Records(0).Fields("volume").FontColor = MyColor.UnChgColor;
					this.intzaVolumeByBoard.Records(0).Fields("value").FontColor = MyColor.UnChgColor;
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateMainBoardValue", ex);
				}
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0008D124 File Offset: 0x0008B524
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBigLotValue(int bDeal, decimal bValue, long bVolume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaVolumeByBoard.InvokeRequired)
			{
				this.intzaVolumeByBoard.Invoke(new frmStockSummary.UpdateBigLotValueCallBack(this.UpdateBigLotValue), new object[]
				{
					bDeal,
					bValue,
					bVolume
				});
			}
			else
			{
				try
				{
					this.intzaVolumeByBoard.Records(1).Fields("h1").Text = "Biglot";
					this.intzaVolumeByBoard.Records(1).Fields("deals").Text = bDeal.ToString();
					this.intzaVolumeByBoard.Records(1).Fields("volume").Text = bVolume.ToString();
					this.intzaVolumeByBoard.Records(1).Fields("value").Text = Utilities.VolumeFormat(bValue, true);
					this.intzaVolumeByBoard.Records(1).Fields("deals").FontColor = MyColor.UnChgColor;
					this.intzaVolumeByBoard.Records(1).Fields("volume").FontColor = MyColor.UnChgColor;
					this.intzaVolumeByBoard.Records(1).Fields("value").FontColor = MyColor.UnChgColor;
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateBigLotValue", ex);
				}
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0008D2B8 File Offset: 0x0008B6B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl_TFEX(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaLS.BeginUpdate();
				this.intzaVolumeByBoard.BeginUpdate();
				this.intzaInfoTFEX.BeginUpdate();
				this.intzaLS.ClearAllText();
				this.intzaVolumeByBoard.ClearAllText();
				this.intzaInfoTFEX.ClearAllText();
				if (ds.Tables.Count > 0)
				{
					if (ds.Tables.Contains("series_info_stat") && ds.Tables["series_info_stat"].Rows.Count > 0)
					{
						DataRow dataRow = ds.Tables["series_info_stat"].Rows[0];
						Color unChgColor = MyColor.UnChgColor;
						decimal num;
						decimal.TryParse(dataRow["Basis"].ToString(), out num);
						decimal num2;
						decimal.TryParse(dataRow["lastIndex"].ToString(), out num2);
						decimal num3;
						decimal.TryParse(dataRow["priorIndex"].ToString(), out num3);
						decimal num4;
						decimal.TryParse(dataRow["PrevClosePrice"].ToString(), out num4);
						decimal num5;
						decimal.TryParse(dataRow["PrjOpenPrice"].ToString(), out num5);
						decimal num6;
						decimal.TryParse(dataRow["PrjOpenPrice2"].ToString(), out num6);
						decimal num7;
						decimal.TryParse(dataRow["PrjOpenPrice3"].ToString(), out num7);
						decimal num8;
						decimal.TryParse(dataRow["PriceOpen1"].ToString(), out num8);
						decimal num9;
						decimal.TryParse(dataRow["PriceOpen2"].ToString(), out num9);
						decimal num10;
						decimal.TryParse(dataRow["PriceOpen3"].ToString(), out num10);
						this.intzaInfoTFEX.Item("basis").Text = num.ToString();
						this.intzaInfoTFEX.Item("basis").FontColor = Utilities.ComparePriceColor(num, 0m);
						this.intzaInfoTFEX.Item("ceiling").Text = Utilities.PriceFormat(this._seriesInfoTFEX.Ceiling, this._seriesInfoTFEX.NumOfDec);
						this.intzaInfoTFEX.Item("ceiling").FontColor = MyColor.CeilingColor;
						this.intzaInfoTFEX.Item("floor").Text = Utilities.PriceFormat(this._seriesInfoTFEX.Floor, this._seriesInfoTFEX.NumOfDec);
						this.intzaInfoTFEX.Item("floor").FontColor = MyColor.FloorColor;
						this.intzaInfoTFEX.Item("psettle").Text = Utilities.PriceFormat(this._seriesInfoTFEX.PrevFixPrice, this._seriesInfoTFEX.NumOfDec);
						this.intzaInfoTFEX.Item("psettle").FontColor = MyColor.UnChgColor;
						this.intzaInfoTFEX.Item("settle").Text = Utilities.PriceFormat(this._seriesInfoTFEX.FixPrice, this._seriesInfoTFEX.NumOfDec);
						this.intzaInfoTFEX.Item("settle").FontColor = MyColor.UnChgColor;
						if (dataRow["FirstTradingDate"].ToString().Length == 8)
						{
							this.intzaInfoTFEX.Item("first_date").Text = Utilities.GetDateFormat(dataRow["FirstTradingDate"].ToString());
						}
						if (dataRow["LastTradingDate"].ToString().Length == 8)
						{
							this.intzaInfoTFEX.Item("last_date").Text = Utilities.GetDateFormat(dataRow["LastTradingDate"].ToString());
						}
						this.intzaInfoTFEX.Item("lastIndex").Text = Utilities.PriceFormat(num2, this._seriesInfoTFEX.NumOfDec);
						this.intzaInfoTFEX.Item("lastIndex").FontColor = MyColor.UnChgColor;
						UnderlyingInfo.UnderlyingList underlyingList = ApplicationInfo.UnderlyingInfo[this._seriesInfoTFEX.UnderOrderBookId];
						if (underlyingList.OrderBookId > 0)
						{
							this.intzaInfoTFEX.Item("lastIndex_label").Text = underlyingList.Symbol;
							this.intzaInfoTFEX.Item("lastIndex_label").FontColor = Color.White;
						}
						this.intzaInfoTFEX.Item("poclose").Text = Utilities.PriceFormat(num4, this._seriesInfoTFEX.NumOfDec);
						this.intzaInfoTFEX.Item("multiplier").Text = dataRow["Multiplier"].ToString();
						this.intzaInfoTFEX.Item("tickSize").Text = Utilities.PriceFormat(dataRow["tickSize"].ToString(), this._seriesInfoTFEX.NumOfDec);
						if (ApplicationInfo.IndexInfoTfex.TXISession == 1)
						{
							if (num8 != 0m && ApplicationInfo.IndexInfoTfex.TXIState != "7")
							{
								this.UpdateOpenOrProjectOpenPriceTFEX("11", num8, this._seriesInfoTFEX);
							}
							else if (num5 != 0m && ApplicationInfo.IndexInfoTfex.TXIState == "7")
							{
								this.UpdateOpenOrProjectOpenPriceTFEX("7", num5, this._seriesInfoTFEX);
							}
							else
							{
								this.intzaInfoTFEX.Item("open1").BackColor = this.intzaInfoTFEX.BackColor;
							}
						}
						else if (ApplicationInfo.IndexInfoTfex.TXISession == 2)
						{
							if (num8 != 0m)
							{
								this.UpdateOpenOrProjectOpenPriceTFEX("11", num8, this._seriesInfoTFEX);
							}
							if (num9 != 0m)
							{
								this.UpdateOpenOrProjectOpenPriceTFEX("10", num9, this._seriesInfoTFEX);
							}
							else if (num6 != 0m && ApplicationInfo.IndexInfoTfex.TXIState == "9")
							{
								this.UpdateOpenOrProjectOpenPriceTFEX("9", num6, this._seriesInfoTFEX);
							}
							else
							{
								this.intzaInfoTFEX.Item("open2").BackColor = this.intzaInfoTFEX.BackColor;
							}
							if (num10 != 0m)
							{
								this.UpdateOpenOrProjectOpenPriceTFEX("24", num10, this._seriesInfoTFEX);
							}
							else if (num7 != 0m && ApplicationInfo.IndexInfoTfex.TXMState == "23")
							{
								this.UpdateOpenOrProjectOpenPriceTFEX("23", num7, this._seriesInfoTFEX);
							}
							else
							{
								this.intzaInfoTFEX.Item("open3").BackColor = this.intzaInfoTFEX.BackColor;
							}
						}
						decimal num11;
						decimal.TryParse(dataRow["Multiplier"].ToString(), out num11);
						int num12;
						int.TryParse(dataRow["OpenInterest"].ToString(), out num12);
						this.intzaInfoTFEX.Item("oi").Text = Utilities.VolumeFormat(num12, true);
						decimal num13;
						decimal.TryParse(dataRow["HighPrice"].ToString(), out num13);
						decimal num14;
						decimal.TryParse(dataRow["LowPrice"].ToString(), out num14);
						decimal num15;
						decimal.TryParse(dataRow["LastPrice"].ToString(), out num15);
						int num16;
						int.TryParse(dataRow["TurnOverQty"].ToString(), out num16);
						decimal num17;
						decimal.TryParse(dataRow["TurnOverValue"].ToString(), out num17);
						long openVolume;
						long.TryParse(dataRow["TotalOpenQty"].ToString(), out openVolume);
						long longVolume;
						long.TryParse(dataRow["LongQty"].ToString(), out longVolume);
						long shortVolume;
						long.TryParse(dataRow["ShortQty"].ToString(), out shortVolume);
						int deals;
						int.TryParse(dataRow["NumOfDeal"].ToString(), out deals);
						decimal d;
						decimal.TryParse(dataRow["TotalOpenValue"].ToString(), out d);
						decimal d2;
						decimal.TryParse(dataRow["LongValue"].ToString(), out d2);
						decimal d3;
						decimal.TryParse(dataRow["ShortValue"].ToString(), out d3);
						if (num16 > 0)
						{
							decimal num18 = num17 / num16;
						}
						if (num11 > 0m)
						{
							this.UpdateAllVolumeTFEX(deals, (long)num16, num17, openVolume, longVolume, shortVolume, d / num11, d2 / num11, d3 / num11, num11, num);
						}
						else
						{
							this.UpdateMainBoardValue(deals, (long)num16, 0m);
						}
						long volume = 0L;
						if (ds.Tables.Contains("last_sale_tfex"))
						{
							int num19 = 0;
							foreach (DataRow dataRow2 in ds.Tables["last_sale_tfex"].Rows)
							{
								long.TryParse(dataRow2["iQuantity"].ToString(), out volume);
								decimal price;
								decimal.TryParse(dataRow2["nmrPrice"].ToString(), out price);
								this.UpdateTickerInfo_TFEX(price, dataRow2["sSide"].ToString(), volume, Utilities.GetTimeLastSale(dataRow2["dtLastUpd"].ToString()), num19);
								num19++;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl_TFEX", ex);
			}
			finally
			{
				this.intzaLS.Redraw();
				this.intzaVolumeByBoard.Redraw();
				this.intzaInfoTFEX.Redraw();
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0008DDF4 File Offset: 0x0008C1F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateOpenOrProjectOpenPriceTFEX(string state, decimal price, SeriesList.SeriesInformation sf)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (state == "7")
				{
					if (price != 0m)
					{
						this.intzaInfoTFEX.Item("open1").Text = Utilities.PriceFormat(price, sf.NumOfDec);
						this.intzaInfoTFEX.Item("open1").BackColor = Utilities.ComparePriceCFColor(price, sf);
						this.intzaInfoTFEX.Item("open1").FontColor = Color.Black;
					}
					else
					{
						this.intzaInfoTFEX.Item("open1").BackColor = this.intzaInfoTFEX.BackColor;
					}
				}
				else if (state == "9")
				{
					if (price != 0m)
					{
						this.intzaInfoTFEX.Item("open2").Text = Utilities.PriceFormat(price, sf.NumOfDec);
						this.intzaInfoTFEX.Item("open2").BackColor = Utilities.ComparePriceCFColor(price, sf);
						this.intzaInfoTFEX.Item("open2").FontColor = Color.Black;
					}
					else
					{
						this.intzaInfoTFEX.Item("open2").BackColor = this.intzaInfoTFEX.BackColor;
					}
				}
				else if (state == "11")
				{
					if (price != 0m)
					{
						this.intzaInfoTFEX.Item("open1").Text = Utilities.PriceFormat(price, sf.NumOfDec);
						this.intzaInfoTFEX.Item("open1").BackColor = this.intzaInfoTFEX.BackColor;
						this.intzaInfoTFEX.Item("open1").FontColor = Utilities.ComparePriceCFColor(price, sf);
					}
				}
				else if (state == "10")
				{
					if (price != 0m)
					{
						this.intzaInfoTFEX.Item("open2").Text = Utilities.PriceFormat(price, sf.NumOfDec);
						this.intzaInfoTFEX.Item("open2").BackColor = this.intzaInfoTFEX.BackColor;
						this.intzaInfoTFEX.Item("open2").FontColor = Utilities.ComparePriceCFColor(price, sf);
					}
				}
				else if (state == "23")
				{
					if (price != 0m)
					{
						this.intzaInfoTFEX.Item("open3").Text = Utilities.PriceFormat(price, sf.NumOfDec);
						this.intzaInfoTFEX.Item("open3").BackColor = Utilities.ComparePriceCFColor(price, sf);
						this.intzaInfoTFEX.Item("open3").FontColor = Color.Black;
					}
					else
					{
						this.intzaInfoTFEX.Item("open3").BackColor = this.intzaInfoTFEX.BackColor;
					}
				}
				else if (state == "24")
				{
					if (price != 0m)
					{
						this.intzaInfoTFEX.Item("open3").Text = Utilities.PriceFormat(price, sf.NumOfDec);
						this.intzaInfoTFEX.Item("open3").BackColor = this.intzaInfoTFEX.BackColor;
						this.intzaInfoTFEX.Item("open3").FontColor = Utilities.ComparePriceCFColor(price, sf);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateOpenOrProjectOpenPriceTFEX", ex);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0008E240 File Offset: 0x0008C640
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateAllVolumeTFEX(int deals, long accVolume, decimal accValue, long openVolume, long longVolume, long shortVolume, decimal openValue, decimal longValue, decimal shortValue, decimal priceQuoteFactor, decimal basis)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal num = 0m;
			decimal num2 = 0m;
			decimal num3 = 0m;
			decimal num4 = 0m;
			decimal d = 0m;
			decimal d2 = 0m;
			try
			{
				if (accVolume > 0L)
				{
					decimal num5 = Math.Round(accValue / accVolume, 2);
					accValue *= priceQuoteFactor;
					if (openVolume > 0L)
					{
						num = Math.Round(openValue / openVolume, 2);
						num4 = openVolume / accVolume * 100m;
					}
					if (longVolume > 0L)
					{
						num2 = Math.Round(longValue / longVolume, 2);
						d = longVolume / accVolume * 100m;
					}
					if (shortVolume > 0L)
					{
						num3 = Math.Round(shortValue / shortVolume, 2);
						d2 = 100m - d - num4;
					}
				}
				this.UpdateMainBoardValue(deals, accVolume, accValue);
				this.intzaInfoTFEX.Item("open_vol").Text = openVolume.ToString();
				this.intzaInfoTFEX.Item("long_vol").Text = longVolume.ToString();
				this.intzaInfoTFEX.Item("short_vol").Text = shortVolume.ToString();
				this.intzaInfoTFEX.Item("open_vol").FontColor = MyColor.OpenColor;
				this.intzaInfoTFEX.Item("long_vol").FontColor = MyColor.BuyColor;
				this.intzaInfoTFEX.Item("short_vol").FontColor = MyColor.SellColor;
				this.intzaInfoTFEX.Item("open_avg").Text = Utilities.PriceFormat(num, this._seriesInfoTFEX.NumOfDec);
				this.intzaInfoTFEX.Item("open_avg").FontColor = Utilities.ComparePriceCFColor(num, this._seriesInfoTFEX);
				this.intzaInfoTFEX.Item("long_avg").Text = Utilities.PriceFormat(num2, this._seriesInfoTFEX.NumOfDec);
				this.intzaInfoTFEX.Item("long_avg").FontColor = Utilities.ComparePriceCFColor(num2, this._seriesInfoTFEX);
				this.intzaInfoTFEX.Item("short_avg").Text = Utilities.PriceFormat(num3, this._seriesInfoTFEX.NumOfDec);
				this.intzaInfoTFEX.Item("short_avg").FontColor = Utilities.ComparePriceCFColor(num3, this._seriesInfoTFEX);
				this.intzaInfoTFEX.Item("turnover").Text = accVolume.ToString();
				this.intzaInfoTFEX.Item("basis").Text = basis.ToString();
				this.intzaInfoTFEX.Item("basis").FontColor = Utilities.ComparePriceColor(basis, 0m);
				if (num4 + d + d2 > 0m)
				{
					this.intzaInfoTFEX.Item("pie").Text = string.Concat(new string[]
					{
						num4.ToString("0.00"),
						";",
						d.ToString("0.00"),
						";",
						d2.ToString("0.00")
					});
				}
				else
				{
					this.intzaInfoTFEX.Item("pie").Text = "0;0;0";
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateAllVolumeTFEX", ex);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0008E674 File Offset: 0x0008CA74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateTickerInfo_TFEX(decimal price, string side, long volume, string lastUpdate, int index)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaLS.InvokeRequired)
			{
				this.intzaLS.Invoke(new frmStockSummary.UpdateTickerTFEXInfoCallBack(this.UpdateTickerInfo_TFEX), new object[]
				{
					price,
					side,
					volume,
					lastUpdate,
					index
				});
			}
			else
			{
				try
				{
					RecordItem recordItem;
					if (index == -1)
					{
						recordItem = this.intzaLS.AddRecord(1, true);
					}
					else
					{
						recordItem = this.intzaLS.Records(index);
					}
					recordItem.Fields("side").Text = side.ToString();
					recordItem.Fields("volume").Text = volume.ToString();
					recordItem.Fields("price").Text = Utilities.PriceFormat(price, this._seriesInfoTFEX.NumOfDec);
					recordItem.Fields("time").Text = Utilities.GetTime(lastUpdate);
					Color fontColor = Utilities.ComparePriceCFColor(price, this._seriesInfoTFEX);
					recordItem.Fields("price").FontColor = fontColor;
					recordItem.Fields("side").FontColor = fontColor;
					recordItem.Fields("volume").FontColor = fontColor;
					recordItem.Fields("time").FontColor = Color.LightGray;
					recordItem.Changed = true;
					if (side == "B")
					{
						recordItem.Fields("side").FontColor = MyColor.BuyColor;
						recordItem.Fields("volume").FontColor = MyColor.BuyColor;
					}
					else if (side == "S")
					{
						recordItem.Fields("side").FontColor = MyColor.SellColor;
						recordItem.Fields("volume").FontColor = MyColor.SellColor;
					}
					else
					{
						recordItem.Fields("side").FontColor = MyColor.UnChgColor;
						recordItem.Fields("volume").FontColor = MyColor.UnChgColor;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateTickerInfo_TFEX", ex);
				}
			}
		}

		// Token: 0x0400043F RID: 1087
		private IContainer components;

		// Token: 0x04000440 RID: 1088
		private ToolStrip tStripMenu;

		// Token: 0x04000441 RID: 1089
		private ToolStripLabel tslblStockInPlayStock;

		// Token: 0x04000442 RID: 1090
		private ToolStripComboBox tscbStock;

		// Token: 0x04000443 RID: 1091
		private ToolStripButton tsbtnStockInPlayPrevPage;

		// Token: 0x04000444 RID: 1092
		private ToolStripButton tsbtnStockInPlayNextPage;

		// Token: 0x04000445 RID: 1093
		private IntzaCustomGrid intzaViewOddLotInfo;

		// Token: 0x04000446 RID: 1094
		private ToolStripLabel tslbHour;

		// Token: 0x04000447 RID: 1095
		private ToolStripTextBox tstxtSaleByTimeSearchTimeHour;

		// Token: 0x04000448 RID: 1096
		private ToolStripLabel tslbMinute;

		// Token: 0x04000449 RID: 1097
		private ToolStripTextBox tstxtSaleByTimeSearchTimeMinute;

		// Token: 0x0400044A RID: 1098
		private ToolStripButton tsbtnSaleByTimeClearTime2;

		// Token: 0x0400044B RID: 1099
		private ToolStripSeparator tssepSaleByTime2;

		// Token: 0x0400044C RID: 1100
		private ToolStripButton tsbtnSaleByTimeFirstPage;

		// Token: 0x0400044D RID: 1101
		private ToolStripButton tsbtnSaleByTimePrevPage;

		// Token: 0x0400044E RID: 1102
		private ToolStripLabel tslblSaleByTimePageNo;

		// Token: 0x0400044F RID: 1103
		private ToolStripButton tsbtnSaleByTimeNextPage;

		// Token: 0x04000450 RID: 1104
		private ToolStripComboBox tscbSelection;

		// Token: 0x04000451 RID: 1105
		private ToolStripLabel toolStripLabel1;

		// Token: 0x04000452 RID: 1106
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000453 RID: 1107
		private SortGrid intzaStockInPlay;

		// Token: 0x04000454 RID: 1108
		private SortGrid intzaViewOddLot;

		// Token: 0x04000455 RID: 1109
		private SortGrid intzaSaleByPrice;

		// Token: 0x04000456 RID: 1110
		private SortGrid intzaSaleByTime;

		// Token: 0x04000457 RID: 1111
		private SortGrid intzaLS;

		// Token: 0x04000458 RID: 1112
		private SortGrid intzaVolumeByBoard;

		// Token: 0x04000459 RID: 1113
		private IntzaCustomGrid intzaInfo;

		// Token: 0x0400045A RID: 1114
		private IntzaCustomGrid intzaInfoTFEX;

		// Token: 0x0400045B RID: 1115
		private ucVolumeAtPrice wcGraphVolume;

		// Token: 0x0400045C RID: 1116
		private string _currentPage;

		// Token: 0x0400045D RID: 1117
		private StockList.StockInformation _stockInfoSET;

		// Token: 0x0400045E RID: 1118
		private SeriesList.SeriesInformation _seriesInfoTFEX;

		// Token: 0x0400045F RID: 1119
		private int maxTopStockInPlay;

		// Token: 0x04000460 RID: 1120
		private decimal priceAtTopGrid;

		// Token: 0x04000461 RID: 1121
		private decimal priceAtBottomGrid;

		// Token: 0x04000462 RID: 1122
		private int _buyDeals;

		// Token: 0x04000463 RID: 1123
		private int _sellDeals;

		// Token: 0x04000464 RID: 1124
		private BackgroundWorker bgwStockInPlayLoadData;

		// Token: 0x04000465 RID: 1125
		private DataSet _dsStockInPlay;

		// Token: 0x04000466 RID: 1126
		private BackgroundWorker bgwSaleByPriceLoadData;

		// Token: 0x04000467 RID: 1127
		private DataSet dsSaleByPrice;

		// Token: 0x04000468 RID: 1128
		private int _saleByTimePageNo;

		// Token: 0x04000469 RID: 1129
		private BackgroundWorker bgwSaleByTimeLoadData;

		// Token: 0x0400046A RID: 1130
		private DataSet _dsSaleByTime;

		// Token: 0x0400046B RID: 1131
		private BackgroundWorker bgwViewOddLotLoadData;

		// Token: 0x0400046C RID: 1132
		private DataSet _dsViewOddLot;

		// Token: 0x0400046D RID: 1133
		private string _currentSymbol;

		// Token: 0x0400046E RID: 1134
		private bool _isNewStock;

		// Token: 0x0400046F RID: 1135
		private decimal _tfexBidPrice1;

		// Token: 0x04000470 RID: 1136
		private decimal _tfexBidPrice2;

		// Token: 0x04000471 RID: 1137
		private decimal _tfexBidPrice3;

		// Token: 0x04000472 RID: 1138
		private decimal _tfexBidPrice4;

		// Token: 0x04000473 RID: 1139
		private decimal _tfexBidPrice5;

		// Token: 0x04000474 RID: 1140
		private decimal _tfexAskPrice1;

		// Token: 0x04000475 RID: 1141
		private decimal _tfexAskPrice2;

		// Token: 0x04000476 RID: 1142
		private decimal _tfexAskPrice3;

		// Token: 0x04000477 RID: 1143
		private decimal _tfexAskPrice4;

		// Token: 0x04000478 RID: 1144
		private decimal _tfexAskPrice5;

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000763 RID: 1891
		private delegate void ReloadDataPageCallBack(string page, bool isForce);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000767 RID: 1895
		private delegate void UpdateLastSaleTicker_TFEXCallBack(decimal price, string side, long volume, string lastUpdate, int index, SeriesList.SeriesInformation seriesInfo);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x0600076B RID: 1899
		private delegate bool SaleByPriceUpdateBuySellCallBack(decimal price, string side, int sideDeals, long sideVolume, bool isUpdate);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x0600076F RID: 1903
		private delegate void UpdatePriceInfoCallBack(decimal lastPrice, decimal high, decimal low);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000773 RID: 1907
		private delegate void UpdateOpenOrProjectOpenPriceCallBack(string state, int session, decimal price);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000777 RID: 1911
		private delegate void UpdateProjectedVolumeCallBack(long volume);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600077B RID: 1915
		private delegate void UpdateProjectedClosePriceCallBack(decimal closePrice);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x0600077F RID: 1919
		private delegate void UpdateAllVolumeCallBack(int deals, long accVolume, decimal accValue, long openVolume, long buyVolume, long sellVolume);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000783 RID: 1923
		private delegate void UpdateLastSaleTickerInfoCallBack(decimal price, string side, long volume, string lastUpdate, int index);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000787 RID: 1927
		private delegate void UpdateFromSSCallBack(StockList.StockInformation realtimeStockInfo);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x0600078B RID: 1931
		private delegate void UpdateMainBoardValueCallBack(int deals, long accVolume, decimal accValue);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x0600078F RID: 1935
		private delegate void UpdateBigLotValueCallBack(int bDeal, decimal bValue, long bVolume);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000793 RID: 1939
		private delegate void UpdateTickerTFEXInfoCallBack(decimal price, string side, long volume, string lastUpdate, int index);
	}
}
