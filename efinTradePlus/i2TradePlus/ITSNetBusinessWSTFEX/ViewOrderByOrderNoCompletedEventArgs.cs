using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200029A RID: 666
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class ViewOrderByOrderNoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600179C RID: 6044 RVA: 0x0014458C File Offset: 0x0014298C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderByOrderNoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x001445B8 File Offset: 0x001429B8
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

		// Token: 0x04000BF3 RID: 3059
		private object[] results;
	}
}
