using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000127 RID: 295
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class LoadStockNicknameCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001036 RID: 4150 RVA: 0x000F7004 File Offset: 0x000F5404
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadStockNicknameCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x000F7030 File Offset: 0x000F5430
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

		// Token: 0x04000975 RID: 2421
		private object[] results;
	}
}
