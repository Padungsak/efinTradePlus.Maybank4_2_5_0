using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001E6 RID: 486
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ViewCustomer_BetaAnalysisCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x000F9520 File Offset: 0x000F7920
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_BetaAnalysisCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000F954C File Offset: 0x000F794C
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

		// Token: 0x040009D4 RID: 2516
		private object[] results;
	}
}
