using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001EC RID: 492
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class ViewCustomer_RealizeProfitLossCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001286 RID: 4742 RVA: 0x000F964C File Offset: 0x000F7A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_RealizeProfitLossCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x000F9678 File Offset: 0x000F7A78
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

		// Token: 0x040009D7 RID: 2519
		private object[] results;
	}
}
