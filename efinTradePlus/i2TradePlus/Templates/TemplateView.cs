using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;

namespace i2TradePlus.Templates
{
	// Token: 0x020000C4 RID: 196
	internal class TemplateView
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x000B097C File Offset: 0x000AED7C
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x000B09A8 File Offset: 0x000AEDA8
		public TemplateView.ContentState CurrentState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.currentState;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.currentState = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x000B09C0 File Offset: 0x000AEDC0
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x000B09EC File Offset: 0x000AEDEC
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.name;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.name = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x000B0A04 File Offset: 0x000AEE04
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x000B0A30 File Offset: 0x000AEE30
		public Form FormObj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.formObj;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.formObj = value;
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000B0A48 File Offset: 0x000AEE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateView(string templateName)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.currentState = TemplateView.ContentState.Detached;
			this.name = string.Empty;
			this.formObj = null;
			this.isFirstOpen = true;
			base..ctor();
			this.name = templateName;
			this.currentState = TemplateView.ContentState.New;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000B0AA0 File Offset: 0x000AEEA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TemplateView.ContentState contentState = this.currentState;
			this.currentState = TemplateView.ContentState.OpeningOrClosing;
			(this.formObj as ClientBaseForm).OpenForm(this.isFirstOpen);
			this.currentState = contentState;
			this.isFirstOpen = false;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000B0AF0 File Offset: 0x000AEEF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			TemplateView.ContentState contentState = this.currentState;
			this.currentState = TemplateView.ContentState.OpeningOrClosing;
			((ClientBaseForm)this.formObj).HideForm();
			this.currentState = contentState;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000B0B34 File Offset: 0x000AEF34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendSymbolLink1(object sender, SymbolLinkSource source, string newStock)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.formObj.GetType() != sender.GetType())
			{
				((ClientBaseForm)this.formObj).SetSymbolLink(sender, source, newStock);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000B0B80 File Offset: 0x000AEF80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FormKeyUp(KeyEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				(this.formObj as ClientBaseForm).ReceiveKeyupMainForm(e);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000B0BD0 File Offset: 0x000AEFD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFont()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.formObj.GetType().BaseType == typeof(ClientBaseForm))
			{
				((ClientBaseForm)this.formObj).SetFontToControl(Settings.Default.Default_Font);
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000B0C30 File Offset: 0x000AF030
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFormSize()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (this.formObj.GetType().BaseType == typeof(ClientBaseForm))
			{
				((ClientBaseForm)this.formObj).SetFormSize();
			}
		}

		// Token: 0x040005CB RID: 1483
		private TemplateView.ContentState currentState;

		// Token: 0x040005CC RID: 1484
		private string name;

		// Token: 0x040005CD RID: 1485
		private Form formObj;

		// Token: 0x040005CE RID: 1486
		private bool isFirstOpen;

		// Token: 0x020000C5 RID: 197
		public enum ContentState
		{
			// Token: 0x040005D0 RID: 1488
			Detached,
			// Token: 0x040005D1 RID: 1489
			New,
			// Token: 0x040005D2 RID: 1490
			OpeningOrClosing,
			// Token: 0x040005D3 RID: 1491
			Unchanged
		}
	}
}
