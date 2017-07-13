using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200014F RID: 335
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewAutoTradePzItemsCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010AE RID: 4270 RVA: 0x000F77D4 File Offset: 0x000F5BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewAutoTradePzItemsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x000F7800 File Offset: 0x000F5C00
		public string Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (string)this.results[0];
			}
		}

		// Token: 0x04000989 RID: 2441
		private object[] results;
	}
}
