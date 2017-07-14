using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200012F RID: 303
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class SaveStockNicknameExtraCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x000F7194 File Offset: 0x000F5594
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveStockNicknameExtraCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x000F71C0 File Offset: 0x000F55C0
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

		// Token: 0x04000979 RID: 2425
		private object[] results;
	}
}
