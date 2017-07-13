using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001BC RID: 444
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class StockByPricePageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011F6 RID: 4598 RVA: 0x000F8CEC File Offset: 0x000F70EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StockByPricePageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x000F8D18 File Offset: 0x000F7118
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

		// Token: 0x040009BF RID: 2495
		private object[] results;
	}
}
