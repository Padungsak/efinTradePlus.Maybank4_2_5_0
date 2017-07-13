using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000135 RID: 309
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class IntradayIndexChartCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x000F72C0 File Offset: 0x000F56C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IntradayIndexChartCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x000F72EC File Offset: 0x000F56EC
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

		// Token: 0x0400097C RID: 2428
		private object[] results;
	}
}
