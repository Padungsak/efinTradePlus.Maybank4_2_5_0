using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000139 RID: 313
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class GetSetIndexChartImageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600106C RID: 4204 RVA: 0x000F7388 File Offset: 0x000F5788
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetSetIndexChartImageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x000F73B4 File Offset: 0x000F57B4
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

		// Token: 0x0400097E RID: 2430
		private object[] results;
	}
}
