using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200018A RID: 394
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class BestBidOfferCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x000F8328 File Offset: 0x000F6728
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BestBidOfferCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x000F8354 File Offset: 0x000F6754
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

		// Token: 0x040009A6 RID: 2470
		private object[] results;
	}
}
