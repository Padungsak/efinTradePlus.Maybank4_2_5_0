using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000282 RID: 642
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class BestBidOfferByInstrumentCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001754 RID: 5972 RVA: 0x001440DC File Offset: 0x001424DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BestBidOfferByInstrumentCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x00144108 File Offset: 0x00142508
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

		// Token: 0x04000BE7 RID: 3047
		private object[] results;
	}
}
