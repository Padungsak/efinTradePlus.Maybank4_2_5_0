using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000165 RID: 357
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class NAVChartCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010F0 RID: 4336 RVA: 0x000F7C20 File Offset: 0x000F6020
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal NAVChartCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x000F7C4C File Offset: 0x000F604C
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

		// Token: 0x04000994 RID: 2452
		private object[] results;
	}
}
