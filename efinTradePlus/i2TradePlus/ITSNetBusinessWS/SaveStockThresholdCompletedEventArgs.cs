using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200021A RID: 538
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class SaveStockThresholdCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001312 RID: 4882 RVA: 0x000F9EE4 File Offset: 0x000F82E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveStockThresholdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x000F9F10 File Offset: 0x000F8310
		public bool Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (bool)this.results[0];
			}
		}

		// Token: 0x040009ED RID: 2541
		private object[] results;
	}
}
