using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001E0 RID: 480
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class ViewCustomer_CreditPositionCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001262 RID: 4706 RVA: 0x000F93F4 File Offset: 0x000F77F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_CreditPositionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x000F9420 File Offset: 0x000F7820
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

		// Token: 0x040009D1 RID: 2513
		private object[] results;
	}
}
