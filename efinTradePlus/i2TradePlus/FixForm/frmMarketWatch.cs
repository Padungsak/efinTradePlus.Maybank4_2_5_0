using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Controls;
using i2TradePlus.Information;
using i2TradePlus.Properties;
using i2TradePlus.Templates;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.RealtimeMessage;
using ITSNet.Common.BIZ.RealtimeMessage.TFEX;
using STIControl;
using STIControl.CustomGrid;
using STIControl.ExpandTableGrid;
using STIControl.SortTableGrid;

namespace i2TradePlus.FixForm
{
	// Token: 0x02000246 RID: 582
	public class frmMarketWatch : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x060015ED RID: 5613 RVA: 0x00126ACC File Offset: 0x00124ECC
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

		// Token: 0x060015EE RID: 5614 RVA: 0x00126B1C File Offset: 0x00124F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMarketWatch));
			STIControl.ExpandTableGrid.ColumnItem columnItem = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem2 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem3 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem4 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem5 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem6 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem7 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem8 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem9 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem10 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem11 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem12 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem13 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem14 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem15 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem16 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem17 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem18 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem19 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem20 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem21 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem22 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem23 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem24 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem25 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem26 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem27 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem28 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem29 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem30 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem31 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem32 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem33 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem34 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem35 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem36 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem37 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem38 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem39 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem40 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem41 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem42 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem43 = new STIControl.ExpandTableGrid.ColumnItem();
			STIControl.ExpandTableGrid.ColumnItem columnItem44 = new STIControl.ExpandTableGrid.ColumnItem();
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
			STIControl.SortTableGrid.ColumnItem columnItem45 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem46 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem47 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem48 = new STIControl.SortTableGrid.ColumnItem();
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
			STIControl.SortTableGrid.ColumnItem columnItem49 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem50 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem51 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem52 = new STIControl.SortTableGrid.ColumnItem();
			ItemGrid itemGrid85 = new ItemGrid();
			STIControl.SortTableGrid.ColumnItem columnItem53 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem54 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem55 = new STIControl.SortTableGrid.ColumnItem();
			STIControl.SortTableGrid.ColumnItem columnItem56 = new STIControl.SortTableGrid.ColumnItem();
			clsPermission clsPermission = new clsPermission();
			clsPermission clsPermission2 = new clsPermission();
			this.tStripMenu = new ToolStrip();
			this.tsStockLable = new ToolStripLabel();
			this.tstbStock = new ToolStripComboBox();
			this.tslbCompare = new ToolStripLabel();
			this.tsPrice = new ToolStripLabel();
			this.tsbtnRefreshChart = new ToolStripButton();
			this.tsbtnSwitchChart = new ToolStripButton();
			this.tsbtnHChart = new ToolStripButton();
			this.tsbtnSETNews = new ToolStripButton();
			this.tslbTfexHigh = new ToolStripLabel();
			this.tstbTfexHigh = new ToolStripLabel();
			this.tslbTfexLow = new ToolStripLabel();
			this.tstbTfexLow = new ToolStripLabel();
			this.tslbTfexAvg = new ToolStripLabel();
			this.tstbTfexAvg = new ToolStripLabel();
			this.tsbtnVolAs = new ToolStripButton();
			this.tsSectorName = new ToolStripLabel();
			this.tsSectorIndex = new ToolStripLabel();
			this.lbSplashInfo = new Label();
			this.tbStockBBO = new TextBox();
			this.lbBBOLoading = new Label();
			this.panelBidOffer = new Panel();
			this.intzaCMPR = new ExpandGrid();
			this.intzaBBO = new ExpandGrid();
			this.intzaOption = new ExpandGrid();
			this.tStripCP = new ToolStrip();
			this.tStripCall = new ToolStripLabel();
			this.tStripPUT = new ToolStripLabel();
			this.tStripBBO = new ToolStrip();
			this.tslbSelection = new ToolStripLabel();
			this.tscbBBOSelectionMain = new ToolStripComboBox();
			this.tscbBBOSelection = new ToolStripComboBox();
			this.tsbtnBBOAddStock = new ToolStripButton();
			this.tsbtnBBODelStock = new ToolStripButton();
			this.tsbtnColumnSetup = new ToolStripButton();
			this.contextMenuStrip1 = new ContextMenuStrip(this.components);
			this.tsmiShowBestBO = new ToolStripMenuItem();
			this.tsmiShow3BO = new ToolStripMenuItem();
			this.tsmiShow5BO = new ToolStripMenuItem();
			this.pictureBox1 = new PictureBox();
			this.lbChartLoading = new Label();
			this.contextLink = new ContextMenuStrip(this.components);
			this.tsmCallHistoricalChart = new ToolStripMenuItem();
			this.tsmCallNews = new ToolStripMenuItem();
			this.tsmCallFinance = new ToolStripMenuItem();
			this.toolStripMenuItem1 = new ToolStripSeparator();
			this.tsmCallStockInPlay = new ToolStripMenuItem();
			this.tsmCallSaleByPrice = new ToolStripMenuItem();
			this.tsmCallSaleByTime = new ToolStripMenuItem();
			this.tsmCallOddlot = new ToolStripMenuItem();
			this.btnCloseChart = new Button();
			this.intzaInfoTFEX = new IntzaCustomGrid();
			this.intzaVolumeByBoard = new SortGrid();
			this.intzaInfo = new IntzaCustomGrid();
			this.intzaLS = new SortGrid();
			this.intzaBF = new IntzaCustomGrid();
			this.intzaTP = new SortGrid();
			this.toolTip1 = new ToolTip(this.components);
			this.wcGraphVolume = new ucVolumeAtPrice();
			this.panelVolAs = new Panel();
			this.btnVolAsClose = new Button();
			this.tStripMenu.SuspendLayout();
			this.panelBidOffer.SuspendLayout();
			this.tStripCP.SuspendLayout();
			this.tStripBBO.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.contextLink.SuspendLayout();
			this.panelVolAs.SuspendLayout();
			base.SuspendLayout();
			this.tStripMenu.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripMenu.BackgroundImageLayout = ImageLayout.None;
			this.tStripMenu.GripMargin = new Padding(0);
			this.tStripMenu.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.tsStockLable,
				this.tstbStock,
				this.tslbCompare,
				this.tsPrice,
				this.tsbtnRefreshChart,
				this.tsbtnSwitchChart,
				this.tsbtnHChart,
				this.tsbtnSETNews,
				this.tslbTfexHigh,
				this.tstbTfexHigh,
				this.tslbTfexLow,
				this.tstbTfexLow,
				this.tslbTfexAvg,
				this.tstbTfexAvg,
				this.tsbtnVolAs,
				this.tsSectorName,
				this.tsSectorIndex
			});
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Padding = new Padding(1, 1, 1, 2);
			this.tStripMenu.RenderMode = ToolStripRenderMode.System;
			this.tStripMenu.Size = new Size(963, 26);
			this.tStripMenu.TabIndex = 21;
			this.tStripMenu.TabStop = true;
			this.tsStockLable.BackColor = Color.Transparent;
			this.tsStockLable.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsStockLable.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsStockLable.ForeColor = Color.LightGray;
			this.tsStockLable.ImageTransparentColor = Color.Magenta;
			this.tsStockLable.Name = "tsStockLable";
			this.tsStockLable.Padding = new Padding(1, 0, 2, 0);
			this.tsStockLable.Size = new Size(44, 20);
			this.tsStockLable.Text = "Symbol";
			this.tstbStock.BackColor = Color.FromArgb(30, 30, 30);
			this.tstbStock.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tstbStock.ForeColor = Color.Yellow;
			this.tstbStock.Name = "tstbStock";
			this.tstbStock.Size = new Size(120, 23);
			this.tstbStock.SelectedIndexChanged += new EventHandler(this.tstbStock_SelectedIndexChanged);
			this.tstbStock.KeyUp += new KeyEventHandler(this.tstbStock_KeyUp);
			this.tstbStock.KeyDown += new KeyEventHandler(this.tstbStock_KeyDown);
			this.tstbStock.Leave += new EventHandler(this.tstbStock_Leave);
			this.tstbStock.KeyPress += new KeyPressEventHandler(this.tstbStock_KeyPress);
			this.tslbCompare.BackColor = Color.Transparent;
			this.tslbCompare.Font = new Font("Wingdings", 9f, FontStyle.Regular, GraphicsUnit.Point, 2);
			this.tslbCompare.ForeColor = Color.Lime;
			this.tslbCompare.Margin = new Padding(5, 1, 0, 2);
			this.tslbCompare.Name = "tslbCompare";
			this.tslbCompare.Size = new Size(0, 20);
			this.tslbCompare.Tag = "0";
			this.tsPrice.BackColor = Color.Transparent;
			this.tsPrice.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsPrice.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsPrice.ForeColor = Color.Yellow;
			this.tsPrice.Margin = new Padding(0, 1, 5, 2);
			this.tsPrice.Name = "tsPrice";
			this.tsPrice.Padding = new Padding(0, 0, 2, 0);
			this.tsPrice.Size = new Size(30, 20);
			this.tsPrice.Text = "0.00";
			this.tsbtnRefreshChart.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnRefreshChart.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnRefreshChart.Image = Resources.refresh;
			this.tsbtnRefreshChart.ImageTransparentColor = Color.Magenta;
			this.tsbtnRefreshChart.Name = "tsbtnRefreshChart";
			this.tsbtnRefreshChart.Size = new Size(23, 20);
			this.tsbtnRefreshChart.Text = "Reload Chart";
			this.tsbtnRefreshChart.Click += new EventHandler(this.tsbtnRefreshChart_Click);
			this.tsbtnSwitchChart.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnSwitchChart.BackColor = Color.Transparent;
			this.tsbtnSwitchChart.ForeColor = Color.LightGray;
			this.tsbtnSwitchChart.Image = (Image)componentResourceManager.GetObject("tsbtnSwitchChart.Image");
			this.tsbtnSwitchChart.ImageTransparentColor = Color.Magenta;
			this.tsbtnSwitchChart.Margin = new Padding(2, 1, 2, 2);
			this.tsbtnSwitchChart.Name = "tsbtnSwitchChart";
			this.tsbtnSwitchChart.Size = new Size(23, 20);
			this.tsbtnSwitchChart.ToolTipText = "Intraday Chart";
			this.tsbtnSwitchChart.Click += new EventHandler(this.tsbtnSwitchChart_Click);
			this.tsbtnHChart.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnHChart.ForeColor = Color.WhiteSmoke;
			this.tsbtnHChart.Image = (Image)componentResourceManager.GetObject("tsbtnHChart.Image");
			this.tsbtnHChart.ImageTransparentColor = Color.Magenta;
			this.tsbtnHChart.Margin = new Padding(2, 1, 2, 2);
			this.tsbtnHChart.Name = "tsbtnHChart";
			this.tsbtnHChart.Size = new Size(23, 20);
			this.tsbtnHChart.ToolTipText = "Graph";
			this.tsbtnHChart.Click += new EventHandler(this.tsbtnHChart_Click);
			this.tsbtnSETNews.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnSETNews.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnSETNews.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tsbtnSETNews.ForeColor = Color.SandyBrown;
			this.tsbtnSETNews.Image = (Image)componentResourceManager.GetObject("tsbtnSETNews.Image");
			this.tsbtnSETNews.ImageTransparentColor = Color.Magenta;
			this.tsbtnSETNews.Margin = new Padding(2, 1, 2, 2);
			this.tsbtnSETNews.Name = "tsbtnSETNews";
			this.tsbtnSETNews.Size = new Size(23, 20);
			this.tsbtnSETNews.Tag = "S";
			this.tsbtnSETNews.Text = "News";
			this.tsbtnSETNews.ToolTipText = "News";
			this.tsbtnSETNews.Click += new EventHandler(this.tsbtnSETNews_Click);
			this.tslbTfexHigh.BackColor = Color.Transparent;
			this.tslbTfexHigh.ForeColor = Color.Gainsboro;
			this.tslbTfexHigh.Margin = new Padding(1, 1, 5, 2);
			this.tslbTfexHigh.Name = "tslbTfexHigh";
			this.tslbTfexHigh.Size = new Size(33, 20);
			this.tslbTfexHigh.Text = "High";
			this.tstbTfexHigh.BackColor = Color.Transparent;
			this.tstbTfexHigh.ForeColor = Color.Yellow;
			this.tstbTfexHigh.Name = "tstbTfexHigh";
			this.tstbTfexHigh.Padding = new Padding(1, 0, 1, 0);
			this.tstbTfexHigh.Size = new Size(30, 20);
			this.tstbTfexHigh.Text = "0.00";
			this.tslbTfexLow.BackColor = Color.Transparent;
			this.tslbTfexLow.ForeColor = Color.Gainsboro;
			this.tslbTfexLow.Margin = new Padding(1, 1, 5, 2);
			this.tslbTfexLow.Name = "tslbTfexLow";
			this.tslbTfexLow.Size = new Size(29, 20);
			this.tslbTfexLow.Text = "Low";
			this.tstbTfexLow.BackColor = Color.Transparent;
			this.tstbTfexLow.ForeColor = Color.Yellow;
			this.tstbTfexLow.Name = "tstbTfexLow";
			this.tstbTfexLow.Padding = new Padding(1, 0, 1, 0);
			this.tstbTfexLow.Size = new Size(30, 20);
			this.tstbTfexLow.Text = "0.00";
			this.tslbTfexAvg.BackColor = Color.Transparent;
			this.tslbTfexAvg.ForeColor = Color.Gainsboro;
			this.tslbTfexAvg.Margin = new Padding(1, 1, 5, 2);
			this.tslbTfexAvg.Name = "tslbTfexAvg";
			this.tslbTfexAvg.Size = new Size(28, 20);
			this.tslbTfexAvg.Text = "Avg";
			this.tstbTfexAvg.BackColor = Color.Transparent;
			this.tstbTfexAvg.ForeColor = Color.Yellow;
			this.tstbTfexAvg.Name = "tstbTfexAvg";
			this.tstbTfexAvg.Padding = new Padding(1, 0, 1, 0);
			this.tstbTfexAvg.Size = new Size(30, 20);
			this.tstbTfexAvg.Text = "0.00";
			this.tsbtnVolAs.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnVolAs.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbtnVolAs.Image = (Image)componentResourceManager.GetObject("tsbtnVolAs.Image");
			this.tsbtnVolAs.ImageTransparentColor = Color.Magenta;
			this.tsbtnVolAs.Name = "tsbtnVolAs";
			this.tsbtnVolAs.Size = new Size(23, 20);
			this.tsbtnVolAs.ToolTipText = "Volume Analysis";
			this.tsbtnVolAs.Click += new EventHandler(this.tsbtnVolAs_Click);
			this.tsSectorName.BackColor = Color.Transparent;
			this.tsSectorName.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsSectorName.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsSectorName.ForeColor = Color.Aqua;
			this.tsSectorName.Margin = new Padding(2, 1, 2, 2);
			this.tsSectorName.Name = "tsSectorName";
			this.tsSectorName.Padding = new Padding(2, 0, 2, 0);
			this.tsSectorName.Size = new Size(42, 20);
			this.tsSectorName.Text = "Sector";
			this.tsSectorIndex.BackColor = Color.Transparent;
			this.tsSectorIndex.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsSectorIndex.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.tsSectorIndex.ForeColor = Color.Yellow;
			this.tsSectorIndex.Name = "tsSectorIndex";
			this.tsSectorIndex.Padding = new Padding(2, 0, 3, 0);
			this.tsSectorIndex.Size = new Size(33, 20);
			this.tsSectorIndex.Text = "0.00";
			this.lbSplashInfo.AutoSize = true;
			this.lbSplashInfo.BackColor = Color.FromArgb(64, 64, 64);
			this.lbSplashInfo.BorderStyle = BorderStyle.FixedSingle;
			this.lbSplashInfo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbSplashInfo.ForeColor = Color.Yellow;
			this.lbSplashInfo.Location = new Point(602, 140);
			this.lbSplashInfo.Name = "lbSplashInfo";
			this.lbSplashInfo.Padding = new Padding(5, 3, 5, 3);
			this.lbSplashInfo.Size = new Size(69, 21);
			this.lbSplashInfo.TabIndex = 75;
			this.lbSplashInfo.Text = "Loading ...";
			this.lbSplashInfo.TextAlign = ContentAlignment.MiddleCenter;
			this.lbSplashInfo.Visible = false;
			this.tbStockBBO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbStockBBO.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbStockBBO.BackColor = Color.WhiteSmoke;
			this.tbStockBBO.BorderStyle = BorderStyle.FixedSingle;
			this.tbStockBBO.CharacterCasing = CharacterCasing.Upper;
			this.tbStockBBO.ForeColor = Color.Black;
			this.tbStockBBO.Location = new Point(8, 80);
			this.tbStockBBO.Margin = new Padding(0);
			this.tbStockBBO.MaxLength = 12;
			this.tbStockBBO.Name = "tbStockBBO";
			this.tbStockBBO.Size = new Size(83, 20);
			this.tbStockBBO.TabIndex = 68;
			this.tbStockBBO.Visible = false;
			this.tbStockBBO.KeyDown += new KeyEventHandler(this.tbStockBBO_KeyDown);
			this.tbStockBBO.Leave += new EventHandler(this.tbStockBBO_Leave);
			this.tbStockBBO.Enter += new EventHandler(this.tbStockBBO_Enter);
			this.lbBBOLoading.AutoSize = true;
			this.lbBBOLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbBBOLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbBBOLoading.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbBBOLoading.ForeColor = Color.Yellow;
			this.lbBBOLoading.Location = new Point(602, 166);
			this.lbBBOLoading.Name = "lbBBOLoading";
			this.lbBBOLoading.Padding = new Padding(5, 3, 5, 3);
			this.lbBBOLoading.Size = new Size(69, 21);
			this.lbBBOLoading.TabIndex = 73;
			this.lbBBOLoading.Text = "Loading ...";
			this.lbBBOLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbBBOLoading.Visible = false;
			this.panelBidOffer.BackColor = Color.FromArgb(20, 20, 20);
			this.panelBidOffer.Controls.Add(this.intzaCMPR);
			this.panelBidOffer.Controls.Add(this.intzaBBO);
			this.panelBidOffer.Controls.Add(this.intzaOption);
			this.panelBidOffer.Controls.Add(this.tStripCP);
			this.panelBidOffer.Controls.Add(this.tStripBBO);
			this.panelBidOffer.Controls.Add(this.tbStockBBO);
			this.panelBidOffer.Location = new Point(2, 192);
			this.panelBidOffer.Margin = new Padding(0);
			this.panelBidOffer.Name = "panelBidOffer";
			this.panelBidOffer.Size = new Size(952, 197);
			this.panelBidOffer.TabIndex = 1;
			this.panelBidOffer.Leave += new EventHandler(this.panelBidOffer_Leave);
			this.panelBidOffer.Enter += new EventHandler(this.panelBidOffer_Enter);
			this.intzaCMPR.AllowDrop = true;
			this.intzaCMPR.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaCMPR.CanBlink = true;
			this.intzaCMPR.CanDrag = true;
			this.intzaCMPR.CanGetMouseMove = true;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.FontColor = Color.LightGray;
			columnItem.IsExpand = false;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "No.";
			columnItem.ValueFormat = FormatType.RecordNumber;
			columnItem.Visible = true;
			columnItem.Width = 6;
			columnItem2.Alignment = StringAlignment.Near;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.FontColor = Color.LightGray;
			columnItem2.IsExpand = false;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "stock";
			columnItem2.Text = "Symbol";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 16;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.FontColor = Color.LightGray;
			columnItem3.IsExpand = false;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "avgvol5";
			columnItem3.Text = "AVG Vol5";
			columnItem3.ValueFormat = FormatType.Volume;
			columnItem3.Visible = true;
			columnItem3.Width = 14;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 100);
			columnItem4.FontColor = Color.LightGray;
			columnItem4.IsExpand = false;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "trade_vol";
			columnItem4.Text = "TradeVol";
			columnItem4.ValueFormat = FormatType.Volume;
			columnItem4.Visible = true;
			columnItem4.Width = 14;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.FontColor = Color.LightGray;
			columnItem5.IsExpand = false;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "cmpr";
			columnItem5.Text = "%CMPR";
			columnItem5.ValueFormat = FormatType.Price;
			columnItem5.Visible = true;
			columnItem5.Width = 10;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.FontColor = Color.LightGray;
			columnItem6.IsExpand = false;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "prev";
			columnItem6.Text = "Prev";
			columnItem6.ValueFormat = FormatType.Price;
			columnItem6.Visible = true;
			columnItem6.Width = 10;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.FontColor = Color.LightGray;
			columnItem7.IsExpand = false;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "last";
			columnItem7.Text = "Last";
			columnItem7.ValueFormat = FormatType.PriceAndCompare;
			columnItem7.Visible = true;
			columnItem7.Width = 10;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.FontColor = Color.LightGray;
			columnItem8.IsExpand = false;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "chg";
			columnItem8.Text = "Chg";
			columnItem8.ValueFormat = FormatType.ChangePrice;
			columnItem8.Visible = true;
			columnItem8.Width = 10;
			columnItem9.Alignment = StringAlignment.Far;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.FontColor = Color.LightGray;
			columnItem9.IsExpand = false;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "chg_pct";
			columnItem9.Text = "%Chg";
			columnItem9.ValueFormat = FormatType.ChangePrice;
			columnItem9.Visible = true;
			columnItem9.Width = 10;
			this.intzaCMPR.Columns.Add(columnItem);
			this.intzaCMPR.Columns.Add(columnItem2);
			this.intzaCMPR.Columns.Add(columnItem3);
			this.intzaCMPR.Columns.Add(columnItem4);
			this.intzaCMPR.Columns.Add(columnItem5);
			this.intzaCMPR.Columns.Add(columnItem6);
			this.intzaCMPR.Columns.Add(columnItem7);
			this.intzaCMPR.Columns.Add(columnItem8);
			this.intzaCMPR.Columns.Add(columnItem9);
			this.intzaCMPR.CurrentScroll = 0;
			this.intzaCMPR.Cursor = Cursors.Hand;
			this.intzaCMPR.FocusItemIndex = -1;
			this.intzaCMPR.ForeColor = Color.Black;
			this.intzaCMPR.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaCMPR.HeaderPctHeight = 80f;
			this.intzaCMPR.IsAutoRepaint = true;
			this.intzaCMPR.IsDrawGrid = true;
			this.intzaCMPR.IsDrawHeader = true;
			this.intzaCMPR.IsScrollable = true;
			this.intzaCMPR.Location = new Point(242, 64);
			this.intzaCMPR.MainColumn = "";
			this.intzaCMPR.Margin = new Padding(0);
			this.intzaCMPR.Name = "intzaCMPR";
			this.intzaCMPR.Rows = 0;
			this.intzaCMPR.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.intzaCMPR.RowSelectType = 2;
			this.intzaCMPR.Size = new Size(684, 65);
			this.intzaCMPR.SortColumnName = "";
			this.intzaCMPR.SortType = SortType.Desc;
			this.intzaCMPR.TabIndex = 82;
			this.intzaCMPR.TableMouseClick += new ExpandGrid.TableMouseClickEventHandler(this.intzaCMPR_TableMouseClick);
			this.intzaBBO.AllowDrop = true;
			this.intzaBBO.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaBBO.CanBlink = true;
			this.intzaBBO.CanDrag = true;
			this.intzaBBO.CanGetMouseMove = true;
			columnItem10.Alignment = StringAlignment.Near;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.FontColor = Color.LightGray;
			columnItem10.IsExpand = true;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "stock";
			columnItem10.Text = "Symbol";
			columnItem10.ValueFormat = FormatType.Symbol;
			columnItem10.Visible = true;
			columnItem10.Width = 15;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.FontColor = Color.LightGray;
			columnItem11.IsExpand = false;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "last";
			columnItem11.Text = "Last";
			columnItem11.ValueFormat = FormatType.PriceAndCompare;
			columnItem11.Visible = true;
			columnItem11.Width = 10;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.FontColor = Color.LightGray;
			columnItem12.IsExpand = false;
			columnItem12.MyStyle = FontStyle.Underline;
			columnItem12.Name = "chg";
			columnItem12.Text = "Chg";
			columnItem12.ValueFormat = FormatType.ChangePrice;
			columnItem12.Visible = true;
			columnItem12.Width = 8;
			columnItem13.Alignment = StringAlignment.Far;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.FontColor = Color.LightGray;
			columnItem13.IsExpand = false;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "prior";
			columnItem13.Text = "Prev";
			columnItem13.ValueFormat = FormatType.Price;
			columnItem13.Visible = false;
			columnItem13.Width = 8;
			columnItem14.Alignment = StringAlignment.Far;
			columnItem14.BackColor = Color.FromArgb(64, 64, 64);
			columnItem14.FontColor = Color.LightGray;
			columnItem14.IsExpand = false;
			columnItem14.MyStyle = FontStyle.Underline;
			columnItem14.Name = "po";
			columnItem14.Text = "PO";
			columnItem14.ValueFormat = FormatType.Price;
			columnItem14.Visible = false;
			columnItem14.Width = 9;
			columnItem15.Alignment = StringAlignment.Far;
			columnItem15.BackColor = Color.FromArgb(64, 64, 64);
			columnItem15.FontColor = Color.LightGray;
			columnItem15.IsExpand = false;
			columnItem15.MyStyle = FontStyle.Underline;
			columnItem15.Name = "avg";
			columnItem15.Text = "Avg";
			columnItem15.ValueFormat = FormatType.Price;
			columnItem15.Visible = true;
			columnItem15.Width = 9;
			columnItem16.Alignment = StringAlignment.Far;
			columnItem16.BackColor = Color.FromArgb(64, 64, 64);
			columnItem16.FontColor = Color.LightGray;
			columnItem16.IsExpand = false;
			columnItem16.MyStyle = FontStyle.Regular;
			columnItem16.Name = "bidvol";
			columnItem16.Text = "BidVol";
			columnItem16.ValueFormat = FormatType.BidOfferVolume;
			columnItem16.Visible = true;
			columnItem16.Width = 11;
			columnItem17.Alignment = StringAlignment.Far;
			columnItem17.BackColor = Color.FromArgb(64, 64, 64);
			columnItem17.FontColor = Color.LightGray;
			columnItem17.IsExpand = false;
			columnItem17.MyStyle = FontStyle.Regular;
			columnItem17.Name = "bid";
			columnItem17.Text = "Bid";
			columnItem17.ValueFormat = FormatType.Text;
			columnItem17.Visible = true;
			columnItem17.Width = 8;
			columnItem18.Alignment = StringAlignment.Far;
			columnItem18.BackColor = Color.FromArgb(64, 64, 64);
			columnItem18.FontColor = Color.LightGray;
			columnItem18.IsExpand = false;
			columnItem18.MyStyle = FontStyle.Regular;
			columnItem18.Name = "offer";
			columnItem18.Text = "Offer";
			columnItem18.ValueFormat = FormatType.Text;
			columnItem18.Visible = true;
			columnItem18.Width = 8;
			columnItem19.Alignment = StringAlignment.Far;
			columnItem19.BackColor = Color.FromArgb(64, 64, 64);
			columnItem19.FontColor = Color.LightGray;
			columnItem19.IsExpand = false;
			columnItem19.MyStyle = FontStyle.Regular;
			columnItem19.Name = "offvol";
			columnItem19.Text = "OffVol";
			columnItem19.ValueFormat = FormatType.BidOfferVolume;
			columnItem19.Visible = true;
			columnItem19.Width = 11;
			columnItem20.Alignment = StringAlignment.Far;
			columnItem20.BackColor = Color.FromArgb(64, 64, 64);
			columnItem20.FontColor = Color.LightGray;
			columnItem20.IsExpand = false;
			columnItem20.MyStyle = FontStyle.Regular;
			columnItem20.Name = "high";
			columnItem20.Text = "High";
			columnItem20.ValueFormat = FormatType.Price;
			columnItem20.Visible = false;
			columnItem20.Width = 8;
			columnItem21.Alignment = StringAlignment.Far;
			columnItem21.BackColor = Color.FromArgb(64, 64, 64);
			columnItem21.FontColor = Color.LightGray;
			columnItem21.IsExpand = false;
			columnItem21.MyStyle = FontStyle.Regular;
			columnItem21.Name = "low";
			columnItem21.Text = "Low";
			columnItem21.ValueFormat = FormatType.Price;
			columnItem21.Visible = false;
			columnItem21.Width = 8;
			columnItem22.Alignment = StringAlignment.Far;
			columnItem22.BackColor = Color.FromArgb(64, 64, 64);
			columnItem22.FontColor = Color.LightGray;
			columnItem22.IsExpand = false;
			columnItem22.MyStyle = FontStyle.Underline;
			columnItem22.Name = "pchg";
			columnItem22.Text = "%Chg";
			columnItem22.ValueFormat = FormatType.ChangePrice;
			columnItem22.Visible = false;
			columnItem22.Width = 8;
			columnItem23.Alignment = StringAlignment.Far;
			columnItem23.BackColor = Color.FromArgb(64, 64, 64);
			columnItem23.FontColor = Color.LightGray;
			columnItem23.IsExpand = false;
			columnItem23.MyStyle = FontStyle.Regular;
			columnItem23.Name = "deals";
			columnItem23.Text = "Deals";
			columnItem23.ValueFormat = FormatType.Volume;
			columnItem23.Visible = false;
			columnItem23.Width = 8;
			columnItem24.Alignment = StringAlignment.Near;
			columnItem24.BackColor = Color.FromArgb(64, 64, 64);
			columnItem24.FontColor = Color.LightGray;
			columnItem24.IsExpand = false;
			columnItem24.MyStyle = FontStyle.Regular;
			columnItem24.Name = "bidofferpct";
			columnItem24.Text = "%Bids";
			columnItem24.ValueFormat = FormatType.BidOfferPct;
			columnItem24.Visible = true;
			columnItem24.Width = 8;
			columnItem25.Alignment = StringAlignment.Far;
			columnItem25.BackColor = Color.FromArgb(64, 64, 64);
			columnItem25.FontColor = Color.LightGray;
			columnItem25.IsExpand = false;
			columnItem25.MyStyle = FontStyle.Underline;
			columnItem25.Name = "mval";
			columnItem25.Text = "Value(K฿)";
			columnItem25.ValueFormat = FormatType.Volume;
			columnItem25.Visible = true;
			columnItem25.Width = 12;
			columnItem26.Alignment = StringAlignment.Far;
			columnItem26.BackColor = Color.FromArgb(64, 64, 64);
			columnItem26.FontColor = Color.LightGray;
			columnItem26.IsExpand = false;
			columnItem26.MyStyle = FontStyle.Underline;
			columnItem26.Name = "mvol";
			columnItem26.Text = "Volume";
			columnItem26.ValueFormat = FormatType.Volume;
			columnItem26.Visible = false;
			columnItem26.Width = 12;
			columnItem27.Alignment = StringAlignment.Far;
			columnItem27.BackColor = Color.FromArgb(64, 64, 100);
			columnItem27.FontColor = Color.LightGray;
			columnItem27.IsExpand = false;
			columnItem27.MyStyle = FontStyle.Underline;
			columnItem27.Name = "pc";
			columnItem27.Text = "PC";
			columnItem27.ValueFormat = FormatType.Price;
			columnItem27.Visible = false;
			columnItem27.Width = 9;
			columnItem28.Alignment = StringAlignment.Far;
			columnItem28.BackColor = Color.FromArgb(64, 64, 64);
			columnItem28.FontColor = Color.LightGray;
			columnItem28.IsExpand = false;
			columnItem28.MyStyle = FontStyle.Regular;
			columnItem28.Name = "buyvolpct";
			columnItem28.Text = "BVol%";
			columnItem28.ValueFormat = FormatType.Price;
			columnItem28.Visible = false;
			columnItem28.Width = 8;
			columnItem29.Alignment = StringAlignment.Far;
			columnItem29.BackColor = Color.FromArgb(64, 64, 64);
			columnItem29.FontColor = Color.LightGray;
			columnItem29.IsExpand = false;
			columnItem29.MyStyle = FontStyle.Regular;
			columnItem29.Name = "selvolpct";
			columnItem29.Text = "SVol%";
			columnItem29.ValueFormat = FormatType.Price;
			columnItem29.Visible = false;
			columnItem29.Width = 8;
			this.intzaBBO.Columns.Add(columnItem10);
			this.intzaBBO.Columns.Add(columnItem11);
			this.intzaBBO.Columns.Add(columnItem12);
			this.intzaBBO.Columns.Add(columnItem13);
			this.intzaBBO.Columns.Add(columnItem14);
			this.intzaBBO.Columns.Add(columnItem15);
			this.intzaBBO.Columns.Add(columnItem16);
			this.intzaBBO.Columns.Add(columnItem17);
			this.intzaBBO.Columns.Add(columnItem18);
			this.intzaBBO.Columns.Add(columnItem19);
			this.intzaBBO.Columns.Add(columnItem20);
			this.intzaBBO.Columns.Add(columnItem21);
			this.intzaBBO.Columns.Add(columnItem22);
			this.intzaBBO.Columns.Add(columnItem23);
			this.intzaBBO.Columns.Add(columnItem24);
			this.intzaBBO.Columns.Add(columnItem25);
			this.intzaBBO.Columns.Add(columnItem26);
			this.intzaBBO.Columns.Add(columnItem27);
			this.intzaBBO.Columns.Add(columnItem28);
			this.intzaBBO.Columns.Add(columnItem29);
			this.intzaBBO.CurrentScroll = 0;
			this.intzaBBO.Cursor = Cursors.Hand;
			this.intzaBBO.FocusItemIndex = -1;
			this.intzaBBO.ForeColor = Color.Black;
			this.intzaBBO.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaBBO.HeaderPctHeight = 80f;
			this.intzaBBO.IsAutoRepaint = true;
			this.intzaBBO.IsDrawGrid = true;
			this.intzaBBO.IsDrawHeader = true;
			this.intzaBBO.IsScrollable = true;
			this.intzaBBO.Location = new Point(4, 35);
			this.intzaBBO.MainColumn = "";
			this.intzaBBO.Margin = new Padding(0);
			this.intzaBBO.Name = "intzaBBO";
			this.intzaBBO.Rows = 0;
			this.intzaBBO.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.intzaBBO.RowSelectType = 2;
			this.intzaBBO.Size = new Size(684, 65);
			this.intzaBBO.SortColumnName = "";
			this.intzaBBO.SortType = SortType.Desc;
			this.intzaBBO.TabIndex = 74;
			this.intzaBBO.TableClickExpand += new ExpandGrid.TableClickExpandEventHandler(this.intzaBBO_TableClickExpand);
			this.intzaBBO.TableMouseClick += new ExpandGrid.TableMouseClickEventHandler(this.intzaBBO_TableMouseClick);
			this.intzaBBO.ItemDragDrop += new ExpandGrid.ItemDragDropEventHandler(this.intzaBBO_ItemDragDrop);
			this.intzaBBO.TableHeaderMouseMove += new ExpandGrid.TableHeaderMouseMoveEventHandler(this.intzaBBO_TableHeaderMouseMove);
			this.intzaBBO.TableMouseDoubleClick += new ExpandGrid.TableMouseDoubleClickEventHandler(this.intzaBBO_TableMouseDoubleClick);
			this.intzaOption.AllowDrop = true;
			this.intzaOption.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaOption.CanBlink = true;
			this.intzaOption.CanDrag = false;
			this.intzaOption.CanGetMouseMove = false;
			columnItem30.Alignment = StringAlignment.Near;
			columnItem30.BackColor = Color.FromArgb(64, 64, 64);
			columnItem30.FontColor = Color.LightGray;
			columnItem30.IsExpand = false;
			columnItem30.MyStyle = FontStyle.Regular;
			columnItem30.Name = "callbidvol";
			columnItem30.Text = "Vol";
			columnItem30.ValueFormat = FormatType.BidOfferVolume;
			columnItem30.Visible = true;
			columnItem30.Width = 5;
			columnItem31.Alignment = StringAlignment.Near;
			columnItem31.BackColor = Color.FromArgb(64, 64, 64);
			columnItem31.FontColor = Color.LightGray;
			columnItem31.IsExpand = false;
			columnItem31.MyStyle = FontStyle.Regular;
			columnItem31.Name = "callbid";
			columnItem31.Text = "Bid";
			columnItem31.ValueFormat = FormatType.Price;
			columnItem31.Visible = true;
			columnItem31.Width = 9;
			columnItem32.Alignment = StringAlignment.Near;
			columnItem32.BackColor = Color.FromArgb(64, 64, 64);
			columnItem32.FontColor = Color.LightGray;
			columnItem32.IsExpand = false;
			columnItem32.MyStyle = FontStyle.Regular;
			columnItem32.Name = "calloffer";
			columnItem32.Text = "Ask";
			columnItem32.ValueFormat = FormatType.Text;
			columnItem32.Visible = true;
			columnItem32.Width = 9;
			columnItem33.Alignment = StringAlignment.Near;
			columnItem33.BackColor = Color.FromArgb(64, 64, 64);
			columnItem33.FontColor = Color.LightGray;
			columnItem33.IsExpand = false;
			columnItem33.MyStyle = FontStyle.Regular;
			columnItem33.Name = "calloffvol";
			columnItem33.Text = "Vol";
			columnItem33.ValueFormat = FormatType.BidOfferVolume;
			columnItem33.Visible = true;
			columnItem33.Width = 5;
			columnItem34.Alignment = StringAlignment.Near;
			columnItem34.BackColor = Color.FromArgb(64, 64, 64);
			columnItem34.FontColor = Color.LightGray;
			columnItem34.IsExpand = false;
			columnItem34.MyStyle = FontStyle.Regular;
			columnItem34.Name = "calllast";
			columnItem34.Text = "Last";
			columnItem34.ValueFormat = FormatType.Price;
			columnItem34.Visible = true;
			columnItem34.Width = 8;
			columnItem35.Alignment = StringAlignment.Near;
			columnItem35.BackColor = Color.FromArgb(64, 64, 64);
			columnItem35.FontColor = Color.LightGray;
			columnItem35.IsExpand = false;
			columnItem35.MyStyle = FontStyle.Regular;
			columnItem35.Name = "callchg";
			columnItem35.Text = "Chg";
			columnItem35.ValueFormat = FormatType.ChangePrice;
			columnItem35.Visible = true;
			columnItem35.Width = 8;
			columnItem36.Alignment = StringAlignment.Center;
			columnItem36.BackColor = Color.FromArgb(64, 64, 64);
			columnItem36.FontColor = Color.LightGray;
			columnItem36.IsExpand = false;
			columnItem36.MyStyle = FontStyle.Regular;
			columnItem36.Name = "strike";
			columnItem36.Text = "Strike Price";
			columnItem36.ValueFormat = FormatType.Price;
			columnItem36.Visible = true;
			columnItem36.Width = 12;
			columnItem37.Alignment = StringAlignment.Near;
			columnItem37.BackColor = Color.FromArgb(64, 64, 64);
			columnItem37.FontColor = Color.LightGray;
			columnItem37.IsExpand = false;
			columnItem37.MyStyle = FontStyle.Regular;
			columnItem37.Name = "putbidvol";
			columnItem37.Text = "Vol";
			columnItem37.ValueFormat = FormatType.BidOfferVolume;
			columnItem37.Visible = true;
			columnItem37.Width = 5;
			columnItem38.Alignment = StringAlignment.Near;
			columnItem38.BackColor = Color.FromArgb(64, 64, 64);
			columnItem38.FontColor = Color.LightGray;
			columnItem38.IsExpand = false;
			columnItem38.MyStyle = FontStyle.Regular;
			columnItem38.Name = "putbid";
			columnItem38.Text = "Bid";
			columnItem38.ValueFormat = FormatType.Text;
			columnItem38.Visible = true;
			columnItem38.Width = 9;
			columnItem39.Alignment = StringAlignment.Near;
			columnItem39.BackColor = Color.FromArgb(64, 64, 64);
			columnItem39.FontColor = Color.LightGray;
			columnItem39.IsExpand = false;
			columnItem39.MyStyle = FontStyle.Regular;
			columnItem39.Name = "putoffer";
			columnItem39.Text = "Ask";
			columnItem39.ValueFormat = FormatType.Text;
			columnItem39.Visible = true;
			columnItem39.Width = 9;
			columnItem40.Alignment = StringAlignment.Near;
			columnItem40.BackColor = Color.FromArgb(64, 64, 64);
			columnItem40.FontColor = Color.LightGray;
			columnItem40.IsExpand = false;
			columnItem40.MyStyle = FontStyle.Regular;
			columnItem40.Name = "putoffvol";
			columnItem40.Text = "Vol";
			columnItem40.ValueFormat = FormatType.BidOfferVolume;
			columnItem40.Visible = true;
			columnItem40.Width = 5;
			columnItem41.Alignment = StringAlignment.Near;
			columnItem41.BackColor = Color.FromArgb(64, 64, 64);
			columnItem41.FontColor = Color.LightGray;
			columnItem41.IsExpand = false;
			columnItem41.MyStyle = FontStyle.Regular;
			columnItem41.Name = "putlast";
			columnItem41.Text = "Last";
			columnItem41.ValueFormat = FormatType.Price;
			columnItem41.Visible = true;
			columnItem41.Width = 8;
			columnItem42.Alignment = StringAlignment.Near;
			columnItem42.BackColor = Color.FromArgb(64, 64, 64);
			columnItem42.FontColor = Color.LightGray;
			columnItem42.IsExpand = false;
			columnItem42.MyStyle = FontStyle.Regular;
			columnItem42.Name = "putchg";
			columnItem42.Text = "Chg";
			columnItem42.ValueFormat = FormatType.ChangePrice;
			columnItem42.Visible = true;
			columnItem42.Width = 8;
			columnItem43.Alignment = StringAlignment.Near;
			columnItem43.BackColor = Color.FromArgb(64, 64, 64);
			columnItem43.FontColor = Color.LightGray;
			columnItem43.IsExpand = false;
			columnItem43.MyStyle = FontStyle.Regular;
			columnItem43.Name = "sSeriesOC";
			columnItem43.Text = "IntzaItem";
			columnItem43.ValueFormat = FormatType.Text;
			columnItem43.Visible = false;
			columnItem43.Width = 10;
			columnItem44.Alignment = StringAlignment.Near;
			columnItem44.BackColor = Color.FromArgb(64, 64, 64);
			columnItem44.FontColor = Color.LightGray;
			columnItem44.IsExpand = false;
			columnItem44.MyStyle = FontStyle.Regular;
			columnItem44.Name = "sSeriesOP";
			columnItem44.Text = "IntzaItem";
			columnItem44.ValueFormat = FormatType.Text;
			columnItem44.Visible = false;
			columnItem44.Width = 10;
			this.intzaOption.Columns.Add(columnItem30);
			this.intzaOption.Columns.Add(columnItem31);
			this.intzaOption.Columns.Add(columnItem32);
			this.intzaOption.Columns.Add(columnItem33);
			this.intzaOption.Columns.Add(columnItem34);
			this.intzaOption.Columns.Add(columnItem35);
			this.intzaOption.Columns.Add(columnItem36);
			this.intzaOption.Columns.Add(columnItem37);
			this.intzaOption.Columns.Add(columnItem38);
			this.intzaOption.Columns.Add(columnItem39);
			this.intzaOption.Columns.Add(columnItem40);
			this.intzaOption.Columns.Add(columnItem41);
			this.intzaOption.Columns.Add(columnItem42);
			this.intzaOption.Columns.Add(columnItem43);
			this.intzaOption.Columns.Add(columnItem44);
			this.intzaOption.CurrentScroll = 0;
			this.intzaOption.Cursor = Cursors.Hand;
			this.intzaOption.FocusItemIndex = -1;
			this.intzaOption.ForeColor = Color.Black;
			this.intzaOption.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaOption.HeaderPctHeight = 80f;
			this.intzaOption.IsAutoRepaint = true;
			this.intzaOption.IsDrawGrid = true;
			this.intzaOption.IsDrawHeader = true;
			this.intzaOption.IsScrollable = true;
			this.intzaOption.Location = new Point(134, 114);
			this.intzaOption.MainColumn = "";
			this.intzaOption.Margin = new Padding(0);
			this.intzaOption.Name = "intzaOption";
			this.intzaOption.Rows = 0;
			this.intzaOption.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.intzaOption.RowSelectType = 2;
			this.intzaOption.Size = new Size(684, 56);
			this.intzaOption.SortColumnName = "";
			this.intzaOption.SortType = SortType.Desc;
			this.intzaOption.TabIndex = 80;
			this.intzaOption.TableMouseClick += new ExpandGrid.TableMouseClickEventHandler(this.intzaOption_TableMouseClick);
			this.tStripCP.AllowMerge = false;
			this.tStripCP.BackColor = Color.FromArgb(20, 20, 20);
			this.tStripCP.GripMargin = new Padding(0);
			this.tStripCP.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripCP.Items.AddRange(new ToolStripItem[]
			{
				this.tStripCall,
				this.tStripPUT
			});
			this.tStripCP.Location = new Point(0, 26);
			this.tStripCP.Name = "tStripCP";
			this.tStripCP.Padding = new Padding(0);
			this.tStripCP.RenderMode = ToolStripRenderMode.System;
			this.tStripCP.Size = new Size(952, 25);
			this.tStripCP.TabIndex = 81;
			this.tStripCP.Text = "toolStrip1";
			this.tStripCP.Visible = false;
			this.tStripCall.BackColor = Color.Black;
			this.tStripCall.ForeColor = Color.Cyan;
			this.tStripCall.Margin = new Padding(0, 1, 3, 2);
			this.tStripCall.Name = "tStripCall";
			this.tStripCall.Padding = new Padding(2, 0, 2, 0);
			this.tStripCall.Size = new Size(16, 22);
			this.tStripCall.Text = "-";
			this.tStripPUT.Alignment = ToolStripItemAlignment.Right;
			this.tStripPUT.BackColor = Color.Black;
			this.tStripPUT.ForeColor = Color.Cyan;
			this.tStripPUT.Margin = new Padding(0, 1, 3, 2);
			this.tStripPUT.Name = "tStripPUT";
			this.tStripPUT.Padding = new Padding(2, 0, 2, 0);
			this.tStripPUT.Size = new Size(16, 22);
			this.tStripPUT.Text = "-";
			this.tStripBBO.AllowMerge = false;
			this.tStripBBO.BackColor = Color.FromArgb(30, 30, 30);
			this.tStripBBO.GripMargin = new Padding(0);
			this.tStripBBO.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripBBO.Items.AddRange(new ToolStripItem[]
			{
				this.tslbSelection,
				this.tscbBBOSelectionMain,
				this.tscbBBOSelection,
				this.tsbtnBBOAddStock,
				this.tsbtnBBODelStock,
				this.tsbtnColumnSetup
			});
			this.tStripBBO.Location = new Point(0, 0);
			this.tStripBBO.Name = "tStripBBO";
			this.tStripBBO.Padding = new Padding(1, 1, 1, 2);
			this.tStripBBO.RenderMode = ToolStripRenderMode.System;
			this.tStripBBO.Size = new Size(952, 26);
			this.tStripBBO.TabIndex = 78;
			this.tslbSelection.ForeColor = Color.LightGray;
			this.tslbSelection.Margin = new Padding(5, 1, 2, 2);
			this.tslbSelection.Name = "tslbSelection";
			this.tslbSelection.Size = new Size(61, 20);
			this.tslbSelection.Text = "Selection :";
			this.tscbBBOSelectionMain.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbBBOSelectionMain.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbBBOSelectionMain.ForeColor = Color.LightGray;
			this.tscbBBOSelectionMain.Items.AddRange(new object[]
			{
				"My Port",
				"Favorite",
				"SET",
				"MAI",
				"Warrant",
				"%CMPR"
			});
			this.tscbBBOSelectionMain.Name = "tscbBBOSelectionMain";
			this.tscbBBOSelectionMain.Size = new Size(110, 23);
			this.tscbBBOSelectionMain.SelectedIndexChanged += new EventHandler(this.tscbBBOSelectionMain_SelectedIndexChanged);
			this.tscbBBOSelectionMain.KeyDown += new KeyEventHandler(this.tscbBBOSelectionMain_KeyDown);
			this.tscbBBOSelection.AutoSize = false;
			this.tscbBBOSelection.BackColor = Color.FromArgb(30, 30, 30);
			this.tscbBBOSelection.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbBBOSelection.ForeColor = Color.LightGray;
			this.tscbBBOSelection.Margin = new Padding(5, 0, 1, 0);
			this.tscbBBOSelection.Name = "tscbBBOSelection";
			this.tscbBBOSelection.Size = new Size(180, 23);
			this.tscbBBOSelection.SelectedIndexChanged += new EventHandler(this.tscbSelection_SelectedIndexChanged);
			this.tscbBBOSelection.KeyDown += new KeyEventHandler(this.tscbBBOSelection_KeyDown);
			this.tsbtnBBOAddStock.ForeColor = Color.LightGray;
			this.tsbtnBBOAddStock.ImageTransparentColor = Color.Magenta;
			this.tsbtnBBOAddStock.Margin = new Padding(10, 1, 0, 2);
			this.tsbtnBBOAddStock.Name = "tsbtnBBOAddStock";
			this.tsbtnBBOAddStock.Size = new Size(33, 20);
			this.tsbtnBBOAddStock.Text = "Add";
			this.tsbtnBBOAddStock.Click += new EventHandler(this.tsbtnAddStock_Click);
			this.tsbtnBBODelStock.ForeColor = Color.LightGray;
			this.tsbtnBBODelStock.ImageTransparentColor = Color.Magenta;
			this.tsbtnBBODelStock.Name = "tsbtnBBODelStock";
			this.tsbtnBBODelStock.Size = new Size(44, 20);
			this.tsbtnBBODelStock.Text = "Delete";
			this.tsbtnBBODelStock.Click += new EventHandler(this.tsbtnBBODelStock_Click);
			this.tsbtnColumnSetup.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnColumnSetup.ForeColor = Color.LightGray;
			this.tsbtnColumnSetup.ImageTransparentColor = Color.Magenta;
			this.tsbtnColumnSetup.Name = "tsbtnColumnSetup";
			this.tsbtnColumnSetup.Size = new Size(59, 20);
			this.tsbtnColumnSetup.Text = "Columns";
			this.tsbtnColumnSetup.Visible = false;
			this.tsbtnColumnSetup.Click += new EventHandler(this.tsbtnColEdit_Click);
			this.contextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.tsmiShowBestBO,
				this.tsmiShow3BO,
				this.tsmiShow5BO
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(106, 70);
			this.contextMenuStrip1.Opening += new CancelEventHandler(this.contextMenuStrip1_Opening);
			this.tsmiShowBestBO.Name = "tsmiShowBestBO";
			this.tsmiShowBestBO.Size = new Size(105, 22);
			this.tsmiShowBestBO.Text = "1 Bids";
			this.tsmiShowBestBO.Click += new EventHandler(this.tsmiShowExpandBBO_Click);
			this.tsmiShow3BO.Name = "tsmiShow3BO";
			this.tsmiShow3BO.Size = new Size(105, 22);
			this.tsmiShow3BO.Text = "3 Bids";
			this.tsmiShow3BO.Click += new EventHandler(this.tsmiShowExpandBBO_Click);
			this.tsmiShow5BO.Name = "tsmiShow5BO";
			this.tsmiShow5BO.Size = new Size(105, 22);
			this.tsmiShow5BO.Text = "5 Bids";
			this.tsmiShow5BO.Click += new EventHandler(this.tsmiShowExpandBBO_Click);
			this.pictureBox1.BackColor = Color.FromArgb(30, 30, 30);
			this.pictureBox1.Location = new Point(511, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(58, 64);
			this.pictureBox1.TabIndex = 81;
			this.pictureBox1.TabStop = false;
			this.lbChartLoading.AutoSize = true;
			this.lbChartLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbChartLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbChartLoading.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbChartLoading.ForeColor = Color.Yellow;
			this.lbChartLoading.Location = new Point(602, 118);
			this.lbChartLoading.Name = "lbChartLoading";
			this.lbChartLoading.Padding = new Padding(5, 3, 5, 3);
			this.lbChartLoading.Size = new Size(69, 21);
			this.lbChartLoading.TabIndex = 82;
			this.lbChartLoading.Text = "Loading ...";
			this.lbChartLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbChartLoading.Visible = false;
			this.contextLink.Items.AddRange(new ToolStripItem[]
			{
				this.tsmCallHistoricalChart,
				this.tsmCallNews,
				this.tsmCallFinance,
				this.toolStripMenuItem1,
				this.tsmCallStockInPlay,
				this.tsmCallSaleByPrice,
				this.tsmCallSaleByTime,
				this.tsmCallOddlot
			});
			this.contextLink.Name = "contextMenuStrip1";
			this.contextLink.Size = new Size(142, 164);
			this.contextLink.Opening += new CancelEventHandler(this.contextLink_Opening);
			this.tsmCallHistoricalChart.Name = "tsmCallHistoricalChart";
			this.tsmCallHistoricalChart.Size = new Size(141, 22);
			this.tsmCallHistoricalChart.Text = "Graph";
			this.tsmCallHistoricalChart.Click += new EventHandler(this.tsmCallHistoricalChart_Click);
			this.tsmCallNews.Name = "tsmCallNews";
			this.tsmCallNews.Size = new Size(141, 22);
			this.tsmCallNews.Text = "News";
			this.tsmCallNews.Click += new EventHandler(this.tsmCallNews_Click);
			this.tsmCallFinance.Name = "tsmCallFinance";
			this.tsmCallFinance.Size = new Size(141, 22);
			this.tsmCallFinance.Text = "Finance";
			this.tsmCallFinance.Click += new EventHandler(this.tsmCallFinance_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(138, 6);
			this.tsmCallStockInPlay.Name = "tsmCallStockInPlay";
			this.tsmCallStockInPlay.Size = new Size(141, 22);
			this.tsmCallStockInPlay.Text = "Stock in Play";
			this.tsmCallStockInPlay.Click += new EventHandler(this.tsmCallStockSummary_Click);
			this.tsmCallSaleByPrice.Name = "tsmCallSaleByPrice";
			this.tsmCallSaleByPrice.Size = new Size(141, 22);
			this.tsmCallSaleByPrice.Text = "Sale by Price";
			this.tsmCallSaleByPrice.Click += new EventHandler(this.tsmCallSaleByPrice_Click);
			this.tsmCallSaleByTime.Name = "tsmCallSaleByTime";
			this.tsmCallSaleByTime.Size = new Size(141, 22);
			this.tsmCallSaleByTime.Text = "Sale by Time";
			this.tsmCallSaleByTime.Click += new EventHandler(this.tsmCallSaleByTime_Click);
			this.tsmCallOddlot.Name = "tsmCallOddlot";
			this.tsmCallOddlot.Size = new Size(141, 22);
			this.tsmCallOddlot.Text = "View Oddlot";
			this.tsmCallOddlot.Click += new EventHandler(this.tsmCallOddlot_Click);
			this.btnCloseChart.BackColor = Color.FromArgb(30, 30, 30);
			this.btnCloseChart.FlatAppearance.BorderSize = 0;
			this.btnCloseChart.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnCloseChart.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnCloseChart.FlatStyle = FlatStyle.Flat;
			this.btnCloseChart.Image = (Image)componentResourceManager.GetObject("btnCloseChart.Image");
			this.btnCloseChart.Location = new Point(523, 70);
			this.btnCloseChart.Name = "btnCloseChart";
			this.btnCloseChart.Size = new Size(19, 19);
			this.btnCloseChart.TabIndex = 88;
			this.btnCloseChart.UseVisualStyleBackColor = false;
			this.btnCloseChart.Visible = false;
			this.btnCloseChart.Click += new EventHandler(this.tsbtnSwitchChart_Click);
			this.intzaInfoTFEX.AllowDrop = true;
			this.intzaInfoTFEX.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfoTFEX.CanDrag = false;
			this.intzaInfoTFEX.IsAutoRepaint = true;
			this.intzaInfoTFEX.IsDroped = false;
			itemGrid.AdjustFontSize = 0f;
			itemGrid.Alignment = StringAlignment.Near;
			itemGrid.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid.Changed = false;
			itemGrid.FieldType = ItemType.Label2;
			itemGrid.FontColor = Color.Gainsboro;
			itemGrid.FontStyle = FontStyle.Regular;
			itemGrid.Height = 1f;
			itemGrid.IsBlink = 0;
			itemGrid.Name = "open_label";
			itemGrid.Text = "Open";
			itemGrid.ValueFormat = FormatType.Text;
			itemGrid.Visible = true;
			itemGrid.Width = 25;
			itemGrid.X = 0;
			itemGrid.Y = 0f;
			itemGrid2.AdjustFontSize = -1f;
			itemGrid2.Alignment = StringAlignment.Far;
			itemGrid2.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid2.Changed = false;
			itemGrid2.FieldType = ItemType.Text;
			itemGrid2.FontColor = Color.Yellow;
			itemGrid2.FontStyle = FontStyle.Regular;
			itemGrid2.Height = 1f;
			itemGrid2.IsBlink = 0;
			itemGrid2.Name = "open_vol";
			itemGrid2.Text = "";
			itemGrid2.ValueFormat = FormatType.Volume;
			itemGrid2.Visible = true;
			itemGrid2.Width = 35;
			itemGrid2.X = 25;
			itemGrid2.Y = 0f;
			itemGrid3.AdjustFontSize = 0f;
			itemGrid3.Alignment = StringAlignment.Far;
			itemGrid3.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid3.Changed = false;
			itemGrid3.FieldType = ItemType.Text;
			itemGrid3.FontColor = Color.Yellow;
			itemGrid3.FontStyle = FontStyle.Regular;
			itemGrid3.Height = 1f;
			itemGrid3.IsBlink = 0;
			itemGrid3.Name = "open_avg";
			itemGrid3.Text = "";
			itemGrid3.ValueFormat = FormatType.Text;
			itemGrid3.Visible = false;
			itemGrid3.Width = 27;
			itemGrid3.X = 73;
			itemGrid3.Y = 0f;
			itemGrid4.AdjustFontSize = 0f;
			itemGrid4.Alignment = StringAlignment.Near;
			itemGrid4.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid4.Changed = false;
			itemGrid4.FieldType = ItemType.Label2;
			itemGrid4.FontColor = Color.Gainsboro;
			itemGrid4.FontStyle = FontStyle.Regular;
			itemGrid4.Height = 1f;
			itemGrid4.IsBlink = 0;
			itemGrid4.Name = "long_label";
			itemGrid4.Text = "Long";
			itemGrid4.ValueFormat = FormatType.Text;
			itemGrid4.Visible = true;
			itemGrid4.Width = 25;
			itemGrid4.X = 0;
			itemGrid4.Y = 1.2f;
			itemGrid5.AdjustFontSize = -1f;
			itemGrid5.Alignment = StringAlignment.Far;
			itemGrid5.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid5.Changed = false;
			itemGrid5.FieldType = ItemType.Text;
			itemGrid5.FontColor = Color.Lime;
			itemGrid5.FontStyle = FontStyle.Regular;
			itemGrid5.Height = 1f;
			itemGrid5.IsBlink = 0;
			itemGrid5.Name = "long_vol";
			itemGrid5.Text = "";
			itemGrid5.ValueFormat = FormatType.Volume;
			itemGrid5.Visible = true;
			itemGrid5.Width = 35;
			itemGrid5.X = 25;
			itemGrid5.Y = 1.2f;
			itemGrid6.AdjustFontSize = 0f;
			itemGrid6.Alignment = StringAlignment.Far;
			itemGrid6.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid6.Changed = false;
			itemGrid6.FieldType = ItemType.Text;
			itemGrid6.FontColor = Color.Yellow;
			itemGrid6.FontStyle = FontStyle.Regular;
			itemGrid6.Height = 1f;
			itemGrid6.IsBlink = 0;
			itemGrid6.Name = "long_avg";
			itemGrid6.Text = "";
			itemGrid6.ValueFormat = FormatType.Text;
			itemGrid6.Visible = false;
			itemGrid6.Width = 27;
			itemGrid6.X = 73;
			itemGrid6.Y = 1.2f;
			itemGrid7.AdjustFontSize = 0f;
			itemGrid7.Alignment = StringAlignment.Near;
			itemGrid7.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid7.Changed = false;
			itemGrid7.FieldType = ItemType.Label2;
			itemGrid7.FontColor = Color.Gainsboro;
			itemGrid7.FontStyle = FontStyle.Regular;
			itemGrid7.Height = 1f;
			itemGrid7.IsBlink = 0;
			itemGrid7.Name = "short_label";
			itemGrid7.Text = "Short";
			itemGrid7.ValueFormat = FormatType.Text;
			itemGrid7.Visible = true;
			itemGrid7.Width = 25;
			itemGrid7.X = 0;
			itemGrid7.Y = 2.4f;
			itemGrid8.AdjustFontSize = -1f;
			itemGrid8.Alignment = StringAlignment.Far;
			itemGrid8.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid8.Changed = false;
			itemGrid8.FieldType = ItemType.Text;
			itemGrid8.FontColor = Color.Red;
			itemGrid8.FontStyle = FontStyle.Regular;
			itemGrid8.Height = 1f;
			itemGrid8.IsBlink = 0;
			itemGrid8.Name = "short_vol";
			itemGrid8.Text = "";
			itemGrid8.ValueFormat = FormatType.Volume;
			itemGrid8.Visible = true;
			itemGrid8.Width = 35;
			itemGrid8.X = 25;
			itemGrid8.Y = 2.4f;
			itemGrid9.AdjustFontSize = 0f;
			itemGrid9.Alignment = StringAlignment.Far;
			itemGrid9.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid9.Changed = false;
			itemGrid9.FieldType = ItemType.Text;
			itemGrid9.FontColor = Color.Yellow;
			itemGrid9.FontStyle = FontStyle.Regular;
			itemGrid9.Height = 1f;
			itemGrid9.IsBlink = 0;
			itemGrid9.Name = "short_avg";
			itemGrid9.Text = "";
			itemGrid9.ValueFormat = FormatType.Text;
			itemGrid9.Visible = false;
			itemGrid9.Width = 27;
			itemGrid9.X = 73;
			itemGrid9.Y = 2.4f;
			itemGrid10.AdjustFontSize = 0f;
			itemGrid10.Alignment = StringAlignment.Near;
			itemGrid10.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid10.Changed = false;
			itemGrid10.FieldType = ItemType.Text;
			itemGrid10.FontColor = Color.White;
			itemGrid10.FontStyle = FontStyle.Regular;
			itemGrid10.Height = 3.4f;
			itemGrid10.IsBlink = 0;
			itemGrid10.Name = "pie";
			itemGrid10.Text = "";
			itemGrid10.ValueFormat = FormatType.PieChartNew;
			itemGrid10.Visible = true;
			itemGrid10.Width = 40;
			itemGrid10.X = 60;
			itemGrid10.Y = 0f;
			itemGrid11.AdjustFontSize = 0f;
			itemGrid11.Alignment = StringAlignment.Near;
			itemGrid11.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid11.Changed = false;
			itemGrid11.FieldType = ItemType.Label2;
			itemGrid11.FontColor = Color.Gainsboro;
			itemGrid11.FontStyle = FontStyle.Regular;
			itemGrid11.Height = 1f;
			itemGrid11.IsBlink = 0;
			itemGrid11.Name = "oi_lable";
			itemGrid11.Text = "OI";
			itemGrid11.ValueFormat = FormatType.Text;
			itemGrid11.Visible = true;
			itemGrid11.Width = 25;
			itemGrid11.X = 0;
			itemGrid11.Y = 3.6f;
			itemGrid12.AdjustFontSize = 0f;
			itemGrid12.Alignment = StringAlignment.Near;
			itemGrid12.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid12.Changed = false;
			itemGrid12.FieldType = ItemType.Text;
			itemGrid12.FontColor = Color.Yellow;
			itemGrid12.FontStyle = FontStyle.Regular;
			itemGrid12.Height = 1f;
			itemGrid12.IsBlink = 0;
			itemGrid12.Name = "oi";
			itemGrid12.Text = "";
			itemGrid12.ValueFormat = FormatType.Price;
			itemGrid12.Visible = true;
			itemGrid12.Width = 24;
			itemGrid12.X = 25;
			itemGrid12.Y = 3.6f;
			itemGrid13.AdjustFontSize = 0f;
			itemGrid13.Alignment = StringAlignment.Near;
			itemGrid13.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid13.Changed = false;
			itemGrid13.FieldType = ItemType.Label2;
			itemGrid13.FontColor = Color.Gainsboro;
			itemGrid13.FontStyle = FontStyle.Regular;
			itemGrid13.Height = 1f;
			itemGrid13.IsBlink = 0;
			itemGrid13.Name = "psettle_label";
			itemGrid13.Text = "P.Settle";
			itemGrid13.ValueFormat = FormatType.Text;
			itemGrid13.Visible = true;
			itemGrid13.Width = 25;
			itemGrid13.X = 0;
			itemGrid13.Y = 4.6f;
			itemGrid14.AdjustFontSize = 0f;
			itemGrid14.Alignment = StringAlignment.Near;
			itemGrid14.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid14.Changed = false;
			itemGrid14.FieldType = ItemType.Text;
			itemGrid14.FontColor = Color.Yellow;
			itemGrid14.FontStyle = FontStyle.Regular;
			itemGrid14.Height = 1f;
			itemGrid14.IsBlink = 0;
			itemGrid14.Name = "psettle";
			itemGrid14.Text = "";
			itemGrid14.ValueFormat = FormatType.Text;
			itemGrid14.Visible = true;
			itemGrid14.Width = 24;
			itemGrid14.X = 25;
			itemGrid14.Y = 4.6f;
			itemGrid15.AdjustFontSize = 0f;
			itemGrid15.Alignment = StringAlignment.Near;
			itemGrid15.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid15.Changed = false;
			itemGrid15.FieldType = ItemType.Label2;
			itemGrid15.FontColor = Color.Gainsboro;
			itemGrid15.FontStyle = FontStyle.Regular;
			itemGrid15.Height = 1f;
			itemGrid15.IsBlink = 0;
			itemGrid15.Name = "settle_label";
			itemGrid15.Text = "Settle";
			itemGrid15.ValueFormat = FormatType.Text;
			itemGrid15.Visible = true;
			itemGrid15.Width = 25;
			itemGrid15.X = 0;
			itemGrid15.Y = 5.6f;
			itemGrid16.AdjustFontSize = 0f;
			itemGrid16.Alignment = StringAlignment.Near;
			itemGrid16.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid16.Changed = false;
			itemGrid16.FieldType = ItemType.Text;
			itemGrid16.FontColor = Color.Yellow;
			itemGrid16.FontStyle = FontStyle.Regular;
			itemGrid16.Height = 1f;
			itemGrid16.IsBlink = 0;
			itemGrid16.Name = "settle";
			itemGrid16.Text = "";
			itemGrid16.ValueFormat = FormatType.Text;
			itemGrid16.Visible = true;
			itemGrid16.Width = 24;
			itemGrid16.X = 25;
			itemGrid16.Y = 5.6f;
			itemGrid17.AdjustFontSize = 0f;
			itemGrid17.Alignment = StringAlignment.Near;
			itemGrid17.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid17.Changed = false;
			itemGrid17.FieldType = ItemType.Label2;
			itemGrid17.FontColor = Color.Gainsboro;
			itemGrid17.FontStyle = FontStyle.Regular;
			itemGrid17.Height = 1f;
			itemGrid17.IsBlink = 0;
			itemGrid17.Name = "ceiling_lable";
			itemGrid17.Text = "Ceiling";
			itemGrid17.ValueFormat = FormatType.Text;
			itemGrid17.Visible = true;
			itemGrid17.Width = 25;
			itemGrid17.X = 0;
			itemGrid17.Y = 6.6f;
			itemGrid18.AdjustFontSize = 0f;
			itemGrid18.Alignment = StringAlignment.Near;
			itemGrid18.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid18.Changed = false;
			itemGrid18.FieldType = ItemType.Text;
			itemGrid18.FontColor = Color.Cyan;
			itemGrid18.FontStyle = FontStyle.Regular;
			itemGrid18.Height = 1f;
			itemGrid18.IsBlink = 0;
			itemGrid18.Name = "ceiling";
			itemGrid18.Text = "";
			itemGrid18.ValueFormat = FormatType.Text;
			itemGrid18.Visible = true;
			itemGrid18.Width = 24;
			itemGrid18.X = 25;
			itemGrid18.Y = 6.6f;
			itemGrid19.AdjustFontSize = 0f;
			itemGrid19.Alignment = StringAlignment.Near;
			itemGrid19.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid19.Changed = false;
			itemGrid19.FieldType = ItemType.Label2;
			itemGrid19.FontColor = Color.Gainsboro;
			itemGrid19.FontStyle = FontStyle.Regular;
			itemGrid19.Height = 1f;
			itemGrid19.IsBlink = 0;
			itemGrid19.Name = "floor_label";
			itemGrid19.Text = "Floor";
			itemGrid19.ValueFormat = FormatType.Text;
			itemGrid19.Visible = true;
			itemGrid19.Width = 25;
			itemGrid19.X = 0;
			itemGrid19.Y = 7.6f;
			itemGrid20.AdjustFontSize = 0f;
			itemGrid20.Alignment = StringAlignment.Near;
			itemGrid20.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid20.Changed = false;
			itemGrid20.FieldType = ItemType.Text;
			itemGrid20.FontColor = Color.Magenta;
			itemGrid20.FontStyle = FontStyle.Regular;
			itemGrid20.Height = 1f;
			itemGrid20.IsBlink = 0;
			itemGrid20.Name = "floor";
			itemGrid20.Text = "";
			itemGrid20.ValueFormat = FormatType.Text;
			itemGrid20.Visible = true;
			itemGrid20.Width = 24;
			itemGrid20.X = 25;
			itemGrid20.Y = 7.6f;
			itemGrid21.AdjustFontSize = 0f;
			itemGrid21.Alignment = StringAlignment.Near;
			itemGrid21.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid21.Changed = false;
			itemGrid21.FieldType = ItemType.Label2;
			itemGrid21.FontColor = Color.White;
			itemGrid21.FontStyle = FontStyle.Regular;
			itemGrid21.Height = 1f;
			itemGrid21.IsBlink = 0;
			itemGrid21.Name = "Multiplier";
			itemGrid21.Text = "Multiplier";
			itemGrid21.ValueFormat = FormatType.Text;
			itemGrid21.Visible = true;
			itemGrid21.Width = 25;
			itemGrid21.X = 0;
			itemGrid21.Y = 8.6f;
			itemGrid22.AdjustFontSize = 0f;
			itemGrid22.Alignment = StringAlignment.Near;
			itemGrid22.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid22.Changed = false;
			itemGrid22.FieldType = ItemType.Text;
			itemGrid22.FontColor = Color.Yellow;
			itemGrid22.FontStyle = FontStyle.Regular;
			itemGrid22.Height = 1f;
			itemGrid22.IsBlink = 0;
			itemGrid22.Name = "multiplier";
			itemGrid22.Text = "";
			itemGrid22.ValueFormat = FormatType.Text;
			itemGrid22.Visible = true;
			itemGrid22.Width = 24;
			itemGrid22.X = 25;
			itemGrid22.Y = 8.6f;
			itemGrid23.AdjustFontSize = 0f;
			itemGrid23.Alignment = StringAlignment.Near;
			itemGrid23.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid23.Changed = false;
			itemGrid23.FieldType = ItemType.Label2;
			itemGrid23.FontColor = Color.Gainsboro;
			itemGrid23.FontStyle = FontStyle.Regular;
			itemGrid23.Height = 1f;
			itemGrid23.IsBlink = 0;
			itemGrid23.Name = "tickSize_lable";
			itemGrid23.Text = "Spread";
			itemGrid23.ValueFormat = FormatType.Text;
			itemGrid23.Visible = true;
			itemGrid23.Width = 25;
			itemGrid23.X = 0;
			itemGrid23.Y = 9.6f;
			itemGrid24.AdjustFontSize = 0f;
			itemGrid24.Alignment = StringAlignment.Near;
			itemGrid24.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid24.Changed = false;
			itemGrid24.FieldType = ItemType.Text;
			itemGrid24.FontColor = Color.Yellow;
			itemGrid24.FontStyle = FontStyle.Regular;
			itemGrid24.Height = 1f;
			itemGrid24.IsBlink = 0;
			itemGrid24.Name = "tickSize";
			itemGrid24.Text = "";
			itemGrid24.ValueFormat = FormatType.Text;
			itemGrid24.Visible = true;
			itemGrid24.Width = 24;
			itemGrid24.X = 25;
			itemGrid24.Y = 9.6f;
			itemGrid25.AdjustFontSize = 0f;
			itemGrid25.Alignment = StringAlignment.Near;
			itemGrid25.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid25.Changed = false;
			itemGrid25.FieldType = ItemType.Label;
			itemGrid25.FontColor = Color.Gainsboro;
			itemGrid25.FontStyle = FontStyle.Regular;
			itemGrid25.Height = 1f;
			itemGrid25.IsBlink = 0;
			itemGrid25.Name = "turnover_label";
			itemGrid25.Text = "Turn Over";
			itemGrid25.ValueFormat = FormatType.Text;
			itemGrid25.Visible = false;
			itemGrid25.Width = 23;
			itemGrid25.X = 49;
			itemGrid25.Y = 3.6f;
			itemGrid26.AdjustFontSize = 0f;
			itemGrid26.Alignment = StringAlignment.Near;
			itemGrid26.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid26.Changed = false;
			itemGrid26.FieldType = ItemType.Text;
			itemGrid26.FontColor = Color.Yellow;
			itemGrid26.FontStyle = FontStyle.Regular;
			itemGrid26.Height = 1f;
			itemGrid26.IsBlink = 0;
			itemGrid26.Name = "turnover";
			itemGrid26.Text = "";
			itemGrid26.ValueFormat = FormatType.Price;
			itemGrid26.Visible = false;
			itemGrid26.Width = 29;
			itemGrid26.X = 72;
			itemGrid26.Y = 3.6f;
			itemGrid27.AdjustFontSize = 0f;
			itemGrid27.Alignment = StringAlignment.Near;
			itemGrid27.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid27.Changed = false;
			itemGrid27.FieldType = ItemType.Label2;
			itemGrid27.FontColor = Color.Gainsboro;
			itemGrid27.FontStyle = FontStyle.Regular;
			itemGrid27.Height = 1f;
			itemGrid27.IsBlink = 0;
			itemGrid27.Name = "basis_label";
			itemGrid27.Text = "Basis";
			itemGrid27.ValueFormat = FormatType.Text;
			itemGrid27.Visible = true;
			itemGrid27.Width = 23;
			itemGrid27.X = 49;
			itemGrid27.Y = 3.6f;
			itemGrid28.AdjustFontSize = 0f;
			itemGrid28.Alignment = StringAlignment.Near;
			itemGrid28.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid28.Changed = false;
			itemGrid28.FieldType = ItemType.Text;
			itemGrid28.FontColor = Color.Yellow;
			itemGrid28.FontStyle = FontStyle.Regular;
			itemGrid28.Height = 1f;
			itemGrid28.IsBlink = 0;
			itemGrid28.Name = "basis";
			itemGrid28.Text = "";
			itemGrid28.ValueFormat = FormatType.Price;
			itemGrid28.Visible = true;
			itemGrid28.Width = 29;
			itemGrid28.X = 72;
			itemGrid28.Y = 3.6f;
			itemGrid29.AdjustFontSize = 0f;
			itemGrid29.Alignment = StringAlignment.Near;
			itemGrid29.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid29.Changed = false;
			itemGrid29.FieldType = ItemType.Label2;
			itemGrid29.FontColor = Color.Gainsboro;
			itemGrid29.FontStyle = FontStyle.Regular;
			itemGrid29.Height = 1f;
			itemGrid29.IsBlink = 0;
			itemGrid29.Name = "open1_label";
			itemGrid29.Text = "Open 1";
			itemGrid29.ValueFormat = FormatType.Text;
			itemGrid29.Visible = true;
			itemGrid29.Width = 23;
			itemGrid29.X = 49;
			itemGrid29.Y = 4.6f;
			itemGrid30.AdjustFontSize = 0f;
			itemGrid30.Alignment = StringAlignment.Near;
			itemGrid30.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid30.Changed = false;
			itemGrid30.FieldType = ItemType.Text;
			itemGrid30.FontColor = Color.Yellow;
			itemGrid30.FontStyle = FontStyle.Regular;
			itemGrid30.Height = 1f;
			itemGrid30.IsBlink = 0;
			itemGrid30.Name = "open1";
			itemGrid30.Text = "";
			itemGrid30.ValueFormat = FormatType.Text;
			itemGrid30.Visible = true;
			itemGrid30.Width = 29;
			itemGrid30.X = 72;
			itemGrid30.Y = 4.6f;
			itemGrid31.AdjustFontSize = 0f;
			itemGrid31.Alignment = StringAlignment.Near;
			itemGrid31.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid31.Changed = false;
			itemGrid31.FieldType = ItemType.Label2;
			itemGrid31.FontColor = Color.Gainsboro;
			itemGrid31.FontStyle = FontStyle.Regular;
			itemGrid31.Height = 1f;
			itemGrid31.IsBlink = 0;
			itemGrid31.Name = "open2_label";
			itemGrid31.Text = "Open 2";
			itemGrid31.ValueFormat = FormatType.Text;
			itemGrid31.Visible = true;
			itemGrid31.Width = 23;
			itemGrid31.X = 49;
			itemGrid31.Y = 5.6f;
			itemGrid32.AdjustFontSize = 0f;
			itemGrid32.Alignment = StringAlignment.Near;
			itemGrid32.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid32.Changed = false;
			itemGrid32.FieldType = ItemType.Text;
			itemGrid32.FontColor = Color.Yellow;
			itemGrid32.FontStyle = FontStyle.Regular;
			itemGrid32.Height = 1f;
			itemGrid32.IsBlink = 0;
			itemGrid32.Name = "open2";
			itemGrid32.Text = "";
			itemGrid32.ValueFormat = FormatType.Text;
			itemGrid32.Visible = true;
			itemGrid32.Width = 29;
			itemGrid32.X = 72;
			itemGrid32.Y = 5.6f;
			itemGrid33.AdjustFontSize = 0f;
			itemGrid33.Alignment = StringAlignment.Near;
			itemGrid33.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid33.Changed = false;
			itemGrid33.FieldType = ItemType.Label2;
			itemGrid33.FontColor = Color.Gainsboro;
			itemGrid33.FontStyle = FontStyle.Regular;
			itemGrid33.Height = 1f;
			itemGrid33.IsBlink = 0;
			itemGrid33.Name = "poclose_label";
			itemGrid33.Text = "P.Close";
			itemGrid33.ValueFormat = FormatType.Text;
			itemGrid33.Visible = true;
			itemGrid33.Width = 23;
			itemGrid33.X = 49;
			itemGrid33.Y = 7.6f;
			itemGrid34.AdjustFontSize = 0f;
			itemGrid34.Alignment = StringAlignment.Near;
			itemGrid34.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid34.Changed = false;
			itemGrid34.FieldType = ItemType.Text;
			itemGrid34.FontColor = Color.Yellow;
			itemGrid34.FontStyle = FontStyle.Regular;
			itemGrid34.Height = 1f;
			itemGrid34.IsBlink = 0;
			itemGrid34.Name = "poclose";
			itemGrid34.Text = "";
			itemGrid34.ValueFormat = FormatType.Text;
			itemGrid34.Visible = true;
			itemGrid34.Width = 29;
			itemGrid34.X = 72;
			itemGrid34.Y = 7.6f;
			itemGrid35.AdjustFontSize = 0f;
			itemGrid35.Alignment = StringAlignment.Near;
			itemGrid35.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid35.Changed = false;
			itemGrid35.FieldType = ItemType.Label2;
			itemGrid35.FontColor = Color.Gainsboro;
			itemGrid35.FontStyle = FontStyle.Regular;
			itemGrid35.Height = 1f;
			itemGrid35.IsBlink = 0;
			itemGrid35.Name = "open3_label";
			itemGrid35.Text = "Open 3";
			itemGrid35.ValueFormat = FormatType.Text;
			itemGrid35.Visible = true;
			itemGrid35.Width = 23;
			itemGrid35.X = 49;
			itemGrid35.Y = 6.6f;
			itemGrid36.AdjustFontSize = 0f;
			itemGrid36.Alignment = StringAlignment.Near;
			itemGrid36.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid36.Changed = false;
			itemGrid36.FieldType = ItemType.Text;
			itemGrid36.FontColor = Color.Yellow;
			itemGrid36.FontStyle = FontStyle.Regular;
			itemGrid36.Height = 1f;
			itemGrid36.IsBlink = 0;
			itemGrid36.Name = "open3";
			itemGrid36.Text = "";
			itemGrid36.ValueFormat = FormatType.Text;
			itemGrid36.Visible = true;
			itemGrid36.Width = 29;
			itemGrid36.X = 72;
			itemGrid36.Y = 6.6f;
			itemGrid37.AdjustFontSize = 0f;
			itemGrid37.Alignment = StringAlignment.Near;
			itemGrid37.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid37.Changed = false;
			itemGrid37.FieldType = ItemType.Label2;
			itemGrid37.FontColor = Color.Gainsboro;
			itemGrid37.FontStyle = FontStyle.Regular;
			itemGrid37.Height = 1f;
			itemGrid37.IsBlink = 0;
			itemGrid37.Name = "first_date_label";
			itemGrid37.Text = "First";
			itemGrid37.ValueFormat = FormatType.Text;
			itemGrid37.Visible = false;
			itemGrid37.Width = 23;
			itemGrid37.X = 49;
			itemGrid37.Y = 7.6f;
			itemGrid38.AdjustFontSize = 0f;
			itemGrid38.Alignment = StringAlignment.Near;
			itemGrid38.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid38.Changed = false;
			itemGrid38.FieldType = ItemType.Text;
			itemGrid38.FontColor = Color.Yellow;
			itemGrid38.FontStyle = FontStyle.Regular;
			itemGrid38.Height = 1f;
			itemGrid38.IsBlink = 0;
			itemGrid38.Name = "first_date";
			itemGrid38.Text = "";
			itemGrid38.ValueFormat = FormatType.Text;
			itemGrid38.Visible = false;
			itemGrid38.Width = 29;
			itemGrid38.X = 72;
			itemGrid38.Y = 7.6f;
			itemGrid39.AdjustFontSize = 0f;
			itemGrid39.Alignment = StringAlignment.Near;
			itemGrid39.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid39.Changed = false;
			itemGrid39.FieldType = ItemType.Label2;
			itemGrid39.FontColor = Color.Gainsboro;
			itemGrid39.FontStyle = FontStyle.Regular;
			itemGrid39.Height = 1f;
			itemGrid39.IsBlink = 0;
			itemGrid39.Name = "last_date_label";
			itemGrid39.Text = "Last";
			itemGrid39.ValueFormat = FormatType.Text;
			itemGrid39.Visible = true;
			itemGrid39.Width = 23;
			itemGrid39.X = 49;
			itemGrid39.Y = 8.6f;
			itemGrid40.AdjustFontSize = 0f;
			itemGrid40.Alignment = StringAlignment.Near;
			itemGrid40.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid40.Changed = false;
			itemGrid40.FieldType = ItemType.Text;
			itemGrid40.FontColor = Color.Yellow;
			itemGrid40.FontStyle = FontStyle.Regular;
			itemGrid40.Height = 1f;
			itemGrid40.IsBlink = 0;
			itemGrid40.Name = "last_date";
			itemGrid40.Text = "";
			itemGrid40.ValueFormat = FormatType.Text;
			itemGrid40.Visible = true;
			itemGrid40.Width = 29;
			itemGrid40.X = 72;
			itemGrid40.Y = 8.6f;
			itemGrid41.AdjustFontSize = 0f;
			itemGrid41.Alignment = StringAlignment.Near;
			itemGrid41.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid41.Changed = false;
			itemGrid41.FieldType = ItemType.Label2;
			itemGrid41.FontColor = Color.Gainsboro;
			itemGrid41.FontStyle = FontStyle.Regular;
			itemGrid41.Height = 1f;
			itemGrid41.IsBlink = 0;
			itemGrid41.Name = "lastIndex_label";
			itemGrid41.Text = "Index";
			itemGrid41.ValueFormat = FormatType.Text;
			itemGrid41.Visible = true;
			itemGrid41.Width = 23;
			itemGrid41.X = 49;
			itemGrid41.Y = 9.6f;
			itemGrid42.AdjustFontSize = 0f;
			itemGrid42.Alignment = StringAlignment.Near;
			itemGrid42.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid42.Changed = false;
			itemGrid42.FieldType = ItemType.Text;
			itemGrid42.FontColor = Color.Yellow;
			itemGrid42.FontStyle = FontStyle.Regular;
			itemGrid42.Height = 1f;
			itemGrid42.IsBlink = 0;
			itemGrid42.Name = "lastIndex";
			itemGrid42.Text = "";
			itemGrid42.ValueFormat = FormatType.Text;
			itemGrid42.Visible = true;
			itemGrid42.Width = 29;
			itemGrid42.X = 72;
			itemGrid42.Y = 9.6f;
			this.intzaInfoTFEX.Items.Add(itemGrid);
			this.intzaInfoTFEX.Items.Add(itemGrid2);
			this.intzaInfoTFEX.Items.Add(itemGrid3);
			this.intzaInfoTFEX.Items.Add(itemGrid4);
			this.intzaInfoTFEX.Items.Add(itemGrid5);
			this.intzaInfoTFEX.Items.Add(itemGrid6);
			this.intzaInfoTFEX.Items.Add(itemGrid7);
			this.intzaInfoTFEX.Items.Add(itemGrid8);
			this.intzaInfoTFEX.Items.Add(itemGrid9);
			this.intzaInfoTFEX.Items.Add(itemGrid10);
			this.intzaInfoTFEX.Items.Add(itemGrid11);
			this.intzaInfoTFEX.Items.Add(itemGrid12);
			this.intzaInfoTFEX.Items.Add(itemGrid13);
			this.intzaInfoTFEX.Items.Add(itemGrid14);
			this.intzaInfoTFEX.Items.Add(itemGrid15);
			this.intzaInfoTFEX.Items.Add(itemGrid16);
			this.intzaInfoTFEX.Items.Add(itemGrid17);
			this.intzaInfoTFEX.Items.Add(itemGrid18);
			this.intzaInfoTFEX.Items.Add(itemGrid19);
			this.intzaInfoTFEX.Items.Add(itemGrid20);
			this.intzaInfoTFEX.Items.Add(itemGrid21);
			this.intzaInfoTFEX.Items.Add(itemGrid22);
			this.intzaInfoTFEX.Items.Add(itemGrid23);
			this.intzaInfoTFEX.Items.Add(itemGrid24);
			this.intzaInfoTFEX.Items.Add(itemGrid25);
			this.intzaInfoTFEX.Items.Add(itemGrid26);
			this.intzaInfoTFEX.Items.Add(itemGrid27);
			this.intzaInfoTFEX.Items.Add(itemGrid28);
			this.intzaInfoTFEX.Items.Add(itemGrid29);
			this.intzaInfoTFEX.Items.Add(itemGrid30);
			this.intzaInfoTFEX.Items.Add(itemGrid31);
			this.intzaInfoTFEX.Items.Add(itemGrid32);
			this.intzaInfoTFEX.Items.Add(itemGrid33);
			this.intzaInfoTFEX.Items.Add(itemGrid34);
			this.intzaInfoTFEX.Items.Add(itemGrid35);
			this.intzaInfoTFEX.Items.Add(itemGrid36);
			this.intzaInfoTFEX.Items.Add(itemGrid37);
			this.intzaInfoTFEX.Items.Add(itemGrid38);
			this.intzaInfoTFEX.Items.Add(itemGrid39);
			this.intzaInfoTFEX.Items.Add(itemGrid40);
			this.intzaInfoTFEX.Items.Add(itemGrid41);
			this.intzaInfoTFEX.Items.Add(itemGrid42);
			this.intzaInfoTFEX.LineColor = Color.Red;
			this.intzaInfoTFEX.Location = new Point(653, 29);
			this.intzaInfoTFEX.Margin = new Padding(2);
			this.intzaInfoTFEX.Name = "intzaInfoTFEX";
			this.intzaInfoTFEX.Size = new Size(239, 196);
			this.intzaInfoTFEX.TabIndex = 90;
			this.intzaInfoTFEX.TabStop = false;
			this.intzaVolumeByBoard.AllowDrop = true;
			this.intzaVolumeByBoard.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaVolumeByBoard.CanBlink = true;
			this.intzaVolumeByBoard.CanDrag = false;
			this.intzaVolumeByBoard.CanGetMouseMove = false;
			columnItem45.Alignment = StringAlignment.Near;
			columnItem45.BackColor = Color.FromArgb(64, 64, 64);
			columnItem45.ColumnAlignment = StringAlignment.Center;
			columnItem45.FontColor = Color.LightGray;
			columnItem45.MyStyle = FontStyle.Regular;
			columnItem45.Name = "h1";
			columnItem45.Text = "";
			columnItem45.ValueFormat = FormatType.Label;
			columnItem45.Visible = true;
			columnItem45.Width = 17;
			columnItem46.Alignment = StringAlignment.Far;
			columnItem46.BackColor = Color.DimGray;
			columnItem46.ColumnAlignment = StringAlignment.Center;
			columnItem46.FontColor = Color.White;
			columnItem46.MyStyle = FontStyle.Regular;
			columnItem46.Name = "deals";
			columnItem46.Text = "Deals";
			columnItem46.ValueFormat = FormatType.Volume;
			columnItem46.Visible = true;
			columnItem46.Width = 20;
			columnItem47.Alignment = StringAlignment.Far;
			columnItem47.BackColor = Color.DimGray;
			columnItem47.ColumnAlignment = StringAlignment.Center;
			columnItem47.FontColor = Color.White;
			columnItem47.MyStyle = FontStyle.Regular;
			columnItem47.Name = "volume";
			columnItem47.Text = "Volume";
			columnItem47.ValueFormat = FormatType.Volume;
			columnItem47.Visible = true;
			columnItem47.Width = 29;
			columnItem48.Alignment = StringAlignment.Far;
			columnItem48.BackColor = Color.DimGray;
			columnItem48.ColumnAlignment = StringAlignment.Center;
			columnItem48.FontColor = Color.White;
			columnItem48.MyStyle = FontStyle.Regular;
			columnItem48.Name = "value";
			columnItem48.Text = "Value";
			columnItem48.ValueFormat = FormatType.Text;
			columnItem48.Visible = true;
			columnItem48.Width = 34;
			this.intzaVolumeByBoard.Columns.Add(columnItem45);
			this.intzaVolumeByBoard.Columns.Add(columnItem46);
			this.intzaVolumeByBoard.Columns.Add(columnItem47);
			this.intzaVolumeByBoard.Columns.Add(columnItem48);
			this.intzaVolumeByBoard.CurrentScroll = 0;
			this.intzaVolumeByBoard.FocusItemIndex = -1;
			this.intzaVolumeByBoard.ForeColor = Color.Black;
			this.intzaVolumeByBoard.GridColor = Color.FromArgb(30, 30, 30);
			this.intzaVolumeByBoard.HeaderPctHeight = 80f;
			this.intzaVolumeByBoard.IsAutoRepaint = true;
			this.intzaVolumeByBoard.IsDrawFullRow = false;
			this.intzaVolumeByBoard.IsDrawGrid = false;
			this.intzaVolumeByBoard.IsDrawHeader = true;
			this.intzaVolumeByBoard.IsScrollable = false;
			this.intzaVolumeByBoard.Location = new Point(30, 127);
			this.intzaVolumeByBoard.MainColumn = "";
			this.intzaVolumeByBoard.Margin = new Padding(0);
			this.intzaVolumeByBoard.Name = "intzaVolumeByBoard";
			this.intzaVolumeByBoard.Rows = 2;
			this.intzaVolumeByBoard.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaVolumeByBoard.RowSelectType = 0;
			this.intzaVolumeByBoard.RowsVisible = 2;
			this.intzaVolumeByBoard.Size = new Size(221, 62);
			this.intzaVolumeByBoard.SortColumnName = "";
			this.intzaVolumeByBoard.SortType = SortType.Desc;
			this.intzaVolumeByBoard.TabIndex = 80;
			this.intzaVolumeByBoard.ItemDragDrop += new SortGrid.ItemDragDropEventHandler(this.intzaLS2_ItemDragDrop);
			this.intzaInfo.AllowDrop = true;
			this.intzaInfo.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo.CanDrag = false;
			this.intzaInfo.IsAutoRepaint = true;
			this.intzaInfo.IsDroped = false;
			itemGrid43.AdjustFontSize = 0f;
			itemGrid43.Alignment = StringAlignment.Near;
			itemGrid43.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid43.Changed = false;
			itemGrid43.FieldType = ItemType.Label2;
			itemGrid43.FontColor = Color.Gainsboro;
			itemGrid43.FontStyle = FontStyle.Regular;
			itemGrid43.Height = 1f;
			itemGrid43.IsBlink = 0;
			itemGrid43.Name = "lb_openvol";
			itemGrid43.Text = "OpnVol";
			itemGrid43.ValueFormat = FormatType.Text;
			itemGrid43.Visible = true;
			itemGrid43.Width = 22;
			itemGrid43.X = 0;
			itemGrid43.Y = 0f;
			itemGrid44.AdjustFontSize = 0f;
			itemGrid44.Alignment = StringAlignment.Far;
			itemGrid44.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid44.Changed = false;
			itemGrid44.FieldType = ItemType.Text;
			itemGrid44.FontColor = Color.Yellow;
			itemGrid44.FontStyle = FontStyle.Regular;
			itemGrid44.Height = 1f;
			itemGrid44.IsBlink = 0;
			itemGrid44.Name = "open_vol";
			itemGrid44.Text = "";
			itemGrid44.ValueFormat = FormatType.Volume;
			itemGrid44.Visible = true;
			itemGrid44.Width = 35;
			itemGrid44.X = 25;
			itemGrid44.Y = 0f;
			itemGrid45.AdjustFontSize = -2f;
			itemGrid45.Alignment = StringAlignment.Far;
			itemGrid45.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid45.Changed = false;
			itemGrid45.FieldType = ItemType.Text;
			itemGrid45.FontColor = Color.Yellow;
			itemGrid45.FontStyle = FontStyle.Regular;
			itemGrid45.Height = 1f;
			itemGrid45.IsBlink = 0;
			itemGrid45.Name = "p_open_vol";
			itemGrid45.Text = "";
			itemGrid45.ValueFormat = FormatType.Text;
			itemGrid45.Visible = false;
			itemGrid45.Width = 19;
			itemGrid45.X = 57;
			itemGrid45.Y = 0f;
			itemGrid46.AdjustFontSize = 0f;
			itemGrid46.Alignment = StringAlignment.Near;
			itemGrid46.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid46.Changed = false;
			itemGrid46.FieldType = ItemType.Label2;
			itemGrid46.FontColor = Color.Gainsboro;
			itemGrid46.FontStyle = FontStyle.Regular;
			itemGrid46.Height = 1f;
			itemGrid46.IsBlink = 0;
			itemGrid46.Name = "lb_buyvol";
			itemGrid46.Text = "BuyVol";
			itemGrid46.ValueFormat = FormatType.Text;
			itemGrid46.Visible = true;
			itemGrid46.Width = 22;
			itemGrid46.X = 0;
			itemGrid46.Y = 1.2f;
			itemGrid47.AdjustFontSize = 0f;
			itemGrid47.Alignment = StringAlignment.Far;
			itemGrid47.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid47.Changed = false;
			itemGrid47.FieldType = ItemType.Text;
			itemGrid47.FontColor = Color.Lime;
			itemGrid47.FontStyle = FontStyle.Regular;
			itemGrid47.Height = 1f;
			itemGrid47.IsBlink = 0;
			itemGrid47.Name = "buy_vol";
			itemGrid47.Text = "";
			itemGrid47.ValueFormat = FormatType.Volume;
			itemGrid47.Visible = true;
			itemGrid47.Width = 35;
			itemGrid47.X = 25;
			itemGrid47.Y = 1.2f;
			itemGrid48.AdjustFontSize = -2f;
			itemGrid48.Alignment = StringAlignment.Far;
			itemGrid48.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid48.Changed = false;
			itemGrid48.FieldType = ItemType.Text;
			itemGrid48.FontColor = Color.Lime;
			itemGrid48.FontStyle = FontStyle.Regular;
			itemGrid48.Height = 1f;
			itemGrid48.IsBlink = 0;
			itemGrid48.Name = "p_buy_vol";
			itemGrid48.Text = "";
			itemGrid48.ValueFormat = FormatType.Text;
			itemGrid48.Visible = false;
			itemGrid48.Width = 19;
			itemGrid48.X = 57;
			itemGrid48.Y = 1.2f;
			itemGrid49.AdjustFontSize = 0f;
			itemGrid49.Alignment = StringAlignment.Near;
			itemGrid49.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid49.Changed = false;
			itemGrid49.FieldType = ItemType.Label2;
			itemGrid49.FontColor = Color.Gainsboro;
			itemGrid49.FontStyle = FontStyle.Regular;
			itemGrid49.Height = 1f;
			itemGrid49.IsBlink = 0;
			itemGrid49.Name = "lb_selvol";
			itemGrid49.Text = "SelVol";
			itemGrid49.ValueFormat = FormatType.Text;
			itemGrid49.Visible = true;
			itemGrid49.Width = 22;
			itemGrid49.X = 0;
			itemGrid49.Y = 2.4f;
			itemGrid50.AdjustFontSize = 0f;
			itemGrid50.Alignment = StringAlignment.Far;
			itemGrid50.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid50.Changed = false;
			itemGrid50.FieldType = ItemType.Text;
			itemGrid50.FontColor = Color.Red;
			itemGrid50.FontStyle = FontStyle.Regular;
			itemGrid50.Height = 1f;
			itemGrid50.IsBlink = 0;
			itemGrid50.Name = "sel_vol";
			itemGrid50.Text = "";
			itemGrid50.ValueFormat = FormatType.Volume;
			itemGrid50.Visible = true;
			itemGrid50.Width = 35;
			itemGrid50.X = 25;
			itemGrid50.Y = 2.4f;
			itemGrid51.AdjustFontSize = -2f;
			itemGrid51.Alignment = StringAlignment.Far;
			itemGrid51.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid51.Changed = false;
			itemGrid51.FieldType = ItemType.Text;
			itemGrid51.FontColor = Color.Red;
			itemGrid51.FontStyle = FontStyle.Regular;
			itemGrid51.Height = 1f;
			itemGrid51.IsBlink = 0;
			itemGrid51.Name = "p_sel_vol";
			itemGrid51.Text = "";
			itemGrid51.ValueFormat = FormatType.Text;
			itemGrid51.Visible = false;
			itemGrid51.Width = 19;
			itemGrid51.X = 57;
			itemGrid51.Y = 2.4f;
			itemGrid52.AdjustFontSize = 0f;
			itemGrid52.Alignment = StringAlignment.Near;
			itemGrid52.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid52.Changed = false;
			itemGrid52.FieldType = ItemType.Text;
			itemGrid52.FontColor = Color.White;
			itemGrid52.FontStyle = FontStyle.Regular;
			itemGrid52.Height = 3.4f;
			itemGrid52.IsBlink = 0;
			itemGrid52.Name = "pie";
			itemGrid52.Text = "";
			itemGrid52.ValueFormat = FormatType.PieChartNew;
			itemGrid52.Visible = true;
			itemGrid52.Width = 40;
			itemGrid52.X = 60;
			itemGrid52.Y = 0f;
			itemGrid53.AdjustFontSize = 0f;
			itemGrid53.Alignment = StringAlignment.Near;
			itemGrid53.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid53.Changed = false;
			itemGrid53.FieldType = ItemType.Label2;
			itemGrid53.FontColor = Color.Gainsboro;
			itemGrid53.FontStyle = FontStyle.Regular;
			itemGrid53.Height = 1f;
			itemGrid53.IsBlink = 0;
			itemGrid53.Name = "lb_prior";
			itemGrid53.Text = "Prev";
			itemGrid53.ValueFormat = FormatType.Text;
			itemGrid53.Visible = true;
			itemGrid53.Width = 22;
			itemGrid53.X = 0;
			itemGrid53.Y = 3.6f;
			itemGrid54.AdjustFontSize = 0f;
			itemGrid54.Alignment = StringAlignment.Near;
			itemGrid54.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid54.Changed = false;
			itemGrid54.FieldType = ItemType.Text;
			itemGrid54.FontColor = Color.Yellow;
			itemGrid54.FontStyle = FontStyle.Regular;
			itemGrid54.Height = 1f;
			itemGrid54.IsBlink = 0;
			itemGrid54.Name = "prior";
			itemGrid54.Text = "";
			itemGrid54.ValueFormat = FormatType.Text;
			itemGrid54.Visible = true;
			itemGrid54.Width = 23;
			itemGrid54.X = 22;
			itemGrid54.Y = 3.6f;
			itemGrid55.AdjustFontSize = 0f;
			itemGrid55.Alignment = StringAlignment.Near;
			itemGrid55.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid55.Changed = false;
			itemGrid55.FieldType = ItemType.Label2;
			itemGrid55.FontColor = Color.Gainsboro;
			itemGrid55.FontStyle = FontStyle.Regular;
			itemGrid55.Height = 1f;
			itemGrid55.IsBlink = 0;
			itemGrid55.Name = "lb_avg";
			itemGrid55.Text = "Avg";
			itemGrid55.ValueFormat = FormatType.Text;
			itemGrid55.Visible = false;
			itemGrid55.Width = 25;
			itemGrid55.X = 48;
			itemGrid55.Y = 3.6f;
			itemGrid56.AdjustFontSize = 0f;
			itemGrid56.Alignment = StringAlignment.Near;
			itemGrid56.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid56.Changed = false;
			itemGrid56.FieldType = ItemType.Text;
			itemGrid56.FontColor = Color.White;
			itemGrid56.FontStyle = FontStyle.Regular;
			itemGrid56.Height = 1f;
			itemGrid56.IsBlink = 0;
			itemGrid56.Name = "avg";
			itemGrid56.Text = "";
			itemGrid56.ValueFormat = FormatType.Price;
			itemGrid56.Visible = false;
			itemGrid56.Width = 26;
			itemGrid56.X = 73;
			itemGrid56.Y = 3.6f;
			itemGrid57.AdjustFontSize = 0f;
			itemGrid57.Alignment = StringAlignment.Near;
			itemGrid57.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid57.Changed = false;
			itemGrid57.FieldType = ItemType.Label2;
			itemGrid57.FontColor = Color.Gainsboro;
			itemGrid57.FontStyle = FontStyle.Regular;
			itemGrid57.Height = 1f;
			itemGrid57.IsBlink = 0;
			itemGrid57.Name = "lbOpen";
			itemGrid57.Text = "Open-1";
			itemGrid57.ValueFormat = FormatType.Text;
			itemGrid57.Visible = true;
			itemGrid57.Width = 22;
			itemGrid57.X = 45;
			itemGrid57.Y = 4.6f;
			itemGrid58.AdjustFontSize = 0f;
			itemGrid58.Alignment = StringAlignment.Near;
			itemGrid58.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid58.Changed = false;
			itemGrid58.FieldType = ItemType.Text;
			itemGrid58.FontColor = Color.White;
			itemGrid58.FontStyle = FontStyle.Regular;
			itemGrid58.Height = 1f;
			itemGrid58.IsBlink = 0;
			itemGrid58.Name = "open1";
			itemGrid58.Text = "";
			itemGrid58.ValueFormat = FormatType.Price;
			itemGrid58.Visible = true;
			itemGrid58.Width = 31;
			itemGrid58.X = 67;
			itemGrid58.Y = 4.6f;
			itemGrid59.AdjustFontSize = 0f;
			itemGrid59.Alignment = StringAlignment.Near;
			itemGrid59.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid59.Changed = false;
			itemGrid59.FieldType = ItemType.Label2;
			itemGrid59.FontColor = Color.Gainsboro;
			itemGrid59.FontStyle = FontStyle.Regular;
			itemGrid59.Height = 1f;
			itemGrid59.IsBlink = 0;
			itemGrid59.Name = "lbOpen2";
			itemGrid59.Text = "Open-2";
			itemGrid59.ValueFormat = FormatType.Text;
			itemGrid59.Visible = true;
			itemGrid59.Width = 22;
			itemGrid59.X = 45;
			itemGrid59.Y = 5.6f;
			itemGrid60.AdjustFontSize = 0f;
			itemGrid60.Alignment = StringAlignment.Near;
			itemGrid60.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid60.Changed = false;
			itemGrid60.FieldType = ItemType.Text;
			itemGrid60.FontColor = Color.White;
			itemGrid60.FontStyle = FontStyle.Regular;
			itemGrid60.Height = 1f;
			itemGrid60.IsBlink = 0;
			itemGrid60.Name = "open2";
			itemGrid60.Text = "";
			itemGrid60.ValueFormat = FormatType.Price;
			itemGrid60.Visible = true;
			itemGrid60.Width = 31;
			itemGrid60.X = 67;
			itemGrid60.Y = 5.6f;
			itemGrid61.AdjustFontSize = 0f;
			itemGrid61.Alignment = StringAlignment.Near;
			itemGrid61.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid61.Changed = false;
			itemGrid61.FieldType = ItemType.Label2;
			itemGrid61.FontColor = Color.Gainsboro;
			itemGrid61.FontStyle = FontStyle.Regular;
			itemGrid61.Height = 1f;
			itemGrid61.IsBlink = 0;
			itemGrid61.Name = "lbHigh";
			itemGrid61.Text = "High";
			itemGrid61.ValueFormat = FormatType.Text;
			itemGrid61.Visible = true;
			itemGrid61.Width = 22;
			itemGrid61.X = 0;
			itemGrid61.Y = 4.6f;
			itemGrid62.AdjustFontSize = 0f;
			itemGrid62.Alignment = StringAlignment.Near;
			itemGrid62.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid62.Changed = false;
			itemGrid62.FieldType = ItemType.Text;
			itemGrid62.FontColor = Color.White;
			itemGrid62.FontStyle = FontStyle.Regular;
			itemGrid62.Height = 1f;
			itemGrid62.IsBlink = 0;
			itemGrid62.Name = "high";
			itemGrid62.Text = "";
			itemGrid62.ValueFormat = FormatType.Price;
			itemGrid62.Visible = true;
			itemGrid62.Width = 23;
			itemGrid62.X = 22;
			itemGrid62.Y = 4.6f;
			itemGrid63.AdjustFontSize = 0f;
			itemGrid63.Alignment = StringAlignment.Near;
			itemGrid63.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid63.Changed = false;
			itemGrid63.FieldType = ItemType.Label2;
			itemGrid63.FontColor = Color.Gainsboro;
			itemGrid63.FontStyle = FontStyle.Regular;
			itemGrid63.Height = 1f;
			itemGrid63.IsBlink = 0;
			itemGrid63.Name = "lbLow";
			itemGrid63.Text = "Low";
			itemGrid63.ValueFormat = FormatType.Text;
			itemGrid63.Visible = true;
			itemGrid63.Width = 22;
			itemGrid63.X = 0;
			itemGrid63.Y = 5.6f;
			itemGrid64.AdjustFontSize = 0f;
			itemGrid64.Alignment = StringAlignment.Near;
			itemGrid64.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid64.Changed = false;
			itemGrid64.FieldType = ItemType.Text;
			itemGrid64.FontColor = Color.White;
			itemGrid64.FontStyle = FontStyle.Regular;
			itemGrid64.Height = 1f;
			itemGrid64.IsBlink = 0;
			itemGrid64.Name = "low";
			itemGrid64.Text = "";
			itemGrid64.ValueFormat = FormatType.Price;
			itemGrid64.Visible = true;
			itemGrid64.Width = 23;
			itemGrid64.X = 22;
			itemGrid64.Y = 5.6f;
			itemGrid65.AdjustFontSize = 0f;
			itemGrid65.Alignment = StringAlignment.Near;
			itemGrid65.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid65.Changed = false;
			itemGrid65.FieldType = ItemType.Label2;
			itemGrid65.FontColor = Color.Gainsboro;
			itemGrid65.FontStyle = FontStyle.Regular;
			itemGrid65.Height = 1f;
			itemGrid65.IsBlink = 0;
			itemGrid65.Name = "lb_ceiling";
			itemGrid65.Text = "Ceiling";
			itemGrid65.ValueFormat = FormatType.Text;
			itemGrid65.Visible = true;
			itemGrid65.Width = 22;
			itemGrid65.X = 0;
			itemGrid65.Y = 6.6f;
			itemGrid66.AdjustFontSize = 0f;
			itemGrid66.Alignment = StringAlignment.Near;
			itemGrid66.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid66.Changed = false;
			itemGrid66.FieldType = ItemType.Text;
			itemGrid66.FontColor = Color.Cyan;
			itemGrid66.FontStyle = FontStyle.Regular;
			itemGrid66.Height = 1f;
			itemGrid66.IsBlink = 0;
			itemGrid66.Name = "ceiling";
			itemGrid66.Text = "";
			itemGrid66.ValueFormat = FormatType.Price;
			itemGrid66.Visible = true;
			itemGrid66.Width = 23;
			itemGrid66.X = 22;
			itemGrid66.Y = 6.6f;
			itemGrid67.AdjustFontSize = 0f;
			itemGrid67.Alignment = StringAlignment.Near;
			itemGrid67.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid67.Changed = false;
			itemGrid67.FieldType = ItemType.Label2;
			itemGrid67.FontColor = Color.Gainsboro;
			itemGrid67.FontStyle = FontStyle.Regular;
			itemGrid67.Height = 1f;
			itemGrid67.IsBlink = 0;
			itemGrid67.Name = "lb_floor";
			itemGrid67.Text = "Floor";
			itemGrid67.ValueFormat = FormatType.Text;
			itemGrid67.Visible = true;
			itemGrid67.Width = 22;
			itemGrid67.X = 0;
			itemGrid67.Y = 7.6f;
			itemGrid68.AdjustFontSize = 0f;
			itemGrid68.Alignment = StringAlignment.Near;
			itemGrid68.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid68.Changed = false;
			itemGrid68.FieldType = ItemType.Text;
			itemGrid68.FontColor = Color.FromArgb(187, 44, 189);
			itemGrid68.FontStyle = FontStyle.Regular;
			itemGrid68.Height = 1f;
			itemGrid68.IsBlink = 0;
			itemGrid68.Name = "floor";
			itemGrid68.Text = "";
			itemGrid68.ValueFormat = FormatType.Price;
			itemGrid68.Visible = true;
			itemGrid68.Width = 23;
			itemGrid68.X = 22;
			itemGrid68.Y = 7.6f;
			itemGrid69.AdjustFontSize = 0f;
			itemGrid69.Alignment = StringAlignment.Near;
			itemGrid69.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid69.Changed = false;
			itemGrid69.FieldType = ItemType.Label2;
			itemGrid69.FontColor = Color.Gainsboro;
			itemGrid69.FontStyle = FontStyle.Regular;
			itemGrid69.Height = 1f;
			itemGrid69.IsBlink = 0;
			itemGrid69.Name = "lb_par";
			itemGrid69.Text = "Par";
			itemGrid69.ValueFormat = FormatType.Text;
			itemGrid69.Visible = true;
			itemGrid69.Width = 22;
			itemGrid69.X = 45;
			itemGrid69.Y = 8.6f;
			itemGrid70.AdjustFontSize = 0f;
			itemGrid70.Alignment = StringAlignment.Near;
			itemGrid70.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid70.Changed = false;
			itemGrid70.FieldType = ItemType.Text;
			itemGrid70.FontColor = Color.Yellow;
			itemGrid70.FontStyle = FontStyle.Regular;
			itemGrid70.Height = 1f;
			itemGrid70.IsBlink = 0;
			itemGrid70.Name = "par";
			itemGrid70.Text = "";
			itemGrid70.ValueFormat = FormatType.Text;
			itemGrid70.Visible = true;
			itemGrid70.Width = 31;
			itemGrid70.X = 67;
			itemGrid70.Y = 8.6f;
			itemGrid71.AdjustFontSize = 0f;
			itemGrid71.Alignment = StringAlignment.Near;
			itemGrid71.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid71.Changed = false;
			itemGrid71.FieldType = ItemType.Label2;
			itemGrid71.FontColor = Color.Gainsboro;
			itemGrid71.FontStyle = FontStyle.Regular;
			itemGrid71.Height = 1f;
			itemGrid71.IsBlink = 0;
			itemGrid71.Name = "lbPoClose";
			itemGrid71.Text = "Prj.Close";
			itemGrid71.ValueFormat = FormatType.Text;
			itemGrid71.Visible = true;
			itemGrid71.Width = 22;
			itemGrid71.X = 45;
			itemGrid71.Y = 6.6f;
			itemGrid72.AdjustFontSize = 0f;
			itemGrid72.Alignment = StringAlignment.Near;
			itemGrid72.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid72.Changed = false;
			itemGrid72.FieldType = ItemType.Text;
			itemGrid72.FontColor = Color.White;
			itemGrid72.FontStyle = FontStyle.Regular;
			itemGrid72.Height = 1f;
			itemGrid72.IsBlink = 0;
			itemGrid72.Name = "poclose";
			itemGrid72.Text = "";
			itemGrid72.ValueFormat = FormatType.Price;
			itemGrid72.Visible = true;
			itemGrid72.Width = 31;
			itemGrid72.X = 67;
			itemGrid72.Y = 6.6f;
			itemGrid73.AdjustFontSize = 0f;
			itemGrid73.Alignment = StringAlignment.Near;
			itemGrid73.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid73.Changed = false;
			itemGrid73.FieldType = ItemType.Label2;
			itemGrid73.FontColor = Color.Gainsboro;
			itemGrid73.FontStyle = FontStyle.Regular;
			itemGrid73.Height = 1f;
			itemGrid73.IsBlink = 0;
			itemGrid73.Name = "lb_spread";
			itemGrid73.Text = "Spread";
			itemGrid73.ValueFormat = FormatType.Text;
			itemGrid73.Visible = true;
			itemGrid73.Width = 22;
			itemGrid73.X = 0;
			itemGrid73.Y = 8.6f;
			itemGrid74.AdjustFontSize = 0f;
			itemGrid74.Alignment = StringAlignment.Near;
			itemGrid74.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid74.Changed = false;
			itemGrid74.FieldType = ItemType.Text;
			itemGrid74.FontColor = Color.Yellow;
			itemGrid74.FontStyle = FontStyle.Regular;
			itemGrid74.Height = 1f;
			itemGrid74.IsBlink = 0;
			itemGrid74.Name = "spread";
			itemGrid74.Text = "";
			itemGrid74.ValueFormat = FormatType.Price;
			itemGrid74.Visible = true;
			itemGrid74.Width = 23;
			itemGrid74.X = 22;
			itemGrid74.Y = 8.6f;
			itemGrid75.AdjustFontSize = 0f;
			itemGrid75.Alignment = StringAlignment.Near;
			itemGrid75.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid75.Changed = false;
			itemGrid75.FieldType = ItemType.Label2;
			itemGrid75.FontColor = Color.Gainsboro;
			itemGrid75.FontStyle = FontStyle.Regular;
			itemGrid75.Height = 1f;
			itemGrid75.IsBlink = 0;
			itemGrid75.Name = "lb_povol";
			itemGrid75.Text = "Prj.Vol";
			itemGrid75.ValueFormat = FormatType.Text;
			itemGrid75.Visible = true;
			itemGrid75.Width = 22;
			itemGrid75.X = 45;
			itemGrid75.Y = 7.6f;
			itemGrid76.AdjustFontSize = 0f;
			itemGrid76.Alignment = StringAlignment.Near;
			itemGrid76.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid76.Changed = false;
			itemGrid76.FieldType = ItemType.Text;
			itemGrid76.FontColor = Color.Yellow;
			itemGrid76.FontStyle = FontStyle.Regular;
			itemGrid76.Height = 1f;
			itemGrid76.IsBlink = 0;
			itemGrid76.Name = "povol";
			itemGrid76.Text = "";
			itemGrid76.ValueFormat = FormatType.Text;
			itemGrid76.Visible = true;
			itemGrid76.Width = 31;
			itemGrid76.X = 67;
			itemGrid76.Y = 7.6f;
			itemGrid77.AdjustFontSize = 0f;
			itemGrid77.Alignment = StringAlignment.Near;
			itemGrid77.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid77.Changed = false;
			itemGrid77.FieldType = ItemType.Label2;
			itemGrid77.FontColor = Color.Gainsboro;
			itemGrid77.FontStyle = FontStyle.Regular;
			itemGrid77.Height = 1f;
			itemGrid77.IsBlink = 0;
			itemGrid77.Name = "lbMarginRate";
			itemGrid77.Text = "IM";
			itemGrid77.ValueFormat = FormatType.Text;
			itemGrid77.Visible = true;
			itemGrid77.Width = 22;
			itemGrid77.X = 45;
			itemGrid77.Y = 9.6f;
			itemGrid78.AdjustFontSize = 0f;
			itemGrid78.Alignment = StringAlignment.Near;
			itemGrid78.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid78.Changed = false;
			itemGrid78.FieldType = ItemType.Text;
			itemGrid78.FontColor = Color.Yellow;
			itemGrid78.FontStyle = FontStyle.Regular;
			itemGrid78.Height = 1f;
			itemGrid78.IsBlink = 0;
			itemGrid78.Name = "tbMarginRate";
			itemGrid78.Text = "";
			itemGrid78.ValueFormat = FormatType.Text;
			itemGrid78.Visible = true;
			itemGrid78.Width = 31;
			itemGrid78.X = 67;
			itemGrid78.Y = 9.6f;
			itemGrid79.AdjustFontSize = 0f;
			itemGrid79.Alignment = StringAlignment.Near;
			itemGrid79.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid79.Changed = false;
			itemGrid79.FieldType = ItemType.Label2;
			itemGrid79.FontColor = Color.Gainsboro;
			itemGrid79.FontStyle = FontStyle.Regular;
			itemGrid79.Height = 1f;
			itemGrid79.IsBlink = 0;
			itemGrid79.Name = "lb_flag";
			itemGrid79.Text = "Flag";
			itemGrid79.ValueFormat = FormatType.Text;
			itemGrid79.Visible = true;
			itemGrid79.Width = 22;
			itemGrid79.X = 0;
			itemGrid79.Y = 9.6f;
			itemGrid80.AdjustFontSize = 0f;
			itemGrid80.Alignment = StringAlignment.Near;
			itemGrid80.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid80.Changed = false;
			itemGrid80.FieldType = ItemType.Text;
			itemGrid80.FontColor = Color.Yellow;
			itemGrid80.FontStyle = FontStyle.Regular;
			itemGrid80.Height = 1f;
			itemGrid80.IsBlink = 0;
			itemGrid80.Name = "flag";
			itemGrid80.Text = "";
			itemGrid80.ValueFormat = FormatType.Text;
			itemGrid80.Visible = true;
			itemGrid80.Width = 23;
			itemGrid80.X = 22;
			itemGrid80.Y = 9.6f;
			itemGrid81.AdjustFontSize = 0f;
			itemGrid81.Alignment = StringAlignment.Near;
			itemGrid81.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid81.Changed = false;
			itemGrid81.FieldType = ItemType.Label2;
			itemGrid81.FontColor = Color.Gainsboro;
			itemGrid81.FontStyle = FontStyle.Regular;
			itemGrid81.Height = 1f;
			itemGrid81.IsBlink = 0;
			itemGrid81.Name = "lb_hl52weel";
			itemGrid81.Text = "H/L 52W";
			itemGrid81.ValueFormat = FormatType.Text;
			itemGrid81.Visible = true;
			itemGrid81.Width = 22;
			itemGrid81.X = 45;
			itemGrid81.Y = 3.6f;
			itemGrid82.AdjustFontSize = -1f;
			itemGrid82.Alignment = StringAlignment.Near;
			itemGrid82.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid82.Changed = false;
			itemGrid82.FieldType = ItemType.Text;
			itemGrid82.FontColor = Color.White;
			itemGrid82.FontStyle = FontStyle.Regular;
			itemGrid82.Height = 1f;
			itemGrid82.IsBlink = 0;
			itemGrid82.Name = "h52w";
			itemGrid82.Text = "";
			itemGrid82.ValueFormat = FormatType.Price;
			itemGrid82.Visible = true;
			itemGrid82.Width = 14;
			itemGrid82.X = 67;
			itemGrid82.Y = 3.6f;
			itemGrid83.AdjustFontSize = 0f;
			itemGrid83.Alignment = StringAlignment.Center;
			itemGrid83.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid83.Changed = false;
			itemGrid83.FieldType = ItemType.Label;
			itemGrid83.FontColor = Color.Gainsboro;
			itemGrid83.FontStyle = FontStyle.Regular;
			itemGrid83.Height = 1f;
			itemGrid83.IsBlink = 0;
			itemGrid83.Name = "lb2";
			itemGrid83.Text = "/";
			itemGrid83.ValueFormat = FormatType.Label;
			itemGrid83.Visible = true;
			itemGrid83.Width = 3;
			itemGrid83.X = 81;
			itemGrid83.Y = 3.6f;
			itemGrid84.AdjustFontSize = -1f;
			itemGrid84.Alignment = StringAlignment.Near;
			itemGrid84.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid84.Changed = false;
			itemGrid84.FieldType = ItemType.Text;
			itemGrid84.FontColor = Color.White;
			itemGrid84.FontStyle = FontStyle.Regular;
			itemGrid84.Height = 1f;
			itemGrid84.IsBlink = 0;
			itemGrid84.Name = "l52w";
			itemGrid84.Text = "";
			itemGrid84.ValueFormat = FormatType.Price;
			itemGrid84.Visible = true;
			itemGrid84.Width = 16;
			itemGrid84.X = 84;
			itemGrid84.Y = 3.6f;
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
			this.intzaInfo.Items.Add(itemGrid63);
			this.intzaInfo.Items.Add(itemGrid64);
			this.intzaInfo.Items.Add(itemGrid65);
			this.intzaInfo.Items.Add(itemGrid66);
			this.intzaInfo.Items.Add(itemGrid67);
			this.intzaInfo.Items.Add(itemGrid68);
			this.intzaInfo.Items.Add(itemGrid69);
			this.intzaInfo.Items.Add(itemGrid70);
			this.intzaInfo.Items.Add(itemGrid71);
			this.intzaInfo.Items.Add(itemGrid72);
			this.intzaInfo.Items.Add(itemGrid73);
			this.intzaInfo.Items.Add(itemGrid74);
			this.intzaInfo.Items.Add(itemGrid75);
			this.intzaInfo.Items.Add(itemGrid76);
			this.intzaInfo.Items.Add(itemGrid77);
			this.intzaInfo.Items.Add(itemGrid78);
			this.intzaInfo.Items.Add(itemGrid79);
			this.intzaInfo.Items.Add(itemGrid80);
			this.intzaInfo.Items.Add(itemGrid81);
			this.intzaInfo.Items.Add(itemGrid82);
			this.intzaInfo.Items.Add(itemGrid83);
			this.intzaInfo.Items.Add(itemGrid84);
			this.intzaInfo.LineColor = Color.Red;
			this.intzaInfo.Location = new Point(253, 26);
			this.intzaInfo.Margin = new Padding(2);
			this.intzaInfo.Name = "intzaInfo";
			this.intzaInfo.Size = new Size(265, 164);
			this.intzaInfo.TabIndex = 61;
			this.intzaInfo.TabStop = false;
			this.intzaInfo.ItemDragDrop += new IntzaCustomGrid.ItemDragDropEventHandler(this.intzaInfo_ItemDragDrop);
			this.intzaLS.AllowDrop = true;
			this.intzaLS.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaLS.CanBlink = true;
			this.intzaLS.CanDrag = false;
			this.intzaLS.CanGetMouseMove = false;
			columnItem49.Alignment = StringAlignment.Center;
			columnItem49.BackColor = Color.FromArgb(64, 64, 64);
			columnItem49.ColumnAlignment = StringAlignment.Center;
			columnItem49.FontColor = Color.LightGray;
			columnItem49.MyStyle = FontStyle.Regular;
			columnItem49.Name = "side";
			columnItem49.Text = "B/S";
			columnItem49.ValueFormat = FormatType.Text;
			columnItem49.Visible = true;
			columnItem49.Width = 13;
			columnItem50.Alignment = StringAlignment.Far;
			columnItem50.BackColor = Color.FromArgb(64, 64, 64);
			columnItem50.ColumnAlignment = StringAlignment.Center;
			columnItem50.FontColor = Color.LightGray;
			columnItem50.MyStyle = FontStyle.Regular;
			columnItem50.Name = "volume";
			columnItem50.Text = "Volume";
			columnItem50.ValueFormat = FormatType.Volume;
			columnItem50.Visible = true;
			columnItem50.Width = 36;
			columnItem51.Alignment = StringAlignment.Far;
			columnItem51.BackColor = Color.FromArgb(64, 64, 64);
			columnItem51.ColumnAlignment = StringAlignment.Center;
			columnItem51.FontColor = Color.LightGray;
			columnItem51.MyStyle = FontStyle.Regular;
			columnItem51.Name = "price";
			columnItem51.Text = "Price";
			columnItem51.ValueFormat = FormatType.Text;
			columnItem51.Visible = true;
			columnItem51.Width = 24;
			columnItem52.Alignment = StringAlignment.Far;
			columnItem52.BackColor = Color.FromArgb(64, 64, 64);
			columnItem52.ColumnAlignment = StringAlignment.Center;
			columnItem52.FontColor = Color.LightGray;
			columnItem52.MyStyle = FontStyle.Regular;
			columnItem52.Name = "time";
			columnItem52.Text = "Time";
			columnItem52.ValueFormat = FormatType.Text;
			columnItem52.Visible = true;
			columnItem52.Width = 27;
			this.intzaLS.Columns.Add(columnItem49);
			this.intzaLS.Columns.Add(columnItem50);
			this.intzaLS.Columns.Add(columnItem51);
			this.intzaLS.Columns.Add(columnItem52);
			this.intzaLS.CurrentScroll = 0;
			this.intzaLS.FocusItemIndex = -1;
			this.intzaLS.ForeColor = Color.Black;
			this.intzaLS.GridColor = Color.FromArgb(30, 30, 30);
			this.intzaLS.HeaderPctHeight = 80f;
			this.intzaLS.IsAutoRepaint = true;
			this.intzaLS.IsDrawFullRow = true;
			this.intzaLS.IsDrawGrid = false;
			this.intzaLS.IsDrawHeader = true;
			this.intzaLS.IsScrollable = false;
			this.intzaLS.Location = new Point(575, 29);
			this.intzaLS.MainColumn = "";
			this.intzaLS.Margin = new Padding(2);
			this.intzaLS.Name = "intzaLS";
			this.intzaLS.Rows = 10;
			this.intzaLS.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaLS.RowSelectType = 0;
			this.intzaLS.RowsVisible = 10;
			this.intzaLS.Size = new Size(121, 77);
			this.intzaLS.SortColumnName = "";
			this.intzaLS.SortType = SortType.Desc;
			this.intzaLS.TabIndex = 85;
			this.intzaLS.ItemDragDrop += new SortGrid.ItemDragDropEventHandler(this.intzaLS2_ItemDragDrop);
			this.intzaBF.AllowDrop = true;
			this.intzaBF.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaBF.CanDrag = false;
			this.intzaBF.IsAutoRepaint = true;
			this.intzaBF.IsDroped = false;
			itemGrid85.AdjustFontSize = 0f;
			itemGrid85.Alignment = StringAlignment.Near;
			itemGrid85.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid85.Changed = false;
			itemGrid85.FieldType = ItemType.Text;
			itemGrid85.FontColor = Color.White;
			itemGrid85.FontStyle = FontStyle.Regular;
			itemGrid85.Height = 1f;
			itemGrid85.IsBlink = 0;
			itemGrid85.Name = "item";
			itemGrid85.Text = "0";
			itemGrid85.ValueFormat = FormatType.BidOfferPct;
			itemGrid85.Visible = true;
			itemGrid85.Width = 100;
			itemGrid85.X = 0;
			itemGrid85.Y = 0f;
			this.intzaBF.Items.Add(itemGrid85);
			this.intzaBF.LineColor = Color.Red;
			this.intzaBF.Location = new Point(2, 107);
			this.intzaBF.Name = "intzaBF";
			this.intzaBF.Size = new Size(221, 17);
			this.intzaBF.TabIndex = 83;
			this.intzaTP.AllowDrop = true;
			this.intzaTP.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaTP.CanBlink = true;
			this.intzaTP.CanDrag = false;
			this.intzaTP.CanGetMouseMove = false;
			columnItem53.Alignment = StringAlignment.Far;
			columnItem53.BackColor = Color.FromArgb(45, 45, 45);
			columnItem53.ColumnAlignment = StringAlignment.Center;
			columnItem53.FontColor = Color.LightGray;
			columnItem53.MyStyle = FontStyle.Regular;
			columnItem53.Name = "bidvolume";
			columnItem53.Text = "Volume";
			columnItem53.ValueFormat = FormatType.BidOfferVolume;
			columnItem53.Visible = true;
			columnItem53.Width = 31;
			columnItem54.Alignment = StringAlignment.Far;
			columnItem54.BackColor = Color.FromArgb(45, 45, 45);
			columnItem54.ColumnAlignment = StringAlignment.Center;
			columnItem54.FontColor = Color.LightGray;
			columnItem54.MyStyle = FontStyle.Regular;
			columnItem54.Name = "bid";
			columnItem54.Text = "Bid";
			columnItem54.ValueFormat = FormatType.Text;
			columnItem54.Visible = true;
			columnItem54.Width = 19;
			columnItem55.Alignment = StringAlignment.Far;
			columnItem55.BackColor = Color.FromArgb(45, 45, 45);
			columnItem55.ColumnAlignment = StringAlignment.Center;
			columnItem55.FontColor = Color.LightGray;
			columnItem55.MyStyle = FontStyle.Regular;
			columnItem55.Name = "offer";
			columnItem55.Text = "Offer";
			columnItem55.ValueFormat = FormatType.Text;
			columnItem55.Visible = true;
			columnItem55.Width = 19;
			columnItem56.Alignment = StringAlignment.Far;
			columnItem56.BackColor = Color.FromArgb(45, 45, 45);
			columnItem56.ColumnAlignment = StringAlignment.Center;
			columnItem56.FontColor = Color.LightGray;
			columnItem56.MyStyle = FontStyle.Regular;
			columnItem56.Name = "offervolume";
			columnItem56.Text = "Volume";
			columnItem56.ValueFormat = FormatType.BidOfferVolume;
			columnItem56.Visible = true;
			columnItem56.Width = 31;
			this.intzaTP.Columns.Add(columnItem53);
			this.intzaTP.Columns.Add(columnItem54);
			this.intzaTP.Columns.Add(columnItem55);
			this.intzaTP.Columns.Add(columnItem56);
			this.intzaTP.CurrentScroll = 0;
			this.intzaTP.FocusItemIndex = -1;
			this.intzaTP.ForeColor = Color.Black;
			this.intzaTP.GridColor = Color.FromArgb(20, 20, 20);
			this.intzaTP.HeaderPctHeight = 80f;
			this.intzaTP.IsAutoRepaint = true;
			this.intzaTP.IsDrawFullRow = false;
			this.intzaTP.IsDrawGrid = false;
			this.intzaTP.IsDrawHeader = true;
			this.intzaTP.IsScrollable = false;
			this.intzaTP.Location = new Point(30, 26);
			this.intzaTP.MainColumn = "";
			this.intzaTP.Margin = new Padding(2);
			this.intzaTP.Name = "intzaTP";
			this.intzaTP.Rows = 5;
			this.intzaTP.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaTP.RowSelectType = 0;
			this.intzaTP.RowsVisible = 5;
			this.intzaTP.Size = new Size(218, 80);
			this.intzaTP.SortColumnName = "";
			this.intzaTP.SortType = SortType.Desc;
			this.intzaTP.TabIndex = 86;
			this.intzaTP.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaTP_TableMouseClick);
			this.intzaTP.ItemDragDrop += new SortGrid.ItemDragDropEventHandler(this.intzaLS2_ItemDragDrop);
			this.toolTip1.AutoPopDelay = 5000;
			this.toolTip1.InitialDelay = 300;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ReshowDelay = 500;
			this.toolTip1.ShowAlways = true;
			this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Info guide";
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
			this.wcGraphVolume.Dock = DockStyle.Fill;
			this.wcGraphVolume.FontName = "Arial";
			this.wcGraphVolume.FontSize = 10f;
			this.wcGraphVolume.Location = new Point(1, 1);
			this.wcGraphVolume.Mode = 0;
			this.wcGraphVolume.Name = "wcGraphVolume";
			this.wcGraphVolume.Size = new Size(197, 69);
			this.wcGraphVolume.SymbolList = null;
			this.wcGraphVolume.SymbolType = enumType.eSet;
			this.wcGraphVolume.TabIndex = 91;
			this.wcGraphVolume.TextBoxBgColor = Color.Empty;
			this.wcGraphVolume.TextBoxForeColor = Color.Empty;
			this.wcGraphVolume.TypeMode = enumMode.Previous;
			this.panelVolAs.BackColor = Color.Gray;
			this.panelVolAs.Controls.Add(this.btnVolAsClose);
			this.panelVolAs.Controls.Add(this.wcGraphVolume);
			this.panelVolAs.Location = new Point(732, 41);
			this.panelVolAs.Name = "panelVolAs";
			this.panelVolAs.Padding = new Padding(1);
			this.panelVolAs.Size = new Size(199, 71);
			this.panelVolAs.TabIndex = 92;
			this.panelVolAs.Visible = false;
			this.btnVolAsClose.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnVolAsClose.BackColor = Color.FromArgb(30, 30, 30);
			this.btnVolAsClose.FlatAppearance.BorderSize = 0;
			this.btnVolAsClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnVolAsClose.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnVolAsClose.FlatStyle = FlatStyle.Flat;
			this.btnVolAsClose.ForeColor = SystemColors.ControlDark;
			this.btnVolAsClose.Image = (Image)componentResourceManager.GetObject("btnVolAsClose.Image");
			this.btnVolAsClose.Location = new Point(178, 1);
			this.btnVolAsClose.Name = "btnVolAsClose";
			this.btnVolAsClose.Size = new Size(18, 18);
			this.btnVolAsClose.TabIndex = 92;
			this.btnVolAsClose.UseVisualStyleBackColor = false;
			this.btnVolAsClose.Click += new EventHandler(this.btnVolAsClose_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(963, 398);
			base.Controls.Add(this.intzaTP);
			base.Controls.Add(this.intzaInfoTFEX);
			base.Controls.Add(this.intzaInfo);
			base.Controls.Add(this.panelVolAs);
			base.Controls.Add(this.btnCloseChart);
			base.Controls.Add(this.intzaVolumeByBoard);
			base.Controls.Add(this.lbBBOLoading);
			base.Controls.Add(this.intzaLS);
			base.Controls.Add(this.intzaBF);
			base.Controls.Add(this.lbSplashInfo);
			base.Controls.Add(this.lbChartLoading);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.panelBidOffer);
			base.Controls.Add(this.tStripMenu);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Margin = new Padding(4);
			base.Name = "frmMarketWatch";
			this.Text = "Market Watch";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmMarketWatch_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmMarketWatch_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmMarketWatch_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmMarketWatch_IDoCustomSizeChanged);
			base.IDoSymbolLinked += new ClientBaseForm.OnSymbolLinkEventHandler(this.frmMarketWatch_IDoSymbolLinked);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmMarketWatch_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmMarketWatch_IDoReActivated);
			base.Controls.SetChildIndex(this.tStripMenu, 0);
			base.Controls.SetChildIndex(this.panelBidOffer, 0);
			base.Controls.SetChildIndex(this.pictureBox1, 0);
			base.Controls.SetChildIndex(this.lbChartLoading, 0);
			base.Controls.SetChildIndex(this.lbSplashInfo, 0);
			base.Controls.SetChildIndex(this.intzaBF, 0);
			base.Controls.SetChildIndex(this.intzaLS, 0);
			base.Controls.SetChildIndex(this.lbBBOLoading, 0);
			base.Controls.SetChildIndex(this.intzaVolumeByBoard, 0);
			base.Controls.SetChildIndex(this.btnCloseChart, 0);
			base.Controls.SetChildIndex(this.panelVolAs, 0);
			base.Controls.SetChildIndex(this.intzaInfo, 0);
			base.Controls.SetChildIndex(this.intzaInfoTFEX, 0);
			base.Controls.SetChildIndex(this.intzaTP, 0);
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			this.panelBidOffer.ResumeLayout(false);
			this.panelBidOffer.PerformLayout();
			this.tStripCP.ResumeLayout(false);
			this.tStripCP.PerformLayout();
			this.tStripBBO.ResumeLayout(false);
			this.tStripBBO.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.contextLink.ResumeLayout(false);
			this.panelVolAs.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x001303BC File Offset: 0x0012E7BC
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x001303E8 File Offset: 0x0012E7E8
		private bool IsInfoLoading
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isInfoLoading;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isInfoLoading = value;
				if (!base.DesignMode)
				{
					this.ShowSplashInfo(value);
				}
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00130424 File Offset: 0x0012E824
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplashInfo(bool visible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMarketWatch.ShowSplashInfoCallBack(this.ShowSplashInfo), new object[]
				{
					visible
				});
			}
			else if (!base.DesignMode)
			{
				if (ApplicationInfo.SuuportSplash == "Y")
				{
					if (visible)
					{
						this.lbSplashInfo.Left = this.intzaInfo.Left + (this.intzaInfo.Width - this.lbBBOLoading.Width) / 2;
						this.lbSplashInfo.Top = this.intzaInfo.Top + (this.intzaInfo.Height - this.lbBBOLoading.Height) / 2;
						this.lbSplashInfo.Visible = true;
						this.lbSplashInfo.BringToFront();
					}
					else
					{
						this.lbSplashInfo.Visible = false;
					}
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00130544 File Offset: 0x0012E944
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x00130570 File Offset: 0x0012E970
		private bool IsBBOLoading
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isBBOLoading;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isBBOLoading = value;
				if (!base.DesignMode)
				{
					this.ShowSplashBBO(value);
				}
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x001305AC File Offset: 0x0012E9AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplashBBO(bool visible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMarketWatch.ShowSplashBBOCallBack(this.ShowSplashBBO), new object[]
				{
					visible
				});
			}
			else if (!base.DesignMode)
			{
				if (ApplicationInfo.SuuportSplash == "Y")
				{
					if (visible)
					{
						this.lbBBOLoading.Left = this.panelBidOffer.Left + (this.panelBidOffer.Width - this.lbBBOLoading.Width) / 2;
						this.lbBBOLoading.Top = this.panelBidOffer.Top + (this.panelBidOffer.Height - this.lbBBOLoading.Height) / 2;
						this.lbBBOLoading.Visible = true;
						this.lbBBOLoading.BringToFront();
					}
					else
					{
						this.lbBBOLoading.Visible = false;
					}
				}
			}
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x001306CC File Offset: 0x0012EACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmMarketWatch() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwReloadData = null;
			this.bgwReloadDataBBO = null;
			this.bgwReloadChart = null;
			this.bgwReloadBBOExp = null;
			this._currentIsSET = true;
			this._stockInfoSET = null;
			this._seriesInfoTFEX = null;
			this.tdsMainInfo = null;
			this.tdsSector = null;
			this.tdsInstrument = null;
			this.tdsSet50Option = null;
			this.tdsTopActive = null;
			this.tdsCmpr = null;
			this.tdsMyPort = null;
			this.tdsBBOFavSET = null;
			this.tdsBBOFavTFEX = null;
			this._currentStock = string.Empty;
			this._itemsUnderlying = new List<string>();
			this.isInfoLoading = false;
			this.isBBOLoading = false;
			this._bboPage = 0;
			this._mainGroupType = string.Empty;
			this._subGroupType = string.Empty;
			this._currentBBOpage = string.Empty;
			this._set50OptList = null;
			this._lastFAV = string.Empty;
			this._lastSETsel = string.Empty;
			this._lastMAIsel = string.Empty;
			this._lastDWsel = string.Empty;
			this._lastWarrantsel = string.Empty;
			this._lastFuturesSel = string.Empty;
			this._lastOptionsSel = string.Empty;
			this._bboOptionsHeaderText = string.Empty;
			this._bboQuerySymbol = string.Empty;
			this._bboQuerySymbolTFEX = string.Empty;
			this._bboQuerySymbolSector = string.Empty;
			this.tmBBOSelectionChanged = null;
			this.tmBBOSelectionMain = null;
			this._colsEdit = string.Empty;
			this._sectorSymbol = string.Empty;
			this._expCurrentIsSET = true;
			this.tdsBBOExp = null;
			this._expStockNo = 0;
			this._expRowId = -1;
			this._expRows = 0;
			this._expSeries = "";
			this._isDWGroup = false;
			this._currentParentStock = string.Empty;
			this._chartVisible = false;
			this._frmColEdit = null;
			this._bboFocused = false;
			this._isSetMainCombo = false;
			this._isTT = string.Empty;
			this._bgwVolAs = null;
			this._volAsVisible = false;
			this.dsSaleByPrice = null;
			
			this.InitializeComponent();
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x001308E0 File Offset: 0x0012ECE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmMarketWatch(Dictionary<string, object> propertiesValue) : base(propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwReloadData = null;
			this.bgwReloadDataBBO = null;
			this.bgwReloadChart = null;
			this.bgwReloadBBOExp = null;
			this._currentIsSET = true;
			this._stockInfoSET = null;
			this._seriesInfoTFEX = null;
			this.tdsMainInfo = null;
			this.tdsSector = null;
			this.tdsInstrument = null;
			this.tdsSet50Option = null;
			this.tdsTopActive = null;
			this.tdsCmpr = null;
			this.tdsMyPort = null;
			this.tdsBBOFavSET = null;
			this.tdsBBOFavTFEX = null;
			this._currentStock = string.Empty;
			this._itemsUnderlying = new List<string>();
			this.isInfoLoading = false;
			this.isBBOLoading = false;
			this._bboPage = 0;
			this._mainGroupType = string.Empty;
			this._subGroupType = string.Empty;
			this._currentBBOpage = string.Empty;
			this._set50OptList = null;
			this._lastFAV = string.Empty;
			this._lastSETsel = string.Empty;
			this._lastMAIsel = string.Empty;
			this._lastDWsel = string.Empty;
			this._lastWarrantsel = string.Empty;
			this._lastFuturesSel = string.Empty;
			this._lastOptionsSel = string.Empty;
			this._bboOptionsHeaderText = string.Empty;
			this._bboQuerySymbol = string.Empty;
			this._bboQuerySymbolTFEX = string.Empty;
			this._bboQuerySymbolSector = string.Empty;
			this.tmBBOSelectionChanged = null;
			this.tmBBOSelectionMain = null;
			this._colsEdit = string.Empty;
			this._sectorSymbol = string.Empty;
			this._expCurrentIsSET = true;
			this.tdsBBOExp = null;
			this._expStockNo = 0;
			this._expRowId = -1;
			this._expRows = 0;
			this._expSeries = "";
			this._isDWGroup = false;
			this._currentParentStock = string.Empty;
			this._chartVisible = false;
			this._frmColEdit = null;
			this._bboFocused = false;
			this._isSetMainCombo = false;
			this._isTT = string.Empty;
			this._bgwVolAs = null;
			this._volAsVisible = false;
			this.dsSaleByPrice = null;
			
			try
			{
				this.InitializeComponent();
				this.tstbStock.Sorted = true;
				this.tstbStock.AutoCompleteMode = AutoCompleteMode.Suggest;
				this.tstbStock.AutoCompleteSource = AutoCompleteSource.ListItems;
				this.tbStockBBO.AutoCompleteMode = AutoCompleteMode.Suggest;
				this.tbStockBBO.AutoCompleteSource = AutoCompleteSource.CustomSource;
				if (ApplicationInfo.IsSupportTfex)
				{
					this.tstbStock.Items.AddRange(ApplicationInfo.MultiAutoCompStringArr);
					this.tbStockBBO.AutoCompleteCustomSource = ApplicationInfo.MultiAutoComp;
				}
				else
				{
					this.tstbStock.Items.AddRange(ApplicationInfo.StockAutoCompStringArr);
					this.tbStockBBO.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
				}
				this.bgwReloadData = new BackgroundWorker();
				this.bgwReloadData.WorkerReportsProgress = true;
				this.bgwReloadData.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
				this.bgwReloadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
				this.bgwReloadDataBBO = new BackgroundWorker();
				this.bgwReloadDataBBO.WorkerReportsProgress = true;
				this.bgwReloadDataBBO.DoWork += new DoWorkEventHandler(this.bgwReloadDataBBO_DoWork);
				this.bgwReloadDataBBO.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadDataBBO_RunWorkerCompleted);
				this.bgwReloadBBOExp = new BackgroundWorker();
				this.bgwReloadBBOExp.WorkerReportsProgress = true;
				this.bgwReloadBBOExp.DoWork += new DoWorkEventHandler(this.bgwReloadBBOExp_DoWork);
				this.bgwReloadBBOExp.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadBBOExp_RunWorkerCompleted);
				this.bgwReloadChart = new BackgroundWorker();
				this.bgwReloadChart.WorkerReportsProgress = true;
				this.bgwReloadChart.DoWork += new DoWorkEventHandler(this.bgwReloadChart_DoWork);
				this.bgwReloadChart.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadChart_RunWorkerCompleted);
				this._chartVisible = false;
				this.pictureBox1.Hide();
				this.tsbtnRefreshChart.Visible = false;
				this.tsbtnBBOAddStock.Visible = false;
				this.tsbtnBBODelStock.Visible = false;
				this.SetBlinkModeTopPrice();
				this.intzaVolumeByBoard.Records(0).Fields("h1").FontColor = Color.LightGray;
				this.intzaVolumeByBoard.Records(1).Fields("h1").FontColor = Color.LightGray;
				if (ApplicationInfo.SupportFreewill)
				{
					this.intzaInfo.Item("lbMarginRate").Visible = false;
					this.intzaInfo.Item("tbMarginRate").Visible = false;
				}
				if (!string.IsNullOrEmpty(this._colsEdit))
				{
				}
				this.tslbTfexHigh.Visible = false;
				this.tstbTfexHigh.Visible = false;
				this.tslbTfexLow.Visible = false;
				this.tstbTfexLow.Visible = false;
				this.intzaOption.Visible = false;
				this.intzaCMPR.Visible = false;
				this.tscbBBOSelectionMain.Items.Clear();
				this.tscbBBOSelectionMain.Items.Add("My Port");
				this.tscbBBOSelectionMain.Items.Add("Favorites");
				this.tscbBBOSelectionMain.Items.Add("SET");
				this.tscbBBOSelectionMain.Items.Add("MAI");
				this.tscbBBOSelectionMain.Items.Add("Warrant");
				this.tscbBBOSelectionMain.Items.Add("Derivative Warrant");
				this.tscbBBOSelectionMain.Items.Add("%CMPR");
				if (ApplicationInfo.IsSupportTfex)
				{
					this.tscbBBOSelectionMain.Items.Add("Futures");
					this.tscbBBOSelectionMain.Items.Add("Option");
				}
				if (this.tmBBOSelectionChanged == null)
				{
					this.tmBBOSelectionChanged = new Timer();
					this.tmBBOSelectionChanged.Interval = 300;
					this.tmBBOSelectionChanged.Tick += new EventHandler(this.tmBBOSelectionChanged_Tick);
				}
				if (this.tmBBOSelectionMain == null)
				{
					this.tmBBOSelectionMain = new Timer();
					this.tmBBOSelectionMain.Interval = 300;
					this.tmBBOSelectionMain.Tick += new EventHandler(this.tmBBOSelectionMain_Tick);
				}
				this.intzaInfo.Item("open_vol").FontColor = MyColor.OpenColor;
				this.intzaInfo.Item("buy_vol").FontColor = MyColor.BuyColor;
				this.intzaInfo.Item("sel_vol").FontColor = MyColor.SellColor;
				this.intzaInfo.Item("p_open_vol").FontColor = MyColor.UnChgColor;
				this.intzaInfo.Item("p_buy_vol").FontColor = MyColor.BuyColor;
				this.intzaInfo.Item("p_sel_vol").FontColor = MyColor.SellColor;
				this.intzaInfo.Item("spread").FontColor = MyColor.UnChgColor;
				this.wcGraphVolume.ColorBuy = MyColor.BuyColor;
				this.wcGraphVolume.ColorSell = MyColor.SellColor;
				this.wcGraphVolume.ColorVolume = MyColor.OpenColor;
				this.wcGraphVolume.ColorUp = MyColor.UpColor;
				this.wcGraphVolume.ColorDown = MyColor.DownColor;
				this.wcGraphVolume.ColorNoChg = MyColor.UnChgColor;
			}
			catch (Exception ex)
			{
				this.ShowError("frmMarketWatch", ex);
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x001310BC File Offset: 0x0012F4BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Dictionary<string, object> DoPackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.PropertiesValue.Clear();
				base.PropertiesValue.Add("CurrentStock", this._currentStock);
				base.PropertiesValue.Add("ActiveGroupType", this._mainGroupType);
				base.PropertiesValue.Add("SelectionText", this._currentBBOpage);
			}
			catch (Exception ex)
			{
				this.ShowError("MarketWatch.DoPackProperties", ex);
			}
			return base.PropertiesValue;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00131164 File Offset: 0x0012F564
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DoUnpackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (base.PropertiesValue != null)
				{
					if (base.PropertiesValue.ContainsKey("CurrentStock"))
					{
						ApplicationInfo.CurrentSymbol = base.PropertiesValue["CurrentStock"].ToString();
					}
					else if (this._currentStock == string.Empty)
					{
						if (base.PropertiesValue.ContainsKey("DefaultStock"))
						{
							ApplicationInfo.CurrentSymbol = base.PropertiesValue["DefaultStock"].ToString();
						}
					}
					if (base.PropertiesValue.ContainsKey("SelectionText"))
					{
						this._currentBBOpage = base.PropertiesValue["SelectionText"].ToString();
					}
					if (base.PropertiesValue.ContainsKey("ActiveGroupType"))
					{
						this._mainGroupType = base.PropertiesValue["ActiveGroupType"].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("MarketWatch.DoUnpackProperties", ex);
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x001312C0 File Offset: 0x0012F6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMarketWatch_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.IsInfoLoading = true;
			this.IsBBOLoading = true;
			this.SetResize(true, true);
			base.Show();
			this.IsInfoLoading = false;
			base.OpenedForm();
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00131300 File Offset: 0x0012F700
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMarketWatch_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.CurrentSymbol == string.Empty)
				{
					ApplicationInfo.CurrentSymbol = "BBL";
				}
				if (ApplicationInfo.MarketState == "S" || ApplicationInfo.MarketState == "P" || ApplicationInfo.MarketState == "B")
				{
					this.SwitchColumns("po");
				}
				else if (ApplicationInfo.MarketState == "M" || ApplicationInfo.MarketState == "R")
				{
					this.SwitchColumns("pc");
				}
				else
				{
					this.SwitchColumns("avg");
				}
				this.SetNewStock_Info(ApplicationInfo.CurrentSymbol, true);
				if (!ApplicationInfo.IsSupportTfex)
				{
					if (this._mainGroupType == "Futures" || this._mainGroupType == "Option")
					{
						this._mainGroupType = "Favorites";
						this._currentBBOpage = "Favorites-1";
					}
				}
				if (this._mainGroupType == string.Empty)
				{
					this._mainGroupType = "Favorites";
				}
				foreach (KeyValuePair<int, UnderlyingInfo.UnderlyingList> current in ApplicationInfo.UnderlyingInfo.Items)
				{
					this._itemsUnderlying.Add("." + current.Value.Symbol + " Futures");
				}
				this.SetBBOGroup(this._mainGroupType);
			}
			catch (Exception ex)
			{
				this.ShowError("frmMarketWatch_IDoLoadData", ex);
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00131540 File Offset: 0x0012F940
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMarketWatch_IDoCustomSizeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.IsInfoLoading)
			{
				this.SetResize(this.IsWidthChanged, this.IsHeightChanged);
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00131580 File Offset: 0x0012F980
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMarketWatch_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.IsInfoLoading)
			{
				this.SetResize(this.IsWidthChanged, this.IsHeightChanged);
				base.Show();
				this.SetNewStock_Info(ApplicationInfo.CurrentSymbol, true);
				if (this._mainGroupType == "Favorites")
				{
					if (ApplicationInfo.FavStockChanged)
					{
						this.SetBBOPage(this._currentBBOpage);
					}
				}
				this.tstbStock.Focus();
				this.tstbStock.SelectAll();
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00131624 File Offset: 0x0012FA24
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMarketWatch_IDoFontChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.IsInfoLoading)
			{
				this.SetResize(true, true);
			}
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00131658 File Offset: 0x0012FA58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMarketWatch_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			switch (e.KeyCode)
			{
			case Keys.Space:
				this.tstbStock.Focus();
				this.tstbStock.SelectAll();
				break;
			case Keys.End:
				e.SuppressKeyPress = true;
				break;
			case Keys.Home:
				if (!this.tbStockBBO.Visible)
				{
					this.ShowTextBoxPosition(e);
				}
				else
				{
					this.tbStockBBO.Hide();
				}
				break;
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x001316F8 File Offset: 0x0012FAF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmMarketWatch_IDoSymbolLinked(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (source == SymbolLinkSource.StockSymbol)
			{
				this.SetNewStock_Info(newStock, false);
			}
			else if (source == SymbolLinkSource.SwitchAccount)
			{
				if (this._mainGroupType == "My Port")
				{
					this.ReloadDataBBO();
				}
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00131764 File Offset: 0x0012FB64
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
					this.IsInfoLoading = true;
					if (this.tdsMainInfo != null)
					{
						this.tdsMainInfo.Clear();
						this.tdsMainInfo.Dispose();
					}
					this.tdsMainInfo = new DataSet();
					string text = string.Empty;
					if (this._currentIsSET)
					{
						text = ApplicationInfo.WebService.StockByPricePage(this._stockInfoSET.Number, this.intzaLS.Rows);
					}
					else
					{
						text = ApplicationInfo.WebServiceTFEX.SeriesByPricePage(this._seriesInfoTFEX.Symbol, this._seriesInfoTFEX.SeriesType, this.intzaLS.Rows);
					}
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.tdsMainInfo);
					}
					this.ReloadChart();
					this.ReloadVolAs();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_DoWork", ex);
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00131890 File Offset: 0x0012FC90
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
					if (this._currentIsSET)
					{
						this.UpdateToControl();
					}
					else
					{
						this.UpdateToControl_TFEX();
					}
					this.tdsMainInfo.Clear();
					this.IsInfoLoading = false;
				}
			}
			catch (Exception ex)
			{
				this.IsInfoLoading = false;
				this.ShowError("SecurityInfo:RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0013192C File Offset: 0x0012FD2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.IsInfoLoading && this._currentIsSET)
				{
					this.ReceiveMessageInfo(message, realtimeStockInfo);
				}
				if (!this.IsBBOLoading)
				{
					this.ReceiveMessageBBO(message, realtimeStockInfo);
				}
				if (message.MessageType == "SC")
				{
					if (this._mainGroupType == "My Port" || this._mainGroupType == "Favorites" || this._mainGroupType == "SET" || this._mainGroupType == "MAI" || this._mainGroupType == "Derivative Warrant" || this._mainGroupType == "Warrant" || this._mainGroupType == "%CMPR")
					{
						if (ApplicationInfo.MarketState == "M" || ApplicationInfo.MarketState == "R")
						{
							this.SwitchColumns("pc");
						}
						else if (ApplicationInfo.MarketState == "O" || ApplicationInfo.MarketState == "C")
						{
							this.SwitchColumns("avg");
						}
						else if (ApplicationInfo.MarketState == "P")
						{
							this.SwitchColumns("po");
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ReceiveMessage", ex);
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00131B2C File Offset: 0x0012FF2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateFromSS(StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmMarketWatch.UpdateFromSSCallBack(this.UpdateFromSS), new object[]
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
					this.intzaInfo.Item("ceiling").FontColor = MyColor.CeilingColor;
					this.intzaInfo.Item("floor").FontColor = MyColor.FloorColor;
					this.intzaInfo.Item("prior").FontColor = MyColor.UnChgColor;
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateFromSS", ex);
				}
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00131C9C File Offset: 0x0013009C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReceiveMessageInfo(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._stockInfoSET != null)
				{
					if (realtimeStockInfo != null)
					{
						string messageType = message.MessageType;
						if (messageType != null)
						{
							if (!(messageType == "TP"))
							{
								if (!(messageType == "L+"))
								{
									if (!(messageType == "PO"))
									{
										if (!(messageType == "SS"))
										{
											if (messageType == "PD")
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
										}
										else if (realtimeStockInfo.Number == this._stockInfoSET.Number)
										{
											this.UpdateFromSS(realtimeStockInfo);
											if (base.IsAllowRender)
											{
												this.intzaInfo.EndUpdate();
											}
											if (ApplicationInfo.MarketState == "S")
											{
												this.UpdateLastPrice(realtimeStockInfo.PriorPrice, "");
											}
										}
									}
									else if (realtimeStockInfo.Number == this._stockInfoSET.Number)
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
									}
								}
								else if (realtimeStockInfo.Number == this._stockInfoSET.Number)
								{
									LSAccumulate lSAccumulate = (LSAccumulate)message;
									this.UpdateLastPrice(lSAccumulate.LastPrice, lSAccumulate.ComparePrice);
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
									this.DrawTPBlinkColor(lSAccumulate);
									if (this._volAsVisible)
									{
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
								}
							}
							else if (realtimeStockInfo.Number == this._stockInfoSET.Number)
							{
								TPMessage tPMessage = (TPMessage)message;
								this.UpdateTopPriceInfo(tPMessage.Side, tPMessage.Price1, tPMessage.Price2, tPMessage.Price3, tPMessage.Price4, tPMessage.Price5, tPMessage.Volume1 * (long)this._stockInfoSET.BoardLot, tPMessage.Volume2 * (long)this._stockInfoSET.BoardLot, tPMessage.Volume3 * (long)this._stockInfoSET.BoardLot, tPMessage.Volume4 * (long)this._stockInfoSET.BoardLot, tPMessage.Volume5 * (long)this._stockInfoSET.BoardLot);
								if (base.IsAllowRender)
								{
									this.intzaTP.EndUpdate();
									this.intzaBF.Redraw();
								}
							}
						}
					}
					else if (message.MessageType == "IE")
					{
						IEMessage iEMessage = (IEMessage)message;
						if (iEMessage.Symbol == this._sectorSymbol && iEMessage.OriginalNumber == this._stockInfoSET.SectorNumber)
						{
							IndexStat.IndexItem sector = ApplicationInfo.IndexStatInfo.GetSector(this._stockInfoSET.SectorNumber);
							this.UpdateSector(iEMessage.IndexValue, sector.IndexChg, sector.IndexChgPct);
						}
					}
					else if (message.MessageType == "SC")
					{
						this.UpdateProjectedVolume(-1L);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SecurityInfo::RecvMessage", ex);
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0013234C File Offset: 0x0013074C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawTPBlinkColor(LSAccumulate msgLS)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaTP.InvokeRequired)
			{
				this.intzaTP.Invoke(new frmMarketWatch.DrawTPBlinkColorCallBack(this.DrawTPBlinkColor), new object[]
				{
					msgLS
				});
			}
			else
			{
				try
				{
					if (ApplicationInfo.IsSupportTPBlinkColor)
					{
						int isBlink = 3;
						if (msgLS.Side == "S")
						{
							string b = Utilities.PriceFormat(msgLS.LastPrice);
							for (int i = 0; i < 5; i++)
							{
								if (this.intzaTP.Records(i).Fields("bidvolume").TempText == b)
								{
									this.intzaTP.Records(i).Fields("bidvolume").IsBlink = isBlink;
									break;
								}
							}
						}
						else if (msgLS.Side == "B")
						{
							string b = Utilities.PriceFormat(msgLS.LastPrice);
							for (int i = 0; i < 5; i++)
							{
								if (this.intzaTP.Records(i).Fields("offervolume").TempText == b)
								{
									this.intzaTP.Records(i).Fields("offervolume").IsBlink = isBlink;
									break;
								}
							}
						}
						if (base.IsAllowRender)
						{
							this.intzaTP.EndUpdate();
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("DrawTPBlinkColor", ex);
				}
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00132558 File Offset: 0x00130958
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReceiveMessageBBO(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string messageType = message.MessageType;
				if (messageType != null)
				{
					if (!(messageType == "TP"))
					{
						if (!(messageType == "L+"))
						{
							if (!(messageType == "SS"))
							{
								if (messageType == "PO")
								{
									int num;
									if (this._mainGroupType == "Favorites")
									{
										num = ApplicationInfo.FavStockList[this._bboPage].IndexOf(realtimeStockInfo.Symbol);
									}
									else
									{
										num = this.intzaBBO.FindIndex("stock", realtimeStockInfo.Symbol);
									}
									if (num > -1)
									{
										POMessage pOMessage = (POMessage)message;
										if (ApplicationInfo.MarketState == "M")
										{
											this.UpdateBBOPreClosePrice(num, pOMessage.ProjectedPrice, realtimeStockInfo);
										}
										else
										{
											this.UpdateBBOPreOpenPrice(num, pOMessage.ProjectedPrice, realtimeStockInfo);
										}
										if (base.IsAllowRender)
										{
											this.intzaBBO.EndUpdate(num);
										}
									}
								}
							}
							else if (realtimeStockInfo != null)
							{
								int num2;
								if (this._mainGroupType == "Favorites")
								{
									num2 = ApplicationInfo.FavStockList[this._bboPage].IndexOf(realtimeStockInfo.Symbol);
								}
								else
								{
									num2 = this.intzaBBO.FindIndex("stock", realtimeStockInfo.Symbol);
								}
								if (num2 > -1)
								{
									this.intzaBBO.Records(num2).Fields("prior").Text = realtimeStockInfo.PriorPrice;
									this.ShowDisplayFlagBBO(num2, realtimeStockInfo.DisplayFlag);
									if (base.IsAllowRender)
									{
										this.intzaBBO.EndUpdate(num2);
									}
								}
							}
						}
						else if (realtimeStockInfo != null)
						{
							int num3;
							if (this._mainGroupType == "Favorites")
							{
								num3 = ApplicationInfo.FavStockList[this._bboPage].IndexOf(realtimeStockInfo.Symbol);
							}
							else
							{
								num3 = this.intzaBBO.FindIndex("stock", realtimeStockInfo.Symbol);
							}
							if (num3 > -1)
							{
								LSAccumulate lSAccumulate = (LSAccumulate)message;
								this.ShowDisplayFlagBBO(num3, realtimeStockInfo.DisplayFlag);
								this.UpdateBBO_LS(num3, lSAccumulate.LastPrice, lSAccumulate.AccVolume * (long)realtimeStockInfo.BoardLot, lSAccumulate.AccValue, lSAccumulate.DealInMain, lSAccumulate.ComparePrice, realtimeStockInfo.HighPrice, realtimeStockInfo.LowPrice, lSAccumulate.BuyVolume * (long)realtimeStockInfo.BoardLot, lSAccumulate.SellVolume * (long)realtimeStockInfo.BoardLot, realtimeStockInfo);
								this.ShowUnderLineBBO(num3, lSAccumulate.LastPrice, realtimeStockInfo.BidPrice1, realtimeStockInfo.OfferPrice1);
								if (base.IsAllowRender)
								{
									this.intzaBBO.EndUpdate(num3);
								}
								this.DrawTPBBoBlink(num3, lSAccumulate);
							}
						}
					}
					else if (realtimeStockInfo != null)
					{
						int num4;
						if (this._mainGroupType == "Favorites")
						{
							num4 = ApplicationInfo.FavStockList[this._bboPage].IndexOf(realtimeStockInfo.Symbol);
						}
						else
						{
							num4 = this.intzaBBO.FindIndex("stock", realtimeStockInfo.Symbol);
						}
						if (num4 > -1)
						{
							TPMessage tPMessage = (TPMessage)message;
							if (tPMessage.Price1 > -1m)
							{
								this.UpdateBBOTopPrice(num4, tPMessage.Side, tPMessage.Price1, tPMessage.Volume1 * (long)realtimeStockInfo.BoardLot, realtimeStockInfo.PriorPrice, realtimeStockInfo.LastSalePrice, realtimeStockInfo);
							}
							if (tPMessage.Side == "B")
							{
								realtimeStockInfo.TotBidVol = (tPMessage.Volume1 + tPMessage.Volume2 + tPMessage.Volume3 + tPMessage.Volume4 + tPMessage.Volume5) * (long)realtimeStockInfo.BoardLot;
							}
							else
							{
								realtimeStockInfo.TotOfferVol = (tPMessage.Volume1 + tPMessage.Volume2 + tPMessage.Volume3 + tPMessage.Volume4 + tPMessage.Volume5) * (long)realtimeStockInfo.BoardLot;
							}
							this.UpdateBidOfferVolPct(num4, realtimeStockInfo.TotBidVol, realtimeStockInfo.TotOfferVol);
							if (this.intzaBBO.Records(num4).Rows > 1)
							{
								this.UpdateBBOBids(this.intzaBBO.Records(num4), realtimeStockInfo, tPMessage.Side, tPMessage.Price2, tPMessage.Volume2 * (long)realtimeStockInfo.BoardLot, tPMessage.Price3, tPMessage.Volume3 * (long)realtimeStockInfo.BoardLot, tPMessage.Price4, tPMessage.Volume4 * (long)realtimeStockInfo.BoardLot, tPMessage.Price5, tPMessage.Volume5 * (long)realtimeStockInfo.BoardLot);
							}
							if (base.IsAllowRender)
							{
								this.intzaBBO.EndUpdate(num4);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SecurityInfo::RecvMessage", ex);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00132B1C File Offset: 0x00130F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawTPBBoBlink(int indexBBO, LSAccumulate msgLS)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsSupportTPBlinkColor)
				{
					if (msgLS.Side != string.Empty)
					{
						if (indexBBO > -1 && indexBBO < ApplicationInfo.FavStockPerPage)
						{
							int isBlink = 3;
							STIControl.ExpandTableGrid.RecordItem recordItem = this.intzaBBO.Records(indexBBO);
							decimal d = 0m;
							decimal.TryParse(recordItem.Fields("bid").Text.ToString(), out d);
							if (msgLS.LastPrice == d)
							{
								recordItem.Fields("bidvol").IsBlink = isBlink;
								if (base.IsAllowRender)
								{
									this.intzaBBO.EndUpdate(indexBBO);
								}
							}
							else
							{
								d = 0m;
								decimal.TryParse(recordItem.Fields("offer").Text.ToString(), out d);
								if (msgLS.LastPrice == d)
								{
									recordItem.Fields("offvol").IsBlink = isBlink;
									if (base.IsAllowRender)
									{
										this.intzaBBO.EndUpdate(indexBBO);
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("DrawTPBBoBlink", ex);
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00132CBC File Offset: 0x001310BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadData()
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

		// Token: 0x06001609 RID: 5641 RVA: 0x00132CF8 File Offset: 0x001310F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl()
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
				this.intzaTP.BeginUpdate();
				this.intzaInfo.ClearAllText();
				this.intzaLS.ClearAllText();
				this.intzaVolumeByBoard.ClearAllText();
				this.intzaTP.ClearAllText();
				this.intzaBF.ClearAllText();
				if (this.tdsMainInfo.Tables.Count > 0)
				{
					this.setTopPriceColume(true);
					if (this.tdsMainInfo.Tables.Contains("security_stat") && this.tdsMainInfo.Tables["security_stat"].Rows.Count > 0)
					{
						DataRow dataRow = this.tdsMainInfo.Tables["security_stat"].Rows[0];
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
						if (this.tdsMainInfo.Tables["security_stat"].Columns.Contains("high52w"))
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
						this.UpdateTopPriceInfo("B", Convert.ToDecimal(dataRow["bid_price1"].ToString()), Convert.ToDecimal(dataRow["bid_price2"].ToString()), Convert.ToDecimal(dataRow["bid_price3"].ToString()), Convert.ToDecimal(dataRow["bid_price4"].ToString()), Convert.ToDecimal(dataRow["bid_price5"].ToString()), Convert.ToInt64(dataRow["bid_volume1"]), Convert.ToInt64(dataRow["bid_volume2"]), Convert.ToInt64(dataRow["bid_volume3"]), Convert.ToInt64(dataRow["bid_volume4"]), Convert.ToInt64(dataRow["bid_volume5"]));
						this.UpdateTopPriceInfo("S", Convert.ToDecimal(dataRow["offer_price1"].ToString()), Convert.ToDecimal(dataRow["offer_price2"].ToString()), Convert.ToDecimal(dataRow["offer_price3"].ToString()), Convert.ToDecimal(dataRow["offer_price4"].ToString()), Convert.ToDecimal(dataRow["offer_price5"].ToString()), Convert.ToInt64(dataRow["offer_volume1"]), Convert.ToInt64(dataRow["offer_volume2"]), Convert.ToInt64(dataRow["offer_volume3"]), Convert.ToInt64(dataRow["offer_volume4"]), Convert.ToInt64(dataRow["offer_volume5"]));
						if (this._stockInfoSET.SecurityType == "W")
						{
							this.intzaInfo.Item("lb_par").Text = "Expire";
							this.intzaInfo.Item("par").Text = Utilities.GetDateFormat(this.tdsMainInfo.Tables["security_info"].Rows[0]["warrant_expire"].ToString());
						}
						else
						{
							this.intzaInfo.Item("lb_par").Text = "Par";
							this.intzaInfo.Item("par").Text = Utilities.PriceFormat(dataRow["par_value"], 5);
							this.intzaInfo.Item("par").FontColor = MyColor.UnChgColor;
						}
						this.intzaInfo.Item("flag").Text = dataRow["display_flag"].ToString();
						this.intzaInfo.Item("flag").FontColor = MyColor.UnChgColor;
						decimal num2 = 0m;
						decimal num3 = 0m;
						decimal pchg = 0m;
						IndexStat.IndexItem sector = ApplicationInfo.IndexStatInfo.GetSector(this._stockInfoSET.SectorNumber);
						if (sector != null)
						{
							this._sectorSymbol = sector.Symbol;
							this.tsSectorName.Text = sector.Symbol;
							decimal prior = sector.Prior;
							if (decimal.TryParse(dataRow["sector_index"].ToString(), out num2))
							{
								if (num2 > 0m && prior > 0m)
								{
									num3 = num2 - prior;
									pchg = num3 / prior * 100m;
								}
								else
								{
									num2 = prior;
								}
							}
						}
						else
						{
							this._sectorSymbol = string.Empty;
							this.tsSectorName.Text = string.Empty;
						}
						this.UpdateSector(num2, num3, pchg);
						this._stockInfoSET.LastSalePrice = Convert.ToDecimal(dataRow["last_sale_price"]);
						this._stockInfoSET.HighPrice = Convert.ToDecimal(dataRow["high_price"]);
						this._stockInfoSET.LowPrice = Convert.ToDecimal(dataRow["low_price"]);
						this.UpdateLastPrice(this._stockInfoSET.LastSalePrice, dataRow["compare_price"].ToString());
						this.UpdatePriceInfo(this._stockInfoSET.LastSalePrice, this._stockInfoSET.HighPrice, this._stockInfoSET.LowPrice);
						this.intzaInfo.Item("povol").FontColor = MyColor.UnChgColor;
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
						if (this.tdsMainInfo.Tables.Contains("last_sale"))
						{
							int num4 = 0;
							foreach (DataRow dataRow2 in this.tdsMainInfo.Tables["last_sale"].Rows)
							{
								this.UpdateStockTicker(Convert.ToDecimal(dataRow2["price"]), dataRow2["side"].ToString(), Convert.ToInt64(dataRow2["volume"]), dataRow2["last_update"].ToString(), num4);
								num4++;
							}
						}
						this.UpdateBigLotValue(Convert.ToInt32(dataRow["deal_in_biglot"]), Convert.ToDecimal(dataRow["biglot_accvalue"]), Convert.ToInt64(dataRow["biglot_accvolume"]));
						this.intzaInfo.Item("tbMarginRate").Text = Utilities.PriceFormat(dataRow["margin_rate"], "%");
						dataRow = null;
					}
					else
					{
						this.tsPrice.Text = Utilities.PriceFormat(this._stockInfoSET.PriorPrice) + "           ";
						this.tsPrice.ForeColor = MyColor.UnChgColor;
					}
				}
				this.intzaTP.Redraw();
				this.intzaVolumeByBoard.Redraw();
				this.intzaInfo.Redraw();
				this.intzaLS.Redraw();
				this.intzaBF.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl", ex);
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00133960 File Offset: 0x00131D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateTopPriceInfo(string side, decimal price1, decimal price2, decimal price3, decimal price4, decimal price5, long volume1, long volume2, long volume3, long volume4, long volume5)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Color fontColor = MyColor.UnChgColor;
				if (side == "B")
				{
					if (price1 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price1, this._stockInfoSET);
						this.intzaTP.Records(0).Fields("bidvolume").SetBidOfferVolumeText(volume1.ToString(), price1);
						this.intzaTP.Records(0).Fields("bidvolume").FontColor = fontColor;
						this.intzaTP.Records(0).Fields("bid").Text = Utilities.BidOfferPriceFormat(price1, volume1);
						this.intzaTP.Records(0).Fields("bid").FontColor = fontColor;
					}
					if (price2 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price2, this._stockInfoSET);
						this.intzaTP.Records(1).Fields("bidvolume").SetBidOfferVolumeText(volume2.ToString(), price2);
						this.intzaTP.Records(1).Fields("bidvolume").FontColor = fontColor;
						this.intzaTP.Records(1).Fields("bid").Text = Utilities.PriceFormat(price2);
						this.intzaTP.Records(1).Fields("bid").FontColor = fontColor;
					}
					if (price3 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price3, this._stockInfoSET);
						this.intzaTP.Records(2).Fields("bidvolume").SetBidOfferVolumeText(volume3.ToString(), price3);
						this.intzaTP.Records(2).Fields("bidvolume").FontColor = fontColor;
						this.intzaTP.Records(2).Fields("bid").Text = Utilities.PriceFormat(price3);
						this.intzaTP.Records(2).Fields("bid").FontColor = fontColor;
					}
					if (price4 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price4, this._stockInfoSET);
						this.intzaTP.Records(3).Fields("bidvolume").SetBidOfferVolumeText(volume4.ToString(), price4);
						this.intzaTP.Records(3).Fields("bidvolume").FontColor = fontColor;
						this.intzaTP.Records(3).Fields("bid").Text = Utilities.PriceFormat(price4);
						this.intzaTP.Records(3).Fields("bid").FontColor = fontColor;
					}
					if (price5 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price5, this._stockInfoSET);
						this.intzaTP.Records(4).Fields("bidvolume").SetBidOfferVolumeText(volume5.ToString(), price5);
						this.intzaTP.Records(4).Fields("bidvolume").FontColor = fontColor;
						this.intzaTP.Records(4).Fields("bid").Text = Utilities.PriceFormat(price5);
						this.intzaTP.Records(4).Fields("bid").FontColor = fontColor;
					}
				}
				else if (side == "S")
				{
					if (price1 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price1, this._stockInfoSET);
						this.intzaTP.Records(0).Fields("offervolume").SetBidOfferVolumeText(volume1.ToString(), price1);
						this.intzaTP.Records(0).Fields("offervolume").FontColor = fontColor;
						this.intzaTP.Records(0).Fields("offer").Text = Utilities.BidOfferPriceFormat(price1, volume1);
						this.intzaTP.Records(0).Fields("offer").FontColor = fontColor;
					}
					if (price2 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price2, this._stockInfoSET);
						this.intzaTP.Records(1).Fields("offervolume").SetBidOfferVolumeText(volume2.ToString(), price2);
						this.intzaTP.Records(1).Fields("offervolume").FontColor = fontColor;
						this.intzaTP.Records(1).Fields("offer").Text = Utilities.PriceFormat(price2);
						this.intzaTP.Records(1).Fields("offer").FontColor = fontColor;
					}
					if (price3 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price3, this._stockInfoSET);
						this.intzaTP.Records(2).Fields("offervolume").SetBidOfferVolumeText(volume3.ToString(), price3);
						this.intzaTP.Records(2).Fields("offervolume").FontColor = fontColor;
						this.intzaTP.Records(2).Fields("offer").Text = Utilities.PriceFormat(price3);
						this.intzaTP.Records(2).Fields("offer").FontColor = fontColor;
					}
					if (price4 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price4, this._stockInfoSET);
						this.intzaTP.Records(3).Fields("offervolume").SetBidOfferVolumeText(volume4.ToString(), price4);
						this.intzaTP.Records(3).Fields("offervolume").FontColor = fontColor;
						this.intzaTP.Records(3).Fields("offer").Text = Utilities.PriceFormat(price4);
						this.intzaTP.Records(3).Fields("offer").FontColor = fontColor;
					}
					if (price5 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price5, this._stockInfoSET);
						this.intzaTP.Records(4).Fields("offervolume").SetBidOfferVolumeText(volume5.ToString(), price5);
						this.intzaTP.Records(4).Fields("offervolume").FontColor = fontColor;
						this.intzaTP.Records(4).Fields("offer").Text = Utilities.PriceFormat(price5);
						this.intzaTP.Records(4).Fields("offer").FontColor = fontColor;
					}
				}
				if (side == "B")
				{
					this._stockInfoSET.TotBidVol = volume1 + volume2 + volume3 + volume4 + volume5;
				}
				else
				{
					this._stockInfoSET.TotOfferVol = volume1 + volume2 + volume3 + volume4 + volume5;
				}
				if (this._stockInfoSET.TotBidVol + this._stockInfoSET.TotOfferVol > 0L)
				{
					this.intzaBF.Item("item").Text = Utilities.PriceFormat(this._stockInfoSET.TotBidVol / (this._stockInfoSET.TotBidVol + this._stockInfoSET.TotOfferVol) * 100m, 2, "0");
				}
				else
				{
					this.intzaBF.Item("item").Text = "";
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateTopPrice", ex);
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0013419C File Offset: 0x0013259C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateOpenOrProjectOpenPrice(string state, int session, decimal price)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmMarketWatch.UpdateOpenOrProjectOpenPriceCallBack(this.UpdateOpenOrProjectOpenPrice), new object[]
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

		// Token: 0x0600160C RID: 5644 RVA: 0x001344AC File Offset: 0x001328AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateProjectedVolume(long volume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmMarketWatch.UpdateProjectedVolumeCallBack(this.UpdateProjectedVolume), new object[]
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

		// Token: 0x0600160D RID: 5645 RVA: 0x001345E4 File Offset: 0x001329E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateProjectedClosePrice(decimal closePrice)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmMarketWatch.UpdateProjectedClosePriceCallBack(this.UpdateProjectedClosePrice), new object[]
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

		// Token: 0x0600160E RID: 5646 RVA: 0x0013479C File Offset: 0x00132B9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateAllVolume(int deals, long accVolume, decimal accValue, long openVolume, long buyVolume, long sellVolume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmMarketWatch.UpdateAllVolumeCallBack(this.UpdateAllVolume), new object[]
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
					decimal price = 0m;
					decimal num = 0m;
					decimal num2 = 0m;
					decimal num3 = 0m;
					if (accVolume > 0L)
					{
						price = Math.Round(accValue / accVolume, 2);
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
					this.tstbTfexAvg.Text = price.ToString();
					this.tstbTfexAvg.ForeColor = Utilities.ComparePriceCFColor(price, this._stockInfoSET);
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateAllVolume", ex);
				}
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00134A78 File Offset: 0x00132E78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateSector(decimal price, decimal chg, decimal pchg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tStripMenu.InvokeRequired)
			{
				this.tStripMenu.Invoke(new frmMarketWatch.UpdateSectorCallBack(this.UpdateSector), new object[]
				{
					price,
					chg,
					pchg
				});
			}
			else
			{
				try
				{
					Color foreColor = Utilities.ComparePriceColor(chg, 0m);
					this.tsSectorIndex.Text = string.Concat(new string[]
					{
						Utilities.PriceFormat(price),
						"   ",
						Utilities.PriceFormat(chg, true, ""),
						"   ",
						Utilities.PriceFormat(pchg, true, "%")
					});
					this.tsSectorIndex.ForeColor = foreColor;
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateSector", ex);
				}
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00134B9C File Offset: 0x00132F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateLastPrice(decimal lastPrice, string comparePrice)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tStripMenu.InvokeRequired)
			{
				this.tStripMenu.Invoke(new frmMarketWatch.UpdateLastPriceCallBack(this.UpdateLastPrice), new object[]
				{
					lastPrice,
					comparePrice
				});
			}
			else
			{
				try
				{
					if (this._currentIsSET)
					{
						if (this._stockInfoSET != null)
						{
							if (lastPrice == 0m)
							{
								lastPrice = this._stockInfoSET.PriorPrice;
							}
							Color foreColor = Utilities.ComparePriceCFColor(lastPrice, this._stockInfoSET);
							this.tsPrice.Text = string.Concat(new string[]
							{
								Utilities.PriceFormat(lastPrice),
								"   ",
								Utilities.PriceFormat(this._stockInfoSET.ChangePrice, true, ""),
								"   ",
								Utilities.PriceFormat(this._stockInfoSET.ChangePricePct, true, "%")
							});
							this.tsPrice.ForeColor = foreColor;
							if (comparePrice == "+")
							{
								this.tslbCompare.Text = "้";
								this.tslbCompare.ForeColor = MyColor.UpColor;
							}
							else if (comparePrice == "-")
							{
								this.tslbCompare.Text = "๊";
								this.tslbCompare.ForeColor = Color.Red;
							}
							else
							{
								this.tslbCompare.Text = "";
							}
						}
					}
					else if (this._seriesInfoTFEX != null)
					{
						Color foreColor = MyColor.UnChgColor;
						if (lastPrice == 0m)
						{
							lastPrice = this._seriesInfoTFEX.PrevFixPrice;
						}
						decimal num = 0m;
						decimal num2 = 0m;
						if (this._seriesInfoTFEX.PrevFixPrice > 0m && lastPrice > 0m)
						{
							num = lastPrice - this._seriesInfoTFEX.PrevFixPrice;
							num2 = (lastPrice - this._seriesInfoTFEX.PrevFixPrice) / this._seriesInfoTFEX.PrevFixPrice * 100m;
						}
						foreColor = Utilities.ComparePriceCFColor(lastPrice, this._seriesInfoTFEX);
						this.tsPrice.Text = string.Concat(new string[]
						{
							Utilities.PriceFormat(lastPrice, this._seriesInfoTFEX.NumOfDec),
							"   ",
							Utilities.PriceFormat(num, true, this._seriesInfoTFEX.NumOfDec),
							"   ",
							Utilities.PriceFormat(num2, true, "%")
						});
						this.tsPrice.ForeColor = foreColor;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateLastPrice", ex);
				}
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00134F14 File Offset: 0x00133314
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePriceInfo(decimal lastPrice, decimal high, decimal low)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaInfo.InvokeRequired)
			{
				this.intzaInfo.Invoke(new frmMarketWatch.UpdatePriceInfoCallBack(this.UpdatePriceInfo), new object[]
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

		// Token: 0x06001612 RID: 5650 RVA: 0x00135070 File Offset: 0x00133470
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateStockTicker(decimal price, string side, long volume, string lastUpdate, int index)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaLS.InvokeRequired)
			{
				this.intzaLS.Invoke(new frmMarketWatch.UpdateLastSaleTickerInfoCallBack(this.UpdateStockTicker), new object[]
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
					STIControl.SortTableGrid.RecordItem recordItem;
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

		// Token: 0x06001613 RID: 5651 RVA: 0x001352BC File Offset: 0x001336BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateMainBoardValue(int deals, long accVolume, decimal accValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaVolumeByBoard.InvokeRequired)
			{
				this.intzaVolumeByBoard.Invoke(new frmMarketWatch.UpdateMainBoardValueCallBack(this.UpdateMainBoardValue), new object[]
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

		// Token: 0x06001614 RID: 5652 RVA: 0x00135450 File Offset: 0x00133850
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBigLotValue(int bDeal, decimal bValue, long bVolume)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaVolumeByBoard.InvokeRequired)
			{
				this.intzaVolumeByBoard.Invoke(new frmMarketWatch.UpdateBigLotValueCallBack(this.UpdateBigLotValue), new object[]
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

		// Token: 0x06001615 RID: 5653 RVA: 0x001355E4 File Offset: 0x001339E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_KeyUp(object sender, KeyEventArgs e)
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
					if (keyCode != Keys.End)
					{
					}
				}
				else
				{
					this.SetNewStock_Info(this.tstbStock.Text.Trim(), true);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tstbStock_KeyUp", ex);
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x0013566C File Offset: 0x00133A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_KeyPress(object sender, KeyPressEventArgs e)
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
				this.ShowError("tstbStock_KeyPress", ex);
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x001356D4 File Offset: 0x00133AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Keys keyCode = e.KeyCode;
				switch (keyCode)
				{
				case Keys.Prior:
				case Keys.Next:
				case Keys.Home:
				case Keys.Up:
				case Keys.Down:
					break;
				case Keys.End:
				case Keys.Left:
				case Keys.Right:
					goto IL_65;
				default:
					if (keyCode != Keys.Subtract && keyCode != Keys.NumLock)
					{
						goto IL_65;
					}
					break;
				}
				e.SuppressKeyPress = true;
				IL_65:;
			}
			catch (Exception ex)
			{
				this.ShowError("tstbStock_KeyDown", ex);
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00135774 File Offset: 0x00133B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetNewStock_Info(string stockSymbol, bool isFocus)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tStripMenu.InvokeRequired)
			{
				this.tStripMenu.Invoke(new frmMarketWatch.SetNewStockInfoCallBack(this.SetNewStock_Info), new object[]
				{
					stockSymbol,
					isFocus
				});
			}
			else
			{
				try
				{
					if (!this.IsInfoLoading)
					{
						if ((stockSymbol != string.Empty && stockSymbol != this._currentStock) || ApplicationInfo.IsResumeState)
						{
							StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stockSymbol];
							if (stockInformation.Number > 0)
							{
								this._stockInfoSET = stockInformation;
								this._seriesInfoTFEX = null;
								ApplicationInfo.CurrentSymbol = this._stockInfoSET.Symbol;
								ApplicationInfo.CurrStockInMktWatch = this._stockInfoSET.Symbol;
								this._currentStock = this._stockInfoSET.Symbol;
								TemplateManager.Instance.SendSymbolLink(this, SymbolLinkSource.SmartStock, this._currentStock);
								this.intzaInfo.Visible = true;
								this.intzaInfoTFEX.Visible = false;
								this.tStripBBO.SuspendLayout();
								this.tsSectorName.Visible = true;
								this.tsSectorIndex.Visible = true;
								this.tsbtnHChart.Visible = true;
								this.tsbtnSETNews.Visible = true;
								this.tsbtnVolAs.Visible = true;
								this.tslbTfexHigh.Visible = false;
								this.tstbTfexHigh.Visible = false;
								this.tslbTfexLow.Visible = false;
								this.tstbTfexLow.Visible = false;
								this.tStripBBO.ResumeLayout();
								this._currentIsSET = true;
								this.ReloadData();
							}
							else
							{
								SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[stockSymbol];
								if (seriesInformation != null & seriesInformation.Symbol != string.Empty)
								{
									this._stockInfoSET = null;
									this._currentIsSET = false;
									this._seriesInfoTFEX = seriesInformation;
									ApplicationInfo.CurrentSymbol = seriesInformation.Symbol;
									this._currentStock = seriesInformation.Symbol;
									this.intzaInfoTFEX.Visible = true;
									this.intzaInfo.Visible = false;
									this.tStripBBO.SuspendLayout();
									this.tsSectorName.Visible = false;
									this.tsSectorIndex.Visible = false;
									this.tsbtnHChart.Visible = false;
									this.tsbtnSETNews.Visible = false;
									this.tsbtnVolAs.Visible = false;
									this._volAsVisible = false;
									this.panelVolAs.Hide();
									this.tslbTfexHigh.Visible = true;
									this.tstbTfexHigh.Visible = true;
									this.tslbTfexLow.Visible = true;
									this.tstbTfexLow.Visible = true;
									this.tStripBBO.ResumeLayout();
									this.ReloadData();
								}
							}
						}
						if (this.tstbStock.Text != this._currentStock)
						{
							this.tstbStock.Text = this._currentStock;
							if (!ApplicationInfo.IsOrderBoxFocus && isFocus)
							{
								this.tstbStock.Focus();
								this.tstbStock.SelectAll();
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SetNewStockInfo", ex);
				}
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00135B20 File Offset: 0x00133F20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControlFav_BBO(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ds.Tables.Count > 0 && ds.Tables["security_info_stat"].Rows.Count > 0)
				{
					this.intzaBBO.BeginUpdate();
					decimal price = 0m;
					decimal price2 = 0m;
					foreach (DataRow dataRow in ds.Tables["security_info_stat"].Rows)
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[Convert.ToInt32(dataRow["security_number"])];
						int num = ApplicationInfo.FavStockList[this._bboPage].IndexOf(stockInformation.Symbol);
						if (num > -1)
						{
							this.intzaBBO.Records(num).Fields("stock").Text = stockInformation.Symbol;
							stockInformation.LastSalePrice = Convert.ToDecimal(dataRow["last_sale_price"].ToString());
							stockInformation.HighPrice = Convert.ToDecimal(dataRow["high_price"].ToString());
							stockInformation.LowPrice = Convert.ToDecimal(dataRow["low_price"].ToString());
							this.ShowDisplayFlagBBO(num, dataRow["display_flag"].ToString());
							this.UpdateBBOTopPrice(num, "B", Convert.ToDecimal(dataRow["bid_price1"].ToString()), Convert.ToInt64(dataRow["bid_volume1"]), stockInformation.PriorPrice, stockInformation.LastSalePrice, stockInformation);
							this.UpdateBBOTopPrice(num, "S", Convert.ToDecimal(dataRow["offer_price1"].ToString()), Convert.ToInt64(dataRow["offer_volume1"]), stockInformation.PriorPrice, stockInformation.LastSalePrice, stockInformation);
							decimal.TryParse(dataRow["projected_open"].ToString(), out price);
							decimal.TryParse(dataRow["projected_close"].ToString(), out price2);
							decimal lastPrice = (stockInformation.LastSalePrice > 0m) ? stockInformation.LastSalePrice : stockInformation.PriorPrice;
							this.UpdateBBO_LS(num, lastPrice, Convert.ToInt64(dataRow["accvolume"]), Convert.ToDecimal(dataRow["accvalue"]), Convert.ToInt32(dataRow["deals"]), dataRow["compare_price"].ToString(), Convert.ToDecimal(dataRow["high_price"]), Convert.ToDecimal(dataRow["low_price"]), Convert.ToInt64(dataRow["buy_volume"]), Convert.ToInt64(dataRow["sell_volume"]), stockInformation);
							this.UpdateBBOPreOpenPrice(num, price, stockInformation);
							this.UpdateBBOPreClosePrice(num, price2, stockInformation);
							this.intzaBBO.Records(num).Fields("prior").Text = stockInformation.PriorPrice;
							this.intzaBBO.Records(num).Fields("prior").FontColor = MyColor.UnChgColor;
							stockInformation.TotBidVol = Convert.ToInt64(dataRow["sumbidvol"].ToString());
							stockInformation.TotOfferVol = Convert.ToInt64(dataRow["sumoffervol"].ToString());
							this.UpdateBidOfferVolPct(num, stockInformation.TotBidVol, stockInformation.TotOfferVol);
						}
					}
				}
				this.intzaBBO.Sort(string.Empty, SortType.None);
				this.intzaBBO.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControlBBO", ex);
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00135F78 File Offset: 0x00134378
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBBOTopPrice(int rowIndex, string side, decimal price, long volume, decimal prior, decimal lastSalePrice, StockList.StockInformation sf)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaBBO.InvokeRequired)
			{
				this.intzaBBO.Invoke(new frmMarketWatch.UpdateBBOTopPriceCallBack(this.UpdateBBOTopPrice), new object[]
				{
					rowIndex,
					side,
					price,
					volume,
					prior,
					lastSalePrice,
					sf
				});
			}
			else
			{
				try
				{
					if (rowIndex >= 0)
					{
						if (price > -1m)
						{
							Color fontColor = MyColor.UnChgColor;
							string text = Utilities.BidOfferPriceFormat(price, volume);
							if (side == "B")
							{
								this.intzaBBO.Records(rowIndex).Fields("bid").Text = text;
								this.intzaBBO.Records(rowIndex).Fields("bidvol").Text = volume;
								if (lastSalePrice > 0m)
								{
									if (Utilities.PriceFormat(lastSalePrice) == text)
									{
										this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Underline;
										this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Regular;
									}
									else
									{
										this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Regular;
									}
								}
								fontColor = Utilities.ComparePriceCFColor(price, sf);
								this.intzaBBO.Records(rowIndex).Fields("bid").FontColor = fontColor;
								this.intzaBBO.Records(rowIndex).Fields("bidvol").FontColor = fontColor;
							}
							else
							{
								this.intzaBBO.Records(rowIndex).Fields("offer").Text = text;
								this.intzaBBO.Records(rowIndex).Fields("offvol").Text = volume;
								if (lastSalePrice > 0m)
								{
									if (Utilities.PriceFormat(lastSalePrice) == text)
									{
										this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Regular;
										this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Underline;
									}
									else
									{
										this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Regular;
									}
								}
								fontColor = Utilities.ComparePriceCFColor(price, sf);
								this.intzaBBO.Records(rowIndex).Fields("offer").FontColor = fontColor;
								this.intzaBBO.Records(rowIndex).Fields("offvol").FontColor = fontColor;
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateTopPriceBBO", ex);
				}
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x001362CC File Offset: 0x001346CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBidOfferVolPct(int index, object bidVol, object offerVol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaBBO.Records(index).Fields("bidofferpct").Text = bidVol.ToString() + ";" + offerVol.ToString();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateBidOfferVolPct", ex);
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00136348 File Offset: 0x00134748
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBBOPreOpenPrice(int rowIndex, decimal price, StockList.StockInformation sf)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.intzaBBO.Records(rowIndex).Fields("po").Text = price;
			this.intzaBBO.Records(rowIndex).Fields("po").BackColor = Color.FromArgb(64, 64, 64);
			this.intzaBBO.Records(rowIndex).Fields("po").FontColor = Utilities.ComparePriceCFColor(price, sf);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x001363D0 File Offset: 0x001347D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBBOPreClosePrice(int rowIndex, decimal price, StockList.StockInformation sf)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.intzaBBO.Records(rowIndex).Fields("pc").Text = price;
			this.intzaBBO.Records(rowIndex).Fields("pc").BackColor = Color.FromArgb(64, 64, 64);
			this.intzaBBO.Records(rowIndex).Fields("pc").FontColor = Utilities.ComparePriceCFColor(price, sf);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00136458 File Offset: 0x00134858
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBBO_LS(int rowIndex, decimal lastPrice, long accVolume, decimal accValue, int deals, string comparePrice, decimal highPrice, decimal lowPrice, long buyVol, long sellVol, StockList.StockInformation sf)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaBBO.InvokeRequired)
			{
				this.intzaBBO.Invoke(new frmMarketWatch.UpdateBBO_LS_CallBack(this.UpdateBBO_LS), new object[]
				{
					rowIndex,
					lastPrice,
					accVolume,
					accValue,
					deals,
					comparePrice,
					highPrice,
					lowPrice,
					buyVol,
					sellVol,
					sf
				});
			}
			else
			{
				try
				{
					STIControl.ExpandTableGrid.RecordItem recordItem = this.intzaBBO.Records(rowIndex);
					decimal num = 0m;
					if (accVolume > 0L)
					{
						num = Math.Round(accValue / accVolume, 2);
					}
					decimal num2 = 0m;
					decimal num3 = 0m;
					if (accVolume > 0L)
					{
						num3 = sellVol / accVolume * 100m;
						num2 = buyVol / accVolume * 100m;
					}
					recordItem.Fields("avg").Text = num;
					recordItem.Fields("high").Text = highPrice;
					recordItem.Fields("low").Text = lowPrice;
					if (lastPrice > 0m)
					{
						recordItem.Fields("last").Text = lastPrice;
						recordItem.Fields("last").Tag = "@" + comparePrice;
					}
					else
					{
						recordItem.Fields("last").Text = sf.PriorPrice;
						recordItem.Fields("last").Tag = "";
					}
					recordItem.Fields("chg").Text = sf.ChangePrice;
					recordItem.Fields("pchg").Text = sf.ChangePricePct;
					recordItem.Fields("mvol").Text = accVolume;
					recordItem.Fields("mval").Text = accValue / 1000m;
					recordItem.Fields("deals").Text = deals;
					recordItem.Fields("buyvolpct").Text = num2;
					recordItem.Fields("selvolpct").Text = num3;
					recordItem.Fields("high").FontColor = Utilities.ComparePriceCFColor(highPrice, sf);
					recordItem.Fields("low").FontColor = Utilities.ComparePriceCFColor(lowPrice, sf);
					recordItem.Fields("avg").FontColor = Utilities.ComparePriceCFColor(num, sf);
					Color fontColor = Utilities.ComparePriceCFColor(lastPrice, sf);
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					recordItem.Fields("chg").FontColor = fontColor;
					recordItem.Fields("pchg").FontColor = fontColor;
					recordItem.Fields("mvol").FontColor = MyColor.UnChgColor;
					recordItem.Fields("mval").FontColor = MyColor.UnChgColor;
					recordItem.Fields("deals").FontColor = MyColor.UnChgColor;
					recordItem.Fields("buyvolpct").FontColor = MyColor.BuyColor;
					recordItem.Fields("selvolpct").FontColor = MyColor.SellColor;
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateLastPriceBBO", ex);
				}
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00136898 File Offset: 0x00134C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowDisplayFlagBBO(int rowIndex, string displayFlag)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaBBO.InvokeRequired)
			{
				this.intzaBBO.Invoke(new frmMarketWatch.ShowDisplayFlagBBOCallBack(this.ShowDisplayFlagBBO), new object[]
				{
					rowIndex,
					displayFlag
				});
			}
			else
			{
				try
				{
					this.intzaBBO.Records(rowIndex).Fields("stock").Tag = displayFlag;
				}
				catch (Exception ex)
				{
					this.ShowError("ShowDisplayFlagBBO", ex);
				}
			}
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0013694C File Offset: 0x00134D4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBBONewStock(string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (newStock != string.Empty)
				{
					bool flag = false;
					bool flag2 = false;
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[newStock.ToUpper()];
					SeriesList.SeriesInformation seriesInformation = null;
					if (stockInformation.Number < 0)
					{
						seriesInformation = ApplicationInfo.SeriesInfo[newStock.ToUpper()];
						if (!string.IsNullOrEmpty(seriesInformation.Symbol))
						{
							flag2 = true;
						}
					}
					else
					{
						flag = true;
					}
					int num = this.intzaBBO.FocusItemIndex + 1;
					this._bboQuerySymbol = string.Empty;
					this._bboQuerySymbolTFEX = string.Empty;
					if (flag)
					{
						this.CheckExist(stockInformation.Symbol);
						this.intzaBBO.ClearAllTextByRow(num - 1);
						this.intzaBBO.Records(num - 1).Fields("stock").Text = stockInformation.Symbol;
						this._bboQuerySymbol = "'" + stockInformation.Number.ToString() + "'";
						ApplicationInfo.FavStockChanged = true;
						ApplicationInfo.FavStockList[this._bboPage][this.intzaBBO.FocusItemIndex] = stockInformation.Symbol;
						this.ReloadDataBBO();
						if (this.intzaBBO.Records(this.intzaBBO.FocusItemIndex).Rows > 1)
						{
							if (!this.bgwReloadBBOExp.IsBusy)
							{
								this._expStockNo = stockInformation.Number;
								this._expRows = this.intzaBBO.Records(this.intzaBBO.FocusItemIndex).Rows;
								this.bgwReloadBBOExp.RunWorkerAsync();
							}
						}
						this.tbStockBBO.Text = stockInformation.Symbol;
						this.tbStockBBO.SelectAll();
					}
					else if (flag2)
					{
						this.CheckExist(seriesInformation.Symbol);
						this.intzaBBO.ClearAllTextByRow(num - 1);
						this.intzaBBO.Records(num - 1).Fields("stock").Text = seriesInformation.Symbol;
						this._bboQuerySymbolTFEX = "'" + seriesInformation.Symbol.ToString() + "'";
						ApplicationInfo.FavStockChanged = true;
						ApplicationInfo.FavStockList[this._bboPage][this.intzaBBO.FocusItemIndex] = seriesInformation.Symbol;
						this.ReloadDataBBO();
						if (this.intzaBBO.Records(this.intzaBBO.FocusItemIndex).Rows > 1)
						{
							if (!this.bgwReloadBBOExp.IsBusy)
							{
								this._expSeries = seriesInformation.Symbol;
								this._expRows = this.intzaBBO.Records(this.intzaBBO.FocusItemIndex).Rows;
								this.bgwReloadBBOExp.RunWorkerAsync();
							}
						}
						this.tbStockBBO.Text = seriesInformation.Symbol;
						this.tbStockBBO.SelectAll();
					}
					else
					{
						this.tbStockBBO.Text = this.intzaBBO.Records(num - 1).Fields("stock").Text.ToString();
						this.tbStockBBO.SelectAll();
					}
				}
				else
				{
					this.ClearStockBBO(this.intzaBBO.FocusItemIndex);
					this.tbStockBBO.Hide();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbStockBBO_KeyUp", ex);
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00136D30 File Offset: 0x00135130
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearStockBBO(int lineNo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaBBO.InvokeRequired)
			{
				this.intzaBBO.Invoke(new frmMarketWatch.ClearStockBBOCallBack(this.ClearStockBBO), new object[]
				{
					lineNo
				});
			}
			else
			{
				try
				{
					if (this._mainGroupType == "Favorites")
					{
						ApplicationInfo.FavStockList[this._bboPage][lineNo] = string.Empty;
						ApplicationInfo.FavStockChanged = true;
						this.intzaBBO.ClearAllTextByRow(lineNo);
						this.intzaBBO.Redraw();
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ClearStockBBO", ex);
				}
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00136E18 File Offset: 0x00135218
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbStockBBO_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetBtnBBODelStock();
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00136E30 File Offset: 0x00135230
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbStockBBO_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00136E44 File Offset: 0x00135244
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbStockBBO_KeyDown(object sender, KeyEventArgs e)
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
					if (keyCode != Keys.Escape)
					{
						switch (keyCode)
						{
						case Keys.Up:
							this.ShowTextBoxPosition(e);
							e.SuppressKeyPress = true;
							break;
						case Keys.Down:
							this.ShowTextBoxPosition(e);
							e.SuppressKeyPress = true;
							break;
						}
					}
					else
					{
						this.tbStockBBO.Hide();
						this.intzaBBO.Redraw();
					}
				}
				else
				{
					this.SetBBONewStock(this.tbStockBBO.Text.Trim());
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbStockBBO_KeyDown", ex);
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00136F24 File Offset: 0x00135324
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadBBOExp_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tdsBBOExp == null)
				{
					this.tdsBBOExp = new DataSet();
				}
				else
				{
					this.tdsBBOExp.Clear();
				}
				if (this._expCurrentIsSET)
				{
					string text = ApplicationInfo.WebService.Get5BidOffer(this._expStockNo);
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this.tdsBBOExp);
					}
				}
				else
				{
					string text2 = ApplicationInfo.WebServiceTFEX.Get5BidOfferTFEX(this._expSeries);
					if (!string.IsNullOrEmpty(text2))
					{
						MyDataHelper.StringToDataSet(text2, this.tdsBBOExp);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadBBOExp_DoWork", ex);
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00137014 File Offset: 0x00135414
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadBBOExp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._expCurrentIsSET)
				{
					if (this.tdsBBOExp != null && this.tdsBBOExp.Tables.Contains("top_price") && this.tdsBBOExp.Tables["top_price"].Rows.Count > 0)
					{
						DataRow dataRow = this.tdsBBOExp.Tables["top_price"].Rows[0];
						if (this.intzaBBO.Records(this._expRowId).Rows != this._expRows)
						{
							this.intzaBBO.ExpandRows(this._expRowId, this._expRows, "stock", this._expRows == 5, false);
						}
						else
						{
							this.intzaBBO.Records(this._expRowId).SubRecord[0].ClearAllText();
							this.intzaBBO.Records(this._expRowId).SubRecord[1].ClearAllText();
							if (this.intzaBBO.Records(this._expRowId).Rows > 3)
							{
								this.intzaBBO.Records(this._expRowId).SubRecord[2].ClearAllText();
								this.intzaBBO.Records(this._expRowId).SubRecord[3].ClearAllText();
							}
						}
						StockList.StockInformation sf = ApplicationInfo.StockInfo[this._expStockNo];
						this.UpdateBBOBids(this.intzaBBO.Records(this._expRowId), sf, "B", Convert.ToDecimal(dataRow["bid_price2"].ToString()), Convert.ToInt64(dataRow["bid_volume2"].ToString()), Convert.ToDecimal(dataRow["bid_price3"].ToString()), Convert.ToInt64(dataRow["bid_volume3"].ToString()), Convert.ToDecimal(dataRow["bid_price4"].ToString()), Convert.ToInt64(dataRow["bid_volume4"].ToString()), Convert.ToDecimal(dataRow["bid_price5"].ToString()), Convert.ToInt64(dataRow["bid_volume5"].ToString()));
						this.UpdateBBOBids(this.intzaBBO.Records(this._expRowId), sf, "S", Convert.ToDecimal(dataRow["offer_price2"].ToString()), Convert.ToInt64(dataRow["offer_volume2"].ToString()), Convert.ToDecimal(dataRow["offer_price3"].ToString()), Convert.ToInt64(dataRow["offer_volume3"].ToString()), Convert.ToDecimal(dataRow["offer_price4"].ToString()), Convert.ToInt64(dataRow["offer_volume4"].ToString()), Convert.ToDecimal(dataRow["offer_price5"].ToString()), Convert.ToInt64(dataRow["offer_volume5"].ToString()));
						this.tdsBBOExp.Clear();
					}
				}
				else if (this.tdsBBOExp != null && this.tdsBBOExp.Tables.Contains("top_price") && this.tdsBBOExp.Tables["top_price"].Rows.Count > 0)
				{
					DataRow dataRow = this.tdsBBOExp.Tables["top_price"].Rows[0];
					if (this.intzaBBO.Records(this._expRowId).Rows != this._expRows)
					{
						this.intzaBBO.ExpandRows(this._expRowId, this._expRows, "stock", this._expRows == 5, false);
					}
					else
					{
						this.intzaBBO.Records(this._expRowId).SubRecord[0].ClearAllText();
						this.intzaBBO.Records(this._expRowId).SubRecord[1].ClearAllText();
						if (this.intzaBBO.Records(this._expRowId).Rows > 3)
						{
							this.intzaBBO.Records(this._expRowId).SubRecord[2].ClearAllText();
							this.intzaBBO.Records(this._expRowId).SubRecord[3].ClearAllText();
						}
					}
					SeriesList.SeriesInformation sf2 = ApplicationInfo.SeriesInfo[this._expSeries];
					long volume;
					long.TryParse(dataRow["iBidQuantity2"].ToString(), out volume);
					long volume2;
					long.TryParse(dataRow["iBidQuantity3"].ToString(), out volume2);
					long volume3;
					long.TryParse(dataRow["iBidQuantity4"].ToString(), out volume3);
					long volume4;
					long.TryParse(dataRow["iBidQuantity5"].ToString(), out volume4);
					this.UpdateBBOBidsTFEX(this.intzaBBO.Records(this._expRowId), sf2, "B", dataRow["nmrBidPrice2"].ToString(), volume, dataRow["nmrBidPrice3"].ToString(), volume2, dataRow["nmrBidPrice4"].ToString(), volume3, dataRow["nmrBidPrice5"].ToString(), volume4);
					long.TryParse(dataRow["iAskQuantity2"].ToString(), out volume);
					long.TryParse(dataRow["iAskQuantity3"].ToString(), out volume2);
					long.TryParse(dataRow["iAskQuantity4"].ToString(), out volume3);
					long.TryParse(dataRow["iAskQuantity5"].ToString(), out volume4);
					this.UpdateBBOBidsTFEX(this.intzaBBO.Records(this._expRowId), sf2, "A", dataRow["nmrAskPrice2"].ToString(), volume, dataRow["nmrAskPrice3"].ToString(), volume2, dataRow["nmrAskPrice4"].ToString(), volume3, dataRow["nmrAskPrice5"].ToString(), volume4);
					this.tdsBBOExp.Clear();
				}
				this.intzaBBO.Invalidate();
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadBBOExp_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00137704 File Offset: 0x00135B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBBOBids(STIControl.ExpandTableGrid.RecordItem rec, StockList.StockInformation sf, string side, decimal price2, long volume2, decimal price3, long volume3, decimal price4, long volume4, decimal price5, long volume5)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Color fontColor = MyColor.UnChgColor;
				if (side == "B")
				{
					if (price2 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price2, sf);
						rec.SubRecord[0].Fields("bidvol").Text = volume2;
						rec.SubRecord[0].Fields("bidvol").FontColor = fontColor;
						rec.SubRecord[0].Fields("bid").Text = Utilities.BidOfferPriceFormat(price2, volume2);
						rec.SubRecord[0].Fields("bid").FontColor = fontColor;
					}
					if (price3 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price3, sf);
						rec.SubRecord[1].Fields("bidvol").Text = volume3;
						rec.SubRecord[1].Fields("bidvol").FontColor = fontColor;
						rec.SubRecord[1].Fields("bid").Text = Utilities.BidOfferPriceFormat(price3, volume3);
						rec.SubRecord[1].Fields("bid").FontColor = fontColor;
					}
					if (rec.Rows == 5)
					{
						if (price4 > -1m)
						{
							fontColor = Utilities.ComparePriceCFColor(price4, sf);
							rec.SubRecord[2].Fields("bidvol").Text = volume4;
							rec.SubRecord[2].Fields("bidvol").FontColor = fontColor;
							rec.SubRecord[2].Fields("bid").Text = Utilities.BidOfferPriceFormat(price4, volume4);
							rec.SubRecord[2].Fields("bid").FontColor = fontColor;
						}
						if (price5 > -1m)
						{
							fontColor = Utilities.ComparePriceCFColor(price5, sf);
							rec.SubRecord[3].Fields("bidvol").Text = volume5;
							rec.SubRecord[3].Fields("bidvol").FontColor = fontColor;
							rec.SubRecord[3].Fields("bid").Text = Utilities.BidOfferPriceFormat(price5, volume5);
							rec.SubRecord[3].Fields("bid").FontColor = fontColor;
						}
					}
				}
				else if (side == "S")
				{
					if (price2 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price2, sf);
						rec.SubRecord[0].Fields("offvol").Text = volume2;
						rec.SubRecord[0].Fields("offvol").FontColor = fontColor;
						rec.SubRecord[0].Fields("offer").Text = Utilities.BidOfferPriceFormat(price2, volume2);
						rec.SubRecord[0].Fields("offer").FontColor = fontColor;
					}
					if (price3 > -1m)
					{
						fontColor = Utilities.ComparePriceCFColor(price3, sf);
						rec.SubRecord[1].Fields("offvol").Text = volume3;
						rec.SubRecord[1].Fields("offvol").FontColor = fontColor;
						rec.SubRecord[1].Fields("offer").Text = Utilities.BidOfferPriceFormat(price3, volume3);
						rec.SubRecord[1].Fields("offer").FontColor = fontColor;
					}
					if (rec.Rows == 5)
					{
						if (price4 > -1m)
						{
							fontColor = Utilities.ComparePriceCFColor(price4, sf);
							rec.SubRecord[2].Fields("offvol").Text = volume4;
							rec.SubRecord[2].Fields("offvol").FontColor = fontColor;
							rec.SubRecord[2].Fields("offer").Text = Utilities.BidOfferPriceFormat(price4, volume4);
							rec.SubRecord[2].Fields("offer").FontColor = fontColor;
						}
						if (price5 > -1m)
						{
							fontColor = Utilities.ComparePriceCFColor(price5, sf);
							rec.SubRecord[3].Fields("offvol").Text = volume5;
							rec.SubRecord[3].Fields("offvol").FontColor = fontColor;
							rec.SubRecord[3].Fields("offer").Text = Utilities.BidOfferPriceFormat(price5, volume5);
							rec.SubRecord[3].Fields("offer").FontColor = fontColor;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateTopPrice", ex);
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00137CDC File Offset: 0x001360DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckExist(string stockName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._mainGroupType == "Favorites")
				{
					int num = ApplicationInfo.FavStockList[this._bboPage].IndexOf(stockName);
					if (num > -1)
					{
						ApplicationInfo.FavStockList[this._bboPage][num] = string.Empty;
						this.intzaBBO.ClearAllTextByRow(num);
						this.intzaBBO.EndUpdate(num);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("CheckExist", ex);
			}
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00137DA0 File Offset: 0x001361A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowTextBoxPosition(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMarketWatch.ShowTextBoxPositionCallBack(this.ShowTextBoxPosition), new object[]
				{
					e
				});
			}
			else
			{
				try
				{
					if (!(this._mainGroupType != "Favorites"))
					{
						int num = this.intzaBBO.StartDrawIndex - 1;
						int num2 = this.intzaBBO.EndDrawIndex - 1;
						int num3 = this.intzaBBO.FocusItemIndex;
						if (e.KeyCode == Keys.Up)
						{
							num3--;
						}
						else if (e.KeyCode == Keys.Down)
						{
							num3++;
						}
						else
						{
							if (e.KeyCode != Keys.Home)
							{
								return;
							}
							if (num3 < num)
							{
								num3 = num;
							}
							else if (num3 > num2)
							{
								num3 = num;
							}
						}
						if (num3 > -1 && num3 < ApplicationInfo.FavStockPerPage)
						{
							this.intzaBBO.SetFocusItem(num3);
							Rectangle fieldPosition = this.intzaBBO.GetFieldPosition(num3, "stock");
							this.tbStockBBO.Text = string.Empty;
							this.tbStockBBO.Left = this.intzaBBO.Margin.Left;
							this.tbStockBBO.Top = this.intzaBBO.Top + fieldPosition.Top + 1;
							this.tbStockBBO.Width = fieldPosition.Width - 1;
							this.tbStockBBO.Height = fieldPosition.Height;
							this.tbStockBBO.Text = this.intzaBBO.Records(num3).Fields("stock").Text.ToString();
							this.tbStockBBO.Visible = true;
							this.tbStockBBO.BringToFront();
							this.tbStockBBO.Focus();
							this.tbStockBBO.SelectAll();
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ShowTextBoxPosition", ex);
				}
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00138020 File Offset: 0x00136420
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl_TA(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ds != null && ds.Tables.Count > 0)
				{
					this.intzaBBO.BeginUpdate();
					this.intzaBBO.Rows = ds.Tables[0].Rows.Count;
					decimal price = 0m;
					decimal price2 = 0m;
					int num = 0;
					foreach (DataRow dataRow in ds.Tables[0].Rows)
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[Convert.ToInt32(dataRow["security_number"])];
						this.intzaBBO.Records(num).Fields("stock").Text = stockInformation.Symbol;
						stockInformation.LastSalePrice = Convert.ToDecimal(dataRow["last_sale_price"].ToString());
						stockInformation.HighPrice = Convert.ToDecimal(dataRow["high_price"].ToString());
						stockInformation.LowPrice = Convert.ToDecimal(dataRow["low_price"].ToString());
						this.ShowDisplayFlagBBO(num, dataRow["display_flag"].ToString());
						this.UpdateBBOTopPrice(num, "B", Convert.ToDecimal(dataRow["bid_price1"].ToString()), Convert.ToInt64(dataRow["bid_volume1"]), stockInformation.PriorPrice, stockInformation.LastSalePrice, stockInformation);
						this.UpdateBBOTopPrice(num, "S", Convert.ToDecimal(dataRow["offer_price1"].ToString()), Convert.ToInt64(dataRow["offer_volume1"]), stockInformation.PriorPrice, stockInformation.LastSalePrice, stockInformation);
						decimal.TryParse(dataRow["projected_open"].ToString(), out price);
						decimal.TryParse(dataRow["projected_close"].ToString(), out price2);
						decimal lastPrice = (stockInformation.LastSalePrice > 0m) ? stockInformation.LastSalePrice : stockInformation.PriorPrice;
						this.UpdateBBO_LS(num, lastPrice, Convert.ToInt64(dataRow["accvolume"]), Convert.ToDecimal(dataRow["accvalue"]), Convert.ToInt32(dataRow["deals"]), dataRow["compare_price"].ToString(), Convert.ToDecimal(dataRow["high_price"]), Convert.ToDecimal(dataRow["low_price"]), Convert.ToInt64(dataRow["buy_volume"]), Convert.ToInt64(dataRow["sell_volume"]), stockInformation);
						this.UpdateBBOPreOpenPrice(num, price, stockInformation);
						this.UpdateBBOPreClosePrice(num, price2, stockInformation);
						stockInformation.TotBidVol = Convert.ToInt64(dataRow["sumbidvol"].ToString());
						stockInformation.TotOfferVol = Convert.ToInt64(dataRow["sumoffervol"].ToString());
						this.UpdateBidOfferVolPct(num, stockInformation.TotBidVol, stockInformation.TotOfferVol);
						this.intzaBBO.Records(num).Fields("prior").Text = stockInformation.PriorPrice;
						this.intzaBBO.Records(num).Fields("prior").FontColor = MyColor.UnChgColor;
						num++;
					}
					this.intzaBBO.Sort(string.Empty, SortType.None);
				}
				this.intzaBBO.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl", ex);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00138454 File Offset: 0x00136854
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbSelection_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.IsBBOLoading && !this._isSetMainCombo)
				{
					this.tmBBOSelectionChanged.Stop();
					this.tmBBOSelectionChanged.Start();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tscbSelection_SelectedIndexChanged", ex);
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x001384D8 File Offset: 0x001368D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmBBOSelectionChanged_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tmBBOSelectionChanged.Stop();
				this.SetBBOPage(this.tscbBBOSelection.Text.Trim());
			}
			catch (Exception ex)
			{
				this.ShowError("timer_Tick", ex);
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00138544 File Offset: 0x00136944
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadDataBBO()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.bgwReloadDataBBO.IsBusy)
				{
					this.bgwReloadDataBBO.RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ReloadDataBBO", ex);
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x001385AC File Offset: 0x001369AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadDataSector(string sector)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sector != string.Empty)
				{
					if (!this.bgwReloadDataBBO.IsBusy)
					{
						this.bgwReloadDataBBO.RunWorkerAsync(sector);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ReloadDataSector", ex);
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0013862C File Offset: 0x00136A2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadDataBBO_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				this.IsBBOLoading = true;
				try
				{
					string text = string.Empty;
					string text2 = this._mainGroupType;
					switch (text2)
					{
					case "Favorites":
						if (this.tdsBBOFavTFEX == null)
						{
							this.tdsBBOFavTFEX = new DataSet();
						}
						else
						{
							this.tdsBBOFavTFEX.Clear();
						}
						if (this.tdsBBOFavSET == null)
						{
							this.tdsBBOFavSET = new DataSet();
						}
						else
						{
							this.tdsBBOFavSET.Clear();
						}
						if (this._bboQuerySymbolTFEX != string.Empty)
						{
							text = ApplicationInfo.WebServiceTFEX.BestBidOfferByList(this._bboQuerySymbolTFEX);
							if (!string.IsNullOrEmpty(text))
							{
								MyDataHelper.StringToDataSet(text, this.tdsBBOFavTFEX);
							}
						}
						if (this._bboQuerySymbol != string.Empty)
						{
							text = ApplicationInfo.WebService.BestBidOffer(this._bboQuerySymbol);
							if (!string.IsNullOrEmpty(text))
							{
								MyDataHelper.StringToDataSet(text, this.tdsBBOFavSET);
							}
						}
						break;
					case "SET":
					case "MAI":
					case "Warrant":
					case "Derivative Warrant":
					{
						string marketID = string.Empty;
						if (this._mainGroupType == "SET")
						{
							marketID = "S";
						}
						else if (this._mainGroupType == "MAI")
						{
							marketID = "M";
						}
						else if (this._mainGroupType == "Warrant")
						{
							marketID = "W";
						}
						else
						{
							marketID = "V";
						}
						if (this._subGroupType == "Set Sector")
						{
							if (this.tdsSector != null)
							{
								this.tdsSector.Clear();
								this.tdsSector = null;
							}
							this.tdsSector = new DataSet();
							IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo[this._bboQuerySymbolSector];
							if (indexItem != null)
							{
								text = ApplicationInfo.WebService.TopActiveBBO_Sector(indexItem.Number);
								if (!string.IsNullOrEmpty(text))
								{
									MyDataHelper.StringToDataSet(text, this.tdsSector);
								}
							}
						}
						else
						{
							text2 = this._currentBBOpage;
							if (text2 != null)
							{
								if (!(text2 == "Most Active Value"))
								{
									if (!(text2 == "Most Active Volume"))
									{
										if (!(text2 == "Most Active Gainer"))
										{
											if (!(text2 == "Most Active Loser"))
											{
												if (!(text2 == "Benefit"))
												{
													if (text2 == "Turnover List")
													{
														text = ApplicationInfo.WebService.TopActiveBBO_TurnOver();
													}
												}
												else
												{
													text = ApplicationInfo.WebService.TopActiveBBO_Benefit();
												}
											}
											else
											{
												text = ApplicationInfo.WebService.TopActiveBBO("LN", "M", marketID, 40);
											}
										}
										else
										{
											text = ApplicationInfo.WebService.TopActiveBBO("GN", "M", marketID, 40);
										}
									}
									else
									{
										text = ApplicationInfo.WebService.TopActiveBBO("MV", "M", marketID, 40);
									}
								}
								else
								{
									text = ApplicationInfo.WebService.TopActiveBBO("MA", "M", marketID, 40);
								}
							}
							if (this.tdsTopActive == null)
							{
								this.tdsTopActive = new DataSet();
							}
							else
							{
								this.tdsTopActive.Clear();
								this.tdsTopActive = null;
								this.tdsTopActive = new DataSet();
							}
							if (!string.IsNullOrEmpty(text))
							{
								MyDataHelper.StringToDataSet(text, this.tdsTopActive);
							}
						}
						break;
					}
					case "%CMPR":
						if (this.tdsCmpr == null)
						{
							this.tdsCmpr = new DataSet();
						}
						else
						{
							this.tdsCmpr.Clear();
							this.tdsCmpr = null;
							this.tdsCmpr = new DataSet();
						}
						text = ApplicationInfo.WebService.TopActiveBBO_CMPR(40);
						if (!string.IsNullOrEmpty(text))
						{
							MyDataHelper.StringToDataSet(text, this.tdsCmpr);
						}
						break;
					case "My Port":
						if (this.tdsMyPort == null)
						{
							this.tdsMyPort = new DataSet();
						}
						else
						{
							this.tdsMyPort.Clear();
							this.tdsMyPort = null;
							this.tdsMyPort = new DataSet();
						}
						if (ApplicationInfo.IsEquityAccount)
						{
							text = ApplicationInfo.WebService.TopActiveBBO_MyPort(ApplicationInfo.AccInfo.CurrentAccount);
						}
						else
						{
							text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO_MyPort(ApplicationInfo.AccInfo.CurrentAccount);
						}
						if (!string.IsNullOrEmpty(text))
						{
							MyDataHelper.StringToDataSet(text, this.tdsMyPort);
						}
						break;
					case "Futures":
						if (this._subGroupType == "Futures Instrument")
						{
							if (this.tdsInstrument != null)
							{
								this.tdsInstrument.Clear();
								this.tdsInstrument = null;
							}
							this.tdsInstrument = new DataSet();
							UnderlyingInfo.UnderlyingList underlyingList = ApplicationInfo.UnderlyingInfo[this._bboQuerySymbolTFEX];
							if (underlyingList != null)
							{
								text = ApplicationInfo.WebServiceTFEX.BestBidOfferByInstrument(underlyingList.OrderBookId);
							}
							if (!string.IsNullOrEmpty(text))
							{
								MyDataHelper.StringToDataSet(text, this.tdsInstrument);
							}
						}
						else
						{
							text2 = this._currentBBOpage;
							if (text2 != null)
							{
								if (!(text2 == "Futures - Most Active Value"))
								{
									if (!(text2 == "Futures - Most Active Volume"))
									{
										if (!(text2 == "Futures - Gainer"))
										{
											if (!(text2 == "Futures - Loser"))
											{
												if (text2 == "Futures - Most Swing")
												{
													text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("SW", true);
												}
											}
											else
											{
												text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("LN", true);
											}
										}
										else
										{
											text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("GN", true);
										}
									}
									else
									{
										text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("MV", true);
									}
								}
								else
								{
									text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("MA", true);
								}
							}
							if (this.tdsTopActive == null)
							{
								this.tdsTopActive = new DataSet();
							}
							else
							{
								this.tdsTopActive.Clear();
								this.tdsTopActive = null;
								this.tdsTopActive = new DataSet();
							}
							if (!string.IsNullOrEmpty(text))
							{
								MyDataHelper.StringToDataSet(text, this.tdsTopActive);
							}
						}
						break;
					case "Option":
						if (this._subGroupType == "SET50Option")
						{
							if (this.tdsSet50Option == null)
							{
								this.tdsSet50Option = new DataSet();
							}
							else
							{
								this.tdsSet50Option.Clear();
							}
							this.RequestWebOptionsData();
						}
						else
						{
							text2 = this._currentBBOpage;
							if (text2 != null)
							{
								if (!(text2 == "Options - Most Active Value"))
								{
									if (!(text2 == "Options - Most Active Volume"))
									{
										if (!(text2 == "Options - Gainer"))
										{
											if (!(text2 == "Options - Loser"))
											{
												if (!(text2 == "Options - Most Swing"))
												{
													break;
												}
												text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("SW", false);
											}
											else
											{
												text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("LN", false);
											}
										}
										else
										{
											text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("GN", false);
										}
									}
									else
									{
										text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("MV", false);
									}
								}
								else
								{
									text = ApplicationInfo.WebServiceTFEX.TFEXTopActiveBBO("MA", false);
								}
								if (this.tdsTopActive == null)
								{
									this.tdsTopActive = new DataSet();
								}
								else
								{
									this.tdsTopActive.Clear();
									this.tdsTopActive = null;
									this.tdsTopActive = new DataSet();
								}
								if (!string.IsNullOrEmpty(text))
								{
									MyDataHelper.StringToDataSet(text, this.tdsTopActive);
								}
							}
						}
						break;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("RequestWebData", ex);
				}
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00138FB0 File Offset: 0x001373B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadDataBBO_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing && e.Result == null)
			{
				try
				{
					string mainGroupType = this._mainGroupType;
					switch (mainGroupType)
					{
					case "Favorites":
						this.intzaBBO.BeginUpdate();
						if (this._bboQuerySymbol != string.Empty)
						{
							this.UpdateToControlFav_BBO(this.tdsBBOFavSET);
						}
						if (this._bboQuerySymbolTFEX != string.Empty)
						{
							this.UpdateToControl_BBO_TFEX(this.tdsBBOFavTFEX);
						}
						this.intzaBBO.Redraw();
						break;
					case "SET":
					case "MAI":
					case "Warrant":
					case "Derivative Warrant":
						if (this._subGroupType == "Set Sector")
						{
							this.intzaBBO.BeginUpdate();
							this.UpdateToControl_TA(this.tdsSector);
							this.tdsSector.Clear();
							this.intzaBBO.Redraw();
						}
						else
						{
							this.intzaBBO.BeginUpdate();
							this.UpdateToControl_TA(this.tdsTopActive);
							this.tdsTopActive.Clear();
							this.intzaBBO.Redraw();
						}
						break;
					case "%CMPR":
						this.intzaBBO.BeginUpdate();
						if (this.tdsCmpr.Tables.Contains("security_cmpr"))
						{
							this.intzaCMPR.Rows = this.tdsCmpr.Tables["security_cmpr"].Rows.Count;
							int num2 = 0;
							decimal num3 = 0m;
							foreach (DataRow dataRow in this.tdsCmpr.Tables["security_cmpr"].Rows)
							{
								int stockNumber;
								int.TryParse(dataRow["security_number"].ToString(), out stockNumber);
								StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stockNumber];
								if (stockInformation.Number > 0)
								{
									STIControl.ExpandTableGrid.RecordItem recordItem = this.intzaCMPR.Records(num2);
									recordItem.Fields("stock").Text = stockInformation.Symbol;
									long num4;
									long.TryParse(dataRow["nmrAvgVol5"].ToString(), out num4);
									long num5;
									long.TryParse(dataRow["accvolume"].ToString(), out num5);
									recordItem.Fields("avgvol5").Text = num4;
									recordItem.Fields("trade_vol").Text = num5;
									recordItem.Fields("cmpr").Text = ((num4 > 0L) ? (num5 / num4 * 100m) : 0m);
									recordItem.Fields("prev").Text = stockInformation.PriorPrice;
									decimal.TryParse(dataRow["last_sale_price"].ToString(), out num3);
									stockInformation.LastSalePrice = num3;
									recordItem.Fields("last").Text = stockInformation.LastSalePrice;
									recordItem.Fields("last").Tag = "@" + dataRow["compare_price"].ToString();
									recordItem.Fields("chg").Text = stockInformation.ChangePrice;
									recordItem.Fields("chg_pct").Text = stockInformation.ChangePricePct;
									Color fontColor = Utilities.ComparePriceCFColor(num3, stockInformation);
									recordItem.Fields("stock").FontColor = fontColor;
									recordItem.Fields("avgvol5").FontColor = Color.LightGray;
									recordItem.Fields("trade_vol").FontColor = Color.LightGray;
									recordItem.Fields("cmpr").FontColor = Color.LightGray;
									recordItem.Fields("prev").FontColor = MyColor.UnChgColor;
									recordItem.Fields("last").FontColor = fontColor;
									recordItem.Fields("chg").FontColor = fontColor;
									recordItem.Fields("chg_pct").FontColor = fontColor;
									num2++;
								}
							}
						}
						else
						{
							this.intzaCMPR.Rows = 0;
						}
						this.tdsCmpr.Clear();
						this.intzaBBO.Invalidate();
						break;
					case "My Port":
						this.intzaBBO.BeginUpdate();
						if (ApplicationInfo.IsEquityAccount)
						{
							this.UpdateToControl_TA(this.tdsMyPort);
						}
						else
						{
							this.UpdateToControl_BBO_TFEX(this.tdsMyPort);
						}
						this.intzaBBO.Redraw();
						break;
					case "Futures":
						if (this._subGroupType == "Futures Instrument")
						{
							this.intzaBBO.BeginUpdate();
							this.UpdateToControl_BBO_TFEX(this.tdsInstrument);
							this.tdsInstrument.Clear();
							this.intzaBBO.Redraw();
						}
						else
						{
							this.intzaBBO.BeginUpdate();
							this.UpdateToControl_BBO_TFEX(this.tdsTopActive);
							this.tdsTopActive.Clear();
							this.intzaBBO.Redraw();
						}
						break;
					case "Option":
						if (this._subGroupType == "SET50Option")
						{
							this.intzaOption.BeginUpdate();
							this.UpdateToControl_BBO_Option();
							this.tdsSet50Option.Clear();
							this.intzaOption.Redraw();
						}
						else
						{
							this.intzaBBO.BeginUpdate();
							this.UpdateToControl_BBO_TFEX(this.tdsTopActive);
							this.tdsTopActive.Clear();
							this.intzaBBO.Redraw();
						}
						break;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("bgwReloadDataBBBO", ex);
				}
				this.IsBBOLoading = false;
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00139710 File Offset: 0x00137B10
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
					this.intzaBF.Font = new Font(Settings.Default.Default_Font.Name, Settings.Default.Default_Font.Size - 1f, Settings.Default.Default_Font.Style);
					int y = this.tStripMenu.Bottom + 2;
					int width = base.Width;
					this.intzaTP.SetBounds(2, y, width * 36 / 100, this.intzaTP.GetHeightByRows() + (int)(this.intzaVolumeByBoard.RowHeight * 0.3f));
					this.intzaBF.SetBounds(2, this.intzaTP.Bottom + 2, this.intzaTP.Width, this.intzaBF.MyBottom + 5);
					this.intzaVolumeByBoard.SetBounds(2, this.intzaBF.Bottom + 2, this.intzaTP.Width, this.intzaVolumeByBoard.GetHeightByRows() + (int)(this.intzaVolumeByBoard.RowHeight * 0.4f));
					this.intzaInfo.SetBounds(this.intzaTP.Right + 2, y, width * 32 / 100, this.intzaVolumeByBoard.Bottom - this.intzaTP.Top);
					this.intzaInfoTFEX.Bounds = this.intzaInfo.Bounds;
					this.intzaLS.SetBounds(this.intzaInfo.Right + 2, this.intzaTP.Top, width - this.intzaInfo.Right - 2, this.intzaInfo.Height);
					this.panelVolAs.SetBounds(this.intzaInfo.Left, this.intzaInfo.Top, this.intzaLS.Right - this.intzaInfo.Left, this.intzaInfo.Height);
					this.pictureBox1.Bounds = this.intzaLS.Bounds;
					this.btnCloseChart.Top = this.pictureBox1.Top + 1;
					this.btnCloseChart.Left = this.pictureBox1.Left + this.pictureBox1.Width - this.btnCloseChart.Width - 1;
					this.panelBidOffer.SetBounds(0, this.intzaVolumeByBoard.Bottom + 2, width, base.Height - (this.intzaVolumeByBoard.Bottom + 2));
					this.intzaBBO.SetBounds(2, this.tStripBBO.Top + this.tStripBBO.Height + 1, this.panelBidOffer.Width - 2, this.panelBidOffer.Height - (this.tStripBBO.Top + this.tStripBBO.Height + 1) - 1);
					this.intzaOption.SetBounds(0, this.tStripCP.Top + this.tStripCP.Height + 1, this.panelBidOffer.Width, this.panelBidOffer.Height - (this.tStripCP.Top + this.tStripCP.Height + 1));
					this.intzaCMPR.Bounds = this.intzaBBO.Bounds;
					Graphics graphics = base.CreateGraphics();
					if (this.intzaBBO.Height > 30)
					{
						this.tscbBBOSelection.DropDownHeight = this.intzaBBO.Height;
					}
					this.tscbBBOSelection.Width = (int)graphics.MeasureString("Feature Most Active Volume....", Settings.Default.Default_Font).Width + 20;
					this.tscbBBOSelection.DropDownWidth = this.tscbBBOSelection.Width;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00139B2C File Offset: 0x00137F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBBOPage(string page)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMarketWatch.SetBBOPageCallBack(this.SetBBOPage), new object[]
				{
					page
				});
			}
			else
			{
				try
				{
					this.tbStockBBO.Hide();
					this.tStripBBO.SuspendLayout();
					this._bboQuerySymbolTFEX = string.Empty;
					this._bboQuerySymbol = string.Empty;
					this.SaveFavFromGrid();
					this._bboPage = 1;
					this.tsbtnBBOAddStock.Visible = false;
					this.tsbtnBBODelStock.Visible = false;
					this._subGroupType = string.Empty;
					switch (page)
					{
					case "Favorites-1":
					case "Favorites-2":
					case "Favorites-3":
					case "Favorites-4":
					case "Favorites-5":
						this.tsbtnBBOAddStock.Visible = true;
						this.tsbtnBBODelStock.Visible = true;
						if (page == "Favorites-1")
						{
							this._bboPage = 1;
						}
						else if (page == "Favorites-2")
						{
							this._bboPage = 2;
						}
						else if (page == "Favorites-3")
						{
							this._bboPage = 3;
						}
						else if (page == "Favorites-4")
						{
							this._bboPage = 4;
						}
						else if (page == "Favorites-5")
						{
							this._bboPage = 5;
						}
						this._lastFAV = page;
						this._currentBBOpage = page;
						if (this.intzaBBO.Rows != 15)
						{
							this.intzaBBO.Rows = 15;
						}
						this.intzaBBO.ClearAllText();
						this.intzaBBO.Redraw();
						ApplicationInfo.GetFavListByPage(this._bboPage, 15, true, ref this._bboQuerySymbol, ref this._bboQuerySymbolTFEX);
						this.ReloadDataBBO();
						goto IL_593;
					case "Most Active Value":
					case "Most Active Volume":
					case "Most Active Gainer":
					case "Most Active Loser":
					case "Benefit":
					case "Turnover List":
						if (this._mainGroupType == "SET")
						{
							this._lastSETsel = page;
						}
						else if (this._mainGroupType == "MAI")
						{
							this._lastMAIsel = page;
						}
						else if (this._mainGroupType == "Warrant")
						{
							this._lastWarrantsel = page;
						}
						else if (this._mainGroupType == "Derivative Warrant")
						{
							this._lastDWsel = page;
						}
						this._currentBBOpage = page;
						this.ReloadDataBBO();
						goto IL_593;
					case "Futures - Most Active Value":
					case "Futures - Most Active Volume":
					case "Futures - Gainer":
					case "Futures - Loser":
					case "Futures - Most Swing":
						this._lastFuturesSel = page;
						this._mainGroupType = "Futures";
						this._currentBBOpage = page;
						this.ReloadDataBBO();
						goto IL_593;
					case "-":
						this._currentBBOpage = page;
						this.ReloadDataBBO();
						goto IL_593;
					case "Options - Most Active Value":
					case "Options - Most Active Volume":
					case "Options - Gainer":
					case "Options - Loser":
					case "Options - Most Swing":
						this._lastOptionsSel = page;
						this._currentBBOpage = page;
						this.ReloadDataBBO();
						goto IL_593;
					}
					if (page.IndexOf("Index Options") > -1)
					{
						this._lastOptionsSel = page;
						this._subGroupType = "SET50Option";
						this._currentBBOpage = page;
						this.ReloadDataBBO();
					}
					else if (page.IndexOf("Futures") > -1)
					{
						this._lastFuturesSel = page;
						this._subGroupType = "Futures Instrument";
						this._currentBBOpage = page;
						this._bboQuerySymbolTFEX = page.Substring(1, page.IndexOf(" ")).Trim();
						this.ReloadDataBBO();
					}
					else if (page.StartsWith("."))
					{
						if (this._isDWGroup)
						{
							this._lastDWsel = page;
							this._currentBBOpage = page;
							this._bboQuerySymbolSector = page.Substring(1);
						}
						else
						{
							this._lastSETsel = page;
							this._subGroupType = "Set Sector";
							this._currentBBOpage = page;
							this._bboQuerySymbolSector = page.Trim();
						}
						this.ReloadDataBBO();
					}
					IL_593:
					if (this._subGroupType == "SET50Option")
					{
						if (!this.intzaOption.Visible)
						{
							this.panelBidOffer.SuspendLayout();
							this.intzaBBO.Visible = false;
							this.intzaCMPR.Visible = false;
							this.tStripCP.Visible = true;
							this.intzaOption.Visible = true;
							this.panelBidOffer.ResumeLayout();
						}
					}
					else if (this._mainGroupType == "%CMPR")
					{
						this.tStripCP.Visible = false;
						this.intzaCMPR.Visible = true;
						this.intzaBBO.Visible = false;
						this.intzaOption.Visible = false;
					}
					else
					{
						this.tStripCP.Visible = false;
						this.intzaBBO.Visible = true;
						this.intzaOption.Visible = false;
						this.intzaCMPR.Visible = false;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SetBBOSetPage", ex);
				}
				this.tStripBBO.ResumeLayout();
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x0013A220 File Offset: 0x00138620
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowUnderLineBBO(int rowIndex, decimal lastPrice, string bidPrice, string offerPrice)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (lastPrice > 0m)
				{
					if (FormatUtil.Isnumeric(bidPrice) && Convert.ToDecimal(bidPrice) == lastPrice)
					{
						this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Underline;
					}
					else
					{
						this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Regular;
					}
					if (FormatUtil.Isnumeric(offerPrice) && Convert.ToDecimal(offerPrice) == lastPrice)
					{
						this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Underline;
					}
					else
					{
						this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Regular;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ShowUnderLineBBO", ex);
			}
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x0013A350 File Offset: 0x00138750
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaLS2_ItemDragDrop(object sender, STIControl.ExpandTableGrid.TableMouseEventArgs e, string dragValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetNewStock_Info(dragValue, false);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0013A36C File Offset: 0x0013876C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaInfo_ItemDragDrop(object sender, ItemGridMouseEventArgs e, string dragValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetNewStock_Info(dragValue, false);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0013A388 File Offset: 0x00138788
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaLS2_ItemDragDrop(object sender, STIControl.SortTableGrid.TableMouseEventArgs e, string dragValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetNewStock_Info(dragValue, false);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0013A3A4 File Offset: 0x001387A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this.IsInfoLoading)
			{
				this.SetNewStock_Info(this.tstbStock.Text.Trim(), false);
			}
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0013A3E8 File Offset: 0x001387E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaTP_TableMouseClick(object sender, STIControl.SortTableGrid.TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (Settings.Default.SmartOneClick && e.RowIndex >= 0)
				{
					if (e.Column.Name == "bid" || e.Column.Name == "bidvolume")
					{
						string price = this.intzaTP.Records(e.RowIndex).Fields("bid").Text.ToString();
						string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
						TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, this._currentStock, price, false);
					}
					else if (e.Column.Name == "offer" || e.Column.Name == "offervolume")
					{
						string price = this.intzaTP.Records(e.RowIndex).Fields("offer").Text.ToString();
						string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
						TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, this._currentStock, price, false);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaTP_TableMouseClick", ex);
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0013A5C0 File Offset: 0x001389C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbTickerFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0013A5FC File Offset: 0x001389FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaLS2_TableMouseClick(object sender, STIControl.ExpandTableGrid.TableMouseEventArgs e)
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
					TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, this._currentStock, text, false);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaLS2_TableMouseClick", ex);
			}
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0013A6F8 File Offset: 0x00138AF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlinkModeTopPrice()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.SetBlinkModeTopPrice));
			}
			else
			{
				try
				{
					this.IsInfoLoading = true;
					FormatType columnFormat = FormatType.BidOfferVolWhite;
					if (ApplicationInfo.IsSupportTPBlinkColor)
					{
						columnFormat = FormatType.BidOfferVolume;
					}
					for (int i = 0; i < this.intzaTP.Rows; i++)
					{
						this.intzaTP.Records(i).Fields("bidvolume").ColumnFormat = columnFormat;
						this.intzaTP.Records(i).Fields("offervolume").ColumnFormat = columnFormat;
					}
					for (int i = 0; i < this.intzaBBO.Rows; i++)
					{
						this.intzaBBO.Records(i).Fields("bidvol").ColumnFormat = columnFormat;
						this.intzaBBO.Records(i).Fields("offvol").ColumnFormat = columnFormat;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SetBlinkModeTopPrice", ex);
				}
				this.IsInfoLoading = false;
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0013A84C File Offset: 0x00138C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnAddStock_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._mainGroupType == "Favorites")
			{
				Keys keyData = Keys.Home;
				if (this.tbStockBBO.Visible)
				{
					keyData = Keys.Down;
				}
				this.ShowTextBoxPosition(new KeyEventArgs(keyData));
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0013A8AC File Offset: 0x00138CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tstbStock.Text = this._currentStock;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0013A8D0 File Offset: 0x00138CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBtnBBODelStock()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tStripBBO.InvokeRequired)
			{
				this.tStripBBO.Invoke(new MethodInvoker(this.SetBtnBBODelStock));
			}
			else
			{
				this.tsbtnBBODelStock.Enabled = this._bboFocused;
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0013A930 File Offset: 0x00138D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSwitchChart_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._volAsVisible)
			{
				this._volAsVisible = false;
				this.panelVolAs.Hide();
			}
			this._chartVisible = !this._chartVisible;
			this.pictureBox1.Visible = this._chartVisible;
			if (this._chartVisible)
			{
				this.intzaLS.Visible = false;
				this.pictureBox1.BringToFront();
			}
			else
			{
				this.intzaLS.Visible = true;
			}
			this.tsbtnRefreshChart.Visible = this._chartVisible;
			this.btnCloseChart.Visible = this._chartVisible;
			if (this._chartVisible)
			{
				this.btnCloseChart.BringToFront();
			}
			this.ReloadChart();
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0013AA18 File Offset: 0x00138E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadChart()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._chartVisible)
			{
				if (!this.bgwReloadChart.IsBusy)
				{
					this.bgwReloadChart.RunWorkerAsync();
				}
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0013AA68 File Offset: 0x00138E68
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
				if (this._currentIsSET)
				{
					string text = ApplicationInfo.WebService.GetChartImage(this._stockInfoSET.Number, true, this.intzaLS.Width, this.intzaLS.Height);
					byte[] buffer = Convert.FromBase64String(text);
					using (MemoryStream memoryStream = new MemoryStream(buffer))
					{
						this.pictureBox1.Image = Image.FromStream(memoryStream);
					}
					if (text != null)
					{
						text = string.Empty;
						text = null;
					}
				}
				else
				{
					string chartImage = ApplicationInfo.WebServiceTFEX.GetChartImage(this._seriesInfoTFEX.Symbol, true, this.intzaLS.Width, this.intzaLS.Height, this._seriesInfoTFEX.MarketCode);
					if (!string.IsNullOrEmpty(chartImage))
					{
						byte[] buffer = Convert.FromBase64String(chartImage);
						using (MemoryStream memoryStream = new MemoryStream(buffer))
						{
							this.pictureBox1.Image = Image.FromStream(memoryStream);
						}
					}
					else
					{
						this.pictureBox1.Image = null;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadChart_DoWork", ex);
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0013AC30 File Offset: 0x00139030
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadChart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ShowSplashChart(false);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0013AC4C File Offset: 0x0013904C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsmiShowExpandBBO_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender.Equals(this.tsmiShowBestBO))
			{
				this.intzaBBO.ExpandRows(this._expRowId, 1, "stock", false, false);
				this.intzaBBO.Redraw();
			}
			else if (!this.bgwReloadBBOExp.IsBusy)
			{
				if (sender.Equals(this.tsmiShow3BO))
				{
					this._expRows = 3;
				}
				else
				{
					this._expRows = 5;
				}
				this.bgwReloadBBOExp.RunWorkerAsync();
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0013ACF8 File Offset: 0x001390F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tsmiShowBestBO.Checked = false;
				this.tsmiShow3BO.Checked = false;
				this.tsmiShow5BO.Checked = false;
				if (this.intzaBBO.Records(this._expRowId).Rows == 3)
				{
					this.tsmiShow3BO.Checked = true;
				}
				else if (this.intzaBBO.Records(this._expRowId).Rows == 1)
				{
					this.tsmiShowBestBO.Checked = true;
				}
				else
				{
					this.tsmiShow5BO.Checked = true;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0013ADD4 File Offset: 0x001391D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnRefreshChart_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReloadChart();
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0013ADEC File Offset: 0x001391EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplashChart(bool visible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmMarketWatch.ShowSplashChartCallBack(this.ShowSplashChart), new object[]
				{
					visible
				});
			}
			else if (!base.DesignMode)
			{
				if (visible)
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
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0013AEE0 File Offset: 0x001392E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnColEdit_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.OpenColumnEditor();
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0013AEF8 File Offset: 0x001392F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenColumnEditor()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.OpenColumnEditor));
			}
			else
			{
				try
				{
					if (this._frmColEdit == null || this._frmColEdit.IsDisposed)
					{
						this._frmColEdit = new frmColumnEditor(this.intzaBBO);
					}
					this._frmColEdit.TopLevel = false;
					this._frmColEdit.Parent = this;
					if (base.Left < 0)
					{
						this._frmColEdit.Left = base.Left + (base.Width - this._frmColEdit.Width) / 2;
					}
					else
					{
						this._frmColEdit.Left = (base.Width - this._frmColEdit.Width) / 2;
					}
					if (base.Top < 0)
					{
						this._frmColEdit.Top = base.Top + (base.Height - this._frmColEdit.Height) / 2;
					}
					else
					{
						this._frmColEdit.Top = (base.Height - this._frmColEdit.Height) / 2;
					}
					this._frmColEdit.FormClosed -= new FormClosedEventHandler(this.frmColEdit_FormClosed);
					this._frmColEdit.FormClosed += new FormClosedEventHandler(this.frmColEdit_FormClosed);
					this._frmColEdit.Show();
					this._frmColEdit.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("OpenSystemOptionForm", ex);
				}
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0013B0D0 File Offset: 0x001394D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmColEdit_FormClosed(object sender, FormClosedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._frmColEdit.DialogResult == DialogResult.OK)
			{
				this.intzaBBO.Columns.Clear();
				this.intzaBBO.Columns = this._frmColEdit.AdjColumns;
				this.intzaBBO.CalcColumnWidth();
				this.intzaBBO.Redraw();
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0013B148 File Offset: 0x00139548
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaBBO_ItemDragDrop(object sender, STIControl.ExpandTableGrid.TableMouseEventArgs e, string dragValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._mainGroupType == "Favorites")
				{
					if (dragValue != null && !string.IsNullOrEmpty(dragValue))
					{
						this.tbStockBBO.Hide();
						if (e != null && e.RowIndex <= this.intzaBBO.Rows - 1)
						{
							this.intzaBBO.FocusItemIndex = e.RowIndex;
							this.SetBBONewStock(dragValue);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaBBO_ItemDragDrop", ex);
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0013B218 File Offset: 0x00139618
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaBBO_TableClickExpand(object sender, STIControl.ExpandTableGrid.TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Column.Name == "stock")
				{
					if (!this.bgwReloadBBOExp.IsBusy)
					{
						string text = this.intzaBBO.Records(e.RowIndex).Fields("stock").Text.ToString();
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[text];
						if (stockInformation.Number > 0)
						{
							this._expStockNo = stockInformation.Number;
							this._expCurrentIsSET = true;
						}
						else
						{
							SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[text];
							if (!(seriesInformation.Symbol != string.Empty))
							{
								return;
							}
							this._expSeries = seriesInformation.Symbol;
							this._expCurrentIsSET = false;
						}
						this._expRowId = e.RowIndex;
						this.contextMenuStrip1.Show(this.intzaBBO, e.Mouse.Location);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaBBO_TableClickExpand", ex);
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0013B37C File Offset: 0x0013977C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaBBO_TableMouseClick(object sender, STIControl.ExpandTableGrid.TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1 && e.RowIndex < this.intzaBBO.Rows)
				{
					this.tbStockBBO.Hide();
					string text = this.intzaBBO.Records(e.RowIndex).Fields("stock").Text.ToString();
					if (!string.IsNullOrEmpty(text.Trim()))
					{
						if (Settings.Default.SmartOneClick && (e.Column.Name == "bid" || e.Column.Name == "offer" || e.Column.Name == "prior" || e.Column.Name == "last" || e.Column.Name == "high" || e.Column.Name == "low" || e.Column.Name == "po" || e.Column.Name == "pc"))
						{
							this.SetNewStock_Info(text, false);
							string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
							string price = this.intzaBBO.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString();
							TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, text, price, false);
						}
						else if (e.Mouse.Button == MouseButtons.Left)
						{
							this.SetNewStock_Info(text, false);
						}
						else if (e.Mouse.Button == MouseButtons.Right && e.Column.Name == "stock")
						{
							this.contextLink.Tag = text;
							this.contextLink.Show(this.intzaBBO, e.Mouse.Location);
						}
					}
				}
				else
				{
					string text2 = e.Column.Name.ToLower();
					switch (text2)
					{
					case "pc":
					case "po":
						this.SwitchColumns("avg");
						break;
					case "avg":
						if (ApplicationInfo.MarketState == "M" || ApplicationInfo.MarketState == "R" || ApplicationInfo.MarketState == "C")
						{
							this.SwitchColumns("pc");
						}
						else
						{
							this.SwitchColumns("po");
						}
						break;
					case "chg":
						this.SwitchColumns("pchg");
						break;
					case "pchg":
						this.SwitchColumns("chg");
						break;
					case "mval":
						this.SwitchColumns("mvol");
						break;
					case "mvol":
						this.SwitchColumns("mval");
						break;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("TableMouseClick", ex);
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0013B7D8 File Offset: 0x00139BD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaBBO_TableMouseDoubleClick(object sender, STIControl.ExpandTableGrid.TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._mainGroupType == "Favorites")
				{
					if (e.Mouse.Button == MouseButtons.Left && e.RowIndex > -1 && e.Column.Name == "stock")
					{
						this.ShowTextBoxPosition(new KeyEventArgs(Keys.Home));
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaBBO_TableMouseDoubleClick", ex);
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0013B894 File Offset: 0x00139C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void panelBidOffer_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._bboFocused = true;
			this.intzaBBO.RowSelectType = 3;
			this.SetBtnBBODelStock();
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0013B8C0 File Offset: 0x00139CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void panelBidOffer_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._bboFocused = false;
			this.intzaBBO.RowSelectType = 2;
			this.tbStockBBO.Hide();
			this.intzaBBO.Redraw();
			this.SetBtnBBODelStock();
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0013B910 File Offset: 0x00139D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnBBODelStock_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._mainGroupType == "Favorites")
			{
				this.ClearStockBBO(this.intzaBBO.FocusItemIndex);
				this.tbStockBBO.Hide();
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0013B968 File Offset: 0x00139D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSETNews_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currentStock != string.Empty)
				{
					if (ApplicationInfo.IsSupportEfinChart)
					{
						TemplateManager.Instance.MainForm.SetTemplateLink("News", "NEWS", this._currentStock);
					}
					else
					{
						ApplicationInfo.NewsSymbol = this._currentStock;
						TemplateManager.Instance.MainForm.SetTemplateLink("SET News", string.Empty, this._currentStock);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnSETNews_Click", ex);
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0013BA30 File Offset: 0x00139E30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnHChart_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._currentStock != string.Empty)
				{
					TemplateManager.Instance.MainForm.SetTemplateLink("Graph", "CHART", this._currentStock);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnHChart_Click", ex);
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0013BAB8 File Offset: 0x00139EB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setTopPriceColume(bool isEquity)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaTP.InvokeRequired)
			{
				this.intzaTP.Invoke(new frmMarketWatch.setTopPriceColumeCallBack(this.setTopPriceColume), new object[]
				{
					isEquity
				});
			}
			else
			{
				try
				{
					if (isEquity)
					{
						this.intzaTP.GetColumn("bidvolume").Width = 31;
						this.intzaTP.GetColumn("bid").Width = 19;
						this.intzaTP.GetColumn("offer").Width = 19;
						this.intzaTP.GetColumn("offervolume").Width = 31;
						this.intzaLS.GetColumn("volume").Width = 36;
						this.intzaLS.GetColumn("price").Width = 24;
					}
					else
					{
						this.intzaTP.GetColumn("bidvolume").Width = 23;
						this.intzaTP.GetColumn("bid").Width = 27;
						this.intzaTP.GetColumn("offer").Width = 27;
						this.intzaTP.GetColumn("offervolume").Width = 23;
						this.intzaLS.GetColumn("volume").Width = 26;
						this.intzaLS.GetColumn("price").Width = 34;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("setTopPriceColume", ex);
				}
			}
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0013BC88 File Offset: 0x0013A088
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setBBOColume(bool isEquity)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaTP.InvokeRequired)
			{
				this.intzaTP.Invoke(new frmMarketWatch.setBBOColumeCallBack(this.setBBOColume), new object[]
				{
					isEquity
				});
			}
			else
			{
				try
				{
					if (isEquity)
					{
						this.intzaBBO.GetColumn("bidvolume").Width = 12;
						this.intzaBBO.GetColumn("bid").Width = 8;
						this.intzaBBO.GetColumn("offer").Width = 8;
						this.intzaBBO.GetColumn("offervolume").Width = 12;
						this.intzaBBO.GetColumn("avg").Width = 7;
						this.intzaBBO.GetColumn("mvol").Width = 12;
					}
					else
					{
						this.intzaBBO.GetColumn("bidvolume").Width = 8;
						this.intzaBBO.GetColumn("bid").Width = 12;
						this.intzaBBO.GetColumn("offer").Width = 12;
						this.intzaBBO.GetColumn("offervolume").Width = 8;
						this.intzaBBO.GetColumn("avg").Width = 11;
						this.intzaBBO.GetColumn("mvol").Width = 8;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("setBBOColume", ex);
				}
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0013BE54 File Offset: 0x0013A254
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl_TFEX()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaLS.BeginUpdate();
				this.intzaVolumeByBoard.BeginUpdate();
				this.intzaTP.BeginUpdate();
				this.intzaInfoTFEX.BeginUpdate();
				this.intzaBF.BeginUpdate();
				this.intzaLS.ClearAllText();
				this.intzaVolumeByBoard.ClearAllText();
				this.intzaTP.ClearAllText();
				this.intzaInfoTFEX.ClearAllText();
				this.intzaBF.ClearAllText();
				if (this.tdsMainInfo.Tables.Count > 0)
				{
					if (this.tdsMainInfo.Tables.Contains("series_info") && this.tdsMainInfo.Tables["series_info"].Rows.Count > 0)
					{
						DataRow dataRow = this.tdsMainInfo.Tables["series_info"].Rows[0];
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
							this.intzaInfoTFEX.Item("lastIndex_label").FontColor = Color.Gainsboro;
						}
						this.intzaInfoTFEX.Item("poclose").Text = Utilities.PriceFormat(num4, this._seriesInfoTFEX.NumOfDec);
						decimal num11;
						decimal.TryParse(dataRow["Multiplier"].ToString(), out num11);
						this.intzaInfoTFEX.Item("multiplier").Text = num11.ToString();
						this.intzaInfoTFEX.Item("multiplier").FontColor = MyColor.UnChgColor;
						this.intzaInfoTFEX.Item("tickSize").Text = Utilities.PriceFormat(dataRow["tickSize"].ToString(), this._seriesInfoTFEX.NumOfDec);
						this.intzaInfoTFEX.Item("tickSize").FontColor = MyColor.UnChgColor;
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
						int num12;
						int.TryParse(dataRow["OpenInterest"].ToString(), out num12);
						this.intzaInfoTFEX.Item("oi").Text = Utilities.VolumeFormat(num12, true);
						decimal highPrice;
						decimal.TryParse(dataRow["HighPrice"].ToString(), out highPrice);
						decimal lowPrice;
						decimal.TryParse(dataRow["LowPrice"].ToString(), out lowPrice);
						decimal lastPrice;
						decimal.TryParse(dataRow["LastPrice"].ToString(), out lastPrice);
						int num13;
						int.TryParse(dataRow["TurnOverQty"].ToString(), out num13);
						decimal num14;
						decimal.TryParse(dataRow["TurnOverValue"].ToString(), out num14);
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
						if (num13 > 0)
						{
							decimal num15 = num14 / num13;
						}
						this.UpdateLastPrice(lastPrice, "");
						this.UpdateHeaderPrice(highPrice, lowPrice);
						if (num11 > 0m)
						{
							this.UpdateAllVolumeTFEX(deals, (long)num13, num14, openVolume, longVolume, shortVolume, d / num11, d2 / num11, d3 / num11, num11, num);
						}
						else
						{
							this.UpdateMainBoardValue(deals, (long)num13, 0m);
						}
						long volume = 0L;
						if (this.tdsMainInfo.Tables.Contains("last_sale"))
						{
							for (int i = 0; i < this.tdsMainInfo.Tables["last_sale"].Rows.Count; i++)
							{
								DataRow dataRow2 = this.tdsMainInfo.Tables["last_sale"].Rows[i];
								long.TryParse(dataRow2["iQuantity"].ToString(), out volume);
								decimal price;
								decimal.TryParse(dataRow2["nmrPrice"].ToString(), out price);
								this.UpdateTickerInfo_TFEX(price, dataRow2["sSide"].ToString(), volume, Utilities.GetTimeLastSale(dataRow2["dtLastUpd"].ToString()), i);
							}
						}
					}
					this.setTopPriceColume(false);
					if (this.tdsMainInfo.Tables.Contains("top_price") && this.tdsMainInfo.Tables["top_price"].Rows.Count > 0)
					{
						int seriesNo = 0;
						DataRow dataRow = this.tdsMainInfo.Tables["top_price"].Rows[0];
						long volume2;
						long.TryParse(dataRow["BidQty1"].ToString(), out volume2);
						long volume3;
						long.TryParse(dataRow["BidQty2"].ToString(), out volume3);
						long volume4;
						long.TryParse(dataRow["BidQty3"].ToString(), out volume4);
						long volume5;
						long.TryParse(dataRow["BidQty4"].ToString(), out volume5);
						long volume6;
						long.TryParse(dataRow["BidQty5"].ToString(), out volume6);
						decimal price2;
						decimal.TryParse(dataRow["BidPrice1"].ToString(), out price2);
						decimal price3;
						decimal.TryParse(dataRow["BidPrice2"].ToString(), out price3);
						decimal price4;
						decimal.TryParse(dataRow["BidPrice3"].ToString(), out price4);
						decimal price5;
						decimal.TryParse(dataRow["BidPrice4"].ToString(), out price5);
						decimal price6;
						decimal.TryParse(dataRow["BidPrice5"].ToString(), out price6);
						int.TryParse(dataRow["lOrderBookId"].ToString(), out seriesNo);
						this.UpdateTopPriceInfo_TFEX(seriesNo, "B", price2, price3, price4, price5, price6, volume2, volume3, volume4, volume5, volume6);
						long.TryParse(dataRow["AskQty1"].ToString(), out volume2);
						long.TryParse(dataRow["AskQty2"].ToString(), out volume3);
						long.TryParse(dataRow["AskQty3"].ToString(), out volume4);
						long.TryParse(dataRow["AskQty4"].ToString(), out volume5);
						long.TryParse(dataRow["AskQty5"].ToString(), out volume6);
						decimal.TryParse(dataRow["AskPrice1"].ToString(), out price2);
						decimal.TryParse(dataRow["AskPrice2"].ToString(), out price3);
						decimal.TryParse(dataRow["AskPrice3"].ToString(), out price4);
						decimal.TryParse(dataRow["AskPrice4"].ToString(), out price5);
						decimal.TryParse(dataRow["AskPrice5"].ToString(), out price6);
						this.UpdateTopPriceInfo_TFEX(seriesNo, "A", price2, price3, price4, price5, price6, volume2, volume3, volume4, volume5, volume6);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl_TFEX", ex);
			}
			finally
			{
				this.intzaTP.Redraw();
				this.intzaLS.Redraw();
				this.intzaVolumeByBoard.Redraw();
				this.intzaInfoTFEX.Redraw();
				this.intzaBF.Redraw();
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0013CCC8 File Offset: 0x0013B0C8
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
						this.intzaInfoTFEX.Item("open1").FontColor = this.intzaInfoTFEX.BackColor;
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

		// Token: 0x06001657 RID: 5719 RVA: 0x0013D11C File Offset: 0x0013B51C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateHeaderPrice(decimal highPrice, decimal lowPrice)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tStripMenu.InvokeRequired)
			{
				this.tStripMenu.Invoke(new frmMarketWatch.UpdateHeaderPriceCallBack(this.UpdateHeaderPrice), new object[]
				{
					highPrice,
					lowPrice
				});
			}
			else
			{
				try
				{
					if (this._seriesInfoTFEX != null)
					{
						Color foreColor = default(Color);
						foreColor = Utilities.ComparePriceCFColor(highPrice, this._seriesInfoTFEX);
						this.tstbTfexHigh.Text = Utilities.PriceFormat(highPrice, this._seriesInfoTFEX.NumOfDec);
						this.tstbTfexHigh.ForeColor = foreColor;
						foreColor = Utilities.ComparePriceCFColor(lowPrice, this._seriesInfoTFEX);
						this.tstbTfexLow.Text = Utilities.PriceFormat(lowPrice, this._seriesInfoTFEX.NumOfDec);
						this.tstbTfexLow.ForeColor = foreColor;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateHeaderPrice", ex);
				}
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0013D248 File Offset: 0x0013B648
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateAllVolumeTFEX(int deals, long accVolume, decimal accValue, long openVolume, long longVolume, long shortVolume, decimal openValue, decimal longValue, decimal shortValue, decimal priceQuoteFactor, decimal basis)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal avg = 0m;
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
					avg = Math.Round(accValue / accVolume, 2);
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
				this.UpdateTfexAvg(avg);
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateAllVolumeTFEX", ex);
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0013D684 File Offset: 0x0013BA84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateTickerInfo_TFEX(decimal price, string side, long volume, string lastUpdate, int index)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaLS.InvokeRequired)
			{
				this.intzaLS.Invoke(new frmMarketWatch.UpdateTickerTFEXInfoCallBack(this.UpdateTickerInfo_TFEX), new object[]
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
					STIControl.SortTableGrid.RecordItem recordItem;
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
					recordItem.Fields("price").FontColor = Utilities.ComparePriceCFColor(price, this._seriesInfoTFEX);
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

		// Token: 0x0600165A RID: 5722 RVA: 0x0013D8D8 File Offset: 0x0013BCD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateTopPriceInfo_TFEX(int seriesNo, string side, decimal price1, decimal price2, decimal price3, decimal price4, decimal price5, long volume1, long volume2, long volume3, long volume4, long volume5)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (seriesNo > 0)
				{
					Color fontColor = (Brushes.Yellow as SolidBrush).Color;
					if (side == "B")
					{
						fontColor = Utilities.ComparePriceCFColor(price1, this._seriesInfoTFEX);
						if (volume1 != -1L)
						{
							this.intzaTP.Records(0).Fields("bidvolume").Text = volume1;
							this.intzaTP.Records(0).Fields("bidvolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume1, price1))
							{
								this.intzaTP.Records(0).Fields("bid").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(0).Fields("bid").Text = Utilities.PriceFormat(price1, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(0).Fields("bid").FontColor = fontColor;
						}
						if (volume2 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price2, this._seriesInfoTFEX);
							this.intzaTP.Records(1).Fields("bidvolume").Text = volume2;
							this.intzaTP.Records(1).Fields("bidvolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume2, price2))
							{
								this.intzaTP.Records(1).Fields("bid").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(1).Fields("bid").Text = Utilities.PriceFormat(price2, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(1).Fields("bid").FontColor = fontColor;
						}
						if (volume3 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price3, this._seriesInfoTFEX);
							this.intzaTP.Records(2).Fields("bidvolume").Text = volume3;
							this.intzaTP.Records(2).Fields("bidvolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume3, price3))
							{
								this.intzaTP.Records(2).Fields("bid").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(2).Fields("bid").Text = Utilities.PriceFormat(price3, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(2).Fields("bid").FontColor = fontColor;
						}
						if (volume4 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price4, this._seriesInfoTFEX);
							this.intzaTP.Records(3).Fields("bidvolume").Text = volume4;
							this.intzaTP.Records(3).Fields("bidvolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume4, price4))
							{
								this.intzaTP.Records(3).Fields("bid").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(3).Fields("bid").Text = Utilities.PriceFormat(price4, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(3).Fields("bid").FontColor = fontColor;
						}
						if (volume5 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price5, this._seriesInfoTFEX);
							this.intzaTP.Records(4).Fields("bidvolume").Text = volume5;
							this.intzaTP.Records(4).Fields("bidvolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume5, price5))
							{
								this.intzaTP.Records(4).Fields("bid").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(4).Fields("bid").Text = Utilities.PriceFormat(price5, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(4).Fields("bid").FontColor = fontColor;
						}
					}
					else if (side == "A")
					{
						if (volume1 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price1, this._seriesInfoTFEX);
							this.intzaTP.Records(0).Fields("offervolume").Text = volume1;
							this.intzaTP.Records(0).Fields("offervolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume1, price1))
							{
								this.intzaTP.Records(0).Fields("offer").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(0).Fields("offer").Text = Utilities.PriceFormat(price1, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(0).Fields("offer").FontColor = fontColor;
						}
						if (volume2 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price2, this._seriesInfoTFEX);
							this.intzaTP.Records(1).Fields("offervolume").Text = volume2;
							this.intzaTP.Records(1).Fields("offervolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume2, price2))
							{
								this.intzaTP.Records(1).Fields("offer").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(1).Fields("offer").Text = Utilities.PriceFormat(price2, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(1).Fields("offer").FontColor = fontColor;
						}
						if (volume3 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price3, this._seriesInfoTFEX);
							this.intzaTP.Records(2).Fields("offervolume").Text = volume3;
							this.intzaTP.Records(2).Fields("offervolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume3, price3))
							{
								this.intzaTP.Records(2).Fields("offer").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(2).Fields("offer").Text = Utilities.PriceFormat(price3, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(2).Fields("offer").FontColor = fontColor;
						}
						if (volume4 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price4, this._seriesInfoTFEX);
							this.intzaTP.Records(3).Fields("offervolume").Text = volume4;
							this.intzaTP.Records(3).Fields("offervolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume4, price4))
							{
								this.intzaTP.Records(3).Fields("offer").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(3).Fields("offer").Text = Utilities.PriceFormat(price4, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(3).Fields("offer").FontColor = fontColor;
						}
						if (volume5 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price5, this._seriesInfoTFEX);
							this.intzaTP.Records(4).Fields("offervolume").Text = volume5;
							this.intzaTP.Records(4).Fields("offervolume").FontColor = fontColor;
							if (Utilities.GetTopPriceZero(volume5, price5))
							{
								this.intzaTP.Records(4).Fields("offer").Text = "0.00";
							}
							else
							{
								this.intzaTP.Records(4).Fields("offer").Text = Utilities.PriceFormat(price5, this._seriesInfoTFEX.NumOfDec);
							}
							this.intzaTP.Records(4).Fields("offer").FontColor = fontColor;
						}
					}
					if (side == "B")
					{
						this._seriesInfoTFEX.BidVol1 = volume1;
						this._seriesInfoTFEX.BidVol2 = volume2;
						this._seriesInfoTFEX.BidVol3 = volume3;
						this._seriesInfoTFEX.BidVol4 = volume4;
						this._seriesInfoTFEX.BidVol5 = volume5;
					}
					else
					{
						this._seriesInfoTFEX.OffVol1 = volume1;
						this._seriesInfoTFEX.OffVol2 = volume2;
						this._seriesInfoTFEX.OffVol3 = volume3;
						this._seriesInfoTFEX.OffVol4 = volume4;
						this._seriesInfoTFEX.OffVol5 = volume5;
					}
					if (this._seriesInfoTFEX.SumBidVol + this._seriesInfoTFEX.SumOffVol > 0L)
					{
						this.intzaBF.Item("item").Text = Utilities.PriceFormat(this._seriesInfoTFEX.SumBidVol / (this._seriesInfoTFEX.SumBidVol + this._seriesInfoTFEX.SumOffVol) * 100m, 2, "0");
					}
					else
					{
						this.intzaBF.Item("item").Text = "";
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateTopPriceInfo_TFEX", ex);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0013E3C8 File Offset: 0x0013C7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateTfexAvg(decimal avg)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.tStripMenu.InvokeRequired)
			{
				this.tStripMenu.Invoke(new frmMarketWatch.UpdateTfexAvgCallBack(this.UpdateTfexAvg), new object[]
				{
					avg
				});
			}
			else
			{
				try
				{
					this.tstbTfexAvg.Text = Utilities.PriceFormat(avg, this._seriesInfoTFEX.NumOfDec);
					this.tstbTfexAvg.ForeColor = Utilities.ComparePriceCFColor(avg, this._seriesInfoTFEX);
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateAvg", ex);
				}
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0013E494 File Offset: 0x0013C894
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBBOTopPrice_Options(int rowIndex, string type, string side, string volume, string price, SeriesList.SeriesInformation seriesInfoForOptionCrtl)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaOption.InvokeRequired)
			{
				frmMarketWatch.UpdateBBOTopPriceOptionsCallBack method = new frmMarketWatch.UpdateBBOTopPriceOptionsCallBack(this.UpdateBBOTopPrice_Options);
				this.intzaOption.Invoke(method, new object[]
				{
					rowIndex,
					type,
					side,
					volume,
					price,
					seriesInfoForOptionCrtl
				});
			}
			else
			{
				try
				{
					if (rowIndex > -1)
					{
						Color fontColor = MyColor.UnChgColor;
						if (volume != "-1")
						{
							if (type == "CALL")
							{
								this.intzaOption.Records(rowIndex).Fields("sSeriesOC").Text = seriesInfoForOptionCrtl.Symbol;
								if (side == "B")
								{
									fontColor = Utilities.ComparePriceCFColor(price, seriesInfoForOptionCrtl);
									this.intzaOption.Records(rowIndex).Fields("callbid").Text = Utilities.PriceFormat(price);
									this.intzaOption.Records(rowIndex).Fields("callbid").FontColor = fontColor;
									this.intzaOption.Records(rowIndex).Fields("callbidvol").Text = volume;
									this.intzaOption.Records(rowIndex).Fields("callbidvol").FontColor = fontColor;
								}
								else
								{
									fontColor = Utilities.ComparePriceCFColor(price, seriesInfoForOptionCrtl);
									this.intzaOption.Records(rowIndex).Fields("calloffer").Text = Utilities.PriceFormat(price);
									this.intzaOption.Records(rowIndex).Fields("calloffer").FontColor = fontColor;
									this.intzaOption.Records(rowIndex).Fields("calloffvol").Text = volume;
									this.intzaOption.Records(rowIndex).Fields("calloffvol").FontColor = fontColor;
								}
							}
							else
							{
								this.intzaOption.Records(rowIndex).Fields("sSeriesOP").Text = seriesInfoForOptionCrtl.Symbol;
								if (side == "B")
								{
									fontColor = Utilities.ComparePriceCFColor(price, seriesInfoForOptionCrtl);
									this.intzaOption.Records(rowIndex).Fields("putbid").Text = Utilities.PriceFormat(price);
									this.intzaOption.Records(rowIndex).Fields("putbid").FontColor = fontColor;
									this.intzaOption.Records(rowIndex).Fields("putbidvol").Text = volume;
									this.intzaOption.Records(rowIndex).Fields("putbidvol").FontColor = fontColor;
								}
								else
								{
									fontColor = Utilities.ComparePriceCFColor(price, seriesInfoForOptionCrtl);
									this.intzaOption.Records(rowIndex).Fields("putoffer").Text = Utilities.PriceFormat(price);
									this.intzaOption.Records(rowIndex).Fields("putoffer").FontColor = fontColor;
									this.intzaOption.Records(rowIndex).Fields("putoffvol").Text = volume;
									this.intzaOption.Records(rowIndex).Fields("putoffvol").FontColor = fontColor;
								}
							}
						}
					}
					this.intzaOption.Redraw();
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateTopPriceBBO_Options", ex);
				}
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0013E840 File Offset: 0x0013CC40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateLastPriceBBOOption(int rowIndex, string type, decimal lastPrice, decimal chg, SeriesList.SeriesInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaOption.InvokeRequired)
			{
				this.intzaOption.Invoke(new frmMarketWatch.UpdateLastPriceBBOOptionsCallBack(this.UpdateLastPriceBBOOption), new object[]
				{
					rowIndex,
					type,
					lastPrice,
					chg,
					stockInfo
				});
			}
			else
			{
				try
				{
					Color fontColor = MyColor.UnChgColor;
					if (lastPrice > 0m)
					{
						fontColor = Utilities.ComparePriceCFColor(lastPrice, stockInfo);
					}
					if (type == "CALL")
					{
						this.intzaOption.Records(rowIndex).Fields("calllast").Text = lastPrice;
						this.intzaOption.Records(rowIndex).Fields("calllast").FontColor = fontColor;
						this.intzaOption.Records(rowIndex).Fields("callchg").Text = chg;
						this.intzaOption.Records(rowIndex).Fields("callchg").FontColor = fontColor;
					}
					else
					{
						this.intzaOption.Records(rowIndex).Fields("putlast").Text = lastPrice;
						this.intzaOption.Records(rowIndex).Fields("putlast").FontColor = fontColor;
						this.intzaOption.Records(rowIndex).Fields("putchg").Text = chg;
						this.intzaOption.Records(rowIndex).Fields("putchg").FontColor = fontColor;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateLastPriceBBOOption", ex);
				}
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0013EA3C File Offset: 0x0013CE3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				try
				{
					if (!this.IsInfoLoading && !this._currentIsSET)
					{
						if (this._seriesInfoTFEX != null && realtimeSeriesInfo != null)
						{
							string text = message.MessageType;
							switch (text)
							{
							case "TP":
								if (realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
								{
									TPMessageTFEX tPMessageTFEX = (TPMessageTFEX)message;
									this.UpdateTopPriceInfo_TFEX(tPMessageTFEX.OrderBookId, tPMessageTFEX.Side, tPMessageTFEX.Price1, tPMessageTFEX.Price2, tPMessageTFEX.Price3, tPMessageTFEX.Price4, tPMessageTFEX.Price5, (long)tPMessageTFEX.Vol1, (long)tPMessageTFEX.Vol2, (long)tPMessageTFEX.Vol3, (long)tPMessageTFEX.Vol4, (long)tPMessageTFEX.Vol5);
									if (base.IsAllowRender)
									{
										this.intzaTP.EndUpdate();
									}
								}
								break;
							case "LS":
								if (realtimeSeriesInfo.Symbol == this._seriesInfoTFEX.Symbol)
								{
									LSMessageTFEX lSMessageTFEX = (LSMessageTFEX)message;
									if (lSMessageTFEX.DealSource == 20)
									{
										if (ApplicationInfo.IndexInfoTfex.TXIState != "3C")
										{
											this.UpdateOpenOrProjectOpenPriceTFEX(ApplicationInfo.IndexInfoTfex.TXIState, lSMessageTFEX.Price, realtimeSeriesInfo);
										}
										else
										{
											this.UpdateOpenOrProjectOpenPriceTFEX(ApplicationInfo.IndexInfoTfex.TXMState, lSMessageTFEX.Price, realtimeSeriesInfo);
										}
									}
									this.UpdateLastPrice(lSMessageTFEX.Price, "");
									this.UpdateHeaderPrice(lSMessageTFEX.High, lSMessageTFEX.Low);
									this.UpdateAllVolumeTFEX(lSMessageTFEX.Deals, (long)lSMessageTFEX.AccVolume, lSMessageTFEX.AccValue, (long)lSMessageTFEX.OpenQty, (long)lSMessageTFEX.LongQty, (long)lSMessageTFEX.ShortQty, lSMessageTFEX.OpenValue, lSMessageTFEX.LongValue, lSMessageTFEX.ShortValue, realtimeSeriesInfo.ContractSize, lSMessageTFEX.Basis);
									if (base.IsAllowRender)
									{
										this.intzaInfoTFEX.EndUpdate();
										this.intzaVolumeByBoard.EndUpdate();
									}
									int num = lSMessageTFEX.Vol;
									int num2;
									int.TryParse(num.ToString(), out num2);
									this.UpdateTickerInfo_TFEX(lSMessageTFEX.Price, lSMessageTFEX.Side, (long)num2, lSMessageTFEX.LastTime, -1);
									if (base.IsAllowRender)
									{
										this.intzaLS.Redraw();
									}
								}
								break;
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
									IntzaBaseItem arg_48E_0 = this.intzaInfoTFEX.Item("multiplier");
									int num = sDMessageTFEX.Price_quot_factor;
									arg_48E_0.Text = num.ToString();
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
										if (realtimeSeriesInfo.MarketCode == 4 || realtimeSeriesInfo.MarketCode == 5)
										{
											this.intzaInfoTFEX.Item("psettle").Text = Utilities.PriceFormat(cA8MessageTFEX.FixingPrice, this._seriesInfoTFEX.NumOfDec);
										}
									}
									else
									{
										this.intzaInfoTFEX.Item("psettle").Text = Utilities.PriceFormat(cA8MessageTFEX.FixingPrice, this._seriesInfoTFEX.NumOfDec);
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
									if (base.IsAllowRender)
									{
										this.intzaInfoTFEX.EndUpdate();
									}
								}
								break;
							}
						}
						else if (message.MessageType == "IU")
						{
							IUMessageTFEX iUMessageTFEX = (IUMessageTFEX)message;
							if (this._seriesInfoTFEX != null && this._seriesInfoTFEX.UnderOrderBookId == iUMessageTFEX.OrderBookId)
							{
								if (this._seriesInfoTFEX.Group == 1 && this._seriesInfoTFEX.LastSalePrice != 0m)
								{
									this.intzaInfoTFEX.Item("basis").Text = (iUMessageTFEX.LastIndx - this._seriesInfoTFEX.StrikPrice).ToString();
									this.intzaInfoTFEX.Item("basis").FontColor = Utilities.ComparePriceColor(iUMessageTFEX.LastIndx - this._seriesInfoTFEX.StrikPrice, 0m);
								}
								else if (this._seriesInfoTFEX.Group == 2 && this._seriesInfoTFEX.LastSalePrice != 0m)
								{
									this.intzaInfoTFEX.Item("basis").Text = (this._seriesInfoTFEX.StrikPrice - iUMessageTFEX.LastIndx).ToString();
									this.intzaInfoTFEX.Item("basis").FontColor = Utilities.ComparePriceColor(this._seriesInfoTFEX.StrikPrice - iUMessageTFEX.LastIndx, 0m);
								}
								else if (this._seriesInfoTFEX.Group != 1 && this._seriesInfoTFEX.Group != 2 && this._seriesInfoTFEX.LastSalePrice != 0m && iUMessageTFEX.LastIndx != 0m)
								{
									this.intzaInfoTFEX.Item("basis").Text = (this._seriesInfoTFEX.LastSalePrice - iUMessageTFEX.LastIndx).ToString();
									this.intzaInfoTFEX.Item("basis").FontColor = Utilities.ComparePriceColor(this._seriesInfoTFEX.LastSalePrice - iUMessageTFEX.LastIndx, 0m);
								}
								this.intzaInfoTFEX.Item("lastIndex").Text = iUMessageTFEX.LastIndx.ToString();
								this.intzaInfoTFEX.Item("lastIndex").FontColor = MyColor.UnChgColor;
							}
							if (base.IsAllowRender)
							{
								this.intzaInfoTFEX.EndUpdate();
							}
						}
					}
					if (!this.IsBBOLoading)
					{
						string text = this._mainGroupType;
						if (text != null)
						{
							if (!(text == "Futures") && !(text == "Option"))
							{
								if (text == "Favorites")
								{
									this.ReceiveMessageBBO_TFEX(message, realtimeSeriesInfo);
								}
							}
							else if (this._subGroupType == "SET50Option")
							{
								this.ReceiveMessageBBO_Options(message, realtimeSeriesInfo);
							}
							else
							{
								this.ReceiveMessageBBO_TFEX(message, realtimeSeriesInfo);
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ReceiveTfexMessage", ex);
				}
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0013F568 File Offset: 0x0013D968
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReceiveMessageBBO_Options(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string messageType = message.MessageType;
				if (messageType != null)
				{
					if (!(messageType == "TP"))
					{
						if (messageType == "LS")
						{
							if (realtimeSeriesInfo != null)
							{
								int num = this.intzaOption.FindIndex("strike", realtimeSeriesInfo.StrikPrice.ToString().Replace(".000000", ""));
								if (num > -1)
								{
									LSMessageTFEX lSMessageTFEX = (LSMessageTFEX)message;
									if (realtimeSeriesInfo.Group == 1 && lSMessageTFEX.Sec == this.intzaOption.Records(num).Fields("sSeriesOC").Text.ToString())
									{
										this.UpdateLastPriceBBOOption(num, "CALL", lSMessageTFEX.Price, lSMessageTFEX.Price - realtimeSeriesInfo.PrevFixPrice, realtimeSeriesInfo);
										if (base.IsAllowRender)
										{
											this.intzaOption.EndUpdate(num);
										}
									}
									else if (realtimeSeriesInfo.Group == 2 && lSMessageTFEX.Sec == this.intzaOption.Records(num).Fields("sSeriesOP").Text.ToString())
									{
										this.UpdateLastPriceBBOOption(num, "PUT", lSMessageTFEX.Price, lSMessageTFEX.Price - realtimeSeriesInfo.PrevFixPrice, realtimeSeriesInfo);
										if (base.IsAllowRender)
										{
											this.intzaOption.EndUpdate(num);
										}
									}
								}
							}
						}
					}
					else if (realtimeSeriesInfo != null)
					{
						string keyValue = Utilities.PriceFormat(realtimeSeriesInfo.StrikPrice);
						int num = this.intzaOption.FindIndex("strike", keyValue);
						if (num > -1)
						{
							TPMessageTFEX tPMessageTFEX = (TPMessageTFEX)message;
							if (realtimeSeriesInfo.Group == 1 && tPMessageTFEX.OrderBookId.ToString() == this.intzaOption.Records(num).Fields("sSeriesOC").Text.ToString())
							{
								this.UpdateBBOTopPrice_Options(num, "CALL", tPMessageTFEX.Side, tPMessageTFEX.Vol1.ToString(), tPMessageTFEX.Price1.ToString(), realtimeSeriesInfo);
								if (base.IsAllowRender)
								{
									this.intzaOption.EndUpdate(num);
								}
							}
							else if (realtimeSeriesInfo.Group == 2 && tPMessageTFEX.OrderBookId.ToString() == this.intzaOption.Records(num).Fields("sSeriesOP").Text.ToString())
							{
								this.UpdateBBOTopPrice_Options(num, "PUT", tPMessageTFEX.Side, tPMessageTFEX.Vol1.ToString(), tPMessageTFEX.Price1.ToString(), realtimeSeriesInfo);
								if (base.IsAllowRender)
								{
									this.intzaOption.EndUpdate(num);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SecurityInfo::RecvMessage", ex);
			}
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0013F928 File Offset: 0x0013DD28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReceiveMessageBBO_TFEX(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (realtimeSeriesInfo != null)
				{
					string messageType = message.MessageType;
					if (messageType != null)
					{
						if (!(messageType == "TP"))
						{
							if (!(messageType == "LS"))
							{
								if (!(messageType == "CA8"))
								{
									if (messageType == "TCF")
									{
										if (realtimeSeriesInfo.Symbol != "")
										{
											int num = this.intzaBBO.FindIndex("stock", realtimeSeriesInfo.Symbol);
											if (num > -1)
											{
												TCFMessageTFEX tCFMessageTFEX = (TCFMessageTFEX)message;
												STIControl.ExpandTableGrid.RecordItem recordItem = this.intzaBBO.Records(num);
												recordItem.Fields("prior").Text = Utilities.PriceFormat(tCFMessageTFEX.PrevFixPrice, realtimeSeriesInfo.NumOfDec);
												if (base.IsAllowRender)
												{
													this.intzaBBO.EndUpdate(num);
												}
											}
										}
									}
								}
								else if (realtimeSeriesInfo.Symbol != "")
								{
									int num = this.intzaBBO.FindIndex("stock", realtimeSeriesInfo.Symbol);
									if (num > -1)
									{
										CA8MessageTFEX cA8MessageTFEX = (CA8MessageTFEX)message;
										STIControl.ExpandTableGrid.RecordItem recordItem = this.intzaBBO.Records(num);
										recordItem.Fields("prior").Text = Utilities.PriceFormat(cA8MessageTFEX.FixingPrice, realtimeSeriesInfo.NumOfDec);
										if (base.IsAllowRender)
										{
											this.intzaBBO.EndUpdate(num);
										}
									}
								}
							}
							else if (realtimeSeriesInfo.Symbol != "")
							{
								int num = this.intzaBBO.FindIndex("stock", realtimeSeriesInfo.Symbol);
								if (num > -1)
								{
									LSMessageTFEX lSMessageTFEX = (LSMessageTFEX)message;
									this.UpdateLastPriceBBO_TFEX(num, lSMessageTFEX.Price, realtimeSeriesInfo.PrevFixPrice, (long)lSMessageTFEX.AccVolume, lSMessageTFEX.AccValue, (long)lSMessageTFEX.Deals, "", realtimeSeriesInfo, lSMessageTFEX.High, lSMessageTFEX.Low, (long)lSMessageTFEX.LongQty, (long)lSMessageTFEX.ShortQty);
									this.ShowUnderLineBBOTFEX(num, lSMessageTFEX.Price, realtimeSeriesInfo.BidPrice1.ToString(), realtimeSeriesInfo.OfferPrice1.ToString());
									if (base.IsAllowRender)
									{
										this.intzaBBO.EndUpdate(num);
									}
								}
							}
						}
						else if (realtimeSeriesInfo.Symbol != string.Empty)
						{
							int num = this.intzaBBO.FindIndex("stock", realtimeSeriesInfo.Symbol);
							if (num > -1)
							{
								TPMessageTFEX tPMessageTFEX = (TPMessageTFEX)message;
								if (tPMessageTFEX.Side == "B")
								{
									realtimeSeriesInfo.BidVol1 = (long)tPMessageTFEX.Vol1;
									realtimeSeriesInfo.BidVol2 = (long)tPMessageTFEX.Vol2;
									realtimeSeriesInfo.BidVol3 = (long)tPMessageTFEX.Vol3;
									realtimeSeriesInfo.BidVol4 = (long)tPMessageTFEX.Vol4;
									realtimeSeriesInfo.BidVol5 = (long)tPMessageTFEX.Vol5;
								}
								else if (tPMessageTFEX.Side == "A")
								{
									realtimeSeriesInfo.OffVol1 = (long)tPMessageTFEX.Vol1;
									realtimeSeriesInfo.OffVol2 = (long)tPMessageTFEX.Vol2;
									realtimeSeriesInfo.OffVol3 = (long)tPMessageTFEX.Vol3;
									realtimeSeriesInfo.OffVol4 = (long)tPMessageTFEX.Vol4;
									realtimeSeriesInfo.OffVol5 = (long)tPMessageTFEX.Vol5;
								}
								this.UpdateBBOTopPrice_TFEX(num, tPMessageTFEX.Side, tPMessageTFEX.Price1.ToString(), (long)tPMessageTFEX.Vol1, realtimeSeriesInfo.PrevFixPrice, realtimeSeriesInfo.LastSalePrice, realtimeSeriesInfo);
								this.UpdateBidOfferVolPct(num, realtimeSeriesInfo.SumBidVol, realtimeSeriesInfo.SumOffVol);
								if (this.intzaBBO.Records(num).Rows > 1)
								{
									this.UpdateBBOBidsTFEX(this.intzaBBO.Records(num), realtimeSeriesInfo, tPMessageTFEX.Side, tPMessageTFEX.Price2.ToString(), (long)tPMessageTFEX.Vol2, tPMessageTFEX.Price3.ToString(), (long)tPMessageTFEX.Vol3, tPMessageTFEX.Price4.ToString(), (long)tPMessageTFEX.Vol4, tPMessageTFEX.Price5.ToString(), (long)tPMessageTFEX.Vol5);
								}
								if (base.IsAllowRender)
								{
									this.intzaBBO.EndUpdate(num);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SecurityInfo::RecvMessage", ex);
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0013FE48 File Offset: 0x0013E248
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowUnderLineBBOTFEX(int rowIndex, decimal lastPrice, string bidPrice, string offerPrice)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal d;
				decimal.TryParse(bidPrice, out d);
				if (d == lastPrice)
				{
					this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Underline;
				}
				else
				{
					this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Regular;
				}
				decimal.TryParse(offerPrice, out d);
				if (d == lastPrice)
				{
					this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Underline;
				}
				else
				{
					this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Regular;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateUnderLineBBO_RealtimeLS_TFEX", ex);
			}
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0013FF44 File Offset: 0x0013E344
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RequestWebOptionsData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = string.Empty;
			IFormatProvider provider = new CultureInfo("en-US", true);
			try
			{
				if (this._set50OptList == null)
				{
					this._set50OptList = Utilities.GetFullOptionsName();
				}
				if (this._set50OptList.ContainsValue(this._currentBBOpage))
				{
					string text2 = this.findMyValue(this._set50OptList, this._currentBBOpage);
					text = ApplicationInfo.WebServiceTFEX.BestBidOfferByOptionsList(text2.Trim());
					DateTime dateValue = Utilities.GetDateValue(text2.Trim());
					this._bboOptionsHeaderText = dateValue.ToString("dd MMM yyyy", provider);
					int num = dateValue.Subtract(DateTime.Now).Days + 1;
					object bboOptionsHeaderText = this._bboOptionsHeaderText;
					this._bboOptionsHeaderText = string.Concat(new object[]
					{
						bboOptionsHeaderText,
						"  ",
						num,
						" Days to expiration"
					});
				}
				if (!string.IsNullOrEmpty(text))
				{
					this.tdsSet50Option.Clear();
					MyDataHelper.StringToDataSet(text, this.tdsSet50Option);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("RequestWebOptionsData", ex);
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x001400B8 File Offset: 0x0013E4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl_BBO_TFEX(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ds != null && ds.Tables.Contains("Table"))
				{
					if (this._mainGroupType != "Favorites")
					{
						int count = ds.Tables["Table"].Rows.Count;
						this.intzaBBO.BeginUpdate();
						if (this.intzaBBO.Rows != count)
						{
							this.intzaBBO.Rows = count;
						}
						else
						{
							this.intzaBBO.ClearAllText();
						}
					}
					long accVolume = 0L;
					long buyVol = 0L;
					long sellVol = 0L;
					long deals = 0L;
					decimal prior = 0m;
					decimal num = 0m;
					decimal num2 = 0m;
					decimal accValue = 0m;
					decimal highPrice = 0m;
					decimal lowPrice = 0m;
					int num3 = -1;
					foreach (DataRow dataRow in ds.Tables["Table"].Rows)
					{
						SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[dataRow["sSeries"].ToString().Trim()];
						if (this._mainGroupType == "Favorites")
						{
							num3 = ApplicationInfo.FavStockList[this._bboPage].IndexOf(seriesInformation.Symbol);
						}
						else
						{
							num3++;
						}
						if (num3 > -1)
						{
							this.intzaBBO.Records(num3).Changed = true;
							this.intzaBBO.Records(num3).Fields("stock").Text = seriesInformation.Symbol;
							decimal.TryParse(dataRow["nmrFixPrice"].ToString(), out num);
							decimal.TryParse(dataRow["nmrPrevFixPrice"].ToString(), out prior);
							decimal.TryParse(dataRow["AccValue"].ToString(), out accValue);
							decimal.TryParse(dataRow["nmrPrice"].ToString(), out num2);
							decimal.TryParse(dataRow["nmrHigh"].ToString(), out highPrice);
							decimal.TryParse(dataRow["nmrLow"].ToString(), out lowPrice);
							long.TryParse(dataRow["iSumLongVol"].ToString(), out buyVol);
							long.TryParse(dataRow["iSumShortVol"].ToString(), out sellVol);
							long.TryParse(dataRow["NumOfDeal"].ToString(), out deals);
							seriesInformation.BidVol1 = Convert.ToInt64(dataRow["iBidQuantity1"].ToString());
							seriesInformation.BidVol2 = Convert.ToInt64(dataRow["iBidQuantity2"].ToString());
							seriesInformation.BidVol3 = Convert.ToInt64(dataRow["iBidQuantity3"].ToString());
							seriesInformation.BidVol4 = Convert.ToInt64(dataRow["iBidQuantity4"].ToString());
							seriesInformation.BidVol5 = Convert.ToInt64(dataRow["iBidQuantity5"].ToString());
							seriesInformation.OffVol1 = Convert.ToInt64(dataRow["iAskQuantity1"].ToString());
							seriesInformation.OffVol2 = Convert.ToInt64(dataRow["iAskQuantity2"].ToString());
							seriesInformation.OffVol3 = Convert.ToInt64(dataRow["iAskQuantity3"].ToString());
							seriesInformation.OffVol4 = Convert.ToInt64(dataRow["iAskQuantity4"].ToString());
							seriesInformation.OffVol5 = Convert.ToInt64(dataRow["iAskQuantity5"].ToString());
							this.UpdateBBOTopPrice_TFEX(num3, "B", dataRow["nmrBidPrice1"].ToString(), seriesInformation.BidVol1, prior, num2, seriesInformation);
							this.UpdateBBOTopPrice_TFEX(num3, "A", dataRow["nmrAskPrice1"].ToString(), seriesInformation.OffVol1, prior, num2, seriesInformation);
							long.TryParse(dataRow["iTurnOver"].ToString(), out accVolume);
							this.UpdateLastPriceBBO_TFEX(num3, num2, prior, accVolume, accValue, deals, "", seriesInformation, highPrice, lowPrice, buyVol, sellVol);
							this.UpdateBidOfferVolPct(num3, seriesInformation.SumBidVol, seriesInformation.SumOffVol);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl_BBO_TFEX", ex);
			}
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x001405E4 File Offset: 0x0013E9E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateLastPriceBBO_TFEX(int rowIndex, decimal lastPrice, decimal prior, long accVolume, decimal accValue, long deals, string comparePrice, SeriesList.SeriesInformation serieInfo, decimal highPrice, decimal lowPrice, long buyVol, long sellVol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaBBO.InvokeRequired)
			{
				this.intzaBBO.Invoke(new frmMarketWatch.UpdateLastPriceBBO_TFEXCallBack(this.UpdateLastPriceBBO_TFEX), new object[]
				{
					rowIndex,
					lastPrice,
					prior,
					accVolume,
					accValue,
					deals,
					comparePrice,
					serieInfo,
					highPrice,
					lowPrice,
					buyVol,
					sellVol
				});
			}
			else
			{
				try
				{
					decimal num = 0m;
					decimal num2 = 0m;
					decimal num3 = 0m;
					if (lastPrice > 0m && prior > 0m)
					{
						num = lastPrice - prior;
						num2 = num / prior * 100m;
					}
					if (accVolume > 0L)
					{
						num3 = accValue / accVolume;
					}
					decimal num4 = 0m;
					decimal num5 = 0m;
					if (accVolume > 0L)
					{
						num5 = sellVol / accVolume * 100m;
						num4 = buyVol / accVolume * 100m;
					}
					Color fontColor = MyColor.UnChgColor;
					if (lastPrice > 0m)
					{
						fontColor = Utilities.ComparePriceCFColor(lastPrice, serieInfo);
					}
					STIControl.ExpandTableGrid.RecordItem recordItem = this.intzaBBO.Records(rowIndex);
					recordItem.Fields("prior").Text = Utilities.PriceFormat(prior, serieInfo.NumOfDec);
					recordItem.Fields("last").Text = Utilities.PriceFormat(lastPrice, serieInfo.NumOfDec);
					recordItem.Fields("chg").Text = num;
					recordItem.Fields("high").Text = highPrice;
					recordItem.Fields("low").Text = lowPrice;
					recordItem.Fields("avg").Text = num3;
					recordItem.Fields("pchg").Text = num2;
					recordItem.Fields("buyvolpct").Text = num4;
					recordItem.Fields("selvolpct").Text = num5;
					recordItem.Fields("mvol").Text = accVolume;
					recordItem.Fields("mval").Text = accValue * serieInfo.ContractSize / 1000m;
					recordItem.Fields("deals").Text = deals;
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					recordItem.Fields("chg").FontColor = fontColor;
					recordItem.Fields("pchg").FontColor = fontColor;
					recordItem.Fields("prior").FontColor = MyColor.UnChgColor;
					recordItem.Fields("mvol").FontColor = MyColor.UnChgColor;
					recordItem.Fields("mval").FontColor = MyColor.UnChgColor;
					recordItem.Fields("deals").FontColor = MyColor.UnChgColor;
					recordItem.Fields("high").FontColor = Utilities.ComparePriceCFColor(highPrice, serieInfo);
					recordItem.Fields("low").FontColor = Utilities.ComparePriceCFColor(lowPrice, serieInfo);
					recordItem.Fields("avg").FontColor = Utilities.ComparePriceCFColor(num3, serieInfo);
					recordItem.Fields("pchg").FontColor = fontColor;
					recordItem.Fields("buyvolpct").FontColor = MyColor.BuyColor;
					recordItem.Fields("selvolpct").FontColor = MyColor.SellColor;
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateLastPriceBBOTFEX", ex);
				}
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00140AB0 File Offset: 0x0013EEB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToControl_BBO_Option()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal num = 0m;
				this.tStripCall.Text = "CALL " + this._bboOptionsHeaderText;
				this.tStripPUT.Text = "PUT " + this._bboOptionsHeaderText;
				if (this.tdsSet50Option != null && this.tdsSet50Option.Tables.Contains("BBO_OptionList"))
				{
					int num2 = -1;
					this.intzaOption.Rows = this.tdsSet50Option.Tables["BBO_OptionList"].Rows.Count;
					if (this.tdsSet50Option.Tables.Contains("tbSET50") && this.tdsSet50Option.Tables["tbSET50"].Rows.Count > 0)
					{
						decimal.TryParse(this.tdsSet50Option.Tables["tbSET50"].Rows[0]["nmrLastIndex"].ToString(), out num);
						num = Math.Round(num / 10m) * 10m;
					}
					int num3 = -1;
					foreach (DataRow dataRow in this.tdsSet50Option.Tables["BBO_OptionList"].Rows)
					{
						SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[dataRow["sSeriesOC"].ToString().Trim()];
						SeriesList.SeriesInformation seriesInformation2 = ApplicationInfo.SeriesInfo[dataRow["sSeriesOP"].ToString().Trim()];
						if (seriesInformation != null && seriesInformation2 != null)
						{
							num2++;
							decimal num4;
							decimal.TryParse(dataRow["Strike"].ToString(), out num4);
							this.intzaOption.Records(num2).Changed = true;
							this.intzaOption.Records(num2).Fields("strike").Text = Utilities.PriceFormat(num4);
							this.intzaOption.Records(num2).Fields("strike").BackColor = Color.FromArgb(64, 64, 64);
							this.intzaOption.Records(num2).Fields("strike").FontColor = Color.Cyan;
							this.UpdateBBOTopPrice_Options(num2, "CALL", "B", dataRow["BidVolOC"].ToString(), dataRow["BidPriceOC"].ToString(), seriesInformation);
							this.UpdateBBOTopPrice_Options(num2, "CALL", "S", dataRow["AskVolOC"].ToString(), dataRow["AskPriceOC"].ToString(), seriesInformation);
							this.UpdateBBOTopPrice_Options(num2, "PUT", "B", dataRow["BidVolOP"].ToString(), dataRow["BidPriceOP"].ToString(), seriesInformation2);
							this.UpdateBBOTopPrice_Options(num2, "PUT", "S", dataRow["AskVolOP"].ToString(), dataRow["AskPriceOP"].ToString(), seriesInformation2);
							decimal lastPrice;
							decimal.TryParse(dataRow["PriceOC"].ToString(), out lastPrice);
							decimal chg;
							decimal.TryParse(dataRow["nmrChangOC"].ToString(), out chg);
							this.UpdateLastPriceBBOOption(num2, "CALL", lastPrice, chg, seriesInformation);
							decimal lastPrice2;
							decimal.TryParse(dataRow["PriceOP"].ToString(), out lastPrice2);
							decimal chg2;
							decimal.TryParse(dataRow["nmrChangOP"].ToString(), out chg2);
							this.UpdateLastPriceBBOOption(num2, "PUT", lastPrice2, chg2, seriesInformation2);
							if (num4 == num)
							{
								this.intzaOption.Records(num2).BackColor = Color.FromArgb(64, 64, 64);
								num3 = num2;
							}
						}
					}
					if (num3 > -1)
					{
						int num5 = 5;
						if (num3 - num5 > -1)
						{
							this.intzaOption.CurrentScroll = num3 - num5;
						}
						else
						{
							this.intzaOption.CurrentScroll = 0;
						}
					}
				}
				this.intzaOption.Redraw();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToControl_BBO_Option", ex);
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00140FC8 File Offset: 0x0013F3C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBBOTopPrice_TFEX(int rowIndex, string side, string price, long volume, decimal prior, decimal lastSalePrice, SeriesList.SeriesInformation serieInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaBBO.InvokeRequired)
			{
				this.intzaBBO.Invoke(new frmMarketWatch.UpdateBBOTopPriceTFEXCallBack(this.UpdateBBOTopPrice_TFEX), new object[]
				{
					rowIndex,
					side,
					price,
					volume,
					prior,
					lastSalePrice,
					serieInfo
				});
			}
			else
			{
				try
				{
					if (rowIndex > -1)
					{
						Color fontColor = MyColor.UnChgColor;
						if (side == "B")
						{
							if (volume != -1L)
							{
								if (Utilities.GetTopPriceZero(volume, price))
								{
									this.intzaBBO.Records(rowIndex).Fields("bid").Text = "0.00";
								}
								else
								{
									this.intzaBBO.Records(rowIndex).Fields("bid").Text = Utilities.PriceFormat(price, serieInfo.NumOfDec);
								}
								this.intzaBBO.Records(rowIndex).Fields("bidvol").Text = volume;
								if (Utilities.PriceFormat(lastSalePrice, serieInfo.NumOfDec) == Utilities.PriceFormat(price, serieInfo.NumOfDec))
								{
									if (ApplicationInfo.IndexInfoTfex.TXIState == "7" || ApplicationInfo.IndexInfoTfex.TXIState == "9")
									{
										this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Underline;
									}
									else
									{
										this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Underline;
										this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Regular;
									}
								}
								else
								{
									this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Regular;
								}
								fontColor = Utilities.ComparePriceCFColor(price, serieInfo);
								this.intzaBBO.Records(rowIndex).Fields("bid").FontColor = fontColor;
								this.intzaBBO.Records(rowIndex).Fields("bidvol").FontColor = fontColor;
							}
						}
						else if (side == "A")
						{
							if (volume != -1L)
							{
								if (Utilities.GetTopPriceZero(volume, price))
								{
									this.intzaBBO.Records(rowIndex).Fields("offer").Text = "0.00";
								}
								else
								{
									this.intzaBBO.Records(rowIndex).Fields("offer").Text = Utilities.PriceFormat(price, serieInfo.NumOfDec);
								}
								this.intzaBBO.Records(rowIndex).Fields("offvol").Text = volume;
								if (Utilities.PriceFormat(lastSalePrice, serieInfo.NumOfDec) == Utilities.PriceFormat(price, serieInfo.NumOfDec))
								{
									if (ApplicationInfo.IndexInfoTfex.TXIState == "7" || ApplicationInfo.IndexInfoTfex.TXIState == "9")
									{
										this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Underline;
									}
									else
									{
										this.intzaBBO.Records(rowIndex).Fields("bid").FontStyle = FontStyle.Regular;
										this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Underline;
									}
								}
								else
								{
									this.intzaBBO.Records(rowIndex).Fields("offer").FontStyle = FontStyle.Regular;
								}
								fontColor = Utilities.ComparePriceCFColor(price, serieInfo);
								this.intzaBBO.Records(rowIndex).Fields("offer").FontColor = fontColor;
								this.intzaBBO.Records(rowIndex).Fields("offvol").FontColor = fontColor;
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("UpdateTopPriceBBOTFEX", ex);
				}
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00141464 File Offset: 0x0013F864
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string findMyValue(Dictionary<string, string> myDic, string val)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			foreach (string current in myDic.Keys)
			{
				if (myDic[current] == val)
				{
					result = current;
					return result;
				}
			}
			result = string.Empty;
			return result;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x001414FC File Offset: 0x0013F8FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBBOBidsTFEX(STIControl.ExpandTableGrid.RecordItem rec, SeriesList.SeriesInformation sf, string side, string price2, long volume2, string price3, long volume3, string price4, long volume4, string price5, long volume5)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Color fontColor = MyColor.UnChgColor;
				if (side == "B")
				{
					if (volume2 != -1L)
					{
						fontColor = Utilities.ComparePriceCFColor(price2, sf);
						rec.SubRecord[0].Fields("bidvol").Text = volume2;
						rec.SubRecord[0].Fields("bidvol").FontColor = fontColor;
						rec.SubRecord[0].Fields("bid").Text = Utilities.BidOfferPriceFormat(price2, volume2);
						rec.SubRecord[0].Fields("bid").FontColor = fontColor;
					}
					if (volume3 != -1L)
					{
						fontColor = Utilities.ComparePriceCFColor(price3, sf);
						rec.SubRecord[1].Fields("bidvol").Text = volume3;
						rec.SubRecord[1].Fields("bidvol").FontColor = fontColor;
						rec.SubRecord[1].Fields("bid").Text = Utilities.BidOfferPriceFormat(price3, volume3);
						rec.SubRecord[1].Fields("bid").FontColor = fontColor;
					}
					if (rec.Rows == 5)
					{
						if (volume4 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price4, sf);
							rec.SubRecord[2].Fields("bidvol").Text = volume4;
							rec.SubRecord[2].Fields("bidvol").FontColor = fontColor;
							rec.SubRecord[2].Fields("bid").Text = Utilities.BidOfferPriceFormat(price4, volume4);
							rec.SubRecord[2].Fields("bid").FontColor = fontColor;
						}
						if (volume5 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price5, sf);
							rec.SubRecord[3].Fields("bidvol").Text = volume5;
							rec.SubRecord[3].Fields("bidvol").FontColor = fontColor;
							rec.SubRecord[3].Fields("bid").Text = Utilities.BidOfferPriceFormat(price5, volume5);
							rec.SubRecord[3].Fields("bid").FontColor = fontColor;
						}
					}
				}
				else if (side == "A")
				{
					if (volume2 != -1L)
					{
						fontColor = Utilities.ComparePriceCFColor(price2, sf);
						rec.SubRecord[0].Fields("offvol").Text = volume2;
						rec.SubRecord[0].Fields("offvol").FontColor = fontColor;
						rec.SubRecord[0].Fields("offer").Text = Utilities.BidOfferPriceFormat(price2, volume2);
						rec.SubRecord[0].Fields("offer").FontColor = fontColor;
					}
					if (volume3 != -1L)
					{
						fontColor = Utilities.ComparePriceCFColor(price3, sf);
						rec.SubRecord[1].Fields("offvol").Text = volume3;
						rec.SubRecord[1].Fields("offvol").FontColor = fontColor;
						rec.SubRecord[1].Fields("offer").Text = Utilities.BidOfferPriceFormat(price3, volume3);
						rec.SubRecord[1].Fields("offer").FontColor = fontColor;
					}
					if (rec.Rows == 5)
					{
						if (volume4 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price4, sf);
							rec.SubRecord[2].Fields("offvol").Text = volume4;
							rec.SubRecord[2].Fields("offvol").FontColor = fontColor;
							rec.SubRecord[2].Fields("offer").Text = Utilities.BidOfferPriceFormat(price4, volume4);
							rec.SubRecord[2].Fields("offer").FontColor = fontColor;
						}
						if (volume5 != -1L)
						{
							fontColor = Utilities.ComparePriceCFColor(price5, sf);
							rec.SubRecord[3].Fields("offvol").Text = volume5;
							rec.SubRecord[3].Fields("offvol").FontColor = fontColor;
							rec.SubRecord[3].Fields("offer").Text = Utilities.BidOfferPriceFormat(price5, volume5);
							rec.SubRecord[3].Fields("offer").FontColor = fontColor;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateTopPrice", ex);
			}
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00141A84 File Offset: 0x0013FE84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnBBO_SET_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.isBBOLoading = true;
				this._isDWGroup = false;
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnBBO_SET_Click", ex);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00141ADC File Offset: 0x0013FEDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBBOGroup(string group)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = string.Empty;
				this._isSetMainCombo = true;
				this.tscbBBOSelectionMain.Text = group;
				this.tscbBBOSelection.Enabled = false;
				this.tscbBBOSelection.Items.Clear();
				if (group == "Favorites")
				{
					this.tscbBBOSelection.Items.Add("Favorites-1");
					this.tscbBBOSelection.Items.Add("Favorites-2");
					this.tscbBBOSelection.Items.Add("Favorites-3");
					this.tscbBBOSelection.Items.Add("Favorites-4");
					this.tscbBBOSelection.Items.Add("Favorites-5");
					text = this._lastFAV;
				}
				else if (group == "SET")
				{
					this.tscbBBOSelection.Items.Add("Most Active Value");
					this.tscbBBOSelection.Items.Add("Most Active Volume");
					this.tscbBBOSelection.Items.Add("Most Active Gainer");
					this.tscbBBOSelection.Items.Add("Most Active Loser");
					this.tscbBBOSelection.Items.Add("-----------FLAG------------");
					this.tscbBBOSelection.Items.Add("Benefit");
					if (!ApplicationInfo.SupportFreewill)
					{
						this.tscbBBOSelection.Items.Add("Turnover List");
					}
					this.tscbBBOSelection.Items.Add("---------SECTOR---------");
					SortedDictionary<string, IndexStat.IndexItem> sortedDictionary = new SortedDictionary<string, IndexStat.IndexItem>();
					foreach (IndexStat.IndexItem current in ApplicationInfo.IndexStatInfo.Items)
					{
						if (current.Type == "S" && current.IsMainMarket)
						{
							sortedDictionary.Add(current.Symbol, current);
						}
					}
					foreach (KeyValuePair<string, IndexStat.IndexItem> current2 in sortedDictionary)
					{
						this.tscbBBOSelection.Items.Add(current2.Value.Symbol);
					}
					text = this._lastSETsel;
				}
				else if (group == "MAI")
				{
					this.tscbBBOSelection.Items.Add("Most Active Value");
					this.tscbBBOSelection.Items.Add("Most Active Volume");
					this.tscbBBOSelection.Items.Add("Most Active Gainer");
					this.tscbBBOSelection.Items.Add("Most Active Loser");
					this.tscbBBOSelection.Items.Add("---------SECTOR---------");
					SortedDictionary<string, IndexStat.IndexItem> sortedDictionary = new SortedDictionary<string, IndexStat.IndexItem>();
					foreach (IndexStat.IndexItem current in ApplicationInfo.IndexStatInfo.Items)
					{
						if (current.Type == "S" && !current.IsMainMarket)
						{
							sortedDictionary.Add(current.Symbol, current);
						}
					}
					foreach (KeyValuePair<string, IndexStat.IndexItem> current2 in sortedDictionary)
					{
						this.tscbBBOSelection.Items.Add(current2.Value.Symbol);
					}
					text = this._lastMAIsel;
				}
				else if (group == "Warrant")
				{
					this.tscbBBOSelection.Items.Add("Most Active Value");
					this.tscbBBOSelection.Items.Add("Most Active Volume");
					this.tscbBBOSelection.Items.Add("Most Active Gainer");
					this.tscbBBOSelection.Items.Add("Most Active Loser");
					text = this._lastWarrantsel;
				}
				else if (group == "Derivative Warrant")
				{
					this.tscbBBOSelection.Items.Add("Most Active Value");
					this.tscbBBOSelection.Items.Add("Most Active Volume");
					this.tscbBBOSelection.Items.Add("Most Active Gainer");
					this.tscbBBOSelection.Items.Add("Most Active Loser");
					text = this._lastDWsel;
				}
				else if (group == "%CMPR")
				{
					this.tscbBBOSelection.Items.Add("-");
				}
				else if (group == "My Port")
				{
					this.tscbBBOSelection.Items.Add("-");
				}
				else if (group == "Futures")
				{
					this.tscbBBOSelection.Items.Add("Futures - Most Active Value");
					this.tscbBBOSelection.Items.Add("Futures - Most Active Volume");
					this.tscbBBOSelection.Items.Add("Futures - Gainer");
					this.tscbBBOSelection.Items.Add("Futures - Loser");
					this.tscbBBOSelection.Items.Add("-------------------------");
					foreach (string current3 in this._itemsUnderlying)
					{
						this.tscbBBOSelection.Items.Add(current3);
					}
					text = this._lastFuturesSel;
				}
				else
				{
					if (!(group == "Option"))
					{
						this._isSetMainCombo = false;
						return;
					}
					this.tscbBBOSelection.Items.Add("Options - Most Active Value");
					this.tscbBBOSelection.Items.Add("Options - Most Active Volume");
					this.tscbBBOSelection.Items.Add("Options - Gainer");
					this.tscbBBOSelection.Items.Add("Options - Loser");
					this.tscbBBOSelection.Items.Add("-------------------------");
					if (this._set50OptList == null)
					{
						this._set50OptList = Utilities.GetFullOptionsName();
					}
					if (this._set50OptList != null)
					{
						foreach (KeyValuePair<string, string> current4 in this._set50OptList)
						{
							this.tscbBBOSelection.Items.Add(current4.Value);
						}
					}
					text = this._lastOptionsSel;
				}
				this._mainGroupType = group;
				this.tscbBBOSelection.Enabled = true;
				this.tsbtnBBOAddStock.Visible = (group == "Favorites");
				this.tsbtnBBOAddStock.Visible = (group == "Favorites");
				if (text == string.Empty)
				{
					if (this.tscbBBOSelection.Items.Count > 0)
					{
						text = this.tscbBBOSelection.Items[0].ToString();
					}
				}
				this.tscbBBOSelection.Text = text;
				this.SetBBOPage(text);
			}
			catch (Exception ex)
			{
				this.ShowError("SetBBOGroup", ex);
			}
			this._isSetMainCombo = false;
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00142400 File Offset: 0x00140800
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SaveFavFromGrid()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return string.Empty;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0014242C File Offset: 0x0014082C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaOption_TableMouseClick(object sender, STIControl.ExpandTableGrid.TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1 && e.RowIndex <= this.intzaOption.Rows - 1)
				{
					string text = string.Empty;
					if (e.Column.Name == "callbidvol" || e.Column.Name == "callbid" || e.Column.Name == "calloffer" || e.Column.Name == "calloffvol" || e.Column.Name == "calllast" || e.Column.Name == "callchg")
					{
						text = this.intzaOption.Records(e.RowIndex).Fields("sSeriesOC").Text.ToString();
					}
					else if (e.Column.Name == "putbidvol" || e.Column.Name == "putbid" || e.Column.Name == "putoffer" || e.Column.Name == "putoffvol" || e.Column.Name == "putlast" || e.Column.Name == "putchg")
					{
						text = this.intzaOption.Records(e.RowIndex).Fields("sSeriesOP").Text.ToString();
					}
					if (!string.IsNullOrEmpty(text.Trim()))
					{
						this.SetNewStock_Info(text, false);
						if (Settings.Default.SmartOneClick)
						{
							string side = (e.Mouse.Button == MouseButtons.Left) ? "B" : "S";
							string price = "";
							if (e.Column.Name == "callbid" || e.Column.Name == "calloffer" || e.Column.Name == "calllast")
							{
								price = this.intzaOption.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString();
							}
							else if (e.Column.Name == "putbid" || e.Column.Name == "putoffer" || e.Column.Name == "putlast")
							{
								price = this.intzaOption.Records(e.RowIndex).Fields(e.Column.Name).Text.ToString();
							}
							TemplateManager.Instance.MainForm.SendOrderBox.SetSmartOneClick(side, text, price, false);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("TableMouseClick", ex);
			}
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x001427F4 File Offset: 0x00140BF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaBBO_TableHeaderMouseMove(STIControl.ExpandTableGrid.TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e != null && e.Column != null && e.RowIndex == -1)
				{
					if (this._isTT != e.Column.Name)
					{
						this.toolTip1.Hide(this.intzaBBO);
						this._isTT = e.Column.Name;
						if (e.Column.Name == "po")
						{
							this.toolTip1.SetToolTip(this.intzaBBO, "Click Swap to Avg");
						}
						else if (e.Column.Name == "avg")
						{
							this.toolTip1.SetToolTip(this.intzaBBO, "Click Swap to " + this.getPOorPC());
						}
						else if (e.Column.Name == "chg")
						{
							this.toolTip1.SetToolTip(this.intzaBBO, "Click Swap to %Chg");
						}
						else if (e.Column.Name == "pchg")
						{
							this.toolTip1.SetToolTip(this.intzaBBO, "Click Swap to Chg");
						}
						else if (e.Column.Name == "mvol")
						{
							this.toolTip1.SetToolTip(this.intzaBBO, "Click Swap to Value");
						}
						else if (e.Column.Name == "mval")
						{
							this.toolTip1.SetToolTip(this.intzaBBO, "Click Swap to Volume");
						}
						else
						{
							this.toolTip1.SetToolTip(this.intzaBBO, "");
						}
					}
				}
				else
				{
					this._isTT = string.Empty;
					this.toolTip1.Hide(this.intzaBBO);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaBBO_TableMouseMove", ex);
			}
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00142A64 File Offset: 0x00140E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string getPOorPC()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			string marketState = ApplicationInfo.MarketState;
			if (marketState != null)
			{
				if (marketState == "S" || marketState == "P" || marketState == "O" || marketState == "B")
				{
					result = "PO";
					return result;
				}
			}
			result = "PC";
			return result;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00142AF8 File Offset: 0x00140EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SwitchColumns(string showColumns)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaBBO.InvokeRequired)
			{
				this.intzaBBO.Invoke(new frmMarketWatch.SwitchColumnsCallBack(this.SwitchColumns), new object[]
				{
					showColumns
				});
			}
			else
			{
				try
				{
					if (showColumns == "po" || showColumns == "pc" || showColumns == "avg")
					{
						this.isBBOLoading = true;
						List<STIControl.ExpandTableGrid.ColumnItem> list = new List<STIControl.ExpandTableGrid.ColumnItem>();
						foreach (STIControl.ExpandTableGrid.ColumnItem current in this.intzaBBO.Columns)
						{
							list.Add(current);
						}
						STIControl.ExpandTableGrid.ColumnItem column = this.intzaBBO.GetColumn(showColumns);
						STIControl.ExpandTableGrid.ColumnItem columnItem = null;
						STIControl.ExpandTableGrid.ColumnItem columnItem2 = null;
						if (showColumns != null)
						{
							if (!(showColumns == "po"))
							{
								if (!(showColumns == "pc"))
								{
									if (showColumns == "avg")
									{
										columnItem = this.intzaBBO.GetColumn("pc");
										columnItem2 = this.intzaBBO.GetColumn("po");
									}
								}
								else
								{
									columnItem = this.intzaBBO.GetColumn("avg");
									columnItem2 = this.intzaBBO.GetColumn("po");
								}
							}
							else
							{
								columnItem = this.intzaBBO.GetColumn("pc");
								columnItem2 = this.intzaBBO.GetColumn("avg");
							}
						}
						if (!column.Visible)
						{
							column.Visible = true;
							if (columnItem.Visible)
							{
								list.Remove(column);
								int index = list.IndexOf(columnItem);
								list.Insert(index, column);
							}
							else if (columnItem2.Visible)
							{
								list.Remove(column);
								int index = list.IndexOf(columnItem2);
								list.Insert(index, column);
							}
							columnItem.Visible = false;
							columnItem2.Visible = false;
						}
						this.intzaBBO.Columns = list;
						this.intzaBBO.CalcColumnWidth();
						this.intzaBBO.Redraw();
					}
					else if (showColumns == "chg" || showColumns == "pchg" || showColumns == "mvol" || showColumns == "mval")
					{
						this.isBBOLoading = true;
						List<STIControl.ExpandTableGrid.ColumnItem> list = new List<STIControl.ExpandTableGrid.ColumnItem>();
						foreach (STIControl.ExpandTableGrid.ColumnItem current in this.intzaBBO.Columns)
						{
							list.Add(current);
						}
						STIControl.ExpandTableGrid.ColumnItem column = this.intzaBBO.GetColumn(showColumns);
						STIControl.ExpandTableGrid.ColumnItem columnItem = null;
						if (showColumns != null)
						{
							if (!(showColumns == "chg"))
							{
								if (!(showColumns == "pchg"))
								{
									if (!(showColumns == "mvol"))
									{
										if (showColumns == "mval")
										{
											columnItem = this.intzaBBO.GetColumn("mvol");
										}
									}
									else
									{
										columnItem = this.intzaBBO.GetColumn("mval");
									}
								}
								else
								{
									columnItem = this.intzaBBO.GetColumn("chg");
								}
							}
							else
							{
								columnItem = this.intzaBBO.GetColumn("pchg");
							}
						}
						if (!column.Visible)
						{
							column.Visible = true;
							if (columnItem.Visible)
							{
								list.Remove(column);
								int index = list.IndexOf(columnItem);
								list.Insert(index, column);
							}
							columnItem.Visible = false;
						}
						this.intzaBBO.Columns = list;
						this.intzaBBO.CalcColumnWidth();
						this.intzaBBO.Redraw();
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SwitchColumns", ex);
				}
				this.isBBOLoading = false;
			}
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00142FC8 File Offset: 0x001413C8
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
					TemplateManager.Instance.MainForm.SetTemplateLink("Graph", "CHART", this.contextLink.Tag.ToString());
				}
			}
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0014305C File Offset: 0x0014145C
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

		// Token: 0x06001672 RID: 5746 RVA: 0x00143138 File Offset: 0x00141538
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

		// Token: 0x06001673 RID: 5747 RVA: 0x001431CC File Offset: 0x001415CC
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

		// Token: 0x06001674 RID: 5748 RVA: 0x00143250 File Offset: 0x00141650
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

		// Token: 0x06001675 RID: 5749 RVA: 0x001432D4 File Offset: 0x001416D4
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

		// Token: 0x06001676 RID: 5750 RVA: 0x00143358 File Offset: 0x00141758
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

		// Token: 0x06001677 RID: 5751 RVA: 0x001433DC File Offset: 0x001417DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnVolAs_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._chartVisible)
			{
				this._chartVisible = false;
				this.btnCloseChart.Visible = this._chartVisible;
				this.pictureBox1.Visible = this._chartVisible;
				this.tsbtnRefreshChart.Visible = this._chartVisible;
			}
			this._volAsVisible = !this._volAsVisible;
			if (this._volAsVisible)
			{
				this.ReloadVolAs();
				this.panelVolAs.Visible = true;
				this.panelVolAs.BringToFront();
			}
			else
			{
				this.panelVolAs.Hide();
				this.intzaLS.Show();
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x001434A8 File Offset: 0x001418A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadVolAs()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._volAsVisible)
				{
					if (this._bgwVolAs == null)
					{
						this._bgwVolAs = new BackgroundWorker();
						this._bgwVolAs.DoWork += new DoWorkEventHandler(this.bgwVolAs_DoWork);
						this._bgwVolAs.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwVolAs_RunWorkerCompleted);
					}
					if (!this._bgwVolAs.IsBusy)
					{
						this._bgwVolAs.RunWorkerAsync();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ReloadVolAs", ex);
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00143574 File Offset: 0x00141974
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwVolAs_DoWork(object sender, DoWorkEventArgs e)
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
						string text = ApplicationInfo.WebService.SaleByPrice(this._stockInfoSET.Number, 1, 999, 0);
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

		// Token: 0x0600167A RID: 5754 RVA: 0x00143654 File Offset: 0x00141A54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwVolAs_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
							if (this.dsSaleByPrice.Tables.Contains("sale_by_price"))
							{
								this.wcGraphVolume.InitData(this._stockInfoSET.Symbol, (double)this._stockInfoSET.PriorPrice, (double)this._stockInfoSET.LastSalePrice, (double)this._stockInfoSET.Ceiling, (double)this._stockInfoSET.Floor);
								foreach (DataRow dataRow in this.dsSaleByPrice.Tables["sale_by_price"].Rows)
								{
									decimal value;
									decimal.TryParse(dataRow["price"].ToString(), out value);
									int num;
									int.TryParse(dataRow["buy_deals"].ToString(), out num);
									long num2;
									long.TryParse(dataRow["buy_volume"].ToString(), out num2);
									int.TryParse(dataRow["sell_deals"].ToString(), out num);
									long num3;
									long.TryParse(dataRow["sell_volume"].ToString(), out num3);
									long num4;
									long.TryParse(dataRow["other_volume"].ToString(), out num4);
									this.wcGraphVolume.InputData((double)value, num2 + num3 + num4, num2, num3);
								}
								this.wcGraphVolume.EndUpdate();
								this.wcGraphVolume.Sort();
							}
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

		// Token: 0x0600167B RID: 5755 RVA: 0x001438CC File Offset: 0x00141CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnVolAsClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._volAsVisible = false;
			this.intzaLS.Visible = true;
			this.panelVolAs.Hide();
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00143900 File Offset: 0x00141D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbBBOSelectionMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.IsBBOLoading && !this._isSetMainCombo)
				{
					this.tmBBOSelectionMain.Stop();
					this.tmBBOSelectionMain.Start();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tscbBBOSelectionMain_SelectedIndexChanged", ex);
			}
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00143984 File Offset: 0x00141D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmBBOSelectionMain_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tmBBOSelectionMain.Stop();
				if (!this.IsBBOLoading && !this._isSetMainCombo)
				{
					this.SetBBOGroup(this.tscbBBOSelectionMain.Text);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tmBBOSelectionMain_Tick", ex);
			}
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00143A0C File Offset: 0x00141E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaCMPR_TableMouseClick(object sender, STIControl.ExpandTableGrid.TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1 && e.RowIndex < this.intzaCMPR.Rows)
				{
					string text = this.intzaCMPR.Records(e.RowIndex).Fields("stock").Text.ToString();
					if (!string.IsNullOrEmpty(text.Trim()))
					{
						if (e.Mouse.Button == MouseButtons.Left)
						{
							this.SetNewStock_Info(text, false);
						}
						else if (e.Mouse.Button == MouseButtons.Right && e.Column.Name == "stock")
						{
							this.contextLink.Tag = text;
							this.contextLink.Show(this.intzaCMPR, e.Mouse.Location);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("CMPR.TableMouseClick", ex);
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00143B5C File Offset: 0x00141F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbBBOSelectionMain_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.SuppressKeyPress = true;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00143B78 File Offset: 0x00141F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tscbBBOSelection_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.SuppressKeyPress = true;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00143B94 File Offset: 0x00141F94
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

		// Token: 0x04000B64 RID: 2916
		private IContainer components;

		// Token: 0x04000B65 RID: 2917
		private IntzaCustomGrid intzaInfo;

		// Token: 0x04000B66 RID: 2918
		private ToolStrip tStripMenu;

		// Token: 0x04000B67 RID: 2919
		private ToolStripLabel tsStockLable;

		// Token: 0x04000B68 RID: 2920
		private ToolStripComboBox tstbStock;

		// Token: 0x04000B69 RID: 2921
		private ToolStripLabel tsPrice;

		// Token: 0x04000B6A RID: 2922
		private ToolStripLabel tsSectorName;

		// Token: 0x04000B6B RID: 2923
		private ToolStripLabel tsSectorIndex;

		// Token: 0x04000B6C RID: 2924
		private ToolStripLabel tslbCompare;

		// Token: 0x04000B6D RID: 2925
		private Label lbSplashInfo;

		// Token: 0x04000B6E RID: 2926
		private ToolStripButton tsbtnSwitchChart;

		// Token: 0x04000B6F RID: 2927
		private TextBox tbStockBBO;

		// Token: 0x04000B70 RID: 2928
		private Label lbBBOLoading;

		// Token: 0x04000B71 RID: 2929
		private Panel panelBidOffer;

		// Token: 0x04000B72 RID: 2930
		private ExpandGrid intzaBBO;

		// Token: 0x04000B73 RID: 2931
		private SortGrid intzaVolumeByBoard;

		// Token: 0x04000B74 RID: 2932
		private ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000B75 RID: 2933
		private ToolStripMenuItem tsmiShow3BO;

		// Token: 0x04000B76 RID: 2934
		private ToolStripMenuItem tsmiShowBestBO;

		// Token: 0x04000B77 RID: 2935
		private ToolStripMenuItem tsmiShow5BO;

		// Token: 0x04000B78 RID: 2936
		private PictureBox pictureBox1;

		// Token: 0x04000B79 RID: 2937
		private ToolStripButton tsbtnRefreshChart;

		// Token: 0x04000B7A RID: 2938
		private Label lbChartLoading;

		// Token: 0x04000B7B RID: 2939
		private IntzaCustomGrid intzaBF;

		// Token: 0x04000B7C RID: 2940
		private ContextMenuStrip contextLink;

		// Token: 0x04000B7D RID: 2941
		private ToolStripMenuItem tsmCallHistoricalChart;

		// Token: 0x04000B7E RID: 2942
		private ToolStripMenuItem tsmCallStockInPlay;

		// Token: 0x04000B7F RID: 2943
		private ToolStripMenuItem tsmCallSaleByPrice;

		// Token: 0x04000B80 RID: 2944
		private ToolStripMenuItem tsmCallSaleByTime;

		// Token: 0x04000B81 RID: 2945
		private ToolStripMenuItem tsmCallOddlot;

		// Token: 0x04000B82 RID: 2946
		private SortGrid intzaLS;

		// Token: 0x04000B83 RID: 2947
		private SortGrid intzaTP;

		// Token: 0x04000B84 RID: 2948
		private ToolStrip tStripBBO;

		// Token: 0x04000B85 RID: 2949
		private ToolStripLabel tslbSelection;

		// Token: 0x04000B86 RID: 2950
		private ToolStripComboBox tscbBBOSelection;

		// Token: 0x04000B87 RID: 2951
		private ToolStripButton tsbtnBBOAddStock;

		// Token: 0x04000B88 RID: 2952
		private ToolStripButton tsbtnBBODelStock;

		// Token: 0x04000B89 RID: 2953
		private ToolStripButton tsbtnColumnSetup;

		// Token: 0x04000B8A RID: 2954
		private ToolStripMenuItem tsmCallNews;

		// Token: 0x04000B8B RID: 2955
		private ToolStripButton tsbtnSETNews;

		// Token: 0x04000B8C RID: 2956
		private Button btnCloseChart;

		// Token: 0x04000B8D RID: 2957
		private ToolStripButton tsbtnHChart;

		// Token: 0x04000B8E RID: 2958
		private IntzaCustomGrid intzaInfoTFEX;

		// Token: 0x04000B8F RID: 2959
		private ToolStripLabel tslbTfexHigh;

		// Token: 0x04000B90 RID: 2960
		private ToolStripLabel tstbTfexHigh;

		// Token: 0x04000B91 RID: 2961
		private ToolStripLabel tslbTfexLow;

		// Token: 0x04000B92 RID: 2962
		private ToolStripLabel tstbTfexLow;

		// Token: 0x04000B93 RID: 2963
		private ToolStripLabel tslbTfexAvg;

		// Token: 0x04000B94 RID: 2964
		private ToolStripLabel tstbTfexAvg;

		// Token: 0x04000B95 RID: 2965
		private ExpandGrid intzaOption;

		// Token: 0x04000B96 RID: 2966
		private ToolStrip tStripCP;

		// Token: 0x04000B97 RID: 2967
		private ToolStripLabel tStripCall;

		// Token: 0x04000B98 RID: 2968
		private ToolStripLabel tStripPUT;

		// Token: 0x04000B99 RID: 2969
		private ToolTip toolTip1;

		// Token: 0x04000B9A RID: 2970
		private ToolStripSeparator toolStripMenuItem1;

		// Token: 0x04000B9B RID: 2971
		private ToolStripButton tsbtnVolAs;

		// Token: 0x04000B9C RID: 2972
		private ucVolumeAtPrice wcGraphVolume;

		// Token: 0x04000B9D RID: 2973
		private Panel panelVolAs;

		// Token: 0x04000B9E RID: 2974
		private Button btnVolAsClose;

		// Token: 0x04000B9F RID: 2975
		private ToolStripComboBox tscbBBOSelectionMain;

		// Token: 0x04000BA0 RID: 2976
		private ExpandGrid intzaCMPR;

		// Token: 0x04000BA1 RID: 2977
		private ToolStripMenuItem tsmCallFinance;

		// Token: 0x04000BA2 RID: 2978
		private BackgroundWorker bgwReloadData;

		// Token: 0x04000BA3 RID: 2979
		private BackgroundWorker bgwReloadDataBBO;

		// Token: 0x04000BA4 RID: 2980
		private BackgroundWorker bgwReloadChart;

		// Token: 0x04000BA5 RID: 2981
		private BackgroundWorker bgwReloadBBOExp;

		// Token: 0x04000BA6 RID: 2982
		private bool _currentIsSET;

		// Token: 0x04000BA7 RID: 2983
		private StockList.StockInformation _stockInfoSET;

		// Token: 0x04000BA8 RID: 2984
		private SeriesList.SeriesInformation _seriesInfoTFEX;

		// Token: 0x04000BA9 RID: 2985
		private DataSet tdsMainInfo;

		// Token: 0x04000BAA RID: 2986
		private DataSet tdsSector;

		// Token: 0x04000BAB RID: 2987
		private DataSet tdsInstrument;

		// Token: 0x04000BAC RID: 2988
		private DataSet tdsSet50Option;

		// Token: 0x04000BAD RID: 2989
		private DataSet tdsTopActive;

		// Token: 0x04000BAE RID: 2990
		private DataSet tdsCmpr;

		// Token: 0x04000BAF RID: 2991
		private DataSet tdsMyPort;

		// Token: 0x04000BB0 RID: 2992
		private DataSet tdsBBOFavSET;

		// Token: 0x04000BB1 RID: 2993
		private DataSet tdsBBOFavTFEX;

		// Token: 0x04000BB2 RID: 2994
		private string _currentStock;

		// Token: 0x04000BB3 RID: 2995
		private List<string> _itemsUnderlying;

		// Token: 0x04000BB4 RID: 2996
		private bool isInfoLoading;

		// Token: 0x04000BB5 RID: 2997
		private bool isBBOLoading;

		// Token: 0x04000BB6 RID: 2998
		private int _bboPage;

		// Token: 0x04000BB7 RID: 2999
		private string _mainGroupType;

		// Token: 0x04000BB8 RID: 3000
		private string _subGroupType;

		// Token: 0x04000BB9 RID: 3001
		private string _currentBBOpage;

		// Token: 0x04000BBA RID: 3002
		private Dictionary<string, string> _set50OptList;

		// Token: 0x04000BBB RID: 3003
		private string _lastFAV;

		// Token: 0x04000BBC RID: 3004
		private string _lastSETsel;

		// Token: 0x04000BBD RID: 3005
		private string _lastMAIsel;

		// Token: 0x04000BBE RID: 3006
		private string _lastDWsel;

		// Token: 0x04000BBF RID: 3007
		private string _lastWarrantsel;

		// Token: 0x04000BC0 RID: 3008
		private string _lastFuturesSel;

		// Token: 0x04000BC1 RID: 3009
		private string _lastOptionsSel;

		// Token: 0x04000BC2 RID: 3010
		private string _bboOptionsHeaderText;

		// Token: 0x04000BC3 RID: 3011
		private string _bboQuerySymbol;

		// Token: 0x04000BC4 RID: 3012
		private string _bboQuerySymbolTFEX;

		// Token: 0x04000BC5 RID: 3013
		private string _bboQuerySymbolSector;

		// Token: 0x04000BC6 RID: 3014
		private Timer tmBBOSelectionChanged;

		// Token: 0x04000BC7 RID: 3015
		private Timer tmBBOSelectionMain;

		// Token: 0x04000BC8 RID: 3016
		private string _colsEdit;

		// Token: 0x04000BC9 RID: 3017
		private string _sectorSymbol;

		// Token: 0x04000BCA RID: 3018
		private bool _expCurrentIsSET;

		// Token: 0x04000BCB RID: 3019
		private DataSet tdsBBOExp;

		// Token: 0x04000BCC RID: 3020
		private int _expStockNo;

		// Token: 0x04000BCD RID: 3021
		private int _expRowId;

		// Token: 0x04000BCE RID: 3022
		private int _expRows;

		// Token: 0x04000BCF RID: 3023
		private string _expSeries;

		// Token: 0x04000BD0 RID: 3024
		private bool _isDWGroup;

		// Token: 0x04000BD1 RID: 3025
		private string _currentParentStock;

		// Token: 0x04000BD2 RID: 3026
		private bool _chartVisible;

		// Token: 0x04000BD3 RID: 3027
		private frmColumnEditor _frmColEdit;

		// Token: 0x04000BD4 RID: 3028
		private bool _bboFocused;

		// Token: 0x04000BD5 RID: 3029
		private bool _isSetMainCombo;

		// Token: 0x04000BD6 RID: 3030
		private string _isTT;

		// Token: 0x04000BD7 RID: 3031
		private BackgroundWorker _bgwVolAs;

		// Token: 0x04000BD8 RID: 3032
		private bool _volAsVisible;

		// Token: 0x04000BD9 RID: 3033
		private DataSet dsSaleByPrice;

		// Token: 0x02000247 RID: 583
		// (Invoke) Token: 0x06001683 RID: 5763
		private delegate void ShowSplashInfoCallBack(bool visible);

		// Token: 0x02000248 RID: 584
		// (Invoke) Token: 0x06001687 RID: 5767
		private delegate void ShowSplashBBOCallBack(bool visible);

		// Token: 0x02000249 RID: 585
		// (Invoke) Token: 0x0600168B RID: 5771
		private delegate void UpdateFromSSCallBack(StockList.StockInformation realtimeStockInfo);

		// Token: 0x0200024A RID: 586
		// (Invoke) Token: 0x0600168F RID: 5775
		private delegate void DrawTPBlinkColorCallBack(LSAccumulate msgLS);

		// Token: 0x0200024B RID: 587
		// (Invoke) Token: 0x06001693 RID: 5779
		private delegate void UpdateOpenOrProjectOpenPriceCallBack(string state, int session, decimal price);

		// Token: 0x0200024C RID: 588
		// (Invoke) Token: 0x06001697 RID: 5783
		private delegate void UpdateProjectedVolumeCallBack(long volume);

		// Token: 0x0200024D RID: 589
		// (Invoke) Token: 0x0600169B RID: 5787
		private delegate void UpdateProjectedClosePriceCallBack(decimal closePrice);

		// Token: 0x0200024E RID: 590
		// (Invoke) Token: 0x0600169F RID: 5791
		private delegate void UpdateAllVolumeCallBack(int deals, long accVolume, decimal accValue, long openVolume, long buyVolume, long sellVolume);

		// Token: 0x0200024F RID: 591
		// (Invoke) Token: 0x060016A3 RID: 5795
		private delegate void UpdateSectorCallBack(decimal price, decimal chg, decimal pchg);

		// Token: 0x02000250 RID: 592
		// (Invoke) Token: 0x060016A7 RID: 5799
		private delegate void UpdateLastPriceCallBack(decimal lastPrice, string comparePrice);

		// Token: 0x02000251 RID: 593
		// (Invoke) Token: 0x060016AB RID: 5803
		private delegate void UpdatePriceInfoCallBack(decimal lastPrice, decimal high, decimal low);

		// Token: 0x02000252 RID: 594
		// (Invoke) Token: 0x060016AF RID: 5807
		private delegate void UpdateLastSaleTickerInfoCallBack(decimal price, string side, long volume, string lastUpdate, int index);

		// Token: 0x02000253 RID: 595
		// (Invoke) Token: 0x060016B3 RID: 5811
		private delegate void UpdateMainBoardValueCallBack(int deals, long accVolume, decimal accValue);

		// Token: 0x02000254 RID: 596
		// (Invoke) Token: 0x060016B7 RID: 5815
		private delegate void UpdateBigLotValueCallBack(int bDeal, decimal bValue, long bVolume);

		// Token: 0x02000255 RID: 597
		// (Invoke) Token: 0x060016BB RID: 5819
		private delegate void SetNewStockInfoCallBack(string stockSymbol, bool isFocus);

		// Token: 0x02000256 RID: 598
		// (Invoke) Token: 0x060016BF RID: 5823
		private delegate void UpdateBBOTopPriceCallBack(int rowIndex, string side, decimal price, long volume, decimal prior, decimal lastSalePrice, StockList.StockInformation sf);

		// Token: 0x02000257 RID: 599
		// (Invoke) Token: 0x060016C3 RID: 5827
		private delegate void UpdateBBO_LS_CallBack(int rowIndex, decimal lastPrice, long accVolume, decimal accValue, int deals, string comparePrice, decimal highPrice, decimal lowPrice, long buyVol, long sellVol, StockList.StockInformation sf);

		// Token: 0x02000258 RID: 600
		// (Invoke) Token: 0x060016C7 RID: 5831
		public delegate void ShowDisplayFlagBBOCallBack(int rowIndex, string displayFlag);

		// Token: 0x02000259 RID: 601
		// (Invoke) Token: 0x060016CB RID: 5835
		private delegate void ClearStockBBOCallBack(int lineNo);

		// Token: 0x0200025A RID: 602
		// (Invoke) Token: 0x060016CF RID: 5839
		public delegate void ShowTextBoxPositionCallBack(KeyEventArgs e);

		// Token: 0x0200025B RID: 603
		// (Invoke) Token: 0x060016D3 RID: 5843
		private delegate void SetBBOPageCallBack(string page);

		// Token: 0x0200025C RID: 604
		// (Invoke) Token: 0x060016D7 RID: 5847
		private delegate void ShowSplashChartCallBack(bool visible);

		// Token: 0x0200025D RID: 605
		// (Invoke) Token: 0x060016DB RID: 5851
		private delegate void setTopPriceColumeCallBack(bool isEquity);

		// Token: 0x0200025E RID: 606
		// (Invoke) Token: 0x060016DF RID: 5855
		private delegate void setBBOColumeCallBack(bool isEquity);

		// Token: 0x0200025F RID: 607
		// (Invoke) Token: 0x060016E3 RID: 5859
		private delegate void UpdateHeaderPriceCallBack(decimal highPrice, decimal lowPrice);

		// Token: 0x02000260 RID: 608
		// (Invoke) Token: 0x060016E7 RID: 5863
		private delegate void UpdateTickerTFEXInfoCallBack(decimal price, string side, long volume, string lastUpdate, int index);

		// Token: 0x02000261 RID: 609
		// (Invoke) Token: 0x060016EB RID: 5867
		private delegate void UpdateTfexAvgCallBack(decimal avg);

		// Token: 0x02000262 RID: 610
		// (Invoke) Token: 0x060016EF RID: 5871
		public delegate void UpdateBBOTopPriceOptionsCallBack(int rowIndex, string type, string side, string volume, string price, SeriesList.SeriesInformation seriesInfoForOptionCrtl);

		// Token: 0x02000263 RID: 611
		// (Invoke) Token: 0x060016F3 RID: 5875
		public delegate void UpdateLastPriceBBOOptionsCallBack(int rowIndex, string type, decimal lastPrice, decimal chg, SeriesList.SeriesInformation stockInfo);

		// Token: 0x02000264 RID: 612
		// (Invoke) Token: 0x060016F7 RID: 5879
		public delegate void UpdateLastPriceBBO_TFEXCallBack(int rowIndex, decimal lastPrice, decimal prior, long accVolume, decimal accValue, long deals, string comparePrice, SeriesList.SeriesInformation serieInfo, decimal highPrice, decimal lowPrice, long buyVol, long sellVol);

		// Token: 0x02000265 RID: 613
		// (Invoke) Token: 0x060016FB RID: 5883
		public delegate void UpdateBBOTopPriceTFEXCallBack(int rowIndex, string side, string price, long volume, decimal prior, decimal lastSalePrice, SeriesList.SeriesInformation serieInfo);

		// Token: 0x02000266 RID: 614
		// (Invoke) Token: 0x060016FF RID: 5887
		private delegate void SwitchColumnsCallBack(string currColumns);
	}
}
