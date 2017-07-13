using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200014D RID: 333
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class ViewAutoTradeDCAItemsCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010A8 RID: 4264 RVA: 0x000F7770 File Offset: 0x000F5B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewAutoTradeDCAItemsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x000F779C File Offset: 0x000F5B9C
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

		// Token: 0x04000988 RID: 2440
		private object[] results;
	}
}
