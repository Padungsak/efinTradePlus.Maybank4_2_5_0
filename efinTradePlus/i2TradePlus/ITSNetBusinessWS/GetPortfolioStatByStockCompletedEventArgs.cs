using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200013D RID: 317
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class GetPortfolioStatByStockCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001078 RID: 4216 RVA: 0x000F7450 File Offset: 0x000F5850
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetPortfolioStatByStockCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x000F747C File Offset: 0x000F587C
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

		// Token: 0x04000980 RID: 2432
		private object[] results;
	}
}
