using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000129 RID: 297
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class SaveStockNicknameCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600103C RID: 4156 RVA: 0x000F7068 File Offset: 0x000F5468
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveStockNicknameCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x000F7094 File Offset: 0x000F5494
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

		// Token: 0x04000976 RID: 2422
		private object[] results;
	}
}
