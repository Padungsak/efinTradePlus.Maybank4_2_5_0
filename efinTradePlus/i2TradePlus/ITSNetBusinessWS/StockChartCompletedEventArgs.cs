using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000123 RID: 291
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class StockChartCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600102A RID: 4138 RVA: 0x000F6F3C File Offset: 0x000F533C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StockChartCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x000F6F68 File Offset: 0x000F5368
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

		// Token: 0x04000973 RID: 2419
		private object[] results;
	}
}
