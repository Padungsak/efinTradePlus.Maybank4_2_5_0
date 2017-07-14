using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001BA RID: 442
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class StockInPlayCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011F0 RID: 4592 RVA: 0x000F8C88 File Offset: 0x000F7088
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

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x000F8CB4 File Offset: 0x000F70B4
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

		// Token: 0x040009BE RID: 2494
		private object[] results;
	}
}
