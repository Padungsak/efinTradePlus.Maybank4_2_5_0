using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000272 RID: 626
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class GetTotalMarketValueInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001724 RID: 5924 RVA: 0x00143DBC File Offset: 0x001421BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetTotalMarketValueInfoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00143DE8 File Offset: 0x001421E8
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

		// Token: 0x04000BDF RID: 3039
		private object[] results;
	}
}
