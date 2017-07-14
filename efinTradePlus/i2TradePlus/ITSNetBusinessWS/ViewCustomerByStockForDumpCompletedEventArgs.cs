using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000119 RID: 281
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class ViewCustomerByStockForDumpCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600100C RID: 4108 RVA: 0x000F6D48 File Offset: 0x000F5148
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomerByStockForDumpCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x000F6D74 File Offset: 0x000F5174
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

		// Token: 0x0400096E RID: 2414
		private object[] results;
	}
}
