using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Controls;
using i2TradePlus.Information;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.Properties;
using i2TradePlus.Templates;
using i2TradePlus.WindowsForms;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.AutoTradeMessage;
using ITSNet.Common.BIZ.RealtimeMessage;
using STIControl;

namespace i2TradePlus
{
	// Token: 0x020000FA RID: 250
	internal class ucSendNewOrder : UserControl, IRealtimeMessage
	{
		// Token: 0x06000BCD RID: 3021 RVA: 0x000D2430 File Offset: 0x000D0830
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

		// Token: 0x06000BCE RID: 3022 RVA: 0x000D2480 File Offset: 0x000D0880
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ucSendNewOrder));
			this.lbPrice = new Label();
			this.lbVolume = new Label();
			this.tbVolume = new TextBox();
			this.lbPublic = new Label();
			this.lbCondition = new Label();
			this.tbPublic = new TextBox();
			this.chbNVDR = new CheckBox();
			this.panelTop = new Panel();
			this.btnStyleMM = new Button();
			this.cbAccount = new ComboBox();
			this.lbBuyLimit = new Label();
			this.btnNotification = new Button();
			this.tbEquity = new Label();
			this.btnShowStockAlert = new Button();
			this.tbBuyLimit = new Label();
			this.btnRisk = new Button();
			this.btnStyle4 = new Button();
			this.lbEquity = new Label();
			this.btnStyle3 = new Button();
			this.lbAccount = new Label();
			this.btnCleanPort = new Button();
			this.lbOnHand = new Label();
			this.btnSetting = new Button();
			this.tbOnHand = new Label();
			this.btnStyle2 = new Button();
			this.btnStyle1 = new Button();
			this.lbLoading = new Label();
			this.btnSendOrder = new Button();
			this.cbCondition = new ComboBox();
			this.panelEquity = new Panel();
			this.cbDepCollateral = new ComboBox();
			this.lbDep = new Label();
			this.cbStock = new ComboBox();
			this.lbStock = new Label();
			this.lbSide = new Label();
			this.cbSide = new ComboBox();
			this.btnPriceDec = new Button();
			this.btnPriceInc = new Button();
			this.btnPBDec = new Button();
			this.btnPBInc = new Button();
			this.btnVolDec = new Button();
			this.btnVolInc = new Button();
			this.btnClear = new Button();
			this.lbPin = new Label();
			this.tbPin = new TextBox();
			this.rbCover = new RadioButton();
			this.rbShort = new RadioButton();
			this.rbSell = new RadioButton();
			this.rbBuy = new RadioButton();
			this.cbPrice = new ComboBox();
			this.tbTimes = new TextBox();
			this.lbTimes = new Label();
			this.toolTip1 = new ToolTip(this.components);
			this.panelDerivative = new Panel();
			this.panelTfexPosition = new Panel();
			this.rdbTfexClosePos = new RadioButton();
			this.rdbTfexOpenPos = new RadioButton();
			this.cbPosition = new ComboBox();
			this.rdbTfexSell = new RadioButton();
			this.rdbTfexBuy = new RadioButton();
			this.tbTfexPriceCondition = new TextBox();
			this.cbTfexConStopOrder = new ComboBox();
			this.tbPriceT = new TextBox();
			this.tbSeriesCondition = new TextBox();
			this.tbSeries = new TextBox();
			this.chbTfexStopOrder = new CheckBox();
			this.tbPublishT = new TextBox();
			this.lbValidityT = new Label();
			this.tbVolumeT = new TextBox();
			this.lbPriceTypeT = new Label();
			this.btnClearTextT = new Button();
			this.lbPosition = new Label();
			this.btnSendOrderT = new Button();
			this.lbPublishT = new Label();
			this.cbValidityT = new ComboBox();
			this.lbPriceT = new Label();
			this.cbPriceTypeT = new ComboBox();
			this.lbVolumeT = new Label();
			this.lbSeries = new Label();
			this.panelAutoTradeMM = new Panel();
			this.panelMMPosition = new Panel();
			this.rdbMMClosePos = new RadioButton();
			this.rdbMMOpenPos = new RadioButton();
			this.btnMMShort = new Button();
			this.btnMMCover = new Button();
			this.tbMMStopPrice = new TextBox();
			this.cbMMPrice = new TextBox();
			this.lbMMPrice = new Label();
			this.lbMMTotalLoss = new Label();
			this.tbMMTotalLoss = new TextBox();
			this.btnMMSell = new Button();
			this.btnMMBuy = new Button();
			this.lbMMGiveUp = new Label();
			this.tbMMGiveUp = new TextBox();
			this.lbMMStopPrice = new Label();
			this.chbMMAutoStopLoss = new CheckBox();
			this.cbMMStock = new ComboBox();
			this.lbMMStock = new Label();
			this.btnMMClear = new Button();
			this.lbMMPin = new Label();
			this.tbMMPin = new TextBox();
			this.lbMMVolume = new Label();
			this.btnMMSend = new Button();
			this.tbMMVolume = new TextBox();
			this.panelTop.SuspendLayout();
			this.panelEquity.SuspendLayout();
			this.panelDerivative.SuspendLayout();
			this.panelTfexPosition.SuspendLayout();
			this.panelAutoTradeMM.SuspendLayout();
			this.panelMMPosition.SuspendLayout();
			base.SuspendLayout();
			this.lbPrice.AutoSize = true;
			this.lbPrice.ForeColor = Color.LightGray;
			this.lbPrice.Location = new Point(442, 8);
			this.lbPrice.Margin = new Padding(2, 0, 2, 0);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new Size(31, 13);
			this.lbPrice.TabIndex = 13;
			this.lbPrice.Text = "Price";
			this.lbPrice.TextAlign = ContentAlignment.MiddleLeft;
			this.lbVolume.AutoSize = true;
			this.lbVolume.ForeColor = Color.LightGray;
			this.lbVolume.Location = new Point(277, 8);
			this.lbVolume.Margin = new Padding(2, 0, 2, 0);
			this.lbVolume.Name = "lbVolume";
			this.lbVolume.Size = new Size(22, 13);
			this.lbVolume.TabIndex = 11;
			this.lbVolume.Text = "Vol";
			this.lbVolume.TextAlign = ContentAlignment.MiddleLeft;
			this.tbVolume.AllowDrop = true;
			this.tbVolume.BackColor = Color.FromArgb(224, 224, 224);
			this.tbVolume.BorderStyle = BorderStyle.FixedSingle;
			this.tbVolume.Location = new Point(300, 6);
			this.tbVolume.Margin = new Padding(2, 3, 2, 3);
			this.tbVolume.MaxLength = 10;
			this.tbVolume.Name = "tbVolume";
			this.tbVolume.Size = new Size(59, 20);
			this.tbVolume.TabIndex = 2;
			this.tbVolume.TextChanged += new EventHandler(this.tbVolume_TextChanged);
			this.tbVolume.DragDrop += new DragEventHandler(this.tbVolume_DragDrop);
			this.tbVolume.KeyDown += new KeyEventHandler(this.tbVolume_KeyDown);
			this.tbVolume.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbVolume.Enter += new EventHandler(this.controlOrder_Enter);
			this.tbVolume.DragEnter += new DragEventHandler(this.tbVolume_DragEnter);
			this.lbPublic.AutoSize = true;
			this.lbPublic.ForeColor = Color.LightGray;
			this.lbPublic.Location = new Point(549, 7);
			this.lbPublic.Margin = new Padding(2, 0, 2, 0);
			this.lbPublic.Name = "lbPublic";
			this.lbPublic.Size = new Size(43, 13);
			this.lbPublic.TabIndex = 67;
			this.lbPublic.Text = "Iceberg";
			this.lbPublic.TextAlign = ContentAlignment.MiddleLeft;
			this.lbCondition.AutoSize = true;
			this.lbCondition.ForeColor = Color.LightGray;
			this.lbCondition.Location = new Point(654, 6);
			this.lbCondition.Margin = new Padding(2, 0, 2, 0);
			this.lbCondition.Name = "lbCondition";
			this.lbCondition.Size = new Size(40, 13);
			this.lbCondition.TabIndex = 68;
			this.lbCondition.Text = "Validity";
			this.lbCondition.TextAlign = ContentAlignment.MiddleLeft;
			this.tbPublic.AllowDrop = true;
			this.tbPublic.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbPublic.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbPublic.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPublic.BorderStyle = BorderStyle.FixedSingle;
			this.tbPublic.CharacterCasing = CharacterCasing.Upper;
			this.tbPublic.Location = new Point(591, 4);
			this.tbPublic.Margin = new Padding(2, 3, 2, 3);
			this.tbPublic.MaxLength = 10;
			this.tbPublic.Name = "tbPublic";
			this.tbPublic.Size = new Size(59, 20);
			this.tbPublic.TabIndex = 4;
			this.tbPublic.TextChanged += new EventHandler(this.tbPublic_TextChanged);
			this.tbPublic.KeyDown += new KeyEventHandler(this.tbPublic_KeyDown);
			this.tbPublic.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbPublic.Enter += new EventHandler(this.controlOrder_Enter);
			this.chbNVDR.AutoSize = true;
			this.chbNVDR.ForeColor = Color.LightGray;
			this.chbNVDR.Location = new Point(225, 8);
			this.chbNVDR.Margin = new Padding(2, 3, 0, 3);
			this.chbNVDR.Name = "chbNVDR";
			this.chbNVDR.Size = new Size(57, 17);
			this.chbNVDR.TabIndex = 1;
			this.chbNVDR.Text = "NVDR";
			this.chbNVDR.UseVisualStyleBackColor = false;
			this.chbNVDR.Leave += new EventHandler(this.controlOrder_Leave);
			this.chbNVDR.Enter += new EventHandler(this.controlOrder_Enter);
			this.chbNVDR.CheckedChanged += new EventHandler(this.cbNVDR_CheckedChanged);
			this.chbNVDR.KeyDown += new KeyEventHandler(this.cbNDVR_KeyDown);
			this.panelTop.BackColor = Color.FromArgb(20, 20, 20);
			this.panelTop.Controls.Add(this.btnStyleMM);
			this.panelTop.Controls.Add(this.cbAccount);
			this.panelTop.Controls.Add(this.lbBuyLimit);
			this.panelTop.Controls.Add(this.btnNotification);
			this.panelTop.Controls.Add(this.tbEquity);
			this.panelTop.Controls.Add(this.btnShowStockAlert);
			this.panelTop.Controls.Add(this.tbBuyLimit);
			this.panelTop.Controls.Add(this.btnRisk);
			this.panelTop.Controls.Add(this.btnStyle4);
			this.panelTop.Controls.Add(this.lbEquity);
			this.panelTop.Controls.Add(this.btnStyle3);
			this.panelTop.Controls.Add(this.lbAccount);
			this.panelTop.Controls.Add(this.btnCleanPort);
			this.panelTop.Controls.Add(this.lbOnHand);
			this.panelTop.Controls.Add(this.btnSetting);
			this.panelTop.Controls.Add(this.tbOnHand);
			this.panelTop.Controls.Add(this.btnStyle2);
			this.panelTop.Controls.Add(this.btnStyle1);
			this.panelTop.ForeColor = Color.Black;
			this.panelTop.Location = new Point(1, 1);
			this.panelTop.Margin = new Padding(0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new Size(868, 24);
			this.panelTop.TabIndex = 72;
			this.btnStyleMM.BackColor = Color.Transparent;
			this.btnStyleMM.FlatAppearance.BorderColor = Color.Gray;
			this.btnStyleMM.FlatAppearance.BorderSize = 0;
			this.btnStyleMM.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnStyleMM.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnStyleMM.FlatStyle = FlatStyle.Flat;
			this.btnStyleMM.ForeColor = Color.LightGray;
			this.btnStyleMM.Location = new Point(809, 1);
			this.btnStyleMM.Name = "btnStyleMM";
			this.btnStyleMM.Size = new Size(33, 20);
			this.btnStyleMM.TabIndex = 111;
			this.btnStyleMM.TabStop = false;
			this.btnStyleMM.Text = "MM";
			this.toolTip1.SetToolTip(this.btnStyleMM, "Money Management");
			this.btnStyleMM.UseVisualStyleBackColor = false;
			this.btnStyleMM.Click += new EventHandler(this.btnStyle_Click);
			this.cbAccount.BackColor = Color.FromArgb(30, 30, 30);
			this.cbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbAccount.FlatStyle = FlatStyle.Popup;
			this.cbAccount.ForeColor = Color.Yellow;
			this.cbAccount.FormattingEnabled = true;
			this.cbAccount.Location = new Point(64, 1);
			this.cbAccount.Margin = new Padding(0, 3, 0, 3);
			this.cbAccount.Name = "cbAccount";
			this.cbAccount.Size = new Size(130, 21);
			this.cbAccount.TabIndex = 78;
			this.cbAccount.TabStop = false;
			this.cbAccount.SelectedIndexChanged += new EventHandler(this.cbAccount_SelectedIndexChanged);
			this.lbBuyLimit.AutoSize = true;
			this.lbBuyLimit.BackColor = Color.Transparent;
			this.lbBuyLimit.ForeColor = Color.White;
			this.lbBuyLimit.Location = new Point(198, 4);
			this.lbBuyLimit.Margin = new Padding(2, 0, 2, 0);
			this.lbBuyLimit.Name = "lbBuyLimit";
			this.lbBuyLimit.Size = new Size(55, 13);
			this.lbBuyLimit.TabIndex = 72;
			this.lbBuyLimit.Text = "Buy Limit :";
			this.lbBuyLimit.TextAlign = ContentAlignment.MiddleLeft;
			this.btnNotification.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnNotification.BackColor = Color.Transparent;
			this.btnNotification.FlatAppearance.BorderColor = Color.LightGray;
			this.btnNotification.FlatAppearance.BorderSize = 0;
			this.btnNotification.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnNotification.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnNotification.FlatStyle = FlatStyle.Flat;
			this.btnNotification.ForeColor = Color.LightGray;
			this.btnNotification.Image = (Image)componentResourceManager.GetObject("btnNotification.Image");
			this.btnNotification.Location = new Point(632, 1);
			this.btnNotification.Name = "btnNotification";
			this.btnNotification.Size = new Size(18, 20);
			this.btnNotification.TabIndex = 95;
			this.btnNotification.TabStop = false;
			this.btnNotification.Tag = "5";
			this.toolTip1.SetToolTip(this.btnNotification, "Mobile Notification");
			this.btnNotification.UseVisualStyleBackColor = false;
			this.btnNotification.Click += new EventHandler(this.btnNotification_Click);
			this.tbEquity.AutoSize = true;
			this.tbEquity.BackColor = Color.Transparent;
			this.tbEquity.ForeColor = Color.Yellow;
			this.tbEquity.Location = new Point(502, 4);
			this.tbEquity.Margin = new Padding(2, 0, 2, 0);
			this.tbEquity.Name = "tbEquity";
			this.tbEquity.Size = new Size(13, 13);
			this.tbEquity.TabIndex = 108;
			this.tbEquity.Tag = "1";
			this.tbEquity.Text = "0";
			this.tbEquity.TextAlign = ContentAlignment.MiddleLeft;
			this.btnShowStockAlert.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnShowStockAlert.BackColor = Color.Transparent;
			this.btnShowStockAlert.FlatAppearance.BorderColor = Color.LightGray;
			this.btnShowStockAlert.FlatAppearance.BorderSize = 0;
			this.btnShowStockAlert.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnShowStockAlert.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnShowStockAlert.FlatStyle = FlatStyle.Flat;
			this.btnShowStockAlert.ForeColor = Color.LightGray;
			this.btnShowStockAlert.Image = (Image)componentResourceManager.GetObject("btnShowStockAlert.Image");
			this.btnShowStockAlert.Location = new Point(661, 1);
			this.btnShowStockAlert.Name = "btnShowStockAlert";
			this.btnShowStockAlert.Size = new Size(18, 20);
			this.btnShowStockAlert.TabIndex = 94;
			this.btnShowStockAlert.TabStop = false;
			this.btnShowStockAlert.Tag = "5";
			this.toolTip1.SetToolTip(this.btnShowStockAlert, "Price Alert on PC");
			this.btnShowStockAlert.UseVisualStyleBackColor = false;
			this.btnShowStockAlert.Click += new EventHandler(this.btnShowStockAlert_Click);
			this.tbBuyLimit.AutoSize = true;
			this.tbBuyLimit.BackColor = Color.Transparent;
			this.tbBuyLimit.ForeColor = Color.Yellow;
			this.tbBuyLimit.Location = new Point(257, 4);
			this.tbBuyLimit.Margin = new Padding(2, 0, 2, 0);
			this.tbBuyLimit.MinimumSize = new Size(60, 0);
			this.tbBuyLimit.Name = "tbBuyLimit";
			this.tbBuyLimit.Size = new Size(60, 13);
			this.tbBuyLimit.TabIndex = 76;
			this.tbBuyLimit.Tag = "1";
			this.tbBuyLimit.Text = "0";
			this.tbBuyLimit.TextAlign = ContentAlignment.MiddleLeft;
			this.btnRisk.BackColor = Color.Transparent;
			this.btnRisk.FlatAppearance.BorderColor = Color.LightGray;
			this.btnRisk.FlatAppearance.BorderSize = 0;
			this.btnRisk.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnRisk.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnRisk.FlatStyle = FlatStyle.Flat;
			this.btnRisk.ForeColor = Color.LightGray;
			this.btnRisk.Image = (Image)componentResourceManager.GetObject("btnRisk.Image");
			this.btnRisk.Location = new Point(586, 1);
			this.btnRisk.Name = "btnRisk";
			this.btnRisk.Size = new Size(37, 20);
			this.btnRisk.TabIndex = 93;
			this.btnRisk.TabStop = false;
			this.toolTip1.SetToolTip(this.btnRisk, "Risk Control / เครื่องมือควบคุมความเสี่ยง");
			this.btnRisk.UseVisualStyleBackColor = false;
			this.btnRisk.Visible = false;
			this.btnRisk.Click += new EventHandler(this.btnPolicy_Click);
			this.btnStyle4.BackColor = Color.Transparent;
			this.btnStyle4.FlatAppearance.BorderColor = Color.Gray;
			this.btnStyle4.FlatAppearance.BorderSize = 0;
			this.btnStyle4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnStyle4.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnStyle4.FlatStyle = FlatStyle.Flat;
			this.btnStyle4.ForeColor = Color.LightGray;
			this.btnStyle4.Location = new Point(789, 1);
			this.btnStyle4.Name = "btnStyle4";
			this.btnStyle4.Size = new Size(18, 20);
			this.btnStyle4.TabIndex = 92;
			this.btnStyle4.TabStop = false;
			this.btnStyle4.Text = "4";
			this.toolTip1.SetToolTip(this.btnStyle4, "Trade Style 4");
			this.btnStyle4.UseVisualStyleBackColor = false;
			this.btnStyle4.Click += new EventHandler(this.btnStyle_Click);
			this.lbEquity.AutoSize = true;
			this.lbEquity.BackColor = Color.Transparent;
			this.lbEquity.ForeColor = Color.White;
			this.lbEquity.Location = new Point(451, 4);
			this.lbEquity.Margin = new Padding(2, 0, 2, 0);
			this.lbEquity.Name = "lbEquity";
			this.lbEquity.Size = new Size(42, 13);
			this.lbEquity.TabIndex = 107;
			this.lbEquity.Text = "Equity :";
			this.lbEquity.TextAlign = ContentAlignment.MiddleLeft;
			this.btnStyle3.BackColor = Color.Transparent;
			this.btnStyle3.FlatAppearance.BorderColor = Color.Gray;
			this.btnStyle3.FlatAppearance.BorderSize = 0;
			this.btnStyle3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnStyle3.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnStyle3.FlatStyle = FlatStyle.Flat;
			this.btnStyle3.ForeColor = Color.LightGray;
			this.btnStyle3.Location = new Point(771, 1);
			this.btnStyle3.Name = "btnStyle3";
			this.btnStyle3.Size = new Size(18, 20);
			this.btnStyle3.TabIndex = 90;
			this.btnStyle3.TabStop = false;
			this.btnStyle3.Text = "3";
			this.toolTip1.SetToolTip(this.btnStyle3, "Trade Style 3");
			this.btnStyle3.UseVisualStyleBackColor = false;
			this.btnStyle3.Click += new EventHandler(this.btnStyle_Click);
			this.lbAccount.AutoSize = true;
			this.lbAccount.BackColor = Color.Transparent;
			this.lbAccount.ForeColor = Color.White;
			this.lbAccount.Location = new Point(6, 4);
			this.lbAccount.Margin = new Padding(2, 0, 1, 0);
			this.lbAccount.Name = "lbAccount";
			this.lbAccount.Size = new Size(53, 13);
			this.lbAccount.TabIndex = 79;
			this.lbAccount.Text = "Account :";
			this.lbAccount.TextAlign = ContentAlignment.MiddleLeft;
			this.btnCleanPort.BackColor = Color.Transparent;
			this.btnCleanPort.FlatAppearance.BorderColor = Color.Gray;
			this.btnCleanPort.FlatAppearance.BorderSize = 0;
			this.btnCleanPort.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnCleanPort.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnCleanPort.FlatStyle = FlatStyle.Flat;
			this.btnCleanPort.ForeColor = Color.LightGray;
			this.btnCleanPort.Image = (Image)componentResourceManager.GetObject("btnCleanPort.Image");
			this.btnCleanPort.Location = new Point(691, 1);
			this.btnCleanPort.Name = "btnCleanPort";
			this.btnCleanPort.Size = new Size(18, 20);
			this.btnCleanPort.TabIndex = 89;
			this.btnCleanPort.TabStop = false;
			this.toolTip1.SetToolTip(this.btnCleanPort, "Portfolio clearing tool");
			this.btnCleanPort.UseVisualStyleBackColor = false;
			this.btnCleanPort.Click += new EventHandler(this.btnCleanPort_Click);
			this.lbOnHand.AutoSize = true;
			this.lbOnHand.BackColor = Color.Transparent;
			this.lbOnHand.ForeColor = Color.White;
			this.lbOnHand.Location = new Point(323, 4);
			this.lbOnHand.Margin = new Padding(2, 0, 2, 0);
			this.lbOnHand.Name = "lbOnHand";
			this.lbOnHand.Size = new Size(56, 13);
			this.lbOnHand.TabIndex = 80;
			this.lbOnHand.Text = "OnHand : ";
			this.lbOnHand.TextAlign = ContentAlignment.MiddleLeft;
			this.btnSetting.BackColor = Color.Transparent;
			this.btnSetting.FlatAppearance.BorderColor = Color.Gray;
			this.btnSetting.FlatAppearance.BorderSize = 0;
			this.btnSetting.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSetting.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnSetting.FlatStyle = FlatStyle.Flat;
			this.btnSetting.ForeColor = Color.LightGray;
			this.btnSetting.Image = (Image)componentResourceManager.GetObject("btnSetting.Image");
			this.btnSetting.Location = new Point(842, 1);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new Size(20, 20);
			this.btnSetting.TabIndex = 88;
			this.btnSetting.TabStop = false;
			this.toolTip1.SetToolTip(this.btnSetting, "Buy/Sell Options");
			this.btnSetting.UseVisualStyleBackColor = false;
			this.btnSetting.Click += new EventHandler(this.btnSetting_Click);
			this.tbOnHand.AutoSize = true;
			this.tbOnHand.BackColor = Color.Transparent;
			this.tbOnHand.ForeColor = Color.Yellow;
			this.tbOnHand.Location = new Point(383, 4);
			this.tbOnHand.Margin = new Padding(2, 0, 2, 0);
			this.tbOnHand.MinimumSize = new Size(60, 0);
			this.tbOnHand.Name = "tbOnHand";
			this.tbOnHand.Size = new Size(60, 13);
			this.tbOnHand.TabIndex = 81;
			this.tbOnHand.Tag = "1";
			this.tbOnHand.Text = "0";
			this.tbOnHand.TextAlign = ContentAlignment.MiddleLeft;
			this.btnStyle2.BackColor = Color.Transparent;
			this.btnStyle2.FlatAppearance.BorderColor = Color.Gray;
			this.btnStyle2.FlatAppearance.BorderSize = 0;
			this.btnStyle2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnStyle2.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnStyle2.FlatStyle = FlatStyle.Flat;
			this.btnStyle2.ForeColor = Color.LightGray;
			this.btnStyle2.Location = new Point(747, 1);
			this.btnStyle2.Name = "btnStyle2";
			this.btnStyle2.Size = new Size(18, 20);
			this.btnStyle2.TabIndex = 87;
			this.btnStyle2.TabStop = false;
			this.btnStyle2.Text = "2";
			this.toolTip1.SetToolTip(this.btnStyle2, "Quick Trade Style");
			this.btnStyle2.UseVisualStyleBackColor = false;
			this.btnStyle2.Click += new EventHandler(this.btnStyle_Click);
			this.btnStyle1.BackColor = Color.Transparent;
			this.btnStyle1.FlatAppearance.BorderColor = Color.Gray;
			this.btnStyle1.FlatAppearance.BorderSize = 0;
			this.btnStyle1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnStyle1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
			this.btnStyle1.FlatStyle = FlatStyle.Flat;
			this.btnStyle1.ForeColor = Color.LightGray;
			this.btnStyle1.Location = new Point(720, 1);
			this.btnStyle1.Name = "btnStyle1";
			this.btnStyle1.Size = new Size(18, 20);
			this.btnStyle1.TabIndex = 86;
			this.btnStyle1.TabStop = false;
			this.btnStyle1.Text = "1";
			this.toolTip1.SetToolTip(this.btnStyle1, "i2 Trade Style");
			this.btnStyle1.UseVisualStyleBackColor = false;
			this.btnStyle1.Click += new EventHandler(this.btnStyle_Click);
			this.lbLoading.AutoSize = true;
			this.lbLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbLoading.ForeColor = Color.Yellow;
			this.lbLoading.Location = new Point(362, 95);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Padding = new Padding(4, 3, 4, 3);
			this.lbLoading.Size = new Size(137, 23);
			this.lbLoading.TabIndex = 73;
			this.lbLoading.Text = "Sending New Order ...";
			this.lbLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbLoading.Visible = false;
			this.btnSendOrder.AutoEllipsis = true;
			this.btnSendOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnSendOrder.BackColor = Color.Transparent;
			this.btnSendOrder.Cursor = Cursors.Hand;
			this.btnSendOrder.FlatAppearance.BorderColor = Color.DimGray;
			this.btnSendOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnSendOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnSendOrder.FlatStyle = FlatStyle.Flat;
			this.btnSendOrder.ForeColor = Color.WhiteSmoke;
			this.btnSendOrder.Image = Resources.side_noside;
			this.btnSendOrder.Location = new Point(718, 28);
			this.btnSendOrder.MaximumSize = new Size(58, 23);
			this.btnSendOrder.Name = "btnSendOrder";
			this.btnSendOrder.Size = new Size(52, 22);
			this.btnSendOrder.TabIndex = 8;
			this.btnSendOrder.TabStop = false;
			this.btnSendOrder.Text = "Send";
			this.btnSendOrder.UseVisualStyleBackColor = false;
			this.btnSendOrder.Click += new EventHandler(this.btnSendOrder_Click);
			this.cbCondition.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"IOC",
				"FOK"
			});
			this.cbCondition.AutoCompleteMode = AutoCompleteMode.Append;
			this.cbCondition.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbCondition.BackColor = Color.FromArgb(224, 224, 224);
			this.cbCondition.FlatStyle = FlatStyle.Popup;
			this.cbCondition.ForeColor = Color.Black;
			this.cbCondition.FormattingEnabled = true;
			this.cbCondition.Items.AddRange(new object[]
			{
				"",
				"IOC",
				"FOK"
			});
			this.cbCondition.Location = new Point(697, 3);
			this.cbCondition.Name = "cbCondition";
			this.cbCondition.Size = new Size(40, 21);
			this.cbCondition.TabIndex = 5;
			this.cbCondition.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbCondition.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbCondition.KeyPress += new KeyPressEventHandler(this.cbCondition_KeyPress);
			this.cbCondition.KeyDown += new KeyEventHandler(this.cbCondition_KeyDown);
			this.panelEquity.BackColor = Color.FromArgb(30, 30, 30);
			this.panelEquity.Controls.Add(this.cbDepCollateral);
			this.panelEquity.Controls.Add(this.lbDep);
			this.panelEquity.Controls.Add(this.cbStock);
			this.panelEquity.Controls.Add(this.lbStock);
			this.panelEquity.Controls.Add(this.lbSide);
			this.panelEquity.Controls.Add(this.cbSide);
			this.panelEquity.Controls.Add(this.btnPriceDec);
			this.panelEquity.Controls.Add(this.btnPriceInc);
			this.panelEquity.Controls.Add(this.btnPBDec);
			this.panelEquity.Controls.Add(this.btnPBInc);
			this.panelEquity.Controls.Add(this.btnVolDec);
			this.panelEquity.Controls.Add(this.btnVolInc);
			this.panelEquity.Controls.Add(this.btnClear);
			this.panelEquity.Controls.Add(this.lbPin);
			this.panelEquity.Controls.Add(this.tbPin);
			this.panelEquity.Controls.Add(this.rbCover);
			this.panelEquity.Controls.Add(this.rbShort);
			this.panelEquity.Controls.Add(this.rbSell);
			this.panelEquity.Controls.Add(this.rbBuy);
			this.panelEquity.Controls.Add(this.cbPrice);
			this.panelEquity.Controls.Add(this.tbTimes);
			this.panelEquity.Controls.Add(this.lbTimes);
			this.panelEquity.Controls.Add(this.cbCondition);
			this.panelEquity.Controls.Add(this.lbPrice);
			this.panelEquity.Controls.Add(this.lbVolume);
			this.panelEquity.Controls.Add(this.btnSendOrder);
			this.panelEquity.Controls.Add(this.tbPublic);
			this.panelEquity.Controls.Add(this.chbNVDR);
			this.panelEquity.Controls.Add(this.lbCondition);
			this.panelEquity.Controls.Add(this.tbVolume);
			this.panelEquity.Controls.Add(this.lbPublic);
			this.panelEquity.Location = new Point(3, 30);
			this.panelEquity.Name = "panelEquity";
			this.panelEquity.Size = new Size(866, 88);
			this.panelEquity.TabIndex = 79;
			this.cbDepCollateral.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"IOC",
				"FOK"
			});
			this.cbDepCollateral.AutoCompleteMode = AutoCompleteMode.Append;
			this.cbDepCollateral.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbDepCollateral.BackColor = Color.FromArgb(224, 224, 224);
			this.cbDepCollateral.FlatStyle = FlatStyle.Popup;
			this.cbDepCollateral.ForeColor = Color.Black;
			this.cbDepCollateral.FormattingEnabled = true;
			this.cbDepCollateral.Location = new Point(774, 3);
			this.cbDepCollateral.Name = "cbDepCollateral";
			this.cbDepCollateral.Size = new Size(57, 21);
			this.cbDepCollateral.TabIndex = 102;
			this.cbDepCollateral.SelectedIndexChanged += new EventHandler(this.cbDepCollateral_SelectedIndexChanged);
			this.cbDepCollateral.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbDepCollateral.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbDepCollateral.KeyPress += new KeyPressEventHandler(this.cbCondition_KeyPress);
			this.cbDepCollateral.KeyDown += new KeyEventHandler(this.cbDepCollateral_KeyDown);
			this.lbDep.AutoSize = true;
			this.lbDep.ForeColor = Color.LightGray;
			this.lbDep.Location = new Point(741, 6);
			this.lbDep.Margin = new Padding(2, 0, 2, 0);
			this.lbDep.Name = "lbDep";
			this.lbDep.Size = new Size(27, 13);
			this.lbDep.TabIndex = 101;
			this.lbDep.Text = "Dep";
			this.lbDep.TextAlign = ContentAlignment.MiddleLeft;
			this.cbStock.AllowDrop = true;
			this.cbStock.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cbStock.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbStock.BackColor = Color.FromArgb(224, 224, 224);
			this.cbStock.FlatStyle = FlatStyle.Popup;
			this.cbStock.ForeColor = Color.Black;
			this.cbStock.FormattingEnabled = true;
			this.cbStock.Location = new Point(139, 4);
			this.cbStock.MaxLength = 20;
			this.cbStock.Name = "cbStock";
			this.cbStock.Size = new Size(82, 21);
			this.cbStock.TabIndex = 0;
			this.cbStock.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbStock.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbStock.DragDrop += new DragEventHandler(this.cbStock_DragDrop);
			this.cbStock.DragEnter += new DragEventHandler(this.cbStock_DragEnter);
			this.cbStock.KeyPress += new KeyPressEventHandler(this.cbStock_KeyPress);
			this.cbStock.KeyDown += new KeyEventHandler(this.cbStock_KeyDown);
			this.lbStock.AutoSize = true;
			this.lbStock.ForeColor = Color.LightGray;
			this.lbStock.Location = new Point(94, 9);
			this.lbStock.Margin = new Padding(2, 0, 2, 0);
			this.lbStock.Name = "lbStock";
			this.lbStock.Size = new Size(41, 13);
			this.lbStock.TabIndex = 100;
			this.lbStock.Text = "Symbol";
			this.lbStock.TextAlign = ContentAlignment.MiddleLeft;
			this.lbStock.Visible = false;
			this.lbSide.AutoSize = true;
			this.lbSide.ForeColor = Color.LightGray;
			this.lbSide.Location = new Point(7, 56);
			this.lbSide.Margin = new Padding(2, 0, 2, 0);
			this.lbSide.Name = "lbSide";
			this.lbSide.Size = new Size(28, 13);
			this.lbSide.TabIndex = 99;
			this.lbSide.Text = "Side";
			this.lbSide.TextAlign = ContentAlignment.MiddleLeft;
			this.lbSide.Visible = false;
			this.cbSide.AutoCompleteCustomSource.AddRange(new string[]
			{
				"Buy",
				"Sell",
				"Cover",
				"Short"
			});
			this.cbSide.AutoCompleteMode = AutoCompleteMode.Append;
			this.cbSide.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbSide.BackColor = Color.FromArgb(224, 224, 224);
			this.cbSide.FlatStyle = FlatStyle.Popup;
			this.cbSide.ForeColor = Color.Black;
			this.cbSide.FormattingEnabled = true;
			this.cbSide.Items.AddRange(new object[]
			{
				"Buy",
				"Sell",
				"Cover",
				"Short"
			});
			this.cbSide.Location = new Point(38, 52);
			this.cbSide.Name = "cbSide";
			this.cbSide.Size = new Size(51, 21);
			this.cbSide.TabIndex = 98;
			this.cbSide.SelectedIndexChanged += new EventHandler(this.cbSide_SelectedIndexChanged);
			this.cbSide.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbSide.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbSide.KeyPress += new KeyPressEventHandler(this.cbSide_KeyPress);
			this.cbSide.KeyDown += new KeyEventHandler(this.cbSide_KeyDown);
			this.btnPriceDec.FlatAppearance.BorderSize = 0;
			this.btnPriceDec.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPriceDec.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnPriceDec.FlatStyle = FlatStyle.Flat;
			this.btnPriceDec.Image = (Image)componentResourceManager.GetObject("btnPriceDec.Image");
			this.btnPriceDec.Location = new Point(510, 34);
			this.btnPriceDec.Name = "btnPriceDec";
			this.btnPriceDec.Size = new Size(15, 15);
			this.btnPriceDec.TabIndex = 97;
			this.btnPriceDec.UseVisualStyleBackColor = true;
			this.btnPriceDec.Click += new EventHandler(this.btnPriceDec_Click);
			this.btnPriceInc.FlatAppearance.BorderSize = 0;
			this.btnPriceInc.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPriceInc.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnPriceInc.FlatStyle = FlatStyle.Flat;
			this.btnPriceInc.Image = (Image)componentResourceManager.GetObject("btnPriceInc.Image");
			this.btnPriceInc.Location = new Point(537, 33);
			this.btnPriceInc.Name = "btnPriceInc";
			this.btnPriceInc.Size = new Size(15, 15);
			this.btnPriceInc.TabIndex = 96;
			this.btnPriceInc.UseVisualStyleBackColor = true;
			this.btnPriceInc.Click += new EventHandler(this.btnPriceInc_Click);
			this.btnPBDec.FlatAppearance.BorderSize = 0;
			this.btnPBDec.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPBDec.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnPBDec.FlatStyle = FlatStyle.Flat;
			this.btnPBDec.Image = (Image)componentResourceManager.GetObject("btnPBDec.Image");
			this.btnPBDec.Location = new Point(443, 33);
			this.btnPBDec.Name = "btnPBDec";
			this.btnPBDec.Size = new Size(15, 15);
			this.btnPBDec.TabIndex = 95;
			this.btnPBDec.UseVisualStyleBackColor = true;
			this.btnPBDec.Click += new EventHandler(this.btnPBDec_Click);
			this.btnPBInc.FlatAppearance.BorderSize = 0;
			this.btnPBInc.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPBInc.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnPBInc.FlatStyle = FlatStyle.Flat;
			this.btnPBInc.Image = (Image)componentResourceManager.GetObject("btnPBInc.Image");
			this.btnPBInc.Location = new Point(470, 32);
			this.btnPBInc.Name = "btnPBInc";
			this.btnPBInc.Size = new Size(15, 15);
			this.btnPBInc.TabIndex = 94;
			this.btnPBInc.UseVisualStyleBackColor = true;
			this.btnPBInc.Click += new EventHandler(this.btnPBInc_Click);
			this.btnVolDec.FlatAppearance.BorderSize = 0;
			this.btnVolDec.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnVolDec.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnVolDec.FlatStyle = FlatStyle.Flat;
			this.btnVolDec.Image = (Image)componentResourceManager.GetObject("btnVolDec.Image");
			this.btnVolDec.Location = new Point(394, 28);
			this.btnVolDec.Name = "btnVolDec";
			this.btnVolDec.Size = new Size(15, 15);
			this.btnVolDec.TabIndex = 93;
			this.btnVolDec.UseVisualStyleBackColor = true;
			this.btnVolDec.Click += new EventHandler(this.btnVolDec_Click);
			this.btnVolInc.FlatAppearance.BorderSize = 0;
			this.btnVolInc.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnVolInc.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnVolInc.FlatStyle = FlatStyle.Flat;
			this.btnVolInc.Image = (Image)componentResourceManager.GetObject("btnVolInc.Image");
			this.btnVolInc.Location = new Point(421, 27);
			this.btnVolInc.Name = "btnVolInc";
			this.btnVolInc.Size = new Size(15, 15);
			this.btnVolInc.TabIndex = 92;
			this.btnVolInc.UseVisualStyleBackColor = true;
			this.btnVolInc.Click += new EventHandler(this.btnVolInc_Click);
			this.btnClear.AutoEllipsis = true;
			this.btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnClear.BackColor = Color.Transparent;
			this.btnClear.Cursor = Cursors.Hand;
			this.btnClear.FlatAppearance.BorderColor = Color.DimGray;
			this.btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnClear.FlatStyle = FlatStyle.Flat;
			this.btnClear.ForeColor = Color.WhiteSmoke;
			this.btnClear.Image = Resources.side_noside;
			this.btnClear.Location = new Point(778, 28);
			this.btnClear.MaximumSize = new Size(58, 23);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new Size(52, 22);
			this.btnClear.TabIndex = 9;
			this.btnClear.TabStop = false;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new EventHandler(this.btnClear_Click);
			this.lbPin.AutoSize = true;
			this.lbPin.ForeColor = Color.LightGray;
			this.lbPin.Location = new Point(642, 33);
			this.lbPin.Margin = new Padding(2, 0, 2, 0);
			this.lbPin.Name = "lbPin";
			this.lbPin.Size = new Size(25, 13);
			this.lbPin.TabIndex = 90;
			this.lbPin.Text = "PIN";
			this.lbPin.TextAlign = ContentAlignment.MiddleLeft;
			this.tbPin.AllowDrop = true;
			this.tbPin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbPin.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbPin.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPin.BorderStyle = BorderStyle.FixedSingle;
			this.tbPin.CharacterCasing = CharacterCasing.Upper;
			this.tbPin.Location = new Point(671, 29);
			this.tbPin.Margin = new Padding(2, 3, 2, 3);
			this.tbPin.MaxLength = 10;
			this.tbPin.Name = "tbPin";
			this.tbPin.PasswordChar = '*';
			this.tbPin.Size = new Size(40, 20);
			this.tbPin.TabIndex = 7;
			this.tbPin.KeyDown += new KeyEventHandler(this.tbPin_KeyDown);
			this.tbPin.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbPin.Enter += new EventHandler(this.controlOrder_Enter);
			this.rbCover.AutoSize = true;
			this.rbCover.ForeColor = Color.LightGray;
			this.rbCover.Location = new Point(57, 29);
			this.rbCover.Name = "rbCover";
			this.rbCover.Size = new Size(53, 17);
			this.rbCover.TabIndex = 88;
			this.rbCover.TabStop = true;
			this.rbCover.Text = "Cover";
			this.rbCover.UseVisualStyleBackColor = true;
			this.rbCover.CheckedChanged += new EventHandler(this.rbSide_CheckedChanged);
			this.rbShort.AutoSize = true;
			this.rbShort.ForeColor = Color.LightGray;
			this.rbShort.Location = new Point(3, 30);
			this.rbShort.Name = "rbShort";
			this.rbShort.Size = new Size(50, 17);
			this.rbShort.TabIndex = 87;
			this.rbShort.TabStop = true;
			this.rbShort.Text = "Short";
			this.rbShort.UseVisualStyleBackColor = true;
			this.rbShort.CheckedChanged += new EventHandler(this.rbSide_CheckedChanged);
			this.rbSell.AutoSize = true;
			this.rbSell.ForeColor = Color.LightGray;
			this.rbSell.Location = new Point(47, 7);
			this.rbSell.Name = "rbSell";
			this.rbSell.Size = new Size(42, 17);
			this.rbSell.TabIndex = 86;
			this.rbSell.TabStop = true;
			this.rbSell.Text = "Sell";
			this.rbSell.UseVisualStyleBackColor = true;
			this.rbSell.CheckedChanged += new EventHandler(this.rbSide_CheckedChanged);
			this.rbBuy.AutoSize = true;
			this.rbBuy.ForeColor = Color.LightGray;
			this.rbBuy.Location = new Point(4, 6);
			this.rbBuy.Name = "rbBuy";
			this.rbBuy.Size = new Size(43, 17);
			this.rbBuy.TabIndex = 85;
			this.rbBuy.TabStop = true;
			this.rbBuy.Text = "Buy";
			this.rbBuy.UseVisualStyleBackColor = true;
			this.rbBuy.CheckedChanged += new EventHandler(this.rbSide_CheckedChanged);
			this.cbPrice.AllowDrop = true;
			this.cbPrice.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"ATO",
				"ATC",
				"MP",
				"MO",
				"ML"
			});
			this.cbPrice.AutoCompleteMode = AutoCompleteMode.Append;
			this.cbPrice.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbPrice.BackColor = Color.FromArgb(224, 224, 224);
			this.cbPrice.FlatStyle = FlatStyle.Popup;
			this.cbPrice.ForeColor = Color.Black;
			this.cbPrice.FormattingEnabled = true;
			this.cbPrice.Items.AddRange(new object[]
			{
				"",
				"ATO",
				"ATC",
				"MP",
				"MO",
				"ML"
			});
			this.cbPrice.Location = new Point(478, 5);
			this.cbPrice.Name = "cbPrice";
			this.cbPrice.Size = new Size(57, 21);
			this.cbPrice.TabIndex = 3;
			this.cbPrice.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbPrice.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbPrice.DragDrop += new DragEventHandler(this.cbPrice_DragDrop);
			this.cbPrice.DragEnter += new DragEventHandler(this.cbPrice_DragEnter);
			this.cbPrice.KeyPress += new KeyPressEventHandler(this.cbPrice_KeyPress);
			this.cbPrice.KeyDown += new KeyEventHandler(this.cbPrice_KeyDown);
			this.tbTimes.AllowDrop = true;
			this.tbTimes.BackColor = Color.FromArgb(224, 224, 224);
			this.tbTimes.BorderStyle = BorderStyle.FixedSingle;
			this.tbTimes.CharacterCasing = CharacterCasing.Upper;
			this.tbTimes.Location = new Point(400, 7);
			this.tbTimes.Margin = new Padding(2, 3, 2, 3);
			this.tbTimes.MaxLength = 2;
			this.tbTimes.Name = "tbTimes";
			this.tbTimes.Size = new Size(40, 20);
			this.tbTimes.TabIndex = 80;
			this.tbTimes.TextAlign = HorizontalAlignment.Center;
			this.tbTimes.Visible = false;
			this.tbTimes.KeyDown += new KeyEventHandler(this.tbTimes_KeyDown);
			this.tbTimes.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbTimes.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbTimes.AutoSize = true;
			this.lbTimes.ForeColor = Color.LightGray;
			this.lbTimes.Location = new Point(361, 8);
			this.lbTimes.Margin = new Padding(2, 0, 2, 0);
			this.lbTimes.Name = "lbTimes";
			this.lbTimes.Size = new Size(35, 13);
			this.lbTimes.TabIndex = 79;
			this.lbTimes.Text = "Times";
			this.lbTimes.TextAlign = ContentAlignment.MiddleLeft;
			this.lbTimes.Visible = false;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Info guide";
			this.panelDerivative.BackColor = Color.FromArgb(30, 30, 30);
			this.panelDerivative.Controls.Add(this.panelTfexPosition);
			this.panelDerivative.Controls.Add(this.cbPosition);
			this.panelDerivative.Controls.Add(this.rdbTfexSell);
			this.panelDerivative.Controls.Add(this.rdbTfexBuy);
			this.panelDerivative.Controls.Add(this.tbTfexPriceCondition);
			this.panelDerivative.Controls.Add(this.cbTfexConStopOrder);
			this.panelDerivative.Controls.Add(this.tbPriceT);
			this.panelDerivative.Controls.Add(this.tbSeriesCondition);
			this.panelDerivative.Controls.Add(this.tbSeries);
			this.panelDerivative.Controls.Add(this.chbTfexStopOrder);
			this.panelDerivative.Controls.Add(this.tbPublishT);
			this.panelDerivative.Controls.Add(this.lbValidityT);
			this.panelDerivative.Controls.Add(this.tbVolumeT);
			this.panelDerivative.Controls.Add(this.lbPriceTypeT);
			this.panelDerivative.Controls.Add(this.btnClearTextT);
			this.panelDerivative.Controls.Add(this.lbPosition);
			this.panelDerivative.Controls.Add(this.btnSendOrderT);
			this.panelDerivative.Controls.Add(this.lbPublishT);
			this.panelDerivative.Controls.Add(this.cbValidityT);
			this.panelDerivative.Controls.Add(this.lbPriceT);
			this.panelDerivative.Controls.Add(this.cbPriceTypeT);
			this.panelDerivative.Controls.Add(this.lbVolumeT);
			this.panelDerivative.Controls.Add(this.lbSeries);
			this.panelDerivative.Location = new Point(7, 124);
			this.panelDerivative.Name = "panelDerivative";
			this.panelDerivative.Size = new Size(862, 62);
			this.panelDerivative.TabIndex = 83;
			this.panelTfexPosition.BackColor = Color.Transparent;
			this.panelTfexPosition.BorderStyle = BorderStyle.FixedSingle;
			this.panelTfexPosition.Controls.Add(this.rdbTfexClosePos);
			this.panelTfexPosition.Controls.Add(this.rdbTfexOpenPos);
			this.panelTfexPosition.Location = new Point(6, 30);
			this.panelTfexPosition.Name = "panelTfexPosition";
			this.panelTfexPosition.Size = new Size(116, 23);
			this.panelTfexPosition.TabIndex = 118;
			this.panelTfexPosition.Visible = false;
			this.rdbTfexClosePos.AutoSize = true;
			this.rdbTfexClosePos.ForeColor = Color.LightGray;
			this.rdbTfexClosePos.Location = new Point(61, 1);
			this.rdbTfexClosePos.Name = "rdbTfexClosePos";
			this.rdbTfexClosePos.Size = new Size(51, 17);
			this.rdbTfexClosePos.TabIndex = 117;
			this.rdbTfexClosePos.TabStop = true;
			this.rdbTfexClosePos.Text = "Close";
			this.rdbTfexClosePos.UseVisualStyleBackColor = true;
			this.rdbTfexOpenPos.AutoSize = true;
			this.rdbTfexOpenPos.ForeColor = Color.LightGray;
			this.rdbTfexOpenPos.Location = new Point(6, 1);
			this.rdbTfexOpenPos.Name = "rdbTfexOpenPos";
			this.rdbTfexOpenPos.Size = new Size(51, 17);
			this.rdbTfexOpenPos.TabIndex = 116;
			this.rdbTfexOpenPos.TabStop = true;
			this.rdbTfexOpenPos.Text = "Open";
			this.rdbTfexOpenPos.UseVisualStyleBackColor = true;
			this.cbPosition.AutoCompleteCustomSource.AddRange(new string[]
			{
				"OPEN",
				"CLOSE"
			});
			this.cbPosition.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbPosition.BackColor = Color.FromArgb(224, 224, 224);
			this.cbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbPosition.FlatStyle = FlatStyle.Popup;
			this.cbPosition.FormattingEnabled = true;
			this.cbPosition.Items.AddRange(new object[]
			{
				"OPEN",
				"CLOSE"
			});
			this.cbPosition.Location = new Point(160, 28);
			this.cbPosition.Name = "cbPosition";
			this.cbPosition.Size = new Size(90, 21);
			this.cbPosition.TabIndex = 117;
			this.cbPosition.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.cbPosition.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbPosition.KeyDown += new KeyEventHandler(this.cbPosition_KeyDown);
			this.rdbTfexSell.AutoSize = true;
			this.rdbTfexSell.ForeColor = Color.LightGray;
			this.rdbTfexSell.Location = new Point(59, 5);
			this.rdbTfexSell.Name = "rdbTfexSell";
			this.rdbTfexSell.Size = new Size(50, 17);
			this.rdbTfexSell.TabIndex = 116;
			this.rdbTfexSell.TabStop = true;
			this.rdbTfexSell.Text = "Short";
			this.rdbTfexSell.UseVisualStyleBackColor = true;
			this.rdbTfexSell.CheckedChanged += new EventHandler(this.rdbTfexSell_CheckedChanged);
			this.rdbTfexBuy.AutoSize = true;
			this.rdbTfexBuy.ForeColor = Color.LightGray;
			this.rdbTfexBuy.Location = new Point(13, 5);
			this.rdbTfexBuy.Name = "rdbTfexBuy";
			this.rdbTfexBuy.Size = new Size(49, 17);
			this.rdbTfexBuy.TabIndex = 115;
			this.rdbTfexBuy.TabStop = true;
			this.rdbTfexBuy.Text = "Long";
			this.rdbTfexBuy.UseVisualStyleBackColor = true;
			this.rdbTfexBuy.CheckedChanged += new EventHandler(this.rdbTfexBuy_CheckedChanged);
			this.tbTfexPriceCondition.AllowDrop = true;
			this.tbTfexPriceCondition.AutoCompleteCustomSource.AddRange(new string[]
			{
				"ATO",
				"ATC",
				"MP"
			});
			this.tbTfexPriceCondition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbTfexPriceCondition.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbTfexPriceCondition.BackColor = Color.FromArgb(224, 224, 224);
			this.tbTfexPriceCondition.BorderStyle = BorderStyle.FixedSingle;
			this.tbTfexPriceCondition.CharacterCasing = CharacterCasing.Upper;
			this.tbTfexPriceCondition.Location = new Point(761, 29);
			this.tbTfexPriceCondition.Margin = new Padding(2, 3, 2, 3);
			this.tbTfexPriceCondition.MaxLength = 10;
			this.tbTfexPriceCondition.Name = "tbTfexPriceCondition";
			this.tbTfexPriceCondition.Size = new Size(61, 20);
			this.tbTfexPriceCondition.TabIndex = 114;
			this.tbTfexPriceCondition.Visible = false;
			this.tbTfexPriceCondition.KeyDown += new KeyEventHandler(this.tbTfexPriceCondition_KeyDown);
			this.tbTfexPriceCondition.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.tbTfexPriceCondition.KeyPress += new KeyPressEventHandler(this.tbTfexPriceCondition_KeyPress);
			this.tbTfexPriceCondition.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbTfexConStopOrder.BackColor = Color.FromArgb(224, 224, 224);
			this.cbTfexConStopOrder.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbTfexConStopOrder.FlatStyle = FlatStyle.Popup;
			this.cbTfexConStopOrder.FormattingEnabled = true;
			this.cbTfexConStopOrder.Items.AddRange(new object[]
			{
				"Bid >=",
				"Bid <=",
				"Ask >=",
				"Ask <=",
				"Last >=",
				"Last <="
			});
			this.cbTfexConStopOrder.Location = new Point(688, 28);
			this.cbTfexConStopOrder.Name = "cbTfexConStopOrder";
			this.cbTfexConStopOrder.Size = new Size(68, 21);
			this.cbTfexConStopOrder.TabIndex = 113;
			this.cbTfexConStopOrder.TabStop = false;
			this.cbTfexConStopOrder.Visible = false;
			this.cbTfexConStopOrder.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.cbTfexConStopOrder.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbTfexConStopOrder.KeyDown += new KeyEventHandler(this.cbTfexConStopOrder_KeyDown);
			this.tbPriceT.AllowDrop = true;
			this.tbPriceT.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPriceT.BorderStyle = BorderStyle.FixedSingle;
			this.tbPriceT.CharacterCasing = CharacterCasing.Upper;
			this.tbPriceT.Location = new Point(444, 3);
			this.tbPriceT.Margin = new Padding(2, 3, 2, 3);
			this.tbPriceT.MaxLength = 10;
			this.tbPriceT.Name = "tbPriceT";
			this.tbPriceT.Size = new Size(70, 20);
			this.tbPriceT.TabIndex = 96;
			this.tbPriceT.KeyDown += new KeyEventHandler(this.tbPriceT_KeyDown);
			this.tbPriceT.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.tbPriceT.KeyPress += new KeyPressEventHandler(this.tbTfexPriceCondition_KeyPress);
			this.tbPriceT.Enter += new EventHandler(this.controlOrder_Enter);
			this.tbSeriesCondition.AllowDrop = true;
			this.tbSeriesCondition.BackColor = Color.FromArgb(224, 224, 224);
			this.tbSeriesCondition.BorderStyle = BorderStyle.FixedSingle;
			this.tbSeriesCondition.CharacterCasing = CharacterCasing.Upper;
			this.tbSeriesCondition.ForeColor = Color.Silver;
			this.tbSeriesCondition.Location = new Point(606, 29);
			this.tbSeriesCondition.Margin = new Padding(2, 3, 2, 3);
			this.tbSeriesCondition.MaxLength = 10;
			this.tbSeriesCondition.Name = "tbSeriesCondition";
			this.tbSeriesCondition.Size = new Size(77, 20);
			this.tbSeriesCondition.TabIndex = 112;
			this.tbSeriesCondition.Visible = false;
			this.tbSeriesCondition.KeyDown += new KeyEventHandler(this.tbSeriesCondition_KeyDown);
			this.tbSeriesCondition.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.tbSeriesCondition.Enter += new EventHandler(this.controlOrder_Enter);
			this.tbSeries.AllowDrop = true;
			this.tbSeries.BackColor = Color.FromArgb(224, 224, 224);
			this.tbSeries.BorderStyle = BorderStyle.FixedSingle;
			this.tbSeries.CharacterCasing = CharacterCasing.Upper;
			this.tbSeries.Location = new Point(160, 3);
			this.tbSeries.Margin = new Padding(2, 3, 2, 3);
			this.tbSeries.MaxLength = 32;
			this.tbSeries.Name = "tbSeries";
			this.tbSeries.Size = new Size(90, 20);
			this.tbSeries.TabIndex = 94;
			this.tbSeries.KeyDown += new KeyEventHandler(this.tbSeries_KeyDown);
			this.tbSeries.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.tbSeries.Enter += new EventHandler(this.controlOrder_Enter);
			this.chbTfexStopOrder.AutoSize = true;
			this.chbTfexStopOrder.ForeColor = Color.LightGray;
			this.chbTfexStopOrder.Location = new Point(528, 30);
			this.chbTfexStopOrder.Name = "chbTfexStopOrder";
			this.chbTfexStopOrder.Size = new Size(77, 17);
			this.chbTfexStopOrder.TabIndex = 100;
			this.chbTfexStopOrder.Text = "Stop Order";
			this.chbTfexStopOrder.UseVisualStyleBackColor = true;
			this.chbTfexStopOrder.CheckedChanged += new EventHandler(this.chbTfexStopOrder_CheckedChanged);
			this.tbPublishT.AllowDrop = true;
			this.tbPublishT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbPublishT.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbPublishT.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPublishT.BorderStyle = BorderStyle.FixedSingle;
			this.tbPublishT.CharacterCasing = CharacterCasing.Upper;
			this.tbPublishT.Location = new Point(580, 3);
			this.tbPublishT.Margin = new Padding(2, 3, 2, 3);
			this.tbPublishT.MaxLength = 12;
			this.tbPublishT.Name = "tbPublishT";
			this.tbPublishT.Size = new Size(70, 20);
			this.tbPublishT.TabIndex = 97;
			this.tbPublishT.KeyDown += new KeyEventHandler(this.tbPublishT_KeyDown);
			this.tbPublishT.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.tbPublishT.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbValidityT.AutoSize = true;
			this.lbValidityT.ForeColor = Color.LightGray;
			this.lbValidityT.Location = new Point(395, 32);
			this.lbValidityT.Margin = new Padding(2, 0, 2, 0);
			this.lbValidityT.Name = "lbValidityT";
			this.lbValidityT.Size = new Size(40, 13);
			this.lbValidityT.TabIndex = 106;
			this.lbValidityT.Text = "Validity";
			this.lbValidityT.TextAlign = ContentAlignment.MiddleLeft;
			this.tbVolumeT.AllowDrop = true;
			this.tbVolumeT.BackColor = Color.FromArgb(224, 224, 224);
			this.tbVolumeT.BorderStyle = BorderStyle.FixedSingle;
			this.tbVolumeT.Location = new Point(309, 3);
			this.tbVolumeT.Margin = new Padding(2, 3, 2, 3);
			this.tbVolumeT.MaxLength = 10;
			this.tbVolumeT.Name = "tbVolumeT";
			this.tbVolumeT.Size = new Size(70, 20);
			this.tbVolumeT.TabIndex = 95;
			this.tbVolumeT.TextChanged += new EventHandler(this.tbVolumeT_TextChanged);
			this.tbVolumeT.KeyDown += new KeyEventHandler(this.tbVolumeT_KeyDown);
			this.tbVolumeT.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.tbVolumeT.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbPriceTypeT.AutoSize = true;
			this.lbPriceTypeT.ForeColor = Color.LightGray;
			this.lbPriceTypeT.Location = new Point(261, 32);
			this.lbPriceTypeT.Margin = new Padding(2, 0, 2, 0);
			this.lbPriceTypeT.Name = "lbPriceTypeT";
			this.lbPriceTypeT.Size = new Size(31, 13);
			this.lbPriceTypeT.TabIndex = 110;
			this.lbPriceTypeT.Text = "Type";
			this.lbPriceTypeT.TextAlign = ContentAlignment.MiddleLeft;
			this.btnClearTextT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnClearTextT.BackColor = Color.Transparent;
			this.btnClearTextT.FlatAppearance.BorderColor = Color.DimGray;
			this.btnClearTextT.FlatStyle = FlatStyle.Flat;
			this.btnClearTextT.ForeColor = Color.WhiteSmoke;
			this.btnClearTextT.Image = Resources.side_noside;
			this.btnClearTextT.Location = new Point(737, 2);
			this.btnClearTextT.Margin = new Padding(2);
			this.btnClearTextT.MaximumSize = new Size(68, 27);
			this.btnClearTextT.Name = "btnClearTextT";
			this.btnClearTextT.Size = new Size(52, 22);
			this.btnClearTextT.TabIndex = 108;
			this.btnClearTextT.TabStop = false;
			this.btnClearTextT.Text = "Clear";
			this.btnClearTextT.UseVisualStyleBackColor = false;
			this.btnClearTextT.Click += new EventHandler(this.btnClearTextT_Click);
			this.lbPosition.AutoSize = true;
			this.lbPosition.ForeColor = Color.LightGray;
			this.lbPosition.Location = new Point(102, 32);
			this.lbPosition.Margin = new Padding(2, 0, 2, 0);
			this.lbPosition.Name = "lbPosition";
			this.lbPosition.Size = new Size(44, 13);
			this.lbPosition.TabIndex = 109;
			this.lbPosition.Text = "Position";
			this.lbPosition.TextAlign = ContentAlignment.MiddleLeft;
			this.btnSendOrderT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnSendOrderT.BackColor = Color.Transparent;
			this.btnSendOrderT.FlatAppearance.BorderColor = Color.DimGray;
			this.btnSendOrderT.FlatStyle = FlatStyle.Flat;
			this.btnSendOrderT.ForeColor = Color.WhiteSmoke;
			this.btnSendOrderT.Image = Resources.side_noside;
			this.btnSendOrderT.Location = new Point(661, 2);
			this.btnSendOrderT.Margin = new Padding(2);
			this.btnSendOrderT.MaximumSize = new Size(68, 27);
			this.btnSendOrderT.Name = "btnSendOrderT";
			this.btnSendOrderT.Size = new Size(52, 22);
			this.btnSendOrderT.TabIndex = 107;
			this.btnSendOrderT.TabStop = false;
			this.btnSendOrderT.Text = "Send";
			this.btnSendOrderT.UseVisualStyleBackColor = false;
			this.btnSendOrderT.Click += new EventHandler(this.btnSendOrderT_Click);
			this.lbPublishT.AutoSize = true;
			this.lbPublishT.ForeColor = Color.LightGray;
			this.lbPublishT.Location = new Point(528, 7);
			this.lbPublishT.Margin = new Padding(2, 0, 2, 0);
			this.lbPublishT.Name = "lbPublishT";
			this.lbPublishT.Size = new Size(43, 13);
			this.lbPublishT.TabIndex = 105;
			this.lbPublishT.Text = "Iceberg";
			this.lbPublishT.TextAlign = ContentAlignment.MiddleLeft;
			this.cbValidityT.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"IOC",
				"FOK"
			});
			this.cbValidityT.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbValidityT.BackColor = Color.FromArgb(224, 224, 224);
			this.cbValidityT.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbValidityT.FlatStyle = FlatStyle.Popup;
			this.cbValidityT.FormattingEnabled = true;
			this.cbValidityT.Items.AddRange(new object[]
			{
				"DAY",
				"FAK",
				"FOK"
			});
			this.cbValidityT.Location = new Point(444, 28);
			this.cbValidityT.Name = "cbValidityT";
			this.cbValidityT.Size = new Size(70, 21);
			this.cbValidityT.TabIndex = 99;
			this.cbValidityT.Leave += new EventHandler(this.controlOrderTFEX_Leave);
			this.cbValidityT.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbValidityT.KeyDown += new KeyEventHandler(this.cbValidity_KeyDown);
			this.lbPriceT.AutoSize = true;
			this.lbPriceT.ForeColor = Color.LightGray;
			this.lbPriceT.Location = new Point(395, 7);
			this.lbPriceT.Margin = new Padding(2, 0, 2, 0);
			this.lbPriceT.Name = "lbPriceT";
			this.lbPriceT.Size = new Size(31, 13);
			this.lbPriceT.TabIndex = 101;
			this.lbPriceT.Text = "Price";
			this.lbPriceT.TextAlign = ContentAlignment.MiddleLeft;
			this.cbPriceTypeT.AutoCompleteCustomSource.AddRange(new string[]
			{
				"",
				"IOC",
				"FOK"
			});
			this.cbPriceTypeT.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.cbPriceTypeT.BackColor = Color.FromArgb(224, 224, 224);
			this.cbPriceTypeT.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbPriceTypeT.FlatStyle = FlatStyle.Popup;
			this.cbPriceTypeT.FormattingEnabled = true;
			this.cbPriceTypeT.Items.AddRange(new object[]
			{
				"Limit",
				"MP",
				"MO",
				"ML"
			});
			this.cbPriceTypeT.Location = new Point(309, 28);
			this.cbPriceTypeT.Name = "cbPriceTypeT";
			this.cbPriceTypeT.Size = new Size(70, 21);
			this.cbPriceTypeT.TabIndex = 98;
			this.cbPriceTypeT.SelectedIndexChanged += new EventHandler(this.cbType_SelectedIndexChanged);
			this.cbPriceTypeT.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbPriceTypeT.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbPriceTypeT.KeyDown += new KeyEventHandler(this.cbType_KeyDown);
			this.lbVolumeT.AutoSize = true;
			this.lbVolumeT.ForeColor = Color.LightGray;
			this.lbVolumeT.Location = new Point(261, 7);
			this.lbVolumeT.Margin = new Padding(2, 0, 2, 0);
			this.lbVolumeT.Name = "lbVolumeT";
			this.lbVolumeT.Size = new Size(42, 13);
			this.lbVolumeT.TabIndex = 103;
			this.lbVolumeT.Text = "Volume";
			this.lbVolumeT.TextAlign = ContentAlignment.MiddleLeft;
			this.lbSeries.AutoSize = true;
			this.lbSeries.ForeColor = Color.LightGray;
			this.lbSeries.Location = new Point(110, 7);
			this.lbSeries.Margin = new Padding(2, 0, 2, 0);
			this.lbSeries.Name = "lbSeries";
			this.lbSeries.Size = new Size(41, 13);
			this.lbSeries.TabIndex = 102;
			this.lbSeries.Text = "Symbol";
			this.lbSeries.TextAlign = ContentAlignment.MiddleLeft;
			this.panelAutoTradeMM.BackColor = Color.FromArgb(30, 30, 30);
			this.panelAutoTradeMM.Controls.Add(this.panelMMPosition);
			this.panelAutoTradeMM.Controls.Add(this.btnMMShort);
			this.panelAutoTradeMM.Controls.Add(this.btnMMCover);
			this.panelAutoTradeMM.Controls.Add(this.tbMMStopPrice);
			this.panelAutoTradeMM.Controls.Add(this.cbMMPrice);
			this.panelAutoTradeMM.Controls.Add(this.lbMMPrice);
			this.panelAutoTradeMM.Controls.Add(this.lbMMTotalLoss);
			this.panelAutoTradeMM.Controls.Add(this.tbMMTotalLoss);
			this.panelAutoTradeMM.Controls.Add(this.btnMMSell);
			this.panelAutoTradeMM.Controls.Add(this.btnMMBuy);
			this.panelAutoTradeMM.Controls.Add(this.lbMMGiveUp);
			this.panelAutoTradeMM.Controls.Add(this.tbMMGiveUp);
			this.panelAutoTradeMM.Controls.Add(this.lbMMStopPrice);
			this.panelAutoTradeMM.Controls.Add(this.chbMMAutoStopLoss);
			this.panelAutoTradeMM.Controls.Add(this.cbMMStock);
			this.panelAutoTradeMM.Controls.Add(this.lbMMStock);
			this.panelAutoTradeMM.Controls.Add(this.btnMMClear);
			this.panelAutoTradeMM.Controls.Add(this.lbMMPin);
			this.panelAutoTradeMM.Controls.Add(this.tbMMPin);
			this.panelAutoTradeMM.Controls.Add(this.lbMMVolume);
			this.panelAutoTradeMM.Controls.Add(this.btnMMSend);
			this.panelAutoTradeMM.Controls.Add(this.tbMMVolume);
			this.panelAutoTradeMM.Location = new Point(3, 192);
			this.panelAutoTradeMM.Name = "panelAutoTradeMM";
			this.panelAutoTradeMM.Size = new Size(777, 58);
			this.panelAutoTradeMM.TabIndex = 84;
			this.panelAutoTradeMM.Visible = false;
			this.panelMMPosition.BackColor = Color.Transparent;
			this.panelMMPosition.BorderStyle = BorderStyle.FixedSingle;
			this.panelMMPosition.Controls.Add(this.rdbMMClosePos);
			this.panelMMPosition.Controls.Add(this.rdbMMOpenPos);
			this.panelMMPosition.Location = new Point(6, 27);
			this.panelMMPosition.Name = "panelMMPosition";
			this.panelMMPosition.Size = new Size(110, 23);
			this.panelMMPosition.TabIndex = 127;
			this.panelMMPosition.Visible = false;
			this.rdbMMClosePos.AutoSize = true;
			this.rdbMMClosePos.ForeColor = Color.LightGray;
			this.rdbMMClosePos.Location = new Point(56, 1);
			this.rdbMMClosePos.Name = "rdbMMClosePos";
			this.rdbMMClosePos.Size = new Size(51, 17);
			this.rdbMMClosePos.TabIndex = 117;
			this.rdbMMClosePos.TabStop = true;
			this.rdbMMClosePos.Text = "Close";
			this.rdbMMClosePos.UseVisualStyleBackColor = true;
			this.rdbMMClosePos.CheckedChanged += new EventHandler(this.rdbMMClosePos_CheckedChanged);
			this.rdbMMOpenPos.AutoSize = true;
			this.rdbMMOpenPos.ForeColor = Color.LightGray;
			this.rdbMMOpenPos.Location = new Point(4, 1);
			this.rdbMMOpenPos.Name = "rdbMMOpenPos";
			this.rdbMMOpenPos.Size = new Size(51, 17);
			this.rdbMMOpenPos.TabIndex = 116;
			this.rdbMMOpenPos.TabStop = true;
			this.rdbMMOpenPos.Text = "Open";
			this.rdbMMOpenPos.UseVisualStyleBackColor = true;
			this.rdbMMOpenPos.CheckedChanged += new EventHandler(this.rdbMMOpenPos_CheckedChanged);
			this.btnMMShort.AutoEllipsis = true;
			this.btnMMShort.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMMShort.BackColor = Color.Transparent;
			this.btnMMShort.Cursor = Cursors.Hand;
			this.btnMMShort.FlatAppearance.BorderColor = Color.DimGray;
			this.btnMMShort.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMMShort.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnMMShort.FlatStyle = FlatStyle.Flat;
			this.btnMMShort.ForeColor = Color.WhiteSmoke;
			this.btnMMShort.Image = Resources.side_noside;
			this.btnMMShort.Location = new Point(64, 28);
			this.btnMMShort.MaximumSize = new Size(58, 23);
			this.btnMMShort.Name = "btnMMShort";
			this.btnMMShort.Size = new Size(52, 22);
			this.btnMMShort.TabIndex = 126;
			this.btnMMShort.TabStop = false;
			this.btnMMShort.Text = "Short";
			this.btnMMShort.UseVisualStyleBackColor = false;
			this.btnMMShort.Visible = false;
			this.btnMMShort.Click += new EventHandler(this.btnMMSide_Click);
			this.btnMMCover.AutoEllipsis = true;
			this.btnMMCover.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMMCover.BackColor = Color.Transparent;
			this.btnMMCover.Cursor = Cursors.Hand;
			this.btnMMCover.FlatAppearance.BorderColor = Color.DimGray;
			this.btnMMCover.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMMCover.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnMMCover.FlatStyle = FlatStyle.Flat;
			this.btnMMCover.ForeColor = Color.WhiteSmoke;
			this.btnMMCover.Image = Resources.side_noside;
			this.btnMMCover.Location = new Point(6, 28);
			this.btnMMCover.MaximumSize = new Size(58, 23);
			this.btnMMCover.Name = "btnMMCover";
			this.btnMMCover.Size = new Size(52, 22);
			this.btnMMCover.TabIndex = 125;
			this.btnMMCover.TabStop = false;
			this.btnMMCover.Text = "Cover";
			this.btnMMCover.UseVisualStyleBackColor = false;
			this.btnMMCover.Visible = false;
			this.btnMMCover.Click += new EventHandler(this.btnMMSide_Click);
			this.tbMMStopPrice.AllowDrop = true;
			this.tbMMStopPrice.BackColor = Color.FromArgb(224, 224, 224);
			this.tbMMStopPrice.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMStopPrice.Location = new Point(437, 4);
			this.tbMMStopPrice.Margin = new Padding(2, 3, 2, 3);
			this.tbMMStopPrice.MaxLength = 10;
			this.tbMMStopPrice.Name = "tbMMStopPrice";
			this.tbMMStopPrice.Size = new Size(63, 20);
			this.tbMMStopPrice.TabIndex = 124;
			this.tbMMStopPrice.TextChanged += new EventHandler(this.tbMMStopPrice_TextChanged);
			this.tbMMStopPrice.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.tbMMStopPrice.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbMMStopPrice.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbMMPrice.AllowDrop = true;
			this.cbMMPrice.BackColor = Color.FromArgb(224, 224, 224);
			this.cbMMPrice.BorderStyle = BorderStyle.FixedSingle;
			this.cbMMPrice.ForeColor = Color.Black;
			this.cbMMPrice.Location = new Point(305, 4);
			this.cbMMPrice.Name = "cbMMPrice";
			this.cbMMPrice.Size = new Size(64, 20);
			this.cbMMPrice.TabIndex = 122;
			this.cbMMPrice.TextChanged += new EventHandler(this.cbMMPrice_TextChanged);
			this.cbMMPrice.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.cbMMPrice.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbMMPrice.KeyPress += new KeyPressEventHandler(this.cbMMPrice_KeyPress);
			this.cbMMPrice.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbMMPrice.AutoSize = true;
			this.lbMMPrice.ForeColor = Color.WhiteSmoke;
			this.lbMMPrice.Location = new Point(273, 8);
			this.lbMMPrice.Margin = new Padding(2, 0, 2, 0);
			this.lbMMPrice.Name = "lbMMPrice";
			this.lbMMPrice.Size = new Size(31, 13);
			this.lbMMPrice.TabIndex = 123;
			this.lbMMPrice.Text = "Price";
			this.lbMMPrice.TextAlign = ContentAlignment.MiddleLeft;
			this.lbMMTotalLoss.AutoSize = true;
			this.lbMMTotalLoss.ForeColor = Color.LightGray;
			this.lbMMTotalLoss.Location = new Point(377, 32);
			this.lbMMTotalLoss.Margin = new Padding(2, 0, 2, 0);
			this.lbMMTotalLoss.Name = "lbMMTotalLoss";
			this.lbMMTotalLoss.Size = new Size(57, 13);
			this.lbMMTotalLoss.TabIndex = 121;
			this.lbMMTotalLoss.Text = "Loss(Baht)";
			this.lbMMTotalLoss.TextAlign = ContentAlignment.MiddleLeft;
			this.tbMMTotalLoss.AllowDrop = true;
			this.tbMMTotalLoss.BackColor = Color.FromArgb(64, 64, 64);
			this.tbMMTotalLoss.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMTotalLoss.ForeColor = Color.FromArgb(255, 128, 128);
			this.tbMMTotalLoss.Location = new Point(437, 28);
			this.tbMMTotalLoss.Margin = new Padding(2, 3, 2, 3);
			this.tbMMTotalLoss.MaxLength = 10;
			this.tbMMTotalLoss.Name = "tbMMTotalLoss";
			this.tbMMTotalLoss.ReadOnly = true;
			this.tbMMTotalLoss.Size = new Size(63, 20);
			this.tbMMTotalLoss.TabIndex = 120;
			this.tbMMTotalLoss.Text = "0";
			this.tbMMTotalLoss.TextAlign = HorizontalAlignment.Center;
			this.btnMMSell.AutoEllipsis = true;
			this.btnMMSell.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMMSell.BackColor = Color.Transparent;
			this.btnMMSell.Cursor = Cursors.Hand;
			this.btnMMSell.FlatAppearance.BorderColor = Color.DimGray;
			this.btnMMSell.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMMSell.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnMMSell.FlatStyle = FlatStyle.Flat;
			this.btnMMSell.ForeColor = Color.WhiteSmoke;
			this.btnMMSell.Image = Resources.side_noside;
			this.btnMMSell.Location = new Point(64, 3);
			this.btnMMSell.MaximumSize = new Size(58, 23);
			this.btnMMSell.Name = "btnMMSell";
			this.btnMMSell.Size = new Size(52, 22);
			this.btnMMSell.TabIndex = 119;
			this.btnMMSell.TabStop = false;
			this.btnMMSell.Text = "Sell";
			this.btnMMSell.UseVisualStyleBackColor = false;
			this.btnMMSell.Click += new EventHandler(this.btnMMSide_Click);
			this.btnMMBuy.AutoEllipsis = true;
			this.btnMMBuy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMMBuy.BackColor = Color.Transparent;
			this.btnMMBuy.Cursor = Cursors.Hand;
			this.btnMMBuy.FlatAppearance.BorderColor = Color.DimGray;
			this.btnMMBuy.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMMBuy.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnMMBuy.FlatStyle = FlatStyle.Flat;
			this.btnMMBuy.ForeColor = Color.WhiteSmoke;
			this.btnMMBuy.Image = Resources.side_noside;
			this.btnMMBuy.Location = new Point(6, 3);
			this.btnMMBuy.MaximumSize = new Size(58, 23);
			this.btnMMBuy.Name = "btnMMBuy";
			this.btnMMBuy.Size = new Size(52, 22);
			this.btnMMBuy.TabIndex = 118;
			this.btnMMBuy.TabStop = false;
			this.btnMMBuy.Text = "Buy";
			this.btnMMBuy.UseVisualStyleBackColor = false;
			this.btnMMBuy.Click += new EventHandler(this.btnMMSide_Click);
			this.lbMMGiveUp.AutoSize = true;
			this.lbMMGiveUp.ForeColor = Color.LightGray;
			this.lbMMGiveUp.Location = new Point(509, 8);
			this.lbMMGiveUp.Margin = new Padding(2, 0, 2, 0);
			this.lbMMGiveUp.Name = "lbMMGiveUp";
			this.lbMMGiveUp.Size = new Size(52, 13);
			this.lbMMGiveUp.TabIndex = 117;
			this.lbMMGiveUp.Text = "%Give up";
			this.lbMMGiveUp.TextAlign = ContentAlignment.MiddleLeft;
			this.tbMMGiveUp.AllowDrop = true;
			this.tbMMGiveUp.BackColor = Color.FromArgb(224, 224, 224);
			this.tbMMGiveUp.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMGiveUp.Location = new Point(562, 4);
			this.tbMMGiveUp.Margin = new Padding(2, 3, 2, 3);
			this.tbMMGiveUp.MaxLength = 10;
			this.tbMMGiveUp.Name = "tbMMGiveUp";
			this.tbMMGiveUp.Size = new Size(42, 20);
			this.tbMMGiveUp.TabIndex = 116;
			this.tbMMGiveUp.TextChanged += new EventHandler(this.tbMMGiveUp_TextChanged);
			this.tbMMGiveUp.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.tbMMGiveUp.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbMMGiveUp.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbMMStopPrice.AutoSize = true;
			this.lbMMStopPrice.ForeColor = Color.WhiteSmoke;
			this.lbMMStopPrice.Location = new Point(378, 8);
			this.lbMMStopPrice.Margin = new Padding(2, 0, 2, 0);
			this.lbMMStopPrice.Name = "lbMMStopPrice";
			this.lbMMStopPrice.Size = new Size(56, 13);
			this.lbMMStopPrice.TabIndex = 115;
			this.lbMMStopPrice.Text = "Stop Price";
			this.lbMMStopPrice.TextAlign = ContentAlignment.MiddleLeft;
			this.chbMMAutoStopLoss.AutoSize = true;
			this.chbMMAutoStopLoss.ForeColor = Color.FromArgb(255, 192, 128);
			this.chbMMAutoStopLoss.Location = new Point(512, 30);
			this.chbMMAutoStopLoss.Margin = new Padding(2, 3, 0, 3);
			this.chbMMAutoStopLoss.Name = "chbMMAutoStopLoss";
			this.chbMMAutoStopLoss.Size = new Size(98, 17);
			this.chbMMAutoStopLoss.TabIndex = 106;
			this.chbMMAutoStopLoss.Text = "Auto Stop Loss";
			this.chbMMAutoStopLoss.UseVisualStyleBackColor = false;
			this.chbMMAutoStopLoss.CheckedChanged += new EventHandler(this.chbMMAutoStopLoss_CheckedChanged);
			this.cbMMStock.AllowDrop = true;
			this.cbMMStock.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cbMMStock.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbMMStock.BackColor = Color.FromArgb(224, 224, 224);
			this.cbMMStock.FlatStyle = FlatStyle.Popup;
			this.cbMMStock.ForeColor = Color.Black;
			this.cbMMStock.FormattingEnabled = true;
			this.cbMMStock.Location = new Point(174, 4);
			this.cbMMStock.MaxLength = 20;
			this.cbMMStock.Name = "cbMMStock";
			this.cbMMStock.Size = new Size(90, 21);
			this.cbMMStock.TabIndex = 0;
			this.cbMMStock.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbMMStock.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbMMStock.KeyPress += new KeyPressEventHandler(this.cbStock_KeyPress);
			this.cbMMStock.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.lbMMStock.AutoSize = true;
			this.lbMMStock.ForeColor = Color.LightGray;
			this.lbMMStock.Location = new Point(130, 8);
			this.lbMMStock.Margin = new Padding(2, 0, 2, 0);
			this.lbMMStock.Name = "lbMMStock";
			this.lbMMStock.Size = new Size(41, 13);
			this.lbMMStock.TabIndex = 100;
			this.lbMMStock.Text = "Symbol";
			this.lbMMStock.TextAlign = ContentAlignment.MiddleLeft;
			this.btnMMClear.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnMMClear.AutoEllipsis = true;
			this.btnMMClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMMClear.BackColor = Color.Transparent;
			this.btnMMClear.Cursor = Cursors.Hand;
			this.btnMMClear.FlatAppearance.BorderColor = Color.DimGray;
			this.btnMMClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMMClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnMMClear.FlatStyle = FlatStyle.Flat;
			this.btnMMClear.ForeColor = Color.WhiteSmoke;
			this.btnMMClear.Image = Resources.side_noside;
			this.btnMMClear.Location = new Point(716, 27);
			this.btnMMClear.MaximumSize = new Size(58, 23);
			this.btnMMClear.Name = "btnMMClear";
			this.btnMMClear.Size = new Size(52, 22);
			this.btnMMClear.TabIndex = 9;
			this.btnMMClear.TabStop = false;
			this.btnMMClear.Text = "Clear";
			this.btnMMClear.UseVisualStyleBackColor = false;
			this.btnMMClear.Click += new EventHandler(this.btnMMClear_Click);
			this.lbMMPin.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lbMMPin.AutoSize = true;
			this.lbMMPin.ForeColor = Color.LightGray;
			this.lbMMPin.Location = new Point(699, 8);
			this.lbMMPin.Margin = new Padding(2, 0, 2, 0);
			this.lbMMPin.Name = "lbMMPin";
			this.lbMMPin.Size = new Size(25, 13);
			this.lbMMPin.TabIndex = 90;
			this.lbMMPin.Text = "PIN";
			this.lbMMPin.TextAlign = ContentAlignment.MiddleLeft;
			this.tbMMPin.AllowDrop = true;
			this.tbMMPin.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.tbMMPin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbMMPin.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbMMPin.BackColor = Color.FromArgb(224, 224, 224);
			this.tbMMPin.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMPin.CharacterCasing = CharacterCasing.Upper;
			this.tbMMPin.Location = new Point(728, 4);
			this.tbMMPin.Margin = new Padding(2, 3, 2, 3);
			this.tbMMPin.MaxLength = 10;
			this.tbMMPin.Name = "tbMMPin";
			this.tbMMPin.PasswordChar = '*';
			this.tbMMPin.Size = new Size(40, 20);
			this.tbMMPin.TabIndex = 7;
			this.tbMMPin.KeyDown += new KeyEventHandler(this.panelAutoTradeMM_KeyDown);
			this.tbMMPin.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbMMPin.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbMMVolume.AutoSize = true;
			this.lbMMVolume.ForeColor = Color.LightGray;
			this.lbMMVolume.Location = new Point(129, 32);
			this.lbMMVolume.Margin = new Padding(2, 0, 2, 0);
			this.lbMMVolume.Name = "lbMMVolume";
			this.lbMMVolume.Size = new Size(42, 13);
			this.lbMMVolume.TabIndex = 11;
			this.lbMMVolume.Text = "Volume";
			this.lbMMVolume.TextAlign = ContentAlignment.MiddleLeft;
			this.btnMMSend.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnMMSend.AutoEllipsis = true;
			this.btnMMSend.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnMMSend.BackColor = Color.Transparent;
			this.btnMMSend.Cursor = Cursors.Hand;
			this.btnMMSend.FlatAppearance.BorderColor = Color.DimGray;
			this.btnMMSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnMMSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnMMSend.FlatStyle = FlatStyle.Flat;
			this.btnMMSend.ForeColor = Color.WhiteSmoke;
			this.btnMMSend.Image = Resources.side_noside;
			this.btnMMSend.Location = new Point(657, 27);
			this.btnMMSend.MaximumSize = new Size(58, 23);
			this.btnMMSend.Name = "btnMMSend";
			this.btnMMSend.Size = new Size(52, 22);
			this.btnMMSend.TabIndex = 8;
			this.btnMMSend.TabStop = false;
			this.btnMMSend.Text = "Send";
			this.btnMMSend.UseVisualStyleBackColor = false;
			this.btnMMSend.Click += new EventHandler(this.btnMMSend_Click);
			this.tbMMVolume.AllowDrop = true;
			this.tbMMVolume.BackColor = Color.FromArgb(64, 64, 64);
			this.tbMMVolume.BorderStyle = BorderStyle.FixedSingle;
			this.tbMMVolume.ForeColor = Color.Cyan;
			this.tbMMVolume.Location = new Point(174, 28);
			this.tbMMVolume.Margin = new Padding(2, 3, 2, 3);
			this.tbMMVolume.MaxLength = 10;
			this.tbMMVolume.Name = "tbMMVolume";
			this.tbMMVolume.ReadOnly = true;
			this.tbMMVolume.Size = new Size(90, 20);
			this.tbMMVolume.TabIndex = 2;
			this.tbMMVolume.Text = "0";
			this.tbMMVolume.TextAlign = HorizontalAlignment.Center;
			this.AllowDrop = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.Controls.Add(this.panelTop);
			base.Controls.Add(this.panelAutoTradeMM);
			base.Controls.Add(this.panelDerivative);
			base.Controls.Add(this.panelEquity);
			base.Controls.Add(this.lbLoading);
			this.ForeColor = Color.Black;
			base.Margin = new Padding(0);
			base.Name = "ucSendNewOrder";
			base.Size = new Size(898, 314);
			base.Leave += new EventHandler(this.ucSendNewOrder_Leave);
			base.Enter += new EventHandler(this.ucSendNewOrder_Enter);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.panelEquity.ResumeLayout(false);
			this.panelEquity.PerformLayout();
			this.panelDerivative.ResumeLayout(false);
			this.panelDerivative.PerformLayout();
			this.panelTfexPosition.ResumeLayout(false);
			this.panelTfexPosition.PerformLayout();
			this.panelAutoTradeMM.ResumeLayout(false);
			this.panelAutoTradeMM.PerformLayout();
			this.panelMMPosition.ResumeLayout(false);
			this.panelMMPosition.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06000BCF RID: 3023 RVA: 0x000D937C File Offset: 0x000D777C
		// (remove) Token: 0x06000BD0 RID: 3024 RVA: 0x000D93A4 File Offset: 0x000D77A4
		public event ucSendNewOrder.OnAccountChangedHandler OnAccountChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnAccountChanged = (ucSendNewOrder.OnAccountChangedHandler)Delegate.Combine(this.OnAccountChanged, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnAccountChanged = (ucSendNewOrder.OnAccountChangedHandler)Delegate.Remove(this.OnAccountChanged, value);
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06000BD1 RID: 3025 RVA: 0x000D93CC File Offset: 0x000D77CC
		// (remove) Token: 0x06000BD2 RID: 3026 RVA: 0x000D93F4 File Offset: 0x000D77F4
		public event ucSendNewOrder.OnBoxStyleChangedHandler OnBoxStyleChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnBoxStyleChanged = (ucSendNewOrder.OnBoxStyleChangedHandler)Delegate.Combine(this.OnBoxStyleChanged, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnBoxStyleChanged = (ucSendNewOrder.OnBoxStyleChangedHandler)Delegate.Remove(this.OnBoxStyleChanged, value);
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06000BD3 RID: 3027 RVA: 0x000D941C File Offset: 0x000D781C
		// (remove) Token: 0x06000BD4 RID: 3028 RVA: 0x000D9444 File Offset: 0x000D7844
		public event ucSendNewOrder.OnResizedHandler OnResized
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnResized = (ucSendNewOrder.OnResizedHandler)Delegate.Combine(this.OnResized, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnResized = (ucSendNewOrder.OnResizedHandler)Delegate.Remove(this.OnResized, value);
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000BD5 RID: 3029 RVA: 0x000D946C File Offset: 0x000D786C
		// (remove) Token: 0x06000BD6 RID: 3030 RVA: 0x000D9494 File Offset: 0x000D7894
		public event ucSendNewOrder.OnResizeUpDownHandler OnResizeUpDown
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnResizeUpDown = (ucSendNewOrder.OnResizeUpDownHandler)Delegate.Combine(this.OnResizeUpDown, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnResizeUpDown = (ucSendNewOrder.OnResizeUpDownHandler)Delegate.Remove(this.OnResizeUpDown, value);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x000D94BC File Offset: 0x000D78BC
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x000D94E8 File Offset: 0x000D78E8
		public bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._isActive;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._isActive = value;
				if (!base.DesignMode)
				{
					try
					{
						if (value)
						{
							if (Settings.Default.BottomStyleEquity == 5 && ApplicationInfo.AutoTradeType <= 0)
							{
								Settings.Default.BottomStyleEquity = 2;
							}
							this._lastEquityStyle = Settings.Default.BottomStyleEquity;
							this._lastTfexStyle = Settings.Default.BottomStyleTfex;
							this._buyCreditLimit = 0m;
							this._totalCreditLimit = 0m;
							this.lbBuyLimit.Text = "Buy Limit :";
							this.tbBuyLimit.Text = "0";
							this.cbSide.Items.Clear();
							this.cbSide.Items.Add("Buy");
							this.cbSide.Items.Add("Sell");
							if (ApplicationInfo.SuuportSBL == "Y")
							{
								this.cbSide.Items.Add("Cover");
								this.cbSide.Items.Add("Short");
							}
							this.timerSwitchAccount.Stop();
							this.timerSwitchAccount.Start();
							ApplicationInfo.OnPincodeChanged -= new ApplicationInfo.OnPincodeChangedCompleteHandler(this.ApplicationInfo_OnPincodeChanged);
							ApplicationInfo.OnPincodeChanged += new ApplicationInfo.OnPincodeChangedCompleteHandler(this.ApplicationInfo_OnPincodeChanged);
						}
					}
					catch (Exception ex)
					{
						this.ShowError("UcSendOrder:IsActive", ex);
					}
				}
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000D96AC File Offset: 0x000D7AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ucSendNewOrder() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwReloadCredit = null;
			this.bgwSendOrder = null;
			this.bgwGetEquity = null;
			this._tdsCredit = null;
			this._stockInfo = null;
			this._seriesInfoTfex = null;
			this._returnOrderNumberFromServer = 0L;
			this.timerReloadCredit = null;
			this.timerSwitchAccount = null;
			this.tmCloseSplash = null;
			this._buyCreditLimit = 0m;
			this._totalCreditLimit = 0m;
			this._creditType = 0;
			this._isActive = false;
			this._showSide = string.Empty;
			this._showSideTFEX = string.Empty;
			this._frmConfirm = null;
			this._frmStopDisclaimer = null;
			this._pcPriceAlertForm = null;
			this.alertSettingForm = null;
			this._objLastActive = null;
			this._OrdTimes = 0;
			this._currTimes = 0;
			this._retOrderMessage = string.Empty;
			this._commandType = string.Empty;
			this._OrdSymbol = string.Empty;
			this._OrdSide = string.Empty;
			this._OrdVolume = 0L;
			this._OrdPrice = string.Empty;
			this._OrdPubVol = 0L;
			this._OrdCondition = string.Empty;
			this._OrdIsDeposit = string.Empty;
			this._OrdAutoStopLoss = false;
			this._OrdStopPrice = 0m;
			this._OrdPriceType = string.Empty;
			this._OrdPosition = string.Empty;
			this._OrdValidityDate = string.Empty;
			this._OrdTfexStopPrice = string.Empty;
			this._OrdTfexStopSeries = string.Empty;
			this._OrdTfexStopCond = string.Empty;
			this._verifyResult_Pin = false;
			this._verifyResultStr_Pin = string.Empty;
			this._verifyResult = false;
			this._verifyParam = false;
			this._dsSendOrder = null;
			this._dsSendOrderTfex = null;
			this._newOrderResult = null;
			this._portStockEquity = 0m;
			this._portTfexEquity = 0m;
			this._onhand = 0L;
			this._lastEquityStyle = 1;
			this._lastTfexStyle = 1;
			this._isLockPubVol = false;
			
			this.InitializeComponent();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			base.UpdateStyles();
			try
			{
				if (!base.DesignMode)
				{
					this._showSide = "";
					this.bgwReloadCredit = new BackgroundWorker();
					this.bgwReloadCredit.WorkerReportsProgress = true;
					this.bgwReloadCredit.DoWork += new DoWorkEventHandler(this.bgwReloadCredit_DoWork);
					this.bgwReloadCredit.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadCredit_RunWorkerCompleted);
					this.bgwSendOrder = new BackgroundWorker();
					this.bgwSendOrder.WorkerReportsProgress = true;
					this.bgwSendOrder.DoWork += new DoWorkEventHandler(this.bgwSendOrder_DoWork);
					this.bgwSendOrder.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwSendOrder_RunWorkerCompleted);
					this.bgwGetEquity = new BackgroundWorker();
					this.bgwGetEquity.WorkerReportsProgress = true;
					this.bgwGetEquity.DoWork += new DoWorkEventHandler(this.bgwGetEquity_DoWork);
					this.bgwGetEquity.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwGetEquity_RunWorkerCompleted);
				}
				if (this.timerSwitchAccount == null)
				{
					this.timerSwitchAccount = new System.Windows.Forms.Timer();
					this.timerSwitchAccount.Interval = 300;
					this.timerSwitchAccount.Tick -= new EventHandler(this.timerSwitchAccount_Tick);
					this.timerSwitchAccount.Tick += new EventHandler(this.timerSwitchAccount_Tick);
				}
				this.timerSwitchAccount.Enabled = false;
				this.cbDepCollateral.Items.Add("");
				this.cbDepCollateral.Items.Add("Deposit");
				if (ApplicationInfo.SupportCollateral == "Y")
				{
					this.cbDepCollateral.Items.Add("Collateral");
				}
				this.panelEquity.Visible = false;
				this.panelAutoTradeMM.Visible = false;
				foreach (Control control in this.panelEquity.Controls)
				{
					control.Visible = false;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SendOrderBox.Constructor", ex);
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000D9B4C File Offset: 0x000D7F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitAccount()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.cbAccount.InvokeRequired)
			{
				this.cbAccount.Invoke(new MethodInvoker(this.InitAccount));
			}
			else
			{
				try
				{
					if (this.cbStock.AutoCompleteCustomSource != null)
					{
						if (this.cbStock.AutoCompleteCustomSource.Count == 0 && ApplicationInfo.StockAutoComp != null)
						{
							this.cbStock.AutoCompleteMode = AutoCompleteMode.Suggest;
							this.cbStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
							this.cbStock.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
						}
					}
					if (this.cbMMStock.AutoCompleteCustomSource != null)
					{
						if (this.cbMMStock.AutoCompleteCustomSource.Count == 0 && ApplicationInfo.StockAutoComp != null)
						{
							this.cbMMStock.AutoCompleteMode = AutoCompleteMode.Suggest;
							this.cbMMStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
							if (ApplicationInfo.IsSupportTfex)
							{
								this.cbMMStock.AutoCompleteCustomSource = ApplicationInfo.MultiAutoComp;
							}
							else
							{
								this.cbMMStock.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
							}
						}
					}
					if (ApplicationInfo.IsSupportTfex)
					{
						if (this.tbSeries.AutoCompleteCustomSource != null)
						{
							if (this.tbSeries.AutoCompleteCustomSource.Count == 0 && ApplicationInfo.SeriesAutoComp != null)
							{
								this.tbSeries.AutoCompleteMode = AutoCompleteMode.Suggest;
								this.tbSeries.AutoCompleteSource = AutoCompleteSource.CustomSource;
								this.tbSeries.AutoCompleteCustomSource = ApplicationInfo.SeriesAutoComp;
							}
						}
						if (this.tbSeriesCondition.AutoCompleteCustomSource != null)
						{
							if (this.tbSeriesCondition.AutoCompleteCustomSource.Count == 0 && ApplicationInfo.SeriesAutoComp != null)
							{
								this.tbSeriesCondition.AutoCompleteMode = AutoCompleteMode.Suggest;
								this.tbSeriesCondition.AutoCompleteSource = AutoCompleteSource.CustomSource;
								this.tbSeriesCondition.AutoCompleteCustomSource = ApplicationInfo.SeriesAutoComp;
							}
						}
					}
					this.cbAccount.Items.Clear();
					if (ApplicationInfo.AccInfo.Items.Count > 0)
					{
						foreach (KeyValuePair<string, AccountInfo.ItemInfo> current in ApplicationInfo.AccInfo.Items)
						{
							string str = string.Empty;
							if (current.Value.Market == "E")
							{
								str = "Equity";
							}
							else if (current.Value.Market == "T")
							{
								str = "Derivative";
							}
							this.cbAccount.Items.Add(current.Key + " (" + str + ")");
						}
						this.cbAccount.SelectedIndex = 0;
						ApplicationInfo.AccInfo.CurrentAccount = this.GetAccount(this.cbAccount.Text.Trim());
						if (ApplicationInfo.AccInfo.Items.ContainsKey(ApplicationInfo.AccInfo.CurrentAccount))
						{
							string market = ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].Market;
							if (market == "E")
							{
								ApplicationInfo.IsEquityAccount = true;
							}
							else if (market == "T")
							{
								ApplicationInfo.IsEquityAccount = false;
							}
						}
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000D9FA0 File Offset: 0x000D83A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetResize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.panelTop.Hide();
				this.panelEquity.Visible = false;
				this.panelDerivative.Visible = false;
				this.panelAutoTradeMM.Visible = false;
				Font default_Font = Settings.Default.Default_Font;
				if (!this.Font.Equals(default_Font))
				{
					this.Font = default_Font;
					this.panelTop.Font = default_Font;
				}
				int num = 5;
				int num2 = num + 3;
				this.chbNVDR.TabIndex = 2;
				if (ApplicationInfo.IsEquityAccount)
				{
					if (Settings.Default.BottomStyleEquity != 5)
					{
						if (Settings.Default.BottomStyleEquity == 1)
						{
							this.lbSide.Left = 5;
							this.lbSide.Top = num2;
							this.cbSide.Top = num - 1;
							this.cbSide.Left = this.lbSide.Right + 3;
							this.lbStock.Left = this.cbSide.Right + 5;
							this.lbStock.Top = num2;
							this.cbStock.Left = this.lbStock.Right + 1;
							this.cbStock.Top = num - 1;
							this.chbNVDR.Location = new Point(this.cbStock.Right + 5, num + 2);
							this.lbVolume.Left = this.chbNVDR.Right + 5;
							this.tbVolume.Left = this.lbVolume.Right + 1;
							this.lbVolume.Top = num2;
							this.tbVolume.Top = num;
							if (ApplicationInfo.SupportOrderTimes)
							{
								this.lbTimes.Top = num2;
								this.tbTimes.Top = num;
								this.lbTimes.Left = this.tbVolume.Right + 4;
								this.tbTimes.Left = this.lbTimes.Right + 1;
								this.lbPrice.Left = this.tbTimes.Right + 4;
								this.cbPrice.Left = this.lbPrice.Right + 1;
							}
							else
							{
								this.lbPrice.Left = this.tbVolume.Right + 4;
								this.cbPrice.Left = this.lbPrice.Right + 1;
							}
							this.lbPrice.Top = num2;
							this.cbPrice.Top = num - 1;
							int num3 = this.cbPrice.Right + 4 + this.lbPublic.Width + 4 + this.tbPublic.Width + 4 + this.lbCondition.Width + 4 + this.cbCondition.Width + 1 + this.lbPin.Width + 15 + this.tbPin.Width + 1 + this.btnSendOrder.Width + 10 + this.btnClear.Width + 10;
							if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
							{
								num3 += this.lbDep.Width + 4 + this.cbDepCollateral.Width + 4;
							}
							if (num3 < base.Width)
							{
								this.lbPublic.Location = new Point(this.cbPrice.Right + 4, num2);
								this.tbPublic.Location = new Point(this.lbPublic.Right + 4, num);
								this.lbCondition.Location = new Point(this.tbPublic.Right + 4, num2);
								this.cbCondition.Location = new Point(this.lbCondition.Right + 1, num - 1);
								if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
								{
									this.lbDep.Location = new Point(this.cbCondition.Right + 7, num2);
									this.cbDepCollateral.Location = new Point(this.lbDep.Right + 4, num - 1);
									this.lbPin.Location = new Point(this.cbDepCollateral.Right + 15, num2);
									this.tbPin.Location = new Point(this.lbPin.Right + 1, num);
								}
								else
								{
									this.lbPin.Location = new Point(this.cbCondition.Right + 15, num2);
									this.tbPin.Location = new Point(this.lbPin.Right + 1, num);
								}
								this.btnSendOrder.Location = new Point(this.tbPin.Right + 10, num - 2);
								this.btnClear.Location = new Point(this.btnSendOrder.Right + 10, num - 2);
							}
							else
							{
								this.lbPublic.Location = new Point(this.lbVolume.Left, this.tbVolume.Bottom + 8);
								this.tbPublic.Location = new Point(this.tbVolume.Left, this.tbVolume.Bottom + 6);
								this.lbCondition.Location = new Point(this.lbTimes.Left, this.lbPublic.Top);
								this.cbCondition.Location = new Point(this.tbTimes.Left, this.tbPublic.Top);
								if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
								{
									this.lbDep.Location = new Point(this.lbPrice.Left, this.lbPublic.Top);
									this.cbDepCollateral.Location = new Point(this.cbPrice.Left, this.tbPublic.Top);
								}
								this.lbPin.Location = new Point(this.cbPrice.Right + 15, num2);
								this.tbPin.Location = new Point(this.lbPin.Right + 1, num);
								this.btnSendOrder.Location = new Point(this.tbPin.Right + 10, num - 2);
								this.btnClear.Location = new Point(this.btnSendOrder.Right + 10, num - 2);
							}
						}
						else if (Settings.Default.BottomStyleEquity == 2)
						{
							this.rbBuy.Location = new Point(5, num + 1);
							this.rbSell.Location = new Point(this.rbBuy.Right + 2, this.rbSell.Top = num + 1);
							if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
							{
								this.rbShort.Location = new Point(this.rbSell.Right + 2, num + 1);
								this.rbCover.Location = new Point(this.rbShort.Right + 2, num + 1);
								this.lbStock.Location = new Point(this.rbCover.Right + 5, num2);
							}
							else
							{
								this.lbStock.Location = new Point(this.rbSell.Right + 5, num2);
							}
							this.cbStock.Location = new Point(this.lbStock.Right + 5, num - 1);
							this.lbVolume.Location = new Point(this.cbStock.Right + 10, num2);
							this.btnVolDec.Location = new Point(this.lbVolume.Right + 3, num + 1);
							this.tbVolume.Location = new Point(this.btnVolDec.Right + 2, num);
							this.btnVolInc.Location = new Point(this.tbVolume.Right + 2, num + 1);
							this.lbPrice.Location = new Point(this.btnVolInc.Right + 10, num2);
							this.btnPriceDec.Location = new Point(this.lbPrice.Right + 2, num + 1);
							this.cbPrice.Location = new Point(this.btnPriceDec.Right + 1, num - 1);
							this.btnPriceInc.Location = new Point(this.cbPrice.Right + 2, num + 1);
							this.lbPin.Location = new Point(this.btnPriceInc.Right + 15, num2);
							this.tbPin.Location = new Point(this.lbPin.Right + 1, num);
							this.btnSendOrder.Location = new Point(this.tbPin.Right + 10, num - 2);
							this.btnClear.Location = new Point(this.btnSendOrder.Right + 5, num - 2);
						}
						else if (Settings.Default.BottomStyleEquity == 3)
						{
							this.rbBuy.Location = new Point(5, num + 1);
							this.rbSell.Location = new Point(this.rbBuy.Right + 15, this.rbBuy.Top);
							this.rbShort.Location = new Point(this.rbSell.Left, num + this.rbBuy.Height + 5);
							this.rbCover.Location = new Point(this.rbBuy.Left, this.rbShort.Top);
							this.cbStock.Location = new Point(this.rbSell.Right + 10, num);
							this.chbNVDR.Location = new Point(this.cbStock.Right + 6, num + 1);
							this.lbVolume.Location = new Point(this.chbNVDR.Right + 10, num2);
							this.btnVolDec.Location = new Point(this.lbVolume.Right + 2, num + 1);
							this.tbVolume.Location = new Point(this.btnVolDec.Right + 1, num);
							this.btnVolInc.Location = new Point(this.tbVolume.Right + 1, num + 1);
							this.lbPublic.Location = new Point(this.lbVolume.Right - this.lbPublic.Width, num2 + this.lbVolume.Height + 12);
							this.btnPBDec.Location = new Point(this.btnVolDec.Left, num + this.lbVolume.Height + 13);
							this.tbPublic.Location = new Point(this.tbVolume.Left, num + this.lbVolume.Height + 12);
							this.btnPBInc.Location = new Point(this.btnVolInc.Left, num + this.lbVolume.Height + 13);
							this.lbPrice.Location = new Point(this.btnVolInc.Right + 15, num2);
							this.btnPriceDec.Location = new Point(this.lbPrice.Right + 2, num + 1);
							this.cbPrice.Location = new Point(this.btnPriceDec.Right + 1, num - 1);
							this.btnPriceInc.Location = new Point(this.cbPrice.Right + 1, num + 1);
							this.lbCondition.Left = this.lbPrice.Left;
							this.lbCondition.Top = this.lbPublic.Top;
							this.cbCondition.Left = this.cbPrice.Left;
							this.cbCondition.Top = this.tbPublic.Top;
							this.lbDep.Top = num2;
							this.cbDepCollateral.Top = num - 1;
							if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
							{
								this.lbDep.Left = this.btnPriceInc.Right + 7;
								this.cbDepCollateral.Left = this.lbDep.Right + 2;
								this.lbPin.Left = this.cbDepCollateral.Right + 10;
								this.btnSendOrder.Left = this.cbDepCollateral.Right + 10;
							}
							else
							{
								this.lbPin.Left = this.btnPriceInc.Right + 10;
							}
							this.lbPin.Top = num2;
							this.tbPin.Top = num;
							this.tbPin.Left = this.lbPin.Right + 2;
							this.btnSendOrder.Left = this.tbPin.Right + 10;
							this.btnSendOrder.Top = num - 2;
							this.btnClear.Left = this.btnSendOrder.Right + 5;
							this.btnClear.Top = num - 2;
						}
						else if (Settings.Default.BottomStyleEquity == 4)
						{
							this.rbBuy.Left = 5;
							this.rbBuy.Top = num + 1;
							this.rbSell.Left = this.rbBuy.Right + 2;
							this.rbSell.Top = num + 1;
							this.rbShort.Top = num + 1;
							this.rbCover.Top = num + 1;
							if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
							{
								this.rbShort.Left = this.rbSell.Right + 2;
								this.rbCover.Left = this.rbShort.Right + 2;
								this.lbStock.Left = this.rbCover.Right + 5;
							}
							else
							{
								this.lbStock.Left = this.rbSell.Right + 5;
							}
							this.lbStock.Top = num2;
							this.cbStock.Left = this.lbStock.Right + 5;
							this.cbStock.Top = num - 1;
							this.lbVolume.Left = this.cbStock.Right + 10;
							this.lbVolume.Top = num2;
							this.tbVolume.Left = this.lbVolume.Right + 2;
							this.tbVolume.Top = num;
							this.lbPrice.Left = this.tbVolume.Right + 10;
							this.lbPrice.Top = num2;
							this.cbPrice.Left = this.lbPrice.Right + 1;
							this.cbPrice.Top = num - 1;
							this.lbCondition.Left = this.cbPrice.Right + 5;
							this.lbCondition.Top = num2;
							this.cbCondition.Left = this.lbCondition.Right + 5;
							this.cbCondition.Top = num - 1;
							this.chbNVDR.Left = this.cbCondition.Right + 10;
							this.chbNVDR.Top = num + 2;
							this.lbPin.Left = this.chbNVDR.Right + 10;
							this.lbPin.Top = num2;
							this.tbPin.Left = this.lbPin.Right + 1;
							this.tbPin.Top = num;
							this.btnSendOrder.Left = this.tbPin.Right + 10;
							this.btnSendOrder.Top = num - 2;
							this.btnClear.Left = this.btnSendOrder.Right + 5;
							this.btnClear.Top = num - 2;
							this.chbNVDR.TabIndex = 6;
						}
						this.tbTimes.Enabled = true;
						this.cbDepCollateral.Enabled = true;
					}
				}
				else if (Settings.Default.BottomStyleEquity != 5)
				{
					this.rdbTfexBuy.Location = new Point(5, num);
					this.rdbTfexSell.Location = new Point(this.rdbTfexBuy.Right + 5, num);
					this.lbSeries.Location = new Point(this.rdbTfexSell.Right + 5, num2);
					this.tbSeries.Location = new Point(this.lbSeries.Right + 5, num);
					this.lbVolumeT.Location = new Point(this.tbSeries.Right + 5, num2);
					this.tbVolumeT.Location = new Point(this.lbVolumeT.Right + 5, num);
					this.lbPriceT.Location = new Point(this.tbVolumeT.Right + 17, num2);
					this.tbPriceT.Location = new Point(this.lbPriceT.Right + 5, num);
					this.lbPublishT.Location = new Point(this.tbPriceT.Right + 5, num2);
					this.tbPublishT.Location = new Point(this.lbPublishT.Right + 5, num);
					if (Settings.Default.BottomStyleEquity == 1)
					{
						int y = this.btnSendOrderT.Bottom + 7;
						int y2 = this.btnSendOrderT.Bottom + 5;
						this.lbPosition.Location = new Point(this.lbSeries.Right - this.lbPosition.Width, y);
						this.cbPosition.Location = new Point(this.tbSeries.Left, y2);
						this.lbPriceTypeT.Location = new Point(this.lbVolumeT.Right - this.lbPriceTypeT.Width, y);
						this.cbPriceTypeT.Location = new Point(this.tbVolumeT.Left, y2);
						this.lbValidityT.Location = new Point(this.lbPriceT.Right - this.lbValidityT.Width, y);
						this.cbValidityT.Location = new Point(this.tbPriceT.Left, y2);
						this.chbTfexStopOrder.Location = new Point(this.cbValidityT.Right + 10, y);
						this.tbSeriesCondition.Location = new Point(this.chbTfexStopOrder.Right + 5, y);
						this.cbTfexConStopOrder.Location = new Point(this.tbSeriesCondition.Right + 5, y2);
						this.tbTfexPriceCondition.Location = new Point(this.cbTfexConStopOrder.Right + 5, y);
						this.btnSendOrderT.Location = new Point(this.tbPublishT.Right + 20, num - 1);
						this.btnClearTextT.Location = new Point(this.btnSendOrderT.Right + 5, num - 1);
					}
					else
					{
						int y = this.btnSendOrderT.Bottom + 7;
						int y2 = this.btnSendOrderT.Bottom + 5;
						this.lbPosition.Location = new Point(this.lbSeries.Right - this.lbPosition.Width, y);
						this.panelTfexPosition.Location = new Point(this.tbSeries.Left, this.tbSeries.Bottom + 4);
						this.btnSendOrderT.Location = new Point(this.tbPriceT.Right + 20, num - 1);
						this.btnClearTextT.Location = new Point(this.btnSendOrderT.Right + 5, num - 1);
					}
				}
				int num4 = this.cbAccount.Height + 5;
				this.panelTop.SetBounds(0, 0, base.Parent.Width, num4);
				this.cbAccount.Left = this.lbAccount.Right + 2;
				this.lbBuyLimit.Left = this.cbAccount.Right + 10;
				this.tbBuyLimit.Left = this.lbBuyLimit.Right + 4;
				this.lbOnHand.Left = this.tbBuyLimit.Right + 10;
				this.tbOnHand.Left = this.lbOnHand.Right + 4;
				this.lbEquity.Left = this.tbOnHand.Right + 10;
				this.tbEquity.Left = this.lbEquity.Right + 4;
				int num5 = this.btnClear.Height + 4;
				if (ApplicationInfo.IsEquityAccount)
				{
					if (Settings.Default.BottomStyleEquity == 5)
					{
						num5 = num4 + this.btnMMSend.Bounds.Bottom + 3;
						this.panelAutoTradeMM.SetBounds(0, this.panelTop.Bottom, base.Parent.Width, num5);
					}
					else
					{
						if (Settings.Default.BottomStyleEquity == 2 || Settings.Default.BottomStyleEquity == 4)
						{
							num5 += this.panelTop.Height + 2;
						}
						else
						{
							num5 = num4 + this.tbPublic.Bottom + 6;
						}
						this.panelEquity.SetBounds(0, this.panelTop.Bottom, base.Parent.Width, num5 - num4);
					}
				}
				else if (Settings.Default.BottomStyleEquity == 5)
				{
					num5 = num4 + this.btnMMSend.Bounds.Bottom + 3;
					this.panelAutoTradeMM.SetBounds(0, this.panelTop.Bottom, base.Parent.Width, num5);
				}
				else if (Settings.Default.BottomStyleEquity == 1)
				{
					this.panelDerivative.SetBounds(0, this.panelTop.Bottom, base.Parent.Width, this.cbValidityT.Bottom + 5);
					num5 = this.panelDerivative.Bottom;
				}
				else
				{
					this.panelDerivative.SetBounds(0, this.panelTop.Bottom, base.Parent.Width, this.panelTfexPosition.Bottom + 4);
					num5 = this.panelDerivative.Bottom;
				}
				if (ApplicationInfo.IsEquityAccount)
				{
					this.btnSetting.Left = base.Parent.Width - this.btnSetting.Width - 5;
					this.btnStyleMM.Left = this.btnSetting.Left - this.btnStyleMM.Width - 5;
					this.btnStyle4.Left = this.btnStyleMM.Left - this.btnStyle4.Width - 5;
					this.btnStyle3.Left = this.btnStyle4.Left - this.btnStyle3.Width - 5;
					this.btnStyle2.Left = this.btnStyle3.Left - this.btnStyle2.Width - 5;
					this.btnStyle1.Left = this.btnStyle2.Left - this.btnStyle1.Width - 5;
				}
				else
				{
					this.btnStyleMM.Left = base.Parent.Width - this.btnStyleMM.Width - 10;
					this.btnStyle2.Left = this.btnStyleMM.Left - this.btnStyle1.Width - 5;
					this.btnStyle1.Left = this.btnStyle2.Left - this.btnStyle1.Width - 5;
				}
				this.btnCleanPort.Left = this.btnStyle1.Left - this.btnCleanPort.Width - 5;
				this.btnShowStockAlert.Left = this.btnCleanPort.Left - this.btnShowStockAlert.Width - 5;
				this.btnNotification.Left = this.btnShowStockAlert.Left - this.btnNotification.Width - 5;
				if (base.Height != num5)
				{
					base.Height = num5;
					if (this.OnResized != null)
					{
						this.OnResized();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetResize", ex);
			}
			finally
			{
				this.panelTop.Show();
				if (ApplicationInfo.IsEquityAccount)
				{
					if (Settings.Default.BottomStyleEquity == 5)
					{
						this.panelAutoTradeMM.Show();
					}
					else if (!this.panelEquity.Visible)
					{
						this.panelEquity.Show();
					}
				}
				else if (Settings.Default.BottomStyleEquity == 5)
				{
					this.panelAutoTradeMM.Show();
				}
				else
				{
					this.panelDerivative.Show();
				}
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000DBB34 File Offset: 0x000D9F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFormActivate(string side)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
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
				if (ApplicationInfo.IsEquityAccount)
				{
					if (this.SetColorBySide(side))
					{
						if (Settings.Default.BSBoxDefaultStock)
						{
							if (this.cbStock.Text == string.Empty)
							{
								this.SetCurrentSymbol(ApplicationInfo.CurrentSymbol);
							}
						}
						this.ShowCreditValueEquity();
						if (Settings.Default.BottomStyleEquity == 5)
						{
							this.SetVisibleControlEquity();
							this.cbMMStock.Focus();
						}
						else
						{
							this.cbStock.Focus();
						}
					}
				}
				else
				{
					this.DoClear();
					if (side == "B" || side == "S")
					{
						this._showSideTFEX = ((side == "B") ? "L" : side);
					}
					else if (side == "C")
					{
						this.cbPosition.Text = "CLOSE";
						this.rdbTfexClosePos.Checked = true;
					}
					else if (side == "H")
					{
						this.cbPosition.Text = "OPEN";
						this.rdbTfexOpenPos.Checked = true;
					}
					this.SetColorBySide(this._showSideTFEX);
					if (Settings.Default.BSBoxDefaultStock)
					{
						if (this.tbSeries.Text == string.Empty)
						{
							this.SetCurrentSymbol(ApplicationInfo.CurrentSymbol);
						}
					}
					this.tbSeries.Focus();
					this.tbSeries.SelectAll();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000DBD8C File Offset: 0x000DA18C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisposeMe()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._isActive = false;
				if (this.timerReloadCredit != null)
				{
					this.timerReloadCredit.Stop();
					this.timerReloadCredit = null;
				}
				if (this.tmCloseSplash != null)
				{
					this.tmCloseSplash.Stop();
					this.tmCloseSplash = null;
				}
				if (this.timerSwitchAccount != null)
				{
					this.timerSwitchAccount.Stop();
					this.timerSwitchAccount = null;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("DisposeMe", ex);
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x000DBE4C File Offset: 0x000DA24C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSendOrder_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.AccInfo.UserInternetInBroker == "Y")
				{
					this.ShowMessageInFormConfirm("Internal user not authenrize!", frmOrderFormConfirm.OpenStyle.ShowBox);
				}
				else
				{
					this.VerifyParam();
					if (this._verifyParam)
					{
						if (!this.bgwSendOrder.IsBusy)
						{
							this._commandType = "V";
							this.btnSendOrder.Enabled = false;
							this.bgwSendOrder.RunWorkerAsync();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnSendOrder_Click", ex);
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000DBF18 File Offset: 0x000DA318
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnClear_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._frmConfirm != null)
				{
					this._frmConfirm.CloseMe();
				}
				this.DoClear();
				this.cbStock.Focus();
			}
			catch (Exception ex)
			{
				this.ShowError("btnClear_Click", ex);
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000DBF90 File Offset: 0x000DA390
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPincodeForNewOrder_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Right)
			{
				this.btnSendOrder.Focus();
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000DBFE4 File Offset: 0x000DA3E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbVolume_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbVolume.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbVolume.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbVolume.Text.Replace(",", ""));
							this.tbVolume.Text = num.ToString("#,###");
							this.tbVolume.Select(this.tbVolume.Text.Length, 0);
							this._isLockPubVol = true;
							this.tbPublic.Text = this.tbVolume.Text;
						}
						catch
						{
							this.tbVolume.Text = this.tbVolume.Text.Substring(0, this.tbVolume.Text.Length - 1);
						}
					}
					else
					{
						this.tbVolume.Text = this.tbVolume.Text.Substring(0, this.tbVolume.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbVolume_TextChanged", ex);
			}
			this._isLockPubVol = false;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000DC188 File Offset: 0x000DA588
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbVolume_DragDrop(object sender, DragEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			DragItemData dragItemData = (DragItemData)e.Data.GetData(typeof(DragItemData).ToString());
			this.tbVolume.Text = dragItemData.DragText;
			this.tbVolume.Focus();
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000DC1E4 File Offset: 0x000DA5E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbVolume_DragEnter(object sender, DragEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.Effect = DragDropEffects.Move;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000DC200 File Offset: 0x000DA600
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPrice_DragEnter(object sender, DragEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.Effect = DragDropEffects.Move;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000DC21C File Offset: 0x000DA61C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPrice_DragDrop(object sender, DragEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			DragItemData dragItemData = (DragItemData)e.Data.GetData(typeof(DragItemData).ToString());
			this.cbPrice.Text = dragItemData.DragText;
			this.cbPrice.Focus();
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000DC278 File Offset: 0x000DA678
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo)
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
					if (!(messageType == "0G"))
					{
						if (!(messageType == "0B"))
						{
							if (!(messageType == "0I"))
							{
								if (messageType == "SC")
								{
									if (ApplicationInfo.MarketState == "R")
									{
										if (this._frmConfirm != null)
										{
											this._frmConfirm.CloseMe();
										}
									}
								}
							}
							else
							{
								OrderInfoClient orderInfoClient = (OrderInfoClient)message;
								if (orderInfoClient.Account == ApplicationInfo.AccInfo.CurrentAccount)
								{
									this.StartTimerLoadCredit();
									ApplicationInfo.RemoveOrderNoFromAutoRefreshList(orderInfoClient.OrderNumber.ToString(), orderInfoClient.RefId);
									if (ApplicationInfo.SupportFreewill && (orderInfoClient.RefId == "R" + this._returnOrderNumberFromServer.ToString() || orderInfoClient.RefId == "OFFLINE"))
									{
										this._returnOrderNumberFromServer = -1L;
										if (ApplicationInfo.SupportOrderTimes)
										{
											if (this._currTimes + 1 <= this._OrdTimes)
											{
												this._currTimes++;
												Thread thread = new Thread(new ThreadStart(this.threadSendTimes));
												thread.Start();
											}
											else if (this._frmConfirm != null)
											{
												this._frmConfirm.CloseMe();
											}
										}
										else if (this._frmConfirm != null)
										{
											this._frmConfirm.CloseMe();
										}
									}
								}
							}
						}
						else if (ApplicationInfo.SupportFreewill)
						{
							BroadCastOrderMessageClient broadCastOrderMessageClient = (BroadCastOrderMessageClient)message;
							if (ApplicationInfo.CanReceiveMessage(broadCastOrderMessageClient.EntryID))
							{
								ApplicationInfo.RemoveOrderNoFromAutoRefreshList("", broadCastOrderMessageClient.Reserve2);
								this.ShowMessageInFormConfirm(broadCastOrderMessageClient.Content, frmOrderFormConfirm.OpenStyle.Error);
							}
						}
					}
					else
					{
						this.ReceiveDGWReplyMessage(message);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SendOrder:ReceiveMessage", ex);
			}
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000DC51C File Offset: 0x000DA91C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo)
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
					if (messageType == "#T9I")
					{
						OrderTFEXInfoClient orderTFEXInfoClient = (OrderTFEXInfoClient)message;
						if (orderTFEXInfoClient.Account == ApplicationInfo.AccInfo.CurrentAccount)
						{
							this.StartTimerLoadCredit();
							ApplicationInfo.RemoveOrderNoFromAutoRefreshList_TFEX(orderTFEXInfoClient.OrderNumber.ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SendOrder:ReceiveTFEXMessage", ex);
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000DC5D0 File Offset: 0x000DA9D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReceiveDGWReplyMessage(IBroadcastMessage message)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				DGWOrderReplyMessage dGWOrderReplyMessage = (DGWOrderReplyMessage)message;
				if (dGWOrderReplyMessage.OrderNumber == this._returnOrderNumberFromServer)
				{
					this.ShowMessageInFormConfirm(string.Concat(new object[]
					{
						"Reject Order Number ",
						dGWOrderReplyMessage.OrderNumber,
						"\nReject Code : ",
						dGWOrderReplyMessage.ReplyCode,
						"\nReject Description : ",
						dGWOrderReplyMessage.ReplyMessage
					}), frmOrderFormConfirm.OpenStyle.ShowBox);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ReceiveDGWReplyMessage", ex);
			}
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000DC688 File Offset: 0x000DAA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartTimerLoadCredit()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (base.InvokeRequired)
				{
					base.Invoke(new MethodInvoker(this.StartTimerLoadCredit));
				}
				else
				{
					if (this.timerReloadCredit == null)
					{
						this.timerReloadCredit = new System.Windows.Forms.Timer();
						this.timerReloadCredit.Interval = 1000;
						this.timerReloadCredit.Tick -= new EventHandler(this.timerReloadCredit_Tick);
						this.timerReloadCredit.Tick += new EventHandler(this.timerReloadCredit_Tick);
					}
					this.timerReloadCredit.Enabled = false;
					this.timerReloadCredit.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("StartTimerLoadCredit", ex);
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000DC778 File Offset: 0x000DAB78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerReloadCredit_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timerReloadCredit.Enabled = false;
				if (!this.bgwReloadCredit.IsBusy)
				{
					this.bgwReloadCredit.RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("timerReloadCredit_Tick", ex);
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000DC7EC File Offset: 0x000DABEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadCredit_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!string.IsNullOrEmpty(ApplicationInfo.AccInfo.CurrentAccount))
				{
					string text = string.Empty;
					if (ApplicationInfo.IsEquityAccount)
					{
						if (ApplicationInfo.SupportFreewill)
						{
							text = ApplicationInfo.WebOrderService.ViewCustomerCreditOnSendBox_Freewill(ApplicationInfo.AccInfo.CurrentAccount, ApplicationInfo.AccInfo.CurrentAccountType, (this._stockInfo != null) ? this._stockInfo.Symbol : string.Empty);
						}
						else
						{
							text = ApplicationInfo.WebOrderService.ViewCustomerCreditOnSendBox(ApplicationInfo.AccInfo.CurrentAccount, (this._stockInfo != null) ? this._stockInfo.Symbol : string.Empty);
						}
					}
					else
					{
						text = ApplicationInfo.WebServiceTFEX.ViewCustomerCreditOnSendBox(ApplicationInfo.AccInfo.CurrentAccount, (this._seriesInfoTfex != null) ? this._seriesInfoTfex.Symbol : string.Empty);
					}
					if (this._tdsCredit != null)
					{
						this._tdsCredit.Clear();
						this._tdsCredit = null;
					}
					this._tdsCredit = new DataSet();
					if (!string.IsNullOrEmpty(text))
					{
						MyDataHelper.StringToDataSet(text, this._tdsCredit);
					}
				}
				else
				{
					this.ShowError("RequestWebData", new Exception("Current Account is null"));
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_DoWork", ex);
			}
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000DC998 File Offset: 0x000DAD98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadCredit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					this._creditType = 0;
					this._buyCreditLimit = 0m;
					this._totalCreditLimit = 0m;
					if (this._tdsCredit != null && this._tdsCredit.Tables.Contains("CUSTOMER_CREDIT") && this._tdsCredit.Tables["CUSTOMER_CREDIT"].Rows.Count > 0)
					{
						DataRow dataRow = this._tdsCredit.Tables["CUSTOMER_CREDIT"].Rows[0];
						int.TryParse(dataRow["credit_type"].ToString(), out this._creditType);
						if (dataRow.Table.Columns.Contains("buy_credit_limit"))
						{
							decimal.TryParse(dataRow["buy_credit_limit"].ToString(), out this._buyCreditLimit);
							this._totalCreditLimit = this._buyCreditLimit;
						}
					}
					else
					{
						this._creditType = 0;
						this._buyCreditLimit = 0m;
						this._totalCreditLimit = 0m;
					}
					this.ShowCreditValueEquity();
				}
				else
				{
					if (this._tdsCredit != null && this._tdsCredit.Tables.Contains("ITDSD_Get_Cust_Info") && this._tdsCredit.Tables["ITDSD_Get_Cust_Info"].Rows.Count > 0)
					{
						DataRow dataRow2 = this._tdsCredit.Tables["ITDSD_Get_Cust_Info"].Rows[0];
						this.tbBuyLimit.Text = Utilities.PriceFormat(dataRow2["BuyLimit"].ToString(), 0, "0");
						this.tbOnHand.Text = Utilities.PriceFormat(dataRow2["EE"].ToString(), 0, "0");
						decimal.TryParse(dataRow2["LiquidationValue"].ToString(), out this._portTfexEquity);
						this.tbEquity.Text = Utilities.PriceFormat(this._portTfexEquity, 0, "0");
						this.GetOnHand();
					}
					else
					{
						this.tbBuyLimit.Text = "-";
						this.tbOnHand.Text = "-";
						this.tbEquity.Text = "-";
					}
					this.tbBuyLimit.Left = this.lbBuyLimit.Right + 4;
					this.lbOnHand.Left = this.tbBuyLimit.Right + 10;
					this.tbOnHand.Left = this.lbOnHand.Right + 4;
					this.lbEquity.Left = this.tbOnHand.Right + 10;
					this.tbEquity.Left = this.lbEquity.Right + 4;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000DCCF8 File Offset: 0x000DB0F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowCreditValueEquity()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.ShowCreditValueEquity));
			}
			else
			{
				try
				{
					string str = string.Empty;
					string text = string.Empty;
					switch (this._creditType)
					{
					case 0:
					case 1:
					case 2:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
						if (ApplicationInfo.AccInfo.CurrentAccountType == "C" || ApplicationInfo.AccInfo.CurrentAccountType == "H" || ApplicationInfo.AccInfo.CurrentAccountType == "I" || ApplicationInfo.AccInfo.CurrentAccountType == "" || ApplicationInfo.AccInfo.CurrentAccountType == "D")
						{
							str = "Buy Limit";
							text = this._buyCreditLimit.ToString("#,##0");
						}
						else
						{
							str = "PP";
							if (ApplicationInfo.SupportFreewill)
							{
								text = this._buyCreditLimit.ToString("#,##0");
							}
							else
							{
								text = (this._buyCreditLimit / ApplicationInfo.UserMarginRate * 100m).ToString("#,##0");
							}
						}
						break;
					case 3:
						str = "Total Limit";
						text = this._totalCreditLimit.ToString("#,##0");
						break;
					}
					this.lbBuyLimit.Text = str + " : ";
					this.tbBuyLimit.Left = this.lbBuyLimit.Right + 4;
					this.tbBuyLimit.Text = text;
					this.lbOnHand.Left = this.tbBuyLimit.Right + 10;
					this.tbOnHand.Left = this.lbOnHand.Right + 4;
					this.tbOnHand.Text = this.GetOnHand().ToString("#,##0");
				}
				catch (Exception ex)
				{
					this.ShowError("ShowCreditValue", ex);
				}
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000DCF74 File Offset: 0x000DB374
		[MethodImpl(MethodImplOptions.NoInlining)]
		private long GetOnHand()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (ApplicationInfo.IsEquityAccount)
			{
				if (this._tdsCredit != null && this._tdsCredit.Tables.Contains("STOCK_POSITION") && this._tdsCredit.Tables["STOCK_POSITION"].Rows.Count > 0)
				{
					bool flag = false;
					string text = string.Empty;
					if (Settings.Default.BottomStyleEquity != 5)
					{
						flag = this.chbNVDR.Checked;
						text = this.cbDepCollateral.Text;
					}
					string b = "0";
					if (flag)
					{
						b = "2";
					}
					string b2 = string.Empty;
					if (text.ToLower() == "deposit")
					{
						b2 = "D";
					}
					else if (text.ToLower() == "collateral")
					{
						b2 = "C";
					}
					else if (this._showSide == "H")
					{
						b2 = "B";
					}
					else if (this._showSide == "C")
					{
						b2 = "S";
					}
					this._onhand = 0L;
					foreach (DataRow dataRow in this._tdsCredit.Tables["STOCK_POSITION"].Rows)
					{
						if (dataRow["trustee_id"].ToString().Trim() == b && dataRow["position_type"].ToString().Trim() == b2)
						{
							long.TryParse(dataRow["onhand"].ToString(), out this._onhand);
							break;
						}
					}
				}
				else
				{
					this._onhand = 0L;
				}
			}
			else
			{
				this._onhand = 0L;
				if (this._tdsCredit != null && this._tdsCredit.Tables.Contains("ITDSD_Get_Cust_Posi") && this._tdsCredit.Tables["ITDSD_Get_Cust_Posi"].Rows.Count > 0)
				{
					long.TryParse(this._tdsCredit.Tables["ITDSD_Get_Cust_Posi"].Rows[0]["CurrentQty"].ToString(), out this._onhand);
				}
			}
			return this._onhand;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000DD2A8 File Offset: 0x000DB6A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void calculateMMVolume()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					if (this._showSide == "B" || this._showSide == "H")
					{
						decimal num = 0m;
						decimal num2 = 0m;
						decimal num3 = 0m;
						decimal.TryParse(this.tbMMStopPrice.Text, out num);
						decimal.TryParse(this.tbMMGiveUp.Text, out num2);
						decimal.TryParse(this.cbMMPrice.Text, out num3);
						long num4 = 0L;
						decimal d = 0m;
						if (num2 > 0m)
						{
							d = this._portStockEquity * num2 / 100m;
							if (this._showSide == "B")
							{
								if (num3 > num)
								{
									num4 = (long)(d / (num3 - num));
								}
							}
							else if (num > num3)
							{
								num4 = (long)(d / (num - num3));
							}
							if (num4 > 0L)
							{
								decimal d2 = num4 * num3;
								decimal userCommVAT = ApplicationInfo.UserCommVAT;
								d2 += d2 * userCommVAT;
								if (d2 > this._buyCreditLimit)
								{
									d2 = this._buyCreditLimit - this._buyCreditLimit * userCommVAT;
									num4 = (long)(d2 / num3);
								}
								num4 -= num4 % (long)this._stockInfo.BoardLot;
								d = num4 * Math.Abs(num3 - num);
							}
							else
							{
								num4 = 0L;
								d = 0m;
							}
						}
						this.tbMMTotalLoss.Text = d.ToString("#,##0");
						this.tbMMVolume.Text = num4.ToString("#,##0");
					}
					else if (this._showSide == "S" || this._showSide == "C")
					{
						long num4 = 0L;
						decimal num5 = 0m;
						if (decimal.TryParse(this.tbMMGiveUp.Text, out num5))
						{
							if (num5 > 100m)
							{
								num5 = 100m;
								this.tbMMGiveUp.Text = "100";
								this.tbMMGiveUp.SelectAll();
							}
							num4 = (long)(this._onhand * num5 / 100m);
							num4 -= num4 % (long)this._stockInfo.BoardLot;
						}
						this.tbMMVolume.Text = num4.ToString("#,##0");
					}
				}
				else if (this.rdbMMOpenPos.Checked)
				{
					decimal num = 0m;
					decimal num2 = 0m;
					decimal num3 = 0m;
					decimal.TryParse(this.tbMMStopPrice.Text, out num);
					decimal.TryParse(this.tbMMGiveUp.Text, out num2);
					decimal.TryParse(this.cbMMPrice.Text, out num3);
					long num4 = 0L;
					decimal d = 0m;
					if (num2 > 0m)
					{
						d = this._portTfexEquity * num2 / 100m;
						if (this._showSideTFEX == "L")
						{
							if (num3 > num)
							{
								num4 = (long)(d / ((num3 - num) * this._seriesInfoTfex.ContractSize));
							}
						}
						else if (num > num3)
						{
							num4 = (long)(d / ((num - num3) * this._seriesInfoTfex.ContractSize));
						}
						if (num4 > 0L)
						{
							decimal d2 = num4 * num3;
							decimal userCommVAT = ApplicationInfo.UserCommVAT;
							d2 += d2 * userCommVAT;
							if (d2 > this._portTfexEquity)
							{
								d2 = this._portTfexEquity - this._portTfexEquity * userCommVAT;
								num4 = (long)(d2 / num3);
							}
							d = num4 * (Math.Abs(num3 - num) * this._seriesInfoTfex.ContractSize);
						}
						else
						{
							num4 = 0L;
							d = 0m;
						}
					}
					this.tbMMTotalLoss.Text = d.ToString("#,##0");
					this.tbMMVolume.Text = num4.ToString("#,##0");
				}
				else if (this.rdbMMClosePos.Checked)
				{
					long num4 = 0L;
					decimal num5 = 0m;
					if (decimal.TryParse(this.tbMMGiveUp.Text, out num5))
					{
						if (num5 > 100m)
						{
							num5 = 100m;
							this.tbMMGiveUp.Text = "100";
							this.tbMMGiveUp.SelectAll();
						}
						num4 = (long)(this._onhand * num5 / 100m);
					}
					this.tbMMVolume.Text = num4.ToString("#,##0");
				}
			}
			catch (Exception ex)
			{
				this.ShowError("calculateMMVolume", ex);
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000DD91C File Offset: 0x000DBD1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwGetEquity_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string result = string.Empty;
				if (ApplicationInfo.IsEquityAccount)
				{
					result = ApplicationInfo.WebOrderService.GetPortEquity(ApplicationInfo.AccInfo.CurrentAccount, ApplicationInfo.AccInfo.CurrentAccountType);
				}
				else
				{
					result = string.Empty;
				}
				e.Result = result;
			}
			catch (Exception ex)
			{
				this.ShowError("bgwGetEquity_DoWork", ex);
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000DD9AC File Offset: 0x000DBDAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwGetEquity_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Error == null)
				{
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(e.Result.ToString(), dataSet);
						if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
						{
							int num = -1;
							int.TryParse(dataSet.Tables["Results"].Rows[0]["code"].ToString(), out num);
							if (num == 0)
							{
								decimal.TryParse(dataSet.Tables["Results"].Rows[0]["message"].ToString(), out this._portStockEquity);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwGetEquity_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000DDB20 File Offset: 0x000DBF20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle, Control lastObject)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._objLastActive = lastObject;
			this.ShowMessageInFormConfirm(message, openStyle);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000DDB44 File Offset: 0x000DBF44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucSendNewOrder.ShowMessageInFormConfirmCallBack(this.ShowMessageInFormConfirm), new object[]
				{
					message,
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
					this._frmConfirm = new frmOrderFormConfirm(message, openStyle);
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.Parent = base.Parent.Parent;
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

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000DDD00 File Offset: 0x000DC100
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowOrderFormConfirm(string message, string orderParam, string ossWarning, string stockTH)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucSendNewOrder.ShowOrderFormConfirmCallBack(this.ShowOrderFormConfirm), new object[]
				{
					message,
					orderParam,
					ossWarning,
					stockTH
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
					this._frmConfirm = new frmOrderFormConfirm(message, frmOrderFormConfirm.OpenStyle.ConfirmSendNew);
					this._frmConfirm.FormClosing -= new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.FormClosing += new FormClosingEventHandler(this.frmConfirm_FormClosing);
					this._frmConfirm.TopLevel = false;
					this._frmConfirm.OssMessage = ossWarning;
					this._frmConfirm.StockThreshold = stockTH;
					this._frmConfirm.OrderParam = orderParam;
					this._frmConfirm.Parent = base.Parent.Parent;
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

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000DDEE8 File Offset: 0x000DC2E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowStopDisclaimer()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucSendNewOrder.ShowStopDisclaimerCallBack(this.ShowStopDisclaimer));
			}
			else
			{
				try
				{
					if (this._frmStopDisclaimer != null)
					{
						if (!this._frmStopDisclaimer.IsDisposed)
						{
							this._frmStopDisclaimer.Dispose();
						}
						this._frmStopDisclaimer = null;
					}
					this._frmStopDisclaimer = new frmStopDisclaimer(false);
					this._frmStopDisclaimer.FormClosing -= new FormClosingEventHandler(this.frmStopDisclaimer_FormClosing);
					this._frmStopDisclaimer.FormClosing += new FormClosingEventHandler(this.frmStopDisclaimer_FormClosing);
					this._frmStopDisclaimer.TopLevel = false;
					this._frmStopDisclaimer.Parent = base.Parent.Parent;
					this._frmStopDisclaimer.Location = new Point((this._frmStopDisclaimer.Parent.Width - this._frmStopDisclaimer.Width) / 2, (this._frmStopDisclaimer.Parent.Height - this._frmStopDisclaimer.Height) / 2);
					this._frmStopDisclaimer.TopMost = true;
					this._frmStopDisclaimer.Show();
					this._frmStopDisclaimer.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("ShowStopDisclaimer", ex);
				}
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000DE074 File Offset: 0x000DC474
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStopDisclaimer_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				base.Focus();
				if (ApplicationInfo.IsAutoTradeAccepted)
				{
					if (this._isActive)
					{
						this.SetResize();
						if (this.OnBoxStyleChanged != null)
						{
							this.OnBoxStyleChanged();
						}
					}
				}
				this.chbMMAutoStopLoss.Checked = ApplicationInfo.IsAutoTradeAccepted;
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000DE11C File Offset: 0x000DC51C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void threadSendTimes()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._currTimes <= this._OrdTimes)
			{
				string text = string.Concat(new object[]
				{
					this._retOrderMessage,
					"\n Times : ",
					this._currTimes,
					"/",
					this._OrdTimes
				});
				this.ShowOrderFormConfirm(string.Concat(new object[]
				{
					"Confirm to send?  *** Times : ",
					this._currTimes,
					"/",
					this._OrdTimes
				}), this._retOrderMessage, "", "");
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x000DE1E4 File Offset: 0x000DC5E4
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
				DialogResult result = ((frmOrderFormConfirm)sender).Result;
				if (ApplicationInfo.IsEquityAccount)
				{
					if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmSendNew)
					{
						if (result == DialogResult.OK)
						{
							if (!this.bgwSendOrder.IsBusy)
							{
								if (this._commandType == "V")
								{
									this._commandType = "S";
								}
								this.bgwSendOrder.RunWorkerAsync();
							}
							else
							{
								this.ShowMessageInFormConfirm("The system is not ready yet.", frmOrderFormConfirm.OpenStyle.Error);
							}
						}
						else
						{
							this._OrdTimes = 0;
							this._returnOrderNumberFromServer = -1L;
							this.DoClear();
						}
					}
					else
					{
						this.btnSendOrder.Enabled = true;
						this.btnMMSend.Enabled = true;
						this.SetLastActiveObject();
					}
				}
				else if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmSendNew)
				{
					if (result == DialogResult.OK)
					{
						if (!this.bgwSendOrder.IsBusy)
						{
							this._commandType = "S";
							this.bgwSendOrder.RunWorkerAsync();
						}
					}
					else if (Settings.Default.BottomStyleEquity == 5)
					{
						this.cbMMPrice.Focus();
					}
					else
					{
						this.tbPriceT.Focus();
					}
				}
				else
				{
					this.SetLastActiveObject();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000DE3C0 File Offset: 0x000DC7C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetLastActiveObject()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._objLastActive != null)
			{
				this._objLastActive.Focus();
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000DE3FC File Offset: 0x000DC7FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoClear()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (Settings.Default.BottomStyleEquity == 5)
				{
					this._OrdAutoStopLoss = false;
					if (!Settings.Default.BSBoxDefaultStock)
					{
						this.cbMMStock.Text = string.Empty;
					}
					this.chbMMAutoStopLoss.Checked = false;
					this.cbMMPrice.Text = "";
					this.tbMMStopPrice.Clear();
					this.tbMMGiveUp.Clear();
					this.tbMMTotalLoss.Text = string.Empty;
					this.tbMMVolume.Clear();
					this.btnMMSend.Enabled = true;
				}
				else if (ApplicationInfo.IsEquityAccount)
				{
					if (!Settings.Default.BSBoxDefaultStock)
					{
						this.cbStock.Text = string.Empty;
					}
					this.cbPrice.Text = string.Empty;
					this.chbNVDR.Checked = false;
					this.tbVolume.Text = string.Empty;
					this.tbTimes.Text = string.Empty;
					this.tbPublic.Text = string.Empty;
					this.cbCondition.Text = string.Empty;
					this.cbDepCollateral.Text = "";
					if (Settings.Default.BSBoxSavePincode)
					{
						this.tbPin.Text = ApplicationInfo.UserPincodeLastEntry;
					}
					else
					{
						this.tbPin.Text = string.Empty;
					}
					this.btnSendOrder.Enabled = true;
				}
				else
				{
					if (!Settings.Default.BSBoxDefaultStock)
					{
						this.tbSeries.Text = string.Empty;
					}
					this.tbVolumeT.Clear();
					this.tbPriceT.Clear();
					this.cbPosition.Text = "OPEN";
					this.rdbTfexOpenPos.Checked = true;
					this.tbPublishT.Clear();
					this.cbPriceTypeT.Text = "Limit";
					this.cbValidityT.Text = "DAY";
					this.chbTfexStopOrder.Checked = false;
					this.tbSeriesCondition.Clear();
					this.cbTfexConStopOrder.SelectedIndex = 0;
					this.tbTfexPriceCondition.Clear();
					this.btnSendOrderT.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("DoClear", ex);
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000DE6B4 File Offset: 0x000DCAB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DoSend_TFEX(string commandType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool flag = false;
			bool result;
			try
			{
				if (!ApplicationInfo.AccInfo.IsAccCanTrade(ApplicationInfo.AccInfo.CurrentAccount))
				{
					this.ShowMessageInFormConfirm(ApplicationInfo.AccInfo.CurrentAccount + " is not allowed to long / short.", frmOrderFormConfirm.OpenStyle.ShowBox);
					result = false;
					return result;
				}
				try
				{
					this._OrdSide = string.Empty;
					this._OrdSymbol = string.Empty;
					this._OrdVolume = 0L;
					this._OrdPriceType = string.Empty;
					this._OrdPrice = string.Empty;
					this._OrdPubVol = 0L;
					this._OrdCondition = string.Empty;
					this._OrdPosition = string.Empty;
					this._OrdValidityDate = string.Empty;
					this._OrdTfexStopSeries = string.Empty;
					this._OrdTfexStopCond = string.Empty;
					this._OrdTfexStopPrice = string.Empty;
					this._OrdSide = this._showSideTFEX;
					if (!(this._OrdSide == "L") && !(this._OrdSide == "S"))
					{
						this.ShowMessageInFormConfirm("Invalid Side!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbSeries);
						result = false;
						return result;
					}
					SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[this.tbSeries.Text.ToUpper().Trim()];
					if (seriesInformation.OrderBookId == 0 || seriesInformation.Group == 5)
					{
						this.ShowMessageInFormConfirm("Invalid Series Symbol!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbSeries);
						this.tbSeries.Focus();
						result = false;
						return result;
					}
					this._OrdSymbol = this.tbSeries.Text.ToUpper().Trim();
					this._OrdVolume = 0L;
					if (!FormatUtil.Isnumeric(this.tbVolumeT.Text.Trim()))
					{
						this.ShowMessageInFormConfirm("Invalid volume.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolumeT);
						result = false;
						return result;
					}
					try
					{
						this._OrdVolume = Convert.ToInt64(this.tbVolumeT.Text.Replace(",", ""));
						if (this._OrdVolume <= 0L)
						{
							this.ShowMessageInFormConfirm("Invalid Volume [More than Zero]!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolumeT);
							result = false;
							return result;
						}
					}
					catch
					{
						this.ShowMessageInFormConfirm("Invalid volume.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolumeT);
						result = false;
						return result;
					}
					string text;
					if (Settings.Default.BottomStyleEquity == 1)
					{
						text = this.tbPriceT.Text.ToUpper().Trim();
						if (text != null)
						{
							if (text == "MP" || text == "MO" || text == "ML")
							{
								this.cbPriceTypeT.Text = this.tbPriceT.Text.ToUpper().Trim();
								goto IL_30C;
							}
						}
						this.cbPriceTypeT.Text = "LIMIT";
						IL_30C:
						if (this.cbPriceTypeT.Text.ToLower() == "limit")
						{
							this._OrdPriceType = "L";
							this._OrdPrice = this.tbPriceT.Text.ToUpper().Trim();
							if (!this.IsValidPrice_TFEX(true, this._OrdPrice))
							{
								result = false;
								return result;
							}
						}
						else if (this.cbPriceTypeT.Text.ToLower() == "mp")
						{
							this._OrdPrice = "-1";
							this._OrdPriceType = "P";
						}
						else if (this.cbPriceTypeT.Text.ToLower() == "mo")
						{
							this._OrdPrice = "-1";
							this._OrdPriceType = "M";
						}
						else
						{
							if (!(this.cbPriceTypeT.Text.ToLower() == "ml"))
							{
								this.ShowMessageInFormConfirm("Invalid Type", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbPriceTypeT);
								result = false;
								return result;
							}
							this._OrdPrice = "-1";
							this._OrdPriceType = "T";
						}
					}
					else if (Settings.Default.BottomStyleEquity == 2)
					{
						text = this.tbPriceT.Text.ToUpper().Trim();
						if (text != null)
						{
							if (text == "MP")
							{
								this._OrdPrice = "-1";
								this._OrdPriceType = "P";
								goto IL_57B;
							}
							if (text == "MO")
							{
								this._OrdPrice = "-1";
								this._OrdPriceType = "M";
								goto IL_57B;
							}
							if (text == "ML")
							{
								this._OrdPrice = "-1";
								this._OrdPriceType = "T";
								goto IL_57B;
							}
						}
						this._OrdPrice = this.tbPriceT.Text.ToUpper().Trim();
						if (!this.IsValidPrice_TFEX(true, this._OrdPrice))
						{
							result = false;
							return result;
						}
						this._OrdPriceType = "L";
						IL_57B:;
					}
					this._OrdPubVol = 0L;
					if (!FormatUtil.Isnumeric(this.tbPublishT.Text.Trim()))
					{
						this.ShowMessageInFormConfirm("Invalid public volume", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPublishT);
						result = false;
						return result;
					}
					try
					{
						this._OrdPubVol = Convert.ToInt64(this.tbPublishT.Text.Replace(",", ""));
					}
					catch
					{
						this.ShowMessageInFormConfirm("Invalid public volume", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPublishT);
						result = false;
						return result;
					}
					if (this._OrdPubVol == this._OrdVolume)
					{
						this._OrdPubVol = 0L;
					}
					text = this.cbValidityT.Text.Trim();
					if (text != null)
					{
						if (text == "DAY" || text == "FAK" || text == "FOK" || text == "")
						{
							this._OrdCondition = this.cbValidityT.Text.Trim();
							goto IL_6C9;
						}
					}
					this.ShowMessageInFormConfirm("Invalid Condition!", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbValidityT);
					IL_6C9:
					if (Settings.Default.BottomStyleEquity == 1)
					{
						if (this.cbPosition.Text.ToUpper() == "CLOSE")
						{
							this._OrdPosition = "C";
						}
						else
						{
							this._OrdPosition = "O";
						}
					}
					else if (Settings.Default.BottomStyleEquity == 2)
					{
						if (this.rdbTfexClosePos.Checked)
						{
							this._OrdPosition = "C";
						}
						else if (this.rdbTfexOpenPos.Checked)
						{
							this._OrdPosition = "O";
						}
					}
					this._OrdValidityDate = DateTime.Now.ToString("yyyyMMdd");
					if (this.chbTfexStopOrder.Checked)
					{
						this._OrdTfexStopSeries = this.tbSeriesCondition.Text.Trim();
						seriesInformation = ApplicationInfo.SeriesInfo[this._OrdTfexStopSeries];
						if (seriesInformation.OrderBookId == 0 || seriesInformation.Group == 5)
						{
							this.ShowMessageInFormConfirm("Invalid Stop Series!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbSeries);
							result = false;
							return result;
						}
						this._OrdTfexStopCond = this.cbTfexConStopOrder.Text.Trim();
						if (!(this.tbTfexPriceCondition.Text.ToUpper().Trim() != "PRICE"))
						{
							this.ShowMessageInFormConfirm("Invalid Stop Price!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbTfexPriceCondition);
							result = false;
							return result;
						}
						this._OrdTfexStopPrice = this.tbTfexPriceCondition.Text.Trim();
						if (!this.IsValidPrice_TFEX(false, this._OrdTfexStopPrice, seriesInformation))
						{
							this.ShowMessageInFormConfirm("Invalid Stop Price!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbSeries);
							result = false;
							return result;
						}
						if (this._OrdTfexStopCond == "Bid >=")
						{
							this._OrdTfexStopCond = "1";
						}
						else if (this._OrdTfexStopCond == "Bid <=")
						{
							this._OrdTfexStopCond = "2";
						}
						else if (this._OrdTfexStopCond == "Ask >=")
						{
							this._OrdTfexStopCond = "3";
						}
						else if (this._OrdTfexStopCond == "Ask <=")
						{
							this._OrdTfexStopCond = "4";
						}
						else if (this._OrdTfexStopCond == "Last >=")
						{
							this._OrdTfexStopCond = "5";
						}
						else if (this._OrdTfexStopCond == "Last <=")
						{
							this._OrdTfexStopCond = "6";
						}
					}
					if (string.IsNullOrEmpty(ApplicationInfo.AccInfo.CurrentAccount))
					{
						this.ShowMessageInFormConfirm("Invalid Account!", frmOrderFormConfirm.OpenStyle.ShowBox);
						result = false;
						return result;
					}
					if (Settings.Default.BottomStyleEquity == 2)
					{
						this._OrdPubVol = 0L;
						this._OrdCondition = "DAY";
						this._OrdTfexStopSeries = string.Empty;
						this._OrdTfexStopCond = string.Empty;
						this._OrdTfexStopPrice = string.Empty;
					}
					this._commandType = commandType;
					string orderParam = string.Concat(new object[]
					{
						(this._OrdSide == "L") ? "Long" : "Short",
						" (",
						this.cbPosition.Text.ToUpper(),
						")",
						" ",
						this._OrdSymbol,
						" , Volume ",
						this._OrdVolume,
						" , Price ",
						(this._OrdPrice == "-1") ? "Market" : this._OrdPrice,
						"\r\n , Account ",
						ApplicationInfo.AccInfo.CurrentAccount
					});
					this.ShowOrderFormConfirm("Confirm to send?", orderParam, "", "");
				}
				catch (Exception ex)
				{
					this.ShowError("DoSend_TFEX", ex);
				}
			}
			catch (Exception ex2)
			{
				this.ShowError("DoSend_TFEX", ex2);
			}
			result = flag;
			return result;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000DF2E4 File Offset: 0x000DD6E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DoSend_MM_TFEX(string commandType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool flag = false;
			bool result;
			try
			{
				if (!ApplicationInfo.AccInfo.IsAccCanTrade(ApplicationInfo.AccInfo.CurrentAccount))
				{
					this.ShowMessageInFormConfirm(ApplicationInfo.AccInfo.CurrentAccount + " is not allowed to long / short.", frmOrderFormConfirm.OpenStyle.ShowBox);
					result = false;
					return result;
				}
				try
				{
					this._OrdSide = string.Empty;
					this._OrdSymbol = string.Empty;
					this._OrdVolume = 0L;
					this._OrdPriceType = string.Empty;
					this._OrdPrice = string.Empty;
					this._OrdPubVol = 0L;
					this._OrdCondition = string.Empty;
					this._OrdPosition = string.Empty;
					this._OrdValidityDate = string.Empty;
					this._OrdTfexStopSeries = string.Empty;
					this._OrdTfexStopCond = string.Empty;
					this._OrdTfexStopPrice = string.Empty;
					this._OrdSide = this._showSideTFEX;
					if (!(this._OrdSide == "L") && !(this._OrdSide == "S"))
					{
						this.ShowMessageInFormConfirm("Invalid Side!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbMMStock);
						result = false;
						return result;
					}
					if (this.rdbMMOpenPos.Checked)
					{
						this._OrdPosition = "O";
					}
					else
					{
						if (!this.rdbMMClosePos.Checked)
						{
							this.ShowMessageInFormConfirm("Invalid Position!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbMMStock);
							result = false;
							return result;
						}
						this._OrdPosition = "C";
					}
					SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[this.cbMMStock.Text.ToUpper().Trim()];
					if (seriesInformation.OrderBookId == 0 || seriesInformation.Group == 5)
					{
						this.ShowMessageInFormConfirm("Invalid Series Symbol!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbMMStock);
						this.tbSeries.Focus();
						result = false;
						return result;
					}
					this._OrdSymbol = seriesInformation.Symbol;
					this._OrdVolume = 0L;
					if (!FormatUtil.Isnumeric(this.tbMMVolume.Text.Trim()))
					{
						this.ShowMessageInFormConfirm("Invalid volume.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbMMVolume);
						result = false;
						return result;
					}
					try
					{
						this._OrdVolume = Convert.ToInt64(this.tbMMVolume.Text.Replace(",", ""));
						if (this._OrdVolume <= 0L)
						{
							this.ShowMessageInFormConfirm("Invalid Volume [More than Zero]!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbMMVolume);
							result = false;
							return result;
						}
					}
					catch
					{
						this.ShowMessageInFormConfirm("Invalid volume.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbMMVolume);
						result = false;
						return result;
					}
					this._OrdPriceType = "L";
					this._OrdPrice = this.cbMMPrice.Text.ToUpper().Trim();
					this._OrdPubVol = 0L;
					this._OrdCondition = "DAY";
					this._OrdValidityDate = DateTime.Now.ToString("yyyyMMdd");
					if (string.IsNullOrEmpty(ApplicationInfo.AccInfo.CurrentAccount))
					{
						this.ShowMessageInFormConfirm("Invalid Account!", frmOrderFormConfirm.OpenStyle.ShowBox);
						result = false;
						return result;
					}
					this._OrdAutoStopLoss = this.chbMMAutoStopLoss.Checked;
					this._commandType = commandType;
					string orderParam = string.Concat(new object[]
					{
						(this._OrdSide == "L") ? "Long" : "Short",
						" (",
						(this._OrdPosition == "O") ? "Open" : "Close",
						")",
						" ",
						this._OrdSymbol,
						" , Volume ",
						this._OrdVolume,
						" , Price ",
						(this._OrdPrice == "-1") ? "Market" : this._OrdPrice,
						"\r\n , Account ",
						ApplicationInfo.AccInfo.CurrentAccount
					});
					this.ShowOrderFormConfirm("Confirm to send?", orderParam, "", "");
				}
				catch (Exception ex)
				{
					this.ShowError("DoSend_MM_TFEX", ex);
				}
			}
			catch (Exception ex2)
			{
				this.ShowError("DoSend_MM_TFEX", ex2);
			}
			result = flag;
			return result;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x000DF804 File Offset: 0x000DDC04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void VerifyParam()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.VerifyParam));
			}
			else
			{
				this._verifyParam = false;
				if (ApplicationInfo.AccInfo.IsAccCanTrade(ApplicationInfo.AccInfo.CurrentAccount))
				{
					this._OrdAutoStopLoss = false;
					this._OrdSymbol = this.cbStock.Text.ToUpper().Trim();
					if (this.chbNVDR.Checked)
					{
						this._OrdTtf = 2;
					}
					else
					{
						this._OrdTtf = 0;
					}
					this._OrdSide = this._showSide;
					this._OrdCondition = this.cbCondition.Text.Trim();
					if (ApplicationInfo.UserLoginMode == "I")
					{
						this.ShowMessageInFormConfirm("Invalid Login Type", frmOrderFormConfirm.OpenStyle.ShowBox);
					}
					else
					{
						this._OrdIsDeposit = "";
						if (ApplicationInfo.AccInfo.CurrentAccountType == "B")
						{
							if (this.cbDepCollateral.Text.ToString() == "Deposit")
							{
								this._OrdIsDeposit = "D";
							}
							else if (this.cbDepCollateral.Text.ToString() == "Collateral")
							{
								this._OrdIsDeposit = "C";
							}
						}
						if (string.IsNullOrEmpty(this._OrdSide))
						{
							this.ShowMessageInFormConfirm("Invalid Side!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbStock);
						}
						else if (string.IsNullOrEmpty(this._OrdSymbol))
						{
							this.ShowMessageInFormConfirm("Invalid Stock Symbol!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbStock);
							this.cbStock.Focus();
						}
						else
						{
							this._OrdVolume = 0L;
							try
							{
								this._OrdVolume = Convert.ToInt64(this.tbVolume.Text.Replace(",", ""));
								if (this._OrdVolume <= 0L)
								{
									this.ShowMessageInFormConfirm("Invalid Volume [More than Zero]!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolume);
									return;
								}
							}
							catch
							{
								this.ShowMessageInFormConfirm("Invalid volume.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolume);
								return;
							}
							if (this.IsValidPrice(this.cbPrice.Text, true, this.cbPrice))
							{
								this._OrdPrice = this.cbPrice.Text.ToUpper().Trim();
								switch (this._OrdTtf)
								{
								case 0:
								case 1:
								case 2:
								{
									this._OrdPubVol = 0L;
									string text;
									try
									{
										this._OrdPubVol = Convert.ToInt64(this.tbPublic.Text.Replace(",", ""));
										if (this._OrdPubVol > this._OrdVolume)
										{
											this.ShowMessageInFormConfirm("Published is Greater than Volume", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolume);
											break;
										}
										if (this._OrdPubVol < this._OrdVolume)
										{
											text = this._OrdPrice;
											if (text != null)
											{
												if (text == "MP" || text == "ATO" || text == "ATC" || text == "MO" || text == "ML")
												{
													this.ShowMessageInFormConfirm("Price condition cannot use Published.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolume);
													break;
												}
											}
											text = this._OrdCondition;
											if (text != null)
											{
												if (text == "IOC" || text == "FOK")
												{
													this.ShowMessageInFormConfirm("Cannot use Published Volume with IOC, FOK", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolume);
													break;
												}
											}
										}
									}
									catch
									{
										this.ShowMessageInFormConfirm("Invalid public volume", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPublic);
										break;
									}
									text = this._OrdCondition;
									if (text != null)
									{
										if (text == "IOC")
										{
											this._OrdCondition = "I";
											goto IL_512;
										}
										if (text == "FOK")
										{
											this._OrdCondition = "F";
											goto IL_512;
										}
										if (text == "")
										{
											if (ApplicationInfo.SupportFreewill)
											{
												if (this._OrdVolume < (long)this._stockInfo.BoardLot)
												{
													this._OrdCondition = "O";
												}
												else
												{
													this._OrdCondition = " ";
												}
											}
											else
											{
												this._OrdCondition = " ";
											}
											goto IL_512;
										}
									}
									this.ShowMessageInFormConfirm("Invalid Condition!", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbCondition);
									IL_512:
									if (string.IsNullOrEmpty(ApplicationInfo.AccInfo.CurrentAccount))
									{
										this.ShowMessageInFormConfirm("Invalid Account!", frmOrderFormConfirm.OpenStyle.ShowBox);
									}
									else
									{
										this._OrdTimes = 0;
										if (ApplicationInfo.SupportOrderTimes)
										{
											int.TryParse(this.tbTimes.Text, out this._OrdTimes);
											if (this._OrdTimes <= -1 || this._OrdTimes >= 100)
											{
												this.ShowMessageInFormConfirm("Invalid times", frmOrderFormConfirm.OpenStyle.ShowBox);
												break;
											}
										}
										this._verifyParam = true;
									}
									break;
								}
								default:
									this.ShowMessageInFormConfirm("Invalid Trustee Id.", frmOrderFormConfirm.OpenStyle.ShowBox);
									break;
								}
							}
						}
					}
				}
				else
				{
					this.ShowMessageInFormConfirm(ApplicationInfo.AccInfo.CurrentAccount + " is not allowed to Buy / Sell.", frmOrderFormConfirm.OpenStyle.ShowBox);
				}
			}
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000DFE18 File Offset: 0x000DE218
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSendOrder_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (ApplicationInfo.IsEquityAccount)
			{
				try
				{
					this._verifyResultStr_Pin = string.Empty;
					this._verifyResult_Pin = false;
					string text = this.tbPin.Text.Trim();
					if (Settings.Default.BottomStyleEquity == 5)
					{
						text = this.tbMMPin.Text.Trim();
					}
					if (text == string.Empty)
					{
						this._verifyResultStr_Pin = "Pincode is empty!!!";
						return;
					}
					if (ApplicationInfo.UserPincodeWrongCount < ApplicationInfo.UserMaxRetryPincode)
					{
						this.ShowSplash(true, "Check Pincode.", false);
						this._verifyResult_Pin = ApplicationInfo.VerifyPincode(text, ref this._verifyResultStr_Pin);
						this.ShowSplash(false, "", false);
					}
				}
				catch (Exception ex)
				{
					this.ShowSplash(false, "", false);
					this.ShowError("CheckPin", ex);
					this._verifyResultStr_Pin = ex.Message;
				}
				this._verifyResult = false;
				if (this._verifyResult_Pin)
				{
					if (this._commandType == "V")
					{
						try
						{
							this.ShowSplash(true, "Verify New Order...", false);
							string data = string.Empty;
							if (ApplicationInfo.SupportFreewill)
							{
								data = ApplicationInfo.WebOrderService.VerifyOrderFw(this._OrdSymbol, this._OrdSide, this._OrdVolume, this._OrdPrice, this._OrdPubVol, this._OrdCondition);
							}
							else
							{
								data = ApplicationInfo.WebOrderService.VerifyOrder(this._OrdSymbol, this._OrdSide, this._OrdVolume, this._OrdPrice, ApplicationInfo.AccInfo.CurrentAccount, ApplicationInfo.IsRiskActive);
							}
							if (this._dsSendOrder == null)
							{
								this._dsSendOrder = new DataSet();
							}
							else
							{
								this._dsSendOrder.Clear();
							}
							MyDataHelper.StringToDataSet(data, this._dsSendOrder);
							this._verifyResult = true;
						}
						catch (Exception ex)
						{
							this.ShowMessageInFormConfirm(ex.Message, frmOrderFormConfirm.OpenStyle.ShowBox);
						}
						this.ShowSplash(false, "", false);
					}
					else if (this._commandType == "S")
					{
						try
						{
							this.ShowSplash(true, "Sending New Order...", false);
							if (ApplicationInfo.SupportFreewill)
							{
								this.ShowMessageInFormConfirm("Please wait for confirmation.", frmOrderFormConfirm.OpenStyle.WaitingForm);
							}
							this._newOrderResult = ApplicationInfo.SendNewOrder(this._OrdSymbol, this._OrdSide, this._OrdVolume, this._OrdPrice, this._OrdPubVol, this._OrdCondition, this._OrdTtf, this._OrdIsDeposit, this._OrdAutoStopLoss);
							this._verifyResult = true;
						}
						catch (Exception ex)
						{
							this.ShowMessageInFormConfirm("SendNewOrder:" + ex.Message, frmOrderFormConfirm.OpenStyle.ShowBox);
						}
						this.ShowSplash(false, "", false);
					}
				}
			}
			else if (this._commandType == "S")
			{
				try
				{
					this.ShowSplash(true, "Sending New Order...", false);
					string currentAccount = ApplicationInfo.AccInfo.CurrentAccount;
					string text2 = ApplicationInfo.WebServiceTFEX.SendTFEXNewOrder(this._OrdSymbol, this._OrdSide, this._OrdVolume, this._OrdPrice, currentAccount, this._OrdPubVol, this._OrdPosition, this._OrdTfexStopPrice, this._OrdTfexStopCond, this._OrdTfexStopSeries, this._OrdCondition, this._OrdValidityDate, ApplicationInfo.UserSessionID, "", "", ApplicationInfo.AuthenKey, ApplicationInfo.AccInfo.InternetUserTFEX, ApplicationInfo.IP, ApplicationInfo.KE_Session, ApplicationInfo.KE_LOCAL, "S", this._OrdPriceType);
					if (text2.Trim() == string.Empty)
					{
						this.ShowMessageInFormConfirm("Request fail , return empty!!!", frmOrderFormConfirm.OpenStyle.ShowBox);
					}
					else if (text2.Trim().ToUpper() == "INVALID_SESSION_KEY")
					{
						this.ShowMessageInFormConfirm("Invalid session key!!!", frmOrderFormConfirm.OpenStyle.ShowBox);
					}
					else
					{
						if (this._dsSendOrderTfex == null)
						{
							this._dsSendOrderTfex = new DataSet();
						}
						else
						{
							this._dsSendOrderTfex.Clear();
						}
						MyDataHelper.StringToDataSet(text2, this._dsSendOrderTfex);
					}
				}
				catch (Exception ex)
				{
					this.ShowMessageInFormConfirm(ex.Message, frmOrderFormConfirm.OpenStyle.ShowBox);
				}
				this.ShowSplash(false, "", false);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000E0344 File Offset: 0x000DE744
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSendOrder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.Error == null)
			{
				if (ApplicationInfo.IsEquityAccount)
				{
					if (this._verifyResult_Pin)
					{
						if (this._verifyResult)
						{
							if (this._commandType == "V")
							{
								try
								{
									if (this._dsSendOrder != null && this._dsSendOrder.Tables.Contains("verify_result") && this._dsSendOrder.Tables["verify_result"].Rows.Count > 0)
									{
										int num = Convert.ToInt32(this._dsSendOrder.Tables["verify_result"].Rows[0]["result_code"]);
										string message = this._dsSendOrder.Tables["verify_result"].Rows[0]["result_message"].ToString();
										int num2 = 0;
										int.TryParse(this._dsSendOrder.Tables["verify_result"].Rows[0]["verify_code"].ToString(), out num2);
										if (num == 1)
										{
											StockList.StockInformation stockInfo = ApplicationInfo.StockInfo[this._OrdSymbol];
											this._retOrderMessage = string.Concat(new string[]
											{
												"Account : ",
												ApplicationInfo.AccInfo.CurrentAccount,
												"\n",
												Utilities.GetOrderSideName(this._OrdSide),
												" : ‘",
												this._OrdSymbol,
												"’",
												(this._OrdIsDeposit == "D") ? "  (Deposit)" : "",
												"\nVolume : ",
												FormatUtil.VolumeFormat(this._OrdVolume, true),
												"\nPrice : ",
												this._OrdPrice,
												(this._OrdTtf != 0) ? (" ,Trustee Id " + this._OrdTtf) : "",
												"\nTotal Amount :  ",
												this.CalculateValue(this._OrdVolume, this._OrdPrice, this._OrdSide, stockInfo),
												"   (Commission and VAT not included)"
											});
											if (ApplicationInfo.SupportOrderTimes && this._OrdTimes > 0)
											{
												this._currTimes = 1;
												message = string.Concat(new object[]
												{
													this._retOrderMessage,
													", Times : ",
													this._currTimes,
													"/",
													this._OrdTimes
												});
											}
											this.ShowOrderFormConfirm("Confirm to send?" + ((this._currTimes + 1 <= this._OrdTimes) ? string.Concat(new object[]
											{
												" *** Times : ",
												this._currTimes,
												"/",
												this._OrdTimes
											}) : ""), this._retOrderMessage, this._dsSendOrder.Tables["verify_result"].Rows[0]["oss"].ToString(), this._dsSendOrder.Tables["verify_result"].Rows[0]["stock_threshold"].ToString());
										}
										else
										{
											this._objLastActive = this.cbPrice;
											this.ShowMessageInFormConfirm(message, frmOrderFormConfirm.OpenStyle.ShowBox);
										}
										this._dsSendOrder.Clear();
									}
									else
									{
										this.ShowMessageInFormConfirm("An error is detected.", frmOrderFormConfirm.OpenStyle.ShowBox);
										this.DoClear();
									}
								}
								catch (Exception ex)
								{
									this.ShowMessageInFormConfirm(ex.Message, frmOrderFormConfirm.OpenStyle.ShowBox);
								}
							}
							else if (this._commandType == "S")
							{
								try
								{
									if (this._newOrderResult.OrderNo > 0L)
									{
										this._returnOrderNumberFromServer = this._newOrderResult.OrderNo;
										if (ApplicationInfo.SupportFreewill)
										{
											this.ShowSplash(true, "New Order Reference no. " + this._newOrderResult.OrderNo, true);
										}
										else
										{
											this.ShowSplash(true, "New Order Number " + this._newOrderResult.OrderNo, true);
										}
										ApplicationInfo.AddOrderNoToAutoRefreshList(this._newOrderResult.OrderNo.ToString(), this._newOrderResult.IsFwOfflineOrder ? 3 : 1);
										if (this._newOrderResult.IsAutoStopLoss)
										{
											string text = string.Empty;
											if (this._OrdSide == "B")
											{
												text = "S";
											}
											else if (this._OrdSide == "H")
											{
												text = "C";
											}
											int operatorType = (text == "C") ? 3 : 4;
											AutoTradeItem item = new AutoTradeItem("MM", ApplicationInfo.UserLoginID, this._OrdSymbol, "LAST", operatorType, this._OrdStopPrice, this._OrdStopPrice, ApplicationInfo.AccInfo.CurrentAccount, text, Convert.ToInt64(this.tbMMVolume.Text.Replace(",", "")), "MP", ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].PcFlag, "N", ApplicationInfo.IsEquityAccount, "");
											AutoTradeMMCommand autoTradeMMCommand = new AutoTradeMMCommand();
											autoTradeMMCommand.IsCancel = false;
											autoTradeMMCommand.OrderNoPending = this._newOrderResult.OrderNo;
											autoTradeMMCommand.Item = item;
											AutoTradeMain autoTradeMain = new AutoTradeMain();
											string message2 = autoTradeMain.Pack("MM", autoTradeMMCommand);
											ApplicationInfo.WebAlertService.SendAutoTradeCompleted -= new SendAutoTradeCompletedEventHandler(this.WebAlertService_SendAutoTradeCompleted);
											ApplicationInfo.WebAlertService.SendAutoTradeCompleted += new SendAutoTradeCompletedEventHandler(this.WebAlertService_SendAutoTradeCompleted);
											ApplicationInfo.WebAlertService.SendAutoTradeAsync(message2);
										}
									}
									else
									{
										this.ShowMessageInFormConfirm("Fail >> " + this._newOrderResult.ResultMessage, frmOrderFormConfirm.OpenStyle.ShowBox);
									}
									if (ApplicationInfo.SupportOrderTimes)
									{
										if (this._currTimes + 1 <= this._OrdTimes)
										{
											if (ApplicationInfo.SupportFreewill)
											{
												return;
											}
											this._currTimes++;
											Thread thread = new Thread(new ThreadStart(this.threadSendTimes));
											thread.Start();
											return;
										}
									}
									this.DoClear();
									this.cbStock.Focus();
									this.cbStock.SelectAll();
								}
								catch (Exception ex)
								{
									this.ShowMessageInFormConfirm("SendNewOrder:" + ex.Message, frmOrderFormConfirm.OpenStyle.ShowBox);
								}
							}
						}
					}
					else if (ApplicationInfo.UserPincodeWrongCount < ApplicationInfo.UserMaxRetryPincode)
					{
						this.ShowMessageInFormConfirm(this._verifyResultStr_Pin, frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPin);
						this.tbPin.Focus();
					}
					else if (this._verifyResultStr_Pin == ApplicationInfo.PINCODE_TIMEOUT)
					{
						this.ShowMessageInFormConfirm("*** Pincode timeout. ***\nPlease entry again!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPin);
					}
					else
					{
						this.ShowMessageInFormConfirm("*** Pincode Locked. ***\nPlease logout and login again!", frmOrderFormConfirm.OpenStyle.ShowBox);
					}
				}
				else
				{
					try
					{
						if (this._commandType == "S")
						{
							if (this._dsSendOrderTfex != null && this._dsSendOrderTfex.Tables.Contains("Results") && this._dsSendOrderTfex.Tables["Results"].Rows.Count > 0)
							{
								DataRow dataRow = this._dsSendOrderTfex.Tables["Results"].Rows[0];
								long num3 = 0L;
								long.TryParse(dataRow["Code"].ToString(), out num3);
								if (num3 > 0L)
								{
									ApplicationInfo.AddOrderNoToAutoRefreshList_TFEX(num3.ToString());
									if (this._OrdAutoStopLoss)
									{
										string tfexPosition = (this._OrdPosition == "O") ? "C" : "O";
										string text2 = (this._OrdSide == "L") ? "S" : "L";
										int operatorType = (text2 == "L") ? 3 : 4;
										AutoTradeItem item = new AutoTradeItem("MM", ApplicationInfo.UserLoginID, this._OrdSymbol, "LAST", operatorType, this._OrdStopPrice, this._OrdStopPrice, ApplicationInfo.AccInfo.CurrentAccount, text2, Convert.ToInt64(this.tbMMVolume.Text.Replace(",", "")), "MP", ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].PcFlag, "N", ApplicationInfo.IsEquityAccount, tfexPosition);
										AutoTradeMMCommand autoTradeMMCommand = new AutoTradeMMCommand();
										autoTradeMMCommand.IsCancel = false;
										autoTradeMMCommand.OrderNoPending = num3;
										autoTradeMMCommand.Item = item;
										AutoTradeMain autoTradeMain = new AutoTradeMain();
										string message2 = autoTradeMain.Pack("MM", autoTradeMMCommand);
										ApplicationInfo.WebAlertService.SendAutoTradeCompleted -= new SendAutoTradeCompletedEventHandler(this.WebAlertService_SendAutoTradeCompleted);
										ApplicationInfo.WebAlertService.SendAutoTradeCompleted += new SendAutoTradeCompletedEventHandler(this.WebAlertService_SendAutoTradeCompleted);
										ApplicationInfo.WebAlertService.SendAutoTradeAsync(message2);
									}
								}
								else
								{
									this.ShowMessageInFormConfirm(dataRow["message"].ToString(), frmOrderFormConfirm.OpenStyle.ShowBox);
								}
								this._dsSendOrderTfex.Clear();
							}
							else
							{
								this.ShowMessageInFormConfirm("Send new order Unsuccessful!!!", frmOrderFormConfirm.OpenStyle.ShowBox);
							}
							this.DoClear();
							this.tbSeries.Focus();
							this.tbSeries.SelectAll();
						}
					}
					catch (Exception ex)
					{
						this.ShowError("bgwSendOrder_RunWorkerCompleted", ex);
					}
				}
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000E0E9C File Offset: 0x000DF29C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebAlertService_SendAutoTradeCompleted(object sender, SendAutoTradeCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.WebAlertService.SendAutoTradeCompleted -= new SendAutoTradeCompletedEventHandler(this.WebAlertService_SendAutoTradeCompleted);
				if (e.Error == null)
				{
					if (!string.IsNullOrEmpty(e.Result))
					{
						using (DataSet dataSet = new DataSet())
						{
							MyDataHelper.StringToDataSet(e.Result, dataSet);
							if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
							{
								if (dataSet.Tables["Results"].Rows[0]["message"].ToString() != "ok")
								{
									this.ShowMessageInFormConfirm(dataSet.Tables["Results"].Rows[0]["message"].ToString(), frmOrderFormConfirm.OpenStyle.Error);
								}
							}
							dataSet.Clear();
						}
					}
				}
				else
				{
					this.ShowError("SendAutoTradeCompleted", new Exception(e.Error.Message));
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SendAutoTradeCompleted", ex);
			}
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000E1058 File Offset: 0x000DF458
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string CalculateValue(long volume, string price, string side, StockList.StockInformation stockInfo)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			decimal d = 0m;
			try
			{
				if (stockInfo != null && stockInfo.Number > 0)
				{
					if (price == "ATO" || price == "ATC" || price == "MP" || price == "MO" || price == "ML")
					{
						if (side == "B" || side == "C")
						{
							d = stockInfo.Ceiling;
						}
						else if (side == "S" || side == "H")
						{
							d = stockInfo.Floor;
						}
					}
					else
					{
						decimal.TryParse(price, out d);
					}
					decimal num = volume * d;
					result = FormatUtil.PriceFormat(num, 2, "");
				}
			}
			catch (Exception ex)
			{
				this.ShowError("CalculateValue", ex);
			}
			return result;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000E11F4 File Offset: 0x000DF5F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SetColorBySide(string side)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			if (base.InvokeRequired)
			{
				result = (bool)base.Invoke(new ucSendNewOrder.SetColorBySideCallBack(this.SetColorBySide), new object[]
				{
					side
				});
			}
			else
			{
				try
				{
					Color foreColor = Color.White;
					if (ApplicationInfo.IsEquityAccount)
					{
						this._showSide = side;
					}
					else
					{
						this._showSideTFEX = side;
					}
					if (Settings.Default.BottomStyleEquity == 5)
					{
						this.btnMMBuy.Image = Resources.side_noside;
						this.btnMMSell.Image = Resources.side_noside;
						this.btnMMCover.Image = Resources.side_noside;
						this.btnMMShort.Image = Resources.side_noside;
						if (side == "B" || side == "L")
						{
							this.panelTop.BackColor = Color.DarkGreen;
							this.btnMMBuy.Image = Resources.side_buy;
						}
						else if (side == "S")
						{
							this.panelTop.BackColor = Color.Maroon;
							this.btnMMSell.Image = Resources.side_sell;
						}
						else if (side == "C")
						{
							foreColor = Color.Black;
							this.btnMMCover.Image = Resources.side_cover;
							this.panelTop.BackColor = Color.Turquoise;
						}
						else if (side == "H")
						{
							foreColor = Color.Black;
							this.btnMMShort.Image = Resources.side_short;
							this.panelTop.BackColor = Color.Pink;
						}
						else
						{
							this.panelTop.BackColor = Color.FromArgb(20, 20, 20);
						}
					}
					else if (ApplicationInfo.IsEquityAccount)
					{
						if (Settings.Default.BottomStyleEquity == 1)
						{
							this.cbSide.Text = Utilities.GetOrderSideName(this._showSide);
						}
						else
						{
							string showSide = this._showSide;
							if (showSide != null)
							{
								if (showSide == "B")
								{
									this.rbBuy.Checked = true;
									goto IL_33D;
								}
								if (showSide == "S")
								{
									this.rbSell.Checked = true;
									goto IL_33D;
								}
								if (showSide == "H")
								{
									this.rbShort.Checked = true;
									goto IL_33D;
								}
								if (showSide == "C")
								{
									this.rbCover.Checked = true;
									goto IL_33D;
								}
							}
							this.rbBuy.Checked = false;
							this.rbSell.Checked = false;
							this.rbShort.Checked = false;
							this.rbCover.Checked = false;
							IL_33D:;
						}
						this.cbDepCollateral.Enabled = false;
						this.cbDepCollateral.Text = "";
						if (this._showSide == "B")
						{
							this.panelTop.BackColor = Color.DarkGreen;
							foreColor = Color.White;
						}
						else if (this._showSide == "S")
						{
							if (ApplicationInfo.SuuportSBL == "Y")
							{
								if (ApplicationInfo.AccInfo.CurrentAccountType == "B")
								{
									this.cbDepCollateral.Enabled = true;
								}
								else
								{
									this.cbDepCollateral.Text = "";
								}
							}
							this.panelTop.BackColor = Color.Maroon;
							foreColor = Color.White;
						}
						else if (this._showSide == "H")
						{
							if (ApplicationInfo.MarketState != "O")
							{
								this.ShowMessageInFormConfirm("This market state short sell not allowed!", frmOrderFormConfirm.OpenStyle.ShowBox);
								result = false;
								return result;
							}
							this.panelTop.BackColor = Color.Pink;
							foreColor = Color.Black;
						}
						else if (this._showSide == "C")
						{
							this.panelTop.BackColor = Color.Turquoise;
							foreColor = Color.Black;
						}
						else
						{
							this.panelTop.BackColor = Color.FromArgb(20, 20, 20);
							foreColor = Color.White;
						}
					}
					else
					{
						foreColor = Color.White;
						if (this._showSideTFEX == "L" && !this.rdbTfexBuy.Checked)
						{
							this.rdbTfexBuy.Checked = true;
						}
						else if (this._showSideTFEX == "S" && !this.rdbTfexSell.Checked)
						{
							this.rdbTfexSell.Checked = true;
						}
						if (this._showSideTFEX == "L")
						{
							this.panelTop.BackColor = Color.DarkGreen;
						}
						else if (this._showSideTFEX == "S")
						{
							this.panelTop.BackColor = Color.Maroon;
						}
						else
						{
							this.panelTop.BackColor = Color.FromArgb(20, 20, 20);
						}
					}
					foreach (Control control in this.panelTop.Controls)
					{
						if (control.Tag == null)
						{
							if (control.GetType() == typeof(Label) || control.GetType() == typeof(CheckBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton))
							{
								control.ForeColor = foreColor;
							}
						}
						else if (side == "H" || side == "C")
						{
							control.ForeColor = Color.Black;
						}
						else
						{
							control.ForeColor = Color.Yellow;
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SetColorBySide", ex);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x000E1988 File Offset: 0x000DFD88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				((Control)sender).BackColor = Color.Yellow;
				((Control)sender).ForeColor = Color.Black;
				if (sender.GetType() == typeof(TextBox))
				{
					((TextBox)sender).SelectAll();
				}
				if (sender.Equals(this.cbPrice))
				{
				}
				if (sender.Equals(this.tbTfexPriceCondition))
				{
					if (this.tbTfexPriceCondition.Text == "PRICE")
					{
						this.tbTfexPriceCondition.BackColor = Color.Yellow;
						this.tbTfexPriceCondition.ForeColor = Color.Black;
						this.tbTfexPriceCondition.Text = "";
					}
				}
				if (sender.Equals(this.tbSeriesCondition))
				{
					if (this.tbSeriesCondition.Text == "SERIES")
					{
						this.tbSeriesCondition.BackColor = Color.Yellow;
						this.tbSeriesCondition.ForeColor = Color.Black;
						this.tbSeriesCondition.Text = "";
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("controlOrder_Enter", ex);
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000E1B1C File Offset: 0x000DFF1C
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
					((Control)sender).ForeColor = Color.White;
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

		// Token: 0x06000C05 RID: 3077 RVA: 0x000E1C34 File Offset: 0x000E0034
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrderTFEX_Leave(object sender, EventArgs e)
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
					if (this.panelDerivative.BackColor == Color.Maroon || this.panelDerivative.BackColor == Color.DarkGreen)
					{
						((Control)sender).ForeColor = Color.LightGray;
					}
					else
					{
						((Control)sender).ForeColor = Color.Black;
					}
				}
				else
				{
					((Control)sender).BackColor = Color.LightGray;
					((Control)sender).ForeColor = Color.Black;
					if (sender == this.tbSeriesCondition)
					{
						if (string.IsNullOrEmpty(((Control)sender).Text))
						{
							((Control)sender).Text = "SERIES";
							((Control)sender).ForeColor = Color.Silver;
						}
					}
					else if (sender == this.tbTfexPriceCondition)
					{
						if (string.IsNullOrEmpty(((Control)sender).Text))
						{
							((Control)sender).Text = "PRICE";
							((Control)sender).ForeColor = Color.Silver;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("controlOrderTFEX_Leave", ex);
			}
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x000E1DF4 File Offset: 0x000E01F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSmartOneClick(string side, string stock, string price, bool isDeposit)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucSendNewOrder.SetSmartOneClickCallBack(this.SetSmartOneClick), new object[]
				{
					side,
					stock,
					price,
					isDeposit
				});
			}
			else
			{
				try
				{
					this._stockInfo = ApplicationInfo.StockInfo[stock];
					if (this._stockInfo.Number > -1)
					{
						if (isDeposit)
						{
							if (!(ApplicationInfo.SuuportSBL == "Y") || !(ApplicationInfo.AccInfo.CurrentAccountType == "B"))
							{
								this.ShowMessageInFormConfirm("Invalid account type!!!", frmOrderFormConfirm.OpenStyle.Error);
								return;
							}
							if (Settings.Default.BottomStyleEquity != 1)
							{
								this.btnStyle_Click(this.btnStyle1, null);
							}
						}
						else if (Settings.Default.BottomStyleEquity == 5)
						{
							this.btnStyle_Click(this.btnStyle2, null);
						}
						this.SetColorBySide(side);
						this.StartTimerLoadCredit();
						this.cbStock.Text = stock;
						this.chbNVDR.Checked = false;
						this.cbPrice.Enabled = true;
						this.cbPrice.Text = price;
						this.cbDepCollateral.Text = (isDeposit ? "Deposit" : "");
						this.cbCondition.Text = string.Empty;
						if (Settings.Default.SmartClickVolume > -1L)
						{
							this.tbVolume.Text = Settings.Default.SmartClickVolume.ToString();
							this.btnSendOrder.PerformClick();
						}
						else
						{
							this.tbVolume.Focus();
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SetSmartOnClick", ex);
				}
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000E2038 File Offset: 0x000E0438
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentSymbol(string symbol)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucSendNewOrder.SetCurrentSymbolCallBack(this.SetCurrentSymbol), new object[]
				{
					symbol
				});
			}
			else
			{
				this._stockInfo = ApplicationInfo.StockInfo[symbol];
				if (this._stockInfo.Number > 0)
				{
					this.cbMMStock.Text = this._stockInfo.Symbol;
					if (!this.cbMMStock.Items.Contains(symbol))
					{
						this.cbMMStock.Items.Add(symbol);
					}
					this.cbMMPrice.Text = string.Empty;
					this.tbMMStopPrice.Text = string.Empty;
					this.tbMMGiveUp.Text = string.Empty;
					this.cbStock.Text = this._stockInfo.Symbol;
					if (!this.cbStock.Items.Contains(symbol))
					{
						this.cbStock.Items.Add(symbol);
					}
					this.chbNVDR.Checked = false;
					this.cbDepCollateral.Text = "";
					this.cbCondition.Text = string.Empty;
					this.cbPrice.Text = string.Empty;
				}
				else
				{
					this._seriesInfoTfex = ApplicationInfo.SeriesInfo[symbol];
					if (this._seriesInfoTfex.OrderBookId > 0)
					{
						this.cbMMStock.Text = this._seriesInfoTfex.Symbol;
						if (!this.cbMMStock.Items.Contains(symbol))
						{
							this.cbMMStock.Items.Add(symbol);
						}
						this.cbMMPrice.Text = string.Empty;
						this.tbMMStopPrice.Text = string.Empty;
						this.tbMMGiveUp.Text = string.Empty;
						this.tbSeries.Text = this._seriesInfoTfex.Symbol;
					}
					else
					{
						this.tbSeries.Text = ((this._seriesInfoTfex != null) ? this._seriesInfoTfex.Symbol : "");
						this.cbStock.Text = ((this._stockInfo != null) ? this._stockInfo.Symbol : "");
						if (ApplicationInfo.IsEquityAccount)
						{
							this.cbMMStock.Text = ((this._stockInfo != null) ? this._stockInfo.Symbol : "");
						}
						else
						{
							this.tbSeries.Text = ((this._seriesInfoTfex != null) ? this._seriesInfoTfex.Symbol : "");
						}
					}
				}
				if (this._isActive)
				{
					this.StartTimerLoadCredit();
				}
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x000E234C File Offset: 0x000E074C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbVolume_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				Keys keyCode = e.KeyCode;
				long num;
				if (keyCode != Keys.Return)
				{
					switch (keyCode)
					{
					case Keys.Left:
						if (Settings.Default.BottomStyleEquity == 4)
						{
							this.cbStock.Focus();
						}
						else if (this.chbNVDR.Visible)
						{
							this.chbNVDR.Focus();
						}
						else
						{
							this.cbStock.Focus();
						}
						e.SuppressKeyPress = true;
						goto IL_29F;
					case Keys.Up:
						long.TryParse(this.tbVolume.Text.Replace(",", ""), out num);
						if (Settings.Default.BSBoxDefaultVolumeNext > 0L)
						{
							num += Settings.Default.BSBoxDefaultVolumeNext;
						}
						else
						{
							num += (long)((this._stockInfo != null) ? this._stockInfo.BoardLot : 0);
						}
						this.tbVolume.Text = Utilities.VolumeFormat(num, true);
						this.tbVolume.SelectAll();
						e.SuppressKeyPress = true;
						goto IL_29F;
					case Keys.Right:
						break;
					case Keys.Down:
						long.TryParse(this.tbVolume.Text.Replace(",", ""), out num);
						if (Settings.Default.BSBoxDefaultVolumeNext > 0L)
						{
							num -= Settings.Default.BSBoxDefaultVolumeNext;
						}
						else
						{
							num -= (long)((this._stockInfo != null) ? this._stockInfo.BoardLot : 0);
						}
						if (num > 0L)
						{
							this.tbVolume.Text = Utilities.VolumeFormat(num, true);
							this.tbVolume.SelectAll();
						}
						e.SuppressKeyPress = true;
						goto IL_29F;
					default:
						goto IL_29F;
					}
				}
				long.TryParse(this.tbVolume.Text.Replace(",", ""), out num);
				if (num > 0L)
				{
					if (this.tbTimes.Visible && this.tbTimes.Enabled)
					{
						this.tbTimes.Focus();
					}
					else if (this.cbPrice.Visible)
					{
						this.cbPrice.Focus();
					}
				}
				else
				{
					this.tbVolume.SelectAll();
				}
				e.SuppressKeyPress = true;
				IL_29F:;
			}
			catch (Exception ex)
			{
				this.ShowError("tbVolume_KeyDown", ex);
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000E2630 File Offset: 0x000E0A30
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
					if (price == "ATO" || price == "ATC" || price == "MP" || price == "MO" || price == "ML")
					{
						result = true;
						return result;
					}
				}
				if (!FormatUtil.Isnumeric(price))
				{
					if (IsShowMessage)
					{
						this.ShowMessageInFormConfirm("Invalid price.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
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
								this.ShowMessageInFormConfirm("Invalid price format [2 digits]!.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
							}
							result = false;
							return result;
						}
					}
					else if (text.Length > 2)
					{
						if (IsShowMessage)
						{
							this.ShowMessageInFormConfirm("Invalid price format [2 digits]!.", frmOrderFormConfirm.OpenStyle.ShowBox, control);
						}
						result = false;
						return result;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("IsValidPrice", ex);
			}
			result = true;
			return result;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000E27F0 File Offset: 0x000E0BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsValidPrice_TFEX(bool IsShowMessage, string price)
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
					if (price == "MP" || price == "MO" || price == "ML")
					{
						result = true;
						return result;
					}
				}
				if (!FormatUtil.Isnumeric(price))
				{
					if (IsShowMessage)
					{
						this.ShowMessageInFormConfirm("Invalid price.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPriceT);
					}
					result = false;
					return result;
				}
				int num = price.IndexOf('.');
				string text = string.Empty;
				if (num > -1)
				{
					text = price.Substring(num + 1);
					if (text.Length > 4)
					{
						if (IsShowMessage)
						{
							this.ShowMessageInFormConfirm("Invalid price decimal!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPriceT);
						}
						result = false;
						return result;
					}
				}
				decimal d = 0m;
				decimal d2 = 0m;
				decimal d3 = 0m;
				decimal.TryParse(this._seriesInfoTfex.Floor.ToString(), out d2);
				decimal.TryParse(this._seriesInfoTfex.Ceiling.ToString(), out d);
				decimal.TryParse(price.ToString(), out d3);
				if (d3 < d2 || d3 > d)
				{
					this.ShowMessageInFormConfirm("Check Floor price or Ceiling price!!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPriceT);
					result = false;
					return result;
				}
				SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[this.tbSeries.Text.ToUpper().Trim()];
				if (seriesInformation != null && seriesInformation.TickSize > 0m && d3 % seriesInformation.TickSize != 0m)
				{
					this.ShowMessageInFormConfirm("Invalid Price [Check series tick size]!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolumeT);
					result = false;
					return result;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("IsValidPrice_TFEX", ex);
			}
			result = true;
			return result;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000E2A74 File Offset: 0x000E0E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsValidPrice_TFEX(bool IsShowMessage, string price, SeriesList.SeriesInformation series)
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
						this.ShowMessageInFormConfirm("Invalid price.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPriceT);
					}
					result = false;
					return result;
				}
				int num = price.IndexOf('.');
				string text = string.Empty;
				if (num > -1)
				{
					text = price.Substring(num + 1);
					if (text.Length > 4)
					{
						if (IsShowMessage)
						{
							this.ShowMessageInFormConfirm("Invalid price decimal!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPriceT);
						}
						result = false;
						return result;
					}
				}
				decimal d = 0m;
				decimal d2 = 0m;
				decimal d3 = 0m;
				decimal.TryParse(series.Floor.ToString(), out d2);
				decimal.TryParse(series.Ceiling.ToString(), out d);
				decimal.TryParse(price.ToString(), out d3);
				if (d3 < d2 || d3 > d)
				{
					this.ShowMessageInFormConfirm("Check Floor price or Ceiling price!!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbPriceT);
					result = false;
					return result;
				}
				SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[series.Symbol.ToUpper().Trim()];
				if (seriesInformation != null && (seriesInformation.TickSize > 0m && d3 % seriesInformation.TickSize != 0m))
				{
					this.ShowMessageInFormConfirm("Invalid Price [Check series tick size]!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbVolumeT);
					result = false;
					return result;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("IsValidPrice_TFEX", ex);
			}
			result = true;
			return result;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000E2CCC File Offset: 0x000E10CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbTimes_KeyDown(object sender, KeyEventArgs e)
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
						this.tbVolume.Focus();
						goto IL_63;
					case Keys.Up:
						goto IL_63;
					case Keys.Right:
						break;
					default:
						goto IL_63;
					}
				}
				this.cbPrice.Focus();
				e.SuppressKeyPress = true;
				IL_63:;
			}
			catch (Exception ex)
			{
				this.ShowError("tbTimes_KeyDown", ex);
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000E2D68 File Offset: 0x000E1168
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPrice_KeyDown(object sender, KeyEventArgs e)
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
						if (ApplicationInfo.SupportOrderTimes)
						{
							int num = 0;
							int.TryParse(this.tbTimes.Text, out num);
							if (num > 0)
							{
								this.tbTimes.Focus();
							}
							else
							{
								this.tbVolume.Focus();
							}
						}
						else
						{
							this.tbVolume.Focus();
						}
						e.SuppressKeyPress = true;
						break;
					case Keys.Up:
						this.cbPrice.Text = Utilities.PriceFormat(this.GetPrice(this.cbPrice, true));
						this.cbPrice.SelectAll();
						e.SuppressKeyPress = true;
						break;
					case Keys.Right:
						if (this.IsValidPrice(this.cbPrice.Text, false, this.cbPrice))
						{
							if (Settings.Default.BottomStyleEquity == 2)
							{
								this.tbPin.Focus();
							}
							else if (Settings.Default.BottomStyleEquity == 4)
							{
								this.cbCondition.Focus();
							}
							else
							{
								this.tbPublic.Focus();
							}
						}
						e.SuppressKeyPress = true;
						break;
					case Keys.Down:
						this.cbPrice.Text = Utilities.PriceFormat(this.GetPrice(this.cbPrice, false));
						this.cbPrice.SelectAll();
						e.SuppressKeyPress = true;
						break;
					}
				}
				else
				{
					if (this.IsValidPrice(this.cbPrice.Text, true, this.cbPrice))
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
				this.ShowError("cbPrice_KeyDown", ex);
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000E2FD4 File Offset: 0x000E13D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private decimal GetPrice(object objPrice, bool isIncrease)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			decimal num = 0m;
			try
			{
				string stockSymbol = string.Empty;
				string s = string.Empty;
				if (objPrice == this.cbPrice)
				{
					stockSymbol = this.cbStock.Text.Trim().ToUpper();
					s = this.cbPrice.Text;
				}
				else if (objPrice == this.cbMMPrice)
				{
					stockSymbol = this.cbMMStock.Text.Trim().ToUpper();
					s = this.cbMMPrice.Text;
				}
				else if (objPrice == this.tbMMStopPrice)
				{
					stockSymbol = this.cbMMStock.Text.Trim().ToUpper();
					s = this.tbMMStopPrice.Text;
				}
				StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[stockSymbol];
				if (stockInformation != null && stockInformation.Number > 0)
				{
					if (decimal.TryParse(s, out num))
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

		// Token: 0x06000C0F RID: 3087 RVA: 0x000E31D8 File Offset: 0x000E15D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000E3214 File Offset: 0x000E1614
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000E3248 File Offset: 0x000E1648
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbNDVR_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				if (keyCode == Keys.Add)
				{
					this.chbNVDR.Checked = !this.chbNVDR.Checked;
				}
			}
			else
			{
				this.tbVolume.Focus();
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000E32B0 File Offset: 0x000E16B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbNVDR_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ShowCreditValueEquity();
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000E32C8 File Offset: 0x000E16C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPublic_KeyDown(object sender, KeyEventArgs e)
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
				case Keys.Up:
					this.cbPrice.Focus();
					return;
				case Keys.Right:
					break;
				default:
					return;
				}
			}
			this.cbCondition.Focus();
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000E3330 File Offset: 0x000E1730
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPublic_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isLockPubVol && this.tbPublic.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbPublic.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbPublic.Text.Replace(",", ""));
							this.tbPublic.Text = num.ToString("#,###");
							this.tbPublic.Select(this.tbPublic.Text.Length, 0);
						}
						catch
						{
							this.tbPublic.Text = this.tbPublic.Text.Substring(0, this.tbPublic.Text.Length - 1);
						}
					}
					else
					{
						this.tbPublic.Text = this.tbPublic.Text.Substring(0, this.tbPublic.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbPublic_TextChanged", ex);
			}
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000E34C0 File Offset: 0x000E18C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbCondition_KeyDown(object sender, KeyEventArgs e)
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
					if (Settings.Default.BottomStyleEquity == 4)
					{
						this.cbPrice.Focus();
					}
					else
					{
						this.tbPublic.Focus();
					}
					break;
				case Keys.Right:
					if (Settings.Default.BottomStyleEquity == 4)
					{
						if (Settings.Default.BSBoxEntryTTF)
						{
							this.chbNVDR.Focus();
						}
						else
						{
							this.tbPin.Focus();
						}
					}
					else if (Settings.Default.BottomStyleEquity == 3)
					{
						this.tbPin.Focus();
					}
					else if (this.cbDepCollateral.Enabled)
					{
						this.cbDepCollateral.Focus();
					}
					else
					{
						this.cbCondition.Focus();
					}
					e.SuppressKeyPress = true;
					break;
				}
			}
			else
			{
				this.btnSendOrder.PerformClick();
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000E360C File Offset: 0x000E1A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbDepCollateral_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				if (keyCode == Keys.Left)
				{
					if (Settings.Default.BottomStyleEquity == 1)
					{
						this.cbCondition.Focus();
					}
					else
					{
						this.tbPublic.Focus();
					}
				}
			}
			else
			{
				this.btnSendOrder.PerformClick();
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000E3690 File Offset: 0x000E1A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplash(bool visible, string message, bool isAutoClose)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucSendNewOrder.ShowSplashCallBack(this.ShowSplash), new object[]
				{
					visible,
					message,
					isAutoClose
				});
			}
			else if (ApplicationInfo.SuuportSplash == "Y")
			{
				try
				{
					if (visible)
					{
						this.lbLoading.Text = message;
						this.lbLoading.Left = (base.Width - this.lbLoading.Width) / 2;
						this.lbLoading.Top = (base.Height - this.lbLoading.Height) / 2;
						this.lbLoading.Visible = true;
						this.lbLoading.BringToFront();
						if (isAutoClose)
						{
							if (this.tmCloseSplash == null)
							{
								this.tmCloseSplash = new System.Windows.Forms.Timer();
								this.tmCloseSplash.Interval = 500;
								this.tmCloseSplash.Tick += new EventHandler(this.tmCloseSplash_Tick);
							}
							this.tmCloseSplash.Enabled = false;
							this.tmCloseSplash.Enabled = true;
						}
					}
					else
					{
						this.lbLoading.Visible = false;
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ShowSplash", ex);
				}
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000E3834 File Offset: 0x000E1C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmCloseSplash_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tmCloseSplash.Enabled = false;
			this.ShowSplash(false, "", false);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000E3860 File Offset: 0x000E1C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbDepCollateral_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.ShowCreditValueEquity();
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000E3878 File Offset: 0x000E1C78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbCondition_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000E38B4 File Offset: 0x000E1CB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucSendNewOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ApplicationInfo.IsOrderBoxFocus = true;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000E38CC File Offset: 0x000E1CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucSendNewOrder_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ApplicationInfo.IsOrderBoxFocus = false;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000E38E4 File Offset: 0x000E1CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchAccountControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.cbAccount.InvokeRequired)
			{
				this.cbAccount.Invoke(new MethodInvoker(this.SwitchAccountControl));
			}
			else if (this.cbAccount.Items.Count > 1)
			{
				if (this.cbAccount.SelectedIndex + 1 < this.cbAccount.Items.Count)
				{
					this.cbAccount.SelectedIndex++;
				}
				else
				{
					this.cbAccount.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000E39A4 File Offset: 0x000E1DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._isActive)
			{
				this.timerSwitchAccount.Stop();
				this.timerSwitchAccount.Start();
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000E39EC File Offset: 0x000E1DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerSwitchAccount_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timerSwitchAccount.Stop();
				ApplicationInfo.AccInfo.CurrentAccount = this.GetAccount(this.cbAccount.Text.Trim());
				if (ApplicationInfo.AccInfo.Items.ContainsKey(ApplicationInfo.AccInfo.CurrentAccount))
				{
					string market = ApplicationInfo.AccInfo.Items[ApplicationInfo.AccInfo.CurrentAccount].Market;
					if (market == "E")
					{
						ApplicationInfo.IsEquityAccount = true;
					}
					else
					{
						if (!(market == "T"))
						{
							return;
						}
						ApplicationInfo.IsEquityAccount = false;
					}
					this.tbBuyLimit.Text = "Loading...";
					this.tbOnHand.Text = "Loading...";
					this.tbEquity.Text = "Loading...";
					if (ApplicationInfo.IsEquityAccount)
					{
						AccountInfo.ItemInfo itemInfo;
						if (ApplicationInfo.AccInfo.Items.TryGetValue(ApplicationInfo.AccInfo.CurrentAccount, out itemInfo))
						{
							if (itemInfo.AccountType == string.Empty)
							{
								string switchAccountInfo = ApplicationInfo.WebOrderService.GetSwitchAccountInfo(ApplicationInfo.AccInfo.CurrentAccount);
								if (!string.IsNullOrEmpty(switchAccountInfo))
								{
									using (DataSet dataSet = new DataSet())
									{
										MyDataHelper.StringToDataSet(switchAccountInfo, dataSet);
										if (dataSet != null && dataSet.Tables.Contains("INFO") && dataSet.Tables["INFO"].Rows.Count > 0)
										{
											itemInfo.AccountType = dataSet.Tables["INFO"].Rows[0]["sAccType"].ToString().Trim();
											itemInfo.PcFlag = dataSet.Tables["INFO"].Rows[0]["sPC"].ToString();
											if (ApplicationInfo.SupportFreewill)
											{
												itemInfo.TraderId = dataSet.Tables["INFO"].Rows[0]["traderid"].ToString();
											}
										}
										ApplicationInfo.AccInfo.CurrentCommRate = 0m;
										if (dataSet.Tables.Contains("COMM_RATE") && dataSet.Tables["COMM_RATE"].Rows.Count > 0)
										{
											decimal.TryParse(dataSet.Tables["COMM_RATE"].Rows[0]["commrate"].ToString(), out ApplicationInfo.AccInfo.CurrentCommRate);
											decimal.TryParse(dataSet.Tables["COMM_RATE"].Rows[0]["trading_fee"].ToString(), out ApplicationInfo.AccInfo.CurrentTradingFee);
											decimal.TryParse(dataSet.Tables["COMM_RATE"].Rows[0]["clearing_fee"].ToString(), out ApplicationInfo.AccInfo.CurrentClearingFee);
										}
										if (dataSet != null && dataSet.Tables.Contains("eservice") && dataSet.Tables["eservice"].Rows.Count > 0)
										{
											ApplicationInfo.EserviceServer = ApplicationInfo.EserviceServer + "?txtParam=" + dataSet.Tables["eservice"].Rows[0]["control_value"].ToString().Trim();
										}
										dataSet.Clear();
									}
								}
							}
							ApplicationInfo.AccInfo.CurrentAccountType = itemInfo.AccountType;
							if (itemInfo.PcFlag == "M" || itemInfo.PcFlag == "U")
							{
								ApplicationInfo.AccInfo.CurrInternetUser = ApplicationInfo.AccInfo.InternetMutualUser;
							}
							else
							{
								ApplicationInfo.AccInfo.CurrInternetUser = ApplicationInfo.AccInfo.InternetUser;
							}
							lock (((ICollection)ApplicationInfo.AutoGetOrderNoList).SyncRoot)
							{
								ApplicationInfo.AutoGetOrderNoList.Clear();
							}
							this.SwitchMarket();
							this.SetResize();
							this.StartTimerLoadCredit();
							if (!this.bgwGetEquity.IsBusy)
							{
								this.bgwGetEquity.RunWorkerAsync();
							}
						}
						else
						{
							ApplicationInfo.AutoGetOrderNoList.Clear();
							this._creditType = 0;
							this._buyCreditLimit = 0m;
							this._totalCreditLimit = 0m;
							if (this._tdsCredit != null)
							{
								this._tdsCredit.Clear();
							}
							this.ShowCreditValueEquity();
						}
					}
					else
					{
						this.SwitchMarket();
						this.SetResize();
						this.StartTimerLoadCredit();
					}
					if (this.OnAccountChanged != null)
					{
						this.OnAccountChanged(ApplicationInfo.AccInfo.CurrentAccount);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("timerSwitchAccount_Tick", ex);
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000E400C File Offset: 0x000E240C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetAccount(string text)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result;
			try
			{
				int num = text.IndexOf("(");
				if (num > -1)
				{
					result = text.Substring(0, num - 1).Trim();
					return result;
				}
				result = text;
				return result;
			}
			catch (Exception ex)
			{
				this.ShowError("GetAccount", ex);
			}
			result = text;
			return result;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000E4090 File Offset: 0x000E2490
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SwitchMarket()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.SwitchMarket));
			}
			else
			{
				try
				{
					base.SuspendLayout();
					if (ApplicationInfo.IsEquityAccount)
					{
						if (this._lastEquityStyle > 0)
						{
							Settings.Default.BottomStyleEquity = this._lastEquityStyle;
						}
						this.lbBuyLimit.Visible = true;
						this.tbBuyLimit.Visible = true;
						this.lbOnHand.Visible = true;
						this.tbOnHand.Visible = true;
						this.btnRisk.Visible = false;
						this.btnNotification.Visible = ApplicationInfo.SupportNod;
						this.btnShowStockAlert.Visible = true;
						this.btnCleanPort.Visible = true;
						this.btnStyle1.Visible = true;
						this.btnStyle2.Visible = true;
						this.btnStyle3.Visible = true;
						this.btnStyle4.Visible = true;
						this.btnStyleMM.Visible = true;
						this.btnSetting.Visible = true;
						this.DoClear();
						this.lbBuyLimit.Text = "Buy Limit : ";
						this.lbOnHand.Text = "OnHand : ";
						this.lbEquity.Visible = false;
						this.tbEquity.Visible = false;
						this.SetVisibleControlEquity();
						this.SetColorBySide(this._showSide);
						if (Settings.Default.BottomStyleEquity == 5)
						{
							this.cbMMStock.Focus();
							this.cbMMStock.SelectAll();
						}
						else
						{
							this.cbStock.Focus();
							this.cbStock.SelectAll();
						}
					}
					else
					{
						if (this._lastTfexStyle > 0)
						{
							Settings.Default.BottomStyleTfex = this._lastTfexStyle;
						}
						this.lbBuyLimit.Text = "Line Available :";
						this.lbOnHand.Text = "Excess Equity :";
						this.lbEquity.Visible = true;
						this.tbEquity.Visible = true;
						this.DoClear();
						this.btnRisk.Visible = false;
						this.btnNotification.Visible = false;
						this.btnShowStockAlert.Visible = false;
						this.btnCleanPort.Visible = false;
						this.btnStyle3.Visible = false;
						this.btnStyle4.Visible = false;
						this.btnSetting.Visible = false;
						if (Settings.Default.BottomStyleEquity == 5)
						{
							Settings.Default.BottomStyleEquity = 1;
						}
						this.SetVisibleControlTfex();
						this.SetColorBySide(this._showSideTFEX);
						if (this._showSideTFEX != string.Empty)
						{
							this.tbSeries.Focus();
							this.tbSeries.SelectAll();
						}
					}
					if (this.OnBoxStyleChanged != null)
					{
						this.OnBoxStyleChanged();
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SwitchMarket", ex);
				}
				finally
				{
					base.ResumeLayout();
				}
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000E4428 File Offset: 0x000E2828
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnStyle_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender == this.btnStyle1)
				{
					Settings.Default.BottomStyleEquity = 1;
				}
				else if (sender == this.btnStyle2)
				{
					Settings.Default.BottomStyleEquity = 2;
				}
				else if (sender == this.btnStyle3)
				{
					Settings.Default.BottomStyleEquity = 3;
				}
				else if (sender == this.btnStyle4)
				{
					Settings.Default.BottomStyleEquity = 4;
				}
				else if (sender == this.btnStyleMM)
				{
					Settings.Default.BottomStyleEquity = 5;
				}
				if (ApplicationInfo.IsEquityAccount)
				{
					this.SetVisibleControlEquity();
					this.SetColorBySide(this._showSide);
				}
				else
				{
					this.SetVisibleControlTfex();
					this.SetColorBySide(this._showSideTFEX);
				}
				if (this.OnBoxStyleChanged != null)
				{
					this.OnBoxStyleChanged();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnStyle_Click", ex);
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000E4588 File Offset: 0x000E2988
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSetting_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.OpenSystemOptionForm();
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x000E45A0 File Offset: 0x000E29A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenSystemOptionForm()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.OpenSystemOptionForm));
			}
			else
			{
				try
				{
					ucBSSetting ucBSSetting = null;
					if (ucBSSetting == null || ucBSSetting.IsDisposed)
					{
						ucBSSetting = new ucBSSetting();
						ucBSSetting.TopLevel = false;
						ucBSSetting.Parent = TemplateManager.Instance.MainForm;
					}
					ucBSSetting.Left = (ucBSSetting.Parent.Width - ucBSSetting.Width) / 2;
					ucBSSetting.Top = (ucBSSetting.Parent.Height - ucBSSetting.Height) / 2;
					ucBSSetting.Show();
					ucBSSetting.BringToFront();
				}
				catch (Exception ex)
				{
					this.ShowError("OpenSystemOptionForm", ex);
				}
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000E4698 File Offset: 0x000E2A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rbSide_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string colorBySide = string.Empty;
			if (sender == this.rbBuy && this.rbBuy.Checked)
			{
				colorBySide = "B";
			}
			else if (sender == this.rbSell && this.rbSell.Checked)
			{
				colorBySide = "S";
			}
			else if (sender == this.rbShort && this.rbShort.Checked)
			{
				colorBySide = "H";
			}
			else
			{
				if (sender != this.rbCover || !this.rbCover.Checked)
				{
					return;
				}
				colorBySide = "C";
			}
			this.SetColorBySide(colorBySide);
			this.ShowCreditValueEquity();
			if (this._isActive)
			{
				this.cbStock.Focus();
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000E47B4 File Offset: 0x000E2BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbSide_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string text = this.cbSide.Text.ToLower();
			if (text != null)
			{
				if (!(text == "buy"))
				{
					if (!(text == "sell"))
					{
						if (!(text == "short"))
						{
							if (text == "cover")
							{
								this.SetColorBySide("C");
							}
						}
						else
						{
							this.SetColorBySide("H");
						}
					}
					else
					{
						this.SetColorBySide("S");
					}
				}
				else
				{
					this.SetColorBySide("B");
				}
			}
			this.ShowCreditValueEquity();
			if (this._isActive)
			{
				this.cbStock.Focus();
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000E4894 File Offset: 0x000E2C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVisibleControlEquity()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._lastEquityStyle = Settings.Default.BottomStyleEquity;
				if (!(ApplicationInfo.SuuportSBL == "Y") || !(ApplicationInfo.AccInfo.CurrentAccountType == "B"))
				{
					if (this._showSide == "C" || this._showSide == "H")
					{
						this._showSide = string.Empty;
					}
				}
				if (Settings.Default.BottomStyleEquity == 5)
				{
					this.tbMMPin.Text = ApplicationInfo.UserPincodeLastEntry;
					this.btnMMBuy.Text = "Buy";
					this.btnMMSell.Text = "Sell";
					this.btnMMCover.Visible = (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B");
					this.btnMMShort.Visible = (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B");
					if (this._showSide == "S" || this._showSide == "C")
					{
						this.lbMMStopPrice.Visible = false;
						this.tbMMStopPrice.Visible = false;
						this.lbMMTotalLoss.Visible = false;
						this.tbMMTotalLoss.Visible = false;
						if (this._showSide == "S")
						{
							this.lbMMGiveUp.Text = "Sell(%)";
						}
						else
						{
							this.lbMMGiveUp.Text = "Cover(%)";
						}
						this.chbMMAutoStopLoss.Visible = false;
						this.chbMMAutoStopLoss.Checked = false;
					}
					else
					{
						this.lbMMStopPrice.Visible = true;
						this.tbMMStopPrice.Visible = true;
						this.lbMMTotalLoss.Visible = true;
						this.tbMMTotalLoss.Visible = true;
						this.lbMMGiveUp.Text = "%Give up";
						if (ApplicationInfo.IsAutoTradeSupport(16))
						{
							this.chbMMAutoStopLoss.Visible = true;
						}
						else
						{
							this.chbMMAutoStopLoss.Visible = false;
						}
					}
					if (this._showSide == "S" || this._showSide == "C")
					{
						this.lbMMGiveUp.Left = this.cbMMPrice.Right + 10;
					}
					else
					{
						this.lbMMGiveUp.Left = this.tbMMStopPrice.Right + 10;
					}
					this.tbMMGiveUp.Left = this.lbMMGiveUp.Right + 3;
					this.panelMMPosition.Visible = false;
				}
				else
				{
					foreach (Control control in this.panelEquity.Controls)
					{
						control.Visible = false;
					}
					this.chbNVDR.Checked = false;
					this.lbPin.Visible = true;
					this.tbPin.Visible = true;
					if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B" && Settings.Default.BottomStyleEquity != 2 && Settings.Default.BottomStyleEquity != 4)
					{
						this.lbDep.Show();
						this.cbDepCollateral.Show();
					}
					this.btnSendOrder.Visible = true;
					this.btnClear.Visible = true;
					this.rbShort.Visible = false;
					this.rbCover.Visible = false;
					if (Settings.Default.BottomStyleEquity == 1)
					{
						this.lbSide.Visible = true;
						this.cbSide.Visible = true;
						this.lbStock.Visible = true;
						this.cbStock.Visible = true;
						this.chbNVDR.Visible = true;
						this.lbVolume.Visible = true;
						this.tbVolume.Visible = true;
						if (ApplicationInfo.SupportOrderTimes)
						{
							this.lbTimes.Visible = true;
							this.tbTimes.Visible = true;
						}
						this.lbPrice.Visible = true;
						this.cbPrice.Visible = true;
						this.lbPublic.Visible = true;
						this.tbPublic.Visible = true;
						this.lbCondition.Visible = true;
						this.cbCondition.Visible = true;
					}
					else if (Settings.Default.BottomStyleEquity == 2)
					{
						this.rbBuy.Visible = true;
						this.rbSell.Visible = true;
						if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
						{
							this.rbShort.Visible = true;
							this.rbCover.Visible = true;
						}
						this.lbStock.Visible = true;
						this.cbStock.Visible = true;
						this.lbVolume.Visible = true;
						this.tbVolume.Visible = true;
						this.btnVolInc.Visible = true;
						this.btnVolDec.Visible = true;
						this.lbPrice.Visible = true;
						this.cbPrice.Visible = true;
						this.btnPriceInc.Visible = true;
						this.btnPriceDec.Visible = true;
					}
					else if (Settings.Default.BottomStyleEquity == 3)
					{
						this.rbBuy.Visible = true;
						this.rbSell.Visible = true;
						if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
						{
							this.rbShort.Visible = true;
							this.rbCover.Visible = true;
						}
						this.cbStock.Visible = true;
						this.chbNVDR.Visible = true;
						this.lbVolume.Visible = true;
						this.tbVolume.Visible = true;
						this.btnVolInc.Visible = true;
						this.btnVolDec.Visible = true;
						this.lbPublic.Visible = true;
						this.tbPublic.Visible = true;
						this.btnPBDec.Visible = true;
						this.btnPBInc.Visible = true;
						this.lbPrice.Visible = true;
						this.cbPrice.Visible = true;
						this.btnPriceInc.Visible = true;
						this.btnPriceDec.Visible = true;
						this.lbCondition.Visible = true;
						this.cbCondition.Visible = true;
					}
					else if (Settings.Default.BottomStyleEquity == 4)
					{
						this.rbBuy.Visible = true;
						this.rbSell.Visible = true;
						if (ApplicationInfo.SuuportSBL == "Y" && ApplicationInfo.AccInfo.CurrentAccountType == "B")
						{
							this.rbShort.Visible = true;
							this.rbCover.Visible = true;
						}
						this.lbStock.Visible = true;
						this.cbStock.Visible = true;
						this.lbVolume.Visible = true;
						this.tbVolume.Visible = true;
						this.lbPrice.Visible = true;
						this.cbPrice.Visible = true;
						this.lbCondition.Visible = true;
						this.cbCondition.Visible = true;
						this.chbNVDR.Visible = true;
					}
					this.tbPin.Text = ApplicationInfo.UserPincodeLastEntry;
				}
				this.btnStyle1.FlatAppearance.BorderSize = 0;
				this.btnStyle2.FlatAppearance.BorderSize = 0;
				this.btnStyle3.FlatAppearance.BorderSize = 0;
				this.btnStyle4.FlatAppearance.BorderSize = 0;
				this.btnStyleMM.FlatAppearance.BorderSize = 0;
				if (Settings.Default.BottomStyleEquity == 1)
				{
					this.btnStyle1.FlatAppearance.BorderSize = 1;
				}
				else if (Settings.Default.BottomStyleEquity == 2)
				{
					this.btnStyle2.FlatAppearance.BorderSize = 1;
				}
				else if (Settings.Default.BottomStyleEquity == 3)
				{
					this.btnStyle3.FlatAppearance.BorderSize = 1;
				}
				else if (Settings.Default.BottomStyleEquity == 4)
				{
					this.btnStyle4.FlatAppearance.BorderSize = 1;
				}
				else if (Settings.Default.BottomStyleEquity == 5)
				{
					this.btnStyleMM.FlatAppearance.BorderSize = 1;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetVisibleControlEquity", ex);
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000E52F8 File Offset: 0x000E36F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVisibleControlTfex()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._lastTfexStyle = Settings.Default.BottomStyleTfex;
				if (Settings.Default.BottomStyleEquity == 5)
				{
					this.btnMMShort.Visible = false;
					this.btnMMCover.Visible = false;
					this.btnMMBuy.Text = "Long";
					this.btnMMSell.Text = "Short";
					this.panelMMPosition.Visible = true;
					this.tbMMPin.Text = ApplicationInfo.UserPincodeLastEntry;
					if (this.rdbMMOpenPos.Checked)
					{
						this._OrdPosition = "O";
					}
					else if (this.rdbMMClosePos.Checked)
					{
						this._OrdPosition = "C";
					}
					if (this._OrdPosition == "C")
					{
						this.lbMMStopPrice.Visible = false;
						this.tbMMStopPrice.Visible = false;
						this.lbMMTotalLoss.Visible = false;
						this.tbMMTotalLoss.Visible = false;
						this.lbMMGiveUp.Text = "Close(%)";
						this.chbMMAutoStopLoss.Visible = false;
						this.chbMMAutoStopLoss.Checked = false;
						this.lbMMGiveUp.Left = this.cbMMPrice.Right + 10;
					}
					else
					{
						this.lbMMStopPrice.Visible = true;
						this.tbMMStopPrice.Visible = true;
						this.lbMMTotalLoss.Visible = true;
						this.tbMMTotalLoss.Visible = true;
						this.lbMMGiveUp.Text = "%Give up";
						if (ApplicationInfo.IsSupportAutoTradeTFEX && ApplicationInfo.IsAutoTradeSupport(16))
						{
							this.chbMMAutoStopLoss.Visible = true;
						}
						else
						{
							this.chbMMAutoStopLoss.Checked = false;
							this.chbMMAutoStopLoss.Visible = false;
						}
						this.lbMMGiveUp.Left = this.tbMMStopPrice.Right + 10;
					}
					this.tbMMGiveUp.Left = this.lbMMGiveUp.Right + 3;
				}
				else if (Settings.Default.BottomStyleEquity == 1)
				{
					this.lbPublishT.Visible = true;
					this.tbPublishT.Visible = true;
					this.lbValidityT.Visible = true;
					this.cbValidityT.Visible = true;
					this.lbPriceTypeT.Visible = true;
					this.cbPriceTypeT.Visible = true;
					this.chbTfexStopOrder.Visible = true;
					this.cbPosition.Visible = true;
					this.panelTfexPosition.Visible = false;
					this.panelMMPosition.Visible = false;
				}
				else if (Settings.Default.BottomStyleEquity == 2)
				{
					this.lbPublishT.Visible = false;
					this.tbPublishT.Visible = false;
					this.lbValidityT.Visible = false;
					this.cbValidityT.Visible = false;
					this.lbPriceTypeT.Visible = false;
					this.cbPriceTypeT.Visible = false;
					this.chbTfexStopOrder.Checked = false;
					this.chbTfexStopOrder.Visible = false;
					this.cbPosition.Visible = false;
					this.panelTfexPosition.Visible = true;
					this.panelMMPosition.Visible = false;
				}
				this.btnStyle1.FlatAppearance.BorderSize = 0;
				this.btnStyle2.FlatAppearance.BorderSize = 0;
				this.btnStyleMM.FlatAppearance.BorderSize = 0;
				if (Settings.Default.BottomStyleEquity == 1)
				{
					this.btnStyle1.FlatAppearance.BorderSize = 1;
				}
				if (Settings.Default.BottomStyleEquity == 2)
				{
					this.btnStyle2.FlatAppearance.BorderSize = 1;
				}
				else if (Settings.Default.BottomStyleEquity == 5)
				{
					this.btnStyleMM.FlatAppearance.BorderSize = 1;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetVisibleControlTfex", ex);
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000E577C File Offset: 0x000E3B7C
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
						if (Settings.Default.BottomStyleEquity == 2)
						{
							this.cbPrice.Focus();
						}
						else if (Settings.Default.BottomStyleEquity == 3)
						{
							this.cbCondition.Focus();
						}
						else if (Settings.Default.BottomStyleEquity == 4)
						{
							this.chbNVDR.Focus();
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

		// Token: 0x06000C2A RID: 3114 RVA: 0x000E5894 File Offset: 0x000E3C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnVolInc_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num;
				long.TryParse(this.tbVolume.Text.Replace(",", ""), out num);
				if (Settings.Default.BSBoxDefaultVolumeNext > 0L)
				{
					num += Settings.Default.BSBoxDefaultVolumeNext;
				}
				else if (this._stockInfo != null)
				{
					num += (long)this._stockInfo.BoardLot;
				}
				this.tbVolume.Text = Utilities.VolumeFormat(num, true);
			}
			catch (Exception ex)
			{
				this.ShowError("btnVolInc_Click", ex);
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000E5960 File Offset: 0x000E3D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnVolDec_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num;
				long.TryParse(this.tbVolume.Text.Replace(",", ""), out num);
				long num2 = 0L;
				if (Settings.Default.BSBoxDefaultVolumeNext > 0L)
				{
					num2 = Settings.Default.BSBoxDefaultVolumeNext;
				}
				else if (this._stockInfo != null)
				{
					num2 = (long)this._stockInfo.BoardLot;
				}
				if (num - num2 > 0L)
				{
					num -= num2;
					this.tbVolume.Text = Utilities.VolumeFormat(num, true);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnVolDec_Click", ex);
			}
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000E5A44 File Offset: 0x000E3E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPriceInc_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.cbPrice.Text = Utilities.PriceFormat(this.GetPrice(this.cbPrice, true));
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000E5A78 File Offset: 0x000E3E78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPriceDec_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.cbPrice.Text = Utilities.PriceFormat(this.GetPrice(this.cbPrice, false));
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000E5AAC File Offset: 0x000E3EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPBInc_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num;
				long.TryParse(this.tbPublic.Text.Replace(",", ""), out num);
				if (Settings.Default.BSBoxDefaultVolumeNext > 0L)
				{
					num += Settings.Default.BSBoxDefaultVolumeNext;
				}
				else if (this._stockInfo != null)
				{
					num += (long)this._stockInfo.BoardLot;
				}
				this.tbPublic.Text = Utilities.VolumeFormat(num, true);
			}
			catch (Exception ex)
			{
				this.ShowError("btnPBInc_Click", ex);
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000E5B78 File Offset: 0x000E3F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPBDec_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num;
				long.TryParse(this.tbPublic.Text.Replace(",", ""), out num);
				long num2 = 0L;
				if (Settings.Default.BSBoxDefaultVolumeNext > 0L)
				{
					num2 = Settings.Default.BSBoxDefaultVolumeNext;
				}
				else if (this._stockInfo != null)
				{
					num2 = (long)this._stockInfo.BoardLot;
				}
				if (num - num2 > 0L)
				{
					num -= num2;
					this.tbPublic.Text = Utilities.VolumeFormat(num, true);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnPBDec_Click", ex);
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000E5C5C File Offset: 0x000E405C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbStock_DragDrop(object sender, DragEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				DragItemData dragItemData = (DragItemData)e.Data.GetData(typeof(DragItemData).ToString());
				this.cbStock.Text = dragItemData.DragText;
				this.cbStock.Focus();
			}
			catch (Exception ex)
			{
				this.ShowError("cbStock_DragDrop", ex);
			}
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x000E5CE4 File Offset: 0x000E40E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbStock_DragEnter(object sender, DragEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.Effect = DragDropEffects.Move;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000E5D00 File Offset: 0x000E4100
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
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_3BC;
					case Keys.Left:
						if (Settings.Default.BottomStyleEquity == 1)
						{
							this.cbSide.Focus();
						}
						e.SuppressKeyPress = true;
						goto IL_3BC;
					case Keys.Up:
						goto IL_3BC;
					case Keys.Right:
						break;
					default:
						goto IL_3BC;
					}
				}
				if (this.cbStock.Text.Trim() != string.Empty)
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbStock.Text.Trim()];
					if (stockInformation.Number > 0)
					{
						this._stockInfo = stockInformation;
						TemplateManager.Instance.SendSymbolLink(this, SymbolLinkSource.StockSymbol, this._stockInfo.Symbol);
						ApplicationInfo.CurrentSymbol = this._stockInfo.Symbol;
						if (!this.cbStock.Items.Contains(this._stockInfo.Symbol))
						{
							this.cbStock.Items.Add(this._stockInfo.Symbol);
						}
						if (this.cbPrice.Text == string.Empty)
						{
							if (Settings.Default.BSBoxDefaultPrice == 1)
							{
								this.cbPrice.Text = ((this._stockInfo.LastSalePrice > 0m) ? Utilities.PriceFormat(this._stockInfo.LastSalePrice) : Utilities.PriceFormat(this._stockInfo.PriorPrice));
							}
							else if (Settings.Default.BSBoxDefaultPrice == 2)
							{
								if (this._showSide == "B" || this._showSide == "C")
								{
									this.cbPrice.Text = Utilities.PriceFormat(this._stockInfo.OfferPrice1);
								}
								else if (this._showSide == "S" || this._showSide == "H")
								{
									this.cbPrice.Text = Utilities.PriceFormat(this._stockInfo.BidPrice1);
								}
							}
						}
						if (this.tbVolume.Text == string.Empty)
						{
							if (Settings.Default.BSBoxDefaultVolumeActive && Settings.Default.BSBoxDefaultVolume > 0L)
							{
								this.tbVolume.Text = Utilities.VolumeFormat(Settings.Default.BSBoxDefaultVolume, true);
							}
						}
						if (Settings.Default.BottomStyleEquity == 2 || Settings.Default.BottomStyleEquity == 4)
						{
							this.tbVolume.Focus();
						}
						else if (Settings.Default.BSBoxEntryTTF)
						{
							this.chbNVDR.Focus();
						}
						else
						{
							this.tbVolume.Focus();
						}
					}
					else
					{
						this.cbStock.Text = this._stockInfo.Symbol;
						this.cbStock.Focus();
						this.cbStock.SelectAll();
					}
				}
				e.SuppressKeyPress = true;
				IL_3BC:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbStock_KeyDown", ex);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000E6104 File Offset: 0x000E4504
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbStock_KeyPress(object sender, KeyPressEventArgs e)
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

		// Token: 0x06000C34 RID: 3124 RVA: 0x000E616C File Offset: 0x000E456C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbSide_KeyPress(object sender, KeyPressEventArgs e)
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
				this.ShowError("cbSide_KeyPress", ex);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000E61D4 File Offset: 0x000E45D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbSide_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode <= Keys.Right)
			{
				if (keyCode != Keys.Return)
				{
					switch (keyCode)
					{
					case Keys.Left:
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
				string text = this.cbSide.Text.ToLower();
				if (text != null)
				{
					if (!(text == "buy"))
					{
						if (!(text == "sell"))
						{
							if (!(text == "short"))
							{
								if (text == "cover")
								{
									this.SetColorBySide("C");
								}
							}
							else
							{
								this.SetColorBySide("H");
							}
						}
						else
						{
							this.SetColorBySide("S");
						}
					}
					else
					{
						this.SetColorBySide("B");
					}
				}
				this.cbStock.Focus();
			}
			else
			{
				switch (keyCode)
				{
				case Keys.B:
					break;
				case Keys.C:
					goto IL_154;
				default:
					if (keyCode == Keys.H)
					{
						goto IL_154;
					}
					if (keyCode != Keys.S)
					{
						return;
					}
					break;
				}
				this.SetColorBySide(e.KeyCode.ToString());
				this.cbStock.Focus();
				e.SuppressKeyPress = true;
				return;
				IL_154:
				if (ApplicationInfo.SuuportSBL == "Y")
				{
					this.SetColorBySide(e.KeyCode.ToString());
				}
				this.cbStock.Focus();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000E6380 File Offset: 0x000E4780
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPolicy_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				foreach (Control control in base.Controls)
				{
					if (control.GetType() == typeof(frmRiskControl))
					{
						return;
					}
				}
				frmRiskControl frmRiskControl = new frmRiskControl();
				frmRiskControl.TopLevel = false;
				frmRiskControl.Parent = TemplateManager.Instance.MainForm;
				frmRiskControl.Left = (frmRiskControl.Parent.Width - frmRiskControl.Width) / 2;
				frmRiskControl.Top = (frmRiskControl.Parent.Height - frmRiskControl.Height) / 2;
				frmRiskControl.Show();
				frmRiskControl.BringToFront();
			}
			catch (Exception ex)
			{
				this.ShowError("OpenRiskControlForm", ex);
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000E64B0 File Offset: 0x000E48B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCleanPort_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				foreach (Control control in base.Controls)
				{
					if (control.GetType() == typeof(frmCleanPort))
					{
						return;
					}
				}
				frmCleanPort frmCleanPort = new frmCleanPort();
				frmCleanPort.TopLevel = false;
				frmCleanPort.Parent = TemplateManager.Instance.MainForm;
				frmCleanPort.Left = (frmCleanPort.Parent.Width - frmCleanPort.Width) / 2;
				frmCleanPort.Top = (frmCleanPort.Parent.Height - frmCleanPort.Height) / 2;
				frmCleanPort.Show();
				frmCleanPort.BringToFront();
			}
			catch (Exception ex)
			{
				this.ShowError("OpenCleanPortForm", ex);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000E65E0 File Offset: 0x000E49E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnShowStockAlert_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._pcPriceAlertForm == null)
				{
					this._pcPriceAlertForm = new frmPcPriceAlert();
					this._pcPriceAlertForm.TopLevel = false;
					this._pcPriceAlertForm.Parent = TemplateManager.Instance.MainForm;
					this._pcPriceAlertForm.Left = (this._pcPriceAlertForm.Parent.Width - this._pcPriceAlertForm.Width) / 2;
					this._pcPriceAlertForm.Top = (this._pcPriceAlertForm.Parent.Height - this._pcPriceAlertForm.Height) / 2;
				}
				this._pcPriceAlertForm.Show();
				this._pcPriceAlertForm.BringToFront();
				this._pcPriceAlertForm.Reload();
			}
			catch (Exception ex)
			{
				this.ShowError("btnShowStockAlert_Click", ex);
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000E66E4 File Offset: 0x000E4AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnNotification_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.alertSettingForm == null)
				{
					this.alertSettingForm = new frmMobileAlert();
					this.alertSettingForm.TopLevel = false;
					this.alertSettingForm.Parent = TemplateManager.Instance.MainForm;
					this.alertSettingForm.Left = (this.alertSettingForm.Parent.Width - this.alertSettingForm.Width) / 2;
					this.alertSettingForm.Top = (this.alertSettingForm.Parent.Height - this.alertSettingForm.Height) / 2;
				}
				this.alertSettingForm.Show();
				this.alertSettingForm.BringToFront();
				this.alertSettingForm.Reload();
			}
			catch (Exception ex)
			{
				this.ShowError("btnNotification_Click", ex);
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000E67E8 File Offset: 0x000E4BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbSeries_KeyDown(object sender, KeyEventArgs e)
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
						goto IL_11B;
					case Keys.Up:
						goto IL_11B;
					case Keys.Right:
						break;
					default:
						goto IL_11B;
					}
				}
				if (this.tbSeries.Text.Trim() != string.Empty)
				{
					this._seriesInfoTfex = ApplicationInfo.SeriesInfo[this.tbSeries.Text.Trim()];
					if (this._seriesInfoTfex.OrderBookId > 0 && this._seriesInfoTfex.Group != 5)
					{
						TemplateManager.Instance.SendSymbolLink(this, SymbolLinkSource.StockSymbol, this._seriesInfoTfex.Symbol);
						ApplicationInfo.CurrentSymbol = this._seriesInfoTfex.Symbol;
						this.tbVolumeT.Focus();
					}
					else
					{
						this.tbSeries.Focus();
					}
				}
				e.SuppressKeyPress = true;
				IL_11B:;
			}
			catch (Exception ex)
			{
				this.ShowError("tbSeries_KeyUp", ex);
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000E6948 File Offset: 0x000E4D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPriceT_KeyDown(object sender, KeyEventArgs e)
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
						this.tbVolumeT.Focus();
						this.tbVolumeT.SelectAll();
						break;
					case Keys.Right:
						if (this.IsValidPrice_TFEX(false, this.tbPriceT.Text.ToUpper().Trim()))
						{
							this.tbPublishT.Focus();
						}
						e.SuppressKeyPress = true;
						break;
					}
				}
				else
				{
					if (this.IsValidPrice_TFEX(false, this.tbPriceT.Text.ToUpper().Trim()))
					{
						this.btnSendOrderT.PerformClick();
					}
					e.SuppressKeyPress = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbPriceT_KeyDown", ex);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000E6A58 File Offset: 0x000E4E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbPublishT_KeyDown(object sender, KeyEventArgs e)
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
						e.SuppressKeyPress = true;
						this.tbPriceT.Focus();
						break;
					case Keys.Right:
						this.cbPosition.Focus();
						e.SuppressKeyPress = true;
						break;
					}
				}
				else
				{
					this.btnSendOrderT.PerformClick();
					e.SuppressKeyPress = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbPublish_KeyDown", ex);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000E6B18 File Offset: 0x000E4F18
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.cbPriceTypeT.Text == "MP" || this.cbPriceTypeT.Text == "MO" || this.cbPriceTypeT.Text == "ML")
				{
					this.tbPriceT.Text = "";
					this.tbPriceT.Enabled = false;
				}
				else
				{
					this.tbPriceT.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("cbType_SelectedIndexChanged", ex);
			}
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x000E6BF0 File Offset: 0x000E4FF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbValidity_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				switch (e.KeyCode)
				{
				case Keys.Left:
					this.cbPriceTypeT.Focus();
					e.SuppressKeyPress = true;
					break;
				case Keys.Right:
					this.cbCondition.Focus();
					e.SuppressKeyPress = true;
					break;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("cbValidity_KeyDown", ex);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000E6C8C File Offset: 0x000E508C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSendOrderT_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.DoSend_TFEX("V");
			}
			catch (Exception ex)
			{
				this.ShowError("btnSendOrderT_Click", ex);
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x000E6CE4 File Offset: 0x000E50E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnClearTextT_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.DoClear();
				this.tbSeries.Focus();
			}
			catch (Exception ex)
			{
				this.ShowError("btnClearTextT_Click", ex);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000E6D40 File Offset: 0x000E5140
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbVolumeT_KeyDown(object sender, KeyEventArgs e)
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
					case Keys.Down:
						e.SuppressKeyPress = true;
						goto IL_BE;
					case Keys.Left:
						this.tbSeries.Focus();
						goto IL_BE;
					case Keys.Up:
						goto IL_BE;
					case Keys.Right:
						break;
					default:
						goto IL_BE;
					}
				}
				long num;
				long.TryParse(this.tbVolumeT.Text.Replace(",", ""), out num);
				if (num > 0L)
				{
					this.tbPriceT.Focus();
				}
				else
				{
					this.tbVolumeT.SelectAll();
				}
				e.SuppressKeyPress = true;
				IL_BE:;
			}
			catch (Exception ex)
			{
				this.ShowError("tbVolumeT_KeyDown", ex);
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000E6E38 File Offset: 0x000E5238
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbVolumeT_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbVolumeT.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbVolumeT.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbVolumeT.Text.Replace(",", ""));
							this.tbVolumeT.Text = num.ToString("#,###");
							this.tbVolumeT.Select(this.tbVolumeT.Text.Length, 0);
							this.tbPublishT.Text = this.tbVolumeT.Text;
						}
						catch
						{
							this.tbVolumeT.Text = this.tbVolumeT.Text.Substring(0, this.tbVolumeT.Text.Length - 1);
						}
					}
					else
					{
						this.tbVolumeT.Text = this.tbVolumeT.Text.Substring(0, this.tbVolumeT.Text.Length - 1);
					}
				}
				else
				{
					this.tbPublishT.Text = this.tbVolumeT.Text;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbVolumeT_TextChanged", ex);
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000E6FEC File Offset: 0x000E53EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rdbTfexBuy_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.rdbTfexBuy.Checked)
			{
				this.SetColorBySide("L");
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000E702C File Offset: 0x000E542C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rdbTfexSell_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.rdbTfexSell.Checked)
			{
				this.SetColorBySide("S");
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000E706C File Offset: 0x000E546C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void chbTfexStopOrder_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.chbTfexStopOrder.Checked)
				{
					this.tbSeriesCondition.Visible = (this.cbTfexConStopOrder.Visible = (this.tbTfexPriceCondition.Visible = true));
					if (string.IsNullOrEmpty(this.tbSeries.Text))
					{
						this.tbSeriesCondition.Text = "SERIES";
						this.tbSeriesCondition.ForeColor = Color.Silver;
					}
					else
					{
						this.tbSeriesCondition.Text = this.tbSeries.Text;
						this.tbSeriesCondition.ForeColor = Color.Black;
					}
					this.tbTfexPriceCondition.Text = "PRICE";
					this.tbTfexPriceCondition.ForeColor = Color.Silver;
					this.cbTfexConStopOrder.SelectedIndex = 4;
				}
				else
				{
					this.tbSeriesCondition.Visible = (this.cbTfexConStopOrder.Visible = (this.tbTfexPriceCondition.Visible = false));
					this.tbSeriesCondition.Text = (this.tbTfexPriceCondition.Text = string.Empty);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("chbStopOrder_CheckedChanged", ex);
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000E71F4 File Offset: 0x000E55F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbSeriesCondition_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			switch (e.KeyCode)
			{
			case Keys.Left:
				this.cbValidityT.Focus();
				e.SuppressKeyPress = true;
				break;
			case Keys.Right:
				this.cbTfexConStopOrder.Focus();
				e.SuppressKeyPress = true;
				break;
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000E7264 File Offset: 0x000E5664
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbTfexConStopOrder_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			switch (e.KeyCode)
			{
			case Keys.Left:
				this.tbSeriesCondition.Focus();
				e.SuppressKeyPress = true;
				break;
			case Keys.Right:
				this.tbTfexPriceCondition.Focus();
				e.SuppressKeyPress = true;
				break;
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000E72D4 File Offset: 0x000E56D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbTfexPriceCondition_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			switch (e.KeyCode)
			{
			case Keys.Left:
				this.cbTfexConStopOrder.Focus();
				e.SuppressKeyPress = true;
				break;
			case Keys.Right:
				e.SuppressKeyPress = true;
				break;
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000E7338 File Offset: 0x000E5738
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbType_KeyDown(object sender, KeyEventArgs e)
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
						this.cbPosition.Focus();
						e.SuppressKeyPress = true;
						goto IL_6B;
					case Keys.Up:
						goto IL_6B;
					case Keys.Right:
						break;
					default:
						goto IL_6B;
					}
				}
				this.cbValidityT.Focus();
				e.SuppressKeyPress = true;
				IL_6B:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbValidity_KeyDown", ex);
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000E73DC File Offset: 0x000E57DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbPosition_KeyDown(object sender, KeyEventArgs e)
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
						this.tbPublishT.Focus();
						e.SuppressKeyPress = true;
						goto IL_6B;
					case Keys.Up:
						goto IL_6B;
					case Keys.Right:
						break;
					default:
						goto IL_6B;
					}
				}
				this.cbPriceTypeT.Focus();
				e.SuppressKeyPress = true;
				IL_6B:;
			}
			catch (Exception ex)
			{
				this.ShowError("cbValidity_KeyDown", ex);
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000E7480 File Offset: 0x000E5880
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnBResize_Up_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.OnResizeUpDown != null)
			{
				this.OnResizeUpDown(true);
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000E74BC File Offset: 0x000E58BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnBResize_Down_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.OnResizeUpDown != null)
			{
				this.OnResizeUpDown(false);
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000E74F8 File Offset: 0x000E58F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbTfexPriceCondition_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (Settings.Default.BSBoxDefaultPrice == 1)
			{
				if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
				{
					e.Handled = true;
				}
			}
			else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != 'M' && e.KeyChar != 'm' && e.KeyChar != 'O' && e.KeyChar != 'o' && e.KeyChar != 'P' && e.KeyChar != 'p' && e.KeyChar != 'L' && e.KeyChar != 'l')
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000E7638 File Offset: 0x000E5A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbTfexPriceCondition_MouseClick(object sender, MouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender == this.tbTfexPriceCondition)
			{
				if (string.IsNullOrEmpty(this.tbTfexPriceCondition.Text))
				{
					this.tbTfexPriceCondition.Text = "PRICE";
					this.tbTfexPriceCondition.ForeColor = Color.Silver;
				}
				else if (this.tbTfexPriceCondition.Text == "PRICE")
				{
					this.tbTfexPriceCondition.ForeColor = Color.Yellow;
					this.tbTfexPriceCondition.Text = "";
				}
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000E76F0 File Offset: 0x000E5AF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbSeriesCondition_MouseClick(object sender, MouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender == this.tbSeriesCondition)
			{
				if (string.IsNullOrEmpty(this.tbSeriesCondition.Text))
				{
					this.tbSeriesCondition.Text = "SERIES";
					this.tbSeriesCondition.ForeColor = Color.Silver;
				}
				else if (this.tbSeriesCondition.Text == "SERIES")
				{
					this.tbSeriesCondition.ForeColor = Color.Yellow;
					this.tbSeriesCondition.Text = "";
				}
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000E77A8 File Offset: 0x000E5BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void chbMMAutoStopLoss_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.chbMMAutoStopLoss.Checked)
			{
				if (!ApplicationInfo.IsAutoTradeAccepted)
				{
					this.ShowStopDisclaimer();
				}
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000E77F0 File Offset: 0x000E5BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnMMSide_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (sender == this.btnMMBuy)
			{
				this.SetColorBySide(ApplicationInfo.IsEquityAccount ? "B" : "L");
			}
			else if (sender == this.btnMMSell)
			{
				this.SetColorBySide("S");
			}
			else if (sender == this.btnMMCover)
			{
				this.SetColorBySide("C");
			}
			else
			{
				if (sender != this.btnMMShort)
				{
					return;
				}
				this.SetColorBySide("H");
			}
			this.DoClear();
			if (ApplicationInfo.IsEquityAccount)
			{
				this.SetVisibleControlEquity();
				this.ShowCreditValueEquity();
			}
			else
			{
				this.SetVisibleControlTfex();
			}
			if (this._isActive)
			{
				this.cbMMStock.Focus();
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000E7904 File Offset: 0x000E5D04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void panelAutoTradeMM_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (sender == this.cbMMStock)
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
							goto IL_4F0;
						case Keys.Up:
							goto IL_4F0;
						case Keys.Right:
							break;
						default:
							goto IL_4F0;
						}
					}
					if (this.cbMMStock.Text.Trim() != string.Empty)
					{
						if (ApplicationInfo.IsEquityAccount)
						{
							StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.cbMMStock.Text.Trim()];
							if (stockInformation.Number > 0)
							{
								this._stockInfo = stockInformation;
								this._seriesInfoTfex = null;
								TemplateManager.Instance.SendSymbolLink(this, SymbolLinkSource.StockSymbol, this._stockInfo.Symbol);
								ApplicationInfo.CurrentSymbol = this._stockInfo.Symbol;
								if (!this.cbMMStock.Items.Contains(this._stockInfo.Symbol))
								{
									this.cbMMStock.Items.Add(this._stockInfo.Symbol);
								}
								if (this.cbMMPrice.Text == string.Empty)
								{
									if (Settings.Default.BSBoxDefaultPrice == 1)
									{
										this.cbMMPrice.Text = ((this._stockInfo.LastSalePrice > 0m) ? Utilities.PriceFormat(this._stockInfo.LastSalePrice) : Utilities.PriceFormat(this._stockInfo.PriorPrice));
									}
									else if (Settings.Default.BSBoxDefaultPrice == 2)
									{
										if (this._showSide == "B")
										{
											this.cbMMPrice.Text = Utilities.PriceFormat(this._stockInfo.OfferPrice1);
										}
										else if (this._showSide == "S")
										{
											this.cbMMPrice.Text = Utilities.PriceFormat(this._stockInfo.BidPrice1);
										}
									}
								}
								this.cbMMPrice.Focus();
							}
							else
							{
								this.cbMMStock.Text = ((this._stockInfo != null) ? this._stockInfo.Symbol : string.Empty);
								this.cbMMStock.Focus();
								this.cbMMStock.SelectAll();
							}
						}
						else
						{
							SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[this.cbMMStock.Text.Trim()];
							if (seriesInformation.OrderBookId > 0)
							{
								this._stockInfo = null;
								this._seriesInfoTfex = seriesInformation;
								TemplateManager.Instance.SendSymbolLink(this, SymbolLinkSource.StockSymbol, this._seriesInfoTfex.Symbol);
								ApplicationInfo.CurrentSymbol = this._seriesInfoTfex.Symbol;
								if (!this.cbMMStock.Items.Contains(this._seriesInfoTfex.Symbol))
								{
									this.cbMMStock.Items.Add(this._seriesInfoTfex.Symbol);
								}
								if (this.cbMMPrice.Text == string.Empty)
								{
									if (Settings.Default.BSBoxDefaultPrice == 1)
									{
										this.cbMMPrice.Text = ((this._seriesInfoTfex.LastSalePrice > 0m) ? Utilities.PriceFormat(this._seriesInfoTfex.LastSalePrice) : Utilities.PriceFormat(this._stockInfo.PriorPrice));
									}
									else if (Settings.Default.BSBoxDefaultPrice == 2)
									{
										if (this._showSide == "L")
										{
											this.cbMMPrice.Text = Utilities.PriceFormat(this._seriesInfoTfex.OfferPrice1);
										}
										else if (this._showSide == "S")
										{
											this.cbMMPrice.Text = Utilities.PriceFormat(this._seriesInfoTfex.BidPrice1);
										}
									}
								}
								this.cbMMPrice.Focus();
							}
							else
							{
								this.cbMMStock.Text = ((this._seriesInfoTfex != null) ? this._seriesInfoTfex.Symbol : string.Empty);
								this.cbMMStock.Focus();
								this.cbMMStock.SelectAll();
							}
						}
					}
					e.SuppressKeyPress = true;
					IL_4F0:;
				}
				else if (sender == this.cbMMPrice)
				{
					Keys keyCode = e.KeyCode;
					if (keyCode != Keys.Return)
					{
						switch (keyCode)
						{
						case Keys.Left:
							this.cbMMStock.Focus();
							e.SuppressKeyPress = true;
							goto IL_6C4;
						case Keys.Up:
							this.cbMMPrice.Text = Utilities.PriceFormat(this.GetPrice(this.cbMMPrice, true));
							this.cbMMPrice.SelectAll();
							e.SuppressKeyPress = true;
							goto IL_6C4;
						case Keys.Right:
							break;
						case Keys.Down:
							this.cbMMPrice.Text = Utilities.PriceFormat(this.GetPrice(this.cbMMPrice, false));
							this.cbMMPrice.SelectAll();
							e.SuppressKeyPress = true;
							goto IL_6C4;
						default:
							goto IL_6C4;
						}
					}
					if (ApplicationInfo.IsEquityAccount)
					{
						if (this.IsValidPrice(this.cbMMPrice.Text, true, this.cbMMPrice))
						{
							if (this._showSide == "B" || this._showSide == "H")
							{
								this.tbMMStopPrice.Focus();
							}
							else
							{
								this.tbMMGiveUp.Focus();
							}
							this.calculateMMVolume();
						}
					}
					else if (this.IsValidPrice_TFEX(true, this.cbMMPrice.Text))
					{
						if (this.tbMMStopPrice.Visible)
						{
							this.tbMMStopPrice.Focus();
						}
						else
						{
							this.tbMMGiveUp.Focus();
						}
						this.calculateMMVolume();
					}
					e.SuppressKeyPress = true;
					IL_6C4:;
				}
				else if (sender == this.tbMMStopPrice)
				{
					Keys keyCode = e.KeyCode;
					if (keyCode != Keys.Return)
					{
						switch (keyCode)
						{
						case Keys.Left:
							this.cbMMPrice.Focus();
							e.SuppressKeyPress = true;
							goto IL_7E3;
						case Keys.Up:
							this.tbMMStopPrice.Text = Utilities.PriceFormat(this.GetPrice(this.tbMMStopPrice, true));
							this.tbMMStopPrice.SelectAll();
							e.SuppressKeyPress = true;
							goto IL_7E3;
						case Keys.Right:
							break;
						case Keys.Down:
							this.tbMMStopPrice.Text = Utilities.PriceFormat(this.GetPrice(this.tbMMStopPrice, false));
							this.tbMMStopPrice.SelectAll();
							e.SuppressKeyPress = true;
							goto IL_7E3;
						default:
							goto IL_7E3;
						}
					}
					if (this.IsValidPrice(this.tbMMStopPrice.Text, true, this.tbMMStopPrice))
					{
						this.calculateMMVolume();
						this.tbMMGiveUp.Focus();
					}
					e.SuppressKeyPress = true;
					IL_7E3:;
				}
				else if (sender == this.tbMMGiveUp)
				{
					Keys keyCode = e.KeyCode;
					if (keyCode != Keys.Return)
					{
						switch (keyCode)
						{
						case Keys.Left:
							this.tbMMStopPrice.Focus();
							e.SuppressKeyPress = true;
							break;
						case Keys.Up:
							e.SuppressKeyPress = true;
							break;
						case Keys.Right:
							e.SuppressKeyPress = true;
							break;
						case Keys.Down:
							e.SuppressKeyPress = true;
							break;
						}
					}
					else
					{
						if (FormatUtil.Isnumeric(this.tbMMGiveUp.Text))
						{
							if (this.tbMMPin.Text.Trim() == string.Empty)
							{
								this.tbMMPin.Focus();
							}
							else
							{
								this.btnMMSend.PerformClick();
							}
						}
						e.SuppressKeyPress = true;
					}
				}
				else if (sender == this.tbMMPin)
				{
					Keys keyCode = e.KeyCode;
					if (keyCode != Keys.Return)
					{
						switch (keyCode)
						{
						case Keys.Left:
							this.tbMMGiveUp.Focus();
							e.SuppressKeyPress = true;
							break;
						case Keys.Up:
							e.SuppressKeyPress = true;
							break;
						case Keys.Right:
							e.SuppressKeyPress = true;
							break;
						case Keys.Down:
							e.SuppressKeyPress = true;
							break;
						}
					}
					else
					{
						if (this.tbMMPin.Text.Trim() == string.Empty)
						{
							this.tbMMPin.Focus();
						}
						else
						{
							this.btnMMSend.PerformClick();
						}
						e.SuppressKeyPress = true;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("panelAutoTradeMM_KeyDown", ex);
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000E82FC File Offset: 0x000E66FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnMMSend_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.calculateMMVolume();
				if (ApplicationInfo.AccInfo.UserInternetInBroker == "Y")
				{
					this.ShowMessageInFormConfirm("Internal user not authenrize!", frmOrderFormConfirm.OpenStyle.ShowBox);
				}
				else
				{
					this._verifyParam = false;
					if (string.IsNullOrEmpty(ApplicationInfo.AccInfo.CurrentAccount))
					{
						this.ShowMessageInFormConfirm("Invalid Account!", frmOrderFormConfirm.OpenStyle.ShowBox);
					}
					else
					{
						if (ApplicationInfo.AccInfo.IsAccCanTrade(ApplicationInfo.AccInfo.CurrentAccount))
						{
							this._OrdSymbol = this.cbMMStock.Text.ToUpper().Trim();
							this._OrdTtf = 0;
							this._OrdSide = (ApplicationInfo.IsEquityAccount ? this._showSide : this._showSideTFEX);
							this._OrdCondition = string.Empty;
							this._OrdTimes = 0;
							this._OrdAutoStopLoss = false;
							this._OrdStopPrice = 0m;
							if (ApplicationInfo.UserLoginMode == "I")
							{
								this.ShowMessageInFormConfirm("Invalid Login Type", frmOrderFormConfirm.OpenStyle.ShowBox);
								return;
							}
							this._OrdIsDeposit = "";
							if (this._OrdSide == "B" || this._OrdSide == "H")
							{
								this._OrdAutoStopLoss = this.chbMMAutoStopLoss.Checked;
							}
							if (string.IsNullOrEmpty(this._OrdSide))
							{
								this.ShowMessageInFormConfirm("Invalid Side!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbMMStock);
								return;
							}
							if (string.IsNullOrEmpty(this._OrdSymbol))
							{
								this.ShowMessageInFormConfirm("Invalid Symbol!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbMMStock);
								return;
							}
							if (ApplicationInfo.IsEquityAccount)
							{
								if (this._stockInfo == null || this._stockInfo.Number <= 0)
								{
									this.ShowMessageInFormConfirm("Invalid Symbol!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbMMStock);
									return;
								}
							}
							else if (this._seriesInfoTfex == null || this._seriesInfoTfex.OrderBookId <= 0)
							{
								this.ShowMessageInFormConfirm("Invalid Symbol!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbMMStock);
								return;
							}
							if (!this.IsValidPrice(this.cbMMPrice.Text, true, this.cbMMPrice))
							{
								return;
							}
							if (this._OrdSide == "B" || this._OrdSide == "H")
							{
								string text = this.cbMMPrice.Text.Trim();
								if (text != null)
								{
									if (text == "ATO" || text == "ATC" || text == "MP" || text == "MO" || text == "ML")
									{
										this.ShowMessageInFormConfirm("Condition price does not supported [ATO, ATC, MP, MO and ML]!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.cbMMPrice);
										return;
									}
								}
							}
							this._OrdPrice = this.cbMMPrice.Text.ToUpper().Trim();
							if (ApplicationInfo.IsEquityAccount && (this._OrdSide == "B" || this._OrdSide == "H"))
							{
								decimal.TryParse(this.tbMMStopPrice.Text, out this._OrdStopPrice);
								if (this._OrdStopPrice <= 0m)
								{
									this.ShowMessageInFormConfirm("Invalid stop price!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbMMStopPrice);
									return;
								}
								if (!this.IsValidPrice(this.tbMMStopPrice.Text, true, this.tbMMStopPrice))
								{
									return;
								}
							}
							else if (!ApplicationInfo.IsEquityAccount && this._OrdPosition == "O")
							{
								decimal.TryParse(this.tbMMStopPrice.Text, out this._OrdStopPrice);
								if (this._OrdStopPrice <= 0m)
								{
									this.ShowMessageInFormConfirm("Invalid stop price!.", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbMMStopPrice);
									return;
								}
								if (!this.IsValidPrice(this.tbMMStopPrice.Text, true, this.tbMMStopPrice))
								{
									return;
								}
							}
							this._OrdVolume = 0L;
							long.TryParse(this.tbMMVolume.Text.Replace(",", ""), out this._OrdVolume);
							if (this._OrdVolume <= 0L)
							{
								this.ShowMessageInFormConfirm("Invalid Volume [More than Zero]!", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbMMVolume);
								return;
							}
							if (ApplicationInfo.IsEquityAccount && this._OrdAutoStopLoss)
							{
								if (this._OrdVolume > 5000000L)
								{
									this.ShowMessageInFormConfirm("ปริมาณซื้อ/ขาย เกินปริมาณที่กำหนด [สูงสุด 5,000,000 หุ้น]", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbMMVolume);
									return;
								}
							}
							if (ApplicationInfo.IsEquityAccount && this._OrdAutoStopLoss)
							{
								decimal d = this._OrdStopPrice * this._OrdVolume;
								if (d > 10000000m)
								{
									this.ShowMessageInFormConfirm("มูลค่าซื้อ/ขาย เกินมูลค่าที่กำหนด [สูงสุด 10,000,000 บาท]", frmOrderFormConfirm.OpenStyle.ShowBox, this.tbMMVolume);
									return;
								}
							}
							this._OrdPubVol = this._OrdVolume;
							this._verifyParam = true;
						}
						else
						{
							this.ShowMessageInFormConfirm(ApplicationInfo.AccInfo.CurrentAccount + " is not allowed to Buy / Sell.", frmOrderFormConfirm.OpenStyle.ShowBox);
						}
						if (this._verifyParam)
						{
							if (ApplicationInfo.IsEquityAccount)
							{
								if (!this.bgwSendOrder.IsBusy)
								{
									this._commandType = "V";
									this.btnMMSend.Enabled = false;
									this.bgwSendOrder.RunWorkerAsync();
								}
							}
							else
							{
								ApplicationInfo.UserPincodeLastEntry = this.tbMMPin.Text.Trim();
								this._verifyParam = this.DoSend_MM_TFEX("V");
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

		// Token: 0x06000C54 RID: 3156 RVA: 0x000E89E0 File Offset: 0x000E6DE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnMMClear_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.DoClear();
			this.cbMMStock.Focus();
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000E8A04 File Offset: 0x000E6E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbMMPrice_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.cbMMPrice.Text.Trim() != string.Empty)
				{
					if (this._showSide == "B")
					{
						if (!Regex.IsMatch(this.cbMMPrice.Text, "^[-+]?\\d+\\.?\\d*$"))
						{
							this.cbMMPrice.Text = this.cbMMPrice.Text.Substring(0, this.cbMMPrice.Text.Length - 1);
							this.cbMMPrice.Select(this.cbMMPrice.Text.Length, 0);
						}
						else
						{
							this.calculateMMVolume();
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("cbMMPrice_TextChanged", ex);
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000E8B10 File Offset: 0x000E6F10
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbMMGiveUp_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbMMGiveUp.Text.Trim() != string.Empty)
				{
					if (!Regex.IsMatch(this.tbMMGiveUp.Text, "^[-+]?\\d+\\.?\\d*$"))
					{
						this.tbMMGiveUp.Text = this.tbMMGiveUp.Text.Substring(0, this.tbMMGiveUp.Text.Length - 1);
						this.tbMMGiveUp.Select(this.tbMMGiveUp.Text.Length, 0);
					}
					else
					{
						this.calculateMMVolume();
					}
				}
				else
				{
					this.calculateMMVolume();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbMMGiveUp_TextChanged", ex);
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000E8C04 File Offset: 0x000E7004
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbMMStopPrice_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbMMStopPrice.Text.Trim() != string.Empty)
				{
					if (!Regex.IsMatch(this.tbMMStopPrice.Text, "^[-+]?\\d+\\.?\\d*$"))
					{
						this.tbMMStopPrice.Text = this.tbMMStopPrice.Text.Substring(0, this.tbMMStopPrice.Text.Length - 1);
						this.tbMMStopPrice.Select(this.tbMMStopPrice.Text.Length, 0);
					}
					else
					{
						this.calculateMMVolume();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbMMStopPrice_TextChanged", ex);
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000E8CEC File Offset: 0x000E70EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbMMPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000E8D28 File Offset: 0x000E7128
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rdbMMOpenPos_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetVisibleControlTfex();
			this.calculateMMVolume();
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000E8D48 File Offset: 0x000E7148
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rdbMMClosePos_CheckedChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetVisibleControlTfex();
			this.calculateMMVolume();
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000E8D68 File Offset: 0x000E7168
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
					this.tbMMPin.Text = ApplicationInfo.UserPincodeLastEntry;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("OnPincodeChanged", ex);
			}
		}

		// Token: 0x040007AB RID: 1963
		private IContainer components;

		// Token: 0x040007AC RID: 1964
		private Label lbPrice;

		// Token: 0x040007AD RID: 1965
		private Label lbVolume;

		// Token: 0x040007AE RID: 1966
		private TextBox tbVolume;

		// Token: 0x040007AF RID: 1967
		private Label lbPublic;

		// Token: 0x040007B0 RID: 1968
		private Label lbCondition;

		// Token: 0x040007B1 RID: 1969
		private TextBox tbPublic;

		// Token: 0x040007B2 RID: 1970
		private CheckBox chbNVDR;

		// Token: 0x040007B3 RID: 1971
		private Panel panelTop;

		// Token: 0x040007B4 RID: 1972
		private Label lbBuyLimit;

		// Token: 0x040007B5 RID: 1973
		private Label lbLoading;

		// Token: 0x040007B6 RID: 1974
		private Label tbBuyLimit;

		// Token: 0x040007B7 RID: 1975
		private Button btnSendOrder;

		// Token: 0x040007B8 RID: 1976
		private ComboBox cbAccount;

		// Token: 0x040007B9 RID: 1977
		private Label lbAccount;

		// Token: 0x040007BA RID: 1978
		private ComboBox cbCondition;

		// Token: 0x040007BB RID: 1979
		private Label tbOnHand;

		// Token: 0x040007BC RID: 1980
		private Label lbOnHand;

		// Token: 0x040007BD RID: 1981
		private Panel panelEquity;

		// Token: 0x040007BE RID: 1982
		private TextBox tbTimes;

		// Token: 0x040007BF RID: 1983
		private Label lbTimes;

		// Token: 0x040007C0 RID: 1984
		private Button btnStyle2;

		// Token: 0x040007C1 RID: 1985
		private Button btnStyle1;

		// Token: 0x040007C2 RID: 1986
		private Button btnSetting;

		// Token: 0x040007C3 RID: 1987
		private Button btnCleanPort;

		// Token: 0x040007C4 RID: 1988
		private ComboBox cbPrice;

		// Token: 0x040007C5 RID: 1989
		private RadioButton rbSell;

		// Token: 0x040007C6 RID: 1990
		private RadioButton rbBuy;

		// Token: 0x040007C7 RID: 1991
		private RadioButton rbCover;

		// Token: 0x040007C8 RID: 1992
		private RadioButton rbShort;

		// Token: 0x040007C9 RID: 1993
		private Button btnStyle3;

		// Token: 0x040007CA RID: 1994
		private TextBox tbPin;

		// Token: 0x040007CB RID: 1995
		private Label lbPin;

		// Token: 0x040007CC RID: 1996
		private Button btnClear;

		// Token: 0x040007CD RID: 1997
		private Button btnVolDec;

		// Token: 0x040007CE RID: 1998
		private Button btnVolInc;

		// Token: 0x040007CF RID: 1999
		private Button btnPBDec;

		// Token: 0x040007D0 RID: 2000
		private Button btnPBInc;

		// Token: 0x040007D1 RID: 2001
		private Button btnPriceDec;

		// Token: 0x040007D2 RID: 2002
		private Button btnPriceInc;

		// Token: 0x040007D3 RID: 2003
		private ToolTip toolTip1;

		// Token: 0x040007D4 RID: 2004
		private ComboBox cbSide;

		// Token: 0x040007D5 RID: 2005
		private Label lbSide;

		// Token: 0x040007D6 RID: 2006
		private Label lbStock;

		// Token: 0x040007D7 RID: 2007
		private ComboBox cbStock;

		// Token: 0x040007D8 RID: 2008
		private Button btnStyle4;

		// Token: 0x040007D9 RID: 2009
		private Button btnRisk;

		// Token: 0x040007DA RID: 2010
		private Button btnShowStockAlert;

		// Token: 0x040007DB RID: 2011
		private ComboBox cbDepCollateral;

		// Token: 0x040007DC RID: 2012
		private Label lbDep;

		// Token: 0x040007DD RID: 2013
		private Button btnNotification;

		// Token: 0x040007DE RID: 2014
		private Panel panelDerivative;

		// Token: 0x040007DF RID: 2015
		private TextBox tbTfexPriceCondition;

		// Token: 0x040007E0 RID: 2016
		private ComboBox cbTfexConStopOrder;

		// Token: 0x040007E1 RID: 2017
		private TextBox tbPriceT;

		// Token: 0x040007E2 RID: 2018
		private TextBox tbSeriesCondition;

		// Token: 0x040007E3 RID: 2019
		private TextBox tbSeries;

		// Token: 0x040007E4 RID: 2020
		private CheckBox chbTfexStopOrder;

		// Token: 0x040007E5 RID: 2021
		private TextBox tbPublishT;

		// Token: 0x040007E6 RID: 2022
		private Label lbValidityT;

		// Token: 0x040007E7 RID: 2023
		private TextBox tbVolumeT;

		// Token: 0x040007E8 RID: 2024
		private Label lbPriceTypeT;

		// Token: 0x040007E9 RID: 2025
		private Button btnClearTextT;

		// Token: 0x040007EA RID: 2026
		private Label lbPosition;

		// Token: 0x040007EB RID: 2027
		private Button btnSendOrderT;

		// Token: 0x040007EC RID: 2028
		private Label lbPublishT;

		// Token: 0x040007ED RID: 2029
		private ComboBox cbValidityT;

		// Token: 0x040007EE RID: 2030
		private Label lbPriceT;

		// Token: 0x040007EF RID: 2031
		private ComboBox cbPriceTypeT;

		// Token: 0x040007F0 RID: 2032
		private Label lbVolumeT;

		// Token: 0x040007F1 RID: 2033
		private Label lbSeries;

		// Token: 0x040007F2 RID: 2034
		private Label tbEquity;

		// Token: 0x040007F3 RID: 2035
		private Label lbEquity;

		// Token: 0x040007F4 RID: 2036
		private RadioButton rdbTfexSell;

		// Token: 0x040007F5 RID: 2037
		private RadioButton rdbTfexBuy;

		// Token: 0x040007F6 RID: 2038
		private ComboBox cbPosition;

		// Token: 0x040007F7 RID: 2039
		private Panel panelAutoTradeMM;

		// Token: 0x040007F8 RID: 2040
		private Label lbMMStopPrice;

		// Token: 0x040007F9 RID: 2041
		private CheckBox chbMMAutoStopLoss;

		// Token: 0x040007FA RID: 2042
		private ComboBox cbMMStock;

		// Token: 0x040007FB RID: 2043
		private Label lbMMStock;

		// Token: 0x040007FC RID: 2044
		private Button btnMMClear;

		// Token: 0x040007FD RID: 2045
		private Label lbMMPin;

		// Token: 0x040007FE RID: 2046
		private TextBox tbMMPin;

		// Token: 0x040007FF RID: 2047
		private Label lbMMVolume;

		// Token: 0x04000800 RID: 2048
		private Button btnMMSend;

		// Token: 0x04000801 RID: 2049
		private TextBox tbMMVolume;

		// Token: 0x04000802 RID: 2050
		private Label lbMMTotalLoss;

		// Token: 0x04000803 RID: 2051
		private TextBox tbMMTotalLoss;

		// Token: 0x04000804 RID: 2052
		private Button btnMMSell;

		// Token: 0x04000805 RID: 2053
		private Button btnMMBuy;

		// Token: 0x04000806 RID: 2054
		private Label lbMMGiveUp;

		// Token: 0x04000807 RID: 2055
		private TextBox tbMMGiveUp;

		// Token: 0x04000808 RID: 2056
		private TextBox cbMMPrice;

		// Token: 0x04000809 RID: 2057
		private Label lbMMPrice;

		// Token: 0x0400080A RID: 2058
		private TextBox tbMMStopPrice;

		// Token: 0x0400080B RID: 2059
		private Button btnStyleMM;

		// Token: 0x0400080C RID: 2060
		private Button btnMMShort;

		// Token: 0x0400080D RID: 2061
		private Button btnMMCover;

		// Token: 0x0400080E RID: 2062
		private Panel panelTfexPosition;

		// Token: 0x0400080F RID: 2063
		private RadioButton rdbTfexClosePos;

		// Token: 0x04000810 RID: 2064
		private RadioButton rdbTfexOpenPos;

		// Token: 0x04000811 RID: 2065
		private Panel panelMMPosition;

		// Token: 0x04000812 RID: 2066
		private RadioButton rdbMMClosePos;

		// Token: 0x04000813 RID: 2067
		private RadioButton rdbMMOpenPos;

		// Token: 0x04000818 RID: 2072
		private BackgroundWorker bgwReloadCredit;

		// Token: 0x04000819 RID: 2073
		private BackgroundWorker bgwSendOrder;

		// Token: 0x0400081A RID: 2074
		private BackgroundWorker bgwGetEquity;

		// Token: 0x0400081B RID: 2075
		private DataSet _tdsCredit;

		// Token: 0x0400081C RID: 2076
		private StockList.StockInformation _stockInfo;

		// Token: 0x0400081D RID: 2077
		private SeriesList.SeriesInformation _seriesInfoTfex;

		// Token: 0x0400081E RID: 2078
		private long _returnOrderNumberFromServer;

		// Token: 0x0400081F RID: 2079
		private System.Windows.Forms.Timer timerReloadCredit;

		// Token: 0x04000820 RID: 2080
		private System.Windows.Forms.Timer timerSwitchAccount;

		// Token: 0x04000821 RID: 2081
		private System.Windows.Forms.Timer tmCloseSplash;

		// Token: 0x04000822 RID: 2082
		private decimal _buyCreditLimit;

		// Token: 0x04000823 RID: 2083
		private decimal _totalCreditLimit;

		// Token: 0x04000824 RID: 2084
		private int _creditType;

		// Token: 0x04000825 RID: 2085
		private bool _isActive;

		// Token: 0x04000826 RID: 2086
		private string _showSide;

		// Token: 0x04000827 RID: 2087
		private string _showSideTFEX;

		// Token: 0x04000828 RID: 2088
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x04000829 RID: 2089
		private frmStopDisclaimer _frmStopDisclaimer;

		// Token: 0x0400082A RID: 2090
		private frmPcPriceAlert _pcPriceAlertForm;

		// Token: 0x0400082B RID: 2091
		private frmMobileAlert alertSettingForm;

		// Token: 0x0400082C RID: 2092
		private Control _objLastActive;

		// Token: 0x0400082D RID: 2093
		private int _OrdTimes;

		// Token: 0x0400082E RID: 2094
		private int _currTimes;

		// Token: 0x0400082F RID: 2095
		private string _retOrderMessage;

		// Token: 0x04000830 RID: 2096
		private string _commandType;

		// Token: 0x04000831 RID: 2097
		private string _OrdSymbol;

		// Token: 0x04000832 RID: 2098
		private string _OrdSide;

		// Token: 0x04000833 RID: 2099
		private long _OrdVolume;

		// Token: 0x04000834 RID: 2100
		private string _OrdPrice;

		// Token: 0x04000835 RID: 2101
		private long _OrdPubVol;

		// Token: 0x04000836 RID: 2102
		private string _OrdCondition;

		// Token: 0x04000837 RID: 2103
		private int _OrdTtf;

		// Token: 0x04000838 RID: 2104
		private string _OrdIsDeposit;

		// Token: 0x04000839 RID: 2105
		private bool _OrdAutoStopLoss;

		// Token: 0x0400083A RID: 2106
		private decimal _OrdStopPrice;

		// Token: 0x0400083B RID: 2107
		private string _OrdPriceType;

		// Token: 0x0400083C RID: 2108
		private string _OrdPosition;

		// Token: 0x0400083D RID: 2109
		private string _OrdValidityDate;

		// Token: 0x0400083E RID: 2110
		private string _OrdTfexStopPrice;

		// Token: 0x0400083F RID: 2111
		private string _OrdTfexStopSeries;

		// Token: 0x04000840 RID: 2112
		private string _OrdTfexStopCond;

		// Token: 0x04000841 RID: 2113
		private bool _verifyResult_Pin;

		// Token: 0x04000842 RID: 2114
		private string _verifyResultStr_Pin;

		// Token: 0x04000843 RID: 2115
		private bool _verifyResult;

		// Token: 0x04000844 RID: 2116
		private bool _verifyParam;

		// Token: 0x04000845 RID: 2117
		private DataSet _dsSendOrder;

		// Token: 0x04000846 RID: 2118
		private DataSet _dsSendOrderTfex;

		// Token: 0x04000847 RID: 2119
		private ApplicationInfo.SendNewOrderResult _newOrderResult;

		// Token: 0x04000848 RID: 2120
		private decimal _portStockEquity;

		// Token: 0x04000849 RID: 2121
		private decimal _portTfexEquity;

		// Token: 0x0400084A RID: 2122
		private long _onhand;

		// Token: 0x0400084B RID: 2123
		private int _lastEquityStyle;

		// Token: 0x0400084C RID: 2124
		private int _lastTfexStyle;

		// Token: 0x0400084D RID: 2125
		private bool _isLockPubVol;

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x06000C5D RID: 3165
		public delegate void OnAccountChangedHandler(string account);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x06000C61 RID: 3169
		public delegate void OnBoxStyleChangedHandler();

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x06000C65 RID: 3173
		public delegate void OnResizedHandler();

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x06000C69 RID: 3177
		public delegate void OnResizeUpDownHandler(bool isUp);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x06000C6D RID: 3181
		private delegate void ShowMessageInFormConfirmCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x06000C71 RID: 3185
		private delegate void ShowOrderFormConfirmCallBack(string message, string orderParam, string ossWarning, string stockTH);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x06000C75 RID: 3189
		private delegate void ShowStopDisclaimerCallBack();

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x06000C79 RID: 3193
		private delegate bool SetColorBySideCallBack(string side);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x06000C7D RID: 3197
		private delegate void SetSmartOneClickCallBack(string side, string stock, string price, bool isDeposit);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x06000C81 RID: 3201
		private delegate void SetCurrentSymbolCallBack(string symbol);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x06000C85 RID: 3205
		private delegate void ShowSplashCallBack(bool visible, string message, bool isAutoClose);
	}
}
