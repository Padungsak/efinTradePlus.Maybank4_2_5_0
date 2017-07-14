using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;

namespace ITSNet.Wins.Controls
{
	// Token: 0x0200007E RID: 126
	internal class LoadingCircleControl : Control
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x00065B8C File Offset: 0x00063F8C
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00065BDC File Offset: 0x00063FDC
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00065C08 File Offset: 0x00064008
		[Category("LoadingCircle"), Description("Sets the color of spoke."), TypeConverter("System.Drawing.ColorConverter")]
		public Color Color
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.aColor;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.aColor = value;
				this.GenerateColorsPallet();
				base.Invalidate();
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00065C30 File Offset: 0x00064030
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00065C74 File Offset: 0x00064074
		[Description("Gets or sets the radius of outer circle."), Category("LoadingCircle")]
		public int OuterCircleRadius
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.aOuterCircleRadius == 0)
				{
					this.aOuterCircleRadius = 10;
				}
				return this.aOuterCircleRadius;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.aOuterCircleRadius = value;
				base.Invalidate();
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00065C94 File Offset: 0x00064094
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00065CD8 File Offset: 0x000640D8
		[Category("LoadingCircle"), Description("Gets or sets the radius of inner circle.")]
		public int InnerCircleRadius
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.aInnerCircleRadius == 0)
				{
					this.aInnerCircleRadius = 8;
				}
				return this.aInnerCircleRadius;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.aInnerCircleRadius = value;
				base.Invalidate();
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00065CF8 File Offset: 0x000640F8
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00065D3C File Offset: 0x0006413C
		[Description("Gets or sets the number of spoke."), Category("LoadingCircle")]
		public int NumberSpoke
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.aNumberOfSpoke == 0)
				{
					this.aNumberOfSpoke = 10;
				}
				return this.aNumberOfSpoke;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.aNumberOfSpoke != value && this.aNumberOfSpoke > 0)
				{
					this.aNumberOfSpoke = value;
					this.GenerateColorsPallet();
					this.GetSpokesAngles();
					base.Invalidate();
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00065D9C File Offset: 0x0006419C
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00065DC8 File Offset: 0x000641C8
		[Description("Gets or sets the number of spoke."), Category("LoadingCircle")]
		public bool Active
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.aTimerActive;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.aTimerActive = value;
				this.ActiveTimer();
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00065DE8 File Offset: 0x000641E8
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00065E28 File Offset: 0x00064228
		[Category("LoadingCircle"), Description("Gets or sets the thickness of a spoke.")]
		public int SpokeThickness
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.aSpokeThickness <= 0)
				{
					this.aSpokeThickness = 4;
				}
				return this.aSpokeThickness;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.aSpokeThickness = value;
				base.Invalidate();
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00065E48 File Offset: 0x00064248
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00065E78 File Offset: 0x00064278
		[Category("LoadingCircle"), Description("Gets or sets the rotation speed. Higher the slower.")]
		public int RotationSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.aTimer.Interval;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (value > 0)
				{
					this.aTimer.Interval = value;
				}
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00065EB0 File Offset: 0x000642B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoadingCircleControl() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.DEFAULT_COLOR = Color.DarkGray;
			
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.aColor = this.DEFAULT_COLOR;
			this.GenerateColorsPallet();
			this.GetSpokesAngles();
			this.GetControlCenterPoint();
			this.aTimer = new Timer();
			this.aTimer.Tick += new EventHandler(this.aTimer_Tick);
			this.ActiveTimer();
			base.Resize += new EventHandler(this.LoadingCircle_Resize);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00065F84 File Offset: 0x00064384
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadingCircle_Resize(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.GetControlCenterPoint();
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00065F9C File Offset: 0x0006439C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void aTimer_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.aProgressValue = ++this.aProgressValue % this.aNumberOfSpoke;
			base.Invalidate();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00065FE0 File Offset: 0x000643E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.aNumberOfSpoke > 0)
			{
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				int num = this.aProgressValue;
				for (int i = 0; i < this.aNumberOfSpoke; i++)
				{
					num %= this.aNumberOfSpoke;
					this.DrawLine(e.Graphics, this.GetCoordinate(this.aCenterPoint, this.aInnerCircleRadius, this.aAngles[num]), this.GetCoordinate(this.aCenterPoint, this.aOuterCircleRadius, this.aAngles[num]), this.aColors[i], this.aSpokeThickness);
					num++;
				}
			}
			base.OnPaint(e);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000660B0 File Offset: 0x000644B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Color Darken(Color _objColor, int _intPercent)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			int val = (int)_objColor.R - _intPercent * (int)(_objColor.R / 100);
			int val2 = (int)_objColor.G - _intPercent * (int)(_objColor.G / 100);
			int val3 = (int)_objColor.B - _intPercent * (int)(_objColor.B / 100);
			return Color.FromArgb(Math.Min(val, 255), Math.Min(val2, 255), Math.Min(val3, 255));
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00066138 File Offset: 0x00064538
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GenerateColorsPallet()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.aColors = this.GenerateColorsPallet(this.aColor, this.Active, (int)Math.Floor((double)this.aNumberOfSpoke / 3.0));
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00066178 File Offset: 0x00064578
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Color[] GenerateColorsPallet(Color _objColor, bool _blnShadeColor, int _intNbSpoke)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			Color[] array = new Color[this.NumberSpoke];
			for (int i = 0; i < this.NumberSpoke; i++)
			{
				if (_blnShadeColor)
				{
					if (i == 0 || i < this.NumberSpoke - _intNbSpoke)
					{
						array[i] = _objColor;
					}
					else
					{
						array[i] = this.Darken(array[i - 1], 10);
					}
				}
				else
				{
					array[i] = _objColor;
				}
			}
			return array;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00066238 File Offset: 0x00064638
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetControlCenterPoint()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.aCenterPoint = this.GetControlCenterPoint(this);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00066258 File Offset: 0x00064658
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PointF GetControlCenterPoint(Control _objControl)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return new PointF((float)(_objControl.Width / 2), (float)(_objControl.Height / 2));
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00066294 File Offset: 0x00064694
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawLine(Graphics _objGraphics, PointF _objPointOne, PointF _objPointTwo, Color _objColor, int _intLineThickness)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			_objGraphics.DrawLine(new Pen(new SolidBrush(_objColor), (float)_intLineThickness)
			{
				StartCap = LineCap.Round,
				EndCap = LineCap.Round
			}, _objPointOne, _objPointTwo);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000662DC File Offset: 0x000646DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PointF GetCoordinate(PointF _objCircleCenter, int _intRadius, double _dblAngle)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			PointF result = default(PointF);
			double num = 3.1415926535897931 * _dblAngle / 180.0;
			result.X = _objCircleCenter.X + (float)_intRadius * (float)Math.Cos(num);
			result.Y = _objCircleCenter.Y + (float)_intRadius * (float)Math.Sin(num);
			return result;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00066354 File Offset: 0x00064754
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetSpokesAngles()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.aAngles = this.GetSpokesAngles(this.NumberSpoke);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00066378 File Offset: 0x00064778
		[MethodImpl(MethodImplOptions.NoInlining)]
		private double[] GetSpokesAngles(int _shtNumberSpoke)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			double[] array = new double[_shtNumberSpoke];
			double num = (double)(360 / _shtNumberSpoke);
			for (int i = 0; i < _shtNumberSpoke; i++)
			{
				array[i] = ((i == 0) ? num : (array[i - 1] + num));
			}
			return array;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000663DC File Offset: 0x000647DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ActiveTimer()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.aTimerActive)
			{
				this.aTimer.Start();
			}
			else
			{
				this.aTimer.Stop();
				this.aProgressValue = 0;
			}
			this.GenerateColorsPallet();
			base.Invalidate();
		}

		// Token: 0x04000337 RID: 823
		private IContainer components;

		// Token: 0x04000338 RID: 824
		private Color DEFAULT_COLOR;

		// Token: 0x04000339 RID: 825
		private Timer aTimer;

		// Token: 0x0400033A RID: 826
		private bool aTimerActive;

		// Token: 0x0400033B RID: 827
		private int aNumberOfSpoke;

		// Token: 0x0400033C RID: 828
		private int aSpokeThickness;

		// Token: 0x0400033D RID: 829
		private int aProgressValue;

		// Token: 0x0400033E RID: 830
		private int aOuterCircleRadius;

		// Token: 0x0400033F RID: 831
		private int aInnerCircleRadius;

		// Token: 0x04000340 RID: 832
		private PointF aCenterPoint;

		// Token: 0x04000341 RID: 833
		private Color aColor;

		// Token: 0x04000342 RID: 834
		private Color[] aColors;

		// Token: 0x04000343 RID: 835
		private double[] aAngles;
	}
}
