using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001FA RID: 506
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class ViewOrderDealDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012B0 RID: 4784 RVA: 0x000F9908 File Offset: 0x000F7D08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderDealDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x000F9934 File Offset: 0x000F7D34
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

		// Token: 0x040009DE RID: 2526
		private object[] results;
	}
}
