using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000121 RID: 289
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class StockHistoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001024 RID: 4132 RVA: 0x000F6ED8 File Offset: 0x000F52D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StockHistoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x000F6F04 File Offset: 0x000F5304
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

		// Token: 0x04000972 RID: 2418
		private object[] results;
	}
}
