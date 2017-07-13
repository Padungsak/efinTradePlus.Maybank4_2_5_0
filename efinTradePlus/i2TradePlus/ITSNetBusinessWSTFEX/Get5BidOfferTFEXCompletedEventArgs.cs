using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000286 RID: 646
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class Get5BidOfferTFEXCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001760 RID: 5984 RVA: 0x001441A4 File Offset: 0x001425A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Get5BidOfferTFEXCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x001441D0 File Offset: 0x001425D0
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

		// Token: 0x04000BE9 RID: 3049
		private object[] results;
	}
}
