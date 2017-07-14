using System;
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
	// Token: 0x02000079 RID: 121
	public class frmDcaItemsInfo : Form
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x00063D78 File Offset: 0x00062178
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

		// Token: 0x06000590 RID: 1424 RVA: 0x00063DC8 File Offset: 0x000621C8
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
			ColumnItem columnItem9 = new ColumnItem();
			ColumnItem columnItem10 = new ColumnItem();
			ColumnItem columnItem11 = new ColumnItem();
			this.gridDcaDetail = new ExpandGrid();
			this.lbDcaRefNo2 = new Label();
			this.lbDcaRefNo1 = new Label();
			this.btnReloadDcaDetail = new Button();
			this.btnBack = new Button();
			base.SuspendLayout();
			this.gridDcaDetail.AllowDrop = true;
			this.gridDcaDetail.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.gridDcaDetail.BackColor = Color.FromArgb(20, 20, 20);
			this.gridDcaDetail.CanBlink = true;
			this.gridDcaDetail.CanDrag = false;
			this.gridDcaDetail.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.FontColor = Color.LightGray;
			columnItem.IsExpand = false;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "No.";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 6;
			columnItem2.Alignment = StringAlignment.Center;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.FontColor = Color.LightGray;
			columnItem2.IsExpand = false;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "date";
			columnItem2.Text = "Date";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 13;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.FontColor = Color.LightGray;
			columnItem3.IsExpand = false;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "budget";
			columnItem3.Text = "Budget";
			columnItem3.ValueFormat = FormatType.Volume;
			columnItem3.Visible = true;
			columnItem3.Width = 13;
			columnItem4.Alignment = StringAlignment.Center;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.FontColor = Color.LightGray;
			columnItem4.IsExpand = false;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "buy_price";
			columnItem4.Text = "Price";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 10;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.FontColor = Color.LightGray;
			columnItem5.IsExpand = false;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "buy_volume";
			columnItem5.Text = "Volume";
			columnItem5.ValueFormat = FormatType.Volume;
			columnItem5.Visible = true;
			columnItem5.Width = 15;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.FontColor = Color.LightGray;
			columnItem6.IsExpand = false;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "matvol";
			columnItem6.Text = "Matched";
			columnItem6.ValueFormat = FormatType.Volume;
			columnItem6.Visible = true;
			columnItem6.Width = 15;
			columnItem7.Alignment = StringAlignment.Center;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.FontColor = Color.LightGray;
			columnItem7.IsExpand = false;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "status";
			columnItem7.Text = "Status";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 15;
			columnItem8.Alignment = StringAlignment.Center;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.FontColor = Color.LightGray;
			columnItem8.IsExpand = false;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "time";
			columnItem8.Text = "Time";
			columnItem8.ValueFormat = FormatType.Text;
			columnItem8.Visible = true;
			columnItem8.Width = 13;
			columnItem9.Alignment = StringAlignment.Center;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.FontColor = Color.LightGray;
			columnItem9.IsExpand = false;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "orderno";
			columnItem9.Text = "Order#";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = true;
			columnItem9.Width = 15;
			columnItem10.Alignment = StringAlignment.Near;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.FontColor = Color.LightGray;
			columnItem10.IsExpand = false;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "message";
			columnItem10.Text = "Message";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = true;
			columnItem10.Width = 78;
			columnItem11.Alignment = StringAlignment.Near;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.FontColor = Color.LightGray;
			columnItem11.IsExpand = false;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "tmp_date";
			columnItem11.Text = "None";
			columnItem11.ValueFormat = FormatType.Text;
			columnItem11.Visible = false;
			columnItem11.Width = 10;
			this.gridDcaDetail.Columns.Add(columnItem);
			this.gridDcaDetail.Columns.Add(columnItem2);
			this.gridDcaDetail.Columns.Add(columnItem3);
			this.gridDcaDetail.Columns.Add(columnItem4);
			this.gridDcaDetail.Columns.Add(columnItem5);
			this.gridDcaDetail.Columns.Add(columnItem6);
			this.gridDcaDetail.Columns.Add(columnItem7);
			this.gridDcaDetail.Columns.Add(columnItem8);
			this.gridDcaDetail.Columns.Add(columnItem9);
			this.gridDcaDetail.Columns.Add(columnItem10);
			this.gridDcaDetail.Columns.Add(columnItem11);
			this.gridDcaDetail.CurrentScroll = 0;
			this.gridDcaDetail.FocusItemIndex = -1;
			this.gridDcaDetail.ForeColor = Color.Black;
			this.gridDcaDetail.GridColor = Color.FromArgb(50, 50, 50);
			this.gridDcaDetail.HeaderPctHeight = 100f;
			this.gridDcaDetail.IsAutoRepaint = true;
			this.gridDcaDetail.IsDrawGrid = true;
			this.gridDcaDetail.IsDrawHeader = true;
			this.gridDcaDetail.IsScrollable = true;
			this.gridDcaDetail.Location = new Point(9, 36);
			this.gridDcaDetail.MainColumn = "";
			this.gridDcaDetail.Name = "gridDcaDetail";
			this.gridDcaDetail.Rows = 0;
			this.gridDcaDetail.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.gridDcaDetail.RowSelectType = 3;
			this.gridDcaDetail.Size = new Size(665, 301);
			this.gridDcaDetail.SortColumnName = "";
			this.gridDcaDetail.SortType = SortType.Desc;
			this.gridDcaDetail.TabIndex = 139;
			this.lbDcaRefNo2.AutoSize = true;
			this.lbDcaRefNo2.ForeColor = Color.Cyan;
			this.lbDcaRefNo2.Location = new Point(120, 13);
			this.lbDcaRefNo2.Name = "lbDcaRefNo2";
			this.lbDcaRefNo2.Size = new Size(10, 13);
			this.lbDcaRefNo2.TabIndex = 142;
			this.lbDcaRefNo2.Text = "-";
			this.lbDcaRefNo1.AutoSize = true;
			this.lbDcaRefNo1.ForeColor = Color.LightGray;
			this.lbDcaRefNo1.Location = new Point(73, 13);
			this.lbDcaRefNo1.Name = "lbDcaRefNo1";
			this.lbDcaRefNo1.Size = new Size(44, 13);
			this.lbDcaRefNo1.TabIndex = 141;
			this.lbDcaRefNo1.Text = "Ref No.";
			this.btnReloadDcaDetail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnReloadDcaDetail.BackColor = Color.Transparent;
			this.btnReloadDcaDetail.Cursor = Cursors.Hand;
			this.btnReloadDcaDetail.FlatAppearance.BorderColor = Color.DimGray;
			this.btnReloadDcaDetail.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
			this.btnReloadDcaDetail.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
			this.btnReloadDcaDetail.FlatStyle = FlatStyle.Flat;
			this.btnReloadDcaDetail.ForeColor = Color.LightGray;
			this.btnReloadDcaDetail.Image = Resources.side_noside;
			this.btnReloadDcaDetail.Location = new Point(10, 8);
			this.btnReloadDcaDetail.MaximumSize = new Size(58, 23);
			this.btnReloadDcaDetail.Name = "btnReloadDcaDetail";
			this.btnReloadDcaDetail.Size = new Size(54, 22);
			this.btnReloadDcaDetail.TabIndex = 140;
			this.btnReloadDcaDetail.TabStop = false;
			this.btnReloadDcaDetail.Text = "Reload";
			this.btnReloadDcaDetail.UseVisualStyleBackColor = false;
			this.btnReloadDcaDetail.Click += new EventHandler(this.btnReloadDcaDetail_Click);
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
			this.btnBack.Location = new Point(620, 8);
			this.btnBack.MaximumSize = new Size(58, 23);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new Size(54, 22);
			this.btnBack.TabIndex = 149;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new EventHandler(this.btnBack_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new Size(684, 345);
			base.Controls.Add(this.btnBack);
			base.Controls.Add(this.gridDcaDetail);
			base.Controls.Add(this.lbDcaRefNo2);
			base.Controls.Add(this.lbDcaRefNo1);
			base.Controls.Add(this.btnReloadDcaDetail);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmDcaItemsInfo";
			this.Text = "frmDcaItemsInfo";
			base.Shown += new EventHandler(this.frmDcaItemsInfo_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00064A18 File Offset: 0x00062E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmDcaItemsInfo(long refNo) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._refNo = 0L;
			this._isReloadData = false;
			
			this.InitializeComponent();
			this._refNo = refNo;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00064A68 File Offset: 0x00062E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmDcaItemsInfo_Shown(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.lbDcaRefNo2.Text = this._refNo.ToString();
				this.Reload();
			}
			catch (Exception ex)
			{
				this.ShowError("frmPzItemsInfo_Shown", ex);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00064AD0 File Offset: 0x00062ED0
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
					this._isReloadData = true;
					this.lbDcaRefNo2.Text = this._refNo.ToString();
					ApplicationInfo.WebAlertService.ViewAutoTradeDCAItemsCompleted -= new ViewAutoTradeDCAItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradeDCACompleted);
					ApplicationInfo.WebAlertService.ViewAutoTradeDCAItemsCompleted += new ViewAutoTradeDCAItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradeDCACompleted);
					ApplicationInfo.WebAlertService.ViewAutoTradeDCAItemsAsync(this._refNo);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ReloadDcaDetail", ex);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00064B88 File Offset: 0x00062F88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebAlertService_ViewAutoTradeDCACompleted(object sender, ViewAutoTradeDCAItemsCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.WebAlertService.ViewAutoTradeDCAItemsCompleted -= new ViewAutoTradeDCAItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradeDCACompleted);
				if (e.Error == null)
				{
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(e.Result.ToString(), dataSet);
						if (dataSet != null && dataSet.Tables.Contains("AUTO"))
						{
							this.gridDcaDetail.Rows = dataSet.Tables["AUTO"].Rows.Count;
							int num = 0;
							foreach (DataRow dataRow in dataSet.Tables["AUTO"].Rows)
							{
								RecordItem recordItem = this.gridDcaDetail.Records(num);
								recordItem.Fields("no").Text = dataRow["iTransNo"];
								DateTime dateTime = DateTime.ParseExact(dataRow["sActionDate"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
								recordItem.Fields("date").Text = dateTime.ToString("dd MMM yy");
								recordItem.Fields("budget").Text = dataRow["iBudget"];
								recordItem.Fields("buy_price").Text = dataRow["nmrBuyPrice"];
								recordItem.Fields("buy_volume").Text = dataRow["iBuyVolume"];
								recordItem.Fields("matvol").Text = dataRow["iMatVolume"];
								recordItem.Fields("time").Text = Utilities.GetTime(dataRow["sSentTime"].ToString());
								recordItem.Fields("orderno").Text = dataRow["iOrdNo"];
								recordItem.Fields("status").Text = AutoTradeConstant.GetSatusString(dataRow["sStatus"].ToString());
								recordItem.Fields("message").Text = dataRow["sResult"].ToString();
								recordItem.Fields("date").FontColor = Color.LightGray;
								recordItem.Fields("budget").FontColor = MyColor.UnChgColor;
								recordItem.Fields("buy_price").FontColor = Color.LightGray;
								recordItem.Fields("buy_volume").FontColor = Color.LightGray;
								recordItem.Fields("matvol").FontColor = Color.Cyan;
								recordItem.Fields("time").FontColor = Color.LightGray;
								recordItem.Fields("orderno").FontColor = Color.Orange;
								recordItem.Fields("status").FontColor = Color.Cyan;
								recordItem.Fields("message").FontColor = Color.LightGray;
								num++;
							}
							this.gridDcaDetail.Redraw();
						}
						dataSet.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				this.gridDcaDetail.Redraw();
				this.ShowError("ViewAutoTradeDCACompleted", ex);
			}
			this._isReloadData = false;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00064F7C File Offset: 0x0006337C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnReloadDcaDetail_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Reload();
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00064F94 File Offset: 0x00063394
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00064FC8 File Offset: 0x000633C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnBack_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x04000326 RID: 806
		private IContainer components;

		// Token: 0x04000327 RID: 807
		private ExpandGrid gridDcaDetail;

		// Token: 0x04000328 RID: 808
		private Label lbDcaRefNo2;

		// Token: 0x04000329 RID: 809
		private Label lbDcaRefNo1;

		// Token: 0x0400032A RID: 810
		private Button btnReloadDcaDetail;

		// Token: 0x0400032B RID: 811
		private Button btnBack;

		// Token: 0x0400032C RID: 812
		private long _refNo;

		// Token: 0x0400032D RID: 813
		private bool _isReloadData;
	}
}
