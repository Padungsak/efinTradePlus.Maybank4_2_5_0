using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200015D RID: 349
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class VerifyAlertManagerCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010D8 RID: 4312 RVA: 0x000F7A90 File Offset: 0x000F5E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal VerifyAlertManagerCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x000F7ABC File Offset: 0x000F5EBC
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

		// Token: 0x04000990 RID: 2448
		private object[] results;
	}
}
