using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000115 RID: 277
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SendEditOrderCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001000 RID: 4096 RVA: 0x000F6C80 File Offset: 0x000F5080
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendEditOrderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x000F6CAC File Offset: 0x000F50AC
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

		// Token: 0x0400096C RID: 2412
		private object[] results;
	}
}
