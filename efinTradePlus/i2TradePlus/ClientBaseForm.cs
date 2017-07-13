using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;
using STIControl.CustomGrid;
using STIControl.ExpandTableGrid;
using STIControl.SortTableGrid;

namespace i2TradePlus
{
	// Token: 0x02000009 RID: 9
	public class ClientBaseForm : Form
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00008214 File Offset: 0x00006614
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Dispose(bool disposing)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.timerLoading != null)
			{
				this.timerLoading.Stop();
				this.timerLoading.Dispose();
				this.timerLoading = null;
			}
			if (this.propertiesValue != null)
			{
				this.propertiesValue.Clear();
				this.propertiesValue = null;
			}
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000082B8 File Offset: 0x000066B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.lbLoading = new Label();
			base.SuspendLayout();
			this.lbLoading.AutoSize = true;
			this.lbLoading.BackColor = Color.FromArgb(64, 64, 64);
			this.lbLoading.BorderStyle = BorderStyle.FixedSingle;
			this.lbLoading.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.lbLoading.ForeColor = Color.Yellow;
			this.lbLoading.Location = new Point(117, 118);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Padding = new Padding(5, 3, 5, 3);
			this.lbLoading.Size = new Size(76, 23);
			this.lbLoading.TabIndex = 6;
			this.lbLoading.Text = "Loading ...";
			this.lbLoading.TextAlign = ContentAlignment.MiddleCenter;
			this.lbLoading.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(290, 250);
			base.Controls.Add(this.lbLoading);
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ClientBaseForm";
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "ClientBaseForm";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000846C File Offset: 0x0000686C
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00008498 File Offset: 0x00006898
		public bool IsLoadingData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isLoadingData;
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
					this.isLoadingData = value;
					this.ShowSplash(this.isLoadingData);
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000084D8 File Offset: 0x000068D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ShowSplash(bool visible)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ClientBaseForm.ShowSplashCallBack(this.ShowSplash), new object[]
				{
					visible
				});
			}
			else if (!base.DesignMode)
			{
				if (ApplicationInfo.SuuportSplash == "Y")
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
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000085D4 File Offset: 0x000069D4
		public bool IsAllowRender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isAllowRender;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00008600 File Offset: 0x00006A00
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00008648 File Offset: 0x00006A48
		public Dictionary<string, object> PropertiesValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				if (this.propertiesValue == null)
				{
					this.propertiesValue = new Dictionary<string, object>();
				}
				return this.propertiesValue;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.propertiesValue = value;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000049 RID: 73 RVA: 0x00008660 File Offset: 0x00006A60
		// (remove) Token: 0x0600004A RID: 74 RVA: 0x00008688 File Offset: 0x00006A88
		public event ClientBaseForm.OnReActiveEventHandler IDoReActivated
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoReActivated = (ClientBaseForm.OnReActiveEventHandler)Delegate.Combine(this.IDoReActivated, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoReActivated = (ClientBaseForm.OnReActiveEventHandler)Delegate.Remove(this.IDoReActivated, value);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600004B RID: 75 RVA: 0x000086B0 File Offset: 0x00006AB0
		// (remove) Token: 0x0600004C RID: 76 RVA: 0x000086D8 File Offset: 0x00006AD8
		public event ClientBaseForm.CustomSizeChangedEventHandler IDoCustomSizeChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoCustomSizeChanged = (ClientBaseForm.CustomSizeChangedEventHandler)Delegate.Combine(this.IDoCustomSizeChanged, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoCustomSizeChanged = (ClientBaseForm.CustomSizeChangedEventHandler)Delegate.Remove(this.IDoCustomSizeChanged, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600004D RID: 77 RVA: 0x00008700 File Offset: 0x00006B00
		// (remove) Token: 0x0600004E RID: 78 RVA: 0x00008728 File Offset: 0x00006B28
		public event ClientBaseForm.OnShownDelayEventHandler IDoShownDelay
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoShownDelay = (ClientBaseForm.OnShownDelayEventHandler)Delegate.Combine(this.IDoShownDelay, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoShownDelay = (ClientBaseForm.OnShownDelayEventHandler)Delegate.Remove(this.IDoShownDelay, value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600004F RID: 79 RVA: 0x00008750 File Offset: 0x00006B50
		// (remove) Token: 0x06000050 RID: 80 RVA: 0x00008778 File Offset: 0x00006B78
		public event ClientBaseForm.OnFormKeyUpEventHandler IDoMainFormKeyUp
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoMainFormKeyUp = (ClientBaseForm.OnFormKeyUpEventHandler)Delegate.Combine(this.IDoMainFormKeyUp, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoMainFormKeyUp = (ClientBaseForm.OnFormKeyUpEventHandler)Delegate.Remove(this.IDoMainFormKeyUp, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000051 RID: 81 RVA: 0x000087A0 File Offset: 0x00006BA0
		// (remove) Token: 0x06000052 RID: 82 RVA: 0x000087C8 File Offset: 0x00006BC8
		public event ClientBaseForm.OnSymbolLinkEventHandler IDoSymbolLinked
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoSymbolLinked = (ClientBaseForm.OnSymbolLinkEventHandler)Delegate.Combine(this.IDoSymbolLinked, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoSymbolLinked = (ClientBaseForm.OnSymbolLinkEventHandler)Delegate.Remove(this.IDoSymbolLinked, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000053 RID: 83 RVA: 0x000087F0 File Offset: 0x00006BF0
		// (remove) Token: 0x06000054 RID: 84 RVA: 0x00008818 File Offset: 0x00006C18
		public event ClientBaseForm.OnFontChangedEventHandler IDoFontChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoFontChanged = (ClientBaseForm.OnFontChangedEventHandler)Delegate.Combine(this.IDoFontChanged, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoFontChanged = (ClientBaseForm.OnFontChangedEventHandler)Delegate.Remove(this.IDoFontChanged, value);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000055 RID: 85 RVA: 0x00008840 File Offset: 0x00006C40
		// (remove) Token: 0x06000056 RID: 86 RVA: 0x00008868 File Offset: 0x00006C68
		public event ClientBaseForm.OnIDoLoadDataEventHandler IDoLoadData
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoLoadData = (ClientBaseForm.OnIDoLoadDataEventHandler)Delegate.Combine(this.IDoLoadData, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoLoadData = (ClientBaseForm.OnIDoLoadDataEventHandler)Delegate.Remove(this.IDoLoadData, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000057 RID: 87 RVA: 0x00008890 File Offset: 0x00006C90
		// (remove) Token: 0x06000058 RID: 88 RVA: 0x000088B8 File Offset: 0x00006CB8
		public event ClientBaseForm.OnHeaderChangedEventHandler IDoHeaderChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoHeaderChanged = (ClientBaseForm.OnHeaderChangedEventHandler)Delegate.Combine(this.IDoHeaderChanged, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.IDoHeaderChanged = (ClientBaseForm.OnHeaderChangedEventHandler)Delegate.Remove(this.IDoHeaderChanged, value);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000088E0 File Offset: 0x00006CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientBaseForm() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.FormState = ClientBaseForm.ClientBaseFormState.Opening;
			this.MyFont = Settings.Default.Default_Font;
			this.isLoadingData = true;
			this.isAllowRender = true;
			this.propertiesValue = null;
			this.isRaiseEventIDoFontChanged = false;
			this.timerLoading = null;
			this.IsWidthChanged = false;
			this.IsHeightChanged = false;
			this._allControls = null;
			base..ctor();
			this.SetControl();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008968 File Offset: 0x00006D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientBaseForm(Dictionary<string, object> propertiesValue) : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			this.FormState = ClientBaseForm.ClientBaseFormState.Opening;
			this.MyFont = Settings.Default.Default_Font;
			this.isLoadingData = true;
			this.isAllowRender = true;
			this.propertiesValue = null;
			this.isRaiseEventIDoFontChanged = false;
			this.timerLoading = null;
			this.IsWidthChanged = false;
			this.IsHeightChanged = false;
			this._allControls = null;
			base..ctor();
			this.SetControl();
			if (!base.DesignMode)
			{
				this.propertiesValue = propertiesValue;
				this.UnpackProperties();
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008A0C File Offset: 0x00006E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetControl()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.SetGlobalization();
				this.InitializeComponent();
				base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
				this.DoubleBuffered = false;
				base.UpdateStyles();
				if (!base.DesignMode)
				{
					this.SetAutoRepaint(false);
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetControl", ex);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008A94 File Offset: 0x00006E94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHeaderColor(bool isRedraw)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				foreach (Control control in base.Controls)
				{
					if (control.GetType() == typeof(SortGrid) || control.GetType() == typeof(ExpandGrid))
					{
						this.SetHeader(control, isRedraw);
					}
					else if (control.GetType() == typeof(Panel))
					{
						foreach (Control control2 in control.Controls)
						{
							if (control2.GetType() == typeof(SortGrid) || control2.GetType() == typeof(ExpandGrid))
							{
								this.SetHeader(control2, isRedraw);
							}
							else if (control2.GetType() == typeof(Panel))
							{
								foreach (Control control3 in control2.Controls)
								{
									if (control3.GetType() == typeof(SortGrid) || control3.GetType() == typeof(ExpandGrid))
									{
										this.SetHeader(control3, isRedraw);
									}
								}
							}
							else if (control2.GetType() == typeof(ucBids))
							{
								((ucBids)control2).SetHeaderColor(true);
							}
						}
					}
					else if (control.GetType() == typeof(ucBids))
					{
						((ucBids)control).SetHeaderColor(true);
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetHeaderBackColor", ex);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008DB4 File Offset: 0x000071B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetHeader(Control control, bool isRedraw)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (control.GetType() == typeof(ExpandGrid))
				{
					foreach (STIControl.ExpandTableGrid.ColumnItem current in ((ExpandGrid)control).Columns)
					{
						current.BackColor = Settings.Default.HeaderBackGColor;
						current.FontColor = Settings.Default.HeaderFontColor;
					}
					((ExpandGrid)control).GridColor = Settings.Default.GridColor;
					if (isRedraw)
					{
						((ExpandGrid)control).Redraw();
					}
				}
				else if (control.GetType() == typeof(SortGrid))
				{
					foreach (STIControl.SortTableGrid.ColumnItem current2 in ((SortGrid)control).Columns)
					{
						current2.BackColor = Settings.Default.HeaderBackGColor;
						current2.FontColor = Settings.Default.HeaderFontColor;
					}
					((SortGrid)control).GridColor = Settings.Default.GridColor;
					if (isRedraw)
					{
						((SortGrid)control).Redraw();
					}
				}
				if (this.IDoHeaderChanged != null)
				{
					this.IDoHeaderChanged();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00008FB0 File Offset: 0x000073B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetAutoRepaint(bool isAutoRepaint)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				foreach (Control control in base.Controls)
				{
					if (control.GetType() == typeof(SortGrid))
					{
						((SortGrid)control).IsAutoRepaint = isAutoRepaint;
					}
					else if (control.GetType() == typeof(ExpandGrid))
					{
						((ExpandGrid)control).IsAutoRepaint = isAutoRepaint;
					}
					else if (control.GetType() == typeof(IntzaCustomGrid))
					{
						((IntzaCustomGrid)control).IsAutoRepaint = isAutoRepaint;
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("SetAutoRepaint", ex);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000090E0 File Offset: 0x000074E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerLoading_Tick(object sender, EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.timerLoading.Enabled = false;
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				if (this.IDoLoadData != null)
				{
					this.IDoLoadData();
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00009140 File Offset: 0x00007540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenedForm()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.timerLoading == null)
				{
					this.timerLoading = new System.Windows.Forms.Timer();
					this.timerLoading.Interval = 100;
					this.timerLoading.Tick += new EventHandler(this.timerLoading_Tick);
				}
				this.timerLoading.Enabled = false;
				this.timerLoading.Enabled = true;
			}
			catch (Exception ex)
			{
				this.ShowError("OpenedForm", ex);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000091EC File Offset: 0x000075EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenForm(bool isFirstOpen)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				this.SetHeaderColor(false);
				if (isFirstOpen)
				{
					this.SetFontToControl(Settings.Default.Default_Font);
					this.isRaiseEventIDoFontChanged = true;
					this.FormState = ClientBaseForm.ClientBaseFormState.Showed;
					base.Bounds = ((frmMain)base.Parent).GetWorkingArea();
					if (this.IDoShownDelay != null)
					{
						this.IDoShownDelay();
					}
				}
				else if (this.FormState != ClientBaseForm.ClientBaseFormState.Opening)
				{
					this.SetAutoRepaint(true);
					if (!ApplicationInfo.IsAreadyLogin)
					{
						return;
					}
					this.FormState = ClientBaseForm.ClientBaseFormState.Showed;
					this.IsWidthChanged = false;
					if (this.MyFont != Settings.Default.Default_Font)
					{
						this.isRaiseEventIDoFontChanged = false;
						this.SetFontToControl(Settings.Default.Default_Font);
						this.isRaiseEventIDoFontChanged = true;
						this.IsWidthChanged = true;
					}
					if (this.IDoReActivated != null)
					{
						Rectangle workingArea = ((frmMain)base.Parent).GetWorkingArea();
						if (!this.IsWidthChanged)
						{
							this.IsWidthChanged = (workingArea.Width > 0 && workingArea.Width != base.Width);
						}
						if (this.IsWidthChanged)
						{
							base.Width = workingArea.Width;
						}
						if (!this.IsHeightChanged)
						{
							this.IsHeightChanged = (workingArea.Height > 0 && workingArea.Height != base.Height);
						}
						if (this.IsHeightChanged)
						{
							base.Height = workingArea.Height;
						}
						base.Bounds = workingArea;
						this.IDoReActivated();
					}
				}
				this.isAllowRender = true;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000093F4 File Offset: 0x000077F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideForm()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.isAllowRender = false;
			this.FormState = ClientBaseForm.ClientBaseFormState.Hide;
			this.SetAutoRepaint(false);
			this.IsLoadingData = false;
			base.Hide();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000942C File Offset: 0x0000782C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFormSize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
				{
					Rectangle workingArea = ((frmMain)base.Parent).GetWorkingArea();
					this.IsWidthChanged = (workingArea.Width > 0 && workingArea.Width != base.Width);
					this.IsHeightChanged = (workingArea.Height > 0 && workingArea.Height != base.Height);
					base.Bounds = workingArea;
					if (this.IDoCustomSizeChanged != null)
					{
						if (this.IsWidthChanged || this.IsHeightChanged)
						{
							this.IDoCustomSizeChanged();
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000952C File Offset: 0x0000792C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClosing(CancelEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.FormState = ClientBaseForm.ClientBaseFormState.Closing;
			this.isLoadingData = true;
			if (this.timerLoading != null)
			{
				this.timerLoading.Enabled = false;
			}
			base.OnClosing(e);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000957C File Offset: 0x0000797C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.FormState != ClientBaseForm.ClientBaseFormState.Closing)
			{
				if (this.FormState == ClientBaseForm.ClientBaseFormState.Showed)
				{
					base.OnPaint(e);
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000095CC File Offset: 0x000079CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnFontChanged(EventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.MyFont = Settings.Default.Default_Font;
			base.OnFontChanged(e);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000095F8 File Offset: 0x000079F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetGlobalization()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (!base.DesignMode)
			{
				CultureInfo cultureInfo = new CultureInfo("en-US");
				cultureInfo.DateTimeFormat.LongTimePattern = "HH:mm:ss";
				Thread.CurrentThread.CurrentCulture = cultureInfo;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000964C File Offset: 0x00007A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFontToControl(Font newFont)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.Invoke(new ClientBaseForm.SetFontToControlCallBack(this.SetFontToControl), new object[]
				{
					newFont
				});
			}
			else
			{
				try
				{
					this.MyFont = newFont;
					if (this._allControls == null)
					{
						this._allControls = this.GetSelfAndChildrenRecursive(this);
					}
					foreach (Control current in this._allControls)
					{
						if (current.Tag == null)
						{
							if (current.GetType() == typeof(ToolStrip))
							{
								this.setToolStripFont(current as ToolStrip);
							}
							else if (current.GetType() != typeof(Panel))
							{
								current.Font = newFont;
							}
						}
					}
					if (this.isRaiseEventIDoFontChanged && this.IDoFontChanged != null)
					{
						this.IsWidthChanged = true;
						this.IsHeightChanged = true;
						this.IDoFontChanged();
					}
				}
				catch (Exception ex)
				{
					this.ShowError("SetControlFont", ex);
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00009804 File Offset: 0x00007C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Control> GetSelfAndChildrenRecursive(Control parent)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			List<Control> list = new List<Control>();
			foreach (Control control in parent.Controls)
			{
				if (control.GetType() == typeof(ToolStrip))
				{
					list.Add(control);
				}
				else
				{
					list.AddRange(this.GetSelfAndChildrenRecursive(control));
				}
			}
			list.Add(parent);
			return list;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000098D4 File Offset: 0x00007CD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setToolStripFont(ToolStrip control)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (control.Tag != null && control.Tag.ToString() == "-1")
				{
					Font font = new Font(Settings.Default.Default_Font.Name, Settings.Default.Default_Font.Size - 1f, FontStyle.Regular);
					control.Font = font;
					foreach (ToolStripItem toolStripItem in control.Items)
					{
						toolStripItem.Font = font;
					}
				}
				else
				{
					control.Font = Settings.Default.Default_Font;
					foreach (ToolStripItem toolStripItem2 in control.Items)
					{
						if (toolStripItem2.Tag != null && toolStripItem2.Tag.ToString() == "0")
						{
							toolStripItem2.Font = new Font("Wingdings", Settings.Default.Default_Font.Size);
						}
						else if (toolStripItem2.Tag != null && toolStripItem2.Tag.ToString() == "S")
						{
							toolStripItem2.Font = new Font("Tempus Sans ITC", Settings.Default.Default_Font.Size);
						}
						else
						{
							toolStripItem2.Font = Settings.Default.Default_Font;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.ShowError("setToolStripFont", ex);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009B50 File Offset: 0x00007F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, object> PackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.propertiesValue == null)
			{
				this.propertiesValue = new Dictionary<string, object>();
			}
			return this.DoPackProperties();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00009B98 File Offset: 0x00007F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnpackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.DoUnpackProperties();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00009BB0 File Offset: 0x00007FB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveKeyupMainForm(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.IDoMainFormKeyUp != null)
			{
				this.IDoMainFormKeyUp(e);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00009BEC File Offset: 0x00007FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSymbolLink(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.IDoSymbolLinked != null)
			{
				this.IDoSymbolLinked(sender, source, newStock);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00009C28 File Offset: 0x00008028
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Dictionary<string, object> DoPackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return this.propertiesValue;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00009C54 File Offset: 0x00008054
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void DoUnpackProperties()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00009C68 File Offset: 0x00008068
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ShowError(string functionName, Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ExceptionManager.Show(new ErrorItem(DateTime.Now, base.Name, functionName, ex.Message, ex.ToString()));
		}

		// Token: 0x04000040 RID: 64
		private IContainer components;

		// Token: 0x04000041 RID: 65
		private Label lbLoading;

		// Token: 0x04000042 RID: 66
		public ClientBaseForm.ClientBaseFormState FormState;

		// Token: 0x04000043 RID: 67
		private Font MyFont;

		// Token: 0x04000044 RID: 68
		private bool isLoadingData;

		// Token: 0x04000045 RID: 69
		private bool isAllowRender;

		// Token: 0x04000046 RID: 70
		private Dictionary<string, object> propertiesValue;

		// Token: 0x0400004F RID: 79
		private bool isRaiseEventIDoFontChanged;

		// Token: 0x04000050 RID: 80
		private System.Windows.Forms.Timer timerLoading;

		// Token: 0x04000051 RID: 81
		public bool IsWidthChanged;

		// Token: 0x04000052 RID: 82
		public bool IsHeightChanged;

		// Token: 0x04000053 RID: 83
		private List<Control> _allControls;

		// Token: 0x0200000A RID: 10
		public enum ClientBaseFormState
		{
			// Token: 0x04000055 RID: 85
			Opening,
			// Token: 0x04000056 RID: 86
			Showed,
			// Token: 0x04000057 RID: 87
			Closing,
			// Token: 0x04000058 RID: 88
			Hide
		}

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000073 RID: 115
		private delegate void ShowSplashCallBack(bool visible);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000077 RID: 119
		public delegate void OnReActiveEventHandler();

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600007B RID: 123
		public delegate void CustomSizeChangedEventHandler();

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600007F RID: 127
		public delegate void OnShownDelayEventHandler();

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000083 RID: 131
		public delegate void OnFormKeyUpEventHandler(KeyEventArgs e);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000087 RID: 135
		public delegate void OnSymbolLinkEventHandler(object sender, SymbolLinkSource source, string newStock);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600008B RID: 139
		public delegate void OnFontChangedEventHandler();

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600008F RID: 143
		public delegate void OnIDoLoadDataEventHandler();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000093 RID: 147
		public delegate void OnHeaderChangedEventHandler();

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000097 RID: 151
		private delegate void SetFontToControlCallBack(Font newFont);
	}
}
