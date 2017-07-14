using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001D8 RID: 472
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class ViewCustomerCreditOnSendBoxCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600124A RID: 4682 RVA: 0x000F9264 File Offset: 0x000F7664
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomerCreditOnSendBoxCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x000F9290 File Offset: 0x000F7690
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

		// Token: 0x040009CD RID: 2509
		private object[] results;
	}
}
