using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000145 RID: 325
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class SendAutoTradeCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001090 RID: 4240 RVA: 0x000F75E0 File Offset: 0x000F59E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendAutoTradeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000F760C File Offset: 0x000F5A0C
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

		// Token: 0x04000984 RID: 2436
		private object[] results;
	}
}
