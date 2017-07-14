using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001D6 RID: 470
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class ViewCustomerCreditOnSendBox_FreewillCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001244 RID: 4676 RVA: 0x000F9200 File Offset: 0x000F7600
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomerCreditOnSendBox_FreewillCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x000F922C File Offset: 0x000F762C
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

		// Token: 0x040009CC RID: 2508
		private object[] results;
	}
}
