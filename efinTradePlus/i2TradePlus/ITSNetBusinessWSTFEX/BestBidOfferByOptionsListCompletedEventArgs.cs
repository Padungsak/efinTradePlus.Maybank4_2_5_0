using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000284 RID: 644
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class BestBidOfferByOptionsListCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x00144140 File Offset: 0x00142540
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BestBidOfferByOptionsListCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x0014416C File Offset: 0x0014256C
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

		// Token: 0x04000BE8 RID: 3048
		private object[] results;
	}
}
