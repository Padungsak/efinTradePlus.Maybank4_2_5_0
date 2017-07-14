using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200013B RID: 315
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetPortfolioStatAllStockCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001072 RID: 4210 RVA: 0x000F73EC File Offset: 0x000F57EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetPortfolioStatAllStockCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x000F7418 File Offset: 0x000F5818
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

		// Token: 0x0400097F RID: 2431
		private object[] results;
	}
}
