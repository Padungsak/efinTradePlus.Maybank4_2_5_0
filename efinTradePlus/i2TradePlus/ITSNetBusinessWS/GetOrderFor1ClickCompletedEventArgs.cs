using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200016B RID: 363
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class GetOrderFor1ClickCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x000F7D4C File Offset: 0x000F614C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetOrderFor1ClickCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x000F7D78 File Offset: 0x000F6178
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

		// Token: 0x04000997 RID: 2455
		private object[] results;
	}
}
