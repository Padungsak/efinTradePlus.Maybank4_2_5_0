using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.AutoTradeMessage;
using STIControl;
using STIControl.ExpandTableGrid;

namespace i2TradePlus
{
	// Token: 0x02000222 RID: 546
	public class frmAutoTrade : ClientBaseForm, IRealtimeMessage
	{
		// Token: 0x06001382 RID: 4994 RVA: 0x000FBF60 File Offset: 0x000FA360
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

		// Token: 0x06001383 RID: 4995 RVA: 0x000FBFB0 File Offset: 0x000FA3B0
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
			ColumnItem columnItem15 = new ColumnItem();
			ColumnItem columnItem16 = new ColumnItem();
			ColumnItem columnItem17 = new ColumnItem();
			ColumnItem columnItem18 = new ColumnItem();
			ColumnItem columnItem19 = new ColumnItem();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmAutoTrade));
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
			ColumnItem columnItem33 = new ColumnItem();
			ColumnItem columnItem34 = new ColumnItem();
			ColumnItem columnItem35 = new ColumnItem();
			this.btnClear = new Button();
			this.btnSendOrder = new Button();
			this.tbPin = new TextBox();
			this.lbPin = new Label();
			this.cb1Price = new ComboBox();
			this.cbStock = new ComboBox();
			this.lbStock = new Label();
			this.lbPrice = new Label();
			this.lb1Volume = new Label();
			this.tb1Volume = new TextBox();
			this.panelTop = new Panel();
			this.btnShort = new Button();
			this.btnCover = new Button();
			this.rdbTfexClosePosition = new RadioButton();
			this.rdbTfexOpenPosition = new RadioButton();
			this.btnType4 = new Button();
			this.btnType3 = new Button();
			this.lbExpire = new Label();
			this.cbExpire = new ComboBox();
			this.panelPZ = new Panel();
			this.gridPzMain = new ExpandGrid();
			this.btnPzCreateNew = new Button();
			this.btnPzCancel = new Button();
			this.btnPzReload = new Button();
			this.panelDCA = new Panel();
			this.gridDcaMain = new ExpandGrid();
			this.btnDcaCreate = new Button();
			this.btn3Cancel = new Button();
			this.btnDcaReload = new Button();
			this.panType2 = new Panel();
			this.panel2OrderVal = new GroupBox();
			this.lb2PriceTakeProfit = new Label();
			this.tb2Volume = new TextBox();
			this.lb2PriceCutLoss = new Label();
			this.lb2Volume = new Label();
			this.chbGroupCancel = new CheckBox();
			this.cb2PriceTakeProfit = new ComboBox();
			this.cb2PriceTrailingStop = new ComboBox();
			this.lb2PriceTrailingStop = new Label();
			this.cb2PriceCutLoss = new ComboBox();
			this.lb2SlipPage = new Label();
			this.lbGrpCondLabel = new Label();
			this.lb2ValueCutloss = new Label();
			this.tb2SlipPage = new TextBox();
			this.cb2ValueCutloss = new ComboBox();
			this.lb2ValueTrailingStop = new Label();
			this.cb2ValueTrailingStop = new ComboBox();
			this.cb2OperCutloss = new ComboBox();
			this.cb2OperTrailingStop = new ComboBox();
			this.cb2OperTakeProfit = new ComboBox();
			this.chb2CutLossCond = new CheckBox();
			this.chb2TrailingStopCond = new CheckBox();
			this.chb2TakeProfitCond = new CheckBox();
			this.lb2ValueTakeProfit = new Label();
			this.cb2ValueTakeProfit = new ComboBox();
			this.btnTypePZ = new Button();
			this.panType1 = new Panel();
			this.panel1OrderVal = new GroupBox();
			this.lbTimingStop = new Label();
			this.cbTimingStop = new ComboBox();
			this.lbSlipPage = new Label();
			this.tbSlipPage = new TextBox();
			this.cb1Condition = new ComboBox();
			this.lb1Value = new Label();
			this.cb1Value = new ComboBox();
			this.lbStopOrderField = new Label();
			this.btnTypeDCA = new Button();
			this.btnTypeMM = new Button();
			this.btnSell = new Button();
			this.btnBuy = new Button();
			this.btnType2 = new Button();
			this.btnType1 = new Button();
			this.lbPattern = new Label();
			this.tStripMenu = new ToolStrip();
			this.tslbMode = new ToolStripLabel();
			this.tsbtnMode = new ToolStripComboBox();
			this.tslbStatus = new ToolStripLabel();
			this.tscbStatus = new ToolStripComboBox();
			this.tslbStock = new ToolStripLabel();
			this.tstbStock = new ToolStripTextBox();
			this.tslbSide = new ToolStripLabel();
			this.tscbSide = new ToolStripComboBox();
			this.tsbtnClearCondition = new ToolStripButton();
			this.tsbtnCancelOrder = new ToolStripButton();
			this.tsbtnSearch = new ToolStripButton();
			this.panel1 = new Panel();
			this.intzaOrder = new ExpandGrid();
			this.toolTip1 = new ToolTip(this.components);
			this.panelTop.SuspendLayout();
			this.panelPZ.SuspendLayout();
			this.panelDCA.SuspendLayout();
			this.panType2.SuspendLayout();
			this.panel2OrderVal.SuspendLayout();
			this.panType1.SuspendLayout();
			this.panel1OrderVal.SuspendLayout();
			this.tStripMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.btnClear.AutoEllipsis = true;
			this.btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnClear.BackColor = Color.Transparent;
			this.btnClear.Cursor = Cursors.Hand;
			this.btnClear.FlatAppearance.BorderColor = Color.DimGray;
			this.btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnClear.FlatStyle = FlatStyle.Flat;
			this.btnClear.ForeColor = Color.WhiteSmoke;
			this.btnClear.Location = new Point(620, 394);
			this.btnClear.MaximumSize = new Size(58, 23);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new Size(54, 22);
			this.btnClear.TabIndex = 103;
			this.btnClear.TabStop = false;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new EventHandler(this.btnClear_Click);
			this.btnSendOrder.AutoEllipsis = true;
			this.btnSendOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnSendOrder.BackColor = Color.Transparent;
			this.btnSendOrder.Cursor = Cursors.Hand;
			this.btnSendOrder.FlatAppearance.BorderColor = Color.DimGray;
			this.btnSendOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSendOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnSendOrder.FlatStyle = FlatStyle.Flat;
			this.btnSendOrder.ForeColor = Color.WhiteSmoke;
			this.btnSendOrder.Location = new Point(560, 394);
			this.btnSendOrder.MaximumSize = new Size(58, 23);
			this.btnSendOrder.Name = "btnSendOrder";
			this.btnSendOrder.Size = new Size(54, 22);
			this.btnSendOrder.TabIndex = 102;
			this.btnSendOrder.TabStop = false;
			this.btnSendOrder.Text = "Send";
			this.btnSendOrder.UseVisualStyleBackColor = false;
			this.btnSendOrder.Click += new EventHandler(this.btnSendOrder_Click);
			this.tbPin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbPin.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbPin.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPin.BorderStyle = BorderStyle.FixedSingle;
			this.tbPin.CharacterCasing = CharacterCasing.Upper;
			this.tbPin.Location = new Point(500, 395);
			this.tbPin.Margin = new Padding(2, 3, 2, 3);
			this.tbPin.MaxLength = 10;
			this.tbPin.Name = "tbPin";
			this.tbPin.PasswordChar = '*';
			this.tbPin.Size = new Size(55, 20);
			this.tbPin.TabIndex = 7;
			this.tbPin.KeyDown += new KeyEventHandler(this.tbPin_KeyDown);
			this.tbPin.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbPin.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbPin.AutoSize = true;
			this.lbPin.ForeColor = Color.LightGray;
			this.lbPin.Location = new Point(473, 399);
			this.lbPin.Margin = new Padding(2, 0, 2, 0);
			this.lbPin.Name = "lbPin";
			this.lbPin.Size = new Size(25, 13);
			this.lbPin.TabIndex = 90;
			this.lbPin.Text = "PIN";
			this.lbPin.TextAlign = ContentAlignment.MiddleLeft;
			this.cb1Price.AllowDrop = true;
			this.cb1Price.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"ATO",
				"ATC",
				"MP",
				"MO",
				"ML"
			});
			this.cb1Price.AutoCompleteMode = AutoCompleteMode.Append;
			this.cb1Price.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb1Price.BackColor = Color.FromArgb(224, 224, 224);
			this.cb1Price.FlatStyle = FlatStyle.Popup;
			this.cb1Price.ForeColor = Color.Black;
			this.cb1Price.FormattingEnabled = true;
			this.cb1Price.Location = new Point(43, 19);
			this.cb1Price.Name = "cb1Price";
			this.cb1Price.Size = new Size(55, 21);
			this.cb1Price.TabIndex = 118;
			this.cb1Price.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb1Price.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb1Price.KeyPress += new KeyPressEventHandler(this.cbPrice_KeyPress);
			this.cb1Price.KeyDown += new KeyEventHandler(this.cb1Price_KeyDown);
			this.cbStock.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cbStock.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbStock.BackColor = Color.FromArgb(224, 224, 224);
			this.cbStock.FlatStyle = FlatStyle.Popup;
			this.cbStock.ForeColor = Color.Black;
			this.cbStock.FormattingEnabled = true;
			this.cbStock.Location = new Point(251, 6);
			this.cbStock.MaxLength = 20;
			this.cbStock.Name = "cbStock";
			this.cbStock.Size = new Size(100, 21);
			this.cbStock.TabIndex = 0;
			this.cbStock.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbStock.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbStock.KeyPress += new KeyPressEventHandler(this.cbPrice_KeyPress);
			this.cbStock.KeyDown += new KeyEventHandler(this.cbStock_KeyDown);
			this.lbStock.AutoSize = true;
			this.lbStock.ForeColor = Color.LightGray;
			this.lbStock.Location = new Point(205, 10);
			this.lbStock.Margin = new Padding(2, 0, 2, 0);
			this.lbStock.Name = "lbStock";
			this.lbStock.Size = new Size(41, 13);
			this.lbStock.TabIndex = 100;
			this.lbStock.Text = "Symbol";
			this.lbStock.TextAlign = ContentAlignment.MiddleLeft;
			this.lbPrice.AutoSize = true;
			this.lbPrice.Location = new Point(8, 23);
			this.lbPrice.Margin = new Padding(2, 0, 2, 0);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new Size(31, 13);
			this.lbPrice.TabIndex = 13;
			this.lbPrice.Text = "Price";
			this.lbPrice.TextAlign = ContentAlignment.MiddleLeft;
			this.lb1Volume.AutoSize = true;
			this.lb1Volume.Location = new Point(106, 23);
			this.lb1Volume.Margin = new Padding(2, 0, 2, 0);
			this.lb1Volume.Name = "lb1Volume";
			this.lb1Volume.Size = new Size(42, 13);
			this.lb1Volume.TabIndex = 11;
			this.lb1Volume.Text = "Volume";
			this.lb1Volume.TextAlign = ContentAlignment.MiddleLeft;
			this.tb1Volume.BackColor = Color.FromArgb(224, 224, 224);
			this.tb1Volume.BorderStyle = BorderStyle.FixedSingle;
			this.tb1Volume.Location = new Point(151, 19);
			this.tb1Volume.Margin = new Padding(2, 3, 2, 3);
			this.tb1Volume.MaxLength = 10;
			this.tb1Volume.Name = "tb1Volume";
			this.tb1Volume.Size = new Size(59, 20);
			this.tb1Volume.TabIndex = 119;
			this.tb1Volume.TextChanged += new EventHandler(this.tb1Volume_TextChanged);
			this.tb1Volume.KeyDown += new KeyEventHandler(this.tb1Volume_KeyDown);
			this.tb1Volume.Leave += new EventHandler(this.controlOrder_Leave);
			this.tb1Volume.Enter += new EventHandler(this.controlOrder_Enter);
			this.panelTop.BackColor = Color.FromArgb(20, 20, 20);
			this.panelTop.Controls.Add(this.btnShort);
			this.panelTop.Controls.Add(this.btnCover);
			this.panelTop.Controls.Add(this.rdbTfexClosePosition);
			this.panelTop.Controls.Add(this.rdbTfexOpenPosition);
			this.panelTop.Controls.Add(this.btnType4);
			this.panelTop.Controls.Add(this.btnType3);
			this.panelTop.Controls.Add(this.lbExpire);
			this.panelTop.Controls.Add(this.cbExpire);
			this.panelTop.Controls.Add(this.panelPZ);
			this.panelTop.Controls.Add(this.panelDCA);
			this.panelTop.Controls.Add(this.panType2);
			this.panelTop.Controls.Add(this.btnTypePZ);
			this.panelTop.Controls.Add(this.panType1);
			this.panelTop.Controls.Add(this.btnTypeDCA);
			this.panelTop.Controls.Add(this.btnTypeMM);
			this.panelTop.Controls.Add(this.btnClear);
			this.panelTop.Controls.Add(this.lbStock);
			this.panelTop.Controls.Add(this.btnSendOrder);
			this.panelTop.Controls.Add(this.cbStock);
			this.panelTop.Controls.Add(this.tbPin);
			this.panelTop.Controls.Add(this.lbPin);
			this.panelTop.Controls.Add(this.btnSell);
			this.panelTop.Controls.Add(this.btnBuy);
			this.panelTop.Controls.Add(this.btnType2);
			this.panelTop.Controls.Add(this.btnType1);
			this.panelTop.Controls.Add(this.lbPattern);
			this.panelTop.Dock = DockStyle.Top;
			this.panelTop.Location = new Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Padding = new Padding(2);
			this.panelTop.Size = new Size(752, 424);
			this.panelTop.TabIndex = 113;
			this.btnShort.AutoEllipsis = true;
			this.btnShort.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnShort.BackColor = Color.Transparent;
			this.btnShort.Cursor = Cursors.Hand;
			this.btnShort.FlatAppearance.BorderColor = Color.DimGray;
			this.btnShort.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnShort.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnShort.FlatStyle = FlatStyle.Flat;
			this.btnShort.ForeColor = Color.WhiteSmoke;
			this.btnShort.Image = Resources.side_noside;
			this.btnShort.Location = new Point(154, 5);
			this.btnShort.MaximumSize = new Size(58, 23);
			this.btnShort.Name = "btnShort";
			this.btnShort.Size = new Size(45, 22);
			this.btnShort.TabIndex = 133;
			this.btnShort.TabStop = false;
			this.btnShort.Text = "Short";
			this.btnShort.UseVisualStyleBackColor = false;
			this.btnShort.Visible = false;
			this.btnShort.Click += new EventHandler(this.btnShort_Click);
			this.btnCover.AutoEllipsis = true;
			this.btnCover.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnCover.BackColor = Color.Transparent;
			this.btnCover.Cursor = Cursors.Hand;
			this.btnCover.FlatAppearance.BorderColor = Color.DimGray;
			this.btnCover.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnCover.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnCover.FlatStyle = FlatStyle.Flat;
			this.btnCover.ForeColor = Color.WhiteSmoke;
			this.btnCover.Image = Resources.side_noside;
			this.btnCover.Location = new Point(105, 5);
			this.btnCover.MaximumSize = new Size(58, 23);
			this.btnCover.Name = "btnCover";
			this.btnCover.Size = new Size(45, 22);
			this.btnCover.TabIndex = 132;
			this.btnCover.TabStop = false;
			this.btnCover.Text = "Cover";
			this.btnCover.UseVisualStyleBackColor = false;
			this.btnCover.Visible = false;
			this.btnCover.Click += new EventHandler(this.btnCover_Click);
			this.rdbTfexClosePosition.AutoSize = true;
			this.rdbTfexClosePosition.ForeColor = Color.LightGray;
			this.rdbTfexClosePosition.Location = new Point(415, 9);
			this.rdbTfexClosePosition.Name = "rdbTfexClosePosition";
			this.rdbTfexClosePosition.Size = new Size(51, 17);
			this.rdbTfexClosePosition.TabIndex = 131;
			this.rdbTfexClosePosition.TabStop = true;
			this.rdbTfexClosePosition.Text = "Close";
			this.rdbTfexClosePosition.UseVisualStyleBackColor = true;
			this.rdbTfexOpenPosition.AutoSize = true;
			this.rdbTfexOpenPosition.ForeColor = Color.LightGray;
			this.rdbTfexOpenPosition.Location = new Point(358, 9);
			this.rdbTfexOpenPosition.Name = "rdbTfexOpenPosition";
			this.rdbTfexOpenPosition.Size = new Size(51, 17);
			this.rdbTfexOpenPosition.TabIndex = 130;
			this.rdbTfexOpenPosition.TabStop = true;
			this.rdbTfexOpenPosition.Text = "Open";
			this.rdbTfexOpenPosition.UseVisualStyleBackColor = true;
			this.btnType4.AutoEllipsis = true;
			this.btnType4.Cursor = Cursors.Hand;
			this.btnType4.FlatAppearance.BorderColor = Color.DimGray;
			this.btnType4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnType4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnType4.FlatStyle = FlatStyle.Flat;
			this.btnType4.ForeColor = Color.WhiteSmoke;
			this.btnType4.Location = new Point(600, 6);
			this.btnType4.MaximumSize = new Size(58, 23);
			this.btnType4.Name = "btnType4";
			this.btnType4.Size = new Size(22, 22);
			this.btnType4.TabIndex = 129;
			this.btnType4.TabStop = false;
			this.btnType4.Text = "4";
			this.toolTip1.SetToolTip(this.btnType4, "SET Filter");
			this.btnType4.UseVisualStyleBackColor = false;
			this.btnType4.Click += new EventHandler(this.btnType4_Click);
			this.btnType3.AutoEllipsis = true;
			this.btnType3.Cursor = Cursors.Hand;
			this.btnType3.FlatAppearance.BorderColor = Color.DimGray;
			this.btnType3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnType3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnType3.FlatStyle = FlatStyle.Flat;
			this.btnType3.ForeColor = Color.WhiteSmoke;
			this.btnType3.Location = new Point(572, 6);
			this.btnType3.MaximumSize = new Size(58, 23);
			this.btnType3.Name = "btnType3";
			this.btnType3.Size = new Size(22, 22);
			this.btnType3.TabIndex = 128;
			this.btnType3.TabStop = false;
			this.btnType3.Text = "3";
			this.toolTip1.SetToolTip(this.btnType3, "Timing Stop");
			this.btnType3.UseVisualStyleBackColor = false;
			this.btnType3.Click += new EventHandler(this.btnType3_Click);
			this.lbExpire.AutoSize = true;
			this.lbExpire.ForeColor = Color.LightGray;
			this.lbExpire.Location = new Point(334, 400);
			this.lbExpire.Margin = new Padding(2, 0, 2, 0);
			this.lbExpire.Name = "lbExpire";
			this.lbExpire.Size = new Size(36, 13);
			this.lbExpire.TabIndex = 127;
			this.lbExpire.Text = "Expire";
			this.lbExpire.TextAlign = ContentAlignment.MiddleLeft;
			this.cbExpire.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbExpire.FlatStyle = FlatStyle.Flat;
			this.cbExpire.ForeColor = Color.FromArgb(192, 0, 0);
			this.cbExpire.FormattingEnabled = true;
			this.cbExpire.Items.AddRange(new object[]
			{
				"End Day",
				"30 Days",
				"60 Days",
				"90 Days",
				"180 Days"
			});
			this.cbExpire.Location = new Point(375, 396);
			this.cbExpire.Margin = new Padding(2);
			this.cbExpire.Name = "cbExpire";
			this.cbExpire.Size = new Size(70, 21);
			this.cbExpire.TabIndex = 126;
			this.panelPZ.BackColor = Color.FromArgb(30, 30, 30);
			this.panelPZ.Controls.Add(this.gridPzMain);
			this.panelPZ.Controls.Add(this.btnPzCreateNew);
			this.panelPZ.Controls.Add(this.btnPzCancel);
			this.panelPZ.Controls.Add(this.btnPzReload);
			this.panelPZ.Location = new Point(7, 193);
			this.panelPZ.Name = "panelPZ";
			this.panelPZ.Size = new Size(733, 105);
			this.panelPZ.TabIndex = 124;
			this.panelPZ.Visible = false;
			this.gridPzMain.AllowDrop = true;
			this.gridPzMain.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.gridPzMain.BackColor = Color.FromArgb(20, 20, 20);
			this.gridPzMain.CanBlink = true;
			this.gridPzMain.CanDrag = false;
			this.gridPzMain.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.FontColor = Color.LightGray;
			columnItem.IsExpand = false;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "refno";
			columnItem.Text = "Ref No.";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 7;
			columnItem2.Alignment = StringAlignment.Near;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.FontColor = Color.LightGray;
			columnItem2.IsExpand = false;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "stock";
			columnItem2.Text = "Symbol";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 14;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.FontColor = Color.LightGray;
			columnItem3.IsExpand = false;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "budget";
			columnItem3.Text = "Budget";
			columnItem3.ValueFormat = FormatType.Volume;
			columnItem3.Visible = true;
			columnItem3.Width = 12;
			columnItem4.Alignment = StringAlignment.Center;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.FontColor = Color.LightGray;
			columnItem4.IsExpand = false;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "start_price";
			columnItem4.Text = "Start Price";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 8;
			columnItem5.Alignment = StringAlignment.Center;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.FontColor = Color.LightGray;
			columnItem5.IsExpand = false;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "no_steps";
			columnItem5.Text = "Segment";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 9;
			columnItem6.Alignment = StringAlignment.Center;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.FontColor = Color.LightGray;
			columnItem6.IsExpand = false;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "depth_pct";
			columnItem6.Text = "%Chg";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 8;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.FontColor = Color.LightGray;
			columnItem7.IsExpand = false;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "matvol";
			columnItem7.Text = "M-Volume";
			columnItem7.ValueFormat = FormatType.Volume;
			columnItem7.Visible = true;
			columnItem7.Width = 11;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.FontColor = Color.LightGray;
			columnItem8.IsExpand = false;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "matval";
			columnItem8.Text = "Cost";
			columnItem8.ValueFormat = FormatType.Volume;
			columnItem8.Visible = true;
			columnItem8.Width = 11;
			columnItem9.Alignment = StringAlignment.Far;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.FontColor = Color.LightGray;
			columnItem9.IsExpand = false;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "avg";
			columnItem9.Text = "Avg";
			columnItem9.ValueFormat = FormatType.Price;
			columnItem9.Visible = true;
			columnItem9.Width = 8;
			columnItem10.Alignment = StringAlignment.Center;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.FontColor = Color.LightGray;
			columnItem10.IsExpand = false;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "status";
			columnItem10.Text = "Status";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = true;
			columnItem10.Width = 11;
			this.gridPzMain.Columns.Add(columnItem);
			this.gridPzMain.Columns.Add(columnItem2);
			this.gridPzMain.Columns.Add(columnItem3);
			this.gridPzMain.Columns.Add(columnItem4);
			this.gridPzMain.Columns.Add(columnItem5);
			this.gridPzMain.Columns.Add(columnItem6);
			this.gridPzMain.Columns.Add(columnItem7);
			this.gridPzMain.Columns.Add(columnItem8);
			this.gridPzMain.Columns.Add(columnItem9);
			this.gridPzMain.Columns.Add(columnItem10);
			this.gridPzMain.CurrentScroll = 0;
			this.gridPzMain.FocusItemIndex = -1;
			this.gridPzMain.ForeColor = Color.Black;
			this.gridPzMain.GridColor = Color.FromArgb(50, 50, 50);
			this.gridPzMain.HeaderPctHeight = 100f;
			this.gridPzMain.IsAutoRepaint = true;
			this.gridPzMain.IsDrawGrid = true;
			this.gridPzMain.IsDrawHeader = true;
			this.gridPzMain.IsScrollable = true;
			this.gridPzMain.Location = new Point(8, 35);
			this.gridPzMain.MainColumn = "";
			this.gridPzMain.Name = "gridPzMain";
			this.gridPzMain.Rows = 0;
			this.gridPzMain.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.gridPzMain.RowSelectType = 3;
			this.gridPzMain.Size = new Size(717, 61);
			this.gridPzMain.SortColumnName = "";
			this.gridPzMain.SortType = SortType.Desc;
			this.gridPzMain.TabIndex = 130;
			this.gridPzMain.TableMouseDoubleClick += new ExpandGrid.TableMouseDoubleClickEventHandler(this.gridPzMain_TableMouseDoubleClick);
			this.btnPzCreateNew.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnPzCreateNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnPzCreateNew.BackColor = Color.Transparent;
			this.btnPzCreateNew.Cursor = Cursors.Hand;
			this.btnPzCreateNew.FlatAppearance.BorderColor = Color.DimGray;
			this.btnPzCreateNew.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPzCreateNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnPzCreateNew.FlatStyle = FlatStyle.Flat;
			this.btnPzCreateNew.ForeColor = Color.WhiteSmoke;
			this.btnPzCreateNew.Image = Resources.blue_tab;
			this.btnPzCreateNew.Location = new Point(607, 7);
			this.btnPzCreateNew.MaximumSize = new Size(58, 23);
			this.btnPzCreateNew.Name = "btnPzCreateNew";
			this.btnPzCreateNew.Size = new Size(54, 22);
			this.btnPzCreateNew.TabIndex = 139;
			this.btnPzCreateNew.TabStop = false;
			this.btnPzCreateNew.Text = "Create";
			this.btnPzCreateNew.UseVisualStyleBackColor = false;
			this.btnPzCreateNew.Click += new EventHandler(this.btnPzCreateNew_Click);
			this.btnPzCancel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnPzCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnPzCancel.BackColor = Color.Transparent;
			this.btnPzCancel.Cursor = Cursors.Hand;
			this.btnPzCancel.FlatAppearance.BorderColor = Color.DimGray;
			this.btnPzCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPzCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnPzCancel.FlatStyle = FlatStyle.Flat;
			this.btnPzCancel.ForeColor = Color.WhiteSmoke;
			this.btnPzCancel.Image = Resources.side_sell;
			this.btnPzCancel.Location = new Point(667, 7);
			this.btnPzCancel.MaximumSize = new Size(58, 23);
			this.btnPzCancel.Name = "btnPzCancel";
			this.btnPzCancel.Size = new Size(54, 22);
			this.btnPzCancel.TabIndex = 132;
			this.btnPzCancel.TabStop = false;
			this.btnPzCancel.Text = "Cancel";
			this.btnPzCancel.UseVisualStyleBackColor = false;
			this.btnPzCancel.Click += new EventHandler(this.btnPzCancel_Click);
			this.btnPzReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnPzReload.BackColor = Color.Transparent;
			this.btnPzReload.Cursor = Cursors.Hand;
			this.btnPzReload.FlatAppearance.BorderColor = Color.DimGray;
			this.btnPzReload.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPzReload.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnPzReload.FlatStyle = FlatStyle.Flat;
			this.btnPzReload.ForeColor = Color.LightGray;
			this.btnPzReload.Image = Resources.side_noside;
			this.btnPzReload.Location = new Point(8, 7);
			this.btnPzReload.MaximumSize = new Size(58, 23);
			this.btnPzReload.Name = "btnPzReload";
			this.btnPzReload.Size = new Size(54, 22);
			this.btnPzReload.TabIndex = 131;
			this.btnPzReload.TabStop = false;
			this.btnPzReload.Text = "Reload";
			this.btnPzReload.UseVisualStyleBackColor = false;
			this.btnPzReload.Click += new EventHandler(this.btnPzReload_Click);
			this.panelDCA.BackColor = Color.FromArgb(30, 30, 30);
			this.panelDCA.Controls.Add(this.gridDcaMain);
			this.panelDCA.Controls.Add(this.btnDcaCreate);
			this.panelDCA.Controls.Add(this.btn3Cancel);
			this.panelDCA.Controls.Add(this.btnDcaReload);
			this.panelDCA.Location = new Point(6, 303);
			this.panelDCA.Name = "panelDCA";
			this.panelDCA.Size = new Size(734, 88);
			this.panelDCA.TabIndex = 122;
			this.panelDCA.Visible = false;
			this.gridDcaMain.AllowDrop = true;
			this.gridDcaMain.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.gridDcaMain.BackColor = Color.FromArgb(20, 20, 20);
			this.gridDcaMain.CanBlink = true;
			this.gridDcaMain.CanDrag = false;
			this.gridDcaMain.CanGetMouseMove = false;
			columnItem11.Alignment = StringAlignment.Center;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.FontColor = Color.LightGray;
			columnItem11.IsExpand = false;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "refno";
			columnItem11.Text = "Ref No.";
			columnItem11.ValueFormat = FormatType.Text;
			columnItem11.Visible = true;
			columnItem11.Width = 10;
			columnItem12.Alignment = StringAlignment.Near;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.FontColor = Color.LightGray;
			columnItem12.IsExpand = false;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "stock";
			columnItem12.Text = "Symbol";
			columnItem12.ValueFormat = FormatType.Text;
			columnItem12.Visible = true;
			columnItem12.Width = 13;
			columnItem13.Alignment = StringAlignment.Far;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.FontColor = Color.LightGray;
			columnItem13.IsExpand = false;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "budget";
			columnItem13.Text = "Budget";
			columnItem13.ValueFormat = FormatType.Volume;
			columnItem13.Visible = true;
			columnItem13.Width = 12;
			columnItem14.Alignment = StringAlignment.Far;
			columnItem14.BackColor = Color.FromArgb(64, 64, 64);
			columnItem14.FontColor = Color.LightGray;
			columnItem14.IsExpand = false;
			columnItem14.MyStyle = FontStyle.Regular;
			columnItem14.Name = "pricelimit";
			columnItem14.Text = "Price Limit";
			columnItem14.ValueFormat = FormatType.Text;
			columnItem14.Visible = true;
			columnItem14.Width = 11;
			columnItem15.Alignment = StringAlignment.Center;
			columnItem15.BackColor = Color.FromArgb(64, 64, 64);
			columnItem15.FontColor = Color.LightGray;
			columnItem15.IsExpand = false;
			columnItem15.MyStyle = FontStyle.Regular;
			columnItem15.Name = "period";
			columnItem15.Text = "Period";
			columnItem15.ValueFormat = FormatType.Text;
			columnItem15.Visible = true;
			columnItem15.Width = 11;
			columnItem16.Alignment = StringAlignment.Center;
			columnItem16.BackColor = Color.FromArgb(64, 64, 64);
			columnItem16.FontColor = Color.LightGray;
			columnItem16.IsExpand = false;
			columnItem16.MyStyle = FontStyle.Regular;
			columnItem16.Name = "startdate";
			columnItem16.Text = "Start Date";
			columnItem16.ValueFormat = FormatType.Text;
			columnItem16.Visible = true;
			columnItem16.Width = 10;
			columnItem17.Alignment = StringAlignment.Center;
			columnItem17.BackColor = Color.FromArgb(64, 64, 64);
			columnItem17.FontColor = Color.LightGray;
			columnItem17.IsExpand = false;
			columnItem17.MyStyle = FontStyle.Regular;
			columnItem17.Name = "enddate";
			columnItem17.Text = "End Date";
			columnItem17.ValueFormat = FormatType.Text;
			columnItem17.Visible = true;
			columnItem17.Width = 10;
			columnItem18.Alignment = StringAlignment.Far;
			columnItem18.BackColor = Color.FromArgb(64, 64, 64);
			columnItem18.FontColor = Color.LightGray;
			columnItem18.IsExpand = false;
			columnItem18.MyStyle = FontStyle.Regular;
			columnItem18.Name = "matvol";
			columnItem18.Text = "Matched";
			columnItem18.ValueFormat = FormatType.Volume;
			columnItem18.Visible = true;
			columnItem18.Width = 10;
			columnItem19.Alignment = StringAlignment.Center;
			columnItem19.BackColor = Color.FromArgb(64, 64, 64);
			columnItem19.FontColor = Color.LightGray;
			columnItem19.IsExpand = false;
			columnItem19.MyStyle = FontStyle.Regular;
			columnItem19.Name = "status";
			columnItem19.Text = "Status";
			columnItem19.ValueFormat = FormatType.Text;
			columnItem19.Visible = true;
			columnItem19.Width = 13;
			this.gridDcaMain.Columns.Add(columnItem11);
			this.gridDcaMain.Columns.Add(columnItem12);
			this.gridDcaMain.Columns.Add(columnItem13);
			this.gridDcaMain.Columns.Add(columnItem14);
			this.gridDcaMain.Columns.Add(columnItem15);
			this.gridDcaMain.Columns.Add(columnItem16);
			this.gridDcaMain.Columns.Add(columnItem17);
			this.gridDcaMain.Columns.Add(columnItem18);
			this.gridDcaMain.Columns.Add(columnItem19);
			this.gridDcaMain.CurrentScroll = 0;
			this.gridDcaMain.FocusItemIndex = -1;
			this.gridDcaMain.ForeColor = Color.Black;
			this.gridDcaMain.GridColor = Color.FromArgb(30, 30, 30);
			this.gridDcaMain.HeaderPctHeight = 100f;
			this.gridDcaMain.IsAutoRepaint = true;
			this.gridDcaMain.IsDrawGrid = true;
			this.gridDcaMain.IsDrawHeader = true;
			this.gridDcaMain.IsScrollable = true;
			this.gridDcaMain.Location = new Point(8, 35);
			this.gridDcaMain.MainColumn = "";
			this.gridDcaMain.Name = "gridDcaMain";
			this.gridDcaMain.Rows = 0;
			this.gridDcaMain.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.gridDcaMain.RowSelectType = 3;
			this.gridDcaMain.Size = new Size(724, 44);
			this.gridDcaMain.SortColumnName = "";
			this.gridDcaMain.SortType = SortType.Desc;
			this.gridDcaMain.TabIndex = 130;
			this.gridDcaMain.TableMouseDoubleClick += new ExpandGrid.TableMouseDoubleClickEventHandler(this.grid3_TableMouseDoubleClick);
			this.btnDcaCreate.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnDcaCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnDcaCreate.BackColor = Color.Transparent;
			this.btnDcaCreate.Cursor = Cursors.Hand;
			this.btnDcaCreate.FlatAppearance.BorderColor = Color.DimGray;
			this.btnDcaCreate.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnDcaCreate.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnDcaCreate.FlatStyle = FlatStyle.Flat;
			this.btnDcaCreate.ForeColor = Color.WhiteSmoke;
			this.btnDcaCreate.Image = Resources.blue_tab;
			this.btnDcaCreate.Location = new Point(605, 7);
			this.btnDcaCreate.MaximumSize = new Size(58, 23);
			this.btnDcaCreate.Name = "btnDcaCreate";
			this.btnDcaCreate.Size = new Size(54, 22);
			this.btnDcaCreate.TabIndex = 139;
			this.btnDcaCreate.TabStop = false;
			this.btnDcaCreate.Text = "Create";
			this.btnDcaCreate.UseVisualStyleBackColor = false;
			this.btnDcaCreate.Click += new EventHandler(this.btnDcaCreate_Click);
			this.btn3Cancel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btn3Cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btn3Cancel.BackColor = Color.Transparent;
			this.btn3Cancel.Cursor = Cursors.Hand;
			this.btn3Cancel.FlatAppearance.BorderColor = Color.DimGray;
			this.btn3Cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btn3Cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btn3Cancel.FlatStyle = FlatStyle.Flat;
			this.btn3Cancel.ForeColor = Color.WhiteSmoke;
			this.btn3Cancel.Image = Resources.side_sell;
			this.btn3Cancel.Location = new Point(668, 7);
			this.btn3Cancel.MaximumSize = new Size(58, 23);
			this.btn3Cancel.Name = "btn3Cancel";
			this.btn3Cancel.Size = new Size(54, 22);
			this.btn3Cancel.TabIndex = 132;
			this.btn3Cancel.TabStop = false;
			this.btn3Cancel.Text = "Cancel";
			this.btn3Cancel.UseVisualStyleBackColor = false;
			this.btn3Cancel.Click += new EventHandler(this.btnDcaCancel_Click);
			this.btnDcaReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnDcaReload.BackColor = Color.Transparent;
			this.btnDcaReload.Cursor = Cursors.Hand;
			this.btnDcaReload.FlatAppearance.BorderColor = Color.DimGray;
			this.btnDcaReload.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnDcaReload.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnDcaReload.FlatStyle = FlatStyle.Flat;
			this.btnDcaReload.ForeColor = Color.LightGray;
			this.btnDcaReload.Image = Resources.side_noside;
			this.btnDcaReload.Location = new Point(8, 7);
			this.btnDcaReload.MaximumSize = new Size(58, 23);
			this.btnDcaReload.Name = "btnDcaReload";
			this.btnDcaReload.Size = new Size(54, 22);
			this.btnDcaReload.TabIndex = 131;
			this.btnDcaReload.TabStop = false;
			this.btnDcaReload.Text = "Reload";
			this.btnDcaReload.UseVisualStyleBackColor = false;
			this.btnDcaReload.Click += new EventHandler(this.btnDcaReload_Click);
			this.panType2.BackColor = Color.FromArgb(30, 30, 30);
			this.panType2.Controls.Add(this.panel2OrderVal);
			this.panType2.Controls.Add(this.lb2SlipPage);
			this.panType2.Controls.Add(this.lbGrpCondLabel);
			this.panType2.Controls.Add(this.lb2ValueCutloss);
			this.panType2.Controls.Add(this.tb2SlipPage);
			this.panType2.Controls.Add(this.cb2ValueCutloss);
			this.panType2.Controls.Add(this.lb2ValueTrailingStop);
			this.panType2.Controls.Add(this.cb2ValueTrailingStop);
			this.panType2.Controls.Add(this.cb2OperCutloss);
			this.panType2.Controls.Add(this.cb2OperTrailingStop);
			this.panType2.Controls.Add(this.cb2OperTakeProfit);
			this.panType2.Controls.Add(this.chb2CutLossCond);
			this.panType2.Controls.Add(this.chb2TrailingStopCond);
			this.panType2.Controls.Add(this.chb2TakeProfitCond);
			this.panType2.Controls.Add(this.lb2ValueTakeProfit);
			this.panType2.Controls.Add(this.cb2ValueTakeProfit);
			this.panType2.Location = new Point(7, 93);
			this.panType2.Name = "panType2";
			this.panType2.Size = new Size(733, 99);
			this.panType2.TabIndex = 118;
			this.panType2.Visible = false;
			this.panel2OrderVal.Controls.Add(this.lb2PriceTakeProfit);
			this.panel2OrderVal.Controls.Add(this.tb2Volume);
			this.panel2OrderVal.Controls.Add(this.lb2PriceCutLoss);
			this.panel2OrderVal.Controls.Add(this.lb2Volume);
			this.panel2OrderVal.Controls.Add(this.chbGroupCancel);
			this.panel2OrderVal.Controls.Add(this.cb2PriceTakeProfit);
			this.panel2OrderVal.Controls.Add(this.cb2PriceTrailingStop);
			this.panel2OrderVal.Controls.Add(this.lb2PriceTrailingStop);
			this.panel2OrderVal.Controls.Add(this.cb2PriceCutLoss);
			this.panel2OrderVal.ForeColor = SystemColors.ControlLight;
			this.panel2OrderVal.Location = new Point(419, 4);
			this.panel2OrderVal.Name = "panel2OrderVal";
			this.panel2OrderVal.Size = new Size(207, 89);
			this.panel2OrderVal.TabIndex = 138;
			this.panel2OrderVal.TabStop = false;
			this.panel2OrderVal.Text = " Order Parameter ";
			this.lb2PriceTakeProfit.AutoSize = true;
			this.lb2PriceTakeProfit.Location = new Point(6, 22);
			this.lb2PriceTakeProfit.Margin = new Padding(2, 0, 2, 0);
			this.lb2PriceTakeProfit.Name = "lb2PriceTakeProfit";
			this.lb2PriceTakeProfit.Size = new Size(31, 13);
			this.lb2PriceTakeProfit.TabIndex = 13;
			this.lb2PriceTakeProfit.Text = "Price";
			this.lb2PriceTakeProfit.TextAlign = ContentAlignment.MiddleLeft;
			this.tb2Volume.BackColor = Color.FromArgb(224, 224, 224);
			this.tb2Volume.BorderStyle = BorderStyle.FixedSingle;
			this.tb2Volume.Location = new Point(141, 18);
			this.tb2Volume.Margin = new Padding(2, 3, 2, 3);
			this.tb2Volume.MaxLength = 10;
			this.tb2Volume.Name = "tb2Volume";
			this.tb2Volume.Size = new Size(59, 20);
			this.tb2Volume.TabIndex = 120;
			this.tb2Volume.TextChanged += new EventHandler(this.tb2Volume_TextChanged);
			this.tb2Volume.KeyDown += new KeyEventHandler(this.tb2Volume_KeyDown);
			this.tb2Volume.Leave += new EventHandler(this.controlOrder_Leave);
			this.tb2Volume.Enter += new EventHandler(this.controlOrder_Enter);
			this.lb2PriceCutLoss.AutoSize = true;
			this.lb2PriceCutLoss.Location = new Point(6, 68);
			this.lb2PriceCutLoss.Margin = new Padding(2, 0, 2, 0);
			this.lb2PriceCutLoss.Name = "lb2PriceCutLoss";
			this.lb2PriceCutLoss.Size = new Size(31, 13);
			this.lb2PriceCutLoss.TabIndex = 128;
			this.lb2PriceCutLoss.Text = "Price";
			this.lb2PriceCutLoss.TextAlign = ContentAlignment.MiddleLeft;
			this.lb2Volume.AutoSize = true;
			this.lb2Volume.Location = new Point(97, 22);
			this.lb2Volume.Margin = new Padding(2, 0, 2, 0);
			this.lb2Volume.Name = "lb2Volume";
			this.lb2Volume.Size = new Size(42, 13);
			this.lb2Volume.TabIndex = 11;
			this.lb2Volume.Text = "Volume";
			this.lb2Volume.TextAlign = ContentAlignment.MiddleLeft;
			this.chbGroupCancel.AutoSize = true;
			this.chbGroupCancel.Checked = true;
			this.chbGroupCancel.CheckState = CheckState.Checked;
			this.chbGroupCancel.Location = new Point(103, 66);
			this.chbGroupCancel.Margin = new Padding(2, 3, 0, 3);
			this.chbGroupCancel.Name = "chbGroupCancel";
			this.chbGroupCancel.Size = new Size(91, 17);
			this.chbGroupCancel.TabIndex = 111;
			this.chbGroupCancel.Text = "Group Cancel";
			this.chbGroupCancel.UseVisualStyleBackColor = false;
			this.cb2PriceTakeProfit.AllowDrop = true;
			this.cb2PriceTakeProfit.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"ATO",
				"ATC",
				"MP",
				"MO",
				"ML"
			});
			this.cb2PriceTakeProfit.AutoCompleteMode = AutoCompleteMode.Append;
			this.cb2PriceTakeProfit.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb2PriceTakeProfit.BackColor = Color.FromArgb(224, 224, 224);
			this.cb2PriceTakeProfit.FlatStyle = FlatStyle.Popup;
			this.cb2PriceTakeProfit.ForeColor = Color.Black;
			this.cb2PriceTakeProfit.FormattingEnabled = true;
			this.cb2PriceTakeProfit.Location = new Point(39, 18);
			this.cb2PriceTakeProfit.Name = "cb2PriceTakeProfit";
			this.cb2PriceTakeProfit.Size = new Size(50, 21);
			this.cb2PriceTakeProfit.TabIndex = 119;
			this.cb2PriceTakeProfit.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2PriceTakeProfit.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2PriceTakeProfit.KeyPress += new KeyPressEventHandler(this.cbPrice_KeyPress);
			this.cb2PriceTakeProfit.KeyDown += new KeyEventHandler(this.cb2PriceLast_KeyDown);
			this.cb2PriceTrailingStop.AllowDrop = true;
			this.cb2PriceTrailingStop.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"ATO",
				"ATC",
				"MP",
				"MO",
				"ML"
			});
			this.cb2PriceTrailingStop.AutoCompleteMode = AutoCompleteMode.Append;
			this.cb2PriceTrailingStop.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb2PriceTrailingStop.BackColor = Color.FromArgb(224, 224, 224);
			this.cb2PriceTrailingStop.Enabled = false;
			this.cb2PriceTrailingStop.FlatStyle = FlatStyle.Popup;
			this.cb2PriceTrailingStop.ForeColor = Color.Black;
			this.cb2PriceTrailingStop.FormattingEnabled = true;
			this.cb2PriceTrailingStop.Location = new Point(39, 41);
			this.cb2PriceTrailingStop.Name = "cb2PriceTrailingStop";
			this.cb2PriceTrailingStop.Size = new Size(50, 21);
			this.cb2PriceTrailingStop.TabIndex = 124;
			this.cb2PriceTrailingStop.Text = "MP";
			this.cb2PriceTrailingStop.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2PriceTrailingStop.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2PriceTrailingStop.KeyPress += new KeyPressEventHandler(this.cbPrice_KeyPress);
			this.lb2PriceTrailingStop.AutoSize = true;
			this.lb2PriceTrailingStop.Location = new Point(6, 45);
			this.lb2PriceTrailingStop.Margin = new Padding(2, 0, 2, 0);
			this.lb2PriceTrailingStop.Name = "lb2PriceTrailingStop";
			this.lb2PriceTrailingStop.Size = new Size(31, 13);
			this.lb2PriceTrailingStop.TabIndex = 122;
			this.lb2PriceTrailingStop.Text = "Price";
			this.lb2PriceTrailingStop.TextAlign = ContentAlignment.MiddleLeft;
			this.cb2PriceCutLoss.AllowDrop = true;
			this.cb2PriceCutLoss.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"ATO",
				"ATC",
				"MP",
				"MO",
				"ML"
			});
			this.cb2PriceCutLoss.AutoCompleteMode = AutoCompleteMode.Append;
			this.cb2PriceCutLoss.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb2PriceCutLoss.BackColor = Color.FromArgb(224, 224, 224);
			this.cb2PriceCutLoss.Enabled = false;
			this.cb2PriceCutLoss.FlatStyle = FlatStyle.Popup;
			this.cb2PriceCutLoss.ForeColor = Color.Black;
			this.cb2PriceCutLoss.FormattingEnabled = true;
			this.cb2PriceCutLoss.Location = new Point(39, 64);
			this.cb2PriceCutLoss.Name = "cb2PriceCutLoss";
			this.cb2PriceCutLoss.Size = new Size(50, 21);
			this.cb2PriceCutLoss.TabIndex = 127;
			this.cb2PriceCutLoss.Text = "MP";
			this.cb2PriceCutLoss.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2PriceCutLoss.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2PriceCutLoss.KeyPress += new KeyPressEventHandler(this.cbPrice_KeyPress);
			this.lb2SlipPage.AutoSize = true;
			this.lb2SlipPage.ForeColor = Color.LightGray;
			this.lb2SlipPage.Location = new Point(315, 51);
			this.lb2SlipPage.Margin = new Padding(2, 0, 2, 0);
			this.lb2SlipPage.Name = "lb2SlipPage";
			this.lb2SlipPage.Size = new Size(62, 13);
			this.lb2SlipPage.TabIndex = 135;
			this.lb2SlipPage.Text = "Slippage(%)";
			this.lb2SlipPage.TextAlign = ContentAlignment.MiddleLeft;
			this.lb2SlipPage.Visible = false;
			this.lbGrpCondLabel.AutoSize = true;
			this.lbGrpCondLabel.BackColor = Color.Transparent;
			this.lbGrpCondLabel.BorderStyle = BorderStyle.FixedSingle;
			this.lbGrpCondLabel.ForeColor = Color.LightGray;
			this.lbGrpCondLabel.Location = new Point(2, 2);
			this.lbGrpCondLabel.Margin = new Padding(2, 0, 2, 0);
			this.lbGrpCondLabel.Name = "lbGrpCondLabel";
			this.lbGrpCondLabel.Padding = new Padding(2);
			this.lbGrpCondLabel.Size = new Size(94, 19);
			this.lbGrpCondLabel.TabIndex = 134;
			this.lbGrpCondLabel.Text = "Group Conditions";
			this.lbGrpCondLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lb2ValueCutloss.AutoSize = true;
			this.lb2ValueCutloss.ForeColor = Color.LightGray;
			this.lb2ValueCutloss.Location = new Point(216, 74);
			this.lb2ValueCutloss.Margin = new Padding(2, 0, 2, 0);
			this.lb2ValueCutloss.Name = "lb2ValueCutloss";
			this.lb2ValueCutloss.Size = new Size(37, 13);
			this.lb2ValueCutloss.TabIndex = 133;
			this.lb2ValueCutloss.Text = "Period";
			this.lb2ValueCutloss.TextAlign = ContentAlignment.MiddleRight;
			this.tb2SlipPage.BackColor = Color.FromArgb(224, 224, 224);
			this.tb2SlipPage.BorderStyle = BorderStyle.FixedSingle;
			this.tb2SlipPage.Location = new Point(385, 47);
			this.tb2SlipPage.Margin = new Padding(2, 3, 2, 3);
			this.tb2SlipPage.MaxLength = 10;
			this.tb2SlipPage.Name = "tb2SlipPage";
			this.tb2SlipPage.Size = new Size(25, 20);
			this.tb2SlipPage.TabIndex = 136;
			this.tb2SlipPage.Visible = false;
			this.tb2SlipPage.KeyDown += new KeyEventHandler(this.tb2SlipPage_KeyDown);
			this.tb2SlipPage.Leave += new EventHandler(this.controlOrder_Leave);
			this.tb2SlipPage.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2ValueCutloss.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb2ValueCutloss.BackColor = Color.FromArgb(224, 224, 224);
			this.cb2ValueCutloss.FlatStyle = FlatStyle.Popup;
			this.cb2ValueCutloss.ForeColor = Color.Black;
			this.cb2ValueCutloss.FormattingEnabled = true;
			this.cb2ValueCutloss.Location = new Point(257, 70);
			this.cb2ValueCutloss.Name = "cb2ValueCutloss";
			this.cb2ValueCutloss.Size = new Size(50, 21);
			this.cb2ValueCutloss.TabIndex = 126;
			this.cb2ValueCutloss.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2ValueCutloss.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2ValueCutloss.KeyDown += new KeyEventHandler(this.cb2ValueCutloss_KeyDown);
			this.lb2ValueTrailingStop.AutoSize = true;
			this.lb2ValueTrailingStop.ForeColor = Color.LightGray;
			this.lb2ValueTrailingStop.Location = new Point(216, 51);
			this.lb2ValueTrailingStop.Margin = new Padding(2, 0, 2, 0);
			this.lb2ValueTrailingStop.Name = "lb2ValueTrailingStop";
			this.lb2ValueTrailingStop.Size = new Size(37, 13);
			this.lb2ValueTrailingStop.TabIndex = 127;
			this.lb2ValueTrailingStop.Text = "Period";
			this.lb2ValueTrailingStop.TextAlign = ContentAlignment.MiddleRight;
			this.cb2ValueTrailingStop.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb2ValueTrailingStop.BackColor = Color.FromArgb(224, 224, 224);
			this.cb2ValueTrailingStop.FlatStyle = FlatStyle.Popup;
			this.cb2ValueTrailingStop.ForeColor = Color.Black;
			this.cb2ValueTrailingStop.FormattingEnabled = true;
			this.cb2ValueTrailingStop.Location = new Point(257, 47);
			this.cb2ValueTrailingStop.Name = "cb2ValueTrailingStop";
			this.cb2ValueTrailingStop.Size = new Size(50, 21);
			this.cb2ValueTrailingStop.TabIndex = 123;
			this.cb2ValueTrailingStop.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2ValueTrailingStop.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2ValueTrailingStop.KeyDown += new KeyEventHandler(this.cb2ValueTrailingStop_KeyDown);
			this.cb2OperCutloss.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cb2OperCutloss.FlatStyle = FlatStyle.Flat;
			this.cb2OperCutloss.FormattingEnabled = true;
			this.cb2OperCutloss.Items.AddRange(new object[]
			{
				"Last <",
				"Break Low <"
			});
			this.cb2OperCutloss.Location = new Point(96, 70);
			this.cb2OperCutloss.Margin = new Padding(2);
			this.cb2OperCutloss.Name = "cb2OperCutloss";
			this.cb2OperCutloss.Size = new Size(112, 21);
			this.cb2OperCutloss.TabIndex = 121;
			this.cb2OperCutloss.SelectedIndexChanged += new EventHandler(this.cb2OperCutloss_SelectedIndexChanged);
			this.cb2OperCutloss.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2OperCutloss.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2OperCutloss.KeyDown += new KeyEventHandler(this.cb2OperCutloss_KeyDown);
			this.cb2OperTrailingStop.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cb2OperTrailingStop.FlatStyle = FlatStyle.Flat;
			this.cb2OperTrailingStop.FormattingEnabled = true;
			this.cb2OperTrailingStop.Items.AddRange(new object[]
			{
				"Last < SMA",
				"Last < Break Low",
				"Last < Discount High",
				"Last > Robound Low "
			});
			this.cb2OperTrailingStop.Location = new Point(96, 47);
			this.cb2OperTrailingStop.Margin = new Padding(2);
			this.cb2OperTrailingStop.Name = "cb2OperTrailingStop";
			this.cb2OperTrailingStop.Size = new Size(112, 21);
			this.cb2OperTrailingStop.TabIndex = 122;
			this.cb2OperTrailingStop.SelectedIndexChanged += new EventHandler(this.cb2OperTrailingStop_SelectedIndexChanged);
			this.cb2OperTrailingStop.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2OperTrailingStop.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2OperTrailingStop.KeyDown += new KeyEventHandler(this.cb2OperTrailingStop_KeyDown);
			this.cb2OperTakeProfit.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cb2OperTakeProfit.FlatStyle = FlatStyle.Flat;
			this.cb2OperTakeProfit.FormattingEnabled = true;
			this.cb2OperTakeProfit.Items.AddRange(new object[]
			{
				"Last >="
			});
			this.cb2OperTakeProfit.Location = new Point(96, 24);
			this.cb2OperTakeProfit.Margin = new Padding(2);
			this.cb2OperTakeProfit.Name = "cb2OperTakeProfit";
			this.cb2OperTakeProfit.Size = new Size(112, 21);
			this.cb2OperTakeProfit.TabIndex = 117;
			this.cb2OperTakeProfit.SelectedIndexChanged += new EventHandler(this.cb2OperTakeProfit_SelectedIndexChanged);
			this.cb2OperTakeProfit.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2OperTakeProfit.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2OperTakeProfit.KeyDown += new KeyEventHandler(this.cb2OperTakeProfit_KeyDown);
			this.chb2CutLossCond.AutoSize = true;
			this.chb2CutLossCond.ForeColor = Color.LightGray;
			this.chb2CutLossCond.Location = new Point(10, 72);
			this.chb2CutLossCond.Margin = new Padding(2);
			this.chb2CutLossCond.Name = "chb2CutLossCond";
			this.chb2CutLossCond.Size = new Size(67, 17);
			this.chb2CutLossCond.TabIndex = 125;
			this.chb2CutLossCond.Text = "Cut Loss";
			this.chb2CutLossCond.UseVisualStyleBackColor = true;
			this.chb2TrailingStopCond.AutoSize = true;
			this.chb2TrailingStopCond.ForeColor = Color.LightGray;
			this.chb2TrailingStopCond.Location = new Point(10, 49);
			this.chb2TrailingStopCond.Margin = new Padding(2);
			this.chb2TrailingStopCond.Name = "chb2TrailingStopCond";
			this.chb2TrailingStopCond.Size = new Size(85, 17);
			this.chb2TrailingStopCond.TabIndex = 121;
			this.chb2TrailingStopCond.Text = "Trailing Stop";
			this.chb2TrailingStopCond.UseVisualStyleBackColor = true;
			this.chb2TakeProfitCond.AutoSize = true;
			this.chb2TakeProfitCond.ForeColor = Color.LightGray;
			this.chb2TakeProfitCond.Location = new Point(10, 27);
			this.chb2TakeProfitCond.Margin = new Padding(2);
			this.chb2TakeProfitCond.Name = "chb2TakeProfitCond";
			this.chb2TakeProfitCond.Size = new Size(78, 17);
			this.chb2TakeProfitCond.TabIndex = 116;
			this.chb2TakeProfitCond.Text = "Take Profit";
			this.chb2TakeProfitCond.UseVisualStyleBackColor = true;
			this.lb2ValueTakeProfit.AutoSize = true;
			this.lb2ValueTakeProfit.ForeColor = Color.LightGray;
			this.lb2ValueTakeProfit.Location = new Point(219, 28);
			this.lb2ValueTakeProfit.Margin = new Padding(2, 0, 2, 0);
			this.lb2ValueTakeProfit.Name = "lb2ValueTakeProfit";
			this.lb2ValueTakeProfit.Size = new Size(34, 13);
			this.lb2ValueTakeProfit.TabIndex = 115;
			this.lb2ValueTakeProfit.Text = "Value";
			this.lb2ValueTakeProfit.TextAlign = ContentAlignment.MiddleRight;
			this.cb2ValueTakeProfit.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb2ValueTakeProfit.BackColor = Color.FromArgb(224, 224, 224);
			this.cb2ValueTakeProfit.FlatStyle = FlatStyle.Popup;
			this.cb2ValueTakeProfit.ForeColor = Color.Black;
			this.cb2ValueTakeProfit.FormattingEnabled = true;
			this.cb2ValueTakeProfit.Location = new Point(257, 24);
			this.cb2ValueTakeProfit.Name = "cb2ValueTakeProfit";
			this.cb2ValueTakeProfit.Size = new Size(50, 21);
			this.cb2ValueTakeProfit.TabIndex = 118;
			this.cb2ValueTakeProfit.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb2ValueTakeProfit.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb2ValueTakeProfit.KeyDown += new KeyEventHandler(this.cb2ValueTakeProfit_KeyDown);
			this.btnTypePZ.AutoEllipsis = true;
			this.btnTypePZ.Cursor = Cursors.Hand;
			this.btnTypePZ.FlatAppearance.BorderColor = Color.DimGray;
			this.btnTypePZ.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnTypePZ.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnTypePZ.FlatStyle = FlatStyle.Flat;
			this.btnTypePZ.ForeColor = Color.WhiteSmoke;
			this.btnTypePZ.Location = new Point(709, 6);
			this.btnTypePZ.MaximumSize = new Size(58, 23);
			this.btnTypePZ.Name = "btnTypePZ";
			this.btnTypePZ.Size = new Size(31, 22);
			this.btnTypePZ.TabIndex = 125;
			this.btnTypePZ.TabStop = false;
			this.btnTypePZ.Text = "PZ";
			this.toolTip1.SetToolTip(this.btnTypePZ, "Pricing Zone");
			this.btnTypePZ.UseVisualStyleBackColor = false;
			this.btnTypePZ.Click += new EventHandler(this.btnTypePZ_Click);
			this.panType1.BackColor = Color.FromArgb(30, 30, 30);
			this.panType1.Controls.Add(this.panel1OrderVal);
			this.panType1.Controls.Add(this.lbTimingStop);
			this.panType1.Controls.Add(this.cbTimingStop);
			this.panType1.Controls.Add(this.lbSlipPage);
			this.panType1.Controls.Add(this.tbSlipPage);
			this.panType1.Controls.Add(this.cb1Condition);
			this.panType1.Controls.Add(this.lb1Value);
			this.panType1.Controls.Add(this.cb1Value);
			this.panType1.Controls.Add(this.lbStopOrderField);
			this.panType1.Location = new Point(6, 31);
			this.panType1.Name = "panType1";
			this.panType1.Size = new Size(734, 60);
			this.panType1.TabIndex = 110;
			this.panel1OrderVal.Controls.Add(this.tb1Volume);
			this.panel1OrderVal.Controls.Add(this.lbPrice);
			this.panel1OrderVal.Controls.Add(this.cb1Price);
			this.panel1OrderVal.Controls.Add(this.lb1Volume);
			this.panel1OrderVal.ForeColor = Color.WhiteSmoke;
			this.panel1OrderVal.Location = new Point(460, 9);
			this.panel1OrderVal.Name = "panel1OrderVal";
			this.panel1OrderVal.Size = new Size(220, 45);
			this.panel1OrderVal.TabIndex = 125;
			this.panel1OrderVal.TabStop = false;
			this.panel1OrderVal.Text = " Order Parameter ";
			this.lbTimingStop.AutoSize = true;
			this.lbTimingStop.ForeColor = Color.LightGray;
			this.lbTimingStop.Location = new Point(12, 34);
			this.lbTimingStop.Margin = new Padding(2, 0, 2, 0);
			this.lbTimingStop.Name = "lbTimingStop";
			this.lbTimingStop.Size = new Size(30, 13);
			this.lbTimingStop.TabIndex = 122;
			this.lbTimingStop.Text = "Time";
			this.lbTimingStop.TextAlign = ContentAlignment.MiddleLeft;
			this.lbTimingStop.Visible = false;
			this.cbTimingStop.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbTimingStop.BackColor = Color.FromArgb(224, 224, 224);
			this.cbTimingStop.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbTimingStop.FlatStyle = FlatStyle.Popup;
			this.cbTimingStop.ForeColor = Color.Black;
			this.cbTimingStop.FormattingEnabled = true;
			this.cbTimingStop.Items.AddRange(new object[]
			{
				"12:20",
				"12:25",
				"16:20",
				"16:25"
			});
			this.cbTimingStop.Location = new Point(45, 30);
			this.cbTimingStop.Name = "cbTimingStop";
			this.cbTimingStop.Size = new Size(53, 21);
			this.cbTimingStop.TabIndex = 123;
			this.cbTimingStop.Visible = false;
			this.cbTimingStop.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbTimingStop.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbTimingStop.KeyDown += new KeyEventHandler(this.cbTimingStop_KeyDown);
			this.lbSlipPage.AutoSize = true;
			this.lbSlipPage.ForeColor = Color.LightGray;
			this.lbSlipPage.Location = new Point(356, 34);
			this.lbSlipPage.Margin = new Padding(2, 0, 2, 0);
			this.lbSlipPage.Name = "lbSlipPage";
			this.lbSlipPage.Size = new Size(62, 13);
			this.lbSlipPage.TabIndex = 120;
			this.lbSlipPage.Text = "Slippage(%)";
			this.lbSlipPage.TextAlign = ContentAlignment.MiddleLeft;
			this.lbSlipPage.Visible = false;
			this.tbSlipPage.BackColor = Color.FromArgb(224, 224, 224);
			this.tbSlipPage.BorderStyle = BorderStyle.FixedSingle;
			this.tbSlipPage.Location = new Point(425, 30);
			this.tbSlipPage.Margin = new Padding(2, 3, 2, 3);
			this.tbSlipPage.MaxLength = 5;
			this.tbSlipPage.Name = "tbSlipPage";
			this.tbSlipPage.Size = new Size(28, 20);
			this.tbSlipPage.TabIndex = 121;
			this.tbSlipPage.Visible = false;
			this.tbSlipPage.KeyDown += new KeyEventHandler(this.tbSlipPage_KeyDown);
			this.tbSlipPage.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbSlipPage.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb1Condition.AllowDrop = true;
			this.cb1Condition.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb1Condition.BackColor = Color.FromArgb(224, 224, 224);
			this.cb1Condition.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cb1Condition.FlatStyle = FlatStyle.Popup;
			this.cb1Condition.ForeColor = Color.Black;
			this.cb1Condition.FormattingEnabled = true;
			this.cb1Condition.Items.AddRange(new object[]
			{
				"Last >=",
				"Last <=",
				"Last >= SMA(Day)",
				"Last <= SMA(Day)",
				"Last > Break High (Day)",
				"Last < Break High (Day)",
				"Last > Break Low (Day)",
				"Last < Break Low (Day)",
				"Last < Discount High (Day)",
				"Last > Rebound Low (Day)"
			});
			this.cb1Condition.Location = new Point(106, 30);
			this.cb1Condition.Name = "cb1Condition";
			this.cb1Condition.Size = new Size(140, 21);
			this.cb1Condition.TabIndex = 116;
			this.cb1Condition.SelectedIndexChanged += new EventHandler(this.cb1Condition_SelectedIndexChanged);
			this.cb1Condition.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb1Condition.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb1Condition.KeyDown += new KeyEventHandler(this.cb1Condition_KeyDown);
			this.lb1Value.AutoSize = true;
			this.lb1Value.ForeColor = Color.LightGray;
			this.lb1Value.Location = new Point(253, 34);
			this.lb1Value.Margin = new Padding(2, 0, 2, 0);
			this.lb1Value.Name = "lb1Value";
			this.lb1Value.Size = new Size(34, 13);
			this.lb1Value.TabIndex = 115;
			this.lb1Value.Text = "Value";
			this.lb1Value.TextAlign = ContentAlignment.MiddleLeft;
			this.cb1Value.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cb1Value.BackColor = Color.FromArgb(224, 224, 224);
			this.cb1Value.FlatStyle = FlatStyle.Popup;
			this.cb1Value.ForeColor = Color.Black;
			this.cb1Value.FormattingEnabled = true;
			this.cb1Value.Location = new Point(294, 30);
			this.cb1Value.Name = "cb1Value";
			this.cb1Value.Size = new Size(55, 21);
			this.cb1Value.TabIndex = 117;
			this.cb1Value.Leave += new EventHandler(this.controlOrder_Leave);
			this.cb1Value.Enter += new EventHandler(this.controlOrder_Enter);
			this.cb1Value.KeyDown += new KeyEventHandler(this.cb1Value_KeyDown);
			this.lbStopOrderField.AutoSize = true;
			this.lbStopOrderField.BackColor = Color.Transparent;
			this.lbStopOrderField.BorderStyle = BorderStyle.FixedSingle;
			this.lbStopOrderField.ForeColor = Color.WhiteSmoke;
			this.lbStopOrderField.Location = new Point(2, 2);
			this.lbStopOrderField.Name = "lbStopOrderField";
			this.lbStopOrderField.Padding = new Padding(2);
			this.lbStopOrderField.Size = new Size(91, 19);
			this.lbStopOrderField.TabIndex = 109;
			this.lbStopOrderField.Text = "Simple Condition";
			this.lbStopOrderField.TextAlign = ContentAlignment.MiddleLeft;
			this.btnTypeDCA.AutoEllipsis = true;
			this.btnTypeDCA.Cursor = Cursors.Hand;
			this.btnTypeDCA.FlatAppearance.BorderColor = Color.DimGray;
			this.btnTypeDCA.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnTypeDCA.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnTypeDCA.FlatStyle = FlatStyle.Flat;
			this.btnTypeDCA.ForeColor = Color.WhiteSmoke;
			this.btnTypeDCA.Location = new Point(666, 6);
			this.btnTypeDCA.MaximumSize = new Size(58, 23);
			this.btnTypeDCA.Name = "btnTypeDCA";
			this.btnTypeDCA.Size = new Size(39, 22);
			this.btnTypeDCA.TabIndex = 123;
			this.btnTypeDCA.TabStop = false;
			this.btnTypeDCA.Text = "DCA";
			this.toolTip1.SetToolTip(this.btnTypeDCA, "Dolla Cost Average");
			this.btnTypeDCA.UseVisualStyleBackColor = false;
			this.btnTypeDCA.Click += new EventHandler(this.btnTypeDCA_Click);
			this.btnTypeMM.AutoEllipsis = true;
			this.btnTypeMM.Cursor = Cursors.Hand;
			this.btnTypeMM.FlatAppearance.BorderColor = Color.DimGray;
			this.btnTypeMM.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnTypeMM.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnTypeMM.FlatStyle = FlatStyle.Flat;
			this.btnTypeMM.ForeColor = Color.WhiteSmoke;
			this.btnTypeMM.Location = new Point(626, 6);
			this.btnTypeMM.MaximumSize = new Size(58, 23);
			this.btnTypeMM.Name = "btnTypeMM";
			this.btnTypeMM.Size = new Size(35, 22);
			this.btnTypeMM.TabIndex = 119;
			this.btnTypeMM.TabStop = false;
			this.btnTypeMM.Text = "MM";
			this.toolTip1.SetToolTip(this.btnTypeMM, "Money Management");
			this.btnTypeMM.UseVisualStyleBackColor = false;
			this.btnTypeMM.Click += new EventHandler(this.btnTypeMM_Click);
			this.btnSell.AutoEllipsis = true;
			this.btnSell.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnSell.BackColor = Color.Transparent;
			this.btnSell.Cursor = Cursors.Hand;
			this.btnSell.FlatAppearance.BorderColor = Color.DimGray;
			this.btnSell.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSell.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnSell.FlatStyle = FlatStyle.Flat;
			this.btnSell.ForeColor = Color.WhiteSmoke;
			this.btnSell.Image = Resources.side_noside;
			this.btnSell.Location = new Point(56, 5);
			this.btnSell.MaximumSize = new Size(58, 23);
			this.btnSell.Name = "btnSell";
			this.btnSell.Size = new Size(45, 22);
			this.btnSell.TabIndex = 117;
			this.btnSell.TabStop = false;
			this.btnSell.Text = "Sell";
			this.btnSell.UseVisualStyleBackColor = false;
			this.btnSell.Click += new EventHandler(this.btnSell_Click);
			this.btnBuy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnBuy.BackColor = Color.Transparent;
			this.btnBuy.Cursor = Cursors.Hand;
			this.btnBuy.FlatAppearance.BorderColor = Color.DimGray;
			this.btnBuy.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnBuy.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnBuy.FlatStyle = FlatStyle.Flat;
			this.btnBuy.ForeColor = Color.WhiteSmoke;
			this.btnBuy.Image = Resources.side_noside;
			this.btnBuy.Location = new Point(7, 5);
			this.btnBuy.MaximumSize = new Size(58, 23);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new Size(45, 22);
			this.btnBuy.TabIndex = 116;
			this.btnBuy.TabStop = false;
			this.btnBuy.Text = "Buy";
			this.btnBuy.UseVisualStyleBackColor = false;
			this.btnBuy.Click += new EventHandler(this.btnBuy_Click);
			this.btnType2.AutoEllipsis = true;
			this.btnType2.Cursor = Cursors.Hand;
			this.btnType2.FlatAppearance.BorderColor = Color.DimGray;
			this.btnType2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnType2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnType2.FlatStyle = FlatStyle.Flat;
			this.btnType2.ForeColor = Color.WhiteSmoke;
			this.btnType2.Location = new Point(544, 6);
			this.btnType2.MaximumSize = new Size(58, 23);
			this.btnType2.Name = "btnType2";
			this.btnType2.Size = new Size(22, 22);
			this.btnType2.TabIndex = 113;
			this.btnType2.TabStop = false;
			this.btnType2.Text = "2";
			this.toolTip1.SetToolTip(this.btnType2, "Group Conditions");
			this.btnType2.UseVisualStyleBackColor = false;
			this.btnType2.Click += new EventHandler(this.btnType2_Click);
			this.btnType1.AutoEllipsis = true;
			this.btnType1.BackColor = Color.DodgerBlue;
			this.btnType1.Cursor = Cursors.Hand;
			this.btnType1.FlatAppearance.BorderColor = Color.DimGray;
			this.btnType1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnType1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnType1.FlatStyle = FlatStyle.Flat;
			this.btnType1.ForeColor = Color.WhiteSmoke;
			this.btnType1.Location = new Point(514, 6);
			this.btnType1.MaximumSize = new Size(58, 23);
			this.btnType1.Name = "btnType1";
			this.btnType1.Size = new Size(22, 22);
			this.btnType1.TabIndex = 112;
			this.btnType1.TabStop = false;
			this.btnType1.Text = "1";
			this.toolTip1.SetToolTip(this.btnType1, "Simple");
			this.btnType1.UseVisualStyleBackColor = false;
			this.btnType1.Click += new EventHandler(this.btnType1_Click);
			this.lbPattern.AutoSize = true;
			this.lbPattern.ForeColor = Color.LightGray;
			this.lbPattern.Location = new Point(473, 10);
			this.lbPattern.Margin = new Padding(2, 0, 2, 0);
			this.lbPattern.Name = "lbPattern";
			this.lbPattern.Size = new Size(31, 13);
			this.lbPattern.TabIndex = 111;
			this.lbPattern.Text = "Type";
			this.lbPattern.TextAlign = ContentAlignment.MiddleLeft;
			this.tStripMenu.AllowMerge = false;
			this.tStripMenu.BackColor = Color.FromArgb(40, 40, 40);
			this.tStripMenu.CanOverflow = false;
			this.tStripMenu.GripMargin = new Padding(0);
			this.tStripMenu.GripStyle = ToolStripGripStyle.Hidden;
			this.tStripMenu.Items.AddRange(new ToolStripItem[]
			{
				this.tslbMode,
				this.tsbtnMode,
				this.tslbStatus,
				this.tscbStatus,
				this.tslbStock,
				this.tstbStock,
				this.tslbSide,
				this.tscbSide,
				this.tsbtnClearCondition,
				this.tsbtnCancelOrder,
				this.tsbtnSearch
			});
			this.tStripMenu.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.tStripMenu.Location = new Point(0, 0);
			this.tStripMenu.Name = "tStripMenu";
			this.tStripMenu.Padding = new Padding(1, 2, 1, 1);
			this.tStripMenu.RenderMode = ToolStripRenderMode.System;
			this.tStripMenu.Size = new Size(752, 28);
			this.tStripMenu.TabIndex = 114;
			this.tslbMode.ForeColor = Color.Gainsboro;
			this.tslbMode.Margin = new Padding(2, 1, 5, 2);
			this.tslbMode.Name = "tslbMode";
			this.tslbMode.Size = new Size(38, 22);
			this.tslbMode.Text = "Mode";
			this.tsbtnMode.BackColor = Color.FromArgb(45, 45, 45);
			this.tsbtnMode.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tsbtnMode.ForeColor = Color.LightGray;
			this.tsbtnMode.Items.AddRange(new object[]
			{
				"Active",
				"History"
			});
			this.tsbtnMode.Name = "tsbtnMode";
			this.tsbtnMode.Padding = new Padding(2, 0, 2, 0);
			this.tsbtnMode.Size = new Size(75, 25);
			this.tsbtnMode.ToolTipText = "Switch Mode(Active/History)";
			this.tsbtnMode.SelectedIndexChanged += new EventHandler(this.tsbtnMode_SelectedIndexChanged);
			this.tslbStatus.BackColor = Color.Transparent;
			this.tslbStatus.ForeColor = Color.Gainsboro;
			this.tslbStatus.Margin = new Padding(5, 1, 1, 1);
			this.tslbStatus.Name = "tslbStatus";
			this.tslbStatus.Size = new Size(39, 23);
			this.tslbStatus.Text = "Status";
			this.tscbStatus.AutoCompleteCustomSource.AddRange(new string[]
			{
				"ALL",
				"O",
				"PO",
				"M",
				"C",
				"PX",
				"R",
				"X"
			});
			this.tscbStatus.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tscbStatus.BackColor = Color.FromArgb(45, 45, 45);
			this.tscbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbStatus.ForeColor = Color.LightGray;
			this.tscbStatus.Margin = new Padding(1, 0, 1, 2);
			this.tscbStatus.MaxLength = 3;
			this.tscbStatus.Name = "tscbStatus";
			this.tscbStatus.Size = new Size(75, 23);
			this.tslbStock.BackColor = Color.Transparent;
			this.tslbStock.ForeColor = Color.Gainsboro;
			this.tslbStock.Margin = new Padding(5, 1, 1, 1);
			this.tslbStock.Name = "tslbStock";
			this.tslbStock.Size = new Size(47, 23);
			this.tslbStock.Text = "Symbol";
			this.tstbStock.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tstbStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tstbStock.BackColor = Color.FromArgb(45, 45, 45);
			this.tstbStock.BorderStyle = BorderStyle.FixedSingle;
			this.tstbStock.CharacterCasing = CharacterCasing.Upper;
			this.tstbStock.Font = new Font("Microsoft Sans Serif", 9f);
			this.tstbStock.ForeColor = Color.LightGray;
			this.tstbStock.Margin = new Padding(1, 0, 1, 2);
			this.tstbStock.MaxLength = 12;
			this.tstbStock.Name = "tstbStock";
			this.tstbStock.Size = new Size(80, 23);
			this.tstbStock.KeyDown += new KeyEventHandler(this.tstbStock_KeyDown);
			this.tslbSide.BackColor = Color.Transparent;
			this.tslbSide.ForeColor = Color.Gainsboro;
			this.tslbSide.Margin = new Padding(5, 1, 1, 1);
			this.tslbSide.Name = "tslbSide";
			this.tslbSide.Size = new Size(29, 23);
			this.tslbSide.Text = "Side";
			this.tscbSide.AutoCompleteCustomSource.AddRange(new string[]
			{
				"ALL",
				"B",
				"S",
				"H",
				"C"
			});
			this.tscbSide.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tscbSide.BackColor = Color.FromArgb(45, 45, 45);
			this.tscbSide.DropDownStyle = ComboBoxStyle.DropDownList;
			this.tscbSide.ForeColor = Color.LightGray;
			this.tscbSide.Items.AddRange(new object[]
			{
				"ALL",
				"B",
				"S"
			});
			this.tscbSide.Margin = new Padding(1, 0, 1, 2);
			this.tscbSide.MaxLength = 3;
			this.tscbSide.Name = "tscbSide";
			this.tscbSide.Size = new Size(75, 23);
			this.tsbtnClearCondition.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbtnClearCondition.ForeColor = Color.Gainsboro;
			this.tsbtnClearCondition.ImageTransparentColor = Color.Magenta;
			this.tsbtnClearCondition.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnClearCondition.Name = "tsbtnClearCondition";
			this.tsbtnClearCondition.Size = new Size(38, 22);
			this.tsbtnClearCondition.Text = "Clear";
			this.tsbtnClearCondition.ToolTipText = "Clear Condition";
			this.tsbtnClearCondition.Click += new EventHandler(this.tsbtnClearCondition_Click);
			this.tsbtnCancelOrder.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnCancelOrder.ForeColor = Color.Tomato;
			this.tsbtnCancelOrder.Image = (Image)componentResourceManager.GetObject("tsbtnCancelOrder.Image");
			this.tsbtnCancelOrder.ImageTransparentColor = Color.Magenta;
			this.tsbtnCancelOrder.Name = "tsbtnCancelOrder";
			this.tsbtnCancelOrder.Size = new Size(63, 22);
			this.tsbtnCancelOrder.Text = "Cancel";
			this.tsbtnCancelOrder.ToolTipText = "Cancel Order";
			this.tsbtnCancelOrder.Click += new EventHandler(this.tsbtnCancelOrder_Click);
			this.tsbtnSearch.Font = new Font("Microsoft Sans Serif", 9f);
			this.tsbtnSearch.ForeColor = Color.Gainsboro;
			this.tsbtnSearch.Image = Resources.refresh;
			this.tsbtnSearch.ImageTransparentColor = Color.Magenta;
			this.tsbtnSearch.Margin = new Padding(5, 1, 0, 2);
			this.tsbtnSearch.Name = "tsbtnSearch";
			this.tsbtnSearch.Size = new Size(66, 22);
			this.tsbtnSearch.Text = "Search";
			this.tsbtnSearch.Click += new EventHandler(this.tsbtnSearch_Click);
			this.panel1.BackColor = Color.FromArgb(50, 50, 50);
			this.panel1.Controls.Add(this.intzaOrder);
			this.panel1.Controls.Add(this.tStripMenu);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(0, 424);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(752, 105);
			this.panel1.TabIndex = 116;
			this.intzaOrder.AllowDrop = true;
			this.intzaOrder.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaOrder.CanBlink = true;
			this.intzaOrder.CanDrag = false;
			this.intzaOrder.CanGetMouseMove = false;
			columnItem20.Alignment = StringAlignment.Near;
			columnItem20.BackColor = Color.FromArgb(64, 64, 64);
			columnItem20.FontColor = Color.LightGray;
			columnItem20.IsExpand = false;
			columnItem20.MyStyle = FontStyle.Regular;
			columnItem20.Name = "checkbox";
			columnItem20.Text = "";
			columnItem20.ValueFormat = FormatType.Bitmap;
			columnItem20.Visible = true;
			columnItem20.Width = 3;
			columnItem21.Alignment = StringAlignment.Center;
			columnItem21.BackColor = Color.FromArgb(64, 64, 64);
			columnItem21.FontColor = Color.LightGray;
			columnItem21.IsExpand = false;
			columnItem21.MyStyle = FontStyle.Regular;
			columnItem21.Name = "side";
			columnItem21.Text = "B/S";
			columnItem21.ValueFormat = FormatType.Text;
			columnItem21.Visible = true;
			columnItem21.Width = 5;
			columnItem22.Alignment = StringAlignment.Near;
			columnItem22.BackColor = Color.FromArgb(64, 64, 64);
			columnItem22.FontColor = Color.LightGray;
			columnItem22.IsExpand = false;
			columnItem22.MyStyle = FontStyle.Regular;
			columnItem22.Name = "stock";
			columnItem22.Text = "Symbol";
			columnItem22.ValueFormat = FormatType.Text;
			columnItem22.Visible = true;
			columnItem22.Width = 12;
			columnItem23.Alignment = StringAlignment.Far;
			columnItem23.BackColor = Color.FromArgb(64, 64, 64);
			columnItem23.FontColor = Color.LightGray;
			columnItem23.IsExpand = false;
			columnItem23.MyStyle = FontStyle.Regular;
			columnItem23.Name = "volume";
			columnItem23.Text = "Volume";
			columnItem23.ValueFormat = FormatType.Volume;
			columnItem23.Visible = true;
			columnItem23.Width = 13;
			columnItem24.Alignment = StringAlignment.Far;
			columnItem24.BackColor = Color.FromArgb(64, 64, 64);
			columnItem24.FontColor = Color.LightGray;
			columnItem24.IsExpand = false;
			columnItem24.MyStyle = FontStyle.Regular;
			columnItem24.Name = "price";
			columnItem24.Text = "Price";
			columnItem24.ValueFormat = FormatType.Text;
			columnItem24.Visible = true;
			columnItem24.Width = 10;
			columnItem25.Alignment = StringAlignment.Near;
			columnItem25.BackColor = Color.FromArgb(64, 64, 64);
			columnItem25.FontColor = Color.LightGray;
			columnItem25.IsExpand = false;
			columnItem25.MyStyle = FontStyle.Regular;
			columnItem25.Name = "condition";
			columnItem25.Text = "Condition";
			columnItem25.ValueFormat = FormatType.Text;
			columnItem25.Visible = true;
			columnItem25.Width = 33;
			columnItem26.Alignment = StringAlignment.Center;
			columnItem26.BackColor = Color.FromArgb(64, 64, 64);
			columnItem26.FontColor = Color.LightGray;
			columnItem26.IsExpand = false;
			columnItem26.MyStyle = FontStyle.Regular;
			columnItem26.Name = "status";
			columnItem26.Text = "Status";
			columnItem26.ValueFormat = FormatType.Text;
			columnItem26.Visible = true;
			columnItem26.Width = 13;
			columnItem27.Alignment = StringAlignment.Center;
			columnItem27.BackColor = Color.FromArgb(64, 64, 64);
			columnItem27.FontColor = Color.LightGray;
			columnItem27.IsExpand = false;
			columnItem27.MyStyle = FontStyle.Regular;
			columnItem27.Name = "sent_time";
			columnItem27.Text = "Time";
			columnItem27.ValueFormat = FormatType.Text;
			columnItem27.Visible = true;
			columnItem27.Width = 11;
			columnItem28.Alignment = StringAlignment.Center;
			columnItem28.BackColor = Color.FromArgb(64, 64, 64);
			columnItem28.FontColor = Color.LightGray;
			columnItem28.IsExpand = false;
			columnItem28.MyStyle = FontStyle.Regular;
			columnItem28.Name = "limit";
			columnItem28.Text = "Expire Date";
			columnItem28.ValueFormat = FormatType.Text;
			columnItem28.Visible = true;
			columnItem28.Width = 12;
			columnItem29.Alignment = StringAlignment.Center;
			columnItem29.BackColor = Color.FromArgb(64, 64, 64);
			columnItem29.FontColor = Color.LightGray;
			columnItem29.IsExpand = false;
			columnItem29.MyStyle = FontStyle.Regular;
			columnItem29.Name = "tfex_position";
			columnItem29.Text = "Position";
			columnItem29.ValueFormat = FormatType.Text;
			columnItem29.Visible = false;
			columnItem29.Width = 10;
			columnItem30.Alignment = StringAlignment.Center;
			columnItem30.BackColor = Color.FromArgb(64, 64, 64);
			columnItem30.FontColor = Color.LightGray;
			columnItem30.IsExpand = false;
			columnItem30.MyStyle = FontStyle.Regular;
			columnItem30.Name = "group_cancel";
			columnItem30.Text = "Group Cancel";
			columnItem30.ValueFormat = FormatType.Text;
			columnItem30.Visible = true;
			columnItem30.Width = 12;
			columnItem31.Alignment = StringAlignment.Center;
			columnItem31.BackColor = Color.FromArgb(64, 64, 64);
			columnItem31.FontColor = Color.LightGray;
			columnItem31.IsExpand = false;
			columnItem31.MyStyle = FontStyle.Regular;
			columnItem31.Name = "ref_no";
			columnItem31.Text = "Ref No.";
			columnItem31.ValueFormat = FormatType.Text;
			columnItem31.Visible = true;
			columnItem31.Width = 10;
			columnItem32.Alignment = StringAlignment.Center;
			columnItem32.BackColor = Color.FromArgb(64, 64, 64);
			columnItem32.FontColor = Color.LightGray;
			columnItem32.IsExpand = false;
			columnItem32.MyStyle = FontStyle.Regular;
			columnItem32.Name = "mm_src_ordno";
			columnItem32.Text = "Source No";
			columnItem32.ValueFormat = FormatType.Text;
			columnItem32.Visible = true;
			columnItem32.Width = 11;
			columnItem33.Alignment = StringAlignment.Center;
			columnItem33.BackColor = Color.FromArgb(64, 64, 64);
			columnItem33.FontColor = Color.LightGray;
			columnItem33.IsExpand = false;
			columnItem33.MyStyle = FontStyle.Regular;
			columnItem33.Name = "matched_time";
			columnItem33.Text = "S-Time";
			columnItem33.ValueFormat = FormatType.Text;
			columnItem33.Visible = true;
			columnItem33.Width = 10;
			columnItem34.Alignment = StringAlignment.Center;
			columnItem34.BackColor = Color.FromArgb(64, 64, 64);
			columnItem34.FontColor = Color.LightGray;
			columnItem34.IsExpand = false;
			columnItem34.MyStyle = FontStyle.Regular;
			columnItem34.Name = "order_no";
			columnItem34.Text = "Order No";
			columnItem34.ValueFormat = FormatType.Text;
			columnItem34.Visible = true;
			columnItem34.Width = 11;
			columnItem35.Alignment = StringAlignment.Near;
			columnItem35.BackColor = Color.FromArgb(64, 64, 64);
			columnItem35.FontColor = Color.LightGray;
			columnItem35.IsExpand = false;
			columnItem35.MyStyle = FontStyle.Regular;
			columnItem35.Name = "error";
			columnItem35.Text = "Error";
			columnItem35.ValueFormat = FormatType.Text;
			columnItem35.Visible = true;
			columnItem35.Width = 70;
			this.intzaOrder.Columns.Add(columnItem20);
			this.intzaOrder.Columns.Add(columnItem21);
			this.intzaOrder.Columns.Add(columnItem22);
			this.intzaOrder.Columns.Add(columnItem23);
			this.intzaOrder.Columns.Add(columnItem24);
			this.intzaOrder.Columns.Add(columnItem25);
			this.intzaOrder.Columns.Add(columnItem26);
			this.intzaOrder.Columns.Add(columnItem27);
			this.intzaOrder.Columns.Add(columnItem28);
			this.intzaOrder.Columns.Add(columnItem29);
			this.intzaOrder.Columns.Add(columnItem30);
			this.intzaOrder.Columns.Add(columnItem31);
			this.intzaOrder.Columns.Add(columnItem32);
			this.intzaOrder.Columns.Add(columnItem33);
			this.intzaOrder.Columns.Add(columnItem34);
			this.intzaOrder.Columns.Add(columnItem35);
			this.intzaOrder.CurrentScroll = 0;
			this.intzaOrder.Dock = DockStyle.Fill;
			this.intzaOrder.FocusItemIndex = -1;
			this.intzaOrder.ForeColor = Color.Black;
			this.intzaOrder.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaOrder.HeaderPctHeight = 100f;
			this.intzaOrder.IsAutoRepaint = true;
			this.intzaOrder.IsDrawGrid = true;
			this.intzaOrder.IsDrawHeader = true;
			this.intzaOrder.IsScrollable = true;
			this.intzaOrder.Location = new Point(0, 28);
			this.intzaOrder.MainColumn = "";
			this.intzaOrder.Name = "intzaOrder";
			this.intzaOrder.Rows = 0;
			this.intzaOrder.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.intzaOrder.RowSelectType = 3;
			this.intzaOrder.Size = new Size(752, 77);
			this.intzaOrder.SortColumnName = "";
			this.intzaOrder.SortType = SortType.Desc;
			this.intzaOrder.TabIndex = 116;
			this.intzaOrder.TableMouseClick += new ExpandGrid.TableMouseClickEventHandler(this.intzaOrder_TableMouseClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(752, 529);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panelTop);
			base.Name = "frmAutoTrade";
			this.Text = "frmAutoTrade";
			base.IDoShownDelay += new ClientBaseForm.OnShownDelayEventHandler(this.frmAutoTrade_IDoShownDelay);
			base.IDoLoadData += new ClientBaseForm.OnIDoLoadDataEventHandler(this.frmAutoTrade_IDoLoadData);
			base.IDoFontChanged += new ClientBaseForm.OnFontChangedEventHandler(this.frmAutoTrade_IDoFontChanged);
			base.IDoCustomSizeChanged += new ClientBaseForm.CustomSizeChangedEventHandler(this.frmAutoTrade_IDoCustomSizeChanged);
			base.IDoSymbolLinked += new ClientBaseForm.OnSymbolLinkEventHandler(this.frmAutoTrade_IDoSymbolLinked);
			base.IDoMainFormKeyUp += new ClientBaseForm.OnFormKeyUpEventHandler(this.frmAutoTrade_IDoMainFormKeyUp);
			base.IDoReActivated += new ClientBaseForm.OnReActiveEventHandler(this.frmAutoTrade_IDoReActivated);
			base.Controls.SetChildIndex(this.panelTop, 0);
			base.Controls.SetChildIndex(this.panel1, 0);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.panelPZ.ResumeLayout(false);
			this.panelDCA.ResumeLayout(false);
			this.panType2.ResumeLayout(false);
			this.panType2.PerformLayout();
			this.panel2OrderVal.ResumeLayout(false);
			this.panel2OrderVal.PerformLayout();
			this.panType1.ResumeLayout(false);
			this.panType1.PerformLayout();
			this.panel1OrderVal.ResumeLayout(false);
			this.panel1OrderVal.PerformLayout();
			this.tStripMenu.ResumeLayout(false);
			this.tStripMenu.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00103080 File Offset: 0x00101480
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmAutoTrade()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._typeId = "ALG1";
			this._ordSide = string.Empty;
			this.bgwSendOrder = null;
			this._frmConfirm = null;
			this._holidays = null;
			this._isReloadData = false;
			this._commandMain = null;
			this._frmDcaInfo = null;
			this._frmDcaCreateNew = null;
			this._frmPzInfo = null;
			this._frmPzCreateNew = null;
			this._accType = string.Empty;
			base..ctor();
			this.InitializeComponent();
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00103118 File Offset: 0x00101518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmAutoTrade(Dictionary<string, object> propertiesValue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._typeId = "ALG1";
			this._ordSide = string.Empty;
			this.bgwSendOrder = null;
			this._frmConfirm = null;
			this._holidays = null;
			this._isReloadData = false;
			this._commandMain = null;
			this._frmDcaInfo = null;
			this._frmDcaCreateNew = null;
			this._frmPzInfo = null;
			this._frmPzCreateNew = null;
			this._accType = string.Empty;
			base..ctor(propertiesValue);
			try
			{
				this.InitializeComponent();
				if (this.cbStock.AutoCompleteCustomSource != null)
				{
					this.cbStock.AutoCompleteMode = AutoCompleteMode.Suggest;
					this.cbStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
				}
				this.tscbStatus.Items.Clear();
				this.tscbStatus.Items.Add("ALL");
				this.tscbStatus.Items.Add(AutoTradeConstant.GetSatusString("P"));
				this.tscbStatus.Items.Add(AutoTradeConstant.GetSatusString("F"));
				this.tscbStatus.Items.Add(AutoTradeConstant.GetSatusString("S"));
				this.tscbStatus.Items.Add(AutoTradeConstant.GetSatusString("X"));
				this.tscbStatus.Items.Add(AutoTradeConstant.GetSatusString("XP"));
				this.bgwSendOrder = new BackgroundWorker();
				this.bgwSendOrder.WorkerReportsProgress = true;
				this.bgwSendOrder.DoWork += new DoWorkEventHandler(this.bgwSendOrder_DoWork);
				this.bgwSendOrder.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwSendOrder_RunWorkerCompleted);
				this.cb1Price.Text = "MP";
				this.cb2PriceTakeProfit.Text = "MP";
				this.cb2PriceTrailingStop.Text = "MP";
				this.cb2PriceCutLoss.Text = "MP";
				this.cbExpire.Text = "180 Days";
				this.cb1Price.Items.Clear();
				this.cb1Price.Items.Add("");
				this.cb1Price.Items.Add("MP");
				this.cb2PriceTakeProfit.Items.Clear();
				this.cb2PriceTakeProfit.Items.Add("");
				this.cb2PriceTakeProfit.Items.Add("MP");
				this.tsbtnMode.Text = "Active";
			}
			catch (Exception ex)
			{
				this.ShowError("frmAutoTrade", ex);
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x001033F4 File Offset: 0x001017F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAutoTrade_IDoLoadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string holiday = ApplicationInfo.WebAlertService.GetHoliday();
				this._holidays = new List<string>();
				using (DataSet dataSet = new DataSet())
				{
					MyDataHelper.StringToDataSet(holiday, dataSet);
					if (dataSet != null && dataSet.Tables.Contains("TAB"))
					{
						foreach (DataRow dataRow in dataSet.Tables["TAB"].Rows)
						{
							this._holidays.Add(dataRow["sDate"].ToString());
						}
					}
					dataSet.Clear();
				}
				this.cbStock.Text = ApplicationInfo.CurrentSymbol;
				this.cbStock.Focus();
			}
			catch (Exception ex)
			{
				this.ShowError("frmAutoTrade_IDoLoadData", ex);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00103590 File Offset: 0x00101990
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAutoTrade_IDoShownDelay()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.SetAutoTradeType("ALG1");
				this.tbPin.Text = ApplicationInfo.UserPincodeLastEntry;
				ApplicationInfo.OnPincodeChanged -= new ApplicationInfo.OnPincodeChangedCompleteHandler(this.ApplicationInfo_OnPincodeChanged);
				ApplicationInfo.OnPincodeChanged += new ApplicationInfo.OnPincodeChangedCompleteHandler(this.ApplicationInfo_OnPincodeChanged);
				base.Show();
				this.UpdateSideByAcc();
				this.SetAutoTradeType(this._typeId);
				base.IsLoadingData = false;
				base.OpenedForm();
			}
			catch (Exception ex)
			{
				this.ShowError("frmAutoTrade_IDoShownDelay", ex);
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00103644 File Offset: 0x00101A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAutoTrade_IDoReActivated()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				base.Show();
				this.UpdateSideByAcc();
				this.SetAutoTradeType(this._typeId);
				this.ReloadData();
				this.cbStock.Text = ApplicationInfo.CurrentSymbol;
				this.cbStock.Focus();
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x001036B0 File Offset: 0x00101AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAutoTrade_IDoMainFormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Space)
			{
				this.cbStock.Focus();
				this.cbStock.SelectAll();
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00103700 File Offset: 0x00101B00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAutoTrade_IDoCustomSizeChanged()
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

		// Token: 0x0600138B RID: 5003 RVA: 0x00103740 File Offset: 0x00101B40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAutoTrade_IDoFontChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.SetResize(true, true);
			}
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00103774 File Offset: 0x00101B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00103788 File Offset: 0x00101B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0010379C File Offset: 0x00101B9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ApplicationInfo_OnPincodeChanged()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (base.InvokeRequired)
				{
					base.BeginInvoke(new MethodInvoker(this.ApplicationInfo_OnPincodeChanged));
				}
				else
				{
					this.tbPin.Text = ApplicationInfo.UserPincodeLastEntry;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("OnPincodeChanged", ex);
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00103820 File Offset: 0x00101C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetResize(bool isWidthChanged, bool isHeightChanged)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._typeId == "ALGDC")
				{
					this.panelTop.Height = base.Height;
					this.panelDCA.SetBounds(5, this.btnBuy.Bottom + 5, this.panelTop.Width - 10, this.panelTop.Height - (this.btnTypeDCA.Bottom + 5) - 5);
					if (this._frmDcaCreateNew != null && this._frmDcaCreateNew.Visible)
					{
						this._frmDcaCreateNew.Bounds = new Rectangle(0, 0, this.panelDCA.Width, this.panelDCA.Height);
					}
					if (this._frmDcaInfo != null && this._frmDcaInfo.Visible)
					{
						this._frmDcaInfo.Bounds = new Rectangle(0, 0, this.panelDCA.Width, this.panelDCA.Height);
					}
				}
				else if (this._typeId == "ALGPZ")
				{
					this.panelTop.Height = base.Height;
					this.panelPZ.SetBounds(5, this.btnTypePZ.Bottom + 5, this.panelTop.Width - 10, this.panelTop.Bottom - (this.btnTypePZ.Bottom + 5) - 5);
					if (this._frmPzCreateNew != null && this._frmPzCreateNew.Visible)
					{
						this._frmPzCreateNew.Bounds = new Rectangle(0, 0, this.panelPZ.Width, this.panelPZ.Height);
					}
					if (this._frmPzInfo != null && this._frmPzInfo.Visible)
					{
						this._frmPzInfo.Bounds = new Rectangle(0, 0, this.panelPZ.Width, this.panelPZ.Height);
					}
				}
				else if (this._typeId == "ALG1" || this._typeId == "ALGTS" || this._typeId == "ALGSF")
				{
					this.panType1.SetBounds(5, this.btnBuy.Bottom + 5, this.panelTop.Width - 10, this.cb1Condition.Bottom + 10);
					this.panelTop.Height = this.panType1.Bottom + 50;
					this.btnBuy.Left = 10;
					this.btnSell.Left = this.btnBuy.Right + 10;
					if (ApplicationInfo.IsEquityAccount)
					{
						if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance && ApplicationInfo.SuuportSBL == "Y")
						{
							this.btnCover.Left = this.btnSell.Right + 10;
							this.btnShort.Left = this.btnCover.Right + 10;
							this.lbStock.Left = this.btnShort.Right + 10;
							this.cbStock.Left = this.lbStock.Right + 5;
						}
						else
						{
							this.lbStock.Left = this.btnSell.Right + 10;
							this.cbStock.Left = this.lbStock.Right + 5;
						}
					}
					else
					{
						this.rdbTfexOpenPosition.Left = this.btnSell.Right + 10;
						this.rdbTfexClosePosition.Left = this.rdbTfexOpenPosition.Right + 5;
						this.lbStock.Left = this.rdbTfexClosePosition.Right + 10;
						this.cbStock.Left = this.lbStock.Right + 5;
					}
					if (this.cb1Condition.Text.ToLower().IndexOf("discount") > -1 || this.cb1Condition.Text.ToLower().IndexOf("rebound") > -1)
					{
						this.lbSlipPage.Left = this.cb1Value.Right + 10;
						this.tbSlipPage.Left = this.lbSlipPage.Right + 5;
						this.panel1OrderVal.Left = this.tbSlipPage.Right + 15;
						this.lbSlipPage.Visible = true;
						this.tbSlipPage.Visible = true;
					}
					else
					{
						this.panel1OrderVal.Left = this.cb1Value.Right + 15;
						this.lbSlipPage.Visible = false;
						this.tbSlipPage.Visible = false;
					}
				}
				else if (this._typeId == "ALG2")
				{
					this.panType2.SetBounds(5, this.btnBuy.Bottom + 5, this.panelTop.Width - 10, this.cb2OperCutloss.Bottom + 10);
					this.panelTop.Height = this.panType2.Bottom + 50;
					if (ApplicationInfo.IsEquityAccount)
					{
						this.btnSell.Left = 10;
						if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance && ApplicationInfo.SuuportSBL == "Y")
						{
							this.btnCover.Left = this.btnSell.Right + 10;
							this.lbStock.Left = this.btnCover.Right + 10;
						}
						else
						{
							this.lbStock.Left = this.btnSell.Right + 10;
						}
					}
					else
					{
						this.btnBuy.Left = 10;
						this.btnSell.Left = this.btnBuy.Right + 10;
						this.rdbTfexClosePosition.Left = this.btnSell.Right + 10;
						this.lbStock.Left = this.rdbTfexClosePosition.Right + 10;
						this.cbStock.Left = this.lbStock.Right + 5;
					}
					this.cbStock.Left = this.lbStock.Right + 5;
					int right;
					if (this.cb2OperTrailingStop.Text.ToLower().IndexOf("discount") > -1 || this.cb2OperTrailingStop.Text.ToLower().IndexOf("rebound") > -1)
					{
						this.lb2SlipPage.Visible = true;
						this.tb2SlipPage.Visible = true;
						right = this.cb2ValueTrailingStop.Right;
						this.lb2SlipPage.Left = this.cb2ValueTrailingStop.Right + 10;
						this.tb2SlipPage.Left = this.lb2SlipPage.Right + 5;
						right = this.tb2SlipPage.Right;
					}
					else
					{
						this.lb2SlipPage.Visible = false;
						this.tb2SlipPage.Visible = false;
						right = this.cb2ValueTrailingStop.Right;
					}
					this.panel2OrderVal.Left = right + 15;
				}
				else if (this._typeId == "ALGMM")
				{
					this.panelTop.Height = this.btnSell.Bottom + 10;
				}
				if (this._typeId == "ALG1" || this._typeId == "ALG2" || this._typeId == "ALGTS" || this._typeId == "ALGSF")
				{
					this.btnClear.Location = new Point(this.panelTop.Width - this.btnClear.Width - 10, this.panelTop.Bottom - this.btnClear.Height - 10);
					this.btnSendOrder.Location = new Point(this.btnClear.Left - this.btnSendOrder.Width - 10, this.btnClear.Top);
					this.tbPin.Location = new Point(this.btnSendOrder.Left - this.tbPin.Width - 15, this.btnClear.Top + 2);
					this.lbPin.Location = new Point(this.tbPin.Left - this.lbPin.Width - 5, this.btnClear.Top + 4);
					this.cbExpire.Location = new Point(this.lbPin.Left - this.cbExpire.Width - 10, this.btnClear.Top + 1);
					this.lbExpire.Location = new Point(this.cbExpire.Left - this.lbExpire.Width - 5, this.btnClear.Top + 4);
				}
				int num = this.panelTop.Width;
				if (ApplicationInfo.IsEquityAccount)
				{
					if (this.btnTypePZ.Visible)
					{
						this.btnTypePZ.Location = new Point(this.panelTop.Width - this.btnTypePZ.Width - 5, 5);
						num = this.btnTypePZ.Left;
					}
					if (this.btnTypeDCA.Visible)
					{
						this.btnTypeDCA.Location = new Point(num - this.btnTypeDCA.Width - 5, 5);
						num = this.btnTypeDCA.Left;
					}
				}
				if (this.btnTypeMM.Visible)
				{
					this.btnTypeMM.Location = new Point(num - this.btnTypeMM.Width - 5, 5);
					num = this.btnTypeMM.Left;
				}
				if (this.btnType4.Visible)
				{
					this.btnType4.Location = new Point(num - this.btnType4.Width - 5, 5);
					num = this.btnType4.Left;
				}
				if (this.btnType3.Visible)
				{
					this.btnType3.Location = new Point(num - this.btnType3.Width - 5, 5);
					num = this.btnType3.Left;
				}
				if (this.btnType2.Visible)
				{
					this.btnType2.Location = new Point(num - this.btnType2.Width - 5, 5);
					num = this.btnType2.Left;
				}
				this.btnType1.Location = new Point(num - this.btnType1.Width - 5, 5);
				num = this.btnType1.Left;
				this.lbPattern.Location = new Point(num - this.lbPattern.Width - 5, this.lbStock.Top);
			}
			catch
			{
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00104440 File Offset: 0x00102840
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadData()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isReloadData)
				{
					base.IsLoadingData = true;
					this._isReloadData = true;
					ApplicationInfo.WebAlertService.ViewAutoTradeTransCompleted -= new ViewAutoTradeTransCompletedEventHandler(this.WebAlertService_ViewAutoTradeTransCompleted);
					ApplicationInfo.WebAlertService.ViewAutoTradeTransCompleted += new ViewAutoTradeTransCompletedEventHandler(this.WebAlertService_ViewAutoTradeTransCompleted);
					ApplicationInfo.WebAlertService.ViewAutoTradeTransAsync(ApplicationInfo.UserLoginID, ApplicationInfo.AccInfo.CurrentAccount, this._typeId, this.tstbStock.Text, (this.tscbSide.Text.ToLower() == "all") ? string.Empty : this.tscbSide.Text, AutoTradeConstant.GetStatusByName(this.tscbStatus.Text, this._typeId), this.tsbtnMode.Text != "Active");
				}
			}
			catch (Exception ex)
			{
				this.ShowError("RequestWeb", ex);
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00104560 File Offset: 0x00102960
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebAlertService_ViewAutoTradeTransCompleted(object sender, ViewAutoTradeTransCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.WebAlertService.ViewAutoTradeTransCompleted -= new ViewAutoTradeTransCompletedEventHandler(this.WebAlertService_ViewAutoTradeTransCompleted);
				if (e.Error == null)
				{
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(e.Result.ToString(), dataSet);
						if (this._typeId == "ALG1" || this._typeId == "ALG2" || this._typeId == "ALGTS" || this._typeId == "ALGSF" || this._typeId == "ALGMM")
						{
							if (dataSet.Tables.Contains("AUTO"))
							{
								this.intzaOrder.SortColumnName = string.Empty;
								this.intzaOrder.BeginUpdate();
								if (this._typeId == "ALG1" || this._typeId == "ALGTS" || this._typeId == "ALGSF" || this._typeId == "ALGMM")
								{
									this.intzaOrder.Rows = dataSet.Tables["AUTO"].Rows.Count;
									int num = 0;
									foreach (DataRow dataRow in dataSet.Tables["AUTO"].Rows)
									{
										this.UpdateStopOrderToGrid(dataRow, num, false);
										num++;
									}
								}
								else if (this._typeId == "ALG2")
								{
									this.intzaOrder.Rows = 0;
									long num2 = 0L;
									long num3 = 0L;
									List<DataRow> list = new List<DataRow>();
									foreach (DataRow dataRow in dataSet.Tables["AUTO"].Rows)
									{
										long.TryParse(dataRow["ref_no"].ToString(), out num2);
										if (num3 == 0L)
										{
											num3 = num2;
										}
										if (num3 != num2)
										{
											this.UpdateStopOrderToGrid2(list, false);
											list.Clear();
											num3 = num2;
										}
										list.Add(dataRow);
									}
									if (list.Count > 0)
									{
										this.UpdateStopOrderToGrid2(list, false);
									}
								}
								this.intzaOrder.Redraw();
							}
						}
						else if (this._typeId == "ALGDC")
						{
							if (dataSet.Tables.Contains("AUTO"))
							{
								this.gridDcaMain.SortColumnName = string.Empty;
								this.gridDcaMain.BeginUpdate();
								this.gridDcaMain.Rows = dataSet.Tables["AUTO"].Rows.Count;
								int num = 0;
								foreach (DataRow dataRow in dataSet.Tables["AUTO"].Rows)
								{
									RecordItem recordItem = this.gridDcaMain.Records(num);
									recordItem.Fields("refno").Text = dataRow["iRefNo"].ToString();
									recordItem.Fields("stock").Text = dataRow["sSymbol"].ToString();
									recordItem.Fields("budget").Text = dataRow["nmrBudget"].ToString();
									DateTime dateTime = DateTime.ParseExact(dataRow["sStartDate"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
									recordItem.Fields("startdate").Text = dateTime.ToString("dd MMM yy");
									dateTime = DateTime.ParseExact(dataRow["sEndDate"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
									recordItem.Fields("enddate").Text = dateTime.ToString("dd MMM yy");
									recordItem.Fields("matvol").Text = dataRow["iTotMat"].ToString();
									recordItem.Fields("pricelimit").Text = FormatUtil.PriceFormat(dataRow["nmrPriceLimit"].ToString());
									string text = dataRow["sPeriod"].ToString();
									if (text != null)
									{
										if (!(text == "D"))
										{
											if (!(text == "W"))
											{
												if (text == "M")
												{
													recordItem.Fields("period").Text = "Every Month";
												}
											}
											else
											{
												recordItem.Fields("period").Text = "Every Week";
											}
										}
										else
										{
											recordItem.Fields("period").Text = "Every Day";
										}
									}
									recordItem.Fields("period").FontColor = Color.LightGray;
									recordItem.Fields("status").Text = AutoTradeConstant.GetSatusString(dataRow["sStatus"].ToString());
									recordItem.Fields("refno").FontColor = Color.LightGray;
									recordItem.Fields("stock").FontColor = Color.LightGray;
									recordItem.Fields("budget").FontColor = Color.Yellow;
									recordItem.Fields("startdate").FontColor = Color.LightGray;
									recordItem.Fields("enddate").FontColor = Color.LightGray;
									recordItem.Fields("status").FontColor = Color.Cyan;
									recordItem.Fields("matvol").FontColor = Color.Yellow;
									recordItem.Fields("pricelimit").FontColor = Color.LightPink;
									num++;
								}
								this.gridDcaMain.Redraw();
								if (this.gridDcaMain.Rows > 0)
								{
									this.gridDcaMain.Focus();
									this.gridDcaMain.SetFocusItem(0);
								}
							}
						}
						else if (this._typeId == "ALGPZ")
						{
							if (dataSet.Tables.Contains("AUTO"))
							{
								this.gridPzMain.SortColumnName = string.Empty;
								this.gridPzMain.BeginUpdate();
								this.gridPzMain.Rows = dataSet.Tables["AUTO"].Rows.Count;
								int num = 0;
								foreach (DataRow dataRow in dataSet.Tables["AUTO"].Rows)
								{
									RecordItem recordItem = this.gridPzMain.Records(num);
									recordItem.Fields("refno").Text = dataRow["iRefNo"].ToString();
									recordItem.Fields("stock").Text = dataRow["sSymbol"].ToString();
									recordItem.Fields("budget").Text = dataRow["nmrBudget"].ToString();
									recordItem.Fields("start_price").Text = dataRow["nmrStartPrice"].ToString();
									recordItem.Fields("depth_pct").Text = dataRow["nmrChgPct"].ToString();
									recordItem.Fields("no_steps").Text = dataRow["iSegment"].ToString();
									long num4;
									long.TryParse(dataRow["iTotMatVol"].ToString(), out num4);
									decimal num5;
									decimal.TryParse(dataRow["iTotMatVal"].ToString(), out num5);
									recordItem.Fields("matvol").Text = num4;
									recordItem.Fields("matval").Text = num5;
									decimal num6 = 0m;
									if (num4 > 0L)
									{
										num6 = num5 / num4;
									}
									recordItem.Fields("avg").Text = num6;
									recordItem.Fields("status").Text = AutoTradeConstant.GetSatusString(dataRow["sStatus"].ToString());
									recordItem.Fields("refno").FontColor = Color.LightGray;
									recordItem.Fields("stock").FontColor = Color.LightGray;
									recordItem.Fields("budget").FontColor = MyColor.UnChgColor;
									recordItem.Fields("start_price").FontColor = MyColor.UnChgColor;
									recordItem.Fields("depth_pct").FontColor = Color.LightGray;
									recordItem.Fields("no_steps").FontColor = Color.LightGray;
									recordItem.Fields("status").FontColor = Color.LightGray;
									recordItem.Fields("matvol").FontColor = Color.Cyan;
									recordItem.Fields("matval").FontColor = Color.Cyan;
									recordItem.Fields("avg").FontColor = Color.Cyan;
									num++;
								}
								this.gridPzMain.Redraw();
								if (this.gridDcaMain.Rows > 0)
								{
									this.gridPzMain.Focus();
									this.gridPzMain.SetFocusItem(0);
								}
							}
						}
						dataSet.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				this.intzaOrder.Redraw();
				this.ShowError("ViewAutoTradeTransCompleted", ex);
			}
			this._isReloadData = false;
			base.IsLoadingData = false;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0010515C File Offset: 0x0010355C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStopOrderToGrid(DataRow dr, int i, bool isRedraw)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = 0L;
				long num2 = 0L;
				string text = string.Empty;
				string empty = string.Empty;
				string text2 = string.Empty;
				long.TryParse(dr["ref_no"].ToString(), out num2);
				text = dr["ord_side"].ToString();
				long.TryParse(dr["ord_volume"].ToString(), out num);
				text2 = dr["status"].ToString().Trim();
				int operType = 0;
				int.TryParse(dr["operator_type"].ToString(), out operType);
				decimal checkPrice = 0m;
				decimal.TryParse(dr["check_price"].ToString(), out checkPrice);
				decimal value = 0m;
				decimal.TryParse(dr["value"].ToString(), out value);
				decimal slipPage;
				decimal.TryParse(dr["slip_page"].ToString(), out slipPage);
				RecordItem recordItem;
				if (i == -1)
				{
					recordItem = this.intzaOrder.Find("ref_no", num2.ToString());
					if (recordItem == null)
					{
						recordItem = this.intzaOrder.AddRecord(1, false);
					}
				}
				else
				{
					recordItem = this.intzaOrder.Records(i);
				}
				recordItem.Fields("ref_no").Text = num2;
				recordItem.Fields("side").Text = text;
				recordItem.Fields("stock").Text = dr["stock"].ToString().Trim();
				recordItem.Fields("volume").Text = num;
				if (dr["expire_date"].ToString() != string.Empty)
				{
					DateTime dateTime = DateTime.ParseExact(dr["expire_date"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
					if (dateTime.ToString("yyyyMMdd") == DateTime.Now.ToString("yyyyMMdd"))
					{
						recordItem.Fields("limit").Text = "ToDay";
					}
					else
					{
						recordItem.Fields("limit").Text = dateTime.ToString("dd MMM yy");
					}
				}
				recordItem.Fields("status").Text = AutoTradeConstant.GetSatusString(text2);
				recordItem.Fields("price").Text = Utilities.PriceFormat(dr["ord_price"].ToString());
				if (dr["time"].ToString().Length == 6)
				{
					recordItem.Fields("sent_time").Text = Utilities.GetTime(dr["time"].ToString());
				}
				else
				{
					DateTime dateTime = DateTime.ParseExact(dr["time"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
					recordItem.Fields("sent_time").Text = dateTime.ToString("dd MMM yy");
				}
				recordItem.Fields("matched_time").Text = Utilities.GetTime(dr["mtime"].ToString());
				recordItem.Fields("condition").Text = this.GetConditionString(dr["field_type"].ToString().Trim(), operType, value, checkPrice, dr["stop_time"].ToString(), slipPage);
				recordItem.Fields("order_no").Text = ((dr["order_number"].ToString() == "0") ? "" : dr["order_number"].ToString());
				recordItem.Fields("mm_src_ordno").Text = dr["mm_src_ordno"].ToString();
				recordItem.Fields("error").Text = dr["message"].ToString().Trim();
				if (dr["tfex_position"].ToString() == "O")
				{
					recordItem.Fields("tfex_position").Text = "Open";
				}
				else
				{
					recordItem.Fields("tfex_position").Text = "Close";
				}
				recordItem.Fields("tfex_position").FontColor = Color.Yellow;
				recordItem.Fields("ref_no").FontColor = Color.White;
				if (ApplicationInfo.IsEquityAccount)
				{
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
						recordItem.Fields("side").FontColor = MyColor.UnChgColor;
					}
				}
				else if (text == "L")
				{
					recordItem.Fields("side").FontColor = MyColor.CeilingColor;
				}
				else if (text == "S")
				{
					recordItem.Fields("side").FontColor = MyColor.FloorColor;
				}
				else
				{
					recordItem.Fields("side").FontColor = MyColor.UnChgColor;
				}
				recordItem.Fields("stock").FontColor = Color.LightGray;
				recordItem.Fields("volume").FontColor = Color.LightGray;
				recordItem.Fields("price").FontColor = Color.LightGray;
				recordItem.Fields("limit").FontColor = Color.LightGray;
				recordItem.Fields("sent_time").FontColor = Color.LightGray;
				recordItem.Fields("matched_time").FontColor = Color.LightGray;
				recordItem.Fields("status").FontColor = Color.Cyan;
				recordItem.Fields("order_no").FontColor = MyColor.UnChgColor;
				recordItem.Fields("mm_src_ordno").FontColor = MyColor.UnChgColor;
				recordItem.Fields("error").FontColor = Color.Red;
				recordItem.Fields("condition").FontColor = MyColor.UnChgColor;
				if (text2 == "W" || text2 == "P" || text2 == "PM")
				{
					recordItem.Fields("checkbox").Text = "0";
				}
				else
				{
					recordItem.Fields("checkbox").Text = "";
				}
				recordItem.Changed = true;
				if (isRedraw)
				{
					this.intzaOrder.Redraw();
				}
			}
			catch (Exception ex)
			{
				this.intzaOrder.Redraw();
				this.ShowError("UpdateToControl", ex);
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00105984 File Offset: 0x00103D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStopOrderToGrid2(List<DataRow> arDr, bool isRedraw)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = 0L;
				long num2 = 0L;
				string text = string.Empty;
				string empty = string.Empty;
				string text2 = string.Empty;
				RecordItem recordItem = this.intzaOrder.Find("ref_no", num2.ToString());
				if (recordItem == null)
				{
					recordItem = this.intzaOrder.AddRecord(-1, false);
					this.intzaOrder.ExpandRows(this.intzaOrder.Rows - 1, arDr.Count, "", false, false);
				}
				int num3 = 1;
				bool flag = false;
				foreach (DataRow current in arDr)
				{
					long.TryParse(current["ref_no"].ToString(), out num2);
					text = current["ord_side"].ToString();
					long.TryParse(current["ord_volume"].ToString(), out num);
					text2 = current["status"].ToString().Trim();
					int operType = 0;
					int.TryParse(current["operator_type"].ToString(), out operType);
					decimal checkPrice = 0m;
					decimal.TryParse(current["check_price"].ToString(), out checkPrice);
					decimal value = 0m;
					decimal.TryParse(current["value"].ToString(), out value);
					decimal slipPage;
					decimal.TryParse(current["slip_page"].ToString(), out slipPage);
					if (num3 == 1)
					{
						recordItem.Fields("ref_no").Text = num2;
						recordItem.Fields("side").Text = text;
						recordItem.Fields("stock").Text = current["stock"].ToString().Trim();
						recordItem.Fields("volume").Text = num;
						if (current["expire_date"].ToString() != string.Empty)
						{
							DateTime dateTime = DateTime.ParseExact(current["expire_date"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
							if (dateTime.ToString("yyyyMMdd") == DateTime.Now.ToString("yyyyMMdd"))
							{
								recordItem.Fields("limit").Text = "ToDay";
							}
							else
							{
								recordItem.Fields("limit").Text = dateTime.ToString("dd MMM yy");
							}
						}
						recordItem.Fields("group_cancel").Text = current["group_cancel"].ToString();
						recordItem.Fields("status").Text = AutoTradeConstant.GetSatusString(text2);
						recordItem.Fields("price").Text = Utilities.PriceFormat(current["ord_price"].ToString());
						if (current["time"].ToString().Length == 6)
						{
							recordItem.Fields("sent_time").Text = Utilities.GetTime(current["time"].ToString());
						}
						else
						{
							DateTime dateTime = DateTime.ParseExact(current["time"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
							recordItem.Fields("sent_time").Text = dateTime.ToString("dd MMM yy");
						}
						if (current["mtime"].ToString().Length == 6)
						{
							recordItem.Fields("matched_time").Text = Utilities.GetTime(current["mtime"].ToString());
						}
						else if (current["mtime"].ToString().Length == 8)
						{
							DateTime dateTime = DateTime.ParseExact(current["mtime"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
							recordItem.Fields("matched_time").Text = dateTime.ToString("dd MMM yy");
						}
						recordItem.Fields("condition").Text = this.GetConditionString(current["field_type"].ToString().Trim(), operType, value, checkPrice, current["stop_time"].ToString(), slipPage);
						recordItem.Fields("order_no").Text = ((current["order_number"].ToString() == "0") ? "" : current["order_number"].ToString());
						recordItem.Fields("error").Text = current["message"].ToString().Trim();
						if (current["tfex_position"].ToString() == "O")
						{
							recordItem.Fields("tfex_position").Text = "Open";
						}
						else
						{
							recordItem.Fields("tfex_position").Text = "Close";
						}
						recordItem.Fields("tfex_position").FontColor = Color.Yellow;
						recordItem.Fields("ref_no").FontColor = Color.White;
						if (ApplicationInfo.IsEquityAccount)
						{
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
								recordItem.Fields("side").FontColor = MyColor.UnChgColor;
							}
						}
						else if (text == "L")
						{
							recordItem.Fields("side").FontColor = MyColor.CeilingColor;
						}
						else if (text == "S")
						{
							recordItem.Fields("side").FontColor = MyColor.FloorColor;
						}
						else
						{
							recordItem.Fields("side").FontColor = MyColor.UnChgColor;
						}
						recordItem.Fields("stock").FontColor = Color.LightGray;
						recordItem.Fields("volume").FontColor = Color.LightGray;
						recordItem.Fields("price").FontColor = Color.LightGray;
						recordItem.Fields("limit").FontColor = Color.LightGray;
						recordItem.Fields("sent_time").FontColor = Color.LightGray;
						recordItem.Fields("matched_time").FontColor = Color.LightGray;
						recordItem.Fields("status").FontColor = Color.Cyan;
						recordItem.Fields("order_no").FontColor = Color.Yellow;
						recordItem.Fields("error").FontColor = Color.Red;
						recordItem.Fields("condition").FontColor = MyColor.UnChgColor;
						recordItem.Changed = true;
					}
					else
					{
						SubRecordItem subRecordItem = this.intzaOrder.Records(this.intzaOrder.Rows - 1).SubRecord[num3 - 2];
						subRecordItem.Fields("price").Text = Utilities.PriceFormat(current["ord_price"].ToString());
						subRecordItem.Fields("status").Text = AutoTradeConstant.GetSatusString(text2);
						if (current["mtime"].ToString().Length == 6)
						{
							subRecordItem.Fields("matched_time").Text = Utilities.GetTime(current["mtime"].ToString());
						}
						else if (current["mtime"].ToString().Length == 8)
						{
							DateTime dateTime = DateTime.ParseExact(current["mtime"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
							subRecordItem.Fields("matched_time").Text = dateTime.ToString("dd MMM yy");
						}
						subRecordItem.Fields("condition").Text = this.GetConditionString(current["field_type"].ToString().Trim(), operType, value, checkPrice, current["stop_time"].ToString(), slipPage);
						subRecordItem.Fields("order_no").Text = ((current["order_number"].ToString() == "0") ? "" : current["order_number"].ToString());
						subRecordItem.Fields("error").Text = current["message"].ToString().Trim();
						subRecordItem.Fields("sent_time").FontColor = Color.LightGray;
						subRecordItem.Fields("matched_time").FontColor = Color.LightGray;
						subRecordItem.Fields("status").FontColor = Color.Cyan;
						subRecordItem.Fields("order_no").FontColor = Color.Yellow;
						subRecordItem.Fields("error").FontColor = Color.Red;
						subRecordItem.Fields("condition").FontColor = MyColor.UnChgColor;
					}
					if (text2 == "W" || text2 == "P")
					{
						flag = true;
					}
					num3++;
				}
				if (flag)
				{
					recordItem.Fields("checkbox").Text = "0";
				}
				else
				{
					recordItem.Fields("checkbox").Text = "";
				}
				if (isRedraw)
				{
					this.intzaOrder.Redraw();
				}
			}
			catch (Exception ex)
			{
				this.intzaOrder.Redraw();
				this.ShowError("UpdateToControl", ex);
			}
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00106524 File Offset: 0x00104924
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetConditionString(string fieldType, int operType, decimal value, decimal checkPrice, string stopTime, decimal slipPage)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = "  ";
			if (fieldType == "LAST" || fieldType == "SMA" || fieldType == "HHV" || fieldType == "LLV" || fieldType == "DISH" || fieldType == "RBLOW")
			{
				if (this._typeId == "ALGSF")
				{
					if (ApplicationInfo.IsEquityAccount)
					{
						text += "SET";
					}
					else
					{
						text += "SET50";
					}
				}
				else
				{
					text += "Last";
				}
			}
			else
			{
				text += "Unknow";
			}
			if (operType == 1)
			{
				text += " >= ";
			}
			else if (operType == 2)
			{
				text += " <= ";
			}
			else if (operType == 3)
			{
				text += " > ";
			}
			else if (operType == 4)
			{
				text += " < ";
			}
			if (fieldType == "SMA" || fieldType == "HHV" || fieldType == "LLV" || fieldType == "DISH" || fieldType == "RBLOW")
			{
				if (fieldType == "SMA")
				{
					text += "SMA ";
				}
				else if (fieldType == "HHV")
				{
					text += "Break High ";
				}
				else if (fieldType == "LLV")
				{
					text += "Break Low ";
				}
				else if (fieldType == "DISH")
				{
					text += "Discount High ";
				}
				else if (fieldType == "RBLOW")
				{
					text += "Rebound Low ";
				}
				text += Utilities.PriceFormat(value);
				if (checkPrice > 0m)
				{
					text = text + " (@" + Utilities.PriceFormat(checkPrice, 3) + " )";
				}
				else
				{
					text += " (...)";
				}
				if (slipPage > 0m)
				{
					text = text + " Sp " + Utilities.PriceFormat(slipPage) + "%";
				}
			}
			else
			{
				text += Utilities.PriceFormat(checkPrice);
			}
			if (stopTime != string.Empty)
			{
				text = text + " (" + Utilities.GetTime(stopTime) + ")";
			}
			return text;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00106884 File Offset: 0x00104C84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				((Control)sender).BackColor = MyColor.UnChgColor;
				((Control)sender).ForeColor = Color.Black;
				if (sender.GetType() == typeof(TextBox))
				{
					((TextBox)sender).SelectAll();
				}
				if (sender.Equals(this.cb1Price))
				{
					if (this.tbPin.Text == string.Empty && ApplicationInfo.UserPincodeLastEntry != string.Empty)
					{
						this.tbPin.Text = ApplicationInfo.UserPincodeLastEntry;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("controlOrder_Enter", ex);
			}
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0010697C File Offset: 0x00104D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender.GetType() == typeof(CheckBox))
				{
					((Control)sender).BackColor = Color.Transparent;
					((Control)sender).ForeColor = Color.LightGray;
				}
				else if (sender.GetType() == typeof(ComboBox))
				{
					((Control)sender).BackColor = Color.FromArgb(224, 224, 224);
					((Control)sender).ForeColor = Color.Black;
				}
				else
				{
					((Control)sender).BackColor = Color.FromArgb(224, 224, 224);
					((Control)sender).ForeColor = Color.Black;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("controlOrder_Leave", ex);
			}
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00106A94 File Offset: 0x00104E94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnType1_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetAutoTradeType("ALG1");
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00106AB4 File Offset: 0x00104EB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnType2_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetAutoTradeType("ALG2");
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00106AD4 File Offset: 0x00104ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnType3_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetAutoTradeType("ALGTS");
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00106AF4 File Offset: 0x00104EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnType4_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetAutoTradeType("ALGSF");
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00106B14 File Offset: 0x00104F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnTypeDCA_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetAutoTradeType("ALGDC");
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00106B34 File Offset: 0x00104F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnTypeMM_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetAutoTradeType("ALGMM");
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00106B54 File Offset: 0x00104F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnTypePZ_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetAutoTradeType("ALGPZ");
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00106B74 File Offset: 0x00104F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateSideByAcc()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tscbSide.Items.Clear();
				if (ApplicationInfo.IsEquityAccount)
				{
					if (ApplicationInfo.SuuportSBL == "Y")
					{
						this.tscbSide.Items.AddRange(new object[]
						{
							"All",
							"B",
							"S",
							"C",
							"H"
						});
					}
					else
					{
						this.tscbSide.Items.AddRange(new object[]
						{
							"All",
							"B",
							"S"
						});
					}
					if (ApplicationInfo.StockAutoComp != null)
					{
						this.cbStock.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
						this.cbStock.Items.Clear();
						this.cbStock.Items.AddRange(ApplicationInfo.StockAutoCompStringArr);
					}
				}
				else
				{
					this.tscbSide.Items.AddRange(new object[]
					{
						"All",
						"L",
						"S"
					});
					if (ApplicationInfo.SeriesAutoComp != null)
					{
						this.cbStock.AutoCompleteCustomSource = ApplicationInfo.SeriesAutoComp;
						this.cbStock.Items.Clear();
						this.cbStock.Items.AddRange(ApplicationInfo.SeriesAutoCompStringArr);
					}
				}
				this.btnType1.Visible = ApplicationInfo.IsAutoTradeSupport(1);
				this.btnType2.Visible = ApplicationInfo.IsAutoTradeSupport(2);
				this.btnType3.Visible = ApplicationInfo.IsAutoTradeSupport(32);
				this.btnType4.Visible = ApplicationInfo.IsAutoTradeSupport(64);
				this.btnTypeMM.Visible = ApplicationInfo.IsAutoTradeSupport(16);
				this.btnTypeDCA.Visible = ApplicationInfo.IsAutoTradeSupport(4);
				this.btnTypePZ.Visible = ApplicationInfo.IsAutoTradeSupport(8);
				this.lbPattern.Visible = true;
				if (ApplicationInfo.IsEquityAccount)
				{
					if (this._typeId == string.Empty)
					{
						this._typeId = "ALG1";
					}
					if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance)
					{
						this.btnType4.Visible = false;
						this.btnTypeDCA.Visible = false;
						this.btnTypePZ.Visible = false;
					}
				}
				else if (ApplicationInfo.IsSupportAutoTradeTFEX)
				{
					this.btnTypeDCA.Visible = false;
					this.btnTypePZ.Visible = false;
				}
				else
				{
					this._typeId = string.Empty;
					this.lbPattern.Visible = false;
					this.btnType1.Visible = false;
					this.btnType2.Visible = false;
					this.btnType3.Visible = false;
					this.btnType4.Visible = false;
					this.btnTypeMM.Visible = false;
					this.btnTypeDCA.Visible = false;
					this.btnTypePZ.Visible = false;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateSideByAcc", ex);
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00106EF4 File Offset: 0x001052F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetAutoTradeType(string newTypeId)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					AccountInfo.ItemInfo itemInfo;
					if (ApplicationInfo.AccInfo.Items.TryGetValue(ApplicationInfo.AccInfo.CurrentAccount, out itemInfo))
					{
						this._accType = itemInfo.AccountType;
					}
				}
				this._typeId = newTypeId;
				this.btnType1.BackColor = Color.Transparent;
				this.btnType2.BackColor = Color.Transparent;
				this.btnType3.BackColor = Color.Transparent;
				this.btnType4.BackColor = Color.Transparent;
				this.btnTypeDCA.BackColor = Color.Transparent;
				this.btnTypeMM.BackColor = Color.Transparent;
				this.btnTypePZ.BackColor = Color.Transparent;
				if (!this.btnTypePZ.Visible && this._typeId == "ALGPZ")
				{
					this._typeId = "ALG1";
				}
				if (!this.btnTypeDCA.Visible && this._typeId == "ALGDC")
				{
					this._typeId = "ALG1";
				}
				if (!this.btnType4.Visible && this._typeId == "ALGSF")
				{
					this._typeId = "ALG1";
				}
				this.panType1.Visible = (this._typeId == "ALG1" || this._typeId == "ALGSF" || this._typeId == "ALGTS");
				this.panType2.Visible = (this._typeId == "ALG2");
				this.panelDCA.Visible = (this._typeId == "ALGDC");
				this.panelPZ.Visible = (this._typeId == "ALGPZ");
				this.lbExpire.Hide();
				this.cbExpire.Hide();
				this.tbPin.Hide();
				this.lbPin.Hide();
				this.btnClear.Hide();
				this.btnSendOrder.Hide();
				this.btnBuy.Hide();
				this.btnSell.Hide();
				this.btnCover.Hide();
				this.btnShort.Hide();
				this.rdbTfexOpenPosition.Hide();
				this.rdbTfexClosePosition.Hide();
				this.lbStock.Hide();
				this.cbStock.Hide();
				this.lbSlipPage.Visible = false;
				this.tbSlipPage.Visible = false;
				if (ApplicationInfo.IsEquityAccount)
				{
					this.btnBuy.Text = "Buy";
					this.btnSell.Text = "Sell";
				}
				else
				{
					this.btnBuy.Text = "Long";
					this.btnSell.Text = "Short";
				}
				if (this._typeId == "ALG1" || this._typeId == "ALGTS" || this._typeId == "ALGSF")
				{
					if (this._typeId == "ALG1")
					{
						this.btnType1.BackColor = Color.DodgerBlue;
						this.lbStopOrderField.Text = "Simple Condition";
					}
					else if (this._typeId == "ALGTS")
					{
						this.btnType3.BackColor = Color.DodgerBlue;
						this.lbStopOrderField.Text = "Timing Stop Condition";
						this.cbTimingStop.Items.Clear();
						if (ApplicationInfo.IsEquityAccount)
						{
							this.cbTimingStop.Items.AddRange(new object[]
							{
								"12:20",
								"12:25",
								"16:20",
								"16:25"
							});
						}
						else
						{
							this.cbTimingStop.Items.AddRange(new object[]
							{
								"12:20",
								"12:25",
								"16:20",
								"16:25",
								"22:20",
								"22:25"
							});
						}
					}
					else if (this._typeId == "ALGSF")
					{
						this.btnType4.BackColor = Color.DodgerBlue;
						this.lbStopOrderField.Text = "SET Filter Condition";
					}
					this.intzaOrder.GetColumn("mm_src_ordno").Visible = false;
					this.cb1Condition.Items.Clear();
					if (this._typeId == "ALG1")
					{
						this.cb1Condition.Items.AddRange(new object[]
						{
							"Last >",
							"Last <",
							"Last > SMA(Day)",
							"Last < SMA(Day)",
							"Last > Break High (Day)",
							"Last < Break High (Day)",
							"Last > Break Low (Day)",
							"Last < Break Low (Day)",
							"Last < Discount High (Day)",
							"Last > Rebound Low (Day)"
						});
						this.cb1Price.Enabled = true;
					}
					else if (this._typeId == "ALGTS")
					{
						this.cb1Condition.Items.AddRange(new object[]
						{
							"Last >",
							"Last <"
						});
						this.cb1Price.Enabled = true;
					}
					else if (this._typeId == "ALGSF")
					{
						this.cb1Price.Text = "MP";
						this.cb1Price.Enabled = false;
						if (ApplicationInfo.IsEquityAccount)
						{
							this.cb1Condition.Items.AddRange(new object[]
							{
								"SET >",
								"SET <",
								"SET > SMA(Day)",
								"SET < SMA(Day)",
								"SET > Break High (Day)",
								"SET < Break High (Day)",
								"SET > Break Low (Day)",
								"SET < Break Low (Day)",
								"SET < Discount High (Day)",
								"SET > Rebound Low (Day)"
							});
						}
						else
						{
							this.cb1Condition.Items.AddRange(new object[]
							{
								"SET50 >",
								"SET50 <",
								"SET50 > SMA(Day)",
								"SET50 < SMA(Day)",
								"SET50 > Break High (Day)",
								"SET50 < Break High (Day)",
								"SET50 > Break Low (Day)",
								"SET50 < Break Low (Day)",
								"SET50 < Discount High (Day)",
								"SET50 > Rebound Low (Day)"
							});
						}
					}
					this.intzaOrder.GetColumn("tfex_position").Visible = !ApplicationInfo.IsEquityAccount;
					this.intzaOrder.GetColumn("group_cancel").Visible = false;
					this.panel1.Show();
					this.btnBuy.Show();
					this.btnSell.Show();
					if (ApplicationInfo.IsEquityAccount)
					{
						if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance && ApplicationInfo.SuuportSBL == "Y")
						{
							this.btnCover.Show();
							this.btnShort.Show();
						}
					}
					else
					{
						this.rdbTfexOpenPosition.Checked = false;
						this.rdbTfexClosePosition.Checked = false;
					}
					this.rdbTfexOpenPosition.Visible = !ApplicationInfo.IsEquityAccount;
					this.rdbTfexClosePosition.Visible = !ApplicationInfo.IsEquityAccount;
					this.lbStock.Show();
					this.cbStock.Show();
					this.btnClear.Show();
					this.btnSendOrder.Show();
					this.tbPin.Show();
					this.lbPin.Show();
					this.lbExpire.Show();
					this.cbExpire.Show();
					this.lbTimingStop.Visible = (this._typeId == "ALGTS");
					this.cbTimingStop.Visible = (this._typeId == "ALGTS");
					if (ApplicationInfo.IsEquityAccount)
					{
						if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance)
						{
							this.SetSide(this._ordSide);
						}
						else if (this._ordSide == "C" || this._ordSide == "H")
						{
							this.SetSide(string.Empty);
						}
						else
						{
							this.SetSide(this._ordSide);
						}
					}
					else if (this._ordSide == "L" || this._ordSide == "S")
					{
						this.SetSide(this._ordSide);
					}
					else
					{
						this.SetSide(string.Empty);
					}
					if (this._typeId == "ALGTS")
					{
						this.lbTimingStop.Left = 15;
						this.cbTimingStop.Left = this.lbTimingStop.Right + 5;
						this.cb1Condition.Left = this.cbTimingStop.Right + 10;
					}
					else
					{
						this.cb1Condition.Left = 15;
					}
					this.lb1Value.Left = this.cb1Condition.Right + 10;
					this.cb1Value.Left = this.lb1Value.Right + 8;
				}
				else if (this._typeId == "ALG2")
				{
					this.btnType2.BackColor = Color.DodgerBlue;
					this.intzaOrder.GetColumn("mm_src_ordno").Visible = false;
					this.intzaOrder.GetColumn("group_cancel").Visible = true;
					this.intzaOrder.GetColumn("tfex_position").Visible = !ApplicationInfo.IsEquityAccount;
					this.panel1.Show();
					this.btnSell.Show();
					this.rdbTfexClosePosition.Visible = !ApplicationInfo.IsEquityAccount;
					this.lbStock.Show();
					this.cbStock.Show();
					this.btnClear.Show();
					this.btnSendOrder.Show();
					this.tbPin.Show();
					this.lbPin.Show();
					this.lbExpire.Show();
					this.cbExpire.Show();
					if (ApplicationInfo.IsEquityAccount)
					{
						if (ApplicationInfo.AccInfo.IsCurrAccCreditBalance && ApplicationInfo.SuuportSBL == "Y")
						{
							this.btnCover.Show();
							if (this._ordSide == "C" || this._ordSide == "S")
							{
								this.SetSide(this._ordSide);
							}
							else
							{
								this.SetSide(string.Empty);
							}
						}
						else
						{
							this.SetSide("S");
						}
					}
					else
					{
						this.btnBuy.Show();
						this.rdbTfexClosePosition.Checked = true;
						if (this._ordSide == "L" || this._ordSide == "S")
						{
							this.SetSide(this._ordSide);
						}
						else
						{
							this.SetSide(string.Empty);
						}
					}
				}
				else if (this._typeId == "ALGDC")
				{
					this.btnTypeDCA.BackColor = Color.DodgerBlue;
					this.panel1.Hide();
				}
				else if (this._typeId == "ALGPZ")
				{
					this.btnTypePZ.BackColor = Color.DodgerBlue;
					this.panel1.Hide();
				}
				else if (this._typeId == "ALGMM")
				{
					this.btnTypeMM.BackColor = Color.DodgerBlue;
					this.intzaOrder.GetColumn("mm_src_ordno").Visible = true;
					this.panel1.Show();
				}
				this.SetResize(true, true);
				if (!ApplicationInfo.IsEquityAccount)
				{
					if (!ApplicationInfo.IsSupportAutoTradeTFEX)
					{
						this.panel1.Visible = false;
						return;
					}
				}
				this.ReloadData();
			}
			catch (Exception ex)
			{
				this.ShowError("SetType", ex);
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00107CCC File Offset: 0x001060CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSendOrder_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = this.cbStock.Text.Trim();
				StockList.StockInformation stockInformation = null;
				if (text == string.Empty)
				{
					this.ShowMessageBox("Invalid order symbol", frmOrderFormConfirm.OpenStyle.Error, this.cbStock);
				}
				else
				{
					bool flag;
					if (ApplicationInfo.IsEquityAccount)
					{
						stockInformation = ApplicationInfo.StockInfo[text];
						if (stockInformation.Number <= 0)
						{
							this.ShowMessageBox("Invalid order symbol", frmOrderFormConfirm.OpenStyle.Error, this.cbStock);
							return;
						}
						flag = true;
					}
					else
					{
						SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[text];
						if (seriesInformation.OrderBookId <= 0 || !seriesInformation.IsCanTrade)
						{
							this.ShowMessageBox("Invalid order symbol", frmOrderFormConfirm.OpenStyle.Error, this.cbStock);
							return;
						}
						flag = false;
					}
					if (this._ordSide == string.Empty)
					{
						this.ShowMessageBox("Invalid order side", frmOrderFormConfirm.OpenStyle.Error, null);
					}
					else if (this._typeId == "ALG1" || this._typeId == "ALGSF" || this._typeId == "ALGTS")
					{
						AutoTradeT1Command autoTradeT1Command = new AutoTradeT1Command();
						autoTradeT1Command.UserId = ApplicationInfo.UserLoginID;
						int operatorType = this.GetOperatorType(this.cb1Condition.Text);
						if (operatorType == -1)
						{
							this.ShowMessageBox("Invalid operator condition", frmOrderFormConfirm.OpenStyle.Error, this.cb1Condition);
						}
						else
						{
							string fieldType = this.GetFieldType(this.cb1Condition.Text);
							if (fieldType == string.Empty)
							{
								this.ShowMessageBox("Invalid order condition", frmOrderFormConfirm.OpenStyle.Error, this.cb1Condition);
							}
							else
							{
								decimal num = 0m;
								decimal.TryParse(this.cb1Value.Text, out num);
								if (num <= 0m)
								{
									this.ShowMessageBox("Invalid price condition", frmOrderFormConfirm.OpenStyle.Error, this.cb1Value);
								}
								else
								{
									decimal checkPrice;
									if (fieldType == "SMA" || fieldType == "HHV" || fieldType == "LLV" || fieldType == "DISH" || fieldType == "RBLOW")
									{
										if (!this.cb1Value.Items.Contains(num.ToString()))
										{
											this.ShowMessageBox("Invalid period condition", frmOrderFormConfirm.OpenStyle.Error, this.cb1Value);
											return;
										}
										checkPrice = -1m;
									}
									else
									{
										if (!this.IsValidPrice(this.cb1Value.Text, true, this.cb1Value))
										{
											return;
										}
										checkPrice = num;
									}
									string text2 = this.cb1Price.Text.Trim();
									if (this.IsValidPrice(text2, true, this.cb1Price))
									{
										string text3 = text2;
										if (text3 != null)
										{
											if (text3 == "MP")
											{
												if (this._ordSide == "H")
												{
													this.ShowMessageBox("MP doesn't support in Short!", frmOrderFormConfirm.OpenStyle.Error, this.cb1Value);
													return;
												}
												goto IL_49F;
											}
										}
										if (!(fieldType == "SMA") && !(fieldType == "HHV") && !(fieldType == "LLV") && !(fieldType == "DISH") && !(fieldType == "RBLOW"))
										{
											decimal d = 0m;
											decimal.TryParse(text2, out d);
											if (this._ordSide == "H")
											{
												if (d < num)
												{
													this.ShowMessageBox("Invalid short price. [Price >= Value]", frmOrderFormConfirm.OpenStyle.Error, this.cb1Price);
													return;
												}
											}
										}
										IL_49F:
										decimal num2 = 0m;
										if (fieldType == "DISH" || fieldType == "RBLOW")
										{
											if (!decimal.TryParse(this.tbSlipPage.Text, out num2))
											{
												this.ShowMessageBox("Invalid Slip Page [More than Zero]!", frmOrderFormConfirm.OpenStyle.Error, this.tbSlipPage);
												return;
											}
											if (!(num2 >= 0.01m) || !(num2 <= 99m))
											{
												this.ShowMessageBox("Invalid slip page! [0.01 - 99]", frmOrderFormConfirm.OpenStyle.Error, this.tb2SlipPage);
												return;
											}
										}
										string text4 = string.Empty;
										if (this._typeId == "ALGTS")
										{
											text4 = this.cbTimingStop.Text.Trim();
											if (text4 == string.Empty)
											{
												this.ShowMessageBox("Invalid Stop Time!", frmOrderFormConfirm.OpenStyle.Error, this.cbTimingStop);
												return;
											}
										}
										string tfexPosition = string.Empty;
										if (!ApplicationInfo.IsEquityAccount)
										{
											if (this.rdbTfexOpenPosition.Checked)
											{
												tfexPosition = "O";
											}
											else
											{
												if (!this.rdbTfexClosePosition.Checked)
												{
													this.ShowMessageBox("Invalid Position!", frmOrderFormConfirm.OpenStyle.Error, this.cbStock);
													return;
												}
												tfexPosition = "C";
											}
										}
										long num3 = 0L;
										long.TryParse(this.tb1Volume.Text.Replace(",", ""), out num3);
										if (num3 <= 0L)
										{
											this.ShowMessageBox("Invalid Volume [More than Zero]!", frmOrderFormConfirm.OpenStyle.Error, this.tb1Volume);
										}
										else
										{
											if (this.cbExpire.Text.ToLower().IndexOf("end") > -1)
											{
												autoTradeT1Command.ExpireDays = 1;
											}
											else if (this.cbExpire.Text.ToLower().IndexOf("30") > -1)
											{
												autoTradeT1Command.ExpireDays = 30;
											}
											else if (this.cbExpire.Text.ToLower().IndexOf("60") > -1)
											{
												autoTradeT1Command.ExpireDays = 60;
											}
											else if (this.cbExpire.Text.ToLower().IndexOf("90") > -1)
											{
												autoTradeT1Command.ExpireDays = 90;
											}
											else if (this.cbExpire.Text.ToLower().IndexOf("180") > -1)
											{
												autoTradeT1Command.ExpireDays = 180;
											}
											if (autoTradeT1Command.ExpireDays < 1)
											{
												this.ShowMessageBox("Invalid Expire!", frmOrderFormConfirm.OpenStyle.Error, this.cbExpire);
											}
											else
											{
												if (!flag)
												{
													if (this._ordSide == "B")
													{
														this._ordSide = "L";
													}
												}
												else if (this._ordSide == "H" && fieldType == "LAST" && operatorType == 4 && text2 != "MP")
												{
													decimal d2;
													decimal.TryParse(text2, out d2);
													decimal num4 = num - Utilities.GetNextSpreadDown(stockInformation, num);
													if (d2 < num4)
													{
														this.ShowMessageBox("Invalid short price, [ >= " + num4 + "]", frmOrderFormConfirm.OpenStyle.Error, this.cb1Price);
														return;
													}
												}
												autoTradeT1Command.Item = new AutoTradeItem(0L, 0, this._typeId, ApplicationInfo.UserLoginID, text, fieldType, operatorType, num, checkPrice, ApplicationInfo.AccInfo.CurrentAccount, this._ordSide, num3, text2, string.Empty, ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].PcFlag, "N", num2, text4.Replace(":", ""), flag, tfexPosition);
												this._commandMain = new AutoTradeMain();
												this._commandMain.Pack("T1", autoTradeT1Command);
												string text5 = string.Empty;
												if (this._typeId == "ALGSF")
												{
													text5 = text5 + "SET " + AutoTradeConstant.GetOperatorSymbol(operatorType) + " ";
												}
												else
												{
													text5 = "Last " + AutoTradeConstant.GetOperatorSymbol(operatorType) + " ";
												}
												if (fieldType == "SMA")
												{
													object obj = text5;
													text5 = string.Concat(new object[]
													{
														obj,
														"SMA (",
														num,
														")"
													});
												}
												else if (fieldType == "HHV")
												{
													object obj = text5;
													text5 = string.Concat(new object[]
													{
														obj,
														"Break High (",
														num,
														")"
													});
												}
												else if (fieldType == "LLV")
												{
													object obj = text5;
													text5 = string.Concat(new object[]
													{
														obj,
														"Break Low (",
														num,
														")"
													});
												}
												else if (fieldType == "DISH")
												{
													object obj = text5;
													text5 = string.Concat(new object[]
													{
														obj,
														"Discount High (",
														num,
														")"
													});
												}
												else if (fieldType == "RBLOW")
												{
													object obj = text5;
													text5 = string.Concat(new object[]
													{
														obj,
														"Rebound Low (",
														num,
														")"
													});
												}
												else
												{
													text5 += num;
												}
												string orderParam = string.Concat(new string[]
												{
													"Auto Trade :",
													" Account : ",
													ApplicationInfo.AccInfo.CurrentAccount,
													"\n",
													Utilities.GetOrderSideName(this._ordSide),
													"  ‘",
													text,
													"’",
													"  Volume ",
													FormatUtil.VolumeFormat(num3, true),
													"  Price ",
													text2,
													"\nCondition : ",
													text5
												});
												this.ShowOrderFormConfirm("Confirm to send?", orderParam, frmOrderFormConfirm.OpenStyle.ConfirmSendNew);
											}
										}
									}
								}
							}
						}
					}
					else if (this._typeId == "ALG2")
					{
						string isGroupRemove = this.chbGroupCancel.Checked ? "Y" : "N";
						long num3;
						long.TryParse(this.tb2Volume.Text.Trim().Replace(",", ""), out num3);
						List<AutoTradeItem> list = new List<AutoTradeItem>();
						AutoTradeT2Command autoTradeT2Command = new AutoTradeT2Command();
						autoTradeT2Command.UserId = ApplicationInfo.UserLoginID;
						autoTradeT2Command.Stock = text;
						autoTradeT2Command.Side = this._ordSide;
						if (this.cbExpire.Text.ToLower().IndexOf("end") > -1)
						{
							autoTradeT2Command.ExpireDays = 1;
						}
						else if (this.cbExpire.Text.ToLower().IndexOf("30") > -1)
						{
							autoTradeT2Command.ExpireDays = 30;
						}
						else if (this.cbExpire.Text.ToLower().IndexOf("60") > -1)
						{
							autoTradeT2Command.ExpireDays = 60;
						}
						else if (this.cbExpire.Text.ToLower().IndexOf("90") > -1)
						{
							autoTradeT2Command.ExpireDays = 90;
						}
						else if (this.cbExpire.Text.ToLower().IndexOf("180") > -1)
						{
							autoTradeT2Command.ExpireDays = 180;
						}
						string text6 = "";
						if (this._ordSide == string.Empty)
						{
							this.ShowMessageBox("Invalid order side", frmOrderFormConfirm.OpenStyle.Error, null);
						}
						else
						{
							string tfexPosition = string.Empty;
							if (!ApplicationInfo.IsEquityAccount)
							{
								if (this.rdbTfexOpenPosition.Checked)
								{
									tfexPosition = "O";
								}
								else
								{
									if (!this.rdbTfexClosePosition.Checked)
									{
										this.ShowMessageBox("Invalid Position!", frmOrderFormConfirm.OpenStyle.Error, this.cbStock);
										return;
									}
									tfexPosition = "C";
								}
							}
							if (this.chb2TakeProfitCond.Checked)
							{
								string fieldType = this.GetFieldType(this.cb2OperTakeProfit.Text);
								if (fieldType == string.Empty)
								{
									this.ShowMessageBox("Invalid condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2OperTakeProfit);
									return;
								}
								int operatorType = this.GetOperatorType(this.cb2OperTakeProfit.Text);
								if (operatorType == -1)
								{
									this.ShowMessageBox("Invalid operator condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2OperTakeProfit);
									return;
								}
								decimal num = 0m;
								decimal.TryParse(this.cb2ValueTakeProfit.Text, out num);
								if (num <= 0m)
								{
									this.ShowMessageBox("Invalid price condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2ValueTakeProfit);
									return;
								}
								if (fieldType == "SMA" || fieldType == "HHV" || fieldType == "LLV" || fieldType == "DISH" || fieldType == "RBLOW")
								{
									if (!this.cb2ValueTakeProfit.Items.Contains(num.ToString()))
									{
										this.ShowMessageBox("Invalid period condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2ValueTakeProfit);
										return;
									}
								}
								else if (!this.IsValidPrice(this.cb2ValueTakeProfit.Text, true, this.cb2ValueTakeProfit))
								{
									return;
								}
								string text2 = this.cb2PriceTakeProfit.Text.Trim();
								string text3 = text2;
								if (text3 != null)
								{
									if (text3 == "MP")
									{
										goto IL_1075;
									}
								}
								if (!this.IsValidPrice(text2, true, this.cb2PriceTakeProfit))
								{
									return;
								}
								IL_1075:
								AutoTradeItem item = new AutoTradeItem(0L, 1, "ALG2", ApplicationInfo.UserLoginID, text, "LAST", operatorType, num, num, ApplicationInfo.AccInfo.CurrentAccount, this._ordSide, num3, text2, string.Empty, ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].PcFlag, isGroupRemove, 0m, string.Empty, flag, tfexPosition);
								list.Add(item);
								text6 = string.Concat(new object[]
								{
									"Take Profit   : Last ",
									AutoTradeConstant.GetOperatorSymbol(operatorType),
									" ",
									num
								});
							}
							if (this.chb2TrailingStopCond.Checked)
							{
								int operatorType = this.GetOperatorType(this.cb2OperTrailingStop.Text);
								if (operatorType == -1)
								{
									this.ShowMessageBox("Invalid operator condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2OperTrailingStop);
									return;
								}
								string fieldType = this.GetFieldType(this.cb2OperTrailingStop.Text);
								if (fieldType == string.Empty)
								{
									this.ShowMessageBox("Invalid condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2OperTrailingStop);
									return;
								}
								decimal num2 = 0m;
								if (fieldType == "DISH" || fieldType == "RBLOW")
								{
									decimal.TryParse(this.tb2SlipPage.Text, out num2);
									if (!(num2 >= 0.01m) || !(num2 <= 99m))
									{
										this.ShowMessageBox("Invalid slip page! [0.01 - 99]", frmOrderFormConfirm.OpenStyle.Error, this.tb2SlipPage);
										return;
									}
								}
								decimal num = 0m;
								decimal.TryParse(this.cb2ValueTrailingStop.Text, out num);
								if (num <= 0m)
								{
									this.ShowMessageBox("Invalid price condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2ValueTrailingStop);
									return;
								}
								if (fieldType == "SMA" || fieldType == "HHV" || fieldType == "LLV" || fieldType == "DISH" || fieldType == "RBLOW")
								{
									if (!this.cb2ValueTrailingStop.Items.Contains(num.ToString()))
									{
										this.ShowMessageBox("Invalid period condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2ValueTrailingStop);
										return;
									}
								}
								else if (!this.IsValidPrice(this.cb2ValueTrailingStop.Text, true, this.cb2ValueTrailingStop))
								{
									return;
								}
								string text2 = this.cb2PriceTrailingStop.Text.Trim();
								string text3 = text2;
								if (text3 != null)
								{
									if (text3 == "MP")
									{
										goto IL_13C4;
									}
								}
								if (!this.IsValidPrice(text2, true, this.cb2PriceTrailingStop))
								{
									return;
								}
								IL_13C4:
								AutoTradeItem item2 = new AutoTradeItem(0L, 2, "ALG2", ApplicationInfo.UserLoginID, text, fieldType, operatorType, num, -1m, ApplicationInfo.AccInfo.CurrentAccount, this._ordSide, num3, text2, string.Empty, ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].PcFlag, isGroupRemove, num2, string.Empty, flag, tfexPosition);
								list.Add(item2);
								text6 = string.Concat(new object[]
								{
									text6,
									(text6 != string.Empty) ? "\n" : "",
									"Trailing Stop : ",
									this.cb2OperTrailingStop.Text,
									", Period(",
									num,
									")",
									(num2 > 0m) ? (" ,Slip page " + num2 + "%") : ""
								});
							}
							if (this.chb2CutLossCond.Checked)
							{
								int operatorType = this.GetOperatorType(this.cb2OperCutloss.Text);
								if (operatorType == -1)
								{
									this.ShowMessageBox("Invalid operator condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2OperCutloss);
									return;
								}
								string fieldType = this.GetFieldType(this.cb2OperCutloss.Text);
								if (fieldType == string.Empty)
								{
									this.ShowMessageBox("Invalid condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2OperCutloss);
									return;
								}
								decimal num = 0m;
								decimal.TryParse(this.cb2ValueCutloss.Text, out num);
								if (num <= 0m)
								{
									this.ShowMessageBox("Invalid price condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2ValueCutloss);
									return;
								}
								decimal checkPrice;
								if (fieldType == "SMA" || fieldType == "HHV" || fieldType == "LLV" || fieldType == "DISH" || fieldType == "RBLOW")
								{
									if (!this.cb2ValueCutloss.Items.Contains(num.ToString()))
									{
										this.ShowMessageBox("Invalid period condition", frmOrderFormConfirm.OpenStyle.Error, this.cb2ValueCutloss);
										return;
									}
									checkPrice = -1m;
								}
								else
								{
									if (!this.IsValidPrice(this.cb2ValueCutloss.Text, true, this.cb2ValueCutloss))
									{
										return;
									}
									checkPrice = num;
								}
								string text2 = this.cb2PriceCutLoss.Text.Trim();
								string text3 = text2;
								if (text3 != null)
								{
									if (text3 == "MP")
									{
										goto IL_16FA;
									}
								}
								if (!this.IsValidPrice(text2, true, this.cb2PriceCutLoss))
								{
									return;
								}
								IL_16FA:
								AutoTradeItem item3 = new AutoTradeItem(0L, 3, "ALG2", ApplicationInfo.UserLoginID, text, fieldType, operatorType, num, checkPrice, ApplicationInfo.AccInfo.CurrentAccount, this._ordSide, num3, text2, string.Empty, ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].PcFlag, isGroupRemove, 0m, string.Empty, flag, tfexPosition);
								list.Add(item3);
								text6 = text6 + ((text6 != string.Empty) ? "\n" : "") + ("Cut loss       : " + this.cb2OperCutloss.Text) + ((fieldType == "LAST") ? (" " + num) : (" Period(" + num + ")"));
							}
							if (autoTradeT2Command.ExpireDays < 1)
							{
								this.ShowMessageBox("Invalid Expire!", frmOrderFormConfirm.OpenStyle.Error, this.cbExpire);
							}
							else if (list.Count > 0)
							{
								if (num3 <= 0L)
								{
									this.ShowMessageBox("Invalid Volume [More than Zero]!", frmOrderFormConfirm.OpenStyle.Error, this.tb2Volume);
								}
								else
								{
									autoTradeT2Command.Items = list;
									this._commandMain = new AutoTradeMain();
									this._commandMain.Pack("T2", autoTradeT2Command);
									string orderParam = string.Concat(new string[]
									{
										"Auto Trade :",
										" Account : ",
										ApplicationInfo.AccInfo.CurrentAccount,
										"  ",
										Utilities.GetOrderSideName(this._ordSide),
										" : ‘",
										text,
										"’",
										"  Volume : ",
										FormatUtil.VolumeFormat(num3, true),
										"\nCondition : \n",
										text6
									});
									this.ShowOrderFormConfirm("Confirm to send?", orderParam, frmOrderFormConfirm.OpenStyle.ConfirmSendNew);
								}
							}
							else
							{
								this.ShowMessageBox("Can not create command Please check the terms!", frmOrderFormConfirm.OpenStyle.Error, null);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnSendOrder_Click", ex);
			}
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00109648 File Offset: 0x00107A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetFieldType(string indicatorName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			if (indicatorName.ToLower().IndexOf("sma") > -1)
			{
				result = "SMA";
			}
			else if (indicatorName.ToLower().IndexOf("break low") > -1)
			{
				result = "LLV";
			}
			else if (indicatorName.ToLower().IndexOf("break high") > -1)
			{
				result = "HHV";
			}
			else if (indicatorName.ToLower().IndexOf("discount") > -1)
			{
				result = "DISH";
			}
			else if (indicatorName.ToLower().IndexOf("rebound") > -1)
			{
				result = "RBLOW";
			}
			else if (indicatorName.ToLower().IndexOf("last") > -1 || indicatorName.ToLower().IndexOf("set") > -1 || indicatorName.ToLower().IndexOf("set50") > -1)
			{
				result = "LAST";
			}
			return result;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00109790 File Offset: 0x00107B90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetOperatorType(string operatorStr)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			int result = -1;
			if (operatorStr.IndexOf(">=") > 0)
			{
				result = 1;
			}
			else if (operatorStr.IndexOf("<=") > 0)
			{
				result = 2;
			}
			else if (operatorStr.IndexOf(">") > 0)
			{
				result = 3;
			}
			else if (operatorStr.IndexOf("<") > 0)
			{
				result = 4;
			}
			return result;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00109830 File Offset: 0x00107C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb1Condition_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetValueItems(this.cb1Value, this.lb1Value, this.cb1Condition.Text);
			this.SetResize(true, true);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00109868 File Offset: 0x00107C68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetValueItems(ComboBox control, Label label, string indicatorName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (indicatorName.ToLower().IndexOf("sma") > -1)
				{
					label.Text = "Period";
					control.Items.Clear();
					control.Text = string.Empty;
					for (int i = 1; i <= 200; i++)
					{
						if (i >= 1 && i <= 60)
						{
							control.Items.Add(i.ToString());
						}
						else if (i == 70 || i == 75 || i == 80 || i == 90 || i == 100 || i == 110 || i == 120 || i == 130 || i == 140 || i == 150 || i == 160 || i == 170 || i == 180 || i == 190 || i == 200)
						{
							control.Items.Add(i.ToString());
						}
					}
				}
				else if (indicatorName.ToLower().IndexOf("break") > -1 || indicatorName.ToLower().IndexOf("hhv") > -1 || indicatorName.ToLower().IndexOf("llv") > -1 || indicatorName.ToLower().IndexOf("discount") > -1 || indicatorName.ToLower().IndexOf("rebound") > -1)
				{
					label.Text = "Period";
					control.Items.Clear();
					control.Text = string.Empty;
					for (int i = 1; i <= 200; i++)
					{
						if (i >= 1 && i <= 60)
						{
							control.Items.Add(i.ToString());
						}
						else if (i == 70 || i == 75 || i == 80 || i == 90 || i == 100 || i == 110 || i == 120 || i == 130 || i == 140 || i == 150 || i == 160 || i == 170 || i == 180 || i == 190 || i == 200)
						{
							control.Items.Add(i.ToString());
						}
					}
				}
				else
				{
					label.Text = "Value";
					control.Items.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetValueItems", ex);
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00109BC8 File Offset: 0x00107FC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnBuy_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetSide(ApplicationInfo.IsEquityAccount ? "B" : "L");
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00109BFC File Offset: 0x00107FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSell_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetSide("S");
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00109C1C File Offset: 0x0010801C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCover_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetSide("C");
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00109C3C File Offset: 0x0010803C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnShort_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetSide("H");
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00109C5C File Offset: 0x0010805C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSide(string side)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._typeId == "ALG1" || this._typeId == "ALGTS" || this._typeId == "ALGSF")
				{
					Color foreColor = Color.White;
					this.btnBuy.Image = Resources.side_noside;
					this.btnSell.Image = Resources.side_noside;
					this.btnCover.Image = Resources.side_noside;
					this.btnShort.Image = Resources.side_noside;
					if (side == "B" || side == "L")
					{
						this.panType1.BackColor = Color.Green;
						this.btnBuy.Image = Resources.side_buy;
						this.cbStock.Focus();
					}
					else if (side == "S")
					{
						this.panType1.BackColor = Color.DarkRed;
						this.btnSell.Image = Resources.side_sell;
						this.cbStock.Focus();
					}
					else if (side == "C")
					{
						this.panType1.BackColor = Color.Turquoise;
						this.btnCover.Image = Resources.side_cover;
						foreColor = Color.Black;
					}
					else if (side == "H")
					{
						this.panType1.BackColor = Color.Pink;
						this.btnShort.Image = Resources.side_short;
						foreColor = Color.Black;
						if (this.cb1Price.Text == "MP")
						{
							this.cb1Price.Text = string.Empty;
						}
					}
					else
					{
						this.panType1.BackColor = Color.FromArgb(30, 30, 30);
					}
					this._ordSide = side;
					foreach (Control control in this.panType1.Controls)
					{
						if (control.GetType() == typeof(Label) || control.GetType() == typeof(GroupBox))
						{
							control.ForeColor = foreColor;
						}
					}
				}
				else if (this._typeId == "ALG2")
				{
					Color foreColor = Color.White;
					if (ApplicationInfo.IsEquityAccount)
					{
						this.btnSell.Image = Resources.side_noside;
						this.btnCover.Image = Resources.side_noside;
						this._ordSide = side;
						if (this._ordSide == "S")
						{
							this.panType2.BackColor = Color.DarkRed;
							this.btnSell.Image = Resources.side_sell;
							this.cbStock.Focus();
						}
						else if (this._ordSide == "C")
						{
							this.panType2.BackColor = Color.Turquoise;
							this.btnCover.Image = Resources.side_cover;
							foreColor = Color.Black;
							this.cbStock.Focus();
						}
						else
						{
							this.panType2.BackColor = Color.FromArgb(30, 30, 30);
							this.cbStock.Focus();
						}
					}
					else
					{
						this.btnBuy.Image = Resources.side_noside;
						this.btnSell.Image = Resources.side_noside;
						this._ordSide = side;
						if (side == "L")
						{
							this.panType2.BackColor = Color.Green;
							this.btnBuy.Image = Resources.side_buy;
							this.cbStock.Focus();
						}
						else if (side == "S")
						{
							this.panType2.BackColor = Color.DarkRed;
							this.btnSell.Image = Resources.side_sell;
							this.cbStock.Focus();
						}
						else
						{
							this.panType2.BackColor = Color.FromArgb(30, 30, 30);
						}
					}
					foreach (Control control in this.panType2.Controls)
					{
						if (control.GetType() == typeof(Label) || control.GetType() == typeof(CheckBox) || control.GetType() == typeof(GroupBox))
						{
							control.ForeColor = foreColor;
						}
					}
					this.SetType2Conditoin();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetSide", ex);
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0010A24C File Offset: 0x0010864C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetType2Conditoin()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.cb2OperTakeProfit.Items.Clear();
			this.cb2OperTrailingStop.Items.Clear();
			this.cb2OperCutloss.Items.Clear();
			if (ApplicationInfo.IsEquityAccount)
			{
				if (this._ordSide == "S")
				{
					this.cb2OperTakeProfit.Items.AddRange(new object[]
					{
						"Last >"
					});
					this.cb2OperTrailingStop.Items.AddRange(new object[]
					{
						"Last < SMA",
						"Last < Break Low",
						"Last < Discount High",
						"Last > Rebound Low "
					});
					this.cb2OperCutloss.Items.AddRange(new object[]
					{
						"Last <",
						"Last < Break Low"
					});
				}
				else if (this._ordSide == "C")
				{
					this.cb2OperTakeProfit.Items.AddRange(new object[]
					{
						"Last <"
					});
					this.cb2OperTrailingStop.Items.AddRange(new object[]
					{
						"Last > SMA",
						"Last > Break High",
						"Last > Rebound Low "
					});
					this.cb2OperCutloss.Items.AddRange(new object[]
					{
						"Last >",
						"Last > Break High"
					});
				}
			}
			else
			{
				this.cb2OperTakeProfit.Items.AddRange(new object[]
				{
					"Last >",
					"Last <"
				});
				this.cb2OperTrailingStop.Items.AddRange(new object[]
				{
					"Last < SMA",
					"Last > SMA",
					"Last < Break Low",
					"Last > Break High",
					"Last < Discount High",
					"Last > Rebound Low "
				});
				this.cb2OperCutloss.Items.AddRange(new object[]
				{
					"Last >",
					"Last <",
					"Last < Break Low",
					"Last > Break High"
				});
			}
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0010A49C File Offset: 0x0010889C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSendOrder_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.IsLoadingData = true;
			string result = string.Empty;
			try
			{
				result = ApplicationInfo.WebAlertService.SendAutoTrade(this._commandMain.ToMessage());
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSendOrder_DoWork", ex);
				result = ex.Message;
			}
			e.Result = result;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0010A518 File Offset: 0x00108918
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSendOrder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Error == null)
				{
					string data = e.Result.ToString();
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(data, dataSet);
						if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
						{
							if (dataSet.Tables["Results"].Rows[0]["message"].ToString() == "ok")
							{
								this.ReloadData();
								this.DoClear();
							}
							else
							{
								this.ReloadData();
								this.ShowMessageBox(dataSet.Tables["Results"].Rows[0]["message"].ToString(), frmOrderFormConfirm.OpenStyle.Error, null);
							}
						}
						dataSet.Clear();
					}
				}
				else
				{
					this.ShowMessageBox(e.Result.ToString(), frmOrderFormConfirm.OpenStyle.Error, null);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSendOrder_RunWorkerCompleted", ex);
			}
			base.IsLoadingData = false;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0010A6CC File Offset: 0x00108ACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageBox(string message, frmOrderFormConfirm.OpenStyle openStyle, Control lastFocusOjb)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmAutoTrade.ShowMessageBoxCallBack(this.ShowMessageBox), new object[]
				{
					message,
					openStyle,
					lastFocusOjb
				});
			}
			else
			{
				try
				{
					this._lastFocusOjb = lastFocusOjb;
					if (this._frmConfirm != null)
					{
						if (!this._frmConfirm.IsDisposed)
						{
							this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
							this._frmConfirm.Dispose();
						}
						this._frmConfirm = null;
					}
					this._frmConfirm = new frmOrderFormConfirm(message, openStyle);
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.Parent = this;
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

		// Token: 0x060013AE RID: 5038 RVA: 0x0010A888 File Offset: 0x00108C88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowOrderFormConfirm(string message, string orderParam, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmAutoTrade.ShowOrderFormConfirmCallBack(this.ShowOrderFormConfirm), new object[]
				{
					message,
					orderParam,
					openStyle
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
							this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
							this._frmConfirm.Dispose();
						}
						this._frmConfirm = null;
					}
					this._frmConfirm = new frmOrderFormConfirm(message, openStyle, this.tbPin.Text.Trim());
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.OssMessage = string.Empty;
					this._frmConfirm.StockThreshold = string.Empty;
					this._frmConfirm.OrderParam = orderParam;
					this._frmConfirm.Parent = this;
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

		// Token: 0x060013AF RID: 5039 RVA: 0x0010AA7C File Offset: 0x00108E7C
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
				if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmSendNew || openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmCancel)
				{
					DialogResult result = ((frmOrderFormConfirm)sender).Result;
					if (result == DialogResult.OK)
					{
						if (!this.bgwSendOrder.IsBusy)
						{
							this.bgwSendOrder.RunWorkerAsync();
						}
						else
						{
							this.ShowMessageBox("The system is not ready yet.", frmOrderFormConfirm.OpenStyle.Error, null);
						}
					}
					else
					{
						this.btnSendOrder.Enabled = true;
					}
				}
				else if (this._lastFocusOjb != null)
				{
					this._lastFocusOjb.Focus();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0010AB80 File Offset: 0x00108F80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSearch_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReloadData();
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0010AB98 File Offset: 0x00108F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbStock_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.End:
					case Keys.Home:
					case Keys.Left:
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_1BB;
					case Keys.Up:
						goto IL_1BB;
					case Keys.Right:
						break;
					default:
						goto IL_1BB;
					}
				}
				if (this.cbStock.Text.Trim() != string.Empty)
				{
					bool flag;
					if (ApplicationInfo.IsEquityAccount)
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbStock.Text.Trim()];
						flag = (stockInformation.Number > 0);
					}
					else
					{
						SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[this.cbStock.Text.Trim()];
						flag = (seriesInformation.OrderBookId > 0);
					}
					if (flag)
					{
						if (this._typeId == "ALG1" || this._typeId == "ALGSF")
						{
							this.cb1Condition.Focus();
						}
						else if (this._typeId == "ALG2")
						{
							this.cb2OperTakeProfit.Focus();
						}
						else if (this._typeId == "ALGTS")
						{
							this.cbTimingStop.Focus();
						}
					}
					else
					{
						this.cbStock.Focus();
						this.cbStock.SelectAll();
					}
				}
				e.SuppressKeyPress = true;
				IL_1BB:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbStock_KeyDown", ex);
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0010AD98 File Offset: 0x00109198
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbTimingStop_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.End:
					case Keys.Home:
						e.SuppressKeyPress = true;
						goto IL_80;
					case Keys.Left:
						this.cbStock.Focus();
						e.SuppressKeyPress = true;
						goto IL_80;
					case Keys.Up:
						goto IL_80;
					case Keys.Right:
						break;
					default:
						goto IL_80;
					}
				}
				this.cb1Condition.Focus();
				e.SuppressKeyPress = true;
				IL_80:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbTimingStop_KeyDown", ex);
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0010AE54 File Offset: 0x00109254
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb1Condition_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.End:
					case Keys.Home:
						e.SuppressKeyPress = true;
						goto IL_A6;
					case Keys.Left:
						if (this.cbTimingStop.Visible)
						{
							this.cbTimingStop.Focus();
						}
						else
						{
							this.cbStock.Focus();
						}
						e.SuppressKeyPress = true;
						goto IL_A6;
					case Keys.Up:
						goto IL_A6;
					case Keys.Right:
						break;
					default:
						goto IL_A6;
					}
				}
				this.cb1Value.Focus();
				e.SuppressKeyPress = true;
				IL_A6:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb1Condition_KeyDown", ex);
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0010AF34 File Offset: 0x00109334
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb1Value_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb1Condition.Focus();
						e.SuppressKeyPress = true;
						goto IL_E1;
					case Keys.Up:
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_E1;
					case Keys.Right:
						break;
					default:
						goto IL_E1;
					}
				}
				this.IsValidPrice(this.cb1Value.Text, true, this.cb1Value);
				if (this.tbSlipPage.Visible)
				{
					this.tbSlipPage.Focus();
				}
				else if (this.cb1Price.Enabled)
				{
					this.cb1Price.Focus();
				}
				else
				{
					this.tb1Volume.Focus();
				}
				e.SuppressKeyPress = true;
				IL_E1:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbPrice_KeyDown", ex);
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0010B050 File Offset: 0x00109450
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb1Price_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						if (this.tbSlipPage.Visible)
						{
							this.tbSlipPage.Focus();
						}
						else
						{
							this.cb1Value.Focus();
						}
						e.SuppressKeyPress = true;
						goto IL_168;
					case Keys.Up:
						if (this._typeId != "ALGSF")
						{
							this.cb1Price.Text = Utilities.PriceFormat(this.GetPrice(true, this.cb1Price.Text));
							this.cb1Price.SelectAll();
						}
						e.SuppressKeyPress = true;
						goto IL_168;
					case Keys.Right:
						break;
					case Keys.Down:
						if (this._typeId != "ALGSF")
						{
							this.cb1Price.Text = Utilities.PriceFormat(this.GetPrice(false, this.cb1Price.Text));
							this.cb1Price.SelectAll();
						}
						e.SuppressKeyPress = true;
						goto IL_168;
					default:
						goto IL_168;
					}
				}
				this.IsValidPrice(this.cb1Price.Text, true, this.cb1Price);
				this.tb1Volume.Focus();
				e.SuppressKeyPress = true;
				IL_168:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb1Price_KeyDown", ex);
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0010B200 File Offset: 0x00109600
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPrice_KeyPress(object sender, KeyPressEventArgs e)
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
				this.ShowError("cbStock_KeyPress", ex);
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0010B268 File Offset: 0x00109668
		[MethodImpl(MethodImplOptions.NoInlining)]
		private decimal GetPrice(bool isIncrease, string orgPrice)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal num = 0m;
			try
			{
				string stockSymbol = this.cbStock.Text.Trim().ToUpper();
				StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stockSymbol];
				if (stockInformation != null && stockInformation.Number > 0)
				{
					if (decimal.TryParse(orgPrice, out num))
					{
						if (isIncrease)
						{
							num += Utilities.GetNextSpreadUp(stockInformation, num);
							if (num > stockInformation.Ceiling)
							{
								num = stockInformation.Ceiling;
							}
						}
						else
						{
							num -= Utilities.GetNextSpreadDown(stockInformation, num);
							if (num < stockInformation.Floor)
							{
								num = stockInformation.Floor;
							}
						}
					}
					else if (num == 0m && stockInformation != null)
					{
						num = stockInformation.PriorPrice;
					}
				}
			}
			catch
			{
			}
			return num;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0010B3C0 File Offset: 0x001097C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsValidPrice(string price, bool IsShowMessage, Control control)
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
					if (price == "MP")
					{
						result = true;
						return result;
					}
				}
				if (!FormatUtil.Isnumeric(price))
				{
					if (IsShowMessage)
					{
						this.ShowMessageBox("Invalid price.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
					}
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
						if (ApplicationInfo.BrokerId != 11)
						{
							if (IsShowMessage)
							{
								this.ShowMessageBox("Invalid price format [2 digits]!.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
							}
							result = false;
							return result;
						}
					}
					else if (text.Length > 2)
					{
						if (IsShowMessage)
						{
							this.ShowMessageBox("Invalid price format [2 digits]!.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
						}
						result = false;
						return result;
					}
				}
				if (Convert.ToDecimal(price) <= 0m)
				{
					if (IsShowMessage)
					{
						this.ShowMessageBox("Invalid price [More than 0]!.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
					}
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

		// Token: 0x060013B9 RID: 5049 RVA: 0x0010B57C File Offset: 0x0010997C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tb1Volume_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tb1Volume.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tb1Volume.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tb1Volume.Text.Replace(",", ""));
							this.tb1Volume.Text = num.ToString("#,###");
							this.tb1Volume.Select(this.tb1Volume.Text.Length, 0);
						}
						catch
						{
							this.tb1Volume.Text = this.tb1Volume.Text.Substring(0, this.tb1Volume.Text.Length - 1);
						}
					}
					else
					{
						this.tb1Volume.Text = this.tb1Volume.Text.Substring(0, this.tb1Volume.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tb1Volume_TextChanged", ex);
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0010B6FC File Offset: 0x00109AFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tb1Volume_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						if (this.cb1Price.Enabled)
						{
							this.cb1Price.Focus();
						}
						else if (this.tbSlipPage.Visible)
						{
							this.tbSlipPage.Focus();
						}
						else
						{
							this.cb1Value.Focus();
						}
						e.SuppressKeyPress = true;
						break;
					case Keys.Up:
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbStock.Text.Trim()];
						if (stockInformation.Number > 0)
						{
							long num = 0L;
							long.TryParse(this.tb1Volume.Text.Replace(",", ""), out num);
							num += (long)stockInformation.BoardLot;
							this.tb1Volume.Text = Utilities.VolumeFormat(num, true);
							this.tb1Volume.SelectAll();
						}
						e.SuppressKeyPress = true;
						break;
					}
					case Keys.Right:
						if (this.tbSlipPage.Visible)
						{
							this.tbSlipPage.Focus();
						}
						else if (this.IsValidPrice(this.cb1Price.Text, false, null))
						{
							this.tb1Volume.Focus();
						}
						e.SuppressKeyPress = true;
						break;
					case Keys.Down:
					{
						StockList.StockInformation stockInformation2 = ApplicationInfo.StockInfo[this.cbStock.Text.Trim()];
						if (stockInformation2.Number > 0)
						{
							long num = 0L;
							long.TryParse(this.tb1Volume.Text.Replace(",", ""), out num);
							num -= (long)stockInformation2.BoardLot;
							if (num > 0L)
							{
								this.tb1Volume.Text = Utilities.VolumeFormat(num, true);
								this.tb1Volume.SelectAll();
							}
						}
						e.SuppressKeyPress = true;
						break;
					}
					}
				}
				else
				{
					if (this.IsValidPrice(this.cb1Price.Text, true, null))
					{
						if (this.tbPin.Text.Trim() == string.Empty)
						{
							this.tbPin.Focus();
						}
						else
						{
							this.btnSendOrder.PerformClick();
						}
					}
					e.SuppressKeyPress = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tb1Volume_KeyDown", ex);
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0010B9FC File Offset: 0x00109DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbSlipPage_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb1Value.Focus();
						e.SuppressKeyPress = true;
						goto IL_B8;
					case Keys.Up:
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_B8;
					case Keys.Right:
						break;
					default:
						goto IL_B8;
					}
				}
				if (this.cb1Price.Visible && this.cb1Price.Enabled)
				{
					this.cb1Price.Focus();
				}
				else
				{
					this.tb1Volume.Focus();
				}
				e.SuppressKeyPress = true;
				IL_B8:;
			}
			catch (Exception ex)
			{
				this.ShowError("tbSlipPage_KeyDown", ex);
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0010BAF0 File Offset: 0x00109EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tb2Volume_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tb2Volume.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tb2Volume.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tb2Volume.Text.Replace(",", ""));
							this.tb2Volume.Text = num.ToString("#,###");
							this.tb2Volume.Select(this.tb2Volume.Text.Length, 0);
						}
						catch
						{
							this.tb2Volume.Text = this.tb2Volume.Text.Substring(0, this.tb2Volume.Text.Length - 1);
						}
					}
					else
					{
						this.tb2Volume.Text = this.tb2Volume.Text.Substring(0, this.tb2Volume.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tb2Volume_TextChanged", ex);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0010BC70 File Offset: 0x0010A070
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tb2Volume_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb2PriceTakeProfit.Focus();
						e.SuppressKeyPress = true;
						break;
					case Keys.Up:
					{
						StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbStock.Text.Trim()];
						if (stockInformation.Number > 0)
						{
							long num = 0L;
							long.TryParse(this.tb2Volume.Text.Replace(",", ""), out num);
							num += (long)stockInformation.BoardLot;
							this.tb2Volume.Text = Utilities.VolumeFormat(num, true);
							this.tb2Volume.SelectAll();
						}
						e.SuppressKeyPress = true;
						break;
					}
					case Keys.Right:
						if (this.IsValidPrice(this.cb2PriceTakeProfit.Text, false, null))
						{
							this.cb2OperTrailingStop.Focus();
						}
						e.SuppressKeyPress = true;
						break;
					case Keys.Down:
					{
						StockList.StockInformation stockInformation2 = ApplicationInfo.StockInfo[this.cbStock.Text.Trim()];
						if (stockInformation2.Number > 0)
						{
							long num = 0L;
							long.TryParse(this.tb2Volume.Text.Replace(",", ""), out num);
							num -= (long)stockInformation2.BoardLot;
							if (num > 0L)
							{
								this.tb2Volume.Text = Utilities.VolumeFormat(num, true);
								this.tb2Volume.SelectAll();
							}
						}
						e.SuppressKeyPress = true;
						break;
					}
					}
				}
				else
				{
					if (this.tbPin.Text.Trim() == string.Empty)
					{
						this.tbPin.Focus();
					}
					else
					{
						this.btnSendOrder.PerformClick();
					}
					e.SuppressKeyPress = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tb2Volume_KeyDown", ex);
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0010BED8 File Offset: 0x0010A2D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2PriceLast_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb2ValueTakeProfit.Focus();
						e.SuppressKeyPress = true;
						goto IL_10A;
					case Keys.Up:
						this.cb2PriceTakeProfit.Text = Utilities.PriceFormat(this.GetPrice(true, this.cb2PriceTakeProfit.Text));
						this.cb2PriceTakeProfit.SelectAll();
						e.SuppressKeyPress = true;
						goto IL_10A;
					case Keys.Right:
						break;
					case Keys.Down:
						this.cb2PriceTakeProfit.Text = Utilities.PriceFormat(this.GetPrice(false, this.cb2PriceTakeProfit.Text));
						this.cb2PriceTakeProfit.SelectAll();
						e.SuppressKeyPress = true;
						goto IL_10A;
					default:
						goto IL_10A;
					}
				}
				this.IsValidPrice(this.cb2PriceTakeProfit.Text, true, this.cb2PriceTakeProfit);
				this.cb2OperTrailingStop.Focus();
				e.SuppressKeyPress = true;
				IL_10A:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb2PriceLast_KeyDown", ex);
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0010C028 File Offset: 0x0010A428
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnCancelOrder_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.intzaOrder.FocusItemIndex >= 0)
			{
				this.CallCancelOrder();
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0010C064 File Offset: 0x0010A464
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CallCancelOrder()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new MethodInvoker(this.CallCancelOrder));
			}
			else
			{
				try
				{
					AutoTradeCancelCommand autoTradeCancelCommand = new AutoTradeCancelCommand();
					autoTradeCancelCommand.UserId = ApplicationInfo.UserLoginID;
					autoTradeCancelCommand.CommandType = this._typeId;
					for (int i = 0; i < this.intzaOrder.Rows; i++)
					{
						if (this.intzaOrder.Records(i).Fields("checkbox").Text.ToString() == "1")
						{
							autoTradeCancelCommand.Items.Add(new AutoTradeCancelCommand.CancelItem(Convert.ToInt64(this.intzaOrder.Records(i).Fields("ref_no").Text), this.intzaOrder.Records(i).Fields("stock").Text.ToString()));
						}
					}
					if (autoTradeCancelCommand.Items.Count == 0 && this.intzaOrder.FocusItemIndex > -1)
					{
						RecordItem recordItem = this.intzaOrder.Records(this.intzaOrder.FocusItemIndex);
						if (recordItem.Fields("checkbox").Text.ToString() == "0")
						{
							autoTradeCancelCommand.Items.Add(new AutoTradeCancelCommand.CancelItem(Convert.ToInt64(recordItem.Fields("ref_no").Text), recordItem.Fields("stock").Text.ToString()));
						}
					}
					if (autoTradeCancelCommand.Items.Count > 0)
					{
						this._commandMain = new AutoTradeMain();
						this._commandMain.Pack("AX", autoTradeCancelCommand);
						this.ShowOrderFormConfirm("Do you want to cancel?", "", frmOrderFormConfirm.OpenStyle.ConfirmCancel);
					}
					else
					{
						this.ShowMessageBox("Can not find the item you want to cancel.", frmOrderFormConfirm.OpenStyle.ShowBox, null);
					}
				}
				catch (Exception ex)
				{
					this.ShowError("CallCancelOrder", ex);
				}
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0010C2C4 File Offset: 0x0010A6C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnClear_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.DoClear();
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0010C2DC File Offset: 0x0010A6DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoClear()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new MethodInvoker(this.DoClear));
			}
			else
			{
				try
				{
					this.btnSendOrder.Enabled = true;
					if (this._typeId == "ALG1" || this._typeId == "ALGSF" || this._typeId == "ALGTS")
					{
						this.cb1Condition.SelectedIndex = -1;
						this.cb1Value.Text = string.Empty;
						this.cb1Price.Text = "MP";
						this.tb1Volume.Text = string.Empty;
						this.cbExpire.Text = "180 Days";
						this.tbSlipPage.Text = string.Empty;
						this.cbTimingStop.SelectedIndex = -1;
					}
					else if (this._typeId == "ALG2")
					{
						this.chb2CutLossCond.Checked = false;
						this.chb2TakeProfitCond.Checked = false;
						this.chb2TrailingStopCond.Checked = false;
						this.cb2OperTakeProfit.SelectedIndex = -1;
						this.cb2OperTrailingStop.SelectedIndex = -1;
						this.cb2OperCutloss.SelectedIndex = -1;
						this.cb2ValueTakeProfit.Text = string.Empty;
						this.cb2ValueTrailingStop.Text = string.Empty;
						this.cb2ValueCutloss.Text = string.Empty;
						this.cb2PriceTakeProfit.Text = "MP";
						this.tb2Volume.Text = string.Empty;
						this.chbGroupCancel.Checked = true;
						this.cbExpire.Text = "180 Days";
						this.tb2SlipPage.Text = string.Empty;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("DoClear", ex);
				}
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0010C518 File Offset: 0x0010A918
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaOrder_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Mouse.Button == MouseButtons.Left)
				{
					if (e.RowIndex == -1)
					{
						string name = e.Column.Name;
						if (name != null)
						{
							if (!(name == "checkbox"))
							{
								if (name == "ref_no" || name == "side" || name == "stock")
								{
									if (this.intzaOrder.SortType == SortType.Asc)
									{
										this.intzaOrder.Sort(e.Column.Name, SortType.Desc);
									}
									else
									{
										this.intzaOrder.Sort(e.Column.Name, SortType.Asc);
									}
									this.intzaOrder.Redraw();
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("intzaOrderList_TableMouseClick", ex);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0010C658 File Offset: 0x0010AA58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void grid3_TableMouseDoubleClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1)
				{
					long refNo;
					long.TryParse(this.gridDcaMain.Records(e.RowIndex).Fields("refno").Text.ToString(), out refNo);
					if (this._frmDcaInfo != null)
					{
						if (!this._frmDcaInfo.IsDisposed)
						{
							this._frmDcaInfo.FormClosed -= new FormClosedEventHandler(this.frmDcaInfo_FormClosed);
							this._frmDcaInfo.Dispose();
						}
						this._frmPzInfo = null;
					}
					this._frmDcaInfo = new frmDcaItemsInfo(refNo);
					this._frmDcaInfo.FormClosed -= new FormClosedEventHandler(this.frmDcaInfo_FormClosed);
					this._frmDcaInfo.FormClosed += new FormClosedEventHandler(this.frmDcaInfo_FormClosed);
					this._frmDcaInfo.TopLevel = false;
					this._frmDcaInfo.Parent = this.panelDCA;
					this._frmDcaInfo.Bounds = new Rectangle(0, 0, this.panelDCA.Width, this.panelDCA.Height);
					this._frmDcaInfo.TopMost = true;
					this._frmDcaInfo.Show();
					this._frmDcaInfo.BringToFront();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("grid3_TableMouseDoubleClick", ex);
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0010C7EC File Offset: 0x0010ABEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmDcaInfo_FormClosed(object sender, FormClosedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._frmDcaInfo.DialogResult == DialogResult.OK)
			{
				this.ReloadData();
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0010C82C File Offset: 0x0010AC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnDcaCancel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.gridDcaMain.FocusItemIndex > -1 && AutoTradeConstant.GetStatusByName(this.gridDcaMain.Records(this.gridDcaMain.FocusItemIndex).Fields("status").Text.ToString(), this._typeId) == "ST")
				{
					RecordItem recordItem = this.gridDcaMain.Records(this.gridDcaMain.FocusItemIndex);
					long num;
					long.TryParse(recordItem.Fields("refno").Text.ToString(), out num);
					string text = recordItem.Fields("stock").Text.ToString();
					AutoTradeDCACommand autoTradeDCACommand = new AutoTradeDCACommand();
					autoTradeDCACommand.RefNo = num;
					autoTradeDCACommand.Symbol = text;
					autoTradeDCACommand.CommandType = "CANCEL";
					autoTradeDCACommand.Items = new List<AutoTradeDCAItem>();
					this._commandMain = new AutoTradeMain();
					this._commandMain.Pack("DCA", autoTradeDCACommand);
					string orderParam = string.Concat(new object[]
					{
						"Dolla Cost Average :",
						"Cancel DCA , Reference no ",
						num,
						"\nStock : ‘",
						text,
						"’"
					});
					this.ShowOrderFormConfirm("Do you want to cancel?\r\n", orderParam, frmOrderFormConfirm.OpenStyle.ConfirmCancel);
				}
				else
				{
					this.ShowMessageBox("Can not find the item you want to cancel.", frmOrderFormConfirm.OpenStyle.ShowBox, null);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btn3Cancel_Click", ex);
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0010C9E4 File Offset: 0x0010ADE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPin_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						if (this._typeId == "ALG1")
						{
							this.tb1Volume.Focus();
						}
						else if (this._typeId == "ALG2")
						{
							this.tb2Volume.Focus();
						}
						e.SuppressKeyPress = true;
						break;
					case Keys.Right:
						e.SuppressKeyPress = true;
						break;
					}
				}
				else
				{
					this.btnSendOrder.PerformClick();
					e.SuppressKeyPress = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbPin_KeyDown", ex);
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0010CADC File Offset: 0x0010AEDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmAutoTrade_IDoSymbolLinked(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (source == SymbolLinkSource.SwitchAccount)
			{
				this.UpdateSideByAcc();
				this.SetSide(string.Empty);
				this.SetAutoTradeType(this._typeId);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0010CB28 File Offset: 0x0010AF28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnDcaCreate_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._frmDcaCreateNew != null)
				{
					if (!this._frmDcaCreateNew.IsDisposed)
					{
						this._frmDcaCreateNew.FormClosing -= new FormClosingEventHandler(this.frmDcaCreateNew_FormClosing);
						this._frmDcaCreateNew.Dispose();
					}
					this._frmDcaCreateNew = null;
				}
				this._frmDcaCreateNew = new frmDcaCreateNew(this._holidays);
				this._frmDcaCreateNew.FormClosing -= new FormClosingEventHandler(this.frmDcaCreateNew_FormClosing);
				this._frmDcaCreateNew.FormClosing += new FormClosingEventHandler(this.frmDcaCreateNew_FormClosing);
				this._frmDcaCreateNew.TopLevel = false;
				this._frmDcaCreateNew.Parent = this.panelDCA;
				this._frmDcaCreateNew.Bounds = new Rectangle(0, 0, this.panelDCA.Width, this.panelDCA.Height);
				this._frmDcaCreateNew.TopMost = true;
				this._frmDcaCreateNew.Show();
				this._frmDcaCreateNew.BringToFront();
			}
			catch (Exception ex)
			{
				this.ShowError("btnDcaCreate_Click", ex);
			}
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0010CC7C File Offset: 0x0010B07C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmDcaCreateNew_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._frmDcaCreateNew.DialogResult == DialogResult.OK)
				{
					this.ReloadData();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmPzCreateNew_FormClosing", ex);
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0010CCE8 File Offset: 0x0010B0E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPzCancel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.gridPzMain.FocusItemIndex > -1 && AutoTradeConstant.GetStatusByName(this.gridPzMain.Records(this.gridPzMain.FocusItemIndex).Fields("status").Text.ToString(), this._typeId) == "ST")
				{
					RecordItem recordItem = this.gridPzMain.Records(this.gridPzMain.FocusItemIndex);
					long num;
					long.TryParse(recordItem.Fields("refno").Text.ToString(), out num);
					string text = recordItem.Fields("stock").Text.ToString();
					AutoTradePzCommand autoTradePzCommand = new AutoTradePzCommand();
					autoTradePzCommand.RefNo = num;
					autoTradePzCommand.Symbol = text;
					autoTradePzCommand.CommandType = "CANCEL";
					autoTradePzCommand.Items = new List<AutoTradePzItem>();
					this._commandMain = new AutoTradeMain();
					this._commandMain.Pack("PZ", autoTradePzCommand);
					string orderParam = string.Concat(new object[]
					{
						"Pricing Zone :",
						"Cancel Pricing Zone , Reference no ",
						num,
						"\nStock : ‘",
						text,
						"’"
					});
					this.ShowOrderFormConfirm("Do you want to cancel?\r\n", orderParam, frmOrderFormConfirm.OpenStyle.ConfirmCancel);
				}
				else
				{
					this.ShowMessageBox("Can not find the item you want to cancel.", frmOrderFormConfirm.OpenStyle.ShowBox, null);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btn3Cancel_Click", ex);
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0010CEA0 File Offset: 0x0010B2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPzReload_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReloadData();
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0010CEB8 File Offset: 0x0010B2B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void gridPzMain_TableMouseDoubleClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1)
				{
					long refNo;
					long.TryParse(this.gridPzMain.Records(e.RowIndex).Fields("refno").Text.ToString(), out refNo);
					if (this._frmPzInfo != null)
					{
						if (!this._frmPzInfo.IsDisposed)
						{
							this._frmPzInfo.FormClosed -= new FormClosedEventHandler(this.frmPzInfo_FormClosed);
							this._frmPzInfo.Dispose();
						}
						this._frmPzInfo = null;
					}
					this._frmPzInfo = new frmPzItemsInfo(refNo, this.gridPzMain.Records(e.RowIndex).Fields("stock").Text.ToString());
					this._frmPzInfo.FormClosed -= new FormClosedEventHandler(this.frmPzInfo_FormClosed);
					this._frmPzInfo.FormClosed += new FormClosedEventHandler(this.frmPzInfo_FormClosed);
					this._frmPzInfo.TopLevel = false;
					this._frmPzInfo.Parent = this.panelPZ;
					this._frmPzInfo.Bounds = new Rectangle(0, 0, this.panelPZ.Width, this.panelPZ.Height);
					this._frmPzInfo.TopMost = true;
					this._frmPzInfo.Show();
					this._frmPzInfo.BringToFront();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("grid3_TableMouseDoubleClick", ex);
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0010D070 File Offset: 0x0010B470
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPzInfo_FormClosed(object sender, FormClosedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReloadData();
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0010D088 File Offset: 0x0010B488
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2OperTrailingStop_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetValueItems(this.cb2ValueTrailingStop, this.lb2ValueTrailingStop, this.cb2OperTrailingStop.Text);
			this.SetResize(true, true);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0010D0C0 File Offset: 0x0010B4C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2OperTakeProfit_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetValueItems(this.cb2ValueTakeProfit, this.lb2ValueTakeProfit, this.cb2OperTakeProfit.Text);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0010D0F0 File Offset: 0x0010B4F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2OperCutloss_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetValueItems(this.cb2ValueCutloss, this.lb2ValueCutloss, this.cb2OperCutloss.Text);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0010D120 File Offset: 0x0010B520
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPzCreateNew_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._frmPzCreateNew != null)
				{
					if (!this._frmPzCreateNew.IsDisposed)
					{
						this._frmPzCreateNew.FormClosing -= new FormClosingEventHandler(this.frmPzCreateNew_FormClosing);
						this._frmPzCreateNew.Dispose();
					}
					this._frmPzCreateNew = null;
				}
				this._frmPzCreateNew = new frmPzCreateNew();
				this._frmPzCreateNew.FormClosing -= new FormClosingEventHandler(this.frmPzCreateNew_FormClosing);
				this._frmPzCreateNew.FormClosing += new FormClosingEventHandler(this.frmPzCreateNew_FormClosing);
				this._frmPzCreateNew.TopLevel = false;
				this._frmPzCreateNew.Parent = this.panelPZ;
				this._frmPzCreateNew.Bounds = new Rectangle(0, 0, this.panelPZ.Width, this.panelPZ.Height);
				this._frmPzCreateNew.TopMost = true;
				this._frmPzCreateNew.Show();
				this._frmPzCreateNew.BringToFront();
			}
			catch (Exception ex)
			{
				this.ShowError("btnPzCreateNew_Click", ex);
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0010D270 File Offset: 0x0010B670
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPzCreateNew_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._frmPzCreateNew.DialogResult == DialogResult.OK)
				{
					this.ReloadData();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmPzCreateNew_FormClosing", ex);
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0010D2DC File Offset: 0x0010B6DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnDcaReload_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ReloadData();
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0010D2F4 File Offset: 0x0010B6F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnClearCondition_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.tscbStatus.Text = "ALL";
				this.tscbSide.Text = "ALL";
				this.tstbStock.Clear();
				this.ReloadData();
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnClearCondition_Click", ex);
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0010D374 File Offset: 0x0010B774
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tstbStock_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return)
			{
				this.ReloadData();
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0010D3B0 File Offset: 0x0010B7B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2ValueTakeProfit_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb2OperTakeProfit.Focus();
						e.SuppressKeyPress = true;
						goto IL_C8;
					case Keys.Up:
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_C8;
					case Keys.Right:
						break;
					default:
						goto IL_C8;
					}
				}
				if (this.cb2ValueTakeProfit.Text != string.Empty && this.cb2OperTakeProfit.Text != string.Empty)
				{
					this.chb2TakeProfitCond.Checked = true;
				}
				this.cb2PriceTakeProfit.Focus();
				e.SuppressKeyPress = true;
				IL_C8:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb2ValueTakeProfit_KeyDown", ex);
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0010D4B4 File Offset: 0x0010B8B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2ValueTrailingStop_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb2OperTrailingStop.Focus();
						e.SuppressKeyPress = true;
						goto IL_EE;
					case Keys.Up:
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_EE;
					case Keys.Right:
						break;
					default:
						goto IL_EE;
					}
				}
				if (this.cb2ValueTrailingStop.Text != string.Empty && this.cb2OperTrailingStop.Text != string.Empty)
				{
					this.chb2TrailingStopCond.Checked = true;
				}
				if (this.tb2SlipPage.Visible)
				{
					this.tb2SlipPage.Focus();
				}
				else
				{
					this.cb2OperCutloss.Focus();
				}
				e.SuppressKeyPress = true;
				IL_EE:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb2ValueTrailingStop_KeyDown", ex);
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0010D5DC File Offset: 0x0010B9DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2ValueCutloss_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb2OperCutloss.Focus();
						e.SuppressKeyPress = true;
						goto IL_C8;
					case Keys.Up:
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_C8;
					case Keys.Right:
						break;
					default:
						goto IL_C8;
					}
				}
				if (this.cb2ValueCutloss.Text != string.Empty && this.cb2OperCutloss.Text != string.Empty)
				{
					this.chb2CutLossCond.Checked = true;
				}
				this.tb2Volume.Focus();
				e.SuppressKeyPress = true;
				IL_C8:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb2ValueCutloss_KeyDown", ex);
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0010D6E0 File Offset: 0x0010BAE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2OperTakeProfit_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cbStock.Focus();
						e.SuppressKeyPress = true;
						goto IL_74;
					case Keys.Up:
					case Keys.Down:
						goto IL_74;
					case Keys.Right:
						break;
					default:
						goto IL_74;
					}
				}
				this.cb2ValueTakeProfit.Focus();
				e.SuppressKeyPress = true;
				IL_74:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb2OperTakeProfit_KeyDown", ex);
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0010D790 File Offset: 0x0010BB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2OperTrailingStop_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.tb2Volume.Focus();
						e.SuppressKeyPress = true;
						goto IL_74;
					case Keys.Up:
					case Keys.Down:
						goto IL_74;
					case Keys.Right:
						break;
					default:
						goto IL_74;
					}
				}
				this.cb2ValueTrailingStop.Focus();
				e.SuppressKeyPress = true;
				IL_74:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb2OperTrailingStop_KeyDown", ex);
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0010D840 File Offset: 0x0010BC40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cb2OperCutloss_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb2ValueTrailingStop.Focus();
						e.SuppressKeyPress = true;
						goto IL_74;
					case Keys.Up:
					case Keys.Down:
						goto IL_74;
					case Keys.Right:
						break;
					default:
						goto IL_74;
					}
				}
				this.cb2ValueCutloss.Focus();
				e.SuppressKeyPress = true;
				IL_74:;
			}
			catch (Exception ex)
			{
				this.ShowError("cb2OperCutloss_KeyDown", ex);
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0010D8F0 File Offset: 0x0010BCF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsLoadingData)
			{
				this.tsbtnSearch.PerformClick();
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0010D928 File Offset: 0x0010BD28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tb2SlipPage_KeyDown(object sender, KeyEventArgs e)
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
					switch (keyCode)
					{
					case Keys.Left:
						this.cb2ValueTrailingStop.Focus();
						e.SuppressKeyPress = true;
						goto IL_9E;
					case Keys.Up:
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_9E;
					case Keys.Right:
						break;
					default:
						goto IL_9E;
					}
				}
				if (this.IsValidPrice(this.tb2SlipPage.Text, true, this.tb2SlipPage))
				{
					this.cb2OperCutloss.Focus();
				}
				e.SuppressKeyPress = true;
				IL_9E:;
			}
			catch (Exception ex)
			{
				this.ShowError("tb2SlipPage_KeyDown", ex);
			}
		}

		// Token: 0x04000A04 RID: 2564
		private IContainer components;

		// Token: 0x04000A05 RID: 2565
		private Panel panType1;

		// Token: 0x04000A06 RID: 2566
		private Label lb1Value;

		// Token: 0x04000A07 RID: 2567
		private ComboBox cb1Value;

		// Token: 0x04000A08 RID: 2568
		private Label lbStopOrderField;

		// Token: 0x04000A09 RID: 2569
		private ComboBox cbStock;

		// Token: 0x04000A0A RID: 2570
		private Label lbStock;

		// Token: 0x04000A0B RID: 2571
		private Label lbPin;

		// Token: 0x04000A0C RID: 2572
		private TextBox tbPin;

		// Token: 0x04000A0D RID: 2573
		private Label lbPrice;

		// Token: 0x04000A0E RID: 2574
		private Label lb1Volume;

		// Token: 0x04000A0F RID: 2575
		private TextBox tb1Volume;

		// Token: 0x04000A10 RID: 2576
		private Label lbPattern;

		// Token: 0x04000A11 RID: 2577
		private Panel panelTop;

		// Token: 0x04000A12 RID: 2578
		private ToolStrip tStripMenu;

		// Token: 0x04000A13 RID: 2579
		private ToolStripLabel tslbStatus;

		// Token: 0x04000A14 RID: 2580
		private ToolStripComboBox tscbStatus;

		// Token: 0x04000A15 RID: 2581
		private ToolStripLabel tslbStock;

		// Token: 0x04000A16 RID: 2582
		private ToolStripTextBox tstbStock;

		// Token: 0x04000A17 RID: 2583
		private ToolStripLabel tslbSide;

		// Token: 0x04000A18 RID: 2584
		private ToolStripComboBox tscbSide;

		// Token: 0x04000A19 RID: 2585
		private ToolStripButton tsbtnClearCondition;

		// Token: 0x04000A1A RID: 2586
		private ToolStripButton tsbtnCancelOrder;

		// Token: 0x04000A1B RID: 2587
		private ToolStripButton tsbtnSearch;

		// Token: 0x04000A1C RID: 2588
		private ComboBox cb1Price;

		// Token: 0x04000A1D RID: 2589
		private Button btnClear;

		// Token: 0x04000A1E RID: 2590
		private Button btnSendOrder;

		// Token: 0x04000A1F RID: 2591
		private Button btnType2;

		// Token: 0x04000A20 RID: 2592
		private Button btnType1;

		// Token: 0x04000A21 RID: 2593
		private Button btnSell;

		// Token: 0x04000A22 RID: 2594
		private Button btnBuy;

		// Token: 0x04000A23 RID: 2595
		private Panel panType2;

		// Token: 0x04000A24 RID: 2596
		private ComboBox cb2OperCutloss;

		// Token: 0x04000A25 RID: 2597
		private ComboBox cb2OperTrailingStop;

		// Token: 0x04000A26 RID: 2598
		private ComboBox cb2OperTakeProfit;

		// Token: 0x04000A27 RID: 2599
		private CheckBox chb2CutLossCond;

		// Token: 0x04000A28 RID: 2600
		private CheckBox chb2TrailingStopCond;

		// Token: 0x04000A29 RID: 2601
		private CheckBox chb2TakeProfitCond;

		// Token: 0x04000A2A RID: 2602
		private Label lb2ValueTakeProfit;

		// Token: 0x04000A2B RID: 2603
		private ComboBox cb2ValueTakeProfit;

		// Token: 0x04000A2C RID: 2604
		private ComboBox cb2PriceTakeProfit;

		// Token: 0x04000A2D RID: 2605
		private CheckBox chbGroupCancel;

		// Token: 0x04000A2E RID: 2606
		private Label lb2Volume;

		// Token: 0x04000A2F RID: 2607
		private TextBox tb2Volume;

		// Token: 0x04000A30 RID: 2608
		private Label lb2PriceTakeProfit;

		// Token: 0x04000A31 RID: 2609
		private Label lb2ValueCutloss;

		// Token: 0x04000A32 RID: 2610
		private ComboBox cb2ValueCutloss;

		// Token: 0x04000A33 RID: 2611
		private ComboBox cb2PriceCutLoss;

		// Token: 0x04000A34 RID: 2612
		private Label lb2PriceCutLoss;

		// Token: 0x04000A35 RID: 2613
		private Label lb2ValueTrailingStop;

		// Token: 0x04000A36 RID: 2614
		private ComboBox cb2ValueTrailingStop;

		// Token: 0x04000A37 RID: 2615
		private ComboBox cb2PriceTrailingStop;

		// Token: 0x04000A38 RID: 2616
		private Label lb2PriceTrailingStop;

		// Token: 0x04000A39 RID: 2617
		private Label lbGrpCondLabel;

		// Token: 0x04000A3A RID: 2618
		private ComboBox cb1Condition;

		// Token: 0x04000A3B RID: 2619
		private Button btnTypeMM;

		// Token: 0x04000A3C RID: 2620
		private Panel panel1;

		// Token: 0x04000A3D RID: 2621
		private ExpandGrid intzaOrder;

		// Token: 0x04000A3E RID: 2622
		private Panel panelDCA;

		// Token: 0x04000A3F RID: 2623
		private ExpandGrid gridDcaMain;

		// Token: 0x04000A40 RID: 2624
		private Button btn3Cancel;

		// Token: 0x04000A41 RID: 2625
		private Button btnDcaReload;

		// Token: 0x04000A42 RID: 2626
		private Button btnTypeDCA;

		// Token: 0x04000A43 RID: 2627
		private ToolTip toolTip1;

		// Token: 0x04000A44 RID: 2628
		private Button btnDcaCreate;

		// Token: 0x04000A45 RID: 2629
		private Panel panelPZ;

		// Token: 0x04000A46 RID: 2630
		private Button btnPzCreateNew;

		// Token: 0x04000A47 RID: 2631
		private Button btnPzCancel;

		// Token: 0x04000A48 RID: 2632
		private Button btnPzReload;

		// Token: 0x04000A49 RID: 2633
		private ExpandGrid gridPzMain;

		// Token: 0x04000A4A RID: 2634
		private Button btnTypePZ;

		// Token: 0x04000A4B RID: 2635
		private ComboBox cbExpire;

		// Token: 0x04000A4C RID: 2636
		private Label lbExpire;

		// Token: 0x04000A4D RID: 2637
		private Label lbSlipPage;

		// Token: 0x04000A4E RID: 2638
		private TextBox tbSlipPage;

		// Token: 0x04000A4F RID: 2639
		private Button btnType4;

		// Token: 0x04000A50 RID: 2640
		private Button btnType3;

		// Token: 0x04000A51 RID: 2641
		private Label lbTimingStop;

		// Token: 0x04000A52 RID: 2642
		private ComboBox cbTimingStop;

		// Token: 0x04000A53 RID: 2643
		private Label lb2SlipPage;

		// Token: 0x04000A54 RID: 2644
		private TextBox tb2SlipPage;

		// Token: 0x04000A55 RID: 2645
		private RadioButton rdbTfexClosePosition;

		// Token: 0x04000A56 RID: 2646
		private RadioButton rdbTfexOpenPosition;

		// Token: 0x04000A57 RID: 2647
		private Button btnCover;

		// Token: 0x04000A58 RID: 2648
		private Button btnShort;

		// Token: 0x04000A59 RID: 2649
		private GroupBox panel2OrderVal;

		// Token: 0x04000A5A RID: 2650
		private GroupBox panel1OrderVal;

		// Token: 0x04000A5B RID: 2651
		private ToolStripLabel tslbMode;

		// Token: 0x04000A5C RID: 2652
		private ToolStripComboBox tsbtnMode;

		// Token: 0x04000A5D RID: 2653
		private string _typeId;

		// Token: 0x04000A5E RID: 2654
		private string _ordSide;

		// Token: 0x04000A5F RID: 2655
		private BackgroundWorker bgwSendOrder;

		// Token: 0x04000A60 RID: 2656
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x04000A61 RID: 2657
		private List<string> _holidays;

		// Token: 0x04000A62 RID: 2658
		private bool _isReloadData;

		// Token: 0x04000A63 RID: 2659
		private AutoTradeMain _commandMain;

		// Token: 0x04000A64 RID: 2660
		private frmDcaItemsInfo _frmDcaInfo;

		// Token: 0x04000A65 RID: 2661
		private frmDcaCreateNew _frmDcaCreateNew;

		// Token: 0x04000A66 RID: 2662
		private frmPzItemsInfo _frmPzInfo;

		// Token: 0x04000A67 RID: 2663
		private frmPzCreateNew _frmPzCreateNew;

		// Token: 0x04000A68 RID: 2664
		private string _accType;

		// Token: 0x04000A69 RID: 2665
		private Control _lastFocusOjb;

		// Token: 0x02000223 RID: 547
		// (Invoke) Token: 0x060013E0 RID: 5088
		private delegate void ShowMessageBoxCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle, Control lastFocusOjb);

		// Token: 0x02000224 RID: 548
		// (Invoke) Token: 0x060013E4 RID: 5092
		private delegate void ShowOrderFormConfirmCallBack(string message, string orderParam, frmOrderFormConfirm.OpenStyle openStyle);
	}
}
