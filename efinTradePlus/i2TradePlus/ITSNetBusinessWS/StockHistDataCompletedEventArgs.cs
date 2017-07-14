using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000125 RID: 293
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class StockHistDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001030 RID: 4144 RVA: 0x000F6FA0 File Offset: 0x000F53A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StockHistDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x000F6FCC File Offset: 0x000F53CC
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

		// Token: 0x04000974 RID: 2420
		private object[] results;
	}
}
