using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000280 RID: 640
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class BestBidOfferByListCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600174E RID: 5966 RVA: 0x00144078 File Offset: 0x00142478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BestBidOfferByListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x001440A4 File Offset: 0x001424A4
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

		// Token: 0x04000BE6 RID: 3046
		private object[] results;
	}
}
