using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.User_Control
{
	// Token: 0x0200007A RID: 122
	public class ucMarketStateBox : UserControl
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x00064FE0 File Offset: 0x000633E0
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

		// Token: 0x06000599 RID: 1433 RVA: 0x00065030 File Offset: 0x00063430
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ucMarketStateBox));
			this.lbTimerServer = new Label();
			this.lbPushMode = new Label();
			this.toolTip1 = new ToolTip(this.components);
			this.tmerServer = new Timer(this.components);
			this.alertStockControl = new AlertStockUC();
			base.SuspendLayout();
			this.lbTimerServer.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.lbTimerServer.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbTimerServer.ForeColor = Color.WhiteSmoke;
			this.lbTimerServer.ImageAlign = ContentAlignment.MiddleLeft;
			this.lbTimerServer.Location = new Point(5, 2);
			this.lbTimerServer.Name = "lbTimerServer";
			this.lbTimerServer.Size = new Size(62, 41);
			this.lbTimerServer.TabIndex = 61;
			this.lbTimerServer.Text = "00:00:00";
			this.lbTimerServer.TextAlign = ContentAlignment.MiddleCenter;
			this.lbPushMode.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.lbPushMode.AutoSize = true;
			this.lbPushMode.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbPushMode.ForeColor = Color.LightGray;
			this.lbPushMode.Location = new Point(124, 15);
			this.lbPushMode.Margin = new Padding(1, 0, 1, 0);
			this.lbPushMode.Name = "lbPushMode";
			this.lbPushMode.Size = new Size(41, 15);
			this.lbPushMode.TabIndex = 59;
			this.lbPushMode.Text = "PUSH";
			this.lbPushMode.TextAlign = ContentAlignment.MiddleCenter;
			this.lbPushMode.Click += new EventHandler(this.lbPushMode_Click);
			this.tmerServer.Interval = 1000;
			this.tmerServer.Tick += new EventHandler(this.tmerServer_Tick);
			this.alertStockControl.AlterMessageCount = 0;
			this.alertStockControl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.alertStockControl.BackColor = Color.Transparent;
			this.alertStockControl.BlinkColor = Color.OrangeRed;
			this.alertStockControl.BlinkImage = (Image)componentResourceManager.GetObject("alertStockControl.BlinkImage");
			this.alertStockControl.Border = BorderStyle.None;
			this.alertStockControl.DisplayImage = (Image)componentResourceManager.GetObject("alertStockControl.DisplayImage");
			this.alertStockControl.ForeColor = SystemColors.Control;
			this.alertStockControl.IsAllowBlink = false;
			this.alertStockControl.IsStarted = false;
			this.alertStockControl.Location = new Point(70, 3);
			this.alertStockControl.Margin = new Padding(1, 0, 1, 0);
			this.alertStockControl.Name = "alertStockControl";
			this.alertStockControl.NormalColor = Color.Transparent;
			this.alertStockControl.NormalImage = (Image)componentResourceManager.GetObject("alertStockControl.NormalImage");
			this.alertStockControl.Size = new Size(40, 39);
			this.alertStockControl.TabIndex = 58;
			this.alertStockControl.AlertClick += new EventHandler(this.alertStockControl_AlertClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.Controls.Add(this.lbTimerServer);
			base.Controls.Add(this.lbPushMode);
			base.Controls.Add(this.alertStockControl);
			base.Name = "ucMarketStateBox";
			base.Size = new Size(168, 46);
			base.Load += new EventHandler(this.ucMarketStateBox_Load);
			base.Paint += new PaintEventHandler(this.ucMarketStateBox_Paint);
			base.Resize += new EventHandler(this.ucMarketStateBox_Resize);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600059A RID: 1434 RVA: 0x00065484 File Offset: 0x00063884
		// (remove) Token: 0x0600059B RID: 1435 RVA: 0x000654AC File Offset: 0x000638AC
        public ucMarketStateBox.SwitchMode _OnSitchMode;
		public event ucMarketStateBox.SwitchMode OnSitchMode
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._OnSitchMode += value;
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
                this._OnSitchMode -= value;
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600059C RID: 1436 RVA: 0x000654D4 File Offset: 0x000638D4
		// (remove) Token: 0x0600059D RID: 1437 RVA: 0x000654FC File Offset: 0x000638FC
		public ucMarketStateBox.CallAlert _OnCallAlert;
		public event ucMarketStateBox.CallAlert OnCallAlert
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				this._OnCallAlert += value;
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				this._OnCallAlert -= value;
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00065524 File Offset: 0x00063924
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ucMarketStateBox() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			
			this.InitializeComponent();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00065550 File Offset: 0x00063950
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucMarketStateBox_Load(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (ApplicationInfo.MarketTime == DateTime.MinValue)
			{
				ApplicationInfo.MarketTime = DateTime.Now;
			}
			if (!base.DesignMode)
			{
				this.tmerServer.Start();
			}
			base.Width = this.lbPushMode.Right + 5;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000655C0 File Offset: 0x000639C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void lbPushMode_Click(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (ApplicationInfo.IsPushMode)
				{
					ApplicationInfo.TunnelCounter++;
					if (ApplicationInfo.TunnelCounter > ApplicationInfo.TunnelHosts.Count - 1)
					{
						ApplicationInfo.IsPushMode = false;
						for (int i = 0; i < ApplicationInfo.TunnelHosts.Count; i++)
						{
							ApplicationInfo.TunnelHosts[i].IsAlreadyStart = false;
						}
						ApplicationInfo.TunnelCounter = 0;
					}
				}
				else
				{
					ApplicationInfo.IsPushMode = true;
					ApplicationInfo.TunnelCounter = 0;
				}
				if (this._OnSitchMode != null)
				{
					this._OnSitchMode();
				}
			}
			catch (Exception ex)
			{
				this.ShowError("ucSETSwep_OnPushPullChanged", ex);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000656B4 File Offset: 0x00063AB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowError(string methodName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, methodName, ex.Message, ex.ToString()));
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000656E8 File Offset: 0x00063AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void alertStockControl_AlertClick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this._OnCallAlert != null)
			{
				this.alertStockControl.IsAllowBlink = false;
				this.alertStockControl.AlterMessageCount = 0;
				this._OnCallAlert();
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0006573C File Offset: 0x00063B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucMarketStateBox_Paint(object sender, PaintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.DrawFeedStatus(e.Graphics);
				e.Graphics.DrawRectangle(Pens.DimGray, 0, 0, base.Width - 1, base.Height - 1);
			}
			catch
			{
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000657A8 File Offset: 0x00063BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawFeedStatus(Graphics e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				e.FillRectangle(this._feedColor, new Rectangle(this.lbPushMode.Left - 10, this.lbPushMode.Top + 1, 7, this.lbPushMode.Height - 2));
			}
			catch
			{
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00065820 File Offset: 0x00063C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowFeedsState(bool isFeeding)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ucMarketStateBox.ShowFeedsStateCallback(this.ShowFeedsState), new object[]
				{
					isFeeding
				});
			}
			else
			{
				if (ApplicationInfo.IsFeedsStarted)
				{
					this._feedColor = new SolidBrush(Color.Lime);
				}
				else
				{
					this._feedColor = new SolidBrush(Color.Red);
				}
				base.Invalidate();
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000658B4 File Offset: 0x00063CB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisplayPushPullImage()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.lbPushMode.InvokeRequired)
			{
				this.lbPushMode.Invoke(new MethodInvoker(this.DisplayPushPullImage));
			}
			else
			{
				try
				{
					if (ApplicationInfo.IsPushMode)
					{
						this.lbPushMode.Text = "PUSH";
						string caption = ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].HostIP + ":" + ApplicationInfo.TunnelHosts[ApplicationInfo.TunnelCounter].Port;
						this.toolTip1.SetToolTip(this.lbPushMode, caption);
					}
					else
					{
						this.lbPushMode.Text = "PULL";
						this.toolTip1.SetToolTip(this.lbPushMode, "PULL");
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000659C0 File Offset: 0x00063DC0
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x000659F0 File Offset: 0x00063DF0
		public bool IsAllowBlinkAlert
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.alertStockControl.IsAllowBlink;
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
					this.alertStockControl.IsAllowBlink = value;
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00065A28 File Offset: 0x00063E28
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00065A58 File Offset: 0x00063E58
		public bool IsAlertStart
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.alertStockControl.IsStarted;
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
					this.alertStockControl.IsStarted = value;
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00065A90 File Offset: 0x00063E90
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00065AC0 File Offset: 0x00063EC0
		public int AlterMessageCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.alertStockControl.AlterMessageCount;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.alertStockControl.AlterMessageCount = value;
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00065AE0 File Offset: 0x00063EE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tmerServer_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ApplicationInfo.MarketTime = ApplicationInfo.MarketTime.AddSeconds(1.0);
				this.lbTimerServer.Text = ApplicationInfo.MarketTime.ToString("HH:mm:ss");
			}
			catch
			{
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00065B58 File Offset: 0x00063F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ucMarketStateBox_Resize(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.lbPushMode.Top = (base.Height - this.lbPushMode.Height) / 2;
		}

		// Token: 0x0400032E RID: 814
		private IContainer components;

		// Token: 0x0400032F RID: 815
		private Label lbTimerServer;

		// Token: 0x04000330 RID: 816
		private Label lbPushMode;

		// Token: 0x04000331 RID: 817
		private AlertStockUC alertStockControl;

		// Token: 0x04000332 RID: 818
		private ToolTip toolTip1;

		// Token: 0x04000333 RID: 819
		private Timer tmerServer;

		// Token: 0x04000336 RID: 822
		private SolidBrush _feedColor;

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060005B0 RID: 1456
		public delegate void SwitchMode();

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060005B4 RID: 1460
		public delegate void CallAlert();

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060005B8 RID: 1464
		private delegate void ShowFeedsStateCallback(bool isFeeding);
	}
}
