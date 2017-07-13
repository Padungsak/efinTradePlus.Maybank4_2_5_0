using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001FC RID: 508
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ViewOrderDealDataHistoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012B6 RID: 4790 RVA: 0x000F996C File Offset: 0x000F7D6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderDealDataHistoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x000F9998 File Offset: 0x000F7D98
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

		// Token: 0x040009DF RID: 2527
		private object[] results;
	}
}
