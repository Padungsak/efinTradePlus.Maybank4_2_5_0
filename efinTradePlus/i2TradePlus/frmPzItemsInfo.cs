using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ.AutoTradeMessage;
using STIControl;
using STIControl.ExpandTableGrid;

namespace i2TradePlus
{
	// Token: 0x020000D7 RID: 215
	public class frmPzItemsInfo : Form
	{
		// Token: 0x06000A08 RID: 2568 RVA: 0x000BF2C4 File Offset: 0x000BD6C4
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

		// Token: 0x06000A09 RID: 2569 RVA: 0x000BF314 File Offset: 0x000BD714
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
			this.gridPzDetail = new ExpandGrid();
			this.lbPzRefNo2 = new Label();
			this.lbPzRefNo1 = new Label();
			this.lbLoading = new Label();
			this.panelPzEdit = new Panel();
			this.tbPin = new TextBox();
			this.lbPin = new Label();
			this.label1 = new Label();
			this.lbPzEditPrice = new Label();
			this.tbPzEditPrice = new TextBox();
			this.btnPzEditClose = new Button();
			this.btnPzEditSend = new Button();
			this.lbPzEditMAvg = new Label();
			this.tbPzEditMAvg = new TextBox();
			this.lbPzEditMVol = new Label();
			this.tbPzEditMVol = new TextBox();
			this.lbPzEditVolume = new Label();
			this.tbPzEditVolume = new TextBox();
			this.btnBack = new Button();
			this.btnPzEdit = new Button();
			this.btnReloadPzDetail = new Button();
			this.panelPzEdit.SuspendLayout();
			base.SuspendLayout();
			this.gridPzDetail.AllowDrop = true;
			this.gridPzDetail.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.gridPzDetail.BackColor = Color.FromArgb(20, 20, 20);
			this.gridPzDetail.CanBlink = true;
			this.gridPzDetail.CanDrag = false;
			this.gridPzDetail.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.FontColor = Color.LightGray;
			columnItem.IsExpand = false;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "No.";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 8;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.FontColor = Color.LightGray;
			columnItem2.IsExpand = false;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "price";
			columnItem2.Text = "Price";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 13;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.FontColor = Color.LightGray;
			columnItem3.IsExpand = false;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "volume";
			columnItem3.Text = "Volume";
			columnItem3.ValueFormat = FormatType.Volume;
			columnItem3.Visible = true;
			columnItem3.Width = 17;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.FontColor = Color.LightGray;
			columnItem4.IsExpand = false;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "budget";
			columnItem4.Text = "Budget";
			columnItem4.ValueFormat = FormatType.Volume;
			columnItem4.Visible = false;
			columnItem4.Width = 15;
			columnItem5.Alignment = StringAlignment.Center;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.FontColor = Color.LightGray;
			columnItem5.IsExpand = false;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "sdate";
			columnItem5.Text = "S-Date";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 15;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.FontColor = Color.LightGray;
			columnItem6.IsExpand = false;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "matvol";
			columnItem6.Text = "M-Volume";
			columnItem6.ValueFormat = FormatType.Volume;
			columnItem6.Visible = true;
			columnItem6.Width = 17;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.FontColor = Color.LightGray;
			columnItem7.IsExpand = false;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "cost";
			columnItem7.Text = "Cost";
			columnItem7.ValueFormat = FormatType.Volume;
			columnItem7.Visible = true;
			columnItem7.Width = 17;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.FontColor = Color.LightGray;
			columnItem8.IsExpand = false;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "mavg";
			columnItem8.Text = "Avg";
			columnItem8.ValueFormat = FormatType.Price;
			columnItem8.Visible = true;
			columnItem8.Width = 13;
			this.gridPzDetail.Columns.Add(columnItem);
			this.gridPzDetail.Columns.Add(columnItem2);
			this.gridPzDetail.Columns.Add(columnItem3);
			this.gridPzDetail.Columns.Add(columnItem4);
			this.gridPzDetail.Columns.Add(columnItem5);
			this.gridPzDetail.Columns.Add(columnItem6);
			this.gridPzDetail.Columns.Add(columnItem7);
			this.gridPzDetail.Columns.Add(columnItem8);
			this.gridPzDetail.CurrentScroll = 0;
			this.gridPzDetail.FocusItemIndex = -1;
			this.gridPzDetail.ForeColor = Color.Black;
			this.gridPzDetail.GridColor = Color.FromArgb(50, 50, 50);
			this.gridPzDetail.HeaderPctHeight = 100f;
			this.gridPzDetail.IsAutoRepaint = true;
			this.gridPzDetail.IsDrawGrid = true;
			this.gridPzDetail.IsDrawHeader = true;
			this.gridPzDetail.IsScrollable = true;
			this.gridPzDetail.Location = new Point(12, 36);
			this.gridPzDetail.MainColumn = "";
			this.gridPzDetail.Name = "gridPzDetail";
			this.gridPzDetail.Rows = 0;
			this.gridPzDetail.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.gridPzDetail.RowSelectType = 3;
			this.gridPzDetail.Size = new Size(763, 371);
			this.gridPzDetail.SortColumnName = "";
			this.gridPzDetail.SortType = SortType.Desc;
			this.gridPzDetail.TabIndex = 143;
			this.gridPzDetail.TableMouseClick += new ExpandGrid.TableMouseClickEventHandler(this.gridPzDetail_TableMouseClick);
			this.lbPzRefNo2.AutoSize = true;
			this.lbPzRefNo2.ForeColor = Color.Cyan;
			this.lbPzRefNo2.Location = new Point(119, 12);
			this.lbPzRefNo2.Name = "lbPzRefNo2";
			this.lbPzRefNo2.Size = new Size(10, 13);
			this.lbPzRefNo2.TabIndex = 146;
			this.lbPzRefNo2.Text = "-";
			this.lbPzRefNo1.AutoSize = true;
			this.lbPzRefNo1.ForeColor = Color.LightGray;
			this.lbPzRefNo1.Location = new Point(72, 12);
			this.lbPzRefNo1.Name = "lbPzRefNo1";
			this.lbPzRefNo1.Size = new Size(44, 13);
			this.lbPzRefNo1.TabIndex = 145;
			this.lbPzRefNo1.Text = "Ref No.";
			this.lbLoading.AutoSize = true;
			this.lbLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbLoading.ForeColor = Color.Yellow;
			this.lbLoading.Location = new Point(325, 189);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Padding = new Padding(4, 3, 4, 3);
			this.lbLoading.Size = new Size(71, 23);
			this.lbLoading.TabIndex = 149;
			this.lbLoading.Text = "Loading...";
			this.lbLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbLoading.Visible = false;
			this.panelPzEdit.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelPzEdit.BackColor = Color.FromArgb(50, 50, 50);
			this.panelPzEdit.Controls.Add(this.tbPin);
			this.panelPzEdit.Controls.Add(this.lbPin);
			this.panelPzEdit.Controls.Add(this.label1);
			this.panelPzEdit.Controls.Add(this.lbPzEditPrice);
			this.panelPzEdit.Controls.Add(this.tbPzEditPrice);
			this.panelPzEdit.Controls.Add(this.btnPzEditClose);
			this.panelPzEdit.Controls.Add(this.btnPzEditSend);
			this.panelPzEdit.Controls.Add(this.lbPzEditMAvg);
			this.panelPzEdit.Controls.Add(this.tbPzEditMAvg);
			this.panelPzEdit.Controls.Add(this.lbPzEditMVol);
			this.panelPzEdit.Controls.Add(this.tbPzEditMVol);
			this.panelPzEdit.Controls.Add(this.lbPzEditVolume);
			this.panelPzEdit.Controls.Add(this.tbPzEditVolume);
			this.panelPzEdit.Location = new Point(12, 351);
			this.panelPzEdit.Name = "panelPzEdit";
			this.panelPzEdit.Size = new Size(763, 58);
			this.panelPzEdit.TabIndex = 150;
			this.panelPzEdit.Visible = false;
			this.tbPin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.tbPin.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tbPin.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPin.BorderStyle = BorderStyle.FixedSingle;
			this.tbPin.CharacterCasing = CharacterCasing.Upper;
			this.tbPin.Location = new Point(437, 29);
			this.tbPin.Margin = new Padding(2, 3, 2, 3);
			this.tbPin.MaxLength = 10;
			this.tbPin.Name = "tbPin";
			this.tbPin.PasswordChar = '*';
			this.tbPin.Size = new Size(55, 20);
			this.tbPin.TabIndex = 151;
			this.lbPin.AutoSize = true;
			this.lbPin.ForeColor = Color.LightGray;
			this.lbPin.Location = new Point(408, 33);
			this.lbPin.Margin = new Padding(2, 0, 2, 0);
			this.lbPin.Name = "lbPin";
			this.lbPin.Size = new Size(25, 13);
			this.lbPin.TabIndex = 152;
			this.lbPin.Text = "PIN";
			this.lbPin.TextAlign = ContentAlignment.MiddleLeft;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Gray;
			this.label1.ForeColor = Color.WhiteSmoke;
			this.label1.Location = new Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new Size(40, 13);
			this.label1.TabIndex = 150;
			this.label1.Text = "  Edit   ";
			this.lbPzEditPrice.AutoSize = true;
			this.lbPzEditPrice.ForeColor = Color.LightGray;
			this.lbPzEditPrice.Location = new Point(5, 33);
			this.lbPzEditPrice.Margin = new Padding(2, 0, 2, 0);
			this.lbPzEditPrice.Name = "lbPzEditPrice";
			this.lbPzEditPrice.Size = new Size(31, 13);
			this.lbPzEditPrice.TabIndex = 147;
			this.lbPzEditPrice.Text = "Price";
			this.lbPzEditPrice.TextAlign = ContentAlignment.MiddleLeft;
			this.tbPzEditPrice.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPzEditPrice.BorderStyle = BorderStyle.FixedSingle;
			this.tbPzEditPrice.Location = new Point(36, 29);
			this.tbPzEditPrice.Margin = new Padding(2, 3, 2, 3);
			this.tbPzEditPrice.MaxLength = 10;
			this.tbPzEditPrice.Name = "tbPzEditPrice";
			this.tbPzEditPrice.Size = new Size(43, 20);
			this.tbPzEditPrice.TabIndex = 148;
			this.btnPzEditClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnPzEditClose.BackColor = Color.Transparent;
			this.btnPzEditClose.Cursor = Cursors.Hand;
			this.btnPzEditClose.FlatAppearance.BorderColor = Color.DimGray;
			this.btnPzEditClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPzEditClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnPzEditClose.FlatStyle = FlatStyle.Flat;
			this.btnPzEditClose.ForeColor = Color.LightGray;
			this.btnPzEditClose.Image = Resources.side_noside;
			this.btnPzEditClose.Location = new Point(556, 29);
			this.btnPzEditClose.Name = "btnPzEditClose";
			this.btnPzEditClose.Size = new Size(52, 22);
			this.btnPzEditClose.TabIndex = 137;
			this.btnPzEditClose.TabStop = false;
			this.btnPzEditClose.Text = "Cancel";
			this.btnPzEditClose.UseVisualStyleBackColor = false;
			this.btnPzEditClose.Click += new EventHandler(this.btnPzEditClose_Click);
			this.btnPzEditSend.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnPzEditSend.BackColor = Color.Transparent;
			this.btnPzEditSend.Cursor = Cursors.Hand;
			this.btnPzEditSend.FlatAppearance.BorderColor = Color.DimGray;
			this.btnPzEditSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPzEditSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnPzEditSend.FlatStyle = FlatStyle.Flat;
			this.btnPzEditSend.ForeColor = Color.LightGray;
			this.btnPzEditSend.Image = Resources.side_noside;
			this.btnPzEditSend.Location = new Point(498, 29);
			this.btnPzEditSend.MaximumSize = new Size(58, 23);
			this.btnPzEditSend.Name = "btnPzEditSend";
			this.btnPzEditSend.Size = new Size(52, 22);
			this.btnPzEditSend.TabIndex = 136;
			this.btnPzEditSend.TabStop = false;
			this.btnPzEditSend.Text = "Confirm";
			this.btnPzEditSend.UseVisualStyleBackColor = false;
			this.btnPzEditSend.Click += new EventHandler(this.btnPzEditSave_Click);
			this.lbPzEditMAvg.AutoSize = true;
			this.lbPzEditMAvg.ForeColor = Color.LightGray;
			this.lbPzEditMAvg.Location = new Point(320, 33);
			this.lbPzEditMAvg.Margin = new Padding(2, 0, 2, 0);
			this.lbPzEditMAvg.Name = "lbPzEditMAvg";
			this.lbPzEditMAvg.Size = new Size(38, 13);
			this.lbPzEditMAvg.TabIndex = 125;
			this.lbPzEditMAvg.Text = "M-Avg";
			this.lbPzEditMAvg.TextAlign = ContentAlignment.MiddleLeft;
			this.tbPzEditMAvg.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPzEditMAvg.BorderStyle = BorderStyle.FixedSingle;
			this.tbPzEditMAvg.Location = new Point(361, 29);
			this.tbPzEditMAvg.Margin = new Padding(2, 3, 2, 3);
			this.tbPzEditMAvg.MaxLength = 10;
			this.tbPzEditMAvg.Name = "tbPzEditMAvg";
			this.tbPzEditMAvg.Size = new Size(42, 20);
			this.tbPzEditMAvg.TabIndex = 126;
			this.lbPzEditMVol.AutoSize = true;
			this.lbPzEditMVol.ForeColor = Color.LightGray;
			this.lbPzEditMVol.Location = new Point(195, 33);
			this.lbPzEditMVol.Margin = new Padding(2, 0, 2, 0);
			this.lbPzEditMVol.Name = "lbPzEditMVol";
			this.lbPzEditMVol.Size = new Size(54, 13);
			this.lbPzEditMVol.TabIndex = 123;
			this.lbPzEditMVol.Text = "M-Volume";
			this.lbPzEditMVol.TextAlign = ContentAlignment.MiddleLeft;
			this.tbPzEditMVol.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPzEditMVol.BorderStyle = BorderStyle.FixedSingle;
			this.tbPzEditMVol.Location = new Point(251, 29);
			this.tbPzEditMVol.Margin = new Padding(2, 3, 2, 3);
			this.tbPzEditMVol.MaxLength = 10;
			this.tbPzEditMVol.Name = "tbPzEditMVol";
			this.tbPzEditMVol.Size = new Size(61, 20);
			this.tbPzEditMVol.TabIndex = 124;
			this.lbPzEditVolume.AutoSize = true;
			this.lbPzEditVolume.ForeColor = Color.LightGray;
			this.lbPzEditVolume.Location = new Point(83, 33);
			this.lbPzEditVolume.Margin = new Padding(2, 0, 2, 0);
			this.lbPzEditVolume.Name = "lbPzEditVolume";
			this.lbPzEditVolume.Size = new Size(42, 13);
			this.lbPzEditVolume.TabIndex = 121;
			this.lbPzEditVolume.Text = "Volume";
			this.lbPzEditVolume.TextAlign = ContentAlignment.MiddleLeft;
			this.tbPzEditVolume.BackColor = Color.FromArgb(224, 224, 224);
			this.tbPzEditVolume.BorderStyle = BorderStyle.FixedSingle;
			this.tbPzEditVolume.Location = new Point(127, 29);
			this.tbPzEditVolume.Margin = new Padding(2, 3, 2, 3);
			this.tbPzEditVolume.MaxLength = 10;
			this.tbPzEditVolume.Name = "tbPzEditVolume";
			this.tbPzEditVolume.Size = new Size(61, 20);
			this.tbPzEditVolume.TabIndex = 122;
			this.btnBack.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnBack.BackColor = Color.Transparent;
			this.btnBack.Cursor = Cursors.Hand;
			this.btnBack.FlatAppearance.BorderColor = Color.DimGray;
			this.btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnBack.FlatStyle = FlatStyle.Flat;
			this.btnBack.ForeColor = Color.LightGray;
			this.btnBack.Image = Resources.side_noside;
			this.btnBack.Location = new Point(722, 7);
			this.btnBack.MaximumSize = new Size(58, 23);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new Size(54, 22);
			this.btnBack.TabIndex = 148;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new EventHandler(this.btnBack_Click);
			this.btnPzEdit.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnPzEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnPzEdit.BackColor = Color.Transparent;
			this.btnPzEdit.Cursor = Cursors.Hand;
			this.btnPzEdit.FlatAppearance.BorderColor = Color.DimGray;
			this.btnPzEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnPzEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnPzEdit.FlatStyle = FlatStyle.Flat;
			this.btnPzEdit.ForeColor = Color.LightGray;
			this.btnPzEdit.Image = Resources.pink__tab;
			this.btnPzEdit.Location = new Point(658, 7);
			this.btnPzEdit.MaximumSize = new Size(58, 23);
			this.btnPzEdit.Name = "btnPzEdit";
			this.btnPzEdit.Size = new Size(54, 22);
			this.btnPzEdit.TabIndex = 147;
			this.btnPzEdit.TabStop = false;
			this.btnPzEdit.Text = "Edit";
			this.btnPzEdit.UseVisualStyleBackColor = false;
			this.btnPzEdit.Visible = false;
			this.btnPzEdit.Click += new EventHandler(this.btnPzEditSend_Click);
			this.btnReloadPzDetail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnReloadPzDetail.BackColor = Color.Transparent;
			this.btnReloadPzDetail.Cursor = Cursors.Hand;
			this.btnReloadPzDetail.FlatAppearance.BorderColor = Color.DimGray;
			this.btnReloadPzDetail.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnReloadPzDetail.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnReloadPzDetail.FlatStyle = FlatStyle.Flat;
			this.btnReloadPzDetail.ForeColor = Color.LightGray;
			this.btnReloadPzDetail.Image = Resources.side_noside;
			this.btnReloadPzDetail.Location = new Point(12, 7);
			this.btnReloadPzDetail.MaximumSize = new Size(58, 23);
			this.btnReloadPzDetail.Name = "btnReloadPzDetail";
			this.btnReloadPzDetail.Size = new Size(54, 22);
			this.btnReloadPzDetail.TabIndex = 144;
			this.btnReloadPzDetail.TabStop = false;
			this.btnReloadPzDetail.Text = "Reload";
			this.btnReloadPzDetail.UseVisualStyleBackColor = false;
			this.btnReloadPzDetail.Click += new EventHandler(this.btnReloadPzDetail_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new Size(787, 415);
			base.Controls.Add(this.panelPzEdit);
			base.Controls.Add(this.lbLoading);
			base.Controls.Add(this.btnBack);
			base.Controls.Add(this.gridPzDetail);
			base.Controls.Add(this.btnPzEdit);
			base.Controls.Add(this.lbPzRefNo2);
			base.Controls.Add(this.lbPzRefNo1);
			base.Controls.Add(this.btnReloadPzDetail);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmPzItemsInfo";
			this.Text = "frmPzItems";
			base.Shown += new EventHandler(this.frmPzItemsInfo_Shown);
			this.panelPzEdit.ResumeLayout(false);
			this.panelPzEdit.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000C0C88 File Offset: 0x000BF088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmPzItemsInfo(long refNo, string stock) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._refNo = 0L;
			this._tranNo = 0;
			this._symbol = string.Empty;
			this._isReloadData = false;
			this.bgwSendOrder = null;
			this._commPz = null;
			this._frmConfirm = null;
			this._verifyResult_Pin = false;
			this._verifyResultStr_Pin = string.Empty;
			
			this.InitializeComponent();
			try
			{
				this._refNo = refNo;
				this._symbol = stock;
				this.bgwSendOrder = new BackgroundWorker();
				this.bgwSendOrder.WorkerReportsProgress = true;
				this.bgwSendOrder.DoWork += new DoWorkEventHandler(this.bgwSendOrder_DoWork);
				this.bgwSendOrder.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwSendOrder_RunWorkerCompleted);
			}
			catch (Exception ex)
			{
				this.ShowError("frmPzItemsInfo.Create", ex);
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000C0D8C File Offset: 0x000BF18C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmPzItemsInfo_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.lbPzRefNo2.Text = this._refNo.ToString();
				this.tbPin.Text = ApplicationInfo.UserPincodeLastEntry;
				this.Reload();
			}
			catch (Exception ex)
			{
				this.ShowError("frmPzItemsInfo_Shown", ex);
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000C0E04 File Offset: 0x000BF204
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPzEditSend_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.gridPzDetail.FocusItemIndex > -1)
				{
					int focusItemIndex = this.gridPzDetail.FocusItemIndex;
					RecordItem recordItem = this.gridPzDetail.Records(focusItemIndex);
					int.TryParse(recordItem.Fields("no").Text.ToString(), out this._tranNo);
					this.tbPzEditVolume.Text = recordItem.Fields("volume").Text.ToString().Replace(",", "");
					this.tbPzEditPrice.Text = recordItem.Fields("price").Text.ToString();
					this.tbPzEditMVol.Text = recordItem.Fields("matvol").Text.ToString();
					this.tbPzEditMAvg.Text = recordItem.Fields("mavg").Text.ToString();
					string a = recordItem.Fields("sdate").Text.ToString();
					this.tbPzEditPrice.Enabled = (a == string.Empty);
					this.tbPzEditVolume.Enabled = (a == string.Empty);
					this.tbPzEditMVol.Enabled = (a == string.Empty);
					this.tbPzEditMAvg.Enabled = (a == string.Empty);
					this.gridPzDetail.Height = base.Height - this.gridPzDetail.Top - this.panelPzEdit.Height - 15;
					this.gridPzDetail.Enabled = false;
					this.panelPzEdit.Top = this.gridPzDetail.Bottom + 10;
					this.panelPzEdit.Show();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnPzEditSend_Click", ex);
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000C1014 File Offset: 0x000BF414
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000C1048 File Offset: 0x000BF448
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnBack_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000C1060 File Offset: 0x000BF460
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnReloadPzDetail_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Reload();
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x000C1078 File Offset: 0x000BF478
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reload()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this._isReloadData)
				{
					this.btnPzEdit.Visible = false;
					this.ShowSplash(true);
					ApplicationInfo.WebAlertService.ViewAutoTradePzItemsCompleted -= new ViewAutoTradePzItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradePzItemsCompleted);
					ApplicationInfo.WebAlertService.ViewAutoTradePzItemsCompleted += new ViewAutoTradePzItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradePzItemsCompleted);
					this._isReloadData = true;
					ApplicationInfo.WebAlertService.ViewAutoTradePzItemsAsync(this._refNo);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("Reload", ex);
				this.ShowSplash(false);
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000C1134 File Offset: 0x000BF534
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebAlertService_ViewAutoTradePzItemsCompleted(object sender, ViewAutoTradePzItemsCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.WebAlertService.ViewAutoTradePzItemsCompleted -= new ViewAutoTradePzItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradePzItemsCompleted);
				if (e.Error == null)
				{
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(e.Result.ToString(), dataSet);
						if (dataSet != null && dataSet.Tables.Contains("AUTO"))
						{
							this.gridPzDetail.Rows = dataSet.Tables["AUTO"].Rows.Count;
							int num = 0;
							foreach (DataRow dataRow in dataSet.Tables["AUTO"].Rows)
							{
								RecordItem recordItem = this.gridPzDetail.Records(num);
								recordItem.Fields("no").Text = dataRow["iTransNo"];
								recordItem.Fields("price").Text = dataRow["nmrBuyPrice"];
								recordItem.Fields("volume").Text = dataRow["iBuyVol"];
								recordItem.Fields("budget").Text = dataRow["nmrBudget"];
								recordItem.Fields("sdate").Text = Utilities.GetDateFormat(dataRow["sLastSentDate"].ToString());
								long num2;
								long.TryParse(dataRow["iMatVol"].ToString(), out num2);
								decimal num3;
								decimal.TryParse(dataRow["nmrMatVal"].ToString(), out num3);
								recordItem.Fields("matvol").Text = num2;
								recordItem.Fields("cost").Text = num3;
								if (num2 > 0L)
								{
									recordItem.Fields("mavg").Text = num3 / num2;
								}
								else
								{
									recordItem.Fields("mavg").Text = "";
								}
								recordItem.Fields("price").FontColor = MyColor.UnChgColor;
								recordItem.Fields("volume").FontColor = MyColor.UnChgColor;
								recordItem.Fields("budget").FontColor = Color.LightGray;
								recordItem.Fields("matvol").FontColor = Color.Cyan;
								recordItem.Fields("cost").FontColor = Color.Cyan;
								recordItem.Fields("mavg").FontColor = Color.Cyan;
								recordItem.Fields("sdate").FontColor = Color.LightGray;
								num++;
							}
							this.gridPzDetail.Redraw();
						}
						dataSet.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				this.gridPzDetail.Redraw();
				this.ShowError("ViewAutoTradePzCompleted", ex);
			}
			this._isReloadData = false;
			this.ShowSplash(false);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000C150C File Offset: 0x000BF90C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowSplash(bool visible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmPzItemsInfo.ShowSplashCallBack(this.ShowSplash), new object[]
				{
					visible
				});
			}
			else if (ApplicationInfo.SuuportSplash == "Y")
			{
				try
				{
					if (visible)
					{
						this.lbLoading.Left = (base.Width - this.lbLoading.Width) / 2;
						this.lbLoading.Top = (base.Height - this.lbLoading.Height) / 2;
						this.lbLoading.Visible = true;
						this.lbLoading.BringToFront();
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

		// Token: 0x06000A13 RID: 2579 RVA: 0x000C1628 File Offset: 0x000BFA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPzEditSave_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._commPz = new AutoTradePzCommand();
				this._commPz.RefNo = this._refNo;
				this._commPz.Symbol = this._symbol;
				this._commPz.CommandType = "EDIT";
				this._commPz.Items = new List<AutoTradePzItem>();
				AutoTradePzItem autoTradePzItem = new AutoTradePzItem();
				autoTradePzItem.RefNo = this._refNo;
				autoTradePzItem.TransNo = this._tranNo;
				autoTradePzItem.BuyPrice = Convert.ToDecimal(this.tbPzEditPrice.Text);
				autoTradePzItem.BuyVolume = Convert.ToInt64(this.tbPzEditVolume.Text.Replace(",", ""));
				long num;
				long.TryParse(this.tbPzEditMVol.Text.Replace(",", ""), out num);
				autoTradePzItem.MatchedVol = num;
				decimal d;
				decimal.TryParse(this.tbPzEditMAvg.Text, out d);
				autoTradePzItem.MatchedVal = num * d;
				CultureInfo cultureInfo = new CultureInfo("en-US");
				autoTradePzItem.SendDate = ((num > 0L) ? DateTime.Now.ToString("yyyyMMdd") : "");
				if (autoTradePzItem.BuyVolume <= 0L)
				{
					this.ShowMessageBox("Invalid Volume", frmOrderFormConfirm.OpenStyle.Error, this.tbPzEditVolume);
				}
				else if (autoTradePzItem.MatchedVol < 0L)
				{
					this.ShowMessageBox("Invalid Matched Volume", frmOrderFormConfirm.OpenStyle.Error, this.tbPzEditMVol);
				}
				else if (autoTradePzItem.MatchedVol > autoTradePzItem.BuyVolume)
				{
					this.ShowMessageBox("Invalid Matched Volume", frmOrderFormConfirm.OpenStyle.Error, this.tbPzEditMVol);
				}
				else if (autoTradePzItem.MatchedVol > 0L && autoTradePzItem.MatchedVal <= 0m)
				{
					this.ShowMessageBox("Invalid Avg", frmOrderFormConfirm.OpenStyle.Error, this.tbPzEditMAvg);
				}
				else
				{
					this._commPz.Items.Add(autoTradePzItem);
					string orderParam = string.Concat(new object[]
					{
						"Pricing zone : Edit ",
						"\nRefNo : ‘",
						autoTradePzItem.RefNo,
						"’",
						"\nTransNo : ",
						autoTradePzItem.TransNo
					});
					this.ShowOrderFormConfirm("Confirm to send?", orderParam, frmOrderFormConfirm.OpenStyle.ConfirmSendNew);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnPzEditSave_Click", ex);
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000C1900 File Offset: 0x000BFD00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageBox(string message, frmOrderFormConfirm.OpenStyle openStyle, Control lastFocusOjb)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmPzItemsInfo.ShowMessageBoxCallBack(this.ShowMessageBox), new object[]
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

		// Token: 0x06000A15 RID: 2581 RVA: 0x000C1ABC File Offset: 0x000BFEBC
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
				if (ApplicationInfo.IsEquityAccount)
				{
					frmOrderFormConfirm.OpenStyle openFormStyle = ((frmOrderFormConfirm)sender).OpenFormStyle;
					if (openFormStyle == frmOrderFormConfirm.OpenStyle.ConfirmSendNew)
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
					}
					else if (this._lastFocusOjb != null)
					{
						this._lastFocusOjb.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ConfirmForm", ex);
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000C1BAC File Offset: 0x000BFFAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPzEditClose_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.panelPzEdit.Hide();
			this.gridPzDetail.Height = base.Height - this.gridPzDetail.Top - 5;
			this.gridPzDetail.Enabled = true;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000C1C04 File Offset: 0x000C0004
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowOrderFormConfirm(string message, string orderParam, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmPzItemsInfo.ShowOrderFormConfirmCallBack(this.ShowOrderFormConfirm), new object[]
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

		// Token: 0x06000A18 RID: 2584 RVA: 0x000C1DF8 File Offset: 0x000C01F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSendOrder_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			try
			{
				string text = this.tbPin.Text.Trim();
				if (text == string.Empty)
				{
					this._verifyResult_Pin = false;
					this._verifyResultStr_Pin = "Pincode is empty!!!";
					return;
				}
				if (ApplicationInfo.UserPincodeWrongCount < ApplicationInfo.UserMaxRetryPincode)
				{
					this._verifyResult_Pin = ApplicationInfo.VerifyPincode(text, ref this._verifyResultStr_Pin);
				}
				if (this._verifyResult_Pin)
				{
					AutoTradeMain autoTradeMain = new AutoTradeMain();
					autoTradeMain.Pack("PZ", this._commPz);
					result = ApplicationInfo.WebAlertService.SendAutoTrade(autoTradeMain.ToMessage());
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSendOrder_DoWork", ex);
				result = ex.Message;
			}
			e.Result = result;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000C1F04 File Offset: 0x000C0304
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
					if (this._verifyResult_Pin)
					{
						string data = e.Result.ToString();
						using (DataSet dataSet = new DataSet())
						{
							MyDataHelper.StringToDataSet(data, dataSet);
							if (dataSet.Tables.Contains("Results") && dataSet.Tables["Results"].Rows.Count > 0)
							{
								if (dataSet.Tables["Results"].Rows[0]["message"].ToString() == "ok")
								{
									this.Reload();
									this.btnPzEditClose.PerformClick();
								}
								else
								{
									this.ShowMessageBox(dataSet.Tables["Results"].Rows[0]["message"].ToString(), frmOrderFormConfirm.OpenStyle.Error, null);
								}
							}
							dataSet.Clear();
						}
					}
					else if (ApplicationInfo.UserPincodeWrongCount < ApplicationInfo.UserMaxRetryPincode)
					{
						this.ShowMessageBox(this._verifyResultStr_Pin, frmOrderFormConfirm.OpenStyle.ShowBox, null);
						this.tbPin.Focus();
					}
					else if (this._verifyResultStr_Pin == ApplicationInfo.PINCODE_TIMEOUT)
					{
						this.ShowMessageBox("*** Pincode timeout. ***\nPlease entry again!", frmOrderFormConfirm.OpenStyle.ShowBox, null);
					}
					else
					{
						this.ShowMessageBox("*** Pincode Locked. ***\nPlease logout and login again!", frmOrderFormConfirm.OpenStyle.ShowBox, null);
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
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000C213C File Offset: 0x000C053C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void gridPzDetail_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.RowIndex > -1)
				{
				}
			}
			catch (Exception ex)
			{
				this.ShowError("gridPzDetail_TableMouseClick", ex);
			}
		}

		// Token: 0x040006B2 RID: 1714
		private IContainer components;

		// Token: 0x040006B3 RID: 1715
		private ExpandGrid gridPzDetail;

		// Token: 0x040006B4 RID: 1716
		private Button btnPzEdit;

		// Token: 0x040006B5 RID: 1717
		private Label lbPzRefNo2;

		// Token: 0x040006B6 RID: 1718
		private Label lbPzRefNo1;

		// Token: 0x040006B7 RID: 1719
		private Button btnReloadPzDetail;

		// Token: 0x040006B8 RID: 1720
		private Button btnBack;

		// Token: 0x040006B9 RID: 1721
		private Label lbLoading;

		// Token: 0x040006BA RID: 1722
		private Panel panelPzEdit;

		// Token: 0x040006BB RID: 1723
		private Label lbPzEditPrice;

		// Token: 0x040006BC RID: 1724
		private TextBox tbPzEditPrice;

		// Token: 0x040006BD RID: 1725
		private Button btnPzEditClose;

		// Token: 0x040006BE RID: 1726
		private Button btnPzEditSend;

		// Token: 0x040006BF RID: 1727
		private Label lbPzEditMAvg;

		// Token: 0x040006C0 RID: 1728
		private TextBox tbPzEditMAvg;

		// Token: 0x040006C1 RID: 1729
		private Label lbPzEditMVol;

		// Token: 0x040006C2 RID: 1730
		private TextBox tbPzEditMVol;

		// Token: 0x040006C3 RID: 1731
		private Label lbPzEditVolume;

		// Token: 0x040006C4 RID: 1732
		private TextBox tbPzEditVolume;

		// Token: 0x040006C5 RID: 1733
		private Label label1;

		// Token: 0x040006C6 RID: 1734
		private TextBox tbPin;

		// Token: 0x040006C7 RID: 1735
		private Label lbPin;

		// Token: 0x040006C8 RID: 1736
		private long _refNo;

		// Token: 0x040006C9 RID: 1737
		private int _tranNo;

		// Token: 0x040006CA RID: 1738
		private string _symbol;

		// Token: 0x040006CB RID: 1739
		private bool _isReloadData;

		// Token: 0x040006CC RID: 1740
		private BackgroundWorker bgwSendOrder;

		// Token: 0x040006CD RID: 1741
		private AutoTradePzCommand _commPz;

		// Token: 0x040006CE RID: 1742
		private Control _lastFocusOjb;

		// Token: 0x040006CF RID: 1743
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x040006D0 RID: 1744
		private bool _verifyResult_Pin;

		// Token: 0x040006D1 RID: 1745
		private string _verifyResultStr_Pin;

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x06000A1C RID: 2588
		private delegate void ShowSplashCallBack(bool visible);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x06000A20 RID: 2592
		private delegate void ShowMessageBoxCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle, Control lastFocusOjb);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x06000A24 RID: 2596
		private delegate void ShowOrderFormConfirmCallBack(string message, string orderParam, frmOrderFormConfirm.OpenStyle openStyle);
	}
}
