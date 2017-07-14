using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200010F RID: 271
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class SendNewOrderCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x000F6B54 File Offset: 0x000F4F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendNewOrderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x000F6B80 File Offset: 0x000F4F80
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

		// Token: 0x04000969 RID: 2409
		private object[] results;
	}
}
