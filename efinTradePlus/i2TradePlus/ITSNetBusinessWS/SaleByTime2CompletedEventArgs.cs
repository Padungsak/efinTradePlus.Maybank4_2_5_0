using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001B8 RID: 440
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class SaleByTime2CompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011EA RID: 4586 RVA: 0x000F8C24 File Offset: 0x000F7024
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaleByTime2CompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x000F8C50 File Offset: 0x000F7050
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

		// Token: 0x040009BD RID: 2493
		private object[] results;
	}
}
