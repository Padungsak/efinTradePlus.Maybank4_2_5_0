using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000133 RID: 307
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class IntradayChartCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600105A RID: 4186 RVA: 0x000F725C File Offset: 0x000F565C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IntradayChartCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x000F7288 File Offset: 0x000F5688
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

		// Token: 0x0400097B RID: 2427
		private object[] results;
	}
}
