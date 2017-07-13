using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001D4 RID: 468
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class ViewCustomersInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600123E RID: 4670 RVA: 0x000F919C File Offset: 0x000F759C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomersInfoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000F91C8 File Offset: 0x000F75C8
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

		// Token: 0x040009CB RID: 2507
		private object[] results;
	}
}
