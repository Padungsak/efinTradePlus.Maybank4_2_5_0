using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001DC RID: 476
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_MobileReportAllCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x000F932C File Offset: 0x000F772C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_MobileReportAllCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x000F9358 File Offset: 0x000F7758
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

		// Token: 0x040009CF RID: 2511
		private object[] results;
	}
}
