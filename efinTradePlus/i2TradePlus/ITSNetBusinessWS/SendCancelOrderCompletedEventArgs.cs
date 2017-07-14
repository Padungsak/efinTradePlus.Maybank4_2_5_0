using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000113 RID: 275
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class SendCancelOrderCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06000FFA RID: 4090 RVA: 0x000F6C1C File Offset: 0x000F501C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendCancelOrderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x000F6C48 File Offset: 0x000F5048
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

		// Token: 0x0400096B RID: 2411
		private object[] results;
	}
}
