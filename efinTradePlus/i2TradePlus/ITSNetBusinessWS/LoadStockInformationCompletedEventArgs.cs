using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200017E RID: 382
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class LoadStockInformationCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600113C RID: 4412 RVA: 0x000F80D0 File Offset: 0x000F64D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadStockInformationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x000F80FC File Offset: 0x000F64FC
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

		// Token: 0x040009A0 RID: 2464
		private object[] results;
	}
}
