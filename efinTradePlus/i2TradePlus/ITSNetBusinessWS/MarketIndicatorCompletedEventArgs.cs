using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001AA RID: 426
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class MarketIndicatorCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011C0 RID: 4544 RVA: 0x000F8968 File Offset: 0x000F6D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal MarketIndicatorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x000F8994 File Offset: 0x000F6D94
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

		// Token: 0x040009B6 RID: 2486
		private object[] results;
	}
}
