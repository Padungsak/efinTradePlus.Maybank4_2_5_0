using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using ITSNet.Common.BIZ;
using STIControl;
using STIControl.CustomGrid;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x02000082 RID: 130
	public class frmViewOrderInfo : Form
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x000683A4 File Offset: 0x000667A4
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

		// Token: 0x0600061B RID: 1563 RVA: 0x000683F4 File Offset: 0x000667F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
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
			ItemGrid itemGrid43 = new ItemGrid();
			ItemGrid itemGrid44 = new ItemGrid();
			ItemGrid itemGrid45 = new ItemGrid();
			ItemGrid itemGrid46 = new ItemGrid();
			ColumnItem columnItem = new ColumnItem();
			ColumnItem columnItem2 = new ColumnItem();
			ColumnItem columnItem3 = new ColumnItem();
			ColumnItem columnItem4 = new ColumnItem();
			this.intzaInfo1 = new IntzaCustomGrid();
			this.intzaInfo2 = new IntzaCustomGrid();
			this.intzaInfo3 = new IntzaCustomGrid();
			this.lbError = new Label();
			this.intzaDeal = new SortGrid();
			base.SuspendLayout();
			this.intzaInfo1.AllowDrop = true;
			this.intzaInfo1.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo1.CanDrag = false;
			this.intzaInfo1.IsAutoRepaint = true;
			this.intzaInfo1.IsDroped = false;
			itemGrid.AdjustFontSize = 0f;
			itemGrid.Alignment = StringAlignment.Near;
			itemGrid.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid.Changed = false;
			itemGrid.FieldType = ItemType.Label2;
			itemGrid.FontColor = Color.White;
			itemGrid.FontStyle = FontStyle.Regular;
			itemGrid.Height = 1f;
			itemGrid.IsBlink = 0;
			itemGrid.Name = "lbOrderNumber";
			itemGrid.Text = "Order No.";
			itemGrid.ValueFormat = FormatType.Text;
			itemGrid.Visible = true;
			itemGrid.Width = 52;
			itemGrid.X = 0;
			itemGrid.Y = 0f;
			itemGrid2.AdjustFontSize = 0f;
			itemGrid2.Alignment = StringAlignment.Far;
			itemGrid2.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid2.Changed = false;
			itemGrid2.FieldType = ItemType.Text;
			itemGrid2.FontColor = Color.Cyan;
			itemGrid2.FontStyle = FontStyle.Regular;
			itemGrid2.Height = 1f;
			itemGrid2.IsBlink = 0;
			itemGrid2.Name = "tbOrderNumber";
			itemGrid2.Text = "10000001";
			itemGrid2.ValueFormat = FormatType.Text;
			itemGrid2.Visible = true;
			itemGrid2.Width = 48;
			itemGrid2.X = 52;
			itemGrid2.Y = 0f;
			itemGrid3.AdjustFontSize = 0f;
			itemGrid3.Alignment = StringAlignment.Near;
			itemGrid3.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid3.Changed = false;
			itemGrid3.FieldType = ItemType.Label2;
			itemGrid3.FontColor = Color.White;
			itemGrid3.FontStyle = FontStyle.Regular;
			itemGrid3.Height = 1f;
			itemGrid3.IsBlink = 0;
			itemGrid3.Name = "lbSide";
			itemGrid3.Text = "Side";
			itemGrid3.ValueFormat = FormatType.Text;
			itemGrid3.Visible = true;
			itemGrid3.Width = 52;
			itemGrid3.X = 0;
			itemGrid3.Y = 1f;
			itemGrid4.AdjustFontSize = 0f;
			itemGrid4.Alignment = StringAlignment.Far;
			itemGrid4.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid4.Changed = false;
			itemGrid4.FieldType = ItemType.Text;
			itemGrid4.FontColor = Color.White;
			itemGrid4.FontStyle = FontStyle.Regular;
			itemGrid4.Height = 1f;
			itemGrid4.IsBlink = 0;
			itemGrid4.Name = "tbSide";
			itemGrid4.Text = "";
			itemGrid4.ValueFormat = FormatType.Text;
			itemGrid4.Visible = true;
			itemGrid4.Width = 48;
			itemGrid4.X = 52;
			itemGrid4.Y = 1f;
			itemGrid5.AdjustFontSize = 0f;
			itemGrid5.Alignment = StringAlignment.Near;
			itemGrid5.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid5.Changed = false;
			itemGrid5.FieldType = ItemType.Label2;
			itemGrid5.FontColor = Color.White;
			itemGrid5.FontStyle = FontStyle.Regular;
			itemGrid5.Height = 1f;
			itemGrid5.IsBlink = 0;
			itemGrid5.Name = "lbStock";
			itemGrid5.Text = "Symbol";
			itemGrid5.ValueFormat = FormatType.Text;
			itemGrid5.Visible = true;
			itemGrid5.Width = 52;
			itemGrid5.X = 0;
			itemGrid5.Y = 2f;
			itemGrid6.AdjustFontSize = 0f;
			itemGrid6.Alignment = StringAlignment.Far;
			itemGrid6.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid6.Changed = false;
			itemGrid6.FieldType = ItemType.Text;
			itemGrid6.FontColor = Color.Yellow;
			itemGrid6.FontStyle = FontStyle.Regular;
			itemGrid6.Height = 1f;
			itemGrid6.IsBlink = 0;
			itemGrid6.Name = "tbStock";
			itemGrid6.Text = "";
			itemGrid6.ValueFormat = FormatType.Text;
			itemGrid6.Visible = true;
			itemGrid6.Width = 48;
			itemGrid6.X = 52;
			itemGrid6.Y = 2f;
			itemGrid7.AdjustFontSize = 0f;
			itemGrid7.Alignment = StringAlignment.Near;
			itemGrid7.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid7.Changed = false;
			itemGrid7.FieldType = ItemType.Label2;
			itemGrid7.FontColor = Color.White;
			itemGrid7.FontStyle = FontStyle.Regular;
			itemGrid7.Height = 1f;
			itemGrid7.IsBlink = 0;
			itemGrid7.Name = "lbVolume";
			itemGrid7.Text = "Volume";
			itemGrid7.ValueFormat = FormatType.Text;
			itemGrid7.Visible = true;
			itemGrid7.Width = 52;
			itemGrid7.X = 0;
			itemGrid7.Y = 3f;
			itemGrid8.AdjustFontSize = 0f;
			itemGrid8.Alignment = StringAlignment.Far;
			itemGrid8.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid8.Changed = false;
			itemGrid8.FieldType = ItemType.Text;
			itemGrid8.FontColor = Color.Yellow;
			itemGrid8.FontStyle = FontStyle.Regular;
			itemGrid8.Height = 1f;
			itemGrid8.IsBlink = 0;
			itemGrid8.Name = "tbVolume";
			itemGrid8.Text = "";
			itemGrid8.ValueFormat = FormatType.Volume;
			itemGrid8.Visible = true;
			itemGrid8.Width = 48;
			itemGrid8.X = 52;
			itemGrid8.Y = 3f;
			itemGrid9.AdjustFontSize = 0f;
			itemGrid9.Alignment = StringAlignment.Near;
			itemGrid9.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid9.Changed = false;
			itemGrid9.FieldType = ItemType.Label2;
			itemGrid9.FontColor = Color.White;
			itemGrid9.FontStyle = FontStyle.Regular;
			itemGrid9.Height = 1f;
			itemGrid9.IsBlink = 0;
			itemGrid9.Name = "lbPrice";
			itemGrid9.Text = "Price";
			itemGrid9.ValueFormat = FormatType.Text;
			itemGrid9.Visible = true;
			itemGrid9.Width = 52;
			itemGrid9.X = 0;
			itemGrid9.Y = 4f;
			itemGrid10.AdjustFontSize = 0f;
			itemGrid10.Alignment = StringAlignment.Far;
			itemGrid10.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid10.Changed = false;
			itemGrid10.FieldType = ItemType.Text;
			itemGrid10.FontColor = Color.Yellow;
			itemGrid10.FontStyle = FontStyle.Regular;
			itemGrid10.Height = 1f;
			itemGrid10.IsBlink = 0;
			itemGrid10.Name = "tbPrice";
			itemGrid10.Text = "";
			itemGrid10.ValueFormat = FormatType.Text;
			itemGrid10.Visible = true;
			itemGrid10.Width = 48;
			itemGrid10.X = 52;
			itemGrid10.Y = 4f;
			itemGrid11.AdjustFontSize = 0f;
			itemGrid11.Alignment = StringAlignment.Near;
			itemGrid11.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid11.Changed = false;
			itemGrid11.FieldType = ItemType.Label2;
			itemGrid11.FontColor = Color.White;
			itemGrid11.FontStyle = FontStyle.Regular;
			itemGrid11.Height = 1f;
			itemGrid11.IsBlink = 0;
			itemGrid11.Name = "lbMatched";
			itemGrid11.Text = "Matched";
			itemGrid11.ValueFormat = FormatType.Text;
			itemGrid11.Visible = true;
			itemGrid11.Width = 52;
			itemGrid11.X = 0;
			itemGrid11.Y = 5f;
			itemGrid12.AdjustFontSize = 0f;
			itemGrid12.Alignment = StringAlignment.Far;
			itemGrid12.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid12.Changed = false;
			itemGrid12.FieldType = ItemType.Text;
			itemGrid12.FontColor = Color.Cyan;
			itemGrid12.FontStyle = FontStyle.Regular;
			itemGrid12.Height = 1f;
			itemGrid12.IsBlink = 0;
			itemGrid12.Name = "tbMatched";
			itemGrid12.Text = "";
			itemGrid12.ValueFormat = FormatType.Volume;
			itemGrid12.Visible = true;
			itemGrid12.Width = 48;
			itemGrid12.X = 52;
			itemGrid12.Y = 5f;
			itemGrid13.AdjustFontSize = 0f;
			itemGrid13.Alignment = StringAlignment.Near;
			itemGrid13.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid13.Changed = false;
			itemGrid13.FieldType = ItemType.Label2;
			itemGrid13.FontColor = Color.White;
			itemGrid13.FontStyle = FontStyle.Regular;
			itemGrid13.Height = 1f;
			itemGrid13.IsBlink = 0;
			itemGrid13.Name = "lbPublished";
			itemGrid13.Text = "Published";
			itemGrid13.ValueFormat = FormatType.Text;
			itemGrid13.Visible = true;
			itemGrid13.Width = 52;
			itemGrid13.X = 0;
			itemGrid13.Y = 6f;
			itemGrid14.AdjustFontSize = 0f;
			itemGrid14.Alignment = StringAlignment.Far;
			itemGrid14.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid14.Changed = false;
			itemGrid14.FieldType = ItemType.Text;
			itemGrid14.FontColor = Color.Cyan;
			itemGrid14.FontStyle = FontStyle.Regular;
			itemGrid14.Height = 1f;
			itemGrid14.IsBlink = 0;
			itemGrid14.Name = "tbPublished";
			itemGrid14.Text = "";
			itemGrid14.ValueFormat = FormatType.Volume;
			itemGrid14.Visible = true;
			itemGrid14.Width = 48;
			itemGrid14.X = 52;
			itemGrid14.Y = 6f;
			itemGrid15.AdjustFontSize = 0f;
			itemGrid15.Alignment = StringAlignment.Near;
			itemGrid15.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid15.Changed = false;
			itemGrid15.FieldType = ItemType.Label2;
			itemGrid15.FontColor = Color.White;
			itemGrid15.FontStyle = FontStyle.Regular;
			itemGrid15.Height = 1f;
			itemGrid15.IsBlink = 0;
			itemGrid15.Name = "lbCondition";
			itemGrid15.Text = "Condition";
			itemGrid15.ValueFormat = FormatType.Text;
			itemGrid15.Visible = true;
			itemGrid15.Width = 52;
			itemGrid15.X = 0;
			itemGrid15.Y = 7f;
			itemGrid16.AdjustFontSize = 0f;
			itemGrid16.Alignment = StringAlignment.Far;
			itemGrid16.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid16.Changed = false;
			itemGrid16.FieldType = ItemType.Text;
			itemGrid16.FontColor = Color.Yellow;
			itemGrid16.FontStyle = FontStyle.Regular;
			itemGrid16.Height = 1f;
			itemGrid16.IsBlink = 0;
			itemGrid16.Name = "tbCondition";
			itemGrid16.Text = "";
			itemGrid16.ValueFormat = FormatType.Text;
			itemGrid16.Visible = true;
			itemGrid16.Width = 48;
			itemGrid16.X = 52;
			itemGrid16.Y = 7f;
			this.intzaInfo1.Items.Add(itemGrid);
			this.intzaInfo1.Items.Add(itemGrid2);
			this.intzaInfo1.Items.Add(itemGrid3);
			this.intzaInfo1.Items.Add(itemGrid4);
			this.intzaInfo1.Items.Add(itemGrid5);
			this.intzaInfo1.Items.Add(itemGrid6);
			this.intzaInfo1.Items.Add(itemGrid7);
			this.intzaInfo1.Items.Add(itemGrid8);
			this.intzaInfo1.Items.Add(itemGrid9);
			this.intzaInfo1.Items.Add(itemGrid10);
			this.intzaInfo1.Items.Add(itemGrid11);
			this.intzaInfo1.Items.Add(itemGrid12);
			this.intzaInfo1.Items.Add(itemGrid13);
			this.intzaInfo1.Items.Add(itemGrid14);
			this.intzaInfo1.Items.Add(itemGrid15);
			this.intzaInfo1.Items.Add(itemGrid16);
			this.intzaInfo1.LineColor = Color.Red;
			this.intzaInfo1.Location = new Point(2, 2);
			this.intzaInfo1.Name = "intzaInfo1";
			this.intzaInfo1.Size = new Size(151, 151);
			this.intzaInfo1.TabIndex = 150;
			this.intzaInfo2.AllowDrop = true;
			this.intzaInfo2.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo2.CanDrag = false;
			this.intzaInfo2.IsAutoRepaint = true;
			this.intzaInfo2.IsDroped = false;
			itemGrid17.AdjustFontSize = 0f;
			itemGrid17.Alignment = StringAlignment.Near;
			itemGrid17.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid17.Changed = false;
			itemGrid17.FieldType = ItemType.Label2;
			itemGrid17.FontColor = Color.White;
			itemGrid17.FontStyle = FontStyle.Regular;
			itemGrid17.Height = 1f;
			itemGrid17.IsBlink = 0;
			itemGrid17.Name = "lbAccount";
			itemGrid17.Text = "Account";
			itemGrid17.ValueFormat = FormatType.Text;
			itemGrid17.Visible = true;
			itemGrid17.Width = 58;
			itemGrid17.X = 0;
			itemGrid17.Y = 0f;
			itemGrid18.AdjustFontSize = -1f;
			itemGrid18.Alignment = StringAlignment.Far;
			itemGrid18.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid18.Changed = false;
			itemGrid18.FieldType = ItemType.Text;
			itemGrid18.FontColor = Color.Cyan;
			itemGrid18.FontStyle = FontStyle.Regular;
			itemGrid18.Height = 1f;
			itemGrid18.IsBlink = 0;
			itemGrid18.Name = "tbAccount";
			itemGrid18.Text = "";
			itemGrid18.ValueFormat = FormatType.Text;
			itemGrid18.Visible = true;
			itemGrid18.Width = 42;
			itemGrid18.X = 58;
			itemGrid18.Y = 0f;
			itemGrid19.AdjustFontSize = 0f;
			itemGrid19.Alignment = StringAlignment.Near;
			itemGrid19.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid19.Changed = false;
			itemGrid19.FieldType = ItemType.Label2;
			itemGrid19.FontColor = Color.White;
			itemGrid19.FontStyle = FontStyle.Regular;
			itemGrid19.Height = 1f;
			itemGrid19.IsBlink = 0;
			itemGrid19.Name = "lbPC";
			itemGrid19.Text = "PC";
			itemGrid19.ValueFormat = FormatType.Text;
			itemGrid19.Visible = true;
			itemGrid19.Width = 58;
			itemGrid19.X = 0;
			itemGrid19.Y = 1f;
			itemGrid20.AdjustFontSize = 0f;
			itemGrid20.Alignment = StringAlignment.Far;
			itemGrid20.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid20.Changed = false;
			itemGrid20.FieldType = ItemType.Text;
			itemGrid20.FontColor = Color.Yellow;
			itemGrid20.FontStyle = FontStyle.Regular;
			itemGrid20.Height = 1f;
			itemGrid20.IsBlink = 0;
			itemGrid20.Name = "tbPC";
			itemGrid20.Text = "";
			itemGrid20.ValueFormat = FormatType.Text;
			itemGrid20.Visible = true;
			itemGrid20.Width = 42;
			itemGrid20.X = 58;
			itemGrid20.Y = 1f;
			itemGrid21.AdjustFontSize = 0f;
			itemGrid21.Alignment = StringAlignment.Near;
			itemGrid21.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid21.Changed = false;
			itemGrid21.FieldType = ItemType.Label2;
			itemGrid21.FontColor = Color.White;
			itemGrid21.FontStyle = FontStyle.Regular;
			itemGrid21.Height = 1f;
			itemGrid21.IsBlink = 0;
			itemGrid21.Name = "lbStatus";
			itemGrid21.Text = "Status";
			itemGrid21.ValueFormat = FormatType.Text;
			itemGrid21.Visible = true;
			itemGrid21.Width = 58;
			itemGrid21.X = 0;
			itemGrid21.Y = 2f;
			itemGrid22.AdjustFontSize = 0f;
			itemGrid22.Alignment = StringAlignment.Far;
			itemGrid22.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid22.Changed = false;
			itemGrid22.FieldType = ItemType.Text;
			itemGrid22.FontColor = Color.Cyan;
			itemGrid22.FontStyle = FontStyle.Regular;
			itemGrid22.Height = 1f;
			itemGrid22.IsBlink = 0;
			itemGrid22.Name = "tbStatus";
			itemGrid22.Text = "";
			itemGrid22.ValueFormat = FormatType.Text;
			itemGrid22.Visible = true;
			itemGrid22.Width = 42;
			itemGrid22.X = 58;
			itemGrid22.Y = 2f;
			itemGrid23.AdjustFontSize = 0f;
			itemGrid23.Alignment = StringAlignment.Near;
			itemGrid23.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid23.Changed = false;
			itemGrid23.FieldType = ItemType.Label2;
			itemGrid23.FontColor = Color.White;
			itemGrid23.FontStyle = FontStyle.Regular;
			itemGrid23.Height = 1f;
			itemGrid23.IsBlink = 0;
			itemGrid23.Name = "lbEntryTime";
			itemGrid23.Text = "Entry Time";
			itemGrid23.ValueFormat = FormatType.Text;
			itemGrid23.Visible = true;
			itemGrid23.Width = 58;
			itemGrid23.X = 0;
			itemGrid23.Y = 3f;
			itemGrid24.AdjustFontSize = 0f;
			itemGrid24.Alignment = StringAlignment.Far;
			itemGrid24.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid24.Changed = false;
			itemGrid24.FieldType = ItemType.Text;
			itemGrid24.FontColor = Color.Yellow;
			itemGrid24.FontStyle = FontStyle.Regular;
			itemGrid24.Height = 1f;
			itemGrid24.IsBlink = 0;
			itemGrid24.Name = "tbEntryTime";
			itemGrid24.Text = "";
			itemGrid24.ValueFormat = FormatType.Text;
			itemGrid24.Visible = true;
			itemGrid24.Width = 42;
			itemGrid24.X = 58;
			itemGrid24.Y = 3f;
			itemGrid25.AdjustFontSize = 0f;
			itemGrid25.Alignment = StringAlignment.Near;
			itemGrid25.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid25.Changed = false;
			itemGrid25.FieldType = ItemType.Label2;
			itemGrid25.FontColor = Color.White;
			itemGrid25.FontStyle = FontStyle.Regular;
			itemGrid25.Height = 1f;
			itemGrid25.IsBlink = 0;
			itemGrid25.Name = "lbQuote";
			itemGrid25.Text = "Quote";
			itemGrid25.ValueFormat = FormatType.Text;
			itemGrid25.Visible = true;
			itemGrid25.Width = 58;
			itemGrid25.X = 0;
			itemGrid25.Y = 4f;
			itemGrid26.AdjustFontSize = 0f;
			itemGrid26.Alignment = StringAlignment.Far;
			itemGrid26.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid26.Changed = false;
			itemGrid26.FieldType = ItemType.Text;
			itemGrid26.FontColor = Color.Yellow;
			itemGrid26.FontStyle = FontStyle.Regular;
			itemGrid26.Height = 1f;
			itemGrid26.IsBlink = 0;
			itemGrid26.Name = "tbQuote";
			itemGrid26.Text = "";
			itemGrid26.ValueFormat = FormatType.Text;
			itemGrid26.Visible = true;
			itemGrid26.Width = 42;
			itemGrid26.X = 58;
			itemGrid26.Y = 4f;
			itemGrid27.AdjustFontSize = 0f;
			itemGrid27.Alignment = StringAlignment.Near;
			itemGrid27.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid27.Changed = false;
			itemGrid27.FieldType = ItemType.Label2;
			itemGrid27.FontColor = Color.White;
			itemGrid27.FontStyle = FontStyle.Regular;
			itemGrid27.Height = 1f;
			itemGrid27.IsBlink = 0;
			itemGrid27.Name = "lbQuoteTime";
			itemGrid27.Text = "Quote Time";
			itemGrid27.ValueFormat = FormatType.Text;
			itemGrid27.Visible = true;
			itemGrid27.Width = 58;
			itemGrid27.X = 0;
			itemGrid27.Y = 5f;
			itemGrid28.AdjustFontSize = 0f;
			itemGrid28.Alignment = StringAlignment.Far;
			itemGrid28.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid28.Changed = false;
			itemGrid28.FieldType = ItemType.Text;
			itemGrid28.FontColor = Color.Yellow;
			itemGrid28.FontStyle = FontStyle.Regular;
			itemGrid28.Height = 1f;
			itemGrid28.IsBlink = 0;
			itemGrid28.Name = "tbQuoteTime";
			itemGrid28.Text = "";
			itemGrid28.ValueFormat = FormatType.Text;
			itemGrid28.Visible = true;
			itemGrid28.Width = 42;
			itemGrid28.X = 58;
			itemGrid28.Y = 5f;
			itemGrid29.AdjustFontSize = 0f;
			itemGrid29.Alignment = StringAlignment.Near;
			itemGrid29.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid29.Changed = false;
			itemGrid29.FieldType = ItemType.Label2;
			itemGrid29.FontColor = Color.White;
			itemGrid29.FontStyle = FontStyle.Regular;
			itemGrid29.Height = 1f;
			itemGrid29.IsBlink = 0;
			itemGrid29.Name = "lbOrigPrice";
			itemGrid29.Text = "Original Price";
			itemGrid29.ValueFormat = FormatType.Text;
			itemGrid29.Visible = true;
			itemGrid29.Width = 58;
			itemGrid29.X = 0;
			itemGrid29.Y = 6f;
			itemGrid30.AdjustFontSize = 0f;
			itemGrid30.Alignment = StringAlignment.Far;
			itemGrid30.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid30.Changed = false;
			itemGrid30.FieldType = ItemType.Text;
			itemGrid30.FontColor = Color.Yellow;
			itemGrid30.FontStyle = FontStyle.Regular;
			itemGrid30.Height = 1f;
			itemGrid30.IsBlink = 0;
			itemGrid30.Name = "tbOrigPrice";
			itemGrid30.Text = "";
			itemGrid30.ValueFormat = FormatType.Text;
			itemGrid30.Visible = true;
			itemGrid30.Width = 42;
			itemGrid30.X = 58;
			itemGrid30.Y = 6f;
			itemGrid31.AdjustFontSize = 0f;
			itemGrid31.Alignment = StringAlignment.Near;
			itemGrid31.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid31.Changed = false;
			itemGrid31.FieldType = ItemType.Label2;
			itemGrid31.FontColor = Color.White;
			itemGrid31.FontStyle = FontStyle.Regular;
			itemGrid31.Height = 1f;
			itemGrid31.IsBlink = 0;
			itemGrid31.Name = "lbEntryId";
			itemGrid31.Text = "Entry Id";
			itemGrid31.ValueFormat = FormatType.Text;
			itemGrid31.Visible = true;
			itemGrid31.Width = 58;
			itemGrid31.X = 0;
			itemGrid31.Y = 7f;
			itemGrid32.AdjustFontSize = 0f;
			itemGrid32.Alignment = StringAlignment.Far;
			itemGrid32.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid32.Changed = false;
			itemGrid32.FieldType = ItemType.Text;
			itemGrid32.FontColor = Color.Yellow;
			itemGrid32.FontStyle = FontStyle.Regular;
			itemGrid32.Height = 1f;
			itemGrid32.IsBlink = 0;
			itemGrid32.Name = "tbEntryId";
			itemGrid32.Text = "";
			itemGrid32.ValueFormat = FormatType.Text;
			itemGrid32.Visible = true;
			itemGrid32.Width = 42;
			itemGrid32.X = 58;
			itemGrid32.Y = 7f;
			this.intzaInfo2.Items.Add(itemGrid17);
			this.intzaInfo2.Items.Add(itemGrid18);
			this.intzaInfo2.Items.Add(itemGrid19);
			this.intzaInfo2.Items.Add(itemGrid20);
			this.intzaInfo2.Items.Add(itemGrid21);
			this.intzaInfo2.Items.Add(itemGrid22);
			this.intzaInfo2.Items.Add(itemGrid23);
			this.intzaInfo2.Items.Add(itemGrid24);
			this.intzaInfo2.Items.Add(itemGrid25);
			this.intzaInfo2.Items.Add(itemGrid26);
			this.intzaInfo2.Items.Add(itemGrid27);
			this.intzaInfo2.Items.Add(itemGrid28);
			this.intzaInfo2.Items.Add(itemGrid29);
			this.intzaInfo2.Items.Add(itemGrid30);
			this.intzaInfo2.Items.Add(itemGrid31);
			this.intzaInfo2.Items.Add(itemGrid32);
			this.intzaInfo2.LineColor = Color.Red;
			this.intzaInfo2.Location = new Point(155, 2);
			this.intzaInfo2.Name = "intzaInfo2";
			this.intzaInfo2.Size = new Size(149, 151);
			this.intzaInfo2.TabIndex = 151;
			this.intzaInfo3.AllowDrop = true;
			this.intzaInfo3.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaInfo3.CanDrag = false;
			this.intzaInfo3.IsAutoRepaint = true;
			this.intzaInfo3.IsDroped = false;
			itemGrid33.AdjustFontSize = 0f;
			itemGrid33.Alignment = StringAlignment.Near;
			itemGrid33.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid33.Changed = false;
			itemGrid33.FieldType = ItemType.Label2;
			itemGrid33.FontColor = Color.White;
			itemGrid33.FontStyle = FontStyle.Regular;
			itemGrid33.Height = 1f;
			itemGrid33.IsBlink = 0;
			itemGrid33.Name = "lbApprover";
			itemGrid33.Text = "Approver";
			itemGrid33.ValueFormat = FormatType.Text;
			itemGrid33.Visible = true;
			itemGrid33.Width = 50;
			itemGrid33.X = 0;
			itemGrid33.Y = 0f;
			itemGrid34.AdjustFontSize = 0f;
			itemGrid34.Alignment = StringAlignment.Far;
			itemGrid34.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid34.Changed = false;
			itemGrid34.FieldType = ItemType.Text;
			itemGrid34.FontColor = Color.Yellow;
			itemGrid34.FontStyle = FontStyle.Regular;
			itemGrid34.Height = 1f;
			itemGrid34.IsBlink = 0;
			itemGrid34.Name = "tbApprover";
			itemGrid34.Text = "";
			itemGrid34.ValueFormat = FormatType.Text;
			itemGrid34.Visible = true;
			itemGrid34.Width = 50;
			itemGrid34.X = 50;
			itemGrid34.Y = 0f;
			itemGrid35.AdjustFontSize = 0f;
			itemGrid35.Alignment = StringAlignment.Near;
			itemGrid35.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid35.Changed = false;
			itemGrid35.FieldType = ItemType.Label2;
			itemGrid35.FontColor = Color.White;
			itemGrid35.FontStyle = FontStyle.Regular;
			itemGrid35.Height = 1f;
			itemGrid35.IsBlink = 0;
			itemGrid35.Name = "lbCanceller";
			itemGrid35.Text = "Canceller";
			itemGrid35.ValueFormat = FormatType.Text;
			itemGrid35.Visible = true;
			itemGrid35.Width = 50;
			itemGrid35.X = 0;
			itemGrid35.Y = 1f;
			itemGrid36.AdjustFontSize = 0f;
			itemGrid36.Alignment = StringAlignment.Far;
			itemGrid36.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid36.Changed = false;
			itemGrid36.FieldType = ItemType.Text;
			itemGrid36.FontColor = Color.Yellow;
			itemGrid36.FontStyle = FontStyle.Regular;
			itemGrid36.Height = 1f;
			itemGrid36.IsBlink = 0;
			itemGrid36.Name = "tbCanceller";
			itemGrid36.Text = "";
			itemGrid36.ValueFormat = FormatType.Text;
			itemGrid36.Visible = true;
			itemGrid36.Width = 50;
			itemGrid36.X = 50;
			itemGrid36.Y = 1f;
			itemGrid37.AdjustFontSize = 0f;
			itemGrid37.Alignment = StringAlignment.Near;
			itemGrid37.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid37.Changed = false;
			itemGrid37.FieldType = ItemType.Label2;
			itemGrid37.FontColor = Color.White;
			itemGrid37.FontStyle = FontStyle.Regular;
			itemGrid37.Height = 1f;
			itemGrid37.IsBlink = 0;
			itemGrid37.Name = "lbCancelTime";
			itemGrid37.Text = "Cancel Time";
			itemGrid37.ValueFormat = FormatType.Text;
			itemGrid37.Visible = true;
			itemGrid37.Width = 50;
			itemGrid37.X = 0;
			itemGrid37.Y = 2f;
			itemGrid38.AdjustFontSize = 0f;
			itemGrid38.Alignment = StringAlignment.Far;
			itemGrid38.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid38.Changed = false;
			itemGrid38.FieldType = ItemType.Text;
			itemGrid38.FontColor = Color.Yellow;
			itemGrid38.FontStyle = FontStyle.Regular;
			itemGrid38.Height = 1f;
			itemGrid38.IsBlink = 0;
			itemGrid38.Name = "tbCancelTime";
			itemGrid38.Text = "";
			itemGrid38.ValueFormat = FormatType.Text;
			itemGrid38.Visible = true;
			itemGrid38.Width = 50;
			itemGrid38.X = 50;
			itemGrid38.Y = 2f;
			itemGrid39.AdjustFontSize = 0f;
			itemGrid39.Alignment = StringAlignment.Near;
			itemGrid39.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid39.Changed = false;
			itemGrid39.FieldType = ItemType.Label2;
			itemGrid39.FontColor = Color.White;
			itemGrid39.FontStyle = FontStyle.Regular;
			itemGrid39.Height = 1f;
			itemGrid39.IsBlink = 0;
			itemGrid39.Name = "lbSource";
			itemGrid39.Text = "Type";
			itemGrid39.ValueFormat = FormatType.Text;
			itemGrid39.Visible = true;
			itemGrid39.Width = 50;
			itemGrid39.X = 0;
			itemGrid39.Y = 3f;
			itemGrid40.AdjustFontSize = 0f;
			itemGrid40.Alignment = StringAlignment.Far;
			itemGrid40.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid40.Changed = false;
			itemGrid40.FieldType = ItemType.Text;
			itemGrid40.FontColor = Color.Yellow;
			itemGrid40.FontStyle = FontStyle.Regular;
			itemGrid40.Height = 1f;
			itemGrid40.IsBlink = 0;
			itemGrid40.Name = "tbSource";
			itemGrid40.Text = "";
			itemGrid40.ValueFormat = FormatType.Text;
			itemGrid40.Visible = true;
			itemGrid40.Width = 50;
			itemGrid40.X = 50;
			itemGrid40.Y = 3f;
			itemGrid41.AdjustFontSize = 0f;
			itemGrid41.Alignment = StringAlignment.Near;
			itemGrid41.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid41.Changed = false;
			itemGrid41.FieldType = ItemType.Label2;
			itemGrid41.FontColor = Color.White;
			itemGrid41.FontStyle = FontStyle.Regular;
			itemGrid41.Height = 1f;
			itemGrid41.IsBlink = 0;
			itemGrid41.Name = "lbTerminal";
			itemGrid41.Text = "Terminal";
			itemGrid41.ValueFormat = FormatType.Text;
			itemGrid41.Visible = true;
			itemGrid41.Width = 50;
			itemGrid41.X = 0;
			itemGrid41.Y = 4f;
			itemGrid42.AdjustFontSize = 0f;
			itemGrid42.Alignment = StringAlignment.Far;
			itemGrid42.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid42.Changed = false;
			itemGrid42.FieldType = ItemType.Text;
			itemGrid42.FontColor = Color.Cyan;
			itemGrid42.FontStyle = FontStyle.Regular;
			itemGrid42.Height = 1f;
			itemGrid42.IsBlink = 0;
			itemGrid42.Name = "tbTerminal";
			itemGrid42.Text = "";
			itemGrid42.ValueFormat = FormatType.Text;
			itemGrid42.Visible = true;
			itemGrid42.Width = 50;
			itemGrid42.X = 50;
			itemGrid42.Y = 4f;
			itemGrid43.AdjustFontSize = 0f;
			itemGrid43.Alignment = StringAlignment.Near;
			itemGrid43.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid43.Changed = false;
			itemGrid43.FieldType = ItemType.Label2;
			itemGrid43.FontColor = Color.White;
			itemGrid43.FontStyle = FontStyle.Regular;
			itemGrid43.Height = 1f;
			itemGrid43.IsBlink = 0;
			itemGrid43.Name = "lbService";
			itemGrid43.Text = "Service";
			itemGrid43.ValueFormat = FormatType.Text;
			itemGrid43.Visible = true;
			itemGrid43.Width = 50;
			itemGrid43.X = 0;
			itemGrid43.Y = 5f;
			itemGrid44.AdjustFontSize = 0f;
			itemGrid44.Alignment = StringAlignment.Far;
			itemGrid44.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid44.Changed = false;
			itemGrid44.FieldType = ItemType.Text;
			itemGrid44.FontColor = Color.Yellow;
			itemGrid44.FontStyle = FontStyle.Regular;
			itemGrid44.Height = 1f;
			itemGrid44.IsBlink = 0;
			itemGrid44.Name = "tbService";
			itemGrid44.Text = "";
			itemGrid44.ValueFormat = FormatType.Text;
			itemGrid44.Visible = true;
			itemGrid44.Width = 50;
			itemGrid44.X = 50;
			itemGrid44.Y = 5f;
			itemGrid45.AdjustFontSize = 0f;
			itemGrid45.Alignment = StringAlignment.Near;
			itemGrid45.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid45.Changed = false;
			itemGrid45.FieldType = ItemType.Label2;
			itemGrid45.FontColor = Color.White;
			itemGrid45.FontStyle = FontStyle.Regular;
			itemGrid45.Height = 1f;
			itemGrid45.IsBlink = 0;
			itemGrid45.Name = "lbTradingChannel";
			itemGrid45.Text = "TradingChannel";
			itemGrid45.ValueFormat = FormatType.Text;
			itemGrid45.Visible = true;
			itemGrid45.Width = 70;
			itemGrid45.X = 0;
			itemGrid45.Y = 6f;
			itemGrid46.AdjustFontSize = 0f;
			itemGrid46.Alignment = StringAlignment.Far;
			itemGrid46.BackColor = Color.FromArgb(30, 30, 30);
			itemGrid46.Changed = false;
			itemGrid46.FieldType = ItemType.Text;
			itemGrid46.FontColor = Color.Yellow;
			itemGrid46.FontStyle = FontStyle.Regular;
			itemGrid46.Height = 1f;
			itemGrid46.IsBlink = 0;
			itemGrid46.Name = "tbTradingChannel";
			itemGrid46.Text = "";
			itemGrid46.ValueFormat = FormatType.Text;
			itemGrid46.Visible = true;
			itemGrid46.Width = 30;
			itemGrid46.X = 70;
			itemGrid46.Y = 6f;
			this.intzaInfo3.Items.Add(itemGrid33);
			this.intzaInfo3.Items.Add(itemGrid34);
			this.intzaInfo3.Items.Add(itemGrid35);
			this.intzaInfo3.Items.Add(itemGrid36);
			this.intzaInfo3.Items.Add(itemGrid37);
			this.intzaInfo3.Items.Add(itemGrid38);
			this.intzaInfo3.Items.Add(itemGrid39);
			this.intzaInfo3.Items.Add(itemGrid40);
			this.intzaInfo3.Items.Add(itemGrid41);
			this.intzaInfo3.Items.Add(itemGrid42);
			this.intzaInfo3.Items.Add(itemGrid43);
			this.intzaInfo3.Items.Add(itemGrid44);
			this.intzaInfo3.Items.Add(itemGrid45);
			this.intzaInfo3.Items.Add(itemGrid46);
			this.intzaInfo3.LineColor = Color.Red;
			this.intzaInfo3.Location = new Point(306, 2);
			this.intzaInfo3.Name = "intzaInfo3";
			this.intzaInfo3.Size = new Size(161, 151);
			this.intzaInfo3.TabIndex = 152;
			this.lbError.BackColor = Color.FromArgb(30, 30, 30);
			this.lbError.ForeColor = Color.Yellow;
			this.lbError.Location = new Point(528, 106);
			this.lbError.Name = "lbError";
			this.lbError.Size = new Size(88, 31);
			this.lbError.TabIndex = 154;
			this.intzaDeal.AllowDrop = true;
			this.intzaDeal.BackColor = Color.FromArgb(30, 30, 30);
			this.intzaDeal.CanBlink = true;
			this.intzaDeal.CanDrag = false;
			this.intzaDeal.CanGetMouseMove = false;
			columnItem.Alignment = StringAlignment.Center;
			columnItem.BackColor = Color.FromArgb(64, 64, 64);
			columnItem.ColumnAlignment = StringAlignment.Center;
			columnItem.FontColor = Color.LightGray;
			columnItem.MyStyle = FontStyle.Regular;
			columnItem.Name = "confirm";
			columnItem.Text = "Confirm";
			columnItem.ValueFormat = FormatType.Text;
			columnItem.Visible = true;
			columnItem.Width = 25;
			columnItem2.Alignment = StringAlignment.Far;
			columnItem2.BackColor = Color.FromArgb(64, 64, 64);
			columnItem2.ColumnAlignment = StringAlignment.Center;
			columnItem2.FontColor = Color.LightGray;
			columnItem2.MyStyle = FontStyle.Regular;
			columnItem2.Name = "volume";
			columnItem2.Text = "Volume";
			columnItem2.ValueFormat = FormatType.Volume;
			columnItem2.Visible = true;
			columnItem2.Width = 30;
			columnItem3.Alignment = StringAlignment.Far;
			columnItem3.BackColor = Color.FromArgb(64, 64, 64);
			columnItem3.ColumnAlignment = StringAlignment.Center;
			columnItem3.FontColor = Color.LightGray;
			columnItem3.MyStyle = FontStyle.Regular;
			columnItem3.Name = "price";
			columnItem3.Text = "Price";
			columnItem3.ValueFormat = FormatType.Price;
			columnItem3.Visible = true;
			columnItem3.Width = 21;
			columnItem4.Alignment = StringAlignment.Far;
			columnItem4.BackColor = Color.FromArgb(64, 64, 64);
			columnItem4.ColumnAlignment = StringAlignment.Center;
			columnItem4.FontColor = Color.LightGray;
			columnItem4.MyStyle = FontStyle.Regular;
			columnItem4.Name = "time";
			columnItem4.Text = "Time";
			columnItem4.ValueFormat = FormatType.Text;
			columnItem4.Visible = true;
			columnItem4.Width = 24;
			this.intzaDeal.Columns.Add(columnItem);
			this.intzaDeal.Columns.Add(columnItem2);
			this.intzaDeal.Columns.Add(columnItem3);
			this.intzaDeal.Columns.Add(columnItem4);
			this.intzaDeal.CurrentScroll = 0;
			this.intzaDeal.FocusItemIndex = -1;
			this.intzaDeal.ForeColor = Color.Black;
			this.intzaDeal.GridColor = Color.FromArgb(45, 45, 45);
			this.intzaDeal.HeaderPctHeight = 80f;
			this.intzaDeal.IsAutoRepaint = true;
			this.intzaDeal.IsDrawFullRow = false;
			this.intzaDeal.IsDrawGrid = true;
			this.intzaDeal.IsDrawHeader = true;
			this.intzaDeal.IsScrollable = true;
			this.intzaDeal.Location = new Point(469, 2);
			this.intzaDeal.MainColumn = "";
			this.intzaDeal.Name = "intzaDeal";
			this.intzaDeal.Rows = 0;
			this.intzaDeal.RowSelectColor = Color.FromArgb(95, 158, 160);
			this.intzaDeal.RowSelectType = 0;
			this.intzaDeal.RowsVisible = 0;
			this.intzaDeal.Size = new Size(233, 151);
			this.intzaDeal.SortColumnName = "";
			this.intzaDeal.SortType = SortType.Desc;
			this.intzaDeal.TabIndex = 155;
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new Size(706, 155);
			base.Controls.Add(this.intzaDeal);
			base.Controls.Add(this.lbError);
			base.Controls.Add(this.intzaInfo3);
			base.Controls.Add(this.intzaInfo2);
			base.Controls.Add(this.intzaInfo1);
			this.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.Name = "frmViewOrderInfo";
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Deal Data";
			base.Load += new EventHandler(this.frmViewOrderInfo_Load);
			base.Shown += new EventHandler(this.frmViewOrderInfo_Shown);
			base.Enter += new EventHandler(this.frmViewOrderInfo_Enter);
			base.Leave += new EventHandler(this.frmViewOrderInfo_Leave);
			base.KeyDown += new KeyEventHandler(this.frmViewOrderInfo_KeyDown);
			base.ResumeLayout(false);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0006B0A4 File Offset: 0x000694A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmViewOrderInfo(bool isHistory, string sendDate, long orderNumber, int yPosition, string isFwAfterClose) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.currentTop = 50;
			this.orderNumber = 0L;
			this.sendDate = string.Empty;
			this.selDbType = 0;
			this.pageNo = 1;
			this.bgwReloadData = new BackgroundWorker();
			this.tdsOrderTrans = null;
			this.isHistory = false;
			this.yPosition = 0;
			this._isFwAfterClose = "N";
			
			try
			{
				this.InitializeComponent();
				this.isHistory = isHistory;
				this.yPosition = yPosition;
				this.sendDate = sendDate;
				this.orderNumber = orderNumber;
				this._isFwAfterClose = isFwAfterClose;
				this.bgwReloadData.WorkerReportsProgress = true;
				this.bgwReloadData.DoWork += new DoWorkEventHandler(this.bgwReloadData_DoWork);
				this.bgwReloadData.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwReloadData_RunWorkerCompleted);
				if (ApplicationInfo.SupportFreewill)
				{
					this.intzaInfo3.Item("lbService").Text = "";
					this.intzaInfo3.Item("lbTradingChannel").Text = "";
				}
				if (ApplicationInfo.BrokerId == 88)
				{
					this.intzaInfo3.Item("lbTradingChannel").Text = "";
				}
			}
			catch (Exception ex)
			{
				this.ShowError("frmViewOrderInfo", ex);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0006B238 File Offset: 0x00069638
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initial(string sendDate, long orderNumber, string isFwAfterClose)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.sendDate = sendDate;
			this.orderNumber = orderNumber;
			this._isFwAfterClose = isFwAfterClose;
			if (this.bgwReloadData != null)
			{
				if (!this.bgwReloadData.IsBusy)
				{
					this.bgwReloadData.RunWorkerAsync();
				}
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0006B29C File Offset: 0x0006969C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfo_Shown(object sender, EventArgs e)
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

		// Token: 0x0600061F RID: 1567 RVA: 0x0006B2D8 File Offset: 0x000696D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.IsDisposed)
			{
				try
				{
					if (this.orderNumber > 0L)
					{
						if (this.tdsOrderTrans == null)
						{
							this.tdsOrderTrans = new DataSet();
						}
						int startRow = (this.pageNo - 1) * this.currentTop + 1;
						string text = string.Empty;
						if (this.isHistory)
						{
							text = ApplicationInfo.WebOrderService.ViewOrderDealDataHistory(this.sendDate, this.orderNumber, startRow, this.currentTop);
						}
						else if (this._isFwAfterClose == "Y")
						{
							text = ApplicationInfo.WebOrderService.ViewOrderInfo_AfterCloseFw(this.orderNumber);
						}
						else
						{
							text = ApplicationInfo.WebOrderService.ViewOrderDealData(this.sendDate, this.orderNumber, startRow, this.currentTop, this.selDbType);
						}
						this.tdsOrderTrans.Clear();
						if (!string.IsNullOrEmpty(text))
						{
							MyDataHelper.StringToDataSet(text, this.tdsOrderTrans);
						}
					}
				}
				catch (Exception ex)
				{
					this.ShowError("bgwReloadData_DoWork", ex);
				}
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0006B440 File Offset: 0x00069840
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwReloadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!base.IsDisposed)
				{
					this.ShowInfo();
					this.tdsOrderTrans.Clear();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("bgwReloadData_RunWorkerCompleted", ex);
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0006B4B4 File Offset: 0x000698B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.intzaInfo1.BeginUpdate();
				this.intzaInfo1.ClearAllText();
				this.intzaInfo2.BeginUpdate();
				this.intzaInfo2.ClearAllText();
				this.intzaInfo3.BeginUpdate();
				this.intzaInfo3.ClearAllText();
				long num = 0L;
				long num2 = 0L;
				long matchedVolume = 0L;
				long publicVolume = 0L;
				long volume = 0L;
				if (this.tdsOrderTrans != null && this.tdsOrderTrans.Tables.Contains("ORDER_INFO") && this.tdsOrderTrans.Tables["ORDER_INFO"].Rows.Count > 0)
				{
					DataRow dataRow = this.tdsOrderTrans.Tables["ORDER_INFO"].Rows[0];
					long.TryParse(dataRow["order_number"].ToString(), out num);
					this.intzaInfo1.Item("tbOrderNumber").Text = num.ToString();
					this.intzaInfo1.Item("tbSide").Text = dataRow["side"].ToString();
					this.intzaInfo1.Item("tbStock").Text = dataRow["stock"].ToString();
					this.intzaInfo1.Item("tbVolume").Text = dataRow["volume"].ToString();
					long.TryParse(dataRow["matched_value"].ToString(), out num2);
					long.TryParse(dataRow["matched_volume"].ToString(), out matchedVolume);
					this.intzaInfo1.Item("tbMatched").Text = matchedVolume.ToString();
					string text = Utilities.PriceFormat(dataRow["price_to_set"].ToString().Trim());
					string text2 = Utilities.PriceFormat(dataRow["sOPrice"].ToString().Trim());
					if (ApplicationInfo.SupportFreewill)
					{
						if (this._isFwAfterClose == "Y")
						{
							string text3 = text2;
							if (text3 != null)
							{
								if (text3 == "A")
								{
									text2 = "ATO";
									goto IL_2FB;
								}
								if (text3 == "C")
								{
									text2 = "ATC";
									goto IL_2FB;
								}
								if (text3 == "M")
								{
									text2 = "MP";
									goto IL_2FB;
								}
								if (text3 == "K")
								{
									text2 = "MO";
									goto IL_2FB;
								}
								if (text3 == "L")
								{
									text2 = "ML";
									goto IL_2FB;
								}
							}
							text2 = Utilities.PriceFormat(text2.Trim());
							IL_2FB:
							text = text2;
						}
						else
						{
							text = Utilities.ConvertPrice(text);
							text2 = Utilities.ConvertPrice(text2);
						}
					}
					this.intzaInfo1.Item("tbPrice").Text = text;
					long.TryParse(dataRow["pub_vol"].ToString(), out publicVolume);
					long.TryParse(dataRow["volume"].ToString(), out volume);
					this.intzaInfo1.Item("tbPublished").Text = FormatUtil.VolumeFormat(Utilities.GetPublishedVolumeDisplay(volume, publicVolume, matchedVolume, dataRow["status"].ToString()), true);
					if (dataRow["condition"].ToString() == "I")
					{
						this.intzaInfo1.Item("tbCondition").Text = "IOC";
					}
					else if (dataRow["condition"].ToString() == "F")
					{
						this.intzaInfo1.Item("tbCondition").Text = "FOK";
					}
					this.intzaInfo2.Item("tbAccount").Text = dataRow["cust_acc_id"].ToString();
					this.intzaInfo2.Item("tbPC").Text = dataRow["acc_type"].ToString();
					string text4 = string.Empty;
					if (dataRow["approve_trader_credit_entry"].ToString().Trim() != string.Empty)
					{
						text4 = dataRow["status"].ToString() + "A";
					}
					else
					{
						text4 = dataRow["status"].ToString().Trim();
					}
					this.intzaInfo2.Item("tbStatus").Text = text4;
					this.intzaInfo2.Item("tbEntryTime").Text = Utilities.GetTime(dataRow["order_time"].ToString().Trim());
					string text5 = dataRow["quote"].ToString().Trim();
					this.intzaInfo2.Item("tbQuote").Text = text5;
					this.intzaInfo2.Item("tbQuoteTime").Text = (ApplicationInfo.SupportFreewill ? "-" : Utilities.GetTime(dataRow["quote_time"].ToString().Trim()));
					this.intzaInfo2.Item("tbOrigPrice").Text = text2;
					this.intzaInfo2.Item("tbEntryId").Text = dataRow["entry_id"].ToString();
					this.intzaInfo3.Item("tbApprover").Text = (ApplicationInfo.SupportFreewill ? "-" : dataRow["approve_trader_credit_entry"].ToString());
					this.intzaInfo3.Item("tbCanceller").Text = dataRow["cancel_entry"].ToString();
					this.intzaInfo3.Item("tbCancelTime").Text = Utilities.GetTime(dataRow["cancel_time"].ToString().Trim());
					if (ApplicationInfo.BrokerId == 88)
					{
						string text6 = dataRow["location_type"].ToString();
						string text3 = text6;
						switch (text3)
						{
						case "S":
							text6 = "Plus";
							break;
						case "M":
							text6 = "AndroidM";
							break;
						case "T":
							text6 = "AndroidT";
							break;
						case "X":
							text6 = "iPhone";
							break;
						case "P":
							text6 = "iPad";
							break;
						case "W":
							text6 = "WinP";
							break;
						case "C":
							text6 = "Classic";
							break;
						}
						this.intzaInfo3.Item("tbTerminal").Text = text6;
						string text7 = dataRow["branch_id"].ToString();
						text3 = text7;
						if (text3 != null)
						{
							if (!(text3 == "I"))
							{
								if (text3 == "D")
								{
									text7 = "Dealer";
								}
							}
							else
							{
								text7 = "Internet";
							}
						}
						this.intzaInfo3.Item("tbService").Text = text7;
						string text8 = dataRow["command_type"].ToString();
						text3 = text8;
						if (text3 != null)
						{
							if (!(text3 == "S"))
							{
								if (!(text3 == "C"))
								{
									if (text3 == "A")
									{
										text8 = "Approve";
									}
								}
								else
								{
									text8 = "After Close";
								}
							}
							else
							{
								text8 = "Normal";
							}
						}
						this.intzaInfo3.Item("tbSource").Text = text8;
					}
					else
					{
						string text6 = dataRow["location_type"].ToString();
						if (text6 == "A")
						{
							this.intzaInfo3.Item("tbTerminal").Text = "Normal";
						}
						else if (text6 == "D")
						{
							this.intzaInfo3.Item("tbTerminal").Text = (ApplicationInfo.SupportFreewill ? "Dealer" : "Dump");
						}
						else if (text6 == "M")
						{
							this.intzaInfo3.Item("tbTerminal").Text = "Market Works";
						}
						else if (text6 == "R")
						{
							this.intzaInfo3.Item("tbTerminal").Text = "Remote Investor";
						}
						else if (text6 == "W")
						{
							this.intzaInfo3.Item("tbTerminal").Text = "Web";
						}
						else if (text6 == "I")
						{
							this.intzaInfo3.Item("tbTerminal").Text = "Internet";
						}
						else if (text6 == "DD")
						{
							this.intzaInfo3.Item("tbTerminal").Text = "Dealer";
						}
						else if (text6 == "V")
						{
							this.intzaInfo3.Item("tbTerminal").Text = "VIP";
						}
						this.intzaInfo3.Item("tbService").Text = dataRow["branch_id"].ToString();
						if (ApplicationInfo.SupportFreewill)
						{
							if (this._isFwAfterClose == "Y")
							{
								this.intzaInfo3.Item("tbSource").Text = "After close";
							}
							else
							{
								this.intzaInfo3.Item("tbSource").Text = "Normal";
							}
						}
						else
						{
							string text8 = dataRow["command_type"].ToString();
							if (text8 == "L")
							{
								this.intzaInfo3.Item("tbSource").Text = "Normal";
							}
							else if (text8 == "F")
							{
								this.intzaInfo3.Item("tbSource").Text = "After close";
							}
							else if (text8 == "M")
							{
								this.intzaInfo3.Item("tbSource").Text = "Market Price";
							}
							else if (text8 == "A")
							{
								this.intzaInfo3.Item("tbSource").Text = "ATO/ATC";
							}
							else if (text8 == "P")
							{
								this.intzaInfo3.Item("tbSource").Text = "Put-Through";
							}
							else if (text8 == "D")
							{
								this.intzaInfo3.Item("tbSource").Text = "DMA";
							}
							else
							{
								this.intzaInfo3.Item("tbSource").Text = dataRow["command_type"].ToString();
							}
						}
					}
					this.intzaInfo3.Item("tbTradingChannel").Text = dataRow["sTradingChannel"].ToString();
					Color fontColor = MyColor.UnChgColor;
					if (dataRow["side"].ToString() == "B")
					{
						fontColor = Color.Lime;
					}
					else if (dataRow["side"].ToString() == "S")
					{
						fontColor = Color.Red;
					}
					this.intzaInfo1.Item("tbSide").FontColor = fontColor;
					if (ApplicationInfo.SupportFreewill)
					{
						if ((text4 == "R" || text4 == "RA" || text4 == "XA") && this.tdsOrderTrans.Tables.Contains("REJECT") && this.tdsOrderTrans.Tables["REJECT"].Rows.Count > 0)
						{
							int num4;
							int.TryParse(this.tdsOrderTrans.Tables["REJECT"].Rows[0]["iRejCode"].ToString(), out num4);
							if (num4 > 0)
							{
								this.lbError.Bounds = this.intzaDeal.Bounds;
								this.lbError.Text = string.Concat(new object[]
								{
									"Reject Code : ",
									num4,
									"\nReject Desc :\n  ",
									this.tdsOrderTrans.Tables["REJECT"].Rows[0]["sDesc"].ToString().Trim()
								});
								this.lbError.Show();
								this.intzaDeal.Hide();
							}
							else
							{
								this.intzaDeal.Show();
								this.lbError.Hide();
							}
						}
						else
						{
							this.intzaDeal.Show();
							this.lbError.Hide();
						}
					}
					else if ((text4 == "R" || text4 == "RA") && this.tdsOrderTrans.Tables.Contains("REJECT") && this.tdsOrderTrans.Tables["REJECT"].Rows.Count > 0)
					{
						this.lbError.Bounds = this.intzaDeal.Bounds;
						this.lbError.Text = "Reject Code : " + this.tdsOrderTrans.Tables["REJECT"].Rows[0]["iRejCode"].ToString() + "\nReject Desc :\n  " + this.tdsOrderTrans.Tables["REJECT"].Rows[0]["sDesc"].ToString();
						this.lbError.Show();
						this.intzaDeal.Hide();
					}
					else
					{
						this.intzaDeal.Show();
						this.lbError.Hide();
					}
					try
					{
						this.intzaDeal.BeginUpdate();
						if (this.tdsOrderTrans.Tables.Contains("DEAL_CONFIRM"))
						{
							this.intzaDeal.Rows = this.tdsOrderTrans.Tables["DEAL_CONFIRM"].Rows.Count;
							for (int i = 0; i < this.tdsOrderTrans.Tables["DEAL_CONFIRM"].Rows.Count; i++)
							{
								DataRow dataRow2 = this.tdsOrderTrans.Tables["DEAL_CONFIRM"].Rows[i];
								RecordItem recordItem = this.intzaDeal.Records(i);
								recordItem.Fields("confirm").Text = dataRow2["confirm_number"].ToString();
								recordItem.Fields("volume").Text = dataRow2["volume"].ToString();
								recordItem.Fields("price").Text = dataRow2["price"].ToString();
								recordItem.Fields("time").Text = Utilities.GetTime(dataRow2["match_time"].ToString().Trim());
							}
						}
						else
						{
							this.intzaDeal.Rows = 0;
						}
						this.intzaDeal.Redraw();
					}
					catch (Exception ex)
					{
						this.ShowError("LoadDealConfirmData", ex);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ShowInfo", ex);
			}
			finally
			{
				this.intzaInfo1.Redraw();
				this.intzaInfo2.Redraw();
				this.intzaInfo3.Redraw();
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0006C768 File Offset: 0x0006AB68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnCloseOrderInfo_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Close();
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0006C780 File Offset: 0x0006AB80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0006C7B4 File Offset: 0x0006ABB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnPreviousPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.pageNo - 1 > 0)
			{
				this.pageNo--;
				if (!this.bgwReloadData.IsBusy)
				{
					this.bgwReloadData.RunWorkerAsync();
				}
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0006C814 File Offset: 0x0006AC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btmFirstPage_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.pageNo > 1)
			{
				this.pageNo = 1;
				if (!this.bgwReloadData.IsBusy)
				{
					this.bgwReloadData.RunWorkerAsync();
				}
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0006C86C File Offset: 0x0006AC6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfo_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.Width > base.Parent.ClientSize.Width)
			{
				base.Width = base.Parent.ClientSize.Width;
			}
			base.Height = this.intzaInfo1.MyBottom + SystemInformation.CaptionHeight + SystemInformation.FixedFrameBorderSize.Height;
			this.intzaInfo1.SetBounds(2, 2, (int)((double)base.Width * 0.19), base.ClientSize.Height - 4);
			this.intzaInfo2.SetBounds(this.intzaInfo1.Right + 2, 2, (int)((double)base.Width * 0.2), this.intzaInfo1.Height);
			this.intzaInfo3.SetBounds(this.intzaInfo2.Right + 2, 2, (int)((double)base.Width * 0.22), this.intzaInfo1.Height);
			this.intzaDeal.SetBounds(this.intzaInfo3.Right + 2, 2, base.ClientSize.Width - this.intzaInfo3.Right - 4, base.ClientSize.Height - 4);
			if (this.yPosition > 0)
			{
				base.Location = new Point(base.Parent.Width - base.Width - 15, this.yPosition - base.Height);
			}
			else
			{
				base.Location = new Point(1, (base.Parent.Height - base.Height) / 2);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0006CA38 File Offset: 0x0006AE38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfo_Enter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.Text = "Deal Data [Press Enter for Close]";
			}
			catch (Exception ex)
			{
				this.ShowError("frmViewOrderInfo_Enter", ex);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0006CA90 File Offset: 0x0006AE90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfo_Leave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.Text = "Deal Data";
			}
			catch (Exception ex)
			{
				this.ShowError("frmViewOrderInfo_Leave", ex);
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0006CAE8 File Offset: 0x0006AEE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void frmViewOrderInfo_KeyDown(object sender, KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Return || keyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		// Token: 0x040003C5 RID: 965
		private IContainer components;

		// Token: 0x040003C6 RID: 966
		private IntzaCustomGrid intzaInfo1;

		// Token: 0x040003C7 RID: 967
		private IntzaCustomGrid intzaInfo2;

		// Token: 0x040003C8 RID: 968
		private IntzaCustomGrid intzaInfo3;

		// Token: 0x040003C9 RID: 969
		private Label lbError;

		// Token: 0x040003CA RID: 970
		private SortGrid intzaDeal;

		// Token: 0x040003CB RID: 971
		private int currentTop;

		// Token: 0x040003CC RID: 972
		private long orderNumber;

		// Token: 0x040003CD RID: 973
		private string sendDate;

		// Token: 0x040003CE RID: 974
		private int selDbType;

		// Token: 0x040003CF RID: 975
		private int pageNo;

		// Token: 0x040003D0 RID: 976
		private BackgroundWorker bgwReloadData;

		// Token: 0x040003D1 RID: 977
		private DataSet tdsOrderTrans;

		// Token: 0x040003D2 RID: 978
		private bool isHistory;

		// Token: 0x040003D3 RID: 979
		private int yPosition;

		// Token: 0x040003D4 RID: 980
		private string _isFwAfterClose;
	}
}
