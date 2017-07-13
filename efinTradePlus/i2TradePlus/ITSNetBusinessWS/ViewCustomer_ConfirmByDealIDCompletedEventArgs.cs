using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001F4 RID: 500
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_ConfirmByDealIDCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600129E RID: 4766 RVA: 0x000F97DC File Offset: 0x000F7BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_ConfirmByDealIDCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x000F9808 File Offset: 0x000F7C08
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

		// Token: 0x040009DB RID: 2523
		private object[] results;
	}
}
