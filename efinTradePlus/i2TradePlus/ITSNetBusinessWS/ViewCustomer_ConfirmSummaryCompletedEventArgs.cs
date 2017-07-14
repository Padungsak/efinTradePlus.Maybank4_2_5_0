using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001F0 RID: 496
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_ConfirmSummaryCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001292 RID: 4754 RVA: 0x000F9714 File Offset: 0x000F7B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_ConfirmSummaryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x000F9740 File Offset: 0x000F7B40
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

		// Token: 0x040009D9 RID: 2521
		private object[] results;
	}
}
