using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;
using ITSNet.Common.BIZ.AutoTradeMessage;
using STIControl;
using STIControl.ExpandTableGrid;

namespace i2TradePlus
{
	// Token: 0x02000008 RID: 8
	public class frmFTSItemInfo : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x0000701C File Offset: 0x0000541C
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

		// Token: 0x06000039 RID: 57 RVA: 0x0000706C File Offset: 0x0000546C
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
			this.gridSimm = new ExpandGrid();
			this.btnBack = new Button();
			this.lbDcaRefNo2 = new Label();
			this.lbDcaRefNo1 = new Label();
			this.btnReloadDcaDetail = new Button();
			base.SuspendLayout();
			this.gridSimm.AllowDrop = true;
			this.gridSimm.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.gridSimm.BackColor = Color.FromArgb(20, 20, 20);
			this.gridSimm.CanBlink = true;
			this.gridSimm.CanDrag = false;
			this.gridSimm.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.FontColor = Color.LightGray;
			columnItem.IsExpand = false;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "no";
			columnItem.Text = "Step";
			columnItem.ValueFormat = FormatType.RecordNumber;
			columnItem.Visible = true;
			columnItem.Width = 6;
			columnItem2.Alignment = StringAlignment.Near;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.FontColor = Color.LightGray;
			columnItem2.IsExpand = false;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "take_condition";
			columnItem2.Text = "Condition";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 39;
			columnItem3.Alignment = StringAlignment.Near;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.FontColor = Color.LightGray;
			columnItem3.IsExpand = false;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "repurchase_cond";
			columnItem3.Text = "Repurchase";
			columnItem3.ValueFormat = FormatType.Text;
			columnItem3.Visible = true;
			columnItem3.Width = 14;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.FontColor = Color.LightGray;
			columnItem4.IsExpand = false;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "stop_price";
			columnItem4.Text = "Stop Price";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 10;
			columnItem5.Alignment = StringAlignment.Near;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.FontColor = Color.LightGray;
			columnItem5.IsExpand = false;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "onhand";
			columnItem5.Text = "OnHand";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 12;
			columnItem6.Alignment = StringAlignment.Near;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.FontColor = Color.LightGray;
			columnItem6.IsExpand = false;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "sellable";
			columnItem6.Text = "Sellable";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 12;
			columnItem7.Alignment = StringAlignment.Center;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.FontColor = Color.LightGray;
			columnItem7.IsExpand = false;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "active";
			columnItem7.Text = "Active";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 7;
			this.gridSimm.Columns.Add(columnItem);
			this.gridSimm.Columns.Add(columnItem2);
			this.gridSimm.Columns.Add(columnItem3);
			this.gridSimm.Columns.Add(columnItem4);
			this.gridSimm.Columns.Add(columnItem5);
			this.gridSimm.Columns.Add(columnItem6);
			this.gridSimm.Columns.Add(columnItem7);
			this.gridSimm.CurrentScroll = 0;
			this.gridSimm.FocusItemIndex = -1;
			this.gridSimm.ForeColor = Color.Black;
			this.gridSimm.GridColor = Color.FromArgb(50, 50, 50);
			this.gridSimm.HeaderPctHeight = 100f;
			this.gridSimm.IsAutoRepaint = true;
			this.gridSimm.IsDrawGrid = true;
			this.gridSimm.IsDrawHeader = true;
			this.gridSimm.IsScrollable = true;
			this.gridSimm.Location = new Point(12, 37);
			this.gridSimm.MainColumn = "";
			this.gridSimm.Name = "gridSimm";
			this.gridSimm.Rows = 0;
			this.gridSimm.RowSelectColor = Color.FromArgb(50, 50, 50);
			this.gridSimm.RowSelectType = 3;
			this.gridSimm.Size = new Size(792, 352);
			this.gridSimm.SortColumnName = "";
			this.gridSimm.SortType = SortType.Desc;
			this.gridSimm.TabIndex = 138;
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
			this.btnBack.Location = new Point(752, 9);
			this.btnBack.MaximumSize = new Size(58, 23);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new Size(54, 22);
			this.btnBack.TabIndex = 153;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new EventHandler(this.btnBack_Click);
			this.lbDcaRefNo2.AutoSize = true;
			this.lbDcaRefNo2.ForeColor = Color.Cyan;
			this.lbDcaRefNo2.Location = new Point(122, 14);
			this.lbDcaRefNo2.Name = "lbDcaRefNo2";
			this.lbDcaRefNo2.Size = new Size(10, 13);
			this.lbDcaRefNo2.TabIndex = 152;
			this.lbDcaRefNo2.Text = "-";
			this.lbDcaRefNo1.AutoSize = true;
			this.lbDcaRefNo1.ForeColor = Color.LightGray;
			this.lbDcaRefNo1.Location = new Point(75, 14);
			this.lbDcaRefNo1.Name = "lbDcaRefNo1";
			this.lbDcaRefNo1.Size = new Size(44, 13);
			this.lbDcaRefNo1.TabIndex = 151;
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
			this.btnReloadDcaDetail.Location = new Point(12, 9);
			this.btnReloadDcaDetail.MaximumSize = new Size(58, 23);
			this.btnReloadDcaDetail.Name = "btnReloadDcaDetail";
			this.btnReloadDcaDetail.Size = new Size(54, 22);
			this.btnReloadDcaDetail.TabIndex = 150;
			this.btnReloadDcaDetail.TabStop = false;
			this.btnReloadDcaDetail.Text = "Reload";
			this.btnReloadDcaDetail.UseVisualStyleBackColor = false;
			this.btnReloadDcaDetail.Click += new EventHandler(this.btnReloadDcaDetail_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new Size(816, 399);
			base.Controls.Add(this.btnBack);
			base.Controls.Add(this.lbDcaRefNo2);
			base.Controls.Add(this.lbDcaRefNo1);
			base.Controls.Add(this.btnReloadDcaDetail);
			base.Controls.Add(this.gridSimm);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmFTSItemInfo";
			this.Text = "frmFTSInfo";
			base.Shown += new EventHandler(this.frmFTSItemInfo_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00007A90 File Offset: 0x00005E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmFTSItemInfo(long refNo) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this._isReloadData = false;
			
			this.InitializeComponent();
			this._refNo = refNo;
			this.Reload();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00007ADC File Offset: 0x00005EDC
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
					ApplicationInfo.WebAlertService.ViewAutoTradeFTSItemsCompleted -= new ViewAutoTradeFTSItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradeFTSItemsCompleted);
					ApplicationInfo.WebAlertService.ViewAutoTradeFTSItemsCompleted += new ViewAutoTradeFTSItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradeFTSItemsCompleted);
					ApplicationInfo.WebAlertService.ViewAutoTradeFTSItemsAsync(this._refNo);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ReloadDcaDetail", ex);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007B94 File Offset: 0x00005F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebAlertService_ViewAutoTradeFTSItemsCompleted(object sender, ViewAutoTradeFTSItemsCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.WebAlertService.ViewAutoTradeFTSItemsCompleted -= new ViewAutoTradeFTSItemsCompletedEventHandler(this.WebAlertService_ViewAutoTradeFTSItemsCompleted);
				if (e.Error == null)
				{
					using (DataSet dataSet = new DataSet())
					{
						MyDataHelper.StringToDataSet(e.Result.ToString(), dataSet);
						if (dataSet != null && dataSet.Tables.Contains("AUTO"))
						{
							this.gridSimm.Rows = dataSet.Tables["AUTO"].Rows.Count;
							int num = 0;
							foreach (DataRow dataRow in dataSet.Tables["AUTO"].Rows)
							{
								RecordItem recordItem = this.gridSimm.Records(num);
								string text = string.Concat(new string[]
								{
									"Last",
									" ",
									AutoTradeConstant.GetOperatorSymbol(Convert.ToInt32(dataRow["iOperType"].ToString())),
									" ",
									AutoTradeConstant.GetFieldName(dataRow["sFieldType"].ToString())
								});
								int num2;
								int.TryParse(dataRow["iPeriod"].ToString(), out num2);
								decimal num3;
								decimal.TryParse(dataRow["nmrTakeProfitPrice"].ToString(), out num3);
								if (num3 > 0m)
								{
									recordItem.Fields("take_condition").Text = string.Concat(new string[]
									{
										"Profit ratio ",
										dataRow["nmrTakeProfitRatio"].ToString(),
										", ",
										text,
										(num2 > 0) ? ("(" + num2 + ")") : (" " + FormatUtil.PriceFormat(num3) + "@"),
										", Vol  ",
										FormatUtil.VolumeFormat(dataRow["iTakeProfitVol"].ToString(), true),
										" (",
										FormatUtil.VolumeFormat(dataRow["iTakeProfitVolPct"].ToString(), false),
										"%)"
									});
									decimal num4;
									decimal.TryParse(dataRow["nmrRepurchasePrice"].ToString(), out num4);
									if (num4 > 0m)
									{
										recordItem.Fields("repurchase_cond").Text = string.Concat(new string[]
										{
											"Last ",
											AutoTradeConstant.GetOperatorSymbol(Convert.ToInt32(dataRow["iOperType"].ToString())),
											" ",
											FormatUtil.PriceFormat(num4),
											"@"
										});
									}
									else
									{
										recordItem.Fields("repurchase_cond").Text = "-";
									}
								}
								else
								{
									recordItem.Fields("take_condition").Text = string.Concat(new string[]
									{
										"Buy , Last < ",
										FormatUtil.PriceFormat(dataRow["nmrRepurchasePrice"].ToString()),
										"@",
										", Vol  ",
										FormatUtil.VolumeFormat(dataRow["iTakeProfitVol"].ToString(), true)
									});
								}
								recordItem.Fields("stop_price").Text = FormatUtil.PriceFormat(dataRow["nmrStopLoss"].ToString());
								recordItem.Fields("onhand").Text = dataRow["iOnHand"].ToString();
								recordItem.Fields("sellable").Text = dataRow["iSellable"].ToString();
								recordItem.Fields("active").Text = dataRow["sActive"].ToString();
								recordItem.Fields("stop_price").FontColor = MyColor.DownColor;
								recordItem.Fields("onhand").FontColor = Color.Yellow;
								recordItem.Fields("sellable").FontColor = Color.Yellow;
								if (dataRow["sActive"].ToString() == "Y")
								{
									recordItem.Fields("active").FontColor = Color.Cyan;
								}
								else
								{
									recordItem.Fields("active").FontColor = Color.LightGray;
								}
								num++;
							}
							this.gridSimm.Redraw();
						}
						dataSet.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				this.gridSimm.Redraw();
				this.ShowError("ViewAutoTradeFTSItemsCompleted", ex);
			}
			this._isReloadData = false;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00008148 File Offset: 0x00006548
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmFTSItemInfo_Shown(object sender, EventArgs e)
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
				this.ShowError("frmFTSItemInfo_Shown", ex);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000081B0 File Offset: 0x000065B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000081E4 File Offset: 0x000065E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnReloadDcaDetail_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.Reload();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000081FC File Offset: 0x000065FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnBack_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x04000038 RID: 56
		private IContainer components;

		// Token: 0x04000039 RID: 57
		private ExpandGrid gridSimm;

		// Token: 0x0400003A RID: 58
		private Button btnBack;

		// Token: 0x0400003B RID: 59
		private Label lbDcaRefNo2;

		// Token: 0x0400003C RID: 60
		private Label lbDcaRefNo1;

		// Token: 0x0400003D RID: 61
		private Button btnReloadDcaDetail;

		// Token: 0x0400003E RID: 62
		private long _refNo;

		// Token: 0x0400003F RID: 63
		private bool _isReloadData;
	}
}
