using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000167 RID: 359
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class NAVAdjustmentCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010F6 RID: 4342 RVA: 0x000F7C84 File Offset: 0x000F6084
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal NAVAdjustmentCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x000F7CB0 File Offset: 0x000F60B0
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

		// Token: 0x04000995 RID: 2453
		private object[] results;
	}
}
