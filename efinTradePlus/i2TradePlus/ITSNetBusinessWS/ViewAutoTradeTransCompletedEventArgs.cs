using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200014B RID: 331
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class ViewAutoTradeTransCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010A2 RID: 4258 RVA: 0x000F770C File Offset: 0x000F5B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewAutoTradeTransCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x000F7738 File Offset: 0x000F5B38
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

		// Token: 0x04000987 RID: 2439
		private object[] results;
	}
}
