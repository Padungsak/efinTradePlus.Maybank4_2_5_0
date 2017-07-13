using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200016F RID: 367
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class GetStockIndicatorCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600110E RID: 4366 RVA: 0x000F7E14 File Offset: 0x000F6214
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetStockIndicatorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000F7E40 File Offset: 0x000F6240
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

		// Token: 0x04000999 RID: 2457
		private object[] results;
	}
}
