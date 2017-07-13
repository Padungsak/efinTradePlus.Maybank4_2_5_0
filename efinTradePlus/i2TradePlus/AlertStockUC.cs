using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus
{
	// Token: 0x020000DD RID: 221
	internal class AlertStockUC : UserControl
	{
		// Token: 0x06000A57 RID: 2647 RVA: 0x000C3C84 File Offset: 0x000C2084
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

		// Token: 0x06000A58 RID: 2648 RVA: 0x000C3CD4 File Offset: 0x000C20D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AlertStockUC));
			this.pictureBoxAlert = new PictureBox();
			this.timerChangeBackColor = new Timer(this.components);
			this.pictureBoxAlertNormal = new PictureBox();
			this.pictureBoxAlertBlink = new PictureBox();
			((ISupportInitialize)this.pictureBoxAlert).BeginInit();
			((ISupportInitialize)this.pictureBoxAlertNormal).BeginInit();
			((ISupportInitialize)this.pictureBoxAlertBlink).BeginInit();
			base.SuspendLayout();
			this.pictureBoxAlert.BackColor = Color.Transparent;
			this.pictureBoxAlert.Dock = DockStyle.Fill;
			this.pictureBoxAlert.Image = (Image)componentResourceManager.GetObject("pictureBoxAlert.Image");
			this.pictureBoxAlert.Location = new Point(0, 0);
			this.pictureBoxAlert.Margin = new Padding(0);
			this.pictureBoxAlert.Name = "pictureBoxAlert";
			this.pictureBoxAlert.Size = new Size(43, 38);
			this.pictureBoxAlert.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBoxAlert.TabIndex = 0;
			this.pictureBoxAlert.TabStop = false;
			this.pictureBoxAlert.MouseLeave += new EventHandler(this.pictureBoxAlert_MouseLeave);
			this.pictureBoxAlert.Click += new EventHandler(this.pictureBoxAlert_Click);
			this.pictureBoxAlert.MouseEnter += new EventHandler(this.pictureBoxAlert_MouseEnter);
			this.timerChangeBackColor.Interval = 500;
			this.timerChangeBackColor.Tick += new EventHandler(this.timerChangeBackColor_Tick);
			this.pictureBoxAlertNormal.BackColor = Color.Transparent;
			this.pictureBoxAlertNormal.Image = (Image)componentResourceManager.GetObject("pictureBoxAlertNormal.Image");
			this.pictureBoxAlertNormal.Location = new Point(3, 34);
			this.pictureBoxAlertNormal.Name = "pictureBoxAlertNormal";
			this.pictureBoxAlertNormal.Size = new Size(27, 38);
			this.pictureBoxAlertNormal.TabIndex = 1;
			this.pictureBoxAlertNormal.TabStop = false;
			this.pictureBoxAlertNormal.Visible = false;
			this.pictureBoxAlertBlink.BackColor = Color.Transparent;
			this.pictureBoxAlertBlink.Image = (Image)componentResourceManager.GetObject("pictureBoxAlertBlink.Image");
			this.pictureBoxAlertBlink.Location = new Point(36, 34);
			this.pictureBoxAlertBlink.Name = "pictureBoxAlertBlink";
			this.pictureBoxAlertBlink.Size = new Size(27, 38);
			this.pictureBoxAlertBlink.TabIndex = 2;
			this.pictureBoxAlertBlink.TabStop = false;
			this.pictureBoxAlertBlink.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.pictureBoxAlert);
			base.Controls.Add(this.pictureBoxAlertBlink);
			base.Controls.Add(this.pictureBoxAlertNormal);
			base.Margin = new Padding(0);
			base.Name = "AlertStockUC";
			base.Size = new Size(43, 38);
			((ISupportInitialize)this.pictureBoxAlert).EndInit();
			((ISupportInitialize)this.pictureBoxAlertNormal).EndInit();
			((ISupportInitialize)this.pictureBoxAlertBlink).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000A59 RID: 2649 RVA: 0x000C4058 File Offset: 0x000C2458
		// (remove) Token: 0x06000A5A RID: 2650 RVA: 0x000C4080 File Offset: 0x000C2480
		public event EventHandler AlertClick
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.AlertClick = (EventHandler)Delegate.Combine(this.AlertClick, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.AlertClick = (EventHandler)Delegate.Remove(this.AlertClick, value);
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000C40A8 File Offset: 0x000C24A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlertStockUC() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.isUseNormalImage = true;
			this.blinkStyle = AlertStockUC.BlinkStyles.BlinkImage;
			this.displayImage = null;
			this.normalColor = Color.Transparent;
			this.blinkColor = Color.Orange;
			this._alterMessageCount = 0;
			this.isAllowBlink = false;
			base..ctor();
			this.InitializeComponent();
			if (!base.DesignMode)
			{
				this.BackColor = this.normalColor;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000C4134 File Offset: 0x000C2534
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x000C4188 File Offset: 0x000C2588
		public Image DisplayImage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.displayImage == null)
				{
					this.displayImage = this.pictureBoxAlert.Image;
				}
				return this.pictureBoxAlert.Image;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.displayImage = value;
				if (!base.DesignMode)
				{
					this.pictureBoxAlert.Image = value;
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000C41C8 File Offset: 0x000C25C8
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x000C4210 File Offset: 0x000C2610
		[DefaultValue(PictureBoxSizeMode.CenterImage)]
		public PictureBoxSizeMode ImageSizeMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				PictureBoxSizeMode result;
				if (this.pictureBoxAlert != null)
				{
					result = this.pictureBoxAlert.SizeMode;
				}
				else
				{
					result = PictureBoxSizeMode.Normal;
				}
				return result;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.pictureBoxAlert != null)
				{
					this.pictureBoxAlert.SizeMode = value;
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x000C424C File Offset: 0x000C264C
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x000C4294 File Offset: 0x000C2694
		public Image NormalImage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				Image result;
				if (this.pictureBoxAlertNormal != null)
				{
					result = this.pictureBoxAlertNormal.Image;
				}
				else
				{
					result = null;
				}
				return result;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.pictureBoxAlertNormal != null)
				{
					this.pictureBoxAlertNormal.Image = value;
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x000C42D0 File Offset: 0x000C26D0
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x000C4318 File Offset: 0x000C2718
		public Image BlinkImage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				Image result;
				if (this.pictureBoxAlertBlink != null)
				{
					result = this.pictureBoxAlertBlink.Image;
				}
				else
				{
					result = null;
				}
				return result;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.pictureBoxAlertBlink != null)
				{
					this.pictureBoxAlertBlink.Image = value;
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x000C4354 File Offset: 0x000C2754
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x000C4380 File Offset: 0x000C2780
		public Color NormalColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.normalColor;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.normalColor = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000C4398 File Offset: 0x000C2798
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x000C43C4 File Offset: 0x000C27C4
		public Color BlinkColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.blinkColor;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.blinkColor = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000C43DC File Offset: 0x000C27DC
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x000C4424 File Offset: 0x000C2824
		[DefaultValue(500)]
		public int BlinkFrequancy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				int result;
				if (this.timerChangeBackColor != null)
				{
					result = this.timerChangeBackColor.Interval;
				}
				else
				{
					result = -1;
				}
				return result;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.timerChangeBackColor != null)
				{
					this.timerChangeBackColor.Interval = value;
				}
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x000C4460 File Offset: 0x000C2860
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x000C448C File Offset: 0x000C288C
		public int AlterMessageCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._alterMessageCount;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._alterMessageCount = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x000C44A4 File Offset: 0x000C28A4
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x000C44E8 File Offset: 0x000C28E8
		public bool IsStarted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return !base.DesignMode && this.timerChangeBackColor.Enabled;
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
					this.timerChangeBackColor.Enabled = value;
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x000C4520 File Offset: 0x000C2920
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x000C454C File Offset: 0x000C294C
		public bool IsAllowBlink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isAllowBlink;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.isAllowBlink = value;
				if (!base.DesignMode)
				{
					if (!this.IsAllowBlink)
					{
						if (!this.isUseNormalImage)
						{
							this.pictureBoxAlert.Image = this.pictureBoxAlertNormal.Image;
						}
					}
				}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x000C45B4 File Offset: 0x000C29B4
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x000C45F8 File Offset: 0x000C29F8
		[DefaultValue(BorderStyle.FixedSingle)]
		public BorderStyle Border
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				BorderStyle result;
				if (!base.DesignMode)
				{
					result = this.pictureBoxAlert.BorderStyle;
				}
				else
				{
					result = BorderStyle.None;
				}
				return result;
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
					this.pictureBoxAlert.BorderStyle = value;
				}
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000C4630 File Offset: 0x000C2A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerChangeBackColor_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._alterMessageCount > 0 && this.isAllowBlink)
			{
				if (this.blinkStyle == AlertStockUC.BlinkStyles.BlinkBackColor)
				{
					if (this.BackColor == this.normalColor)
					{
						this.BackColor = this.blinkColor;
					}
					else
					{
						this.BackColor = this.normalColor;
					}
				}
				else
				{
					if (this.isUseNormalImage)
					{
						this.pictureBoxAlert.Image = this.pictureBoxAlertBlink.Image;
					}
					else
					{
						this.pictureBoxAlert.Image = this.pictureBoxAlertNormal.Image;
					}
					this.isUseNormalImage = !this.isUseNormalImage;
				}
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x000C4718 File Offset: 0x000C2B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void pictureBoxAlert_MouseEnter(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BackColor = Color.LightSteelBlue;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000C4738 File Offset: 0x000C2B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void pictureBoxAlert_MouseLeave(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.BackColor = this.normalColor;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000C4758 File Offset: 0x000C2B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void pictureBoxAlert_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.AlertClick != null)
			{
				this.AlertClick(sender, e);
			}
		}

		// Token: 0x040006F8 RID: 1784
		private IContainer components;

		// Token: 0x040006F9 RID: 1785
		private PictureBox pictureBoxAlert;

		// Token: 0x040006FA RID: 1786
		private Timer timerChangeBackColor;

		// Token: 0x040006FB RID: 1787
		private PictureBox pictureBoxAlertNormal;

		// Token: 0x040006FC RID: 1788
		private PictureBox pictureBoxAlertBlink;

		// Token: 0x040006FE RID: 1790
		private bool isUseNormalImage;

		// Token: 0x040006FF RID: 1791
		private AlertStockUC.BlinkStyles blinkStyle;

		// Token: 0x04000700 RID: 1792
		private Image displayImage;

		// Token: 0x04000701 RID: 1793
		private Color normalColor;

		// Token: 0x04000702 RID: 1794
		private Color blinkColor;

		// Token: 0x04000703 RID: 1795
		private int _alterMessageCount;

		// Token: 0x04000704 RID: 1796
		private bool isAllowBlink;

		// Token: 0x020000DE RID: 222
		public enum BlinkStyles
		{
			// Token: 0x04000706 RID: 1798
			BlinkBackColor,
			// Token: 0x04000707 RID: 1799
			BlinkImage
		}
	}
}
