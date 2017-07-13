using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001F6 RID: 502
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_ConfirmByStockCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012A4 RID: 4772 RVA: 0x000F9840 File Offset: 0x000F7C40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_ConfirmByStockCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x000F986C File Offset: 0x000F7C6C
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

		// Token: 0x040009DC RID: 2524
		private object[] results;
	}
}
