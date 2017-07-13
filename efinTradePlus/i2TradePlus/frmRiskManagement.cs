using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.ITSNetBusinessWS;
using ITSNet.Common.BIZ;
using STIControl;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x02000233 RID: 563
	public class frmRiskManagement : Form
	{
		// Token: 0x0600155A RID: 5466 RVA: 0x0011AE6C File Offset: 0x0011926C
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

		// Token: 0x0600155B RID: 5467 RVA: 0x0011AEBC File Offset: 0x001192BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmRiskManagement));
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
			this.panelAdj = new Panel();
			this.btnCancel = new Button();
			this.btnEditOk = new Button();
			this.tbStopPrice = new TextBox();
			this.label3 = new Label();
			this.cbPeriod = new ComboBox();
			this.label2 = new Label();
			this.cbCondition = new ComboBox();
			this.label1 = new Label();
			this.toolStrip1 = new ToolStrip();
			this.tsbtnSave = new ToolStripButton();
			this.tsbtnEdit = new ToolStripButton();
			this.panel1 = new Panel();
			this.intzaSumReport = new SortGrid();
			this.intzaReport = new SortGrid();
			this.label4 = new Label();
			this.tbMinEquity = new TextBox();
			this.tbTotalLoss = new TextBox();
			this.label5 = new Label();
			this.tbRiskOfEquity = new TextBox();
			this.label6 = new Label();
			this.tbMaxDrawdown = new TextBox();
			this.label7 = new Label();
			this.tbLossLeft = new TextBox();
			this.label8 = new Label();
			this.panelAdj.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panelAdj.Controls.Add(this.btnCancel);
			this.panelAdj.Controls.Add(this.btnEditOk);
			this.panelAdj.Controls.Add(this.tbStopPrice);
			this.panelAdj.Controls.Add(this.label3);
			this.panelAdj.Controls.Add(this.cbPeriod);
			this.panelAdj.Controls.Add(this.label2);
			this.panelAdj.Controls.Add(this.cbCondition);
			this.panelAdj.Controls.Add(this.label1);
			this.panelAdj.Location = new Point(158, 144);
			this.panelAdj.Name = "panelAdj";
			this.panelAdj.Size = new Size(415, 63);
			this.panelAdj.TabIndex = 72;
			this.panelAdj.Visible = false;
			this.btnCancel.BackColor = Color.FromArgb(60, 60, 60);
			this.btnCancel.FlatStyle = FlatStyle.Popup;
			this.btnCancel.ForeColor = Color.LightGray;
			this.btnCancel.Location = new Point(343, 28);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(64, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.btnEditOk.BackColor = Color.FromArgb(60, 60, 60);
			this.btnEditOk.FlatStyle = FlatStyle.Popup;
			this.btnEditOk.ForeColor = Color.WhiteSmoke;
			this.btnEditOk.Location = new Point(273, 28);
			this.btnEditOk.Name = "btnEditOk";
			this.btnEditOk.Size = new Size(64, 23);
			this.btnEditOk.TabIndex = 6;
			this.btnEditOk.Text = "Ok";
			this.btnEditOk.UseVisualStyleBackColor = false;
			this.btnEditOk.Click += new EventHandler(this.btnEditOk_Click);
			this.tbStopPrice.BorderStyle = BorderStyle.FixedSingle;
			this.tbStopPrice.Location = new Point(183, 29);
			this.tbStopPrice.Name = "tbStopPrice";
			this.tbStopPrice.Size = new Size(84, 20);
			this.tbStopPrice.TabIndex = 5;
			this.label3.AutoSize = true;
			this.label3.ForeColor = Color.WhiteSmoke;
			this.label3.Location = new Point(196, 9);
			this.label3.Name = "label3";
			this.label3.Size = new Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Stop Price";
			this.cbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbPeriod.FormattingEnabled = true;
			this.cbPeriod.Location = new Point(101, 28);
			this.cbPeriod.Name = "cbPeriod";
			this.cbPeriod.Size = new Size(74, 21);
			this.cbPeriod.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.ForeColor = Color.WhiteSmoke;
			this.label2.Location = new Point(118, 9);
			this.label2.Name = "label2";
			this.label2.Size = new Size(37, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Period";
			this.cbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbCondition.FormattingEnabled = true;
			this.cbCondition.Location = new Point(8, 28);
			this.cbCondition.Name = "cbCondition";
			this.cbCondition.Size = new Size(84, 21);
			this.cbCondition.TabIndex = 1;
			this.cbCondition.SelectedIndexChanged += new EventHandler(this.cbCondition_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.ForeColor = Color.WhiteSmoke;
			this.label1.Location = new Point(23, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Condition";
			this.toolStrip1.BackColor = Color.FromArgb(35, 35, 35);
			this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.tsbtnSave,
				this.tsbtnEdit
			});
			this.toolStrip1.Location = new Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new Padding(1, 1, 1, 3);
			this.toolStrip1.RenderMode = ToolStripRenderMode.System;
			this.toolStrip1.Size = new Size(758, 27);
			this.toolStrip1.TabIndex = 73;
			this.toolStrip1.Tag = "-1";
			this.toolStrip1.Text = "toolStrip1";
			this.tsbtnSave.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnSave.ForeColor = Color.WhiteSmoke;
			this.tsbtnSave.Image = (Image)componentResourceManager.GetObject("tsbtnSave.Image");
			this.tsbtnSave.ImageTransparentColor = Color.Magenta;
			this.tsbtnSave.Margin = new Padding(5, 1, 5, 2);
			this.tsbtnSave.Name = "tsbtnSave";
			this.tsbtnSave.Size = new Size(51, 20);
			this.tsbtnSave.Text = "Save";
			this.tsbtnSave.Click += new EventHandler(this.tsbtnSave_Click);
			this.tsbtnEdit.Alignment = ToolStripItemAlignment.Right;
			this.tsbtnEdit.Enabled = false;
			this.tsbtnEdit.ForeColor = Color.WhiteSmoke;
			this.tsbtnEdit.Image = (Image)componentResourceManager.GetObject("tsbtnEdit.Image");
			this.tsbtnEdit.ImageTransparentColor = Color.Magenta;
			this.tsbtnEdit.Margin = new Padding(5, 1, 5, 2);
			this.tsbtnEdit.Name = "tsbtnEdit";
			this.tsbtnEdit.Size = new Size(47, 20);
			this.tsbtnEdit.Text = "Edit";
			this.tsbtnEdit.Click += new EventHandler(this.tsbtnEdit_Click);
			this.panel1.BackColor = Color.FromArgb(30, 30, 30);
			this.panel1.Controls.Add(this.tbMaxDrawdown);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.tbLossLeft);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.tbRiskOfEquity);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.tbTotalLoss);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.tbMinEquity);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = DockStyle.Bottom;
			this.panel1.Location = new Point(0, 289);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(758, 85);
			this.panel1.TabIndex = 77;
			this.intzaSumReport.AllowDrop = true;
			this.intzaSumReport.BackColor = Color.FromArgb(25, 25, 25);
			this.intzaSumReport.CanBlink = true;
			this.intzaSumReport.CanDrag = false;
			this.intzaSumReport.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Near;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.White;
			columnItem.MyStyle = FontStyle.Bold;
			columnItem.Name = "text";
			columnItem.Text = "";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 89;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "total";
			columnItem2.Text = "Real P/L";
			columnItem2.ValueFormat = FormatType.Text;
			columnItem2.Visible = true;
			columnItem2.Width = 11;
			this.intzaSumReport.Columns.Add(columnItem);
			this.intzaSumReport.Columns.Add(columnItem2);
			this.intzaSumReport.CurrentScroll = 0;
			this.intzaSumReport.Dock = DockStyle.Bottom;
			this.intzaSumReport.FocusItemIndex = -1;
			this.intzaSumReport.ForeColor = Color.Black;
			this.intzaSumReport.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaSumReport.HeaderPctHeight = 100f;
			this.intzaSumReport.IsAutoRepaint = true;
			this.intzaSumReport.IsDrawFullRow = false;
			this.intzaSumReport.IsDrawGrid = true;
			this.intzaSumReport.IsDrawHeader = false;
			this.intzaSumReport.IsScrollable = true;
			this.intzaSumReport.Location = new Point(0, 266);
			this.intzaSumReport.MainColumn = "";
			this.intzaSumReport.Name = "intzaSumReport";
			this.intzaSumReport.Rows = 1;
			this.intzaSumReport.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaSumReport.RowSelectType = 0;
			this.intzaSumReport.RowsVisible = 1;
			this.intzaSumReport.Size = new Size(758, 23);
			this.intzaSumReport.SortColumnName = "";
			this.intzaSumReport.SortType = SortType.Desc;
			this.intzaSumReport.TabIndex = 78;
			this.intzaReport.AllowDrop = true;
			this.intzaReport.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaReport.CanBlink = true;
			this.intzaReport.CanDrag = false;
			this.intzaReport.CanGetMouseMove = false;
			columnItem3.Alignment = StringAlignment.Near;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "stock";
			columnItem3.Text = "Symbol";
			columnItem3.ValueFormat = FormatType.Symbol;
			columnItem3.Visible = true;
			columnItem3.Width = 12;
			columnItem4.Alignment = StringAlignment.Center;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "ttf";
			columnItem4.Text = "TTF";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 6;
			columnItem5.Alignment = StringAlignment.Far;
			columnItem5.BackColor = Color.FromArgb(64, 64, 64);
			columnItem5.ColumnAlignment = StringAlignment.Center;
			columnItem5.FontColor = Color.LightGray;
			columnItem5.MyStyle = FontStyle.Regular;
			columnItem5.Name = "onhand";
			columnItem5.Text = "OnHand";
			columnItem5.ValueFormat = FormatType.Text;
			columnItem5.Visible = true;
			columnItem5.Width = 10;
			columnItem6.Alignment = StringAlignment.Far;
			columnItem6.BackColor = Color.FromArgb(64, 64, 64);
			columnItem6.ColumnAlignment = StringAlignment.Center;
			columnItem6.FontColor = Color.LightGray;
			columnItem6.MyStyle = FontStyle.Regular;
			columnItem6.Name = "avg";
			columnItem6.Text = "Avg";
			columnItem6.ValueFormat = FormatType.Text;
			columnItem6.Visible = true;
			columnItem6.Width = 8;
			columnItem7.Alignment = StringAlignment.Far;
			columnItem7.BackColor = Color.FromArgb(64, 64, 64);
			columnItem7.ColumnAlignment = StringAlignment.Center;
			columnItem7.FontColor = Color.LightGray;
			columnItem7.MyStyle = FontStyle.Regular;
			columnItem7.Name = "last";
			columnItem7.Text = "Last";
			columnItem7.ValueFormat = FormatType.Text;
			columnItem7.Visible = true;
			columnItem7.Width = 8;
			columnItem8.Alignment = StringAlignment.Far;
			columnItem8.BackColor = Color.FromArgb(64, 64, 64);
			columnItem8.ColumnAlignment = StringAlignment.Center;
			columnItem8.FontColor = Color.LightGray;
			columnItem8.MyStyle = FontStyle.Regular;
			columnItem8.Name = "cost";
			columnItem8.Text = "Cost";
			columnItem8.ValueFormat = FormatType.Text;
			columnItem8.Visible = true;
			columnItem8.Width = 10;
			columnItem9.Alignment = StringAlignment.Far;
			columnItem9.BackColor = Color.FromArgb(64, 64, 64);
			columnItem9.ColumnAlignment = StringAlignment.Center;
			columnItem9.FontColor = Color.LightGray;
			columnItem9.MyStyle = FontStyle.Regular;
			columnItem9.Name = "curr_value";
			columnItem9.Text = "Curr Val";
			columnItem9.ValueFormat = FormatType.Text;
			columnItem9.Visible = true;
			columnItem9.Width = 10;
			columnItem10.Alignment = StringAlignment.Far;
			columnItem10.BackColor = Color.FromArgb(64, 64, 64);
			columnItem10.ColumnAlignment = StringAlignment.Center;
			columnItem10.FontColor = Color.LightGray;
			columnItem10.MyStyle = FontStyle.Regular;
			columnItem10.Name = "condition";
			columnItem10.Text = "Condition";
			columnItem10.ValueFormat = FormatType.Text;
			columnItem10.Visible = true;
			columnItem10.Width = 9;
			columnItem11.Alignment = StringAlignment.Far;
			columnItem11.BackColor = Color.FromArgb(64, 64, 64);
			columnItem11.ColumnAlignment = StringAlignment.Center;
			columnItem11.FontColor = Color.LightGray;
			columnItem11.MyStyle = FontStyle.Regular;
			columnItem11.Name = "period";
			columnItem11.Text = "Period";
			columnItem11.ValueFormat = FormatType.Text;
			columnItem11.Visible = true;
			columnItem11.Width = 8;
			columnItem12.Alignment = StringAlignment.Far;
			columnItem12.BackColor = Color.FromArgb(64, 64, 64);
			columnItem12.ColumnAlignment = StringAlignment.Center;
			columnItem12.FontColor = Color.LightGray;
			columnItem12.MyStyle = FontStyle.Regular;
			columnItem12.Name = "stop_price";
			columnItem12.Text = "Stop Price";
			columnItem12.ValueFormat = FormatType.Text;
			columnItem12.Visible = true;
			columnItem12.Width = 8;
			columnItem13.Alignment = StringAlignment.Far;
			columnItem13.BackColor = Color.FromArgb(64, 64, 64);
			columnItem13.ColumnAlignment = StringAlignment.Center;
			columnItem13.FontColor = Color.LightGray;
			columnItem13.MyStyle = FontStyle.Regular;
			columnItem13.Name = "loss";
			columnItem13.Text = "P/L (Baht)";
			columnItem13.ValueFormat = FormatType.Text;
			columnItem13.Visible = true;
			columnItem13.Width = 11;
			this.intzaReport.Columns.Add(columnItem3);
			this.intzaReport.Columns.Add(columnItem4);
			this.intzaReport.Columns.Add(columnItem5);
			this.intzaReport.Columns.Add(columnItem6);
			this.intzaReport.Columns.Add(columnItem7);
			this.intzaReport.Columns.Add(columnItem8);
			this.intzaReport.Columns.Add(columnItem9);
			this.intzaReport.Columns.Add(columnItem10);
			this.intzaReport.Columns.Add(columnItem11);
			this.intzaReport.Columns.Add(columnItem12);
			this.intzaReport.Columns.Add(columnItem13);
			this.intzaReport.CurrentScroll = 0;
			this.intzaReport.Dock = DockStyle.Fill;
			this.intzaReport.FocusItemIndex = -1;
			this.intzaReport.ForeColor = Color.Black;
			this.intzaReport.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaReport.HeaderPctHeight = 80f;
			this.intzaReport.IsAutoRepaint = true;
			this.intzaReport.IsDrawFullRow = false;
			this.intzaReport.IsDrawGrid = true;
			this.intzaReport.IsDrawHeader = true;
			this.intzaReport.IsScrollable = true;
			this.intzaReport.Location = new Point(0, 27);
			this.intzaReport.MainColumn = "";
			this.intzaReport.Name = "intzaReport";
			this.intzaReport.Rows = 0;
			this.intzaReport.RowSelectColor = Color.FromArgb(60, 60, 60);
			this.intzaReport.RowSelectType = 3;
			this.intzaReport.RowsVisible = 0;
			this.intzaReport.Size = new Size(758, 239);
			this.intzaReport.SortColumnName = "";
			this.intzaReport.SortType = SortType.Desc;
			this.intzaReport.TabIndex = 79;
			this.intzaReport.TableMouseClick += new SortGrid.TableMouseClickEventHandler(this.intzaReport_TableMouseClick);
			this.intzaReport.TableFocusIndexChanged += new SortGrid.TableFocusIndexChangedEventHandler(this.intzaReport_TableFocusIndexChanged);
			this.intzaReport.TableMouseDoubleClick += new SortGrid.TableMouseDoubleClickEventHandler(this.intzaReport_TableMouseDoubleClick);
			this.label4.AutoSize = true;
			this.label4.ForeColor = Color.LightGray;
			this.label4.Location = new Point(21, 10);
			this.label4.Name = "label4";
			this.label4.Size = new Size(114, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Minimum Equity (Baht) ";
			this.tbMinEquity.BorderStyle = BorderStyle.FixedSingle;
			this.tbMinEquity.Location = new Point(138, 7);
			this.tbMinEquity.Name = "tbMinEquity";
			this.tbMinEquity.Size = new Size(84, 20);
			this.tbMinEquity.TabIndex = 1;
			this.tbMinEquity.TextAlign = HorizontalAlignment.Right;
			this.tbMinEquity.TextChanged += new EventHandler(this.tbMinEquity_TextChanged);
			this.tbTotalLoss.BackColor = Color.FromArgb(64, 64, 64);
			this.tbTotalLoss.BorderStyle = BorderStyle.FixedSingle;
			this.tbTotalLoss.ForeColor = Color.WhiteSmoke;
			this.tbTotalLoss.Location = new Point(138, 30);
			this.tbTotalLoss.Name = "tbTotalLoss";
			this.tbTotalLoss.ReadOnly = true;
			this.tbTotalLoss.Size = new Size(84, 20);
			this.tbTotalLoss.TabIndex = 3;
			this.tbTotalLoss.TextAlign = HorizontalAlignment.Right;
			this.label5.AutoSize = true;
			this.label5.ForeColor = Color.LightGray;
			this.label5.Location = new Point(37, 33);
			this.label5.Name = "label5";
			this.label5.Size = new Size(95, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Profit / Loss (Baht)";
			this.tbRiskOfEquity.BackColor = Color.FromArgb(64, 64, 64);
			this.tbRiskOfEquity.BorderStyle = BorderStyle.FixedSingle;
			this.tbRiskOfEquity.ForeColor = Color.WhiteSmoke;
			this.tbRiskOfEquity.Location = new Point(138, 54);
			this.tbRiskOfEquity.Name = "tbRiskOfEquity";
			this.tbRiskOfEquity.ReadOnly = true;
			this.tbRiskOfEquity.Size = new Size(84, 20);
			this.tbRiskOfEquity.TabIndex = 5;
			this.tbRiskOfEquity.TextAlign = HorizontalAlignment.Right;
			this.label6.AutoSize = true;
			this.label6.ForeColor = Color.LightGray;
			this.label6.Location = new Point(46, 57);
			this.label6.Name = "label6";
			this.label6.Size = new Size(86, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Risk of Equity(%)";
			this.tbMaxDrawdown.BackColor = Color.FromArgb(64, 64, 64);
			this.tbMaxDrawdown.BorderStyle = BorderStyle.FixedSingle;
			this.tbMaxDrawdown.ForeColor = Color.WhiteSmoke;
			this.tbMaxDrawdown.Location = new Point(380, 54);
			this.tbMaxDrawdown.Name = "tbMaxDrawdown";
			this.tbMaxDrawdown.ReadOnly = true;
			this.tbMaxDrawdown.Size = new Size(82, 20);
			this.tbMaxDrawdown.TabIndex = 9;
			this.tbMaxDrawdown.TextAlign = HorizontalAlignment.Right;
			this.label7.AutoSize = true;
			this.label7.ForeColor = Color.LightGray;
			this.label7.Location = new Point(247, 57);
			this.label7.Name = "label7";
			this.label7.Size = new Size(127, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Maximum Draw Down(%) ";
			this.tbLossLeft.BackColor = Color.FromArgb(64, 64, 64);
			this.tbLossLeft.BorderStyle = BorderStyle.FixedSingle;
			this.tbLossLeft.ForeColor = Color.WhiteSmoke;
			this.tbLossLeft.Location = new Point(380, 30);
			this.tbLossLeft.Name = "tbLossLeft";
			this.tbLossLeft.ReadOnly = true;
			this.tbLossLeft.Size = new Size(82, 20);
			this.tbLossLeft.TabIndex = 7;
			this.tbLossLeft.TextAlign = HorizontalAlignment.Right;
			this.label8.AutoSize = true;
			this.label8.ForeColor = Color.LightGray;
			this.label8.Location = new Point(296, 33);
			this.label8.Name = "label8";
			this.label8.Size = new Size(81, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Loss Left (Baht)";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(758, 374);
			base.Controls.Add(this.intzaReport);
			base.Controls.Add(this.intzaSumReport);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panelAdj);
			base.Controls.Add(this.toolStrip1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmRiskManagement";
			this.Text = "frmRiskManagement";
			base.Load += new EventHandler(this.frmRiskManagement_Load);
			this.panelAdj.ResumeLayout(false);
			this.panelAdj.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0011C9D8 File Offset: 0x0011ADD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmRiskManagement()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.bgwLoadReport = null;
			this.bgwSave = null;
			this.tdsR1 = null;
			this._custEquity = 0m;
			this._codition = string.Empty;
			this._period = 0;
			this._stopPrice = 0m;
			this._frmConfirm = null;
			base..ctor();
			this.InitializeComponent();
			this.bgwLoadReport = new BackgroundWorker();
			this.bgwLoadReport.WorkerReportsProgress = true;
			this.bgwLoadReport.DoWork += new DoWorkEventHandler(this.bgwLoadReport_DoWork);
			this.bgwLoadReport.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwLoadReport_RunWorkerCompleted);
			this.bgwSave = new BackgroundWorker();
			this.bgwSave.WorkerReportsProgress = true;
			this.bgwSave.DoWork += new DoWorkEventHandler(this.bgwSave_DoWork);
			this.bgwSave.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0011CAE8 File Offset: 0x0011AEE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reload(decimal custEquity)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this._custEquity = (long)custEquity;
				this.tbMinEquity.Text = FormatUtil.VolumeFormat(this._custEquity, true);
				this.tsbtnEdit.Enabled = false;
				this.panelAdj.Visible = false;
				if (!this.bgwLoadReport.IsBusy)
				{
					this.bgwLoadReport.RunWorkerAsync();
				}
				this.btnEditOk.Enabled = true;
			}
			catch (Exception ex)
			{
				this.ShowError("Reload", ex);
			}
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0011CBA4 File Offset: 0x0011AFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetResize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.intzaSumReport.Height = this.intzaSumReport.GetHeightByRows() + 1;
			this.intzaReport.Height = base.Height - this.intzaSumReport.Height - 1;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0011CBFC File Offset: 0x0011AFFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoadReport_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = string.Empty;
				if (ApplicationInfo.IsEquityAccount)
				{
					text = ApplicationInfo.WebMainService.ViewCustomer_RiskManagement(ApplicationInfo.AccInfo.CurrentAccount);
				}
				else
				{
					text = ApplicationInfo.WebMainTfexService.ViewCustomer_RiskManagement(ApplicationInfo.AccInfo.CurrentAccount);
				}
				if (!string.IsNullOrEmpty(text))
				{
					if (this.tdsR1 != null)
					{
						this.tdsR1.Clear();
					}
					this.tdsR1 = new DataSet();
					MyDataHelper.StringToDataSet(text, this.tdsR1);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoadReport_DoWork", ex);
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0011CCCC File Offset: 0x0011B0CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwLoadReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Error == null)
				{
					if (ApplicationInfo.IsEquityAccount)
					{
						this.UpdateToEquityReport(this.tdsR1);
					}
					else
					{
						this.UpdateToTfexReport(this.tdsR1);
					}
					this.intzaReport.Redraw();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwLoadReport_RunWorkerCompleted", ex);
				this.intzaReport.Redraw();
			}
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0011CD70 File Offset: 0x0011B170
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToEquityReport(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				long num = 0L;
				long num2 = 0L;
				decimal num3 = 0m;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				this.intzaReport.Rows = ds.Tables["view_risk"].Rows.Count;
				int num7 = 0;
				this.intzaReport.GetColumn("ttf").Text = "TTF";
				foreach (DataRow dataRow in ds.Tables["view_risk"].Rows)
				{
					RecordItem recordItem = this.intzaReport.Records(num7);
					long.TryParse(dataRow["onhand"].ToString(), out num);
					decimal.TryParse(dataRow["average"].ToString(), out num3);
					decimal.TryParse(dataRow["last_price"].ToString(), out num5);
					long.TryParse(dataRow["sellable"].ToString(), out num2);
					decimal.TryParse(dataRow["Cost"].ToString(), out num4);
					decimal.TryParse(dataRow["Curr_val"].ToString(), out num6);
					if (dataRow["position_type"].ToString() != "B")
					{
						recordItem.Fields("avg").Text = Utilities.PriceFormat(num3, (ApplicationInfo.BrokerId == 11) ? 2 : 4);
						recordItem.Fields("last").Text = Utilities.PriceFormat(num5);
						recordItem.Fields("cost").Text = Utilities.VolumeFormat((long)num4, true);
						recordItem.Fields("curr_value").Text = Utilities.VolumeFormat((long)num6, true);
					}
					recordItem.Fields("stock").Text = dataRow["stock"].ToString();
					recordItem.Fields("stock").Tag = this.GetPositionType(dataRow["position_type"].ToString().Trim());
					recordItem.Fields("onhand").Text = FormatUtil.VolumeFormat(num, true);
					recordItem.Fields("ttf").Text = Utilities.PriceFormat(dataRow["trustee_id"].ToString());
					if (num > 0L)
					{
						recordItem.Fields("condition").Text = dataRow["field_type"].ToString();
						recordItem.Fields("period").Text = FormatUtil.PriceFormat(dataRow["period"].ToString());
						recordItem.Fields("stop_price").Text = FormatUtil.PriceFormat(dataRow["stop_price"].ToString());
						this.calcLoss(recordItem);
					}
					Color fontColor = (num4 < num6) ? MyColor.UpColor : ((num4 > num6) ? MyColor.DownColor : MyColor.UpColor);
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("ttf").FontColor = fontColor;
					recordItem.Fields("onhand").FontColor = fontColor;
					recordItem.Fields("avg").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					recordItem.Fields("cost").FontColor = fontColor;
					recordItem.Fields("curr_value").FontColor = fontColor;
					num7++;
				}
				this.setSummaryTab();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToReport3", ex);
			}
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0011D208 File Offset: 0x0011B608
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateToTfexReport(DataSet ds)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaReport.Rows = ds.Tables[0].Rows.Count;
				int num = 0;
				this.intzaReport.GetColumn("ttf").Text = "Side";
				foreach (DataRow dataRow in ds.Tables[0].Rows)
				{
					long num2 = 0L;
					long value = 0L;
					decimal num3 = 0m;
					decimal num4 = 0m;
					long.TryParse(dataRow["CurrentQty"].ToString(), out num2);
					long.TryParse(dataRow["SellableQty"].ToString(), out value);
					decimal.TryParse(dataRow["CurrentAvgPrice"].ToString(), out num3);
					decimal.TryParse(dataRow["LastPrice"].ToString(), out num4);
					string text = string.Empty;
					if (dataRow["Side"].ToString() == "L")
					{
						text = "Long";
					}
					else if (dataRow["Side"].ToString() == "S")
					{
						text = "Short";
					}
					SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[dataRow["Series"].ToString().Trim()];
					decimal num5 = value * num3 * seriesInformation.ContractSize;
					decimal num6 = value * num3;
					RecordItem recordItem = this.intzaReport.Records(num);
					recordItem.Fields("stock").Text = dataRow["Series"].ToString().Trim();
					recordItem.Fields("ttf").Text = text;
					recordItem.Fields("onhand").Text = Utilities.VolumeFormat(num2, true);
					if (seriesInformation.OrderBookId > 0 && num2 > 0L)
					{
						recordItem.Fields("avg").Text = Utilities.PriceFormat(num3, 4);
						recordItem.Fields("last").Text = Utilities.PriceFormat(num4);
						recordItem.Fields("cost").Text = Utilities.VolumeFormat(num5, true);
						recordItem.Fields("curr_value").Text = Utilities.PriceFormat(num6);
						recordItem.Fields("condition").Text = dataRow["field_type"].ToString();
						recordItem.Fields("period").Text = FormatUtil.PriceFormat(dataRow["period"].ToString());
						recordItem.Fields("stop_price").Text = FormatUtil.PriceFormat(dataRow["stop_price"].ToString());
						this.calcLoss(recordItem);
					}
					Color fontColor = MyColor.UnChgColor;
					if (num5 > 0m && num6 > 0m)
					{
						fontColor = Utilities.ComparePriceColor(num5, num6);
					}
					recordItem.Fields("stock").FontColor = fontColor;
					recordItem.Fields("ttf").FontColor = ((dataRow["Side"].ToString() == "L") ? MyColor.CeilingColor : MyColor.FloorColor);
					recordItem.Fields("onhand").FontColor = fontColor;
					recordItem.Fields("avg").FontColor = fontColor;
					recordItem.Fields("last").FontColor = fontColor;
					recordItem.Fields("cost").FontColor = fontColor;
					recordItem.Fields("curr_value").FontColor = fontColor;
					num++;
				}
				this.setSummaryTab();
			}
			catch (Exception ex)
			{
				this.ShowError("UpdateToTfexReport", ex);
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0011D6D8 File Offset: 0x0011BAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetPositionType(string positionType)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = string.Empty;
			if (ApplicationInfo.SupportFreewill)
			{
				switch (positionType)
				{
				case "2":
					result = "";
					goto IL_161;
				case "4":
					result = "P";
					goto IL_161;
				case "8":
					result = "N";
					goto IL_161;
				case "9":
					result = "E";
					goto IL_161;
				case "12":
					result = "R";
					goto IL_161;
				case "20":
					result = "S";
					goto IL_161;
				case "21":
					result = "p";
					goto IL_161;
				case "22":
					result = "B";
					goto IL_161;
				case "23":
					result = "r";
					goto IL_161;
				}
				result = positionType;
				IL_161:;
			}
			else
			{
				result = positionType;
			}
			return result;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0011D858 File Offset: 0x0011BC58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0011D88C File Offset: 0x0011BC8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnEditOk_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.intzaReport.FocusItemIndex > -1)
				{
					RecordItem recordItem = this.intzaReport.Records(this.intzaReport.FocusItemIndex);
					decimal num;
					decimal.TryParse(this.tbStopPrice.Text, out num);
					int num2;
					int.TryParse(this.cbPeriod.Text, out num2);
					recordItem.Fields("condition").Text = this.cbCondition.Text;
					recordItem.Fields("period").Text = FormatUtil.PriceFormat(num2);
					recordItem.Fields("stop_price").Text = FormatUtil.PriceFormat(num);
					string text = this.cbCondition.Text;
					if (text != null)
					{
						if (text == "SMA" || text == "HHV" || text == "LLV")
						{
							ApplicationInfo.WebMainService.GetStockIndicatorCompleted -= new GetStockIndicatorCompletedEventHandler(this.WebMainService_GetStockIndicatorCompleted);
							ApplicationInfo.WebMainService.GetStockIndicatorCompleted += new GetStockIndicatorCompletedEventHandler(this.WebMainService_GetStockIndicatorCompleted);
							ApplicationInfo.WebMainService.GetStockIndicatorAsync(this.cbCondition.Text, recordItem.Fields("stock").Text.ToString(), num2);
							goto IL_187;
						}
					}
					this.calcLoss(recordItem);
					this.setSummaryTab();
					this.intzaReport.Redraw();
					IL_187:
					this.panelAdj.Visible = false;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("btnSave_Click", ex);
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0011DA68 File Offset: 0x0011BE68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WebMainService_GetStockIndicatorCompleted(object sender, GetStockIndicatorCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.WebMainService.GetStockIndicatorCompleted -= new GetStockIndicatorCompletedEventHandler(this.WebMainService_GetStockIndicatorCompleted);
				if (e.Error == null)
				{
					string[] array = e.Result.ToString().Split(new char[]
					{
						'|'
					});
					if (array.Length == 4)
					{
						for (int i = 0; i < this.intzaReport.Rows; i++)
						{
							RecordItem recordItem = this.intzaReport.Records(i);
							if (recordItem.Fields("stock").Text.ToString() == array[0] && recordItem.Fields("condition").Text.ToString() == array[1] && recordItem.Fields("period").Text.ToString() == array[2])
							{
								decimal num;
								decimal.TryParse(array[3], out num);
								recordItem.Fields("stop_price").Text = FormatUtil.PriceFormat(num);
								this.calcLoss(recordItem);
								this.setSummaryTab();
								this.intzaReport.Redraw();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("WebMainService_GetStockIndicatorCompleted", ex);
			}
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0011DC0C File Offset: 0x0011C00C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void calcLoss(RecordItem rec)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal num;
				decimal.TryParse(rec.Fields("stop_price").Text.ToString().Replace(",", ""), out num);
				long value;
				long.TryParse(rec.Fields("onhand").Text.ToString().Replace(",", ""), out value);
				decimal num2;
				decimal.TryParse(rec.Fields("avg").Text.ToString().Replace(",", ""), out num2);
				if (num != 0m)
				{
					decimal num3;
					if (rec.Fields("condition").Text.ToString() == "HHV")
					{
						num3 = (num2 - num) * value;
					}
					else
					{
						num3 = (num - num2) * value;
					}
					if (!ApplicationInfo.IsEquityAccount)
					{
						SeriesList.SeriesInformation seriesInformation = ApplicationInfo.SeriesInfo[rec.Fields("stock").Text.ToString()];
						num3 *= seriesInformation.ContractSize;
					}
					rec.Fields("loss").Text = FormatUtil.VolumeFormat(num3, true);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("calcLoss", ex);
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0011DDBC File Offset: 0x0011C1BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setSummaryTab()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				decimal num = 0m;
				for (int i = 0; i < this.intzaReport.Rows; i++)
				{
					RecordItem recordItem = this.intzaReport.Records(i);
					decimal d;
					decimal.TryParse(recordItem.Fields("loss").Text.ToString(), out d);
					num += d;
				}
				this.intzaSumReport.Records(0).Fields("text").Text = "Total";
				this.intzaSumReport.Records(0).Fields("total").Text = FormatUtil.VolumeFormat(num, true);
				this.intzaSumReport.Redraw();
				this.tbTotalLoss.Text = FormatUtil.VolumeFormat(num, true);
				decimal num2 = num / this._custEquity * 100m;
				this.tbRiskOfEquity.Text = FormatUtil.PriceFormat(num2, 3, "0");
				decimal d2;
				decimal.TryParse(this.tbMinEquity.Text, out d2);
				decimal num3 = this._custEquity - d2;
				this.tbLossLeft.Text = FormatUtil.PriceFormat(num3, 0, "0");
				decimal num4 = (num3 > 0m) ? (num / num3 * 100m) : 0m;
				this.tbMaxDrawdown.Text = FormatUtil.PriceFormat(num4, 2, "0.00");
			}
			catch (Exception ex)
			{
				this.ShowError("setSummaryTab", ex);
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0011DFA8 File Offset: 0x0011C3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSave_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.intzaReport.Rows > 0)
				{
					List<string> list = new List<string>();
					for (int i = 0; i < this.intzaReport.Rows; i++)
					{
						RecordItem recordItem = this.intzaReport.Records(i);
						int num;
						int.TryParse(recordItem.Fields("ttf").Text.ToString(), out num);
						decimal num2;
						decimal.TryParse(recordItem.Fields("stop_price").Text.ToString().Replace(",", ""), out num2);
						int num3;
						int.TryParse(recordItem.Fields("period").Text.ToString(), out num3);
						string text = string.Empty;
						if (ApplicationInfo.IsEquityAccount)
						{
							text = recordItem.Fields("stock").Tag;
						}
						else if (recordItem.Fields("ttf").Text.ToString().ToLower() == "long")
						{
							text = "L";
						}
						else
						{
							text = "S";
						}
						string item = string.Concat(new object[]
						{
							recordItem.Fields("stock").Text.ToString(),
							"|",
							text,
							"|",
							num,
							"|",
							recordItem.Fields("condition").Text.ToString(),
							"|",
							num3,
							"|",
							num2
						});
						list.Add(item);
					}
					e.Result = ApplicationInfo.WebMainService.ViewCustomer_RiskManagement_SaveValue(ApplicationInfo.AccInfo.CurrentAccount, list.ToArray());
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSave_DoWork", ex);
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0011E1F0 File Offset: 0x0011C5F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (e.Error == null)
				{
					string[] array = e.Result.ToString().Split(new char[]
					{
						'|'
					});
					if (array[0] == "ok")
					{
						this.ShowMessageInFormConfirm("Successfully.", frmOrderFormConfirm.OpenStyle.ShowBox);
					}
					else
					{
						this.ShowMessageInFormConfirm("Fail, " + array[1], frmOrderFormConfirm.OpenStyle.ShowBox);
					}
				}
				else
				{
					this.ShowError("bgwSave_RunWorkerCompleted", e.Error);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwSave_RunWorkerCompleted", ex);
			}
			this.btnEditOk.Enabled = true;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0011E2D0 File Offset: 0x0011C6D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaReport_TableMouseDoubleClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.showItemToEditBox();
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0011E2E8 File Offset: 0x0011C6E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void showItemToEditBox()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.intzaReport.FocusItemIndex > -1)
				{
					RecordItem recordItem = this.intzaReport.Records(this.intzaReport.FocusItemIndex);
					int num;
					int.TryParse(recordItem.Fields("period").Text.ToString(), out num);
					decimal num2;
					decimal.TryParse(recordItem.Fields("stop_price").Text.ToString(), out num2);
					if (ApplicationInfo.IsEquityAccount)
					{
						if (recordItem.Fields("stock").Tag.Trim() == "" || recordItem.Fields("stock").Tag.Trim() == "S")
						{
							this.cbCondition.Items.Clear();
							string text = recordItem.Fields("stock").Tag.Trim();
							if (text != null)
							{
								if (!(text == ""))
								{
									if (text == "S")
									{
										this.cbCondition.Items.Add("LAST");
										this.cbCondition.Items.Add("HHV");
										this.cbCondition.Items.Add("SMA");
									}
								}
								else
								{
									this.cbCondition.Items.Add("LAST");
									this.cbCondition.Items.Add("LLV");
									this.cbCondition.Items.Add("SMA");
								}
							}
						}
						else
						{
							this.ShowMessageInFormConfirm("This stock is not supported, [Position type must be '', S]", frmOrderFormConfirm.OpenStyle.Error);
						}
					}
					else
					{
						long num3;
						long.TryParse(recordItem.Fields("onhand").Text.ToString(), out num3);
						if (num3 <= 0L)
						{
							this.ShowMessageInFormConfirm("You have no stock available, [OnHand is 0]", frmOrderFormConfirm.OpenStyle.Error);
							return;
						}
						this.cbCondition.Items.Clear();
						if (recordItem.Fields("ttf").Text.ToString().ToLower() == "long")
						{
							this.cbCondition.Items.Add("LAST");
							this.cbCondition.Items.Add("LLV");
							this.cbCondition.Items.Add("SMA");
						}
						else if (recordItem.Fields("ttf").Text.ToString().ToLower() == "short")
						{
							this.cbCondition.Items.Add("LAST");
							this.cbCondition.Items.Add("HHV");
							this.cbCondition.Items.Add("SMA");
						}
					}
					this.cbCondition.Text = recordItem.Fields("condition").Text.ToString();
					this.cbPeriod.Text = num.ToString();
					this.tbStopPrice.Text = FormatUtil.PriceFormat(num2);
					this.panelAdj.Location = new Point((base.Width - this.panelAdj.Width) / 2, (base.Height - this.panelAdj.Height) / 2);
					this.panelAdj.Visible = true;
					this.panelAdj.BringToFront();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("editItem", ex);
			}
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0011E6FC File Offset: 0x0011CAFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCancel_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.panelAdj.Visible = !this.panelAdj.Visible;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0011E728 File Offset: 0x0011CB28
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cbCondition_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.cbPeriod.Enabled = (this.cbCondition.Text != "LAST");
			this.tbStopPrice.Enabled = (this.cbCondition.Text == "LAST");
			this.SetValueItems(this.cbPeriod, this.cbCondition.Text);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0011E7A0 File Offset: 0x0011CBA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetValueItems(ComboBox control, string indicatorName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (indicatorName.ToLower().IndexOf("sma") > -1)
				{
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
					control.Items.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetValueItems", ex);
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0011EADC File Offset: 0x0011CEDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmRiskManagement_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.SetResize();
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0011EAF4 File Offset: 0x0011CEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaReport_TableMouseClick(object sender, TableMouseEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.panelAdj.Visible = false;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0011EB14 File Offset: 0x0011CF14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnEdit_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.showItemToEditBox();
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0011EB2C File Offset: 0x0011CF2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void intzaReport_TableFocusIndexChanged(object sender, int Index)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tsbtnEdit.Enabled = (Index > -1);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0011EB50 File Offset: 0x0011CF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tsbtnSave_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.bgwSave.IsBusy)
				{
					this.btnEditOk.Enabled = false;
					this._codition = this.cbCondition.Text;
					if (!(this._codition == "LAST"))
					{
						if (!string.IsNullOrEmpty(this.cbPeriod.Text))
						{
							int.TryParse(this.cbPeriod.Text, out this._period);
						}
					}
					decimal.TryParse(this.tbStopPrice.Text, out this._stopPrice);
					this.bgwSave.RunWorkerAsync();
				}
				else
				{
					this.ShowMessageInFormConfirm("Worker is busy!!!", frmOrderFormConfirm.OpenStyle.Error);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tsbtnSave_Click", ex);
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0011EC54 File Offset: 0x0011D054
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessageInFormConfirm(string message, frmOrderFormConfirm.OpenStyle openStyle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new frmRiskManagement.ShowMessageInFormConfirmCallBack(this.ShowMessageInFormConfirm), new object[]
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

		// Token: 0x06001576 RID: 5494 RVA: 0x0011EE04 File Offset: 0x0011D204
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0011EE18 File Offset: 0x0011D218
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tbMinEquity_TextChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.tbMinEquity.Text.Trim() != string.Empty)
				{
					if (FormatUtil.Isnumeric(this.tbMinEquity.Text))
					{
						try
						{
							decimal num = Convert.ToInt64(this.tbMinEquity.Text.Replace(",", ""));
							this.tbMinEquity.Text = num.ToString("#,###");
							this.tbMinEquity.Select(this.tbMinEquity.Text.Length, 0);
						}
						catch
						{
							this.tbMinEquity.Text = this.tbMinEquity.Text.Substring(0, this.tbMinEquity.Text.Length - 1);
						}
						this.setSummaryTab();
					}
					else
					{
						this.tbMinEquity.Text = this.tbMinEquity.Text.Substring(0, this.tbMinEquity.Text.Length - 1);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("tbMinEquity_TextChanged", ex);
			}
		}

		// Token: 0x04000B14 RID: 2836
		private IContainer components;

		// Token: 0x04000B15 RID: 2837
		private Panel panelAdj;

		// Token: 0x04000B16 RID: 2838
		private ComboBox cbCondition;

		// Token: 0x04000B17 RID: 2839
		private Label label1;

		// Token: 0x04000B18 RID: 2840
		private Button btnCancel;

		// Token: 0x04000B19 RID: 2841
		private Button btnEditOk;

		// Token: 0x04000B1A RID: 2842
		private TextBox tbStopPrice;

		// Token: 0x04000B1B RID: 2843
		private Label label3;

		// Token: 0x04000B1C RID: 2844
		private ComboBox cbPeriod;

		// Token: 0x04000B1D RID: 2845
		private Label label2;

		// Token: 0x04000B1E RID: 2846
		private ToolStrip toolStrip1;

		// Token: 0x04000B1F RID: 2847
		private ToolStripButton tsbtnSave;

		// Token: 0x04000B20 RID: 2848
		private ToolStripButton tsbtnEdit;

		// Token: 0x04000B21 RID: 2849
		private Panel panel1;

		// Token: 0x04000B22 RID: 2850
		private SortGrid intzaSumReport;

		// Token: 0x04000B23 RID: 2851
		private SortGrid intzaReport;

		// Token: 0x04000B24 RID: 2852
		private TextBox tbMinEquity;

		// Token: 0x04000B25 RID: 2853
		private Label label4;

		// Token: 0x04000B26 RID: 2854
		private TextBox tbMaxDrawdown;

		// Token: 0x04000B27 RID: 2855
		private Label label7;

		// Token: 0x04000B28 RID: 2856
		private TextBox tbLossLeft;

		// Token: 0x04000B29 RID: 2857
		private Label label8;

		// Token: 0x04000B2A RID: 2858
		private TextBox tbRiskOfEquity;

		// Token: 0x04000B2B RID: 2859
		private Label label6;

		// Token: 0x04000B2C RID: 2860
		private TextBox tbTotalLoss;

		// Token: 0x04000B2D RID: 2861
		private Label label5;

		// Token: 0x04000B2E RID: 2862
		private BackgroundWorker bgwLoadReport;

		// Token: 0x04000B2F RID: 2863
		private BackgroundWorker bgwSave;

		// Token: 0x04000B30 RID: 2864
		private DataSet tdsR1;

		// Token: 0x04000B31 RID: 2865
		private decimal _custEquity;

		// Token: 0x04000B32 RID: 2866
		private string _codition;

		// Token: 0x04000B33 RID: 2867
		private int _period;

		// Token: 0x04000B34 RID: 2868
		private decimal _stopPrice;

		// Token: 0x04000B35 RID: 2869
		private frmOrderFormConfirm _frmConfirm;

		// Token: 0x02000234 RID: 564
		// (Invoke) Token: 0x06001579 RID: 5497
		private delegate void ShowMessageInFormConfirmCallBack(string message, frmOrderFormConfirm.OpenStyle openStyle);
	}
}
