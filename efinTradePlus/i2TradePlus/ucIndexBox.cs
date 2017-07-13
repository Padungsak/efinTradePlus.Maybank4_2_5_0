using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Information;
using i2TradePlus.Properties;
using ITSNet.Common.BIZ;

namespace i2TradePlus
{
	// Token: 0x020000CC RID: 204
	public class ucIndexBox : UserControl
	{
		// Token: 0x0600095B RID: 2395 RVA: 0x000B99AC File Offset: 0x000B7DAC
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

		// Token: 0x0600095C RID: 2396 RVA: 0x000B99FC File Offset: 0x000B7DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			this.btnSwap = new Button();
			this.btnSelect = new Button();
			this.panel1 = new Panel();
			this.timerSwapSET = new Timer(this.components);
			this.contextMenuStrip1 = new ContextMenuStrip(this.components);
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.btnSwap.Cursor = Cursors.Hand;
			this.btnSwap.Dock = DockStyle.Top;
			this.btnSwap.FlatAppearance.BorderSize = 0;
			this.btnSwap.FlatStyle = FlatStyle.Flat;
			this.btnSwap.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnSwap.ForeColor = Color.DarkGray;
			this.btnSwap.Location = new Point(0, 0);
			this.btnSwap.Margin = new Padding(2);
			this.btnSwap.Name = "btnSwap";
			this.btnSwap.Size = new Size(40, 20);
			this.btnSwap.TabIndex = 0;
			this.btnSwap.Text = "Swap";
			this.btnSwap.UseVisualStyleBackColor = true;
			this.btnSwap.Click += new EventHandler(this.btnSwap_Click);
			this.btnSelect.Cursor = Cursors.Hand;
			this.btnSelect.Dock = DockStyle.Bottom;
			this.btnSelect.FlatAppearance.BorderSize = 0;
			this.btnSelect.FlatStyle = FlatStyle.Flat;
			this.btnSelect.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.btnSelect.ForeColor = Color.DarkGray;
			this.btnSelect.Location = new Point(0, 22);
			this.btnSelect.Margin = new Padding(2);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new Size(40, 20);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new EventHandler(this.btnSelect_Click);
			this.panel1.BackColor = Color.FromArgb(20, 20, 20);
			this.panel1.Controls.Add(this.btnSwap);
			this.panel1.Controls.Add(this.btnSelect);
			this.panel1.Location = new Point(2, 2);
			this.panel1.Margin = new Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(40, 42);
			this.panel1.TabIndex = 2;
			this.timerSwapSET.Interval = 15000;
			this.timerSwapSET.Tick += new EventHandler(this.timerSwapSET_Tick);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(61, 4);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.Controls.Add(this.panel1);
			base.Name = "ucIndexBox";
			base.Size = new Size(265, 46);
			base.Paint += new PaintEventHandler(this.ucIndexBox_Paint);
			base.SizeChanged += new EventHandler(this.ucIndexBox_SizeChanged);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x000B9E00 File Offset: 0x000B8200
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x000B9E2C File Offset: 0x000B822C
		public int DisplayType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.displayType;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.displayType = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x000B9E44 File Offset: 0x000B8244
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x000B9E70 File Offset: 0x000B8270
		public string DisplaySET
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._displaySET;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._displaySET = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x000B9E88 File Offset: 0x000B8288
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x000B9EB4 File Offset: 0x000B82B4
		public int DisplaySector
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._displaySector;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._displaySector = value;
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000B9ECC File Offset: 0x000B82CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ucIndexBox()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.displayType = 1;
			this._displaySET = "SET";
			this._displaySector = 1;
			this._autoSwap = true;
			this._maxSector = 0;
			this._currentTFEXMarket = 1;
			this._strFormat = new StringFormat();
			this._maxTFEXMarket = 6;
			this.bgwGold = null;
			this._goldUpdateLastTime = DateTime.MinValue;
			this._active = false;
			this._goldSpotValue = null;
			base..ctor();
			try
			{
				this.InitializeComponent();
				this.panel1.Visible = false;
				if (ApplicationInfo.BrokerId == 4 && ApplicationInfo.IsSupportTfex)
				{
					this._maxTFEXMarket = 8;
					this.bgwGold = new BackgroundWorker();
					this.bgwGold.DoWork += new DoWorkEventHandler(this.bgwGold_DoWork);
					this.bgwGold.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwGold_RunWorkerCompleted);
				}
				base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
				base.UpdateStyles();
			}
			catch
			{
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000BA008 File Offset: 0x000B8408
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucIndexBox_Paint(object sender, PaintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.displayType == 1)
				{
					this.DrawSET(e.Graphics);
				}
				else if (this.displayType == 2)
				{
					this.DrawSector(e.Graphics);
				}
				else
				{
					this.DrawTFEX(e.Graphics);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000BA09C File Offset: 0x000B849C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawSET(Graphics g)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!ApplicationInfo.IsAreadyLogin)
				{
					g.DrawRectangle(Pens.DimGray, 0, 0, base.Width - 1, base.Height - 1);
				}
				else
				{
					float num = 10f;
					int num2 = 75;
					int num3 = 175;
					if (ApplicationInfo.IsScreen125)
					{
						num2 = 90;
						num3 = 195;
					}
					if (this._displaySET == string.Empty)
					{
						this._displaySET = "SET";
					}
					int num4 = this.panel1.Right + 1;
					if (this._displaySET == "SET")
					{
						num4 = 0;
					}
					int num5 = 0;
					int width = base.Width;
					int height = base.Height;
					this._strFormat.LineAlignment = StringAlignment.Center;
					g.Clear(Color.FromArgb(30, 30, 30));
					IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo["." + this._displaySET];
					if (indexItem != null)
					{
						this._strFormat.Alignment = StringAlignment.Near;
						g.DrawString(this._displaySET, new Font(Settings.Default.Default_Font.Name, num + 2f, FontStyle.Bold), Brushes.Gold, new RectangleF((float)(num4 + 5), (float)(num5 + 4), 70f, 20f), this._strFormat);
						Color color = Utilities.ComparePriceColor(indexItem.IndexChg, 0m);
						this._strFormat.Alignment = StringAlignment.Far;
						g.DrawString(Utilities.PriceFormat((indexItem.LastIndex > 0m) ? indexItem.LastIndex : indexItem.Prior), new Font(Settings.Default.Default_Font.Name, num + 3f, FontStyle.Bold), new SolidBrush(color), new RectangleF((float)(num4 + num2), (float)(num5 + 3), 87f, 24f), this._strFormat);
						if (indexItem.AccValue > 0m)
						{
							g.DrawString(FormatUtil.VolumeFormat(indexItem.AccValue / 1000000m, true) + " M", new Font(Settings.Default.Default_Font.Name, num - 2f, FontStyle.Regular), Brushes.LightGray, new RectangleF((float)(num4 + num2), (float)(num5 + 28), 87f, 15f), this._strFormat);
						}
						if (indexItem.IndexChg != 0m)
						{
							this._strFormat.Alignment = StringAlignment.Near;
							g.DrawString(FormatUtil.PriceFormat(indexItem.IndexChg, true, "", 2), new Font(Settings.Default.Default_Font.Name, num - 1f, FontStyle.Regular), new SolidBrush(color), new RectangleF((float)(num4 + num3), (float)(num5 + 6), 58f, 16f), this._strFormat);
							g.DrawString(FormatUtil.PriceFormat(indexItem.IndexChgPct, true, "%", 2), new Font(Settings.Default.Default_Font.Name, num - 1f, FontStyle.Regular), new SolidBrush(color), new RectangleF((float)(num4 + num3), (float)(num5 + 27), 58f, 16f), this._strFormat);
						}
						if (this._displaySET == "SET")
						{
							string s = string.Empty;
							Color color2 = MyColor.UnChgColor;
							string marketState = ApplicationInfo.MarketState;
							switch (marketState)
							{
							case "H":
								s = "Halt";
								color2 = Color.Red;
								goto IL_53A;
							case "S":
								s = "Start";
								color2 = Color.Lime;
								goto IL_53A;
							case "P":
								s = "Pre-Open";
								color2 = Color.Lime;
								goto IL_53A;
							case "O":
								s = "Open";
								color2 = Color.Lime;
								goto IL_53A;
							case "B":
								s = "Intermission";
								color2 = Color.White;
								goto IL_53A;
							case "M":
								s = "Call Market";
								color2 = Color.Lime;
								goto IL_53A;
							case "R":
								s = "Run-Off";
								color2 = Color.White;
								goto IL_53A;
							case "C":
								s = "Close";
								color2 = Color.Red;
								goto IL_53A;
							}
							int marketSession = ApplicationInfo.MarketSession;
							s = marketSession.ToString();
							color2 = Color.White;
							IL_53A:
							this._strFormat.Alignment = StringAlignment.Near;
							g.DrawString(s, new Font(Settings.Default.Default_Font.Name, num - 1.75f, FontStyle.Regular), new SolidBrush(color2), new RectangleF((float)(num4 + 5), (float)(num5 + 24), 80f, 20f), this._strFormat);
						}
						g.DrawRectangle(Pens.DimGray, 0, 0, base.Width - 1, base.Height - 1);
					}
					else
					{
						this.ShowError("DrawSET", new Exception("Index [" + this._displaySET + "] is null."));
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("DrawSET", ex);
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000BA6C4 File Offset: 0x000B8AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawSector(Graphics g)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsAreadyLogin)
				{
					int num = this.panel1.Right + 1;
					int num2 = 0;
					int width = base.Width;
					int height = base.Height;
					float num3 = 10f;
					int num4 = 75;
					int num5 = 175;
					if (ApplicationInfo.IsScreen125)
					{
						num4 = 90;
						num5 = 195;
					}
					g.Clear(Color.FromArgb(30, 30, 30));
					IndexStat.IndexItem sector = ApplicationInfo.IndexStatInfo.GetSector(this._displaySector);
					if (sector != null)
					{
						this._strFormat.Alignment = StringAlignment.Near;
						g.DrawString(sector.Symbol, new Font(Settings.Default.Default_Font.Name, num3, FontStyle.Bold), Brushes.Cyan, new RectangleF((float)(num + 5), (float)(num2 + 3), 80f, 20f), this._strFormat);
						Color color = Utilities.ComparePriceColor(sector.LastIndex, sector.Prior);
						this._strFormat.Alignment = StringAlignment.Far;
						g.DrawString(Utilities.PriceFormat((sector.LastIndex > 0m) ? sector.LastIndex : sector.Prior), new Font(Settings.Default.Default_Font.Name, num3 + 1f, FontStyle.Bold), new SolidBrush(color), new RectangleF((float)(num + num4), (float)(num2 + 3), 87f, 24f), this._strFormat);
						if (sector.AccValue > 0m)
						{
							this._strFormat.Alignment = StringAlignment.Far;
							g.DrawString(FormatUtil.VolumeFormat(sector.AccValue / 1000000m, true) + " M", new Font(Settings.Default.Default_Font.Name, num3 - 2f, FontStyle.Regular), Brushes.LightGray, new RectangleF((float)(num + num4), (float)(num2 + 28), 87f, 15f), this._strFormat);
						}
						if (sector.IndexChg != 0m)
						{
							this._strFormat.Alignment = StringAlignment.Near;
							g.DrawString(FormatUtil.PriceFormat(sector.IndexChg, true, "", 2), new Font(Settings.Default.Default_Font.Name, num3 - 1f, FontStyle.Regular), new SolidBrush(color), new RectangleF((float)(num + num5), (float)(num2 + 5), 58f, 16f), this._strFormat);
							g.DrawString(FormatUtil.PriceFormat((sector.IndexChg != 0m) ? (sector.IndexChg / sector.Prior * 100m) : 0m, true, "%", 2), new Font(Settings.Default.Default_Font.Name, num3 - 1f, FontStyle.Regular), new SolidBrush(color), new RectangleF((float)(num + num5), (float)(num2 + 27), 58f, 16f), this._strFormat);
						}
						g.DrawRectangle(Pens.DimGray, 0, 0, base.Width - 1, base.Height - 1);
					}
					else
					{
						this.ShowError("DrawSector", new Exception("Sector no " + this._displaySector + " is null."));
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("DrawSector", ex);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000BAAC4 File Offset: 0x000B8EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawTFEX(Graphics g)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!ApplicationInfo.IsAreadyLogin)
			{
				g.DrawRectangle(Pens.DimGray, 0, 0, base.Width - 1, base.Height - 1);
			}
			else if (base.InvokeRequired)
			{
				base.Invoke(new ucIndexBox.DrawTFEXCallback(this.DrawTFEX), new object[]
				{
					g
				});
			}
			else
			{
				try
				{
					int num = 0;
					int width = base.Width;
					int num2 = base.Height;
					int num3 = this.panel1.Right + 1;
					float emSize = 10f;
					g.Clear(Color.FromArgb(30, 30, 30));
					this._strFormat.LineAlignment = StringAlignment.Near;
					string name = Settings.Default.Default_Font.Name;
					Brush yellow = Brushes.Yellow;
					string empty = string.Empty;
					string empty2 = string.Empty;
					Font font = new Font(name, 7.25f, FontStyle.Regular);
					this.GetTFEXMarketState(ref empty2, ref empty, ref yellow);
					if ((this._currentTFEXMarket == 7 || this._currentTFEXMarket == 8) && ApplicationInfo.BrokerId == 4 && ApplicationInfo.IsSupportTfex)
					{
						this._strFormat.Alignment = StringAlignment.Near;
						g.DrawString(empty, new Font(name, 12f, FontStyle.Bold), Brushes.Gold, new RectangleF((float)(num3 + 13), (float)(num + 5), 85f, 20f), this._strFormat);
						g.DrawString("Gold Spot", new Font(name, 8f, FontStyle.Regular), Brushes.Cyan, new RectangleF((float)(num3 + 8), (float)(num + 28), 85f, 20f), this._strFormat);
						g.DrawString("BID", new Font(Settings.Default.Default_Font.Name, emSize, FontStyle.Bold), Brushes.LightGray, new RectangleF((float)(num3 + 90), (float)(num + 6), 40f, 20f), this._strFormat);
						g.DrawString(Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.BBOCurrency[empty2].BidPrice), new Font(name, 11f, FontStyle.Regular), Brushes.Magenta, new RectangleF((float)(num3 + 140), (float)(num + 4), 80f, 24f), this._strFormat);
						this._strFormat.Alignment = StringAlignment.Far;
						g.DrawString("ASK", new Font(Settings.Default.Default_Font.Name, emSize, FontStyle.Bold), Brushes.LightGray, new RectangleF((float)(num3 + 250), (float)(num + 6), 40f, 20f), this._strFormat);
						this._strFormat.Alignment = StringAlignment.Far;
						g.DrawString(Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.BBOCurrency[empty2].AskPrice), new Font(name, 11f, FontStyle.Regular), Brushes.Cyan, new RectangleF((float)(num3 + 295), (float)(num + 4), 80f, 24f), this._strFormat);
						this._strFormat.Alignment = StringAlignment.Far;
						g.DrawString(Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.BBOCurrency[empty2].LastDate) + "  " + Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.BBOCurrency[empty2].LastTime), new Font(name, 8f, FontStyle.Regular), Brushes.LightGray, new RectangleF((float)(num3 + 230), (float)(num + 29), 145f, 24f), this._strFormat);
					}
					else
					{
						num2 /= 2;
						this._strFormat.Alignment = StringAlignment.Near;
						this._strFormat.LineAlignment = StringAlignment.Center;
						g.DrawString(empty2, new Font(name, 9.25f, FontStyle.Bold), Brushes.Gold, new RectangleF((float)(num3 + 4), (float)(num + 5), 85f, (float)(num2 / 2)), this._strFormat);
						g.DrawString("Total Vol", font, Brushes.LightGray, new RectangleF((float)(num3 + 87), (float)(num + 2), 90f, (float)(num2 - 2)), this._strFormat);
						g.DrawString(Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.TfexTotalVol), new Font(name, 9f, FontStyle.Regular), Brushes.Yellow, new RectangleF((float)(num3 + 142), (float)(num + 2), 85f, (float)(num2 - 2)), this._strFormat);
						g.DrawString("OI / DEAL", font, Brushes.LightGray, new RectangleF((float)(num3 + 227), (float)(num + 2), 65f, (float)(num2 - 2)), this._strFormat);
						g.DrawString(Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.TfexTotalOI) + " / " + Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.TfexTotalDeal), new Font(name, 8.25f, FontStyle.Regular), Brushes.Yellow, new RectangleF((float)(num3 + 282), (float)(num + 2), 110f, (float)(num2 - 2)), this._strFormat);
						g.DrawString(empty, font, yellow, new RectangleF((float)(num3 + 5), (float)(num + num2), 85f, (float)(num2 - 2)), this._strFormat);
						g.DrawString("FU/OP Vol", font, Brushes.LightGray, new RectangleF((float)(num3 + 87), (float)(num + num2), 90f, (float)(num2 - 2)), this._strFormat);
						g.DrawString(Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.FutureVol) + " / " + Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.OptionsVol), font, Brushes.Yellow, new RectangleF((float)(num3 + 142), (float)(num + num2), 85f, (float)(num2 - 2)), this._strFormat);
						g.DrawString("FU/OP OI", font, Brushes.LightGray, new RectangleF((float)(num3 + 227), (float)(num + num2), 65f, (float)(num2 - 2)), this._strFormat);
						g.DrawString(Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.FutureOI) + " / " + Utilities.PriceFormat(ApplicationInfo.IndexInfoTfex.OptionsOI), font, Brushes.Yellow, new RectangleF((float)(num3 + 282), (float)(num + num2), 110f, (float)(num2 - 2)), this._strFormat);
					}
					g.DrawRectangle(Pens.DimGray, 0, 0, base.Width - 1, base.Height - 1);
				}
				catch (Exception ex)
				{
					this.ShowError("DrawTFEX", ex);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x000BB1A4 File Offset: 0x000B95A4
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x000BB1D0 File Offset: 0x000B95D0
		public bool Active
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._active;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._active = value;
				if (value && ApplicationInfo.IsScreen125)
				{
					this.btnSwap.Font = new Font("Microsoft Sans Serif", 5.75f);
					this.btnSelect.Font = new Font("Microsoft Sans Serif", 5.75f);
					this.panel1.SetBounds(1, 1, 53, base.Height - 2);
					this.btnSwap.Top = 0;
					this.btnSwap.Height = this.panel1.Height / 2;
					this.btnSelect.Top = this.btnSwap.Bottom;
					this.btnSelect.Height = this.btnSwap.Height;
				}
				if (this.displayType == 2 || this.displayType == 3)
				{
					this.panel1.Visible = true;
				}
				if (this._displaySET != "SET")
				{
					this.panel1.Visible = true;
				}
				if (this.DisplayType == 2)
				{
					foreach (IndexStat.IndexItem current in ApplicationInfo.IndexStatInfo.Items)
					{
						if (current.Type == "S")
						{
							if (current.Number > this._maxSector)
							{
								this._maxSector = current.Number;
							}
						}
					}
					this._autoSwap = true;
				}
				else if (this.DisplayType == 1)
				{
					this._autoSwap = false;
				}
				else if (this.DisplayType == 3)
				{
					this._autoSwap = true;
				}
				if (value)
				{
					this.SetSwap(this._autoSwap);
					base.Invalidate();
				}
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000BB420 File Offset: 0x000B9820
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSwap(bool isSwap)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.btnSwap.Text = (isSwap ? "Stop" : "Swap");
				if (isSwap)
				{
					this.timerSwapSET.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000BB494 File Offset: 0x000B9894
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerSwapSET_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._autoSwap)
				{
					if (this.DisplayType == 1)
					{
						if (this._displaySET == string.Empty)
						{
							this._displaySET = "SET50";
						}
						if (this._displaySET == "SET50")
						{
							this._displaySET = "SET100";
						}
						else if (this._displaySET == "SET100")
						{
							this._displaySET = "sSET";
							IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo["." + this._displaySET];
							if (indexItem == null)
							{
								this._displaySET = "MAI";
							}
						}
						else if (this._displaySET == "sSET")
						{
							this._displaySET = "MAI";
						}
						else if (this._displaySET == "MAI")
						{
							this._displaySET = "SETHD";
						}
						else if (this._displaySET == "SETHD")
						{
							this._displaySET = "SET50";
						}
						base.Invalidate();
					}
					else if (this.DisplayType == 2)
					{
						this._displaySector++;
						if (this._displaySector > this._maxSector)
						{
							this._displaySector = 1;
						}
						IndexStat.IndexItem indexItem2 = ApplicationInfo.IndexStatInfo.GetSector(this._displaySector);
						while (indexItem2 == null)
						{
							this._displaySector++;
							indexItem2 = ApplicationInfo.IndexStatInfo.GetSector(this._displaySector);
							if (indexItem2 != null)
							{
								if (!indexItem2.IsMainMarket)
								{
									indexItem2 = null;
								}
							}
							if (this._displaySector > 100)
							{
								break;
							}
						}
						base.Invalidate();
					}
					else if (this.DisplayType == 3)
					{
						this._currentTFEXMarket++;
						if (this._currentTFEXMarket > this._maxTFEXMarket)
						{
							this._currentTFEXMarket = 1;
						}
						base.Invalidate();
					}
				}
				else
				{
					base.Invalidate();
				}
				if (this.DisplayType == 3)
				{
					if (ApplicationInfo.BrokerId == 4 && ApplicationInfo.IsSupportTfex)
					{
						if (this._currentTFEXMarket == 7 || this._currentTFEXMarket == 8)
						{
							if (!this.bgwGold.IsBusy)
							{
								this.bgwGold.RunWorkerAsync();
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000BB7D0 File Offset: 0x000B9BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000BB804 File Offset: 0x000B9C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSwap_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._autoSwap = !this._autoSwap;
			this.SetSwap(this._autoSwap);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000BB834 File Offset: 0x000B9C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void btnSelect_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.DisplayType == 1)
				{
					if (this.contextMenuStrip1.Items.Count == 0)
					{
						foreach (IndexStat.IndexItem current in ApplicationInfo.IndexStatInfo.Items)
						{
							if (current.Type == "E" && current.Symbol != ".SET")
							{
								this.contextMenuStrip1.Items.Add(current.Symbol, null, new EventHandler(this.item_Click));
							}
						}
					}
				}
				else if (this.DisplayType == 2)
				{
					if (this.contextMenuStrip1.Items.Count == 0)
					{
						foreach (IndexStat.IndexItem current in ApplicationInfo.IndexStatInfo.Items)
						{
							if (current.Type == "S" && current.IsMainMarket)
							{
								this.contextMenuStrip1.Items.Add(current.Symbol, null, new EventHandler(this.item_Click));
							}
						}
					}
				}
				else if (this.DisplayType == 3)
				{
					if (this.contextMenuStrip1.Items.Count == 0)
					{
						this.contextMenuStrip1.Items.Add("INDEX", null, new EventHandler(this.itemtfex_Click));
						this.contextMenuStrip1.Items.Add("STOCK", null, new EventHandler(this.itemtfex_Click));
						this.contextMenuStrip1.Items.Add("IR", null, new EventHandler(this.itemtfex_Click));
						this.contextMenuStrip1.Items.Add("METAL", null, new EventHandler(this.itemtfex_Click));
						this.contextMenuStrip1.Items.Add("ENERGY", null, new EventHandler(this.itemtfex_Click));
						this.contextMenuStrip1.Items.Add("CURRENCY", null, new EventHandler(this.itemtfex_Click));
						if (ApplicationInfo.BrokerId == 4 && ApplicationInfo.IsSupportTfex)
						{
							this.contextMenuStrip1.Items.Add("USD", null, new EventHandler(this.itemtfex_Click));
							this.contextMenuStrip1.Items.Add("THB", null, new EventHandler(this.itemtfex_Click));
						}
					}
				}
				this.contextMenuStrip1.Show(this.btnSelect, new Point(0, 0));
			}
			catch (Exception ex)
			{
				this.ShowError("btnSelect_Click", ex);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000BBBE0 File Offset: 0x000B9FE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void item_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ToolStripItem toolStripItem = sender as ToolStripItem;
				if (toolStripItem.Text == ".SET50")
				{
					this._displaySET = "SET50";
					base.Invalidate();
				}
				else if (toolStripItem.Text == ".SET100")
				{
					this._displaySET = "SET100";
					base.Invalidate();
				}
				else if (toolStripItem.Text == ".sSET")
				{
					this._displaySET = "sSET";
					base.Invalidate();
				}
				else if (toolStripItem.Text == ".SETHD")
				{
					this._displaySET = "SETHD";
					base.Invalidate();
				}
				else if (toolStripItem.Text == ".MAI")
				{
					this._displaySET = "MAI";
					base.Invalidate();
				}
				else
				{
					IndexStat.IndexItem indexItem = ApplicationInfo.IndexStatInfo[toolStripItem.Text];
					if (indexItem.Number > -1)
					{
						this._displaySector = indexItem.Number;
						base.Invalidate();
					}
				}
				this.SetSwap(this._autoSwap);
			}
			catch (Exception ex)
			{
				this.ShowError("item_Click", ex);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000BBD84 File Offset: 0x000BA184
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void itemtfex_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ToolStripItem toolStripItem = sender as ToolStripItem;
				if (toolStripItem.Text == "INDEX")
				{
					this._currentTFEXMarket = 1;
					base.Invalidate();
				}
				else if (toolStripItem.Text == "STOCK")
				{
					this._currentTFEXMarket = 2;
					base.Invalidate();
				}
				else if (toolStripItem.Text == "IR")
				{
					this._currentTFEXMarket = 3;
					base.Invalidate();
				}
				else if (toolStripItem.Text == "METAL")
				{
					this._currentTFEXMarket = 4;
					base.Invalidate();
				}
				else if (toolStripItem.Text == "ENERGY")
				{
					this._currentTFEXMarket = 5;
					base.Invalidate();
				}
				else if (toolStripItem.Text == "CURRENCY")
				{
					this._currentTFEXMarket = 6;
					base.Invalidate();
				}
				else if (toolStripItem.Text == "USD")
				{
					this._currentTFEXMarket = 7;
					if (!this.bgwGold.IsBusy)
					{
						this.bgwGold.RunWorkerAsync();
					}
					base.Invalidate();
				}
				else if (toolStripItem.Text == "THB")
				{
					this._currentTFEXMarket = 8;
					if (!this.bgwGold.IsBusy)
					{
						this.bgwGold.RunWorkerAsync();
					}
					base.Invalidate();
				}
				this.SetSwap(this._autoSwap);
			}
			catch (Exception ex)
			{
				this.ShowError("itemtfex_Click", ex);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000BBF9C File Offset: 0x000BA39C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetTFEXMarketState(ref string mktName, ref string marketState, ref Brush color)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string empty = string.Empty;
			try
			{
				string text = string.Empty;
				if (this._currentTFEXMarket == 1)
				{
					text = ApplicationInfo.IndexInfoTfex.TXIState;
					mktName = "INDEX";
				}
				else if (this._currentTFEXMarket == 2)
				{
					text = ApplicationInfo.IndexInfoTfex.TXSState;
					mktName = "STOCK";
				}
				else if (this._currentTFEXMarket == 3)
				{
					text = ApplicationInfo.IndexInfoTfex.TXRState;
					mktName = "IR";
				}
				else if (this._currentTFEXMarket == 4)
				{
					text = ApplicationInfo.IndexInfoTfex.TXMState;
					mktName = "METAL";
				}
				else if (this._currentTFEXMarket == 5)
				{
					text = ApplicationInfo.IndexInfoTfex.TXEState;
					mktName = "ENERGY";
				}
				else if (this._currentTFEXMarket == 6)
				{
					text = ApplicationInfo.IndexInfoTfex.TXCState;
					mktName = "CURRENCY";
				}
				else if (this._currentTFEXMarket == 7 && ApplicationInfo.BrokerId == 4 && ApplicationInfo.IsSupportTfex)
				{
					text = "USD";
					mktName = "USD";
					marketState = "USD";
				}
				else if (this._currentTFEXMarket == 8 && ApplicationInfo.BrokerId == 4 && ApplicationInfo.IsSupportTfex)
				{
					text = "THB";
					mktName = "THB";
					marketState = "THB";
				}
				string text2 = text;
				switch (text2)
				{
				case "0":
					marketState = "Already";
					color = Brushes.White;
					goto IL_466;
				case "3S":
					marketState = "Start";
					color = Brushes.Lime;
					goto IL_466;
				case "3C":
					marketState = "Close";
					color = Brushes.Red;
					goto IL_466;
				case "7":
					marketState = "Pre-Open";
					color = Brushes.Lime;
					goto IL_466;
				case "8":
					marketState = "Intermission";
					color = Brushes.White;
					goto IL_466;
				case "9":
					marketState = "Pre-Open";
					color = Brushes.Lime;
					goto IL_466;
				case "10":
					marketState = "Open";
					color = Brushes.Lime;
					goto IL_466;
				case "11":
					marketState = "Open";
					color = Brushes.Lime;
					goto IL_466;
				case "12":
					marketState = "HALT";
					color = Brushes.Red;
					goto IL_466;
				case "16":
					marketState = "Pre Trade";
					color = Brushes.Lime;
					goto IL_466;
				case "18":
					marketState = "CIRCUIT BREAK";
					color = Brushes.Red;
					goto IL_466;
				case "20":
					marketState = "Intermission";
					color = Brushes.White;
					goto IL_466;
				case "21":
					marketState = "Intermission";
					color = Brushes.White;
					goto IL_466;
				case "22":
					marketState = "Intermission";
					color = Brushes.White;
					goto IL_466;
				case "23":
					marketState = "Pre Night";
					color = Brushes.Cyan;
					goto IL_466;
				case "24":
					marketState = "Night";
					color = Brushes.Cyan;
					goto IL_466;
				case "25":
					marketState = "SETTLEMENT";
					color = Brushes.Cyan;
					goto IL_466;
				}
				color = Brushes.Cyan;
				IL_466:;
			}
			catch (Exception ex)
			{
				this.ShowError("GetTFEXMarketStateString", ex);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000BC448 File Offset: 0x000BA848
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwGold_DoWork(object sender, DoWorkEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this._goldUpdateLastTime.AddSeconds(60.0) <= DateTime.Now)
				{
					string goldSpot = ApplicationInfo.WebServiceTFEX.GetGoldSpot();
					string[] array = goldSpot.Split(new char[]
					{
						';'
					});
					decimal num = 0m;
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						string text = array2[i];
						string[] array3 = text.Split(new char[]
						{
							'='
						});
						if (array3.Length > 1)
						{
							if (array3[0].ToString() == "BidUSD")
							{
								this._goldSpotValue = ApplicationInfo.IndexInfoTfex.BBOCurrency["USD"];
								decimal.TryParse(array3[1].ToString(), out num);
								this._goldSpotValue.BidPrice = num;
							}
							else if (array3[0].ToString() == "OfferUSD")
							{
								this._goldSpotValue = ApplicationInfo.IndexInfoTfex.BBOCurrency["USD"];
								decimal.TryParse(array3[1].ToString(), out num);
								this._goldSpotValue.AskPrice = num;
							}
							else if (array3[0].ToString() == "BidTHB")
							{
								this._goldSpotValue = ApplicationInfo.IndexInfoTfex.BBOCurrency["THB"];
								decimal.TryParse(array3[1].ToString(), out num);
								this._goldSpotValue.BidPrice = num;
							}
							else if (array3[0].ToString() == "OfferTHB")
							{
								this._goldSpotValue = ApplicationInfo.IndexInfoTfex.BBOCurrency["THB"];
								decimal.TryParse(array3[1].ToString(), out num);
								this._goldSpotValue.AskPrice = num;
							}
							else if (array3[0].ToString() == "Date")
							{
								this._goldSpotValue = ApplicationInfo.IndexInfoTfex.BBOCurrency["THB"];
								this._goldSpotValue.LastDate = this.GetDateString(array3[1].ToString());
								this._goldSpotValue = ApplicationInfo.IndexInfoTfex.BBOCurrency["USD"];
								this._goldSpotValue.LastDate = this.GetDateString(array3[1].ToString());
							}
							else if (array3[0].ToString() == "Time")
							{
								this._goldSpotValue = ApplicationInfo.IndexInfoTfex.BBOCurrency["THB"];
								this._goldSpotValue.LastTime = array3[1].ToString();
								this._goldSpotValue = ApplicationInfo.IndexInfoTfex.BBOCurrency["USD"];
								this._goldSpotValue.LastTime = array3[1].ToString();
							}
						}
					}
					this._goldUpdateLastTime = DateTime.Now;
				}
			}
			catch (Exception ex)
			{
				this.ShowError("GetGoldSpot", ex);
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000BC7E0 File Offset: 0x000BABE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bgwGold_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.Invalidate();
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000BC7F8 File Offset: 0x000BABF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetDateString(string date)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			string result = date;
			try
			{
				if (date.Length == 8)
				{
					string text = date.Substring(0, 4);
					string text2 = date.Substring(4, 2);
					string text3 = date.Substring(6, 2);
					string text4 = text2;
					switch (text4)
					{
					case "01":
						text2 = "January";
						break;
					case "02":
						text2 = "February";
						break;
					case "03":
						text2 = "March";
						break;
					case "04":
						text2 = "April";
						break;
					case "05":
						text2 = "May";
						break;
					case "06":
						text2 = "June";
						break;
					case "07":
						text2 = "July";
						break;
					case "08":
						text2 = "August";
						break;
					case "09":
						text2 = "September";
						break;
					case "10":
						text2 = "October";
						break;
					case "11":
						text2 = "November";
						break;
					case "12":
						text2 = "December";
						break;
					}
					result = string.Concat(new string[]
					{
						text3,
						" ",
						text2,
						" ",
						text
					});
				}
			}
			catch (Exception ex)
			{
				this.ShowError("GetDateString", ex);
			}
			return result;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000BCA50 File Offset: 0x000BAE50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucIndexBox_SizeChanged(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x04000670 RID: 1648
		private IContainer components;

		// Token: 0x04000671 RID: 1649
		private Button btnSwap;

		// Token: 0x04000672 RID: 1650
		private Button btnSelect;

		// Token: 0x04000673 RID: 1651
		private Panel panel1;

		// Token: 0x04000674 RID: 1652
		private Timer timerSwapSET;

		// Token: 0x04000675 RID: 1653
		private ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000676 RID: 1654
		private int displayType;

		// Token: 0x04000677 RID: 1655
		private string _displaySET;

		// Token: 0x04000678 RID: 1656
		private int _displaySector;

		// Token: 0x04000679 RID: 1657
		private bool _autoSwap;

		// Token: 0x0400067A RID: 1658
		public int _maxSector;

		// Token: 0x0400067B RID: 1659
		private int _currentTFEXMarket;

		// Token: 0x0400067C RID: 1660
		private StringFormat _strFormat;

		// Token: 0x0400067D RID: 1661
		private int _maxTFEXMarket;

		// Token: 0x0400067E RID: 1662
		private BackgroundWorker bgwGold;

		// Token: 0x0400067F RID: 1663
		private DateTime _goldUpdateLastTime;

		// Token: 0x04000680 RID: 1664
		private bool _active;

		// Token: 0x04000681 RID: 1665
		private BBOTFEXCurrency _goldSpotValue;

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000977 RID: 2423
		private delegate void DrawTFEXCallback(Graphics g);
	}
}
