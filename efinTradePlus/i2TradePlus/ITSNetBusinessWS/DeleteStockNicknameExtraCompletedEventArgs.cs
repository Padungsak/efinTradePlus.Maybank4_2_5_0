using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000131 RID: 305
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class DeleteStockNicknameExtraCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001054 RID: 4180 RVA: 0x000F71F8 File Offset: 0x000F55F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DeleteStockNicknameExtraCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x000F7224 File Offset: 0x000F5624
		public bool Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (bool)this.results[0];
			}
		}

		// Token: 0x0400097A RID: 2426
		private object[] results;
	}
}
