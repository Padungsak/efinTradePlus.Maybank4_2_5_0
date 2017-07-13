using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001DE RID: 478
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class ViewCustomer_OrdersConfirmsCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600125C RID: 4700 RVA: 0x000F9390 File Offset: 0x000F7790
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_OrdersConfirmsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000F93BC File Offset: 0x000F77BC
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

		// Token: 0x040009D0 RID: 2512
		private object[] results;
	}
}
