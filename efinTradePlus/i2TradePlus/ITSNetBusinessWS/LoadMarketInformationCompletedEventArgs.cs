using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000182 RID: 386
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class LoadMarketInformationCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001148 RID: 4424 RVA: 0x000F8198 File Offset: 0x000F6598
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadMarketInformationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x000F81C4 File Offset: 0x000F65C4
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

		// Token: 0x040009A2 RID: 2466
		private object[] results;
	}
}
