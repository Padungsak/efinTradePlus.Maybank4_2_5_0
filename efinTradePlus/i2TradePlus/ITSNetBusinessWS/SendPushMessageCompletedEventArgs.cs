using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000188 RID: 392
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class SendPushMessageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600115A RID: 4442 RVA: 0x000F82C4 File Offset: 0x000F66C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendPushMessageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x000F82F0 File Offset: 0x000F66F0
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

		// Token: 0x040009A5 RID: 2469
		private object[] results;
	}
}
