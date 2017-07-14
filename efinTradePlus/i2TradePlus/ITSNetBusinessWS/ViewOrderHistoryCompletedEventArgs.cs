using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001CA RID: 458
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class ViewOrderHistoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x000F8FA8 File Offset: 0x000F73A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderHistoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000F8FD4 File Offset: 0x000F73D4
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

		// Token: 0x040009C6 RID: 2502
		private object[] results;
	}
}
