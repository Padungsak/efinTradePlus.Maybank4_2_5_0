using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001E4 RID: 484
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_FScoreAnalysisCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600126E RID: 4718 RVA: 0x000F94BC File Offset: 0x000F78BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_FScoreAnalysisCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x000F94E8 File Offset: 0x000F78E8
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

		// Token: 0x040009D3 RID: 2515
		private object[] results;
	}
}
