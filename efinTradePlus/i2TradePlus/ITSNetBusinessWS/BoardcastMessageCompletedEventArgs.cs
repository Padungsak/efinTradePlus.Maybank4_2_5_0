using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000186 RID: 390
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class BoardcastMessageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001154 RID: 4436 RVA: 0x000F8260 File Offset: 0x000F6660
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BoardcastMessageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x000F828C File Offset: 0x000F668C
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

		// Token: 0x040009A4 RID: 2468
		private object[] results;
	}
}
