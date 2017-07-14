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
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus.FixForm
{
	// Token: 0x0200002D RID: 45
	public class frmTopBBOs : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00019AA0 File Offset: 0x00017EA0
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

		// Token: 0x060001A1 RID: 417 RVA: 0x00019AF0 File Offset: 0x00017EF0
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
			this.panelMain = new Panel();
			this.ucBids8 = new ucBids();
			this.ucBids7 = new ucBids();
			this.ucBids6 = new ucBids();
			this.ucBids5 = new ucBids();
			this.ucBids4 = new ucBids();
			this.ucBids3 = new ucBids();
			this.ucBids2 = new ucBids();
			this.ucBids1 = new ucBids();
			this.tStripMenu = new ToolStrip();
			this.toolStripLabel10 = new ToolStripLabel();
			this.tscbSelection = new ToolStripComboBox();
			this.tsbtnAdd = new ToolStripButton();
			this.tsbtnDel = new ToolStripButton();
			this.scrollbar1 = new Scrollbar();
			this.speedTableGrid1 = new SortGrid();
			this.speedTableGrid2 = new SortGrid();
			this.speedTableGrid3 = new SortGrid();
			this.speedTableGrid4 = new SortGrid();
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
			this.panelMain.SuspendLayout();
			this.tStripMenu.SuspendLayout();
			this.contextLink.SuspendLayout();
			base.SuspendLayout();
			this.panelMain.BackColor = Color.FromArgb(20, 20, 20);
			this.panelMain.Controls.Add(this.ucBids8);
			this.panelMain.Controls.Add(this.ucBids7);
			this.panelMain.Controls.Add(this.ucBids6);
			this.panelMain.Controls.Add(this.ucBids5);
			this.panelMain.Controls.Add(this.ucBids4);
			this.panelMain.Controls.Add(this.ucBids3);
			this.panelMain.Controls.Add(this.ucBids2);
			this.panelMain.Controls.Add(this.ucBids1);
			this.panelMain.Location = new Point(0, 67);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new Size(818, 418);
			this.panelMain.TabIndex = 70;
			this.ucBids8.BackColor = Color.FromArgb(20, 20, 20);
			this.ucBids8.CurrStockNo = 0;
			this.ucBids8.IsLoadingData = false;
			this.ucBids8.Location = new Point(374, 260);
			this.ucBids8.Name = "ucBids8";
			this.ucBids8.Size = new Size(444, 154);
			this.ucBids8.TabIndex = 85;
			this.ucBids8.OnNewStock += new ucBids.OnNewStockEventHandler(this.ucBids1_OnNewStock);
			this.ucBids8.OnLink += new ucBids.OnLinkEventHandler(this.ucBids_OnLink);
			this.ucBids8.Leave += new EventHandler(this.ucBids_Leave);
			this.ucBids8.Enter += new EventHandler(this.ucBids_Enter);
			this.ucBids7.BackColor = Color.FromArgb(20, 20, 20);
			this.ucBids7.CurrStockNo = 0;
			this.ucBids7.IsLoadingData = false;
			this.ucBids7.Location = new Point(371, 182);
			this.ucBids7.Name = "ucBids7";
			this.ucBids7.Size = new Size(444, 154);
			this.ucBids7.TabIndex = 84;
			this.ucBids7.OnNewStock += new ucBids.OnNewStockEventHandler(this.ucBids1_OnNewStock);
			this.ucBids7.OnLink += new ucBids.OnLinkEventHandler(this.ucBids_OnLink);
			this.ucBids7.Leave += new EventHandler(this.ucBids_Leave);
			this.ucBids7.Enter += new EventHandler(this.ucBids_Enter);
			this.ucBids6.BackColor = Color.FromArgb(20, 20, 20);
			this.ucBids6.CurrStockNo = 0;
			this.ucBids6.IsLoadingData = false;
			this.ucBids6.Location = new Point(374, 84);
			this.ucBids6.Name = "ucBids6";
			this.ucBids6.Size = new Size(444, 154);
			this.ucBids6.TabIndex = 83;
			this.ucBids6.OnNewStock += new ucBids.OnNewStockEventHandler(this.ucBids1_OnNewStock);
			this.ucBids6.OnLink += new ucBids.OnLinkEventHandler(this.ucBids_OnLink);
			this.ucBids6.Leave += new EventHandler(this.ucBids_Leave);
			this.ucBids6.Enter += new EventHandler(this.ucBids_Enter);
			this.ucBids5.BackColor = Color.FromArgb(20, 20, 20);
			this.ucBids5.CurrStockNo = 0;
			this.ucBids5.IsLoadingData = false;
			this.ucBids5.Location = new Point(377, 3);
			this.ucBids5.Name = "ucBids5";
			this.ucBids5.Size = new Size(444, 154);
			this.ucBids5.TabIndex = 82;
			this.ucBids5.OnNewStock += new ucBids.OnNewStockEventHandler(this.ucBids1_OnNewStock);
			this.ucBids5.OnLink += new ucBids.OnLinkEventHandler(this.ucBids_OnLink);
			this.ucBids5.Leave += new EventHandler(this.ucBids_Leave);
			this.ucBids5.Enter += new EventHandler(this.ucBids_Enter);
			this.ucBids4.BackColor = Color.FromArgb(20, 20, 20);
			this.ucBids4.CurrStockNo = 0;
			this.ucBids4.IsLoadingData = false;
			this.ucBids4.Location = new Point(3, 260);
			this.ucBids4.Name = "ucBids4";
			this.ucBids4.Size = new Size(444, 154);
			this.ucBids4.TabIndex = 81;
			this.ucBids4.OnNewStock += new ucBids.OnNewStockEventHandler(this.ucBids1_OnNewStock);
			this.ucBids4.OnLink += new ucBids.OnLinkEventHandler(this.ucBids_OnLink);
			this.ucBids4.Leave += new EventHandler(this.ucBids_Leave);
			this.ucBids4.Enter += new EventHandler(this.ucBids_Enter);
			this.ucBids3.BackColor = Color.FromArgb(20, 20, 20);
			this.ucBids3.CurrStockNo = 0;
			this.ucBids3.IsLoadingData = false;
			this.ucBids3.Location = new Point(-4, 200);
			this.ucBids3.Name = "ucBids3";
			this.ucBids3.Size = new Size(444, 154);
			this.ucBids3.TabIndex = 80;
			this.ucBids3.OnNewStock += new ucBids.OnNewStockEventHandler(this.ucBids1_OnNewStock);
			this.ucBids3.OnLink += new ucBids.OnLinkEventHandler(this.ucBids_OnLink);
			this.ucBids3.Leave += new EventHandler(this.ucBids_Leave);
			this.ucBids3.Enter += new EventHandler(this.ucBids_Enter);
			this.ucBids2.BackColor = Color.FromArgb(20, 20, 20);
			this.ucBids2.CurrStockNo = 0;
			this.ucBids2.IsLoadingData = false;
			this.ucBids2.Location = new Point(0, 112);
			this.ucBids2.Name = "ucBids2";
			this.ucBids2.Size = new Size(444, 154);
			this.ucBids2.TabIndex = 79;
			this.ucBids2.OnNewStock += new ucBids.OnNewStockEventHandler(this.ucBids1_OnNewStock);
			this.ucBids2.OnLink += new ucBids.OnLinkEventHandler(this.ucBids_OnLink);
			this.ucBids2.Leave += new EventHandler(this.ucBids_Leave);
			this.ucBids2.Enter += new EventHandler(this.ucBids_Enter);
			this.ucBids1.BackColor = Color.FromArgb(20, 20, 20);
			this.ucBids1.CurrStockNo = 0;
			this.ucBids1.IsLoadingData = false;
			this.ucBids1.Location = new Point(0, 3);
			this.ucBids1.Name = "ucBids1";
			this.ucBids1.Size = new Size(444, 154);
			this.ucBids1.TabIndex = 78;
			this.ucBids1.OnNewStock += new ucBids.OnNewStockEventHandler(this.ucBids1_OnNewStock);
			this.ucBids1.OnLink += new ucBids.OnLinkEventHandler(this.ucBids_OnLink);
			this.ucBids1.Leave += new EventHandler(this.ucBids_Leave);
			this.ucBids1.Enter += new EventHandler(this.ucBids_Enter);
			this.tStripMenu.AllowMerge = false;
			this.tStripMenu.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripMenu.GripMargin = new Padding(0);
			this.tStripMenu.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripLabel10,
				this.tscbSelection,
				this.tsbtnAdd,
				this.tsbtnDel
			});
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Padding = new Padding(1, 1, 1, 2);
			this.tStripMenu.RenderMode = ToolStripRenderMode.System;
			this.tStripMenu.Size = new Size(1121, 26);
			this.tStripMenu.TabIndex = 77;
			this.toolStripLabel10.ForeColor = Color.LightGray;
			this.toolStripLabel10.Margin = new Padding(2, 1, 2, 2);
			this.toolStripLabel10.Name = "toolStripLabel10";
			this.toolStripLabel10.Size = new Size(61, 20);
			this.toolStripLabel10.Text = "Selection :";
			this.tscbSelection.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbSelection.ForeColor = Color.LightGray;
			this.tscbSelection.Items.AddRange(new object[]
			{
				"Favorites-1",
				"Favorites-2",
				"Favorites-3",
				"Favorites-4",
				"Favorites-5"
			});
			this.tscbSelection.Name = "tscbSelection";
			this.tscbSelection.Size = new Size(120, 23);
			this.tscbSelection.SelectedIndexChanged += new EventHandler(this.tscbSelection_SelectedIndexChanged);
			this.tsbtnAdd.ForeColor = Color.LightGray;
			this.tsbtnAdd.Image = Resources.Plus;
			this.tsbtnAdd.ImageTransparentColor = Color.Magenta;
			this.tsbtnAdd.Margin = new Padding(10, 1, 0, 2);
			this.tsbtnAdd.Name = "tsbtnAdd";
			this.tsbtnAdd.Size = new Size(49, 20);
			this.tsbtnAdd.Text = "Add";
			this.tsbtnAdd.Click += new EventHandler(this.tsbtnAdd_Click);
			this.tsbtnDel.ForeColor = Color.LightGray;
			this.tsbtnDel.Image = Resources.Minus;
			this.tsbtnDel.ImageTransparentColor = Color.Magenta;
			this.tsbtnDel.Name = "tsbtnDel";
			this.tsbtnDel.Size = new Size(60, 20);
			this.tsbtnDel.Text = "Delete";
			this.tsbtnDel.Click += new EventHandler(this.tsbtnDel_Click);
			this.scrollbar1.BackColor = Color.FromArgb(20, 20, 20);
			this.scrollbar1.ChannelColor = Color.FromArgb(80, 80, 80);
			this.scrollbar1.Cursor = Cursors.Hand;
			this.scrollbar1.HeaderHeight = 0f;
			this.scrollbar1.LargeChange = 10;
			this.scrollbar1.Location = new Point(896, 29);
			this.scrollbar1.Maximum = 100;
			this.scrollbar1.MinimumSize = new Size(10, 47);
			this.scrollbar1.Name = "scrollbar1";
			this.scrollbar1.Size = new Size(10, 375);
			this.scrollbar1.TabIndex = 71;
			this.scrollbar1.Value = 0;
			this.scrollbar1.ValueChanged += new EventHandler(this.scrollbar1_ValueChanged);
			this.speedTableGrid1.AllowDrop = true;
			this.speedTableGrid1.BackColor = Color.Black;
			this.speedTableGrid1.CanBlink = true;
			this.speedTableGrid1.CanDrag = false;
			this.speedTableGrid1.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Far;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "bidvolume";
			columnItem.Text = "Volume";
			columnItem.ValueFormat = FormatType.Volume;
			columnItem.Visible = true;
			columnItem.Width = 30;
			columnItem2.Alignment = StringAlignment.Near;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "bid";
			columnItem2.Text = "Bid";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 20;
			columnItem3.Alignment = StringAlignment.Near;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "offer";
			columnItem3.Text = "Offer";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 20;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "offervolume";
			columnItem4.Text = "Volume";
			columnItem4.ValueFormat = FormatType.Volume;
			columnItem4.Visible = true;
			columnItem4.Width = 30;
			this.speedTableGrid1.Columns.Add(columnItem);
			this.speedTableGrid1.Columns.Add(columnItem2);
			this.speedTableGrid1.Columns.Add(columnItem3);
			this.speedTableGrid1.Columns.Add(columnItem4);
			this.speedTableGrid1.CurrentScroll = 0;
			this.speedTableGrid1.FocusItemIndex = -1;
			this.speedTableGrid1.ForeColor = Color.Black;
			this.speedTableGrid1.GridColor = Color.FromArgb(45, 45, 45);
			this.speedTableGrid1.HeaderPctHeight = 80f;
			this.speedTableGrid1.IsAutoRepaint = false;
			this.speedTableGrid1.IsDrawFullRow = false;
			this.speedTableGrid1.IsDrawGrid = true;
			this.speedTableGrid1.IsDrawHeader = true;
			this.speedTableGrid1.IsScrollable = false;
			this.speedTableGrid1.Location = new Point(0, 23);
			this.speedTableGrid1.MainColumn = "";
			this.speedTableGrid1.Margin = new Padding(1);
			this.speedTableGrid1.Name = "speedTableGrid1";
			this.speedTableGrid1.Rows = 5;
			this.speedTableGrid1.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.speedTableGrid1.RowSelectType = 0;
			this.speedTableGrid1.RowsVisible = 5;
			this.speedTableGrid1.Size = new Size(220, 45);
			this.speedTableGrid1.SortColumnName = "";
			this.speedTableGrid1.SortType = SortType.Desc;
			this.speedTableGrid1.TabIndex = 66;
			this.speedTableGrid2.AllowDrop = true;
			this.speedTableGrid2.BackColor = Color.Black;
			this.speedTableGrid2.CanBlink = true;
			this.speedTableGrid2.CanDrag = false;
			this.speedTableGrid2.CanGetMouseMove = false;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "volume";
			columnItem5.Text = "Volume";
			columnItem5.ValueFormat = FormatType.Volume;
			columnItem5.Visible = true;
			columnItem5.Width = 40;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "price";
			columnItem6.Text = "Price";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 27;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "time";
			columnItem7.Text = "Time";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 33;
			this.speedTableGrid2.Columns.Add(columnItem5);
			this.speedTableGrid2.Columns.Add(columnItem6);
			this.speedTableGrid2.Columns.Add(columnItem7);
			this.speedTableGrid2.CurrentScroll = 0;
			this.speedTableGrid2.FocusItemIndex = -1;
			this.speedTableGrid2.ForeColor = Color.Black;
			this.speedTableGrid2.GridColor = Color.FromArgb(45, 45, 45);
			this.speedTableGrid2.HeaderPctHeight = 80f;
			this.speedTableGrid2.IsAutoRepaint = false;
			this.speedTableGrid2.IsDrawFullRow = true;
			this.speedTableGrid2.IsDrawGrid = false;
			this.speedTableGrid2.IsDrawHeader = true;
			this.speedTableGrid2.IsScrollable = false;
			this.speedTableGrid2.Location = new Point(232, 21);
			this.speedTableGrid2.MainColumn = "";
			this.speedTableGrid2.Margin = new Padding(1);
			this.speedTableGrid2.Name = "speedTableGrid2";
			this.speedTableGrid2.Rows = 5;
			this.speedTableGrid2.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.speedTableGrid2.RowSelectType = 0;
			this.speedTableGrid2.RowsVisible = 5;
			this.speedTableGrid2.Size = new Size(156, 38);
			this.speedTableGrid2.SortColumnName = "";
			this.speedTableGrid2.SortType = SortType.Desc;
			this.speedTableGrid2.TabIndex = 65;
			this.speedTableGrid3.AllowDrop = true;
			this.speedTableGrid3.BackColor = Color.Black;
			this.speedTableGrid3.CanBlink = true;
			this.speedTableGrid3.CanDrag = false;
			this.speedTableGrid3.CanGetMouseMove = false;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "bidvolume";
			columnItem8.Text = "Volume";
			columnItem8.ValueFormat = FormatType.Volume;
			columnItem8.Visible = true;
			columnItem8.Width = 30;
			columnItem9.Alignment = StringAlignment.Near;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "bid";
			columnItem9.Text = "Bid";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = true;
			columnItem9.Width = 20;
			columnItem10.Alignment = StringAlignment.Near;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.LightGray;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "offer";
			columnItem10.Text = "Offer";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = true;
			columnItem10.Width = 20;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "offervolume";
			columnItem11.Text = "Volume";
			columnItem11.ValueFormat = FormatType.Volume;
			columnItem11.Visible = true;
			columnItem11.Width = 30;
			this.speedTableGrid3.Columns.Add(columnItem8);
			this.speedTableGrid3.Columns.Add(columnItem9);
			this.speedTableGrid3.Columns.Add(columnItem10);
			this.speedTableGrid3.Columns.Add(columnItem11);
			this.speedTableGrid3.CurrentScroll = 0;
			this.speedTableGrid3.FocusItemIndex = -1;
			this.speedTableGrid3.ForeColor = Color.Black;
			this.speedTableGrid3.GridColor = Color.FromArgb(45, 45, 45);
			this.speedTableGrid3.HeaderPctHeight = 80f;
			this.speedTableGrid3.IsAutoRepaint = false;
			this.speedTableGrid3.IsDrawFullRow = false;
			this.speedTableGrid3.IsDrawGrid = true;
			this.speedTableGrid3.IsDrawHeader = true;
			this.speedTableGrid3.IsScrollable = false;
			this.speedTableGrid3.Location = new Point(0, 23);
			this.speedTableGrid3.MainColumn = "";
			this.speedTableGrid3.Margin = new Padding(1);
			this.speedTableGrid3.Name = "speedTableGrid3";
			this.speedTableGrid3.Rows = 5;
			this.speedTableGrid3.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.speedTableGrid3.RowSelectType = 0;
			this.speedTableGrid3.RowsVisible = 5;
			this.speedTableGrid3.Size = new Size(220, 45);
			this.speedTableGrid3.SortColumnName = "";
			this.speedTableGrid3.SortType = SortType.Desc;
			this.speedTableGrid3.TabIndex = 66;
			this.speedTableGrid4.AllowDrop = true;
			this.speedTableGrid4.BackColor = Color.Black;
			this.speedTableGrid4.CanBlink = true;
			this.speedTableGrid4.CanDrag = false;
			this.speedTableGrid4.CanGetMouseMove = false;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "volume";
			columnItem12.Text = "Volume";
			columnItem12.ValueFormat = FormatType.Volume;
			columnItem12.Visible = true;
			columnItem12.Width = 40;
			columnItem13.Alignment = StringAlignment.Far;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.ColumnAlignment = StringAlignment.Center;
			columnItem13.FontColor = Color.LightGray;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "price";
			columnItem13.Text = "Price";
			columnItem13.ValueFormat = FormatType.Text;
			columnItem13.Visible = true;
			columnItem13.Width = 27;
			columnItem14.Alignment = StringAlignment.Far;
			columnItem14.BackColor = Color.FromArgb(64, 64, 64);
			columnItem14.ColumnAlignment = StringAlignment.Center;
			columnItem14.FontColor = Color.LightGray;
			columnItem14.MyStyle = FontStyle.Regular;
			columnItem14.Name = "time";
			columnItem14.Text = "Time";
			columnItem14.ValueFormat = FormatType.Text;
			columnItem14.Visible = true;
			columnItem14.Width = 33;
			this.speedTableGrid4.Columns.Add(columnItem12);
			this.speedTableGrid4.Columns.Add(columnItem13);
			this.speedTableGrid4.Columns.Add(columnItem14);
			this.speedTableGrid4.CurrentScroll = 0;
			this.speedTableGrid4.FocusItemIndex = -1;
			this.speedTableGrid4.ForeColor = Color.Black;
			this.speedTableGrid4.GridColor = Color.FromArgb(45, 45, 45);
			this.speedTableGrid4.HeaderPctHeight = 80f;
			this.speedTableGrid4.IsAutoRepaint = false;
			this.speedTableGrid4.IsDrawFullRow = true;
			this.speedTableGrid4.IsDrawGrid = false;
			this.speedTableGrid4.IsDrawHeader = true;
			this.speedTableGrid4.IsScrollable = false;
			this.speedTableGrid4.Location = new Point(232, 21);
			this.speedTableGrid4.MainColumn = "";
			this.speedTableGrid4.Margin = new Padding(1);
			this.speedTableGrid4.Name = "speedTableGrid4";
			this.speedTableGrid4.Rows = 5;
			this.speedTableGrid4.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.speedTableGrid4.RowSelectType = 0;
			this.speedTableGrid4.RowsVisible = 5;
			this.speedTableGrid4.Size = new Size(156, 38);
			this.speedTableGrid4.SortColumnName = "";
			this.speedTableGrid4.SortType = SortType.Desc;
			this.speedTableGrid4.TabIndex = 65;
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
			this.BackColor = Color.FromArgb(50, 50, 50);
			base.ClientSize = new Size(1121, 497);
			base.Controls.Add(this.tStripMenu);
			base.Controls.Add(this.scrollbar1);
			base.Controls.Add(this.panelMain);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.Name = "frmTopBBOs";
			this.Text = "Top BBO";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmTopBBOs_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmTopBBOs_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmTopBBOs_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmTopBBOs_IDoCustomSizeChanged);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmTopBBOs_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmTopBBOs_IDoReActivated);
			base.KeyDown += new KeyEventHandler(this.frmTopBBOs_KeyDown);
			base.Controls.SetChildIndex(this.panelMain, 0);
			base.Controls.SetChildIndex(this.scrollbar1, 0);
			base.Controls.SetChildIndex(this.tStripMenu, 0);
			this.panelMain.ResumeLayout(false);
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			this.contextLink.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001BBFC File Offset: 0x00019FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmTopBBOs() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwReloadData = null;
			this.bgwReloadData_TFEX = null;
			this.tdsTOPBBo = null;
			this.tdsTOPBBoTfex = null;
			this._selectionText = string.Empty;
			this._currentActivePanel = 0;
			this._currFavPage = 1;
			this._bidControl = null;
			
			this.InitializeComponent();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001BC70 File Offset: 0x0001A070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmTopBBOs(Dictionary<string, object> propertiesValue) : base(propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwReloadData = null;
			this.bgwReloadData_TFEX = null;
			this.tdsTOPBBo = null;
			this.tdsTOPBBoTfex = null;
			this._selectionText = string.Empty;
			this._currentActivePanel = 0;
			this._currFavPage = 1;
			this._bidControl = null;
			
			this.InitializeComponent();
			try
			{
				this.bgwReloadData = new BackgroundWorker();
				this.bgwReloadData.WorkerReportsProgress = true;
				this.bgwReloadData.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
				this.bgwReloadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
				this.bgwReloadData_TFEX = new BackgroundWorker();
				this.bgwReloadData_TFEX.WorkerReportsProgress = true;
				this.bgwReloadData_TFEX.DoWork += new DoWorkEventHandler(this.bgwReloadData_TFEX_DoWork);
				this.bgwReloadData_TFEX.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_TFEX_RunWorkerCompleted);
			}
			catch (Exception ex)
			{
				this.ShowError("frmTopBBOs.Create", ex);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001BDA4 File Offset: 0x0001A1A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlinkModeTopPrice()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.IsLoadingData = true;
				ucBids[] bidControl = this._bidControl;
				for (int i = 0; i < bidControl.Length; i++)
				{
					ucBids ucBids = bidControl[i];
					ucBids.SetBlinkModeTopPrice();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetBlinkModeTopPrice", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001BE2C File Offset: 0x0001A22C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Dictionary<string, object> DoPackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.PropertiesValue.Clear();
			base.PropertiesValue.Add("SelectionText", this._selectionText);
			return base.PropertiesValue;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001BE78 File Offset: 0x0001A278
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DoUnpackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.PropertiesValue != null)
			{
				if (base.PropertiesValue.ContainsKey("SelectionText"))
				{
					this._selectionText = base.PropertiesValue["SelectionText"].ToString();
				}
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001BEDC File Offset: 0x0001A2DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					if (this.tdsTOPBBo == null)
					{
						this.tdsTOPBBo = new DataSet();
					}
					else
					{
						this.tdsTOPBBo.Clear();
					}
					base.IsLoadingData = true;
					int[] stockNumber = (int[])e.Argument;
					string text = ApplicationInfo.WebService.TopBBO(stockNumber, 5);
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.tdsTOPBBo);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_DoWork", ex);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001BFA4 File Offset: 0x0001A3A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				try
				{
					if (e.Error == null)
					{
						this.UpdateToControl();
						this.tdsTOPBBo.Clear();
					}
				}
				catch (Exception ex)
				{
					this.ShowError("bgwReloadData_RunWorkerCompleted", ex);
				}
				base.IsLoadingData = false;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001C030 File Offset: 0x0001A430
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_TFEX_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					if (this.tdsTOPBBoTfex != null)
					{
						this.tdsTOPBBoTfex.Clear();
					}
					else
					{
						this.tdsTOPBBoTfex = new DataSet();
					}
					base.IsLoadingData = true;
					string[] array = (string[])e.Argument;
					if (array.Length > 0)
					{
						string text = ApplicationInfo.WebServiceTFEX.TopBBOTFEX(array, 5);
						if (!string.IsNullOrEmpty(text))
						{
							MyDataHelper.StringToDataSet(text, this.tdsTOPBBoTfex);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_TFEX_DoWork", ex);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001C104 File Offset: 0x0001A504
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_TFEX_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					this.UpdateToControl_TFEX();
					this.tdsTOPBBoTfex.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_TFEX_RunWorkerCompleted", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001C17C File Offset: 0x0001A57C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetNewStock(string symbol, bool isPropertyChange)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[symbol];
				if (stockInformation.Number > 0)
				{
					ApplicationInfo.CurrentSymbol = stockInformation.Symbol;
					ApplicationInfo.FavStockChanged = true;
					ApplicationInfo.FavStockList[this._currFavPage][this._currentActivePanel - 1] = stockInformation.Symbol;
					this.ReloadData(new int[]
					{
						stockInformation.Number
					});
				}
				else
				{
					ApplicationInfo.CurrentSymbol = symbol;
					ApplicationInfo.FavStockChanged = true;
					ApplicationInfo.FavStockList[this._currFavPage][this._currentActivePanel - 1] = symbol;
					this.ReloadDataTFEX(new string[]
					{
						symbol
					});
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetNewStock", ex);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001C280 File Offset: 0x0001A680
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadData(int[] stockNumber)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwReloadData.IsBusy)
			{
				this.bgwReloadData.RunWorkerAsync(stockNumber);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001C2BC File Offset: 0x0001A6BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadDataTFEX(string[] symbolLst)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.bgwReloadData_TFEX.IsBusy)
			{
				this.bgwReloadData_TFEX.RunWorkerAsync(symbolLst);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001C2F8 File Offset: 0x0001A6F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tdsTOPBBo != null && this.tdsTOPBBo.Tables.Count > 0)
				{
					int stockNumber = 0;
					DataRow dataRow = null;
					StockList.StockInformation stockInformation = null;
					for (int i = 0; i < this.tdsTOPBBo.Tables["security_stat"].Rows.Count; i++)
					{
						if (this.tdsTOPBBo.Tables.Contains("security_stat") && this.tdsTOPBBo.Tables["security_stat"].Rows.Count > 0)
						{
							dataRow = this.tdsTOPBBo.Tables["security_stat"].Rows[i];
							stockNumber = Convert.ToInt32(dataRow["security_number"]);
							stockInformation = ApplicationInfo.StockInfo[stockNumber];
						}
						int num = ApplicationInfo.FavStockList[this._currFavPage].IndexOf(stockInformation.Symbol);
						if (num > -1 && num < 8)
						{
							DataRow[] drTicker = null;
							if (this.tdsTOPBBo.Tables.Contains("last_sale"))
							{
								if (this.tdsTOPBBo.Tables["last_sale"].Columns.Contains("security_number"))
								{
									drTicker = this.tdsTOPBBo.Tables["last_sale"].Select("security_number = '" + stockNumber.ToString() + "'");
								}
								else
								{
									drTicker = this.tdsTOPBBo.Tables["last_sale"].Select("0=0");
								}
							}
							this._bidControl[num].UpdateToControl(dataRow, drTicker);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl", ex);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001C550 File Offset: 0x0001A950
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tdsTOPBBoTfex != null && this.tdsTOPBBoTfex.Tables.Count > 0 && this.tdsTOPBBoTfex.Tables.Contains("info"))
				{
					DataRow dataRow = null;
					string text = string.Empty;
					int num = 0;
					for (int i = 0; i < this.tdsTOPBBoTfex.Tables["info"].Rows.Count; i++)
					{
						if (this.tdsTOPBBoTfex.Tables["info"].Rows.Count > 0)
						{
							dataRow = this.tdsTOPBBoTfex.Tables["info"].Rows[i];
							text = dataRow["sSeries"].ToString().Trim();
							int.TryParse(dataRow["iDecPrice"].ToString(), out num);
						}
						int num2 = ApplicationInfo.FavStockList[this._currFavPage].IndexOf(text);
						if (num2 > -1 && num2 < 8)
						{
							DataRow[] drTicker = null;
							if (this.tdsTOPBBoTfex.Tables.Contains("last_sale"))
							{
								if (this.tdsTOPBBoTfex.Tables["last_sale"].Columns.Contains("sSeries"))
								{
									drTicker = this.tdsTOPBBoTfex.Tables["last_sale"].Select("sSeries = '" + text.Trim() + "'");
								}
								else
								{
									drTicker = this.tdsTOPBBoTfex.Tables["last_sale"].Select("0=0");
								}
							}
							this._bidControl[num2].UpdateToControl_TFEX(dataRow, drTicker);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl_TFEX", ex);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001C7AC File Offset: 0x0001ABAC
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
					string messageType = message.MessageType;
					if (messageType != null)
					{
						if (!(messageType == "TP"))
						{
							if (!(messageType == "L+"))
							{
								if (messageType == "SS")
								{
									int num = ApplicationInfo.FavStockList[this._currFavPage].IndexOf(realtimeStockInfo.Symbol);
									if (num > -1 && num < 8)
									{
										this._bidControl[num].ReceiveMessage(message, realtimeStockInfo);
									}
								}
							}
							else
							{
								int num = ApplicationInfo.FavStockList[this._currFavPage].IndexOf(realtimeStockInfo.Symbol);
								if (num > -1 && num < 8)
								{
									this._bidControl[num].ReceiveMessage(message, realtimeStockInfo);
								}
							}
						}
						else
						{
							int num = ApplicationInfo.FavStockList[this._currFavPage].IndexOf(realtimeStockInfo.Symbol);
							if (num > -1 && num < 8)
							{
								this._bidControl[num].ReceiveMessage(message, realtimeStockInfo);
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SecurityInfo::RecvMessage", ex);
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001C944 File Offset: 0x0001AD44
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
						if (message.MessageType == "TP")
						{
							if (realtimeSeriesInfo.Symbol != "")
							{
								int num = ApplicationInfo.FavStockList[this._currFavPage].IndexOf(realtimeSeriesInfo.Symbol);
								if (num > -1 && num < 8)
								{
									this._bidControl[num].ReceiveTfexMessage(message, realtimeSeriesInfo);
								}
							}
						}
						else if (message.MessageType == "LS")
						{
							if (realtimeSeriesInfo.Symbol != "")
							{
								int num = ApplicationInfo.FavStockList[this._currFavPage].IndexOf(realtimeSeriesInfo.Symbol);
								if (num > -1 && num < 8)
								{
									this._bidControl[num].ReceiveTfexMessage(message, realtimeSeriesInfo);
								}
							}
						}
					}
					catch (Exception ex)
					{
						this.ShowError("SecurityInfo::RecvMessage", ex);
					}
				}
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001CAD0 File Offset: 0x0001AED0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmTopBBOs_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._bidControl = new ucBids[8];
			this._bidControl[0] = this.ucBids1;
			this._bidControl[1] = this.ucBids2;
			this._bidControl[2] = this.ucBids3;
			this._bidControl[3] = this.ucBids4;
			this._bidControl[4] = this.ucBids5;
			this._bidControl[5] = this.ucBids6;
			this._bidControl[6] = this.ucBids7;
			this._bidControl[7] = this.ucBids8;
			this.SetBlinkModeTopPrice();
			this.SetResize(true, false);
			base.Show();
			base.OpenedForm();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001CB88 File Offset: 0x0001AF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmTopBBOs_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._selectionText == string.Empty)
				{
					this._selectionText = this.tscbSelection.Items[0].ToString();
				}
				this.setFavPage(this._selectionText);
			}
			catch (Exception ex)
			{
				this.ShowError("frmTopBBOs_IDoLoadData", ex);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0001CC14 File Offset: 0x0001B014
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetResize(bool isWidthChanged, bool isHeightChanged)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (isWidthChanged || isHeightChanged)
				{
					int num = base.ClientSize.Width - this.scrollbar1.Width;
					int num2 = num / 2;
					this.ucBids1.SetResize();
					this.ucBids2.SetResize();
					this.ucBids3.SetResize();
					this.ucBids4.SetResize();
					this.ucBids5.SetResize();
					this.ucBids6.SetResize();
					this.ucBids7.SetResize();
					this.ucBids8.SetResize();
					this.ucBids1.SetBounds(0, 3, num2 - 1, this.ucBids1.Height);
					this.ucBids2.SetBounds(this.ucBids1.Left, this.ucBids1.Bottom + 3, this.ucBids1.Width, this.ucBids1.Height);
					this.ucBids3.SetBounds(this.ucBids1.Left, this.ucBids2.Bottom + 3, this.ucBids1.Width, this.ucBids1.Height);
					this.ucBids4.SetBounds(this.ucBids1.Left, this.ucBids3.Bottom + 3, this.ucBids1.Width, this.ucBids1.Height);
					this.ucBids5.SetBounds(this.ucBids1.Right + 2, this.ucBids1.Top, this.ucBids1.Width, this.ucBids1.Height);
					this.ucBids6.SetBounds(this.ucBids5.Left, this.ucBids2.Top, this.ucBids1.Width, this.ucBids1.Height);
					this.ucBids7.SetBounds(this.ucBids5.Left, this.ucBids3.Top, this.ucBids1.Width, this.ucBids1.Height);
					this.ucBids8.SetBounds(this.ucBids5.Left, this.ucBids4.Top, this.ucBids1.Width, this.ucBids1.Height);
					int num3 = this.ucBids8.Bottom + 3;
					int height = (base.Height > num3) ? base.Height : num3;
					this.panelMain.SetBounds(0, this.tStripMenu.Top + this.tStripMenu.Height, num, height);
					this.scrollbar1.SetBounds(this.panelMain.Left + this.panelMain.Width, this.panelMain.Top, this.scrollbar1.Width, base.ClientSize.Height - this.panelMain.Top);
					this.scrollbar1.Maximum = num3;
					this.scrollbar1.LargeChange = base.Height - this.panelMain.Top;
					this.scrollbar1.Value = 0;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001CF8C File Offset: 0x0001B38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmTopBBOs_IDoCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged, this.IsHeightChanged);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001CFC8 File Offset: 0x0001B3C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmTopBBOs_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Space)
			{
				this.SetTextPosition(this._currentActivePanel);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001D00C File Offset: 0x0001B40C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmTopBBOs_IDoFontChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				base.SuspendLayout();
				this.SetResize(true, true);
				base.ResumeLayout();
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001D050 File Offset: 0x0001B450
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmTopBBOs_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(this.IsWidthChanged, this.IsHeightChanged);
				base.Show();
				if (ApplicationInfo.FavStockChanged || ApplicationInfo.IsResumeState)
				{
					this.setFavPage(this._selectionText);
				}
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001D0C4 File Offset: 0x0001B4C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmTopBBOs_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			switch (e.KeyCode)
			{
			case Keys.Left:
				if (this._currentActivePanel - 4 > 0)
				{
					this.SetTextPosition(this._currentActivePanel - 4);
				}
				else
				{
					this.SetTextPosition(this._currentActivePanel + 4);
				}
				e.SuppressKeyPress = true;
				break;
			case Keys.Up:
				this.SetTextPosition(this._currentActivePanel - 1);
				e.SuppressKeyPress = true;
				break;
			case Keys.Right:
				if (this._currentActivePanel + 4 > 8)
				{
					this.SetTextPosition(this._currentActivePanel - 4);
				}
				else
				{
					this.SetTextPosition(this._currentActivePanel + 4);
				}
				e.SuppressKeyPress = true;
				break;
			case Keys.Down:
				this.SetTextPosition(this._currentActivePanel + 1);
				e.SuppressKeyPress = true;
				break;
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001D1C8 File Offset: 0x0001B5C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTextPosition(int toCurrentBox)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (toCurrentBox > 8 || toCurrentBox == 0)
				{
					toCurrentBox = 1;
				}
				else if (toCurrentBox < 1)
				{
					toCurrentBox = 8;
				}
				if (this._bidControl[toCurrentBox - 1].Top + this.ucBids1.Height > base.Height + this.scrollbar1.Value)
				{
					this.scrollbar1.Value = this._bidControl[toCurrentBox - 1].Top + this.ucBids1.Height - (base.Height - this.tStripMenu.Height);
				}
				else if (this._bidControl[toCurrentBox - 1].Top < this.scrollbar1.Value)
				{
					this.scrollbar1.Value = this._bidControl[toCurrentBox - 1].Top;
				}
				this._bidControl[toCurrentBox - 1].SetTextPosition();
			}
			catch (Exception ex)
			{
				this.ShowError("SetTextPosition", ex);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001D31C File Offset: 0x0001B71C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void scrollbar1_ValueChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.panelMain.Top = -this.scrollbar1.Value + this.tStripMenu.Top + this.tStripMenu.Height;
			}
			catch (Exception ex)
			{
				this.ShowError("scrollbar1_ValueChanged", ex);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001D398 File Offset: 0x0001B798
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbSelection_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.setFavPage(this.tscbSelection.Text);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001D3D8 File Offset: 0x0001B7D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setFavPage(string selectionText)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tscbSelection.Items.IndexOf(selectionText) > -1)
				{
					base.IsLoadingData = true;
					this._selectionText = selectionText;
					this.tscbSelection.Text = selectionText;
					this._currFavPage = this.tscbSelection.Items.IndexOf(selectionText) + 1;
					for (int i = 1; i <= 8; i++)
					{
						this._bidControl[i - 1].ClearControl(true);
					}
					ApplicationInfo.FavStockChanged = false;
					string empty = string.Empty;
					string empty2 = string.Empty;
					ApplicationInfo.GetFavListByPage(this._currFavPage, 8, false, ref empty, ref empty2);
					if (empty.Length > 0)
					{
						string[] array = empty.Split(new char[]
						{
							','
						});
						if (array.Length > 0)
						{
							int[] array2 = new int[array.Length];
							for (int j = 0; j < array.Length; j++)
							{
								array2[j] = Convert.ToInt32(array[j]);
							}
							this.ReloadData(array2);
						}
					}
					else
					{
						base.IsLoadingData = false;
					}
					if (empty2.Length > 0)
					{
						string[] array3 = empty2.Split(new char[]
						{
							','
						});
						if (array3.Length > 0)
						{
							this.ReloadDataTFEX(array3);
						}
					}
					else
					{
						base.IsLoadingData = false;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tscbSelection_SelectedIndexChanged", ex);
				base.IsLoadingData = false;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001D5CC File Offset: 0x0001B9CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnAdd_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetTextPosition(this._currentActivePanel + 1);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001D5EC File Offset: 0x0001B9EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnDel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ClearStock();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001D604 File Offset: 0x0001BA04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearStock()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currentActivePanel > 0 && this._currentActivePanel <= 8)
				{
					int num = (this._currFavPage - 1) * ApplicationInfo.FavStockPerPage + this._currentActivePanel - 1;
					ApplicationInfo.FavStockChanged = true;
					ApplicationInfo.FavStockList[this._currFavPage][this._currentActivePanel - 1] = string.Empty;
					this._bidControl[this._currentActivePanel - 1].ClearControl(true);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnDel_Click", ex);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001D6C8 File Offset: 0x0001BAC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tStripMenu_Paint(object sender, PaintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.ClipRectangle.Width == this.tStripMenu.Width)
			{
				e.Graphics.DrawLine(Pens.Gray, 0, e.ClipRectangle.Height - 1, e.ClipRectangle.Width, e.ClipRectangle.Height - 1);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001D74C File Offset: 0x0001BB4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucBids1_OnNewStock(object sender, string stock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currentActivePanel > 0)
				{
					if (!string.IsNullOrEmpty(stock))
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stock];
						if (stockInformation.Number > 0)
						{
							if (ApplicationInfo.FavStockList[this._currFavPage].IndexOf(stockInformation.Symbol) == -1)
							{
								this.SetNewStock(stockInformation.Symbol, true);
							}
							else
							{
								((ucBids)sender).ResetToCurrentStock();
							}
						}
						else
						{
							SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[stock];
							if (seriesInformation.Symbol != string.Empty)
							{
								if (ApplicationInfo.FavStockList[this._currFavPage].IndexOf(seriesInformation.Symbol) == -1)
								{
									this.SetNewStock(seriesInformation.Symbol, true);
								}
								else
								{
									((ucBids)sender).ResetToCurrentStock();
								}
							}
						}
					}
					else
					{
						this.ClearStock();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("txtStock_KeyDown", ex);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001D8B8 File Offset: 0x0001BCB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucBids_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender == this.ucBids1)
			{
				this._currentActivePanel = 1;
			}
			else if (sender == this.ucBids2)
			{
				this._currentActivePanel = 2;
			}
			else if (sender == this.ucBids3)
			{
				this._currentActivePanel = 3;
			}
			else if (sender == this.ucBids4)
			{
				this._currentActivePanel = 4;
			}
			else if (sender == this.ucBids5)
			{
				this._currentActivePanel = 5;
			}
			else if (sender == this.ucBids6)
			{
				this._currentActivePanel = 6;
			}
			else if (sender == this.ucBids7)
			{
				this._currentActivePanel = 7;
			}
			else if (sender == this.ucBids8)
			{
				this._currentActivePanel = 8;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001D9C8 File Offset: 0x0001BDC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucBids_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currentActivePanel > 0)
				{
					this._bidControl[this._currentActivePanel - 1].HideTextBox();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ucBids_Leave", ex);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001DA3C File Offset: 0x0001BE3C
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

		// Token: 0x060001C6 RID: 454 RVA: 0x0001DAD0 File Offset: 0x0001BED0
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

		// Token: 0x060001C7 RID: 455 RVA: 0x0001DBAC File Offset: 0x0001BFAC
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

		// Token: 0x060001C8 RID: 456 RVA: 0x0001DC40 File Offset: 0x0001C040
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

		// Token: 0x060001C9 RID: 457 RVA: 0x0001DCC4 File Offset: 0x0001C0C4
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

		// Token: 0x060001CA RID: 458 RVA: 0x0001DD48 File Offset: 0x0001C148
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

		// Token: 0x060001CB RID: 459 RVA: 0x0001DDCC File Offset: 0x0001C1CC
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

		// Token: 0x060001CC RID: 460 RVA: 0x0001DE50 File Offset: 0x0001C250
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

		// Token: 0x060001CD RID: 461 RVA: 0x0001DED4 File Offset: 0x0001C2D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucBids_OnLink(object sender, string stock, Point point)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.contextLink.Tag = stock;
				this.contextLink.Show((ucBids)sender, point);
			}
			catch (Exception ex)
			{
				this.ShowError("ucBids_OnLink", ex);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001DF40 File Offset: 0x0001C340
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

		// Token: 0x040000E2 RID: 226
		private IContainer components;

		// Token: 0x040000E3 RID: 227
		private Panel panelMain;

		// Token: 0x040000E4 RID: 228
		private Scrollbar scrollbar1;

		// Token: 0x040000E5 RID: 229
		private SortGrid speedTableGrid1;

		// Token: 0x040000E6 RID: 230
		private SortGrid speedTableGrid2;

		// Token: 0x040000E7 RID: 231
		private SortGrid speedTableGrid3;

		// Token: 0x040000E8 RID: 232
		private SortGrid speedTableGrid4;

		// Token: 0x040000E9 RID: 233
		private ToolStrip tStripMenu;

		// Token: 0x040000EA RID: 234
		private ToolStripLabel toolStripLabel10;

		// Token: 0x040000EB RID: 235
		private ToolStripComboBox tscbSelection;

		// Token: 0x040000EC RID: 236
		private ToolStripButton tsbtnAdd;

		// Token: 0x040000ED RID: 237
		private ToolStripButton tsbtnDel;

		// Token: 0x040000EE RID: 238
		private ucBids ucBids1;

		// Token: 0x040000EF RID: 239
		private ucBids ucBids4;

		// Token: 0x040000F0 RID: 240
		private ucBids ucBids3;

		// Token: 0x040000F1 RID: 241
		private ucBids ucBids2;

		// Token: 0x040000F2 RID: 242
		private ucBids ucBids8;

		// Token: 0x040000F3 RID: 243
		private ucBids ucBids7;

		// Token: 0x040000F4 RID: 244
		private ucBids ucBids6;

		// Token: 0x040000F5 RID: 245
		private ucBids ucBids5;

		// Token: 0x040000F6 RID: 246
		private ContextMenuStrip contextLink;

		// Token: 0x040000F7 RID: 247
		private ToolStripMenuItem tsmCallHistoricalChart;

		// Token: 0x040000F8 RID: 248
		private ToolStripMenuItem tsmCallNews;

		// Token: 0x040000F9 RID: 249
		private ToolStripMenuItem tsmCallStockInPlay;

		// Token: 0x040000FA RID: 250
		private ToolStripMenuItem tsmCallSaleByPrice;

		// Token: 0x040000FB RID: 251
		private ToolStripMenuItem tsmCallSaleByTime;

		// Token: 0x040000FC RID: 252
		private ToolStripMenuItem tsmCallOddlot;

		// Token: 0x040000FD RID: 253
		private ToolStripSeparator toolStripMenuItem1;

		// Token: 0x040000FE RID: 254
		private ToolStripMenuItem tsmCallMarketWatch;

		// Token: 0x040000FF RID: 255
		private ToolStripMenuItem tsmCallFinance;

		// Token: 0x04000100 RID: 256
		private BackgroundWorker bgwReloadData;

		// Token: 0x04000101 RID: 257
		private BackgroundWorker bgwReloadData_TFEX;

		// Token: 0x04000102 RID: 258
		private DataSet tdsTOPBBo;

		// Token: 0x04000103 RID: 259
		private DataSet tdsTOPBBoTfex;

		// Token: 0x04000104 RID: 260
		private string _selectionText;

		// Token: 0x04000105 RID: 261
		private int _currentActivePanel;

		// Token: 0x04000106 RID: 262
		private int _currFavPage;

		// Token: 0x04000107 RID: 263
		private ucBids[] _bidControl;
	}
}
