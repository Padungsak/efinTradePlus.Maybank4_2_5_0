using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using ITSNet.Common.BIZ;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x02000005 RID: 5
	public class frmRiskControl : Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002810 File Offset: 0x00000C10
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

		// Token: 0x0600000C RID: 12 RVA: 0x00002860 File Offset: 0x00000C60
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
			this.lbQuantity = new Label();
			this.lbStock = new Label();
			this.tbPrice = new TextBox();
			this.tbStock = new TextBox();
			this.tbVolume = new TextBox();
			this.lbPrice = new Label();
			this.btnRemoveRow = new Button();
			this.btnAdd = new Button();
			this.label1 = new Label();
			this.lbLoading = new Label();
			this.panel2 = new Panel();
			this.label3 = new Label();
			this.label2 = new Label();
			this.cbSide = new ComboBox();
			this.lbMessage = new Label();
			this.gbPolicy = new GroupBox();
			this.btnRiskMax = new Button();
			this.btnRiskMedium = new Button();
			this.btnRiskMin = new Button();
			this.tbSectorLimitValue = new TextBox();
			this.chbSectorLimit = new CheckBox();
			this.tbAvg5Volume = new TextBox();
			this.chbAvg5Volume = new CheckBox();
			this.tbStocksInSector = new TextBox();
			this.lbRiskLevel = new Label();
			this.tbChgLimitValue = new TextBox();
			this.chbChgLimit = new CheckBox();
			this.tbValueLimitValue = new TextBox();
			this.chbValueLimit = new CheckBox();
			this.chbStocksInSector = new CheckBox();
			this.gbStockThreshold = new GroupBox();
			this.intza = new SortGrid();
			this.btnUpdate = new Button();
			this.btnCancel = new Button();
			this.chbOpen = new CheckBox();
			this.panel2.SuspendLayout();
			this.gbPolicy.SuspendLayout();
			this.gbStockThreshold.SuspendLayout();
			base.SuspendLayout();
			this.lbQuantity.AutoSize = true;
			this.lbQuantity.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbQuantity.Location = new Point(171, 68);
			this.lbQuantity.Name = "lbQuantity";
			this.lbQuantity.Size = new Size(51, 16);
			this.lbQuantity.TabIndex = 34;
			this.lbQuantity.Text = "Volume";
			this.lbStock.AutoSize = true;
			this.lbStock.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbStock.Location = new Point(19, 11);
			this.lbStock.Name = "lbStock";
			this.lbStock.Size = new Size(39, 16);
			this.lbStock.TabIndex = 31;
			this.lbStock.Text = "Stock";
			this.tbPrice.BackColor = Color.White;
			this.tbPrice.BorderStyle = BorderStyle.FixedSingle;
			this.tbPrice.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tbPrice.Location = new Point(71, 119);
			this.tbPrice.Margin = new Padding(3, 4, 3, 4);
			this.tbPrice.MaxLength = 9;
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new Size(81, 23);
			this.tbPrice.TabIndex = 2;
			this.tbPrice.KeyDown += new KeyEventHandler(this.tsPrice_KeyDown);
			this.tbPrice.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbPrice.KeyPress += new KeyPressEventHandler(this.tsPrice_KeyPress);
			this.tbPrice.Enter += new EventHandler(this.controlOrder_Enter);
			this.tbStock.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbStock.BackColor = Color.White;
			this.tbStock.BorderStyle = BorderStyle.FixedSingle;
			this.tbStock.CharacterCasing = CharacterCasing.Upper;
			this.tbStock.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tbStock.Location = new Point(71, 8);
			this.tbStock.Margin = new Padding(3, 4, 3, 4);
			this.tbStock.MaxLength = 8;
			this.tbStock.Name = "tbStock";
			this.tbStock.Size = new Size(95, 23);
			this.tbStock.TabIndex = 0;
			this.tbStock.KeyDown += new KeyEventHandler(this.tsStock_KeyDown);
			this.tbStock.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbStock.Enter += new EventHandler(this.controlOrder_Enter);
			this.tbVolume.BackColor = Color.White;
			this.tbVolume.BorderStyle = BorderStyle.FixedSingle;
			this.tbVolume.CharacterCasing = CharacterCasing.Upper;
			this.tbVolume.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tbVolume.Location = new Point(237, 65);
			this.tbVolume.Margin = new Padding(3, 4, 3, 4);
			this.tbVolume.MaxLength = 9;
			this.tbVolume.Name = "tbVolume";
			this.tbVolume.Size = new Size(95, 23);
			this.tbVolume.TabIndex = 1;
			this.tbVolume.TextChanged += new EventHandler(this.tsQuantity_TextChanged);
			this.tbVolume.KeyDown += new KeyEventHandler(this.tsQuantity_KeyDown);
			this.tbVolume.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbVolume.KeyPress += new KeyPressEventHandler(this.tsQuantity_KeyPress);
			this.tbVolume.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbPrice.AutoSize = true;
			this.lbPrice.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbPrice.Location = new Point(24, 122);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new Size(36, 16);
			this.lbPrice.TabIndex = 37;
			this.lbPrice.Text = "Price";
			this.btnRemoveRow.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnRemoveRow.AutoSize = true;
			this.btnRemoveRow.FlatAppearance.BorderColor = Color.Gray;
			this.btnRemoveRow.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnRemoveRow.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnRemoveRow.FlatStyle = FlatStyle.Flat;
			this.btnRemoveRow.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnRemoveRow.Location = new Point(301, 6);
			this.btnRemoveRow.Margin = new Padding(3, 4, 3, 4);
			this.btnRemoveRow.Name = "btnRemoveRow";
			this.btnRemoveRow.Size = new Size(76, 30);
			this.btnRemoveRow.TabIndex = 4;
			this.btnRemoveRow.Text = "Remove";
			this.btnRemoveRow.UseVisualStyleBackColor = true;
			this.btnRemoveRow.Click += new EventHandler(this.btnRemoveRow_Click);
			this.btnAdd.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnAdd.AutoSize = true;
			this.btnAdd.FlatAppearance.BorderColor = Color.Gray;
			this.btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnAdd.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnAdd.FlatStyle = FlatStyle.Flat;
			this.btnAdd.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnAdd.Location = new Point(221, 6);
			this.btnAdd.Margin = new Padding(3, 4, 3, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new Size(75, 30);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Save";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.label1.Location = new Point(28, 69);
			this.label1.Name = "label1";
			this.label1.Size = new Size(33, 16);
			this.label1.TabIndex = 39;
			this.label1.Text = "Side";
			this.lbLoading.AutoSize = true;
			this.lbLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbLoading.ForeColor = Color.Yellow;
			this.lbLoading.Location = new Point(148, 209);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Padding = new Padding(5, 4, 5, 4);
			this.lbLoading.Size = new Size(73, 25);
			this.lbLoading.TabIndex = 84;
			this.lbLoading.Text = "Loading...";
			this.lbLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbLoading.Visible = false;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.cbSide);
			this.panel2.Controls.Add(this.lbMessage);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lbPrice);
			this.panel2.Controls.Add(this.btnRemoveRow);
			this.panel2.Controls.Add(this.tbVolume);
			this.panel2.Controls.Add(this.tbStock);
			this.panel2.Controls.Add(this.lbQuantity);
			this.panel2.Controls.Add(this.tbPrice);
			this.panel2.Controls.Add(this.lbStock);
			this.panel2.Dock = DockStyle.Bottom;
			this.panel2.Location = new Point(3, 159);
			this.panel2.Margin = new Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(394, 150);
			this.panel2.TabIndex = 88;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(3, 96);
			this.label3.Name = "label3";
			this.label3.Size = new Size(300, 16);
			this.label3.TabIndex = 42;
			this.label3.Text = "* เตือนเมื่อซื้อ 'เกิน' ราคา , ขาย 'ต่ำ' กว่าราคาที่กำหนด";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(3, 40);
			this.label2.Name = "label2";
			this.label2.Size = new Size(242, 16);
			this.label2.TabIndex = 41;
			this.label2.Text = "* เตือนเมื่อซื้อ/ขาย เกินกว่าปริมาณที่กำหนด";
			this.cbSide.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbSide.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.cbSide.FormattingEnabled = true;
			this.cbSide.Items.AddRange(new object[]
			{
				"",
				"BUY",
				"SELL"
			});
			this.cbSide.Location = new Point(71, 65);
			this.cbSide.Margin = new Padding(3, 4, 3, 4);
			this.cbSide.Name = "cbSide";
			this.cbSide.Size = new Size(95, 24);
			this.cbSide.TabIndex = 40;
			this.cbSide.SelectedIndexChanged += new EventHandler(this.cbSide_SelectedIndexChanged);
			this.cbSide.Leave += new EventHandler(this.controlOrder_Leave);
			this.cbSide.Enter += new EventHandler(this.controlOrder_Enter);
			this.cbSide.KeyDown += new KeyEventHandler(this.cbSide_KeyDown);
			this.lbMessage.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbMessage.ForeColor = Color.Red;
			this.lbMessage.Location = new Point(158, 121);
			this.lbMessage.Name = "lbMessage";
			this.lbMessage.Padding = new Padding(2, 1, 0, 1);
			this.lbMessage.Size = new Size(183, 22);
			this.lbMessage.TabIndex = 38;
			this.lbMessage.Text = "Warning or Error Message.";
			this.lbMessage.TextAlign = ContentAlignment.MiddleRight;
			this.gbPolicy.BackColor = Color.BlanchedAlmond;
			this.gbPolicy.Controls.Add(this.btnRiskMax);
			this.gbPolicy.Controls.Add(this.btnRiskMedium);
			this.gbPolicy.Controls.Add(this.btnRiskMin);
			this.gbPolicy.Controls.Add(this.tbSectorLimitValue);
			this.gbPolicy.Controls.Add(this.chbSectorLimit);
			this.gbPolicy.Controls.Add(this.tbAvg5Volume);
			this.gbPolicy.Controls.Add(this.chbAvg5Volume);
			this.gbPolicy.Controls.Add(this.tbStocksInSector);
			this.gbPolicy.Controls.Add(this.lbRiskLevel);
			this.gbPolicy.Controls.Add(this.tbChgLimitValue);
			this.gbPolicy.Controls.Add(this.chbChgLimit);
			this.gbPolicy.Controls.Add(this.tbValueLimitValue);
			this.gbPolicy.Controls.Add(this.chbValueLimit);
			this.gbPolicy.Controls.Add(this.chbStocksInSector);
			this.gbPolicy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.gbPolicy.Location = new Point(3, 36);
			this.gbPolicy.Margin = new Padding(3, 4, 3, 4);
			this.gbPolicy.Name = "gbPolicy";
			this.gbPolicy.Padding = new Padding(3, 4, 3, 4);
			this.gbPolicy.Size = new Size(445, 313);
			this.gbPolicy.TabIndex = 89;
			this.gbPolicy.TabStop = false;
			this.gbPolicy.Text = "นโยบายควบคุมทั่วไป (General control policy.)";
			this.btnRiskMax.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnRiskMax.AutoSize = true;
			this.btnRiskMax.FlatAppearance.BorderColor = Color.Gray;
			this.btnRiskMax.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnRiskMax.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
			this.btnRiskMax.FlatStyle = FlatStyle.Flat;
			this.btnRiskMax.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnRiskMax.Location = new Point(354, 271);
			this.btnRiskMax.Name = "btnRiskMax";
			this.btnRiskMax.Size = new Size(59, 30);
			this.btnRiskMax.TabIndex = 94;
			this.btnRiskMax.Text = "สูง";
			this.btnRiskMax.UseVisualStyleBackColor = true;
			this.btnRiskMax.Click += new EventHandler(this.btnRiskMax_Click);
			this.btnRiskMedium.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnRiskMedium.AutoSize = true;
			this.btnRiskMedium.FlatAppearance.BorderColor = Color.Gray;
			this.btnRiskMedium.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnRiskMedium.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
			this.btnRiskMedium.FlatStyle = FlatStyle.Flat;
			this.btnRiskMedium.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnRiskMedium.Location = new Point(281, 271);
			this.btnRiskMedium.Name = "btnRiskMedium";
			this.btnRiskMedium.Size = new Size(71, 30);
			this.btnRiskMedium.TabIndex = 93;
			this.btnRiskMedium.Text = "ปานกลาง";
			this.btnRiskMedium.UseVisualStyleBackColor = true;
			this.btnRiskMedium.Click += new EventHandler(this.btnRiskMedium_Click);
			this.btnRiskMin.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnRiskMin.AutoSize = true;
			this.btnRiskMin.FlatAppearance.BorderColor = Color.Gray;
			this.btnRiskMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnRiskMin.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
			this.btnRiskMin.FlatStyle = FlatStyle.Flat;
			this.btnRiskMin.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnRiskMin.Location = new Point(220, 271);
			this.btnRiskMin.Name = "btnRiskMin";
			this.btnRiskMin.Size = new Size(59, 30);
			this.btnRiskMin.TabIndex = 92;
			this.btnRiskMin.Text = "ต่ำ";
			this.btnRiskMin.UseVisualStyleBackColor = true;
			this.btnRiskMin.Click += new EventHandler(this.btnRiskMin_Click);
			this.tbSectorLimitValue.BackColor = Color.White;
			this.tbSectorLimitValue.BorderStyle = BorderStyle.FixedSingle;
			this.tbSectorLimitValue.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tbSectorLimitValue.Location = new Point(181, 181);
			this.tbSectorLimitValue.Margin = new Padding(3, 4, 3, 4);
			this.tbSectorLimitValue.MaxLength = 2;
			this.tbSectorLimitValue.Name = "tbSectorLimitValue";
			this.tbSectorLimitValue.Size = new Size(33, 21);
			this.tbSectorLimitValue.TabIndex = 3;
			this.tbSectorLimitValue.TextAlign = HorizontalAlignment.Center;
			this.tbSectorLimitValue.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbSectorLimitValue.Enter += new EventHandler(this.controlOrder_Enter);
			this.chbSectorLimit.AutoSize = true;
			this.chbSectorLimit.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chbSectorLimit.Location = new Point(3, 183);
			this.chbSectorLimit.Margin = new Padding(3, 4, 3, 4);
			this.chbSectorLimit.Name = "chbSectorLimit";
			this.chbSectorLimit.Size = new Size(261, 20);
			this.chbSectorLimit.TabIndex = 14;
			this.chbSectorLimit.Text = "กำหนดต้องซื้อหุ้นให้มากกว่า            Sector";
			this.chbSectorLimit.UseVisualStyleBackColor = true;
			this.tbAvg5Volume.BackColor = Color.White;
			this.tbAvg5Volume.BorderStyle = BorderStyle.FixedSingle;
			this.tbAvg5Volume.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tbAvg5Volume.Location = new Point(181, 123);
			this.tbAvg5Volume.Margin = new Padding(3, 4, 3, 4);
			this.tbAvg5Volume.MaxLength = 2;
			this.tbAvg5Volume.Name = "tbAvg5Volume";
			this.tbAvg5Volume.Size = new Size(33, 21);
			this.tbAvg5Volume.TabIndex = 13;
			this.tbAvg5Volume.TextAlign = HorizontalAlignment.Center;
			this.tbAvg5Volume.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbAvg5Volume.Enter += new EventHandler(this.controlOrder_Enter);
			this.chbAvg5Volume.AutoSize = true;
			this.chbAvg5Volume.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chbAvg5Volume.Location = new Point(3, 128);
			this.chbAvg5Volume.Margin = new Padding(3, 4, 3, 4);
			this.chbAvg5Volume.Name = "chbAvg5Volume";
			this.chbAvg5Volume.Size = new Size(253, 36);
			this.chbAvg5Volume.TabIndex = 12;
			this.chbAvg5Volume.Text = "จำนวนหุ้นที่ลงทุนไม่ควรเกิน               % \r\nเทียบกับปริมาณซื้อขายเฉลี่ย 5 วันก่อนหน้า";
			this.chbAvg5Volume.UseVisualStyleBackColor = true;
			this.tbStocksInSector.BackColor = Color.White;
			this.tbStocksInSector.BorderStyle = BorderStyle.FixedSingle;
			this.tbStocksInSector.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tbStocksInSector.Location = new Point(268, 219);
			this.tbStocksInSector.Margin = new Padding(3, 4, 3, 4);
			this.tbStocksInSector.MaxLength = 2;
			this.tbStocksInSector.Name = "tbStocksInSector";
			this.tbStocksInSector.Size = new Size(33, 21);
			this.tbStocksInSector.TabIndex = 11;
			this.tbStocksInSector.TextAlign = HorizontalAlignment.Center;
			this.tbStocksInSector.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbStocksInSector.Enter += new EventHandler(this.controlOrder_Enter);
			this.lbRiskLevel.AutoSize = true;
			this.lbRiskLevel.Font = new Font("Tahoma", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 222);
			this.lbRiskLevel.ForeColor = Color.FromArgb(192, 0, 0);
			this.lbRiskLevel.Location = new Point(10, 273);
			this.lbRiskLevel.Name = "lbRiskLevel";
			this.lbRiskLevel.Size = new Size(160, 16);
			this.lbRiskLevel.TabIndex = 6;
			this.lbRiskLevel.Text = "ค่าแนะนำ *ระดับความเสี่ยง*";
			this.tbChgLimitValue.BackColor = Color.White;
			this.tbChgLimitValue.BorderStyle = BorderStyle.FixedSingle;
			this.tbChgLimitValue.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tbChgLimitValue.Location = new Point(289, 86);
			this.tbChgLimitValue.Margin = new Padding(3, 4, 3, 4);
			this.tbChgLimitValue.MaxLength = 2;
			this.tbChgLimitValue.Name = "tbChgLimitValue";
			this.tbChgLimitValue.Size = new Size(32, 21);
			this.tbChgLimitValue.TabIndex = 5;
			this.tbChgLimitValue.TextAlign = HorizontalAlignment.Center;
			this.tbChgLimitValue.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbChgLimitValue.Enter += new EventHandler(this.controlOrder_Enter);
			this.chbChgLimit.AutoSize = true;
			this.chbChgLimit.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chbChgLimit.Location = new Point(3, 88);
			this.chbChgLimit.Margin = new Padding(3, 4, 3, 4);
			this.chbChgLimit.Name = "chbChgLimit";
			this.chbChgLimit.Size = new Size(346, 20);
			this.chbChgLimit.TabIndex = 4;
			this.chbChgLimit.Text = "กำหนดห้ามซื้อหุ้นที่ราคาบวก(Change Price) เกิน            %";
			this.chbChgLimit.UseVisualStyleBackColor = true;
			this.tbValueLimitValue.BackColor = Color.White;
			this.tbValueLimitValue.BorderStyle = BorderStyle.FixedSingle;
			this.tbValueLimitValue.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.tbValueLimitValue.Location = new Point(243, 38);
			this.tbValueLimitValue.Margin = new Padding(3, 4, 3, 4);
			this.tbValueLimitValue.MaxLength = 2;
			this.tbValueLimitValue.Name = "tbValueLimitValue";
			this.tbValueLimitValue.Size = new Size(33, 21);
			this.tbValueLimitValue.TabIndex = 1;
			this.tbValueLimitValue.TextAlign = HorizontalAlignment.Center;
			this.tbValueLimitValue.Leave += new EventHandler(this.controlOrder_Leave);
			this.tbValueLimitValue.Enter += new EventHandler(this.controlOrder_Enter);
			this.chbValueLimit.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chbValueLimit.Location = new Point(3, 40);
			this.chbValueLimit.Margin = new Padding(3, 4, 3, 4);
			this.chbValueLimit.Name = "chbValueLimit";
			this.chbValueLimit.Size = new Size(409, 30);
			this.chbValueLimit.TabIndex = 0;
			this.chbValueLimit.Text = "กำหนดเงินลงทุนไม่ให้ซื้อหุ้นแต่ละตัวเกิน              % \r\nของวงเงินเริ่มต้น";
			this.chbValueLimit.UseVisualStyleBackColor = true;
			this.chbStocksInSector.AutoSize = true;
			this.chbStocksInSector.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chbStocksInSector.Location = new Point(3, 222);
			this.chbStocksInSector.Margin = new Padding(3, 4, 3, 4);
			this.chbStocksInSector.Name = "chbStocksInSector";
			this.chbStocksInSector.Size = new Size(329, 20);
			this.chbStocksInSector.TabIndex = 15;
			this.chbStocksInSector.Text = "กำหนดต้องซื้อหุ้นใน Sector เดียวกันมากกว่า             ตัว";
			this.chbStocksInSector.UseVisualStyleBackColor = true;
			this.gbStockThreshold.BackColor = Color.PowderBlue;
			this.gbStockThreshold.Controls.Add(this.intza);
			this.gbStockThreshold.Controls.Add(this.panel2);
			this.gbStockThreshold.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.gbStockThreshold.Location = new Point(451, 36);
			this.gbStockThreshold.Margin = new Padding(3, 4, 3, 4);
			this.gbStockThreshold.Name = "gbStockThreshold";
			this.gbStockThreshold.Padding = new Padding(3, 4, 3, 4);
			this.gbStockThreshold.Size = new Size(400, 313);
			this.gbStockThreshold.TabIndex = 90;
			this.gbStockThreshold.TabStop = false;
			this.gbStockThreshold.Text = "นโยบายควบคุมรายหุ้น (Stock control policy.)";
			this.intza.AllowDrop = true;
			this.intza.BackColor = Color.FromArgb(20, 20, 20);
			this.intza.CanBlink = true;
			this.intza.CanDrag = false;
			this.intza.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "#";
			columnItem.ValueFormat = FormatType.RecordNumber;
			columnItem.Visible = true;
			columnItem.Width = 10;
			columnItem2.Alignment = StringAlignment.Center;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "side";
			columnItem2.Text = "Side";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 14;
			columnItem3.Alignment = StringAlignment.Near;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "stock";
			columnItem3.Text = "Stock";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 22;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "volume";
			columnItem4.Text = "Volume";
			columnItem4.ValueFormat = FormatType.Volume;
			columnItem4.Visible = true;
			columnItem4.Width = 30;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "price";
			columnItem5.Text = "Price";
			columnItem5.ValueFormat = FormatType.Price;
			columnItem5.Visible = true;
			columnItem5.Width = 24;
			this.intza.Columns.Add(columnItem);
			this.intza.Columns.Add(columnItem2);
			this.intza.Columns.Add(columnItem3);
			this.intza.Columns.Add(columnItem4);
			this.intza.Columns.Add(columnItem5);
			this.intza.CurrentScroll = 0;
			this.intza.Cursor = Cursors.Hand;
			this.intza.Dock = DockStyle.Fill;
			this.intza.FocusItemIndex = -1;
			this.intza.ForeColor = Color.Black;
			this.intza.GridColor = Color.FromArgb(45, 45, 45);
			this.intza.HeaderPctHeight = 80f;
			this.intza.IsAutoRepaint = true;
			this.intza.IsDrawFullRow = false;
			this.intza.IsDrawGrid = true;
			this.intza.IsDrawHeader = true;
			this.intza.IsScrollable = true;
			this.intza.Location = new Point(3, 20);
			this.intza.MainColumn = "";
			this.intza.Margin = new Padding(3, 4, 3, 4);
			this.intza.Name = "intza";
			this.intza.Rows = 0;
			this.intza.RowSelectColor = Color.FromArgb(0, 0, 128);
			this.intza.RowSelectType = 3;
			this.intza.RowsVisible = 0;
			this.intza.Size = new Size(394, 139);
			this.intza.SortColumnName = "";
			this.intza.SortType = SortType.Desc;
			this.intza.TabIndex = 87;
			this.intza.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaTableGrid1_TableMouseClick);
			this.btnUpdate.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnUpdate.AutoSize = true;
			this.btnUpdate.FlatAppearance.BorderColor = Color.Gray;
			this.btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnUpdate.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnUpdate.FlatStyle = FlatStyle.Flat;
			this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnUpdate.Location = new Point(691, 356);
			this.btnUpdate.Margin = new Padding(3, 4, 3, 4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new Size(75, 30);
			this.btnUpdate.TabIndex = 91;
			this.btnUpdate.Text = "Confirm";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
			this.btnCancel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnCancel.AutoSize = true;
			this.btnCancel.FlatAppearance.BorderColor = Color.Gray;
			this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnCancel.FlatAppearance.MouseOverBackColor = Color.Teal;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnCancel.Location = new Point(772, 355);
			this.btnCancel.Margin = new Padding(3, 4, 3, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(75, 30);
			this.btnCancel.TabIndex = 92;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.chbOpen.AutoSize = true;
			this.chbOpen.BackColor = SystemColors.ControlLight;
			this.chbOpen.Location = new Point(11, 6);
			this.chbOpen.Name = "chbOpen";
			this.chbOpen.Padding = new Padding(3, 1, 1, 1);
			this.chbOpen.Size = new Size(157, 22);
			this.chbOpen.TabIndex = 93;
			this.chbOpen.Text = "เปิดการใช้งาน (Enable)";
			this.chbOpen.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(7f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(854, 391);
			base.ControlBox = false;
			base.Controls.Add(this.chbOpen);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnUpdate);
			base.Controls.Add(this.gbStockThreshold);
			base.Controls.Add(this.gbPolicy);
			base.Controls.Add(this.lbLoading);
			this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.Margin = new Padding(3, 5, 3, 5);
			base.MaximizeBox = false;
			base.Name = "frmRiskControl";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Risk Control Tools. / เครื่องมือควบคุมความเสี่ยง";
			base.Shown += new EventHandler(this.frmStockThreshold_Shown);
			base.FormClosing += new FormClosingEventHandler(this.frmStockThreshold_FormClosing);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.gbPolicy.ResumeLayout(false);
			this.gbPolicy.PerformLayout();
			this.gbStockThreshold.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004F08 File Offset: 0x00003308
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmRiskControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwReloadData = null;
			this._stockTHItems = null;
			this.tds = null;
			this._isInit = false;
			this._isUpdate = false;
			this._isLoading = true;
			this.tmCloseSplash = null;
			base..ctor();
			this.InitializeComponent();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004F70 File Offset: 0x00003370
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockThreshold_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetLabelText("", Color.Black);
			this.Init();
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			if (ApplicationInfo.IsScreen125)
			{
				this.tbValueLimitValue.Left = this.chbValueLimit.Left + (int)base.CreateGraphics().MeasureString("กำหนดเงินลงทุนไม่ให้ซื้อหุ้นแต่ละตัวเกิน", this.chbValueLimit.Font).Width + 30;
				this.tbChgLimitValue.Left = this.chbChgLimit.Left + (int)base.CreateGraphics().MeasureString("กำหนดห้ามซื้อหุ้นที่ราคาบวก(Change Price) เกิน", this.chbChgLimit.Font).Width + 30;
				this.tbAvg5Volume.Left = this.chbAvg5Volume.Left + (int)base.CreateGraphics().MeasureString("จำนวนหุ้นที่ลงทุนไม่ควรเกิน", this.chbAvg5Volume.Font).Width + 30;
				this.tbSectorLimitValue.Left = this.chbSectorLimit.Left + (int)base.CreateGraphics().MeasureString("กำหนดต้องซื้อหุ้นให้มากกว่า", this.chbSectorLimit.Font).Width + 30;
				this.tbStocksInSector.Left = this.chbStocksInSector.Left + (int)base.CreateGraphics().MeasureString("กำหนดต้องซื้อหุ้นใน Sector เดียวกันมากกว่า", this.chbStocksInSector.Font).Width + 30;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000050F8 File Offset: 0x000034F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isInit)
				{
					this.chbOpen.Checked = ApplicationInfo.IsRiskActive;
					if (this.bgwReloadData == null)
					{
						this.bgwReloadData = new BackgroundWorker();
						this.bgwReloadData.WorkerReportsProgress = true;
						this.bgwReloadData.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
						this.bgwReloadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
					}
					this.tbStock.AutoCompleteCustomSource = ApplicationInfo.StockAutoComp;
					this.tbStock.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					this.tbStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
					this.SetLabelText("Loading...", Color.Black);
					this.ReloadData();
					this._isInit = true;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("Init", ex);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000520C File Offset: 0x0000360C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._stockTHItems == null)
				{
					this._stockTHItems = new Dictionary<string, frmRiskControl.StockThreasholdItem>();
				}
				else
				{
					this._stockTHItems.Clear();
				}
				foreach (DataRow dataRow in this.tds.Tables[0].Rows)
				{
					frmRiskControl.StockThreasholdItem value = new frmRiskControl.StockThreasholdItem(dataRow["stock"].ToString(), dataRow["side"].ToString(), Convert.ToDecimal(dataRow["price"].ToString()), Convert.ToInt64(dataRow["quantity"].ToString()));
					string text = dataRow["stock"].ToString();
					if (text == null)
					{
						goto IL_219;
					}
					if (!(text == "@VALUE"))
					{
						if (!(text == "@VOLUME"))
						{
							if (!(text == "@STSECTOR"))
							{
								if (!(text == "@SECTORS"))
								{
									if (!(text == "@CHG"))
									{
										goto IL_219;
									}
									this.chbChgLimit.Checked = true;
									this.tbChgLimitValue.Text = dataRow["quantity"].ToString();
								}
								else
								{
									this.chbSectorLimit.Checked = true;
									this.tbSectorLimitValue.Text = dataRow["quantity"].ToString();
								}
							}
							else
							{
								this.chbStocksInSector.Checked = true;
								this.tbStocksInSector.Text = dataRow["quantity"].ToString();
							}
						}
						else
						{
							this.chbAvg5Volume.Checked = true;
							this.tbAvg5Volume.Text = dataRow["quantity"].ToString();
						}
					}
					else
					{
						this.chbValueLimit.Checked = true;
						this.tbValueLimitValue.Text = dataRow["quantity"].ToString();
					}
					continue;
					IL_219:
					this._stockTHItems.Add(dataRow["stock"].ToString(), value);
				}
				this.UpdateToListView();
				this.SetLabelText("", Color.Black);
			}
			catch (Exception ex)
			{
				this.ShowError("StockThreshold:RunWorkerCompleted", ex);
			}
			this.IsLoadingData = false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000054F8 File Offset: 0x000038F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.IsLoadingData = true;
				string text = string.Empty;
				text = ApplicationInfo.WebService.StockThresholdInformation(ApplicationInfo.AccInfo.CurrentAccount);
				if (this.tds == null)
				{
					this.tds = new DataSet();
				}
				else
				{
					this.tds.Clear();
				}
				if (!string.IsNullOrEmpty(text))
				{
					MyDataHelper.StringToDataSet(text, this.tds);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_DoWork", ex);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000055B0 File Offset: 0x000039B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnRemoveRow_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._stockTHItems.Count == 0)
				{
					this.SetLabelText("Not Found Data.", Color.DarkRed);
					this.tbStock.Focus();
					this.tbStock.SelectAll();
				}
				else
				{
					try
					{
						if (this._stockTHItems.ContainsKey(this.tbStock.Text.Trim()))
						{
							this._stockTHItems.Remove(this.tbStock.Text.Trim());
							this.UpdateToListView();
							this.tbStock.Text = string.Empty;
							this.tbVolume.Text = string.Empty;
							this.tbPrice.Text = string.Empty;
						}
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("Remove Stock ThreshHold", ex);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000056D8 File Offset: 0x00003AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnAdd_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.IsNotNull())
				{
					StockList.StockInformation stockInformation = ApplicationInfo.StockInfo[this.tbStock.Text.Trim()];
					if (stockInformation.Number > 0)
					{
						long volume = 0L;
						decimal price = 0m;
						long.TryParse(this.tbVolume.Text.Replace(",", ""), out volume);
						decimal.TryParse(this.tbPrice.Text, out price);
						if (this._stockTHItems.ContainsKey(this.tbStock.Text.Trim()))
						{
							frmRiskControl.StockThreasholdItem stockThreasholdItem = this._stockTHItems[this.tbStock.Text.Trim()];
							stockThreasholdItem.stock = this.tbStock.Text;
							stockThreasholdItem.side = this.GetSideString();
							stockThreasholdItem.volume = volume;
							stockThreasholdItem.price = price;
						}
						else
						{
							frmRiskControl.StockThreasholdItem stockThreasholdItem = new frmRiskControl.StockThreasholdItem(this.tbStock.Text, this.GetSideString(), price, volume);
							this._stockTHItems.Add(this.tbStock.Text.Trim(), stockThreasholdItem);
						}
						this.UpdateToListView();
						this.tbStock.Text = string.Empty;
						this.tbVolume.Text = string.Empty;
						this.tbPrice.Text = string.Empty;
						this.SetLabelText("", Color.Black);
						this.tbStock.Focus();
					}
					else
					{
						this.SetLabelText("Invalid stock symbol!!!", Color.DarkRed);
						this.tbStock.Clear();
						this.tbStock.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnAdd_Click", ex);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000058EC File Offset: 0x00003CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void dgvListCondition_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Right)
			{
				this.cbSide.Focus();
			}
			else if (e.KeyCode == Keys.Left)
			{
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005958 File Offset: 0x00003D58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsStock_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Right)
			{
				this.tbVolume.Focus();
				this.tbVolume.SelectAll();
			}
			else if (e.KeyCode == Keys.Left)
			{
				this.cbSide.Focus();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000059DC File Offset: 0x00003DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsQuantity_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Right)
			{
				this.tbPrice.Focus();
				this.tbPrice.SelectAll();
			}
			else if (e.KeyCode == Keys.Left)
			{
				this.tbStock.Focus();
				this.tbStock.SelectAll();
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005A6C File Offset: 0x00003E6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsPrice_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Right)
			{
				this.btnAdd.PerformClick();
			}
			else if (e.KeyCode == Keys.Left)
			{
				this.tbVolume.Focus();
				this.tbVolume.SelectAll();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005AF0 File Offset: 0x00003EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rdSell_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Right)
			{
				this.tbStock.Focus();
				this.tbStock.SelectAll();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005B50 File Offset: 0x00003F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rdBuy_KeyUp(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Right)
			{
				this.cbSide.Focus();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005BA4 File Offset: 0x00003FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsQuantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.IsNumeric(sender, e);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005BC0 File Offset: 0x00003FC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.IsNumeric(sender, e);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005BDC File Offset: 0x00003FDC
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

		// Token: 0x0600001D RID: 29 RVA: 0x00005C18 File Offset: 0x00004018
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetSideString()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			if (this.cbSide.Text.ToLower() == "buy")
			{
				result = "B";
			}
			else if (this.cbSide.Text.ToLower() == "sell")
			{
				result = "S";
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005C9C File Offset: 0x0000409C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsNotNull()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			bool result;
			if (this.tbStock.Text == string.Empty)
			{
				this.SetLabelText("Stock is not null.", Color.DarkRed);
				this.tbStock.Focus();
				this.tbStock.SelectAll();
				result = true;
			}
			else if (this.tbVolume.Text == string.Empty && this.tbPrice.Text == string.Empty)
			{
				this.SetLabelText("Conditions is required. Between the volume and price.", Color.DarkRed);
				this.tbStock.Focus();
				this.tbStock.SelectAll();
				result = true;
			}
			else if (this.tbVolume.Text != string.Empty && this.cbSide.Text == string.Empty)
			{
				this.SetLabelText("Side is require", Color.DarkRed);
				this.cbSide.Focus();
				result = true;
			}
			else if (this.tbVolume.Text == string.Empty && this.cbSide.Text != string.Empty)
			{
				this.SetLabelText("Volume is require", Color.DarkRed);
				this.tbVolume.Focus();
				this.tbVolume.SelectAll();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005E54 File Offset: 0x00004254
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToListView()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intza.BeginUpdate();
				this.intza.ClearAllText();
				this.intza.Rows = 0;
				foreach (KeyValuePair<string, frmRiskControl.StockThreasholdItem> current in this._stockTHItems)
				{
					RecordItem recordItem = this.intza.AddRecord(1, false);
					recordItem.Fields("side").Text = current.Value.side;
					recordItem.Fields("stock").Text = current.Value.stock;
					recordItem.Fields("volume").Text = current.Value.volume.ToString();
					recordItem.Fields("price").Text = current.Value.price.ToString();
					Color fontColor = Color.Yellow;
					if (current.Value.side == "B")
					{
						fontColor = Color.Lime;
					}
					else if (current.Value.side == "S")
					{
						fontColor = Color.Red;
					}
					recordItem.Fields("side").FontColor = fontColor;
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("volume").FontColor = fontColor;
					recordItem.Fields("price").FontColor = fontColor;
				}
				this.intza.Redraw();
			}
			catch (Exception ex)
			{
				this.intza.Redraw();
				this.ShowError("UpdateToListView", ex);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00006070 File Offset: 0x00004470
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetLabelText(string message, Color color)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.lbMessage.Text = message;
			this.lbMessage.ForeColor = color;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000609C File Offset: 0x0000449C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IsNumeric(object sender, KeyPressEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyChar == '-' || (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || e.KeyChar == '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.')
			{
				if ((sender as Control).Text.IndexOf('.') > -1)
				{
					e.Handled = true;
				}
				else
				{
					e.Handled = false;
				}
			}
			if (e.KeyChar == '-')
			{
				if ((sender as Control).Text.IndexOf('-') > -1)
				{
					e.Handled = true;
				}
				else
				{
					e.Handled = false;
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000619C File Offset: 0x0000459C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsQuantity_TextChanged(object sender, EventArgs e)
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
						}
						catch
						{
							this.SetLabelText("Invalid quantity", Color.DarkRed);
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
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000062E4 File Offset: 0x000046E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbSide_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Right)
			{
				this.tbStock.Focus();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Left)
			{
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006360 File Offset: 0x00004760
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbSide_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!this._isUpdate)
			{
				this.tbStock.Focus();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00006398 File Offset: 0x00004798
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			((Control)sender).BackColor = Color.Yellow;
			((Control)sender).ForeColor = Color.Black;
			if (sender.GetType() == typeof(TextBox))
			{
				((TextBox)sender).SelectAll();
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006400 File Offset: 0x00004800
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void controlOrder_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			((Control)sender).BackColor = Color.White;
			((Control)sender).ForeColor = Color.Black;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00006434 File Offset: 0x00004834
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaTableGrid1_TableMouseClick(object sender, TableMouseEventArgs e)
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
						if (name == "side" || name == "stock")
						{
							if (this.intza.SortType == SortType.Asc)
							{
								this.intza.Sort(e.Column.Name, SortType.Desc);
							}
							else
							{
								this.intza.Sort(e.Column.Name, SortType.Asc);
							}
							this.intza.Redraw();
						}
					}
				}
				else if (e.RowIndex > -1 && e.RowIndex <= this.intza.Rows - 1)
				{
					this._isUpdate = true;
					RecordItem recordItem = this.intza.Records(e.RowIndex);
					if (recordItem.Fields("side").Text.ToString() == "B")
					{
						this.cbSide.Text = "BUY";
					}
					else if (recordItem.Fields("side").Text.ToString() == "S")
					{
						this.cbSide.Text = "SELL";
					}
					else
					{
						this.cbSide.Text = "";
					}
					this.tbStock.Text = recordItem.Fields("stock").Text.ToString();
					this.tbPrice.Text = Utilities.PriceFormat(recordItem.Fields("price").Text.ToString());
					this.tbVolume.Text = FormatUtil.VolumeFormat(recordItem.Fields("volume").Text.ToString(), true);
					this._isUpdate = false;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("TableMouseClick", ex);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00006688 File Offset: 0x00004A88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000066BC File Offset: 0x00004ABC
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000066E8 File Offset: 0x00004AE8
		public bool IsLoadingData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._isLoading;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (!base.DesignMode)
				{
					this._isLoading = value;
					this.ShowSplash(this._isLoading, "Loading...", false);
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006730 File Offset: 0x00004B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplash(bool visible, string message, bool isAutoClose)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmRiskControl.ShowSplashCallBack(this.ShowSplash), new object[]
				{
					visible,
					message,
					isAutoClose
				});
			}
			else
			{
				try
				{
					if (ApplicationInfo.SuuportSplash == "Y")
					{
						if (this.tmCloseSplash == null)
						{
							this.tmCloseSplash = new Timer();
							this.tmCloseSplash.Interval = 1000;
							this.tmCloseSplash.Tick += new EventHandler(this.tmCloseSplash_Tick);
						}
						if (visible)
						{
							this.lbLoading.Text = message;
							this.lbLoading.Left = (base.Width - this.lbLoading.Width) / 2;
							this.lbLoading.Top = (base.Height - this.lbLoading.Height) / 2;
							this.lbLoading.Visible = true;
							this.lbLoading.BringToFront();
							this.tmCloseSplash.Enabled = false;
							if (isAutoClose)
							{
								this.tmCloseSplash.Enabled = true;
							}
						}
						else
						{
							this.lbLoading.Visible = false;
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("ShowSplash", ex);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000068E0 File Offset: 0x00004CE0
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

		// Token: 0x0600002D RID: 45 RVA: 0x0000690C File Offset: 0x00004D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCancel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006924 File Offset: 0x00004D24
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.IsRiskActive = this.chbOpen.Checked;
				string text = string.Empty;
				if (this.chbValueLimit.Checked)
				{
					long num;
					long.TryParse(this.tbValueLimitValue.Text, out num);
					if (num <= 0L)
					{
						this.ShowSplash(true, "Invalid value!", true);
						this.tbValueLimitValue.Focus();
						return;
					}
					text = string.Concat(new object[]
					{
						"|",
						"@VALUE",
						"##",
						num,
						"#",
						0
					});
				}
				if (this.chbSectorLimit.Checked)
				{
					long num;
					long.TryParse(this.tbSectorLimitValue.Text, out num);
					if (num <= 0L)
					{
						this.ShowSplash(true, "Invalid value!", true);
						this.tbSectorLimitValue.Focus();
						return;
					}
					text = string.Concat(new object[]
					{
						text,
						"|",
						"@SECTORS",
						"##",
						num,
						"#",
						0
					});
				}
				if (this.chbStocksInSector.Checked)
				{
					long num;
					long.TryParse(this.tbStocksInSector.Text, out num);
					if (num <= 0L)
					{
						this.ShowSplash(true, "Invalid value!", true);
						this.tbStocksInSector.Focus();
						return;
					}
					text = string.Concat(new object[]
					{
						text,
						"|",
						"@STSECTOR",
						"##",
						num,
						"#",
						0
					});
				}
				if (this.chbChgLimit.Checked)
				{
					long num;
					long.TryParse(this.tbChgLimitValue.Text, out num);
					if (num <= 0L)
					{
						this.ShowSplash(true, "Invalid value!", true);
						this.tbChgLimitValue.Focus();
						return;
					}
					text = string.Concat(new object[]
					{
						text,
						"|",
						"@CHG",
						"##",
						num,
						"#",
						0
					});
				}
				if (this.chbAvg5Volume.Checked)
				{
					long num;
					long.TryParse(this.tbAvg5Volume.Text, out num);
					if (num <= 0L)
					{
						this.ShowSplash(true, "Invalid value!", true);
						this.tbAvg5Volume.Focus();
						return;
					}
					text = string.Concat(new object[]
					{
						text,
						"|",
						"@VOLUME",
						"##",
						num,
						"#",
						0
					});
				}
				foreach (KeyValuePair<string, frmRiskControl.StockThreasholdItem> current in this._stockTHItems)
				{
					text = string.Concat(new object[]
					{
						text,
						"|",
						current.Value.stock,
						"#",
						current.Value.side,
						"#",
						current.Value.volume,
						"#",
						current.Value.price
					});
				}
				if (text != string.Empty)
				{
					text = text.Substring(1);
				}
				this.IsLoadingData = true;
				ApplicationInfo.WebService.SaveStockThreshold(ApplicationInfo.AccInfo.CurrentAccount, text);
				base.Close();
			}
			catch (Exception ex)
			{
				this.ShowError("SaveStockThreshold", ex);
			}
			this.IsLoadingData = false;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006E20 File Offset: 0x00005220
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmStockThreshold_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._stockTHItems != null)
			{
				this._stockTHItems.Clear();
				this._stockTHItems = null;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00006E64 File Offset: 0x00005264
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnRiskMin_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tbValueLimitValue.Text = "10";
			this.tbStocksInSector.Text = "2";
			this.tbSectorLimitValue.Text = "5";
			this.tbChgLimitValue.Text = "5";
			this.tbAvg5Volume.Text = "1";
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006ED8 File Offset: 0x000052D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnRiskMedium_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tbValueLimitValue.Text = "20";
			this.tbStocksInSector.Text = "2";
			this.tbSectorLimitValue.Text = "3";
			this.tbChgLimitValue.Text = "10";
			this.tbAvg5Volume.Text = "3";
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006F4C File Offset: 0x0000534C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnRiskMax_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tbValueLimitValue.Text = "50";
			this.tbStocksInSector.Text = "2";
			this.tbSectorLimitValue.Text = "1";
			this.tbChgLimitValue.Text = "15";
			this.tbAvg5Volume.Text = "10";
		}

		// Token: 0x04000009 RID: 9
		private IContainer components;

		// Token: 0x0400000A RID: 10
		private Label lbQuantity;

		// Token: 0x0400000B RID: 11
		private Label lbStock;

		// Token: 0x0400000C RID: 12
		private TextBox tbPrice;

		// Token: 0x0400000D RID: 13
		private TextBox tbStock;

		// Token: 0x0400000E RID: 14
		private TextBox tbVolume;

		// Token: 0x0400000F RID: 15
		private Label lbPrice;

		// Token: 0x04000010 RID: 16
		private Button btnRemoveRow;

		// Token: 0x04000011 RID: 17
		private Button btnAdd;

		// Token: 0x04000012 RID: 18
		private Label label1;

		// Token: 0x04000013 RID: 19
		private Label lbLoading;

		// Token: 0x04000014 RID: 20
		private SortGrid intza;

		// Token: 0x04000015 RID: 21
		private Panel panel2;

		// Token: 0x04000016 RID: 22
		private ComboBox cbSide;

		// Token: 0x04000017 RID: 23
		private GroupBox gbPolicy;

		// Token: 0x04000018 RID: 24
		private CheckBox chbValueLimit;

		// Token: 0x04000019 RID: 25
		private TextBox tbValueLimitValue;

		// Token: 0x0400001A RID: 26
		private TextBox tbChgLimitValue;

		// Token: 0x0400001B RID: 27
		private CheckBox chbChgLimit;

		// Token: 0x0400001C RID: 28
		private TextBox tbSectorLimitValue;

		// Token: 0x0400001D RID: 29
		private GroupBox gbStockThreshold;

		// Token: 0x0400001E RID: 30
		private Label lbMessage;

		// Token: 0x0400001F RID: 31
		private Label label3;

		// Token: 0x04000020 RID: 32
		private Label label2;

		// Token: 0x04000021 RID: 33
		private Button btnUpdate;

		// Token: 0x04000022 RID: 34
		private Button btnCancel;

		// Token: 0x04000023 RID: 35
		private CheckBox chbOpen;

		// Token: 0x04000024 RID: 36
		private Label lbRiskLevel;

		// Token: 0x04000025 RID: 37
		private TextBox tbStocksInSector;

		// Token: 0x04000026 RID: 38
		private CheckBox chbAvg5Volume;

		// Token: 0x04000027 RID: 39
		private TextBox tbAvg5Volume;

		// Token: 0x04000028 RID: 40
		private CheckBox chbSectorLimit;

		// Token: 0x04000029 RID: 41
		private CheckBox chbStocksInSector;

		// Token: 0x0400002A RID: 42
		private Button btnRiskMax;

		// Token: 0x0400002B RID: 43
		private Button btnRiskMedium;

		// Token: 0x0400002C RID: 44
		private Button btnRiskMin;

		// Token: 0x0400002D RID: 45
		private BackgroundWorker bgwReloadData;

		// Token: 0x0400002E RID: 46
		private Dictionary<string, frmRiskControl.StockThreasholdItem> _stockTHItems;

		// Token: 0x0400002F RID: 47
		private DataSet tds;

		// Token: 0x04000030 RID: 48
		private bool _isInit;

		// Token: 0x04000031 RID: 49
		private bool _isUpdate;

		// Token: 0x04000032 RID: 50
		private bool _isLoading;

		// Token: 0x04000033 RID: 51
		private Timer tmCloseSplash;

		// Token: 0x02000006 RID: 6
		private class StockThreasholdItem
		{
			// Token: 0x06000033 RID: 51 RVA: 0x00006FC0 File Offset: 0x000053C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockThreasholdItem(string stock, string side, decimal price, long volume)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				this.stock = string.Empty;
				this.side = string.Empty;
				base..ctor();
				this.stock = stock;
				this.side = side;
				this.price = price;
				this.volume = volume;
			}

			// Token: 0x04000034 RID: 52
			public string stock;

			// Token: 0x04000035 RID: 53
			public string side;

			// Token: 0x04000036 RID: 54
			public decimal price;

			// Token: 0x04000037 RID: 55
			public long volume;
		}

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate void ShowSplashCallBack(bool visible, string message, bool isAutoClose);
	}
}
