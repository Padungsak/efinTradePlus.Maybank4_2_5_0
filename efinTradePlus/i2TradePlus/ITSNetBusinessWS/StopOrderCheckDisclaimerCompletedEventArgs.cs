using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000149 RID: 329
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class StopOrderCheckDisclaimerCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600109C RID: 4252 RVA: 0x000F76A8 File Offset: 0x000F5AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StopOrderCheckDisclaimerCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x000F76D4 File Offset: 0x000F5AD4
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

		// Token: 0x04000986 RID: 2438
		private object[] results;
	}
}
