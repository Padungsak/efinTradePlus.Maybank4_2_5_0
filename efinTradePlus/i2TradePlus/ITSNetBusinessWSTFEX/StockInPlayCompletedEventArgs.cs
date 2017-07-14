using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000290 RID: 656
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class StockInPlayCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600177E RID: 6014 RVA: 0x00144398 File Offset: 0x00142798
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StockInPlayCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x001443C4 File Offset: 0x001427C4
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

		// Token: 0x04000BEE RID: 3054
		private object[] results;
	}
}
