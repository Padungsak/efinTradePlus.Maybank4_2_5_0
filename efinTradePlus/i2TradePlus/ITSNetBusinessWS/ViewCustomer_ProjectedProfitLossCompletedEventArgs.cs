using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001E2 RID: 482
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ViewCustomer_ProjectedProfitLossCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001268 RID: 4712 RVA: 0x000F9458 File Offset: 0x000F7858
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_ProjectedProfitLossCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x000F9484 File Offset: 0x000F7884
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

		// Token: 0x040009D2 RID: 2514
		private object[] results;
	}
}
