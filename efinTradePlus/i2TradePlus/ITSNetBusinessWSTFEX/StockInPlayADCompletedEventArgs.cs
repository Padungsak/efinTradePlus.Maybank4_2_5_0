using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000292 RID: 658
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class StockInPlayADCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001784 RID: 6020 RVA: 0x001443FC File Offset: 0x001427FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StockInPlayADCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x00144428 File Offset: 0x00142828
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

		// Token: 0x04000BEF RID: 3055
		private object[] results;
	}
}
