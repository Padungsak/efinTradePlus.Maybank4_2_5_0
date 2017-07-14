using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000175 RID: 373
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class GetPortEquityCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001120 RID: 4384 RVA: 0x000F7F40 File Offset: 0x000F6340
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetPortEquityCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x000F7F6C File Offset: 0x000F636C
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

		// Token: 0x0400099C RID: 2460
		private object[] results;
	}
}
