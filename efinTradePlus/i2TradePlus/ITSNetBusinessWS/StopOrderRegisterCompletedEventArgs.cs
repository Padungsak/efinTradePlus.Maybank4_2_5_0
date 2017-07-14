using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000147 RID: 327
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class StopOrderRegisterCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001096 RID: 4246 RVA: 0x000F7644 File Offset: 0x000F5A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StopOrderRegisterCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x000F7670 File Offset: 0x000F5A70
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

		// Token: 0x04000985 RID: 2437
		private object[] results;
	}
}
