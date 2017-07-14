using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000177 RID: 375
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class SendHeartBeat2CompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001126 RID: 4390 RVA: 0x000F7FA4 File Offset: 0x000F63A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendHeartBeat2CompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x000F7FD0 File Offset: 0x000F63D0
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

		// Token: 0x0400099D RID: 2461
		private object[] results;
	}
}
