using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000202 RID: 514
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetTunnelCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012C8 RID: 4808 RVA: 0x000F9A98 File Offset: 0x000F7E98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetTunnelCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x000F9AC4 File Offset: 0x000F7EC4
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

		// Token: 0x040009E2 RID: 2530
		private object[] results;
	}
}
