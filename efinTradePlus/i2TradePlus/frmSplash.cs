using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using ITSNet.Wins.Controls;

namespace i2TradePlus
{
	// Token: 0x02000055 RID: 85
	public class frmSplash : Form
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x0003EE9C File Offset: 0x0003D29C
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

		// Token: 0x060003FA RID: 1018 RVA: 0x0003EEEC File Offset: 0x0003D2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeComponent()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.lblTask = new Label();
			this.lccSplash = new LoadingCircleControl();
			base.SuspendLayout();
			this.lblTask.Dock = DockStyle.Fill;
			this.lblTask.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
			this.lblTask.ForeColor = Color.Black;
			this.lblTask.Location = new Point(40, 0);
			this.lblTask.Margin = new Padding(4, 0, 4, 0);
			this.lblTask.Name = "lblTask";
			this.lblTask.Size = new Size(324, 46);
			this.lblTask.TabIndex = 3;
			this.lblTask.Text = "..";
			this.lblTask.TextAlign = ContentAlignment.MiddleCenter;
			this.lccSplash.Active = false;
			this.lccSplash.Color = SystemColors.InactiveCaption;
			this.lccSplash.Dock = DockStyle.Left;
			this.lccSplash.InnerCircleRadius = 8;
			this.lccSplash.Location = new Point(0, 0);
			this.lccSplash.Margin = new Padding(4, 4, 4, 4);
			this.lccSplash.Name = "lccSplash";
			this.lccSplash.NumberSpoke = 10;
			this.lccSplash.OuterCircleRadius = 10;
			this.lccSplash.RotationSpeed = 100;
			this.lccSplash.Size = new Size(40, 46);
			this.lccSplash.SpokeThickness = 4;
			this.lccSplash.TabIndex = 2;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(364, 46);
			base.ControlBox = false;
			base.Controls.Add(this.lblTask);
			base.Controls.Add(this.lccSplash);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Margin = new Padding(4, 4, 4, 4);
			base.Name = "frmSplash";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.Manual;
			base.TopMost = true;
			base.ResumeLayout(false);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0003F15C File Offset: 0x0003D55C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public frmSplash() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.components = null;
			
			this.InitializeComponent();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0003F188 File Offset: 0x0003D588
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisposeMe()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.lccSplash.InvokeRequired)
			{
				this.lccSplash.BeginInvoke(new MethodInvoker(this.DisposeMe));
			}
			else if (!base.IsDisposed)
			{
				this.lccSplash.Enabled = false;
				this.lccSplash.Dispose();
				base.Close();
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0003F20C File Offset: 0x0003D60C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentTask(string currentTask)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new frmSplash.SetCurrentTaskCallBack(this.SetCurrentTask), new object[]
				{
					currentTask
				});
			}
			else if (!base.IsDisposed)
			{
				this.lblTask.Text = currentTask;
				base.Show();
				base.BringToFront();
				this.lccSplash.Active = true;
				this.Refresh();
			}
		}

		// Token: 0x04000247 RID: 583
		private IContainer components;

		// Token: 0x04000248 RID: 584
		private Label lblTask;

		// Token: 0x04000249 RID: 585
		private LoadingCircleControl lccSplash;

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060003FF RID: 1023
		private delegate void SetCurrentTaskCallBack(string currentTask);
	}
}
