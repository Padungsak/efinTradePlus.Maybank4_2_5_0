using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000159 RID: 345
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetAlertLogCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010CC RID: 4300 RVA: 0x000F79C8 File Offset: 0x000F5DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetAlertLogCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x000F79F4 File Offset: 0x000F5DF4
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

		// Token: 0x0400098E RID: 2446
		private object[] results;
	}
}
