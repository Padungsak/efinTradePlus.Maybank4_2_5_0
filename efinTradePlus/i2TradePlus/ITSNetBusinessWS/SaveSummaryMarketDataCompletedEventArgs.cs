using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200016D RID: 365
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class SaveSummaryMarketDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001108 RID: 4360 RVA: 0x000F7DB0 File Offset: 0x000F61B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveSummaryMarketDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000F7DDC File Offset: 0x000F61DC
		public int Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (int)this.results[0];
			}
		}

		// Token: 0x04000998 RID: 2456
		private object[] results;
	}
}
